using Godot;
using BattleTechCHI.Data;
using BattleTechCHI.Core;

namespace BattleTechCHI.BLD;

/// <summary>
/// Dispatcher per fn1CD3_0004: 47 casi (0x01-0x2F) che gestiscono
/// tutte le interazioni con edifici e personaggi.
/// Chiamato dall'opcode BLD 0xF5 (SHOP_DISPATCH).
/// Uses the Strategy pattern via IShopInventory for building-specific
/// pricing and item catalogs.
/// Returns GameMode? — null if no mode change, new mode if dispatcher
/// requests a mode transition (e.g. ExitBuilding → WorldMap).
/// </summary>
public static partial class Fn1CD3Dispatcher
{
    public static GameMode? Dispatch(byte caseVal, GameState state, IShopInventory? shop = null)
    {
        GD.Print($"  fn1CD3 case 0x{caseVal:X2} (shop={shop?.ShopName ?? "none"})");
        switch (caseVal)
        {
            case 0x01: return EnterBuilding(state);
            case 0x02: ShowGreeting(state); return null;
            case 0x03: return ExitBuilding();
            case 0x04: ShowShopItems(state, shop); return null;
            case 0x05: BuyItemSingle(state, shop); return null;
            case 0x06: ShowPlayerItems(state); return null;
            case 0x07: BuyItemBulk(state, shop); return null;
            case 0x08: SellItemBulk(state, shop); return null;
            case 0x09: HospitalHeal(state); return null;
            case 0x0A: ShowCredits(state); return null;
            case 0x0B: BuyWithUnitSel(state, shop); return null;
            case 0x0C: return CloseAction();
            case 0x0D: EquipmentMenu(state); return null;
            case 0x0E: CountUnitSlots(state); return null;
            case 0x0F: EquipSlot5(state); return null;
            case 0x10: CheckEquipSlot5(state); return null;
            case 0x11: CountStorySlots(state); return null;
            case 0x12: Dispatch11B8_0002(state); return null;
            case 0x13: Dispatch11B8_080A(state); return null;
            case 0x14: Dispatch11B8_0925(state); return null;
            case 0x15: EquipSlot6(state); return null;
            case 0x16: CheckEquipSlot6(state); return null;
            case 0x17: EquipConsistency(state); return null;
            case 0x18: GarageService(state); return null;
            case 0x19: FlagD450(state); return null;
            case 0x1A: FlagD451(state); return null;
            case 0x1B: Goto2eShared(state); return null;
            case 0x1C: ClearAllSlots(state); return null;
            case 0x1D: CountUppercase(state); return null;
            case 0x1E: Dispatch11B8_104E(state); return null;
            case 0x1F: ReadSlotFlag(state); return null;
            case 0x20: ComplexEquip(state); return null;
            case 0x21: Dispatch0FDC_1C9B(state); return null;
            case 0x22: Dispatch0FDC_1A26(state); return null;
            case 0x23: NewGameInit(state); return null;
            case 0x24: ReadUnitSlot(state); return null;
            case 0x25: ClearUnitSlot(state); return null;
            case 0x26: ReadD456(state); return null;
            case 0x27: TriggerAction(state); return null;
            case 0x28: Dispatch11B8_152F(state); return null;
            case 0x29: CombatHeal(state); return null;
            case 0x2A: SavePositions(state); return null;
            case 0x2B: RestorePositions(state); return null;
            case 0x2C: Dispatch11B8_1762(state); return null;
            case 0x2D: return CombatEncounter();
            case 0x2E: RestoreSlots(state); return null;
            case 0x2F: DecrementState(state); return null;
            default: GD.Print($"    unknown case 0x{caseVal:X2}"); return null;
        }
    }

    // ── Case 0x01 ──────────────────────────────────────────────
    static GameMode? EnterBuilding(GameState state)
    {
        GD.Print("    ENTER_BUILDING: load BLD, init viewport");
        return null;
    }

    // ── Case 0x02 ──────────────────────────────────────────────
    static void ShowGreeting(GameState state) => GD.Print("    SHOW_GREETING");

    // ── Case 0x03 ──────────────────────────────────────────────
    static GameMode ExitBuilding()
    {
        GD.Print("    EXIT_BUILDING");
        return GameMode.WorldMap;
    }

