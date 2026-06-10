using BattleTechCHI.Data;

namespace BattleTechCHI.Combat;

/// <summary>
/// AI target selection — exact algorithm from ghidra_guess_1000_0AB2_10AB2.
///
/// Story state properties at offsets 0x33-0x55 encode a target preference
/// sequence per unit. Each byte = (target_slot_id + 1) in range 0x10-0x20.
/// The stage counter selects which n-th valid target to use.
/// </summary>
public static class AiController
{
    /// <summary>
    /// Select target for the given enemy unit using data-driven preferences.
    /// </summary>
    /// <param name="state">Combat state</param>
    /// <param name="unitId">Enemy unit ID (4-11)</param>
    /// <param name="stageCounter">Stage counter [BP-0x42]</param>
    /// <returns>Target unit ID, or -1 (0xFF) if no valid target.</returns>
    public static int SelectTarget(CombatState state, int unitId, int stageCounter)
    {
        int result = -1;          // [BP-0x8], default 0xFF
        int matchCount = 0;       // [BP-0x2]
        int offset = 0x33;        // [BP-0x4], start of AI preference table

        // Base address: ES:0xC724 + unitId * 0x7D
        int structBase = 0xC724 + unitId * 0x7D;

        while (offset <= 0x55)
        {
            int storyByte = state.GameState.StateArray[offset];
            int masked = storyByte & 0x7F;

            if (masked >= 0x10 && masked <= 0x20)
            {
                if (matchCount == stageCounter)
                {
                    // Found the n-th preference — target = (preference - 1)
                    result = masked - 1;

                    // Validate: check story state offset 0x27+stage for non-zero
                    int validateOffset = structBase + 0x27 + stageCounter;
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

    /// <summary>
    /// Compute action code for a unit — from ghidra_guess_1000_0934_10934.
    /// Returns 1 (short), 2 (medium), 3 (long), or 4 (no action).
    /// Maps to: AX < 3 → can act, AX >= 3 → skip.
    /// </summary>
    public static ActionCode GetActionCode(CombatState state, int unitId, int targetId)
    {
        if (targetId < 0 || targetId >= 24)
            return ActionCode.NoAction;

        var src = state.GetUnitPos(unitId);
        var dst = state.GetUnitPos(targetId);

        int dx = Math.Abs(dst.x - src.x);
        int dy = Math.Abs(dst.y - src.y);
        int dist = Math.Max(dx, dy);

        // Weapon range lookup — use the unit's first weapon
        // Base: action_code * 2 + 4 determines to-hit TN
        if (dist <= 3)
            return ActionCode.ShortRange;   // TN 6
        if (dist <= 6)
            return ActionCode.MediumRange;  // TN 8
        if (dist <= 10)
            return ActionCode.LongRange;    // TN 10

        return ActionCode.NoAction;
    }

    /// <summary>
    /// Find the best weapon for a unit against a target at given range.
    /// Iterates weapon slots (0xB max) checking range & ammo.
    /// </summary>
    public static int SelectWeapon(CombatState state, int unitId, int targetId)
    {
        int weaponSlot = 0;
        int bestWeapon = -1;
        int bestRange = int.MaxValue;

        int srcX = state.Units[unitId].UnitX;
        int srcY = state.Units[unitId].UnitY;
        int dstX = state.Units[targetId].UnitX;
        int dstY = state.Units[targetId].UnitY;
        int dist = Math.Max(Math.Abs(dstX - srcX), Math.Abs(dstY - srcY));

        // Scan weapon slots for best match
        // Original code stores weapon data at ES:[BX+0x2EE8] with 0x11 stride
        // Using story slot weapon data from StateArray
        for (int slot = 0; slot <= 0xB; slot++)
        {
            int weaponId = state.GameState.StateArray[0x18 + slot];
            if (weaponId == 0 || weaponId == 0xFF)
                continue;

            // Look up weapon in data table
            var weapons = WeaponData.Weapons;
            if (weaponId > weapons.Length)
                continue;

            var wpn = weapons[weaponId - 1];
            if (dist >= wpn.MinRange && dist <= wpn.MaxRange)
            {
                // Check ammo
                int ammo = state.Units[unitId].CurrentAmmo != null &&
                           slot < state.Units[unitId].CurrentAmmo.Length
                    ? state.Units[unitId].CurrentAmmo[slot]
                    : -1;

                if (ammo == 0)
                    continue;

                if (wpn.MaxRange < bestRange)
                {
                    bestRange = wpn.MaxRange;
                    bestWeapon = weaponId;
                    weaponSlot = slot;
                }
            }
        }

        return weaponSlot;
    }
}
