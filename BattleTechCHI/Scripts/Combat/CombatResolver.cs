using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.Combat;

/// <summary>
/// Combat resolution systems: movement, LoS, to-hit, damage, heat.
/// Maps to segments 19EF (movement/fire) and 1000 (LoS/to-hit).
/// </summary>
public static class CombatResolver
{
    // ─── RNG: 24-bit LFSR variant (unknown_19EF_0BC0_1AAB0) ───
    private static uint _rngState = 0x4FC0;

    /// <summary>Step the LFSR and return a random byte.</summary>
    public static byte RngByte()
    {
        // LFSR: SHR, RCL, RCL, CMC, SBB, SHR, RCR, XOR on 3-byte state
        uint carry = (_rngState >> 16) & 1;
        _rngState = (_rngState << 1) | carry;
        if (carry != 0)
            _rngState ^= 0x1021;  // poly
        return (byte)(_rngState & 0xFF);
    }

    /// <summary>2D6 roll via rejection-sampled RNG (ghidra_guess_0000_30DD_030DD).</summary>
    public static int Roll2D6()
    {
        int d1 = RngDie();
        int d2 = RngDie();
        return d1 + d2;
    }

    private static int RngDie()
    {
        // Rejection-sampled: RNG & 0x7, retry if > 5, then INC → 1-6
        int val;
        do { val = RngByte() & 0x07; } while (val > 5);
        return val + 1;
    }

    // ─── MOVEMENT PHASE (unknown_19EF_0971_1A861) ───

    /// <summary>
    /// Calculate movement direction from source to destination.
    /// Uses binary search on slope ratios for 16/32-way angle refinement.
    /// </summary>
    public static Direction8 CalcMoveDirection(int srcX, int srcY, int dstX, int dstY)
    {
        int dx = dstX - srcX;
        int dy = srcY - dstY;  // Y inverted

        if (dx == 0 && dy == 0)
            return Direction8.None;

        // Approximate angle to nearest 8-direction
        double angle = Math.Atan2(dy, dx) * 4.0 / Math.PI;
        int octant = ((int)Math.Round(angle) + 8) % 8;
        return (Direction8)octant;
    }

    // ─── LINE OF SIGHT (ghidra_guess_1000_160E_1160E) ───

    /// <summary>
    /// Bresenham-style ray-cast from (ax,ay) to (bx,by).
    /// Checks tile property at +0x7AD against skill threshold.
    /// Returns true if LoS is clear.
    /// </summary>
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
            // Check tile at current position
            int tileIdx = y * 24 + x;
            if (tileIdx >= 0 && tileIdx < tileProperties.Length)
            {
                if (tileProperties[tileIdx] >= skillGate)
                    return false;  // blocked
            }

            if (x == bx && y == by)
                return true;  // reached target

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

    // ─── TO-HIT FORMULA ───

    /// <summary>
    /// Compute target number for to-hit roll.
    /// TN = actionCode * 2 + 4 + skill + terrain + heat + story.
    /// </summary>
    public static int ComputeTargetNumber(
        ActionCode actionCode,
        int weaponId,
        int skillMod,
        int terrainMod,
        int heatPenalty,
        bool storyPenalty)
    {
        int tn;

        if (weaponId == 33)  // Kick (physical)
            tn = 3;
        else
            tn = (int)actionCode * 2 + 4;

        tn += skillMod;        // popcount(byte0x24 & 0x07) + popcount(byte0x25 & 0x07)
        tn += terrainMod;      // sign_extend(tileProperty) + 1
        tn += heatPenalty;     // thresholds 8/13/17/24 → +1 each (max +4)
        if (storyPenalty)
            tn += 2;           // state byte b0057 != 0

        return tn;
    }

    /// <summary>Compute heat penalty: thresholds at 8/13/17/24 → +1 each.</summary>
    public static int ComputeHeatPenalty(int heatPool)
    {
        int penalty = 0;
        if (heatPool >= 8) penalty++;
        if (heatPool >= 13) penalty++;
        if (heatPool >= 17) penalty++;
        if (heatPool >= 24) penalty++;
        return Math.Min(penalty, 4);
    }

    /// <summary>Compute skill modifier from story state bytes.</summary>
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

    // ─── HEAT SYSTEM (ghidra_guess_1000_0673_10673) ───

    /// <summary>Add weapon heat to unit's heat pool.</summary>
    public static void AddWeaponHeat(MechState unit, int weaponId)
    {
        var weapons = WeaponData.Weapons;
        if (weaponId >= 1 && weaponId <= weapons.Length)
            unit.HeatPool += weapons[weaponId - 1].HeatGenerated;
    }

    /// <summary>End-of-round heat dissipation.</summary>
    public static void DissipateHeat(MechState unit)
    {
        // Player: heat pool (0x92) copied to penalty accumulator (0x6E), then reset
        unit.HeatPenalty = ComputeHeatPenalty(unit.HeatPool);
        unit.HeatPool = 0;
    }

    // ─── DAMAGE ───

    /// <summary>Apply damage from a weapon hit to target unit.</summary>
    public static int ApplyDamage(int weaponId)
    {
        var weapons = WeaponData.Weapons;
        if (weaponId >= 1 && weaponId <= weapons.Length)
            return weapons[weaponId - 1].Damage;
        return 0;
    }

    /// <summary>Determine hit location using RNG (50/50 variance).</summary>
    public static int RollHitLocation()
    {
        // 2-entry table, selected via RNG & 0x8
        return (RngByte() & 0x08) == 0 ? 0 : 1;
    }

    /// <summary>Critical hit check: 2D6 ≥ 8, multiplier = (roll-8)/2+1.</summary>
    public static int CheckCritical(int roll)
    {
        if (roll >= 8)
            return (roll - 8) / 2 + 1;
        return 0;
    }
}