    // ── Case 0x04: SHOW_SHOP_ITEMS ─────────────────────────────
    // Populate shop item slots (C618[0..2] = StateArray 0x18-0x1A)
    // with item types from the current shop strategy.
    // The BLD text handles display; this sets up state for buy/sell.
    static void ShowShopItems(GameState state, IShopInventory? shop)
    {
        GD.Print("    SHOW_SHOP_ITEMS");
        if (shop == null) return;
        for (int i = 0; i < 3 && i < shop.SlotCount; i++)
            state.StateArray[0x18 + i] = (byte)shop.GetItemType(i);
    }

    // ── Case 0x05: BUY_ITEM_SINGLE ─────────────────────────────
    // Buy single item at current selection index (bD314).
    // Item type from C618[bD314] (StateArray[0x18 + bD314]).
    // Price = item_type * 125 + 75.
    static void BuyItemSingle(GameState state, IShopInventory? shop)
    {
        GD.Print("    BUY_ITEM_SINGLE");
        int slot = state.StateArray[0x14]; // bD314
        int itemType = state.StateArray[0x18 + slot];
        if (itemType == 0) return;
        int price = itemType * 125 + 75;
        if (state.Credits >= price)
        {
            state.Credits -= price;
            state.StateArray[0x18 + slot]++; // rotate to next item type
            if (itemType < state.InventoryQuantities.Length)
                state.InventoryQuantities[itemType]++;
            GD.Print($"    bought single type {itemType} for {price}, credits={state.Credits}");
        }
    }

    // ── Case 0x06: SHOW_PLAYER_ITEMS ───────────────────────────
    // Display player's owned items (aD374[n] != 0) for sale.
    // In our system, this finds owned items and sets up state for SellItemBulk.
    static void ShowPlayerItems(GameState state)
    {
        GD.Print("    SHOW_PLAYER_ITEMS");
        int count = 0;
        for (int i = 0; i < state.InventoryQuantities.Length && count < 3; i++)
        {
            if (state.InventoryQuantities[i] > 0)
            {
                state.StateArray[0x18 + count] = (byte)i;
                count++;
            }
        }
        for (int i = count; i < 3; i++)
            state.StateArray[0x18 + i] = 0;
        state.StateArray[0x14] = 0; // reset selection
    }

    // ── Case 0x07: BUY_ITEM_BULK ───────────────────────────────
    // Bulk buy at 1 cr/unit using strategy pricing.
    static void BuyItemBulk(GameState state, IShopInventory? shop)
    {
        GD.Print("    BUY_ITEM_BULK");
        int slot = state.StateArray[0x14]; // bD314
        int item = shop != null ? shop.GetItemType(slot) : state.StateArray[0x18 + slot];
        if (item == 0) return;
        int price = shop?.GetBuyPrice(slot) ?? (item * 125 + 75);
        if (state.Credits >= price)
        {
            state.Credits -= price;
            if (item < state.InventoryQuantities.Length)
                state.InventoryQuantities[item]++;
            GD.Print($"    bought bulk type {item} for {price}, credits={state.Credits}, shop={shop?.ShopName}");
        }
    }

    // ── Case 0x08: SELL_ITEM_BULK ──────────────────────────────
    // Bulk sell at 1 cr/unit using strategy pricing.
    static void SellItemBulk(GameState state, IShopInventory? shop)
    {
        GD.Print("    SELL_ITEM_BULK");
        int slot = state.StateArray[0x14]; // bD314
        int item = shop != null ? shop.GetItemType(slot) : state.StateArray[0x18 + slot];
        if (item > 0 && item < state.InventoryQuantities.Length && state.InventoryQuantities[item] > 0)
        {
            state.InventoryQuantities[item]--;
            state.Credits += shop?.GetSellPrice(slot) ?? (item * 125 + 75) / 2;
        }
    }

    // ── Case 0x09: HOSPITAL_HEAL ───────────────────────────────
    // Heal player units for a cost. Reads healing cost from table.
    static void HospitalHeal(GameState state)
    {
        GD.Print("    HOSPITAL_HEAL (cost 50)");
        if (state.Credits >= 50)
        {
            state.Credits -= 50;
            for (int i = 0; i < 4; i++) state.UnitStatus[i] = 1;
        }
    }

