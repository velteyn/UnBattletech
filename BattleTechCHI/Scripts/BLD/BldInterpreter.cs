using Godot;
using BattleTechCHI.Data;
using BattleTechCHI.Core;

namespace BattleTechCHI.BLD;

public partial class BldInterpreter : Node
{
    private GameState _state = null!;
    private StateManager _stateManager = null!;
    private BldScript? _script;

    private int _ip;
    private string _currentText = "";
    private string _lastRenderedText = "";
    private NarrativeMode _currentNarrativeMode = NarrativeMode.ThirdPerson;

    private bool _waitingForInput;
    private bool _waitingForMenu;
    private int _pendingMenuIp;
    private bool _running;

    [Signal]
    public delegate void TextRenderedEventHandler(string text, NarrativeMode mode);

    [Signal]
    public delegate void CreditsChangedEventHandler(int newAmount);

    [Signal]
    public delegate void InterpreterCompleteEventHandler();

    [Signal]
    public delegate void SpriteRequestedEventHandler(int spriteId);

    [Signal]
    public delegate void WorldMapReinitRequestedEventHandler();

    public bool IsRunning => _running;
    public bool WaitingForInput => _waitingForInput;
    public bool WaitingForMenu => _waitingForMenu;

    public void LoadAndRun(BldScript script)
    {
        _script = script;
        _ip = 0;
        _currentText = "";
        _currentNarrativeMode = NarrativeMode.ThirdPerson;
        _waitingForInput = false;
        _running = true;

        var gl = GetNode<GameLoop>("/root/GameLoop");
        _state = gl.State;
        _stateManager = gl.StateManager;

        GD.Print($"BLD: running {script.Name} ({script.RawBytes.Length} bytes)");
        ProcessNext();
    }

    /// <summary>
    /// Process a batch of opcodes until we hit one that needs input,
    /// or until the script ends.
    /// </summary>
    public void ProcessNext()
    {
        if (!_running || _script == null) return;
        if (_waitingForInput || _waitingForMenu) return;

        var buf = _script.RawBytes;
        int base_ = _script.InterpreterBase;

        while (_ip < buf.Length - base_)
        {
            int filePos = base_ + _ip;
            if (filePos >= buf.Length) break;

            byte b = buf[filePos];

            // 0x00-0x7F = cipher text
            if (b < 0x80) { HandleTextByte(b); _ip++; continue; }

            // Narrative markers (specific byte values; 0x80-0x96 are uppercase cipher text)
            switch (b)
            {
                case 0x9E: _currentNarrativeMode = NarrativeMode.ThirdPerson; _ip++; continue;
                case 0x9C: _currentNarrativeMode = NarrativeMode.CharacterSpeech; _ip++; continue;
                case 0x9B: _currentNarrativeMode = NarrativeMode.PlayerThought; _ip++; continue;
                case 0x9F: _currentNarrativeMode = NarrativeMode.PlayerAction; _ip++; continue;
                case 0xA5: _currentNarrativeMode = NarrativeMode.Continuation; _ip++; continue;
                case 0xA0: HandleTextByte(b); _ip++; continue; // space
                case 0x9D: _ip++; continue; // unknown marker, skip
            }

            // 0xC0 structural separator; 0xBA rparen; 0xBB separator
            if (b == 0xC0 || b == 0xBA || b == 0xBB) { _ip++; continue; }

            // 0x80-0xE3: cipher text (uppercase 0x81-0x87, 0x90-0x96, 0xA0)
            // or structural markers (no-ops). Only decode known cipher bytes.
            if (b < 0xE4)
            {
                if (CipherDecoder.IsMapped(b)) { HandleTextByte(b); }
                _ip++; continue;
            }

            // Opcode range 0xE4-0xFF
            _ip++;
            bool shouldYield = ExecuteOpcode((BldOpcode)b);
            if (shouldYield) return; // yielded for input or mode change
            continue;
        }

        // End of script
        if (_running)
            Finish();
    }

    /// <summary>
    /// Resume interpreter after input (called from GameLoop when InputReady fires).
    /// </summary>
    public void ResumeAfterInput()
    {
        if (_waitingForMenu) return; // handled by ResumeAfterMenuSelection
        _waitingForInput = false;
        ProcessNext();
    }

    public void ResumeAfterMenuSelection(int selectedIndex)
    {
        if (!_waitingForMenu || _script == null) return;
        _waitingForMenu = false;

        var buf = _script.RawBytes;
        int base_ = _script.InterpreterBase;

        // Clamp to prevent out-of-bounds jump table read
        // Scan ahead to find max entries before next opcode (0xE4-0xFF)
        int maxEntries = 0;
        for (int i = 0; ; i++)
        {
            int filePos = base_ + _pendingMenuIp + i * 2;
            if (filePos + 1 >= buf.Length) break;
            if (buf[filePos] >= 0xE4) break; // hit next opcode
            maxEntries++;
        }
        if (maxEntries == 0) maxEntries = 9; // fallback default
        if (selectedIndex >= maxEntries)
            selectedIndex = maxEntries - 1;

        int entryPos = base_ + _pendingMenuIp + selectedIndex * 2;
        if (entryPos + 1 < buf.Length)
        {
            _ip = buf[entryPos] | (buf[entryPos + 1] << 8);
        }
        ProcessNext();
    }

