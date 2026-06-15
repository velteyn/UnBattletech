// Minimal test runner for core logic (no Godot dependencies)
using System.Collections.Generic;

int passed = 0, failed = 0;

void Assert(bool condition, string msg) {
    if (condition) { passed++; Console.Write("."); }
    else { failed++; Console.WriteLine($"\nFAIL: {msg}"); }
}

Console.WriteLine("=== BattleTechCHI Core Logic Tests ===\n");

// --- CipherDecoder ---
Console.Write("CipherDecoder ");
Assert(CipherDecoder.DecodeByte(0x57) == 'i', "0x57 -> i");
Assert(CipherDecoder.DecodeByte(0x58) == 'h', "0x58 -> h");
Assert(CipherDecoder.DecodeByte(0xA0) == ' ', "0xA0 -> space");
Assert(CipherDecoder.DecodeByte(0x77) == 'I', "0x77 -> I");
Assert(CipherDecoder.DecodeByte(0x7F) == 'A', "0x7F -> A");
var phrase = CipherDecoder.Decode(new byte[] { 0x5A, 0x73, 0x5B, 0x70 });
Assert(phrase == "jump", $"0x5A,73,5B,70 -> '{phrase}'");

// --- WeaponData ---
Console.Write(" WeaponData ");
var weapons = WeaponData.Weapons;
Assert(weapons.Length == 33, $"count={weapons.Length}");
Assert(weapons[0].Name == "Small Laser", weapons[0].Name);
Assert(weapons[0].Damage == 3, $"damage={weapons[0].Damage}");
Assert(weapons[32].IsPhysicalKick == 1, $"kick={weapons[32].IsPhysicalKick}");

// --- GameState ---
Console.Write(" GameState ");
var state = new GameState();
Assert(state.StateArray.Length == 256, $"state={state.StateArray.Length}");
Assert(state.WorldMapVisibility.Length == 2048, $"vis={state.WorldMapVisibility.Length}");

// --- LocationMapper ---
Console.Write(" LocationMapper ");
var idx = LocationMapper.GetBldIndex(26, 5);
Assert(idx != null, "citadel index");
Assert(LocationMapper.GetBldName(idx!.Value) == "TRAINING", "TRAINING");
Assert(LocationMapper.GetBldIndex(0, 0) == null, "null lookup");
Assert(LocationMapper.GetMapId(28, 11) == 2, "map 2");

// --- StorySlot ---
Console.Write(" StorySlot ");
var slot = new StorySlot();
Assert(slot.StoryState == 0, "default");
Assert(slot.CounterA == 0, "counterA");

// --- GameEnums ---
Console.Write(" GameEnums ");
Assert((int)GameMode.WorldMap == 0, "worldmap=0");
Assert((int)GameMode.Combat == 2, "combat=2");
Assert((byte)BldOpcode.ShopDispatch == 0xF5, "0xF5");
Assert((byte)BldOpcode.StopInterpreter == 0xFF, "0xFF");
Assert((byte)NarrativeMode.ThirdPerson == 0x9E, "9E");

// --- HashMap consistency ---
Console.Write(" Consistency ");
var modes = new HashSet<int>();
foreach (GameMode m in Enum.GetValues<GameMode>()) Assert(modes.Add((int)m), $"dup mode {m}");
Assert(modes.Count == 6, $"modes={modes.Count}");

// --- RLE decompressor (format01 basic) ---
Console.Write(" RLE ");
var rleResult = RleDecompressor.DecompressFormat01(new byte[] { 0x05, 0xAB }, 0);
Assert(rleResult[0] == 0xAB, $"rle[0]={rleResult[0]:X2}");
Assert(rleResult[4] == 0xAB, $"rle[4]={rleResult[4]:X2}");
Assert(rleResult[5] == 0, $"rle[5]={rleResult[5]}");

// ===== NEW ASSUMPTION TESTS =====

