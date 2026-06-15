using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.Combat;

public partial class CombatManager
{
    public CombatState State { get; }
    public bool CombatActive => State.Active;

    private byte[] _tileProperties = Array.Empty<byte>();
    private byte _skillGate;
    private Action? _onComplete;

    // Melee range for physical attacks
    private const int MeleeRange = 1;
    private const int ShortRangeMax = 3;
    private const int MediumRangeMax = 6;
    private const int LongRangeMax = 10;

    // 3 fixed enemy mech templates
    private static readonly int[] EnemyMechTemplateIds = { 0x00, 0x01, 0x02 };

    public CombatManager(GameState gameState)
    {
        State = new CombatState(gameState);
    }

    // ─── COMBAT INIT ───

    public void StartCombat(Action? onComplete = null)
    {
        GD.Print("CombatManager: starting combat encounter");

        _onComplete = onComplete;
        State.Active = true;
        State.Phase = CombatPhase.Init;
        State.StageCounter = 0;
        State.SavedCursorX = State.GameState.CursorX;
        State.SavedCursorY = State.GameState.CursorY;
        State.InitFogGrids();

        PopulateEnemies();
        InitPlayerUnits();

        State.Phase = CombatPhase.UnitLoop;
        State.CurrentUnit = 0;

        GD.Print($"  {CountAlivePlayers()} player units, {CountAliveEnemies()} enemy units");
    }

    private void PopulateEnemies()
    {
        int templateIdx = CombatResolver.RngByte() % 3;
        LoadMechTemplate(12, EnemyMechTemplateIds[templateIdx]);

        for (int i = 4; i <= 11; i++)
        {
            State.Units[i].Init(i, 1, false);
            State.UnitActive[i] = true;
            int equipIdx = CombatResolver.RngByte() & 0x03;
            State.Units[i].InfantryEquipment = equipIdx;
            State.Units[i].UnitX = 18 + (i - 4) * 2;
            State.Units[i].UnitY = 5;
        }

        // Fill remaining enemy mech slots
        for (int i = 13; i <= 17; i++)
        {
            int tIdx = CombatResolver.RngByte() % 3;
            LoadMechTemplate(i, EnemyMechTemplateIds[tIdx]);
            State.Units[i].UnitX = 16 + (i - 12) * 2;
            State.Units[i].UnitY = 3 + (i - 12);
        }
    }

    private void LoadMechTemplate(int slot, int mechId)
    {
        var unit = State.Units[slot];
        unit.Init(slot, 1, true);
        unit.MechId = mechId;

        // Default armour/structure values based on tonnage
        int tonnage = mechId switch
        {
            0x00 => 20,  // Locust
            0x01 => 20,  // Wasp
            0x02 => 20,  // Stinger
            0x03 => 25,  // Commando
            0x06 => 30,  // Urbanmech
            0x09 => 35,  // Jenner
            0xC8 => 50,  // Chameleon
            _ => 20
        };

        int baseArmour = tonnage * 2;
        int baseStructure = tonnage / 5;

        for (int i = 0; i < CombatConstants.NumHitLocations; i++)
        {
            unit.MaxArmour[i] = baseArmour / CombatConstants.NumHitLocations;
            unit.CurrentArmour[i] = unit.MaxArmour[i];
            unit.MaxStructure[i] = baseStructure;
            unit.CurrentStructure[i] = baseStructure;
        }

        // Give default ammo
        unit.Ammo[0] = new AmmoBin { WeaponId = 3, Remaining = 10, MaxCapacity = 10 };  // Medium Laser
        unit.Ammo[1] = new AmmoBin { WeaponId = 9, Remaining = 8, MaxCapacity = 8 };     // SRM-2
        unit.Ammo[2] = new AmmoBin { WeaponId = 12, Remaining = 6, MaxCapacity = 6 };    // LRM-5

        State.UnitActive[slot] = true;
    }

