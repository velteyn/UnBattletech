using Godot;

namespace BattleTechCHI.UI;

public partial class ViewportRegion : Control
{
    public string RegionName { get; set; } = "";
    public bool ShowBorder { get; set; }

    public void SetRegionRect(Rect2 rect)
    {
        Position = rect.Position;
        Size = rect.Size;
    }
}
