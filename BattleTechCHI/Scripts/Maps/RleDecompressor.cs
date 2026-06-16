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
    /// Decomprime animazione ANM con XOR-delta RLE.
    /// Buffer 0x0F20 (3872) byte → 88×88 px dopo NibbleToPixels.
    /// Differenze da Format01:
    ///   - Output[N] ^= DataByte  (XOR delta, non sovrascrive)
    ///   - byte positivo = N byte letterali distinti (non ripetizioni)
    ///   - byte negativo = ripeti 1 byte -N volte
    ///   - 0x00 esteso: WORD little-endian = lunghezza
    /// </summary>
    public static byte[] DecompressAnimation(byte[] compressed, int startPos)
    {
        const int bufSize = 0x0F20; // 3872 = 88*88/2
        var output = new byte[bufSize];
        int srcIdx = startPos;
        int dstIdx = 0;

        while (dstIdx < bufSize && srcIdx < compressed.Length)
        {
            sbyte b = (sbyte)compressed[srcIdx++];
            int runLength;

            if (b == 0)
            {
                // Extended run: WORD little-endian, then 1 data byte
                if (srcIdx + 2 > compressed.Length) break;
                runLength = compressed[srcIdx] | (compressed[srcIdx + 1] << 8);
                srcIdx += 2;
            }
            else if (b < 0)
            {
                // Negative: repeat next byte -b times
                runLength = -b;
            }
            else
            {
                // Positive: read b distinct literal bytes
                runLength = b;
            }

            while (runLength > 0 && dstIdx < bufSize && srcIdx < compressed.Length)
            {
                byte data = compressed[srcIdx];
                output[dstIdx] ^= data; // XOR delta
                dstIdx++;
                runLength--;

                if (b > 0)
                {
                    // Literal: consume one byte per output
                    srcIdx++;
                }
                else
                {
                    // Repeat: keep using same byte
                    if (runLength > 0)
                        continue;
                    srcIdx++;
                }
            }
        }

        return output;
    }

    /// <summary>
    /// Decomprime TUTTI i frame di un file ANM.
    /// Header ANM=51 byte (0x00-0x32), dati da offset 0x33.
    /// Ogni frame = 0x0F20 byte nibble = 88×88 pixel.
    /// Il RLE è continuo (nessun separatore tra frame) — si legge finché
    /// il flusso RLE è esaurito, producendo frame di 0x0F20 byte ciascuno.
    /// I frame sono XOR-delta: ogni frame è XORato col precedente.
    /// </summary>
    public static List<byte[]> DecompressAnimationFrames(byte[] compressed)
    {
        const int bufSize = 0x0F20;
        const int headerSize = 0x33;
        var frames = new List<byte[]>();

        if (compressed.Length <= headerSize) return frames;

        // Check active flag
        if (compressed[0x32] == 0) return frames;

        var buffer = new byte[bufSize];
        int srcIdx = headerSize;

        while (srcIdx < compressed.Length)
        {
            int prevSrcIdx = srcIdx;
            int dstIdx = 0;
            Buffer.BlockCopy(buffer, 0, buffer, 0, bufSize); // reset to current base

            while (dstIdx < bufSize && srcIdx < compressed.Length)
            {
                sbyte b = (sbyte)compressed[srcIdx++];
                int runLength;

                if (b == 0)
                {
                    if (srcIdx + 2 > compressed.Length) break;
                    runLength = compressed[srcIdx] | (compressed[srcIdx + 1] << 8);
                    srcIdx += 2;
                }
                else if (b < 0)
                {
                    runLength = -b;
                }
                else
                {
                    runLength = b;
                }

                while (runLength > 0 && dstIdx < bufSize && srcIdx < compressed.Length)
                {
                    byte data = compressed[srcIdx];
                    buffer[dstIdx] ^= data;
                    dstIdx++;
                    runLength--;

                    if (b > 0)
                        srcIdx++;
                    else if (runLength == 0)
                        srcIdx++;
                }
            }

            if (dstIdx == 0) break; // no progress → done

            var frame = new byte[bufSize];
            Buffer.BlockCopy(buffer, 0, frame, 0, bufSize);
            frames.Add(frame);
        }

        return frames;
    }

    /// <summary>
    /// Crea una texture atlas orizzontale da tutti i frame ANM.
    /// </summary>
    public static Image? AnmFramesToImage(List<byte[]> frames, int frameW = 88, int frameH = 88)
    {
        if (frames.Count == 0) return null;

        int sheetW = frameW * frames.Count;
        int sheetH = frameH;

        var sheet = Image.CreateEmpty(sheetW, sheetH, false, Image.Format.Rgba8);

        for (int f = 0; f < frames.Count; f++)
        {
            var pixels = NibbleToPixels(frames[f], frameW, frameH);
            var frameImg = PixelsToImage(pixels, frameW, frameH);
            if (frameImg == null) continue;

            sheet.BlitRect(frameImg, new Rect2I(0, 0, frameW, frameH), new Vector2I(f * frameW, 0));
        }

        return sheet;
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