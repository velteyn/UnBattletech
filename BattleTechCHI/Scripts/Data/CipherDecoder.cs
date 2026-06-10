namespace BattleTechCHI.Data;

/// <summary>
/// Decodifica i testi cifrati nei file .BLD.
/// Mappa: substitution cipher crackato via frequency analysis.
/// </summary>
public static class CipherDecoder
{
    private static readonly Dictionary<byte, char> DecodeTable = new()
    {
        // Lowercase range 0x57-0x5F
        [0x57] = 'i', [0x58] = 'h', [0x59] = 'k', [0x5A] = 'j',
        [0x5B] = 'm', [0x5C] = 'l', [0x5D] = 'o', [0x5E] = 'n', [0x5F] = 'a',
        // 0x60
        [0x60] = 'q',
        // Lowercase range 0x61-0x76 (with 0x6B=control, skipped)
        [0x61] = 'c', [0x62] = 'b', [0x63] = 'e', [0x64] = 'd', [0x65] = 'g',
        [0x66] = 'f', [0x67] = 'y', [0x68] = 'x', [0x69] = 'i', [0x6A] = 'z',
        [0x6C] = 'l', [0x6D] = 'm', [0x6E] = 'n', [0x6F] = 'o', [0x70] = 'p',
        [0x71] = 's', [0x72] = 'r', [0x73] = 'u', [0x74] = 't', [0x75] = 'w', [0x76] = 'v',
        // Uppercase range 0x77-0x7F (caps in "lowercase" range)
        [0x77] = 'I', [0x78] = 'H', [0x79] = 'K', [0x7A] = 'J',
        [0x7B] = 'M', [0x7C] = 'L', [0x7D] = 'O', [0x7E] = 'N', [0x7F] = 'A',
        // Uppercase range 0x80-0x96
        [0x81] = 'C', [0x82] = 'B', [0x83] = 'E', [0x84] = 'D', [0x85] = 'G',
        [0x86] = 'F', [0x87] = 'Y', [0x90] = 'P', [0x91] = 'S', [0x92] = 'R',
        [0x93] = 'U', [0x94] = 'T', [0x95] = 'W', [0x96] = 'V',
    };

    /// <summary>
    /// Returns true if this cipher byte has a mapping in the decode table
    /// (including space at 0xA0 and direct ASCII 0x20-0x7E).
    /// </summary>
    public static bool IsMapped(byte cipherByte)
    {
        if (DecodeTable.ContainsKey(cipherByte)) return true;
        if (cipherByte == 0xA0) return true;
        if (cipherByte >= 0x20 && cipherByte <= 0x7E) return true;
        return false;
    }

    /// <summary>
    /// Decodifica un byte cipher nel carattere corrispondente.
    /// </summary>
    public static char DecodeByte(byte cipherByte)
    {
        if (DecodeTable.TryGetValue(cipherByte, out var c))
            return c;
        // 0xA0 = spazio
        if (cipherByte == 0xA0) return ' ';
        // Altri range: passa come carattere diretto se printable
        if (cipherByte >= 0x20 && cipherByte <= 0x7E)
            return (char)cipherByte;
        return '?';
    }

    /// <summary>
    /// Decodifica un array di byte cipher in stringa leggibile.
    /// </summary>
    public static string Decode(ReadOnlySpan<byte> cipherBytes)
    {
        var sb = new System.Text.StringBuilder(cipherBytes.Length);
        foreach (var b in cipherBytes)
        {
            sb.Append(DecodeByte(b));
        }
        return sb.ToString();
    }
}