    private void HandleTextByte(byte b) => _currentText += CipherDecoder.DecodeByte(b);

    /// <summary>
    /// Execute one opcode. Returns true if the interpreter should yield (wait for input / mode changed).
    /// </summary>
    private bool ExecuteOpcode(BldOpcode opcode)
    {
        if (_script == null) return false;
        var buf = _script.RawBytes;
        int base_ = _script.InterpreterBase;

        bool ReadByte(out byte v)
        {
            v = 0;
            int p = base_ + _ip;
            if (p >= buf.Length) return false;
            v = buf[p]; _ip++; return true;
        }

        bool ReadWord(out short v)
        {
            v = 0;
            int p = base_ + _ip;
            if (p + 1 >= buf.Length) return false;
            v = (short)(buf[p] | (buf[p + 1] << 8)); _ip += 2; return true;
        }

        switch (opcode)
        {
            case BldOpcode.WriteChar:
                if (ReadByte(out byte ch)) _currentText += CipherDecoder.DecodeByte(ch);
                break;

            case BldOpcode.AddCredits:
                if (ReadWord(out short add))
                {
                    _state.Credits = Mathf.Max(0, _state.Credits + add);
                    EmitSignal(SignalName.CreditsChanged, _state.Credits);
                }
                break;

            case BldOpcode.SetCursorXY:
                if (ReadWord(out short tx) && ReadWord(out short ty))
                { _state.TextCursorX = tx; _state.TextCursorY = ty; }
                break;

            case BldOpcode.CmpCursorX:
                if (ReadWord(out short cmp) && ReadWord(out short jump))
                    if (_state.CursorX == cmp) _ip = jump;
                break;

            case BldOpcode.RngCheck:
                if (ReadByte(out byte mask) && ReadWord(out short rjump))
                    if ((GD.Randi() & mask) != 0) _ip = rjump;
                break;

            case BldOpcode.CallRoomHandler:
                if (ReadByte(out byte handler)) CallRoomHandler(handler);
                break;

            case BldOpcode.CondStateAction:
                if (ReadByte(out byte cond) && ReadByte(out byte act))
                {
                    // Original: if (w3938 == 0) fn0800_48B7(cond)
                    // action byte is consumed from stream but NOT passed to fn0800_48B7
                    if (_state.KeyWaitState == 0)
                    {
                        GD.Print($"  cond_state_action(cond={cond}) — reinit world map");
                        EmitSignal(SignalName.WorldMapReinitRequested);
                    }
                    else
                    {
                        GD.Print($"  cond_state_action(cond={cond}) — SKIP (w3938 != 0)");
                    }
                }
                break;

            case BldOpcode.CheckFlagEB:
                if (ReadWord(out short ebJump))
                    if (_state.Milestone) _ip = ebJump;
                break;

            case BldOpcode.CheckFlagEC:
                if (ReadWord(out short ecJump))
                    if (_state.TrainingComplete) _ip = ecJump;
                break;

            case BldOpcode.UnitCheckLoop:
                ReadWord(out _);
                break;

            case BldOpcode.SpendCredits:
                if (ReadWord(out short spend))
                {
                    _state.Credits = Mathf.Max(0, _state.Credits - spend);
                    EmitSignal(SignalName.CreditsChanged, _state.Credits);
                }
                break;

            case BldOpcode.CheckCredits:
                if (ReadWord(out short need) && _state.Credits < need)
                    GD.Print($"  check_credits: need {need}, have {_state.Credits} — FAIL");
                break;

            case BldOpcode.SetTextMargins:
                if (ReadByte(out byte ml) && ReadByte(out byte mr))
                { _state.TextMarginLeft = ml; _state.TextMarginRight = mr; }
                break;

            case BldOpcode.AddToState:
                if (ReadByte(out byte si) && ReadByte(out byte sv))
                    _state.StateArray[si] += sv;
                break;

            case BldOpcode.RoomDescription:
                FlushText(); break;

            case BldOpcode.ShopInteraction:
                if (ReadByte(out byte sidx))
                {
                    // Computed jump: state_val * 2 → word offset from current IP
                    int stateVal = (sbyte)_state.StateArray[sidx];
                    int targetPos = base_ + _ip + stateVal * 2;
                    if (targetPos + 1 < buf.Length)
                    {
                        _ip = buf[targetPos] | (buf[targetPos + 1] << 8);
                    }
                    else
                    {
                        GD.Print($"  shop_interaction: state[{sidx}]={stateVal} → OOB at {targetPos}");
                    }
                }
                break;

            case BldOpcode.SetStateValue:
                if (ReadByte(out byte ssi) && ReadByte(out byte ssv))
                    _state.StateArray[ssi] = ssv;
                break;

            case BldOpcode.ShopDispatch:
                if (ReadByte(out byte caseVal))
                {
                    FlushText();
                    var newMode = DispatchCase(caseVal);
                    if (newMode.HasValue)
                    {
                        _stateManager.SetMode(newMode.Value);
                        Finish();
                        return true;
                    }
                }
                break;

            case BldOpcode.CheckCondition:
                if (ReadByte(out byte condIdx))
                {
                    // Check if StateArray[condIdx] != 0; if true jump to WORD target
                    if (_state.StateArray[condIdx] != 0)
                    {
                        if (ReadWord(out short cjump))
                            _ip = cjump;
                    }
                    else
                    {
                        ReadWord(out _); // skip target word
                    }
                }
                break;

            case BldOpcode.StateCondCheck:
                if (ReadByte(out byte sci) && _state.StateArray[sci] == 0) ReadWord(out _);
                break;

            case BldOpcode.JumpForward:
                if (ReadWord(out short fwd)) _ip = fwd;
                break;

            case BldOpcode.JumpIndexed:
                if (ReadByte(out byte menuId))
                {
                    // HandleMenuSelection flushes text and shows menu asynchronously.
                    // After user picks, ResumeAfterMenuSelection applies the jump.
                    HandleMenuSelection(menuId);
                    return true; // yield for menu input
                }
                break;

            case BldOpcode.DrawSprite:
                if (ReadByte(out byte sid))
                {
                    GD.Print($"  draw_sprite({sid})");
                    EmitSignal(SignalName.SpriteRequested, sid);
                }
                break;

            case BldOpcode.AdvanceInput:
                FlushText();
                _waitingForInput = true;
                return true; // yield: wait for keypress

            case BldOpcode.RenderText:
                FlushText();
                _waitingForInput = true;
                return true; // yield: wait for keypress

            case BldOpcode.SetFont2: break;
            case BldOpcode.SetFont: ReadByte(out _); break;

            case BldOpcode.StopInterpreter:
                FlushText();
                Finish();
                return true;

            default:
                GD.Print($"  unknown opcode {opcode} (0x{(byte)opcode:X2}) at IP={_ip}");
                break;
        }
        return false;
    }

