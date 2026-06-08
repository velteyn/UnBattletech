namespace BattleTechCHI.Data;

    /// <summary>
    /// Modello dati per un file .BLD decodificato (o da JSON pre-convertito).
    /// </summary>
    public class BldScript
    {
        public string Name { get; set; } = "";
        public int FileType { get; set; }
        public int InteractionCount { get; set; }
        public int TypeCode { get; set; }
        public int SubType { get; set; }
        public byte[] RawBytes { get; set; } = Array.Empty<byte>();
        /// <summary>
        /// BLD script start offset, set dynamically by BldLoader based on type code.
        /// - shop/service (0xC0F5): base=11 (skip 3 subtype bytes at 8-10)
        /// - dialogue/story (0xC0EC): base=8 (script starts right after header)
        /// Raw bytes at base..0x9F are unencrypted; bytes at 0xA0+ are
        /// decrypted in-place by BldLoader (cipher: ((b+41)&0xFF)^233).
        /// </summary>
        public int InterpreterBase { get; set; }
    }

/// <summary>
/// Una singola istruzione del bytecode BLD.
/// </summary>
public class BldInstruction
{
    public BldOpcode Opcode { get; set; }
    public int Position { get; set; }       // Posizione nell'interpreter space (base 0xA0)
    public int RawPosition { get; set; }    // Posizione raw nel file
    public byte[] Operands { get; set; } = Array.Empty<byte>();
    public string? TextOperand { get; set; } // Per RenderText
    public NarrativeMode? NarrativeMode { get; set; }
}

/// <summary>
/// Modello dati per armi/nemici nel combattimento.
/// </summary>
public class MechDef
{
    public string Name { get; set; } = "";
    public int Id { get; set; }
    public int Tonnage { get; set; }
    public int MaxArmor { get; set; }
    public int Speed { get; set; }
    public List<MechWeaponSlot> Weapons { get; set; } = new();
}

public class MechWeaponSlot
{
    public int WeaponId { get; set; }
    public string WeaponName { get; set; } = "";
    public int Ammo { get; set; }
    public int MaxAmmo { get; set; }
}

/// <summary>
/// Modello dati mappa. Corrisponde al formato .MTP.
/// </summary>
public class MapData
{
    public int MapId { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public MapFormat Format { get; set; }
    public string[] NpcNames { get; set; } = Array.Empty<string>();
    public string[] BuildingNames { get; set; } = Array.Empty<string>();
    public byte[] TileData { get; set; } = Array.Empty<byte>();
    public byte[] RawMapData { get; set; } = Array.Empty<byte>();

    // NPC positions parsed from variable blocks 0-1 (low byte of each word, masked)
    public (int x, int y)[] NpcPositions { get; set; } = Array.Empty<(int, int)>();

    // Building positions parsed from variable blocks 2-3
    public (int x, int y)[] BuildingPositions { get; set; } = Array.Empty<(int, int)>();

    // NPC-to-building mapping from block 4 (first 8 bytes)
    public int[] NpcToBuilding { get; set; } = Array.Empty<int>();

    // Building-to-NPC mapping from block 4 (second 8 bytes) / block 5
    public int[] BuildingToNpc { get; set; } = Array.Empty<int>();
}