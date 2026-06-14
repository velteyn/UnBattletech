using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.BLD;

/// <summary>
/// Carica e decripta i file .BLD del gioco originale.
/// </summary>
public static class BldLoader
{
    /// <summary>
    /// Carica un file .BLD e lo decripta.
    /// </summary>
    public static BldScript? Load(string bldPath, string name)
    {
        if (!File.Exists(bldPath))
        {
            GD.PrintErr($"BLD file not found: {bldPath}");
            return null;
        }

        var raw = File.ReadAllBytes(bldPath);
        var script = new BldScript { Name = name };

        // Header parsing
        script.FileType = raw[0];
        script.InteractionCount = raw[1];
        // signature 4 byte: ee c6 eb ea
        script.TypeCode = raw[6] << 8 | raw[7];
        script.SubType = raw[8];

        // InterpreterBase = 0xA0 (confirmed from Reko decompilation — fn0FDC_01C0
        // at UNBTECH_0FDC.asm:92-98: "mov ax,0A0h; mov dx,3092h; push dx; push ax").
        // Bytecode starts at file offset 0xA0. Pre-0xA0 (0x08-0x9F) is metadata/cipher
        // text, NOT bytecode. Original game NEVER interprets those bytes as opcodes.
        script.InterpreterBase = 0xA0;

        // Decrypt bytes from offset 0xA0
        var decrypted = new byte[raw.Length];
        Array.Copy(raw, decrypted, raw.Length);
        DecryptInPlace(decrypted);

        script.RawBytes = decrypted;
        return script;
    }

    /// <summary>
    /// Decripta i byte del BLD in-place.
    /// Original encryption: ((plain + 41) & 0xFF) ^ 233
    /// Inverse (decryption): ((cipher ^ 233) - 41) & 0xFF
    /// </summary>
    public static void DecryptInPlace(byte[] data)
    {
        for (int i = 0xA0; i < data.Length; i++)
        {
            data[i] = (byte)((data[i] ^ 233) - 41);
        }
    }

    /// <summary>
    /// Legge il file JSON pre-convertito (più veloce del decriptare a runtime).
    /// </summary>
    public static BldScript? LoadFromJson(string jsonPath, string name)
    {
        if (!File.Exists(jsonPath))
        {
            GD.PrintErr($"BLD JSON not found: {jsonPath}");
            return null;
        }
        
        // TODO Phase 3: parser JSON completo
        GD.Print($"BLD JSON loaded: {name} (parser TBD)");
        return null;
    }
}