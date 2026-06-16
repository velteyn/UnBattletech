using Godot;

namespace BattleTechCHI.UI;

public partial class AnmPlayer : Node2D
{
    private Sprite2D _sprite = null!;
    private Godot.Timer _timer = null!;
    private Texture2D? _sheet;
    private int _frameCount;
    private int _currentFrame;
    private int _frameWidth = 88;
    private int _frameHeight = 88;
    private bool _playing;
    private float _fps = 10.0f;

    public int FrameCount => _frameCount;
    public int CurrentFrame => _currentFrame;
    public bool Playing => _playing;
    public string? CurrentAnimation { get; private set; }

    public override void _Ready()
    {
        _sprite = new Sprite2D
        {
            Name = "AnmSprite",
            Centered = true
        };
        AddChild(_sprite);

        _timer = new Godot.Timer
        {
            Name = "AnmTimer",
            OneShot = false
        };
        _timer.Timeout += OnTimerTick;
        AddChild(_timer);
    }

    public bool Load(string anmName)
    {
        var path = $"res://Assets/Animations/{anmName}_sheet.png";
        _sheet = ResourceLoader.Load<Texture2D>(path);
        if (_sheet == null)
        {
            GD.PrintErr($"AnmPlayer: failed to load '{path}'");
            CurrentAnimation = null;
            return false;
        }

        _frameCount = (int)(_sheet.GetWidth() / _frameWidth);
        _frameHeight = (int)_sheet.GetHeight();
        _currentFrame = 0;
        _sprite.Texture = _sheet;
        _sprite.RegionEnabled = true;
        _sprite.RegionRect = new Rect2(0, 0, _frameWidth, _frameHeight);
        CurrentAnimation = anmName;
        return true;
    }

    public void Play(float fps = 10.0f)
    {
        if (_sheet == null || _frameCount <= 1) return;
        _fps = Mathf.Max(1.0f, fps);
        _playing = true;
        _timer.WaitTime = 1.0f / _fps;
        _timer.Start();
    }

    public void Stop()
    {
        _playing = false;
        _timer.Stop();
    }

    public void SetFrame(int frame)
    {
        if (_sheet == null) return;
        _currentFrame = Mathf.Clamp(frame, 0, Mathf.Max(0, _frameCount - 1));
        _sprite.RegionRect = new Rect2(_currentFrame * _frameWidth, 0, _frameWidth, _frameHeight);
    }

    private void OnTimerTick()
    {
        if (!_playing || _sheet == null) return;
        _currentFrame = (_currentFrame + 1) % _frameCount;
        _sprite.RegionRect = new Rect2(_currentFrame * _frameWidth, 0, _frameWidth, _frameHeight);
    }
}
