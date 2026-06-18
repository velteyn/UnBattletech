using Godot;
using System.Collections.Generic;
using BattleTechCHI.Maps;

namespace BattleTechCHI.UI;

public partial class ViewportManager : Node2D
{
    private ViewportLayout _currentLayout = ViewportLayout.WorldMap;
    private bool _narrowPanel;
    private readonly Dictionary<string, ViewportRegion> _regions = new();
    private readonly Dictionary<string, Node> _contentMap = new();
    private readonly List<Node> _borderNodes = new();
    private TileManager? _tileManager;

    private const int PanelWide = 80;
    private const int PanelNarrow = 16;
    private const int ViewportWide = 240;
    private const int ViewportNarrow = 304;
    private const int ViewportHeight = 192;
    private const int BottomBarHeight = 8;

    public ViewportLayout CurrentLayout => _currentLayout;
    public bool NarrowPanel => _narrowPanel;
    public ViewportRegion? GetRegion(string name) =>
        _regions.GetValueOrDefault(name);

    public void SetTileManager(TileManager tm)
    {
        _tileManager = tm;
    }

    public void SetLayout(ViewportLayout layout, bool narrow = false)
    {
        if (layout == _currentLayout && narrow == _narrowPanel && _regions.Count > 0)
            return;

        _currentLayout = layout;
        _narrowPanel = narrow;

        ClearRegions();
        ClearBorderNodes();

        int panelW = narrow ? PanelNarrow : PanelWide;
        int viewW = narrow ? ViewportNarrow : ViewportWide;
        int viewX = narrow ? PanelNarrow : PanelWide;

        CreateRegion("LeftPanel", new Rect2(0, 0, panelW, 200), 0, new Color(0x00, 0x00, 0x55));
        CreateRegion("Viewport", new Rect2(viewX, 0, viewW, ViewportHeight), 1, Colors.Black);
        CreateRegion("BottomBar", new Rect2(0, ViewportHeight, 320, BottomBarHeight), 2, new Color(0x55, 0x55, 0x55));

        ReassignContent();
        DrawBorders();
    }

    private void CreateRegion(string name, Rect2 rect, int zIndex, Color bgColor)
    {
        var region = new ViewportRegion
        {
            RegionName = name,
            ShowBorder = true,
            Name = $"Region_{name}",
            ZIndex = zIndex,
            MouseFilter = Control.MouseFilterEnum.Ignore,
        };
        region.SetRegionRect(rect);
        region.ClipContents = true;

        var regionBg = new ColorRect
        {
            Color = bgColor,
            Size = rect.Size,
            MouseFilter = Control.MouseFilterEnum.Ignore,
        };
        region.AddChild(regionBg);

        AddChild(region);
        _regions[name] = region;
    }

    public void AssignContent(Node node, string regionName)
    {
        var existingKey = FindContentKey(node);
        if (existingKey != null)
            _contentMap.Remove(existingKey);

        _contentMap[regionName] = node;
        UpdateNodeVisibility(node, regionName);

        var region = GetRegion(regionName);
        if (region != null)
            ReparentToRegion(node, region);
    }

    public void RemoveContent(Node node)
    {
        var key = FindContentKey(node);
        if (key != null)
            _contentMap.Remove(key);
    }

    private void ClearRegions()
    {
        foreach (var region in _regions.Values)
        {
            foreach (var (key, node) in _contentMap)
            {
                if (node.GetParent() == region)
                {
                    region.RemoveChild(node);
                    AddChild(node);
                }
            }
            region.QueueFree();
        }
        _regions.Clear();
    }

    private void ClearBorderNodes()
    {
        foreach (var node in _borderNodes)
            node.QueueFree();
        _borderNodes.Clear();
    }

    private void ReassignContent()
    {
        foreach (var (regionName, node) in _contentMap)
        {
            var region = GetRegion(regionName);
            if (region != null)
                ReparentToRegion(node, region);
            UpdateNodeVisibility(node, regionName);
        }
    }

    private void UpdateNodeVisibility(Node node, string regionName)
    {
        if (regionName == "LeftPanel" && node is CanvasItem ci)
            ci.Visible = !_narrowPanel;
    }

