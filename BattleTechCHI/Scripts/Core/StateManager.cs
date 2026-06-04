using Godot;
using BattleTechCHI.Data;
using BattleTechCHI.Maps;
using BattleTechCHI.Combat;

namespace BattleTechCHI.Core;

/// <summary>
/// StateManager: gestisce lo stato globale del gioco e la macchina a stati w4FBA.
/// Emette segnali per cambio modalità.
/// </summary>
public partial class StateManager : Node
{
    [Signal]
    public delegate void GameModeChangedEventHandler(GameMode newMode);

    private GameState _state = new();

    public GameState State => _state;
    public GameMode CurrentMode => _state.Mode;

    /// <summary>
    /// Cambia la modalità UI e notifica i subscriber.
    /// </summary>
    public void SetMode(GameMode mode)
    {
        if (_state.Mode != mode)
        {
            _state.Mode = mode;
            EmitSignal(SignalName.GameModeChanged, (int)mode);
            GD.Print($"GameMode changed to: {mode}");
        }
    }

    /// <summary>
    /// Aggiorna la posizione del cursore dalla formula originale.
    /// Tile X = (wA44B & 0x7F) >> 1
    /// </summary>
    public (int tileX, int tileY) GetCursorTile()
    {
        int tileX = (_state.CursorX & 0x7F) >> 1;
        int tileY = (_state.CursorY & 0x7F) >> 1;
        return (tileX, tileY);
    }

    /// <summary>
    /// Legge un byte dall'array di stato generico (D30C).
    /// </summary>
    public byte GetStateByte(int index)
    {
        return (index >= 0 && index < _state.StateArray.Length) 
            ? _state.StateArray[index] 
            : (byte)0;
    }

    /// <summary>
    /// Scriva un byte nell'array di stato generico.
    /// </summary>
    public void SetStateByte(int index, byte value)
    {
        if (index >= 0 && index < _state.StateArray.Length)
            _state.StateArray[index] = value;
    }
}