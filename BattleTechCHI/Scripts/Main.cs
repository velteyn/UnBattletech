using Godot;
using BattleTechCHI.Core;
using BattleTechCHI.UI;

namespace BattleTechCHI;

public partial class Main : Node2D
{
    private GameLoop? _gameLoop;

    public override void _Ready()
    {
        var startup = new StartupSequence();
        startup.Name = "StartupSequence";
        AddChild(startup);
        startup.StartupComplete += OnStartupComplete;
    }

    private void OnStartupComplete()
    {
        ShowFirstTimeDialog();
    }

    private void ShowFirstTimeDialog()
    {
        var dialog = new OptionDialog("Is this your first time playing BattleTech?");
        dialog.Name = "FirstTimeDialog";
        AddChild(dialog);
        dialog.OptionChosen += OnFirstTimeChoice;
    }

    private void OnFirstTimeChoice(int index)
    {
        if (index == 0)
        {
            StartNewGameLocal();
        }
        else
        {
            ShowLoadGameDialog();
        }
    }

    private void ShowLoadGameDialog()
    {
        var dialog = new OptionDialog("Do you want to load an old game?");
        AddChild(dialog);
        dialog.OptionChosen += (int idx) =>
        {
            if (idx == 0)
            {
                GD.Print("Load game — TBD, falling back to world map");
                StartNewGameWorldMap();
            }
            else
            {
                StartNewGameWorldMap();
            }
        };
    }

    private void StartNewGameLocal()
    {
        _gameLoop = new GameLoop(startInLocalMap: true);
        _gameLoop.Name = "GameLoop";
        AddChild(_gameLoop);
        GD.Print("Main: GameLoop created (local map start).");
    }

    private void StartNewGameWorldMap()
    {
        _gameLoop = new GameLoop(startInLocalMap: false);
        _gameLoop.Name = "GameLoop";
        AddChild(_gameLoop);
        GD.Print("Main: GameLoop created (world map start).");
    }
}