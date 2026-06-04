using Godot;
using BattleTechCHI.Data;
using BattleTechCHI.Maps;
using BattleTechCHI.UI;
using BattleTechCHI.BLD;

namespace BattleTechCHI.Core;

public partial class GameLoop : Node
{
    private StateManager _stateManager = null!;
    private InputHandler _inputHandler = null!;
    private TileManager _tileManager = null!;
    private WorldMapView _worldMapView = null!;
    private BorderPanel _borderPanel = null!;
    private BldInterpreter _bldInterpreter = null!;
    private DialogueBox _dialogueBox = null!;

    public StateManager StateManager => _stateManager;
    public GameState State => _stateManager.State;

    public override void _Ready()
    {
        GD.Print("=== BattleTech: The Crescent Hawk's Inception — Rebuild ===");
        GD.Print("RE state: ~95% | Engine: Phase 3");

        // TileManager
        _tileManager = new TileManager();
        _tileManager.Name = "TileManager";
        AddChild(_tileManager);

        // StateManager
        _stateManager = new StateManager();
        _stateManager.Name = "StateManager";
        AddChild(_stateManager);

        // InputHandler
        _inputHandler = new InputHandler();
        _stateManager.AddChild(_inputHandler);

        // BLD Interpreter
        _bldInterpreter = new BldInterpreter();
        _bldInterpreter.Name = "BldInterpreter";
        _stateManager.AddChild(_bldInterpreter);

        // DialogueBox UI
        _dialogueBox = new DialogueBox();
        _dialogueBox.Name = "DialogueBox";
        AddChild(_dialogueBox);

        // BorderPanel
        _borderPanel = new BorderPanel();
        _borderPanel.Name = "BorderPanel";
        AddChild(_borderPanel);

        // WorldMapView
        _worldMapView = new WorldMapView();
        _worldMapView.Name = "WorldMapView";
        AddChild(_worldMapView);

        // Connetti input
        _inputHandler.CursorMoved += OnCursorMoved;
        _inputHandler.ActionPressed += OnActionPressed;
        _inputHandler.MenuPressed += OnMenuPressed;
        _inputHandler.FunctionKeyPressed += OnFunctionKey;

        // Connetti cambio modalità
        _stateManager.GameModeChanged += OnGameModeChanged;

        // Connetti BLD interpreter -> DialogueBox
        _bldInterpreter.TextRendered += OnBldText;
        _bldInterpreter.CreditsChanged += (amount) => _borderPanel.UpdateInfo(State.CursorX, State.CursorY, amount);
        _bldInterpreter.InterpreterComplete += OnBldComplete;

        // Connetti DialogueBox -> interpreter continue
        _dialogueBox.InputReady += OnDialogueInputReady;

        // Stato iniziale
        _stateManager.State.Credits = 1500;
        _stateManager.State.CurrentMapId = 1;
        _stateManager.SetMode(GameMode.WorldMap);

        GD.Print("GameLoop ready. Phase 3.");
    }

    public override void _Process(double delta) { }

    private void OnCursorMoved(int dx, int dy)
    {
        _stateManager.State.CursorX = Mathf.Clamp(_stateManager.State.CursorX + dx, 0, 127);
        _stateManager.State.CursorY = Mathf.Clamp(_stateManager.State.CursorY + dy, 0, 127);
        _borderPanel.UpdateInfo(_stateManager.State.CursorX, _stateManager.State.CursorY, _stateManager.State.Credits);
        _worldMapView.RenderViewport();
    }

    private void OnActionPressed()
    {
        var (tx, ty) = _stateManager.GetCursorTile();
        GD.Print($"Action at tile ({tx},{ty})");

        // Check if there's a building at this position using BLD mapping
        string poi = "";
        if (_worldMapView != null)
        {
            // TODO: get WorldMapData ref for POI lookup
        }

        // Load TRAINING.BLD for testing the interpreter
        var bldPath = ProjectSettings.GlobalizePath("../../../TRAINING.BLD");
        var jsonPath = ProjectSettings.GlobalizePath("../../../TRAINING.BLD.json");
        var bldDir = ProjectSettings.GlobalizePath("../../../");

        // Try loading from JSON first (pre-converted)
        var script = BldLoader.LoadFromJson(jsonPath, "TRAINING");
        script ??= BldLoader.Load(bldPath, "TRAINING");

        if (script != null)
        {
            _stateManager.SetMode(GameMode.TextScreen);
            _bldInterpreter.LoadAndRun(script);
        }
    }

    private void OnBldText(string text, NarrativeMode mode)
    {
        _dialogueBox.ShowText(text, mode);
        _dialogueBox.WaitForInput();
    }

    private void OnBldComplete()
    {
        GD.Print("BLD interpreter finished");
        _stateManager.SetMode(GameMode.WorldMap);
    }

    private void OnDialogueInputReady()
    {
        GD.Print("Dialogue input ready — resuming interpreter?");
        // TODO: resume interpreter after ADVANCE_INPUT
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

    private void OnFunctionKey(int key) => GD.Print($"F{key}");

    private void OnGameModeChanged(GameMode mode)
    {
        _worldMapView.Visible = mode == GameMode.WorldMap;
        _dialogueBox.Visible = mode == GameMode.TextScreen;
    }
}