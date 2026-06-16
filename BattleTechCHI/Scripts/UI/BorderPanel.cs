using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.UI;

/// <summary>
/// BorderPanel: contenuto del pannello sinistro (80px).
/// Layout e bordi gestiti da ViewportManager.
/// BTBORDER.CMP tile border — Phase 2.
/// </summary>
public partial class BorderPanel : Node2D
{
    private Label? _locationLabel;
    private Label? _creditsLabel;
    private AnmPlayer _anmPlayer = null!;
    private GameMode _currentMode = GameMode.WorldMap;

    public AnmPlayer AnmPlayer => _anmPlayer;

    public override void _Ready()
    {
        _anmPlayer = new AnmPlayer();
        _anmPlayer.Name = "AnmPlayer";
        _anmPlayer.Position = new Vector2(40, 85);
        AddChild(_anmPlayer);
        _anmPlayer.Hide();

        _locationLabel = new Label
        {
            Text = "Pos: (0,0)",
            Position = new Vector2(4, 4),
            Theme = CreateEgaTheme()
        };
        AddChild(_locationLabel);

        _creditsLabel = new Label
        {
            Text = "CB: 1000",
            Position = new Vector2(4, 180),
            Theme = CreateEgaTheme()
        };
        AddChild(_creditsLabel);
    }

    /// <summary>
    /// Aggiorna le label con lo stato corrente.
    /// </summary>
    public void UpdateInfo(int cursorX, int cursorY, int credits, GameMode? mode = null)
    {
        var m = mode ?? _currentMode;
        _currentMode = m;

        if (_locationLabel != null)
        {
            if (m == GameMode.Combat)
                _locationLabel.Text = $"Grid:({cursorX},{cursorY})";
            else
            {
                int tileX = (cursorX & 0x7F) >> 1;
                int tileY = (cursorY & 0x7F) >> 1;
                _locationLabel.Text = $"({tileX},{tileY})";
            }
        }
        if (_creditsLabel != null)
        {
            if (m == GameMode.Combat)
                _creditsLabel.Text = $"COMBAT";
            else
                _creditsLabel.Text = $"CB:{credits}";
        }
    }

    /// <summary>
    /// Show an ANM animation in the left panel.
    /// </summary>
    public void ShowAnimation(string anmName, float fps = 10.0f)
    {
        if (_anmPlayer.Load(anmName))
        {
            _anmPlayer.Play(fps);
            _anmPlayer.Visible = true;
        }
    }

    /// <summary>
    /// Hide the left panel animation.
    /// </summary>
    public void HideAnimation()
    {
        _anmPlayer.Stop();
        _anmPlayer.Visible = false;
    }

    /// <summary>
    /// Show building name on cursor hover (135D position interaction dispatch).
    /// null/empty = no hover (coordinate display already set by UpdateInfo).
    /// </summary>
    public void SetHoverBuildingName(string? name)
    {
        if (_locationLabel != null && !string.IsNullOrEmpty(name))
            _locationLabel.Text = name;
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