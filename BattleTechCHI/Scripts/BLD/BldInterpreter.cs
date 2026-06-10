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
    private NarrativeMode _currentNarrativeMode = NarrativeMode.ThirdPerson;

    private bool _waitingForInput;
    private bool _running;

    [Signal]
    public delegate void TextRenderedEventHandler(string text, NarrativeMode mode);

    [Signal]
    public delegate void CreditsChangedEventHandler(int newAmount);

    [Signal]
    public delegate void InterpreterCompleteEventHandler();

    [Signal]
    public delegate void SpriteRequestedEventHandler(int spriteId);

    public bool IsRunning => _running;
    public bool WaitingForInput => _waitingForInput;

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
        if (_waitingForInput) return;

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
        _waitingForInput = false;
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
                if (ReadByte(out byte cond)) GD.Print($"  cond_state_action({cond}) — TBD");
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
                    GD.Print($"  shop_interaction(state[{sidx}]={_state.StateArray[sidx]}) — TBD");
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
                break;

            case BldOpcode.StateCondCheck:
                if (ReadByte(out byte sci) && _state.StateArray[sci] == 0) ReadWord(out _);
                break;

            case BldOpcode.JumpForward:
                if (ReadWord(out short fwd)) _ip += fwd;
                break;

            case BldOpcode.JumpIndexed:
                if (ReadByte(out byte ji)) _ip += ji * 2 + 2;
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
        EmitSignal(SignalName.InterpreterComplete);
    }

    private GameMode? DispatchCase(byte rawCase)
    {
        byte caseVal = (byte)((rawCase & 0x1F) + 1);
        GD.Print($"  raw_operand=0x{rawCase:X2} → case=0x{caseVal:X2}");
        var shop = _script != null ? ShopRegistry.Get(_script.Name) : null;
        return Fn1CD3Dispatcher.Dispatch(caseVal, _state, shop);
    }

    private void CallRoomHandler(byte handlerIdx)
    {
        GD.Print($"  call_room_handler({handlerIdx}) — TBD");
    }

    private void FlushText()
    {
        if (!string.IsNullOrEmpty(_currentText))
        {
            EmitSignal(SignalName.TextRendered, _currentText.Trim(), (int)_currentNarrativeMode);
            _currentText = "";
        }
    }
}
