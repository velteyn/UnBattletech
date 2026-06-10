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
Assert(CipherDecoder.DecodeByte(0x57) == 'i', "0x57 → i");
Assert(CipherDecoder.DecodeByte(0x58) == 'h', "0x58 → h");
Assert(CipherDecoder.DecodeByte(0xA0) == ' ', "0xA0 → space");
Assert(CipherDecoder.DecodeByte(0x77) == 'I', "0x77 → I");
Assert(CipherDecoder.DecodeByte(0x7F) == 'A', "0x7F → A");
var phrase = CipherDecoder.Decode(new byte[] { 0x5A, 0x73, 0x5B, 0x70 });
Assert(phrase == "jump", $"0x5A,73,5B,70 → '{phrase}'");

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
// 5 bytes of 0xAB
var rleResult = RleDecompressor.DecompressFormat01(new byte[] { 0x05, 0xAB }, 0);
Assert(rleResult[0] == 0xAB, $"rle[0]={rleResult[0]:X2}");
Assert(rleResult[4] == 0xAB, $"rle[4]={rleResult[4]:X2}");
Assert(rleResult[5] == 0, $"rle[5]={rleResult[5]}");

Console.WriteLine($"\n\nResults: {passed} passed, {failed} failed");
return failed > 0 ? 1 : 0;

// Inline the classes that don't need Godot
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
}

public class StorySlot { public byte StatusByte,FlagsLow,FlagsHigh,TimingNibble,CounterA,CounterB,StoryState,LatchMarker; }
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