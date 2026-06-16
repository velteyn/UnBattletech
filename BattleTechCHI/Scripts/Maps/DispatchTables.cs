using System.Collections.Generic;
using System.Linq;

namespace BattleTechCHI.Maps;

/// <summary>
/// Position interaction entry (33-entry table at DGROUP:0x21CE).
/// Maps world map tile positions to code terminal building interactions.
/// </summary>
public struct PositionInteractionEntry
{
    public int XStart;    // X coordinate lower bound (0x21CE)
    public int Y;         // Y coordinate (0x21F0)
    public int TextIndex; // Building text index (0x2212) → 0=RED, 1=BLUE, 2=YELLOW
    public bool Visited;  // Visited flag
}

/// <summary>
/// Animation dispatch entry (12-entry table at DGROUP:0x247A, runtime-populated).
/// Maps subtile coordinates to 3 animation parameters (tile frame indices).
/// </summary>
public struct AnimationDispatchEntry
{
    public int X;      // X coordinate even part (Field0)
    public int Y;      // Y coordinate (Field2)
    public int Param1; // Animation param 1 (Field4)
    public int Param2; // Animation param 2 (Field6)
    public int Param3; // Animation param 3 (Field8)
    public bool Active;
}

/// <summary>
/// 33-entry position interaction table — static building position data
/// extracted from DGROUP:0x21CE/0x21F0/0x2212. When the cursor moves over
/// one of these tiles (property 0xB6/0xB7), the game shows the code
/// terminal building name.
/// </summary>
public class PositionInteractionTable
{
    public const int EntryCount = 33;

    private readonly PositionInteractionEntry[] _entries;

    // Static data extracted from DGROUP:0x21CE (33 bytes, X coordinate starts)
    private static readonly byte[] XStarts =
    {
        0x13, 0x17, 0x5B, 0x63, 0x67, 0x7D, 0x6F, 0x13, 0x2B, 0x4B,
        0x59, 0x67, 0x75, 0x63, 0x73, 0x43, 0x47, 0x2B, 0x4F, 0x0D,
        0x03, 0x19, 0x29, 0x53, 0x63, 0x69, 0x7D, 0x43, 0x15, 0x77,
        0x03, 0x63, 0x55
    };

    // Static data extracted from DGROUP:0x21F0 (33 bytes, Y coordinates)
    private static readonly byte[] Ys =
    {
        0x73, 0x73, 0x7B, 0x7B, 0x7B, 0x75, 0x71, 0x5D, 0x61, 0x57,
        0x5D, 0x5D, 0x5B, 0x53, 0x4B, 0x4B, 0x4B, 0x03, 0x4B, 0x4F,
        0x43, 0x3B, 0x3D, 0x39, 0x31, 0x31, 0x1F, 0x29, 0x29, 0x03,
        0x31, 0x1B, 0x1B
    };

    // Static data extracted from DGROUP:0x2212 (33 bytes, text indices)
    private static readonly byte[] TextIndices =
    {
        0x00, 0x00, 0x01, 0x02, 0x02, 0x02, 0x01, 0x00, 0x01, 0x02,
        0x02, 0x01, 0x00, 0x01, 0x00, 0x02, 0x00, 0x02, 0x01, 0x00,
        0x02, 0x02, 0x01, 0x01, 0x00, 0x02, 0x01, 0x00, 0x00, 0x00,
        0x01, 0x02, 0x01
    };

    public PositionInteractionTable()
    {
        _entries = new PositionInteractionEntry[EntryCount];
        for (int i = 0; i < EntryCount; i++)
        {
            _entries[i] = new PositionInteractionEntry
            {
                XStart = XStarts[i],
                Y = Ys[i],
                TextIndex = TextIndices[i],
                Visited = false
            };
        }
    }

    /// <summary>
    /// Find entry by subtile coordinate. Matches original formula:
    /// (tileX+1)&0x7F >= xStart && (tileX+1)&0x7F < xStart + 3 && tileY == Y
    /// </summary>
    public int FindEntry(int subtileX, int subtileY)
    {
        int ax32 = (subtileX + 1) & 0x7F;
        int arg6 = subtileY & 0x7F;

        for (int i = 0; i < EntryCount; i++)
        {
            if (_entries[i].Y == arg6 && ax32 >= _entries[i].XStart && ax32 < _entries[i].XStart + 3)
                return i;
        }
        return -1;
    }

    public bool IsVisited(int index)
    {
        return index >= 0 && index < EntryCount && _entries[index].Visited;
    }

    public void MarkVisited(int index)
    {
        if (index >= 0 && index < EntryCount)
            _entries[index].Visited = true;
    }

    public PositionInteractionEntry GetEntry(int index)
    {
        return index >= 0 && index < EntryCount ? _entries[index] : default;
    }
}

/// <summary>
/// 12-entry animation dispatch table — maps subtile positions to
/// 3 animation parameters (tile frame cycling). Runtime-populated
/// shared memory region at DGROUP:0x247A.
/// </summary>
public class AnimationDispatchTable
{
    public const int EntryCount = 12;

    private readonly AnimationDispatchEntry[] _entries;

    /// <summary>
    /// The source tile animation frames written as 2×2 cycling tile blocks.
    /// Extracted from DGROUP:0x246E — Frame0={122,123,124,125},
    /// Frame1={118,119,120,121}, Frame2={116,0,1,117}.
    /// </summary>
    public static readonly byte[] TileAnimationFrames = { 0x7A, 0x7B, 0x7C, 0x7D, 0x76, 0x77, 0x78, 0x79, 0x74, 0x00, 0x01, 0x75 };

    public AnimationDispatchTable()
    {
        _entries = new AnimationDispatchEntry[EntryCount];
        for (int i = 0; i < EntryCount; i++)
            _entries[i] = new AnimationDispatchEntry { Active = false };
    }

    public void SetEntry(int index, int x, int y, int param1, int param2, int param3, bool active = true)
    {
        if (index < 0 || index >= EntryCount) return;
        _entries[index] = new AnimationDispatchEntry
        {
            X = x, Y = y, Param1 = param1, Param2 = param2, Param3 = param3, Active = active
        };
    }

    /// <summary>
    /// Search for matching entry. Original match:
    /// (arg2 & 0x7E) == Y && (arg4 & 0x7E) == X
    /// </summary>
    public int FindEntry(int subtileX, int subtileY)
    {
        int maskedX = (subtileX + 1) & 0x7F;
        int maskedY = subtileY & 0x7E;

        for (int i = 0; i < EntryCount; i++)
        {
            if (!_entries[i].Active) continue;
            if ((_entries[i].Y & 0x7E) == maskedY && (_entries[i].X & 0x7E) == (maskedX & 0x7E))
                return i;
        }
        return -1;
    }

    public AnimationDispatchEntry GetEntry(int index)
    {
        return index >= 0 && index < EntryCount ? _entries[index] : default;
    }

    public void Clear()
    {
        for (int i = 0; i < EntryCount; i++)
            _entries[i].Active = false;
    }

    /// <summary>
    /// Populate from tile coordinate arrays (converts tile → subtile).
    /// </summary>
    public void PopulateFromTiles(int[] tileXs, int[] tileYs, int param1, int param2, int param3)
    {
        int count = System.Math.Min(tileXs.Length, EntryCount);
        for (int i = 0; i < count; i++)
            SetEntry(i, tileXs[i] * 2, tileYs[i] * 2, param1, param2, param3);
    }
}
