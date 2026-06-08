using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.Core;

/// <summary>
/// Gestisce il movimento NPC sulla mappa locale.
/// Ogni NPC pattuglia tra waypoint, con pathfinding semplice (tile-step).
/// Basato sulla RE del motore originale fn0800_24C2.
/// </summary>
public partial class NpcController : Node
{
    private MapData? _mapData;
    private int _npcCount;
    private string[] _npcNames = System.Array.Empty<string>();
    private int[] _npcX = System.Array.Empty<int>();
    private int[] _npcY = System.Array.Empty<int>();
    private int[] _destX = System.Array.Empty<int>();
    private int[] _destY = System.Array.Empty<int>();
    private int[] _moveTimer = System.Array.Empty<int>();
    private int[] _buildingIdx = System.Array.Empty<int>();
    private int[] _direction = System.Array.Empty<int>();
    private int _frameCounter;

    private const int MoveInterval = 8;
    private const int PauseFrames = 40;
    private const int ProcessMod = 3;

    public int Count => _npcCount;

    public void Initialize(MapData map)
    {
        _mapData = map;
        int maxNpc = Mathf.Min(Mathf.Min(map.NpcPositions.Length, map.NpcNames.Length), 8);

        _npcCount = maxNpc;
        _npcNames = new string[_npcCount];
        _npcX = new int[_npcCount];
        _npcY = new int[_npcCount];
        _destX = new int[_npcCount];
        _destY = new int[_npcCount];
        _moveTimer = new int[_npcCount];
        _buildingIdx = new int[_npcCount];
        _direction = new int[_npcCount];

        for (int i = 0; i < _npcCount; i++)
        {
            _npcNames[i] = map.NpcNames[i];
            _npcX[i] = map.NpcPositions[i].x;
            _npcY[i] = map.NpcPositions[i].y;
            _buildingIdx[i] = i < map.NpcToBuilding.Length ? map.NpcToBuilding[i] : -1;
            _moveTimer[i] = (int)(GD.Randi() % MoveInterval);
            _direction[i] = (int)(GD.Randi() & 7);
            PickNewDestination(i);
        }
        _frameCounter = 0;
    }

    public void ProcessTick()
    {
        if (_mapData == null || _npcCount == 0) return;

        _frameCounter++;
        if (_frameCounter % ProcessMod != 0) return;

        for (int i = 0; i < _npcCount; i++)
        {
            _moveTimer[i]--;
            if (_moveTimer[i] > 0) continue;

            // Move one step toward destination
            int dx = _destX[i] - _npcX[i];
            int dy = _destY[i] - _npcY[i];

            if (dx == 0 && dy == 0)
            {
                PickNewDestination(i);
                continue;
            }

            int stepX = dx > 0 ? 1 : (dx < 0 ? -1 : 0);
            int stepY = dy > 0 ? 1 : (dy < 0 ? -1 : 0);

            bool moved = false;
            // Priority: move along longer axis
            if (Mathf.Abs(dx) >= Mathf.Abs(dy))
            {
                moved = TryMove(i, stepX, 0) || TryMove(i, 0, stepY);
            }
            else
            {
                moved = TryMove(i, 0, stepY) || TryMove(i, stepX, 0);
            }

            if (!moved)
            {
                // Blocked — pick a new destination
                PickNewDestination(i);
            }

            _moveTimer[i] = MoveInterval;
        }
    }

    private bool TryMove(int i, int dx, int dy)
    {
        int nx = _npcX[i] + dx;
        int ny = _npcY[i] + dy;
        if (IsWalkable(nx, ny) && !IsOccupied(nx, ny, i))
        {
            _npcX[i] = nx;
            _npcY[i] = ny;
            // Store facing direction
            if (dx != 0) _direction[i] = dx > 0 ? 0 : 4;
            if (dy != 0) _direction[i] = dy > 0 ? 2 : 6;
            return true;
        }
        return false;
    }

    private void PickNewDestination(int i)
    {
        if (_mapData == null) return;
        int mapW = _mapData.Width;
        int mapH = _mapData.Height;

        // Patrol near assigned building or current area
        for (int attempt = 0; attempt < 12; attempt++)
        {
            int range = (int)(GD.Randi() % 3) + 2;
            int tx = _npcX[i] + (int)(GD.Randi() % (range * 2 + 1)) - range;
            int ty = _npcY[i] + (int)(GD.Randi() % (range * 2 + 1)) - range;
            tx = Mathf.Clamp(tx, 1, mapW - 2);
            ty = Mathf.Clamp(ty, 1, mapH - 2);

            if (IsWalkable(tx, ty) && !IsOccupied(tx, ty, i) && (tx != _npcX[i] || ty != _npcY[i]))
            {
                _destX[i] = tx;
                _destY[i] = ty;
                _moveTimer[i] = (int)(GD.Randi() % PauseFrames);
                return;
            }
        }
        // Stand still
        _destX[i] = _npcX[i];
        _destY[i] = _npcY[i];
        _moveTimer[i] = PauseFrames;
    }

    private bool IsWalkable(int tx, int ty)
    {
        if (_mapData == null) return false;
        if (tx < 0 || tx >= _mapData.Width || ty < 0 || ty >= _mapData.Height)
            return false;
        int idx = ty * _mapData.Width + tx;
        if (idx >= _mapData.TileData.Length) return false;
        byte tile = _mapData.TileData[idx];
        return tile != 0x00;
    }

    private bool IsOccupied(int tx, int ty, int excludeIdx)
    {
        for (int i = 0; i < _npcCount; i++)
        {
            if (i != excludeIdx && _npcX[i] == tx && _npcY[i] == ty)
                return true;
        }
        return false;
    }

    public string GetName(int idx) => idx < _npcNames.Length ? _npcNames[idx] : "";
    public int GetX(int idx) => idx < _npcX.Length ? _npcX[idx] : 0;
    public int GetY(int idx) => idx < _npcY.Length ? _npcY[idx] : 0;
    public int GetDirection(int idx) => idx < _direction.Length ? _direction[idx] : 0;
    public int GetBuildingIdx(int idx) => idx < _buildingIdx.Length ? _buildingIdx[idx] : -1;
}