    private static void ReparentToRegion(Node node, ViewportRegion region)
    {
        var currentParent = node.GetParent();
        if (currentParent == region)
            return;

        if (currentParent is Node parent)
            parent.RemoveChild(node);

        region.AddChild(node);

        if (node is Control c)
            c.Position = Vector2.Zero;
        else if (node is Node2D n2d)
            n2d.Position = Vector2.Zero;
    }

    private string? FindContentKey(Node node)
    {
        foreach (var (key, val) in _contentMap)
        {
            if (val == node)
                return key;
        }
        return null;
    }

    private void DrawBorders()
    {
        if (_narrowPanel)
        {
            // Narrow: just a thin decorative column on the left edge
            // No vertical separator (viewport butts up against the narrow strip)
            DrawHorizontalSeparator();
            DrawLeftEdgeDecoration();
            return;
        }

        // Wide: full decorative strip + separators
        DrawLeftEdgeDecoration();
        DrawVerticalSeparator();
        DrawHorizontalSeparator();
    }

    private void DrawLeftEdgeDecoration()
    {
        if (_tileManager == null) return;

        int[] decorTiles =
        [
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            10, 11, 12, 13, 14, 15, 16, 17,
        ];

        for (int i = 0; i < decorTiles.Length; i++)
        {
            int y = i * 16;
            if (y >= 200) break;

            var tile = _tileManager.GetBorderTile(decorTiles[i]);
            if (tile == null) continue;

            var texRect = new TextureRect
            {
                Texture = tile,
                ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
                StretchMode = TextureRect.StretchModeEnum.Keep,
                Size = new Vector2(16, 16),
                Position = new Vector2(0, y),
                ZIndex = 50,
                MouseFilter = Control.MouseFilterEnum.Ignore,
            };
            AddChild(texRect);
            _borderNodes.Add(texRect);
        }
    }

    private void DrawVerticalSeparator()
    {
        if (_tileManager == null)
        {
            DrawColorRectBorder(new Rect2(76, 0, 4, 200));
            return;
        }

        var tile = _tileManager.GetBorderTile(6);
        if (tile == null)
        {
            DrawColorRectBorder(new Rect2(76, 0, 4, 200));
            return;
        }

        for (int i = 0; i < 13; i++)
        {
            int y = i * 16;
            if (y >= 200) break;

            var texRect = new TextureRect
            {
                Texture = tile,
                ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
                StretchMode = TextureRect.StretchModeEnum.Keep,
                Size = new Vector2(4, 16),
                Position = new Vector2(76, y),
                ZIndex = 100,
                MouseFilter = Control.MouseFilterEnum.Ignore,
            };
            AddChild(texRect);
            _borderNodes.Add(texRect);
        }
    }

    private void DrawHorizontalSeparator()
    {
        if (_tileManager == null)
        {
            DrawColorRectBorder(new Rect2(0, 188, 320, 4));
            return;
        }

        var tile = _tileManager.GetBorderTile(6);
        if (tile == null)
        {
            DrawColorRectBorder(new Rect2(0, 188, 320, 4));
            return;
        }

        for (int i = 0; i < 20; i++)
        {
            int x = i * 16;
            if (x >= 320) break;

            var texRect = new TextureRect
            {
                Texture = tile,
                ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
                StretchMode = TextureRect.StretchModeEnum.Keep,
                Size = new Vector2(16, 4),
                Position = new Vector2(x, 188),
                ZIndex = 100,
                MouseFilter = Control.MouseFilterEnum.Ignore,
            };
            AddChild(texRect);
            _borderNodes.Add(texRect);
        }
    }

    private void DrawColorRectBorder(Rect2 rect)
    {
        var line = new ColorRect
        {
            Color = new Color(0x55, 0x55, 0x55),
            Size = rect.Size,
            Position = rect.Position,
            ZIndex = 100,
            MouseFilter = Control.MouseFilterEnum.Ignore,
        };
        AddChild(line);
        _borderNodes.Add(line);

        var highlight = new ColorRect
        {
            Color = new Color(0xAA, 0xAA, 0xAA),
            Size = new Vector2(rect.Size.X > rect.Size.Y ? rect.Size.X : 1,
                               rect.Size.Y > rect.Size.X ? rect.Size.Y : 1),
            Position = rect.Position + (rect.Size.X > rect.Size.Y ? Vector2.Down : Vector2.Right),
            ZIndex = 101,
            MouseFilter = Control.MouseFilterEnum.Ignore,
        };
        AddChild(highlight);
        _borderNodes.Add(highlight);
    }
}
