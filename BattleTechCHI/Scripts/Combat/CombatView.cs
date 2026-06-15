using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.Combat;

public partial class CombatView : TileMap
{
    private CombatState _combatState = null!;
    private GameState _gameState = null!;

    private const int GridW = 24;
    private const int GridH = 12;
    private const int TileSize = 16;
    private const int ViewportTilesX = 15;
    private const int ViewportTilesY = 12;

    private const int LayerTerrain = 0;
    private const int LayerFog = 1;
    private const int LayerOverlay = 2;

    private Sprite2D _cursor = null!;
    private ColorRect _cursorRect = null!;
    private Sprite2D _targetReticle = null!;
    private Godot.Collections.Array<Sprite2D> _unitSprites = new();
    private Godot.Collections.Array<ColorRect> _fogRects = new();
    private Texture2D _mechSheet = null!;
    private Texture2D _infantryTexture = null!;

    private int _prevCursorX = -1, _prevCursorY = -1;
    private int _tilesetCols = 16;

    public CombatState? CombatState => _combatState;

    public override void _Ready()
    {
        SetLayerEnabled(LayerTerrain, true);
        SetLayerEnabled(LayerFog, true);
        SetLayerEnabled(LayerOverlay, true);

        _mechSheet = ResourceLoader.Load<Texture2D>("res://Assets/Sprites/MECHSHAP_0.png");
        if (_mechSheet == null)
            _mechSheet = ResourceLoader.Load<Texture2D>("res://Assets/MECHSHAP.png");

        var infantryImg = Image.Create(TileSize, TileSize, false, Image.Format.Rgba8);
        infantryImg.Fill(new Color(0, 1, 0, 1));
        _infantryTexture = ImageTexture.CreateFromImage(infantryImg);

        _cursor = new Sprite2D();
        _cursor.Name = "CombatCursor";
        var cursorImg = Image.Create(TileSize, TileSize, false, Image.Format.Rgba8);
        for (int y = 0; y < TileSize; y++)
            for (int x = 0; x < TileSize; x++)
            {
                if (x == 0 || x == TileSize - 1 || y == 0 || y == TileSize - 1)
                    cursorImg.SetPixel(x, y, new Color(0, 1, 0, 1));
                else
                    cursorImg.SetPixel(x, y, new Color(0, 0, 0, 0));
            }
        _cursor.Texture = ImageTexture.CreateFromImage(cursorImg);
        _cursor.Modulate = new Color(0, 1, 0, 0.8f);
        AddChild(_cursor);
        _cursor.Hide();

        _targetReticle = new Sprite2D();
        _targetReticle.Name = "TargetReticle";
        var retImg = Image.Create(TileSize, TileSize, false, Image.Format.Rgba8);
        for (int y = 0; y < TileSize; y++)
            for (int x = 0; x < TileSize; x++)
            {
                bool onCircle = (x - 7) * (x - 7) + (y - 7) * (y - 7) >= 25 &&
                                (x - 7) * (x - 7) + (y - 7) * (y - 7) <= 45;
                if (onCircle || x == 0 || x == TileSize - 1 || y == 0 || y == TileSize - 1)
                    retImg.SetPixel(x, y, new Color(1, 0, 0, 1));
                else
                    retImg.SetPixel(x, y, new Color(0, 0, 0, 0));
            }
        _targetReticle.Texture = ImageTexture.CreateFromImage(retImg);
        _targetReticle.Modulate = new Color(1, 0.3f, 0.3f, 0.8f);
        AddChild(_targetReticle);
        _targetReticle.Hide();

        SetLayerModulate(LayerFog, new Color(0, 0, 0, 0.6f));

        var ts = new TileSet();
        var src = new TileSetAtlasSource();
        src.Texture = _mechSheet;
        src.TextureRegionSize = new Vector2I(TileSize, TileSize);
        ts.AddSource(src, 0);
        TileSet = ts;

        if (_mechSheet != null)
            _tilesetCols = Mathf.Max(1, (int)(_mechSheet.GetWidth() / TileSize));
    }

    public void SetState(CombatState state, GameState gameState)
    {
        _combatState = state;
        _gameState = gameState;
    }

