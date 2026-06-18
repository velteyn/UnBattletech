using Godot;
using BattleTechCHI.Data;
using BattleTechCHI.Core;

namespace BattleTechCHI.BLD;

public static partial class Fn1CD3Dispatcher
{
    // Events for GameLoop to subscribe to
    public static event Action<string>? BuildingEntered;
    public static event Action<int>? CreditsDisplayed;
    public static event Action<string>? RenderingRequested;
    public static event Action? ActionTriggered;
    public static event Action? SaveRequested;
    public static event Action? RestoreRequested;
    public static event Action? StatsScreenRequested;

    public static GameMode? Dispatch(byte caseVal, GameState state, string bldName, IShopInventory? shop = null)
    {
        GD.Print($"  fn1CD3 case 0x{caseVal:X2} (shop={shop?.ShopName ?? "none"}, bld={bldName})");
        switch (caseVal)
        {
            case 0x01: return EnterBuilding(state, bldName);
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
    static GameMode? EnterBuilding(GameState state, string bldName)
    {
        GD.Print($"    ENTER_BUILDING: {bldName}");
        BuildingEntered?.Invoke(bldName);
        return null;
    }

    // ── Case 0x02 ──────────────────────────────────────────────
    static void ShowGreeting(GameState state)
    {
        GD.Print("    SHOW_GREETING (handled by BLD text)");
    }

    // ── Case 0x03 ──────────────────────────────────────────────
    static GameMode ExitBuilding()
    {
        GD.Print("    EXIT_BUILDING");
        return GameMode.WorldMap;
    }

    // ── Case 0x04: SHOW_SHOP_ITEMS ─────────────────────────────
    static void ShowShopItems(GameState state, IShopInventory? shop)
    {
        GD.Print("    SHOW_SHOP_ITEMS");
        if (shop == null) return;
        for (int i = 0; i < 3 && i < shop.SlotCount; i++)
            state.StateArray[0x18 + i] = (byte)shop.GetItemType(i);
    }

    // ── Case 0x05: BUY_ITEM_SINGLE ─────────────────────────────
    static void BuyItemSingle(GameState state, IShopInventory? shop)
    {
        GD.Print("    BUY_ITEM_SINGLE");
        int slot = state.StateArray[0x14];
        int itemType = state.StateArray[0x18 + slot];
        if (itemType == 0) return;
        int price = itemType * 125 + 75;
        if (state.Credits >= price)
        {
            state.Credits -= price;
            state.StateArray[0x18 + slot]++;
            if (itemType < state.InventoryQuantities.Length)
                state.InventoryQuantities[itemType]++;
            GD.Print($"    bought single type {itemType} for {price}, credits={state.Credits}");
        }
    }

    // ── Case 0x06: SHOW_PLAYER_ITEMS ───────────────────────────
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
        state.StateArray[0x14] = 0;
    }

    // ── Case 0x07: BUY_ITEM_BULK ───────────────────────────────
    static void BuyItemBulk(GameState state, IShopInventory? shop)
    {
        GD.Print("    BUY_ITEM_BULK");
        int slot = state.StateArray[0x14];
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
    static void SellItemBulk(GameState state, IShopInventory? shop)
    {
        GD.Print("    SELL_ITEM_BULK");
        int slot = state.StateArray[0x14];
        int item = shop != null ? shop.GetItemType(slot) : state.StateArray[0x18 + slot];
        if (item > 0 && item < state.InventoryQuantities.Length && state.InventoryQuantities[item] > 0)
        {
            state.InventoryQuantities[item]--;
            state.Credits += shop?.GetSellPrice(slot) ?? (item * 125 + 75) / 2;
        }
    }

    // ── Case 0x09: HOSPITAL_HEAL ───────────────────────────────
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
    static void ShowCredits(GameState state)
    {
        GD.Print($"    SHOW_CREDITS: {state.Credits}");
        CreditsDisplayed?.Invoke(state.Credits);
    }

    // ── Case 0x0B: BUY_WITH_UNIT_SEL ───────────────────────────
    static void BuyWithUnitSel(GameState state, IShopInventory? shop)
    {
        GD.Print("    BUY_WITH_UNIT_SEL");
        int slot = state.StateArray[0x14];
        int item = shop != null ? shop.GetItemType(slot) : state.StateArray[0x18 + slot];
        if (item == 0) return;
        int price = shop?.GetBuyPrice(slot) ?? (item * 125 + 75);
        if (state.Credits >= price)
        {
            state.Credits -= price;
            if (item < state.InventoryQuantities.Length)
                state.InventoryQuantities[item]++;
            state.StateArray[0x1A] = 0;
            GD.Print($"    bought + unit sel type {item} for {price}, credits={state.Credits}");
        }
    }

    // ── Case 0x0C: CLOSE_ACTION ────────────────────────────────
    static GameMode? CloseAction()
    {
        GD.Print("    CLOSE_ACTION");
        return null;
    }

    // ── Case 0x0D: EQUIPMENT_MENU ──────────────────────────────
    static void EquipmentMenu(GameState state)
    {
        GD.Print("    EQUIPMENT_MENU");
        state.StateArray[0x1A] = 0;
        StatsScreenRequested?.Invoke();
    }

    // ── Case 0x0E: COUNT_UNIT_SLOTS ────────────────────────────
    static void CountUnitSlots(GameState state)
    {
        GD.Print("    COUNT_UNIT_SLOTS");
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            if (state.UnitStatus[i] != 0)
                count++;
        }
        state.StateArray[0x1A] = (byte)count;
    }

    // ── Case 0x0F: EQUIP_SLOT5 ─────────────────────────────────
    static void EquipSlot5(GameState state)
    {
        GD.Print("    EQUIP_SLOT5");
        if (state.Credits >= 500)
        {
            state.Credits -= 500;
            state.StateArray[0x1A] = 1;
        }
        else
            state.StateArray[0x1A] = 0;
    }

    // ── Case 0x10: CHECK_EQUIP_SLOT5 ───────────────────────────
    // bD31B = bC623[bD31A] & 0x01
    static void CheckEquipSlot5(GameState state)
    {
        GD.Print("    CHECK_EQUIP_SLOT5");
        int slotIdx = state.StateArray[0x1A];
        if (slotIdx >= 0 && slotIdx < state.UnitSlots.Length)
            state.StateArray[0x1B] = (byte)(state.UnitSlots[slotIdx].DerivedAttr & 0x01);
        else
            state.StateArray[0x1B] = 0;
    }

    // ── Case 0x11: COUNT_STORY_SLOTS ───────────────────────────
    static void CountStorySlots(GameState state)
    {
        GD.Print("    COUNT_STORY_SLOTS");
        int count = 0;
        for (int i = 0; i < state.StorySlots.Length; i++)
        {
            if (state.StorySlots[i]?.StatusByte != 0xFF)
                count++;
        }
        state.StateArray[0x1C] = (byte)count;
    }

    // ── Case 0x12-0x14, 0x1E, 0x28, 0x2C: DISPATCH_11B8_* ────
    static void Dispatch11B8_0002(GameState state)
    {
        GD.Print("    DISPATCH_11B8_0002 (viewport/tile display)");
        RenderingRequested?.Invoke("11B8_0002");
    }

    static void Dispatch11B8_080A(GameState state)
    {
        GD.Print("    DISPATCH_11B8_080A (building name overlay)");
        RenderingRequested?.Invoke("11B8_080A");
    }

    static void Dispatch11B8_0925(GameState state)
    {
        GD.Print("    DISPATCH_11B8_0925 (text overlay)");
        RenderingRequested?.Invoke("11B8_0925");
    }

    static void Dispatch11B8_104E(GameState state)
    {
        GD.Print("    DISPATCH_11B8_104E (building interior)");
        RenderingRequested?.Invoke("11B8_104E");
    }

    static void Dispatch11B8_152F(GameState state)
    {
        GD.Print("    DISPATCH_11B8_152F (sprite composition)");
        state.StateArray[0x34] = 1;
        RenderingRequested?.Invoke("11B8_152F");
    }

    static void Dispatch11B8_1762(GameState state)
    {
        GD.Print("    DISPATCH_11B8_1762 (position/state)");
        RenderingRequested?.Invoke("11B8_1762");
    }

    // ── Case 0x15: EQUIP_SLOT6 ─────────────────────────────────
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
    // bD31B = bC623[bD31A] & 0x02
    static void CheckEquipSlot6(GameState state)
    {
        GD.Print("    CHECK_EQUIP_SLOT6");
        int slotIdx = state.StateArray[0x1A];
        if (slotIdx >= 0 && slotIdx < state.UnitSlots.Length)
            state.StateArray[0x1B] = (byte)((state.UnitSlots[slotIdx].DerivedAttr >> 1) & 0x01);
        else
            state.StateArray[0x1B] = 0;
    }

    // ── Case 0x17: EQUIP_CONSISTENCY ───────────────────────────
    // Verify: aC615[n]*10 == bC623[n] for all occupied slots
    static void EquipConsistency(GameState state)
    {
        GD.Print("    EQUIP_CONSISTENCY");
        state.StateArray[0x25] = 0;
        for (int i = 0; i < state.UnitSlots.Length; i++)
        {
            if (state.UnitSlots[i].TypeId != 0xFF &&
                state.UnitSlots[i].Attr1 * 10 != state.UnitSlots[i].DerivedAttr)
            {
                state.StateArray[0x25] = 1;
                break;
            }
        }
    }

    // ── Case 0x18: GARAGE_SERVICE ──────────────────────────────
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
    // Shared path with 0x2E RestoreSlots
    static void Goto2eShared(GameState state)
    {
        GD.Print("    GOTO_2E_SHARED (= RestoreSlots)");
        state.StateArray[0x5E] = 0;
    }

    // ── Case 0x1C: CLEAR_ALL_SLOTS ─────────────────────────────
    static void ClearAllSlots(GameState state)
    {
        GD.Print("    CLEAR_ALL_SLOTS");
        for (int i = 0; i < state.StorySlots.Length; i++)
            if (state.StorySlots[i] != null)
                state.StorySlots[i].StatusByte = 0xFF;
    }

    // ── Case 0x1D: COUNT_UPPERCASE ─────────────────────────────
    // Count story slots with valid named (uppercase) IDs
    static void CountUppercase(GameState state)
    {
        GD.Print("    COUNT_UPPERCASE");
        int count = 0;
        for (int i = 0; i < state.StorySlots.Length; i++)
        {
            if (state.StorySlots[i]?.StatusByte != 0xFF && state.StorySlots[i]?.StatusByte < 0x80)
                count++;
        }
        state.StateArray[0x1C] = (byte)count;
    }

    // ── Case 0x1F: READ_SLOT_FLAG ──────────────────────────────
    // bD32B = bC620[bD31A] (LinkedStorySlot for given unit)
    static void ReadSlotFlag(GameState state)
    {
        GD.Print("    READ_SLOT_FLAG");
        int slotIdx = state.StateArray[0x1A];
        if (slotIdx >= 0 && slotIdx < state.UnitSlots.Length)
            state.StateArray[0x2B] = state.UnitSlots[slotIdx].LinkedStorySlot;
        else
            state.StateArray[0x2B] = 0;
    }

    // ── Case 0x20: COMPLEX_EQUIP ───────────────────────────────
    static void ComplexEquip(GameState state)
    {
        GD.Print("    COMPLEX_EQUIP");
        if (state.Credits >= 500)
        {
            state.Credits -= 500;
            state.StateArray[0x1A] = 1;
        }
        else
            state.StateArray[0x1A] = 0;
    }

    // ── Case 0x21: DISPATCH_0FDC_1C9B ─────────────────────────
    // fn0FDC_1C9B — ENTER ROOM INTERACTION (push state)
    // Original: backup story slot 0 (0xC724, 0x7D bytes) → [0x54AA]+0x3780,
    // load room data from [0x54B0]+0x2F0 into slot 0, clear unit slots 1-7,
    // set wE48E=1.
    static void Dispatch0FDC_1C9B(GameState state)
    {
        GD.Print("    DISPATCH_0FDC_1C9B (enter room)");
        // Back up current story slot 0 (125 bytes → RoomStateBackup)
        if (state.StorySlots.Length > 0 && state.StorySlots[0] != null)
        {
            var slot = state.StorySlots[0];
            int idx = 0;
            state.RoomStateBackup[idx++] = slot.StatusByte;
            state.RoomStateBackup[idx++] = slot.FlagsLow;
            state.RoomStateBackup[idx++] = slot.FlagsHigh;
            state.RoomStateBackup[idx++] = slot.TimingNibble;
            state.RoomStateBackup[idx++] = slot.CounterA;
            state.RoomStateBackup[idx++] = slot.CounterB;
            state.RoomStateBackup[idx++] = slot.StoryState;
            state.RoomStateBackup[idx++] = slot.LatchMarker;
            state.RoomStateBackup[idx++] = slot.LinkedUnitSlot;
            // Remaining bytes are zeroed (the room interaction data
            // will be set by BLD text opcodes during the room).
            for (int i = idx; i < state.RoomStateBackup.Length; i++)
                state.RoomStateBackup[i] = 0;
        }
        // Clear NPC unit slots 1-7 (units leave during room interaction)
        for (int i = 1; i < state.UnitSlots.Length; i++)
            state.UnitSlots[i].TypeId = 0xFF;
        state.RoomActive = true;
        RenderingRequested?.Invoke("0FDC_1C9B");
    }

    // ── Case 0x22: DISPATCH_0FDC_1A26 ─────────────────────────
    // fn0FDC_1A26 — EXIT ROOM INTERACTION (pop state + render text)
    // Original: backup 4 slots' C79D/C79E, call fn1E56_0388 +
    // fn1E56_03F5(0x17A5) to render room text, call fn1467_0B98
    // to re-init state, restore slot 0 data from linked slot,
    // clear unit slots 1-7, set wE48E=0.
    static void Dispatch0FDC_1A26(GameState state)
    {
        GD.Print("    DISPATCH_0FDC_1A26 (exit room / render text)");
        // Restore story slot 0 from backup
        if (state.StorySlots.Length > 0 && state.StorySlots[0] != null
            && state.RoomStateBackup.Length >= 9)
        {
            var slot = state.StorySlots[0];
            var b = state.RoomStateBackup;
            slot.StatusByte = b[0];
            slot.FlagsLow = b[1];
            slot.FlagsHigh = b[2];
            slot.TimingNibble = b[3];
            slot.CounterA = b[4];
            slot.CounterB = b[5];
            slot.StoryState = b[6];
            slot.LatchMarker = b[7];
            slot.LinkedUnitSlot = b[8];
        }
        // Clear NPC unit slots 1-7
        for (int i = 1; i < state.UnitSlots.Length; i++)
            state.UnitSlots[i].TypeId = 0xFF;
        state.RoomActive = false;
        // Signal the GameLoop to render BLD room text and wait for input.
        // The GameLoop's RenderingRequested handler should call
        // BldInterpreter to process the room's text opcodes.
        RenderingRequested?.Invoke("0FDC_1A26");
    }

    // ── Case 0x23: NEW_GAME_INIT ───────────────────────────────
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
    // Read bC614[bD331].b0000 (TypeId) and prepare name display
    static void ReadUnitSlot(GameState state)
    {
        int slotIdx = state.StateArray[0x31];
        if (slotIdx >= 0 && slotIdx < state.UnitSlots.Length && state.UnitSlots[slotIdx].TypeId != 0xFF)
            GD.Print($"    READ_UNIT_SLOT: slot {slotIdx} type {state.UnitSlots[slotIdx].TypeId}");
        else
            GD.Print($"    READ_UNIT_SLOT: slot {slotIdx} empty");
    }

    // ── Case 0x25: CLEAR_UNIT_SLOT ─────────────────────────────
    static void ClearUnitSlot(GameState state)
    {
        GD.Print("    CLEAR_UNIT_SLOT");
        if (state.StorySlots.Length > 0 && state.StorySlots[0] != null)
            state.StorySlots[0].StatusByte = 0xFF;
    }

    // ── Case 0x26: READ_D456 ───────────────────────────────────
    // Read UnitIdCounter value
    static void ReadD456(GameState state)
    {
        GD.Print($"    READ_D456: UnitIdCounter={state.UnitIdCounter}");
    }

    // ── Case 0x27: TRIGGER_ACTION ──────────────────────────────
    // Call fn1467_0002(0x01) — mode trigger
    static void TriggerAction(GameState state)
    {
        GD.Print("    TRIGGER_ACTION (mode trigger 0x01)");
        ActionTriggered?.Invoke();
    }

    // ── Case 0x28: DISPATCH_11B8_152F ─────────────────────────
    // (moved above with other 11B8 dispatch methods)

    // ── Case 0x29: COMBAT_HEAL ─────────────────────────────────
    static void CombatHeal(GameState state)
    {
        GD.Print("    COMBAT_HEAL");
        for (int i = 0; i < 4; i++) state.UnitStatus[i] = 1;
    }

    // ── Case 0x2A: SAVE_POSITIONS ──────────────────────────────
    // Save unit positions + COMSTAR state to backup arrays
    static void SavePositions(GameState state)
    {
        GD.Print("    SAVE_POSITIONS");
        SaveRequested?.Invoke();
    }

    // ── Case 0x2B: RESTORE_POSITIONS ───────────────────────────
    // Restore positions from backup arrays
    static void RestorePositions(GameState state)
    {
        GD.Print("    RESTORE_POSITIONS");
        RestoreRequested?.Invoke();
    }

    // ── Case 0x2C: DISPATCH_11B8_1762 ─────────────────────────
    // (moved above with other 11B8 dispatch methods)

    // ── Case 0x2D: COMBAT_ENCOUNTER ────────────────────────────
    static GameMode CombatEncounter()
    {
        GD.Print("    COMBAT_ENCOUNTER!");
        return GameMode.Combat;
    }

    // ── Case 0x2E: RESTORE_SLOTS ───────────────────────────────
    static void RestoreSlots(GameState state)
    {
        GD.Print("    RESTORE_SLOTS");
        state.StateArray[0x5E] = 0;
    }

    // ── Case 0x2F: DECREMENT_STATE ─────────────────────────────
    static void DecrementState(GameState state)
    {
        GD.Print("    DECREMENT_STATE");
        if (state.StateArray[0x23] > 5)
            state.StateArray[0x23] -= 4;
    }
}