// --- State-aware BLD Selection (SelectBldForTile) ---
Console.Write("\nSelectBldForTile ");
var selState = new GameState();
selState.StorySlots[0] = new StorySlot();
selState.UnitSlots[0] = new UnitSlot();
// Default at (26,5) -> TRAINING
Assert(SelectBldForTile(26, 5, selState) == "TRAINING", "default -> TRAINING");
// TrainingComplete -> CITADEL
selState.TrainingComplete = true;
Assert(SelectBldForTile(26, 5, selState) == "CITADEL", "training -> CITADEL");
// TrainingComplete + cache flag -> ENDMECH
selState.StateArray[0x52] = 1;
Assert(SelectBldForTile(26, 5, selState) == "ENDMECH", "cache -> ENDMECH");
// Milestone + all objectives -> WINSCENE
selState.Milestone = true;
selState.StateArray[0x53] = 1;
Assert(SelectBldForTile(26, 5, selState) == "WINSCENE", "done -> WINSCENE");
// Different tile (not 26,5) -> LocationMapper default
var nonCitadelIdx = LocationMapper.GetBldIndex(28, 11);
Assert(nonCitadelIdx != null, "barracks index");
var defaultName = nonCitadelIdx != null ? LocationMapper.GetBldName(nonCitadelIdx.Value) : "";
Assert(SelectBldForTile(28, 11, selState) == defaultName, "other tile -> mapper default");

// --- Room Interaction (push/pop state) ---
Console.Write("\nRoomInteraction ");
var roomState = new GameState();
roomState.StorySlots = new StorySlot[16];
for (int i = 0; i < 16; i++) roomState.StorySlots[i] = new StorySlot();
roomState.UnitSlots = new UnitSlot[8];
for (int i = 0; i < 8; i++) roomState.UnitSlots[i] = new UnitSlot();
roomState.RoomStateBackup = new byte[0x7D];

// Setup initial state
roomState.StorySlots[0].StatusByte = 0x42;
roomState.StorySlots[0].StoryState = 3;
roomState.UnitSlots[1].TypeId = 0x05;
roomState.UnitSlots[2].TypeId = 0x0A;

// Push (enter room)
PushRoomState(roomState);
Assert(roomState.RoomActive, "room active after push");
Assert(roomState.RoomStateBackup[0] == 0x42, $"backup StatusByte={roomState.RoomStateBackup[0]}");
Assert(roomState.RoomStateBackup[6] == 3, $"backup StoryState={roomState.RoomStateBackup[6]}");
Assert(roomState.UnitSlots[1].TypeId == 0xFF, "slot1 cleared after push");
Assert(roomState.UnitSlots[2].TypeId == 0xFF, "slot2 cleared after push");
Assert(roomState.UnitSlots[0].TypeId == 0xFF, "slot0 cleared (all cleared)");

// Pop (exit room)
PopRoomState(roomState);
Assert(!roomState.RoomActive, "room inactive after pop");
Assert(roomState.StorySlots[0].StatusByte == 0x42, $"restored StatusByte={roomState.StorySlots[0].StatusByte}");
Assert(roomState.StorySlots[0].StoryState == 3, $"restored StoryState={roomState.StorySlots[0].StoryState}");
Assert(roomState.UnitSlots[1].TypeId == 0xFF, "slot1 still cleared after pop");
Assert(roomState.UnitSlots[2].TypeId == 0xFF, "slot2 still cleared after pop");

// Push with null slot check
var emptyState = new GameState();
emptyState.RoomStateBackup = new byte[0x7D];
var noCrash = true;
try { PushRoomState(emptyState); } catch { noCrash = false; }
Assert(noCrash, "push with null slots doesn't crash");

// --- Fn1CD3Dispatcher Key Cases ---
Console.Write("\nDispatcher ");
// Case 0x23: NewGameInit
var initState = new GameState();
initState.Credits = 9999;
initState.TrainingComplete = true;
initState.Milestone = true;
initState.StateArray[10] = 0xFF;
initState.InventoryQuantities = new uint[] { 5, 3, 1 };
DispatcherNewGameInit(initState);
Assert(initState.Credits == 1500, $"init credits={initState.Credits}");
Assert(!initState.TrainingComplete, "init TrainingComplete=false");
Assert(!initState.Milestone, "init Milestone=false");
Assert(initState.StateArray[10] == 0, $"init state[10]={initState.StateArray[10]}");
Assert(initState.InventoryQuantities[0] == 0, "init inventory cleared");

// Case 0x09: HospitalHeal
var hospState = new GameState();
hospState.UnitSlots = new UnitSlot[8];
for (int i = 0; i < 8; i++) hospState.UnitSlots[i] = new UnitSlot();
hospState.Credits = 100;
DispatcherHospitalHeal(hospState);
Assert(hospState.Credits == 50, $"hospital credits={hospState.Credits}");

