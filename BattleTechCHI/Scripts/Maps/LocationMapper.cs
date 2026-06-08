using Godot;

namespace BattleTechCHI.Maps;

/// <summary>
/// LocationMapper: traduce coordinate world map in BLD index.
/// Usa la tabella di traduzione a 22 entry dal gioco originale (DS:0x4602).
/// </summary>
public static class LocationMapper
{
    /// <summary>
    /// Mappa nome file BLD → coordinate world map (centro edificio).
    /// Basata sulla RE: tabella a 0x4602 + filenames a 0xCC30.
    /// </summary>
    private static readonly (string bldName, int tileX, int tileY, int mapId)[] Locations = new[]
    {
        ("TRAINING",  26,  5, 1),  // Training Center / Citadel
        ("CITADEL",   26,  6, 1),
        ("BARRACKS",  28, 11, 2),  // Barracks
        ("BARRACK2",  29, 11, 2),  // Barracks 2
        ("COMSTAR",   27,  9, 2),  // ComStar
        ("INSTRUCT",  27,  5, 1),  // Instruction
        ("GARAGE",    29, 12, 2),  // Garage
        ("HOSPITAL",  28, 12, 2),  // Hospital
        ("WEAPON",    29, 10, 2),  // Weapon shop
        ("WEAPON2",   30, 10, 2),  // Weapon shop 2
        ("ARMOR",     28,  9, 2),  // Armor shop
        ("CLOTHES",   27, 10, 2),  // Clothes shop
        ("LOUNGE",    30, 11, 2),  // Lounge
        ("THEATER",   27, 12, 2),  // Theater/Viewdisk
        ("VIEWDISK",  27, 12, 2),  // Viewdisk
        ("JAIL",       5, 54, 3),  // Jail
        ("MAYOR",      5, 55, 3),  // Mayor
        ("FINDIT",    55,  8, 4),  // Findit (cache island)
        ("FROB",      32, 18, 5),  // Frob
        ("PARTY",     28, 10, 2),  // Party
        ("HUT",       10, 10, 6),  // Hut
        ("ENTRANCE",  33, 49, 7),  // Cave entrance
        ("ARENA",     30,  8, 2),  // Arena
        ("REPAIR",    28, 13, 2),  // Repair shop
        ("WINSCENE",  26,  5, 1),  // Win scene (citadel end)
        ("ENDMECH",   26,  5, 1),  // End mech
    };

    /// <summary>
    /// Trova il BLD index per una data posizione world map.
    /// </summary>
    public static int? GetBldIndex(int tileX, int tileY)
    {
        for (int i = 0; i < Locations.Length; i++)
        {
            var loc = Locations[i];
            if (loc.tileX == tileX && loc.tileY == tileY)
                return i;
        }
        return null;
    }

    /// <summary>
    /// Ottiene il nome BLD per un dato index.
    /// </summary>
    public static string GetBldName(int index)
    {
        if (index >= 0 && index < Locations.Length)
            return Locations[index].bldName;
        return "";
    }

    /// <summary>
    /// Ottiene la mappa locale associata a un BLD.
    /// </summary>
    public static int? GetMapId(int tileX, int tileY)
    {
        for (int i = 0; i < Locations.Length; i++)
        {
            var loc = Locations[i];
            if (loc.tileX == tileX && loc.tileY == tileY)
                return loc.mapId;
        }
        return null;
    }

    /// <summary>
    /// Restituisce la prima posizione world map associata a un mapId locale.
    /// Usata per calcolare il punto di uscita dalla local map verso la world map.
    /// </summary>
    public static (int tileX, int tileY)? GetWorldTileForMap(int mapId)
    {
        for (int i = 0; i < Locations.Length; i++)
        {
            if (Locations[i].mapId == mapId)
                return (Locations[i].tileX, Locations[i].tileY);
        }
        return null;
    }
}