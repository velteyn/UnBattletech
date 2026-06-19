using Godot;
using System.Collections.Generic;
using System.IO;

namespace BattleTechCHI.Combat;

public enum MechPortraitAnimState
{
    Idle,
    Moving,
    Firing,
    TakingDamage
}

public partial class MechPortrait : Node2D
{
    private static readonly int[] LocustFrames = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
    private static readonly int[] CommandoFrames = { 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157 };

    private static readonly Dictionary<int, int[]> MechFrameMap = new()
    {
        { 0x00, LocustFrames },
        { 0x01, LocustFrames },
        { 0x02, LocustFrames },
        { 0x03, CommandoFrames },
        { 0x06, LocustFrames },
        { 0x09, LocustFrames },
        { 0xC8, LocustFrames },
    };

    private Sprite2D _portrait;
    private ColorRect _overlay;
    private Godot.Timer _animTimer;
    private Godot.Timer _stateTimer;

    private int[] _currentFrames = LocustFrames;
    private int _currentFrameIdx;
    private int _frameCount;
    private Texture2D? _sheet;

    private MechPortraitAnimState _state = MechPortraitAnimState.Idle;
    private const int FrameSize = 24;
    private const int DisplayScale = 2;
    private const int DisplaySize = FrameSize * DisplayScale;

    public MechPortraitAnimState CurrentState => _state;

    public override void _Ready()
    {
        _portrait = new Sprite2D
        {
            Name = "MechPortraitSprite",
            Centered = true,
            Scale = new Vector2(DisplayScale, DisplayScale),
            Position = new Vector2(40, 2 + DisplaySize / 2),
        };
        AddChild(_portrait);

        _overlay = new ColorRect
        {
            Name = "MechPortraitOverlay",
            Color = new Color(1, 1, 1, 0),
            Size = new Vector2(DisplaySize, DisplaySize),
            Position = new Vector2(40 - DisplaySize / 2, 2),
            MouseFilter = Control.MouseFilterEnum.Ignore,
        };
        AddChild(_overlay);

        _animTimer = new Godot.Timer
        {
            Name = "MechPortraitAnimTimer",
            OneShot = false,
        };
        _animTimer.Timeout += OnAnimTick;
        AddChild(_animTimer);

        _stateTimer = new Godot.Timer
        {
            Name = "MechPortraitStateTimer",
            OneShot = true,
        };
        _stateTimer.Timeout += OnStateTimerEnd;
        AddChild(_stateTimer);
    }

    public void SetMechType(int mechId)
    {
        if (MechFrameMap.TryGetValue(mechId, out var frames))
            _currentFrames = frames;
        else
            _currentFrames = LocustFrames;

        _frameCount = _currentFrames.Length;
        _sheet = BuildSpritesheet(_currentFrames);
        _portrait.Texture = _sheet;
        _portrait.RegionEnabled = true;
        _portrait.RegionRect = new Rect2(0, 0, FrameSize, FrameSize);
        _currentFrameIdx = 0;
    }

    public void SetAnimState(MechPortraitAnimState newState)
    {
        if (newState == _state) return;
        _state = newState;

        _stateTimer.Stop();

        switch (newState)
        {
            case MechPortraitAnimState.Idle:
                _animTimer.WaitTime = 1.0f / 4.0f;
                _animTimer.Start();
                _overlay.Color = new Color(1, 1, 1, 0);
                break;

            case MechPortraitAnimState.Moving:
                _animTimer.WaitTime = 1.0f / 8.0f;
                _animTimer.Start();
                _overlay.Color = new Color(1, 1, 1, 0);
                break;

            case MechPortraitAnimState.Firing:
                _animTimer.Stop();
                _overlay.Color = new Color(1, 0.8f, 0, 0.5f);
                _stateTimer.WaitTime = 0.3f;
                _stateTimer.Start();
                break;

            case MechPortraitAnimState.TakingDamage:
                _animTimer.Stop();
                _overlay.Color = new Color(1, 0, 0, 0.4f);
                _stateTimer.WaitTime = 0.4f;
                _stateTimer.Start();
                break;
        }
    }

    private void OnAnimTick()
    {
        if (_sheet == null || _frameCount <= 1) return;
        _currentFrameIdx = (_currentFrameIdx + 1) % _frameCount;
        _portrait.RegionRect = new Rect2(_currentFrameIdx * FrameSize, 0, FrameSize, FrameSize);
    }

    private void OnStateTimerEnd()
    {
        _overlay.Color = new Color(1, 1, 1, 0);
        _state = MechPortraitAnimState.Idle;
        _animTimer.WaitTime = 1.0f / 4.0f;
        _animTimer.Start();
    }

    private Texture2D BuildSpritesheet(int[] frameIndices)
    {
        int totalW = frameIndices.Length * FrameSize;
        var sheetImg = Image.CreateEmpty(totalW, FrameSize, false, Image.Format.Rgba8);

        var projectDir = ProjectSettings.GlobalizePath("res://");
        var spritesDir = Path.GetFullPath(Path.Combine(projectDir, "Assets", "Sprites"));

        for (int i = 0; i < frameIndices.Length; i++)
        {
            var path = Path.Combine(spritesDir, $"MECHSHAP_{frameIndices[i]}.png");
            if (!File.Exists(path)) continue;

            var frameImg = new Image();
            var err = frameImg.Load(path);
            if (err != Error.Ok) continue;

            sheetImg.BlitRect(frameImg, new Rect2I(0, 0, FrameSize, FrameSize), new Vector2I(i * FrameSize, 0));
            frameImg.Dispose();
        }

        return ImageTexture.CreateFromImage(sheetImg);
    }
}
