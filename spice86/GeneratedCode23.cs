namespace generated;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.InstructionsImpl;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action entry_24D7_0010_24D80(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_24D7_0010_24D80:
    CheckExternalEvents(cs16, 0x14);
    // AND AH,byte ptr [BP + SI + 0x2222] (24D7_0010 / 0x24D80)
    AH &= UInt8[SS, (ushort)(BP + SI + 0x2222)];
    CheckExternalEvents(cs16, 0x16);
    // AND AH,byte ptr [BP + SI] (24D7_0014 / 0x24D84)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0x18);
    // AND AH,byte ptr [BP + SI] (24D7_0016 / 0x24D86)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0x1C);
    // AND AH,byte ptr [BP + SI + 0x8022] (24D7_0018 / 0x24D88)
    AH &= UInt8[SS, (ushort)(BP + SI + 0x8022)];
    CheckExternalEvents(cs16, 0x1E);
    // ADD byte ptr [BX + SI],AL (24D7_001C / 0x24D8C)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x20);
    // ADD byte ptr [BX + SI],AL (24D7_001E / 0x24D8E)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x22);
    // ADD byte ptr [BX + SI],AL (24D7_0020 / 0x24D90)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x24);
    // ADD byte ptr [BX + SI],AL (24D7_0022 / 0x24D92)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x26);
    // ADD byte ptr [BX + SI],AL (24D7_0024 / 0x24D94)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x28);
    // ADD byte ptr [BX + SI],AL (24D7_0026 / 0x24D96)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x2A);
    // ADD byte ptr [BX + SI],AL (24D7_0028 / 0x24D98)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x2C);
    // ADD byte ptr [BX + SI],AL (24D7_002A / 0x24D9A)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x2E);
    // ADD byte ptr [BX + SI],AL (24D7_002C / 0x24D9C)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x30);
    // ADD byte ptr [BX + SI],AL (24D7_002E / 0x24D9E)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x32);
    // ADD byte ptr [BX + SI],AL (24D7_0030 / 0x24DA0)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x34);
    // ADD byte ptr [BX + SI],AL (24D7_0032 / 0x24DA2)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x36);
    // ADD byte ptr [BX + SI],AL (24D7_0034 / 0x24DA4)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x38);
    // ADD byte ptr [BX + SI],AL (24D7_0036 / 0x24DA6)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x3A);
    // ADD byte ptr [BX + SI],AL (24D7_0038 / 0x24DA8)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs16, 0x3C);
    // ADD byte ptr [BX + DI],AL (24D7_003A / 0x24DAA)
    // UInt8[DS, (ushort)(BX + DI)] += AL;
    UInt8[DS, (ushort)(BX + DI)] = Alu8.Add(UInt8[DS, (ushort)(BX + DI)], AL);
    CheckExternalEvents(cs16, 0x40);
    // PADDD MM6,qword ptr [BX + 0x11] (24D7_003C / 0x24DAC)
    throw FailAsUntested("Unimplemented Instruction!");
    CheckExternalEvents(cs16, 0x41);
    // POP SS (24D7_0040 / 0x24DB0)
    SS = Stack.Pop16();;
    CheckExternalEvents(cs16, 0x43);
    // JNO 0x2000:4dcc (24D7_0041 / 0x24DB1)
    if(!OverflowFlag) {
      throw FailAsUntested("Would have been a goto but label label_24D7_005C_24DCC does not exist because no instruction was found there that belongs to a function.");
    }
    CheckExternalEvents(cs16, 0x44);
    // XCHG AX,SI (24D7_0043 / 0x24DB3)
    (SI, AX) = (AX, SI);
    CheckExternalEvents(cs16, 0x45);
    // OUT DX,AL (24D7_0044 / 0x24DB4)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs16, 0x47);
    // OUT 0xf9,AL (24D7_0045 / 0x24DB5)
    Cpu.Out8(0xF9, AL);
    CheckExternalEvents(cs16, 0x4A);
    // OUT 0x6,AL (24D7_0047 / 0x24DB7)
    Cpu.Out8(0x6, AL);
    CheckExternalEvents(cs16, 0x4B);
    // POPF  (24D7_004A / 0x24DBA)
    FlagRegister16 = Stack.Pop16();;
    CheckExternalEvents(cs16, 0x4C);
    // OUTSB DX,SI (24D7_004B / 0x24DBB)
    Cpu.Out8(DX, UInt8[DS, (ushort)(SI)]);
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs16, 0x4D);
    // OUT DX,AL (24D7_004C / 0x24DBC)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs16, 0x51);
    // ADC word ptr [BX + SI],0x7177 (24D7_004D / 0x24DBD)
    UInt16[DS, (ushort)(BX + SI)] = Alu16.Adc(UInt16[DS, (ushort)(BX + SI)], 0x7177);
    CheckExternalEvents(cs16, 0x54);
    // INC byte ptr [BX + 0x2] (24D7_0051 / 0x24DC1)
    UInt8[DS, (ushort)(BX + 0x2)] = Alu8.Inc(UInt8[DS, (ushort)(BX + 0x2)]);
    CheckExternalEvents(cs16, 0x58);
    // SBB byte ptr [BX + DI + 0xec],AL (24D7_0054 / 0x24DC4)
    UInt8[DS, (ushort)(BX + DI + 0xEC)] = Alu8.Sbb(UInt8[DS, (ushort)(BX + DI + 0xEC)], AL);
    CheckExternalEvents(cs16, 0x5A);
    // ADD CX,SI (24D7_0058 / 0x24DC8)
    CX += SI;
    CheckExternalEvents(cs16, 0x5E);
    // DEC byte ptr [BX + SI + 0x1810] (24D7_005A / 0x24DCA)
    UInt8[DS, (ushort)(BX + SI + 0x1810)] = Alu8.Dec(UInt8[DS, (ushort)(BX + SI + 0x1810)]);
    CheckExternalEvents(cs16, 0x62);
    // SBB word ptr [BX + DI],0x1168 (24D7_005E / 0x24DCE)
    UInt16[DS, (ushort)(BX + DI)] = Alu16.Sbb(UInt16[DS, (ushort)(BX + DI)], 0x1168);
    CheckExternalEvents(cs16, 0x64);
    // SBB SP,SI (24D7_0062 / 0x24DD2)
    SP = Alu16.Sbb(SP, SI);
    CheckExternalEvents(cs16, 0x65);
    // XCHG AX,SI (24D7_0064 / 0x24DD4)
    (SI, AX) = (AX, SI);
    label_24D7_0065_24DD5:
    CheckExternalEvents(cs16, 0x67);
    // OUT 0x6,AL (24D7_0065 / 0x24DD5)
    Cpu.Out8(0x6, AL);
    CheckExternalEvents(cs16, 0x69);
    // FISTTP qword ptr [BX + SI] (24D7_0067 / 0x24DD7)
    throw FailAsUntested("Unimplemented Instruction!");
    CheckExternalEvents(cs16, 0x6B);
    // MOV byte ptr [BX + DI],DL (24D7_0069 / 0x24DD9)
    UInt8[DS, (ushort)(BX + DI)] = DL;
    CheckExternalEvents(cs16, 0x70);
    // XOR word ptr [BX + -0x3],0xbb11 (24D7_006B / 0x24DDB)
    // UInt16[DS, (ushort)(BX - 0x3)] ^= 0xBB11;
    UInt16[DS, (ushort)(BX - 0x3)] = Alu16.Xor(UInt16[DS, (ushort)(BX - 0x3)], 0xBB11);
    CheckExternalEvents(cs16, 0x71);
    // STC  (24D7_0070 / 0x24DE0)
    CarryFlag = true;
    CheckExternalEvents(cs16, 0x74);
    // MOV BX,0xbbbb (24D7_0071 / 0x24DE1)
    BX = 0xBBBB;
    CheckExternalEvents(cs16, 0x77);
    // MOV DI,0x2252 (24D7_0074 / 0x24DE4)
    DI = 0x2252;
    CheckExternalEvents(cs16, 0x79);
    // AND AH,byte ptr [BP + SI] (24D7_0077 / 0x24DE7)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0x7B);
    // AND AH,byte ptr [BP + SI] (24D7_0079 / 0x24DE9)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0x7D);
    // AND AH,byte ptr [BP + SI] (24D7_007B / 0x24DEB)
    // AH &= UInt8[SS, (ushort)(BP + SI)];
    AH = Alu8.And(AH, UInt8[SS, (ushort)(BP + SI)]);
    CheckExternalEvents(cs16, 0x80);
    // MOV [0x2222],AL (24D7_007D / 0x24DED)
    UInt8[DS, 0x2222] = AL;
    CheckExternalEvents(cs16, 0x82);
    // AND AH,byte ptr [BP + SI] (24D7_0080 / 0x24DF0)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0x86);
    // AND AL,byte ptr [BX + 0x87f7] (24D7_0082 / 0x24DF2)
    AL &= UInt8[DS, (ushort)(BX + 0x87F7)];
    CheckExternalEvents(cs16, 0x8C);
    // TEST word ptr [BX + 0x87f7],0x87f7 (24D7_0086 / 0x24DF6)
    Alu16.And(UInt16[DS, (ushort)(BX + 0x87F7)], 0x87F7);
    CheckExternalEvents(cs16, 0x92);
    // TEST word ptr [BX + 0x87f7],0x87f7 (24D7_008C / 0x24DFC)
    Alu16.And(UInt16[DS, (ushort)(BX + 0x87F7)], 0x87F7);
    CheckExternalEvents(cs16, 0x98);
    // TEST word ptr [BX + 0x87f7],0x39f7 (24D7_0092 / 0x24E02)
    Alu16.And(UInt16[DS, (ushort)(BX + 0x87F7)], 0x39F7);
    CheckExternalEvents(cs16, 0x9B);
    // INC word ptr [BX + -0x1] (24D7_0098 / 0x24E08)
    UInt16[DS, (ushort)(BX - 0x1)]++;
    CheckExternalEvents(cs16, 0x9F);
    // AND AH,byte ptr [BP + SI + 0xa2a2] (24D7_009B / 0x24E0B)
    AH &= UInt8[SS, (ushort)(BP + SI + 0xA2A2)];
    CheckExternalEvents(cs16, 0xA1);
    // SUB AH,byte ptr [BP + SI] (24D7_009F / 0x24E0F)
    AH -= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0xA3);
    // AND AH,byte ptr [BP + SI] (24D7_00A1 / 0x24E11)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0xA5);
    // AND AH,byte ptr [BP + SI] (24D7_00A3 / 0x24E13)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0xA7);
    // AND AH,byte ptr [BP + SI] (24D7_00A5 / 0x24E15)
    // AH &= UInt8[SS, (ushort)(BP + SI)];
    AH = Alu8.And(AH, UInt8[SS, (ushort)(BP + SI)]);
    CheckExternalEvents(cs16, 0xA8);
    // POP ES (24D7_00A7 / 0x24E17)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs16, 0xAC);
    // MOV byte ptr [BX + SI + 0x2207],CL (24D7_00A8 / 0x24E18)
    UInt8[DS, (ushort)(BX + SI + 0x2207)] = CL;
    CheckExternalEvents(cs16, 0xAF);
    // AND CH,byte ptr [BX] (24D7_00AC / 0x24E1C)
    CH &= UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs16, 0xB1);
    // AND AH,byte ptr [BP + SI] (24D7_00AF / 0x24E1F)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0xB3);
    // AND AH,byte ptr [BP + SI] (24D7_00B1 / 0x24E21)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0xB5);
    // AND AH,byte ptr [BP + SI] (24D7_00B3 / 0x24E23)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0xB7);
    // SUB CH,byte ptr [BP + SI] (24D7_00B5 / 0x24E25)
    CH -= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0xB9);
    // AND AH,byte ptr [BP + SI] (24D7_00B7 / 0x24E27)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0xBB);
    // AND AH,byte ptr [BP + SI] (24D7_00B9 / 0x24E29)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs16, 0xBF);
    // SUB byte ptr [0x6066],AL (24D7_00BB / 0x24E2B)
    UInt8[DS, 0x6066] -= AL;
    CheckExternalEvents(cs16, 0xC3);
    // ADD byte ptr [0x6066],AL (24D7_00BF / 0x24E2F)
    UInt8[DS, 0x6066] += AL;
    CheckExternalEvents(cs16, 0xC7);
    // ADD byte ptr [0xe00e],CL (24D7_00C3 / 0x24E33)
    UInt8[DS, 0xE00E] += CL;
    CheckExternalEvents(cs16, 0xCB);
    // ADD byte ptr [0xe00e],CL (24D7_00C7 / 0x24E37)
    UInt8[DS, 0xE00E] += CL;
    CheckExternalEvents(cs16, 0xCF);
    // ADD byte ptr [0xe00e],CL (24D7_00CB / 0x24E3B)
    UInt8[DS, 0xE00E] += CL;
    CheckExternalEvents(cs16, 0xD3);
    // ADD byte ptr [0xe00e],CL (24D7_00CF / 0x24E3F)
    UInt8[DS, 0xE00E] += CL;
    CheckExternalEvents(cs16, 0xD7);
    // ADD byte ptr [0x6066],AL (24D7_00D3 / 0x24E43)
    UInt8[DS, 0x6066] += AL;
    CheckExternalEvents(cs16, 0xDB);
    // ADD byte ptr [0x6066],AL (24D7_00D7 / 0x24E47)
    // UInt8[DS, 0x6066] += AL;
    UInt8[DS, 0x6066] = Alu8.Add(UInt8[DS, 0x6066], AL);
    CheckExternalEvents(cs16, 0xDD);
    // LOOPZ 0x2000:4e65 (24D7_00DB / 0x24E4B)
    if(--CX != 0 && ZeroFlag) {
      goto label_24D7_00F5_24E65;
    }
    CheckExternalEvents(cs16, 0xDE);
    // CWD  (24D7_00DD / 0x24E4D)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs16, 0xDF);
    // XCHG AX,CX (24D7_00DE / 0x24E4E)
    (CX, AX) = (AX, CX);
    CheckExternalEvents(cs16, 0xE2);
    // INC byte ptr [BX + 0x2] (24D7_00DF / 0x24E4F)
    UInt8[DS, (ushort)(BX + 0x2)] = Alu8.Inc(UInt8[DS, (ushort)(BX + 0x2)]);
    CheckExternalEvents(cs16, 0xE4);
    // JS 0x2000:4dd5 (24D7_00E2 / 0x24E52)
    if(SignFlag) {
      goto label_24D7_0065_24DD5;
    }
    CheckExternalEvents(cs16, 0xE5);
    // IN AL,DX (24D7_00E4 / 0x24E54)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs16, 0xE7);
    // ADD byte ptr [BP + SI],AL (24D7_00E5 / 0x24E55)
    UInt8[SS, (ushort)(BP + SI)] += AL;
    CheckExternalEvents(cs16, 0xE9);
    // NEG word ptr [BX + SI] (24D7_00E7 / 0x24E57)
    UInt16[DS, (ushort)(BX + SI)] = Alu16.Sub(0, UInt16[DS, (ushort)(BX + SI)]);
    CheckExternalEvents(cs16, 0xEC);
    // INC byte ptr [BX + 0xe] (24D7_00E9 / 0x24E59)
    UInt8[DS, (ushort)(BX + 0xE)] = Alu8.Inc(UInt8[DS, (ushort)(BX + 0xE)]);
    CheckExternalEvents(cs16, 0xEE);
    // MOV byte ptr [BX + DI],BL (24D7_00EC / 0x24E5C)
    UInt8[DS, (ushort)(BX + DI)] = BL;
    CheckExternalEvents(cs16, 0xEF);
    // OUTSB DX,SI (24D7_00EE / 0x24E5E)
    Cpu.Out8(DX, UInt8[DS, (ushort)(SI)]);
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs16, 0xF3);
    // SUB SI,0x66e6 (24D7_00EF / 0x24E5F)
    // SI -= 0x66E6;
    SI = Alu16.Sub(SI, 0x66E6);
    CheckExternalEvents(cs16, 0xF4);
    // PUSH CS (24D7_00F3 / 0x24E63)
    Stack.Push16(cs16);
    CheckExternalEvents(cs16, 0xF5);
    // OUT DX,AL (24D7_00F4 / 0x24E64)
    Cpu.Out8(DX, AL);
    label_24D7_00F5_24E65:
    CheckExternalEvents(cs16, 0xF8);
    // CALL 0x2000:bd61 (24D7_00F5 / 0x24E65)
    NearCall(cs16, 0xF8, ghidra_guess_2000_BD61_2BD61);
    CheckExternalEvents(cs16, 0xFA);
    // LOOPZ 0x2000:4e82 (24D7_00F8 / 0x24E68)
    if(--CX != 0 && ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_2000_4E82_24E82, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs16, 0xFE);
    // INC byte ptr [BX + DI + 0x1704] (24D7_00FA / 0x24E6A)
    UInt8[DS, (ushort)(BX + DI + 0x1704)] = Alu8.Inc(UInt8[DS, (ushort)(BX + DI + 0x1704)]);
    CheckExternalEvents(cs16, 0x100);
    // JA 0x2000:4ee8 (24D7_00FE / 0x24E6E)
    if(!CarryFlag && !ZeroFlag) {
      throw FailAsUntested("Would have been a goto but label label_24D7_0178_24EE8 does not exist because no instruction was found there that belongs to a function.");
    }
    CheckExternalEvents(cs16, 0x104);
    // SUB SP,0x1200 (24D7_0100 / 0x24E70)
    // SP -= 0x1200;
    SP = Alu16.Sub(SP, 0x1200);
    CheckExternalEvents(cs16, 0x106);
    // NOT word ptr [BX] (24D7_0104 / 0x24E74)
    UInt16[DS, (ushort)(BX)] = (ushort)(~UInt16[DS, (ushort)(BX)]);
    CheckExternalEvents(cs16, 0x108);
    // JA 0x2000:4ef0 (24D7_0106 / 0x24E76)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_2000_4E82_24E82, 0x24EF0 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs16, 0x10E);
    // SBB word ptr [BX + DI + 0x8e6e],0xe9ee (24D7_0108 / 0x24E78)
    UInt16[DS, (ushort)(BX + DI + 0x8E6E)] = Alu16.Sbb(UInt16[DS, (ushort)(BX + DI + 0x8E6E)], 0xE9EE);
    CheckExternalEvents(cs16, 0x10F);
    // OUTSW DX,SI (24D7_010E / 0x24E7E)
    Cpu.Out16(DX, UInt16[DS, (ushort)(SI)]);
    SI = (ushort)(SI + Direction16);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action split_2000_4E82_24E82(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_2000_4E82_24E82:
    CheckExternalEvents(cs15, 0x4E86);
    // INC word ptr [BP + DI + 0x55bf] (2000_4E82 / 0x24E82)
    UInt16[SS, (ushort)(BP + DI + 0x55BF)]++;
    CheckExternalEvents(cs15, 0x4E88);
    // AND AH,byte ptr [BP + SI] (2000_4E86 / 0x24E86)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4E8A);
    // AND AH,byte ptr [BP + SI] (2000_4E88 / 0x24E88)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4E8C);
    // AND AH,byte ptr [BP + SI] (2000_4E8A / 0x24E8A)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4E8E);
    // AND AH,byte ptr [BP + SI] (2000_4E8C / 0x24E8C)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4E90);
    // AND AH,byte ptr [BP + SI] (2000_4E8E / 0x24E8E)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4E94);
    // AND AH,byte ptr [BP + SI + 0x8722] (2000_4E90 / 0x24E90)
    AH &= UInt8[SS, (ushort)(BP + SI + 0x8722)];
    CheckExternalEvents(cs15, 0x4E9A);
    // TEST word ptr [BX + 0x87f7],0x87f7 (2000_4E94 / 0x24E94)
    Alu16.And(UInt16[DS, (ushort)(BX + 0x87F7)], 0x87F7);
    CheckExternalEvents(cs15, 0x4EA0);
    // TEST word ptr [BX + 0x87f7],0x87f7 (2000_4E9A / 0x24E9A)
    Alu16.And(UInt16[DS, (ushort)(BX + 0x87F7)], 0x87F7);
    CheckExternalEvents(cs15, 0x4EA6);
    // TEST word ptr [BX + 0x87f7],0x87f7 (2000_4EA0 / 0x24EA0)
    Alu16.And(UInt16[DS, (ushort)(BX + 0x87F7)], 0x87F7);
    CheckExternalEvents(cs15, 0x4EA8);
    // IDIV word ptr [BX + DI] (2000_4EA6 / 0x24EA6)
    int op1Idiv2000_4EA6 = (int)(DX << 16 | AX);
    short op2Idiv2000_4EA6 = (short)UInt16[DS, (ushort)(BX + DI)];
    short? resIdiv2000_4EA6 = Alu16.Idiv(op1Idiv2000_4EA6, op2Idiv2000_4EA6);
    if(resIdiv2000_4EA6 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = (ushort)resIdiv2000_4EA6.Value;
    DX = (ushort)(op1Idiv2000_4EA6 % op2Idiv2000_4EA6);
    CheckExternalEvents(cs15, 0x4EAC);
    // INC word ptr [BX + 0x22ff] (2000_4EA8 / 0x24EA8)
    UInt16[DS, (ushort)(BX + 0x22FF)]++;
    CheckExternalEvents(cs15, 0x4EAE);
    // AND AH,byte ptr [BP + SI] (2000_4EAC / 0x24EAC)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4EB0);
    // AND AH,byte ptr [BP + SI] (2000_4EAE / 0x24EAE)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4EB4);
    // AND AH,byte ptr [BP + SI + 0x22a2] (2000_4EB0 / 0x24EB0)
    AH &= UInt8[SS, (ushort)(BP + SI + 0x22A2)];
    CheckExternalEvents(cs15, 0x4EB6);
    // AND AH,byte ptr [BP + SI] (2000_4EB4 / 0x24EB4)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4EB8);
    // AND AL,byte ptr [BX] (2000_4EB6 / 0x24EB6)
    // AL &= UInt8[DS, (ushort)(BX)];
    AL = Alu8.And(AL, UInt8[DS, (ushort)(BX)]);
    CheckExternalEvents(cs15, 0x4EBC);
    // MOV byte ptr [BX + SI + 0x2207],CL (2000_4EB8 / 0x24EB8)
    UInt8[DS, (ushort)(BX + SI + 0x2207)] = CL;
    CheckExternalEvents(cs15, 0x4EBD);
    // CLI  (2000_4EBC / 0x24EBC)
    InterruptFlag = false;
    CheckExternalEvents(cs15, 0x4EBF);
    // AND AH,byte ptr [BP + SI] (2000_4EBD / 0x24EBD)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4EC2);
    // AND AH,byte ptr [BP + SI] (2000_4EBF / 0x24EBF)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4EC4);
    // AND AH,byte ptr [BP + SI] (2000_4EC2 / 0x24EC2)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4EC6);
    // SUB AH,byte ptr [BP + SI] (2000_4EC4 / 0x24EC4)
    AH -= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4EC8);
    // AND AH,byte ptr [BP + SI] (2000_4EC6 / 0x24EC6)
    // AH &= UInt8[SS, (ushort)(BP + SI)];
    AH = Alu8.And(AH, UInt8[SS, (ushort)(BP + SI)]);
    CheckExternalEvents(cs15, 0x4ECB);
    // MOV [0x2222],AL (2000_4EC8 / 0x24EC8)
    UInt8[DS, 0x2222] = AL;
    CheckExternalEvents(cs15, 0x4ECF);
    // AND AL,byte ptr [BX + 0xee0e] (2000_4ECB / 0x24ECB)
    AL &= UInt8[DS, (ushort)(BX + 0xEE0E)];
    CheckExternalEvents(cs15, 0x4ED2);
    // ADD byte ptr [BX + SI + -0x12],DH (2000_4ECF / 0x24ECF)
    // UInt8[DS, (ushort)(BX + SI - 0x12)] += DH;
    UInt8[DS, (ushort)(BX + SI - 0x12)] = Alu8.Add(UInt8[DS, (ushort)(BX + SI - 0x12)], DH);
    CheckExternalEvents(cs15, 0x4ED3);
    // OUT DX,AL (2000_4ED2 / 0x24ED2)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x4ED4);
    // INC SP (2000_4ED3 / 0x24ED3)
    SP++;
    CheckExternalEvents(cs15, 0x4ED5);
    // INC SP (2000_4ED4 / 0x24ED4)
    SP++;
    CheckExternalEvents(cs15, 0x4ED6);
    // INC SP (2000_4ED5 / 0x24ED5)
    SP++;
    CheckExternalEvents(cs15, 0x4ED7);
    // INC SP (2000_4ED6 / 0x24ED6)
    SP++;
    CheckExternalEvents(cs15, 0x4ED8);
    // INC SP (2000_4ED7 / 0x24ED7)
    SP++;
    CheckExternalEvents(cs15, 0x4ED9);
    // INC SP (2000_4ED8 / 0x24ED8)
    SP++;
    CheckExternalEvents(cs15, 0x4EDA);
    // INC SP (2000_4ED9 / 0x24ED9)
    SP++;
    CheckExternalEvents(cs15, 0x4EDB);
    // INC SP (2000_4EDA / 0x24EDA)
    SP++;
    CheckExternalEvents(cs15, 0x4EDC);
    // INC SP (2000_4EDB / 0x24EDB)
    SP++;
    CheckExternalEvents(cs15, 0x4EDD);
    // INC SP (2000_4EDC / 0x24EDC)
    SP++;
    CheckExternalEvents(cs15, 0x4EDE);
    // INC SP (2000_4EDD / 0x24EDD)
    SP++;
    CheckExternalEvents(cs15, 0x4EDF);
    // INC SP (2000_4EDE / 0x24EDE)
    SP++;
    CheckExternalEvents(cs15, 0x4EE0);
    // INC SP (2000_4EDF / 0x24EDF)
    SP++;
    CheckExternalEvents(cs15, 0x4EE1);
    // INC SP (2000_4EE0 / 0x24EE0)
    SP++;
    CheckExternalEvents(cs15, 0x4EE2);
    // INC SP (2000_4EE1 / 0x24EE1)
    SP++;
    CheckExternalEvents(cs15, 0x4EE3);
    // INC SP (2000_4EE2 / 0x24EE2)
    SP++;
    CheckExternalEvents(cs15, 0x4EE4);
    // INC AX (2000_4EE3 / 0x24EE3)
    AX++;
    CheckExternalEvents(cs15, 0x4EE6);
    // ADD DH,CH (2000_4EE4 / 0x24EE4)
    // DH += CH;
    DH = Alu8.Add(DH, CH);
    CheckExternalEvents(cs15, 0x4EE7);
    // OUT DX,AL (2000_4EE6 / 0x24EE6)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x4EEA);
    // ADD byte ptr [BX + SI + -0x12],DH (2000_4EE7 / 0x24EE7)
    // UInt8[DS, (ushort)(BX + SI - 0x12)] += DH;
    UInt8[DS, (ushort)(BX + SI - 0x12)] = Alu8.Add(UInt8[DS, (ushort)(BX + SI - 0x12)], DH);
    CheckExternalEvents(cs15, 0x4EEB);
    // OUT DX,AL (2000_4EEA / 0x24EEA)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x4EEC);
    // XCHG AX,SI (2000_4EEB / 0x24EEB)
    (SI, AX) = (AX, SI);
    CheckExternalEvents(cs15, 0x4EF0);
    // DEC byte ptr [BX + SI + 0x800c] (2000_4EEC / 0x24EEC)
    UInt8[DS, (ushort)(BX + SI + 0x800C)]--;
    label_2000_4EF0_24EF0:
    CheckExternalEvents(cs15, 0x4EF4);
    // DEC word ptr [0xe0ee] (2000_4EF0 / 0x24EF0)
    UInt16[DS, 0xE0EE] = Alu16.Dec(UInt16[DS, 0xE0EE]);
    CheckExternalEvents(cs15, 0x4EF6);
    // OUTSB DX,SI (2000_4EF4 / 0x24EF4)
    Cpu.Out8(DX, UInt8[DS, (ushort)(SI)]);
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs15, 0x4EF7);
    // OUT DX,AL (2000_4EF6 / 0x24EF6)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x4EF9);
    // LOOPZ 0x2000:4f11 (2000_4EF7 / 0x24EF7)
    if(--CX != 0 && ZeroFlag) {
      throw FailAsUntested("Would have been a goto but label label_2000_4F11_24F11 does not exist because no instruction was found there that belongs to a function.");
    }
    CheckExternalEvents(cs15, 0x4EFA);
    // XCHG AX,CX (2000_4EF9 / 0x24EF9)
    (CX, AX) = (AX, CX);
    CheckExternalEvents(cs15, 0x4EFC);
    // MOV DH,BH (2000_4EFA / 0x24EFA)
    DH = BH;
    CheckExternalEvents(cs15, 0x4EFE);
    // JA 0x2000:4f00 (2000_4EFC / 0x24EFC)
    if(!CarryFlag && !ZeroFlag) {
      goto label_2000_4F00_24F00;
    }
    CheckExternalEvents(cs15, 0x4F00);
    // JS 0x2000:4e81 (2000_4EFE / 0x24EFE)
    if(SignFlag) {
      throw FailAsUntested("Would have been a goto but label label_2000_4E81_24E81 does not exist because no instruction was found there that belongs to a function.");
    }
    label_2000_4F00_24F00:
    CheckExternalEvents(cs15, 0x4F01);
    // IN AL,DX (2000_4F00 / 0x24F00)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs15, 0x4F03);
    // ADD byte ptr [BX + DI],AL (2000_4F01 / 0x24F01)
    UInt8[DS, (ushort)(BX + DI)] += AL;
    CheckExternalEvents(cs15, 0x4F05);
    // IDIV SI (2000_4F03 / 0x24F03)
    int op1Idiv2000_4F03 = (int)(DX << 16 | AX);
    short op2Idiv2000_4F03 = (short)SI;
    short? resIdiv2000_4F03 = Alu16.Idiv(op1Idiv2000_4F03, op2Idiv2000_4F03);
    if(resIdiv2000_4F03 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = (ushort)resIdiv2000_4F03.Value;
    DX = (ushort)(op1Idiv2000_4F03 % op2Idiv2000_4F03);
    CheckExternalEvents(cs15, 0x4F07);
    // JA 0x2000:4f13 (2000_4F05 / 0x24F05)
    if(!CarryFlag && !ZeroFlag) {
      throw FailAsUntested("Would have been a goto but label label_2000_4F13_24F13 does not exist because no instruction was found there that belongs to a function.");
    }
    CheckExternalEvents(cs15, 0x4F09);
    // MOV byte ptr [BX + DI],BL (2000_4F07 / 0x24F07)
    UInt8[DS, (ushort)(BX + DI)] = BL;
    CheckExternalEvents(cs15, 0x4F0A);
    // CWD  (2000_4F09 / 0x24F09)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs15, 0x4F0B);
    // OUTSB DX,SI (2000_4F0A / 0x24F0A)
    Cpu.Out8(DX, UInt8[DS, (ushort)(SI)]);
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs15, 0x4F0C);
    // OUT DX,AL (2000_4F0B / 0x24F0B)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x4F0E);
    // OUT 0x66,AL (2000_4F0C / 0x24F0C)
    Cpu.Out8(0x66, AL);
    CheckExternalEvents(cs15, 0x4F0F);
    // PUSH CS (2000_4F0E / 0x24F0E)
    Stack.Push16(cs15);
    CheckExternalEvents(cs15, 0x4F10);
    // OUT DX,AL (2000_4F0F / 0x24F0F)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x4F12);
    // LOOPNZ 0x2000:4f76 (2000_4F10 / 0x24F10)
    if(--CX != 0 && !ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_2000_4F21_24F21, 0x24F76 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs15, 0x4F13);
    // OUTSB DX,SI (2000_4F12 / 0x24F12)
    Cpu.Out8(DX, UInt8[DS, (ushort)(SI)]);
    SI = (ushort)(SI + Direction8);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action split_2000_4F21_24F21(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_2000_4F21_24F21:
    CheckExternalEvents(cs15, 0x4F22);
    // PUSH BP (2000_4F21 / 0x24F21)
    Stack.Push16(BP);
    CheckExternalEvents(cs15, 0x4F23);
    // PUSH BP (2000_4F22 / 0x24F22)
    Stack.Push16(BP);
    CheckExternalEvents(cs15, 0x4F24);
    // STI  (2000_4F23 / 0x24F23)
    InterruptFlag = true;
    CheckExternalEvents(cs15, 0x4F27);
    // MOV DI,0x5b95 (2000_4F24 / 0x24F24)
    DI = 0x5B95;
    CheckExternalEvents(cs15, 0x4F29);
    // PUSH BP (2000_4F27 / 0x24F27)
    Stack.Push16(BP);
    CheckExternalEvents(cs15, 0x4F2B);
    // AND AH,byte ptr [BP + SI] (2000_4F29 / 0x24F29)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F2D);
    // AND AH,byte ptr [BP + SI] (2000_4F2B / 0x24F2B)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F2F);
    // AND AH,byte ptr [BP + SI] (2000_4F2D / 0x24F2D)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F31);
    // SUB AH,byte ptr [BP + SI] (2000_4F2F / 0x24F2F)
    AH -= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F33);
    // AND AH,byte ptr [BP + SI] (2000_4F31 / 0x24F31)
    // AH &= UInt8[SS, (ushort)(BP + SI)];
    AH = Alu8.And(AH, UInt8[SS, (ushort)(BP + SI)]);
    CheckExternalEvents(cs15, 0x4F35);
    // XCHG DI,SI (2000_4F33 / 0x24F33)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4F37);
    // XCHG DI,SI (2000_4F35 / 0x24F35)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4F39);
    // XCHG DI,SI (2000_4F37 / 0x24F37)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4F3B);
    // XCHG DI,SI (2000_4F39 / 0x24F39)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4F3D);
    // XCHG DI,SI (2000_4F3B / 0x24F3B)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4F3F);
    // XCHG DI,SI (2000_4F3D / 0x24F3D)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4F41);
    // XCHG DI,SI (2000_4F3F / 0x24F3F)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4F43);
    // XCHG DI,SI (2000_4F41 / 0x24F41)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4F45);
    // XCHG DI,SI (2000_4F43 / 0x24F43)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4F47);
    // XCHG DI,SI (2000_4F45 / 0x24F45)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4F49);
    // CMP DI,DI (2000_4F47 / 0x24F47)
    Alu16.Sub(DI, DI);
    CheckExternalEvents(cs15, 0x4F4C);
    // OR byte ptr [BX + 0x22],BH (2000_4F49 / 0x24F49)
    UInt8[DS, (ushort)(BX + 0x22)] |= BH;
    CheckExternalEvents(cs15, 0x4F4E);
    // SUB AH,byte ptr [BP + SI] (2000_4F4C / 0x24F4C)
    AH -= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F50);
    // AND CH,byte ptr [BP + SI] (2000_4F4E / 0x24F4E)
    CH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F52);
    // AND AH,byte ptr [BP + SI] (2000_4F50 / 0x24F50)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F54);
    // AND AH,byte ptr [BP + SI] (2000_4F52 / 0x24F52)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F56);
    // AND CH,byte ptr [BP + SI] (2000_4F54 / 0x24F54)
    CH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F58);
    // AND AL,byte ptr [BX] (2000_4F56 / 0x24F56)
    // AL &= UInt8[DS, (ushort)(BX)];
    AL = Alu8.And(AL, UInt8[DS, (ushort)(BX)]);
    CheckExternalEvents(cs15, 0x4F5C);
    // MOV byte ptr [BX + SI + 0xa207],CL (2000_4F58 / 0x24F58)
    UInt8[DS, (ushort)(BX + SI + 0xA207)] = CL;
    CheckExternalEvents(cs15, 0x4F5D);
    // DAS  (2000_4F5C / 0x24F5C)
    new Instructions8(Cpu.State, Cpu, Memory, new(Memory, Cpu, Cpu.State)).Das();
    label_2000_4F5D_24F5D:
    CheckExternalEvents(cs15, 0x4F5F);
    // AND CH,byte ptr [BX] (2000_4F5D / 0x24F5D)
    CH &= UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs15, 0x4F61);
    // AND AH,byte ptr [BP + SI] (2000_4F5F / 0x24F5F)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F65);
    // AND AH,byte ptr [BP + SI + 0x2aa2] (2000_4F61 / 0x24F61)
    AH &= UInt8[SS, (ushort)(BP + SI + 0x2AA2)];
    CheckExternalEvents(cs15, 0x4F67);
    // AND AH,byte ptr [BP + SI] (2000_4F65 / 0x24F65)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F69);
    // AND AH,byte ptr [BP + SI] (2000_4F67 / 0x24F67)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4F6D);
    // AND AH,byte ptr [BP + SI + 0x2822] (2000_4F69 / 0x24F69)
    // AH &= UInt8[SS, (ushort)(BP + SI + 0x2822)];
    AH = Alu8.And(AH, UInt8[SS, (ushort)(BP + SI + 0x2822)]);
    CheckExternalEvents(cs15, 0x4F6F);
    // JO 0x2000:4f5d (2000_4F6D / 0x24F6D)
    if(OverflowFlag) {
      goto label_2000_4F5D_24F5D;
    }
    CheckExternalEvents(cs15, 0x4F71);
    // LOOPNZ 0x2000:4f78 (2000_4F6F / 0x24F6F)
    if(--CX != 0 && !ZeroFlag) {
      goto label_2000_4F78_24F78;
    }
    CheckExternalEvents(cs15, 0x4F72);
    // PUSH CS (2000_4F71 / 0x24F71)
    Stack.Push16(cs15);
    CheckExternalEvents(cs15, 0x4F73);
    // OUT DX,AL (2000_4F72 / 0x24F72)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x4F74);
    // INC AX (2000_4F73 / 0x24F73)
    AX++;
    CheckExternalEvents(cs15, 0x4F76);
    // ADD byte ptr [BX + SI],AL (2000_4F74 / 0x24F74)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    label_2000_4F76_24F76:
    CheckExternalEvents(cs15, 0x4F78);
    // ADD byte ptr [BX + SI],AL (2000_4F76 / 0x24F76)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    label_2000_4F78_24F78:
    CheckExternalEvents(cs15, 0x4F7A);
    // ADD byte ptr [BX + SI],AL (2000_4F78 / 0x24F78)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0x4F7C);
    // ADD byte ptr [BX + SI],AL (2000_4F7A / 0x24F7A)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0x4F7E);
    // ADD byte ptr [BX + SI],AL (2000_4F7C / 0x24F7C)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0x4F80);
    // ADD byte ptr [BX + SI],AL (2000_4F7E / 0x24F7E)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0x4F82);
    // ADD byte ptr [BX + SI],AL (2000_4F80 / 0x24F80)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0x4F84);
    // ADD byte ptr [SI],AL (2000_4F82 / 0x24F82)
    // UInt8[DS, (ushort)(SI)] += AL;
    UInt8[DS, (ushort)(SI)] = Alu8.Add(UInt8[DS, (ushort)(SI)], AL);
    CheckExternalEvents(cs15, 0x4F85);
    // POP ES (2000_4F84 / 0x24F84)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs15, 0x4F86);
    // PUSH CS (2000_4F85 / 0x24F85)
    Stack.Push16(cs15);
    CheckExternalEvents(cs15, 0x4F87);
    // OUT DX,AL (2000_4F86 / 0x24F86)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x4F89);
    // LOOPNZ 0x2000:4f90 (2000_4F87 / 0x24F87)
    if(--CX != 0 && !ZeroFlag) {
      goto label_2000_4F90_24F90;
    }
    CheckExternalEvents(cs15, 0x4F8A);
    // PUSH CS (2000_4F89 / 0x24F89)
    Stack.Push16(cs15);
    CheckExternalEvents(cs15, 0x4F8B);
    // OUT DX,AL (2000_4F8A / 0x24F8A)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x4F8D);
    // ADD word ptr [BX],CX (2000_4F8B / 0x24F8B)
    // UInt16[DS, (ushort)(BX)] += CX;
    UInt16[DS, (ushort)(BX)] = Alu16.Add(UInt16[DS, (ushort)(BX)], CX);
    CheckExternalEvents(cs15, 0x4F8E);
    // STI  (2000_4F8D / 0x24F8D)
    InterruptFlag = true;
    CheckExternalEvents(cs15, 0x4F8F);
    // CWD  (2000_4F8E / 0x24F8E)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs15, 0x4F90);
    // POP ES (2000_4F8F / 0x24F8F)
    ES = Stack.Pop16();;
    label_2000_4F90_24F90:
    CheckExternalEvents(cs15, 0x4F91);
    // SAHF  (2000_4F90 / 0x24F90)
    FlagRegister16 = AH;
    CheckExternalEvents(cs15, 0x4F93);
    // JA 0x2000:4f21 (2000_4F91 / 0x24F91)
    if(!CarryFlag && !ZeroFlag) {
      goto label_2000_4F21_24F21;
    }
    CheckExternalEvents(cs15, 0x4F94);
    // OUT DX,AL (2000_4F93 / 0x24F93)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x4F97);
    // CALL 0x2000:d00e (2000_4F94 / 0x24F94)
    NearCall(cs15, 0x4F97, ghidra_guess_2000_D00E_2D00E);
    CheckExternalEvents(cs15, 0x4F98);
    // CLD  (2000_4F97 / 0x24F97)
    DirectionFlag = false;
    CheckExternalEvents(cs15, 0x4F9A);
    // ADD byte ptr [BP + SI],AL (2000_4F98 / 0x24F98)
    UInt8[SS, (ushort)(BP + SI)] += AL;
    CheckExternalEvents(cs15, 0x4F9C);
    // ADD word ptr [BX + SI],BX (2000_4F9A / 0x24F9A)
    // UInt16[DS, (ushort)(BX + SI)] += BX;
    UInt16[DS, (ushort)(BX + SI)] = Alu16.Add(UInt16[DS, (ushort)(BX + SI)], BX);
    CheckExternalEvents(cs15, 0x4F9D);
    // CLD  (2000_4F9C / 0x24F9C)
    DirectionFlag = false;
    CheckExternalEvents(cs15, 0x4F9E);
    // CWD  (2000_4F9D / 0x24F9D)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs15, 0x4FA2);
    // ADD BL,byte ptr [BX + SI + 0xec81] (2000_4F9E / 0x24F9E)
    BL += UInt8[DS, (ushort)(BX + SI + 0xEC81)];
    CheckExternalEvents(cs15, 0x4FA4);
    // ADD byte ptr [BX + DI],AL (2000_4FA2 / 0x24FA2)
    // UInt8[DS, (ushort)(BX + DI)] += AL;
    UInt8[DS, (ushort)(BX + DI)] = Alu8.Add(UInt8[DS, (ushort)(BX + DI)], AL);
    CheckExternalEvents(cs15, 0x4FA5);
    // STC  (2000_4FA4 / 0x24FA4)
    CarryFlag = true;
    CheckExternalEvents(cs15, 0x4FA6);
    // CLD  (2000_4FA5 / 0x24FA5)
    DirectionFlag = false;
    CheckExternalEvents(cs15, 0x4FA7);
    // CWD  (2000_4FA6 / 0x24FA6)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs15, 0x4FA8);
    // POP ES (2000_4FA7 / 0x24FA7)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs15, 0x4FA9);
    // XCHG AX,CX (2000_4FA8 / 0x24FA8)
    (CX, AX) = (AX, CX);
    CheckExternalEvents(cs15, 0x4FAA);
    // POP SS (2000_4FA9 / 0x24FA9)
    SS = Stack.Pop16();;
    CheckExternalEvents(cs15, 0x4FAC);
    // MOV GS,SI (2000_4FAA / 0x24FAA)
    GS = SI;
    CheckExternalEvents(cs15, 0x4FAF);
    // CALL 0x2000:d026 (2000_4FAC / 0x24FAC)
    NearCall(cs15, 0x4FAF, ghidra_guess_2000_D026_2D026);
    CheckExternalEvents(cs15, 0x4FB0);
    // CLD  (2000_4FAF / 0x24FAF)
    DirectionFlag = false;
    CheckExternalEvents(cs15, 0x4FB2);
    // ADD byte ptr [BP + SI],AL (2000_4FB0 / 0x24FB0)
    UInt8[SS, (ushort)(BP + SI)] += AL;
    CheckExternalEvents(cs15, 0x4FB4);
    // ADD word ptr [BX + SI],BX (2000_4FB2 / 0x24FB2)
    // UInt16[DS, (ushort)(BX + SI)] += BX;
    UInt16[DS, (ushort)(BX + SI)] = Alu16.Add(UInt16[DS, (ushort)(BX + SI)], BX);
    CheckExternalEvents(cs15, 0x4FB5);
    // CLD  (2000_4FB4 / 0x24FB4)
    DirectionFlag = false;
    CheckExternalEvents(cs15, 0x4FB6);
    // CWD  (2000_4FB5 / 0x24FB5)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs15, 0x4FBA);
    // ADD BL,byte ptr [BX + SI + 0xec81] (2000_4FB6 / 0x24FB6)
    BL += UInt8[DS, (ushort)(BX + SI + 0xEC81)];
    CheckExternalEvents(cs15, 0x4FBC);
    // ADD byte ptr [BX + DI],AL (2000_4FBA / 0x24FBA)
    // UInt8[DS, (ushort)(BX + DI)] += AL;
    UInt8[DS, (ushort)(BX + DI)] = Alu8.Add(UInt8[DS, (ushort)(BX + DI)], AL);
    CheckExternalEvents(cs15, 0x4FBD);
    // STC  (2000_4FBC / 0x24FBC)
    CarryFlag = true;
    CheckExternalEvents(cs15, 0x4FBE);
    // CLD  (2000_4FBD / 0x24FBD)
    DirectionFlag = false;
    CheckExternalEvents(cs15, 0x4FBF);
    // CWD  (2000_4FBE / 0x24FBE)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs15, 0x4FC0);
    // PUSH BP (2000_4FBF / 0x24FBF)
    Stack.Push16(BP);
    CheckExternalEvents(cs15, 0x4FC1);
    // PUSH BP (2000_4FC0 / 0x24FC0)
    Stack.Push16(BP);
    CheckExternalEvents(cs15, 0x4FC2);
    // XCHG AX,BP (2000_4FC1 / 0x24FC1)
    (BP, AX) = (AX, BP);
    CheckExternalEvents(cs15, 0x4FC3);
    // PUSH BP (2000_4FC2 / 0x24FC2)
    Stack.Push16(BP);
    CheckExternalEvents(cs15, 0x4FC4);
    // WAIT  (2000_4FC3 / 0x24FC3)
    throw FailAsUntested("Unimplemented Instruction!");
    CheckExternalEvents(cs15, 0x4FC7);
    // MOV DI,0x59b9 (2000_4FC4 / 0x24FC4)
    DI = 0x59B9;
    CheckExternalEvents(cs15, 0x4FC8);
    // POP BX (2000_4FC7 / 0x24FC7)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs15, 0x4FCB);
    // MOV DI,0x2252 (2000_4FC8 / 0x24FC8)
    DI = 0x2252;
    CheckExternalEvents(cs15, 0x4FCD);
    // AND AH,byte ptr [BP + SI] (2000_4FCB / 0x24FCB)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4FCF);
    // AND AH,byte ptr [BP + SI] (2000_4FCD / 0x24FCD)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4FD1);
    // AND AH,byte ptr [BP + SI] (2000_4FCF / 0x24FCF)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4FD3);
    // AND AH,byte ptr [BP + SI] (2000_4FD1 / 0x24FD1)
    // AH &= UInt8[SS, (ushort)(BP + SI)];
    AH = Alu8.And(AH, UInt8[SS, (ushort)(BP + SI)]);
    CheckExternalEvents(cs15, 0x4FD5);
    // XCHG DI,SI (2000_4FD3 / 0x24FD3)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4FD7);
    // XCHG DI,SI (2000_4FD5 / 0x24FD5)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4FD9);
    // XCHG DI,SI (2000_4FD7 / 0x24FD7)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4FDB);
    // XCHG DI,SI (2000_4FD9 / 0x24FD9)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4FDD);
    // XCHG DI,SI (2000_4FDB / 0x24FDB)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4FDF);
    // XCHG DI,SI (2000_4FDD / 0x24FDD)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4FE1);
    // XCHG DI,SI (2000_4FDF / 0x24FDF)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4FE3);
    // XCHG DI,SI (2000_4FE1 / 0x24FE1)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4FE5);
    // XCHG DI,SI (2000_4FE3 / 0x24FE3)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4FE7);
    // XCHG DI,SI (2000_4FE5 / 0x24FE5)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs15, 0x4FE9);
    // CMP DI,DI (2000_4FE7 / 0x24FE7)
    Alu16.Sub(DI, DI);
    CheckExternalEvents(cs15, 0x4FED);
    // ADD byte ptr [BX + 0x2222],AL (2000_4FE9 / 0x24FE9)
    UInt8[DS, (ushort)(BX + 0x2222)] += AL;
    CheckExternalEvents(cs15, 0x4FEF);
    // AND AH,byte ptr [BP + SI] (2000_4FED / 0x24FED)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4FF1);
    // AND AH,byte ptr [BP + SI] (2000_4FEF / 0x24FEF)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4FF3);
    // AND AH,byte ptr [BP + SI] (2000_4FF1 / 0x24FF1)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4FF5);
    // AND AH,byte ptr [BP + SI] (2000_4FF3 / 0x24FF3)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x4FF7);
    // AND AH,byte ptr [BP + SI] (2000_4FF5 / 0x24FF5)
    // AH &= UInt8[SS, (ushort)(BP + SI)];
    AH = Alu8.And(AH, UInt8[SS, (ushort)(BP + SI)]);
    CheckExternalEvents(cs15, 0x4FF8);
    // POP ES (2000_4FF7 / 0x24FF7)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs15, 0x4FFC);
    // MOV byte ptr [BX + SI + 0x2207],CL (2000_4FF8 / 0x24FF8)
    UInt8[DS, (ushort)(BX + SI + 0x2207)] = CL;
    CheckExternalEvents(cs15, 0x4FFE);
    // AND DH,DL (2000_4FFC / 0x24FFC)
    DH &= DL;
    CheckExternalEvents(cs15, 0x5000);
    // AND DH,DL (2000_4FFE / 0x24FFE)
    DH &= DL;
    CheckExternalEvents(cs15, 0x5002);
    // AND AH,byte ptr [BP + SI] (2000_5000 / 0x25000)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x5004);
    // AND AH,byte ptr [BP + SI] (2000_5002 / 0x25002)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x5006);
    // AND AH,byte ptr [BP + SI] (2000_5004 / 0x25004)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x5008);
    // AND AH,byte ptr [BP + SI] (2000_5006 / 0x25006)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x500A);
    // AND AH,byte ptr [BP + SI] (2000_5008 / 0x25008)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x500C);
    // AND AH,byte ptr [BP + SI] (2000_500A / 0x2500A)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x5010);
    // AND AL,byte ptr [BX + 0xee0e] (2000_500C / 0x2500C)
    AL &= UInt8[DS, (ushort)(BX + 0xEE0E)];
    CheckExternalEvents(cs15, 0x5013);
    // ADD byte ptr [BX + SI + -0x12],DH (2000_5010 / 0x25010)
    UInt8[DS, (ushort)(BX + SI - 0x12)] += DH;
    CheckExternalEvents(cs15, 0x5015);
    // ADD AL,0x6 (2000_5013 / 0x25013)
    AL += 0x6;
    CheckExternalEvents(cs15, 0x5017);
    // ADD AL,0x40 (2000_5015 / 0x25015)
    AL += 0x40;
    CheckExternalEvents(cs15, 0x501A);
    // ADD AX,0x500 (2000_5017 / 0x25017)
    AX += 0x500;
    CheckExternalEvents(cs15, 0x501C);
    // ADD byte ptr [BX + SI],AL (2000_501A / 0x2501A)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu8.Add(UInt8[DS, (ushort)(BX + SI)], AL);
    CheckExternalEvents(cs15, 0x501D);
    // CWD  (2000_501C / 0x2501C)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs15, 0x5020);
    // OR word ptr [BX + SI + 0x0],DX (2000_501D / 0x2501D)
    UInt16[DS, (ushort)(BX + SI)] |= DX;
    CheckExternalEvents(cs15, 0x5022);
    // ADD byte ptr [BX + SI],AL (2000_5020 / 0x25020)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0x5026);
    // ADD byte ptr [BX + SI + 0x70],AL (2000_5022 / 0x25022)
    // UInt8[DS, (ushort)(BX + SI + 0x70)] += AL;
    UInt8[DS, (ushort)(BX + SI + 0x70)] = Alu8.Add(UInt8[DS, (ushort)(BX + SI + 0x70)], AL);
    CheckExternalEvents(cs15, 0x5027);
    // OUT DX,AL (2000_5026 / 0x25026)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x5028);
    // OUT DX,AL (2000_5027 / 0x25027)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x502B);
    // ADD byte ptr [BX + SI + -0x12],DH (2000_5028 / 0x25028)
    // UInt8[DS, (ushort)(BX + SI - 0x12)] += DH;
    UInt8[DS, (ushort)(BX + SI - 0x12)] = Alu8.Add(UInt8[DS, (ushort)(BX + SI - 0x12)], DH);
    CheckExternalEvents(cs15, 0x502D);
    // JA 0x2000:4fad (2000_502B / 0x2502B)
    if(!CarryFlag && !ZeroFlag) {
      throw FailAsUntested("Would have been a goto but label label_2000_4FAD_24FAD does not exist because no instruction was found there that belongs to a function.");
    }
    CheckExternalEvents(cs15, 0x502F);
    // MOV CH,BH (2000_502D / 0x2502D)
    CH = BH;
    CheckExternalEvents(cs15, 0x5031);
    // JA 0x2000:5034 (2000_502F / 0x2502F)
    if(!CarryFlag && !ZeroFlag) {
      throw FailAsUntested("Would have been a goto but label label_2000_5034_25034 does not exist because no instruction was found there that belongs to a function.");
    }
    CheckExternalEvents(cs15, 0x5033);
    // JNO 0x2000:504b (2000_5031 / 0x25031)
    if(!OverflowFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_2000_504B_2504B, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs15, 0x5035);
    // ADC BP,DI (2000_5033 / 0x25033)
    BP = Alu16.Adc(BP, DI);
    CheckExternalEvents(cs15, 0x5036);
    // OUT DX,AL (2000_5035 / 0x25035)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs15, 0x5038);
    // ADD CH,AL (2000_5036 / 0x25036)
    CH += AL;
    CheckExternalEvents(cs15, 0x503C);
    // SUB SP,0x100 (2000_5038 / 0x25038)
    // SP -= 0x100;
    SP = Alu16.Sub(SP, 0x100);
    CheckExternalEvents(cs15, 0x503D);
    // STC  (2000_503C / 0x2503C)
    CarryFlag = true;
    CheckExternalEvents(cs15, 0x503E);
    // CLD  (2000_503D / 0x2503D)
    DirectionFlag = false;
    CheckExternalEvents(cs15, 0x503F);
    // CWD  (2000_503E / 0x2503E)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs15, 0x5040);
    // POP ES (2000_503F / 0x2503F)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs15, 0x5041);
    // XCHG AX,CX (2000_5040 / 0x25040)
    (CX, AX) = (AX, CX);
    CheckExternalEvents(cs15, 0x5042);
    // AAA  (2000_5041 / 0x25041)
    new Instructions8(Cpu.State, Cpu, Memory, new(Memory, Cpu, Cpu.State)).Aaa();
    CheckExternalEvents(cs15, 0x5044);
    // MOV GS,SI (2000_5042 / 0x25042)
    GS = SI;
    CheckExternalEvents(cs15, 0x5047);
    // CALL 0x2000:58be (2000_5044 / 0x25044)
    NearCall(cs15, 0x5047, ghidra_guess_2000_58BE_258BE);
    CheckExternalEvents(cs15, 0x504A);
    // INC byte ptr [BX + 0x4] (2000_5047 / 0x25047)
    UInt8[DS, (ushort)(BX + 0x4)] = Alu8.Inc(UInt8[DS, (ushort)(BX + 0x4)]);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action split_2000_504B_2504B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_2000_504B_2504B:
    CheckExternalEvents(cs15, 0x504E);
    // XCHG word ptr [BX + DI + -0x70],SI (2000_504B / 0x2504B)
    (SI, UInt16[DS, (ushort)(BX + DI - 0x70)]) = (UInt16[DS, (ushort)(BX + DI - 0x70)], SI);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action ghidra_guess_2000_58BE_258BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_2000_58BE_258BE:
    CheckExternalEvents(cs15, 0x58BF);
    // XCHG AX,BP (2000_58BE / 0x258BE)
    (BP, AX) = (AX, BP);
    CheckExternalEvents(cs15, 0x58C0);
    // PUSH BP (2000_58BF / 0x258BF)
    Stack.Push16(BP);
    CheckExternalEvents(cs15, 0x58C2);
    // AND AH,byte ptr [BP + SI] (2000_58C0 / 0x258C0)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x58C4);
    // AND AH,byte ptr [BP + SI] (2000_58C2 / 0x258C2)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x58C6);
    // SUB AH,byte ptr [BP + SI] (2000_58C4 / 0x258C4)
    AH -= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x58C8);
    // AND AH,byte ptr [BP + SI] (2000_58C6 / 0x258C6)
    // AH &= UInt8[SS, (ushort)(BP + SI)];
    AH = Alu8.And(AH, UInt8[SS, (ushort)(BP + SI)]);
    CheckExternalEvents(cs15, 0x58CB);
    // MOV [0x2222],AL (2000_58C8 / 0x258C8)
    UInt8[DS, 0x2222] = AL;
    CheckExternalEvents(cs15, 0x58CD);
    // AND CH,byte ptr [BP + SI] (2000_58CB / 0x258CB)
    CH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x58CF);
    // AND AH,byte ptr [BP + SI] (2000_58CD / 0x258CD)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x58D3);
    // AND AH,byte ptr [BP + SI + 0x2222] (2000_58CF / 0x258CF)
    AH &= UInt8[SS, (ushort)(BP + SI + 0x2222)];
    CheckExternalEvents(cs15, 0x58D5);
    // AND CH,byte ptr [BP + SI] (2000_58D3 / 0x258D3)
    CH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x58D7);
    // AND AH,byte ptr [BP + SI] (2000_58D5 / 0x258D5)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x58DB);
    // AND AH,byte ptr [BP + SI + 0x2222] (2000_58D7 / 0x258D7)
    AH &= UInt8[SS, (ushort)(BP + SI + 0x2222)];
    CheckExternalEvents(cs15, 0x58DD);
    // AND CH,byte ptr [BP + SI] (2000_58DB / 0x258DB)
    CH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x58DF);
    // AND AH,byte ptr [BP + SI] (2000_58DD / 0x258DD)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x58E3);
    // AND AH,byte ptr [BP + SI + 0x2222] (2000_58DF / 0x258DF)
    AH &= UInt8[SS, (ushort)(BP + SI + 0x2222)];
    CheckExternalEvents(cs15, 0x58E5);
    // AND CH,byte ptr [BP + SI] (2000_58E3 / 0x258E3)
    CH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x58E7);
    // AND AH,byte ptr [BP + SI] (2000_58E5 / 0x258E5)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs15, 0x58EB);
    // AND AH,byte ptr [BP + SI + 0x2222] (2000_58E7 / 0x258E7)
    AH &= UInt8[SS, (ushort)(BP + SI + 0x2222)];
    CheckExternalEvents(cs15, 0x58EE);
    // ADD byte ptr [BX + -0x1],BL (2000_58EB / 0x258EB)
    UInt8[DS, (ushort)(BX - 0x1)] += BL;
    CheckExternalEvents(cs15, 0x58F1);
    // ADD AX,0x9000 (2000_58EE / 0x258EE)
    // AX += 0x9000;
    AX = Alu16.Add(AX, 0x9000);
    CheckExternalEvents(cs15, 0x58F5);
    // UD0 EDX,dword ptr [DI + 0x5f] (2000_58F1 / 0x258F1)
    throw FailAsUntested("Unimplemented Instruction!");
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action ghidra_guess_2000_BD61_2BD61(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_2000_BD61_2BD61:
    CheckExternalEvents(cs15, 0xBD64);
    // ROL AL,0xc0 (2000_BD61 / 0x2BD61)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD67);
    // ROL AL,0xc0 (2000_BD64 / 0x2BD64)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD6A);
    // ROL AL,0xc0 (2000_BD67 / 0x2BD67)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD6D);
    // ROL AL,0xc0 (2000_BD6A / 0x2BD6A)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD70);
    // ROL AL,0xc0 (2000_BD6D / 0x2BD6D)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD73);
    // ROL AL,0xc0 (2000_BD70 / 0x2BD70)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD76);
    // ROL AL,0xc0 (2000_BD73 / 0x2BD73)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD79);
    // ROL AL,0xc0 (2000_BD76 / 0x2BD76)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD7C);
    // ROL AL,0xc0 (2000_BD79 / 0x2BD79)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD7F);
    // ROL AL,0xc0 (2000_BD7C / 0x2BD7C)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD82);
    // ROL AL,0xc0 (2000_BD7F / 0x2BD7F)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD85);
    // ROL AL,0xc0 (2000_BD82 / 0x2BD82)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD88);
    // ROL AL,0xc0 (2000_BD85 / 0x2BD85)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD8B);
    // ROL AL,0xc0 (2000_BD88 / 0x2BD88)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD8E);
    // ROL AL,0xc0 (2000_BD8B / 0x2BD8B)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD91);
    // ROL AL,0xc0 (2000_BD8E / 0x2BD8E)
    AL = Alu8.Rol(AL, 0xC0);
    CheckExternalEvents(cs15, 0xBD94);
    // ROL AL,0xc0 (2000_BD91 / 0x2BD91)
    AL = Alu8.Rol(AL, 0xC0);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action ghidra_guess_2000_D00E_2D00E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_2000_D00E_2D00E:
    CheckExternalEvents(cs15, 0xD010);
    // ADD byte ptr [BX + SI],AL (2000_D00E / 0x2D00E)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD012);
    // ADD byte ptr [BX + SI],AL (2000_D010 / 0x2D010)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD014);
    // ADD byte ptr [BX + SI],AL (2000_D012 / 0x2D012)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD016);
    // ADD byte ptr [BX + SI],AL (2000_D014 / 0x2D014)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD018);
    // ADD byte ptr [BX + SI],AL (2000_D016 / 0x2D016)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD01A);
    // ADD byte ptr [BX + SI],AL (2000_D018 / 0x2D018)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD01C);
    // ADD byte ptr [BX + SI],AL (2000_D01A / 0x2D01A)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD01E);
    // ADD byte ptr [BX + SI],AL (2000_D01C / 0x2D01C)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD020);
    // ADD byte ptr [BX + SI],AL (2000_D01E / 0x2D01E)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD022);
    // ADD byte ptr [BX + SI],AL (2000_D020 / 0x2D020)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD024);
    // ADD byte ptr [BX + SI],AL (2000_D022 / 0x2D022)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD026);
    // ADD byte ptr [BX + SI],AL (2000_D024 / 0x2D024)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    // Function call generated as ASM continues to next function entry point without return
    return ghidra_guess_2000_D026_2D026(0);
  }
  
  public virtual Action ghidra_guess_2000_D026_2D026(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_2000_D026_2D026:
    CheckExternalEvents(cs15, 0xD028);
    // ADD byte ptr [BX + SI],AL (2000_D026 / 0x2D026)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD02A);
    // ADD byte ptr [BX + SI],AL (2000_D028 / 0x2D028)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD02C);
    // ADD byte ptr [BX + SI],AL (2000_D02A / 0x2D02A)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD02E);
    // ADD byte ptr [BX + SI],AL (2000_D02C / 0x2D02C)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs15, 0xD030);
    // ADD byte ptr [BX + SI],AL (2000_D02E / 0x2D02E)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu8.Add(UInt8[DS, (ushort)(BX + SI)], AL);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action provided_interrupt_handler_0x1F_C000_0440_C0440(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_C000_0440_C0440:
    CheckExternalEvents(cs17, 0x442);
    // ADD byte ptr [BX + SI],AL (C000_0440 / 0xC0440)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu8.Add(UInt8[DS, (ushort)(BX + SI)], AL);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action provided_interrupt_handler_0x43_C000_1640_C1640(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_C000_1640_C1640:
    CheckExternalEvents(cs17, 0x1642);
    // ADD byte ptr [BX + SI],AL (C000_1640 / 0xC1640)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu8.Add(UInt8[DS, (ushort)(BX + SI)], AL);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action provided_interrupt_handler_10_F000_0000_F0000(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0000_F0000:
    CheckExternalEvents(cs18, 0x2);
    // INT 0x10 (F000_0000 / 0xF0000)
    Interrupt(0x10);
    CheckExternalEvents(cs18, 0x3);
    // NOP  (F000_0002 / 0xF0002)
    
    CheckExternalEvents(cs18, 0x4);
    // NOP  (F000_0003 / 0xF0003)
    
    CheckExternalEvents(cs18, 0x5);
    // IRET  (F000_0004 / 0xF0004)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_1C_F000_0005_F0005(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0005_F0005:
    CheckExternalEvents(cs18, 0x6);
    // IRET  (F000_0005 / 0xF0005)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_8_F000_0006_F0006(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0006_F0006:
    CheckExternalEvents(cs18, 0x8);
    // INT 0x8 (F000_0006 / 0xF0006)
    Interrupt(0x8);
    CheckExternalEvents(cs18, 0x9);
    // NOP  (F000_0008 / 0xF0008)
    
    CheckExternalEvents(cs18, 0xA);
    // NOP  (F000_0009 / 0xF0009)
    
    CheckExternalEvents(cs18, 0xC);
    // INT 0x1c (F000_000A / 0xF000A)
    Interrupt(0x1c);
    CheckExternalEvents(cs18, 0xE);
    // INT 0xff (F000_000C / 0xF000C)
    Interrupt(0xff);
    CheckExternalEvents(cs18, 0xF);
    // NOP  (F000_000E / 0xF000E)
    
    CheckExternalEvents(cs18, 0x10);
    // NOP  (F000_000F / 0xF000F)
    
    CheckExternalEvents(cs18, 0x11);
    // IRET  (F000_0010 / 0xF0010)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_9_F000_0011_F0011(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0011_F0011:
    CheckExternalEvents(cs18, 0x13);
    // INT 0x9 (F000_0011 / 0xF0011)
    Interrupt(0x9);
    CheckExternalEvents(cs18, 0x14);
    // NOP  (F000_0013 / 0xF0013)
    
    CheckExternalEvents(cs18, 0x15);
    // NOP  (F000_0014 / 0xF0014)
    
    CheckExternalEvents(cs18, 0x16);
    // IRET  (F000_0015 / 0xF0015)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_11_F000_0016_F0016(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0016_F0016:
    CheckExternalEvents(cs18, 0x18);
    // INT 0x11 (F000_0016 / 0xF0016)
    Interrupt(0x11);
    CheckExternalEvents(cs18, 0x19);
    // NOP  (F000_0018 / 0xF0018)
    
    CheckExternalEvents(cs18, 0x1A);
    // NOP  (F000_0019 / 0xF0019)
    
    CheckExternalEvents(cs18, 0x1B);
    // IRET  (F000_001A / 0xF001A)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_12_F000_001B_F001B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_001B_F001B:
    CheckExternalEvents(cs18, 0x1D);
    // INT 0x12 (F000_001B / 0xF001B)
    Interrupt(0x12);
    CheckExternalEvents(cs18, 0x1E);
    // NOP  (F000_001D / 0xF001D)
    
    CheckExternalEvents(cs18, 0x1F);
    // NOP  (F000_001E / 0xF001E)
    
    CheckExternalEvents(cs18, 0x20);
    // IRET  (F000_001F / 0xF001F)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_15_F000_0020_F0020(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0020_F0020:
    CheckExternalEvents(cs18, 0x22);
    // INT 0x15 (F000_0020 / 0xF0020)
    Interrupt(0x15);
    CheckExternalEvents(cs18, 0x23);
    // NOP  (F000_0022 / 0xF0022)
    
    CheckExternalEvents(cs18, 0x24);
    // NOP  (F000_0023 / 0xF0023)
    
    CheckExternalEvents(cs18, 0x25);
    // IRET  (F000_0024 / 0xF0024)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_16_F000_0025_F0025(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0025_F0025:
    CheckExternalEvents(cs18, 0x28);
    // CMP AH,0x0 (F000_0025 / 0xF0025)
    Alu8.Sub(AH, 0x0);
    CheckExternalEvents(cs18, 0x2A);
    // JZ 0xf000:002f (F000_0028 / 0xF0028)
    if(ZeroFlag) {
      goto label_F000_002F_F002F;
    }
    CheckExternalEvents(cs18, 0x2C);
    // INT 0x16 (F000_002A / 0xF002A)
    Interrupt(0x16);
    CheckExternalEvents(cs18, 0x2D);
    // NOP  (F000_002C / 0xF002C)
    
    CheckExternalEvents(cs18, 0x2E);
    // NOP  (F000_002D / 0xF002D)
    
    CheckExternalEvents(cs18, 0x2F);
    // IRET  (F000_002E / 0xF002E)
    return InterruptRet();
    label_F000_002F_F002F:
    CheckExternalEvents(cs18, 0x31);
    // INT 0xff (F000_002F / 0xF002F)
    Interrupt(0xff);
    CheckExternalEvents(cs18, 0x32);
    // NOP  (F000_0031 / 0xF0031)
    
    CheckExternalEvents(cs18, 0x33);
    // NOP  (F000_0032 / 0xF0032)
    
    CheckExternalEvents(cs18, 0x35);
    // JNZ 0xf000:0039 (F000_0033 / 0xF0033)
    if(!ZeroFlag) {
      goto label_F000_0039_F0039;
    }
    CheckExternalEvents(cs18, 0x37);
    // INT 0x9 (F000_0035 / 0xF0035)
    Interrupt(0x9);
    CheckExternalEvents(cs18, 0x39);
    // JMP 0xf000:002f (F000_0037 / 0xF0037)
    goto label_F000_002F_F002F;
    label_F000_0039_F0039:
    CheckExternalEvents(cs18, 0x3B);
    // INT 0xff (F000_0039 / 0xF0039)
    Interrupt(0xff);
    CheckExternalEvents(cs18, 0x3C);
    // NOP  (F000_003B / 0xF003B)
    
    CheckExternalEvents(cs18, 0x3D);
    // NOP  (F000_003C / 0xF003C)
    
    CheckExternalEvents(cs18, 0x3E);
    // IRET  (F000_003D / 0xF003D)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_1A_F000_003E_F003E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_003E_F003E:
    CheckExternalEvents(cs18, 0x40);
    // INT 0x1a (F000_003E / 0xF003E)
    Interrupt(0x1a);
    CheckExternalEvents(cs18, 0x41);
    // NOP  (F000_0040 / 0xF0040)
    
    CheckExternalEvents(cs18, 0x42);
    // NOP  (F000_0041 / 0xF0041)
    
    CheckExternalEvents(cs18, 0x43);
    // IRET  (F000_0042 / 0xF0042)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_13_F000_0043_F0043(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0043_F0043:
    CheckExternalEvents(cs18, 0x45);
    // INT 0x13 (F000_0043 / 0xF0043)
    Interrupt(0x13);
    CheckExternalEvents(cs18, 0x46);
    // NOP  (F000_0045 / 0xF0045)
    
    CheckExternalEvents(cs18, 0x47);
    // NOP  (F000_0046 / 0xF0046)
    
    CheckExternalEvents(cs18, 0x48);
    // IRET  (F000_0047 / 0xF0047)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_74_F000_0049_F0049(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0049_F0049:
    CheckExternalEvents(cs18, 0x4E);
    // CALLF 0xf000:0095 (F000_0049 / 0xF0049)
    FarCall(cs18, 0x4E, provided_mouse_driver_F000_0095_F0095);
    CheckExternalEvents(cs18, 0x50);
    // INT 0x74 (F000_004E / 0xF004E)
    Interrupt(0x74);
    CheckExternalEvents(cs18, 0x51);
    // NOP  (F000_0050 / 0xF0050)
    
    CheckExternalEvents(cs18, 0x52);
    // NOP  (F000_0051 / 0xF0051)
    
    CheckExternalEvents(cs18, 0x53);
    // IRET  (F000_0052 / 0xF0052)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_B_F000_0053_F0053(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0053_F0053:
    CheckExternalEvents(cs18, 0x55);
    // INT 0xff (F000_0053 / 0xF0053)
    Interrupt(0xff);
    CheckExternalEvents(cs18, 0x56);
    // NOP  (F000_0055 / 0xF0055)
    
    CheckExternalEvents(cs18, 0x57);
    // NOP  (F000_0056 / 0xF0056)
    
    CheckExternalEvents(cs18, 0x58);
    // IRET  (F000_0057 / 0xF0057)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_C_F000_0058_F0058(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0058_F0058:
    CheckExternalEvents(cs18, 0x5A);
    // INT 0xff (F000_0058 / 0xF0058)
    Interrupt(0xff);
    CheckExternalEvents(cs18, 0x5B);
    // NOP  (F000_005A / 0xF005A)
    
    CheckExternalEvents(cs18, 0x5C);
    // NOP  (F000_005B / 0xF005B)
    
    CheckExternalEvents(cs18, 0x5D);
    // IRET  (F000_005C / 0xF005C)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_D_F000_005D_F005D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_005D_F005D:
    CheckExternalEvents(cs18, 0x5F);
    // INT 0xff (F000_005D / 0xF005D)
    Interrupt(0xff);
    CheckExternalEvents(cs18, 0x60);
    // NOP  (F000_005F / 0xF005F)
    
    CheckExternalEvents(cs18, 0x61);
    // NOP  (F000_0060 / 0xF0060)
    
    CheckExternalEvents(cs18, 0x62);
    // IRET  (F000_0061 / 0xF0061)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_F_F000_0062_F0062(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0062_F0062:
    CheckExternalEvents(cs18, 0x64);
    // INT 0xff (F000_0062 / 0xF0062)
    Interrupt(0xff);
    CheckExternalEvents(cs18, 0x65);
    // NOP  (F000_0064 / 0xF0064)
    
    CheckExternalEvents(cs18, 0x66);
    // NOP  (F000_0065 / 0xF0065)
    
    CheckExternalEvents(cs18, 0x67);
    // IRET  (F000_0066 / 0xF0066)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_72_F000_0067_F0067(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0067_F0067:
    CheckExternalEvents(cs18, 0x69);
    // INT 0xff (F000_0067 / 0xF0067)
    Interrupt(0xff);
    CheckExternalEvents(cs18, 0x6A);
    // NOP  (F000_0069 / 0xF0069)
    
    CheckExternalEvents(cs18, 0x6B);
    // NOP  (F000_006A / 0xF006A)
    
    CheckExternalEvents(cs18, 0x6C);
    // IRET  (F000_006B / 0xF006B)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_73_F000_006C_F006C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_006C_F006C:
    CheckExternalEvents(cs18, 0x6E);
    // INT 0xff (F000_006C / 0xF006C)
    Interrupt(0xff);
    CheckExternalEvents(cs18, 0x6F);
    // NOP  (F000_006E / 0xF006E)
    
    CheckExternalEvents(cs18, 0x70);
    // NOP  (F000_006F / 0xF006F)
    
    CheckExternalEvents(cs18, 0x71);
    // IRET  (F000_0070 / 0xF0070)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_20_F000_0071_F0071(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0071_F0071:
    CheckExternalEvents(cs18, 0x73);
    // INT 0x20 (F000_0071 / 0xF0071)
    Interrupt(0x20);
    CheckExternalEvents(cs18, 0x74);
    // NOP  (F000_0073 / 0xF0073)
    
    CheckExternalEvents(cs18, 0x75);
    // NOP  (F000_0074 / 0xF0074)
    
    CheckExternalEvents(cs18, 0x76);
    // IRET  (F000_0075 / 0xF0075)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_21_F000_0076_F0076(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0076_F0076:
    CheckExternalEvents(cs18, 0x78);
    // INT 0x21 (F000_0076 / 0xF0076)
    Interrupt(0x21);
    // Function call generated as ASM continues to next function entry point without return
    return split_F000_0078_F0078(0);
  }
  
  public virtual Action split_F000_0078_F0078(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0078_F0078:
    CheckExternalEvents(cs18, 0x79);
    // NOP  (F000_0078 / 0xF0078)
    
    CheckExternalEvents(cs18, 0x7A);
    // NOP  (F000_0079 / 0xF0079)
    
    CheckExternalEvents(cs18, 0x7B);
    // IRET  (F000_007A / 0xF007A)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_2F_F000_007B_F007B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_007B_F007B:
    CheckExternalEvents(cs18, 0x7D);
    // INT 0x2f (F000_007B / 0xF007B)
    Interrupt(0x2f);
    CheckExternalEvents(cs18, 0x7E);
    // NOP  (F000_007D / 0xF007D)
    
    CheckExternalEvents(cs18, 0x7F);
    // NOP  (F000_007E / 0xF007E)
    
    CheckExternalEvents(cs18, 0x80);
    // IRET  (F000_007F / 0xF007F)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_25_F000_0080_F0080(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0080_F0080:
    CheckExternalEvents(cs18, 0x82);
    // INT 0x25 (F000_0080 / 0xF0080)
    Interrupt(0x25);
    CheckExternalEvents(cs18, 0x83);
    // NOP  (F000_0082 / 0xF0082)
    
    CheckExternalEvents(cs18, 0x84);
    // NOP  (F000_0083 / 0xF0083)
    
    CheckExternalEvents(cs18, 0x85);
    // IRET  (F000_0084 / 0xF0084)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_26_F000_0085_F0085(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0085_F0085:
    CheckExternalEvents(cs18, 0x87);
    // INT 0x26 (F000_0085 / 0xF0085)
    Interrupt(0x26);
    CheckExternalEvents(cs18, 0x88);
    // NOP  (F000_0087 / 0xF0087)
    
    CheckExternalEvents(cs18, 0x89);
    // NOP  (F000_0088 / 0xF0088)
    
    CheckExternalEvents(cs18, 0x8A);
    // IRET  (F000_0089 / 0xF0089)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_28_F000_008A_F008A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_008A_F008A:
    CheckExternalEvents(cs18, 0x8C);
    // INT 0x28 (F000_008A / 0xF008A)
    Interrupt(0x28);
    CheckExternalEvents(cs18, 0x8D);
    // NOP  (F000_008C / 0xF008C)
    
    CheckExternalEvents(cs18, 0x8E);
    // NOP  (F000_008D / 0xF008D)
    
    CheckExternalEvents(cs18, 0x8F);
    // IRET  (F000_008E / 0xF008E)
    return InterruptRet();
  }
  
  public virtual Action provided_interrupt_handler_33_F000_008F_F008F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_008F_F008F:
    CheckExternalEvents(cs18, 0x91);
    // INT 0x33 (F000_008F / 0xF008F)
    Interrupt(0x33);
    CheckExternalEvents(cs18, 0x92);
    // NOP  (F000_0091 / 0xF0091)
    
    CheckExternalEvents(cs18, 0x93);
    // NOP  (F000_0092 / 0xF0092)
    
    CheckExternalEvents(cs18, 0x94);
    // IRET  (F000_0093 / 0xF0093)
    return InterruptRet();
  }
  
  public virtual Action unknown_F000_0094_F0094(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0094_F0094:
    CheckExternalEvents(cs18, 0x95);
    // RETF  (F000_0094 / 0xF0094)
    return FarRet();
  }
  
  public virtual Action provided_mouse_driver_F000_0095_F0095(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F000_0095_F0095:
    CheckExternalEvents(cs18, 0x97);
    // INT 0xff (F000_0095 / 0xF0095)
    Interrupt(0xff);
    CheckExternalEvents(cs18, 0x98);
    // NOP  (F000_0097 / 0xF0097)
    
    CheckExternalEvents(cs18, 0x99);
    // NOP  (F000_0098 / 0xF0098)
    
    CheckExternalEvents(cs18, 0x9E);
    // CALLF 0xf000:0094 (F000_0099 / 0xF0099)
    FarCall(cs18, 0x9E, unknown_F000_0094_F0094);
    CheckExternalEvents(cs18, 0xA0);
    // INT 0xff (F000_009E / 0xF009E)
    Interrupt(0xff);
    CheckExternalEvents(cs18, 0xA1);
    // NOP  (F000_00A0 / 0xF00A0)
    
    CheckExternalEvents(cs18, 0xA2);
    // NOP  (F000_00A1 / 0xF00A1)
    
    CheckExternalEvents(cs18, 0xA3);
    // RETF  (F000_00A2 / 0xF00A2)
    return FarRet();
  }
  
  public virtual Action provided_interrupt_handler_67_F100_0000_F1000(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_F100_0000_F1000:
    CheckExternalEvents(cs19, 0x2);
    // INT 0x67 (F100_0000 / 0xF1000)
    Interrupt(0x67);
    CheckExternalEvents(cs19, 0x3);
    // NOP  (F100_0002 / 0xF1002)
    
    CheckExternalEvents(cs19, 0x4);
    // NOP  (F100_0003 / 0xF1003)
    
    CheckExternalEvents(cs19, 0x5);
    // IRET  (F100_0004 / 0xF1004)
    return InterruptRet();
  }
  
}
