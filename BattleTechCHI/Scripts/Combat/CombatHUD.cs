using Godot;
using BattleTechCHI.Data;

namespace BattleTechCHI.Combat;

public partial class CombatHUD : Control
{
    private CombatState _combatState = null!;
    private GameState _gameState = null!;

    private MechPortrait _mechPortrait = null!;
    private Label _statusLabel = null!;
    private Label _messageLabel = null!;
    private RichTextLabel _logLabel = null!;
    private Label _unitInfoLabel = null!;
    private Label _targetInfoLabel = null!;
    private Label _weaponListLabel = null!;
    private Label _promptLabel = null!;
    private ColorRect _bg = null!;
    private int _lastPortraitUnit = -1;

    public override void _Ready()
    {
        _bg = new ColorRect();
        _bg.Color = new Color(0, 0, 0x55, 0.85f);
        _bg.Size = new Vector2(80, 200);
        AddChild(_bg);

        _mechPortrait = new MechPortrait
        {
            Name = "MechPortrait",
            Position = new Vector2(0, 0),
        };
        AddChild(_mechPortrait);

        var theme = CreateEgaTheme();

        _statusLabel = new Label();
        _statusLabel.Position = new Vector2(4, 50);
        _statusLabel.Theme = theme;
        _statusLabel.Text = "";
        _statusLabel.HorizontalAlignment = HorizontalAlignment.Center;
        _statusLabel.Size = new Vector2(76, 12);
        AddChild(_statusLabel);

        _unitInfoLabel = new Label();
        _unitInfoLabel.Position = new Vector2(4, 64);
        _unitInfoLabel.Theme = theme;
        _unitInfoLabel.Text = "";
        _unitInfoLabel.Size = new Vector2(76, 40);
        _unitInfoLabel.AutowrapMode = TextServer.AutowrapMode.Off;
        AddChild(_unitInfoLabel);

        _weaponListLabel = new Label();
        _weaponListLabel.Position = new Vector2(4, 106);
        _weaponListLabel.Theme = theme;
        _weaponListLabel.Text = "";
        _weaponListLabel.Size = new Vector2(76, 46);
        _weaponListLabel.AutowrapMode = TextServer.AutowrapMode.Off;
        AddChild(_weaponListLabel);

        _logLabel = new RichTextLabel();
        _logLabel.Position = new Vector2(4, 154);
        _logLabel.Size = new Vector2(76, 28);
        _logLabel.Theme = theme;
        _logLabel.BbcodeEnabled = true;
        _logLabel.Text = "";
        _logLabel.AutowrapMode = TextServer.AutowrapMode.Off;
        AddChild(_logLabel);

        _promptLabel = new Label();
        _promptLabel.Position = new Vector2(4, 184);
        _promptLabel.Theme = theme;
        _promptLabel.Text = "";
        _promptLabel.Size = new Vector2(76, 16);
        AddChild(_promptLabel);
    }

    public void SetState(CombatState combatState, GameState gameState)
    {
        _combatState = combatState;
        _gameState = gameState;
    }