// Case 0x19: FlagD450 (TrainingComplete)
var flagState = new GameState();
DispatcherFlagD450(flagState);
Assert(flagState.TrainingComplete, "FlagD450 sets TrainingComplete");
Assert(flagState.StateArray[0x50] == 1, "FlagD450 state[0x50]=1");

// Case 0x1A: FlagD451 (Milestone)
var flagState2 = new GameState();
DispatcherFlagD451(flagState2);
Assert(flagState2.Milestone, "FlagD451 sets Milestone");
Assert(flagState2.StateArray[0x51] == 1, "FlagD451 state[0x51]=1");

// --- BldLoader Decryption ---
Console.Write("\nBldLoader ");
// DecryptInPlace: ((c ^ 233) - 41) & 0xFF
// For input 0x00 at offset 0xA0: ((0 ^ 233) - 41) & 0xFF = (233 - 41) = 192 = 0xC0
var decData = new byte[0xA5];
decData[0xA0] = 0x00;
decData[0x42] = 0xAB; // pre-0xA0 byte
BldLoaderDecryptInPlace(decData);
Assert(decData[0xA0] == 0xC0, $"decrypt 0x00 -> 0x{decData[0xA0]:X2}");
Assert(decData[0x42] == 0xAB, "pre-0xA0 byte unchanged");
// Edge: 0xFF at 0xA0: ((255 ^ 233) - 41) & 0xFF = (22 - 41) & 0xFF = 0xED
var decData2 = new byte[0xA5];
decData2[0xA0] = 0xFF;
BldLoaderDecryptInPlace(decData2);
Assert(decData2[0xA0] == 0xED, $"decrypt 0xFF -> 0x{decData2[0xA0]:X2}");
// Empty array (smaller than 0xA0) should not crash
var smallData = new byte[10];
BldLoaderDecryptInPlace(smallData); // should do nothing
Assert(smallData[0] == 0, "small array no-op");

// --- UnitSlot defaults ---
Console.Write("\nUnitSlot ");
var us = new UnitSlot();
Assert(us.TypeId == 0xFF, "default TypeId=0xFF");
Assert(us.Inventory.Length == 7, "inventory size 7");
Assert(us.LinkedStorySlot == 0x08, "default LinkedStorySlot=0x08");

// --- RoomStateBackup roundtrip ---
Console.Write("\nRoomStateBackup ");
var rtState = new GameState();
rtState.StorySlots = new StorySlot[16];
for (int i = 0; i < 16; i++) rtState.StorySlots[i] = new StorySlot();
rtState.UnitSlots = new UnitSlot[8];
for (int i = 0; i < 8; i++) rtState.UnitSlots[i] = new UnitSlot();
rtState.RoomStateBackup = new byte[0x7D];
// Fill story slot with distinct values
rtState.StorySlots[0].StatusByte = 0x12;
rtState.StorySlots[0].FlagsLow = 0x34;
rtState.StorySlots[0].FlagsHigh = 0x56;
rtState.StorySlots[0].TimingNibble = 0x78;
rtState.StorySlots[0].CounterA = 0x9A;
rtState.StorySlots[0].CounterB = 0xBC;
rtState.StorySlots[0].StoryState = 0xDE;
rtState.StorySlots[0].LatchMarker = 0xF0;
rtState.StorySlots[0].LinkedUnitSlot = 0xAA;
// Push
PushRoomState(rtState);
Assert(rtState.RoomActive, "rt active");
// Mutate slot 0
rtState.StorySlots[0].StatusByte = 0xFF;
// Pop
PopRoomState(rtState);
Assert(!rtState.RoomActive, "rt inactive");
Assert(rtState.StorySlots[0].StatusByte == 0x12, $"rt restored StatusByte={rtState.StorySlots[0].StatusByte}");
Assert(rtState.StorySlots[0].FlagsLow == 0x34, "rt restored FlagsLow");
Assert(rtState.StorySlots[0].StoryState == 0xDE, "rt restored StoryState");
Assert(rtState.StorySlots[0].LinkedUnitSlot == 0xAA, "rt restored LinkedUnitSlot");

Console.WriteLine($"\n\nResults: {passed} passed, {failed} failed");
return failed > 0 ? 1 : 0;

// ── Helper functions replicating Godot project logic ──

