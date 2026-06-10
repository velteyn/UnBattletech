using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.Combat;

/// <summary>
/// Main combat loop and phase dispatch.
/// Maps to ghidra_guess_1000_458C_1458C + fn183B_000A.
///
/// Flow:
///   Init → UnitLoop (0..23) →
///     StateCheck → AITarget → Movement → LoS → ToHit → Fire → PostFire
///   → HeatDissipation → next round
/// </summary>
public partial class CombatManager
{
    public CombatState State { get; }
    public bool CombatActive => State.Active;

    // Tile property table for LoS blocking
    private byte[] _tileProperties = Array.Empty<byte>();
    private byte _skillGate;

    public CombatManager(GameState gameState)
    {
        State = new CombatState(gameState);
    }

    // ─── COMBAT INIT (fn183B_000A) ───

    /// <summary>
    /// Start a combat encounter. Called from GameLoop when entering combat mode.
    /// </summary>
    public void StartCombat(Action onComplete)
    {
        GD.Print("CombatManager: starting combat encounter");

        State.Active = true;
        State.Phase = CombatPhase.Init;
        State.StageCounter = 0;

        // Save cursor position
        State.SavedCursorX = State.GameState.CursorX;
        State.SavedCursorY = State.GameState.CursorY;

        // Initialize fog grids (all fogged)
        State.InitFogGrids();

        // Populate enemy units
        PopulateEnemies();

        // Position player units
        InitPlayerUnits();

        // Transition to main loop
        State.Phase = CombatPhase.UnitLoop;
        State.CurrentUnit = 0;
    }

    /// <summary>Populate enemy units from template table (fn0DAB_0D3D).</summary>
    private void PopulateEnemies()
    {
        // Enemy mechs: select from fixed 3-entry table via RNG % 3
        int templateIdx = CombatResolver.RngByte() % 3;
        LoadMechTemplate(12, templateIdx);

        // Enemy infantry: random equipment from 4-option table
        for (int i = 4; i <= 11; i++)
        {
            State.Units[i].Alive = true;
            State.UnitActive[i] = true;
            int equipIdx = CombatResolver.RngByte() & 0x03;
            State.Units[i].MechId = -1;  // infantry — no mech ID
            State.Units[i].Team = 1;

            // Position in a line across the map
            State.Units[i].UnitX = 18 + (i - 4) * 2;
            State.Units[i].UnitY = 5;
        }
    }

    /// <summary>Load a mech template into enemy slot.</summary>
    private void LoadMechTemplate(int slot, int templateIdx)
    {
        // 3 fixed templates: Locust(0x00), Wasp(0x01), Stinger(0x02) at 20t each
        int[] mechIds = { 0x00, 0x01, 0x02 };
        int mechId = mechIds[templateIdx];

        State.Units[slot].Alive = true;
        State.UnitActive[slot] = true;
        State.Units[slot].MechId = mechId;
        State.Units[slot].Team = 1;
        State.Units[slot].UnitX = 20;
        State.Units[slot].UnitY = 3 + templateIdx * 3;
    }

    /// <summary>Position player units at the start of combat.</summary>
    private void InitPlayerUnits()
    {
        for (int i = 0; i < 4; i++)
        {
            State.Units[i].Alive = true;
            State.UnitActive[i] = true;
            State.Units[i].MechId = 0xC8;  // Chameleon
            State.Units[i].Team = 0;
            State.Units[i].UnitX = 3 + i;
            State.Units[i].UnitY = 6;
            State.Units[i].CurrentAmmo = new int[10];
        }
    }

    // ─── MAIN COMBAT LOOP ───