    // ── Case 0x0A: SHOW_CREDITS ────────────────────────────────
    // Display credits formatted. In our system, credits are already
    // shown in the UI; this ensures the display is updated.
    static void ShowCredits(GameState state)
    {
        GD.Print($"    SHOW_CREDITS: {state.Credits}");
    }

    // ── Case 0x0B: BUY_WITH_UNIT_SEL ───────────────────────────
    // Purchase with unit selection. Shows price from table,
    // deducts credits, selects a unit for the purchase.
    static void BuyWithUnitSel(GameState state, IShopInventory? shop)
    {
        GD.Print("    BUY_WITH_UNIT_SEL");
        int slot = state.StateArray[0x14]; // bD314
        int item = shop != null ? shop.GetItemType(slot) : state.StateArray[0x18 + slot];
        if (item == 0) return;
        int price = shop?.GetBuyPrice(slot) ?? (item * 125 + 75);
        if (state.Credits >= price)
        {
            state.Credits -= price;
            if (item < state.InventoryQuantities.Length)
                state.InventoryQuantities[item]++;
            state.StateArray[0x1A] = 0; // bD31A = first unit slot
            GD.Print($"    bought + unit sel type {item} for {price}, credits={state.Credits}");
        }
    }

    // ── Case 0x0C: CLOSE_ACTION ────────────────────────────────
    // Close current shop/action sub-dialog.
    // Does NOT end the BLD script — the script itself will hit
    // StopInterpreter (0xFF) when it's done.
    static GameMode? CloseAction()
    {
        GD.Print("    CLOSE_ACTION");
        return null; // no mode change — BLD script continues
    }

    // ── Case 0x0D: EQUIPMENT_MENU ──────────────────────────────
    // Equipment selection from unit slots. Lists items at C61C[stride 0x11].
    // Stores selected unit index in bD31A.
    static void EquipmentMenu(GameState state)
    {
        GD.Print("    EQUIPMENT_MENU");
        state.StateArray[0x1A] = 0; // bD31A = default first slot
    }

