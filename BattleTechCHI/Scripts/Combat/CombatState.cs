using BattleTechCHI.Data;

namespace BattleTechCHI.Combat;

/// <summary>Holds all per-combat state: fog grids, combatants, phase tracking.</summary>
public class CombatState
{
    public GameState GameState { get; }
    public bool Active { get; set; }

    /// <summary>Twin 12×24 fog grids (288 bytes each). 0x02=fogged, 0x00=clear.</summary>
    public byte[,] FogGridA { get; } = new byte[12, 24];
    public byte[,] FogGridB { get; } = new byte[12, 24];

    /// <summary>24-bool per-unit external combatant state.</summary>
    public bool[] UnitActive { get; } = new bool[24];

    /// <summary>24 per-unit mech state structs.</summary>
    public MechState[] Units { get; } = new MechState[24];

    /// <summary>Current stage counter [BP-0x42], increments 0..0xB.</summary>
    public int StageCounter { get; set; }

    /// <summary>Current unit index being processed (0-23).</summary>
    public int CurrentUnit { get; set; }

    /// <summary>Action code returned by state check for current unit.</summary>
    public ActionCode CurrentAction { get; set; }

    /// <summary>Target ID for current unit (0xFF = none).</summary>
    public int CurrentTargetId { get; set; } = -1;

    /// <summary>Saved cursor position before combat started.</summary>
    public int SavedCursorX { get; set; }
    public int SavedCursorY { get; set; }

    /// <summary>Current combat phase.</summary>
    public CombatPhase Phase { get; set; } = CombatPhase.Init;

    /// <summary>Direction computed by movement phase.</summary>
    public Direction8 MoveDirection { get; set; } = Direction8.None;

    /// <summary>To-hit target number after all modifiers.</summary>
    public int TargetNumber { get; set; }
    /// <summary>2D6 roll result.</summary>
    public int DiceRoll { get; set; }
    /// <summary>True if the roll hit.</summary>
    public bool HitResult { get; set; }
    /// <summary>Weapon index used for this attack.</summary>
    public int WeaponIndex { get; set; }

    public CombatState(GameState gameState)
    {
        GameState = gameState;
        for (int i = 0; i < 24; i++)
            Units[i] = new MechState();
    }

    /// <summary>Initialize fog grids with all-fogged.</summary>
    public void InitFogGrids()
    {
        for (int y = 0; y < 12; y++)
            for (int x = 0; x < 24; x++)
            {
                FogGridA[y, x] = 0x02;
                FogGridB[y, x] = 0x02;
            }
    }

    /// <summary>Check if a unit slot is alive.</summary>
    public bool IsAlive(int slot) =>
        slot >= 0 && slot < 24 && UnitActive[slot];

    /// <summary>Get unit position.</summary>
    public (int x, int y) GetUnitPos(int slot) =>
        (Units[slot].UnitX, Units[slot].UnitY);

    /// <summary>Check if unit is player-controlled.</summary>
    public bool IsPlayer(int slot) =>
        slot >= CombatConstants.PlayerLanceStart &&
        slot <= CombatConstants.PlayerLanceEnd;

    /// <summary>Check if unit is enemy infantry.</summary>
    public bool IsEnemyInfantry(int slot) =>
        slot >= CombatConstants.EnemyInfantryStart &&
        slot <= CombatConstants.EnemyInfantryEnd;

    /// <summary>Check if unit is enemy mech.</summary>
    public bool IsEnemyMech(int slot) =>
        slot >= CombatConstants.EnemyMechStart &&
        slot <= CombatConstants.EnemyMechEnd;
}