    /// <summary>
    /// Process one tick of the combat state machine.
    /// Called each frame from GameLoop when in Combat mode.
    /// </summary>
    public void ProcessTick()
    {
        if (!State.Active) return;

        switch (State.Phase)
        {
            case CombatPhase.Init:
                break;

            case CombatPhase.UnitLoop:
                ProcessUnitSlot();
                break;

            case CombatPhase.Movement:
                ProcessMovement();
                break;

            case CombatPhase.Targeting:
                ProcessTargeting();
                break;

            case CombatPhase.ToHit:
                ProcessToHit();
                break;

            case CombatPhase.Fire:
                ProcessFire();
                break;

            case CombatPhase.PostFire:
                AdvanceToNextUnit();
                break;

            case CombatPhase.HeatDissipation:
                EndRound();
                break;

            case CombatPhase.Complete:
                break;
        }
    }

    // ─── UNIT LOOP ───

    private void ProcessUnitSlot()
    {
        int unit = State.CurrentUnit;

        // Check end of loop
        if (unit >= 24)
        {
            State.Phase = CombatPhase.HeatDissipation;
            return;
        }

        // Skip dead/inactive units
        if (!State.IsAlive(unit))
        {
            State.CurrentUnit++;
            return;
        }

        GD.Print($"  Combat unit {unit} at ({State.Units[unit].UnitX},{State.Units[unit].UnitY})");

        // Determine target
        int targetId = -1;
        ActionCode action;

        if (State.IsPlayer(unit))
        {
            // Player units use cursor position as target
            targetId = GetTargetAtCursor();
            action = AiController.GetActionCode(State, unit, targetId);
        }
        else
        {
            // AI target selection
            targetId = AiController.SelectTarget(
                State, unit, State.StageCounter);
            action = AiController.GetActionCode(State, unit, targetId);
        }

        State.CurrentTargetId = targetId;
        State.CurrentAction = action;

        if (targetId < 0 || action >= ActionCode.NoAction)
        {
            // No valid target — skip unit
            GD.Print($"    no target / out of range → skip");
            State.CurrentUnit++;
            return;
        }

        GD.Print($"    target={targetId} action={action}");

        // Select weapon
        State.WeaponIndex = AiController.SelectWeapon(
            State, unit, targetId);

        // Proceed to movement
        State.Phase = CombatPhase.Movement;
    }

    private int GetTargetAtCursor()
    {
        // Player targets whatever is under the cursor
        int cx = State.GameState.CursorX;
        int cy = State.GameState.CursorY;

        for (int i = 4; i < 24; i++)
        {
            if (State.IsAlive(i) &&
                State.Units[i].UnitX == cx &&
                State.Units[i].UnitY == cy)
                return i;
        }
        return -1;
    }

    // ─── MOVEMENT PHASE ───

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

        Direction8 dir = CombatResolver.CalcMoveDirection(
            src.x, src.y, dst.x, dst.y);

        State.MoveDirection = dir;

        // Apply movement: move 1 tile toward target
        if (dir != Direction8.None)
        {
            var delta = Direction8Table.Deltas[(int)dir];
            State.Units[unit].UnitX += delta.dx;
            State.Units[unit].UnitY += delta.dy;
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

        var src = State.GetUnitPos(unit);
        var dst = State.GetUnitPos(target);

        // LoS check
        bool losClear = CombatResolver.CheckLoS(
            src.x, src.y, dst.x, dst.y,
            _tileProperties, _skillGate);

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

        // Compute modifiers
        int skillMod = CombatResolver.ComputeSkillMod(
            State.Units[unit].StorySkill24,
            State.Units[unit].StorySkill25);

        int terrainMod = 0; // from tile property at 0x32C6 — TBD

        int heatPenalty = CombatResolver.ComputeHeatPenalty(
            State.Units[unit].HeatPool);

        bool storyPenalty = State.Units[unit].StoryStateByte != 0;

        int weaponId = -1;
        // Look up weapon ID from weapon index
        var weapons = WeaponData.Weapons;
        if (State.WeaponIndex >= 0 && State.WeaponIndex < 0xB)
        {
            int w = State.GameState.StateArray[0x18 + State.WeaponIndex];
            if (w >= 1 && w <= weapons.Length)
                weaponId = weapons[w - 1].Id;
        }

        State.TargetNumber = CombatResolver.ComputeTargetNumber(
            State.CurrentAction,
            weaponId,
            skillMod,
            terrainMod,
            heatPenalty,
            storyPenalty);

        // Roll 2D6
        State.DiceRoll = CombatResolver.Roll2D6();
        State.HitResult = State.DiceRoll >= State.TargetNumber;

        GD.Print($"    TN={State.TargetNumber} roll={State.DiceRoll} " +
                 (State.HitResult ? "HIT" : "MISS"));

        // Add weapon heat
        if (State.WeaponIndex >= 0)
        {
            int w = State.GameState.StateArray[0x18 + State.WeaponIndex];
            CombatResolver.AddWeaponHeat(State.Units[unit], w);
        }

        State.Phase = CombatPhase.Fire;
    }

