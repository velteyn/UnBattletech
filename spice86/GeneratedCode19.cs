namespace generated;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.InstructionsImpl;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action unknown_19EF_12BA_1B1AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_12BA_1B1AA:
    CheckExternalEvents(cs14, 0x12BC);
    // XOR BL,BL (19EF_12BA / 0x1B1AA)
    // BL ^= BL;
    BL = Alu8.Xor(BL, BL);
    CheckExternalEvents(cs14, 0x12BE);
    // MOV AL,byte ptr [SI] (19EF_12BC / 0x1B1AC)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x12C0);
    // OR AL,AL (19EF_12BE / 0x1B1AE)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x12C2);
    // JS 0x1000:b1c3 (19EF_12C0 / 0x1B1B0)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_12D3_1B1C3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x12C5);
    // CMP AL,byte ptr [SI + -0x39] (19EF_12C2 / 0x1B1B2)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI - 0x39)]);
    CheckExternalEvents(cs14, 0x12C7);
    // JNZ 0x1000:b1ba (19EF_12C5 / 0x1B1B5)
    if(!ZeroFlag) {
      goto label_19EF_12CA_1B1BA;
    }
    CheckExternalEvents(cs14, 0x12CA);
    // OR BL,0x8 (19EF_12C7 / 0x1B1B7)
    BL |= 0x8;
    label_19EF_12CA_1B1BA:
    CheckExternalEvents(cs14, 0x12CD);
    // CMP AL,byte ptr [SI + 0x1] (19EF_12CA / 0x1B1BA)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI + 0x1)]);
    CheckExternalEvents(cs14, 0x12CF);
    // JNZ 0x1000:b1c2 (19EF_12CD / 0x1B1BD)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      CheckExternalEvents(cs14, 0x12D3);
      // RET  (19EF_12D2 / 0x1B1C2)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x12D2);
    // OR BL,0x2 (19EF_12CF / 0x1B1BF)
    // BL |= 0x2;
    BL = Alu8.Or(BL, 0x2);
    label_19EF_12D2_1B1C2:
    CheckExternalEvents(cs14, 0x12D3);
    // RET  (19EF_12D2 / 0x1B1C2)
    return NearRet();
  }
  
  public virtual Action spice86_imported_label_jump_target_19EF_12D3_1B1C3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_12D3_1B1C3:
    CheckExternalEvents(cs14, 0x12D5);
    // MOV BL,AL (19EF_12D3 / 0x1B1C3)
    BL = AL;
    CheckExternalEvents(cs14, 0x12D8);
    // SUB BL,0x80 (19EF_12D5 / 0x1B1C5)
    // BL -= 0x80;
    BL = Alu8.Sub(BL, 0x80);
    CheckExternalEvents(cs14, 0x12D9);
    // RET  (19EF_12D8 / 0x1B1C8)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_12D9_1B1C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_12D9_1B1C9:
    CheckExternalEvents(cs14, 0x12DB);
    // XOR BL,BL (19EF_12D9 / 0x1B1C9)
    // BL ^= BL;
    BL = Alu8.Xor(BL, BL);
    CheckExternalEvents(cs14, 0x12DD);
    // MOV AL,byte ptr [SI] (19EF_12DB / 0x1B1CB)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x12DF);
    // OR AL,AL (19EF_12DD / 0x1B1CD)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x12E1);
    // JS 0x1000:b1c3 (19EF_12DF / 0x1B1CF)
    if(SignFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_12D3_1B1C3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x12E4);
    // CMP AL,byte ptr [SI + -0x1] (19EF_12E1 / 0x1B1D1)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI - 0x1)]);
    CheckExternalEvents(cs14, 0x12E6);
    // JNZ 0x1000:b1d9 (19EF_12E4 / 0x1B1D4)
    if(!ZeroFlag) {
      goto label_19EF_12E9_1B1D9;
    }
    CheckExternalEvents(cs14, 0x12E9);
    // OR BL,0x8 (19EF_12E6 / 0x1B1D6)
    BL |= 0x8;
    label_19EF_12E9_1B1D9:
    CheckExternalEvents(cs14, 0x12EC);
    // CMP AL,byte ptr [SI + 0x39] (19EF_12E9 / 0x1B1D9)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI + 0x39)]);
    CheckExternalEvents(cs14, 0x12EE);
    // JNZ 0x1000:b1e1 (19EF_12EC / 0x1B1DC)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      CheckExternalEvents(cs14, 0x12F2);
      // RET  (19EF_12F1 / 0x1B1E1)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x12F1);
    // OR BL,0x2 (19EF_12EE / 0x1B1DE)
    // BL |= 0x2;
    BL = Alu8.Or(BL, 0x2);
    label_19EF_12F1_1B1E1:
    CheckExternalEvents(cs14, 0x12F2);
    // RET  (19EF_12F1 / 0x1B1E1)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_12F2_1B1E2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_12F2_1B1E2:
    CheckExternalEvents(cs14, 0x12F6);
    // CMP AL,byte ptr [SI + 0xff78] (19EF_12F2 / 0x1B1E2)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI + 0xFF78)]);
    CheckExternalEvents(cs14, 0x12F8);
    // JNZ 0x1000:b1ea (19EF_12F6 / 0x1B1E6)
    if(!ZeroFlag) {
      goto label_19EF_12FA_1B1EA;
    }
    CheckExternalEvents(cs14, 0x12FA);
    // INC BL (19EF_12F8 / 0x1B1E8)
    BL++;
    label_19EF_12FA_1B1EA:
    CheckExternalEvents(cs14, 0x12FD);
    // CMP AL,byte ptr [SI + 0x8] (19EF_12FA / 0x1B1EA)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI + 0x8)]);
    CheckExternalEvents(cs14, 0x12FF);
    // JNZ 0x1000:b1f2 (19EF_12FD / 0x1B1ED)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      CheckExternalEvents(cs14, 0x1303);
      // RET  (19EF_1302 / 0x1B1F2)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x1302);
    // OR BL,0x4 (19EF_12FF / 0x1B1EF)
    // BL |= 0x4;
    BL = Alu8.Or(BL, 0x4);
    label_19EF_1302_1B1F2:
    CheckExternalEvents(cs14, 0x1303);
    // RET  (19EF_1302 / 0x1B1F2)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1303_1B1F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1303_1B1F3:
    CheckExternalEvents(cs14, 0x1306);
    // CMP AL,byte ptr [SI + -0x8] (19EF_1303 / 0x1B1F3)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI - 0x8)]);
    CheckExternalEvents(cs14, 0x1308);
    // JNZ 0x1000:b1fa (19EF_1306 / 0x1B1F6)
    if(!ZeroFlag) {
      goto label_19EF_130A_1B1FA;
    }
    CheckExternalEvents(cs14, 0x130A);
    // INC BL (19EF_1308 / 0x1B1F8)
    BL++;
    label_19EF_130A_1B1FA:
    CheckExternalEvents(cs14, 0x130E);
    // CMP AL,byte ptr [SI + 0x88] (19EF_130A / 0x1B1FA)
    Alu8.Sub(AL, UInt8[DS, (ushort)(SI + 0x88)]);
    CheckExternalEvents(cs14, 0x1310);
    // JNZ 0x1000:b203 (19EF_130E / 0x1B1FE)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      CheckExternalEvents(cs14, 0x1314);
      // RET  (19EF_1313 / 0x1B203)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x1313);
    // OR BL,0x4 (19EF_1310 / 0x1B200)
    // BL |= 0x4;
    BL = Alu8.Or(BL, 0x4);
    label_19EF_1313_1B203:
    CheckExternalEvents(cs14, 0x1314);
    // RET  (19EF_1313 / 0x1B203)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1314_1B204(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1314_1B204:
    CheckExternalEvents(cs14, 0x1315);
    // PUSH BP (19EF_1314 / 0x1B204)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x1317);
    // MOV BP,SP (19EF_1315 / 0x1B205)
    BP = SP;
    CheckExternalEvents(cs14, 0x1318);
    // PUSH DI (19EF_1317 / 0x1B207)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1319);
    // PUSH SI (19EF_1318 / 0x1B208)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x131A);
    // PUSH DS (19EF_1319 / 0x1B209)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x131D);
    // MOV AX,0x1ddc (19EF_131A / 0x1B20A)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x131F);
    // MOV DS,AX (19EF_131D / 0x1B20D)
    DS = AX;
    CheckExternalEvents(cs14, 0x1322);
    // MOV AX,word ptr [BP + 0x6] (19EF_131F / 0x1B20F)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x1325);
    // MOV [0x2cf],AX (19EF_1322 / 0x1B212)
    UInt16[DS, 0x2CF] = AX;
    CheckExternalEvents(cs14, 0x1328);
    // MOV BX,word ptr [BP + 0x8] (19EF_1325 / 0x1B215)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x132C);
    // MOV word ptr [0x2d1],BX (19EF_1328 / 0x1B218)
    UInt16[DS, 0x2D1] = BX;
    CheckExternalEvents(cs14, 0x132E);
    // SHR BL,0x1 (19EF_132C / 0x1B21C)
    BL >>= 0x1;
    CheckExternalEvents(cs14, 0x1330);
    // SHR BL,0x1 (19EF_132E / 0x1B21E)
    BL >>= 0x1;
    CheckExternalEvents(cs14, 0x1332);
    // SHR BL,0x1 (19EF_1330 / 0x1B220)
    BL >>= 0x1;
    CheckExternalEvents(cs14, 0x1334);
    // SHR BL,0x1 (19EF_1332 / 0x1B222)
    // BL >>= 0x1;
    BL = Alu8.Shr(BL, 0x1);
    CheckExternalEvents(cs14, 0x1338);
    // MOV byte ptr [0x2ce],BL (19EF_1334 / 0x1B224)
    UInt8[DS, 0x2CE] = BL;
    CheckExternalEvents(cs14, 0x133A);
    // SHR AL,0x1 (19EF_1338 / 0x1B228)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x133C);
    // SHR AL,0x1 (19EF_133A / 0x1B22A)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x133E);
    // SHR AL,0x1 (19EF_133C / 0x1B22C)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x1340);
    // SHR AL,0x1 (19EF_133E / 0x1B22E)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0x1343);
    // MOV [0x2cd],AL (19EF_1340 / 0x1B230)
    UInt8[DS, 0x2CD] = AL;
    CheckExternalEvents(cs14, 0x1346);
    // MOV DI,0x7ad (19EF_1343 / 0x1B233)
    DI = 0x7AD;
    CheckExternalEvents(cs14, 0x1348);
    // DEC AL (19EF_1346 / 0x1B236)
    AL--;
    CheckExternalEvents(cs14, 0x134A);
    // DEC BL (19EF_1348 / 0x1B238)
    BL = Alu8.Dec(BL);
    CheckExternalEvents(cs14, 0x134D);
    // CALL 0x1000:b2c9 (19EF_134A / 0x1B23A)
    NearCall(cs14, 0x134D, unknown_19EF_13D9_1B2C9);
    CheckExternalEvents(cs14, 0x1350);
    // MOV [0x7a4],AL (19EF_134D / 0x1B23D)
    UInt8[DS, 0x7A4] = AL;
    CheckExternalEvents(cs14, 0x1354);
    // MOV BL,byte ptr [0x2ce] (19EF_1350 / 0x1B240)
    BL = UInt8[DS, 0x2CE];
    CheckExternalEvents(cs14, 0x1357);
    // MOV AL,[0x2cd] (19EF_1354 / 0x1B244)
    AL = UInt8[DS, 0x2CD];
    CheckExternalEvents(cs14, 0x1359);
    // DEC BL (19EF_1357 / 0x1B247)
    BL = Alu8.Dec(BL);
    CheckExternalEvents(cs14, 0x135C);
    // CALL 0x1000:b2c9 (19EF_1359 / 0x1B249)
    NearCall(cs14, 0x135C, unknown_19EF_13D9_1B2C9);
    CheckExternalEvents(cs14, 0x135F);
    // MOV [0x7a5],AL (19EF_135C / 0x1B24C)
    UInt8[DS, 0x7A5] = AL;
    CheckExternalEvents(cs14, 0x1363);
    // MOV BL,byte ptr [0x2ce] (19EF_135F / 0x1B24F)
    BL = UInt8[DS, 0x2CE];
    CheckExternalEvents(cs14, 0x1365);
    // DEC BL (19EF_1363 / 0x1B253)
    BL = Alu8.Dec(BL);
    CheckExternalEvents(cs14, 0x1368);
    // MOV AL,[0x2cd] (19EF_1365 / 0x1B255)
    AL = UInt8[DS, 0x2CD];
    CheckExternalEvents(cs14, 0x136A);
    // INC AL (19EF_1368 / 0x1B258)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs14, 0x136D);
    // CALL 0x1000:b2c9 (19EF_136A / 0x1B25A)
    NearCall(cs14, 0x136D, unknown_19EF_13D9_1B2C9);
    CheckExternalEvents(cs14, 0x1371);
    // ADD DI,0xa8 (19EF_136D / 0x1B25D)
    // DI += 0xA8;
    DI = Alu16.Add(DI, 0xA8);
    CheckExternalEvents(cs14, 0x1374);
    // MOV [0x7a6],AL (19EF_1371 / 0x1B261)
    UInt8[DS, 0x7A6] = AL;
    CheckExternalEvents(cs14, 0x1378);
    // MOV BL,byte ptr [0x2ce] (19EF_1374 / 0x1B264)
    BL = UInt8[DS, 0x2CE];
    CheckExternalEvents(cs14, 0x137B);
    // MOV AL,[0x2cd] (19EF_1378 / 0x1B268)
    AL = UInt8[DS, 0x2CD];
    CheckExternalEvents(cs14, 0x137D);
    // DEC AL (19EF_137B / 0x1B26B)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs14, 0x1380);
    // CALL 0x1000:b2c9 (19EF_137D / 0x1B26D)
    NearCall(cs14, 0x1380, unknown_19EF_13D9_1B2C9);
    CheckExternalEvents(cs14, 0x1383);
    // MOV [0x7a7],AL (19EF_1380 / 0x1B270)
    UInt8[DS, 0x7A7] = AL;
    CheckExternalEvents(cs14, 0x1387);
    // MOV BL,byte ptr [0x2ce] (19EF_1383 / 0x1B273)
    BL = UInt8[DS, 0x2CE];
    CheckExternalEvents(cs14, 0x138A);
    // MOV AL,[0x2cd] (19EF_1387 / 0x1B277)
    AL = UInt8[DS, 0x2CD];
    CheckExternalEvents(cs14, 0x138D);
    // CALL 0x1000:b2c9 (19EF_138A / 0x1B27A)
    NearCall(cs14, 0x138D, unknown_19EF_13D9_1B2C9);
    CheckExternalEvents(cs14, 0x1390);
    // MOV [0x7a8],AL (19EF_138D / 0x1B27D)
    UInt8[DS, 0x7A8] = AL;
    CheckExternalEvents(cs14, 0x1394);
    // MOV BL,byte ptr [0x2ce] (19EF_1390 / 0x1B280)
    BL = UInt8[DS, 0x2CE];
    CheckExternalEvents(cs14, 0x1397);
    // MOV AL,[0x2cd] (19EF_1394 / 0x1B284)
    AL = UInt8[DS, 0x2CD];
    CheckExternalEvents(cs14, 0x1399);
    // INC AL (19EF_1397 / 0x1B287)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs14, 0x139C);
    // CALL 0x1000:b2c9 (19EF_1399 / 0x1B289)
    NearCall(cs14, 0x139C, unknown_19EF_13D9_1B2C9);
    CheckExternalEvents(cs14, 0x13A0);
    // ADD DI,0xa8 (19EF_139C / 0x1B28C)
    // DI += 0xA8;
    DI = Alu16.Add(DI, 0xA8);
    CheckExternalEvents(cs14, 0x13A3);
    // MOV [0x7a9],AL (19EF_13A0 / 0x1B290)
    UInt8[DS, 0x7A9] = AL;
    CheckExternalEvents(cs14, 0x13A7);
    // MOV BL,byte ptr [0x2ce] (19EF_13A3 / 0x1B293)
    BL = UInt8[DS, 0x2CE];
    CheckExternalEvents(cs14, 0x13A9);
    // INC BL (19EF_13A7 / 0x1B297)
    BL = Alu8.Inc(BL);
    CheckExternalEvents(cs14, 0x13AC);
    // MOV AL,[0x2cd] (19EF_13A9 / 0x1B299)
    AL = UInt8[DS, 0x2CD];
    CheckExternalEvents(cs14, 0x13AE);
    // DEC AL (19EF_13AC / 0x1B29C)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs14, 0x13B1);
    // CALL 0x1000:b2c9 (19EF_13AE / 0x1B29E)
    NearCall(cs14, 0x13B1, unknown_19EF_13D9_1B2C9);
    CheckExternalEvents(cs14, 0x13B4);
    // MOV [0x7aa],AL (19EF_13B1 / 0x1B2A1)
    UInt8[DS, 0x7AA] = AL;
    CheckExternalEvents(cs14, 0x13B8);
    // MOV BL,byte ptr [0x2ce] (19EF_13B4 / 0x1B2A4)
    BL = UInt8[DS, 0x2CE];
    CheckExternalEvents(cs14, 0x13BA);
    // INC BL (19EF_13B8 / 0x1B2A8)
    BL = Alu8.Inc(BL);
    CheckExternalEvents(cs14, 0x13BD);
    // MOV AL,[0x2cd] (19EF_13BA / 0x1B2AA)
    AL = UInt8[DS, 0x2CD];
    CheckExternalEvents(cs14, 0x13C0);
    // CALL 0x1000:b2c9 (19EF_13BD / 0x1B2AD)
    NearCall(cs14, 0x13C0, unknown_19EF_13D9_1B2C9);
    CheckExternalEvents(cs14, 0x13C3);
    // MOV [0x7ab],AL (19EF_13C0 / 0x1B2B0)
    UInt8[DS, 0x7AB] = AL;
    CheckExternalEvents(cs14, 0x13C7);
    // MOV BL,byte ptr [0x2ce] (19EF_13C3 / 0x1B2B3)
    BL = UInt8[DS, 0x2CE];
    CheckExternalEvents(cs14, 0x13C9);
    // INC BL (19EF_13C7 / 0x1B2B7)
    BL = Alu8.Inc(BL);
    CheckExternalEvents(cs14, 0x13CC);
    // MOV AL,[0x2cd] (19EF_13C9 / 0x1B2B9)
    AL = UInt8[DS, 0x2CD];
    CheckExternalEvents(cs14, 0x13CE);
    // INC AL (19EF_13CC / 0x1B2BC)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs14, 0x13D1);
    // CALL 0x1000:b2c9 (19EF_13CE / 0x1B2BE)
    NearCall(cs14, 0x13D1, unknown_19EF_13D9_1B2C9);
    CheckExternalEvents(cs14, 0x13D4);
    // MOV [0x7ac],AL (19EF_13D1 / 0x1B2C1)
    UInt8[DS, 0x7AC] = AL;
    CheckExternalEvents(cs14, 0x13D5);
    // POP DS (19EF_13D4 / 0x1B2C4)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x13D6);
    // POP SI (19EF_13D5 / 0x1B2C5)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x13D7);
    // POP DI (19EF_13D6 / 0x1B2C6)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x13D8);
    // POP BP (19EF_13D7 / 0x1B2C7)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x13D9);
    // RETF  (19EF_13D8 / 0x1B2C8)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_13D9_1B2C9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_13D9_1B2C9:
    CheckExternalEvents(cs14, 0x13DC);
    // MOV SI,0x424 (19EF_13D9 / 0x1B2C9)
    SI = 0x424;
    CheckExternalEvents(cs14, 0x13DE);
    // MOV CL,BL (19EF_13DC / 0x1B2CC)
    CL = BL;
    CheckExternalEvents(cs14, 0x13E0);
    // MOV CH,AL (19EF_13DE / 0x1B2CE)
    CH = AL;
    CheckExternalEvents(cs14, 0x13E2);
    // ADD CL,CH (19EF_13E0 / 0x1B2D0)
    // CL += CH;
    CL = Alu8.Add(CL, CH);
    CheckExternalEvents(cs14, 0x13E4);
    // MOV CH,CL (19EF_13E2 / 0x1B2D2)
    CH = CL;
    CheckExternalEvents(cs14, 0x13E7);
    // AND CL,0x3 (19EF_13E4 / 0x1B2D4)
    // CL &= 0x3;
    CL = Alu8.And(CL, 0x3);
    CheckExternalEvents(cs14, 0x13EB);
    // MOV byte ptr [0x273],CL (19EF_13E7 / 0x1B2D7)
    UInt8[DS, 0x273] = CL;
    CheckExternalEvents(cs14, 0x13ED);
    // SHL CH,0x1 (19EF_13EB / 0x1B2DB)
    CH <<= 0x1;
    CheckExternalEvents(cs14, 0x13EF);
    // SHL CH,0x1 (19EF_13ED / 0x1B2DD)
    CH <<= 0x1;
    CheckExternalEvents(cs14, 0x13F2);
    // AND CH,0x10 (19EF_13EF / 0x1B2DF)
    // CH &= 0x10;
    CH = Alu8.And(CH, 0x10);
    CheckExternalEvents(cs14, 0x13F6);
    // MOV byte ptr [0x272],CH (19EF_13F2 / 0x1B2E2)
    UInt8[DS, 0x272] = CH;
    CheckExternalEvents(cs14, 0x13F8);
    // XOR DH,DH (19EF_13F6 / 0x1B2E6)
    // DH ^= DH;
    DH = Alu8.Xor(DH, DH);
    CheckExternalEvents(cs14, 0x13FA);
    // MOV DL,BL (19EF_13F8 / 0x1B2E8)
    DL = BL;
    CheckExternalEvents(cs14, 0x13FC);
    // SHL DL,0x1 (19EF_13FA / 0x1B2EA)
    DL <<= 0x1;
    CheckExternalEvents(cs14, 0x13FE);
    // SHL DL,0x1 (19EF_13FC / 0x1B2EC)
    DL <<= 0x1;
    CheckExternalEvents(cs14, 0x1400);
    // SHL DL,0x1 (19EF_13FE / 0x1B2EE)
    DL <<= 0x1;
    CheckExternalEvents(cs14, 0x1402);
    // ADD SI,DX (19EF_1400 / 0x1B2F0)
    SI += DX;
    CheckExternalEvents(cs14, 0x1405);
    // CMP BL,0xff (19EF_1402 / 0x1B2F2)
    Alu8.Sub(BL, 0xFF);
    CheckExternalEvents(cs14, 0x1407);
    // JNZ 0x1000:b2fd (19EF_1405 / 0x1B2F5)
    if(!ZeroFlag) {
      goto label_19EF_140D_1B2FD;
    }
    CheckExternalEvents(cs14, 0x140A);
    // MOV SI,0x364 (19EF_1407 / 0x1B2F7)
    SI = 0x364;
    CheckExternalEvents(cs14, 0x140D);
    // ADD SI,0x38 (19EF_140A / 0x1B2FA)
    SI += 0x38;
    label_19EF_140D_1B2FD:
    CheckExternalEvents(cs14, 0x1410);
    // CMP BL,0x8 (19EF_140D / 0x1B2FD)
    Alu8.Sub(BL, 0x8);
    CheckExternalEvents(cs14, 0x1412);
    // JNZ 0x1000:b305 (19EF_1410 / 0x1B300)
    if(!ZeroFlag) {
      goto label_19EF_1415_1B305;
    }
    CheckExternalEvents(cs14, 0x1415);
    // MOV SI,0x4e4 (19EF_1412 / 0x1B302)
    SI = 0x4E4;
    label_19EF_1415_1B305:
    CheckExternalEvents(cs14, 0x1417);
    // MOV DL,AL (19EF_1415 / 0x1B305)
    DL = AL;
    CheckExternalEvents(cs14, 0x1419);
    // CMP AL,0xff (19EF_1417 / 0x1B307)
    Alu8.Sub(AL, 0xFF);
    CheckExternalEvents(cs14, 0x141B);
    // JNZ 0x1000:b310 (19EF_1419 / 0x1B309)
    if(!ZeroFlag) {
      goto label_19EF_1420_1B310;
    }
    CheckExternalEvents(cs14, 0x141D);
    // MOV DL,0x7 (19EF_141B / 0x1B30B)
    DL = 0x7;
    CheckExternalEvents(cs14, 0x1420);
    // SUB SI,0x40 (19EF_141D / 0x1B30D)
    SI -= 0x40;
    label_19EF_1420_1B310:
    CheckExternalEvents(cs14, 0x1422);
    // CMP AL,0x8 (19EF_1420 / 0x1B310)
    Alu8.Sub(AL, 0x8);
    CheckExternalEvents(cs14, 0x1424);
    // JNZ 0x1000:b319 (19EF_1422 / 0x1B312)
    if(!ZeroFlag) {
      goto label_19EF_1429_1B319;
    }
    CheckExternalEvents(cs14, 0x1426);
    // XOR DL,DL (19EF_1424 / 0x1B314)
    DL = 0;
    CheckExternalEvents(cs14, 0x1429);
    // ADD SI,0x40 (19EF_1426 / 0x1B316)
    SI += 0x40;
    label_19EF_1429_1B319:
    CheckExternalEvents(cs14, 0x142B);
    // ADD SI,DX (19EF_1429 / 0x1B319)
    SI += DX;
    CheckExternalEvents(cs14, 0x142D);
    // XOR DL,DL (19EF_142B / 0x1B31B)
    // DL ^= DL;
    DL = Alu8.Xor(DL, DL);
    CheckExternalEvents(cs14, 0x142F);
    // MOV CH,byte ptr [SI] (19EF_142D / 0x1B31D)
    CH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x1433);
    // MOV byte ptr [0x2c9],CH (19EF_142F / 0x1B31F)
    UInt8[DS, 0x2C9] = CH;
    CheckExternalEvents(cs14, 0x1435);
    // MOV DH,CH (19EF_1433 / 0x1B323)
    DH = CH;
    CheckExternalEvents(cs14, 0x1437);
    // SHR DX,0x1 (19EF_1435 / 0x1B325)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1439);
    // SHR DX,0x1 (19EF_1437 / 0x1B327)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x143D);
    // SUB SI,0x324 (19EF_1439 / 0x1B329)
    SI -= 0x324;
    CheckExternalEvents(cs14, 0x1441);
    // ADD SI,0x564 (19EF_143D / 0x1B32D)
    // SI += 0x564;
    SI = Alu16.Add(SI, 0x564);
    CheckExternalEvents(cs14, 0x1443);
    // MOV BL,byte ptr [SI] (19EF_1441 / 0x1B331)
    BL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x1447);
    // MOV byte ptr [0x2ca],BL (19EF_1443 / 0x1B333)
    UInt8[DS, 0x2CA] = BL;
    CheckExternalEvents(cs14, 0x144A);
    // MOV SI,0xc1d (19EF_1447 / 0x1B337)
    SI = 0xC1D;
    CheckExternalEvents(cs14, 0x144C);
    // OR BL,BL (19EF_144A / 0x1B33A)
    // BL |= BL;
    BL = Alu8.Or(BL, BL);
    CheckExternalEvents(cs14, 0x144E);
    // JS 0x1000:b356 (19EF_144C / 0x1B33C)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs14, 0x1469);
      // JMP 0x1000:b42a (19EF_1466 / 0x1B356)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_B3E0_1B3E0, 0x1B42A - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x1450);
    // JZ 0x1000:b34f (19EF_144E / 0x1B33E)
    if(ZeroFlag) {
      goto label_19EF_145F_1B34F;
    }
    CheckExternalEvents(cs14, 0x1453);
    // CMP BL,0x10 (19EF_1450 / 0x1B340)
    Alu8.Sub(BL, 0x10);
    CheckExternalEvents(cs14, 0x1455);
    // JZ 0x1000:b359 (19EF_1453 / 0x1B343)
    if(ZeroFlag) {
      goto label_19EF_1469_1B359;
    }
    CheckExternalEvents(cs14, 0x1458);
    // SUB BL,0x10 (19EF_1455 / 0x1B345)
    BL -= 0x10;
    CheckExternalEvents(cs14, 0x145B);
    // CMP BL,0x31 (19EF_1458 / 0x1B348)
    Alu8.Sub(BL, 0x31);
    CheckExternalEvents(cs14, 0x145D);
    // JC 0x1000:b34f (19EF_145B / 0x1B34B)
    if(CarryFlag) {
      goto label_19EF_145F_1B34F;
    }
    CheckExternalEvents(cs14, 0x145F);
    // MOV BL,0x30 (19EF_145D / 0x1B34D)
    BL = 0x30;
    label_19EF_145F_1B34F:
    CheckExternalEvents(cs14, 0x1464);
    // CMP byte ptr [0x273],0x0 (19EF_145F / 0x1B34F)
    Alu8.Sub(UInt8[DS, 0x273], 0x0);
    CheckExternalEvents(cs14, 0x1466);
    // JNZ 0x1000:b35e (19EF_1464 / 0x1B354)
    if(!ZeroFlag) {
      goto label_19EF_146E_1B35E;
    }
    label_19EF_1466_1B356:
    CheckExternalEvents(cs14, 0x1469);
    // JMP 0x1000:b42a (19EF_1466 / 0x1B356)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_B3E0_1B3E0, 0x1B42A - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_1469_1B359:
    CheckExternalEvents(cs14, 0x146B);
    // MOV BL,0x70 (19EF_1469 / 0x1B359)
    BL = 0x70;
    CheckExternalEvents(cs14, 0x146E);
    // JMP 0x1000:b42a (19EF_146B / 0x1B35B)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_B3E0_1B3E0, 0x1B42A - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_146E_1B35E:
    CheckExternalEvents(cs14, 0x1473);
    // CMP byte ptr [0x273],0x2 (19EF_146E / 0x1B35E)
    Alu8.Sub(UInt8[DS, 0x273], 0x2);
    CheckExternalEvents(cs14, 0x1475);
    // JNZ 0x1000:b39f (19EF_1473 / 0x1B363)
    if(!ZeroFlag) {
      goto label_19EF_14AF_1B39F;
    }
    CheckExternalEvents(cs14, 0x1476);
    // PUSH DI (19EF_1475 / 0x1B365)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1477);
    // PUSH BX (19EF_1476 / 0x1B366)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x147A);
    // MOV DI,0x20dd (19EF_1477 / 0x1B367)
    DI = 0x20DD;
    CheckExternalEvents(cs14, 0x147D);
    // ADD DI,0x7 (19EF_147A / 0x1B36A)
    DI += 0x7;
    CheckExternalEvents(cs14, 0x147F);
    // XOR BH,BH (19EF_147D / 0x1B36D)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    CheckExternalEvents(cs14, 0x1481);
    // MOV BL,CH (19EF_147F / 0x1B36F)
    BL = CH;
    CheckExternalEvents(cs14, 0x1485);
    // MOV CH,byte ptr [BX + 0x211d] (19EF_1481 / 0x1B371)
    CH = UInt8[DS, (ushort)(BX + 0x211D)];
    CheckExternalEvents(cs14, 0x1487);
    // XOR CL,CL (19EF_1485 / 0x1B375)
    CL = 0;
    CheckExternalEvents(cs14, 0x1489);
    // SHR CX,0x1 (19EF_1487 / 0x1B377)
    CX >>= 0x1;
    CheckExternalEvents(cs14, 0x148B);
    // SHR CX,0x1 (19EF_1489 / 0x1B379)
    CX >>= 0x1;
    CheckExternalEvents(cs14, 0x148D);
    // ADD SI,CX (19EF_148B / 0x1B37B)
    // SI += CX;
    SI = Alu16.Add(SI, CX);
    CheckExternalEvents(cs14, 0x148F);
    // MOV AL,0x8 (19EF_148D / 0x1B37D)
    AL = 0x8;
    label_19EF_148F_1B37F:
    CheckExternalEvents(cs14, 0x1492);
    // MOV CX,0x8 (19EF_148F / 0x1B37F)
    CX = 0x8;
    CheckExternalEvents(cs14, 0x1494);
    // XOR BH,BH (19EF_1492 / 0x1B382)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    label_19EF_1494_1B384:
    CheckExternalEvents(cs14, 0x1496);
    // MOV BL,byte ptr [SI] (19EF_1494 / 0x1B384)
    BL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x1499);
    // CMP BL,0x40 (19EF_1496 / 0x1B386)
    Alu8.Sub(BL, 0x40);
    CheckExternalEvents(cs14, 0x149B);
    // JNC 0x1000:b38f (19EF_1499 / 0x1B389)
    if(!CarryFlag) {
      goto label_19EF_149F_1B38F;
    }
    CheckExternalEvents(cs14, 0x149F);
    // MOV BL,byte ptr [BX + 0x211d] (19EF_149B / 0x1B38B)
    BL = UInt8[DS, (ushort)(BX + 0x211D)];
    label_19EF_149F_1B38F:
    CheckExternalEvents(cs14, 0x14A1);
    // MOV byte ptr [DI],BL (19EF_149F / 0x1B38F)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs14, 0x14A2);
    // INC SI (19EF_14A1 / 0x1B391)
    SI++;
    CheckExternalEvents(cs14, 0x14A3);
    // DEC DI (19EF_14A2 / 0x1B392)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs14, 0x14A5);
    // LOOP 0x1000:b384 (19EF_14A3 / 0x1B393)
    if(--CX != 0) {
      goto label_19EF_1494_1B384;
    }
    CheckExternalEvents(cs14, 0x14A8);
    // ADD DI,0x10 (19EF_14A5 / 0x1B395)
    DI += 0x10;
    CheckExternalEvents(cs14, 0x14AA);
    // DEC AL (19EF_14A8 / 0x1B398)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs14, 0x14AC);
    // JNZ 0x1000:b37f (19EF_14AA / 0x1B39A)
    if(!ZeroFlag) {
      goto label_19EF_148F_1B37F;
    }
    CheckExternalEvents(cs14, 0x14AF);
    // JMP 0x1000:b423 (19EF_14AC / 0x1B39C)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_B3E0_1B3E0, 0x1B423 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_14AF_1B39F:
    CheckExternalEvents(cs14, 0x14B4);
    // CMP byte ptr [0x273],0x1 (19EF_14AF / 0x1B39F)
    Alu8.Sub(UInt8[DS, 0x273], 0x1);
    CheckExternalEvents(cs14, 0x14B6);
    // JNZ 0x1000:b3e0 (19EF_14B4 / 0x1B3A4)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_B3E0_1B3E0, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x14B7);
    // PUSH DI (19EF_14B6 / 0x1B3A6)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x14B8);
    // PUSH BX (19EF_14B7 / 0x1B3A7)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x14BB);
    // MOV DI,0x20dd (19EF_14B8 / 0x1B3A8)
    DI = 0x20DD;
    CheckExternalEvents(cs14, 0x14BE);
    // ADD DI,0x38 (19EF_14BB / 0x1B3AB)
    DI += 0x38;
    CheckExternalEvents(cs14, 0x14C0);
    // XOR BH,BH (19EF_14BE / 0x1B3AE)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    CheckExternalEvents(cs14, 0x14C2);
    // MOV BL,CH (19EF_14C0 / 0x1B3B0)
    BL = CH;
    CheckExternalEvents(cs14, 0x14C6);
    // MOV CH,byte ptr [BX + 0x213d] (19EF_14C2 / 0x1B3B2)
    CH = UInt8[DS, (ushort)(BX + 0x213D)];
    CheckExternalEvents(cs14, 0x14C8);
    // XOR CL,CL (19EF_14C6 / 0x1B3B6)
    CL = 0;
    CheckExternalEvents(cs14, 0x14CA);
    // SHR CX,0x1 (19EF_14C8 / 0x1B3B8)
    CX >>= 0x1;
    CheckExternalEvents(cs14, 0x14CC);
    // SHR CX,0x1 (19EF_14CA / 0x1B3BA)
    CX >>= 0x1;
    CheckExternalEvents(cs14, 0x14CE);
    // ADD SI,CX (19EF_14CC / 0x1B3BC)
    // SI += CX;
    SI = Alu16.Add(SI, CX);
    CheckExternalEvents(cs14, 0x14D0);
    // MOV AL,0x8 (19EF_14CE / 0x1B3BE)
    AL = 0x8;
    label_19EF_14D0_1B3C0:
    CheckExternalEvents(cs14, 0x14D3);
    // MOV CX,0x8 (19EF_14D0 / 0x1B3C0)
    CX = 0x8;
    CheckExternalEvents(cs14, 0x14D5);
    // XOR BH,BH (19EF_14D3 / 0x1B3C3)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    label_19EF_14D5_1B3C5:
    CheckExternalEvents(cs14, 0x14D7);
    // MOV BL,byte ptr [SI] (19EF_14D5 / 0x1B3C5)
    BL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x14DA);
    // CMP BL,0x40 (19EF_14D7 / 0x1B3C7)
    Alu8.Sub(BL, 0x40);
    CheckExternalEvents(cs14, 0x14DC);
    // JNC 0x1000:b3d0 (19EF_14DA / 0x1B3CA)
    if(!CarryFlag) {
      goto label_19EF_14E0_1B3D0;
    }
    CheckExternalEvents(cs14, 0x14E0);
    // MOV BL,byte ptr [BX + 0x213d] (19EF_14DC / 0x1B3CC)
    BL = UInt8[DS, (ushort)(BX + 0x213D)];
    label_19EF_14E0_1B3D0:
    CheckExternalEvents(cs14, 0x14E2);
    // MOV byte ptr [DI],BL (19EF_14E0 / 0x1B3D0)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs14, 0x14E3);
    // INC SI (19EF_14E2 / 0x1B3D2)
    SI++;
    CheckExternalEvents(cs14, 0x14E4);
    // INC DI (19EF_14E3 / 0x1B3D3)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs14, 0x14E6);
    // LOOP 0x1000:b3c5 (19EF_14E4 / 0x1B3D4)
    if(--CX != 0) {
      goto label_19EF_14D5_1B3C5;
    }
    CheckExternalEvents(cs14, 0x14E9);
    // SUB DI,0x10 (19EF_14E6 / 0x1B3D6)
    DI -= 0x10;
    CheckExternalEvents(cs14, 0x14EB);
    // DEC AL (19EF_14E9 / 0x1B3D9)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs14, 0x14ED);
    // JNZ 0x1000:b3c0 (19EF_14EB / 0x1B3DB)
    if(!ZeroFlag) {
      goto label_19EF_14D0_1B3C0;
    }
    CheckExternalEvents(cs14, 0x14EF);
    // JMP 0x1000:b423 (19EF_14ED / 0x1B3DD)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_B3E0_1B3E0, 0x1B423 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_B3E0_1B3E0(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1B423: goto label_1000_B423_1B423;break; // Target of external jump from 0x1B3DD, 0x1B39C
      case 0x1B42A: goto label_1000_B42A_1B42A;break; // Target of external jump from 0x1B356
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_B3E0_1B3E0:
    CheckExternalEvents(cs8, 0xB3E5);
    // CMP byte ptr [0x273],0x3 (1000_B3E0 / 0x1B3E0)
    Alu8.Sub(UInt8[DS, 0x273], 0x3);
    CheckExternalEvents(cs8, 0xB3E7);
    // JNZ 0x1000:b42a (1000_B3E5 / 0x1B3E5)
    if(!ZeroFlag) {
      goto label_1000_B42A_1B42A;
    }
    CheckExternalEvents(cs8, 0xB3E8);
    // PUSH DI (1000_B3E7 / 0x1B3E7)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xB3E9);
    // PUSH BX (1000_B3E8 / 0x1B3E8)
    Stack.Push16(BX);
    CheckExternalEvents(cs8, 0xB3EC);
    // MOV DI,0x20dd (1000_B3E9 / 0x1B3E9)
    DI = 0x20DD;
    CheckExternalEvents(cs8, 0xB3EF);
    // ADD DI,0x3f (1000_B3EC / 0x1B3EC)
    DI += 0x3F;
    CheckExternalEvents(cs8, 0xB3F1);
    // XOR BH,BH (1000_B3EF / 0x1B3EF)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    CheckExternalEvents(cs8, 0xB3F3);
    // MOV BL,CH (1000_B3F1 / 0x1B3F1)
    BL = CH;
    CheckExternalEvents(cs8, 0xB3F7);
    // MOV BL,byte ptr [BX + 0x213d] (1000_B3F3 / 0x1B3F3)
    BL = UInt8[DS, (ushort)(BX + 0x213D)];
    CheckExternalEvents(cs8, 0xB3FB);
    // MOV CH,byte ptr [BX + 0x211d] (1000_B3F7 / 0x1B3F7)
    CH = UInt8[DS, (ushort)(BX + 0x211D)];
    CheckExternalEvents(cs8, 0xB3FD);
    // XOR CL,CL (1000_B3FB / 0x1B3FB)
    CL = 0;
    CheckExternalEvents(cs8, 0xB3FF);
    // SHR CX,0x1 (1000_B3FD / 0x1B3FD)
    CX >>= 0x1;
    CheckExternalEvents(cs8, 0xB401);
    // SHR CX,0x1 (1000_B3FF / 0x1B3FF)
    CX >>= 0x1;
    CheckExternalEvents(cs8, 0xB403);
    // ADD SI,CX (1000_B401 / 0x1B401)
    // SI += CX;
    SI = Alu16.Add(SI, CX);
    CheckExternalEvents(cs8, 0xB405);
    // MOV AL,0x8 (1000_B403 / 0x1B403)
    AL = 0x8;
    label_1000_B405_1B405:
    CheckExternalEvents(cs8, 0xB408);
    // MOV CX,0x8 (1000_B405 / 0x1B405)
    CX = 0x8;
    CheckExternalEvents(cs8, 0xB40A);
    // XOR BH,BH (1000_B408 / 0x1B408)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    label_1000_B40A_1B40A:
    CheckExternalEvents(cs8, 0xB40C);
    // MOV BL,byte ptr [SI] (1000_B40A / 0x1B40A)
    BL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xB40F);
    // CMP BL,0x40 (1000_B40C / 0x1B40C)
    Alu8.Sub(BL, 0x40);
    CheckExternalEvents(cs8, 0xB411);
    // JNC 0x1000:b419 (1000_B40F / 0x1B40F)
    if(!CarryFlag) {
      goto label_1000_B419_1B419;
    }
    CheckExternalEvents(cs8, 0xB415);
    // MOV BL,byte ptr [BX + 0x213d] (1000_B411 / 0x1B411)
    BL = UInt8[DS, (ushort)(BX + 0x213D)];
    CheckExternalEvents(cs8, 0xB419);
    // MOV BL,byte ptr [BX + 0x211d] (1000_B415 / 0x1B415)
    BL = UInt8[DS, (ushort)(BX + 0x211D)];
    label_1000_B419_1B419:
    CheckExternalEvents(cs8, 0xB41B);
    // MOV byte ptr [DI],BL (1000_B419 / 0x1B419)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs8, 0xB41C);
    // INC SI (1000_B41B / 0x1B41B)
    SI++;
    CheckExternalEvents(cs8, 0xB41D);
    // DEC DI (1000_B41C / 0x1B41C)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs8, 0xB41F);
    // LOOP 0x1000:b40a (1000_B41D / 0x1B41D)
    if(--CX != 0) {
      goto label_1000_B40A_1B40A;
    }
    CheckExternalEvents(cs8, 0xB421);
    // DEC AL (1000_B41F / 0x1B41F)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs8, 0xB423);
    // JNZ 0x1000:b405 (1000_B421 / 0x1B421)
    if(!ZeroFlag) {
      goto label_1000_B405_1B405;
    }
    label_1000_B423_1B423:
    CheckExternalEvents(cs8, 0xB426);
    // MOV SI,0x20dd (1000_B423 / 0x1B423)
    SI = 0x20DD;
    CheckExternalEvents(cs8, 0xB427);
    // POP BX (1000_B426 / 0x1B426)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xB428);
    // POP DI (1000_B427 / 0x1B427)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xB42A);
    // XOR DX,DX (1000_B428 / 0x1B428)
    DX = 0;
    label_1000_B42A_1B42A:
    CheckExternalEvents(cs8, 0xB42C);
    // ADD SI,DX (1000_B42A / 0x1B42A)
    // SI += DX;
    SI = Alu16.Add(SI, DX);
    CheckExternalEvents(cs8, 0xB42D);
    // PUSH ES (1000_B42C / 0x1B42C)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xB42F);
    // MOV AX,DS (1000_B42D / 0x1B42D)
    AX = DS;
    CheckExternalEvents(cs8, 0xB431);
    // MOV ES,AX (1000_B42F / 0x1B42F)
    ES = AX;
    CheckExternalEvents(cs8, 0xB433);
    // MOV BH,BL (1000_B431 / 0x1B431)
    BH = BL;
    CheckExternalEvents(cs8, 0xB434);
    // CLD  (1000_B433 / 0x1B433)
    DirectionFlag = false;
    CheckExternalEvents(cs8, 0xB437);
    // MOV DX,0x8 (1000_B434 / 0x1B434)
    DX = 0x8;
    CheckExternalEvents(cs8, 0xB43A);
    // MOV CX,0x4 (1000_B437 / 0x1B437)
    CX = 0x4;
    CheckExternalEvents(cs8, 0xB43C);
    // OR BL,BL (1000_B43A / 0x1B43A)
    // BL |= BL;
    BL = Alu8.Or(BL, BL);
    CheckExternalEvents(cs8, 0xB43E);
    // JS 0x1000:b446 (1000_B43C / 0x1B43C)
    if(SignFlag) {
      goto label_1000_B446_1B446;
    }
    CheckExternalEvents(cs8, 0xB441);
    // CMP BL,0x70 (1000_B43E / 0x1B43E)
    Alu8.Sub(BL, 0x70);
    CheckExternalEvents(cs8, 0xB443);
    // JNZ 0x1000:b455 (1000_B441 / 0x1B441)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_B455_1B455, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xB446);
    // MOV SI,0x209d (1000_B443 / 0x1B443)
    SI = 0x209D;
    label_1000_B446_1B446:
    CheckExternalEvents(cs8, 0xB448);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_B446 / 0x1B446)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs8, 0xB44B);
    // ADD DI,0x10 (1000_B448 / 0x1B448)
    // DI += 0x10;
    DI = Alu16.Add(DI, 0x10);
    CheckExternalEvents(cs8, 0xB44E);
    // MOV CX,0x4 (1000_B44B / 0x1B44B)
    CX = 0x4;
    CheckExternalEvents(cs8, 0xB450);
    // DEC DL (1000_B44E / 0x1B44E)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs8, 0xB452);
    // JNZ 0x1000:b446 (1000_B450 / 0x1B450)
    if(!ZeroFlag) {
      goto label_1000_B446_1B446;
    }
    CheckExternalEvents(cs8, 0xB454);
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
      case 0x1B46F: goto label_1000_B46F_1B46F;break; // Target of external jump from 0x1B452
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_B455_1B455:
    CheckExternalEvents(cs8, 0xB459);
    // MOV AH,byte ptr [0x272] (1000_B455 / 0x1B455)
    AH = UInt8[DS, 0x272];
    CheckExternalEvents(cs8, 0xB45C);
    // MOV CX,0x8 (1000_B459 / 0x1B459)
    CX = 0x8;
    label_1000_B45C_1B45C:
    CheckExternalEvents(cs8, 0xB45D);
    // LODSB SI (1000_B45C / 0x1B45C)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xB45F);
    // CMP AL,0x40 (1000_B45D / 0x1B45D)
    Alu8.Sub(AL, 0x40);
    CheckExternalEvents(cs8, 0xB461);
    // JNC 0x1000:b465 (1000_B45F / 0x1B45F)
    if(!CarryFlag) {
      goto label_1000_B465_1B465;
    }
    CheckExternalEvents(cs8, 0xB463);
    // AND AL,0xf (1000_B461 / 0x1B461)
    AL &= 0xF;
    CheckExternalEvents(cs8, 0xB465);
    // ADD AL,BL (1000_B463 / 0x1B463)
    // AL += BL;
    AL = Alu8.Add(AL, BL);
    label_1000_B465_1B465:
    CheckExternalEvents(cs8, 0xB466);
    // STOSB ES:DI (1000_B465 / 0x1B465)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xB468);
    // LOOP 0x1000:b45c (1000_B466 / 0x1B466)
    if(--CX != 0) {
      goto label_1000_B45C_1B45C;
    }
    CheckExternalEvents(cs8, 0xB46B);
    // ADD DI,0x10 (1000_B468 / 0x1B468)
    DI += 0x10;
    CheckExternalEvents(cs8, 0xB46D);
    // DEC DL (1000_B46B / 0x1B46B)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs8, 0xB46F);
    // JNZ 0x1000:b455 (1000_B46D / 0x1B46D)
    if(!ZeroFlag) {
      goto label_1000_B455_1B455;
    }
    label_1000_B46F_1B46F:
    CheckExternalEvents(cs8, 0xB473);
    // SUB DI,0xb8 (1000_B46F / 0x1B46F)
    // DI -= 0xB8;
    DI = Alu16.Sub(DI, 0xB8);
    CheckExternalEvents(cs8, 0xB474);
    // POP ES (1000_B473 / 0x1B473)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xB477);
    // MOV AL,[0x2c9] (1000_B474 / 0x1B474)
    AL = UInt8[DS, 0x2C9];
    CheckExternalEvents(cs8, 0xB47B);
    // OR AL,byte ptr [0x2ca] (1000_B477 / 0x1B477)
    // AL |= UInt8[DS, 0x2CA];
    AL = Alu8.Or(AL, UInt8[DS, 0x2CA]);
    CheckExternalEvents(cs8, 0xB47C);
    // RET  (1000_B47B / 0x1B47B)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_158C_1B47C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_158C_1B47C:
    CheckExternalEvents(cs14, 0x158D);
    // PUSH BP (19EF_158C / 0x1B47C)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x158F);
    // MOV BP,SP (19EF_158D / 0x1B47D)
    BP = SP;
    CheckExternalEvents(cs14, 0x1590);
    // PUSH DI (19EF_158F / 0x1B47F)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1591);
    // PUSH SI (19EF_1590 / 0x1B480)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1592);
    // PUSH DS (19EF_1591 / 0x1B481)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1595);
    // MOV AX,0x1ddc (19EF_1592 / 0x1B482)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x1597);
    // MOV DS,AX (19EF_1595 / 0x1B485)
    DS = AX;
    CheckExternalEvents(cs14, 0x159A);
    // MOV AX,[0xa44d] (19EF_1597 / 0x1B487)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x159C);
    // DEC AL (19EF_159A / 0x1B48A)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs14, 0x159E);
    // JS 0x1000:b494 (19EF_159C / 0x1B48C)
    if(SignFlag) {
      goto label_19EF_15A4_1B494;
    }
    CheckExternalEvents(cs14, 0x15A1);
    // MOV [0xa44d],AX (19EF_159E / 0x1B48E)
    UInt16[DS, 0xA44D] = AX;
    label_19EF_15A1_1B491:
    CheckExternalEvents(cs14, 0x15A4);
    // JMP 0x1000:b526 (19EF_15A1 / 0x1B491)
    goto label_19EF_1636_1B526;
    label_19EF_15A4_1B494:
    CheckExternalEvents(cs14, 0x15A7);
    // CMP AH,0x0 (19EF_15A4 / 0x1B494)
    Alu8.Sub(AH, 0x0);
    CheckExternalEvents(cs14, 0x15A9);
    // JZ 0x1000:b491 (19EF_15A7 / 0x1B497)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs14, 0x15A4);
      // JMP 0x1000:b526 (19EF_15A1 / 0x1B491)
      goto label_19EF_1636_1B526;
    }
    CheckExternalEvents(cs14, 0x15AC);
    // SUB AH,0x10 (19EF_15A9 / 0x1B499)
    // AH -= 0x10;
    AH = Alu8.Sub(AH, 0x10);
    CheckExternalEvents(cs14, 0x15AE);
    // MOV AL,0x7f (19EF_15AC / 0x1B49C)
    AL = 0x7F;
    CheckExternalEvents(cs14, 0x15B1);
    // MOV [0xa44d],AX (19EF_15AE / 0x1B49E)
    UInt16[DS, 0xA44D] = AX;
    CheckExternalEvents(cs14, 0x15B2);
    // PUSH ES (19EF_15B1 / 0x1B4A1)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x15B4);
    // MOV AX,DS (19EF_15B2 / 0x1B4A2)
    AX = DS;
    CheckExternalEvents(cs14, 0x15B6);
    // MOV ES,AX (19EF_15B4 / 0x1B4A4)
    ES = AX;
    CheckExternalEvents(cs14, 0x15B9);
    // MOV SI,0x6e4 (19EF_15B6 / 0x1B4A6)
    SI = 0x6E4;
    CheckExternalEvents(cs14, 0x15BC);
    // SUB SI,0x2 (19EF_15B9 / 0x1B4A9)
    // SI -= 0x2;
    SI = Alu16.Sub(SI, 0x2);
    CheckExternalEvents(cs14, 0x15BF);
    // MOV DI,0x764 (19EF_15BC / 0x1B4AC)
    DI = 0x764;
    CheckExternalEvents(cs14, 0x15C2);
    // ADD DI,0x3e (19EF_15BF / 0x1B4AF)
    // DI += 0x3E;
    DI = Alu16.Add(DI, 0x3E);
    CheckExternalEvents(cs14, 0x15C5);
    // MOV CX,0xc0 (19EF_15C2 / 0x1B4B2)
    CX = 0xC0;
    CheckExternalEvents(cs14, 0x15C6);
    // STD  (19EF_15C5 / 0x1B4B5)
    DirectionFlag = true;
    CheckExternalEvents(cs14, 0x15C8);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_15C6 / 0x1B4B6)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x15C9);
    // CLD  (19EF_15C8 / 0x1B4B8)
    DirectionFlag = false;
    CheckExternalEvents(cs14, 0x15CA);
    // POP ES (19EF_15C9 / 0x1B4B9)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x15CD);
    // MOV DI,0x2d3 (19EF_15CA / 0x1B4BA)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x15D0);
    // MOV AX,[0xa44d] (19EF_15CD / 0x1B4BD)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x15D4);
    // MOV BX,word ptr [0xa44b] (19EF_15D0 / 0x1B4C0)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs14, 0x15D6);
    // OR AH,BH (19EF_15D4 / 0x1B4C4)
    // AH |= BH;
    AH = Alu8.Or(AH, BH);
    CheckExternalEvents(cs14, 0x15D8);
    // MOV AL,AH (19EF_15D6 / 0x1B4C6)
    AL = AH;
    CheckExternalEvents(cs14, 0x15DA);
    // XOR AH,AH (19EF_15D8 / 0x1B4C8)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0x15DC);
    // MOV SI,AX (19EF_15DA / 0x1B4CA)
    SI = AX;
    CheckExternalEvents(cs14, 0x15E0);
    // ADD SI,0xb0b (19EF_15DC / 0x1B4CC)
    SI += 0xB0B;
    CheckExternalEvents(cs14, 0x15E3);
    // SUB SI,0x11 (19EF_15E0 / 0x1B4D0)
    // SI -= 0x11;
    SI = Alu16.Sub(SI, 0x11);
    CheckExternalEvents(cs14, 0x15E6);
    // CALL 0x1000:b7c8 (19EF_15E3 / 0x1B4D3)
    NearCall(cs14, 0x15E6, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x15E7);
    // PUSH SI (19EF_15E6 / 0x1B4D6)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x15EA);
    // MOV SI,0x564 (19EF_15E7 / 0x1B4D7)
    SI = 0x564;
    CheckExternalEvents(cs14, 0x15ED);
    // CALL 0x1000:aaeb (19EF_15EA / 0x1B4DA)
    NearCall(cs14, 0x15ED, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x15EE);
    // POP SI (19EF_15ED / 0x1B4DD)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x15EF);
    // INC SI (19EF_15EE / 0x1B4DE)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x15F2);
    // MOV DI,0x2d3 (19EF_15EF / 0x1B4DF)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x15F5);
    // CALL 0x1000:b7c8 (19EF_15F2 / 0x1B4E2)
    NearCall(cs14, 0x15F5, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x15F6);
    // PUSH SI (19EF_15F5 / 0x1B4E5)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x15F9);
    // MOV SI,0x5a4 (19EF_15F6 / 0x1B4E6)
    SI = 0x5A4;
    CheckExternalEvents(cs14, 0x15FC);
    // CALL 0x1000:aaeb (19EF_15F9 / 0x1B4E9)
    NearCall(cs14, 0x15FC, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x15FD);
    // POP SI (19EF_15FC / 0x1B4EC)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x15FE);
    // INC SI (19EF_15FD / 0x1B4ED)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x1601);
    // MOV DI,0x2d3 (19EF_15FE / 0x1B4EE)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x1604);
    // CALL 0x1000:b7c8 (19EF_1601 / 0x1B4F1)
    NearCall(cs14, 0x1604, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x1607);
    // MOV SI,0x5e4 (19EF_1604 / 0x1B4F4)
    SI = 0x5E4;
    CheckExternalEvents(cs14, 0x160A);
    // CALL 0x1000:aaeb (19EF_1607 / 0x1B4F7)
    NearCall(cs14, 0x160A, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x160D);
    // CALL 0x1000:b776 (19EF_160A / 0x1B4FA)
    NearCall(cs14, 0x160D, unknown_19EF_1886_1B776);
    CheckExternalEvents(cs14, 0x1610);
    // MOV SI,0x9f3 (19EF_160D / 0x1B4FD)
    SI = 0x9F3;
    CheckExternalEvents(cs14, 0x1613);
    // MOV AX,0x100 (19EF_1610 / 0x1B500)
    AX = 0x100;
    CheckExternalEvents(cs14, 0x1615);
    // MOV word ptr [SI],AX (19EF_1613 / 0x1B503)
    UInt16[DS, (ushort)(SI)] = AX;
    CheckExternalEvents(cs14, 0x1618);
    // ADD SI,0x2 (19EF_1615 / 0x1B505)
    SI += 0x2;
    CheckExternalEvents(cs14, 0x161A);
    // INC AH (19EF_1618 / 0x1B508)
    AH = Alu8.Inc(AH);
    CheckExternalEvents(cs14, 0x161C);
    // MOV byte ptr [SI],AH (19EF_161A / 0x1B50A)
    UInt8[DS, (ushort)(SI)] = AH;
    CheckExternalEvents(cs14, 0x161D);
    // INC SI (19EF_161C / 0x1B50C)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x1620);
    // MOV AX,[0xa44d] (19EF_161D / 0x1B50D)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x1624);
    // OR AX,word ptr [0xa44b] (19EF_1620 / 0x1B510)
    // AX |= UInt16[DS, 0xA44B];
    AX = Alu16.Or(AX, UInt16[DS, 0xA44B]);
    CheckExternalEvents(cs14, 0x1626);
    // MOV AL,AH (19EF_1624 / 0x1B514)
    AL = AH;
    CheckExternalEvents(cs14, 0x1628);
    // XOR AH,AH (19EF_1626 / 0x1B516)
    AH = 0;
    CheckExternalEvents(cs14, 0x162A);
    // SUB AL,0x11 (19EF_1628 / 0x1B518)
    // AL -= 0x11;
    AL = Alu8.Sub(AL, 0x11);
    CheckExternalEvents(cs14, 0x162C);
    // MOV byte ptr [SI],AL (19EF_162A / 0x1B51A)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs14, 0x162D);
    // INC SI (19EF_162C / 0x1B51C)
    SI++;
    CheckExternalEvents(cs14, 0x162F);
    // INC AL (19EF_162D / 0x1B51D)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs14, 0x1631);
    // MOV byte ptr [SI],AL (19EF_162F / 0x1B51F)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs14, 0x1632);
    // INC SI (19EF_1631 / 0x1B521)
    SI++;
    CheckExternalEvents(cs14, 0x1634);
    // INC AL (19EF_1632 / 0x1B522)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs14, 0x1636);
    // MOV byte ptr [SI],AL (19EF_1634 / 0x1B524)
    UInt8[DS, (ushort)(SI)] = AL;
    label_19EF_1636_1B526:
    CheckExternalEvents(cs14, 0x1637);
    // POP DS (19EF_1636 / 0x1B526)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1638);
    // POP SI (19EF_1637 / 0x1B527)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1639);
    // POP DI (19EF_1638 / 0x1B528)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x163A);
    // POP BP (19EF_1639 / 0x1B529)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x163B);
    // RETF  (19EF_163A / 0x1B52A)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_163B_1B52B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_163B_1B52B:
    CheckExternalEvents(cs14, 0x163C);
    // PUSH BP (19EF_163B / 0x1B52B)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x163E);
    // MOV BP,SP (19EF_163C / 0x1B52C)
    BP = SP;
    CheckExternalEvents(cs14, 0x163F);
    // PUSH DI (19EF_163E / 0x1B52E)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1640);
    // PUSH SI (19EF_163F / 0x1B52F)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1641);
    // PUSH DS (19EF_1640 / 0x1B530)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1644);
    // MOV AX,0x1ddc (19EF_1641 / 0x1B531)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x1646);
    // MOV DS,AX (19EF_1644 / 0x1B534)
    DS = AX;
    CheckExternalEvents(cs14, 0x1649);
    // MOV AX,[0xa44d] (19EF_1646 / 0x1B536)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x164B);
    // INC AL (19EF_1649 / 0x1B539)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs14, 0x164D);
    // JS 0x1000:b543 (19EF_164B / 0x1B53B)
    if(SignFlag) {
      goto label_19EF_1653_1B543;
    }
    CheckExternalEvents(cs14, 0x1650);
    // MOV [0xa44d],AX (19EF_164D / 0x1B53D)
    UInt16[DS, 0xA44D] = AX;
    label_19EF_1650_1B540:
    CheckExternalEvents(cs14, 0x1653);
    // JMP 0x1000:b5ce (19EF_1650 / 0x1B540)
    goto label_19EF_16DE_1B5CE;
    label_19EF_1653_1B543:
    CheckExternalEvents(cs14, 0x1656);
    // CMP AH,0xf0 (19EF_1653 / 0x1B543)
    Alu8.Sub(AH, 0xF0);
    CheckExternalEvents(cs14, 0x1658);
    // JZ 0x1000:b540 (19EF_1656 / 0x1B546)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs14, 0x1653);
      // JMP 0x1000:b5ce (19EF_1650 / 0x1B540)
      goto label_19EF_16DE_1B5CE;
    }
    CheckExternalEvents(cs14, 0x165B);
    // ADD AH,0x10 (19EF_1658 / 0x1B548)
    AH += 0x10;
    CheckExternalEvents(cs14, 0x165D);
    // XOR AL,AL (19EF_165B / 0x1B54B)
    // AL ^= AL;
    AL = Alu8.Xor(AL, AL);
    CheckExternalEvents(cs14, 0x1660);
    // MOV [0xa44d],AX (19EF_165D / 0x1B54D)
    UInt16[DS, 0xA44D] = AX;
    CheckExternalEvents(cs14, 0x1661);
    // PUSH ES (19EF_1660 / 0x1B550)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x1663);
    // MOV AX,DS (19EF_1661 / 0x1B551)
    AX = DS;
    CheckExternalEvents(cs14, 0x1665);
    // MOV ES,AX (19EF_1663 / 0x1B553)
    ES = AX;
    CheckExternalEvents(cs14, 0x1668);
    // MOV SI,0x624 (19EF_1665 / 0x1B555)
    SI = 0x624;
    CheckExternalEvents(cs14, 0x166B);
    // MOV DI,0x564 (19EF_1668 / 0x1B558)
    DI = 0x564;
    CheckExternalEvents(cs14, 0x166E);
    // MOV CX,0xc0 (19EF_166B / 0x1B55B)
    CX = 0xC0;
    CheckExternalEvents(cs14, 0x166F);
    // CLD  (19EF_166E / 0x1B55E)
    DirectionFlag = false;
    CheckExternalEvents(cs14, 0x1671);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_166F / 0x1B55F)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x1672);
    // POP ES (19EF_1671 / 0x1B561)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1675);
    // MOV DI,0x2d3 (19EF_1672 / 0x1B562)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x1678);
    // MOV AX,[0xa44d] (19EF_1675 / 0x1B565)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x167C);
    // MOV BX,word ptr [0xa44b] (19EF_1678 / 0x1B568)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs14, 0x167E);
    // OR AH,BH (19EF_167C / 0x1B56C)
    // AH |= BH;
    AH = Alu8.Or(AH, BH);
    CheckExternalEvents(cs14, 0x1680);
    // MOV AL,AH (19EF_167E / 0x1B56E)
    AL = AH;
    CheckExternalEvents(cs14, 0x1682);
    // XOR AH,AH (19EF_1680 / 0x1B570)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0x1684);
    // MOV SI,AX (19EF_1682 / 0x1B572)
    SI = AX;
    CheckExternalEvents(cs14, 0x1688);
    // ADD SI,0xb0b (19EF_1684 / 0x1B574)
    SI += 0xB0B;
    CheckExternalEvents(cs14, 0x168B);
    // ADD SI,0xf (19EF_1688 / 0x1B578)
    // SI += 0xF;
    SI = Alu16.Add(SI, 0xF);
    CheckExternalEvents(cs14, 0x168E);
    // CALL 0x1000:b7c8 (19EF_168B / 0x1B57B)
    NearCall(cs14, 0x168E, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x168F);
    // PUSH SI (19EF_168E / 0x1B57E)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1692);
    // MOV SI,0x6e4 (19EF_168F / 0x1B57F)
    SI = 0x6E4;
    CheckExternalEvents(cs14, 0x1695);
    // CALL 0x1000:aaeb (19EF_1692 / 0x1B582)
    NearCall(cs14, 0x1695, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x1696);
    // POP SI (19EF_1695 / 0x1B585)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1697);
    // INC SI (19EF_1696 / 0x1B586)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x169A);
    // MOV DI,0x2d3 (19EF_1697 / 0x1B587)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x169D);
    // CALL 0x1000:b7c8 (19EF_169A / 0x1B58A)
    NearCall(cs14, 0x169D, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x169E);
    // PUSH SI (19EF_169D / 0x1B58D)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x16A1);
    // MOV SI,0x724 (19EF_169E / 0x1B58E)
    SI = 0x724;
    CheckExternalEvents(cs14, 0x16A4);
    // CALL 0x1000:aaeb (19EF_16A1 / 0x1B591)
    NearCall(cs14, 0x16A4, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x16A5);
    // POP SI (19EF_16A4 / 0x1B594)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x16A6);
    // INC SI (19EF_16A5 / 0x1B595)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x16A9);
    // MOV DI,0x2d3 (19EF_16A6 / 0x1B596)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x16AC);
    // CALL 0x1000:b7c8 (19EF_16A9 / 0x1B599)
    NearCall(cs14, 0x16AC, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x16AF);
    // MOV SI,0x764 (19EF_16AC / 0x1B59C)
    SI = 0x764;
    CheckExternalEvents(cs14, 0x16B2);
    // CALL 0x1000:aaeb (19EF_16AF / 0x1B59F)
    NearCall(cs14, 0x16B2, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x16B5);
    // CALL 0x1000:b776 (19EF_16B2 / 0x1B5A2)
    NearCall(cs14, 0x16B5, unknown_19EF_1886_1B776);
    CheckExternalEvents(cs14, 0x16B8);
    // MOV SI,0x9f3 (19EF_16B5 / 0x1B5A5)
    SI = 0x9F3;
    CheckExternalEvents(cs14, 0x16BB);
    // MOV AX,0x706 (19EF_16B8 / 0x1B5A8)
    AX = 0x706;
    CheckExternalEvents(cs14, 0x16BD);
    // MOV word ptr [SI],AX (19EF_16BB / 0x1B5AB)
    UInt16[DS, (ushort)(SI)] = AX;
    CheckExternalEvents(cs14, 0x16C0);
    // ADD SI,0x2 (19EF_16BD / 0x1B5AD)
    SI += 0x2;
    CheckExternalEvents(cs14, 0x16C2);
    // INC AH (19EF_16C0 / 0x1B5B0)
    AH = Alu8.Inc(AH);
    CheckExternalEvents(cs14, 0x16C4);
    // MOV byte ptr [SI],AH (19EF_16C2 / 0x1B5B2)
    UInt8[DS, (ushort)(SI)] = AH;
    CheckExternalEvents(cs14, 0x16C5);
    // INC SI (19EF_16C4 / 0x1B5B4)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x16C8);
    // MOV AX,[0xa44d] (19EF_16C5 / 0x1B5B5)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x16CC);
    // OR AX,word ptr [0xa44b] (19EF_16C8 / 0x1B5B8)
    // AX |= UInt16[DS, 0xA44B];
    AX = Alu16.Or(AX, UInt16[DS, 0xA44B]);
    CheckExternalEvents(cs14, 0x16CE);
    // MOV AL,AH (19EF_16CC / 0x1B5BC)
    AL = AH;
    CheckExternalEvents(cs14, 0x16D0);
    // XOR AH,AH (19EF_16CE / 0x1B5BE)
    AH = 0;
    CheckExternalEvents(cs14, 0x16D2);
    // ADD AL,0xf (19EF_16D0 / 0x1B5C0)
    // AL += 0xF;
    AL = Alu8.Add(AL, 0xF);
    CheckExternalEvents(cs14, 0x16D4);
    // MOV byte ptr [SI],AL (19EF_16D2 / 0x1B5C2)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs14, 0x16D5);
    // INC SI (19EF_16D4 / 0x1B5C4)
    SI++;
    CheckExternalEvents(cs14, 0x16D7);
    // INC AL (19EF_16D5 / 0x1B5C5)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs14, 0x16D9);
    // MOV byte ptr [SI],AL (19EF_16D7 / 0x1B5C7)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs14, 0x16DA);
    // INC SI (19EF_16D9 / 0x1B5C9)
    SI++;
    CheckExternalEvents(cs14, 0x16DC);
    // INC AL (19EF_16DA / 0x1B5CA)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs14, 0x16DE);
    // MOV byte ptr [SI],AL (19EF_16DC / 0x1B5CC)
    UInt8[DS, (ushort)(SI)] = AL;
    label_19EF_16DE_1B5CE:
    CheckExternalEvents(cs14, 0x16DF);
    // POP DS (19EF_16DE / 0x1B5CE)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x16E0);
    // POP SI (19EF_16DF / 0x1B5CF)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x16E1);
    // POP DI (19EF_16E0 / 0x1B5D0)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x16E2);
    // POP BP (19EF_16E1 / 0x1B5D1)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x16E3);
    // RETF  (19EF_16E2 / 0x1B5D2)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_16E3_1B5D3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_16E3_1B5D3:
    CheckExternalEvents(cs14, 0x16E4);
    // PUSH BP (19EF_16E3 / 0x1B5D3)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x16E6);
    // MOV BP,SP (19EF_16E4 / 0x1B5D4)
    BP = SP;
    CheckExternalEvents(cs14, 0x16E7);
    // PUSH DI (19EF_16E6 / 0x1B5D6)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x16E8);
    // PUSH SI (19EF_16E7 / 0x1B5D7)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x16E9);
    // PUSH DS (19EF_16E8 / 0x1B5D8)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x16EC);
    // MOV AX,0x1ddc (19EF_16E9 / 0x1B5D9)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x16EE);
    // MOV DS,AX (19EF_16EC / 0x1B5DC)
    DS = AX;
    CheckExternalEvents(cs14, 0x16F1);
    // MOV AX,[0xa44b] (19EF_16EE / 0x1B5DE)
    AX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs14, 0x16F3);
    // DEC AL (19EF_16F1 / 0x1B5E1)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs14, 0x16F5);
    // JS 0x1000:b5eb (19EF_16F3 / 0x1B5E3)
    if(SignFlag) {
      goto label_19EF_16FB_1B5EB;
    }
    CheckExternalEvents(cs14, 0x16F8);
    // MOV [0xa44b],AX (19EF_16F5 / 0x1B5E5)
    UInt16[DS, 0xA44B] = AX;
    label_19EF_16F8_1B5E8:
    CheckExternalEvents(cs14, 0x16FB);
    // JMP 0x1000:b6b0 (19EF_16F8 / 0x1B5E8)
    goto label_19EF_17C0_1B6B0;
    label_19EF_16FB_1B5EB:
    CheckExternalEvents(cs14, 0x16FE);
    // CMP AH,0x0 (19EF_16FB / 0x1B5EB)
    Alu8.Sub(AH, 0x0);
    CheckExternalEvents(cs14, 0x1700);
    // JZ 0x1000:b5e8 (19EF_16FE / 0x1B5EE)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs14, 0x16FB);
      // JMP 0x1000:b6b0 (19EF_16F8 / 0x1B5E8)
      goto label_19EF_17C0_1B6B0;
    }
    CheckExternalEvents(cs14, 0x1702);
    // DEC AH (19EF_1700 / 0x1B5F0)
    AH = Alu8.Dec(AH);
    CheckExternalEvents(cs14, 0x1704);
    // MOV AL,0x7f (19EF_1702 / 0x1B5F2)
    AL = 0x7F;
    CheckExternalEvents(cs14, 0x1707);
    // MOV [0xa44b],AX (19EF_1704 / 0x1B5F4)
    UInt16[DS, 0xA44B] = AX;
    CheckExternalEvents(cs14, 0x1708);
    // PUSH ES (19EF_1707 / 0x1B5F7)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x170A);
    // MOV AX,DS (19EF_1708 / 0x1B5F8)
    AX = DS;
    CheckExternalEvents(cs14, 0x170C);
    // MOV ES,AX (19EF_170A / 0x1B5FA)
    ES = AX;
    CheckExternalEvents(cs14, 0x170F);
    // MOV SI,0x5a4 (19EF_170C / 0x1B5FC)
    SI = 0x5A4;
    CheckExternalEvents(cs14, 0x1712);
    // MOV DI,0x5e4 (19EF_170F / 0x1B5FF)
    DI = 0x5E4;
    CheckExternalEvents(cs14, 0x1715);
    // MOV CX,0x20 (19EF_1712 / 0x1B602)
    CX = 0x20;
    CheckExternalEvents(cs14, 0x1716);
    // CLD  (19EF_1715 / 0x1B605)
    DirectionFlag = false;
    CheckExternalEvents(cs14, 0x1718);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_1716 / 0x1B606)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x171B);
    // MOV SI,0x564 (19EF_1718 / 0x1B608)
    SI = 0x564;
    CheckExternalEvents(cs14, 0x171E);
    // MOV DI,0x5a4 (19EF_171B / 0x1B60B)
    DI = 0x5A4;
    CheckExternalEvents(cs14, 0x1721);
    // MOV CX,0x20 (19EF_171E / 0x1B60E)
    CX = 0x20;
    CheckExternalEvents(cs14, 0x1723);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_1721 / 0x1B611)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x1726);
    // MOV SI,0x664 (19EF_1723 / 0x1B613)
    SI = 0x664;
    CheckExternalEvents(cs14, 0x1729);
    // MOV DI,0x6a4 (19EF_1726 / 0x1B616)
    DI = 0x6A4;
    CheckExternalEvents(cs14, 0x172C);
    // MOV CX,0x20 (19EF_1729 / 0x1B619)
    CX = 0x20;
    CheckExternalEvents(cs14, 0x172E);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_172C / 0x1B61C)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x1731);
    // MOV SI,0x624 (19EF_172E / 0x1B61E)
    SI = 0x624;
    CheckExternalEvents(cs14, 0x1734);
    // MOV DI,0x664 (19EF_1731 / 0x1B621)
    DI = 0x664;
    CheckExternalEvents(cs14, 0x1737);
    // MOV CX,0x20 (19EF_1734 / 0x1B624)
    CX = 0x20;
    CheckExternalEvents(cs14, 0x1739);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_1737 / 0x1B627)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x173C);
    // MOV SI,0x724 (19EF_1739 / 0x1B629)
    SI = 0x724;
    CheckExternalEvents(cs14, 0x173F);
    // MOV DI,0x764 (19EF_173C / 0x1B62C)
    DI = 0x764;
    CheckExternalEvents(cs14, 0x1742);
    // MOV CX,0x20 (19EF_173F / 0x1B62F)
    CX = 0x20;
    CheckExternalEvents(cs14, 0x1744);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_1742 / 0x1B632)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x1747);
    // MOV SI,0x6e4 (19EF_1744 / 0x1B634)
    SI = 0x6E4;
    CheckExternalEvents(cs14, 0x174A);
    // MOV DI,0x724 (19EF_1747 / 0x1B637)
    DI = 0x724;
    CheckExternalEvents(cs14, 0x174D);
    // MOV CX,0x20 (19EF_174A / 0x1B63A)
    CX = 0x20;
    CheckExternalEvents(cs14, 0x174F);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_174D / 0x1B63D)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x1750);
    // POP ES (19EF_174F / 0x1B63F)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1753);
    // MOV DI,0x2d3 (19EF_1750 / 0x1B640)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x1756);
    // MOV AX,[0xa44d] (19EF_1753 / 0x1B643)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x175A);
    // MOV BX,word ptr [0xa44b] (19EF_1756 / 0x1B646)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs14, 0x175C);
    // OR AH,BH (19EF_175A / 0x1B64A)
    // AH |= BH;
    AH = Alu8.Or(AH, BH);
    CheckExternalEvents(cs14, 0x175E);
    // MOV AL,AH (19EF_175C / 0x1B64C)
    AL = AH;
    CheckExternalEvents(cs14, 0x1760);
    // XOR AH,AH (19EF_175E / 0x1B64E)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0x1762);
    // MOV SI,AX (19EF_1760 / 0x1B650)
    SI = AX;
    CheckExternalEvents(cs14, 0x1766);
    // ADD SI,0xb0b (19EF_1762 / 0x1B652)
    SI += 0xB0B;
    CheckExternalEvents(cs14, 0x1769);
    // SUB SI,0x11 (19EF_1766 / 0x1B656)
    // SI -= 0x11;
    SI = Alu16.Sub(SI, 0x11);
    CheckExternalEvents(cs14, 0x176C);
    // CALL 0x1000:b7c8 (19EF_1769 / 0x1B659)
    NearCall(cs14, 0x176C, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x176D);
    // PUSH SI (19EF_176C / 0x1B65C)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1770);
    // MOV SI,0x564 (19EF_176D / 0x1B65D)
    SI = 0x564;
    CheckExternalEvents(cs14, 0x1773);
    // CALL 0x1000:aaeb (19EF_1770 / 0x1B660)
    NearCall(cs14, 0x1773, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x1774);
    // POP SI (19EF_1773 / 0x1B663)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1777);
    // ADD SI,0x10 (19EF_1774 / 0x1B664)
    // SI += 0x10;
    SI = Alu16.Add(SI, 0x10);
    CheckExternalEvents(cs14, 0x177A);
    // MOV DI,0x2d3 (19EF_1777 / 0x1B667)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x177D);
    // CALL 0x1000:b7c8 (19EF_177A / 0x1B66A)
    NearCall(cs14, 0x177D, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x177E);
    // PUSH SI (19EF_177D / 0x1B66D)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1781);
    // MOV SI,0x624 (19EF_177E / 0x1B66E)
    SI = 0x624;
    CheckExternalEvents(cs14, 0x1784);
    // CALL 0x1000:aaeb (19EF_1781 / 0x1B671)
    NearCall(cs14, 0x1784, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x1785);
    // POP SI (19EF_1784 / 0x1B674)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1788);
    // ADD SI,0x10 (19EF_1785 / 0x1B675)
    // SI += 0x10;
    SI = Alu16.Add(SI, 0x10);
    CheckExternalEvents(cs14, 0x178B);
    // MOV DI,0x2d3 (19EF_1788 / 0x1B678)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x178E);
    // CALL 0x1000:b7c8 (19EF_178B / 0x1B67B)
    NearCall(cs14, 0x178E, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x1791);
    // MOV SI,0x6e4 (19EF_178E / 0x1B67E)
    SI = 0x6E4;
    CheckExternalEvents(cs14, 0x1794);
    // CALL 0x1000:aaeb (19EF_1791 / 0x1B681)
    NearCall(cs14, 0x1794, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x1797);
    // CALL 0x1000:b776 (19EF_1794 / 0x1B684)
    NearCall(cs14, 0x1797, unknown_19EF_1886_1B776);
    CheckExternalEvents(cs14, 0x179A);
    // MOV SI,0x9f3 (19EF_1797 / 0x1B687)
    SI = 0x9F3;
    CheckExternalEvents(cs14, 0x179D);
    // MOV AX,0x300 (19EF_179A / 0x1B68A)
    AX = 0x300;
    CheckExternalEvents(cs14, 0x179F);
    // MOV word ptr [SI],AX (19EF_179D / 0x1B68D)
    UInt16[DS, (ushort)(SI)] = AX;
    CheckExternalEvents(cs14, 0x17A2);
    // ADD SI,0x2 (19EF_179F / 0x1B68F)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs14, 0x17A4);
    // MOV AH,0x6 (19EF_17A2 / 0x1B692)
    AH = 0x6;
    CheckExternalEvents(cs14, 0x17A6);
    // MOV byte ptr [SI],AH (19EF_17A4 / 0x1B694)
    UInt8[DS, (ushort)(SI)] = AH;
    CheckExternalEvents(cs14, 0x17A7);
    // INC SI (19EF_17A6 / 0x1B696)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x17AA);
    // MOV AX,[0xa44d] (19EF_17A7 / 0x1B697)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x17AE);
    // OR AX,word ptr [0xa44b] (19EF_17AA / 0x1B69A)
    // AX |= UInt16[DS, 0xA44B];
    AX = Alu16.Or(AX, UInt16[DS, 0xA44B]);
    CheckExternalEvents(cs14, 0x17B0);
    // MOV AL,AH (19EF_17AE / 0x1B69E)
    AL = AH;
    CheckExternalEvents(cs14, 0x17B2);
    // XOR AH,AH (19EF_17B0 / 0x1B6A0)
    AH = 0;
    CheckExternalEvents(cs14, 0x17B4);
    // SUB AL,0x11 (19EF_17B2 / 0x1B6A2)
    // AL -= 0x11;
    AL = Alu8.Sub(AL, 0x11);
    CheckExternalEvents(cs14, 0x17B6);
    // MOV byte ptr [SI],AL (19EF_17B4 / 0x1B6A4)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs14, 0x17B7);
    // INC SI (19EF_17B6 / 0x1B6A6)
    SI++;
    CheckExternalEvents(cs14, 0x17B9);
    // ADD AL,0x10 (19EF_17B7 / 0x1B6A7)
    // AL += 0x10;
    AL = Alu8.Add(AL, 0x10);
    CheckExternalEvents(cs14, 0x17BB);
    // MOV byte ptr [SI],AL (19EF_17B9 / 0x1B6A9)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs14, 0x17BC);
    // INC SI (19EF_17BB / 0x1B6AB)
    SI++;
    CheckExternalEvents(cs14, 0x17BE);
    // ADD AL,0x10 (19EF_17BC / 0x1B6AC)
    // AL += 0x10;
    AL = Alu8.Add(AL, 0x10);
    CheckExternalEvents(cs14, 0x17C0);
    // MOV byte ptr [SI],AL (19EF_17BE / 0x1B6AE)
    UInt8[DS, (ushort)(SI)] = AL;
    label_19EF_17C0_1B6B0:
    CheckExternalEvents(cs14, 0x17C1);
    // POP DS (19EF_17C0 / 0x1B6B0)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x17C2);
    // POP SI (19EF_17C1 / 0x1B6B1)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x17C3);
    // POP DI (19EF_17C2 / 0x1B6B2)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x17C4);
    // POP BP (19EF_17C3 / 0x1B6B3)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x17C5);
    // RETF  (19EF_17C4 / 0x1B6B4)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_17C5_1B6B5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_17C5_1B6B5:
    CheckExternalEvents(cs14, 0x17C6);
    // PUSH BP (19EF_17C5 / 0x1B6B5)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x17C8);
    // MOV BP,SP (19EF_17C6 / 0x1B6B6)
    BP = SP;
    CheckExternalEvents(cs14, 0x17C9);
    // PUSH DI (19EF_17C8 / 0x1B6B8)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x17CA);
    // PUSH SI (19EF_17C9 / 0x1B6B9)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x17CB);
    // PUSH DS (19EF_17CA / 0x1B6BA)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x17CE);
    // MOV AX,0x1ddc (19EF_17CB / 0x1B6BB)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x17D0);
    // MOV DS,AX (19EF_17CE / 0x1B6BE)
    DS = AX;
    CheckExternalEvents(cs14, 0x17D3);
    // MOV AX,[0xa44b] (19EF_17D0 / 0x1B6C0)
    AX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs14, 0x17D5);
    // INC AL (19EF_17D3 / 0x1B6C3)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs14, 0x17D7);
    // JS 0x1000:b6cd (19EF_17D5 / 0x1B6C5)
    if(SignFlag) {
      goto label_19EF_17DD_1B6CD;
    }
    CheckExternalEvents(cs14, 0x17DA);
    // MOV [0xa44b],AX (19EF_17D7 / 0x1B6C7)
    UInt16[DS, 0xA44B] = AX;
    label_19EF_17DA_1B6CA:
    CheckExternalEvents(cs14, 0x17DD);
    // JMP 0x1000:b771 (19EF_17DA / 0x1B6CA)
    goto label_19EF_1881_1B771;
    label_19EF_17DD_1B6CD:
    CheckExternalEvents(cs14, 0x17E0);
    // CMP AH,0xf (19EF_17DD / 0x1B6CD)
    Alu8.Sub(AH, 0xF);
    CheckExternalEvents(cs14, 0x17E2);
    // JZ 0x1000:b6ca (19EF_17E0 / 0x1B6D0)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs14, 0x17DD);
      // JMP 0x1000:b771 (19EF_17DA / 0x1B6CA)
      goto label_19EF_1881_1B771;
    }
    CheckExternalEvents(cs14, 0x17E4);
    // INC AH (19EF_17E2 / 0x1B6D2)
    AH++;
    CheckExternalEvents(cs14, 0x17E6);
    // XOR AL,AL (19EF_17E4 / 0x1B6D4)
    // AL ^= AL;
    AL = Alu8.Xor(AL, AL);
    CheckExternalEvents(cs14, 0x17E9);
    // MOV [0xa44b],AX (19EF_17E6 / 0x1B6D6)
    UInt16[DS, 0xA44B] = AX;
    CheckExternalEvents(cs14, 0x17EA);
    // PUSH ES (19EF_17E9 / 0x1B6D9)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x17EC);
    // MOV AX,DS (19EF_17EA / 0x1B6DA)
    AX = DS;
    CheckExternalEvents(cs14, 0x17EE);
    // MOV ES,AX (19EF_17EC / 0x1B6DC)
    ES = AX;
    CheckExternalEvents(cs14, 0x17F1);
    // MOV SI,0x5a4 (19EF_17EE / 0x1B6DE)
    SI = 0x5A4;
    CheckExternalEvents(cs14, 0x17F4);
    // MOV DI,0x564 (19EF_17F1 / 0x1B6E1)
    DI = 0x564;
    CheckExternalEvents(cs14, 0x17F7);
    // MOV CX,0x40 (19EF_17F4 / 0x1B6E4)
    CX = 0x40;
    CheckExternalEvents(cs14, 0x17F8);
    // CLD  (19EF_17F7 / 0x1B6E7)
    DirectionFlag = false;
    CheckExternalEvents(cs14, 0x17FA);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_17F8 / 0x1B6E8)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x17FD);
    // MOV SI,0x664 (19EF_17FA / 0x1B6EA)
    SI = 0x664;
    CheckExternalEvents(cs14, 0x1800);
    // MOV DI,0x624 (19EF_17FD / 0x1B6ED)
    DI = 0x624;
    CheckExternalEvents(cs14, 0x1803);
    // MOV CX,0x40 (19EF_1800 / 0x1B6F0)
    CX = 0x40;
    CheckExternalEvents(cs14, 0x1805);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_1803 / 0x1B6F3)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x1808);
    // MOV SI,0x724 (19EF_1805 / 0x1B6F5)
    SI = 0x724;
    CheckExternalEvents(cs14, 0x180B);
    // MOV DI,0x6e4 (19EF_1808 / 0x1B6F8)
    DI = 0x6E4;
    CheckExternalEvents(cs14, 0x180E);
    // MOV CX,0x40 (19EF_180B / 0x1B6FB)
    CX = 0x40;
    CheckExternalEvents(cs14, 0x1810);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_180E / 0x1B6FE)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x1811);
    // POP ES (19EF_1810 / 0x1B700)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1814);
    // MOV DI,0x2d3 (19EF_1811 / 0x1B701)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x1817);
    // MOV AX,[0xa44d] (19EF_1814 / 0x1B704)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x181B);
    // MOV BX,word ptr [0xa44b] (19EF_1817 / 0x1B707)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs14, 0x181D);
    // OR AH,BH (19EF_181B / 0x1B70B)
    // AH |= BH;
    AH = Alu8.Or(AH, BH);
    CheckExternalEvents(cs14, 0x181F);
    // MOV AL,AH (19EF_181D / 0x1B70D)
    AL = AH;
    CheckExternalEvents(cs14, 0x1821);
    // XOR AH,AH (19EF_181F / 0x1B70F)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0x1823);
    // MOV SI,AX (19EF_1821 / 0x1B711)
    SI = AX;
    CheckExternalEvents(cs14, 0x1827);
    // ADD SI,0xb0b (19EF_1823 / 0x1B713)
    SI += 0xB0B;
    CheckExternalEvents(cs14, 0x182A);
    // SUB SI,0xf (19EF_1827 / 0x1B717)
    // SI -= 0xF;
    SI = Alu16.Sub(SI, 0xF);
    CheckExternalEvents(cs14, 0x182D);
    // CALL 0x1000:b7c8 (19EF_182A / 0x1B71A)
    NearCall(cs14, 0x182D, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x182E);
    // PUSH SI (19EF_182D / 0x1B71D)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1831);
    // MOV SI,0x5e4 (19EF_182E / 0x1B71E)
    SI = 0x5E4;
    CheckExternalEvents(cs14, 0x1834);
    // CALL 0x1000:aaeb (19EF_1831 / 0x1B721)
    NearCall(cs14, 0x1834, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x1835);
    // POP SI (19EF_1834 / 0x1B724)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1838);
    // ADD SI,0x10 (19EF_1835 / 0x1B725)
    // SI += 0x10;
    SI = Alu16.Add(SI, 0x10);
    CheckExternalEvents(cs14, 0x183B);
    // MOV DI,0x2d3 (19EF_1838 / 0x1B728)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x183E);
    // CALL 0x1000:b7c8 (19EF_183B / 0x1B72B)
    NearCall(cs14, 0x183E, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x183F);
    // PUSH SI (19EF_183E / 0x1B72E)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1842);
    // MOV SI,0x6a4 (19EF_183F / 0x1B72F)
    SI = 0x6A4;
    CheckExternalEvents(cs14, 0x1845);
    // CALL 0x1000:aaeb (19EF_1842 / 0x1B732)
    NearCall(cs14, 0x1845, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x1846);
    // POP SI (19EF_1845 / 0x1B735)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1849);
    // ADD SI,0x10 (19EF_1846 / 0x1B736)
    // SI += 0x10;
    SI = Alu16.Add(SI, 0x10);
    CheckExternalEvents(cs14, 0x184C);
    // MOV DI,0x2d3 (19EF_1849 / 0x1B739)
    DI = 0x2D3;
    CheckExternalEvents(cs14, 0x184F);
    // CALL 0x1000:b7c8 (19EF_184C / 0x1B73C)
    NearCall(cs14, 0x184F, ghidra_guess_1000_B7C8_1B7C8);
    CheckExternalEvents(cs14, 0x1852);
    // MOV SI,0x764 (19EF_184F / 0x1B73F)
    SI = 0x764;
    CheckExternalEvents(cs14, 0x1855);
    // CALL 0x1000:aaeb (19EF_1852 / 0x1B742)
    NearCall(cs14, 0x1855, unknown_19EF_0BFB_1AAEB);
    CheckExternalEvents(cs14, 0x1858);
    // CALL 0x1000:b776 (19EF_1855 / 0x1B745)
    NearCall(cs14, 0x1858, unknown_19EF_1886_1B776);
    CheckExternalEvents(cs14, 0x185B);
    // MOV SI,0x9f3 (19EF_1858 / 0x1B748)
    SI = 0x9F3;
    CheckExternalEvents(cs14, 0x185E);
    // MOV AX,0x502 (19EF_185B / 0x1B74B)
    AX = 0x502;
    CheckExternalEvents(cs14, 0x1860);
    // MOV word ptr [SI],AX (19EF_185E / 0x1B74E)
    UInt16[DS, (ushort)(SI)] = AX;
    CheckExternalEvents(cs14, 0x1863);
    // ADD SI,0x2 (19EF_1860 / 0x1B750)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs14, 0x1865);
    // MOV AH,0x8 (19EF_1863 / 0x1B753)
    AH = 0x8;
    CheckExternalEvents(cs14, 0x1867);
    // MOV byte ptr [SI],AH (19EF_1865 / 0x1B755)
    UInt8[DS, (ushort)(SI)] = AH;
    CheckExternalEvents(cs14, 0x1868);
    // INC SI (19EF_1867 / 0x1B757)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x186B);
    // MOV AX,[0xa44d] (19EF_1868 / 0x1B758)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x186F);
    // OR AX,word ptr [0xa44b] (19EF_186B / 0x1B75B)
    // AX |= UInt16[DS, 0xA44B];
    AX = Alu16.Or(AX, UInt16[DS, 0xA44B]);
    CheckExternalEvents(cs14, 0x1871);
    // MOV AL,AH (19EF_186F / 0x1B75F)
    AL = AH;
    CheckExternalEvents(cs14, 0x1873);
    // XOR AH,AH (19EF_1871 / 0x1B761)
    AH = 0;
    CheckExternalEvents(cs14, 0x1875);
    // SUB AL,0xf (19EF_1873 / 0x1B763)
    // AL -= 0xF;
    AL = Alu8.Sub(AL, 0xF);
    CheckExternalEvents(cs14, 0x1877);
    // MOV byte ptr [SI],AL (19EF_1875 / 0x1B765)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs14, 0x1878);
    // INC SI (19EF_1877 / 0x1B767)
    SI++;
    CheckExternalEvents(cs14, 0x187A);
    // ADD AL,0x10 (19EF_1878 / 0x1B768)
    // AL += 0x10;
    AL = Alu8.Add(AL, 0x10);
    CheckExternalEvents(cs14, 0x187C);
    // MOV byte ptr [SI],AL (19EF_187A / 0x1B76A)
    UInt8[DS, (ushort)(SI)] = AL;
    CheckExternalEvents(cs14, 0x187D);
    // INC SI (19EF_187C / 0x1B76C)
    SI++;
    CheckExternalEvents(cs14, 0x187F);
    // ADD AL,0x10 (19EF_187D / 0x1B76D)
    // AL += 0x10;
    AL = Alu8.Add(AL, 0x10);
    CheckExternalEvents(cs14, 0x1881);
    // MOV byte ptr [SI],AL (19EF_187F / 0x1B76F)
    UInt8[DS, (ushort)(SI)] = AL;
    label_19EF_1881_1B771:
    CheckExternalEvents(cs14, 0x1882);
    // POP DS (19EF_1881 / 0x1B771)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1883);
    // POP SI (19EF_1882 / 0x1B772)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1884);
    // POP DI (19EF_1883 / 0x1B773)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1885);
    // POP BP (19EF_1884 / 0x1B774)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1886);
    // RETF  (19EF_1885 / 0x1B775)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1886_1B776(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1886_1B776:
    CheckExternalEvents(cs14, 0x1889);
    // MOV SI,0x564 (19EF_1886 / 0x1B776)
    SI = 0x564;
    CheckExternalEvents(cs14, 0x188C);
    // MOV DI,0x324 (19EF_1889 / 0x1B779)
    DI = 0x324;
    CheckExternalEvents(cs14, 0x188F);
    // CALL 0x1000:b0ab (19EF_188C / 0x1B77C)
    NearCall(cs14, 0x188F, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs14, 0x1892);
    // MOV SI,0x5a4 (19EF_188F / 0x1B77F)
    SI = 0x5A4;
    CheckExternalEvents(cs14, 0x1895);
    // MOV DI,0x364 (19EF_1892 / 0x1B782)
    DI = 0x364;
    CheckExternalEvents(cs14, 0x1898);
    // CALL 0x1000:b0ab (19EF_1895 / 0x1B785)
    NearCall(cs14, 0x1898, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs14, 0x189B);
    // MOV SI,0x5e4 (19EF_1898 / 0x1B788)
    SI = 0x5E4;
    CheckExternalEvents(cs14, 0x189E);
    // MOV DI,0x3a4 (19EF_189B / 0x1B78B)
    DI = 0x3A4;
    CheckExternalEvents(cs14, 0x18A1);
    // CALL 0x1000:b0ab (19EF_189E / 0x1B78E)
    NearCall(cs14, 0x18A1, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs14, 0x18A4);
    // MOV SI,0x624 (19EF_18A1 / 0x1B791)
    SI = 0x624;
    CheckExternalEvents(cs14, 0x18A7);
    // MOV DI,0x3e4 (19EF_18A4 / 0x1B794)
    DI = 0x3E4;
    CheckExternalEvents(cs14, 0x18AA);
    // CALL 0x1000:b0ab (19EF_18A7 / 0x1B797)
    NearCall(cs14, 0x18AA, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs14, 0x18AD);
    // MOV SI,0x664 (19EF_18AA / 0x1B79A)
    SI = 0x664;
    CheckExternalEvents(cs14, 0x18B0);
    // MOV DI,0x424 (19EF_18AD / 0x1B79D)
    DI = 0x424;
    CheckExternalEvents(cs14, 0x18B3);
    // CALL 0x1000:b0ab (19EF_18B0 / 0x1B7A0)
    NearCall(cs14, 0x18B3, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs14, 0x18B6);
    // MOV SI,0x6a4 (19EF_18B3 / 0x1B7A3)
    SI = 0x6A4;
    CheckExternalEvents(cs14, 0x18B9);
    // MOV DI,0x464 (19EF_18B6 / 0x1B7A6)
    DI = 0x464;
    CheckExternalEvents(cs14, 0x18BC);
    // CALL 0x1000:b0ab (19EF_18B9 / 0x1B7A9)
    NearCall(cs14, 0x18BC, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs14, 0x18BF);
    // MOV SI,0x6e4 (19EF_18BC / 0x1B7AC)
    SI = 0x6E4;
    CheckExternalEvents(cs14, 0x18C2);
    // MOV DI,0x4a4 (19EF_18BF / 0x1B7AF)
    DI = 0x4A4;
    CheckExternalEvents(cs14, 0x18C5);
    // CALL 0x1000:b0ab (19EF_18C2 / 0x1B7B2)
    NearCall(cs14, 0x18C5, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs14, 0x18C8);
    // MOV SI,0x724 (19EF_18C5 / 0x1B7B5)
    SI = 0x724;
    CheckExternalEvents(cs14, 0x18CB);
    // MOV DI,0x4e4 (19EF_18C8 / 0x1B7B8)
    DI = 0x4E4;
    CheckExternalEvents(cs14, 0x18CE);
    // CALL 0x1000:b0ab (19EF_18CB / 0x1B7BB)
    NearCall(cs14, 0x18CE, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs14, 0x18D1);
    // MOV SI,0x764 (19EF_18CE / 0x1B7BE)
    SI = 0x764;
    CheckExternalEvents(cs14, 0x18D4);
    // MOV DI,0x524 (19EF_18D1 / 0x1B7C1)
    DI = 0x524;
    CheckExternalEvents(cs14, 0x18D7);
    // CALL 0x1000:b0ab (19EF_18D4 / 0x1B7C4)
    NearCall(cs14, 0x18D7, unknown_19EF_11BB_1B0AB);
    CheckExternalEvents(cs14, 0x18D8);
    // RET  (19EF_18D7 / 0x1B7C7)
    return NearRet();
  }
  
  public virtual Action ghidra_guess_1000_B7C8_1B7C8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_B7C8_1B7C8:
    CheckExternalEvents(cs8, 0xB7CA);
    // MOV AL,byte ptr [SI] (1000_B7C8 / 0x1B7C8)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xB7CC);
    // MOV byte ptr [DI],AL (1000_B7CA / 0x1B7CA)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs8, 0xB7CF);
    // MOV AL,byte ptr [SI + 0x1] (1000_B7CC / 0x1B7CC)
    AL = UInt8[DS, (ushort)(SI + 0x1)];
    CheckExternalEvents(cs8, 0xB7D2);
    // MOV byte ptr [DI + 0x8],AL (1000_B7CF / 0x1B7CF)
    UInt8[DS, (ushort)(DI + 0x8)] = AL;
    CheckExternalEvents(cs8, 0xB7D5);
    // MOV AL,byte ptr [SI + 0x10] (1000_B7D2 / 0x1B7D2)
    AL = UInt8[DS, (ushort)(SI + 0x10)];
    CheckExternalEvents(cs8, 0xB7D8);
    // MOV byte ptr [DI + 0x48],AL (1000_B7D5 / 0x1B7D5)
    UInt8[DS, (ushort)(DI + 0x48)] = AL;
    CheckExternalEvents(cs8, 0xB7DB);
    // MOV AL,byte ptr [SI + 0x11] (1000_B7D8 / 0x1B7D8)
    AL = UInt8[DS, (ushort)(SI + 0x11)];
    CheckExternalEvents(cs8, 0xB7DE);
    // MOV byte ptr [DI + 0x50],AL (1000_B7DB / 0x1B7DB)
    UInt8[DS, (ushort)(DI + 0x50)] = AL;
    CheckExternalEvents(cs8, 0xB7DF);
    // RET  (1000_B7DE / 0x1B7DE)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_18EF_1B7DF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_18EF_1B7DF:
    CheckExternalEvents(cs14, 0x18F0);
    // PUSH BP (19EF_18EF / 0x1B7DF)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x18F2);
    // MOV BP,SP (19EF_18F0 / 0x1B7E0)
    BP = SP;
    CheckExternalEvents(cs14, 0x18F3);
    // PUSH DI (19EF_18F2 / 0x1B7E2)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x18F4);
    // PUSH SI (19EF_18F3 / 0x1B7E3)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x18F5);
    // PUSH DS (19EF_18F4 / 0x1B7E4)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x18F8);
    // MOV AX,0x1ddc (19EF_18F5 / 0x1B7E5)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x18FA);
    // MOV DS,AX (19EF_18F8 / 0x1B7E8)
    DS = AX;
    CheckExternalEvents(cs14, 0x18FB);
    // PUSH BP (19EF_18FA / 0x1B7EA)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x18FC);
    // PUSH ES (19EF_18FB / 0x1B7EB)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x18FF);
    // MOV DI,0x34 (19EF_18FC / 0x1B7EC)
    DI = 0x34;
    CheckExternalEvents(cs14, 0x1903);
    // ADD DI,0x244b (19EF_18FF / 0x1B7EF)
    // DI += 0x244B;
    DI = Alu16.Add(DI, 0x244B);
    CheckExternalEvents(cs14, 0x1909);
    // MOV word ptr [0xa452],0x8 (19EF_1903 / 0x1B7F3)
    UInt16[DS, 0xA452] = 0x8;
    CheckExternalEvents(cs14, 0x190F);
    // MOV word ptr [0xa454],0x994 (19EF_1909 / 0x1B7F9)
    UInt16[DS, 0xA454] = 0x994;
    CheckExternalEvents(cs14, 0x1915);
    // MOV word ptr [0xa456],0x494 (19EF_190F / 0x1B7FF)
    UInt16[DS, 0xA456] = 0x494;
    CheckExternalEvents(cs14, 0x1917);
    // MOV AX,DS (19EF_1915 / 0x1B805)
    AX = DS;
    CheckExternalEvents(cs14, 0x191C);
    // CMP word ptr [0xb764],0x2 (19EF_1917 / 0x1B807)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x191E);
    // JNZ 0x1000:b831 (19EF_191C / 0x1B80C)
    if(!ZeroFlag) {
      goto label_19EF_1941_1B831;
    }
    CheckExternalEvents(cs14, 0x1921);
    // MOV DX,0x3ce (19EF_191E / 0x1B80E)
    DX = 0x3CE;
    CheckExternalEvents(cs14, 0x1924);
    // MOV AX,0x205 (19EF_1921 / 0x1B811)
    AX = 0x205;
    CheckExternalEvents(cs14, 0x1925);
    // OUT DX,AX (19EF_1924 / 0x1B814)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x1928);
    // MOV AX,0x8 (19EF_1925 / 0x1B815)
    AX = 0x8;
    CheckExternalEvents(cs14, 0x1929);
    // OUT DX,AX (19EF_1928 / 0x1B818)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x192F);
    // MOV word ptr [0xa452],0x2 (19EF_1929 / 0x1B819)
    UInt16[DS, 0xA452] = 0x2;
    CheckExternalEvents(cs14, 0x1935);
    // MOV word ptr [0xa454],0x265 (19EF_192F / 0x1B81F)
    UInt16[DS, 0xA454] = 0x265;
    CheckExternalEvents(cs14, 0x193B);
    // MOV word ptr [0xa456],0x125 (19EF_1935 / 0x1B825)
    UInt16[DS, 0xA456] = 0x125;
    CheckExternalEvents(cs14, 0x193E);
    // MOV AX,0xac00 (19EF_193B / 0x1B82B)
    AX = 0xAC00;
    CheckExternalEvents(cs14, 0x1941);
    // MOV DI,0xd (19EF_193E / 0x1B82E)
    DI = 0xD;
    label_19EF_1941_1B831:
    CheckExternalEvents(cs14, 0x1943);
    // MOV ES,AX (19EF_1941 / 0x1B831)
    ES = AX;
    CheckExternalEvents(cs14, 0x1948);
    // CMP word ptr [0xb764],0x0 (19EF_1943 / 0x1B833)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x194A);
    // JNZ 0x1000:b849 (19EF_1948 / 0x1B838)
    if(!ZeroFlag) {
      goto label_19EF_1959_1B849;
    }
    CheckExternalEvents(cs14, 0x194D);
    // SUB DI,0x1a (19EF_194A / 0x1B83A)
    DI -= 0x1A;
    CheckExternalEvents(cs14, 0x1951);
    // SHR word ptr [0xa452],0x1 (19EF_194D / 0x1B83D)
    UInt16[DS, 0xA452] >>= 0x1;
    CheckExternalEvents(cs14, 0x1955);
    // SHR word ptr [0xa454],0x1 (19EF_1951 / 0x1B841)
    UInt16[DS, 0xA454] >>= 0x1;
    CheckExternalEvents(cs14, 0x1959);
    // SHR word ptr [0xa456],0x1 (19EF_1955 / 0x1B845)
    // UInt16[DS, 0xA456] >>= 0x1;
    UInt16[DS, 0xA456] = Alu16.Shr(UInt16[DS, 0xA456], 0x1);
    label_19EF_1959_1B849:
    CheckExternalEvents(cs14, 0x195A);
    // CLD  (19EF_1959 / 0x1B849)
    DirectionFlag = false;
    CheckExternalEvents(cs14, 0x195D);
    // MOV AX,[0xa44d] (19EF_195A / 0x1B84A)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x195F);
    // SHR AL,0x1 (19EF_195D / 0x1B84D)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x1962);
    // AND AX,0x7 (19EF_195F / 0x1B84F)
    AX &= 0x7;
    CheckExternalEvents(cs14, 0x1964);
    // ADD AL,0x2 (19EF_1962 / 0x1B852)
    AL += 0x2;
    CheckExternalEvents(cs14, 0x1966);
    // SHL AX,0x1 (19EF_1964 / 0x1B854)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x1968);
    // SHL AX,0x1 (19EF_1966 / 0x1B856)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x196A);
    // SHL AX,0x1 (19EF_1968 / 0x1B858)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs14, 0x196C);
    // MOV BX,AX (19EF_196A / 0x1B85A)
    BX = AX;
    CheckExternalEvents(cs14, 0x196E);
    // SHL AX,0x1 (19EF_196C / 0x1B85C)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x1970);
    // ADD AX,BX (19EF_196E / 0x1B85E)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs14, 0x1974);
    // MOV BX,word ptr [0xa44b] (19EF_1970 / 0x1B860)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs14, 0x1976);
    // SHR BL,0x1 (19EF_1974 / 0x1B864)
    BL >>= 0x1;
    CheckExternalEvents(cs14, 0x1979);
    // AND BX,0x7 (19EF_1976 / 0x1B866)
    BX &= 0x7;
    CheckExternalEvents(cs14, 0x197C);
    // ADD BL,0x2 (19EF_1979 / 0x1B869)
    BL += 0x2;
    CheckExternalEvents(cs14, 0x197E);
    // ADD BX,AX (19EF_197C / 0x1B86C)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs14, 0x1982);
    // MOV word ptr [0x9ed],BX (19EF_197E / 0x1B86E)
    UInt16[DS, 0x9ED] = BX;
    CheckExternalEvents(cs14, 0x1986);
    // ADD BX,0x7ad (19EF_1982 / 0x1B872)
    // BX += 0x7AD;
    BX = Alu16.Add(BX, 0x7AD);
    CheckExternalEvents(cs14, 0x198B);
    // MOV byte ptr [0xa44f],0x0 (19EF_1986 / 0x1B876)
    UInt8[DS, 0xA44F] = 0x0;
    CheckExternalEvents(cs14, 0x1991);
    // TEST word ptr [0xa44d],0x1 (19EF_198B / 0x1B87B)
    Alu16.And(UInt16[DS, 0xA44D], 0x1);
    CheckExternalEvents(cs14, 0x1993);
    // JZ 0x1000:b8e5 (19EF_1991 / 0x1B881)
    if(ZeroFlag) {
      goto label_19EF_19F5_1B8E5;
    }
    CheckExternalEvents(cs14, 0x1999);
    // TEST word ptr [0xa44b],0x1 (19EF_1993 / 0x1B883)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs14, 0x199B);
    // JZ 0x1000:b8a7 (19EF_1999 / 0x1B889)
    if(ZeroFlag) {
      goto label_19EF_19B7_1B8A7;
    }
    CheckExternalEvents(cs14, 0x199D);
    // MOV DH,byte ptr [BX] (19EF_199B / 0x1B88B)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs14, 0x19A2);
    // MOV byte ptr [0xa450],0x0 (19EF_199D / 0x1B88D)
    UInt8[DS, 0xA450] = 0x0;
    CheckExternalEvents(cs14, 0x19A7);
    // MOV byte ptr [0xa44f],0x1 (19EF_19A2 / 0x1B892)
    UInt8[DS, 0xA44F] = 0x1;
    CheckExternalEvents(cs14, 0x19AC);
    // MOV byte ptr [0xa451],0x1 (19EF_19A7 / 0x1B897)
    UInt8[DS, 0xA451] = 0x1;
    CheckExternalEvents(cs14, 0x19AF);
    // CALL 0x1000:b998 (19EF_19AC / 0x1B89C)
    NearCall(cs14, 0x19AF, unknown_19EF_1AA8_1B998);
    CheckExternalEvents(cs14, 0x19B0);
    // INC BX (19EF_19AF / 0x1B89F)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs14, 0x19B3);
    // MOV AX,[0xa452] (19EF_19B0 / 0x1B8A0)
    AX = UInt16[DS, 0xA452];
    CheckExternalEvents(cs14, 0x19B5);
    // SHR AX,0x1 (19EF_19B3 / 0x1B8A3)
    AX >>= 0x1;
    CheckExternalEvents(cs14, 0x19B7);
    // ADD DI,AX (19EF_19B5 / 0x1B8A5)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    label_19EF_19B7_1B8A7:
    CheckExternalEvents(cs14, 0x19BA);
    // MOV CX,0xd (19EF_19B7 / 0x1B8A7)
    CX = 0xD;
    label_19EF_19BA_1B8AA:
    CheckExternalEvents(cs14, 0x19BB);
    // PUSH CX (19EF_19BA / 0x1B8AA)
    Stack.Push16(CX);
    CheckExternalEvents(cs14, 0x19BD);
    // MOV DH,byte ptr [BX] (19EF_19BB / 0x1B8AB)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs14, 0x19C0);
    // CALL 0x1000:b9be (19EF_19BD / 0x1B8AD)
    NearCall(cs14, 0x19C0, unknown_19EF_1ACE_1B9BE);
    CheckExternalEvents(cs14, 0x19C4);
    // ADD DI,word ptr [0xa452] (19EF_19C0 / 0x1B8B0)
    DI += UInt16[DS, 0xA452];
    CheckExternalEvents(cs14, 0x19C5);
    // INC BX (19EF_19C4 / 0x1B8B4)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs14, 0x19C6);
    // POP CX (19EF_19C5 / 0x1B8B5)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x19C8);
    // LOOP 0x1000:b8aa (19EF_19C6 / 0x1B8B6)
    if(--CX != 0) {
      goto label_19EF_19BA_1B8AA;
    }
    CheckExternalEvents(cs14, 0x19CE);
    // TEST word ptr [0xa44b],0x1 (19EF_19C8 / 0x1B8B8)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs14, 0x19D0);
    // JNZ 0x1000:b8de (19EF_19CE / 0x1B8BE)
    if(!ZeroFlag) {
      goto label_19EF_19EE_1B8DE;
    }
    CheckExternalEvents(cs14, 0x19D2);
    // MOV DH,byte ptr [BX] (19EF_19D0 / 0x1B8C0)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs14, 0x19D4);
    // MOV DL,0x1 (19EF_19D2 / 0x1B8C2)
    DL = 0x1;
    CheckExternalEvents(cs14, 0x19D9);
    // MOV byte ptr [0xa44f],0x1 (19EF_19D4 / 0x1B8C4)
    UInt8[DS, 0xA44F] = 0x1;
    CheckExternalEvents(cs14, 0x19DE);
    // MOV byte ptr [0xa450],0x1 (19EF_19D9 / 0x1B8C9)
    UInt8[DS, 0xA450] = 0x1;
    CheckExternalEvents(cs14, 0x19E3);
    // MOV byte ptr [0xa451],0x1 (19EF_19DE / 0x1B8CE)
    UInt8[DS, 0xA451] = 0x1;
    CheckExternalEvents(cs14, 0x19E6);
    // CALL 0x1000:b998 (19EF_19E3 / 0x1B8D3)
    NearCall(cs14, 0x19E6, unknown_19EF_1AA8_1B998);
    CheckExternalEvents(cs14, 0x19E9);
    // MOV AX,[0xa452] (19EF_19E6 / 0x1B8D6)
    AX = UInt16[DS, 0xA452];
    CheckExternalEvents(cs14, 0x19EB);
    // SHR AX,0x1 (19EF_19E9 / 0x1B8D9)
    AX >>= 0x1;
    CheckExternalEvents(cs14, 0x19ED);
    // ADD DI,AX (19EF_19EB / 0x1B8DB)
    DI += AX;
    CheckExternalEvents(cs14, 0x19EE);
    // INC BX (19EF_19ED / 0x1B8DD)
    BX++;
    label_19EF_19EE_1B8DE:
    CheckExternalEvents(cs14, 0x19F1);
    // ADD BX,0xa (19EF_19EE / 0x1B8DE)
    BX += 0xA;
    CheckExternalEvents(cs14, 0x19F5);
    // ADD DI,word ptr [0xa456] (19EF_19F1 / 0x1B8E1)
    DI += UInt16[DS, 0xA456];
    label_19EF_19F5_1B8E5:
    CheckExternalEvents(cs14, 0x19F7);
    // XOR AL,AL (19EF_19F5 / 0x1B8E5)
    // AL ^= AL;
    AL = Alu8.Xor(AL, AL);
    CheckExternalEvents(cs14, 0x19FA);
    // MOV [0xa44f],AL (19EF_19F7 / 0x1B8E7)
    UInt8[DS, 0xA44F] = AL;
    CheckExternalEvents(cs14, 0x19FD);
    // MOV [0xa450],AL (19EF_19FA / 0x1B8EA)
    UInt8[DS, 0xA450] = AL;
    CheckExternalEvents(cs14, 0x1A00);
    // MOV [0xa451],AL (19EF_19FD / 0x1B8ED)
    UInt8[DS, 0xA451] = AL;
    CheckExternalEvents(cs14, 0x1A05);
    // MOV byte ptr [0xa458],0xc (19EF_1A00 / 0x1B8F0)
    UInt8[DS, 0xA458] = 0xC;
    label_19EF_1A05_1B8F5:
    CheckExternalEvents(cs14, 0x1A0B);
    // TEST word ptr [0xa44b],0x1 (19EF_1A05 / 0x1B8F5)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs14, 0x1A0D);
    // JZ 0x1000:b90f (19EF_1A0B / 0x1B8FB)
    if(ZeroFlag) {
      goto label_19EF_1A1F_1B90F;
    }
    CheckExternalEvents(cs14, 0x1A0F);
    // MOV DH,byte ptr [BX] (19EF_1A0D / 0x1B8FD)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs14, 0x1A14);
    // MOV byte ptr [0xa450],0x0 (19EF_1A0F / 0x1B8FF)
    UInt8[DS, 0xA450] = 0x0;
    CheckExternalEvents(cs14, 0x1A17);
    // CALL 0x1000:b998 (19EF_1A14 / 0x1B904)
    NearCall(cs14, 0x1A17, unknown_19EF_1AA8_1B998);
    CheckExternalEvents(cs14, 0x1A18);
    // INC BX (19EF_1A17 / 0x1B907)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs14, 0x1A1B);
    // MOV AX,[0xa452] (19EF_1A18 / 0x1B908)
    AX = UInt16[DS, 0xA452];
    CheckExternalEvents(cs14, 0x1A1D);
    // SHR AX,0x1 (19EF_1A1B / 0x1B90B)
    AX >>= 0x1;
    CheckExternalEvents(cs14, 0x1A1F);
    // ADD DI,AX (19EF_1A1D / 0x1B90D)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    label_19EF_1A1F_1B90F:
    CheckExternalEvents(cs14, 0x1A22);
    // MOV CX,0xd (19EF_1A1F / 0x1B90F)
    CX = 0xD;
    label_19EF_1A22_1B912:
    CheckExternalEvents(cs14, 0x1A24);
    // MOV DH,byte ptr [BX] (19EF_1A22 / 0x1B912)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs14, 0x1A25);
    // PUSH CX (19EF_1A24 / 0x1B914)
    Stack.Push16(CX);
    CheckExternalEvents(cs14, 0x1A28);
    // CALL 0x1000:b9e4 (19EF_1A25 / 0x1B915)
    NearCall(cs14, 0x1A28, unknown_19EF_1AF4_1B9E4);
    CheckExternalEvents(cs14, 0x1A29);
    // INC BX (19EF_1A28 / 0x1B918)
    BX++;
    CheckExternalEvents(cs14, 0x1A2D);
    // ADD DI,word ptr [0xa452] (19EF_1A29 / 0x1B919)
    // DI += UInt16[DS, 0xA452];
    DI = Alu16.Add(DI, UInt16[DS, 0xA452]);
    CheckExternalEvents(cs14, 0x1A2E);
    // POP CX (19EF_1A2D / 0x1B91D)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1A30);
    // LOOP 0x1000:b912 (19EF_1A2E / 0x1B91E)
    if(--CX != 0) {
      goto label_19EF_1A22_1B912;
    }
    CheckExternalEvents(cs14, 0x1A36);
    // TEST word ptr [0xa44b],0x1 (19EF_1A30 / 0x1B920)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs14, 0x1A38);
    // JNZ 0x1000:b93a (19EF_1A36 / 0x1B926)
    if(!ZeroFlag) {
      goto label_19EF_1A4A_1B93A;
    }
    CheckExternalEvents(cs14, 0x1A3A);
    // MOV DH,byte ptr [BX] (19EF_1A38 / 0x1B928)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs14, 0x1A3F);
    // MOV byte ptr [0xa450],0x1 (19EF_1A3A / 0x1B92A)
    UInt8[DS, 0xA450] = 0x1;
    CheckExternalEvents(cs14, 0x1A42);
    // CALL 0x1000:b998 (19EF_1A3F / 0x1B92F)
    NearCall(cs14, 0x1A42, unknown_19EF_1AA8_1B998);
    CheckExternalEvents(cs14, 0x1A43);
    // INC BX (19EF_1A42 / 0x1B932)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs14, 0x1A46);
    // MOV AX,[0xa452] (19EF_1A43 / 0x1B933)
    AX = UInt16[DS, 0xA452];
    CheckExternalEvents(cs14, 0x1A48);
    // SHR AX,0x1 (19EF_1A46 / 0x1B936)
    AX >>= 0x1;
    CheckExternalEvents(cs14, 0x1A4A);
    // ADD DI,AX (19EF_1A48 / 0x1B938)
    DI += AX;
    label_19EF_1A4A_1B93A:
    CheckExternalEvents(cs14, 0x1A4D);
    // ADD BX,0xa (19EF_1A4A / 0x1B93A)
    BX += 0xA;
    CheckExternalEvents(cs14, 0x1A51);
    // ADD DI,word ptr [0xa454] (19EF_1A4D / 0x1B93D)
    DI += UInt16[DS, 0xA454];
    CheckExternalEvents(cs14, 0x1A55);
    // DEC byte ptr [0xa458] (19EF_1A51 / 0x1B941)
    UInt8[DS, 0xA458] = Alu8.Dec(UInt8[DS, 0xA458]);
    CheckExternalEvents(cs14, 0x1A57);
    // JNZ 0x1000:b8f5 (19EF_1A55 / 0x1B945)
    if(!ZeroFlag) {
      goto label_19EF_1A05_1B8F5;
    }
    CheckExternalEvents(cs14, 0x1A5D);
    // TEST word ptr [0xa44d],0x1 (19EF_1A57 / 0x1B947)
    Alu16.And(UInt16[DS, 0xA44D], 0x1);
    CheckExternalEvents(cs14, 0x1A5F);
    // JNZ 0x1000:b991 (19EF_1A5D / 0x1B94D)
    if(!ZeroFlag) {
      goto label_19EF_1AA1_1B991;
    }
    CheckExternalEvents(cs14, 0x1A64);
    // MOV byte ptr [0xa44f],0x1 (19EF_1A5F / 0x1B94F)
    UInt8[DS, 0xA44F] = 0x1;
    CheckExternalEvents(cs14, 0x1A6A);
    // TEST word ptr [0xa44b],0x1 (19EF_1A64 / 0x1B954)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs14, 0x1A6C);
    // JZ 0x1000:b96e (19EF_1A6A / 0x1B95A)
    if(ZeroFlag) {
      goto label_19EF_1A7E_1B96E;
    }
    CheckExternalEvents(cs14, 0x1A6E);
    // MOV DH,byte ptr [BX] (19EF_1A6C / 0x1B95C)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs14, 0x1A73);
    // MOV byte ptr [0xa450],0x0 (19EF_1A6E / 0x1B95E)
    UInt8[DS, 0xA450] = 0x0;
    CheckExternalEvents(cs14, 0x1A76);
    // CALL 0x1000:b998 (19EF_1A73 / 0x1B963)
    NearCall(cs14, 0x1A76, unknown_19EF_1AA8_1B998);
    CheckExternalEvents(cs14, 0x1A77);
    // INC BX (19EF_1A76 / 0x1B966)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs14, 0x1A7A);
    // MOV AX,[0xa452] (19EF_1A77 / 0x1B967)
    AX = UInt16[DS, 0xA452];
    CheckExternalEvents(cs14, 0x1A7C);
    // SHR AX,0x1 (19EF_1A7A / 0x1B96A)
    AX >>= 0x1;
    CheckExternalEvents(cs14, 0x1A7E);
    // ADD DI,AX (19EF_1A7C / 0x1B96C)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    label_19EF_1A7E_1B96E:
    CheckExternalEvents(cs14, 0x1A81);
    // MOV CX,0xd (19EF_1A7E / 0x1B96E)
    CX = 0xD;
    label_19EF_1A81_1B971:
    CheckExternalEvents(cs14, 0x1A82);
    // PUSH CX (19EF_1A81 / 0x1B971)
    Stack.Push16(CX);
    CheckExternalEvents(cs14, 0x1A84);
    // MOV DH,byte ptr [BX] (19EF_1A82 / 0x1B972)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs14, 0x1A87);
    // CALL 0x1000:b9e4 (19EF_1A84 / 0x1B974)
    NearCall(cs14, 0x1A87, unknown_19EF_1AF4_1B9E4);
    CheckExternalEvents(cs14, 0x1A8B);
    // ADD DI,word ptr [0xa452] (19EF_1A87 / 0x1B977)
    DI += UInt16[DS, 0xA452];
    CheckExternalEvents(cs14, 0x1A8C);
    // INC BX (19EF_1A8B / 0x1B97B)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs14, 0x1A8D);
    // POP CX (19EF_1A8C / 0x1B97C)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1A8F);
    // LOOP 0x1000:b971 (19EF_1A8D / 0x1B97D)
    if(--CX != 0) {
      goto label_19EF_1A81_1B971;
    }
    CheckExternalEvents(cs14, 0x1A95);
    // TEST word ptr [0xa44b],0x1 (19EF_1A8F / 0x1B97F)
    Alu16.And(UInt16[DS, 0xA44B], 0x1);
    CheckExternalEvents(cs14, 0x1A97);
    // JNZ 0x1000:b991 (19EF_1A95 / 0x1B985)
    if(!ZeroFlag) {
      goto label_19EF_1AA1_1B991;
    }
    CheckExternalEvents(cs14, 0x1A99);
    // MOV DH,byte ptr [BX] (19EF_1A97 / 0x1B987)
    DH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs14, 0x1A9E);
    // MOV byte ptr [0xa450],0x1 (19EF_1A99 / 0x1B989)
    UInt8[DS, 0xA450] = 0x1;
    CheckExternalEvents(cs14, 0x1AA1);
    // CALL 0x1000:b998 (19EF_1A9E / 0x1B98E)
    NearCall(cs14, 0x1AA1, unknown_19EF_1AA8_1B998);
    label_19EF_1AA1_1B991:
    CheckExternalEvents(cs14, 0x1AA2);
    // POP ES (19EF_1AA1 / 0x1B991)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1AA3);
    // POP BP (19EF_1AA2 / 0x1B992)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1AA4);
    // POP DS (19EF_1AA3 / 0x1B993)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1AA5);
    // POP SI (19EF_1AA4 / 0x1B994)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1AA6);
    // POP DI (19EF_1AA5 / 0x1B995)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1AA7);
    // POP BP (19EF_1AA6 / 0x1B996)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1AA8);
    // RETF  (19EF_1AA7 / 0x1B997)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1AA8_1B998(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1AA8_1B998:
    CheckExternalEvents(cs14, 0x1AAA);
    // MOV BP,BX (19EF_1AA8 / 0x1B998)
    BP = BX;
    CheckExternalEvents(cs14, 0x1AAB);
    // PUSH DI (19EF_1AAA / 0x1B99A)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1AAD);
    // XOR DL,DL (19EF_1AAB / 0x1B99B)
    DL = 0;
    CheckExternalEvents(cs14, 0x1AB2);
    // CMP word ptr [0xb764],0x2 (19EF_1AAD / 0x1B99D)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x1AB4);
    // JZ 0x1000:b9b7 (19EF_1AB2 / 0x1B9A2)
    if(ZeroFlag) {
      goto label_19EF_1AC7_1B9B7;
    }
    CheckExternalEvents(cs14, 0x1AB6);
    // SHR DX,0x1 (19EF_1AB4 / 0x1B9A4)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1ABA);
    // ADD DX,word ptr [0x26e] (19EF_1AB6 / 0x1B9A6)
    // DX += UInt16[DS, 0x26E];
    DX = Alu16.Add(DX, UInt16[DS, 0x26E]);
    CheckExternalEvents(cs14, 0x1ABC);
    // MOV SI,DX (19EF_1ABA / 0x1B9AA)
    SI = DX;
    CheckExternalEvents(cs14, 0x1AC0);
    // MOV DX,word ptr [0x270] (19EF_1ABC / 0x1B9AC)
    DX = UInt16[DS, 0x270];
    CheckExternalEvents(cs14, 0x1AC3);
    // CALL 0x1000:baec (19EF_1AC0 / 0x1B9B0)
    NearCall(cs14, 0x1AC3, unknown_19EF_1BFC_1BAEC);
    CheckExternalEvents(cs14, 0x1AC4);
    // POP DI (19EF_1AC3 / 0x1B9B3)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1AC6);
    // MOV BX,BP (19EF_1AC4 / 0x1B9B4)
    BX = BP;
    CheckExternalEvents(cs14, 0x1AC7);
    // RET  (19EF_1AC6 / 0x1B9B6)
    return NearRet();
    label_19EF_1AC7_1B9B7:
    CheckExternalEvents(cs14, 0x1ACA);
    // CALL 0x1000:bb73 (19EF_1AC7 / 0x1B9B7)
    NearCall(cs14, 0x1ACA, unknown_19EF_1C83_1BB73);
    CheckExternalEvents(cs14, 0x1ACB);
    // POP DI (19EF_1ACA / 0x1B9BA)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1ACD);
    // MOV BX,BP (19EF_1ACB / 0x1B9BB)
    BX = BP;
    CheckExternalEvents(cs14, 0x1ACE);
    // RET  (19EF_1ACD / 0x1B9BD)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1ACE_1B9BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1ACE_1B9BE:
    CheckExternalEvents(cs14, 0x1AD0);
    // MOV BP,BX (19EF_1ACE / 0x1B9BE)
    BP = BX;
    CheckExternalEvents(cs14, 0x1AD1);
    // PUSH DI (19EF_1AD0 / 0x1B9C0)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1AD3);
    // XOR DL,DL (19EF_1AD1 / 0x1B9C1)
    DL = 0;
    CheckExternalEvents(cs14, 0x1AD8);
    // CMP word ptr [0xb764],0x2 (19EF_1AD3 / 0x1B9C3)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x1ADA);
    // JZ 0x1000:b9dd (19EF_1AD8 / 0x1B9C8)
    if(ZeroFlag) {
      goto label_19EF_1AED_1B9DD;
    }
    CheckExternalEvents(cs14, 0x1ADC);
    // SHR DX,0x1 (19EF_1ADA / 0x1B9CA)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1AE0);
    // ADD DX,word ptr [0x26e] (19EF_1ADC / 0x1B9CC)
    // DX += UInt16[DS, 0x26E];
    DX = Alu16.Add(DX, UInt16[DS, 0x26E]);
    CheckExternalEvents(cs14, 0x1AE2);
    // MOV SI,DX (19EF_1AE0 / 0x1B9D0)
    SI = DX;
    CheckExternalEvents(cs14, 0x1AE6);
    // MOV DX,word ptr [0x270] (19EF_1AE2 / 0x1B9D2)
    DX = UInt16[DS, 0x270];
    CheckExternalEvents(cs14, 0x1AE9);
    // CALL 0x1000:ba84 (19EF_1AE6 / 0x1B9D6)
    NearCall(cs14, 0x1AE9, unknown_19EF_1B94_1BA84);
    CheckExternalEvents(cs14, 0x1AEA);
    // POP DI (19EF_1AE9 / 0x1B9D9)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1AEC);
    // MOV BX,BP (19EF_1AEA / 0x1B9DA)
    BX = BP;
    CheckExternalEvents(cs14, 0x1AED);
    // RET  (19EF_1AEC / 0x1B9DC)
    return NearRet();
    label_19EF_1AED_1B9DD:
    CheckExternalEvents(cs14, 0x1AF0);
    // CALL 0x1000:bacf (19EF_1AED / 0x1B9DD)
    NearCall(cs14, 0x1AF0, unknown_19EF_1BDF_1BACF);
    CheckExternalEvents(cs14, 0x1AF1);
    // POP DI (19EF_1AF0 / 0x1B9E0)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1AF3);
    // MOV BX,BP (19EF_1AF1 / 0x1B9E1)
    BX = BP;
    CheckExternalEvents(cs14, 0x1AF4);
    // RET  (19EF_1AF3 / 0x1B9E3)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1AF4_1B9E4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1AF4_1B9E4:
    CheckExternalEvents(cs14, 0x1AF6);
    // MOV BP,BX (19EF_1AF4 / 0x1B9E4)
    BP = BX;
    CheckExternalEvents(cs14, 0x1AF7);
    // PUSH DI (19EF_1AF6 / 0x1B9E6)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1AF9);
    // XOR DL,DL (19EF_1AF7 / 0x1B9E7)
    DL = 0;
    CheckExternalEvents(cs14, 0x1AFE);
    // CMP word ptr [0xb764],0x2 (19EF_1AF9 / 0x1B9E9)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x1B00);
    // JZ 0x1000:ba03 (19EF_1AFE / 0x1B9EE)
    if(ZeroFlag) {
      goto label_19EF_1B13_1BA03;
    }
    CheckExternalEvents(cs14, 0x1B02);
    // SHR DX,0x1 (19EF_1B00 / 0x1B9F0)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1B06);
    // ADD DX,word ptr [0x26e] (19EF_1B02 / 0x1B9F2)
    // DX += UInt16[DS, 0x26E];
    DX = Alu16.Add(DX, UInt16[DS, 0x26E]);
    CheckExternalEvents(cs14, 0x1B08);
    // MOV SI,DX (19EF_1B06 / 0x1B9F6)
    SI = DX;
    CheckExternalEvents(cs14, 0x1B0C);
    // MOV DX,word ptr [0x270] (19EF_1B08 / 0x1B9F8)
    DX = UInt16[DS, 0x270];
    CheckExternalEvents(cs14, 0x1B0F);
    // CALL 0x1000:ba0a (19EF_1B0C / 0x1B9FC)
    NearCall(cs14, 0x1B0F, unknown_19EF_1B1A_1BA0A);
    CheckExternalEvents(cs14, 0x1B10);
    // POP DI (19EF_1B0F / 0x1B9FF)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1B12);
    // MOV BX,BP (19EF_1B10 / 0x1BA00)
    BX = BP;
    CheckExternalEvents(cs14, 0x1B13);
    // RET  (19EF_1B12 / 0x1BA02)
    return NearRet();
    label_19EF_1B13_1BA03:
    CheckExternalEvents(cs14, 0x1B16);
    // CALL 0x1000:ba61 (19EF_1B13 / 0x1BA03)
    NearCall(cs14, 0x1B16, unknown_19EF_1B71_1BA61);
    CheckExternalEvents(cs14, 0x1B17);
    // POP DI (19EF_1B16 / 0x1BA06)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1B19);
    // MOV BX,BP (19EF_1B17 / 0x1BA07)
    BX = BP;
    CheckExternalEvents(cs14, 0x1B1A);
    // RET  (19EF_1B19 / 0x1BA09)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1B1A_1BA0A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1B1A_1BA0A:
    CheckExternalEvents(cs14, 0x1B1F);
    // CMP word ptr [0xb764],0x0 (19EF_1B1A / 0x1BA0A)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x1B21);
    // JZ 0x1000:ba44 (19EF_1B1F / 0x1BA0F)
    if(ZeroFlag) {
      goto label_19EF_1B54_1BA44;
    }
    CheckExternalEvents(cs14, 0x1B24);
    // MOV CX,0x4 (19EF_1B21 / 0x1BA11)
    CX = 0x4;
    CheckExternalEvents(cs14, 0x1B29);
    // CMP byte ptr [0xa44f],0x0 (19EF_1B24 / 0x1BA14)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs14, 0x1B2B);
    // JZ 0x1000:ba1d (19EF_1B29 / 0x1BA19)
    if(ZeroFlag) {
      goto label_19EF_1B2D_1BA1D;
    }
    CheckExternalEvents(cs14, 0x1B2D);
    // SHR CX,0x1 (19EF_1B2B / 0x1BA1B)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_19EF_1B2D_1BA1D:
    CheckExternalEvents(cs14, 0x1B2E);
    // PUSH DS (19EF_1B2D / 0x1BA1D)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1B30);
    // MOV DS,DX (19EF_1B2E / 0x1BA1E)
    DS = DX;
    label_19EF_1B30_1BA20:
    CheckExternalEvents(cs14, 0x1B31);
    // MOVSW ES:DI,SI (19EF_1B30 / 0x1BA20)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B32);
    // MOVSW ES:DI,SI (19EF_1B31 / 0x1BA21)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B33);
    // MOVSW ES:DI,SI (19EF_1B32 / 0x1BA22)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B34);
    // MOVSW ES:DI,SI (19EF_1B33 / 0x1BA23)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B38);
    // ADD DI,0x98 (19EF_1B34 / 0x1BA24)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs14, 0x1B39);
    // MOVSW ES:DI,SI (19EF_1B38 / 0x1BA28)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B3A);
    // MOVSW ES:DI,SI (19EF_1B39 / 0x1BA29)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B3B);
    // MOVSW ES:DI,SI (19EF_1B3A / 0x1BA2A)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B3C);
    // MOVSW ES:DI,SI (19EF_1B3B / 0x1BA2B)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B40);
    // ADD DI,0x98 (19EF_1B3C / 0x1BA2C)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs14, 0x1B41);
    // MOVSW ES:DI,SI (19EF_1B40 / 0x1BA30)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B42);
    // MOVSW ES:DI,SI (19EF_1B41 / 0x1BA31)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B43);
    // MOVSW ES:DI,SI (19EF_1B42 / 0x1BA32)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B44);
    // MOVSW ES:DI,SI (19EF_1B43 / 0x1BA33)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B48);
    // ADD DI,0x98 (19EF_1B44 / 0x1BA34)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs14, 0x1B49);
    // MOVSW ES:DI,SI (19EF_1B48 / 0x1BA38)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B4A);
    // MOVSW ES:DI,SI (19EF_1B49 / 0x1BA39)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B4B);
    // MOVSW ES:DI,SI (19EF_1B4A / 0x1BA3A)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B4C);
    // MOVSW ES:DI,SI (19EF_1B4B / 0x1BA3B)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B50);
    // ADD DI,0x98 (19EF_1B4C / 0x1BA3C)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs14, 0x1B52);
    // LOOP 0x1000:ba20 (19EF_1B50 / 0x1BA40)
    if(--CX != 0) {
      goto label_19EF_1B30_1BA20;
    }
    CheckExternalEvents(cs14, 0x1B53);
    // POP DS (19EF_1B52 / 0x1BA42)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1B54);
    // RET  (19EF_1B53 / 0x1BA43)
    return NearRet();
    label_19EF_1B54_1BA44:
    CheckExternalEvents(cs14, 0x1B57);
    // MOV CX,0x8 (19EF_1B54 / 0x1BA44)
    CX = 0x8;
    CheckExternalEvents(cs14, 0x1B5C);
    // CMP byte ptr [0xa44f],0x0 (19EF_1B57 / 0x1BA47)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs14, 0x1B5E);
    // JZ 0x1000:ba50 (19EF_1B5C / 0x1BA4C)
    if(ZeroFlag) {
      goto label_19EF_1B60_1BA50;
    }
    CheckExternalEvents(cs14, 0x1B60);
    // SHR CX,0x1 (19EF_1B5E / 0x1BA4E)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_19EF_1B60_1BA50:
    CheckExternalEvents(cs14, 0x1B61);
    // PUSH DS (19EF_1B60 / 0x1BA50)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1B63);
    // MOV DS,DX (19EF_1B61 / 0x1BA51)
    DS = DX;
    label_19EF_1B63_1BA53:
    CheckExternalEvents(cs14, 0x1B64);
    // MOVSW ES:DI,SI (19EF_1B63 / 0x1BA53)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B65);
    // MOVSW ES:DI,SI (19EF_1B64 / 0x1BA54)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B68);
    // ADD DI,0x4c (19EF_1B65 / 0x1BA55)
    // DI += 0x4C;
    DI = Alu16.Add(DI, 0x4C);
    CheckExternalEvents(cs14, 0x1B69);
    // MOVSW ES:DI,SI (19EF_1B68 / 0x1BA58)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B6A);
    // MOVSW ES:DI,SI (19EF_1B69 / 0x1BA59)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1B6D);
    // ADD DI,0x4c (19EF_1B6A / 0x1BA5A)
    // DI += 0x4C;
    DI = Alu16.Add(DI, 0x4C);
    CheckExternalEvents(cs14, 0x1B6F);
    // LOOP 0x1000:ba53 (19EF_1B6D / 0x1BA5D)
    if(--CX != 0) {
      goto label_19EF_1B63_1BA53;
    }
    CheckExternalEvents(cs14, 0x1B70);
    // POP DS (19EF_1B6F / 0x1BA5F)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1B71);
    // RET  (19EF_1B70 / 0x1BA60)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1B71_1BA61(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1B71_1BA61:
    CheckExternalEvents(cs14, 0x1B73);
    // SHR DX,0x1 (19EF_1B71 / 0x1BA61)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1B75);
    // SHR DX,0x1 (19EF_1B73 / 0x1BA63)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1B77);
    // SHR DX,0x1 (19EF_1B75 / 0x1BA65)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs14, 0x1B79);
    // MOV SI,DX (19EF_1B77 / 0x1BA67)
    SI = DX;
    CheckExternalEvents(cs14, 0x1B7C);
    // MOV CX,0x10 (19EF_1B79 / 0x1BA69)
    CX = 0x10;
    CheckExternalEvents(cs14, 0x1B81);
    // CMP byte ptr [0xa44f],0x0 (19EF_1B7C / 0x1BA6C)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs14, 0x1B83);
    // JZ 0x1000:ba75 (19EF_1B81 / 0x1BA71)
    if(ZeroFlag) {
      goto label_19EF_1B85_1BA75;
    }
    CheckExternalEvents(cs14, 0x1B85);
    // SHR CX,0x1 (19EF_1B83 / 0x1BA73)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_19EF_1B85_1BA75:
    CheckExternalEvents(cs14, 0x1B86);
    // PUSH DS (19EF_1B85 / 0x1BA75)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1B89);
    // MOV AX,0xa400 (19EF_1B86 / 0x1BA76)
    AX = 0xA400;
    CheckExternalEvents(cs14, 0x1B8B);
    // MOV DS,AX (19EF_1B89 / 0x1BA79)
    DS = AX;
    label_19EF_1B8B_1BA7B:
    CheckExternalEvents(cs14, 0x1B8C);
    // MOVSB ES:DI,SI (19EF_1B8B / 0x1BA7B)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x1B8D);
    // MOVSB ES:DI,SI (19EF_1B8C / 0x1BA7C)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x1B90);
    // ADD DI,0x26 (19EF_1B8D / 0x1BA7D)
    // DI += 0x26;
    DI = Alu16.Add(DI, 0x26);
    CheckExternalEvents(cs14, 0x1B92);
    // LOOP 0x1000:ba7b (19EF_1B90 / 0x1BA80)
    if(--CX != 0) {
      goto label_19EF_1B8B_1BA7B;
    }
    CheckExternalEvents(cs14, 0x1B93);
    // POP DS (19EF_1B92 / 0x1BA82)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1B94);
    // RET  (19EF_1B93 / 0x1BA83)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1B94_1BA84(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1B94_1BA84:
    CheckExternalEvents(cs14, 0x1B99);
    // CMP word ptr [0xb764],0x0 (19EF_1B94 / 0x1BA84)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x1B9B);
    // JZ 0x1000:bab8 (19EF_1B99 / 0x1BA89)
    if(ZeroFlag) {
      goto label_19EF_1BC8_1BAB8;
    }
    CheckExternalEvents(cs14, 0x1B9E);
    // ADD SI,0x40 (19EF_1B9B / 0x1BA8B)
    // SI += 0x40;
    SI = Alu16.Add(SI, 0x40);
    CheckExternalEvents(cs14, 0x1BA1);
    // MOV CX,0x2 (19EF_1B9E / 0x1BA8E)
    CX = 0x2;
    CheckExternalEvents(cs14, 0x1BA2);
    // PUSH DS (19EF_1BA1 / 0x1BA91)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1BA4);
    // MOV DS,DX (19EF_1BA2 / 0x1BA92)
    DS = DX;
    label_19EF_1BA4_1BA94:
    CheckExternalEvents(cs14, 0x1BA5);
    // MOVSW ES:DI,SI (19EF_1BA4 / 0x1BA94)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BA6);
    // MOVSW ES:DI,SI (19EF_1BA5 / 0x1BA95)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BA7);
    // MOVSW ES:DI,SI (19EF_1BA6 / 0x1BA96)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BA8);
    // MOVSW ES:DI,SI (19EF_1BA7 / 0x1BA97)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BAC);
    // ADD DI,0x98 (19EF_1BA8 / 0x1BA98)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs14, 0x1BAD);
    // MOVSW ES:DI,SI (19EF_1BAC / 0x1BA9C)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BAE);
    // MOVSW ES:DI,SI (19EF_1BAD / 0x1BA9D)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BAF);
    // MOVSW ES:DI,SI (19EF_1BAE / 0x1BA9E)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BB0);
    // MOVSW ES:DI,SI (19EF_1BAF / 0x1BA9F)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BB4);
    // ADD DI,0x98 (19EF_1BB0 / 0x1BAA0)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs14, 0x1BB5);
    // MOVSW ES:DI,SI (19EF_1BB4 / 0x1BAA4)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BB6);
    // MOVSW ES:DI,SI (19EF_1BB5 / 0x1BAA5)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BB7);
    // MOVSW ES:DI,SI (19EF_1BB6 / 0x1BAA6)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BB8);
    // MOVSW ES:DI,SI (19EF_1BB7 / 0x1BAA7)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BBC);
    // ADD DI,0x98 (19EF_1BB8 / 0x1BAA8)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs14, 0x1BBD);
    // MOVSW ES:DI,SI (19EF_1BBC / 0x1BAAC)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BBE);
    // MOVSW ES:DI,SI (19EF_1BBD / 0x1BAAD)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BBF);
    // MOVSW ES:DI,SI (19EF_1BBE / 0x1BAAE)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BC0);
    // MOVSW ES:DI,SI (19EF_1BBF / 0x1BAAF)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BC4);
    // ADD DI,0x98 (19EF_1BC0 / 0x1BAB0)
    // DI += 0x98;
    DI = Alu16.Add(DI, 0x98);
    CheckExternalEvents(cs14, 0x1BC6);
    // LOOP 0x1000:ba94 (19EF_1BC4 / 0x1BAB4)
    if(--CX != 0) {
      goto label_19EF_1BA4_1BA94;
    }
    CheckExternalEvents(cs14, 0x1BC7);
    // POP DS (19EF_1BC6 / 0x1BAB6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1BC8);
    // RET  (19EF_1BC7 / 0x1BAB7)
    return NearRet();
    label_19EF_1BC8_1BAB8:
    CheckExternalEvents(cs14, 0x1BCB);
    // ADD SI,0x20 (19EF_1BC8 / 0x1BAB8)
    // SI += 0x20;
    SI = Alu16.Add(SI, 0x20);
    CheckExternalEvents(cs14, 0x1BCE);
    // MOV CX,0x4 (19EF_1BCB / 0x1BABB)
    CX = 0x4;
    CheckExternalEvents(cs14, 0x1BCF);
    // PUSH DS (19EF_1BCE / 0x1BABE)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1BD1);
    // MOV DS,DX (19EF_1BCF / 0x1BABF)
    DS = DX;
    label_19EF_1BD1_1BAC1:
    CheckExternalEvents(cs14, 0x1BD2);
    // MOVSW ES:DI,SI (19EF_1BD1 / 0x1BAC1)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BD3);
    // MOVSW ES:DI,SI (19EF_1BD2 / 0x1BAC2)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BD6);
    // ADD DI,0x4c (19EF_1BD3 / 0x1BAC3)
    // DI += 0x4C;
    DI = Alu16.Add(DI, 0x4C);
    CheckExternalEvents(cs14, 0x1BD7);
    // MOVSW ES:DI,SI (19EF_1BD6 / 0x1BAC6)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BD8);
    // MOVSW ES:DI,SI (19EF_1BD7 / 0x1BAC7)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1BDB);
    // ADD DI,0x4c (19EF_1BD8 / 0x1BAC8)
    // DI += 0x4C;
    DI = Alu16.Add(DI, 0x4C);
    CheckExternalEvents(cs14, 0x1BDD);
    // LOOP 0x1000:bac1 (19EF_1BDB / 0x1BACB)
    if(--CX != 0) {
      goto label_19EF_1BD1_1BAC1;
    }
    CheckExternalEvents(cs14, 0x1BDE);
    // POP DS (19EF_1BDD / 0x1BACD)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1BDF);
    // RET  (19EF_1BDE / 0x1BACE)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1BDF_1BACF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1BDF_1BACF:
    CheckExternalEvents(cs14, 0x1BE1);
    // SHR DX,0x1 (19EF_1BDF / 0x1BACF)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1BE3);
    // SHR DX,0x1 (19EF_1BE1 / 0x1BAD1)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1BE5);
    // SHR DX,0x1 (19EF_1BE3 / 0x1BAD3)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1BE8);
    // ADD DX,0x10 (19EF_1BE5 / 0x1BAD5)
    // DX += 0x10;
    DX = Alu16.Add(DX, 0x10);
    CheckExternalEvents(cs14, 0x1BEA);
    // MOV SI,DX (19EF_1BE8 / 0x1BAD8)
    SI = DX;
    CheckExternalEvents(cs14, 0x1BED);
    // MOV CX,0x8 (19EF_1BEA / 0x1BADA)
    CX = 0x8;
    CheckExternalEvents(cs14, 0x1BEE);
    // PUSH DS (19EF_1BED / 0x1BADD)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1BF1);
    // MOV AX,0xa400 (19EF_1BEE / 0x1BADE)
    AX = 0xA400;
    CheckExternalEvents(cs14, 0x1BF3);
    // MOV DS,AX (19EF_1BF1 / 0x1BAE1)
    DS = AX;
    label_19EF_1BF3_1BAE3:
    CheckExternalEvents(cs14, 0x1BF4);
    // MOVSB ES:DI,SI (19EF_1BF3 / 0x1BAE3)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x1BF5);
    // MOVSB ES:DI,SI (19EF_1BF4 / 0x1BAE4)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x1BF8);
    // ADD DI,0x26 (19EF_1BF5 / 0x1BAE5)
    // DI += 0x26;
    DI = Alu16.Add(DI, 0x26);
    CheckExternalEvents(cs14, 0x1BFA);
    // LOOP 0x1000:bae3 (19EF_1BF8 / 0x1BAE8)
    if(--CX != 0) {
      goto label_19EF_1BF3_1BAE3;
    }
    CheckExternalEvents(cs14, 0x1BFB);
    // POP DS (19EF_1BFA / 0x1BAEA)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1BFC);
    // RET  (19EF_1BFB / 0x1BAEB)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1BFC_1BAEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1BFC_1BAEC:
    CheckExternalEvents(cs14, 0x1C01);
    // CMP word ptr [0xb764],0x0 (19EF_1BFC / 0x1BAEC)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x1C03);
    // JZ 0x1000:bb3e (19EF_1C01 / 0x1BAF1)
    if(ZeroFlag) {
      goto label_19EF_1C4E_1BB3E;
    }
    CheckExternalEvents(cs14, 0x1C08);
    // CMP byte ptr [0xa451],0x0 (19EF_1C03 / 0x1BAF3)
    Alu8.Sub(UInt8[DS, 0xA451], 0x0);
    CheckExternalEvents(cs14, 0x1C0A);
    // JZ 0x1000:bafd (19EF_1C08 / 0x1BAF8)
    if(ZeroFlag) {
      goto label_19EF_1C0D_1BAFD;
    }
    CheckExternalEvents(cs14, 0x1C0D);
    // ADD SI,0x40 (19EF_1C0A / 0x1BAFA)
    SI += 0x40;
    label_19EF_1C0D_1BAFD:
    CheckExternalEvents(cs14, 0x1C12);
    // CMP byte ptr [0xa450],0x0 (19EF_1C0D / 0x1BAFD)
    Alu8.Sub(UInt8[DS, 0xA450], 0x0);
    CheckExternalEvents(cs14, 0x1C14);
    // JNZ 0x1000:bb07 (19EF_1C12 / 0x1BB02)
    if(!ZeroFlag) {
      goto label_19EF_1C17_1BB07;
    }
    CheckExternalEvents(cs14, 0x1C17);
    // ADD SI,0x4 (19EF_1C14 / 0x1BB04)
    // SI += 0x4;
    SI = Alu16.Add(SI, 0x4);
    label_19EF_1C17_1BB07:
    CheckExternalEvents(cs14, 0x1C1A);
    // MOV CX,0x4 (19EF_1C17 / 0x1BB07)
    CX = 0x4;
    CheckExternalEvents(cs14, 0x1C1F);
    // CMP byte ptr [0xa44f],0x0 (19EF_1C1A / 0x1BB0A)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs14, 0x1C21);
    // JZ 0x1000:bb13 (19EF_1C1F / 0x1BB0F)
    if(ZeroFlag) {
      goto label_19EF_1C23_1BB13;
    }
    CheckExternalEvents(cs14, 0x1C23);
    // SHR CX,0x1 (19EF_1C21 / 0x1BB11)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_19EF_1C23_1BB13:
    CheckExternalEvents(cs14, 0x1C24);
    // PUSH DS (19EF_1C23 / 0x1BB13)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1C26);
    // MOV DS,DX (19EF_1C24 / 0x1BB14)
    DS = DX;
    label_19EF_1C26_1BB16:
    CheckExternalEvents(cs14, 0x1C27);
    // MOVSW ES:DI,SI (19EF_1C26 / 0x1BB16)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1C28);
    // MOVSW ES:DI,SI (19EF_1C27 / 0x1BB17)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1C2B);
    // ADD SI,0x4 (19EF_1C28 / 0x1BB18)
    SI += 0x4;
    CheckExternalEvents(cs14, 0x1C2F);
    // ADD DI,0x9c (19EF_1C2B / 0x1BB1B)
    // DI += 0x9C;
    DI = Alu16.Add(DI, 0x9C);
    CheckExternalEvents(cs14, 0x1C30);
    // MOVSW ES:DI,SI (19EF_1C2F / 0x1BB1F)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1C31);
    // MOVSW ES:DI,SI (19EF_1C30 / 0x1BB20)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1C34);
    // ADD SI,0x4 (19EF_1C31 / 0x1BB21)
    SI += 0x4;
    CheckExternalEvents(cs14, 0x1C38);
    // ADD DI,0x9c (19EF_1C34 / 0x1BB24)
    // DI += 0x9C;
    DI = Alu16.Add(DI, 0x9C);
    CheckExternalEvents(cs14, 0x1C39);
    // MOVSW ES:DI,SI (19EF_1C38 / 0x1BB28)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1C3A);
    // MOVSW ES:DI,SI (19EF_1C39 / 0x1BB29)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1C3D);
    // ADD SI,0x4 (19EF_1C3A / 0x1BB2A)
    SI += 0x4;
    CheckExternalEvents(cs14, 0x1C41);
    // ADD DI,0x9c (19EF_1C3D / 0x1BB2D)
    // DI += 0x9C;
    DI = Alu16.Add(DI, 0x9C);
    CheckExternalEvents(cs14, 0x1C42);
    // MOVSW ES:DI,SI (19EF_1C41 / 0x1BB31)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1C43);
    // MOVSW ES:DI,SI (19EF_1C42 / 0x1BB32)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1C46);
    // ADD SI,0x4 (19EF_1C43 / 0x1BB33)
    SI += 0x4;
    CheckExternalEvents(cs14, 0x1C4A);
    // ADD DI,0x9c (19EF_1C46 / 0x1BB36)
    // DI += 0x9C;
    DI = Alu16.Add(DI, 0x9C);
    CheckExternalEvents(cs14, 0x1C4C);
    // LOOP 0x1000:bb16 (19EF_1C4A / 0x1BB3A)
    if(--CX != 0) {
      goto label_19EF_1C26_1BB16;
    }
    CheckExternalEvents(cs14, 0x1C4D);
    // POP DS (19EF_1C4C / 0x1BB3C)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1C4E);
    // RET  (19EF_1C4D / 0x1BB3D)
    return NearRet();
    label_19EF_1C4E_1BB3E:
    CheckExternalEvents(cs14, 0x1C53);
    // CMP byte ptr [0xa451],0x0 (19EF_1C4E / 0x1BB3E)
    Alu8.Sub(UInt8[DS, 0xA451], 0x0);
    CheckExternalEvents(cs14, 0x1C55);
    // JZ 0x1000:bb48 (19EF_1C53 / 0x1BB43)
    if(ZeroFlag) {
      goto label_19EF_1C58_1BB48;
    }
    CheckExternalEvents(cs14, 0x1C58);
    // ADD SI,0x20 (19EF_1C55 / 0x1BB45)
    SI += 0x20;
    label_19EF_1C58_1BB48:
    CheckExternalEvents(cs14, 0x1C5D);
    // CMP byte ptr [0xa450],0x0 (19EF_1C58 / 0x1BB48)
    Alu8.Sub(UInt8[DS, 0xA450], 0x0);
    CheckExternalEvents(cs14, 0x1C5F);
    // JNZ 0x1000:bb52 (19EF_1C5D / 0x1BB4D)
    if(!ZeroFlag) {
      goto label_19EF_1C62_1BB52;
    }
    CheckExternalEvents(cs14, 0x1C62);
    // ADD SI,0x2 (19EF_1C5F / 0x1BB4F)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    label_19EF_1C62_1BB52:
    CheckExternalEvents(cs14, 0x1C65);
    // MOV CX,0x8 (19EF_1C62 / 0x1BB52)
    CX = 0x8;
    CheckExternalEvents(cs14, 0x1C6A);
    // CMP byte ptr [0xa44f],0x0 (19EF_1C65 / 0x1BB55)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs14, 0x1C6C);
    // JZ 0x1000:bb5e (19EF_1C6A / 0x1BB5A)
    if(ZeroFlag) {
      goto label_19EF_1C6E_1BB5E;
    }
    CheckExternalEvents(cs14, 0x1C6E);
    // SHR CX,0x1 (19EF_1C6C / 0x1BB5C)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_19EF_1C6E_1BB5E:
    CheckExternalEvents(cs14, 0x1C6F);
    // PUSH DS (19EF_1C6E / 0x1BB5E)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1C71);
    // MOV DS,DX (19EF_1C6F / 0x1BB5F)
    DS = DX;
    label_19EF_1C71_1BB61:
    CheckExternalEvents(cs14, 0x1C72);
    // MOVSW ES:DI,SI (19EF_1C71 / 0x1BB61)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1C75);
    // ADD DI,0x4e (19EF_1C72 / 0x1BB62)
    DI += 0x4E;
    CheckExternalEvents(cs14, 0x1C78);
    // ADD SI,0x2 (19EF_1C75 / 0x1BB65)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs14, 0x1C79);
    // MOVSW ES:DI,SI (19EF_1C78 / 0x1BB68)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1C7C);
    // ADD DI,0x4e (19EF_1C79 / 0x1BB69)
    DI += 0x4E;
    CheckExternalEvents(cs14, 0x1C7F);
    // ADD SI,0x2 (19EF_1C7C / 0x1BB6C)
    // SI += 0x2;
    SI = Alu16.Add(SI, 0x2);
    CheckExternalEvents(cs14, 0x1C81);
    // LOOP 0x1000:bb61 (19EF_1C7F / 0x1BB6F)
    if(--CX != 0) {
      goto label_19EF_1C71_1BB61;
    }
    CheckExternalEvents(cs14, 0x1C82);
    // POP DS (19EF_1C81 / 0x1BB71)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1C83);
    // RET  (19EF_1C82 / 0x1BB72)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_1C83_1BB73(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1C83_1BB73:
    CheckExternalEvents(cs14, 0x1C85);
    // SHR DX,0x1 (19EF_1C83 / 0x1BB73)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1C87);
    // SHR DX,0x1 (19EF_1C85 / 0x1BB75)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1C89);
    // SHR DX,0x1 (19EF_1C87 / 0x1BB77)
    DX >>= 0x1;
    CheckExternalEvents(cs14, 0x1C8E);
    // CMP byte ptr [0xa451],0x0 (19EF_1C89 / 0x1BB79)
    Alu8.Sub(UInt8[DS, 0xA451], 0x0);
    CheckExternalEvents(cs14, 0x1C90);
    // JZ 0x1000:bb83 (19EF_1C8E / 0x1BB7E)
    if(ZeroFlag) {
      goto label_19EF_1C93_1BB83;
    }
    CheckExternalEvents(cs14, 0x1C93);
    // ADD DX,0x10 (19EF_1C90 / 0x1BB80)
    DX += 0x10;
    label_19EF_1C93_1BB83:
    CheckExternalEvents(cs14, 0x1C98);
    // CMP byte ptr [0xa450],0x0 (19EF_1C93 / 0x1BB83)
    Alu8.Sub(UInt8[DS, 0xA450], 0x0);
    CheckExternalEvents(cs14, 0x1C9A);
    // JNZ 0x1000:bb8b (19EF_1C98 / 0x1BB88)
    if(!ZeroFlag) {
      goto label_19EF_1C9B_1BB8B;
    }
    CheckExternalEvents(cs14, 0x1C9B);
    // INC DX (19EF_1C9A / 0x1BB8A)
    DX = Alu16.Inc(DX);
    label_19EF_1C9B_1BB8B:
    CheckExternalEvents(cs14, 0x1C9D);
    // MOV SI,DX (19EF_1C9B / 0x1BB8B)
    SI = DX;
    CheckExternalEvents(cs14, 0x1CA0);
    // MOV CX,0x10 (19EF_1C9D / 0x1BB8D)
    CX = 0x10;
    CheckExternalEvents(cs14, 0x1CA5);
    // CMP byte ptr [0xa44f],0x0 (19EF_1CA0 / 0x1BB90)
    Alu8.Sub(UInt8[DS, 0xA44F], 0x0);
    CheckExternalEvents(cs14, 0x1CA7);
    // JZ 0x1000:bb99 (19EF_1CA5 / 0x1BB95)
    if(ZeroFlag) {
      goto label_19EF_1CA9_1BB99;
    }
    CheckExternalEvents(cs14, 0x1CA9);
    // SHR CX,0x1 (19EF_1CA7 / 0x1BB97)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    label_19EF_1CA9_1BB99:
    CheckExternalEvents(cs14, 0x1CAA);
    // PUSH DS (19EF_1CA9 / 0x1BB99)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1CAD);
    // MOV AX,0xa400 (19EF_1CAA / 0x1BB9A)
    AX = 0xA400;
    CheckExternalEvents(cs14, 0x1CAF);
    // MOV DS,AX (19EF_1CAD / 0x1BB9D)
    DS = AX;
    label_19EF_1CAF_1BB9F:
    CheckExternalEvents(cs14, 0x1CB0);
    // MOVSB ES:DI,SI (19EF_1CAF / 0x1BB9F)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x1CB1);
    // INC SI (19EF_1CB0 / 0x1BBA0)
    SI++;
    CheckExternalEvents(cs14, 0x1CB4);
    // ADD DI,0x27 (19EF_1CB1 / 0x1BBA1)
    // DI += 0x27;
    DI = Alu16.Add(DI, 0x27);
    CheckExternalEvents(cs14, 0x1CB6);
    // LOOP 0x1000:bb9f (19EF_1CB4 / 0x1BBA4)
    if(--CX != 0) {
      goto label_19EF_1CAF_1BB9F;
    }
    CheckExternalEvents(cs14, 0x1CB7);
    // POP DS (19EF_1CB6 / 0x1BBA6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1CB8);
    // RET  (19EF_1CB7 / 0x1BBA7)
    return NearRet();
  }
  
  public virtual Action ghidra_guess_1000_BBA8_1BBA8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BBA8_1BBA8:
    CheckExternalEvents(cs8, 0xBBA9);
    // PUSH BP (1000_BBA8 / 0x1BBA8)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xBBAB);
    // MOV BP,SP (1000_BBA9 / 0x1BBA9)
    BP = SP;
    CheckExternalEvents(cs8, 0xBBAC);
    // PUSH DI (1000_BBAB / 0x1BBAB)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xBBAD);
    // PUSH SI (1000_BBAC / 0x1BBAC)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xBBAE);
    // PUSH DS (1000_BBAD / 0x1BBAD)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xBBB1);
    // MOV AX,0x1ddc (1000_BBAE / 0x1BBAE)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xBBB3);
    // MOV DS,AX (1000_BBB1 / 0x1BBB1)
    DS = AX;
    CheckExternalEvents(cs8, 0xBBB4);
    // PUSH ES (1000_BBB3 / 0x1BBB3)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xBBB7);
    // MOV AX,0xb800 (1000_BBB4 / 0x1BBB4)
    AX = 0xB800;
    CheckExternalEvents(cs8, 0xBBB9);
    // MOV ES,AX (1000_BBB7 / 0x1BBB7)
    ES = AX;
    CheckExternalEvents(cs8, 0xBBBC);
    // MOV SI,0x244b (1000_BBB9 / 0x1BBB9)
    SI = 0x244B;
    CheckExternalEvents(cs8, 0xBBC1);
    // CMP word ptr [0xb764],0x0 (1000_BBBC / 0x1BBBC)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs8, 0xBBC3);
    // JZ 0x1000:bc00 (1000_BBC1 / 0x1BBC1)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_BC00_1BC00, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xBBC6);
    // MOV DI,0x34 (1000_BBC3 / 0x1BBC3)
    DI = 0x34;
    CheckExternalEvents(cs8, 0xBBC8);
    // ADD SI,DI (1000_BBC6 / 0x1BBC6)
    // SI += DI;
    SI = Alu16.Add(SI, DI);
    CheckExternalEvents(cs8, 0xBBCB);
    // MOV DX,0x32 (1000_BBC8 / 0x1BBC8)
    DX = 0x32;
    CheckExternalEvents(cs8, 0xBBCE);
    // MOV BX,0x36 (1000_BBCB / 0x1BBCB)
    BX = 0x36;
    label_1000_BBCE_1BBCE:
    CheckExternalEvents(cs8, 0xBBD0);
    // MOV CX,BX (1000_BBCE / 0x1BBCE)
    CX = BX;
    CheckExternalEvents(cs8, 0xBBD2);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BBD0 / 0x1BBD0)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs8, 0xBBD5);
    // ADD SI,0x34 (1000_BBD2 / 0x1BBD2)
    SI += 0x34;
    CheckExternalEvents(cs8, 0xBBD9);
    // ADD DI,0x1f94 (1000_BBD5 / 0x1BBD5)
    // DI += 0x1F94;
    DI = Alu16.Add(DI, 0x1F94);
    CheckExternalEvents(cs8, 0xBBDB);
    // MOV CX,BX (1000_BBD9 / 0x1BBD9)
    CX = BX;
    CheckExternalEvents(cs8, 0xBBDD);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BBDB / 0x1BBDB)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs8, 0xBBE0);
    // ADD SI,0x34 (1000_BBDD / 0x1BBDD)
    SI += 0x34;
    CheckExternalEvents(cs8, 0xBBE4);
    // ADD DI,0x1f94 (1000_BBE0 / 0x1BBE0)
    // DI += 0x1F94;
    DI = Alu16.Add(DI, 0x1F94);
    CheckExternalEvents(cs8, 0xBBE6);
    // MOV CX,BX (1000_BBE4 / 0x1BBE4)
    CX = BX;
    CheckExternalEvents(cs8, 0xBBE8);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BBE6 / 0x1BBE6)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs8, 0xBBEB);
    // ADD SI,0x34 (1000_BBE8 / 0x1BBE8)
    SI += 0x34;
    CheckExternalEvents(cs8, 0xBBEF);
    // ADD DI,0x1f94 (1000_BBEB / 0x1BBEB)
    // DI += 0x1F94;
    DI = Alu16.Add(DI, 0x1F94);
    CheckExternalEvents(cs8, 0xBBF1);
    // MOV CX,BX (1000_BBEF / 0x1BBEF)
    CX = BX;
    CheckExternalEvents(cs8, 0xBBF3);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BBF1 / 0x1BBF1)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs8, 0xBBF6);
    // ADD SI,0x34 (1000_BBF3 / 0x1BBF3)
    SI += 0x34;
    CheckExternalEvents(cs8, 0xBBFA);
    // SUB DI,0x5fcc (1000_BBF6 / 0x1BBF6)
    DI -= 0x5FCC;
    CheckExternalEvents(cs8, 0xBBFB);
    // DEC DX (1000_BBFA / 0x1BBFA)
    DX = Alu16.Dec(DX);
    CheckExternalEvents(cs8, 0xBBFD);
    // JNZ 0x1000:bbce (1000_BBFB / 0x1BBFB)
    if(!ZeroFlag) {
      goto label_1000_BBCE_1BBCE;
    }
    CheckExternalEvents(cs8, 0xBBFF);
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
    CheckExternalEvents(cs8, 0xBC03);
    // MOV DI,0x1a (1000_BC00 / 0x1BC00)
    DI = 0x1A;
    CheckExternalEvents(cs8, 0xBC05);
    // ADD SI,DI (1000_BC03 / 0x1BC03)
    // SI += DI;
    SI = Alu16.Add(SI, DI);
    CheckExternalEvents(cs8, 0xBC07);
    // MOV DL,0x64 (1000_BC05 / 0x1BC05)
    DL = 0x64;
    CheckExternalEvents(cs8, 0xBC0A);
    // MOV BX,0x1b (1000_BC07 / 0x1BC07)
    BX = 0x1B;
    label_1000_BC0A_1BC0A:
    CheckExternalEvents(cs8, 0xBC0C);
    // MOV CX,BX (1000_BC0A / 0x1BC0A)
    CX = BX;
    CheckExternalEvents(cs8, 0xBC0E);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BC0C / 0x1BC0C)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs8, 0xBC11);
    // ADD SI,0x1a (1000_BC0E / 0x1BC0E)
    SI += 0x1A;
    CheckExternalEvents(cs8, 0xBC15);
    // ADD DI,0x1fca (1000_BC11 / 0x1BC11)
    // DI += 0x1FCA;
    DI = Alu16.Add(DI, 0x1FCA);
    CheckExternalEvents(cs8, 0xBC17);
    // MOV CX,BX (1000_BC15 / 0x1BC15)
    CX = BX;
    CheckExternalEvents(cs8, 0xBC19);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BC17 / 0x1BC17)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs8, 0xBC1C);
    // ADD SI,0x1a (1000_BC19 / 0x1BC19)
    SI += 0x1A;
    CheckExternalEvents(cs8, 0xBC20);
    // SUB DI,0x1fe6 (1000_BC1C / 0x1BC1C)
    DI -= 0x1FE6;
    CheckExternalEvents(cs8, 0xBC22);
    // DEC DL (1000_BC20 / 0x1BC20)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs8, 0xBC24);
    // JNZ 0x1000:bc0a (1000_BC22 / 0x1BC22)
    if(!ZeroFlag) {
      goto label_1000_BC0A_1BC0A;
    }
    label_1000_BC24_1BC24:
    CheckExternalEvents(cs8, 0xBC25);
    // POP ES (1000_BC24 / 0x1BC24)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBC26);
    // POP DS (1000_BC25 / 0x1BC25)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBC27);
    // POP SI (1000_BC26 / 0x1BC26)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBC28);
    // POP DI (1000_BC27 / 0x1BC27)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBC29);
    // POP BP (1000_BC28 / 0x1BC28)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBC2A);
    // RETF  (1000_BC29 / 0x1BC29)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1D3A_1BC2A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1D3A_1BC2A:
    CheckExternalEvents(cs14, 0x1D3B);
    // PUSH BP (19EF_1D3A / 0x1BC2A)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x1D3D);
    // MOV BP,SP (19EF_1D3B / 0x1BC2B)
    BP = SP;
    CheckExternalEvents(cs14, 0x1D3E);
    // PUSH DI (19EF_1D3D / 0x1BC2D)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1D3F);
    // PUSH SI (19EF_1D3E / 0x1BC2E)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1D40);
    // PUSH DS (19EF_1D3F / 0x1BC2F)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1D43);
    // MOV AX,0x1ddc (19EF_1D40 / 0x1BC30)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x1D45);
    // MOV DS,AX (19EF_1D43 / 0x1BC33)
    DS = AX;
    CheckExternalEvents(cs14, 0x1D46);
    // PUSH ES (19EF_1D45 / 0x1BC35)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x1D49);
    // MOV AX,0xa000 (19EF_1D46 / 0x1BC36)
    AX = 0xA000;
    CheckExternalEvents(cs14, 0x1D4B);
    // MOV ES,AX (19EF_1D49 / 0x1BC39)
    ES = AX;
    CheckExternalEvents(cs14, 0x1D4E);
    // MOV DI,0x68 (19EF_1D4B / 0x1BC3B)
    DI = 0x68;
    CheckExternalEvents(cs14, 0x1D51);
    // MOV SI,0x244b (19EF_1D4E / 0x1BC3E)
    SI = 0x244B;
    CheckExternalEvents(cs14, 0x1D54);
    // ADD SI,0x34 (19EF_1D51 / 0x1BC41)
    // SI += 0x34;
    SI = Alu16.Add(SI, 0x34);
    CheckExternalEvents(cs14, 0x1D56);
    // MOV DL,0xc8 (19EF_1D54 / 0x1BC44)
    DL = 0xC8;
    CheckExternalEvents(cs14, 0x1D59);
    // MOV BX,0xff0 (19EF_1D56 / 0x1BC46)
    BX = 0xFF0;
    label_19EF_1D59_1BC49:
    CheckExternalEvents(cs14, 0x1D5C);
    // MOV CX,0x1b (19EF_1D59 / 0x1BC49)
    CX = 0x1B;
    label_19EF_1D5C_1BC4C:
    CheckExternalEvents(cs14, 0x1D5D);
    // LODSW SI (19EF_1D5C / 0x1BC4C)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0x1D5F);
    // MOV DH,AH (19EF_1D5D / 0x1BC4D)
    DH = AH;
    CheckExternalEvents(cs14, 0x1D61);
    // MOV AH,AL (19EF_1D5F / 0x1BC4F)
    AH = AL;
    CheckExternalEvents(cs14, 0x1D63);
    // AND AX,BX (19EF_1D61 / 0x1BC51)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs14, 0x1D64);
    // STOSW ES:DI (19EF_1D63 / 0x1BC53)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1D66);
    // MOV AH,DH (19EF_1D64 / 0x1BC54)
    AH = DH;
    CheckExternalEvents(cs14, 0x1D68);
    // MOV AL,AH (19EF_1D66 / 0x1BC56)
    AL = AH;
    CheckExternalEvents(cs14, 0x1D6A);
    // AND AX,BX (19EF_1D68 / 0x1BC58)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs14, 0x1D6B);
    // STOSW ES:DI (19EF_1D6A / 0x1BC5A)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1D6C);
    // LODSW SI (19EF_1D6B / 0x1BC5B)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0x1D6E);
    // MOV DH,AH (19EF_1D6C / 0x1BC5C)
    DH = AH;
    CheckExternalEvents(cs14, 0x1D70);
    // MOV AH,AL (19EF_1D6E / 0x1BC5E)
    AH = AL;
    CheckExternalEvents(cs14, 0x1D72);
    // AND AX,BX (19EF_1D70 / 0x1BC60)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs14, 0x1D73);
    // STOSW ES:DI (19EF_1D72 / 0x1BC62)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1D75);
    // MOV AH,DH (19EF_1D73 / 0x1BC63)
    AH = DH;
    CheckExternalEvents(cs14, 0x1D77);
    // MOV AL,AH (19EF_1D75 / 0x1BC65)
    AL = AH;
    CheckExternalEvents(cs14, 0x1D79);
    // AND AX,BX (19EF_1D77 / 0x1BC67)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs14, 0x1D7A);
    // STOSW ES:DI (19EF_1D79 / 0x1BC69)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1D7C);
    // LOOP 0x1000:bc4c (19EF_1D7A / 0x1BC6A)
    if(--CX != 0) {
      goto label_19EF_1D5C_1BC4C;
    }
    CheckExternalEvents(cs14, 0x1D7F);
    // ADD DI,0x68 (19EF_1D7C / 0x1BC6C)
    DI += 0x68;
    CheckExternalEvents(cs14, 0x1D82);
    // ADD SI,0x34 (19EF_1D7F / 0x1BC6F)
    SI += 0x34;
    CheckExternalEvents(cs14, 0x1D84);
    // DEC DL (19EF_1D82 / 0x1BC72)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs14, 0x1D86);
    // JNZ 0x1000:bc49 (19EF_1D84 / 0x1BC74)
    if(!ZeroFlag) {
      goto label_19EF_1D59_1BC49;
    }
    CheckExternalEvents(cs14, 0x1D87);
    // POP ES (19EF_1D86 / 0x1BC76)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1D88);
    // POP DS (19EF_1D87 / 0x1BC77)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1D89);
    // POP SI (19EF_1D88 / 0x1BC78)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1D8A);
    // POP DI (19EF_1D89 / 0x1BC79)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1D8B);
    // POP BP (19EF_1D8A / 0x1BC7A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1D8C);
    // RETF  (19EF_1D8B / 0x1BC7B)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1D8C_1BC7C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1D8C_1BC7C:
    CheckExternalEvents(cs14, 0x1D8D);
    // PUSH BP (19EF_1D8C / 0x1BC7C)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x1D8F);
    // MOV BP,SP (19EF_1D8D / 0x1BC7D)
    BP = SP;
    CheckExternalEvents(cs14, 0x1D90);
    // PUSH DI (19EF_1D8F / 0x1BC7F)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1D91);
    // PUSH SI (19EF_1D90 / 0x1BC80)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1D92);
    // PUSH DS (19EF_1D91 / 0x1BC81)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1D95);
    // MOV AX,0x1ddc (19EF_1D92 / 0x1BC82)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x1D97);
    // MOV DS,AX (19EF_1D95 / 0x1BC85)
    DS = AX;
    CheckExternalEvents(cs14, 0x1D9A);
    // MOV AX,word ptr [BP + 0x6] (19EF_1D97 / 0x1BC87)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x1D9D);
    // MOV [0x26e],AX (19EF_1D9A / 0x1BC8A)
    UInt16[DS, 0x26E] = AX;
    CheckExternalEvents(cs14, 0x1DA0);
    // MOV AX,word ptr [BP + 0x8] (19EF_1D9D / 0x1BC8D)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x1DA3);
    // MOV [0x270],AX (19EF_1DA0 / 0x1BC90)
    UInt16[DS, 0x270] = AX;
    CheckExternalEvents(cs14, 0x1DA4);
    // POP DS (19EF_1DA3 / 0x1BC93)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1DA5);
    // POP SI (19EF_1DA4 / 0x1BC94)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1DA6);
    // POP DI (19EF_1DA5 / 0x1BC95)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1DA7);
    // POP BP (19EF_1DA6 / 0x1BC96)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1DA8);
    // RETF  (19EF_1DA7 / 0x1BC97)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1DA8_1BC98(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1DA8_1BC98:
    CheckExternalEvents(cs14, 0x1DA9);
    // PUSH BP (19EF_1DA8 / 0x1BC98)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x1DAB);
    // MOV BP,SP (19EF_1DA9 / 0x1BC99)
    BP = SP;
    CheckExternalEvents(cs14, 0x1DAC);
    // PUSH DI (19EF_1DAB / 0x1BC9B)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1DAD);
    // PUSH SI (19EF_1DAC / 0x1BC9C)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1DAE);
    // PUSH DS (19EF_1DAD / 0x1BC9D)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1DB1);
    // MOV AX,0x1ddc (19EF_1DAE / 0x1BC9E)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x1DB3);
    // MOV DS,AX (19EF_1DB1 / 0x1BCA1)
    DS = AX;
    CheckExternalEvents(cs14, 0x1DB6);
    // CALL 0x1000:b776 (19EF_1DB3 / 0x1BCA3)
    NearCall(cs14, 0x1DB6, unknown_19EF_1886_1B776);
    CheckExternalEvents(cs14, 0x1DB7);
    // POP DS (19EF_1DB6 / 0x1BCA6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1DB8);
    // POP SI (19EF_1DB7 / 0x1BCA7)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1DB9);
    // POP DI (19EF_1DB8 / 0x1BCA8)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1DBA);
    // POP BP (19EF_1DB9 / 0x1BCA9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1DBB);
    // RETF  (19EF_1DBA / 0x1BCAA)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1DF8_1BCE8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1DF8_1BCE8:
    CheckExternalEvents(cs14, 0x1DF9);
    // PUSH BP (19EF_1DF8 / 0x1BCE8)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x1DFB);
    // MOV BP,SP (19EF_1DF9 / 0x1BCE9)
    BP = SP;
    CheckExternalEvents(cs14, 0x1DFC);
    // PUSH DI (19EF_1DFB / 0x1BCEB)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1DFD);
    // PUSH SI (19EF_1DFC / 0x1BCEC)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1DFE);
    // PUSH DS (19EF_1DFD / 0x1BCED)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1E01);
    // MOV AX,0x1ddc (19EF_1DFE / 0x1BCEE)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x1E03);
    // MOV DS,AX (19EF_1E01 / 0x1BCF1)
    DS = AX;
    CheckExternalEvents(cs14, 0x1E06);
    // MOV AX,[0xa44d] (19EF_1E03 / 0x1BCF3)
    AX = UInt16[DS, 0xA44D];
    CheckExternalEvents(cs14, 0x1E08);
    // SHR AL,0x1 (19EF_1E06 / 0x1BCF6)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x1E0B);
    // AND AX,0x7 (19EF_1E08 / 0x1BCF8)
    AX &= 0x7;
    CheckExternalEvents(cs14, 0x1E0D);
    // ADD AL,0x2 (19EF_1E0B / 0x1BCFB)
    AL += 0x2;
    CheckExternalEvents(cs14, 0x1E0F);
    // SHL AX,0x1 (19EF_1E0D / 0x1BCFD)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x1E11);
    // SHL AX,0x1 (19EF_1E0F / 0x1BCFF)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x1E13);
    // SHL AX,0x1 (19EF_1E11 / 0x1BD01)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs14, 0x1E15);
    // MOV BX,AX (19EF_1E13 / 0x1BD03)
    BX = AX;
    CheckExternalEvents(cs14, 0x1E17);
    // SHL AX,0x1 (19EF_1E15 / 0x1BD05)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x1E19);
    // ADD AX,BX (19EF_1E17 / 0x1BD07)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs14, 0x1E1C);
    // MOV [0x9f1],AX (19EF_1E19 / 0x1BD09)
    UInt16[DS, 0x9F1] = AX;
    CheckExternalEvents(cs14, 0x1E20);
    // MOV BX,word ptr [0xa44b] (19EF_1E1C / 0x1BD0C)
    BX = UInt16[DS, 0xA44B];
    CheckExternalEvents(cs14, 0x1E22);
    // SHR BL,0x1 (19EF_1E20 / 0x1BD10)
    BL >>= 0x1;
    CheckExternalEvents(cs14, 0x1E25);
    // AND BX,0x7 (19EF_1E22 / 0x1BD12)
    BX &= 0x7;
    CheckExternalEvents(cs14, 0x1E28);
    // ADD BL,0x2 (19EF_1E25 / 0x1BD15)
    // BL += 0x2;
    BL = Alu8.Add(BL, 0x2);
    CheckExternalEvents(cs14, 0x1E2C);
    // MOV word ptr [0x9ef],BX (19EF_1E28 / 0x1BD18)
    UInt16[DS, 0x9EF] = BX;
    CheckExternalEvents(cs14, 0x1E2E);
    // ADD BX,AX (19EF_1E2C / 0x1BD1C)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs14, 0x1E32);
    // MOV word ptr [0x9ed],BX (19EF_1E2E / 0x1BD1E)
    UInt16[DS, 0x9ED] = BX;
    CheckExternalEvents(cs14, 0x1E33);
    // POP DS (19EF_1E32 / 0x1BD22)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1E34);
    // POP SI (19EF_1E33 / 0x1BD23)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1E35);
    // POP DI (19EF_1E34 / 0x1BD24)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1E36);
    // POP BP (19EF_1E35 / 0x1BD25)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1E37);
    // RETF  (19EF_1E36 / 0x1BD26)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1E37_1BD27(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1E37_1BD27:
    CheckExternalEvents(cs14, 0x1E38);
    // PUSH BP (19EF_1E37 / 0x1BD27)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x1E3A);
    // MOV BP,SP (19EF_1E38 / 0x1BD28)
    BP = SP;
    CheckExternalEvents(cs14, 0x1E3B);
    // PUSH DI (19EF_1E3A / 0x1BD2A)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1E3C);
    // PUSH SI (19EF_1E3B / 0x1BD2B)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1E3D);
    // PUSH DS (19EF_1E3C / 0x1BD2C)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1E40);
    // MOV AX,0x1ddc (19EF_1E3D / 0x1BD2D)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x1E42);
    // MOV DS,AX (19EF_1E40 / 0x1BD30)
    DS = AX;
    CheckExternalEvents(cs14, 0x1E43);
    // PUSH ES (19EF_1E42 / 0x1BD32)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x1E46);
    // MOV AX,0xa000 (19EF_1E43 / 0x1BD33)
    AX = 0xA000;
    CheckExternalEvents(cs14, 0x1E48);
    // MOV ES,AX (19EF_1E46 / 0x1BD36)
    ES = AX;
    CheckExternalEvents(cs14, 0x1E4B);
    // MOV SI,0x244b (19EF_1E48 / 0x1BD38)
    SI = 0x244B;
    CheckExternalEvents(cs14, 0x1E50);
    // CMP word ptr [0xb764],0x2 (19EF_1E4B / 0x1BD3B)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x1E52);
    // JC 0x1000:bd68 (19EF_1E50 / 0x1BD40)
    if(CarryFlag) {
      goto label_19EF_1E78_1BD68;
    }
    CheckExternalEvents(cs14, 0x1E54);
    // JZ 0x1000:bd6e (19EF_1E52 / 0x1BD42)
    if(ZeroFlag) {
      goto label_19EF_1E7E_1BD6E;
    }
    CheckExternalEvents(cs14, 0x1E57);
    // MOV DI,0xa08 (19EF_1E54 / 0x1BD44)
    DI = 0xA08;
    CheckExternalEvents(cs14, 0x1E59);
    // MOV DL,0x58 (19EF_1E57 / 0x1BD47)
    DL = 0x58;
    CheckExternalEvents(cs14, 0x1E5C);
    // MOV BX,0xff0 (19EF_1E59 / 0x1BD49)
    BX = 0xFF0;
    label_19EF_1E5C_1BD4C:
    CheckExternalEvents(cs14, 0x1E5F);
    // MOV CX,0x16 (19EF_1E5C / 0x1BD4C)
    CX = 0x16;
    label_19EF_1E5F_1BD4F:
    CheckExternalEvents(cs14, 0x1E60);
    // LODSW SI (19EF_1E5F / 0x1BD4F)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0x1E62);
    // MOV DH,AH (19EF_1E60 / 0x1BD50)
    DH = AH;
    CheckExternalEvents(cs14, 0x1E64);
    // MOV AH,AL (19EF_1E62 / 0x1BD52)
    AH = AL;
    CheckExternalEvents(cs14, 0x1E66);
    // AND AX,BX (19EF_1E64 / 0x1BD54)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs14, 0x1E67);
    // STOSW ES:DI (19EF_1E66 / 0x1BD56)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1E69);
    // MOV AH,DH (19EF_1E67 / 0x1BD57)
    AH = DH;
    CheckExternalEvents(cs14, 0x1E6B);
    // MOV AL,AH (19EF_1E69 / 0x1BD59)
    AL = AH;
    CheckExternalEvents(cs14, 0x1E6D);
    // AND AX,BX (19EF_1E6B / 0x1BD5B)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs14, 0x1E6E);
    // STOSW ES:DI (19EF_1E6D / 0x1BD5D)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x1E70);
    // LOOP 0x1000:bd4f (19EF_1E6E / 0x1BD5E)
    if(--CX != 0) {
      goto label_19EF_1E5F_1BD4F;
    }
    CheckExternalEvents(cs14, 0x1E74);
    // ADD DI,0xe8 (19EF_1E70 / 0x1BD60)
    DI += 0xE8;
    CheckExternalEvents(cs14, 0x1E76);
    // DEC DL (19EF_1E74 / 0x1BD64)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs14, 0x1E78);
    // JNZ 0x1000:bd4c (19EF_1E76 / 0x1BD66)
    if(!ZeroFlag) {
      goto label_19EF_1E5C_1BD4C;
    }
    label_19EF_1E78_1BD68:
    CheckExternalEvents(cs14, 0x1E79);
    // POP ES (19EF_1E78 / 0x1BD68)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1E7A);
    // POP DS (19EF_1E79 / 0x1BD69)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1E7B);
    // POP SI (19EF_1E7A / 0x1BD6A)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1E7C);
    // POP DI (19EF_1E7B / 0x1BD6B)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1E7D);
    // POP BP (19EF_1E7C / 0x1BD6C)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1E7E);
    // RETF  (19EF_1E7D / 0x1BD6D)
    return FarRet();
    label_19EF_1E7E_1BD6E:
    CheckExternalEvents(cs14, 0x1E81);
    // MOV DI,0x141 (19EF_1E7E / 0x1BD6E)
    DI = 0x141;
    CheckExternalEvents(cs14, 0x1E85);
    // ADD SI,0xf20 (19EF_1E81 / 0x1BD71)
    // SI += 0xF20;
    SI = Alu16.Add(SI, 0xF20);
    CheckExternalEvents(cs14, 0x1E88);
    // MOV DX,0x3ce (19EF_1E85 / 0x1BD75)
    DX = 0x3CE;
    CheckExternalEvents(cs14, 0x1E8B);
    // MOV AX,0x5 (19EF_1E88 / 0x1BD78)
    AX = 0x5;
    CheckExternalEvents(cs14, 0x1E8C);
    // OUT DX,AX (19EF_1E8B / 0x1BD7B)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x1E8F);
    // MOV AX,0xff08 (19EF_1E8C / 0x1BD7C)
    AX = 0xFF08;
    CheckExternalEvents(cs14, 0x1E90);
    // OUT DX,AX (19EF_1E8F / 0x1BD7F)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x1E93);
    // MOV AX,0x1 (19EF_1E90 / 0x1BD80)
    AX = 0x1;
    CheckExternalEvents(cs14, 0x1E94);
    // OUT DX,AX (19EF_1E93 / 0x1BD83)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x1E97);
    // MOV BX,0x58 (19EF_1E94 / 0x1BD84)
    BX = 0x58;
    CheckExternalEvents(cs14, 0x1E9A);
    // MOV DX,0x3c4 (19EF_1E97 / 0x1BD87)
    DX = 0x3C4;
    label_19EF_1E9A_1BD8A:
    CheckExternalEvents(cs14, 0x1E9D);
    // MOV CX,0xb (19EF_1E9A / 0x1BD8A)
    CX = 0xB;
    label_19EF_1E9D_1BD8D:
    CheckExternalEvents(cs14, 0x1EA0);
    // MOV AX,0x102 (19EF_1E9D / 0x1BD8D)
    AX = 0x102;
    CheckExternalEvents(cs14, 0x1EA1);
    // OUT DX,AX (19EF_1EA0 / 0x1BD90)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x1EA4);
    // MOV AL,byte ptr ES:[DI] (19EF_1EA1 / 0x1BD91)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x1EA5);
    // MOVSB ES:DI,SI (19EF_1EA4 / 0x1BD94)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x1EA6);
    // DEC DI (19EF_1EA5 / 0x1BD95)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs14, 0x1EA9);
    // MOV AX,0x202 (19EF_1EA6 / 0x1BD96)
    AX = 0x202;
    CheckExternalEvents(cs14, 0x1EAA);
    // OUT DX,AX (19EF_1EA9 / 0x1BD99)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x1EAD);
    // MOV AL,byte ptr ES:[DI] (19EF_1EAA / 0x1BD9A)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x1EAE);
    // MOVSB ES:DI,SI (19EF_1EAD / 0x1BD9D)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x1EAF);
    // DEC DI (19EF_1EAE / 0x1BD9E)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs14, 0x1EB2);
    // MOV AX,0x402 (19EF_1EAF / 0x1BD9F)
    AX = 0x402;
    CheckExternalEvents(cs14, 0x1EB3);
    // OUT DX,AX (19EF_1EB2 / 0x1BDA2)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x1EB6);
    // MOV AL,byte ptr ES:[DI] (19EF_1EB3 / 0x1BDA3)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x1EB7);
    // MOVSB ES:DI,SI (19EF_1EB6 / 0x1BDA6)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x1EB8);
    // DEC DI (19EF_1EB7 / 0x1BDA7)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs14, 0x1EBB);
    // MOV AX,0x802 (19EF_1EB8 / 0x1BDA8)
    AX = 0x802;
    CheckExternalEvents(cs14, 0x1EBC);
    // OUT DX,AX (19EF_1EBB / 0x1BDAB)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x1EBF);
    // MOV AL,byte ptr ES:[DI] (19EF_1EBC / 0x1BDAC)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x1EC0);
    // MOVSB ES:DI,SI (19EF_1EBF / 0x1BDAF)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x1EC2);
    // LOOP 0x1000:bd8d (19EF_1EC0 / 0x1BDB0)
    if(--CX != 0) {
      goto label_19EF_1E9D_1BD8D;
    }
    CheckExternalEvents(cs14, 0x1EC5);
    // ADD DI,0x1d (19EF_1EC2 / 0x1BDB2)
    DI += 0x1D;
    CheckExternalEvents(cs14, 0x1EC6);
    // DEC BX (19EF_1EC5 / 0x1BDB5)
    BX = Alu16.Dec(BX);
    CheckExternalEvents(cs14, 0x1EC8);
    // JNZ 0x1000:bd8a (19EF_1EC6 / 0x1BDB6)
    if(!ZeroFlag) {
      goto label_19EF_1E9A_1BD8A;
    }
    CheckExternalEvents(cs14, 0x1ECB);
    // MOV AX,0xf02 (19EF_1EC8 / 0x1BDB8)
    AX = 0xF02;
    CheckExternalEvents(cs14, 0x1ECC);
    // OUT DX,AX (19EF_1ECB / 0x1BDBB)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x1ECE);
    // JMP 0x1000:bd68 (19EF_1ECC / 0x1BDBC)
    goto label_19EF_1E78_1BD68;
  }
  
}
