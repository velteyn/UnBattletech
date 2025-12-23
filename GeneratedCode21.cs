using Spice86.Core.Emulator.CPU.InstructionsImpl;

namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_1000_D60E_1D60E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D60E_1D60E:
    CheckExternalEvents(cs7, 0xD60F);
    // PUSH AX (1000_D60E / 0x1D60E)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0xD610);
    // PUSH BX (1000_D60F / 0x1D60F)
    Stack.Push16(BX);
    CheckExternalEvents(cs7, 0xD611);
    // PUSH CX (1000_D610 / 0x1D610)
    Stack.Push16(CX);
    CheckExternalEvents(cs7, 0xD612);
    // PUSH DS (1000_D611 / 0x1D611)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xD613);
    // PUSH ES (1000_D612 / 0x1D612)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xD614);
    // POP DS (1000_D613 / 0x1D613)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD616);
    // MOV CX,DI (1000_D614 / 0x1D614)
    CX = DI;
    CheckExternalEvents(cs7, 0xD618);
    // SUB CX,DX (1000_D616 / 0x1D616)
    // CX -= DX;
    CX = Alu16.Sub(CX, DX);
    CheckExternalEvents(cs7, 0xD61A);
    // JCXZ 0x1000:d62a (1000_D618 / 0x1D618)
    if(CX == 0) {
      goto label_1000_D62A_1D62A;
    }
    CheckExternalEvents(cs7, 0xD61D);
    // MOV BX,word ptr [BP + 0x6] (1000_D61A / 0x1D61A)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xD61F);
    // MOV AH,0x40 (1000_D61D / 0x1D61D)
    AH = 0x40;
    CheckExternalEvents(cs7, 0xD621);
    // INT 0x21 (1000_D61F / 0x1D61F)
    Interrupt(0x21);
    CheckExternalEvents(cs7, 0xD623);
    // JC 0x1000:d631 (1000_D621 / 0x1D621)
    if(CarryFlag) {
      goto label_1000_D631_1D631;
    }
    CheckExternalEvents(cs7, 0xD626);
    // ADD word ptr [BP + -0x2],AX (1000_D623 / 0x1D623)
    // UInt16[SS, (ushort)(BP - 0x2)] += AX;
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x2)], AX);
    CheckExternalEvents(cs7, 0xD628);
    // OR AX,AX (1000_D626 / 0x1D626)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs7, 0xD62A);
    // JZ 0x1000:d631 (1000_D628 / 0x1D628)
    if(ZeroFlag) {
      goto label_1000_D631_1D631;
    }
    label_1000_D62A_1D62A:
    CheckExternalEvents(cs7, 0xD62B);
    // POP DS (1000_D62A / 0x1D62A)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD62C);
    // POP CX (1000_D62B / 0x1D62B)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD62D);
    // POP BX (1000_D62C / 0x1D62C)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD62E);
    // POP AX (1000_D62D / 0x1D62D)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD630);
    // MOV DI,DX (1000_D62E / 0x1D62E)
    DI = DX;
    CheckExternalEvents(cs7, 0xD631);
    // RET  (1000_D630 / 0x1D630)
    return NearRet();
    label_1000_D631_1D631:
    CheckExternalEvents(cs7, 0xD632);
    // POP DS (1000_D631 / 0x1D631)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD635);
    // ADD SP,0x8 (1000_D632 / 0x1D632)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0xD637);
    // JNC 0x1000:d63b (1000_D635 / 0x1D635)
    if(!CarryFlag) {
      goto label_1000_D63B_1D63B;
    }
    CheckExternalEvents(cs7, 0xD639);
    // MOV AH,0x9 (1000_D637 / 0x1D637)
    AH = 0x9;
    CheckExternalEvents(cs7, 0xD63B);
    // JMP 0x1000:d65f (1000_D639 / 0x1D639)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_D659_1D659, 0x1D65F - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D63B_1D63B:
    CheckExternalEvents(cs7, 0xD63E);
    // MOV DS,word ptr [BP + -0x2] (1000_D63B / 0x1D63B)
    DS = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0xD643);
    // TEST byte ptr [BX + 0x5300],0x40 (1000_D63E / 0x1D63E)
    Alu8.And(UInt8[DS, (ushort)(BX + 0x5300)], 0x40);
    CheckExternalEvents(cs7, 0xD645);
    // JZ 0x1000:d653 (1000_D643 / 0x1D643)
    if(ZeroFlag) {
      goto label_1000_D653_1D653;
    }
    CheckExternalEvents(cs7, 0xD648);
    // MOV DS,word ptr [BP + 0xa] (1000_D645 / 0x1D645)
    DS = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0xD64B);
    // MOV BX,word ptr [BP + 0x8] (1000_D648 / 0x1D648)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xD64E);
    // CMP byte ptr [BX],0x1a (1000_D64B / 0x1D64B)
    Alu8.Sub(UInt8[DS, (ushort)(BX)], 0x1A);
    CheckExternalEvents(cs7, 0xD650);
    // JNZ 0x1000:d653 (1000_D64E / 0x1D64E)
    if(!ZeroFlag) {
      goto label_1000_D653_1D653;
    }
    CheckExternalEvents(cs7, 0xD651);
    // CLC  (1000_D650 / 0x1D650)
    CarryFlag = false;
    CheckExternalEvents(cs7, 0xD653);
    // JMP 0x1000:d65f (1000_D651 / 0x1D651)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_D659_1D659, 0x1D65F - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D653_1D653:
    CheckExternalEvents(cs7, 0xD654);
    // STC  (1000_D653 / 0x1D653)
    CarryFlag = true;
    CheckExternalEvents(cs7, 0xD657);
    // MOV AX,0x1c00 (1000_D654 / 0x1D654)
    AX = 0x1C00;
    CheckExternalEvents(cs7, 0xD659);
    // JMP 0x1000:d65f (1000_D657 / 0x1D657)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_D659_1D659, 0x1D65F - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ghidra_guess_1000_D659_1D659(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D659_1D659:
    CheckExternalEvents(cs7, 0xD65C);
    // MOV AX,word ptr [BP + -0x2] (1000_D659 / 0x1D659)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0xD65F);
    // SUB AX,word ptr [BP + -0x4] (1000_D65C / 0x1D65C)
    // AX -= UInt16[SS, (ushort)(BP - 0x4)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x4)]);
    label_1000_D65F_1D65F:
    CheckExternalEvents(cs7, 0xD662);
    // MOV SP,word ptr [BP + -0x8] (1000_D65F / 0x1D65F)
    SP = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0xD663);
    // POP SI (1000_D662 / 0x1D662)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD664);
    // POP DI (1000_D663 / 0x1D663)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD667);
    // MOV DS,word ptr [BP + -0x6] (1000_D664 / 0x1D664)
    DS = UInt16[SS, (ushort)(BP - 0x6)];
    label_1000_D667_1D667:
    CheckExternalEvents(cs7, 0xD66A);
    // JMP 0x1000:d1e5 (1000_D667 / 0x1D667)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ghidra_guess_1000_D66A_1D66A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D66A_1D66A:
    CheckExternalEvents(cs7, 0xD66D);
    // MOV CX,word ptr [BP + 0xc] (1000_D66A / 0x1D66A)
    CX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs7, 0xD66F);
    // OR CX,CX (1000_D66D / 0x1D66D)
    // CX |= CX;
    CX = Alu16.Or(CX, CX);
    CheckExternalEvents(cs7, 0xD671);
    // JNZ 0x1000:d676 (1000_D66F / 0x1D66F)
    if(!ZeroFlag) {
      goto label_1000_D676_1D676;
    }
    CheckExternalEvents(cs7, 0xD673);
    // MOV AX,CX (1000_D671 / 0x1D671)
    AX = CX;
    CheckExternalEvents(cs7, 0xD676);
    // JMP 0x1000:d1e5 (1000_D673 / 0x1D673)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D676_1D676:
    CheckExternalEvents(cs7, 0xD677);
    // PUSH DS (1000_D676 / 0x1D676)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xD67A);
    // LDS DX,[BP + 0x8] (1000_D677 / 0x1D677)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    DS = UInt16[SS, (ushort)(BP + 0x8 + 2)];
    CheckExternalEvents(cs7, 0xD67C);
    // MOV AH,0x40 (1000_D67A / 0x1D67A)
    AH = 0x40;
    CheckExternalEvents(cs7, 0xD67E);
    // INT 0x21 (1000_D67C / 0x1D67C)
    Interrupt(0x21);
    CheckExternalEvents(cs7, 0xD67F);
    // PUSH DS (1000_D67E / 0x1D67E)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xD680);
    // POP ES (1000_D67F / 0x1D67F)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD681);
    // POP DS (1000_D680 / 0x1D680)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD683);
    // JNC 0x1000:d687 (1000_D681 / 0x1D681)
    if(!CarryFlag) {
      goto label_1000_D687_1D687;
    }
    CheckExternalEvents(cs7, 0xD685);
    // MOV AH,0x9 (1000_D683 / 0x1D683)
    AH = 0x9;
    CheckExternalEvents(cs7, 0xD687);
    // JMP 0x1000:d667 (1000_D685 / 0x1D685)
    // JMP target is JMP, inlining.
    CheckExternalEvents(cs7, 0xD66A);
    // JMP 0x1000:d1e5 (1000_D667 / 0x1D667)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D687_1D687:
    CheckExternalEvents(cs7, 0xD689);
    // OR AX,AX (1000_D687 / 0x1D687)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs7, 0xD68B);
    // JNZ 0x1000:d667 (1000_D689 / 0x1D689)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      CheckExternalEvents(cs7, 0xD66A);
      // JMP 0x1000:d1e5 (1000_D667 / 0x1D667)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xD690);
    // TEST byte ptr [BX + 0x5300],0x40 (1000_D68B / 0x1D68B)
    Alu8.And(UInt8[DS, (ushort)(BX + 0x5300)], 0x40);
    CheckExternalEvents(cs7, 0xD692);
    // JZ 0x1000:d69d (1000_D690 / 0x1D690)
    if(ZeroFlag) {
      goto label_1000_D69D_1D69D;
    }
    CheckExternalEvents(cs7, 0xD694);
    // MOV BX,DX (1000_D692 / 0x1D692)
    BX = DX;
    CheckExternalEvents(cs7, 0xD698);
    // CMP byte ptr ES:[BX],0x1a (1000_D694 / 0x1D694)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0x1A);
    CheckExternalEvents(cs7, 0xD69A);
    // JNZ 0x1000:d69d (1000_D698 / 0x1D698)
    if(!ZeroFlag) {
      goto label_1000_D69D_1D69D;
    }
    CheckExternalEvents(cs7, 0xD69B);
    // CLC  (1000_D69A / 0x1D69A)
    CarryFlag = false;
    CheckExternalEvents(cs7, 0xD69D);
    // JMP 0x1000:d667 (1000_D69B / 0x1D69B)
    // JMP target is JMP, inlining.
    CheckExternalEvents(cs7, 0xD66A);
    // JMP 0x1000:d1e5 (1000_D667 / 0x1D667)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D69D_1D69D:
    CheckExternalEvents(cs7, 0xD69E);
    // STC  (1000_D69D / 0x1D69D)
    CarryFlag = true;
    CheckExternalEvents(cs7, 0xD6A1);
    // MOV AX,0x1c00 (1000_D69E / 0x1D69E)
    AX = 0x1C00;
    CheckExternalEvents(cs7, 0xD6A3);
    // JMP 0x1000:d667 (1000_D6A1 / 0x1D6A1)
    // JMP target is JMP, inlining.
    CheckExternalEvents(cs7, 0xD66A);
    // JMP 0x1000:d1e5 (1000_D667 / 0x1D667)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ghidra_guess_1000_D6A4_1D6A4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D6A4_1D6A4:
    CheckExternalEvents(cs7, 0xD6A5);
    // POP CX (1000_D6A4 / 0x1D6A4)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD6A6);
    // POP DX (1000_D6A5 / 0x1D6A5)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD6A9);
    // MOV AX,[0x5334] (1000_D6A6 / 0x1D6A6)
    AX = UInt16[DS, 0x5334];
    CheckExternalEvents(cs7, 0xD6AB);
    // CMP AX,SP (1000_D6A9 / 0x1D6A9)
    Alu16.Sub(AX, SP);
    CheckExternalEvents(cs7, 0xD6AD);
    // JNC 0x1000:d6b4 (1000_D6AB / 0x1D6AB)
    if(!CarryFlag) {
      goto label_1000_D6B4_1D6B4;
    }
    CheckExternalEvents(cs7, 0xD6AF);
    // SUB AX,SP (1000_D6AD / 0x1D6AD)
    AX -= SP;
    CheckExternalEvents(cs7, 0xD6B1);
    // NEG AX (1000_D6AF / 0x1D6AF)
    AX = Alu16.Sub(0, AX);
    label_1000_D6B1_1D6B1:
    CheckExternalEvents(cs7, 0xD6B2);
    // PUSH DX (1000_D6B1 / 0x1D6B1)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0xD6B3);
    // PUSH CX (1000_D6B2 / 0x1D6B2)
    Stack.Push16(CX);
    CheckExternalEvents(cs7, 0xD6B4);
    // RETF  (1000_D6B3 / 0x1D6B3)
    return FarRet();
    label_1000_D6B4_1D6B4:
    CheckExternalEvents(cs7, 0xD6B6);
    // XOR AX,AX (1000_D6B4 / 0x1D6B4)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs7, 0xD6B8);
    // JMP 0x1000:d6b1 (1000_D6B6 / 0x1D6B6)
    goto label_1000_D6B1_1D6B1;
  }
  
  public virtual Action ghidra_guess_1000_D6CA_1D6CA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D6CA_1D6CA:
    CheckExternalEvents(cs7, 0xD6CB);
    // PUSH BP (1000_D6CA / 0x1D6CA)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xD6CD);
    // MOV BP,SP (1000_D6CB / 0x1D6CB)
    BP = SP;
    CheckExternalEvents(cs7, 0xD6CE);
    // PUSH SI (1000_D6CD / 0x1D6CD)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xD6CF);
    // PUSH DI (1000_D6CE / 0x1D6CE)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xD6D2);
    // MOV BX,0x5350 (1000_D6CF / 0x1D6CF)
    BX = 0x5350;
    CheckExternalEvents(cs7, 0xD6D5);
    // CMP word ptr [BX],0x0 (1000_D6D2 / 0x1D6D2)
    Alu16.Sub(UInt16[DS, (ushort)(BX)], 0x0);
    CheckExternalEvents(cs7, 0xD6D7);
    // JNZ 0x1000:d700 (1000_D6D5 / 0x1D6D5)
    if(!ZeroFlag) {
      goto label_1000_D700_1D700;
    }
    CheckExternalEvents(cs7, 0xD6D8);
    // PUSH DS (1000_D6D7 / 0x1D6D7)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xD6D9);
    // POP ES (1000_D6D8 / 0x1D6D8)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD6DC);
    // MOV AX,0x5 (1000_D6D9 / 0x1D6D9)
    AX = 0x5;
    CheckExternalEvents(cs7, 0xD6DF);
    // CALL 0x1000:d92c (1000_D6DC / 0x1D6DC)
    NearCall(cs7, 0xD6DF, unknown_19EF_3A3C_1D92C);
    CheckExternalEvents(cs7, 0xD6E1);
    // JNZ 0x1000:d6e6 (1000_D6DF / 0x1D6DF)
    if(!ZeroFlag) {
      goto label_1000_D6E6_1D6E6;
    }
    CheckExternalEvents(cs7, 0xD6E3);
    // XOR AX,AX (1000_D6E1 / 0x1D6E1)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs7, 0xD6E4);
    // CWD  (1000_D6E3 / 0x1D6E3)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs7, 0xD6E6);
    // JMP 0x1000:d70a (1000_D6E4 / 0x1D6E4)
    goto label_1000_D70A_1D70A;
    label_1000_D6E6_1D6E6:
    CheckExternalEvents(cs7, 0xD6E7);
    // INC AX (1000_D6E6 / 0x1D6E6)
    AX++;
    CheckExternalEvents(cs7, 0xD6E9);
    // AND AL,0xfe (1000_D6E7 / 0x1D6E7)
    // AL &= 0xFE;
    AL = Alu8.And(AL, 0xFE);
    CheckExternalEvents(cs7, 0xD6EC);
    // MOV [0x5350],AX (1000_D6E9 / 0x1D6E9)
    UInt16[DS, 0x5350] = AX;
    CheckExternalEvents(cs7, 0xD6EF);
    // MOV [0x5352],AX (1000_D6EC / 0x1D6EC)
    UInt16[DS, 0x5352] = AX;
    CheckExternalEvents(cs7, 0xD6F0);
    // XCHG AX,SI (1000_D6EF / 0x1D6EF)
    (SI, AX) = (AX, SI);
    CheckExternalEvents(cs7, 0xD6F4);
    // MOV word ptr [SI],0x1 (1000_D6F0 / 0x1D6F0)
    UInt16[DS, (ushort)(SI)] = 0x1;
    CheckExternalEvents(cs7, 0xD6F7);
    // ADD SI,0x4 (1000_D6F4 / 0x1D6F4)
    // SI += 0x4;
    SI = Alu16.Add(SI, 0x4);
    CheckExternalEvents(cs7, 0xD6FC);
    // MOV word ptr [SI + -0x2],0xfffe (1000_D6F7 / 0x1D6F7)
    UInt16[DS, (ushort)(SI - 0x2)] = 0xFFFE;
    CheckExternalEvents(cs7, 0xD700);
    // MOV word ptr [0x5356],SI (1000_D6FC / 0x1D6FC)
    UInt16[DS, 0x5356] = SI;
    label_1000_D700_1D700:
    CheckExternalEvents(cs7, 0xD703);
    // MOV CX,word ptr [BP + 0x6] (1000_D700 / 0x1D700)
    CX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xD705);
    // MOV AX,DS (1000_D703 / 0x1D703)
    AX = DS;
    CheckExternalEvents(cs7, 0xD707);
    // MOV ES,AX (1000_D705 / 0x1D705)
    ES = AX;
    CheckExternalEvents(cs7, 0xD70A);
    // CALL 0x1000:d7ed (1000_D707 / 0x1D707)
    NearCall(cs7, 0xD70A, unknown_19EF_38FD_1D7ED);
    label_1000_D70A_1D70A:
    CheckExternalEvents(cs7, 0xD70B);
    // POP DI (1000_D70A / 0x1D70A)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD70C);
    // POP SI (1000_D70B / 0x1D70B)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD70E);
    // MOV SP,BP (1000_D70C / 0x1D70C)
    SP = BP;
    CheckExternalEvents(cs7, 0xD70F);
    // POP BP (1000_D70E / 0x1D70E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xD710);
    // RETF  (1000_D70F / 0x1D70F)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_3835_1D725(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3835_1D725:
    CheckExternalEvents(cs12, 0x3836);
    // PUSH BP (19EF_3835 / 0x1D725)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3838);
    // MOV BP,SP (19EF_3836 / 0x1D726)
    BP = SP;
    CheckExternalEvents(cs12, 0x383B);
    // SUB SP,0x2 (19EF_3838 / 0x1D728)
    // SP -= 0x2;
    SP = Alu16.Sub(SP, 0x2);
    CheckExternalEvents(cs12, 0x383C);
    // PUSH SI (19EF_383B / 0x1D72B)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x383D);
    // PUSH DI (19EF_383C / 0x1D72C)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x3840);
    // MOV AX,word ptr [BP + 0x6] (19EF_383D / 0x1D72D)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3843);
    // CMP AX,0xfff1 (19EF_3840 / 0x1D730)
    Alu16.Sub(AX, 0xFFF1);
    CheckExternalEvents(cs12, 0x3845);
    // JNC 0x1000:d753 (19EF_3843 / 0x1D733)
    if(!CarryFlag) {
      goto label_19EF_3863_1D753;
    }
    CheckExternalEvents(cs12, 0x384A);
    // CMP word ptr [0x535a],0x0 (19EF_3845 / 0x1D735)
    Alu16.Sub(UInt16[DS, 0x535A], 0x0);
    CheckExternalEvents(cs12, 0x384C);
    // JNZ 0x1000:d744 (19EF_384A / 0x1D73A)
    if(!ZeroFlag) {
      goto label_19EF_3854_1D744;
    }
    CheckExternalEvents(cs12, 0x384F);
    // CALL 0x1000:d764 (19EF_384C / 0x1D73C)
    NearCall(cs12, 0x384F, unknown_19EF_3874_1D764);
    CheckExternalEvents(cs12, 0x3851);
    // JZ 0x1000:d753 (19EF_384F / 0x1D73F)
    if(ZeroFlag) {
      goto label_19EF_3863_1D753;
    }
    CheckExternalEvents(cs12, 0x3854);
    // MOV [0x535a],AX (19EF_3851 / 0x1D741)
    UInt16[DS, 0x535A] = AX;
    label_19EF_3854_1D744:
    CheckExternalEvents(cs12, 0x3857);
    // CALL 0x1000:d7d2 (19EF_3854 / 0x1D744)
    NearCall(cs12, 0x3857, unknown_19EF_38E2_1D7D2);
    CheckExternalEvents(cs12, 0x3859);
    // JNZ 0x1000:d75e (19EF_3857 / 0x1D747)
    if(!ZeroFlag) {
      goto label_19EF_386E_1D75E;
    }
    CheckExternalEvents(cs12, 0x385C);
    // CALL 0x1000:d764 (19EF_3859 / 0x1D749)
    NearCall(cs12, 0x385C, unknown_19EF_3874_1D764);
    CheckExternalEvents(cs12, 0x385E);
    // JZ 0x1000:d753 (19EF_385C / 0x1D74C)
    if(ZeroFlag) {
      goto label_19EF_3863_1D753;
    }
    CheckExternalEvents(cs12, 0x3861);
    // CALL 0x1000:d7d2 (19EF_385E / 0x1D74E)
    NearCall(cs12, 0x3861, unknown_19EF_38E2_1D7D2);
    CheckExternalEvents(cs12, 0x3863);
    // JNZ 0x1000:d75e (19EF_3861 / 0x1D751)
    if(!ZeroFlag) {
      goto label_19EF_386E_1D75E;
    }
    label_19EF_3863_1D753:
    CheckExternalEvents(cs12, 0x3866);
    // PUSH word ptr [BP + 0x6] (19EF_3863 / 0x1D753)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs12, 0x386B);
    // CALLF 0x1000:d6ca (19EF_3866 / 0x1D756)
    FarCall(cs12, 0x386B, ghidra_guess_1000_D6CA_1D6CA);
    CheckExternalEvents(cs12, 0x386E);
    // ADD SP,0x2 (19EF_386B / 0x1D75B)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_19EF_386E_1D75E:
    CheckExternalEvents(cs12, 0x386F);
    // POP DI (19EF_386E / 0x1D75E)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3870);
    // POP SI (19EF_386F / 0x1D75F)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3872);
    // MOV SP,BP (19EF_3870 / 0x1D760)
    SP = BP;
    CheckExternalEvents(cs12, 0x3873);
    // POP BP (19EF_3872 / 0x1D762)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3874);
    // RETF  (19EF_3873 / 0x1D763)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_3874_1D764(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3874_1D764:
    CheckExternalEvents(cs12, 0x3877);
    // MOV BX,0xf0 (19EF_3874 / 0x1D764)
    BX = 0xF0;
    CheckExternalEvents(cs12, 0x387A);
    // CMP word ptr [BP + 0x6],BX (19EF_3877 / 0x1D767)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], BX);
    CheckExternalEvents(cs12, 0x387C);
    // JBE 0x1000:d773 (19EF_387A / 0x1D76A)
    if(CarryFlag || ZeroFlag) {
      goto label_19EF_3883_1D773;
    }
    CheckExternalEvents(cs12, 0x387F);
    // MOV BX,word ptr [BP + 0x6] (19EF_387C / 0x1D76C)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3880);
    // INC BX (19EF_387F / 0x1D76F)
    BX++;
    CheckExternalEvents(cs12, 0x3883);
    // AND BX,0xfffe (19EF_3880 / 0x1D770)
    // BX &= 0xFFFE;
    BX = Alu16.And(BX, 0xFFFE);
    label_19EF_3883_1D773:
    CheckExternalEvents(cs12, 0x3886);
    // MOV word ptr [BP + -0x2],BX (19EF_3883 / 0x1D773)
    UInt16[SS, (ushort)(BP - 0x2)] = BX;
    CheckExternalEvents(cs12, 0x3888);
    // XOR AX,AX (19EF_3886 / 0x1D776)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs12, 0x3889);
    // PUSH DS (19EF_3888 / 0x1D778)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x388A);
    // PUSH AX (19EF_3889 / 0x1D779)
    Stack.Push16(AX);
    CheckExternalEvents(cs12, 0x388B);
    // PUSH AX (19EF_388A / 0x1D77A)
    Stack.Push16(AX);
    CheckExternalEvents(cs12, 0x388E);
    // LEA CX,[BX + 0xe] (19EF_388B / 0x1D77B)
    CX = (ushort)(BX + 0xE);
    CheckExternalEvents(cs12, 0x388F);
    // PUSH CX (19EF_388E / 0x1D77E)
    Stack.Push16(CX);
    CheckExternalEvents(cs12, 0x3891);
    // MOV AL,0x2 (19EF_388F / 0x1D77F)
    AL = 0x2;
    CheckExternalEvents(cs12, 0x3892);
    // PUSH AX (19EF_3891 / 0x1D781)
    Stack.Push16(AX);
    CheckExternalEvents(cs12, 0x3897);
    // CALLF 0x1000:d94e (19EF_3892 / 0x1D782)
    FarCall(cs12, 0x3897, unknown_19EF_3A5E_1D94E);
    CheckExternalEvents(cs12, 0x389A);
    // ADD SP,0x8 (19EF_3897 / 0x1D787)
    SP += 0x8;
    CheckExternalEvents(cs12, 0x389D);
    // CMP DX,-0x1 (19EF_389A / 0x1D78A)
    Alu16.Sub(DX, 0xFFFF);
    CheckExternalEvents(cs12, 0x389F);
    // JZ 0x1000:d7d0 (19EF_389D / 0x1D78D)
    if(ZeroFlag) {
      goto label_19EF_38E0_1D7D0;
    }
    CheckExternalEvents(cs12, 0x38A1);
    // MOV AX,DX (19EF_389F / 0x1D78F)
    AX = DX;
    CheckExternalEvents(cs12, 0x38A5);
    // XCHG word ptr [0x535c],DX (19EF_38A1 / 0x1D791)
    (DX, UInt16[DS, 0x535C]) = (UInt16[DS, 0x535C], DX);
    CheckExternalEvents(cs12, 0x38A8);
    // MOV [0x535e],AX (19EF_38A5 / 0x1D795)
    UInt16[DS, 0x535E] = AX;
    CheckExternalEvents(cs12, 0x38AC);
    // CMP AX,word ptr [0x5362] (19EF_38A8 / 0x1D798)
    Alu16.Sub(AX, UInt16[DS, 0x5362]);
    CheckExternalEvents(cs12, 0x38AE);
    // JBE 0x1000:d7a1 (19EF_38AC / 0x1D79C)
    if(CarryFlag || ZeroFlag) {
      goto label_19EF_38B1_1D7A1;
    }
    CheckExternalEvents(cs12, 0x38B1);
    // MOV [0x5362],AX (19EF_38AE / 0x1D79E)
    UInt16[DS, 0x5362] = AX;
    label_19EF_38B1_1D7A1:
    CheckExternalEvents(cs12, 0x38B3);
    // OR DX,DX (19EF_38B1 / 0x1D7A1)
    // DX |= DX;
    DX = Alu16.Or(DX, DX);
    CheckExternalEvents(cs12, 0x38B5);
    // JZ 0x1000:d7aa (19EF_38B3 / 0x1D7A3)
    if(ZeroFlag) {
      goto label_19EF_38BA_1D7AA;
    }
    CheckExternalEvents(cs12, 0x38B7);
    // MOV DS,DX (19EF_38B5 / 0x1D7A5)
    DS = DX;
    CheckExternalEvents(cs12, 0x38BA);
    // MOV [0x8],AX (19EF_38B7 / 0x1D7A7)
    UInt16[DS, 0x8] = AX;
    label_19EF_38BA_1D7AA:
    CheckExternalEvents(cs12, 0x38BD);
    // MOV BX,word ptr [BP + -0x2] (19EF_38BA / 0x1D7AA)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs12, 0x38BF);
    // MOV DS,AX (19EF_38BD / 0x1D7AD)
    DS = AX;
    CheckExternalEvents(cs12, 0x38C1);
    // XOR AX,AX (19EF_38BF / 0x1D7AF)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs12, 0x38C4);
    // MOV [0x8],AX (19EF_38C1 / 0x1D7B1)
    UInt16[DS, 0x8] = AX;
    CheckExternalEvents(cs12, 0x38C5);
    // DEC AX (19EF_38C4 / 0x1D7B4)
    AX--;
    CheckExternalEvents(cs12, 0x38C6);
    // DEC AX (19EF_38C5 / 0x1D7B5)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs12, 0x38C9);
    // MOV word ptr [BX + 0xc],AX (19EF_38C6 / 0x1D7B6)
    UInt16[DS, (ushort)(BX + 0xC)] = AX;
    CheckExternalEvents(cs12, 0x38CC);
    // MOV AX,0xa (19EF_38C9 / 0x1D7B9)
    AX = 0xA;
    CheckExternalEvents(cs12, 0x38CF);
    // MOV [0x0],AX (19EF_38CC / 0x1D7BC)
    UInt16[DS, 0x0] = AX;
    CheckExternalEvents(cs12, 0x38D2);
    // MOV [0x2],AX (19EF_38CF / 0x1D7BF)
    UInt16[DS, 0x2] = AX;
    CheckExternalEvents(cs12, 0x38D5);
    // LEA AX,[BX + 0x1] (19EF_38D2 / 0x1D7C2)
    AX = (ushort)(BX + 0x1);
    CheckExternalEvents(cs12, 0x38D8);
    // MOV [0xa],AX (19EF_38D5 / 0x1D7C5)
    UInt16[DS, 0xA] = AX;
    CheckExternalEvents(cs12, 0x38DB);
    // ADD AX,0xd (19EF_38D8 / 0x1D7C8)
    // AX += 0xD;
    AX = Alu16.Add(AX, 0xD);
    CheckExternalEvents(cs12, 0x38DE);
    // MOV [0x6],AX (19EF_38DB / 0x1D7CB)
    UInt16[DS, 0x6] = AX;
    CheckExternalEvents(cs12, 0x38E0);
    // MOV AX,DS (19EF_38DE / 0x1D7CE)
    AX = DS;
    label_19EF_38E0_1D7D0:
    CheckExternalEvents(cs12, 0x38E1);
    // POP DS (19EF_38E0 / 0x1D7D0)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x38E2);
    // RET  (19EF_38E1 / 0x1D7D1)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_38E2_1D7D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_38E2_1D7D2:
    CheckExternalEvents(cs12, 0x38E4);
    // MOV AX,DS (19EF_38E2 / 0x1D7D2)
    AX = DS;
    CheckExternalEvents(cs12, 0x38E6);
    // MOV ES,AX (19EF_38E4 / 0x1D7D4)
    ES = AX;
    CheckExternalEvents(cs12, 0x38E9);
    // MOV CX,word ptr [BP + 0x6] (19EF_38E6 / 0x1D7D6)
    CX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x38EB);
    // XOR BX,BX (19EF_38E9 / 0x1D7D9)
    // BX ^= BX;
    BX = Alu16.Xor(BX, BX);
    CheckExternalEvents(cs12, 0x38EF);
    // MOV DS,word ptr [0x535e] (19EF_38EB / 0x1D7DB)
    DS = UInt16[DS, 0x535E];
    CheckExternalEvents(cs12, 0x38F2);
    // CALL 0x1000:d7ed (19EF_38EF / 0x1D7DF)
    NearCall(cs12, 0x38F2, unknown_19EF_38FD_1D7ED);
    CheckExternalEvents(cs12, 0x38F4);
    // OR DX,DX (19EF_38F2 / 0x1D7E2)
    // DX |= DX;
    DX = Alu16.Or(DX, DX);
    CheckExternalEvents(cs12, 0x38F6);
    // MOV CX,ES (19EF_38F4 / 0x1D7E4)
    CX = ES;
    CheckExternalEvents(cs12, 0x38F8);
    // MOV DS,CX (19EF_38F6 / 0x1D7E6)
    DS = CX;
    CheckExternalEvents(cs12, 0x38F9);
    // RET  (19EF_38F8 / 0x1D7E8)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_38FD_1D7ED(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1D7EA: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_19EF_38FA_1D7EA:
    CheckExternalEvents(cs12, 0x38FD);
    // JMP 0x1000:d8bb (19EF_38FA / 0x1D7EA)
    goto label_19EF_39CB_1D8BB;
    entry:
    label_19EF_38FD_1D7ED:
    CheckExternalEvents(cs12, 0x38FE);
    // INC CX (19EF_38FD / 0x1D7ED)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs12, 0x3900);
    // JZ 0x1000:d7ea (19EF_38FE / 0x1D7EE)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs12, 0x38FD);
      // JMP 0x1000:d8bb (19EF_38FA / 0x1D7EA)
      goto label_19EF_39CB_1D8BB;
    }
    CheckExternalEvents(cs12, 0x3903);
    // AND CL,0xfe (19EF_3900 / 0x1D7F0)
    CL &= 0xFE;
    CheckExternalEvents(cs12, 0x3906);
    // CMP CX,-0x12 (19EF_3903 / 0x1D7F3)
    Alu16.Sub(CX, 0xFFEE);
    CheckExternalEvents(cs12, 0x3908);
    // JNC 0x1000:d7ea (19EF_3906 / 0x1D7F6)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs12, 0x38FD);
      // JMP 0x1000:d8bb (19EF_38FA / 0x1D7EA)
      goto label_19EF_39CB_1D8BB;
    }
    CheckExternalEvents(cs12, 0x390B);
    // MOV SI,word ptr [BX + 0x2] (19EF_3908 / 0x1D7F8)
    SI = UInt16[DS, (ushort)(BX + 0x2)];
    CheckExternalEvents(cs12, 0x390C);
    // CLD  (19EF_390B / 0x1D7FB)
    DirectionFlag = false;
    CheckExternalEvents(cs12, 0x390D);
    // LODSW SI (19EF_390C / 0x1D7FC)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs12, 0x390F);
    // MOV DI,SI (19EF_390D / 0x1D7FD)
    DI = SI;
    CheckExternalEvents(cs12, 0x3911);
    // TEST AL,0x1 (19EF_390F / 0x1D7FF)
    Alu8.And(AL, 0x1);
    CheckExternalEvents(cs12, 0x3913);
    // JZ 0x1000:d845 (19EF_3911 / 0x1D801)
    if(ZeroFlag) {
      goto label_19EF_3955_1D845;
    }
    label_19EF_3913_1D803:
    CheckExternalEvents(cs12, 0x3914);
    // DEC AX (19EF_3913 / 0x1D803)
    AX--;
    CheckExternalEvents(cs12, 0x3916);
    // CMP AX,CX (19EF_3914 / 0x1D804)
    Alu16.Sub(AX, CX);
    CheckExternalEvents(cs12, 0x3918);
    // JNC 0x1000:d81d (19EF_3916 / 0x1D806)
    if(!CarryFlag) {
      goto label_19EF_392D_1D81D;
    }
    CheckExternalEvents(cs12, 0x391A);
    // MOV DX,AX (19EF_3918 / 0x1D808)
    DX = AX;
    CheckExternalEvents(cs12, 0x391C);
    // ADD SI,AX (19EF_391A / 0x1D80A)
    // SI += AX;
    SI = Alu16.Add(SI, AX);
    CheckExternalEvents(cs12, 0x391D);
    // LODSW SI (19EF_391C / 0x1D80C)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs12, 0x391F);
    // TEST AL,0x1 (19EF_391D / 0x1D80D)
    Alu8.And(AL, 0x1);
    CheckExternalEvents(cs12, 0x3921);
    // JZ 0x1000:d845 (19EF_391F / 0x1D80F)
    if(ZeroFlag) {
      goto label_19EF_3955_1D845;
    }
    CheckExternalEvents(cs12, 0x3923);
    // ADD AX,DX (19EF_3921 / 0x1D811)
    AX += DX;
    CheckExternalEvents(cs12, 0x3926);
    // ADD AX,0x2 (19EF_3923 / 0x1D813)
    // AX += 0x2;
    AX = Alu16.Add(AX, 0x2);
    CheckExternalEvents(cs12, 0x3928);
    // MOV SI,DI (19EF_3926 / 0x1D816)
    SI = DI;
    CheckExternalEvents(cs12, 0x392B);
    // MOV word ptr [SI + -0x2],AX (19EF_3928 / 0x1D818)
    UInt16[DS, (ushort)(SI - 0x2)] = AX;
    CheckExternalEvents(cs12, 0x392D);
    // JMP 0x1000:d803 (19EF_392B / 0x1D81B)
    goto label_19EF_3913_1D803;
    label_19EF_392D_1D81D:
    CheckExternalEvents(cs12, 0x392F);
    // MOV DI,SI (19EF_392D / 0x1D81D)
    DI = SI;
    CheckExternalEvents(cs12, 0x3931);
    // JZ 0x1000:d82d (19EF_392F / 0x1D81F)
    if(ZeroFlag) {
      goto label_19EF_393D_1D82D;
    }
    CheckExternalEvents(cs12, 0x3933);
    // ADD DI,CX (19EF_3931 / 0x1D821)
    // DI += CX;
    DI = Alu16.Add(DI, CX);
    CheckExternalEvents(cs12, 0x3936);
    // MOV word ptr [SI + -0x2],CX (19EF_3933 / 0x1D823)
    UInt16[DS, (ushort)(SI - 0x2)] = CX;
    CheckExternalEvents(cs12, 0x3938);
    // SUB AX,CX (19EF_3936 / 0x1D826)
    AX -= CX;
    CheckExternalEvents(cs12, 0x3939);
    // DEC AX (19EF_3938 / 0x1D828)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs12, 0x393B);
    // MOV word ptr [DI],AX (19EF_3939 / 0x1D829)
    UInt16[DS, (ushort)(DI)] = AX;
    CheckExternalEvents(cs12, 0x393D);
    // JMP 0x1000:d832 (19EF_393B / 0x1D82B)
    goto label_19EF_3942_1D832;
    label_19EF_393D_1D82D:
    CheckExternalEvents(cs12, 0x393F);
    // ADD DI,CX (19EF_393D / 0x1D82D)
    DI += CX;
    CheckExternalEvents(cs12, 0x3942);
    // DEC byte ptr [SI + -0x2] (19EF_393F / 0x1D82F)
    UInt8[DS, (ushort)(SI - 0x2)] = Alu8.Dec(UInt8[DS, (ushort)(SI - 0x2)]);
    label_19EF_3942_1D832:
    CheckExternalEvents(cs12, 0x3944);
    // MOV AX,SI (19EF_3942 / 0x1D832)
    AX = SI;
    CheckExternalEvents(cs12, 0x3946);
    // MOV DX,DS (19EF_3944 / 0x1D834)
    DX = DS;
    CheckExternalEvents(cs12, 0x3948);
    // MOV CX,SS (19EF_3946 / 0x1D836)
    CX = SS;
    CheckExternalEvents(cs12, 0x394A);
    // CMP DX,CX (19EF_3948 / 0x1D838)
    Alu16.Sub(DX, CX);
    CheckExternalEvents(cs12, 0x394C);
    // JZ 0x1000:d841 (19EF_394A / 0x1D83A)
    if(ZeroFlag) {
      goto label_19EF_3951_1D841;
    }
    CheckExternalEvents(cs12, 0x3951);
    // MOV word ptr ES:[0x535e],DS (19EF_394C / 0x1D83C)
    UInt16[ES, 0x535E] = DS;
    label_19EF_3951_1D841:
    CheckExternalEvents(cs12, 0x3954);
    // MOV word ptr [BX + 0x2],DI (19EF_3951 / 0x1D841)
    UInt16[DS, (ushort)(BX + 0x2)] = DI;
    CheckExternalEvents(cs12, 0x3955);
    // RET  (19EF_3954 / 0x1D844)
    return NearRet();
    label_19EF_3955_1D845:
    CheckExternalEvents(cs12, 0x395B);
    // MOV byte ptr ES:[0x5364],0x2 (19EF_3955 / 0x1D845)
    UInt8[ES, 0x5364] = 0x2;
    label_19EF_395B_1D84B:
    CheckExternalEvents(cs12, 0x395E);
    // CMP AX,0xfffe (19EF_395B / 0x1D84B)
    Alu16.Sub(AX, 0xFFFE);
    CheckExternalEvents(cs12, 0x3960);
    // JZ 0x1000:d875 (19EF_395E / 0x1D84E)
    if(ZeroFlag) {
      goto label_19EF_3985_1D875;
    }
    CheckExternalEvents(cs12, 0x3962);
    // MOV DI,SI (19EF_3960 / 0x1D850)
    DI = SI;
    CheckExternalEvents(cs12, 0x3964);
    // ADD SI,AX (19EF_3962 / 0x1D852)
    // SI += AX;
    SI = Alu16.Add(SI, AX);
    label_19EF_3964_1D854:
    CheckExternalEvents(cs12, 0x3965);
    // LODSW SI (19EF_3964 / 0x1D854)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs12, 0x3967);
    // TEST AL,0x1 (19EF_3965 / 0x1D855)
    Alu8.And(AL, 0x1);
    CheckExternalEvents(cs12, 0x3969);
    // JZ 0x1000:d84b (19EF_3967 / 0x1D857)
    if(ZeroFlag) {
      goto label_19EF_395B_1D84B;
    }
    CheckExternalEvents(cs12, 0x396B);
    // MOV DI,SI (19EF_3969 / 0x1D859)
    DI = SI;
    label_19EF_396B_1D85B:
    CheckExternalEvents(cs12, 0x396C);
    // DEC AX (19EF_396B / 0x1D85B)
    AX--;
    CheckExternalEvents(cs12, 0x396E);
    // CMP AX,CX (19EF_396C / 0x1D85C)
    Alu16.Sub(AX, CX);
    CheckExternalEvents(cs12, 0x3970);
    // JNC 0x1000:d81d (19EF_396E / 0x1D85E)
    if(!CarryFlag) {
      goto label_19EF_392D_1D81D;
    }
    CheckExternalEvents(cs12, 0x3972);
    // MOV DX,AX (19EF_3970 / 0x1D860)
    DX = AX;
    CheckExternalEvents(cs12, 0x3974);
    // ADD SI,AX (19EF_3972 / 0x1D862)
    // SI += AX;
    SI = Alu16.Add(SI, AX);
    CheckExternalEvents(cs12, 0x3975);
    // LODSW SI (19EF_3974 / 0x1D864)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs12, 0x3977);
    // TEST AL,0x1 (19EF_3975 / 0x1D865)
    Alu8.And(AL, 0x1);
    CheckExternalEvents(cs12, 0x3979);
    // JZ 0x1000:d84b (19EF_3977 / 0x1D867)
    if(ZeroFlag) {
      goto label_19EF_395B_1D84B;
    }
    CheckExternalEvents(cs12, 0x397B);
    // ADD AX,DX (19EF_3979 / 0x1D869)
    AX += DX;
    CheckExternalEvents(cs12, 0x397E);
    // ADD AX,0x2 (19EF_397B / 0x1D86B)
    // AX += 0x2;
    AX = Alu16.Add(AX, 0x2);
    CheckExternalEvents(cs12, 0x3980);
    // MOV SI,DI (19EF_397E / 0x1D86E)
    SI = DI;
    CheckExternalEvents(cs12, 0x3983);
    // MOV word ptr [SI + -0x2],AX (19EF_3980 / 0x1D870)
    UInt16[DS, (ushort)(SI - 0x2)] = AX;
    CheckExternalEvents(cs12, 0x3985);
    // JMP 0x1000:d85b (19EF_3983 / 0x1D873)
    goto label_19EF_396B_1D85B;
    label_19EF_3985_1D875:
    CheckExternalEvents(cs12, 0x3988);
    // MOV AX,word ptr [BX + 0x8] (19EF_3985 / 0x1D875)
    AX = UInt16[DS, (ushort)(BX + 0x8)];
    CheckExternalEvents(cs12, 0x398A);
    // OR AX,AX (19EF_3988 / 0x1D878)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs12, 0x398C);
    // JZ 0x1000:d880 (19EF_398A / 0x1D87A)
    if(ZeroFlag) {
      goto label_19EF_3990_1D880;
    }
    CheckExternalEvents(cs12, 0x398E);
    // MOV DS,AX (19EF_398C / 0x1D87C)
    DS = AX;
    CheckExternalEvents(cs12, 0x3990);
    // JMP 0x1000:d894 (19EF_398E / 0x1D87E)
    goto label_19EF_39A4_1D894;
    label_19EF_3990_1D880:
    CheckExternalEvents(cs12, 0x3995);
    // DEC byte ptr ES:[0x5364] (19EF_3990 / 0x1D880)
    UInt8[ES, 0x5364] = Alu8.Dec(UInt8[ES, 0x5364]);
    CheckExternalEvents(cs12, 0x3997);
    // JZ 0x1000:d898 (19EF_3995 / 0x1D885)
    if(ZeroFlag) {
      goto label_19EF_39A8_1D898;
    }
    CheckExternalEvents(cs12, 0x3999);
    // MOV AX,DS (19EF_3997 / 0x1D887)
    AX = DS;
    CheckExternalEvents(cs12, 0x399B);
    // MOV DI,SS (19EF_3999 / 0x1D889)
    DI = SS;
    CheckExternalEvents(cs12, 0x399D);
    // CMP AX,DI (19EF_399B / 0x1D88B)
    Alu16.Sub(AX, DI);
    CheckExternalEvents(cs12, 0x399F);
    // JZ 0x1000:d894 (19EF_399D / 0x1D88D)
    if(ZeroFlag) {
      goto label_19EF_39A4_1D894;
    }
    CheckExternalEvents(cs12, 0x39A4);
    // MOV DS,word ptr ES:[0x535a] (19EF_399F / 0x1D88F)
    DS = UInt16[ES, 0x535A];
    label_19EF_39A4_1D894:
    CheckExternalEvents(cs12, 0x39A6);
    // MOV SI,word ptr [BX] (19EF_39A4 / 0x1D894)
    SI = UInt16[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x39A8);
    // JMP 0x1000:d854 (19EF_39A6 / 0x1D896)
    goto label_19EF_3964_1D854;
    label_19EF_39A8_1D898:
    CheckExternalEvents(cs12, 0x39AB);
    // MOV SI,word ptr [BX + 0x6] (19EF_39A8 / 0x1D898)
    SI = UInt16[DS, (ushort)(BX + 0x6)];
    CheckExternalEvents(cs12, 0x39AD);
    // XOR AX,AX (19EF_39AB / 0x1D89B)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs12, 0x39B0);
    // CALL 0x1000:d90a (19EF_39AD / 0x1D89D)
    NearCall(cs12, 0x39B0, unknown_19EF_3A1A_1D90A);
    CheckExternalEvents(cs12, 0x39B2);
    // CMP AX,SI (19EF_39B0 / 0x1D8A0)
    Alu16.Sub(AX, SI);
    CheckExternalEvents(cs12, 0x39B4);
    // JZ 0x1000:d8b1 (19EF_39B2 / 0x1D8A2)
    if(ZeroFlag) {
      goto label_19EF_39C1_1D8B1;
    }
    CheckExternalEvents(cs12, 0x39B6);
    // AND AL,0x1 (19EF_39B4 / 0x1D8A4)
    AL &= 0x1;
    CheckExternalEvents(cs12, 0x39B7);
    // INC AX (19EF_39B6 / 0x1D8A6)
    AX++;
    CheckExternalEvents(cs12, 0x39B8);
    // INC AX (19EF_39B7 / 0x1D8A7)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs12, 0x39B9);
    // CBW  (19EF_39B8 / 0x1D8A8)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs12, 0x39BC);
    // CALL 0x1000:d90a (19EF_39B9 / 0x1D8A9)
    NearCall(cs12, 0x39BC, unknown_19EF_3A1A_1D90A);
    CheckExternalEvents(cs12, 0x39BE);
    // JZ 0x1000:d8bb (19EF_39BC / 0x1D8AC)
    if(ZeroFlag) {
      goto label_19EF_39CB_1D8BB;
    }
    CheckExternalEvents(cs12, 0x39C1);
    // DEC byte ptr [DI + -0x2] (19EF_39BE / 0x1D8AE)
    UInt8[DS, (ushort)(DI - 0x2)] = Alu8.Dec(UInt8[DS, (ushort)(DI - 0x2)]);
    label_19EF_39C1_1D8B1:
    CheckExternalEvents(cs12, 0x39C4);
    // CALL 0x1000:d8d0 (19EF_39C1 / 0x1D8B1)
    NearCall(cs12, 0x39C4, unknown_19EF_39E0_1D8D0);
    CheckExternalEvents(cs12, 0x39C6);
    // JZ 0x1000:d8bb (19EF_39C4 / 0x1D8B4)
    if(ZeroFlag) {
      goto label_19EF_39CB_1D8BB;
    }
    CheckExternalEvents(cs12, 0x39C7);
    // XCHG AX,SI (19EF_39C6 / 0x1D8B6)
    (SI, AX) = (AX, SI);
    CheckExternalEvents(cs12, 0x39C8);
    // DEC SI (19EF_39C7 / 0x1D8B7)
    SI--;
    CheckExternalEvents(cs12, 0x39C9);
    // DEC SI (19EF_39C8 / 0x1D8B8)
    SI = Alu16.Dec(SI);
    CheckExternalEvents(cs12, 0x39CB);
    // JMP 0x1000:d854 (19EF_39C9 / 0x1D8B9)
    goto label_19EF_3964_1D854;
    label_19EF_39CB_1D8BB:
    CheckExternalEvents(cs12, 0x39CD);
    // MOV AX,DS (19EF_39CB / 0x1D8BB)
    AX = DS;
    CheckExternalEvents(cs12, 0x39CF);
    // MOV CX,SS (19EF_39CD / 0x1D8BD)
    CX = SS;
    CheckExternalEvents(cs12, 0x39D1);
    // CMP AX,CX (19EF_39CF / 0x1D8BF)
    Alu16.Sub(AX, CX);
    CheckExternalEvents(cs12, 0x39D3);
    // JZ 0x1000:d8c7 (19EF_39D1 / 0x1D8C1)
    if(ZeroFlag) {
      goto label_19EF_39D7_1D8C7;
    }
    CheckExternalEvents(cs12, 0x39D7);
    // MOV ES:[0x535e],AX (19EF_39D3 / 0x1D8C3)
    UInt16[ES, 0x535E] = AX;
    label_19EF_39D7_1D8C7:
    CheckExternalEvents(cs12, 0x39D9);
    // MOV AX,word ptr [BX] (19EF_39D7 / 0x1D8C7)
    AX = UInt16[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x39DC);
    // MOV word ptr [BX + 0x2],AX (19EF_39D9 / 0x1D8C9)
    UInt16[DS, (ushort)(BX + 0x2)] = AX;
    CheckExternalEvents(cs12, 0x39DE);
    // XOR AX,AX (19EF_39DC / 0x1D8CC)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs12, 0x39DF);
    // CWD  (19EF_39DE / 0x1D8CE)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs12, 0x39E0);
    // RET  (19EF_39DF / 0x1D8CF)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_39E0_1D8D0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_39E0_1D8D0:
    CheckExternalEvents(cs12, 0x39E1);
    // PUSH CX (19EF_39E0 / 0x1D8D0)
    Stack.Push16(CX);
    CheckExternalEvents(cs12, 0x39E4);
    // MOV AX,word ptr [DI + -0x2] (19EF_39E1 / 0x1D8D1)
    AX = UInt16[DS, (ushort)(DI - 0x2)];
    CheckExternalEvents(cs12, 0x39E6);
    // TEST AL,0x1 (19EF_39E4 / 0x1D8D4)
    Alu8.And(AL, 0x1);
    CheckExternalEvents(cs12, 0x39E8);
    // JZ 0x1000:d8db (19EF_39E6 / 0x1D8D6)
    if(ZeroFlag) {
      goto label_19EF_39EB_1D8DB;
    }
    CheckExternalEvents(cs12, 0x39EA);
    // SUB CX,AX (19EF_39E8 / 0x1D8D8)
    CX -= AX;
    CheckExternalEvents(cs12, 0x39EB);
    // DEC CX (19EF_39EA / 0x1D8DA)
    CX--;
    label_19EF_39EB_1D8DB:
    CheckExternalEvents(cs12, 0x39EC);
    // INC CX (19EF_39EB / 0x1D8DB)
    CX++;
    CheckExternalEvents(cs12, 0x39ED);
    // INC CX (19EF_39EC / 0x1D8DC)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs12, 0x39F0);
    // MOV DX,0x7fff (19EF_39ED / 0x1D8DD)
    DX = 0x7FFF;
    label_19EF_39F0_1D8E0:
    CheckExternalEvents(cs12, 0x39F5);
    // CMP DX,word ptr ES:[0x5360] (19EF_39F0 / 0x1D8E0)
    Alu16.Sub(DX, UInt16[ES, 0x5360]);
    CheckExternalEvents(cs12, 0x39F7);
    // JBE 0x1000:d8eb (19EF_39F5 / 0x1D8E5)
    if(CarryFlag || ZeroFlag) {
      goto label_19EF_39FB_1D8EB;
    }
    CheckExternalEvents(cs12, 0x39F9);
    // SHR DX,0x1 (19EF_39F7 / 0x1D8E7)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs12, 0x39FB);
    // JNZ 0x1000:d8e0 (19EF_39F9 / 0x1D8E9)
    if(!ZeroFlag) {
      goto label_19EF_39F0_1D8E0;
    }
    label_19EF_39FB_1D8EB:
    CheckExternalEvents(cs12, 0x39FD);
    // MOV AX,CX (19EF_39FB / 0x1D8EB)
    AX = CX;
    CheckExternalEvents(cs12, 0x39FF);
    // ADD AX,SI (19EF_39FD / 0x1D8ED)
    // AX += SI;
    AX = Alu16.Add(AX, SI);
    CheckExternalEvents(cs12, 0x3A01);
    // JC 0x1000:d906 (19EF_39FF / 0x1D8EF)
    if(CarryFlag) {
      goto label_19EF_3A16_1D906;
    }
    CheckExternalEvents(cs12, 0x3A03);
    // ADD AX,DX (19EF_3A01 / 0x1D8F1)
    // AX += DX;
    AX = Alu16.Add(AX, DX);
    CheckExternalEvents(cs12, 0x3A05);
    // JC 0x1000:d902 (19EF_3A03 / 0x1D8F3)
    if(CarryFlag) {
      goto label_19EF_3A12_1D902;
    }
    CheckExternalEvents(cs12, 0x3A07);
    // NOT DX (19EF_3A05 / 0x1D8F5)
    DX = (ushort)(~DX);
    CheckExternalEvents(cs12, 0x3A09);
    // AND AX,DX (19EF_3A07 / 0x1D8F7)
    AX &= DX;
    CheckExternalEvents(cs12, 0x3A0B);
    // SUB AX,SI (19EF_3A09 / 0x1D8F9)
    // AX -= SI;
    AX = Alu16.Sub(AX, SI);
    CheckExternalEvents(cs12, 0x3A0E);
    // CALL 0x1000:d90a (19EF_3A0B / 0x1D8FB)
    NearCall(cs12, 0x3A0E, unknown_19EF_3A1A_1D90A);
    CheckExternalEvents(cs12, 0x3A10);
    // JNZ 0x1000:d908 (19EF_3A0E / 0x1D8FE)
    if(!ZeroFlag) {
      goto label_19EF_3A18_1D908;
    }
    CheckExternalEvents(cs12, 0x3A12);
    // NOT DX (19EF_3A10 / 0x1D900)
    DX = (ushort)(~DX);
    label_19EF_3A12_1D902:
    CheckExternalEvents(cs12, 0x3A14);
    // SHR DX,0x1 (19EF_3A12 / 0x1D902)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs12, 0x3A16);
    // JNZ 0x1000:d8eb (19EF_3A14 / 0x1D904)
    if(!ZeroFlag) {
      goto label_19EF_39FB_1D8EB;
    }
    label_19EF_3A16_1D906:
    CheckExternalEvents(cs12, 0x3A18);
    // XOR AX,AX (19EF_3A16 / 0x1D906)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    label_19EF_3A18_1D908:
    CheckExternalEvents(cs12, 0x3A19);
    // POP CX (19EF_3A18 / 0x1D908)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3A1A);
    // RET  (19EF_3A19 / 0x1D909)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_3A1A_1D90A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3A1A_1D90A:
    CheckExternalEvents(cs12, 0x3A1B);
    // PUSH DX (19EF_3A1A / 0x1D90A)
    Stack.Push16(DX);
    CheckExternalEvents(cs12, 0x3A1C);
    // PUSH CX (19EF_3A1B / 0x1D90B)
    Stack.Push16(CX);
    CheckExternalEvents(cs12, 0x3A1F);
    // CALL 0x1000:d92c (19EF_3A1C / 0x1D90C)
    NearCall(cs12, 0x3A1F, unknown_19EF_3A3C_1D92C);
    CheckExternalEvents(cs12, 0x3A21);
    // JZ 0x1000:d929 (19EF_3A1F / 0x1D90F)
    if(ZeroFlag) {
      goto label_19EF_3A39_1D929;
    }
    CheckExternalEvents(cs12, 0x3A22);
    // PUSH DI (19EF_3A21 / 0x1D911)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x3A24);
    // MOV DI,SI (19EF_3A22 / 0x1D912)
    DI = SI;
    CheckExternalEvents(cs12, 0x3A26);
    // MOV SI,AX (19EF_3A24 / 0x1D914)
    SI = AX;
    CheckExternalEvents(cs12, 0x3A28);
    // ADD SI,DX (19EF_3A26 / 0x1D916)
    // SI += DX;
    SI = Alu16.Add(SI, DX);
    CheckExternalEvents(cs12, 0x3A2D);
    // MOV word ptr [SI + -0x2],0xfffe (19EF_3A28 / 0x1D918)
    UInt16[DS, (ushort)(SI - 0x2)] = 0xFFFE;
    CheckExternalEvents(cs12, 0x3A30);
    // MOV word ptr [BX + 0x6],SI (19EF_3A2D / 0x1D91D)
    UInt16[DS, (ushort)(BX + 0x6)] = SI;
    CheckExternalEvents(cs12, 0x3A32);
    // MOV DX,SI (19EF_3A30 / 0x1D920)
    DX = SI;
    CheckExternalEvents(cs12, 0x3A34);
    // SUB DX,DI (19EF_3A32 / 0x1D922)
    DX -= DI;
    CheckExternalEvents(cs12, 0x3A35);
    // DEC DX (19EF_3A34 / 0x1D924)
    DX = Alu16.Dec(DX);
    CheckExternalEvents(cs12, 0x3A38);
    // MOV word ptr [DI + -0x2],DX (19EF_3A35 / 0x1D925)
    UInt16[DS, (ushort)(DI - 0x2)] = DX;
    CheckExternalEvents(cs12, 0x3A39);
    // POP AX (19EF_3A38 / 0x1D928)
    AX = Stack.Pop16();;
    label_19EF_3A39_1D929:
    CheckExternalEvents(cs12, 0x3A3A);
    // POP CX (19EF_3A39 / 0x1D929)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3A3B);
    // POP DX (19EF_3A3A / 0x1D92A)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3A3C);
    // RET  (19EF_3A3B / 0x1D92B)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_3A3C_1D92C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3A3C_1D92C:
    CheckExternalEvents(cs12, 0x3A3D);
    // PUSH BX (19EF_3A3C / 0x1D92C)
    Stack.Push16(BX);
    CheckExternalEvents(cs12, 0x3A3E);
    // PUSH AX (19EF_3A3D / 0x1D92D)
    Stack.Push16(AX);
    CheckExternalEvents(cs12, 0x3A40);
    // XOR DX,DX (19EF_3A3E / 0x1D92E)
    // DX ^= DX;
    DX = Alu16.Xor(DX, DX);
    CheckExternalEvents(cs12, 0x3A41);
    // PUSH DS (19EF_3A40 / 0x1D930)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x3A42);
    // PUSH DX (19EF_3A41 / 0x1D931)
    Stack.Push16(DX);
    CheckExternalEvents(cs12, 0x3A43);
    // PUSH DX (19EF_3A42 / 0x1D932)
    Stack.Push16(DX);
    CheckExternalEvents(cs12, 0x3A44);
    // PUSH AX (19EF_3A43 / 0x1D933)
    Stack.Push16(AX);
    CheckExternalEvents(cs12, 0x3A47);
    // MOV AX,0x1 (19EF_3A44 / 0x1D934)
    AX = 0x1;
    CheckExternalEvents(cs12, 0x3A48);
    // PUSH AX (19EF_3A47 / 0x1D937)
    Stack.Push16(AX);
    CheckExternalEvents(cs12, 0x3A49);
    // PUSH ES (19EF_3A48 / 0x1D938)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x3A4A);
    // POP DS (19EF_3A49 / 0x1D939)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3A4F);
    // CALLF 0x1000:d94e (19EF_3A4A / 0x1D93A)
    FarCall(cs12, 0x3A4F, unknown_19EF_3A5E_1D94E);
    CheckExternalEvents(cs12, 0x3A52);
    // ADD SP,0x8 (19EF_3A4F / 0x1D93F)
    SP += 0x8;
    CheckExternalEvents(cs12, 0x3A55);
    // CMP DX,-0x1 (19EF_3A52 / 0x1D942)
    Alu16.Sub(DX, 0xFFFF);
    CheckExternalEvents(cs12, 0x3A56);
    // POP DS (19EF_3A55 / 0x1D945)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3A57);
    // POP DX (19EF_3A56 / 0x1D946)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3A58);
    // POP BX (19EF_3A57 / 0x1D947)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3A5A);
    // JZ 0x1000:d94c (19EF_3A58 / 0x1D948)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      CheckExternalEvents(cs12, 0x3A5D);
      // RET  (19EF_3A5C / 0x1D94C)
      return NearRet();
    }
    CheckExternalEvents(cs12, 0x3A5C);
    // OR DX,DX (19EF_3A5A / 0x1D94A)
    // DX |= DX;
    DX = Alu16.Or(DX, DX);
    label_19EF_3A5C_1D94C:
    CheckExternalEvents(cs12, 0x3A5D);
    // RET  (19EF_3A5C / 0x1D94C)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_3A5E_1D94E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3A5E_1D94E:
    CheckExternalEvents(cs12, 0x3A5F);
    // PUSH BP (19EF_3A5E / 0x1D94E)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3A61);
    // MOV BP,SP (19EF_3A5F / 0x1D94F)
    BP = SP;
    CheckExternalEvents(cs12, 0x3A62);
    // PUSH SI (19EF_3A61 / 0x1D951)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x3A63);
    // PUSH DI (19EF_3A62 / 0x1D952)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x3A64);
    // PUSH ES (19EF_3A63 / 0x1D953)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x3A68);
    // CMP word ptr [BP + 0xa],0x0 (19EF_3A64 / 0x1D954)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs12, 0x3A6A);
    // JNZ 0x1000:d992 (19EF_3A68 / 0x1D958)
    if(!ZeroFlag) {
      goto label_19EF_3AA2_1D992;
    }
    CheckExternalEvents(cs12, 0x3A6D);
    // MOV DI,0x5286 (19EF_3A6A / 0x1D95A)
    DI = 0x5286;
    CheckExternalEvents(cs12, 0x3A70);
    // MOV DX,word ptr [BP + 0x8] (19EF_3A6D / 0x1D95D)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x3A73);
    // MOV AX,word ptr [BP + 0x6] (19EF_3A70 / 0x1D960)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3A74);
    // DEC AX (19EF_3A73 / 0x1D963)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs12, 0x3A76);
    // JNZ 0x1000:d96d (19EF_3A74 / 0x1D964)
    if(!ZeroFlag) {
      goto label_19EF_3A7D_1D96D;
    }
    CheckExternalEvents(cs12, 0x3A79);
    // CALL 0x1000:d9bc (19EF_3A76 / 0x1D966)
    NearCall(cs12, 0x3A79, unknown_19EF_3ACC_1D9BC);
    CheckExternalEvents(cs12, 0x3A7B);
    // JC 0x1000:d992 (19EF_3A79 / 0x1D969)
    if(CarryFlag) {
      goto label_19EF_3AA2_1D992;
    }
    CheckExternalEvents(cs12, 0x3A7D);
    // JMP 0x1000:d9b5 (19EF_3A7B / 0x1D96B)
    goto label_19EF_3AC5_1D9B5;
    label_19EF_3A7D_1D96D:
    CheckExternalEvents(cs12, 0x3A81);
    // MOV SI,word ptr [0x52d6] (19EF_3A7D / 0x1D96D)
    SI = UInt16[DS, 0x52D6];
    CheckExternalEvents(cs12, 0x3A82);
    // DEC AX (19EF_3A81 / 0x1D971)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs12, 0x3A84);
    // JZ 0x1000:d985 (19EF_3A82 / 0x1D972)
    if(ZeroFlag) {
      goto label_19EF_3A95_1D985;
    }
    CheckExternalEvents(cs12, 0x3A86);
    // CMP SI,DI (19EF_3A84 / 0x1D974)
    Alu16.Sub(SI, DI);
    CheckExternalEvents(cs12, 0x3A88);
    // JZ 0x1000:d985 (19EF_3A86 / 0x1D976)
    if(ZeroFlag) {
      goto label_19EF_3A95_1D985;
    }
    CheckExternalEvents(cs12, 0x3A8B);
    // MOV AX,word ptr [SI + 0x2] (19EF_3A88 / 0x1D978)
    AX = UInt16[DS, (ushort)(SI + 0x2)];
    CheckExternalEvents(cs12, 0x3A8E);
    // MOV word ptr [BP + 0xe],AX (19EF_3A8B / 0x1D97B)
    UInt16[SS, (ushort)(BP + 0xE)] = AX;
    CheckExternalEvents(cs12, 0x3A8F);
    // PUSH SI (19EF_3A8E / 0x1D97E)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x3A92);
    // CALL 0x1000:d9bc (19EF_3A8F / 0x1D97F)
    NearCall(cs12, 0x3A92, unknown_19EF_3ACC_1D9BC);
    CheckExternalEvents(cs12, 0x3A93);
    // POP SI (19EF_3A92 / 0x1D982)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3A95);
    // JNC 0x1000:d9b5 (19EF_3A93 / 0x1D983)
    if(!CarryFlag) {
      goto label_19EF_3AC5_1D9B5;
    }
    label_19EF_3A95_1D985:
    CheckExternalEvents(cs12, 0x3A98);
    // ADD SI,0x4 (19EF_3A95 / 0x1D985)
    SI += 0x4;
    CheckExternalEvents(cs12, 0x3A9C);
    // CMP SI,0x52d6 (19EF_3A98 / 0x1D988)
    Alu16.Sub(SI, 0x52D6);
    CheckExternalEvents(cs12, 0x3A9E);
    // JNC 0x1000:d992 (19EF_3A9C / 0x1D98C)
    if(!CarryFlag) {
      goto label_19EF_3AA2_1D992;
    }
    CheckExternalEvents(cs12, 0x3AA0);
    // OR DX,DX (19EF_3A9E / 0x1D98E)
    // DX |= DX;
    DX = Alu16.Or(DX, DX);
    CheckExternalEvents(cs12, 0x3AA2);
    // JNZ 0x1000:d998 (19EF_3AA0 / 0x1D990)
    if(!ZeroFlag) {
      goto label_19EF_3AA8_1D998;
    }
    label_19EF_3AA2_1D992:
    CheckExternalEvents(cs12, 0x3AA5);
    // MOV AX,0xffff (19EF_3AA2 / 0x1D992)
    AX = 0xFFFF;
    CheckExternalEvents(cs12, 0x3AA6);
    // CWD  (19EF_3AA5 / 0x1D995)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs12, 0x3AA8);
    // JMP 0x1000:d9b5 (19EF_3AA6 / 0x1D996)
    goto label_19EF_3AC5_1D9B5;
    label_19EF_3AA8_1D998:
    CheckExternalEvents(cs12, 0x3AAA);
    // MOV BX,DX (19EF_3AA8 / 0x1D998)
    BX = DX;
    CheckExternalEvents(cs12, 0x3AAD);
    // ADD BX,0xf (19EF_3AAA / 0x1D99A)
    // BX += 0xF;
    BX = Alu16.Add(BX, 0xF);
    CheckExternalEvents(cs12, 0x3AAF);
    // RCR BX,0x1 (19EF_3AAD / 0x1D99D)
    BX = Alu16.Rcr(BX, 0x1);
    CheckExternalEvents(cs12, 0x3AB1);
    // MOV CL,0x3 (19EF_3AAF / 0x1D99F)
    CL = 0x3;
    CheckExternalEvents(cs12, 0x3AB3);
    // SHR BX,CL (19EF_3AB1 / 0x1D9A1)
    // BX >>= CL;
    BX = Alu16.Shr(BX, CL);
    CheckExternalEvents(cs12, 0x3AB5);
    // MOV AH,0x48 (19EF_3AB3 / 0x1D9A3)
    AH = 0x48;
    CheckExternalEvents(cs12, 0x3AB7);
    // INT 0x21 (19EF_3AB5 / 0x1D9A5)
    Interrupt(0x21);
    CheckExternalEvents(cs12, 0x3AB9);
    // JC 0x1000:d992 (19EF_3AB7 / 0x1D9A7)
    if(CarryFlag) {
      goto label_19EF_3AA2_1D992;
    }
    CheckExternalEvents(cs12, 0x3ABA);
    // XCHG AX,DX (19EF_3AB9 / 0x1D9A9)
    (DX, AX) = (AX, DX);
    CheckExternalEvents(cs12, 0x3ABC);
    // MOV word ptr [SI],AX (19EF_3ABA / 0x1D9AA)
    UInt16[DS, (ushort)(SI)] = AX;
    CheckExternalEvents(cs12, 0x3ABF);
    // MOV word ptr [SI + 0x2],DX (19EF_3ABC / 0x1D9AC)
    UInt16[DS, (ushort)(SI + 0x2)] = DX;
    CheckExternalEvents(cs12, 0x3AC3);
    // MOV word ptr [0x52d6],SI (19EF_3ABF / 0x1D9AF)
    UInt16[DS, 0x52D6] = SI;
    CheckExternalEvents(cs12, 0x3AC5);
    // XOR AX,AX (19EF_3AC3 / 0x1D9B3)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    label_19EF_3AC5_1D9B5:
    CheckExternalEvents(cs12, 0x3AC6);
    // POP ES (19EF_3AC5 / 0x1D9B5)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3AC7);
    // POP DI (19EF_3AC6 / 0x1D9B6)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3AC8);
    // POP SI (19EF_3AC7 / 0x1D9B7)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3ACA);
    // MOV SP,BP (19EF_3AC8 / 0x1D9B8)
    SP = BP;
    CheckExternalEvents(cs12, 0x3ACB);
    // POP BP (19EF_3ACA / 0x1D9BA)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3ACC);
    // RETF  (19EF_3ACB / 0x1D9BB)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_3ACC_1D9BC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3ACC_1D9BC:
    CheckExternalEvents(cs12, 0x3ACF);
    // MOV CX,word ptr [BP + 0xe] (19EF_3ACC / 0x1D9BC)
    CX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs12, 0x3AD1);
    // MOV SI,DI (19EF_3ACF / 0x1D9BF)
    SI = DI;
    label_19EF_3AD1_1D9C1:
    CheckExternalEvents(cs12, 0x3AD4);
    // CMP word ptr [SI + 0x2],CX (19EF_3AD1 / 0x1D9C1)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x2)], CX);
    CheckExternalEvents(cs12, 0x3AD6);
    // JZ 0x1000:d9d2 (19EF_3AD4 / 0x1D9C4)
    if(ZeroFlag) {
      goto label_19EF_3AE2_1D9D2;
    }
    CheckExternalEvents(cs12, 0x3AD9);
    // ADD SI,0x4 (19EF_3AD6 / 0x1D9C6)
    SI += 0x4;
    CheckExternalEvents(cs12, 0x3ADD);
    // CMP SI,0x52d6 (19EF_3AD9 / 0x1D9C9)
    Alu16.Sub(SI, 0x52D6);
    CheckExternalEvents(cs12, 0x3ADF);
    // JNZ 0x1000:d9c1 (19EF_3ADD / 0x1D9CD)
    if(!ZeroFlag) {
      goto label_19EF_3AD1_1D9C1;
    }
    CheckExternalEvents(cs12, 0x3AE0);
    // STC  (19EF_3ADF / 0x1D9CF)
    CarryFlag = true;
    CheckExternalEvents(cs12, 0x3AE2);
    // JMP 0x1000:da11 (19EF_3AE0 / 0x1D9D0)
    // JMP target is RET, inlining.
    CheckExternalEvents(cs12, 0x3B22);
    // RET  (19EF_3B21 / 0x1DA11)
    return NearRet();
    label_19EF_3AE2_1D9D2:
    CheckExternalEvents(cs12, 0x3AE4);
    // MOV BX,DX (19EF_3AE2 / 0x1D9D2)
    BX = DX;
    CheckExternalEvents(cs12, 0x3AE6);
    // ADD BX,word ptr [SI] (19EF_3AE4 / 0x1D9D4)
    // BX += UInt16[DS, (ushort)(SI)];
    BX = Alu16.Add(BX, UInt16[DS, (ushort)(SI)]);
    CheckExternalEvents(cs12, 0x3AE8);
    // JC 0x1000:da11 (19EF_3AE6 / 0x1D9D6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      CheckExternalEvents(cs12, 0x3B22);
      // RET  (19EF_3B21 / 0x1DA11)
      return NearRet();
    }
    CheckExternalEvents(cs12, 0x3AEA);
    // MOV DX,BX (19EF_3AE8 / 0x1D9D8)
    DX = BX;
    CheckExternalEvents(cs12, 0x3AEC);
    // MOV ES,CX (19EF_3AEA / 0x1D9DA)
    ES = CX;
    CheckExternalEvents(cs12, 0x3AEE);
    // CMP SI,DI (19EF_3AEC / 0x1D9DC)
    Alu16.Sub(SI, DI);
    CheckExternalEvents(cs12, 0x3AF0);
    // JNZ 0x1000:d9e6 (19EF_3AEE / 0x1D9DE)
    if(!ZeroFlag) {
      goto label_19EF_3AF6_1D9E6;
    }
    CheckExternalEvents(cs12, 0x3AF4);
    // CMP word ptr [0x5280],BX (19EF_3AF0 / 0x1D9E0)
    Alu16.Sub(UInt16[DS, 0x5280], BX);
    CheckExternalEvents(cs12, 0x3AF6);
    // JNC 0x1000:da0c (19EF_3AF4 / 0x1D9E4)
    if(!CarryFlag) {
      goto label_19EF_3B1C_1DA0C;
    }
    label_19EF_3AF6_1D9E6:
    CheckExternalEvents(cs12, 0x3AF9);
    // ADD BX,0xf (19EF_3AF6 / 0x1D9E6)
    // BX += 0xF;
    BX = Alu16.Add(BX, 0xF);
    CheckExternalEvents(cs12, 0x3AFB);
    // RCR BX,0x1 (19EF_3AF9 / 0x1D9E9)
    BX = Alu16.Rcr(BX, 0x1);
    CheckExternalEvents(cs12, 0x3AFD);
    // SHR BX,0x1 (19EF_3AFB / 0x1D9EB)
    BX >>= 0x1;
    CheckExternalEvents(cs12, 0x3AFF);
    // SHR BX,0x1 (19EF_3AFD / 0x1D9ED)
    BX >>= 0x1;
    CheckExternalEvents(cs12, 0x3B01);
    // SHR BX,0x1 (19EF_3AFF / 0x1D9EF)
    BX >>= 0x1;
    CheckExternalEvents(cs12, 0x3B03);
    // CMP SI,DI (19EF_3B01 / 0x1D9F1)
    Alu16.Sub(SI, DI);
    CheckExternalEvents(cs12, 0x3B05);
    // JNZ 0x1000:d9fe (19EF_3B03 / 0x1D9F3)
    if(!ZeroFlag) {
      goto label_19EF_3B0E_1D9FE;
    }
    CheckExternalEvents(cs12, 0x3B07);
    // ADD BX,CX (19EF_3B05 / 0x1D9F5)
    // BX += CX;
    BX = Alu16.Add(BX, CX);
    CheckExternalEvents(cs12, 0x3B0A);
    // MOV AX,[0x52f7] (19EF_3B07 / 0x1D9F7)
    AX = UInt16[DS, 0x52F7];
    CheckExternalEvents(cs12, 0x3B0C);
    // SUB BX,AX (19EF_3B0A / 0x1D9FA)
    // BX -= AX;
    BX = Alu16.Sub(BX, AX);
    CheckExternalEvents(cs12, 0x3B0E);
    // MOV ES,AX (19EF_3B0C / 0x1D9FC)
    ES = AX;
    label_19EF_3B0E_1D9FE:
    CheckExternalEvents(cs12, 0x3B10);
    // MOV AH,0x4a (19EF_3B0E / 0x1D9FE)
    AH = 0x4A;
    CheckExternalEvents(cs12, 0x3B12);
    // INT 0x21 (19EF_3B10 / 0x1DA00)
    Interrupt(0x21);
    CheckExternalEvents(cs12, 0x3B14);
    // JC 0x1000:da11 (19EF_3B12 / 0x1DA02)
    if(CarryFlag) {
      // JC target is RET, inlining.
      CheckExternalEvents(cs12, 0x3B22);
      // RET  (19EF_3B21 / 0x1DA11)
      return NearRet();
    }
    CheckExternalEvents(cs12, 0x3B16);
    // CMP SI,DI (19EF_3B14 / 0x1DA04)
    Alu16.Sub(SI, DI);
    CheckExternalEvents(cs12, 0x3B18);
    // JNZ 0x1000:da0c (19EF_3B16 / 0x1DA06)
    if(!ZeroFlag) {
      goto label_19EF_3B1C_1DA0C;
    }
    CheckExternalEvents(cs12, 0x3B1C);
    // MOV word ptr [0x5280],DX (19EF_3B18 / 0x1DA08)
    UInt16[DS, 0x5280] = DX;
    label_19EF_3B1C_1DA0C:
    CheckExternalEvents(cs12, 0x3B1D);
    // XCHG AX,DX (19EF_3B1C / 0x1DA0C)
    (DX, AX) = (AX, DX);
    CheckExternalEvents(cs12, 0x3B1F);
    // XCHG word ptr [SI],AX (19EF_3B1D / 0x1DA0D)
    (AX, UInt16[DS, (ushort)(SI)]) = (UInt16[DS, (ushort)(SI)], AX);
    CheckExternalEvents(cs12, 0x3B21);
    // MOV DX,CX (19EF_3B1F / 0x1DA0F)
    DX = CX;
    label_19EF_3B21_1DA11:
    CheckExternalEvents(cs12, 0x3B22);
    // RET  (19EF_3B21 / 0x1DA11)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_3B22_1DA12(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3B22_1DA12:
    CheckExternalEvents(cs12, 0x3B23);
    // PUSH BP (19EF_3B22 / 0x1DA12)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3B25);
    // MOV BP,SP (19EF_3B23 / 0x1DA13)
    BP = SP;
    CheckExternalEvents(cs12, 0x3B27);
    // MOV DX,DI (19EF_3B25 / 0x1DA15)
    DX = DI;
    CheckExternalEvents(cs12, 0x3B29);
    // MOV BX,SI (19EF_3B27 / 0x1DA17)
    BX = SI;
    CheckExternalEvents(cs12, 0x3B2A);
    // PUSH DS (19EF_3B29 / 0x1DA19)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x3B2D);
    // LES DI,[BP + 0x6] (19EF_3B2A / 0x1DA1A)
    DI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs12, 0x3B2F);
    // XOR AX,AX (19EF_3B2D / 0x1DA1D)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs12, 0x3B32);
    // MOV CX,0xffff (19EF_3B2F / 0x1DA1F)
    CX = 0xFFFF;
    CheckExternalEvents(cs12, 0x3B34);
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (19EF_3B32 / 0x1DA22)
      Alu8.Sub(AL, UInt8[ES, (ushort)(DI)]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    CheckExternalEvents(cs12, 0x3B37);
    // LEA SI,[DI + -0x1] (19EF_3B34 / 0x1DA24)
    SI = (ushort)(DI - 0x1);
    CheckExternalEvents(cs12, 0x3B3A);
    // LES DI,[BP + 0xa] (19EF_3B37 / 0x1DA27)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    ES = UInt16[SS, (ushort)(BP + 0xA + 2)];
    CheckExternalEvents(cs12, 0x3B3D);
    // MOV CX,0xffff (19EF_3B3A / 0x1DA2A)
    CX = 0xFFFF;
    CheckExternalEvents(cs12, 0x3B3F);
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (19EF_3B3D / 0x1DA2D)
      Alu8.Sub(AL, UInt8[ES, (ushort)(DI)]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    CheckExternalEvents(cs12, 0x3B41);
    // NOT CX (19EF_3B3F / 0x1DA2F)
    CX = (ushort)(~CX);
    CheckExternalEvents(cs12, 0x3B43);
    // SUB DI,CX (19EF_3B41 / 0x1DA31)
    // DI -= CX;
    DI = Alu16.Sub(DI, CX);
    CheckExternalEvents(cs12, 0x3B45);
    // MOV AX,ES (19EF_3B43 / 0x1DA33)
    AX = ES;
    CheckExternalEvents(cs12, 0x3B47);
    // MOV DS,AX (19EF_3B45 / 0x1DA35)
    DS = AX;
    CheckExternalEvents(cs12, 0x3B4A);
    // MOV ES,word ptr [BP + 0x8] (19EF_3B47 / 0x1DA37)
    ES = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x3B4C);
    // XCHG SI,DI (19EF_3B4A / 0x1DA3A)
    (DI, SI) = (SI, DI);
    CheckExternalEvents(cs12, 0x3B4F);
    // MOV AX,word ptr [BP + 0x6] (19EF_3B4C / 0x1DA3C)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3B53);
    // TEST SI,0x1 (19EF_3B4F / 0x1DA3F)
    Alu16.And(SI, 0x1);
    CheckExternalEvents(cs12, 0x3B55);
    // JZ 0x1000:da47 (19EF_3B53 / 0x1DA43)
    if(ZeroFlag) {
      goto label_19EF_3B57_1DA47;
    }
    CheckExternalEvents(cs12, 0x3B56);
    // MOVSB ES:DI,SI (19EF_3B55 / 0x1DA45)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs12, 0x3B57);
    // DEC CX (19EF_3B56 / 0x1DA46)
    CX--;
    label_19EF_3B57_1DA47:
    CheckExternalEvents(cs12, 0x3B59);
    // SHR CX,0x1 (19EF_3B57 / 0x1DA47)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    CheckExternalEvents(cs12, 0x3B5B);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_3B59 / 0x1DA49)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x3B5D);
    // ADC CX,CX (19EF_3B5B / 0x1DA4B)
    CX = Alu16.Adc(CX, CX);
    CheckExternalEvents(cs12, 0x3B5F);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (19EF_3B5D / 0x1DA4D)
      UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs12, 0x3B61);
    // MOV SI,BX (19EF_3B5F / 0x1DA4F)
    SI = BX;
    CheckExternalEvents(cs12, 0x3B63);
    // MOV DI,DX (19EF_3B61 / 0x1DA51)
    DI = DX;
    CheckExternalEvents(cs12, 0x3B64);
    // POP DS (19EF_3B63 / 0x1DA53)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3B66);
    // MOV DX,ES (19EF_3B64 / 0x1DA54)
    DX = ES;
    CheckExternalEvents(cs12, 0x3B67);
    // POP BP (19EF_3B66 / 0x1DA56)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3B68);
    // RETF  (19EF_3B67 / 0x1DA57)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_3B68_1DA58(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3B68_1DA58:
    CheckExternalEvents(cs12, 0x3B69);
    // PUSH BP (19EF_3B68 / 0x1DA58)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3B6B);
    // MOV BP,SP (19EF_3B69 / 0x1DA59)
    BP = SP;
    CheckExternalEvents(cs12, 0x3B6D);
    // MOV DX,DI (19EF_3B6B / 0x1DA5B)
    DX = DI;
    CheckExternalEvents(cs12, 0x3B6F);
    // MOV BX,SI (19EF_3B6D / 0x1DA5D)
    BX = SI;
    CheckExternalEvents(cs12, 0x3B70);
    // PUSH DS (19EF_3B6F / 0x1DA5F)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x3B73);
    // LDS SI,[BP + 0xa] (19EF_3B70 / 0x1DA60)
    SI = UInt16[SS, (ushort)(BP + 0xA)];
    DS = UInt16[SS, (ushort)(BP + 0xA + 2)];
    CheckExternalEvents(cs12, 0x3B75);
    // MOV DI,SI (19EF_3B73 / 0x1DA63)
    DI = SI;
    CheckExternalEvents(cs12, 0x3B77);
    // MOV AX,DS (19EF_3B75 / 0x1DA65)
    AX = DS;
    CheckExternalEvents(cs12, 0x3B79);
    // MOV ES,AX (19EF_3B77 / 0x1DA67)
    ES = AX;
    CheckExternalEvents(cs12, 0x3B7B);
    // XOR AX,AX (19EF_3B79 / 0x1DA69)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs12, 0x3B7E);
    // MOV CX,0xffff (19EF_3B7B / 0x1DA6B)
    CX = 0xFFFF;
    CheckExternalEvents(cs12, 0x3B80);
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (19EF_3B7E / 0x1DA6E)
      Alu8.Sub(AL, UInt8[ES, (ushort)(DI)]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    CheckExternalEvents(cs12, 0x3B82);
    // NOT CX (19EF_3B80 / 0x1DA70)
    CX = (ushort)(~CX);
    CheckExternalEvents(cs12, 0x3B85);
    // LES DI,[BP + 0x6] (19EF_3B82 / 0x1DA72)
    DI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs12, 0x3B87);
    // MOV AX,DI (19EF_3B85 / 0x1DA75)
    AX = DI;
    CheckExternalEvents(cs12, 0x3B89);
    // TEST AL,0x1 (19EF_3B87 / 0x1DA77)
    Alu8.And(AL, 0x1);
    CheckExternalEvents(cs12, 0x3B8B);
    // JZ 0x1000:da7d (19EF_3B89 / 0x1DA79)
    if(ZeroFlag) {
      goto label_19EF_3B8D_1DA7D;
    }
    CheckExternalEvents(cs12, 0x3B8C);
    // MOVSB ES:DI,SI (19EF_3B8B / 0x1DA7B)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs12, 0x3B8D);
    // DEC CX (19EF_3B8C / 0x1DA7C)
    CX--;
    label_19EF_3B8D_1DA7D:
    CheckExternalEvents(cs12, 0x3B8F);
    // SHR CX,0x1 (19EF_3B8D / 0x1DA7D)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    CheckExternalEvents(cs12, 0x3B91);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_3B8F / 0x1DA7F)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x3B93);
    // ADC CX,CX (19EF_3B91 / 0x1DA81)
    CX = Alu16.Adc(CX, CX);
    CheckExternalEvents(cs12, 0x3B95);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (19EF_3B93 / 0x1DA83)
      UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs12, 0x3B97);
    // MOV SI,BX (19EF_3B95 / 0x1DA85)
    SI = BX;
    CheckExternalEvents(cs12, 0x3B99);
    // MOV DI,DX (19EF_3B97 / 0x1DA87)
    DI = DX;
    CheckExternalEvents(cs12, 0x3B9A);
    // POP DS (19EF_3B99 / 0x1DA89)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3B9C);
    // MOV DX,ES (19EF_3B9A / 0x1DA8A)
    DX = ES;
    CheckExternalEvents(cs12, 0x3B9D);
    // POP BP (19EF_3B9C / 0x1DA8C)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3B9E);
    // RETF  (19EF_3B9D / 0x1DA8D)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_3B9E_1DA8E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3B9E_1DA8E:
    CheckExternalEvents(cs12, 0x3B9F);
    // PUSH BP (19EF_3B9E / 0x1DA8E)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3BA1);
    // MOV BP,SP (19EF_3B9F / 0x1DA8F)
    BP = SP;
    CheckExternalEvents(cs12, 0x3BA3);
    // MOV DX,DI (19EF_3BA1 / 0x1DA91)
    DX = DI;
    CheckExternalEvents(cs12, 0x3BA6);
    // LES DI,[BP + 0x6] (19EF_3BA3 / 0x1DA93)
    DI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs12, 0x3BA8);
    // XOR AX,AX (19EF_3BA6 / 0x1DA96)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs12, 0x3BAB);
    // MOV CX,0xffff (19EF_3BA8 / 0x1DA98)
    CX = 0xFFFF;
    CheckExternalEvents(cs12, 0x3BAD);
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (19EF_3BAB / 0x1DA9B)
      Alu8.Sub(AL, UInt8[ES, (ushort)(DI)]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    CheckExternalEvents(cs12, 0x3BAF);
    // NOT CX (19EF_3BAD / 0x1DA9D)
    CX = (ushort)(~CX);
    CheckExternalEvents(cs12, 0x3BB0);
    // DEC CX (19EF_3BAF / 0x1DA9F)
    CX = Alu16.Dec(CX);
    CheckExternalEvents(cs12, 0x3BB1);
    // XCHG AX,CX (19EF_3BB0 / 0x1DAA0)
    (CX, AX) = (AX, CX);
    CheckExternalEvents(cs12, 0x3BB3);
    // MOV DI,DX (19EF_3BB1 / 0x1DAA1)
    DI = DX;
    CheckExternalEvents(cs12, 0x3BB4);
    // POP BP (19EF_3BB3 / 0x1DAA3)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3BB5);
    // RETF  (19EF_3BB4 / 0x1DAA4)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_3BB6_1DAA6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3BB6_1DAA6:
    CheckExternalEvents(cs12, 0x3BB7);
    // PUSH BP (19EF_3BB6 / 0x1DAA6)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3BB9);
    // MOV BP,SP (19EF_3BB7 / 0x1DAA7)
    BP = SP;
    CheckExternalEvents(cs12, 0x3BBA);
    // PUSH SI (19EF_3BB9 / 0x1DAA9)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x3BBB);
    // PUSH DI (19EF_3BBA / 0x1DAAA)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x3BBD);
    // MOV BL,0x1 (19EF_3BBB / 0x1DAAB)
    BL = 0x1;
    CheckExternalEvents(cs12, 0x3BC0);
    // MOV CX,word ptr [BP + 0xc] (19EF_3BBD / 0x1DAAD)
    CX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs12, 0x3BC3);
    // MOV AX,word ptr [BP + 0x6] (19EF_3BC0 / 0x1DAB0)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3BC5);
    // XOR DX,DX (19EF_3BC3 / 0x1DAB3)
    DX = 0;
    CheckExternalEvents(cs12, 0x3BC8);
    // CMP CX,0xa (19EF_3BC5 / 0x1DAB5)
    Alu16.Sub(CX, 0xA);
    CheckExternalEvents(cs12, 0x3BCA);
    // JNZ 0x1000:dabb (19EF_3BC8 / 0x1DAB8)
    if(!ZeroFlag) {
      goto label_19EF_3BCB_1DABB;
    }
    CheckExternalEvents(cs12, 0x3BCB);
    // CWD  (19EF_3BCA / 0x1DABA)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    label_19EF_3BCB_1DABB:
    CheckExternalEvents(cs12, 0x3BCC);
    // PUSH DS (19EF_3BCB / 0x1DABB)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x3BCF);
    // LDS DI,[BP + 0x8] (19EF_3BCC / 0x1DABC)
    DI = UInt16[SS, (ushort)(BP + 0x8)];
    DS = UInt16[SS, (ushort)(BP + 0x8 + 2)];
    CheckExternalEvents(cs12, 0x3BD2);
    // JMP 0x1000:db05 (19EF_3BCF / 0x1DABF)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_3C08_1DAF8, 0x1DB05 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action unknown_19EF_3BD2_1DAC2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3BD2_1DAC2:
    CheckExternalEvents(cs12, 0x3BD3);
    // PUSH BP (19EF_3BD2 / 0x1DAC2)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3BD5);
    // MOV BP,SP (19EF_3BD3 / 0x1DAC3)
    BP = SP;
    CheckExternalEvents(cs12, 0x3BD6);
    // PUSH SI (19EF_3BD5 / 0x1DAC5)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x3BD7);
    // PUSH DI (19EF_3BD6 / 0x1DAC6)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x3BD9);
    // MOV BL,0x1 (19EF_3BD7 / 0x1DAC7)
    BL = 0x1;
    CheckExternalEvents(cs12, 0x3BDC);
    // JMP 0x1000:daf8 (19EF_3BD9 / 0x1DAC9)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_3C08_1DAF8, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action unknown_19EF_3BDC_1DACC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3BDC_1DACC:
    CheckExternalEvents(cs12, 0x3BDF);
    // MOV AX,[0x5366] (19EF_3BDC / 0x1DACC)
    AX = UInt16[DS, 0x5366];
    CheckExternalEvents(cs12, 0x3BE1);
    // OR AH,AH (19EF_3BDF / 0x1DACF)
    // AH |= AH;
    AH = Alu8.Or(AH, AH);
    CheckExternalEvents(cs12, 0x3BE3);
    // MOV AL,0xff (19EF_3BE1 / 0x1DAD1)
    AL = 0xFF;
    CheckExternalEvents(cs12, 0x3BE5);
    // JZ 0x1000:dadb (19EF_3BE3 / 0x1DAD3)
    if(ZeroFlag) {
      // JZ target is RETF, inlining.
      CheckExternalEvents(cs12, 0x3BEC);
      // RETF  (19EF_3BEB / 0x1DADB)
      return FarRet();
    }
    CheckExternalEvents(cs12, 0x3BE7);
    // MOV AH,0xb (19EF_3BE5 / 0x1DAD5)
    AH = 0xB;
    CheckExternalEvents(cs12, 0x3BE9);
    // INT 0x21 (19EF_3BE7 / 0x1DAD7)
    Interrupt(0x21);
    CheckExternalEvents(cs12, 0x3BEB);
    // MOV AH,0x0 (19EF_3BE9 / 0x1DAD9)
    AH = 0x0;
    label_19EF_3BEB_1DADB:
    CheckExternalEvents(cs12, 0x3BEC);
    // RETF  (19EF_3BEB / 0x1DADB)
    return FarRet();
  }
  
  public virtual Action spice86_imported_label_jump_target_19EF_3C08_1DAF8(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1DB05: goto label_19EF_3C15_1DB05;break; // Target of external jump from 0x1DABF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_19EF_3C08_1DAF8:
    CheckExternalEvents(cs12, 0x3C0B);
    // MOV CX,word ptr [BP + 0xe] (19EF_3C08 / 0x1DAF8)
    CX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs12, 0x3C0E);
    // MOV AX,word ptr [BP + 0x6] (19EF_3C0B / 0x1DAFB)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3C11);
    // MOV DX,word ptr [BP + 0x8] (19EF_3C0E / 0x1DAFE)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x3C12);
    // PUSH DS (19EF_3C11 / 0x1DB01)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x3C15);
    // LDS DI,[BP + 0xa] (19EF_3C12 / 0x1DB02)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    DS = UInt16[SS, (ushort)(BP + 0xA + 2)];
    label_19EF_3C15_1DB05:
    CheckExternalEvents(cs12, 0x3C16);
    // PUSH DI (19EF_3C15 / 0x1DB05)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x3C17);
    // PUSH DS (19EF_3C16 / 0x1DB06)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x3C18);
    // POP ES (19EF_3C17 / 0x1DB07)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3C19);
    // CLD  (19EF_3C18 / 0x1DB08)
    DirectionFlag = false;
    CheckExternalEvents(cs12, 0x3C1A);
    // XCHG AX,BX (19EF_3C19 / 0x1DB09)
    (BX, AX) = (AX, BX);
    CheckExternalEvents(cs12, 0x3C1C);
    // OR AL,AL (19EF_3C1A / 0x1DB0A)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs12, 0x3C1E);
    // JZ 0x1000:db21 (19EF_3C1C / 0x1DB0C)
    if(ZeroFlag) {
      goto label_19EF_3C31_1DB21;
    }
    CheckExternalEvents(cs12, 0x3C21);
    // CMP CX,0xa (19EF_3C1E / 0x1DB0E)
    Alu16.Sub(CX, 0xA);
    CheckExternalEvents(cs12, 0x3C23);
    // JNZ 0x1000:db21 (19EF_3C21 / 0x1DB11)
    if(!ZeroFlag) {
      goto label_19EF_3C31_1DB21;
    }
    CheckExternalEvents(cs12, 0x3C25);
    // OR DX,DX (19EF_3C23 / 0x1DB13)
    // DX |= DX;
    DX = Alu16.Or(DX, DX);
    CheckExternalEvents(cs12, 0x3C27);
    // JNS 0x1000:db21 (19EF_3C25 / 0x1DB15)
    if(!SignFlag) {
      goto label_19EF_3C31_1DB21;
    }
    CheckExternalEvents(cs12, 0x3C29);
    // MOV AL,0x2d (19EF_3C27 / 0x1DB17)
    AL = 0x2D;
    CheckExternalEvents(cs12, 0x3C2A);
    // STOSB ES:DI (19EF_3C29 / 0x1DB19)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs12, 0x3C2C);
    // NEG BX (19EF_3C2A / 0x1DB1A)
    BX = Alu16.Sub(0, BX);
    CheckExternalEvents(cs12, 0x3C2F);
    // ADC DX,0x0 (19EF_3C2C / 0x1DB1C)
    DX = Alu16.Adc(DX, 0x0);
    CheckExternalEvents(cs12, 0x3C31);
    // NEG DX (19EF_3C2F / 0x1DB1F)
    DX = Alu16.Sub(0, DX);
    label_19EF_3C31_1DB21:
    CheckExternalEvents(cs12, 0x3C33);
    // MOV SI,DI (19EF_3C31 / 0x1DB21)
    SI = DI;
    label_19EF_3C33_1DB23:
    CheckExternalEvents(cs12, 0x3C34);
    // XCHG AX,DX (19EF_3C33 / 0x1DB23)
    (DX, AX) = (AX, DX);
    CheckExternalEvents(cs12, 0x3C36);
    // XOR DX,DX (19EF_3C34 / 0x1DB24)
    // DX ^= DX;
    DX = Alu16.Xor(DX, DX);
    CheckExternalEvents(cs12, 0x3C38);
    // OR AX,AX (19EF_3C36 / 0x1DB26)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs12, 0x3C3A);
    // JZ 0x1000:db2c (19EF_3C38 / 0x1DB28)
    if(ZeroFlag) {
      goto label_19EF_3C3C_1DB2C;
    }
    CheckExternalEvents(cs12, 0x3C3C);
    // DIV CX (19EF_3C3A / 0x1DB2A)
    uint op1Div19EF_3C3A = (DX << 16 | AX);
    ushort op2Div19EF_3C3A = CX;
    ushort? resDiv19EF_3C3A = Alu16.Div(op1Div19EF_3C3A, op2Div19EF_3C3A);
    if(resDiv19EF_3C3A == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = resDiv19EF_3C3A.Value;
    DX = (ushort)(op1Div19EF_3C3A % op2Div19EF_3C3A);
    label_19EF_3C3C_1DB2C:
    CheckExternalEvents(cs12, 0x3C3D);
    // XCHG AX,BX (19EF_3C3C / 0x1DB2C)
    (BX, AX) = (AX, BX);
    CheckExternalEvents(cs12, 0x3C3F);
    // DIV CX (19EF_3C3D / 0x1DB2D)
    uint op1Div19EF_3C3D = (DX << 16 | AX);
    ushort op2Div19EF_3C3D = CX;
    ushort? resDiv19EF_3C3D = Alu16.Div(op1Div19EF_3C3D, op2Div19EF_3C3D);
    if(resDiv19EF_3C3D == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = resDiv19EF_3C3D.Value;
    DX = (ushort)(op1Div19EF_3C3D % op2Div19EF_3C3D);
    CheckExternalEvents(cs12, 0x3C40);
    // XCHG AX,DX (19EF_3C3F / 0x1DB2F)
    (DX, AX) = (AX, DX);
    CheckExternalEvents(cs12, 0x3C42);
    // XCHG BX,DX (19EF_3C40 / 0x1DB30)
    (DX, BX) = (BX, DX);
    CheckExternalEvents(cs12, 0x3C44);
    // ADD AL,0x30 (19EF_3C42 / 0x1DB32)
    AL += 0x30;
    CheckExternalEvents(cs12, 0x3C46);
    // CMP AL,0x39 (19EF_3C44 / 0x1DB34)
    Alu8.Sub(AL, 0x39);
    CheckExternalEvents(cs12, 0x3C48);
    // JBE 0x1000:db3a (19EF_3C46 / 0x1DB36)
    if(CarryFlag || ZeroFlag) {
      goto label_19EF_3C4A_1DB3A;
    }
    CheckExternalEvents(cs12, 0x3C4A);
    // ADD AL,0x27 (19EF_3C48 / 0x1DB38)
    // AL += 0x27;
    AL = Alu8.Add(AL, 0x27);
    label_19EF_3C4A_1DB3A:
    CheckExternalEvents(cs12, 0x3C4B);
    // STOSB ES:DI (19EF_3C4A / 0x1DB3A)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs12, 0x3C4D);
    // MOV AX,DX (19EF_3C4B / 0x1DB3B)
    AX = DX;
    CheckExternalEvents(cs12, 0x3C4F);
    // OR AX,BX (19EF_3C4D / 0x1DB3D)
    // AX |= BX;
    AX = Alu16.Or(AX, BX);
    CheckExternalEvents(cs12, 0x3C51);
    // JNZ 0x1000:db23 (19EF_3C4F / 0x1DB3F)
    if(!ZeroFlag) {
      goto label_19EF_3C33_1DB23;
    }
    CheckExternalEvents(cs12, 0x3C53);
    // MOV byte ptr [DI],AL (19EF_3C51 / 0x1DB41)
    UInt8[DS, (ushort)(DI)] = AL;
    label_19EF_3C53_1DB43:
    CheckExternalEvents(cs12, 0x3C54);
    // DEC DI (19EF_3C53 / 0x1DB43)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs12, 0x3C55);
    // LODSB SI (19EF_3C54 / 0x1DB44)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs12, 0x3C57);
    // XCHG byte ptr [DI],AL (19EF_3C55 / 0x1DB45)
    (AL, UInt8[DS, (ushort)(DI)]) = (UInt8[DS, (ushort)(DI)], AL);
    CheckExternalEvents(cs12, 0x3C5A);
    // MOV byte ptr [SI + -0x1],AL (19EF_3C57 / 0x1DB47)
    UInt8[DS, (ushort)(SI - 0x1)] = AL;
    CheckExternalEvents(cs12, 0x3C5D);
    // LEA AX,[SI + 0x1] (19EF_3C5A / 0x1DB4A)
    AX = (ushort)(SI + 0x1);
    CheckExternalEvents(cs12, 0x3C5F);
    // CMP AX,DI (19EF_3C5D / 0x1DB4D)
    Alu16.Sub(AX, DI);
    CheckExternalEvents(cs12, 0x3C61);
    // JC 0x1000:db43 (19EF_3C5F / 0x1DB4F)
    if(CarryFlag) {
      goto label_19EF_3C53_1DB43;
    }
    CheckExternalEvents(cs12, 0x3C63);
    // MOV DX,DS (19EF_3C61 / 0x1DB51)
    DX = DS;
    CheckExternalEvents(cs12, 0x3C64);
    // POP AX (19EF_3C63 / 0x1DB53)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3C65);
    // POP DS (19EF_3C64 / 0x1DB54)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3C66);
    // POP DI (19EF_3C65 / 0x1DB55)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3C67);
    // POP SI (19EF_3C66 / 0x1DB56)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3C69);
    // MOV SP,BP (19EF_3C67 / 0x1DB57)
    SP = BP;
    CheckExternalEvents(cs12, 0x3C6A);
    // POP BP (19EF_3C69 / 0x1DB59)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3C6B);
    // RETF  (19EF_3C6A / 0x1DB5A)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_DB5C_1DB5C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DB5C_1DB5C:
    CheckExternalEvents(cs7, 0xDB5D);
    // PUSH BP (1000_DB5C / 0x1DB5C)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xDB5F);
    // MOV BP,SP (1000_DB5D / 0x1DB5D)
    BP = SP;
    CheckExternalEvents(cs7, 0xDB63);
    // CMP word ptr [BP + 0x6],0x0 (1000_DB5F / 0x1DB5F)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs7, 0xDB65);
    // JL 0x1000:db6a (1000_DB63 / 0x1DB63)
    if(SignFlag != OverflowFlag) {
      goto label_1000_DB6A_1DB6A;
    }
    CheckExternalEvents(cs7, 0xDB68);
    // MOV AX,word ptr [BP + 0x6] (1000_DB65 / 0x1DB65)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xDB6A);
    // JMP 0x1000:db6f (1000_DB68 / 0x1DB68)
    goto label_1000_DB6F_1DB6F;
    label_1000_DB6A_1DB6A:
    CheckExternalEvents(cs7, 0xDB6D);
    // MOV AX,word ptr [BP + 0x6] (1000_DB6A / 0x1DB6A)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xDB6F);
    // NEG AX (1000_DB6D / 0x1DB6D)
    AX = Alu16.Sub(0, AX);
    label_1000_DB6F_1DB6F:
    CheckExternalEvents(cs7, 0xDB70);
    // POP BP (1000_DB6F / 0x1DB6F)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xDB71);
    // RETF  (1000_DB70 / 0x1DB70)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_3C82_1DB72(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3C82_1DB72:
    CheckExternalEvents(cs12, 0x3C83);
    // PUSH BP (19EF_3C82 / 0x1DB72)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3C85);
    // MOV BP,SP (19EF_3C83 / 0x1DB73)
    BP = SP;
    CheckExternalEvents(cs12, 0x3C88);
    // LES DX,[BP + 0x6] (19EF_3C85 / 0x1DB75)
    DX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs12, 0x3C8C);
    // MOV word ptr [0x536a],ES (19EF_3C88 / 0x1DB78)
    UInt16[DS, 0x536A] = ES;
    CheckExternalEvents(cs12, 0x3C90);
    // MOV word ptr [0x5368],DX (19EF_3C8C / 0x1DB7C)
    UInt16[DS, 0x5368] = DX;
    CheckExternalEvents(cs12, 0x3C91);
    // PUSH DS (19EF_3C90 / 0x1DB80)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x3C93);
    // MOV AX,CS (19EF_3C91 / 0x1DB81)
    AX = cs12;
    CheckExternalEvents(cs12, 0x3C95);
    // MOV DS,AX (19EF_3C93 / 0x1DB83)
    DS = AX;
    CheckExternalEvents(cs12, 0x3C98);
    // MOV DX,0x3ca5 (19EF_3C95 / 0x1DB85)
    DX = 0x3CA5;
    CheckExternalEvents(cs12, 0x3C9A);
    // MOV AL,0x24 (19EF_3C98 / 0x1DB88)
    AL = 0x24;
    CheckExternalEvents(cs12, 0x3C9C);
    // MOV AH,0x25 (19EF_3C9A / 0x1DB8A)
    AH = 0x25;
    CheckExternalEvents(cs12, 0x3C9E);
    // INT 0x21 (19EF_3C9C / 0x1DB8C)
    Interrupt(0x21);
    CheckExternalEvents(cs12, 0x3C9F);
    // POP DS (19EF_3C9E / 0x1DB8E)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3CA1);
    // XOR AX,AX (19EF_3C9F / 0x1DB8F)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs12, 0x3CA3);
    // MOV SP,BP (19EF_3CA1 / 0x1DB91)
    SP = BP;
    CheckExternalEvents(cs12, 0x3CA4);
    // POP BP (19EF_3CA3 / 0x1DB93)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3CA5);
    // RETF  (19EF_3CA4 / 0x1DB94)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_3D1C_1DC0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3D1C_1DC0C:
    CheckExternalEvents(cs12, 0x3D1D);
    // PUSH BP (19EF_3D1C / 0x1DC0C)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3D1F);
    // MOV BP,SP (19EF_3D1D / 0x1DC0D)
    BP = SP;
    CheckExternalEvents(cs12, 0x3D22);
    // LES BX,[BP + 0x6] (19EF_3D1F / 0x1DC0F)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs12, 0x3D25);
    // PUSH word ptr [BP + 0xc] (19EF_3D22 / 0x1DC12)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs12, 0x3D28);
    // PUSH word ptr [BP + 0xa] (19EF_3D25 / 0x1DC15)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs12, 0x3D2C);
    // PUSH word ptr ES:[BX + 0x2] (19EF_3D28 / 0x1DC18)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x2)]);
    CheckExternalEvents(cs12, 0x3D2F);
    // PUSH word ptr ES:[BX] (19EF_3D2C / 0x1DC1C)
    Stack.Push16(UInt16[ES, (ushort)(BX)]);
    CheckExternalEvents(cs12, 0x3D34);
    // CALLF 0x1000:dd1e (19EF_3D2F / 0x1DC1F)
    FarCall(cs12, 0x3D34, unknown_19EF_3E2E_1DD1E);
    CheckExternalEvents(cs12, 0x3D37);
    // LES BX,[BP + 0x6] (19EF_3D34 / 0x1DC24)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs12, 0x3D3A);
    // MOV word ptr ES:[BX],AX (19EF_3D37 / 0x1DC27)
    UInt16[ES, (ushort)(BX)] = AX;
    CheckExternalEvents(cs12, 0x3D3E);
    // MOV word ptr ES:[BX + 0x2],DX (19EF_3D3A / 0x1DC2A)
    UInt16[ES, (ushort)(BX + 0x2)] = DX;
    CheckExternalEvents(cs12, 0x3D40);
    // MOV SP,BP (19EF_3D3E / 0x1DC2E)
    SP = BP;
    CheckExternalEvents(cs12, 0x3D41);
    // POP BP (19EF_3D40 / 0x1DC30)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3D44);
    // RETF 0x8 (19EF_3D41 / 0x1DC31)
    return FarRet(0x8);
  }
  
  public virtual Action unknown_19EF_3D44_1DC34(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3D44_1DC34:
    CheckExternalEvents(cs12, 0x3D45);
    // PUSH BP (19EF_3D44 / 0x1DC34)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3D47);
    // MOV BP,SP (19EF_3D45 / 0x1DC35)
    BP = SP;
    CheckExternalEvents(cs12, 0x3D4A);
    // LES BX,[BP + 0x6] (19EF_3D47 / 0x1DC37)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs12, 0x3D4D);
    // PUSH word ptr [BP + 0xc] (19EF_3D4A / 0x1DC3A)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs12, 0x3D50);
    // PUSH word ptr [BP + 0xa] (19EF_3D4D / 0x1DC3D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs12, 0x3D54);
    // PUSH word ptr ES:[BX + 0x2] (19EF_3D50 / 0x1DC40)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x2)]);
    CheckExternalEvents(cs12, 0x3D57);
    // PUSH word ptr ES:[BX] (19EF_3D54 / 0x1DC44)
    Stack.Push16(UInt16[ES, (ushort)(BX)]);
    CheckExternalEvents(cs12, 0x3D5C);
    // CALLF 0x1000:dd52 (19EF_3D57 / 0x1DC47)
    FarCall(cs12, 0x3D5C, unknown_19EF_3E62_1DD52);
    CheckExternalEvents(cs12, 0x3D5F);
    // LES BX,[BP + 0x6] (19EF_3D5C / 0x1DC4C)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs12, 0x3D63);
    // MOV word ptr ES:[BX + 0x2],DX (19EF_3D5F / 0x1DC4F)
    UInt16[ES, (ushort)(BX + 0x2)] = DX;
    CheckExternalEvents(cs12, 0x3D66);
    // MOV word ptr ES:[BX],AX (19EF_3D63 / 0x1DC53)
    UInt16[ES, (ushort)(BX)] = AX;
    CheckExternalEvents(cs12, 0x3D68);
    // MOV SP,BP (19EF_3D66 / 0x1DC56)
    SP = BP;
    CheckExternalEvents(cs12, 0x3D69);
    // POP BP (19EF_3D68 / 0x1DC58)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3D6C);
    // RETF 0x8 (19EF_3D69 / 0x1DC59)
    return FarRet(0x8);
  }
  
  public virtual Action ghidra_guess_1000_DC5C_1DC5C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DC5C_1DC5C:
    CheckExternalEvents(cs7, 0xDC5D);
    // PUSH BP (1000_DC5C / 0x1DC5C)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xDC5F);
    // MOV BP,SP (1000_DC5D / 0x1DC5D)
    BP = SP;
    CheckExternalEvents(cs7, 0xDC62);
    // LES BX,[BP + 0x6] (1000_DC5F / 0x1DC5F)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs7, 0xDC65);
    // MOV AX,word ptr ES:[BX] (1000_DC62 / 0x1DC62)
    AX = UInt16[ES, (ushort)(BX)];
    CheckExternalEvents(cs7, 0xDC69);
    // MOV DX,word ptr ES:[BX + 0x2] (1000_DC65 / 0x1DC65)
    DX = UInt16[ES, (ushort)(BX + 0x2)];
    CheckExternalEvents(cs7, 0xDC6C);
    // MOV CX,word ptr [BP + 0xa] (1000_DC69 / 0x1DC69)
    CX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0xDC71);
    // CALLF 0x1000:ddb4 (1000_DC6C / 0x1DC6C)
    FarCall(cs7, 0xDC71, ghidra_guess_1000_DDB4_1DDB4);
    CheckExternalEvents(cs7, 0xDC74);
    // LES BX,[BP + 0x6] (1000_DC71 / 0x1DC71)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs7, 0xDC77);
    // MOV word ptr ES:[BX],AX (1000_DC74 / 0x1DC74)
    UInt16[ES, (ushort)(BX)] = AX;
    CheckExternalEvents(cs7, 0xDC7B);
    // MOV word ptr ES:[BX + 0x2],DX (1000_DC77 / 0x1DC77)
    UInt16[ES, (ushort)(BX + 0x2)] = DX;
    CheckExternalEvents(cs7, 0xDC7D);
    // MOV SP,BP (1000_DC7B / 0x1DC7B)
    SP = BP;
    CheckExternalEvents(cs7, 0xDC7E);
    // POP BP (1000_DC7D / 0x1DC7D)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xDC81);
    // RETF 0x6 (1000_DC7E / 0x1DC7E)
    return FarRet(0x6);
  }
  
  public virtual Action unknown_19EF_3D92_1DC82(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3D92_1DC82:
    CheckExternalEvents(cs12, 0x3D93);
    // PUSH BP (19EF_3D92 / 0x1DC82)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3D95);
    // MOV BP,SP (19EF_3D93 / 0x1DC83)
    BP = SP;
    CheckExternalEvents(cs12, 0x3D96);
    // PUSH DI (19EF_3D95 / 0x1DC85)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x3D97);
    // PUSH SI (19EF_3D96 / 0x1DC86)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x3D98);
    // PUSH BX (19EF_3D97 / 0x1DC87)
    Stack.Push16(BX);
    CheckExternalEvents(cs12, 0x3D9A);
    // XOR DI,DI (19EF_3D98 / 0x1DC88)
    // DI ^= DI;
    DI = Alu16.Xor(DI, DI);
    CheckExternalEvents(cs12, 0x3D9D);
    // MOV AX,word ptr [BP + 0x8] (19EF_3D9A / 0x1DC8A)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x3D9F);
    // OR AX,AX (19EF_3D9D / 0x1DC8D)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs12, 0x3DA1);
    // JGE 0x1000:dca2 (19EF_3D9F / 0x1DC8F)
    if(SignFlag == OverflowFlag) {
      goto label_19EF_3DB2_1DCA2;
    }
    CheckExternalEvents(cs12, 0x3DA2);
    // INC DI (19EF_3DA1 / 0x1DC91)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs12, 0x3DA5);
    // MOV DX,word ptr [BP + 0x6] (19EF_3DA2 / 0x1DC92)
    DX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3DA7);
    // NEG AX (19EF_3DA5 / 0x1DC95)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs12, 0x3DA9);
    // NEG DX (19EF_3DA7 / 0x1DC97)
    DX = Alu16.Sub(0, DX);
    CheckExternalEvents(cs12, 0x3DAC);
    // SBB AX,0x0 (19EF_3DA9 / 0x1DC99)
    AX = Alu16.Sbb(AX, 0x0);
    CheckExternalEvents(cs12, 0x3DAF);
    // MOV word ptr [BP + 0x8],AX (19EF_3DAC / 0x1DC9C)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    CheckExternalEvents(cs12, 0x3DB2);
    // MOV word ptr [BP + 0x6],DX (19EF_3DAF / 0x1DC9F)
    UInt16[SS, (ushort)(BP + 0x6)] = DX;
    label_19EF_3DB2_1DCA2:
    CheckExternalEvents(cs12, 0x3DB5);
    // MOV AX,word ptr [BP + 0xc] (19EF_3DB2 / 0x1DCA2)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs12, 0x3DB7);
    // OR AX,AX (19EF_3DB5 / 0x1DCA5)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs12, 0x3DB9);
    // JGE 0x1000:dcba (19EF_3DB7 / 0x1DCA7)
    if(SignFlag == OverflowFlag) {
      goto label_19EF_3DCA_1DCBA;
    }
    CheckExternalEvents(cs12, 0x3DBA);
    // INC DI (19EF_3DB9 / 0x1DCA9)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs12, 0x3DBD);
    // MOV DX,word ptr [BP + 0xa] (19EF_3DBA / 0x1DCAA)
    DX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x3DBF);
    // NEG AX (19EF_3DBD / 0x1DCAD)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs12, 0x3DC1);
    // NEG DX (19EF_3DBF / 0x1DCAF)
    DX = Alu16.Sub(0, DX);
    CheckExternalEvents(cs12, 0x3DC4);
    // SBB AX,0x0 (19EF_3DC1 / 0x1DCB1)
    AX = Alu16.Sbb(AX, 0x0);
    CheckExternalEvents(cs12, 0x3DC7);
    // MOV word ptr [BP + 0xc],AX (19EF_3DC4 / 0x1DCB4)
    UInt16[SS, (ushort)(BP + 0xC)] = AX;
    CheckExternalEvents(cs12, 0x3DCA);
    // MOV word ptr [BP + 0xa],DX (19EF_3DC7 / 0x1DCB7)
    UInt16[SS, (ushort)(BP + 0xA)] = DX;
    label_19EF_3DCA_1DCBA:
    CheckExternalEvents(cs12, 0x3DCC);
    // OR AX,AX (19EF_3DCA / 0x1DCBA)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs12, 0x3DCE);
    // JNZ 0x1000:dcd3 (19EF_3DCC / 0x1DCBC)
    if(!ZeroFlag) {
      goto label_19EF_3DE3_1DCD3;
    }
    CheckExternalEvents(cs12, 0x3DD1);
    // MOV CX,word ptr [BP + 0xa] (19EF_3DCE / 0x1DCBE)
    CX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x3DD4);
    // MOV AX,word ptr [BP + 0x8] (19EF_3DD1 / 0x1DCC1)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x3DD6);
    // XOR DX,DX (19EF_3DD4 / 0x1DCC4)
    DX = 0;
    CheckExternalEvents(cs12, 0x3DD8);
    // DIV CX (19EF_3DD6 / 0x1DCC6)
    uint op1Div19EF_3DD6 = (DX << 16 | AX);
    ushort op2Div19EF_3DD6 = CX;
    ushort? resDiv19EF_3DD6 = Alu16.Div(op1Div19EF_3DD6, op2Div19EF_3DD6);
    if(resDiv19EF_3DD6 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = resDiv19EF_3DD6.Value;
    DX = (ushort)(op1Div19EF_3DD6 % op2Div19EF_3DD6);
    CheckExternalEvents(cs12, 0x3DDA);
    // MOV BX,AX (19EF_3DD8 / 0x1DCC8)
    BX = AX;
    CheckExternalEvents(cs12, 0x3DDD);
    // MOV AX,word ptr [BP + 0x6] (19EF_3DDA / 0x1DCCA)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3DDF);
    // DIV CX (19EF_3DDD / 0x1DCCD)
    uint op1Div19EF_3DDD = (DX << 16 | AX);
    ushort op2Div19EF_3DDD = CX;
    ushort? resDiv19EF_3DDD = Alu16.Div(op1Div19EF_3DDD, op2Div19EF_3DDD);
    if(resDiv19EF_3DDD == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = resDiv19EF_3DDD.Value;
    DX = (ushort)(op1Div19EF_3DDD % op2Div19EF_3DDD);
    CheckExternalEvents(cs12, 0x3DE1);
    // MOV DX,BX (19EF_3DDF / 0x1DCCF)
    DX = BX;
    CheckExternalEvents(cs12, 0x3DE3);
    // JMP 0x1000:dd0b (19EF_3DE1 / 0x1DCD1)
    goto label_19EF_3E1B_1DD0B;
    label_19EF_3DE3_1DCD3:
    CheckExternalEvents(cs12, 0x3DE5);
    // MOV BX,AX (19EF_3DE3 / 0x1DCD3)
    BX = AX;
    CheckExternalEvents(cs12, 0x3DE8);
    // MOV CX,word ptr [BP + 0xa] (19EF_3DE5 / 0x1DCD5)
    CX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x3DEB);
    // MOV DX,word ptr [BP + 0x8] (19EF_3DE8 / 0x1DCD8)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x3DEE);
    // MOV AX,word ptr [BP + 0x6] (19EF_3DEB / 0x1DCDB)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    label_19EF_3DEE_1DCDE:
    CheckExternalEvents(cs12, 0x3DF0);
    // SHR BX,0x1 (19EF_3DEE / 0x1DCDE)
    // BX >>= 0x1;
    BX = Alu16.Shr(BX, 0x1);
    CheckExternalEvents(cs12, 0x3DF2);
    // RCR CX,0x1 (19EF_3DF0 / 0x1DCE0)
    CX = Alu16.Rcr(CX, 0x1);
    CheckExternalEvents(cs12, 0x3DF4);
    // SHR DX,0x1 (19EF_3DF2 / 0x1DCE2)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs12, 0x3DF6);
    // RCR AX,0x1 (19EF_3DF4 / 0x1DCE4)
    AX = Alu16.Rcr(AX, 0x1);
    CheckExternalEvents(cs12, 0x3DF8);
    // OR BX,BX (19EF_3DF6 / 0x1DCE6)
    // BX |= BX;
    BX = Alu16.Or(BX, BX);
    CheckExternalEvents(cs12, 0x3DFA);
    // JNZ 0x1000:dcde (19EF_3DF8 / 0x1DCE8)
    if(!ZeroFlag) {
      goto label_19EF_3DEE_1DCDE;
    }
    CheckExternalEvents(cs12, 0x3DFC);
    // DIV CX (19EF_3DFA / 0x1DCEA)
    uint op1Div19EF_3DFA = (DX << 16 | AX);
    ushort op2Div19EF_3DFA = CX;
    ushort? resDiv19EF_3DFA = Alu16.Div(op1Div19EF_3DFA, op2Div19EF_3DFA);
    if(resDiv19EF_3DFA == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = resDiv19EF_3DFA.Value;
    DX = (ushort)(op1Div19EF_3DFA % op2Div19EF_3DFA);
    CheckExternalEvents(cs12, 0x3DFE);
    // MOV SI,AX (19EF_3DFC / 0x1DCEC)
    SI = AX;
    CheckExternalEvents(cs12, 0x3E01);
    // MUL word ptr [BP + 0xc] (19EF_3DFE / 0x1DCEE)
    uint resMul19EF_3DFE = Alu16.Mul(AX, UInt16[SS, (ushort)(BP + 0xC)]);
    AX = (ushort)(resMul19EF_3DFE);
    DX = (ushort)(resMul19EF_3DFE >> 16);
    CheckExternalEvents(cs12, 0x3E02);
    // XCHG AX,CX (19EF_3E01 / 0x1DCF1)
    (CX, AX) = (AX, CX);
    CheckExternalEvents(cs12, 0x3E05);
    // MOV AX,word ptr [BP + 0xa] (19EF_3E02 / 0x1DCF2)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x3E07);
    // MUL SI (19EF_3E05 / 0x1DCF5)
    uint resMul19EF_3E05 = Alu16.Mul(AX, SI);
    AX = (ushort)(resMul19EF_3E05);
    DX = (ushort)(resMul19EF_3E05 >> 16);
    CheckExternalEvents(cs12, 0x3E09);
    // ADD DX,CX (19EF_3E07 / 0x1DCF7)
    // DX += CX;
    DX = Alu16.Add(DX, CX);
    CheckExternalEvents(cs12, 0x3E0B);
    // JC 0x1000:dd07 (19EF_3E09 / 0x1DCF9)
    if(CarryFlag) {
      goto label_19EF_3E17_1DD07;
    }
    CheckExternalEvents(cs12, 0x3E0E);
    // CMP DX,word ptr [BP + 0x8] (19EF_3E0B / 0x1DCFB)
    Alu16.Sub(DX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs12, 0x3E10);
    // JA 0x1000:dd07 (19EF_3E0E / 0x1DCFE)
    if(!CarryFlag && !ZeroFlag) {
      goto label_19EF_3E17_1DD07;
    }
    CheckExternalEvents(cs12, 0x3E12);
    // JC 0x1000:dd08 (19EF_3E10 / 0x1DD00)
    if(CarryFlag) {
      goto label_19EF_3E18_1DD08;
    }
    CheckExternalEvents(cs12, 0x3E15);
    // CMP AX,word ptr [BP + 0x6] (19EF_3E12 / 0x1DD02)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs12, 0x3E17);
    // JBE 0x1000:dd08 (19EF_3E15 / 0x1DD05)
    if(CarryFlag || ZeroFlag) {
      goto label_19EF_3E18_1DD08;
    }
    label_19EF_3E17_1DD07:
    CheckExternalEvents(cs12, 0x3E18);
    // DEC SI (19EF_3E17 / 0x1DD07)
    SI--;
    label_19EF_3E18_1DD08:
    CheckExternalEvents(cs12, 0x3E1A);
    // XOR DX,DX (19EF_3E18 / 0x1DD08)
    // DX ^= DX;
    DX = Alu16.Xor(DX, DX);
    CheckExternalEvents(cs12, 0x3E1B);
    // XCHG AX,SI (19EF_3E1A / 0x1DD0A)
    (SI, AX) = (AX, SI);
    label_19EF_3E1B_1DD0B:
    CheckExternalEvents(cs12, 0x3E1C);
    // DEC DI (19EF_3E1B / 0x1DD0B)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs12, 0x3E1E);
    // JNZ 0x1000:dd15 (19EF_3E1C / 0x1DD0C)
    if(!ZeroFlag) {
      goto label_19EF_3E25_1DD15;
    }
    CheckExternalEvents(cs12, 0x3E20);
    // NEG DX (19EF_3E1E / 0x1DD0E)
    DX = Alu16.Sub(0, DX);
    CheckExternalEvents(cs12, 0x3E22);
    // NEG AX (19EF_3E20 / 0x1DD10)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs12, 0x3E25);
    // SBB DX,0x0 (19EF_3E22 / 0x1DD12)
    DX = Alu16.Sbb(DX, 0x0);
    label_19EF_3E25_1DD15:
    CheckExternalEvents(cs12, 0x3E26);
    // POP BX (19EF_3E25 / 0x1DD15)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3E27);
    // POP SI (19EF_3E26 / 0x1DD16)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3E28);
    // POP DI (19EF_3E27 / 0x1DD17)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3E2A);
    // MOV SP,BP (19EF_3E28 / 0x1DD18)
    SP = BP;
    CheckExternalEvents(cs12, 0x3E2B);
    // POP BP (19EF_3E2A / 0x1DD1A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3E2E);
    // RETF 0x8 (19EF_3E2B / 0x1DD1B)
    return FarRet(0x8);
  }
  
  public virtual Action unknown_19EF_3E2E_1DD1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3E2E_1DD1E:
    CheckExternalEvents(cs12, 0x3E2F);
    // PUSH BP (19EF_3E2E / 0x1DD1E)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3E31);
    // MOV BP,SP (19EF_3E2F / 0x1DD1F)
    BP = SP;
    CheckExternalEvents(cs12, 0x3E34);
    // MOV AX,word ptr [BP + 0x8] (19EF_3E31 / 0x1DD21)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x3E37);
    // MOV BX,word ptr [BP + 0xc] (19EF_3E34 / 0x1DD24)
    BX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs12, 0x3E39);
    // OR BX,AX (19EF_3E37 / 0x1DD27)
    // BX |= AX;
    BX = Alu16.Or(BX, AX);
    CheckExternalEvents(cs12, 0x3E3C);
    // MOV BX,word ptr [BP + 0xa] (19EF_3E39 / 0x1DD29)
    BX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x3E3E);
    // JNZ 0x1000:dd39 (19EF_3E3C / 0x1DD2C)
    if(!ZeroFlag) {
      goto label_19EF_3E49_1DD39;
    }
    CheckExternalEvents(cs12, 0x3E41);
    // MOV AX,word ptr [BP + 0x6] (19EF_3E3E / 0x1DD2E)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3E43);
    // MUL BX (19EF_3E41 / 0x1DD31)
    uint resMul19EF_3E41 = Alu16.Mul(AX, BX);
    AX = (ushort)(resMul19EF_3E41);
    DX = (ushort)(resMul19EF_3E41 >> 16);
    CheckExternalEvents(cs12, 0x3E45);
    // MOV SP,BP (19EF_3E43 / 0x1DD33)
    SP = BP;
    CheckExternalEvents(cs12, 0x3E46);
    // POP BP (19EF_3E45 / 0x1DD35)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3E49);
    // RETF 0x8 (19EF_3E46 / 0x1DD36)
    return FarRet(0x8);
    label_19EF_3E49_1DD39:
    CheckExternalEvents(cs12, 0x3E4B);
    // MUL BX (19EF_3E49 / 0x1DD39)
    uint resMul19EF_3E49 = Alu16.Mul(AX, BX);
    AX = (ushort)(resMul19EF_3E49);
    DX = (ushort)(resMul19EF_3E49 >> 16);
    CheckExternalEvents(cs12, 0x3E4D);
    // MOV CX,AX (19EF_3E4B / 0x1DD3B)
    CX = AX;
    CheckExternalEvents(cs12, 0x3E50);
    // MOV AX,word ptr [BP + 0x6] (19EF_3E4D / 0x1DD3D)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3E53);
    // MUL word ptr [BP + 0xc] (19EF_3E50 / 0x1DD40)
    uint resMul19EF_3E50 = Alu16.Mul(AX, UInt16[SS, (ushort)(BP + 0xC)]);
    AX = (ushort)(resMul19EF_3E50);
    DX = (ushort)(resMul19EF_3E50 >> 16);
    CheckExternalEvents(cs12, 0x3E55);
    // ADD CX,AX (19EF_3E53 / 0x1DD43)
    // CX += AX;
    CX = Alu16.Add(CX, AX);
    CheckExternalEvents(cs12, 0x3E58);
    // MOV AX,word ptr [BP + 0x6] (19EF_3E55 / 0x1DD45)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3E5A);
    // MUL BX (19EF_3E58 / 0x1DD48)
    uint resMul19EF_3E58 = Alu16.Mul(AX, BX);
    AX = (ushort)(resMul19EF_3E58);
    DX = (ushort)(resMul19EF_3E58 >> 16);
    CheckExternalEvents(cs12, 0x3E5C);
    // ADD DX,CX (19EF_3E5A / 0x1DD4A)
    // DX += CX;
    DX = Alu16.Add(DX, CX);
    CheckExternalEvents(cs12, 0x3E5E);
    // MOV SP,BP (19EF_3E5C / 0x1DD4C)
    SP = BP;
    CheckExternalEvents(cs12, 0x3E5F);
    // POP BP (19EF_3E5E / 0x1DD4E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3E62);
    // RETF 0x8 (19EF_3E5F / 0x1DD4F)
    return FarRet(0x8);
  }
  
  public virtual Action unknown_19EF_3E62_1DD52(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3E62_1DD52:
    CheckExternalEvents(cs12, 0x3E63);
    // PUSH BP (19EF_3E62 / 0x1DD52)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3E65);
    // MOV BP,SP (19EF_3E63 / 0x1DD53)
    BP = SP;
    CheckExternalEvents(cs12, 0x3E66);
    // PUSH BX (19EF_3E65 / 0x1DD55)
    Stack.Push16(BX);
    CheckExternalEvents(cs12, 0x3E67);
    // PUSH SI (19EF_3E66 / 0x1DD56)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x3E6A);
    // MOV AX,word ptr [BP + 0xc] (19EF_3E67 / 0x1DD57)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs12, 0x3E6C);
    // OR AX,AX (19EF_3E6A / 0x1DD5A)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs12, 0x3E6E);
    // JNZ 0x1000:dd73 (19EF_3E6C / 0x1DD5C)
    if(!ZeroFlag) {
      goto label_19EF_3E83_1DD73;
    }
    CheckExternalEvents(cs12, 0x3E71);
    // MOV CX,word ptr [BP + 0xa] (19EF_3E6E / 0x1DD5E)
    CX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x3E74);
    // MOV AX,word ptr [BP + 0x8] (19EF_3E71 / 0x1DD61)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x3E76);
    // XOR DX,DX (19EF_3E74 / 0x1DD64)
    DX = 0;
    CheckExternalEvents(cs12, 0x3E78);
    // DIV CX (19EF_3E76 / 0x1DD66)
    uint op1Div19EF_3E76 = (uint)(DX << 16 | AX);
    ushort op2Div19EF_3E76 = CX;
    ushort? resDiv19EF_3E76 = Alu16.Div(op1Div19EF_3E76, op2Div19EF_3E76);
    if(resDiv19EF_3E76 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = resDiv19EF_3E76.Value;
    DX = (ushort)(op1Div19EF_3E76 % op2Div19EF_3E76);
    CheckExternalEvents(cs12, 0x3E7A);
    // MOV BX,AX (19EF_3E78 / 0x1DD68)
    BX = AX;
    CheckExternalEvents(cs12, 0x3E7D);
    // MOV AX,word ptr [BP + 0x6] (19EF_3E7A / 0x1DD6A)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x3E7F);
    // DIV CX (19EF_3E7D / 0x1DD6D)
    uint op1Div19EF_3E7D = (uint)(DX << 16 | AX);
    ushort op2Div19EF_3E7D = CX;
    ushort? resDiv19EF_3E7D = Alu16.Div(op1Div19EF_3E7D, op2Div19EF_3E7D);
    if(resDiv19EF_3E7D == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = resDiv19EF_3E7D.Value;
    DX = (ushort)(op1Div19EF_3E7D % op2Div19EF_3E7D);
    CheckExternalEvents(cs12, 0x3E81);
    // MOV DX,BX (19EF_3E7F / 0x1DD6F)
    DX = BX;
    CheckExternalEvents(cs12, 0x3E83);
    // JMP 0x1000:ddab (19EF_3E81 / 0x1DD71)
    goto label_19EF_3EBB_1DDAB;
    label_19EF_3E83_1DD73:
    CheckExternalEvents(cs12, 0x3E85);
    // MOV CX,AX (19EF_3E83 / 0x1DD73)
    CX = AX;
    CheckExternalEvents(cs12, 0x3E88);
    // MOV BX,word ptr [BP + 0xa] (19EF_3E85 / 0x1DD75)
    BX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x3E8B);
    // MOV DX,word ptr [BP + 0x8] (19EF_3E88 / 0x1DD78)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x3E8E);
    // MOV AX,word ptr [BP + 0x6] (19EF_3E8B / 0x1DD7B)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    label_19EF_3E8E_1DD7E:
    CheckExternalEvents(cs12, 0x3E90);
    // SHR CX,0x1 (19EF_3E8E / 0x1DD7E)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    CheckExternalEvents(cs12, 0x3E92);
    // RCR BX,0x1 (19EF_3E90 / 0x1DD80)
    BX = Alu16.Rcr(BX, 0x1);
    CheckExternalEvents(cs12, 0x3E94);
    // SHR DX,0x1 (19EF_3E92 / 0x1DD82)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs12, 0x3E96);
    // RCR AX,0x1 (19EF_3E94 / 0x1DD84)
    AX = Alu16.Rcr(AX, 0x1);
    CheckExternalEvents(cs12, 0x3E98);
    // OR CX,CX (19EF_3E96 / 0x1DD86)
    // CX |= CX;
    CX = Alu16.Or(CX, CX);
    CheckExternalEvents(cs12, 0x3E9A);
    // JNZ 0x1000:dd7e (19EF_3E98 / 0x1DD88)
    if(!ZeroFlag) {
      goto label_19EF_3E8E_1DD7E;
    }
    CheckExternalEvents(cs12, 0x3E9C);
    // DIV BX (19EF_3E9A / 0x1DD8A)
    uint op1Div19EF_3E9A = (uint)(DX << 16 | AX);
    ushort op2Div19EF_3E9A = BX;
    ushort? resDiv19EF_3E9A = Alu16.Div(op1Div19EF_3E9A, op2Div19EF_3E9A);
    if(resDiv19EF_3E9A == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = resDiv19EF_3E9A.Value;
    DX = (ushort)(op1Div19EF_3E9A % op2Div19EF_3E9A);
    CheckExternalEvents(cs12, 0x3E9E);
    // MOV SI,AX (19EF_3E9C / 0x1DD8C)
    SI = AX;
    CheckExternalEvents(cs12, 0x3EA1);
    // MUL word ptr [BP + 0xc] (19EF_3E9E / 0x1DD8E)
    uint resMul19EF_3E9E = Alu16.Mul(AX, UInt16[SS, (ushort)(BP + 0xC)]);
    AX = (ushort)(resMul19EF_3E9E);
    DX = (ushort)(resMul19EF_3E9E >> 16);
    CheckExternalEvents(cs12, 0x3EA2);
    // XCHG AX,CX (19EF_3EA1 / 0x1DD91)
    (CX, AX) = (AX, CX);
    CheckExternalEvents(cs12, 0x3EA5);
    // MOV AX,word ptr [BP + 0xa] (19EF_3EA2 / 0x1DD92)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x3EA7);
    // MUL SI (19EF_3EA5 / 0x1DD95)
    uint resMul19EF_3EA5 = Alu16.Mul(AX, SI);
    AX = (ushort)(resMul19EF_3EA5);
    DX = (ushort)(resMul19EF_3EA5 >> 16);
    CheckExternalEvents(cs12, 0x3EA9);
    // ADD DX,CX (19EF_3EA7 / 0x1DD97)
    // DX += CX;
    DX = Alu16.Add(DX, CX);
    CheckExternalEvents(cs12, 0x3EAB);
    // JC 0x1000:dda7 (19EF_3EA9 / 0x1DD99)
    if(CarryFlag) {
      goto label_19EF_3EB7_1DDA7;
    }
    CheckExternalEvents(cs12, 0x3EAE);
    // CMP DX,word ptr [BP + 0x8] (19EF_3EAB / 0x1DD9B)
    Alu16.Sub(DX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs12, 0x3EB0);
    // JA 0x1000:dda7 (19EF_3EAE / 0x1DD9E)
    if(!CarryFlag && !ZeroFlag) {
      goto label_19EF_3EB7_1DDA7;
    }
    CheckExternalEvents(cs12, 0x3EB2);
    // JC 0x1000:dda8 (19EF_3EB0 / 0x1DDA0)
    if(CarryFlag) {
      goto label_19EF_3EB8_1DDA8;
    }
    CheckExternalEvents(cs12, 0x3EB5);
    // CMP AX,word ptr [BP + 0x6] (19EF_3EB2 / 0x1DDA2)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs12, 0x3EB7);
    // JBE 0x1000:dda8 (19EF_3EB5 / 0x1DDA5)
    if(CarryFlag || ZeroFlag) {
      goto label_19EF_3EB8_1DDA8;
    }
    label_19EF_3EB7_1DDA7:
    CheckExternalEvents(cs12, 0x3EB8);
    // DEC SI (19EF_3EB7 / 0x1DDA7)
    SI--;
    label_19EF_3EB8_1DDA8:
    CheckExternalEvents(cs12, 0x3EBA);
    // XOR DX,DX (19EF_3EB8 / 0x1DDA8)
    // DX ^= DX;
    DX = Alu16.Xor(DX, DX);
    CheckExternalEvents(cs12, 0x3EBB);
    // XCHG AX,SI (19EF_3EBA / 0x1DDAA)
    (SI, AX) = (AX, SI);
    label_19EF_3EBB_1DDAB:
    CheckExternalEvents(cs12, 0x3EBC);
    // POP SI (19EF_3EBB / 0x1DDAB)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3EBD);
    // POP BX (19EF_3EBC / 0x1DDAC)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3EBF);
    // MOV SP,BP (19EF_3EBD / 0x1DDAD)
    SP = BP;
    CheckExternalEvents(cs12, 0x3EC0);
    // POP BP (19EF_3EBF / 0x1DDAF)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x3EC3);
    // RETF 0x8 (19EF_3EC0 / 0x1DDB0)
    return FarRet(0x8);
  }
  
  public virtual Action ghidra_guess_1000_DDB4_1DDB4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_DDB4_1DDB4:
    CheckExternalEvents(cs7, 0xDDB6);
    // XOR CH,CH (1000_DDB4 / 0x1DDB4)
    // CH ^= CH;
    CH = Alu8.Xor(CH, CH);
    CheckExternalEvents(cs7, 0xDDB8);
    // JCXZ 0x1000:ddbe (1000_DDB6 / 0x1DDB6)
    if(CX == 0) {
      // JCXZ target is RETF, inlining.
      CheckExternalEvents(cs7, 0xDDBF);
      // RETF  (1000_DDBE / 0x1DDBE)
      return FarRet();
    }
    label_1000_DDB8_1DDB8:
    CheckExternalEvents(cs7, 0xDDBA);
    // SHR DX,0x1 (1000_DDB8 / 0x1DDB8)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs7, 0xDDBC);
    // RCR AX,0x1 (1000_DDBA / 0x1DDBA)
    AX = Alu16.Rcr(AX, 0x1);
    CheckExternalEvents(cs7, 0xDDBE);
    // LOOP 0x1000:ddb8 (1000_DDBC / 0x1DDBC)
    if(--CX != 0) {
      goto label_1000_DDB8_1DDB8;
    }
    label_1000_DDBE_1DDBE:
    CheckExternalEvents(cs7, 0xDDBF);
    // RETF  (1000_DDBE / 0x1DDBE)
    return FarRet();
  }
  
  public virtual Action split_1000_E6D1_1E6D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E6D1_1E6D1:
    CheckExternalEvents(cs7, 0xE6D2);
    // POPA  (1000_E6D1 / 0x1E6D1)
    DI = Stack.Pop16();;
    SI = Stack.Pop16();;
    BP = Stack.Pop16();;
    // not restoring SP, popping emptyStack.Pop16();
    BX = Stack.Pop16();;
    DX = Stack.Pop16();;
    CX = Stack.Pop16();;
    AX = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xE6D3);
    // INSW ES:DI,DX (1000_E6D2 / 0x1E6D2)
    UInt16[ES, (ushort)(DI)] = Cpu.In16(DX);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs7, 0xE6D4);
    // POP SI (1000_E6D3 / 0x1E6D3)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xE6D5);
    // POP SI (1000_E6D4 / 0x1E6D4)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xE6D7);
    // AAD 0x45 (1000_E6D5 / 0x1E6D5)
    Cpu.Aad(0x45);
    CheckExternalEvents(cs7, 0xE6D9);
    // DIV CL (1000_E6D7 / 0x1E6D7)
    ushort op1Div1000_E6D7 = AX;
    byte op2Div1000_E6D7 = CL;
    byte? resDiv1000_E6D7 = Alu8.Div(op1Div1000_E6D7, op2Div1000_E6D7);
    if(resDiv1000_E6D7 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AL = resDiv1000_E6D7.Value;
    AH = (byte)(op1Div1000_E6D7 % op2Div1000_E6D7);
    CheckExternalEvents(cs7, 0xE6DA);
    // INT1  (1000_E6D9 / 0x1E6D9)
    throw FailAsUntested("Unimplemented Instruction!");
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action split_1000_E903_1E903(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_E903_1E903:
    CheckExternalEvents(cs7, 0xE906);
    // AND byte ptr SS:[BX + DI],CL (1000_E903 / 0x1E903)
    UInt8[SS, (ushort)(BX + DI)] &= CL;
    CheckExternalEvents(cs7, 0xE907);
    // AAA  (1000_E906 / 0x1E906)
    Cpu.Aaa();
    CheckExternalEvents(cs7, 0xE90B);
    // ADD byte ptr [0x324],AL (1000_E907 / 0x1E907)
    UInt8[DS, 0x324] += AL;
    CheckExternalEvents(cs7, 0xE90D);
    // ADD byte ptr [BX],AL (1000_E90B / 0x1E90B)
    UInt8[DS, (ushort)(BX)] += AL;
    CheckExternalEvents(cs7, 0xE90F);
    // XOR word ptr [BP + DI],AX (1000_E90D / 0x1E90D)
    UInt16[SS, (ushort)(BP + DI)] ^= AX;
    CheckExternalEvents(cs7, 0xE912);
    // CMP AX,0x4850 (1000_E90F / 0x1E90F)
    Alu16.Sub(AX, 0x4850);
    CheckExternalEvents(cs7, 0xE916);
    // ADC byte ptr SS:[BX + SI + 0x6],AL (1000_E912 / 0x1E912)
    UInt8[SS, (ushort)(BX + SI + 0x6)] = Alu8.Adc(UInt8[SS, (ushort)(BX + SI + 0x6)], AL);
    CheckExternalEvents(cs7, 0xE917);
    // DAA  (1000_E916 / 0x1E916)
    Cpu.Daa();
    CheckExternalEvents(cs7, 0xE918);
    // INC CX (1000_E917 / 0x1E917)
    CX++;
    CheckExternalEvents(cs7, 0xE91A);
    // XOR DX,word ptr [DI] (1000_E918 / 0x1E918)
    DX ^= UInt16[DS, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xE91C);
    // ADD AL,byte ptr [BX + SI] (1000_E91A / 0x1E91A)
    // AL += UInt8[DS, (ushort)(BX + SI)];
    AL = Alu8.Add(AL, UInt8[DS, (ushort)(BX + SI)]);
    CheckExternalEvents(cs7, 0xE91D);
    // PUSH ES (1000_E91C / 0x1E91C)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xE91F);
    // AND AX,word ptr [BX + DI] (1000_E91D / 0x1E91D)
    AX &= UInt16[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs7, 0xE922);
    // AND byte ptr [BP + 0x24],AL (1000_E91F / 0x1E91F)
    // UInt8[SS, (ushort)(BP + 0x24)] &= AL;
    UInt8[SS, (ushort)(BP + 0x24)] = Alu8.And(UInt8[SS, (ushort)(BP + 0x24)], AL);
    CheckExternalEvents(cs7, 0xE924);
    // ADC word ptr [BP + DI],DX (1000_E922 / 0x1E922)
    UInt16[SS, (ushort)(BP + DI)] = Alu16.Adc(UInt16[SS, (ushort)(BP + DI)], DX);
    CheckExternalEvents(cs7, 0xE926);
    // ADC word ptr [BX + SI],AX (1000_E924 / 0x1E924)
    UInt16[DS, (ushort)(BX + SI)] = Alu16.Adc(UInt16[DS, (ushort)(BX + SI)], AX);
    CheckExternalEvents(cs7, 0xE929);
    // AND word ptr [BP + 0x2],AX (1000_E926 / 0x1E926)
    UInt16[SS, (ushort)(BP + 0x2)] &= AX;
    CheckExternalEvents(cs7, 0xE92D);
    // ADD AX,word ptr [0x1600] (1000_E929 / 0x1E929)
    // AX += UInt16[DS, 0x1600];
    AX = Alu16.Add(AX, UInt16[DS, 0x1600]);
    CheckExternalEvents(cs7, 0xE931);
    // SBB byte ptr [0x241a],DL (1000_E92D / 0x1E92D)
    UInt8[DS, 0x241A] = Alu8.Sbb(UInt8[DS, 0x241A], DL);
    CheckExternalEvents(cs7, 0xE933);
    // OR byte ptr [DI],DL (1000_E931 / 0x1E931)
    // UInt8[DS, (ushort)(DI)] |= DL;
    UInt8[DS, (ushort)(DI)] = Alu8.Or(UInt8[DS, (ushort)(DI)], DL);
    CheckExternalEvents(cs7, 0xE935);
    // SBB word ptr [BX + SI],AX (1000_E933 / 0x1E933)
    UInt16[DS, (ushort)(BX + SI)] = Alu16.Sbb(UInt16[DS, (ushort)(BX + SI)], AX);
    CheckExternalEvents(cs7, 0xE938);
    // NOP/reserved word ptr [BX + SI] (1000_E935 / 0x1E935)
    throw FailAsUntested("Unimplemented Instruction!");
    CheckExternalEvents(cs7, 0xE939);
    // PUSH AX (1000_E938 / 0x1E938)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0xE93B);
    // AND byte ptr [BX + SI],AL (1000_E939 / 0x1E939)
    UInt8[DS, (ushort)(BX + SI)] &= AL;
    CheckExternalEvents(cs7, 0xE93D);
    // ADD byte ptr [BX],DL (1000_E93B / 0x1E93B)
    // UInt8[DS, (ushort)(BX)] += DL;
    UInt8[DS, (ushort)(BX)] = Alu8.Add(UInt8[DS, (ushort)(BX)], DL);
    CheckExternalEvents(cs7, 0xE93F);
    // SBB byte ptr [BX + DI],DL (1000_E93D / 0x1E93D)
    UInt8[DS, (ushort)(BX + DI)] = Alu8.Sbb(UInt8[DS, (ushort)(BX + DI)], DL);
    CheckExternalEvents(cs7, 0xE941);
    // AND DX,word ptr [DI] (1000_E93F / 0x1E93F)
    // DX &= UInt16[DS, (ushort)(DI)];
    DX = Alu16.And(DX, UInt16[DS, (ushort)(DI)]);
    CheckExternalEvents(cs7, 0xE943);
    // ADC byte ptr [BX + SI],AL (1000_E941 / 0x1E941)
    UInt8[DS, (ushort)(BX + SI)] = Alu8.Adc(UInt8[DS, (ushort)(BX + SI)], AL);
    CheckExternalEvents(cs7, 0xE945);
    // ADD AH,byte ptr [BX + SI] (1000_E943 / 0x1E943)
    AH += UInt8[DS, (ushort)(BX + SI)];
    CheckExternalEvents(cs7, 0xE949);
    // XOR CL,byte ptr ES:[BX + SI + 0x38] (1000_E945 / 0x1E945)
    CL ^= UInt8[ES, (ushort)(BX + SI + 0x38)];
    CheckExternalEvents(cs7, 0xE94B);
    // XOR byte ptr [BX + SI],AL (1000_E949 / 0x1E949)
    UInt8[DS, (ushort)(BX + SI)] ^= AL;
    CheckExternalEvents(cs7, 0xE94D);
    // ADD byte ptr [BX + SI],AH (1000_E94B / 0x1E94B)
    // UInt8[DS, (ushort)(BX + SI)] += AH;
    UInt8[DS, (ushort)(BX + SI)] = Alu8.Add(UInt8[DS, (ushort)(BX + SI)], AH);
    CheckExternalEvents(cs7, 0xE94F);
    // SBB AL,byte ptr [BX + DI] (1000_E94D / 0x1E94D)
    AL = Alu8.Sbb(AL, UInt8[DS, (ushort)(BX + DI)]);
    CheckExternalEvents(cs7, 0xE950);
    // POP ES (1000_E94F / 0x1E94F)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xE952);
    // ADD byte ptr [SI],AL (1000_E950 / 0x1E950)
    UInt8[DS, (ushort)(SI)] += AL;
    CheckExternalEvents(cs7, 0xE954);
    // ADD byte ptr [BX + DI],AH (1000_E952 / 0x1E952)
    // UInt8[DS, (ushort)(BX + DI)] += AH;
    UInt8[DS, (ushort)(BX + DI)] = Alu8.Add(UInt8[DS, (ushort)(BX + DI)], AH);
    CheckExternalEvents(cs7, 0xE955);
    // PUSH ES (1000_E954 / 0x1E954)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xE958);
    // XOR byte ptr [BX + SI + 0x4a],CL (1000_E955 / 0x1E955)
    // UInt8[DS, (ushort)(BX + SI + 0x4A)] ^= CL;
    UInt8[DS, (ushort)(BX + SI + 0x4A)] = Alu8.Xor(UInt8[DS, (ushort)(BX + SI + 0x4A)], CL);
    CheckExternalEvents(cs7, 0xE95A);
    // PUSH ES (1000_E958 / 0x1E958)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xE95C);
    // ADD byte ptr [BX + SI],AL (1000_E95A / 0x1E95A)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu8.Add(UInt8[DS, (ushort)(BX + SI)], AL);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action ghidra_guess_1000_FA7E_1FA7E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_FA7E_1FA7E:
    CheckExternalEvents(cs7, 0xFA7F);
    // INC DX (1000_FA7E / 0x1FA7E)
    DX = Alu16.Inc(DX);
    CheckExternalEvents(cs7, 0xFA83);
    // MOV SS,word ptr [BX + SI + 0x9090] (1000_FA7F / 0x1FA7F)
    SS = UInt16[DS, (ushort)(BX + SI + 0x9090)];
    CheckExternalEvents(cs7, 0xFA84);
    // NOP  (1000_FA83 / 0x1FA83)
    
    CheckExternalEvents(cs7, 0xFA85);
    // XCHG AX,DX (1000_FA84 / 0x1FA84)
    (DX, AX) = (AX, DX);
    CheckExternalEvents(cs7, 0xFA86);
    // INC DX (1000_FA85 / 0x1FA85)
    DX++;
    CheckExternalEvents(cs7, 0xFA87);
    // INC DX (1000_FA86 / 0x1FA86)
    DX = Alu16.Inc(DX);
    CheckExternalEvents(cs7, 0xFA89);
    // MOV DL,0xb7 (1000_FA87 / 0x1FA87)
    DL = 0xB7;
    CheckExternalEvents(cs7, 0xFA8D);
    // MOV SS,word ptr [BP + SI + 0xb7b7] (1000_FA89 / 0x1FA89)
    SS = UInt16[SS, (ushort)(BP + SI + 0xB7B7)];
    CheckExternalEvents(cs7, 0xFA8E);
    // INC DX (1000_FA8D / 0x1FA8D)
    DX++;
    CheckExternalEvents(cs7, 0xFA8F);
    // INC DX (1000_FA8E / 0x1FA8E)
    DX++;
    CheckExternalEvents(cs7, 0xFA90);
    // INC DX (1000_FA8F / 0x1FA8F)
    DX = Alu16.Inc(DX);
    CheckExternalEvents(cs7, 0xFA94);
    // MOV SS,word ptr [BX + SI + 0x9090] (1000_FA90 / 0x1FA90)
    SS = UInt16[DS, (ushort)(BX + SI + 0x9090)];
    CheckExternalEvents(cs7, 0xFA95);
    // NOP  (1000_FA94 / 0x1FA94)
    
    CheckExternalEvents(cs7, 0xFA96);
    // INC DX (1000_FA95 / 0x1FA95)
    DX++;
    CheckExternalEvents(cs7, 0xFA97);
    // INC DX (1000_FA96 / 0x1FA96)
    DX++;
    CheckExternalEvents(cs7, 0xFA98);
    // INC DX (1000_FA97 / 0x1FA97)
    DX = Alu16.Inc(DX);
    CheckExternalEvents(cs7, 0xFA9A);
    // MOV DL,0xb7 (1000_FA98 / 0x1FA98)
    DL = 0xB7;
    CheckExternalEvents(cs7, 0xFA9C);
    // MOV BH,0xb7 (1000_FA9A / 0x1FA9A)
    BH = 0xB7;
    CheckExternalEvents(cs7, 0xFA9E);
    // MOV BH,0x87 (1000_FA9C / 0x1FA9C)
    BH = 0x87;
    CheckExternalEvents(cs7, 0xFAA2);
    // MOV DX,word ptr [BP + SI + 0xb4b4] (1000_FA9E / 0x1FA9E)
    DX = UInt16[SS, (ushort)(BP + SI + 0xB4B4)];
    CheckExternalEvents(cs7, 0xFAA4);
    // JNO 0x1000:fae7 (1000_FAA2 / 0x1FAA2)
    if(!OverflowFlag) {
      goto label_1000_FAE7_1FAE7;
    }
    CheckExternalEvents(cs7, 0xFAA5);
    // INC CX (1000_FAA4 / 0x1FAA4)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs7, 0xFAA7);
    // MOV AH,0x91 (1000_FAA5 / 0x1FAA5)
    AH = 0x91;
    CheckExternalEvents(cs7, 0xFAAA);
    // TEST AX,0xb4b5 (1000_FAA7 / 0x1FAA7)
    Alu16.And(AX, 0xB4B5);
    CheckExternalEvents(cs7, 0xFAAE);
    // IMUL AX,word ptr [BP + DI + 0x41],-0x4c (1000_FAAA / 0x1FAAA)
    AX = (ushort)(Alu16.Imul(UInt16[SS, (ushort)(BP + DI + 0x41)], 0xFFB4));
    CheckExternalEvents(cs7, 0xFAAF);
    // XCHG AX,CX (1000_FAAE / 0x1FAAE)
    (CX, AX) = (AX, CX);
    CheckExternalEvents(cs7, 0xFAB1);
    // MOV AH,0xa9 (1000_FAAF / 0x1FAAF)
    AH = 0xA9;
    CheckExternalEvents(cs7, 0xFAB3);
    // MOV CH,0x71 (1000_FAB1 / 0x1FAB1)
    CH = 0x71;
    CheckExternalEvents(cs7, 0xFAB4);
    // INC CX (1000_FAB3 / 0x1FAB3)
    CX++;
    CheckExternalEvents(cs7, 0xFAB5);
    // INC AX (1000_FAB4 / 0x1FAB4)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs7, 0xFAB7);
    // MOV AH,0x91 (1000_FAB5 / 0x1FAB5)
    AH = 0x91;
    CheckExternalEvents(cs7, 0xFABB);
    // MOV word ptr [DI + 0x6b42],CS (1000_FAB7 / 0x1FAB7)
    UInt16[DS, (ushort)(DI + 0x6B42)] = cs7;
    CheckExternalEvents(cs7, 0xFABC);
    // INC DX (1000_FABB / 0x1FABB)
    DX++;
    CheckExternalEvents(cs7, 0xFABD);
    // INC CX (1000_FABC / 0x1FABC)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs7, 0xFABF);
    // MOV AH,0x91 (1000_FABD / 0x1FABD)
    AH = 0x91;
    CheckExternalEvents(cs7, 0xFAC0);
    // XCHG AX,DX (1000_FABF / 0x1FABF)
    (DX, AX) = (AX, DX);
    CheckExternalEvents(cs7, 0xFAC2);
    // MOV AH,0xb3 (1000_FAC0 / 0x1FAC0)
    AH = 0xB3;
    CheckExternalEvents(cs7, 0xFAC4);
    // JNO 0x1000:fb06 (1000_FAC2 / 0x1FAC2)
    if(!OverflowFlag) {
      goto label_1000_FB06_1FB06;
    }
    CheckExternalEvents(cs7, 0xFAC5);
    // INC CX (1000_FAC4 / 0x1FAC4)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs7, 0xFAC7);
    // MOV CH,0x91 (1000_FAC5 / 0x1FAC5)
    CH = 0x91;
    CheckExternalEvents(cs7, 0xFACA);
    // TEST AX,0xb4b5 (1000_FAC7 / 0x1FAC7)
    Alu16.And(AX, 0xB4B5);
    CheckExternalEvents(cs7, 0xFACE);
    // IMUL AX,word ptr [BX + DI + 0x40],-0x70 (1000_FACA / 0x1FACA)
    AX = (ushort)(Alu16.Imul(UInt16[DS, (ushort)(BX + DI + 0x40)], 0xFF90));
    CheckExternalEvents(cs7, 0xFACF);
    // XCHG AX,DX (1000_FACE / 0x1FACE)
    (DX, AX) = (AX, DX);
    CheckExternalEvents(cs7, 0xFAD1);
    // MOV AH,0xa9 (1000_FACF / 0x1FACF)
    AH = 0xA9;
    CheckExternalEvents(cs7, 0xFAD3);
    // MOV CH,0x71 (1000_FAD1 / 0x1FAD1)
    CH = 0x71;
    CheckExternalEvents(cs7, 0xFAD4);
    // INC CX (1000_FAD3 / 0x1FAD3)
    CX++;
    CheckExternalEvents(cs7, 0xFAD5);
    // INC AX (1000_FAD4 / 0x1FAD4)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs7, 0xFAD7);
    // MOV BH,0xb7 (1000_FAD5 / 0x1FAD5)
    BH = 0xB7;
    CheckExternalEvents(cs7, 0xFAD9);
    // MOV CH,0xb4 (1000_FAD7 / 0x1FAD7)
    CH = 0xB4;
    CheckExternalEvents(cs7, 0xFADA);
    // INC DX (1000_FAD9 / 0x1FAD9)
    DX++;
    CheckExternalEvents(cs7, 0xFADE);
    // IMUL AX,word ptr [BX + DI + 0x40],0x41 (1000_FADA / 0x1FADA)
    AX = (ushort)(Alu16.Imul((short)UInt16[DS, (ushort)(BX + DI + 0x40)], 0x41));
    CheckExternalEvents(cs7, 0xFADF);
    // INC DX (1000_FADE / 0x1FADE)
    DX++;
    CheckExternalEvents(cs7, 0xFAE0);
    // INC AX (1000_FADF / 0x1FADF)
    AX++;
    CheckExternalEvents(cs7, 0xFAE1);
    // INC AX (1000_FAE0 / 0x1FAE0)
    AX++;
    CheckExternalEvents(cs7, 0xFAE2);
    // INC BX (1000_FAE1 / 0x1FAE1)
    BX++;
    CheckExternalEvents(cs7, 0xFAE3);
    // INC BX (1000_FAE2 / 0x1FAE2)
    BX++;
    CheckExternalEvents(cs7, 0xFAE4);
    // INC BX (1000_FAE3 / 0x1FAE3)
    BX++;
    CheckExternalEvents(cs7, 0xFAE5);
    // INC BX (1000_FAE4 / 0x1FAE4)
    BX++;
    CheckExternalEvents(cs7, 0xFAE6);
    // INC AX (1000_FAE5 / 0x1FAE5)
    AX++;
    CheckExternalEvents(cs7, 0xFAE7);
    // INC DX (1000_FAE6 / 0x1FAE6)
    DX++;
    label_1000_FAE7_1FAE7:
    CheckExternalEvents(cs7, 0xFAE8);
    // INC AX (1000_FAE7 / 0x1FAE7)
    AX++;
    CheckExternalEvents(cs7, 0xFAE9);
    // INC AX (1000_FAE8 / 0x1FAE8)
    AX++;
    CheckExternalEvents(cs7, 0xFAEA);
    // INC BX (1000_FAE9 / 0x1FAE9)
    BX++;
    CheckExternalEvents(cs7, 0xFAEB);
    // INC BX (1000_FAEA / 0x1FAEA)
    BX++;
    CheckExternalEvents(cs7, 0xFAEC);
    // INC CX (1000_FAEB / 0x1FAEB)
    CX++;
    CheckExternalEvents(cs7, 0xFAED);
    // INC CX (1000_FAEC / 0x1FAEC)
    CX++;
    CheckExternalEvents(cs7, 0xFAEE);
    // INC AX (1000_FAED / 0x1FAED)
    AX++;
    CheckExternalEvents(cs7, 0xFAEF);
    // INC DX (1000_FAEE / 0x1FAEE)
    DX++;
    CheckExternalEvents(cs7, 0xFAF0);
    // INC DX (1000_FAEF / 0x1FAEF)
    DX++;
    CheckExternalEvents(cs7, 0xFAF1);
    // INC AX (1000_FAF0 / 0x1FAF0)
    AX++;
    CheckExternalEvents(cs7, 0xFAF2);
    // INC BX (1000_FAF1 / 0x1FAF1)
    BX++;
    CheckExternalEvents(cs7, 0xFAF3);
    // INC BX (1000_FAF2 / 0x1FAF2)
    BX++;
    CheckExternalEvents(cs7, 0xFAF4);
    // INC CX (1000_FAF3 / 0x1FAF3)
    CX++;
    CheckExternalEvents(cs7, 0xFAF5);
    // INC BX (1000_FAF4 / 0x1FAF4)
    BX++;
    CheckExternalEvents(cs7, 0xFAF6);
    // INC CX (1000_FAF5 / 0x1FAF5)
    CX++;
    CheckExternalEvents(cs7, 0xFAF7);
    // INC CX (1000_FAF6 / 0x1FAF6)
    CX++;
    CheckExternalEvents(cs7, 0xFAF8);
    // INC CX (1000_FAF7 / 0x1FAF7)
    CX++;
    CheckExternalEvents(cs7, 0xFAF9);
    // INC DX (1000_FAF8 / 0x1FAF8)
    DX++;
    CheckExternalEvents(cs7, 0xFAFA);
    // INC DX (1000_FAF9 / 0x1FAF9)
    DX++;
    CheckExternalEvents(cs7, 0xFAFB);
    // INC CX (1000_FAFA / 0x1FAFA)
    CX++;
    CheckExternalEvents(cs7, 0xFAFC);
    // INC BX (1000_FAFB / 0x1FAFB)
    BX++;
    CheckExternalEvents(cs7, 0xFAFD);
    // INC AX (1000_FAFC / 0x1FAFC)
    AX++;
    CheckExternalEvents(cs7, 0xFAFE);
    // INC AX (1000_FAFD / 0x1FAFD)
    AX++;
    CheckExternalEvents(cs7, 0xFAFF);
    // INC AX (1000_FAFE / 0x1FAFE)
    AX++;
    CheckExternalEvents(cs7, 0xFB00);
    // INC AX (1000_FAFF / 0x1FAFF)
    AX++;
    CheckExternalEvents(cs7, 0xFB01);
    // INC AX (1000_FB00 / 0x1FB00)
    AX++;
    CheckExternalEvents(cs7, 0xFB02);
    // INC AX (1000_FB01 / 0x1FB01)
    AX++;
    CheckExternalEvents(cs7, 0xFB03);
    // INC DX (1000_FB02 / 0x1FB02)
    DX++;
    CheckExternalEvents(cs7, 0xFB04);
    // INC AX (1000_FB03 / 0x1FB03)
    AX++;
    CheckExternalEvents(cs7, 0xFB05);
    // INC AX (1000_FB04 / 0x1FB04)
    AX++;
    CheckExternalEvents(cs7, 0xFB06);
    // INC AX (1000_FB05 / 0x1FB05)
    AX++;
    label_1000_FB06_1FB06:
    CheckExternalEvents(cs7, 0xFB07);
    // INC CX (1000_FB06 / 0x1FB06)
    CX++;
    CheckExternalEvents(cs7, 0xFB08);
    // INC CX (1000_FB07 / 0x1FB07)
    CX++;
    CheckExternalEvents(cs7, 0xFB0A);
    // XOR AL,0x42 (1000_FB08 / 0x1FB08)
    AL ^= 0x42;
    CheckExternalEvents(cs7, 0xFB0B);
    // INC DX (1000_FB0A / 0x1FB0A)
    DX++;
    CheckExternalEvents(cs7, 0xFB0C);
    // INC CX (1000_FB0B / 0x1FB0B)
    CX++;
    CheckExternalEvents(cs7, 0xFB0D);
    // INC CX (1000_FB0C / 0x1FB0C)
    CX++;
    CheckExternalEvents(cs7, 0xFB0E);
    // INC CX (1000_FB0D / 0x1FB0D)
    CX++;
    CheckExternalEvents(cs7, 0xFB0F);
    // INC DX (1000_FB0E / 0x1FB0E)
    DX++;
    CheckExternalEvents(cs7, 0xFB12);
    // CMP DI,word ptr SS:[BX + SI] (1000_FB0F / 0x1FB0F)
    Alu16.Sub(DI, UInt16[SS, (ushort)(BX + SI)]);
    CheckExternalEvents(cs7, 0xFB15);
    // XOR byte ptr [BX + DI + 0x41],AL (1000_FB12 / 0x1FB12)
    UInt8[DS, (ushort)(BX + DI + 0x41)] ^= AL;
    CheckExternalEvents(cs7, 0xFB16);
    // INC CX (1000_FB15 / 0x1FB15)
    CX++;
    CheckExternalEvents(cs7, 0xFB18);
    // XOR byte ptr [DI],DH (1000_FB16 / 0x1FB16)
    // UInt8[DS, (ushort)(DI)] ^= DH;
    UInt8[DS, (ushort)(DI)] = Alu8.Xor(UInt8[DS, (ushort)(DI)], DH);
    CheckExternalEvents(cs7, 0xFB1A);
    // JO 0x1000:fb56 (1000_FB18 / 0x1FB18)
    if(OverflowFlag) {
      goto label_1000_FB56_1FB56;
    }
    CheckExternalEvents(cs7, 0xFB1D);
    // XOR byte ptr [BX + DI + 0x41],AL (1000_FB1A / 0x1FB1A)
    // UInt8[DS, (ushort)(BX + DI + 0x41)] ^= AL;
    UInt8[DS, (ushort)(BX + DI + 0x41)] = Alu8.Xor(UInt8[DS, (ushort)(BX + DI + 0x41)], AL);
    CheckExternalEvents(cs7, 0xFB1E);
    // OUTSW DX,SI (1000_FB1D / 0x1FB1D)
    Cpu.Out16(DX, UInt16[DS, (ushort)(SI)]);
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs7, 0xFB20);
    // PUSH 0x70 (1000_FB1E / 0x1FB1E)
    Stack.Push16(0x70);
    CheckExternalEvents(cs7, 0xFB21);
    // INC CX (1000_FB20 / 0x1FB20)
    CX++;
    CheckExternalEvents(cs7, 0xFB22);
    // INC AX (1000_FB21 / 0x1FB21)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs7, 0xFB24);
    // JNS 0x1000:fb9d (1000_FB22 / 0x1FB22)
    if(!SignFlag) {
      throw FailAsUntested("Would have been a goto but label label_1000_FB9D_1FB9D does not exist because no instruction was found there that belongs to a function.");
    }
    CheckExternalEvents(cs7, 0xFB26);
    // JNP 0x1000:fb69 (1000_FB24 / 0x1FB24)
    if(!ParityFlag) {
      goto label_1000_FB69_1FB69;
    }
    CheckExternalEvents(cs7, 0xFB27);
    // INC CX (1000_FB26 / 0x1FB26)
    CX++;
    CheckExternalEvents(cs7, 0xFB28);
    // INC CX (1000_FB27 / 0x1FB27)
    CX++;
    CheckExternalEvents(cs7, 0xFB29);
    // INC AX (1000_FB28 / 0x1FB28)
    AX++;
    CheckExternalEvents(cs7, 0xFB2A);
    // INC AX (1000_FB29 / 0x1FB29)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs7, 0xFB2C);
    // JNS 0x1000:fba5 (1000_FB2A / 0x1FB2A)
    if(!SignFlag) {
      goto label_1000_FBA5_1FBA5;
    }
    CheckExternalEvents(cs7, 0xFB2E);
    // JNP 0x1000:fb6f (1000_FB2C / 0x1FB2C)
    if(!ParityFlag) {
      goto label_1000_FB6F_1FB6F;
    }
    CheckExternalEvents(cs7, 0xFB2F);
    // INC CX (1000_FB2E / 0x1FB2E)
    CX++;
    CheckExternalEvents(cs7, 0xFB30);
    // INC AX (1000_FB2F / 0x1FB2F)
    AX++;
    CheckExternalEvents(cs7, 0xFB31);
    // INC BX (1000_FB30 / 0x1FB30)
    BX++;
    CheckExternalEvents(cs7, 0xFB32);
    // INC AX (1000_FB31 / 0x1FB31)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs7, 0xFB34);
    // JL 0x1000:fba8 (1000_FB32 / 0x1FB32)
    if(SignFlag != OverflowFlag) {
      goto label_1000_FBA8_1FBA8;
    }
    CheckExternalEvents(cs7, 0xFB36);
    // JLE 0x1000:fb76 (1000_FB34 / 0x1FB34)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_FB76_1FB76;
    }
    CheckExternalEvents(cs7, 0xFB37);
    // INC AX (1000_FB36 / 0x1FB36)
    AX++;
    CheckExternalEvents(cs7, 0xFB38);
    // INC AX (1000_FB37 / 0x1FB37)
    AX++;
    CheckExternalEvents(cs7, 0xFB39);
    // INC AX (1000_FB38 / 0x1FB38)
    AX++;
    CheckExternalEvents(cs7, 0xFB3A);
    // INC BX (1000_FB39 / 0x1FB39)
    BX++;
    CheckExternalEvents(cs7, 0xFB3B);
    // INC BX (1000_FB3A / 0x1FB3A)
    BX++;
    CheckExternalEvents(cs7, 0xFB3C);
    // INC CX (1000_FB3B / 0x1FB3B)
    CX++;
    CheckExternalEvents(cs7, 0xFB3D);
    // INC CX (1000_FB3C / 0x1FB3C)
    CX++;
    CheckExternalEvents(cs7, 0xFB3E);
    // INC AX (1000_FB3D / 0x1FB3D)
    AX++;
    CheckExternalEvents(cs7, 0xFB3F);
    // INC AX (1000_FB3E / 0x1FB3E)
    AX++;
    CheckExternalEvents(cs7, 0xFB40);
    // INC AX (1000_FB3F / 0x1FB3F)
    AX++;
    CheckExternalEvents(cs7, 0xFB41);
    // INC AX (1000_FB40 / 0x1FB40)
    AX++;
    CheckExternalEvents(cs7, 0xFB42);
    // INC AX (1000_FB41 / 0x1FB41)
    AX++;
    CheckExternalEvents(cs7, 0xFB43);
    // INC DX (1000_FB42 / 0x1FB42)
    DX++;
    CheckExternalEvents(cs7, 0xFB44);
    // INC CX (1000_FB43 / 0x1FB43)
    CX++;
    CheckExternalEvents(cs7, 0xFB45);
    // INC CX (1000_FB44 / 0x1FB44)
    CX++;
    CheckExternalEvents(cs7, 0xFB46);
    // INC CX (1000_FB45 / 0x1FB45)
    CX++;
    CheckExternalEvents(cs7, 0xFB47);
    // INC DX (1000_FB46 / 0x1FB46)
    DX++;
    CheckExternalEvents(cs7, 0xFB48);
    // INC DX (1000_FB47 / 0x1FB47)
    DX++;
    CheckExternalEvents(cs7, 0xFB4A);
    // XOR AL,0x42 (1000_FB48 / 0x1FB48)
    AL ^= 0x42;
    CheckExternalEvents(cs7, 0xFB4B);
    // INC CX (1000_FB4A / 0x1FB4A)
    CX++;
    CheckExternalEvents(cs7, 0xFB4C);
    // INC DX (1000_FB4B / 0x1FB4B)
    DX++;
    CheckExternalEvents(cs7, 0xFB4D);
    // INC DX (1000_FB4C / 0x1FB4C)
    DX++;
    CheckExternalEvents(cs7, 0xFB4E);
    // INC CX (1000_FB4D / 0x1FB4D)
    CX++;
    CheckExternalEvents(cs7, 0xFB4F);
    // INC DX (1000_FB4E / 0x1FB4E)
    DX++;
    CheckExternalEvents(cs7, 0xFB53);
    // CMP word ptr SS:[BP + SI + 0x41],AX (1000_FB4F / 0x1FB4F)
    Alu16.Sub(UInt16[SS, (ushort)(BP + SI + 0x41)], AX);
    CheckExternalEvents(cs7, 0xFB54);
    // INC DX (1000_FB53 / 0x1FB53)
    DX++;
    CheckExternalEvents(cs7, 0xFB55);
    // INC DX (1000_FB54 / 0x1FB54)
    DX++;
    CheckExternalEvents(cs7, 0xFB56);
    // INC CX (1000_FB55 / 0x1FB55)
    CX++;
    label_1000_FB56_1FB56:
    CheckExternalEvents(cs7, 0xFB58);
    // XOR BH,byte ptr [BX] (1000_FB56 / 0x1FB56)
    BH ^= UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs7, 0xFB5B);
    // CMP byte ptr [BP + SI + 0x42],AL (1000_FB58 / 0x1FB58)
    Alu8.Sub(UInt8[SS, (ushort)(BP + SI + 0x42)], AL);
    CheckExternalEvents(cs7, 0xFB5C);
    // INC DX (1000_FB5B / 0x1FB5B)
    DX++;
    CheckExternalEvents(cs7, 0xFB5D);
    // INC DX (1000_FB5C / 0x1FB5C)
    DX++;
    CheckExternalEvents(cs7, 0xFB5E);
    // INC DX (1000_FB5D / 0x1FB5D)
    DX++;
    CheckExternalEvents(cs7, 0xFB5F);
    // INC DX (1000_FB5E / 0x1FB5E)
    DX = Alu16.Inc(DX);
    CheckExternalEvents(cs7, 0xFB61);
    // JO 0x1000:fba3 (1000_FB5F / 0x1FB5F)
    if(OverflowFlag) {
      goto label_1000_FBA3_1FBA3;
    }
    CheckExternalEvents(cs7, 0xFB62);
    // INC DX (1000_FB61 / 0x1FB61)
    DX++;
    CheckExternalEvents(cs7, 0xFB63);
    // INC DX (1000_FB62 / 0x1FB62)
    DX++;
    CheckExternalEvents(cs7, 0xFB64);
    // INC CX (1000_FB63 / 0x1FB63)
    CX++;
    CheckExternalEvents(cs7, 0xFB65);
    // INC CX (1000_FB64 / 0x1FB64)
    CX++;
    CheckExternalEvents(cs7, 0xFB66);
    // INC CX (1000_FB65 / 0x1FB65)
    CX++;
    CheckExternalEvents(cs7, 0xFB67);
    // INC DX (1000_FB66 / 0x1FB66)
    DX++;
    CheckExternalEvents(cs7, 0xFB68);
    // INC DX (1000_FB67 / 0x1FB67)
    DX++;
    CheckExternalEvents(cs7, 0xFB69);
    // INC DX (1000_FB68 / 0x1FB68)
    DX++;
    label_1000_FB69_1FB69:
    CheckExternalEvents(cs7, 0xFB6A);
    // INC CX (1000_FB69 / 0x1FB69)
    CX++;
    CheckExternalEvents(cs7, 0xFB6B);
    // INC CX (1000_FB6A / 0x1FB6A)
    CX++;
    CheckExternalEvents(cs7, 0xFB6C);
    // INC DX (1000_FB6B / 0x1FB6B)
    DX++;
    CheckExternalEvents(cs7, 0xFB6D);
    // INC CX (1000_FB6C / 0x1FB6C)
    CX++;
    CheckExternalEvents(cs7, 0xFB6E);
    // INC DX (1000_FB6D / 0x1FB6D)
    DX++;
    CheckExternalEvents(cs7, 0xFB6F);
    // INC DX (1000_FB6E / 0x1FB6E)
    DX++;
    label_1000_FB6F_1FB6F:
    CheckExternalEvents(cs7, 0xFB70);
    // INC DX (1000_FB6F / 0x1FB6F)
    DX++;
    CheckExternalEvents(cs7, 0xFB71);
    // INC DX (1000_FB70 / 0x1FB70)
    DX++;
    CheckExternalEvents(cs7, 0xFB72);
    // INC DX (1000_FB71 / 0x1FB71)
    DX++;
    CheckExternalEvents(cs7, 0xFB73);
    // INC DX (1000_FB72 / 0x1FB72)
    DX++;
    CheckExternalEvents(cs7, 0xFB74);
    // INC DX (1000_FB73 / 0x1FB73)
    DX++;
    CheckExternalEvents(cs7, 0xFB75);
    // INC CX (1000_FB74 / 0x1FB74)
    CX++;
    CheckExternalEvents(cs7, 0xFB76);
    // INC CX (1000_FB75 / 0x1FB75)
    CX++;
    label_1000_FB76_1FB76:
    CheckExternalEvents(cs7, 0xFB77);
    // INC CX (1000_FB76 / 0x1FB76)
    CX++;
    CheckExternalEvents(cs7, 0xFB78);
    // INC CX (1000_FB77 / 0x1FB77)
    CX++;
    CheckExternalEvents(cs7, 0xFB79);
    // INC DX (1000_FB78 / 0x1FB78)
    DX++;
    CheckExternalEvents(cs7, 0xFB7A);
    // INC DX (1000_FB79 / 0x1FB79)
    DX++;
    label_1000_FB7A_1FB7A:
    CheckExternalEvents(cs7, 0xFB7B);
    // INC DX (1000_FB7A / 0x1FB7A)
    DX++;
    CheckExternalEvents(cs7, 0xFB7C);
    // INC DX (1000_FB7B / 0x1FB7B)
    DX++;
    CheckExternalEvents(cs7, 0xFB7D);
    // INC DX (1000_FB7C / 0x1FB7C)
    DX++;
    CheckExternalEvents(cs7, 0xFB7E);
    // INC CX (1000_FB7D / 0x1FB7D)
    CX++;
    CheckExternalEvents(cs7, 0xFB7F);
    // INC CX (1000_FB7E / 0x1FB7E)
    CX++;
    CheckExternalEvents(cs7, 0xFB80);
    // INC CX (1000_FB7F / 0x1FB7F)
    CX++;
    CheckExternalEvents(cs7, 0xFB81);
    // INC CX (1000_FB80 / 0x1FB80)
    CX++;
    CheckExternalEvents(cs7, 0xFB82);
    // INC CX (1000_FB81 / 0x1FB81)
    CX++;
    CheckExternalEvents(cs7, 0xFB83);
    // INC DX (1000_FB82 / 0x1FB82)
    DX++;
    CheckExternalEvents(cs7, 0xFB84);
    // INC DX (1000_FB83 / 0x1FB83)
    DX++;
    CheckExternalEvents(cs7, 0xFB85);
    // INC DX (1000_FB84 / 0x1FB84)
    DX++;
    CheckExternalEvents(cs7, 0xFB86);
    // INC DX (1000_FB85 / 0x1FB85)
    DX++;
    CheckExternalEvents(cs7, 0xFB87);
    // INC DX (1000_FB86 / 0x1FB86)
    DX++;
    CheckExternalEvents(cs7, 0xFB88);
    // INC DX (1000_FB87 / 0x1FB87)
    DX++;
    CheckExternalEvents(cs7, 0xFB89);
    // INC CX (1000_FB88 / 0x1FB88)
    CX++;
    CheckExternalEvents(cs7, 0xFB8A);
    // INC CX (1000_FB89 / 0x1FB89)
    CX++;
    label_1000_FB8A_1FB8A:
    CheckExternalEvents(cs7, 0xFB8B);
    // INC CX (1000_FB8A / 0x1FB8A)
    CX++;
    CheckExternalEvents(cs7, 0xFB8C);
    // INC DX (1000_FB8B / 0x1FB8B)
    DX++;
    CheckExternalEvents(cs7, 0xFB8D);
    // INC DX (1000_FB8C / 0x1FB8C)
    DX++;
    CheckExternalEvents(cs7, 0xFB8E);
    // INC DX (1000_FB8D / 0x1FB8D)
    DX++;
    CheckExternalEvents(cs7, 0xFB8F);
    // INC CX (1000_FB8E / 0x1FB8E)
    CX++;
    CheckExternalEvents(cs7, 0xFB90);
    // INC CX (1000_FB8F / 0x1FB8F)
    CX++;
    CheckExternalEvents(cs7, 0xFB91);
    // INC CX (1000_FB90 / 0x1FB90)
    CX++;
    CheckExternalEvents(cs7, 0xFB92);
    // INC CX (1000_FB91 / 0x1FB91)
    CX++;
    CheckExternalEvents(cs7, 0xFB94);
    // ADD CL,byte ptr [SI] (1000_FB92 / 0x1FB92)
    CL += UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xFB95);
    // INC CX (1000_FB94 / 0x1FB94)
    CX++;
    CheckExternalEvents(cs7, 0xFB96);
    // INC CX (1000_FB95 / 0x1FB95)
    CX++;
    CheckExternalEvents(cs7, 0xFB97);
    // INC CX (1000_FB96 / 0x1FB96)
    CX++;
    CheckExternalEvents(cs7, 0xFB98);
    // INC CX (1000_FB97 / 0x1FB97)
    CX++;
    CheckExternalEvents(cs7, 0xFB99);
    // INC CX (1000_FB98 / 0x1FB98)
    CX++;
    CheckExternalEvents(cs7, 0xFB9A);
    // INC CX (1000_FB99 / 0x1FB99)
    CX++;
    label_1000_FB9A_1FB9A:
    CheckExternalEvents(cs7, 0xFB9B);
    // INC CX (1000_FB9A / 0x1FB9A)
    CX++;
    CheckExternalEvents(cs7, 0xFB9F);
    // ADD CX,word ptr [0x4242] (1000_FB9B / 0x1FB9B)
    CX += UInt16[DS, 0x4242];
    CheckExternalEvents(cs7, 0xFBA0);
    // INC CX (1000_FB9F / 0x1FB9F)
    CX++;
    CheckExternalEvents(cs7, 0xFBA1);
    // INC CX (1000_FBA0 / 0x1FBA0)
    CX++;
    CheckExternalEvents(cs7, 0xFBA2);
    // INC DX (1000_FBA1 / 0x1FBA1)
    DX++;
    CheckExternalEvents(cs7, 0xFBA3);
    // INC DX (1000_FBA2 / 0x1FBA2)
    DX = Alu16.Inc(DX);
    label_1000_FBA3_1FBA3:
    CheckExternalEvents(cs7, 0xFBA5);
    // JNO 0x1000:fb7a (1000_FBA3 / 0x1FBA3)
    if(!OverflowFlag) {
      goto label_1000_FB7A_1FB7A;
    }
    label_1000_FBA5_1FBA5:
    CheckExternalEvents(cs7, 0xFBA6);
    // INC DX (1000_FBA5 / 0x1FBA5)
    DX++;
    CheckExternalEvents(cs7, 0xFBA7);
    // INC DX (1000_FBA6 / 0x1FBA6)
    DX++;
    CheckExternalEvents(cs7, 0xFBA8);
    // INC CX (1000_FBA7 / 0x1FBA7)
    CX++;
    label_1000_FBA8_1FBA8:
    CheckExternalEvents(cs7, 0xFBA9);
    // INC DX (1000_FBA8 / 0x1FBA8)
    DX++;
    CheckExternalEvents(cs7, 0xFBAA);
    // INC DX (1000_FBA9 / 0x1FBA9)
    DX++;
    label_1000_FBAA_1FBAA:
    CheckExternalEvents(cs7, 0xFBAB);
    // INC DX (1000_FBAA / 0x1FBAA)
    DX++;
    CheckExternalEvents(cs7, 0xFBAE);
    // IMUL DX,BP,0x41 (1000_FBAB / 0x1FBAB)
    DX = (ushort)(Alu16.Imul(BP, 0x41));
    CheckExternalEvents(cs7, 0xFBAF);
    // INC CX (1000_FBAE / 0x1FBAE)
    CX++;
    CheckExternalEvents(cs7, 0xFBB0);
    // INC CX (1000_FBAF / 0x1FBAF)
    CX++;
    CheckExternalEvents(cs7, 0xFBB1);
    // INC CX (1000_FBB0 / 0x1FBB0)
    CX++;
    CheckExternalEvents(cs7, 0xFBB2);
    // INC CX (1000_FBB1 / 0x1FBB1)
    CX++;
    CheckExternalEvents(cs7, 0xFBB3);
    // INC CX (1000_FBB2 / 0x1FBB2)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs7, 0xFBB5);
    // JNO 0x1000:fb8a (1000_FBB3 / 0x1FBB3)
    if(!OverflowFlag) {
      goto label_1000_FB8A_1FB8A;
    }
    CheckExternalEvents(cs7, 0xFBB6);
    // INC CX (1000_FBB5 / 0x1FBB5)
    CX++;
    CheckExternalEvents(cs7, 0xFBB7);
    // INC CX (1000_FBB6 / 0x1FBB6)
    CX++;
    CheckExternalEvents(cs7, 0xFBB8);
    // INC CX (1000_FBB7 / 0x1FBB7)
    CX++;
    CheckExternalEvents(cs7, 0xFBB9);
    // INC CX (1000_FBB8 / 0x1FBB8)
    CX++;
    CheckExternalEvents(cs7, 0xFBBA);
    // INC DX (1000_FBB9 / 0x1FBB9)
    DX++;
    CheckExternalEvents(cs7, 0xFBBB);
    // INC DX (1000_FBBA / 0x1FBBA)
    DX++;
    CheckExternalEvents(cs7, 0xFBBE);
    // IMUL DX,BP,0x41 (1000_FBBB / 0x1FBBB)
    DX = (ushort)(Alu16.Imul(BP, 0x41));
    CheckExternalEvents(cs7, 0xFBBF);
    // INC CX (1000_FBBE / 0x1FBBE)
    CX++;
    CheckExternalEvents(cs7, 0xFBC0);
    // INC CX (1000_FBBF / 0x1FBBF)
    CX++;
    CheckExternalEvents(cs7, 0xFBC1);
    // INC CX (1000_FBC0 / 0x1FBC0)
    CX++;
    CheckExternalEvents(cs7, 0xFBC2);
    // INC CX (1000_FBC1 / 0x1FBC1)
    CX++;
    CheckExternalEvents(cs7, 0xFBC3);
    // INC DX (1000_FBC2 / 0x1FBC2)
    DX = Alu16.Inc(DX);
    CheckExternalEvents(cs7, 0xFBC5);
    // JNO 0x1000:fb9a (1000_FBC3 / 0x1FBC3)
    if(!OverflowFlag) {
      goto label_1000_FB9A_1FB9A;
    }
    CheckExternalEvents(cs7, 0xFBC6);
    // INC DX (1000_FBC5 / 0x1FBC5)
    DX++;
    CheckExternalEvents(cs7, 0xFBC7);
    // INC DX (1000_FBC6 / 0x1FBC6)
    DX++;
    CheckExternalEvents(cs7, 0xFBC8);
    // INC DX (1000_FBC7 / 0x1FBC7)
    DX++;
    CheckExternalEvents(cs7, 0xFBC9);
    // INC DX (1000_FBC8 / 0x1FBC8)
    DX++;
    CheckExternalEvents(cs7, 0xFBCA);
    // INC DX (1000_FBC9 / 0x1FBC9)
    DX++;
    CheckExternalEvents(cs7, 0xFBCB);
    // INC DX (1000_FBCA / 0x1FBCA)
    DX++;
    CheckExternalEvents(cs7, 0xFBCE);
    // IMUL DX,BP,0x41 (1000_FBCB / 0x1FBCB)
    DX = (ushort)(Alu16.Imul(BP, 0x41));
    CheckExternalEvents(cs7, 0xFBCF);
    // INC DX (1000_FBCE / 0x1FBCE)
    DX++;
    label_1000_FBCF_1FBCF:
    CheckExternalEvents(cs7, 0xFBD0);
    // INC CX (1000_FBCF / 0x1FBCF)
    CX++;
    CheckExternalEvents(cs7, 0xFBD1);
    // INC CX (1000_FBD0 / 0x1FBD0)
    CX++;
    CheckExternalEvents(cs7, 0xFBD2);
    // INC DX (1000_FBD1 / 0x1FBD1)
    DX++;
    CheckExternalEvents(cs7, 0xFBD3);
    // INC DX (1000_FBD2 / 0x1FBD2)
    DX = Alu16.Inc(DX);
    CheckExternalEvents(cs7, 0xFBD5);
    // JNO 0x1000:fbaa (1000_FBD3 / 0x1FBD3)
    if(!OverflowFlag) {
      goto label_1000_FBAA_1FBAA;
    }
    CheckExternalEvents(cs7, 0xFBD7);
    // OR AL,0x42 (1000_FBD5 / 0x1FBD5)
    AL |= 0x42;
    CheckExternalEvents(cs7, 0xFBD8);
    // INC CX (1000_FBD7 / 0x1FBD7)
    CX++;
    CheckExternalEvents(cs7, 0xFBD9);
    // INC CX (1000_FBD8 / 0x1FBD8)
    CX++;
    CheckExternalEvents(cs7, 0xFBDA);
    // INC DX (1000_FBD9 / 0x1FBD9)
    DX++;
    CheckExternalEvents(cs7, 0xFBDB);
    // INC CX (1000_FBDA / 0x1FBDA)
    CX++;
    CheckExternalEvents(cs7, 0xFBDE);
    // IMUL DX,BP,-0x2b (1000_FBDB / 0x1FBDB)
    DX = (ushort)(Alu16.Imul(BP, 0xFFD5));
    CheckExternalEvents(cs7, 0xFBE1);
    // SUB AL,0xe9 (1000_FBDE / 0x1FBDE)
    // AL -= 0xE9;
    AL = Alu8.Sub(AL, 0xE9);
    CheckExternalEvents(cs7, 0xFBE3);
    // LOOPNZ 0x1000:fbcf (1000_FBE1 / 0x1FBE1)
    if(--CX != 0 && !ZeroFlag) {
      goto label_1000_FBCF_1FBCF;
    }
    CheckExternalEvents(cs7, 0xFBE4);
    // IN AL,DX (1000_FBE3 / 0x1FBE3)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs7, 0xFBE5);
    // STC  (1000_FBE4 / 0x1FBE4)
    CarryFlag = true;
    CheckExternalEvents(cs7, 0xFBE7);
    // AAD 0x23 (1000_FBE5 / 0x1FBE5)
    Cpu.Aad(0x23);
    CheckExternalEvents(cs7, 0xFBE9);
    // AND BP,SI (1000_FBE7 / 0x1FBE7)
    // BP &= SI;
    BP = Alu16.And(BP, SI);
    CheckExternalEvents(cs7, 0xFBEA);
    // IN AL,DX (1000_FBE9 / 0x1FBE9)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs7, 0xFBEB);
    // IN AL,DX (1000_FBEA / 0x1FBEA)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs7, 0xFBEC);
    // IN AL,DX (1000_FBEB / 0x1FBEB)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs7, 0xFBED);
    // IN AL,DX (1000_FBEC / 0x1FBEC)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs7, 0xFBEF);
    // AAD 0xe5 (1000_FBED / 0x1FBED)
    Cpu.Aad(0xE5);
    CheckExternalEvents(cs7, 0xFBF1);
    // OUT 0x20,AL (1000_FBEF / 0x1FBEF)
    Cpu.Out8(0x20, AL);
    CheckExternalEvents(cs7, 0xFBF3);
    // OUT 0xe5,AL (1000_FBF1 / 0x1FBF1)
    Cpu.Out8(0xE5, AL);
    CheckExternalEvents(cs7, 0xFBF5);
    // AND CH,AH (1000_FBF3 / 0x1FBF3)
    CH &= AH;
    CheckExternalEvents(cs7, 0xFBF7);
    // AAM 0x46 (1000_FBF5 / 0x1FBF5)
    Cpu.Aam(0x46);
    CheckExternalEvents(cs7, 0xFBF8);
    // INC SI (1000_FBF7 / 0x1FBF7)
    SI++;
    CheckExternalEvents(cs7, 0xFBF9);
    // INC SI (1000_FBF8 / 0x1FBF8)
    SI++;
    CheckExternalEvents(cs7, 0xFBFA);
    // INC SI (1000_FBF9 / 0x1FBF9)
    SI++;
    CheckExternalEvents(cs7, 0xFBFB);
    // INC SI (1000_FBFA / 0x1FBFA)
    SI++;
    CheckExternalEvents(cs7, 0xFBFC);
    // INC SI (1000_FBFB / 0x1FBFB)
    SI++;
    CheckExternalEvents(cs7, 0xFBFD);
    // INC SI (1000_FBFC / 0x1FBFC)
    SI++;
    CheckExternalEvents(cs7, 0xFBFF);
    // SHL word ptr [BX + SI],CL (1000_FBFD / 0x1FBFD)
    UInt16[DS, (ushort)(BX + SI)] <<= CL;
    CheckExternalEvents(cs7, 0xFC01);
    // DIV CX (1000_FBFF / 0x1FBFF)
    uint op1Div1000_FBFF = (uint)(DX << 16 | AX);
    ushort op2Div1000_FBFF = CX;
    ushort? resDiv1000_FBFF = Alu16.Div(op1Div1000_FBFF, op2Div1000_FBFF);
    if(resDiv1000_FBFF == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = resDiv1000_FBFF.Value;
    DX = (ushort)(op1Div1000_FBFF % op2Div1000_FBFF);
    CheckExternalEvents(cs7, 0xFC02);
    // INT1  (1000_FC01 / 0x1FC01)
    throw FailAsUntested("Unimplemented Instruction!");
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action entry_24D7_0010_24D80(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_24D7_0010_24D80:
    CheckExternalEvents(cs14, 0x14);
    // Instruction bytes at index 0, 3 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA22, 1BA20
    // Instruction bytes at index 1, 2 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA23, 1BA21
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 1, A2, 22, 5, 7, 28, A8, 88, AA, 2A, 8C, 6E, 2F, 11, 92, 33, F7, 98, 99, BB, FF. Opcode offset:0");
    // AND AH,byte ptr [BP + SI + 0x2222] (24D7_0010 / 0x24D80)
    AH &= UInt8[SS, (ushort)(BP + SI + 0x2222)];
    CheckExternalEvents(cs14, 0x16);
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA20, 1BA22
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA21, 1BA23
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 80, A2, 22, A8, 28, 88, E9, AA, 2A, 2F, 11, 92, 33, 96, F7, 99, BB, FE, FF. Opcode offset:0");
    // AND AH,byte ptr [BP + SI] (24D7_0014 / 0x24D84)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0x18);
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA22, 1BA20
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA21, 1BA23
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, A2, 22, 45, 7, 88, A8, A9, 2A, AA, 6A, 11, F2, 33, F7, 99, BB, FE, 1F, FF. Opcode offset:0");
    // AND AH,byte ptr [BP + SI] (24D7_0016 / 0x24D86)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0x1C);
    // Instruction bytes at index 0, 3 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA22, 1BA20
    // Instruction bytes at index 1, 2 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA23, 1BA21
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 80, 22, A2, 4, 5, A8, 28, 2A, AA, 6A, F, 2F, 8F, 11, 92, 33, 55, F7, 99, BB, FE, FF, 5F. Opcode offset:0");
    // AND AH,byte ptr [BP + SI + 0x8022] (24D7_0018 / 0x24D88)
    AH &= UInt8[SS, (ushort)(BP + SI + 0x8022)];
    CheckExternalEvents(cs14, 0x1E);
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA20, 1BA22
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA21, 1BA23
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 1, 81, 22, A2, 88, 28, A8, 2A, AA, 6A, C, EE, 2F, 8F, F2, 92, 33, F7, 98, 99, BB, FF, 5F. Opcode offset:0");
    // ADD byte ptr [BX + SI],AL (24D7_001C / 0x24D8C)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x20);
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA22, 1BA20
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA21, 1BA23
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 22, A2, 7, 88, A8, A9, 2A, AA, 8E, 70, F2, 33, F7, 59, 99, FB, BB, FF. Opcode offset:0");
    // ADD byte ptr [BX + SI],AL (24D7_001E / 0x24D8E)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x22);
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA22, 1BA20
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA23, 1BA21
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 80, 1, A2, 22, 88, A8, 28, 2A, AA, 8A, 8B, 2F, 50, 92, 33, F7, 99, BB, FF, BF. Opcode offset:0");
    // ADD byte ptr [BX + SI],AL (24D7_0020 / 0x24D90)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x24);
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA20, 1BA22
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA23, 1BA21
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 81, 22, 82, 6, 7, A9, 89, 2A, AA, B0, 70, F2, 33, 17, F7, F8, 99, BB, FF, 5F. Opcode offset:0");
    // ADD byte ptr [BX + SI],AL (24D7_0022 / 0x24D92)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x26);
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA20, 1BA22
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA21, 1BA23
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 22, A2, 3, 28, 88, A8, 89, 2A, AA, 8A, 8B, EE, 2F, 11, 33, F7, 19, 99, BB, 9B, FF, 5F. Opcode offset:0");
    // ADD byte ptr [BX + SI],AL (24D7_0024 / 0x24D94)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x28);
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA22, 1BA20
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA21, 1BA23
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 81, 22, A2, 7, 88, A9, 89, 9, AA, 6E, 4F, EF, 2F, F2, 33, B5, 96, F7, 99, BB, FF. Opcode offset:0");
    // ADD byte ptr [BX + SI],AL (24D7_0026 / 0x24D96)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x2A);
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA22, 1BA20
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA23, 1BA21
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 1, 22, A2, 5, 28, 2A, AA, 8A, F, 11, 33, B5, 95, F7, 59, D9, 99, BB, FC, FF, BF. Opcode offset:0");
    // ADD byte ptr [BX + SI],AL (24D7_0028 / 0x24D98)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x2C);
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA20, 1BA22
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA23, 1BA21
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 22, 82, A2, 3, E6, 7, 88, A9, AA, 2F, 11, F3, 33, F5, 96, F7, 99, B9, BB, FF, 5F. Opcode offset:0");
    // ADD byte ptr [BX + SI],AL (24D7_002A / 0x24D9A)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x2E);
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA20, 1BA22
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA21, 1BA23
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, A2, 22, A8, 28, 88, E9, 2A, AA, 8A, 50, F2, 33, 55, F7, 98, 99, BB, FF, 5F. Opcode offset:0");
    // ADD byte ptr [BX + SI],AL (24D7_002C / 0x24D9C)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x30);
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA22, 1BA20
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA21, 1BA23
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 22, 82, A2, 7, 88, A8, 9, AA, EE, 32, 33, 55, F7, 99, BB, FD, FF. Opcode offset:0");
    // ADD byte ptr [BX + SI],AL (24D7_002E / 0x24D9E)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x32);
    // Instruction bytes at index 0 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA22, 1BA20
    // Instruction bytes at index 1 modified by those instruction(s): 3DD35, 1C2B0, 1C23D, F0076, 1BA23, 1BA21
    throw FailAsUntested("Instruction is modified by code but this is at least partially unhandled. Parser handled: . Instruction needed: Opcode is modified, Mod R/M is modified. Possible opcodes: 0, 80, A2, 22, 82, 5, 8, A8, 28, 89, AA, 2A, 2F, 50, 33, 55, F7, 19, 99, BB, FF, BF. Opcode offset:0");
    // ADD byte ptr [BX + SI],AL (24D7_0030 / 0x24DA0)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x34);
    // ADD byte ptr [BX + SI],AL (24D7_0032 / 0x24DA2)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x36);
    // ADD byte ptr [BX + SI],AL (24D7_0034 / 0x24DA4)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x38);
    // ADD byte ptr [BX + SI],AL (24D7_0036 / 0x24DA6)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x3A);
    // ADD byte ptr [BX + SI],AL (24D7_0038 / 0x24DA8)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs14, 0x3C);
    // ADD byte ptr [BX + DI],AL (24D7_003A / 0x24DAA)
    // UInt8[DS, (ushort)(BX + DI)] += AL;
    UInt8[DS, (ushort)(BX + DI)] = Alu8.Add(UInt8[DS, (ushort)(BX + DI)], AL);
    CheckExternalEvents(cs14, 0x40);
    // PADDD MM6,qword ptr [BX + 0x11] (24D7_003C / 0x24DAC)
    throw FailAsUntested("Unimplemented Instruction!");
    CheckExternalEvents(cs14, 0x41);
    // POP SS (24D7_0040 / 0x24DB0)
    SS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x43);
    // JNO 0x2000:4dcc (24D7_0041 / 0x24DB1)
    if(!OverflowFlag) {
      throw FailAsUntested("Would have been a goto but label label_24D7_005C_24DCC does not exist because no instruction was found there that belongs to a function.");
    }
    CheckExternalEvents(cs14, 0x44);
    // XCHG AX,SI (24D7_0043 / 0x24DB3)
    (SI, AX) = (AX, SI);
    CheckExternalEvents(cs14, 0x45);
    // OUT DX,AL (24D7_0044 / 0x24DB4)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs14, 0x47);
    // OUT 0xf9,AL (24D7_0045 / 0x24DB5)
    Cpu.Out8(0xF9, AL);
    CheckExternalEvents(cs14, 0x4A);
    // OUT 0x6,AL (24D7_0047 / 0x24DB7)
    Cpu.Out8(0x6, AL);
    CheckExternalEvents(cs14, 0x4B);
    // POPF  (24D7_004A / 0x24DBA)
    FlagRegister16 = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x4C);
    // OUTSB DX,SI (24D7_004B / 0x24DBB)
    Cpu.Out8(DX, UInt8[DS, (ushort)(SI)]);
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x4D);
    // OUT DX,AL (24D7_004C / 0x24DBC)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs14, 0x51);
    // ADC word ptr [BX + SI],0x7177 (24D7_004D / 0x24DBD)
    UInt16[DS, (ushort)(BX + SI)] = Alu16.Adc(UInt16[DS, (ushort)(BX + SI)], 0x7177);
    CheckExternalEvents(cs14, 0x54);
    // INC byte ptr [BX + 0x2] (24D7_0051 / 0x24DC1)
    UInt8[DS, (ushort)(BX + 0x2)] = Alu8.Inc(UInt8[DS, (ushort)(BX + 0x2)]);
    CheckExternalEvents(cs14, 0x58);
    // SBB byte ptr [BX + DI + 0xec],AL (24D7_0054 / 0x24DC4)
    UInt8[DS, (ushort)(BX + DI + 0xEC)] = Alu8.Sbb(UInt8[DS, (ushort)(BX + DI + 0xEC)], AL);
    CheckExternalEvents(cs14, 0x5A);
    // ADD CX,SI (24D7_0058 / 0x24DC8)
    CX += SI;
    CheckExternalEvents(cs14, 0x5E);
    // DEC byte ptr [BX + SI + 0x1810] (24D7_005A / 0x24DCA)
    UInt8[DS, (ushort)(BX + SI + 0x1810)] = Alu8.Dec(UInt8[DS, (ushort)(BX + SI + 0x1810)]);
    CheckExternalEvents(cs14, 0x62);
    // SBB word ptr [BX + DI],0x1168 (24D7_005E / 0x24DCE)
    UInt16[DS, (ushort)(BX + DI)] = Alu16.Sbb(UInt16[DS, (ushort)(BX + DI)], 0x1168);
    CheckExternalEvents(cs14, 0x64);
    // SBB SP,SI (24D7_0062 / 0x24DD2)
    SP = Alu16.Sbb(SP, SI);
    CheckExternalEvents(cs14, 0x65);
    // XCHG AX,SI (24D7_0064 / 0x24DD4)
    (SI, AX) = (AX, SI);
    label_24D7_0065_24DD5:
    CheckExternalEvents(cs14, 0x67);
    // OUT 0x6,AL (24D7_0065 / 0x24DD5)
    Cpu.Out8(0x6, AL);
    CheckExternalEvents(cs14, 0x69);
    // FISTTP qword ptr [BX + SI] (24D7_0067 / 0x24DD7)
    throw FailAsUntested("Unimplemented Instruction!");
    CheckExternalEvents(cs14, 0x6B);
    // MOV byte ptr [BX + DI],DL (24D7_0069 / 0x24DD9)
    UInt8[DS, (ushort)(BX + DI)] = DL;
    CheckExternalEvents(cs14, 0x70);
    // XOR word ptr [BX + -0x3],0xbb11 (24D7_006B / 0x24DDB)
    // UInt16[DS, (ushort)(BX - 0x3)] ^= 0xBB11;
    UInt16[DS, (ushort)(BX - 0x3)] = Alu16.Xor(UInt16[DS, (ushort)(BX - 0x3)], 0xBB11);
    CheckExternalEvents(cs14, 0x71);
    // STC  (24D7_0070 / 0x24DE0)
    CarryFlag = true;
    CheckExternalEvents(cs14, 0x74);
    // MOV BX,0xbbbb (24D7_0071 / 0x24DE1)
    BX = 0xBBBB;
    CheckExternalEvents(cs14, 0x77);
    // MOV DI,0x2252 (24D7_0074 / 0x24DE4)
    DI = 0x2252;
    CheckExternalEvents(cs14, 0x79);
    // AND AH,byte ptr [BP + SI] (24D7_0077 / 0x24DE7)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0x7B);
    // AND AH,byte ptr [BP + SI] (24D7_0079 / 0x24DE9)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0x7D);
    // AND AH,byte ptr [BP + SI] (24D7_007B / 0x24DEB)
    // AH &= UInt8[SS, (ushort)(BP + SI)];
    AH = Alu8.And(AH, UInt8[SS, (ushort)(BP + SI)]);
    CheckExternalEvents(cs14, 0x80);
    // MOV [0x2222],AL (24D7_007D / 0x24DED)
    UInt8[DS, 0x2222] = AL;
    CheckExternalEvents(cs14, 0x82);
    // AND AH,byte ptr [BP + SI] (24D7_0080 / 0x24DF0)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0x86);
    // AND AL,byte ptr [BX + 0x87f7] (24D7_0082 / 0x24DF2)
    AL &= UInt8[DS, (ushort)(BX + 0x87F7)];
    CheckExternalEvents(cs14, 0x8C);
    // TEST word ptr [BX + 0x87f7],0x87f7 (24D7_0086 / 0x24DF6)
    Alu16.And(UInt16[DS, (ushort)(BX + 0x87F7)], 0x87F7);
    CheckExternalEvents(cs14, 0x92);
    // TEST word ptr [BX + 0x87f7],0x87f7 (24D7_008C / 0x24DFC)
    Alu16.And(UInt16[DS, (ushort)(BX + 0x87F7)], 0x87F7);
    CheckExternalEvents(cs14, 0x98);
    // TEST word ptr [BX + 0x87f7],0x39f7 (24D7_0092 / 0x24E02)
    Alu16.And(UInt16[DS, (ushort)(BX + 0x87F7)], 0x39F7);
    CheckExternalEvents(cs14, 0x9B);
    // INC word ptr [BX + -0x1] (24D7_0098 / 0x24E08)
    UInt16[DS, (ushort)(BX - 0x1)]++;
    CheckExternalEvents(cs14, 0x9F);
    // AND AH,byte ptr [BP + SI + 0xa2a2] (24D7_009B / 0x24E0B)
    AH &= UInt8[SS, (ushort)(BP + SI + 0xA2A2)];
    CheckExternalEvents(cs14, 0xA1);
    // SUB AH,byte ptr [BP + SI] (24D7_009F / 0x24E0F)
    AH -= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0xA3);
    // AND AH,byte ptr [BP + SI] (24D7_00A1 / 0x24E11)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0xA5);
    // AND AH,byte ptr [BP + SI] (24D7_00A3 / 0x24E13)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0xA7);
    // AND AH,byte ptr [BP + SI] (24D7_00A5 / 0x24E15)
    // AH &= UInt8[SS, (ushort)(BP + SI)];
    AH = Alu8.And(AH, UInt8[SS, (ushort)(BP + SI)]);
    CheckExternalEvents(cs14, 0xA8);
    // POP ES (24D7_00A7 / 0x24E17)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xAC);
    // MOV byte ptr [BX + SI + 0x2207],CL (24D7_00A8 / 0x24E18)
    UInt8[DS, (ushort)(BX + SI + 0x2207)] = CL;
    CheckExternalEvents(cs14, 0xAF);
    // AND CH,byte ptr [BX] (24D7_00AC / 0x24E1C)
    CH &= UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs14, 0xB1);
    // AND AH,byte ptr [BP + SI] (24D7_00AF / 0x24E1F)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0xB3);
    // AND AH,byte ptr [BP + SI] (24D7_00B1 / 0x24E21)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0xB5);
    // AND AH,byte ptr [BP + SI] (24D7_00B3 / 0x24E23)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0xB7);
    // SUB CH,byte ptr [BP + SI] (24D7_00B5 / 0x24E25)
    CH -= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0xB9);
    // AND AH,byte ptr [BP + SI] (24D7_00B7 / 0x24E27)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0xBB);
    // AND AH,byte ptr [BP + SI] (24D7_00B9 / 0x24E29)
    AH &= UInt8[SS, (ushort)(BP + SI)];
    CheckExternalEvents(cs14, 0xBF);
    // SUB byte ptr [0x6066],AL (24D7_00BB / 0x24E2B)
    UInt8[DS, 0x6066] -= AL;
    CheckExternalEvents(cs14, 0xC3);
    // ADD byte ptr [0x6066],AL (24D7_00BF / 0x24E2F)
    UInt8[DS, 0x6066] += AL;
    CheckExternalEvents(cs14, 0xC7);
    // ADD byte ptr [0xe00e],CL (24D7_00C3 / 0x24E33)
    UInt8[DS, 0xE00E] += CL;
    CheckExternalEvents(cs14, 0xCB);
    // ADD byte ptr [0xe00e],CL (24D7_00C7 / 0x24E37)
    UInt8[DS, 0xE00E] += CL;
    CheckExternalEvents(cs14, 0xCF);
    // ADD byte ptr [0xe00e],CL (24D7_00CB / 0x24E3B)
    UInt8[DS, 0xE00E] += CL;
    CheckExternalEvents(cs14, 0xD3);
    // ADD byte ptr [0xe00e],CL (24D7_00CF / 0x24E3F)
    UInt8[DS, 0xE00E] += CL;
    CheckExternalEvents(cs14, 0xD7);
    // ADD byte ptr [0x6066],AL (24D7_00D3 / 0x24E43)
    UInt8[DS, 0x6066] += AL;
    CheckExternalEvents(cs14, 0xDB);
    // ADD byte ptr [0x6066],AL (24D7_00D7 / 0x24E47)
    // UInt8[DS, 0x6066] += AL;
    UInt8[DS, 0x6066] = Alu8.Add(UInt8[DS, 0x6066], AL);
    CheckExternalEvents(cs14, 0xDD);
    // LOOPZ 0x2000:4e65 (24D7_00DB / 0x24E4B)
    if(--CX != 0 && ZeroFlag) {
      goto label_24D7_00F5_24E65;
    }
    CheckExternalEvents(cs14, 0xDE);
    // CWD  (24D7_00DD / 0x24E4D)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs14, 0xDF);
    // XCHG AX,CX (24D7_00DE / 0x24E4E)
    (CX, AX) = (AX, CX);
    CheckExternalEvents(cs14, 0xE2);
    // INC byte ptr [BX + 0x2] (24D7_00DF / 0x24E4F)
    UInt8[DS, (ushort)(BX + 0x2)] = Alu8.Inc(UInt8[DS, (ushort)(BX + 0x2)]);
    CheckExternalEvents(cs14, 0xE4);
    // JS 0x2000:4dd5 (24D7_00E2 / 0x24E52)
    if(SignFlag) {
      goto label_24D7_0065_24DD5;
    }
    CheckExternalEvents(cs14, 0xE5);
    // IN AL,DX (24D7_00E4 / 0x24E54)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs14, 0xE7);
    // ADD byte ptr [BP + SI],AL (24D7_00E5 / 0x24E55)
    UInt8[SS, (ushort)(BP + SI)] += AL;
    CheckExternalEvents(cs14, 0xE9);
    // NEG word ptr [BX + SI] (24D7_00E7 / 0x24E57)
    UInt16[DS, (ushort)(BX + SI)] = Alu16.Sub(0, UInt16[DS, (ushort)(BX + SI)]);
    CheckExternalEvents(cs14, 0xEC);
    // INC byte ptr [BX + 0xe] (24D7_00E9 / 0x24E59)
    UInt8[DS, (ushort)(BX + 0xE)] = Alu8.Inc(UInt8[DS, (ushort)(BX + 0xE)]);
    CheckExternalEvents(cs14, 0xEE);
    // MOV byte ptr [BX + DI],BL (24D7_00EC / 0x24E5C)
    UInt8[DS, (ushort)(BX + DI)] = BL;
    CheckExternalEvents(cs14, 0xEF);
    // OUTSB DX,SI (24D7_00EE / 0x24E5E)
    Cpu.Out8(DX, UInt8[DS, (ushort)(SI)]);
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0xF3);
    // SUB SI,0x66e6 (24D7_00EF / 0x24E5F)
    // SI -= 0x66E6;
    SI = Alu16.Sub(SI, 0x66E6);
    CheckExternalEvents(cs14, 0xF4);
    // PUSH CS (24D7_00F3 / 0x24E63)
    Stack.Push16(cs14);
    CheckExternalEvents(cs14, 0xF5);
    // OUT DX,AL (24D7_00F4 / 0x24E64)
    Cpu.Out8(DX, AL);
    label_24D7_00F5_24E65:
    CheckExternalEvents(cs14, 0xF8);
    // CALL 0x2000:bd61 (24D7_00F5 / 0x24E65)
    NearCall(cs14, 0xF8, ghidra_guess_2000_BD61_2BD61);
    CheckExternalEvents(cs14, 0xFA);
    // LOOPZ 0x2000:4e82 (24D7_00F8 / 0x24E68)
    if(--CX != 0 && ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_2000_4E82_24E82, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0xFE);
    // INC byte ptr [BX + DI + 0x1704] (24D7_00FA / 0x24E6A)
    UInt8[DS, (ushort)(BX + DI + 0x1704)] = Alu8.Inc(UInt8[DS, (ushort)(BX + DI + 0x1704)]);
    CheckExternalEvents(cs14, 0x100);
    // JA 0x2000:4ee8 (24D7_00FE / 0x24E6E)
    if(!CarryFlag && !ZeroFlag) {
      throw FailAsUntested("Would have been a goto but label label_24D7_0178_24EE8 does not exist because no instruction was found there that belongs to a function.");
    }
    CheckExternalEvents(cs14, 0x104);
    // SUB SP,0x1200 (24D7_0100 / 0x24E70)
    // SP -= 0x1200;
    SP = Alu16.Sub(SP, 0x1200);
    CheckExternalEvents(cs14, 0x106);
    // NOT word ptr [BX] (24D7_0104 / 0x24E74)
    UInt16[DS, (ushort)(BX)] = (ushort)(~UInt16[DS, (ushort)(BX)]);
    CheckExternalEvents(cs14, 0x108);
    // JA 0x2000:4ef0 (24D7_0106 / 0x24E76)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_2000_4E82_24E82, 0x24EF0 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x10E);
    // SBB word ptr [BX + DI + 0x8e6e],0xe9ee (24D7_0108 / 0x24E78)
    UInt16[DS, (ushort)(BX + DI + 0x8E6E)] = Alu16.Sbb(UInt16[DS, (ushort)(BX + DI + 0x8E6E)], 0xE9EE);
    CheckExternalEvents(cs14, 0x10F);
    // OUTSW DX,SI (24D7_010E / 0x24E7E)
    Cpu.Out16(DX, UInt16[DS, (ushort)(SI)]);
    SI = (ushort)(SI + Direction16);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
}
