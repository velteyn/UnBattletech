using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.Maps;

/// <summary>
/// TileManager: carica e gestisce i tileset del gioco.
/// I tileset sono estratti dai file .ICN e salvati come BMP.
/// Ogni tile è 16×16 pixel, palette EGA 16-colori.
/// </summary>
public partial class TileManager : Node
{
    private Dictionary<string, TileSet> _tileSets = new();
    private Dictionary<string, AtlasTexture> _tileAtlases = new();

    /// <summary>
    /// Carica un tileset da un file BMP e lo converte in Godot TileSet.
    /// </summary>
    public TileSet? LoadTileSet(string name, string bmpPath, int tileWidth = 16, int tileHeight = 16)
    {
        if (_tileSets.ContainsKey(name))
            return _tileSets[name];

        if (!File.Exists(bmpPath))
        {
            GD.PrintErr($"Tileset not found: {bmpPath}");
            return null;
        }

        var image = Image.LoadFromFile(bmpPath);
        if (image == null)
        {
            GD.PrintErr($"Failed to load tileset image: {bmpPath}");
            return null;
        }

        // Crea texture dal BMP
        var texture = ImageTexture.CreateFromImage(image);

        // Crea TileSet
        var tileSet = new TileSet();
        var source = new TileSetAtlasSource();
        source.Texture = texture;
        source.TextureRegionSize = new Vector2I(tileWidth, tileHeight);

        // Calcola quanti tile stanno nell'immagine
        int cols = image.GetWidth() / tileWidth;
        int rows = image.GetHeight() / tileHeight;
        int totalTiles = cols * rows;

        for (int i = 0; i < totalTiles; i++)
        {
            int x = (i % cols) * tileWidth;
            int y = (i / cols) * tileHeight;
            source.CreateTile(new Vector2I(i % cols, i / cols));
        }

        tileSet.AddSource(source, 0);
        _tileSets[name] = tileSet;

        GD.Print($"TileSet '{name}' loaded: {totalTiles} tiles ({cols}×{rows})");
        return tileSet;
    }

    /// <summary>
    /// Restituisce una texture per un tile specifico da un tileset.
    /// </summary>
    public AtlasTexture? GetTile(string setName, int tileId)
    {
        var key = $"{setName}_{tileId}";
        if (_tileAtlases.TryGetValue(key, out var existing))
            return existing;

        if (!_tileSets.TryGetValue(setName, out var tileSet))
            return null;

        var source = tileSet.GetSource(0) as TileSetAtlasSource;
        if (source == null) return null;

        int cols = (int)(source.Texture.GetWidth() / 16);
        int tileX = tileId % cols;
        int tileY = tileId / cols;

        var atlas = new AtlasTexture
        {
            Atlas = source.Texture,
            Region = new Rect2(tileX * 16, tileY * 16, 16, 16),
            FilterClip = true,
            Margin = new Rect2()
        };

        _tileAtlases[key] = atlas;
        return atlas;
    }

    /// <summary>
    /// Crea una texture per un singolo tile dal tileset MAP.ICN (world map).
    /// </summary>
    public AtlasTexture? GetWorldMapTile(int tileId)
    {
        return GetTile("MAP", tileId);
    }

    /// <summary>
    /// Crea una texture per un tile dal tileset BTTLTECH.ICN (local maps).
    /// </summary>
    public AtlasTexture? GetLocalTile(int tileId)
    {
        return GetTile("BTTLTECH", tileId);
    }

    /// <summary>
    /// Ottiene il tile per la palette custom dei bordi.
    /// </summary>
    public AtlasTexture? GetBorderTile(int tileId)
    {
        return GetTile("BTBORDER", tileId);
    }
}