namespace generated;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.InstructionsImpl;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_1000_BDBE_1BDBE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BDBE_1BDBE:
    CheckExternalEvents(cs8, 0xBDBF);
    // PUSH BP (1000_BDBE / 0x1BDBE)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xBDC1);
    // MOV BP,SP (1000_BDBF / 0x1BDBF)
    BP = SP;
    CheckExternalEvents(cs8, 0xBDC2);
    // PUSH DI (1000_BDC1 / 0x1BDC1)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xBDC3);
    // PUSH SI (1000_BDC2 / 0x1BDC2)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xBDC4);
    // PUSH DS (1000_BDC3 / 0x1BDC3)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xBDC7);
    // MOV AX,0x1ddc (1000_BDC4 / 0x1BDC4)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xBDC9);
    // MOV DS,AX (1000_BDC7 / 0x1BDC7)
    DS = AX;
    CheckExternalEvents(cs8, 0xBDCC);
    // MOV DI,word ptr [BP + 0x6] (1000_BDC9 / 0x1BDC9)
    DI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xBDCF);
    // MOV AX,word ptr [BP + 0x8] (1000_BDCC / 0x1BDCC)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0xBDD2);
    // MOV DX,word ptr [BP + 0xa] (1000_BDCF / 0x1BDCF)
    DX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0xBDD3);
    // PUSH ES (1000_BDD2 / 0x1BDD2)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xBDD5);
    // MOV ES,AX (1000_BDD3 / 0x1BDD3)
    ES = AX;
    CheckExternalEvents(cs8, 0xBDD8);
    // MOV SI,0x7ad (1000_BDD5 / 0x1BDD5)
    SI = 0x7AD;
    CheckExternalEvents(cs8, 0xBDD9);
    // PUSH DS (1000_BDD8 / 0x1BDD8)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xBDDB);
    // OR DX,DX (1000_BDD9 / 0x1BDD9)
    // DX |= DX;
    DX = Alu16.Or(DX, DX);
    CheckExternalEvents(cs8, 0xBDDD);
    // JZ 0x1000:bde7 (1000_BDDB / 0x1BDDB)
    if(ZeroFlag) {
      goto label_1000_BDE7_1BDE7;
    }
    CheckExternalEvents(cs8, 0xBDDF);
    // XCHG DI,SI (1000_BDDD / 0x1BDDD)
    (SI, DI) = (DI, SI);
    CheckExternalEvents(cs8, 0xBDE1);
    // MOV DX,DS (1000_BDDF / 0x1BDDF)
    DX = DS;
    CheckExternalEvents(cs8, 0xBDE3);
    // MOV AX,ES (1000_BDE1 / 0x1BDE1)
    AX = ES;
    CheckExternalEvents(cs8, 0xBDE5);
    // MOV DS,AX (1000_BDE3 / 0x1BDE3)
    DS = AX;
    CheckExternalEvents(cs8, 0xBDE7);
    // MOV ES,DX (1000_BDE5 / 0x1BDE5)
    ES = DX;
    label_1000_BDE7_1BDE7:
    CheckExternalEvents(cs8, 0xBDEA);
    // MOV CX,0x120 (1000_BDE7 / 0x1BDE7)
    CX = 0x120;
    CheckExternalEvents(cs8, 0xBDEB);
    // CLD  (1000_BDEA / 0x1BDEA)
    DirectionFlag = false;
    CheckExternalEvents(cs8, 0xBDED);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_BDEB / 0x1BDEB)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs8, 0xBDEE);
    // POP DS (1000_BDED / 0x1BDED)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBDEF);
    // POP ES (1000_BDEE / 0x1BDEE)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBDF0);
    // POP DS (1000_BDEF / 0x1BDEF)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBDF1);
    // POP SI (1000_BDF0 / 0x1BDF0)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBDF2);
    // POP DI (1000_BDF1 / 0x1BDF1)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBDF3);
    // POP BP (1000_BDF2 / 0x1BDF2)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBDF4);
    // RETF  (1000_BDF3 / 0x1BDF3)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_BDF4_1BDF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BDF4_1BDF4:
    CheckExternalEvents(cs8, 0xBDF5);
    // PUSH BP (1000_BDF4 / 0x1BDF4)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xBDF7);
    // MOV BP,SP (1000_BDF5 / 0x1BDF5)
    BP = SP;
    CheckExternalEvents(cs8, 0xBDF8);
    // PUSH DI (1000_BDF7 / 0x1BDF7)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xBDF9);
    // PUSH SI (1000_BDF8 / 0x1BDF8)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xBDFA);
    // PUSH DS (1000_BDF9 / 0x1BDF9)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xBDFD);
    // MOV AX,0x1ddc (1000_BDFA / 0x1BDFA)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xBDFF);
    // MOV DS,AX (1000_BDFD / 0x1BDFD)
    DS = AX;
    CheckExternalEvents(cs8, 0xBE02);
    // MOV AX,word ptr [BP + 0x6] (1000_BDFF / 0x1BDFF)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xBE05);
    // MOV DI,0x244b (1000_BE02 / 0x1BE02)
    DI = 0x244B;
    CheckExternalEvents(cs8, 0xBE07);
    // ADD DI,AX (1000_BE05 / 0x1BE05)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs8, 0xBE08);
    // PUSH ES (1000_BE07 / 0x1BE07)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xBE0A);
    // MOV AX,DS (1000_BE08 / 0x1BE08)
    AX = DS;
    CheckExternalEvents(cs8, 0xBE0C);
    // MOV ES,AX (1000_BE0A / 0x1BE0A)
    ES = AX;
    CheckExternalEvents(cs8, 0xBE0F);
    // MOV SI,0x664 (1000_BE0C / 0x1BE0C)
    SI = 0x664;
    CheckExternalEvents(cs8, 0xBE12);
    // MOV BX,0x424 (1000_BE0F / 0x1BE0F)
    BX = 0x424;
    CheckExternalEvents(cs8, 0xBE15);
    // MOV DX,0x8 (1000_BE12 / 0x1BE12)
    DX = 0x8;
    label_1000_BE15_1BE15:
    CheckExternalEvents(cs8, 0xBE18);
    // MOV CX,0x8 (1000_BE15 / 0x1BE15)
    CX = 0x8;
    label_1000_BE18_1BE18:
    CheckExternalEvents(cs8, 0xBE19);
    // LODSB SI (1000_BE18 / 0x1BE18)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xBE1B);
    // CMP AL,0x90 (1000_BE19 / 0x1BE19)
    Alu8.Sub(AL, 0x90);
    CheckExternalEvents(cs8, 0xBE1D);
    // JNC 0x1000:be29 (1000_BE1B / 0x1BE1B)
    if(!CarryFlag) {
      goto label_1000_BE29_1BE29;
    }
    CheckExternalEvents(cs8, 0xBE1F);
    // CMP AL,0x10 (1000_BE1D / 0x1BE1D)
    Alu8.Sub(AL, 0x10);
    CheckExternalEvents(cs8, 0xBE21);
    // JZ 0x1000:be39 (1000_BE1F / 0x1BE1F)
    if(ZeroFlag) {
      goto label_1000_BE39_1BE39;
    }
    CheckExternalEvents(cs8, 0xBE23);
    // CMP AL,0x20 (1000_BE21 / 0x1BE21)
    Alu8.Sub(AL, 0x20);
    CheckExternalEvents(cs8, 0xBE25);
    // JC 0x1000:be27 (1000_BE23 / 0x1BE23)
    if(CarryFlag) {
      goto label_1000_BE27_1BE27;
    }
    CheckExternalEvents(cs8, 0xBE27);
    // SUB AL,0x10 (1000_BE25 / 0x1BE25)
    // AL -= 0x10;
    AL = Alu8.Sub(AL, 0x10);
    label_1000_BE27_1BE27:
    CheckExternalEvents(cs8, 0xBE29);
    // OR AL,byte ptr [BX] (1000_BE27 / 0x1BE27)
    // AL |= UInt8[DS, (ushort)(BX)];
    AL = Alu8.Or(AL, UInt8[DS, (ushort)(BX)]);
    label_1000_BE29_1BE29:
    CheckExternalEvents(cs8, 0xBE2A);
    // STOSB ES:DI (1000_BE29 / 0x1BE29)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xBE2B);
    // INC BX (1000_BE2A / 0x1BE2A)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs8, 0xBE2D);
    // LOOP 0x1000:be18 (1000_BE2B / 0x1BE2B)
    if(--CX != 0) {
      goto label_1000_BE18_1BE18;
    }
    label_1000_BE2D_1BE2D:
    CheckExternalEvents(cs8, 0xBE30);
    // ADD DI,0x20 (1000_BE2D / 0x1BE2D)
    DI += 0x20;
    CheckExternalEvents(cs8, 0xBE31);
    // DEC DX (1000_BE30 / 0x1BE30)
    DX = Alu16.Dec(DX);
    CheckExternalEvents(cs8, 0xBE33);
    // JNZ 0x1000:be15 (1000_BE31 / 0x1BE31)
    if(!ZeroFlag) {
      goto label_1000_BE15_1BE15;
    }
    CheckExternalEvents(cs8, 0xBE34);
    // POP ES (1000_BE33 / 0x1BE33)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBE35);
    // POP DS (1000_BE34 / 0x1BE34)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBE36);
    // POP SI (1000_BE35 / 0x1BE35)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBE37);
    // POP DI (1000_BE36 / 0x1BE36)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBE38);
    // POP BP (1000_BE37 / 0x1BE37)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBE39);
    // RETF  (1000_BE38 / 0x1BE38)
    return FarRet();
    label_1000_BE39_1BE39:
    CheckExternalEvents(cs8, 0xBE3B);
    // MOV AL,0x40 (1000_BE39 / 0x1BE39)
    AL = 0x40;
    CheckExternalEvents(cs8, 0xBE3C);
    // STOSB ES:DI (1000_BE3B / 0x1BE3B)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xBE3D);
    // INC BX (1000_BE3C / 0x1BE3C)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs8, 0xBE3F);
    // LOOP 0x1000:be18 (1000_BE3D / 0x1BE3D)
    if(--CX != 0) {
      goto label_1000_BE18_1BE18;
    }
    CheckExternalEvents(cs8, 0xBE41);
    // JMP 0x1000:be2d (1000_BE3F / 0x1BE3F)
    goto label_1000_BE2D_1BE2D;
  }
  
  public virtual Action ghidra_guess_1000_BE41_1BE41(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_BE41_1BE41:
    CheckExternalEvents(cs8, 0xBE42);
    // PUSH BP (1000_BE41 / 0x1BE41)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xBE44);
    // MOV BP,SP (1000_BE42 / 0x1BE42)
    BP = SP;
    CheckExternalEvents(cs8, 0xBE45);
    // PUSH DI (1000_BE44 / 0x1BE44)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xBE46);
    // PUSH SI (1000_BE45 / 0x1BE45)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xBE47);
    // PUSH DS (1000_BE46 / 0x1BE46)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xBE4A);
    // MOV AX,0x1ddc (1000_BE47 / 0x1BE47)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xBE4C);
    // MOV DS,AX (1000_BE4A / 0x1BE4A)
    DS = AX;
    CheckExternalEvents(cs8, 0xBE4F);
    // MOV AX,word ptr [BP + 0x6] (1000_BE4C / 0x1BE4C)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xBE52);
    // SUB AX,0x90 (1000_BE4F / 0x1BE4F)
    // AX -= 0x90;
    AX = Alu16.Sub(AX, 0x90);
    CheckExternalEvents(cs8, 0xBE54);
    // XCHG AL,AH (1000_BE52 / 0x1BE52)
    (AH, AL) = (AL, AH);
    CheckExternalEvents(cs8, 0xBE56);
    // SHR AX,0x1 (1000_BE54 / 0x1BE54)
    AX >>= 0x1;
    CheckExternalEvents(cs8, 0xBE58);
    // SHR AX,0x1 (1000_BE56 / 0x1BE56)
    AX >>= 0x1;
    CheckExternalEvents(cs8, 0xBE5B);
    // ADD AH,0x40 (1000_BE58 / 0x1BE58)
    // AH += 0x40;
    AH = Alu8.Add(AH, 0x40);
    CheckExternalEvents(cs8, 0xBE5E);
    // MOV DI,0x244b (1000_BE5B / 0x1BE5B)
    DI = 0x244B;
    CheckExternalEvents(cs8, 0xBE60);
    // ADD AX,DI (1000_BE5E / 0x1BE5E)
    // AX += DI;
    AX = Alu16.Add(AX, DI);
    CheckExternalEvents(cs8, 0xBE62);
    // MOV SI,AX (1000_BE60 / 0x1BE60)
    SI = AX;
    CheckExternalEvents(cs8, 0xBE66);
    // ADD DI,0x3fe0 (1000_BE62 / 0x1BE62)
    // DI += 0x3FE0;
    DI = Alu16.Add(DI, 0x3FE0);
    CheckExternalEvents(cs8, 0xBE69);
    // MOV BX,0x215d (1000_BE66 / 0x1BE66)
    BX = 0x215D;
    CheckExternalEvents(cs8, 0xBE6A);
    // PUSH ES (1000_BE69 / 0x1BE69)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xBE6C);
    // MOV AX,DS (1000_BE6A / 0x1BE6A)
    AX = DS;
    CheckExternalEvents(cs8, 0xBE6E);
    // MOV ES,AX (1000_BE6C / 0x1BE6C)
    ES = AX;
    CheckExternalEvents(cs8, 0xBE71);
    // MOV CX,0x20 (1000_BE6E / 0x1BE6E)
    CX = 0x20;
    label_1000_BE71_1BE71:
    CheckExternalEvents(cs8, 0xBE73);
    // XOR AH,AH (1000_BE71 / 0x1BE71)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs8, 0xBE74);
    // LODSB SI (1000_BE73 / 0x1BE73)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xBE75);
    // XLAT BX (1000_BE74 / 0x1BE74)
    AL = UInt8[DS, (ushort)(BX + AL)];
    CheckExternalEvents(cs8, 0xBE77);
    // MOV AH,AL (1000_BE75 / 0x1BE75)
    AH = AL;
    CheckExternalEvents(cs8, 0xBE79);
    // SHL AH,0x1 (1000_BE77 / 0x1BE77)
    AH <<= 0x1;
    CheckExternalEvents(cs8, 0xBE7B);
    // SHL AH,0x1 (1000_BE79 / 0x1BE79)
    AH <<= 0x1;
    CheckExternalEvents(cs8, 0xBE7D);
    // SHL AH,0x1 (1000_BE7B / 0x1BE7B)
    AH <<= 0x1;
    CheckExternalEvents(cs8, 0xBE7F);
    // SHL AH,0x1 (1000_BE7D / 0x1BE7D)
    // AH <<= 0x1;
    AH = Alu8.Shl(AH, 0x1);
    CheckExternalEvents(cs8, 0xBE80);
    // LODSB SI (1000_BE7F / 0x1BE7F)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xBE81);
    // XLAT BX (1000_BE80 / 0x1BE80)
    AL = UInt8[DS, (ushort)(BX + AL)];
    CheckExternalEvents(cs8, 0xBE83);
    // OR AL,AH (1000_BE81 / 0x1BE81)
    // AL |= AH;
    AL = Alu8.Or(AL, AH);
    CheckExternalEvents(cs8, 0xBE84);
    // STOSB ES:DI (1000_BE83 / 0x1BE83)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xBE86);
    // LOOP 0x1000:be71 (1000_BE84 / 0x1BE84)
    if(--CX != 0) {
      goto label_1000_BE71_1BE71;
    }
    CheckExternalEvents(cs8, 0xBE87);
    // POP ES (1000_BE86 / 0x1BE86)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBE88);
    // POP DS (1000_BE87 / 0x1BE87)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBE89);
    // POP SI (1000_BE88 / 0x1BE88)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBE8A);
    // POP DI (1000_BE89 / 0x1BE89)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBE8B);
    // POP BP (1000_BE8A / 0x1BE8A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBE8C);
    // RETF  (1000_BE8B / 0x1BE8B)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1F9C_1BE8C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1F9C_1BE8C:
    CheckExternalEvents(cs14, 0x1F9D);
    // PUSH BP (19EF_1F9C / 0x1BE8C)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x1F9F);
    // MOV BP,SP (19EF_1F9D / 0x1BE8D)
    BP = SP;
    CheckExternalEvents(cs14, 0x1FA0);
    // PUSH DI (19EF_1F9F / 0x1BE8F)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1FA1);
    // PUSH SI (19EF_1FA0 / 0x1BE90)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1FA2);
    // PUSH DS (19EF_1FA1 / 0x1BE91)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1FA5);
    // MOV AX,0x1ddc (19EF_1FA2 / 0x1BE92)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x1FA7);
    // MOV DS,AX (19EF_1FA5 / 0x1BE95)
    DS = AX;
    CheckExternalEvents(cs14, 0x1FA8);
    // STI  (19EF_1FA7 / 0x1BE97)
    InterruptFlag = true;
    CheckExternalEvents(cs14, 0x1FA9);
    // POP DS (19EF_1FA8 / 0x1BE98)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1FAA);
    // POP SI (19EF_1FA9 / 0x1BE99)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1FAB);
    // POP DI (19EF_1FAA / 0x1BE9A)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1FAC);
    // POP BP (19EF_1FAB / 0x1BE9B)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1FAD);
    // RETF  (19EF_1FAC / 0x1BE9C)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1FAD_1BE9D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1FAD_1BE9D:
    CheckExternalEvents(cs14, 0x1FAE);
    // PUSH BP (19EF_1FAD / 0x1BE9D)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x1FB0);
    // MOV BP,SP (19EF_1FAE / 0x1BE9E)
    BP = SP;
    CheckExternalEvents(cs14, 0x1FB1);
    // PUSH DI (19EF_1FB0 / 0x1BEA0)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1FB2);
    // PUSH SI (19EF_1FB1 / 0x1BEA1)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1FB3);
    // PUSH DS (19EF_1FB2 / 0x1BEA2)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1FB6);
    // MOV AX,0x1ddc (19EF_1FB3 / 0x1BEA3)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x1FB8);
    // MOV DS,AX (19EF_1FB6 / 0x1BEA6)
    DS = AX;
    CheckExternalEvents(cs14, 0x1FB9);
    // CLI  (19EF_1FB8 / 0x1BEA8)
    InterruptFlag = false;
    CheckExternalEvents(cs14, 0x1FBA);
    // POP DS (19EF_1FB9 / 0x1BEA9)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1FBB);
    // POP SI (19EF_1FBA / 0x1BEAA)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1FBC);
    // POP DI (19EF_1FBB / 0x1BEAB)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1FBD);
    // POP BP (19EF_1FBC / 0x1BEAC)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x1FBE);
    // RETF  (19EF_1FBD / 0x1BEAD)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_1FBE_1BEAE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_1FBE_1BEAE:
    CheckExternalEvents(cs14, 0x1FBF);
    // PUSH BP (19EF_1FBE / 0x1BEAE)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x1FC1);
    // MOV BP,SP (19EF_1FBF / 0x1BEAF)
    BP = SP;
    CheckExternalEvents(cs14, 0x1FC2);
    // PUSH DI (19EF_1FC1 / 0x1BEB1)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x1FC3);
    // PUSH SI (19EF_1FC2 / 0x1BEB2)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x1FC4);
    // PUSH DS (19EF_1FC3 / 0x1BEB3)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x1FC7);
    // MOV AX,0x1ddc (19EF_1FC4 / 0x1BEB4)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x1FC9);
    // MOV DS,AX (19EF_1FC7 / 0x1BEB7)
    DS = AX;
    CheckExternalEvents(cs14, 0x1FCA);
    // PUSH ES (19EF_1FC9 / 0x1BEB9)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x1FCD);
    // MOV AX,0xb800 (19EF_1FCA / 0x1BEBA)
    AX = 0xB800;
    CheckExternalEvents(cs14, 0x1FCF);
    // MOV ES,AX (19EF_1FCD / 0x1BEBD)
    ES = AX;
    CheckExternalEvents(cs14, 0x1FD2);
    // MOV DI,0x0 (19EF_1FCF / 0x1BEBF)
    DI = 0x0;
    CheckExternalEvents(cs14, 0x1FD5);
    // MOV CX,0x2000 (19EF_1FD2 / 0x1BEC2)
    CX = 0x2000;
    CheckExternalEvents(cs14, 0x1FDA);
    // CMP word ptr [0xb764],0x0 (19EF_1FD5 / 0x1BEC5)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x1FDC);
    // JZ 0x1000:bef4 (19EF_1FDA / 0x1BECA)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_BEE6_1BEE6, 0x1BEF4 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x1FDE);
    // SHL CH,0x1 (19EF_1FDC / 0x1BECC)
    CH <<= 0x1;
    CheckExternalEvents(cs14, 0x1FE3);
    // CMP word ptr [0xb764],0x1 (19EF_1FDE / 0x1BECE)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs14, 0x1FE5);
    // JZ 0x1000:bef4 (19EF_1FE3 / 0x1BED3)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_BEE6_1BEE6, 0x1BEF4 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x1FE8);
    // MOV AX,0xa000 (19EF_1FE5 / 0x1BED5)
    AX = 0xA000;
    CheckExternalEvents(cs14, 0x1FEA);
    // MOV ES,AX (19EF_1FE8 / 0x1BED8)
    ES = AX;
    CheckExternalEvents(cs14, 0x1FEF);
    // CMP word ptr [0xb764],0x2 (19EF_1FEA / 0x1BEDA)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x1FF1);
    // JZ 0x1000:bee6 (19EF_1FEF / 0x1BEDF)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_BEE6_1BEE6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x1FF3);
    // SHL CH,0x1 (19EF_1FF1 / 0x1BEE1)
    // CH <<= 0x1;
    CH = Alu8.Shl(CH, 0x1);
    CheckExternalEvents(cs14, 0x1FF5);
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
      case 0x1BEF4: goto label_1000_BEF4_1BEF4;break; // Target of external jump from 0x1BEE3
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_BEE6_1BEE6:
    CheckExternalEvents(cs8, 0xBEE9);
    // MOV CX,0x1f40 (1000_BEE6 / 0x1BEE6)
    CX = 0x1F40;
    CheckExternalEvents(cs8, 0xBEEC);
    // MOV DX,0x3ce (1000_BEE9 / 0x1BEE9)
    DX = 0x3CE;
    CheckExternalEvents(cs8, 0xBEEF);
    // MOV AX,0x205 (1000_BEEC / 0x1BEEC)
    AX = 0x205;
    CheckExternalEvents(cs8, 0xBEF0);
    // OUT DX,AX (1000_BEEF / 0x1BEEF)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xBEF3);
    // MOV AX,0xff08 (1000_BEF0 / 0x1BEF0)
    AX = 0xFF08;
    CheckExternalEvents(cs8, 0xBEF4);
    // OUT DX,AX (1000_BEF3 / 0x1BEF3)
    Cpu.Out16(DX, AX);
    label_1000_BEF4_1BEF4:
    CheckExternalEvents(cs8, 0xBEF6);
    // MOV AX,DI (1000_BEF4 / 0x1BEF4)
    AX = DI;
    CheckExternalEvents(cs8, 0xBEF8);
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_BEF6 / 0x1BEF6)
      UInt16[ES, (ushort)(DI)] = AX;
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs8, 0xBEF9);
    // POP ES (1000_BEF8 / 0x1BEF8)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBEFA);
    // POP DS (1000_BEF9 / 0x1BEF9)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBEFB);
    // POP SI (1000_BEFA / 0x1BEFA)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBEFC);
    // POP DI (1000_BEFB / 0x1BEFB)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBEFD);
    // POP BP (1000_BEFC / 0x1BEFC)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBEFE);
    // RETF  (1000_BEFD / 0x1BEFD)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_200E_1BEFE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_200E_1BEFE:
    CheckExternalEvents(cs14, 0x200F);
    // PUSH BP (19EF_200E / 0x1BEFE)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x2011);
    // MOV BP,SP (19EF_200F / 0x1BEFF)
    BP = SP;
    CheckExternalEvents(cs14, 0x2012);
    // PUSH DI (19EF_2011 / 0x1BF01)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x2013);
    // PUSH SI (19EF_2012 / 0x1BF02)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x2014);
    // PUSH DS (19EF_2013 / 0x1BF03)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2017);
    // MOV AX,0x1ddc (19EF_2014 / 0x1BF04)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x2019);
    // MOV DS,AX (19EF_2017 / 0x1BF07)
    DS = AX;
    CheckExternalEvents(cs14, 0x201A);
    // PUSH ES (19EF_2019 / 0x1BF09)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x201D);
    // MOV AX,0xb800 (19EF_201A / 0x1BF0A)
    AX = 0xB800;
    CheckExternalEvents(cs14, 0x201F);
    // MOV ES,AX (19EF_201D / 0x1BF0D)
    ES = AX;
    CheckExternalEvents(cs14, 0x2022);
    // MOV SI,word ptr [BP + 0x6] (19EF_201F / 0x1BF0F)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x2026);
    // MOV word ptr [0xb78a],SI (19EF_2022 / 0x1BF12)
    UInt16[DS, 0xB78A] = SI;
    CheckExternalEvents(cs14, 0x2029);
    // MOV BX,word ptr [BP + 0x8] (19EF_2026 / 0x1BF16)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x202D);
    // MOV word ptr [0xb78c],BX (19EF_2029 / 0x1BF19)
    UInt16[DS, 0xB78C] = BX;
    CheckExternalEvents(cs14, 0x2030);
    // MOV AX,word ptr [BP + 0xa] (19EF_202D / 0x1BF1D)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x2032);
    // SHL AX,0x1 (19EF_2030 / 0x1BF20)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x2034);
    // SHL AX,0x1 (19EF_2032 / 0x1BF22)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs14, 0x2037);
    // MOV [0xb792],AX (19EF_2034 / 0x1BF24)
    UInt16[DS, 0xB792] = AX;
    CheckExternalEvents(cs14, 0x203A);
    // MOV AX,word ptr [BP + 0xc] (19EF_2037 / 0x1BF27)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x203D);
    // MOV [0xb794],AX (19EF_203A / 0x1BF2A)
    UInt16[DS, 0xB794] = AX;
    CheckExternalEvents(cs14, 0x2040);
    // MOV AX,word ptr [BP + 0xe] (19EF_203D / 0x1BF2D)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs14, 0x2042);
    // SHL AX,0x1 (19EF_2040 / 0x1BF30)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x2044);
    // SHL AX,0x1 (19EF_2042 / 0x1BF32)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs14, 0x2047);
    // MOV [0xb79a],AX (19EF_2044 / 0x1BF34)
    UInt16[DS, 0xB79A] = AX;
    CheckExternalEvents(cs14, 0x204A);
    // MOV CX,word ptr [BP + 0x10] (19EF_2047 / 0x1BF37)
    CX = UInt16[SS, (ushort)(BP + 0x10)];
    CheckExternalEvents(cs14, 0x204E);
    // MOV word ptr [0xb79c],CX (19EF_204A / 0x1BF3A)
    UInt16[DS, 0xB79C] = CX;
    CheckExternalEvents(cs14, 0x2053);
    // CMP word ptr [0xb764],0x1 (19EF_204E / 0x1BF3E)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs14, 0x2055);
    // JZ 0x1000:bf7a (19EF_2053 / 0x1BF43)
    if(ZeroFlag) {
      goto label_19EF_208A_1BF7A;
    }
    CheckExternalEvents(cs14, 0x2057);
    // JC 0x1000:bfc5 (19EF_2055 / 0x1BF45)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_BFC5_1BFC5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x205B);
    // SHL word ptr [0xb792],0x1 (19EF_2057 / 0x1BF47)
    // UInt16[DS, 0xB792] <<= 0x1;
    UInt16[DS, 0xB792] = Alu16.Shl(UInt16[DS, 0xB792], 0x1);
    CheckExternalEvents(cs14, 0x205E);
    // MOV AX,0xa000 (19EF_205B / 0x1BF4B)
    AX = 0xA000;
    CheckExternalEvents(cs14, 0x2060);
    // MOV ES,AX (19EF_205E / 0x1BF4E)
    ES = AX;
    label_19EF_2060_1BF50:
    CheckExternalEvents(cs14, 0x2061);
    // PUSH CX (19EF_2060 / 0x1BF50)
    Stack.Push16(CX);
    CheckExternalEvents(cs14, 0x2064);
    // MOV AX,[0xb794] (19EF_2061 / 0x1BF51)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x2068);
    // INC word ptr [0xb794] (19EF_2064 / 0x1BF54)
    UInt16[DS, 0xB794] = Alu16.Inc(UInt16[DS, 0xB794]);
    CheckExternalEvents(cs14, 0x206B);
    // MOV DX,0x140 (19EF_2068 / 0x1BF58)
    DX = 0x140;
    CheckExternalEvents(cs14, 0x206D);
    // MUL DX (19EF_206B / 0x1BF5B)
    uint resMul19EF_206B = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul19EF_206B);
    DX = (ushort)(resMul19EF_206B >> 16);
    CheckExternalEvents(cs14, 0x2071);
    // ADD AX,word ptr [0xb792] (19EF_206D / 0x1BF5D)
    // AX += UInt16[DS, 0xB792];
    AX = Alu16.Add(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs14, 0x2073);
    // MOV DI,AX (19EF_2071 / 0x1BF61)
    DI = AX;
    CheckExternalEvents(cs14, 0x2077);
    // MOV CX,word ptr [0xb79a] (19EF_2073 / 0x1BF63)
    CX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x2078);
    // PUSH DS (19EF_2077 / 0x1BF67)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x207A);
    // MOV DS,BX (19EF_2078 / 0x1BF68)
    DS = BX;
    label_19EF_207A_1BF6A:
    CheckExternalEvents(cs14, 0x207B);
    // LODSB SI (19EF_207A / 0x1BF6A)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x207D);
    // MOV AH,AL (19EF_207B / 0x1BF6B)
    AH = AL;
    CheckExternalEvents(cs14, 0x2080);
    // AND AX,0xff0 (19EF_207D / 0x1BF6D)
    // AX &= 0xFF0;
    AX = Alu16.And(AX, 0xFF0);
    CheckExternalEvents(cs14, 0x2081);
    // STOSW ES:DI (19EF_2080 / 0x1BF70)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x2083);
    // LOOP 0x1000:bf6a (19EF_2081 / 0x1BF71)
    if(--CX != 0) {
      goto label_19EF_207A_1BF6A;
    }
    CheckExternalEvents(cs14, 0x2084);
    // POP DS (19EF_2083 / 0x1BF73)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2085);
    // POP CX (19EF_2084 / 0x1BF74)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2087);
    // LOOP 0x1000:bf50 (19EF_2085 / 0x1BF75)
    if(--CX != 0) {
      goto label_19EF_2060_1BF50;
    }
    CheckExternalEvents(cs14, 0x208A);
    // JMP 0x1000:c011 (19EF_2087 / 0x1BF77)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_BFC5_1BFC5, 0x1C011 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_208A_1BF7A:
    CheckExternalEvents(cs14, 0x208B);
    // PUSH CX (19EF_208A / 0x1BF7A)
    Stack.Push16(CX);
    CheckExternalEvents(cs14, 0x208E);
    // MOV AX,0x28 (19EF_208B / 0x1BF7B)
    AX = 0x28;
    CheckExternalEvents(cs14, 0x2092);
    // MOV DX,word ptr [0xb794] (19EF_208E / 0x1BF7E)
    DX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x2093);
    // PUSH DX (19EF_2092 / 0x1BF82)
    Stack.Push16(DX);
    CheckExternalEvents(cs14, 0x2096);
    // AND DL,0xfc (19EF_2093 / 0x1BF83)
    DL &= 0xFC;
    CheckExternalEvents(cs14, 0x2098);
    // MUL DL (19EF_2096 / 0x1BF86)
    ushort resMul19EF_2096 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul19EF_2096);
    AH = (byte)(resMul19EF_2096 >> 8);
    CheckExternalEvents(cs14, 0x2099);
    // POP DX (19EF_2098 / 0x1BF88)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x209C);
    // AND DL,0x3 (19EF_2099 / 0x1BF89)
    // DL &= 0x3;
    DL = Alu8.And(DL, 0x3);
    CheckExternalEvents(cs14, 0x209E);
    // JZ 0x1000:bf95 (19EF_209C / 0x1BF8C)
    if(ZeroFlag) {
      goto label_19EF_20A5_1BF95;
    }
    CheckExternalEvents(cs14, 0x20A0);
    // MOV CL,DL (19EF_209E / 0x1BF8E)
    CL = DL;
    label_19EF_20A0_1BF90:
    CheckExternalEvents(cs14, 0x20A3);
    // ADD AH,0x20 (19EF_20A0 / 0x1BF90)
    // AH += 0x20;
    AH = Alu8.Add(AH, 0x20);
    CheckExternalEvents(cs14, 0x20A5);
    // LOOP 0x1000:bf90 (19EF_20A3 / 0x1BF93)
    if(--CX != 0) {
      goto label_19EF_20A0_1BF90;
    }
    label_19EF_20A5_1BF95:
    CheckExternalEvents(cs14, 0x20A9);
    // ADD AX,word ptr [0xb792] (19EF_20A5 / 0x1BF95)
    // AX += UInt16[DS, 0xB792];
    AX = Alu16.Add(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs14, 0x20AB);
    // MOV DI,AX (19EF_20A9 / 0x1BF99)
    DI = AX;
    CheckExternalEvents(cs14, 0x20AF);
    // MOV BX,word ptr [0xb78a] (19EF_20AB / 0x1BF9B)
    BX = UInt16[DS, 0xB78A];
    CheckExternalEvents(cs14, 0x20B0);
    // PUSH BX (19EF_20AF / 0x1BF9F)
    Stack.Push16(BX);
    CheckExternalEvents(cs14, 0x20B4);
    // MOV CX,word ptr [0xb79a] (19EF_20B0 / 0x1BFA0)
    CX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x20B6);
    // ADD BX,CX (19EF_20B4 / 0x1BFA4)
    // BX += CX;
    BX = Alu16.Add(BX, CX);
    CheckExternalEvents(cs14, 0x20BA);
    // MOV word ptr [0xb78a],BX (19EF_20B6 / 0x1BFA6)
    UInt16[DS, 0xB78A] = BX;
    CheckExternalEvents(cs14, 0x20BB);
    // POP BX (19EF_20BA / 0x1BFAA)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x20BD);
    // MOV SI,BX (19EF_20BB / 0x1BFAB)
    SI = BX;
    CheckExternalEvents(cs14, 0x20BE);
    // PUSH DS (19EF_20BD / 0x1BFAD)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x20C1);
    // MOV AX,[0xb78c] (19EF_20BE / 0x1BFAE)
    AX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs14, 0x20C3);
    // MOV DS,AX (19EF_20C1 / 0x1BFB1)
    DS = AX;
    CheckExternalEvents(cs14, 0x20C5);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (19EF_20C3 / 0x1BFB3)
      UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs14, 0x20C6);
    // POP DS (19EF_20C5 / 0x1BFB5)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x20CA);
    // MOV BX,word ptr [0xb794] (19EF_20C6 / 0x1BFB6)
    BX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x20CB);
    // INC BX (19EF_20CA / 0x1BFBA)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs14, 0x20CF);
    // MOV word ptr [0xb794],BX (19EF_20CB / 0x1BFBB)
    UInt16[DS, 0xB794] = BX;
    CheckExternalEvents(cs14, 0x20D0);
    // POP CX (19EF_20CF / 0x1BFBF)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x20D2);
    // LOOP 0x1000:bf7a (19EF_20D0 / 0x1BFC0)
    if(--CX != 0) {
      goto label_19EF_208A_1BF7A;
    }
    CheckExternalEvents(cs14, 0x20D4);
    // JMP 0x1000:c011 (19EF_20D2 / 0x1BFC2)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_BFC5_1BFC5, 0x1C011 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_BFC5_1BFC5(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1C011: goto label_1000_C011_1C011;break; // Target of external jump from 0x1BF77
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_BFC5_1BFC5:
    CheckExternalEvents(cs8, 0xBFC9);
    // SHR word ptr [0xb792],0x1 (1000_BFC5 / 0x1BFC5)
    UInt16[DS, 0xB792] >>= 0x1;
    CheckExternalEvents(cs8, 0xBFCD);
    // SHR word ptr [0xb79a],0x1 (1000_BFC9 / 0x1BFC9)
    // UInt16[DS, 0xB79A] >>= 0x1;
    UInt16[DS, 0xB79A] = Alu16.Shr(UInt16[DS, 0xB79A], 0x1);
    label_1000_BFCD_1BFCD:
    CheckExternalEvents(cs8, 0xBFCE);
    // PUSH CX (1000_BFCD / 0x1BFCD)
    Stack.Push16(CX);
    CheckExternalEvents(cs8, 0xBFD1);
    // MOV AX,0x28 (1000_BFCE / 0x1BFCE)
    AX = 0x28;
    CheckExternalEvents(cs8, 0xBFD5);
    // MOV DX,word ptr [0xb794] (1000_BFD1 / 0x1BFD1)
    DX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs8, 0xBFD6);
    // PUSH DX (1000_BFD5 / 0x1BFD5)
    Stack.Push16(DX);
    CheckExternalEvents(cs8, 0xBFD9);
    // AND DL,0xfe (1000_BFD6 / 0x1BFD6)
    DL &= 0xFE;
    CheckExternalEvents(cs8, 0xBFDB);
    // MUL DL (1000_BFD9 / 0x1BFD9)
    ushort resMul1000_BFD9 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_BFD9);
    AH = (byte)(resMul1000_BFD9 >> 8);
    CheckExternalEvents(cs8, 0xBFDC);
    // POP DX (1000_BFDB / 0x1BFDB)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBFDF);
    // TEST DL,0x1 (1000_BFDC / 0x1BFDC)
    Alu8.And(DL, 0x1);
    CheckExternalEvents(cs8, 0xBFE1);
    // JZ 0x1000:bfe4 (1000_BFDF / 0x1BFDF)
    if(ZeroFlag) {
      goto label_1000_BFE4_1BFE4;
    }
    CheckExternalEvents(cs8, 0xBFE4);
    // ADD AH,0x20 (1000_BFE1 / 0x1BFE1)
    AH += 0x20;
    label_1000_BFE4_1BFE4:
    CheckExternalEvents(cs8, 0xBFE8);
    // ADD AX,word ptr [0xb792] (1000_BFE4 / 0x1BFE4)
    // AX += UInt16[DS, 0xB792];
    AX = Alu16.Add(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs8, 0xBFEA);
    // MOV DI,AX (1000_BFE8 / 0x1BFE8)
    DI = AX;
    CheckExternalEvents(cs8, 0xBFEE);
    // MOV BX,word ptr [0xb78a] (1000_BFEA / 0x1BFEA)
    BX = UInt16[DS, 0xB78A];
    CheckExternalEvents(cs8, 0xBFEF);
    // PUSH BX (1000_BFEE / 0x1BFEE)
    Stack.Push16(BX);
    CheckExternalEvents(cs8, 0xBFF3);
    // MOV CX,word ptr [0xb79a] (1000_BFEF / 0x1BFEF)
    CX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs8, 0xBFF5);
    // ADD BX,CX (1000_BFF3 / 0x1BFF3)
    // BX += CX;
    BX = Alu16.Add(BX, CX);
    CheckExternalEvents(cs8, 0xBFF9);
    // MOV word ptr [0xb78a],BX (1000_BFF5 / 0x1BFF5)
    UInt16[DS, 0xB78A] = BX;
    CheckExternalEvents(cs8, 0xBFFA);
    // POP BX (1000_BFF9 / 0x1BFF9)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xBFFC);
    // MOV SI,BX (1000_BFFA / 0x1BFFA)
    SI = BX;
    CheckExternalEvents(cs8, 0xBFFD);
    // PUSH DS (1000_BFFC / 0x1BFFC)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xC000);
    // MOV AX,[0xb78c] (1000_BFFD / 0x1BFFD)
    AX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs8, 0xC002);
    // MOV DS,AX (1000_C000 / 0x1C000)
    DS = AX;
    CheckExternalEvents(cs8, 0xC004);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (1000_C002 / 0x1C002)
      UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs8, 0xC005);
    // POP DS (1000_C004 / 0x1C004)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC009);
    // MOV BX,word ptr [0xb794] (1000_C005 / 0x1C005)
    BX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs8, 0xC00A);
    // INC BX (1000_C009 / 0x1C009)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs8, 0xC00E);
    // MOV word ptr [0xb794],BX (1000_C00A / 0x1C00A)
    UInt16[DS, 0xB794] = BX;
    CheckExternalEvents(cs8, 0xC00F);
    // POP CX (1000_C00E / 0x1C00E)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC011);
    // LOOP 0x1000:bfcd (1000_C00F / 0x1C00F)
    if(--CX != 0) {
      goto label_1000_BFCD_1BFCD;
    }
    label_1000_C011_1C011:
    CheckExternalEvents(cs8, 0xC012);
    // POP ES (1000_C011 / 0x1C011)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC013);
    // POP DS (1000_C012 / 0x1C012)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC014);
    // POP SI (1000_C013 / 0x1C013)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC015);
    // POP DI (1000_C014 / 0x1C014)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC016);
    // POP BP (1000_C015 / 0x1C015)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC017);
    // RETF  (1000_C016 / 0x1C016)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_2127_1C017(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_2127_1C017:
    CheckExternalEvents(cs14, 0x2128);
    // PUSH BP (19EF_2127 / 0x1C017)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x212A);
    // MOV BP,SP (19EF_2128 / 0x1C018)
    BP = SP;
    CheckExternalEvents(cs14, 0x212B);
    // PUSH DI (19EF_212A / 0x1C01A)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x212C);
    // PUSH SI (19EF_212B / 0x1C01B)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x212D);
    // PUSH DS (19EF_212C / 0x1C01C)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2130);
    // MOV AX,0x1ddc (19EF_212D / 0x1C01D)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x2132);
    // MOV DS,AX (19EF_2130 / 0x1C020)
    DS = AX;
    CheckExternalEvents(cs14, 0x2135);
    // MOV AL,byte ptr [BP + 0x6] (19EF_2132 / 0x1C022)
    AL = UInt8[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x2138);
    // MOV [0xb772],AL (19EF_2135 / 0x1C025)
    UInt8[DS, 0xB772] = AL;
    CheckExternalEvents(cs14, 0x213B);
    // MOV AL,byte ptr [BP + 0x8] (19EF_2138 / 0x1C028)
    AL = UInt8[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x213E);
    // MOV [0xb775],AL (19EF_213B / 0x1C02B)
    UInt8[DS, 0xB775] = AL;
    CheckExternalEvents(cs14, 0x2143);
    // CMP word ptr [0xb764],0x0 (19EF_213E / 0x1C02E)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x2145);
    // JZ 0x1000:c067 (19EF_2143 / 0x1C033)
    if(ZeroFlag) {
      goto label_19EF_2177_1C067;
    }
    CheckExternalEvents(cs14, 0x214A);
    // CMP word ptr [0xb764],0x2 (19EF_2145 / 0x1C035)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x214C);
    // JNC 0x1000:c062 (19EF_214A / 0x1C03A)
    if(!CarryFlag) {
      goto label_19EF_2172_1C062;
    }
    CheckExternalEvents(cs14, 0x2150);
    // MOV BL,byte ptr [0xb772] (19EF_214C / 0x1C03C)
    BL = UInt8[DS, 0xB772];
    CheckExternalEvents(cs14, 0x2152);
    // MOV AL,BL (19EF_2150 / 0x1C040)
    AL = BL;
    CheckExternalEvents(cs14, 0x2155);
    // MOV CX,0x4 (19EF_2152 / 0x1C042)
    CX = 0x4;
    CheckExternalEvents(cs14, 0x2157);
    // SHL BL,CL (19EF_2155 / 0x1C045)
    // BL <<= CL;
    BL = Alu8.Shl(BL, CL);
    CheckExternalEvents(cs14, 0x2159);
    // OR BL,AL (19EF_2157 / 0x1C047)
    // BL |= AL;
    BL = Alu8.Or(BL, AL);
    CheckExternalEvents(cs14, 0x215B);
    // MOV BH,BL (19EF_2159 / 0x1C049)
    BH = BL;
    CheckExternalEvents(cs14, 0x215F);
    // MOV word ptr [0xb773],BX (19EF_215B / 0x1C04B)
    UInt16[DS, 0xB773] = BX;
    CheckExternalEvents(cs14, 0x2163);
    // MOV BL,byte ptr [0xb775] (19EF_215F / 0x1C04F)
    BL = UInt8[DS, 0xB775];
    CheckExternalEvents(cs14, 0x2165);
    // MOV AL,BL (19EF_2163 / 0x1C053)
    AL = BL;
    CheckExternalEvents(cs14, 0x2168);
    // MOV CX,0x4 (19EF_2165 / 0x1C055)
    CX = 0x4;
    CheckExternalEvents(cs14, 0x216A);
    // SHL BL,CL (19EF_2168 / 0x1C058)
    // BL <<= CL;
    BL = Alu8.Shl(BL, CL);
    CheckExternalEvents(cs14, 0x216C);
    // OR BL,AL (19EF_216A / 0x1C05A)
    // BL |= AL;
    BL = Alu8.Or(BL, AL);
    CheckExternalEvents(cs14, 0x216E);
    // MOV BH,BL (19EF_216C / 0x1C05C)
    BH = BL;
    CheckExternalEvents(cs14, 0x2172);
    // MOV word ptr [0xb776],BX (19EF_216E / 0x1C05E)
    UInt16[DS, 0xB776] = BX;
    label_19EF_2172_1C062:
    CheckExternalEvents(cs14, 0x2173);
    // POP DS (19EF_2172 / 0x1C062)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2174);
    // POP SI (19EF_2173 / 0x1C063)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2175);
    // POP DI (19EF_2174 / 0x1C064)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2176);
    // POP BP (19EF_2175 / 0x1C065)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2177);
    // RETF  (19EF_2176 / 0x1C066)
    return FarRet();
    label_19EF_2177_1C067:
    CheckExternalEvents(cs14, 0x217B);
    // MOV BL,byte ptr [0xb772] (19EF_2177 / 0x1C067)
    BL = UInt8[DS, 0xB772];
    CheckExternalEvents(cs14, 0x217E);
    // AND BL,0x3 (19EF_217B / 0x1C06B)
    // BL &= 0x3;
    BL = Alu8.And(BL, 0x3);
    CheckExternalEvents(cs14, 0x2180);
    // MOV AL,BL (19EF_217E / 0x1C06E)
    AL = BL;
    CheckExternalEvents(cs14, 0x2184);
    // MOV DL,byte ptr [0xb775] (19EF_2180 / 0x1C070)
    DL = UInt8[DS, 0xB775];
    CheckExternalEvents(cs14, 0x2187);
    // AND DL,0x3 (19EF_2184 / 0x1C074)
    // DL &= 0x3;
    DL = Alu8.And(DL, 0x3);
    CheckExternalEvents(cs14, 0x2189);
    // MOV AH,DL (19EF_2187 / 0x1C077)
    AH = DL;
    CheckExternalEvents(cs14, 0x218C);
    // MOV CX,0x3 (19EF_2189 / 0x1C079)
    CX = 0x3;
    label_19EF_218C_1C07C:
    CheckExternalEvents(cs14, 0x218E);
    // SHL AL,0x1 (19EF_218C / 0x1C07C)
    AL <<= 0x1;
    CheckExternalEvents(cs14, 0x2190);
    // SHL AL,0x1 (19EF_218E / 0x1C07E)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs14, 0x2192);
    // OR BL,AL (19EF_2190 / 0x1C080)
    BL |= AL;
    CheckExternalEvents(cs14, 0x2194);
    // SHL AH,0x1 (19EF_2192 / 0x1C082)
    AH <<= 0x1;
    CheckExternalEvents(cs14, 0x2196);
    // SHL AH,0x1 (19EF_2194 / 0x1C084)
    // AH <<= 0x1;
    AH = Alu8.Shl(AH, 0x1);
    CheckExternalEvents(cs14, 0x2198);
    // OR DL,AH (19EF_2196 / 0x1C086)
    // DL |= AH;
    DL = Alu8.Or(DL, AH);
    CheckExternalEvents(cs14, 0x219A);
    // LOOP 0x1000:c07c (19EF_2198 / 0x1C088)
    if(--CX != 0) {
      goto label_19EF_218C_1C07C;
    }
    CheckExternalEvents(cs14, 0x219C);
    // MOV BH,BL (19EF_219A / 0x1C08A)
    BH = BL;
    CheckExternalEvents(cs14, 0x21A0);
    // MOV word ptr [0xb773],BX (19EF_219C / 0x1C08C)
    UInt16[DS, 0xB773] = BX;
    CheckExternalEvents(cs14, 0x21A2);
    // MOV DH,DL (19EF_21A0 / 0x1C090)
    DH = DL;
    CheckExternalEvents(cs14, 0x21A6);
    // MOV word ptr [0xb776],DX (19EF_21A2 / 0x1C092)
    UInt16[DS, 0xB776] = DX;
    CheckExternalEvents(cs14, 0x21A8);
    // JMP 0x1000:c062 (19EF_21A6 / 0x1C096)
    goto label_19EF_2172_1C062;
  }
  
  public virtual Action ghidra_guess_1000_C098_1C098(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C098_1C098:
    CheckExternalEvents(cs8, 0xC099);
    // PUSH BP (1000_C098 / 0x1C098)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xC09B);
    // MOV BP,SP (1000_C099 / 0x1C099)
    BP = SP;
    CheckExternalEvents(cs8, 0xC09C);
    // PUSH DI (1000_C09B / 0x1C09B)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xC09D);
    // PUSH SI (1000_C09C / 0x1C09C)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xC09E);
    // PUSH DS (1000_C09D / 0x1C09D)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xC0A1);
    // MOV AX,0x1ddc (1000_C09E / 0x1C09E)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xC0A3);
    // MOV DS,AX (1000_C0A1 / 0x1C0A1)
    DS = AX;
    CheckExternalEvents(cs8, 0xC0A6);
    // MOV SI,word ptr [BP + 0x6] (1000_C0A3 / 0x1C0A3)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xC0AA);
    // ADD SI,0xa661 (1000_C0A6 / 0x1C0A6)
    // SI += 0xA661;
    SI = Alu16.Add(SI, 0xA661);
    CheckExternalEvents(cs8, 0xC0AD);
    // MOV AX,word ptr [BP + 0x8] (1000_C0AA / 0x1C0AA)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0xC0B0);
    // MOV DI,word ptr [BP + 0xa] (1000_C0AD / 0x1C0AD)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0xC0B2);
    // ADD DI,AX (1000_C0B0 / 0x1C0B0)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs8, 0xC0B3);
    // PUSH ES (1000_C0B2 / 0x1C0B2)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xC0B6);
    // MOV AX,0xb800 (1000_C0B3 / 0x1C0B3)
    AX = 0xB800;
    CheckExternalEvents(cs8, 0xC0B8);
    // MOV ES,AX (1000_C0B6 / 0x1C0B6)
    ES = AX;
    CheckExternalEvents(cs8, 0xC0BE);
    // MOV word ptr [0xb77c],0x2 (1000_C0B8 / 0x1C0B8)
    UInt16[DS, 0xB77C] = 0x2;
    CheckExternalEvents(cs8, 0xC0C2);
    // MOV DX,word ptr [0xb773] (1000_C0BE / 0x1C0BE)
    DX = UInt16[DS, 0xB773];
    CheckExternalEvents(cs8, 0xC0C6);
    // MOV BP,word ptr [0xb776] (1000_C0C2 / 0x1C0C2)
    BP = UInt16[DS, 0xB776];
    label_1000_C0C6_1C0C6:
    CheckExternalEvents(cs8, 0xC0C9);
    // MOV CX,0x4 (1000_C0C6 / 0x1C0C6)
    CX = 0x4;
    label_1000_C0C9_1C0C9:
    CheckExternalEvents(cs8, 0xC0CA);
    // LODSW SI (1000_C0C9 / 0x1C0C9)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs8, 0xC0CC);
    // MOV BX,AX (1000_C0CA / 0x1C0CA)
    BX = AX;
    CheckExternalEvents(cs8, 0xC0CE);
    // AND AX,DX (1000_C0CC / 0x1C0CC)
    // AX &= DX;
    AX = Alu16.And(AX, DX);
    CheckExternalEvents(cs8, 0xC0D0);
    // NOT BX (1000_C0CE / 0x1C0CE)
    BX = (ushort)(~BX);
    CheckExternalEvents(cs8, 0xC0D2);
    // AND BX,BP (1000_C0D0 / 0x1C0D0)
    // BX &= BP;
    BX = Alu16.And(BX, BP);
    CheckExternalEvents(cs8, 0xC0D4);
    // OR AX,BX (1000_C0D2 / 0x1C0D2)
    // AX |= BX;
    AX = Alu16.Or(AX, BX);
    CheckExternalEvents(cs8, 0xC0D5);
    // STOSW ES:DI (1000_C0D4 / 0x1C0D4)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xC0D6);
    // LODSW SI (1000_C0D5 / 0x1C0D5)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs8, 0xC0D8);
    // MOV BX,AX (1000_C0D6 / 0x1C0D6)
    BX = AX;
    CheckExternalEvents(cs8, 0xC0DA);
    // AND AX,DX (1000_C0D8 / 0x1C0D8)
    // AX &= DX;
    AX = Alu16.And(AX, DX);
    CheckExternalEvents(cs8, 0xC0DC);
    // NOT BX (1000_C0DA / 0x1C0DA)
    BX = (ushort)(~BX);
    CheckExternalEvents(cs8, 0xC0DE);
    // AND BX,BP (1000_C0DC / 0x1C0DC)
    // BX &= BP;
    BX = Alu16.And(BX, BP);
    CheckExternalEvents(cs8, 0xC0E0);
    // OR AX,BX (1000_C0DE / 0x1C0DE)
    // AX |= BX;
    AX = Alu16.Or(AX, BX);
    CheckExternalEvents(cs8, 0xC0E3);
    // MOV word ptr ES:[DI],AX (1000_C0E0 / 0x1C0E0)
    UInt16[ES, (ushort)(DI)] = AX;
    CheckExternalEvents(cs8, 0xC0E7);
    // ADD DI,0x1ffe (1000_C0E3 / 0x1C0E3)
    // DI += 0x1FFE;
    DI = Alu16.Add(DI, 0x1FFE);
    CheckExternalEvents(cs8, 0xC0E9);
    // LOOP 0x1000:c0c9 (1000_C0E7 / 0x1C0E7)
    if(--CX != 0) {
      goto label_1000_C0C9_1C0C9;
    }
    CheckExternalEvents(cs8, 0xC0ED);
    // SUB DI,0x7f60 (1000_C0E9 / 0x1C0E9)
    DI -= 0x7F60;
    CheckExternalEvents(cs8, 0xC0F1);
    // DEC word ptr [0xb77c] (1000_C0ED / 0x1C0ED)
    UInt16[DS, 0xB77C] = Alu16.Dec(UInt16[DS, 0xB77C]);
    CheckExternalEvents(cs8, 0xC0F3);
    // JNZ 0x1000:c0c6 (1000_C0F1 / 0x1C0F1)
    if(!ZeroFlag) {
      goto label_1000_C0C6_1C0C6;
    }
    CheckExternalEvents(cs8, 0xC0F4);
    // POP ES (1000_C0F3 / 0x1C0F3)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC0F5);
    // POP DS (1000_C0F4 / 0x1C0F4)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC0F6);
    // POP SI (1000_C0F5 / 0x1C0F5)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC0F7);
    // POP DI (1000_C0F6 / 0x1C0F6)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC0F8);
    // POP BP (1000_C0F7 / 0x1C0F7)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC0F9);
    // RETF  (1000_C0F8 / 0x1C0F8)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_C0F9_1C0F9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C0F9_1C0F9:
    CheckExternalEvents(cs8, 0xC0FA);
    // PUSH BP (1000_C0F9 / 0x1C0F9)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xC0FC);
    // MOV BP,SP (1000_C0FA / 0x1C0FA)
    BP = SP;
    CheckExternalEvents(cs8, 0xC0FD);
    // PUSH DI (1000_C0FC / 0x1C0FC)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xC0FE);
    // PUSH SI (1000_C0FD / 0x1C0FD)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xC0FF);
    // PUSH DS (1000_C0FE / 0x1C0FE)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xC102);
    // MOV AX,0x1ddc (1000_C0FF / 0x1C0FF)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xC104);
    // MOV DS,AX (1000_C102 / 0x1C102)
    DS = AX;
    CheckExternalEvents(cs8, 0xC107);
    // MOV SI,word ptr [BP + 0x6] (1000_C104 / 0x1C104)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xC10B);
    // ADD SI,0xa661 (1000_C107 / 0x1C107)
    // SI += 0xA661;
    SI = Alu16.Add(SI, 0xA661);
    CheckExternalEvents(cs8, 0xC10E);
    // MOV AX,word ptr [BP + 0x8] (1000_C10B / 0x1C10B)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0xC111);
    // MOV DI,word ptr [BP + 0xa] (1000_C10E / 0x1C10E)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0xC113);
    // ADD DI,AX (1000_C111 / 0x1C111)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs8, 0xC114);
    // PUSH ES (1000_C113 / 0x1C113)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xC117);
    // MOV AX,0xb800 (1000_C114 / 0x1C114)
    AX = 0xB800;
    CheckExternalEvents(cs8, 0xC119);
    // MOV ES,AX (1000_C117 / 0x1C117)
    ES = AX;
    CheckExternalEvents(cs8, 0xC11C);
    // MOV DX,0x2000 (1000_C119 / 0x1C119)
    DX = 0x2000;
    CheckExternalEvents(cs8, 0xC120);
    // MOV BP,word ptr [0xb773] (1000_C11C / 0x1C11C)
    BP = UInt16[DS, 0xB773];
    CheckExternalEvents(cs8, 0xC123);
    // MOV CX,0x8 (1000_C120 / 0x1C120)
    CX = 0x8;
    label_1000_C123_1C123:
    CheckExternalEvents(cs8, 0xC124);
    // LODSW SI (1000_C123 / 0x1C123)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs8, 0xC126);
    // MOV BX,AX (1000_C124 / 0x1C124)
    BX = AX;
    CheckExternalEvents(cs8, 0xC128);
    // AND AX,BP (1000_C126 / 0x1C126)
    // AX &= BP;
    AX = Alu16.And(AX, BP);
    CheckExternalEvents(cs8, 0xC12A);
    // NOT BX (1000_C128 / 0x1C128)
    BX = (ushort)(~BX);
    CheckExternalEvents(cs8, 0xC12E);
    // AND BX,word ptr [0xb776] (1000_C12A / 0x1C12A)
    // BX &= UInt16[DS, 0xB776];
    BX = Alu16.And(BX, UInt16[DS, 0xB776]);
    CheckExternalEvents(cs8, 0xC130);
    // OR AX,BX (1000_C12E / 0x1C12E)
    // AX |= BX;
    AX = Alu16.Or(AX, BX);
    CheckExternalEvents(cs8, 0xC133);
    // MOV word ptr ES:[DI],AX (1000_C130 / 0x1C130)
    UInt16[ES, (ushort)(DI)] = AX;
    CheckExternalEvents(cs8, 0xC135);
    // ADD DI,DX (1000_C133 / 0x1C133)
    DI += DX;
    CheckExternalEvents(cs8, 0xC139);
    // XOR DX,0xc050 (1000_C135 / 0x1C135)
    // DX ^= 0xC050;
    DX = Alu16.Xor(DX, 0xC050);
    CheckExternalEvents(cs8, 0xC13B);
    // LOOP 0x1000:c123 (1000_C139 / 0x1C139)
    if(--CX != 0) {
      goto label_1000_C123_1C123;
    }
    CheckExternalEvents(cs8, 0xC13C);
    // POP ES (1000_C13B / 0x1C13B)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC13D);
    // POP DS (1000_C13C / 0x1C13C)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC13E);
    // POP SI (1000_C13D / 0x1C13D)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC13F);
    // POP DI (1000_C13E / 0x1C13E)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC140);
    // POP BP (1000_C13F / 0x1C13F)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC141);
    // RETF  (1000_C140 / 0x1C140)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_2251_1C141(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_2251_1C141:
    CheckExternalEvents(cs14, 0x2252);
    // PUSH BP (19EF_2251 / 0x1C141)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x2254);
    // MOV BP,SP (19EF_2252 / 0x1C142)
    BP = SP;
    CheckExternalEvents(cs14, 0x2255);
    // PUSH DI (19EF_2254 / 0x1C144)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x2256);
    // PUSH SI (19EF_2255 / 0x1C145)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x2257);
    // PUSH DS (19EF_2256 / 0x1C146)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x225A);
    // MOV AX,0x1ddc (19EF_2257 / 0x1C147)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x225C);
    // MOV DS,AX (19EF_225A / 0x1C14A)
    DS = AX;
    CheckExternalEvents(cs14, 0x225F);
    // MOV SI,word ptr [BP + 0x6] (19EF_225C / 0x1C14C)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x2263);
    // ADD SI,0xa661 (19EF_225F / 0x1C14F)
    // SI += 0xA661;
    SI = Alu16.Add(SI, 0xA661);
    CheckExternalEvents(cs14, 0x2266);
    // MOV AX,word ptr [BP + 0x8] (19EF_2263 / 0x1C153)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x2269);
    // MOV DI,word ptr [BP + 0xa] (19EF_2266 / 0x1C156)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x226B);
    // ADD DI,AX (19EF_2269 / 0x1C159)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs14, 0x226D);
    // MOV BP,ES (19EF_226B / 0x1C15B)
    BP = ES;
    CheckExternalEvents(cs14, 0x2270);
    // MOV AX,0xa000 (19EF_226D / 0x1C15D)
    AX = 0xA000;
    CheckExternalEvents(cs14, 0x2272);
    // MOV ES,AX (19EF_2270 / 0x1C160)
    ES = AX;
    CheckExternalEvents(cs14, 0x2275);
    // MOV DX,0x3ce (19EF_2272 / 0x1C162)
    DX = 0x3CE;
    CheckExternalEvents(cs14, 0x2278);
    // MOV AX,0x205 (19EF_2275 / 0x1C165)
    AX = 0x205;
    CheckExternalEvents(cs14, 0x2279);
    // OUT DX,AX (19EF_2278 / 0x1C168)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x227D);
    // MOV BL,byte ptr [0xb772] (19EF_2279 / 0x1C169)
    BL = UInt8[DS, 0xB772];
    CheckExternalEvents(cs14, 0x2281);
    // MOV BH,byte ptr [0xb775] (19EF_227D / 0x1C16D)
    BH = UInt8[DS, 0xB775];
    CheckExternalEvents(cs14, 0x2284);
    // MOV CX,0x8 (19EF_2281 / 0x1C171)
    CX = 0x8;
    CheckExternalEvents(cs14, 0x2286);
    // MOV AL,CL (19EF_2284 / 0x1C174)
    AL = CL;
    label_19EF_2286_1C176:
    CheckExternalEvents(cs14, 0x2288);
    // MOV AH,byte ptr [SI] (19EF_2286 / 0x1C176)
    AH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x2289);
    // OUT DX,AX (19EF_2288 / 0x1C178)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x228B);
    // MOV AH,BL (19EF_2289 / 0x1C179)
    AH = BL;
    CheckExternalEvents(cs14, 0x228E);
    // XCHG byte ptr ES:[DI],AH (19EF_228B / 0x1C17B)
    (AH, UInt8[ES, (ushort)(DI)]) = (UInt8[ES, (ushort)(DI)], AH);
    CheckExternalEvents(cs14, 0x2290);
    // MOV AH,byte ptr [SI] (19EF_228E / 0x1C17E)
    AH = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x2292);
    // NOT AH (19EF_2290 / 0x1C180)
    AH = (byte)(~AH);
    CheckExternalEvents(cs14, 0x2293);
    // OUT DX,AX (19EF_2292 / 0x1C182)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x2295);
    // MOV AH,BH (19EF_2293 / 0x1C183)
    AH = BH;
    CheckExternalEvents(cs14, 0x2298);
    // XCHG byte ptr ES:[DI],AH (19EF_2295 / 0x1C185)
    (AH, UInt8[ES, (ushort)(DI)]) = (UInt8[ES, (ushort)(DI)], AH);
    CheckExternalEvents(cs14, 0x2299);
    // INC SI (19EF_2298 / 0x1C188)
    SI++;
    CheckExternalEvents(cs14, 0x229C);
    // ADD DI,0x28 (19EF_2299 / 0x1C189)
    // DI += 0x28;
    DI = Alu16.Add(DI, 0x28);
    CheckExternalEvents(cs14, 0x229E);
    // LOOP 0x1000:c176 (19EF_229C / 0x1C18C)
    if(--CX != 0) {
      goto label_19EF_2286_1C176;
    }
    CheckExternalEvents(cs14, 0x22A0);
    // MOV ES,BP (19EF_229E / 0x1C18E)
    ES = BP;
    CheckExternalEvents(cs14, 0x22A1);
    // POP DS (19EF_22A0 / 0x1C190)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x22A2);
    // POP SI (19EF_22A1 / 0x1C191)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x22A3);
    // POP DI (19EF_22A2 / 0x1C192)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x22A4);
    // POP BP (19EF_22A3 / 0x1C193)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x22A5);
    // RETF  (19EF_22A4 / 0x1C194)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_22A5_1C195(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1C1C2: goto label_19EF_22D2_1C1C2;break; // Target of external jump from 0x1C1DF
      case 0x1C1C6: goto label_19EF_22D6_1C1C6;break; // Target of external jump from 0x1C1D7, 0x1C1CE
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_19EF_22A5_1C195:
    CheckExternalEvents(cs14, 0x22A6);
    // PUSH BP (19EF_22A5 / 0x1C195)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x22A8);
    // MOV BP,SP (19EF_22A6 / 0x1C196)
    BP = SP;
    CheckExternalEvents(cs14, 0x22A9);
    // PUSH DI (19EF_22A8 / 0x1C198)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x22AA);
    // PUSH SI (19EF_22A9 / 0x1C199)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x22AB);
    // PUSH DS (19EF_22AA / 0x1C19A)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x22AE);
    // MOV AX,0x1ddc (19EF_22AB / 0x1C19B)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x22B0);
    // MOV DS,AX (19EF_22AE / 0x1C19E)
    DS = AX;
    CheckExternalEvents(cs14, 0x22B3);
    // MOV SI,word ptr [BP + 0x6] (19EF_22B0 / 0x1C1A0)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x22B7);
    // ADD SI,0xa661 (19EF_22B3 / 0x1C1A3)
    // SI += 0xA661;
    SI = Alu16.Add(SI, 0xA661);
    CheckExternalEvents(cs14, 0x22BA);
    // MOV AX,word ptr [BP + 0x8] (19EF_22B7 / 0x1C1A7)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x22BC);
    // MOV DI,AX (19EF_22BA / 0x1C1AA)
    DI = AX;
    CheckExternalEvents(cs14, 0x22BF);
    // MOV AX,word ptr [BP + 0xa] (19EF_22BC / 0x1C1AC)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x22C1);
    // ADD DI,AX (19EF_22BF / 0x1C1AF)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs14, 0x22C3);
    // MOV BP,ES (19EF_22C1 / 0x1C1B1)
    BP = ES;
    CheckExternalEvents(cs14, 0x22C6);
    // MOV AX,0xa000 (19EF_22C3 / 0x1C1B3)
    AX = 0xA000;
    CheckExternalEvents(cs14, 0x22C8);
    // MOV ES,AX (19EF_22C6 / 0x1C1B6)
    ES = AX;
    CheckExternalEvents(cs14, 0x22CA);
    // MOV BL,0x8 (19EF_22C8 / 0x1C1B8)
    BL = 0x8;
    CheckExternalEvents(cs14, 0x22CE);
    // MOV DH,byte ptr [0xb772] (19EF_22CA / 0x1C1BA)
    DH = UInt8[DS, 0xB772];
    CheckExternalEvents(cs14, 0x22D2);
    // MOV DL,byte ptr [0xb775] (19EF_22CE / 0x1C1BE)
    DL = UInt8[DS, 0xB775];
    label_19EF_22D2_1C1C2:
    CheckExternalEvents(cs14, 0x22D3);
    // LODSB SI (19EF_22D2 / 0x1C1C2)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x22D6);
    // MOV CX,0x8 (19EF_22D3 / 0x1C1C3)
    CX = 0x8;
    label_19EF_22D6_1C1C6:
    CheckExternalEvents(cs14, 0x22D8);
    // SHL AL,0x1 (19EF_22D6 / 0x1C1C6)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs14, 0x22DA);
    // JC 0x1000:c1d3 (19EF_22D8 / 0x1C1C8)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_C1D3_1C1D3, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x22DD);
    // MOV byte ptr ES:[DI],DL (19EF_22DA / 0x1C1CA)
    UInt8[ES, (ushort)(DI)] = DL;
    CheckExternalEvents(cs14, 0x22DE);
    // INC DI (19EF_22DD / 0x1C1CD)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs14, 0x22E0);
    // LOOP 0x1000:c1c6 (19EF_22DE / 0x1C1CE)
    if(--CX != 0) {
      goto label_19EF_22D6_1C1C6;
    }
    CheckExternalEvents(cs14, 0x22E2);
    // JMP 0x1000:c1d9 (19EF_22E0 / 0x1C1D0)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_C1D3_1C1D3, 0x1C1D9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_C1D3_1C1D3(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1C1D9: goto label_1000_C1D9_1C1D9;break; // Target of external jump from 0x1C1D0
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C1D3_1C1D3:
    CheckExternalEvents(cs8, 0xC1D6);
    // MOV byte ptr ES:[DI],DH (1000_C1D3 / 0x1C1D3)
    UInt8[ES, (ushort)(DI)] = DH;
    CheckExternalEvents(cs8, 0xC1D7);
    // INC DI (1000_C1D6 / 0x1C1D6)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs8, 0xC1D9);
    // LOOP 0x1000:c1c6 (1000_C1D7 / 0x1C1D7)
    if(--CX != 0) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(unknown_19EF_22A5_1C195, 0x1C1C6 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_C1D9_1C1D9:
    CheckExternalEvents(cs8, 0xC1DD);
    // ADD DI,0x138 (1000_C1D9 / 0x1C1D9)
    DI += 0x138;
    CheckExternalEvents(cs8, 0xC1DF);
    // DEC BL (1000_C1DD / 0x1C1DD)
    BL = Alu8.Dec(BL);
    CheckExternalEvents(cs8, 0xC1E1);
    // JNZ 0x1000:c1c2 (1000_C1DF / 0x1C1DF)
    if(!ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(unknown_19EF_22A5_1C195, 0x1C1C2 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC1E3);
    // MOV ES,BP (1000_C1E1 / 0x1C1E1)
    ES = BP;
    CheckExternalEvents(cs8, 0xC1E4);
    // POP DS (1000_C1E3 / 0x1C1E3)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC1E5);
    // POP SI (1000_C1E4 / 0x1C1E4)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC1E6);
    // POP DI (1000_C1E5 / 0x1C1E5)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC1E7);
    // POP BP (1000_C1E6 / 0x1C1E6)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC1E8);
    // RETF  (1000_C1E7 / 0x1C1E7)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_22F8_1C1E8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_22F8_1C1E8:
    CheckExternalEvents(cs14, 0x22F9);
    // PUSH BP (19EF_22F8 / 0x1C1E8)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x22FB);
    // MOV BP,SP (19EF_22F9 / 0x1C1E9)
    BP = SP;
    CheckExternalEvents(cs14, 0x22FC);
    // PUSH DI (19EF_22FB / 0x1C1EB)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x22FD);
    // PUSH SI (19EF_22FC / 0x1C1EC)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x22FE);
    // PUSH DS (19EF_22FD / 0x1C1ED)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2301);
    // MOV AX,0x1ddc (19EF_22FE / 0x1C1EE)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x2303);
    // MOV DS,AX (19EF_2301 / 0x1C1F1)
    DS = AX;
    CheckExternalEvents(cs14, 0x2304);
    // PUSH ES (19EF_2303 / 0x1C1F3)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x2305);
    // PUSH DS (19EF_2304 / 0x1C1F4)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2308);
    // MOV AX,word ptr [BP + 0x6] (19EF_2305 / 0x1C1F5)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x230B);
    // MOV [0xb78a],AX (19EF_2308 / 0x1C1F8)
    UInt16[DS, 0xB78A] = AX;
    CheckExternalEvents(cs14, 0x230E);
    // MOV AX,word ptr [BP + 0x8] (19EF_230B / 0x1C1FB)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x2311);
    // MOV [0xb78c],AX (19EF_230E / 0x1C1FE)
    UInt16[DS, 0xB78C] = AX;
    CheckExternalEvents(cs14, 0x2314);
    // MOV AX,word ptr [BP + 0xa] (19EF_2311 / 0x1C201)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x2317);
    // MOV [0xb78e],AX (19EF_2314 / 0x1C204)
    UInt16[DS, 0xB78E] = AX;
    CheckExternalEvents(cs14, 0x231A);
    // MOV AX,word ptr [BP + 0xc] (19EF_2317 / 0x1C207)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x231D);
    // MOV [0xb790],AX (19EF_231A / 0x1C20A)
    UInt16[DS, 0xB790] = AX;
    CheckExternalEvents(cs14, 0x231F);
    // MOV ES,AX (19EF_231D / 0x1C20D)
    ES = AX;
    CheckExternalEvents(cs14, 0x2323);
    // MOV DI,word ptr [0xb78e] (19EF_231F / 0x1C20F)
    DI = UInt16[DS, 0xB78E];
    CheckExternalEvents(cs14, 0x2327);
    // MOV SI,word ptr [0xb78a] (19EF_2323 / 0x1C213)
    SI = UInt16[DS, 0xB78A];
    CheckExternalEvents(cs14, 0x232A);
    // MOV AX,[0xb78c] (19EF_2327 / 0x1C217)
    AX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs14, 0x232C);
    // MOV DS,AX (19EF_232A / 0x1C21A)
    DS = AX;
    CheckExternalEvents(cs14, 0x232E);
    // JMP 0x1000:c226 (19EF_232C / 0x1C21C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_C226_1C226, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_C21F_1C21F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C21F_1C21F:
    CheckExternalEvents(cs8, 0xC220);
    // INC SI (1000_C21F / 0x1C21F)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC222);
    // MOV AX,word ptr [SI] (1000_C220 / 0x1C220)
    AX = UInt16[DS, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xC223);
    // INC SI (1000_C222 / 0x1C222)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC225);
    // JMP 0x1000:c237 (1000_C223 / 0x1C223)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_C226_1C226, 0x1C237 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_C226_1C226(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1C237: goto label_1000_C237_1C237;break; // Target of external jump from 0x1C223
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C226_1C226:
    CheckExternalEvents(cs8, 0xC229);
    // MOV DX,0x7d00 (1000_C226 / 0x1C226)
    DX = 0x7D00;
    label_1000_C229_1C229:
    CheckExternalEvents(cs8, 0xC22B);
    // XOR BX,BX (1000_C229 / 0x1C229)
    BX = 0;
    CheckExternalEvents(cs8, 0xC22D);
    // XOR AX,AX (1000_C22B / 0x1C22B)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0xC22F);
    // MOV AL,byte ptr [SI] (1000_C22D / 0x1C22D)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xC231);
    // CMP AL,0x0 (1000_C22F / 0x1C22F)
    Alu8.Sub(AL, 0x0);
    CheckExternalEvents(cs8, 0xC233);
    // JZ 0x1000:c21f (1000_C231 / 0x1C231)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_C21F_1C21F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC235);
    // JNS 0x1000:c238 (1000_C233 / 0x1C233)
    if(!SignFlag) {
      goto label_1000_C238_1C238;
    }
    CheckExternalEvents(cs8, 0xC237);
    // NEG AL (1000_C235 / 0x1C235)
    AL = Alu8.Sub(0, AL);
    label_1000_C237_1C237:
    CheckExternalEvents(cs8, 0xC238);
    // DEC BX (1000_C237 / 0x1C237)
    BX = Alu16.Dec(BX);
    label_1000_C238_1C238:
    CheckExternalEvents(cs8, 0xC23A);
    // MOV CX,AX (1000_C238 / 0x1C238)
    CX = AX;
    label_1000_C23A_1C23A:
    CheckExternalEvents(cs8, 0xC23B);
    // INC SI (1000_C23A / 0x1C23A)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC23D);
    // MOV AL,byte ptr [SI] (1000_C23B / 0x1C23B)
    AL = UInt8[DS, (ushort)(SI)];
    label_1000_C23D_1C23D:
    CheckExternalEvents(cs8, 0xC23E);
    // STOSB ES:DI (1000_C23D / 0x1C23D)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xC23F);
    // DEC DX (1000_C23E / 0x1C23E)
    DX = Alu16.Dec(DX);
    CheckExternalEvents(cs8, 0xC241);
    // JZ 0x1000:c251 (1000_C23F / 0x1C23F)
    if(ZeroFlag) {
      goto label_1000_C251_1C251;
    }
    CheckExternalEvents(cs8, 0xC245);
    // TEST BX,0x1 (1000_C241 / 0x1C241)
    Alu16.And(BX, 0x1);
    CheckExternalEvents(cs8, 0xC247);
    // JNZ 0x1000:c24c (1000_C245 / 0x1C245)
    if(!ZeroFlag) {
      goto label_1000_C24C_1C24C;
    }
    CheckExternalEvents(cs8, 0xC249);
    // LOOP 0x1000:c23a (1000_C247 / 0x1C247)
    if(--CX != 0) {
      goto label_1000_C23A_1C23A;
    }
    CheckExternalEvents(cs8, 0xC24A);
    // INC SI (1000_C249 / 0x1C249)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC24C);
    // JMP 0x1000:c229 (1000_C24A / 0x1C24A)
    goto label_1000_C229_1C229;
    label_1000_C24C_1C24C:
    CheckExternalEvents(cs8, 0xC24E);
    // LOOP 0x1000:c23d (1000_C24C / 0x1C24C)
    if(--CX != 0) {
      goto label_1000_C23D_1C23D;
    }
    CheckExternalEvents(cs8, 0xC24F);
    // INC SI (1000_C24E / 0x1C24E)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC251);
    // JMP 0x1000:c229 (1000_C24F / 0x1C24F)
    goto label_1000_C229_1C229;
    label_1000_C251_1C251:
    CheckExternalEvents(cs8, 0xC252);
    // POP DS (1000_C251 / 0x1C251)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC253);
    // POP ES (1000_C252 / 0x1C252)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC254);
    // POP DS (1000_C253 / 0x1C253)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC255);
    // POP SI (1000_C254 / 0x1C254)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC256);
    // POP DI (1000_C255 / 0x1C255)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC257);
    // POP BP (1000_C256 / 0x1C256)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC258);
    // RETF  (1000_C257 / 0x1C257)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_2368_1C258(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_2368_1C258:
    CheckExternalEvents(cs14, 0x2369);
    // PUSH BP (19EF_2368 / 0x1C258)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x236B);
    // MOV BP,SP (19EF_2369 / 0x1C259)
    BP = SP;
    CheckExternalEvents(cs14, 0x236C);
    // PUSH DI (19EF_236B / 0x1C25B)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x236D);
    // PUSH SI (19EF_236C / 0x1C25C)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x236E);
    // PUSH DS (19EF_236D / 0x1C25D)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2371);
    // MOV AX,0x1ddc (19EF_236E / 0x1C25E)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x2373);
    // MOV DS,AX (19EF_2371 / 0x1C261)
    DS = AX;
    CheckExternalEvents(cs14, 0x2374);
    // PUSH ES (19EF_2373 / 0x1C263)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x2375);
    // PUSH DS (19EF_2374 / 0x1C264)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2378);
    // MOV AX,word ptr [BP + 0x6] (19EF_2375 / 0x1C265)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x237B);
    // MOV [0xb78a],AX (19EF_2378 / 0x1C268)
    UInt16[DS, 0xB78A] = AX;
    CheckExternalEvents(cs14, 0x237E);
    // MOV AX,word ptr [BP + 0x8] (19EF_237B / 0x1C26B)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x2381);
    // MOV [0xb78c],AX (19EF_237E / 0x1C26E)
    UInt16[DS, 0xB78C] = AX;
    CheckExternalEvents(cs14, 0x2384);
    // MOV AX,word ptr [BP + 0xa] (19EF_2381 / 0x1C271)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x2387);
    // MOV [0xb78e],AX (19EF_2384 / 0x1C274)
    UInt16[DS, 0xB78E] = AX;
    CheckExternalEvents(cs14, 0x238A);
    // MOV AX,word ptr [BP + 0xc] (19EF_2387 / 0x1C277)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x238D);
    // MOV [0xb790],AX (19EF_238A / 0x1C27A)
    UInt16[DS, 0xB790] = AX;
    CheckExternalEvents(cs14, 0x238F);
    // MOV ES,AX (19EF_238D / 0x1C27D)
    ES = AX;
    CheckExternalEvents(cs14, 0x2393);
    // MOV DI,word ptr [0xb78e] (19EF_238F / 0x1C27F)
    DI = UInt16[DS, 0xB78E];
    CheckExternalEvents(cs14, 0x2397);
    // MOV SI,word ptr [0xb78a] (19EF_2393 / 0x1C283)
    SI = UInt16[DS, 0xB78A];
    CheckExternalEvents(cs14, 0x239A);
    // MOV AX,[0xb78c] (19EF_2397 / 0x1C287)
    AX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs14, 0x239C);
    // MOV DS,AX (19EF_239A / 0x1C28A)
    DS = AX;
    CheckExternalEvents(cs14, 0x239E);
    // JMP 0x1000:c296 (19EF_239C / 0x1C28C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_C296_1C296, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_C28F_1C28F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C28F_1C28F:
    CheckExternalEvents(cs8, 0xC290);
    // INC SI (1000_C28F / 0x1C28F)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC292);
    // MOV AX,word ptr [SI] (1000_C290 / 0x1C290)
    AX = UInt16[DS, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xC293);
    // INC SI (1000_C292 / 0x1C292)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC295);
    // JMP 0x1000:c2a9 (1000_C293 / 0x1C293)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_C296_1C296, 0x1C2A9 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_C296_1C296(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1C2A9: goto label_1000_C2A9_1C2A9;break; // Target of external jump from 0x1C293
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C296_1C296:
    CheckExternalEvents(cs8, 0xC299);
    // MOV DX,0x7d00 (1000_C296 / 0x1C296)
    DX = 0x7D00;
    CheckExternalEvents(cs8, 0xC29B);
    // MOV BL,0xc8 (1000_C299 / 0x1C299)
    BL = 0xC8;
    label_1000_C29B_1C29B:
    CheckExternalEvents(cs8, 0xC29D);
    // SUB BH,BH (1000_C29B / 0x1C29B)
    BH -= BH;
    CheckExternalEvents(cs8, 0xC29F);
    // SUB AX,AX (1000_C29D / 0x1C29D)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0xC2A1);
    // MOV AL,byte ptr [SI] (1000_C29F / 0x1C29F)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xC2A3);
    // CMP AL,0x0 (1000_C2A1 / 0x1C2A1)
    Alu8.Sub(AL, 0x0);
    CheckExternalEvents(cs8, 0xC2A5);
    // JZ 0x1000:c28f (1000_C2A3 / 0x1C2A3)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_C28F_1C28F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC2A7);
    // JNS 0x1000:c2ab (1000_C2A5 / 0x1C2A5)
    if(!SignFlag) {
      goto label_1000_C2AB_1C2AB;
    }
    CheckExternalEvents(cs8, 0xC2A9);
    // NEG AL (1000_C2A7 / 0x1C2A7)
    AL = Alu8.Sub(0, AL);
    label_1000_C2A9_1C2A9:
    CheckExternalEvents(cs8, 0xC2AB);
    // DEC BH (1000_C2A9 / 0x1C2A9)
    BH = Alu8.Dec(BH);
    label_1000_C2AB_1C2AB:
    CheckExternalEvents(cs8, 0xC2AD);
    // MOV CX,AX (1000_C2AB / 0x1C2AB)
    CX = AX;
    label_1000_C2AD_1C2AD:
    CheckExternalEvents(cs8, 0xC2AE);
    // INC SI (1000_C2AD / 0x1C2AD)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC2B0);
    // MOV AL,byte ptr [SI] (1000_C2AE / 0x1C2AE)
    AL = UInt8[DS, (ushort)(SI)];
    label_1000_C2B0_1C2B0:
    CheckExternalEvents(cs8, 0xC2B3);
    // MOV byte ptr ES:[DI],AL (1000_C2B0 / 0x1C2B0)
    UInt8[ES, (ushort)(DI)] = AL;
    CheckExternalEvents(cs8, 0xC2B7);
    // ADD DI,0xa0 (1000_C2B3 / 0x1C2B3)
    DI += 0xA0;
    CheckExternalEvents(cs8, 0xC2B9);
    // DEC BL (1000_C2B7 / 0x1C2B7)
    BL = Alu8.Dec(BL);
    CheckExternalEvents(cs8, 0xC2BB);
    // JZ 0x1000:c2cd (1000_C2B9 / 0x1C2B9)
    if(ZeroFlag) {
      goto label_1000_C2CD_1C2CD;
    }
    label_1000_C2BB_1C2BB:
    CheckExternalEvents(cs8, 0xC2BC);
    // DEC DX (1000_C2BB / 0x1C2BB)
    DX = Alu16.Dec(DX);
    CheckExternalEvents(cs8, 0xC2BE);
    // JZ 0x1000:c2d5 (1000_C2BC / 0x1C2BC)
    if(ZeroFlag) {
      goto label_1000_C2D5_1C2D5;
    }
    CheckExternalEvents(cs8, 0xC2C1);
    // TEST BH,0x1 (1000_C2BE / 0x1C2BE)
    Alu8.And(BH, 0x1);
    CheckExternalEvents(cs8, 0xC2C3);
    // JNZ 0x1000:c2c8 (1000_C2C1 / 0x1C2C1)
    if(!ZeroFlag) {
      goto label_1000_C2C8_1C2C8;
    }
    CheckExternalEvents(cs8, 0xC2C5);
    // LOOP 0x1000:c2ad (1000_C2C3 / 0x1C2C3)
    if(--CX != 0) {
      goto label_1000_C2AD_1C2AD;
    }
    CheckExternalEvents(cs8, 0xC2C6);
    // INC SI (1000_C2C5 / 0x1C2C5)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC2C8);
    // JMP 0x1000:c29b (1000_C2C6 / 0x1C2C6)
    goto label_1000_C29B_1C29B;
    label_1000_C2C8_1C2C8:
    CheckExternalEvents(cs8, 0xC2CA);
    // LOOP 0x1000:c2b0 (1000_C2C8 / 0x1C2C8)
    if(--CX != 0) {
      goto label_1000_C2B0_1C2B0;
    }
    CheckExternalEvents(cs8, 0xC2CB);
    // INC SI (1000_C2CA / 0x1C2CA)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC2CD);
    // JMP 0x1000:c29b (1000_C2CB / 0x1C2CB)
    goto label_1000_C29B_1C29B;
    label_1000_C2CD_1C2CD:
    CheckExternalEvents(cs8, 0xC2CF);
    // MOV BL,0xc8 (1000_C2CD / 0x1C2CD)
    BL = 0xC8;
    CheckExternalEvents(cs8, 0xC2D3);
    // SUB DI,0x7cff (1000_C2CF / 0x1C2CF)
    // DI -= 0x7CFF;
    DI = Alu16.Sub(DI, 0x7CFF);
    CheckExternalEvents(cs8, 0xC2D5);
    // JMP 0x1000:c2bb (1000_C2D3 / 0x1C2D3)
    goto label_1000_C2BB_1C2BB;
    label_1000_C2D5_1C2D5:
    CheckExternalEvents(cs8, 0xC2D6);
    // POP DS (1000_C2D5 / 0x1C2D5)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC2D7);
    // POP ES (1000_C2D6 / 0x1C2D6)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC2D8);
    // POP DS (1000_C2D7 / 0x1C2D7)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC2D9);
    // POP SI (1000_C2D8 / 0x1C2D8)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC2DA);
    // POP DI (1000_C2D9 / 0x1C2D9)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC2DB);
    // POP BP (1000_C2DA / 0x1C2DA)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC2DC);
    // RETF  (1000_C2DB / 0x1C2DB)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_23EC_1C2DC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_23EC_1C2DC:
    CheckExternalEvents(cs14, 0x23ED);
    // PUSH BP (19EF_23EC / 0x1C2DC)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x23EF);
    // MOV BP,SP (19EF_23ED / 0x1C2DD)
    BP = SP;
    CheckExternalEvents(cs14, 0x23F0);
    // PUSH DI (19EF_23EF / 0x1C2DF)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x23F1);
    // PUSH SI (19EF_23F0 / 0x1C2E0)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x23F2);
    // PUSH DS (19EF_23F1 / 0x1C2E1)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x23F5);
    // MOV AX,0x1ddc (19EF_23F2 / 0x1C2E2)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x23F7);
    // MOV DS,AX (19EF_23F5 / 0x1C2E5)
    DS = AX;
    CheckExternalEvents(cs14, 0x23F8);
    // PUSH ES (19EF_23F7 / 0x1C2E7)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x23FB);
    // MOV AX,word ptr [BP + 0x6] (19EF_23F8 / 0x1C2E8)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x23FE);
    // MOV [0xb78a],AX (19EF_23FB / 0x1C2EB)
    UInt16[DS, 0xB78A] = AX;
    CheckExternalEvents(cs14, 0x2400);
    // MOV SI,AX (19EF_23FE / 0x1C2EE)
    SI = AX;
    CheckExternalEvents(cs14, 0x2403);
    // MOV AX,word ptr [BP + 0x8] (19EF_2400 / 0x1C2F0)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x2406);
    // MOV [0xb78c],AX (19EF_2403 / 0x1C2F3)
    UInt16[DS, 0xB78C] = AX;
    CheckExternalEvents(cs14, 0x2409);
    // MOV AX,word ptr [BP + 0xa] (19EF_2406 / 0x1C2F6)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x240B);
    // MOV DI,AX (19EF_2409 / 0x1C2F9)
    DI = AX;
    CheckExternalEvents(cs14, 0x240E);
    // MOV AX,word ptr [BP + 0xc] (19EF_240B / 0x1C2FB)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x2410);
    // MOV ES,AX (19EF_240E / 0x1C2FE)
    ES = AX;
    CheckExternalEvents(cs14, 0x2413);
    // MOV AX,[0xb78c] (19EF_2410 / 0x1C300)
    AX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs14, 0x2414);
    // PUSH DS (19EF_2413 / 0x1C303)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2416);
    // MOV DS,AX (19EF_2414 / 0x1C304)
    DS = AX;
    CheckExternalEvents(cs14, 0x2418);
    // JMP 0x1000:c312 (19EF_2416 / 0x1C306)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_C312_1C312, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_C309_1C309(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C309_1C309:
    CheckExternalEvents(cs8, 0xC30A);
    // INC SI (1000_C309 / 0x1C309)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC30C);
    // MOV AX,word ptr [SI] (1000_C30A / 0x1C30A)
    AX = UInt16[DS, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xC30E);
    // XCHG AL,AH (1000_C30C / 0x1C30C)
    (AH, AL) = (AL, AH);
    CheckExternalEvents(cs8, 0xC30F);
    // INC SI (1000_C30E / 0x1C30E)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC311);
    // JMP 0x1000:c323 (1000_C30F / 0x1C30F)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_C312_1C312, 0x1C323 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_C312_1C312(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1C323: goto label_1000_C323_1C323;break; // Target of external jump from 0x1C30F
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C312_1C312:
    CheckExternalEvents(cs8, 0xC315);
    // MOV DX,0xf20 (1000_C312 / 0x1C312)
    DX = 0xF20;
    label_1000_C315_1C315:
    CheckExternalEvents(cs8, 0xC317);
    // XOR BX,BX (1000_C315 / 0x1C315)
    BX = 0;
    CheckExternalEvents(cs8, 0xC319);
    // XOR AX,AX (1000_C317 / 0x1C317)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0xC31B);
    // MOV AL,byte ptr [SI] (1000_C319 / 0x1C319)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xC31D);
    // OR AL,AL (1000_C31B / 0x1C31B)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs8, 0xC31F);
    // JZ 0x1000:c309 (1000_C31D / 0x1C31D)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_C309_1C309, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC321);
    // JNS 0x1000:c324 (1000_C31F / 0x1C31F)
    if(!SignFlag) {
      goto label_1000_C324_1C324;
    }
    CheckExternalEvents(cs8, 0xC323);
    // NEG AL (1000_C321 / 0x1C321)
    AL = Alu8.Sub(0, AL);
    label_1000_C323_1C323:
    CheckExternalEvents(cs8, 0xC324);
    // DEC BX (1000_C323 / 0x1C323)
    BX = Alu16.Dec(BX);
    label_1000_C324_1C324:
    CheckExternalEvents(cs8, 0xC326);
    // MOV CX,AX (1000_C324 / 0x1C324)
    CX = AX;
    label_1000_C326_1C326:
    CheckExternalEvents(cs8, 0xC327);
    // INC SI (1000_C326 / 0x1C326)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC329);
    // MOV AL,byte ptr [SI] (1000_C327 / 0x1C327)
    AL = UInt8[DS, (ushort)(SI)];
    label_1000_C329_1C329:
    CheckExternalEvents(cs8, 0xC32C);
    // XOR byte ptr ES:[DI],AL (1000_C329 / 0x1C329)
    UInt8[ES, (ushort)(DI)] ^= AL;
    CheckExternalEvents(cs8, 0xC32D);
    // INC DI (1000_C32C / 0x1C32C)
    DI++;
    CheckExternalEvents(cs8, 0xC32E);
    // DEC DX (1000_C32D / 0x1C32D)
    DX = Alu16.Dec(DX);
    CheckExternalEvents(cs8, 0xC330);
    // JZ 0x1000:c33e (1000_C32E / 0x1C32E)
    if(ZeroFlag) {
      goto label_1000_C33E_1C33E;
    }
    CheckExternalEvents(cs8, 0xC332);
    // OR BX,BX (1000_C330 / 0x1C330)
    // BX |= BX;
    BX = Alu16.Or(BX, BX);
    CheckExternalEvents(cs8, 0xC334);
    // JNZ 0x1000:c339 (1000_C332 / 0x1C332)
    if(!ZeroFlag) {
      goto label_1000_C339_1C339;
    }
    CheckExternalEvents(cs8, 0xC336);
    // LOOP 0x1000:c326 (1000_C334 / 0x1C334)
    if(--CX != 0) {
      goto label_1000_C326_1C326;
    }
    CheckExternalEvents(cs8, 0xC337);
    // INC SI (1000_C336 / 0x1C336)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC339);
    // JMP 0x1000:c315 (1000_C337 / 0x1C337)
    goto label_1000_C315_1C315;
    label_1000_C339_1C339:
    CheckExternalEvents(cs8, 0xC33B);
    // LOOP 0x1000:c329 (1000_C339 / 0x1C339)
    if(--CX != 0) {
      goto label_1000_C329_1C329;
    }
    CheckExternalEvents(cs8, 0xC33C);
    // INC SI (1000_C33B / 0x1C33B)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC33E);
    // JMP 0x1000:c315 (1000_C33C / 0x1C33C)
    goto label_1000_C315_1C315;
    label_1000_C33E_1C33E:
    CheckExternalEvents(cs8, 0xC33F);
    // POP DS (1000_C33E / 0x1C33E)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC340);
    // POP ES (1000_C33F / 0x1C33F)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC342);
    // MOV AX,SI (1000_C340 / 0x1C340)
    AX = SI;
    CheckExternalEvents(cs8, 0xC343);
    // INC AX (1000_C342 / 0x1C342)
    AX++;
    CheckExternalEvents(cs8, 0xC347);
    // SUB AX,word ptr [0xb78a] (1000_C343 / 0x1C343)
    // AX -= UInt16[DS, 0xB78A];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB78A]);
    CheckExternalEvents(cs8, 0xC348);
    // POP DS (1000_C347 / 0x1C347)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC349);
    // POP SI (1000_C348 / 0x1C348)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC34A);
    // POP DI (1000_C349 / 0x1C349)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC34B);
    // POP BP (1000_C34A / 0x1C34A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC34C);
    // RETF  (1000_C34B / 0x1C34B)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_245C_1C34C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_245C_1C34C:
    CheckExternalEvents(cs14, 0x245D);
    // PUSH BP (19EF_245C / 0x1C34C)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x245F);
    // MOV BP,SP (19EF_245D / 0x1C34D)
    BP = SP;
    CheckExternalEvents(cs14, 0x2460);
    // PUSH DI (19EF_245F / 0x1C34F)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x2461);
    // PUSH SI (19EF_2460 / 0x1C350)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x2462);
    // PUSH DS (19EF_2461 / 0x1C351)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2465);
    // MOV AX,0x1ddc (19EF_2462 / 0x1C352)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x2467);
    // MOV DS,AX (19EF_2465 / 0x1C355)
    DS = AX;
    CheckExternalEvents(cs14, 0x2468);
    // PUSH ES (19EF_2467 / 0x1C357)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x246B);
    // MOV AX,word ptr [BP + 0x6] (19EF_2468 / 0x1C358)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x246E);
    // MOV [0xb78a],AX (19EF_246B / 0x1C35B)
    UInt16[DS, 0xB78A] = AX;
    CheckExternalEvents(cs14, 0x2471);
    // MOV AX,word ptr [BP + 0x8] (19EF_246E / 0x1C35E)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x2474);
    // MOV [0xb78c],AX (19EF_2471 / 0x1C361)
    UInt16[DS, 0xB78C] = AX;
    CheckExternalEvents(cs14, 0x2477);
    // MOV AX,word ptr [BP + 0xa] (19EF_2474 / 0x1C364)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x247A);
    // MOV [0xb78e],AX (19EF_2477 / 0x1C367)
    UInt16[DS, 0xB78E] = AX;
    CheckExternalEvents(cs14, 0x247D);
    // MOV AX,word ptr [BP + 0xc] (19EF_247A / 0x1C36A)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x2480);
    // MOV [0xb790],AX (19EF_247D / 0x1C36D)
    UInt16[DS, 0xB790] = AX;
    CheckExternalEvents(cs14, 0x2483);
    // MOV AX,word ptr [BP + 0xe] (19EF_2480 / 0x1C370)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs14, 0x2488);
    // CMP word ptr [0xb764],0x2 (19EF_2483 / 0x1C373)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x248A);
    // JZ 0x1000:c38e (19EF_2488 / 0x1C378)
    if(ZeroFlag) {
      goto label_19EF_249E_1C38E;
    }
    CheckExternalEvents(cs14, 0x248C);
    // SHL AX,0x1 (19EF_248A / 0x1C37A)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x2491);
    // CMP word ptr [0xb764],0x0 (19EF_248C / 0x1C37C)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x2493);
    // JZ 0x1000:c38e (19EF_2491 / 0x1C381)
    if(ZeroFlag) {
      goto label_19EF_249E_1C38E;
    }
    CheckExternalEvents(cs14, 0x2495);
    // SHL AX,0x1 (19EF_2493 / 0x1C383)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x249A);
    // CMP word ptr [0xb764],0x1 (19EF_2495 / 0x1C385)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs14, 0x249C);
    // JZ 0x1000:c38e (19EF_249A / 0x1C38A)
    if(ZeroFlag) {
      goto label_19EF_249E_1C38E;
    }
    CheckExternalEvents(cs14, 0x249E);
    // SHL AX,0x1 (19EF_249C / 0x1C38C)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    label_19EF_249E_1C38E:
    CheckExternalEvents(cs14, 0x24A1);
    // MOV [0xb792],AX (19EF_249E / 0x1C38E)
    UInt16[DS, 0xB792] = AX;
    CheckExternalEvents(cs14, 0x24A4);
    // MOV AX,word ptr [BP + 0x10] (19EF_24A1 / 0x1C391)
    AX = UInt16[SS, (ushort)(BP + 0x10)];
    CheckExternalEvents(cs14, 0x24A7);
    // MOV [0xb794],AX (19EF_24A4 / 0x1C394)
    UInt16[DS, 0xB794] = AX;
    CheckExternalEvents(cs14, 0x24AA);
    // MOV AX,word ptr [BP + 0x12] (19EF_24A7 / 0x1C397)
    AX = UInt16[SS, (ushort)(BP + 0x12)];
    CheckExternalEvents(cs14, 0x24AF);
    // CMP word ptr [0xb764],0x2 (19EF_24AA / 0x1C39A)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x24B1);
    // JZ 0x1000:c3b5 (19EF_24AF / 0x1C39F)
    if(ZeroFlag) {
      goto label_19EF_24C5_1C3B5;
    }
    CheckExternalEvents(cs14, 0x24B3);
    // SHL AX,0x1 (19EF_24B1 / 0x1C3A1)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x24B8);
    // CMP word ptr [0xb764],0x0 (19EF_24B3 / 0x1C3A3)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x24BA);
    // JZ 0x1000:c3b5 (19EF_24B8 / 0x1C3A8)
    if(ZeroFlag) {
      goto label_19EF_24C5_1C3B5;
    }
    CheckExternalEvents(cs14, 0x24BC);
    // SHL AX,0x1 (19EF_24BA / 0x1C3AA)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x24C1);
    // CMP word ptr [0xb764],0x1 (19EF_24BC / 0x1C3AC)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs14, 0x24C3);
    // JZ 0x1000:c3b5 (19EF_24C1 / 0x1C3B1)
    if(ZeroFlag) {
      goto label_19EF_24C5_1C3B5;
    }
    CheckExternalEvents(cs14, 0x24C5);
    // SHL AX,0x1 (19EF_24C3 / 0x1C3B3)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    label_19EF_24C5_1C3B5:
    CheckExternalEvents(cs14, 0x24C8);
    // MOV [0xb79a],AX (19EF_24C5 / 0x1C3B5)
    UInt16[DS, 0xB79A] = AX;
    CheckExternalEvents(cs14, 0x24CB);
    // MOV AX,word ptr [BP + 0x14] (19EF_24C8 / 0x1C3B8)
    AX = UInt16[SS, (ushort)(BP + 0x14)];
    CheckExternalEvents(cs14, 0x24CE);
    // MOV [0xb79c],AX (19EF_24CB / 0x1C3BB)
    UInt16[DS, 0xB79C] = AX;
    CheckExternalEvents(cs14, 0x24D1);
    // CALL 0x1000:c3c7 (19EF_24CE / 0x1C3BE)
    NearCall(cs14, 0x24D1, unknown_19EF_24D7_1C3C7);
    CheckExternalEvents(cs14, 0x24D2);
    // POP ES (19EF_24D1 / 0x1C3C1)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x24D3);
    // POP DS (19EF_24D2 / 0x1C3C2)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x24D4);
    // POP SI (19EF_24D3 / 0x1C3C3)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x24D5);
    // POP DI (19EF_24D4 / 0x1C3C4)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x24D6);
    // POP BP (19EF_24D5 / 0x1C3C5)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x24D7);
    // RETF  (19EF_24D6 / 0x1C3C6)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_24D7_1C3C7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_24D7_1C3C7:
    CheckExternalEvents(cs14, 0x24DC);
    // CMP word ptr [0xb764],0x0 (19EF_24D7 / 0x1C3C7)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x24DE);
    // JNZ 0x1000:c3d1 (19EF_24DC / 0x1C3CC)
    if(!ZeroFlag) {
      goto label_19EF_24E1_1C3D1;
    }
    CheckExternalEvents(cs14, 0x24E1);
    // JMP 0x1000:c59e (19EF_24DE / 0x1C3CE)
    goto label_19EF_26AE_1C59E;
    label_19EF_24E1_1C3D1:
    CheckExternalEvents(cs14, 0x24E6);
    // CMP word ptr [0xb764],0x2 (19EF_24E1 / 0x1C3D1)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x24E8);
    // JZ 0x1000:c3db (19EF_24E6 / 0x1C3D6)
    if(ZeroFlag) {
      goto label_19EF_24EB_1C3DB;
    }
    CheckExternalEvents(cs14, 0x24EB);
    // JMP 0x1000:c45b (19EF_24E8 / 0x1C3D8)
    goto label_19EF_256B_1C45B;
    label_19EF_24EB_1C3DB:
    CheckExternalEvents(cs14, 0x24EE);
    // MOV AX,[0xb79a] (19EF_24EB / 0x1C3DB)
    AX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x24F2);
    // ADD AX,word ptr [0xb792] (19EF_24EE / 0x1C3DE)
    AX += UInt16[DS, 0xB792];
    CheckExternalEvents(cs14, 0x24F5);
    // CMP AX,0x29 (19EF_24F2 / 0x1C3E2)
    Alu16.Sub(AX, 0x29);
    CheckExternalEvents(cs14, 0x24F7);
    // JC 0x1000:c3f1 (19EF_24F5 / 0x1C3E5)
    if(CarryFlag) {
      goto label_19EF_2501_1C3F1;
    }
    CheckExternalEvents(cs14, 0x24FA);
    // MOV AX,0x28 (19EF_24F7 / 0x1C3E7)
    AX = 0x28;
    CheckExternalEvents(cs14, 0x24FE);
    // SUB AX,word ptr [0xb792] (19EF_24FA / 0x1C3EA)
    // AX -= UInt16[DS, 0xB792];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs14, 0x2501);
    // MOV [0xb79a],AX (19EF_24FE / 0x1C3EE)
    UInt16[DS, 0xB79A] = AX;
    label_19EF_2501_1C3F1:
    CheckExternalEvents(cs14, 0x2504);
    // MOV AX,[0xb794] (19EF_2501 / 0x1C3F1)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x2508);
    // ADD AX,word ptr [0xb79c] (19EF_2504 / 0x1C3F4)
    AX += UInt16[DS, 0xB79C];
    CheckExternalEvents(cs14, 0x250B);
    // CMP AX,0xc9 (19EF_2508 / 0x1C3F8)
    Alu16.Sub(AX, 0xC9);
    CheckExternalEvents(cs14, 0x250D);
    // JC 0x1000:c407 (19EF_250B / 0x1C3FB)
    if(CarryFlag) {
      goto label_19EF_2517_1C407;
    }
    CheckExternalEvents(cs14, 0x2510);
    // MOV AX,0xc8 (19EF_250D / 0x1C3FD)
    AX = 0xC8;
    CheckExternalEvents(cs14, 0x2514);
    // SUB AX,word ptr [0xb794] (19EF_2510 / 0x1C400)
    // AX -= UInt16[DS, 0xB794];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB794]);
    CheckExternalEvents(cs14, 0x2517);
    // MOV [0xb79c],AX (19EF_2514 / 0x1C404)
    UInt16[DS, 0xB79C] = AX;
    label_19EF_2517_1C407:
    CheckExternalEvents(cs14, 0x251A);
    // MOV AX,[0xb792] (19EF_2517 / 0x1C407)
    AX = UInt16[DS, 0xB792];
    CheckExternalEvents(cs14, 0x251D);
    // CMP AX,0x28 (19EF_251A / 0x1C40A)
    Alu16.Sub(AX, 0x28);
    CheckExternalEvents(cs14, 0x251F);
    // JNC 0x1000:c458 (19EF_251D / 0x1C40D)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs14, 0x256B);
      // JMP 0x1000:c519 (19EF_2568 / 0x1C458)
      // JMP target is RET, inlining.
      CheckExternalEvents(cs14, 0x262A);
      // RET  (19EF_2629 / 0x1C519)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x2522);
    // MOV AX,[0xb794] (19EF_251F / 0x1C40F)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x2525);
    // CMP AX,0xc8 (19EF_2522 / 0x1C412)
    Alu16.Sub(AX, 0xC8);
    CheckExternalEvents(cs14, 0x2527);
    // JNC 0x1000:c458 (19EF_2525 / 0x1C415)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs14, 0x256B);
      // JMP 0x1000:c519 (19EF_2568 / 0x1C458)
      // JMP target is RET, inlining.
      CheckExternalEvents(cs14, 0x262A);
      // RET  (19EF_2629 / 0x1C519)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x252A);
    // MOV DX,0x28 (19EF_2527 / 0x1C417)
    DX = 0x28;
    CheckExternalEvents(cs14, 0x252C);
    // MUL DL (19EF_252A / 0x1C41A)
    ushort resMul19EF_252A = Alu8.Mul(AL, DL);
    AL = (byte)(resMul19EF_252A);
    AH = (byte)(resMul19EF_252A >> 8);
    CheckExternalEvents(cs14, 0x2530);
    // ADD AX,word ptr [0xb792] (19EF_252C / 0x1C41C)
    // AX += UInt16[DS, 0xB792];
    AX = Alu16.Add(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs14, 0x2534);
    // MOV DI,word ptr [0xb78e] (19EF_2530 / 0x1C420)
    DI = UInt16[DS, 0xB78E];
    CheckExternalEvents(cs14, 0x2536);
    // ADD DI,AX (19EF_2534 / 0x1C424)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs14, 0x253A);
    // MOV DX,word ptr [0xb790] (19EF_2536 / 0x1C426)
    DX = UInt16[DS, 0xB790];
    CheckExternalEvents(cs14, 0x253C);
    // MOV ES,DX (19EF_253A / 0x1C42A)
    ES = DX;
    CheckExternalEvents(cs14, 0x253E);
    // MOV SI,AX (19EF_253C / 0x1C42C)
    SI = AX;
    CheckExternalEvents(cs14, 0x2542);
    // ADD SI,word ptr [0xb78a] (19EF_253E / 0x1C42E)
    // SI += UInt16[DS, 0xB78A];
    SI = Alu16.Add(SI, UInt16[DS, 0xB78A]);
    CheckExternalEvents(cs14, 0x2545);
    // MOV DX,0x3ce (19EF_2542 / 0x1C432)
    DX = 0x3CE;
    CheckExternalEvents(cs14, 0x2548);
    // MOV AX,0x105 (19EF_2545 / 0x1C435)
    AX = 0x105;
    CheckExternalEvents(cs14, 0x2549);
    // OUT DX,AX (19EF_2548 / 0x1C438)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x254D);
    // MOV BX,word ptr [0xb79a] (19EF_2549 / 0x1C439)
    BX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x2551);
    // MOV DX,word ptr [0xb79c] (19EF_254D / 0x1C43D)
    DX = UInt16[DS, 0xB79C];
    CheckExternalEvents(cs14, 0x2554);
    // MOV AX,[0xb78c] (19EF_2551 / 0x1C441)
    AX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs14, 0x2555);
    // PUSH DS (19EF_2554 / 0x1C444)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2557);
    // MOV DS,AX (19EF_2555 / 0x1C445)
    DS = AX;
    label_19EF_2557_1C447:
    CheckExternalEvents(cs14, 0x2559);
    // MOV CX,BX (19EF_2557 / 0x1C447)
    CX = BX;
    CheckExternalEvents(cs14, 0x255B);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSB ES:DI,SI (19EF_2559 / 0x1C449)
      UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction8);
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs14, 0x255E);
    // MOV AX,0x28 (19EF_255B / 0x1C44B)
    AX = 0x28;
    CheckExternalEvents(cs14, 0x2560);
    // SUB AX,BX (19EF_255E / 0x1C44E)
    AX -= BX;
    CheckExternalEvents(cs14, 0x2562);
    // ADD SI,AX (19EF_2560 / 0x1C450)
    SI += AX;
    CheckExternalEvents(cs14, 0x2564);
    // ADD DI,AX (19EF_2562 / 0x1C452)
    DI += AX;
    CheckExternalEvents(cs14, 0x2565);
    // DEC DX (19EF_2564 / 0x1C454)
    DX = Alu16.Dec(DX);
    CheckExternalEvents(cs14, 0x2567);
    // JNZ 0x1000:c447 (19EF_2565 / 0x1C455)
    if(!ZeroFlag) {
      goto label_19EF_2557_1C447;
    }
    CheckExternalEvents(cs14, 0x2568);
    // POP DS (19EF_2567 / 0x1C457)
    DS = Stack.Pop16();;
    label_19EF_2568_1C458:
    CheckExternalEvents(cs14, 0x256B);
    // JMP 0x1000:c519 (19EF_2568 / 0x1C458)
    // JMP target is RET, inlining.
    CheckExternalEvents(cs14, 0x262A);
    // RET  (19EF_2629 / 0x1C519)
    return NearRet();
    label_19EF_256B_1C45B:
    CheckExternalEvents(cs14, 0x2570);
    // CMP word ptr [0xb764],0x1 (19EF_256B / 0x1C45B)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs14, 0x2572);
    // JZ 0x1000:c465 (19EF_2570 / 0x1C460)
    if(ZeroFlag) {
      goto label_19EF_2575_1C465;
    }
    CheckExternalEvents(cs14, 0x2575);
    // JMP 0x1000:c51a (19EF_2572 / 0x1C462)
    goto label_19EF_262A_1C51A;
    label_19EF_2575_1C465:
    CheckExternalEvents(cs14, 0x2578);
    // MOV AX,[0xb79a] (19EF_2575 / 0x1C465)
    AX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x257C);
    // ADD AX,word ptr [0xb792] (19EF_2578 / 0x1C468)
    AX += UInt16[DS, 0xB792];
    CheckExternalEvents(cs14, 0x257F);
    // CMP AX,0xa1 (19EF_257C / 0x1C46C)
    Alu16.Sub(AX, 0xA1);
    CheckExternalEvents(cs14, 0x2581);
    // JC 0x1000:c47b (19EF_257F / 0x1C46F)
    if(CarryFlag) {
      goto label_19EF_258B_1C47B;
    }
    CheckExternalEvents(cs14, 0x2584);
    // MOV AX,0xa0 (19EF_2581 / 0x1C471)
    AX = 0xA0;
    CheckExternalEvents(cs14, 0x2588);
    // SUB AX,word ptr [0xb792] (19EF_2584 / 0x1C474)
    // AX -= UInt16[DS, 0xB792];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs14, 0x258B);
    // MOV [0xb79a],AX (19EF_2588 / 0x1C478)
    UInt16[DS, 0xB79A] = AX;
    label_19EF_258B_1C47B:
    CheckExternalEvents(cs14, 0x258E);
    // MOV AX,[0xb794] (19EF_258B / 0x1C47B)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x2592);
    // ADD AX,word ptr [0xb79c] (19EF_258E / 0x1C47E)
    AX += UInt16[DS, 0xB79C];
    CheckExternalEvents(cs14, 0x2595);
    // CMP AX,0xc9 (19EF_2592 / 0x1C482)
    Alu16.Sub(AX, 0xC9);
    CheckExternalEvents(cs14, 0x2597);
    // JC 0x1000:c491 (19EF_2595 / 0x1C485)
    if(CarryFlag) {
      goto label_19EF_25A1_1C491;
    }
    CheckExternalEvents(cs14, 0x259A);
    // MOV AX,0xc8 (19EF_2597 / 0x1C487)
    AX = 0xC8;
    CheckExternalEvents(cs14, 0x259E);
    // SUB AX,word ptr [0xb794] (19EF_259A / 0x1C48A)
    // AX -= UInt16[DS, 0xB794];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB794]);
    CheckExternalEvents(cs14, 0x25A1);
    // MOV [0xb79c],AX (19EF_259E / 0x1C48E)
    UInt16[DS, 0xB79C] = AX;
    label_19EF_25A1_1C491:
    CheckExternalEvents(cs14, 0x25A4);
    // MOV AX,[0xb792] (19EF_25A1 / 0x1C491)
    AX = UInt16[DS, 0xB792];
    CheckExternalEvents(cs14, 0x25A7);
    // CMP AX,0xa0 (19EF_25A4 / 0x1C494)
    Alu16.Sub(AX, 0xA0);
    CheckExternalEvents(cs14, 0x25A9);
    // JNC 0x1000:c458 (19EF_25A7 / 0x1C497)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs14, 0x256B);
      // JMP 0x1000:c519 (19EF_2568 / 0x1C458)
      // JMP target is RET, inlining.
      CheckExternalEvents(cs14, 0x262A);
      // RET  (19EF_2629 / 0x1C519)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x25AC);
    // MOV AX,[0xb794] (19EF_25A9 / 0x1C499)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x25AF);
    // CMP AX,0xc8 (19EF_25AC / 0x1C49C)
    Alu16.Sub(AX, 0xC8);
    CheckExternalEvents(cs14, 0x25B1);
    // JNC 0x1000:c519 (19EF_25AF / 0x1C49F)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      CheckExternalEvents(cs14, 0x262A);
      // RET  (19EF_2629 / 0x1C519)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x25B3);
    // MOV BX,AX (19EF_25B1 / 0x1C4A1)
    BX = AX;
    CheckExternalEvents(cs14, 0x25B6);
    // AND AX,0xfc (19EF_25B3 / 0x1C4A3)
    // AX &= 0xFC;
    AX = Alu16.And(AX, 0xFC);
    CheckExternalEvents(cs14, 0x25B9);
    // MOV DX,0x28 (19EF_25B6 / 0x1C4A6)
    DX = 0x28;
    CheckExternalEvents(cs14, 0x25BB);
    // MUL DL (19EF_25B9 / 0x1C4A9)
    ushort resMul19EF_25B9 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul19EF_25B9);
    AH = (byte)(resMul19EF_25B9 >> 8);
    CheckExternalEvents(cs14, 0x25BF);
    // ADD AX,word ptr [0xb792] (19EF_25BB / 0x1C4AB)
    AX += UInt16[DS, 0xB792];
    CheckExternalEvents(cs14, 0x25C2);
    // AND BX,0x3 (19EF_25BF / 0x1C4AF)
    // BX &= 0x3;
    BX = Alu16.And(BX, 0x3);
    CheckExternalEvents(cs14, 0x25C4);
    // JZ 0x1000:c4bd (19EF_25C2 / 0x1C4B2)
    if(ZeroFlag) {
      goto label_19EF_25CD_1C4BD;
    }
    CheckExternalEvents(cs14, 0x25C6);
    // MOV CX,BX (19EF_25C4 / 0x1C4B4)
    CX = BX;
    CheckExternalEvents(cs14, 0x25C9);
    // MOV AX,0x2000 (19EF_25C6 / 0x1C4B6)
    AX = 0x2000;
    CheckExternalEvents(cs14, 0x25CB);
    // MUL BX (19EF_25C9 / 0x1C4B9)
    uint resMul19EF_25C9 = Alu16.Mul(AX, BX);
    AX = (ushort)(resMul19EF_25C9);
    DX = (ushort)(resMul19EF_25C9 >> 16);
    CheckExternalEvents(cs14, 0x25CD);
    // ADD AX,CX (19EF_25CB / 0x1C4BB)
    // AX += CX;
    AX = Alu16.Add(AX, CX);
    label_19EF_25CD_1C4BD:
    CheckExternalEvents(cs14, 0x25D1);
    // MOV DI,word ptr [0xb78e] (19EF_25CD / 0x1C4BD)
    DI = UInt16[DS, 0xB78E];
    CheckExternalEvents(cs14, 0x25D3);
    // ADD DI,AX (19EF_25D1 / 0x1C4C1)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs14, 0x25D7);
    // MOV DX,word ptr [0xb790] (19EF_25D3 / 0x1C4C3)
    DX = UInt16[DS, 0xB790];
    CheckExternalEvents(cs14, 0x25D9);
    // MOV ES,DX (19EF_25D7 / 0x1C4C7)
    ES = DX;
    CheckExternalEvents(cs14, 0x25DB);
    // MOV SI,AX (19EF_25D9 / 0x1C4C9)
    SI = AX;
    CheckExternalEvents(cs14, 0x25DF);
    // ADD SI,word ptr [0xb78a] (19EF_25DB / 0x1C4CB)
    // SI += UInt16[DS, 0xB78A];
    SI = Alu16.Add(SI, UInt16[DS, 0xB78A]);
    CheckExternalEvents(cs14, 0x25E3);
    // MOV DX,word ptr [0xb79a] (19EF_25DF / 0x1C4CF)
    DX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x25E6);
    // MOV AX,0x2000 (19EF_25E3 / 0x1C4D3)
    AX = 0x2000;
    CheckExternalEvents(cs14, 0x25E8);
    // SUB AX,DX (19EF_25E6 / 0x1C4D6)
    // AX -= DX;
    AX = Alu16.Sub(AX, DX);
    CheckExternalEvents(cs14, 0x25EB);
    // MOV [0xb794],AX (19EF_25E8 / 0x1C4D8)
    UInt16[DS, 0xB794] = AX;
    CheckExternalEvents(cs14, 0x25ED);
    // MOV AX,DX (19EF_25EB / 0x1C4DB)
    AX = DX;
    CheckExternalEvents(cs14, 0x25F0);
    // SUB AX,0xa0 (19EF_25ED / 0x1C4DD)
    AX -= 0xA0;
    CheckExternalEvents(cs14, 0x25F3);
    // ADD AH,0x60 (19EF_25F0 / 0x1C4E0)
    AH += 0x60;
    CheckExternalEvents(cs14, 0x25F5);
    // SHR DX,0x1 (19EF_25F3 / 0x1C4E3)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs14, 0x25F9);
    // MOV word ptr [0xb79a],DX (19EF_25F5 / 0x1C4E5)
    UInt16[DS, 0xB79A] = DX;
    CheckExternalEvents(cs14, 0x25FD);
    // MOV DX,word ptr [0xb78c] (19EF_25F9 / 0x1C4E9)
    DX = UInt16[DS, 0xB78C];
    label_19EF_25FD_1C4ED:
    CheckExternalEvents(cs14, 0x2601);
    // MOV CX,word ptr [0xb79a] (19EF_25FD / 0x1C4ED)
    CX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x2602);
    // PUSH DS (19EF_2601 / 0x1C4F1)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2604);
    // MOV DS,DX (19EF_2602 / 0x1C4F2)
    DS = DX;
    CheckExternalEvents(cs14, 0x2606);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_2604 / 0x1C4F4)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x2607);
    // POP DS (19EF_2606 / 0x1C4F6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2608);
    // INC BX (19EF_2607 / 0x1C4F7)
    BX++;
    CheckExternalEvents(cs14, 0x260B);
    // AND BX,0x3 (19EF_2608 / 0x1C4F8)
    // BX &= 0x3;
    BX = Alu16.And(BX, 0x3);
    CheckExternalEvents(cs14, 0x260D);
    // JZ 0x1000:c50e (19EF_260B / 0x1C4FB)
    if(ZeroFlag) {
      goto label_19EF_261E_1C50E;
    }
    CheckExternalEvents(cs14, 0x2611);
    // ADD SI,word ptr [0xb794] (19EF_260D / 0x1C4FD)
    SI += UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x2615);
    // ADD DI,word ptr [0xb794] (19EF_2611 / 0x1C501)
    DI += UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x261A);
    // SUB word ptr [0xb79c],0x1 (19EF_2615 / 0x1C505)
    // UInt16[DS, 0xB79C] -= 0x1;
    UInt16[DS, 0xB79C] = Alu16.Sub(UInt16[DS, 0xB79C], 0x1);
    CheckExternalEvents(cs14, 0x261C);
    // JNZ 0x1000:c4ed (19EF_261A / 0x1C50A)
    if(!ZeroFlag) {
      goto label_19EF_25FD_1C4ED;
    }
    CheckExternalEvents(cs14, 0x261E);
    // JZ 0x1000:c519 (19EF_261C / 0x1C50C)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      CheckExternalEvents(cs14, 0x262A);
      // RET  (19EF_2629 / 0x1C519)
      return NearRet();
    }
    label_19EF_261E_1C50E:
    CheckExternalEvents(cs14, 0x2620);
    // SUB SI,AX (19EF_261E / 0x1C50E)
    SI -= AX;
    CheckExternalEvents(cs14, 0x2622);
    // SUB DI,AX (19EF_2620 / 0x1C510)
    DI -= AX;
    CheckExternalEvents(cs14, 0x2627);
    // SUB word ptr [0xb79c],0x1 (19EF_2622 / 0x1C512)
    // UInt16[DS, 0xB79C] -= 0x1;
    UInt16[DS, 0xB79C] = Alu16.Sub(UInt16[DS, 0xB79C], 0x1);
    CheckExternalEvents(cs14, 0x2629);
    // JNZ 0x1000:c4ed (19EF_2627 / 0x1C517)
    if(!ZeroFlag) {
      goto label_19EF_25FD_1C4ED;
    }
    label_19EF_2629_1C519:
    CheckExternalEvents(cs14, 0x262A);
    // RET  (19EF_2629 / 0x1C519)
    return NearRet();
    label_19EF_262A_1C51A:
    CheckExternalEvents(cs14, 0x262D);
    // MOV AX,[0xb79a] (19EF_262A / 0x1C51A)
    AX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x2631);
    // ADD AX,word ptr [0xb792] (19EF_262D / 0x1C51D)
    AX += UInt16[DS, 0xB792];
    CheckExternalEvents(cs14, 0x2634);
    // CMP AX,0x141 (19EF_2631 / 0x1C521)
    Alu16.Sub(AX, 0x141);
    CheckExternalEvents(cs14, 0x2636);
    // JC 0x1000:c530 (19EF_2634 / 0x1C524)
    if(CarryFlag) {
      goto label_19EF_2640_1C530;
    }
    CheckExternalEvents(cs14, 0x2639);
    // MOV AX,0x140 (19EF_2636 / 0x1C526)
    AX = 0x140;
    CheckExternalEvents(cs14, 0x263D);
    // SUB AX,word ptr [0xb792] (19EF_2639 / 0x1C529)
    // AX -= UInt16[DS, 0xB792];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs14, 0x2640);
    // MOV [0xb79a],AX (19EF_263D / 0x1C52D)
    UInt16[DS, 0xB79A] = AX;
    label_19EF_2640_1C530:
    CheckExternalEvents(cs14, 0x2643);
    // MOV AX,[0xb794] (19EF_2640 / 0x1C530)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x2647);
    // ADD AX,word ptr [0xb79c] (19EF_2643 / 0x1C533)
    AX += UInt16[DS, 0xB79C];
    CheckExternalEvents(cs14, 0x264A);
    // CMP AX,0xc9 (19EF_2647 / 0x1C537)
    Alu16.Sub(AX, 0xC9);
    CheckExternalEvents(cs14, 0x264C);
    // JC 0x1000:c546 (19EF_264A / 0x1C53A)
    if(CarryFlag) {
      goto label_19EF_2656_1C546;
    }
    CheckExternalEvents(cs14, 0x264F);
    // MOV AX,0xc8 (19EF_264C / 0x1C53C)
    AX = 0xC8;
    CheckExternalEvents(cs14, 0x2653);
    // SUB AX,word ptr [0xb794] (19EF_264F / 0x1C53F)
    // AX -= UInt16[DS, 0xB794];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB794]);
    CheckExternalEvents(cs14, 0x2656);
    // MOV [0xb79c],AX (19EF_2653 / 0x1C543)
    UInt16[DS, 0xB79C] = AX;
    label_19EF_2656_1C546:
    CheckExternalEvents(cs14, 0x2659);
    // MOV AX,[0xb792] (19EF_2656 / 0x1C546)
    AX = UInt16[DS, 0xB792];
    CheckExternalEvents(cs14, 0x265C);
    // CMP AX,0x140 (19EF_2659 / 0x1C549)
    Alu16.Sub(AX, 0x140);
    CheckExternalEvents(cs14, 0x265E);
    // JNC 0x1000:c519 (19EF_265C / 0x1C54C)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      CheckExternalEvents(cs14, 0x262A);
      // RET  (19EF_2629 / 0x1C519)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x2661);
    // MOV AX,[0xb794] (19EF_265E / 0x1C54E)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x2664);
    // CMP AX,0xc8 (19EF_2661 / 0x1C551)
    Alu16.Sub(AX, 0xC8);
    CheckExternalEvents(cs14, 0x2666);
    // JNC 0x1000:c519 (19EF_2664 / 0x1C554)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      CheckExternalEvents(cs14, 0x262A);
      // RET  (19EF_2629 / 0x1C519)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x2668);
    // MOV BX,AX (19EF_2666 / 0x1C556)
    BX = AX;
    CheckExternalEvents(cs14, 0x266B);
    // MOV DX,0x140 (19EF_2668 / 0x1C558)
    DX = 0x140;
    CheckExternalEvents(cs14, 0x266D);
    // MUL DX (19EF_266B / 0x1C55B)
    uint resMul19EF_266B = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul19EF_266B);
    DX = (ushort)(resMul19EF_266B >> 16);
    CheckExternalEvents(cs14, 0x2671);
    // ADD AX,word ptr [0xb792] (19EF_266D / 0x1C55D)
    // AX += UInt16[DS, 0xB792];
    AX = Alu16.Add(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs14, 0x2675);
    // MOV DI,word ptr [0xb78e] (19EF_2671 / 0x1C561)
    DI = UInt16[DS, 0xB78E];
    CheckExternalEvents(cs14, 0x2677);
    // ADD DI,AX (19EF_2675 / 0x1C565)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs14, 0x267B);
    // MOV DX,word ptr [0xb790] (19EF_2677 / 0x1C567)
    DX = UInt16[DS, 0xB790];
    CheckExternalEvents(cs14, 0x267D);
    // MOV ES,DX (19EF_267B / 0x1C56B)
    ES = DX;
    CheckExternalEvents(cs14, 0x267F);
    // MOV SI,AX (19EF_267D / 0x1C56D)
    SI = AX;
    CheckExternalEvents(cs14, 0x2683);
    // ADD SI,word ptr [0xb78a] (19EF_267F / 0x1C56F)
    // SI += UInt16[DS, 0xB78A];
    SI = Alu16.Add(SI, UInt16[DS, 0xB78A]);
    CheckExternalEvents(cs14, 0x2686);
    // MOV BX,0x140 (19EF_2683 / 0x1C573)
    BX = 0x140;
    CheckExternalEvents(cs14, 0x268A);
    // MOV DX,word ptr [0xb79a] (19EF_2686 / 0x1C576)
    DX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x268C);
    // SUB BX,DX (19EF_268A / 0x1C57A)
    BX -= DX;
    CheckExternalEvents(cs14, 0x268E);
    // SHR DX,0x1 (19EF_268C / 0x1C57C)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs14, 0x2692);
    // MOV word ptr [0xb79a],DX (19EF_268E / 0x1C57E)
    UInt16[DS, 0xB79A] = DX;
    CheckExternalEvents(cs14, 0x2696);
    // MOV DX,word ptr [0xb78c] (19EF_2692 / 0x1C582)
    DX = UInt16[DS, 0xB78C];
    label_19EF_2696_1C586:
    CheckExternalEvents(cs14, 0x269A);
    // MOV CX,word ptr [0xb79a] (19EF_2696 / 0x1C586)
    CX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x269B);
    // PUSH DS (19EF_269A / 0x1C58A)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x269D);
    // MOV DS,DX (19EF_269B / 0x1C58B)
    DS = DX;
    CheckExternalEvents(cs14, 0x269F);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_269D / 0x1C58D)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x26A0);
    // POP DS (19EF_269F / 0x1C58F)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x26A2);
    // ADD SI,BX (19EF_26A0 / 0x1C590)
    SI += BX;
    CheckExternalEvents(cs14, 0x26A4);
    // ADD DI,BX (19EF_26A2 / 0x1C592)
    DI += BX;
    CheckExternalEvents(cs14, 0x26A9);
    // SUB word ptr [0xb79c],0x1 (19EF_26A4 / 0x1C594)
    // UInt16[DS, 0xB79C] -= 0x1;
    UInt16[DS, 0xB79C] = Alu16.Sub(UInt16[DS, 0xB79C], 0x1);
    CheckExternalEvents(cs14, 0x26AB);
    // JNZ 0x1000:c586 (19EF_26A9 / 0x1C599)
    if(!ZeroFlag) {
      goto label_19EF_2696_1C586;
    }
    CheckExternalEvents(cs14, 0x26AE);
    // JMP 0x1000:c519 (19EF_26AB / 0x1C59B)
    // JMP target is RET, inlining.
    CheckExternalEvents(cs14, 0x262A);
    // RET  (19EF_2629 / 0x1C519)
    return NearRet();
    label_19EF_26AE_1C59E:
    CheckExternalEvents(cs14, 0x26B1);
    // MOV AX,[0xb79a] (19EF_26AE / 0x1C59E)
    AX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x26B5);
    // ADD AX,word ptr [0xb792] (19EF_26B1 / 0x1C5A1)
    AX += UInt16[DS, 0xB792];
    CheckExternalEvents(cs14, 0x26B8);
    // CMP AX,0x51 (19EF_26B5 / 0x1C5A5)
    Alu16.Sub(AX, 0x51);
    CheckExternalEvents(cs14, 0x26BA);
    // JC 0x1000:c5b4 (19EF_26B8 / 0x1C5A8)
    if(CarryFlag) {
      goto label_19EF_26C4_1C5B4;
    }
    CheckExternalEvents(cs14, 0x26BD);
    // MOV AX,0x50 (19EF_26BA / 0x1C5AA)
    AX = 0x50;
    CheckExternalEvents(cs14, 0x26C1);
    // SUB AX,word ptr [0xb792] (19EF_26BD / 0x1C5AD)
    // AX -= UInt16[DS, 0xB792];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs14, 0x26C4);
    // MOV [0xb79a],AX (19EF_26C1 / 0x1C5B1)
    UInt16[DS, 0xB79A] = AX;
    label_19EF_26C4_1C5B4:
    CheckExternalEvents(cs14, 0x26C7);
    // MOV AX,[0xb794] (19EF_26C4 / 0x1C5B4)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x26CB);
    // ADD AX,word ptr [0xb79c] (19EF_26C7 / 0x1C5B7)
    AX += UInt16[DS, 0xB79C];
    CheckExternalEvents(cs14, 0x26CE);
    // CMP AX,0xc9 (19EF_26CB / 0x1C5BB)
    Alu16.Sub(AX, 0xC9);
    CheckExternalEvents(cs14, 0x26D0);
    // JC 0x1000:c5ca (19EF_26CE / 0x1C5BE)
    if(CarryFlag) {
      goto label_19EF_26DA_1C5CA;
    }
    CheckExternalEvents(cs14, 0x26D3);
    // MOV AX,0xc8 (19EF_26D0 / 0x1C5C0)
    AX = 0xC8;
    CheckExternalEvents(cs14, 0x26D7);
    // SUB AX,word ptr [0xb794] (19EF_26D3 / 0x1C5C3)
    // AX -= UInt16[DS, 0xB794];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB794]);
    CheckExternalEvents(cs14, 0x26DA);
    // MOV [0xb79c],AX (19EF_26D7 / 0x1C5C7)
    UInt16[DS, 0xB79C] = AX;
    label_19EF_26DA_1C5CA:
    CheckExternalEvents(cs14, 0x26DD);
    // MOV AX,[0xb792] (19EF_26DA / 0x1C5CA)
    AX = UInt16[DS, 0xB792];
    CheckExternalEvents(cs14, 0x26E0);
    // CMP AX,0x50 (19EF_26DD / 0x1C5CD)
    Alu16.Sub(AX, 0x50);
    CheckExternalEvents(cs14, 0x26E2);
    // JNC 0x1000:c64b (19EF_26E0 / 0x1C5D0)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      CheckExternalEvents(cs14, 0x275C);
      // RET  (19EF_275B / 0x1C64B)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x26E5);
    // MOV AX,[0xb794] (19EF_26E2 / 0x1C5D2)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x26E8);
    // CMP AX,0xc8 (19EF_26E5 / 0x1C5D5)
    Alu16.Sub(AX, 0xC8);
    CheckExternalEvents(cs14, 0x26EA);
    // JNC 0x1000:c64b (19EF_26E8 / 0x1C5D8)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      CheckExternalEvents(cs14, 0x275C);
      // RET  (19EF_275B / 0x1C64B)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x26EC);
    // MOV BX,AX (19EF_26EA / 0x1C5DA)
    BX = AX;
    CheckExternalEvents(cs14, 0x26EF);
    // AND AX,0xfe (19EF_26EC / 0x1C5DC)
    // AX &= 0xFE;
    AX = Alu16.And(AX, 0xFE);
    CheckExternalEvents(cs14, 0x26F2);
    // MOV DX,0x28 (19EF_26EF / 0x1C5DF)
    DX = 0x28;
    CheckExternalEvents(cs14, 0x26F4);
    // MUL DL (19EF_26F2 / 0x1C5E2)
    ushort resMul19EF_26F2 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul19EF_26F2);
    AH = (byte)(resMul19EF_26F2 >> 8);
    CheckExternalEvents(cs14, 0x26F8);
    // ADD AX,word ptr [0xb792] (19EF_26F4 / 0x1C5E4)
    AX += UInt16[DS, 0xB792];
    CheckExternalEvents(cs14, 0x26FB);
    // AND BX,0x1 (19EF_26F8 / 0x1C5E8)
    // BX &= 0x1;
    BX = Alu16.And(BX, 0x1);
    CheckExternalEvents(cs14, 0x26FD);
    // JZ 0x1000:c5f0 (19EF_26FB / 0x1C5EB)
    if(ZeroFlag) {
      goto label_19EF_2700_1C5F0;
    }
    CheckExternalEvents(cs14, 0x2700);
    // ADD AH,0x20 (19EF_26FD / 0x1C5ED)
    // AH += 0x20;
    AH = Alu8.Add(AH, 0x20);
    label_19EF_2700_1C5F0:
    CheckExternalEvents(cs14, 0x2704);
    // MOV DI,word ptr [0xb78e] (19EF_2700 / 0x1C5F0)
    DI = UInt16[DS, 0xB78E];
    CheckExternalEvents(cs14, 0x2706);
    // ADD DI,AX (19EF_2704 / 0x1C5F4)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs14, 0x270A);
    // MOV DX,word ptr [0xb790] (19EF_2706 / 0x1C5F6)
    DX = UInt16[DS, 0xB790];
    CheckExternalEvents(cs14, 0x270C);
    // MOV ES,DX (19EF_270A / 0x1C5FA)
    ES = DX;
    CheckExternalEvents(cs14, 0x270E);
    // MOV SI,AX (19EF_270C / 0x1C5FC)
    SI = AX;
    CheckExternalEvents(cs14, 0x2712);
    // ADD SI,word ptr [0xb78a] (19EF_270E / 0x1C5FE)
    // SI += UInt16[DS, 0xB78A];
    SI = Alu16.Add(SI, UInt16[DS, 0xB78A]);
    CheckExternalEvents(cs14, 0x2716);
    // MOV DX,word ptr [0xb79a] (19EF_2712 / 0x1C602)
    DX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x2719);
    // MOV AX,0x2000 (19EF_2716 / 0x1C606)
    AX = 0x2000;
    CheckExternalEvents(cs14, 0x271B);
    // SUB AX,DX (19EF_2719 / 0x1C609)
    // AX -= DX;
    AX = Alu16.Sub(AX, DX);
    CheckExternalEvents(cs14, 0x271E);
    // MOV [0xb794],AX (19EF_271B / 0x1C60B)
    UInt16[DS, 0xB794] = AX;
    CheckExternalEvents(cs14, 0x2720);
    // MOV AX,DX (19EF_271E / 0x1C60E)
    AX = DX;
    CheckExternalEvents(cs14, 0x2723);
    // SUB AX,0x50 (19EF_2720 / 0x1C610)
    AX -= 0x50;
    CheckExternalEvents(cs14, 0x2726);
    // ADD AH,0x20 (19EF_2723 / 0x1C613)
    AH += 0x20;
    CheckExternalEvents(cs14, 0x2728);
    // SHR DX,0x1 (19EF_2726 / 0x1C616)
    // DX >>= 0x1;
    DX = Alu16.Shr(DX, 0x1);
    CheckExternalEvents(cs14, 0x272C);
    // MOV word ptr [0xb79a],DX (19EF_2728 / 0x1C618)
    UInt16[DS, 0xB79A] = DX;
    CheckExternalEvents(cs14, 0x2730);
    // MOV DX,word ptr [0xb78c] (19EF_272C / 0x1C61C)
    DX = UInt16[DS, 0xB78C];
    label_19EF_2730_1C620:
    CheckExternalEvents(cs14, 0x2734);
    // MOV CX,word ptr [0xb79a] (19EF_2730 / 0x1C620)
    CX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x2735);
    // PUSH DS (19EF_2734 / 0x1C624)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2737);
    // MOV DS,DX (19EF_2735 / 0x1C625)
    DS = DX;
    CheckExternalEvents(cs14, 0x2739);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_2737 / 0x1C627)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x273A);
    // POP DS (19EF_2739 / 0x1C629)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x273D);
    // XOR BX,0x1 (19EF_273A / 0x1C62A)
    // BX ^= 0x1;
    BX = Alu16.Xor(BX, 0x1);
    CheckExternalEvents(cs14, 0x273F);
    // JZ 0x1000:c640 (19EF_273D / 0x1C62D)
    if(ZeroFlag) {
      goto label_19EF_2750_1C640;
    }
    CheckExternalEvents(cs14, 0x2743);
    // ADD SI,word ptr [0xb794] (19EF_273F / 0x1C62F)
    SI += UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x2747);
    // ADD DI,word ptr [0xb794] (19EF_2743 / 0x1C633)
    DI += UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x274C);
    // SUB word ptr [0xb79c],0x1 (19EF_2747 / 0x1C637)
    // UInt16[DS, 0xB79C] -= 0x1;
    UInt16[DS, 0xB79C] = Alu16.Sub(UInt16[DS, 0xB79C], 0x1);
    CheckExternalEvents(cs14, 0x274E);
    // JNZ 0x1000:c620 (19EF_274C / 0x1C63C)
    if(!ZeroFlag) {
      goto label_19EF_2730_1C620;
    }
    CheckExternalEvents(cs14, 0x2750);
    // JZ 0x1000:c64b (19EF_274E / 0x1C63E)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      CheckExternalEvents(cs14, 0x275C);
      // RET  (19EF_275B / 0x1C64B)
      return NearRet();
    }
    label_19EF_2750_1C640:
    CheckExternalEvents(cs14, 0x2752);
    // SUB SI,AX (19EF_2750 / 0x1C640)
    SI -= AX;
    CheckExternalEvents(cs14, 0x2754);
    // SUB DI,AX (19EF_2752 / 0x1C642)
    DI -= AX;
    CheckExternalEvents(cs14, 0x2759);
    // SUB word ptr [0xb79c],0x1 (19EF_2754 / 0x1C644)
    // UInt16[DS, 0xB79C] -= 0x1;
    UInt16[DS, 0xB79C] = Alu16.Sub(UInt16[DS, 0xB79C], 0x1);
    CheckExternalEvents(cs14, 0x275B);
    // JNZ 0x1000:c620 (19EF_2759 / 0x1C649)
    if(!ZeroFlag) {
      goto label_19EF_2730_1C620;
    }
    label_19EF_275B_1C64B:
    CheckExternalEvents(cs14, 0x275C);
    // RET  (19EF_275B / 0x1C64B)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_275C_1C64C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_275C_1C64C:
    CheckExternalEvents(cs14, 0x275D);
    // PUSH BP (19EF_275C / 0x1C64C)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x275F);
    // MOV BP,SP (19EF_275D / 0x1C64D)
    BP = SP;
    CheckExternalEvents(cs14, 0x2760);
    // PUSH DI (19EF_275F / 0x1C64F)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x2761);
    // PUSH SI (19EF_2760 / 0x1C650)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x2762);
    // PUSH DS (19EF_2761 / 0x1C651)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2765);
    // MOV AX,0x1ddc (19EF_2762 / 0x1C652)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x2767);
    // MOV DS,AX (19EF_2765 / 0x1C655)
    DS = AX;
    CheckExternalEvents(cs14, 0x2768);
    // PUSH ES (19EF_2767 / 0x1C657)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x276B);
    // MOV AX,0xb800 (19EF_2768 / 0x1C658)
    AX = 0xB800;
    CheckExternalEvents(cs14, 0x276D);
    // MOV ES,AX (19EF_276B / 0x1C65B)
    ES = AX;
    CheckExternalEvents(cs14, 0x2770);
    // MOV SI,word ptr [BP + 0x6] (19EF_276D / 0x1C65D)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x2773);
    // MOV AX,word ptr [BP + 0x8] (19EF_2770 / 0x1C660)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x2776);
    // MOV [0xb78c],AX (19EF_2773 / 0x1C663)
    UInt16[DS, 0xB78C] = AX;
    CheckExternalEvents(cs14, 0x277B);
    // CMP word ptr [0xb764],0x0 (19EF_2776 / 0x1C666)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x277D);
    // JNZ 0x1000:c670 (19EF_277B / 0x1C66B)
    if(!ZeroFlag) {
      goto label_19EF_2780_1C670;
    }
    CheckExternalEvents(cs14, 0x2780);
    // JMP 0x1000:c710 (19EF_277D / 0x1C66D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_C710_1C710, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_2780_1C670:
    CheckExternalEvents(cs14, 0x2785);
    // CMP word ptr [0xb764],0x2 (19EF_2780 / 0x1C670)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x2787);
    // JNZ 0x1000:c67a (19EF_2785 / 0x1C675)
    if(!ZeroFlag) {
      goto label_19EF_278A_1C67A;
    }
    CheckExternalEvents(cs14, 0x278A);
    // JMP 0x1000:c73d (19EF_2787 / 0x1C677)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_C73D_1C73D, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_278A_1C67A:
    CheckExternalEvents(cs14, 0x278F);
    // CMP word ptr [0xb764],0x3 (19EF_278A / 0x1C67A)
    Alu16.Sub(UInt16[DS, 0xB764], 0x3);
    CheckExternalEvents(cs14, 0x2791);
    // JNZ 0x1000:c6ce (19EF_278F / 0x1C67F)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_C6CE_1C6CE, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x2794);
    // MOV AX,0xa000 (19EF_2791 / 0x1C681)
    AX = 0xA000;
    CheckExternalEvents(cs14, 0x2796);
    // MOV ES,AX (19EF_2794 / 0x1C684)
    ES = AX;
    CheckExternalEvents(cs14, 0x2799);
    // MOV AX,word ptr [BP + 0xa] (19EF_2796 / 0x1C686)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x279B);
    // SHL AX,0x1 (19EF_2799 / 0x1C689)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x279D);
    // SHL AX,0x1 (19EF_279B / 0x1C68B)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x279F);
    // SHL AX,0x1 (19EF_279D / 0x1C68D)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs14, 0x27A2);
    // MOV [0xb792],AX (19EF_279F / 0x1C68F)
    UInt16[DS, 0xB792] = AX;
    CheckExternalEvents(cs14, 0x27A5);
    // MOV AX,word ptr [BP + 0xc] (19EF_27A2 / 0x1C692)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x27A8);
    // MOV DX,0xa00 (19EF_27A5 / 0x1C695)
    DX = 0xA00;
    CheckExternalEvents(cs14, 0x27AA);
    // MUL DX (19EF_27A8 / 0x1C698)
    uint resMul19EF_27A8 = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul19EF_27A8);
    DX = (ushort)(resMul19EF_27A8 >> 16);
    CheckExternalEvents(cs14, 0x27AE);
    // ADD AX,word ptr [0xb792] (19EF_27AA / 0x1C69A)
    // AX += UInt16[DS, 0xB792];
    AX = Alu16.Add(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs14, 0x27B0);
    // MOV DI,AX (19EF_27AE / 0x1C69E)
    DI = AX;
    CheckExternalEvents(cs14, 0x27B3);
    // MOV CX,0x8 (19EF_27B0 / 0x1C6A0)
    CX = 0x8;
    CheckExternalEvents(cs14, 0x27B4);
    // PUSH DS (19EF_27B3 / 0x1C6A3)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x27B8);
    // MOV DS,word ptr [0xb78c] (19EF_27B4 / 0x1C6A4)
    DS = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs14, 0x27B9);
    // CLD  (19EF_27B8 / 0x1C6A8)
    DirectionFlag = false;
    CheckExternalEvents(cs14, 0x27BC);
    // MOV DX,0xff0 (19EF_27B9 / 0x1C6A9)
    DX = 0xFF0;
    CheckExternalEvents(cs14, 0x27BF);
    // MOV BX,0x138 (19EF_27BC / 0x1C6AC)
    BX = 0x138;
    label_19EF_27BF_1C6AF:
    CheckExternalEvents(cs14, 0x27C0);
    // LODSB SI (19EF_27BF / 0x1C6AF)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x27C2);
    // MOV AH,AL (19EF_27C0 / 0x1C6B0)
    AH = AL;
    CheckExternalEvents(cs14, 0x27C4);
    // AND AX,DX (19EF_27C2 / 0x1C6B2)
    // AX &= DX;
    AX = Alu16.And(AX, DX);
    CheckExternalEvents(cs14, 0x27C5);
    // STOSW ES:DI (19EF_27C4 / 0x1C6B4)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x27C6);
    // LODSB SI (19EF_27C5 / 0x1C6B5)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x27C8);
    // MOV AH,AL (19EF_27C6 / 0x1C6B6)
    AH = AL;
    CheckExternalEvents(cs14, 0x27CA);
    // AND AX,DX (19EF_27C8 / 0x1C6B8)
    // AX &= DX;
    AX = Alu16.And(AX, DX);
    CheckExternalEvents(cs14, 0x27CB);
    // STOSW ES:DI (19EF_27CA / 0x1C6BA)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x27CC);
    // LODSB SI (19EF_27CB / 0x1C6BB)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x27CE);
    // MOV AH,AL (19EF_27CC / 0x1C6BC)
    AH = AL;
    CheckExternalEvents(cs14, 0x27D0);
    // AND AX,DX (19EF_27CE / 0x1C6BE)
    // AX &= DX;
    AX = Alu16.And(AX, DX);
    CheckExternalEvents(cs14, 0x27D1);
    // STOSW ES:DI (19EF_27D0 / 0x1C6C0)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x27D2);
    // LODSB SI (19EF_27D1 / 0x1C6C1)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x27D4);
    // MOV AH,AL (19EF_27D2 / 0x1C6C2)
    AH = AL;
    CheckExternalEvents(cs14, 0x27D6);
    // AND AX,DX (19EF_27D4 / 0x1C6C4)
    // AX &= DX;
    AX = Alu16.And(AX, DX);
    CheckExternalEvents(cs14, 0x27D7);
    // STOSW ES:DI (19EF_27D6 / 0x1C6C6)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x27D9);
    // ADD DI,BX (19EF_27D7 / 0x1C6C7)
    // DI += BX;
    DI = Alu16.Add(DI, BX);
    CheckExternalEvents(cs14, 0x27DB);
    // LOOP 0x1000:c6af (19EF_27D9 / 0x1C6C9)
    if(--CX != 0) {
      goto label_19EF_27BF_1C6AF;
    }
    CheckExternalEvents(cs14, 0x27DD);
    // JMP 0x1000:c709 (19EF_27DB / 0x1C6CB)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_C6CE_1C6CE, 0x1C709 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_C6CE_1C6CE(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1C709: goto label_1000_C709_1C709;break; // Target of external jump from 0x1C795, 0x1C6CB
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_C6CE_1C6CE:
    CheckExternalEvents(cs8, 0xC6D1);
    // MOV AX,word ptr [BP + 0xa] (1000_C6CE / 0x1C6CE)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0xC6D3);
    // SHL AX,0x1 (1000_C6D1 / 0x1C6D1)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0xC6D5);
    // SHL AX,0x1 (1000_C6D3 / 0x1C6D3)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs8, 0xC6D8);
    // MOV [0xb792],AX (1000_C6D5 / 0x1C6D5)
    UInt16[DS, 0xB792] = AX;
    CheckExternalEvents(cs8, 0xC6DB);
    // MOV AX,word ptr [BP + 0xc] (1000_C6D8 / 0x1C6D8)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0xC6DE);
    // MOV DX,0x140 (1000_C6DB / 0x1C6DB)
    DX = 0x140;
    CheckExternalEvents(cs8, 0xC6E0);
    // MUL DX (1000_C6DE / 0x1C6DE)
    uint resMul1000_C6DE = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul1000_C6DE);
    DX = (ushort)(resMul1000_C6DE >> 16);
    CheckExternalEvents(cs8, 0xC6E4);
    // ADD AX,word ptr [0xb792] (1000_C6E0 / 0x1C6E0)
    // AX += UInt16[DS, 0xB792];
    AX = Alu16.Add(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs8, 0xC6E6);
    // MOV DI,AX (1000_C6E4 / 0x1C6E4)
    DI = AX;
    CheckExternalEvents(cs8, 0xC6E9);
    // MOV CX,0x2 (1000_C6E6 / 0x1C6E6)
    CX = 0x2;
    CheckExternalEvents(cs8, 0xC6EA);
    // PUSH DS (1000_C6E9 / 0x1C6E9)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xC6EE);
    // MOV DS,word ptr [0xb78c] (1000_C6EA / 0x1C6EA)
    DS = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs8, 0xC6EF);
    // CLD  (1000_C6EE / 0x1C6EE)
    DirectionFlag = false;
    label_1000_C6EF_1C6EF:
    CheckExternalEvents(cs8, 0xC6F0);
    // MOVSW ES:DI,SI (1000_C6EF / 0x1C6EF)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xC6F1);
    // MOVSW ES:DI,SI (1000_C6F0 / 0x1C6F0)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xC6F5);
    // ADD DI,0x1ffc (1000_C6F1 / 0x1C6F1)
    // DI += 0x1FFC;
    DI = Alu16.Add(DI, 0x1FFC);
    CheckExternalEvents(cs8, 0xC6F6);
    // MOVSW ES:DI,SI (1000_C6F5 / 0x1C6F5)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xC6F7);
    // MOVSW ES:DI,SI (1000_C6F6 / 0x1C6F6)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xC6FB);
    // ADD DI,0x1ffc (1000_C6F7 / 0x1C6F7)
    // DI += 0x1FFC;
    DI = Alu16.Add(DI, 0x1FFC);
    CheckExternalEvents(cs8, 0xC6FC);
    // MOVSW ES:DI,SI (1000_C6FB / 0x1C6FB)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xC6FD);
    // MOVSW ES:DI,SI (1000_C6FC / 0x1C6FC)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xC701);
    // ADD DI,0x1ffc (1000_C6FD / 0x1C6FD)
    // DI += 0x1FFC;
    DI = Alu16.Add(DI, 0x1FFC);
    CheckExternalEvents(cs8, 0xC702);
    // MOVSW ES:DI,SI (1000_C701 / 0x1C701)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xC703);
    // MOVSW ES:DI,SI (1000_C702 / 0x1C702)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xC707);
    // SUB DI,0x5f64 (1000_C703 / 0x1C703)
    // DI -= 0x5F64;
    DI = Alu16.Sub(DI, 0x5F64);
    CheckExternalEvents(cs8, 0xC709);
    // LOOP 0x1000:c6ef (1000_C707 / 0x1C707)
    if(--CX != 0) {
      goto label_1000_C6EF_1C6EF;
    }
    label_1000_C709_1C709:
    CheckExternalEvents(cs8, 0xC70A);
    // POP DS (1000_C709 / 0x1C709)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC70B);
    // POP ES (1000_C70A / 0x1C70A)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC70C);
    // POP DS (1000_C70B / 0x1C70B)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC70D);
    // POP SI (1000_C70C / 0x1C70C)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC70E);
    // POP DI (1000_C70D / 0x1C70D)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC70F);
    // POP BP (1000_C70E / 0x1C70E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC710);
    // RETF  (1000_C70F / 0x1C70F)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_C710_1C710(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C710_1C710:
    CheckExternalEvents(cs8, 0xC713);
    // MOV AX,word ptr [BP + 0xa] (1000_C710 / 0x1C710)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0xC715);
    // SHL AX,0x1 (1000_C713 / 0x1C713)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs8, 0xC718);
    // MOV [0xb792],AX (1000_C715 / 0x1C715)
    UInt16[DS, 0xB792] = AX;
    CheckExternalEvents(cs8, 0xC71B);
    // MOV AX,word ptr [BP + 0xc] (1000_C718 / 0x1C718)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0xC71E);
    // MOV DX,0x140 (1000_C71B / 0x1C71B)
    DX = 0x140;
    CheckExternalEvents(cs8, 0xC720);
    // MUL DX (1000_C71E / 0x1C71E)
    uint resMul1000_C71E = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul1000_C71E);
    DX = (ushort)(resMul1000_C71E >> 16);
    CheckExternalEvents(cs8, 0xC724);
    // ADD AX,word ptr [0xb792] (1000_C720 / 0x1C720)
    // AX += UInt16[DS, 0xB792];
    AX = Alu16.Add(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs8, 0xC726);
    // MOV DI,AX (1000_C724 / 0x1C724)
    DI = AX;
    CheckExternalEvents(cs8, 0xC729);
    // MOV CX,0x4 (1000_C726 / 0x1C726)
    CX = 0x4;
    CheckExternalEvents(cs8, 0xC72A);
    // PUSH DS (1000_C729 / 0x1C729)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xC72E);
    // MOV DS,word ptr [0xb78c] (1000_C72A / 0x1C72A)
    DS = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs8, 0xC72F);
    // CLD  (1000_C72E / 0x1C72E)
    DirectionFlag = false;
    label_1000_C72F_1C72F:
    CheckExternalEvents(cs8, 0xC730);
    // MOVSW ES:DI,SI (1000_C72F / 0x1C72F)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xC734);
    // ADD DI,0x1ffe (1000_C730 / 0x1C730)
    // DI += 0x1FFE;
    DI = Alu16.Add(DI, 0x1FFE);
    CheckExternalEvents(cs8, 0xC735);
    // MOVSW ES:DI,SI (1000_C734 / 0x1C734)
    UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xC739);
    // SUB DI,0x1fb2 (1000_C735 / 0x1C735)
    // DI -= 0x1FB2;
    DI = Alu16.Sub(DI, 0x1FB2);
    CheckExternalEvents(cs8, 0xC73B);
    // LOOP 0x1000:c72f (1000_C739 / 0x1C739)
    if(--CX != 0) {
      goto label_1000_C72F_1C72F;
    }
    CheckExternalEvents(cs8, 0xC73D);
    // JMP 0x1000:c709 (1000_C73B / 0x1C73B)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_C6CE_1C6CE, 0x1C709 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ghidra_guess_1000_C73D_1C73D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C73D_1C73D:
    CheckExternalEvents(cs8, 0xC740);
    // MOV DX,0x3ce (1000_C73D / 0x1C73D)
    DX = 0x3CE;
    CheckExternalEvents(cs8, 0xC743);
    // MOV AX,0x5 (1000_C740 / 0x1C740)
    AX = 0x5;
    CheckExternalEvents(cs8, 0xC744);
    // OUT DX,AX (1000_C743 / 0x1C743)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xC747);
    // MOV AX,0xff08 (1000_C744 / 0x1C744)
    AX = 0xFF08;
    CheckExternalEvents(cs8, 0xC748);
    // OUT DX,AX (1000_C747 / 0x1C747)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xC74B);
    // MOV AX,0x1 (1000_C748 / 0x1C748)
    AX = 0x1;
    CheckExternalEvents(cs8, 0xC74C);
    // OUT DX,AX (1000_C74B / 0x1C74B)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xC74F);
    // MOV AX,0xa000 (1000_C74C / 0x1C74C)
    AX = 0xA000;
    CheckExternalEvents(cs8, 0xC751);
    // MOV ES,AX (1000_C74F / 0x1C74F)
    ES = AX;
    CheckExternalEvents(cs8, 0xC754);
    // MOV DI,word ptr [BP + 0xa] (1000_C751 / 0x1C751)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0xC757);
    // MOV AX,word ptr [BP + 0xc] (1000_C754 / 0x1C754)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0xC75A);
    // MOV DX,0x140 (1000_C757 / 0x1C757)
    DX = 0x140;
    CheckExternalEvents(cs8, 0xC75C);
    // MUL DX (1000_C75A / 0x1C75A)
    uint resMul1000_C75A = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul1000_C75A);
    DX = (ushort)(resMul1000_C75A >> 16);
    CheckExternalEvents(cs8, 0xC75E);
    // ADD DI,AX (1000_C75C / 0x1C75C)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs8, 0xC75F);
    // PUSH DS (1000_C75E / 0x1C75E)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xC763);
    // MOV DS,word ptr [0xb78c] (1000_C75F / 0x1C75F)
    DS = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs8, 0xC766);
    // MOV CX,0x8 (1000_C763 / 0x1C763)
    CX = 0x8;
    CheckExternalEvents(cs8, 0xC769);
    // MOV DX,0x3c4 (1000_C766 / 0x1C766)
    DX = 0x3C4;
    label_1000_C769_1C769:
    CheckExternalEvents(cs8, 0xC76C);
    // MOV AX,0x102 (1000_C769 / 0x1C769)
    AX = 0x102;
    CheckExternalEvents(cs8, 0xC76D);
    // OUT DX,AX (1000_C76C / 0x1C76C)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xC770);
    // MOV AL,byte ptr ES:[DI] (1000_C76D / 0x1C76D)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs8, 0xC771);
    // MOVSB ES:DI,SI (1000_C770 / 0x1C770)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xC772);
    // DEC DI (1000_C771 / 0x1C771)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs8, 0xC775);
    // MOV AX,0x202 (1000_C772 / 0x1C772)
    AX = 0x202;
    CheckExternalEvents(cs8, 0xC776);
    // OUT DX,AX (1000_C775 / 0x1C775)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xC779);
    // MOV AL,byte ptr ES:[DI] (1000_C776 / 0x1C776)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs8, 0xC77A);
    // MOVSB ES:DI,SI (1000_C779 / 0x1C779)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xC77B);
    // DEC DI (1000_C77A / 0x1C77A)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs8, 0xC77E);
    // MOV AX,0x402 (1000_C77B / 0x1C77B)
    AX = 0x402;
    CheckExternalEvents(cs8, 0xC77F);
    // OUT DX,AX (1000_C77E / 0x1C77E)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xC782);
    // MOV AL,byte ptr ES:[DI] (1000_C77F / 0x1C77F)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs8, 0xC783);
    // MOVSB ES:DI,SI (1000_C782 / 0x1C782)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xC784);
    // DEC DI (1000_C783 / 0x1C783)
    DI = Alu16.Dec(DI);
    CheckExternalEvents(cs8, 0xC787);
    // MOV AX,0x802 (1000_C784 / 0x1C784)
    AX = 0x802;
    CheckExternalEvents(cs8, 0xC788);
    // OUT DX,AX (1000_C787 / 0x1C787)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xC78B);
    // MOV AL,byte ptr ES:[DI] (1000_C788 / 0x1C788)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs8, 0xC78C);
    // MOVSB ES:DI,SI (1000_C78B / 0x1C78B)
    UInt8[ES, (ushort)(DI)] = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xC78F);
    // ADD DI,0x27 (1000_C78C / 0x1C78C)
    // DI += 0x27;
    DI = Alu16.Add(DI, 0x27);
    CheckExternalEvents(cs8, 0xC791);
    // LOOP 0x1000:c769 (1000_C78F / 0x1C78F)
    if(--CX != 0) {
      goto label_1000_C769_1C769;
    }
    CheckExternalEvents(cs8, 0xC794);
    // MOV AX,0xf02 (1000_C791 / 0x1C791)
    AX = 0xF02;
    CheckExternalEvents(cs8, 0xC795);
    // OUT DX,AX (1000_C794 / 0x1C794)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xC798);
    // JMP 0x1000:c709 (1000_C795 / 0x1C795)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_C6CE_1C6CE, 0x1C709 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action unknown_19EF_28A8_1C798(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_28A8_1C798:
    CheckExternalEvents(cs14, 0x28A9);
    // PUSH BP (19EF_28A8 / 0x1C798)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x28AB);
    // MOV BP,SP (19EF_28A9 / 0x1C799)
    BP = SP;
    CheckExternalEvents(cs14, 0x28AC);
    // PUSH DI (19EF_28AB / 0x1C79B)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x28AD);
    // PUSH SI (19EF_28AC / 0x1C79C)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x28AE);
    // PUSH DS (19EF_28AD / 0x1C79D)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x28B1);
    // MOV AX,0x1ddc (19EF_28AE / 0x1C79E)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x28B3);
    // MOV DS,AX (19EF_28B1 / 0x1C7A1)
    DS = AX;
    CheckExternalEvents(cs14, 0x28B6);
    // MOV AX,word ptr [BP + 0x6] (19EF_28B3 / 0x1C7A3)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x28B9);
    // MOV [0xb78a],AX (19EF_28B6 / 0x1C7A6)
    UInt16[DS, 0xB78A] = AX;
    CheckExternalEvents(cs14, 0x28BC);
    // MOV AX,word ptr [BP + 0x8] (19EF_28B9 / 0x1C7A9)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x28BF);
    // MOV [0xb78c],AX (19EF_28BC / 0x1C7AC)
    UInt16[DS, 0xB78C] = AX;
    CheckExternalEvents(cs14, 0x28C2);
    // MOV AX,word ptr [BP + 0xa] (19EF_28BF / 0x1C7AF)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x28C5);
    // MOV [0xb78e],AX (19EF_28C2 / 0x1C7B2)
    UInt16[DS, 0xB78E] = AX;
    CheckExternalEvents(cs14, 0x28C8);
    // MOV AX,word ptr [BP + 0xc] (19EF_28C5 / 0x1C7B5)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x28CB);
    // MOV [0xb790],AX (19EF_28C8 / 0x1C7B8)
    UInt16[DS, 0xB790] = AX;
    CheckExternalEvents(cs14, 0x28CF);
    // MOV DI,word ptr [0xb78e] (19EF_28CB / 0x1C7BB)
    DI = UInt16[DS, 0xB78E];
    CheckExternalEvents(cs14, 0x28D2);
    // MOV AX,[0xb790] (19EF_28CF / 0x1C7BF)
    AX = UInt16[DS, 0xB790];
    CheckExternalEvents(cs14, 0x28D3);
    // PUSH ES (19EF_28D2 / 0x1C7C2)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x28D5);
    // MOV ES,AX (19EF_28D3 / 0x1C7C3)
    ES = AX;
    CheckExternalEvents(cs14, 0x28D9);
    // MOV SI,word ptr [0xb78a] (19EF_28D5 / 0x1C7C5)
    SI = UInt16[DS, 0xB78A];
    CheckExternalEvents(cs14, 0x28DC);
    // MOV CX,0x40 (19EF_28D9 / 0x1C7C9)
    CX = 0x40;
    CheckExternalEvents(cs14, 0x28DD);
    // PUSH DS (19EF_28DC / 0x1C7CC)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x28E1);
    // MOV DS,word ptr [0xb78c] (19EF_28DD / 0x1C7CD)
    DS = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs14, 0x28E2);
    // CLD  (19EF_28E1 / 0x1C7D1)
    DirectionFlag = false;
    CheckExternalEvents(cs14, 0x28E4);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (19EF_28E2 / 0x1C7D2)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs14, 0x28E5);
    // POP DS (19EF_28E4 / 0x1C7D4)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x28E6);
    // POP ES (19EF_28E5 / 0x1C7D5)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x28E7);
    // POP DS (19EF_28E6 / 0x1C7D6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x28E8);
    // POP SI (19EF_28E7 / 0x1C7D7)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x28E9);
    // POP DI (19EF_28E8 / 0x1C7D8)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x28EA);
    // POP BP (19EF_28E9 / 0x1C7D9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x28EB);
    // RETF  (19EF_28EA / 0x1C7DA)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_28EB_1C7DB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_28EB_1C7DB:
    CheckExternalEvents(cs14, 0x28EC);
    // PUSH BP (19EF_28EB / 0x1C7DB)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x28EE);
    // MOV BP,SP (19EF_28EC / 0x1C7DC)
    BP = SP;
    CheckExternalEvents(cs14, 0x28EF);
    // PUSH DI (19EF_28EE / 0x1C7DE)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x28F0);
    // PUSH SI (19EF_28EF / 0x1C7DF)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x28F1);
    // PUSH DS (19EF_28F0 / 0x1C7E0)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x28F4);
    // MOV AX,0x1ddc (19EF_28F1 / 0x1C7E1)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x28F6);
    // MOV DS,AX (19EF_28F4 / 0x1C7E4)
    DS = AX;
    CheckExternalEvents(cs14, 0x28FB);
    // CMP word ptr [0xb764],0x0 (19EF_28F6 / 0x1C7E6)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x28FD);
    // JNZ 0x1000:c7f0 (19EF_28FB / 0x1C7EB)
    if(!ZeroFlag) {
      goto label_19EF_2900_1C7F0;
    }
    CheckExternalEvents(cs14, 0x2900);
    // JMP 0x1000:c90e (19EF_28FD / 0x1C7ED)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_C90E_1C90E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_2900_1C7F0:
    CheckExternalEvents(cs14, 0x2901);
    // PUSH ES (19EF_2900 / 0x1C7F0)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x2904);
    // MOV AX,word ptr [BP + 0x6] (19EF_2901 / 0x1C7F1)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x2907);
    // MOV [0xb78e],AX (19EF_2904 / 0x1C7F4)
    UInt16[DS, 0xB78E] = AX;
    CheckExternalEvents(cs14, 0x290A);
    // MOV AX,word ptr [BP + 0x8] (19EF_2907 / 0x1C7F7)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x290D);
    // MOV [0xb790],AX (19EF_290A / 0x1C7FA)
    UInt16[DS, 0xB790] = AX;
    CheckExternalEvents(cs14, 0x2910);
    // MOV AX,word ptr [BP + 0xa] (19EF_290D / 0x1C7FD)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x2913);
    // MOV [0xb78a],AX (19EF_2910 / 0x1C800)
    UInt16[DS, 0xB78A] = AX;
    CheckExternalEvents(cs14, 0x2916);
    // MOV AX,word ptr [BP + 0xc] (19EF_2913 / 0x1C803)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x2919);
    // MOV [0xb78c],AX (19EF_2916 / 0x1C806)
    UInt16[DS, 0xB78C] = AX;
    CheckExternalEvents(cs14, 0x291C);
    // MOV AX,word ptr [BP + 0xe] (19EF_2919 / 0x1C809)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs14, 0x291E);
    // SAR AX,0x1 (19EF_291C / 0x1C80C)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs14, 0x2921);
    // MOV [0xb792],AX (19EF_291E / 0x1C80E)
    UInt16[DS, 0xB792] = AX;
    CheckExternalEvents(cs14, 0x2924);
    // MOV AX,word ptr [BP + 0x10] (19EF_2921 / 0x1C811)
    AX = UInt16[SS, (ushort)(BP + 0x10)];
    CheckExternalEvents(cs14, 0x2927);
    // MOV [0xb794],AX (19EF_2924 / 0x1C814)
    UInt16[DS, 0xB794] = AX;
    CheckExternalEvents(cs14, 0x2928);
    // PUSH DS (19EF_2927 / 0x1C817)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x292C);
    // MOV SI,word ptr [0xb78a] (19EF_2928 / 0x1C818)
    SI = UInt16[DS, 0xB78A];
    CheckExternalEvents(cs14, 0x292D);
    // INC SI (19EF_292C / 0x1C81C)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x2930);
    // MOV AX,[0xb78c] (19EF_292D / 0x1C81D)
    AX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs14, 0x2932);
    // MOV DS,AX (19EF_2930 / 0x1C820)
    DS = AX;
    CheckExternalEvents(cs14, 0x2933);
    // LODSW SI (19EF_2932 / 0x1C822)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0x2934);
    // INC SI (19EF_2933 / 0x1C823)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x2935);
    // POP DS (19EF_2934 / 0x1C824)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2937);
    // INC AL (19EF_2935 / 0x1C825)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs14, 0x2938);
    // PUSH AX (19EF_2937 / 0x1C827)
    Stack.Push16(AX);
    CheckExternalEvents(cs14, 0x293B);
    // AND AX,0xff (19EF_2938 / 0x1C828)
    // AX &= 0xFF;
    AX = Alu16.And(AX, 0xFF);
    CheckExternalEvents(cs14, 0x293E);
    // MOV [0xb79c],AX (19EF_293B / 0x1C82B)
    UInt16[DS, 0xB79C] = AX;
    CheckExternalEvents(cs14, 0x293F);
    // POP AX (19EF_293E / 0x1C82E)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2941);
    // XCHG AH,AL (19EF_293F / 0x1C82F)
    (AL, AH) = (AH, AL);
    CheckExternalEvents(cs14, 0x2944);
    // AND AX,0xff (19EF_2941 / 0x1C831)
    AX &= 0xFF;
    CheckExternalEvents(cs14, 0x2946);
    // SHL AX,0x1 (19EF_2944 / 0x1C834)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x2948);
    // SHL AX,0x1 (19EF_2946 / 0x1C836)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs14, 0x294B);
    // MOV [0xb79a],AX (19EF_2948 / 0x1C838)
    UInt16[DS, 0xB79A] = AX;
    CheckExternalEvents(cs14, 0x294E);
    // MOV [0xb79e],AX (19EF_294B / 0x1C83B)
    UInt16[DS, 0xB79E] = AX;
    CheckExternalEvents(cs14, 0x2951);
    // MOV AX,[0xb794] (19EF_294E / 0x1C83E)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs14, 0x2954);
    // CMP AX,0x0 (19EF_2951 / 0x1C841)
    Alu16.Sub(AX, 0x0);
    CheckExternalEvents(cs14, 0x2956);
    // JNS 0x1000:c867 (19EF_2954 / 0x1C844)
    if(!SignFlag) {
      goto label_19EF_2977_1C867;
    }
    CheckExternalEvents(cs14, 0x2958);
    // NEG AX (19EF_2956 / 0x1C846)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs14, 0x295C);
    // CMP AX,word ptr [0xb79c] (19EF_2958 / 0x1C848)
    Alu16.Sub(AX, UInt16[DS, 0xB79C]);
    CheckExternalEvents(cs14, 0x295E);
    // JNC 0x1000:c8ad (19EF_295C / 0x1C84C)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC8AF);
      // JMP 0x1000:c908 (1000_C8AD / 0x1C8AD)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x2962);
    // MOV DX,word ptr [0xb79a] (19EF_295E / 0x1C84E)
    DX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x2964);
    // MUL DL (19EF_2962 / 0x1C852)
    ushort resMul19EF_2962 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul19EF_2962);
    AH = (byte)(resMul19EF_2962 >> 8);
    CheckExternalEvents(cs14, 0x2966);
    // ADD SI,AX (19EF_2964 / 0x1C854)
    // SI += AX;
    SI = Alu16.Add(SI, AX);
    CheckExternalEvents(cs14, 0x2969);
    // MOV AX,[0xb79c] (19EF_2966 / 0x1C856)
    AX = UInt16[DS, 0xB79C];
    CheckExternalEvents(cs14, 0x296D);
    // ADD AX,word ptr [0xb794] (19EF_2969 / 0x1C859)
    // AX += UInt16[DS, 0xB794];
    AX = Alu16.Add(AX, UInt16[DS, 0xB794]);
    CheckExternalEvents(cs14, 0x296F);
    // JS 0x1000:c8ad (19EF_296D / 0x1C85D)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC8AF);
      // JMP 0x1000:c908 (1000_C8AD / 0x1C8AD)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x2972);
    // MOV [0xb79c],AX (19EF_296F / 0x1C85F)
    UInt16[DS, 0xB79C] = AX;
    CheckExternalEvents(cs14, 0x2974);
    // XOR AX,AX (19EF_2972 / 0x1C862)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs14, 0x2977);
    // MOV [0xb794],AX (19EF_2974 / 0x1C864)
    UInt16[DS, 0xB794] = AX;
    label_19EF_2977_1C867:
    CheckExternalEvents(cs14, 0x297A);
    // MOV AX,0xc8 (19EF_2977 / 0x1C867)
    AX = 0xC8;
    CheckExternalEvents(cs14, 0x297E);
    // SUB AX,word ptr [0xb794] (19EF_297A / 0x1C86A)
    // AX -= UInt16[DS, 0xB794];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB794]);
    CheckExternalEvents(cs14, 0x2980);
    // JS 0x1000:c8ad (19EF_297E / 0x1C86E)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC8AF);
      // JMP 0x1000:c908 (1000_C8AD / 0x1C8AD)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x2982);
    // JZ 0x1000:c8ad (19EF_2980 / 0x1C870)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC8AF);
      // JMP 0x1000:c908 (1000_C8AD / 0x1C8AD)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x2986);
    // CMP AX,word ptr [0xb79c] (19EF_2982 / 0x1C872)
    Alu16.Sub(AX, UInt16[DS, 0xB79C]);
    CheckExternalEvents(cs14, 0x2988);
    // JNC 0x1000:c87b (19EF_2986 / 0x1C876)
    if(!CarryFlag) {
      goto label_19EF_298B_1C87B;
    }
    CheckExternalEvents(cs14, 0x298B);
    // MOV [0xb79c],AX (19EF_2988 / 0x1C878)
    UInt16[DS, 0xB79C] = AX;
    label_19EF_298B_1C87B:
    CheckExternalEvents(cs14, 0x298E);
    // MOV AX,[0xb792] (19EF_298B / 0x1C87B)
    AX = UInt16[DS, 0xB792];
    CheckExternalEvents(cs14, 0x2991);
    // CMP AX,0x0 (19EF_298E / 0x1C87E)
    Alu16.Sub(AX, 0x0);
    CheckExternalEvents(cs14, 0x2993);
    // JNS 0x1000:c896 (19EF_2991 / 0x1C881)
    if(!SignFlag) {
      goto label_19EF_29A6_1C896;
    }
    CheckExternalEvents(cs14, 0x2997);
    // ADD word ptr [0xb79a],AX (19EF_2993 / 0x1C883)
    UInt16[DS, 0xB79A] += AX;
    CheckExternalEvents(cs14, 0x2999);
    // NEG AX (19EF_2997 / 0x1C887)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs14, 0x299B);
    // ADD SI,AX (19EF_2999 / 0x1C889)
    SI += AX;
    CheckExternalEvents(cs14, 0x299F);
    // CMP AX,word ptr [0xb79e] (19EF_299B / 0x1C88B)
    Alu16.Sub(AX, UInt16[DS, 0xB79E]);
    CheckExternalEvents(cs14, 0x29A1);
    // JNC 0x1000:c8ad (19EF_299F / 0x1C88F)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC8AF);
      // JMP 0x1000:c908 (1000_C8AD / 0x1C8AD)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x29A3);
    // XOR AX,AX (19EF_29A1 / 0x1C891)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs14, 0x29A6);
    // MOV [0xb792],AX (19EF_29A3 / 0x1C893)
    UInt16[DS, 0xB792] = AX;
    label_19EF_29A6_1C896:
    CheckExternalEvents(cs14, 0x29A9);
    // MOV AX,0xa0 (19EF_29A6 / 0x1C896)
    AX = 0xA0;
    CheckExternalEvents(cs14, 0x29AD);
    // SUB AX,word ptr [0xb792] (19EF_29A9 / 0x1C899)
    // AX -= UInt16[DS, 0xB792];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs14, 0x29AF);
    // JS 0x1000:c8ad (19EF_29AD / 0x1C89D)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC8AF);
      // JMP 0x1000:c908 (1000_C8AD / 0x1C8AD)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x29B1);
    // JZ 0x1000:c8ad (19EF_29AF / 0x1C89F)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC8AF);
      // JMP 0x1000:c908 (1000_C8AD / 0x1C8AD)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x29B5);
    // CMP AX,word ptr [0xb79a] (19EF_29B1 / 0x1C8A1)
    Alu16.Sub(AX, UInt16[DS, 0xB79A]);
    CheckExternalEvents(cs14, 0x29B7);
    // JNC 0x1000:c8b0 (19EF_29B5 / 0x1C8A5)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x29BA);
    // MOV [0xb79a],AX (19EF_29B7 / 0x1C8A7)
    UInt16[DS, 0xB79A] = AX;
    CheckExternalEvents(cs14, 0x29BC);
    // JMP 0x1000:c8b0 (19EF_29BA / 0x1C8AA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
