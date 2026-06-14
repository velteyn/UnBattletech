using Godot;
using BattleTechCHI.Core;
using BattleTechCHI.Data;

namespace BattleTechCHI.Maps;

public partial class LocalMapView : TileMap
{
    private class NpcSpriteData
    {
        public string Name;
        public int TileX, TileY;
        public ColorRect? Rect;

        public NpcSpriteData(string name, int tx, int ty)
        {
            Name = name; TileX = tx; TileY = ty;
        }
    }
    private GameState _state = null!;
    private TileManager _tileManager = null!;
    private NpcController _npcController = null!;
    private MapData? _currentMap;
    private MapCursor? _cursor;
    private string _currentTileset = "BTTLTECH";

    private int _tilesetSourceId = 0;
    private const int ViewportW = 20;
    private const int ViewportH = 12;

    private const int LayerTerrain = 0;
    private const int LayerOverlay = 1;

    public MapData? CurrentMap => _currentMap;
    public NpcController NpcController => _npcController;

    // Building tile positions parsed from MTP variable blocks
    private (int x, int y, string name)[] _buildingTiles = System.Array.Empty<(int, int, string)>();

    // NPC sprite data for rendering
    private System.Collections.Generic.List<NpcSpriteData> _npcSprites = new();

    public override void _Ready()
    {
        _tileManager = GetNode<TileManager>("/root/GameLoop/TileManager");
        var gl = GetNode<GameLoop>("/root/GameLoop");
        _state = gl.State;

        _npcController = new NpcController();
        _npcController.Name = "NpcController";
        AddChild(_npcController);

        SetLayerEnabled(LayerTerrain, true);
        SetLayerEnabled(LayerOverlay, true);

        _cursor = new MapCursor();
        _cursor.Name = "MapCursor";
        AddChild(_cursor);
    }

    public void LoadMap(int mapId)
    {
        string tilesetName = mapId switch
        {
            11 => "DESTRUCT",
            14 => "STARLEAG",
            _ => "BTTLTECH"
        };

        _currentTileset = tilesetName;
        var bmpPath = ProjectSettings.GlobalizePath($"res://Assets/{tilesetName}.png");
        var ts = _tileManager.LoadTileSet(tilesetName, bmpPath, 16, 16);
        if (ts != null) TileSet = ts;

        _currentMap = MapLoader.Load(
            ProjectSettings.GlobalizePath($"../original/mtp/MAP{mapId}.MTP"),
            mapId);

        if (_currentMap != null)
        {
            ParseBuildingPositions(_currentMap);
            _npcController.Initialize(_currentMap);
            ClearNpcSprites();
            CreateNpcSprites(_currentMap);
            RenderMap();
        }
    }

    public void RenderMap()
    {
        if (_currentMap == null) return;
        Clear();

        int mapW = _currentMap.Width;
        int mapH = _currentMap.Height;
        int cols = GetTilesetCols();

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

        // Position cursor in viewport
        if (_cursor != null)
        {
            int cursorVx = _state.CursorX - startX;
            int cursorVy = _state.CursorY - startY;
            _cursor.SetTilePosition(cursorVx, cursorVy);
        }

        // Sync NPC positions from controller, then render
        SyncNpcPositions();
        foreach (var sprite in _npcSprites)
        {
            if (sprite.Rect == null) continue;
            int vx = sprite.TileX - startX;
            int vy = sprite.TileY - startY;
            if (vx >= 0 && vx < ViewportW && vy >= 0 && vy < ViewportH)
            {
                sprite.Rect.Visible = true;
                sprite.Rect.Position = new Vector2(vx * 16 + 1, vy * 16 + 1);
            }
            else
            {
                sprite.Rect.Visible = false;
            }
        }
    }

    /// <summary>
    /// Get building name at given tile position, or empty string if none.
    /// </summary>
    /// <summary>
    /// Sync NPC tile positions from the movement controller into sprite render data.
    /// </summary>
    private void SyncNpcPositions()
    {
        for (int i = 0; i < _npcSprites.Count && i < _npcController.Count; i++)
        {
            _npcSprites[i].TileX = _npcController.GetX(i);
            _npcSprites[i].TileY = _npcController.GetY(i);
        }
    }

    public string GetBuildingNameAtTile(int tileX, int tileY)
    {
        foreach (var (bx, by, name) in _buildingTiles)
        {
            if (bx == tileX && by == tileY)
                return name;
        }
        return "";
    }

    /// <summary>
    /// Parse building tile positions from parsed MapData.
    /// </summary>
    private void ParseBuildingPositions(MapData map)
    {
        var list = new System.Collections.Generic.List<(int, int, string)>();
        int mapW = map.Width;
        int mapH = map.Height;

        for (int i = 0; i < map.BuildingPositions.Length && i < map.BuildingNames.Length; i++)
        {
            int bx = map.BuildingPositions[i].x;
            int by = map.BuildingPositions[i].y;
            if (bx == 0 && by == 0) continue;

            string name = map.BuildingNames[i];
            if (string.IsNullOrEmpty(name)) continue;

            // Verify this tile is near a door tile (0x45)
            bool hasDoorNearby = false;
            for (int dy = -3; dy <= 3 && !hasDoorNearby; dy++)
            {
                for (int dx = -3; dx <= 3 && !hasDoorNearby; dx++)
                {
                    int tx = bx + dx;
                    int ty = by + dy;
                    if (tx >= 0 && tx < mapW && ty >= 0 && ty < mapH)
                    {
                        int idx = ty * mapW + tx;
                        if (idx < map.TileData.Length && map.TileData[idx] == 0x45)
                            hasDoorNearby = true;
                    }
                }
            }

            if (hasDoorNearby)
                list.Add((bx, by, name));
        }

        _buildingTiles = list.ToArray();
    }

    private void ClearNpcSprites()
    {
        foreach (var spr in _npcSprites)
        {
            if (spr.Rect != null && IsInstanceValid(spr.Rect))
                spr.Rect.QueueFree();
        }
        _npcSprites.Clear();
    }

    private void CreateNpcSprites(MapData map)
    {
        for (int i = 0; i < map.NpcPositions.Length && i < map.NpcNames.Length; i++)
        {
            int nx = map.NpcPositions[i].x;
            int ny = map.NpcPositions[i].y;
            if (nx == 0 && ny == 0) continue;

            string npcName = map.NpcNames[i];
            if (string.IsNullOrEmpty(npcName)) continue;

            var data = new NpcSpriteData(npcName, nx, ny);

            // Create a visible colored rectangle as NPC marker
            var rect = new ColorRect();
            rect.Name = $"NpcRect_{i}";
            rect.Color = new Color(0.2f, 0.8f, 0.2f, 0.9f);
            rect.Size = new Vector2(14, 14);
            rect.Position = new Vector2(-7, -7);
            var label = new Label();
            label.Text = npcName.Length > 6 ? npcName[..6] : npcName;
            label.Position = new Vector2(-10, 8);
            label.Scale = new Vector2(0.5f, 0.5f);
            rect.AddChild(label);
            data.Rect = rect;
            AddChild(rect);
            _npcSprites.Add(data);
        }
    }

    private int GetTilesetCols()
    {
        var src = TileSet?.GetSource(_tilesetSourceId) as TileSetAtlasSource;
        if (src?.Texture == null) return 16;
        return (int)(src.Texture.GetWidth() / 16);
    }
}