using BattleTechCHI.Data;

namespace BattleTechCHI.Combat;

public static class AiController
{
    public static int SelectTarget(CombatState state, int unitId, int stageCounter)
    {
        int result = -1;
        int matchCount = 0;
        int offset = 0x33;

        while (offset <= 0x55)
        {
            int storyByte = state.GameState.StateArray[offset];
            int masked = storyByte & 0x7F;

            if (masked >= 0x10 && masked <= 0x20)
            {
                if (matchCount == stageCounter)
                {
                    result = masked - 1;
                    if (!state.IsAlive(result))
                        result = -1;
                    break;
                }
                matchCount++;
            }
            offset++;
        }

        return result;
    }

    public static ActionCode GetActionCode(CombatState state, int unitId, int targetId)
    {
        if (targetId < 0 || targetId >= 24)
            return ActionCode.NoAction;

        int dist = state.GetDistance(unitId, targetId);

        if (dist <= ShortMax)
            return ActionCode.ShortRange;
        if (dist <= MediumMax)
            return ActionCode.MediumRange;
        if (dist <= LongMax)
            return ActionCode.LongRange;

        return ActionCode.NoAction;
    }

    private const int ShortMax = 3;
    private const int MediumMax = 6;
    private const int LongMax = 10;

    public static int SelectWeapon(CombatState state, int unitId, int targetId)
    {
        var unit = state.Units[unitId];
        int dist = state.GetDistance(unitId, targetId);
        int bestSlot = -1;
        int bestRange = int.MaxValue;
        int bestDamage = 0;

        if (unit.Ammo == null)
            return -1;

        for (int slot = 0; slot < unit.Ammo.Length; slot++)
        {
            int weaponId = unit.Ammo[slot].WeaponId;
            if (weaponId <= 0 || unit.Ammo[slot].Remaining <= 0)
                continue;

            var weapons = WeaponData.Weapons;
            if (weaponId > weapons.Length)
                continue;

            var wpn = weapons[weaponId - 1];
            if (dist >= wpn.MinRange && dist <= wpn.MaxRange)
            {
                // Prefer shorter-range (more accurate) weapons within range
                int rangeScore = wpn.MaxRange;
                int damageScore = wpn.Damage;

                if (rangeScore < bestRange || (rangeScore == bestRange && damageScore > bestDamage))
                {
                    bestRange = rangeScore;
                    bestDamage = damageScore;
                    bestSlot = slot;
                }
            }
        }

        return bestSlot;
    }
}