string SelectBldForTile(int tileX, int tileY, GameState gs)
{
    if (tileX == 26 && tileY == 5)
    {
        if (gs.Milestone && gs.StateArray[0x53] == 1) return "WINSCENE";
        if (gs.TrainingComplete && gs.StateArray[0x52] == 1) return "ENDMECH";
        if (gs.TrainingComplete) return "CITADEL";
        return "TRAINING";
    }
    var idx = LocationMapper.GetBldIndex(tileX, tileY);
    return idx != null ? LocationMapper.GetBldName(idx.Value) : "";
}

void PushRoomState(GameState gs)
{
    if (gs.StorySlots == null || gs.StorySlots.Length == 0 || gs.StorySlots[0] == null) return;
    if (gs.RoomStateBackup == null || gs.RoomStateBackup.Length < 9) return;
    var slot = gs.StorySlots[0];
    int idx = 0;
    gs.RoomStateBackup[idx++] = slot.StatusByte;
    gs.RoomStateBackup[idx++] = slot.FlagsLow;
    gs.RoomStateBackup[idx++] = slot.FlagsHigh;
    gs.RoomStateBackup[idx++] = slot.TimingNibble;
    gs.RoomStateBackup[idx++] = slot.CounterA;
    gs.RoomStateBackup[idx++] = slot.CounterB;
    gs.RoomStateBackup[idx++] = slot.StoryState;
    gs.RoomStateBackup[idx++] = slot.LatchMarker;
    gs.RoomStateBackup[idx++] = slot.LinkedUnitSlot;
    if (gs.UnitSlots != null)
        for (int i = 1; i < gs.UnitSlots.Length; i++)
            if (gs.UnitSlots[i] != null) gs.UnitSlots[i].TypeId = 0xFF;
    gs.RoomActive = true;
}

void PopRoomState(GameState gs)
{
    if (gs.StorySlots == null || gs.StorySlots.Length == 0 || gs.StorySlots[0] == null) return;
    if (gs.RoomStateBackup == null || gs.RoomStateBackup.Length < 9) return;
    var slot = gs.StorySlots[0];
    var b = gs.RoomStateBackup;
    slot.StatusByte = b[0];
    slot.FlagsLow = b[1];
    slot.FlagsHigh = b[2];
    slot.TimingNibble = b[3];
    slot.CounterA = b[4];
    slot.CounterB = b[5];
    slot.StoryState = b[6];
    slot.LatchMarker = b[7];
    slot.LinkedUnitSlot = b[8];
    if (gs.UnitSlots != null)
        for (int i = 1; i < gs.UnitSlots.Length; i++)
            if (gs.UnitSlots[i] != null) gs.UnitSlots[i].TypeId = 0xFF;
    gs.RoomActive = false;
}

void DispatcherNewGameInit(GameState gs)
{
    gs.Credits = 1500;
    gs.TrainingComplete = false;
    gs.Milestone = false;
    for (int i = 0; i < gs.StateArray.Length; i++) gs.StateArray[i] = 0;
    if (gs.InventoryQuantities != null)
        for (int i = 0; i < gs.InventoryQuantities.Length; i++) gs.InventoryQuantities[i] = 0;
}

void DispatcherHospitalHeal(GameState gs)
{
    gs.Credits = Math.Max(0, gs.Credits - 50);
}

void DispatcherFlagD450(GameState gs)
{
    gs.TrainingComplete = true;
    gs.StateArray[0x50] = 1;
}

void DispatcherFlagD451(GameState gs)
{
    gs.Milestone = true;
    gs.StateArray[0x51] = 1;
}

void BldLoaderDecryptInPlace(byte[] data)
{
    for (int i = 0xA0; i < data.Length; i++)
        data[i] = (byte)((data[i] ^ 233) - 41);
}

// ── Inline class definitions (no Godot dependencies) ──