    private void Finish()
    {
        _running = false;
        _waitingForInput = false;
        _waitingForMenu = false;
        EmitSignal(SignalName.InterpreterComplete);
    }

    private GameMode? DispatchCase(byte rawCase)
    {
        // Operand is passed DIRECTLY — no transformation.
        // Verified from Reko: l0FDC_02D3 pushes the raw byte and calls fn1CD3_0004.
        GD.Print($"  shop_dispatch case=0x{rawCase:X2}");
        var shop = _script != null ? ShopRegistry.Get(_script.Name) : null;
        return Fn1CD3Dispatcher.Dispatch(rawCase, _state, _script?.Name ?? "", shop);
    }

    private void HandleMenuSelection(byte menuId)
    {
        // Use the last rendered text as menu content (menu text was already flushed
        // by a prior RenderText/RoomDescription opcode; _currentText is empty).
        // If _lastRenderedText is also empty, fall back to _currentText.
        string menuText = !string.IsNullOrEmpty(_lastRenderedText)
            ? _lastRenderedText
            : _currentText;
        _currentText = "";
        _pendingMenuIp = _ip; // _ip is at start of jump table (after menuId byte)
        _waitingForMenu = true;

        GD.Print($"  menu_select(id={menuId}) — showing menu, waiting for input");

        // Show menu text via GameLoop → DialogueBox
        var gl = GetNode<GameLoop>("/root/GameLoop");
        gl.ShowMenuForBld(menuText);
    }

