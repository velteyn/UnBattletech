using Godot;
using BattleTechCHI.Data;
using BattleTechCHI.Maps;

namespace BattleTechCHI.Core;

/// <summary>
/// GameLoop principale: integra StateManager, InputHandler, e coordina
/// i sottosistemi in un ciclo init → input → update → render.
/// </summary>
public partial class GameLoop : Node
{
    private StateManager _stateManager = null!;
    private InputHandler _inputHandler = null!;

    public StateManager StateManager => _stateManager;
    public GameState State => _stateManager.State;

    public override void _Ready()
    {
        GD.Print("=== BattleTech: The Crescent Hawk's Inception — Rebuild ===");
        GD.Print($"RE state: ~95% | Engine state: Phase 0-1");

        // Inizializza StateManager
        _stateManager = new StateManager();
        AddChild(_stateManager);

        // Inizializza InputHandler (child dello StateManager)
        _inputHandler = new InputHandler();
        _stateManager.AddChild(_inputHandler);

        // Connetti segnali
        _inputHandler.CursorMoved += OnCursorMoved;
        _inputHandler.ActionPressed += OnActionPressed;
        _inputHandler.MenuPressed += OnMenuPressed;
        _inputHandler.FunctionKeyPressed += OnFunctionKey;

        // Inizializza stato di default
        _stateManager.State.Credits = 1000; // C-Bills iniziali
        _stateManager.State.CurrentMapId = 1;

        GD.Print("GameLoop ready. Waiting for user input.");
    }

    public override void _Process(double delta)
    {
        // TODO Phase 1: game loop completo
        // 1. Update timer/cooldown
        // 2. Random encounter check (se world map)
        // 3. NPC movement
        // 4. Economy tick
    }

    private void OnCursorMoved(int dx, int dy)
    {
        _stateManager.State.CursorX = Mathf.Clamp(_stateManager.State.CursorX + dx, 0, 127);
        _stateManager.State.CursorY = Mathf.Clamp(_stateManager.State.CursorY + dy, 0, 127);
        
        var (tx, ty) = _stateManager.GetCursorTile();
        GD.Print($"Cursor tile: ({tx}, {ty})");
    }

    private void OnActionPressed()
    {
        GD.Print("Action pressed — entering building / interacting");
        // TODO Phase 2-3: trigger BLD interaction at cursor position
    }

    private void OnMenuPressed(int index)
    {
        GD.Print($"Menu pressed: {index}");
        // TODO Phase 2: SPACE menu handler (party, tech, star map, stock market, etc.)
        switch (index)
        {
            case 1: // 1-4 = map mode switch (original game behavior)
            case 2:
            case 3:
            case 4:
                _stateManager.SetMode((GameMode)(index - 1));
                break;
        }
    }

    private void OnFunctionKey(int key)
    {
        GD.Print($"Function key F{key}");
    }
}