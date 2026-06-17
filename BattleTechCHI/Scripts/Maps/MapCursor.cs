using Godot;

namespace BattleTechCHI.Maps;

public partial class MapCursor : Sprite2D
{
    private Godot.Timer _animTimer = null!;
    private int _currentFrame;
    private int _frameCount = 2;
    private int _frameSize = 16;

    public override void _Ready()
    {
        int sheetW = _frameSize * _frameCount;
        var img = Image.CreateEmpty(sheetW, _frameSize, false, Image.Format.Rgba8);
        for (int frame = 0; frame < _frameCount; frame++)
        {
            float alpha = frame == 0 ? 1.0f : 0.3f;
            var color = new Color(0x55 / 255f, 0xFF / 255f, 0x55 / 255f, alpha);
            for (int y = 0; y < _frameSize; y++)
            {
                for (int x = 0; x < _frameSize; x++)
                {
                    bool isBorder = y < 2 || y >= _frameSize - 2 || x < 2 || x >= _frameSize - 2;
                    img.SetPixel(frame * _frameSize + x, y, isBorder ? color : Colors.Transparent);
                }
            }
        }
        Texture = ImageTexture.CreateFromImage(img);
        RegionEnabled = true;
        RegionRect = new Rect2(0, 0, _frameSize, _frameSize);

        _animTimer = new Godot.Timer { WaitTime = 0.4f, OneShot = false };
        _animTimer.Timeout += () =>
        {
            _currentFrame = (_currentFrame + 1) % _frameCount;
            RegionRect = new Rect2(_currentFrame * _frameSize, 0, _frameSize, _frameSize);
        };
        AddChild(_animTimer);
        _animTimer.Start();
    }

    public void SetTilePosition(int tileX, int tileY)
    {
        Position = new Vector2(tileX * _frameSize, tileY * _frameSize);
    }
}
