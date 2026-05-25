namespace generated;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.InstructionsImpl;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action split_1000_A5E1_1A5E1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1A5E7: goto label_1000_A5E7_1A5E7;break; // Target of external jump from 0x1A51D, 0x1A56C
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_A5E1_1A5E1:
    CheckExternalEvents(cs8, 0xA5E5);
    // SUB DI,0x5f60 (1000_A5E1 / 0x1A5E1)
    // DI -= 0x5F60;
    DI = Alu16.Sub(DI, 0x5F60);
    CheckExternalEvents(cs8, 0xA5E7);
    // LOOP 0x1000:a5c5 (1000_A5E5 / 0x1A5E5)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_A56F_1A56F, 0x1A5C5 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_A5E7_1A5E7:
    CheckExternalEvents(cs8, 0xA5E8);
    // POP ES (1000_A5E7 / 0x1A5E7)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA5E9);
    // POP DS (1000_A5E8 / 0x1A5E8)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA5EA);
    // POP SI (1000_A5E9 / 0x1A5E9)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA5EB);
    // POP DI (1000_A5EA / 0x1A5EA)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA5EC);
    // POP BP (1000_A5EB / 0x1A5EB)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA5ED);
    // RETF  (1000_A5EC / 0x1A5EC)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A5ED_1A5ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A5ED_1A5ED:
    CheckExternalEvents(cs8, 0xA5F0);
    // AND AX,0x3 (1000_A5ED / 0x1A5ED)
    // AX &= 0x3;
    AX = Alu16.And(AX, 0x3);
    CheckExternalEvents(cs8, 0xA5F3);
    // MOV [0x224],AX (1000_A5F0 / 0x1A5F0)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs8, 0xA5F5);
    // SHL AX,0x1 (1000_A5F3 / 0x1A5F3)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0xA5F7);
    // SHL AX,0x1 (1000_A5F5 / 0x1A5F5)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs8, 0xA5FB);
    // OR AX,word ptr [0x224] (1000_A5F7 / 0x1A5F7)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs8, 0xA5FD);
    // MOV BX,AX (1000_A5FB / 0x1A5FB)
    BX = AX;
    CheckExternalEvents(cs8, 0xA600);
    // MOV CX,0x4 (1000_A5FD / 0x1A5FD)
    CX = 0x4;
    CheckExternalEvents(cs8, 0xA602);
    // SHL AX,CL (1000_A600 / 0x1A600)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs8, 0xA604);
    // OR AX,BX (1000_A602 / 0x1A602)
    // AX |= BX;
    AX = Alu16.Or(AX, BX);
    CheckExternalEvents(cs8, 0xA607);
    // MOV BX,0x3 (1000_A604 / 0x1A604)
    BX = 0x3;
    CheckExternalEvents(cs8, 0xA60B);
    // MOV CX,word ptr [0x220] (1000_A607 / 0x1A607)
    CX = UInt16[DS, 0x220];
    CheckExternalEvents(cs8, 0xA60E);
    // AND CX,0x3 (1000_A60B / 0x1A60B)
    CX &= 0x3;
    CheckExternalEvents(cs8, 0xA611);
    // XOR CX,0x3 (1000_A60E / 0x1A60E)
    // CX ^= 0x3;
    CX = Alu16.Xor(CX, 0x3);
    CheckExternalEvents(cs8, 0xA613);
    // JZ 0x1000:a617 (1000_A611 / 0x1A611)
    if(ZeroFlag) {
      goto label_1000_A617_1A617;
    }
    CheckExternalEvents(cs8, 0xA615);
    // ADD CX,CX (1000_A613 / 0x1A613)
    CX += CX;
    CheckExternalEvents(cs8, 0xA617);
    // SHL BX,CL (1000_A615 / 0x1A615)
    BX <<= CL;
    label_1000_A617_1A617:
    CheckExternalEvents(cs8, 0xA619);
    // AND AX,BX (1000_A617 / 0x1A617)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs8, 0xA61C);
    // MOV [0x224],AX (1000_A619 / 0x1A619)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs8, 0xA61E);
    // NOT BL (1000_A61C / 0x1A61C)
    BL = (byte)(~BL);
    CheckExternalEvents(cs8, 0xA621);
    // MOV AX,0xb800 (1000_A61E / 0x1A61E)
    AX = 0xB800;
    CheckExternalEvents(cs8, 0xA623);
    // MOV ES,AX (1000_A621 / 0x1A621)
    ES = AX;
    CheckExternalEvents(cs8, 0xA626);
    // MOV AX,[0x234] (1000_A623 / 0x1A623)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA628);
    // AND AL,0xfe (1000_A626 / 0x1A626)
    // AL &= 0xFE;
    AL = Alu8.And(AL, 0xFE);
    CheckExternalEvents(cs8, 0xA62B);
    // MOV DX,0x28 (1000_A628 / 0x1A628)
    DX = 0x28;
    CheckExternalEvents(cs8, 0xA62D);
    // MUL DL (1000_A62B / 0x1A62B)
    ushort resMul1000_A62B = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A62B);
    AH = (byte)(resMul1000_A62B >> 8);
    CheckExternalEvents(cs8, 0xA631);
    // MOV DX,word ptr [0x220] (1000_A62D / 0x1A62D)
    DX = UInt16[DS, 0x220];
    CheckExternalEvents(cs8, 0xA633);
    // SHR DX,0x1 (1000_A631 / 0x1A631)
    DX >>= 0x1;
    CheckExternalEvents(cs8, 0xA635);
    // SHR DX,0x1 (1000_A633 / 0x1A633)
    DX >>= 0x1;
    CheckExternalEvents(cs8, 0xA637);
    // ADD AX,DX (1000_A635 / 0x1A635)
    // AX += DX;
    AX = Alu16.Add(AX, DX);
    CheckExternalEvents(cs8, 0xA63B);
    // MOV DX,word ptr [0x234] (1000_A637 / 0x1A637)
    DX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA63E);
    // AND DX,0x1 (1000_A63B / 0x1A63B)
    // DX &= 0x1;
    DX = Alu16.And(DX, 0x1);
    CheckExternalEvents(cs8, 0xA640);
    // JZ 0x1000:a643 (1000_A63E / 0x1A63E)
    if(ZeroFlag) {
      goto label_1000_A643_1A643;
    }
    CheckExternalEvents(cs8, 0xA643);
    // ADD AX,0x2000 (1000_A640 / 0x1A640)
    // AX += 0x2000;
    AX = Alu16.Add(AX, 0x2000);
    label_1000_A643_1A643:
    CheckExternalEvents(cs8, 0xA645);
    // MOV DI,AX (1000_A643 / 0x1A643)
    DI = AX;
    CheckExternalEvents(cs8, 0xA649);
    // MOV CX,word ptr [0x236] (1000_A645 / 0x1A645)
    CX = UInt16[DS, 0x236];
    CheckExternalEvents(cs8, 0xA64D);
    // SUB CX,word ptr [0x234] (1000_A649 / 0x1A649)
    CX -= UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA64E);
    // INC CX (1000_A64D / 0x1A64D)
    CX = Alu16.Inc(CX);
    label_1000_A64E_1A64E:
    CheckExternalEvents(cs8, 0xA651);
    // MOV AL,byte ptr ES:[DI] (1000_A64E / 0x1A64E)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs8, 0xA653);
    // AND AL,BL (1000_A651 / 0x1A651)
    // AL &= BL;
    AL = Alu8.And(AL, BL);
    CheckExternalEvents(cs8, 0xA657);
    // OR AX,word ptr [0x224] (1000_A653 / 0x1A653)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs8, 0xA65A);
    // MOV byte ptr ES:[DI],AL (1000_A657 / 0x1A657)
    UInt8[ES, (ushort)(DI)] = AL;
    CheckExternalEvents(cs8, 0xA65D);
    // XOR DL,0x1 (1000_A65A / 0x1A65A)
    // DL ^= 0x1;
    DL = Alu8.Xor(DL, 0x1);
    CheckExternalEvents(cs8, 0xA65F);
    // JZ 0x1000:a667 (1000_A65D / 0x1A65D)
    if(ZeroFlag) {
      goto label_1000_A667_1A667;
    }
    CheckExternalEvents(cs8, 0xA663);
    // ADD DI,0x2000 (1000_A65F / 0x1A65F)
    // DI += 0x2000;
    DI = Alu16.Add(DI, 0x2000);
    CheckExternalEvents(cs8, 0xA665);
    // LOOP 0x1000:a64e (1000_A663 / 0x1A663)
    if(--CX != 0) {
      goto label_1000_A64E_1A64E;
    }
    CheckExternalEvents(cs8, 0xA667);
    // JMP 0x1000:a5e7 (1000_A665 / 0x1A665)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A5E1_1A5E1, 0x1A5E7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_A667_1A667:
    CheckExternalEvents(cs8, 0xA66B);
    // SUB DI,0x1fb0 (1000_A667 / 0x1A667)
    // DI -= 0x1FB0;
    DI = Alu16.Sub(DI, 0x1FB0);
    CheckExternalEvents(cs8, 0xA66D);
    // LOOP 0x1000:a64e (1000_A66B / 0x1A66B)
    if(--CX != 0) {
      goto label_1000_A64E_1A64E;
    }
    CheckExternalEvents(cs8, 0xA670);
    // JMP 0x1000:a5e7 (1000_A66D / 0x1A66D)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A5E1_1A5E1, 0x1A5E7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action unknown_19EF_0780_1A670(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0780_1A670:
    CheckExternalEvents(cs14, 0x781);
    // PUSH BP (19EF_0780 / 0x1A670)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x783);
    // MOV BP,SP (19EF_0781 / 0x1A671)
    BP = SP;
    CheckExternalEvents(cs14, 0x784);
    // PUSH DI (19EF_0783 / 0x1A673)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x785);
    // PUSH SI (19EF_0784 / 0x1A674)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x786);
    // PUSH DS (19EF_0785 / 0x1A675)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x789);
    // MOV AX,0x1ddc (19EF_0786 / 0x1A676)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x78B);
    // MOV DS,AX (19EF_0789 / 0x1A679)
    DS = AX;
    CheckExternalEvents(cs14, 0x78C);
    // PUSH ES (19EF_078B / 0x1A67B)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x78F);
    // MOV AX,word ptr [BP + 0x6] (19EF_078C / 0x1A67C)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x792);
    // MOV [0x220],AX (19EF_078F / 0x1A67F)
    UInt16[DS, 0x220] = AX;
    CheckExternalEvents(cs14, 0x795);
    // MOV AX,word ptr [BP + 0x8] (19EF_0792 / 0x1A682)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x798);
    // MOV [0x234],AX (19EF_0795 / 0x1A685)
    UInt16[DS, 0x234] = AX;
    CheckExternalEvents(cs14, 0x79B);
    // MOV CX,word ptr [BP + 0xa] (19EF_0798 / 0x1A688)
    CX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x79F);
    // MOV word ptr [0x230],CX (19EF_079B / 0x1A68B)
    UInt16[DS, 0x230] = CX;
    CheckExternalEvents(cs14, 0x7A2);
    // MOV AX,word ptr [BP + 0xc] (19EF_079F / 0x1A68F)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x7A5);
    // MOV [0x224],AX (19EF_07A2 / 0x1A692)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs14, 0x7AA);
    // CMP word ptr [0xb764],0x3 (19EF_07A5 / 0x1A695)
    Alu16.Sub(UInt16[DS, 0xB764], 0x3);
    CheckExternalEvents(cs14, 0x7AC);
    // JZ 0x1000:a6ad (19EF_07AA / 0x1A69A)
    if(ZeroFlag) {
      goto label_19EF_07BD_1A6AD;
    }
    CheckExternalEvents(cs14, 0x7B1);
    // CMP word ptr [0xb764],0x2 (19EF_07AC / 0x1A69C)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x7B3);
    // JZ 0x1000:a6c8 (19EF_07B1 / 0x1A6A1)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A6C8_1A6C8, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x7B8);
    // CMP word ptr [0xb764],0x1 (19EF_07B3 / 0x1A6A3)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs14, 0x7BA);
    // JZ 0x1000:a6fe (19EF_07B8 / 0x1A6A8)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A6FE_1A6FE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x7BD);
    // JMP 0x1000:a744 (19EF_07BA / 0x1A6AA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_A744_1A744, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_07BD_1A6AD:
    CheckExternalEvents(cs14, 0x7C0);
    // MOV AX,0xa000 (19EF_07BD / 0x1A6AD)
    AX = 0xA000;
    CheckExternalEvents(cs14, 0x7C2);
    // MOV ES,AX (19EF_07C0 / 0x1A6B0)
    ES = AX;
    CheckExternalEvents(cs14, 0x7C5);
    // MOV AX,[0x234] (19EF_07C2 / 0x1A6B2)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs14, 0x7C8);
    // MOV DX,0x140 (19EF_07C5 / 0x1A6B5)
    DX = 0x140;
    CheckExternalEvents(cs14, 0x7CA);
    // MUL DX (19EF_07C8 / 0x1A6B8)
    uint resMul19EF_07C8 = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul19EF_07C8);
    DX = (ushort)(resMul19EF_07C8 >> 16);
    CheckExternalEvents(cs14, 0x7CE);
    // ADD AX,word ptr [0x220] (19EF_07CA / 0x1A6BA)
    // AX += UInt16[DS, 0x220];
    AX = Alu16.Add(AX, UInt16[DS, 0x220]);
    CheckExternalEvents(cs14, 0x7D0);
    // MOV DI,AX (19EF_07CE / 0x1A6BE)
    DI = AX;
    CheckExternalEvents(cs14, 0x7D3);
    // MOV AX,[0x224] (19EF_07D0 / 0x1A6C0)
    AX = UInt16[DS, 0x224];
    CheckExternalEvents(cs14, 0x7D5);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (19EF_07D3 / 0x1A6C3)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs14, 0x7D7);
    // JMP 0x1000:a73e (19EF_07D5 / 0x1A6C5)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A6FE_1A6FE, 0x1A73E - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_A6C8_1A6C8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A6C8_1A6C8:
    CheckExternalEvents(cs8, 0xA6CB);
    // MOV DX,0x3ce (1000_A6C8 / 0x1A6C8)
    DX = 0x3CE;
    CheckExternalEvents(cs8, 0xA6CE);
    // MOV AX,0x205 (1000_A6CB / 0x1A6CB)
    AX = 0x205;
    CheckExternalEvents(cs8, 0xA6CF);
    // OUT DX,AX (1000_A6CE / 0x1A6CE)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA6D2);
    // MOV AX,0xff08 (1000_A6CF / 0x1A6CF)
    AX = 0xFF08;
    CheckExternalEvents(cs8, 0xA6D3);
    // OUT DX,AX (1000_A6D2 / 0x1A6D2)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA6D6);
    // MOV DX,0x28 (1000_A6D3 / 0x1A6D3)
    DX = 0x28;
    CheckExternalEvents(cs8, 0xA6D9);
    // MOV AX,[0x234] (1000_A6D6 / 0x1A6D6)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA6DB);
    // MUL DL (1000_A6D9 / 0x1A6D9)
    ushort resMul1000_A6D9 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A6D9);
    AH = (byte)(resMul1000_A6D9 >> 8);
    CheckExternalEvents(cs8, 0xA6DF);
    // MOV BX,word ptr [0x220] (1000_A6DB / 0x1A6DB)
    BX = UInt16[DS, 0x220];
    CheckExternalEvents(cs8, 0xA6E1);
    // SHR BX,0x1 (1000_A6DF / 0x1A6DF)
    BX >>= 0x1;
    CheckExternalEvents(cs8, 0xA6E3);
    // SHR BX,0x1 (1000_A6E1 / 0x1A6E1)
    BX >>= 0x1;
    CheckExternalEvents(cs8, 0xA6E5);
    // SHR BX,0x1 (1000_A6E3 / 0x1A6E3)
    BX >>= 0x1;
    CheckExternalEvents(cs8, 0xA6E7);
    // ADD AX,BX (1000_A6E5 / 0x1A6E5)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs8, 0xA6E9);
    // MOV DI,AX (1000_A6E7 / 0x1A6E7)
    DI = AX;
    CheckExternalEvents(cs8, 0xA6EC);
    // MOV AX,0xa000 (1000_A6E9 / 0x1A6E9)
    AX = 0xA000;
    CheckExternalEvents(cs8, 0xA6EE);
    // MOV ES,AX (1000_A6EC / 0x1A6EC)
    ES = AX;
    CheckExternalEvents(cs8, 0xA6F2);
    // MOV CX,word ptr [0x230] (1000_A6EE / 0x1A6EE)
    CX = UInt16[DS, 0x230];
    CheckExternalEvents(cs8, 0xA6F5);
    // MOV AX,[0x224] (1000_A6F2 / 0x1A6F2)
    AX = UInt16[DS, 0x224];
    label_1000_A6F5_1A6F5:
    CheckExternalEvents(cs8, 0xA6F8);
    // MOV AH,byte ptr ES:[DI] (1000_A6F5 / 0x1A6F5)
    AH = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs8, 0xA6F9);
    // STOSB ES:DI (1000_A6F8 / 0x1A6F8)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xA6FB);
    // LOOP 0x1000:a6f5 (1000_A6F9 / 0x1A6F9)
    if(--CX != 0) {
      goto label_1000_A6F5_1A6F5;
    }
    CheckExternalEvents(cs8, 0xA6FD);
    // JMP 0x1000:a73e (1000_A6FB / 0x1A6FB)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A6FE_1A6FE, 0x1A73E - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_A6FE_1A6FE(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1A73E: goto label_1000_A73E_1A73E;break; // Target of external jump from 0x1A6C5, 0x1A6FB
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_A6FE_1A6FE:
    CheckExternalEvents(cs8, 0xA701);
    // MOV CX,0x4 (1000_A6FE / 0x1A6FE)
    CX = 0x4;
    CheckExternalEvents(cs8, 0xA703);
    // SHL AL,CL (1000_A701 / 0x1A701)
    // AL <<= CL;
    AL = Alu8.Shl(AL, CL);
    CheckExternalEvents(cs8, 0xA707);
    // OR AX,word ptr [0x224] (1000_A703 / 0x1A703)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs8, 0xA709);
    // MOV AH,AL (1000_A707 / 0x1A707)
    AH = AL;
    CheckExternalEvents(cs8, 0xA70C);
    // MOV [0x224],AX (1000_A709 / 0x1A709)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs8, 0xA70F);
    // MOV AX,0xb800 (1000_A70C / 0x1A70C)
    AX = 0xB800;
    CheckExternalEvents(cs8, 0xA711);
    // MOV ES,AX (1000_A70F / 0x1A70F)
    ES = AX;
    CheckExternalEvents(cs8, 0xA714);
    // MOV AX,[0x234] (1000_A711 / 0x1A711)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA716);
    // AND AL,0xfc (1000_A714 / 0x1A714)
    // AL &= 0xFC;
    AL = Alu8.And(AL, 0xFC);
    CheckExternalEvents(cs8, 0xA719);
    // MOV DX,0x28 (1000_A716 / 0x1A716)
    DX = 0x28;
    CheckExternalEvents(cs8, 0xA71B);
    // MUL DL (1000_A719 / 0x1A719)
    ushort resMul1000_A719 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A719);
    AH = (byte)(resMul1000_A719 >> 8);
    CheckExternalEvents(cs8, 0xA71F);
    // MOV DX,word ptr [0x220] (1000_A71B / 0x1A71B)
    DX = UInt16[DS, 0x220];
    CheckExternalEvents(cs8, 0xA721);
    // SHR DX,0x1 (1000_A71F / 0x1A71F)
    DX >>= 0x1;
    CheckExternalEvents(cs8, 0xA723);
    // ADD AX,DX (1000_A721 / 0x1A721)
    // AX += DX;
    AX = Alu16.Add(AX, DX);
    CheckExternalEvents(cs8, 0xA727);
    // MOV DX,word ptr [0x234] (1000_A723 / 0x1A723)
    DX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA72A);
    // AND DX,0x3 (1000_A727 / 0x1A727)
    // DX &= 0x3;
    DX = Alu16.And(DX, 0x3);
    CheckExternalEvents(cs8, 0xA72C);
    // JZ 0x1000:a733 (1000_A72A / 0x1A72A)
    if(ZeroFlag) {
      goto label_1000_A733_1A733;
    }
    CheckExternalEvents(cs8, 0xA72E);
    // MOV CX,DX (1000_A72C / 0x1A72C)
    CX = DX;
    label_1000_A72E_1A72E:
    CheckExternalEvents(cs8, 0xA731);
    // ADD AH,0x20 (1000_A72E / 0x1A72E)
    // AH += 0x20;
    AH = Alu8.Add(AH, 0x20);
    CheckExternalEvents(cs8, 0xA733);
    // LOOP 0x1000:a72e (1000_A731 / 0x1A731)
    if(--CX != 0) {
      goto label_1000_A72E_1A72E;
    }
    label_1000_A733_1A733:
    CheckExternalEvents(cs8, 0xA735);
    // MOV DI,AX (1000_A733 / 0x1A733)
    DI = AX;
    CheckExternalEvents(cs8, 0xA739);
    // MOV CX,word ptr [0x230] (1000_A735 / 0x1A735)
    CX = UInt16[DS, 0x230];
    CheckExternalEvents(cs8, 0xA73C);
    // MOV AX,[0x224] (1000_A739 / 0x1A739)
    AX = UInt16[DS, 0x224];
    CheckExternalEvents(cs8, 0xA73E);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_A73C / 0x1A73C)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    label_1000_A73E_1A73E:
    CheckExternalEvents(cs8, 0xA73F);
    // POP ES (1000_A73E / 0x1A73E)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA740);
    // POP DS (1000_A73F / 0x1A73F)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA741);
    // POP SI (1000_A740 / 0x1A740)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA742);
    // POP DI (1000_A741 / 0x1A741)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA743);
    // POP BP (1000_A742 / 0x1A742)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA744);
    // RETF  (1000_A743 / 0x1A743)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A744_1A744(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A744_1A744:
    CheckExternalEvents(cs8, 0xA747);
    // AND AX,0x3 (1000_A744 / 0x1A744)
    // AX &= 0x3;
    AX = Alu16.And(AX, 0x3);
    CheckExternalEvents(cs8, 0xA74A);
    // MOV [0x224],AX (1000_A747 / 0x1A747)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs8, 0xA74C);
    // SHL AL,0x1 (1000_A74A / 0x1A74A)
    AL <<= 0x1;
    CheckExternalEvents(cs8, 0xA74E);
    // SHL AL,0x1 (1000_A74C / 0x1A74C)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs8, 0xA752);
    // OR AX,word ptr [0x224] (1000_A74E / 0x1A74E)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs8, 0xA754);
    // MOV BL,AL (1000_A752 / 0x1A752)
    BL = AL;
    CheckExternalEvents(cs8, 0xA756);
    // MOV CL,0x4 (1000_A754 / 0x1A754)
    CL = 0x4;
    CheckExternalEvents(cs8, 0xA758);
    // SHL AL,CL (1000_A756 / 0x1A756)
    // AL <<= CL;
    AL = Alu8.Shl(AL, CL);
    CheckExternalEvents(cs8, 0xA75A);
    // OR AL,BL (1000_A758 / 0x1A758)
    // AL |= BL;
    AL = Alu8.Or(AL, BL);
    CheckExternalEvents(cs8, 0xA75C);
    // MOV AH,AL (1000_A75A / 0x1A75A)
    AH = AL;
    CheckExternalEvents(cs8, 0xA75F);
    // MOV [0x224],AX (1000_A75C / 0x1A75C)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs8, 0xA762);
    // MOV AX,0xb800 (1000_A75F / 0x1A75F)
    AX = 0xB800;
    CheckExternalEvents(cs8, 0xA764);
    // MOV ES,AX (1000_A762 / 0x1A762)
    ES = AX;
    CheckExternalEvents(cs8, 0xA767);
    // MOV AX,[0x234] (1000_A764 / 0x1A764)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA769);
    // AND AL,0xfe (1000_A767 / 0x1A767)
    // AL &= 0xFE;
    AL = Alu8.And(AL, 0xFE);
    CheckExternalEvents(cs8, 0xA76C);
    // MOV DX,0x28 (1000_A769 / 0x1A769)
    DX = 0x28;
    CheckExternalEvents(cs8, 0xA76E);
    // MUL DL (1000_A76C / 0x1A76C)
    ushort resMul1000_A76C = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A76C);
    AH = (byte)(resMul1000_A76C >> 8);
    CheckExternalEvents(cs8, 0xA772);
    // MOV DX,word ptr [0x220] (1000_A76E / 0x1A76E)
    DX = UInt16[DS, 0x220];
    CheckExternalEvents(cs8, 0xA774);
    // SHR DX,0x1 (1000_A772 / 0x1A772)
    DX >>= 0x1;
    CheckExternalEvents(cs8, 0xA776);
    // SHR DX,0x1 (1000_A774 / 0x1A774)
    DX >>= 0x1;
    CheckExternalEvents(cs8, 0xA778);
    // ADD AX,DX (1000_A776 / 0x1A776)
    // AX += DX;
    AX = Alu16.Add(AX, DX);
    CheckExternalEvents(cs8, 0xA77C);
    // MOV DX,word ptr [0x234] (1000_A778 / 0x1A778)
    DX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA77F);
    // AND DX,0x1 (1000_A77C / 0x1A77C)
    // DX &= 0x1;
    DX = Alu16.And(DX, 0x1);
    CheckExternalEvents(cs8, 0xA781);
    // JZ 0x1000:a784 (1000_A77F / 0x1A77F)
    if(ZeroFlag) {
      goto label_1000_A784_1A784;
    }
    CheckExternalEvents(cs8, 0xA784);
    // ADD AH,0x20 (1000_A781 / 0x1A781)
    // AH += 0x20;
    AH = Alu8.Add(AH, 0x20);
    label_1000_A784_1A784:
    CheckExternalEvents(cs8, 0xA786);
    // MOV DI,AX (1000_A784 / 0x1A784)
    DI = AX;
    CheckExternalEvents(cs8, 0xA78A);
    // MOV CX,word ptr [0x230] (1000_A786 / 0x1A786)
    CX = UInt16[DS, 0x230];
    CheckExternalEvents(cs8, 0xA78D);
    // MOV AX,[0x224] (1000_A78A / 0x1A78A)
    AX = UInt16[DS, 0x224];
    CheckExternalEvents(cs8, 0xA78F);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_A78D / 0x1A78D)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs8, 0xA791);
    // JMP 0x1000:a73e (1000_A78F / 0x1A78F)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A6FE_1A6FE, 0x1A73E - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ghidra_guess_1000_A791_1A791(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A791_1A791:
    CheckExternalEvents(cs8, 0xA792);
    // PUSH BP (1000_A791 / 0x1A791)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xA794);
    // MOV BP,SP (1000_A792 / 0x1A792)
    BP = SP;
    CheckExternalEvents(cs8, 0xA795);
    // PUSH DI (1000_A794 / 0x1A794)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xA796);
    // PUSH SI (1000_A795 / 0x1A795)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xA797);
    // PUSH DS (1000_A796 / 0x1A796)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xA79A);
    // MOV AX,0x1ddc (1000_A797 / 0x1A797)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xA79C);
    // MOV DS,AX (1000_A79A / 0x1A79A)
    DS = AX;
    CheckExternalEvents(cs8, 0xA79D);
    // PUSH ES (1000_A79C / 0x1A79C)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xA7A0);
    // MOV AX,word ptr [BP + 0x6] (1000_A79D / 0x1A79D)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xA7A2);
    // SHR AX,0x1 (1000_A7A0 / 0x1A7A0)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs8, 0xA7A5);
    // MOV [0x220],AX (1000_A7A2 / 0x1A7A2)
    UInt16[DS, 0x220] = AX;
    CheckExternalEvents(cs8, 0xA7A8);
    // MOV AX,word ptr [BP + 0x8] (1000_A7A5 / 0x1A7A5)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0xA7AB);
    // MOV [0x234],AX (1000_A7A8 / 0x1A7A8)
    UInt16[DS, 0x234] = AX;
    CheckExternalEvents(cs8, 0xA7AE);
    // MOV AX,word ptr [BP + 0xa] (1000_A7AB / 0x1A7AB)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0xA7B1);
    // ADD AX,0x1 (1000_A7AE / 0x1A7AE)
    // AX += 0x1;
    AX = Alu16.Add(AX, 0x1);
    CheckExternalEvents(cs8, 0xA7B4);
    // MOV [0x230],AX (1000_A7B1 / 0x1A7B1)
    UInt16[DS, 0x230] = AX;
    CheckExternalEvents(cs8, 0xA7B7);
    // MOV AX,word ptr [BP + 0xc] (1000_A7B4 / 0x1A7B4)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0xA7BA);
    // MOV [0x236],AX (1000_A7B7 / 0x1A7B7)
    UInt16[DS, 0x236] = AX;
    CheckExternalEvents(cs8, 0xA7BD);
    // MOV AX,word ptr [BP + 0xe] (1000_A7BA / 0x1A7BA)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs8, 0xA7C0);
    // MOV [0x224],AX (1000_A7BD / 0x1A7BD)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs8, 0xA7C3);
    // MOV CX,0x4 (1000_A7C0 / 0x1A7C0)
    CX = 0x4;
    CheckExternalEvents(cs8, 0xA7C5);
    // SHL AL,CL (1000_A7C3 / 0x1A7C3)
    // AL <<= CL;
    AL = Alu8.Shl(AL, CL);
    CheckExternalEvents(cs8, 0xA7C9);
    // OR AX,word ptr [0x224] (1000_A7C5 / 0x1A7C5)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs8, 0xA7CB);
    // MOV AH,AL (1000_A7C9 / 0x1A7C9)
    AH = AL;
    CheckExternalEvents(cs8, 0xA7CE);
    // MOV [0x224],AX (1000_A7CB / 0x1A7CB)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs8, 0xA7D1);
    // MOV AX,0xb800 (1000_A7CE / 0x1A7CE)
    AX = 0xB800;
    CheckExternalEvents(cs8, 0xA7D3);
    // MOV ES,AX (1000_A7D1 / 0x1A7D1)
    ES = AX;
    CheckExternalEvents(cs8, 0xA7D6);
    // MOV AX,[0x234] (1000_A7D3 / 0x1A7D3)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA7D8);
    // AND AL,0xfc (1000_A7D6 / 0x1A7D6)
    // AL &= 0xFC;
    AL = Alu8.And(AL, 0xFC);
    CheckExternalEvents(cs8, 0xA7DB);
    // MOV DX,0x28 (1000_A7D8 / 0x1A7D8)
    DX = 0x28;
    CheckExternalEvents(cs8, 0xA7DD);
    // MUL DL (1000_A7DB / 0x1A7DB)
    ushort resMul1000_A7DB = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A7DB);
    AH = (byte)(resMul1000_A7DB >> 8);
    CheckExternalEvents(cs8, 0xA7E1);
    // ADD AX,word ptr [0x220] (1000_A7DD / 0x1A7DD)
    // AX += UInt16[DS, 0x220];
    AX = Alu16.Add(AX, UInt16[DS, 0x220]);
    CheckExternalEvents(cs8, 0xA7E5);
    // MOV DX,word ptr [0x234] (1000_A7E1 / 0x1A7E1)
    DX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA7E8);
    // AND DX,0x3 (1000_A7E5 / 0x1A7E5)
    // DX &= 0x3;
    DX = Alu16.And(DX, 0x3);
    CheckExternalEvents(cs8, 0xA7EA);
    // JZ 0x1000:a7f1 (1000_A7E8 / 0x1A7E8)
    if(ZeroFlag) {
      goto label_1000_A7F1_1A7F1;
    }
    CheckExternalEvents(cs8, 0xA7EC);
    // MOV CX,DX (1000_A7EA / 0x1A7EA)
    CX = DX;
    label_1000_A7EC_1A7EC:
    CheckExternalEvents(cs8, 0xA7EF);
    // ADD AH,0x20 (1000_A7EC / 0x1A7EC)
    // AH += 0x20;
    AH = Alu8.Add(AH, 0x20);
    CheckExternalEvents(cs8, 0xA7F1);
    // LOOP 0x1000:a7ec (1000_A7EF / 0x1A7EF)
    if(--CX != 0) {
      goto label_1000_A7EC_1A7EC;
    }
    label_1000_A7F1_1A7F1:
    CheckExternalEvents(cs8, 0xA7F3);
    // MOV DI,AX (1000_A7F1 / 0x1A7F1)
    DI = AX;
    CheckExternalEvents(cs8, 0xA7F7);
    // MOV BX,word ptr [0x236] (1000_A7F3 / 0x1A7F3)
    BX = UInt16[DS, 0x236];
    CheckExternalEvents(cs8, 0xA7FA);
    // MOV AX,[0x224] (1000_A7F7 / 0x1A7F7)
    AX = UInt16[DS, 0x224];
    label_1000_A7FA_1A7FA:
    CheckExternalEvents(cs8, 0xA7FE);
    // MOV CX,word ptr [0x230] (1000_A7FA / 0x1A7FA)
    CX = UInt16[DS, 0x230];
    CheckExternalEvents(cs8, 0xA800);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_A7FE / 0x1A7FE)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs8, 0xA804);
    // SUB DI,word ptr [0x230] (1000_A800 / 0x1A800)
    DI -= UInt16[DS, 0x230];
    CheckExternalEvents(cs8, 0xA806);
    // INC DL (1000_A804 / 0x1A804)
    DL++;
    CheckExternalEvents(cs8, 0xA809);
    // AND DL,0x3 (1000_A806 / 0x1A806)
    // DL &= 0x3;
    DL = Alu8.And(DL, 0x3);
    CheckExternalEvents(cs8, 0xA80B);
    // JZ 0x1000:a814 (1000_A809 / 0x1A809)
    if(ZeroFlag) {
      goto label_1000_A814_1A814;
    }
    CheckExternalEvents(cs8, 0xA80F);
    // ADD DI,0x2000 (1000_A80B / 0x1A80B)
    DI += 0x2000;
    CheckExternalEvents(cs8, 0xA810);
    // DEC BX (1000_A80F / 0x1A80F)
    BX = Alu16.Dec(BX);
    CheckExternalEvents(cs8, 0xA812);
    // JNS 0x1000:a7fa (1000_A810 / 0x1A810)
    if(!SignFlag) {
      goto label_1000_A7FA_1A7FA;
    }
    CheckExternalEvents(cs8, 0xA814);
    // JS 0x1000:a81b (1000_A812 / 0x1A812)
    if(SignFlag) {
      goto label_1000_A81B_1A81B;
    }
    label_1000_A814_1A814:
    CheckExternalEvents(cs8, 0xA818);
    // SUB DI,0x5f60 (1000_A814 / 0x1A814)
    DI -= 0x5F60;
    CheckExternalEvents(cs8, 0xA819);
    // DEC BX (1000_A818 / 0x1A818)
    BX = Alu16.Dec(BX);
    CheckExternalEvents(cs8, 0xA81B);
    // JNS 0x1000:a7fa (1000_A819 / 0x1A819)
    if(!SignFlag) {
      goto label_1000_A7FA_1A7FA;
    }
    label_1000_A81B_1A81B:
    CheckExternalEvents(cs8, 0xA81C);
    // POP ES (1000_A81B / 0x1A81B)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA81D);
    // POP DS (1000_A81C / 0x1A81C)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA81E);
    // POP SI (1000_A81D / 0x1A81D)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA81F);
    // POP DI (1000_A81E / 0x1A81E)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA820);
    // POP BP (1000_A81F / 0x1A81F)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA821);
    // RETF  (1000_A820 / 0x1A820)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0931_1A821(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0931_1A821:
    CheckExternalEvents(cs14, 0x932);
    // PUSH BP (19EF_0931 / 0x1A821)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x934);
    // MOV BP,SP (19EF_0932 / 0x1A822)
    BP = SP;
    CheckExternalEvents(cs14, 0x935);
    // PUSH DI (19EF_0934 / 0x1A824)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x936);
    // PUSH SI (19EF_0935 / 0x1A825)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x937);
    // PUSH DS (19EF_0936 / 0x1A826)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x93A);
    // MOV AX,0x1ddc (19EF_0937 / 0x1A827)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x93C);
    // MOV DS,AX (19EF_093A / 0x1A82A)
    DS = AX;
    CheckExternalEvents(cs14, 0x93D);
    // PUSH ES (19EF_093C / 0x1A82C)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x940);
    // MOV SI,word ptr [BP + 0x6] (19EF_093D / 0x1A82D)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x943);
    // MOV AX,word ptr [BP + 0x8] (19EF_0940 / 0x1A830)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x946);
    // MOV [0x25a],AX (19EF_0943 / 0x1A833)
    UInt16[DS, 0x25A] = AX;
    CheckExternalEvents(cs14, 0x949);
    // MOV DI,word ptr [BP + 0xa] (19EF_0946 / 0x1A836)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x94C);
    // MOV AX,word ptr [BP + 0xc] (19EF_0949 / 0x1A839)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x94E);
    // MOV ES,AX (19EF_094C / 0x1A83C)
    ES = AX;
    CheckExternalEvents(cs14, 0x951);
    // MOV DX,word ptr [BP + 0xe] (19EF_094E / 0x1A83E)
    DX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs14, 0x954);
    // MOV AX,word ptr [BP + 0x10] (19EF_0951 / 0x1A841)
    AX = UInt16[SS, (ushort)(BP + 0x10)];
    CheckExternalEvents(cs14, 0x956);
    // MOV DH,AL (19EF_0954 / 0x1A844)
    DH = AL;
    CheckExternalEvents(cs14, 0x959);
    // MOV BX,word ptr [BP + 0x12] (19EF_0956 / 0x1A846)
    BX = UInt16[SS, (ushort)(BP + 0x12)];
    CheckExternalEvents(cs14, 0x95A);
    // PUSH DS (19EF_0959 / 0x1A849)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x95E);
    // MOV DS,word ptr [0x25a] (19EF_095A / 0x1A84A)
    DS = UInt16[DS, 0x25A];
    label_19EF_095E_1A84E:
    CheckExternalEvents(cs14, 0x960);
    // MOV CL,DL (19EF_095E / 0x1A84E)
    CL = DL;
    CheckExternalEvents(cs14, 0x962);
    // XOR CH,CH (19EF_0960 / 0x1A850)
    // CH ^= CH;
    CH = Alu8.Xor(CH, CH);
    CheckExternalEvents(cs14, 0x964);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_0962 / 0x1A852)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x966);
    // ADD SI,BX (19EF_0964 / 0x1A854)
    SI += BX;
    CheckExternalEvents(cs14, 0x968);
    // DEC DH (19EF_0966 / 0x1A856)
    DH = Alu8.Dec(DH);
    CheckExternalEvents(cs14, 0x96A);
    // JNZ 0x1000:a84e (19EF_0968 / 0x1A858)
    if(!ZeroFlag) {
      goto label_19EF_095E_1A84E;
    }
    CheckExternalEvents(cs14, 0x96B);
    // POP DS (19EF_096A / 0x1A85A)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x96C);
    // POP ES (19EF_096B / 0x1A85B)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x96D);
    // POP DS (19EF_096C / 0x1A85C)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x96E);
    // POP SI (19EF_096D / 0x1A85D)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x96F);
    // POP DI (19EF_096E / 0x1A85E)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x970);
    // POP BP (19EF_096F / 0x1A85F)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x971);
    // RETF  (19EF_0970 / 0x1A860)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0971_1A861(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0971_1A861:
    CheckExternalEvents(cs14, 0x972);
    // PUSH BP (19EF_0971 / 0x1A861)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x974);
    // MOV BP,SP (19EF_0972 / 0x1A862)
    BP = SP;
    CheckExternalEvents(cs14, 0x975);
    // PUSH DI (19EF_0974 / 0x1A864)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x976);
    // PUSH SI (19EF_0975 / 0x1A865)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x977);
    // PUSH DS (19EF_0976 / 0x1A866)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x97A);
    // MOV AX,0x1ddc (19EF_0977 / 0x1A867)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x97C);
    // MOV DS,AX (19EF_097A / 0x1A86A)
    DS = AX;
    CheckExternalEvents(cs14, 0x97F);
    // MOV AX,word ptr [BP + 0x6] (19EF_097C / 0x1A86C)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x982);
    // MOV [0x238],AX (19EF_097F / 0x1A86F)
    UInt16[DS, 0x238] = AX;
    CheckExternalEvents(cs14, 0x985);
    // MOV AX,word ptr [BP + 0x8] (19EF_0982 / 0x1A872)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x988);
    // MOV [0x23a],AX (19EF_0985 / 0x1A875)
    UInt16[DS, 0x23A] = AX;
    CheckExternalEvents(cs14, 0x98B);
    // MOV AX,word ptr [BP + 0xa] (19EF_0988 / 0x1A878)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x98E);
    // MOV [0x23c],AX (19EF_098B / 0x1A87B)
    UInt16[DS, 0x23C] = AX;
    CheckExternalEvents(cs14, 0x991);
    // MOV AX,word ptr [BP + 0xc] (19EF_098E / 0x1A87E)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x994);
    // MOV [0x23e],AX (19EF_0991 / 0x1A881)
    UInt16[DS, 0x23E] = AX;
    CheckExternalEvents(cs14, 0x997);
    // MOV AX,[0x23a] (19EF_0994 / 0x1A884)
    AX = UInt16[DS, 0x23A];
    CheckExternalEvents(cs14, 0x99B);
    // MOV BX,word ptr [0x23e] (19EF_0997 / 0x1A887)
    BX = UInt16[DS, 0x23E];
    CheckExternalEvents(cs14, 0x99D);
    // SUB AL,BL (19EF_099B / 0x1A88B)
    AL -= BL;
    CheckExternalEvents(cs14, 0x99F);
    // XOR DX,DX (19EF_099D / 0x1A88D)
    // DX ^= DX;
    DX = Alu16.Xor(DX, DX);
    CheckExternalEvents(cs14, 0x9A1);
    // MOV DL,AL (19EF_099F / 0x1A88F)
    DL = AL;
    CheckExternalEvents(cs14, 0x9A3);
    // OR DL,DL (19EF_09A1 / 0x1A891)
    // DL |= DL;
    DL = Alu8.Or(DL, DL);
    CheckExternalEvents(cs14, 0x9A5);
    // JNS 0x1000:a897 (19EF_09A3 / 0x1A893)
    if(!SignFlag) {
      goto label_19EF_09A7_1A897;
    }
    CheckExternalEvents(cs14, 0x9A7);
    // DEC DH (19EF_09A5 / 0x1A895)
    DH--;
    label_19EF_09A7_1A897:
    CheckExternalEvents(cs14, 0x9AA);
    // AND AH,0xf0 (19EF_09A7 / 0x1A897)
    AH &= 0xF0;
    CheckExternalEvents(cs14, 0x9AD);
    // AND BH,0xf0 (19EF_09AA / 0x1A89A)
    BH &= 0xF0;
    CheckExternalEvents(cs14, 0x9AF);
    // CMP BH,AH (19EF_09AD / 0x1A89D)
    Alu8.Sub(BH, AH);
    CheckExternalEvents(cs14, 0x9B1);
    // JZ 0x1000:a8ab (19EF_09AF / 0x1A89F)
    if(ZeroFlag) {
      goto label_19EF_09BB_1A8AB;
    }
    CheckExternalEvents(cs14, 0x9B3);
    // JC 0x1000:a8a8 (19EF_09B1 / 0x1A8A1)
    if(CarryFlag) {
      goto label_19EF_09B8_1A8A8;
    }
    CheckExternalEvents(cs14, 0x9B6);
    // OR DX,0xff80 (19EF_09B3 / 0x1A8A3)
    // DX |= 0xFF80;
    DX = Alu16.Or(DX, 0xFF80);
    CheckExternalEvents(cs14, 0x9B8);
    // JNZ 0x1000:a8ab (19EF_09B6 / 0x1A8A6)
    if(!ZeroFlag) {
      goto label_19EF_09BB_1A8AB;
    }
    label_19EF_09B8_1A8A8:
    CheckExternalEvents(cs14, 0x9BB);
    // AND DX,0x7f (19EF_09B8 / 0x1A8A8)
    // DX &= 0x7F;
    DX = Alu16.And(DX, 0x7F);
    label_19EF_09BB_1A8AB:
    CheckExternalEvents(cs14, 0x9BD);
    // MOV DI,DX (19EF_09BB / 0x1A8AB)
    DI = DX;
    CheckExternalEvents(cs14, 0x9BF);
    // XOR DX,DX (19EF_09BD / 0x1A8AD)
    // DX ^= DX;
    DX = Alu16.Xor(DX, DX);
    CheckExternalEvents(cs14, 0x9C2);
    // MOV AX,[0x238] (19EF_09BF / 0x1A8AF)
    AX = UInt16[DS, 0x238];
    CheckExternalEvents(cs14, 0x9C6);
    // MOV BX,word ptr [0x23c] (19EF_09C2 / 0x1A8B2)
    BX = UInt16[DS, 0x23C];
    CheckExternalEvents(cs14, 0x9C8);
    // MOV CX,BX (19EF_09C6 / 0x1A8B6)
    CX = BX;
    CheckExternalEvents(cs14, 0x9CA);
    // SUB CX,AX (19EF_09C8 / 0x1A8B8)
    CX -= AX;
    CheckExternalEvents(cs14, 0x9CC);
    // CMP BH,AH (19EF_09CA / 0x1A8BA)
    Alu8.Sub(BH, AH);
    CheckExternalEvents(cs14, 0x9CE);
    // JZ 0x1000:a8ca (19EF_09CC / 0x1A8BC)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_A8C6_1A8C6, 0x1A8CA - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x9D0);
    // JC 0x1000:a8c6 (19EF_09CE / 0x1A8BE)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A8C6_1A8C6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x9D3);
    // AND CX,0x7f (19EF_09D0 / 0x1A8C0)
    // CX &= 0x7F;
    CX = Alu16.And(CX, 0x7F);
    CheckExternalEvents(cs14, 0x9D5);
    // JMP 0x1000:a8ca (19EF_09D3 / 0x1A8C3)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A8C6_1A8C6, 0x1A8CA - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_A8C6_1A8C6(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1A8CA: goto label_1000_A8CA_1A8CA;break; // Target of external jump from 0x1A8BC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_A8C6_1A8C6:
    CheckExternalEvents(cs8, 0xA8CA);
    // OR CX,0x80 (1000_A8C6 / 0x1A8C6)
    // CX |= 0x80;
    CX = Alu16.Or(CX, 0x80);
    label_1000_A8CA_1A8CA:
    CheckExternalEvents(cs8, 0xA8CC);
    // MOV BX,CX (1000_A8CA / 0x1A8CA)
    BX = CX;
    CheckExternalEvents(cs8, 0xA8CE);
    // OR BX,BX (1000_A8CC / 0x1A8CC)
    // BX |= BX;
    BX = Alu16.Or(BX, BX);
    CheckExternalEvents(cs8, 0xA8D0);
    // JNS 0x1000:a8d2 (1000_A8CE / 0x1A8CE)
    if(!SignFlag) {
      goto label_1000_A8D2_1A8D2;
    }
    CheckExternalEvents(cs8, 0xA8D2);
    // NEG BX (1000_A8D0 / 0x1A8D0)
    BX = Alu16.Sub(0, BX);
    label_1000_A8D2_1A8D2:
    CheckExternalEvents(cs8, 0xA8D4);
    // MOV AX,DI (1000_A8D2 / 0x1A8D2)
    AX = DI;
    CheckExternalEvents(cs8, 0xA8D6);
    // SHL AX,0x1 (1000_A8D4 / 0x1A8D4)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0xA8D8);
    // CMP AX,BX (1000_A8D6 / 0x1A8D6)
    Alu16.Sub(AX, BX);
    CheckExternalEvents(cs8, 0xA8DA);
    // JL 0x1000:a8dd (1000_A8D8 / 0x1A8D8)
    if(SignFlag != OverflowFlag) {
      goto label_1000_A8DD_1A8DD;
    }
    CheckExternalEvents(cs8, 0xA8DD);
    // OR DX,0x8 (1000_A8DA / 0x1A8DA)
    // DX |= 0x8;
    DX = Alu16.Or(DX, 0x8);
    label_1000_A8DD_1A8DD:
    CheckExternalEvents(cs8, 0xA8DF);
    // MOV AX,DI (1000_A8DD / 0x1A8DD)
    AX = DI;
    CheckExternalEvents(cs8, 0xA8E1);
    // NEG AX (1000_A8DF / 0x1A8DF)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs8, 0xA8E3);
    // SHL AX,0x1 (1000_A8E1 / 0x1A8E1)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0xA8E5);
    // CMP AX,BX (1000_A8E3 / 0x1A8E3)
    Alu16.Sub(AX, BX);
    CheckExternalEvents(cs8, 0xA8E7);
    // JL 0x1000:a8ea (1000_A8E5 / 0x1A8E5)
    if(SignFlag != OverflowFlag) {
      goto label_1000_A8EA_1A8EA;
    }
    CheckExternalEvents(cs8, 0xA8EA);
    // OR DX,0x4 (1000_A8E7 / 0x1A8E7)
    // DX |= 0x4;
    DX = Alu16.Or(DX, 0x4);
    label_1000_A8EA_1A8EA:
    CheckExternalEvents(cs8, 0xA8EC);
    // MOV BX,DI (1000_A8EA / 0x1A8EA)
    BX = DI;
    CheckExternalEvents(cs8, 0xA8EE);
    // OR BX,BX (1000_A8EC / 0x1A8EC)
    // BX |= BX;
    BX = Alu16.Or(BX, BX);
    CheckExternalEvents(cs8, 0xA8F0);
    // JNS 0x1000:a8f2 (1000_A8EE / 0x1A8EE)
    if(!SignFlag) {
      goto label_1000_A8F2_1A8F2;
    }
    CheckExternalEvents(cs8, 0xA8F2);
    // NEG BX (1000_A8F0 / 0x1A8F0)
    BX = Alu16.Sub(0, BX);
    label_1000_A8F2_1A8F2:
    CheckExternalEvents(cs8, 0xA8F4);
    // MOV AX,CX (1000_A8F2 / 0x1A8F2)
    AX = CX;
    CheckExternalEvents(cs8, 0xA8F6);
    // SHL AX,0x1 (1000_A8F4 / 0x1A8F4)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0xA8F8);
    // CMP AX,BX (1000_A8F6 / 0x1A8F6)
    Alu16.Sub(AX, BX);
    CheckExternalEvents(cs8, 0xA8FA);
    // JL 0x1000:a8fd (1000_A8F8 / 0x1A8F8)
    if(SignFlag != OverflowFlag) {
      goto label_1000_A8FD_1A8FD;
    }
    CheckExternalEvents(cs8, 0xA8FD);
    // OR DX,0x2 (1000_A8FA / 0x1A8FA)
    // DX |= 0x2;
    DX = Alu16.Or(DX, 0x2);
    label_1000_A8FD_1A8FD:
    CheckExternalEvents(cs8, 0xA8FF);
    // MOV AX,CX (1000_A8FD / 0x1A8FD)
    AX = CX;
    CheckExternalEvents(cs8, 0xA901);
    // NEG AX (1000_A8FF / 0x1A8FF)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs8, 0xA903);
    // SHL AX,0x1 (1000_A901 / 0x1A901)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0xA905);
    // CMP AX,BX (1000_A903 / 0x1A903)
    Alu16.Sub(AX, BX);
    CheckExternalEvents(cs8, 0xA907);
    // JL 0x1000:a90a (1000_A905 / 0x1A905)
    if(SignFlag != OverflowFlag) {
      goto label_1000_A90A_1A90A;
    }
    CheckExternalEvents(cs8, 0xA90A);
    // OR DX,0x1 (1000_A907 / 0x1A907)
    // DX |= 0x1;
    DX = Alu16.Or(DX, 0x1);
    label_1000_A90A_1A90A:
    CheckExternalEvents(cs8, 0xA90C);
    // MOV BX,DX (1000_A90A / 0x1A90A)
    BX = DX;
    CheckExternalEvents(cs8, 0xA910);
    // MOV AL,byte ptr [BX + 0x240] (1000_A90C / 0x1A90C)
    AL = UInt8[DS, (ushort)(BX + 0x240)];
    CheckExternalEvents(cs8, 0xA911);
    // CBW  (1000_A910 / 0x1A910)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0xA912);
    // POP DS (1000_A911 / 0x1A911)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA913);
    // POP SI (1000_A912 / 0x1A912)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA914);
    // POP DI (1000_A913 / 0x1A913)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA915);
    // POP BP (1000_A914 / 0x1A914)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA916);
    // RETF  (1000_A915 / 0x1A915)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A916_1A916(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A916_1A916:
    CheckExternalEvents(cs8, 0xA917);
    // PUSH BP (1000_A916 / 0x1A916)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xA919);
    // MOV BP,SP (1000_A917 / 0x1A917)
    BP = SP;
    CheckExternalEvents(cs8, 0xA91A);
    // PUSH DI (1000_A919 / 0x1A919)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xA91B);
    // PUSH SI (1000_A91A / 0x1A91A)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xA91C);
    // PUSH DS (1000_A91B / 0x1A91B)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xA91F);
    // MOV AX,0x1ddc (1000_A91C / 0x1A91C)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xA921);
    // MOV DS,AX (1000_A91F / 0x1A91F)
    DS = AX;
    CheckExternalEvents(cs8, 0xA924);
    // MOV SI,word ptr [BP + 0x6] (1000_A921 / 0x1A921)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xA927);
    // MOV DX,word ptr [BP + 0x8] (1000_A924 / 0x1A924)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0xA92A);
    // MOV DI,word ptr [BP + 0xa] (1000_A927 / 0x1A927)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0xA92D);
    // MOV AX,word ptr [BP + 0xc] (1000_A92A / 0x1A92A)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0xA92E);
    // PUSH ES (1000_A92D / 0x1A92D)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xA930);
    // MOV ES,AX (1000_A92E / 0x1A92E)
    ES = AX;
    CheckExternalEvents(cs8, 0xA933);
    // MOV CX,0x3e80 (1000_A930 / 0x1A930)
    CX = 0x3E80;
    CheckExternalEvents(cs8, 0xA934);
    // PUSH DS (1000_A933 / 0x1A933)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xA936);
    // MOV DS,DX (1000_A934 / 0x1A934)
    DS = DX;
    CheckExternalEvents(cs8, 0xA939);
    // MOV DX,0xf00f (1000_A936 / 0x1A936)
    DX = 0xF00F;
    label_1000_A939_1A939:
    CheckExternalEvents(cs8, 0xA93A);
    // LODSW SI (1000_A939 / 0x1A939)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs8, 0xA93C);
    // XOR BL,BL (1000_A93A / 0x1A93A)
    BL = 0;
    CheckExternalEvents(cs8, 0xA93E);
    // TEST DH,AL (1000_A93C / 0x1A93C)
    Alu8.And(DH, AL);
    CheckExternalEvents(cs8, 0xA940);
    // JZ 0x1000:a943 (1000_A93E / 0x1A93E)
    if(ZeroFlag) {
      goto label_1000_A943_1A943;
    }
    CheckExternalEvents(cs8, 0xA943);
    // OR BL,0xc0 (1000_A940 / 0x1A940)
    BL |= 0xC0;
    label_1000_A943_1A943:
    CheckExternalEvents(cs8, 0xA945);
    // TEST DL,AL (1000_A943 / 0x1A943)
    Alu8.And(DL, AL);
    CheckExternalEvents(cs8, 0xA947);
    // JZ 0x1000:a94a (1000_A945 / 0x1A945)
    if(ZeroFlag) {
      goto label_1000_A94A_1A94A;
    }
    CheckExternalEvents(cs8, 0xA94A);
    // OR BL,0x30 (1000_A947 / 0x1A947)
    BL |= 0x30;
    label_1000_A94A_1A94A:
    CheckExternalEvents(cs8, 0xA94C);
    // TEST DH,AH (1000_A94A / 0x1A94A)
    Alu8.And(DH, AH);
    CheckExternalEvents(cs8, 0xA94E);
    // JZ 0x1000:a951 (1000_A94C / 0x1A94C)
    if(ZeroFlag) {
      goto label_1000_A951_1A951;
    }
    CheckExternalEvents(cs8, 0xA951);
    // OR BL,0xc (1000_A94E / 0x1A94E)
    BL |= 0xC;
    label_1000_A951_1A951:
    CheckExternalEvents(cs8, 0xA953);
    // TEST DL,AH (1000_A951 / 0x1A951)
    Alu8.And(DL, AH);
    CheckExternalEvents(cs8, 0xA955);
    // JZ 0x1000:a958 (1000_A953 / 0x1A953)
    if(ZeroFlag) {
      goto label_1000_A958_1A958;
    }
    CheckExternalEvents(cs8, 0xA958);
    // OR BL,0x3 (1000_A955 / 0x1A955)
    // BL |= 0x3;
    BL = Alu8.Or(BL, 0x3);
    label_1000_A958_1A958:
    CheckExternalEvents(cs8, 0xA95A);
    // MOV AL,BL (1000_A958 / 0x1A958)
    AL = BL;
    CheckExternalEvents(cs8, 0xA95C);
    // NOT AL (1000_A95A / 0x1A95A)
    AL = (byte)(~AL);
    CheckExternalEvents(cs8, 0xA95D);
    // STOSB ES:DI (1000_A95C / 0x1A95C)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xA95F);
    // LOOP 0x1000:a939 (1000_A95D / 0x1A95D)
    if(--CX != 0) {
      goto label_1000_A939_1A939;
    }
    CheckExternalEvents(cs8, 0xA960);
    // POP DS (1000_A95F / 0x1A95F)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA961);
    // POP ES (1000_A960 / 0x1A960)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA962);
    // POP DS (1000_A961 / 0x1A961)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA963);
    // POP SI (1000_A962 / 0x1A962)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA964);
    // POP DI (1000_A963 / 0x1A963)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA965);
    // POP BP (1000_A964 / 0x1A964)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA966);
    // RETF  (1000_A965 / 0x1A965)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0A76_1A966(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0A76_1A966:
    CheckExternalEvents(cs14, 0xA77);
    // PUSH BP (19EF_0A76 / 0x1A966)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0xA79);
    // MOV BP,SP (19EF_0A77 / 0x1A967)
    BP = SP;
    CheckExternalEvents(cs14, 0xA7A);
    // PUSH DI (19EF_0A79 / 0x1A969)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0xA7B);
    // PUSH SI (19EF_0A7A / 0x1A96A)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0xA7C);
    // PUSH DS (19EF_0A7B / 0x1A96B)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xA7F);
    // MOV AX,0x1ddc (19EF_0A7C / 0x1A96C)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0xA81);
    // MOV DS,AX (19EF_0A7F / 0x1A96F)
    DS = AX;
    CheckExternalEvents(cs14, 0xA84);
    // MOV SI,word ptr [BP + 0x6] (19EF_0A81 / 0x1A971)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0xA87);
    // MOV DX,word ptr [BP + 0x8] (19EF_0A84 / 0x1A974)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0xA8A);
    // MOV DI,word ptr [BP + 0xa] (19EF_0A87 / 0x1A977)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0xA8D);
    // MOV AX,word ptr [BP + 0xc] (19EF_0A8A / 0x1A97A)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0xA8E);
    // PUSH ES (19EF_0A8D / 0x1A97D)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0xA90);
    // MOV ES,AX (19EF_0A8E / 0x1A97E)
    ES = AX;
    CheckExternalEvents(cs14, 0xA93);
    // MOV CX,word ptr [BP + 0xe] (19EF_0A90 / 0x1A980)
    CX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs14, 0xA94);
    // PUSH DS (19EF_0A93 / 0x1A983)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xA96);
    // MOV DS,DX (19EF_0A94 / 0x1A984)
    DS = DX;
    CheckExternalEvents(cs14, 0xA98);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_0A96 / 0x1A986)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0xA99);
    // POP DS (19EF_0A98 / 0x1A988)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xA9A);
    // POP ES (19EF_0A99 / 0x1A989)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xA9B);
    // POP DS (19EF_0A9A / 0x1A98A)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xA9C);
    // POP SI (19EF_0A9B / 0x1A98B)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xA9D);
    // POP DI (19EF_0A9C / 0x1A98C)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xA9E);
    // POP BP (19EF_0A9D / 0x1A98D)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xA9F);
    // RETF  (19EF_0A9E / 0x1A98E)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0A9F_1A98F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0A9F_1A98F:
    CheckExternalEvents(cs14, 0xAA0);
    // PUSH BP (19EF_0A9F / 0x1A98F)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0xAA2);
    // MOV BP,SP (19EF_0AA0 / 0x1A990)
    BP = SP;
    CheckExternalEvents(cs14, 0xAA3);
    // PUSH DI (19EF_0AA2 / 0x1A992)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0xAA4);
    // PUSH SI (19EF_0AA3 / 0x1A993)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0xAA5);
    // PUSH DS (19EF_0AA4 / 0x1A994)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xAA8);
    // MOV AX,0x1ddc (19EF_0AA5 / 0x1A995)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0xAAA);
    // MOV DS,AX (19EF_0AA8 / 0x1A998)
    DS = AX;
    CheckExternalEvents(cs14, 0xAAD);
    // MOV DX,0x3ce (19EF_0AAA / 0x1A99A)
    DX = 0x3CE;
    CheckExternalEvents(cs14, 0xAB0);
    // MOV AX,0x5 (19EF_0AAD / 0x1A99D)
    AX = 0x5;
    CheckExternalEvents(cs14, 0xAB1);
    // OUT DX,AX (19EF_0AB0 / 0x1A9A0)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xAB4);
    // MOV AX,0xff08 (19EF_0AB1 / 0x1A9A1)
    AX = 0xFF08;
    CheckExternalEvents(cs14, 0xAB5);
    // OUT DX,AX (19EF_0AB4 / 0x1A9A4)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xAB8);
    // MOV AX,0x1 (19EF_0AB5 / 0x1A9A5)
    AX = 0x1;
    CheckExternalEvents(cs14, 0xAB9);
    // OUT DX,AX (19EF_0AB8 / 0x1A9A8)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xABC);
    // MOV AX,word ptr [BP + 0x6] (19EF_0AB9 / 0x1A9A9)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0xABE);
    // MOV SI,AX (19EF_0ABC / 0x1A9AC)
    SI = AX;
    CheckExternalEvents(cs14, 0xAC1);
    // MOV AX,0xa400 (19EF_0ABE / 0x1A9AE)
    AX = 0xA400;
    CheckExternalEvents(cs14, 0xAC2);
    // PUSH ES (19EF_0AC1 / 0x1A9B1)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0xAC4);
    // MOV ES,AX (19EF_0AC2 / 0x1A9B2)
    ES = AX;
    CheckExternalEvents(cs14, 0xAC7);
    // MOV DI,word ptr [BP + 0xa] (19EF_0AC4 / 0x1A9B4)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0xACA);
    // MOV AX,word ptr [BP + 0x8] (19EF_0AC7 / 0x1A9B7)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0xACB);
    // PUSH DS (19EF_0ACA / 0x1A9BA)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xACD);
    // MOV DS,AX (19EF_0ACB / 0x1A9BB)
    DS = AX;
    CheckExternalEvents(cs14, 0xAD0);
    // MOV CX,0x10 (19EF_0ACD / 0x1A9BD)
    CX = 0x10;
    CheckExternalEvents(cs14, 0xAD3);
    // MOV DX,0x3c4 (19EF_0AD0 / 0x1A9C0)
    DX = 0x3C4;
    label_19EF_0AD3_1A9C3:
    CheckExternalEvents(cs14, 0xAD6);
    // MOV AX,0x102 (19EF_0AD3 / 0x1A9C3)
    AX = 0x102;
    CheckExternalEvents(cs14, 0xAD7);
    // OUT DX,AX (19EF_0AD6 / 0x1A9C6)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xADA);
    // MOV AL,byte ptr ES:[DI] (19EF_0AD7 / 0x1A9C7)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0xADB);
    // MOVSB ES:DI,SI (19EF_0ADA / 0x1A9CA)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0xADC);
    // DEC DI (19EF_0ADB / 0x1A9CB)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs14, 0xADF);
    // MOV AX,0x202 (19EF_0ADC / 0x1A9CC)
    AX = 0x202;
    CheckExternalEvents(cs14, 0xAE0);
    // OUT DX,AX (19EF_0ADF / 0x1A9CF)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xAE3);
    // MOV AL,byte ptr ES:[DI] (19EF_0AE0 / 0x1A9D0)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0xAE4);
    // MOVSB ES:DI,SI (19EF_0AE3 / 0x1A9D3)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0xAE5);
    // DEC DI (19EF_0AE4 / 0x1A9D4)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs14, 0xAE8);
    // MOV AX,0x402 (19EF_0AE5 / 0x1A9D5)
    AX = 0x402;
    CheckExternalEvents(cs14, 0xAE9);
    // OUT DX,AX (19EF_0AE8 / 0x1A9D8)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xAEC);
    // MOV AL,byte ptr ES:[DI] (19EF_0AE9 / 0x1A9D9)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0xAED);
    // MOVSB ES:DI,SI (19EF_0AEC / 0x1A9DC)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0xAEE);
    // DEC DI (19EF_0AED / 0x1A9DD)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs14, 0xAF1);
    // MOV AX,0x802 (19EF_0AEE / 0x1A9DE)
    AX = 0x802;
    CheckExternalEvents(cs14, 0xAF2);
    // OUT DX,AX (19EF_0AF1 / 0x1A9E1)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xAF5);
    // MOV AL,byte ptr ES:[DI] (19EF_0AF2 / 0x1A9E2)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0xAF6);
    // MOVSB ES:DI,SI (19EF_0AF5 / 0x1A9E5)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0xAF9);
    // MOV AX,0x102 (19EF_0AF6 / 0x1A9E6)
    AX = 0x102;
    CheckExternalEvents(cs14, 0xAFA);
    // OUT DX,AX (19EF_0AF9 / 0x1A9E9)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xAFD);
    // MOV AL,byte ptr ES:[DI] (19EF_0AFA / 0x1A9EA)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0xAFE);
    // MOVSB ES:DI,SI (19EF_0AFD / 0x1A9ED)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0xAFF);
    // DEC DI (19EF_0AFE / 0x1A9EE)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs14, 0xB02);
    // MOV AX,0x202 (19EF_0AFF / 0x1A9EF)
    AX = 0x202;
    CheckExternalEvents(cs14, 0xB03);
    // OUT DX,AX (19EF_0B02 / 0x1A9F2)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xB06);
    // MOV AL,byte ptr ES:[DI] (19EF_0B03 / 0x1A9F3)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0xB07);
    // MOVSB ES:DI,SI (19EF_0B06 / 0x1A9F6)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0xB08);
    // DEC DI (19EF_0B07 / 0x1A9F7)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs14, 0xB0B);
    // MOV AX,0x402 (19EF_0B08 / 0x1A9F8)
    AX = 0x402;
    CheckExternalEvents(cs14, 0xB0C);
    // OUT DX,AX (19EF_0B0B / 0x1A9FB)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xB0F);
    // MOV AL,byte ptr ES:[DI] (19EF_0B0C / 0x1A9FC)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0xB10);
    // MOVSB ES:DI,SI (19EF_0B0F / 0x1A9FF)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0xB11);
    // DEC DI (19EF_0B10 / 0x1AA00)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs14, 0xB14);
    // MOV AX,0x802 (19EF_0B11 / 0x1AA01)
    AX = 0x802;
    CheckExternalEvents(cs14, 0xB15);
    // OUT DX,AX (19EF_0B14 / 0x1AA04)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xB18);
    // MOV AL,byte ptr ES:[DI] (19EF_0B15 / 0x1AA05)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0xB19);
    // MOVSB ES:DI,SI (19EF_0B18 / 0x1AA08)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0xB1B);
    // LOOP 0x1000:a9c3 (19EF_0B19 / 0x1AA09)
    if(--CX != 0) {
      goto label_19EF_0AD3_1A9C3;
    }
    CheckExternalEvents(cs14, 0xB1E);
    // MOV AX,0xf02 (19EF_0B1B / 0x1AA0B)
    AX = 0xF02;
    CheckExternalEvents(cs14, 0xB1F);
    // OUT DX,AX (19EF_0B1E / 0x1AA0E)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0xB20);
    // POP DS (19EF_0B1F / 0x1AA0F)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB21);
    // POP ES (19EF_0B20 / 0x1AA10)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB22);
    // POP DS (19EF_0B21 / 0x1AA11)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB23);
    // POP SI (19EF_0B22 / 0x1AA12)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB24);
    // POP DI (19EF_0B23 / 0x1AA13)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB25);
    // POP BP (19EF_0B24 / 0x1AA14)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB26);
    // RETF  (19EF_0B25 / 0x1AA15)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0B26_1AA16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0B26_1AA16:
    CheckExternalEvents(cs14, 0xB27);
    // PUSH BP (19EF_0B26 / 0x1AA16)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0xB29);
    // MOV BP,SP (19EF_0B27 / 0x1AA17)
    BP = SP;
    CheckExternalEvents(cs14, 0xB2A);
    // PUSH DI (19EF_0B29 / 0x1AA19)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0xB2B);
    // PUSH SI (19EF_0B2A / 0x1AA1A)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0xB2C);
    // PUSH DS (19EF_0B2B / 0x1AA1B)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xB2F);
    // MOV AX,0x1ddc (19EF_0B2C / 0x1AA1C)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0xB31);
    // MOV DS,AX (19EF_0B2F / 0x1AA1F)
    DS = AX;
    CheckExternalEvents(cs14, 0xB32);
    // PUSH DX (19EF_0B31 / 0x1AA21)
    Stack.Push16(DX);
    CheckExternalEvents(cs14, 0xB35);
    // MOV DX,0x3da (19EF_0B32 / 0x1AA22)
    DX = 0x3DA;
    CheckExternalEvents(cs14, 0xB36);
    // IN AL,DX (19EF_0B35 / 0x1AA25)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs14, 0xB38);
    // AND AL,0x8 (19EF_0B36 / 0x1AA26)
    AL &= 0x8;
    CheckExternalEvents(cs14, 0xB3A);
    // XOR AH,AH (19EF_0B38 / 0x1AA28)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0xB3B);
    // POP DX (19EF_0B3A / 0x1AA2A)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB3C);
    // POP DS (19EF_0B3B / 0x1AA2B)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB3D);
    // POP SI (19EF_0B3C / 0x1AA2C)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB3E);
    // POP DI (19EF_0B3D / 0x1AA2D)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB3F);
    // POP BP (19EF_0B3E / 0x1AA2E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB40);
    // RETF  (19EF_0B3F / 0x1AA2F)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0B40_1AA30(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0B40_1AA30:
    CheckExternalEvents(cs14, 0xB41);
    // PUSH BP (19EF_0B40 / 0x1AA30)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0xB43);
    // MOV BP,SP (19EF_0B41 / 0x1AA31)
    BP = SP;
    CheckExternalEvents(cs14, 0xB44);
    // PUSH DI (19EF_0B43 / 0x1AA33)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0xB45);
    // PUSH SI (19EF_0B44 / 0x1AA34)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0xB46);
    // PUSH DS (19EF_0B45 / 0x1AA35)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xB49);
    // MOV AX,0x1ddc (19EF_0B46 / 0x1AA36)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0xB4B);
    // MOV DS,AX (19EF_0B49 / 0x1AA39)
    DS = AX;
    CheckExternalEvents(cs14, 0xB4E);
    // MOV BL,byte ptr [BP + 0x6] (19EF_0B4B / 0x1AA3B)
    BL = UInt8[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0xB4F);
    // PUSH DX (19EF_0B4E / 0x1AA3E)
    Stack.Push16(DX);
    CheckExternalEvents(cs14, 0xB52);
    // MOV DX,0x3da (19EF_0B4F / 0x1AA3F)
    DX = 0x3DA;
    CheckExternalEvents(cs14, 0xB55);
    // CMP BL,0x1 (19EF_0B52 / 0x1AA42)
    Alu8.Sub(BL, 0x1);
    CheckExternalEvents(cs14, 0xB57);
    // JZ 0x1000:aa53 (19EF_0B55 / 0x1AA45)
    if(ZeroFlag) {
      goto label_19EF_0B63_1AA53;
    }
    label_19EF_0B57_1AA47:
    CheckExternalEvents(cs14, 0xB58);
    // IN AL,DX (19EF_0B57 / 0x1AA47)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs14, 0xB5A);
    // TEST AL,0x8 (19EF_0B58 / 0x1AA48)
    Alu8.And(AL, 0x8);
    CheckExternalEvents(cs14, 0xB5C);
    // JZ 0x1000:aa47 (19EF_0B5A / 0x1AA4A)
    if(ZeroFlag) {
      goto label_19EF_0B57_1AA47;
    }
    label_19EF_0B5C_1AA4C:
    CheckExternalEvents(cs14, 0xB5D);
    // IN AL,DX (19EF_0B5C / 0x1AA4C)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs14, 0xB5F);
    // TEST AL,0x8 (19EF_0B5D / 0x1AA4D)
    Alu8.And(AL, 0x8);
    CheckExternalEvents(cs14, 0xB61);
    // JNZ 0x1000:aa4c (19EF_0B5F / 0x1AA4F)
    if(!ZeroFlag) {
      goto label_19EF_0B5C_1AA4C;
    }
    CheckExternalEvents(cs14, 0xB63);
    // JZ 0x1000:aa5d (19EF_0B61 / 0x1AA51)
    if(ZeroFlag) {
      goto label_19EF_0B6D_1AA5D;
    }
    label_19EF_0B63_1AA53:
    CheckExternalEvents(cs14, 0xB64);
    // IN AL,DX (19EF_0B63 / 0x1AA53)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs14, 0xB66);
    // TEST AL,0x8 (19EF_0B64 / 0x1AA54)
    Alu8.And(AL, 0x8);
    CheckExternalEvents(cs14, 0xB68);
    // JNZ 0x1000:aa53 (19EF_0B66 / 0x1AA56)
    if(!ZeroFlag) {
      goto label_19EF_0B63_1AA53;
    }
    label_19EF_0B68_1AA58:
    CheckExternalEvents(cs14, 0xB69);
    // IN AL,DX (19EF_0B68 / 0x1AA58)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs14, 0xB6B);
    // TEST AL,0x8 (19EF_0B69 / 0x1AA59)
    Alu8.And(AL, 0x8);
    CheckExternalEvents(cs14, 0xB6D);
    // JZ 0x1000:aa58 (19EF_0B6B / 0x1AA5B)
    if(ZeroFlag) {
      goto label_19EF_0B68_1AA58;
    }
    label_19EF_0B6D_1AA5D:
    CheckExternalEvents(cs14, 0xB6E);
    // POP DX (19EF_0B6D / 0x1AA5D)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB6F);
    // POP DS (19EF_0B6E / 0x1AA5E)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB70);
    // POP SI (19EF_0B6F / 0x1AA5F)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB71);
    // POP DI (19EF_0B70 / 0x1AA60)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB72);
    // POP BP (19EF_0B71 / 0x1AA61)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB73);
    // RETF  (19EF_0B72 / 0x1AA62)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0B73_1AA63(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0B73_1AA63:
    CheckExternalEvents(cs14, 0xB74);
    // PUSH BP (19EF_0B73 / 0x1AA63)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0xB76);
    // MOV BP,SP (19EF_0B74 / 0x1AA64)
    BP = SP;
    CheckExternalEvents(cs14, 0xB77);
    // PUSH DI (19EF_0B76 / 0x1AA66)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0xB78);
    // PUSH SI (19EF_0B77 / 0x1AA67)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0xB79);
    // PUSH DS (19EF_0B78 / 0x1AA68)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xB7C);
    // MOV AX,0x1ddc (19EF_0B79 / 0x1AA69)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0xB7E);
    // MOV DS,AX (19EF_0B7C / 0x1AA6C)
    DS = AX;
    CheckExternalEvents(cs14, 0xB81);
    // MOV AX,word ptr [BP + 0x6] (19EF_0B7E / 0x1AA6E)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0xB83);
    // XOR AH,AH (19EF_0B81 / 0x1AA71)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0xB85);
    // INT 0x10 (19EF_0B83 / 0x1AA73)
    Interrupt(0x10);
    CheckExternalEvents(cs14, 0xB86);
    // POP DS (19EF_0B85 / 0x1AA75)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB87);
    // POP SI (19EF_0B86 / 0x1AA76)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB88);
    // POP DI (19EF_0B87 / 0x1AA77)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB89);
    // POP BP (19EF_0B88 / 0x1AA78)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xB8A);
    // RETF  (19EF_0B89 / 0x1AA79)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0B8A_1AA7A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0B8A_1AA7A:
    CheckExternalEvents(cs14, 0xB8B);
    // PUSH BP (19EF_0B8A / 0x1AA7A)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0xB8D);
    // MOV BP,SP (19EF_0B8B / 0x1AA7B)
    BP = SP;
    CheckExternalEvents(cs14, 0xB8E);
    // PUSH DI (19EF_0B8D / 0x1AA7D)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0xB8F);
    // PUSH SI (19EF_0B8E / 0x1AA7E)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0xB90);
    // PUSH DS (19EF_0B8F / 0x1AA7F)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xB93);
    // MOV AX,0x1ddc (19EF_0B90 / 0x1AA80)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0xB95);
    // MOV DS,AX (19EF_0B93 / 0x1AA83)
    DS = AX;
    CheckExternalEvents(cs14, 0xB97);
    // XOR AH,AH (19EF_0B95 / 0x1AA85)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0xB99);
    // INT 0x16 (19EF_0B97 / 0x1AA87)
    Interrupt(0x16);
    CheckExternalEvents(cs14, 0xB9B);
    // CMP AL,0x0 (19EF_0B99 / 0x1AA89)
    Alu8.Sub(AL, 0x0);
    CheckExternalEvents(cs14, 0xB9D);
    // JNZ 0x1000:aa91 (19EF_0B9B / 0x1AA8B)
    if(!ZeroFlag) {
      goto label_19EF_0BA1_1AA91;
    }
    CheckExternalEvents(cs14, 0xB9F);
    // MOV AL,AH (19EF_0B9D / 0x1AA8D)
    AL = AH;
    CheckExternalEvents(cs14, 0xBA1);
    // NEG AL (19EF_0B9F / 0x1AA8F)
    AL = Alu8.Sub(0, AL);
    label_19EF_0BA1_1AA91:
    CheckExternalEvents(cs14, 0xBA2);
    // CBW  (19EF_0BA1 / 0x1AA91)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs14, 0xBA3);
    // POP DS (19EF_0BA2 / 0x1AA92)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xBA4);
    // POP SI (19EF_0BA3 / 0x1AA93)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xBA5);
    // POP DI (19EF_0BA4 / 0x1AA94)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xBA6);
    // POP BP (19EF_0BA5 / 0x1AA95)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xBA7);
    // RETF  (19EF_0BA6 / 0x1AA96)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_AA97_1AA97(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_AA97_1AA97:
    CheckExternalEvents(cs8, 0xAA98);
    // PUSH BP (1000_AA97 / 0x1AA97)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xAA9A);
    // MOV BP,SP (1000_AA98 / 0x1AA98)
    BP = SP;
    CheckExternalEvents(cs8, 0xAA9B);
    // PUSH DI (1000_AA9A / 0x1AA9A)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xAA9C);
    // PUSH SI (1000_AA9B / 0x1AA9B)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xAA9D);
    // PUSH DS (1000_AA9C / 0x1AA9C)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xAAA0);
    // MOV AX,0x1ddc (1000_AA9D / 0x1AA9D)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xAAA2);
    // MOV DS,AX (1000_AAA0 / 0x1AAA0)
    DS = AX;
    CheckExternalEvents(cs8, 0xAAA5);
    // MOV BX,word ptr [BP + 0x6] (1000_AAA2 / 0x1AAA2)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xAAA7);
    // MOV BH,0x1 (1000_AAA5 / 0x1AAA5)
    BH = 0x1;
    CheckExternalEvents(cs8, 0xAAA9);
    // MOV AH,0xb (1000_AAA7 / 0x1AAA7)
    AH = 0xB;
    CheckExternalEvents(cs8, 0xAAAB);
    // INT 0x10 (1000_AAA9 / 0x1AAA9)
    Interrupt(0x10);
    CheckExternalEvents(cs8, 0xAAAC);
    // POP DS (1000_AAAB / 0x1AAAB)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xAAAD);
    // POP SI (1000_AAAC / 0x1AAAC)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xAAAE);
    // POP DI (1000_AAAD / 0x1AAAD)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xAAAF);
    // POP BP (1000_AAAE / 0x1AAAE)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xAAB0);
    // RETF  (1000_AAAF / 0x1AAAF)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0BC0_1AAB0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0BC0_1AAB0:
    CheckExternalEvents(cs14, 0xBC1);
    // PUSH BP (19EF_0BC0 / 0x1AAB0)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0xBC3);
    // MOV BP,SP (19EF_0BC1 / 0x1AAB1)
    BP = SP;
    CheckExternalEvents(cs14, 0xBC4);
    // PUSH DI (19EF_0BC3 / 0x1AAB3)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0xBC5);
    // PUSH SI (19EF_0BC4 / 0x1AAB4)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0xBC6);
    // PUSH DS (19EF_0BC5 / 0x1AAB5)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xBC9);
    // MOV AX,0x1ddc (19EF_0BC6 / 0x1AAB6)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0xBCB);
    // MOV DS,AX (19EF_0BC9 / 0x1AAB9)
    DS = AX;
    CheckExternalEvents(cs14, 0xBCC);
    // PUSH ES (19EF_0BCB / 0x1AABB)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0xBCF);
    // MOV AX,0x384b (19EF_0BCC / 0x1AABC)
    AX = 0x384B;
    CheckExternalEvents(cs14, 0xBD1);
    // MOV ES,AX (19EF_0BCF / 0x1AABF)
    ES = AX;
    CheckExternalEvents(cs14, 0xBD4);
    // MOV SI,0x4fc0 (19EF_0BD1 / 0x1AAC1)
    SI = 0x4FC0;
    CheckExternalEvents(cs14, 0xBD6);
    // XOR AH,AH (19EF_0BD4 / 0x1AAC4)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0xBD9);
    // MOV AL,byte ptr ES:[SI] (19EF_0BD6 / 0x1AAC6)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xBDB);
    // SHR AL,0x1 (19EF_0BD9 / 0x1AAC9)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0xBDD);
    // SHR AL,0x1 (19EF_0BDB / 0x1AACB)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0xBE1);
    // RCL byte ptr ES:[SI + 0x2],0x1 (19EF_0BDD / 0x1AACD)
    UInt8[ES, (ushort)(SI + 0x2)] = Alu8.Rcl(UInt8[ES, (ushort)(SI + 0x2)], 0x1);
    CheckExternalEvents(cs14, 0xBE5);
    // RCL byte ptr ES:[SI + 0x1],0x1 (19EF_0BE1 / 0x1AAD1)
    UInt8[ES, (ushort)(SI + 0x1)] = Alu8.Rcl(UInt8[ES, (ushort)(SI + 0x1)], 0x1);
    CheckExternalEvents(cs14, 0xBE6);
    // CMC  (19EF_0BE5 / 0x1AAD5)
    CarryFlag = !CarryFlag;
    CheckExternalEvents(cs14, 0xBE9);
    // SBB AL,byte ptr ES:[SI] (19EF_0BE6 / 0x1AAD6)
    AL = Alu8.Sbb(AL, UInt8[ES, (ushort)(SI)]);
    CheckExternalEvents(cs14, 0xBEB);
    // SHR AL,0x1 (19EF_0BE9 / 0x1AAD9)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0xBEE);
    // RCR byte ptr ES:[SI],0x1 (19EF_0BEB / 0x1AADB)
    UInt8[ES, (ushort)(SI)] = Alu8.Rcr(UInt8[ES, (ushort)(SI)], 0x1);
    CheckExternalEvents(cs14, 0xBF1);
    // MOV AL,byte ptr ES:[SI] (19EF_0BEE / 0x1AADE)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xBF5);
    // XOR AL,byte ptr ES:[SI + 0x1] (19EF_0BF1 / 0x1AAE1)
    // AL ^= UInt8[ES, (ushort)(SI + 0x1)];
    AL = Alu8.Xor(AL, UInt8[ES, (ushort)(SI + 0x1)]);
    CheckExternalEvents(cs14, 0xBF6);
    // POP ES (19EF_0BF5 / 0x1AAE5)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xBF7);
    // POP DS (19EF_0BF6 / 0x1AAE6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xBF8);
    // POP SI (19EF_0BF7 / 0x1AAE7)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xBF9);
    // POP DI (19EF_0BF8 / 0x1AAE8)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xBFA);
    // POP BP (19EF_0BF9 / 0x1AAE9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xBFB);
    // RETF  (19EF_0BFA / 0x1AAEA)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0BFB_1AAEB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0BFB_1AAEB:
    CheckExternalEvents(cs14, 0xBFC);
    // PUSH SI (19EF_0BFB / 0x1AAEB)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0xBFE);
    // MOV SI,DI (19EF_0BFC / 0x1AAEC)
    SI = DI;
    CheckExternalEvents(cs14, 0xC00);
    // MOV DH,byte ptr [DI] (19EF_0BFE / 0x1AAEE)
    DH = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs14, 0xC03);
    // MOV DL,byte ptr [DI + 0x8] (19EF_0C00 / 0x1AAF0)
    DL = UInt8[DS, (ushort)(DI + 0x8)];
    CheckExternalEvents(cs14, 0xC06);
    // MOV BH,byte ptr [DI + 0x48] (19EF_0C03 / 0x1AAF3)
    BH = UInt8[DS, (ushort)(DI + 0x48)];
    CheckExternalEvents(cs14, 0xC09);
    // MOV BL,byte ptr [DI + 0x50] (19EF_0C06 / 0x1AAF6)
    BL = UInt8[DS, (ushort)(DI + 0x50)];
    CheckExternalEvents(cs14, 0xC0A);
    // PUSH ES (19EF_0C09 / 0x1AAF9)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0xC0C);
    // MOV AX,DS (19EF_0C0A / 0x1AAFA)
    AX = DS;
    CheckExternalEvents(cs14, 0xC0E);
    // MOV ES,AX (19EF_0C0C / 0x1AAFC)
    ES = AX;
    CheckExternalEvents(cs14, 0xC11);
    // MOV CX,0x28 (19EF_0C0E / 0x1AAFE)
    CX = 0x28;
    CheckExternalEvents(cs14, 0xC14);
    // MOV AX,0xffff (19EF_0C11 / 0x1AB01)
    AX = 0xFFFF;
    CheckExternalEvents(cs14, 0xC15);
    // CLD  (19EF_0C14 / 0x1AB04)
    DirectionFlag = false;
    CheckExternalEvents(cs14, 0xC17);
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (19EF_0C15 / 0x1AB05)
      UInt16[ES, (ushort)(DI)] = AX;
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0xC18);
    // POP ES (19EF_0C17 / 0x1AB07)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xC1A);
    // MOV DI,SI (19EF_0C18 / 0x1AB08)
    DI = SI;
    CheckExternalEvents(cs14, 0xC1C);
    // MOV byte ptr [DI],DH (19EF_0C1A / 0x1AB0A)
    UInt8[DS, (ushort)(DI)] = DH;
    CheckExternalEvents(cs14, 0xC1F);
    // MOV byte ptr [DI + 0x8],DL (19EF_0C1C / 0x1AB0C)
    UInt8[DS, (ushort)(DI + 0x8)] = DL;
    CheckExternalEvents(cs14, 0xC22);
    // MOV byte ptr [DI + 0x48],BH (19EF_0C1F / 0x1AB0F)
    UInt8[DS, (ushort)(DI + 0x48)] = BH;
    CheckExternalEvents(cs14, 0xC25);
    // MOV byte ptr [DI + 0x50],BL (19EF_0C22 / 0x1AB12)
    UInt8[DS, (ushort)(DI + 0x50)] = BL;
    CheckExternalEvents(cs14, 0xC27);
    // ADD DL,DH (19EF_0C25 / 0x1AB15)
    DL += DH;
    CheckExternalEvents(cs14, 0xC29);
    // XOR DH,DH (19EF_0C27 / 0x1AB17)
    // DH ^= DH;
    DH = Alu8.Xor(DH, DH);
    CheckExternalEvents(cs14, 0xC2D);
    // MOV word ptr [0x9f9],DX (19EF_0C29 / 0x1AB19)
    UInt16[DS, 0x9F9] = DX;
    CheckExternalEvents(cs14, 0xC30);
    // MOV SI,0x279 (19EF_0C2D / 0x1AB1D)
    SI = 0x279;
    CheckExternalEvents(cs14, 0xC33);
    // MOV byte ptr [SI],0x0 (19EF_0C30 / 0x1AB20)
    UInt8[DS, (ushort)(SI)] = 0x0;
    CheckExternalEvents(cs14, 0xC37);
    // MOV byte ptr [SI + 0x1],0x8 (19EF_0C33 / 0x1AB23)
    UInt8[DS, (ushort)(SI + 0x1)] = 0x8;
    CheckExternalEvents(cs14, 0xC3A);
    // ADD SI,0x2 (19EF_0C37 / 0x1AB27)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs14, 0xC3D);
    // CALL 0x1000:abf7 (19EF_0C3A / 0x1AB2A)
    NearCall(cs14, 0xC3D, unknown_19EF_0D07_1ABF7);
    CheckExternalEvents(cs14, 0xC40);
    // MOV AL,byte ptr [DI + 0x48] (19EF_0C3D / 0x1AB2D)
    AL = UInt8[DS, (ushort)(DI + 0x48)];
    CheckExternalEvents(cs14, 0xC43);
    // ADD AL,byte ptr [DI + 0x50] (19EF_0C40 / 0x1AB30)
    AL += UInt8[DS, (ushort)(DI + 0x50)];
    CheckExternalEvents(cs14, 0xC45);
    // XOR AH,AH (19EF_0C43 / 0x1AB33)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0xC48);
    // MOV [0x9f9],AX (19EF_0C45 / 0x1AB35)
    UInt16[DS, 0x9F9] = AX;
    CheckExternalEvents(cs14, 0xC4B);
    // MOV SI,0x279 (19EF_0C48 / 0x1AB38)
    SI = 0x279;
    CheckExternalEvents(cs14, 0xC4E);
    // MOV byte ptr [SI],0x48 (19EF_0C4B / 0x1AB3B)
    UInt8[DS, (ushort)(SI)] = 0x48;
    CheckExternalEvents(cs14, 0xC52);
    // MOV byte ptr [SI + 0x1],0x50 (19EF_0C4E / 0x1AB3E)
    UInt8[DS, (ushort)(SI + 0x1)] = 0x50;
    CheckExternalEvents(cs14, 0xC55);
    // ADD SI,0x2 (19EF_0C52 / 0x1AB42)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs14, 0xC58);
    // CALL 0x1000:abf7 (19EF_0C55 / 0x1AB45)
    NearCall(cs14, 0xC58, unknown_19EF_0D07_1ABF7);
    CheckExternalEvents(cs14, 0xC5A);
    // MOV AL,byte ptr [DI] (19EF_0C58 / 0x1AB48)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs14, 0xC5D);
    // ADD AL,byte ptr [DI + 0x48] (19EF_0C5A / 0x1AB4A)
    AL += UInt8[DS, (ushort)(DI + 0x48)];
    CheckExternalEvents(cs14, 0xC5F);
    // XOR AH,AH (19EF_0C5D / 0x1AB4D)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0xC62);
    // MOV [0x9f9],AX (19EF_0C5F / 0x1AB4F)
    UInt16[DS, 0x9F9] = AX;
    CheckExternalEvents(cs14, 0xC65);
    // MOV SI,0x279 (19EF_0C62 / 0x1AB52)
    SI = 0x279;
    CheckExternalEvents(cs14, 0xC68);
    // MOV byte ptr [SI],0x0 (19EF_0C65 / 0x1AB55)
    UInt8[DS, (ushort)(SI)] = 0x0;
    CheckExternalEvents(cs14, 0xC6C);
    // MOV byte ptr [SI + 0x1],0x48 (19EF_0C68 / 0x1AB58)
    UInt8[DS, (ushort)(SI + 0x1)] = 0x48;
    CheckExternalEvents(cs14, 0xC6F);
    // ADD SI,0x2 (19EF_0C6C / 0x1AB5C)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs14, 0xC72);
    // CALL 0x1000:ac69 (19EF_0C6F / 0x1AB5F)
    NearCall(cs14, 0xC72, unknown_19EF_0D79_1AC69);
    CheckExternalEvents(cs14, 0xC75);
    // MOV AL,byte ptr [DI + 0x8] (19EF_0C72 / 0x1AB62)
    AL = UInt8[DS, (ushort)(DI + 0x8)];
    CheckExternalEvents(cs14, 0xC78);
    // ADD AL,byte ptr [DI + 0x50] (19EF_0C75 / 0x1AB65)
    AL += UInt8[DS, (ushort)(DI + 0x50)];
    CheckExternalEvents(cs14, 0xC7A);
    // XOR AH,AH (19EF_0C78 / 0x1AB68)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0xC7D);
    // MOV [0x9f9],AX (19EF_0C7A / 0x1AB6A)
    UInt16[DS, 0x9F9] = AX;
    CheckExternalEvents(cs14, 0xC80);
    // MOV SI,0x279 (19EF_0C7D / 0x1AB6D)
    SI = 0x279;
    CheckExternalEvents(cs14, 0xC83);
    // MOV byte ptr [SI],0x8 (19EF_0C80 / 0x1AB70)
    UInt8[DS, (ushort)(SI)] = 0x8;
    CheckExternalEvents(cs14, 0xC87);
    // MOV byte ptr [SI + 0x1],0x50 (19EF_0C83 / 0x1AB73)
    UInt8[DS, (ushort)(SI + 0x1)] = 0x50;
    CheckExternalEvents(cs14, 0xC8A);
    // ADD SI,0x2 (19EF_0C87 / 0x1AB77)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs14, 0xC8D);
    // CALL 0x1000:ac69 (19EF_0C8A / 0x1AB7A)
    NearCall(cs14, 0xC8D, unknown_19EF_0D79_1AC69);
    CheckExternalEvents(cs14, 0xC90);
    // MOV SI,0x279 (19EF_0C8D / 0x1AB7D)
    SI = 0x279;
    CheckExternalEvents(cs14, 0xC93);
    // MOV byte ptr [SI],0x0 (19EF_0C90 / 0x1AB80)
    UInt8[DS, (ushort)(SI)] = 0x0;
    CheckExternalEvents(cs14, 0xC97);
    // MOV byte ptr [SI + 0x1],0x8 (19EF_0C93 / 0x1AB83)
    UInt8[DS, (ushort)(SI + 0x1)] = 0x8;
    CheckExternalEvents(cs14, 0xC9B);
    // MOV byte ptr [SI + 0x2],0x48 (19EF_0C97 / 0x1AB87)
    UInt8[DS, (ushort)(SI + 0x2)] = 0x48;
    CheckExternalEvents(cs14, 0xC9F);
    // MOV byte ptr [SI + 0x3],0x50 (19EF_0C9B / 0x1AB8B)
    UInt8[DS, (ushort)(SI + 0x3)] = 0x50;
    CheckExternalEvents(cs14, 0xCA2);
    // ADD SI,0x4 (19EF_0C9F / 0x1AB8F)
    // SI += 0x4;
    SI = Alu16.Add(SI, 0x4);
    CheckExternalEvents(cs14, 0xCA5);
    // CALL 0x1000:ace8 (19EF_0CA2 / 0x1AB92)
    NearCall(cs14, 0xCA5, unknown_19EF_0DF8_1ACE8);
    CheckExternalEvents(cs14, 0xCA6);
    // POP SI (19EF_0CA5 / 0x1AB95)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xCA8);
    // XCHG DI,SI (19EF_0CA6 / 0x1AB96)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs14, 0xCA9);
    // PUSH ES (19EF_0CA8 / 0x1AB98)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0xCAB);
    // MOV AX,DS (19EF_0CA9 / 0x1AB99)
    AX = DS;
    CheckExternalEvents(cs14, 0xCAD);
    // MOV ES,AX (19EF_0CAB / 0x1AB9B)
    ES = AX;
    CheckExternalEvents(cs14, 0xCAE);
    // CLD  (19EF_0CAD / 0x1AB9D)
    DirectionFlag = false;
    CheckExternalEvents(cs14, 0xCB1);
    // MOV CX,0x4 (19EF_0CAE / 0x1AB9E)
    CX = 0x4;
    label_19EF_0CB1_1ABA1:
    CheckExternalEvents(cs14, 0xCB2);
    // LODSW SI (19EF_0CB1 / 0x1ABA1)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0xCB5);
    // AND AX,0xf0f0 (19EF_0CB2 / 0x1ABA2)
    // AX &= 0xF0F0;
    AX = Alu16.And(AX, 0xF0F0);
    CheckExternalEvents(cs14, 0xCB6);
    // STOSW ES:DI (19EF_0CB5 / 0x1ABA5)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0xCB8);
    // LOOP 0x1000:aba1 (19EF_0CB6 / 0x1ABA6)
    if(--CX != 0) {
      goto label_19EF_0CB1_1ABA1;
    }
    CheckExternalEvents(cs14, 0xCB9);
    // INC SI (19EF_0CB8 / 0x1ABA8)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0xCBC);
    // MOV CX,0x4 (19EF_0CB9 / 0x1ABA9)
    CX = 0x4;
    label_19EF_0CBC_1ABAC:
    CheckExternalEvents(cs14, 0xCBD);
    // LODSW SI (19EF_0CBC / 0x1ABAC)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0xCC0);
    // AND AX,0xf0f0 (19EF_0CBD / 0x1ABAD)
    // AX &= 0xF0F0;
    AX = Alu16.And(AX, 0xF0F0);
    CheckExternalEvents(cs14, 0xCC1);
    // STOSW ES:DI (19EF_0CC0 / 0x1ABB0)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0xCC3);
    // LOOP 0x1000:abac (19EF_0CC1 / 0x1ABB1)
    if(--CX != 0) {
      goto label_19EF_0CBC_1ABAC;
    }
    CheckExternalEvents(cs14, 0xCC4);
    // INC SI (19EF_0CC3 / 0x1ABB3)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0xCC7);
    // MOV CX,0x4 (19EF_0CC4 / 0x1ABB4)
    CX = 0x4;
    label_19EF_0CC7_1ABB7:
    CheckExternalEvents(cs14, 0xCC8);
    // LODSW SI (19EF_0CC7 / 0x1ABB7)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0xCCB);
    // AND AX,0xf0f0 (19EF_0CC8 / 0x1ABB8)
    // AX &= 0xF0F0;
    AX = Alu16.And(AX, 0xF0F0);
    CheckExternalEvents(cs14, 0xCCC);
    // STOSW ES:DI (19EF_0CCB / 0x1ABBB)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0xCCE);
    // LOOP 0x1000:abb7 (19EF_0CCC / 0x1ABBC)
    if(--CX != 0) {
      goto label_19EF_0CC7_1ABB7;
    }
    CheckExternalEvents(cs14, 0xCCF);
    // INC SI (19EF_0CCE / 0x1ABBE)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0xCD2);
    // MOV CX,0x4 (19EF_0CCF / 0x1ABBF)
    CX = 0x4;
    label_19EF_0CD2_1ABC2:
    CheckExternalEvents(cs14, 0xCD3);
    // LODSW SI (19EF_0CD2 / 0x1ABC2)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0xCD6);
    // AND AX,0xf0f0 (19EF_0CD3 / 0x1ABC3)
    // AX &= 0xF0F0;
    AX = Alu16.And(AX, 0xF0F0);
    CheckExternalEvents(cs14, 0xCD7);
    // STOSW ES:DI (19EF_0CD6 / 0x1ABC6)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0xCD9);
    // LOOP 0x1000:abc2 (19EF_0CD7 / 0x1ABC7)
    if(--CX != 0) {
      goto label_19EF_0CD2_1ABC2;
    }
    CheckExternalEvents(cs14, 0xCDA);
    // INC SI (19EF_0CD9 / 0x1ABC9)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0xCDD);
    // MOV CX,0x4 (19EF_0CDA / 0x1ABCA)
    CX = 0x4;
    label_19EF_0CDD_1ABCD:
    CheckExternalEvents(cs14, 0xCDE);
    // LODSW SI (19EF_0CDD / 0x1ABCD)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0xCE1);
    // AND AX,0xf0f0 (19EF_0CDE / 0x1ABCE)
    // AX &= 0xF0F0;
    AX = Alu16.And(AX, 0xF0F0);
    CheckExternalEvents(cs14, 0xCE2);
    // STOSW ES:DI (19EF_0CE1 / 0x1ABD1)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0xCE4);
    // LOOP 0x1000:abcd (19EF_0CE2 / 0x1ABD2)
    if(--CX != 0) {
      goto label_19EF_0CDD_1ABCD;
    }
    CheckExternalEvents(cs14, 0xCE5);
    // INC SI (19EF_0CE4 / 0x1ABD4)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0xCE8);
    // MOV CX,0x4 (19EF_0CE5 / 0x1ABD5)
    CX = 0x4;
    label_19EF_0CE8_1ABD8:
    CheckExternalEvents(cs14, 0xCE9);
    // LODSW SI (19EF_0CE8 / 0x1ABD8)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0xCEC);
    // AND AX,0xf0f0 (19EF_0CE9 / 0x1ABD9)
    // AX &= 0xF0F0;
    AX = Alu16.And(AX, 0xF0F0);
    CheckExternalEvents(cs14, 0xCED);
    // STOSW ES:DI (19EF_0CEC / 0x1ABDC)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0xCEF);
    // LOOP 0x1000:abd8 (19EF_0CED / 0x1ABDD)
    if(--CX != 0) {
      goto label_19EF_0CE8_1ABD8;
    }
    CheckExternalEvents(cs14, 0xCF0);
    // INC SI (19EF_0CEF / 0x1ABDF)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0xCF3);
    // MOV CX,0x4 (19EF_0CF0 / 0x1ABE0)
    CX = 0x4;
    label_19EF_0CF3_1ABE3:
    CheckExternalEvents(cs14, 0xCF4);
    // LODSW SI (19EF_0CF3 / 0x1ABE3)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0xCF7);
    // AND AX,0xf0f0 (19EF_0CF4 / 0x1ABE4)
    // AX &= 0xF0F0;
    AX = Alu16.And(AX, 0xF0F0);
    CheckExternalEvents(cs14, 0xCF8);
    // STOSW ES:DI (19EF_0CF7 / 0x1ABE7)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0xCFA);
    // LOOP 0x1000:abe3 (19EF_0CF8 / 0x1ABE8)
    if(--CX != 0) {
      goto label_19EF_0CF3_1ABE3;
    }
    CheckExternalEvents(cs14, 0xCFB);
    // INC SI (19EF_0CFA / 0x1ABEA)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0xCFE);
    // MOV CX,0x4 (19EF_0CFB / 0x1ABEB)
    CX = 0x4;
    label_19EF_0CFE_1ABEE:
    CheckExternalEvents(cs14, 0xCFF);
    // LODSW SI (19EF_0CFE / 0x1ABEE)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0xD02);
    // AND AX,0xf0f0 (19EF_0CFF / 0x1ABEF)
    // AX &= 0xF0F0;
    AX = Alu16.And(AX, 0xF0F0);
    CheckExternalEvents(cs14, 0xD03);
    // STOSW ES:DI (19EF_0D02 / 0x1ABF2)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0xD05);
    // LOOP 0x1000:abee (19EF_0D03 / 0x1ABF3)
    if(--CX != 0) {
      goto label_19EF_0CFE_1ABEE;
    }
    CheckExternalEvents(cs14, 0xD06);
    // POP ES (19EF_0D05 / 0x1ABF5)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xD07);
    // RET  (19EF_0D06 / 0x1ABF6)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_0D07_1ABF7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0D07_1ABF7:
    CheckExternalEvents(cs14, 0xD0B);
    // CMP SI,0x279 (19EF_0D07 / 0x1ABF7)
    Alu16.Sub(SI, 0x279);
    CheckExternalEvents(cs14, 0xD0D);
    // JZ 0x1000:ac68 (19EF_0D0B / 0x1ABFB)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      CheckExternalEvents(cs14, 0xD79);
      // RET  (19EF_0D78 / 0x1AC68)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0xD10);
    // SUB SI,0x2 (19EF_0D0D / 0x1ABFD)
    // SI -= 0x2;
    SI = Alu16.Sub(SI, 0x2);
    CheckExternalEvents(cs14, 0xD12);
    // MOV DH,byte ptr [SI] (19EF_0D10 / 0x1AC00)
    DH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xD15);
    // MOV DL,byte ptr [SI + 0x1] (19EF_0D12 / 0x1AC02)
    DL = UInt8[DS, (ushort)(SI + 0x1)];
    CheckExternalEvents(cs14, 0xD17);
    // MOV AL,DL (19EF_0D15 / 0x1AC05)
    AL = DL;
    CheckExternalEvents(cs14, 0xD19);
    // SUB AL,DH (19EF_0D17 / 0x1AC07)
    AL -= DH;
    CheckExternalEvents(cs14, 0xD1B);
    // CMP AL,0x1 (19EF_0D19 / 0x1AC09)
    Alu8.Sub(AL, 0x1);
    CheckExternalEvents(cs14, 0xD1D);
    // JZ 0x1000:abf7 (19EF_0D1B / 0x1AC0B)
    if(ZeroFlag) {
      goto label_19EF_0D07_1ABF7;
    }
    CheckExternalEvents(cs14, 0xD1F);
    // XOR BH,BH (19EF_0D1D / 0x1AC0D)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    CheckExternalEvents(cs14, 0xD21);
    // MOV BL,DH (19EF_0D1F / 0x1AC0F)
    BL = DH;
    CheckExternalEvents(cs14, 0xD23);
    // MOV CH,byte ptr [BX + DI] (19EF_0D21 / 0x1AC11)
    CH = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xD25);
    // MOV BL,DL (19EF_0D23 / 0x1AC13)
    BL = DL;
    CheckExternalEvents(cs14, 0xD27);
    // MOV CL,byte ptr [BX + DI] (19EF_0D25 / 0x1AC15)
    CL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xD29);
    // SHR AL,0x1 (19EF_0D27 / 0x1AC17)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0xD2B);
    // MOV BL,AL (19EF_0D29 / 0x1AC19)
    BL = AL;
    CheckExternalEvents(cs14, 0xD2D);
    // ADD BL,DH (19EF_0D2B / 0x1AC1B)
    // BL += DH;
    BL = Alu8.Add(BL, DH);
    CheckExternalEvents(cs14, 0xD2F);
    // MOV byte ptr [SI],DH (19EF_0D2D / 0x1AC1D)
    UInt8[DS, (ushort)(SI)] = DH;
    CheckExternalEvents(cs14, 0xD32);
    // MOV byte ptr [SI + 0x1],BL (19EF_0D2F / 0x1AC1F)
    UInt8[DS, (ushort)(SI + 0x1)] = BL;
    CheckExternalEvents(cs14, 0xD35);
    // MOV byte ptr [SI + 0x2],BL (19EF_0D32 / 0x1AC22)
    UInt8[DS, (ushort)(SI + 0x2)] = BL;
    CheckExternalEvents(cs14, 0xD38);
    // MOV byte ptr [SI + 0x3],DL (19EF_0D35 / 0x1AC25)
    UInt8[DS, (ushort)(SI + 0x3)] = DL;
    CheckExternalEvents(cs14, 0xD3B);
    // ADD SI,0x4 (19EF_0D38 / 0x1AC28)
    // SI += 0x4;
    SI = Alu16.Add(SI, 0x4);
    CheckExternalEvents(cs14, 0xD3D);
    // MOV AH,byte ptr [BX + DI] (19EF_0D3B / 0x1AC2B)
    AH = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xD40);
    // CMP AH,0xff (19EF_0D3D / 0x1AC2D)
    Alu8.Sub(AH, 0xFF);
    CheckExternalEvents(cs14, 0xD42);
    // JNZ 0x1000:abf7 (19EF_0D40 / 0x1AC30)
    if(!ZeroFlag) {
      goto label_19EF_0D07_1ABF7;
    }
    CheckExternalEvents(cs14, 0xD44);
    // MOV DL,CH (19EF_0D42 / 0x1AC32)
    DL = CH;
    CheckExternalEvents(cs14, 0xD46);
    // XOR DH,DH (19EF_0D44 / 0x1AC34)
    // DH ^= DH;
    DH = Alu8.Xor(DH, DH);
    CheckExternalEvents(cs14, 0xD48);
    // MOV CH,DH (19EF_0D46 / 0x1AC36)
    CH = DH;
    CheckExternalEvents(cs14, 0xD4A);
    // ADD DX,CX (19EF_0D48 / 0x1AC38)
    DX += CX;
    CheckExternalEvents(cs14, 0xD4C);
    // SHR DX,0x1 (19EF_0D4A / 0x1AC3A)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs14, 0xD4E);
    // MOV CX,SI (19EF_0D4C / 0x1AC3C)
    CX = SI;
    CheckExternalEvents(cs14, 0xD51);
    // MOV SI,0x9fb (19EF_0D4E / 0x1AC3E)
    SI = 0x9FB;
    CheckExternalEvents(cs14, 0xD55);
    // ADD SI,word ptr [0x9f9] (19EF_0D51 / 0x1AC41)
    // SI += UInt16[DS, 0x9F9];
    SI = Alu16.Add(SI, UInt16[DS, 0x9F9]);
    CheckExternalEvents(cs14, 0xD57);
    // MOV AH,byte ptr [SI] (19EF_0D55 / 0x1AC45)
    AH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xD59);
    // MOV SI,CX (19EF_0D57 / 0x1AC47)
    SI = CX;
    CheckExternalEvents(cs14, 0xD5B);
    // MOV CL,AL (19EF_0D59 / 0x1AC49)
    CL = AL;
    CheckExternalEvents(cs14, 0xD5D);
    // SHL CL,0x1 (19EF_0D5B / 0x1AC4B)
    // CL <<= 0x1;
    CL = Alu8.Shl(CL, 0x1);
    CheckExternalEvents(cs14, 0xD5F);
    // MOV CH,CL (19EF_0D5D / 0x1AC4D)
    CH = CL;
    CheckExternalEvents(cs14, 0xD61);
    // SHL CL,0x1 (19EF_0D5F / 0x1AC4F)
    CL <<= 0x1;
    CheckExternalEvents(cs14, 0xD63);
    // DEC CL (19EF_0D61 / 0x1AC51)
    CL--;
    CheckExternalEvents(cs14, 0xD65);
    // AND CL,AH (19EF_0D63 / 0x1AC53)
    CL &= AH;
    CheckExternalEvents(cs14, 0xD67);
    // SUB CL,CH (19EF_0D65 / 0x1AC55)
    CL -= CH;
    CheckExternalEvents(cs14, 0xD69);
    // ADD DL,CL (19EF_0D67 / 0x1AC57)
    DL += CL;
    CheckExternalEvents(cs14, 0xD6C);
    // CMP DL,0x80 (19EF_0D69 / 0x1AC59)
    Alu8.Sub(DL, 0x80);
    CheckExternalEvents(cs14, 0xD6E);
    // JC 0x1000:ac60 (19EF_0D6C / 0x1AC5C)
    if(CarryFlag) {
      goto label_19EF_0D70_1AC60;
    }
    CheckExternalEvents(cs14, 0xD70);
    // XOR DL,DL (19EF_0D6E / 0x1AC5E)
    // DL ^= DL;
    DL = Alu8.Xor(DL, DL);
    label_19EF_0D70_1AC60:
    CheckExternalEvents(cs14, 0xD72);
    // MOV byte ptr [BX + DI],DL (19EF_0D70 / 0x1AC60)
    UInt8[DS, (ushort)(BX + DI)] = DL;
    CheckExternalEvents(cs14, 0xD76);
    // INC byte ptr [0x9f9] (19EF_0D72 / 0x1AC62)
    UInt8[DS, 0x9F9] = Alu8.Inc(UInt8[DS, 0x9F9]);
    CheckExternalEvents(cs14, 0xD78);
    // JMP 0x1000:abf7 (19EF_0D76 / 0x1AC66)
    goto label_19EF_0D07_1ABF7;
    label_19EF_0D78_1AC68:
    CheckExternalEvents(cs14, 0xD79);
    // RET  (19EF_0D78 / 0x1AC68)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_0D79_1AC69(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0D79_1AC69:
    CheckExternalEvents(cs14, 0xD7D);
    // CMP SI,0x279 (19EF_0D79 / 0x1AC69)
    Alu16.Sub(SI, 0x279);
    CheckExternalEvents(cs14, 0xD7F);
    // JZ 0x1000:ace7 (19EF_0D7D / 0x1AC6D)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      CheckExternalEvents(cs14, 0xDF8);
      // RET  (19EF_0DF7 / 0x1ACE7)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0xD82);
    // SUB SI,0x2 (19EF_0D7F / 0x1AC6F)
    // SI -= 0x2;
    SI = Alu16.Sub(SI, 0x2);
    CheckExternalEvents(cs14, 0xD84);
    // MOV DH,byte ptr [SI] (19EF_0D82 / 0x1AC72)
    DH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xD87);
    // MOV DL,byte ptr [SI + 0x1] (19EF_0D84 / 0x1AC74)
    DL = UInt8[DS, (ushort)(SI + 0x1)];
    CheckExternalEvents(cs14, 0xD89);
    // MOV AL,DL (19EF_0D87 / 0x1AC77)
    AL = DL;
    CheckExternalEvents(cs14, 0xD8B);
    // SUB AL,DH (19EF_0D89 / 0x1AC79)
    AL -= DH;
    CheckExternalEvents(cs14, 0xD8D);
    // CMP AL,0x9 (19EF_0D8B / 0x1AC7B)
    Alu8.Sub(AL, 0x9);
    CheckExternalEvents(cs14, 0xD8F);
    // JZ 0x1000:ac69 (19EF_0D8D / 0x1AC7D)
    if(ZeroFlag) {
      goto label_19EF_0D79_1AC69;
    }
    CheckExternalEvents(cs14, 0xD91);
    // XOR BH,BH (19EF_0D8F / 0x1AC7F)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    CheckExternalEvents(cs14, 0xD93);
    // MOV BL,DH (19EF_0D91 / 0x1AC81)
    BL = DH;
    CheckExternalEvents(cs14, 0xD95);
    // MOV CH,byte ptr [BX + DI] (19EF_0D93 / 0x1AC83)
    CH = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xD97);
    // MOV BL,DL (19EF_0D95 / 0x1AC85)
    BL = DL;
    CheckExternalEvents(cs14, 0xD99);
    // MOV CL,byte ptr [BX + DI] (19EF_0D97 / 0x1AC87)
    CL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xD9B);
    // SHR AL,0x1 (19EF_0D99 / 0x1AC89)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0xD9D);
    // MOV BL,AL (19EF_0D9B / 0x1AC8B)
    BL = AL;
    CheckExternalEvents(cs14, 0xD9F);
    // ADD BL,DH (19EF_0D9D / 0x1AC8D)
    // BL += DH;
    BL = Alu8.Add(BL, DH);
    CheckExternalEvents(cs14, 0xDA1);
    // MOV byte ptr [SI],DH (19EF_0D9F / 0x1AC8F)
    UInt8[DS, (ushort)(SI)] = DH;
    CheckExternalEvents(cs14, 0xDA4);
    // MOV byte ptr [SI + 0x1],BL (19EF_0DA1 / 0x1AC91)
    UInt8[DS, (ushort)(SI + 0x1)] = BL;
    CheckExternalEvents(cs14, 0xDA7);
    // MOV byte ptr [SI + 0x2],BL (19EF_0DA4 / 0x1AC94)
    UInt8[DS, (ushort)(SI + 0x2)] = BL;
    CheckExternalEvents(cs14, 0xDAA);
    // MOV byte ptr [SI + 0x3],DL (19EF_0DA7 / 0x1AC97)
    UInt8[DS, (ushort)(SI + 0x3)] = DL;
    CheckExternalEvents(cs14, 0xDAD);
    // ADD SI,0x4 (19EF_0DAA / 0x1AC9A)
    // SI += 0x4;
    SI = Alu16.Add(SI, 0x4);
    CheckExternalEvents(cs14, 0xDAF);
    // MOV AH,byte ptr [BX + DI] (19EF_0DAD / 0x1AC9D)
    AH = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xDB2);
    // CMP AH,0xff (19EF_0DAF / 0x1AC9F)
    Alu8.Sub(AH, 0xFF);
    CheckExternalEvents(cs14, 0xDB4);
    // JNZ 0x1000:ac69 (19EF_0DB2 / 0x1ACA2)
    if(!ZeroFlag) {
      goto label_19EF_0D79_1AC69;
    }
    CheckExternalEvents(cs14, 0xDB6);
    // MOV DL,CH (19EF_0DB4 / 0x1ACA4)
    DL = CH;
    CheckExternalEvents(cs14, 0xDB8);
    // XOR DH,DH (19EF_0DB6 / 0x1ACA6)
    // DH ^= DH;
    DH = Alu8.Xor(DH, DH);
    CheckExternalEvents(cs14, 0xDBA);
    // MOV CH,DH (19EF_0DB8 / 0x1ACA8)
    CH = DH;
    CheckExternalEvents(cs14, 0xDBC);
    // ADD DX,CX (19EF_0DBA / 0x1ACAA)
    DX += CX;
    CheckExternalEvents(cs14, 0xDBE);
    // SHR DX,0x1 (19EF_0DBC / 0x1ACAC)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs14, 0xDC0);
    // MOV CX,SI (19EF_0DBE / 0x1ACAE)
    CX = SI;
    CheckExternalEvents(cs14, 0xDC3);
    // MOV SI,0x9fb (19EF_0DC0 / 0x1ACB0)
    SI = 0x9FB;
    CheckExternalEvents(cs14, 0xDC7);
    // ADD SI,word ptr [0x9f9] (19EF_0DC3 / 0x1ACB3)
    // SI += UInt16[DS, 0x9F9];
    SI = Alu16.Add(SI, UInt16[DS, 0x9F9]);
    CheckExternalEvents(cs14, 0xDC9);
    // MOV AH,byte ptr [SI] (19EF_0DC7 / 0x1ACB7)
    AH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xDCB);
    // MOV SI,CX (19EF_0DC9 / 0x1ACB9)
    SI = CX;
    CheckExternalEvents(cs14, 0xDCD);
    // MOV DH,AL (19EF_0DCB / 0x1ACBB)
    DH = AL;
    CheckExternalEvents(cs14, 0xDCF);
    // SHR DH,0x1 (19EF_0DCD / 0x1ACBD)
    DH >>= 0x1;
    CheckExternalEvents(cs14, 0xDD1);
    // SHR DH,0x1 (19EF_0DCF / 0x1ACBF)
    DH >>= 0x1;
    CheckExternalEvents(cs14, 0xDD3);
    // SHR DH,0x1 (19EF_0DD1 / 0x1ACC1)
    DH >>= 0x1;
    CheckExternalEvents(cs14, 0xDD6);
    // CMP DH,0x9 (19EF_0DD3 / 0x1ACC3)
    Alu8.Sub(DH, 0x9);
    CheckExternalEvents(cs14, 0xDD8);
    // JNZ 0x1000:acca (19EF_0DD6 / 0x1ACC6)
    if(!ZeroFlag) {
      goto label_19EF_0DDA_1ACCA;
    }
    CheckExternalEvents(cs14, 0xDDA);
    // DEC DH (19EF_0DD8 / 0x1ACC8)
    DH--;
    label_19EF_0DDA_1ACCA:
    CheckExternalEvents(cs14, 0xDDC);
    // SHL DH,0x1 (19EF_0DDA / 0x1ACCA)
    // DH <<= 0x1;
    DH = Alu8.Shl(DH, 0x1);
    CheckExternalEvents(cs14, 0xDDE);
    // MOV CH,DH (19EF_0DDC / 0x1ACCC)
    CH = DH;
    CheckExternalEvents(cs14, 0xDE0);
    // SHL DH,0x1 (19EF_0DDE / 0x1ACCE)
    DH <<= 0x1;
    CheckExternalEvents(cs14, 0xDE2);
    // DEC DH (19EF_0DE0 / 0x1ACD0)
    DH--;
    CheckExternalEvents(cs14, 0xDE4);
    // AND DH,AH (19EF_0DE2 / 0x1ACD2)
    DH &= AH;
    CheckExternalEvents(cs14, 0xDE6);
    // SUB DH,CH (19EF_0DE4 / 0x1ACD4)
    DH -= CH;
    CheckExternalEvents(cs14, 0xDE8);
    // ADD DL,DH (19EF_0DE6 / 0x1ACD6)
    DL += DH;
    CheckExternalEvents(cs14, 0xDEB);
    // CMP DL,0x80 (19EF_0DE8 / 0x1ACD8)
    Alu8.Sub(DL, 0x80);
    CheckExternalEvents(cs14, 0xDED);
    // JC 0x1000:acdf (19EF_0DEB / 0x1ACDB)
    if(CarryFlag) {
      goto label_19EF_0DEF_1ACDF;
    }
    CheckExternalEvents(cs14, 0xDEF);
    // XOR DL,DL (19EF_0DED / 0x1ACDD)
    // DL ^= DL;
    DL = Alu8.Xor(DL, DL);
    label_19EF_0DEF_1ACDF:
    CheckExternalEvents(cs14, 0xDF1);
    // MOV byte ptr [BX + DI],DL (19EF_0DEF / 0x1ACDF)
    UInt8[DS, (ushort)(BX + DI)] = DL;
    CheckExternalEvents(cs14, 0xDF5);
    // INC byte ptr [0x9f9] (19EF_0DF1 / 0x1ACE1)
    UInt8[DS, 0x9F9] = Alu8.Inc(UInt8[DS, 0x9F9]);
    CheckExternalEvents(cs14, 0xDF7);
    // JMP 0x1000:ac69 (19EF_0DF5 / 0x1ACE5)
    goto label_19EF_0D79_1AC69;
    label_19EF_0DF7_1ACE7:
    CheckExternalEvents(cs14, 0xDF8);
    // RET  (19EF_0DF7 / 0x1ACE7)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_0DF8_1ACE8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0DF8_1ACE8:
    CheckExternalEvents(cs14, 0xDFC);
    // CMP SI,0x279 (19EF_0DF8 / 0x1ACE8)
    Alu16.Sub(SI, 0x279);
    CheckExternalEvents(cs14, 0xDFE);
    // JNZ 0x1000:acf1 (19EF_0DFC / 0x1ACEC)
    if(!ZeroFlag) {
      goto label_19EF_0E01_1ACF1;
    }
    CheckExternalEvents(cs14, 0xE01);
    // JMP 0x1000:aedd (19EF_0DFE / 0x1ACEE)
    // JMP target is RET, inlining.
    CheckExternalEvents(cs14, 0xFEE);
    // RET  (19EF_0FED / 0x1AEDD)
    return NearRet();
    label_19EF_0E01_1ACF1:
    CheckExternalEvents(cs14, 0xE04);
    // SUB SI,0x4 (19EF_0E01 / 0x1ACF1)
    // SI -= 0x4;
    SI = Alu16.Sub(SI, 0x4);
    CheckExternalEvents(cs14, 0xE06);
    // MOV DH,byte ptr [SI] (19EF_0E04 / 0x1ACF4)
    DH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xE09);
    // MOV DL,byte ptr [SI + 0x1] (19EF_0E06 / 0x1ACF6)
    DL = UInt8[DS, (ushort)(SI + 0x1)];
    CheckExternalEvents(cs14, 0xE0B);
    // SUB DL,DH (19EF_0E09 / 0x1ACF9)
    DL -= DH;
    CheckExternalEvents(cs14, 0xE0E);
    // CMP DL,0x1 (19EF_0E0B / 0x1ACFB)
    Alu8.Sub(DL, 0x1);
    CheckExternalEvents(cs14, 0xE10);
    // JZ 0x1000:ace8 (19EF_0E0E / 0x1ACFE)
    if(ZeroFlag) {
      goto label_19EF_0DF8_1ACE8;
    }
    CheckExternalEvents(cs14, 0xE13);
    // MOV DL,byte ptr [SI + 0x3] (19EF_0E10 / 0x1AD00)
    DL = UInt8[DS, (ushort)(SI + 0x3)];
    CheckExternalEvents(cs14, 0xE15);
    // XOR BH,BH (19EF_0E13 / 0x1AD03)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    CheckExternalEvents(cs14, 0xE17);
    // MOV AH,BH (19EF_0E15 / 0x1AD05)
    AH = BH;
    CheckExternalEvents(cs14, 0xE19);
    // MOV BL,DH (19EF_0E17 / 0x1AD07)
    BL = DH;
    CheckExternalEvents(cs14, 0xE1B);
    // MOV AL,byte ptr [BX + DI] (19EF_0E19 / 0x1AD09)
    AL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xE1D);
    // MOV BL,DL (19EF_0E1B / 0x1AD0B)
    BL = DL;
    CheckExternalEvents(cs14, 0xE1F);
    // MOV BL,byte ptr [BX + DI] (19EF_0E1D / 0x1AD0D)
    BL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xE21);
    // ADD AX,BX (19EF_0E1F / 0x1AD0F)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs14, 0xE24);
    // MOV BL,byte ptr [SI + 0x1] (19EF_0E21 / 0x1AD11)
    BL = UInt8[DS, (ushort)(SI + 0x1)];
    CheckExternalEvents(cs14, 0xE26);
    // MOV BL,byte ptr [BX + DI] (19EF_0E24 / 0x1AD14)
    BL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xE28);
    // ADD AX,BX (19EF_0E26 / 0x1AD16)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs14, 0xE2B);
    // MOV BL,byte ptr [SI + 0x2] (19EF_0E28 / 0x1AD18)
    BL = UInt8[DS, (ushort)(SI + 0x2)];
    CheckExternalEvents(cs14, 0xE2D);
    // MOV BL,byte ptr [BX + DI] (19EF_0E2B / 0x1AD1B)
    BL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xE2F);
    // ADD AX,BX (19EF_0E2D / 0x1AD1D)
    AX += BX;
    CheckExternalEvents(cs14, 0xE31);
    // SHR AX,0x1 (19EF_0E2F / 0x1AD1F)
    AX >>= 0x1;
    CheckExternalEvents(cs14, 0xE33);
    // SHR AX,0x1 (19EF_0E31 / 0x1AD21)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs14, 0xE35);
    // MOV CL,DL (19EF_0E33 / 0x1AD23)
    CL = DL;
    CheckExternalEvents(cs14, 0xE37);
    // SUB CL,DH (19EF_0E35 / 0x1AD25)
    CL -= DH;
    CheckExternalEvents(cs14, 0xE39);
    // SHR CL,0x1 (19EF_0E37 / 0x1AD27)
    // CL >>= 0x1;
    CL = Alu8.Shr(CL, 0x1);
    CheckExternalEvents(cs14, 0xE3B);
    // MOV BL,CL (19EF_0E39 / 0x1AD29)
    BL = CL;
    CheckExternalEvents(cs14, 0xE3D);
    // ADD BL,DH (19EF_0E3B / 0x1AD2B)
    // BL += DH;
    BL = Alu8.Add(BL, DH);
    CheckExternalEvents(cs14, 0xE3F);
    // MOV AH,byte ptr [BX + DI] (19EF_0E3D / 0x1AD2D)
    AH = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xE42);
    // CMP AH,0xff (19EF_0E3F / 0x1AD2F)
    Alu8.Sub(AH, 0xFF);
    CheckExternalEvents(cs14, 0xE44);
    // JNZ 0x1000:ad36 (19EF_0E42 / 0x1AD32)
    if(!ZeroFlag) {
      goto label_19EF_0E46_1AD36;
    }
    CheckExternalEvents(cs14, 0xE46);
    // MOV byte ptr [BX + DI],AL (19EF_0E44 / 0x1AD34)
    UInt8[DS, (ushort)(BX + DI)] = AL;
    label_19EF_0E46_1AD36:
    CheckExternalEvents(cs14, 0xE4A);
    // MOV byte ptr [0x272],DH (19EF_0E46 / 0x1AD36)
    UInt8[DS, 0x272] = DH;
    CheckExternalEvents(cs14, 0xE4E);
    // MOV byte ptr [0x275],DL (19EF_0E4A / 0x1AD3A)
    UInt8[DS, 0x275] = DL;
    CheckExternalEvents(cs14, 0xE52);
    // MOV byte ptr [0x276],BL (19EF_0E4E / 0x1AD3E)
    UInt8[DS, 0x276] = BL;
    CheckExternalEvents(cs14, 0xE55);
    // MOV AL,byte ptr [SI + 0x1] (19EF_0E52 / 0x1AD42)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    CheckExternalEvents(cs14, 0xE58);
    // MOV [0x273],AL (19EF_0E55 / 0x1AD45)
    UInt8[DS, 0x273] = AL;
    CheckExternalEvents(cs14, 0xE5B);
    // MOV AL,byte ptr [SI + 0x2] (19EF_0E58 / 0x1AD48)
    AL = UInt8[DS, (ushort)(SI + 0x2)];
    CheckExternalEvents(cs14, 0xE5E);
    // MOV [0x274],AL (19EF_0E5B / 0x1AD4B)
    UInt8[DS, 0x274] = AL;
    CheckExternalEvents(cs14, 0xE60);
    // MOV byte ptr [SI],DH (19EF_0E5E / 0x1AD4E)
    UInt8[DS, (ushort)(SI)] = DH;
    CheckExternalEvents(cs14, 0xE63);
    // MOV byte ptr [SI + 0x3],BL (19EF_0E60 / 0x1AD50)
    UInt8[DS, (ushort)(SI + 0x3)] = BL;
    CheckExternalEvents(cs14, 0xE66);
    // MOV byte ptr [SI + 0x6],BL (19EF_0E63 / 0x1AD53)
    UInt8[DS, (ushort)(SI + 0x6)] = BL;
    CheckExternalEvents(cs14, 0xE69);
    // MOV byte ptr [SI + 0x9],BL (19EF_0E66 / 0x1AD56)
    UInt8[DS, (ushort)(SI + 0x9)] = BL;
    CheckExternalEvents(cs14, 0xE6C);
    // MOV byte ptr [SI + 0xc],BL (19EF_0E69 / 0x1AD59)
    UInt8[DS, (ushort)(SI + 0xC)] = BL;
    CheckExternalEvents(cs14, 0xE6F);
    // MOV AL,[0x273] (19EF_0E6C / 0x1AD5C)
    AL = UInt8[DS, 0x273];
    CheckExternalEvents(cs14, 0xE71);
    // SUB AL,DH (19EF_0E6F / 0x1AD5F)
    AL -= DH;
    CheckExternalEvents(cs14, 0xE73);
    // SHR AL,0x1 (19EF_0E71 / 0x1AD61)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0xE76);
    // MOV [0x277],AL (19EF_0E73 / 0x1AD63)
    UInt8[DS, 0x277] = AL;
    CheckExternalEvents(cs14, 0xE7A);
    // MOV BL,byte ptr [0x272] (19EF_0E76 / 0x1AD66)
    BL = UInt8[DS, 0x272];
    CheckExternalEvents(cs14, 0xE7C);
    // XOR DH,DH (19EF_0E7A / 0x1AD6A)
    // DH ^= DH;
    DH = Alu8.Xor(DH, DH);
    CheckExternalEvents(cs14, 0xE7E);
    // MOV DL,byte ptr [BX + DI] (19EF_0E7C / 0x1AD6C)
    DL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xE82);
    // MOV BL,byte ptr [0x273] (19EF_0E7E / 0x1AD6E)
    BL = UInt8[DS, 0x273];
    CheckExternalEvents(cs14, 0xE85);
    // MOV byte ptr [SI + 0x5],BL (19EF_0E82 / 0x1AD72)
    UInt8[DS, (ushort)(SI + 0x5)] = BL;
    CheckExternalEvents(cs14, 0xE87);
    // MOV BL,byte ptr [BX + DI] (19EF_0E85 / 0x1AD75)
    BL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xE89);
    // ADD DX,BX (19EF_0E87 / 0x1AD77)
    DX += BX;
    CheckExternalEvents(cs14, 0xE8B);
    // SHR DX,0x1 (19EF_0E89 / 0x1AD79)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs14, 0xE8D);
    // MOV BL,AL (19EF_0E8B / 0x1AD7B)
    BL = AL;
    CheckExternalEvents(cs14, 0xE91);
    // ADD BL,byte ptr [0x272] (19EF_0E8D / 0x1AD7D)
    // BL += UInt8[DS, 0x272];
    BL = Alu8.Add(BL, UInt8[DS, 0x272]);
    CheckExternalEvents(cs14, 0xE94);
    // MOV byte ptr [SI + 0x1],BL (19EF_0E91 / 0x1AD81)
    UInt8[DS, (ushort)(SI + 0x1)] = BL;
    CheckExternalEvents(cs14, 0xE97);
    // MOV byte ptr [SI + 0x4],BL (19EF_0E94 / 0x1AD84)
    UInt8[DS, (ushort)(SI + 0x4)] = BL;
    CheckExternalEvents(cs14, 0xE99);
    // MOV AH,byte ptr [BX + DI] (19EF_0E97 / 0x1AD87)
    AH = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xE9C);
    // CMP AH,0xff (19EF_0E99 / 0x1AD89)
    Alu8.Sub(AH, 0xFF);
    CheckExternalEvents(cs14, 0xE9E);
    // JNZ 0x1000:adb8 (19EF_0E9C / 0x1AD8C)
    if(!ZeroFlag) {
      goto label_19EF_0EC8_1ADB8;
    }
    CheckExternalEvents(cs14, 0xEA0);
    // MOV CX,SI (19EF_0E9E / 0x1AD8E)
    CX = SI;
    CheckExternalEvents(cs14, 0xEA3);
    // MOV SI,0x9fb (19EF_0EA0 / 0x1AD90)
    SI = 0x9FB;
    CheckExternalEvents(cs14, 0xEA7);
    // ADD SI,word ptr [0x9f9] (19EF_0EA3 / 0x1AD93)
    SI += UInt16[DS, 0x9F9];
    CheckExternalEvents(cs14, 0xEAB);
    // INC byte ptr [0x9f9] (19EF_0EA7 / 0x1AD97)
    UInt8[DS, 0x9F9] = Alu8.Inc(UInt8[DS, 0x9F9]);
    CheckExternalEvents(cs14, 0xEAD);
    // MOV AH,byte ptr [SI] (19EF_0EAB / 0x1AD9B)
    AH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xEAF);
    // MOV SI,CX (19EF_0EAD / 0x1AD9D)
    SI = CX;
    CheckExternalEvents(cs14, 0xEB1);
    // MOV CL,AL (19EF_0EAF / 0x1AD9F)
    CL = AL;
    CheckExternalEvents(cs14, 0xEB3);
    // SHL CL,0x1 (19EF_0EB1 / 0x1ADA1)
    // CL <<= 0x1;
    CL = Alu8.Shl(CL, 0x1);
    CheckExternalEvents(cs14, 0xEB5);
    // MOV CH,CL (19EF_0EB3 / 0x1ADA3)
    CH = CL;
    CheckExternalEvents(cs14, 0xEB7);
    // SHL CL,0x1 (19EF_0EB5 / 0x1ADA5)
    CL <<= 0x1;
    CheckExternalEvents(cs14, 0xEB9);
    // DEC CL (19EF_0EB7 / 0x1ADA7)
    CL--;
    CheckExternalEvents(cs14, 0xEBB);
    // AND CL,AH (19EF_0EB9 / 0x1ADA9)
    CL &= AH;
    CheckExternalEvents(cs14, 0xEBD);
    // SUB CL,CH (19EF_0EBB / 0x1ADAB)
    CL -= CH;
    CheckExternalEvents(cs14, 0xEBF);
    // ADD DL,CL (19EF_0EBD / 0x1ADAD)
    DL += CL;
    CheckExternalEvents(cs14, 0xEC2);
    // CMP DL,0x80 (19EF_0EBF / 0x1ADAF)
    Alu8.Sub(DL, 0x80);
    CheckExternalEvents(cs14, 0xEC4);
    // JC 0x1000:adb6 (19EF_0EC2 / 0x1ADB2)
    if(CarryFlag) {
      goto label_19EF_0EC6_1ADB6;
    }
    CheckExternalEvents(cs14, 0xEC6);
    // XOR DL,DL (19EF_0EC4 / 0x1ADB4)
    // DL ^= DL;
    DL = Alu8.Xor(DL, DL);
    label_19EF_0EC6_1ADB6:
    CheckExternalEvents(cs14, 0xEC8);
    // MOV byte ptr [BX + DI],DL (19EF_0EC6 / 0x1ADB6)
    UInt8[DS, (ushort)(BX + DI)] = DL;
    label_19EF_0EC8_1ADB8:
    CheckExternalEvents(cs14, 0xECC);
    // MOV CL,byte ptr [0x274] (19EF_0EC8 / 0x1ADB8)
    CL = UInt8[DS, 0x274];
    CheckExternalEvents(cs14, 0xED0);
    // SUB CL,byte ptr [0x272] (19EF_0ECC / 0x1ADBC)
    CL -= UInt8[DS, 0x272];
    CheckExternalEvents(cs14, 0xED2);
    // SHR CL,0x1 (19EF_0ED0 / 0x1ADC0)
    // CL >>= 0x1;
    CL = Alu8.Shr(CL, 0x1);
    CheckExternalEvents(cs14, 0xED6);
    // MOV byte ptr [0x278],CL (19EF_0ED2 / 0x1ADC2)
    UInt8[DS, 0x278] = CL;
    CheckExternalEvents(cs14, 0xEDA);
    // MOV BL,byte ptr [0x272] (19EF_0ED6 / 0x1ADC6)
    BL = UInt8[DS, 0x272];
    CheckExternalEvents(cs14, 0xEDC);
    // MOV DL,byte ptr [BX + DI] (19EF_0EDA / 0x1ADCA)
    DL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xEDE);
    // XOR DH,DH (19EF_0EDC / 0x1ADCC)
    // DH ^= DH;
    DH = Alu8.Xor(DH, DH);
    CheckExternalEvents(cs14, 0xEE2);
    // MOV BL,byte ptr [0x274] (19EF_0EDE / 0x1ADCE)
    BL = UInt8[DS, 0x274];
    CheckExternalEvents(cs14, 0xEE4);
    // MOV BL,byte ptr [BX + DI] (19EF_0EE2 / 0x1ADD2)
    BL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xEE6);
    // ADD DX,BX (19EF_0EE4 / 0x1ADD4)
    DX += BX;
    CheckExternalEvents(cs14, 0xEE8);
    // SHR DX,0x1 (19EF_0EE6 / 0x1ADD6)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs14, 0xEEA);
    // MOV BL,CL (19EF_0EE8 / 0x1ADD8)
    BL = CL;
    CheckExternalEvents(cs14, 0xEEE);
    // ADD BL,byte ptr [0x272] (19EF_0EEA / 0x1ADDA)
    // BL += UInt8[DS, 0x272];
    BL = Alu8.Add(BL, UInt8[DS, 0x272]);
    CheckExternalEvents(cs14, 0xEF1);
    // MOV byte ptr [SI + 0x2],BL (19EF_0EEE / 0x1ADDE)
    UInt8[DS, (ushort)(SI + 0x2)] = BL;
    CheckExternalEvents(cs14, 0xEF4);
    // MOV byte ptr [SI + 0x8],BL (19EF_0EF1 / 0x1ADE1)
    UInt8[DS, (ushort)(SI + 0x8)] = BL;
    CheckExternalEvents(cs14, 0xEF6);
    // MOV AH,byte ptr [BX + DI] (19EF_0EF4 / 0x1ADE4)
    AH = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xEF9);
    // CMP AH,0xff (19EF_0EF6 / 0x1ADE6)
    Alu8.Sub(AH, 0xFF);
    CheckExternalEvents(cs14, 0xEFB);
    // JNZ 0x1000:ae24 (19EF_0EF9 / 0x1ADE9)
    if(!ZeroFlag) {
      goto label_19EF_0F34_1AE24;
    }
    CheckExternalEvents(cs14, 0xEFD);
    // MOV CX,SI (19EF_0EFB / 0x1ADEB)
    CX = SI;
    CheckExternalEvents(cs14, 0xF00);
    // MOV SI,0x9fb (19EF_0EFD / 0x1ADED)
    SI = 0x9FB;
    CheckExternalEvents(cs14, 0xF04);
    // ADD SI,word ptr [0x9f9] (19EF_0F00 / 0x1ADF0)
    SI += UInt16[DS, 0x9F9];
    CheckExternalEvents(cs14, 0xF08);
    // INC byte ptr [0x9f9] (19EF_0F04 / 0x1ADF4)
    UInt8[DS, 0x9F9] = Alu8.Inc(UInt8[DS, 0x9F9]);
    CheckExternalEvents(cs14, 0xF0A);
    // MOV AH,byte ptr [SI] (19EF_0F08 / 0x1ADF8)
    AH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xF0C);
    // MOV SI,CX (19EF_0F0A / 0x1ADFA)
    SI = CX;
    CheckExternalEvents(cs14, 0xF10);
    // MOV DH,byte ptr [0x278] (19EF_0F0C / 0x1ADFC)
    DH = UInt8[DS, 0x278];
    CheckExternalEvents(cs14, 0xF12);
    // SHR DH,0x1 (19EF_0F10 / 0x1AE00)
    DH >>= 0x1;
    CheckExternalEvents(cs14, 0xF14);
    // SHR DH,0x1 (19EF_0F12 / 0x1AE02)
    DH >>= 0x1;
    CheckExternalEvents(cs14, 0xF16);
    // SHR DH,0x1 (19EF_0F14 / 0x1AE04)
    DH >>= 0x1;
    CheckExternalEvents(cs14, 0xF19);
    // CMP DH,0x9 (19EF_0F16 / 0x1AE06)
    Alu8.Sub(DH, 0x9);
    CheckExternalEvents(cs14, 0xF1B);
    // JNZ 0x1000:ae0d (19EF_0F19 / 0x1AE09)
    if(!ZeroFlag) {
      goto label_19EF_0F1D_1AE0D;
    }
    CheckExternalEvents(cs14, 0xF1D);
    // DEC DH (19EF_0F1B / 0x1AE0B)
    DH--;
    label_19EF_0F1D_1AE0D:
    CheckExternalEvents(cs14, 0xF1F);
    // SHL DH,0x1 (19EF_0F1D / 0x1AE0D)
    // DH <<= 0x1;
    DH = Alu8.Shl(DH, 0x1);
    CheckExternalEvents(cs14, 0xF21);
    // MOV CH,DH (19EF_0F1F / 0x1AE0F)
    CH = DH;
    CheckExternalEvents(cs14, 0xF23);
    // SHL DH,0x1 (19EF_0F21 / 0x1AE11)
    DH <<= 0x1;
    CheckExternalEvents(cs14, 0xF25);
    // DEC DH (19EF_0F23 / 0x1AE13)
    DH--;
    CheckExternalEvents(cs14, 0xF27);
    // AND DH,AH (19EF_0F25 / 0x1AE15)
    DH &= AH;
    CheckExternalEvents(cs14, 0xF29);
    // SUB DH,CH (19EF_0F27 / 0x1AE17)
    DH -= CH;
    CheckExternalEvents(cs14, 0xF2B);
    // ADD DL,DH (19EF_0F29 / 0x1AE19)
    DL += DH;
    CheckExternalEvents(cs14, 0xF2E);
    // CMP DL,0x80 (19EF_0F2B / 0x1AE1B)
    Alu8.Sub(DL, 0x80);
    CheckExternalEvents(cs14, 0xF30);
    // JC 0x1000:ae22 (19EF_0F2E / 0x1AE1E)
    if(CarryFlag) {
      goto label_19EF_0F32_1AE22;
    }
    CheckExternalEvents(cs14, 0xF32);
    // XOR DL,DL (19EF_0F30 / 0x1AE20)
    // DL ^= DL;
    DL = Alu8.Xor(DL, DL);
    label_19EF_0F32_1AE22:
    CheckExternalEvents(cs14, 0xF34);
    // MOV byte ptr [BX + DI],DL (19EF_0F32 / 0x1AE22)
    UInt8[DS, (ushort)(BX + DI)] = DL;
    label_19EF_0F34_1AE24:
    CheckExternalEvents(cs14, 0xF38);
    // MOV BL,byte ptr [0x274] (19EF_0F34 / 0x1AE24)
    BL = UInt8[DS, 0x274];
    CheckExternalEvents(cs14, 0xF3B);
    // MOV byte ptr [SI + 0xa],BL (19EF_0F38 / 0x1AE28)
    UInt8[DS, (ushort)(SI + 0xA)] = BL;
    CheckExternalEvents(cs14, 0xF3D);
    // MOV DL,byte ptr [BX + DI] (19EF_0F3B / 0x1AE2B)
    DL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xF41);
    // MOV BL,byte ptr [0x275] (19EF_0F3D / 0x1AE2D)
    BL = UInt8[DS, 0x275];
    CheckExternalEvents(cs14, 0xF44);
    // MOV byte ptr [SI + 0xf],BL (19EF_0F41 / 0x1AE31)
    UInt8[DS, (ushort)(SI + 0xF)] = BL;
    CheckExternalEvents(cs14, 0xF46);
    // MOV BL,byte ptr [BX + DI] (19EF_0F44 / 0x1AE34)
    BL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xF48);
    // ADD DX,BX (19EF_0F46 / 0x1AE36)
    DX += BX;
    CheckExternalEvents(cs14, 0xF4A);
    // SHR DX,0x1 (19EF_0F48 / 0x1AE38)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs14, 0xF4E);
    // MOV BL,byte ptr [0x277] (19EF_0F4A / 0x1AE3A)
    BL = UInt8[DS, 0x277];
    CheckExternalEvents(cs14, 0xF52);
    // ADD BL,byte ptr [0x274] (19EF_0F4E / 0x1AE3E)
    // BL += UInt8[DS, 0x274];
    BL = Alu8.Add(BL, UInt8[DS, 0x274]);
    CheckExternalEvents(cs14, 0xF55);
    // MOV byte ptr [SI + 0xb],BL (19EF_0F52 / 0x1AE42)
    UInt8[DS, (ushort)(SI + 0xB)] = BL;
    CheckExternalEvents(cs14, 0xF58);
    // MOV byte ptr [SI + 0xe],BL (19EF_0F55 / 0x1AE45)
    UInt8[DS, (ushort)(SI + 0xE)] = BL;
    CheckExternalEvents(cs14, 0xF5A);
    // MOV AH,byte ptr [BX + DI] (19EF_0F58 / 0x1AE48)
    AH = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xF5D);
    // CMP AH,0xff (19EF_0F5A / 0x1AE4A)
    Alu8.Sub(AH, 0xFF);
    CheckExternalEvents(cs14, 0xF5F);
    // JNZ 0x1000:ae7b (19EF_0F5D / 0x1AE4D)
    if(!ZeroFlag) {
      goto label_19EF_0F8B_1AE7B;
    }
    CheckExternalEvents(cs14, 0xF61);
    // MOV CX,SI (19EF_0F5F / 0x1AE4F)
    CX = SI;
    CheckExternalEvents(cs14, 0xF64);
    // MOV SI,0x9fb (19EF_0F61 / 0x1AE51)
    SI = 0x9FB;
    CheckExternalEvents(cs14, 0xF68);
    // ADD SI,word ptr [0x9f9] (19EF_0F64 / 0x1AE54)
    SI += UInt16[DS, 0x9F9];
    CheckExternalEvents(cs14, 0xF6C);
    // INC byte ptr [0x9f9] (19EF_0F68 / 0x1AE58)
    UInt8[DS, 0x9F9] = Alu8.Inc(UInt8[DS, 0x9F9]);
    CheckExternalEvents(cs14, 0xF6E);
    // MOV AH,byte ptr [SI] (19EF_0F6C / 0x1AE5C)
    AH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xF70);
    // MOV SI,CX (19EF_0F6E / 0x1AE5E)
    SI = CX;
    CheckExternalEvents(cs14, 0xF74);
    // MOV CL,byte ptr [0x277] (19EF_0F70 / 0x1AE60)
    CL = UInt8[DS, 0x277];
    CheckExternalEvents(cs14, 0xF76);
    // SHL CL,0x1 (19EF_0F74 / 0x1AE64)
    // CL <<= 0x1;
    CL = Alu8.Shl(CL, 0x1);
    CheckExternalEvents(cs14, 0xF78);
    // MOV CH,CL (19EF_0F76 / 0x1AE66)
    CH = CL;
    CheckExternalEvents(cs14, 0xF7A);
    // SHL CL,0x1 (19EF_0F78 / 0x1AE68)
    CL <<= 0x1;
    CheckExternalEvents(cs14, 0xF7C);
    // DEC CL (19EF_0F7A / 0x1AE6A)
    CL--;
    CheckExternalEvents(cs14, 0xF7E);
    // AND CL,AH (19EF_0F7C / 0x1AE6C)
    CL &= AH;
    CheckExternalEvents(cs14, 0xF80);
    // SUB CL,CH (19EF_0F7E / 0x1AE6E)
    CL -= CH;
    CheckExternalEvents(cs14, 0xF82);
    // ADD DL,CL (19EF_0F80 / 0x1AE70)
    DL += CL;
    CheckExternalEvents(cs14, 0xF85);
    // CMP DL,0x80 (19EF_0F82 / 0x1AE72)
    Alu8.Sub(DL, 0x80);
    CheckExternalEvents(cs14, 0xF87);
    // JC 0x1000:ae79 (19EF_0F85 / 0x1AE75)
    if(CarryFlag) {
      goto label_19EF_0F89_1AE79;
    }
    CheckExternalEvents(cs14, 0xF89);
    // XOR DL,DL (19EF_0F87 / 0x1AE77)
    // DL ^= DL;
    DL = Alu8.Xor(DL, DL);
    label_19EF_0F89_1AE79:
    CheckExternalEvents(cs14, 0xF8B);
    // MOV byte ptr [BX + DI],DL (19EF_0F89 / 0x1AE79)
    UInt8[DS, (ushort)(BX + DI)] = DL;
    label_19EF_0F8B_1AE7B:
    CheckExternalEvents(cs14, 0xF8F);
    // MOV BL,byte ptr [0x273] (19EF_0F8B / 0x1AE7B)
    BL = UInt8[DS, 0x273];
    CheckExternalEvents(cs14, 0xF91);
    // MOV DL,byte ptr [BX + DI] (19EF_0F8F / 0x1AE7F)
    DL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xF95);
    // MOV BL,byte ptr [0x275] (19EF_0F91 / 0x1AE81)
    BL = UInt8[DS, 0x275];
    CheckExternalEvents(cs14, 0xF97);
    // MOV BL,byte ptr [BX + DI] (19EF_0F95 / 0x1AE85)
    BL = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xF99);
    // ADD DX,BX (19EF_0F97 / 0x1AE87)
    DX += BX;
    CheckExternalEvents(cs14, 0xF9B);
    // SHR DX,0x1 (19EF_0F99 / 0x1AE89)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs14, 0xF9F);
    // MOV BL,byte ptr [0x278] (19EF_0F9B / 0x1AE8B)
    BL = UInt8[DS, 0x278];
    CheckExternalEvents(cs14, 0xFA3);
    // ADD BL,byte ptr [0x273] (19EF_0F9F / 0x1AE8F)
    // BL += UInt8[DS, 0x273];
    BL = Alu8.Add(BL, UInt8[DS, 0x273]);
    CheckExternalEvents(cs14, 0xFA6);
    // MOV byte ptr [SI + 0x7],BL (19EF_0FA3 / 0x1AE93)
    UInt8[DS, (ushort)(SI + 0x7)] = BL;
    CheckExternalEvents(cs14, 0xFA9);
    // MOV byte ptr [SI + 0xd],BL (19EF_0FA6 / 0x1AE96)
    UInt8[DS, (ushort)(SI + 0xD)] = BL;
    CheckExternalEvents(cs14, 0xFAB);
    // MOV AH,byte ptr [BX + DI] (19EF_0FA9 / 0x1AE99)
    AH = UInt8[DS, (ushort)(BX + DI)];
    CheckExternalEvents(cs14, 0xFAE);
    // CMP AH,0xff (19EF_0FAB / 0x1AE9B)
    Alu8.Sub(AH, 0xFF);
    CheckExternalEvents(cs14, 0xFB0);
    // JNZ 0x1000:aed7 (19EF_0FAE / 0x1AE9E)
    if(!ZeroFlag) {
      goto label_19EF_0FE7_1AED7;
    }
    CheckExternalEvents(cs14, 0xFB2);
    // MOV CX,SI (19EF_0FB0 / 0x1AEA0)
    CX = SI;
    CheckExternalEvents(cs14, 0xFB5);
    // MOV SI,0x9fb (19EF_0FB2 / 0x1AEA2)
    SI = 0x9FB;
    CheckExternalEvents(cs14, 0xFB9);
    // ADD SI,word ptr [0x9f9] (19EF_0FB5 / 0x1AEA5)
    SI += UInt16[DS, 0x9F9];
    CheckExternalEvents(cs14, 0xFBD);
    // INC byte ptr [0x9f9] (19EF_0FB9 / 0x1AEA9)
    UInt8[DS, 0x9F9] = Alu8.Inc(UInt8[DS, 0x9F9]);
    CheckExternalEvents(cs14, 0xFBF);
    // MOV AH,byte ptr [SI] (19EF_0FBD / 0x1AEAD)
    AH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xFC1);
    // MOV SI,CX (19EF_0FBF / 0x1AEAF)
    SI = CX;
    CheckExternalEvents(cs14, 0xFC3);
    // MOV DH,AL (19EF_0FC1 / 0x1AEB1)
    DH = AL;
    CheckExternalEvents(cs14, 0xFC5);
    // SHR DH,0x1 (19EF_0FC3 / 0x1AEB3)
    DH >>= 0x1;
    CheckExternalEvents(cs14, 0xFC7);
    // SHR DH,0x1 (19EF_0FC5 / 0x1AEB5)
    DH >>= 0x1;
    CheckExternalEvents(cs14, 0xFC9);
    // SHR DH,0x1 (19EF_0FC7 / 0x1AEB7)
    DH >>= 0x1;
    CheckExternalEvents(cs14, 0xFCC);
    // CMP DH,0x9 (19EF_0FC9 / 0x1AEB9)
    Alu8.Sub(DH, 0x9);
    CheckExternalEvents(cs14, 0xFCE);
    // JNZ 0x1000:aec0 (19EF_0FCC / 0x1AEBC)
    if(!ZeroFlag) {
      goto label_19EF_0FD0_1AEC0;
    }
    CheckExternalEvents(cs14, 0xFD0);
    // DEC DH (19EF_0FCE / 0x1AEBE)
    DH--;
    label_19EF_0FD0_1AEC0:
    CheckExternalEvents(cs14, 0xFD2);
    // SHL DH,0x1 (19EF_0FD0 / 0x1AEC0)
    // DH <<= 0x1;
    DH = Alu8.Shl(DH, 0x1);
    CheckExternalEvents(cs14, 0xFD4);
    // MOV CH,DH (19EF_0FD2 / 0x1AEC2)
    CH = DH;
    CheckExternalEvents(cs14, 0xFD6);
    // SHL DH,0x1 (19EF_0FD4 / 0x1AEC4)
    DH <<= 0x1;
    CheckExternalEvents(cs14, 0xFD8);
    // DEC DH (19EF_0FD6 / 0x1AEC6)
    DH--;
    CheckExternalEvents(cs14, 0xFDA);
    // AND DH,AH (19EF_0FD8 / 0x1AEC8)
    DH &= AH;
    CheckExternalEvents(cs14, 0xFDC);
    // SUB DH,CH (19EF_0FDA / 0x1AECA)
    DH -= CH;
    CheckExternalEvents(cs14, 0xFDE);
    // ADD DL,DH (19EF_0FDC / 0x1AECC)
    DL += DH;
    CheckExternalEvents(cs14, 0xFE1);
    // CMP DL,0x80 (19EF_0FDE / 0x1AECE)
    Alu8.Sub(DL, 0x80);
    CheckExternalEvents(cs14, 0xFE3);
    // JC 0x1000:aed5 (19EF_0FE1 / 0x1AED1)
    if(CarryFlag) {
      goto label_19EF_0FE5_1AED5;
    }
    CheckExternalEvents(cs14, 0xFE5);
    // XOR DL,DL (19EF_0FE3 / 0x1AED3)
    // DL ^= DL;
    DL = Alu8.Xor(DL, DL);
    label_19EF_0FE5_1AED5:
    CheckExternalEvents(cs14, 0xFE7);
    // MOV byte ptr [BX + DI],DL (19EF_0FE5 / 0x1AED5)
    UInt8[DS, (ushort)(BX + DI)] = DL;
    label_19EF_0FE7_1AED7:
    CheckExternalEvents(cs14, 0xFEA);
    // ADD SI,0x10 (19EF_0FE7 / 0x1AED7)
    // SI += 0x10;
    SI = Alu16.Add(SI, 0x10);
    CheckExternalEvents(cs14, 0xFED);
    // JMP 0x1000:ace8 (19EF_0FEA / 0x1AEDA)
    goto label_19EF_0DF8_1ACE8;
    label_19EF_0FED_1AEDD:
    CheckExternalEvents(cs14, 0xFEE);
    // RET  (19EF_0FED / 0x1AEDD)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_0FEE_1AEDE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0FEE_1AEDE:
    CheckExternalEvents(cs14, 0xFEF);
    // PUSH BP (19EF_0FEE / 0x1AEDE)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0xFF1);
    // MOV BP,SP (19EF_0FEF / 0x1AEDF)
    BP = SP;
    CheckExternalEvents(cs14, 0xFF2);
    // PUSH DI (19EF_0FF1 / 0x1AEE1)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0xFF3);
    // PUSH SI (19EF_0FF2 / 0x1AEE2)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0xFF4);
    // PUSH DS (19EF_0FF3 / 0x1AEE3)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xFF7);
    // MOV AX,0x1ddc (19EF_0FF4 / 0x1AEE4)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0xFF9);
    // MOV DS,AX (19EF_0FF7 / 0x1AEE7)
    DS = AX;
    CheckExternalEvents(cs14, 0xFFC);
    // MOV SI,word ptr [BP + 0x6] (19EF_0FF9 / 0x1AEE9)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0xFFF);
    // MOV AX,word ptr [BP + 0x8] (19EF_0FFC / 0x1AEEC)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x1000);
    // PUSH ES (19EF_0FFF / 0x1AEEF)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x1002);
    // MOV ES,AX (19EF_1000 / 0x1AEF0)
    ES = AX;
    CheckExternalEvents(cs14, 0x1005);
    // MOV BX,0x0 (19EF_1002 / 0x1AEF2)
    BX = 0x0;
    label_19EF_1005_1AEF5:
    CheckExternalEvents(cs14, 0x1008);
    // MOV AL,byte ptr ES:[SI] (19EF_1005 / 0x1AEF5)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x100A);
    // XOR AH,AH (19EF_1008 / 0x1AEF8)
    AH = 0;
    CheckExternalEvents(cs14, 0x100C);
    // SHR AL,0x1 (19EF_100A / 0x1AEFA)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x100E);
    // SHR AL,0x1 (19EF_100C / 0x1AEFC)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x1010);
    // SHR AL,0x1 (19EF_100E / 0x1AEFE)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x1012);
    // SHR AL,0x1 (19EF_1010 / 0x1AF00)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0x1014);
    // MOV DI,AX (19EF_1012 / 0x1AF02)
    DI = AX;
    CheckExternalEvents(cs14, 0x1018);
    // MOV CH,byte ptr [DI + 0xa459] (19EF_1014 / 0x1AF04)
    CH = UInt8[DS, (ushort)(DI + 0xA459)];
    CheckExternalEvents(cs14, 0x101B);
    // MOV AL,byte ptr ES:[SI] (19EF_1018 / 0x1AF08)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x101D);
    // AND AL,0x7 (19EF_101B / 0x1AF0B)
    // AL &= 0x7;
    AL = Alu8.And(AL, 0x7);
    CheckExternalEvents(cs14, 0x101F);
    // MOV DI,AX (19EF_101D / 0x1AF0D)
    DI = AX;
    CheckExternalEvents(cs14, 0x1023);
    // MOV CL,byte ptr [DI + 0xa459] (19EF_101F / 0x1AF0F)
    CL = UInt8[DS, (ushort)(DI + 0xA459)];
    CheckExternalEvents(cs14, 0x1024);
    // INC SI (19EF_1023 / 0x1AF13)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x1027);
    // MOV AL,byte ptr ES:[SI] (19EF_1024 / 0x1AF14)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x1028);
    // INC SI (19EF_1027 / 0x1AF17)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x102A);
    // MOV DI,AX (19EF_1028 / 0x1AF18)
    DI = AX;
    CheckExternalEvents(cs14, 0x102E);
    // MOV DH,byte ptr [DI + 0xa459] (19EF_102A / 0x1AF1A)
    DH = UInt8[DS, (ushort)(DI + 0xA459)];
    CheckExternalEvents(cs14, 0x1031);
    // MOV AX,0x1010 (19EF_102E / 0x1AF1E)
    AX = 0x1010;
    CheckExternalEvents(cs14, 0x1033);
    // INT 0x10 (19EF_1031 / 0x1AF21)
    Interrupt(0x10);
    CheckExternalEvents(cs14, 0x1034);
    // PUSH BX (19EF_1033 / 0x1AF23)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x1036);
    // SHL BX,0x1 (19EF_1034 / 0x1AF24)
    BX <<= 0x1;
    CheckExternalEvents(cs14, 0x1038);
    // SHL BX,0x1 (19EF_1036 / 0x1AF26)
    BX <<= 0x1;
    CheckExternalEvents(cs14, 0x103A);
    // SHL BX,0x1 (19EF_1038 / 0x1AF28)
    BX <<= 0x1;
    CheckExternalEvents(cs14, 0x103C);
    // SHL BX,0x1 (19EF_103A / 0x1AF2A)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs14, 0x103F);
    // MOV AX,0x1010 (19EF_103C / 0x1AF2C)
    AX = 0x1010;
    CheckExternalEvents(cs14, 0x1041);
    // INT 0x10 (19EF_103F / 0x1AF2F)
    Interrupt(0x10);
    CheckExternalEvents(cs14, 0x1042);
    // POP BX (19EF_1041 / 0x1AF31)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1043);
    // INC BX (19EF_1042 / 0x1AF32)
    BX++;
    CheckExternalEvents(cs14, 0x1046);
    // CMP BX,0x10 (19EF_1043 / 0x1AF33)
    Alu16.Sub(BX, 0x10);
    CheckExternalEvents(cs14, 0x1048);
    // JC 0x1000:aef5 (19EF_1046 / 0x1AF36)
    if(CarryFlag) {
      goto label_19EF_1005_1AEF5;
    }
    CheckExternalEvents(cs14, 0x1049);
    // POP ES (19EF_1048 / 0x1AF38)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x104A);
    // POP DS (19EF_1049 / 0x1AF39)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x104B);
    // POP SI (19EF_104A / 0x1AF3A)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x104C);
    // POP DI (19EF_104B / 0x1AF3B)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x104D);
    // POP BP (19EF_104C / 0x1AF3C)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x104E);
    // RETF  (19EF_104D / 0x1AF3D)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_104E_1AF3E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_104E_1AF3E:
    CheckExternalEvents(cs14, 0x104F);
    // PUSH BP (19EF_104E / 0x1AF3E)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x1051);
    // MOV BP,SP (19EF_104F / 0x1AF3F)
    BP = SP;
    CheckExternalEvents(cs14, 0x1052);
    // PUSH DI (19EF_1051 / 0x1AF41)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1053);
    // PUSH SI (19EF_1052 / 0x1AF42)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1054);
    // PUSH DS (19EF_1053 / 0x1AF43)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1057);
    // MOV AX,0x1ddc (19EF_1054 / 0x1AF44)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x1059);
    // MOV DS,AX (19EF_1057 / 0x1AF47)
    DS = AX;
    CheckExternalEvents(cs14, 0x105C);
    // MOV BX,word ptr [BP + 0x6] (19EF_1059 / 0x1AF49)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x105F);
    // SUB BX,0x11 (19EF_105C / 0x1AF4C)
    // BX -= 0x11;
    BX = Alu16.Sub(BX, 0x11);
    CheckExternalEvents(cs14, 0x1062);
    // MOV DI,0x2d3 (19EF_105F / 0x1AF4F)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x1066);
    // MOV AL,byte ptr [BX + 0xb0b] (19EF_1062 / 0x1AF52)
    AL = UInt8[DS, (ushort)(BX + 0xB0B)];
    CheckExternalEvents(cs14, 0x1068);
    // MOV byte ptr [DI],AL (19EF_1066 / 0x1AF56)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x106C);
    // MOV AL,byte ptr [BX + 0xb0c] (19EF_1068 / 0x1AF58)
    AL = UInt8[DS, (ushort)(BX + 0xB0C)];
    CheckExternalEvents(cs14, 0x106F);
    // MOV byte ptr [DI + 0x8],AL (19EF_106C / 0x1AF5C)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    CheckExternalEvents(cs14, 0x1073);
    // MOV AL,byte ptr [BX + 0xb1b] (19EF_106F / 0x1AF5F)
    AL = UInt8[DS, (ushort)(BX + 0xB1B)];
    CheckExternalEvents(cs14, 0x1076);
    // MOV byte ptr [DI + 0x48],AL (19EF_1073 / 0x1AF63)
    UInt8[DS, (ushort)(DI + 0x48)] = AL;
    CheckExternalEvents(cs14, 0x107A);
    // MOV AL,byte ptr [BX + 0xb1c] (19EF_1076 / 0x1AF66)
    AL = UInt8[DS, (ushort)(BX + 0xB1C)];
    CheckExternalEvents(cs14, 0x107D);
    // MOV byte ptr [DI + 0x50],AL (19EF_107A / 0x1AF6A)
    UInt8[DS, (ushort)(DI + 0x50)] = AL;
    CheckExternalEvents(cs14, 0x1080);
    // MOV SI,0x564 (19EF_107D / 0x1AF6D)
    SI = 0x564;
    CheckExternalEvents(cs14, 0x1081);
    // PUSH BX (19EF_1080 / 0x1AF70)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x1084);
    // CALL 0x1000:aaeb (19EF_1081 / 0x1AF71)
    NearCall(cs14, 0x1084, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x1085);
    // POP BX (19EF_1084 / 0x1AF74)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1088);
    // MOV DI,0x2d3 (19EF_1085 / 0x1AF75)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x108C);
    // MOV AL,byte ptr [BX + 0xb0c] (19EF_1088 / 0x1AF78)
    AL = UInt8[DS, (ushort)(BX + 0xB0C)];
    CheckExternalEvents(cs14, 0x108E);
    // MOV byte ptr [DI],AL (19EF_108C / 0x1AF7C)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x1092);
    // MOV AL,byte ptr [BX + 0xb0d] (19EF_108E / 0x1AF7E)
    AL = UInt8[DS, (ushort)(BX + 0xB0D)];
    CheckExternalEvents(cs14, 0x1095);
    // MOV byte ptr [DI + 0x8],AL (19EF_1092 / 0x1AF82)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    CheckExternalEvents(cs14, 0x1099);
    // MOV AL,byte ptr [BX + 0xb1c] (19EF_1095 / 0x1AF85)
    AL = UInt8[DS, (ushort)(BX + 0xB1C)];
    CheckExternalEvents(cs14, 0x109C);
    // MOV byte ptr [DI + 0x48],AL (19EF_1099 / 0x1AF89)
    UInt8[DS, (ushort)(DI + 0x48)] = AL;
    CheckExternalEvents(cs14, 0x10A0);
    // MOV AL,byte ptr [BX + 0xb1d] (19EF_109C / 0x1AF8C)
    AL = UInt8[DS, (ushort)(BX + 0xB1D)];
    CheckExternalEvents(cs14, 0x10A3);
    // MOV byte ptr [DI + 0x50],AL (19EF_10A0 / 0x1AF90)
    UInt8[DS, (ushort)(DI + 0x50)] = AL;
    CheckExternalEvents(cs14, 0x10A6);
    // MOV SI,0x5a4 (19EF_10A3 / 0x1AF93)
    SI = 0x5A4;
    CheckExternalEvents(cs14, 0x10A7);
    // PUSH BX (19EF_10A6 / 0x1AF96)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x10AA);
    // CALL 0x1000:aaeb (19EF_10A7 / 0x1AF97)
    NearCall(cs14, 0x10AA, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x10AB);
    // POP BX (19EF_10AA / 0x1AF9A)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x10AE);
    // MOV DI,0x2d3 (19EF_10AB / 0x1AF9B)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x10B2);
    // MOV AL,byte ptr [BX + 0xb0d] (19EF_10AE / 0x1AF9E)
    AL = UInt8[DS, (ushort)(BX + 0xB0D)];
    CheckExternalEvents(cs14, 0x10B4);
    // MOV byte ptr [DI],AL (19EF_10B2 / 0x1AFA2)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x10B8);
    // MOV AL,byte ptr [BX + 0xb0e] (19EF_10B4 / 0x1AFA4)
    AL = UInt8[DS, (ushort)(BX + 0xB0E)];
    CheckExternalEvents(cs14, 0x10BB);
    // MOV byte ptr [DI + 0x8],AL (19EF_10B8 / 0x1AFA8)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    CheckExternalEvents(cs14, 0x10BF);
    // MOV AL,byte ptr [BX + 0xb1d] (19EF_10BB / 0x1AFAB)
    AL = UInt8[DS, (ushort)(BX + 0xB1D)];
    CheckExternalEvents(cs14, 0x10C2);
    // MOV byte ptr [DI + 0x48],AL (19EF_10BF / 0x1AFAF)
    UInt8[DS, (ushort)(DI + 0x48)] = AL;
    CheckExternalEvents(cs14, 0x10C6);
    // MOV AL,byte ptr [BX + 0xb1e] (19EF_10C2 / 0x1AFB2)
    AL = UInt8[DS, (ushort)(BX + 0xB1E)];
    CheckExternalEvents(cs14, 0x10C9);
    // MOV byte ptr [DI + 0x50],AL (19EF_10C6 / 0x1AFB6)
    UInt8[DS, (ushort)(DI + 0x50)] = AL;
    CheckExternalEvents(cs14, 0x10CC);
    // MOV SI,0x5e4 (19EF_10C9 / 0x1AFB9)
    SI = 0x5E4;
    CheckExternalEvents(cs14, 0x10CD);
    // PUSH BX (19EF_10CC / 0x1AFBC)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x10D0);
    // CALL 0x1000:aaeb (19EF_10CD / 0x1AFBD)
    NearCall(cs14, 0x10D0, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x10D1);
    // POP BX (19EF_10D0 / 0x1AFC0)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x10D4);
    // MOV DI,0x2d3 (19EF_10D1 / 0x1AFC1)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x10D8);
    // MOV AL,byte ptr [BX + 0xb1b] (19EF_10D4 / 0x1AFC4)
    AL = UInt8[DS, (ushort)(BX + 0xB1B)];
    CheckExternalEvents(cs14, 0x10DA);
    // MOV byte ptr [DI],AL (19EF_10D8 / 0x1AFC8)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x10DE);
    // MOV AL,byte ptr [BX + 0xb1c] (19EF_10DA / 0x1AFCA)
    AL = UInt8[DS, (ushort)(BX + 0xB1C)];
    CheckExternalEvents(cs14, 0x10E1);
    // MOV byte ptr [DI + 0x8],AL (19EF_10DE / 0x1AFCE)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    CheckExternalEvents(cs14, 0x10E5);
    // MOV AL,byte ptr [BX + 0xb2b] (19EF_10E1 / 0x1AFD1)
    AL = UInt8[DS, (ushort)(BX + 0xB2B)];
    CheckExternalEvents(cs14, 0x10E8);
    // MOV byte ptr [DI + 0x48],AL (19EF_10E5 / 0x1AFD5)
    UInt8[DS, (ushort)(DI + 0x48)] = AL;
    CheckExternalEvents(cs14, 0x10EC);
    // MOV AL,byte ptr [BX + 0xb2c] (19EF_10E8 / 0x1AFD8)
    AL = UInt8[DS, (ushort)(BX + 0xB2C)];
    CheckExternalEvents(cs14, 0x10EF);
    // MOV byte ptr [DI + 0x50],AL (19EF_10EC / 0x1AFDC)
    UInt8[DS, (ushort)(DI + 0x50)] = AL;
    CheckExternalEvents(cs14, 0x10F2);
    // MOV SI,0x624 (19EF_10EF / 0x1AFDF)
    SI = 0x624;
    CheckExternalEvents(cs14, 0x10F3);
    // PUSH BX (19EF_10F2 / 0x1AFE2)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x10F6);
    // CALL 0x1000:aaeb (19EF_10F3 / 0x1AFE3)
    NearCall(cs14, 0x10F6, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x10F7);
    // POP BX (19EF_10F6 / 0x1AFE6)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x10FA);
    // MOV DI,0x2d3 (19EF_10F7 / 0x1AFE7)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x10FE);
    // MOV AL,byte ptr [BX + 0xb1c] (19EF_10FA / 0x1AFEA)
    AL = UInt8[DS, (ushort)(BX + 0xB1C)];
    CheckExternalEvents(cs14, 0x1100);
    // MOV byte ptr [DI],AL (19EF_10FE / 0x1AFEE)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x1104);
    // MOV AL,byte ptr [BX + 0xb1d] (19EF_1100 / 0x1AFF0)
    AL = UInt8[DS, (ushort)(BX + 0xB1D)];
    CheckExternalEvents(cs14, 0x1107);
    // MOV byte ptr [DI + 0x8],AL (19EF_1104 / 0x1AFF4)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    CheckExternalEvents(cs14, 0x110B);
    // MOV AL,byte ptr [BX + 0xb2c] (19EF_1107 / 0x1AFF7)
    AL = UInt8[DS, (ushort)(BX + 0xB2C)];
    CheckExternalEvents(cs14, 0x110E);
    // MOV byte ptr [DI + 0x48],AL (19EF_110B / 0x1AFFB)
    UInt8[DS, (ushort)(DI + 0x48)] = AL;
    CheckExternalEvents(cs14, 0x1112);
    // MOV AL,byte ptr [BX + 0xb2d] (19EF_110E / 0x1AFFE)
    AL = UInt8[DS, (ushort)(BX + 0xB2D)];
    CheckExternalEvents(cs14, 0x1115);
    // MOV byte ptr [DI + 0x50],AL (19EF_1112 / 0x1B002)
    UInt8[DS, (ushort)(DI + 0x50)] = AL;
    CheckExternalEvents(cs14, 0x1118);
    // MOV SI,0x664 (19EF_1115 / 0x1B005)
    SI = 0x664;
    CheckExternalEvents(cs14, 0x1119);
    // PUSH BX (19EF_1118 / 0x1B008)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x111C);
    // CALL 0x1000:aaeb (19EF_1119 / 0x1B009)
    NearCall(cs14, 0x111C, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x111D);
    // POP BX (19EF_111C / 0x1B00C)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1120);
    // MOV DI,0x2d3 (19EF_111D / 0x1B00D)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x1124);
    // MOV AL,byte ptr [BX + 0xb1d] (19EF_1120 / 0x1B010)
    AL = UInt8[DS, (ushort)(BX + 0xB1D)];
    CheckExternalEvents(cs14, 0x1126);
    // MOV byte ptr [DI],AL (19EF_1124 / 0x1B014)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x112A);
    // MOV AL,byte ptr [BX + 0xb1e] (19EF_1126 / 0x1B016)
    AL = UInt8[DS, (ushort)(BX + 0xB1E)];
    CheckExternalEvents(cs14, 0x112D);
    // MOV byte ptr [DI + 0x8],AL (19EF_112A / 0x1B01A)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    CheckExternalEvents(cs14, 0x1131);
    // MOV AL,byte ptr [BX + 0xb2d] (19EF_112D / 0x1B01D)
    AL = UInt8[DS, (ushort)(BX + 0xB2D)];
    CheckExternalEvents(cs14, 0x1134);
    // MOV byte ptr [DI + 0x48],AL (19EF_1131 / 0x1B021)
    UInt8[DS, (ushort)(DI + 0x48)] = AL;
    CheckExternalEvents(cs14, 0x1138);
    // MOV AL,byte ptr [BX + 0xb2e] (19EF_1134 / 0x1B024)
    AL = UInt8[DS, (ushort)(BX + 0xB2E)];
    CheckExternalEvents(cs14, 0x113B);
    // MOV byte ptr [DI + 0x50],AL (19EF_1138 / 0x1B028)
    UInt8[DS, (ushort)(DI + 0x50)] = AL;
    CheckExternalEvents(cs14, 0x113E);
    // MOV SI,0x6a4 (19EF_113B / 0x1B02B)
    SI = 0x6A4;
    CheckExternalEvents(cs14, 0x113F);
    // PUSH BX (19EF_113E / 0x1B02E)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x1142);
    // CALL 0x1000:aaeb (19EF_113F / 0x1B02F)
    NearCall(cs14, 0x1142, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x1143);
    // POP BX (19EF_1142 / 0x1B032)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1146);
    // MOV DI,0x2d3 (19EF_1143 / 0x1B033)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x114A);
    // MOV AL,byte ptr [BX + 0xb2b] (19EF_1146 / 0x1B036)
    AL = UInt8[DS, (ushort)(BX + 0xB2B)];
    CheckExternalEvents(cs14, 0x114C);
    // MOV byte ptr [DI],AL (19EF_114A / 0x1B03A)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x1150);
    // MOV AL,byte ptr [BX + 0xb2c] (19EF_114C / 0x1B03C)
    AL = UInt8[DS, (ushort)(BX + 0xB2C)];
    CheckExternalEvents(cs14, 0x1153);
    // MOV byte ptr [DI + 0x8],AL (19EF_1150 / 0x1B040)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    CheckExternalEvents(cs14, 0x1157);
    // MOV AL,byte ptr [BX + 0xb3b] (19EF_1153 / 0x1B043)
    AL = UInt8[DS, (ushort)(BX + 0xB3B)];
    CheckExternalEvents(cs14, 0x115A);
    // MOV byte ptr [DI + 0x48],AL (19EF_1157 / 0x1B047)
    UInt8[DS, (ushort)(DI + 0x48)] = AL;
    CheckExternalEvents(cs14, 0x115E);
    // MOV AL,byte ptr [BX + 0xb3c] (19EF_115A / 0x1B04A)
    AL = UInt8[DS, (ushort)(BX + 0xB3C)];
    CheckExternalEvents(cs14, 0x1161);
    // MOV byte ptr [DI + 0x50],AL (19EF_115E / 0x1B04E)
    UInt8[DS, (ushort)(DI + 0x50)] = AL;
    CheckExternalEvents(cs14, 0x1164);
    // MOV SI,0x6e4 (19EF_1161 / 0x1B051)
    SI = 0x6E4;
    CheckExternalEvents(cs14, 0x1165);
    // PUSH BX (19EF_1164 / 0x1B054)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x1168);
    // CALL 0x1000:aaeb (19EF_1165 / 0x1B055)
    NearCall(cs14, 0x1168, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x1169);
    // POP BX (19EF_1168 / 0x1B058)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x116C);
    // MOV DI,0x2d3 (19EF_1169 / 0x1B059)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x1170);
    // MOV AL,byte ptr [BX + 0xb2c] (19EF_116C / 0x1B05C)
    AL = UInt8[DS, (ushort)(BX + 0xB2C)];
    CheckExternalEvents(cs14, 0x1172);
    // MOV byte ptr [DI],AL (19EF_1170 / 0x1B060)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x1176);
    // MOV AL,byte ptr [BX + 0xb2d] (19EF_1172 / 0x1B062)
    AL = UInt8[DS, (ushort)(BX + 0xB2D)];
    CheckExternalEvents(cs14, 0x1179);
    // MOV byte ptr [DI + 0x8],AL (19EF_1176 / 0x1B066)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    CheckExternalEvents(cs14, 0x117D);
    // MOV AL,byte ptr [BX + 0xb3c] (19EF_1179 / 0x1B069)
    AL = UInt8[DS, (ushort)(BX + 0xB3C)];
    CheckExternalEvents(cs14, 0x1180);
    // MOV byte ptr [DI + 0x48],AL (19EF_117D / 0x1B06D)
    UInt8[DS, (ushort)(DI + 0x48)] = AL;
    CheckExternalEvents(cs14, 0x1184);
    // MOV AL,byte ptr [BX + 0xb3d] (19EF_1180 / 0x1B070)
    AL = UInt8[DS, (ushort)(BX + 0xB3D)];
    CheckExternalEvents(cs14, 0x1187);
    // MOV byte ptr [DI + 0x50],AL (19EF_1184 / 0x1B074)
    UInt8[DS, (ushort)(DI + 0x50)] = AL;
    CheckExternalEvents(cs14, 0x118A);
    // MOV SI,0x724 (19EF_1187 / 0x1B077)
    SI = 0x724;
    CheckExternalEvents(cs14, 0x118B);
    // PUSH BX (19EF_118A / 0x1B07A)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x118E);
    // CALL 0x1000:aaeb (19EF_118B / 0x1B07B)
    NearCall(cs14, 0x118E, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x118F);
    // POP BX (19EF_118E / 0x1B07E)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1192);
    // MOV DI,0x2d3 (19EF_118F / 0x1B07F)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x1196);
    // MOV AL,byte ptr [BX + 0xb2d] (19EF_1192 / 0x1B082)
    AL = UInt8[DS, (ushort)(BX + 0xB2D)];
    CheckExternalEvents(cs14, 0x1198);
    // MOV byte ptr [DI],AL (19EF_1196 / 0x1B086)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x119C);
    // MOV AL,byte ptr [BX + 0xb2e] (19EF_1198 / 0x1B088)
    AL = UInt8[DS, (ushort)(BX + 0xB2E)];
    CheckExternalEvents(cs14, 0x119F);
    // MOV byte ptr [DI + 0x8],AL (19EF_119C / 0x1B08C)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    CheckExternalEvents(cs14, 0x11A3);
    // MOV AL,byte ptr [BX + 0xb3d] (19EF_119F / 0x1B08F)
    AL = UInt8[DS, (ushort)(BX + 0xB3D)];
    CheckExternalEvents(cs14, 0x11A6);
    // MOV byte ptr [DI + 0x48],AL (19EF_11A3 / 0x1B093)
    UInt8[DS, (ushort)(DI + 0x48)] = AL;
    CheckExternalEvents(cs14, 0x11AA);
    // MOV AL,byte ptr [BX + 0xb3e] (19EF_11A6 / 0x1B096)
    AL = UInt8[DS, (ushort)(BX + 0xB3E)];
    CheckExternalEvents(cs14, 0x11AD);
    // MOV byte ptr [DI + 0x50],AL (19EF_11AA / 0x1B09A)
    UInt8[DS, (ushort)(DI + 0x50)] = AL;
    CheckExternalEvents(cs14, 0x11B0);
    // MOV SI,0x764 (19EF_11AD / 0x1B09D)
    SI = 0x764;
    CheckExternalEvents(cs14, 0x11B3);
    // CALL 0x1000:aaeb (19EF_11B0 / 0x1B0A0)
    NearCall(cs14, 0x11B3, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x11B6);
    // CALL 0x1000:b776 (19EF_11B3 / 0x1B0A3)
    NearCall(cs14, 0x11B6, unknown_19EF_1886_1B776);
    CheckExternalEvents(cs14, 0x11B7);
    // POP DS (19EF_11B6 / 0x1B0A6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x11B8);
    // POP SI (19EF_11B7 / 0x1B0A7)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x11B9);
    // POP DI (19EF_11B8 / 0x1B0A8)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x11BA);
    // POP BP (19EF_11B9 / 0x1B0A9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x11BB);
    // RETF  (19EF_11BA / 0x1B0AA)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_11BB_1B0AB(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1B112: goto label_19EF_1222_1B112;break; // Target of external jump from 0x1B145
      case 0x1B0F5: goto label_19EF_1205_1B0F5;break; // Target of external jump from 0x1B162
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_19EF_11BB_1B0AB:
    CheckExternalEvents(cs14, 0x11BE);
    // CALL 0x1000:b1aa (19EF_11BB / 0x1B0AB)
    NearCall(cs14, 0x11BE, unknown_19EF_12BA_1B1AA);
    CheckExternalEvents(cs14, 0x11C0);
    // OR AL,AL (19EF_11BE / 0x1B0AE)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x11C2);
    // JS 0x1000:b0b5 (19EF_11C0 / 0x1B0B0)
    if(SignFlag) {
      goto label_19EF_11C5_1B0B5;
    }
    CheckExternalEvents(cs14, 0x11C5);
    // CALL 0x1000:b1e2 (19EF_11C2 / 0x1B0B2)
    NearCall(cs14, 0x11C5, unknown_19EF_12F2_1B1E2);
    label_19EF_11C5_1B0B5:
    CheckExternalEvents(cs14, 0x11C7);
    // MOV byte ptr [DI],BL (19EF_11C5 / 0x1B0B5)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs14, 0x11C8);
    // INC SI (19EF_11C7 / 0x1B0B7)
    SI++;
    CheckExternalEvents(cs14, 0x11C9);
    // INC DI (19EF_11C8 / 0x1B0B8)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs14, 0x11CC);
    // MOV CX,0x6 (19EF_11C9 / 0x1B0B9)
    CX = 0x6;
    label_19EF_11CC_1B0BC:
    CheckExternalEvents(cs14, 0x11CE);
    // XOR BL,BL (19EF_11CC / 0x1B0BC)
    // BL ^= BL;
    BL = Alu8.Xor(BL, BL);
    CheckExternalEvents(cs14, 0x11D0);
    // MOV AL,byte ptr [SI] (19EF_11CE / 0x1B0BE)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x11D2);
    // OR AL,AL (19EF_11D0 / 0x1B0C0)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x11D4);
    // JNS 0x1000:b0cb (19EF_11D2 / 0x1B0C2)
    if(!SignFlag) {
      goto label_19EF_11DB_1B0CB;
    }
    CheckExternalEvents(cs14, 0x11D6);
    // MOV BL,AL (19EF_11D4 / 0x1B0C4)
    BL = AL;
    CheckExternalEvents(cs14, 0x11D9);
    // SUB BL,0x80 (19EF_11D6 / 0x1B0C6)
    // BL -= 0x80;
    BL = Alu8.Sub(BL, 0x80);
    CheckExternalEvents(cs14, 0x11DB);
    // JNZ 0x1000:b0de (19EF_11D9 / 0x1B0C9)
    if(!ZeroFlag) {
      goto label_19EF_11EE_1B0DE;
    }
    label_19EF_11DB_1B0CB:
    CheckExternalEvents(cs14, 0x11DE);
    // CALL 0x1000:b1e2 (19EF_11DB / 0x1B0CB)
    NearCall(cs14, 0x11DE, unknown_19EF_12F2_1B1E2);
    CheckExternalEvents(cs14, 0x11E1);
    // CMP AL,byte ptr [SI + -0x1] (19EF_11DE / 0x1B0CE)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI - 0x1)]);
    CheckExternalEvents(cs14, 0x11E3);
    // JNZ 0x1000:b0d6 (19EF_11E1 / 0x1B0D1)
    if(!ZeroFlag) {
      goto label_19EF_11E6_1B0D6;
    }
    CheckExternalEvents(cs14, 0x11E6);
    // OR BL,0x8 (19EF_11E3 / 0x1B0D3)
    BL |= 0x8;
    label_19EF_11E6_1B0D6:
    CheckExternalEvents(cs14, 0x11E9);
    // CMP AL,byte ptr [SI + 0x1] (19EF_11E6 / 0x1B0D6)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI + 0x1)]);
    CheckExternalEvents(cs14, 0x11EB);
    // JNZ 0x1000:b0de (19EF_11E9 / 0x1B0D9)
    if(!ZeroFlag) {
      goto label_19EF_11EE_1B0DE;
    }
    CheckExternalEvents(cs14, 0x11EE);
    // OR BL,0x2 (19EF_11EB / 0x1B0DB)
    // BL |= 0x2;
    BL = Alu8.Or(BL, 0x2);
    label_19EF_11EE_1B0DE:
    CheckExternalEvents(cs14, 0x11F0);
    // MOV byte ptr [DI],BL (19EF_11EE / 0x1B0DE)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs14, 0x11F1);
    // INC SI (19EF_11F0 / 0x1B0E0)
    SI++;
    CheckExternalEvents(cs14, 0x11F2);
    // INC DI (19EF_11F1 / 0x1B0E1)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs14, 0x11F4);
    // LOOP 0x1000:b0bc (19EF_11F2 / 0x1B0E2)
    if(--CX != 0) {
      goto label_19EF_11CC_1B0BC;
    }
    CheckExternalEvents(cs14, 0x11F7);
    // CALL 0x1000:b1c9 (19EF_11F4 / 0x1B0E4)
    NearCall(cs14, 0x11F7, unknown_19EF_12D9_1B1C9);
    CheckExternalEvents(cs14, 0x11F9);
    // OR AL,AL (19EF_11F7 / 0x1B0E7)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x11FB);
    // JS 0x1000:b0ee (19EF_11F9 / 0x1B0E9)
    if(SignFlag) {
      goto label_19EF_11FE_1B0EE;
    }
    CheckExternalEvents(cs14, 0x11FE);
    // CALL 0x1000:b1e2 (19EF_11FB / 0x1B0EB)
    NearCall(cs14, 0x11FE, unknown_19EF_12F2_1B1E2);
    label_19EF_11FE_1B0EE:
    CheckExternalEvents(cs14, 0x1200);
    // MOV byte ptr [DI],BL (19EF_11FE / 0x1B0EE)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs14, 0x1201);
    // INC SI (19EF_1200 / 0x1B0F0)
    SI++;
    CheckExternalEvents(cs14, 0x1202);
    // INC DI (19EF_1201 / 0x1B0F1)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs14, 0x1205);
    // MOV DX,0x6 (19EF_1202 / 0x1B0F2)
    DX = 0x6;
    label_19EF_1205_1B0F5:
    CheckExternalEvents(cs14, 0x1208);
    // CALL 0x1000:b1aa (19EF_1205 / 0x1B0F5)
    NearCall(cs14, 0x1208, unknown_19EF_12BA_1B1AA);
    CheckExternalEvents(cs14, 0x120A);
    // OR AL,AL (19EF_1208 / 0x1B0F8)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x120C);
    // JS 0x1000:b10b (19EF_120A / 0x1B0FA)
    if(SignFlag) {
      goto label_19EF_121B_1B10B;
    }
    CheckExternalEvents(cs14, 0x120F);
    // CMP AL,byte ptr [SI + 0x8] (19EF_120C / 0x1B0FC)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI + 0x8)]);
    CheckExternalEvents(cs14, 0x1211);
    // JNZ 0x1000:b104 (19EF_120F / 0x1B0FF)
    if(!ZeroFlag) {
      goto label_19EF_1214_1B104;
    }
    CheckExternalEvents(cs14, 0x1214);
    // OR BL,0x4 (19EF_1211 / 0x1B101)
    BL |= 0x4;
    label_19EF_1214_1B104:
    CheckExternalEvents(cs14, 0x1217);
    // CMP AL,byte ptr [SI + -0x8] (19EF_1214 / 0x1B104)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI - 0x8)]);
    CheckExternalEvents(cs14, 0x1219);
    // JNZ 0x1000:b10b (19EF_1217 / 0x1B107)
    if(!ZeroFlag) {
      goto label_19EF_121B_1B10B;
    }
    CheckExternalEvents(cs14, 0x121B);
    // INC BL (19EF_1219 / 0x1B109)
    BL = Alu8.Inc(BL);
    label_19EF_121B_1B10B:
    CheckExternalEvents(cs14, 0x121D);
    // MOV byte ptr [DI],BL (19EF_121B / 0x1B10B)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs14, 0x121E);
    // INC SI (19EF_121D / 0x1B10D)
    SI++;
    CheckExternalEvents(cs14, 0x121F);
    // INC DI (19EF_121E / 0x1B10E)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs14, 0x1222);
    // MOV CX,0x6 (19EF_121F / 0x1B10F)
    CX = 0x6;
    label_19EF_1222_1B112:
    CheckExternalEvents(cs14, 0x1224);
    // XOR BL,BL (19EF_1222 / 0x1B112)
    // BL ^= BL;
    BL = Alu8.Xor(BL, BL);
    CheckExternalEvents(cs14, 0x1226);
    // MOV AL,byte ptr [SI] (19EF_1224 / 0x1B114)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x1228);
    // OR AL,AL (19EF_1226 / 0x1B116)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x122A);
    // JNS 0x1000:b122 (19EF_1228 / 0x1B118)
    if(!SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_B122_1B122, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x122C);
    // MOV BL,AL (19EF_122A / 0x1B11A)
    BL = AL;
    CheckExternalEvents(cs14, 0x122F);
    // SUB BL,0x80 (19EF_122C / 0x1B11C)
    // BL -= 0x80;
    BL = Alu8.Sub(BL, 0x80);
    CheckExternalEvents(cs14, 0x1231);
    // JMP 0x1000:b141 (19EF_122F / 0x1B11F)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_B122_1B122, 0x1B141 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_B122_1B122(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1B141: goto label_1000_B141_1B141;break; // Target of external jump from 0x1B13D, 0x1B11F
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_B122_1B122:
    CheckExternalEvents(cs8, 0xB125);
    // CMP AL,byte ptr [SI + -0x1] (1000_B122 / 0x1B122)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI - 0x1)]);
    CheckExternalEvents(cs8, 0xB127);
    // JNZ 0x1000:b12a (1000_B125 / 0x1B125)
    if(!ZeroFlag) {
      goto label_1000_B12A_1B12A;
    }
    CheckExternalEvents(cs8, 0xB12A);
    // OR BL,0x8 (1000_B127 / 0x1B127)
    BL |= 0x8;
    label_1000_B12A_1B12A:
    CheckExternalEvents(cs8, 0xB12D);
    // CMP AL,byte ptr [SI + 0x8] (1000_B12A / 0x1B12A)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI + 0x8)]);
    CheckExternalEvents(cs8, 0xB12F);
    // JNZ 0x1000:b132 (1000_B12D / 0x1B12D)
    if(!ZeroFlag) {
      goto label_1000_B132_1B132;
    }
    CheckExternalEvents(cs8, 0xB132);
    // OR BL,0x4 (1000_B12F / 0x1B12F)
    BL |= 0x4;
    label_1000_B132_1B132:
    CheckExternalEvents(cs8, 0xB135);
    // CMP AL,byte ptr [SI + 0x1] (1000_B132 / 0x1B132)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI + 0x1)]);
    CheckExternalEvents(cs8, 0xB137);
    // JNZ 0x1000:b13a (1000_B135 / 0x1B135)
    if(!ZeroFlag) {
      goto label_1000_B13A_1B13A;
    }
    CheckExternalEvents(cs8, 0xB13A);
    // OR BL,0x2 (1000_B137 / 0x1B137)
    BL |= 0x2;
    label_1000_B13A_1B13A:
    CheckExternalEvents(cs8, 0xB13D);
    // CMP AL,byte ptr [SI + -0x8] (1000_B13A / 0x1B13A)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI - 0x8)]);
    CheckExternalEvents(cs8, 0xB13F);
    // JNZ 0x1000:b141 (1000_B13D / 0x1B13D)
    if(!ZeroFlag) {
      goto label_1000_B141_1B141;
    }
    CheckExternalEvents(cs8, 0xB141);
    // INC BL (1000_B13F / 0x1B13F)
    BL = Alu8.Inc(BL);
    label_1000_B141_1B141:
    CheckExternalEvents(cs8, 0xB143);
    // MOV byte ptr [DI],BL (1000_B141 / 0x1B141)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs8, 0xB144);
    // INC SI (1000_B143 / 0x1B143)
    SI++;
    CheckExternalEvents(cs8, 0xB145);
    // INC DI (1000_B144 / 0x1B144)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs8, 0xB147);
    // LOOP 0x1000:b112 (1000_B145 / 0x1B145)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(unknown_19EF_11BB_1B0AB, 0x1B112 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xB14A);
    // CALL 0x1000:b1c9 (1000_B147 / 0x1B147)
    NearCall(cs8, 0xB14A, unknown_19EF_12D9_1B1C9);
    CheckExternalEvents(cs8, 0xB14C);
    // OR AL,AL (1000_B14A / 0x1B14A)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs8, 0xB14E);
    // JS 0x1000:b15d (1000_B14C / 0x1B14C)
    if(SignFlag) {
      goto label_1000_B15D_1B15D;
    }
    CheckExternalEvents(cs8, 0xB151);
    // CMP AL,byte ptr [SI + 0x8] (1000_B14E / 0x1B14E)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI + 0x8)]);
    CheckExternalEvents(cs8, 0xB153);
    // JNZ 0x1000:b156 (1000_B151 / 0x1B151)
    if(!ZeroFlag) {
      goto label_1000_B156_1B156;
    }
    CheckExternalEvents(cs8, 0xB156);
    // OR BL,0x4 (1000_B153 / 0x1B153)
    BL |= 0x4;
    label_1000_B156_1B156:
    CheckExternalEvents(cs8, 0xB159);
    // CMP AL,byte ptr [SI + -0x8] (1000_B156 / 0x1B156)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI - 0x8)]);
    CheckExternalEvents(cs8, 0xB15B);
    // JNZ 0x1000:b15d (1000_B159 / 0x1B159)
    if(!ZeroFlag) {
      goto label_1000_B15D_1B15D;
    }
    CheckExternalEvents(cs8, 0xB15D);
    // INC BL (1000_B15B / 0x1B15B)
    BL = Alu8.Inc(BL);
    label_1000_B15D_1B15D:
    CheckExternalEvents(cs8, 0xB15F);
    // MOV byte ptr [DI],BL (1000_B15D / 0x1B15D)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs8, 0xB160);
    // INC SI (1000_B15F / 0x1B15F)
    SI++;
    CheckExternalEvents(cs8, 0xB161);
    // INC DI (1000_B160 / 0x1B160)
    DI++;
    CheckExternalEvents(cs8, 0xB162);
    // DEC DX (1000_B161 / 0x1B161)
    DX = Alu16.Dec(DX);
    CheckExternalEvents(cs8, 0xB164);
    // JNZ 0x1000:b0f5 (1000_B162 / 0x1B162)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(unknown_19EF_11BB_1B0AB, 0x1B0F5 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xB167);
    // CALL 0x1000:b1aa (1000_B164 / 0x1B164)
    NearCall(cs8, 0xB167, unknown_19EF_12BA_1B1AA);
    CheckExternalEvents(cs8, 0xB169);
    // OR AL,AL (1000_B167 / 0x1B167)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs8, 0xB16B);
    // JS 0x1000:b16e (1000_B169 / 0x1B169)
    if(SignFlag) {
      goto label_1000_B16E_1B16E;
    }
    CheckExternalEvents(cs8, 0xB16E);
    // CALL 0x1000:b1f3 (1000_B16B / 0x1B16B)
    NearCall(cs8, 0xB16E, unknown_19EF_1303_1B1F3);
    label_1000_B16E_1B16E:
    CheckExternalEvents(cs8, 0xB170);
    // MOV byte ptr [DI],BL (1000_B16E / 0x1B16E)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs8, 0xB171);
    // INC SI (1000_B170 / 0x1B170)
    SI++;
    CheckExternalEvents(cs8, 0xB172);
    // INC DI (1000_B171 / 0x1B171)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs8, 0xB175);
    // MOV CX,0x6 (1000_B172 / 0x1B172)
    CX = 0x6;
    label_1000_B175_1B175:
    CheckExternalEvents(cs8, 0xB177);
    // XOR BL,BL (1000_B175 / 0x1B175)
    // BL ^= BL;
    BL = Alu8.Xor(BL, BL);
    CheckExternalEvents(cs8, 0xB179);
    // MOV AL,byte ptr [SI] (1000_B177 / 0x1B177)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xB17B);
    // OR AL,AL (1000_B179 / 0x1B179)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs8, 0xB17D);
    // JNS 0x1000:b184 (1000_B17B / 0x1B17B)
    if(!SignFlag) {
      goto label_1000_B184_1B184;
    }
    CheckExternalEvents(cs8, 0xB17F);
    // MOV BL,AL (1000_B17D / 0x1B17D)
    BL = AL;
    CheckExternalEvents(cs8, 0xB182);
    // SUB BL,0x80 (1000_B17F / 0x1B17F)
    // BL -= 0x80;
    BL = Alu8.Sub(BL, 0x80);
    CheckExternalEvents(cs8, 0xB184);
    // JNZ 0x1000:b197 (1000_B182 / 0x1B182)
    if(!ZeroFlag) {
      goto label_1000_B197_1B197;
    }
    label_1000_B184_1B184:
    CheckExternalEvents(cs8, 0xB187);
    // CMP AL,byte ptr [SI + -0x1] (1000_B184 / 0x1B184)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI - 0x1)]);
    CheckExternalEvents(cs8, 0xB189);
    // JNZ 0x1000:b18c (1000_B187 / 0x1B187)
    if(!ZeroFlag) {
      goto label_1000_B18C_1B18C;
    }
    CheckExternalEvents(cs8, 0xB18C);
    // OR BL,0x8 (1000_B189 / 0x1B189)
    BL |= 0x8;
    label_1000_B18C_1B18C:
    CheckExternalEvents(cs8, 0xB18F);
    // CMP AL,byte ptr [SI + 0x1] (1000_B18C / 0x1B18C)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI + 0x1)]);
    CheckExternalEvents(cs8, 0xB191);
    // JNZ 0x1000:b194 (1000_B18F / 0x1B18F)
    if(!ZeroFlag) {
      goto label_1000_B194_1B194;
    }
    CheckExternalEvents(cs8, 0xB194);
    // OR BL,0x2 (1000_B191 / 0x1B191)
    // BL |= 0x2;
    BL = Alu8.Or(BL, 0x2);
    label_1000_B194_1B194:
    CheckExternalEvents(cs8, 0xB197);
    // CALL 0x1000:b1f3 (1000_B194 / 0x1B194)
    NearCall(cs8, 0xB197, unknown_19EF_1303_1B1F3);
    label_1000_B197_1B197:
    CheckExternalEvents(cs8, 0xB199);
    // MOV byte ptr [DI],BL (1000_B197 / 0x1B197)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs8, 0xB19A);
    // INC SI (1000_B199 / 0x1B199)
    SI++;
    CheckExternalEvents(cs8, 0xB19B);
    // INC DI (1000_B19A / 0x1B19A)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs8, 0xB19D);
    // LOOP 0x1000:b175 (1000_B19B / 0x1B19B)
    if(--CX != 0) {
      goto label_1000_B175_1B175;
    }
    CheckExternalEvents(cs8, 0xB1A0);
    // CALL 0x1000:b1c9 (1000_B19D / 0x1B19D)
    NearCall(cs8, 0xB1A0, unknown_19EF_12D9_1B1C9);
    CheckExternalEvents(cs8, 0xB1A2);
    // OR AL,AL (1000_B1A0 / 0x1B1A0)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs8, 0xB1A4);
    // JS 0x1000:b1a7 (1000_B1A2 / 0x1B1A2)
    if(SignFlag) {
      goto label_1000_B1A7_1B1A7;
    }
    CheckExternalEvents(cs8, 0xB1A7);
    // CALL 0x1000:b1f3 (1000_B1A4 / 0x1B1A4)
    NearCall(cs8, 0xB1A7, unknown_19EF_1303_1B1F3);
    label_1000_B1A7_1B1A7:
    CheckExternalEvents(cs8, 0xB1A9);
    // MOV byte ptr [DI],BL (1000_B1A7 / 0x1B1A7)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs8, 0xB1AA);
    // RET  (1000_B1A9 / 0x1B1A9)
    return NearRet();
  }
  
}