    private void CallRoomHandler(byte raw)
    {
        sbyte handlerIdx = (sbyte)raw; // sign-extend as original CBW does

        // 1. Find first empty slot (TypeId == 0xFF) in slots 0-7
        int slot = -1;
        for (int i = 0; i < 8; i++)
        {
            if (_state.UnitSlots[i].TypeId == 0xFF)
            {
                slot = i;
                break;
            }
        }
        if (slot == -1)
        {
            GD.Print($"  call_room_handler({handlerIdx}) — no empty slot");
            return;
        }

        // 2. Assign unit ID from counter, increment, wrap to 2 at 10
        byte unitId = _state.UnitIdCounter;
        _state.UnitIdCounter++;
        if (_state.UnitIdCounter >= 10)
            _state.UnitIdCounter = 2;

        var unit = _state.UnitSlots[slot];
        unit.TypeId = unitId;
        unit.HandlerTag = handlerIdx;

        // 3. Clear fields C624, C622, C621, C61F
        unit.FieldC624 = 0;
        unit.FieldC622 = 0;
        unit.FieldC621 = 0;
        unit.FieldC61F = 0;

        // 4. Generate 3 random attributes via 2D6 (fn0800_19DD three times)
        unit.Attr1 = (byte)Roll2D6();
        unit.Attr2 = (byte)Roll2D6();
        unit.Attr3 = (byte)Roll2D6();

        // 5. Derived attribute C623 = Attr1 * 10
        unit.DerivedAttr = (byte)(unit.Attr1 * 10);

        // 6. C620 = 0x08 (unassigned story slot marker)
        unit.LinkedStorySlot = 0x08;

        // 7. Random fill C618[0..6] with RNG & 1
        for (int i = 0; i < 7; i++)
            unit.Inventory[i] = (byte)(GD.Randi() & 1);

        // 8. C61C = 0
        unit.FieldC61C = 0;

        // 9. C618[slot*17 + handlerIdx] = 3
        // In original: writes value 3 at offset C618 + slot*17 + handlerIdx
        // Since C618 = C614 + 4 and slot stride = 17, effective offset within slot = 4 + handlerIdx
        // Map to our data model: if offset 4..10 (inventory range), write to inventory[i]
        int slotOffset = 4 + handlerIdx;
        if (slotOffset >= 4 && slotOffset <= 10)
        {
            unit.Inventory[slotOffset - 4] = 3;
        }

        // 10. If handlerIdx == 4: C623 -= Attr1 * 2 (halve derived attr)
        if (handlerIdx == 4)
            unit.DerivedAttr -= (byte)(unit.Attr1 * 2);

        // 11. Link to first occupied story slot with no unit assignment
        for (int story = 0; story < 4; story++)
        {
            var storySlot = _state.StorySlots[story];
            if (storySlot != null && storySlot.StatusByte != 0xFF && storySlot.LinkedUnitSlot == 0xFF)
            {
                storySlot.LinkedUnitSlot = (byte)slot;
                unit.LinkedStorySlot = (byte)story;
                break;
            }
        }

        // 12. Display unit name (original calls fn1E56_03F5 with name template)
        string unitName = GetUnitName(unit);
        string linked = unit.LinkedStorySlot != 0x08 ? " (assigned)" : " (unlinked)";
        GD.Print($"  call_room_handler: created unit {unitId} in slot {slot} handler={handlerIdx}{linked}");
        EmitSignal(SignalName.TextRendered, unitName, (int)NarrativeMode.ThirdPerson);

        // 13. Encounter probability setup
        if (_state.EncounterTriggerFlag == 0 && (GD.Randi() & 1) != 0)
        {
            _state.EncounterSlot = (byte)slot;
            _state.EncounterTriggerFlag = 1;
            _state.EncounterFlag = 1;
            _state.EncounterMask = 0x1F;
        }
    }

    // ==== Helpers ====

    /// <summary>
    /// fn0800_19F3: rejection-sampled D6 (RNG & 7, retry if > 5, then +1)
    /// </summary>
    private int RollD6()
    {
        int val;
        do { val = (int)(GD.Randi() & 7); } while (val > 5);
        return val + 1;
    }

    /// <summary>
    /// fn0800_19DD: 2D6 roll (two D6 summed => range 2-12)
    /// </summary>
    private int Roll2D6() => RollD6() + RollD6();

    /// <summary>
    /// Get a display name for a unit based on TypeId and handler tag.
    /// Original game looks up from a01CC/a01CA name template table at segment 54C8.
    /// </summary>
    private string GetUnitName(UnitSlot unit)
    {
        // TypeId starts at 2 (counter wraps 2..9), represents person ID not mech type
        // Handler tag from BLD opcode determines the unit's role
        string role = unit.HandlerTag switch
        {
            -21 => "Cadet",
            -19 => "Arena Fighter",
            -24 => "Guardsman",
            -13 => "Attendant",
            -38 => "Hireling",
            -20 => "Trainee",
            -28 => "Mercenary",
            -11 => "Technician",
            -12 => "Agent",
            -65 => "Specialist",
            4 => "Veteran",
            _ => "Recruit"
        };
        return $"{role} #{unit.TypeId}";
    }

    private void FlushText()
    {
        if (!string.IsNullOrEmpty(_currentText))
        {
            string trimmed = _currentText.Trim();
            _lastRenderedText = trimmed;
            EmitSignal(SignalName.TextRendered, trimmed, (int)_currentNarrativeMode);
            _currentText = "";
        }
    }
}
