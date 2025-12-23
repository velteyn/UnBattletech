namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_1000_9B2A_19B2A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9B2A_19B2A:
    CheckExternalEvents(cs7, 0x9B2B);
    // PUSH BP (1000_9B2A / 0x19B2A)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9B2D);
    // MOV BP,SP (1000_9B2B / 0x19B2B)
    BP = SP;
    CheckExternalEvents(cs7, 0x9B30);
    // MOV AX,0x4 (1000_9B2D / 0x19B2D)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x9B35);
    // CALLF 0x1000:cecc (1000_9B30 / 0x19B30)
    FarCall(cs7, 0x9B35, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x9B36);
    // PUSH SI (1000_9B35 / 0x19B35)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x9B3A);
    // MOV ES,word ptr [0x5716] (1000_9B36 / 0x19B36)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs7, 0x9B3D);
    // MOV AX,word ptr [BP + 0x6] (1000_9B3A / 0x19B3A)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x9B41);
    // MOV ES:[0x398c],AX (1000_9B3D / 0x19B3D)
    UInt16[ES, 0x398C] = AX;
    CheckExternalEvents(cs7, 0x9B45);
    // MOV ES,word ptr [0x5718] (1000_9B41 / 0x19B41)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs7, 0x9B48);
    // MOV AX,word ptr [BP + 0x8] (1000_9B45 / 0x19B45)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x9B4C);
    // MOV ES:[0x39a2],AX (1000_9B48 / 0x19B48)
    UInt16[ES, 0x39A2] = AX;
    CheckExternalEvents(cs7, 0x9B50);
    // MOV ES,word ptr [0x571a] (1000_9B4C / 0x19B4C)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs7, 0x9B53);
    // MOV AX,word ptr [BP + 0xa] (1000_9B50 / 0x19B50)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0x9B57);
    // MOV ES:[0x39f6],AX (1000_9B53 / 0x19B53)
    UInt16[ES, 0x39F6] = AX;
    CheckExternalEvents(cs7, 0x9B5B);
    // MOV ES,word ptr [0x571c] (1000_9B57 / 0x19B57)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs7, 0x9B5E);
    // MOV AX,word ptr [BP + 0xc] (1000_9B5B / 0x19B5B)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs7, 0x9B62);
    // MOV ES:[0x3ff2],AX (1000_9B5E / 0x19B5E)
    UInt16[ES, 0x3FF2] = AX;
    CheckExternalEvents(cs7, 0x9B66);
    // MOV ES,word ptr [0x571e] (1000_9B62 / 0x19B62)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs7, 0x9B69);
    // MOV AX,word ptr [BP + 0xe] (1000_9B66 / 0x19B66)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs7, 0x9B6D);
    // MOV ES:[0x9c],AX (1000_9B69 / 0x19B69)
    UInt16[ES, 0x9C] = AX;
    CheckExternalEvents(cs7, 0x9B72);
    // MOV word ptr [BP + -0x4],0x0 (1000_9B6D / 0x19B6D)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs7, 0x9B74);
    // JMP 0x1000:9b97 (1000_9B72 / 0x19B72)
    goto label_1000_9B97_19B97;
    label_1000_9B74_19B74:
    CheckExternalEvents(cs7, 0x9B77);
    // MOV word ptr [BP + -0x2],SI (1000_9B74 / 0x19B74)
    UInt16[SS, (ushort)(BP - 0x2)] = SI;
    CheckExternalEvents(cs7, 0x9B7B);
    // MOV ES,word ptr [0x571c] (1000_9B77 / 0x19B77)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs7, 0x9B80);
    // PUSH word ptr ES:[0x3ff2] (1000_9B7B / 0x19B7B)
    Stack.Push16(UInt16[ES, 0x3FF2]);
    CheckExternalEvents(cs7, 0x9B82);
    // MOV AX,SI (1000_9B80 / 0x19B80)
    AX = SI;
    CheckExternalEvents(cs7, 0x9B86);
    // MOV ES,word ptr [0x571a] (1000_9B82 / 0x19B82)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs7, 0x9B8B);
    // SUB AX,word ptr ES:[0x39f6] (1000_9B86 / 0x19B86)
    // AX -= UInt16[ES, 0x39F6];
    AX = Alu16.Sub(AX, UInt16[ES, 0x39F6]);
    CheckExternalEvents(cs7, 0x9B8C);
    // PUSH AX (1000_9B8B / 0x19B8B)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x9B8D);
    // PUSH SI (1000_9B8C / 0x19B8C)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x9B8E);
    // PUSH CS (1000_9B8D / 0x19B8D)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9B91);
    // CALL 0x1000:9841 (1000_9B8E / 0x19B8E)
    NearCall(cs7, 0x9B91, ghidra_guess_1000_9841_19841);
    CheckExternalEvents(cs7, 0x9B94);
    // ADD SP,0x6 (1000_9B91 / 0x19B91)
    SP += 0x6;
    CheckExternalEvents(cs7, 0x9B97);
    // INC word ptr [BP + -0x4] (1000_9B94 / 0x19B94)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1000_9B97_19B97:
    CheckExternalEvents(cs7, 0x9B9B);
    // MOV ES,word ptr [0x571e] (1000_9B97 / 0x19B97)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs7, 0x9B9F);
    // MOV AX,ES:[0x9c] (1000_9B9B / 0x19B9B)
    AX = UInt16[ES, 0x9C];
    CheckExternalEvents(cs7, 0x9BA2);
    // IMUL word ptr [BP + -0x4] (1000_9B9F / 0x19B9F)
    int resImul1000_9B9F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul1000_9B9F);
    DX = (ushort)(resImul1000_9B9F >> 16);
    CheckExternalEvents(cs7, 0x9BA4);
    // MOV SI,AX (1000_9BA2 / 0x19BA2)
    SI = AX;
    CheckExternalEvents(cs7, 0x9BA8);
    // MOV ES,word ptr [0x5716] (1000_9BA4 / 0x19BA4)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs7, 0x9BAD);
    // ADD SI,word ptr ES:[0x398c] (1000_9BA8 / 0x19BA8)
    // SI += UInt16[ES, 0x398C];
    SI = Alu16.Add(SI, UInt16[ES, 0x398C]);
    CheckExternalEvents(cs7, 0x9BB1);
    // MOV ES,word ptr [0x5718] (1000_9BAD / 0x19BAD)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs7, 0x9BB6);
    // CMP word ptr ES:[0x39a2],SI (1000_9BB1 / 0x19BB1)
    Alu16.Sub(UInt16[ES, 0x39A2], SI);
    CheckExternalEvents(cs7, 0x9BB8);
    // JG 0x1000:9b74 (1000_9BB6 / 0x19BB6)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_9B74_19B74;
    }
    CheckExternalEvents(cs7, 0x9BB9);
    // POP SI (1000_9BB8 / 0x19BB8)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9BBB);
    // MOV SP,BP (1000_9BB9 / 0x19BB9)
    SP = BP;
    CheckExternalEvents(cs7, 0x9BBC);
    // POP BP (1000_9BBB / 0x19BBB)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9BBD);
    // RETF  (1000_9BBC / 0x19BBC)
    return FarRet();
  }
  
  public virtual Action interrupt_handler_0x8_19BB_0020_19BD0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0020_19BD0:
    CheckExternalEvents(cs11, 0x25);
    // CALLF [0x16] (19BB_0020 / 0x19BD0)
    // Indirect call to [0x16], generating possible targets from emulator records
    uint targetAddress_19BB_0020 = (uint)(UInt16[cs11, 0x18] * 0x10 + UInt16[cs11, 0x16] - cs1 * 0x10);
    switch(targetAddress_19BB_0020) {
      case 0x19E48 : FarCall(cs11, 0x25, unknown_19BB_0298_19E48); break;
      case 0x19D36 : FarCall(cs11, 0x25, unknown_19BB_0186_19D36); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_19BB_0020));
        break;
    }
    CheckExternalEvents(cs11, 0x26);
    // PUSH AX (19BB_0025 / 0x19BD5)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x2A);
    // MOV AX,CS:[0xe] (19BB_0026 / 0x19BD6)
    AX = UInt16[cs11, 0xE];
    CheckExternalEvents(cs11, 0x2C);
    // CMP AL,0x0 (19BB_002A / 0x19BDA)
    Alu8.Sub(AL, 0x0);
    CheckExternalEvents(cs11, 0x2E);
    // JNZ 0x1000:9bec (19BB_002C / 0x19BDC)
    if(!ZeroFlag) {
      goto label_19BB_003C_19BEC;
    }
    CheckExternalEvents(cs11, 0x32);
    // MOV AX,CS:[0x10] (19BB_002E / 0x19BDE)
    AX = UInt16[cs11, 0x10];
    CheckExternalEvents(cs11, 0x36);
    // MOV CS:[0xe],AX (19BB_0032 / 0x19BE2)
    UInt16[cs11, 0xE] = AX;
    CheckExternalEvents(cs11, 0x37);
    // POP AX (19BB_0036 / 0x19BE6)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x3C);
    // JMPF CS:[0x12] (19BB_0037 / 0x19BE7)
    // Indirect jump to CS:[0x12], generating possible targets from emulator records
    uint targetAddress_19BB_0037 = (uint)(UInt16[cs11, 0x14] * 0x10 + UInt16[cs11, 0x12] - cs1 * 0x10);
    switch(targetAddress_19BB_0037) {
      case 0xF0006 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(provided_interrupt_handler_8_F000_0006_F0006, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_19BB_0037));
        break;
    }
    label_19BB_003C_19BEC:
    CheckExternalEvents(cs11, 0x3E);
    // DEC AL (19BB_003C / 0x19BEC)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs11, 0x42);
    // MOV CS:[0xe],AX (19BB_003E / 0x19BEE)
    UInt16[cs11, 0xE] = AX;
    CheckExternalEvents(cs11, 0x44);
    // MOV AL,0x20 (19BB_0042 / 0x19BF2)
    AL = 0x20;
    CheckExternalEvents(cs11, 0x46);
    // OUT 0x20,AL (19BB_0044 / 0x19BF4)
    Cpu.Out8(0x20, AL);
    CheckExternalEvents(cs11, 0x47);
    // POP AX (19BB_0046 / 0x19BF6)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x48);
    // IRET  (19BB_0047 / 0x19BF7)
    return InterruptRet();
  }
  
  public virtual Action unknown_19BB_0048_19BF8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0048_19BF8:
    CheckExternalEvents(cs11, 0x49);
    // PUSH DS (19BB_0048 / 0x19BF8)
    Stack.Push16(DS);
    CheckExternalEvents(cs11, 0x4C);
    // MOV AX,0x0 (19BB_0049 / 0x19BF9)
    AX = 0x0;
    CheckExternalEvents(cs11, 0x4E);
    // MOV DS,AX (19BB_004C / 0x19BFC)
    DS = AX;
    CheckExternalEvents(cs11, 0x51);
    // MOV AX,[0x20] (19BB_004E / 0x19BFE)
    AX = UInt16[DS, 0x20];
    CheckExternalEvents(cs11, 0x55);
    // MOV CS:[0x12],AX (19BB_0051 / 0x19C01)
    UInt16[cs11, 0x12] = AX;
    CheckExternalEvents(cs11, 0x58);
    // MOV AX,[0x22] (19BB_0055 / 0x19C05)
    AX = UInt16[DS, 0x22];
    CheckExternalEvents(cs11, 0x5C);
    // MOV CS:[0x14],AX (19BB_0058 / 0x19C08)
    UInt16[cs11, 0x14] = AX;
    CheckExternalEvents(cs11, 0x63);
    // MOV word ptr CS:[0x10],0x10 (19BB_005C / 0x19C0C)
    UInt16[cs11, 0x10] = 0x10;
    CheckExternalEvents(cs11, 0x6A);
    // MOV word ptr CS:[0xe],0x0 (19BB_0063 / 0x19C13)
    UInt16[cs11, 0xE] = 0x0;
    CheckExternalEvents(cs11, 0x6D);
    // MOV AX,0x186 (19BB_006A / 0x19C1A)
    AX = 0x186;
    CheckExternalEvents(cs11, 0x71);
    // MOV CS:[0x16],AX (19BB_006D / 0x19C1D)
    UInt16[cs11, 0x16] = AX;
    CheckExternalEvents(cs11, 0x72);
    // PUSH CS (19BB_0071 / 0x19C21)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x73);
    // POP AX (19BB_0072 / 0x19C22)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x77);
    // MOV CS:[0x18],AX (19BB_0073 / 0x19C23)
    UInt16[cs11, 0x18] = AX;
    CheckExternalEvents(cs11, 0x7A);
    // MOV DX,0x20 (19BB_0077 / 0x19C27)
    DX = 0x20;
    CheckExternalEvents(cs11, 0x7B);
    // PUSH CS (19BB_007A / 0x19C2A)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x7C);
    // POP DS (19BB_007B / 0x19C2B)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x7E);
    // MOV AH,0x25 (19BB_007C / 0x19C2C)
    AH = 0x25;
    CheckExternalEvents(cs11, 0x80);
    // MOV AL,0x8 (19BB_007E / 0x19C2E)
    AL = 0x8;
    CheckExternalEvents(cs11, 0x82);
    // INT 0x21 (19BB_0080 / 0x19C30)
    Interrupt(0x21);
    CheckExternalEvents(cs11, 0x84);
    // MOV AL,0x36 (19BB_0082 / 0x19C32)
    AL = 0x36;
    CheckExternalEvents(cs11, 0x86);
    // OUT 0x43,AL (19BB_0084 / 0x19C34)
    Cpu.Out8(0x43, AL);
    CheckExternalEvents(cs11, 0x89);
    // MOV AX,0xfff (19BB_0086 / 0x19C36)
    AX = 0xFFF;
    CheckExternalEvents(cs11, 0x8B);
    // OUT 0x40,AL (19BB_0089 / 0x19C39)
    Cpu.Out8(0x40, AL);
    CheckExternalEvents(cs11, 0x8D);
    // MOV AL,AH (19BB_008B / 0x19C3B)
    AL = AH;
    CheckExternalEvents(cs11, 0x8F);
    // OUT 0x40,AL (19BB_008D / 0x19C3D)
    Cpu.Out8(0x40, AL);
    CheckExternalEvents(cs11, 0x90);
    // POP DS (19BB_008F / 0x19C3F)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x91);
    // RETF  (19BB_0090 / 0x19C40)
    return FarRet();
  }
  
  public virtual Action unknown_19BB_0091_19C41(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0091_19C41:
    CheckExternalEvents(cs11, 0x92);
    // PUSH DS (19BB_0091 / 0x19C41)
    Stack.Push16(DS);
    CheckExternalEvents(cs11, 0x97);
    // MOV DX,word ptr CS:[0x12] (19BB_0092 / 0x19C42)
    DX = UInt16[cs11, 0x12];
    CheckExternalEvents(cs11, 0x9B);
    // MOV AX,CS:[0x14] (19BB_0097 / 0x19C47)
    AX = UInt16[cs11, 0x14];
    CheckExternalEvents(cs11, 0x9C);
    // PUSH AX (19BB_009B / 0x19C4B)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x9D);
    // POP DS (19BB_009C / 0x19C4C)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x9F);
    // MOV AH,0x25 (19BB_009D / 0x19C4D)
    AH = 0x25;
    CheckExternalEvents(cs11, 0xA1);
    // MOV AL,0x8 (19BB_009F / 0x19C4F)
    AL = 0x8;
    CheckExternalEvents(cs11, 0xA3);
    // INT 0x21 (19BB_00A1 / 0x19C51)
    Interrupt(0x21);
    CheckExternalEvents(cs11, 0xA5);
    // MOV AL,0x36 (19BB_00A3 / 0x19C53)
    AL = 0x36;
    CheckExternalEvents(cs11, 0xA7);
    // OUT 0x43,AL (19BB_00A5 / 0x19C55)
    Cpu.Out8(0x43, AL);
    CheckExternalEvents(cs11, 0xAA);
    // MOV AX,0xffff (19BB_00A7 / 0x19C57)
    AX = 0xFFFF;
    CheckExternalEvents(cs11, 0xAC);
    // OUT 0x40,AL (19BB_00AA / 0x19C5A)
    Cpu.Out8(0x40, AL);
    CheckExternalEvents(cs11, 0xAE);
    // MOV AL,AH (19BB_00AC / 0x19C5C)
    AL = AH;
    CheckExternalEvents(cs11, 0xB0);
    // OUT 0x40,AL (19BB_00AE / 0x19C5E)
    Cpu.Out8(0x40, AL);
    CheckExternalEvents(cs11, 0xB1);
    // POP DS (19BB_00B0 / 0x19C60)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs11, 0xB2);
    // RETF  (19BB_00B1 / 0x19C61)
    return FarRet();
  }
  
  public virtual Action unknown_19BB_00B2_19C62(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_00B2_19C62:
    CheckExternalEvents(cs11, 0xB3);
    // PUSH AX (19BB_00B2 / 0x19C62)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0xB5);
    // MOV AL,CL (19BB_00B3 / 0x19C63)
    AL = CL;
    CheckExternalEvents(cs11, 0xB7);
    // OUT 0x42,AL (19BB_00B5 / 0x19C65)
    Cpu.Out8(0x42, AL);
    CheckExternalEvents(cs11, 0xB9);
    // MOV AL,CH (19BB_00B7 / 0x19C67)
    AL = CH;
    CheckExternalEvents(cs11, 0xBB);
    // OUT 0x42,AL (19BB_00B9 / 0x19C69)
    Cpu.Out8(0x42, AL);
    CheckExternalEvents(cs11, 0xBC);
    // POP AX (19BB_00BB / 0x19C6B)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0xBD);
    // RET  (19BB_00BC / 0x19C6C)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_00BD_19C6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_00BD_19C6D:
    CheckExternalEvents(cs11, 0xBE);
    // PUSH AX (19BB_00BD / 0x19C6D)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0xC0);
    // IN AL,0x61 (19BB_00BE / 0x19C6E)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs11, 0xC2);
    // OR AL,0x3 (19BB_00C0 / 0x19C70)
    // AL |= 0x3;
    AL = Alu8.Or(AL, 0x3);
    CheckExternalEvents(cs11, 0xC4);
    // OUT 0x61,AL (19BB_00C2 / 0x19C72)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs11, 0xC5);
    // POP AX (19BB_00C4 / 0x19C74)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0xC6);
    // RET  (19BB_00C5 / 0x19C75)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_00C6_19C76(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_00C6_19C76:
    CheckExternalEvents(cs11, 0xC7);
    // PUSH AX (19BB_00C6 / 0x19C76)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0xC9);
    // IN AL,0x61 (19BB_00C7 / 0x19C77)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs11, 0xCB);
    // AND AL,0xfc (19BB_00C9 / 0x19C79)
    // AL &= 0xFC;
    AL = Alu8.And(AL, 0xFC);
    CheckExternalEvents(cs11, 0xCD);
    // OUT 0x61,AL (19BB_00CB / 0x19C7B)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs11, 0xCE);
    // POP AX (19BB_00CD / 0x19C7D)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0xCF);
    // RET  (19BB_00CE / 0x19C7E)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_00CF_19C7F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_00CF_19C7F:
    CheckExternalEvents(cs11, 0xD0);
    // PUSH DX (19BB_00CF / 0x19C7F)
    Stack.Push16(DX);
    CheckExternalEvents(cs11, 0xD1);
    // PUSH AX (19BB_00D0 / 0x19C80)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0xD4);
    // MOV DX,0x12 (19BB_00D1 / 0x19C81)
    DX = 0x12;
    CheckExternalEvents(cs11, 0xD7);
    // MOV AX,0x34de (19BB_00D4 / 0x19C84)
    AX = 0x34DE;
    CheckExternalEvents(cs11, 0xD9);
    // DIV CX (19BB_00D7 / 0x19C87)
    uint op1Div19BB_00D7 = (DX << 16 | AX);
    ushort op2Div19BB_00D7 = CX;
    ushort? resDiv19BB_00D7 = Alu16.Div(op1Div19BB_00D7, op2Div19BB_00D7);
    if(resDiv19BB_00D7 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = resDiv19BB_00D7.Value;
    DX = (ushort)(op1Div19BB_00D7 % op2Div19BB_00D7);
    CheckExternalEvents(cs11, 0xDB);
    // MOV CX,AX (19BB_00D9 / 0x19C89)
    CX = AX;
    CheckExternalEvents(cs11, 0xDC);
    // POP AX (19BB_00DB / 0x19C8B)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0xDD);
    // POP DX (19BB_00DC / 0x19C8C)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0xDE);
    // RET  (19BB_00DD / 0x19C8D)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_0139_19CE9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0139_19CE9:
    CheckExternalEvents(cs11, 0x13A);
    // PUSH CX (19BB_0139 / 0x19CE9)
    Stack.Push16(CX);
    CheckExternalEvents(cs11, 0x13B);
    // PUSH BX (19BB_013A / 0x19CEA)
    Stack.Push16(BX);
    CheckExternalEvents(cs11, 0x13C);
    // PUSH AX (19BB_013B / 0x19CEB)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x13E);
    // MOV AH,0x0 (19BB_013C / 0x19CEC)
    AH = 0x0;
    CheckExternalEvents(cs11, 0x140);
    // MOV CL,0xc (19BB_013E / 0x19CEE)
    CL = 0xC;
    CheckExternalEvents(cs11, 0x142);
    // DIV CL (19BB_0140 / 0x19CF0)
    ushort op1Div19BB_0140 = AX;
    byte op2Div19BB_0140 = CL;
    byte? resDiv19BB_0140 = Alu8.Div(op1Div19BB_0140, op2Div19BB_0140);
    if(resDiv19BB_0140 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AL = resDiv19BB_0140.Value;
    AH = (byte)(op1Div19BB_0140 % op2Div19BB_0140);
    CheckExternalEvents(cs11, 0x144);
    // MOV DL,AL (19BB_0142 / 0x19CF2)
    DL = AL;
    CheckExternalEvents(cs11, 0x146);
    // MOV AL,AH (19BB_0144 / 0x19CF4)
    AL = AH;
    CheckExternalEvents(cs11, 0x147);
    // CBW  (19BB_0146 / 0x19CF6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs11, 0x149);
    // SHL AX,0x1 (19BB_0147 / 0x19CF7)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs11, 0x14B);
    // MOV BX,AX (19BB_0149 / 0x19CF9)
    BX = AX;
    CheckExternalEvents(cs11, 0x150);
    // MOV CX,word ptr CS:[BX + 0x121] (19BB_014B / 0x19CFB)
    CX = UInt16[cs11, (ushort)(BX + 0x121)];
    CheckExternalEvents(cs11, 0x153);
    // CALL 0x1000:9c7f (19BB_0150 / 0x19D00)
    NearCall(cs11, 0x153, unknown_19BB_00CF_19C7F);
    CheckExternalEvents(cs11, 0x155);
    // XCHG DX,CX (19BB_0153 / 0x19D03)
    (CX, DX) = (DX, CX);
    CheckExternalEvents(cs11, 0x157);
    // NEG CL (19BB_0155 / 0x19D05)
    CL = Alu8.Sub(0, CL);
    CheckExternalEvents(cs11, 0x15A);
    // ADD CL,0x8 (19BB_0157 / 0x19D07)
    CL += 0x8;
    CheckExternalEvents(cs11, 0x15C);
    // SHL DX,CL (19BB_015A / 0x19D0A)
    // DX <<= CL;
    DX = Alu16.Shl(DX, CL);
    CheckExternalEvents(cs11, 0x15D);
    // POP AX (19BB_015C / 0x19D0C)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x15E);
    // POP BX (19BB_015D / 0x19D0D)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x15F);
    // POP CX (19BB_015E / 0x19D0E)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x160);
    // RET  (19BB_015F / 0x19D0F)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_0179_19D29(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0179_19D29:
    CheckExternalEvents(cs11, 0x17A);
    // PUSH AX (19BB_0179 / 0x19D29)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x17D);
    // MOV AX,0x186 (19BB_017A / 0x19D2A)
    AX = 0x186;
    CheckExternalEvents(cs11, 0x181);
    // MOV CS:[0x16],AX (19BB_017D / 0x19D2D)
    UInt16[cs11, 0x16] = AX;
    CheckExternalEvents(cs11, 0x184);
    // CALL 0x1000:9c76 (19BB_0181 / 0x19D31)
    NearCall(cs11, 0x184, unknown_19BB_00C6_19C76);
    CheckExternalEvents(cs11, 0x185);
    // POP AX (19BB_0184 / 0x19D34)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x186);
    // RET  (19BB_0185 / 0x19D35)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_0186_19D36(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0186_19D36:
    CheckExternalEvents(cs11, 0x187);
    // RETF  (19BB_0186 / 0x19D36)
    return FarRet();
  }
  
  public virtual Action unknown_19BB_0233_19DE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0233_19DE3:
    CheckExternalEvents(cs11, 0x236);
    // MOV AX,word ptr [BP + 0x8] (19BB_0233 / 0x19DE3)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs11, 0x23A);
    // MOV CS:[0x205],AX (19BB_0236 / 0x19DE6)
    UInt16[cs11, 0x205] = AX;
    CheckExternalEvents(cs11, 0x23D);
    // MOV AX,word ptr [BP + 0xa] (19BB_023A / 0x19DEA)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs11, 0x241);
    // MOV CS:[0x207],AX (19BB_023D / 0x19DED)
    UInt16[cs11, 0x207] = AX;
    CheckExternalEvents(cs11, 0x244);
    // MOV AX,word ptr [BP + 0xc] (19BB_0241 / 0x19DF1)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs11, 0x248);
    // MOV CS:[0x20a],AL (19BB_0244 / 0x19DF4)
    UInt8[cs11, 0x20A] = AL;
    CheckExternalEvents(cs11, 0x24E);
    // MOV byte ptr CS:[0x209],0x1 (19BB_0248 / 0x19DF8)
    UInt8[cs11, 0x209] = 0x1;
    CheckExternalEvents(cs11, 0x24F);
    // RET  (19BB_024E / 0x19DFE)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_0298_19E48(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0298_19E48:
    CheckExternalEvents(cs11, 0x29D);
    // DEC byte ptr CS:[0x209] (19BB_0298 / 0x19E48)
    UInt8[cs11, 0x209]--;
    CheckExternalEvents(cs11, 0x2A3);
    // CMP byte ptr CS:[0x209],0x0 (19BB_029D / 0x19E4D)
    Alu8.Sub(UInt8[cs11, 0x209], 0x0);
    CheckExternalEvents(cs11, 0x2A5);
    // JNZ 0x1000:9e8c (19BB_02A3 / 0x19E53)
    if(!ZeroFlag) {
      // JNZ target is RETF, inlining.
      CheckExternalEvents(cs11, 0x2DD);
      // RETF  (19BB_02DC / 0x19E8C)
      return FarRet();
    }
    CheckExternalEvents(cs11, 0x2A6);
    // PUSH AX (19BB_02A5 / 0x19E55)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x2AA);
    // MOV AL,CS:[0x20a] (19BB_02A6 / 0x19E56)
    AL = UInt8[cs11, 0x20A];
    CheckExternalEvents(cs11, 0x2AE);
    // MOV CS:[0x209],AL (19BB_02AA / 0x19E5A)
    UInt8[cs11, 0x209] = AL;
    CheckExternalEvents(cs11, 0x2AF);
    // PUSH DS (19BB_02AE / 0x19E5E)
    Stack.Push16(DS);
    CheckExternalEvents(cs11, 0x2B0);
    // PUSH SI (19BB_02AF / 0x19E5F)
    Stack.Push16(SI);
    CheckExternalEvents(cs11, 0x2B5);
    // LDS SI,CS:[0x205] (19BB_02B0 / 0x19E60)
    SI = UInt16[cs11, 0x205];
    DS = UInt16[cs11, 0x207];
    CheckExternalEvents(cs11, 0x2B6);
    // LODSB SI (19BB_02B5 / 0x19E65)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs11, 0x2B8);
    // CMP AL,0x0 (19BB_02B6 / 0x19E66)
    Alu8.Sub(AL, 0x0);
    CheckExternalEvents(cs11, 0x2BA);
    // JNZ 0x1000:9e6f (19BB_02B8 / 0x19E68)
    if(!ZeroFlag) {
      goto label_19BB_02BF_19E6F;
    }
    CheckExternalEvents(cs11, 0x2BB);
    // LODSB SI (19BB_02BA / 0x19E6A)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs11, 0x2BD);
    // CMP AL,0x0 (19BB_02BB / 0x19E6B)
    Alu8.Sub(AL, 0x0);
    CheckExternalEvents(cs11, 0x2BF);
    // JZ 0x1000:9e8d (19BB_02BD / 0x19E6D)
    if(ZeroFlag) {
      goto label_19BB_02DD_19E8D;
    }
    label_19BB_02BF_19E6F:
    CheckExternalEvents(cs11, 0x2C4);
    // MOV word ptr CS:[0x205],SI (19BB_02BF / 0x19E6F)
    UInt16[cs11, 0x205] = SI;
    CheckExternalEvents(cs11, 0x2C5);
    // POP SI (19BB_02C4 / 0x19E74)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x2C6);
    // POP DS (19BB_02C5 / 0x19E75)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x2C7);
    // PUSH DX (19BB_02C6 / 0x19E76)
    Stack.Push16(DX);
    CheckExternalEvents(cs11, 0x2C8);
    // PUSH CX (19BB_02C7 / 0x19E77)
    Stack.Push16(CX);
    CheckExternalEvents(cs11, 0x2CA);
    // TEST AL,0x80 (19BB_02C8 / 0x19E78)
    Alu8.And(AL, 0x80);
    CheckExternalEvents(cs11, 0x2CC);
    // JZ 0x1000:9e81 (19BB_02CA / 0x19E7A)
    if(ZeroFlag) {
      goto label_19BB_02D1_19E81;
    }
    CheckExternalEvents(cs11, 0x2CF);
    // MOV CX,0xe (19BB_02CC / 0x19E7C)
    CX = 0xE;
    CheckExternalEvents(cs11, 0x2D1);
    // JMP 0x1000:9e86 (19BB_02CF / 0x19E7F)
    goto label_19BB_02D6_19E86;
    label_19BB_02D1_19E81:
    CheckExternalEvents(cs11, 0x2D4);
    // CALL 0x1000:9ce9 (19BB_02D1 / 0x19E81)
    NearCall(cs11, 0x2D4, unknown_19BB_0139_19CE9);
    CheckExternalEvents(cs11, 0x2D6);
    // MOV CX,DX (19BB_02D4 / 0x19E84)
    CX = DX;
    label_19BB_02D6_19E86:
    CheckExternalEvents(cs11, 0x2D9);
    // CALL 0x1000:9c62 (19BB_02D6 / 0x19E86)
    NearCall(cs11, 0x2D9, unknown_19BB_00B2_19C62);
    CheckExternalEvents(cs11, 0x2DA);
    // POP CX (19BB_02D9 / 0x19E89)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x2DB);
    // POP DX (19BB_02DA / 0x19E8A)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x2DC);
    // POP AX (19BB_02DB / 0x19E8B)
    AX = Stack.Pop16();;
    label_19BB_02DC_19E8C:
    CheckExternalEvents(cs11, 0x2DD);
    // RETF  (19BB_02DC / 0x19E8C)
    return FarRet();
    label_19BB_02DD_19E8D:
    CheckExternalEvents(cs11, 0x2DE);
    // POP SI (19BB_02DD / 0x19E8D)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x2DF);
    // POP DS (19BB_02DE / 0x19E8E)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x2E0);
    // POP AX (19BB_02DF / 0x19E8F)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x2E3);
    // CALL 0x1000:9d29 (19BB_02E0 / 0x19E90)
    NearCall(cs11, 0x2E3, unknown_19BB_0179_19D29);
    CheckExternalEvents(cs11, 0x2E4);
    // RETF  (19BB_02E3 / 0x19E93)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9E94_19E94(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9E94_19E94:
    CheckExternalEvents(cs7, 0x9E95);
    // PUSH BP (1000_9E94 / 0x19E94)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9E97);
    // MOV BP,SP (1000_9E95 / 0x19E95)
    BP = SP;
    CheckExternalEvents(cs7, 0x9E9A);
    // MOV BX,word ptr [BP + 0x6] (1000_9E97 / 0x19E97)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x9E9D);
    // CMP BX,0xd (1000_9E9A / 0x19E9A)
    Alu16.Sub(BX, 0xD);
    CheckExternalEvents(cs7, 0x9E9F);
    // JGE 0x1000:9eb4 (1000_9E9D / 0x19E9D)
    if(SignFlag == OverflowFlag) {
      goto label_1000_9EB4_19EB4;
    }
    CheckExternalEvents(cs7, 0x9EA1);
    // ADD BX,BX (1000_9E9F / 0x19E9F)
    BX += BX;
    CheckExternalEvents(cs7, 0x9EA3);
    // ADD BX,BX (1000_9EA1 / 0x19EA1)
    // BX += BX;
    BX = Alu16.Add(BX, BX);
    CheckExternalEvents(cs7, 0x9EA6);
    // CALL 0x1000:9c6d (1000_9EA3 / 0x19EA3)
    NearCall(cs7, 0x9EA6, unknown_19BB_00BD_19C6D);
    CheckExternalEvents(cs7, 0x9EAB);
    // CALL word ptr CS:[BX + 0x328] (1000_9EA6 / 0x19EA6)
    // Indirect call to word ptr CS:[BX + 0x328], generating possible targets from emulator records
    uint targetAddress_1000_9EA6 = (uint)(cs7 * 0x10 + UInt16[cs7, (ushort)(BX + 0x328)] - cs1 * 0x10);
    switch(targetAddress_1000_9EA6) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_9EA6));
        break;
    }
    CheckExternalEvents(cs7, 0x9EB0);
    // MOV AX,word ptr CS:[BX + 0x32a] (1000_9EAB / 0x19EAB)
    AX = UInt16[cs7, (ushort)(BX + 0x32A)];
    CheckExternalEvents(cs7, 0x9EB4);
    // MOV CS:[0x16],AX (1000_9EB0 / 0x19EB0)
    UInt16[cs7, 0x16] = AX;
    label_1000_9EB4_19EB4:
    CheckExternalEvents(cs7, 0x9EB5);
    // POP BP (1000_9EB4 / 0x19EB4)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9EB6);
    // RETF  (1000_9EB5 / 0x19EB5)
    return FarRet();
  }
  
  public virtual Action unknown_19BB_0306_19EB6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0306_19EB6:
    CheckExternalEvents(cs11, 0x307);
    // PUSH BP (19BB_0306 / 0x19EB6)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x309);
    // MOV BP,SP (19BB_0307 / 0x19EB7)
    BP = SP;
    CheckExternalEvents(cs11, 0x30C);
    // MOV BX,word ptr [BP + 0x6] (19BB_0309 / 0x19EB9)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs11, 0x30F);
    // CMP BX,0xd (19BB_030C / 0x19EBC)
    Alu16.Sub(BX, 0xD);
    CheckExternalEvents(cs11, 0x311);
    // JGE 0x1000:9ed6 (19BB_030F / 0x19EBF)
    if(SignFlag == OverflowFlag) {
      goto label_19BB_0326_19ED6;
    }
    CheckExternalEvents(cs11, 0x313);
    // ADD BX,BX (19BB_0311 / 0x19EC1)
    BX += BX;
    CheckExternalEvents(cs11, 0x315);
    // ADD BX,BX (19BB_0313 / 0x19EC3)
    // BX += BX;
    BX = Alu16.Add(BX, BX);
    CheckExternalEvents(cs11, 0x318);
    // CALL 0x1000:9c6d (19BB_0315 / 0x19EC5)
    NearCall(cs11, 0x318, unknown_19BB_00BD_19C6D);
    CheckExternalEvents(cs11, 0x31D);
    // CALL word ptr CS:[BX + 0x332] (19BB_0318 / 0x19EC8)
    // Indirect call to word ptr CS:[BX + 0x332], generating possible targets from emulator records
    uint targetAddress_19BB_0318 = (uint)(cs11 * 0x10 + UInt16[cs11, (ushort)(BX + 0x332)] - cs1 * 0x10);
    switch(targetAddress_19BB_0318) {
      case 0x19D29 : NearCall(cs11, 0x31D, unknown_19BB_0179_19D29); break;
      case 0x19DE3 : NearCall(cs11, 0x31D, unknown_19BB_0233_19DE3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_19BB_0318));
        break;
    }
    CheckExternalEvents(cs11, 0x322);
    // MOV AX,word ptr CS:[BX + 0x334] (19BB_031D / 0x19ECD)
    AX = UInt16[cs11, (ushort)(BX + 0x334)];
    CheckExternalEvents(cs11, 0x326);
    // MOV CS:[0x16],AX (19BB_0322 / 0x19ED2)
    UInt16[cs11, 0x16] = AX;
    label_19BB_0326_19ED6:
    CheckExternalEvents(cs11, 0x327);
    // POP BP (19BB_0326 / 0x19ED6)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x328);
    // RETF  (19BB_0327 / 0x19ED7)
    return FarRet();
  }
  
  public virtual Action unknown_19BB_033C_19EEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_033C_19EEC:
    CheckExternalEvents(cs11, 0x340);
    // MOV AX,CS:[0x16] (19BB_033C / 0x19EEC)
    AX = UInt16[cs11, 0x16];
    CheckExternalEvents(cs11, 0x343);
    // XOR AX,0x186 (19BB_0340 / 0x19EF0)
    // AX ^= 0x186;
    AX = Alu16.Xor(AX, 0x186);
    CheckExternalEvents(cs11, 0x345);
    // JZ 0x1000:9ef8 (19BB_0343 / 0x19EF3)
    if(ZeroFlag) {
      goto label_19BB_0348_19EF8;
    }
    CheckExternalEvents(cs11, 0x347);
    // XOR AX,AX (19BB_0345 / 0x19EF5)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs11, 0x348);
    // RETF  (19BB_0347 / 0x19EF7)
    return FarRet();
    label_19BB_0348_19EF8:
    CheckExternalEvents(cs11, 0x34B);
    // MOV AX,0x1 (19BB_0348 / 0x19EF8)
    AX = 0x1;
    CheckExternalEvents(cs11, 0x34C);
    // RETF  (19BB_034B / 0x19EFB)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9F0C_19F0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F0C_19F0C:
    CheckExternalEvents(cs7, 0x9F0D);
    // PUSH BP (1000_9F0C / 0x19F0C)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9F0F);
    // MOV BP,SP (1000_9F0D / 0x19F0D)
    BP = SP;
    CheckExternalEvents(cs7, 0x9F10);
    // PUSH DI (1000_9F0F / 0x19F0F)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x9F11);
    // PUSH SI (1000_9F10 / 0x19F10)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x9F12);
    // PUSH DS (1000_9F11 / 0x19F11)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x9F15);
    // MOV AX,0x1ddc (1000_9F12 / 0x19F12)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0x9F17);
    // MOV DS,AX (1000_9F15 / 0x19F15)
    DS = AX;
    CheckExternalEvents(cs7, 0x9F19);
    // MOV AL,0xb6 (1000_9F17 / 0x19F17)
    AL = 0xB6;
    CheckExternalEvents(cs7, 0x9F1B);
    // OUT 0x43,AL (1000_9F19 / 0x19F19)
    Cpu.Out8(0x43, AL);
    CheckExternalEvents(cs7, 0x9F1C);
    // POP DS (1000_9F1B / 0x19F1B)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F1D);
    // POP SI (1000_9F1C / 0x19F1C)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F1E);
    // POP DI (1000_9F1D / 0x19F1D)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F1F);
    // POP BP (1000_9F1E / 0x19F1E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F20);
    // RETF  (1000_9F1F / 0x19F1F)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9F20_19F20(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F20_19F20:
    CheckExternalEvents(cs7, 0x9F21);
    // PUSH BP (1000_9F20 / 0x19F20)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9F23);
    // MOV BP,SP (1000_9F21 / 0x19F21)
    BP = SP;
    CheckExternalEvents(cs7, 0x9F24);
    // PUSH DI (1000_9F23 / 0x19F23)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x9F25);
    // PUSH SI (1000_9F24 / 0x19F24)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x9F26);
    // PUSH DS (1000_9F25 / 0x19F25)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x9F29);
    // MOV AX,0x1ddc (1000_9F26 / 0x19F26)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0x9F2B);
    // MOV DS,AX (1000_9F29 / 0x19F29)
    DS = AX;
    CheckExternalEvents(cs7, 0x9F2E);
    // MOV BX,word ptr [BP + 0x6] (1000_9F2B / 0x19F2B)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x9F30);
    // MOV AX,BX (1000_9F2E / 0x19F2E)
    AX = BX;
    CheckExternalEvents(cs7, 0x9F32);
    // OUT 0x42,AL (1000_9F30 / 0x19F30)
    Cpu.Out8(0x42, AL);
    CheckExternalEvents(cs7, 0x9F34);
    // MOV AL,AH (1000_9F32 / 0x19F32)
    AL = AH;
    CheckExternalEvents(cs7, 0x9F36);
    // OUT 0x42,AL (1000_9F34 / 0x19F34)
    Cpu.Out8(0x42, AL);
    CheckExternalEvents(cs7, 0x9F38);
    // IN AL,0x61 (1000_9F36 / 0x19F36)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs7, 0x9F3A);
    // OR AL,0x3 (1000_9F38 / 0x19F38)
    // AL |= 0x3;
    AL = Alu8.Or(AL, 0x3);
    CheckExternalEvents(cs7, 0x9F3C);
    // OUT 0x61,AL (1000_9F3A / 0x19F3A)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs7, 0x9F3D);
    // POP DS (1000_9F3C / 0x19F3C)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F3E);
    // POP SI (1000_9F3D / 0x19F3D)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F3F);
    // POP DI (1000_9F3E / 0x19F3E)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F40);
    // POP BP (1000_9F3F / 0x19F3F)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F41);
    // RETF  (1000_9F40 / 0x19F40)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9F41_19F41(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F41_19F41:
    CheckExternalEvents(cs7, 0x9F42);
    // PUSH BP (1000_9F41 / 0x19F41)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9F44);
    // MOV BP,SP (1000_9F42 / 0x19F42)
    BP = SP;
    CheckExternalEvents(cs7, 0x9F45);
    // PUSH DI (1000_9F44 / 0x19F44)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x9F46);
    // PUSH SI (1000_9F45 / 0x19F45)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x9F47);
    // PUSH DS (1000_9F46 / 0x19F46)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x9F4A);
    // MOV AX,0x1ddc (1000_9F47 / 0x19F47)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0x9F4C);
    // MOV DS,AX (1000_9F4A / 0x19F4A)
    DS = AX;
    CheckExternalEvents(cs7, 0x9F4E);
    // IN AL,0x61 (1000_9F4C / 0x19F4C)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs7, 0x9F50);
    // AND AL,0xfc (1000_9F4E / 0x19F4E)
    // AL &= 0xFC;
    AL = Alu8.And(AL, 0xFC);
    CheckExternalEvents(cs7, 0x9F52);
    // OUT 0x61,AL (1000_9F50 / 0x19F50)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs7, 0x9F53);
    // POP DS (1000_9F52 / 0x19F52)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F54);
    // POP SI (1000_9F53 / 0x19F53)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F55);
    // POP DI (1000_9F54 / 0x19F54)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F56);
    // POP BP (1000_9F55 / 0x19F55)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F57);
    // RETF  (1000_9F56 / 0x19F56)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9F57_19F57(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F57_19F57:
    CheckExternalEvents(cs7, 0x9F58);
    // PUSH BP (1000_9F57 / 0x19F57)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9F5A);
    // MOV BP,SP (1000_9F58 / 0x19F58)
    BP = SP;
    CheckExternalEvents(cs7, 0x9F5B);
    // PUSH DI (1000_9F5A / 0x19F5A)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x9F5C);
    // PUSH SI (1000_9F5B / 0x19F5B)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x9F5D);
    // PUSH DS (1000_9F5C / 0x19F5C)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x9F60);
    // MOV AX,0x1ddc (1000_9F5D / 0x19F5D)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0x9F62);
    // MOV DS,AX (1000_9F60 / 0x19F60)
    DS = AX;
    CheckExternalEvents(cs7, 0x9F64);
    // IN AL,0x61 (1000_9F62 / 0x19F62)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs7, 0x9F66);
    // AND AL,0xfc (1000_9F64 / 0x19F64)
    // AL &= 0xFC;
    AL = Alu8.And(AL, 0xFC);
    CheckExternalEvents(cs7, 0x9F68);
    // OUT 0x61,AL (1000_9F66 / 0x19F66)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs7, 0x9F69);
    // POP DS (1000_9F68 / 0x19F68)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F6A);
    // POP SI (1000_9F69 / 0x19F69)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F6B);
    // POP DI (1000_9F6A / 0x19F6A)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F6C);
    // POP BP (1000_9F6B / 0x19F6B)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F6D);
    // RETF  (1000_9F6C / 0x19F6C)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9F6D_19F6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F6D_19F6D:
    CheckExternalEvents(cs7, 0x9F6E);
    // PUSH BP (1000_9F6D / 0x19F6D)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9F70);
    // MOV BP,SP (1000_9F6E / 0x19F6E)
    BP = SP;
    CheckExternalEvents(cs7, 0x9F71);
    // PUSH DI (1000_9F70 / 0x19F70)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x9F72);
    // PUSH SI (1000_9F71 / 0x19F71)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x9F73);
    // PUSH DS (1000_9F72 / 0x19F72)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x9F76);
    // MOV AX,0x1ddc (1000_9F73 / 0x19F73)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0x9F78);
    // MOV DS,AX (1000_9F76 / 0x19F76)
    DS = AX;
    CheckExternalEvents(cs7, 0x9F7B);
    // MOV AX,word ptr [BP + 0x6] (1000_9F78 / 0x19F78)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x9F7E);
    // MOV [0x252],AX (1000_9F7B / 0x19F7B)
    UInt16[DS, 0x252] = AX;
    CheckExternalEvents(cs7, 0x9F80);
    // IN AL,0x61 (1000_9F7E / 0x19F7E)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs7, 0x9F82);
    // XOR AL,0x2 (1000_9F80 / 0x19F80)
    // AL ^= 0x2;
    AL = Alu8.Xor(AL, 0x2);
    CheckExternalEvents(cs7, 0x9F84);
    // OUT 0x61,AL (1000_9F82 / 0x19F82)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs7, 0x9F88);
    // MOV DX,word ptr [0x252] (1000_9F84 / 0x19F84)
    DX = UInt16[DS, 0x252];
    CheckExternalEvents(cs7, 0x9F8C);
    // ADD DX,0x9248 (1000_9F88 / 0x19F88)
    // DX += 0x9248;
    DX = Alu16.Add(DX, 0x9248);
    CheckExternalEvents(cs7, 0x9F8E);
    // MOV CL,0x3 (1000_9F8C / 0x19F8C)
    CL = 0x3;
    CheckExternalEvents(cs7, 0x9F90);
    // ROR DX,CL (1000_9F8E / 0x19F8E)
    DX = Alu.Ror16(DX, CL);
    CheckExternalEvents(cs7, 0x9F94);
    // MOV word ptr [0x252],DX (1000_9F90 / 0x19F90)
    UInt16[DS, 0x252] = DX;
    CheckExternalEvents(cs7, 0x9F95);
    // POP DS (1000_9F94 / 0x19F94)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F96);
    // POP SI (1000_9F95 / 0x19F95)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F97);
    // POP DI (1000_9F96 / 0x19F96)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F98);
    // POP BP (1000_9F97 / 0x19F97)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9F99);
    // RETF  (1000_9F98 / 0x19F98)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9F99_19F99(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F99_19F99:
    CheckExternalEvents(cs7, 0x9F9A);
    // PUSH BP (1000_9F99 / 0x19F99)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9F9C);
    // MOV BP,SP (1000_9F9A / 0x19F9A)
    BP = SP;
    CheckExternalEvents(cs7, 0x9F9D);
    // PUSH DI (1000_9F9C / 0x19F9C)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x9F9E);
    // PUSH SI (1000_9F9D / 0x19F9D)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x9F9F);
    // PUSH DS (1000_9F9E / 0x19F9E)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x9FA2);
    // MOV AX,0x1ddc (1000_9F9F / 0x19F9F)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0x9FA4);
    // MOV DS,AX (1000_9FA2 / 0x19FA2)
    DS = AX;
    CheckExternalEvents(cs7, 0x9FA7);
    // MOV AX,word ptr [BP + 0x6] (1000_9FA4 / 0x19FA4)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x9FAA);
    // MOV [0x254],AX (1000_9FA7 / 0x19FA7)
    UInt16[DS, 0x254] = AX;
    CheckExternalEvents(cs7, 0x9FAD);
    // MOV AX,word ptr [BP + 0x8] (1000_9FAA / 0x19FAA)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x9FB0);
    // MOV [0x256],AX (1000_9FAD / 0x19FAD)
    UInt16[DS, 0x256] = AX;
    CheckExternalEvents(cs7, 0x9FB2);
    // MOV CX,DX (1000_9FB0 / 0x19FB0)
    CX = DX;
    CheckExternalEvents(cs7, 0x9FB6);
    // AND CX,word ptr [0x254] (1000_9FB2 / 0x19FB2)
    // CX &= UInt16[DS, 0x254];
    CX = Alu16.And(CX, UInt16[DS, 0x254]);
    CheckExternalEvents(cs7, 0x9FBA);
    // OR CX,word ptr [0x256] (1000_9FB6 / 0x19FB6)
    // CX |= UInt16[DS, 0x256];
    CX = Alu16.Or(CX, UInt16[DS, 0x256]);
    label_1000_9FBA_19FBA:
    CheckExternalEvents(cs7, 0x9FBC);
    // LOOP 0x1000:9fba (1000_9FBA / 0x19FBA)
    if(--CX != 0) {
      goto label_1000_9FBA_19FBA;
    }
    CheckExternalEvents(cs7, 0x9FBD);
    // POP DS (1000_9FBC / 0x19FBC)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9FBE);
    // POP SI (1000_9FBD / 0x19FBD)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9FBF);
    // POP DI (1000_9FBE / 0x19FBE)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9FC0);
    // POP BP (1000_9FBF / 0x19FBF)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9FC1);
    // RETF  (1000_9FC0 / 0x19FC0)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_00D1_19FC1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_00D1_19FC1:
    CheckExternalEvents(cs12, 0xD2);
    // PUSH BP (19EF_00D1 / 0x19FC1)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0xD4);
    // MOV BP,SP (19EF_00D2 / 0x19FC2)
    BP = SP;
    CheckExternalEvents(cs12, 0xD5);
    // PUSH DI (19EF_00D4 / 0x19FC4)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0xD6);
    // PUSH SI (19EF_00D5 / 0x19FC5)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0xD7);
    // PUSH DS (19EF_00D6 / 0x19FC6)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0xDA);
    // MOV AX,0x1ddc (19EF_00D7 / 0x19FC7)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0xDC);
    // MOV DS,AX (19EF_00DA / 0x19FCA)
    DS = AX;
    CheckExternalEvents(cs12, 0xE1);
    // CMP word ptr [0xb764],0x0 (19EF_00DC / 0x19FCC)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs12, 0xE3);
    // JNZ 0x1000:a037 (19EF_00E1 / 0x19FD1)
    if(!ZeroFlag) {
      goto label_19EF_0147_1A037;
    }
    CheckExternalEvents(cs12, 0xE6);
    // MOV AX,word ptr [BP + 0x6] (19EF_00E3 / 0x19FD3)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0xE8);
    // MOV SI,AX (19EF_00E6 / 0x19FD6)
    SI = AX;
    CheckExternalEvents(cs12, 0xEB);
    // MOV AX,word ptr [BP + 0x8] (19EF_00E8 / 0x19FD8)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0xEC);
    // PUSH ES (19EF_00EB / 0x19FDB)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0xEE);
    // MOV ES,AX (19EF_00EC / 0x19FDC)
    ES = AX;
    CheckExternalEvents(cs12, 0xF1);
    // MOV DI,0x200 (19EF_00EE / 0x19FDE)
    DI = 0x200;
    CheckExternalEvents(cs12, 0xF4);
    // MOV CX,0x20 (19EF_00F1 / 0x19FE1)
    CX = 0x20;
    label_19EF_00F4_19FE4:
    CheckExternalEvents(cs12, 0xF7);
    // MOV AL,byte ptr ES:[SI] (19EF_00F4 / 0x19FE4)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs12, 0xF9);
    // MOV byte ptr [DI],AL (19EF_00F7 / 0x19FE7)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs12, 0xFA);
    // INC SI (19EF_00F9 / 0x19FE9)
    SI++;
    CheckExternalEvents(cs12, 0xFB);
    // INC DI (19EF_00FA / 0x19FEA)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs12, 0xFD);
    // LOOP 0x1000:9fe4 (19EF_00FB / 0x19FEB)
    if(--CX != 0) {
      goto label_19EF_00F4_19FE4;
    }
    CheckExternalEvents(cs12, 0x100);
    // MOV SI,0x0 (19EF_00FD / 0x19FED)
    SI = 0x0;
    CheckExternalEvents(cs12, 0x103);
    // MOV DI,0x100 (19EF_0100 / 0x19FF0)
    DI = 0x100;
    CheckExternalEvents(cs12, 0x105);
    // XOR CL,CL (19EF_0103 / 0x19FF3)
    CL = 0;
    CheckExternalEvents(cs12, 0x107);
    // XOR DX,DX (19EF_0105 / 0x19FF5)
    DX = 0;
    label_19EF_0107_19FF7:
    CheckExternalEvents(cs12, 0x109);
    // XOR AH,AH (19EF_0107 / 0x19FF7)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs12, 0x10B);
    // MOV AL,CL (19EF_0109 / 0x19FF9)
    AL = CL;
    CheckExternalEvents(cs12, 0x10D);
    // SHR AL,0x1 (19EF_010B / 0x19FFB)
    AL >>= 0x1;
    CheckExternalEvents(cs12, 0x10F);
    // SHR AL,0x1 (19EF_010D / 0x19FFD)
    AL >>= 0x1;
    CheckExternalEvents(cs12, 0x111);
    // SHR AL,0x1 (19EF_010F / 0x19FFF)
    AL >>= 0x1;
    CheckExternalEvents(cs12, 0x113);
    // SHR AL,0x1 (19EF_0111 / 0x1A001)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs12, 0x115);
    // MOV DL,AL (19EF_0113 / 0x1A003)
    DL = AL;
    CheckExternalEvents(cs12, 0x117);
    // MOV AL,CL (19EF_0115 / 0x1A005)
    AL = CL;
    CheckExternalEvents(cs12, 0x119);
    // AND AL,0xf (19EF_0117 / 0x1A007)
    // AL &= 0xF;
    AL = Alu8.And(AL, 0xF);
    CheckExternalEvents(cs12, 0x11C);
    // MOV BX,0x200 (19EF_0119 / 0x1A009)
    BX = 0x200;
    CheckExternalEvents(cs12, 0x11E);
    // ADD BX,DX (19EF_011C / 0x1A00C)
    // BX += DX;
    BX = Alu16.Add(BX, DX);
    CheckExternalEvents(cs12, 0x120);
    // MOV CH,byte ptr [BX] (19EF_011E / 0x1A00E)
    CH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs12, 0x122);
    // SUB BX,DX (19EF_0120 / 0x1A010)
    BX -= DX;
    CheckExternalEvents(cs12, 0x124);
    // SHL CH,0x1 (19EF_0122 / 0x1A012)
    CH <<= 0x1;
    CheckExternalEvents(cs12, 0x126);
    // SHL CH,0x1 (19EF_0124 / 0x1A014)
    CH <<= 0x1;
    CheckExternalEvents(cs12, 0x128);
    // ADD BX,AX (19EF_0126 / 0x1A016)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs12, 0x12B);
    // OR CH,byte ptr [BX + 0x10] (19EF_0128 / 0x1A018)
    CH |= UInt8[DS, (ushort)(BX + 0x10)];
    CheckExternalEvents(cs12, 0x12D);
    // SUB BX,AX (19EF_012B / 0x1A01B)
    // BX -= AX;
    BX = Alu16.Sub(BX, AX);
    CheckExternalEvents(cs12, 0x12F);
    // MOV byte ptr [SI],CH (19EF_012D / 0x1A01D)
    UInt8[DS, (ushort)(SI)] = CH;
    CheckExternalEvents(cs12, 0x130);
    // INC SI (19EF_012F / 0x1A01F)
    SI++;
    CheckExternalEvents(cs12, 0x132);
    // ADD BX,DX (19EF_0130 / 0x1A020)
    // BX += DX;
    BX = Alu16.Add(BX, DX);
    CheckExternalEvents(cs12, 0x135);
    // MOV CH,byte ptr [BX + 0x10] (19EF_0132 / 0x1A022)
    CH = UInt8[DS, (ushort)(BX + 0x10)];
    CheckExternalEvents(cs12, 0x137);
    // SUB BX,DX (19EF_0135 / 0x1A025)
    BX -= DX;
    CheckExternalEvents(cs12, 0x139);
    // SHL CH,0x1 (19EF_0137 / 0x1A027)
    CH <<= 0x1;
    CheckExternalEvents(cs12, 0x13B);
    // SHL CH,0x1 (19EF_0139 / 0x1A029)
    CH <<= 0x1;
    CheckExternalEvents(cs12, 0x13D);
    // ADD BX,AX (19EF_013B / 0x1A02B)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs12, 0x13F);
    // OR CH,byte ptr [BX] (19EF_013D / 0x1A02D)
    // CH |= UInt8[DS, (ushort)(BX)];
    CH = Alu8.Or(CH, UInt8[DS, (ushort)(BX)]);
    CheckExternalEvents(cs12, 0x141);
    // MOV byte ptr [DI],CH (19EF_013F / 0x1A02F)
    UInt8[DS, (ushort)(DI)] = CH;
    CheckExternalEvents(cs12, 0x142);
    // INC DI (19EF_0141 / 0x1A031)
    DI++;
    CheckExternalEvents(cs12, 0x144);
    // INC CL (19EF_0142 / 0x1A032)
    CL = Alu8.Inc(CL);
    CheckExternalEvents(cs12, 0x146);
    // JNZ 0x1000:9ff7 (19EF_0144 / 0x1A034)
    if(!ZeroFlag) {
      goto label_19EF_0107_19FF7;
    }
    CheckExternalEvents(cs12, 0x147);
    // POP ES (19EF_0146 / 0x1A036)
    ES = Stack.Pop16();;
    label_19EF_0147_1A037:
    CheckExternalEvents(cs12, 0x148);
    // POP DS (19EF_0147 / 0x1A037)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x149);
    // POP SI (19EF_0148 / 0x1A038)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x14A);
    // POP DI (19EF_0149 / 0x1A039)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x14B);
    // POP BP (19EF_014A / 0x1A03A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x14C);
    // RETF  (19EF_014B / 0x1A03B)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A03C_1A03C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A03C_1A03C:
    CheckExternalEvents(cs7, 0xA03D);
    // PUSH BP (1000_A03C / 0x1A03C)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xA03F);
    // MOV BP,SP (1000_A03D / 0x1A03D)
    BP = SP;
    CheckExternalEvents(cs7, 0xA040);
    // PUSH DI (1000_A03F / 0x1A03F)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xA041);
    // PUSH SI (1000_A040 / 0x1A040)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xA042);
    // PUSH DS (1000_A041 / 0x1A041)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA045);
    // MOV AX,0x1ddc (1000_A042 / 0x1A042)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xA047);
    // MOV DS,AX (1000_A045 / 0x1A045)
    DS = AX;
    CheckExternalEvents(cs7, 0xA04A);
    // MOV DX,word ptr [BP + 0x6] (1000_A047 / 0x1A047)
    DX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xA04C);
    // MOV AH,0xe (1000_A04A / 0x1A04A)
    AH = 0xE;
    CheckExternalEvents(cs7, 0xA04E);
    // INT 0x21 (1000_A04C / 0x1A04C)
    Interrupt(0x21);
    CheckExternalEvents(cs7, 0xA04F);
    // POP DS (1000_A04E / 0x1A04E)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA050);
    // POP SI (1000_A04F / 0x1A04F)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA051);
    // POP DI (1000_A050 / 0x1A050)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA052);
    // POP BP (1000_A051 / 0x1A051)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA053);
    // RETF  (1000_A052 / 0x1A052)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A053_1A053(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A053_1A053:
    CheckExternalEvents(cs7, 0xA054);
    // PUSH BP (1000_A053 / 0x1A053)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xA056);
    // MOV BP,SP (1000_A054 / 0x1A054)
    BP = SP;
    CheckExternalEvents(cs7, 0xA057);
    // PUSH DI (1000_A056 / 0x1A056)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xA058);
    // PUSH SI (1000_A057 / 0x1A057)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xA059);
    // PUSH DS (1000_A058 / 0x1A058)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA05C);
    // MOV AX,0x1ddc (1000_A059 / 0x1A059)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xA05E);
    // MOV DS,AX (1000_A05C / 0x1A05C)
    DS = AX;
    CheckExternalEvents(cs7, 0xA061);
    // MOV AX,word ptr [BP + 0x6] (1000_A05E / 0x1A05E)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xA063);
    // MOV SI,AX (1000_A061 / 0x1A061)
    SI = AX;
    CheckExternalEvents(cs7, 0xA066);
    // MOV AX,word ptr [BP + 0x8] (1000_A063 / 0x1A063)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xA069);
    // MOV [0xb78c],AX (1000_A066 / 0x1A066)
    UInt16[DS, 0xB78C] = AX;
    CheckExternalEvents(cs7, 0xA06C);
    // MOV AX,word ptr [BP + 0xa] (1000_A069 / 0x1A069)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0xA06E);
    // MOV DI,AX (1000_A06C / 0x1A06C)
    DI = AX;
    CheckExternalEvents(cs7, 0xA071);
    // MOV AX,word ptr [BP + 0xc] (1000_A06E / 0x1A06E)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs7, 0xA074);
    // MOV [0xb790],AX (1000_A071 / 0x1A071)
    UInt16[DS, 0xB790] = AX;
    CheckExternalEvents(cs7, 0xA077);
    // MOV DX,word ptr [BP + 0xe] (1000_A074 / 0x1A074)
    DX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs7, 0xA07B);
    // MOV byte ptr [0xb763],DL (1000_A077 / 0x1A077)
    UInt8[DS, 0xB763] = DL;
    CheckExternalEvents(cs7, 0xA07E);
    // MOV CX,word ptr [BP + 0x10] (1000_A07B / 0x1A07B)
    CX = UInt16[SS, (ushort)(BP + 0x10)];
    CheckExternalEvents(cs7, 0xA082);
    // MOV DX,word ptr [0xb790] (1000_A07E / 0x1A07E)
    DX = UInt16[DS, 0xB790];
    CheckExternalEvents(cs7, 0xA083);
    // PUSH ES (1000_A082 / 0x1A082)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xA084);
    // PUSH BP (1000_A083 / 0x1A083)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xA086);
    // MOV BP,DX (1000_A084 / 0x1A084)
    BP = DX;
    CheckExternalEvents(cs7, 0xA088);
    // XOR DH,DH (1000_A086 / 0x1A086)
    // DH ^= DH;
    DH = Alu8.Xor(DH, DH);
    label_1000_A088_1A088:
    CheckExternalEvents(cs7, 0xA08B);
    // MOV BX,0x0 (1000_A088 / 0x1A088)
    BX = 0x0;
    label_1000_A08B_1A08B:
    CheckExternalEvents(cs7, 0xA08F);
    // MOV DL,byte ptr [0xb763] (1000_A08B / 0x1A08B)
    DL = UInt8[DS, 0xB763];
    label_1000_A08F_1A08F:
    CheckExternalEvents(cs7, 0xA092);
    // MOV AX,[0xb78c] (1000_A08F / 0x1A08F)
    AX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs7, 0xA094);
    // MOV ES,AX (1000_A092 / 0x1A092)
    ES = AX;
    CheckExternalEvents(cs7, 0xA097);
    // MOV AL,byte ptr ES:[SI] (1000_A094 / 0x1A094)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xA098);
    // INC SI (1000_A097 / 0x1A097)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs7, 0xA099);
    // XLAT BX (1000_A098 / 0x1A098)
    AL = UInt8[DS, (ushort)(BX + AL)];
    CheckExternalEvents(cs7, 0xA09B);
    // SHL AL,0x1 (1000_A099 / 0x1A099)
    AL <<= 0x1;
    CheckExternalEvents(cs7, 0xA09D);
    // SHL AL,0x1 (1000_A09B / 0x1A09B)
    AL <<= 0x1;
    CheckExternalEvents(cs7, 0xA09F);
    // SHL AL,0x1 (1000_A09D / 0x1A09D)
    AL <<= 0x1;
    CheckExternalEvents(cs7, 0xA0A1);
    // SHL AL,0x1 (1000_A09F / 0x1A09F)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs7, 0xA0A3);
    // MOV AH,AL (1000_A0A1 / 0x1A0A1)
    AH = AL;
    CheckExternalEvents(cs7, 0xA0A6);
    // MOV AL,byte ptr ES:[SI] (1000_A0A3 / 0x1A0A3)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xA0A7);
    // XLAT BX (1000_A0A6 / 0x1A0A6)
    AL = UInt8[DS, (ushort)(BX + AL)];
    CheckExternalEvents(cs7, 0xA0A8);
    // INC SI (1000_A0A7 / 0x1A0A7)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs7, 0xA0AA);
    // OR AL,AH (1000_A0A8 / 0x1A0A8)
    // AL |= AH;
    AL = Alu8.Or(AL, AH);
    CheckExternalEvents(cs7, 0xA0AC);
    // MOV ES,BP (1000_A0AA / 0x1A0AA)
    ES = BP;
    CheckExternalEvents(cs7, 0xA0AD);
    // STOSB ES:DI (1000_A0AC / 0x1A0AC)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xA0AF);
    // DEC DL (1000_A0AD / 0x1A0AD)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs7, 0xA0B1);
    // JZ 0x1000:a0b6 (1000_A0AF / 0x1A0AF)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A0B6_1A0B6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA0B3);
    // LOOP 0x1000:a08f (1000_A0B1 / 0x1A0B1)
    if(--CX != 0) {
      goto label_1000_A08F_1A08F;
    }
    CheckExternalEvents(cs7, 0xA0B5);
    // JMP 0x1000:a0c0 (1000_A0B3 / 0x1A0B3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_A0C0_1A0C0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_A0B6_1A0B6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A0B6_1A0B6:
    CheckExternalEvents(cs7, 0xA0B9);
    // XOR DH,0x1 (1000_A0B6 / 0x1A0B6)
    // DH ^= 0x1;
    DH = Alu8.Xor(DH, 0x1);
    CheckExternalEvents(cs7, 0xA0BB);
    // JZ 0x1000:a088 (1000_A0B9 / 0x1A0B9)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A053_1A053, 0x1A088 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA0BE);
    // MOV BX,0x100 (1000_A0BB / 0x1A0BB)
    BX = 0x100;
    CheckExternalEvents(cs7, 0xA0C0);
    // JMP 0x1000:a08b (1000_A0BE / 0x1A0BE)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_A053_1A053, 0x1A08B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ghidra_guess_1000_A0C0_1A0C0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A0C0_1A0C0:
    CheckExternalEvents(cs7, 0xA0C1);
    // POP BP (1000_A0C0 / 0x1A0C0)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA0C2);
    // POP ES (1000_A0C1 / 0x1A0C1)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA0C3);
    // POP DS (1000_A0C2 / 0x1A0C2)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA0C4);
    // POP SI (1000_A0C3 / 0x1A0C3)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA0C5);
    // POP DI (1000_A0C4 / 0x1A0C4)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA0C6);
    // POP BP (1000_A0C5 / 0x1A0C5)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA0C7);
    // RETF  (1000_A0C6 / 0x1A0C6)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A0C7_1A0C7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A0C7_1A0C7:
    CheckExternalEvents(cs7, 0xA0C8);
    // PUSH BP (1000_A0C7 / 0x1A0C7)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xA0CA);
    // MOV BP,SP (1000_A0C8 / 0x1A0C8)
    BP = SP;
    CheckExternalEvents(cs7, 0xA0CB);
    // PUSH DI (1000_A0CA / 0x1A0CA)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xA0CC);
    // PUSH SI (1000_A0CB / 0x1A0CB)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xA0CD);
    // PUSH DS (1000_A0CC / 0x1A0CC)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA0D0);
    // MOV AX,0x1ddc (1000_A0CD / 0x1A0CD)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xA0D2);
    // MOV DS,AX (1000_A0D0 / 0x1A0D0)
    DS = AX;
    CheckExternalEvents(cs7, 0xA0D5);
    // MOV BX,word ptr [BP + 0x6] (1000_A0D2 / 0x1A0D2)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xA0D7);
    // MOV SI,BX (1000_A0D5 / 0x1A0D5)
    SI = BX;
    CheckExternalEvents(cs7, 0xA0D9);
    // MOV DI,BX (1000_A0D7 / 0x1A0D7)
    DI = BX;
    CheckExternalEvents(cs7, 0xA0DC);
    // MOV AX,word ptr [BP + 0x8] (1000_A0D9 / 0x1A0D9)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xA0DD);
    // PUSH ES (1000_A0DC / 0x1A0DC)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xA0DE);
    // PUSH DS (1000_A0DD / 0x1A0DD)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA0E0);
    // MOV ES,AX (1000_A0DE / 0x1A0DE)
    ES = AX;
    CheckExternalEvents(cs7, 0xA0E2);
    // MOV DS,AX (1000_A0E0 / 0x1A0E0)
    DS = AX;
    CheckExternalEvents(cs7, 0xA0E6);
    // ADD SI,0x3e40 (1000_A0E2 / 0x1A0E2)
    SI += 0x3E40;
    CheckExternalEvents(cs7, 0xA0EA);
    // ADD DI,0x7c80 (1000_A0E6 / 0x1A0E6)
    // DI += 0x7C80;
    DI = Alu16.Add(DI, 0x7C80);
    CheckExternalEvents(cs7, 0xA0EB);
    // CLD  (1000_A0EA / 0x1A0EA)
    DirectionFlag = false;
    label_1000_A0EB_1A0EB:
    CheckExternalEvents(cs7, 0xA0EE);
    // MOV CX,0x20 (1000_A0EB / 0x1A0EB)
    CX = 0x20;
    CheckExternalEvents(cs7, 0xA0F0);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_A0EE / 0x1A0EE)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs7, 0xA0F4);
    // SUB SI,0x80 (1000_A0F0 / 0x1A0F0)
    SI -= 0x80;
    CheckExternalEvents(cs7, 0xA0F8);
    // SUB DI,0xc0 (1000_A0F4 / 0x1A0F4)
    DI -= 0xC0;
    CheckExternalEvents(cs7, 0xA0FA);
    // CMP DI,BX (1000_A0F8 / 0x1A0F8)
    Alu16.Sub(DI, BX);
    CheckExternalEvents(cs7, 0xA0FC);
    // JNZ 0x1000:a0eb (1000_A0FA / 0x1A0FA)
    if(!ZeroFlag) {
      goto label_1000_A0EB_1A0EB;
    }
    CheckExternalEvents(cs7, 0xA0FD);
    // POP DS (1000_A0FC / 0x1A0FC)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA0FE);
    // POP ES (1000_A0FD / 0x1A0FD)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA0FF);
    // POP DS (1000_A0FE / 0x1A0FE)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA100);
    // POP SI (1000_A0FF / 0x1A0FF)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA101);
    // POP DI (1000_A100 / 0x1A100)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA102);
    // POP BP (1000_A101 / 0x1A101)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA103);
    // RETF  (1000_A102 / 0x1A102)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0213_1A103(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0213_1A103:
    CheckExternalEvents(cs12, 0x214);
    // PUSH BP (19EF_0213 / 0x1A103)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x216);
    // MOV BP,SP (19EF_0214 / 0x1A104)
    BP = SP;
    CheckExternalEvents(cs12, 0x217);
    // PUSH DI (19EF_0216 / 0x1A106)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x218);
    // PUSH SI (19EF_0217 / 0x1A107)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x219);
    // PUSH DS (19EF_0218 / 0x1A108)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x21C);
    // MOV AX,0x1ddc (19EF_0219 / 0x1A109)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x21E);
    // MOV DS,AX (19EF_021C / 0x1A10C)
    DS = AX;
    CheckExternalEvents(cs12, 0x221);
    // MOV DL,byte ptr [BP + 0x6] (19EF_021E / 0x1A10E)
    DL = UInt8[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x223);
    // MOV AH,0x6 (19EF_0221 / 0x1A111)
    AH = 0x6;
    CheckExternalEvents(cs12, 0x225);
    // INT 0x21 (19EF_0223 / 0x1A113)
    Interrupt(0x21);
    CheckExternalEvents(cs12, 0x226);
    // POP DS (19EF_0225 / 0x1A115)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x227);
    // POP SI (19EF_0226 / 0x1A116)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x228);
    // POP DI (19EF_0227 / 0x1A117)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x229);
    // POP BP (19EF_0228 / 0x1A118)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x22A);
    // RETF  (19EF_0229 / 0x1A119)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A11A_1A11A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A11A_1A11A:
    CheckExternalEvents(cs7, 0xA11B);
    // PUSH BP (1000_A11A / 0x1A11A)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xA11D);
    // MOV BP,SP (1000_A11B / 0x1A11B)
    BP = SP;
    CheckExternalEvents(cs7, 0xA11E);
    // PUSH DI (1000_A11D / 0x1A11D)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xA11F);
    // PUSH SI (1000_A11E / 0x1A11E)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xA120);
    // PUSH DS (1000_A11F / 0x1A11F)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA123);
    // MOV AX,0x1ddc (1000_A120 / 0x1A120)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xA125);
    // MOV DS,AX (1000_A123 / 0x1A123)
    DS = AX;
    CheckExternalEvents(cs7, 0xA128);
    // MOV BX,word ptr [BP + 0x6] (1000_A125 / 0x1A125)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xA12B);
    // MOV CX,word ptr [BP + 0x8] (1000_A128 / 0x1A128)
    CX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xA12E);
    // MOV AX,0x40 (1000_A12B / 0x1A12B)
    AX = 0x40;
    CheckExternalEvents(cs7, 0xA130);
    // MOV ES,AX (1000_A12E / 0x1A12E)
    ES = AX;
    CheckExternalEvents(cs7, 0xA135);
    // MOV DX,word ptr ES:[0x63] (1000_A130 / 0x1A130)
    DX = UInt16[ES, 0x63];
    CheckExternalEvents(cs7, 0xA138);
    // ADD DL,0x6 (1000_A135 / 0x1A135)
    // DL += 0x6;
    DL = Alu8.Add(DL, 0x6);
    CheckExternalEvents(cs7, 0xA139);
    // PUSH DX (1000_A138 / 0x1A138)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0xA13A);
    // CLI  (1000_A139 / 0x1A139)
    InterruptFlag = false;
    CheckExternalEvents(cs7, 0xA13B);
    // IN AL,DX (1000_A13A / 0x1A13A)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs7, 0xA13D);
    // MOV DL,0xc0 (1000_A13B / 0x1A13B)
    DL = 0xC0;
    CheckExternalEvents(cs7, 0xA13F);
    // MOV AL,BL (1000_A13D / 0x1A13D)
    AL = BL;
    CheckExternalEvents(cs7, 0xA140);
    // OUT DX,AL (1000_A13F / 0x1A13F)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs7, 0xA142);
    // MOV AL,CL (1000_A140 / 0x1A140)
    AL = CL;
    CheckExternalEvents(cs7, 0xA143);
    // OUT DX,AL (1000_A142 / 0x1A142)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs7, 0xA144);
    // POP DX (1000_A143 / 0x1A143)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA145);
    // IN AL,DX (1000_A144 / 0x1A144)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs7, 0xA147);
    // MOV DL,0xc0 (1000_A145 / 0x1A145)
    DL = 0xC0;
    CheckExternalEvents(cs7, 0xA149);
    // MOV AL,0x20 (1000_A147 / 0x1A147)
    AL = 0x20;
    CheckExternalEvents(cs7, 0xA14A);
    // OUT DX,AL (1000_A149 / 0x1A149)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs7, 0xA14B);
    // STI  (1000_A14A / 0x1A14A)
    InterruptFlag = true;
    CheckExternalEvents(cs7, 0xA14C);
    // POP DS (1000_A14B / 0x1A14B)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA14D);
    // POP SI (1000_A14C / 0x1A14C)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA14E);
    // POP DI (1000_A14D / 0x1A14D)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA14F);
    // POP BP (1000_A14E / 0x1A14E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA150);
    // RETF  (1000_A14F / 0x1A14F)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A150_1A150(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A150_1A150:
    CheckExternalEvents(cs7, 0xA151);
    // PUSH BP (1000_A150 / 0x1A150)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xA153);
    // MOV BP,SP (1000_A151 / 0x1A151)
    BP = SP;
    CheckExternalEvents(cs7, 0xA154);
    // PUSH DI (1000_A153 / 0x1A153)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xA155);
    // PUSH SI (1000_A154 / 0x1A154)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xA156);
    // PUSH DS (1000_A155 / 0x1A155)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA159);
    // MOV AX,0x1ddc (1000_A156 / 0x1A156)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xA15B);
    // MOV DS,AX (1000_A159 / 0x1A159)
    DS = AX;
    CheckExternalEvents(cs7, 0xA15E);
    // MOV AX,word ptr [BP + 0x6] (1000_A15B / 0x1A15B)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xA160);
    // MOV SI,AX (1000_A15E / 0x1A15E)
    SI = AX;
    CheckExternalEvents(cs7, 0xA163);
    // MOV AX,word ptr [BP + 0x8] (1000_A160 / 0x1A160)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xA164);
    // PUSH ES (1000_A163 / 0x1A163)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xA166);
    // MOV ES,AX (1000_A164 / 0x1A164)
    ES = AX;
    CheckExternalEvents(cs7, 0xA169);
    // MOV AX,word ptr [BP + 0xa] (1000_A166 / 0x1A166)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0xA16C);
    // MOV CX,0x1f40 (1000_A169 / 0x1A169)
    CX = 0x1F40;
    CheckExternalEvents(cs7, 0xA16D);
    // PUSH DS (1000_A16C / 0x1A16C)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA16F);
    // MOV DS,AX (1000_A16D / 0x1A16D)
    DS = AX;
    CheckExternalEvents(cs7, 0xA172);
    // MOV DI,0x0 (1000_A16F / 0x1A16F)
    DI = 0x0;
    CheckExternalEvents(cs7, 0xA175);
    // MOV DX,0x3ce (1000_A172 / 0x1A172)
    DX = 0x3CE;
    CheckExternalEvents(cs7, 0xA178);
    // MOV AX,0x205 (1000_A175 / 0x1A175)
    AX = 0x205;
    CheckExternalEvents(cs7, 0xA179);
    // OUT DX,AX (1000_A178 / 0x1A178)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA17B);
    // MOV AL,0x3 (1000_A179 / 0x1A179)
    AL = 0x3;
    CheckExternalEvents(cs7, 0xA17D);
    // MOV AH,0x18 (1000_A17B / 0x1A17B)
    AH = 0x18;
    label_1000_A17D_1A17D:
    CheckExternalEvents(cs7, 0xA180);
    // MOV AX,0x8008 (1000_A17D / 0x1A17D)
    AX = 0x8008;
    CheckExternalEvents(cs7, 0xA181);
    // OUT DX,AX (1000_A180 / 0x1A180)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA183);
    // MOV AL,byte ptr [DI] (1000_A181 / 0x1A181)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xA186);
    // MOV BL,byte ptr ES:[SI] (1000_A183 / 0x1A183)
    BL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xA188);
    // MOV AL,BL (1000_A186 / 0x1A186)
    AL = BL;
    CheckExternalEvents(cs7, 0xA18A);
    // SHR AL,0x1 (1000_A188 / 0x1A188)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA18C);
    // SHR AL,0x1 (1000_A18A / 0x1A18A)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA18E);
    // SHR AL,0x1 (1000_A18C / 0x1A18C)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA190);
    // SHR AL,0x1 (1000_A18E / 0x1A18E)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs7, 0xA192);
    // MOV byte ptr [DI],AL (1000_A190 / 0x1A190)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs7, 0xA194);
    // MOV AL,byte ptr [DI] (1000_A192 / 0x1A192)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xA197);
    // MOV AX,0x4008 (1000_A194 / 0x1A194)
    AX = 0x4008;
    CheckExternalEvents(cs7, 0xA198);
    // OUT DX,AX (1000_A197 / 0x1A197)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA19A);
    // MOV byte ptr [DI],BL (1000_A198 / 0x1A198)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs7, 0xA19B);
    // INC SI (1000_A19A / 0x1A19A)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs7, 0xA19E);
    // MOV AX,0x2008 (1000_A19B / 0x1A19B)
    AX = 0x2008;
    CheckExternalEvents(cs7, 0xA19F);
    // OUT DX,AX (1000_A19E / 0x1A19E)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA1A1);
    // MOV AL,byte ptr [DI] (1000_A19F / 0x1A19F)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xA1A4);
    // MOV BL,byte ptr ES:[SI] (1000_A1A1 / 0x1A1A1)
    BL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xA1A6);
    // MOV AL,BL (1000_A1A4 / 0x1A1A4)
    AL = BL;
    CheckExternalEvents(cs7, 0xA1A8);
    // SHR AL,0x1 (1000_A1A6 / 0x1A1A6)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA1AA);
    // SHR AL,0x1 (1000_A1A8 / 0x1A1A8)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA1AC);
    // SHR AL,0x1 (1000_A1AA / 0x1A1AA)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA1AE);
    // SHR AL,0x1 (1000_A1AC / 0x1A1AC)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs7, 0xA1B0);
    // MOV byte ptr [DI],AL (1000_A1AE / 0x1A1AE)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs7, 0xA1B2);
    // MOV AL,byte ptr [DI] (1000_A1B0 / 0x1A1B0)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xA1B5);
    // MOV AX,0x1008 (1000_A1B2 / 0x1A1B2)
    AX = 0x1008;
    CheckExternalEvents(cs7, 0xA1B6);
    // OUT DX,AX (1000_A1B5 / 0x1A1B5)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA1B8);
    // MOV byte ptr [DI],BL (1000_A1B6 / 0x1A1B6)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs7, 0xA1B9);
    // INC SI (1000_A1B8 / 0x1A1B8)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs7, 0xA1BC);
    // MOV AX,0x808 (1000_A1B9 / 0x1A1B9)
    AX = 0x808;
    CheckExternalEvents(cs7, 0xA1BD);
    // OUT DX,AX (1000_A1BC / 0x1A1BC)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA1BF);
    // MOV AL,byte ptr [DI] (1000_A1BD / 0x1A1BD)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xA1C2);
    // MOV BL,byte ptr ES:[SI] (1000_A1BF / 0x1A1BF)
    BL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xA1C4);
    // MOV AL,BL (1000_A1C2 / 0x1A1C2)
    AL = BL;
    CheckExternalEvents(cs7, 0xA1C6);
    // SHR AL,0x1 (1000_A1C4 / 0x1A1C4)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA1C8);
    // SHR AL,0x1 (1000_A1C6 / 0x1A1C6)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA1CA);
    // SHR AL,0x1 (1000_A1C8 / 0x1A1C8)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA1CC);
    // SHR AL,0x1 (1000_A1CA / 0x1A1CA)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs7, 0xA1CE);
    // MOV byte ptr [DI],AL (1000_A1CC / 0x1A1CC)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs7, 0xA1D0);
    // MOV AL,byte ptr [DI] (1000_A1CE / 0x1A1CE)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xA1D3);
    // MOV AX,0x408 (1000_A1D0 / 0x1A1D0)
    AX = 0x408;
    CheckExternalEvents(cs7, 0xA1D4);
    // OUT DX,AX (1000_A1D3 / 0x1A1D3)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA1D6);
    // MOV byte ptr [DI],BL (1000_A1D4 / 0x1A1D4)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs7, 0xA1D7);
    // INC SI (1000_A1D6 / 0x1A1D6)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs7, 0xA1DA);
    // MOV AX,0x208 (1000_A1D7 / 0x1A1D7)
    AX = 0x208;
    CheckExternalEvents(cs7, 0xA1DB);
    // OUT DX,AX (1000_A1DA / 0x1A1DA)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA1DD);
    // MOV AL,byte ptr [DI] (1000_A1DB / 0x1A1DB)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xA1E0);
    // MOV BL,byte ptr ES:[SI] (1000_A1DD / 0x1A1DD)
    BL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xA1E2);
    // MOV AL,BL (1000_A1E0 / 0x1A1E0)
    AL = BL;
    CheckExternalEvents(cs7, 0xA1E4);
    // SHR AL,0x1 (1000_A1E2 / 0x1A1E2)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA1E6);
    // SHR AL,0x1 (1000_A1E4 / 0x1A1E4)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA1E8);
    // SHR AL,0x1 (1000_A1E6 / 0x1A1E6)
    AL >>= 0x1;
    CheckExternalEvents(cs7, 0xA1EA);
    // SHR AL,0x1 (1000_A1E8 / 0x1A1E8)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs7, 0xA1EC);
    // MOV byte ptr [DI],AL (1000_A1EA / 0x1A1EA)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs7, 0xA1EE);
    // MOV AL,byte ptr [DI] (1000_A1EC / 0x1A1EC)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xA1F1);
    // MOV AX,0x108 (1000_A1EE / 0x1A1EE)
    AX = 0x108;
    CheckExternalEvents(cs7, 0xA1F2);
    // OUT DX,AX (1000_A1F1 / 0x1A1F1)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA1F4);
    // MOV byte ptr [DI],BL (1000_A1F2 / 0x1A1F2)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs7, 0xA1F5);
    // INC SI (1000_A1F4 / 0x1A1F4)
    SI++;
    CheckExternalEvents(cs7, 0xA1F6);
    // INC DI (1000_A1F5 / 0x1A1F5)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs7, 0xA1F8);
    // LOOP 0x1000:a17d (1000_A1F6 / 0x1A1F6)
    if(--CX != 0) {
      goto label_1000_A17D_1A17D;
    }
    CheckExternalEvents(cs7, 0xA1FB);
    // MOV AX,0x8 (1000_A1F8 / 0x1A1F8)
    AX = 0x8;
    CheckExternalEvents(cs7, 0xA1FC);
    // OUT DX,AX (1000_A1FB / 0x1A1FB)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA1FD);
    // POP DS (1000_A1FC / 0x1A1FC)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA1FE);
    // POP ES (1000_A1FD / 0x1A1FD)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA1FF);
    // POP DS (1000_A1FE / 0x1A1FE)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA200);
    // POP SI (1000_A1FF / 0x1A1FF)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA201);
    // POP DI (1000_A200 / 0x1A200)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA202);
    // POP BP (1000_A201 / 0x1A201)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA203);
    // RETF  (1000_A202 / 0x1A202)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A203_1A203(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A203_1A203:
    CheckExternalEvents(cs7, 0xA204);
    // PUSH BP (1000_A203 / 0x1A203)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xA206);
    // MOV BP,SP (1000_A204 / 0x1A204)
    BP = SP;
    CheckExternalEvents(cs7, 0xA207);
    // PUSH DI (1000_A206 / 0x1A206)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xA208);
    // PUSH SI (1000_A207 / 0x1A207)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xA209);
    // PUSH DS (1000_A208 / 0x1A208)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA20C);
    // MOV AX,0x1ddc (1000_A209 / 0x1A209)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xA20E);
    // MOV DS,AX (1000_A20C / 0x1A20C)
    DS = AX;
    CheckExternalEvents(cs7, 0xA20F);
    // PUSH ES (1000_A20E / 0x1A20E)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xA212);
    // MOV DX,0x3ce (1000_A20F / 0x1A20F)
    DX = 0x3CE;
    CheckExternalEvents(cs7, 0xA215);
    // MOV AX,0x205 (1000_A212 / 0x1A212)
    AX = 0x205;
    CheckExternalEvents(cs7, 0xA216);
    // OUT DX,AX (1000_A215 / 0x1A215)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA219);
    // MOV AX,0x8 (1000_A216 / 0x1A216)
    AX = 0x8;
    CheckExternalEvents(cs7, 0xA21A);
    // OUT DX,AX (1000_A219 / 0x1A219)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA21D);
    // MOV AX,word ptr [BP + 0x6] (1000_A21A / 0x1A21A)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xA21F);
    // MOV DI,AX (1000_A21D / 0x1A21D)
    DI = AX;
    CheckExternalEvents(cs7, 0xA222);
    // MOV AX,word ptr [BP + 0x8] (1000_A21F / 0x1A21F)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xA224);
    // MOV ES,AX (1000_A222 / 0x1A222)
    ES = AX;
    CheckExternalEvents(cs7, 0xA227);
    // MOV BX,word ptr [BP + 0xa] (1000_A224 / 0x1A224)
    BX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0xA22A);
    // MOV AX,word ptr [BP + 0xc] (1000_A227 / 0x1A227)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs7, 0xA22D);
    // MOV DX,0x140 (1000_A22A / 0x1A22A)
    DX = 0x140;
    CheckExternalEvents(cs7, 0xA22F);
    // MUL DX (1000_A22D / 0x1A22D)
    uint resMul1000_A22D = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul1000_A22D);
    DX = (ushort)(resMul1000_A22D >> 16);
    CheckExternalEvents(cs7, 0xA231);
    // ADD AX,BX (1000_A22F / 0x1A22F)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs7, 0xA233);
    // MOV SI,AX (1000_A231 / 0x1A231)
    SI = AX;
    CheckExternalEvents(cs7, 0xA234);
    // PUSH DS (1000_A233 / 0x1A233)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA237);
    // MOV AX,0xa800 (1000_A234 / 0x1A234)
    AX = 0xA800;
    CheckExternalEvents(cs7, 0xA239);
    // MOV DS,AX (1000_A237 / 0x1A237)
    DS = AX;
    CheckExternalEvents(cs7, 0xA23C);
    // MOV CX,0x8 (1000_A239 / 0x1A239)
    CX = 0x8;
    CheckExternalEvents(cs7, 0xA23F);
    // MOV DX,0x3ce (1000_A23C / 0x1A23C)
    DX = 0x3CE;
    label_1000_A23F_1A23F:
    CheckExternalEvents(cs7, 0xA242);
    // MOV AX,0x4 (1000_A23F / 0x1A23F)
    AX = 0x4;
    CheckExternalEvents(cs7, 0xA243);
    // OUT DX,AX (1000_A242 / 0x1A242)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA245);
    // MOV AL,byte ptr [SI] (1000_A243 / 0x1A243)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xA246);
    // STOSB ES:DI (1000_A245 / 0x1A245)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xA249);
    // MOV AX,0x104 (1000_A246 / 0x1A246)
    AX = 0x104;
    CheckExternalEvents(cs7, 0xA24A);
    // OUT DX,AX (1000_A249 / 0x1A249)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA24C);
    // MOV AL,byte ptr [SI] (1000_A24A / 0x1A24A)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xA24D);
    // STOSB ES:DI (1000_A24C / 0x1A24C)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xA250);
    // MOV AX,0x204 (1000_A24D / 0x1A24D)
    AX = 0x204;
    CheckExternalEvents(cs7, 0xA251);
    // OUT DX,AX (1000_A250 / 0x1A250)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA253);
    // MOV AL,byte ptr [SI] (1000_A251 / 0x1A251)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xA254);
    // STOSB ES:DI (1000_A253 / 0x1A253)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xA257);
    // MOV AX,0x304 (1000_A254 / 0x1A254)
    AX = 0x304;
    CheckExternalEvents(cs7, 0xA258);
    // OUT DX,AX (1000_A257 / 0x1A257)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA25A);
    // MOV AL,byte ptr [SI] (1000_A258 / 0x1A258)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xA25B);
    // STOSB ES:DI (1000_A25A / 0x1A25A)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xA25E);
    // ADD SI,0x28 (1000_A25B / 0x1A25B)
    // SI += 0x28;
    SI = Alu16.Add(SI, 0x28);
    CheckExternalEvents(cs7, 0xA260);
    // LOOP 0x1000:a23f (1000_A25E / 0x1A25E)
    if(--CX != 0) {
      goto label_1000_A23F_1A23F;
    }
    CheckExternalEvents(cs7, 0xA261);
    // POP DS (1000_A260 / 0x1A260)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA262);
    // POP ES (1000_A261 / 0x1A261)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA263);
    // POP DS (1000_A262 / 0x1A262)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA264);
    // POP SI (1000_A263 / 0x1A263)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA265);
    // POP DI (1000_A264 / 0x1A264)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA266);
    // POP BP (1000_A265 / 0x1A265)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA267);
    // RETF  (1000_A266 / 0x1A266)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A267_1A267(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A267_1A267:
    CheckExternalEvents(cs7, 0xA268);
    // PUSH BP (1000_A267 / 0x1A267)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xA26A);
    // MOV BP,SP (1000_A268 / 0x1A268)
    BP = SP;
    CheckExternalEvents(cs7, 0xA26B);
    // PUSH DI (1000_A26A / 0x1A26A)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xA26C);
    // PUSH SI (1000_A26B / 0x1A26B)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xA26D);
    // PUSH DS (1000_A26C / 0x1A26C)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA270);
    // MOV AX,0x1ddc (1000_A26D / 0x1A26D)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xA272);
    // MOV DS,AX (1000_A270 / 0x1A270)
    DS = AX;
    CheckExternalEvents(cs7, 0xA273);
    // PUSH ES (1000_A272 / 0x1A272)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xA276);
    // MOV AX,word ptr [BP + 0x6] (1000_A273 / 0x1A273)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xA278);
    // MOV DI,AX (1000_A276 / 0x1A276)
    DI = AX;
    CheckExternalEvents(cs7, 0xA27B);
    // MOV AX,word ptr [BP + 0x8] (1000_A278 / 0x1A278)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xA27D);
    // MOV ES,AX (1000_A27B / 0x1A27B)
    ES = AX;
    CheckExternalEvents(cs7, 0xA280);
    // MOV AX,word ptr [BP + 0xa] (1000_A27D / 0x1A27D)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0xA282);
    // MOV SI,AX (1000_A280 / 0x1A280)
    SI = AX;
    CheckExternalEvents(cs7, 0xA285);
    // MOV AX,word ptr [BP + 0xc] (1000_A282 / 0x1A282)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs7, 0xA288);
    // MOV [0x25c],AX (1000_A285 / 0x1A285)
    UInt16[DS, 0x25C] = AX;
    CheckExternalEvents(cs7, 0xA28B);
    // MOV AX,word ptr [BP + 0xe] (1000_A288 / 0x1A288)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs7, 0xA28E);
    // MOV [0x262],AX (1000_A28B / 0x1A28B)
    UInt16[DS, 0x262] = AX;
    CheckExternalEvents(cs7, 0xA290);
    // SAR AX,0x1 (1000_A28E / 0x1A28E)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs7, 0xA292);
    // SAR AX,0x1 (1000_A290 / 0x1A290)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs7, 0xA294);
    // SAR AX,0x1 (1000_A292 / 0x1A292)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs7, 0xA297);
    // MOV [0x266],AX (1000_A294 / 0x1A294)
    UInt16[DS, 0x266] = AX;
    CheckExternalEvents(cs7, 0xA29A);
    // MOV AX,word ptr [BP + 0x10] (1000_A297 / 0x1A297)
    AX = UInt16[SS, (ushort)(BP + 0x10)];
    CheckExternalEvents(cs7, 0xA29D);
    // MOV [0x264],AX (1000_A29A / 0x1A29A)
    UInt16[DS, 0x264] = AX;
    CheckExternalEvents(cs7, 0xA29E);
    // PUSH DS (1000_A29D / 0x1A29D)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA29F);
    // INC SI (1000_A29E / 0x1A29E)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs7, 0xA2A2);
    // MOV AX,[0x25c] (1000_A29F / 0x1A29F)
    AX = UInt16[DS, 0x25C];
    CheckExternalEvents(cs7, 0xA2A4);
    // MOV DS,AX (1000_A2A2 / 0x1A2A2)
    DS = AX;
    CheckExternalEvents(cs7, 0xA2A5);
    // LODSW SI (1000_A2A4 / 0x1A2A4)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs7, 0xA2A6);
    // INC SI (1000_A2A5 / 0x1A2A5)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs7, 0xA2A7);
    // POP DS (1000_A2A6 / 0x1A2A6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA2A9);
    // INC AL (1000_A2A7 / 0x1A2A7)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs7, 0xA2AA);
    // PUSH AX (1000_A2A9 / 0x1A2A9)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0xA2AD);
    // AND AX,0xff (1000_A2AA / 0x1A2AA)
    // AX &= 0xFF;
    AX = Alu16.And(AX, 0xFF);
    CheckExternalEvents(cs7, 0xA2B0);
    // MOV [0x26c],AX (1000_A2AD / 0x1A2AD)
    UInt16[DS, 0x26C] = AX;
    CheckExternalEvents(cs7, 0xA2B1);
    // POP AX (1000_A2B0 / 0x1A2B0)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA2B3);
    // XCHG AH,AL (1000_A2B1 / 0x1A2B1)
    (AL, AH) = (AH, AL);
    CheckExternalEvents(cs7, 0xA2B6);
    // AND AX,0xff (1000_A2B3 / 0x1A2B3)
    // AX &= 0xFF;
    AX = Alu16.And(AX, 0xFF);
    CheckExternalEvents(cs7, 0xA2B9);
    // MOV [0x268],AX (1000_A2B6 / 0x1A2B6)
    UInt16[DS, 0x268] = AX;
    CheckExternalEvents(cs7, 0xA2BB);
    // SHL AX,0x1 (1000_A2B9 / 0x1A2B9)
    AX <<= 0x1;
    CheckExternalEvents(cs7, 0xA2BD);
    // SHL AX,0x1 (1000_A2BB / 0x1A2BB)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs7, 0xA2C0);
    // MOV [0x26a],AX (1000_A2BD / 0x1A2BD)
    UInt16[DS, 0x26A] = AX;
    CheckExternalEvents(cs7, 0xA2C3);
    // MOV AX,[0x264] (1000_A2C0 / 0x1A2C0)
    AX = UInt16[DS, 0x264];
    CheckExternalEvents(cs7, 0xA2C6);
    // CMP AX,0x0 (1000_A2C3 / 0x1A2C3)
    Alu16.Sub(AX, 0x0);
    CheckExternalEvents(cs7, 0xA2C8);
    // JNS 0x1000:a2ed (1000_A2C6 / 0x1A2C6)
    if(!SignFlag) {
      goto label_1000_A2ED_1A2ED;
    }
    CheckExternalEvents(cs7, 0xA2CA);
    // NEG AX (1000_A2C8 / 0x1A2C8)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs7, 0xA2CE);
    // CMP AX,word ptr [0x26c] (1000_A2CA / 0x1A2CA)
    Alu16.Sub(AX, UInt16[DS, 0x26C]);
    CheckExternalEvents(cs7, 0xA2D0);
    // JNC 0x1000:a337 (1000_A2CE / 0x1A2CE)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs7, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA2D4);
    // MOV DX,word ptr [0x268] (1000_A2D0 / 0x1A2D0)
    DX = UInt16[DS, 0x268];
    CheckExternalEvents(cs7, 0xA2D6);
    // SHL DX,0x1 (1000_A2D4 / 0x1A2D4)
    DX <<= 0x1;
    CheckExternalEvents(cs7, 0xA2D8);
    // SHL DX,0x1 (1000_A2D6 / 0x1A2D6)
    DX <<= 0x1;
    CheckExternalEvents(cs7, 0xA2DA);
    // MUL DX (1000_A2D8 / 0x1A2D8)
    uint resMul1000_A2D8 = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul1000_A2D8);
    DX = (ushort)(resMul1000_A2D8 >> 16);
    CheckExternalEvents(cs7, 0xA2DC);
    // ADD SI,AX (1000_A2DA / 0x1A2DA)
    // SI += AX;
    SI = Alu16.Add(SI, AX);
    CheckExternalEvents(cs7, 0xA2DF);
    // MOV AX,[0x26c] (1000_A2DC / 0x1A2DC)
    AX = UInt16[DS, 0x26C];
    CheckExternalEvents(cs7, 0xA2E3);
    // ADD AX,word ptr [0x264] (1000_A2DF / 0x1A2DF)
    // AX += UInt16[DS, 0x264];
    AX = Alu16.Add(AX, UInt16[DS, 0x264]);
    CheckExternalEvents(cs7, 0xA2E5);
    // JS 0x1000:a337 (1000_A2E3 / 0x1A2E3)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs7, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA2E8);
    // MOV [0x26c],AX (1000_A2E5 / 0x1A2E5)
    UInt16[DS, 0x26C] = AX;
    CheckExternalEvents(cs7, 0xA2EA);
    // XOR AX,AX (1000_A2E8 / 0x1A2E8)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs7, 0xA2ED);
    // MOV [0x264],AX (1000_A2EA / 0x1A2EA)
    UInt16[DS, 0x264] = AX;
    label_1000_A2ED_1A2ED:
    CheckExternalEvents(cs7, 0xA2F0);
    // MOV AX,0xc8 (1000_A2ED / 0x1A2ED)
    AX = 0xC8;
    CheckExternalEvents(cs7, 0xA2F4);
    // SUB AX,word ptr [0x264] (1000_A2F0 / 0x1A2F0)
    // AX -= UInt16[DS, 0x264];
    AX = Alu16.Sub(AX, UInt16[DS, 0x264]);
    CheckExternalEvents(cs7, 0xA2F6);
    // JS 0x1000:a337 (1000_A2F4 / 0x1A2F4)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs7, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA2F8);
    // JZ 0x1000:a337 (1000_A2F6 / 0x1A2F6)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs7, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA2FC);
    // CMP AX,word ptr [0x26c] (1000_A2F8 / 0x1A2F8)
    Alu16.Sub(AX, UInt16[DS, 0x26C]);
    CheckExternalEvents(cs7, 0xA2FE);
    // JNC 0x1000:a301 (1000_A2FC / 0x1A2FC)
    if(!CarryFlag) {
      goto label_1000_A301_1A301;
    }
    CheckExternalEvents(cs7, 0xA301);
    // MOV [0x26c],AX (1000_A2FE / 0x1A2FE)
    UInt16[DS, 0x26C] = AX;
    label_1000_A301_1A301:
    CheckExternalEvents(cs7, 0xA304);
    // MOV AX,[0x266] (1000_A301 / 0x1A301)
    AX = UInt16[DS, 0x266];
    CheckExternalEvents(cs7, 0xA307);
    // CMP AX,0x0 (1000_A304 / 0x1A304)
    Alu16.Sub(AX, 0x0);
    CheckExternalEvents(cs7, 0xA309);
    // JNS 0x1000:a320 (1000_A307 / 0x1A307)
    if(!SignFlag) {
      goto label_1000_A320_1A320;
    }
    CheckExternalEvents(cs7, 0xA30D);
    // ADD word ptr [0x268],AX (1000_A309 / 0x1A309)
    UInt16[DS, 0x268] += AX;
    CheckExternalEvents(cs7, 0xA30F);
    // NEG AX (1000_A30D / 0x1A30D)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs7, 0xA311);
    // SHL AX,0x1 (1000_A30F / 0x1A30F)
    AX <<= 0x1;
    CheckExternalEvents(cs7, 0xA313);
    // SHL AX,0x1 (1000_A311 / 0x1A311)
    AX <<= 0x1;
    CheckExternalEvents(cs7, 0xA315);
    // ADD SI,AX (1000_A313 / 0x1A313)
    SI += AX;
    CheckExternalEvents(cs7, 0xA319);
    // CMP AX,word ptr [0x26a] (1000_A315 / 0x1A315)
    Alu16.Sub(AX, UInt16[DS, 0x26A]);
    CheckExternalEvents(cs7, 0xA31B);
    // JNC 0x1000:a337 (1000_A319 / 0x1A319)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs7, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA31D);
    // XOR AX,AX (1000_A31B / 0x1A31B)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs7, 0xA320);
    // MOV [0x266],AX (1000_A31D / 0x1A31D)
    UInt16[DS, 0x266] = AX;
    label_1000_A320_1A320:
    CheckExternalEvents(cs7, 0xA323);
    // MOV AX,0x28 (1000_A320 / 0x1A320)
    AX = 0x28;
    CheckExternalEvents(cs7, 0xA327);
    // SUB AX,word ptr [0x266] (1000_A323 / 0x1A323)
    // AX -= UInt16[DS, 0x266];
    AX = Alu16.Sub(AX, UInt16[DS, 0x266]);
    CheckExternalEvents(cs7, 0xA329);
    // JS 0x1000:a337 (1000_A327 / 0x1A327)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs7, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA32B);
    // JZ 0x1000:a337 (1000_A329 / 0x1A329)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs7, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA32F);
    // CMP AX,word ptr [0x268] (1000_A32B / 0x1A32B)
    Alu16.Sub(AX, UInt16[DS, 0x268]);
    CheckExternalEvents(cs7, 0xA331);
    // JNC 0x1000:a33a (1000_A32F / 0x1A32F)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A33A_1A33A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA334);
    // MOV [0x268],AX (1000_A331 / 0x1A331)
    UInt16[DS, 0x268] = AX;
    CheckExternalEvents(cs7, 0xA336);
    // JMP 0x1000:a33a (1000_A334 / 0x1A334)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_A33A_1A33A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_A337_1A337(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A337_1A337:
    CheckExternalEvents(cs7, 0xA33A);
    // JMP 0x1000:a458 (1000_A337 / 0x1A337)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ghidra_guess_1000_A33A_1A33A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A33A_1A33A:
    CheckExternalEvents(cs7, 0xA33D);
    // MOV AX,[0x264] (1000_A33A / 0x1A33A)
    AX = UInt16[DS, 0x264];
    CheckExternalEvents(cs7, 0xA340);
    // MOV DX,0x28 (1000_A33D / 0x1A33D)
    DX = 0x28;
    CheckExternalEvents(cs7, 0xA342);
    // MUL DL (1000_A340 / 0x1A340)
    ushort resMul1000_A340 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A340);
    AH = (byte)(resMul1000_A340 >> 8);
    CheckExternalEvents(cs7, 0xA346);
    // ADD AX,word ptr [0x266] (1000_A342 / 0x1A342)
    AX += UInt16[DS, 0x266];
    CheckExternalEvents(cs7, 0xA348);
    // ADD DI,AX (1000_A346 / 0x1A346)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs7, 0xA34B);
    // MOV AX,0x28 (1000_A348 / 0x1A348)
    AX = 0x28;
    CheckExternalEvents(cs7, 0xA34F);
    // SUB AX,word ptr [0x268] (1000_A34B / 0x1A34B)
    // AX -= UInt16[DS, 0x268];
    AX = Alu16.Sub(AX, UInt16[DS, 0x268]);
    CheckExternalEvents(cs7, 0xA352);
    // MOV [0x264],AX (1000_A34F / 0x1A34F)
    UInt16[DS, 0x264] = AX;
    CheckExternalEvents(cs7, 0xA355);
    // MOV DX,0x3ce (1000_A352 / 0x1A352)
    DX = 0x3CE;
    CheckExternalEvents(cs7, 0xA358);
    // MOV AX,0x5 (1000_A355 / 0x1A355)
    AX = 0x5;
    CheckExternalEvents(cs7, 0xA359);
    // OUT DX,AX (1000_A358 / 0x1A358)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA35C);
    // MOV AX,0xff08 (1000_A359 / 0x1A359)
    AX = 0xFF08;
    CheckExternalEvents(cs7, 0xA35D);
    // OUT DX,AX (1000_A35C / 0x1A35C)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA361);
    // MOV BX,word ptr [0x262] (1000_A35D / 0x1A35D)
    BX = UInt16[DS, 0x262];
    CheckExternalEvents(cs7, 0xA364);
    // AND BX,0x7 (1000_A361 / 0x1A361)
    // BX &= 0x7;
    BX = Alu16.And(BX, 0x7);
    label_1000_A364_1A364:
    CheckExternalEvents(cs7, 0xA368);
    // MOV BP,word ptr [0x266] (1000_A364 / 0x1A364)
    BP = UInt16[DS, 0x266];
    CheckExternalEvents(cs7, 0xA36C);
    // MOV CX,word ptr [0x268] (1000_A368 / 0x1A368)
    CX = UInt16[DS, 0x268];
    CheckExternalEvents(cs7, 0xA36F);
    // MOV AX,[0x25c] (1000_A36C / 0x1A36C)
    AX = UInt16[DS, 0x25C];
    CheckExternalEvents(cs7, 0xA370);
    // PUSH DS (1000_A36F / 0x1A36F)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA372);
    // MOV DS,AX (1000_A370 / 0x1A370)
    DS = AX;
    CheckExternalEvents(cs7, 0xA374);
    // MOV DH,0x3 (1000_A372 / 0x1A372)
    DH = 0x3;
    label_1000_A374_1A374:
    CheckExternalEvents(cs7, 0xA375);
    // PUSH CX (1000_A374 / 0x1A374)
    Stack.Push16(CX);
    CheckExternalEvents(cs7, 0xA377);
    // MOV DL,0xce (1000_A375 / 0x1A375)
    DL = 0xCE;
    CheckExternalEvents(cs7, 0xA37A);
    // MOV AX,0x4 (1000_A377 / 0x1A377)
    AX = 0x4;
    CheckExternalEvents(cs7, 0xA37B);
    // OUT DX,AX (1000_A37A / 0x1A37A)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA37D);
    // MOV DL,0xc4 (1000_A37B / 0x1A37B)
    DL = 0xC4;
    CheckExternalEvents(cs7, 0xA380);
    // MOV AX,0x102 (1000_A37D / 0x1A37D)
    AX = 0x102;
    CheckExternalEvents(cs7, 0xA381);
    // OUT DX,AX (1000_A380 / 0x1A380)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA383);
    // MOV AX,word ptr [SI] (1000_A381 / 0x1A381)
    AX = UInt16[DS, (ushort)(SI)];
    CheckExternalEvents(cs7, 0xA386);
    // OR AX,word ptr [SI + 0x2] (1000_A383 / 0x1A383)
    // AX |= UInt16[DS, (ushort)(SI + 0x2)];
    AX = Alu16.Or(AX, UInt16[DS, (ushort)(SI + 0x2)]);
    CheckExternalEvents(cs7, 0xA388);
    // OR AH,AL (1000_A386 / 0x1A386)
    AH |= AL;
    CheckExternalEvents(cs7, 0xA38A);
    // XOR AL,AL (1000_A388 / 0x1A388)
    AL = 0;
    CheckExternalEvents(cs7, 0xA38C);
    // CMP BL,AL (1000_A38A / 0x1A38A)
    Alu8.Sub(BL, AL);
    CheckExternalEvents(cs7, 0xA38E);
    // JZ 0x1000:a392 (1000_A38C / 0x1A38C)
    if(ZeroFlag) {
      goto label_1000_A392_1A392;
    }
    CheckExternalEvents(cs7, 0xA390);
    // MOV CL,BL (1000_A38E / 0x1A38E)
    CL = BL;
    CheckExternalEvents(cs7, 0xA392);
    // SHR AX,CL (1000_A390 / 0x1A390)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    label_1000_A392_1A392:
    CheckExternalEvents(cs7, 0xA394);
    // NOT AX (1000_A392 / 0x1A392)
    AX = (ushort)(~AX);
    CheckExternalEvents(cs7, 0xA396);
    // MOV CH,AH (1000_A394 / 0x1A394)
    CH = AH;
    CheckExternalEvents(cs7, 0xA398);
    // MOV BH,AL (1000_A396 / 0x1A396)
    BH = AL;
    CheckExternalEvents(cs7, 0xA39B);
    // AND byte ptr ES:[DI],CH (1000_A398 / 0x1A398)
    // UInt8[ES, (ushort)(DI)] &= CH;
    UInt8[ES, (ushort)(DI)] = Alu8.And(UInt8[ES, (ushort)(DI)], CH);
    CheckExternalEvents(cs7, 0xA39C);
    // LODSB SI (1000_A39B / 0x1A39B)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xA39E);
    // MOV AH,AL (1000_A39C / 0x1A39C)
    AH = AL;
    CheckExternalEvents(cs7, 0xA3A0);
    // XOR AL,AL (1000_A39E / 0x1A39E)
    AL = 0;
    CheckExternalEvents(cs7, 0xA3A2);
    // CMP BL,AL (1000_A3A0 / 0x1A3A0)
    Alu8.Sub(BL, AL);
    CheckExternalEvents(cs7, 0xA3A4);
    // JZ 0x1000:a3a6 (1000_A3A2 / 0x1A3A2)
    if(ZeroFlag) {
      goto label_1000_A3A6_1A3A6;
    }
    CheckExternalEvents(cs7, 0xA3A6);
    // SHR AX,CL (1000_A3A4 / 0x1A3A4)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    label_1000_A3A6_1A3A6:
    CheckExternalEvents(cs7, 0xA3A9);
    // OR byte ptr ES:[DI],AH (1000_A3A6 / 0x1A3A6)
    UInt8[ES, (ushort)(DI)] |= AH;
    CheckExternalEvents(cs7, 0xA3AC);
    // CMP BP,0x27 (1000_A3A9 / 0x1A3A9)
    Alu16.Sub(BP, 0x27);
    CheckExternalEvents(cs7, 0xA3AE);
    // JNC 0x1000:a3b6 (1000_A3AC / 0x1A3AC)
    if(!CarryFlag) {
      goto label_1000_A3B6_1A3B6;
    }
    CheckExternalEvents(cs7, 0xA3B2);
    // AND byte ptr ES:[DI + 0x1],BH (1000_A3AE / 0x1A3AE)
    // UInt8[ES, (ushort)(DI + 0x1)] &= BH;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.And(UInt8[ES, (ushort)(DI + 0x1)], BH);
    CheckExternalEvents(cs7, 0xA3B6);
    // OR byte ptr ES:[DI + 0x1],AL (1000_A3B2 / 0x1A3B2)
    // UInt8[ES, (ushort)(DI + 0x1)] |= AL;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.Or(UInt8[ES, (ushort)(DI + 0x1)], AL);
    label_1000_A3B6_1A3B6:
    CheckExternalEvents(cs7, 0xA3B8);
    // MOV DL,0xce (1000_A3B6 / 0x1A3B6)
    DL = 0xCE;
    CheckExternalEvents(cs7, 0xA3BB);
    // MOV AX,0x104 (1000_A3B8 / 0x1A3B8)
    AX = 0x104;
    CheckExternalEvents(cs7, 0xA3BC);
    // OUT DX,AX (1000_A3BB / 0x1A3BB)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA3BE);
    // MOV DL,0xc4 (1000_A3BC / 0x1A3BC)
    DL = 0xC4;
    CheckExternalEvents(cs7, 0xA3C1);
    // MOV AX,0x202 (1000_A3BE / 0x1A3BE)
    AX = 0x202;
    CheckExternalEvents(cs7, 0xA3C2);
    // OUT DX,AX (1000_A3C1 / 0x1A3C1)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA3C5);
    // AND byte ptr ES:[DI],CH (1000_A3C2 / 0x1A3C2)
    // UInt8[ES, (ushort)(DI)] &= CH;
    UInt8[ES, (ushort)(DI)] = Alu8.And(UInt8[ES, (ushort)(DI)], CH);
    CheckExternalEvents(cs7, 0xA3C6);
    // LODSB SI (1000_A3C5 / 0x1A3C5)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xA3C8);
    // MOV AH,AL (1000_A3C6 / 0x1A3C6)
    AH = AL;
    CheckExternalEvents(cs7, 0xA3CA);
    // XOR AL,AL (1000_A3C8 / 0x1A3C8)
    AL = 0;
    CheckExternalEvents(cs7, 0xA3CC);
    // CMP BL,AL (1000_A3CA / 0x1A3CA)
    Alu8.Sub(BL, AL);
    CheckExternalEvents(cs7, 0xA3CE);
    // JZ 0x1000:a3d0 (1000_A3CC / 0x1A3CC)
    if(ZeroFlag) {
      goto label_1000_A3D0_1A3D0;
    }
    CheckExternalEvents(cs7, 0xA3D0);
    // SHR AX,CL (1000_A3CE / 0x1A3CE)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    label_1000_A3D0_1A3D0:
    CheckExternalEvents(cs7, 0xA3D3);
    // OR byte ptr ES:[DI],AH (1000_A3D0 / 0x1A3D0)
    UInt8[ES, (ushort)(DI)] |= AH;
    CheckExternalEvents(cs7, 0xA3D6);
    // CMP BP,0x27 (1000_A3D3 / 0x1A3D3)
    Alu16.Sub(BP, 0x27);
    CheckExternalEvents(cs7, 0xA3D8);
    // JNC 0x1000:a3e0 (1000_A3D6 / 0x1A3D6)
    if(!CarryFlag) {
      goto label_1000_A3E0_1A3E0;
    }
    CheckExternalEvents(cs7, 0xA3DC);
    // AND byte ptr ES:[DI + 0x1],BH (1000_A3D8 / 0x1A3D8)
    // UInt8[ES, (ushort)(DI + 0x1)] &= BH;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.And(UInt8[ES, (ushort)(DI + 0x1)], BH);
    CheckExternalEvents(cs7, 0xA3E0);
    // OR byte ptr ES:[DI + 0x1],AL (1000_A3DC / 0x1A3DC)
    // UInt8[ES, (ushort)(DI + 0x1)] |= AL;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.Or(UInt8[ES, (ushort)(DI + 0x1)], AL);
    label_1000_A3E0_1A3E0:
    CheckExternalEvents(cs7, 0xA3E2);
    // MOV DL,0xce (1000_A3E0 / 0x1A3E0)
    DL = 0xCE;
    CheckExternalEvents(cs7, 0xA3E5);
    // MOV AX,0x204 (1000_A3E2 / 0x1A3E2)
    AX = 0x204;
    CheckExternalEvents(cs7, 0xA3E6);
    // OUT DX,AX (1000_A3E5 / 0x1A3E5)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA3E8);
    // MOV DL,0xc4 (1000_A3E6 / 0x1A3E6)
    DL = 0xC4;
    CheckExternalEvents(cs7, 0xA3EB);
    // MOV AX,0x402 (1000_A3E8 / 0x1A3E8)
    AX = 0x402;
    CheckExternalEvents(cs7, 0xA3EC);
    // OUT DX,AX (1000_A3EB / 0x1A3EB)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA3EF);
    // AND byte ptr ES:[DI],CH (1000_A3EC / 0x1A3EC)
    // UInt8[ES, (ushort)(DI)] &= CH;
    UInt8[ES, (ushort)(DI)] = Alu8.And(UInt8[ES, (ushort)(DI)], CH);
    CheckExternalEvents(cs7, 0xA3F0);
    // LODSB SI (1000_A3EF / 0x1A3EF)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xA3F2);
    // MOV AH,AL (1000_A3F0 / 0x1A3F0)
    AH = AL;
    CheckExternalEvents(cs7, 0xA3F4);
    // XOR AL,AL (1000_A3F2 / 0x1A3F2)
    AL = 0;
    CheckExternalEvents(cs7, 0xA3F6);
    // CMP BL,AL (1000_A3F4 / 0x1A3F4)
    Alu8.Sub(BL, AL);
    CheckExternalEvents(cs7, 0xA3F8);
    // JZ 0x1000:a3fa (1000_A3F6 / 0x1A3F6)
    if(ZeroFlag) {
      goto label_1000_A3FA_1A3FA;
    }
    CheckExternalEvents(cs7, 0xA3FA);
    // SHR AX,CL (1000_A3F8 / 0x1A3F8)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    label_1000_A3FA_1A3FA:
    CheckExternalEvents(cs7, 0xA3FD);
    // OR byte ptr ES:[DI],AH (1000_A3FA / 0x1A3FA)
    UInt8[ES, (ushort)(DI)] |= AH;
    CheckExternalEvents(cs7, 0xA400);
    // CMP BP,0x27 (1000_A3FD / 0x1A3FD)
    Alu16.Sub(BP, 0x27);
    CheckExternalEvents(cs7, 0xA402);
    // JNC 0x1000:a40a (1000_A400 / 0x1A400)
    if(!CarryFlag) {
      goto label_1000_A40A_1A40A;
    }
    CheckExternalEvents(cs7, 0xA406);
    // AND byte ptr ES:[DI + 0x1],BH (1000_A402 / 0x1A402)
    // UInt8[ES, (ushort)(DI + 0x1)] &= BH;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.And(UInt8[ES, (ushort)(DI + 0x1)], BH);
    CheckExternalEvents(cs7, 0xA40A);
    // OR byte ptr ES:[DI + 0x1],AL (1000_A406 / 0x1A406)
    // UInt8[ES, (ushort)(DI + 0x1)] |= AL;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.Or(UInt8[ES, (ushort)(DI + 0x1)], AL);
    label_1000_A40A_1A40A:
    CheckExternalEvents(cs7, 0xA40C);
    // MOV DL,0xce (1000_A40A / 0x1A40A)
    DL = 0xCE;
    CheckExternalEvents(cs7, 0xA40F);
    // MOV AX,0x304 (1000_A40C / 0x1A40C)
    AX = 0x304;
    CheckExternalEvents(cs7, 0xA410);
    // OUT DX,AX (1000_A40F / 0x1A40F)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA412);
    // MOV DL,0xc4 (1000_A410 / 0x1A410)
    DL = 0xC4;
    CheckExternalEvents(cs7, 0xA415);
    // MOV AX,0x802 (1000_A412 / 0x1A412)
    AX = 0x802;
    CheckExternalEvents(cs7, 0xA416);
    // OUT DX,AX (1000_A415 / 0x1A415)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA419);
    // AND byte ptr ES:[DI],CH (1000_A416 / 0x1A416)
    // UInt8[ES, (ushort)(DI)] &= CH;
    UInt8[ES, (ushort)(DI)] = Alu8.And(UInt8[ES, (ushort)(DI)], CH);
    CheckExternalEvents(cs7, 0xA41A);
    // LODSB SI (1000_A419 / 0x1A419)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xA41C);
    // MOV AH,AL (1000_A41A / 0x1A41A)
    AH = AL;
    CheckExternalEvents(cs7, 0xA41E);
    // XOR AL,AL (1000_A41C / 0x1A41C)
    AL = 0;
    CheckExternalEvents(cs7, 0xA420);
    // CMP BL,AL (1000_A41E / 0x1A41E)
    Alu8.Sub(BL, AL);
    CheckExternalEvents(cs7, 0xA422);
    // JZ 0x1000:a424 (1000_A420 / 0x1A420)
    if(ZeroFlag) {
      goto label_1000_A424_1A424;
    }
    CheckExternalEvents(cs7, 0xA424);
    // SHR AX,CL (1000_A422 / 0x1A422)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    label_1000_A424_1A424:
    CheckExternalEvents(cs7, 0xA427);
    // OR byte ptr ES:[DI],AH (1000_A424 / 0x1A424)
    UInt8[ES, (ushort)(DI)] |= AH;
    CheckExternalEvents(cs7, 0xA42A);
    // CMP BP,0x27 (1000_A427 / 0x1A427)
    Alu16.Sub(BP, 0x27);
    CheckExternalEvents(cs7, 0xA42C);
    // JNC 0x1000:a434 (1000_A42A / 0x1A42A)
    if(!CarryFlag) {
      goto label_1000_A434_1A434;
    }
    CheckExternalEvents(cs7, 0xA430);
    // AND byte ptr ES:[DI + 0x1],BH (1000_A42C / 0x1A42C)
    // UInt8[ES, (ushort)(DI + 0x1)] &= BH;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.And(UInt8[ES, (ushort)(DI + 0x1)], BH);
    CheckExternalEvents(cs7, 0xA434);
    // OR byte ptr ES:[DI + 0x1],AL (1000_A430 / 0x1A430)
    UInt8[ES, (ushort)(DI + 0x1)] |= AL;
    label_1000_A434_1A434:
    CheckExternalEvents(cs7, 0xA435);
    // INC BP (1000_A434 / 0x1A434)
    BP++;
    CheckExternalEvents(cs7, 0xA436);
    // INC DI (1000_A435 / 0x1A435)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs7, 0xA437);
    // POP CX (1000_A436 / 0x1A436)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA439);
    // LOOP 0x1000:a455 (1000_A437 / 0x1A437)
    if(--CX != 0) {
      // LOOP target is JMP, inlining.
      CheckExternalEvents(cs7, 0xA458);
      // JMP 0x1000:a374 (1000_A455 / 0x1A455)
      goto label_1000_A374_1A374;
    }
    CheckExternalEvents(cs7, 0xA43A);
    // POP DS (1000_A439 / 0x1A439)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA43E);
    // ADD SI,word ptr [0x26a] (1000_A43A / 0x1A43A)
    // SI += UInt16[DS, 0x26A];
    SI = Alu16.Add(SI, UInt16[DS, 0x26A]);
    CheckExternalEvents(cs7, 0xA441);
    // MOV AX,[0x268] (1000_A43E / 0x1A43E)
    AX = UInt16[DS, 0x268];
    CheckExternalEvents(cs7, 0xA443);
    // SHL AX,0x1 (1000_A441 / 0x1A441)
    AX <<= 0x1;
    CheckExternalEvents(cs7, 0xA445);
    // SHL AX,0x1 (1000_A443 / 0x1A443)
    AX <<= 0x1;
    CheckExternalEvents(cs7, 0xA447);
    // SUB SI,AX (1000_A445 / 0x1A445)
    SI -= AX;
    CheckExternalEvents(cs7, 0xA44B);
    // ADD DI,word ptr [0x264] (1000_A447 / 0x1A447)
    DI += UInt16[DS, 0x264];
    label_1000_A44B_1A44B:
    CheckExternalEvents(cs7, 0xA450);
    // SUB word ptr [0x26c],0x1 (1000_A44B / 0x1A44B)
    // UInt16[DS, 0x26C] -= 0x1;
    UInt16[DS, 0x26C] = Alu16.Sub(UInt16[DS, 0x26C], 0x1);
    CheckExternalEvents(cs7, 0xA452);
    // JZ 0x1000:a458 (1000_A450 / 0x1A450)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA455);
    // JMP 0x1000:a364 (1000_A452 / 0x1A452)
    goto label_1000_A364_1A364;
    label_1000_A455_1A455:
    CheckExternalEvents(cs7, 0xA458);
    // JMP 0x1000:a374 (1000_A455 / 0x1A455)
    goto label_1000_A374_1A374;
  }
  
  public virtual Action ghidra_guess_1000_A458_1A458(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A458_1A458:
    CheckExternalEvents(cs7, 0xA45B);
    // MOV AX,0xf02 (1000_A458 / 0x1A458)
    AX = 0xF02;
    CheckExternalEvents(cs7, 0xA45C);
    // OUT DX,AX (1000_A45B / 0x1A45B)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA45D);
    // POP ES (1000_A45C / 0x1A45C)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA45E);
    // POP DS (1000_A45D / 0x1A45D)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA45F);
    // POP SI (1000_A45E / 0x1A45E)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA460);
    // POP DI (1000_A45F / 0x1A45F)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA461);
    // POP BP (1000_A460 / 0x1A460)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA462);
    // RETF  (1000_A461 / 0x1A461)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A462_1A462(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A462_1A462:
    CheckExternalEvents(cs7, 0xA463);
    // PUSH BP (1000_A462 / 0x1A462)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xA465);
    // MOV BP,SP (1000_A463 / 0x1A463)
    BP = SP;
    CheckExternalEvents(cs7, 0xA466);
    // PUSH DI (1000_A465 / 0x1A465)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xA467);
    // PUSH SI (1000_A466 / 0x1A466)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xA468);
    // PUSH DS (1000_A467 / 0x1A467)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA46B);
    // MOV AX,0x1ddc (1000_A468 / 0x1A468)
    AX = 0x1DDC;
    CheckExternalEvents(cs7, 0xA46D);
    // MOV DS,AX (1000_A46B / 0x1A46B)
    DS = AX;
    CheckExternalEvents(cs7, 0xA46E);
    // PUSH ES (1000_A46D / 0x1A46D)
    Stack.Push16(ES);
    CheckExternalEvents(cs7, 0xA471);
    // MOV SI,word ptr [BP + 0x6] (1000_A46E / 0x1A46E)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xA474);
    // MOV BX,word ptr [BP + 0x8] (1000_A471 / 0x1A471)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xA477);
    // MOV DI,word ptr [BP + 0xa] (1000_A474 / 0x1A474)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0xA47A);
    // MOV AX,word ptr [BP + 0xc] (1000_A477 / 0x1A477)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs7, 0xA47C);
    // MOV ES,AX (1000_A47A / 0x1A47A)
    ES = AX;
    CheckExternalEvents(cs7, 0xA47F);
    // MOV CX,word ptr [BP + 0xe] (1000_A47C / 0x1A47C)
    CX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs7, 0xA481);
    // SHR CX,0x1 (1000_A47F / 0x1A47F)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    CheckExternalEvents(cs7, 0xA482);
    // PUSH DS (1000_A481 / 0x1A481)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xA484);
    // MOV DS,BX (1000_A482 / 0x1A482)
    DS = BX;
    label_1000_A484_1A484:
    CheckExternalEvents(cs7, 0xA485);
    // LODSB SI (1000_A484 / 0x1A484)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xA488);
    // CALL 0x1000:a4af (1000_A485 / 0x1A485)
    NearCall(cs7, 0xA488, ghidra_guess_1000_A4AF_1A4AF);
    CheckExternalEvents(cs7, 0xA48B);
    // CALL 0x1000:a4af (1000_A488 / 0x1A488)
    NearCall(cs7, 0xA48B, ghidra_guess_1000_A4AF_1A4AF);
    CheckExternalEvents(cs7, 0xA48C);
    // LODSB SI (1000_A48B / 0x1A48B)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xA48F);
    // CALL 0x1000:a4af (1000_A48C / 0x1A48C)
    NearCall(cs7, 0xA48F, ghidra_guess_1000_A4AF_1A4AF);
    CheckExternalEvents(cs7, 0xA492);
    // CALL 0x1000:a4af (1000_A48F / 0x1A48F)
    NearCall(cs7, 0xA492, ghidra_guess_1000_A4AF_1A4AF);
    CheckExternalEvents(cs7, 0xA493);
    // LODSB SI (1000_A492 / 0x1A492)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xA496);
    // CALL 0x1000:a4af (1000_A493 / 0x1A493)
    NearCall(cs7, 0xA496, ghidra_guess_1000_A4AF_1A4AF);
    CheckExternalEvents(cs7, 0xA499);
    // CALL 0x1000:a4af (1000_A496 / 0x1A496)
    NearCall(cs7, 0xA499, ghidra_guess_1000_A4AF_1A4AF);
    CheckExternalEvents(cs7, 0xA49A);
    // LODSB SI (1000_A499 / 0x1A499)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs7, 0xA49D);
    // CALL 0x1000:a4af (1000_A49A / 0x1A49A)
    NearCall(cs7, 0xA49D, ghidra_guess_1000_A4AF_1A4AF);
    CheckExternalEvents(cs7, 0xA4A0);
    // CALL 0x1000:a4af (1000_A49D / 0x1A49D)
    NearCall(cs7, 0xA4A0, ghidra_guess_1000_A4AF_1A4AF);
    CheckExternalEvents(cs7, 0xA4A2);
    // MOV AX,BX (1000_A4A0 / 0x1A4A0)
    AX = BX;
    CheckExternalEvents(cs7, 0xA4A3);
    // STOSW ES:DI (1000_A4A2 / 0x1A4A2)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs7, 0xA4A5);
    // MOV AX,DX (1000_A4A3 / 0x1A4A3)
    AX = DX;
    CheckExternalEvents(cs7, 0xA4A6);
    // STOSW ES:DI (1000_A4A5 / 0x1A4A5)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs7, 0xA4A8);
    // LOOP 0x1000:a484 (1000_A4A6 / 0x1A4A6)
    if(--CX != 0) {
      goto label_1000_A484_1A484;
    }
    CheckExternalEvents(cs7, 0xA4A9);
    // POP DS (1000_A4A8 / 0x1A4A8)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA4AA);
    // POP ES (1000_A4A9 / 0x1A4A9)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA4AB);
    // POP DS (1000_A4AA / 0x1A4AA)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA4AC);
    // POP SI (1000_A4AB / 0x1A4AB)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA4AD);
    // POP DI (1000_A4AC / 0x1A4AC)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA4AE);
    // POP BP (1000_A4AD / 0x1A4AD)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA4AF);
    // RETF  (1000_A4AE / 0x1A4AE)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A4AF_1A4AF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A4AF_1A4AF:
    CheckExternalEvents(cs7, 0xA4B1);
    // SHL AL,0x1 (1000_A4AF / 0x1A4AF)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs7, 0xA4B3);
    // RCL DH,0x1 (1000_A4B1 / 0x1A4B1)
    DH = Alu.Rcl8(DH, 0x1);
    CheckExternalEvents(cs7, 0xA4B5);
    // SHL AL,0x1 (1000_A4B3 / 0x1A4B3)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs7, 0xA4B7);
    // RCL DL,0x1 (1000_A4B5 / 0x1A4B5)
    DL = Alu.Rcl8(DL, 0x1);
    CheckExternalEvents(cs7, 0xA4B9);
    // SHL AL,0x1 (1000_A4B7 / 0x1A4B7)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs7, 0xA4BB);
    // RCL BH,0x1 (1000_A4B9 / 0x1A4B9)
    BH = Alu.Rcl8(BH, 0x1);
    CheckExternalEvents(cs7, 0xA4BD);
    // SHL AL,0x1 (1000_A4BB / 0x1A4BB)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs7, 0xA4BF);
    // RCL BL,0x1 (1000_A4BD / 0x1A4BD)
    BL = Alu.Rcl8(BL, 0x1);
    CheckExternalEvents(cs7, 0xA4C0);
    // RET  (1000_A4BF / 0x1A4BF)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_05D0_1A4C0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_05D0_1A4C0:
    CheckExternalEvents(cs12, 0x5D1);
    // PUSH BP (19EF_05D0 / 0x1A4C0)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x5D3);
    // MOV BP,SP (19EF_05D1 / 0x1A4C1)
    BP = SP;
    CheckExternalEvents(cs12, 0x5D4);
    // PUSH DI (19EF_05D3 / 0x1A4C3)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x5D5);
    // PUSH SI (19EF_05D4 / 0x1A4C4)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x5D6);
    // PUSH DS (19EF_05D5 / 0x1A4C5)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x5D9);
    // MOV AX,0x1ddc (19EF_05D6 / 0x1A4C6)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x5DB);
    // MOV DS,AX (19EF_05D9 / 0x1A4C9)
    DS = AX;
    CheckExternalEvents(cs12, 0x5DC);
    // PUSH ES (19EF_05DB / 0x1A4CB)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x5DF);
    // MOV AX,word ptr [BP + 0x6] (19EF_05DC / 0x1A4CC)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x5E2);
    // MOV [0x220],AX (19EF_05DF / 0x1A4CF)
    UInt16[DS, 0x220] = AX;
    CheckExternalEvents(cs12, 0x5E5);
    // MOV AX,word ptr [BP + 0x8] (19EF_05E2 / 0x1A4D2)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x5E8);
    // MOV [0x234],AX (19EF_05E5 / 0x1A4D5)
    UInt16[DS, 0x234] = AX;
    CheckExternalEvents(cs12, 0x5EB);
    // MOV AX,word ptr [BP + 0xa] (19EF_05E8 / 0x1A4D8)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x5EE);
    // MOV [0x236],AX (19EF_05EB / 0x1A4DB)
    UInt16[DS, 0x236] = AX;
    CheckExternalEvents(cs12, 0x5F1);
    // MOV AX,word ptr [BP + 0xc] (19EF_05EE / 0x1A4DE)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs12, 0x5F4);
    // MOV [0x224],AX (19EF_05F1 / 0x1A4E1)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs12, 0x5F9);
    // CMP word ptr [0xb764],0x3 (19EF_05F4 / 0x1A4E4)
    Alu16.Sub(UInt16[DS, 0xB764], 0x3);
    CheckExternalEvents(cs12, 0x5FB);
    // JZ 0x1000:a4f5 (19EF_05F9 / 0x1A4E9)
    if(ZeroFlag) {
      goto label_19EF_0605_1A4F5;
    }
    CheckExternalEvents(cs12, 0x600);
    // CMP word ptr [0xb764],0x0 (19EF_05FB / 0x1A4EB)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs12, 0x602);
    // JNZ 0x1000:a520 (19EF_0600 / 0x1A4F0)
    if(!ZeroFlag) {
      goto label_19EF_0630_1A520;
    }
    CheckExternalEvents(cs12, 0x605);
    // JMP 0x1000:a5ed (19EF_0602 / 0x1A4F2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_A5ED_1A5ED, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_0605_1A4F5:
    CheckExternalEvents(cs12, 0x608);
    // MOV AX,0xa000 (19EF_0605 / 0x1A4F5)
    AX = 0xA000;
    CheckExternalEvents(cs12, 0x60A);
    // MOV ES,AX (19EF_0608 / 0x1A4F8)
    ES = AX;
    CheckExternalEvents(cs12, 0x60D);
    // MOV AX,[0x234] (19EF_060A / 0x1A4FA)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs12, 0x610);
    // MOV DX,0x140 (19EF_060D / 0x1A4FD)
    DX = 0x140;
    CheckExternalEvents(cs12, 0x612);
    // MUL DX (19EF_0610 / 0x1A500)
    uint resMul19EF_0610 = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul19EF_0610);
    DX = (ushort)(resMul19EF_0610 >> 16);
    CheckExternalEvents(cs12, 0x616);
    // ADD AX,word ptr [0x220] (19EF_0612 / 0x1A502)
    // AX += UInt16[DS, 0x220];
    AX = Alu16.Add(AX, UInt16[DS, 0x220]);
    CheckExternalEvents(cs12, 0x618);
    // MOV DI,AX (19EF_0616 / 0x1A506)
    DI = AX;
    CheckExternalEvents(cs12, 0x61C);
    // MOV CX,word ptr [0x236] (19EF_0618 / 0x1A508)
    CX = UInt16[DS, 0x236];
    CheckExternalEvents(cs12, 0x620);
    // SUB CX,word ptr [0x234] (19EF_061C / 0x1A50C)
    CX -= UInt16[DS, 0x234];
    CheckExternalEvents(cs12, 0x621);
    // INC CX (19EF_0620 / 0x1A510)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs12, 0x624);
    // MOV AX,[0x224] (19EF_0621 / 0x1A511)
    AX = UInt16[DS, 0x224];
    label_19EF_0624_1A514:
    CheckExternalEvents(cs12, 0x627);
    // MOV byte ptr ES:[DI],AL (19EF_0624 / 0x1A514)
    UInt8[ES, (ushort)(DI)] = AL;
    CheckExternalEvents(cs12, 0x62B);
    // ADD DI,0x140 (19EF_0627 / 0x1A517)
    // DI += 0x140;
    DI = Alu16.Add(DI, 0x140);
    CheckExternalEvents(cs12, 0x62D);
    // LOOP 0x1000:a514 (19EF_062B / 0x1A51B)
    if(--CX != 0) {
      goto label_19EF_0624_1A514;
    }
    CheckExternalEvents(cs12, 0x630);
    // JMP 0x1000:a5e7 (19EF_062D / 0x1A51D)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A5E1_1A5E1, 0x1A5E7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_0630_1A520:
    CheckExternalEvents(cs12, 0x635);
    // CMP word ptr [0xb764],0x1 (19EF_0630 / 0x1A520)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs12, 0x637);
    // JZ 0x1000:a56f (19EF_0635 / 0x1A525)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A56F_1A56F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs12, 0x63A);
    // MOV DX,0x3ce (19EF_0637 / 0x1A527)
    DX = 0x3CE;
    CheckExternalEvents(cs12, 0x63D);
    // MOV AX,0x205 (19EF_063A / 0x1A52A)
    AX = 0x205;
    CheckExternalEvents(cs12, 0x63E);
    // OUT DX,AX (19EF_063D / 0x1A52D)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x642);
    // MOV CX,word ptr [0x220] (19EF_063E / 0x1A52E)
    CX = UInt16[DS, 0x220];
    CheckExternalEvents(cs12, 0x645);
    // MOV AX,0x8008 (19EF_0642 / 0x1A532)
    AX = 0x8008;
    CheckExternalEvents(cs12, 0x648);
    // AND CX,0x7 (19EF_0645 / 0x1A535)
    // CX &= 0x7;
    CX = Alu16.And(CX, 0x7);
    CheckExternalEvents(cs12, 0x64A);
    // JZ 0x1000:a53c (19EF_0648 / 0x1A538)
    if(ZeroFlag) {
      goto label_19EF_064C_1A53C;
    }
    CheckExternalEvents(cs12, 0x64C);
    // SHR AH,CL (19EF_064A / 0x1A53A)
    // AH >>= CL;
    AH = Alu8.Shr(AH, CL);
    label_19EF_064C_1A53C:
    CheckExternalEvents(cs12, 0x64D);
    // OUT DX,AX (19EF_064C / 0x1A53C)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs12, 0x650);
    // MOV AX,0xa000 (19EF_064D / 0x1A53D)
    AX = 0xA000;
    CheckExternalEvents(cs12, 0x652);
    // MOV ES,AX (19EF_0650 / 0x1A540)
    ES = AX;
    CheckExternalEvents(cs12, 0x656);
    // MOV DX,word ptr [0x234] (19EF_0652 / 0x1A542)
    DX = UInt16[DS, 0x234];
    CheckExternalEvents(cs12, 0x659);
    // MOV AX,0x28 (19EF_0656 / 0x1A546)
    AX = 0x28;
    CheckExternalEvents(cs12, 0x65B);
    // MUL DL (19EF_0659 / 0x1A549)
    ushort resMul19EF_0659 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul19EF_0659);
    AH = (byte)(resMul19EF_0659 >> 8);
    CheckExternalEvents(cs12, 0x65F);
    // MOV BX,word ptr [0x220] (19EF_065B / 0x1A54B)
    BX = UInt16[DS, 0x220];
    CheckExternalEvents(cs12, 0x661);
    // SHR BX,0x1 (19EF_065F / 0x1A54F)
    BX >>= 0x1;
    CheckExternalEvents(cs12, 0x663);
    // SHR BX,0x1 (19EF_0661 / 0x1A551)
    BX >>= 0x1;
    CheckExternalEvents(cs12, 0x665);
    // SHR BX,0x1 (19EF_0663 / 0x1A553)
    BX >>= 0x1;
    CheckExternalEvents(cs12, 0x667);
    // ADD AX,BX (19EF_0665 / 0x1A555)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs12, 0x669);
    // MOV DI,AX (19EF_0667 / 0x1A557)
    DI = AX;
    CheckExternalEvents(cs12, 0x66C);
    // MOV AX,[0x224] (19EF_0669 / 0x1A559)
    AX = UInt16[DS, 0x224];
    label_19EF_066C_1A55C:
    CheckExternalEvents(cs12, 0x66F);
    // MOV AH,byte ptr ES:[DI] (19EF_066C / 0x1A55C)
    AH = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs12, 0x672);
    // MOV byte ptr ES:[DI],AL (19EF_066F / 0x1A55F)
    UInt8[ES, (ushort)(DI)] = AL;
    CheckExternalEvents(cs12, 0x675);
    // ADD DI,0x28 (19EF_0672 / 0x1A562)
    DI += 0x28;
    CheckExternalEvents(cs12, 0x676);
    // INC DX (19EF_0675 / 0x1A565)
    DX++;
    CheckExternalEvents(cs12, 0x67A);
    // CMP DX,word ptr [0x236] (19EF_0676 / 0x1A566)
    Alu16.Sub(DX, UInt16[DS, 0x236]);
    CheckExternalEvents(cs12, 0x67C);
    // JLE 0x1000:a55c (19EF_067A / 0x1A56A)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_19EF_066C_1A55C;
    }
    CheckExternalEvents(cs12, 0x67E);
    // JMP 0x1000:a5e7 (19EF_067C / 0x1A56C)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A5E1_1A5E1, 0x1A5E7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_A56F_1A56F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A56F_1A56F:
    CheckExternalEvents(cs7, 0xA572);
    // MOV CX,0x4 (1000_A56F / 0x1A56F)
    CX = 0x4;
    CheckExternalEvents(cs7, 0xA574);
    // SHL AX,CL (1000_A572 / 0x1A572)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs7, 0xA578);
    // OR AX,word ptr [0x224] (1000_A574 / 0x1A574)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs7, 0xA57B);
    // MOV BX,0xf (1000_A578 / 0x1A578)
    BX = 0xF;
    CheckExternalEvents(cs7, 0xA57F);
    // MOV CX,word ptr [0x220] (1000_A57B / 0x1A57B)
    CX = UInt16[DS, 0x220];
    CheckExternalEvents(cs7, 0xA583);
    // TEST CX,0x1 (1000_A57F / 0x1A57F)
    Alu16.And(CX, 0x1);
    CheckExternalEvents(cs7, 0xA585);
    // JNZ 0x1000:a58a (1000_A583 / 0x1A583)
    if(!ZeroFlag) {
      goto label_1000_A58A_1A58A;
    }
    CheckExternalEvents(cs7, 0xA588);
    // MOV CX,0x4 (1000_A585 / 0x1A585)
    CX = 0x4;
    CheckExternalEvents(cs7, 0xA58A);
    // SHL BX,CL (1000_A588 / 0x1A588)
    BX <<= CL;
    label_1000_A58A_1A58A:
    CheckExternalEvents(cs7, 0xA58C);
    // AND AX,BX (1000_A58A / 0x1A58A)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs7, 0xA58F);
    // MOV [0x224],AX (1000_A58C / 0x1A58C)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs7, 0xA591);
    // NOT BL (1000_A58F / 0x1A58F)
    BL = (byte)(~BL);
    CheckExternalEvents(cs7, 0xA594);
    // MOV AX,0xb800 (1000_A591 / 0x1A591)
    AX = 0xB800;
    CheckExternalEvents(cs7, 0xA596);
    // MOV ES,AX (1000_A594 / 0x1A594)
    ES = AX;
    CheckExternalEvents(cs7, 0xA599);
    // MOV AX,[0x234] (1000_A596 / 0x1A596)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA59B);
    // AND AL,0xfc (1000_A599 / 0x1A599)
    // AL &= 0xFC;
    AL = Alu8.And(AL, 0xFC);
    CheckExternalEvents(cs7, 0xA59E);
    // MOV DX,0x28 (1000_A59B / 0x1A59B)
    DX = 0x28;
    CheckExternalEvents(cs7, 0xA5A0);
    // MUL DL (1000_A59E / 0x1A59E)
    ushort resMul1000_A59E = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A59E);
    AH = (byte)(resMul1000_A59E >> 8);
    CheckExternalEvents(cs7, 0xA5A4);
    // MOV CX,word ptr [0x234] (1000_A5A0 / 0x1A5A0)
    CX = UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA5A7);
    // AND CX,0x3 (1000_A5A4 / 0x1A5A4)
    // CX &= 0x3;
    CX = Alu16.And(CX, 0x3);
    CheckExternalEvents(cs7, 0xA5A9);
    // JZ 0x1000:a5ae (1000_A5A7 / 0x1A5A7)
    if(ZeroFlag) {
      goto label_1000_A5AE_1A5AE;
    }
    label_1000_A5A9_1A5A9:
    CheckExternalEvents(cs7, 0xA5AC);
    // ADD AH,0x20 (1000_A5A9 / 0x1A5A9)
    // AH += 0x20;
    AH = Alu8.Add(AH, 0x20);
    CheckExternalEvents(cs7, 0xA5AE);
    // LOOP 0x1000:a5a9 (1000_A5AC / 0x1A5AC)
    if(--CX != 0) {
      goto label_1000_A5A9_1A5A9;
    }
    label_1000_A5AE_1A5AE:
    CheckExternalEvents(cs7, 0xA5B2);
    // MOV DX,word ptr [0x220] (1000_A5AE / 0x1A5AE)
    DX = UInt16[DS, 0x220];
    CheckExternalEvents(cs7, 0xA5B4);
    // SHR DX,0x1 (1000_A5B2 / 0x1A5B2)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xA5B6);
    // ADD AX,DX (1000_A5B4 / 0x1A5B4)
    // AX += DX;
    AX = Alu16.Add(AX, DX);
    CheckExternalEvents(cs7, 0xA5BA);
    // MOV DX,word ptr [0x234] (1000_A5B6 / 0x1A5B6)
    DX = UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA5BC);
    // MOV DI,AX (1000_A5BA / 0x1A5BA)
    DI = AX;
    CheckExternalEvents(cs7, 0xA5C0);
    // MOV CX,word ptr [0x236] (1000_A5BC / 0x1A5BC)
    CX = UInt16[DS, 0x236];
    CheckExternalEvents(cs7, 0xA5C4);
    // SUB CX,word ptr [0x234] (1000_A5C0 / 0x1A5C0)
    CX -= UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA5C5);
    // INC CX (1000_A5C4 / 0x1A5C4)
    CX = Alu16.Inc(CX);
    label_1000_A5C5_1A5C5:
    CheckExternalEvents(cs7, 0xA5C8);
    // MOV AL,byte ptr ES:[DI] (1000_A5C5 / 0x1A5C5)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xA5CA);
    // AND AL,BL (1000_A5C8 / 0x1A5C8)
    // AL &= BL;
    AL = Alu8.And(AL, BL);
    CheckExternalEvents(cs7, 0xA5CE);
    // OR AX,word ptr [0x224] (1000_A5CA / 0x1A5CA)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs7, 0xA5D1);
    // MOV byte ptr ES:[DI],AL (1000_A5CE / 0x1A5CE)
    UInt8[ES, (ushort)(DI)] = AL;
    CheckExternalEvents(cs7, 0xA5D3);
    // INC DL (1000_A5D1 / 0x1A5D1)
    DL++;
    CheckExternalEvents(cs7, 0xA5D6);
    // AND DL,0x3 (1000_A5D3 / 0x1A5D3)
    // DL &= 0x3;
    DL = Alu8.And(DL, 0x3);
    CheckExternalEvents(cs7, 0xA5D8);
    // JZ 0x1000:a5e1 (1000_A5D6 / 0x1A5D6)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A5E1_1A5E1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xA5DC);
    // ADD DI,0x2000 (1000_A5D8 / 0x1A5D8)
    // DI += 0x2000;
    DI = Alu16.Add(DI, 0x2000);
    CheckExternalEvents(cs7, 0xA5DE);
    // LOOP 0x1000:a5c5 (1000_A5DC / 0x1A5DC)
    if(--CX != 0) {
      goto label_1000_A5C5_1A5C5;
    }
    CheckExternalEvents(cs7, 0xA5E0);
    // JMP 0x1000:a5e7 (1000_A5DE / 0x1A5DE)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A5E1_1A5E1, 0x1A5E7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_A5E1_1A5E1(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1A5E7: goto label_19EF_06F7_1A5E7;break; // Target of external jump from 0x1A51D
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_A5E1_1A5E1:
    CheckExternalEvents(cs7, 0xA5E5);
    // SUB DI,0x5f60 (1000_A5E1 / 0x1A5E1)
    // DI -= 0x5F60;
    DI = Alu16.Sub(DI, 0x5F60);
    CheckExternalEvents(cs7, 0xA5E7);
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
    CheckExternalEvents(cs7, 0xA5E8);
    // POP ES (1000_A5E7 / 0x1A5E7)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA5E9);
    // POP DS (1000_A5E8 / 0x1A5E8)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA5EA);
    // POP SI (1000_A5E9 / 0x1A5E9)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA5EB);
    // POP DI (1000_A5EA / 0x1A5EA)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA5EC);
    // POP BP (1000_A5EB / 0x1A5EB)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA5ED);
    // RETF  (1000_A5EC / 0x1A5EC)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A5ED_1A5ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A5ED_1A5ED:
    CheckExternalEvents(cs7, 0xA5F0);
    // AND AX,0x3 (1000_A5ED / 0x1A5ED)
    // AX &= 0x3;
    AX = Alu16.And(AX, 0x3);
    CheckExternalEvents(cs7, 0xA5F3);
    // MOV [0x224],AX (1000_A5F0 / 0x1A5F0)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs7, 0xA5F5);
    // SHL AX,0x1 (1000_A5F3 / 0x1A5F3)
    AX <<= 0x1;
    CheckExternalEvents(cs7, 0xA5F7);
    // SHL AX,0x1 (1000_A5F5 / 0x1A5F5)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs7, 0xA5FB);
    // OR AX,word ptr [0x224] (1000_A5F7 / 0x1A5F7)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs7, 0xA5FD);
    // MOV BX,AX (1000_A5FB / 0x1A5FB)
    BX = AX;
    CheckExternalEvents(cs7, 0xA600);
    // MOV CX,0x4 (1000_A5FD / 0x1A5FD)
    CX = 0x4;
    CheckExternalEvents(cs7, 0xA602);
    // SHL AX,CL (1000_A600 / 0x1A600)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs7, 0xA604);
    // OR AX,BX (1000_A602 / 0x1A602)
    // AX |= BX;
    AX = Alu16.Or(AX, BX);
    CheckExternalEvents(cs7, 0xA607);
    // MOV BX,0x3 (1000_A604 / 0x1A604)
    BX = 0x3;
    CheckExternalEvents(cs7, 0xA60B);
    // MOV CX,word ptr [0x220] (1000_A607 / 0x1A607)
    CX = UInt16[DS, 0x220];
    CheckExternalEvents(cs7, 0xA60E);
    // AND CX,0x3 (1000_A60B / 0x1A60B)
    CX &= 0x3;
    CheckExternalEvents(cs7, 0xA611);
    // XOR CX,0x3 (1000_A60E / 0x1A60E)
    // CX ^= 0x3;
    CX = Alu16.Xor(CX, 0x3);
    CheckExternalEvents(cs7, 0xA613);
    // JZ 0x1000:a617 (1000_A611 / 0x1A611)
    if(ZeroFlag) {
      goto label_1000_A617_1A617;
    }
    CheckExternalEvents(cs7, 0xA615);
    // ADD CX,CX (1000_A613 / 0x1A613)
    CX += CX;
    CheckExternalEvents(cs7, 0xA617);
    // SHL BX,CL (1000_A615 / 0x1A615)
    BX <<= CL;
    label_1000_A617_1A617:
    CheckExternalEvents(cs7, 0xA619);
    // AND AX,BX (1000_A617 / 0x1A617)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs7, 0xA61C);
    // MOV [0x224],AX (1000_A619 / 0x1A619)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs7, 0xA61E);
    // NOT BL (1000_A61C / 0x1A61C)
    BL = (byte)(~BL);
    CheckExternalEvents(cs7, 0xA621);
    // MOV AX,0xb800 (1000_A61E / 0x1A61E)
    AX = 0xB800;
    CheckExternalEvents(cs7, 0xA623);
    // MOV ES,AX (1000_A621 / 0x1A621)
    ES = AX;
    CheckExternalEvents(cs7, 0xA626);
    // MOV AX,[0x234] (1000_A623 / 0x1A623)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA628);
    // AND AL,0xfe (1000_A626 / 0x1A626)
    // AL &= 0xFE;
    AL = Alu8.And(AL, 0xFE);
    CheckExternalEvents(cs7, 0xA62B);
    // MOV DX,0x28 (1000_A628 / 0x1A628)
    DX = 0x28;
    CheckExternalEvents(cs7, 0xA62D);
    // MUL DL (1000_A62B / 0x1A62B)
    ushort resMul1000_A62B = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A62B);
    AH = (byte)(resMul1000_A62B >> 8);
    CheckExternalEvents(cs7, 0xA631);
    // MOV DX,word ptr [0x220] (1000_A62D / 0x1A62D)
    DX = UInt16[DS, 0x220];
    CheckExternalEvents(cs7, 0xA633);
    // SHR DX,0x1 (1000_A631 / 0x1A631)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xA635);
    // SHR DX,0x1 (1000_A633 / 0x1A633)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xA637);
    // ADD AX,DX (1000_A635 / 0x1A635)
    // AX += DX;
    AX = Alu16.Add(AX, DX);
    CheckExternalEvents(cs7, 0xA63B);
    // MOV DX,word ptr [0x234] (1000_A637 / 0x1A637)
    DX = UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA63E);
    // AND DX,0x1 (1000_A63B / 0x1A63B)
    // DX &= 0x1;
    DX = Alu16.And(DX, 0x1);
    CheckExternalEvents(cs7, 0xA640);
    // JZ 0x1000:a643 (1000_A63E / 0x1A63E)
    if(ZeroFlag) {
      goto label_1000_A643_1A643;
    }
    CheckExternalEvents(cs7, 0xA643);
    // ADD AX,0x2000 (1000_A640 / 0x1A640)
    // AX += 0x2000;
    AX = Alu16.Add(AX, 0x2000);
    label_1000_A643_1A643:
    CheckExternalEvents(cs7, 0xA645);
    // MOV DI,AX (1000_A643 / 0x1A643)
    DI = AX;
    CheckExternalEvents(cs7, 0xA649);
    // MOV CX,word ptr [0x236] (1000_A645 / 0x1A645)
    CX = UInt16[DS, 0x236];
    CheckExternalEvents(cs7, 0xA64D);
    // SUB CX,word ptr [0x234] (1000_A649 / 0x1A649)
    CX -= UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA64E);
    // INC CX (1000_A64D / 0x1A64D)
    CX = Alu16.Inc(CX);
    label_1000_A64E_1A64E:
    CheckExternalEvents(cs7, 0xA651);
    // MOV AL,byte ptr ES:[DI] (1000_A64E / 0x1A64E)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xA653);
    // AND AL,BL (1000_A651 / 0x1A651)
    // AL &= BL;
    AL = Alu8.And(AL, BL);
    CheckExternalEvents(cs7, 0xA657);
    // OR AX,word ptr [0x224] (1000_A653 / 0x1A653)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs7, 0xA65A);
    // MOV byte ptr ES:[DI],AL (1000_A657 / 0x1A657)
    UInt8[ES, (ushort)(DI)] = AL;
    CheckExternalEvents(cs7, 0xA65D);
    // XOR DL,0x1 (1000_A65A / 0x1A65A)
    // DL ^= 0x1;
    DL = Alu8.Xor(DL, 0x1);
    CheckExternalEvents(cs7, 0xA65F);
    // JZ 0x1000:a667 (1000_A65D / 0x1A65D)
    if(ZeroFlag) {
      goto label_1000_A667_1A667;
    }
    CheckExternalEvents(cs7, 0xA663);
    // ADD DI,0x2000 (1000_A65F / 0x1A65F)
    // DI += 0x2000;
    DI = Alu16.Add(DI, 0x2000);
    CheckExternalEvents(cs7, 0xA665);
    // LOOP 0x1000:a64e (1000_A663 / 0x1A663)
    if(--CX != 0) {
      goto label_1000_A64E_1A64E;
    }
    CheckExternalEvents(cs7, 0xA667);
    // JMP 0x1000:a5e7 (1000_A665 / 0x1A665)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A5E1_1A5E1, 0x1A5E7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_A667_1A667:
    CheckExternalEvents(cs7, 0xA66B);
    // SUB DI,0x1fb0 (1000_A667 / 0x1A667)
    // DI -= 0x1FB0;
    DI = Alu16.Sub(DI, 0x1FB0);
    CheckExternalEvents(cs7, 0xA66D);
    // LOOP 0x1000:a64e (1000_A66B / 0x1A66B)
    if(--CX != 0) {
      goto label_1000_A64E_1A64E;
    }
    CheckExternalEvents(cs7, 0xA670);
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
    CheckExternalEvents(cs12, 0x781);
    // PUSH BP (19EF_0780 / 0x1A670)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x783);
    // MOV BP,SP (19EF_0781 / 0x1A671)
    BP = SP;
    CheckExternalEvents(cs12, 0x784);
    // PUSH DI (19EF_0783 / 0x1A673)
    Stack.Push16(DI);
    CheckExternalEvents(cs12, 0x785);
    // PUSH SI (19EF_0784 / 0x1A674)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x786);
    // PUSH DS (19EF_0785 / 0x1A675)
    Stack.Push16(DS);
    CheckExternalEvents(cs12, 0x789);
    // MOV AX,0x1ddc (19EF_0786 / 0x1A676)
    AX = 0x1DDC;
    CheckExternalEvents(cs12, 0x78B);
    // MOV DS,AX (19EF_0789 / 0x1A679)
    DS = AX;
    CheckExternalEvents(cs12, 0x78C);
    // PUSH ES (19EF_078B / 0x1A67B)
    Stack.Push16(ES);
    CheckExternalEvents(cs12, 0x78F);
    // MOV AX,word ptr [BP + 0x6] (19EF_078C / 0x1A67C)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x792);
    // MOV [0x220],AX (19EF_078F / 0x1A67F)
    UInt16[DS, 0x220] = AX;
    CheckExternalEvents(cs12, 0x795);
    // MOV AX,word ptr [BP + 0x8] (19EF_0792 / 0x1A682)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x798);
    // MOV [0x234],AX (19EF_0795 / 0x1A685)
    UInt16[DS, 0x234] = AX;
    CheckExternalEvents(cs12, 0x79B);
    // MOV CX,word ptr [BP + 0xa] (19EF_0798 / 0x1A688)
    CX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x79F);
    // MOV word ptr [0x230],CX (19EF_079B / 0x1A68B)
    UInt16[DS, 0x230] = CX;
    CheckExternalEvents(cs12, 0x7A2);
    // MOV AX,word ptr [BP + 0xc] (19EF_079F / 0x1A68F)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs12, 0x7A5);
    // MOV [0x224],AX (19EF_07A2 / 0x1A692)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs12, 0x7AA);
    // CMP word ptr [0xb764],0x3 (19EF_07A5 / 0x1A695)
    Alu16.Sub(UInt16[DS, 0xB764], 0x3);
    CheckExternalEvents(cs12, 0x7AC);
    // JZ 0x1000:a6ad (19EF_07AA / 0x1A69A)
    if(ZeroFlag) {
      goto label_19EF_07BD_1A6AD;
    }
    CheckExternalEvents(cs12, 0x7B1);
    // CMP word ptr [0xb764],0x2 (19EF_07AC / 0x1A69C)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs12, 0x7B3);
    // JZ 0x1000:a6c8 (19EF_07B1 / 0x1A6A1)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A6C8_1A6C8, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs12, 0x7B8);
    // CMP word ptr [0xb764],0x1 (19EF_07B3 / 0x1A6A3)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs12, 0x7BA);
    // JZ 0x1000:a6fe (19EF_07B8 / 0x1A6A8)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A6FE_1A6FE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs12, 0x7BD);
    // JMP 0x1000:a744 (19EF_07BA / 0x1A6AA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_A744_1A744, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_07BD_1A6AD:
    CheckExternalEvents(cs12, 0x7C0);
    // MOV AX,0xa000 (19EF_07BD / 0x1A6AD)
    AX = 0xA000;
    CheckExternalEvents(cs12, 0x7C2);
    // MOV ES,AX (19EF_07C0 / 0x1A6B0)
    ES = AX;
    CheckExternalEvents(cs12, 0x7C5);
    // MOV AX,[0x234] (19EF_07C2 / 0x1A6B2)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs12, 0x7C8);
    // MOV DX,0x140 (19EF_07C5 / 0x1A6B5)
    DX = 0x140;
    CheckExternalEvents(cs12, 0x7CA);
    // MUL DX (19EF_07C8 / 0x1A6B8)
    uint resMul19EF_07C8 = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul19EF_07C8);
    DX = (ushort)(resMul19EF_07C8 >> 16);
    CheckExternalEvents(cs12, 0x7CE);
    // ADD AX,word ptr [0x220] (19EF_07CA / 0x1A6BA)
    // AX += UInt16[DS, 0x220];
    AX = Alu16.Add(AX, UInt16[DS, 0x220]);
    CheckExternalEvents(cs12, 0x7D0);
    // MOV DI,AX (19EF_07CE / 0x1A6BE)
    DI = AX;
    CheckExternalEvents(cs12, 0x7D3);
    // MOV AX,[0x224] (19EF_07D0 / 0x1A6C0)
    AX = UInt16[DS, 0x224];
    CheckExternalEvents(cs12, 0x7D5);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (19EF_07D3 / 0x1A6C3)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs12, 0x7D7);
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
    CheckExternalEvents(cs7, 0xA6CB);
    // MOV DX,0x3ce (1000_A6C8 / 0x1A6C8)
    DX = 0x3CE;
    CheckExternalEvents(cs7, 0xA6CE);
    // MOV AX,0x205 (1000_A6CB / 0x1A6CB)
    AX = 0x205;
    CheckExternalEvents(cs7, 0xA6CF);
    // OUT DX,AX (1000_A6CE / 0x1A6CE)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA6D2);
    // MOV AX,0xff08 (1000_A6CF / 0x1A6CF)
    AX = 0xFF08;
    CheckExternalEvents(cs7, 0xA6D3);
    // OUT DX,AX (1000_A6D2 / 0x1A6D2)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs7, 0xA6D6);
    // MOV DX,0x28 (1000_A6D3 / 0x1A6D3)
    DX = 0x28;
    CheckExternalEvents(cs7, 0xA6D9);
    // MOV AX,[0x234] (1000_A6D6 / 0x1A6D6)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA6DB);
    // MUL DL (1000_A6D9 / 0x1A6D9)
    ushort resMul1000_A6D9 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A6D9);
    AH = (byte)(resMul1000_A6D9 >> 8);
    CheckExternalEvents(cs7, 0xA6DF);
    // MOV BX,word ptr [0x220] (1000_A6DB / 0x1A6DB)
    BX = UInt16[DS, 0x220];
    CheckExternalEvents(cs7, 0xA6E1);
    // SHR BX,0x1 (1000_A6DF / 0x1A6DF)
    BX >>= 0x1;
    CheckExternalEvents(cs7, 0xA6E3);
    // SHR BX,0x1 (1000_A6E1 / 0x1A6E1)
    BX >>= 0x1;
    CheckExternalEvents(cs7, 0xA6E5);
    // SHR BX,0x1 (1000_A6E3 / 0x1A6E3)
    BX >>= 0x1;
    CheckExternalEvents(cs7, 0xA6E7);
    // ADD AX,BX (1000_A6E5 / 0x1A6E5)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs7, 0xA6E9);
    // MOV DI,AX (1000_A6E7 / 0x1A6E7)
    DI = AX;
    CheckExternalEvents(cs7, 0xA6EC);
    // MOV AX,0xa000 (1000_A6E9 / 0x1A6E9)
    AX = 0xA000;
    CheckExternalEvents(cs7, 0xA6EE);
    // MOV ES,AX (1000_A6EC / 0x1A6EC)
    ES = AX;
    CheckExternalEvents(cs7, 0xA6F2);
    // MOV CX,word ptr [0x230] (1000_A6EE / 0x1A6EE)
    CX = UInt16[DS, 0x230];
    CheckExternalEvents(cs7, 0xA6F5);
    // MOV AX,[0x224] (1000_A6F2 / 0x1A6F2)
    AX = UInt16[DS, 0x224];
    label_1000_A6F5_1A6F5:
    CheckExternalEvents(cs7, 0xA6F8);
    // MOV AH,byte ptr ES:[DI] (1000_A6F5 / 0x1A6F5)
    AH = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs7, 0xA6F9);
    // STOSB ES:DI (1000_A6F8 / 0x1A6F8)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs7, 0xA6FB);
    // LOOP 0x1000:a6f5 (1000_A6F9 / 0x1A6F9)
    if(--CX != 0) {
      goto label_1000_A6F5_1A6F5;
    }
    CheckExternalEvents(cs7, 0xA6FD);
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
      case 0x1A73E: goto label_19EF_084E_1A73E;break; // Target of external jump from 0x1A6C5
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_A6FE_1A6FE:
    CheckExternalEvents(cs7, 0xA701);
    // MOV CX,0x4 (1000_A6FE / 0x1A6FE)
    CX = 0x4;
    CheckExternalEvents(cs7, 0xA703);
    // SHL AL,CL (1000_A701 / 0x1A701)
    // AL <<= CL;
    AL = Alu8.Shl(AL, CL);
    CheckExternalEvents(cs7, 0xA707);
    // OR AX,word ptr [0x224] (1000_A703 / 0x1A703)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs7, 0xA709);
    // MOV AH,AL (1000_A707 / 0x1A707)
    AH = AL;
    CheckExternalEvents(cs7, 0xA70C);
    // MOV [0x224],AX (1000_A709 / 0x1A709)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs7, 0xA70F);
    // MOV AX,0xb800 (1000_A70C / 0x1A70C)
    AX = 0xB800;
    CheckExternalEvents(cs7, 0xA711);
    // MOV ES,AX (1000_A70F / 0x1A70F)
    ES = AX;
    CheckExternalEvents(cs7, 0xA714);
    // MOV AX,[0x234] (1000_A711 / 0x1A711)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA716);
    // AND AL,0xfc (1000_A714 / 0x1A714)
    // AL &= 0xFC;
    AL = Alu8.And(AL, 0xFC);
    CheckExternalEvents(cs7, 0xA719);
    // MOV DX,0x28 (1000_A716 / 0x1A716)
    DX = 0x28;
    CheckExternalEvents(cs7, 0xA71B);
    // MUL DL (1000_A719 / 0x1A719)
    ushort resMul1000_A719 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A719);
    AH = (byte)(resMul1000_A719 >> 8);
    CheckExternalEvents(cs7, 0xA71F);
    // MOV DX,word ptr [0x220] (1000_A71B / 0x1A71B)
    DX = UInt16[DS, 0x220];
    CheckExternalEvents(cs7, 0xA721);
    // SHR DX,0x1 (1000_A71F / 0x1A71F)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xA723);
    // ADD AX,DX (1000_A721 / 0x1A721)
    // AX += DX;
    AX = Alu16.Add(AX, DX);
    CheckExternalEvents(cs7, 0xA727);
    // MOV DX,word ptr [0x234] (1000_A723 / 0x1A723)
    DX = UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA72A);
    // AND DX,0x3 (1000_A727 / 0x1A727)
    // DX &= 0x3;
    DX = Alu16.And(DX, 0x3);
    CheckExternalEvents(cs7, 0xA72C);
    // JZ 0x1000:a733 (1000_A72A / 0x1A72A)
    if(ZeroFlag) {
      goto label_1000_A733_1A733;
    }
    CheckExternalEvents(cs7, 0xA72E);
    // MOV CX,DX (1000_A72C / 0x1A72C)
    CX = DX;
    label_1000_A72E_1A72E:
    CheckExternalEvents(cs7, 0xA731);
    // ADD AH,0x20 (1000_A72E / 0x1A72E)
    // AH += 0x20;
    AH = Alu8.Add(AH, 0x20);
    CheckExternalEvents(cs7, 0xA733);
    // LOOP 0x1000:a72e (1000_A731 / 0x1A731)
    if(--CX != 0) {
      goto label_1000_A72E_1A72E;
    }
    label_1000_A733_1A733:
    CheckExternalEvents(cs7, 0xA735);
    // MOV DI,AX (1000_A733 / 0x1A733)
    DI = AX;
    CheckExternalEvents(cs7, 0xA739);
    // MOV CX,word ptr [0x230] (1000_A735 / 0x1A735)
    CX = UInt16[DS, 0x230];
    CheckExternalEvents(cs7, 0xA73C);
    // MOV AX,[0x224] (1000_A739 / 0x1A739)
    AX = UInt16[DS, 0x224];
    CheckExternalEvents(cs7, 0xA73E);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_A73C / 0x1A73C)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    label_1000_A73E_1A73E:
    CheckExternalEvents(cs7, 0xA73F);
    // POP ES (1000_A73E / 0x1A73E)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA740);
    // POP DS (1000_A73F / 0x1A73F)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA741);
    // POP SI (1000_A740 / 0x1A740)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA742);
    // POP DI (1000_A741 / 0x1A741)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA743);
    // POP BP (1000_A742 / 0x1A742)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA744);
    // RETF  (1000_A743 / 0x1A743)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A744_1A744(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A744_1A744:
    CheckExternalEvents(cs7, 0xA747);
    // AND AX,0x3 (1000_A744 / 0x1A744)
    // AX &= 0x3;
    AX = Alu16.And(AX, 0x3);
    CheckExternalEvents(cs7, 0xA74A);
    // MOV [0x224],AX (1000_A747 / 0x1A747)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs7, 0xA74C);
    // SHL AL,0x1 (1000_A74A / 0x1A74A)
    AL <<= 0x1;
    CheckExternalEvents(cs7, 0xA74E);
    // SHL AL,0x1 (1000_A74C / 0x1A74C)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs7, 0xA752);
    // OR AX,word ptr [0x224] (1000_A74E / 0x1A74E)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs7, 0xA754);
    // MOV BL,AL (1000_A752 / 0x1A752)
    BL = AL;
    CheckExternalEvents(cs7, 0xA756);
    // MOV CL,0x4 (1000_A754 / 0x1A754)
    CL = 0x4;
    CheckExternalEvents(cs7, 0xA758);
    // SHL AL,CL (1000_A756 / 0x1A756)
    // AL <<= CL;
    AL = Alu8.Shl(AL, CL);
    CheckExternalEvents(cs7, 0xA75A);
    // OR AL,BL (1000_A758 / 0x1A758)
    // AL |= BL;
    AL = Alu8.Or(AL, BL);
    CheckExternalEvents(cs7, 0xA75C);
    // MOV AH,AL (1000_A75A / 0x1A75A)
    AH = AL;
    CheckExternalEvents(cs7, 0xA75F);
    // MOV [0x224],AX (1000_A75C / 0x1A75C)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs7, 0xA762);
    // MOV AX,0xb800 (1000_A75F / 0x1A75F)
    AX = 0xB800;
    CheckExternalEvents(cs7, 0xA764);
    // MOV ES,AX (1000_A762 / 0x1A762)
    ES = AX;
    CheckExternalEvents(cs7, 0xA767);
    // MOV AX,[0x234] (1000_A764 / 0x1A764)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA769);
    // AND AL,0xfe (1000_A767 / 0x1A767)
    // AL &= 0xFE;
    AL = Alu8.And(AL, 0xFE);
    CheckExternalEvents(cs7, 0xA76C);
    // MOV DX,0x28 (1000_A769 / 0x1A769)
    DX = 0x28;
    CheckExternalEvents(cs7, 0xA76E);
    // MUL DL (1000_A76C / 0x1A76C)
    ushort resMul1000_A76C = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A76C);
    AH = (byte)(resMul1000_A76C >> 8);
    CheckExternalEvents(cs7, 0xA772);
    // MOV DX,word ptr [0x220] (1000_A76E / 0x1A76E)
    DX = UInt16[DS, 0x220];
    CheckExternalEvents(cs7, 0xA774);
    // SHR DX,0x1 (1000_A772 / 0x1A772)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xA776);
    // SHR DX,0x1 (1000_A774 / 0x1A774)
    DX >>= 0x1;
    CheckExternalEvents(cs7, 0xA778);
    // ADD AX,DX (1000_A776 / 0x1A776)
    // AX += DX;
    AX = Alu16.Add(AX, DX);
    CheckExternalEvents(cs7, 0xA77C);
    // MOV DX,word ptr [0x234] (1000_A778 / 0x1A778)
    DX = UInt16[DS, 0x234];
    CheckExternalEvents(cs7, 0xA77F);
    // AND DX,0x1 (1000_A77C / 0x1A77C)
    // DX &= 0x1;
    DX = Alu16.And(DX, 0x1);
    CheckExternalEvents(cs7, 0xA781);
    // JZ 0x1000:a784 (1000_A77F / 0x1A77F)
    if(ZeroFlag) {
      goto label_1000_A784_1A784;
    }
    CheckExternalEvents(cs7, 0xA784);
    // ADD AH,0x20 (1000_A781 / 0x1A781)
    // AH += 0x20;
    AH = Alu8.Add(AH, 0x20);
    label_1000_A784_1A784:
    CheckExternalEvents(cs7, 0xA786);
    // MOV DI,AX (1000_A784 / 0x1A784)
    DI = AX;
    CheckExternalEvents(cs7, 0xA78A);
    // MOV CX,word ptr [0x230] (1000_A786 / 0x1A786)
    CX = UInt16[DS, 0x230];
    CheckExternalEvents(cs7, 0xA78D);
    // MOV AX,[0x224] (1000_A78A / 0x1A78A)
    AX = UInt16[DS, 0x224];
    CheckExternalEvents(cs7, 0xA78F);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_A78D / 0x1A78D)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs7, 0xA791);
    // JMP 0x1000:a73e (1000_A78F / 0x1A78F)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A6FE_1A6FE, 0x1A73E - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
