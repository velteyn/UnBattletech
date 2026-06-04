using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.UI;

/// <summary>
/// DialogueBox: renderizza il testo decodificato dai BLD con word wrapping,
/// indicatori del narratore (9E/9C/9B/9F/A5) e attesa input.
/// Stile EGA: sfondo nero, testo chiaro, font monospace.
/// </summary>
public partial class DialogueBox : Control
{
    private RichTextLabel _textLabel = null!;
    private Label _narratorLabel = null!;
    private Godot.Timer _typeTimer = null!;
    private bool _waitingForInput;

    [Signal]
    public delegate void InputReadyEventHandler();

    public override void _Ready()
    {
        // Sfondo semitrasparente
        var bg = new ColorRect
        {
            Color = new Color(0, 0, 0, 0.85f),
            Size = new Vector2(320, 200)
        };
        AddChild(bg);

        // Etichetta narratore (in alto)
        _narratorLabel = new Label
        {
            Position = new Vector2(4, 2),
            Theme = CreateEgaTheme(new Color(0xAA, 0xAA, 0x55)) // yellow
        };
        AddChild(_narratorLabel);

        // Testo centrale con word wrap
        _textLabel = new RichTextLabel
        {
            Position = new Vector2(8, 20),
            Size = new Vector2(304, 160),
            BbcodeEnabled = true,
            ScrollActive = false,
            Theme = CreateEgaTheme(new Color(0xAA, 0xAA, 0xAA))
        };
        AddChild(_textLabel);

        // Timer per effetto scrittura
        _typeTimer = new Godot.Timer { OneShot = true };
        AddChild(_typeTimer);
        _typeTimer.Timeout += OnTypeTimeout;

        Visible = false;
    }

    /// <summary>
    /// Mostra un testo con l'indicatore del narratore appropriato.
    /// </summary>
    public void ShowText(string text, NarrativeMode mode)
    {
        _narratorLabel.Text = GetNarratorPrefix(mode);
        _textLabel.Text = FormatText(text, mode);
        _waitingForInput = false;
        Visible = true;
    }

    /// <summary>
    /// Aspetta input utente prima di continuare.
    /// </summary>
    public void WaitForInput()
    {
        _waitingForInput = true;
        _textLabel.Text += "\n\n[PRESS SPACE]";
    }

    public override void _Input(InputEvent @event)
    {
        if (!_waitingForInput || !Visible) return;
        if (@event is InputEventKey key && key.Pressed && !key.Echo)
        {
            if (key.Keycode == Key.Space || key.Keycode == Key.Enter)
            {
                _waitingForInput = false;
                Visible = false;
                EmitSignal(SignalName.InputReady);
            }
        }
    }

    private static string GetNarratorPrefix(NarrativeMode mode) => mode switch
    {
        NarrativeMode.ThirdPerson => ":: Narrator ::",
        NarrativeMode.CharacterSpeech => ":: Says ::",
        NarrativeMode.PlayerThought => ":: Think ::",
        NarrativeMode.PlayerAction => ":: You ::",
        NarrativeMode.Continuation => "",
        _ => ""
    };

    private static string FormatText(string text, NarrativeMode mode)
    {
        string prefix = mode switch
        {
            NarrativeMode.ThirdPerson => "",
            NarrativeMode.CharacterSpeech => "\"",
            NarrativeMode.PlayerThought => "(",
            NarrativeMode.PlayerAction => "",
            NarrativeMode.Continuation => "",
            _ => ""
        };

        string suffix = mode switch
        {
            NarrativeMode.CharacterSpeech => "\"",
            NarrativeMode.PlayerThought => ")",
            _ => ""
        };

        return prefix + text + suffix;
    }

    private void OnTypeTimeout() { }

    private static Theme CreateEgaTheme(Color fontColor)
    {
        var theme = new Theme();
        theme.SetFont("font", "Label", ThemeDB.FallbackFont);
        theme.SetColor("font_color", "Label", fontColor);
        theme.SetColor("default_color", "RichTextLabel", fontColor);
        theme.SetFont("normal_font", "RichTextLabel", ThemeDB.FallbackFont);
        return theme;
    }
}