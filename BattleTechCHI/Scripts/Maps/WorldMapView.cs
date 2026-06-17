using Godot;
using BattleTechCHI.Core;
using BattleTechCHI.Data;

namespace BattleTechCHI.Maps;

/// <summary>
/// WorldMapView: renderizza la world map (Pacifica, 64×64) usando Godot TileMap.
/// Mostra un viewport 8×8 tile centrato sul cursore.
/// Include fog of war dalla bitmask 128×128.
/// </summary>
public partial class WorldMapView : TileMap
{
    private WorldMapData _worldData = null!;
    private GameState _state = null!;
    private TileManager _tileManager = null!;

    private int _tilesetSourceId = 0;
    private int _tileWidth = 16;
    private int _tileHeight = 16;
    private MapCursor? _cursor;

    // Viewport visibile: 8×8 tile
    private const int ViewportW = 8;
    private const int ViewportH = 8;

    // Layer IDs
    private const int LayerTerrain = 0;
    private const int LayerFog = 1;

    public override void _Ready()
    {
        _tileManager = GetNode<TileManager>("/root/GameLoop/TileManager");
        _worldData = new WorldMapData();
        AddChild(_worldData);
        _worldData.Initialize();

        var gl = GetNode<GameLoop>("/root/GameLoop");
        _state = gl.State;

        // Carica tileset MAP.ICN per la world map
        var mapPath = ProjectSettings.GlobalizePath("res://Assets/MAP.png");
        var tileSet = _tileManager.LoadTileSet("MAP", mapPath, 16, 16);

        if (tileSet != null)
        {
            TileSet = tileSet;
            _tilesetSourceId = 0;
        }
        else
        {
            // Fallback: create a simple colored tileset
            GD.PrintErr("MAP.png not found, using fallback tileset");
            CreateFallbackTileset();
        }

        // Configura layers
        SetLayerEnabled(LayerTerrain, true);
        SetLayerEnabled(LayerFog, true);
        SetLayerModulate(LayerFog, new Color(0, 0, 0, 0.7f));

        _cursor = new MapCursor { Name = "MapCursor" };
        AddChild(_cursor);

        RenderViewport();
    }

    /// <summary>
    /// Renderizza il viewport 8×8 centrato sul cursore.
    /// </summary>
    public void RenderViewport()
    {
        Clear();

        var (cursorTileX, cursorTileY) = GetCursorTileCenter();

        // Offset per centrare il viewport: il cursore va al centro 3,3 del viewport 8×8
        int startX = cursorTileX - 3;
        int startY = cursorTileY - 3;

        // Assicura che il viewport sia dentro i bordi della mappa
        startX = Mathf.Clamp(startX, 0, 64 - ViewportW);
        startY = Mathf.Clamp(startY, 0, 64 - ViewportH);

        for (int vy = 0; vy < ViewportH; vy++)
        {
            for (int vx = 0; vx < ViewportW; vx++)
            {
                int wx = startX + vx;
                int wy = startY + vy;

                byte tileId = _worldData.GetTile(wx, wy);

                // Tile terra
                SetCell(LayerTerrain, new Vector2I(vx, vy), _tilesetSourceId, 
                    new Vector2I(tileId % GetTilesetCols(), tileId / GetTilesetCols()));

                // Fog of war: nascondi se non visibile
                if (!_worldData.IsVisible(wx, wy))
                {
                    SetCell(LayerFog, new Vector2I(vx, vy), _tilesetSourceId,
                        new Vector2I(0, 0)); // tile nero
                }
            }
        }

        // Posiziona il cursore
        int cursorVx = cursorTileX - startX;
        int cursorVy = cursorTileY - startY;
        DrawCursor(cursorVx, cursorVy);
    }

    /// <summary>
    /// Ottiene le coordinate tile del cursore dalla formula originale:
    /// Tile X = (wA44B & 0x7F) >> 1
    /// </summary>
    private (int x, int y) GetCursorTileCenter()
    {
        int tileX = (_state.CursorX & 0x7F) >> 1;
        int tileY = (_state.CursorY & 0x7F) >> 1;
        return (tileX, tileY);
    }

    private void DrawCursor(int vx, int vy)
    {
        if (_cursor != null)
            _cursor.SetTilePosition(vx, vy);
    }

    private int GetTilesetCols()
    {
        var src = TileSet?.GetSource(_tilesetSourceId) as TileSetAtlasSource;
        if (src?.Texture == null) return 16;
        return (int)(src.Texture.GetWidth() / _tileWidth);
    }

    /// <summary>
    /// Reinitialize the world map from template (called from BLD CondStateAction).
    /// </summary>
    public void Reinitialize()
    {
        _worldData.Initialize();
        RenderViewport();
    }

    private void CreateFallbackTileset()
    {
        // Crea un tileset minimale colorato per testing
        var ts = new TileSet();
        var img = Image.CreateEmpty(256, 16, false, Image.Format.Rgba8);
        for (int i = 0; i < 16; i++)
        {
            byte c = (byte)(i * 17);
            for (int py = 0; py < 16; py++)
                for (int px = 0; px < 16; px++)
                    img.SetPixel(i * 16 + px, py, Color.FromHtml($"#{c:X2}{c:X2}{c:X2}"));
        }
        var tex = ImageTexture.CreateFromImage(img);
        var src = new TileSetAtlasSource { Texture = tex, TextureRegionSize = new Vector2I(16, 16) };
        for (int i = 0; i < 16; i++)
            src.CreateTile(new Vector2I(i, 0));
        ts.AddSource(src, 0);
        TileSet = ts;
    }
}