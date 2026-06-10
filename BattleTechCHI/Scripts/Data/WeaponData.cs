namespace BattleTechCHI.Data;

/// <summary>
/// Dati arma dal gioco originale (33 armi documentate).
/// </summary>
public class WeaponData
{
    public static Weapon[] Weapons { get; } = new[]
    {
        new Weapon("Small Laser",     1, 0,  3,  1,  1,  5,  0, 0),
        new Weapon("Medium Laser",    2, 0,  5,  3,  3,  8,  0, 0),
        new Weapon("Large Laser",     3, 0,  8,  8,  5,  12, 0, 0),
        new Weapon("PPC",             4, 0,  10, 10, 7,  15, 0, 0),
        new Weapon("AC/2",            5, 0,  2,  2,  4,  8,  0, 0),
        new Weapon("AC/5",            6, 0,  5,  5,  6,  12, 0, 0),
        new Weapon("AC/10",           7, 0,  10, 10, 8,  16, 0, 0),
        new Weapon("AC/20",           8, 0,  20, 20, 9,  18, 0, 0),
        new Weapon("SRM-2",           9, 1,  2,  2,  2,  6,  0, 0),
        new Weapon("SRM-4",           10, 1, 4,  4,  3,  8,  0, 0),
        new Weapon("SRM-6",           11, 1, 6,  6,  4,  10, 0, 0),
        new Weapon("LRM-5",           12, 1, 5,  5,  4,  8,  0, 0),
        new Weapon("LRM-10",          13, 1, 10, 10, 5,  10, 0, 0),
        new Weapon("LRM-15",          14, 1, 15, 15, 6,  12, 0, 0),
        new Weapon("LRM-20",          15, 1, 20, 20, 7,  14, 0, 0),
        new Weapon("Machine Gun",     16, 0, 2,  1,  1,  3,  0, 0),
        new Weapon("Flamer",          17, 0, 2,  0,  2,  4,  0, 0),
        new Weapon("Small Laser (NPC)",18,0, 3,  1,  1,  5,  0, 0),
        new Weapon("Medium Laser (NPC)",19,0,5,  3,  3,  8,  0, 0),
        new Weapon("Large Laser (NPC)",20,0, 8,  8,  5,  12, 0, 0),
        new Weapon("PPC (NPC)",        21,0, 10, 10, 7,  15, 0, 0),
        new Weapon("AC/2 (NPC)",       22,0, 2,  2,  4,  8,  0, 0),
        new Weapon("AC/5 (NPC)",       23,0, 5,  5,  6,  12, 0, 0),
        new Weapon("AC/10 (NPC)",      24,0, 10, 10, 8,  16, 0, 0),
        new Weapon("AC/20 (NPC)",      25,0, 20, 20, 9,  18, 0, 0),
        new Weapon("SRM-2 (NPC)",      26,1, 2,  2,  2,  6,  0, 0),
        new Weapon("SRM-4 (NPC)",      27,1, 4,  4,  3,  8,  0, 0),
        new Weapon("SRM-6 (NPC)",      28,1, 6,  6,  4,  10, 0, 0),
        new Weapon("LRM-5 (NPC)",      29,1, 5,  5,  4,  8,  0, 0),
        new Weapon("LRM-10 (NPC)",     30,1, 10, 10, 5,  10, 0, 0),
        new Weapon("LRM-15 (NPC)",     31,1, 15, 15, 6,  12, 0, 0),
        new Weapon("LRM-20 (NPC)",     32,1, 20, 20, 7,  14, 0, 0),
        new Weapon("Kick (Physical)",  33,0, 5,  0,  1,  1,  0, 1),
    };
}

public record Weapon(
    string Name,
    int Id,
    int AmmoType,       // 0=energy/ballistic, 1=missile
    int Damage,
    int HeatGenerated,
    int MinRange,
    int MaxRange,
    int AccuracyBonus,
    int IsPhysicalKick
);