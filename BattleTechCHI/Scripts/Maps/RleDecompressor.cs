using Godot;

namespace BattleTechCHI.Maps;

/// <summary>
/// Decompressione RLE per file .CMP, .ICN e .ANM del gioco originale.
/// Formato 01: RLE + row-major (full-screen come BTTITLE, INFOCOM, ENDMECH)
/// Formato 02: RLE + column-major (sprite sheet come MECHSHAP, tile set come BTBORDER)
/// </summary>
public static class RleDecompressor
{
    /// <summary>
    /// Decomprime formato 01: RLE row-major. Output 32000 byte = 320×200 nibble.
    /// </summary>
    public static byte[] DecompressFormat01(byte[] compressed, int startPos)
    {
        var output = new byte[32000]; // 320×200, 4-bit per pixel
        int srcIdx = startPos;
        int dstIdx = 0;

        while (dstIdx < output.Length && srcIdx < compressed.Length)
        {
            byte b = compressed[srcIdx++];
            int runLength;

            if (b == 0)
            {
                // Extended run: next 2 byte = 16-bit length, then 1 data byte
                if (srcIdx + 2 >= compressed.Length) break;
                runLength = (compressed[srcIdx] << 8) | compressed[srcIdx + 1];
                srcIdx += 2;
                if (srcIdx >= compressed.Length) break;
                byte data = compressed[srcIdx++];
                int end = Math.Min(dstIdx + runLength, output.Length);
                while (dstIdx < end)
                    output[dstIdx++] = data;
            }
            else
            {
                // Literal run: byte value = run length
                if (srcIdx >= compressed.Length) break;
                byte data = compressed[srcIdx++];
                int end = Math.Min(dstIdx + b, output.Length);
                while (dstIdx < end)
                    output[dstIdx++] = data;
            }
        }

        return output;
    }

    /// <summary>
    /// Decomprime formato 02: RLE column-major. Output 32000 byte = 320×200 nibble.
    /// </summary>
    public static byte[] DecompressFormat02(byte[] compressed, int startPos)
    {
        var linear = DecompressFormat01(compressed, startPos);
        var output = new byte[32000];

        // Column-major → row-major: transpose 320×200
        for (int y = 0; y < 200; y++)
        {
            for (int x = 0; x < 320; x++)
            {
                output[y * 320 + x] = linear[x * 200 + y];
            }
        }

        return output;
    }

    /// <summary>
    /// Decomprime animazione ANM. Stesso formato 01 ma con header 0x33 byte.
    /// </summary>
    public static byte[] DecompressAnimation(byte[] compressed, int startPos)
    {
        return DecompressFormat01(compressed, startPos);
    }

    /// <summary>
    /// Converte da formato nibble (4-bit) a pixel (8-bit) con palette EGA mapping.
    /// Ogni byte in input contiene due nibble: high nibble = pixel sinistro, low = destro.
    /// </summary>
    public static byte[] NibbleToPixels(byte[] nibbleData, int width, int height)
    {
        int pixelCount = width * height;
        var pixels = new byte[pixelCount];
        int nibbleIdx = 0;

        for (int i = 0; i < pixelCount && nibbleIdx < nibbleData.Length; i += 2)
        {
            byte pair = nibbleData[nibbleIdx++];
            pixels[i] = (byte)((pair >> 4) & 0x0F);      // High nibble = pixel sinistro
            if (i + 1 < pixelCount)
                pixels[i + 1] = (byte)(pair & 0x0F);     // Low nibble = pixel destro
        }

        return pixels;
    }

    /// <summary>
    /// Converte pixel EGA in texture Godot.
    /// </summary>
    public static Image? PixelsToImage(byte[] pixels, int width, int height, Color[]? palette = null)
    {
        palette ??= UI.EgaPalette.StandardPalette; // fallback direct, not via method
        var image = Image.CreateEmpty(width, height, false, Image.Format.Rgba8);
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                int idx = y * width + x;
                byte pixel = idx < pixels.Length ? pixels[idx] : (byte)0;
                var color = (pixel < palette.Length) ? palette[pixel] : Colors.Black;
                image.SetPixel(x, y, color);
            }
        }
        return image;
    }
}