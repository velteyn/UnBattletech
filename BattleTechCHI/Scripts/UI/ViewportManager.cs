using Godot;
using System.Collections.Generic;

namespace BattleTechCHI.UI;

public partial class ViewportManager : Node2D
{
    private ViewportLayout _currentLayout = ViewportLayout.WorldMap;
    private readonly Dictionary<string, ViewportRegion> _regions = new();
    private readonly Dictionary<string, Node> _contentMap = new();
    private readonly List<ColorRect> _borderLines = new();

    // Layout definitions: regionName → (Rect2, zIndex, bgColor)
    private static readonly Dictionary<ViewportLayout, (string name, Rect2 rect, int zIndex, Color bgColor)[]> LayoutDefs = new()
    {
        [ViewportLayout.WorldMap] = new[]
        {
            ("LeftPanel", new Rect2(0, 0, 80, 200), 0, new Color(0x00, 0x00, 0x55)),
            ("Viewport", new Rect2(80, 0, 240, 192), 1, Colors.Black),
            ("BottomBar", new Rect2(0, 192, 320, 8), 2, new Color(0x55, 0x55, 0x55)),
        },
        [ViewportLayout.LocalTiles] = new[]
        {
            ("LeftPanel", new Rect2(0, 0, 80, 200), 0, new Color(0x00, 0x00, 0x55)),
            ("Viewport", new Rect2(80, 0, 240, 192), 1, Colors.Black),
            ("BottomBar", new Rect2(0, 192, 320, 8), 2, new Color(0x55, 0x55, 0x55)),
        },
        [ViewportLayout.TextScreen] = new[]
        {
            ("LeftPanel", new Rect2(0, 0, 80, 200), 0, new Color(0x00, 0x00, 0x55)),
            ("Viewport", new Rect2(80, 0, 240, 192), 1, Colors.Black),
            ("BottomBar", new Rect2(0, 192, 320, 8), 2, new Color(0x55, 0x55, 0x55)),
        },
        [ViewportLayout.BuildingName] = new[]
        {
            ("LeftPanel", new Rect2(0, 0, 80, 200), 0, new Color(0x00, 0x00, 0x55)),
            ("Viewport", new Rect2(80, 0, 240, 192), 1, Colors.Black),
            ("BottomBar", new Rect2(0, 192, 320, 8), 2, new Color(0x55, 0x55, 0x55)),
        },
        [ViewportLayout.Combat] = new[]
        {
            ("LeftPanel", new Rect2(0, 0, 80, 200), 0, new Color(0x00, 0x00, 0x55)),
            ("Viewport", new Rect2(80, 0, 240, 192), 1, Colors.Black),
            ("BottomBar", new Rect2(0, 192, 320, 8), 2, new Color(0x55, 0x55, 0x55)),
        },
        [ViewportLayout.Stats] = new[]
        {
            ("TopLeft", new Rect2(0, 0, 80, 96), 0, Colors.Black),
            ("BottomLeft", new Rect2(0, 104, 80, 96), 1, Colors.Black),
            ("TopRight", new Rect2(88, 0, 232, 96), 2, Colors.Black),
            ("BottomRight", new Rect2(88, 104, 232, 64), 3, Colors.Black),
            ("Center", new Rect2(88, 176, 232, 24), 4, Colors.Black),
        },
    };

    public ViewportLayout CurrentLayout => _currentLayout;
    public ViewportRegion? GetRegion(string name) =>
        _regions.GetValueOrDefault(name);

    public void SetLayout(ViewportLayout layout)
    {
        if (layout == _currentLayout && _regions.Count > 0)
            return;
        _currentLayout = layout;

        ClearRegions();
        ClearBorderLines();

        if (!LayoutDefs.TryGetValue(layout, out var defs))
            return;

        foreach (var (name, rect, zIndex, bgColor) in defs)
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

        ReassignContent();
        DrawBorders();
    }

    public void AssignContent(Node node, string regionName)
    {
        var existingKey = FindContentKey(node);
        if (existingKey != null)
            _contentMap.Remove(existingKey);

        _contentMap[regionName] = node;

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
            // Move only tracked content nodes back to ViewportManager
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

    private void ClearBorderLines()
    {
        foreach (var line in _borderLines)
            line.QueueFree();
        _borderLines.Clear();
    }

    private void ReassignContent()
    {
        foreach (var (regionName, node) in _contentMap)
        {
            var region = GetRegion(regionName);
            if (region != null)
                ReparentToRegion(node, region);
        }
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
        if (_currentLayout == ViewportLayout.Stats)
        {
            DrawBorderLine(new Rect2(80, 0, 8, 200));
            DrawBorderLine(new Rect2(0, 96, 80, 8));
            DrawBorderLine(new Rect2(88, 100, 232, 4));
            DrawBorderLine(new Rect2(88, 168, 232, 8));
            return;
        }

        DrawBorderLine(new Rect2(76, 0, 4, 200));
        DrawBorderLine(new Rect2(0, 188, 320, 4));
    }

    private void DrawBorderLine(Rect2 rect)
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
        _borderLines.Add(line);

        // Highlight for EGA bevel effect
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
        _borderLines.Add(highlight);
    }
}