    // ─── FIRE / DAMAGE ───

    private void ProcessFire()
    {
        if (!State.HitResult)
        {
            State.Phase = CombatPhase.PostFire;
            return;
        }

        int target = State.CurrentTargetId;
        if (target < 0)
        {
            State.Phase = CombatPhase.PostFire;
            return;
        }

        // Determine weapon damage
        int weaponId = -1;
        var weapons = WeaponData.Weapons;
        if (State.WeaponIndex >= 0 && State.WeaponIndex < 0xB)
        {
            int w = State.GameState.StateArray[0x18 + State.WeaponIndex];
            if (w >= 1 && w <= weapons.Length)
                weaponId = w;
        }

        int damage = weaponId > 0 ? CombatResolver.ApplyDamage(weaponId) : 0;

        // Decrement ammo
        if (State.Units[State.CurrentUnit].CurrentAmmo != null &&
            State.WeaponIndex < State.Units[State.CurrentUnit].CurrentAmmo.Length)
        {
            if (State.Units[State.CurrentUnit].CurrentAmmo[State.WeaponIndex] > 0)
                State.Units[State.CurrentUnit].CurrentAmmo[State.WeaponIndex]--;
        }

        // Hit location
        int hitLoc = CombatResolver.RollHitLocation();

        GD.Print($"    damage={damage} location={hitLoc}");

        // Critical check
        int critMul = CombatResolver.CheckCritical(State.DiceRoll);
        if (critMul > 0)
            GD.Print($"    CRITICAL! multiplier={critMul}");

        // Apply damage (simplified — mark target dead if damage > threshold)
        if (damage > 0)
        {
            // Simplified: record damage but don't implement full structure damage
            // In the original: damage is applied to mech struct body parts
            GD.Print($"    dealt {damage} damage to unit {target}");
        }

        State.Phase = CombatPhase.PostFire;
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

        // Heat dissipation
        for (int i = 0; i < 24; i++)
        {
            if (State.IsAlive(i))
                CombatResolver.DissipateHeat(State.Units[i]);
        }

        // Increment stage counter
        State.StageCounter++;

        // Check if combat should end
        bool enemiesDead = true;
        for (int i = 4; i < 24; i++)
        {
            if (State.IsAlive(i))
            {
                enemiesDead = false;
                break;
            }
        }

        if (enemiesDead || State.StageCounter > 20)
        {
            EndCombat();
            return;
        }

        // Start next round
        State.CurrentUnit = 0;
        State.Phase = CombatPhase.UnitLoop;
    }

    // ─── END COMBAT ───

    private void EndCombat()
    {
        GD.Print("CombatManager: combat ended");
        State.Active = false;
        State.Phase = CombatPhase.Complete;
        State.GameState.Mode = GameMode.WorldMap;

        // Restore cursor
        State.GameState.CursorX = State.SavedCursorX;
        State.GameState.CursorY = State.SavedCursorY;
    }

    // ─── PUBLIC HELPERS ───

    public void SetTileProperties(byte[] properties, byte skillGate)
    {
        _tileProperties = properties;
        _skillGate = skillGate;
    }
}
