using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.Core;

/// <summary>
/// GameLoop principale: init → input → update → render.
/// Mantiene lo stato globale e coordina tutti i sottosistemi.
/// </summary>
public partial class GameLoop : Node
{
    public GameState State { get; private set; } = new();

    public override void _Ready()
    {
        GD.Print("BattleTech: The Crescent Hawk's Inception — Rebuild");
        GD.Print($"RE state: ~90% | Engine state: Phase 0");
        
        // TODO Phase 1:
        // - Inizializza subsystems (MapLoader, BldInterpreter, CombatSystem, etc.)
        // - Carica palette EGA e assets base
        // - Avvia startup sequence (INFOCOM → BTTITLE)
    }

    public override void _Process(double delta)
    {
        // TODO Phase 1: game loop a 6 fasi (match originale)
        // 1. Input handling (rimappato da WASD a tasti freccia originali)
        // 2. Update stato in base al GameMode
        // 3. Render
    }

    public override void _Input(InputEvent @event)
    {
        // TODO Phase 1: key remapping
        // Frecce/ WASD → movimento cursore
        // SPACE → azione / menu
        // F1-F10 → funzioni speciali
        // ESC → pausa/menu
        base._Input(@event);
    }
}