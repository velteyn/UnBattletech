using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.Combat;

public static class CombatResolver
{
    private static uint _rngState = 0x4FC0;

    public static byte RngByte()
    {
        uint carry = (_rngState >> 16) & 1;
        _rngState = (_rngState << 1) | carry;
        if (carry != 0)
            _rngState ^= 0x1021;
        return (byte)(_rngState & 0xFF);
    }

    public static int Roll2D6()
    {
        int d1 = RngDie();
        int d2 = RngDie();
        return d1 + d2;
    }

    private static int RngDie()
    {
        int val;
        do { val = RngByte() & 0x07; } while (val > 5);
        return val + 1;
    }

    // ─── MOVEMENT ───

    public static Direction8 CalcMoveDirection(int srcX, int srcY, int dstX, int dstY)
    {
        int dx = dstX - srcX;
        int dy = srcY - dstY;
        if (dx == 0 && dy == 0)
            return Direction8.None;
        double angle = Math.Atan2(dy, dx) * 4.0 / Math.PI;
        int octant = ((int)Math.Round(angle) + 8) % 8;
        return (Direction8)octant;
    }

    // ─── LINE OF SIGHT ───

    public static bool CheckLoS(int ax, int ay, int bx, int by, byte[] tileProperties, byte skillGate)
    {
        int dx = Math.Abs(bx - ax);
        int dy = -Math.Abs(by - ay);
        int sx = ax < bx ? 1 : -1;
        int sy = ay < by ? 1 : -1;
        int err = dx + dy;
        int x = ax, y = ay;
        while (true)
        {
            int tileIdx = y * 24 + x;
            if (tileIdx >= 0 && tileIdx < tileProperties.Length)
                if (tileProperties[tileIdx] >= skillGate)
                    return false;
            if (x == bx && y == by)
                return true;
            int e2 = 2 * err;
            if (e2 >= dy)
            {
                if (x == bx) return true;
                err += dy;
                x += sx;
            }
            if (e2 <= dx)
            {
                if (y == by) return true;
                err += dx;
                y += sy;
            }
        }
    }

    // ─── TO-HIT ───

    public static int ComputeTargetNumber(
        ActionCode actionCode, int weaponId, int skillMod,
        int terrainMod, int heatPenalty, bool storyPenalty)
    {
        int tn = weaponId == 33 ? 3 : (int)actionCode * 2 + 4;
        tn += skillMod;
        tn += terrainMod;
        tn += heatPenalty;
        if (storyPenalty) tn += 2;
        return tn;
    }

    public static int ComputeHeatPenalty(int heatPool)
    {
        int p = 0;
        if (heatPool >= 8) p++;
        if (heatPool >= 13) p++;
        if (heatPool >= 17) p++;
        if (heatPool >= 24) p++;
        return Math.Min(p, 4);
    }

    public static int ComputeSkillMod(byte byte24, byte byte25)
    {
        return PopCount((byte)(byte24 & 0x07)) + PopCount((byte)(byte25 & 0x07));
    }

    private static int PopCount(byte b)
    {
        int count = 0;
        for (int i = 0; i < 3; i++)
            if ((b & (1 << i)) == 0)
                count++;
        return count;
    }

    // ─── HEAT ───

    public static void AddWeaponHeat(MechState unit, int weaponId)
    {
        var weapons = WeaponData.Weapons;
        if (weaponId >= 1 && weaponId <= weapons.Length)
            unit.HeatPool += weapons[weaponId - 1].HeatGenerated;
    }

    /// <summary>End-of-round: player heat copied to penalty then pool reset; enemy pool never cleared.</summary>
    public static void DissipateHeat(MechState unit)
    {
        unit.HeatPenalty = ComputeHeatPenalty(unit.HeatPool);
        unit.HeatPool = 0;
    }

    // ─── HIT LOCATION ───

    private static readonly HitLocation[] FrontHitTable =
    {
        HitLocation.LeftArm, HitLocation.LeftLeg, HitLocation.LeftTorso,
        HitLocation.Head, HitLocation.CenterTorso, HitLocation.RightArm,
        HitLocation.RightLeg, HitLocation.RightTorso, HitLocation.CenterTorso,
        HitLocation.LeftTorso, HitLocation.RightTorso
    };

    public static HitLocation RollHitLocation()
    {
        int roll = RngByte() & 0x0A;  // 0, 2, 4, 6, 8, 10 (6 entries via 0x0A mask)
        int idx = roll / 2;
        if (idx >= FrontHitTable.Length) idx = FrontHitTable.Length - 1;
        return FrontHitTable[idx];
    }

    // ─── CRITICALS ───

    public static int CheckCritical(int roll)
    {
        if (roll >= 8)
            return (roll - 8) / 2 + 1;
        return 0;
    }

