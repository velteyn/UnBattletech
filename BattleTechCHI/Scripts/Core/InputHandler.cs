using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.Core;

/// <summary>
/// Gestisce l'input utente e lo traduce in azioni di gioco.
/// Mappa i tasti freccia WASD, SPACE, F1-F10 e numerici.
/// </summary>
public partial class InputHandler : Node
{
    [Signal]
    public delegate void CursorMovedEventHandler(int dx, int dy);

    [Signal]
    public delegate void ActionPressedEventHandler();

    [Signal]
    public delegate void MenuPressedEventHandler(int menuIndex);

    [Signal]
    public delegate void FunctionKeyPressedEventHandler(int key);

    private StateManager _stateManager = null!;

    public override void _Ready()
    {
        _stateManager = GetParent<StateManager>();
    }

    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventKey key && key.Pressed && !key.Echo)
        {
            HandleKey(key);
        }
    }

    private void HandleKey(InputEventKey key)
    {
        // During combat, input is handled by GameLoop._Input directly
        if (_stateManager.State.Mode == GameMode.Combat)
            return;

        switch (key.Keycode)
        {
            // Movimento: frecce e WASD alternativi
            case Key.Up or Key.W:
                EmitSignal(SignalName.CursorMoved, 0, -1);
                break;
            case Key.Down or Key.S:
                EmitSignal(SignalName.CursorMoved, 0, 1);
                break;
            case Key.Left or Key.A:
                EmitSignal(SignalName.CursorMoved, -1, 0);
                break;
            case Key.Right or Key.D:
                EmitSignal(SignalName.CursorMoved, 1, 0);
                break;

            // Azione / conferma
            case Key.Space or Key.Enter:
                EmitSignal(SignalName.ActionPressed);
                break;

            // Menu azioni (SPACE menu nel gioco originale)
            case Key.Escape:
                EmitSignal(SignalName.MenuPressed, 0);
                break;

            // Tasti funzione
            case Key.F1: EmitSignal(SignalName.FunctionKeyPressed, 1); break;
            case Key.F2: EmitSignal(SignalName.FunctionKeyPressed, 2); break;
            case Key.F3: EmitSignal(SignalName.FunctionKeyPressed, 3); break;
            case Key.F4: EmitSignal(SignalName.FunctionKeyPressed, 4); break;
            case Key.F5: EmitSignal(SignalName.FunctionKeyPressed, 5); break;
            case Key.F6: EmitSignal(SignalName.FunctionKeyPressed, 6); break;
            case Key.F7: EmitSignal(SignalName.FunctionKeyPressed, 7); break;
            case Key.F8: EmitSignal(SignalName.FunctionKeyPressed, 8); break;
            case Key.F9: EmitSignal(SignalName.FunctionKeyPressed, 9); break;
            case Key.F10: EmitSignal(SignalName.FunctionKeyPressed, 10); break;

            // Tasti numerici per menu modalità (originale: 1=World, 2=Local, 3=Text, 4=Building)
            case Key.Key1: EmitSignal(SignalName.MenuPressed, 1); break;
            case Key.Key2: EmitSignal(SignalName.MenuPressed, 2); break;
            case Key.Key3: EmitSignal(SignalName.MenuPressed, 3); break;
            case Key.Key4: EmitSignal(SignalName.MenuPressed, 4); break;
        }
    }
}