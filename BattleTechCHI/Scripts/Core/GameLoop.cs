using Godot;
using BattleTechCHI.Data;
using BattleTechCHI.Maps;
using BattleTechCHI.UI;

namespace BattleTechCHI.Core;

/// <summary>
/// GameLoop principale: coordina StateManager, InputHandler, TileManager,
/// WorldMapView, BorderPanel e tutti i sottosistemi.
/// Ciclo: init → input → update → render.
/// </summary>
public partial class GameLoop : Node
{
    private StateManager _stateManager = null!;
    private InputHandler _inputHandler = null!;
    private TileManager _tileManager = null!;
    private WorldMapView _worldMapView = null!;
    private BorderPanel _borderPanel = null!;

    public StateManager StateManager => _stateManager;
    public GameState State => _stateManager.State;

    public override void _Ready()
    {
        GD.Print("=== BattleTech: The Crescent Hawk's Inception — Rebuild ===");
        GD.Print("RE state: ~95% | Engine: Phase 2");

        // TileManager (carica tileset, thread-safe)
        _tileManager = new TileManager();
        _tileManager.Name = "TileManager";
        AddChild(_tileManager);

        // StateManager (stato globale + w4FBA mode)
        _stateManager = new StateManager();
        _stateManager.Name = "StateManager";
        AddChild(_stateManager);

        // InputHandler (child di StateManager)
        _inputHandler = new InputHandler();
        _stateManager.AddChild(_inputHandler);

        // BorderPanel (sempre visibile, UI di bordo)
        _borderPanel = new BorderPanel();
        _borderPanel.Name = "BorderPanel";
        AddChild(_borderPanel);

        // WorldMapView (TileMap, viewport 8×8 sulla mappa 64×64)
        _worldMapView = new WorldMapView();
        _worldMapView.Name = "WorldMapView";
        AddChild(_worldMapView);

        // Connetti segnali input
        _inputHandler.CursorMoved += OnCursorMoved;
        _inputHandler.ActionPressed += OnActionPressed;
        _inputHandler.MenuPressed += OnMenuPressed;
        _inputHandler.FunctionKeyPressed += OnFunctionKey;

        // Connetti cambio modalità
        _stateManager.GameModeChanged += OnGameModeChanged;

        // Stato iniziale
        _stateManager.State.Credits = 1500;
        _stateManager.State.CurrentMapId = 1;
        _stateManager.SetMode(GameMode.WorldMap);

        GD.Print("GameLoop ready. WorldMap view active.");
    }

    public override void _Process(double delta)
    {
        // TODO: update timer, random encounter check, NPC movement, economy tick
    }

    private void OnCursorMoved(int dx, int dy)
    {
        _stateManager.State.CursorX = Mathf.Clamp(_stateManager.State.CursorX + dx, 0, 127);
        _stateManager.State.CursorY = Mathf.Clamp(_stateManager.State.CursorY + dy, 0, 127);

        var (tx, ty) = _stateManager.GetCursorTile();
        _borderPanel.UpdateInfo(_stateManager.State.CursorX, _stateManager.State.CursorY, _stateManager.State.Credits);

        // Ri-renderizza viewport
        _worldMapView.RenderViewport();
    }

    private void OnActionPressed()
    {
        GD.Print("Action pressed at tile " + _stateManager.GetCursorTile());
        // TODO Phase 3: trigger BLD interaction
    }

    private void OnMenuPressed(int index)
    {
        switch (index)
        {
            case 1: _stateManager.SetMode(GameMode.WorldMap); break;
            case 2: _stateManager.SetMode(GameMode.LocalTiles); break;
            case 3: _stateManager.SetMode(GameMode.TextScreen); break;
            case 4: _stateManager.SetMode(GameMode.BuildingName); break;
        }
    }

    private void OnFunctionKey(int key)
    {
        GD.Print($"F{key} pressed");
    }

    private void OnGameModeChanged(GameMode mode)
    {
        GD.Print($"Mode changed to: {mode}");
        _worldMapView.Visible = mode == GameMode.WorldMap;
        // TODO: attivare/disattivare LocalMapView, CombatView, DialogueBox
    }
}