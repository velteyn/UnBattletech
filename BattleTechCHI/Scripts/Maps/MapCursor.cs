using Godot;

namespace BattleTechCHI.Maps;

/// <summary>
/// Cursor: overlay visibile sulla TileMap che mostra dove si trova il giocatore.
/// Lampeggia stile EGA.
/// </summary>
public partial class MapCursor : Sprite2D
{
    private Timer _blinkTimer = null!;
    private bool _visible_state = true;

    public override void _Ready()
    {
        // Crea un quadratino 16x16 colore EGA light green
        var img = Image.CreateEmpty(16, 16, false, Image.Format.Rgba8);
        for (int y = 0; y < 16; y++)
            for (int x = 0; x < 16; x++)
                img.SetPixel(x, y, y < 2 || y >= 14 || x < 2 || x >= 14
                    ? new Color(0x55, 0xFF, 0x55) // light green EGA
                    : Colors.Transparent);
        Texture = ImageTexture.CreateFromImage(img);

        _blinkTimer = new Timer { WaitTime = 0.4f, OneShot = false };
        AddChild(_blinkTimer);
        _blinkTimer.Timeout += () =>
        {
            _visible_state = !_visible_state;
            Modulate = _visible_state ? new Color(1, 1, 1, 1) : new Color(1, 1, 1, 0.3f);
        };
        _blinkTimer.Start();
    }

    /// <summary>
    /// Posiziona il cursore su un tile specifico.
    /// </summary>
    public void SetTilePosition(int tileX, int tileY)
    {
        Position = new Vector2(tileX * 16, tileY * 16);
    }
}