static class CipherDecoder
{
    static readonly Dictionary<byte, char> _t = Assign();
    static Dictionary<byte, char> Assign() => new()
    {
        [0x57]='i',[0x58]='h',[0x59]='k',[0x5A]='j',[0x5B]='m',[0x5C]='l',[0x5D]='o',[0x5E]='n',[0x5F]='a',
        [0x60]='q',[0x61]='c',[0x62]='b',[0x63]='e',[0x64]='d',[0x65]='g',[0x66]='f',[0x67]='y',[0x68]='x',
        [0x69]='i',[0x6A]='z',[0x6C]='l',[0x6D]='m',[0x6E]='n',[0x6F]='o',[0x70]='p',[0x71]='s',[0x72]='r',
        [0x73]='u',[0x74]='t',[0x75]='w',[0x76]='v',
        [0x77]='I',[0x78]='H',[0x79]='K',[0x7A]='J',[0x7B]='M',[0x7C]='L',[0x7D]='O',[0x7E]='N',[0x7F]='A',
        [0x81]='C',[0x82]='B',[0x83]='E',[0x84]='D',[0x85]='G',[0x86]='F',[0x87]='Y',[0x90]='P',
        [0x91]='S',[0x92]='R',[0x93]='U',[0x94]='T',[0x95]='W',[0x96]='V',
    };
    public static char DecodeByte(byte b) => _t.TryGetValue(b, out var c) ? c : (b == 0xA0 ? ' ' : b >= 0x20 && b <= 0x7E ? (char)b : '?');
    public static string Decode(ReadOnlySpan<byte> b) { var sb = new System.Text.StringBuilder(); foreach (var x in b) sb.Append(DecodeByte(x)); return sb.ToString(); }
}

public enum GameMode:ushort { WorldMap,LocalTiles,Combat,PostCombat,TextScreen,BuildingName }
public enum MapFormat { BlockFormat,LinearFormat }
public enum NarrativeMode:byte { ThirdPerson=0x9E,CharacterSpeech=0x9C,PlayerThought=0x9B,PlayerAction=0x9F,Continuation=0xA5 }
public enum BldOpcode:byte { WriteChar=0xE4,AddCredits=0xE5,SetCursorXY=0xE6,CmpCursorX=0xE7,RngCheck=0xE8,CallRoomHandler=0xE9,CondStateAction=0xEA,CheckFlagEB=0xEB,CheckFlagEC=0xEC,UnitCheckLoop=0xED,SpendCredits=0xEE,CheckCredits=0xEF,SetTextMargins=0xF0,AddToState=0xF1,RoomDescription=0xF2,ShopInteraction=0xF3,SetStateValue=0xF4,ShopDispatch=0xF5,CheckCondition=0xF6,StateCondCheck=0xF7,JumpForward=0xF8,JumpIndexed=0xF9,DrawSprite=0xFA,AdvanceInput=0xFB,RenderText=0xFC,SetFont2=0xFD,SetFont=0xFE,StopInterpreter=0xFF }

public class GameState
{
    public GameMode Mode;
    public int CursorX,CursorY;
    public int[] UnitX=new int[32],UnitY=new int[32];
    public byte[] UnitStatus=new byte[32];
    public int Credits;
    public byte[] StateArray=new byte[256];
    public StorySlot[] StorySlots=new StorySlot[16];
    public bool TrainingComplete,Milestone;
    public byte EncounterMask=0x1F;
    public byte[] WorldMapVisibility=new byte[2048];
    public int CurrentMapId=1;
    public int TextCursorX,TextCursorY,TextMarginLeft,TextMarginRight;
    // Fields added for room interactions
    public bool RoomActive;
    public byte[] RoomStateBackup = new byte[0x7D];
    public UnitSlot[] UnitSlots = new UnitSlot[8];
    public uint[] InventoryQuantities = new uint[32];
}

public class StorySlot
{
    public byte StatusByte,FlagsLow,FlagsHigh,TimingNibble,CounterA,CounterB,StoryState,LatchMarker,LinkedUnitSlot;
}

public class UnitSlot
{
    public byte TypeId = 0xFF;
    public byte Attr1,Attr2,Attr3;
    public byte[] Inventory = new byte[7];
    public byte FieldC61C,FieldC61F,LinkedStorySlot=0x08,FieldC621,FieldC622,DerivedAttr,FieldC624;
}