    private void InitPlayerUnits()
    {
        for (int i = 0; i < 4; i++)
        {
            var unit = State.Units[i];
            unit.Init(i, 0, true);
            unit.MechId = 0xC8;  // Chameleon

            int baseArmour = 100;
            for (int j = 0; j < CombatConstants.NumHitLocations; j++)
            {
                unit.MaxArmour[j] = baseArmour / CombatConstants.NumHitLocations;
                unit.CurrentArmour[j] = unit.MaxArmour[j];
                unit.MaxStructure[j] = 10;
                unit.CurrentStructure[j] = 10;
            }

            unit.Ammo[0] = new AmmoBin { WeaponId = 3, Remaining = 20, MaxCapacity = 20 };
            unit.Ammo[1] = new AmmoBin { WeaponId = 8, Remaining = 15, MaxCapacity = 15 };
            unit.Ammo[2] = new AmmoBin { WeaponId = 11, Remaining = 10, MaxCapacity = 10 };

            unit.UnitX = 3 + i;
            unit.UnitY = 6;
            unit.StoryStateByte = 0;
            unit.StorySkill24 = 0;
            unit.StorySkill25 = 0;

            State.UnitActive[i] = true;
        }
    }

    // ─── MAIN LOOP ───

    public void ProcessTick()
    {
        if (!State.Active) return;

        switch (State.Phase)
        {
            case CombatPhase.Init: break;
            case CombatPhase.UnitLoop: ProcessUnitSlot(); break;
            case CombatPhase.Movement: ProcessMovement(); break;
            case CombatPhase.Targeting: ProcessTargeting(); break;
            case CombatPhase.ToHit: ProcessToHit(); break;
            case CombatPhase.Fire: ProcessFire(); break;
            case CombatPhase.PostFire: AdvanceToNextUnit(); break;
            case CombatPhase.HeatDissipation: EndRound(); break;
            case CombatPhase.Complete: break;
        }
    }

    // ─── UNIT LOOP ───

    private void ProcessUnitSlot()
    {
        int unit = State.CurrentUnit;
        if (unit >= 24)
        {
            State.Phase = CombatPhase.HeatDissipation;
            return;
        }

        if (!State.IsAlive(unit))
        {
            State.CurrentUnit++;
            return;
        }

        // Don't re-process while waiting for player input
        if (State.InputState != CombatInputState.Auto)
            return;

        GD.Print($"  Combat unit {unit} at ({State.Units[unit].UnitX},{State.Units[unit].UnitY})");

        if (State.IsPlayer(unit))
        {
            State.InputState = CombatInputState.WaitingForTarget;
            State.AddMessage($"Your turn: Unit {unit}");
            State.GameState.CursorX = State.Units[unit].UnitX;
            State.GameState.CursorY = State.Units[unit].UnitY;
            return;
        }

        ProcessEnemyUnit();
    }

    private void ProcessEnemyUnit()
    {
        int unit = State.CurrentUnit;
        int targetId = AiController.SelectTarget(State, unit, State.StageCounter);
        ActionCode action = AiController.GetActionCode(State, unit, targetId);

        State.CurrentTargetId = targetId;
        State.CurrentAction = action;

        if (targetId < 0 || action >= ActionCode.NoAction)
        {
            if (targetId < 0)
                GD.Print($"    no target → skip");
            else
                GD.Print($"    out of range → skip");
            State.CurrentUnit++;
            return;
        }

        State.WeaponIndex = AiController.SelectWeapon(State, unit, targetId);

        State.AddMessage($"Enemy Unit {unit} targets Unit {targetId} (action={action})");

        int dist = State.GetDistance(unit, targetId);
        if (dist > GetWeaponMaxRange(unit, State.WeaponIndex))
            State.Phase = CombatPhase.Movement;
        else
            State.Phase = CombatPhase.Targeting;
    }

    // ─── PLAYER INPUT ───

    public void MovePlayerCursor(int dx, int dy)
    {
        if (State.InputState != CombatInputState.WaitingForTarget &&
            State.InputState != CombatInputState.WaitingForWeapon)
            return;

        int newX = Mathf.Clamp(State.GameState.CursorX + dx, 0, 23);
        int newY = Mathf.Clamp(State.GameState.CursorY + dy, 0, 11);
        State.GameState.CursorX = newX;
        State.GameState.CursorY = newY;

        if (State.InputState == CombatInputState.WaitingForTarget)
            State.CurrentTargetId = GetTargetAtCursor();
    }

