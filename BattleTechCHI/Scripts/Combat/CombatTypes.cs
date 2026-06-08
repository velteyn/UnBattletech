namespace BattleTechCHI.Combat;

/// <summary>Maximum unit slots in combat (0-23).</summary>
public static class CombatConstants
{
    public const int MaxUnits = 24;
    public const int PlayerLanceStart = 0;
    public const int PlayerLanceEnd = 3;
    public const int EnemyInfantryStart = 4;
    public const int EnemyInfantryEnd = 11;
    public const int EnemyMechStart = 12;
    public const int EnemyMechEnd = 17;
    public const int MaxStagePhases = 12;
    public const int FogGridW = 24;
    public const int FogGridH = 12;
}

/// <summary>Action codes returned by state check.</summary>
public enum ActionCode
{
    None = 0,
    ShortRange = 1,
    MediumRange = 2,
    LongRange = 3,
    NoAction = 4
}

/// <summary>Combat sub-phase within the main loop.</summary>
public enum CombatPhase
{
    Init,
    UnitLoop,
    Movement,
    Targeting,
    ToHit,
    Fire,
    PostFire,
    HeatDissipation,
    Complete
}

/// <summary>8-way direction enum.</summary>
public enum Direction8 : byte
{
    E = 0, NE = 1, N = 2, NW = 3,
    W = 4, SW = 5, S = 6, SE = 7,
    None = 0xFF
}

public static class Direction8Table
{
    public static readonly (sbyte dx, sbyte dy)[] Deltas =
    {
        ( 1, 0),  // E
        ( 1,-1),  // NE
        ( 0,-1),  // N
        (-1,-1),  // NW
        (-1, 0),  // W
        (-1, 1),  // SW
        ( 0, 1),  // S
        ( 1, 1),  // SE
    };
}

/// <summary>Per-unit combat state (maps to 125-byte mech struct).</summary>
public struct MechState
{
    public int MechId;         // +0x7B  mech template ID
    public int Team;           // 0=player, 1=enemy
    public int UnitX, UnitY;   // position
    public bool Alive;         // status != 0

    public int HeatPool;       // accumulated heat this round
    public int HeatPenalty;    // heat penalty carry-over

    public int[] CurrentAmmo;  // per-weapon ammo (10 slots)

    public byte StoryStateByte; // b0057 / +0xC79B
    public byte StorySkill24;   // story state offset 0x24
    public byte StorySkill25;   // story state offset 0x25
}
