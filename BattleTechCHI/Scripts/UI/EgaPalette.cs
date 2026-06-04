using Godot;

namespace BattleTechCHI.UI;

/// <summary>
/// Sistema palette EGA 16-colori.
/// Ogni asset può avere la propria palette (BTTITLE, INFOCOM, ENDMECH hanno palette custom).
/// </summary>
public static class EgaPalette
{
    // Palette EGA standard: 16 colori
    private static readonly Color[] StandardPalette = new[]
    {
        new Color(0x00, 0x00, 0x00), // 0 Black
        new Color(0x00, 0x00, 0xAA), // 1 Blue
        new Color(0x00, 0xAA, 0x00), // 2 Green
        new Color(0x00, 0xAA, 0xAA), // 3 Cyan
        new Color(0xAA, 0x00, 0x00), // 4 Red
        new Color(0xAA, 0x00, 0xAA), // 5 Magenta
        new Color(0xAA, 0x55, 0x00), // 6 Brown
        new Color(0xAA, 0xAA, 0xAA), // 7 Light Gray
        new Color(0x55, 0x55, 0x55), // 8 Dark Gray
        new Color(0x55, 0x55, 0xFF), // 9 Light Blue
        new Color(0x55, 0xFF, 0x55), // 10 Light Green
        new Color(0x55, 0xFF, 0xFF), // 11 Light Cyan
        new Color(0xFF, 0x55, 0x55), // 12 Light Red
        new Color(0xFF, 0x55, 0xFF), // 13 Light Magenta
        new Color(0xFF, 0xFF, 0x55), // 14 Yellow
        new Color(0xFF, 0xFF, 0xFF), // 15 White
    };

    /// <summary>
    /// Palette per asset specifici (override di colore EGA).
    /// </summary>
    public static class CustomPalettes
    {
        // BTTITLE: palette index 1 diventa nero (invece di blue)
        public static Color[] Bttitle { get; } = SwapColor(StandardPalette, 1, new Color(0x00, 0x00, 0x00));

        // INFOCOM: index 9 = dark blue (shadow), index 5 = light blue (background)
        public static Color[] Infocom { get; } = ApplyOverrides(StandardPalette,
            (9, new Color(0x00, 0x00, 0xAA)),
            (5, new Color(0x55, 0x55, 0xFF)));

        // ENDMECH: index 1 = nero, index 13 = light blue, index 9 = dark blue
        public static Color[] Endmech { get; } = ApplyOverrides(StandardPalette,
            (1, new Color(0x00, 0x00, 0x00)),
            (13, new Color(0x55, 0x55, 0xFF)),
            (9, new Color(0x00, 0x00, 0xAA)));
    }

    /// <summary>
    /// Converte un nibble EGA (4-bit) in colore Godot usando la palette data.
    /// </summary>
    public static Color NibbleToColor(byte nibble, Color[]? palette = null)
    {
        palette ??= StandardPalette;
        int idx = nibble & 0x0F;
        return idx < palette.Length ? palette[idx] : Colors.Black;
    }

    /// <summary>
    /// Converte pixel EGA planari (4 byte, uno per piano) in colore.
    /// I piani sono: Blue=0, Green=1, Red=2, Intensity=3
    /// </summary>
    public static Color PlanarToColor(byte blue, byte green, byte red, byte intensity)
    {
        int idx = ((intensity & 1) << 3) | ((red & 1) << 2) | ((green & 1) << 1) | (blue & 1);
        return idx < StandardPalette.Length ? StandardPalette[idx] : Colors.Black;
    }

    private static Color[] SwapColor(Color[] source, int index, Color newColor)
    {
        var result = (Color[])source.Clone();
        result[index] = newColor;
        return result;
    }

    private static Color[] ApplyOverrides(Color[] source, params (int, Color)[] overrides)
    {
        var result = (Color[])source.Clone();
        foreach (var (idx, col) in overrides)
            if (idx >= 0 && idx < result.Length)
                result[idx] = col;
        return result;
    }
}