    public void RenderCombat()
    {
        if (_combatState == null || !_combatState.Active) return;

        Clear();
        ClearUnitSprites();
        ClearFog();

        int mapW = GridW, mapH = GridH;

        int centerX = Mathf.Clamp(_gameState.CursorX, 0, mapW - 1);
        int centerY = Mathf.Clamp(_gameState.CursorY, 0, mapH - 1);

        int startX = Mathf.Clamp(centerX - ViewportTilesX / 2, 0, Mathf.Max(0, mapW - ViewportTilesX));
        int startY = Mathf.Clamp(centerY - ViewportTilesY / 2, 0, Mathf.Max(0, mapH - ViewportTilesY));

        for (int vy = 0; vy < ViewportTilesY; vy++)
        {
            for (int vx = 0; vx < ViewportTilesX; vx++)
            {
                int gx = startX + vx;
                int gy = startY + vy;
                if (gx >= mapW || gy >= mapH) continue;

                byte tileId = (byte)(((gy * 3 + gx) % 8) + 1);
                SetCell(LayerTerrain, new Vector2I(vx, vy), 0, new Vector2I(tileId % _tilesetCols, tileId / _tilesetCols));

                bool fogged = (gy < GridH && gx < GridW) &&
                    (_combatState.FogGridA[gy, gx] == 0x02 ||
                     _combatState.FogGridB[gy, gx] == 0x02);
                if (fogged)
                {
                    SetCell(LayerFog, new Vector2I(vx, vy), 0, new Vector2I(0, 0));
                }
            }
        }

        for (int slot = 0; slot < 24; slot++)
        {
            if (!_combatState.IsAlive(slot)) continue;
            int ux = _combatState.Units[slot].UnitX;
            int uy = _combatState.Units[slot].UnitY;
            int vx = ux - startX;
            int vy = uy - startY;
            if (vx < 0 || vx >= ViewportTilesX || vy < 0 || vy >= ViewportTilesY) continue;

            var sprite = new Sprite2D();
            sprite.Name = $"Unit_{slot}";

            if (_combatState.IsPlayer(slot))
            {
                sprite.Texture = _mechSheet;
                sprite.RegionEnabled = true;
                int frame = slot % 4;
                sprite.RegionRect = new Rect2(frame * TileSize, 0, TileSize, TileSize);
                sprite.Modulate = new Color(0.6f, 0.8f, 1.0f, 1.0f);
            }
            else if (_combatState.IsEnemyInfantry(slot))
            {
                sprite.Texture = _infantryTexture;
                sprite.Modulate = new Color(1, 0.3f, 0.3f, 0.9f);
            }
            else
            {
                sprite.Texture = _mechSheet;
                sprite.RegionEnabled = true;
                int frame = 4 + (slot % 3);
                sprite.RegionRect = new Rect2(frame * TileSize, 0, TileSize, TileSize);
                sprite.Modulate = new Color(1, 0.4f, 0.4f, 1.0f);
            }

            sprite.Position = new Vector2(vx * TileSize + TileSize / 2, vy * TileSize + TileSize / 2);
            AddChild(sprite);
            _unitSprites.Add(sprite);
        }

        int cvx = _gameState.CursorX - startX;
        int cvy = _gameState.CursorY - startY;
        if (cvx >= 0 && cvx < ViewportTilesX && cvy >= 0 && cvy < ViewportTilesY)
        {
            _cursor.Position = new Vector2(cvx * TileSize, cvy * TileSize);
            _cursor.Show();
        }
        else
        {
            _cursor.Hide();
        }

        if (_combatState.CurrentTargetId >= 0 && _combatState.IsAlive(_combatState.CurrentTargetId))
        {
            int tx = _combatState.Units[_combatState.CurrentTargetId].UnitX - startX;
            int ty = _combatState.Units[_combatState.CurrentTargetId].UnitY - startY;
            if (tx >= 0 && tx < ViewportTilesX && ty >= 0 && ty < ViewportTilesY)
            {
                _targetReticle.Position = new Vector2(tx * TileSize, ty * TileSize);
                _targetReticle.Show();
            }
            else
                _targetReticle.Hide();
        }
        else
            _targetReticle.Hide();

        _prevCursorX = _gameState.CursorX;
        _prevCursorY = _gameState.CursorY;
    }

    private void ClearUnitSprites()
    {
        foreach (var sprite in _unitSprites)
        {
            if (IsInstanceValid(sprite))
                sprite.QueueFree();
        }
        _unitSprites.Clear();
    }

    private void ClearFog()
    {
        foreach (var rect in _fogRects)
        {
            if (IsInstanceValid(rect))
                rect.QueueFree();
        }
        _fogRects.Clear();
    }

    public Vector2I GetGridCoordsAtViewport(int viewX, int viewY)
    {
        int mapW = GridW, mapH = GridH;
        int centerX = Mathf.Clamp(_gameState.CursorX, 0, mapW - 1);
        int centerY = Mathf.Clamp(_gameState.CursorY, 0, mapH - 1);
        int startX = Mathf.Clamp(centerX - ViewportTilesX / 2, 0, Mathf.Max(0, mapW - ViewportTilesX));
        int startY = Mathf.Clamp(centerY - ViewportTilesY / 2, 0, Mathf.Max(0, mapH - ViewportTilesY));
        return new Vector2I(startX + viewX, startY + viewY);
    }
}
