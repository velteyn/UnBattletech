using Godot;
using BattleTechCHI.Data;
using BattleTechCHI.Maps;
using BattleTechCHI.UI;
using BattleTechCHI.BLD;
using BattleTechCHI.Combat;

namespace BattleTechCHI.Core;

public partial class GameLoop : Node
{
    private StateManager _stateManager = null!;
    private InputHandler _inputHandler = null!;
    private TileManager _tileManager = null!;
    private WorldMapView _worldMapView = null!;
    private LocalMapView _localMapView = null!;
    private BorderPanel _borderPanel = null!;
    private BldInterpreter _bldInterpreter = null!;
    private DialogueBox _dialogueBox = null!;
    private CombatManager _combatManager = null!;
    private ShopScreen _shopScreen = null!;

    private bool _startInLocalMap;
    private GameMode _previousMode = GameMode.WorldMap;
    private string _currentBldName = "";

    public StateManager StateManager => _stateManager;
    public GameState State => _stateManager.State;

    public GameLoop(bool startInLocalMap = false)
    {
        _startInLocalMap = startInLocalMap;
    }

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

        // LocalMapView
        _localMapView = new LocalMapView();
        _localMapView.Name = "LocalMapView";
        AddChild(_localMapView);
        _localMapView.Visible = false;

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
        _bldInterpreter.SpriteRequested += OnBldSpriteRequested;
        _bldInterpreter.WorldMapReinitRequested += OnWorldMapReinitRequested;

        // CombatManager
        _combatManager = new CombatManager(_stateManager.State);

        // Connetti DialogueBox -> interpreter continue / menu selection
        _dialogueBox.InputReady += OnDialogueInputReady;
        _dialogueBox.MenuItemSelected += OnMenuItemSelected;

        // ShopScreen (hidden by default, shown on shop dispatch)
        _shopScreen = new ShopScreen();
        _shopScreen.Name = "ShopScreen";
        AddChild(_shopScreen);
        _shopScreen.BuyRequested += OnShopBuy;
        _shopScreen.SellRequested += OnShopSell;
        _shopScreen.ExitShop += OnShopExit;

        // Fn1CD3Dispatcher events
        Fn1CD3Dispatcher.BuildingEntered += (bld) => GD.Print($"  Dispatcher: building entered '{bld}'");
        Fn1CD3Dispatcher.CreditsDisplayed += (amount) => _borderPanel.UpdateInfo(State.CursorX, State.CursorY, amount);
        Fn1CD3Dispatcher.RenderingRequested += (handler) => GD.Print($"  Dispatcher: render request '{handler}'");
        Fn1CD3Dispatcher.ActionTriggered += () => GD.Print("  Dispatcher: action triggered");
        Fn1CD3Dispatcher.SaveRequested += () => GD.Print("  Dispatcher: save positions");
        Fn1CD3Dispatcher.RestoreRequested += () => GD.Print("  Dispatcher: restore positions");

        // Stato iniziale
        _stateManager.State.Credits = 1500;
        _stateManager.State.CurrentMapId = 1;

        if (_startInLocalMap)
        {
            _stateManager.State.CursorX = 32;
            _stateManager.State.CursorY = 32;
            _stateManager.SetMode(GameMode.LocalTiles);
            _localMapView.LoadMap(1);
        }
        else
        {
            _stateManager.State.CursorX = 52;
            _stateManager.State.CursorY = 10;
            _stateManager.SetMode(GameMode.WorldMap);
        }

