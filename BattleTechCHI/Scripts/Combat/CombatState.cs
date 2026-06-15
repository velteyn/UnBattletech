using BattleTechCHI.Data;

namespace BattleTechCHI.Combat;

public class CombatState
{
    public GameState GameState { get; }
    public bool Active { get; set; }

    public byte[,] FogGridA { get; } = new byte[12, 24];
    public byte[,] FogGridB { get; } = new byte[12, 24];
    public bool[] UnitActive { get; } = new bool[24];
    public MechState[] Units { get; } = new MechState[24];

    public int StageCounter { get; set; }
    public int CurrentUnit { get; set; }
    public ActionCode CurrentAction { get; set; }
    public int CurrentTargetId { get; set; } = -1;

    public int SavedCursorX { get; set; }
    public int SavedCursorY { get; set; }

    public CombatPhase Phase { get; set; } = CombatPhase.Init;
    public Direction8 MoveDirection { get; set; } = Direction8.None;
    public int TargetNumber { get; set; }
    public int DiceRoll { get; set; }
    public bool HitResult { get; set; }
    public int WeaponIndex { get; set; }

    // Damage tracking for the current attack
    public int DamageDealt { get; set; }
    public HitLocation HitLocation { get; set; }
    public int CriticalMultiplier { get; set; }
    public bool IsKillShot { get; set; }

    // Kill chain phase tracking
    public int KillChainPhase { get; set; }
    public int KillChainTarget { get; set; } = -1;

    // Player input state
    public CombatInputState InputState { get; set; } = CombatInputState.Auto;
    public int SelectedWeaponSlot { get; set; } = -1;
    public System.Collections.Generic.List<string> Messages { get; } = new();

    public void AddMessage(string msg)
    {
        Messages.Add(msg);
        if (Messages.Count > 50)
            Messages.RemoveAt(0);
    }

    public CombatState(GameState gameState)
    {
        GameState = gameState;
        for (int i = 0; i < 24; i++)
            Units[i] = new MechState();
    }

    public void InitFogGrids()
    {
        for (int y = 0; y < 12; y++)
            for (int x = 0; x < 24; x++)
            {
                FogGridA[y, x] = 0x02;
                FogGridB[y, x] = 0x02;
            }
    }

    /// <summary>Clear fog for a unit's column on movement.</summary>
    public void ClearFogForUnit(int slot)
    {
        int x = Units[slot].UnitX;
        for (int y = 0; y < 12; y++)
        {
            if (x >= 0 && x < 24)
            {
                FogGridA[y, x] = 0x00;
                FogGridB[y, x] = 0x00;
            }
        }
    }

    /// <summary>Reset fog for a unit on death.</summary>
    public void ResetFogForUnit(int slot)
    {
        int x = Units[slot].UnitX;
        for (int y = 0; y < 12; y++)
        {
            if (x >= 0 && x < 24)
            {
                FogGridA[y, x] = 0x02;
                FogGridB[y, x] = 0x02;
            }
        }
    }

    public bool IsAlive(int slot) =>
        slot >= 0 && slot < 24 && UnitActive[slot];

    public (int x, int y) GetUnitPos(int slot) =>
        (Units[slot].UnitX, Units[slot].UnitY);

    public bool IsPlayer(int slot) =>
        slot >= CombatConstants.PlayerLanceStart &&
        slot <= CombatConstants.PlayerLanceEnd;

    public bool IsEnemyInfantry(int slot) =>
        slot >= CombatConstants.EnemyInfantryStart &&
        slot <= CombatConstants.EnemyInfantryEnd;

    public bool IsEnemyMech(int slot) =>
        slot >= CombatConstants.EnemyMechStart &&
        slot <= CombatConstants.EnemyMechEnd;

    /// <summary>Get distance in Chebyshev metric between two units.</summary>
    public int GetDistance(int a, int b)
    {
        int dx = Math.Abs(Units[a].UnitX - Units[b].UnitX);
        int dy = Math.Abs(Units[a].UnitY - Units[b].UnitY);
        return Math.Max(dx, dy);
    }

    /// <summary>Kill a unit: mark dead, reset fog column.</summary>
    public void KillUnit(int slot)
    {
        if (slot < 0 || slot >= 24) return;
        UnitActive[slot] = false;
        Units[slot].Alive = false;
        ResetFogForUnit(slot);
    }

    /// <summary>Check if any enemies remain alive.</summary>
    public bool AnyEnemiesAlive()
    {
        for (int i = CombatConstants.EnemyInfantryStart; i <= CombatConstants.EnemyMechEnd; i++)
            if (IsAlive(i)) return true;
        return false;
    }

    /// <summary>Check if any player units remain alive.</summary>
    public bool AnyPlayersAlive()
    {
        for (int i = CombatConstants.PlayerLanceStart; i <= CombatConstants.PlayerLanceEnd; i++)
            if (IsAlive(i)) return true;
        return false;
    }
}
