using Godot;
using BattleTechCHI.Core;

namespace BattleTechCHI;

public partial class Main : Node2D
{
    private GameLoop? _gameLoop;

    public override void _Ready()
    {
        _gameLoop = new GameLoop();
        AddChild(_gameLoop);
        
        GD.Print("Main scene ready.");
    }
}