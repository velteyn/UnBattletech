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
    public int InterpreterBase { get; set; } = 0xA0;
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
    public byte[] TileData { get; set; } = Array.Empty<byte>();       // Layout tile
    public byte[] RawMapData { get; set; } = Array.Empty<byte>();
}