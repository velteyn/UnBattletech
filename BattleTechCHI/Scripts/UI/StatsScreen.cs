using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.UI;

public partial class StatsScreen : Control
{
    private AnmPlayer _anmPlayer = null!;
    private Label _unitLabel = null!;
    private Label _statsLabel = null!;
    private Label _equipLabel = null!;
    private int _selectedUnit;

    [Signal]
    public delegate void ExitStatsEventHandler();

    public override void _Ready()
    {
        // Background: BTSTATS.CMP full-screen image
        var bgPath = ResourceLoader.Load<Texture2D>("res://Assets/BTSTATS.png");
        if (bgPath != null)
        {
            var bg = new TextureRect
            {
                Texture = bgPath,
                ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
                StretchMode = TextureRect.StretchModeEnum.Keep,
                Size = new Vector2(320, 200),
                MouseFilter = MouseFilterEnum.Ignore,
            };
            AddChild(bg);
        }
        else
        {
            var fallback = new ColorRect
            {
                Color = new Color(0, 0, 0, 0.9f),
                Size = new Vector2(320, 200),
            };
            AddChild(fallback);
        }

        // Left panel ANM player (unit portrait)
        _anmPlayer = new AnmPlayer();
        _anmPlayer.Name = "StatsAnm";
        _anmPlayer.Position = new Vector2(-4, 16);
        AddChild(_anmPlayer);

        // Unit name label
        _unitLabel = new Label
        {
            Position = new Vector2(84, 8),
            Theme = CreateEgaTheme(new Color(0xFF, 0xFF, 0x55)),
        };
        AddChild(_unitLabel);

        // Stats / attributes label
        _statsLabel = new Label
        {
            Position = new Vector2(84, 28),
            Theme = CreateEgaTheme(new Color(0xAA, 0xAA, 0xAA)),
        };
        AddChild(_statsLabel);

        // Equipment list label
        _equipLabel = new Label
        {
            Position = new Vector2(84, 80),
            Theme = CreateEgaTheme(new Color(0x55, 0xFF, 0x55)),
        };
        AddChild(_equipLabel);

        // Help text at bottom
        var help = new Label
        {
            Position = new Vector2(84, 180),
            Text = "UP/DOWN: select unit  SPACE/ESC: exit",
            Theme = CreateEgaTheme(new Color(0x55, 0x55, 0x55)),
        };
        AddChild(help);

        Visible = false;
    }

    public void ShowForUnit(GameState state, int unitIndex = 0)
    {
        _selectedUnit = unitIndex;
        UpdateDisplay(state);
        Visible = true;
    }

    private void UpdateDisplay(GameState state)
    {
        var slots = state.UnitSlots;
        if (_selectedUnit < 0 || _selectedUnit >= slots.Length)
        {
            _selectedUnit = 0;
            return;
        }

        var slot = slots[_selectedUnit];
        _unitLabel.Text = $"Unit {_selectedUnit + 1}  Type: {slot.TypeId}";

        _statsLabel.Text = $"Attr1: {slot.Attr1}  Attr2: {slot.Attr2}  Attr3: {slot.Attr3}  Derived: {slot.DerivedAttr}";

        string equip = "";
        for (int i = 0; i < slot.Inventory.Length; i++)
        {
            if (slot.Inventory[i] > 0)
                equip += $"Slot {i + 1}: Item {slot.Inventory[i]}\n";
        }
        if (string.IsNullOrEmpty(equip))
            equip = "No equipment";
        _equipLabel.Text = equip;

        // Load ANM animation for this unit (try O0 by default)
        _anmPlayer.Load("O0");
        _anmPlayer.Play(10.0f);
    }

    public override void _Input(InputEvent @event)
    {
        if (!Visible || @event is not InputEventKey key || !key.Pressed || key.Echo) return;

        switch (key.Keycode)
        {
            case Key.Up or Key.W:
                _selectedUnit = (_selectedUnit + 7) % 8;
                break;
            case Key.Down or Key.S:
                _selectedUnit = (_selectedUnit + 1) % 8;
                break;
            case Key.Space or Key.Escape:
                _anmPlayer.Stop();
                Visible = false;
                EmitSignal(SignalName.ExitStats);
                break;
        }
    }

    private static Theme CreateEgaTheme(Color fontColor)
    {
        var theme = new Theme();
        theme.SetFont("font", "Label", ThemeDB.FallbackFont);
        theme.SetColor("font_color", "Label", fontColor);
        return theme;
    }
}
