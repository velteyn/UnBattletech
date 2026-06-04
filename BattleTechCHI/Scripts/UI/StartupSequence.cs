using Godot;

namespace BattleTechCHI.UI;

/// <summary>
/// Schermata di avvio: mostra INFOCOM e BTTITLE in sequenza,
/// poi passa al gioco.
/// </summary>
public partial class StartupSequence : Node2D
{
    [Signal]
    public delegate void StartupCompleteEventHandler();

    private TextureRect? _imageRect;
    private Godot.Timer? _timer;
    private int _phase;

    public override void _Ready()
    {
        _imageRect = new TextureRect
        {
            ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
            StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered,
            AnchorRight = 1.0f,
            AnchorBottom = 1.0f,
        };
        AddChild(_imageRect);

        _timer = new Godot.Timer { OneShot = true };
        AddChild(_timer);
        _timer.Timeout += OnTimerTimeout;

        // Start with INFOCOM
        ShowTitle("INFOCOM.bmp");
    }

    private void ShowTitle(string filename)
    {
        // TODO Phase 7: caricare le BMP originali da Assets/
        // var path = ProjectSettings.GlobalizePath("res://Assets/" + filename);
        // if (File.Exists(path))
        //     _imageRect!.Texture = ImageTexture.CreateFromImage(Image.LoadFromFile(path));
        
        _timer!.Start(2.0);
    }

    private void OnTimerTimeout()
    {
        _phase++;
        switch (_phase)
        {
            case 1:
                ShowTitle("BTTITLE.bmp");
                break;
            case 2:
                EmitSignal(SignalName.StartupComplete);
                QueueFree();
                break;
        }
    }
}