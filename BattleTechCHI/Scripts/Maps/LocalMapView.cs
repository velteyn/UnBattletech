using Godot;
using BattleTechCHI.Core;
using BattleTechCHI.Data;

namespace BattleTechCHI.Maps;

/// <summary>
/// LocalMapView: renderizza le mappe locali (MAP1-14.MTP) usando Godot TileMap.
/// Mostra il tile buffer della mappa corrente con scroll centrato sul giocatore.
/// Ogni mappa usa il tileset BTTLTECH.ICN (o DESTRUCT.ICN per MAP11).
/// </summary>
public partial class LocalMapView : TileMap
{
    private GameState _state = null!;
    private TileManager _tileManager = null!;
    private MapData? _currentMap;
    private string _currentTileset = "BTTLTECH";

    private int _tilesetSourceId = 0;
    private const int ViewportW = 20; // tiles visibili in larghezza (320/16)
    private const int ViewportH = 12; // tiles visibili in altezza (200/16 - border)

    private const int LayerTerrain = 0;
    private const int LayerOverlay = 1;

    public override void _Ready()
    {
        _tileManager = GetNode<TileManager>("/root/GameLoop/TileManager");
        var gl = GetNode<GameLoop>("/root/GameLoop");
        _state = gl.State;

        SetLayerEnabled(LayerTerrain, true);
        SetLayerEnabled(LayerOverlay, true);
    }

    /// <summary>
    /// Carica e visualizza una mappa locale dal file .MTP originale.
    /// </summary>
    public void LoadMap(int mapId)
    {
        var mtpPath = ProjectSettings.GlobalizePath($"res://Assets/Maps/MAP{mapId}.bmp");
        // Il MapLoader lavora sui .MTP originali, ma qui usiamo i BMP pre-renderizzati
        // TODO Phase 2 full: implementare il loader .MTP nativo con tileset
        
        // Determina tileset in base alla mappa
        string tilesetName = mapId switch
        {
            11 => "DESTRUCT",
            14 => "STARLEAG",
            _ => "BTTLTECH"
        };

        _currentTileset = tilesetName;
        var bmpPath = ProjectSettings.GlobalizePath($"res://Assets/{tilesetName}.bmp");
        _tileManager.LoadTileSet(tilesetName, bmpPath, 16, 16);

        if (_tileManager.GetTile(tilesetName, 0) != null)
        {
            var ts = _tileManager.LoadTileSet(tilesetName, bmpPath);
            if (ts != null) TileSet = ts;
        }

        _currentMap = MapLoader.Load(
            ProjectSettings.GlobalizePath($"../../../MAP{mapId}.MTP"),
            mapId);

        if (_currentMap != null)
            RenderMap();
    }

    /// <summary>
    /// Renderizza la mappa corrente centrata sul giocatore.
    /// </summary>
    public void RenderMap()
    {
        if (_currentMap == null) return;
        Clear();

        int mapW = _currentMap.Width;
        int mapH = _currentMap.Height;
        int cols = GetTilesetCols();

        // Centro sul giocatore (dalle coordinate unit)
        int centerX = Mathf.Clamp(_state.CursorX, 0, mapW - 1);
        int centerY = Mathf.Clamp(_state.CursorY, 0, mapH - 1);

        int startX = Mathf.Clamp(centerX - ViewportW / 2, 0, Mathf.Max(0, mapW - ViewportW));
        int startY = Mathf.Clamp(centerY - ViewportH / 2, 0, Mathf.Max(0, mapH - ViewportH));

        for (int vy = 0; vy < ViewportH && startY + vy < mapH; vy++)
        {
            for (int vx = 0; vx < ViewportW && startX + vx < mapW; vx++)
            {
                int tileIdx = (startY + vy) * mapW + (startX + vx);
                byte tileId = tileIdx < _currentMap.TileData.Length ? _currentMap.TileData[tileIdx] : (byte)0;

                SetCell(LayerTerrain, new Vector2I(vx, vy), _tilesetSourceId,
                    new Vector2I(tileId % cols, tileId / cols));
            }
        }
    }

    private int GetTilesetCols()
    {
        var src = TileSet?.GetSource(_tilesetSourceId) as TileSetAtlasSource;
        if (src?.Texture == null) return 16;
        return (int)(src.Texture.GetWidth() / 16);
    }
}