    public void SelectNextWeapon(int direction)
    {
        if (State.InputState != CombatInputState.WaitingForWeapon) return;
        int unit = State.CurrentUnit;
        int slot = State.SelectedWeaponSlot;
        int start = slot;
        do
        {
            slot += direction;
            if (slot < 0) slot = CombatConstants.MaxAmmoBins - 1;
            if (slot >= CombatConstants.MaxAmmoBins) slot = 0;
            if (slot == start) break;
        } while (State.Units[unit].Ammo[slot].WeaponId <= 0);
        State.SelectedWeaponSlot = slot;
    }

    public void ConfirmPlayerAction()
    {
        int unit = State.CurrentUnit;

        if (State.InputState == CombatInputState.WaitingForTarget)
        {
            int targetId = GetTargetAtCursor();
            if (targetId < 0)
            {
                State.AddMessage("No target at cursor position!");
                return;
            }
            State.CurrentTargetId = targetId;
            State.CurrentAction = AiController.GetActionCode(State, unit, targetId);
            if (State.CurrentAction >= ActionCode.NoAction)
            {
                State.AddMessage("Target out of range!");
                return;
            }
            State.InputState = CombatInputState.WaitingForWeapon;
            State.SelectedWeaponSlot = AiController.SelectWeapon(State, unit, targetId);
            State.AddMessage($"Target locked: Unit {targetId}");
        }
        else if (State.InputState == CombatInputState.WaitingForWeapon)
        {
            State.WeaponIndex = State.SelectedWeaponSlot;
            int weaponId = State.Units[unit].Ammo[State.WeaponIndex].WeaponId;
            string wName = weaponId >= 1 && weaponId <= WeaponData.Weapons.Length
                ? WeaponData.Weapons[weaponId - 1].Name : $"WPN{weaponId}";
            State.AddMessage($"Firing {wName} at Unit {State.CurrentTargetId}");

            int dist = State.GetDistance(unit, State.CurrentTargetId);
            if (dist > GetWeaponMaxRange(unit, State.WeaponIndex))
                State.Phase = CombatPhase.Movement;
            else
                State.Phase = CombatPhase.Targeting;

            State.InputState = CombatInputState.Auto;
        }
    }

    public void SelectWeaponByNumber(int num)
    {
        if (State.InputState != CombatInputState.WaitingForWeapon) return;
        int unit = State.CurrentUnit;
        int count = 0;
        for (int i = 0; i < CombatConstants.MaxAmmoBins; i++)
        {
            if (State.Units[unit].Ammo[i].WeaponId > 0)
            {
                if (count == num)
                {
                    State.SelectedWeaponSlot = i;
                    return;
                }
                count++;
            }
        }
    }

    public void CancelPlayerAction()
    {
        if (State.InputState == CombatInputState.WaitingForWeapon)
        {
            State.InputState = CombatInputState.WaitingForTarget;
            State.AddMessage("Select a new target");
        }
        else if (State.InputState == CombatInputState.WaitingForTarget)
        {
            State.AddMessage($"Unit {State.CurrentUnit} skips turn");
            State.InputState = CombatInputState.Auto;
            State.CurrentUnit++;
        }
    }

    private int GetWeaponMaxRange(int unitId, int weaponSlot)
    {
        if (weaponSlot < 0) return MeleeRange;
        var unit = State.Units[unitId];
        if (unit.Ammo == null || weaponSlot >= unit.Ammo.Length) return MeleeRange;
        int weaponId = unit.Ammo[weaponSlot].WeaponId;
        var weapons = WeaponData.Weapons;
        if (weaponId >= 1 && weaponId <= weapons.Length)
            return weapons[weaponId - 1].MaxRange;
        return MeleeRange;
    }

    private int GetTargetAtCursor()
    {
        int cx = State.GameState.CursorX;
        int cy = State.GameState.CursorY;
        for (int i = 4; i < 24; i++)
        {
            if (State.IsAlive(i) && State.Units[i].UnitX == cx && State.Units[i].UnitY == cy)
                return i;
        }
        return -1;
    }

    // ─── MOVEMENT ───

