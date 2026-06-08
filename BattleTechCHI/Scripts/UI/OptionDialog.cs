using Godot;

namespace BattleTechCHI.UI;

public partial class OptionDialog : Control
{
    private Label _promptLabel;
    private Button _yesButton;
    private Button _noButton;

    [Signal]
    public delegate void OptionChosenEventHandler(int index);

    public OptionDialog(string text)
    {
        var bg = new ColorRect
        {
            Color = new Color(0, 0, 0, 0.9f),
            Size = new Vector2(320, 200),
        };
        AddChild(bg);

        _promptLabel = new Label
        {
            Text = text,
            Position = new Vector2(16, 60),
            Size = new Vector2(288, 40),
            HorizontalAlignment = HorizontalAlignment.Center,
            Theme = CreateEgaTheme(new Color(0xAA, 0xAA, 0xAA)),
        };
        AddChild(_promptLabel);

        _yesButton = new Button
        {
            Text = "Yes",
            Position = new Vector2(80, 120),
            Size = new Vector2(60, 24),
        };
        _yesButton.Pressed += () => OnChoice(0);
        AddChild(_yesButton);

        _noButton = new Button
        {
            Text = "No",
            Position = new Vector2(180, 120),
            Size = new Vector2(60, 24),
        };
        _noButton.Pressed += () => OnChoice(1);
        AddChild(_noButton);
    }

    private void OnChoice(int index)
    {
        EmitSignal(SignalName.OptionChosen, index);
        QueueFree();
    }

    private static Theme CreateEgaTheme(Color fontColor)
    {
        var theme = new Theme();
        theme.SetFont("font", "Label", ThemeDB.FallbackFont);
        theme.SetColor("font_color", "Label", fontColor);
        theme.SetColor("font_color", "Button", fontColor);
        return theme;
    }
}
