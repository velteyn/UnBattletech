using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.UI;

/// <summary>
/// BorderPanel: pannello di bordo stile EGA che incornicia il viewport.
/// Nel gioco originale: 80px a sinistra (immagine mech/info) + 240px viewport.
/// BTBORDER.CMP contiene i tile per i bordi.
/// </summary>
public partial class BorderPanel : Node2D
{
    private Sprite2D? _borderLeft;
    private Sprite2D? _borderBottom;
    private Label? _locationLabel;
    private Label? _creditsLabel;

    public override void _Ready()
    {
        // Sfondo nero per l'area bordo
        var bg = new ColorRect
        {
            Color = Colors.Black,
            Size = new Vector2(320, 200)
        };
        AddChild(bg);

        // TODO Phase 2: caricare BTBORDER.CMP per i tile bordo reali
        // Per ora: rettangoli colorati che simulano il layout

        // Left panel (80px)
        var leftPanel = new ColorRect
        {
            Color = new Color(0x00, 0x00, 0x55), // dark blue EGA
            Size = new Vector2(80, 200)
        };
        AddChild(leftPanel);

        // Label posizione (in alto a sinistra)
        _locationLabel = new Label
        {
            Text = "Pos: (0,0)",
            Position = new Vector2(4, 4),
            Theme = CreateEgaTheme()
        };
        AddChild(_locationLabel);

        // Label crediti (in basso a sinistra)
        _creditsLabel = new Label
        {
            Text = "CB: 1000",
            Position = new Vector2(4, 180),
            Theme = CreateEgaTheme()
        };
        AddChild(_creditsLabel);

        // Bottom bar (4px sotto il viewport, larga 240)
        var bottomBar = new ColorRect
        {
            Color = new Color(0x55, 0x55, 0x55), // dark gray EGA
            Size = new Vector2(320, 8),
            Position = new Vector2(0, 192)
        };
        AddChild(bottomBar);
    }

    /// <summary>
    /// Aggiorna le label con lo stato corrente.
    /// </summary>
    public void UpdateInfo(int cursorX, int cursorY, int credits)
    {
        if (_locationLabel != null)
        {
            int tileX = (cursorX & 0x7F) >> 1;
            int tileY = (cursorY & 0x7F) >> 1;
            _locationLabel.Text = $"({tileX},{tileY})";
        }
        if (_creditsLabel != null)
            _creditsLabel.Text = $"CB:{credits}";
    }

    private static Theme CreateEgaTheme()
    {
        var theme = new Theme();
        var font = ThemeDB.FallbackFont;
        theme.SetFont("font", "Label", font);
        theme.SetColor("font_color", "Label", new Color(0xAA, 0xAA, 0xAA)); // light gray EGA
        theme.SetConstant("outline_size", "Label", 1);
        theme.SetColor("font_outline_color", "Label", Colors.Black);
        return theme;
    }
}