    private void ProcessMovement()
    {
        int unit = State.CurrentUnit;
        int target = State.CurrentTargetId;

        if (target < 0)
        {
            State.Phase = CombatPhase.Targeting;
            return;
        }

        var src = State.GetUnitPos(unit);
        var dst = State.GetUnitPos(target);
        int dist = State.GetDistance(unit, target);
        int weaponRange = GetWeaponMaxRange(unit, State.WeaponIndex);

        if (dist <= weaponRange)
        {
            State.Phase = CombatPhase.Targeting;
            return;
        }

        // Move 1 tile toward target
        Direction8 dir = CombatResolver.CalcMoveDirection(src.x, src.y, dst.x, dst.y);
        State.MoveDirection = dir;

        if (dir != Direction8.None)
        {
            var delta = Direction8Table.Deltas[(int)dir];
            int newX = State.Units[unit].UnitX + delta.dx;
            int newY = State.Units[unit].UnitY + delta.dy;

            // Bounds check
            if (newX >= 0 && newX < 24 && newY >= 0 && newY < 12)
            {
                // Check if target tile is occupied
                bool occupied = false;
                for (int i = 0; i < 24; i++)
                {
                    if (i != unit && State.IsAlive(i) &&
                        State.Units[i].UnitX == newX && State.Units[i].UnitY == newY)
                    {
                        occupied = true;
                        break;
                    }
                }

                if (!occupied)
                {
                    State.Units[unit].UnitX = newX;
                    State.Units[unit].UnitY = newY;
                    State.ClearFogForUnit(unit);
                    GD.Print($"    moved to ({newX},{newY})");
                }
            }
        }

        State.Phase = CombatPhase.Targeting;
    }

    // ─── TARGETING / LOS ───

    private void ProcessTargeting()
    {
        int unit = State.CurrentUnit;
        int target = State.CurrentTargetId;

        if (target < 0)
        {
            State.Phase = CombatPhase.ToHit;
            return;
        }

        // Training dummy (ID 0xD) is always targetable
        if (State.Units[target].IsTrainingDummy)
        {
            State.Phase = CombatPhase.ToHit;
            return;
        }

        var src = State.GetUnitPos(unit);
        var dst = State.GetUnitPos(target);

        bool losClear = CombatResolver.CheckLoS(src.x, src.y, dst.x, dst.y, _tileProperties, _skillGate);
        if (!losClear)
        {
            GD.Print($"    LoS blocked");
            AdvanceToNextUnit();
            return;
        }

        State.Phase = CombatPhase.ToHit;
    }

    // ─── TO-HIT ───

    private void ProcessToHit()
    {
        int unit = State.CurrentUnit;
        int target = State.CurrentTargetId;

        int skillMod = CombatResolver.ComputeSkillMod(State.Units[unit].StorySkill24, State.Units[unit].StorySkill25);
        int terrainMod = 0;
        int heatPenalty = CombatResolver.ComputeHeatPenalty(State.Units[unit].HeatPool);
        bool storyPenalty = State.Units[unit].StoryStateByte != 0;

        int weaponId = -1;
        if (State.WeaponIndex >= 0 && State.Units[unit].Ammo != null &&
            State.WeaponIndex < State.Units[unit].Ammo.Length)
        {
            weaponId = State.Units[unit].Ammo[State.WeaponIndex].WeaponId;
        }

        State.TargetNumber = CombatResolver.ComputeTargetNumber(
            State.CurrentAction, weaponId, skillMod, terrainMod, heatPenalty, storyPenalty);

        State.DiceRoll = CombatResolver.Roll2D6();
        State.HitResult = State.DiceRoll >= State.TargetNumber;

        GD.Print($"    TN={State.TargetNumber} roll={State.DiceRoll} {(State.HitResult ? "HIT" : "MISS")}");

        if (weaponId > 0)
            CombatResolver.AddWeaponHeat(State.Units[unit], weaponId);

        // Handle cluster weapons during to-hit
        if (State.HitResult && CombatResolver.IsClusterWeapon(weaponId))
        {
            int clusterSize = CombatResolver.GetClusterSize(weaponId);
            int hits = CombatResolver.RollClusterHits(clusterSize);
            int perMissileDamage = CombatResolver.GetWeaponDamage(weaponId);
            State.DamageDealt = perMissileDamage * hits;
            GD.Print($"    cluster: {hits} hits × {perMissileDamage} damage = {State.DamageDealt}");
        }
        else if (State.HitResult)
        {
            State.DamageDealt = CombatResolver.GetWeaponDamage(weaponId);
        }
        else
        {
            State.DamageDealt = 0;
        }

        State.Phase = CombatPhase.Fire;
    }

