namespace BattleTechCHI.Combat;

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
    public const int MaxAmmoBins = 10;
    public const int NumHitLocations = 11;
    public const int MaxHeat = 30;
}

public enum ActionCode
{
    None = 0,
    ShortRange = 1,
    MediumRange = 2,
    LongRange = 3,
    NoAction = 4
}

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

/// <summary>Hit locations (11 body parts per BT mech).</summary>
public enum HitLocation : byte
{
    LeftArm = 0,
    LeftLeg = 1,
    LeftTorso = 2,
    Head = 3,
    CenterTorso = 4,
    RightArm = 5,
    RightLeg = 6,
    RightTorso = 7,
    CenterTorsoRear = 8,
    LeftTorsoRear = 9,
    RightTorsoRear = 10
}

/// <summary>Ammo bin: tracks weapon type and remaining shots.</summary>
public struct AmmoBin
{
    public int WeaponId;
    public int Remaining;
    public int MaxCapacity;
}

/// <summary>Full per-unit mech/infantry state for combat.</summary>
public class MechState
{
    public int SlotId;
    public int MechId;
    public int Team;
    public int UnitX, UnitY;
    public bool Alive;

    public int HeatPool;
    public int HeatPenalty;

    public AmmoBin[] Ammo = Array.Empty<AmmoBin>();
    public int[] CurrentArmour = Array.Empty<int>();
    public int[] MaxArmour = Array.Empty<int>();
    public int[] CurrentStructure = Array.Empty<int>();
    public int[] MaxStructure = Array.Empty<int>();
    public byte[] CriticalFlags = Array.Empty<byte>();

    public byte StoryStateByte;
    public byte StorySkill24;
    public byte StorySkill25;
    public int InfantryEquipment;
    public int InfantryBurstCount;
    public bool IsTrainingDummy;

    public void Init(int slot, int team, bool isMech)
    {
        SlotId = slot;
        Team = team;
        Alive = true;
        UnitX = 0; UnitY = 0;
        HeatPool = 0; HeatPenalty = 0;
        IsTrainingDummy = false;
        InfantryBurstCount = 0;
        InfantryEquipment = 0;

        if (isMech)
        {
            Ammo = new AmmoBin[CombatConstants.MaxAmmoBins];
            CurrentArmour = new int[CombatConstants.NumHitLocations];
            MaxArmour = new int[CombatConstants.NumHitLocations];
            CurrentStructure = new int[CombatConstants.NumHitLocations];
            MaxStructure = new int[CombatConstants.NumHitLocations];
            CriticalFlags = new byte[CombatConstants.NumHitLocations];
            for (int i = 0; i < CombatConstants.NumHitLocations; i++)
            {
                CurrentStructure[i] = 5;
                MaxStructure[i] = 5;
            }
        }
    }

    public bool IsMech => Ammo.Length > 0;
}
