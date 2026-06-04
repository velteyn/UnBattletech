namespace BattleTechCHI.Data;

/// <summary>
/// Game UI mode — corrisponde alla variabile w4FBA dell'originale.
/// </summary>
public enum GameMode : ushort
{
    WorldMap = 0,      // Mappa mondo grande
    LocalTiles = 1,    // Mappa locale (città/edificio)
    Combat = 2,        // Schermata di combattimento
    PostCombat = 3,    // Transizione post-combattimento
    TextScreen = 4,    // Schermata testo/dialogo
    BuildingName = 5,  // Nome edificio
}

/// <summary>
/// Formati di encoding delle mappe MTP.
/// </summary>
public enum MapFormat
{
    BlockFormat,   // MAP1-2, MAP11-14: 8x8 block-encoded
    LinearFormat   // MAP3-10, MAP15: linear block-encoded
}

/// <summary>
/// Narratore / stile del testo nei BLD.
/// </summary>
public enum NarrativeMode : byte
{
    ThirdPerson = 0x9E,     // Terza persona (narratore)
    CharacterSpeech = 0x9C, // Dialogo personaggio
    PlayerThought = 0x9B,   // Pensiero del giocatore
    PlayerAction = 0x9F,    // Azione del giocatore
    Continuation = 0xA5,    // Continuazione frase (lowercase)
}

/// <summary>
/// Opcode del bytecode BLD (0xE4-0xFF).
/// </summary>
public enum BldOpcode : byte
{
    WriteChar = 0xE4,
    AddCredits = 0xE5,
    SetCursorXY = 0xE6,
    CmpCursorX = 0xE7,
    RngCheck = 0xE8,
    CallRoomHandler = 0xE9,
    CondStateAction = 0xEA,
    CheckFlagEB = 0xEB,
    CheckFlagEC = 0xEC,
    UnitCheckLoop = 0xED,
    SpendCredits = 0xEE,
    CheckCredits = 0xEF,
    SetTextMargins = 0xF0,
    AddToState = 0xF1,
    RoomDescription = 0xF2,
    ShopInteraction = 0xF3,
    SetStateValue = 0xF4,
    ShopDispatch = 0xF5,
    CheckCondition = 0xF6,
    StateCondCheck = 0xF7,
    JumpForward = 0xF8,
    JumpIndexed = 0xF9,
    DrawSprite = 0xFA,
    AdvanceInput = 0xFB,
    RenderText = 0xFC,
    SetFont2 = 0xFD,
    SetFont = 0xFE,
    StopInterpreter = 0xFF,
}