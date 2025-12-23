namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action split_1000_B3E0_1B3E0(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1B42A: goto label_19EF_153A_1B42A;break; // Target of external jump from 0x1B356
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_B3E0_1B3E0:
    CheckExternalEvents(cs7, 0xB3E5);
    // CMP byte ptr [0x273],0x3 (1000_B3E0 / 0x1B3E0)
    Alu8.Sub(UInt8[DS, 0x273], 0x3);
    CheckExternalEvents(cs7, 0xB3E7);
    // JNZ 0x1000:b42a (1000_B3E5 / 0x1B3E5)
    if(!ZeroFlag) {
      goto label_1000_B42A_1B42A;
    }
    CheckExternalEvents(cs7, 0xB3E8);
    // PUSH DI (1000_B3E7 / 0x1B3E7)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xB3E9);
    // PUSH BX (1000_B3E8 / 0x1B3E8)
    Stack.Push16(BX);
    CheckExternalEvents(cs7, 0xB3EC);
    // MOV DI,0x20dd (1000_B3E9 / 0x1B3E9)
    DI = 0x20DD;
    CheckExternalEvents(cs7, 0xB3EF);
    // ADD DI,0x3f (1000_B3EC / 0x1B3EC)
    DI += 0x3F;
    CheckExternalEvents(cs7, 0xB3F1);
    // XOR BH,BH (1000_B3EF / 0x1B3EF)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    CheckExternalEvents(cs7, 0xB3F3);
    // MOV BL,CH (1000_B3F1 / 0x1B3F1)
    BL = CH;
    CheckExternalEvents(cs7, 0xB3F7);
    // MOV BL,byte ptr [BX + 0x213d] (1000_B3F3 / 0x1B3F3)
    BL = UInt8[DS, (ushort)(BX + 0x213D)];
    CheckExternalEvents(cs7, 0xB3FB);
    // MOV CH,byte ptr [BX + 0x211d] (1000_B3F7 / 0x1B3F7)
    CH = UInt8[DS, (ushort)(BX + 0x211D)];
    CheckExternalEvents(cs7, 0xB3FD);
    // XOR CL,CL (1000_B3FB / 0x1B3FB)
    CL = 0;
    CheckExternalEvents(cs7, 0xB3FF);
    // SHR CX,0x1 (1000_B3FD / 0x1B3FD)
    CX >>= 0x1;
    CheckExternalEvents(cs7, 0xB401);
    // SHR CX,0x1 (1000_B3FF / 0x1B3FF)
    CX >>= 0x1;
    CheckExternalEvents(cs7, 0xB403);
    // ADD SI,CX (1000_B401 / 0x1B401)
    // SI += CX;
    SI = Alu16.Add(SI, CX);
    CheckExternalEvents(cs7, 0xB405);
    // MOV AL,0x8 (1000_B403 / 0x1B403)
    AL = 0x8;
    label_1000_B405_1B405:
    CheckExternalEvents(cs7, 0xB408);
    // MOV CX,0x8 (1000_B405 / 0x1B405)
    CX = 0x8;
    CheckExternalEvents(cs7, 0xB40A);
    // XOR BH,BH (1000_B408 / 0x1B408)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    label_1000_B40A_1B40A:
    CheckExternalEvents(cs7, 0xB40C);
    // MOV BL,byte ptr [SI] (1000_B40A / 0x1B40A)
    BL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xB40F);
    // CMP BL,0x40 (1000_B40C / 0x1B40C)
    Alu8.Sub(BL, 0x40);
    CheckExternalEvents(cs7, 0xB411);
    // JNC 0x1000:b419 (1000_B40F / 0x1B40F)
    if(!CarryFlag) {
      goto label_1000_B419_1B419;
    }
    CheckExternalEvents(cs7, 0xB415);
    // MOV BL,byte ptr [BX + 0x213d] (1000_B411 / 0x1B411)
    BL = UInt8[DS, (ushort)(BX + 0x213D)];
    CheckExternalEvents(cs7, 0xB419);
    // MOV BL,byte ptr [BX + 0x211d] (1000_B415 / 0x1B415)
    BL = UInt8[DS, (ushort)(BX + 0x211D)];
    label_1000_B419_1B419:
    CheckExternalEvents(cs7, 0xB41B);
    // MOV byte ptr [DI],BL (1000_B419 / 0x1B419)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs7, 0xB41C);
    // INC SI (1000_B41B / 0x1B41B)
    SI++;
    CheckExternalEvents(cs7, 0xB41D);
    // DEC DI (1000_B41C / 0x1B41C)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs7, 0xB41F);
    // LOOP 0x1000:b40a (1000_B41D / 0x1B41D)
    if(--CX != 0) {
      goto label_1000_B40A_1B40A;
    }
    CheckExternalEvents(cs7, 0xB421);
    // DEC AL (1000_B41F / 0x1B41F)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs7, 0xB423);
    // JNZ 0x1000:b405 (1000_B421 / 0x1B421)
    if(!ZeroFlag) {
      goto label_1000_B405_1B405;
    }
    label_1000_B423_1B423:
    CheckExternalEvents(cs7, 0xB426);
    // MOV SI,0x20dd (1000_B423 / 0x1B423)
    SI = 0x20DD;
    CheckExternalEvents(cs7, 0xB427);
    // POP BX (1000_B426 / 0x1B426)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB428);
    // POP DI (1000_B427 / 0x1B427)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB42A);
    // XOR DX,DX (1000_B428 / 0x1B428)
    DX = 0;
    label_1000_B42A_1B42A:
    CheckExternalEvents(cs7, 0xB42C);
    // ADD SI,DX (1000_B42A / 0x1B42A)
    // SI += DX;
    SI = Alu16.Add(SI, DX);
    CheckExternalEvents(cs7, 0xB42D);
    // PUSH ES (1000_B42C / 0x1B42C)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xB42F);
    // MOV AX,DS (1000_B42D / 0x1B42D)
    AX = DS;
    CheckExternalEvents(cs7, 0xB431);
    // MOV ES,AX (1000_B42F / 0x1B42F)
    ES = AX;
    CheckExternalEvents(cs7, 0xB433);
    // MOV BH,BL (1000_B431 / 0x1B431)
    BH = BL;
    CheckExternalEvents(cs7, 0xB434);
    // CLD  (1000_B433 / 0x1B433)
    DirectionFlag = false;
    CheckExternalEvents(cs7, 0xB437);
    // MOV DX,0x8 (1000_B434 / 0x1B434)
    DX = 0x8;
    CheckExternalEvents(cs7, 0xB43A);
    // MOV CX,0x4 (1000_B437 / 0x1B437)
    CX = 0x4;
    CheckExternalEvents(cs7, 0xB43C);
    // OR BL,BL (1000_B43A / 0x1B43A)
    // BL |= BL;
    BL = Alu8.Or(BL, BL);
    CheckExternalEvents(cs7, 0xB43E);
    // JS 0x1000:b446 (1000_B43C / 0x1B43C)
    if(SignFlag) {
      goto label_1000_B446_1B446;
    }
    CheckExternalEvents(cs7, 0xB441);
    // CMP BL,0x70 (1000_B43E / 0x1B43E)
    Alu8.Sub(BL, 0x70);
    CheckExternalEvents(cs7, 0xB443);
    // JNZ 0x1000:b455 (1000_B441 / 0x1B441)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_B455_1B455, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xB446);
    // MOV SI,0x209d (1000_B443 / 0x1B443)
    SI = 0x209D;
    label_1000_B446_1B446:
    CheckExternalEvents(cs7, 0xB448);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_B446 / 0x1B446)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs7, 0xB44B);
    // ADD DI,0x10 (1000_B448 / 0x1B448)
    // DI += 0x10;
    DI = Alu16.Add(DI, 0x10);
    CheckExternalEvents(cs7, 0xB44E);
    // MOV CX,0x4 (1000_B44B / 0x1B44B)
    CX = 0x4;
    CheckExternalEvents(cs7, 0xB450);
    // DEC DL (1000_B44E / 0x1B44E)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs7, 0xB452);
    // JNZ 0x1000:b446 (1000_B450 / 0x1B450)
    if(!ZeroFlag) {
      goto label_1000_B446_1B446;
    }
    CheckExternalEvents(cs7, 0xB454);
    // JMP 0x1000:b46f (1000_B452 / 0x1B452)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_B455_1B455, 0x1B46F - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_B455_1B455(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1B46F: goto label_19EF_157F_1B46F;break; // Target of external jump from 0x1B452
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_B455_1B455:
    CheckExternalEvents(cs7, 0xB459);
    // MOV AH,byte ptr [0x272] (1000_B455 / 0x1B455)
    AH = UInt8[DS, 0x272];
    CheckExternalEvents(cs7, 0xB45C);
    // MOV CX,0x8 (1000_B459 / 0x1B459)
    CX = 0x8;
    label_1000_B45C_1B45C:
    CheckExternalEvents(cs7, 0xB45D);
    // LODSB SI (1000_B45C / 0x1B45C)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xB45F);
    // CMP AL,0x40 (1000_B45D / 0x1B45D)
    Alu8.Sub(AL, 0x40);
    CheckExternalEvents(cs7, 0xB461);
    // JNC 0x1000:b465 (1000_B45F / 0x1B45F)
    if(!CarryFlag) {
      goto label_1000_B465_1B465;
    }
    CheckExternalEvents(cs7, 0xB463);
    // AND AL,0xf (1000_B461 / 0x1B461)
    AL &= 0xF;
    CheckExternalEvents(cs7, 0xB465);
    // ADD AL,BL (1000_B463 / 0x1B463)
    // AL += BL;
    AL = Alu8.Add(AL, BL);
    label_1000_B465_1B465:
    CheckExternalEvents(cs7, 0xB466);
    // STOSB ES:DI (1000_B465 / 0x1B465)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xB468);
    // LOOP 0x1000:b45c (1000_B466 / 0x1B466)
    if(--CX != 0) {
      goto label_1000_B45C_1B45C;
    }
    CheckExternalEvents(cs7, 0xB46B);
    // ADD DI,0x10 (1000_B468 / 0x1B468)
    DI += 0x10;
    CheckExternalEvents(cs7, 0xB46D);
    // DEC DL (1000_B46B / 0x1B46B)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs7, 0xB46F);
    // JNZ 0x1000:b455 (1000_B46D / 0x1B46D)
    if(!ZeroFlag) {
      goto label_1000_B455_1B455;
    }
    label_1000_B46F_1B46F:
    CheckExternalEvents(cs7, 0xB473);
    // SUB DI,0xb8 (1000_B46F / 0x1B46F)
    // DI -= 0xB8;
    DI = Alu16.Sub(DI, 0xB8);
    CheckExternalEvents(cs7, 0xB474);
    // POP ES (1000_B473 / 0x1B473)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB477);
    // MOV AL,[0x2c9] (1000_B474 / 0x1B474)
    AL = UInt8[DS, 0x2C9];
    CheckExternalEvents(cs7, 0xB47B);
    // OR AL,byte ptr [0x2ca] (1000_B477 / 0x1B477)
    // AL |= UInt8[DS, 0x2CA];
    AL = Alu8.Or(AL, UInt8[DS, 0x2CA]);
    CheckExternalEvents(cs7, 0xB47C);
    // RET  (1000_B47B / 0x1B47B)
    return NearRet();
  }
  
  public virtual Action ghidra_guess_1000_B47C_1B47C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_B47C_1B47C:
    CheckExternalEvents(cs7, 0xB47D);
    // PUSH BP (1000_B47C / 0x1B47C)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xB47F);
    // MOV BP,SP (1000_B47D / 0x1B47D)
    BP = SP;
    CheckExternalEvents(cs7, 0xB480);
    // PUSH DI (1000_B47F / 0x1B47F)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xB481);
    // PUSH SI (1000_B480 / 0x1B480)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xB482);
    // PUSH DS (1000_B481 / 0x1B481)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xB485);
    // MOV AX,0x1ddc (1000_B482 / 0x1B482)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xB487);
    // MOV DS,AX (1000_B485 / 0x1B485)
    DS = AX;
    CheckExternalEvents(cs7, 0xB48A);
    // MOV AX,[0xa44d] (1000_B487 / 0x1B487)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs7, 0xB48C);
    // DEC AL (1000_B48A / 0x1B48A)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs7, 0xB48E);
    // JS 0x1000:b494 (1000_B48C / 0x1B48C)
    if(SignFlag) {
      goto label_1000_B494_1B494;
    }
    CheckExternalEvents(cs7, 0xB491);
    // MOV [0xa44d],AX (1000_B48E / 0x1B48E)
    UInt16[DS, 0xA44D] = AX;
    label_1000_B491_1B491:
    CheckExternalEvents(cs7, 0xB494);
    // JMP 0x1000:b526 (1000_B491 / 0x1B491)
    goto label_1000_B526_1B526;
    label_1000_B494_1B494:
    CheckExternalEvents(cs7, 0xB497);
    // CMP AH,0x0 (1000_B494 / 0x1B494)
    Alu8.Sub(AH, 0x0);
    CheckExternalEvents(cs7, 0xB499);
    // JZ 0x1000:b491 (1000_B497 / 0x1B497)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs7, 0xB494);
      // JMP 0x1000:b526 (1000_B491 / 0x1B491)
      goto label_1000_B526_1B526;
    }
    CheckExternalEvents(cs7, 0xB49C);
    // SUB AH,0x10 (1000_B499 / 0x1B499)
    // AH -= 0x10;
    AH = Alu8.Sub(AH, 0x10);
    CheckExternalEvents(cs7, 0xB49E);
    // MOV AL,0x7f (1000_B49C / 0x1B49C)
    AL = 0x7F;
    CheckExternalEvents(cs7, 0xB4A1);
    // MOV [0xa44d],AX (1000_B49E / 0x1B49E)
    UInt16[DS, 0xA44D] = AX;
    CheckExternalEvents(cs7, 0xB4A2);
    // PUSH ES (1000_B4A1 / 0x1B4A1)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xB4A4);
    // MOV AX,DS (1000_B4A2 / 0x1B4A2)
    AX = DS;
    CheckExternalEvents(cs7, 0xB4A6);
    // MOV ES,AX (1000_B4A4 / 0x1B4A4)
    ES = AX;
    CheckExternalEvents(cs7, 0xB4A9);
    // MOV SI,0x6e4 (1000_B4A6 / 0x1B4A6)
    SI = 0x6E4;
    CheckExternalEvents(cs7, 0xB4AC);
    // SUB SI,0x2 (1000_B4A9 / 0x1B4A9)
    // SI -= 0x2;
    SI = Alu16.Sub(SI, 0x2);
    CheckExternalEvents(cs7, 0xB4AF);
    // MOV DI,0x764 (1000_B4AC / 0x1B4AC)
    DI = 0x764;
    CheckExternalEvents(cs7, 0xB4B2);
    // ADD DI,0x3e (1000_B4AF / 0x1B4AF)
    // DI += 0x3E;
    DI = Alu16.Add(DI, 0x3E);
    CheckExternalEvents(cs7, 0xB4B5);
    // MOV CX,0xc0 (1000_B4B2 / 0x1B4B2)
    CX = 0xC0;
    CheckExternalEvents(cs7, 0xB4B6);
    // STD  (1000_B4B5 / 0x1B4B5)
    DirectionFlag = true;
    CheckExternalEvents(cs7, 0xB4B8);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_B4B6 / 0x1B4B6)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs7, 0xB4B9);
    // CLD  (1000_B4B8 / 0x1B4B8)
    DirectionFlag = false;
    CheckExternalEvents(cs7, 0xB4BA);
    // POP ES (1000_B4B9 / 0x1B4B9)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB4BD);
    // MOV DI,0x2d3 (1000_B4BA / 0x1B4BA)
    DI = 0x2D3;
    CheckExternalEvents(cs7, 0xB4C0);
    // MOV AX,[0xa44d] (1000_B4BD / 0x1B4BD)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs7, 0xB4C4);
    // MOV BX,word ptr [0xa44b] (1000_B4C0 / 0x1B4C0)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs7, 0xB4C6);
    // OR AH,BH (1000_B4C4 / 0x1B4C4)
    // AH |= BH;
    AH = Alu8.Or(AH, BH);
    CheckExternalEvents(cs7, 0xB4C8);
    // MOV AL,AH (1000_B4C6 / 0x1B4C6)
    AL = AH;
    CheckExternalEvents(cs7, 0xB4CA);
    // XOR AH,AH (1000_B4C8 / 0x1B4C8)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs7, 0xB4CC);
    // MOV SI,AX (1000_B4CA / 0x1B4CA)
    SI = AX;
    CheckExternalEvents(cs7, 0xB4D0);
    // ADD SI,0xb0b (1000_B4CC / 0x1B4CC)
    SI += 0xB0B;
    CheckExternalEvents(cs7, 0xB4D3);
    // SUB SI,0x11 (1000_B4D0 / 0x1B4D0)
    // SI -= 0x11;
    SI = Alu16.Sub(SI, 0x11);
    CheckExternalEvents(cs7, 0xB4D6);
    // CALL 0x1000:b7c8 (1000_B4D3 / 0x1B4D3)
    NearCall(cs7, 0xB4D6, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs7, 0xB4D7);
    // PUSH SI (1000_B4D6 / 0x1B4D6)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xB4DA);
    // MOV SI,0x564 (1000_B4D7 / 0x1B4D7)
    SI = 0x564;
    CheckExternalEvents(cs7, 0xB4DD);
    // CALL 0x1000:aaeb (1000_B4DA / 0x1B4DA)
    NearCall(cs7, 0xB4DD, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs7, 0xB4DE);
    // POP SI (1000_B4DD / 0x1B4DD)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB4DF);
    // INC SI (1000_B4DE / 0x1B4DE)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs7, 0xB4E2);
    // MOV DI,0x2d3 (1000_B4DF / 0x1B4DF)
    DI = 0x2D3;
    CheckExternalEvents(cs7, 0xB4E5);
    // CALL 0x1000:b7c8 (1000_B4E2 / 0x1B4E2)
    NearCall(cs7, 0xB4E5, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs7, 0xB4E6);
    // PUSH SI (1000_B4E5 / 0x1B4E5)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xB4E9);
    // MOV SI,0x5a4 (1000_B4E6 / 0x1B4E6)
    SI = 0x5A4;
    CheckExternalEvents(cs7, 0xB4EC);
    // CALL 0x1000:aaeb (1000_B4E9 / 0x1B4E9)
    NearCall(cs7, 0xB4EC, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs7, 0xB4ED);
    // POP SI (1000_B4EC / 0x1B4EC)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB4EE);
    // INC SI (1000_B4ED / 0x1B4ED)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs7, 0xB4F1);
    // MOV DI,0x2d3 (1000_B4EE / 0x1B4EE)
    DI = 0x2D3;
    CheckExternalEvents(cs7, 0xB4F4);
    // CALL 0x1000:b7c8 (1000_B4F1 / 0x1B4F1)
    NearCall(cs7, 0xB4F4, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs7, 0xB4F7);
    // MOV SI,0x5e4 (1000_B4F4 / 0x1B4F4)
    SI = 0x5E4;
    CheckExternalEvents(cs7, 0xB4FA);
    // CALL 0x1000:aaeb (1000_B4F7 / 0x1B4F7)
    NearCall(cs7, 0xB4FA, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs7, 0xB4FD);
    // CALL 0x1000:b776 (1000_B4FA / 0x1B4FA)
    NearCall(cs7, 0xB4FD, unknown_19EF_1886_1B776);
    CheckExternalEvents(cs7, 0xB500);
    // MOV SI,0x9f3 (1000_B4FD / 0x1B4FD)
    SI = 0x9F3;
    CheckExternalEvents(cs7, 0xB503);
    // MOV AX,0x100 (1000_B500 / 0x1B500)
    AX = 0x100;
    CheckExternalEvents(cs7, 0xB505);
    // MOV word ptr [SI],AX (1000_B503 / 0x1B503)
    UInt16[DS, (ushort)(SI)] = AX;
    CheckExternalEvents(cs7, 0xB508);
    // ADD SI,0x2 (1000_B505 / 0x1B505)
    SI += 0x2;
    CheckExternalEvents(cs7, 0xB50A);
    // INC AH (1000_B508 / 0x1B508)
    AH = Alu8.Inc(AH);
    CheckExternalEvents(cs7, 0xB50C);
    // MOV byte ptr [SI],AH (1000_B50A / 0x1B50A)
    UInt8[DS, (ushort)(SI)] = AH;
    CheckExternalEvents(cs7, 0xB50D);
    // INC SI (1000_B50C / 0x1B50C)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs7, 0xB510);
    // MOV AX,[0xa44d] (1000_B50D / 0x1B50D)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs7, 0xB514);
    // OR AX,word ptr [0xa44b] (1000_B510 / 0x1B510)
    // AX |= UInt16[DS, 0xA44B];
    AX = Alu16.Or(AX, UInt16[DS, 0xA44B]);
    CheckExternalEvents(cs7, 0xB516);
    // MOV AL,AH (1000_B514 / 0x1B514)
    AL = AH;
    CheckExternalEvents(cs7, 0xB518);
    // XOR AH,AH (1000_B516 / 0x1B516)
    AH = 0;
    CheckExternalEvents(cs7, 0xB51A);
    // SUB AL,0x11 (1000_B518 / 0x1B518)
    // AL -= 0x11;
    AL = Alu8.Sub(AL, 0x11);
    CheckExternalEvents(cs7, 0xB51C);
    // MOV byte ptr [SI],AL (1000_B51A / 0x1B51A)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs7, 0xB51D);
    // INC SI (1000_B51C / 0x1B51C)
    SI++;
    CheckExternalEvents(cs7, 0xB51F);
    // INC AL (1000_B51D / 0x1B51D)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs7, 0xB521);
    // MOV byte ptr [SI],AL (1000_B51F / 0x1B51F)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs7, 0xB522);
    // INC SI (1000_B521 / 0x1B521)
    SI++;
    CheckExternalEvents(cs7, 0xB524);
    // INC AL (1000_B522 / 0x1B522)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs7, 0xB526);
    // MOV byte ptr [SI],AL (1000_B524 / 0x1B524)
    UInt8[DS, (ushort)(SI)] = AL;
    label_1000_B526_1B526:
    CheckExternalEvents(cs7, 0xB527);
    // POP DS (1000_B526 / 0x1B526)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB528);
    // POP SI (1000_B527 / 0x1B527)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB529);
    // POP DI (1000_B528 / 0x1B528)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB52A);
    // POP BP (1000_B529 / 0x1B529)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB52B);
    // RETF  (1000_B52A / 0x1B52A)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_163B_1B52B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_163B_1B52B:
    CheckExternalEvents(cs12, 0x163C);
    // PUSH BP (19EF_163B / 0x1B52B)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x163E);
    // MOV BP,SP (19EF_163C / 0x1B52C)
    BP = SP;
    CheckExternalEvents(cs12, 0x163F);
    // PUSH DI (19EF_163E / 0x1B52E)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1640);
    // PUSH SI (19EF_163F / 0x1B52F)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1641);
    // PUSH DS (19EF_1640 / 0x1B530)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1644);
    // MOV AX,0x1ddc (19EF_1641 / 0x1B531)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x1646);
    // MOV DS,AX (19EF_1644 / 0x1B534)
    DS = AX;
    CheckExternalEvents(cs12, 0x1649);
    // MOV AX,[0xa44d] (19EF_1646 / 0x1B536)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs12, 0x164B);
    // INC AL (19EF_1649 / 0x1B539)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs12, 0x164D);
    // JS 0x1000:b543 (19EF_164B / 0x1B53B)
    if(SignFlag) {
      goto label_19EF_1653_1B543;
    }
    CheckExternalEvents(cs12, 0x1650);
    // MOV [0xa44d],AX (19EF_164D / 0x1B53D)
    UInt16[DS, 0xA44D] = AX;
    label_19EF_1650_1B540:
    CheckExternalEvents(cs12, 0x1653);
    // JMP 0x1000:b5ce (19EF_1650 / 0x1B540)
    goto label_19EF_16DE_1B5CE;
    label_19EF_1653_1B543:
    CheckExternalEvents(cs12, 0x1656);
    // CMP AH,0xf0 (19EF_1653 / 0x1B543)
    Alu8.Sub(AH, 0xF0);
    CheckExternalEvents(cs12, 0x1658);
    // JZ 0x1000:b540 (19EF_1656 / 0x1B546)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs12, 0x1653);
      // JMP 0x1000:b5ce (19EF_1650 / 0x1B540)
      goto label_19EF_16DE_1B5CE;
    }
    CheckExternalEvents(cs12, 0x165B);
    // ADD AH,0x10 (19EF_1658 / 0x1B548)
    AH += 0x10;
    CheckExternalEvents(cs12, 0x165D);
    // XOR AL,AL (19EF_165B / 0x1B54B)
    // AL ^= AL;
    AL = Alu8.Xor(AL, AL);
    CheckExternalEvents(cs12, 0x1660);
    // MOV [0xa44d],AX (19EF_165D / 0x1B54D)
    UInt16[DS, 0xA44D] = AX;
    CheckExternalEvents(cs12, 0x1661);
    // PUSH ES (19EF_1660 / 0x1B550)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x1663);
    // MOV AX,DS (19EF_1661 / 0x1B551)
    AX = DS;
    CheckExternalEvents(cs12, 0x1665);
    // MOV ES,AX (19EF_1663 / 0x1B553)
    ES = AX;
    CheckExternalEvents(cs12, 0x1668);
    // MOV SI,0x624 (19EF_1665 / 0x1B555)
    SI = 0x624;
    CheckExternalEvents(cs12, 0x166B);
    // MOV DI,0x564 (19EF_1668 / 0x1B558)
    DI = 0x564;
    CheckExternalEvents(cs12, 0x166E);
    // MOV CX,0xc0 (19EF_166B / 0x1B55B)
    CX = 0xC0;
    CheckExternalEvents(cs12, 0x166F);
    // CLD  (19EF_166E / 0x1B55E)
    DirectionFlag = false;
    CheckExternalEvents(cs12, 0x1671);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_166F / 0x1B55F)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x1672);
    // POP ES (19EF_1671 / 0x1B561)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1675);
    // MOV DI,0x2d3 (19EF_1672 / 0x1B562)
    DI = 0x2D3;
    CheckExternalEvents(cs12, 0x1678);
    // MOV AX,[0xa44d] (19EF_1675 / 0x1B565)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs12, 0x167C);
    // MOV BX,word ptr [0xa44b] (19EF_1678 / 0x1B568)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs12, 0x167E);
    // OR AH,BH (19EF_167C / 0x1B56C)
    // AH |= BH;
    AH = Alu8.Or(AH, BH);
    CheckExternalEvents(cs12, 0x1680);
    // MOV AL,AH (19EF_167E / 0x1B56E)
    AL = AH;
    CheckExternalEvents(cs12, 0x1682);
    // XOR AH,AH (19EF_1680 / 0x1B570)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs12, 0x1684);
    // MOV SI,AX (19EF_1682 / 0x1B572)
    SI = AX;
    CheckExternalEvents(cs12, 0x1688);
    // ADD SI,0xb0b (19EF_1684 / 0x1B574)
    SI += 0xB0B;
    CheckExternalEvents(cs12, 0x168B);
    // ADD SI,0xf (19EF_1688 / 0x1B578)
    // SI += 0xF;
    SI = Alu16.Add(SI, 0xF);
    CheckExternalEvents(cs12, 0x168E);
    // CALL 0x1000:b7c8 (19EF_168B / 0x1B57B)
    NearCall(cs12, 0x168E, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs12, 0x168F);
    // PUSH SI (19EF_168E / 0x1B57E)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1692);
    // MOV SI,0x6e4 (19EF_168F / 0x1B57F)
    SI = 0x6E4;
    CheckExternalEvents(cs12, 0x1695);
    // CALL 0x1000:aaeb (19EF_1692 / 0x1B582)
    NearCall(cs12, 0x1695, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs12, 0x1696);
    // POP SI (19EF_1695 / 0x1B585)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1697);
    // INC SI (19EF_1696 / 0x1B586)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs12, 0x169A);
    // MOV DI,0x2d3 (19EF_1697 / 0x1B587)
    DI = 0x2D3;
    CheckExternalEvents(cs12, 0x169D);
    // CALL 0x1000:b7c8 (19EF_169A / 0x1B58A)
    NearCall(cs12, 0x169D, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs12, 0x169E);
    // PUSH SI (19EF_169D / 0x1B58D)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x16A1);
    // MOV SI,0x724 (19EF_169E / 0x1B58E)
    SI = 0x724;
    CheckExternalEvents(cs12, 0x16A4);
    // CALL 0x1000:aaeb (19EF_16A1 / 0x1B591)
    NearCall(cs12, 0x16A4, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs12, 0x16A5);
    // POP SI (19EF_16A4 / 0x1B594)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x16A6);
    // INC SI (19EF_16A5 / 0x1B595)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs12, 0x16A9);
    // MOV DI,0x2d3 (19EF_16A6 / 0x1B596)
    DI = 0x2D3;
    CheckExternalEvents(cs12, 0x16AC);
    // CALL 0x1000:b7c8 (19EF_16A9 / 0x1B599)
    NearCall(cs12, 0x16AC, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs12, 0x16AF);
    // MOV SI,0x764 (19EF_16AC / 0x1B59C)
    SI = 0x764;
    CheckExternalEvents(cs12, 0x16B2);
    // CALL 0x1000:aaeb (19EF_16AF / 0x1B59F)
    NearCall(cs12, 0x16B2, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs12, 0x16B5);
    // CALL 0x1000:b776 (19EF_16B2 / 0x1B5A2)
    NearCall(cs12, 0x16B5, unknown_19EF_1886_1B776);
    CheckExternalEvents(cs12, 0x16B8);
    // MOV SI,0x9f3 (19EF_16B5 / 0x1B5A5)
    SI = 0x9F3;
    CheckExternalEvents(cs12, 0x16BB);
    // MOV AX,0x706 (19EF_16B8 / 0x1B5A8)
    AX = 0x706;
    CheckExternalEvents(cs12, 0x16BD);
    // MOV word ptr [SI],AX (19EF_16BB / 0x1B5AB)
    UInt16[DS, (ushort)(SI)] = AX;
    CheckExternalEvents(cs12, 0x16C0);
    // ADD SI,0x2 (19EF_16BD / 0x1B5AD)
    SI += 0x2;
    CheckExternalEvents(cs12, 0x16C2);
    // INC AH (19EF_16C0 / 0x1B5B0)
    AH = Alu8.Inc(AH);
    CheckExternalEvents(cs12, 0x16C4);
    // MOV byte ptr [SI],AH (19EF_16C2 / 0x1B5B2)
    UInt8[DS, (ushort)(SI)] = AH;
    CheckExternalEvents(cs12, 0x16C5);
    // INC SI (19EF_16C4 / 0x1B5B4)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs12, 0x16C8);
    // MOV AX,[0xa44d] (19EF_16C5 / 0x1B5B5)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs12, 0x16CC);
    // OR AX,word ptr [0xa44b] (19EF_16C8 / 0x1B5B8)
    // AX |= UInt16[DS, 0xA44B];
    AX = Alu16.Or(AX, UInt16[DS, 0xA44B]);
    CheckExternalEvents(cs12, 0x16CE);
    // MOV AL,AH (19EF_16CC / 0x1B5BC)
    AL = AH;
    CheckExternalEvents(cs12, 0x16D0);
    // XOR AH,AH (19EF_16CE / 0x1B5BE)
    AH = 0;
    CheckExternalEvents(cs12, 0x16D2);
    // ADD AL,0xf (19EF_16D0 / 0x1B5C0)
    // AL += 0xF;
    AL = Alu8.Add(AL, 0xF);
    CheckExternalEvents(cs12, 0x16D4);
    // MOV byte ptr [SI],AL (19EF_16D2 / 0x1B5C2)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs12, 0x16D5);
    // INC SI (19EF_16D4 / 0x1B5C4)
    SI++;
    CheckExternalEvents(cs12, 0x16D7);
    // INC AL (19EF_16D5 / 0x1B5C5)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs12, 0x16D9);
    // MOV byte ptr [SI],AL (19EF_16D7 / 0x1B5C7)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs12, 0x16DA);
    // INC SI (19EF_16D9 / 0x1B5C9)
    SI++;
    CheckExternalEvents(cs12, 0x16DC);
    // INC AL (19EF_16DA / 0x1B5CA)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs12, 0x16DE);
    // MOV byte ptr [SI],AL (19EF_16DC / 0x1B5CC)
    UInt8[DS, (ushort)(SI)] = AL;
    label_19EF_16DE_1B5CE:
    CheckExternalEvents(cs12, 0x16DF);
    // POP DS (19EF_16DE / 0x1B5CE)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x16E0);
    // POP SI (19EF_16DF / 0x1B5CF)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x16E1);
    // POP DI (19EF_16E0 / 0x1B5D0)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x16E2);
    // POP BP (19EF_16E1 / 0x1B5D1)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x16E3);
    // RETF  (19EF_16E2 / 0x1B5D2)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_16E3_1B5D3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_16E3_1B5D3:
    CheckExternalEvents(cs12, 0x16E4);
    // PUSH BP (19EF_16E3 / 0x1B5D3)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x16E6);
    // MOV BP,SP (19EF_16E4 / 0x1B5D4)
    BP = SP;
    CheckExternalEvents(cs12, 0x16E7);
    // PUSH DI (19EF_16E6 / 0x1B5D6)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x16E8);
    // PUSH SI (19EF_16E7 / 0x1B5D7)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x16E9);
    // PUSH DS (19EF_16E8 / 0x1B5D8)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x16EC);
    // MOV AX,0x1ddc (19EF_16E9 / 0x1B5D9)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x16EE);
    // MOV DS,AX (19EF_16EC / 0x1B5DC)
    DS = AX;
    CheckExternalEvents(cs12, 0x16F1);
    // MOV AX,[0xa44b] (19EF_16EE / 0x1B5DE)
    AX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs12, 0x16F3);
    // DEC AL (19EF_16F1 / 0x1B5E1)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs12, 0x16F5);
    // JS 0x1000:b5eb (19EF_16F3 / 0x1B5E3)
    if(SignFlag) {
      goto label_19EF_16FB_1B5EB;
    }
    CheckExternalEvents(cs12, 0x16F8);
    // MOV [0xa44b],AX (19EF_16F5 / 0x1B5E5)
    UInt16[DS, 0xA44B] = AX;
    label_19EF_16F8_1B5E8:
    CheckExternalEvents(cs12, 0x16FB);
    // JMP 0x1000:b6b0 (19EF_16F8 / 0x1B5E8)
    goto label_19EF_17C0_1B6B0;
    label_19EF_16FB_1B5EB:
    CheckExternalEvents(cs12, 0x16FE);
    // CMP AH,0x0 (19EF_16FB / 0x1B5EB)
    Alu8.Sub(AH, 0x0);
    CheckExternalEvents(cs12, 0x1700);
    // JZ 0x1000:b5e8 (19EF_16FE / 0x1B5EE)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs12, 0x16FB);
      // JMP 0x1000:b6b0 (19EF_16F8 / 0x1B5E8)
      goto label_19EF_17C0_1B6B0;
    }
    CheckExternalEvents(cs12, 0x1702);
    // DEC AH (19EF_1700 / 0x1B5F0)
    AH = Alu8.Dec(AH);
    CheckExternalEvents(cs12, 0x1704);
    // MOV AL,0x7f (19EF_1702 / 0x1B5F2)
    AL = 0x7F;
    CheckExternalEvents(cs12, 0x1707);
    // MOV [0xa44b],AX (19EF_1704 / 0x1B5F4)
    UInt16[DS, 0xA44B] = AX;
    CheckExternalEvents(cs12, 0x1708);
    // PUSH ES (19EF_1707 / 0x1B5F7)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x170A);
    // MOV AX,DS (19EF_1708 / 0x1B5F8)
    AX = DS;
    CheckExternalEvents(cs12, 0x170C);
    // MOV ES,AX (19EF_170A / 0x1B5FA)
    ES = AX;
    CheckExternalEvents(cs12, 0x170F);
    // MOV SI,0x5a4 (19EF_170C / 0x1B5FC)
    SI = 0x5A4;
    CheckExternalEvents(cs12, 0x1712);
    // MOV DI,0x5e4 (19EF_170F / 0x1B5FF)
    DI = 0x5E4;
    CheckExternalEvents(cs12, 0x1715);
    // MOV CX,0x20 (19EF_1712 / 0x1B602)
    CX = 0x20;
    CheckExternalEvents(cs12, 0x1716);
    // CLD  (19EF_1715 / 0x1B605)
    DirectionFlag = false;
    CheckExternalEvents(cs12, 0x1718);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_1716 / 0x1B606)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x171B);
    // MOV SI,0x564 (19EF_1718 / 0x1B608)
    SI = 0x564;
    CheckExternalEvents(cs12, 0x171E);
    // MOV DI,0x5a4 (19EF_171B / 0x1B60B)
    DI = 0x5A4;
    CheckExternalEvents(cs12, 0x1721);
    // MOV CX,0x20 (19EF_171E / 0x1B60E)
    CX = 0x20;
    CheckExternalEvents(cs12, 0x1723);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_1721 / 0x1B611)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x1726);
    // MOV SI,0x664 (19EF_1723 / 0x1B613)
    SI = 0x664;
    CheckExternalEvents(cs12, 0x1729);
    // MOV DI,0x6a4 (19EF_1726 / 0x1B616)
    DI = 0x6A4;
    CheckExternalEvents(cs12, 0x172C);
    // MOV CX,0x20 (19EF_1729 / 0x1B619)
    CX = 0x20;
    CheckExternalEvents(cs12, 0x172E);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_172C / 0x1B61C)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x1731);
    // MOV SI,0x624 (19EF_172E / 0x1B61E)
    SI = 0x624;
    CheckExternalEvents(cs12, 0x1734);
    // MOV DI,0x664 (19EF_1731 / 0x1B621)
    DI = 0x664;
    CheckExternalEvents(cs12, 0x1737);
    // MOV CX,0x20 (19EF_1734 / 0x1B624)
    CX = 0x20;
    CheckExternalEvents(cs12, 0x1739);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_1737 / 0x1B627)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x173C);
    // MOV SI,0x724 (19EF_1739 / 0x1B629)
    SI = 0x724;
    CheckExternalEvents(cs12, 0x173F);
    // MOV DI,0x764 (19EF_173C / 0x1B62C)
    DI = 0x764;
    CheckExternalEvents(cs12, 0x1742);
    // MOV CX,0x20 (19EF_173F / 0x1B62F)
    CX = 0x20;
    CheckExternalEvents(cs12, 0x1744);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_1742 / 0x1B632)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x1747);
    // MOV SI,0x6e4 (19EF_1744 / 0x1B634)
    SI = 0x6E4;
    CheckExternalEvents(cs12, 0x174A);
    // MOV DI,0x724 (19EF_1747 / 0x1B637)
    DI = 0x724;
    CheckExternalEvents(cs12, 0x174D);
    // MOV CX,0x20 (19EF_174A / 0x1B63A)
    CX = 0x20;
    CheckExternalEvents(cs12, 0x174F);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_174D / 0x1B63D)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x1750);
    // POP ES (19EF_174F / 0x1B63F)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1753);
    // MOV DI,0x2d3 (19EF_1750 / 0x1B640)
    DI = 0x2D3;
    CheckExternalEvents(cs12, 0x1756);
    // MOV AX,[0xa44d] (19EF_1753 / 0x1B643)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs12, 0x175A);
    // MOV BX,word ptr [0xa44b] (19EF_1756 / 0x1B646)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs12, 0x175C);
    // OR AH,BH (19EF_175A / 0x1B64A)
    // AH |= BH;
    AH = Alu8.Or(AH, BH);
    CheckExternalEvents(cs12, 0x175E);
    // MOV AL,AH (19EF_175C / 0x1B64C)
    AL = AH;
    CheckExternalEvents(cs12, 0x1760);
    // XOR AH,AH (19EF_175E / 0x1B64E)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs12, 0x1762);
    // MOV SI,AX (19EF_1760 / 0x1B650)
    SI = AX;
    CheckExternalEvents(cs12, 0x1766);
    // ADD SI,0xb0b (19EF_1762 / 0x1B652)
    SI += 0xB0B;
    CheckExternalEvents(cs12, 0x1769);
    // SUB SI,0x11 (19EF_1766 / 0x1B656)
    // SI -= 0x11;
    SI = Alu16.Sub(SI, 0x11);
    CheckExternalEvents(cs12, 0x176C);
    // CALL 0x1000:b7c8 (19EF_1769 / 0x1B659)
    NearCall(cs12, 0x176C, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs12, 0x176D);
    // PUSH SI (19EF_176C / 0x1B65C)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1770);
    // MOV SI,0x564 (19EF_176D / 0x1B65D)
    SI = 0x564;
    CheckExternalEvents(cs12, 0x1773);
    // CALL 0x1000:aaeb (19EF_1770 / 0x1B660)
    NearCall(cs12, 0x1773, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs12, 0x1774);
    // POP SI (19EF_1773 / 0x1B663)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1777);
    // ADD SI,0x10 (19EF_1774 / 0x1B664)
    // SI += 0x10;
    SI = Alu16.Add(SI, 0x10);
    CheckExternalEvents(cs12, 0x177A);
    // MOV DI,0x2d3 (19EF_1777 / 0x1B667)
    DI = 0x2D3;
    CheckExternalEvents(cs12, 0x177D);
    // CALL 0x1000:b7c8 (19EF_177A / 0x1B66A)
    NearCall(cs12, 0x177D, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs12, 0x177E);
    // PUSH SI (19EF_177D / 0x1B66D)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1781);
    // MOV SI,0x624 (19EF_177E / 0x1B66E)
    SI = 0x624;
    CheckExternalEvents(cs12, 0x1784);
    // CALL 0x1000:aaeb (19EF_1781 / 0x1B671)
    NearCall(cs12, 0x1784, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs12, 0x1785);
    // POP SI (19EF_1784 / 0x1B674)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1788);
    // ADD SI,0x10 (19EF_1785 / 0x1B675)
    // SI += 0x10;
    SI = Alu16.Add(SI, 0x10);
    CheckExternalEvents(cs12, 0x178B);
    // MOV DI,0x2d3 (19EF_1788 / 0x1B678)
    DI = 0x2D3;
    CheckExternalEvents(cs12, 0x178E);
    // CALL 0x1000:b7c8 (19EF_178B / 0x1B67B)
    NearCall(cs12, 0x178E, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs12, 0x1791);
    // MOV SI,0x6e4 (19EF_178E / 0x1B67E)
    SI = 0x6E4;
    CheckExternalEvents(cs12, 0x1794);
    // CALL 0x1000:aaeb (19EF_1791 / 0x1B681)
    NearCall(cs12, 0x1794, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs12, 0x1797);
    // CALL 0x1000:b776 (19EF_1794 / 0x1B684)
    NearCall(cs12, 0x1797, unknown_19EF_1886_1B776);
    CheckExternalEvents(cs12, 0x179A);
    // MOV SI,0x9f3 (19EF_1797 / 0x1B687)
    SI = 0x9F3;
    CheckExternalEvents(cs12, 0x179D);
    // MOV AX,0x300 (19EF_179A / 0x1B68A)
    AX = 0x300;
    CheckExternalEvents(cs12, 0x179F);
    // MOV word ptr [SI],AX (19EF_179D / 0x1B68D)
    UInt16[DS, (ushort)(SI)] = AX;
    CheckExternalEvents(cs12, 0x17A2);
    // ADD SI,0x2 (19EF_179F / 0x1B68F)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs12, 0x17A4);
    // MOV AH,0x6 (19EF_17A2 / 0x1B692)
    AH = 0x6;
    CheckExternalEvents(cs12, 0x17A6);
    // MOV byte ptr [SI],AH (19EF_17A4 / 0x1B694)
    UInt8[DS, (ushort)(SI)] = AH;
    CheckExternalEvents(cs12, 0x17A7);
    // INC SI (19EF_17A6 / 0x1B696)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs12, 0x17AA);
    // MOV AX,[0xa44d] (19EF_17A7 / 0x1B697)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs12, 0x17AE);
    // OR AX,word ptr [0xa44b] (19EF_17AA / 0x1B69A)
    // AX |= UInt16[DS, 0xA44B];
    AX = Alu16.Or(AX, UInt16[DS, 0xA44B]);
    CheckExternalEvents(cs12, 0x17B0);
    // MOV AL,AH (19EF_17AE / 0x1B69E)
    AL = AH;
    CheckExternalEvents(cs12, 0x17B2);
    // XOR AH,AH (19EF_17B0 / 0x1B6A0)
    AH = 0;
    CheckExternalEvents(cs12, 0x17B4);
    // SUB AL,0x11 (19EF_17B2 / 0x1B6A2)
    // AL -= 0x11;
    AL = Alu8.Sub(AL, 0x11);
    CheckExternalEvents(cs12, 0x17B6);
    // MOV byte ptr [SI],AL (19EF_17B4 / 0x1B6A4)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs12, 0x17B7);
    // INC SI (19EF_17B6 / 0x1B6A6)
    SI++;
    CheckExternalEvents(cs12, 0x17B9);
    // ADD AL,0x10 (19EF_17B7 / 0x1B6A7)
    // AL += 0x10;
    AL = Alu8.Add(AL, 0x10);
    CheckExternalEvents(cs12, 0x17BB);
    // MOV byte ptr [SI],AL (19EF_17B9 / 0x1B6A9)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs12, 0x17BC);
    // INC SI (19EF_17BB / 0x1B6AB)
    SI++;
    CheckExternalEvents(cs12, 0x17BE);
    // ADD AL,0x10 (19EF_17BC / 0x1B6AC)
    // AL += 0x10;
    AL = Alu8.Add(AL, 0x10);
    CheckExternalEvents(cs12, 0x17C0);
    // MOV byte ptr [SI],AL (19EF_17BE / 0x1B6AE)
    UInt8[DS, (ushort)(SI)] = AL;
    label_19EF_17C0_1B6B0:
    CheckExternalEvents(cs12, 0x17C1);
    // POP DS (19EF_17C0 / 0x1B6B0)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x17C2);
    // POP SI (19EF_17C1 / 0x1B6B1)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x17C3);
    // POP DI (19EF_17C2 / 0x1B6B2)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x17C4);
    // POP BP (19EF_17C3 / 0x1B6B3)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x17C5);
    // RETF  (19EF_17C4 / 0x1B6B4)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_17C5_1B6B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_17C5_1B6B5:
    CheckExternalEvents(cs12, 0x17C6);
    // PUSH BP (19EF_17C5 / 0x1B6B5)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x17C8);
    // MOV BP,SP (19EF_17C6 / 0x1B6B6)
    BP = SP;
    CheckExternalEvents(cs12, 0x17C9);
    // PUSH DI (19EF_17C8 / 0x1B6B8)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x17CA);
    // PUSH SI (19EF_17C9 / 0x1B6B9)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x17CB);
    // PUSH DS (19EF_17CA / 0x1B6BA)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x17CE);
    // MOV AX,0x1ddc (19EF_17CB / 0x1B6BB)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x17D0);
    // MOV DS,AX (19EF_17CE / 0x1B6BE)
    DS = AX;
    CheckExternalEvents(cs12, 0x17D3);
    // MOV AX,[0xa44b] (19EF_17D0 / 0x1B6C0)
    AX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs12, 0x17D5);
    // INC AL (19EF_17D3 / 0x1B6C3)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs12, 0x17D7);
    // JS 0x1000:b6cd (19EF_17D5 / 0x1B6C5)
    if(SignFlag) {
      goto label_19EF_17DD_1B6CD;
    }
    CheckExternalEvents(cs12, 0x17DA);
    // MOV [0xa44b],AX (19EF_17D7 / 0x1B6C7)
    UInt16[DS, 0xA44B] = AX;
    label_19EF_17DA_1B6CA:
    CheckExternalEvents(cs12, 0x17DD);
    // JMP 0x1000:b771 (19EF_17DA / 0x1B6CA)
    goto label_19EF_1881_1B771;
    label_19EF_17DD_1B6CD:
    CheckExternalEvents(cs12, 0x17E0);
    // CMP AH,0xf (19EF_17DD / 0x1B6CD)
    Alu8.Sub(AH, 0xF);
    CheckExternalEvents(cs12, 0x17E2);
    // JZ 0x1000:b6ca (19EF_17E0 / 0x1B6D0)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs12, 0x17DD);
      // JMP 0x1000:b771 (19EF_17DA / 0x1B6CA)
      goto label_19EF_1881_1B771;
    }
    CheckExternalEvents(cs12, 0x17E4);
    // INC AH (19EF_17E2 / 0x1B6D2)
    AH++;
    CheckExternalEvents(cs12, 0x17E6);
    // XOR AL,AL (19EF_17E4 / 0x1B6D4)
    // AL ^= AL;
    AL = Alu8.Xor(AL, AL);
    CheckExternalEvents(cs12, 0x17E9);
    // MOV [0xa44b],AX (19EF_17E6 / 0x1B6D6)
    UInt16[DS, 0xA44B] = AX;
    CheckExternalEvents(cs12, 0x17EA);
    // PUSH ES (19EF_17E9 / 0x1B6D9)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x17EC);
    // MOV AX,DS (19EF_17EA / 0x1B6DA)
    AX = DS;
    CheckExternalEvents(cs12, 0x17EE);
    // MOV ES,AX (19EF_17EC / 0x1B6DC)
    ES = AX;
    CheckExternalEvents(cs12, 0x17F1);
    // MOV SI,0x5a4 (19EF_17EE / 0x1B6DE)
    SI = 0x5A4;
    CheckExternalEvents(cs12, 0x17F4);
    // MOV DI,0x564 (19EF_17F1 / 0x1B6E1)
    DI = 0x564;
    CheckExternalEvents(cs12, 0x17F7);
    // MOV CX,0x40 (19EF_17F4 / 0x1B6E4)
    CX = 0x40;
    CheckExternalEvents(cs12, 0x17F8);
    // CLD  (19EF_17F7 / 0x1B6E7)
    DirectionFlag = false;
    CheckExternalEvents(cs12, 0x17FA);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_17F8 / 0x1B6E8)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x17FD);
    // MOV SI,0x664 (19EF_17FA / 0x1B6EA)
    SI = 0x664;
    CheckExternalEvents(cs12, 0x1800);
    // MOV DI,0x624 (19EF_17FD / 0x1B6ED)
    DI = 0x624;
    CheckExternalEvents(cs12, 0x1803);
    // MOV CX,0x40 (19EF_1800 / 0x1B6F0)
    CX = 0x40;
    CheckExternalEvents(cs12, 0x1805);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_1803 / 0x1B6F3)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x1808);
    // MOV SI,0x724 (19EF_1805 / 0x1B6F5)
    SI = 0x724;
    CheckExternalEvents(cs12, 0x180B);
    // MOV DI,0x6e4 (19EF_1808 / 0x1B6F8)
    DI = 0x6E4;
    CheckExternalEvents(cs12, 0x180E);
    // MOV CX,0x40 (19EF_180B / 0x1B6FB)
    CX = 0x40;
    CheckExternalEvents(cs12, 0x1810);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_180E / 0x1B6FE)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs12, 0x1811);
    // POP ES (19EF_1810 / 0x1B700)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1814);
    // MOV DI,0x2d3 (19EF_1811 / 0x1B701)
    DI = 0x2D3;
    CheckExternalEvents(cs12, 0x1817);
    // MOV AX,[0xa44d] (19EF_1814 / 0x1B704)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs12, 0x181B);
    // MOV BX,word ptr [0xa44b] (19EF_1817 / 0x1B707)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs12, 0x181D);
    // OR AH,BH (19EF_181B / 0x1B70B)
    // AH |= BH;
    AH = Alu8.Or(AH, BH);
    CheckExternalEvents(cs12, 0x181F);
    // MOV AL,AH (19EF_181D / 0x1B70D)
    AL = AH;
    CheckExternalEvents(cs12, 0x1821);
    // XOR AH,AH (19EF_181F / 0x1B70F)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs12, 0x1823);
    // MOV SI,AX (19EF_1821 / 0x1B711)
    SI = AX;
    CheckExternalEvents(cs12, 0x1827);
    // ADD SI,0xb0b (19EF_1823 / 0x1B713)
    SI += 0xB0B;
    CheckExternalEvents(cs12, 0x182A);
    // SUB SI,0xf (19EF_1827 / 0x1B717)
    // SI -= 0xF;
    SI = Alu16.Sub(SI, 0xF);
    CheckExternalEvents(cs12, 0x182D);
    // CALL 0x1000:b7c8 (19EF_182A / 0x1B71A)
    NearCall(cs12, 0x182D, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs12, 0x182E);
    // PUSH SI (19EF_182D / 0x1B71D)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1831);
    // MOV SI,0x5e4 (19EF_182E / 0x1B71E)
    SI = 0x5E4;
    CheckExternalEvents(cs12, 0x1834);
    // CALL 0x1000:aaeb (19EF_1831 / 0x1B721)
    NearCall(cs12, 0x1834, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs12, 0x1835);
    // POP SI (19EF_1834 / 0x1B724)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1838);
    // ADD SI,0x10 (19EF_1835 / 0x1B725)
    // SI += 0x10;
    SI = Alu16.Add(SI, 0x10);
    CheckExternalEvents(cs12, 0x183B);
    // MOV DI,0x2d3 (19EF_1838 / 0x1B728)
    DI = 0x2D3;
    CheckExternalEvents(cs12, 0x183E);
    // CALL 0x1000:b7c8 (19EF_183B / 0x1B72B)
    NearCall(cs12, 0x183E, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs12, 0x183F);
    // PUSH SI (19EF_183E / 0x1B72E)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1842);
    // MOV SI,0x6a4 (19EF_183F / 0x1B72F)
    SI = 0x6A4;
    CheckExternalEvents(cs12, 0x1845);
    // CALL 0x1000:aaeb (19EF_1842 / 0x1B732)
    NearCall(cs12, 0x1845, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs12, 0x1846);
    // POP SI (19EF_1845 / 0x1B735)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1849);
    // ADD SI,0x10 (19EF_1846 / 0x1B736)
    // SI += 0x10;
    SI = Alu16.Add(SI, 0x10);
    CheckExternalEvents(cs12, 0x184C);
    // MOV DI,0x2d3 (19EF_1849 / 0x1B739)
    DI = 0x2D3;
    CheckExternalEvents(cs12, 0x184F);
    // CALL 0x1000:b7c8 (19EF_184C / 0x1B73C)
    NearCall(cs12, 0x184F, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs12, 0x1852);
    // MOV SI,0x764 (19EF_184F / 0x1B73F)
    SI = 0x764;
    CheckExternalEvents(cs12, 0x1855);
    // CALL 0x1000:aaeb (19EF_1852 / 0x1B742)
    NearCall(cs12, 0x1855, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs12, 0x1858);
    // CALL 0x1000:b776 (19EF_1855 / 0x1B745)
    NearCall(cs12, 0x1858, unknown_19EF_1886_1B776);
    CheckExternalEvents(cs12, 0x185B);
    // MOV SI,0x9f3 (19EF_1858 / 0x1B748)
    SI = 0x9F3;
    CheckExternalEvents(cs12, 0x185E);
    // MOV AX,0x502 (19EF_185B / 0x1B74B)
    AX = 0x502;
    CheckExternalEvents(cs12, 0x1860);
    // MOV word ptr [SI],AX (19EF_185E / 0x1B74E)
    UInt16[DS, (ushort)(SI)] = AX;
    CheckExternalEvents(cs12, 0x1863);
    // ADD SI,0x2 (19EF_1860 / 0x1B750)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs12, 0x1865);
    // MOV AH,0x8 (19EF_1863 / 0x1B753)
    AH = 0x8;
    CheckExternalEvents(cs12, 0x1867);
    // MOV byte ptr [SI],AH (19EF_1865 / 0x1B755)
    UInt8[DS, (ushort)(SI)] = AH;
    CheckExternalEvents(cs12, 0x1868);
    // INC SI (19EF_1867 / 0x1B757)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs12, 0x186B);
    // MOV AX,[0xa44d] (19EF_1868 / 0x1B758)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs12, 0x186F);
    // OR AX,word ptr [0xa44b] (19EF_186B / 0x1B75B)
    // AX |= UInt16[DS, 0xA44B];
    AX = Alu16.Or(AX, UInt16[DS, 0xA44B]);
    CheckExternalEvents(cs12, 0x1871);
    // MOV AL,AH (19EF_186F / 0x1B75F)
    AL = AH;
    CheckExternalEvents(cs12, 0x1873);
    // XOR AH,AH (19EF_1871 / 0x1B761)
    AH = 0;
    CheckExternalEvents(cs12, 0x1875);
    // SUB AL,0xf (19EF_1873 / 0x1B763)
    // AL -= 0xF;
    AL = Alu8.Sub(AL, 0xF);
    CheckExternalEvents(cs12, 0x1877);
    // MOV byte ptr [SI],AL (19EF_1875 / 0x1B765)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs12, 0x1878);
    // INC SI (19EF_1877 / 0x1B767)
    SI++;
    CheckExternalEvents(cs12, 0x187A);
    // ADD AL,0x10 (19EF_1878 / 0x1B768)
    // AL += 0x10;
    AL = Alu8.Add(AL, 0x10);
    CheckExternalEvents(cs12, 0x187C);
    // MOV byte ptr [SI],AL (19EF_187A / 0x1B76A)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs12, 0x187D);
    // INC SI (19EF_187C / 0x1B76C)
    SI++;
    CheckExternalEvents(cs12, 0x187F);
    // ADD AL,0x10 (19EF_187D / 0x1B76D)
    // AL += 0x10;
    AL = Alu8.Add(AL, 0x10);
    CheckExternalEvents(cs12, 0x1881);
    // MOV byte ptr [SI],AL (19EF_187F / 0x1B76F)
    UInt8[DS, (ushort)(SI)] = AL;
    label_19EF_1881_1B771:
    CheckExternalEvents(cs12, 0x1882);
    // POP DS (19EF_1881 / 0x1B771)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1883);
    // POP SI (19EF_1882 / 0x1B772)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1884);
    // POP DI (19EF_1883 / 0x1B773)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1885);
    // POP BP (19EF_1884 / 0x1B774)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1886);
    // RETF  (19EF_1885 / 0x1B775)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1886_1B776(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1886_1B776:
    CheckExternalEvents(cs12, 0x1889);
    // MOV SI,0x564 (19EF_1886 / 0x1B776)
    SI = 0x564;
    CheckExternalEvents(cs12, 0x188C);
    // MOV DI,0x324 (19EF_1889 / 0x1B779)
    DI = 0x324;
    CheckExternalEvents(cs12, 0x188F);
    // CALL 0x1000:b0ab (19EF_188C / 0x1B77C)
    NearCall(cs12, 0x188F, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs12, 0x1892);
    // MOV SI,0x5a4 (19EF_188F / 0x1B77F)
    SI = 0x5A4;
    CheckExternalEvents(cs12, 0x1895);
    // MOV DI,0x364 (19EF_1892 / 0x1B782)
    DI = 0x364;
    CheckExternalEvents(cs12, 0x1898);
    // CALL 0x1000:b0ab (19EF_1895 / 0x1B785)
    NearCall(cs12, 0x1898, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs12, 0x189B);
    // MOV SI,0x5e4 (19EF_1898 / 0x1B788)
    SI = 0x5E4;
    CheckExternalEvents(cs12, 0x189E);
    // MOV DI,0x3a4 (19EF_189B / 0x1B78B)
    DI = 0x3A4;
    CheckExternalEvents(cs12, 0x18A1);
    // CALL 0x1000:b0ab (19EF_189E / 0x1B78E)
    NearCall(cs12, 0x18A1, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs12, 0x18A4);
    // MOV SI,0x624 (19EF_18A1 / 0x1B791)
    SI = 0x624;
    CheckExternalEvents(cs12, 0x18A7);
    // MOV DI,0x3e4 (19EF_18A4 / 0x1B794)
    DI = 0x3E4;
    CheckExternalEvents(cs12, 0x18AA);
    // CALL 0x1000:b0ab (19EF_18A7 / 0x1B797)
    NearCall(cs12, 0x18AA, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs12, 0x18AD);
    // MOV SI,0x664 (19EF_18AA / 0x1B79A)
    SI = 0x664;
    CheckExternalEvents(cs12, 0x18B0);
    // MOV DI,0x424 (19EF_18AD / 0x1B79D)
    DI = 0x424;
    CheckExternalEvents(cs12, 0x18B3);
    // CALL 0x1000:b0ab (19EF_18B0 / 0x1B7A0)
    NearCall(cs12, 0x18B3, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs12, 0x18B6);
    // MOV SI,0x6a4 (19EF_18B3 / 0x1B7A3)
    SI = 0x6A4;
    CheckExternalEvents(cs12, 0x18B9);
    // MOV DI,0x464 (19EF_18B6 / 0x1B7A6)
    DI = 0x464;
    CheckExternalEvents(cs12, 0x18BC);
    // CALL 0x1000:b0ab (19EF_18B9 / 0x1B7A9)
    NearCall(cs12, 0x18BC, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs12, 0x18BF);
    // MOV SI,0x6e4 (19EF_18BC / 0x1B7AC)
    SI = 0x6E4;
    CheckExternalEvents(cs12, 0x18C2);
    // MOV DI,0x4a4 (19EF_18BF / 0x1B7AF)
    DI = 0x4A4;
    CheckExternalEvents(cs12, 0x18C5);
    // CALL 0x1000:b0ab (19EF_18C2 / 0x1B7B2)
    NearCall(cs12, 0x18C5, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs12, 0x18C8);
    // MOV SI,0x724 (19EF_18C5 / 0x1B7B5)
    SI = 0x724;
    CheckExternalEvents(cs12, 0x18CB);
    // MOV DI,0x4e4 (19EF_18C8 / 0x1B7B8)
    DI = 0x4E4;
    CheckExternalEvents(cs12, 0x18CE);
    // CALL 0x1000:b0ab (19EF_18CB / 0x1B7BB)
    NearCall(cs12, 0x18CE, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs12, 0x18D1);
    // MOV SI,0x764 (19EF_18CE / 0x1B7BE)
    SI = 0x764;
    CheckExternalEvents(cs12, 0x18D4);
    // MOV DI,0x524 (19EF_18D1 / 0x1B7C1)
    DI = 0x524;
    CheckExternalEvents(cs12, 0x18D7);
    // CALL 0x1000:b0ab (19EF_18D4 / 0x1B7C4)
    NearCall(cs12, 0x18D7, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs12, 0x18D8);
    // RET  (19EF_18D7 / 0x1B7C7)
    return NearRet();
  }
  
  public virtual Action ghidra_guess_1000_B7C8_1B7C8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_B7C8_1B7C8:
    CheckExternalEvents(cs7, 0xB7CA);
    // MOV AL,byte ptr [SI] (1000_B7C8 / 0x1B7C8)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xB7CC);
    // MOV byte ptr [DI],AL (1000_B7CA / 0x1B7CA)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs7, 0xB7CF);
    // MOV AL,byte ptr [SI + 0x1] (1000_B7CC / 0x1B7CC)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    CheckExternalEvents(cs7, 0xB7D2);
    // MOV byte ptr [DI + 0x8],AL (1000_B7CF / 0x1B7CF)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    CheckExternalEvents(cs7, 0xB7D5);
    // MOV AL,byte ptr [SI + 0x10] (1000_B7D2 / 0x1B7D2)
    AL = UInt8[DS, (ushort)(SI + 0x10)];
    CheckExternalEvents(cs7, 0xB7D8);
    // MOV byte ptr [DI + 0x48],AL (1000_B7D5 / 0x1B7D5)
    UInt8[DS, (ushort)(DI + 0x48)] = AL;
    CheckExternalEvents(cs7, 0xB7DB);
    // MOV AL,byte ptr [SI + 0x11] (1000_B7D8 / 0x1B7D8)
    AL = UInt8[DS, (ushort)(SI + 0x11)];
    CheckExternalEvents(cs7, 0xB7DE);
    // MOV byte ptr [DI + 0x50],AL (1000_B7DB / 0x1B7DB)
    UInt8[DS, (ushort)(DI + 0x50)] = AL;
    CheckExternalEvents(cs7, 0xB7DF);
    // RET  (1000_B7DE / 0x1B7DE)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_18EF_1B7DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_18EF_1B7DF:
    CheckExternalEvents(cs12, 0x18F0);
    // PUSH BP (19EF_18EF / 0x1B7DF)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x18F2);
    // MOV BP,SP (19EF_18F0 / 0x1B7E0)
    BP = SP;
    CheckExternalEvents(cs12, 0x18F3);
    // PUSH DI (19EF_18F2 / 0x1B7E2)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x18F4);
    // PUSH SI (19EF_18F3 / 0x1B7E3)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x18F5);
    // PUSH DS (19EF_18F4 / 0x1B7E4)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x18F8);
    // MOV AX,0x1ddc (19EF_18F5 / 0x1B7E5)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x18FA);
    // MOV DS,AX (19EF_18F8 / 0x1B7E8)
    DS = AX;
    CheckExternalEvents(cs12, 0x18FB);
    // PUSH BP (19EF_18FA / 0x1B7EA)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x18FC);
    // PUSH ES (19EF_18FB / 0x1B7EB)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x18FF);
    // MOV DI,0x34 (19EF_18FC / 0x1B7EC)
    DI = 0x34;
    CheckExternalEvents(cs12, 0x1903);
    // ADD DI,0x244b (19EF_18FF / 0x1B7EF)
    // DI += 0x244B;
    DI = Alu16.Add(DI, 0x244B);
    CheckExternalEvents(cs12, 0x1909);
    // MOV word ptr [0xa452],0x8 (19EF_1903 / 0x1B7F3)
    UInt16[DS, 0xA452] = 0x8;
    CheckExternalEvents(cs12, 0x190F);
    // MOV word ptr [0xa454],0x994 (19EF_1909 / 0x1B7F9)
    UInt16[DS, 0xA454] = 0x994;
    CheckExternalEvents(cs12, 0x1915);
    // MOV word ptr [0xa456],0x494 (19EF_190F / 0x1B7FF)
    UInt16[DS, 0xA456] = 0x494;
    CheckExternalEvents(cs12, 0x1917);
    // MOV AX,DS (19EF_1915 / 0x1B805)
    AX = DS;
    CheckExternalEvents(cs12, 0x191C);
    // CMP word ptr [0xb764],0x2 (19EF_1917 / 0x1B807)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs12, 0x191E);
    // JNZ 0x1000:b831 (19EF_191C / 0x1B80C)
    if(!ZeroFlag) {
      goto label_19EF_1941_1B831;
    }
    CheckExternalEvents(cs12, 0x1921);
    // MOV DX,0x3ce (19EF_191E / 0x1B80E)
    DX = 0x3CE;
    CheckExternalEvents(cs12, 0x1924);
    // MOV AX,0x205 (19EF_1921 / 0x1B811)
    AX = 0x205;
    CheckExternalEvents(cs12, 0x1925);
    // OUT DX,AX (19EF_1924 / 0x1B814)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x1928);
    // MOV AX,0x8 (19EF_1925 / 0x1B815)
    AX = 0x8;
    CheckExternalEvents(cs12, 0x1929);
    // OUT DX,AX (19EF_1928 / 0x1B818)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x192F);
    // MOV word ptr [0xa452],0x2 (19EF_1929 / 0x1B819)
    UInt16[DS, 0xA452] = 0x2;
    CheckExternalEvents(cs12, 0x1935);
    // MOV word ptr [0xa454],0x265 (19EF_192F / 0x1B81F)
    UInt16[DS, 0xA454] = 0x265;
    CheckExternalEvents(cs12, 0x193B);
    // MOV word ptr [0xa456],0x125 (19EF_1935 / 0x1B825)
    UInt16[DS, 0xA456] = 0x125;
    CheckExternalEvents(cs12, 0x193E);
    // MOV AX,0xac00 (19EF_193B / 0x1B82B)
    AX = 0xAC00;
    CheckExternalEvents(cs12, 0x1941);
    // MOV DI,0xd (19EF_193E / 0x1B82E)
    DI = 0xD;
    label_19EF_1941_1B831:
    CheckExternalEvents(cs12, 0x1943);
    // MOV ES,AX (19EF_1941 / 0x1B831)
    ES = AX;
    CheckExternalEvents(cs12, 0x1948);
    // CMP word ptr [0xb764],0x0 (19EF_1943 / 0x1B833)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs12, 0x194A);
    // JNZ 0x1000:b849 (19EF_1948 / 0x1B838)
    if(!ZeroFlag) {
      goto label_19EF_1959_1B849;
    }
    CheckExternalEvents(cs12, 0x194D);
    // SUB DI,0x1a (19EF_194A / 0x1B83A)
    DI -= 0x1A;
    CheckExternalEvents(cs12, 0x1951);
    // SHR word ptr [0xa452],0x1 (19EF_194D / 0x1B83D)
    UInt16[DS, 0xA452] >>= 0x1;
    CheckExternalEvents(cs12, 0x1955);
    // SHR word ptr [0xa454],0x1 (19EF_1951 / 0x1B841)
    UInt16[DS, 0xA454] >>= 0x1;
    CheckExternalEvents(cs12, 0x1959);
    // SHR word ptr [0xa456],0x1 (19EF_1955 / 0x1B845)
    // UInt16[DS, 0xA456] >>= 0x1;
    UInt16[DS, 0xA456] = Alu16.Shr(UInt16[DS, 0xA456], 0x1);
    label_19EF_1959_1B849:
    CheckExternalEvents(cs12, 0x195A);
    // CLD  (19EF_1959 / 0x1B849)
    DirectionFlag = false;
    CheckExternalEvents(cs12, 0x195D);
    // MOV AX,[0xa44d] (19EF_195A / 0x1B84A)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs12, 0x195F);
    // SHR AL,0x1 (19EF_195D / 0x1B84D)
    AL >>= 0x1;
    CheckExternalEvents(cs12, 0x1962);
    // AND AX,0x7 (19EF_195F / 0x1B84F)
    AX &= 0x7;
    CheckExternalEvents(cs12, 0x1964);
    // ADD AL,0x2 (19EF_1962 / 0x1B852)
    AL += 0x2;
    CheckExternalEvents(cs12, 0x1966);
    // SHL AX,0x1 (19EF_1964 / 0x1B854)
    AX <<= 0x1;
    CheckExternalEvents(cs12, 0x1968);
    // SHL AX,0x1 (19EF_1966 / 0x1B856)
    AX <<= 0x1;
    CheckExternalEvents(cs12, 0x196A);
    // SHL AX,0x1 (19EF_1968 / 0x1B858)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs12, 0x196C);
    // MOV BX,AX (19EF_196A / 0x1B85A)
    BX = AX;
    CheckExternalEvents(cs12, 0x196E);
    // SHL AX,0x1 (19EF_196C / 0x1B85C)
    AX <<= 0x1;
    CheckExternalEvents(cs12, 0x1970);
    // ADD AX,BX (19EF_196E / 0x1B85E)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs12, 0x1974);
    // MOV BX,word ptr [0xa44b] (19EF_1970 / 0x1B860)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs12, 0x1976);
    // SHR BL,0x1 (19EF_1974 / 0x1B864)
    BL >>= 0x1;
    CheckExternalEvents(cs12, 0x1979);
    // AND BX,0x7 (19EF_1976 / 0x1B866)
    BX &= 0x7;
    CheckExternalEvents(cs12, 0x197C);
    // ADD BL,0x2 (19EF_1979 / 0x1B869)
    BL += 0x2;
    CheckExternalEvents(cs12, 0x197E);
    // ADD BX,AX (19EF_197C / 0x1B86C)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs12, 0x1982);
    // MOV word ptr [0x9ed],BX (19EF_197E / 0x1B86E)
    UInt16[DS, 0x9ED] = BX;
    CheckExternalEvents(cs12, 0x1986);
    // ADD BX,0x7ad (19EF_1982 / 0x1B872)
    // BX += 0x7AD;
    BX = Alu16.Add(BX, 0x7AD);
    CheckExternalEvents(cs12, 0x198B);
    // MOV byte ptr [0xa44f],0x0 (19EF_1986 / 0x1B876)
    UInt8[DS, 0xA44F] = 0x0;
    CheckExternalEvents(cs12, 0x1991);
    // TEST word ptr [0xa44d],0x1 (19EF_198B / 0x1B87B)
    Alu16.And(UInt16[DS, 0xA44D], 0x1);
    CheckExternalEvents(cs12, 0x1993);
    // JZ 0x1000:b8e5 (19EF_1991 / 0x1B881)
    if(ZeroFlag) {
      goto label_19EF_19F5_1B8E5;
    }
    CheckExternalEvents(cs12, 0x1999);
    // TEST word ptr [0xa44b],0x1 (19EF_1993 / 0x1B883)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs12, 0x199B);
    // JZ 0x1000:b8a7 (19EF_1999 / 0x1B889)
    if(ZeroFlag) {
      goto label_19EF_19B7_1B8A7;
    }
    CheckExternalEvents(cs12, 0x199D);
    // MOV DH,byte ptr [BX] (19EF_199B / 0x1B88B)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x19A2);
    // MOV byte ptr [0xa450],0x0 (19EF_199D / 0x1B88D)
    UInt8[DS, 0xA450] = 0x0;
    CheckExternalEvents(cs12, 0x19A7);
    // MOV byte ptr [0xa44f],0x1 (19EF_19A2 / 0x1B892)
    UInt8[DS, 0xA44F] = 0x1;
    CheckExternalEvents(cs12, 0x19AC);
    // MOV byte ptr [0xa451],0x1 (19EF_19A7 / 0x1B897)
    UInt8[DS, 0xA451] = 0x1;
    CheckExternalEvents(cs12, 0x19AF);
    // CALL 0x1000:b998 (19EF_19AC / 0x1B89C)
    NearCall(cs12, 0x19AF, unknown_19EF_1AA8_1B998);
    CheckExternalEvents(cs12, 0x19B0);
    // INC BX (19EF_19AF / 0x1B89F)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs12, 0x19B3);
    // MOV AX,[0xa452] (19EF_19B0 / 0x1B8A0)
    AX = UInt16[DS, 0xA452];
    CheckExternalEvents(cs12, 0x19B5);
    // SHR AX,0x1 (19EF_19B3 / 0x1B8A3)
    AX >>= 0x1;
    CheckExternalEvents(cs12, 0x19B7);
    // ADD DI,AX (19EF_19B5 / 0x1B8A5)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    label_19EF_19B7_1B8A7:
    CheckExternalEvents(cs12, 0x19BA);
    // MOV CX,0xd (19EF_19B7 / 0x1B8A7)
    CX = 0xD;
    label_19EF_19BA_1B8AA:
    CheckExternalEvents(cs12, 0x19BB);
    // PUSH CX (19EF_19BA / 0x1B8AA)
    Stack.Push16(CX);
    CheckExternalEvents(cs12, 0x19BD);
    // MOV DH,byte ptr [BX] (19EF_19BB / 0x1B8AB)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x19C0);
    // CALL 0x1000:b9be (19EF_19BD / 0x1B8AD)
    NearCall(cs12, 0x19C0, unknown_19EF_1ACE_1B9BE);
    CheckExternalEvents(cs12, 0x19C4);
    // ADD DI,word ptr [0xa452] (19EF_19C0 / 0x1B8B0)
    DI += UInt16[DS, 0xA452];
    CheckExternalEvents(cs12, 0x19C5);
    // INC BX (19EF_19C4 / 0x1B8B4)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs12, 0x19C6);
    // POP CX (19EF_19C5 / 0x1B8B5)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x19C8);
    // LOOP 0x1000:b8aa (19EF_19C6 / 0x1B8B6)
    if(--CX != 0) {
      goto label_19EF_19BA_1B8AA;
    }
    CheckExternalEvents(cs12, 0x19CE);
    // TEST word ptr [0xa44b],0x1 (19EF_19C8 / 0x1B8B8)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs12, 0x19D0);
    // JNZ 0x1000:b8de (19EF_19CE / 0x1B8BE)
    if(!ZeroFlag) {
      goto label_19EF_19EE_1B8DE;
    }
    CheckExternalEvents(cs12, 0x19D2);
    // MOV DH,byte ptr [BX] (19EF_19D0 / 0x1B8C0)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x19D4);
    // MOV DL,0x1 (19EF_19D2 / 0x1B8C2)
    DL = 0x1;
    CheckExternalEvents(cs12, 0x19D9);
    // MOV byte ptr [0xa44f],0x1 (19EF_19D4 / 0x1B8C4)
    UInt8[DS, 0xA44F] = 0x1;
    CheckExternalEvents(cs12, 0x19DE);
    // MOV byte ptr [0xa450],0x1 (19EF_19D9 / 0x1B8C9)
    UInt8[DS, 0xA450] = 0x1;
    CheckExternalEvents(cs12, 0x19E3);
    // MOV byte ptr [0xa451],0x1 (19EF_19DE / 0x1B8CE)
    UInt8[DS, 0xA451] = 0x1;
    CheckExternalEvents(cs12, 0x19E6);
    // CALL 0x1000:b998 (19EF_19E3 / 0x1B8D3)
    NearCall(cs12, 0x19E6, unknown_19EF_1AA8_1B998);
    CheckExternalEvents(cs12, 0x19E9);
    // MOV AX,[0xa452] (19EF_19E6 / 0x1B8D6)
    AX = UInt16[DS, 0xA452];
    CheckExternalEvents(cs12, 0x19EB);
    // SHR AX,0x1 (19EF_19E9 / 0x1B8D9)
    AX >>= 0x1;
    CheckExternalEvents(cs12, 0x19ED);
    // ADD DI,AX (19EF_19EB / 0x1B8DB)
    DI += AX;
    CheckExternalEvents(cs12, 0x19EE);
    // INC BX (19EF_19ED / 0x1B8DD)
    BX++;
    label_19EF_19EE_1B8DE:
    CheckExternalEvents(cs12, 0x19F1);
    // ADD BX,0xa (19EF_19EE / 0x1B8DE)
    BX += 0xA;
    CheckExternalEvents(cs12, 0x19F5);
    // ADD DI,word ptr [0xa456] (19EF_19F1 / 0x1B8E1)
    DI += UInt16[DS, 0xA456];
    label_19EF_19F5_1B8E5:
    CheckExternalEvents(cs12, 0x19F7);
    // XOR AL,AL (19EF_19F5 / 0x1B8E5)
    // AL ^= AL;
    AL = Alu8.Xor(AL, AL);
    CheckExternalEvents(cs12, 0x19FA);
    // MOV [0xa44f],AL (19EF_19F7 / 0x1B8E7)
    UInt8[DS, 0xA44F] = AL;
    CheckExternalEvents(cs12, 0x19FD);
    // MOV [0xa450],AL (19EF_19FA / 0x1B8EA)
    UInt8[DS, 0xA450] = AL;
    CheckExternalEvents(cs12, 0x1A00);
    // MOV [0xa451],AL (19EF_19FD / 0x1B8ED)
    UInt8[DS, 0xA451] = AL;
    CheckExternalEvents(cs12, 0x1A05);
    // MOV byte ptr [0xa458],0xc (19EF_1A00 / 0x1B8F0)
    UInt8[DS, 0xA458] = 0xC;
    label_19EF_1A05_1B8F5:
    CheckExternalEvents(cs12, 0x1A0B);
    // TEST word ptr [0xa44b],0x1 (19EF_1A05 / 0x1B8F5)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs12, 0x1A0D);
    // JZ 0x1000:b90f (19EF_1A0B / 0x1B8FB)
    if(ZeroFlag) {
      goto label_19EF_1A1F_1B90F;
    }
    CheckExternalEvents(cs12, 0x1A0F);
    // MOV DH,byte ptr [BX] (19EF_1A0D / 0x1B8FD)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x1A14);
    // MOV byte ptr [0xa450],0x0 (19EF_1A0F / 0x1B8FF)
    UInt8[DS, 0xA450] = 0x0;
    CheckExternalEvents(cs12, 0x1A17);
    // CALL 0x1000:b998 (19EF_1A14 / 0x1B904)
    NearCall(cs12, 0x1A17, unknown_19EF_1AA8_1B998);
    CheckExternalEvents(cs12, 0x1A18);
    // INC BX (19EF_1A17 / 0x1B907)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs12, 0x1A1B);
    // MOV AX,[0xa452] (19EF_1A18 / 0x1B908)
    AX = UInt16[DS, 0xA452];
    CheckExternalEvents(cs12, 0x1A1D);
    // SHR AX,0x1 (19EF_1A1B / 0x1B90B)
    AX >>= 0x1;
    CheckExternalEvents(cs12, 0x1A1F);
    // ADD DI,AX (19EF_1A1D / 0x1B90D)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    label_19EF_1A1F_1B90F:
    CheckExternalEvents(cs12, 0x1A22);
    // MOV CX,0xd (19EF_1A1F / 0x1B90F)
    CX = 0xD;
    label_19EF_1A22_1B912:
    CheckExternalEvents(cs12, 0x1A24);
    // MOV DH,byte ptr [BX] (19EF_1A22 / 0x1B912)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x1A25);
    // PUSH CX (19EF_1A24 / 0x1B914)
    Stack.Push16(CX);
    CheckExternalEvents(cs12, 0x1A28);
    // CALL 0x1000:b9e4 (19EF_1A25 / 0x1B915)
    NearCall(cs12, 0x1A28, unknown_19EF_1AF4_1B9E4);
    CheckExternalEvents(cs12, 0x1A29);
    // INC BX (19EF_1A28 / 0x1B918)
    BX++;
    CheckExternalEvents(cs12, 0x1A2D);
    // ADD DI,word ptr [0xa452] (19EF_1A29 / 0x1B919)
    // DI += UInt16[DS, 0xA452];
    DI = Alu16.Add(DI, UInt16[DS, 0xA452]);
    CheckExternalEvents(cs12, 0x1A2E);
    // POP CX (19EF_1A2D / 0x1B91D)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1A30);
    // LOOP 0x1000:b912 (19EF_1A2E / 0x1B91E)
    if(--CX != 0) {
      goto label_19EF_1A22_1B912;
    }
    CheckExternalEvents(cs12, 0x1A36);
    // TEST word ptr [0xa44b],0x1 (19EF_1A30 / 0x1B920)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs12, 0x1A38);
    // JNZ 0x1000:b93a (19EF_1A36 / 0x1B926)
    if(!ZeroFlag) {
      goto label_19EF_1A4A_1B93A;
    }
    CheckExternalEvents(cs12, 0x1A3A);
    // MOV DH,byte ptr [BX] (19EF_1A38 / 0x1B928)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x1A3F);
    // MOV byte ptr [0xa450],0x1 (19EF_1A3A / 0x1B92A)
    UInt8[DS, 0xA450] = 0x1;
    CheckExternalEvents(cs12, 0x1A42);
    // CALL 0x1000:b998 (19EF_1A3F / 0x1B92F)
    NearCall(cs12, 0x1A42, unknown_19EF_1AA8_1B998);
    CheckExternalEvents(cs12, 0x1A43);
    // INC BX (19EF_1A42 / 0x1B932)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs12, 0x1A46);
    // MOV AX,[0xa452] (19EF_1A43 / 0x1B933)
    AX = UInt16[DS, 0xA452];
    CheckExternalEvents(cs12, 0x1A48);
    // SHR AX,0x1 (19EF_1A46 / 0x1B936)
    AX >>= 0x1;
    CheckExternalEvents(cs12, 0x1A4A);
    // ADD DI,AX (19EF_1A48 / 0x1B938)
    DI += AX;
    label_19EF_1A4A_1B93A:
    CheckExternalEvents(cs12, 0x1A4D);
    // ADD BX,0xa (19EF_1A4A / 0x1B93A)
    BX += 0xA;
    CheckExternalEvents(cs12, 0x1A51);
    // ADD DI,word ptr [0xa454] (19EF_1A4D / 0x1B93D)
    DI += UInt16[DS, 0xA454];
    CheckExternalEvents(cs12, 0x1A55);
    // DEC byte ptr [0xa458] (19EF_1A51 / 0x1B941)
    UInt8[DS, 0xA458] = Alu8.Dec(UInt8[DS, 0xA458]);
    CheckExternalEvents(cs12, 0x1A57);
    // JNZ 0x1000:b8f5 (19EF_1A55 / 0x1B945)
    if(!ZeroFlag) {
      goto label_19EF_1A05_1B8F5;
    }
    CheckExternalEvents(cs12, 0x1A5D);
    // TEST word ptr [0xa44d],0x1 (19EF_1A57 / 0x1B947)
    Alu16.And(UInt16[DS, 0xA44D], 0x1);
    CheckExternalEvents(cs12, 0x1A5F);
    // JNZ 0x1000:b991 (19EF_1A5D / 0x1B94D)
    if(!ZeroFlag) {
      goto label_19EF_1AA1_1B991;
    }
    CheckExternalEvents(cs12, 0x1A64);
    // MOV byte ptr [0xa44f],0x1 (19EF_1A5F / 0x1B94F)
    UInt8[DS, 0xA44F] = 0x1;
    CheckExternalEvents(cs12, 0x1A6A);
    // TEST word ptr [0xa44b],0x1 (19EF_1A64 / 0x1B954)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs12, 0x1A6C);
    // JZ 0x1000:b96e (19EF_1A6A / 0x1B95A)
    if(ZeroFlag) {
      goto label_19EF_1A7E_1B96E;
    }
    CheckExternalEvents(cs12, 0x1A6E);
    // MOV DH,byte ptr [BX] (19EF_1A6C / 0x1B95C)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x1A73);
    // MOV byte ptr [0xa450],0x0 (19EF_1A6E / 0x1B95E)
    UInt8[DS, 0xA450] = 0x0;
    CheckExternalEvents(cs12, 0x1A76);
    // CALL 0x1000:b998 (19EF_1A73 / 0x1B963)
    NearCall(cs12, 0x1A76, unknown_19EF_1AA8_1B998);
    CheckExternalEvents(cs12, 0x1A77);
    // INC BX (19EF_1A76 / 0x1B966)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs12, 0x1A7A);
    // MOV AX,[0xa452] (19EF_1A77 / 0x1B967)
    AX = UInt16[DS, 0xA452];
    CheckExternalEvents(cs12, 0x1A7C);
    // SHR AX,0x1 (19EF_1A7A / 0x1B96A)
    AX >>= 0x1;
    CheckExternalEvents(cs12, 0x1A7E);
    // ADD DI,AX (19EF_1A7C / 0x1B96C)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    label_19EF_1A7E_1B96E:
    CheckExternalEvents(cs12, 0x1A81);
    // MOV CX,0xd (19EF_1A7E / 0x1B96E)
    CX = 0xD;
    label_19EF_1A81_1B971:
    CheckExternalEvents(cs12, 0x1A82);
    // PUSH CX (19EF_1A81 / 0x1B971)
    Stack.Push16(CX);
    CheckExternalEvents(cs12, 0x1A84);
    // MOV DH,byte ptr [BX] (19EF_1A82 / 0x1B972)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x1A87);
    // CALL 0x1000:b9e4 (19EF_1A84 / 0x1B974)
    NearCall(cs12, 0x1A87, unknown_19EF_1AF4_1B9E4);
    CheckExternalEvents(cs12, 0x1A8B);
    // ADD DI,word ptr [0xa452] (19EF_1A87 / 0x1B977)
    DI += UInt16[DS, 0xA452];
    CheckExternalEvents(cs12, 0x1A8C);
    // INC BX (19EF_1A8B / 0x1B97B)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs12, 0x1A8D);
    // POP CX (19EF_1A8C / 0x1B97C)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1A8F);
    // LOOP 0x1000:b971 (19EF_1A8D / 0x1B97D)
    if(--CX != 0) {
      goto label_19EF_1A81_1B971;
    }
    CheckExternalEvents(cs12, 0x1A95);
    // TEST word ptr [0xa44b],0x1 (19EF_1A8F / 0x1B97F)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs12, 0x1A97);
    // JNZ 0x1000:b991 (19EF_1A95 / 0x1B985)
    if(!ZeroFlag) {
      goto label_19EF_1AA1_1B991;
    }
    CheckExternalEvents(cs12, 0x1A99);
    // MOV DH,byte ptr [BX] (19EF_1A97 / 0x1B987)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x1A9E);
    // MOV byte ptr [0xa450],0x1 (19EF_1A99 / 0x1B989)
    UInt8[DS, 0xA450] = 0x1;
    CheckExternalEvents(cs12, 0x1AA1);
    // CALL 0x1000:b998 (19EF_1A9E / 0x1B98E)
    NearCall(cs12, 0x1AA1, unknown_19EF_1AA8_1B998);
    label_19EF_1AA1_1B991:
    CheckExternalEvents(cs12, 0x1AA2);
    // POP ES (19EF_1AA1 / 0x1B991)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1AA3);
    // POP BP (19EF_1AA2 / 0x1B992)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1AA4);
    // POP DS (19EF_1AA3 / 0x1B993)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1AA5);
    // POP SI (19EF_1AA4 / 0x1B994)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1AA6);
    // POP DI (19EF_1AA5 / 0x1B995)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1AA7);
    // POP BP (19EF_1AA6 / 0x1B996)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1AA8);
    // RETF  (19EF_1AA7 / 0x1B997)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1AA8_1B998(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1AA8_1B998:
    CheckExternalEvents(cs12, 0x1AAA);
    // MOV BP,BX (19EF_1AA8 / 0x1B998)
    BP = BX;
    CheckExternalEvents(cs12, 0x1AAB);
    // PUSH DI (19EF_1AAA / 0x1B99A)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1AAD);
    // XOR DL,DL (19EF_1AAB / 0x1B99B)
    DL = 0;
    CheckExternalEvents(cs12, 0x1AB2);
    // CMP word ptr [0xb764],0x2 (19EF_1AAD / 0x1B99D)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs12, 0x1AB4);
    // JZ 0x1000:b9b7 (19EF_1AB2 / 0x1B9A2)
    if(ZeroFlag) {
      goto label_19EF_1AC7_1B9B7;
    }
    CheckExternalEvents(cs12, 0x1AB6);
    // SHR DX,0x1 (19EF_1AB4 / 0x1B9A4)
    DX >>= 0x1;
    CheckExternalEvents(cs12, 0x1ABA);
    // ADD DX,word ptr [0x26e] (19EF_1AB6 / 0x1B9A6)
    // DX += UInt16[DS, 0x26E];
    DX = Alu16.Add(DX, UInt16[DS, 0x26E]);
    CheckExternalEvents(cs12, 0x1ABC);
    // MOV SI,DX (19EF_1ABA / 0x1B9AA)
    SI = DX;
    CheckExternalEvents(cs12, 0x1AC0);
    // MOV DX,word ptr [0x270] (19EF_1ABC / 0x1B9AC)
    DX = UInt16[DS, 0x270];
    CheckExternalEvents(cs12, 0x1AC3);
    // CALL 0x1000:baec (19EF_1AC0 / 0x1B9B0)
    NearCall(cs12, 0x1AC3, unknown_19EF_1BFC_1BAEC);
    CheckExternalEvents(cs12, 0x1AC4);
    // POP DI (19EF_1AC3 / 0x1B9B3)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1AC6);
    // MOV BX,BP (19EF_1AC4 / 0x1B9B4)
    BX = BP;
    CheckExternalEvents(cs12, 0x1AC7);
    // RET  (19EF_1AC6 / 0x1B9B6)
    return NearRet();
    label_19EF_1AC7_1B9B7:
    CheckExternalEvents(cs12, 0x1ACA);
    // CALL 0x1000:bb73 (19EF_1AC7 / 0x1B9B7)
    NearCall(cs12, 0x1ACA, ghidra_guess_1000_BB73_1BB73);
    CheckExternalEvents(cs12, 0x1ACB);
    // POP DI (19EF_1ACA / 0x1B9BA)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1ACD);
    // MOV BX,BP (19EF_1ACB / 0x1B9BB)
    BX = BP;
    CheckExternalEvents(cs12, 0x1ACE);
    // RET  (19EF_1ACD / 0x1B9BD)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1ACE_1B9BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1ACE_1B9BE:
    CheckExternalEvents(cs12, 0x1AD0);
    // MOV BP,BX (19EF_1ACE / 0x1B9BE)
    BP = BX;
    CheckExternalEvents(cs12, 0x1AD1);
    // PUSH DI (19EF_1AD0 / 0x1B9C0)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1AD3);
    // XOR DL,DL (19EF_1AD1 / 0x1B9C1)
    DL = 0;
    CheckExternalEvents(cs12, 0x1AD8);
    // CMP word ptr [0xb764],0x2 (19EF_1AD3 / 0x1B9C3)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs12, 0x1ADA);
    // JZ 0x1000:b9dd (19EF_1AD8 / 0x1B9C8)
    if(ZeroFlag) {
      goto label_19EF_1AED_1B9DD;
    }
    CheckExternalEvents(cs12, 0x1ADC);
    // SHR DX,0x1 (19EF_1ADA / 0x1B9CA)
    DX >>= 0x1;
    CheckExternalEvents(cs12, 0x1AE0);
    // ADD DX,word ptr [0x26e] (19EF_1ADC / 0x1B9CC)
    // DX += UInt16[DS, 0x26E];
    DX = Alu16.Add(DX, UInt16[DS, 0x26E]);
    CheckExternalEvents(cs12, 0x1AE2);
    // MOV SI,DX (19EF_1AE0 / 0x1B9D0)
    SI = DX;
    CheckExternalEvents(cs12, 0x1AE6);
    // MOV DX,word ptr [0x270] (19EF_1AE2 / 0x1B9D2)
    DX = UInt16[DS, 0x270];
    CheckExternalEvents(cs12, 0x1AE9);
    // CALL 0x1000:ba84 (19EF_1AE6 / 0x1B9D6)
    NearCall(cs12, 0x1AE9, unknown_19EF_1B94_1BA84);
    CheckExternalEvents(cs12, 0x1AEA);
    // POP DI (19EF_1AE9 / 0x1B9D9)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1AEC);
    // MOV BX,BP (19EF_1AEA / 0x1B9DA)
    BX = BP;
    CheckExternalEvents(cs12, 0x1AED);
    // RET  (19EF_1AEC / 0x1B9DC)
    return NearRet();
    label_19EF_1AED_1B9DD:
    CheckExternalEvents(cs12, 0x1AF0);
    // CALL 0x1000:bacf (19EF_1AED / 0x1B9DD)
    NearCall(cs12, 0x1AF0, ghidra_guess_1000_BACF_1BACF);
    CheckExternalEvents(cs12, 0x1AF1);
    // POP DI (19EF_1AF0 / 0x1B9E0)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1AF3);
    // MOV BX,BP (19EF_1AF1 / 0x1B9E1)
    BX = BP;
    CheckExternalEvents(cs12, 0x1AF4);
    // RET  (19EF_1AF3 / 0x1B9E3)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1AF4_1B9E4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1AF4_1B9E4:
    CheckExternalEvents(cs12, 0x1AF6);
    // MOV BP,BX (19EF_1AF4 / 0x1B9E4)
    BP = BX;
    CheckExternalEvents(cs12, 0x1AF7);
    // PUSH DI (19EF_1AF6 / 0x1B9E6)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1AF9);
    // XOR DL,DL (19EF_1AF7 / 0x1B9E7)
    DL = 0;
    CheckExternalEvents(cs12, 0x1AFE);
    // CMP word ptr [0xb764],0x2 (19EF_1AF9 / 0x1B9E9)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs12, 0x1B00);
    // JZ 0x1000:ba03 (19EF_1AFE / 0x1B9EE)
    if(ZeroFlag) {
      goto label_19EF_1B13_1BA03;
    }
    CheckExternalEvents(cs12, 0x1B02);
    // SHR DX,0x1 (19EF_1B00 / 0x1B9F0)
    DX >>= 0x1;
    CheckExternalEvents(cs12, 0x1B06);
    // ADD DX,word ptr [0x26e] (19EF_1B02 / 0x1B9F2)
    // DX += UInt16[DS, 0x26E];
    DX = Alu16.Add(DX, UInt16[DS, 0x26E]);
    CheckExternalEvents(cs12, 0x1B08);
    // MOV SI,DX (19EF_1B06 / 0x1B9F6)
    SI = DX;
    CheckExternalEvents(cs12, 0x1B0C);
    // MOV DX,word ptr [0x270] (19EF_1B08 / 0x1B9F8)
    DX = UInt16[DS, 0x270];
    CheckExternalEvents(cs12, 0x1B0F);
    // CALL 0x1000:ba0a (19EF_1B0C / 0x1B9FC)
    NearCall(cs12, 0x1B0F, unknown_19EF_1B1A_1BA0A);
    CheckExternalEvents(cs12, 0x1B10);
    // POP DI (19EF_1B0F / 0x1B9FF)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1B12);
    // MOV BX,BP (19EF_1B10 / 0x1BA00)
    BX = BP;
    CheckExternalEvents(cs12, 0x1B13);
    // RET  (19EF_1B12 / 0x1BA02)
    return NearRet();
    label_19EF_1B13_1BA03:
    CheckExternalEvents(cs12, 0x1B16);
    // CALL 0x1000:ba61 (19EF_1B13 / 0x1BA03)
    NearCall(cs12, 0x1B16, ghidra_guess_1000_BA61_1BA61);
    CheckExternalEvents(cs12, 0x1B17);
    // POP DI (19EF_1B16 / 0x1BA06)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1B19);
    // MOV BX,BP (19EF_1B17 / 0x1BA07)
    BX = BP;
    CheckExternalEvents(cs12, 0x1B1A);
    // RET  (19EF_1B19 / 0x1BA09)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1B1A_1BA0A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1B1A_1BA0A:
    CheckExternalEvents(cs12, 0x1B1F);
    // CMP word ptr [0xb764],0x0 (19EF_1B1A / 0x1BA0A)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs12, 0x1B21);
    // JZ 0x1000:ba44 (19EF_1B1F / 0x1BA0F)
    if(ZeroFlag) {
      goto label_19EF_1B54_1BA44;
    }
    CheckExternalEvents(cs12, 0x1B24);
    // MOV CX,0x4 (19EF_1B21 / 0x1BA11)
    CX = 0x4;
    CheckExternalEvents(cs12, 0x1B29);
    // CMP byte ptr [0xa44f],0x0 (19EF_1B24 / 0x1BA14)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs12, 0x1B2B);
    // JZ 0x1000:ba1d (19EF_1B29 / 0x1BA19)
    if(ZeroFlag) {
      goto label_19EF_1B2D_1BA1D;
    }
    CheckExternalEvents(cs12, 0x1B2D);
    // SHR CX,0x1 (19EF_1B2B / 0x1BA1B)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_19EF_1B2D_1BA1D:
    CheckExternalEvents(cs12, 0x1B2E);
    // PUSH DS (19EF_1B2D / 0x1BA1D)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1B30);
    // MOV DS,DX (19EF_1B2E / 0x1BA1E)
    DS = DX;
    label_19EF_1B30_1BA20:
    CheckExternalEvents(cs12, 0x1B31);
    // MOVSW ES:DI,SI (19EF_1B30 / 0x1BA20)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B32);
    // MOVSW ES:DI,SI (19EF_1B31 / 0x1BA21)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B33);
    // MOVSW ES:DI,SI (19EF_1B32 / 0x1BA22)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B34);
    // MOVSW ES:DI,SI (19EF_1B33 / 0x1BA23)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B38);
    // ADD DI,0x98 (19EF_1B34 / 0x1BA24)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs12, 0x1B39);
    // MOVSW ES:DI,SI (19EF_1B38 / 0x1BA28)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B3A);
    // MOVSW ES:DI,SI (19EF_1B39 / 0x1BA29)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B3B);
    // MOVSW ES:DI,SI (19EF_1B3A / 0x1BA2A)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B3C);
    // MOVSW ES:DI,SI (19EF_1B3B / 0x1BA2B)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B40);
    // ADD DI,0x98 (19EF_1B3C / 0x1BA2C)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs12, 0x1B41);
    // MOVSW ES:DI,SI (19EF_1B40 / 0x1BA30)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B42);
    // MOVSW ES:DI,SI (19EF_1B41 / 0x1BA31)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B43);
    // MOVSW ES:DI,SI (19EF_1B42 / 0x1BA32)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B44);
    // MOVSW ES:DI,SI (19EF_1B43 / 0x1BA33)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B48);
    // ADD DI,0x98 (19EF_1B44 / 0x1BA34)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs12, 0x1B49);
    // MOVSW ES:DI,SI (19EF_1B48 / 0x1BA38)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B4A);
    // MOVSW ES:DI,SI (19EF_1B49 / 0x1BA39)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B4B);
    // MOVSW ES:DI,SI (19EF_1B4A / 0x1BA3A)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B4C);
    // MOVSW ES:DI,SI (19EF_1B4B / 0x1BA3B)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B50);
    // ADD DI,0x98 (19EF_1B4C / 0x1BA3C)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs12, 0x1B52);
    // LOOP 0x1000:ba20 (19EF_1B50 / 0x1BA40)
    if(--CX != 0) {
      goto label_19EF_1B30_1BA20;
    }
    CheckExternalEvents(cs12, 0x1B53);
    // POP DS (19EF_1B52 / 0x1BA42)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1B54);
    // RET  (19EF_1B53 / 0x1BA43)
    return NearRet();
    label_19EF_1B54_1BA44:
    CheckExternalEvents(cs12, 0x1B57);
    // MOV CX,0x8 (19EF_1B54 / 0x1BA44)
    CX = 0x8;
    CheckExternalEvents(cs12, 0x1B5C);
    // CMP byte ptr [0xa44f],0x0 (19EF_1B57 / 0x1BA47)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs12, 0x1B5E);
    // JZ 0x1000:ba50 (19EF_1B5C / 0x1BA4C)
    if(ZeroFlag) {
      goto label_19EF_1B60_1BA50;
    }
    CheckExternalEvents(cs12, 0x1B60);
    // SHR CX,0x1 (19EF_1B5E / 0x1BA4E)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_19EF_1B60_1BA50:
    CheckExternalEvents(cs12, 0x1B61);
    // PUSH DS (19EF_1B60 / 0x1BA50)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1B63);
    // MOV DS,DX (19EF_1B61 / 0x1BA51)
    DS = DX;
    label_19EF_1B63_1BA53:
    CheckExternalEvents(cs12, 0x1B64);
    // MOVSW ES:DI,SI (19EF_1B63 / 0x1BA53)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B65);
    // MOVSW ES:DI,SI (19EF_1B64 / 0x1BA54)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B68);
    // ADD DI,0x4c (19EF_1B65 / 0x1BA55)
    // DI += 0x4C;
    DI = Alu16.Add(DI, 0x4C);
    CheckExternalEvents(cs12, 0x1B69);
    // MOVSW ES:DI,SI (19EF_1B68 / 0x1BA58)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B6A);
    // MOVSW ES:DI,SI (19EF_1B69 / 0x1BA59)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1B6D);
    // ADD DI,0x4c (19EF_1B6A / 0x1BA5A)
    // DI += 0x4C;
    DI = Alu16.Add(DI, 0x4C);
    CheckExternalEvents(cs12, 0x1B6F);
    // LOOP 0x1000:ba53 (19EF_1B6D / 0x1BA5D)
    if(--CX != 0) {
      goto label_19EF_1B63_1BA53;
    }
    CheckExternalEvents(cs12, 0x1B70);
    // POP DS (19EF_1B6F / 0x1BA5F)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1B71);
    // RET  (19EF_1B70 / 0x1BA60)
    return NearRet();
  }
  
  public virtual Action ghidra_guess_1000_BA61_1BA61(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BA61_1BA61:
    CheckExternalEvents(cs7, 0xBA63);
    // SHR DX,0x1 (1000_BA61 / 0x1BA61)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xBA65);
    // SHR DX,0x1 (1000_BA63 / 0x1BA63)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xBA67);
    // SHR DX,0x1 (1000_BA65 / 0x1BA65)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs7, 0xBA69);
    // MOV SI,DX (1000_BA67 / 0x1BA67)
    SI = DX;
    CheckExternalEvents(cs7, 0xBA6C);
    // MOV CX,0x10 (1000_BA69 / 0x1BA69)
    CX = 0x10;
    CheckExternalEvents(cs7, 0xBA71);
    // CMP byte ptr [0xa44f],0x0 (1000_BA6C / 0x1BA6C)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs7, 0xBA73);
    // JZ 0x1000:ba75 (1000_BA71 / 0x1BA71)
    if(ZeroFlag) {
      goto label_1000_BA75_1BA75;
    }
    CheckExternalEvents(cs7, 0xBA75);
    // SHR CX,0x1 (1000_BA73 / 0x1BA73)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_1000_BA75_1BA75:
    CheckExternalEvents(cs7, 0xBA76);
    // PUSH DS (1000_BA75 / 0x1BA75)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xBA79);
    // MOV AX,0xa400 (1000_BA76 / 0x1BA76)
    AX = 0xA400;
    CheckExternalEvents(cs7, 0xBA7B);
    // MOV DS,AX (1000_BA79 / 0x1BA79)
    DS = AX;
    label_1000_BA7B_1BA7B:
    CheckExternalEvents(cs7, 0xBA7C);
    // MOVSB ES:DI,SI (1000_BA7B / 0x1BA7B)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xBA7D);
    // MOVSB ES:DI,SI (1000_BA7C / 0x1BA7C)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xBA80);
    // ADD DI,0x26 (1000_BA7D / 0x1BA7D)
    // DI += 0x26;
    DI = Alu16.Add(DI, 0x26);
    CheckExternalEvents(cs7, 0xBA82);
    // LOOP 0x1000:ba7b (1000_BA80 / 0x1BA80)
    if(--CX != 0) {
      goto label_1000_BA7B_1BA7B;
    }
    CheckExternalEvents(cs7, 0xBA83);
    // POP DS (1000_BA82 / 0x1BA82)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBA84);
    // RET  (1000_BA83 / 0x1BA83)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1B94_1BA84(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1B94_1BA84:
    CheckExternalEvents(cs12, 0x1B99);
    // CMP word ptr [0xb764],0x0 (19EF_1B94 / 0x1BA84)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs12, 0x1B9B);
    // JZ 0x1000:bab8 (19EF_1B99 / 0x1BA89)
    if(ZeroFlag) {
      goto label_19EF_1BC8_1BAB8;
    }
    CheckExternalEvents(cs12, 0x1B9E);
    // ADD SI,0x40 (19EF_1B9B / 0x1BA8B)
    // SI += 0x40;
    SI = Alu16.Add(SI, 0x40);
    CheckExternalEvents(cs12, 0x1BA1);
    // MOV CX,0x2 (19EF_1B9E / 0x1BA8E)
    CX = 0x2;
    CheckExternalEvents(cs12, 0x1BA2);
    // PUSH DS (19EF_1BA1 / 0x1BA91)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1BA4);
    // MOV DS,DX (19EF_1BA2 / 0x1BA92)
    DS = DX;
    label_19EF_1BA4_1BA94:
    CheckExternalEvents(cs12, 0x1BA5);
    // MOVSW ES:DI,SI (19EF_1BA4 / 0x1BA94)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BA6);
    // MOVSW ES:DI,SI (19EF_1BA5 / 0x1BA95)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BA7);
    // MOVSW ES:DI,SI (19EF_1BA6 / 0x1BA96)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BA8);
    // MOVSW ES:DI,SI (19EF_1BA7 / 0x1BA97)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BAC);
    // ADD DI,0x98 (19EF_1BA8 / 0x1BA98)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs12, 0x1BAD);
    // MOVSW ES:DI,SI (19EF_1BAC / 0x1BA9C)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BAE);
    // MOVSW ES:DI,SI (19EF_1BAD / 0x1BA9D)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BAF);
    // MOVSW ES:DI,SI (19EF_1BAE / 0x1BA9E)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BB0);
    // MOVSW ES:DI,SI (19EF_1BAF / 0x1BA9F)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BB4);
    // ADD DI,0x98 (19EF_1BB0 / 0x1BAA0)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs12, 0x1BB5);
    // MOVSW ES:DI,SI (19EF_1BB4 / 0x1BAA4)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BB6);
    // MOVSW ES:DI,SI (19EF_1BB5 / 0x1BAA5)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BB7);
    // MOVSW ES:DI,SI (19EF_1BB6 / 0x1BAA6)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BB8);
    // MOVSW ES:DI,SI (19EF_1BB7 / 0x1BAA7)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BBC);
    // ADD DI,0x98 (19EF_1BB8 / 0x1BAA8)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs12, 0x1BBD);
    // MOVSW ES:DI,SI (19EF_1BBC / 0x1BAAC)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BBE);
    // MOVSW ES:DI,SI (19EF_1BBD / 0x1BAAD)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BBF);
    // MOVSW ES:DI,SI (19EF_1BBE / 0x1BAAE)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BC0);
    // MOVSW ES:DI,SI (19EF_1BBF / 0x1BAAF)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BC4);
    // ADD DI,0x98 (19EF_1BC0 / 0x1BAB0)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs12, 0x1BC6);
    // LOOP 0x1000:ba94 (19EF_1BC4 / 0x1BAB4)
    if(--CX != 0) {
      goto label_19EF_1BA4_1BA94;
    }
    CheckExternalEvents(cs12, 0x1BC7);
    // POP DS (19EF_1BC6 / 0x1BAB6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1BC8);
    // RET  (19EF_1BC7 / 0x1BAB7)
    return NearRet();
    label_19EF_1BC8_1BAB8:
    CheckExternalEvents(cs12, 0x1BCB);
    // ADD SI,0x20 (19EF_1BC8 / 0x1BAB8)
    // SI += 0x20;
    SI = Alu16.Add(SI, 0x20);
    CheckExternalEvents(cs12, 0x1BCE);
    // MOV CX,0x4 (19EF_1BCB / 0x1BABB)
    CX = 0x4;
    CheckExternalEvents(cs12, 0x1BCF);
    // PUSH DS (19EF_1BCE / 0x1BABE)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1BD1);
    // MOV DS,DX (19EF_1BCF / 0x1BABF)
    DS = DX;
    label_19EF_1BD1_1BAC1:
    CheckExternalEvents(cs12, 0x1BD2);
    // MOVSW ES:DI,SI (19EF_1BD1 / 0x1BAC1)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BD3);
    // MOVSW ES:DI,SI (19EF_1BD2 / 0x1BAC2)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BD6);
    // ADD DI,0x4c (19EF_1BD3 / 0x1BAC3)
    // DI += 0x4C;
    DI = Alu16.Add(DI, 0x4C);
    CheckExternalEvents(cs12, 0x1BD7);
    // MOVSW ES:DI,SI (19EF_1BD6 / 0x1BAC6)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BD8);
    // MOVSW ES:DI,SI (19EF_1BD7 / 0x1BAC7)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1BDB);
    // ADD DI,0x4c (19EF_1BD8 / 0x1BAC8)
    // DI += 0x4C;
    DI = Alu16.Add(DI, 0x4C);
    CheckExternalEvents(cs12, 0x1BDD);
    // LOOP 0x1000:bac1 (19EF_1BDB / 0x1BACB)
    if(--CX != 0) {
      goto label_19EF_1BD1_1BAC1;
    }
    CheckExternalEvents(cs12, 0x1BDE);
    // POP DS (19EF_1BDD / 0x1BACD)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1BDF);
    // RET  (19EF_1BDE / 0x1BACE)
    return NearRet();
  }
  
  public virtual Action ghidra_guess_1000_BACF_1BACF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BACF_1BACF:
    CheckExternalEvents(cs7, 0xBAD1);
    // SHR DX,0x1 (1000_BACF / 0x1BACF)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xBAD3);
    // SHR DX,0x1 (1000_BAD1 / 0x1BAD1)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xBAD5);
    // SHR DX,0x1 (1000_BAD3 / 0x1BAD3)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xBAD8);
    // ADD DX,0x10 (1000_BAD5 / 0x1BAD5)
    // DX += 0x10;
    DX = Alu16.Add(DX, 0x10);
    CheckExternalEvents(cs7, 0xBADA);
    // MOV SI,DX (1000_BAD8 / 0x1BAD8)
    SI = DX;
    CheckExternalEvents(cs7, 0xBADD);
    // MOV CX,0x8 (1000_BADA / 0x1BADA)
    CX = 0x8;
    CheckExternalEvents(cs7, 0xBADE);
    // PUSH DS (1000_BADD / 0x1BADD)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xBAE1);
    // MOV AX,0xa400 (1000_BADE / 0x1BADE)
    AX = 0xA400;
    CheckExternalEvents(cs7, 0xBAE3);
    // MOV DS,AX (1000_BAE1 / 0x1BAE1)
    DS = AX;
    label_1000_BAE3_1BAE3:
    CheckExternalEvents(cs7, 0xBAE4);
    // MOVSB ES:DI,SI (1000_BAE3 / 0x1BAE3)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xBAE5);
    // MOVSB ES:DI,SI (1000_BAE4 / 0x1BAE4)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xBAE8);
    // ADD DI,0x26 (1000_BAE5 / 0x1BAE5)
    // DI += 0x26;
    DI = Alu16.Add(DI, 0x26);
    CheckExternalEvents(cs7, 0xBAEA);
    // LOOP 0x1000:bae3 (1000_BAE8 / 0x1BAE8)
    if(--CX != 0) {
      goto label_1000_BAE3_1BAE3;
    }
    CheckExternalEvents(cs7, 0xBAEB);
    // POP DS (1000_BAEA / 0x1BAEA)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBAEC);
    // RET  (1000_BAEB / 0x1BAEB)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1BFC_1BAEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1BFC_1BAEC:
    CheckExternalEvents(cs12, 0x1C01);
    // CMP word ptr [0xb764],0x0 (19EF_1BFC / 0x1BAEC)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs12, 0x1C03);
    // JZ 0x1000:bb3e (19EF_1C01 / 0x1BAF1)
    if(ZeroFlag) {
      goto label_19EF_1C4E_1BB3E;
    }
    CheckExternalEvents(cs12, 0x1C08);
    // CMP byte ptr [0xa451],0x0 (19EF_1C03 / 0x1BAF3)
    Alu8.Sub(UInt8[DS, 0xA451], 0x0);
    CheckExternalEvents(cs12, 0x1C0A);
    // JZ 0x1000:bafd (19EF_1C08 / 0x1BAF8)
    if(ZeroFlag) {
      goto label_19EF_1C0D_1BAFD;
    }
    CheckExternalEvents(cs12, 0x1C0D);
    // ADD SI,0x40 (19EF_1C0A / 0x1BAFA)
    SI += 0x40;
    label_19EF_1C0D_1BAFD:
    CheckExternalEvents(cs12, 0x1C12);
    // CMP byte ptr [0xa450],0x0 (19EF_1C0D / 0x1BAFD)
    Alu8.Sub(UInt8[DS, 0xA450], 0x0);
    CheckExternalEvents(cs12, 0x1C14);
    // JNZ 0x1000:bb07 (19EF_1C12 / 0x1BB02)
    if(!ZeroFlag) {
      goto label_19EF_1C17_1BB07;
    }
    CheckExternalEvents(cs12, 0x1C17);
    // ADD SI,0x4 (19EF_1C14 / 0x1BB04)
    // SI += 0x4;
    SI = Alu16.Add(SI, 0x4);
    label_19EF_1C17_1BB07:
    CheckExternalEvents(cs12, 0x1C1A);
    // MOV CX,0x4 (19EF_1C17 / 0x1BB07)
    CX = 0x4;
    CheckExternalEvents(cs12, 0x1C1F);
    // CMP byte ptr [0xa44f],0x0 (19EF_1C1A / 0x1BB0A)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs12, 0x1C21);
    // JZ 0x1000:bb13 (19EF_1C1F / 0x1BB0F)
    if(ZeroFlag) {
      goto label_19EF_1C23_1BB13;
    }
    CheckExternalEvents(cs12, 0x1C23);
    // SHR CX,0x1 (19EF_1C21 / 0x1BB11)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_19EF_1C23_1BB13:
    CheckExternalEvents(cs12, 0x1C24);
    // PUSH DS (19EF_1C23 / 0x1BB13)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1C26);
    // MOV DS,DX (19EF_1C24 / 0x1BB14)
    DS = DX;
    label_19EF_1C26_1BB16:
    CheckExternalEvents(cs12, 0x1C27);
    // MOVSW ES:DI,SI (19EF_1C26 / 0x1BB16)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1C28);
    // MOVSW ES:DI,SI (19EF_1C27 / 0x1BB17)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1C2B);
    // ADD SI,0x4 (19EF_1C28 / 0x1BB18)
    SI += 0x4;
    CheckExternalEvents(cs12, 0x1C2F);
    // ADD DI,0x9c (19EF_1C2B / 0x1BB1B)
    // DI += 0x9C;
    DI = Alu16.Add(DI, 0x9C);
    CheckExternalEvents(cs12, 0x1C30);
    // MOVSW ES:DI,SI (19EF_1C2F / 0x1BB1F)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1C31);
    // MOVSW ES:DI,SI (19EF_1C30 / 0x1BB20)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1C34);
    // ADD SI,0x4 (19EF_1C31 / 0x1BB21)
    SI += 0x4;
    CheckExternalEvents(cs12, 0x1C38);
    // ADD DI,0x9c (19EF_1C34 / 0x1BB24)
    // DI += 0x9C;
    DI = Alu16.Add(DI, 0x9C);
    CheckExternalEvents(cs12, 0x1C39);
    // MOVSW ES:DI,SI (19EF_1C38 / 0x1BB28)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1C3A);
    // MOVSW ES:DI,SI (19EF_1C39 / 0x1BB29)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1C3D);
    // ADD SI,0x4 (19EF_1C3A / 0x1BB2A)
    SI += 0x4;
    CheckExternalEvents(cs12, 0x1C41);
    // ADD DI,0x9c (19EF_1C3D / 0x1BB2D)
    // DI += 0x9C;
    DI = Alu16.Add(DI, 0x9C);
    CheckExternalEvents(cs12, 0x1C42);
    // MOVSW ES:DI,SI (19EF_1C41 / 0x1BB31)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1C43);
    // MOVSW ES:DI,SI (19EF_1C42 / 0x1BB32)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1C46);
    // ADD SI,0x4 (19EF_1C43 / 0x1BB33)
    SI += 0x4;
    CheckExternalEvents(cs12, 0x1C4A);
    // ADD DI,0x9c (19EF_1C46 / 0x1BB36)
    // DI += 0x9C;
    DI = Alu16.Add(DI, 0x9C);
    CheckExternalEvents(cs12, 0x1C4C);
    // LOOP 0x1000:bb16 (19EF_1C4A / 0x1BB3A)
    if(--CX != 0) {
      goto label_19EF_1C26_1BB16;
    }
    CheckExternalEvents(cs12, 0x1C4D);
    // POP DS (19EF_1C4C / 0x1BB3C)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1C4E);
    // RET  (19EF_1C4D / 0x1BB3D)
    return NearRet();
    label_19EF_1C4E_1BB3E:
    CheckExternalEvents(cs12, 0x1C53);
    // CMP byte ptr [0xa451],0x0 (19EF_1C4E / 0x1BB3E)
    Alu8.Sub(UInt8[DS, 0xA451], 0x0);
    CheckExternalEvents(cs12, 0x1C55);
    // JZ 0x1000:bb48 (19EF_1C53 / 0x1BB43)
    if(ZeroFlag) {
      goto label_19EF_1C58_1BB48;
    }
    CheckExternalEvents(cs12, 0x1C58);
    // ADD SI,0x20 (19EF_1C55 / 0x1BB45)
    SI += 0x20;
    label_19EF_1C58_1BB48:
    CheckExternalEvents(cs12, 0x1C5D);
    // CMP byte ptr [0xa450],0x0 (19EF_1C58 / 0x1BB48)
    Alu8.Sub(UInt8[DS, 0xA450], 0x0);
    CheckExternalEvents(cs12, 0x1C5F);
    // JNZ 0x1000:bb52 (19EF_1C5D / 0x1BB4D)
    if(!ZeroFlag) {
      goto label_19EF_1C62_1BB52;
    }
    CheckExternalEvents(cs12, 0x1C62);
    // ADD SI,0x2 (19EF_1C5F / 0x1BB4F)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    label_19EF_1C62_1BB52:
    CheckExternalEvents(cs12, 0x1C65);
    // MOV CX,0x8 (19EF_1C62 / 0x1BB52)
    CX = 0x8;
    CheckExternalEvents(cs12, 0x1C6A);
    // CMP byte ptr [0xa44f],0x0 (19EF_1C65 / 0x1BB55)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs12, 0x1C6C);
    // JZ 0x1000:bb5e (19EF_1C6A / 0x1BB5A)
    if(ZeroFlag) {
      goto label_19EF_1C6E_1BB5E;
    }
    CheckExternalEvents(cs12, 0x1C6E);
    // SHR CX,0x1 (19EF_1C6C / 0x1BB5C)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_19EF_1C6E_1BB5E:
    CheckExternalEvents(cs12, 0x1C6F);
    // PUSH DS (19EF_1C6E / 0x1BB5E)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1C71);
    // MOV DS,DX (19EF_1C6F / 0x1BB5F)
    DS = DX;
    label_19EF_1C71_1BB61:
    CheckExternalEvents(cs12, 0x1C72);
    // MOVSW ES:DI,SI (19EF_1C71 / 0x1BB61)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1C75);
    // ADD DI,0x4e (19EF_1C72 / 0x1BB62)
    DI += 0x4E;
    CheckExternalEvents(cs12, 0x1C78);
    // ADD SI,0x2 (19EF_1C75 / 0x1BB65)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs12, 0x1C79);
    // MOVSW ES:DI,SI (19EF_1C78 / 0x1BB68)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1C7C);
    // ADD DI,0x4e (19EF_1C79 / 0x1BB69)
    DI += 0x4E;
    CheckExternalEvents(cs12, 0x1C7F);
    // ADD SI,0x2 (19EF_1C7C / 0x1BB6C)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs12, 0x1C81);
    // LOOP 0x1000:bb61 (19EF_1C7F / 0x1BB6F)
    if(--CX != 0) {
      goto label_19EF_1C71_1BB61;
    }
    CheckExternalEvents(cs12, 0x1C82);
    // POP DS (19EF_1C81 / 0x1BB71)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1C83);
    // RET  (19EF_1C82 / 0x1BB72)
    return NearRet();
  }
  
  public virtual Action ghidra_guess_1000_BB73_1BB73(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BB73_1BB73:
    CheckExternalEvents(cs7, 0xBB75);
    // SHR DX,0x1 (1000_BB73 / 0x1BB73)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xBB77);
    // SHR DX,0x1 (1000_BB75 / 0x1BB75)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xBB79);
    // SHR DX,0x1 (1000_BB77 / 0x1BB77)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xBB7E);
    // CMP byte ptr [0xa451],0x0 (1000_BB79 / 0x1BB79)
    Alu8.Sub(UInt8[DS, 0xA451], 0x0);
    CheckExternalEvents(cs7, 0xBB80);
    // JZ 0x1000:bb83 (1000_BB7E / 0x1BB7E)
    if(ZeroFlag) {
      goto label_1000_BB83_1BB83;
    }
    CheckExternalEvents(cs7, 0xBB83);
    // ADD DX,0x10 (1000_BB80 / 0x1BB80)
    DX += 0x10;
    label_1000_BB83_1BB83:
    CheckExternalEvents(cs7, 0xBB88);
    // CMP byte ptr [0xa450],0x0 (1000_BB83 / 0x1BB83)
    Alu8.Sub(UInt8[DS, 0xA450], 0x0);
    CheckExternalEvents(cs7, 0xBB8A);
    // JNZ 0x1000:bb8b (1000_BB88 / 0x1BB88)
    if(!ZeroFlag) {
      goto label_1000_BB8B_1BB8B;
    }
    CheckExternalEvents(cs7, 0xBB8B);
    // INC DX (1000_BB8A / 0x1BB8A)
    DX = Alu16.Inc(DX);
    label_1000_BB8B_1BB8B:
    CheckExternalEvents(cs7, 0xBB8D);
    // MOV SI,DX (1000_BB8B / 0x1BB8B)
    SI = DX;
    CheckExternalEvents(cs7, 0xBB90);
    // MOV CX,0x10 (1000_BB8D / 0x1BB8D)
    CX = 0x10;
    CheckExternalEvents(cs7, 0xBB95);
    // CMP byte ptr [0xa44f],0x0 (1000_BB90 / 0x1BB90)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs7, 0xBB97);
    // JZ 0x1000:bb99 (1000_BB95 / 0x1BB95)
    if(ZeroFlag) {
      goto label_1000_BB99_1BB99;
    }
    CheckExternalEvents(cs7, 0xBB99);
    // SHR CX,0x1 (1000_BB97 / 0x1BB97)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_1000_BB99_1BB99:
    CheckExternalEvents(cs7, 0xBB9A);
    // PUSH DS (1000_BB99 / 0x1BB99)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xBB9D);
    // MOV AX,0xa400 (1000_BB9A / 0x1BB9A)
    AX = 0xA400;
    CheckExternalEvents(cs7, 0xBB9F);
    // MOV DS,AX (1000_BB9D / 0x1BB9D)
    DS = AX;
    label_1000_BB9F_1BB9F:
    CheckExternalEvents(cs7, 0xBBA0);
    // MOVSB ES:DI,SI (1000_BB9F / 0x1BB9F)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xBBA1);
    // INC SI (1000_BBA0 / 0x1BBA0)
    SI++;
    CheckExternalEvents(cs7, 0xBBA4);
    // ADD DI,0x27 (1000_BBA1 / 0x1BBA1)
    // DI += 0x27;
    DI = Alu16.Add(DI, 0x27);
    CheckExternalEvents(cs7, 0xBBA6);
    // LOOP 0x1000:bb9f (1000_BBA4 / 0x1BBA4)
    if(--CX != 0) {
      goto label_1000_BB9F_1BB9F;
    }
    CheckExternalEvents(cs7, 0xBBA7);
    // POP DS (1000_BBA6 / 0x1BBA6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBBA8);
    // RET  (1000_BBA7 / 0x1BBA7)
    return NearRet();
  }
  
  public virtual Action ghidra_guess_1000_BBA8_1BBA8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BBA8_1BBA8:
    CheckExternalEvents(cs7, 0xBBA9);
    // PUSH BP (1000_BBA8 / 0x1BBA8)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xBBAB);
    // MOV BP,SP (1000_BBA9 / 0x1BBA9)
    BP = SP;
    CheckExternalEvents(cs7, 0xBBAC);
    // PUSH DI (1000_BBAB / 0x1BBAB)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xBBAD);
    // PUSH SI (1000_BBAC / 0x1BBAC)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xBBAE);
    // PUSH DS (1000_BBAD / 0x1BBAD)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xBBB1);
    // MOV AX,0x1ddc (1000_BBAE / 0x1BBAE)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xBBB3);
    // MOV DS,AX (1000_BBB1 / 0x1BBB1)
    DS = AX;
    CheckExternalEvents(cs7, 0xBBB4);
    // PUSH ES (1000_BBB3 / 0x1BBB3)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xBBB7);
    // MOV AX,0xb800 (1000_BBB4 / 0x1BBB4)
    AX = 0xB800;
    CheckExternalEvents(cs7, 0xBBB9);
    // MOV ES,AX (1000_BBB7 / 0x1BBB7)
    ES = AX;
    CheckExternalEvents(cs7, 0xBBBC);
    // MOV SI,0x244b (1000_BBB9 / 0x1BBB9)
    SI = 0x244B;
    CheckExternalEvents(cs7, 0xBBC1);
    // CMP word ptr [0xb764],0x0 (1000_BBBC / 0x1BBBC)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs7, 0xBBC3);
    // JZ 0x1000:bc00 (1000_BBC1 / 0x1BBC1)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_BC00_1BC00, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xBBC6);
    // MOV DI,0x34 (1000_BBC3 / 0x1BBC3)
    DI = 0x34;
    CheckExternalEvents(cs7, 0xBBC8);
    // ADD SI,DI (1000_BBC6 / 0x1BBC6)
    // SI += DI;
    SI = Alu16.Add(SI, DI);
    CheckExternalEvents(cs7, 0xBBCB);
    // MOV DX,0x32 (1000_BBC8 / 0x1BBC8)
    DX = 0x32;
    CheckExternalEvents(cs7, 0xBBCE);
    // MOV BX,0x36 (1000_BBCB / 0x1BBCB)
    BX = 0x36;
    label_1000_BBCE_1BBCE:
    CheckExternalEvents(cs7, 0xBBD0);
    // MOV CX,BX (1000_BBCE / 0x1BBCE)
    CX = BX;
    CheckExternalEvents(cs7, 0xBBD2);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BBD0 / 0x1BBD0)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs7, 0xBBD5);
    // ADD SI,0x34 (1000_BBD2 / 0x1BBD2)
    SI += 0x34;
    CheckExternalEvents(cs7, 0xBBD9);
    // ADD DI,0x1f94 (1000_BBD5 / 0x1BBD5)
    // DI += 0x1F94;
    DI = Alu16.Add(DI, 0x1F94);
    CheckExternalEvents(cs7, 0xBBDB);
    // MOV CX,BX (1000_BBD9 / 0x1BBD9)
    CX = BX;
    CheckExternalEvents(cs7, 0xBBDD);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BBDB / 0x1BBDB)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs7, 0xBBE0);
    // ADD SI,0x34 (1000_BBDD / 0x1BBDD)
    SI += 0x34;
    CheckExternalEvents(cs7, 0xBBE4);
    // ADD DI,0x1f94 (1000_BBE0 / 0x1BBE0)
    // DI += 0x1F94;
    DI = Alu16.Add(DI, 0x1F94);
    CheckExternalEvents(cs7, 0xBBE6);
    // MOV CX,BX (1000_BBE4 / 0x1BBE4)
    CX = BX;
    CheckExternalEvents(cs7, 0xBBE8);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BBE6 / 0x1BBE6)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs7, 0xBBEB);
    // ADD SI,0x34 (1000_BBE8 / 0x1BBE8)
    SI += 0x34;
    CheckExternalEvents(cs7, 0xBBEF);
    // ADD DI,0x1f94 (1000_BBEB / 0x1BBEB)
    // DI += 0x1F94;
    DI = Alu16.Add(DI, 0x1F94);
    CheckExternalEvents(cs7, 0xBBF1);
    // MOV CX,BX (1000_BBEF / 0x1BBEF)
    CX = BX;
    CheckExternalEvents(cs7, 0xBBF3);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BBF1 / 0x1BBF1)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs7, 0xBBF6);
    // ADD SI,0x34 (1000_BBF3 / 0x1BBF3)
    SI += 0x34;
    CheckExternalEvents(cs7, 0xBBFA);
    // SUB DI,0x5fcc (1000_BBF6 / 0x1BBF6)
    DI -= 0x5FCC;
    CheckExternalEvents(cs7, 0xBBFB);
    // DEC DX (1000_BBFA / 0x1BBFA)
    DX = Alu16.Dec(DX);
    CheckExternalEvents(cs7, 0xBBFD);
    // JNZ 0x1000:bbce (1000_BBFB / 0x1BBFB)
    if(!ZeroFlag) {
      goto label_1000_BBCE_1BBCE;
    }
    CheckExternalEvents(cs7, 0xBBFF);
    // JMP 0x1000:bc24 (1000_BBFD / 0x1BBFD)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_BC00_1BC00, 0x1BC24 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_BC00_1BC00(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BC00_1BC00:
    CheckExternalEvents(cs7, 0xBC03);
    // MOV DI,0x1a (1000_BC00 / 0x1BC00)
    DI = 0x1A;
    CheckExternalEvents(cs7, 0xBC05);
    // ADD SI,DI (1000_BC03 / 0x1BC03)
    // SI += DI;
    SI = Alu16.Add(SI, DI);
    CheckExternalEvents(cs7, 0xBC07);
    // MOV DL,0x64 (1000_BC05 / 0x1BC05)
    DL = 0x64;
    CheckExternalEvents(cs7, 0xBC0A);
    // MOV BX,0x1b (1000_BC07 / 0x1BC07)
    BX = 0x1B;
    label_1000_BC0A_1BC0A:
    CheckExternalEvents(cs7, 0xBC0C);
    // MOV CX,BX (1000_BC0A / 0x1BC0A)
    CX = BX;
    CheckExternalEvents(cs7, 0xBC0E);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BC0C / 0x1BC0C)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs7, 0xBC11);
    // ADD SI,0x1a (1000_BC0E / 0x1BC0E)
    SI += 0x1A;
    CheckExternalEvents(cs7, 0xBC15);
    // ADD DI,0x1fca (1000_BC11 / 0x1BC11)
    // DI += 0x1FCA;
    DI = Alu16.Add(DI, 0x1FCA);
    CheckExternalEvents(cs7, 0xBC17);
    // MOV CX,BX (1000_BC15 / 0x1BC15)
    CX = BX;
    CheckExternalEvents(cs7, 0xBC19);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BC17 / 0x1BC17)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs7, 0xBC1C);
    // ADD SI,0x1a (1000_BC19 / 0x1BC19)
    SI += 0x1A;
    CheckExternalEvents(cs7, 0xBC20);
    // SUB DI,0x1fe6 (1000_BC1C / 0x1BC1C)
    DI -= 0x1FE6;
    CheckExternalEvents(cs7, 0xBC22);
    // DEC DL (1000_BC20 / 0x1BC20)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs7, 0xBC24);
    // JNZ 0x1000:bc0a (1000_BC22 / 0x1BC22)
    if(!ZeroFlag) {
      goto label_1000_BC0A_1BC0A;
    }
    label_1000_BC24_1BC24:
    CheckExternalEvents(cs7, 0xBC25);
    // POP ES (1000_BC24 / 0x1BC24)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBC26);
    // POP DS (1000_BC25 / 0x1BC25)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBC27);
    // POP SI (1000_BC26 / 0x1BC26)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBC28);
    // POP DI (1000_BC27 / 0x1BC27)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBC29);
    // POP BP (1000_BC28 / 0x1BC28)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBC2A);
    // RETF  (1000_BC29 / 0x1BC29)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1D3A_1BC2A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1D3A_1BC2A:
    CheckExternalEvents(cs12, 0x1D3B);
    // PUSH BP (19EF_1D3A / 0x1BC2A)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x1D3D);
    // MOV BP,SP (19EF_1D3B / 0x1BC2B)
    BP = SP;
    CheckExternalEvents(cs12, 0x1D3E);
    // PUSH DI (19EF_1D3D / 0x1BC2D)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1D3F);
    // PUSH SI (19EF_1D3E / 0x1BC2E)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1D40);
    // PUSH DS (19EF_1D3F / 0x1BC2F)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1D43);
    // MOV AX,0x1ddc (19EF_1D40 / 0x1BC30)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x1D45);
    // MOV DS,AX (19EF_1D43 / 0x1BC33)
    DS = AX;
    CheckExternalEvents(cs12, 0x1D46);
    // PUSH ES (19EF_1D45 / 0x1BC35)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x1D49);
    // MOV AX,0xa000 (19EF_1D46 / 0x1BC36)
    AX = 0xA000;
    CheckExternalEvents(cs12, 0x1D4B);
    // MOV ES,AX (19EF_1D49 / 0x1BC39)
    ES = AX;
    CheckExternalEvents(cs12, 0x1D4E);
    // MOV DI,0x68 (19EF_1D4B / 0x1BC3B)
    DI = 0x68;
    CheckExternalEvents(cs12, 0x1D51);
    // MOV SI,0x244b (19EF_1D4E / 0x1BC3E)
    SI = 0x244B;
    CheckExternalEvents(cs12, 0x1D54);
    // ADD SI,0x34 (19EF_1D51 / 0x1BC41)
    // SI += 0x34;
    SI = Alu16.Add(SI, 0x34);
    CheckExternalEvents(cs12, 0x1D56);
    // MOV DL,0xc8 (19EF_1D54 / 0x1BC44)
    DL = 0xC8;
    CheckExternalEvents(cs12, 0x1D59);
    // MOV BX,0xff0 (19EF_1D56 / 0x1BC46)
    BX = 0xFF0;
    label_19EF_1D59_1BC49:
    CheckExternalEvents(cs12, 0x1D5C);
    // MOV CX,0x1b (19EF_1D59 / 0x1BC49)
    CX = 0x1B;
    label_19EF_1D5C_1BC4C:
    CheckExternalEvents(cs12, 0x1D5D);
    // LODSW SI (19EF_1D5C / 0x1BC4C)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs12, 0x1D5F);
    // MOV DH,AH (19EF_1D5D / 0x1BC4D)
    DH = AH;
    CheckExternalEvents(cs12, 0x1D61);
    // MOV AH,AL (19EF_1D5F / 0x1BC4F)
    AH = AL;
    CheckExternalEvents(cs12, 0x1D63);
    // AND AX,BX (19EF_1D61 / 0x1BC51)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs12, 0x1D64);
    // STOSW ES:DI (19EF_1D63 / 0x1BC53)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1D66);
    // MOV AH,DH (19EF_1D64 / 0x1BC54)
    AH = DH;
    CheckExternalEvents(cs12, 0x1D68);
    // MOV AL,AH (19EF_1D66 / 0x1BC56)
    AL = AH;
    CheckExternalEvents(cs12, 0x1D6A);
    // AND AX,BX (19EF_1D68 / 0x1BC58)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs12, 0x1D6B);
    // STOSW ES:DI (19EF_1D6A / 0x1BC5A)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1D6C);
    // LODSW SI (19EF_1D6B / 0x1BC5B)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs12, 0x1D6E);
    // MOV DH,AH (19EF_1D6C / 0x1BC5C)
    DH = AH;
    CheckExternalEvents(cs12, 0x1D70);
    // MOV AH,AL (19EF_1D6E / 0x1BC5E)
    AH = AL;
    CheckExternalEvents(cs12, 0x1D72);
    // AND AX,BX (19EF_1D70 / 0x1BC60)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs12, 0x1D73);
    // STOSW ES:DI (19EF_1D72 / 0x1BC62)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1D75);
    // MOV AH,DH (19EF_1D73 / 0x1BC63)
    AH = DH;
    CheckExternalEvents(cs12, 0x1D77);
    // MOV AL,AH (19EF_1D75 / 0x1BC65)
    AL = AH;
    CheckExternalEvents(cs12, 0x1D79);
    // AND AX,BX (19EF_1D77 / 0x1BC67)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs12, 0x1D7A);
    // STOSW ES:DI (19EF_1D79 / 0x1BC69)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1D7C);
    // LOOP 0x1000:bc4c (19EF_1D7A / 0x1BC6A)
    if(--CX != 0) {
      goto label_19EF_1D5C_1BC4C;
    }
    CheckExternalEvents(cs12, 0x1D7F);
    // ADD DI,0x68 (19EF_1D7C / 0x1BC6C)
    DI += 0x68;
    CheckExternalEvents(cs12, 0x1D82);
    // ADD SI,0x34 (19EF_1D7F / 0x1BC6F)
    SI += 0x34;
    CheckExternalEvents(cs12, 0x1D84);
    // DEC DL (19EF_1D82 / 0x1BC72)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs12, 0x1D86);
    // JNZ 0x1000:bc49 (19EF_1D84 / 0x1BC74)
    if(!ZeroFlag) {
      goto label_19EF_1D59_1BC49;
    }
    CheckExternalEvents(cs12, 0x1D87);
    // POP ES (19EF_1D86 / 0x1BC76)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1D88);
    // POP DS (19EF_1D87 / 0x1BC77)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1D89);
    // POP SI (19EF_1D88 / 0x1BC78)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1D8A);
    // POP DI (19EF_1D89 / 0x1BC79)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1D8B);
    // POP BP (19EF_1D8A / 0x1BC7A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1D8C);
    // RETF  (19EF_1D8B / 0x1BC7B)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1D8C_1BC7C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1D8C_1BC7C:
    CheckExternalEvents(cs12, 0x1D8D);
    // PUSH BP (19EF_1D8C / 0x1BC7C)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x1D8F);
    // MOV BP,SP (19EF_1D8D / 0x1BC7D)
    BP = SP;
    CheckExternalEvents(cs12, 0x1D90);
    // PUSH DI (19EF_1D8F / 0x1BC7F)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1D91);
    // PUSH SI (19EF_1D90 / 0x1BC80)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1D92);
    // PUSH DS (19EF_1D91 / 0x1BC81)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1D95);
    // MOV AX,0x1ddc (19EF_1D92 / 0x1BC82)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x1D97);
    // MOV DS,AX (19EF_1D95 / 0x1BC85)
    DS = AX;
    CheckExternalEvents(cs12, 0x1D9A);
    // MOV AX,word ptr [BP + 0x6] (19EF_1D97 / 0x1BC87)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x1D9D);
    // MOV [0x26e],AX (19EF_1D9A / 0x1BC8A)
    UInt16[DS, 0x26E] = AX;
    CheckExternalEvents(cs12, 0x1DA0);
    // MOV AX,word ptr [BP + 0x8] (19EF_1D9D / 0x1BC8D)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x1DA3);
    // MOV [0x270],AX (19EF_1DA0 / 0x1BC90)
    UInt16[DS, 0x270] = AX;
    CheckExternalEvents(cs12, 0x1DA4);
    // POP DS (19EF_1DA3 / 0x1BC93)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1DA5);
    // POP SI (19EF_1DA4 / 0x1BC94)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1DA6);
    // POP DI (19EF_1DA5 / 0x1BC95)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1DA7);
    // POP BP (19EF_1DA6 / 0x1BC96)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1DA8);
    // RETF  (19EF_1DA7 / 0x1BC97)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1DA8_1BC98(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1DA8_1BC98:
    CheckExternalEvents(cs12, 0x1DA9);
    // PUSH BP (19EF_1DA8 / 0x1BC98)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x1DAB);
    // MOV BP,SP (19EF_1DA9 / 0x1BC99)
    BP = SP;
    CheckExternalEvents(cs12, 0x1DAC);
    // PUSH DI (19EF_1DAB / 0x1BC9B)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1DAD);
    // PUSH SI (19EF_1DAC / 0x1BC9C)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1DAE);
    // PUSH DS (19EF_1DAD / 0x1BC9D)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1DB1);
    // MOV AX,0x1ddc (19EF_1DAE / 0x1BC9E)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x1DB3);
    // MOV DS,AX (19EF_1DB1 / 0x1BCA1)
    DS = AX;
    CheckExternalEvents(cs12, 0x1DB6);
    // CALL 0x1000:b776 (19EF_1DB3 / 0x1BCA3)
    NearCall(cs12, 0x1DB6, unknown_19EF_1886_1B776);
    CheckExternalEvents(cs12, 0x1DB7);
    // POP DS (19EF_1DB6 / 0x1BCA6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1DB8);
    // POP SI (19EF_1DB7 / 0x1BCA7)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1DB9);
    // POP DI (19EF_1DB8 / 0x1BCA8)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1DBA);
    // POP BP (19EF_1DB9 / 0x1BCA9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1DBB);
    // RETF  (19EF_1DBA / 0x1BCAA)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1DF8_1BCE8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1DF8_1BCE8:
    CheckExternalEvents(cs12, 0x1DF9);
    // PUSH BP (19EF_1DF8 / 0x1BCE8)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x1DFB);
    // MOV BP,SP (19EF_1DF9 / 0x1BCE9)
    BP = SP;
    CheckExternalEvents(cs12, 0x1DFC);
    // PUSH DI (19EF_1DFB / 0x1BCEB)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1DFD);
    // PUSH SI (19EF_1DFC / 0x1BCEC)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1DFE);
    // PUSH DS (19EF_1DFD / 0x1BCED)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1E01);
    // MOV AX,0x1ddc (19EF_1DFE / 0x1BCEE)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x1E03);
    // MOV DS,AX (19EF_1E01 / 0x1BCF1)
    DS = AX;
    CheckExternalEvents(cs12, 0x1E06);
    // MOV AX,[0xa44d] (19EF_1E03 / 0x1BCF3)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs12, 0x1E08);
    // SHR AL,0x1 (19EF_1E06 / 0x1BCF6)
    AL >>= 0x1;
    CheckExternalEvents(cs12, 0x1E0B);
    // AND AX,0x7 (19EF_1E08 / 0x1BCF8)
    AX &= 0x7;
    CheckExternalEvents(cs12, 0x1E0D);
    // ADD AL,0x2 (19EF_1E0B / 0x1BCFB)
    AL += 0x2;
    CheckExternalEvents(cs12, 0x1E0F);
    // SHL AX,0x1 (19EF_1E0D / 0x1BCFD)
    AX <<= 0x1;
    CheckExternalEvents(cs12, 0x1E11);
    // SHL AX,0x1 (19EF_1E0F / 0x1BCFF)
    AX <<= 0x1;
    CheckExternalEvents(cs12, 0x1E13);
    // SHL AX,0x1 (19EF_1E11 / 0x1BD01)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs12, 0x1E15);
    // MOV BX,AX (19EF_1E13 / 0x1BD03)
    BX = AX;
    CheckExternalEvents(cs12, 0x1E17);
    // SHL AX,0x1 (19EF_1E15 / 0x1BD05)
    AX <<= 0x1;
    CheckExternalEvents(cs12, 0x1E19);
    // ADD AX,BX (19EF_1E17 / 0x1BD07)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs12, 0x1E1C);
    // MOV [0x9f1],AX (19EF_1E19 / 0x1BD09)
    UInt16[DS, 0x9F1] = AX;
    CheckExternalEvents(cs12, 0x1E20);
    // MOV BX,word ptr [0xa44b] (19EF_1E1C / 0x1BD0C)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs12, 0x1E22);
    // SHR BL,0x1 (19EF_1E20 / 0x1BD10)
    BL >>= 0x1;
    CheckExternalEvents(cs12, 0x1E25);
    // AND BX,0x7 (19EF_1E22 / 0x1BD12)
    BX &= 0x7;
    CheckExternalEvents(cs12, 0x1E28);
    // ADD BL,0x2 (19EF_1E25 / 0x1BD15)
    // BL += 0x2;
    BL = Alu8.Add(BL, 0x2);
    CheckExternalEvents(cs12, 0x1E2C);
    // MOV word ptr [0x9ef],BX (19EF_1E28 / 0x1BD18)
    UInt16[DS, 0x9EF] = BX;
    CheckExternalEvents(cs12, 0x1E2E);
    // ADD BX,AX (19EF_1E2C / 0x1BD1C)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs12, 0x1E32);
    // MOV word ptr [0x9ed],BX (19EF_1E2E / 0x1BD1E)
    UInt16[DS, 0x9ED] = BX;
    CheckExternalEvents(cs12, 0x1E33);
    // POP DS (19EF_1E32 / 0x1BD22)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1E34);
    // POP SI (19EF_1E33 / 0x1BD23)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1E35);
    // POP DI (19EF_1E34 / 0x1BD24)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1E36);
    // POP BP (19EF_1E35 / 0x1BD25)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1E37);
    // RETF  (19EF_1E36 / 0x1BD26)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1E37_1BD27(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1E37_1BD27:
    CheckExternalEvents(cs12, 0x1E38);
    // PUSH BP (19EF_1E37 / 0x1BD27)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x1E3A);
    // MOV BP,SP (19EF_1E38 / 0x1BD28)
    BP = SP;
    CheckExternalEvents(cs12, 0x1E3B);
    // PUSH DI (19EF_1E3A / 0x1BD2A)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1E3C);
    // PUSH SI (19EF_1E3B / 0x1BD2B)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1E3D);
    // PUSH DS (19EF_1E3C / 0x1BD2C)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1E40);
    // MOV AX,0x1ddc (19EF_1E3D / 0x1BD2D)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x1E42);
    // MOV DS,AX (19EF_1E40 / 0x1BD30)
    DS = AX;
    CheckExternalEvents(cs12, 0x1E43);
    // PUSH ES (19EF_1E42 / 0x1BD32)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x1E46);
    // MOV AX,0xa000 (19EF_1E43 / 0x1BD33)
    AX = 0xA000;
    CheckExternalEvents(cs12, 0x1E48);
    // MOV ES,AX (19EF_1E46 / 0x1BD36)
    ES = AX;
    CheckExternalEvents(cs12, 0x1E4B);
    // MOV SI,0x244b (19EF_1E48 / 0x1BD38)
    SI = 0x244B;
    CheckExternalEvents(cs12, 0x1E50);
    // CMP word ptr [0xb764],0x2 (19EF_1E4B / 0x1BD3B)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs12, 0x1E52);
    // JC 0x1000:bd68 (19EF_1E50 / 0x1BD40)
    if(CarryFlag) {
      goto label_19EF_1E78_1BD68;
    }
    CheckExternalEvents(cs12, 0x1E54);
    // JZ 0x1000:bd6e (19EF_1E52 / 0x1BD42)
    if(ZeroFlag) {
      goto label_19EF_1E7E_1BD6E;
    }
    CheckExternalEvents(cs12, 0x1E57);
    // MOV DI,0xa08 (19EF_1E54 / 0x1BD44)
    DI = 0xA08;
    CheckExternalEvents(cs12, 0x1E59);
    // MOV DL,0x58 (19EF_1E57 / 0x1BD47)
    DL = 0x58;
    CheckExternalEvents(cs12, 0x1E5C);
    // MOV BX,0xff0 (19EF_1E59 / 0x1BD49)
    BX = 0xFF0;
    label_19EF_1E5C_1BD4C:
    CheckExternalEvents(cs12, 0x1E5F);
    // MOV CX,0x16 (19EF_1E5C / 0x1BD4C)
    CX = 0x16;
    label_19EF_1E5F_1BD4F:
    CheckExternalEvents(cs12, 0x1E60);
    // LODSW SI (19EF_1E5F / 0x1BD4F)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs12, 0x1E62);
    // MOV DH,AH (19EF_1E60 / 0x1BD50)
    DH = AH;
    CheckExternalEvents(cs12, 0x1E64);
    // MOV AH,AL (19EF_1E62 / 0x1BD52)
    AH = AL;
    CheckExternalEvents(cs12, 0x1E66);
    // AND AX,BX (19EF_1E64 / 0x1BD54)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs12, 0x1E67);
    // STOSW ES:DI (19EF_1E66 / 0x1BD56)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1E69);
    // MOV AH,DH (19EF_1E67 / 0x1BD57)
    AH = DH;
    CheckExternalEvents(cs12, 0x1E6B);
    // MOV AL,AH (19EF_1E69 / 0x1BD59)
    AL = AH;
    CheckExternalEvents(cs12, 0x1E6D);
    // AND AX,BX (19EF_1E6B / 0x1BD5B)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs12, 0x1E6E);
    // STOSW ES:DI (19EF_1E6D / 0x1BD5D)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x1E70);
    // LOOP 0x1000:bd4f (19EF_1E6E / 0x1BD5E)
    if(--CX != 0) {
      goto label_19EF_1E5F_1BD4F;
    }
    CheckExternalEvents(cs12, 0x1E74);
    // ADD DI,0xe8 (19EF_1E70 / 0x1BD60)
    DI += 0xE8;
    CheckExternalEvents(cs12, 0x1E76);
    // DEC DL (19EF_1E74 / 0x1BD64)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs12, 0x1E78);
    // JNZ 0x1000:bd4c (19EF_1E76 / 0x1BD66)
    if(!ZeroFlag) {
      goto label_19EF_1E5C_1BD4C;
    }
    label_19EF_1E78_1BD68:
    CheckExternalEvents(cs12, 0x1E79);
    // POP ES (19EF_1E78 / 0x1BD68)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1E7A);
    // POP DS (19EF_1E79 / 0x1BD69)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1E7B);
    // POP SI (19EF_1E7A / 0x1BD6A)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1E7C);
    // POP DI (19EF_1E7B / 0x1BD6B)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1E7D);
    // POP BP (19EF_1E7C / 0x1BD6C)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1E7E);
    // RETF  (19EF_1E7D / 0x1BD6D)
    return FarRet();
    label_19EF_1E7E_1BD6E:
    CheckExternalEvents(cs12, 0x1E81);
    // MOV DI,0x141 (19EF_1E7E / 0x1BD6E)
    DI = 0x141;
    CheckExternalEvents(cs12, 0x1E85);
    // ADD SI,0xf20 (19EF_1E81 / 0x1BD71)
    // SI += 0xF20;
    SI = Alu16.Add(SI, 0xF20);
    CheckExternalEvents(cs12, 0x1E88);
    // MOV DX,0x3ce (19EF_1E85 / 0x1BD75)
    DX = 0x3CE;
    CheckExternalEvents(cs12, 0x1E8B);
    // MOV AX,0x5 (19EF_1E88 / 0x1BD78)
    AX = 0x5;
    CheckExternalEvents(cs12, 0x1E8C);
    // OUT DX,AX (19EF_1E8B / 0x1BD7B)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x1E8F);
    // MOV AX,0xff08 (19EF_1E8C / 0x1BD7C)
    AX = 0xFF08;
    CheckExternalEvents(cs12, 0x1E90);
    // OUT DX,AX (19EF_1E8F / 0x1BD7F)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x1E93);
    // MOV AX,0x1 (19EF_1E90 / 0x1BD80)
    AX = 0x1;
    CheckExternalEvents(cs12, 0x1E94);
    // OUT DX,AX (19EF_1E93 / 0x1BD83)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x1E97);
    // MOV BX,0x58 (19EF_1E94 / 0x1BD84)
    BX = 0x58;
    CheckExternalEvents(cs12, 0x1E9A);
    // MOV DX,0x3c4 (19EF_1E97 / 0x1BD87)
    DX = 0x3C4;
    label_19EF_1E9A_1BD8A:
    CheckExternalEvents(cs12, 0x1E9D);
    // MOV CX,0xb (19EF_1E9A / 0x1BD8A)
    CX = 0xB;
    label_19EF_1E9D_1BD8D:
    CheckExternalEvents(cs12, 0x1EA0);
    // MOV AX,0x102 (19EF_1E9D / 0x1BD8D)
    AX = 0x102;
    CheckExternalEvents(cs12, 0x1EA1);
    // OUT DX,AX (19EF_1EA0 / 0x1BD90)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x1EA4);
    // MOV AL,byte ptr ES:[DI] (19EF_1EA1 / 0x1BD91)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs12, 0x1EA5);
    // MOVSB ES:DI,SI (19EF_1EA4 / 0x1BD94)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs12, 0x1EA6);
    // DEC DI (19EF_1EA5 / 0x1BD95)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs12, 0x1EA9);
    // MOV AX,0x202 (19EF_1EA6 / 0x1BD96)
    AX = 0x202;
    CheckExternalEvents(cs12, 0x1EAA);
    // OUT DX,AX (19EF_1EA9 / 0x1BD99)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x1EAD);
    // MOV AL,byte ptr ES:[DI] (19EF_1EAA / 0x1BD9A)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs12, 0x1EAE);
    // MOVSB ES:DI,SI (19EF_1EAD / 0x1BD9D)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs12, 0x1EAF);
    // DEC DI (19EF_1EAE / 0x1BD9E)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs12, 0x1EB2);
    // MOV AX,0x402 (19EF_1EAF / 0x1BD9F)
    AX = 0x402;
    CheckExternalEvents(cs12, 0x1EB3);
    // OUT DX,AX (19EF_1EB2 / 0x1BDA2)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x1EB6);
    // MOV AL,byte ptr ES:[DI] (19EF_1EB3 / 0x1BDA3)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs12, 0x1EB7);
    // MOVSB ES:DI,SI (19EF_1EB6 / 0x1BDA6)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs12, 0x1EB8);
    // DEC DI (19EF_1EB7 / 0x1BDA7)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs12, 0x1EBB);
    // MOV AX,0x802 (19EF_1EB8 / 0x1BDA8)
    AX = 0x802;
    CheckExternalEvents(cs12, 0x1EBC);
    // OUT DX,AX (19EF_1EBB / 0x1BDAB)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x1EBF);
    // MOV AL,byte ptr ES:[DI] (19EF_1EBC / 0x1BDAC)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs12, 0x1EC0);
    // MOVSB ES:DI,SI (19EF_1EBF / 0x1BDAF)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs12, 0x1EC2);
    // LOOP 0x1000:bd8d (19EF_1EC0 / 0x1BDB0)
    if(--CX != 0) {
      goto label_19EF_1E9D_1BD8D;
    }
    CheckExternalEvents(cs12, 0x1EC5);
    // ADD DI,0x1d (19EF_1EC2 / 0x1BDB2)
    DI += 0x1D;
    CheckExternalEvents(cs12, 0x1EC6);
    // DEC BX (19EF_1EC5 / 0x1BDB5)
    BX = Alu16.Dec(BX);
    CheckExternalEvents(cs12, 0x1EC8);
    // JNZ 0x1000:bd8a (19EF_1EC6 / 0x1BDB6)
    if(!ZeroFlag) {
      goto label_19EF_1E9A_1BD8A;
    }
    CheckExternalEvents(cs12, 0x1ECB);
    // MOV AX,0xf02 (19EF_1EC8 / 0x1BDB8)
    AX = 0xF02;
    CheckExternalEvents(cs12, 0x1ECC);
    // OUT DX,AX (19EF_1ECB / 0x1BDBB)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x1ECE);
    // JMP 0x1000:bd68 (19EF_1ECC / 0x1BDBC)
    goto label_19EF_1E78_1BD68;
  }
  
  public virtual Action ghidra_guess_1000_BDBE_1BDBE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BDBE_1BDBE:
    CheckExternalEvents(cs7, 0xBDBF);
    // PUSH BP (1000_BDBE / 0x1BDBE)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xBDC1);
    // MOV BP,SP (1000_BDBF / 0x1BDBF)
    BP = SP;
    CheckExternalEvents(cs7, 0xBDC2);
    // PUSH DI (1000_BDC1 / 0x1BDC1)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xBDC3);
    // PUSH SI (1000_BDC2 / 0x1BDC2)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xBDC4);
    // PUSH DS (1000_BDC3 / 0x1BDC3)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xBDC7);
    // MOV AX,0x1ddc (1000_BDC4 / 0x1BDC4)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xBDC9);
    // MOV DS,AX (1000_BDC7 / 0x1BDC7)
    DS = AX;
    CheckExternalEvents(cs7, 0xBDCC);
    // MOV DI,word ptr [BP + 0x6] (1000_BDC9 / 0x1BDC9)
    DI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xBDCF);
    // MOV AX,word ptr [BP + 0x8] (1000_BDCC / 0x1BDCC)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xBDD2);
    // MOV DX,word ptr [BP + 0xa] (1000_BDCF / 0x1BDCF)
    DX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0xBDD3);
    // PUSH ES (1000_BDD2 / 0x1BDD2)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xBDD5);
    // MOV ES,AX (1000_BDD3 / 0x1BDD3)
    ES = AX;
    CheckExternalEvents(cs7, 0xBDD8);
    // MOV SI,0x7ad (1000_BDD5 / 0x1BDD5)
    SI = 0x7AD;
    CheckExternalEvents(cs7, 0xBDD9);
    // PUSH DS (1000_BDD8 / 0x1BDD8)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xBDDB);
    // OR DX,DX (1000_BDD9 / 0x1BDD9)
    // DX |= DX;
    DX = Alu16.Or(DX, DX);
    CheckExternalEvents(cs7, 0xBDDD);
    // JZ 0x1000:bde7 (1000_BDDB / 0x1BDDB)
    if(ZeroFlag) {
      goto label_1000_BDE7_1BDE7;
    }
    CheckExternalEvents(cs7, 0xBDDF);
    // XCHG DI,SI (1000_BDDD / 0x1BDDD)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs7, 0xBDE1);
    // MOV DX,DS (1000_BDDF / 0x1BDDF)
    DX = DS;
    CheckExternalEvents(cs7, 0xBDE3);
    // MOV AX,ES (1000_BDE1 / 0x1BDE1)
    AX = ES;
    CheckExternalEvents(cs7, 0xBDE5);
    // MOV DS,AX (1000_BDE3 / 0x1BDE3)
    DS = AX;
    CheckExternalEvents(cs7, 0xBDE7);
    // MOV ES,DX (1000_BDE5 / 0x1BDE5)
    ES = DX;
    label_1000_BDE7_1BDE7:
    CheckExternalEvents(cs7, 0xBDEA);
    // MOV CX,0x120 (1000_BDE7 / 0x1BDE7)
    CX = 0x120;
    CheckExternalEvents(cs7, 0xBDEB);
    // CLD  (1000_BDEA / 0x1BDEA)
    DirectionFlag = false;
    CheckExternalEvents(cs7, 0xBDED);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BDEB / 0x1BDEB)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs7, 0xBDEE);
    // POP DS (1000_BDED / 0x1BDED)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBDEF);
    // POP ES (1000_BDEE / 0x1BDEE)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBDF0);
    // POP DS (1000_BDEF / 0x1BDEF)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBDF1);
    // POP SI (1000_BDF0 / 0x1BDF0)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBDF2);
    // POP DI (1000_BDF1 / 0x1BDF1)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBDF3);
    // POP BP (1000_BDF2 / 0x1BDF2)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBDF4);
    // RETF  (1000_BDF3 / 0x1BDF3)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_BDF4_1BDF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BDF4_1BDF4:
    CheckExternalEvents(cs7, 0xBDF5);
    // PUSH BP (1000_BDF4 / 0x1BDF4)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xBDF7);
    // MOV BP,SP (1000_BDF5 / 0x1BDF5)
    BP = SP;
    CheckExternalEvents(cs7, 0xBDF8);
    // PUSH DI (1000_BDF7 / 0x1BDF7)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xBDF9);
    // PUSH SI (1000_BDF8 / 0x1BDF8)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xBDFA);
    // PUSH DS (1000_BDF9 / 0x1BDF9)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xBDFD);
    // MOV AX,0x1ddc (1000_BDFA / 0x1BDFA)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xBDFF);
    // MOV DS,AX (1000_BDFD / 0x1BDFD)
    DS = AX;
    CheckExternalEvents(cs7, 0xBE02);
    // MOV AX,word ptr [BP + 0x6] (1000_BDFF / 0x1BDFF)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xBE05);
    // MOV DI,0x244b (1000_BE02 / 0x1BE02)
    DI = 0x244B;
    CheckExternalEvents(cs7, 0xBE07);
    // ADD DI,AX (1000_BE05 / 0x1BE05)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs7, 0xBE08);
    // PUSH ES (1000_BE07 / 0x1BE07)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xBE0A);
    // MOV AX,DS (1000_BE08 / 0x1BE08)
    AX = DS;
    CheckExternalEvents(cs7, 0xBE0C);
    // MOV ES,AX (1000_BE0A / 0x1BE0A)
    ES = AX;
    CheckExternalEvents(cs7, 0xBE0F);
    // MOV SI,0x664 (1000_BE0C / 0x1BE0C)
    SI = 0x664;
    CheckExternalEvents(cs7, 0xBE12);
    // MOV BX,0x424 (1000_BE0F / 0x1BE0F)
    BX = 0x424;
    CheckExternalEvents(cs7, 0xBE15);
    // MOV DX,0x8 (1000_BE12 / 0x1BE12)
    DX = 0x8;
    label_1000_BE15_1BE15:
    CheckExternalEvents(cs7, 0xBE18);
    // MOV CX,0x8 (1000_BE15 / 0x1BE15)
    CX = 0x8;
    label_1000_BE18_1BE18:
    CheckExternalEvents(cs7, 0xBE19);
    // LODSB SI (1000_BE18 / 0x1BE18)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xBE1B);
    // CMP AL,0x90 (1000_BE19 / 0x1BE19)
    Alu8.Sub(AL, 0x90);
    CheckExternalEvents(cs7, 0xBE1D);
    // JNC 0x1000:be29 (1000_BE1B / 0x1BE1B)
    if(!CarryFlag) {
      goto label_1000_BE29_1BE29;
    }
    CheckExternalEvents(cs7, 0xBE1F);
    // CMP AL,0x10 (1000_BE1D / 0x1BE1D)
    Alu8.Sub(AL, 0x10);
    CheckExternalEvents(cs7, 0xBE21);
    // JZ 0x1000:be39 (1000_BE1F / 0x1BE1F)
    if(ZeroFlag) {
      goto label_1000_BE39_1BE39;
    }
    CheckExternalEvents(cs7, 0xBE23);
    // CMP AL,0x20 (1000_BE21 / 0x1BE21)
    Alu8.Sub(AL, 0x20);
    CheckExternalEvents(cs7, 0xBE25);
    // JC 0x1000:be27 (1000_BE23 / 0x1BE23)
    if(CarryFlag) {
      goto label_1000_BE27_1BE27;
    }
    CheckExternalEvents(cs7, 0xBE27);
    // SUB AL,0x10 (1000_BE25 / 0x1BE25)
    // AL -= 0x10;
    AL = Alu8.Sub(AL, 0x10);
    label_1000_BE27_1BE27:
    CheckExternalEvents(cs7, 0xBE29);
    // OR AL,byte ptr [BX] (1000_BE27 / 0x1BE27)
    // AL |= UInt8[DS, (ushort)(BX)];
    AL = Alu8.Or(AL, UInt8[DS, (ushort)(BX)]);
    label_1000_BE29_1BE29:
    CheckExternalEvents(cs7, 0xBE2A);
    // STOSB ES:DI (1000_BE29 / 0x1BE29)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xBE2B);
    // INC BX (1000_BE2A / 0x1BE2A)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs7, 0xBE2D);
    // LOOP 0x1000:be18 (1000_BE2B / 0x1BE2B)
    if(--CX != 0) {
      goto label_1000_BE18_1BE18;
    }
    label_1000_BE2D_1BE2D:
    CheckExternalEvents(cs7, 0xBE30);
    // ADD DI,0x20 (1000_BE2D / 0x1BE2D)
    DI += 0x20;
    CheckExternalEvents(cs7, 0xBE31);
    // DEC DX (1000_BE30 / 0x1BE30)
    DX = Alu16.Dec(DX);
    CheckExternalEvents(cs7, 0xBE33);
    // JNZ 0x1000:be15 (1000_BE31 / 0x1BE31)
    if(!ZeroFlag) {
      goto label_1000_BE15_1BE15;
    }
    CheckExternalEvents(cs7, 0xBE34);
    // POP ES (1000_BE33 / 0x1BE33)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBE35);
    // POP DS (1000_BE34 / 0x1BE34)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBE36);
    // POP SI (1000_BE35 / 0x1BE35)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBE37);
    // POP DI (1000_BE36 / 0x1BE36)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBE38);
    // POP BP (1000_BE37 / 0x1BE37)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBE39);
    // RETF  (1000_BE38 / 0x1BE38)
    return FarRet();
    label_1000_BE39_1BE39:
    CheckExternalEvents(cs7, 0xBE3B);
    // MOV AL,0x40 (1000_BE39 / 0x1BE39)
    AL = 0x40;
    CheckExternalEvents(cs7, 0xBE3C);
    // STOSB ES:DI (1000_BE3B / 0x1BE3B)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xBE3D);
    // INC BX (1000_BE3C / 0x1BE3C)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs7, 0xBE3F);
    // LOOP 0x1000:be18 (1000_BE3D / 0x1BE3D)
    if(--CX != 0) {
      goto label_1000_BE18_1BE18;
    }
    CheckExternalEvents(cs7, 0xBE41);
    // JMP 0x1000:be2d (1000_BE3F / 0x1BE3F)
    goto label_1000_BE2D_1BE2D;
  }
  
  public virtual Action ghidra_guess_1000_BE41_1BE41(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BE41_1BE41:
    CheckExternalEvents(cs7, 0xBE42);
    // PUSH BP (1000_BE41 / 0x1BE41)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xBE44);
    // MOV BP,SP (1000_BE42 / 0x1BE42)
    BP = SP;
    CheckExternalEvents(cs7, 0xBE45);
    // PUSH DI (1000_BE44 / 0x1BE44)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xBE46);
    // PUSH SI (1000_BE45 / 0x1BE45)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xBE47);
    // PUSH DS (1000_BE46 / 0x1BE46)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xBE4A);
    // MOV AX,0x1ddc (1000_BE47 / 0x1BE47)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xBE4C);
    // MOV DS,AX (1000_BE4A / 0x1BE4A)
    DS = AX;
    CheckExternalEvents(cs7, 0xBE4F);
    // MOV AX,word ptr [BP + 0x6] (1000_BE4C / 0x1BE4C)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xBE52);
    // SUB AX,0x90 (1000_BE4F / 0x1BE4F)
    // AX -= 0x90;
    AX = Alu16.Sub(AX, 0x90);
    CheckExternalEvents(cs7, 0xBE54);
    // XCHG AL,AH (1000_BE52 / 0x1BE52)
    (AH, AL) = (AL, AH);
    CheckExternalEvents(cs7, 0xBE56);
    // SHR AX,0x1 (1000_BE54 / 0x1BE54)
    AX >>= 0x1;
    CheckExternalEvents(cs7, 0xBE58);
    // SHR AX,0x1 (1000_BE56 / 0x1BE56)
    AX >>= 0x1;
    CheckExternalEvents(cs7, 0xBE5B);
    // ADD AH,0x40 (1000_BE58 / 0x1BE58)
    // AH += 0x40;
    AH = Alu8.Add(AH, 0x40);
    CheckExternalEvents(cs7, 0xBE5E);
    // MOV DI,0x244b (1000_BE5B / 0x1BE5B)
    DI = 0x244B;
    CheckExternalEvents(cs7, 0xBE60);
    // ADD AX,DI (1000_BE5E / 0x1BE5E)
    // AX += DI;
    AX = Alu16.Add(AX, DI);
    CheckExternalEvents(cs7, 0xBE62);
    // MOV SI,AX (1000_BE60 / 0x1BE60)
    SI = AX;
    CheckExternalEvents(cs7, 0xBE66);
    // ADD DI,0x3fe0 (1000_BE62 / 0x1BE62)
    // DI += 0x3FE0;
    DI = Alu16.Add(DI, 0x3FE0);
    CheckExternalEvents(cs7, 0xBE69);
    // MOV BX,0x215d (1000_BE66 / 0x1BE66)
    BX = 0x215D;
    CheckExternalEvents(cs7, 0xBE6A);
    // PUSH ES (1000_BE69 / 0x1BE69)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xBE6C);
    // MOV AX,DS (1000_BE6A / 0x1BE6A)
    AX = DS;
    CheckExternalEvents(cs7, 0xBE6E);
    // MOV ES,AX (1000_BE6C / 0x1BE6C)
    ES = AX;
    CheckExternalEvents(cs7, 0xBE71);
    // MOV CX,0x20 (1000_BE6E / 0x1BE6E)
    CX = 0x20;
    label_1000_BE71_1BE71:
    CheckExternalEvents(cs7, 0xBE73);
    // XOR AH,AH (1000_BE71 / 0x1BE71)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs7, 0xBE74);
    // LODSB SI (1000_BE73 / 0x1BE73)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xBE75);
    // XLAT BX (1000_BE74 / 0x1BE74)
    AL = UInt8[DS, (ushort)(BX + AL)];
    CheckExternalEvents(cs7, 0xBE77);
    // MOV AH,AL (1000_BE75 / 0x1BE75)
    AH = AL;
    CheckExternalEvents(cs7, 0xBE79);
    // SHL AH,0x1 (1000_BE77 / 0x1BE77)
    AH <<= 0x1;
    CheckExternalEvents(cs7, 0xBE7B);
    // SHL AH,0x1 (1000_BE79 / 0x1BE79)
    AH <<= 0x1;
    CheckExternalEvents(cs7, 0xBE7D);
    // SHL AH,0x1 (1000_BE7B / 0x1BE7B)
    AH <<= 0x1;
    CheckExternalEvents(cs7, 0xBE7F);
    // SHL AH,0x1 (1000_BE7D / 0x1BE7D)
    // AH <<= 0x1;
    AH = Alu8.Shl(AH, 0x1);
    CheckExternalEvents(cs7, 0xBE80);
    // LODSB SI (1000_BE7F / 0x1BE7F)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xBE81);
    // XLAT BX (1000_BE80 / 0x1BE80)
    AL = UInt8[DS, (ushort)(BX + AL)];
    CheckExternalEvents(cs7, 0xBE83);
    // OR AL,AH (1000_BE81 / 0x1BE81)
    // AL |= AH;
    AL = Alu8.Or(AL, AH);
    CheckExternalEvents(cs7, 0xBE84);
    // STOSB ES:DI (1000_BE83 / 0x1BE83)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xBE86);
    // LOOP 0x1000:be71 (1000_BE84 / 0x1BE84)
    if(--CX != 0) {
      goto label_1000_BE71_1BE71;
    }
    CheckExternalEvents(cs7, 0xBE87);
    // POP ES (1000_BE86 / 0x1BE86)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBE88);
    // POP DS (1000_BE87 / 0x1BE87)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBE89);
    // POP SI (1000_BE88 / 0x1BE88)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBE8A);
    // POP DI (1000_BE89 / 0x1BE89)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBE8B);
    // POP BP (1000_BE8A / 0x1BE8A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBE8C);
    // RETF  (1000_BE8B / 0x1BE8B)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1F9C_1BE8C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1F9C_1BE8C:
    CheckExternalEvents(cs12, 0x1F9D);
    // PUSH BP (19EF_1F9C / 0x1BE8C)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x1F9F);
    // MOV BP,SP (19EF_1F9D / 0x1BE8D)
    BP = SP;
    CheckExternalEvents(cs12, 0x1FA0);
    // PUSH DI (19EF_1F9F / 0x1BE8F)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1FA1);
    // PUSH SI (19EF_1FA0 / 0x1BE90)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1FA2);
    // PUSH DS (19EF_1FA1 / 0x1BE91)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1FA5);
    // MOV AX,0x1ddc (19EF_1FA2 / 0x1BE92)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x1FA7);
    // MOV DS,AX (19EF_1FA5 / 0x1BE95)
    DS = AX;
    CheckExternalEvents(cs12, 0x1FA8);
    // STI  (19EF_1FA7 / 0x1BE97)
    InterruptFlag = true;
    CheckExternalEvents(cs12, 0x1FA9);
    // POP DS (19EF_1FA8 / 0x1BE98)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1FAA);
    // POP SI (19EF_1FA9 / 0x1BE99)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1FAB);
    // POP DI (19EF_1FAA / 0x1BE9A)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1FAC);
    // POP BP (19EF_1FAB / 0x1BE9B)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1FAD);
    // RETF  (19EF_1FAC / 0x1BE9C)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1FAD_1BE9D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1FAD_1BE9D:
    CheckExternalEvents(cs12, 0x1FAE);
    // PUSH BP (19EF_1FAD / 0x1BE9D)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x1FB0);
    // MOV BP,SP (19EF_1FAE / 0x1BE9E)
    BP = SP;
    CheckExternalEvents(cs12, 0x1FB1);
    // PUSH DI (19EF_1FB0 / 0x1BEA0)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1FB2);
    // PUSH SI (19EF_1FB1 / 0x1BEA1)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1FB3);
    // PUSH DS (19EF_1FB2 / 0x1BEA2)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1FB6);
    // MOV AX,0x1ddc (19EF_1FB3 / 0x1BEA3)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x1FB8);
    // MOV DS,AX (19EF_1FB6 / 0x1BEA6)
    DS = AX;
    CheckExternalEvents(cs12, 0x1FB9);
    // CLI  (19EF_1FB8 / 0x1BEA8)
    InterruptFlag = false;
    CheckExternalEvents(cs12, 0x1FBA);
    // POP DS (19EF_1FB9 / 0x1BEA9)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1FBB);
    // POP SI (19EF_1FBA / 0x1BEAA)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1FBC);
    // POP DI (19EF_1FBB / 0x1BEAB)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1FBD);
    // POP BP (19EF_1FBC / 0x1BEAC)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x1FBE);
    // RETF  (19EF_1FBD / 0x1BEAD)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1FBE_1BEAE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1FBE_1BEAE:
    CheckExternalEvents(cs12, 0x1FBF);
    // PUSH BP (19EF_1FBE / 0x1BEAE)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x1FC1);
    // MOV BP,SP (19EF_1FBF / 0x1BEAF)
    BP = SP;
    CheckExternalEvents(cs12, 0x1FC2);
    // PUSH DI (19EF_1FC1 / 0x1BEB1)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x1FC3);
    // PUSH SI (19EF_1FC2 / 0x1BEB2)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x1FC4);
    // PUSH DS (19EF_1FC3 / 0x1BEB3)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x1FC7);
    // MOV AX,0x1ddc (19EF_1FC4 / 0x1BEB4)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x1FC9);
    // MOV DS,AX (19EF_1FC7 / 0x1BEB7)
    DS = AX;
    CheckExternalEvents(cs12, 0x1FCA);
    // PUSH ES (19EF_1FC9 / 0x1BEB9)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x1FCD);
    // MOV AX,0xb800 (19EF_1FCA / 0x1BEBA)
    AX = 0xB800;
    CheckExternalEvents(cs12, 0x1FCF);
    // MOV ES,AX (19EF_1FCD / 0x1BEBD)
    ES = AX;
    CheckExternalEvents(cs12, 0x1FD2);
    // MOV DI,0x0 (19EF_1FCF / 0x1BEBF)
    DI = 0x0;
    CheckExternalEvents(cs12, 0x1FD5);
    // MOV CX,0x2000 (19EF_1FD2 / 0x1BEC2)
    CX = 0x2000;
    CheckExternalEvents(cs12, 0x1FDA);
    // CMP word ptr [0xb764],0x0 (19EF_1FD5 / 0x1BEC5)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs12, 0x1FDC);
    // JZ 0x1000:bef4 (19EF_1FDA / 0x1BECA)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_BEE6_1BEE6, 0x1BEF4 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs12, 0x1FDE);
    // SHL CH,0x1 (19EF_1FDC / 0x1BECC)
    CH <<= 0x1;
    CheckExternalEvents(cs12, 0x1FE3);
    // CMP word ptr [0xb764],0x1 (19EF_1FDE / 0x1BECE)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs12, 0x1FE5);
    // JZ 0x1000:bef4 (19EF_1FE3 / 0x1BED3)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_BEE6_1BEE6, 0x1BEF4 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs12, 0x1FE8);
    // MOV AX,0xa000 (19EF_1FE5 / 0x1BED5)
    AX = 0xA000;
    CheckExternalEvents(cs12, 0x1FEA);
    // MOV ES,AX (19EF_1FE8 / 0x1BED8)
    ES = AX;
    CheckExternalEvents(cs12, 0x1FEF);
    // CMP word ptr [0xb764],0x2 (19EF_1FEA / 0x1BEDA)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs12, 0x1FF1);
    // JZ 0x1000:bee6 (19EF_1FEF / 0x1BEDF)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_BEE6_1BEE6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs12, 0x1FF3);
    // SHL CH,0x1 (19EF_1FF1 / 0x1BEE1)
    // CH <<= 0x1;
    CH = Alu8.Shl(CH, 0x1);
    CheckExternalEvents(cs12, 0x1FF5);
    // JMP 0x1000:bef4 (19EF_1FF3 / 0x1BEE3)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_BEE6_1BEE6, 0x1BEF4 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_BEE6_1BEE6(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1BEF4: goto label_19EF_2004_1BEF4;break; // Target of external jump from 0x1BEE3
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_BEE6_1BEE6:
    CheckExternalEvents(cs7, 0xBEE9);
    // MOV CX,0x1f40 (1000_BEE6 / 0x1BEE6)
    CX = 0x1F40;
    CheckExternalEvents(cs7, 0xBEEC);
    // MOV DX,0x3ce (1000_BEE9 / 0x1BEE9)
    DX = 0x3CE;
    CheckExternalEvents(cs7, 0xBEEF);
    // MOV AX,0x205 (1000_BEEC / 0x1BEEC)
    AX = 0x205;
    CheckExternalEvents(cs7, 0xBEF0);
    // OUT DX,AX (1000_BEEF / 0x1BEEF)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xBEF3);
    // MOV AX,0xff08 (1000_BEF0 / 0x1BEF0)
    AX = 0xFF08;
    CheckExternalEvents(cs7, 0xBEF4);
    // OUT DX,AX (1000_BEF3 / 0x1BEF3)
    Cpu.Out16(DX, AX);
    label_1000_BEF4_1BEF4:
    CheckExternalEvents(cs7, 0xBEF6);
    // MOV AX,DI (1000_BEF4 / 0x1BEF4)
    AX = DI;
    CheckExternalEvents(cs7, 0xBEF8);
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_BEF6 / 0x1BEF6)
      UInt16[ES, (ushort)(DI)] = AX;
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs7, 0xBEF9);
    // POP ES (1000_BEF8 / 0x1BEF8)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBEFA);
    // POP DS (1000_BEF9 / 0x1BEF9)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBEFB);
    // POP SI (1000_BEFA / 0x1BEFA)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBEFC);
    // POP DI (1000_BEFB / 0x1BEFB)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBEFD);
    // POP BP (1000_BEFC / 0x1BEFC)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBEFE);
    // RETF  (1000_BEFD / 0x1BEFD)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_200E_1BEFE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_200E_1BEFE:
    CheckExternalEvents(cs12, 0x200F);
    // PUSH BP (19EF_200E / 0x1BEFE)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x2011);
    // MOV BP,SP (19EF_200F / 0x1BEFF)
    BP = SP;
    CheckExternalEvents(cs12, 0x2012);
    // PUSH DI (19EF_2011 / 0x1BF01)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x2013);
    // PUSH SI (19EF_2012 / 0x1BF02)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x2014);
    // PUSH DS (19EF_2013 / 0x1BF03)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x2017);
    // MOV AX,0x1ddc (19EF_2014 / 0x1BF04)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x2019);
    // MOV DS,AX (19EF_2017 / 0x1BF07)
    DS = AX;
    CheckExternalEvents(cs12, 0x201A);
    // PUSH ES (19EF_2019 / 0x1BF09)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x201D);
    // MOV AX,0xb800 (19EF_201A / 0x1BF0A)
    AX = 0xB800;
    CheckExternalEvents(cs12, 0x201F);
    // MOV ES,AX (19EF_201D / 0x1BF0D)
    ES = AX;
    CheckExternalEvents(cs12, 0x2022);
    // MOV SI,word ptr [BP + 0x6] (19EF_201F / 0x1BF0F)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x2026);
    // MOV word ptr [0xb78a],SI (19EF_2022 / 0x1BF12)
    UInt16[DS, 0xB78A] = SI;
    CheckExternalEvents(cs12, 0x2029);
    // MOV BX,word ptr [BP + 0x8] (19EF_2026 / 0x1BF16)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x202D);
    // MOV word ptr [0xb78c],BX (19EF_2029 / 0x1BF19)
    UInt16[DS, 0xB78C] = BX;
    CheckExternalEvents(cs12, 0x2030);
    // MOV AX,word ptr [BP + 0xa] (19EF_202D / 0x1BF1D)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x2032);
    // SHL AX,0x1 (19EF_2030 / 0x1BF20)
    AX <<= 0x1;
    CheckExternalEvents(cs12, 0x2034);
    // SHL AX,0x1 (19EF_2032 / 0x1BF22)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs12, 0x2037);
    // MOV [0xb792],AX (19EF_2034 / 0x1BF24)
    UInt16[DS, 0xB792] = AX;
    CheckExternalEvents(cs12, 0x203A);
    // MOV AX,word ptr [BP + 0xc] (19EF_2037 / 0x1BF27)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs12, 0x203D);
    // MOV [0xb794],AX (19EF_203A / 0x1BF2A)
    UInt16[DS, 0xB794] = AX;
    CheckExternalEvents(cs12, 0x2040);
    // MOV AX,word ptr [BP + 0xe] (19EF_203D / 0x1BF2D)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs12, 0x2042);
    // SHL AX,0x1 (19EF_2040 / 0x1BF30)
    AX <<= 0x1;
    CheckExternalEvents(cs12, 0x2044);
    // SHL AX,0x1 (19EF_2042 / 0x1BF32)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs12, 0x2047);
    // MOV [0xb79a],AX (19EF_2044 / 0x1BF34)
    UInt16[DS, 0xB79A] = AX;
    CheckExternalEvents(cs12, 0x204A);
    // MOV CX,word ptr [BP + 0x10] (19EF_2047 / 0x1BF37)
    CX = UInt16[SS, (ushort)(BP + 0x10)];
    CheckExternalEvents(cs12, 0x204E);
    // MOV word ptr [0xb79c],CX (19EF_204A / 0x1BF3A)
    UInt16[DS, 0xB79C] = CX;
    CheckExternalEvents(cs12, 0x2053);
    // CMP word ptr [0xb764],0x1 (19EF_204E / 0x1BF3E)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs12, 0x2055);
    // JZ 0x1000:bf7a (19EF_2053 / 0x1BF43)
    if(ZeroFlag) {
      goto label_19EF_208A_1BF7A;
    }
    CheckExternalEvents(cs12, 0x2057);
    // JC 0x1000:bfc5 (19EF_2055 / 0x1BF45)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_BFC5_1BFC5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs12, 0x205B);
    // SHL word ptr [0xb792],0x1 (19EF_2057 / 0x1BF47)
    // UInt16[DS, 0xB792] <<= 0x1;
    UInt16[DS, 0xB792] = Alu16.Shl(UInt16[DS, 0xB792], 0x1);
    CheckExternalEvents(cs12, 0x205E);
    // MOV AX,0xa000 (19EF_205B / 0x1BF4B)
    AX = 0xA000;
    CheckExternalEvents(cs12, 0x2060);
    // MOV ES,AX (19EF_205E / 0x1BF4E)
    ES = AX;
    label_19EF_2060_1BF50:
    CheckExternalEvents(cs12, 0x2061);
    // PUSH CX (19EF_2060 / 0x1BF50)
    Stack.Push16(CX);
    CheckExternalEvents(cs12, 0x2064);
    // MOV AX,[0xb794] (19EF_2061 / 0x1BF51)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs12, 0x2068);
    // INC word ptr [0xb794] (19EF_2064 / 0x1BF54)
    UInt16[DS, 0xB794] = Alu16.Inc(UInt16[DS, 0xB794]);
    CheckExternalEvents(cs12, 0x206B);
    // MOV DX,0x140 (19EF_2068 / 0x1BF58)
    DX = 0x140;
    CheckExternalEvents(cs12, 0x206D);
    // MUL DX (19EF_206B / 0x1BF5B)
    uint resMul19EF_206B = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul19EF_206B);
    DX = (ushort)(resMul19EF_206B >> 16);
    CheckExternalEvents(cs12, 0x2071);
    // ADD AX,word ptr [0xb792] (19EF_206D / 0x1BF5D)
    // AX += UInt16[DS, 0xB792];
    AX = Alu16.Add(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs12, 0x2073);
    // MOV DI,AX (19EF_2071 / 0x1BF61)
    DI = AX;
    CheckExternalEvents(cs12, 0x2077);
    // MOV CX,word ptr [0xb79a] (19EF_2073 / 0x1BF63)
    CX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs12, 0x2078);
    // PUSH DS (19EF_2077 / 0x1BF67)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x207A);
    // MOV DS,BX (19EF_2078 / 0x1BF68)
    DS = BX;
    label_19EF_207A_1BF6A:
    CheckExternalEvents(cs12, 0x207B);
    // LODSB SI (19EF_207A / 0x1BF6A)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs12, 0x207D);
    // MOV AH,AL (19EF_207B / 0x1BF6B)
    AH = AL;
    CheckExternalEvents(cs12, 0x2080);
    // AND AX,0xff0 (19EF_207D / 0x1BF6D)
    // AX &= 0xFF0;
    AX = Alu16.And(AX, 0xFF0);
    CheckExternalEvents(cs12, 0x2081);
    // STOSW ES:DI (19EF_2080 / 0x1BF70)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs12, 0x2083);
    // LOOP 0x1000:bf6a (19EF_2081 / 0x1BF71)
    if(--CX != 0) {
      goto label_19EF_207A_1BF6A;
    }
    CheckExternalEvents(cs12, 0x2084);
    // POP DS (19EF_2083 / 0x1BF73)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x2085);
    // POP CX (19EF_2084 / 0x1BF74)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x2087);
    // LOOP 0x1000:bf50 (19EF_2085 / 0x1BF75)
    if(--CX != 0) {
      goto label_19EF_2060_1BF50;
    }
    CheckExternalEvents(cs12, 0x208A);
    // JMP 0x1000:c011 (19EF_2087 / 0x1BF77)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_BFC5_1BFC5, 0x1C011 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_208A_1BF7A:
    CheckExternalEvents(cs12, 0x208B);
    // PUSH CX (19EF_208A / 0x1BF7A)
    Stack.Push16(CX);
    CheckExternalEvents(cs12, 0x208E);
    // MOV AX,0x28 (19EF_208B / 0x1BF7B)
    AX = 0x28;
    CheckExternalEvents(cs12, 0x2092);
    // MOV DX,word ptr [0xb794] (19EF_208E / 0x1BF7E)
    DX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs12, 0x2093);
    // PUSH DX (19EF_2092 / 0x1BF82)
    Stack.Push16(DX);
    CheckExternalEvents(cs12, 0x2096);
    // AND DL,0xfc (19EF_2093 / 0x1BF83)
    DL &= 0xFC;
    CheckExternalEvents(cs12, 0x2098);
    // MUL DL (19EF_2096 / 0x1BF86)
    ushort resMul19EF_2096 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul19EF_2096);
    AH = (byte)(resMul19EF_2096 >> 8);
    CheckExternalEvents(cs12, 0x2099);
    // POP DX (19EF_2098 / 0x1BF88)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x209C);
    // AND DL,0x3 (19EF_2099 / 0x1BF89)
    // DL &= 0x3;
    DL = Alu8.And(DL, 0x3);
    CheckExternalEvents(cs12, 0x209E);
    // JZ 0x1000:bf95 (19EF_209C / 0x1BF8C)
    if(ZeroFlag) {
      goto label_19EF_20A5_1BF95;
    }
    CheckExternalEvents(cs12, 0x20A0);
    // MOV CL,DL (19EF_209E / 0x1BF8E)
    CL = DL;
    label_19EF_20A0_1BF90:
    CheckExternalEvents(cs12, 0x20A3);
    // ADD AH,0x20 (19EF_20A0 / 0x1BF90)
    // AH += 0x20;
    AH = Alu8.Add(AH, 0x20);
    CheckExternalEvents(cs12, 0x20A5);
    // LOOP 0x1000:bf90 (19EF_20A3 / 0x1BF93)
    if(--CX != 0) {
      goto label_19EF_20A0_1BF90;
    }
    label_19EF_20A5_1BF95:
    CheckExternalEvents(cs12, 0x20A9);
    // ADD AX,word ptr [0xb792] (19EF_20A5 / 0x1BF95)
    // AX += UInt16[DS, 0xB792];
    AX = Alu16.Add(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs12, 0x20AB);
    // MOV DI,AX (19EF_20A9 / 0x1BF99)
    DI = AX;
    CheckExternalEvents(cs12, 0x20AF);
    // MOV BX,word ptr [0xb78a] (19EF_20AB / 0x1BF9B)
    BX = UInt16[DS, 0xB78A];
    CheckExternalEvents(cs12, 0x20B0);
    // PUSH BX (19EF_20AF / 0x1BF9F)
    Stack.Push16(BX);
    CheckExternalEvents(cs12, 0x20B4);
    // MOV CX,word ptr [0xb79a] (19EF_20B0 / 0x1BFA0)
    CX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs12, 0x20B6);
    // ADD BX,CX (19EF_20B4 / 0x1BFA4)
    // BX += CX;
    BX = Alu16.Add(BX, CX);
    CheckExternalEvents(cs12, 0x20BA);
    // MOV word ptr [0xb78a],BX (19EF_20B6 / 0x1BFA6)
    UInt16[DS, 0xB78A] = BX;
    CheckExternalEvents(cs12, 0x20BB);
    // POP BX (19EF_20BA / 0x1BFAA)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x20BD);
    // MOV SI,BX (19EF_20BB / 0x1BFAB)
    SI = BX;
    CheckExternalEvents(cs12, 0x20BE);
    // PUSH DS (19EF_20BD / 0x1BFAD)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x20C1);
    // MOV AX,[0xb78c] (19EF_20BE / 0x1BFAE)
    AX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs12, 0x20C3);
    // MOV DS,AX (19EF_20C1 / 0x1BFB1)
    DS = AX;
    CheckExternalEvents(cs12, 0x20C5);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (19EF_20C3 / 0x1BFB3)
      UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs12, 0x20C6);
    // POP DS (19EF_20C5 / 0x1BFB5)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x20CA);
    // MOV BX,word ptr [0xb794] (19EF_20C6 / 0x1BFB6)
    BX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs12, 0x20CB);
    // INC BX (19EF_20CA / 0x1BFBA)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs12, 0x20CF);
    // MOV word ptr [0xb794],BX (19EF_20CB / 0x1BFBB)
    UInt16[DS, 0xB794] = BX;
    CheckExternalEvents(cs12, 0x20D0);
    // POP CX (19EF_20CF / 0x1BFBF)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x20D2);
    // LOOP 0x1000:bf7a (19EF_20D0 / 0x1BFC0)
    if(--CX != 0) {
      goto label_19EF_208A_1BF7A;
    }
    CheckExternalEvents(cs12, 0x20D4);
    // JMP 0x1000:c011 (19EF_20D2 / 0x1BFC2)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_BFC5_1BFC5, 0x1C011 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