    // ─── FIRE / DAMAGE ───

    private void ProcessFire()
    {
        int target = State.CurrentTargetId;
        State.IsKillShot = false;

        if (!State.HitResult || target < 0 || State.DamageDealt <= 0)
        {
            State.Phase = CombatPhase.PostFire;
            return;
        }

        var targetUnit = State.Units[target];

        // Roll hit location
        State.HitLocation = CombatResolver.RollHitLocation();

        // Check critical
        State.CriticalMultiplier = CombatResolver.CheckCritical(State.DiceRoll);

        GD.Print($"    damage={State.DamageDealt} location={State.HitLocation} crit={State.CriticalMultiplier}");

        if (targetUnit.IsMech)
        {
            bool locDestroyed = CombatResolver.ApplyLocationDamage(targetUnit, State.HitLocation, State.DamageDealt);

            if (State.CriticalMultiplier > 0)
                CombatResolver.ApplyCriticalDamage(targetUnit, State.HitLocation, State.CriticalMultiplier);

            if (CombatResolver.IsMechDestroyed(targetUnit))
            {
                GD.Print($"    Unit {target} destroyed!");
                CombatResolver.ProcessKillChain(State, target);
                State.IsKillShot = true;
            }
        }
        else
        {
            // Infantry: simplified - one-shot kill
            CombatResolver.ProcessKillChain(State, target);
            State.IsKillShot = true;
        }

        // Decrement ammo
        DecrementAmmo(State.CurrentUnit, State.WeaponIndex);

        State.Phase = CombatPhase.PostFire;
    }

    private void DecrementAmmo(int unitId, int weaponSlot)
    {
        if (weaponSlot < 0) return;
        var unit = State.Units[unitId];
        if (unit.Ammo == null || weaponSlot >= unit.Ammo.Length) return;
        if (unit.Ammo[weaponSlot].Remaining > 0)
            unit.Ammo[weaponSlot].Remaining--;
    }

    // ─── ADVANCE ───

    private void AdvanceToNextUnit()
    {
        State.Phase = CombatPhase.UnitLoop;
        State.CurrentUnit++;
    }

    // ─── END ROUND ───

    private void EndRound()
    {
        GD.Print("CombatManager: end of round");

        for (int i = 0; i < 24; i++)
            if (State.IsAlive(i))
                CombatResolver.DissipateHeat(State.Units[i]);

        State.StageCounter++;

        if (!State.AnyEnemiesAlive())
        {
            GD.Print("  All enemies defeated!");
            EndCombat(victory: true);
            return;
        }

        if (!State.AnyPlayersAlive())
        {
            GD.Print("  All player units destroyed!");
            EndCombat(victory: false);
            return;
        }

        if (State.StageCounter > 20)
        {
            GD.Print("  Stage limit reached — ending combat");
            EndCombat(victory: false);
            return;
        }

        State.CurrentUnit = 0;
        State.Phase = CombatPhase.UnitLoop;
    }

    // ─── END COMBAT ───

    private void EndCombat(bool victory)
    {
        GD.Print($"CombatManager: combat ended (victory={victory})");

        State.Active = false;
        State.Phase = CombatPhase.Complete;

        // Apply story state updates post-combat
        if (victory)
        {
            State.GameState.StateArray[0x50] = 1;  // Training progress
            State.GameState.EncounterMask = 0x7F;  // Reduce encounter rate
        }

        State.GameState.Mode = GameMode.WorldMap;
        State.GameState.CursorX = State.SavedCursorX;
        State.GameState.CursorY = State.SavedCursorY;

        _onComplete?.Invoke();
    }

    // ─── HELPERS ───

    public void SetTileProperties(byte[] properties, byte skillGate)
    {
        _tileProperties = properties;
        _skillGate = skillGate;
    }

    public int CountAlivePlayers()
    {
        int count = 0;
        for (int i = 0; i < 4; i++)
            if (State.IsAlive(i)) count++;
        return count;
    }

    public int CountAliveEnemies()
    {
        int count = 0;
        for (int i = 4; i < 24; i++)
            if (State.IsAlive(i)) count++;
        return count;
    }
}
