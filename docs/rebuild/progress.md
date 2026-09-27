# Rebuild Progress — Godot 4 + C#

> Canonical rebuild progress/status. For phases and estimates see `docs/rebuild/roadmap.md`.


The old Java/Swing prototype has been **deleted** — it was a hardcoded dead end. The official rebuild is in `BattleTechCHI/`, a Godot 4 C# project.

**File structure:**
```
BattleTechCHI/
├── project.godot              # Godot 4 config, 320x200 viewport
├── BattleTechCHI.csproj       # .NET 8.0
├── BattleTechCHI.sln
├── .gitignore
├── Assets/                    # (empty — linked from parent Assets/) 
├── Data/                      # BLD JSON pre-converted
├── Scripts/
│   ├── Main.cs                # Entry: Node2D → GameLoop
│   ├── Core/
│   │   ├── GameLoop.cs        # Init → input → update → render, coordina tutti i subsystems
│   │   ├── StateManager.cs     # w4FBA mode, 3-layer state machine
│   │   ├── InputHandler.cs     # WASD/frecce, SPACE, F1-F10, 1-4
│   │   └── SaveManager.cs      # Save/Load formato GAME1-6
│   ├── Data/
│   │   ├── GameEnums.cs        # GameMode, MapFormat, BldOpcode, NarrativeMode
│   │   ├── GameState.cs        # Stato globale + StorySlot
│   │   ├── DataModels.cs       # BldScript, MapData, MechDef, WeaponSlot
│   │   ├── WeaponData.cs       # 33 armi tabellate
│   │   └── CipherDecoder.cs    # Traduzione cipher BLD → testo
│   ├── Maps/
│   │   ├── MapLoader.cs        # Carica .MTP (BlockFormat/LinearFormat)
│   │   ├── RleDecompressor.cs  # Decompressione .CMP/.ICN/.ANM (Format 01/02)
│   │   ├── TileManager.cs      # Carica tileset BMP, fornisce texture per tile ID
│   │   ├── WorldMapData.cs     # Dati world map 64×64, visibilità 128×128, POI
│   │   ├── WorldMapView.cs     # TileMap viewport 8×8 con fog of war
│   │   └── LocalMapView.cs     # TileMap viewport per MAP1-14.MTP
│   ├── BLD/
│   │   └── BldLoader.cs        # Carica e decripta .BLD
│   ├── Combat/
│   │   ├── CombatManager.cs    # Loop 12-fasi: movimento, to-hit, danno, kill chain
│   │   ├── CombatView.cs       # TileMap 15×12 + sprite2D unità (ricreati ogni frame)
│   │   ├── CombatHUD.cs        # Overlay sinistro 80px in combattimento + mech portrait
│   │   ├── CombatState.cs      # Stato combattimento, griglie fog 12×24
│   │   ├── CombatResolver.cs   # RNG (LFSR 24-bit), LoS (Bresenham), danno
│   │   ├── CombatTypes.cs      # MechState, HitLocation, ActionCode enum
│   │   └── MechPortrait.cs     # Mech animato (scala 2× da MECHSHAP, stati idle/move/fire/danno)
│   ├── BLD/
│   │   └── BldLoader.cs        # Carica e decripta .BLD
│       ├── EgaPalette.cs       # Palette EGA 16 colori + custom asset
│       ├── AnmPlayer.cs        # Player animazioni ANM (88×88, timer-based, FPS configurabile)
│       ├── BorderPanel.cs      # Pannello sinistro 80px + bordo EGA + AnmPlayer
│       ├── StartupSequence.cs  # INFOCOM → BTTITLE → gioco
│       ├── DialogueBox.cs      # Testo BLD, sprite, menu interattivo
│       └── ShopScreen.cs       # Interfaccia compra/vendita
├── Scenes/
│   └── Main.tscn
├── Assets/
│   └── Animations/             # Spritesheet ANM O0–O16 (88×88 px, 321 PNG, 1.4MB)
└── docs/
    └── reference/
        └── anm-format.md        # ANM format spec (XOR-delta RLE)
```

**Status**: Phase 5 in progress (~8,000 lines C#). Phases 0-4 done: core systems, tile rendering, world/local maps, BLD interpreter (26 opcodes) + 47-case dispatcher, shops/dialogue, full combat system. Phase 5 shipped: AnmPlayer, ViewportManager, BldAnmMap, runtime ANM decompress, animation dispatch on hover, combat mech panel ANM (MechPortrait). Remaining: stock market, tech screen, end-to-end playtesting.

---

