namespace BattleTechCHI.Data;

/// <summary>
/// Stato generale del gioco: mappa la memory map del gioco originale.
/// </summary>
public class GameState
{
    // === UI Mode ===
    public GameMode Mode { get; set; } = GameMode.WorldMap;
    
    // === Cursore ===
    public int CursorX { get; set; }  // A44B
    public int CursorY { get; set; }  // A44D

    // === Unità / Personaggi ===
    // Unit X positions: segment 0x5592, offset 0x4004 (ID * 2)
    // Unit Y positions: segment 0x5590, offset 0x4036 (ID * 2)
    // Unit status: offset 0x406A (0 = inattivo/morto)
    public int[] UnitX { get; set; } = new int[32];
    public int[] UnitY { get; set; } = new int[32];
    public byte[] UnitStatus { get; set; } = new byte[32];
    
    // === Finanze ===
    public int Credits { get; set; }          // tD370 (32-bit)
    
    // === Inventario Player ===
    public uint[] InventoryQuantities { get; set; } = new uint[32];  // aD374[]
    public ushort[] InventoryData { get; set; } = new ushort[32];   // aD376[]
    
    // === 3-Layer Story State ===
    // Layer 1: Generic state array (D30C, 256 byte)
    public byte[] StateArray { get; set; } = new byte[256];
    
    // Layer 2: Story properties per story slot
    public StorySlot[] StorySlots { get; set; } = new StorySlot[16];
    
    // Layer 3: Flags
    public bool TrainingComplete { get; set; }     // bD450
    public bool Milestone { get; set; }            // bD451
    
    // === Incontri ===
    public byte EncounterMask { get; set; } = 0x1F;  // bD330
    
    // === World Map ===
    public byte[] WorldMapVisibility { get; set; } = new byte[2048]; // 128x128 bit-packed
    
    // === Mappa attuale ===
    public int CurrentMapId { get; set; } = 1;
    public int CurrentBldId { get; set; } = -1;
    
    // === BLD interpreter state ===
    public byte[] BldBuffer { get; set; } = Array.Empty<byte>();
    public int BldPosition { get; set; }
    public int TextCursorX { get; set; }
    public int TextCursorY { get; set; }
    public int TextMarginLeft { get; set; }
    public int TextMarginRight { get; set; }
}

/// <summary>
/// Per-story slot (Eq_107947, 0x7D bytes per entry).
/// </summary>
public class StorySlot
{
    public byte StatusByte { get; set; }          // b0000
    public byte FlagsLow { get; set; }             // b0004 (nibble-packed)
    public byte FlagsHigh { get; set; }            // b0005 (nibble-packed)
    public byte TimingNibble { get; set; }         // b0006
    public byte CounterA { get; set; }             // b0055 (capped 3)
    public byte CounterB { get; set; }             // b0056 (capped 2)
    public byte StoryState { get; set; }           // b0057 (0=Training, 1=CitadelAttack, 2=PostAttack)
    public byte LatchMarker { get; set; }          // b0058 (one-shot latch)
}