using Godot;

namespace BattleTechCHI.Core;

/// <summary>
/// SaveManager: carica e salva lo stato del gioco nel formato originale.
/// I save file originali sono in GAME1-GAME6.
/// Formato: binario, 4096 byte, segment 0x3092 mappato in memoria.
/// </summary>
public static class SaveManager
{
    private const int SaveSize = 4096;

    /// <summary>
    /// Carica un save file nel GameState.
    /// </summary>
    public static bool Load(string path, Data.GameState state)
    {
        if (!File.Exists(path))
        {
            GD.PrintErr($"Save file not found: {path}");
            return false;
        }

        var bytes = File.ReadAllBytes(path);
        if (bytes.Length != SaveSize)
        {
            GD.PrintErr($"Save file wrong size: {bytes.Length} (expected {SaveSize})");
            return false;
        }

        // Parse save file fields
        // Offset 0x04F9: World Map Visibility (2048 bytes, bit-packed 128×128)
        if (0x04F9 + 2048 <= bytes.Length)
        {
            state.WorldMapVisibility = bytes[0x04F9..(0x04F9 + 2048)];
        }

        // Offset 0x0F45: Party position X
        // Offset 0x0F47: Party position Y
        state.CursorX = (bytes[0x0F45] << 8) | bytes[0x0F46];
        state.CursorY = (bytes[0x0F47] << 8) | bytes[0x0F48];

        // Offset 0x0D30C: Generic state array (256 bytes)
        if (0x0D30C + 256 <= bytes.Length)
        {
            for (int i = 0; i < 256; i++)
                state.StateArray[i] = bytes[0x0D30C + i];
        }

        GD.Print($"Save loaded: {path} — pos=({state.CursorX}, {state.CursorY})");
        return true;
    }

    /// <summary>
    /// Salva lo stato corrente in un file.
    /// </summary>
    public static bool Save(string path, Data.GameState state)
    {
        var bytes = new byte[SaveSize];

        // Visibility
        if (state.WorldMapVisibility.Length >= 2048)
            Array.Copy(state.WorldMapVisibility, 0, bytes, 0x04F9, 2048);

        // Position
        bytes[0x0F45] = (byte)((state.CursorX >> 8) & 0xFF);
        bytes[0x0F46] = (byte)(state.CursorX & 0xFF);
        bytes[0x0F47] = (byte)((state.CursorY >> 8) & 0xFF);
        bytes[0x0F48] = (byte)(state.CursorY & 0xFF);

        // State array
        for (int i = 0; i < 256; i++)
            bytes[0x0D30C + i] = state.StateArray[i];

        try
        {
            File.WriteAllBytes(path, bytes);
            GD.Print($"Save written: {path}");
            return true;
        }
        catch (Exception ex)
        {
            GD.PrintErr($"Save failed: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Cerca file di save nella directory del gioco.
    /// </summary>
    public static string[] FindSaves(string gameDir)
    {
        if (!Directory.Exists(gameDir))
            return Array.Empty<string>();

        return Directory.GetFiles(gameDir, "GAME*")
            .Where(f => new FileInfo(f).Length == SaveSize)
            .OrderBy(f => f)
            .ToArray();
    }
}