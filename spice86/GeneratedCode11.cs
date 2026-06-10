namespace generated;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.InstructionsImpl;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action split_1000_1005_11005(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1005_11005:
    CheckExternalEvents(cs8, 0x1006);
    // POP SI (1000_1005 / 0x11005)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x1008);
    // MOV SP,BP (1000_1006 / 0x11006)
    SP = BP;
    CheckExternalEvents(cs8, 0x1009);
    // POP BP (1000_1008 / 0x11008)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x100A);
    // RETF  (1000_1009 / 0x11009)
    return FarRet();
  }
  
  public virtual Action unknown_0FA1_16AB_110BB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0FA1_16AB_110BB:
    CheckExternalEvents(cs7, 0x16AC);
    // PUSH BP (0FA1_16AB / 0x110BB)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x16AE);
    // MOV BP,SP (0FA1_16AC / 0x110BC)
    BP = SP;
    CheckExternalEvents(cs7, 0x16B1);
    // MOV AX,0x22 (0FA1_16AE / 0x110BE)
    AX = 0x22;
    CheckExternalEvents(cs7, 0x16B6);
    // CALLF 0x1000:cecc (0FA1_16B1 / 0x110C1)
    FarCall(cs7, 0x16B6, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x16B7);
    // PUSH DI (0FA1_16B6 / 0x110C6)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x16B8);
    // PUSH SI (0FA1_16B7 / 0x110C7)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x16BD);
    // MOV word ptr [BP + -0x6],0x0 (0FA1_16B8 / 0x110C8)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    CheckExternalEvents(cs7, 0x16C1);
    // CMP word ptr [BP + 0x6],0x4 (0FA1_16BD / 0x110CD)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x16C3);
    // JL 0x1000:10d9 (0FA1_16C1 / 0x110D1)
    if(SignFlag != OverflowFlag) {
      goto label_0FA1_16C9_110D9;
    }
    CheckExternalEvents(cs7, 0x16C7);
    // CMP word ptr [BP + 0x6],0xc (0FA1_16C3 / 0x110D3)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs7, 0x16C9);
    // JL 0x1000:10e2 (0FA1_16C7 / 0x110D7)
    if(SignFlag != OverflowFlag) {
      goto label_0FA1_16D2_110E2;
    }
    label_0FA1_16C9_110D9:
    CheckExternalEvents(cs7, 0x16CD);
    // CMP word ptr [BP + 0x6],0x10 (0FA1_16C9 / 0x110D9)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x10);
    CheckExternalEvents(cs7, 0x16CF);
    // JGE 0x1000:10e2 (0FA1_16CD / 0x110DD)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_16D2_110E2;
    }
    CheckExternalEvents(cs7, 0x16D2);
    // JMP 0x1000:1274 (0FA1_16CF / 0x110DF)
    goto label_0FA1_1864_11274;
    label_0FA1_16D2_110E2:
    CheckExternalEvents(cs7, 0x16D6);
    // CMP word ptr [BP + 0x6],0x10 (0FA1_16D2 / 0x110E2)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x10);
    CheckExternalEvents(cs7, 0x16D8);
    // JL 0x1000:10f0 (0FA1_16D6 / 0x110E6)
    if(SignFlag != OverflowFlag) {
      goto label_0FA1_16E0_110F0;
    }
    CheckExternalEvents(cs7, 0x16DB);
    // MOV AX,word ptr [BP + 0x6] (0FA1_16D8 / 0x110E8)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x16DE);
    // SUB AX,0x8 (0FA1_16DB / 0x110EB)
    // AX -= 0x8;
    AX = Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs7, 0x16E0);
    // JMP 0x1000:10f6 (0FA1_16DE / 0x110EE)
    goto label_0FA1_16E6_110F6;
    label_0FA1_16E0_110F0:
    CheckExternalEvents(cs7, 0x16E3);
    // MOV AX,word ptr [BP + 0x6] (0FA1_16E0 / 0x110F0)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x16E6);
    // SUB AX,0x4 (0FA1_16E3 / 0x110F3)
    // AX -= 0x4;
    AX = Alu16.Sub(AX, 0x4);
    label_0FA1_16E6_110F6:
    CheckExternalEvents(cs7, 0x16E9);
    // MOV word ptr [BP + -0x1a],AX (0FA1_16E6 / 0x110F6)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs7, 0x16EE);
    // MOV word ptr [BP + -0x18],0x4 (0FA1_16E9 / 0x110F9)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x4;
    label_0FA1_16EE_110FE:
    CheckExternalEvents(cs7, 0x16F1);
    // MOV AX,word ptr [BP + 0x6] (0FA1_16EE / 0x110FE)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x16F4);
    // CMP word ptr [BP + -0x18],AX (0FA1_16F1 / 0x11101)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], AX);
    CheckExternalEvents(cs7, 0x16F6);
    // JZ 0x1000:113b (0FA1_16F4 / 0x11104)
    if(ZeroFlag) {
      goto label_0FA1_172B_1113B;
    }
    CheckExternalEvents(cs7, 0x16F9);
    // MOV SI,word ptr [BP + -0x18] (0FA1_16F6 / 0x11106)
    SI = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x16FB);
    // SHL SI,0x1 (0FA1_16F9 / 0x11109)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x16FF);
    // MOV ES,word ptr [0x5582] (0FA1_16FB / 0x1110B)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x1703);
    // MOV AX,ES:[0xa44b] (0FA1_16FF / 0x1110F)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x1707);
    // MOV ES,word ptr [0x5592] (0FA1_1703 / 0x11113)
    ES = UInt16[DS, 0x5592];
    CheckExternalEvents(cs7, 0x170C);
    // CMP word ptr ES:[SI + 0x4004],AX (0FA1_1707 / 0x11117)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4004)], AX);
    CheckExternalEvents(cs7, 0x170E);
    // JNZ 0x1000:113b (0FA1_170C / 0x1111C)
    if(!ZeroFlag) {
      goto label_0FA1_172B_1113B;
    }
    CheckExternalEvents(cs7, 0x1712);
    // MOV ES,word ptr [0x5584] (0FA1_170E / 0x1111E)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs7, 0x1716);
    // MOV AX,ES:[0xa44d] (0FA1_1712 / 0x11122)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x171A);
    // MOV ES,word ptr [0x5590] (0FA1_1716 / 0x11126)
    ES = UInt16[DS, 0x5590];
    CheckExternalEvents(cs7, 0x171F);
    // CMP word ptr ES:[SI + 0x4036],AX (0FA1_171A / 0x1112A)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4036)], AX);
    CheckExternalEvents(cs7, 0x1721);
    // JNZ 0x1000:113b (0FA1_171F / 0x1112F)
    if(!ZeroFlag) {
      goto label_0FA1_172B_1113B;
    }
    CheckExternalEvents(cs7, 0x1726);
    // MOV word ptr [BP + -0x6],0x1 (0FA1_1721 / 0x11131)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    CheckExternalEvents(cs7, 0x172B);
    // MOV word ptr [BP + -0x18],0xc (0FA1_1726 / 0x11136)
    UInt16[SS, (ushort)(BP - 0x18)] = 0xC;
    label_0FA1_172B_1113B:
    CheckExternalEvents(cs7, 0x172F);
    // CMP word ptr [BP + -0x6],0x0 (0FA1_172B / 0x1113B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs7, 0x1731);
    // JNZ 0x1000:1181 (0FA1_172F / 0x1113F)
    if(!ZeroFlag) {
      goto label_0FA1_1771_11181;
    }
    CheckExternalEvents(cs7, 0x1734);
    // MOV AX,word ptr [BP + -0x18] (0FA1_1731 / 0x11141)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x1737);
    // ADD AX,0xc (0FA1_1734 / 0x11144)
    AX += 0xC;
    CheckExternalEvents(cs7, 0x173A);
    // CMP AX,word ptr [BP + 0x6] (0FA1_1737 / 0x11147)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x173C);
    // JZ 0x1000:1181 (0FA1_173A / 0x1114A)
    if(ZeroFlag) {
      goto label_0FA1_1771_11181;
    }
    CheckExternalEvents(cs7, 0x173F);
    // MOV SI,word ptr [BP + -0x18] (0FA1_173C / 0x1114C)
    SI = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x1741);
    // SHL SI,0x1 (0FA1_173F / 0x1114F)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x1745);
    // MOV ES,word ptr [0x5582] (0FA1_1741 / 0x11151)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x1749);
    // MOV AX,ES:[0xa44b] (0FA1_1745 / 0x11155)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x174D);
    // MOV ES,word ptr [0x5592] (0FA1_1749 / 0x11159)
    ES = UInt16[DS, 0x5592];
    CheckExternalEvents(cs7, 0x1752);
    // CMP word ptr ES:[SI + 0x401c],AX (0FA1_174D / 0x1115D)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x401C)], AX);
    CheckExternalEvents(cs7, 0x1754);
    // JNZ 0x1000:1181 (0FA1_1752 / 0x11162)
    if(!ZeroFlag) {
      goto label_0FA1_1771_11181;
    }
    CheckExternalEvents(cs7, 0x1758);
    // MOV ES,word ptr [0x5584] (0FA1_1754 / 0x11164)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs7, 0x175C);
    // MOV AX,ES:[0xa44d] (0FA1_1758 / 0x11168)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x1760);
    // MOV ES,word ptr [0x5590] (0FA1_175C / 0x1116C)
    ES = UInt16[DS, 0x5590];
    CheckExternalEvents(cs7, 0x1765);
    // CMP word ptr ES:[SI + 0x404e],AX (0FA1_1760 / 0x11170)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x404E)], AX);
    CheckExternalEvents(cs7, 0x1767);
    // JNZ 0x1000:1181 (0FA1_1765 / 0x11175)
    if(!ZeroFlag) {
      goto label_0FA1_1771_11181;
    }
    CheckExternalEvents(cs7, 0x176C);
    // MOV word ptr [BP + -0x6],0x1 (0FA1_1767 / 0x11177)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    CheckExternalEvents(cs7, 0x1771);
    // MOV word ptr [BP + -0x18],0xc (0FA1_176C / 0x1117C)
    UInt16[SS, (ushort)(BP - 0x18)] = 0xC;
    label_0FA1_1771_11181:
    CheckExternalEvents(cs7, 0x1774);
    // INC word ptr [BP + -0x18] (0FA1_1771 / 0x11181)
    UInt16[SS, (ushort)(BP - 0x18)]++;
    CheckExternalEvents(cs7, 0x1778);
    // CMP word ptr [BP + -0x18],0xc (0FA1_1774 / 0x11184)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0xC);
    CheckExternalEvents(cs7, 0x177A);
    // JGE 0x1000:118d (0FA1_1778 / 0x11188)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_177D_1118D;
    }
    CheckExternalEvents(cs7, 0x177D);
    // JMP 0x1000:10fe (0FA1_177A / 0x1118A)
    goto label_0FA1_16EE_110FE;
    label_0FA1_177D_1118D:
    CheckExternalEvents(cs7, 0x1781);
    // CMP word ptr [BP + -0x6],0x0 (0FA1_177D / 0x1118D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs7, 0x1783);
    // JZ 0x1000:1196 (0FA1_1781 / 0x11191)
    if(ZeroFlag) {
      goto label_0FA1_1786_11196;
    }
    CheckExternalEvents(cs7, 0x1786);
    // JMP 0x1000:154b (0FA1_1783 / 0x11193)
    goto label_0FA1_1B3B_1154B;
    label_0FA1_1786_11196:
    CheckExternalEvents(cs7, 0x178A);
    // MOV ES,word ptr [0x5582] (0FA1_1786 / 0x11196)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x178E);
    // MOV AX,ES:[0xa44b] (0FA1_178A / 0x1119A)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x1791);
    // MOV word ptr [BP + -0x4],AX (0FA1_178E / 0x1119E)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x1795);
    // MOV ES,word ptr [0x5584] (0FA1_1791 / 0x111A1)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs7, 0x1799);
    // MOV AX,ES:[0xa44d] (0FA1_1795 / 0x111A5)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x179C);
    // MOV word ptr [BP + -0xa],AX (0FA1_1799 / 0x111A9)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs7, 0x17A1);
    // MOV word ptr [BP + -0x18],0x0 (0FA1_179C / 0x111AC)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x0;
    CheckExternalEvents(cs7, 0x17A4);
    // JMP 0x1000:124e (0FA1_17A1 / 0x111B1)
    goto label_0FA1_183E_1124E;
    label_0FA1_17A4_111B4:
    CheckExternalEvents(cs7, 0x17A6);
    // SUB AX,AX (0FA1_17A4 / 0x111B4)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x17A7);
    // PUSH AX (0FA1_17A6 / 0x111B6)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x17AA);
    // MOV AX,0xffff (0FA1_17A7 / 0x111B7)
    AX = 0xFFFF;
    CheckExternalEvents(cs7, 0x17AB);
    // PUSH AX (0FA1_17AA / 0x111BA)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x17B0);
    // CALLF 0x0000:301b (0FA1_17AB / 0x111BB)
    FarCall(cs7, 0x17B0, unknown_0170_191B_0301B);
    CheckExternalEvents(cs7, 0x17B3);
    // ADD SP,0x4 (0FA1_17B0 / 0x111C0)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x17B7);
    // MOV ES,word ptr [0x5582] (0FA1_17B3 / 0x111C3)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x17BB);
    // MOV AX,ES:[0xa44b] (0FA1_17B7 / 0x111C7)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x17BE);
    // CMP word ptr [BP + -0x4],AX (0FA1_17BB / 0x111CB)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs7, 0x17C0);
    // JZ 0x1000:11ec (0FA1_17BE / 0x111CE)
    if(ZeroFlag) {
      goto label_0FA1_17DC_111EC;
    }
    CheckExternalEvents(cs7, 0x17C2);
    // SUB AX,AX (0FA1_17C0 / 0x111D0)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x17C3);
    // PUSH AX (0FA1_17C2 / 0x111D2)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x17C6);
    // MOV AX,0x2 (0FA1_17C3 / 0x111D3)
    AX = 0x2;
    CheckExternalEvents(cs7, 0x17C7);
    // PUSH AX (0FA1_17C6 / 0x111D6)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x17CC);
    // CALLF 0x0000:301b (0FA1_17C7 / 0x111D7)
    FarCall(cs7, 0x17CC, unknown_0170_191B_0301B);
    CheckExternalEvents(cs7, 0x17CF);
    // ADD SP,0x4 (0FA1_17CC / 0x111DC)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x17D3);
    // MOV ES,word ptr [0x5582] (0FA1_17CF / 0x111DF)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x17D7);
    // MOV AX,ES:[0xa44b] (0FA1_17D3 / 0x111E3)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x17DA);
    // CMP word ptr [BP + -0x4],AX (0FA1_17D7 / 0x111E7)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs7, 0x17DC);
    // JNZ 0x1000:11f1 (0FA1_17DA / 0x111EA)
    if(!ZeroFlag) {
      goto label_0FA1_17E1_111F1;
    }
    label_0FA1_17DC_111EC:
    CheckExternalEvents(cs7, 0x17E1);
    // MOV word ptr [BP + -0x6],0x1 (0FA1_17DC / 0x111EC)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    label_0FA1_17E1_111F1:
    CheckExternalEvents(cs7, 0x17E5);
    // CMP word ptr [BP + -0x6],0x0 (0FA1_17E1 / 0x111F1)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs7, 0x17E7);
    // JZ 0x1000:1200 (0FA1_17E5 / 0x111F5)
    if(ZeroFlag) {
      goto label_0FA1_17F0_11200;
    }
    CheckExternalEvents(cs7, 0x17EA);
    // MOV AX,0xe (0FA1_17E7 / 0x111F7)
    AX = 0xE;
    CheckExternalEvents(cs7, 0x17ED);
    // MOV word ptr [BP + -0x18],AX (0FA1_17EA / 0x111FA)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs7, 0x17F0);
    // MOV word ptr [BP + -0x1e],AX (0FA1_17ED / 0x111FD)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    label_0FA1_17F0_11200:
    CheckExternalEvents(cs7, 0x17F4);
    // ADD word ptr [BP + -0x1e],0xc (0FA1_17F0 / 0x11200)
    UInt16[SS, (ushort)(BP - 0x1E)] += 0xC;
    label_0FA1_17F4_11204:
    CheckExternalEvents(cs7, 0x17F8);
    // CMP word ptr [BP + -0x1e],0xd (0FA1_17F4 / 0x11204)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1E)], 0xD);
    CheckExternalEvents(cs7, 0x17FA);
    // JGE 0x1000:124b (0FA1_17F8 / 0x11208)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_183B_1124B;
    }
    CheckExternalEvents(cs7, 0x17FD);
    // MOV SI,word ptr [BP + -0x18] (0FA1_17FA / 0x1120A)
    SI = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x1800);
    // ADD SI,word ptr [BP + -0x1e] (0FA1_17FD / 0x1120D)
    SI += UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs7, 0x1802);
    // SHL SI,0x1 (0FA1_1800 / 0x11210)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x1806);
    // MOV ES,word ptr [0x5592] (0FA1_1802 / 0x11212)
    ES = UInt16[DS, 0x5592];
    CheckExternalEvents(cs7, 0x180B);
    // MOV AX,word ptr ES:[SI + 0x4004] (0FA1_1806 / 0x11216)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs7, 0x180F);
    // MOV ES,word ptr [0x5582] (0FA1_180B / 0x1121B)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x1813);
    // MOV ES:[0xa44b],AX (0FA1_180F / 0x1121F)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs7, 0x1817);
    // MOV ES,word ptr [0x5590] (0FA1_1813 / 0x11223)
    ES = UInt16[DS, 0x5590];
    CheckExternalEvents(cs7, 0x181C);
    // MOV AX,word ptr ES:[SI + 0x4036] (0FA1_1817 / 0x11227)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs7, 0x1820);
    // MOV ES,word ptr [0x5584] (0FA1_181C / 0x1122C)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs7, 0x1824);
    // MOV ES:[0xa44d],AX (0FA1_1820 / 0x11230)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs7, 0x1827);
    // CMP word ptr [BP + -0xa],AX (0FA1_1824 / 0x11234)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], AX);
    CheckExternalEvents(cs7, 0x1829);
    // JNZ 0x1000:11f1 (0FA1_1827 / 0x11237)
    if(!ZeroFlag) {
      goto label_0FA1_17E1_111F1;
    }
    CheckExternalEvents(cs7, 0x182D);
    // MOV ES,word ptr [0x5582] (0FA1_1829 / 0x11239)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x1831);
    // MOV AX,ES:[0xa44b] (0FA1_182D / 0x1123D)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x1834);
    // CMP word ptr [BP + -0x4],AX (0FA1_1831 / 0x11241)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs7, 0x1836);
    // JZ 0x1000:1249 (0FA1_1834 / 0x11244)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs7, 0x183B);
      // JMP 0x1000:11ec (0FA1_1839 / 0x11249)
      goto label_0FA1_17DC_111EC;
    }
    CheckExternalEvents(cs7, 0x1839);
    // JMP 0x1000:11b4 (0FA1_1836 / 0x11246)
    goto label_0FA1_17A4_111B4;
    label_0FA1_1839_11249:
    CheckExternalEvents(cs7, 0x183B);
    // JMP 0x1000:11ec (0FA1_1839 / 0x11249)
    goto label_0FA1_17DC_111EC;
    label_0FA1_183B_1124B:
    CheckExternalEvents(cs7, 0x183E);
    // INC word ptr [BP + -0x18] (0FA1_183B / 0x1124B)
    UInt16[SS, (ushort)(BP - 0x18)]++;
    label_0FA1_183E_1124E:
    CheckExternalEvents(cs7, 0x1842);
    // CMP word ptr [BP + -0x18],0x4 (0FA1_183E / 0x1124E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0x4);
    CheckExternalEvents(cs7, 0x1844);
    // JGE 0x1000:125b (0FA1_1842 / 0x11252)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_184B_1125B;
    }
    CheckExternalEvents(cs7, 0x1849);
    // MOV word ptr [BP + -0x1e],0x0 (0FA1_1844 / 0x11254)
    UInt16[SS, (ushort)(BP - 0x1E)] = 0x0;
    CheckExternalEvents(cs7, 0x184B);
    // JMP 0x1000:1204 (0FA1_1849 / 0x11259)
    goto label_0FA1_17F4_11204;
    label_0FA1_184B_1125B:
    CheckExternalEvents(cs7, 0x184F);
    // MOV ES,word ptr [0x5582] (0FA1_184B / 0x1125B)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x1852);
    // MOV AX,word ptr [BP + -0x4] (0FA1_184F / 0x1125F)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x1856);
    // MOV ES:[0xa44b],AX (0FA1_1852 / 0x11262)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs7, 0x185A);
    // MOV ES,word ptr [0x5584] (0FA1_1856 / 0x11266)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs7, 0x185D);
    // MOV AX,word ptr [BP + -0xa] (0FA1_185A / 0x1126A)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x1861);
    // MOV ES:[0xa44d],AX (0FA1_185D / 0x1126D)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs7, 0x1864);
    // JMP 0x1000:154b (0FA1_1861 / 0x11271)
    goto label_0FA1_1B3B_1154B;
    label_0FA1_1864_11274:
    CheckExternalEvents(cs7, 0x1868);
    // MOV ES,word ptr [0x5582] (0FA1_1864 / 0x11274)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x186C);
    // MOV AX,ES:[0xa44b] (0FA1_1868 / 0x11278)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x186D);
    // INC AX (0FA1_186C / 0x1127C)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs7, 0x1870);
    // MOV word ptr [BP + -0x1c],AX (0FA1_186D / 0x1127D)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs7, 0x1874);
    // TEST byte ptr [BP + -0x1c],0x80 (0FA1_1870 / 0x11280)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x1C)], 0x80);
    CheckExternalEvents(cs7, 0x1876);
    // JZ 0x1000:128b (0FA1_1874 / 0x11284)
    if(ZeroFlag) {
      goto label_0FA1_187B_1128B;
    }
    CheckExternalEvents(cs7, 0x187B);
    // ADD word ptr [BP + -0x1c],0x80 (0FA1_1876 / 0x11286)
    // UInt16[SS, (ushort)(BP - 0x1C)] += 0x80;
    UInt16[SS, (ushort)(BP - 0x1C)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x1C)], 0x80);
    label_0FA1_187B_1128B:
    CheckExternalEvents(cs7, 0x187E);
    // MOV AX,word ptr [BP + -0x1c] (0FA1_187B / 0x1128B)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs7, 0x1881);
    // AND AX,0xf00 (0FA1_187E / 0x1128E)
    AX &= 0xF00;
    CheckExternalEvents(cs7, 0x1883);
    // SHR AX,0x1 (0FA1_1881 / 0x11291)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs7, 0x1886);
    // MOV CX,word ptr [BP + -0x1c] (0FA1_1883 / 0x11293)
    CX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs7, 0x1889);
    // AND CX,0x7f (0FA1_1886 / 0x11296)
    // CX &= 0x7F;
    CX = Alu16.And(CX, 0x7F);
    CheckExternalEvents(cs7, 0x188B);
    // OR AX,CX (0FA1_1889 / 0x11299)
    // AX |= CX;
    AX = Alu16.Or(AX, CX);
    CheckExternalEvents(cs7, 0x188E);
    // MOV word ptr [BP + -0x1c],AX (0FA1_188B / 0x1129B)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs7, 0x1893);
    // MOV word ptr [BP + -0x18],0x0 (0FA1_188E / 0x1129E)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x0;
    CheckExternalEvents(cs7, 0x1896);
    // JMP 0x1000:132e (0FA1_1893 / 0x112A3)
    goto label_0FA1_191E_1132E;
    label_0FA1_1896_112A6:
    CheckExternalEvents(cs7, 0x189A);
    // ADD word ptr [BP + -0x1e],0xc (0FA1_1896 / 0x112A6)
    UInt16[SS, (ushort)(BP - 0x1E)] += 0xC;
    label_0FA1_189A_112AA:
    CheckExternalEvents(cs7, 0x189E);
    // CMP word ptr [BP + -0x1e],0xd (0FA1_189A / 0x112AA)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1E)], 0xD);
    CheckExternalEvents(cs7, 0x18A0);
    // JGE 0x1000:132b (0FA1_189E / 0x112AE)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_191B_1132B;
    }
    CheckExternalEvents(cs7, 0x18A3);
    // MOV SI,word ptr [BP + -0x18] (0FA1_18A0 / 0x112B0)
    SI = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x18A6);
    // ADD SI,word ptr [BP + -0x1e] (0FA1_18A3 / 0x112B3)
    // SI += UInt16[SS, (ushort)(BP - 0x1E)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs7, 0x18A8);
    // MOV DI,SI (0FA1_18A6 / 0x112B6)
    DI = SI;
    CheckExternalEvents(cs7, 0x18AA);
    // SHL DI,0x1 (0FA1_18A8 / 0x112B8)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs7, 0x18AE);
    // MOV ES,word ptr [0x559a] (0FA1_18AA / 0x112BA)
    ES = UInt16[DS, 0x559A];
    CheckExternalEvents(cs7, 0x18B4);
    // CMP word ptr ES:[DI + 0x406a],0x0 (0FA1_18AE / 0x112BE)
    Alu16.Sub(UInt16[ES, (ushort)(DI + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x18B6);
    // JZ 0x1000:12a6 (0FA1_18B4 / 0x112C4)
    if(ZeroFlag) {
      goto label_0FA1_1896_112A6;
    }
    CheckExternalEvents(cs7, 0x18B9);
    // CMP word ptr [BP + 0x6],SI (0FA1_18B6 / 0x112C6)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], SI);
    CheckExternalEvents(cs7, 0x18BB);
    // JZ 0x1000:12a6 (0FA1_18B9 / 0x112C9)
    if(ZeroFlag) {
      goto label_0FA1_1896_112A6;
    }
    CheckExternalEvents(cs7, 0x18BF);
    // MOV ES,word ptr [0x5584] (0FA1_18BB / 0x112CB)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs7, 0x18C3);
    // MOV AX,ES:[0xa44d] (0FA1_18BF / 0x112CF)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x18C7);
    // MOV ES,word ptr [0x5590] (0FA1_18C3 / 0x112D3)
    ES = UInt16[DS, 0x5590];
    CheckExternalEvents(cs7, 0x18CC);
    // CMP word ptr ES:[DI + 0x4036],AX (0FA1_18C7 / 0x112D7)
    Alu16.Sub(UInt16[ES, (ushort)(DI + 0x4036)], AX);
    CheckExternalEvents(cs7, 0x18CE);
    // JNZ 0x1000:12a6 (0FA1_18CC / 0x112DC)
    if(!ZeroFlag) {
      goto label_0FA1_1896_112A6;
    }
    CheckExternalEvents(cs7, 0x18D2);
    // MOV ES,word ptr [0x5592] (0FA1_18CE / 0x112DE)
    ES = UInt16[DS, 0x5592];
    CheckExternalEvents(cs7, 0x18D7);
    // MOV AX,word ptr ES:[DI + 0x4004] (0FA1_18D2 / 0x112E2)
    AX = UInt16[ES, (ushort)(DI + 0x4004)];
    CheckExternalEvents(cs7, 0x18D8);
    // INC AX (0FA1_18D7 / 0x112E7)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs7, 0x18DB);
    // MOV word ptr [BP + -0x8],AX (0FA1_18D8 / 0x112E8)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0x18DF);
    // TEST byte ptr [BP + -0x8],0x80 (0FA1_18DB / 0x112EB)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x8)], 0x80);
    CheckExternalEvents(cs7, 0x18E1);
    // JZ 0x1000:12f6 (0FA1_18DF / 0x112EF)
    if(ZeroFlag) {
      goto label_0FA1_18E6_112F6;
    }
    CheckExternalEvents(cs7, 0x18E6);
    // ADD word ptr [BP + -0x8],0x80 (0FA1_18E1 / 0x112F1)
    // UInt16[SS, (ushort)(BP - 0x8)] += 0x80;
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x8)], 0x80);
    label_0FA1_18E6_112F6:
    CheckExternalEvents(cs7, 0x18E9);
    // MOV AX,word ptr [BP + -0x8] (0FA1_18E6 / 0x112F6)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x18EC);
    // AND AX,0xf00 (0FA1_18E9 / 0x112F9)
    AX &= 0xF00;
    CheckExternalEvents(cs7, 0x18EE);
    // SHR AX,0x1 (0FA1_18EC / 0x112FC)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs7, 0x18F1);
    // MOV CX,word ptr [BP + -0x8] (0FA1_18EE / 0x112FE)
    CX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x18F4);
    // AND CX,0x7f (0FA1_18F1 / 0x11301)
    // CX &= 0x7F;
    CX = Alu16.And(CX, 0x7F);
    CheckExternalEvents(cs7, 0x18F6);
    // OR AX,CX (0FA1_18F4 / 0x11304)
    // AX |= CX;
    AX = Alu16.Or(AX, CX);
    CheckExternalEvents(cs7, 0x18F9);
    // MOV word ptr [BP + -0x8],AX (0FA1_18F6 / 0x11306)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0x18FC);
    // SUB AX,word ptr [BP + -0x1c] (0FA1_18F9 / 0x11309)
    // AX -= UInt16[SS, (ushort)(BP - 0x1C)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x1C)]);
    CheckExternalEvents(cs7, 0x18FD);
    // PUSH AX (0FA1_18FC / 0x1130C)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x1902);
    // CALLF 0x1000:db5c (0FA1_18FD / 0x1130D)
    FarCall(cs7, 0x1902, ghidra_guess_1000_DB5C_1DB5C);
    CheckExternalEvents(cs7, 0x1905);
    // ADD SP,0x2 (0FA1_1902 / 0x11312)
    SP += 0x2;
    CheckExternalEvents(cs7, 0x1908);
    // CMP AX,0x3 (0FA1_1905 / 0x11315)
    Alu16.Sub(AX, 0x3);
    CheckExternalEvents(cs7, 0x190A);
    // JGE 0x1000:12a6 (0FA1_1908 / 0x11318)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_1896_112A6;
    }
    CheckExternalEvents(cs7, 0x190F);
    // MOV word ptr [BP + -0x6],0x1 (0FA1_190A / 0x1131A)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    CheckExternalEvents(cs7, 0x1912);
    // MOV AX,0xd (0FA1_190F / 0x1131F)
    AX = 0xD;
    CheckExternalEvents(cs7, 0x1915);
    // MOV word ptr [BP + -0x1e],AX (0FA1_1912 / 0x11322)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs7, 0x1918);
    // MOV word ptr [BP + -0x18],AX (0FA1_1915 / 0x11325)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs7, 0x191B);
    // JMP 0x1000:12a6 (0FA1_1918 / 0x11328)
    goto label_0FA1_1896_112A6;
    label_0FA1_191B_1132B:
    CheckExternalEvents(cs7, 0x191E);
    // INC word ptr [BP + -0x18] (0FA1_191B / 0x1132B)
    UInt16[SS, (ushort)(BP - 0x18)]++;
    label_0FA1_191E_1132E:
    CheckExternalEvents(cs7, 0x1922);
    // CMP word ptr [BP + -0x18],0x4 (0FA1_191E / 0x1132E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0x4);
    CheckExternalEvents(cs7, 0x1924);
    // JGE 0x1000:133c (0FA1_1922 / 0x11332)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_192C_1133C;
    }
    CheckExternalEvents(cs7, 0x1929);
    // MOV word ptr [BP + -0x1e],0x0 (0FA1_1924 / 0x11334)
    UInt16[SS, (ushort)(BP - 0x1E)] = 0x0;
    CheckExternalEvents(cs7, 0x192C);
    // JMP 0x1000:12aa (0FA1_1929 / 0x11339)
    goto label_0FA1_189A_112AA;
    label_0FA1_192C_1133C:
    CheckExternalEvents(cs7, 0x1931);
    // MOV word ptr [BP + -0x10],0x4 (0FA1_192C / 0x1133C)
    UInt16[SS, (ushort)(BP - 0x10)] = 0x4;
    CheckExternalEvents(cs7, 0x1935);
    // CMP word ptr [BP + 0x6],0xc (0FA1_1931 / 0x11341)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs7, 0x1937);
    // JL 0x1000:134c (0FA1_1935 / 0x11345)
    if(SignFlag != OverflowFlag) {
      goto label_0FA1_193C_1134C;
    }
    CheckExternalEvents(cs7, 0x193C);
    // MOV word ptr [BP + -0x10],0x10 (0FA1_1937 / 0x11347)
    UInt16[SS, (ushort)(BP - 0x10)] = 0x10;
    label_0FA1_193C_1134C:
    CheckExternalEvents(cs7, 0x193F);
    // DEC word ptr [BP + -0x1c] (0FA1_193C / 0x1134C)
    UInt16[SS, (ushort)(BP - 0x1C)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0x1C)]);
    CheckExternalEvents(cs7, 0x1942);
    // MOV AX,word ptr [BP + -0x10] (0FA1_193F / 0x1134F)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs7, 0x1945);
    // MOV word ptr [BP + -0x18],AX (0FA1_1942 / 0x11352)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs7, 0x1947);
    // JMP 0x1000:13bc (0FA1_1945 / 0x11355)
    goto label_0FA1_19AC_113BC;
    label_0FA1_1947_11357:
    CheckExternalEvents(cs7, 0x194A);
    // MOV SI,word ptr [BP + -0x18] (0FA1_1947 / 0x11357)
    SI = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x194C);
    // SHL SI,0x1 (0FA1_194A / 0x1135A)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x1950);
    // MOV ES,word ptr [0x559a] (0FA1_194C / 0x1135C)
    ES = UInt16[DS, 0x559A];
    CheckExternalEvents(cs7, 0x1956);
    // CMP word ptr ES:[SI + 0x406a],0x0 (0FA1_1950 / 0x11360)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x1958);
    // JZ 0x1000:13b9 (0FA1_1956 / 0x11366)
    if(ZeroFlag) {
      goto label_0FA1_19A9_113B9;
    }
    CheckExternalEvents(cs7, 0x195C);
    // MOV ES,word ptr [0x5584] (0FA1_1958 / 0x11368)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs7, 0x1960);
    // MOV AX,ES:[0xa44d] (0FA1_195C / 0x1136C)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x1964);
    // MOV ES,word ptr [0x5590] (0FA1_1960 / 0x11370)
    ES = UInt16[DS, 0x5590];
    CheckExternalEvents(cs7, 0x1969);
    // CMP word ptr ES:[SI + 0x4036],AX (0FA1_1964 / 0x11374)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4036)], AX);
    CheckExternalEvents(cs7, 0x196B);
    // JNZ 0x1000:13b9 (0FA1_1969 / 0x11379)
    if(!ZeroFlag) {
      goto label_0FA1_19A9_113B9;
    }
    CheckExternalEvents(cs7, 0x196F);
    // MOV ES,word ptr [0x5592] (0FA1_196B / 0x1137B)
    ES = UInt16[DS, 0x5592];
    CheckExternalEvents(cs7, 0x1974);
    // MOV AX,word ptr ES:[SI + 0x4004] (0FA1_196F / 0x1137F)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs7, 0x1977);
    // MOV word ptr [BP + -0x8],AX (0FA1_1974 / 0x11384)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0x197A);
    // AND AX,0xf00 (0FA1_1977 / 0x11387)
    AX &= 0xF00;
    CheckExternalEvents(cs7, 0x197C);
    // SHR AX,0x1 (0FA1_197A / 0x1138A)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs7, 0x197F);
    // MOV CX,word ptr [BP + -0x8] (0FA1_197C / 0x1138C)
    CX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x1982);
    // AND CX,0x7f (0FA1_197F / 0x1138F)
    // CX &= 0x7F;
    CX = Alu16.And(CX, 0x7F);
    CheckExternalEvents(cs7, 0x1984);
    // OR AX,CX (0FA1_1982 / 0x11392)
    // AX |= CX;
    AX = Alu16.Or(AX, CX);
    CheckExternalEvents(cs7, 0x1987);
    // MOV word ptr [BP + -0x8],AX (0FA1_1984 / 0x11394)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0x198A);
    // MOV AX,word ptr [BP + -0x1c] (0FA1_1987 / 0x11397)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs7, 0x198D);
    // SUB AX,word ptr [BP + -0x8] (0FA1_198A / 0x1139A)
    // AX -= UInt16[SS, (ushort)(BP - 0x8)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs7, 0x198E);
    // PUSH AX (0FA1_198D / 0x1139D)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x1993);
    // CALLF 0x1000:db5c (0FA1_198E / 0x1139E)
    FarCall(cs7, 0x1993, ghidra_guess_1000_DB5C_1DB5C);
    CheckExternalEvents(cs7, 0x1996);
    // ADD SP,0x2 (0FA1_1993 / 0x113A3)
    SP += 0x2;
    CheckExternalEvents(cs7, 0x1999);
    // CMP AX,0x2 (0FA1_1996 / 0x113A6)
    Alu16.Sub(AX, 0x2);
    CheckExternalEvents(cs7, 0x199B);
    // JGE 0x1000:13b9 (0FA1_1999 / 0x113A9)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_19A9_113B9;
    }
    CheckExternalEvents(cs7, 0x19A0);
    // MOV word ptr [BP + -0x6],0x1 (0FA1_199B / 0x113AB)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    CheckExternalEvents(cs7, 0x19A3);
    // MOV AX,word ptr [BP + -0x10] (0FA1_19A0 / 0x113B0)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs7, 0x19A6);
    // ADD AX,0x9 (0FA1_19A3 / 0x113B3)
    // AX += 0x9;
    AX = Alu16.Add(AX, 0x9);
    CheckExternalEvents(cs7, 0x19A9);
    // MOV word ptr [BP + -0x18],AX (0FA1_19A6 / 0x113B6)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    label_0FA1_19A9_113B9:
    CheckExternalEvents(cs7, 0x19AC);
    // INC word ptr [BP + -0x18] (0FA1_19A9 / 0x113B9)
    UInt16[SS, (ushort)(BP - 0x18)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x18)]);
    label_0FA1_19AC_113BC:
    CheckExternalEvents(cs7, 0x19AF);
    // MOV AX,word ptr [BP + -0x10] (0FA1_19AC / 0x113BC)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs7, 0x19B2);
    // ADD AX,0x8 (0FA1_19AF / 0x113BF)
    AX += 0x8;
    CheckExternalEvents(cs7, 0x19B5);
    // CMP AX,word ptr [BP + -0x18] (0FA1_19B2 / 0x113C2)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs7, 0x19B7);
    // JG 0x1000:1357 (0FA1_19B5 / 0x113C5)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0FA1_1947_11357;
    }
    CheckExternalEvents(cs7, 0x19BB);
    // CMP word ptr [BP + -0x6],0x0 (0FA1_19B7 / 0x113C7)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs7, 0x19BD);
    // JZ 0x1000:13d0 (0FA1_19BB / 0x113CB)
    if(ZeroFlag) {
      goto label_0FA1_19C0_113D0;
    }
    CheckExternalEvents(cs7, 0x19C0);
    // JMP 0x1000:154b (0FA1_19BD / 0x113CD)
    goto label_0FA1_1B3B_1154B;
    label_0FA1_19C0_113D0:
    CheckExternalEvents(cs7, 0x19C4);
    // CMP word ptr [BP + 0xc],0x0 (0FA1_19C0 / 0x113D0)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], 0x0);
    CheckExternalEvents(cs7, 0x19C6);
    // JNZ 0x1000:13d9 (0FA1_19C4 / 0x113D4)
    if(!ZeroFlag) {
      goto label_0FA1_19C9_113D9;
    }
    CheckExternalEvents(cs7, 0x19C9);
    // JMP 0x1000:154b (0FA1_19C6 / 0x113D6)
    goto label_0FA1_1B3B_1154B;
    label_0FA1_19C9_113D9:
    CheckExternalEvents(cs7, 0x19CD);
    // XOR byte ptr [BP + -0x10],0x14 (0FA1_19C9 / 0x113D9)
    // UInt8[SS, (ushort)(BP - 0x10)] ^= 0x14;
    UInt8[SS, (ushort)(BP - 0x10)] = Alu8.Xor(UInt8[SS, (ushort)(BP - 0x10)], 0x14);
    CheckExternalEvents(cs7, 0x19D0);
    // MOV AX,word ptr [BP + -0x10] (0FA1_19CD / 0x113DD)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs7, 0x19D3);
    // MOV word ptr [BP + -0x18],AX (0FA1_19D0 / 0x113E0)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs7, 0x19D6);
    // JMP 0x1000:14ba (0FA1_19D3 / 0x113E3)
    goto label_0FA1_1AAA_114BA;
    label_0FA1_19D6_113E6:
    CheckExternalEvents(cs7, 0x19D9);
    // MOV AX,0x11 (0FA1_19D6 / 0x113E6)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x19DC);
    // MUL word ptr [BP + -0x20] (0FA1_19D9 / 0x113E9)
    uint resMul0FA1_19D9 = Alu16.Mul(AX, UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resMul0FA1_19D9);
    DX = (ushort)(resMul0FA1_19D9 >> 16);
    CheckExternalEvents(cs7, 0x19DE);
    // MOV BX,AX (0FA1_19DC / 0x113EC)
    BX = AX;
    CheckExternalEvents(cs7, 0x19E2);
    // MOV ES,word ptr [0x558e] (0FA1_19DE / 0x113EE)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0x19E7);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0FA1_19E2 / 0x113F2)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs7, 0x19E8);
    // CBW  (0FA1_19E7 / 0x113F7)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x19EA);
    // MOV BX,AX (0FA1_19E8 / 0x113F8)
    BX = AX;
    CheckExternalEvents(cs7, 0x19EC);
    // SHL BX,0x1 (0FA1_19EA / 0x113FA)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x19EE);
    // SHL BX,0x1 (0FA1_19EC / 0x113FC)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x19F2);
    // MOV ES,word ptr [0x55b6] (0FA1_19EE / 0x113FE)
    ES = UInt16[DS, 0x55B6];
    CheckExternalEvents(cs7, 0x19F7);
    // PUSH word ptr ES:[BX + 0x1cc] (0FA1_19F2 / 0x11402)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs7, 0x19FC);
    // PUSH word ptr ES:[BX + 0x1ca] (0FA1_19F7 / 0x11407)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    label_0FA1_19FC_1140C:
    CheckExternalEvents(cs7, 0x19FD);
    // PUSH CS (0FA1_19FC / 0x1140C)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x1A00);
    // CALL 0x1000:17bb (0FA1_19FD / 0x1140D)
    NearCall(cs7, 0x1A00, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x1A03);
    // ADD SP,0x4 (0FA1_1A00 / 0x11410)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x1A06);
    // MOV AX,0x31a6 (0FA1_1A03 / 0x11413)
    AX = 0x31A6;
    CheckExternalEvents(cs7, 0x1A07);
    // PUSH DS (0FA1_1A06 / 0x11416)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x1A08);
    // PUSH AX (0FA1_1A07 / 0x11417)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x1A09);
    // PUSH CS (0FA1_1A08 / 0x11418)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x1A0C);
    // CALL 0x1000:17bb (0FA1_1A09 / 0x11419)
    NearCall(cs7, 0x1A0C, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x1A0F);
    // ADD SP,0x4 (0FA1_1A0C / 0x1141C)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x1A12);
    // MOV AX,0x12 (0FA1_1A0F / 0x1141F)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x1A13);
    // PUSH AX (0FA1_1A12 / 0x11422)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x1A18);
    // CALLF 0x0000:30bf (0FA1_1A13 / 0x11423)
    FarCall(cs7, 0x1A18, unknown_0170_19BF_030BF);
    CheckExternalEvents(cs7, 0x1A1B);
    // ADD SP,0x2 (0FA1_1A18 / 0x11428)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x1A1F);
    // MOV ES,word ptr [0x55b8] (0FA1_1A1B / 0x1142B)
    ES = UInt16[DS, 0x55B8];
    CheckExternalEvents(cs7, 0x1A25);
    // CMP word ptr ES:[0x15e],0x5 (0FA1_1A1F / 0x1142F)
    Alu16.Sub(UInt16[ES, 0x15E], 0x5);
    CheckExternalEvents(cs7, 0x1A27);
    // JGE 0x1000:1445 (0FA1_1A25 / 0x11435)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_1A35_11445;
    }
    CheckExternalEvents(cs7, 0x1A28);
    // PUSH CS (0FA1_1A27 / 0x11437)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x1A2B);
    // CALL 0x1000:17dc (0FA1_1A28 / 0x11438)
    NearCall(cs7, 0x1A2B, ghidra_guess_1000_17DC_117DC);
    CheckExternalEvents(cs7, 0x1A2F);
    // CMP word ptr [BP + -0x20],0x8 (0FA1_1A2B / 0x1143B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0x8);
    CheckExternalEvents(cs7, 0x1A31);
    // JNC 0x1000:1445 (0FA1_1A2F / 0x1143F)
    if(!CarryFlag) {
      goto label_0FA1_1A35_11445;
    }
    CheckExternalEvents(cs7, 0x1A32);
    // PUSH CS (0FA1_1A31 / 0x11441)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x1A35);
    // CALL 0x1000:17dc (0FA1_1A32 / 0x11442)
    NearCall(cs7, 0x1A35, ghidra_guess_1000_17DC_117DC);
    label_0FA1_1A35_11445:
    CheckExternalEvents(cs7, 0x1A38);
    // MOV SI,word ptr [BP + -0x18] (0FA1_1A35 / 0x11445)
    SI = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x1A3A);
    // SHL SI,0x1 (0FA1_1A38 / 0x11448)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x1A3E);
    // MOV ES,word ptr [0x5590] (0FA1_1A3A / 0x1144A)
    ES = UInt16[DS, 0x5590];
    CheckExternalEvents(cs7, 0x1A43);
    // PUSH word ptr ES:[SI + 0x4036] (0FA1_1A3E / 0x1144E)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs7, 0x1A47);
    // MOV ES,word ptr [0x5592] (0FA1_1A43 / 0x11453)
    ES = UInt16[DS, 0x5592];
    CheckExternalEvents(cs7, 0x1A4C);
    // PUSH word ptr ES:[SI + 0x4004] (0FA1_1A47 / 0x11457)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs7, 0x1A4F);
    // MOV AX,0x7e (0FA1_1A4C / 0x1145C)
    AX = 0x7E;
    CheckExternalEvents(cs7, 0x1A50);
    // PUSH AX (0FA1_1A4F / 0x1145F)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x1A55);
    // CALLF 0x1000:4279 (0FA1_1A50 / 0x11460)
    FarCall(cs7, 0x1A55, ghidra_guess_1000_4279_14279);
    CheckExternalEvents(cs7, 0x1A58);
    // ADD SP,0x6 (0FA1_1A55 / 0x11465)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs7, 0x1A5B);
    // MOV BX,word ptr [BP + -0x18] (0FA1_1A58 / 0x11468)
    BX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x1A5F);
    // MOV ES,word ptr [0x55ba] (0FA1_1A5B / 0x1146B)
    ES = UInt16[DS, 0x55BA];
    CheckExternalEvents(cs7, 0x1A65);
    // MOV byte ptr ES:[BX + 0x409a],0x7e (0FA1_1A5F / 0x1146F)
    UInt8[ES, (ushort)(BX + 0x409A)] = 0x7E;
    CheckExternalEvents(cs7, 0x1A68);
    // MOV BX,word ptr [BP + -0x18] (0FA1_1A65 / 0x11475)
    BX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x1A6C);
    // MOV ES,word ptr [0x55ae] (0FA1_1A68 / 0x11478)
    ES = UInt16[DS, 0x55AE];
    CheckExternalEvents(cs7, 0x1A72);
    // MOV byte ptr ES:[BX + 0xd55e],0x0 (0FA1_1A6C / 0x1147C)
    UInt8[ES, (ushort)(BX + 0xD55E)] = 0x0;
    CheckExternalEvents(cs7, 0x1A75);
    // MOV AX,0x11 (0FA1_1A72 / 0x11482)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x1A78);
    // MUL word ptr [BP + -0x20] (0FA1_1A75 / 0x11485)
    uint resMul0FA1_1A75 = Alu16.Mul(AX, UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resMul0FA1_1A75);
    DX = (ushort)(resMul0FA1_1A75 >> 16);
    CheckExternalEvents(cs7, 0x1A7A);
    // MOV SI,AX (0FA1_1A78 / 0x11488)
    SI = AX;
    CheckExternalEvents(cs7, 0x1A7C);
    // SUB AX,AX (0FA1_1A7A / 0x1148A)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x1A7F);
    // MOV BX,word ptr [BP + -0x18] (0FA1_1A7C / 0x1148C)
    BX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x1A81);
    // SHL BX,0x1 (0FA1_1A7F / 0x1148F)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x1A85);
    // MOV ES,word ptr [0x559a] (0FA1_1A81 / 0x11491)
    ES = UInt16[DS, 0x559A];
    CheckExternalEvents(cs7, 0x1A8A);
    // MOV word ptr ES:[BX + 0x406a],AX (0FA1_1A85 / 0x11495)
    UInt16[ES, (ushort)(BX + 0x406A)] = AX;
    CheckExternalEvents(cs7, 0x1A8E);
    // MOV ES,word ptr [0x558e] (0FA1_1A8A / 0x1149A)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0x1A93);
    // MOV byte ptr ES:[SI + 0xc623],AL (0FA1_1A8E / 0x1149E)
    UInt8[ES, (ushort)(SI + 0xC623)] = AL;
    CheckExternalEvents(cs7, 0x1A99);
    // MOV byte ptr ES:[SI + 0xc614],0xff (0FA1_1A93 / 0x114A3)
    UInt8[ES, (ushort)(SI + 0xC614)] = 0xFF;
    CheckExternalEvents(cs7, 0x1A9D);
    // CMP word ptr [BP + -0x20],0x2 (0FA1_1A99 / 0x114A9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0x2);
    CheckExternalEvents(cs7, 0x1A9F);
    // JNC 0x1000:14b7 (0FA1_1A9D / 0x114AD)
    if(!CarryFlag) {
      goto label_0FA1_1AA7_114B7;
    }
    CheckExternalEvents(cs7, 0x1AA3);
    // MOV ES,word ptr [0x55bc] (0FA1_1A9F / 0x114AF)
    ES = UInt16[DS, 0x55BC];
    CheckExternalEvents(cs7, 0x1AA7);
    // MOV ES:[0x14a],AX (0FA1_1AA3 / 0x114B3)
    UInt16[ES, 0x14A] = AX;
    label_0FA1_1AA7_114B7:
    CheckExternalEvents(cs7, 0x1AAA);
    // INC word ptr [BP + -0x18] (0FA1_1AA7 / 0x114B7)
    UInt16[SS, (ushort)(BP - 0x18)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x18)]);
    label_0FA1_1AAA_114BA:
    CheckExternalEvents(cs7, 0x1AAD);
    // MOV AX,word ptr [BP + -0x10] (0FA1_1AAA / 0x114BA)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs7, 0x1AB0);
    // ADD AX,0x8 (0FA1_1AAD / 0x114BD)
    AX += 0x8;
    CheckExternalEvents(cs7, 0x1AB3);
    // CMP AX,word ptr [BP + -0x18] (0FA1_1AB0 / 0x114C0)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs7, 0x1AB5);
    // JG 0x1000:14c8 (0FA1_1AB3 / 0x114C3)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0FA1_1AB8_114C8;
    }
    CheckExternalEvents(cs7, 0x1AB8);
    // JMP 0x1000:154b (0FA1_1AB5 / 0x114C5)
    goto label_0FA1_1B3B_1154B;
    label_0FA1_1AB8_114C8:
    CheckExternalEvents(cs7, 0x1ABB);
    // MOV SI,word ptr [BP + -0x18] (0FA1_1AB8 / 0x114C8)
    SI = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x1ABD);
    // SHL SI,0x1 (0FA1_1ABB / 0x114CB)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x1AC1);
    // MOV ES,word ptr [0x559a] (0FA1_1ABD / 0x114CD)
    ES = UInt16[DS, 0x559A];
    CheckExternalEvents(cs7, 0x1AC7);
    // CMP word ptr ES:[SI + 0x406a],0x0 (0FA1_1AC1 / 0x114D1)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x1AC9);
    // JZ 0x1000:14b7 (0FA1_1AC7 / 0x114D7)
    if(ZeroFlag) {
      goto label_0FA1_1AA7_114B7;
    }
    CheckExternalEvents(cs7, 0x1ACD);
    // MOV ES,word ptr [0x5584] (0FA1_1AC9 / 0x114D9)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs7, 0x1AD1);
    // MOV AX,ES:[0xa44d] (0FA1_1ACD / 0x114DD)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x1AD5);
    // MOV ES,word ptr [0x5590] (0FA1_1AD1 / 0x114E1)
    ES = UInt16[DS, 0x5590];
    CheckExternalEvents(cs7, 0x1ADA);
    // CMP word ptr ES:[SI + 0x4036],AX (0FA1_1AD5 / 0x114E5)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4036)], AX);
    CheckExternalEvents(cs7, 0x1ADC);
    // JNZ 0x1000:14b7 (0FA1_1ADA / 0x114EA)
    if(!ZeroFlag) {
      goto label_0FA1_1AA7_114B7;
    }
    CheckExternalEvents(cs7, 0x1AE0);
    // MOV ES,word ptr [0x5592] (0FA1_1ADC / 0x114EC)
    ES = UInt16[DS, 0x5592];
    CheckExternalEvents(cs7, 0x1AE5);
    // MOV AX,word ptr ES:[SI + 0x4004] (0FA1_1AE0 / 0x114F0)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs7, 0x1AE8);
    // MOV word ptr [BP + -0x8],AX (0FA1_1AE5 / 0x114F5)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0x1AEB);
    // AND AX,0xf00 (0FA1_1AE8 / 0x114F8)
    AX &= 0xF00;
    CheckExternalEvents(cs7, 0x1AED);
    // SHR AX,0x1 (0FA1_1AEB / 0x114FB)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs7, 0x1AF0);
    // MOV CX,word ptr [BP + -0x8] (0FA1_1AED / 0x114FD)
    CX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x1AF3);
    // AND CX,0x7f (0FA1_1AF0 / 0x11500)
    // CX &= 0x7F;
    CX = Alu16.And(CX, 0x7F);
    CheckExternalEvents(cs7, 0x1AF5);
    // OR AX,CX (0FA1_1AF3 / 0x11503)
    // AX |= CX;
    AX = Alu16.Or(AX, CX);
    CheckExternalEvents(cs7, 0x1AF8);
    // MOV word ptr [BP + -0x8],AX (0FA1_1AF5 / 0x11505)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0x1AFB);
    // MOV AX,word ptr [BP + -0x1c] (0FA1_1AF8 / 0x11508)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs7, 0x1AFE);
    // SUB AX,word ptr [BP + -0x8] (0FA1_1AFB / 0x1150B)
    // AX -= UInt16[SS, (ushort)(BP - 0x8)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs7, 0x1AFF);
    // PUSH AX (0FA1_1AFE / 0x1150E)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x1B04);
    // CALLF 0x1000:db5c (0FA1_1AFF / 0x1150F)
    FarCall(cs7, 0x1B04, ghidra_guess_1000_DB5C_1DB5C);
    CheckExternalEvents(cs7, 0x1B07);
    // ADD SP,0x2 (0FA1_1B04 / 0x11514)
    SP += 0x2;
    CheckExternalEvents(cs7, 0x1B0A);
    // CMP AX,0x2 (0FA1_1B07 / 0x11517)
    Alu16.Sub(AX, 0x2);
    CheckExternalEvents(cs7, 0x1B0C);
    // JGE 0x1000:14b7 (0FA1_1B0A / 0x1151A)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_1AA7_114B7;
    }
    CheckExternalEvents(cs7, 0x1B0F);
    // MOV AX,word ptr [BP + -0x18] (0FA1_1B0C / 0x1151C)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x1B12);
    // SUB AX,0x4 (0FA1_1B0F / 0x1151F)
    // AX -= 0x4;
    AX = Alu16.Sub(AX, 0x4);
    CheckExternalEvents(cs7, 0x1B15);
    // MOV word ptr [BP + -0x20],AX (0FA1_1B12 / 0x11522)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    CheckExternalEvents(cs7, 0x1B18);
    // MOV AX,0x4 (0FA1_1B15 / 0x11525)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x1B19);
    // PUSH AX (0FA1_1B18 / 0x11528)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x1B1E);
    // CALLF 0x1000:7ee1 (0FA1_1B19 / 0x11529)
    FarCall(cs7, 0x1B1E, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x1B21);
    // ADD SP,0x2 (0FA1_1B1E / 0x1152E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x1B26);
    // CALLF 0x1000:7fe8 (0FA1_1B21 / 0x11531)
    FarCall(cs7, 0x1B26, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x1B2A);
    // CMP word ptr [BP + -0x20],0xc (0FA1_1B26 / 0x11536)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0xC);
    CheckExternalEvents(cs7, 0x1B2C);
    // JNC 0x1000:153f (0FA1_1B2A / 0x1153A)
    if(!CarryFlag) {
      goto label_0FA1_1B2F_1153F;
    }
    CheckExternalEvents(cs7, 0x1B2F);
    // JMP 0x1000:13e6 (0FA1_1B2C / 0x1153C)
    goto label_0FA1_19D6_113E6;
    label_0FA1_1B2F_1153F:
    CheckExternalEvents(cs7, 0x1B33);
    // SUB word ptr [BP + -0x20],0x4 (0FA1_1B2F / 0x1153F)
    // UInt16[SS, (ushort)(BP - 0x20)] -= 0x4;
    UInt16[SS, (ushort)(BP - 0x20)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0x4);
    CheckExternalEvents(cs7, 0x1B36);
    // MOV AX,0x319a (0FA1_1B33 / 0x11543)
    AX = 0x319A;
    CheckExternalEvents(cs7, 0x1B37);
    // PUSH DS (0FA1_1B36 / 0x11546)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x1B38);
    // PUSH AX (0FA1_1B37 / 0x11547)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x1B3B);
    // JMP 0x1000:140c (0FA1_1B38 / 0x11548)
    goto label_0FA1_19FC_1140C;
    label_0FA1_1B3B_1154B:
    CheckExternalEvents(cs7, 0x1B3E);
    // MOV AX,word ptr [BP + -0x6] (0FA1_1B3B / 0x1154B)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs7, 0x1B3F);
    // POP SI (0FA1_1B3E / 0x1154E)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x1B40);
    // POP DI (0FA1_1B3F / 0x1154F)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x1B42);
    // MOV SP,BP (0FA1_1B40 / 0x11550)
    SP = BP;
    CheckExternalEvents(cs7, 0x1B43);
    // POP BP (0FA1_1B42 / 0x11552)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x1B44);
    // RETF  (0FA1_1B43 / 0x11553)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_1554_11554(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1554_11554:
    CheckExternalEvents(cs8, 0x1555);
    // PUSH BP (1000_1554 / 0x11554)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x1557);
    // MOV BP,SP (1000_1555 / 0x11555)
    BP = SP;
    CheckExternalEvents(cs8, 0x155A);
    // MOV AX,0x4 (1000_1557 / 0x11557)
    AX = 0x4;
    CheckExternalEvents(cs8, 0x155F);
    // CALLF 0x1000:cecc (1000_155A / 0x1155A)
    FarCall(cs8, 0x155F, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x1562);
    // MOV AX,0x7d (1000_155F / 0x1155F)
    AX = 0x7D;
    CheckExternalEvents(cs8, 0x1565);
    // IMUL word ptr [BP + 0x6] (1000_1562 / 0x11562)
    int resImul1000_1562 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_1562);
    DX = (ushort)(resImul1000_1562 >> 16);
    CheckExternalEvents(cs8, 0x1567);
    // MOV BX,AX (1000_1565 / 0x11565)
    BX = AX;
    CheckExternalEvents(cs8, 0x156A);
    // ADD BX,word ptr [BP + 0x8] (1000_1567 / 0x11567)
    // BX += UInt16[SS, (ushort)(BP + 0x8)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs8, 0x156E);
    // MOV ES,word ptr [0x558e] (1000_156A / 0x1156A)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs8, 0x1573);
    // MOV AL,byte ptr ES:[BX + 0xc724] (1000_156E / 0x1156E)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs8, 0x1575);
    // SUB AH,AH (1000_1573 / 0x11573)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs8, 0x1578);
    // MOV word ptr [BP + -0x2],AX (1000_1575 / 0x11575)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs8, 0x157D);
    // MOV word ptr [BP + -0x4],0x0 (1000_1578 / 0x11578)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs8, 0x1581);
    // TEST byte ptr [BP + -0x2],0x4 (1000_157D / 0x1157D)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs8, 0x1583);
    // JNZ 0x1000:1586 (1000_1581 / 0x11581)
    if(!ZeroFlag) {
      goto label_1000_1586_11586;
    }
    CheckExternalEvents(cs8, 0x1586);
    // INC word ptr [BP + -0x4] (1000_1583 / 0x11583)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_1000_1586_11586:
    CheckExternalEvents(cs8, 0x158A);
    // TEST byte ptr [BP + -0x2],0x2 (1000_1586 / 0x11586)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x2)], 0x2);
    CheckExternalEvents(cs8, 0x158C);
    // JNZ 0x1000:158f (1000_158A / 0x1158A)
    if(!ZeroFlag) {
      goto label_1000_158F_1158F;
    }
    CheckExternalEvents(cs8, 0x158F);
    // INC word ptr [BP + -0x4] (1000_158C / 0x1158C)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_1000_158F_1158F:
    CheckExternalEvents(cs8, 0x1593);
    // TEST byte ptr [BP + -0x2],0x1 (1000_158F / 0x1158F)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x2)], 0x1);
    CheckExternalEvents(cs8, 0x1595);
    // JNZ 0x1000:1598 (1000_1593 / 0x11593)
    if(!ZeroFlag) {
      goto label_1000_1598_11598;
    }
    CheckExternalEvents(cs8, 0x1598);
    // INC word ptr [BP + -0x4] (1000_1595 / 0x11595)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1000_1598_11598:
    CheckExternalEvents(cs8, 0x159B);
    // MOV AX,word ptr [BP + -0x4] (1000_1598 / 0x11598)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs8, 0x159D);
    // MOV SP,BP (1000_159B / 0x1159B)
    SP = BP;
    CheckExternalEvents(cs8, 0x159E);
    // POP BP (1000_159D / 0x1159D)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x159F);
    // RETF  (1000_159E / 0x1159E)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_159F_1159F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_159F_1159F:
    CheckExternalEvents(cs8, 0x15A0);
    // PUSH BP (1000_159F / 0x1159F)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x15A2);
    // MOV BP,SP (1000_15A0 / 0x115A0)
    BP = SP;
    CheckExternalEvents(cs8, 0x15A5);
    // MOV AX,0x2 (1000_15A2 / 0x115A2)
    AX = 0x2;
    CheckExternalEvents(cs8, 0x15AA);
    // CALLF 0x1000:cecc (1000_15A5 / 0x115A5)
    FarCall(cs8, 0x15AA, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x15AF);
    // MOV word ptr [BP + -0x2],0x0 (1000_15AA / 0x115AA)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_1000_15AF_115AF:
    CheckExternalEvents(cs8, 0x15B2);
    // MOV BX,word ptr [BP + -0x2] (1000_15AF / 0x115AF)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x15B6);
    // MOV AL,byte ptr [BX + 0x3242] (1000_15B2 / 0x115B2)
    AL = UInt8[DS, (ushort)(BX + 0x3242)];
    CheckExternalEvents(cs8, 0x15B7);
    // CBW  (1000_15B6 / 0x115B6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x15BA);
    // CMP AX,word ptr [BP + 0x6] (1000_15B7 / 0x115B7)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs8, 0x15BC);
    // JNZ 0x1000:1601 (1000_15BA / 0x115BA)
    if(!ZeroFlag) {
      goto label_1000_1601_11601;
    }
    CheckExternalEvents(cs8, 0x15BE);
    // SHL BX,0x1 (1000_15BC / 0x115BC)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x15C0);
    // SHL BX,0x1 (1000_15BE / 0x115BE)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x15C4);
    // PUSH word ptr [BX + 0x3250] (1000_15C0 / 0x115C0)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x3250)]);
    CheckExternalEvents(cs8, 0x15C8);
    // PUSH word ptr [BX + 0x324e] (1000_15C4 / 0x115C4)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x324E)]);
    CheckExternalEvents(cs8, 0x15CB);
    // MOV AX,0x12 (1000_15C8 / 0x115C8)
    AX = 0x12;
    CheckExternalEvents(cs8, 0x15CE);
    // MOV DX,0x2a02 (1000_15CB / 0x115CB)
    DX = 0x2A02;
    CheckExternalEvents(cs8, 0x15CF);
    // PUSH DX (1000_15CE / 0x115CE)
    Stack.Push16(DX);
    CheckExternalEvents(cs8, 0x15D0);
    // PUSH AX (1000_15CF / 0x115CF)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x15D5);
    // CALLF 0x1000:da58 (1000_15D0 / 0x115D0)
    FarCall(cs8, 0x15D5, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs8, 0x15D8);
    // ADD SP,0x8 (1000_15D5 / 0x115D5)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs8, 0x15DB);
    // MOV AX,0x3240 (1000_15D8 / 0x115D8)
    AX = 0x3240;
    CheckExternalEvents(cs8, 0x15DC);
    // PUSH DS (1000_15DB / 0x115DB)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x15DD);
    // PUSH AX (1000_15DC / 0x115DC)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x15E0);
    // MOV AX,0x12 (1000_15DD / 0x115DD)
    AX = 0x12;
    CheckExternalEvents(cs8, 0x15E3);
    // MOV DX,0x2a02 (1000_15E0 / 0x115E0)
    DX = 0x2A02;
    CheckExternalEvents(cs8, 0x15E4);
    // PUSH DX (1000_15E3 / 0x115E3)
    Stack.Push16(DX);
    CheckExternalEvents(cs8, 0x15E5);
    // PUSH AX (1000_15E4 / 0x115E4)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x15EA);
    // CALLF 0x1000:da12 (1000_15E5 / 0x115E5)
    FarCall(cs8, 0x15EA, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs8, 0x15ED);
    // ADD SP,0x8 (1000_15EA / 0x115EA)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs8, 0x15F0);
    // MOV AX,0x12 (1000_15ED / 0x115ED)
    AX = 0x12;
    CheckExternalEvents(cs8, 0x15F3);
    // MOV DX,0x2a02 (1000_15F0 / 0x115F0)
    DX = 0x2A02;
    CheckExternalEvents(cs8, 0x15F4);
    // PUSH DX (1000_15F3 / 0x115F3)
    Stack.Push16(DX);
    CheckExternalEvents(cs8, 0x15F5);
    // PUSH AX (1000_15F4 / 0x115F4)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x15F6);
    // PUSH CS (1000_15F5 / 0x115F5)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x15F9);
    // CALL 0x1000:17bb (1000_15F6 / 0x115F6)
    NearCall(cs8, 0x15F9, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs8, 0x15FC);
    // ADD SP,0x4 (1000_15F9 / 0x115F9)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x1601);
    // MOV word ptr [BP + -0x2],0xb (1000_15FC / 0x115FC)
    UInt16[SS, (ushort)(BP - 0x2)] = 0xB;
    label_1000_1601_11601:
    CheckExternalEvents(cs8, 0x1604);
    // INC word ptr [BP + -0x2] (1000_1601 / 0x11601)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs8, 0x1608);
    // CMP word ptr [BP + -0x2],0xb (1000_1604 / 0x11604)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xB);
    CheckExternalEvents(cs8, 0x160A);
    // JL 0x1000:15af (1000_1608 / 0x11608)
    if(SignFlag != OverflowFlag) {
      goto label_1000_15AF_115AF;
    }
    CheckExternalEvents(cs8, 0x160C);
    // MOV SP,BP (1000_160A / 0x1160A)
    SP = BP;
    CheckExternalEvents(cs8, 0x160D);
    // POP BP (1000_160C / 0x1160C)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x160E);
    // RETF  (1000_160D / 0x1160D)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_160E_1160E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_160E_1160E:
    CheckExternalEvents(cs8, 0x160F);
    // PUSH BP (1000_160E / 0x1160E)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x1611);
    // MOV BP,SP (1000_160F / 0x1160F)
    BP = SP;
    CheckExternalEvents(cs8, 0x1614);
    // MOV AX,0x1c (1000_1611 / 0x11611)
    AX = 0x1C;
    CheckExternalEvents(cs8, 0x1619);
    // CALLF 0x1000:cecc (1000_1614 / 0x11614)
    FarCall(cs8, 0x1619, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x161A);
    // PUSH SI (1000_1619 / 0x11619)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0x161E);
    // MOV ES,word ptr [0x5582] (1000_161A / 0x1161A)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs8, 0x1622);
    // MOV AX,ES:[0xa44b] (1000_161E / 0x1161E)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs8, 0x1625);
    // MOV word ptr [BP + -0x4],AX (1000_1622 / 0x11622)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs8, 0x1629);
    // MOV ES,word ptr [0x5584] (1000_1625 / 0x11625)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs8, 0x162D);
    // MOV AX,ES:[0xa44d] (1000_1629 / 0x11629)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs8, 0x1630);
    // MOV word ptr [BP + -0x8],AX (1000_162D / 0x1162D)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs8, 0x1631);
    // PUSH AX (1000_1630 / 0x11630)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1634);
    // PUSH word ptr [BP + -0x4] (1000_1631 / 0x11631)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs8, 0x1639);
    // CALLF 0x1000:b204 (1000_1634 / 0x11634)
    FarCall(cs8, 0x1639, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs8, 0x163C);
    // ADD SP,0x4 (1000_1639 / 0x11639)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x1641);
    // CALLF 0x1000:bce8 (1000_163C / 0x1163C)
    FarCall(cs8, 0x1641, unknown_19EF_1DF8_1BCE8);
    CheckExternalEvents(cs8, 0x1645);
    // MOV ES,word ptr [0x559c] (1000_1641 / 0x11641)
    ES = UInt16[DS, 0x559C];
    CheckExternalEvents(cs8, 0x164B);
    // CMP word ptr ES:[0xe48e],0x0 (1000_1645 / 0x11645)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs8, 0x164D);
    // JZ 0x1000:1659 (1000_164B / 0x1164B)
    if(ZeroFlag) {
      goto label_1000_1659_11659;
    }
    CheckExternalEvents(cs8, 0x1651);
    // CMP word ptr [BP + 0x8],0xd (1000_164D / 0x1164D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xD);
    CheckExternalEvents(cs8, 0x1653);
    // JNZ 0x1000:1659 (1000_1651 / 0x11651)
    if(!ZeroFlag) {
      goto label_1000_1659_11659;
    }
    CheckExternalEvents(cs8, 0x1656);
    // MOV AX,0x1 (1000_1653 / 0x11653)
    AX = 0x1;
    CheckExternalEvents(cs8, 0x1659);
    // JMP 0x1000:17b6 (1000_1656 / 0x11656)
    goto label_1000_17B6_117B6;
    label_1000_1659_11659:
    CheckExternalEvents(cs8, 0x165D);
    // MOV ES,word ptr [0x5586] (1000_1659 / 0x11659)
    ES = UInt16[DS, 0x5586];
    CheckExternalEvents(cs8, 0x1661);
    // MOV AX,ES:[0x9ed] (1000_165D / 0x1165D)
    AX = UInt16[ES, 0x9ED];
    CheckExternalEvents(cs8, 0x1664);
    // ADD AX,0x96 (1000_1661 / 0x11661)
    // AX += 0x96;
    AX = Alu16.Add(AX, 0x96);
    CheckExternalEvents(cs8, 0x1667);
    // MOV word ptr [BP + -0x10],AX (1000_1664 / 0x11664)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs8, 0x166C);
    // MOV word ptr [BP + -0x1c],0x1 (1000_1667 / 0x11667)
    UInt16[SS, (ushort)(BP - 0x1C)] = 0x1;
    CheckExternalEvents(cs8, 0x166F);
    // MOV AX,word ptr [BP + -0x8] (1000_166C / 0x1166C)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs8, 0x1672);
    // AND AX,0x1 (1000_166F / 0x1166F)
    // AX &= 0x1;
    AX = Alu16.And(AX, 0x1);
    CheckExternalEvents(cs8, 0x1675);
    // MOV word ptr [BP + -0x2],AX (1000_1672 / 0x11672)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs8, 0x1679);
    // TEST byte ptr [BP + -0x4],0x1 (1000_1675 / 0x11675)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x4)], 0x1);
    CheckExternalEvents(cs8, 0x167B);
    // JZ 0x1000:1683 (1000_1679 / 0x11679)
    if(ZeroFlag) {
      goto label_1000_1683_11683;
    }
    CheckExternalEvents(cs8, 0x167E);
    // INC word ptr [BP + -0x10] (1000_167B / 0x1167B)
    UInt16[SS, (ushort)(BP - 0x10)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x10)]);
    CheckExternalEvents(cs8, 0x1683);
    // MOV word ptr [BP + -0x1c],0x0 (1000_167E / 0x1167E)
    UInt16[SS, (ushort)(BP - 0x1C)] = 0x0;
    label_1000_1683_11683:
    CheckExternalEvents(cs8, 0x1686);
    // PUSH word ptr [BP + 0xc] (1000_1683 / 0x11683)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs8, 0x1689);
    // PUSH word ptr [BP + 0xa] (1000_1686 / 0x11686)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs8, 0x168C);
    // PUSH word ptr [BP + -0x8] (1000_1689 / 0x11689)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs8, 0x168F);
    // PUSH word ptr [BP + -0x4] (1000_168C / 0x1168C)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs8, 0x1694);
    // CALLF 0x1000:a861 (1000_168F / 0x1168F)
    FarCall(cs8, 0x1694, unknown_19EF_0971_1A861);
    CheckExternalEvents(cs8, 0x1697);
    // ADD SP,0x8 (1000_1694 / 0x11694)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs8, 0x169A);
    // MOV word ptr [BP + -0x12],AX (1000_1697 / 0x11697)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs8, 0x169F);
    // MOV word ptr [BP + -0xe],0x1 (1000_169A / 0x1169A)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x1;
    CheckExternalEvents(cs8, 0x16A2);
    // MOV BX,word ptr [BP + -0x10] (1000_169F / 0x1169F)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs8, 0x16A6);
    // MOV ES,word ptr [0x5588] (1000_16A2 / 0x116A2)
    ES = UInt16[DS, 0x5588];
    CheckExternalEvents(cs8, 0x16AB);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (1000_16A6 / 0x116A6)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs8, 0x16AD);
    // SUB AH,AH (1000_16AB / 0x116AB)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs8, 0x16B0);
    // MOV word ptr [BP + -0x14],AX (1000_16AD / 0x116AD)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs8, 0x16B4);
    // MOV ES,word ptr [0x558a] (1000_16B0 / 0x116B0)
    ES = UInt16[DS, 0x558A];
    CheckExternalEvents(cs8, 0x16B9);
    // CMP word ptr ES:[0x150],AX (1000_16B4 / 0x116B4)
    Alu16.Sub(UInt16[ES, 0x150], AX);
    CheckExternalEvents(cs8, 0x16BB);
    // JLE 0x1000:16be (1000_16B9 / 0x116B9)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_16BE_116BE;
    }
    CheckExternalEvents(cs8, 0x16BE);
    // JMP 0x1000:176c (1000_16BB / 0x116BB)
    goto label_1000_176C_1176C;
    label_1000_16BE_116BE:
    CheckExternalEvents(cs8, 0x16C0);
    // SUB AX,AX (1000_16BE / 0x116BE)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x16C3);
    // JMP 0x1000:17b6 (1000_16C0 / 0x116C0)
    goto label_1000_17B6_117B6;
    label_1000_16C3_116C3:
    CheckExternalEvents(cs8, 0x16C6);
    // DEC word ptr [BP + -0x12] (1000_16C3 / 0x116C3)
    UInt16[SS, (ushort)(BP - 0x12)]--;
    label_1000_16C6_116C6:
    CheckExternalEvents(cs8, 0x16CA);
    // AND word ptr [BP + -0x12],0x7 (1000_16C6 / 0x116C6)
    // UInt16[SS, (ushort)(BP - 0x12)] &= 0x7;
    UInt16[SS, (ushort)(BP - 0x12)] = Alu16.And(UInt16[SS, (ushort)(BP - 0x12)], 0x7);
    label_1000_16CA_116CA:
    CheckExternalEvents(cs8, 0x16CD);
    // MOV SI,word ptr [BP + -0x12] (1000_16CA / 0x116CA)
    SI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs8, 0x16CF);
    // SHL SI,0x1 (1000_16CD / 0x116CD)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x16D3);
    // MOV AX,word ptr [SI + 0x328a] (1000_16CF / 0x116CF)
    AX = UInt16[DS, (ushort)(SI + 0x328A)];
    CheckExternalEvents(cs8, 0x16D6);
    // ADD word ptr [BP + -0x4],AX (1000_16D3 / 0x116D3)
    UInt16[SS, (ushort)(BP - 0x4)] += AX;
    CheckExternalEvents(cs8, 0x16DA);
    // TEST byte ptr [BP + -0x4],0x80 (1000_16D6 / 0x116D6)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x4)], 0x80);
    CheckExternalEvents(cs8, 0x16DC);
    // JZ 0x1000:16e3 (1000_16DA / 0x116DA)
    if(ZeroFlag) {
      goto label_1000_16E3_116E3;
    }
    CheckExternalEvents(cs8, 0x16E0);
    // MOV AX,word ptr [SI + 0x32aa] (1000_16DC / 0x116DC)
    AX = UInt16[DS, (ushort)(SI + 0x32AA)];
    CheckExternalEvents(cs8, 0x16E3);
    // ADD word ptr [BP + -0x4],AX (1000_16E0 / 0x116E0)
    // UInt16[SS, (ushort)(BP - 0x4)] += AX;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], AX);
    label_1000_16E3_116E3:
    CheckExternalEvents(cs8, 0x16E6);
    // MOV SI,word ptr [BP + -0x12] (1000_16E3 / 0x116E3)
    SI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs8, 0x16E8);
    // SHL SI,0x1 (1000_16E6 / 0x116E6)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x16EC);
    // MOV AX,word ptr [SI + 0x329a] (1000_16E8 / 0x116E8)
    AX = UInt16[DS, (ushort)(SI + 0x329A)];
    CheckExternalEvents(cs8, 0x16EF);
    // ADD word ptr [BP + -0x8],AX (1000_16EC / 0x116EC)
    UInt16[SS, (ushort)(BP - 0x8)] += AX;
    CheckExternalEvents(cs8, 0x16F3);
    // TEST byte ptr [BP + -0x8],0x80 (1000_16EF / 0x116EF)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x8)], 0x80);
    CheckExternalEvents(cs8, 0x16F5);
    // JZ 0x1000:16fc (1000_16F3 / 0x116F3)
    if(ZeroFlag) {
      goto label_1000_16FC_116FC;
    }
    CheckExternalEvents(cs8, 0x16F9);
    // MOV AX,word ptr [SI + 0x32ba] (1000_16F5 / 0x116F5)
    AX = UInt16[DS, (ushort)(SI + 0x32BA)];
    CheckExternalEvents(cs8, 0x16FC);
    // ADD word ptr [BP + -0x8],AX (1000_16F9 / 0x116F9)
    // UInt16[SS, (ushort)(BP - 0x8)] += AX;
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x8)], AX);
    label_1000_16FC_116FC:
    CheckExternalEvents(cs8, 0x16FF);
    // MOV BX,word ptr [BP + -0x12] (1000_16FC / 0x116FC)
    BX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs8, 0x1701);
    // SHL BX,0x1 (1000_16FF / 0x116FF)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x1705);
    // MOV SI,word ptr [BX + 0x328a] (1000_1701 / 0x11701)
    SI = UInt16[DS, (ushort)(BX + 0x328A)];
    CheckExternalEvents(cs8, 0x1707);
    // OR SI,SI (1000_1705 / 0x11705)
    // SI |= SI;
    SI = Alu16.Or(SI, SI);
    CheckExternalEvents(cs8, 0x1709);
    // JZ 0x1000:171b (1000_1707 / 0x11707)
    if(ZeroFlag) {
      goto label_1000_171B_1171B;
    }
    CheckExternalEvents(cs8, 0x170C);
    // MOV AX,word ptr [BP + -0x1c] (1000_1709 / 0x11709)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs8, 0x170E);
    // ADD AX,SI (1000_170C / 0x1170C)
    AX += SI;
    CheckExternalEvents(cs8, 0x1711);
    // AND AX,0x1 (1000_170E / 0x1170E)
    // AX &= 0x1;
    AX = Alu16.And(AX, 0x1);
    CheckExternalEvents(cs8, 0x1714);
    // MOV word ptr [BP + -0x1c],AX (1000_1711 / 0x11711)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs8, 0x1716);
    // OR AX,AX (1000_1714 / 0x11714)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs8, 0x1718);
    // JNZ 0x1000:171b (1000_1716 / 0x11716)
    if(!ZeroFlag) {
      goto label_1000_171B_1171B;
    }
    CheckExternalEvents(cs8, 0x171B);
    // ADD word ptr [BP + -0x10],SI (1000_1718 / 0x11718)
    // UInt16[SS, (ushort)(BP - 0x10)] += SI;
    UInt16[SS, (ushort)(BP - 0x10)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x10)], SI);
    label_1000_171B_1171B:
    CheckExternalEvents(cs8, 0x171E);
    // MOV SI,word ptr [BP + -0x12] (1000_171B / 0x1171B)
    SI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs8, 0x1720);
    // SHL SI,0x1 (1000_171E / 0x1171E)
    SI <<= 0x1;
    CheckExternalEvents(cs8, 0x1725);
    // CMP word ptr [SI + 0x329a],0x0 (1000_1720 / 0x11720)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x329A)], 0x0);
    CheckExternalEvents(cs8, 0x1727);
    // JZ 0x1000:173f (1000_1725 / 0x11725)
    if(ZeroFlag) {
      goto label_1000_173F_1173F;
    }
    CheckExternalEvents(cs8, 0x172B);
    // MOV AX,word ptr [SI + 0x329a] (1000_1727 / 0x11727)
    AX = UInt16[DS, (ushort)(SI + 0x329A)];
    CheckExternalEvents(cs8, 0x172E);
    // ADD AX,word ptr [BP + -0x2] (1000_172B / 0x1172B)
    AX += UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x1731);
    // AND AX,0x1 (1000_172E / 0x1172E)
    // AX &= 0x1;
    AX = Alu16.And(AX, 0x1);
    CheckExternalEvents(cs8, 0x1734);
    // MOV word ptr [BP + -0x2],AX (1000_1731 / 0x11731)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs8, 0x1736);
    // OR AX,AX (1000_1734 / 0x11734)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs8, 0x1738);
    // JNZ 0x1000:173f (1000_1736 / 0x11736)
    if(!ZeroFlag) {
      goto label_1000_173F_1173F;
    }
    CheckExternalEvents(cs8, 0x173C);
    // MOV AX,word ptr [SI + 0x32ca] (1000_1738 / 0x11738)
    AX = UInt16[DS, (ushort)(SI + 0x32CA)];
    CheckExternalEvents(cs8, 0x173F);
    // ADD word ptr [BP + -0x10],AX (1000_173C / 0x1173C)
    // UInt16[SS, (ushort)(BP - 0x10)] += AX;
    UInt16[SS, (ushort)(BP - 0x10)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x10)], AX);
    label_1000_173F_1173F:
    CheckExternalEvents(cs8, 0x1742);
    // MOV BX,word ptr [BP + -0x10] (1000_173F / 0x1173F)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs8, 0x1746);
    // MOV ES,word ptr [0x5588] (1000_1742 / 0x11742)
    ES = UInt16[DS, 0x5588];
    CheckExternalEvents(cs8, 0x174B);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (1000_1746 / 0x11746)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs8, 0x174D);
    // SUB AH,AH (1000_174B / 0x1174B)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs8, 0x1750);
    // MOV word ptr [BP + -0x14],AX (1000_174D / 0x1174D)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs8, 0x1754);
    // MOV ES,word ptr [0x558a] (1000_1750 / 0x11750)
    ES = UInt16[DS, 0x558A];
    CheckExternalEvents(cs8, 0x1759);
    // CMP word ptr ES:[0x150],AX (1000_1754 / 0x11754)
    Alu16.Sub(UInt16[ES, 0x150], AX);
    CheckExternalEvents(cs8, 0x175B);
    // JG 0x1000:176c (1000_1759 / 0x11759)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_176C_1176C;
    }
    CheckExternalEvents(cs8, 0x175E);
    // MOV AX,word ptr [BP + 0xa] (1000_175B / 0x1175B)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0x1761);
    // MOV word ptr [BP + -0x4],AX (1000_175E / 0x1175E)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs8, 0x1764);
    // MOV AX,word ptr [BP + 0xc] (1000_1761 / 0x11761)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x1767);
    // MOV word ptr [BP + -0x8],AX (1000_1764 / 0x11764)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs8, 0x176C);
    // MOV word ptr [BP + -0xe],0x0 (1000_1767 / 0x11767)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    label_1000_176C_1176C:
    CheckExternalEvents(cs8, 0x176F);
    // MOV AX,word ptr [BP + 0xa] (1000_176C / 0x1176C)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0x1772);
    // CMP word ptr [BP + -0x4],AX (1000_176F / 0x1176F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs8, 0x1774);
    // JNZ 0x1000:177c (1000_1772 / 0x11772)
    if(!ZeroFlag) {
      goto label_1000_177C_1177C;
    }
    CheckExternalEvents(cs8, 0x1777);
    // MOV AX,word ptr [BP + 0xc] (1000_1774 / 0x11774)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x177A);
    // CMP word ptr [BP + -0x8],AX (1000_1777 / 0x11777)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], AX);
    CheckExternalEvents(cs8, 0x177C);
    // JZ 0x1000:17b3 (1000_177A / 0x1177A)
    if(ZeroFlag) {
      goto label_1000_17B3_117B3;
    }
    label_1000_177C_1177C:
    CheckExternalEvents(cs8, 0x177F);
    // PUSH word ptr [BP + 0xc] (1000_177C / 0x1177C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs8, 0x1782);
    // PUSH word ptr [BP + 0xa] (1000_177F / 0x1177F)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs8, 0x1785);
    // PUSH word ptr [BP + -0x8] (1000_1782 / 0x11782)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs8, 0x1788);
    // PUSH word ptr [BP + -0x4] (1000_1785 / 0x11785)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs8, 0x178D);
    // CALLF 0x1000:a861 (1000_1788 / 0x11788)
    FarCall(cs8, 0x178D, unknown_19EF_0971_1A861);
    CheckExternalEvents(cs8, 0x1790);
    // ADD SP,0x8 (1000_178D / 0x1178D)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs8, 0x1793);
    // MOV word ptr [BP + -0x6],AX (1000_1790 / 0x11790)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs8, 0x1796);
    // SUB AX,word ptr [BP + -0x12] (1000_1793 / 0x11793)
    // AX -= UInt16[SS, (ushort)(BP - 0x12)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs8, 0x1799);
    // MOV word ptr [BP + -0x18],AX (1000_1796 / 0x11796)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs8, 0x179B);
    // OR AX,AX (1000_1799 / 0x11799)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs8, 0x179D);
    // JNZ 0x1000:17a0 (1000_179B / 0x1179B)
    if(!ZeroFlag) {
      goto label_1000_17A0_117A0;
    }
    CheckExternalEvents(cs8, 0x17A0);
    // JMP 0x1000:16ca (1000_179D / 0x1179D)
    goto label_1000_16CA_116CA;
    label_1000_17A0_117A0:
    CheckExternalEvents(cs8, 0x17A4);
    // AND word ptr [BP + -0x18],0x7 (1000_17A0 / 0x117A0)
    UInt16[SS, (ushort)(BP - 0x18)] &= 0x7;
    CheckExternalEvents(cs8, 0x17A8);
    // CMP word ptr [BP + -0x18],0x5 (1000_17A4 / 0x117A4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0x5);
    CheckExternalEvents(cs8, 0x17AA);
    // JL 0x1000:17ad (1000_17A8 / 0x117A8)
    if(SignFlag != OverflowFlag) {
      goto label_1000_17AD_117AD;
    }
    CheckExternalEvents(cs8, 0x17AD);
    // JMP 0x1000:16c3 (1000_17AA / 0x117AA)
    goto label_1000_16C3_116C3;
    label_1000_17AD_117AD:
    CheckExternalEvents(cs8, 0x17B0);
    // INC word ptr [BP + -0x12] (1000_17AD / 0x117AD)
    UInt16[SS, (ushort)(BP - 0x12)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs8, 0x17B3);
    // JMP 0x1000:16c6 (1000_17B0 / 0x117B0)
    goto label_1000_16C6_116C6;
    label_1000_17B3_117B3:
    CheckExternalEvents(cs8, 0x17B6);
    // MOV AX,word ptr [BP + -0xe] (1000_17B3 / 0x117B3)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    label_1000_17B6_117B6:
    CheckExternalEvents(cs8, 0x17B7);
    // POP SI (1000_17B6 / 0x117B6)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x17B9);
    // MOV SP,BP (1000_17B7 / 0x117B7)
    SP = BP;
    CheckExternalEvents(cs8, 0x17BA);
    // POP BP (1000_17B9 / 0x117B9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x17BB);
    // RETF  (1000_17BA / 0x117BA)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_17BB_117BB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_17BB_117BB:
    CheckExternalEvents(cs8, 0x17BC);
    // PUSH BP (1000_17BB / 0x117BB)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x17BE);
    // MOV BP,SP (1000_17BC / 0x117BC)
    BP = SP;
    CheckExternalEvents(cs8, 0x17C0);
    // XOR AX,AX (1000_17BE / 0x117BE)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0x17C5);
    // CALLF 0x1000:cecc (1000_17C0 / 0x117C0)
    FarCall(cs8, 0x17C5, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x17CA);
    // CMP word ptr [0x2e38],0x0 (1000_17C5 / 0x117C5)
    Alu16.Sub(UInt16[DS, 0x2E38], 0x0);
    CheckExternalEvents(cs8, 0x17CC);
    // JZ 0x1000:17da (1000_17CA / 0x117CA)
    if(ZeroFlag) {
      goto label_1000_17DA_117DA;
    }
    CheckExternalEvents(cs8, 0x17CF);
    // PUSH word ptr [BP + 0x8] (1000_17CC / 0x117CC)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs8, 0x17D2);
    // PUSH word ptr [BP + 0x6] (1000_17CF / 0x117CF)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs8, 0x17D7);
    // CALLF 0x1000:8055 (1000_17D2 / 0x117D2)
    FarCall(cs8, 0x17D7, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x17DA);
    // ADD SP,0x4 (1000_17D7 / 0x117D7)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_17DA_117DA:
    CheckExternalEvents(cs8, 0x17DB);
    // POP BP (1000_17DA / 0x117DA)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x17DC);
    // RETF  (1000_17DB / 0x117DB)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_17DC_117DC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_17DC_117DC:
    CheckExternalEvents(cs8, 0x17DE);
    // XOR AX,AX (1000_17DC / 0x117DC)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0x17E3);
    // CALLF 0x1000:cecc (1000_17DE / 0x117DE)
    FarCall(cs8, 0x17E3, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x17E7);
    // MOV ES,word ptr [0x55b8] (1000_17E3 / 0x117E3)
    ES = UInt16[DS, 0x55B8];
    CheckExternalEvents(cs8, 0x17ED);
    // CMP word ptr ES:[0x15e],0x5 (1000_17E7 / 0x117E7)
    Alu16.Sub(UInt16[ES, 0x15E], 0x5);
    CheckExternalEvents(cs8, 0x17EF);
    // JGE 0x1000:1802 (1000_17ED / 0x117ED)
    if(SignFlag == OverflowFlag) {
      goto label_1000_1802_11802;
    }
    CheckExternalEvents(cs8, 0x17F2);
    // MOV AX,0xc (1000_17EF / 0x117EF)
    AX = 0xC;
    CheckExternalEvents(cs8, 0x17F7);
    // IMUL word ptr ES:[0x15e] (1000_17F2 / 0x117F2)
    int resImul1000_17F2 = Alu16.Imul((short)AX, (short)UInt16[ES, 0x15E]);
    AX = (ushort)(resImul1000_17F2);
    DX = (ushort)(resImul1000_17F2 >> 16);
    CheckExternalEvents(cs8, 0x17F8);
    // PUSH AX (1000_17F7 / 0x117F7)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x17FD);
    // CALLF 0x1000:8ad6 (1000_17F8 / 0x117F8)
    FarCall(cs8, 0x17FD, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs8, 0x1800);
    // ADD SP,0x2 (1000_17FD / 0x117FD)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x1802);
    // JMP 0x1000:1807 (1000_1800 / 0x11800)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs8, 0x1808);
    // RETF  (1000_1807 / 0x11807)
    return FarRet();
    label_1000_1802_11802:
    CheckExternalEvents(cs8, 0x1807);
    // CALLF 0x1000:8d29 (1000_1802 / 0x11802)
    FarCall(cs8, 0x1807, unknown_18AD_0259_18D29);
    label_1000_1807_11807:
    CheckExternalEvents(cs8, 0x1808);
    // RETF  (1000_1807 / 0x11807)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_1808_11808(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1808_11808:
    CheckExternalEvents(cs8, 0x1809);
    // PUSH BP (1000_1808 / 0x11808)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x180B);
    // MOV BP,SP (1000_1809 / 0x11809)
    BP = SP;
    CheckExternalEvents(cs8, 0x180D);
    // XOR AX,AX (1000_180B / 0x1180B)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0x1812);
    // CALLF 0x1000:cecc (1000_180D / 0x1180D)
    FarCall(cs8, 0x1812, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x1816);
    // MOV ES,word ptr [0x5580] (1000_1812 / 0x11812)
    ES = UInt16[DS, 0x5580];
    CheckExternalEvents(cs8, 0x181D);
    // MOV word ptr ES:[0xe486],0x1a (1000_1816 / 0x11816)
    UInt16[ES, 0xE486] = 0x1A;
    CheckExternalEvents(cs8, 0x1821);
    // MOV ES,word ptr [0x557e] (1000_181D / 0x1181D)
    ES = UInt16[DS, 0x557E];
    CheckExternalEvents(cs8, 0x1828);
    // MOV word ptr ES:[0xe488],0xc (1000_1821 / 0x11821)
    UInt16[ES, 0xE488] = 0xC;
    CheckExternalEvents(cs8, 0x182A);
    // JMP 0x1000:1842 (1000_1828 / 0x11828)
    goto label_1000_1842_11842;
    label_1000_182A_1182A:
    CheckExternalEvents(cs8, 0x182D);
    // DEC word ptr [BP + 0x8] (1000_182A / 0x1182A)
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Dec(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs8, 0x1830);
    // MOV AL,byte ptr [BP + 0x8] (1000_182D / 0x1182D)
    AL = UInt8[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x1832);
    // TEST AL,0x80 (1000_1830 / 0x11830)
    Alu8.And(AL, 0x80);
    CheckExternalEvents(cs8, 0x1834);
    // JZ 0x1000:1839 (1000_1832 / 0x11832)
    if(ZeroFlag) {
      goto label_1000_1839_11839;
    }
    CheckExternalEvents(cs8, 0x1839);
    // AND word ptr [BP + 0x8],0xf07f (1000_1834 / 0x11834)
    // UInt16[SS, (ushort)(BP + 0x8)] &= 0xF07F;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.And(UInt16[SS, (ushort)(BP + 0x8)], 0xF07F);
    label_1000_1839_11839:
    CheckExternalEvents(cs8, 0x183D);
    // MOV ES,word ptr [0x557e] (1000_1839 / 0x11839)
    ES = UInt16[DS, 0x557E];
    CheckExternalEvents(cs8, 0x1842);
    // DEC word ptr ES:[0xe488] (1000_183D / 0x1183D)
    UInt16[ES, 0xE488] = Alu16.Dec(UInt16[ES, 0xE488]);
    label_1000_1842_11842:
    CheckExternalEvents(cs8, 0x1845);
    // MOV AX,word ptr [BP + 0xc] (1000_1842 / 0x11842)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x1848);
    // CMP word ptr [BP + 0x8],AX (1000_1845 / 0x11845)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs8, 0x184A);
    // JA 0x1000:182a (1000_1848 / 0x11848)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_182A_1182A;
    }
    CheckExternalEvents(cs8, 0x184C);
    // JMP 0x1000:1864 (1000_184A / 0x1184A)
    goto label_1000_1864_11864;
    label_1000_184C_1184C:
    CheckExternalEvents(cs8, 0x184F);
    // INC word ptr [BP + 0x8] (1000_184C / 0x1184C)
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs8, 0x1852);
    // MOV AL,byte ptr [BP + 0x8] (1000_184F / 0x1184F)
    AL = UInt8[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x1854);
    // TEST AL,0x80 (1000_1852 / 0x11852)
    Alu8.And(AL, 0x80);
    CheckExternalEvents(cs8, 0x1856);
    // JZ 0x1000:185b (1000_1854 / 0x11854)
    if(ZeroFlag) {
      goto label_1000_185B_1185B;
    }
    CheckExternalEvents(cs8, 0x185B);
    // ADD word ptr [BP + 0x8],0xf80 (1000_1856 / 0x11856)
    // UInt16[SS, (ushort)(BP + 0x8)] += 0xF80;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Add(UInt16[SS, (ushort)(BP + 0x8)], 0xF80);
    label_1000_185B_1185B:
    CheckExternalEvents(cs8, 0x185F);
    // MOV ES,word ptr [0x557e] (1000_185B / 0x1185B)
    ES = UInt16[DS, 0x557E];
    CheckExternalEvents(cs8, 0x1864);
    // INC word ptr ES:[0xe488] (1000_185F / 0x1185F)
    UInt16[ES, 0xE488] = Alu16.Inc(UInt16[ES, 0xE488]);
    label_1000_1864_11864:
    CheckExternalEvents(cs8, 0x1867);
    // MOV AX,word ptr [BP + 0xc] (1000_1864 / 0x11864)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x186A);
    // CMP word ptr [BP + 0x8],AX (1000_1867 / 0x11867)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs8, 0x186C);
    // JC 0x1000:184c (1000_186A / 0x1186A)
    if(CarryFlag) {
      goto label_1000_184C_1184C;
    }
    CheckExternalEvents(cs8, 0x186E);
    // JMP 0x1000:1886 (1000_186C / 0x1186C)
    goto label_1000_1886_11886;
    label_1000_186E_1186E:
    CheckExternalEvents(cs8, 0x1871);
    // DEC word ptr [BP + 0x6] (1000_186E / 0x1186E)
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Dec(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs8, 0x1874);
    // MOV AL,byte ptr [BP + 0x6] (1000_1871 / 0x11871)
    AL = UInt8[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x1876);
    // TEST AL,0x80 (1000_1874 / 0x11874)
    Alu8.And(AL, 0x80);
    CheckExternalEvents(cs8, 0x1878);
    // JZ 0x1000:187d (1000_1876 / 0x11876)
    if(ZeroFlag) {
      goto label_1000_187D_1187D;
    }
    CheckExternalEvents(cs8, 0x187D);
    // AND word ptr [BP + 0x6],0xf7f (1000_1878 / 0x11878)
    // UInt16[SS, (ushort)(BP + 0x6)] &= 0xF7F;
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.And(UInt16[SS, (ushort)(BP + 0x6)], 0xF7F);
    label_1000_187D_1187D:
    CheckExternalEvents(cs8, 0x1881);
    // MOV ES,word ptr [0x5580] (1000_187D / 0x1187D)
    ES = UInt16[DS, 0x5580];
    CheckExternalEvents(cs8, 0x1886);
    // DEC word ptr ES:[0xe486] (1000_1881 / 0x11881)
    UInt16[ES, 0xE486] = Alu16.Dec(UInt16[ES, 0xE486]);
    label_1000_1886_11886:
    CheckExternalEvents(cs8, 0x1889);
    // MOV AX,word ptr [BP + 0xa] (1000_1886 / 0x11886)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0x188C);
    // CMP word ptr [BP + 0x6],AX (1000_1889 / 0x11889)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], AX);
    CheckExternalEvents(cs8, 0x188E);
    // JA 0x1000:186e (1000_188C / 0x1188C)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_186E_1186E;
    }
    CheckExternalEvents(cs8, 0x1890);
    // JMP 0x1000:18a8 (1000_188E / 0x1188E)
    goto label_1000_18A8_118A8;
    label_1000_1890_11890:
    CheckExternalEvents(cs8, 0x1893);
    // INC word ptr [BP + 0x6] (1000_1890 / 0x11890)
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs8, 0x1896);
    // MOV AL,byte ptr [BP + 0x6] (1000_1893 / 0x11893)
    AL = UInt8[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x1898);
    // TEST AL,0x80 (1000_1896 / 0x11896)
    Alu8.And(AL, 0x80);
    CheckExternalEvents(cs8, 0x189A);
    // JZ 0x1000:189f (1000_1898 / 0x11898)
    if(ZeroFlag) {
      goto label_1000_189F_1189F;
    }
    CheckExternalEvents(cs8, 0x189F);
    // ADD word ptr [BP + 0x6],0x80 (1000_189A / 0x1189A)
    // UInt16[SS, (ushort)(BP + 0x6)] += 0x80;
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Add(UInt16[SS, (ushort)(BP + 0x6)], 0x80);
    label_1000_189F_1189F:
    CheckExternalEvents(cs8, 0x18A3);
    // MOV ES,word ptr [0x5580] (1000_189F / 0x1189F)
    ES = UInt16[DS, 0x5580];
    CheckExternalEvents(cs8, 0x18A8);
    // INC word ptr ES:[0xe486] (1000_18A3 / 0x118A3)
    UInt16[ES, 0xE486] = Alu16.Inc(UInt16[ES, 0xE486]);
    label_1000_18A8_118A8:
    CheckExternalEvents(cs8, 0x18AB);
    // MOV AX,word ptr [BP + 0xa] (1000_18A8 / 0x118A8)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0x18AE);
    // CMP word ptr [BP + 0x6],AX (1000_18AB / 0x118AB)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], AX);
    CheckExternalEvents(cs8, 0x18B0);
    // JC 0x1000:1890 (1000_18AE / 0x118AE)
    if(CarryFlag) {
      goto label_1000_1890_11890;
    }
    CheckExternalEvents(cs8, 0x18B1);
    // POP BP (1000_18B0 / 0x118B0)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x18B2);
    // RETF  (1000_18B1 / 0x118B1)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_18B2_118B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_18B2_118B2:
    CheckExternalEvents(cs8, 0x18B3);
    // PUSH BP (1000_18B2 / 0x118B2)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x18B5);
    // MOV BP,SP (1000_18B3 / 0x118B3)
    BP = SP;
    CheckExternalEvents(cs8, 0x18B8);
    // MOV AX,0x2 (1000_18B5 / 0x118B5)
    AX = 0x2;
    CheckExternalEvents(cs8, 0x18BD);
    // CALLF 0x1000:cecc (1000_18B8 / 0x118B8)
    FarCall(cs8, 0x18BD, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x18C1);
    // CMP word ptr [BP + 0x6],0x0 (1000_18BD / 0x118BD)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs8, 0x18C3);
    // JGE 0x1000:18ed (1000_18C1 / 0x118C1)
    if(SignFlag == OverflowFlag) {
      goto label_1000_18ED_118ED;
    }
    CheckExternalEvents(cs8, 0x18C7);
    // CMP word ptr [BP + 0x8],0x0 (1000_18C3 / 0x118C3)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs8, 0x18C9);
    // JLE 0x1000:18da (1000_18C7 / 0x118C7)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_18DA_118DA;
    }
    CheckExternalEvents(cs8, 0x18CE);
    // MOV word ptr [BP + -0x2],0x2 (1000_18C9 / 0x118C9)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x2;
    CheckExternalEvents(cs8, 0x18D1);
    // MOV AX,word ptr [BP + 0x6] (1000_18CE / 0x118CE)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x18D3);
    // NEG AX (1000_18D1 / 0x118D1)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs8, 0x18D6);
    // CMP AX,word ptr [BP + 0x8] (1000_18D3 / 0x118D3)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    label_1000_18D6_118D6:
    CheckExternalEvents(cs8, 0x18D8);
    // JLE 0x1000:1912 (1000_18D6 / 0x118D6)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_1912_11912;
    }
    CheckExternalEvents(cs8, 0x18DA);
    // JMP 0x1000:190f (1000_18D8 / 0x118D8)
    goto label_1000_190F_1190F;
    label_1000_18DA_118DA:
    CheckExternalEvents(cs8, 0x18DF);
    // MOV word ptr [BP + -0x2],0x4 (1000_18DA / 0x118DA)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x4;
    CheckExternalEvents(cs8, 0x18E2);
    // MOV AX,word ptr [BP + 0x8] (1000_18DF / 0x118DF)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x18E4);
    // NEG AX (1000_18E2 / 0x118E2)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs8, 0x18E7);
    // MOV CX,word ptr [BP + 0x6] (1000_18E4 / 0x118E4)
    CX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x18E9);
    // NEG CX (1000_18E7 / 0x118E7)
    CX = Alu16.Sub(0, CX);
    CheckExternalEvents(cs8, 0x18EB);
    // CMP AX,CX (1000_18E9 / 0x118E9)
    Alu16.Sub(AX, CX);
    CheckExternalEvents(cs8, 0x18ED);
    // JMP 0x1000:18d6 (1000_18EB / 0x118EB)
    goto label_1000_18D6_118D6;
    label_1000_18ED_118ED:
    CheckExternalEvents(cs8, 0x18F1);
    // CMP word ptr [BP + 0x8],0x0 (1000_18ED / 0x118ED)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs8, 0x18F3);
    // JLE 0x1000:1900 (1000_18F1 / 0x118F1)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_1900_11900;
    }
    CheckExternalEvents(cs8, 0x18F8);
    // MOV word ptr [BP + -0x2],0x0 (1000_18F3 / 0x118F3)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs8, 0x18FB);
    // MOV AX,word ptr [BP + 0x6] (1000_18F8 / 0x118F8)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x18FE);
    // CMP word ptr [BP + 0x8],AX (1000_18FB / 0x118FB)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs8, 0x1900);
    // JMP 0x1000:18d6 (1000_18FE / 0x118FE)
    goto label_1000_18D6_118D6;
    label_1000_1900_11900:
    CheckExternalEvents(cs8, 0x1905);
    // MOV word ptr [BP + -0x2],0x6 (1000_1900 / 0x11900)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x6;
    CheckExternalEvents(cs8, 0x1908);
    // MOV AX,word ptr [BP + 0x8] (1000_1905 / 0x11905)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x190A);
    // NEG AX (1000_1908 / 0x11908)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs8, 0x190D);
    // CMP AX,word ptr [BP + 0x6] (1000_190A / 0x1190A)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs8, 0x190F);
    // JGE 0x1000:1912 (1000_190D / 0x1190D)
    if(SignFlag == OverflowFlag) {
      goto label_1000_1912_11912;
    }
    label_1000_190F_1190F:
    CheckExternalEvents(cs8, 0x1912);
    // INC word ptr [BP + -0x2] (1000_190F / 0x1190F)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_1912_11912:
    CheckExternalEvents(cs8, 0x1915);
    // MOV AX,word ptr [BP + -0x2] (1000_1912 / 0x11912)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x1917);
    // MOV SP,BP (1000_1915 / 0x11915)
    SP = BP;
    CheckExternalEvents(cs8, 0x1918);
    // POP BP (1000_1917 / 0x11917)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x1919);
    // RETF  (1000_1918 / 0x11918)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_1919_11919(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1919_11919:
    CheckExternalEvents(cs8, 0x191A);
    // PUSH BP (1000_1919 / 0x11919)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x191C);
    // MOV BP,SP (1000_191A / 0x1191A)
    BP = SP;
    CheckExternalEvents(cs8, 0x191F);
    // MOV AX,0x2 (1000_191C / 0x1191C)
    AX = 0x2;
    CheckExternalEvents(cs8, 0x1924);
    // CALLF 0x1000:cecc (1000_191F / 0x1191F)
    FarCall(cs8, 0x1924, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x1925);
    // PUSH SI (1000_1924 / 0x11924)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0x1928);
    // MOV AX,0x1 (1000_1925 / 0x11925)
    AX = 0x1;
    CheckExternalEvents(cs8, 0x1929);
    // PUSH AX (1000_1928 / 0x11928)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x192C);
    // PUSH word ptr [BP + 0x8] (1000_1929 / 0x11929)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs8, 0x192F);
    // PUSH word ptr [BP + 0x6] (1000_192C / 0x1192C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs8, 0x1934);
    // CALLF 0x1000:bdbe (1000_192F / 0x1192F)
    FarCall(cs8, 0x1934, ghidra_guess_1000_BDBE_1BDBE);
    CheckExternalEvents(cs8, 0x1937);
    // ADD SP,0x6 (1000_1934 / 0x11934)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs8, 0x193C);
    // MOV word ptr [BP + -0x2],0x4 (1000_1937 / 0x11937)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x4;
    CheckExternalEvents(cs8, 0x1940);
    // MOV ES,word ptr [0x558e] (1000_193C / 0x1193C)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs8, 0x1946);
    // CMP byte ptr ES:[0xc620],0x8 (1000_1940 / 0x11940)
    Alu8.Sub(UInt8[ES, 0xC620], 0x8);
    CheckExternalEvents(cs8, 0x1948);
    // JGE 0x1000:1950 (1000_1946 / 0x11946)
    if(SignFlag == OverflowFlag) {
      goto label_1000_1950_11950;
    }
    CheckExternalEvents(cs8, 0x194C);
    // MOV AL,ES:[0xc620] (1000_1948 / 0x11948)
    AL = UInt8[ES, 0xC620];
    CheckExternalEvents(cs8, 0x194D);
    // CBW  (1000_194C / 0x1194C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x1950);
    // MOV word ptr [BP + -0x2],AX (1000_194D / 0x1194D)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    label_1000_1950_11950:
    CheckExternalEvents(cs8, 0x1953);
    // MOV SI,word ptr [BP + -0x2] (1000_1950 / 0x11950)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x1955);
    // SHL SI,0x1 (1000_1953 / 0x11953)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x1959);
    // MOV ES,word ptr [0x5590] (1000_1955 / 0x11955)
    ES = UInt16[DS, 0x5590];
    CheckExternalEvents(cs8, 0x195E);
    // PUSH word ptr ES:[SI + 0x4036] (1000_1959 / 0x11959)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs8, 0x1962);
    // MOV ES,word ptr [0x5592] (1000_195E / 0x1195E)
    ES = UInt16[DS, 0x5592];
    CheckExternalEvents(cs8, 0x1967);
    // PUSH word ptr ES:[SI + 0x4004] (1000_1962 / 0x11962)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs8, 0x196C);
    // CALLF 0x0000:2ebb (1000_1967 / 0x11967)
    FarCall(cs8, 0x196C, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs8, 0x196F);
    // ADD SP,0x4 (1000_196C / 0x1196C)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x1974);
    // CALLF 0x0000:3b0b (1000_196F / 0x1196F)
    FarCall(cs8, 0x1974, unknown_0170_240B_03B0B);
    CheckExternalEvents(cs8, 0x1979);
    // CALLF 0x1000:b7df (1000_1974 / 0x11974)
    FarCall(cs8, 0x1979, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs8, 0x197E);
    // CALLF 0x0000:254b (1000_1979 / 0x11979)
    FarCall(cs8, 0x197E, ghidra_guess_0000_254B_0254B);
    CheckExternalEvents(cs8, 0x197F);
    // POP SI (1000_197E / 0x1197E)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x1981);
    // MOV SP,BP (1000_197F / 0x1197F)
    SP = BP;
    CheckExternalEvents(cs8, 0x1982);
    // POP BP (1000_1981 / 0x11981)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x1983);
    // RETF  (1000_1982 / 0x11982)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_1983_11983(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1983_11983:
    CheckExternalEvents(cs8, 0x1984);
    // PUSH BP (1000_1983 / 0x11983)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x1986);
    // MOV BP,SP (1000_1984 / 0x11984)
    BP = SP;
    CheckExternalEvents(cs8, 0x1988);
    // XOR AX,AX (1000_1986 / 0x11986)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0x198D);
    // CALLF 0x1000:cecc (1000_1988 / 0x11988)
    FarCall(cs8, 0x198D, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x1991);
    // MOV ES,word ptr [0x55be] (1000_198D / 0x1198D)
    ES = UInt16[DS, 0x55BE];
    CheckExternalEvents(cs8, 0x1997);
    // CMP word ptr ES:[0x4fba],0x2 (1000_1991 / 0x11991)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs8, 0x1999);
    // JZ 0x1000:19c3 (1000_1997 / 0x11997)
    if(ZeroFlag) {
      goto label_1000_19C3_119C3;
    }
    CheckExternalEvents(cs8, 0x199C);
    // PUSH word ptr [BP + 0xa] (1000_1999 / 0x11999)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs8, 0x199F);
    // PUSH word ptr [BP + 0x8] (1000_199C / 0x1199C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs8, 0x19A2);
    // MOV BX,word ptr [BP + 0x6] (1000_199F / 0x1199F)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x19A4);
    // SHL BX,0x1 (1000_19A2 / 0x119A2)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x19A6);
    // SHL BX,0x1 (1000_19A4 / 0x119A4)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x19AA);
    // MOV ES,word ptr [0x55c0] (1000_19A6 / 0x119A6)
    ES = UInt16[DS, 0x55C0];
    CheckExternalEvents(cs8, 0x19AF);
    // PUSH word ptr ES:[BX + 0x39fc] (1000_19AA / 0x119AA)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x39FC)]);
    CheckExternalEvents(cs8, 0x19B4);
    // PUSH word ptr ES:[BX + 0x39fa] (1000_19AF / 0x119AF)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x39FA)]);
    CheckExternalEvents(cs8, 0x19B7);
    // MOV AX,0x244b (1000_19B4 / 0x119B4)
    AX = 0x244B;
    CheckExternalEvents(cs8, 0x19BA);
    // MOV DX,0x1ddc (1000_19B7 / 0x119B7)
    DX = 0x1DDC;
    CheckExternalEvents(cs8, 0x19BB);
    // PUSH DX (1000_19BA / 0x119BA)
    Stack.Push16(DX);
    CheckExternalEvents(cs8, 0x19BC);
    // PUSH AX (1000_19BB / 0x119BB)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x19C1);
    // CALLF 0x1000:c7db (1000_19BC / 0x119BC)
    FarCall(cs8, 0x19C1, unknown_19EF_28EB_1C7DB);
    CheckExternalEvents(cs8, 0x19C3);
    // JMP 0x1000:19ea (1000_19C1 / 0x119C1)
    goto label_1000_19EA_119EA;
    label_1000_19C3_119C3:
    CheckExternalEvents(cs8, 0x19C6);
    // PUSH word ptr [BP + 0xa] (1000_19C3 / 0x119C3)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs8, 0x19C9);
    // PUSH word ptr [BP + 0x8] (1000_19C6 / 0x119C6)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs8, 0x19CC);
    // MOV BX,word ptr [BP + 0x6] (1000_19C9 / 0x119C9)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x19CE);
    // SHL BX,0x1 (1000_19CC / 0x119CC)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x19D0);
    // SHL BX,0x1 (1000_19CE / 0x119CE)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x19D4);
    // MOV ES,word ptr [0x55c0] (1000_19D0 / 0x119D0)
    ES = UInt16[DS, 0x55C0];
    CheckExternalEvents(cs8, 0x19D9);
    // PUSH word ptr ES:[BX + 0x39fc] (1000_19D4 / 0x119D4)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x39FC)]);
    CheckExternalEvents(cs8, 0x19DE);
    // PUSH word ptr ES:[BX + 0x39fa] (1000_19D9 / 0x119D9)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x39FA)]);
    CheckExternalEvents(cs8, 0x19E0);
    // SUB AX,AX (1000_19DE / 0x119DE)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x19E3);
    // MOV DX,0xac00 (1000_19E0 / 0x119E0)
    DX = 0xAC00;
    CheckExternalEvents(cs8, 0x19E4);
    // PUSH DX (1000_19E3 / 0x119E3)
    Stack.Push16(DX);
    CheckExternalEvents(cs8, 0x19E5);
    // PUSH AX (1000_19E4 / 0x119E4)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x19EA);
    // CALLF 0x1000:a267 (1000_19E5 / 0x119E5)
    FarCall(cs8, 0x19EA, unknown_19EF_0377_1A267);
    label_1000_19EA_119EA:
    CheckExternalEvents(cs8, 0x19ED);
    // ADD SP,0xc (1000_19EA / 0x119EA)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs8, 0x19EE);
    // POP BP (1000_19ED / 0x119ED)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x19EF);
    // RETF  (1000_19EE / 0x119EE)
    return FarRet();
  }
  
  public virtual Action unknown_0FA1_1FDF_119EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0FA1_1FDF_119EF:
    CheckExternalEvents(cs7, 0x1FE0);
    // PUSH BP (0FA1_1FDF / 0x119EF)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x1FE2);
    // MOV BP,SP (0FA1_1FE0 / 0x119F0)
    BP = SP;
    CheckExternalEvents(cs7, 0x1FE5);
    // MOV AX,0x4 (0FA1_1FE2 / 0x119F2)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x1FEA);
    // CALLF 0x1000:cecc (0FA1_1FE5 / 0x119F5)
    FarCall(cs7, 0x1FEA, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x1FEE);
    // MOV ES,word ptr [0x55b0] (0FA1_1FEA / 0x119FA)
    ES = UInt16[DS, 0x55B0];
    CheckExternalEvents(cs7, 0x1FF2);
    // MOV AX,ES:[0x4600] (0FA1_1FEE / 0x119FE)
    AX = UInt16[ES, 0x4600];
    CheckExternalEvents(cs7, 0x1FF5);
    // MOV word ptr [BP + -0x4],AX (0FA1_1FF2 / 0x11A02)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x1FF8);
    // MOV AX,0x3 (0FA1_1FF5 / 0x11A05)
    AX = 0x3;
    CheckExternalEvents(cs7, 0x1FF9);
    // PUSH AX (0FA1_1FF8 / 0x11A08)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x1FFE);
    // CALLF 0x1000:7ee1 (0FA1_1FF9 / 0x11A09)
    FarCall(cs7, 0x1FFE, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x2001);
    // ADD SP,0x2 (0FA1_1FFE / 0x11A0E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x2005);
    // MOV ES,word ptr [0x55c2] (0FA1_2001 / 0x11A11)
    ES = UInt16[DS, 0x55C2];
    CheckExternalEvents(cs7, 0x200C);
    // MOV word ptr ES:[0x3748],0x0 (0FA1_2005 / 0x11A15)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs7, 0x2010);
    // MOV ES,word ptr [0x55c4] (0FA1_200C / 0x11A1C)
    ES = UInt16[DS, 0x55C4];
    CheckExternalEvents(cs7, 0x2017);
    // MOV word ptr ES:[0x374e],0x9 (0FA1_2010 / 0x11A20)
    UInt16[ES, 0x374E] = 0x9;
    CheckExternalEvents(cs7, 0x201A);
    // MOV AX,0x32da (0FA1_2017 / 0x11A27)
    AX = 0x32DA;
    CheckExternalEvents(cs7, 0x201B);
    // PUSH DS (0FA1_201A / 0x11A2A)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x201C);
    // PUSH AX (0FA1_201B / 0x11A2B)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x2021);
    // CALLF 0x1000:8055 (0FA1_201C / 0x11A2C)
    FarCall(cs7, 0x2021, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x2024);
    // ADD SP,0x4 (0FA1_2021 / 0x11A31)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x2029);
    // CALLF 0x0000:3fa2 (0FA1_2024 / 0x11A34)
    FarCall(cs7, 0x2029, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs7, 0x202C);
    // MOV AX,0xa (0FA1_2029 / 0x11A39)
    AX = 0xA;
    CheckExternalEvents(cs7, 0x202D);
    // PUSH AX (0FA1_202C / 0x11A3C)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x2030);
    // MOV AX,0x12 (0FA1_202D / 0x11A3D)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x2033);
    // MOV DX,0x2a02 (0FA1_2030 / 0x11A40)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x2034);
    // PUSH DX (0FA1_2033 / 0x11A43)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x2035);
    // PUSH AX (0FA1_2034 / 0x11A44)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x2039);
    // MOV ES,word ptr [0x558e] (0FA1_2035 / 0x11A45)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0x203E);
    // PUSH word ptr ES:[0xd372] (0FA1_2039 / 0x11A49)
    Stack.Push16(UInt16[ES, 0xD372]);
    CheckExternalEvents(cs7, 0x2043);
    // PUSH word ptr ES:[0xd370] (0FA1_203E / 0x11A4E)
    Stack.Push16(UInt16[ES, 0xD370]);
    CheckExternalEvents(cs7, 0x2048);
    // CALLF 0x1000:dac2 (0FA1_2043 / 0x11A53)
    FarCall(cs7, 0x2048, unknown_19EF_3BD2_1DAC2);
    CheckExternalEvents(cs7, 0x204B);
    // ADD SP,0xa (0FA1_2048 / 0x11A58)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    CheckExternalEvents(cs7, 0x204E);
    // MOV AX,0x12 (0FA1_204B / 0x11A5B)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x2051);
    // MOV DX,0x2a02 (0FA1_204E / 0x11A5E)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x2052);
    // PUSH DX (0FA1_2051 / 0x11A61)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x2053);
    // PUSH AX (0FA1_2052 / 0x11A62)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x2058);
    // CALLF 0x1000:da8e (0FA1_2053 / 0x11A63)
    FarCall(cs7, 0x2058, unknown_19EF_3B9E_1DA8E);
    CheckExternalEvents(cs7, 0x205B);
    // ADD SP,0x4 (0FA1_2058 / 0x11A68)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x205E);
    // MOV word ptr [BP + -0x2],AX (0FA1_205B / 0x11A6B)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x2060);
    // JMP 0x1000:1a80 (0FA1_205E / 0x11A6E)
    goto label_0FA1_2070_11A80;
    label_0FA1_2060_11A70:
    CheckExternalEvents(cs7, 0x2063);
    // MOV BX,word ptr [BP + -0x2] (0FA1_2060 / 0x11A70)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x2066);
    // INC word ptr [BP + -0x2] (0FA1_2063 / 0x11A73)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x206A);
    // MOV ES,word ptr [0x55c6] (0FA1_2066 / 0x11A76)
    ES = UInt16[DS, 0x55C6];
    CheckExternalEvents(cs7, 0x2070);
    // MOV byte ptr ES:[BX + 0x12],0x20 (0FA1_206A / 0x11A7A)
    UInt8[ES, (ushort)(BX + 0x12)] = 0x20;
    label_0FA1_2070_11A80:
    CheckExternalEvents(cs7, 0x2074);
    // CMP word ptr [BP + -0x2],0xa (0FA1_2070 / 0x11A80)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xA);
    CheckExternalEvents(cs7, 0x2076);
    // JL 0x1000:1a70 (0FA1_2074 / 0x11A84)
    if(SignFlag != OverflowFlag) {
      goto label_0FA1_2060_11A70;
    }
    CheckExternalEvents(cs7, 0x2079);
    // MOV BX,word ptr [BP + -0x2] (0FA1_2076 / 0x11A86)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x207D);
    // MOV ES,word ptr [0x55c6] (0FA1_2079 / 0x11A89)
    ES = UInt16[DS, 0x55C6];
    CheckExternalEvents(cs7, 0x2083);
    // MOV byte ptr ES:[BX + 0x12],0x0 (0FA1_207D / 0x11A8D)
    UInt8[ES, (ushort)(BX + 0x12)] = 0x0;
    CheckExternalEvents(cs7, 0x2086);
    // MOV AX,0x12 (0FA1_2083 / 0x11A93)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x2089);
    // MOV DX,0x2a02 (0FA1_2086 / 0x11A96)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x208A);
    // PUSH DX (0FA1_2089 / 0x11A99)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x208B);
    // PUSH AX (0FA1_208A / 0x11A9A)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x2090);
    // CALLF 0x1000:8055 (0FA1_208B / 0x11A9B)
    FarCall(cs7, 0x2090, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x2093);
    // ADD SP,0x4 (0FA1_2090 / 0x11AA0)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x2097);
    // MOV ES,word ptr [0x55c8] (0FA1_2093 / 0x11AA3)
    ES = UInt16[DS, 0x55C8];
    CheckExternalEvents(cs7, 0x209E);
    // MOV word ptr ES:[0x37fe],0xf (0FA1_2097 / 0x11AA7)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs7, 0x20A1);
    // PUSH word ptr [BP + -0x4] (0FA1_209E / 0x11AAE)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs7, 0x20A6);
    // CALLF 0x1000:7ee1 (0FA1_20A1 / 0x11AB1)
    FarCall(cs7, 0x20A6, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x20A8);
    // MOV SP,BP (0FA1_20A6 / 0x11AB6)
    SP = BP;
    CheckExternalEvents(cs7, 0x20A9);
    // POP BP (0FA1_20A8 / 0x11AB8)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x20AA);
    // RETF  (0FA1_20A9 / 0x11AB9)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_1ABA_11ABA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_1ABA_11ABA:
    CheckExternalEvents(cs8, 0x1ABB);
    // PUSH BP (1000_1ABA / 0x11ABA)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x1ABD);
    // MOV BP,SP (1000_1ABB / 0x11ABB)
    BP = SP;
    CheckExternalEvents(cs8, 0x1AC0);
    // MOV AX,0x44 (1000_1ABD / 0x11ABD)
    AX = 0x44;
    CheckExternalEvents(cs8, 0x1AC5);
    // CALLF 0x1000:cecc (1000_1AC0 / 0x11AC0)
    FarCall(cs8, 0x1AC5, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x1AC6);
    // PUSH DI (1000_1AC5 / 0x11AC5)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0x1AC7);
    // PUSH SI (1000_1AC6 / 0x11AC6)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0x1ACB);
    // MOV ES,word ptr [0x55ca] (1000_1AC7 / 0x11AC7)
    ES = UInt16[DS, 0x55CA];
    CheckExternalEvents(cs8, 0x1AD2);
    // MOV word ptr ES:[0x2b20],0xc (1000_1ACB / 0x11ACB)
    UInt16[ES, 0x2B20] = 0xC;
    CheckExternalEvents(cs8, 0x1AD6);
    // MOV ES,word ptr [0x55cc] (1000_1AD2 / 0x11AD2)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x1ADA);
    // MOV AX,ES:[0xa44b] (1000_1AD6 / 0x11AD6)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs8, 0x1ADD);
    // MOV word ptr [BP + -0x32],AX (1000_1ADA / 0x11ADA)
    UInt16[SS, (ushort)(BP - 0x32)] = AX;
    CheckExternalEvents(cs8, 0x1AE1);
    // MOV ES,word ptr [0x55ce] (1000_1ADD / 0x11ADD)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x1AE5);
    // MOV AX,ES:[0xa44d] (1000_1AE1 / 0x11AE1)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs8, 0x1AE8);
    // MOV word ptr [BP + -0x36],AX (1000_1AE5 / 0x11AE5)
    UInt16[SS, (ushort)(BP - 0x36)] = AX;
    CheckExternalEvents(cs8, 0x1AED);
    // MOV word ptr [BP + -0x2c],0x0 (1000_1AE8 / 0x11AE8)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_1000_1AED_11AED:
    CheckExternalEvents(cs8, 0x1AF0);
    // MOV BX,word ptr [BP + -0x2c] (1000_1AED / 0x11AED)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x1AF4);
    // MOV ES,word ptr [0x55d0] (1000_1AF0 / 0x11AF0)
    ES = UInt16[DS, 0x55D0];
    CheckExternalEvents(cs8, 0x1AF9);
    // MOV AL,byte ptr ES:[BX + 0x7a4] (1000_1AF4 / 0x11AF4)
    AL = UInt8[ES, (ushort)(BX + 0x7A4)];
    CheckExternalEvents(cs8, 0x1AFB);
    // MOV SI,BX (1000_1AF9 / 0x11AF9)
    SI = BX;
    CheckExternalEvents(cs8, 0x1AFE);
    // MOV byte ptr [BP + SI + -0x1c],AL (1000_1AFB / 0x11AFB)
    UInt8[SS, (ushort)(BP + SI - 0x1C)] = AL;
    CheckExternalEvents(cs8, 0x1B01);
    // INC word ptr [BP + -0x2c] (1000_1AFE / 0x11AFE)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x1B05);
    // CMP word ptr [BP + -0x2c],0x9 (1000_1B01 / 0x11B01)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x9);
    CheckExternalEvents(cs8, 0x1B07);
    // JL 0x1000:1aed (1000_1B05 / 0x11B05)
    if(SignFlag != OverflowFlag) {
      goto label_1000_1AED_11AED;
    }
    CheckExternalEvents(cs8, 0x1B0C);
    // MOV word ptr [BP + -0xa],0x0 (1000_1B07 / 0x11B07)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs8, 0x1B10);
    // CMP word ptr [BP + 0x6],0x0 (1000_1B0C / 0x11B0C)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs8, 0x1B12);
    // JNZ 0x1000:1b51 (1000_1B10 / 0x11B10)
    if(!ZeroFlag) {
      goto label_1000_1B51_11B51;
    }
    CheckExternalEvents(cs8, 0x1B17);
    // MOV word ptr [BP + -0x26],0x0 (1000_1B12 / 0x11B12)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x0;
    label_1000_1B17_11B17:
    CheckExternalEvents(cs8, 0x1B1A);
    // MOV SI,word ptr [BP + -0x26] (1000_1B17 / 0x11B17)
    SI = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x1B1C);
    // SHL SI,0x1 (1000_1B1A / 0x11B1A)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x1B1F);
    // MOV AX,0x1a (1000_1B1C / 0x11B1C)
    AX = 0x1A;
    CheckExternalEvents(cs8, 0x1B22);
    // IMUL word ptr [BP + -0x26] (1000_1B1F / 0x11B1F)
    int resImul1000_1B1F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x26)]);
    AX = (ushort)(resImul1000_1B1F);
    DX = (ushort)(resImul1000_1B1F >> 16);
    CheckExternalEvents(cs8, 0x1B24);
    // MOV DI,AX (1000_1B22 / 0x11B22)
    DI = AX;
    CheckExternalEvents(cs8, 0x1B28);
    // MOV ES,word ptr [0x55d2] (1000_1B24 / 0x11B24)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x1B2D);
    // MOV AX,word ptr ES:[SI + 0x4024] (1000_1B28 / 0x11B28)
    AX = UInt16[ES, (ushort)(SI + 0x4024)];
    CheckExternalEvents(cs8, 0x1B31);
    // MOV ES,word ptr [0x55d4] (1000_1B2D / 0x11B2D)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x1B36);
    // MOV word ptr ES:[DI + 0xd390],AX (1000_1B31 / 0x11B31)
    UInt16[ES, (ushort)(DI + 0xD390)] = AX;
    CheckExternalEvents(cs8, 0x1B3A);
    // MOV ES,word ptr [0x55d6] (1000_1B36 / 0x11B36)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x1B3F);
    // MOV AX,word ptr ES:[SI + 0x4056] (1000_1B3A / 0x11B3A)
    AX = UInt16[ES, (ushort)(SI + 0x4056)];
    CheckExternalEvents(cs8, 0x1B43);
    // MOV ES,word ptr [0x55d4] (1000_1B3F / 0x11B3F)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x1B48);
    // MOV word ptr ES:[DI + 0xd392],AX (1000_1B43 / 0x11B43)
    UInt16[ES, (ushort)(DI + 0xD392)] = AX;
    CheckExternalEvents(cs8, 0x1B4B);
    // INC word ptr [BP + -0x26] (1000_1B48 / 0x11B48)
    UInt16[SS, (ushort)(BP - 0x26)]++;
    CheckExternalEvents(cs8, 0x1B4F);
    // CMP word ptr [BP + -0x26],0x8 (1000_1B4B / 0x11B4B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x26)], 0x8);
    CheckExternalEvents(cs8, 0x1B51);
    // JL 0x1000:1b17 (1000_1B4F / 0x11B4F)
    if(SignFlag != OverflowFlag) {
      goto label_1000_1B17_11B17;
    }
    label_1000_1B51_11B51:
    CheckExternalEvents(cs8, 0x1B56);
    // MOV word ptr [BP + -0x26],0x0 (1000_1B51 / 0x11B51)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x0;
    CheckExternalEvents(cs8, 0x1B59);
    // JMP 0x1000:1c1e (1000_1B56 / 0x11B56)
    goto label_1000_1C1E_11C1E;
    label_1000_1B59_11B59:
    CheckExternalEvents(cs8, 0x1B5C);
    // INC word ptr [BP + -0x2a] (1000_1B59 / 0x11B59)
    UInt16[SS, (ushort)(BP - 0x2A)]++;
    label_1000_1B5C_11B5C:
    CheckExternalEvents(cs8, 0x1B60);
    // CMP word ptr [BP + -0x2a],0x18 (1000_1B5C / 0x11B5C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2A)], 0x18);
    CheckExternalEvents(cs8, 0x1B62);
    // JL 0x1000:1b65 (1000_1B60 / 0x11B60)
    if(SignFlag != OverflowFlag) {
      goto label_1000_1B65_11B65;
    }
    CheckExternalEvents(cs8, 0x1B65);
    // JMP 0x1000:1c1b (1000_1B62 / 0x11B62)
    goto label_1000_1C1B_11C1B;
    label_1000_1B65_11B65:
    CheckExternalEvents(cs8, 0x1B68);
    // MOV AX,0x18 (1000_1B65 / 0x11B65)
    AX = 0x18;
    CheckExternalEvents(cs8, 0x1B6B);
    // IMUL word ptr [BP + -0x26] (1000_1B68 / 0x11B68)
    int resImul1000_1B68 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x26)]);
    AX = (ushort)(resImul1000_1B68);
    DX = (ushort)(resImul1000_1B68 >> 16);
    CheckExternalEvents(cs8, 0x1B6D);
    // MOV SI,AX (1000_1B6B / 0x11B6B)
    SI = AX;
    CheckExternalEvents(cs8, 0x1B70);
    // ADD SI,word ptr [BP + -0x2a] (1000_1B6D / 0x11B6D)
    // SI += UInt16[SS, (ushort)(BP - 0x2A)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0x2A)]);
    CheckExternalEvents(cs8, 0x1B72);
    // MOV AL,0x2 (1000_1B70 / 0x11B70)
    AL = 0x2;
    CheckExternalEvents(cs8, 0x1B76);
    // MOV ES,word ptr [0x55d8] (1000_1B72 / 0x11B72)
    ES = UInt16[DS, 0x55D8];
    CheckExternalEvents(cs8, 0x1B7B);
    // MOV byte ptr ES:[SI + 0x41d4],AL (1000_1B76 / 0x11B76)
    UInt8[ES, (ushort)(SI + 0x41D4)] = AL;
    CheckExternalEvents(cs8, 0x1B80);
    // MOV byte ptr ES:[SI + 0x40b4],AL (1000_1B7B / 0x11B7B)
    UInt8[ES, (ushort)(SI + 0x40B4)] = AL;
    CheckExternalEvents(cs8, 0x1B84);
    // CMP word ptr [BP + -0x2a],0xc (1000_1B80 / 0x11B80)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2A)], 0xC);
    CheckExternalEvents(cs8, 0x1B86);
    // JGE 0x1000:1ba1 (1000_1B84 / 0x11B84)
    if(SignFlag == OverflowFlag) {
      goto label_1000_1BA1_11BA1;
    }
    CheckExternalEvents(cs8, 0x1B89);
    // MOV AX,0xc (1000_1B86 / 0x11B86)
    AX = 0xC;
    CheckExternalEvents(cs8, 0x1B8C);
    // IMUL word ptr [BP + -0x26] (1000_1B89 / 0x11B89)
    int resImul1000_1B89 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x26)]);
    AX = (ushort)(resImul1000_1B89);
    DX = (ushort)(resImul1000_1B89 >> 16);
    CheckExternalEvents(cs8, 0x1B8E);
    // MOV SI,AX (1000_1B8C / 0x11B8C)
    SI = AX;
    CheckExternalEvents(cs8, 0x1B91);
    // ADD SI,word ptr [BP + -0x2a] (1000_1B8E / 0x11B8E)
    // SI += UInt16[SS, (ushort)(BP - 0x2A)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0x2A)]);
    CheckExternalEvents(cs8, 0x1B93);
    // MOV AL,0xff (1000_1B91 / 0x11B91)
    AL = 0xFF;
    CheckExternalEvents(cs8, 0x1B97);
    // MOV ES,word ptr [0x55da] (1000_1B93 / 0x11B93)
    ES = UInt16[DS, 0x55DA];
    CheckExternalEvents(cs8, 0x1B9C);
    // MOV byte ptr ES:[SI + 0x3890],AL (1000_1B97 / 0x11B97)
    UInt8[ES, (ushort)(SI + 0x3890)] = AL;
    CheckExternalEvents(cs8, 0x1BA1);
    // MOV byte ptr ES:[SI + 0x3800],AL (1000_1B9C / 0x11B9C)
    UInt8[ES, (ushort)(SI + 0x3800)] = AL;
    label_1000_1BA1_11BA1:
    CheckExternalEvents(cs8, 0x1BA4);
    // MOV AX,0x30 (1000_1BA1 / 0x11BA1)
    AX = 0x30;
    CheckExternalEvents(cs8, 0x1BA7);
    // IMUL word ptr [BP + -0x26] (1000_1BA4 / 0x11BA4)
    int resImul1000_1BA4 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x26)]);
    AX = (ushort)(resImul1000_1BA4);
    DX = (ushort)(resImul1000_1BA4 >> 16);
    CheckExternalEvents(cs8, 0x1BA9);
    // MOV SI,AX (1000_1BA7 / 0x11BA7)
    SI = AX;
    CheckExternalEvents(cs8, 0x1BAC);
    // ADD SI,word ptr [BP + -0x2a] (1000_1BA9 / 0x11BA9)
    // SI += UInt16[SS, (ushort)(BP - 0x2A)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0x2A)]);
    CheckExternalEvents(cs8, 0x1BAE);
    // MOV AL,0xff (1000_1BAC / 0x11BAC)
    AL = 0xFF;
    CheckExternalEvents(cs8, 0x1BB2);
    // MOV ES,word ptr [0x55dc] (1000_1BAE / 0x11BAE)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs8, 0x1BB7);
    // MOV byte ptr ES:[SI + 0x351e],AL (1000_1BB2 / 0x11BB2)
    UInt8[ES, (ushort)(SI + 0x351E)] = AL;
    CheckExternalEvents(cs8, 0x1BBC);
    // MOV byte ptr ES:[SI + 0x32de],AL (1000_1BB7 / 0x11BB7)
    UInt8[ES, (ushort)(SI + 0x32DE)] = AL;
    CheckExternalEvents(cs8, 0x1BC1);
    // MOV byte ptr ES:[SI + 0x3506],AL (1000_1BBC / 0x11BBC)
    UInt8[ES, (ushort)(SI + 0x3506)] = AL;
    CheckExternalEvents(cs8, 0x1BC6);
    // MOV byte ptr ES:[SI + 0x32c6],AL (1000_1BC1 / 0x11BC1)
    UInt8[ES, (ushort)(SI + 0x32C6)] = AL;
    CheckExternalEvents(cs8, 0x1BCA);
    // CMP word ptr [BP + 0x6],0x0 (1000_1BC6 / 0x11BC6)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs8, 0x1BCC);
    // JNZ 0x1000:1b59 (1000_1BCA / 0x11BCA)
    if(!ZeroFlag) {
      goto label_1000_1B59_11B59;
    }
    CheckExternalEvents(cs8, 0x1BD0);
    // CMP word ptr [BP + -0x26],0x0 (1000_1BCC / 0x11BCC)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x26)], 0x0);
    CheckExternalEvents(cs8, 0x1BD2);
    // JNZ 0x1000:1b59 (1000_1BD0 / 0x11BD0)
    if(!ZeroFlag) {
      goto label_1000_1B59_11B59;
    }
    CheckExternalEvents(cs8, 0x1BD5);
    // MOV SI,word ptr [BP + -0x2a] (1000_1BD2 / 0x11BD2)
    SI = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs8, 0x1BD7);
    // SHL SI,0x1 (1000_1BD5 / 0x11BD5)
    SI <<= 0x1;
    CheckExternalEvents(cs8, 0x1BD9);
    // SUB AX,AX (1000_1BD7 / 0x11BD7)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x1BDD);
    // MOV ES,word ptr [0x55de] (1000_1BD9 / 0x11BD9)
    ES = UInt16[DS, 0x55DE];
    CheckExternalEvents(cs8, 0x1BE2);
    // MOV word ptr ES:[SI + 0x393c],AX (1000_1BDD / 0x11BDD)
    UInt16[ES, (ushort)(SI + 0x393C)] = AX;
    CheckExternalEvents(cs8, 0x1BE6);
    // MOV ES,word ptr [0x55e0] (1000_1BE2 / 0x11BE2)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x1BEB);
    // MOV word ptr ES:[SI + 0x406a],AX (1000_1BE6 / 0x11BE6)
    UInt16[ES, (ushort)(SI + 0x406A)] = AX;
    CheckExternalEvents(cs8, 0x1BEE);
    // MOV BX,word ptr [BP + -0x2a] (1000_1BEB / 0x11BEB)
    BX = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs8, 0x1BF2);
    // MOV ES,word ptr [0x55e2] (1000_1BEE / 0x11BEE)
    ES = UInt16[DS, 0x55E2];
    CheckExternalEvents(cs8, 0x1BF7);
    // MOV byte ptr ES:[BX + 0x32ae],AL (1000_1BF2 / 0x11BF2)
    UInt8[ES, (ushort)(BX + 0x32AE)] = AL;
    CheckExternalEvents(cs8, 0x1BF9);
    // MOV AL,0xff (1000_1BF7 / 0x11BF7)
    AL = 0xFF;
    CheckExternalEvents(cs8, 0x1BFC);
    // MOV BX,word ptr [BP + -0x2a] (1000_1BF9 / 0x11BF9)
    BX = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs8, 0x1C00);
    // MOV ES,word ptr [0x55e4] (1000_1BFC / 0x11BFC)
    ES = UInt16[DS, 0x55E4];
    CheckExternalEvents(cs8, 0x1C05);
    // MOV byte ptr ES:[BX + 0x3920],AL (1000_1C00 / 0x11C00)
    UInt8[ES, (ushort)(BX + 0x3920)] = AL;
    CheckExternalEvents(cs8, 0x1C06);
    // CBW  (1000_1C05 / 0x11C05)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x1C0A);
    // MOV ES,word ptr [0x55d6] (1000_1C06 / 0x11C06)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x1C0F);
    // MOV word ptr ES:[SI + 0x4036],AX (1000_1C0A / 0x11C0A)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs8, 0x1C13);
    // MOV ES,word ptr [0x55d2] (1000_1C0F / 0x11C0F)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x1C18);
    // MOV word ptr ES:[SI + 0x4004],AX (1000_1C13 / 0x11C13)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    CheckExternalEvents(cs8, 0x1C1B);
    // JMP 0x1000:1b59 (1000_1C18 / 0x11C18)
    goto label_1000_1B59_11B59;
    label_1000_1C1B_11C1B:
    CheckExternalEvents(cs8, 0x1C1E);
    // INC word ptr [BP + -0x26] (1000_1C1B / 0x11C1B)
    UInt16[SS, (ushort)(BP - 0x26)]++;
    label_1000_1C1E_11C1E:
    CheckExternalEvents(cs8, 0x1C22);
    // CMP word ptr [BP + -0x26],0xc (1000_1C1E / 0x11C1E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x26)], 0xC);
    CheckExternalEvents(cs8, 0x1C24);
    // JGE 0x1000:1c2c (1000_1C22 / 0x11C22)
    if(SignFlag == OverflowFlag) {
      goto label_1000_1C2C_11C2C;
    }
    CheckExternalEvents(cs8, 0x1C29);
    // MOV word ptr [BP + -0x2a],0x0 (1000_1C24 / 0x11C24)
    UInt16[SS, (ushort)(BP - 0x2A)] = 0x0;
    CheckExternalEvents(cs8, 0x1C2C);
    // JMP 0x1000:1b5c (1000_1C29 / 0x11C29)
    goto label_1000_1B5C_11B5C;
    label_1000_1C2C_11C2C:
    CheckExternalEvents(cs8, 0x1C31);
    // MOV word ptr [BP + -0x26],0x0 (1000_1C2C / 0x11C2C)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x0;
    label_1000_1C31_11C31:
    CheckExternalEvents(cs8, 0x1C33);
    // SUB AL,AL (1000_1C31 / 0x11C31)
    // AL -= AL;
    AL = Alu8.Sub(AL, AL);
    CheckExternalEvents(cs8, 0x1C36);
    // MOV BX,word ptr [BP + -0x26] (1000_1C33 / 0x11C33)
    BX = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x1C3A);
    // MOV ES,word ptr [0x55e6] (1000_1C36 / 0x11C36)
    ES = UInt16[DS, 0x55E6];
    CheckExternalEvents(cs8, 0x1C3F);
    // MOV byte ptr ES:[BX + 0x3998],AL (1000_1C3A / 0x11C3A)
    UInt8[ES, (ushort)(BX + 0x3998)] = AL;
    CheckExternalEvents(cs8, 0x1C42);
    // MOV BX,word ptr [BP + -0x26] (1000_1C3F / 0x11C3F)
    BX = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x1C47);
    // MOV byte ptr ES:[BX + 0x3994],AL (1000_1C42 / 0x11C42)
    UInt8[ES, (ushort)(BX + 0x3994)] = AL;
    CheckExternalEvents(cs8, 0x1C4A);
    // MOV BX,word ptr [BP + -0x26] (1000_1C47 / 0x11C47)
    BX = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x1C4E);
    // MOV ES,word ptr [0x55e8] (1000_1C4A / 0x11C4A)
    ES = UInt16[DS, 0x55E8];
    CheckExternalEvents(cs8, 0x1C53);
    // MOV byte ptr ES:[BX + 0xd576],AL (1000_1C4E / 0x11C4E)
    UInt8[ES, (ushort)(BX + 0xD576)] = AL;
    CheckExternalEvents(cs8, 0x1C56);
    // MOV BX,word ptr [BP + -0x26] (1000_1C53 / 0x11C53)
    BX = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x1C5A);
    // MOV ES,word ptr [0x55ea] (1000_1C56 / 0x11C56)
    ES = UInt16[DS, 0x55EA];
    CheckExternalEvents(cs8, 0x1C5F);
    // MOV byte ptr ES:[BX + 0x6e],AL (1000_1C5A / 0x11C5A)
    UInt8[ES, (ushort)(BX + 0x6E)] = AL;
    CheckExternalEvents(cs8, 0x1C62);
    // INC word ptr [BP + -0x26] (1000_1C5F / 0x11C5F)
    UInt16[SS, (ushort)(BP - 0x26)]++;
    CheckExternalEvents(cs8, 0x1C66);
    // CMP word ptr [BP + -0x26],0x8 (1000_1C62 / 0x11C62)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x26)], 0x8);
    CheckExternalEvents(cs8, 0x1C68);
    // JL 0x1000:1c31 (1000_1C66 / 0x11C66)
    if(SignFlag != OverflowFlag) {
      goto label_1000_1C31_11C31;
    }
    CheckExternalEvents(cs8, 0x1C6C);
    // MOV ES,word ptr [0x55cc] (1000_1C68 / 0x11C68)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x1C70);
    // MOV AX,ES:[0xa44b] (1000_1C6C / 0x11C6C)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs8, 0x1C73);
    // MOV word ptr [BP + -0x28],AX (1000_1C70 / 0x11C70)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs8, 0x1C77);
    // MOV ES,word ptr [0x55ce] (1000_1C73 / 0x11C73)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x1C7B);
    // MOV AX,ES:[0xa44d] (1000_1C77 / 0x11C77)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs8, 0x1C7E);
    // MOV word ptr [BP + -0x2e],AX (1000_1C7B / 0x11C7B)
    UInt16[SS, (ushort)(BP - 0x2E)] = AX;
    CheckExternalEvents(cs8, 0x1C80);
    // SUB AX,AX (1000_1C7E / 0x11C7E)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x1C83);
    // MOV word ptr [BP + -0x38],AX (1000_1C80 / 0x11C80)
    UInt16[SS, (ushort)(BP - 0x38)] = AX;
    CheckExternalEvents(cs8, 0x1C86);
    // MOV word ptr [BP + -0x22],AX (1000_1C83 / 0x11C83)
    UInt16[SS, (ushort)(BP - 0x22)] = AX;
    CheckExternalEvents(cs8, 0x1C89);
    // MOV word ptr [BP + -0x10],AX (1000_1C86 / 0x11C86)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs8, 0x1C8C);
    // MOV word ptr [BP + -0x2c],AX (1000_1C89 / 0x11C89)
    UInt16[SS, (ushort)(BP - 0x2C)] = AX;
    label_1000_1C8C_11C8C:
    CheckExternalEvents(cs8, 0x1C8F);
    // MOV AX,0x11 (1000_1C8C / 0x11C8C)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x1C92);
    // IMUL word ptr [BP + -0x2c] (1000_1C8F / 0x11C8F)
    int resImul1000_1C8F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_1C8F);
    DX = (ushort)(resImul1000_1C8F >> 16);
    CheckExternalEvents(cs8, 0x1C94);
    // MOV SI,AX (1000_1C92 / 0x11C92)
    SI = AX;
    CheckExternalEvents(cs8, 0x1C98);
    // MOV ES,word ptr [0x55d4] (1000_1C94 / 0x11C94)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x1C9E);
    // CMP byte ptr ES:[SI + 0xc614],0xff (1000_1C98 / 0x11C98)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0xC614)], 0xFF);
    CheckExternalEvents(cs8, 0x1CA0);
    // JZ 0x1000:1d00 (1000_1C9E / 0x11C9E)
    if(ZeroFlag) {
      goto label_1000_1D00_11D00;
    }
    CheckExternalEvents(cs8, 0x1CA6);
    // CMP byte ptr ES:[SI + 0xc620],0x8 (1000_1CA0 / 0x11CA0)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0xC620)], 0x8);
    CheckExternalEvents(cs8, 0x1CA8);
    // JL 0x1000:1d00 (1000_1CA6 / 0x11CA6)
    if(SignFlag != OverflowFlag) {
      goto label_1000_1D00_11D00;
    }
    CheckExternalEvents(cs8, 0x1CAB);
    // MOV BX,word ptr [BP + -0x10] (1000_1CA8 / 0x11CA8)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs8, 0x1CAF);
    // MOV AL,byte ptr [BX + 0x3a1e] (1000_1CAB / 0x11CAB)
    AL = UInt8[DS, (ushort)(BX + 0x3A1E)];
    CheckExternalEvents(cs8, 0x1CB0);
    // CBW  (1000_1CAF / 0x11CAF)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x1CB1);
    // PUSH AX (1000_1CB0 / 0x11CB0)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1CB5);
    // MOV AL,byte ptr [BX + 0x3a16] (1000_1CB1 / 0x11CB1)
    AL = UInt8[DS, (ushort)(BX + 0x3A16)];
    CheckExternalEvents(cs8, 0x1CB6);
    // CBW  (1000_1CB5 / 0x11CB5)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x1CB7);
    // PUSH AX (1000_1CB6 / 0x11CB6)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1CBC);
    // CALLF 0x0000:301b (1000_1CB7 / 0x11CB7)
    FarCall(cs8, 0x1CBC, unknown_0170_191B_0301B);
    CheckExternalEvents(cs8, 0x1CBF);
    // ADD SP,0x4 (1000_1CBC / 0x11CBC)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x1CC2);
    // MOV SI,word ptr [BP + -0x2c] (1000_1CBF / 0x11CBF)
    SI = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x1CC4);
    // SHL SI,0x1 (1000_1CC2 / 0x11CC2)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x1CC8);
    // MOV ES,word ptr [0x55cc] (1000_1CC4 / 0x11CC4)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x1CCC);
    // MOV AX,ES:[0xa44b] (1000_1CC8 / 0x11CC8)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs8, 0x1CD0);
    // MOV ES,word ptr [0x55d2] (1000_1CCC / 0x11CCC)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x1CD5);
    // MOV word ptr ES:[SI + 0x400c],AX (1000_1CD0 / 0x11CD0)
    UInt16[ES, (ushort)(SI + 0x400C)] = AX;
    CheckExternalEvents(cs8, 0x1CD9);
    // MOV ES,word ptr [0x55ce] (1000_1CD5 / 0x11CD5)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x1CDD);
    // MOV AX,ES:[0xa44d] (1000_1CD9 / 0x11CD9)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs8, 0x1CE1);
    // MOV ES,word ptr [0x55d6] (1000_1CDD / 0x11CDD)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x1CE6);
    // MOV word ptr ES:[SI + 0x403e],AX (1000_1CE1 / 0x11CE1)
    UInt16[ES, (ushort)(SI + 0x403E)] = AX;
    CheckExternalEvents(cs8, 0x1CEA);
    // MOV ES,word ptr [0x55e0] (1000_1CE6 / 0x11CE6)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x1CEF);
    // INC word ptr ES:[SI + 0x4072] (1000_1CEA / 0x11CEA)
    UInt16[ES, (ushort)(SI + 0x4072)] = Alu16.Inc(UInt16[ES, (ushort)(SI + 0x4072)]);
    CheckExternalEvents(cs8, 0x1CF2);
    // PUSH word ptr [BP + -0x2e] (1000_1CEF / 0x11CEF)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2E)]);
    CheckExternalEvents(cs8, 0x1CF5);
    // PUSH word ptr [BP + -0x28] (1000_1CF2 / 0x11CF2)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs8, 0x1CFA);
    // CALLF 0x0000:2f6f (1000_1CF5 / 0x11CF5)
    FarCall(cs8, 0x1CFA, ghidra_guess_0000_2F6F_02F6F);
    CheckExternalEvents(cs8, 0x1CFD);
    // ADD SP,0x4 (1000_1CFA / 0x11CFA)
    SP += 0x4;
    CheckExternalEvents(cs8, 0x1D00);
    // INC word ptr [BP + -0x10] (1000_1CFD / 0x11CFD)
    UInt16[SS, (ushort)(BP - 0x10)]++;
    label_1000_1D00_11D00:
    CheckExternalEvents(cs8, 0x1D03);
    // INC word ptr [BP + -0x2c] (1000_1D00 / 0x11D00)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x1D07);
    // CMP word ptr [BP + -0x2c],0x8 (1000_1D03 / 0x11D03)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x8);
    CheckExternalEvents(cs8, 0x1D09);
    // JL 0x1000:1c8c (1000_1D07 / 0x11D07)
    if(SignFlag != OverflowFlag) {
      goto label_1000_1C8C_11C8C;
    }
    CheckExternalEvents(cs8, 0x1D0E);
    // MOV word ptr [BP + -0x2c],0x0 (1000_1D09 / 0x11D09)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_1000_1D0E_11D0E:
    CheckExternalEvents(cs8, 0x1D11);
    // MOV AX,0x7d (1000_1D0E / 0x11D0E)
    AX = 0x7D;
    CheckExternalEvents(cs8, 0x1D14);
    // IMUL word ptr [BP + -0x2c] (1000_1D11 / 0x11D11)
    int resImul1000_1D11 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_1D11);
    DX = (ushort)(resImul1000_1D11 >> 16);
    CheckExternalEvents(cs8, 0x1D16);
    // MOV BX,AX (1000_1D14 / 0x11D14)
    BX = AX;
    CheckExternalEvents(cs8, 0x1D1A);
    // MOV ES,word ptr [0x55d4] (1000_1D16 / 0x11D16)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x1D20);
    // CMP byte ptr ES:[BX + 0xc724],0xff (1000_1D1A / 0x11D1A)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs8, 0x1D22);
    // JZ 0x1000:1d82 (1000_1D20 / 0x11D20)
    if(ZeroFlag) {
      goto label_1000_1D82_11D82;
    }
    CheckExternalEvents(cs8, 0x1D25);
    // MOV BX,word ptr [BP + -0x22] (1000_1D22 / 0x11D22)
    BX = UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs8, 0x1D29);
    // MOV AL,byte ptr [BX + 0x3a26] (1000_1D25 / 0x11D25)
    AL = UInt8[DS, (ushort)(BX + 0x3A26)];
    CheckExternalEvents(cs8, 0x1D2A);
    // CBW  (1000_1D29 / 0x11D29)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x1D2D);
    // MOV word ptr [BP + -0x26],AX (1000_1D2A / 0x11D2A)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    CheckExternalEvents(cs8, 0x1D31);
    // MOV AL,byte ptr [BX + 0x3a2a] (1000_1D2D / 0x11D2D)
    AL = UInt8[DS, (ushort)(BX + 0x3A2A)];
    CheckExternalEvents(cs8, 0x1D32);
    // CBW  (1000_1D31 / 0x11D31)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x1D35);
    // MOV word ptr [BP + -0x2a],AX (1000_1D32 / 0x11D32)
    UInt16[SS, (ushort)(BP - 0x2A)] = AX;
    CheckExternalEvents(cs8, 0x1D38);
    // INC word ptr [BP + -0x22] (1000_1D35 / 0x11D35)
    UInt16[SS, (ushort)(BP - 0x22)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x22)]);
    CheckExternalEvents(cs8, 0x1D39);
    // PUSH AX (1000_1D38 / 0x11D38)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1D3C);
    // PUSH word ptr [BP + -0x26] (1000_1D39 / 0x11D39)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs8, 0x1D41);
    // CALLF 0x0000:301b (1000_1D3C / 0x11D3C)
    FarCall(cs8, 0x1D41, unknown_0170_191B_0301B);
    CheckExternalEvents(cs8, 0x1D44);
    // ADD SP,0x4 (1000_1D41 / 0x11D41)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x1D47);
    // MOV SI,word ptr [BP + -0x2c] (1000_1D44 / 0x11D44)
    SI = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x1D49);
    // SHL SI,0x1 (1000_1D47 / 0x11D47)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x1D4D);
    // MOV ES,word ptr [0x55cc] (1000_1D49 / 0x11D49)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x1D51);
    // MOV AX,ES:[0xa44b] (1000_1D4D / 0x11D4D)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs8, 0x1D55);
    // MOV ES,word ptr [0x55d2] (1000_1D51 / 0x11D51)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x1D5A);
    // MOV word ptr ES:[SI + 0x4004],AX (1000_1D55 / 0x11D55)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    CheckExternalEvents(cs8, 0x1D5E);
    // MOV ES,word ptr [0x55ce] (1000_1D5A / 0x11D5A)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x1D62);
    // MOV AX,ES:[0xa44d] (1000_1D5E / 0x11D5E)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs8, 0x1D66);
    // MOV ES,word ptr [0x55d6] (1000_1D62 / 0x11D62)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x1D6B);
    // MOV word ptr ES:[SI + 0x4036],AX (1000_1D66 / 0x11D66)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs8, 0x1D6F);
    // MOV ES,word ptr [0x55e0] (1000_1D6B / 0x11D6B)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x1D74);
    // INC word ptr ES:[SI + 0x406a] (1000_1D6F / 0x11D6F)
    UInt16[ES, (ushort)(SI + 0x406A)] = Alu16.Inc(UInt16[ES, (ushort)(SI + 0x406A)]);
    CheckExternalEvents(cs8, 0x1D77);
    // PUSH word ptr [BP + -0x2e] (1000_1D74 / 0x11D74)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2E)]);
    CheckExternalEvents(cs8, 0x1D7A);
    // PUSH word ptr [BP + -0x28] (1000_1D77 / 0x11D77)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs8, 0x1D7F);
    // CALLF 0x0000:2f6f (1000_1D7A / 0x11D7A)
    FarCall(cs8, 0x1D7F, ghidra_guess_0000_2F6F_02F6F);
    CheckExternalEvents(cs8, 0x1D82);
    // ADD SP,0x4 (1000_1D7F / 0x11D7F)
    SP += 0x4;
    label_1000_1D82_11D82:
    CheckExternalEvents(cs8, 0x1D85);
    // INC word ptr [BP + -0x2c] (1000_1D82 / 0x11D82)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x1D89);
    // CMP word ptr [BP + -0x2c],0x4 (1000_1D85 / 0x11D85)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x4);
    CheckExternalEvents(cs8, 0x1D8B);
    // JL 0x1000:1d0e (1000_1D89 / 0x11D89)
    if(SignFlag != OverflowFlag) {
      goto label_1000_1D0E_11D0E;
    }
    CheckExternalEvents(cs8, 0x1D8F);
    // CMP word ptr [BP + 0x6],0x0 (1000_1D8B / 0x11D8B)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs8, 0x1D91);
    // JZ 0x1000:1d94 (1000_1D8F / 0x11D8F)
    if(ZeroFlag) {
      goto label_1000_1D94_11D94;
    }
    CheckExternalEvents(cs8, 0x1D94);
    // JMP 0x1000:1f21 (1000_1D91 / 0x11D91)
    goto label_1000_1F21_11F21;
    label_1000_1D94_11D94:
    CheckExternalEvents(cs8, 0x1D99);
    // CALLF 0x0000:7eed (1000_1D94 / 0x11D94)
    FarCall(cs8, 0x1D99, ghidra_guess_0000_7EED_07EED);
    CheckExternalEvents(cs8, 0x1D9C);
    // MOV AX,0x4 (1000_1D99 / 0x11D99)
    AX = 0x4;
    CheckExternalEvents(cs8, 0x1D9D);
    // PUSH AX (1000_1D9C / 0x11D9C)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1DA2);
    // CALLF 0x1000:7ee1 (1000_1D9D / 0x11D9D)
    FarCall(cs8, 0x1DA2, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs8, 0x1DA5);
    // ADD SP,0x2 (1000_1DA2 / 0x11DA2)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x1DAA);
    // CALLF 0x1000:7fe8 (1000_1DA5 / 0x11DA5)
    FarCall(cs8, 0x1DAA, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs8, 0x1DAE);
    // MOV ES,word ptr [0x55ec] (1000_1DAA / 0x11DAA)
    ES = UInt16[DS, 0x55EC];
    CheckExternalEvents(cs8, 0x1DB5);
    // MOV word ptr ES:[0x37fe],0xf (1000_1DAE / 0x11DAE)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs8, 0x1DB7);
    // SUB AX,AX (1000_1DB5 / 0x11DB5)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x1DBA);
    // MOV word ptr [BP + -0xa],AX (1000_1DB7 / 0x11DB7)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs8, 0x1DBD);
    // MOV word ptr [BP + -0x12],AX (1000_1DBA / 0x11DBA)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs8, 0x1DC2);
    // MOV word ptr [BP + -0x2c],0xc (1000_1DBD / 0x11DBD)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0xC;
    label_1000_1DC2_11DC2:
    CheckExternalEvents(cs8, 0x1DC5);
    // MOV SI,word ptr [BP + -0x2c] (1000_1DC2 / 0x11DC2)
    SI = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x1DC7);
    // SHL SI,0x1 (1000_1DC5 / 0x11DC5)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x1DCB);
    // MOV ES,word ptr [0x55e0] (1000_1DC7 / 0x11DC7)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x1DD1);
    // CMP word ptr ES:[SI + 0x406a],0x0 (1000_1DCB / 0x11DCB)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x406A)], 0x0);
    CheckExternalEvents(cs8, 0x1DD3);
    // JZ 0x1000:1df0 (1000_1DD1 / 0x11DD1)
    if(ZeroFlag) {
      goto label_1000_1DF0_11DF0;
    }
    CheckExternalEvents(cs8, 0x1DD7);
    // MOV ES,word ptr [0x55d2] (1000_1DD3 / 0x11DD3)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x1DDD);
    // CMP word ptr ES:[SI + 0x4004],-0x1 (1000_1DD7 / 0x11DD7)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4004)], 0xFFFF);
    CheckExternalEvents(cs8, 0x1DDF);
    // JZ 0x1000:1df0 (1000_1DDD / 0x11DDD)
    if(ZeroFlag) {
      goto label_1000_1DF0_11DF0;
    }
    CheckExternalEvents(cs8, 0x1DE3);
    // MOV ES,word ptr [0x55d6] (1000_1DDF / 0x11DDF)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x1DE9);
    // CMP word ptr ES:[SI + 0x4036],-0x1 (1000_1DE3 / 0x11DE3)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4036)], 0xFFFF);
    CheckExternalEvents(cs8, 0x1DEB);
    // JZ 0x1000:1df0 (1000_1DE9 / 0x11DE9)
    if(ZeroFlag) {
      goto label_1000_1DF0_11DF0;
    }
    CheckExternalEvents(cs8, 0x1DF0);
    // MOV word ptr [BP + -0xa],0x1 (1000_1DEB / 0x11DEB)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x1;
    label_1000_1DF0_11DF0:
    CheckExternalEvents(cs8, 0x1DF3);
    // INC word ptr [BP + -0x2c] (1000_1DF0 / 0x11DF0)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x1DF7);
    // CMP word ptr [BP + -0x2c],0x18 (1000_1DF3 / 0x11DF3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x18);
    CheckExternalEvents(cs8, 0x1DF9);
    // JL 0x1000:1dc2 (1000_1DF7 / 0x11DF7)
    if(SignFlag != OverflowFlag) {
      goto label_1000_1DC2_11DC2;
    }
    CheckExternalEvents(cs8, 0x1DFD);
    // CMP word ptr [BP + -0xa],0x0 (1000_1DF9 / 0x11DF9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x0);
    CheckExternalEvents(cs8, 0x1DFF);
    // JZ 0x1000:1e06 (1000_1DFD / 0x11DFD)
    if(ZeroFlag) {
      goto label_1000_1E06_11E06;
    }
    CheckExternalEvents(cs8, 0x1E00);
    // PUSH CS (1000_1DFF / 0x11DFF)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x1E03);
    // CALL 0x1000:438b (1000_1E00 / 0x11E00)
    NearCall(cs8, 0x1E03, ghidra_guess_1000_438B_1438B);
    CheckExternalEvents(cs8, 0x1E06);
    // MOV word ptr [BP + -0xa],AX (1000_1E03 / 0x11E03)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    label_1000_1E06_11E06:
    CheckExternalEvents(cs8, 0x1E0A);
    // CMP word ptr [BP + -0xa],0x0 (1000_1E06 / 0x11E06)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x0);
    CheckExternalEvents(cs8, 0x1E0C);
    // JNZ 0x1000:1e0f (1000_1E0A / 0x11E0A)
    if(!ZeroFlag) {
      goto label_1000_1E0F_11E0F;
    }
    CheckExternalEvents(cs8, 0x1E0F);
    // JMP 0x1000:1f26 (1000_1E0C / 0x11E0C)
    goto label_1000_1F26_11F26;
    label_1000_1E0F_11E0F:
    CheckExternalEvents(cs8, 0x1E12);
    // MOV AX,0x3402 (1000_1E0F / 0x11E0F)
    AX = 0x3402;
    CheckExternalEvents(cs8, 0x1E13);
    // PUSH DS (1000_1E12 / 0x11E12)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x1E14);
    // PUSH AX (1000_1E13 / 0x11E13)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1E19);
    // CALLF 0x1000:8055 (1000_1E14 / 0x11E14)
    FarCall(cs8, 0x1E19, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x1E1C);
    // ADD SP,0x4 (1000_1E19 / 0x11E19)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x1E21);
    // MOV word ptr [BP + -0x2c],0x4 (1000_1E1C / 0x11E1C)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x4;
    label_1000_1E21_11E21:
    CheckExternalEvents(cs8, 0x1E24);
    // MOV AX,0x7d (1000_1E21 / 0x11E21)
    AX = 0x7D;
    CheckExternalEvents(cs8, 0x1E27);
    // IMUL word ptr [BP + -0x2c] (1000_1E24 / 0x11E24)
    int resImul1000_1E24 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_1E24);
    DX = (ushort)(resImul1000_1E24 >> 16);
    CheckExternalEvents(cs8, 0x1E29);
    // MOV BX,AX (1000_1E27 / 0x11E27)
    BX = AX;
    CheckExternalEvents(cs8, 0x1E2D);
    // MOV ES,word ptr [0x55d4] (1000_1E29 / 0x11E29)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x1E33);
    // CMP byte ptr ES:[BX + 0xc724],0xff (1000_1E2D / 0x11E2D)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs8, 0x1E35);
    // JZ 0x1000:1e38 (1000_1E33 / 0x11E33)
    if(ZeroFlag) {
      goto label_1000_1E38_11E38;
    }
    CheckExternalEvents(cs8, 0x1E38);
    // INC word ptr [BP + -0x12] (1000_1E35 / 0x11E35)
    UInt16[SS, (ushort)(BP - 0x12)]++;
    label_1000_1E38_11E38:
    CheckExternalEvents(cs8, 0x1E3B);
    // INC word ptr [BP + -0x2c] (1000_1E38 / 0x11E38)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x1E3F);
    // CMP word ptr [BP + -0x2c],0x8 (1000_1E3B / 0x11E3B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x8);
    CheckExternalEvents(cs8, 0x1E41);
    // JL 0x1000:1e21 (1000_1E3F / 0x11E3F)
    if(SignFlag != OverflowFlag) {
      goto label_1000_1E21_11E21;
    }
    CheckExternalEvents(cs8, 0x1E45);
    // CMP word ptr [BP + -0x12],0x0 (1000_1E41 / 0x11E41)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs8, 0x1E47);
    // JZ 0x1000:1e77 (1000_1E45 / 0x11E45)
    if(ZeroFlag) {
      goto label_1000_1E77_11E77;
    }
    CheckExternalEvents(cs8, 0x1E4A);
    // PUSH word ptr [BP + -0x12] (1000_1E47 / 0x11E47)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs8, 0x1E4F);
    // CALLF 0x1000:8b23 (1000_1E4A / 0x11E4A)
    FarCall(cs8, 0x1E4F, ghidra_guess_1000_8B23_18B23);
    CheckExternalEvents(cs8, 0x1E52);
    // ADD SP,0x2 (1000_1E4F / 0x11E4F)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x1E55);
    // MOV AX,0x3414 (1000_1E52 / 0x11E52)
    AX = 0x3414;
    CheckExternalEvents(cs8, 0x1E56);
    // PUSH DS (1000_1E55 / 0x11E55)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x1E57);
    // PUSH AX (1000_1E56 / 0x11E56)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1E5C);
    // CALLF 0x1000:8055 (1000_1E57 / 0x11E57)
    FarCall(cs8, 0x1E5C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x1E5F);
    // ADD SP,0x4 (1000_1E5C / 0x11E5C)
    SP += 0x4;
    CheckExternalEvents(cs8, 0x1E63);
    // CMP word ptr [BP + -0x12],0x1 (1000_1E5F / 0x11E5F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x1);
    CheckExternalEvents(cs8, 0x1E65);
    // JLE 0x1000:1e6a (1000_1E63 / 0x11E63)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_1E6A_11E6A;
    }
    CheckExternalEvents(cs8, 0x1E6A);
    // CALLF 0x0000:4169 (1000_1E65 / 0x11E65)
    FarCall(cs8, 0x1E6A, ghidra_guess_0000_4169_04169);
    label_1000_1E6A_11E6A:
    CheckExternalEvents(cs8, 0x1E6D);
    // MOV AX,0x341b (1000_1E6A / 0x11E6A)
    AX = 0x341B;
    CheckExternalEvents(cs8, 0x1E6E);
    // PUSH DS (1000_1E6D / 0x11E6D)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x1E6F);
    // PUSH AX (1000_1E6E / 0x11E6E)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1E74);
    // CALLF 0x1000:8055 (1000_1E6F / 0x11E6F)
    FarCall(cs8, 0x1E74, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x1E77);
    // ADD SP,0x4 (1000_1E74 / 0x11E74)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_1E77_11E77:
    CheckExternalEvents(cs8, 0x1E7C);
    // MOV word ptr [BP + -0x12],0x0 (1000_1E77 / 0x11E77)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    CheckExternalEvents(cs8, 0x1E81);
    // MOV word ptr [BP + -0x2c],0x8 (1000_1E7C / 0x11E7C)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x8;
    label_1000_1E81_11E81:
    CheckExternalEvents(cs8, 0x1E84);
    // MOV AX,0x11 (1000_1E81 / 0x11E81)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x1E87);
    // IMUL word ptr [BP + -0x2c] (1000_1E84 / 0x11E84)
    int resImul1000_1E84 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_1E84);
    DX = (ushort)(resImul1000_1E84 >> 16);
    CheckExternalEvents(cs8, 0x1E89);
    // MOV BX,AX (1000_1E87 / 0x11E87)
    BX = AX;
    CheckExternalEvents(cs8, 0x1E8D);
    // MOV ES,word ptr [0x55d4] (1000_1E89 / 0x11E89)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x1E93);
    // CMP byte ptr ES:[BX + 0xc614],0xff (1000_1E8D / 0x11E8D)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC614)], 0xFF);
    CheckExternalEvents(cs8, 0x1E95);
    // JZ 0x1000:1ec1 (1000_1E93 / 0x11E93)
    if(ZeroFlag) {
      goto label_1000_1EC1_11EC1;
    }
    CheckExternalEvents(cs8, 0x1E98);
    // MOV SI,word ptr [BP + -0x2c] (1000_1E95 / 0x11E95)
    SI = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x1E9A);
    // SHL SI,0x1 (1000_1E98 / 0x11E98)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x1E9E);
    // MOV ES,word ptr [0x55e0] (1000_1E9A / 0x11E9A)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x1EA4);
    // CMP word ptr ES:[SI + 0x407a],0x0 (1000_1E9E / 0x11E9E)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x407A)], 0x0);
    CheckExternalEvents(cs8, 0x1EA6);
    // JZ 0x1000:1ec1 (1000_1EA4 / 0x11EA4)
    if(ZeroFlag) {
      goto label_1000_1EC1_11EC1;
    }
    CheckExternalEvents(cs8, 0x1EAA);
    // MOV ES,word ptr [0x55d2] (1000_1EA6 / 0x11EA6)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x1EB0);
    // CMP word ptr ES:[SI + 0x4014],-0x1 (1000_1EAA / 0x11EAA)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4014)], 0xFFFF);
    CheckExternalEvents(cs8, 0x1EB2);
    // JZ 0x1000:1ec1 (1000_1EB0 / 0x11EB0)
    if(ZeroFlag) {
      goto label_1000_1EC1_11EC1;
    }
    CheckExternalEvents(cs8, 0x1EB6);
    // MOV ES,word ptr [0x55d6] (1000_1EB2 / 0x11EB2)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x1EBC);
    // CMP word ptr ES:[SI + 0x4046],-0x1 (1000_1EB6 / 0x11EB6)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4046)], 0xFFFF);
    CheckExternalEvents(cs8, 0x1EBE);
    // JZ 0x1000:1ec1 (1000_1EBC / 0x11EBC)
    if(ZeroFlag) {
      goto label_1000_1EC1_11EC1;
    }
    CheckExternalEvents(cs8, 0x1EC1);
    // INC word ptr [BP + -0x12] (1000_1EBE / 0x11EBE)
    UInt16[SS, (ushort)(BP - 0x12)]++;
    label_1000_1EC1_11EC1:
    CheckExternalEvents(cs8, 0x1EC4);
    // INC word ptr [BP + -0x2c] (1000_1EC1 / 0x11EC1)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x1EC8);
    // CMP word ptr [BP + -0x2c],0x10 (1000_1EC4 / 0x11EC4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x10);
    CheckExternalEvents(cs8, 0x1ECA);
    // JL 0x1000:1e81 (1000_1EC8 / 0x11EC8)
    if(SignFlag != OverflowFlag) {
      goto label_1000_1E81_11E81;
    }
    CheckExternalEvents(cs8, 0x1ECD);
    // PUSH word ptr [BP + -0x12] (1000_1ECA / 0x11ECA)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs8, 0x1ED2);
    // CALLF 0x1000:8b23 (1000_1ECD / 0x11ECD)
    FarCall(cs8, 0x1ED2, ghidra_guess_1000_8B23_18B23);
    CheckExternalEvents(cs8, 0x1ED5);
    // ADD SP,0x2 (1000_1ED2 / 0x11ED2)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x1ED8);
    // MOV AX,0x3421 (1000_1ED5 / 0x11ED5)
    AX = 0x3421;
    CheckExternalEvents(cs8, 0x1ED9);
    // PUSH DS (1000_1ED8 / 0x11ED8)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x1EDA);
    // PUSH AX (1000_1ED9 / 0x11ED9)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1EDF);
    // CALLF 0x1000:8055 (1000_1EDA / 0x11EDA)
    FarCall(cs8, 0x1EDF, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x1EE2);
    // ADD SP,0x4 (1000_1EDF / 0x11EDF)
    SP += 0x4;
    CheckExternalEvents(cs8, 0x1EE6);
    // CMP word ptr [BP + -0x12],0x1 (1000_1EE2 / 0x11EE2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x1);
    CheckExternalEvents(cs8, 0x1EE8);
    // JZ 0x1000:1eed (1000_1EE6 / 0x11EE6)
    if(ZeroFlag) {
      goto label_1000_1EED_11EED;
    }
    CheckExternalEvents(cs8, 0x1EED);
    // CALLF 0x0000:4169 (1000_1EE8 / 0x11EE8)
    FarCall(cs8, 0x1EED, ghidra_guess_0000_4169_04169);
    label_1000_1EED_11EED:
    CheckExternalEvents(cs8, 0x1EF2);
    // CALLF 0x0000:417e (1000_1EED / 0x11EED)
    FarCall(cs8, 0x1EF2, ghidra_guess_0000_417E_0417E);
    CheckExternalEvents(cs8, 0x1EF5);
    // MOV AX,0x3 (1000_1EF2 / 0x11EF2)
    AX = 0x3;
    CheckExternalEvents(cs8, 0x1EF6);
    // PUSH AX (1000_1EF5 / 0x11EF5)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1EFB);
    // CALLF 0x1000:7ee1 (1000_1EF6 / 0x11EF6)
    FarCall(cs8, 0x1EFB, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs8, 0x1EFE);
    // ADD SP,0x2 (1000_1EFB / 0x11EFB)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x1F03);
    // CALLF 0x1000:7fe8 (1000_1EFE / 0x11EFE)
    FarCall(cs8, 0x1F03, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs8, 0x1F06);
    // MOV AX,0x3428 (1000_1F03 / 0x11F03)
    AX = 0x3428;
    CheckExternalEvents(cs8, 0x1F07);
    // PUSH DS (1000_1F06 / 0x11F06)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x1F08);
    // PUSH AX (1000_1F07 / 0x11F07)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1F0D);
    // CALLF 0x1000:8055 (1000_1F08 / 0x11F08)
    FarCall(cs8, 0x1F0D, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x1F10);
    // ADD SP,0x4 (1000_1F0D / 0x11F0D)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x1F13);
    // MOV AX,0x1 (1000_1F10 / 0x11F10)
    AX = 0x1;
    CheckExternalEvents(cs8, 0x1F14);
    // PUSH AX (1000_1F13 / 0x11F13)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1F19);
    // CALLF 0x0000:3113 (1000_1F14 / 0x11F14)
    FarCall(cs8, 0x1F19, unknown_0170_1A13_03113);
    CheckExternalEvents(cs8, 0x1F1C);
    // ADD SP,0x2 (1000_1F19 / 0x11F19)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x1F1F);
    // MOV word ptr [BP + -0x6],AX (1000_1F1C / 0x11F1C)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs8, 0x1F21);
    // JMP 0x1000:1f26 (1000_1F1F / 0x11F1F)
    goto label_1000_1F26_11F26;
    label_1000_1F21_11F21:
    CheckExternalEvents(cs8, 0x1F26);
    // MOV word ptr [BP + -0x6],0x1 (1000_1F21 / 0x11F21)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    label_1000_1F26_11F26:
    CheckExternalEvents(cs8, 0x1F2A);
    // CMP word ptr [BP + 0x6],0x0 (1000_1F26 / 0x11F26)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs8, 0x1F2C);
    // JZ 0x1000:1f31 (1000_1F2A / 0x11F2A)
    if(ZeroFlag) {
      goto label_1000_1F31_11F31;
    }
    CheckExternalEvents(cs8, 0x1F31);
    // MOV word ptr [BP + -0xa],0x1 (1000_1F2C / 0x11F2C)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x1;
    label_1000_1F31_11F31:
    CheckExternalEvents(cs8, 0x1F35);
    // CMP word ptr [BP + -0xa],0x0 (1000_1F31 / 0x11F31)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x0);
    CheckExternalEvents(cs8, 0x1F37);
    // JNZ 0x1000:1f3a (1000_1F35 / 0x11F35)
    if(!ZeroFlag) {
      goto label_1000_1F3A_11F3A;
    }
    CheckExternalEvents(cs8, 0x1F3A);
    // JMP 0x1000:2ae7 (1000_1F37 / 0x11F37)
    goto label_1000_2AE7_12AE7;
    label_1000_1F3A_11F3A:
    CheckExternalEvents(cs8, 0x1F3E);
    // CMP word ptr [BP + -0x6],0x0 (1000_1F3A / 0x11F3A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs8, 0x1F40);
    // JNZ 0x1000:1f4c (1000_1F3E / 0x11F3E)
    if(!ZeroFlag) {
      goto label_1000_1F4C_11F4C;
    }
    CheckExternalEvents(cs8, 0x1F45);
    // CALLF 0x1000:aab0 (1000_1F40 / 0x11F40)
    FarCall(cs8, 0x1F45, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs8, 0x1F47);
    // TEST AL,0x3 (1000_1F45 / 0x11F45)
    Alu8.And(AL, 0x3);
    CheckExternalEvents(cs8, 0x1F49);
    // JZ 0x1000:1f4c (1000_1F47 / 0x11F47)
    if(ZeroFlag) {
      goto label_1000_1F4C_11F4C;
    }
    CheckExternalEvents(cs8, 0x1F4C);
    // JMP 0x1000:2ae7 (1000_1F49 / 0x11F49)
    goto label_1000_2AE7_12AE7;
    label_1000_1F4C_11F4C:
    CheckExternalEvents(cs8, 0x1F50);
    // CMP word ptr [BP + -0x6],0x0 (1000_1F4C / 0x11F4C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs8, 0x1F52);
    // JNZ 0x1000:1f6e (1000_1F50 / 0x11F50)
    if(!ZeroFlag) {
      goto label_1000_1F6E_11F6E;
    }
    CheckExternalEvents(cs8, 0x1F57);
    // CALLF 0x1000:7fe8 (1000_1F52 / 0x11F52)
    FarCall(cs8, 0x1F57, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs8, 0x1F5A);
    // MOV AX,0x343a (1000_1F57 / 0x11F57)
    AX = 0x343A;
    CheckExternalEvents(cs8, 0x1F5B);
    // PUSH DS (1000_1F5A / 0x11F5A)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x1F5C);
    // PUSH AX (1000_1F5B / 0x11F5B)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1F61);
    // CALLF 0x1000:8055 (1000_1F5C / 0x11F5C)
    FarCall(cs8, 0x1F61, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x1F64);
    // ADD SP,0x4 (1000_1F61 / 0x11F61)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x1F69);
    // CALLF 0x0000:414f (1000_1F64 / 0x11F64)
    FarCall(cs8, 0x1F69, ghidra_guess_0000_414F_0414F);
    CheckExternalEvents(cs8, 0x1F6E);
    // MOV word ptr [BP + -0x6],0x1 (1000_1F69 / 0x11F69)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    label_1000_1F6E_11F6E:
    CheckExternalEvents(cs8, 0x1F72);
    // MOV ES,word ptr [0x55ee] (1000_1F6E / 0x11F6E)
    ES = UInt16[DS, 0x55EE];
    CheckExternalEvents(cs8, 0x1F78);
    // CMP word ptr ES:[0x3772],0x0 (1000_1F72 / 0x11F72)
    Alu16.Sub(UInt16[ES, 0x3772], 0x0);
    CheckExternalEvents(cs8, 0x1F7A);
    // JZ 0x1000:1f96 (1000_1F78 / 0x11F78)
    if(ZeroFlag) {
      goto label_1000_1F96_11F96;
    }
    CheckExternalEvents(cs8, 0x1F7F);
    // CALLF 0x1000:7bf6 (1000_1F7A / 0x11F7A)
    FarCall(cs8, 0x1F7F, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs8, 0x1F82);
    // MOV AX,0x3452 (1000_1F7F / 0x11F7F)
    AX = 0x3452;
    CheckExternalEvents(cs8, 0x1F83);
    // PUSH DS (1000_1F82 / 0x11F82)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x1F84);
    // PUSH AX (1000_1F83 / 0x11F83)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x1F89);
    // CALLF 0x1000:7c1a (1000_1F84 / 0x11F84)
    FarCall(cs8, 0x1F89, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs8, 0x1F8C);
    // ADD SP,0x4 (1000_1F89 / 0x11F89)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x1F91);
    // CALLF 0x1000:8d29 (1000_1F8C / 0x11F8C)
    FarCall(cs8, 0x1F91, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs8, 0x1F96);
    // MOV word ptr [BP + -0x8],0x0 (1000_1F91 / 0x11F91)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    label_1000_1F96_11F96:
    CheckExternalEvents(cs8, 0x1F9A);
    // CMP word ptr [BP + 0x6],0x2 (1000_1F96 / 0x11F96)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x2);
    CheckExternalEvents(cs8, 0x1F9C);
    // JNZ 0x1000:1fc5 (1000_1F9A / 0x11F9A)
    if(!ZeroFlag) {
      goto label_1000_1FC5_11FC5;
    }
    CheckExternalEvents(cs8, 0x1FA0);
    // MOV ES,word ptr [0x55ce] (1000_1F9C / 0x11F9C)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x1FA5);
    // PUSH word ptr ES:[0xa44d] (1000_1FA0 / 0x11FA0)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs8, 0x1FA9);
    // MOV ES,word ptr [0x55cc] (1000_1FA5 / 0x11FA5)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x1FAE);
    // PUSH word ptr ES:[0xa44b] (1000_1FA9 / 0x11FA9)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs8, 0x1FB3);
    // CALLF 0x1000:b204 (1000_1FAE / 0x11FAE)
    FarCall(cs8, 0x1FB3, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs8, 0x1FB6);
    // ADD SP,0x4 (1000_1FB3 / 0x11FB3)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x1FBB);
    // CALLF 0x1000:b7df (1000_1FB6 / 0x11FB6)
    FarCall(cs8, 0x1FBB, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs8, 0x1FC0);
    // CALLF 0x0000:254b (1000_1FBB / 0x11FBB)
    FarCall(cs8, 0x1FC0, ghidra_guess_0000_254B_0254B);
    CheckExternalEvents(cs8, 0x1FC5);
    // CALLF 0x1000:9193 (1000_1FC0 / 0x11FC0)
    FarCall(cs8, 0x1FC5, unknown_18AD_06C3_19193);
    label_1000_1FC5_11FC5:
    CheckExternalEvents(cs8, 0x1FC9);
    // MOV ES,word ptr [0x55f0] (1000_1FC5 / 0x11FC5)
    ES = UInt16[DS, 0x55F0];
    CheckExternalEvents(cs8, 0x1FD0);
    // MOV word ptr ES:[0x9e],0x0 (1000_1FC9 / 0x11FC9)
    UInt16[ES, 0x9E] = 0x0;
    CheckExternalEvents(cs8, 0x1FD5);
    // CALLF 0x0000:412b (1000_1FD0 / 0x11FD0)
    FarCall(cs8, 0x1FD5, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs8, 0x1FD9);
    // MOV ES,word ptr [0x55f2] (1000_1FD5 / 0x11FD5)
    ES = UInt16[DS, 0x55F2];
    CheckExternalEvents(cs8, 0x1FDF);
    // CMP word ptr ES:[0x90],0x0 (1000_1FD9 / 0x11FD9)
    Alu16.Sub(UInt16[ES, 0x90], 0x0);
    CheckExternalEvents(cs8, 0x1FE1);
    // JNZ 0x1000:1fee (1000_1FDF / 0x11FDF)
    if(!ZeroFlag) {
      goto label_1000_1FEE_11FEE;
    }
    CheckExternalEvents(cs8, 0x1FE6);
    // CALLF 0x0000:7d0e (1000_1FE1 / 0x11FE1)
    FarCall(cs8, 0x1FE6, ghidra_guess_0000_7D0E_07D0E);
    CheckExternalEvents(cs8, 0x1FEA);
    // MOV ES,word ptr [0x55f0] (1000_1FE6 / 0x11FE6)
    ES = UInt16[DS, 0x55F0];
    CheckExternalEvents(cs8, 0x1FEE);
    // MOV ES:[0x9e],AX (1000_1FEA / 0x11FEA)
    UInt16[ES, 0x9E] = AX;
    label_1000_1FEE_11FEE:
    CheckExternalEvents(cs8, 0x1FF3);
    // CALLF 0x0000:412b (1000_1FEE / 0x11FEE)
    FarCall(cs8, 0x1FF3, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs8, 0x1FF4);
    // PUSH CS (1000_1FF3 / 0x11FF3)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x1FF7);
    // CALL 0x1000:3fa0 (1000_1FF4 / 0x11FF4)
    NearCall(cs8, 0x1FF7, ghidra_guess_1000_3FA0_13FA0);
    CheckExternalEvents(cs8, 0x1FFB);
    // MOV ES,word ptr [0x55f4] (1000_1FF7 / 0x11FF7)
    ES = UInt16[DS, 0x55F4];
    CheckExternalEvents(cs8, 0x1FFF);
    // MOV ES:[0x2e38],AX (1000_1FFB / 0x11FFB)
    UInt16[ES, 0x2E38] = AX;
    CheckExternalEvents(cs8, 0x2004);
    // CALLF 0x0000:412b (1000_1FFF / 0x11FFF)
    FarCall(cs8, 0x2004, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs8, 0x2005);
    // PUSH CS (1000_2004 / 0x12004)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x2008);
    // CALL 0x1000:4006 (1000_2005 / 0x12005)
    NearCall(cs8, 0x2008, ghidra_guess_1000_4006_14006);
    CheckExternalEvents(cs8, 0x200C);
    // MOV ES,word ptr [0x55f6] (1000_2008 / 0x12008)
    ES = UInt16[DS, 0x55F6];
    CheckExternalEvents(cs8, 0x2010);
    // MOV ES:[0x2e3a],AX (1000_200C / 0x1200C)
    UInt16[ES, 0x2E3A] = AX;
    CheckExternalEvents(cs8, 0x2012);
    // SUB AX,AX (1000_2010 / 0x12010)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x2015);
    // MOV word ptr [BP + -0xc],AX (1000_2012 / 0x12012)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs8, 0x2018);
    // MOV word ptr [BP + -0x12],AX (1000_2015 / 0x12015)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs8, 0x201B);
    // JMP 0x1000:2ade (1000_2018 / 0x12018)
    goto label_1000_2ADE_12ADE;
    label_1000_201B_1201B:
    CheckExternalEvents(cs8, 0x201F);
    // MOV ES,word ptr [0x55cc] (1000_201B / 0x1201B)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x2023);
    // MOV AX,ES:[0xa44b] (1000_201F / 0x1201F)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs8, 0x2026);
    // MOV word ptr [BP + -0x20],AX (1000_2023 / 0x12023)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    CheckExternalEvents(cs8, 0x202A);
    // MOV ES,word ptr [0x55ce] (1000_2026 / 0x12026)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x202E);
    // MOV AX,ES:[0xa44d] (1000_202A / 0x1202A)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs8, 0x2031);
    // MOV word ptr [BP + -0x24],AX (1000_202E / 0x1202E)
    UInt16[SS, (ushort)(BP - 0x24)] = AX;
    CheckExternalEvents(cs8, 0x2035);
    // MOV ES,word ptr [0x55f8] (1000_2031 / 0x12031)
    ES = UInt16[DS, 0x55F8];
    CheckExternalEvents(cs8, 0x203C);
    // MOV word ptr ES:[0x3992],0x0 (1000_2035 / 0x12035)
    UInt16[ES, 0x3992] = 0x0;
    CheckExternalEvents(cs8, 0x2040);
    // MOV ES,word ptr [0x55f0] (1000_203C / 0x1203C)
    ES = UInt16[DS, 0x55F0];
    CheckExternalEvents(cs8, 0x2046);
    // CMP word ptr ES:[0x9e],0x0 (1000_2040 / 0x12040)
    Alu16.Sub(UInt16[ES, 0x9E], 0x0);
    CheckExternalEvents(cs8, 0x2048);
    // JZ 0x1000:204b (1000_2046 / 0x12046)
    if(ZeroFlag) {
      goto label_1000_204B_1204B;
    }
    CheckExternalEvents(cs8, 0x204B);
    // JMP 0x1000:2280 (1000_2048 / 0x12048)
    goto label_1000_2280_12280;
    label_1000_204B_1204B:
    CheckExternalEvents(cs8, 0x2050);
    // MOV word ptr [BP + -0x2c],0x0 (1000_204B / 0x1204B)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_1000_2050_12050:
    CheckExternalEvents(cs8, 0x2053);
    // MOV SI,word ptr [BP + -0x2c] (1000_2050 / 0x12050)
    SI = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x2055);
    // SHL SI,0x1 (1000_2053 / 0x12053)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x2059);
    // MOV ES,word ptr [0x55e0] (1000_2055 / 0x12055)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x205F);
    // CMP word ptr ES:[SI + 0x406a],0x0 (1000_2059 / 0x12059)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x406A)], 0x0);
    CheckExternalEvents(cs8, 0x2061);
    // JZ 0x1000:20ac (1000_205F / 0x1205F)
    if(ZeroFlag) {
      goto label_1000_20AC_120AC;
    }
    CheckExternalEvents(cs8, 0x2065);
    // MOV ES,word ptr [0x55d2] (1000_2061 / 0x12061)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x206B);
    // CMP word ptr ES:[SI + 0x4004],-0x1 (1000_2065 / 0x12065)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4004)], 0xFFFF);
    CheckExternalEvents(cs8, 0x206D);
    // JZ 0x1000:2079 (1000_206B / 0x1206B)
    if(ZeroFlag) {
      goto label_1000_2079_12079;
    }
    CheckExternalEvents(cs8, 0x2071);
    // MOV ES,word ptr [0x55d6] (1000_206D / 0x1206D)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x2077);
    // CMP word ptr ES:[SI + 0x4036],-0x1 (1000_2071 / 0x12071)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4036)], 0xFFFF);
    CheckExternalEvents(cs8, 0x2079);
    // JNZ 0x1000:2089 (1000_2077 / 0x12077)
    if(!ZeroFlag) {
      goto label_1000_2089_12089;
    }
    label_1000_2079_12079:
    CheckExternalEvents(cs8, 0x207C);
    // MOV BX,word ptr [BP + -0x2c] (1000_2079 / 0x12079)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x207E);
    // SHL BX,0x1 (1000_207C / 0x1207C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x2082);
    // MOV ES,word ptr [0x55e0] (1000_207E / 0x1207E)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x2089);
    // MOV word ptr ES:[BX + 0x406a],0x0 (1000_2082 / 0x12082)
    UInt16[ES, (ushort)(BX + 0x406A)] = 0x0;
    label_1000_2089_12089:
    CheckExternalEvents(cs8, 0x208E);
    // MOV word ptr [BP + -0x30],0x0 (1000_2089 / 0x12089)
    UInt16[SS, (ushort)(BP - 0x30)] = 0x0;
    label_1000_208E_1208E:
    CheckExternalEvents(cs8, 0x2091);
    // MOV AX,0x18 (1000_208E / 0x1208E)
    AX = 0x18;
    CheckExternalEvents(cs8, 0x2094);
    // IMUL word ptr [BP + -0x2c] (1000_2091 / 0x12091)
    int resImul1000_2091 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_2091);
    DX = (ushort)(resImul1000_2091 >> 16);
    CheckExternalEvents(cs8, 0x2096);
    // MOV BX,AX (1000_2094 / 0x12094)
    BX = AX;
    CheckExternalEvents(cs8, 0x2099);
    // ADD BX,word ptr [BP + -0x30] (1000_2096 / 0x12096)
    // BX += UInt16[SS, (ushort)(BP - 0x30)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x30)]);
    CheckExternalEvents(cs8, 0x209D);
    // MOV ES,word ptr [0x55d8] (1000_2099 / 0x12099)
    ES = UInt16[DS, 0x55D8];
    CheckExternalEvents(cs8, 0x20A3);
    // MOV byte ptr ES:[BX + 0x40b4],0x2 (1000_209D / 0x1209D)
    UInt8[ES, (ushort)(BX + 0x40B4)] = 0x2;
    CheckExternalEvents(cs8, 0x20A6);
    // INC word ptr [BP + -0x30] (1000_20A3 / 0x120A3)
    UInt16[SS, (ushort)(BP - 0x30)]++;
    CheckExternalEvents(cs8, 0x20AA);
    // CMP word ptr [BP + -0x30],0x18 (1000_20A6 / 0x120A6)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x30)], 0x18);
    CheckExternalEvents(cs8, 0x20AC);
    // JL 0x1000:208e (1000_20AA / 0x120AA)
    if(SignFlag != OverflowFlag) {
      goto label_1000_208E_1208E;
    }
    label_1000_20AC_120AC:
    CheckExternalEvents(cs8, 0x20AF);
    // INC word ptr [BP + -0x2c] (1000_20AC / 0x120AC)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x20B3);
    // CMP word ptr [BP + -0x2c],0xc (1000_20AF / 0x120AF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0xC);
    CheckExternalEvents(cs8, 0x20B5);
    // JL 0x1000:2050 (1000_20B3 / 0x120B3)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2050_12050;
    }
    CheckExternalEvents(cs8, 0x20B6);
    // PUSH CS (1000_20B5 / 0x120B5)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x20B9);
    // CALL 0x1000:2f73 (1000_20B6 / 0x120B6)
    NearCall(cs8, 0x20B9, ghidra_guess_1000_2F73_12F73);
    CheckExternalEvents(cs8, 0x20BC);
    // MOV word ptr [BP + -0x38],AX (1000_20B9 / 0x120B9)
    UInt16[SS, (ushort)(BP - 0x38)] = AX;
    CheckExternalEvents(cs8, 0x20C0);
    // MOV ES,word ptr [0x55ee] (1000_20BC / 0x120BC)
    ES = UInt16[DS, 0x55EE];
    CheckExternalEvents(cs8, 0x20C6);
    // CMP word ptr ES:[0x3772],0x0 (1000_20C0 / 0x120C0)
    Alu16.Sub(UInt16[ES, 0x3772], 0x0);
    CheckExternalEvents(cs8, 0x20C8);
    // JZ 0x1000:2101 (1000_20C6 / 0x120C6)
    if(ZeroFlag) {
      goto label_1000_2101_12101;
    }
    CheckExternalEvents(cs8, 0x20CC);
    // MOV ES,word ptr [0x55d6] (1000_20C8 / 0x120C8)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x20D3);
    // CMP word ptr ES:[0x4036],0xd000 (1000_20CC / 0x120CC)
    Alu16.Sub(UInt16[ES, 0x4036], 0xD000);
    CheckExternalEvents(cs8, 0x20D5);
    // JNC 0x1000:20fc (1000_20D3 / 0x120D3)
    if(!CarryFlag) {
      goto label_1000_20FC_120FC;
    }
    CheckExternalEvents(cs8, 0x20D9);
    // MOV ES,word ptr [0x55d2] (1000_20D5 / 0x120D5)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x20E0);
    // CMP word ptr ES:[0x4004],0xd00 (1000_20D9 / 0x120D9)
    Alu16.Sub(UInt16[ES, 0x4004], 0xD00);
    CheckExternalEvents(cs8, 0x20E2);
    // JGE 0x1000:20fc (1000_20E0 / 0x120E0)
    if(SignFlag == OverflowFlag) {
      goto label_1000_20FC_120FC;
    }
    CheckExternalEvents(cs8, 0x20E6);
    // MOV ES,word ptr [0x55d6] (1000_20E2 / 0x120E2)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x20ED);
    // CMP word ptr ES:[0x4036],0xb07f (1000_20E6 / 0x120E6)
    Alu16.Sub(UInt16[ES, 0x4036], 0xB07F);
    CheckExternalEvents(cs8, 0x20EF);
    // JC 0x1000:20fc (1000_20ED / 0x120ED)
    if(CarryFlag) {
      goto label_1000_20FC_120FC;
    }
    CheckExternalEvents(cs8, 0x20F3);
    // MOV ES,word ptr [0x55d2] (1000_20EF / 0x120EF)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x20FA);
    // CMP word ptr ES:[0x4004],0xb7f (1000_20F3 / 0x120F3)
    Alu16.Sub(UInt16[ES, 0x4004], 0xB7F);
    CheckExternalEvents(cs8, 0x20FC);
    // JGE 0x1000:2101 (1000_20FA / 0x120FA)
    if(SignFlag == OverflowFlag) {
      goto label_1000_2101_12101;
    }
    label_1000_20FC_120FC:
    CheckExternalEvents(cs8, 0x2101);
    // MOV word ptr [BP + -0x38],0x2 (1000_20FC / 0x120FC)
    UInt16[SS, (ushort)(BP - 0x38)] = 0x2;
    label_1000_2101_12101:
    CheckExternalEvents(cs8, 0x2105);
    // CMP word ptr [BP + -0x38],0x0 (1000_2101 / 0x12101)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x38)], 0x0);
    CheckExternalEvents(cs8, 0x2107);
    // JNZ 0x1000:210a (1000_2105 / 0x12105)
    if(!ZeroFlag) {
      goto label_1000_210A_1210A;
    }
    CheckExternalEvents(cs8, 0x210A);
    // JMP 0x1000:218c (1000_2107 / 0x12107)
    goto label_1000_218C_1218C;
    label_1000_210A_1210A:
    CheckExternalEvents(cs8, 0x210E);
    // CMP word ptr [BP + -0x38],0x2 (1000_210A / 0x1210A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x38)], 0x2);
    CheckExternalEvents(cs8, 0x2110);
    // JZ 0x1000:211f (1000_210E / 0x1210E)
    if(ZeroFlag) {
      goto label_1000_211F_1211F;
    }
    CheckExternalEvents(cs8, 0x2115);
    // CALLF 0x1000:aab0 (1000_2110 / 0x12110)
    FarCall(cs8, 0x2115, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs8, 0x2117);
    // AND AL,0x3 (1000_2115 / 0x12115)
    AL &= 0x3;
    CheckExternalEvents(cs8, 0x2119);
    // CMP AL,0x1 (1000_2117 / 0x12117)
    Alu8.Sub(AL, 0x1);
    CheckExternalEvents(cs8, 0x211B);
    // SBB CX,CX (1000_2119 / 0x12119)
    CX = Alu16.Sbb(CX, CX);
    CheckExternalEvents(cs8, 0x211C);
    // INC CX (1000_211B / 0x1211B)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs8, 0x211F);
    // MOV word ptr [BP + -0x38],CX (1000_211C / 0x1211C)
    UInt16[SS, (ushort)(BP - 0x38)] = CX;
    label_1000_211F_1211F:
    CheckExternalEvents(cs8, 0x2122);
    // MOV AX,0x3 (1000_211F / 0x1211F)
    AX = 0x3;
    CheckExternalEvents(cs8, 0x2123);
    // PUSH AX (1000_2122 / 0x12122)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2128);
    // CALLF 0x1000:7ee1 (1000_2123 / 0x12123)
    FarCall(cs8, 0x2128, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs8, 0x212B);
    // ADD SP,0x2 (1000_2128 / 0x12128)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2130);
    // CALLF 0x1000:7fe8 (1000_212B / 0x1212B)
    FarCall(cs8, 0x2130, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs8, 0x2134);
    // CMP word ptr [BP + 0x6],0x2 (1000_2130 / 0x12130)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x2);
    CheckExternalEvents(cs8, 0x2136);
    // JL 0x1000:213b (1000_2134 / 0x12134)
    if(SignFlag != OverflowFlag) {
      goto label_1000_213B_1213B;
    }
    CheckExternalEvents(cs8, 0x213B);
    // MOV word ptr [BP + -0x38],0x0 (1000_2136 / 0x12136)
    UInt16[SS, (ushort)(BP - 0x38)] = 0x0;
    label_1000_213B_1213B:
    CheckExternalEvents(cs8, 0x213F);
    // MOV ES,word ptr [0x55ee] (1000_213B / 0x1213B)
    ES = UInt16[DS, 0x55EE];
    CheckExternalEvents(cs8, 0x2145);
    // CMP word ptr ES:[0x3772],0x0 (1000_213F / 0x1213F)
    Alu16.Sub(UInt16[ES, 0x3772], 0x0);
    CheckExternalEvents(cs8, 0x2147);
    // JZ 0x1000:2166 (1000_2145 / 0x12145)
    if(ZeroFlag) {
      goto label_1000_2166_12166;
    }
    CheckExternalEvents(cs8, 0x214B);
    // CMP word ptr [BP + -0x38],0x2 (1000_2147 / 0x12147)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x38)], 0x2);
    CheckExternalEvents(cs8, 0x214D);
    // JZ 0x1000:2166 (1000_214B / 0x1214B)
    if(ZeroFlag) {
      goto label_1000_2166_12166;
    }
    CheckExternalEvents(cs8, 0x2150);
    // MOV AX,0x3497 (1000_214D / 0x1214D)
    AX = 0x3497;
    CheckExternalEvents(cs8, 0x2151);
    // PUSH DS (1000_2150 / 0x12150)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2152);
    // PUSH AX (1000_2151 / 0x12151)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2157);
    // CALLF 0x1000:8055 (1000_2152 / 0x12152)
    FarCall(cs8, 0x2157, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x215A);
    // ADD SP,0x4 (1000_2157 / 0x12157)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x215F);
    // MOV word ptr [BP + -0x38],0x0 (1000_215A / 0x1215A)
    UInt16[SS, (ushort)(BP - 0x38)] = 0x0;
    label_1000_215F_1215F:
    CheckExternalEvents(cs8, 0x2164);
    // CALLF 0x0000:414f (1000_215F / 0x1215F)
    FarCall(cs8, 0x2164, ghidra_guess_0000_414F_0414F);
    CheckExternalEvents(cs8, 0x2166);
    // JMP 0x1000:218c (1000_2164 / 0x12164)
    goto label_1000_218C_1218C;
    label_1000_2166_12166:
    CheckExternalEvents(cs8, 0x216A);
    // CMP word ptr [BP + -0x38],0x0 (1000_2166 / 0x12166)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x38)], 0x0);
    CheckExternalEvents(cs8, 0x216C);
    // JNZ 0x1000:217b (1000_216A / 0x1216A)
    if(!ZeroFlag) {
      goto label_1000_217B_1217B;
    }
    CheckExternalEvents(cs8, 0x216F);
    // MOV AX,0x34b8 (1000_216C / 0x1216C)
    AX = 0x34B8;
    CheckExternalEvents(cs8, 0x2170);
    // PUSH DS (1000_216F / 0x1216F)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2171);
    // PUSH AX (1000_2170 / 0x12170)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2176);
    // CALLF 0x1000:8055 (1000_2171 / 0x12171)
    FarCall(cs8, 0x2176, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2179);
    // ADD SP,0x4 (1000_2176 / 0x12176)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x217B);
    // JMP 0x1000:215f (1000_2179 / 0x12179)
    goto label_1000_215F_1215F;
    label_1000_217B_1217B:
    CheckExternalEvents(cs8, 0x217F);
    // CMP word ptr [BP + 0x6],0x0 (1000_217B / 0x1217B)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs8, 0x2181);
    // JLE 0x1000:218c (1000_217F / 0x1217F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_218C_1218C;
    }
    CheckExternalEvents(cs8, 0x2185);
    // MOV ES,word ptr [0x55f8] (1000_2181 / 0x12181)
    ES = UInt16[DS, 0x55F8];
    CheckExternalEvents(cs8, 0x218C);
    // MOV word ptr ES:[0x3992],0x1 (1000_2185 / 0x12185)
    UInt16[ES, 0x3992] = 0x1;
    label_1000_218C_1218C:
    CheckExternalEvents(cs8, 0x218F);
    // MOV AX,word ptr [BP + -0x38] (1000_218C / 0x1218C)
    AX = UInt16[SS, (ushort)(BP - 0x38)];
    CheckExternalEvents(cs8, 0x2192);
    // MOV word ptr [BP + -0x12],AX (1000_218F / 0x1218F)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs8, 0x2194);
    // OR AX,AX (1000_2192 / 0x12192)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs8, 0x2196);
    // JZ 0x1000:2199 (1000_2194 / 0x12194)
    if(ZeroFlag) {
      goto label_1000_2199_12199;
    }
    CheckExternalEvents(cs8, 0x2199);
    // JMP 0x1000:22d6 (1000_2196 / 0x12196)
    goto label_1000_22D6_122D6;
    label_1000_2199_12199:
    CheckExternalEvents(cs8, 0x219E);
    // MOV word ptr [BP + -0x2c],0x0 (1000_2199 / 0x12199)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    CheckExternalEvents(cs8, 0x21A1);
    // JMP 0x1000:2246 (1000_219E / 0x1219E)
    goto label_1000_2246_12246;
    label_1000_21A1_121A1:
    CheckExternalEvents(cs8, 0x21A4);
    // MOV AX,0x18 (1000_21A1 / 0x121A1)
    AX = 0x18;
    CheckExternalEvents(cs8, 0x21A7);
    // IMUL word ptr [BP + -0x2c] (1000_21A4 / 0x121A4)
    int resImul1000_21A4 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_21A4);
    DX = (ushort)(resImul1000_21A4 >> 16);
    CheckExternalEvents(cs8, 0x21A9);
    // MOV BX,AX (1000_21A7 / 0x121A7)
    BX = AX;
    CheckExternalEvents(cs8, 0x21AD);
    // MOV ES,word ptr [0x55d8] (1000_21A9 / 0x121A9)
    ES = UInt16[DS, 0x55D8];
    CheckExternalEvents(cs8, 0x21B3);
    // CMP byte ptr ES:[BX + 0x40b4],0x2 (1000_21AD / 0x121AD)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x40B4)], 0x2);
    CheckExternalEvents(cs8, 0x21B5);
    // JZ 0x1000:21b8 (1000_21B3 / 0x121B3)
    if(ZeroFlag) {
      goto label_1000_21B8_121B8;
    }
    CheckExternalEvents(cs8, 0x21B8);
    // JMP 0x1000:2243 (1000_21B5 / 0x121B5)
    goto label_1000_2243_12243;
    label_1000_21B8_121B8:
    CheckExternalEvents(cs8, 0x21BB);
    // MOV AX,0x30 (1000_21B8 / 0x121B8)
    AX = 0x30;
    CheckExternalEvents(cs8, 0x21BE);
    // IMUL word ptr [BP + -0x2c] (1000_21BB / 0x121BB)
    int resImul1000_21BB = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_21BB);
    DX = (ushort)(resImul1000_21BB >> 16);
    CheckExternalEvents(cs8, 0x21C0);
    // MOV BX,AX (1000_21BE / 0x121BE)
    BX = AX;
    CheckExternalEvents(cs8, 0x21C4);
    // MOV ES,word ptr [0x55dc] (1000_21C0 / 0x121C0)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs8, 0x21CA);
    // CMP byte ptr ES:[BX + 0x32c6],0xff (1000_21C4 / 0x121C4)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x32C6)], 0xFF);
    CheckExternalEvents(cs8, 0x21CC);
    // JZ 0x1000:2243 (1000_21CA / 0x121CA)
    if(ZeroFlag) {
      goto label_1000_2243_12243;
    }
    CheckExternalEvents(cs8, 0x21CF);
    // MOV SI,word ptr [BP + -0x2c] (1000_21CC / 0x121CC)
    SI = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x21D1);
    // SHL SI,0x1 (1000_21CF / 0x121CF)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x21D5);
    // MOV ES,word ptr [0x55d6] (1000_21D1 / 0x121D1)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x21DA);
    // PUSH word ptr ES:[SI + 0x4036] (1000_21D5 / 0x121D5)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs8, 0x21DE);
    // MOV ES,word ptr [0x55d2] (1000_21DA / 0x121DA)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x21E3);
    // PUSH word ptr ES:[SI + 0x4004] (1000_21DE / 0x121DE)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs8, 0x21E8);
    // CALLF 0x0000:2ebb (1000_21E3 / 0x121E3)
    FarCall(cs8, 0x21E8, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs8, 0x21EB);
    // ADD SP,0x4 (1000_21E8 / 0x121E8)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x21EF);
    // MOV ES,word ptr [0x55ce] (1000_21EB / 0x121EB)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x21F4);
    // PUSH word ptr ES:[0xa44d] (1000_21EF / 0x121EF)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs8, 0x21F8);
    // MOV ES,word ptr [0x55cc] (1000_21F4 / 0x121F4)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x21FD);
    // PUSH word ptr ES:[0xa44b] (1000_21F8 / 0x121F8)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs8, 0x2202);
    // CALLF 0x1000:b204 (1000_21FD / 0x121FD)
    FarCall(cs8, 0x2202, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs8, 0x2205);
    // ADD SP,0x4 (1000_2202 / 0x12202)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x220A);
    // CALLF 0x1000:bce8 (1000_2205 / 0x12205)
    FarCall(cs8, 0x220A, unknown_19EF_1DF8_1BCE8);
    CheckExternalEvents(cs8, 0x220E);
    // CMP word ptr [BP + -0x2c],0x4 (1000_220A / 0x1220A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x4);
    CheckExternalEvents(cs8, 0x2210);
    // JGE 0x1000:222f (1000_220E / 0x1220E)
    if(SignFlag == OverflowFlag) {
      goto label_1000_222F_1222F;
    }
    CheckExternalEvents(cs8, 0x2213);
    // MOV AX,0x30 (1000_2210 / 0x12210)
    AX = 0x30;
    CheckExternalEvents(cs8, 0x2216);
    // IMUL word ptr [BP + -0x2c] (1000_2213 / 0x12213)
    int resImul1000_2213 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_2213);
    DX = (ushort)(resImul1000_2213 >> 16);
    CheckExternalEvents(cs8, 0x2218);
    // MOV BX,AX (1000_2216 / 0x12216)
    BX = AX;
    CheckExternalEvents(cs8, 0x221C);
    // MOV ES,word ptr [0x55dc] (1000_2218 / 0x12218)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs8, 0x2221);
    // MOV AL,byte ptr ES:[BX + 0x32c6] (1000_221C / 0x1221C)
    AL = UInt8[ES, (ushort)(BX + 0x32C6)];
    CheckExternalEvents(cs8, 0x2222);
    // CBW  (1000_2221 / 0x12221)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x2223);
    // PUSH AX (1000_2222 / 0x12222)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2226);
    // PUSH word ptr [BP + -0x2c] (1000_2223 / 0x12223)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2C)]);
    CheckExternalEvents(cs8, 0x2227);
    // PUSH CS (1000_2226 / 0x12226)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x222A);
    // CALL 0x1000:3d6c (1000_2227 / 0x12227)
    NearCall(cs8, 0x222A, ghidra_guess_1000_3D6C_13D6C);
    CheckExternalEvents(cs8, 0x222D);
    // ADD SP,0x4 (1000_222A / 0x1222A)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x222F);
    // JMP 0x1000:2239 (1000_222D / 0x1222D)
    goto label_1000_2239_12239;
    label_1000_222F_1222F:
    CheckExternalEvents(cs8, 0x2232);
    // PUSH word ptr [BP + -0x2c] (1000_222F / 0x1222F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2C)]);
    CheckExternalEvents(cs8, 0x2233);
    // PUSH CS (1000_2232 / 0x12232)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x2236);
    // CALL 0x1000:3f24 (1000_2233 / 0x12233)
    NearCall(cs8, 0x2236, ghidra_guess_1000_3F24_13F24);
    CheckExternalEvents(cs8, 0x2239);
    // ADD SP,0x2 (1000_2236 / 0x12236)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_1000_2239_12239:
    CheckExternalEvents(cs8, 0x223C);
    // PUSH word ptr [BP + -0x2c] (1000_2239 / 0x12239)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2C)]);
    CheckExternalEvents(cs8, 0x223D);
    // PUSH CS (1000_223C / 0x1223C)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x2240);
    // CALL 0x1000:33eb (1000_223D / 0x1223D)
    NearCall(cs8, 0x2240, ghidra_guess_1000_33EB_133EB);
    CheckExternalEvents(cs8, 0x2243);
    // ADD SP,0x2 (1000_2240 / 0x12240)
    SP += 0x2;
    label_1000_2243_12243:
    CheckExternalEvents(cs8, 0x2246);
    // INC word ptr [BP + -0x2c] (1000_2243 / 0x12243)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    label_1000_2246_12246:
    CheckExternalEvents(cs8, 0x224A);
    // CMP word ptr [BP + -0x2c],0xc (1000_2246 / 0x12246)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0xC);
    CheckExternalEvents(cs8, 0x224C);
    // JL 0x1000:224f (1000_224A / 0x1224A)
    if(SignFlag != OverflowFlag) {
      goto label_1000_224F_1224F;
    }
    CheckExternalEvents(cs8, 0x224F);
    // JMP 0x1000:22d6 (1000_224C / 0x1224C)
    goto label_1000_22D6_122D6;
    label_1000_224F_1224F:
    CheckExternalEvents(cs8, 0x2252);
    // MOV BX,word ptr [BP + -0x2c] (1000_224F / 0x1224F)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x2254);
    // SHL BX,0x1 (1000_2252 / 0x12252)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x2258);
    // MOV ES,word ptr [0x55e0] (1000_2254 / 0x12254)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x225E);
    // CMP word ptr ES:[BX + 0x406a],0x0 (1000_2258 / 0x12258)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x406A)], 0x0);
    CheckExternalEvents(cs8, 0x2260);
    // JZ 0x1000:2243 (1000_225E / 0x1225E)
    if(ZeroFlag) {
      goto label_1000_2243_12243;
    }
    CheckExternalEvents(cs8, 0x2263);
    // MOV BX,word ptr [BP + -0x2c] (1000_2260 / 0x12260)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x2267);
    // MOV ES,word ptr [0x55e6] (1000_2263 / 0x12263)
    ES = UInt16[DS, 0x55E6];
    CheckExternalEvents(cs8, 0x226D);
    // CMP byte ptr ES:[BX + 0x3994],0x0 (1000_2267 / 0x12267)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x3994)], 0x0);
    CheckExternalEvents(cs8, 0x226F);
    // JNZ 0x1000:2272 (1000_226D / 0x1226D)
    if(!ZeroFlag) {
      goto label_1000_2272_12272;
    }
    CheckExternalEvents(cs8, 0x2272);
    // JMP 0x1000:21a1 (1000_226F / 0x1226F)
    goto label_1000_21A1_121A1;
    label_1000_2272_12272:
    CheckExternalEvents(cs8, 0x2274);
    // SUB AX,AX (1000_2272 / 0x12272)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x2275);
    // PUSH AX (1000_2274 / 0x12274)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2276);
    // PUSH BX (1000_2275 / 0x12275)
    Stack.Push16(BX);
    CheckExternalEvents(cs8, 0x227B);
    // CALLF 0x0000:fdbb (1000_2276 / 0x12276)
    throw FailAsUntested("Could not find a valid function at address 0FA1_03AB / 0xFDBB");
    CheckExternalEvents(cs8, 0x227E);
    // ADD SP,0x4 (1000_227B / 0x1227B)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2280);
    // JMP 0x1000:2243 (1000_227E / 0x1227E)
    goto label_1000_2243_12243;
    label_1000_2280_12280:
    CheckExternalEvents(cs8, 0x2282);
    // SUB AX,AX (1000_2280 / 0x12280)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x2283);
    // PUSH AX (1000_2282 / 0x12282)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2284);
    // PUSH CS (1000_2283 / 0x12283)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x2287);
    // CALL 0x1000:2f32 (1000_2284 / 0x12284)
    NearCall(cs8, 0x2287, ghidra_guess_1000_2F32_12F32);
    CheckExternalEvents(cs8, 0x228A);
    // ADD SP,0x2 (1000_2287 / 0x12287)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x228E);
    // MOV ES,word ptr [0x55f8] (1000_228A / 0x1228A)
    ES = UInt16[DS, 0x55F8];
    CheckExternalEvents(cs8, 0x2294);
    // CMP word ptr ES:[0x3992],0x0 (1000_228E / 0x1228E)
    Alu16.Sub(UInt16[ES, 0x3992], 0x0);
    CheckExternalEvents(cs8, 0x2296);
    // JZ 0x1000:22d6 (1000_2294 / 0x12294)
    if(ZeroFlag) {
      goto label_1000_22D6_122D6;
    }
    CheckExternalEvents(cs8, 0x229B);
    // MOV word ptr [BP + -0x38],0x1 (1000_2296 / 0x12296)
    UInt16[SS, (ushort)(BP - 0x38)] = 0x1;
    CheckExternalEvents(cs8, 0x22A0);
    // MOV word ptr [BP + -0x2c],0x0 (1000_229B / 0x1229B)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_1000_22A0_122A0:
    CheckExternalEvents(cs8, 0x22A3);
    // MOV AX,0x7d (1000_22A0 / 0x122A0)
    AX = 0x7D;
    CheckExternalEvents(cs8, 0x22A6);
    // IMUL word ptr [BP + -0x2c] (1000_22A3 / 0x122A3)
    int resImul1000_22A3 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_22A3);
    DX = (ushort)(resImul1000_22A3 >> 16);
    CheckExternalEvents(cs8, 0x22A8);
    // MOV BX,AX (1000_22A6 / 0x122A6)
    BX = AX;
    CheckExternalEvents(cs8, 0x22AC);
    // MOV ES,word ptr [0x55d4] (1000_22A8 / 0x122A8)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x22B2);
    // CMP byte ptr ES:[BX + 0xc724],0xff (1000_22AC / 0x122AC)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs8, 0x22B4);
    // JZ 0x1000:22b9 (1000_22B2 / 0x122B2)
    if(ZeroFlag) {
      goto label_1000_22B9_122B9;
    }
    CheckExternalEvents(cs8, 0x22B9);
    // MOV word ptr [BP + -0x38],0x0 (1000_22B4 / 0x122B4)
    UInt16[SS, (ushort)(BP - 0x38)] = 0x0;
    label_1000_22B9_122B9:
    CheckExternalEvents(cs8, 0x22BC);
    // INC word ptr [BP + -0x2c] (1000_22B9 / 0x122B9)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x22C0);
    // CMP word ptr [BP + -0x2c],0x4 (1000_22BC / 0x122BC)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x4);
    CheckExternalEvents(cs8, 0x22C2);
    // JL 0x1000:22a0 (1000_22C0 / 0x122C0)
    if(SignFlag != OverflowFlag) {
      goto label_1000_22A0_122A0;
    }
    CheckExternalEvents(cs8, 0x22C6);
    // CMP word ptr [BP + -0x38],0x0 (1000_22C2 / 0x122C2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x38)], 0x0);
    CheckExternalEvents(cs8, 0x22C8);
    // JZ 0x1000:22d6 (1000_22C6 / 0x122C6)
    if(ZeroFlag) {
      goto label_1000_22D6_122D6;
    }
    CheckExternalEvents(cs8, 0x22CD);
    // CALLF 0x1000:aab0 (1000_22C8 / 0x122C8)
    FarCall(cs8, 0x22CD, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs8, 0x22D0);
    // AND AX,0x3 (1000_22CD / 0x122CD)
    // AX &= 0x3;
    AX = Alu16.And(AX, 0x3);
    CheckExternalEvents(cs8, 0x22D3);
    // MOV word ptr [BP + -0x38],AX (1000_22D0 / 0x122D0)
    UInt16[SS, (ushort)(BP - 0x38)] = AX;
    CheckExternalEvents(cs8, 0x22D6);
    // MOV word ptr [BP + -0x12],AX (1000_22D3 / 0x122D3)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    label_1000_22D6_122D6:
    CheckExternalEvents(cs8, 0x22DA);
    // CMP word ptr [BP + -0x38],0x0 (1000_22D6 / 0x122D6)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x38)], 0x0);
    CheckExternalEvents(cs8, 0x22DC);
    // JZ 0x1000:22df (1000_22DA / 0x122DA)
    if(ZeroFlag) {
      goto label_1000_22DF_122DF;
    }
    CheckExternalEvents(cs8, 0x22DF);
    // JMP 0x1000:2aad (1000_22DC / 0x122DC)
    goto label_1000_2AAD_12AAD;
    label_1000_22DF_122DF:
    CheckExternalEvents(cs8, 0x22E2);
    // PUSH word ptr [BP + -0x24] (1000_22DF / 0x122DF)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x24)]);
    CheckExternalEvents(cs8, 0x22E5);
    // PUSH word ptr [BP + -0x20] (1000_22E2 / 0x122E2)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x20)]);
    CheckExternalEvents(cs8, 0x22EA);
    // CALLF 0x0000:2ebb (1000_22E5 / 0x122E5)
    FarCall(cs8, 0x22EA, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs8, 0x22ED);
    // ADD SP,0x4 (1000_22EA / 0x122EA)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x22F1);
    // MOV ES,word ptr [0x55fa] (1000_22ED / 0x122ED)
    ES = UInt16[DS, 0x55FA];
    CheckExternalEvents(cs8, 0x22F8);
    // MOV word ptr ES:[0x374c],0x0 (1000_22F1 / 0x122F1)
    UInt16[ES, 0x374C] = 0x0;
    CheckExternalEvents(cs8, 0x22FB);
    // MOV AX,0xc (1000_22F8 / 0x122F8)
    AX = 0xC;
    CheckExternalEvents(cs8, 0x22FC);
    // PUSH AX (1000_22FB / 0x122FB)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x22FD);
    // PUSH CS (1000_22FC / 0x122FC)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x2300);
    // CALL 0x1000:2f32 (1000_22FD / 0x122FD)
    NearCall(cs8, 0x2300, ghidra_guess_1000_2F32_12F32);
    CheckExternalEvents(cs8, 0x2303);
    // ADD SP,0x2 (1000_2300 / 0x12300)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2306);
    // PUSH word ptr [BP + -0x24] (1000_2303 / 0x12303)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x24)]);
    CheckExternalEvents(cs8, 0x2309);
    // PUSH word ptr [BP + -0x20] (1000_2306 / 0x12306)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x20)]);
    CheckExternalEvents(cs8, 0x230E);
    // CALLF 0x0000:2ebb (1000_2309 / 0x12309)
    FarCall(cs8, 0x230E, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs8, 0x2311);
    // ADD SP,0x4 (1000_230E / 0x1230E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2315);
    // MOV ES,word ptr [0x55ce] (1000_2311 / 0x12311)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x231A);
    // PUSH word ptr ES:[0xa44d] (1000_2315 / 0x12315)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs8, 0x231E);
    // MOV ES,word ptr [0x55cc] (1000_231A / 0x1231A)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x2323);
    // PUSH word ptr ES:[0xa44b] (1000_231E / 0x1231E)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs8, 0x2328);
    // CALLF 0x1000:b204 (1000_2323 / 0x12323)
    FarCall(cs8, 0x2328, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs8, 0x232B);
    // ADD SP,0x4 (1000_2328 / 0x12328)
    SP += 0x4;
    CheckExternalEvents(cs8, 0x232F);
    // CMP word ptr [BP + 0x6],0x0 (1000_232B / 0x1232B)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs8, 0x2331);
    // JLE 0x1000:2336 (1000_232F / 0x1232F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_2336_12336;
    }
    CheckExternalEvents(cs8, 0x2334);
    // MOV AX,0x1 (1000_2331 / 0x12331)
    AX = 0x1;
    CheckExternalEvents(cs8, 0x2336);
    // JMP 0x1000:2338 (1000_2334 / 0x12334)
    goto label_1000_2338_12338;
    label_1000_2336_12336:
    CheckExternalEvents(cs8, 0x2338);
    // SUB AX,AX (1000_2336 / 0x12336)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    label_1000_2338_12338:
    CheckExternalEvents(cs8, 0x2339);
    // PUSH AX (1000_2338 / 0x12338)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x233E);
    // CALLF 0x1000:458c (1000_2339 / 0x12339)
    FarCall(cs8, 0x233E, ghidra_guess_1000_458C_1458C);
    CheckExternalEvents(cs8, 0x2341);
    // ADD SP,0x2 (1000_233E / 0x1233E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2345);
    // MOV ES,word ptr [0x55fc] (1000_2341 / 0x12341)
    ES = UInt16[DS, 0x55FC];
    CheckExternalEvents(cs8, 0x234B);
    // CMP word ptr ES:[0x14a],0x0 (1000_2345 / 0x12345)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs8, 0x234D);
    // JNZ 0x1000:2350 (1000_234B / 0x1234B)
    if(!ZeroFlag) {
      goto label_1000_2350_12350;
    }
    CheckExternalEvents(cs8, 0x2350);
    // JMP 0x1000:278b (1000_234D / 0x1234D)
    goto label_1000_278B_1278B;
    label_1000_2350_12350:
    CheckExternalEvents(cs8, 0x2354);
    // MOV ES,word ptr [0x55d4] (1000_2350 / 0x12350)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x235A);
    // CMP byte ptr ES:[0xd333],0x0 (1000_2354 / 0x12354)
    Alu8.Sub(UInt8[ES, 0xD333], 0x0);
    CheckExternalEvents(cs8, 0x235C);
    // JNZ 0x1000:235f (1000_235A / 0x1235A)
    if(!ZeroFlag) {
      goto label_1000_235F_1235F;
    }
    CheckExternalEvents(cs8, 0x235F);
    // JMP 0x1000:278b (1000_235C / 0x1235C)
    goto label_1000_278B_1278B;
    label_1000_235F_1235F:
    CheckExternalEvents(cs8, 0x2363);
    // MOV ES,word ptr [0x55fe] (1000_235F / 0x1235F)
    ES = UInt16[DS, 0x55FE];
    CheckExternalEvents(cs8, 0x2369);
    // CMP word ptr ES:[0x374a],0x0 (1000_2363 / 0x12363)
    Alu16.Sub(UInt16[ES, 0x374A], 0x0);
    CheckExternalEvents(cs8, 0x236B);
    // JNZ 0x1000:236e (1000_2369 / 0x12369)
    if(!ZeroFlag) {
      goto label_1000_236E_1236E;
    }
    CheckExternalEvents(cs8, 0x236E);
    // JMP 0x1000:278b (1000_236B / 0x1236B)
    goto label_1000_278B_1278B;
    label_1000_236E_1236E:
    CheckExternalEvents(cs8, 0x2371);
    // MOV AX,0x6 (1000_236E / 0x1236E)
    AX = 0x6;
    CheckExternalEvents(cs8, 0x2372);
    // PUSH AX (1000_2371 / 0x12371)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2377);
    // CALLF 0x1000:7ee1 (1000_2372 / 0x12372)
    FarCall(cs8, 0x2377, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs8, 0x237A);
    // ADD SP,0x2 (1000_2377 / 0x12377)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x237F);
    // CALLF 0x1000:7fe8 (1000_237A / 0x1237A)
    FarCall(cs8, 0x237F, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs8, 0x2381);
    // SUB AX,AX (1000_237F / 0x1237F)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x2382);
    // PUSH AX (1000_2381 / 0x12381)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2387);
    // CALLF 0x1000:7c64 (1000_2382 / 0x12382)
    FarCall(cs8, 0x2387, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs8, 0x238A);
    // ADD SP,0x2 (1000_2387 / 0x12387)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x238E);
    // MOV ES,word ptr [0x55d4] (1000_238A / 0x1238A)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2392);
    // MOV AL,ES:[0xd331] (1000_238E / 0x1238E)
    AL = UInt8[ES, 0xD331];
    CheckExternalEvents(cs8, 0x2393);
    // CBW  (1000_2392 / 0x12392)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x2396);
    // MOV word ptr [BP + -0x44],AX (1000_2393 / 0x12393)
    UInt16[SS, (ushort)(BP - 0x44)] = AX;
    CheckExternalEvents(cs8, 0x2399);
    // MOV AX,0x11 (1000_2396 / 0x12396)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x239C);
    // IMUL word ptr [BP + -0x44] (1000_2399 / 0x12399)
    int resImul1000_2399 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x44)]);
    AX = (ushort)(resImul1000_2399);
    DX = (ushort)(resImul1000_2399 >> 16);
    CheckExternalEvents(cs8, 0x239E);
    // MOV BX,AX (1000_239C / 0x1239C)
    BX = AX;
    CheckExternalEvents(cs8, 0x23A3);
    // MOV AL,byte ptr ES:[BX + 0xc620] (1000_239E / 0x1239E)
    AL = UInt8[ES, (ushort)(BX + 0xC620)];
    CheckExternalEvents(cs8, 0x23A4);
    // CBW  (1000_23A3 / 0x123A3)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x23A7);
    // MOV word ptr [BP + -0x2],AX (1000_23A4 / 0x123A4)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs8, 0x23AA);
    // CMP AX,0x8 (1000_23A7 / 0x123A7)
    Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs8, 0x23AC);
    // JZ 0x1000:23af (1000_23AA / 0x123AA)
    if(ZeroFlag) {
      goto label_1000_23AF_123AF;
    }
    CheckExternalEvents(cs8, 0x23AF);
    // JMP 0x1000:245d (1000_23AC / 0x123AC)
    goto label_1000_245D_1245D;
    label_1000_23AF_123AF:
    CheckExternalEvents(cs8, 0x23B2);
    // MOV AX,0x34e9 (1000_23AF / 0x123AF)
    AX = 0x34E9;
    CheckExternalEvents(cs8, 0x23B3);
    // PUSH DS (1000_23B2 / 0x123B2)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x23B4);
    // PUSH AX (1000_23B3 / 0x123B3)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x23B9);
    // CALLF 0x1000:8055 (1000_23B4 / 0x123B4)
    FarCall(cs8, 0x23B9, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x23BC);
    // ADD SP,0x4 (1000_23B9 / 0x123B9)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x23BF);
    // MOV AX,0x11 (1000_23BC / 0x123BC)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x23C2);
    // IMUL word ptr [BP + -0x44] (1000_23BF / 0x123BF)
    int resImul1000_23BF = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x44)]);
    AX = (ushort)(resImul1000_23BF);
    DX = (ushort)(resImul1000_23BF >> 16);
    CheckExternalEvents(cs8, 0x23C4);
    // MOV BX,AX (1000_23C2 / 0x123C2)
    BX = AX;
    CheckExternalEvents(cs8, 0x23C8);
    // MOV ES,word ptr [0x55d4] (1000_23C4 / 0x123C4)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x23CD);
    // MOV AL,byte ptr ES:[BX + 0xc614] (1000_23C8 / 0x123C8)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs8, 0x23CE);
    // CBW  (1000_23CD / 0x123CD)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x23D0);
    // MOV BX,AX (1000_23CE / 0x123CE)
    BX = AX;
    CheckExternalEvents(cs8, 0x23D2);
    // SHL BX,0x1 (1000_23D0 / 0x123D0)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x23D4);
    // SHL BX,0x1 (1000_23D2 / 0x123D2)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x23D8);
    // MOV ES,word ptr [0x5600] (1000_23D4 / 0x123D4)
    ES = UInt16[DS, 0x5600];
    CheckExternalEvents(cs8, 0x23DD);
    // PUSH word ptr ES:[BX + 0x1cc] (1000_23D8 / 0x123D8)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs8, 0x23E2);
    // PUSH word ptr ES:[BX + 0x1ca] (1000_23DD / 0x123DD)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs8, 0x23E7);
    // CALLF 0x1000:8055 (1000_23E2 / 0x123E2)
    FarCall(cs8, 0x23E7, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x23EA);
    // ADD SP,0x4 (1000_23E7 / 0x123E7)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x23ED);
    // MOV AX,0x34f6 (1000_23EA / 0x123EA)
    AX = 0x34F6;
    CheckExternalEvents(cs8, 0x23EE);
    // PUSH DS (1000_23ED / 0x123ED)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x23EF);
    // PUSH AX (1000_23EE / 0x123EE)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x23F4);
    // CALLF 0x1000:8055 (1000_23EF / 0x123EF)
    FarCall(cs8, 0x23F4, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x23F7);
    // ADD SP,0x4 (1000_23F4 / 0x123F4)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x23FA);
    // MOV AX,0x3510 (1000_23F7 / 0x123F7)
    AX = 0x3510;
    CheckExternalEvents(cs8, 0x23FB);
    // PUSH DS (1000_23FA / 0x123FA)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x23FC);
    // PUSH AX (1000_23FB / 0x123FB)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2401);
    // CALLF 0x1000:8055 (1000_23FC / 0x123FC)
    FarCall(cs8, 0x2401, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2404);
    // ADD SP,0x4 (1000_2401 / 0x12401)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2407);
    // MOV AX,0x3555 (1000_2404 / 0x12404)
    AX = 0x3555;
    CheckExternalEvents(cs8, 0x2408);
    // PUSH DS (1000_2407 / 0x12407)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2409);
    // PUSH AX (1000_2408 / 0x12408)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x240E);
    // CALLF 0x1000:8055 (1000_2409 / 0x12409)
    FarCall(cs8, 0x240E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2411);
    // ADD SP,0x4 (1000_240E / 0x1240E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2414);
    // MOV AX,0x358e (1000_2411 / 0x12411)
    AX = 0x358E;
    CheckExternalEvents(cs8, 0x2415);
    // PUSH DS (1000_2414 / 0x12414)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2416);
    // PUSH AX (1000_2415 / 0x12415)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x241B);
    // CALLF 0x1000:8055 (1000_2416 / 0x12416)
    FarCall(cs8, 0x241B, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x241E);
    // ADD SP,0x4 (1000_241B / 0x1241B)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2421);
    // MOV SI,word ptr [BP + -0x44] (1000_241E / 0x1241E)
    SI = UInt16[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs8, 0x2423);
    // SHL SI,0x1 (1000_2421 / 0x12421)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x2427);
    // MOV ES,word ptr [0x55d6] (1000_2423 / 0x12423)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x242C);
    // PUSH word ptr ES:[SI + 0x403e] (1000_2427 / 0x12427)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x403E)]);
    CheckExternalEvents(cs8, 0x2430);
    // MOV ES,word ptr [0x55d2] (1000_242C / 0x1242C)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x2435);
    // PUSH word ptr ES:[SI + 0x400c] (1000_2430 / 0x12430)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x400C)]);
    CheckExternalEvents(cs8, 0x2438);
    // MOV AX,0x7e (1000_2435 / 0x12435)
    AX = 0x7E;
    CheckExternalEvents(cs8, 0x2439);
    // PUSH AX (1000_2438 / 0x12438)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x243A);
    // PUSH CS (1000_2439 / 0x12439)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x243D);
    // CALL 0x1000:4279 (1000_243A / 0x1243A)
    NearCall(cs8, 0x243D, ghidra_guess_1000_4279_14279);
    CheckExternalEvents(cs8, 0x2440);
    // ADD SP,0x6 (1000_243D / 0x1243D)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs8, 0x2443);
    // MOV SI,word ptr [BP + -0x44] (1000_2440 / 0x12440)
    SI = UInt16[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs8, 0x2445);
    // SHL SI,0x1 (1000_2443 / 0x12443)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x2448);
    // MOV AX,0xffff (1000_2445 / 0x12445)
    AX = 0xFFFF;
    CheckExternalEvents(cs8, 0x244C);
    // MOV ES,word ptr [0x55d6] (1000_2448 / 0x12448)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x2451);
    // MOV word ptr ES:[SI + 0x403e],AX (1000_244C / 0x1244C)
    UInt16[ES, (ushort)(SI + 0x403E)] = AX;
    CheckExternalEvents(cs8, 0x2455);
    // MOV ES,word ptr [0x55d2] (1000_2451 / 0x12451)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x245A);
    // MOV word ptr ES:[SI + 0x400c],AX (1000_2455 / 0x12455)
    UInt16[ES, (ushort)(SI + 0x400C)] = AX;
    CheckExternalEvents(cs8, 0x245D);
    // JMP 0x1000:2751 (1000_245A / 0x1245A)
    goto label_1000_2751_12751;
    label_1000_245D_1245D:
    CheckExternalEvents(cs8, 0x2460);
    // MOV AX,0x7d (1000_245D / 0x1245D)
    AX = 0x7D;
    CheckExternalEvents(cs8, 0x2463);
    // IMUL word ptr [BP + -0x2] (1000_2460 / 0x12460)
    int resImul1000_2460 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_2460);
    DX = (ushort)(resImul1000_2460 >> 16);
    CheckExternalEvents(cs8, 0x2465);
    // MOV SI,AX (1000_2463 / 0x12463)
    SI = AX;
    CheckExternalEvents(cs8, 0x2469);
    // MOV ES,word ptr [0x55d4] (1000_2465 / 0x12465)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x246E);
    // MOV AL,byte ptr ES:[SI + 0xc79d] (1000_2469 / 0x12469)
    AL = UInt8[ES, (ushort)(SI + 0xC79D)];
    CheckExternalEvents(cs8, 0x2470);
    // SUB AH,AH (1000_246E / 0x1246E)
    AH -= AH;
    CheckExternalEvents(cs8, 0x2473);
    // CMP AX,word ptr [BP + -0x44] (1000_2470 / 0x12470)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x44)]);
    CheckExternalEvents(cs8, 0x2475);
    // JZ 0x1000:2478 (1000_2473 / 0x12473)
    if(ZeroFlag) {
      goto label_1000_2478_12478;
    }
    CheckExternalEvents(cs8, 0x2478);
    // JMP 0x1000:2684 (1000_2475 / 0x12475)
    goto label_1000_2684_12684;
    label_1000_2478_12478:
    CheckExternalEvents(cs8, 0x247D);
    // MOV AL,byte ptr ES:[SI + 0xc79e] (1000_2478 / 0x12478)
    AL = UInt8[ES, (ushort)(SI + 0xC79E)];
    CheckExternalEvents(cs8, 0x2480);
    // MOV word ptr [BP + -0xe],AX (1000_247D / 0x1247D)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs8, 0x2483);
    // MOV AX,0x11 (1000_2480 / 0x12480)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x2486);
    // IMUL word ptr [BP + -0x44] (1000_2483 / 0x12483)
    int resImul1000_2483 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x44)]);
    AX = (ushort)(resImul1000_2483);
    DX = (ushort)(resImul1000_2483 >> 16);
    CheckExternalEvents(cs8, 0x2488);
    // MOV BX,AX (1000_2486 / 0x12486)
    BX = AX;
    CheckExternalEvents(cs8, 0x248D);
    // MOV AL,byte ptr ES:[BX + 0xc614] (1000_2488 / 0x12488)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs8, 0x248E);
    // CBW  (1000_248D / 0x1248D)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x2490);
    // MOV BX,AX (1000_248E / 0x1248E)
    BX = AX;
    CheckExternalEvents(cs8, 0x2492);
    // SHL BX,0x1 (1000_2490 / 0x12490)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x2494);
    // SHL BX,0x1 (1000_2492 / 0x12492)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x2498);
    // MOV ES,word ptr [0x5600] (1000_2494 / 0x12494)
    ES = UInt16[DS, 0x5600];
    CheckExternalEvents(cs8, 0x249D);
    // PUSH word ptr ES:[BX + 0x1cc] (1000_2498 / 0x12498)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs8, 0x24A2);
    // PUSH word ptr ES:[BX + 0x1ca] (1000_249D / 0x1249D)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs8, 0x24A7);
    // CALLF 0x1000:8055 (1000_24A2 / 0x124A2)
    FarCall(cs8, 0x24A7, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x24AA);
    // ADD SP,0x4 (1000_24A7 / 0x124A7)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x24AD);
    // MOV AX,0x35d1 (1000_24AA / 0x124AA)
    AX = 0x35D1;
    CheckExternalEvents(cs8, 0x24AE);
    // PUSH DS (1000_24AD / 0x124AD)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x24AF);
    // PUSH AX (1000_24AE / 0x124AE)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x24B4);
    // CALLF 0x1000:8055 (1000_24AF / 0x124AF)
    FarCall(cs8, 0x24B4, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x24B7);
    // ADD SP,0x4 (1000_24B4 / 0x124B4)
    SP += 0x4;
    CheckExternalEvents(cs8, 0x24BC);
    // CMP word ptr [BP + -0xe],0xff (1000_24B7 / 0x124B7)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0xFF);
    CheckExternalEvents(cs8, 0x24BE);
    // JZ 0x1000:24d5 (1000_24BC / 0x124BC)
    if(ZeroFlag) {
      goto label_1000_24D5_124D5;
    }
    CheckExternalEvents(cs8, 0x24C1);
    // MOV AX,0x11 (1000_24BE / 0x124BE)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x24C4);
    // IMUL word ptr [BP + -0xe] (1000_24C1 / 0x124C1)
    int resImul1000_24C1 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul1000_24C1);
    DX = (ushort)(resImul1000_24C1 >> 16);
    CheckExternalEvents(cs8, 0x24C6);
    // MOV BX,AX (1000_24C4 / 0x124C4)
    BX = AX;
    CheckExternalEvents(cs8, 0x24CA);
    // MOV ES,word ptr [0x55d4] (1000_24C6 / 0x124C6)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x24D0);
    // CMP byte ptr ES:[BX + 0xc61c],0x0 (1000_24CA / 0x124CA)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC61C)], 0x0);
    CheckExternalEvents(cs8, 0x24D2);
    // JZ 0x1000:24d5 (1000_24D0 / 0x124D0)
    if(ZeroFlag) {
      goto label_1000_24D5_124D5;
    }
    CheckExternalEvents(cs8, 0x24D5);
    // JMP 0x1000:25f0 (1000_24D2 / 0x124D2)
    goto label_1000_25F0_125F0;
    label_1000_24D5_124D5:
    CheckExternalEvents(cs8, 0x24DA);
    // CMP word ptr [BP + -0xe],0xff (1000_24D5 / 0x124D5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0xFF);
    CheckExternalEvents(cs8, 0x24DC);
    // JNZ 0x1000:24f9 (1000_24DA / 0x124DA)
    if(!ZeroFlag) {
      goto label_1000_24F9_124F9;
    }
    CheckExternalEvents(cs8, 0x24DF);
    // MOV AX,0x3610 (1000_24DC / 0x124DC)
    AX = 0x3610;
    CheckExternalEvents(cs8, 0x24E0);
    // PUSH DS (1000_24DF / 0x124DF)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x24E1);
    // PUSH AX (1000_24E0 / 0x124E0)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x24E6);
    // CALLF 0x1000:8055 (1000_24E1 / 0x124E1)
    FarCall(cs8, 0x24E6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x24E9);
    // ADD SP,0x4 (1000_24E6 / 0x124E6)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x24EC);
    // MOV AX,0x3653 (1000_24E9 / 0x124E9)
    AX = 0x3653;
    CheckExternalEvents(cs8, 0x24ED);
    // PUSH DS (1000_24EC / 0x124EC)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x24EE);
    // PUSH AX (1000_24ED / 0x124ED)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x24F3);
    // CALLF 0x1000:8055 (1000_24EE / 0x124EE)
    FarCall(cs8, 0x24F3, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x24F6);
    // ADD SP,0x4 (1000_24F3 / 0x124F3)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x24F9);
    // JMP 0x1000:2584 (1000_24F6 / 0x124F6)
    goto label_1000_2584_12584;
    label_1000_24F9_124F9:
    CheckExternalEvents(cs8, 0x24FC);
    // MOV AX,0x11 (1000_24F9 / 0x124F9)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x24FF);
    // IMUL word ptr [BP + -0xe] (1000_24FC / 0x124FC)
    int resImul1000_24FC = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul1000_24FC);
    DX = (ushort)(resImul1000_24FC >> 16);
    CheckExternalEvents(cs8, 0x2501);
    // MOV BX,AX (1000_24FF / 0x124FF)
    BX = AX;
    CheckExternalEvents(cs8, 0x2505);
    // MOV ES,word ptr [0x55d4] (1000_2501 / 0x12501)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x250A);
    // MOV AL,byte ptr ES:[BX + 0xc614] (1000_2505 / 0x12505)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs8, 0x250B);
    // CBW  (1000_250A / 0x1250A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x250D);
    // MOV BX,AX (1000_250B / 0x1250B)
    BX = AX;
    CheckExternalEvents(cs8, 0x250F);
    // SHL BX,0x1 (1000_250D / 0x1250D)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x2511);
    // SHL BX,0x1 (1000_250F / 0x1250F)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x2515);
    // MOV ES,word ptr [0x5600] (1000_2511 / 0x12511)
    ES = UInt16[DS, 0x5600];
    CheckExternalEvents(cs8, 0x251A);
    // PUSH word ptr ES:[BX + 0x1cc] (1000_2515 / 0x12515)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs8, 0x251F);
    // PUSH word ptr ES:[BX + 0x1ca] (1000_251A / 0x1251A)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs8, 0x2524);
    // CALLF 0x1000:8055 (1000_251F / 0x1251F)
    FarCall(cs8, 0x2524, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2527);
    // ADD SP,0x4 (1000_2524 / 0x12524)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x252A);
    // MOV AX,0x3666 (1000_2527 / 0x12527)
    AX = 0x3666;
    CheckExternalEvents(cs8, 0x252B);
    // PUSH DS (1000_252A / 0x1252A)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x252C);
    // PUSH AX (1000_252B / 0x1252B)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2531);
    // CALLF 0x1000:8055 (1000_252C / 0x1252C)
    FarCall(cs8, 0x2531, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2534);
    // ADD SP,0x4 (1000_2531 / 0x12531)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2537);
    // MOV AX,0x36a9 (1000_2534 / 0x12534)
    AX = 0x36A9;
    CheckExternalEvents(cs8, 0x2538);
    // PUSH DS (1000_2537 / 0x12537)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2539);
    // PUSH AX (1000_2538 / 0x12538)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x253E);
    // CALLF 0x1000:8055 (1000_2539 / 0x12539)
    FarCall(cs8, 0x253E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2541);
    // ADD SP,0x4 (1000_253E / 0x1253E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2544);
    // MOV AX,0x11 (1000_2541 / 0x12541)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x2547);
    // IMUL word ptr [BP + -0xe] (1000_2544 / 0x12544)
    int resImul1000_2544 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul1000_2544);
    DX = (ushort)(resImul1000_2544 >> 16);
    CheckExternalEvents(cs8, 0x2549);
    // MOV BX,AX (1000_2547 / 0x12547)
    BX = AX;
    CheckExternalEvents(cs8, 0x254D);
    // MOV ES,word ptr [0x55d4] (1000_2549 / 0x12549)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2553);
    // MOV byte ptr ES:[BX + 0xc620],0x8 (1000_254D / 0x1254D)
    UInt8[ES, (ushort)(BX + 0xC620)] = 0x8;
    CheckExternalEvents(cs8, 0x2556);
    // MOV SI,word ptr [BP + -0xe] (1000_2553 / 0x12553)
    SI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs8, 0x2558);
    // SHL SI,0x1 (1000_2556 / 0x12556)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x255C);
    // MOV ES,word ptr [0x55e0] (1000_2558 / 0x12558)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x2563);
    // MOV word ptr ES:[SI + 0x4072],0x1 (1000_255C / 0x1255C)
    UInt16[ES, (ushort)(SI + 0x4072)] = 0x1;
    CheckExternalEvents(cs8, 0x2566);
    // MOV DI,word ptr [BP + -0x2] (1000_2563 / 0x12563)
    DI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x2568);
    // SHL DI,0x1 (1000_2566 / 0x12566)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs8, 0x256C);
    // MOV ES,word ptr [0x55d2] (1000_2568 / 0x12568)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x2571);
    // MOV AX,word ptr ES:[DI + 0x4004] (1000_256C / 0x1256C)
    AX = UInt16[ES, (ushort)(DI + 0x4004)];
    CheckExternalEvents(cs8, 0x2576);
    // MOV word ptr ES:[SI + 0x400c],AX (1000_2571 / 0x12571)
    UInt16[ES, (ushort)(SI + 0x400C)] = AX;
    CheckExternalEvents(cs8, 0x257A);
    // MOV ES,word ptr [0x55d6] (1000_2576 / 0x12576)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x257F);
    // MOV AX,word ptr ES:[DI + 0x4036] (1000_257A / 0x1257A)
    AX = UInt16[ES, (ushort)(DI + 0x4036)];
    CheckExternalEvents(cs8, 0x2584);
    // MOV word ptr ES:[SI + 0x403e],AX (1000_257F / 0x1257F)
    UInt16[ES, (ushort)(SI + 0x403E)] = AX;
    label_1000_2584_12584:
    CheckExternalEvents(cs8, 0x2587);
    // MOV AX,0x7d (1000_2584 / 0x12584)
    AX = 0x7D;
    CheckExternalEvents(cs8, 0x258A);
    // IMUL word ptr [BP + -0x2] (1000_2587 / 0x12587)
    int resImul1000_2587 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_2587);
    DX = (ushort)(resImul1000_2587 >> 16);
    CheckExternalEvents(cs8, 0x258C);
    // MOV BX,AX (1000_258A / 0x1258A)
    BX = AX;
    CheckExternalEvents(cs8, 0x2590);
    // MOV ES,word ptr [0x55d4] (1000_258C / 0x1258C)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2596);
    // MOV byte ptr ES:[BX + 0xc724],0xff (1000_2590 / 0x12590)
    UInt8[ES, (ushort)(BX + 0xC724)] = 0xFF;
    CheckExternalEvents(cs8, 0x2599);
    // MOV SI,word ptr [BP + -0x2] (1000_2596 / 0x12596)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x259B);
    // SHL SI,0x1 (1000_2599 / 0x12599)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x259F);
    // MOV ES,word ptr [0x55d6] (1000_259B / 0x1259B)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x25A4);
    // PUSH word ptr ES:[SI + 0x4036] (1000_259F / 0x1259F)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs8, 0x25A8);
    // MOV ES,word ptr [0x55d2] (1000_25A4 / 0x125A4)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x25AD);
    // PUSH word ptr ES:[SI + 0x4004] (1000_25A8 / 0x125A8)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs8, 0x25B0);
    // MOV BX,word ptr [BP + -0x2] (1000_25AD / 0x125AD)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x25B4);
    // MOV ES,word ptr [0x5602] (1000_25B0 / 0x125B0)
    ES = UInt16[DS, 0x5602];
    CheckExternalEvents(cs8, 0x25BA);
    // CMP byte ptr ES:[BX + 0xd55e],0x1 (1000_25B4 / 0x125B4)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xD55E)], 0x1);
    CheckExternalEvents(cs8, 0x25BC);
    // SBB AX,AX (1000_25BA / 0x125BA)
    AX = Alu16.Sbb(AX, AX);
    CheckExternalEvents(cs8, 0x25BD);
    // INC AX (1000_25BC / 0x125BC)
    AX++;
    CheckExternalEvents(cs8, 0x25C0);
    // ADD AX,0x80 (1000_25BD / 0x125BD)
    // AX += 0x80;
    AX = Alu16.Add(AX, 0x80);
    CheckExternalEvents(cs8, 0x25C1);
    // PUSH AX (1000_25C0 / 0x125C0)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x25C2);
    // PUSH CS (1000_25C1 / 0x125C1)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x25C5);
    // CALL 0x1000:4279 (1000_25C2 / 0x125C2)
    NearCall(cs8, 0x25C5, ghidra_guess_1000_4279_14279);
    CheckExternalEvents(cs8, 0x25C8);
    // ADD SP,0x6 (1000_25C5 / 0x125C5)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs8, 0x25CB);
    // MOV SI,word ptr [BP + -0x2] (1000_25C8 / 0x125C8)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x25CD);
    // SHL SI,0x1 (1000_25CB / 0x125CB)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x25D0);
    // MOV AX,0xffff (1000_25CD / 0x125CD)
    AX = 0xFFFF;
    CheckExternalEvents(cs8, 0x25D4);
    // MOV ES,word ptr [0x55d6] (1000_25D0 / 0x125D0)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x25D9);
    // MOV word ptr ES:[SI + 0x4036],AX (1000_25D4 / 0x125D4)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs8, 0x25DD);
    // MOV ES,word ptr [0x55d2] (1000_25D9 / 0x125D9)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x25E2);
    // MOV word ptr ES:[SI + 0x4004],AX (1000_25DD / 0x125DD)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    CheckExternalEvents(cs8, 0x25E6);
    // MOV ES,word ptr [0x55e0] (1000_25E2 / 0x125E2)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x25ED);
    // MOV word ptr ES:[SI + 0x406a],0x0 (1000_25E6 / 0x125E6)
    UInt16[ES, (ushort)(SI + 0x406A)] = 0x0;
    CheckExternalEvents(cs8, 0x25F0);
    // JMP 0x1000:2751 (1000_25ED / 0x125ED)
    goto label_1000_2751_12751;
    label_1000_25F0_125F0:
    CheckExternalEvents(cs8, 0x25F3);
    // MOV AX,0x11 (1000_25F0 / 0x125F0)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x25F6);
    // IMUL word ptr [BP + -0xe] (1000_25F3 / 0x125F3)
    int resImul1000_25F3 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul1000_25F3);
    DX = (ushort)(resImul1000_25F3 >> 16);
    CheckExternalEvents(cs8, 0x25F8);
    // MOV BX,AX (1000_25F6 / 0x125F6)
    BX = AX;
    CheckExternalEvents(cs8, 0x25FC);
    // MOV ES,word ptr [0x55d4] (1000_25F8 / 0x125F8)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2601);
    // MOV AL,byte ptr ES:[BX + 0xc614] (1000_25FC / 0x125FC)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs8, 0x2602);
    // CBW  (1000_2601 / 0x12601)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x2604);
    // MOV BX,AX (1000_2602 / 0x12602)
    BX = AX;
    CheckExternalEvents(cs8, 0x2606);
    // SHL BX,0x1 (1000_2604 / 0x12604)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x2608);
    // SHL BX,0x1 (1000_2606 / 0x12606)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x260C);
    // MOV ES,word ptr [0x5600] (1000_2608 / 0x12608)
    ES = UInt16[DS, 0x5600];
    CheckExternalEvents(cs8, 0x2611);
    // PUSH word ptr ES:[BX + 0x1cc] (1000_260C / 0x1260C)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs8, 0x2616);
    // PUSH word ptr ES:[BX + 0x1ca] (1000_2611 / 0x12611)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs8, 0x261B);
    // CALLF 0x1000:8055 (1000_2616 / 0x12616)
    FarCall(cs8, 0x261B, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x261E);
    // ADD SP,0x4 (1000_261B / 0x1261B)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2621);
    // MOV AX,0x36f6 (1000_261E / 0x1261E)
    AX = 0x36F6;
    CheckExternalEvents(cs8, 0x2622);
    // PUSH DS (1000_2621 / 0x12621)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2623);
    // PUSH AX (1000_2622 / 0x12622)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2628);
    // CALLF 0x1000:8055 (1000_2623 / 0x12623)
    FarCall(cs8, 0x2628, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x262B);
    // ADD SP,0x4 (1000_2628 / 0x12628)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x262E);
    // MOV AX,0x3731 (1000_262B / 0x1262B)
    AX = 0x3731;
    CheckExternalEvents(cs8, 0x262F);
    // PUSH DS (1000_262E / 0x1262E)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2630);
    // PUSH AX (1000_262F / 0x1262F)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2635);
    // CALLF 0x1000:8055 (1000_2630 / 0x12630)
    FarCall(cs8, 0x2635, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2638);
    // ADD SP,0x4 (1000_2635 / 0x12635)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x263B);
    // MOV AX,0x3774 (1000_2638 / 0x12638)
    AX = 0x3774;
    CheckExternalEvents(cs8, 0x263C);
    // PUSH DS (1000_263B / 0x1263B)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x263D);
    // PUSH AX (1000_263C / 0x1263C)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2642);
    // CALLF 0x1000:8055 (1000_263D / 0x1263D)
    FarCall(cs8, 0x2642, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2645);
    // ADD SP,0x4 (1000_2642 / 0x12642)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2648);
    // MOV AX,0x7d (1000_2645 / 0x12645)
    AX = 0x7D;
    CheckExternalEvents(cs8, 0x264B);
    // IMUL word ptr [BP + -0x2] (1000_2648 / 0x12648)
    int resImul1000_2648 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_2648);
    DX = (ushort)(resImul1000_2648 >> 16);
    CheckExternalEvents(cs8, 0x264D);
    // MOV SI,AX (1000_264B / 0x1264B)
    SI = AX;
    CheckExternalEvents(cs8, 0x2650);
    // MOV AL,byte ptr [BP + -0xe] (1000_264D / 0x1264D)
    AL = UInt8[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs8, 0x2654);
    // MOV ES,word ptr [0x55d4] (1000_2650 / 0x12650)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2659);
    // MOV byte ptr ES:[SI + 0xc79d],AL (1000_2654 / 0x12654)
    UInt8[ES, (ushort)(SI + 0xC79D)] = AL;
    CheckExternalEvents(cs8, 0x265F);
    // MOV byte ptr ES:[SI + 0xc79e],0xff (1000_2659 / 0x12659)
    UInt8[ES, (ushort)(SI + 0xC79E)] = 0xFF;
    CheckExternalEvents(cs8, 0x2662);
    // MOV SI,word ptr [BP + -0x2] (1000_265F / 0x1265F)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x2664);
    // SHL SI,0x1 (1000_2662 / 0x12662)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x2668);
    // MOV ES,word ptr [0x55d6] (1000_2664 / 0x12664)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x266D);
    // PUSH word ptr ES:[SI + 0x4036] (1000_2668 / 0x12668)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs8, 0x2671);
    // MOV ES,word ptr [0x55d2] (1000_266D / 0x1266D)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x2676);
    // PUSH word ptr ES:[SI + 0x4004] (1000_2671 / 0x12671)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs8, 0x2679);
    // MOV AX,0x7e (1000_2676 / 0x12676)
    AX = 0x7E;
    CheckExternalEvents(cs8, 0x267A);
    // PUSH AX (1000_2679 / 0x12679)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x267B);
    // PUSH CS (1000_267A / 0x1267A)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x267E);
    // CALL 0x1000:4279 (1000_267B / 0x1267B)
    NearCall(cs8, 0x267E, ghidra_guess_1000_4279_14279);
    CheckExternalEvents(cs8, 0x2681);
    // ADD SP,0x6 (1000_267E / 0x1267E)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs8, 0x2684);
    // JMP 0x1000:2751 (1000_2681 / 0x12681)
    goto label_1000_2751_12751;
    label_1000_2684_12684:
    CheckExternalEvents(cs8, 0x2687);
    // MOV AX,0x7d (1000_2684 / 0x12684)
    AX = 0x7D;
    CheckExternalEvents(cs8, 0x268A);
    // IMUL word ptr [BP + -0x2] (1000_2687 / 0x12687)
    int resImul1000_2687 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_2687);
    DX = (ushort)(resImul1000_2687 >> 16);
    CheckExternalEvents(cs8, 0x268C);
    // MOV BX,AX (1000_268A / 0x1268A)
    BX = AX;
    CheckExternalEvents(cs8, 0x2690);
    // MOV ES,word ptr [0x55d4] (1000_268C / 0x1268C)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2696);
    // MOV byte ptr ES:[BX + 0xc79e],0xff (1000_2690 / 0x12690)
    UInt8[ES, (ushort)(BX + 0xC79E)] = 0xFF;
    CheckExternalEvents(cs8, 0x2699);
    // MOV SI,word ptr [BP + -0x2] (1000_2696 / 0x12696)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x269B);
    // SHL SI,0x1 (1000_2699 / 0x12699)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x269F);
    // MOV ES,word ptr [0x55d6] (1000_269B / 0x1269B)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x26A4);
    // PUSH word ptr ES:[SI + 0x4036] (1000_269F / 0x1269F)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs8, 0x26A8);
    // MOV ES,word ptr [0x55d2] (1000_26A4 / 0x126A4)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x26AD);
    // PUSH word ptr ES:[SI + 0x4004] (1000_26A8 / 0x126A8)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs8, 0x26B0);
    // MOV AX,0x7e (1000_26AD / 0x126AD)
    AX = 0x7E;
    CheckExternalEvents(cs8, 0x26B1);
    // PUSH AX (1000_26B0 / 0x126B0)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x26B2);
    // PUSH CS (1000_26B1 / 0x126B1)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x26B5);
    // CALL 0x1000:4279 (1000_26B2 / 0x126B2)
    NearCall(cs8, 0x26B5, ghidra_guess_1000_4279_14279);
    CheckExternalEvents(cs8, 0x26B8);
    // ADD SP,0x6 (1000_26B5 / 0x126B5)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs8, 0x26BB);
    // MOV AX,0x11 (1000_26B8 / 0x126B8)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x26BE);
    // IMUL word ptr [BP + -0x44] (1000_26BB / 0x126BB)
    int resImul1000_26BB = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x44)]);
    AX = (ushort)(resImul1000_26BB);
    DX = (ushort)(resImul1000_26BB >> 16);
    CheckExternalEvents(cs8, 0x26C0);
    // MOV BX,AX (1000_26BE / 0x126BE)
    BX = AX;
    CheckExternalEvents(cs8, 0x26C4);
    // MOV ES,word ptr [0x55d4] (1000_26C0 / 0x126C0)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x26C9);
    // MOV AL,byte ptr ES:[BX + 0xc614] (1000_26C4 / 0x126C4)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs8, 0x26CA);
    // CBW  (1000_26C9 / 0x126C9)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x26CC);
    // MOV BX,AX (1000_26CA / 0x126CA)
    BX = AX;
    CheckExternalEvents(cs8, 0x26CE);
    // SHL BX,0x1 (1000_26CC / 0x126CC)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x26D0);
    // SHL BX,0x1 (1000_26CE / 0x126CE)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x26D4);
    // MOV ES,word ptr [0x5600] (1000_26D0 / 0x126D0)
    ES = UInt16[DS, 0x5600];
    CheckExternalEvents(cs8, 0x26D9);
    // PUSH word ptr ES:[BX + 0x1cc] (1000_26D4 / 0x126D4)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs8, 0x26DE);
    // PUSH word ptr ES:[BX + 0x1ca] (1000_26D9 / 0x126D9)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs8, 0x26E3);
    // CALLF 0x1000:8055 (1000_26DE / 0x126DE)
    FarCall(cs8, 0x26E3, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x26E6);
    // ADD SP,0x4 (1000_26E3 / 0x126E3)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x26E9);
    // MOV AX,0x37b8 (1000_26E6 / 0x126E6)
    AX = 0x37B8;
    CheckExternalEvents(cs8, 0x26EA);
    // PUSH DS (1000_26E9 / 0x126E9)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x26EB);
    // PUSH AX (1000_26EA / 0x126EA)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x26F0);
    // CALLF 0x1000:8055 (1000_26EB / 0x126EB)
    FarCall(cs8, 0x26F0, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x26F3);
    // ADD SP,0x4 (1000_26F0 / 0x126F0)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x26F6);
    // MOV AX,0x37fd (1000_26F3 / 0x126F3)
    AX = 0x37FD;
    CheckExternalEvents(cs8, 0x26F7);
    // PUSH DS (1000_26F6 / 0x126F6)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x26F8);
    // PUSH AX (1000_26F7 / 0x126F7)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x26FD);
    // CALLF 0x1000:8055 (1000_26F8 / 0x126F8)
    FarCall(cs8, 0x26FD, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2700);
    // ADD SP,0x4 (1000_26FD / 0x126FD)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2703);
    // MOV AX,0x7d (1000_2700 / 0x12700)
    AX = 0x7D;
    CheckExternalEvents(cs8, 0x2706);
    // IMUL word ptr [BP + -0x2] (1000_2703 / 0x12703)
    int resImul1000_2703 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_2703);
    DX = (ushort)(resImul1000_2703 >> 16);
    CheckExternalEvents(cs8, 0x2708);
    // MOV BX,AX (1000_2706 / 0x12706)
    BX = AX;
    CheckExternalEvents(cs8, 0x270C);
    // MOV ES,word ptr [0x55d4] (1000_2708 / 0x12708)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x270E);
    // MOV AL,0x11 (1000_270C / 0x1270C)
    AL = 0x11;
    CheckExternalEvents(cs8, 0x2713);
    // MUL byte ptr ES:[BX + 0xc79d] (1000_270E / 0x1270E)
    ushort resMul1000_270E = Alu8.Mul(AL, UInt8[ES, (ushort)(BX + 0xC79D)]);
    AL = (byte)(resMul1000_270E);
    AH = (byte)(resMul1000_270E >> 8);
    CheckExternalEvents(cs8, 0x2715);
    // MOV BX,AX (1000_2713 / 0x12713)
    BX = AX;
    CheckExternalEvents(cs8, 0x271A);
    // MOV AL,byte ptr ES:[BX + 0xc614] (1000_2715 / 0x12715)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs8, 0x271B);
    // CBW  (1000_271A / 0x1271A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x271D);
    // MOV BX,AX (1000_271B / 0x1271B)
    BX = AX;
    CheckExternalEvents(cs8, 0x271F);
    // SHL BX,0x1 (1000_271D / 0x1271D)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x2721);
    // SHL BX,0x1 (1000_271F / 0x1271F)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x2725);
    // MOV ES,word ptr [0x5600] (1000_2721 / 0x12721)
    ES = UInt16[DS, 0x5600];
    CheckExternalEvents(cs8, 0x272A);
    // PUSH word ptr ES:[BX + 0x1cc] (1000_2725 / 0x12725)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs8, 0x272F);
    // PUSH word ptr ES:[BX + 0x1ca] (1000_272A / 0x1272A)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs8, 0x2734);
    // CALLF 0x1000:8055 (1000_272F / 0x1272F)
    FarCall(cs8, 0x2734, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2737);
    // ADD SP,0x4 (1000_2734 / 0x12734)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x273A);
    // MOV AX,0x3830 (1000_2737 / 0x12737)
    AX = 0x3830;
    CheckExternalEvents(cs8, 0x273B);
    // PUSH DS (1000_273A / 0x1273A)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x273C);
    // PUSH AX (1000_273B / 0x1273B)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2741);
    // CALLF 0x1000:8055 (1000_273C / 0x1273C)
    FarCall(cs8, 0x2741, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2744);
    // ADD SP,0x4 (1000_2741 / 0x12741)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2747);
    // MOV AX,0x387a (1000_2744 / 0x12744)
    AX = 0x387A;
    CheckExternalEvents(cs8, 0x2748);
    // PUSH DS (1000_2747 / 0x12747)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2749);
    // PUSH AX (1000_2748 / 0x12748)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x274E);
    // CALLF 0x1000:8055 (1000_2749 / 0x12749)
    FarCall(cs8, 0x274E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2751);
    // ADD SP,0x4 (1000_274E / 0x1274E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_2751_12751:
    CheckExternalEvents(cs8, 0x2756);
    // CALLF 0x1000:933a (1000_2751 / 0x12751)
    FarCall(cs8, 0x2756, unknown_18AD_086A_1933A);
    CheckExternalEvents(cs8, 0x275B);
    // CALLF 0x1000:8d29 (1000_2756 / 0x12756)
    FarCall(cs8, 0x275B, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs8, 0x275E);
    // MOV AX,0x11 (1000_275B / 0x1275B)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x2761);
    // IMUL word ptr [BP + -0x44] (1000_275E / 0x1275E)
    int resImul1000_275E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x44)]);
    AX = (ushort)(resImul1000_275E);
    DX = (ushort)(resImul1000_275E >> 16);
    CheckExternalEvents(cs8, 0x2763);
    // MOV BX,AX (1000_2761 / 0x12761)
    BX = AX;
    CheckExternalEvents(cs8, 0x2767);
    // MOV ES,word ptr [0x55d4] (1000_2763 / 0x12763)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x276D);
    // MOV byte ptr ES:[BX + 0xc614],0xff (1000_2767 / 0x12767)
    UInt8[ES, (ushort)(BX + 0xC614)] = 0xFF;
    CheckExternalEvents(cs8, 0x276F);
    // SUB AX,AX (1000_276D / 0x1276D)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x2772);
    // MOV BX,word ptr [BP + -0x44] (1000_276F / 0x1276F)
    BX = UInt16[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs8, 0x2774);
    // SHL BX,0x1 (1000_2772 / 0x12772)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x2778);
    // MOV ES,word ptr [0x55e0] (1000_2774 / 0x12774)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x277D);
    // MOV word ptr ES:[BX + 0x4072],AX (1000_2778 / 0x12778)
    UInt16[ES, (ushort)(BX + 0x4072)] = AX;
    CheckExternalEvents(cs8, 0x2781);
    // MOV ES,word ptr [0x55d4] (1000_277D / 0x1277D)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2785);
    // MOV ES:[0xd333],AL (1000_2781 / 0x12781)
    UInt8[ES, 0xD333] = AL;
    CheckExternalEvents(cs8, 0x278B);
    // MOV byte ptr ES:[0xd330],0x7f (1000_2785 / 0x12785)
    UInt8[ES, 0xD330] = 0x7F;
    label_1000_278B_1278B:
    CheckExternalEvents(cs8, 0x278F);
    // MOV ES,word ptr [0x55d4] (1000_278B / 0x1278B)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2795);
    // CMP byte ptr ES:[0xd32f],0x0 (1000_278F / 0x1278F)
    Alu8.Sub(UInt8[ES, 0xD32F], 0x0);
    CheckExternalEvents(cs8, 0x2797);
    // JZ 0x1000:27be (1000_2795 / 0x12795)
    if(ZeroFlag) {
      goto label_1000_27BE_127BE;
    }
    CheckExternalEvents(cs8, 0x279B);
    // MOV ES,word ptr [0x55e0] (1000_2797 / 0x12797)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x27A1);
    // CMP word ptr ES:[0x406a],0x0 (1000_279B / 0x1279B)
    Alu16.Sub(UInt16[ES, 0x406A], 0x0);
    CheckExternalEvents(cs8, 0x27A3);
    // JZ 0x1000:27be (1000_27A1 / 0x127A1)
    if(ZeroFlag) {
      goto label_1000_27BE_127BE;
    }
    CheckExternalEvents(cs8, 0x27A7);
    // MOV ES,word ptr [0x55d2] (1000_27A3 / 0x127A3)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x27AE);
    // CMP word ptr ES:[0x4004],0x900 (1000_27A7 / 0x127A7)
    Alu16.Sub(UInt16[ES, 0x4004], 0x900);
    CheckExternalEvents(cs8, 0x27B0);
    // JLE 0x1000:27be (1000_27AE / 0x127AE)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_27BE_127BE;
    }
    CheckExternalEvents(cs8, 0x27B7);
    // CMP word ptr ES:[0x4004],0xa07 (1000_27B0 / 0x127B0)
    Alu16.Sub(UInt16[ES, 0x4004], 0xA07);
    CheckExternalEvents(cs8, 0x27B9);
    // JGE 0x1000:27be (1000_27B7 / 0x127B7)
    if(SignFlag == OverflowFlag) {
      goto label_1000_27BE_127BE;
    }
    CheckExternalEvents(cs8, 0x27BE);
    // MOV word ptr [BP + -0xc],0x1 (1000_27B9 / 0x127B9)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x1;
    label_1000_27BE_127BE:
    CheckExternalEvents(cs8, 0x27C3);
    // MOV word ptr [BP + -0x12],0x1 (1000_27BE / 0x127BE)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    CheckExternalEvents(cs8, 0x27C8);
    // MOV word ptr [BP + -0x2c],0xc (1000_27C3 / 0x127C3)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0xC;
    label_1000_27C8_127C8:
    CheckExternalEvents(cs8, 0x27CB);
    // MOV SI,word ptr [BP + -0x2c] (1000_27C8 / 0x127C8)
    SI = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x27CD);
    // SHL SI,0x1 (1000_27CB / 0x127CB)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x27D1);
    // MOV ES,word ptr [0x55d2] (1000_27CD / 0x127CD)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x27D7);
    // CMP word ptr ES:[SI + 0x4004],-0x1 (1000_27D1 / 0x127D1)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4004)], 0xFFFF);
    CheckExternalEvents(cs8, 0x27D9);
    // JZ 0x1000:27e5 (1000_27D7 / 0x127D7)
    if(ZeroFlag) {
      goto label_1000_27E5_127E5;
    }
    CheckExternalEvents(cs8, 0x27DD);
    // MOV ES,word ptr [0x55d6] (1000_27D9 / 0x127D9)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x27E3);
    // CMP word ptr ES:[SI + 0x4036],-0x1 (1000_27DD / 0x127DD)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4036)], 0xFFFF);
    CheckExternalEvents(cs8, 0x27E5);
    // JNZ 0x1000:27f5 (1000_27E3 / 0x127E3)
    if(!ZeroFlag) {
      goto label_1000_27F5_127F5;
    }
    label_1000_27E5_127E5:
    CheckExternalEvents(cs8, 0x27E8);
    // MOV BX,word ptr [BP + -0x2c] (1000_27E5 / 0x127E5)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x27EA);
    // SHL BX,0x1 (1000_27E8 / 0x127E8)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x27EE);
    // MOV ES,word ptr [0x55e0] (1000_27EA / 0x127EA)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x27F5);
    // MOV word ptr ES:[BX + 0x406a],0x0 (1000_27EE / 0x127EE)
    UInt16[ES, (ushort)(BX + 0x406A)] = 0x0;
    label_1000_27F5_127F5:
    CheckExternalEvents(cs8, 0x27F8);
    // MOV BX,word ptr [BP + -0x2c] (1000_27F5 / 0x127F5)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x27FA);
    // SHL BX,0x1 (1000_27F8 / 0x127F8)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x27FE);
    // MOV ES,word ptr [0x55e0] (1000_27FA / 0x127FA)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x2804);
    // CMP word ptr ES:[BX + 0x406a],0x0 (1000_27FE / 0x127FE)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x406A)], 0x0);
    CheckExternalEvents(cs8, 0x2806);
    // JZ 0x1000:280b (1000_2804 / 0x12804)
    if(ZeroFlag) {
      goto label_1000_280B_1280B;
    }
    CheckExternalEvents(cs8, 0x280B);
    // MOV word ptr [BP + -0x12],0x0 (1000_2806 / 0x12806)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    label_1000_280B_1280B:
    CheckExternalEvents(cs8, 0x280E);
    // INC word ptr [BP + -0x2c] (1000_280B / 0x1280B)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x2812);
    // CMP word ptr [BP + -0x2c],0x18 (1000_280E / 0x1280E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x18);
    CheckExternalEvents(cs8, 0x2814);
    // JL 0x1000:27c8 (1000_2812 / 0x12812)
    if(SignFlag != OverflowFlag) {
      goto label_1000_27C8_127C8;
    }
    CheckExternalEvents(cs8, 0x2818);
    // CMP word ptr [BP + -0x12],0x0 (1000_2814 / 0x12814)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs8, 0x281A);
    // JZ 0x1000:281d (1000_2818 / 0x12818)
    if(ZeroFlag) {
      goto label_1000_281D_1281D;
    }
    CheckExternalEvents(cs8, 0x281D);
    // JMP 0x1000:29a6 (1000_281A / 0x1281A)
    goto label_1000_29A6_129A6;
    label_1000_281D_1281D:
    CheckExternalEvents(cs8, 0x2821);
    // MOV ES,word ptr [0x55fa] (1000_281D / 0x1281D)
    ES = UInt16[DS, 0x55FA];
    CheckExternalEvents(cs8, 0x2827);
    // CMP word ptr ES:[0x374c],0x0 (1000_2821 / 0x12821)
    Alu16.Sub(UInt16[ES, 0x374C], 0x0);
    CheckExternalEvents(cs8, 0x2829);
    // JNZ 0x1000:282c (1000_2827 / 0x12827)
    if(!ZeroFlag) {
      goto label_1000_282C_1282C;
    }
    CheckExternalEvents(cs8, 0x282C);
    // JMP 0x1000:29a6 (1000_2829 / 0x12829)
    goto label_1000_29A6_129A6;
    label_1000_282C_1282C:
    CheckExternalEvents(cs8, 0x2830);
    // CMP word ptr [BP + 0x6],0x0 (1000_282C / 0x1282C)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs8, 0x2832);
    // JZ 0x1000:2835 (1000_2830 / 0x12830)
    if(ZeroFlag) {
      goto label_1000_2835_12835;
    }
    CheckExternalEvents(cs8, 0x2835);
    // JMP 0x1000:29a6 (1000_2832 / 0x12832)
    goto label_1000_29A6_129A6;
    label_1000_2835_12835:
    CheckExternalEvents(cs8, 0x283A);
    // MOV word ptr [BP + -0x42],0x0 (1000_2835 / 0x12835)
    UInt16[SS, (ushort)(BP - 0x42)] = 0x0;
    CheckExternalEvents(cs8, 0x283F);
    // MOV word ptr [BP + -0x2c],0xc (1000_283A / 0x1283A)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0xC;
    label_1000_283F_1283F:
    CheckExternalEvents(cs8, 0x2842);
    // MOV BX,word ptr [BP + -0x2c] (1000_283F / 0x1283F)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x2844);
    // SHL BX,0x1 (1000_2842 / 0x12842)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x2848);
    // MOV ES,word ptr [0x55e0] (1000_2844 / 0x12844)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x284E);
    // CMP word ptr ES:[BX + 0x406a],0x0 (1000_2848 / 0x12848)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x406A)], 0x0);
    CheckExternalEvents(cs8, 0x2850);
    // JZ 0x1000:2855 (1000_284E / 0x1284E)
    if(ZeroFlag) {
      goto label_1000_2855_12855;
    }
    CheckExternalEvents(cs8, 0x2855);
    // MOV word ptr [BP + -0x42],0x1 (1000_2850 / 0x12850)
    UInt16[SS, (ushort)(BP - 0x42)] = 0x1;
    label_1000_2855_12855:
    CheckExternalEvents(cs8, 0x2858);
    // INC word ptr [BP + -0x2c] (1000_2855 / 0x12855)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x285C);
    // CMP word ptr [BP + -0x2c],0x10 (1000_2858 / 0x12858)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x10);
    CheckExternalEvents(cs8, 0x285E);
    // JL 0x1000:283f (1000_285C / 0x1285C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_283F_1283F;
    }
    CheckExternalEvents(cs8, 0x2862);
    // CMP word ptr [BP + -0x42],0x0 (1000_285E / 0x1285E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x42)], 0x0);
    CheckExternalEvents(cs8, 0x2864);
    // JNZ 0x1000:2867 (1000_2862 / 0x12862)
    if(!ZeroFlag) {
      goto label_1000_2867_12867;
    }
    CheckExternalEvents(cs8, 0x2867);
    // JMP 0x1000:2966 (1000_2864 / 0x12864)
    goto label_1000_2966_12966;
    label_1000_2867_12867:
    CheckExternalEvents(cs8, 0x286B);
    // MOV ES,word ptr [0x55cc] (1000_2867 / 0x12867)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x286F);
    // MOV AX,ES:[0xa44b] (1000_286B / 0x1286B)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs8, 0x2872);
    // MOV word ptr [BP + -0x3c],AX (1000_286F / 0x1286F)
    UInt16[SS, (ushort)(BP - 0x3C)] = AX;
    CheckExternalEvents(cs8, 0x2876);
    // MOV ES,word ptr [0x55ce] (1000_2872 / 0x12872)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x287A);
    // MOV AX,ES:[0xa44d] (1000_2876 / 0x12876)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs8, 0x287D);
    // MOV word ptr [BP + -0x3e],AX (1000_287A / 0x1287A)
    UInt16[SS, (ushort)(BP - 0x3E)] = AX;
    CheckExternalEvents(cs8, 0x2881);
    // MOV ES,word ptr [0x55fa] (1000_287D / 0x1287D)
    ES = UInt16[DS, 0x55FA];
    CheckExternalEvents(cs8, 0x2883);
    // SUB AX,AX (1000_2881 / 0x12881)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x2887);
    // MOV ES:[0x374c],AX (1000_2883 / 0x12883)
    UInt16[ES, 0x374C] = AX;
    CheckExternalEvents(cs8, 0x288A);
    // MOV word ptr [BP + -0x40],AX (1000_2887 / 0x12887)
    UInt16[SS, (ushort)(BP - 0x40)] = AX;
    CheckExternalEvents(cs8, 0x288F);
    // MOV word ptr [BP + -0x2c],0x10 (1000_288A / 0x1288A)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x10;
    label_1000_288F_1288F:
    CheckExternalEvents(cs8, 0x2892);
    // MOV SI,word ptr [BP + -0x2c] (1000_288F / 0x1288F)
    SI = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x2894);
    // SHL SI,0x1 (1000_2892 / 0x12892)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x2898);
    // MOV ES,word ptr [0x55e0] (1000_2894 / 0x12894)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x289E);
    // CMP word ptr ES:[SI + 0x406a],0x0 (1000_2898 / 0x12898)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x406A)], 0x0);
    CheckExternalEvents(cs8, 0x28A0);
    // JNZ 0x1000:28a3 (1000_289E / 0x1289E)
    if(!ZeroFlag) {
      goto label_1000_28A3_128A3;
    }
    CheckExternalEvents(cs8, 0x28A3);
    // JMP 0x1000:2927 (1000_28A0 / 0x128A0)
    goto label_1000_2927_12927;
    label_1000_28A3_128A3:
    CheckExternalEvents(cs8, 0x28A7);
    // MOV ES,word ptr [0x55d2] (1000_28A3 / 0x128A3)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x28AC);
    // MOV AX,word ptr ES:[SI + 0x4004] (1000_28A7 / 0x128A7)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs8, 0x28B0);
    // MOV ES,word ptr [0x55cc] (1000_28AC / 0x128AC)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x28B4);
    // MOV ES:[0xa44b],AX (1000_28B0 / 0x128B0)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs8, 0x28B8);
    // MOV ES,word ptr [0x55d6] (1000_28B4 / 0x128B4)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x28BD);
    // MOV AX,word ptr ES:[SI + 0x4036] (1000_28B8 / 0x128B8)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs8, 0x28C1);
    // MOV ES,word ptr [0x55ce] (1000_28BD / 0x128BD)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x28C5);
    // MOV ES:[0xa44d],AX (1000_28C1 / 0x128C1)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs8, 0x28C8);
    // MOV AX,0xc (1000_28C5 / 0x128C5)
    AX = 0xC;
    CheckExternalEvents(cs8, 0x28CB);
    // IMUL word ptr [BP + -0x2c] (1000_28C8 / 0x128C8)
    int resImul1000_28C8 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_28C8);
    DX = (ushort)(resImul1000_28C8 >> 16);
    CheckExternalEvents(cs8, 0x28CD);
    // MOV BX,AX (1000_28CB / 0x128CB)
    BX = AX;
    CheckExternalEvents(cs8, 0x28D1);
    // MOV ES,word ptr [0x55da] (1000_28CD / 0x128CD)
    ES = UInt16[DS, 0x55DA];
    CheckExternalEvents(cs8, 0x28D6);
    // MOV AL,byte ptr ES:[BX + 0x3800] (1000_28D1 / 0x128D1)
    AL = UInt8[ES, (ushort)(BX + 0x3800)];
    CheckExternalEvents(cs8, 0x28D7);
    // CBW  (1000_28D6 / 0x128D6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x28DA);
    // MOV word ptr [BP + -0x1e],AX (1000_28D7 / 0x128D7)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs8, 0x28DC);
    // MOV SI,AX (1000_28DA / 0x128DA)
    SI = AX;
    CheckExternalEvents(cs8, 0x28DE);
    // SHL SI,0x1 (1000_28DC / 0x128DC)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x28E2);
    // MOV ES,word ptr [0x55d6] (1000_28DE / 0x128DE)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x28E7);
    // PUSH word ptr ES:[SI + 0x4036] (1000_28E2 / 0x128E2)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs8, 0x28EB);
    // MOV ES,word ptr [0x55d2] (1000_28E7 / 0x128E7)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x28F0);
    // PUSH word ptr ES:[SI + 0x4004] (1000_28EB / 0x128EB)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs8, 0x28F5);
    // CALLF 0x1000:05c5 (1000_28F0 / 0x128F0)
    FarCall(cs8, 0x28F5, ghidra_guess_1000_05C5_105C5);
    CheckExternalEvents(cs8, 0x28F8);
    // ADD SP,0x4 (1000_28F5 / 0x128F5)
    SP += 0x4;
    CheckExternalEvents(cs8, 0x28FB);
    // CMP AX,0x19 (1000_28F8 / 0x128F8)
    Alu16.Sub(AX, 0x19);
    CheckExternalEvents(cs8, 0x28FD);
    // JLE 0x1000:2927 (1000_28FB / 0x128FB)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_2927_12927;
    }
    CheckExternalEvents(cs8, 0x2902);
    // MOV word ptr [BP + -0x40],0x1 (1000_28FD / 0x128FD)
    UInt16[SS, (ushort)(BP - 0x40)] = 0x1;
    CheckExternalEvents(cs8, 0x2905);
    // MOV SI,word ptr [BP + -0x2c] (1000_2902 / 0x12902)
    SI = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x2907);
    // SHL SI,0x1 (1000_2905 / 0x12905)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x290B);
    // MOV ES,word ptr [0x55e0] (1000_2907 / 0x12907)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x2912);
    // MOV word ptr ES:[SI + 0x406a],0x0 (1000_290B / 0x1290B)
    UInt16[ES, (ushort)(SI + 0x406A)] = 0x0;
    CheckExternalEvents(cs8, 0x2915);
    // MOV AX,0xffff (1000_2912 / 0x12912)
    AX = 0xFFFF;
    CheckExternalEvents(cs8, 0x2919);
    // MOV ES,word ptr [0x55d6] (1000_2915 / 0x12915)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x291E);
    // MOV word ptr ES:[SI + 0x4036],AX (1000_2919 / 0x12919)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs8, 0x2922);
    // MOV ES,word ptr [0x55d2] (1000_291E / 0x1291E)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x2927);
    // MOV word ptr ES:[SI + 0x4004],AX (1000_2922 / 0x12922)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    label_1000_2927_12927:
    CheckExternalEvents(cs8, 0x292A);
    // INC word ptr [BP + -0x2c] (1000_2927 / 0x12927)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x292E);
    // CMP word ptr [BP + -0x2c],0x18 (1000_292A / 0x1292A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x18);
    CheckExternalEvents(cs8, 0x2930);
    // JGE 0x1000:2933 (1000_292E / 0x1292E)
    if(SignFlag == OverflowFlag) {
      goto label_1000_2933_12933;
    }
    CheckExternalEvents(cs8, 0x2933);
    // JMP 0x1000:288f (1000_2930 / 0x12930)
    goto label_1000_288F_1288F;
    label_1000_2933_12933:
    CheckExternalEvents(cs8, 0x2937);
    // CMP word ptr [BP + -0x40],0x0 (1000_2933 / 0x12933)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x40)], 0x0);
    CheckExternalEvents(cs8, 0x2939);
    // JZ 0x1000:2950 (1000_2937 / 0x12937)
    if(ZeroFlag) {
      goto label_1000_2950_12950;
    }
    CheckExternalEvents(cs8, 0x293E);
    // CALLF 0x1000:7bf6 (1000_2939 / 0x12939)
    FarCall(cs8, 0x293E, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs8, 0x2941);
    // MOV AX,0x38bc (1000_293E / 0x1293E)
    AX = 0x38BC;
    CheckExternalEvents(cs8, 0x2942);
    // PUSH DS (1000_2941 / 0x12941)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2943);
    // PUSH AX (1000_2942 / 0x12942)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2948);
    // CALLF 0x1000:7c1a (1000_2943 / 0x12943)
    FarCall(cs8, 0x2948, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs8, 0x294B);
    // ADD SP,0x4 (1000_2948 / 0x12948)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2950);
    // CALLF 0x1000:8d29 (1000_294B / 0x1294B)
    FarCall(cs8, 0x2950, unknown_18AD_0259_18D29);
    label_1000_2950_12950:
    CheckExternalEvents(cs8, 0x2954);
    // MOV ES,word ptr [0x55cc] (1000_2950 / 0x12950)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x2957);
    // MOV AX,word ptr [BP + -0x3c] (1000_2954 / 0x12954)
    AX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs8, 0x295B);
    // MOV ES:[0xa44b],AX (1000_2957 / 0x12957)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs8, 0x295F);
    // MOV ES,word ptr [0x55ce] (1000_295B / 0x1295B)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x2962);
    // MOV AX,word ptr [BP + -0x3e] (1000_295F / 0x1295F)
    AX = UInt16[SS, (ushort)(BP - 0x3E)];
    CheckExternalEvents(cs8, 0x2966);
    // MOV ES:[0xa44d],AX (1000_2962 / 0x12962)
    UInt16[ES, 0xA44D] = AX;
    label_1000_2966_12966:
    CheckExternalEvents(cs8, 0x296A);
    // MOV ES,word ptr [0x55fa] (1000_2966 / 0x12966)
    ES = UInt16[DS, 0x55FA];
    CheckExternalEvents(cs8, 0x2970);
    // CMP word ptr ES:[0x374c],0x0 (1000_296A / 0x1296A)
    Alu16.Sub(UInt16[ES, 0x374C], 0x0);
    CheckExternalEvents(cs8, 0x2972);
    // JZ 0x1000:2982 (1000_2970 / 0x12970)
    if(ZeroFlag) {
      goto label_1000_2982_12982;
    }
    CheckExternalEvents(cs8, 0x2977);
    // CALLF 0x1000:aab0 (1000_2972 / 0x12972)
    FarCall(cs8, 0x2977, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs8, 0x297A);
    // AND AX,0x1 (1000_2977 / 0x12977)
    // AX &= 0x1;
    AX = Alu16.And(AX, 0x1);
    CheckExternalEvents(cs8, 0x297E);
    // MOV ES,word ptr [0x55fa] (1000_297A / 0x1297A)
    ES = UInt16[DS, 0x55FA];
    CheckExternalEvents(cs8, 0x2982);
    // MOV ES:[0x374c],AX (1000_297E / 0x1297E)
    UInt16[ES, 0x374C] = AX;
    label_1000_2982_12982:
    CheckExternalEvents(cs8, 0x2988);
    // CMP word ptr ES:[0x374c],0x0 (1000_2982 / 0x12982)
    Alu16.Sub(UInt16[ES, 0x374C], 0x0);
    CheckExternalEvents(cs8, 0x298A);
    // JZ 0x1000:29a6 (1000_2988 / 0x12988)
    if(ZeroFlag) {
      goto label_1000_29A6_129A6;
    }
    CheckExternalEvents(cs8, 0x298F);
    // MOV word ptr [BP + -0x12],0x1 (1000_298A / 0x1298A)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    CheckExternalEvents(cs8, 0x2994);
    // CALLF 0x1000:7bf6 (1000_298F / 0x1298F)
    FarCall(cs8, 0x2994, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs8, 0x2997);
    // MOV AX,0x38e0 (1000_2994 / 0x12994)
    AX = 0x38E0;
    CheckExternalEvents(cs8, 0x2998);
    // PUSH DS (1000_2997 / 0x12997)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2999);
    // PUSH AX (1000_2998 / 0x12998)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x299E);
    // CALLF 0x1000:7c1a (1000_2999 / 0x12999)
    FarCall(cs8, 0x299E, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs8, 0x29A1);
    // ADD SP,0x4 (1000_299E / 0x1299E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x29A6);
    // CALLF 0x1000:8d29 (1000_29A1 / 0x129A1)
    FarCall(cs8, 0x29A6, unknown_18AD_0259_18D29);
    label_1000_29A6_129A6:
    CheckExternalEvents(cs8, 0x29AA);
    // CMP word ptr [BP + 0x6],0x1 (1000_29A6 / 0x129A6)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x1);
    CheckExternalEvents(cs8, 0x29AC);
    // JNZ 0x1000:29bd (1000_29AA / 0x129AA)
    if(!ZeroFlag) {
      goto label_1000_29BD_129BD;
    }
    CheckExternalEvents(cs8, 0x29B0);
    // MOV ES,word ptr [0x55e0] (1000_29AC / 0x129AC)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x29B6);
    // CMP word ptr ES:[0x406a],0x0 (1000_29B0 / 0x129B0)
    Alu16.Sub(UInt16[ES, 0x406A], 0x0);
    CheckExternalEvents(cs8, 0x29B8);
    // JNZ 0x1000:29bd (1000_29B6 / 0x129B6)
    if(!ZeroFlag) {
      goto label_1000_29BD_129BD;
    }
    CheckExternalEvents(cs8, 0x29BD);
    // MOV word ptr [BP + -0x12],0x1 (1000_29B8 / 0x129B8)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    label_1000_29BD_129BD:
    CheckExternalEvents(cs8, 0x29C1);
    // CMP word ptr [BP + -0xc],0x0 (1000_29BD / 0x129BD)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs8, 0x29C3);
    // JNZ 0x1000:29e6 (1000_29C1 / 0x129C1)
    if(!ZeroFlag) {
      goto label_1000_29E6_129E6;
    }
    CheckExternalEvents(cs8, 0x29C7);
    // CMP word ptr [BP + 0x6],0x2 (1000_29C3 / 0x129C3)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x2);
    CheckExternalEvents(cs8, 0x29C9);
    // JNZ 0x1000:29e6 (1000_29C7 / 0x129C7)
    if(!ZeroFlag) {
      goto label_1000_29E6_129E6;
    }
    CheckExternalEvents(cs8, 0x29CD);
    // MOV ES,word ptr [0x55e0] (1000_29C9 / 0x129C9)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs8, 0x29D3);
    // CMP word ptr ES:[0x406a],0x0 (1000_29CD / 0x129CD)
    Alu16.Sub(UInt16[ES, 0x406A], 0x0);
    CheckExternalEvents(cs8, 0x29D5);
    // JNZ 0x1000:29e6 (1000_29D3 / 0x129D3)
    if(!ZeroFlag) {
      goto label_1000_29E6_129E6;
    }
    CheckExternalEvents(cs8, 0x29D9);
    // MOV ES,word ptr [0x55d4] (1000_29D5 / 0x129D5)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x29DF);
    // CMP byte ptr ES:[0xd32f],0x0 (1000_29D9 / 0x129D9)
    Alu8.Sub(UInt8[ES, 0xD32F], 0x0);
    CheckExternalEvents(cs8, 0x29E1);
    // JNZ 0x1000:29e6 (1000_29DF / 0x129DF)
    if(!ZeroFlag) {
      goto label_1000_29E6_129E6;
    }
    CheckExternalEvents(cs8, 0x29E6);
    // MOV word ptr [BP + -0x12],0x1 (1000_29E1 / 0x129E1)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    label_1000_29E6_129E6:
    CheckExternalEvents(cs8, 0x29EA);
    // CMP word ptr [BP + -0xc],0x0 (1000_29E6 / 0x129E6)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs8, 0x29EC);
    // JZ 0x1000:29f1 (1000_29EA / 0x129EA)
    if(ZeroFlag) {
      goto label_1000_29F1_129F1;
    }
    CheckExternalEvents(cs8, 0x29F1);
    // MOV word ptr [BP + -0x12],0x1 (1000_29EC / 0x129EC)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    label_1000_29F1_129F1:
    CheckExternalEvents(cs8, 0x29F5);
    // MOV ES,word ptr [0x55fc] (1000_29F1 / 0x129F1)
    ES = UInt16[DS, 0x55FC];
    CheckExternalEvents(cs8, 0x29FB);
    // CMP word ptr ES:[0x14a],0x0 (1000_29F5 / 0x129F5)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs8, 0x29FD);
    // JNZ 0x1000:2a02 (1000_29FB / 0x129FB)
    if(!ZeroFlag) {
      goto label_1000_2A02_12A02;
    }
    CheckExternalEvents(cs8, 0x2A02);
    // MOV word ptr [BP + -0x12],0x1 (1000_29FD / 0x129FD)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    label_1000_2A02_12A02:
    CheckExternalEvents(cs8, 0x2A06);
    // MOV ES,word ptr [0x55ee] (1000_2A02 / 0x12A02)
    ES = UInt16[DS, 0x55EE];
    CheckExternalEvents(cs8, 0x2A0C);
    // CMP word ptr ES:[0x3772],0x0 (1000_2A06 / 0x12A06)
    Alu16.Sub(UInt16[ES, 0x3772], 0x0);
    CheckExternalEvents(cs8, 0x2A0E);
    // JNZ 0x1000:2a11 (1000_2A0C / 0x12A0C)
    if(!ZeroFlag) {
      goto label_1000_2A11_12A11;
    }
    CheckExternalEvents(cs8, 0x2A11);
    // JMP 0x1000:2aad (1000_2A0E / 0x12A0E)
    goto label_1000_2AAD_12AAD;
    label_1000_2A11_12A11:
    CheckExternalEvents(cs8, 0x2A16);
    // MOV word ptr [BP + -0x4],0x1 (1000_2A11 / 0x12A11)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    CheckExternalEvents(cs8, 0x2A1A);
    // CMP word ptr [BP + -0x12],0x0 (1000_2A16 / 0x12A16)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs8, 0x2A1C);
    // JNZ 0x1000:2a1f (1000_2A1A / 0x12A1A)
    if(!ZeroFlag) {
      goto label_1000_2A1F_12A1F;
    }
    CheckExternalEvents(cs8, 0x2A1F);
    // JMP 0x1000:2aa0 (1000_2A1C / 0x12A1C)
    goto label_1000_2AA0_12AA0;
    label_1000_2A1F_12A1F:
    CheckExternalEvents(cs8, 0x2A22);
    // MOV AX,0x5 (1000_2A1F / 0x12A1F)
    AX = 0x5;
    CheckExternalEvents(cs8, 0x2A25);
    // SUB AX,word ptr [BP + -0x8] (1000_2A22 / 0x12A22)
    // AX -= UInt16[SS, (ushort)(BP - 0x8)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs8, 0x2A28);
    // MOV word ptr [BP + -0x4],AX (1000_2A25 / 0x12A25)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs8, 0x2A2A);
    // JMP 0x1000:2aa0 (1000_2A28 / 0x12A28)
    goto label_1000_2AA0_12AA0;
    label_1000_2A2A_12A2A:
    CheckExternalEvents(cs8, 0x2A2E);
    // CMP word ptr [BP + -0x8],0x5 (1000_2A2A / 0x12A2A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x5);
    CheckExternalEvents(cs8, 0x2A30);
    // JGE 0x1000:2aa0 (1000_2A2E / 0x12A2E)
    if(SignFlag == OverflowFlag) {
      goto label_1000_2AA0_12AA0;
    }
    CheckExternalEvents(cs8, 0x2A34);
    // CMP word ptr [BP + -0x8],0x1 (1000_2A30 / 0x12A30)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x1);
    CheckExternalEvents(cs8, 0x2A36);
    // JNZ 0x1000:2a46 (1000_2A34 / 0x12A34)
    if(!ZeroFlag) {
      goto label_1000_2A46_12A46;
    }
    CheckExternalEvents(cs8, 0x2A39);
    // MOV AX,0x1 (1000_2A36 / 0x12A36)
    AX = 0x1;
    CheckExternalEvents(cs8, 0x2A3A);
    // PUSH AX (1000_2A39 / 0x12A39)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2A3D);
    // MOV AX,0x2 (1000_2A3A / 0x12A3A)
    AX = 0x2;
    CheckExternalEvents(cs8, 0x2A3E);
    // PUSH AX (1000_2A3D / 0x12A3D)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2A43);
    // CALLF 0x0000:5fb7 (1000_2A3E / 0x12A3E)
    FarCall(cs8, 0x2A43, unknown_0170_48B7_05FB7);
    CheckExternalEvents(cs8, 0x2A46);
    // ADD SP,0x4 (1000_2A43 / 0x12A43)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_2A46_12A46:
    CheckExternalEvents(cs8, 0x2A4B);
    // CALLF 0x1000:7bf6 (1000_2A46 / 0x12A46)
    FarCall(cs8, 0x2A4B, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs8, 0x2A4E);
    // MOV BX,word ptr [BP + -0x8] (1000_2A4B / 0x12A4B)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs8, 0x2A51);
    // INC word ptr [BP + -0x8] (1000_2A4E / 0x12A4E)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    CheckExternalEvents(cs8, 0x2A53);
    // SHL BX,0x1 (1000_2A51 / 0x12A51)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x2A55);
    // SHL BX,0x1 (1000_2A53 / 0x12A53)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x2A59);
    // PUSH word ptr [BX + 0x3a30] (1000_2A55 / 0x12A55)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x3A30)]);
    CheckExternalEvents(cs8, 0x2A5D);
    // PUSH word ptr [BX + 0x3a2e] (1000_2A59 / 0x12A59)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x3A2E)]);
    CheckExternalEvents(cs8, 0x2A62);
    // CALLF 0x1000:7c1a (1000_2A5D / 0x12A5D)
    FarCall(cs8, 0x2A62, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs8, 0x2A65);
    // ADD SP,0x4 (1000_2A62 / 0x12A62)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2A6A);
    // CALLF 0x1000:8d29 (1000_2A65 / 0x12A65)
    FarCall(cs8, 0x2A6A, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs8, 0x2A6E);
    // CMP word ptr [BP + -0x8],0x3 (1000_2A6A / 0x12A6A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x3);
    CheckExternalEvents(cs8, 0x2A70);
    // JNZ 0x1000:2a8f (1000_2A6E / 0x12A6E)
    if(!ZeroFlag) {
      goto label_1000_2A8F_12A8F;
    }
    CheckExternalEvents(cs8, 0x2A73);
    // MOV AX,0xb (1000_2A70 / 0x12A70)
    AX = 0xB;
    CheckExternalEvents(cs8, 0x2A74);
    // PUSH AX (1000_2A73 / 0x12A73)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2A77);
    // MOV AX,0x4 (1000_2A74 / 0x12A74)
    AX = 0x4;
    CheckExternalEvents(cs8, 0x2A78);
    // PUSH AX (1000_2A77 / 0x12A77)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2A7D);
    // CALLF 0x0000:44a8 (1000_2A78 / 0x12A78)
    FarCall(cs8, 0x2A7D, unknown_0170_2DA8_044A8);
    CheckExternalEvents(cs8, 0x2A80);
    // ADD SP,0x4 (1000_2A7D / 0x12A7D)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2A85);
    // CALLF 0x1000:bc98 (1000_2A80 / 0x12A80)
    FarCall(cs8, 0x2A85, unknown_19EF_1DA8_1BC98);
    CheckExternalEvents(cs8, 0x2A89);
    // MOV ES,word ptr [0x5604] (1000_2A85 / 0x12A85)
    ES = UInt16[DS, 0x5604];
    CheckExternalEvents(cs8, 0x2A8F);
    // MOV byte ptr ES:[0xfc],0xb (1000_2A89 / 0x12A89)
    UInt8[ES, 0xFC] = 0xB;
    label_1000_2A8F_12A8F:
    CheckExternalEvents(cs8, 0x2A92);
    // MOV AX,0x4 (1000_2A8F / 0x12A8F)
    AX = 0x4;
    CheckExternalEvents(cs8, 0x2A93);
    // PUSH AX (1000_2A92 / 0x12A92)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2A98);
    // CALLF 0x1000:7ee1 (1000_2A93 / 0x12A93)
    FarCall(cs8, 0x2A98, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs8, 0x2A9B);
    // ADD SP,0x2 (1000_2A98 / 0x12A98)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2AA0);
    // CALLF 0x1000:7fe8 (1000_2A9B / 0x12A9B)
    FarCall(cs8, 0x2AA0, unknown_17C6_0388_17FE8);
    label_1000_2AA0_12AA0:
    CheckExternalEvents(cs8, 0x2AA3);
    // MOV AX,word ptr [BP + -0x4] (1000_2AA0 / 0x12AA0)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs8, 0x2AA6);
    // DEC word ptr [BP + -0x4] (1000_2AA3 / 0x12AA3)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs8, 0x2AA8);
    // OR AX,AX (1000_2AA6 / 0x12AA6)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs8, 0x2AAA);
    // JZ 0x1000:2aad (1000_2AA8 / 0x12AA8)
    if(ZeroFlag) {
      goto label_1000_2AAD_12AAD;
    }
    CheckExternalEvents(cs8, 0x2AAD);
    // JMP 0x1000:2a2a (1000_2AAA / 0x12AAA)
    goto label_1000_2A2A_12A2A;
    label_1000_2AAD_12AAD:
    CheckExternalEvents(cs8, 0x2AB1);
    // MOV ES,word ptr [0x55f0] (1000_2AAD / 0x12AAD)
    ES = UInt16[DS, 0x55F0];
    CheckExternalEvents(cs8, 0x2AB7);
    // CMP word ptr ES:[0x9e],0x0 (1000_2AB1 / 0x12AB1)
    Alu16.Sub(UInt16[ES, 0x9E], 0x0);
    CheckExternalEvents(cs8, 0x2AB9);
    // JZ 0x1000:2ade (1000_2AB7 / 0x12AB7)
    if(ZeroFlag) {
      goto label_1000_2ADE_12ADE;
    }
    CheckExternalEvents(cs8, 0x2ABD);
    // MOV ES,word ptr [0x5606] (1000_2AB9 / 0x12AB9)
    ES = UInt16[DS, 0x5606];
    CheckExternalEvents(cs8, 0x2AC3);
    // CMP word ptr ES:[0x3938],0x0 (1000_2ABD / 0x12ABD)
    Alu16.Sub(UInt16[ES, 0x3938], 0x0);
    CheckExternalEvents(cs8, 0x2AC5);
    // JNZ 0x1000:2ade (1000_2AC3 / 0x12AC3)
    if(!ZeroFlag) {
      goto label_1000_2ADE_12ADE;
    }
    CheckExternalEvents(cs8, 0x2ACA);
    // CALLF 0x1000:8aff (1000_2AC5 / 0x12AC5)
    FarCall(cs8, 0x2ACA, unknown_18AD_002F_18AFF);
    CheckExternalEvents(cs8, 0x2ACC);
    // OR AX,AX (1000_2ACA / 0x12ACA)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs8, 0x2ACE);
    // JZ 0x1000:2ade (1000_2ACC / 0x12ACC)
    if(ZeroFlag) {
      goto label_1000_2ADE_12ADE;
    }
    CheckExternalEvents(cs8, 0x2AD2);
    // MOV ES,word ptr [0x55f0] (1000_2ACE / 0x12ACE)
    ES = UInt16[DS, 0x55F0];
    CheckExternalEvents(cs8, 0x2AD9);
    // MOV word ptr ES:[0x9e],0x0 (1000_2AD2 / 0x12AD2)
    UInt16[ES, 0x9E] = 0x0;
    CheckExternalEvents(cs8, 0x2ADE);
    // CALLF 0x0000:412b (1000_2AD9 / 0x12AD9)
    FarCall(cs8, 0x2ADE, unknown_0170_2A2B_0412B);
    label_1000_2ADE_12ADE:
    CheckExternalEvents(cs8, 0x2AE2);
    // CMP word ptr [BP + -0x12],0x0 (1000_2ADE / 0x12ADE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs8, 0x2AE4);
    // JNZ 0x1000:2ae7 (1000_2AE2 / 0x12AE2)
    if(!ZeroFlag) {
      goto label_1000_2AE7_12AE7;
    }
    CheckExternalEvents(cs8, 0x2AE7);
    // JMP 0x1000:201b (1000_2AE4 / 0x12AE4)
    goto label_1000_201B_1201B;
    label_1000_2AE7_12AE7:
    CheckExternalEvents(cs8, 0x2AEB);
    // CMP word ptr [BP + -0xa],0x0 (1000_2AE7 / 0x12AE7)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x0);
    CheckExternalEvents(cs8, 0x2AED);
    // JNZ 0x1000:2af0 (1000_2AEB / 0x12AEB)
    if(!ZeroFlag) {
      goto label_1000_2AF0_12AF0;
    }
    CheckExternalEvents(cs8, 0x2AF0);
    // JMP 0x1000:2ebd (1000_2AED / 0x12AED)
    goto label_1000_2EBD_12EBD;
    label_1000_2AF0_12AF0:
    CheckExternalEvents(cs8, 0x2AF3);
    // MOV AX,0x3 (1000_2AF0 / 0x12AF0)
    AX = 0x3;
    CheckExternalEvents(cs8, 0x2AF4);
    // PUSH AX (1000_2AF3 / 0x12AF3)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2AF9);
    // CALLF 0x1000:7ee1 (1000_2AF4 / 0x12AF4)
    FarCall(cs8, 0x2AF9, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs8, 0x2AFC);
    // ADD SP,0x2 (1000_2AF9 / 0x12AF9)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2B01);
    // CALLF 0x1000:7fe8 (1000_2AFC / 0x12AFC)
    FarCall(cs8, 0x2B01, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs8, 0x2B05);
    // CMP word ptr [BP + 0x6],0x1 (1000_2B01 / 0x12B01)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x1);
    CheckExternalEvents(cs8, 0x2B07);
    // JL 0x1000:2b10 (1000_2B05 / 0x12B05)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2B10_12B10;
    }
    CheckExternalEvents(cs8, 0x2B0B);
    // CMP word ptr [BP + 0x6],0x3 (1000_2B07 / 0x12B07)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x3);
    CheckExternalEvents(cs8, 0x2B0D);
    // JZ 0x1000:2b10 (1000_2B0B / 0x12B0B)
    if(ZeroFlag) {
      goto label_1000_2B10_12B10;
    }
    CheckExternalEvents(cs8, 0x2B10);
    // JMP 0x1000:2e1d (1000_2B0D / 0x12B0D)
    goto label_1000_2E1D_12E1D;
    label_1000_2B10_12B10:
    CheckExternalEvents(cs8, 0x2B14);
    // CMP word ptr [BP + -0x6],0x0 (1000_2B10 / 0x12B10)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs8, 0x2B16);
    // JNZ 0x1000:2b19 (1000_2B14 / 0x12B14)
    if(!ZeroFlag) {
      goto label_1000_2B19_12B19;
    }
    CheckExternalEvents(cs8, 0x2B19);
    // JMP 0x1000:2d6f (1000_2B16 / 0x12B16)
    goto label_1000_2D6F_12D6F;
    label_1000_2B19_12B19:
    CheckExternalEvents(cs8, 0x2B1D);
    // CMP word ptr [BP + -0x38],0x0 (1000_2B19 / 0x12B19)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x38)], 0x0);
    CheckExternalEvents(cs8, 0x2B1F);
    // JZ 0x1000:2b22 (1000_2B1D / 0x12B1D)
    if(ZeroFlag) {
      goto label_1000_2B22_12B22;
    }
    CheckExternalEvents(cs8, 0x2B22);
    // JMP 0x1000:2d6f (1000_2B1F / 0x12B1F)
    goto label_1000_2D6F_12D6F;
    label_1000_2B22_12B22:
    CheckExternalEvents(cs8, 0x2B26);
    // MOV ES,word ptr [0x55fc] (1000_2B22 / 0x12B22)
    ES = UInt16[DS, 0x55FC];
    CheckExternalEvents(cs8, 0x2B2C);
    // CMP word ptr ES:[0x14a],0x0 (1000_2B26 / 0x12B26)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs8, 0x2B2E);
    // JNZ 0x1000:2b31 (1000_2B2C / 0x12B2C)
    if(!ZeroFlag) {
      goto label_1000_2B31_12B31;
    }
    CheckExternalEvents(cs8, 0x2B31);
    // JMP 0x1000:2d6f (1000_2B2E / 0x12B2E)
    goto label_1000_2D6F_12D6F;
    label_1000_2B31_12B31:
    CheckExternalEvents(cs8, 0x2B34);
    // MOV AX,0x1 (1000_2B31 / 0x12B31)
    AX = 0x1;
    CheckExternalEvents(cs8, 0x2B35);
    // PUSH AX (1000_2B34 / 0x12B34)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2B3A);
    // CALLF 0x1000:7ee1 (1000_2B35 / 0x12B35)
    FarCall(cs8, 0x2B3A, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs8, 0x2B3D);
    // ADD SP,0x2 (1000_2B3A / 0x12B3A)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2B40);
    // MOV AX,0x1 (1000_2B3D / 0x12B3D)
    AX = 0x1;
    CheckExternalEvents(cs8, 0x2B41);
    // PUSH AX (1000_2B40 / 0x12B40)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2B46);
    // CALLF 0x1000:7c64 (1000_2B41 / 0x12B41)
    FarCall(cs8, 0x2B46, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs8, 0x2B49);
    // ADD SP,0x2 (1000_2B46 / 0x12B46)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2B4E);
    // CALLF 0x1000:7fe8 (1000_2B49 / 0x12B49)
    FarCall(cs8, 0x2B4E, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs8, 0x2B53);
    // MOV word ptr [BP + -0x3a],0x0 (1000_2B4E / 0x12B4E)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x0;
    CheckExternalEvents(cs8, 0x2B58);
    // MOV word ptr [BP + -0x2c],0xc (1000_2B53 / 0x12B53)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0xC;
    label_1000_2B58_12B58:
    CheckExternalEvents(cs8, 0x2B5B);
    // MOV BX,word ptr [BP + -0x2c] (1000_2B58 / 0x12B58)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x2B5D);
    // SHL BX,0x1 (1000_2B5B / 0x12B5B)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x2B61);
    // MOV ES,word ptr [0x55de] (1000_2B5D / 0x12B5D)
    ES = UInt16[DS, 0x55DE];
    CheckExternalEvents(cs8, 0x2B67);
    // CMP word ptr ES:[BX + 0x393c],0x0 (1000_2B61 / 0x12B61)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x393C)], 0x0);
    CheckExternalEvents(cs8, 0x2B69);
    // JZ 0x1000:2b6e (1000_2B67 / 0x12B67)
    if(ZeroFlag) {
      goto label_1000_2B6E_12B6E;
    }
    CheckExternalEvents(cs8, 0x2B6E);
    // MOV word ptr [BP + -0x3a],0x1 (1000_2B69 / 0x12B69)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x1;
    label_1000_2B6E_12B6E:
    CheckExternalEvents(cs8, 0x2B71);
    // INC word ptr [BP + -0x2c] (1000_2B6E / 0x12B6E)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x2B75);
    // CMP word ptr [BP + -0x2c],0x18 (1000_2B71 / 0x12B71)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x18);
    CheckExternalEvents(cs8, 0x2B77);
    // JL 0x1000:2b58 (1000_2B75 / 0x12B75)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2B58_12B58;
    }
    CheckExternalEvents(cs8, 0x2B7B);
    // CMP word ptr [BP + -0x3a],0x0 (1000_2B77 / 0x12B77)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x0);
    CheckExternalEvents(cs8, 0x2B7D);
    // JZ 0x1000:2b8f (1000_2B7B / 0x12B7B)
    if(ZeroFlag) {
      goto label_1000_2B8F_12B8F;
    }
    CheckExternalEvents(cs8, 0x2B80);
    // MOV AX,0x38fc (1000_2B7D / 0x12B7D)
    AX = 0x38FC;
    CheckExternalEvents(cs8, 0x2B81);
    // PUSH DS (1000_2B80 / 0x12B80)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2B82);
    // PUSH AX (1000_2B81 / 0x12B81)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2B87);
    // CALLF 0x1000:8055 (1000_2B82 / 0x12B82)
    FarCall(cs8, 0x2B87, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2B8A);
    // ADD SP,0x4 (1000_2B87 / 0x12B87)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2B8F);
    // CALLF 0x0000:414f (1000_2B8A / 0x12B8A)
    FarCall(cs8, 0x2B8F, ghidra_guess_0000_414F_0414F);
    label_1000_2B8F_12B8F:
    CheckExternalEvents(cs8, 0x2B94);
    // MOV word ptr [BP + -0x3a],0x0 (1000_2B8F / 0x12B8F)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x0;
    CheckExternalEvents(cs8, 0x2B99);
    // MOV word ptr [BP + -0x2c],0x0 (1000_2B94 / 0x12B94)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_1000_2B99_12B99:
    CheckExternalEvents(cs8, 0x2B9C);
    // MOV AX,0x7d (1000_2B99 / 0x12B99)
    AX = 0x7D;
    CheckExternalEvents(cs8, 0x2B9F);
    // IMUL word ptr [BP + -0x2c] (1000_2B9C / 0x12B9C)
    int resImul1000_2B9C = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_2B9C);
    DX = (ushort)(resImul1000_2B9C >> 16);
    CheckExternalEvents(cs8, 0x2BA1);
    // MOV BX,AX (1000_2B9F / 0x12B9F)
    BX = AX;
    CheckExternalEvents(cs8, 0x2BA5);
    // MOV ES,word ptr [0x55d4] (1000_2BA1 / 0x12BA1)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2BAB);
    // CMP byte ptr ES:[BX + 0xc724],0xff (1000_2BA5 / 0x12BA5)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs8, 0x2BAD);
    // JZ 0x1000:2bb2 (1000_2BAB / 0x12BAB)
    if(ZeroFlag) {
      goto label_1000_2BB2_12BB2;
    }
    CheckExternalEvents(cs8, 0x2BB2);
    // MOV word ptr [BP + -0x3a],0x1 (1000_2BAD / 0x12BAD)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x1;
    label_1000_2BB2_12BB2:
    CheckExternalEvents(cs8, 0x2BB5);
    // INC word ptr [BP + -0x2c] (1000_2BB2 / 0x12BB2)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x2BB9);
    // CMP word ptr [BP + -0x2c],0x4 (1000_2BB5 / 0x12BB5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x4);
    CheckExternalEvents(cs8, 0x2BBB);
    // JL 0x1000:2b99 (1000_2BB9 / 0x12BB9)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2B99_12B99;
    }
    CheckExternalEvents(cs8, 0x2BBF);
    // CMP word ptr [BP + -0x3a],0x0 (1000_2BBB / 0x12BBB)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x0);
    CheckExternalEvents(cs8, 0x2BC1);
    // JZ 0x1000:2c2c (1000_2BBF / 0x12BBF)
    if(ZeroFlag) {
      goto label_1000_2C2C_12C2C;
    }
    CheckExternalEvents(cs8, 0x2BC6);
    // MOV word ptr [BP + -0x3a],0x0 (1000_2BC1 / 0x12BC1)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x0;
    CheckExternalEvents(cs8, 0x2BCB);
    // MOV word ptr [BP + -0x2c],0xc (1000_2BC6 / 0x12BC6)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0xC;
    label_1000_2BCB_12BCB:
    CheckExternalEvents(cs8, 0x2BCE);
    // MOV BX,word ptr [BP + -0x2c] (1000_2BCB / 0x12BCB)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x2BD0);
    // SHL BX,0x1 (1000_2BCE / 0x12BCE)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x2BD4);
    // MOV ES,word ptr [0x55de] (1000_2BD0 / 0x12BD0)
    ES = UInt16[DS, 0x55DE];
    CheckExternalEvents(cs8, 0x2BDA);
    // CMP word ptr ES:[BX + 0x393c],0x0 (1000_2BD4 / 0x12BD4)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x393C)], 0x0);
    CheckExternalEvents(cs8, 0x2BDC);
    // JZ 0x1000:2be1 (1000_2BDA / 0x12BDA)
    if(ZeroFlag) {
      goto label_1000_2BE1_12BE1;
    }
    CheckExternalEvents(cs8, 0x2BE1);
    // MOV word ptr [BP + -0x3a],0x1 (1000_2BDC / 0x12BDC)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x1;
    label_1000_2BE1_12BE1:
    CheckExternalEvents(cs8, 0x2BE4);
    // INC word ptr [BP + -0x2c] (1000_2BE1 / 0x12BE1)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x2BE8);
    // CMP word ptr [BP + -0x2c],0x10 (1000_2BE4 / 0x12BE4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x10);
    CheckExternalEvents(cs8, 0x2BEA);
    // JL 0x1000:2bcb (1000_2BE8 / 0x12BE8)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2BCB_12BCB;
    }
    CheckExternalEvents(cs8, 0x2BEE);
    // CMP word ptr [BP + -0x3a],0x0 (1000_2BEA / 0x12BEA)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x0);
    CheckExternalEvents(cs8, 0x2BF0);
    // JZ 0x1000:2c2c (1000_2BEE / 0x12BEE)
    if(ZeroFlag) {
      goto label_1000_2C2C_12C2C;
    }
    CheckExternalEvents(cs8, 0x2BF5);
    // MOV word ptr [BP + -0x3a],0x0 (1000_2BF0 / 0x12BF0)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x0;
    CheckExternalEvents(cs8, 0x2BFA);
    // MOV word ptr [BP + -0x2c],0x0 (1000_2BF5 / 0x12BF5)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_1000_2BFA_12BFA:
    CheckExternalEvents(cs8, 0x2BFD);
    // MOV AX,0x11 (1000_2BFA / 0x12BFA)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x2C00);
    // IMUL word ptr [BP + -0x2c] (1000_2BFD / 0x12BFD)
    int resImul1000_2BFD = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_2BFD);
    DX = (ushort)(resImul1000_2BFD >> 16);
    CheckExternalEvents(cs8, 0x2C02);
    // MOV SI,AX (1000_2C00 / 0x12C00)
    SI = AX;
    CheckExternalEvents(cs8, 0x2C06);
    // MOV ES,word ptr [0x55d4] (1000_2C02 / 0x12C02)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2C0B);
    // MOV AL,byte ptr ES:[SI + 0xc614] (1000_2C06 / 0x12C06)
    AL = UInt8[ES, (ushort)(SI + 0xC614)];
    CheckExternalEvents(cs8, 0x2C0C);
    // CBW  (1000_2C0B / 0x12C0B)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x2C0F);
    // CMP AX,0xff (1000_2C0C / 0x12C0C)
    Alu16.Sub(AX, 0xFF);
    CheckExternalEvents(cs8, 0x2C11);
    // JZ 0x1000:2c23 (1000_2C0F / 0x12C0F)
    if(ZeroFlag) {
      goto label_1000_2C23_12C23;
    }
    CheckExternalEvents(cs8, 0x2C17);
    // CMP byte ptr ES:[SI + 0xc61d],0x0 (1000_2C11 / 0x12C11)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0xC61D)], 0x0);
    CheckExternalEvents(cs8, 0x2C19);
    // JZ 0x1000:2c23 (1000_2C17 / 0x12C17)
    if(ZeroFlag) {
      goto label_1000_2C23_12C23;
    }
    CheckExternalEvents(cs8, 0x2C1E);
    // CALLF 0x0000:71b2 (1000_2C19 / 0x12C19)
    FarCall(cs8, 0x2C1E, ghidra_guess_0000_71B2_071B2);
    CheckExternalEvents(cs8, 0x2C23);
    // MOV word ptr [BP + -0x2c],0x8 (1000_2C1E / 0x12C1E)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x8;
    label_1000_2C23_12C23:
    CheckExternalEvents(cs8, 0x2C26);
    // INC word ptr [BP + -0x2c] (1000_2C23 / 0x12C23)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x2C2A);
    // CMP word ptr [BP + -0x2c],0x8 (1000_2C26 / 0x12C26)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x8);
    CheckExternalEvents(cs8, 0x2C2C);
    // JL 0x1000:2bfa (1000_2C2A / 0x12C2A)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2BFA_12BFA;
    }
    label_1000_2C2C_12C2C:
    CheckExternalEvents(cs8, 0x2C31);
    // MOV word ptr [BP + -0x3a],0x0 (1000_2C2C / 0x12C2C)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x0;
    CheckExternalEvents(cs8, 0x2C36);
    // MOV word ptr [BP + -0x2c],0x0 (1000_2C31 / 0x12C31)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_1000_2C36_12C36:
    CheckExternalEvents(cs8, 0x2C39);
    // MOV SI,word ptr [BP + -0x2c] (1000_2C36 / 0x12C36)
    SI = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x2C3B);
    // SHL SI,0x1 (1000_2C39 / 0x12C39)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x2C3F);
    // MOV ES,word ptr [0x55de] (1000_2C3B / 0x12C3B)
    ES = UInt16[DS, 0x55DE];
    CheckExternalEvents(cs8, 0x2C45);
    // CMP word ptr ES:[SI + 0x393c],0x0 (1000_2C3F / 0x12C3F)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x393C)], 0x0);
    CheckExternalEvents(cs8, 0x2C47);
    // JNZ 0x1000:2c4f (1000_2C45 / 0x12C45)
    if(!ZeroFlag) {
      goto label_1000_2C4F_12C4F;
    }
    CheckExternalEvents(cs8, 0x2C4D);
    // CMP word ptr ES:[SI + 0x3954],0x0 (1000_2C47 / 0x12C47)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x3954)], 0x0);
    CheckExternalEvents(cs8, 0x2C4F);
    // JZ 0x1000:2c54 (1000_2C4D / 0x12C4D)
    if(ZeroFlag) {
      goto label_1000_2C54_12C54;
    }
    label_1000_2C4F_12C4F:
    CheckExternalEvents(cs8, 0x2C54);
    // MOV word ptr [BP + -0x3a],0x1 (1000_2C4F / 0x12C4F)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x1;
    label_1000_2C54_12C54:
    CheckExternalEvents(cs8, 0x2C57);
    // INC word ptr [BP + -0x2c] (1000_2C54 / 0x12C54)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x2C5B);
    // CMP word ptr [BP + -0x2c],0x4 (1000_2C57 / 0x12C57)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x4);
    CheckExternalEvents(cs8, 0x2C5D);
    // JL 0x1000:2c36 (1000_2C5B / 0x12C5B)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2C36_12C36;
    }
    CheckExternalEvents(cs8, 0x2C61);
    // CMP word ptr [BP + -0x3a],0x0 (1000_2C5D / 0x12C5D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x0);
    CheckExternalEvents(cs8, 0x2C63);
    // JNZ 0x1000:2c66 (1000_2C61 / 0x12C61)
    if(!ZeroFlag) {
      goto label_1000_2C66_12C66;
    }
    CheckExternalEvents(cs8, 0x2C66);
    // JMP 0x1000:2d01 (1000_2C63 / 0x12C63)
    goto label_1000_2D01_12D01;
    label_1000_2C66_12C66:
    CheckExternalEvents(cs8, 0x2C6B);
    // MOV word ptr [BP + -0x3a],0x0 (1000_2C66 / 0x12C66)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x0;
    CheckExternalEvents(cs8, 0x2C70);
    // MOV word ptr [BP + -0x2c],0x0 (1000_2C6B / 0x12C6B)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_1000_2C70_12C70:
    CheckExternalEvents(cs8, 0x2C73);
    // MOV AX,0x11 (1000_2C70 / 0x12C70)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x2C76);
    // IMUL word ptr [BP + -0x2c] (1000_2C73 / 0x12C73)
    int resImul1000_2C73 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_2C73);
    DX = (ushort)(resImul1000_2C73 >> 16);
    CheckExternalEvents(cs8, 0x2C78);
    // MOV SI,AX (1000_2C76 / 0x12C76)
    SI = AX;
    CheckExternalEvents(cs8, 0x2C7C);
    // MOV ES,word ptr [0x55d4] (1000_2C78 / 0x12C78)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2C82);
    // CMP byte ptr ES:[SI + 0xc614],0xff (1000_2C7C / 0x12C7C)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0xC614)], 0xFF);
    CheckExternalEvents(cs8, 0x2C84);
    // JZ 0x1000:2c99 (1000_2C82 / 0x12C82)
    if(ZeroFlag) {
      goto label_1000_2C99_12C99;
    }
    CheckExternalEvents(cs8, 0x2C8A);
    // CMP byte ptr ES:[SI + 0xc61c],0x0 (1000_2C84 / 0x12C84)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0xC61C)], 0x0);
    CheckExternalEvents(cs8, 0x2C8C);
    // JZ 0x1000:2c99 (1000_2C8A / 0x12C8A)
    if(ZeroFlag) {
      goto label_1000_2C99_12C99;
    }
    CheckExternalEvents(cs8, 0x2C92);
    // CMP byte ptr ES:[SI + 0xc620],0x8 (1000_2C8C / 0x12C8C)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0xC620)], 0x8);
    CheckExternalEvents(cs8, 0x2C94);
    // JL 0x1000:2c99 (1000_2C92 / 0x12C92)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2C99_12C99;
    }
    CheckExternalEvents(cs8, 0x2C99);
    // MOV word ptr [BP + -0x3a],0x1 (1000_2C94 / 0x12C94)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x1;
    label_1000_2C99_12C99:
    CheckExternalEvents(cs8, 0x2C9C);
    // INC word ptr [BP + -0x2c] (1000_2C99 / 0x12C99)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x2CA0);
    // CMP word ptr [BP + -0x2c],0x8 (1000_2C9C / 0x12C9C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x8);
    CheckExternalEvents(cs8, 0x2CA2);
    // JL 0x1000:2c70 (1000_2CA0 / 0x12CA0)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2C70_12C70;
    }
    CheckExternalEvents(cs8, 0x2CA6);
    // CMP word ptr [BP + -0x3a],0x0 (1000_2CA2 / 0x12CA2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x0);
    CheckExternalEvents(cs8, 0x2CA8);
    // JZ 0x1000:2cd4 (1000_2CA6 / 0x12CA6)
    if(ZeroFlag) {
      goto label_1000_2CD4_12CD4;
    }
    CheckExternalEvents(cs8, 0x2CAD);
    // MOV word ptr [BP + -0x3a],0x0 (1000_2CA8 / 0x12CA8)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x0;
    CheckExternalEvents(cs8, 0x2CB2);
    // MOV word ptr [BP + -0x2c],0x0 (1000_2CAD / 0x12CAD)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_1000_2CB2_12CB2:
    CheckExternalEvents(cs8, 0x2CB5);
    // MOV AX,0x7d (1000_2CB2 / 0x12CB2)
    AX = 0x7D;
    CheckExternalEvents(cs8, 0x2CB8);
    // IMUL word ptr [BP + -0x2c] (1000_2CB5 / 0x12CB5)
    int resImul1000_2CB5 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_2CB5);
    DX = (ushort)(resImul1000_2CB5 >> 16);
    CheckExternalEvents(cs8, 0x2CBA);
    // MOV BX,AX (1000_2CB8 / 0x12CB8)
    BX = AX;
    CheckExternalEvents(cs8, 0x2CBE);
    // MOV ES,word ptr [0x55d4] (1000_2CBA / 0x12CBA)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2CC4);
    // CMP byte ptr ES:[BX + 0xc724],0xff (1000_2CBE / 0x12CBE)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs8, 0x2CC6);
    // JNZ 0x1000:2ccb (1000_2CC4 / 0x12CC4)
    if(!ZeroFlag) {
      goto label_1000_2CCB_12CCB;
    }
    CheckExternalEvents(cs8, 0x2CCB);
    // MOV word ptr [BP + -0x3a],0x1 (1000_2CC6 / 0x12CC6)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x1;
    label_1000_2CCB_12CCB:
    CheckExternalEvents(cs8, 0x2CCE);
    // INC word ptr [BP + -0x2c] (1000_2CCB / 0x12CCB)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x2CD2);
    // CMP word ptr [BP + -0x2c],0x4 (1000_2CCE / 0x12CCE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x4);
    CheckExternalEvents(cs8, 0x2CD4);
    // JL 0x1000:2cb2 (1000_2CD2 / 0x12CD2)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2CB2_12CB2;
    }
    label_1000_2CD4_12CD4:
    CheckExternalEvents(cs8, 0x2CD8);
    // CMP word ptr [BP + -0x3a],0x0 (1000_2CD4 / 0x12CD4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x0);
    CheckExternalEvents(cs8, 0x2CDA);
    // JZ 0x1000:2d01 (1000_2CD8 / 0x12CD8)
    if(ZeroFlag) {
      goto label_1000_2D01_12D01;
    }
    CheckExternalEvents(cs8, 0x2CDF);
    // MOV word ptr [BP + -0x2c],0x0 (1000_2CDA / 0x12CDA)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_1000_2CDF_12CDF:
    CheckExternalEvents(cs8, 0x2CE2);
    // MOV SI,word ptr [BP + -0x2c] (1000_2CDF / 0x12CDF)
    SI = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs8, 0x2CE6);
    // TEST byte ptr [BP + SI + -0x1c],0x80 (1000_2CE2 / 0x12CE2)
    Alu8.And(UInt8[SS, (ushort)(BP + SI - 0x1C)], 0x80);
    CheckExternalEvents(cs8, 0x2CE8);
    // JZ 0x1000:2ced (1000_2CE6 / 0x12CE6)
    if(ZeroFlag) {
      goto label_1000_2CED_12CED;
    }
    CheckExternalEvents(cs8, 0x2CED);
    // MOV word ptr [BP + -0x3a],0x0 (1000_2CE8 / 0x12CE8)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x0;
    label_1000_2CED_12CED:
    CheckExternalEvents(cs8, 0x2CF0);
    // INC word ptr [BP + -0x2c] (1000_2CED / 0x12CED)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x2CF4);
    // CMP word ptr [BP + -0x2c],0x9 (1000_2CF0 / 0x12CF0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x9);
    CheckExternalEvents(cs8, 0x2CF6);
    // JL 0x1000:2cdf (1000_2CF4 / 0x12CF4)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2CDF_12CDF;
    }
    CheckExternalEvents(cs8, 0x2CFA);
    // CMP word ptr [BP + -0x3a],0x0 (1000_2CF6 / 0x12CF6)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x0);
    CheckExternalEvents(cs8, 0x2CFC);
    // JZ 0x1000:2d01 (1000_2CFA / 0x12CFA)
    if(ZeroFlag) {
      goto label_1000_2D01_12D01;
    }
    CheckExternalEvents(cs8, 0x2D01);
    // CALLF 0x0000:76a9 (1000_2CFC / 0x12CFC)
    FarCall(cs8, 0x2D01, ghidra_guess_0000_76A9_076A9);
    label_1000_2D01_12D01:
    CheckExternalEvents(cs8, 0x2D06);
    // CALLF 0x0000:7afb (1000_2D01 / 0x12D01)
    FarCall(cs8, 0x2D06, ghidra_guess_0000_7AFB_07AFB);
    CheckExternalEvents(cs8, 0x2D0A);
    // MOV ES,word ptr [0x55d4] (1000_2D06 / 0x12D06)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2D10);
    // MOV byte ptr ES:[0xd335],0x0 (1000_2D0A / 0x12D0A)
    UInt8[ES, 0xD335] = 0x0;
    CheckExternalEvents(cs8, 0x2D13);
    // MOV AX,0x3 (1000_2D10 / 0x12D10)
    AX = 0x3;
    CheckExternalEvents(cs8, 0x2D14);
    // PUSH AX (1000_2D13 / 0x12D13)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2D19);
    // CALLF 0x1000:7ee1 (1000_2D14 / 0x12D14)
    FarCall(cs8, 0x2D19, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs8, 0x2D1C);
    // ADD SP,0x2 (1000_2D19 / 0x12D19)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2D21);
    // CALLF 0x1000:7fe8 (1000_2D1C / 0x12D1C)
    FarCall(cs8, 0x2D21, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs8, 0x2D26);
    // MOV word ptr [BP + -0x3a],0x0 (1000_2D21 / 0x12D21)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x0;
    CheckExternalEvents(cs8, 0x2D2B);
    // MOV word ptr [BP + -0x2c],0x0 (1000_2D26 / 0x12D26)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_1000_2D2B_12D2B:
    CheckExternalEvents(cs8, 0x2D2E);
    // MOV AX,0x11 (1000_2D2B / 0x12D2B)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x2D31);
    // IMUL word ptr [BP + -0x2c] (1000_2D2E / 0x12D2E)
    int resImul1000_2D2E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2C)]);
    AX = (ushort)(resImul1000_2D2E);
    DX = (ushort)(resImul1000_2D2E >> 16);
    CheckExternalEvents(cs8, 0x2D33);
    // MOV SI,AX (1000_2D31 / 0x12D31)
    SI = AX;
    CheckExternalEvents(cs8, 0x2D37);
    // MOV ES,word ptr [0x55d4] (1000_2D33 / 0x12D33)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2D3D);
    // CMP byte ptr ES:[SI + 0xc614],0xff (1000_2D37 / 0x12D37)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0xC614)], 0xFF);
    CheckExternalEvents(cs8, 0x2D3F);
    // JZ 0x1000:2d53 (1000_2D3D / 0x12D3D)
    if(ZeroFlag) {
      goto label_1000_2D53_12D53;
    }
    CheckExternalEvents(cs8, 0x2D44);
    // MOV AL,byte ptr ES:[SI + 0xc623] (1000_2D3F / 0x12D3F)
    AL = UInt8[ES, (ushort)(SI + 0xC623)];
    CheckExternalEvents(cs8, 0x2D45);
    // CBW  (1000_2D44 / 0x12D44)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x2D47);
    // MOV CX,AX (1000_2D45 / 0x12D45)
    CX = AX;
    CheckExternalEvents(cs8, 0x2D49);
    // MOV AL,0xa (1000_2D47 / 0x12D47)
    AL = 0xA;
    CheckExternalEvents(cs8, 0x2D4E);
    // IMUL byte ptr ES:[SI + 0xc615] (1000_2D49 / 0x12D49)
    short resImul1000_2D49 = Alu8.Imul((sbyte)AL, (sbyte)UInt8[ES, (ushort)(SI + 0xC615)]);
    AL = (byte)(resImul1000_2D49);
    AH = (byte)(resImul1000_2D49 >> 8);
    CheckExternalEvents(cs8, 0x2D50);
    // SUB AX,CX (1000_2D4E / 0x12D4E)
    AX -= CX;
    CheckExternalEvents(cs8, 0x2D53);
    // ADD word ptr [BP + -0x3a],AX (1000_2D50 / 0x12D50)
    UInt16[SS, (ushort)(BP - 0x3A)] += AX;
    label_1000_2D53_12D53:
    CheckExternalEvents(cs8, 0x2D56);
    // INC word ptr [BP + -0x2c] (1000_2D53 / 0x12D53)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs8, 0x2D5A);
    // CMP word ptr [BP + -0x2c],0x8 (1000_2D56 / 0x12D56)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2C)], 0x8);
    CheckExternalEvents(cs8, 0x2D5C);
    // JL 0x1000:2d2b (1000_2D5A / 0x12D5A)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2D2B_12D2B;
    }
    CheckExternalEvents(cs8, 0x2D60);
    // CMP word ptr [BP + -0x3a],0x0 (1000_2D5C / 0x12D5C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x0);
    CheckExternalEvents(cs8, 0x2D62);
    // JZ 0x1000:2d92 (1000_2D60 / 0x12D60)
    if(ZeroFlag) {
      goto label_1000_2D92_12D92;
    }
    CheckExternalEvents(cs8, 0x2D64);
    // SUB AX,AX (1000_2D62 / 0x12D62)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x2D65);
    // PUSH AX (1000_2D64 / 0x12D64)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2D6A);
    // CALLF 0x0000:da1a (1000_2D65 / 0x12D65)
    FarCall(cs8, 0x2D6A, ghidra_guess_0000_DA1A_0DA1A);
    CheckExternalEvents(cs8, 0x2D6D);
    // ADD SP,0x2 (1000_2D6A / 0x12D6A)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2D6F);
    // JMP 0x1000:2d92 (1000_2D6D / 0x12D6D)
    goto label_1000_2D92_12D92;
    label_1000_2D6F_12D6F:
    CheckExternalEvents(cs8, 0x2D73);
    // MOV ES,word ptr [0x55fc] (1000_2D6F / 0x12D6F)
    ES = UInt16[DS, 0x55FC];
    CheckExternalEvents(cs8, 0x2D79);
    // CMP word ptr ES:[0x14a],0x0 (1000_2D73 / 0x12D73)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs8, 0x2D7B);
    // JZ 0x1000:2d92 (1000_2D79 / 0x12D79)
    if(ZeroFlag) {
      goto label_1000_2D92_12D92;
    }
    CheckExternalEvents(cs8, 0x2D80);
    // CALLF 0x1000:7fe8 (1000_2D7B / 0x12D7B)
    FarCall(cs8, 0x2D80, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs8, 0x2D83);
    // MOV AX,0x3936 (1000_2D80 / 0x12D80)
    AX = 0x3936;
    CheckExternalEvents(cs8, 0x2D84);
    // PUSH DS (1000_2D83 / 0x12D83)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2D85);
    // PUSH AX (1000_2D84 / 0x12D84)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2D8A);
    // CALLF 0x1000:8055 (1000_2D85 / 0x12D85)
    FarCall(cs8, 0x2D8A, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2D8D);
    // ADD SP,0x4 (1000_2D8A / 0x12D8A)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2D92);
    // CALLF 0x0000:414f (1000_2D8D / 0x12D8D)
    FarCall(cs8, 0x2D92, ghidra_guess_0000_414F_0414F);
    label_1000_2D92_12D92:
    CheckExternalEvents(cs8, 0x2D96);
    // MOV ES,word ptr [0x55fc] (1000_2D92 / 0x12D92)
    ES = UInt16[DS, 0x55FC];
    CheckExternalEvents(cs8, 0x2D9C);
    // CMP word ptr ES:[0x14a],0x0 (1000_2D96 / 0x12D96)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs8, 0x2D9E);
    // JNZ 0x1000:2da1 (1000_2D9C / 0x12D9C)
    if(!ZeroFlag) {
      goto label_1000_2DA1_12DA1;
    }
    CheckExternalEvents(cs8, 0x2DA1);
    // JMP 0x1000:2eca (1000_2D9E / 0x12D9E)
    goto label_1000_2ECA_12ECA;
    label_1000_2DA1_12DA1:
    CheckExternalEvents(cs8, 0x2DA5);
    // CMP word ptr [BP + 0x6],0x1 (1000_2DA1 / 0x12DA1)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x1);
    CheckExternalEvents(cs8, 0x2DA7);
    // JL 0x1000:2db0 (1000_2DA5 / 0x12DA5)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2DB0_12DB0;
    }
    CheckExternalEvents(cs8, 0x2DAB);
    // CMP word ptr [BP + 0x6],0x3 (1000_2DA7 / 0x12DA7)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x3);
    CheckExternalEvents(cs8, 0x2DAD);
    // JZ 0x1000:2db0 (1000_2DAB / 0x12DAB)
    if(ZeroFlag) {
      goto label_1000_2DB0_12DB0;
    }
    CheckExternalEvents(cs8, 0x2DB0);
    // JMP 0x1000:2eca (1000_2DAD / 0x12DAD)
    goto label_1000_2ECA_12ECA;
    label_1000_2DB0_12DB0:
    CheckExternalEvents(cs8, 0x2DB3);
    // MOV AX,0x4 (1000_2DB0 / 0x12DB0)
    AX = 0x4;
    CheckExternalEvents(cs8, 0x2DB4);
    // PUSH AX (1000_2DB3 / 0x12DB3)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2DB9);
    // CALLF 0x1000:7ee1 (1000_2DB4 / 0x12DB4)
    FarCall(cs8, 0x2DB9, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs8, 0x2DBC);
    // ADD SP,0x2 (1000_2DB9 / 0x12DB9)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2DC1);
    // CALLF 0x1000:7fe8 (1000_2DBC / 0x12DBC)
    FarCall(cs8, 0x2DC1, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs8, 0x2DC4);
    // MOV AX,0x1 (1000_2DC1 / 0x12DC1)
    AX = 0x1;
    CheckExternalEvents(cs8, 0x2DC5);
    // PUSH AX (1000_2DC4 / 0x12DC4)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2DCA);
    // CALLF 0x0000:63ac (1000_2DC5 / 0x12DC5)
    FarCall(cs8, 0x2DCA, unknown_0170_4CAC_063AC);
    CheckExternalEvents(cs8, 0x2DCD);
    // ADD SP,0x2 (1000_2DCA / 0x12DCA)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2DD2);
    // CALLF 0x1000:7bf6 (1000_2DCD / 0x12DCD)
    FarCall(cs8, 0x2DD2, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs8, 0x2DD5);
    // MOV AX,0x3954 (1000_2DD2 / 0x12DD2)
    AX = 0x3954;
    CheckExternalEvents(cs8, 0x2DD6);
    // PUSH DS (1000_2DD5 / 0x12DD5)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2DD7);
    // PUSH AX (1000_2DD6 / 0x12DD6)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2DDC);
    // CALLF 0x1000:8055 (1000_2DD7 / 0x12DD7)
    FarCall(cs8, 0x2DDC, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2DDF);
    // ADD SP,0x4 (1000_2DDC / 0x12DDC)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2DE4);
    // CALLF 0x0000:412b (1000_2DDF / 0x12DDF)
    FarCall(cs8, 0x2DE4, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs8, 0x2DE9);
    // CALLF 0x1000:8d29 (1000_2DE4 / 0x12DE4)
    FarCall(cs8, 0x2DE9, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs8, 0x2DEC);
    // PUSH word ptr [BP + -0x36] (1000_2DE9 / 0x12DE9)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x36)]);
    CheckExternalEvents(cs8, 0x2DEF);
    // PUSH word ptr [BP + -0x32] (1000_2DEC / 0x12DEC)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x32)]);
    CheckExternalEvents(cs8, 0x2DF4);
    // CALLF 0x0000:2ebb (1000_2DEF / 0x12DEF)
    FarCall(cs8, 0x2DF4, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs8, 0x2DF7);
    // ADD SP,0x4 (1000_2DF4 / 0x12DF4)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2DF8);
    // PUSH CS (1000_2DF7 / 0x12DF7)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x2DFB);
    // CALL 0x1000:42e5 (1000_2DF8 / 0x12DF8)
    NearCall(cs8, 0x2DFB, ghidra_guess_1000_42E5_142E5);
    CheckExternalEvents(cs8, 0x2DFF);
    // MOV ES,word ptr [0x55ce] (1000_2DFB / 0x12DFB)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs8, 0x2E04);
    // PUSH word ptr ES:[0xa44d] (1000_2DFF / 0x12DFF)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs8, 0x2E08);
    // MOV ES,word ptr [0x55cc] (1000_2E04 / 0x12E04)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs8, 0x2E0D);
    // PUSH word ptr ES:[0xa44b] (1000_2E08 / 0x12E08)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs8, 0x2E12);
    // CALLF 0x1000:b204 (1000_2E0D / 0x12E0D)
    FarCall(cs8, 0x2E12, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs8, 0x2E15);
    // ADD SP,0x4 (1000_2E12 / 0x12E12)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2E1A);
    // CALLF 0x1000:b7df (1000_2E15 / 0x12E15)
    FarCall(cs8, 0x2E1A, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs8, 0x2E1D);
    // JMP 0x1000:2eca (1000_2E1A / 0x12E1A)
    goto label_1000_2ECA_12ECA;
    label_1000_2E1D_12E1D:
    CheckExternalEvents(cs8, 0x2E21);
    // MOV ES,word ptr [0x55fc] (1000_2E1D / 0x12E1D)
    ES = UInt16[DS, 0x55FC];
    CheckExternalEvents(cs8, 0x2E27);
    // CMP word ptr ES:[0x14a],0x0 (1000_2E21 / 0x12E21)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs8, 0x2E29);
    // JNZ 0x1000:2e2c (1000_2E27 / 0x12E27)
    if(!ZeroFlag) {
      goto label_1000_2E2C_12E2C;
    }
    CheckExternalEvents(cs8, 0x2E2C);
    // JMP 0x1000:2eca (1000_2E29 / 0x12E29)
    goto label_1000_2ECA_12ECA;
    label_1000_2E2C_12E2C:
    CheckExternalEvents(cs8, 0x2E30);
    // MOV ES,word ptr [0x55ee] (1000_2E2C / 0x12E2C)
    ES = UInt16[DS, 0x55EE];
    CheckExternalEvents(cs8, 0x2E36);
    // CMP word ptr ES:[0x3772],0x0 (1000_2E30 / 0x12E30)
    Alu16.Sub(UInt16[ES, 0x3772], 0x0);
    CheckExternalEvents(cs8, 0x2E38);
    // JNZ 0x1000:2e92 (1000_2E36 / 0x12E36)
    if(!ZeroFlag) {
      goto label_1000_2E92_12E92;
    }
    CheckExternalEvents(cs8, 0x2E3C);
    // CMP word ptr [BP + 0x6],0x1 (1000_2E38 / 0x12E38)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x1);
    CheckExternalEvents(cs8, 0x2E3E);
    // JNZ 0x1000:2e57 (1000_2E3C / 0x12E3C)
    if(!ZeroFlag) {
      goto label_1000_2E57_12E57;
    }
    CheckExternalEvents(cs8, 0x2E43);
    // CALLF 0x1000:7bf6 (1000_2E3E / 0x12E3E)
    FarCall(cs8, 0x2E43, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs8, 0x2E46);
    // MOV AX,0x398b (1000_2E43 / 0x12E43)
    AX = 0x398B;
    label_1000_2E46_12E46:
    CheckExternalEvents(cs8, 0x2E47);
    // PUSH DS (1000_2E46 / 0x12E46)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2E48);
    // PUSH AX (1000_2E47 / 0x12E47)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2E4D);
    // CALLF 0x1000:7c1a (1000_2E48 / 0x12E48)
    FarCall(cs8, 0x2E4D, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs8, 0x2E50);
    // ADD SP,0x4 (1000_2E4D / 0x12E4D)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_2E50_12E50:
    CheckExternalEvents(cs8, 0x2E55);
    // CALLF 0x1000:8d29 (1000_2E50 / 0x12E50)
    FarCall(cs8, 0x2E55, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs8, 0x2E57);
    // JMP 0x1000:2eca (1000_2E55 / 0x12E55)
    goto label_1000_2ECA_12ECA;
    label_1000_2E57_12E57:
    CheckExternalEvents(cs8, 0x2E5B);
    // CMP word ptr [BP + -0xc],0x0 (1000_2E57 / 0x12E57)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs8, 0x2E5D);
    // JNZ 0x1000:2eca (1000_2E5B / 0x12E5B)
    if(!ZeroFlag) {
      goto label_1000_2ECA_12ECA;
    }
    CheckExternalEvents(cs8, 0x2E62);
    // CALLF 0x1000:7bf6 (1000_2E5D / 0x12E5D)
    FarCall(cs8, 0x2E62, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs8, 0x2E66);
    // MOV ES,word ptr [0x55d4] (1000_2E62 / 0x12E62)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2E6C);
    // MOV byte ptr ES:[0xd32d],0x1 (1000_2E66 / 0x12E66)
    UInt8[ES, 0xD32D] = 0x1;
    CheckExternalEvents(cs8, 0x2E72);
    // CMP byte ptr ES:[0xc724],0xff (1000_2E6C / 0x12E6C)
    Alu8.Sub(UInt8[ES, 0xC724], 0xFF);
    CheckExternalEvents(cs8, 0x2E74);
    // JZ 0x1000:2e79 (1000_2E72 / 0x12E72)
    if(ZeroFlag) {
      goto label_1000_2E79_12E79;
    }
    CheckExternalEvents(cs8, 0x2E77);
    // MOV AX,0x39aa (1000_2E74 / 0x12E74)
    AX = 0x39AA;
    CheckExternalEvents(cs8, 0x2E79);
    // JMP 0x1000:2e46 (1000_2E77 / 0x12E77)
    goto label_1000_2E46_12E46;
    label_1000_2E79_12E79:
    CheckExternalEvents(cs8, 0x2E7C);
    // MOV AX,0x39ca (1000_2E79 / 0x12E79)
    AX = 0x39CA;
    CheckExternalEvents(cs8, 0x2E7D);
    // PUSH DS (1000_2E7C / 0x12E7C)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2E7E);
    // PUSH AX (1000_2E7D / 0x12E7D)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2E83);
    // CALLF 0x1000:7c1a (1000_2E7E / 0x12E7E)
    FarCall(cs8, 0x2E83, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs8, 0x2E86);
    // ADD SP,0x4 (1000_2E83 / 0x12E83)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2E8A);
    // MOV ES,word ptr [0x55d4] (1000_2E86 / 0x12E86)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2E90);
    // MOV byte ptr ES:[0xd32d],0x0 (1000_2E8A / 0x12E8A)
    UInt8[ES, 0xD32D] = 0x0;
    CheckExternalEvents(cs8, 0x2E92);
    // JMP 0x1000:2e50 (1000_2E90 / 0x12E90)
    goto label_1000_2E50_12E50;
    label_1000_2E92_12E92:
    CheckExternalEvents(cs8, 0x2E96);
    // CMP word ptr [BP + -0x38],0x2 (1000_2E92 / 0x12E92)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x38)], 0x2);
    CheckExternalEvents(cs8, 0x2E98);
    // JNZ 0x1000:2eca (1000_2E96 / 0x12E96)
    if(!ZeroFlag) {
      goto label_1000_2ECA_12ECA;
    }
    CheckExternalEvents(cs8, 0x2E9B);
    // MOV AX,0x3 (1000_2E98 / 0x12E98)
    AX = 0x3;
    CheckExternalEvents(cs8, 0x2E9C);
    // PUSH AX (1000_2E9B / 0x12E9B)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2EA1);
    // CALLF 0x1000:7ee1 (1000_2E9C / 0x12E9C)
    FarCall(cs8, 0x2EA1, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs8, 0x2EA4);
    // ADD SP,0x2 (1000_2EA1 / 0x12EA1)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x2EA9);
    // CALLF 0x1000:7fe8 (1000_2EA4 / 0x12EA4)
    FarCall(cs8, 0x2EA9, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs8, 0x2EAC);
    // MOV AX,0x39f7 (1000_2EA9 / 0x12EA9)
    AX = 0x39F7;
    CheckExternalEvents(cs8, 0x2EAD);
    // PUSH DS (1000_2EAC / 0x12EAC)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x2EAE);
    // PUSH AX (1000_2EAD / 0x12EAD)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x2EB3);
    // CALLF 0x1000:8055 (1000_2EAE / 0x12EAE)
    FarCall(cs8, 0x2EB3, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x2EB6);
    // ADD SP,0x4 (1000_2EB3 / 0x12EB3)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x2EBB);
    // CALLF 0x0000:414f (1000_2EB6 / 0x12EB6)
    FarCall(cs8, 0x2EBB, ghidra_guess_0000_414F_0414F);
    CheckExternalEvents(cs8, 0x2EBD);
    // JMP 0x1000:2eca (1000_2EBB / 0x12EBB)
    goto label_1000_2ECA_12ECA;
    label_1000_2EBD_12EBD:
    CheckExternalEvents(cs8, 0x2EC0);
    // PUSH word ptr [BP + -0x36] (1000_2EBD / 0x12EBD)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x36)]);
    CheckExternalEvents(cs8, 0x2EC3);
    // PUSH word ptr [BP + -0x32] (1000_2EC0 / 0x12EC0)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x32)]);
    CheckExternalEvents(cs8, 0x2EC4);
    // PUSH CS (1000_2EC3 / 0x12EC3)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x2EC7);
    // CALL 0x1000:4553 (1000_2EC4 / 0x12EC4)
    NearCall(cs8, 0x2EC7, ghidra_guess_1000_4553_14553);
    CheckExternalEvents(cs8, 0x2ECA);
    // ADD SP,0x4 (1000_2EC7 / 0x12EC7)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_2ECA_12ECA:
    CheckExternalEvents(cs8, 0x2ECF);
    // MOV word ptr [BP + -0x26],0x0 (1000_2ECA / 0x12ECA)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x0;
    label_1000_2ECF_12ECF:
    CheckExternalEvents(cs8, 0x2ED2);
    // MOV AX,0x1a (1000_2ECF / 0x12ECF)
    AX = 0x1A;
    CheckExternalEvents(cs8, 0x2ED5);
    // IMUL word ptr [BP + -0x26] (1000_2ED2 / 0x12ED2)
    int resImul1000_2ED2 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x26)]);
    AX = (ushort)(resImul1000_2ED2);
    DX = (ushort)(resImul1000_2ED2 >> 16);
    CheckExternalEvents(cs8, 0x2ED7);
    // MOV SI,AX (1000_2ED5 / 0x12ED5)
    SI = AX;
    CheckExternalEvents(cs8, 0x2EDA);
    // MOV DI,word ptr [BP + -0x26] (1000_2ED7 / 0x12ED7)
    DI = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x2EDC);
    // SHL DI,0x1 (1000_2EDA / 0x12EDA)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs8, 0x2EE0);
    // MOV ES,word ptr [0x55d4] (1000_2EDC / 0x12EDC)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2EE5);
    // MOV AX,word ptr ES:[SI + 0xd390] (1000_2EE0 / 0x12EE0)
    AX = UInt16[ES, (ushort)(SI + 0xD390)];
    CheckExternalEvents(cs8, 0x2EE9);
    // MOV ES,word ptr [0x55d2] (1000_2EE5 / 0x12EE5)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs8, 0x2EEE);
    // MOV word ptr ES:[DI + 0x4024],AX (1000_2EE9 / 0x12EE9)
    UInt16[ES, (ushort)(DI + 0x4024)] = AX;
    CheckExternalEvents(cs8, 0x2EF2);
    // MOV ES,word ptr [0x55d4] (1000_2EEE / 0x12EEE)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs8, 0x2EF7);
    // MOV AX,word ptr ES:[SI + 0xd392] (1000_2EF2 / 0x12EF2)
    AX = UInt16[ES, (ushort)(SI + 0xD392)];
    CheckExternalEvents(cs8, 0x2EFB);
    // MOV ES,word ptr [0x55d6] (1000_2EF7 / 0x12EF7)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs8, 0x2F00);
    // MOV word ptr ES:[DI + 0x4056],AX (1000_2EFB / 0x12EFB)
    UInt16[ES, (ushort)(DI + 0x4056)] = AX;
    CheckExternalEvents(cs8, 0x2F02);
    // MOV AL,0xff (1000_2F00 / 0x12F00)
    AL = 0xFF;
    CheckExternalEvents(cs8, 0x2F05);
    // MOV BX,word ptr [BP + -0x26] (1000_2F02 / 0x12F02)
    BX = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x2F09);
    // MOV ES,word ptr [0x5608] (1000_2F05 / 0x12F05)
    ES = UInt16[DS, 0x5608];
    CheckExternalEvents(cs8, 0x2F0E);
    // MOV byte ptr ES:[BX + 0x397c],AL (1000_2F09 / 0x12F09)
    UInt8[ES, (ushort)(BX + 0x397C)] = AL;
    CheckExternalEvents(cs8, 0x2F11);
    // MOV BX,word ptr [BP + -0x26] (1000_2F0E / 0x12F0E)
    BX = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x2F16);
    // MOV byte ptr ES:[BX + 0x396c],AL (1000_2F11 / 0x12F11)
    UInt8[ES, (ushort)(BX + 0x396C)] = AL;
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
}