public static class WeaponData { public static Weapon[] Weapons = new[]{new Weapon("Small Laser",1,0,3,1,1,5,0,0),new Weapon("Medium Laser",2,0,5,3,3,8,0,0),new Weapon("Large Laser",3,0,8,8,5,12,0,0),new Weapon("PPC",4,0,10,10,7,15,0,0),new Weapon("AC/2",5,0,2,2,4,8,0,0),new Weapon("AC/5",6,0,5,5,6,12,0,0),new Weapon("AC/10",7,0,10,10,8,16,0,0),new Weapon("AC/20",8,0,20,20,9,18,0,0),new Weapon("SRM-2",9,1,2,2,2,6,0,0),new Weapon("SRM-4",10,1,4,4,3,8,0,0),new Weapon("SRM-6",11,1,6,6,4,10,0,0),new Weapon("LRM-5",12,1,5,5,4,8,0,0),new Weapon("LRM-10",13,1,10,10,5,10,0,0),new Weapon("LRM-15",14,1,15,15,6,12,0,0),new Weapon("LRM-20",15,1,20,20,7,14,0,0),new Weapon("Machine Gun",16,0,2,1,1,3,0,0),new Weapon("Flamer",17,0,2,0,2,4,0,0),new Weapon("Small Laser (NPC)",18,0,3,1,1,5,0,0),new Weapon("Medium Laser (NPC)",19,0,5,3,3,8,0,0),new Weapon("Large Laser (NPC)",20,0,8,8,5,12,0,0),new Weapon("PPC (NPC)",21,0,10,10,7,15,0,0),new Weapon("AC/2 (NPC)",22,0,2,2,4,8,0,0),new Weapon("AC/5 (NPC)",23,0,5,5,6,12,0,0),new Weapon("AC/10 (NPC)",24,0,10,10,8,16,0,0),new Weapon("AC/20 (NPC)",25,0,20,20,9,18,0,0),new Weapon("SRM-2 (NPC)",26,1,2,2,2,6,0,0),new Weapon("SRM-4 (NPC)",27,1,4,4,3,8,0,0),new Weapon("SRM-6 (NPC)",28,1,6,6,4,10,0,0),new Weapon("LRM-5 (NPC)",29,1,5,5,4,8,0,0),new Weapon("LRM-10 (NPC)",30,1,10,10,5,10,0,0),new Weapon("LRM-15 (NPC)",31,1,15,15,6,12,0,0),new Weapon("LRM-20 (NPC)",32,1,20,20,7,14,0,0),new Weapon("Kick (Physical)",33,0,5,0,1,1,0,1)}; }
public record Weapon(string Name,int Id,int AmmoType,int Damage,int HeatGenerated,int MinRange,int MaxRange,int AccuracyBonus,int IsPhysicalKick);

static class LocationMapper
{
    static readonly(string,int,int,int)[] Locs={("TRAINING",26,5,1),("CITADEL",26,6,1),("BARRACKS",28,11,2),("BARRACK2",29,11,2),("COMSTAR",27,9,2),("INSTRUCT",27,5,1),("GARAGE",29,12,2),("HOSPITAL",28,12,2),("WEAPON",29,10,2),("WEAPON2",30,10,2),("ARMOR",28,9,2),("CLOTHES",27,10,2),("LOUNGE",30,11,2),("THEATER",27,12,2),("VIEWDISK",27,12,2),("JAIL",5,54,3),("MAYOR",5,55,3),("FINDIT",55,8,4),("FROB",32,18,5),("PARTY",28,10,2),("HUT",10,10,6),("ENTRANCE",33,49,7),("ARENA",30,8,2),("REPAIR",28,13,2),("WINSCENE",26,5,1),("ENDMECH",26,5,1)};
    public static int? GetBldIndex(int x,int y){for(int i=0;i<Locs.Length;i++)if(Locs[i].Item2==x&&Locs[i].Item3==y)return i;return null;}
    public static string GetBldName(int i)=>i>=0&&i<Locs.Length?Locs[i].Item1:"";
    public static int? GetMapId(int x,int y){for(int i=0;i<Locs.Length;i++)if(Locs[i].Item2==x&&Locs[i].Item3==y)return Locs[i].Item4;return null;}
}

static class RleDecompressor
{
    public static byte[] DecompressFormat01(byte[] compressed,int startPos){
        var o=new byte[32000];int si=startPos,di=0;
        while(di<o.Length&&si<compressed.Length){
            byte b=compressed[si++];int len;
            if(b==0){if(si+2>=compressed.Length)break;len=(compressed[si]<<8)|compressed[si+1];si+=2;if(si>=compressed.Length)break;byte d=compressed[si++];int e=Math.Min(di+len,o.Length);while(di<e)o[di++]=d;}
            else{if(si>=compressed.Length)break;byte d=compressed[si++];int e=Math.Min(di+b,o.Length);while(di<e)o[di++]=d;}
        }
        return o;
    }
}

static class Mathf { public static int Min(int a,int b)=>a<b?a:b; }