        GD.Print("GameLoop ready. Phase 3.");
    }

    public override void _Process(double delta)
    {
        if (_combatManager.CombatActive)
        {
            _combatManager.ProcessTick();
        }
        else if (_stateManager.State.Mode == GameMode.Combat &&
                 !_combatManager.State.Active)
        {
            StartCombatEncounter();
        }
        else if (_stateManager.State.Mode == GameMode.LocalTiles)
        {
            _localMapView.NpcController.ProcessTick();
        }

        // Safety: if BLD interpreter is running in TextScreen mode but not waiting
        // for input, nudge it. In normal flow ProcessNext runs synchronously until
        // yield inside the interpreter's own call chain, so this should not fire.
        if (_stateManager.State.Mode == GameMode.TextScreen &&
            _bldInterpreter.IsRunning && !_bldInterpreter.WaitingForInput && !_bldInterpreter.WaitingForMenu)
            _bldInterpreter.ProcessNext();
    }

    private void OnCursorMoved(int dx, int dy)
    {
        var mode = _stateManager.State.Mode;
        if (mode == GameMode.LocalTiles)
        {
            int curX = _stateManager.State.CursorX;
            int curY = _stateManager.State.CursorY;
            int newX = curX + dx;
            int newY = curY + dy;
            int mapW = _localMapView.CurrentMap?.Width ?? 64;
            int mapH = _localMapView.CurrentMap?.Height ?? 64;

            // Edge transition: walking off the map edge
            if (newX < 0 || newX >= mapW || newY < 0 || newY >= mapH)
            {
                var worldPos = LocationMapper.GetWorldTileForMap(
                    _stateManager.State.CurrentMapId);
                if (worldPos.HasValue)
                {
                    int wtX = worldPos.Value.tileX;
                    int wtY = worldPos.Value.tileY;
                    if (newX < 0) wtX -= 1;
                    else if (newX >= mapW) wtX += 1;
                    if (newY < 0) wtY -= 1;
                    else if (newY >= mapH) wtY += 1;
                    wtX = Mathf.Clamp(wtX, 0, 63);
                    wtY = Mathf.Clamp(wtY, 0, 63);
                    TransitionToWorldMap(wtX, wtY);
                }
                return;
            }

            _stateManager.State.CursorX = newX;
            _stateManager.State.CursorY = newY;
            _localMapView.RenderMap();
        }
        else
        {
            _stateManager.State.CursorX = Mathf.Clamp(_stateManager.State.CursorX + dx, 0, 127);
            _stateManager.State.CursorY = Mathf.Clamp(_stateManager.State.CursorY + dy, 0, 127);
            _borderPanel.UpdateInfo(_stateManager.State.CursorX, _stateManager.State.CursorY, _stateManager.State.Credits);
            _worldMapView.RenderViewport();
        }
    }

    private void OnActionPressed()
    {
        var mode = _stateManager.State.Mode;
        int tx, ty;
        if (mode == GameMode.LocalTiles)
        {
            tx = _stateManager.State.CursorX;
            ty = _stateManager.State.CursorY;
        }
        else
        {
            (tx, ty) = _stateManager.GetCursorTile();
        }

        if (mode == GameMode.LocalTiles)
        {
            HandleLocalMapAction(tx, ty);
        }
        else if (mode == GameMode.WorldMap)
        {
            HandleWorldMapAction(tx, ty);
        }
    }

    private void HandleLocalMapAction(int tileX, int tileY)
    {
        GD.Print($"Action on local map at tile ({tileX},{tileY})");

        if (_localMapView.CurrentMap == null) return;

        // Check if an NPC is at this tile
        var ctrl = _localMapView.NpcController;
        for (int i = 0; i < ctrl.Count; i++)
        {
            if (ctrl.GetX(i) == tileX && ctrl.GetY(i) == tileY)
            {
                string npcName = ctrl.GetName(i);
                if (!string.IsNullOrEmpty(npcName))
                {
                    GD.Print($"Encounter NPC: {npcName}");
                    _dialogueBox.ShowText($"[{npcName}]", NarrativeMode.CharacterSpeech);
                    _dialogueBox.WaitForInput();
                    _stateManager.SetMode(GameMode.TextScreen);
                    return;
                }
            }
        }

        // Check for building
        var bldName = _localMapView.GetBuildingNameAtTile(tileX, tileY);
        if (!string.IsNullOrEmpty(bldName))
        {
            GD.Print($"Building: {bldName}");
            LoadBldForLocalBuilding(bldName);
        }
    }

    private void HandleWorldMapAction(int tileX, int tileY)
    {
        GD.Print($"Action on world map at tile ({tileX},{tileY})");

        var bldIndex = LocationMapper.GetBldIndex(tileX, tileY);
        if (bldIndex == null)
        {
            GD.Print("No building/POI here.");
            return;
        }

        var bldName = LocationMapper.GetBldName(bldIndex.Value);
        GD.Print($"Location: {bldName}");

        // If this world tile has an associated local map, enter it first
        var mapId = LocationMapper.GetMapId(tileX, tileY);
        if (mapId.HasValue)
        {
            GD.Print($"Entering local map {mapId.Value}");
            TransitionToLocalMap(mapId.Value, 32, 32);
        }

        // Run the BLD script (shows entry menu, story, shops, etc.)
        var bldPath = ProjectSettings.GlobalizePath($"../original/bld/{bldName}.BLD");
        var script = BldLoader.Load(bldPath, bldName);
        if (script != null)
        {
            _currentBldName = bldName;
            _previousMode = mapId.HasValue ? GameMode.LocalTiles : GameMode.WorldMap;
            _stateManager.SetMode(GameMode.TextScreen);
            _bldInterpreter.LoadAndRun(script);
        }
    }

    private void LoadBldForLocalBuilding(string buildingName)
    {
        // Normalize building name for BLD lookup
        var bldName = buildingName switch
        {
            "Training Center" => "TRAINING",
            "Citadel" => "CITADEL",
            "ComStar Station" => "COMSTAR",
            "Weapons Shop" => "WEAPON",
            "Armor Shop" => "ARMOR",
            "Mechit-Lube" => "GARAGE",
            "Barracks" => "BARRACKS",
            "Barracks 2" => "BARRACK2",
            "Lounge" => "LOUNGE",
            "Hospital" => "HOSPITAL",
            "Clothes Shop" => "CLOTHES",
            "Theater" => "THEATER",
            "Viewdisk" => "VIEWDISK",
            "Arena" => "ARENA",
            "Repair Shop" => "REPAIR",
            "Party" => "PARTY",
            "Hut" => "HUT",
            "Jail" => "JAIL",
            "Mayor" => "MAYOR",
            "Hotel" => "FROB",
            "Findit" => "FINDIT",
            _ => null
        };

        if (bldName == null)
        {
            GD.Print($"No BLD mapping for '{buildingName}'");
            return;
        }

        var bldPath = ProjectSettings.GlobalizePath($"../original/bld/{bldName}.BLD");
        var script = BldLoader.Load(bldPath, bldName);
        if (script != null)
        {
            _currentBldName = bldName;
            _previousMode = GameMode.LocalTiles;
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
        GD.Print($"BLD interpreter finished — mode={_stateManager.State.Mode}, prev={_previousMode}");
        // Only restore previous mode if the dispatcher didn't already change it
        // (e.g. ExitBuilding sets WorldMap, CombatEncounter sets Combat)
        if (_stateManager.State.Mode == GameMode.TextScreen)
            _stateManager.SetMode(_previousMode);
    }

    private void OnDialogueInputReady()
    {
        GD.Print("Dialogue input ready — resuming interpreter");
        _bldInterpreter.ResumeAfterInput();
    }

    private void OnMenuItemSelected(int index)
    {
        GD.Print($"Menu item selected: {index}");
        _bldInterpreter.ResumeAfterMenuSelection(index);
    }

    /// <summary>
    /// Called by BldInterpreter when a menu needs to be shown.
    /// </summary>
    public void ShowMenuForBld(string text)
    {
        _dialogueBox.ShowMenu(text);
    }

    private void OnWorldMapReinitRequested()
    {
        _worldMapView.Reinitialize();
    }

    // ── ShopScreen handlers ────────────────────────────────────
    private void OnShopBuy(int slot)
    {
        GD.Print($"Shop buy requested: slot {slot}");
        var shop = ShopRegistry.Get(_currentBldName);
        if (shop != null)
            Fn1CD3Dispatcher.Dispatch(0x05, State, _currentBldName, shop);
    }

    private void OnShopSell(int slot)
    {
        GD.Print($"Shop sell requested: slot {slot}");
        var shop = ShopRegistry.Get(_currentBldName);
        if (shop != null)
            Fn1CD3Dispatcher.Dispatch(0x08, State, _currentBldName, shop);
    }

    private void OnShopExit()
    {
        GD.Print("Shop exit");
        _shopScreen.Visible = false;
        if (_stateManager.State.Mode == GameMode.TextScreen)
            _bldInterpreter.ResumeAfterInput();
    }

    private void OnMenuPressed(int index)
    {
        switch (index)
        {
            case 1:
                _stateManager.SetMode(GameMode.WorldMap);
                break;
            case 2:
                if (_stateManager.State.Mode != GameMode.LocalTiles)
                {
                    _stateManager.SetMode(GameMode.LocalTiles);
                    if (_localMapView.CurrentMap == null)
                        _localMapView.LoadMap(_stateManager.State.CurrentMapId);
                    else
                        _localMapView.RenderMap();
                }
                break;
            case 3: _stateManager.SetMode(GameMode.TextScreen); break;
            case 4: _stateManager.SetMode(GameMode.BuildingName); break;
        }
    }

    private void OnFunctionKey(int key) => GD.Print($"F{key}");

    private void OnBldSpriteRequested(int spriteId)
    {
        GD.Print($"GameLoop: BLD sprite request {spriteId} for '{_currentBldName}'");
        // Try to load building interior bitmap from Assets/{bldName}.png
        var path = ProjectSettings.GlobalizePath($"res://Assets/{_currentBldName}.png");
        if (System.IO.File.Exists(path))
        {
            var img = Image.LoadFromFile(path);
            if (img != null)
            {
                _dialogueBox.ShowSprite(ImageTexture.CreateFromImage(img));
                return;
            }
        }
        _dialogueBox.ShowSprite(null); // placeholder will be drawn as empty frame
    }

    public void StartCombatEncounter()
    {
        GD.Print("GameLoop: starting combat encounter");
        _combatManager.StartCombat(() => {
            GD.Print("Combat ended callback");
        });
    }

    private void OnGameModeChanged(GameMode mode)
    {
        _worldMapView.Visible = mode == GameMode.WorldMap;
        _localMapView.Visible = mode == GameMode.LocalTiles;
        _dialogueBox.Visible = mode == GameMode.TextScreen;
        _shopScreen.Visible = mode == GameMode.BuildingName; // shown on dispatch requests
        _borderPanel.Visible = mode == GameMode.WorldMap || mode == GameMode.LocalTiles;
    }

    /// <summary>
    /// Switch from local map to world map at a given world tile.
    /// </summary>
    public void TransitionToWorldMap(int worldTileX, int worldTileY)
    {
        _stateManager.State.CursorX = worldTileX * 2;
        _stateManager.State.CursorY = worldTileY * 2;
        _stateManager.State.CurrentMapId = 0;
        _stateManager.SetMode(GameMode.WorldMap);
    }

    /// <summary>
    /// Switch from world map to local map.
    /// </summary>
    public void TransitionToLocalMap(int mapId, int startTileX, int startTileY)
    {
        _stateManager.State.CursorX = startTileX;
        _stateManager.State.CursorY = startTileY;
        _stateManager.State.CurrentMapId = mapId;
        _stateManager.SetMode(GameMode.LocalTiles);
        _localMapView.LoadMap(mapId);
    }
}