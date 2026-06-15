namespace BattleTechCHI.Data;

/// <summary>
/// Stato generale del gioco: mappa la memory map del gioco originale.
/// </summary>
public class GameState
{
    public GameState()
    {
        for (int i = 0; i < 8; i++) UnitSlots[i] = new UnitSlot();
        for (int i = 0; i < 16; i++) StorySlots[i] = new StorySlot();
    }

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
    
    // === Unit Slots (aC614[0..7], stride 0x11) ===
    public UnitSlot[] UnitSlots { get; set; } = new UnitSlot[8];

    // === Key Wait State (w3938) ===
    // 0 = normal (opcodes execute, busy-wait on keypress)
    // non-zero = fast-forward / skip (opcode 0xEA becomes no-op, timer-based wait)
    public short KeyWaitState { get; set; }

    // === Unit ID Counter (bD456) ===
    // Incremented each time a new unit is created; wraps to 2 when >= 10
    public byte UnitIdCounter { get; set; } = 2;

    // === Encounter Flags ===
    public byte EncounterSlot { get; set; }          // bD331
    public byte EncounterTriggerFlag { get; set; }   // bD332
    public byte EncounterFlag { get; set; }          // bD333

    // === Incontri ===
    public byte EncounterMask { get; set; } = 0x1F;  // bD330
    public byte EncounterCooldown { get; set; }      // bD335
    
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

    // === Room Interaction State (0x21/0x22) ===
    // Tracks whether we're inside a room interaction (wE48E equivalent).
    public bool RoomActive { get; set; }

    // Backup of StorySlots[0] (125 bytes = 0x7D) saved when entering a room,
    // restored when exiting. Maps to the [0x54AA]+0x3780 backup area.
    public byte[] RoomStateBackup { get; set; } = new byte[0x7D];
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
    public byte LinkedUnitSlot { get; set; } = 0xFF;  // b0079 (0xFF = unassigned)
}

/// <summary>
/// Per-unit slot (aC614[slot], stride 0x11 = 17 bytes).
/// 8 slots total (0-7), 0xFF in TypeId = empty.
/// </summary>
public class UnitSlot
{
    public byte TypeId { get; set; } = 0xFF;       // +0x00: b0000 (0xFF = empty)
    public byte Attr1 { get; set; }                 // +0x01: C615 (random attribute, 2D6)
    public byte Attr2 { get; set; }                 // +0x02: C616 (random attribute, 2D6)
    public byte Attr3 { get; set; }                 // +0x03: C617 (random attribute, 2D6)
    public byte[] Inventory { get; set; } = new byte[7];  // +0x04..+0x0A: C618[0..6]
    public byte FieldC61C { get; set; }             // +0x08 (within C618 region)
    public byte FieldC61F { get; set; }             // +0x0B
    public byte LinkedStorySlot { get; set; } = 0x08;  // +0x0C: C620 (0x08 = unassigned)
    public byte FieldC621 { get; set; }             // +0x0D
    public byte FieldC622 { get; set; }             // +0x0E
    public byte DerivedAttr { get; set; }           // +0x0F: C623 = Attr1 * 10
    public byte FieldC624 { get; set; }             // +0x10
    /// <summary>
    /// The handler value from CALL_ROOM_HANDLER (0xE9) opcode that created this unit.
    /// In the original game, this writes value 3 to C618[slot*17 + handler].
    /// </summary>
    public sbyte HandlerTag { get; set; }
}