    public void UpdateDisplay()
    {
        if (_combatState == null || !_combatState.Active)
        {
            Hide();
            return;
        }
        Show();

        _statusLabel.Text = $"Round {_combatState.StageCounter + 1}  Unit {_combatState.CurrentUnit}/24";

        if (_combatState.InputState == CombatInputState.Auto)
            _promptLabel.Text = "[自動]";
        else if (_combatState.InputState == CombatInputState.WaitingForTarget)
            _promptLabel.Text = "[方向キー:移動 Space:確定 Esc:キャンセル]";
        else if (_combatState.InputState == CombatInputState.WaitingForWeapon)
            _promptLabel.Text = "[1-9:武器選択 Space:発砲]";
        else if (_combatState.InputState == CombatInputState.WaitingForConfirm)
            _promptLabel.Text = "[Space:確認 Esc:戻る]";
        else
            _promptLabel.Text = "";

        int unit = _combatState.CurrentUnit;
        if (unit >= 0 && unit < 24 && _combatState.IsAlive(unit))
        {
            var mech = _combatState.Units[unit];

            // Update portrait when unit changes
            if (unit != _lastPortraitUnit)
            {
                _lastPortraitUnit = unit;
                _mechPortrait.SetMechType(mech.MechId);
            }

            string team = _combatState.IsPlayer(unit) ? "自軍" : "敵軍";
            string type = mech.IsMech ? $"Mech ID:{mech.MechId}" : "歩兵";
            _unitInfoLabel.Text = $"Unit {unit} ({team}) {type}\n" +
                $"HP:{mech.CurrentStructure[4]}/{mech.MaxStructure[4]} " +
                $"装甲:{mech.CurrentArmour[4]}/{mech.MaxArmour[4]} " +
                $"熱量:{mech.HeatPool}/{CombatConstants.MaxHeat}" +
                (mech.HeatPenalty > 0 ? $" [+{mech.HeatPenalty}]" : "") +
                $" Pos:({mech.UnitX},{mech.UnitY})";

            string wpnText = "武器:\n";
            if (mech.Ammo != null)
            {
                for (int i = 0; i < mech.Ammo.Length; i++)
                {
                    if (mech.Ammo[i].WeaponId > 0)
                    {
                        int wid = mech.Ammo[i].WeaponId;
                        string wName = wid >= 1 && wid <= WeaponData.Weapons.Length
                            ? WeaponData.Weapons[wid - 1].Name : $"WPN{wid}";
                        string marker = (i == _combatState.SelectedWeaponSlot) ? ">" : " ";
                        wpnText += $" {marker}[{i + 1}] {wName} ({mech.Ammo[i].Remaining}/{mech.Ammo[i].MaxCapacity})\n";
                    }
                }
            }
            _weaponListLabel.Text = wpnText;
        }

        if (_combatState.CurrentTargetId >= 0 && _combatState.IsAlive(_combatState.CurrentTargetId))
        {
            int tid = _combatState.CurrentTargetId;
            var tgt = _combatState.Units[tid];
            int dist = _combatState.GetDistance(unit, tid);
            _targetInfoLabel.Text = $"Target: Unit {tid} ({tgt.UnitX},{tgt.UnitY}) Dist:{dist}";
        }
        else
        {
            _targetInfoLabel.Text = "";
        }

        _logLabel.Text = "";
        int startIdx = Mathf.Max(0, _combatState.Messages.Count - 3);
        for (int i = startIdx; i < _combatState.Messages.Count; i++)
            _logLabel.Text += _combatState.Messages[i] + "\n";

        UpdatePortraitState();
    }

    private void UpdatePortraitState()
    {
        if (_combatState == null) return;

        int unit = _combatState.CurrentUnit;
        if (unit < 0 || unit >= 24 || !_combatState.IsAlive(unit))
        {
            _mechPortrait.SetAnimState(MechPortraitAnimState.Idle);
            return;
        }

        switch (_combatState.Phase)
        {
            case CombatPhase.Movement:
                _mechPortrait.SetAnimState(MechPortraitAnimState.Moving);
                break;

            case CombatPhase.ToHit:
            case CombatPhase.Fire:
                _mechPortrait.SetAnimState(MechPortraitAnimState.Firing);
                break;

            case CombatPhase.PostFire:
                _mechPortrait.SetAnimState(MechPortraitAnimState.TakingDamage);
                break;

            default:
                _mechPortrait.SetAnimState(MechPortraitAnimState.Idle);
                break;
        }
    }

    private static Theme CreateEgaTheme()
    {
        var theme = new Theme();
        var font = ThemeDB.FallbackFont;
        theme.SetFont("font", "Label", font);
        theme.SetColor("font_color", "Label", new Color(0xAA, 0xAA, 0xAA));
        theme.SetConstant("outline_size", "Label", 1);
        theme.SetColor("font_outline_color", "Label", Colors.Black);
        theme.SetFont("font", "RichTextLabel", font);
        theme.SetColor("default_color", "RichTextLabel", new Color(0xAA, 0xAA, 0xAA));
        return theme;
    }

    private string GetWeaponName(int weaponId)
    {
        if (weaponId >= 1 && weaponId <= WeaponData.Weapons.Length)
            return WeaponData.Weapons[weaponId - 1].Name;
        return $"WPN{weaponId}";
    }
}
