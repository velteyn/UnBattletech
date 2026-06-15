using Godot;
using BattleTechCHI.Data;
using BattleTechCHI.Maps;
using BattleTechCHI.UI;
using BattleTechCHI.BLD;
using BattleTechCHI.Combat;
using System.IO;

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
    private CombatView _combatView = null!;
    private CombatHUD _combatHud = null!;
    private ShopScreen _shopScreen = null!;

    private bool _startInLocalMap;
    private GameMode _previousMode = GameMode.WorldMap;
    private string _currentBldName = "";
    private bool _wasCombatActive;

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

        // CombatView (tile grid positioned in right 240px area)
        _combatView = new CombatView();
        _combatView.Name = "CombatView";
        _combatView.Position = new Vector2(80, 0);
        AddChild(_combatView);
        _combatView.SetState(_combatManager.State, State);
        _combatView.Hide();

        // CombatHUD (info overlay in left 80px panel)
        _combatHud = new CombatHUD();
        _combatHud.Name = "CombatHUD";
        AddChild(_combatHud);
        _combatHud.SetState(_combatManager.State, State);
        _combatHud.Hide();

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

    public override void _Input(InputEvent @event)
    {
        if (_stateManager.State.Mode != GameMode.Combat || !_combatManager.CombatActive)
            return;

        if (@event is InputEventKey key && key.Pressed && !key.Echo)
        {
            bool handled = true;
            switch (key.Keycode)
            {
                case Key.Up or Key.W:
                    _combatManager.MovePlayerCursor(0, -1);
                    break;
                case Key.Down or Key.S:
                    _combatManager.MovePlayerCursor(0, 1);
                    break;
                case Key.Left or Key.A:
                    _combatManager.MovePlayerCursor(-1, 0);
                    break;
                case Key.Right or Key.D:
                    _combatManager.MovePlayerCursor(1, 0);
                    break;
                case Key.Space or Key.Enter:
                    _combatManager.ConfirmPlayerAction();
                    break;
                case Key.Escape:
                    _combatManager.CancelPlayerAction();
                    break;
                case Key.Key1: _combatManager.SelectWeaponByNumber(0); break;
                case Key.Key2: _combatManager.SelectWeaponByNumber(1); break;
                case Key.Key3: _combatManager.SelectWeaponByNumber(2); break;
                case Key.Key4: _combatManager.SelectWeaponByNumber(3); break;
                case Key.Key5: _combatManager.SelectWeaponByNumber(4); break;
                case Key.Key6: _combatManager.SelectWeaponByNumber(5); break;
                case Key.Key7: _combatManager.SelectWeaponByNumber(6); break;
                case Key.Key8: _combatManager.SelectWeaponByNumber(7); break;
                case Key.Key9: _combatManager.SelectWeaponByNumber(8); break;
                default:
                    handled = false;
                    break;
            }

            if (handled)
                GetViewport().SetInputAsHandled();
        }
    }

    public override void _Process(double delta)
    {
        if (_combatManager.CombatActive)
        {
            _combatManager.ProcessTick();
            _combatView.RenderCombat();
            _combatHud.UpdateDisplay();
            _borderPanel.UpdateInfo(State.CursorX, State.CursorY, State.Credits, GameMode.Combat);
            _wasCombatActive = true;
        }
        else if (_wasCombatActive)
        {
            // Combat just ended — restore view visibility
            _wasCombatActive = false;
            OnGameModeChanged(_stateManager.State.Mode);
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

        // World map random encounter check
        if (_stateManager.State.Mode == GameMode.WorldMap)
        {
            if (State.EncounterCooldown > 0)
                State.EncounterCooldown--;

            if (State.EncounterCooldown == 0 &&
                (Combat.CombatResolver.RngByte() & State.EncounterMask) == 0)
            {
                State.EncounterCooldown = 63;
                GD.Print("Random encounter triggered!");
                _stateManager.SetMode(GameMode.Combat);
            }
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

        var bldName = SelectBldForTile(tileX, tileY, bldIndex.Value);
        GD.Print($"Location: {bldName}");

        // If this world tile has an associated local map, enter it first
        var mapId = LocationMapper.GetMapId(tileX, tileY);
        if (mapId.HasValue)
        {
            GD.Print($"Entering local map {mapId.Value}");
            TransitionToLocalMap(mapId.Value, 32, 32);
        }

        // Run the BLD script (shows entry menu, story, shops, etc.)
        var bldPath = GetBldPath(bldName);
        var script = BldLoader.Load(bldPath, bldName);
        if (script != null)
        {
            _currentBldName = bldName;
            _previousMode = mapId.HasValue ? GameMode.LocalTiles : GameMode.WorldMap;
            _stateManager.SetMode(GameMode.TextScreen);
            _bldInterpreter.LoadAndRun(script);
        }
    }

    /// <summary>
    /// State-aware BLD selection for tiles with multiple BLDs (e.g. Citadel tile 26,5).
    /// Falls back to LocationMapper default for tiles with a single BLD.
    /// </summary>
    private string SelectBldForTile(int tileX, int tileY, int defaultIndex)
    {
        // Tile (26,5) map 1: shared by TRAINING, CITADEL, ENDMECH, WINSCENE
        if (tileX == 26 && tileY == 5)
        {
            // WINSCENE: endgame — all objectives done
            if (State.Milestone && State.StateArray[0x53] == 1)
                return "WINSCENE";
            // ENDMECH: Phoenix Hawk discovery — cache found
            if (State.TrainingComplete && State.StateArray[0x52] == 1)
                return "ENDMECH";
            // CITADEL: story hub — after basic training
            if (State.TrainingComplete)
                return "CITADEL";
            // TRAINING: default (tutorial intro)
            return "TRAINING";
        }
        return LocationMapper.GetBldName(defaultIndex);
    }

    private static string GetBldPath(string bldName)
    {
        var projectDir = ProjectSettings.GlobalizePath("res://");
        return Path.GetFullPath(Path.Combine(projectDir, "..", "original", "bld", $"{bldName}.BLD"));
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

        var bldPath = GetBldPath(bldName);
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
            _wasCombatActive = false;
            OnGameModeChanged(_stateManager.State.Mode);
            GD.Print("Combat ended — restored world map");
        });
    }

    private void OnGameModeChanged(GameMode mode)
    {
        _worldMapView.Visible = mode == GameMode.WorldMap;
        _localMapView.Visible = mode == GameMode.LocalTiles;
        _dialogueBox.Visible = mode == GameMode.TextScreen;
        _shopScreen.Visible = mode == GameMode.BuildingName;
        _combatView.Visible = mode == GameMode.Combat;
        _combatHud.Visible = mode == GameMode.Combat;
        _borderPanel.Visible = mode is GameMode.WorldMap or GameMode.LocalTiles or GameMode.Combat;
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