    /// <summary>Apply critical damage to a location's components.</summary>
    public static void ApplyCriticalDamage(MechState target, HitLocation loc, int multiplier)
    {
        if (!target.IsMech) return;
        int idx = (int)loc;
        if (idx < 0 || idx >= target.CriticalFlags.Length) return;
        target.CriticalFlags[idx] = (byte)Math.Min(target.CriticalFlags[idx] + multiplier, 3);
    }

    // ─── WEAPON LOOKUP ───

    public static int GetWeaponDamage(int weaponId)
    {
        var weapons = WeaponData.Weapons;
        if (weaponId >= 1 && weaponId <= weapons.Length)
            return weapons[weaponId - 1].Damage;
        return 0;
    }

    public static int GetWeaponHeat(int weaponId)
    {
        var weapons = WeaponData.Weapons;
        if (weaponId >= 1 && weaponId <= weapons.Length)
            return weapons[weaponId - 1].HeatGenerated;
        return 0;
    }

    /// <summary>Check if weapon is a cluster weapon (missile).</summary>
    public static bool IsClusterWeapon(int weaponId)
    {
        return weaponId switch
        {
            >= 9 and <= 11 => true,  // SRM-2/4/6
            >= 12 and <= 15 => true, // LRM-5/10/15/20
            >= 26 and <= 32 => true, // NPC missile variants
            _ => false
        };
    }

    /// <summary>Get cluster size (number of missiles) for a weapon ID.</summary>
    public static int GetClusterSize(int weaponId)
    {
        return weaponId switch
        {
            9 or 26 => 2,    // SRM-2
            10 or 27 => 4,   // SRM-4
            11 or 28 => 6,   // SRM-6
            12 or 29 => 5,   // LRM-5
            13 or 30 => 10,  // LRM-10
            14 or 31 => 15,  // LRM-15
            15 or 32 => 20,  // LRM-20
            _ => 1
        };
    }

    /// <summary>Roll cluster hits table: 2D6 roll × 7 + column → hits.</summary>
    public static int RollClusterHits(int clusterSize)
    {
        int roll = Roll2D6();
        int hits;
        if (clusterSize <= 4)
        {
            int[] table = { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4, 4 };
            hits = table[Math.Min(roll - 2, 10)];
        }
        else if (clusterSize <= 8)
        {
            int[] table = { 1, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8 };
            hits = table[Math.Min(roll - 2, 10)];
        }
        else if (clusterSize <= 12)
        {
            int[] table = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            hits = table[Math.Min(roll - 2, 10)];
        }
        else
        {
            int[] table = { 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 20 };
            hits = Math.Min(table[Math.Min(roll - 2, 10)], clusterSize);
        }
        return hits;
    }

    // ─── DAMAGE APPLICATION ───

    /// <summary>Apply damage to a mech at a hit location. Returns true if location destroyed.</summary>
    public static bool ApplyLocationDamage(MechState target, HitLocation loc, int damage)
    {
        if (!target.IsMech) return false;
        int idx = (int)loc;
        if (idx < 0 || idx >= target.CurrentArmour.Length) return false;

        int remaining = damage;

        // Apply armour first
        if (target.CurrentArmour[idx] > 0)
        {
            int armourDamage = Math.Min(remaining, target.CurrentArmour[idx]);
            target.CurrentArmour[idx] -= armourDamage;
            remaining -= armourDamage;
        }

        // Remaining damage goes to structure
        if (remaining > 0)
        {
            int structDamage = Math.Min(remaining, target.CurrentStructure[idx]);
            target.CurrentStructure[idx] -= structDamage;
            remaining -= structDamage;
        }

        return target.CurrentStructure[idx] <= 0;
    }

    /// <summary>Check if a mech is destroyed (all critical locations zero).</summary>
    public static bool IsMechDestroyed(MechState target)
    {
        if (!target.IsMech) return !target.Alive;
        return target.CurrentStructure[(int)HitLocation.CenterTorso] <= 0 ||
               target.CurrentStructure[(int)HitLocation.Head] <= 0;
    }

    /// <summary>Ammo explosion check: 2D6 >= 8, multiplier = (roll-8)/2+1.</summary>
    public static int CheckAmmoExplosion(int roll)
    {
        if (roll >= 8)
            return (roll - 8) / 2 + 1;
        return 0;
    }

    // ─── KILL CHAIN ───

    /// <summary>Process the 4-phase kill chain for a destroyed unit.</summary>
    public static void ProcessKillChain(CombatState state, int targetSlot)
    {
        if (targetSlot < 0 || targetSlot >= 24) return;
        var target = state.Units[targetSlot];

        // Phase 1: Mark combat slot with bit 7 (destroyed)
        state.KillUnit(targetSlot);

        // Phase 2: Overkill handling — zero all structure
        if (target.IsMech)
        {
            for (int i = 0; i < target.CurrentStructure.Length; i++)
                target.CurrentStructure[i] = 0;
        }

        // Phase 3: Clear fog for destroyed unit
        state.ResetFogForUnit(targetSlot);

        // Phase 4: Death message via GD.Print
        GD.Print($"  Unit {targetSlot} destroyed!");
    }
}
