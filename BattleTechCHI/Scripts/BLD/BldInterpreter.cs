using Godot;
using BattleTechCHI.Data;
using BattleTechCHI.Core;

namespace BattleTechCHI.BLD;

/// <summary>
/// Interprete del bytecode BLD (26 opcode 0xE4-0xFF).
/// Legge il buffer decriptato dal BldLoader ed esegue le istruzioni
/// che controllano dialoghi, negozi, story progression, combattimenti.
/// </summary>
public partial class BldInterpreter : Node
{
    private GameState _state = null!;
    private BldScript? _script;

    private int _ip;
    private string _currentText = "";
    private NarrativeMode _currentNarrativeMode = NarrativeMode.ThirdPerson;

    [Signal]
    public delegate void TextRenderedEventHandler(string text, NarrativeMode mode);

    [Signal]
    public delegate void CreditsChangedEventHandler(int newAmount);

    [Signal]
    public delegate void InterpreterCompleteEventHandler();

    public void LoadAndRun(BldScript script)
    {
        _script = script;
        _ip = 0;
        _currentText = "";
        _currentNarrativeMode = NarrativeMode.ThirdPerson;

        var gl = GetNode<GameLoop>("/root/GameLoop");
        _state = gl.State;

        GD.Print($"BLD Interpreter: running {script.Name} ({script.RawBytes.Length} bytes)");
        Run();
    }

    private void Run()
    {
        if (_script == null) return;
        var buf = _script.RawBytes;
        int base_ = _script.InterpreterBase;

        while (_ip < buf.Length - base_)
        {
            int filePos = base_ + _ip;
            if (filePos >= buf.Length) break;

            byte b = buf[filePos];

            // 0x00-0x7F = cipher text direct to renderer
            if (b < 0x80) { HandleTextByte(b); _ip++; continue; }

            // 0x80-0xC3: structural markers / narrative mode switches
            if (b >= 0x80 && b <= 0xC3)
            {
                switch (b)
                {
                    case 0x9E: _currentNarrativeMode = NarrativeMode.ThirdPerson; break;
                    case 0x9C: _currentNarrativeMode = NarrativeMode.CharacterSpeech; break;
                    case 0x9B: _currentNarrativeMode = NarrativeMode.PlayerThought; break;
                    case 0x9F: _currentNarrativeMode = NarrativeMode.PlayerAction; break;
                    case 0xA5: _currentNarrativeMode = NarrativeMode.Continuation; break;
                    case 0xA0: HandleTextByte(b); break;
                }
                _ip++;
                continue;
            }

            // 0xC0 = structural separator (no-op, next byte is real opcode)
            if (b == 0xC0) { _ip++; continue; }

            // Opcode range 0xE4-0xFF
            if (b >= 0xE4)
            {
                _ip++;
                if (!ExecuteOpcode((BldOpcode)b)) break;
                continue;
            }

            _ip++; // skip unknown
        }

        EmitSignal(SignalName.InterpreterComplete);
    }

    private void HandleTextByte(byte b) => _currentText += CipherDecoder.DecodeByte(b);

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
                if (!_state.Milestone) ReadWord(out _);
                break;

            case BldOpcode.CheckFlagEC:
                if (!_state.TrainingComplete) ReadWord(out _);
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
                if (ReadByte(out byte caseVal)) { FlushText(); DispatchCase(caseVal); }
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
                if (ReadByte(out byte sid)) GD.Print($"  draw_sprite({sid}) — TBD");
                break;

            case BldOpcode.AdvanceInput:
                FlushText(); break;

            case BldOpcode.RenderText:
                FlushText(); break;

            case BldOpcode.SetFont2: break;
            case BldOpcode.SetFont: ReadByte(out _); break;

            case BldOpcode.StopInterpreter:
                FlushText(); return false;

            default:
                GD.Print($"  unknown opcode {opcode} (0x{(byte)opcode:X2}) at IP={_ip}");
                break;
        }
        return true;
    }

    private void DispatchCase(byte caseVal)
    {
        Fn1CD3Dispatcher.Dispatch(caseVal);
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