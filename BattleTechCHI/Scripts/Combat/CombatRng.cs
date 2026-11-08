namespace BattleTechCHI.Combat;

/// <summary>
/// Exact port of the original's random-byte source (`19FC:0BC0`).
/// Single 3-byte state at main-DS `0x4FC0` (image default `04 03 02`);
/// no reseed path exists in either code dump — state is a pure function of
/// draw count since boot (live-verify: docs/t3-differential.md E1).
/// Single-bit rcl/rcr through carry; order matters. Preserves nothing —
/// callers rely on BX/CX/DX surviving (the original only clobbers AX).
/// </summary>
public static class CombatRng
{
    private static byte _s0 = 0x04, _s1 = 0x03, _s2 = 0x02;

    public static void SetState(byte s0, byte s1, byte s2)
    {
        _s0 = s0; _s1 = s1; _s2 = s2;
    }

    public static (byte S0, byte S1, byte S2) GetState() => (_s0, _s1, _s2);

    public static void ResetToImageDefault() => SetState(0x04, 0x03, 0x02);

    /// <summary>One `0BC0` step. Returns `(new s0) ^ s1`.</summary>
    public static byte NextByte()
    {
        int carry = (_s0 >> 1) & 1;
        int al = _s0 >> 2;
        // rcl s2,1
        int nc = (_s2 >> 7) & 1;
        _s2 = (byte)((( _s2 << 1) & 0xFF) | carry);
        carry = nc;
        // rcl s1,1
        nc = (_s1 >> 7) & 1;
        _s1 = (byte)((( _s1 << 1) & 0xFF) | carry);
        carry = nc;
        // cmc
        carry ^= 1;
        // sbb al, old s0
        al = (al - _s0 - carry) & 0xFF;
        int c = al & 1;
        al >>= 1;
        // rcr s0,1
        _s0 = (byte)((_s0 >> 1) | (c << 7));
        return (byte)(_s0 ^ _s1);
    }

    /// <summary>Single die (`017D:19F3`): `&amp; 7`, reject &gt; 5, +1. Rejected
    /// draws still advance state.</summary>
    public static int NextDie()
    {
        int v;
        do { v = NextByte() & 0x07; } while (v > 5);
        return v + 1;
    }

    /// <summary>2D6 (`017D:19DD`).</summary>
    public static int Roll2D6() => NextDie() + NextDie();
}