    // ── Case 0x0E: COUNT_UNIT_SLOTS ────────────────────────────
    // Count occupied unit slots (8 slots bC614[], stride 0x11).
    // Result in bD31A.
    static void CountUnitSlots(GameState state)
    {
        GD.Print("    COUNT_UNIT_SLOTS");
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            if (state.UnitStatus[i] != 0)
                count++;
        }
        state.StateArray[0x1A] = (byte)count; // bD31A
    }

    // ── Case 0x0F: EQUIP_SLOT5 ─────────────────────────────────
    // Equip item type 5: 500cr debit, C618[5][bD31A]++, set bC623[].bit0.
    static void EquipSlot5(GameState state)
    {
        GD.Print("    EQUIP_SLOT5");
        if (state.Credits >= 500)
        {
            state.Credits -= 500;
            state.StateArray[0x1A] = 1; // bD31A = success
        }
        else
            state.StateArray[0x1A] = 0;
    }

    // ── Case 0x10: CHECK_EQUIP_SLOT5 ───────────────────────────
    // Query: bD31B = bC623[bD31A] & 0x01 (slot 5 flag).
    static void CheckEquipSlot5(GameState state)
    {
        GD.Print("    CHECK_EQUIP_SLOT5");
        state.StateArray[0x1B] = 0; // bD31B = 0 (not equipped)
    }

    // ── Case 0x11: COUNT_STORY_SLOTS ───────────────────────────
    // Count occupied story/mech slots (4 slots, stride 0x7D).
    // Result in bD31C.
    static void CountStorySlots(GameState state)
    {
        GD.Print("    COUNT_STORY_SLOTS");
        int count = 0;
        for (int i = 0; i < 4; i++)
        {
            if (state.StorySlots[i]?.StatusByte != 0xFF)
                count++;
        }
        state.StateArray[0x1C] = (byte)count; // bD31C
    }

    // ── Case 0x12: DISPATCH_11B8_0002 ──────────────────────────
    // Render via fn11B8_0002 (viewport/tile display).
    static void Dispatch11B8_0002(GameState state) => GD.Print("    DISPATCH_11B8_0002");

    // ── Case 0x13: DISPATCH_11B8_080A ──────────────────────────
    // Render building name/text overlay.
    static void Dispatch11B8_080A(GameState state) => GD.Print("    DISPATCH_11B8_080A");

    // ── Case 0x14: DISPATCH_11B8_0925 ──────────────────────────
    // Render text overlay.
    static void Dispatch11B8_0925(GameState state) => GD.Print("    DISPATCH_11B8_0925");

    // ── Case 0x15: EQUIP_SLOT6 ─────────────────────────────────
    // Equip item type 6: 500cr debit, C618[6][bD31A]++, set bC623[].bit1.
    static void EquipSlot6(GameState state)
    {
        GD.Print("    EQUIP_SLOT6");
        if (state.Credits >= 500)
        {
            state.Credits -= 500;
            state.StateArray[0x1A] = 1;
        }
        else
            state.StateArray[0x1A] = 0;
    }

    // ── Case 0x16: CHECK_EQUIP_SLOT6 ───────────────────────────
    // Query: bD31B = bC623[bD31A] & 0x02 (slot 6 flag).
    static void CheckEquipSlot6(GameState state)
    {
        GD.Print("    CHECK_EQUIP_SLOT6");
        state.StateArray[0x1B] = 0; // bD31B = 0 (not equipped)
    }

    // ── Case 0x17: EQUIP_CONSISTENCY ───────────────────────────
    // Verify equip state vs expected: compare aC615[n]*10 vs bC623[n].
    // Sets bD325=1 on mismatch.
    static void EquipConsistency(GameState state)
    {
        GD.Print("    EQUIP_CONSISTENCY");
        state.StateArray[0x25] = 0; // bD325 = 0 (consistent)
    }

    // ── Case 0x18: GARAGE_SERVICE ──────────────────────────────
    // Paid service dispatch. Reads cost from table indexed by bD326.
    static void GarageService(GameState state)
    {
        GD.Print("    GARAGE_SERVICE");
        if (state.Credits >= 100)
        {
            state.Credits -= 100;
            for (int i = 0; i < 4; i++) state.UnitStatus[i] = 1;
        }
    }

    // ── Case 0x19: FLAG_D450 (Training Complete) ────────────────
    static void FlagD450(GameState state)
    {
        GD.Print("    TRAINING COMPLETE!");
        state.TrainingComplete = true;
        state.StateArray[0x50] = 1;
    }

    // ── Case 0x1A: FLAG_D451 (Milestone) ───────────────────────
    static void FlagD451(GameState state)
    {
        GD.Print("    MILESTONE!");
        state.Milestone = true;
        state.StateArray[0x51] = 1;
    }

    // ── Case 0x1B: GOTO_2E_SHARED ──────────────────────────────
    // Shared path with case 0x2E (RESTORE_SLOTS).
    static void Goto2eShared(GameState state) => GD.Print("    GOTO_2E_SHARED");

    // ── Case 0x1C: CLEAR_ALL_SLOTS ─────────────────────────────
    // Clear 4 story/mech slots.
    static void ClearAllSlots(GameState state)
    {
        GD.Print("    CLEAR_ALL_SLOTS");
        for (int i = 0; i < 4; i++)
            if (state.StorySlots[i] != null)
                state.StorySlots[i].StatusByte = 0xFF;
    }

    // ── Case 0x1D: COUNT_UPPERCASE ─────────────────────────────
    // Count story slots with IDs in 'A'-'Z' range. Result in bD31C.
    static void CountUppercase(GameState state)
    {
        GD.Print("    COUNT_UPPERCASE");
        state.StateArray[0x1C] = 0; // bD31C
    }

    // ── Case 0x1E: DISPATCH_11B8_104E ─────────────────────────
    // Render via fn11B8_104E.
    static void Dispatch11B8_104E(GameState state) => GD.Print("    DISPATCH_11B8_104E");

    // ── Case 0x1F: READ_SLOT_FLAG ──────────────────────────────
    // Copy bC620[1][bD31A] → bD32B.
    static void ReadSlotFlag(GameState state)
    {
        GD.Print("    READ_SLOT_FLAG");
        state.StateArray[0x2B] = 0; // bD32B = 0
    }

    // ── Case 0x20: COMPLEX_EQUIP ───────────────────────────────
    // Multi-step equip interaction.
    static void ComplexEquip(GameState state)
    {
        GD.Print("    COMPLEX_EQUIP");
        if (state.Credits >= 500)
        {
            state.Credits -= 500;
            state.StateArray[0x1A] = 1; // bD31A = success
        }
        else
            state.StateArray[0x1A] = 0;
    }

    // ── Case 0x21: DISPATCH_0FDC_1C9B ─────────────────────────
    // Call fn0FDC_1C9B.
    static void Dispatch0FDC_1C9B(GameState state) => GD.Print("    DISPATCH_0FDC_1C9B");

    // ── Case 0x22: DISPATCH_0FDC_1A26 ─────────────────────────
    // Call fn0FDC_1A26.
    static void Dispatch0FDC_1A26(GameState state) => GD.Print("    DISPATCH_0FDC_1A26");

    // ── Case 0x23: NEW_GAME_INIT ───────────────────────────────
    // Full game init: clear state, set party, init viewport.
    static void NewGameInit(GameState state)
    {
        GD.Print("    NEW_GAME_INIT");
        state.Credits = 1500;
        state.TrainingComplete = false;
        state.Milestone = false;
        for (int i = 0; i < state.StateArray.Length; i++) state.StateArray[i] = 0;
        for (int i = 0; i < state.InventoryQuantities.Length; i++) state.InventoryQuantities[i] = 0;
    }

    // ── Case 0x24: READ_UNIT_SLOT ──────────────────────────────
    // Read bC614[bD331].b0000 → display via item name lookup.
    static void ReadUnitSlot(GameState state)
    {
        GD.Print("    READ_UNIT_SLOT");
    }

    // ── Case 0x25: CLEAR_UNIT_SLOT ─────────────────────────────
    // Clear unit slot (set first slot to empty).
    static void ClearUnitSlot(GameState state)
    {
        GD.Print("    CLEAR_UNIT_SLOT");
        if (state.StorySlots.Length > 0 && state.StorySlots[0] != null)
            state.StorySlots[0].StatusByte = 0xFF;
    }

    // ── Case 0x26: READ_D456 ───────────────────────────────────
    // Read bD456, look up item name, render.
    static void ReadD456(GameState state)
    {
        GD.Print("    READ_D456");
    }

    // ── Case 0x27: TRIGGER_ACTION ──────────────────────────────
    // Call fn1467_0002(0x01) — mode trigger.
    static void TriggerAction(GameState state)
    {
        GD.Print("    TRIGGER_ACTION");
    }

    // ── Case 0x28: DISPATCH_11B8_152F ─────────────────────────
    // Call fn11B8_152F, optionally set bD334=1.
    static void Dispatch11B8_152F(GameState state) => GD.Print("    DISPATCH_11B8_152F");

    // ── Case 0x29: COMBAT_HEAL ─────────────────────────────────
    // Apply RNG damage/healing to party.
    static void CombatHeal(GameState state)
    {
        GD.Print("    COMBAT_HEAL");
        for (int i = 0; i < 4; i++) state.UnitStatus[i] = 1;
    }

    // ── Case 0x2A: SAVE_POSITIONS ──────────────────────────────
    // Save unit positions + COMSTAR state.
    static void SavePositions(GameState state) => GD.Print("    SAVE_POSITIONS");

    // ── Case 0x2B: RESTORE_POSITIONS ───────────────────────────
    // Restore positions from saved arrays.
    static void RestorePositions(GameState state) => GD.Print("    RESTORE_POSITIONS");

    // ── Case 0x2C: DISPATCH_11B8_1762 ─────────────────────────
    // Position/state management via fn11B8_1762.
    static void Dispatch11B8_1762(GameState state) => GD.Print("    DISPATCH_11B8_1762");

    // ── Case 0x2D: COMBAT_ENCOUNTER ────────────────────────────
    static GameMode CombatEncounter()
    {
        GD.Print("    COMBAT_ENCOUNTER!");
        return GameMode.Combat;
    }

    // ── Case 0x2E: RESTORE_SLOTS ───────────────────────────────
    // Restore 4 story slots from temporary backup.
    static void RestoreSlots(GameState state)
    {
        GD.Print("    RESTORE_SLOTS");
        state.StateArray[0x5E] = 0; // bD55E
    }

    // ── Case 0x2F: DECREMENT_STATE ─────────────────────────────
    // If state array entry > 5, decrement by 4.
    static void DecrementState(GameState state)
    {
        GD.Print("    DECREMENT_STATE");
        if (state.StateArray[0x23] > 5) // bC623 check
            state.StateArray[0x23] -= 4;
    }
}
