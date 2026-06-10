using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.Maps;

/// <summary>
/// Carica e interpreta i file .MTP del gioco originale.
/// Supporta BlockFormat (MAP1-2, 11-14) e LinearFormat (MAP3-10, 15).
/// </summary>
public static class MapLoader
{
    /// <summary>
    /// Carica una mappa dal file .MTP originale.
    /// </summary>
    public static MapData? Load(string mtpPath, int mapId)
    {
        if (!File.Exists(mtpPath))
        {
            GD.PrintErr($"Map file not found: {mtpPath}");
            return null;
        }

        var bytes = File.ReadAllBytes(mtpPath);
        var data = new MapData { MapId = mapId };
        int pos = 0;

        // Header: 3 byte (sempre 0x01 0x01 0x01 per le mappe locali)
        byte h1 = bytes[pos++];
        byte h2 = bytes[pos++];
        byte h3 = bytes[pos++];

        data.Width = bytes[pos++];
        data.Height = bytes[pos++];

        // 0x80 byte nomi NPC (8 nomi null-terminated)
        var npcRaw = bytes.AsSpan(pos, 0x80);
        data.NpcNames = ParseNullTerminatedStrings(npcRaw, 8);
        pos += 0x80;

        // 0x100 byte nomi edifici (fino a stringa "MAP")
        var bldRaw = bytes.AsSpan(pos, 0x100);
        data.BuildingNames = ParseBuildingNames(bldRaw);
        pos += 0x100;

        // Variabili fisse (0x20 + 0x20 + 0x20 + 0x20 + 0x10 + 0x08 = 0x98 byte)
        var block0 = bytes.AsSpan(pos, 0x20); pos += 0x20;
        var block1 = bytes.AsSpan(pos, 0x20); pos += 0x20;
        var block2 = bytes.AsSpan(pos, 0x20); pos += 0x20;
        var block3 = bytes.AsSpan(pos, 0x20); pos += 0x20;
        var block4 = bytes.AsSpan(pos, 0x10); pos += 0x10;
        var block5 = bytes.AsSpan(pos, 0x08); pos += 0x08;

        // Parse NPC positions from blocks 0-1 (first 8 word-pairs, low byte masked)
        int mapW = data.Width;
        int mapH = data.Height;
        int coordMaskX = mapW - 1;
        int coordMaskY = mapH - 1;
        int maxNpc = 8;

        var npcPositions = new System.Collections.Generic.List<(int, int)>();
        for (int i = 0; i < maxNpc; i++)
        {
            int x = block0[i * 2] & coordMaskX;
            int y = block1[i * 2] & coordMaskY;
            if (x != 0 || y != 0)
                npcPositions.Add((x, y));
            else
                npcPositions.Add((0, 0));
        }
        data.NpcPositions = npcPositions.ToArray();

        // Parse building positions from blocks 2-3
        var bldPositions = new System.Collections.Generic.List<(int, int)>();
        for (int i = 0; i < maxNpc; i++)
        {
            int x = block2[i * 2] & coordMaskX;
            int y = block3[i * 2] & coordMaskY;
            if (x != 0 || y != 0)
                bldPositions.Add((x, y));
            else
                bldPositions.Add((0, 0));
        }
        data.BuildingPositions = bldPositions.ToArray();

        // Parse NPC-to-building mapping from block 4 (first 8 bytes)
        var npcToBld = new int[maxNpc];
        for (int i = 0; i < maxNpc && i < block4.Length; i++)
            npcToBld[i] = block4[i];
        data.NpcToBuilding = npcToBld;

        // Parse building-to-NPC mapping from block 4 (second 8 bytes)
        var bldToNpc = new int[maxNpc];
        for (int i = 0; i < maxNpc && (i + 8) < block4.Length; i++)
            bldToNpc[i] = block4[i + 8];
        data.BuildingToNpc = bldToNpc;

        // Tile data: tutto ciò che rimane
        int remaining = bytes.Length - pos;
        data.RawMapData = bytes.AsSpan(pos, remaining).ToArray();

        // Decodifica tile in base al formato
        data.Format = mapId switch
        {
            1 or 2 or >= 11 and <= 14 => MapFormat.BlockFormat,
            _ => MapFormat.LinearFormat
        };

        data.TileData = data.Format == MapFormat.BlockFormat
            ? DecodeBlockFormat(data.RawMapData, data.Width, data.Height)
            : DecodeLinearFormat(data.RawMapData, data.Width, data.Height);

        return data;
    }

    /// <summary>
    /// Carica la world map (64×64 template embedded nell'EXE).
    /// </summary>
    public static MapData CreateWorldMap()
    {
        // La world map non ha un file .MTP — è embedded nell'EXE.
        // Per ora creiamo una 64×64 vuota. I dati verranno popolati
        // dal copia da 0x246C:0x42F6 a runtime.
        // TODO Phase 2: estrarre il template dal memory dump o EXE.
        return new MapData
        {
            MapId = 0,
            Width = 64,
            Height = 64,
            Format = MapFormat.LinearFormat,
            TileData = new byte[64 * 64],
            NpcNames = Array.Empty<string>(),
            BuildingNames = Array.Empty<string>(),
        };
    }

    private static byte[] DecodeBlockFormat(byte[] raw, int w, int h)
    {
        // BlockFormat: tile 8×8 raggruppati in macro-blocchi
        // Ogni blocco 8×8 = 64 byte, mappa w×h in blocchi di 8 tile
        int tileW = (w + 7) / 8 * 8;
        int tileH = (h + 7) / 8 * 8;
        byte[] tiles = new byte[tileW * tileH];

        int srcIdx = 0;
        for (int by = 0; by < tileH; by += 8)
        {
            for (int bx = 0; bx < tileW; bx += 8)
            {
                for (int ty = 0; ty < 8; ty++)
                {
                    for (int tx = 0; tx < 8; tx++)
                    {
                        if (srcIdx < raw.Length)
                        {
                            int dstIdx = (by + ty) * tileW + (bx + tx);
                            if (dstIdx < tiles.Length)
                                tiles[dstIdx] = raw[srcIdx];
                        }
                        srcIdx++;
                    }
                }
            }
        }
        return tiles;
    }

    private static byte[] DecodeLinearFormat(byte[] raw, int w, int h)
    {
        // LinearFormat: tile in ordine row-major con block encoding
        // Ogni byte è un tile ID, w × h tiles
        int size = w * h;
        byte[] tiles = new byte[size];
        int copyLen = Math.Min(raw.Length, size);
        Array.Copy(raw, tiles, copyLen);
        return tiles;
    }

    private static string[] ParseNullTerminatedStrings(ReadOnlySpan<byte> data, int maxCount)
    {
        var list = new List<string>();
        int pos = 0;
        for (int i = 0; i < maxCount && pos < data.Length; i++)
        {
            int end = pos;
            while (end < data.Length && data[end] != 0) end++;
            if (end > pos)
                list.Add(System.Text.Encoding.ASCII.GetString(data[pos..end]));
            else
                list.Add("");
            pos = end + 1;
        }
        return list.ToArray();
    }

    private static string[] ParseBuildingNames(ReadOnlySpan<byte> data)
    {
        var list = new List<string>();
        int pos = 0;
        while (pos < data.Length)
        {
            int end = pos;
            while (end < data.Length && data[end] != 0) end++;
            if (end > pos)
            {
                var name = System.Text.Encoding.ASCII.GetString(data[pos..end]);
                if (name.StartsWith("MAP")) break;
                list.Add(name);
            }
            pos = end + 1;
        }
        return list.ToArray();
    }
}