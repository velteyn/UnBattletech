using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.UI;

/// <summary>
/// ShopScreen: interfaccia negozio stile EGA.
/// Mostra 3 slot di item con prezzi, seleziona con su/giù,
/// compra con SPACE, vende con BACK, esci con ESC.
/// </summary>
public partial class ShopScreen : Control
{
    // 3 display slots: C618[0..2]
    // bD314 = selection index
    private int _selectedSlot;
    private Label[] _slotLabels = new Label[3];
    private Label _creditsLabel;

    [Signal]
    public delegate void BuyRequestedEventHandler(int slot);

    [Signal]
    public delegate void SellRequestedEventHandler(int slot);

    [Signal]
    public delegate void ExitShopEventHandler();

    public override void _Ready()
    {
        var bg = new ColorRect
        {
            Color = new Color(0, 0, 0, 0.9f),
            Size = new Vector2(320, 200)
        };
        AddChild(bg);

        // Title
        var title = new Label
        {
            Text = "SHOP",
            Position = new Vector2(120, 8),
            Theme = CreateEgaTheme(new Color(0xFF, 0xFF, 0x55))
        };
        AddChild(title);

        // 3 item slots
        for (int i = 0; i < 3; i++)
        {
            _slotLabels[i] = new Label
            {
                Position = new Vector2(16, 40 + i * 30),
                Text = $"[ ] Slot {i + 1}: ---",
                Theme = CreateEgaTheme(new Color(0xAA, 0xAA, 0xAA))
            };
            AddChild(_slotLabels[i]);
        }

        // Credits
        _creditsLabel = new Label
        {
            Position = new Vector2(16, 160),
            Text = "C-Bills: 0",
            Theme = CreateEgaTheme(new Color(0x55, 0xFF, 0x55))
        };
        AddChild(_creditsLabel);

        // Help text
        var help = new Label
        {
            Position = new Vector2(16, 180),
            Text = "UP/DOWN: select  SPACE: buy  S: sell  ESC: exit",
            Theme = CreateEgaTheme(new Color(0x55, 0x55, 0x55))
        };
        AddChild(help);

        Visible = false;
    }

    /// <summary>
    /// Aggiorna la visualizzazione dei 3 slot e crediti.
    /// </summary>
    public void UpdateDisplay(int selectedSlot, int[] itemTypes, int[] prices, int credits)
    {
        _selectedSlot = selectedSlot;
        _creditsLabel.Text = $"C-Bills: {credits}";

        for (int i = 0; i < 3; i++)
        {
            string prefix = i == selectedSlot ? "[>]" : "[ ]";
            string itemName = itemTypes[i] > 0 ? $"Item {itemTypes[i]}" : "---";
            string priceStr = prices[i] > 0 ? $"{prices[i]} cr" : "";
            _slotLabels[i].Text = $"{prefix} Slot {i + 1}: {itemName} {priceStr}";

            _slotLabels[i].Theme = CreateEgaTheme(
                i == selectedSlot
                    ? new Color(0x55, 0xFF, 0x55)
                    : new Color(0xAA, 0xAA, 0xAA));
        }
    }

    public override void _Input(InputEvent @event)
    {
        if (!Visible || @event is not InputEventKey key || !key.Pressed || key.Echo) return;

        switch (key.Keycode)
        {
            case Key.Up or Key.W:
                _selectedSlot = (_selectedSlot + 2) % 3;
                break;
            case Key.Down or Key.S:
                _selectedSlot = (_selectedSlot + 1) % 3;
                break;
            case Key.Space or Key.Enter:
                EmitSignal(SignalName.BuyRequested, _selectedSlot);
                break;
            case Key.Backspace:
                EmitSignal(SignalName.SellRequested, _selectedSlot);
                break;
            case Key.Escape:
                EmitSignal(SignalName.ExitShop);
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