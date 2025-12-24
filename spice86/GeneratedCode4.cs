namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_0000_5CC2_05CC2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_5CC2_05CC2:
    CheckExternalEvents(cs1, 0x5CC3);
    // PUSH BP (0000_5CC2 / 0x5CC2)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x5CC5);
    // MOV BP,SP (0000_5CC3 / 0x5CC3)
    BP = SP;
    CheckExternalEvents(cs1, 0x5CC7);
    // XOR AX,AX (0000_5CC5 / 0x5CC5)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs1, 0x5CCC);
    // CALLF 0x1000:cecc (0000_5CC7 / 0x5CC7)
    FarCall(cs1, 0x5CCC, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x5CCF);
    // PUSH word ptr [BP + 0x6] (0000_5CCC / 0x5CCC)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0x5CD4);
    // CALLF 0x1000:be41 (0000_5CCF / 0x5CCF)
    FarCall(cs1, 0x5CD4, ghidra_guess_1000_BE41_1BE41);
    CheckExternalEvents(cs1, 0x5CD7);
    // ADD SP,0x2 (0000_5CD4 / 0x5CD4)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x5CDB);
    // MOV ES,word ptr [0x53a0] (0000_5CD7 / 0x5CD7)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs1, 0x5CE1);
    // CMP word ptr ES:[0x4fba],0x0 (0000_5CDB / 0x5CDB)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x5CE3);
    // JNZ 0x0000:5cfd (0000_5CE1 / 0x5CE1)
    if(!ZeroFlag) {
      goto label_0000_5CFD_05CFD;
    }
    CheckExternalEvents(cs1, 0x5CE6);
    // MOV AX,0x10 (0000_5CE3 / 0x5CE3)
    AX = 0x10;
    CheckExternalEvents(cs1, 0x5CE7);
    // PUSH AX (0000_5CE6 / 0x5CE6)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5CEA);
    // MOV AX,0x2 (0000_5CE7 / 0x5CE7)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x5CEB);
    // PUSH AX (0000_5CEA / 0x5CEA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5CEE);
    // MOV AX,0x642b (0000_5CEB / 0x5CEB)
    AX = 0x642B;
    CheckExternalEvents(cs1, 0x5CF1);
    // MOV DX,0x1ddc (0000_5CEE / 0x5CEE)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x5CF2);
    // PUSH DX (0000_5CF1 / 0x5CF1)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x5CF3);
    // PUSH AX (0000_5CF2 / 0x5CF2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5CF4);
    // PUSH DX (0000_5CF3 / 0x5CF3)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x5CF5);
    // PUSH AX (0000_5CF4 / 0x5CF4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5CFA);
    // CALLF 0x1000:a053 (0000_5CF5 / 0x5CF5)
    FarCall(cs1, 0x5CFA, ghidra_guess_1000_A053_1A053);
    CheckExternalEvents(cs1, 0x5CFD);
    // ADD SP,0xc (0000_5CFA / 0x5CFA)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    label_0000_5CFD_05CFD:
    CheckExternalEvents(cs1, 0x5D01);
    // MOV ES,word ptr [0x53a0] (0000_5CFD / 0x5CFD)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs1, 0x5D07);
    // CMP word ptr ES:[0x4fba],0x2 (0000_5D01 / 0x5D01)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs1, 0x5D09);
    // JNZ 0x0000:5d1f (0000_5D07 / 0x5D07)
    if(!ZeroFlag) {
      goto label_0000_5D1F_05D1F;
    }
    CheckExternalEvents(cs1, 0x5D0C);
    // MOV AX,0x10 (0000_5D09 / 0x5D09)
    AX = 0x10;
    CheckExternalEvents(cs1, 0x5D0D);
    // PUSH AX (0000_5D0C / 0x5D0C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5D10);
    // MOV AX,0x642b (0000_5D0D / 0x5D0D)
    AX = 0x642B;
    CheckExternalEvents(cs1, 0x5D13);
    // MOV DX,0x1ddc (0000_5D10 / 0x5D10)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x5D14);
    // PUSH DX (0000_5D13 / 0x5D13)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x5D15);
    // PUSH AX (0000_5D14 / 0x5D14)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5D16);
    // PUSH DX (0000_5D15 / 0x5D15)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x5D17);
    // PUSH AX (0000_5D16 / 0x5D16)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5D1C);
    // CALLF 0x1000:a462 (0000_5D17 / 0x5D17)
    FarCall(cs1, 0x5D1C, ghidra_guess_1000_A462_1A462);
    CheckExternalEvents(cs1, 0x5D1F);
    // ADD SP,0xa (0000_5D1C / 0x5D1C)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    label_0000_5D1F_05D1F:
    CheckExternalEvents(cs1, 0x5D20);
    // POP BP (0000_5D1F / 0x5D1F)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x5D21);
    // RETF  (0000_5D20 / 0x5D20)
    return FarRet();
  }
  
  public virtual Action unknown_0170_4621_05D21(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_4621_05D21:
    CheckExternalEvents(cs2, 0x4623);
    // XOR AX,AX (0170_4621 / 0x5D21)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs2, 0x4628);
    // CALLF 0x1000:cecc (0170_4623 / 0x5D23)
    FarCall(cs2, 0x4628, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x462B);
    // MOV AX,0x150 (0170_4628 / 0x5D28)
    AX = 0x150;
    CheckExternalEvents(cs2, 0x462E);
    // MOV DX,0x2958 (0170_462B / 0x5D2B)
    DX = 0x2958;
    CheckExternalEvents(cs2, 0x462F);
    // PUSH DX (0170_462E / 0x5D2E)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x4630);
    // PUSH AX (0170_462F / 0x5D2F)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4635);
    // CALLF 0x1000:9fc1 (0170_4630 / 0x5D30)
    FarCall(cs2, 0x4635, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs2, 0x4638);
    // ADD SP,0x4 (0170_4635 / 0x5D35)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x463C);
    // MOV ES,word ptr [0x53e8] (0170_4638 / 0x5D38)
    ES = UInt16[DS, 0x53E8];
    CheckExternalEvents(cs2, 0x4643);
    // MOV word ptr ES:[0x4fbc],0x1 (0170_463C / 0x5D3C)
    UInt16[ES, 0x4FBC] = 0x1;
    CheckExternalEvents(cs2, 0x4646);
    // MOV AX,0x2 (0170_4643 / 0x5D43)
    AX = 0x2;
    CheckExternalEvents(cs2, 0x4647);
    // PUSH AX (0170_4646 / 0x5D46)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4648);
    // PUSH CS (0170_4647 / 0x5D47)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x464B);
    // CALL 0x0000:3fcc (0170_4648 / 0x5D48)
    NearCall(cs2, 0x464B, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs2, 0x464E);
    // ADD SP,0x2 (0170_464B / 0x5D4B)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4651);
    // MOV AX,0x244b (0170_464E / 0x5D4E)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x4654);
    // MOV DX,0x1ddc (0170_4651 / 0x5D51)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x4655);
    // PUSH DX (0170_4654 / 0x5D54)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x4656);
    // PUSH AX (0170_4655 / 0x5D55)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4659);
    // MOV AX,0xa9a (0170_4656 / 0x5D56)
    AX = 0xA9A;
    CheckExternalEvents(cs2, 0x465A);
    // PUSH DS (0170_4659 / 0x5D59)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x465B);
    // PUSH AX (0170_465A / 0x5D5A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4660);
    // CALLF 0x1000:910b (0170_465B / 0x5D5B)
    FarCall(cs2, 0x4660, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs2, 0x4663);
    // ADD SP,0x8 (0170_4660 / 0x5D60)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs2, 0x4666);
    // MOV AX,0x4614 (0170_4663 / 0x5D63)
    AX = 0x4614;
    CheckExternalEvents(cs2, 0x4669);
    // MOV DX,0x2a02 (0170_4666 / 0x5D66)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x466A);
    // PUSH DX (0170_4669 / 0x5D69)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x466B);
    // PUSH AX (0170_466A / 0x5D6A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x466E);
    // MOV AX,0x244b (0170_466B / 0x5D6B)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x4671);
    // MOV DX,0x1ddc (0170_466E / 0x5D6E)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x4672);
    // PUSH DX (0170_4671 / 0x5D71)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x4673);
    // PUSH AX (0170_4672 / 0x5D72)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4678);
    // CALLF 0x1000:8f6d (0170_4673 / 0x5D73)
    FarCall(cs2, 0x4678, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs2, 0x467B);
    // ADD SP,0x8 (0170_4678 / 0x5D78)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs2, 0x467F);
    // MOV ES,word ptr [0x53a0] (0170_467B / 0x5D7B)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x4685);
    // CMP word ptr ES:[0x4fba],0x2 (0170_467F / 0x5D7F)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0x4687);
    // JNZ 0x0000:5d9b (0170_4685 / 0x5D85)
    if(!ZeroFlag) {
      goto label_0170_469B_05D9B;
    }
    CheckExternalEvents(cs2, 0x468A);
    // MOV AX,0xa400 (0170_4687 / 0x5D87)
    AX = 0xA400;
    CheckExternalEvents(cs2, 0x468B);
    // PUSH AX (0170_468A / 0x5D8A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x468E);
    // MOV AX,0x4614 (0170_468B / 0x5D8B)
    AX = 0x4614;
    CheckExternalEvents(cs2, 0x4691);
    // MOV DX,0x2a02 (0170_468E / 0x5D8E)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x4692);
    // PUSH DX (0170_4691 / 0x5D91)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x4693);
    // PUSH AX (0170_4692 / 0x5D92)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4698);
    // CALLF 0x1000:a150 (0170_4693 / 0x5D93)
    FarCall(cs2, 0x4698, ghidra_guess_1000_A150_1A150);
    CheckExternalEvents(cs2, 0x469B);
    // ADD SP,0x6 (0170_4698 / 0x5D98)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    label_0170_469B_05D9B:
    CheckExternalEvents(cs2, 0x469F);
    // MOV ES,word ptr [0x53d2] (0170_469B / 0x5D9B)
    ES = UInt16[DS, 0x53D2];
    CheckExternalEvents(cs2, 0x46A6);
    // MOV word ptr ES:[0x3988],0x0 (0170_469F / 0x5D9F)
    UInt16[ES, 0x3988] = 0x0;
    CheckExternalEvents(cs2, 0x46A7);
    // RETF  (0170_46A6 / 0x5DA6)
    return FarRet();
  }
  
  public virtual Action unknown_0170_46A7_05DA7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_46A7_05DA7:
    CheckExternalEvents(cs2, 0x46A9);
    // XOR AX,AX (0170_46A7 / 0x5DA7)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs2, 0x46AE);
    // CALLF 0x1000:cecc (0170_46A9 / 0x5DA9)
    FarCall(cs2, 0x46AE, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x46B2);
    // MOV ES,word ptr [0x53a0] (0170_46AE / 0x5DAE)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x46B8);
    // CMP word ptr ES:[0x4fba],0x3 (0170_46B2 / 0x5DB2)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x3);
    CheckExternalEvents(cs2, 0x46BA);
    // JZ 0x0000:5dc2 (0170_46B8 / 0x5DB8)
    if(ZeroFlag) {
      goto label_0170_46C2_05DC2;
    }
    CheckExternalEvents(cs2, 0x46BD);
    // MOV AX,0x0 (0170_46BA / 0x5DBA)
    AX = 0x0;
    CheckExternalEvents(cs2, 0x46C0);
    // MOV DX,0x2958 (0170_46BD / 0x5DBD)
    DX = 0x2958;
    CheckExternalEvents(cs2, 0x46C2);
    // JMP 0x0000:5dc8 (0170_46C0 / 0x5DC0)
    goto label_0170_46C8_05DC8;
    label_0170_46C2_05DC2:
    CheckExternalEvents(cs2, 0x46C5);
    // MOV AX,0x10 (0170_46C2 / 0x5DC2)
    AX = 0x10;
    CheckExternalEvents(cs2, 0x46C8);
    // MOV DX,0x2958 (0170_46C5 / 0x5DC5)
    DX = 0x2958;
    label_0170_46C8_05DC8:
    CheckExternalEvents(cs2, 0x46C9);
    // PUSH DX (0170_46C8 / 0x5DC8)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x46CA);
    // PUSH AX (0170_46C9 / 0x5DC9)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x46CF);
    // CALLF 0x1000:8ff5 (0170_46CA / 0x5DCA)
    FarCall(cs2, 0x46CF, unknown_18AD_0525_18FF5);
    CheckExternalEvents(cs2, 0x46D2);
    // ADD SP,0x4 (0170_46CF / 0x5DCF)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x46D5);
    // MOV AX,0x2 (0170_46D2 / 0x5DD2)
    AX = 0x2;
    CheckExternalEvents(cs2, 0x46D6);
    // PUSH AX (0170_46D5 / 0x5DD5)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x46D7);
    // PUSH CS (0170_46D6 / 0x5DD6)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x46DA);
    // CALL 0x0000:3fcc (0170_46D7 / 0x5DD7)
    NearCall(cs2, 0x46DA, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs2, 0x46DD);
    // ADD SP,0x2 (0170_46DA / 0x5DDA)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x46E0);
    // MOV AX,0x210 (0170_46DD / 0x5DDD)
    AX = 0x210;
    CheckExternalEvents(cs2, 0x46E3);
    // MOV DX,0x2958 (0170_46E0 / 0x5DE0)
    DX = 0x2958;
    CheckExternalEvents(cs2, 0x46E4);
    // PUSH DX (0170_46E3 / 0x5DE3)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x46E5);
    // PUSH AX (0170_46E4 / 0x5DE4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x46EA);
    // CALLF 0x1000:9fc1 (0170_46E5 / 0x5DE5)
    FarCall(cs2, 0x46EA, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs2, 0x46ED);
    // ADD SP,0x4 (0170_46EA / 0x5DEA)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x46F0);
    // MOV AX,0x4614 (0170_46ED / 0x5DED)
    AX = 0x4614;
    CheckExternalEvents(cs2, 0x46F3);
    // MOV DX,0x2a02 (0170_46F0 / 0x5DF0)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x46F4);
    // PUSH DX (0170_46F3 / 0x5DF3)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x46F5);
    // PUSH AX (0170_46F4 / 0x5DF4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x46F8);
    // MOV AX,0xaa7 (0170_46F5 / 0x5DF5)
    AX = 0xAA7;
    CheckExternalEvents(cs2, 0x46F9);
    // PUSH DS (0170_46F8 / 0x5DF8)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x46FA);
    // PUSH AX (0170_46F9 / 0x5DF9)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x46FF);
    // CALLF 0x1000:910b (0170_46FA / 0x5DFA)
    FarCall(cs2, 0x46FF, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs2, 0x4702);
    // ADD SP,0x8 (0170_46FF / 0x5DFF)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs2, 0x4706);
    // MOV ES,word ptr [0x53e8] (0170_4702 / 0x5E02)
    ES = UInt16[DS, 0x53E8];
    CheckExternalEvents(cs2, 0x470D);
    // MOV word ptr ES:[0x4fbc],0x0 (0170_4706 / 0x5E06)
    UInt16[ES, 0x4FBC] = 0x0;
    CheckExternalEvents(cs2, 0x4710);
    // MOV AX,0x244b (0170_470D / 0x5E0D)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x4713);
    // MOV DX,0x1ddc (0170_4710 / 0x5E10)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x4714);
    // PUSH DX (0170_4713 / 0x5E13)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x4715);
    // PUSH AX (0170_4714 / 0x5E14)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4718);
    // MOV AX,0x4614 (0170_4715 / 0x5E15)
    AX = 0x4614;
    CheckExternalEvents(cs2, 0x471B);
    // MOV DX,0x2a02 (0170_4718 / 0x5E18)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x471C);
    // PUSH DX (0170_471B / 0x5E1B)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x471D);
    // PUSH AX (0170_471C / 0x5E1C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4722);
    // CALLF 0x1000:8f6d (0170_471D / 0x5E1D)
    FarCall(cs2, 0x4722, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs2, 0x4725);
    // ADD SP,0x8 (0170_4722 / 0x5E22)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs2, 0x4729);
    // MOV ES,word ptr [0x53a0] (0170_4725 / 0x5E25)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x472F);
    // CMP word ptr ES:[0x4fba],0x2 (0170_4729 / 0x5E29)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0x4731);
    // JNZ 0x0000:5e45 (0170_472F / 0x5E2F)
    if(!ZeroFlag) {
      goto label_0170_4745_05E45;
    }
    CheckExternalEvents(cs2, 0x4734);
    // MOV AX,0xa800 (0170_4731 / 0x5E31)
    AX = 0xA800;
    CheckExternalEvents(cs2, 0x4735);
    // PUSH AX (0170_4734 / 0x5E34)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4738);
    // MOV AX,0x244b (0170_4735 / 0x5E35)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x473B);
    // MOV DX,0x1ddc (0170_4738 / 0x5E38)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x473C);
    // PUSH DX (0170_473B / 0x5E3B)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x473D);
    // PUSH AX (0170_473C / 0x5E3C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4742);
    // CALLF 0x1000:a150 (0170_473D / 0x5E3D)
    FarCall(cs2, 0x4742, ghidra_guess_1000_A150_1A150);
    CheckExternalEvents(cs2, 0x4745);
    // ADD SP,0x6 (0170_4742 / 0x5E42)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    label_0170_4745_05E45:
    CheckExternalEvents(cs2, 0x4748);
    // MOV AX,0xc8 (0170_4745 / 0x5E45)
    AX = 0xC8;
    CheckExternalEvents(cs2, 0x4749);
    // PUSH AX (0170_4748 / 0x5E48)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x474C);
    // MOV AX,0x28 (0170_4749 / 0x5E49)
    AX = 0x28;
    CheckExternalEvents(cs2, 0x474D);
    // PUSH AX (0170_474C / 0x5E4C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x474F);
    // SUB AX,AX (0170_474D / 0x5E4D)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x4750);
    // PUSH AX (0170_474F / 0x5E4F)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4751);
    // PUSH AX (0170_4750 / 0x5E50)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4754);
    // MOV AX,0x244b (0170_4751 / 0x5E51)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x4757);
    // MOV DX,0x1ddc (0170_4754 / 0x5E54)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x4758);
    // PUSH DX (0170_4757 / 0x5E57)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x4759);
    // PUSH AX (0170_4758 / 0x5E58)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x475E);
    // CALLF 0x1000:8b56 (0170_4759 / 0x5E59)
    FarCall(cs2, 0x475E, unknown_18AD_0086_18B56);
    CheckExternalEvents(cs2, 0x4761);
    // ADD SP,0xc (0170_475E / 0x5E5E)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs2, 0x4765);
    // MOV ES,word ptr [0x53d2] (0170_4761 / 0x5E61)
    ES = UInt16[DS, 0x53D2];
    CheckExternalEvents(cs2, 0x476C);
    // MOV word ptr ES:[0x3988],0xffff (0170_4765 / 0x5E65)
    UInt16[ES, 0x3988] = 0xFFFF;
    CheckExternalEvents(cs2, 0x476D);
    // RETF  (0170_476C / 0x5E6C)
    return FarRet();
  }
  
  public virtual Action unknown_0170_476D_05E6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_476D_05E6D:
    CheckExternalEvents(cs2, 0x476E);
    // PUSH BP (0170_476D / 0x5E6D)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x4770);
    // MOV BP,SP (0170_476E / 0x5E6E)
    BP = SP;
    CheckExternalEvents(cs2, 0x4773);
    // MOV AX,0x4 (0170_4770 / 0x5E70)
    AX = 0x4;
    CheckExternalEvents(cs2, 0x4778);
    // CALLF 0x1000:cecc (0170_4773 / 0x5E73)
    FarCall(cs2, 0x4778, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x477B);
    // MOV AX,0x2 (0170_4778 / 0x5E78)
    AX = 0x2;
    CheckExternalEvents(cs2, 0x477C);
    // PUSH AX (0170_477B / 0x5E7B)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x477D);
    // PUSH CS (0170_477C / 0x5E7C)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4780);
    // CALL 0x0000:3fcc (0170_477D / 0x5E7D)
    NearCall(cs2, 0x4780, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs2, 0x4782);
    // JMP 0x0000:5e8a (0170_4780 / 0x5E80)
    goto label_0170_478A_05E8A;
    label_0170_4782_05E82:
    CheckExternalEvents(cs2, 0x4786);
    // PUSH word ptr [0x14e] (0170_4782 / 0x5E82)
    Stack.Push16(UInt16[DS, 0x14E]);
    CheckExternalEvents(cs2, 0x4787);
    // PUSH CS (0170_4786 / 0x5E86)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x478A);
    // CALL 0x0000:4013 (0170_4787 / 0x5E87)
    NearCall(cs2, 0x478A, ghidra_guess_0000_4013_04013);
    label_0170_478A_05E8A:
    CheckExternalEvents(cs2, 0x478D);
    // ADD SP,0x2 (0170_478A / 0x5E8A)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4790);
    // MOV AX,0x8000 (0170_478D / 0x5E8D)
    AX = 0x8000;
    CheckExternalEvents(cs2, 0x4791);
    // PUSH AX (0170_4790 / 0x5E90)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4794);
    // MOV AX,0xab3 (0170_4791 / 0x5E91)
    AX = 0xAB3;
    CheckExternalEvents(cs2, 0x4795);
    // PUSH DS (0170_4794 / 0x5E94)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x4796);
    // PUSH AX (0170_4795 / 0x5E95)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x479B);
    // CALLF 0x1000:d2c0 (0170_4796 / 0x5E96)
    FarCall(cs2, 0x479B, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs2, 0x479E);
    // ADD SP,0x6 (0170_479B / 0x5E9B)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    CheckExternalEvents(cs2, 0x47A1);
    // MOV word ptr [BP + -0x4],AX (0170_479E / 0x5E9E)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs2, 0x47A2);
    // INC AX (0170_47A1 / 0x5EA1)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs2, 0x47A4);
    // JZ 0x0000:5e82 (0170_47A2 / 0x5EA2)
    if(ZeroFlag) {
      goto label_0170_4782_05E82;
    }
    CheckExternalEvents(cs2, 0x47A7);
    // MOV AX,0x2 (0170_47A4 / 0x5EA4)
    AX = 0x2;
    CheckExternalEvents(cs2, 0x47A8);
    // PUSH AX (0170_47A7 / 0x5EA7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x47AA);
    // SUB AX,AX (0170_47A8 / 0x5EA8)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x47AB);
    // PUSH AX (0170_47AA / 0x5EAA)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x47AC);
    // PUSH AX (0170_47AB / 0x5EAB)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x47AF);
    // PUSH word ptr [BP + -0x4] (0170_47AC / 0x5EAC)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x47B4);
    // CALLF 0x1000:d246 (0170_47AF / 0x5EAF)
    FarCall(cs2, 0x47B4, unknown_19EF_3356_1D246);
    CheckExternalEvents(cs2, 0x47B7);
    // ADD SP,0x8 (0170_47B4 / 0x5EB4)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs2, 0x47BA);
    // MOV word ptr [BP + -0x2],AX (0170_47B7 / 0x5EB7)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x47BC);
    // SUB AX,AX (0170_47BA / 0x5EBA)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x47BD);
    // PUSH AX (0170_47BC / 0x5EBC)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x47BE);
    // PUSH AX (0170_47BD / 0x5EBD)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x47BF);
    // PUSH AX (0170_47BE / 0x5EBE)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x47C2);
    // PUSH word ptr [BP + -0x4] (0170_47BF / 0x5EBF)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x47C7);
    // CALLF 0x1000:d246 (0170_47C2 / 0x5EC2)
    FarCall(cs2, 0x47C7, unknown_19EF_3356_1D246);
    CheckExternalEvents(cs2, 0x47CA);
    // ADD SP,0x8 (0170_47C7 / 0x5EC7)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs2, 0x47CD);
    // PUSH word ptr [BP + -0x2] (0170_47CA / 0x5ECA)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x47D0);
    // MOV AX,0x244b (0170_47CD / 0x5ECD)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x47D3);
    // MOV DX,0x1ddc (0170_47D0 / 0x5ED0)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x47D4);
    // PUSH DX (0170_47D3 / 0x5ED3)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x47D5);
    // PUSH AX (0170_47D4 / 0x5ED4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x47D8);
    // PUSH word ptr [BP + -0x4] (0170_47D5 / 0x5ED5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x47DD);
    // CALLF 0x1000:d470 (0170_47D8 / 0x5ED8)
    FarCall(cs2, 0x47DD, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x47E0);
    // ADD SP,0x8 (0170_47DD / 0x5EDD)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs2, 0x47E3);
    // PUSH word ptr [BP + -0x4] (0170_47E0 / 0x5EE0)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x47E8);
    // CALLF 0x1000:d226 (0170_47E3 / 0x5EE3)
    FarCall(cs2, 0x47E8, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs2, 0x47EB);
    // ADD SP,0x2 (0170_47E8 / 0x5EE8)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x47EE);
    // MOV BX,word ptr [BP + -0x2] (0170_47EB / 0x5EEB)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x47F2);
    // MOV ES,word ptr [0x53c6] (0170_47EE / 0x5EEE)
    ES = UInt16[DS, 0x53C6];
    CheckExternalEvents(cs2, 0x47F8);
    // MOV byte ptr ES:[BX + 0x244b],0x0 (0170_47F2 / 0x5EF2)
    UInt8[ES, (ushort)(BX + 0x244B)] = 0x0;
    CheckExternalEvents(cs2, 0x47FB);
    // MOV BX,word ptr [BP + -0x2] (0170_47F8 / 0x5EF8)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4801);
    // MOV byte ptr ES:[BX + 0x244c],0x0 (0170_47FB / 0x5EFB)
    UInt8[ES, (ushort)(BX + 0x244C)] = 0x0;
    CheckExternalEvents(cs2, 0x4804);
    // MOV BX,word ptr [BP + -0x2] (0170_4801 / 0x5F01)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x480A);
    // MOV byte ptr ES:[BX + 0x244d],0x0 (0170_4804 / 0x5F04)
    UInt8[ES, (ushort)(BX + 0x244D)] = 0x0;
    CheckExternalEvents(cs2, 0x480D);
    // MOV BX,word ptr [BP + -0x2] (0170_480A / 0x5F0A)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4813);
    // MOV byte ptr ES:[BX + 0x244e],0x0 (0170_480D / 0x5F0D)
    UInt8[ES, (ushort)(BX + 0x244E)] = 0x0;
    CheckExternalEvents(cs2, 0x4818);
    // CALLF 0x1000:9bf8 (0170_4813 / 0x5F13)
    FarCall(cs2, 0x4818, unknown_19BB_0048_19BF8);
    CheckExternalEvents(cs2, 0x481C);
    // MOV ES,word ptr [0x53a0] (0170_4818 / 0x5F18)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x4822);
    // CMP word ptr ES:[0x4fba],0x1 (0170_481C / 0x5F1C)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x1);
    CheckExternalEvents(cs2, 0x4824);
    // JNZ 0x0000:5f46 (0170_4822 / 0x5F22)
    if(!ZeroFlag) {
      goto label_0170_4846_05F46;
    }
    CheckExternalEvents(cs2, 0x4826);
    // SUB AX,AX (0170_4824 / 0x5F24)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x4827);
    // PUSH AX (0170_4826 / 0x5F26)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x482C);
    // CALLF 0x1000:9e94 (0170_4827 / 0x5F27)
    FarCall(cs2, 0x482C, ghidra_guess_1000_9E94_19E94);
    CheckExternalEvents(cs2, 0x482F);
    // ADD SP,0x2 (0170_482C / 0x5F2C)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4832);
    // MOV AX,0x14 (0170_482F / 0x5F2F)
    AX = 0x14;
    CheckExternalEvents(cs2, 0x4833);
    // PUSH AX (0170_4832 / 0x5F32)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4836);
    // MOV AX,0x244b (0170_4833 / 0x5F33)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x4839);
    // MOV DX,0x1ddc (0170_4836 / 0x5F36)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x483A);
    // PUSH DX (0170_4839 / 0x5F39)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x483B);
    // PUSH AX (0170_483A / 0x5F3A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x483E);
    // MOV AX,0x1 (0170_483B / 0x5F3B)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x483F);
    // PUSH AX (0170_483E / 0x5F3E)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4844);
    // CALLF 0x1000:9e94 (0170_483F / 0x5F3F)
    FarCall(cs2, 0x4844, ghidra_guess_1000_9E94_19E94);
    CheckExternalEvents(cs2, 0x4846);
    // JMP 0x0000:5f66 (0170_4844 / 0x5F44)
    goto label_0170_4866_05F66;
    label_0170_4846_05F46:
    CheckExternalEvents(cs2, 0x4848);
    // SUB AX,AX (0170_4846 / 0x5F46)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x4849);
    // PUSH AX (0170_4848 / 0x5F48)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x484E);
    // CALLF 0x1000:9eb6 (0170_4849 / 0x5F49)
    FarCall(cs2, 0x484E, unknown_19BB_0306_19EB6);
    CheckExternalEvents(cs2, 0x4851);
    // ADD SP,0x2 (0170_484E / 0x5F4E)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4854);
    // MOV AX,0x4 (0170_4851 / 0x5F51)
    AX = 0x4;
    CheckExternalEvents(cs2, 0x4855);
    // PUSH AX (0170_4854 / 0x5F54)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4858);
    // MOV AX,0x244b (0170_4855 / 0x5F55)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x485B);
    // MOV DX,0x1ddc (0170_4858 / 0x5F58)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x485C);
    // PUSH DX (0170_485B / 0x5F5B)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x485D);
    // PUSH AX (0170_485C / 0x5F5C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4860);
    // MOV AX,0x1 (0170_485D / 0x5F5D)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x4861);
    // PUSH AX (0170_4860 / 0x5F60)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4866);
    // CALLF 0x1000:9eb6 (0170_4861 / 0x5F61)
    FarCall(cs2, 0x4866, unknown_19BB_0306_19EB6);
    label_0170_4866_05F66:
    CheckExternalEvents(cs2, 0x4869);
    // ADD SP,0x8 (0170_4866 / 0x5F66)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs2, 0x486D);
    // MOV ES,word ptr [0x5384] (0170_4869 / 0x5F69)
    ES = UInt16[DS, 0x5384];
    CheckExternalEvents(cs2, 0x4874);
    // MOV word ptr ES:[0x3938],0x0 (0170_486D / 0x5F6D)
    UInt16[ES, 0x3938] = 0x0;
    label_0170_4874_05F74:
    CheckExternalEvents(cs2, 0x4879);
    // CALLF 0x1000:8aff (0170_4874 / 0x5F74)
    FarCall(cs2, 0x4879, unknown_18AD_002F_18AFF);
    CheckExternalEvents(cs2, 0x487B);
    // OR AX,AX (0170_4879 / 0x5F79)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x487D);
    // JNZ 0x0000:5f8d (0170_487B / 0x5F7B)
    if(!ZeroFlag) {
      goto label_0170_488D_05F8D;
    }
    CheckExternalEvents(cs2, 0x4880);
    // MOV AX,0x1 (0170_487D / 0x5F7D)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x4881);
    // PUSH AX (0170_4880 / 0x5F80)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4886);
    // CALLF 0x1000:9eec (0170_4881 / 0x5F81)
    FarCall(cs2, 0x4886, unknown_19BB_033C_19EEC);
    CheckExternalEvents(cs2, 0x4889);
    // ADD SP,0x2 (0170_4886 / 0x5F86)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x488B);
    // OR AX,AX (0170_4889 / 0x5F89)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x488D);
    // JZ 0x0000:5f74 (0170_488B / 0x5F8B)
    if(ZeroFlag) {
      goto label_0170_4874_05F74;
    }
    label_0170_488D_05F8D:
    CheckExternalEvents(cs2, 0x4891);
    // MOV ES,word ptr [0x53a0] (0170_488D / 0x5F8D)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x4897);
    // CMP word ptr ES:[0x4fba],0x1 (0170_4891 / 0x5F91)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x1);
    CheckExternalEvents(cs2, 0x4899);
    // JNZ 0x0000:5fa3 (0170_4897 / 0x5F97)
    if(!ZeroFlag) {
      goto label_0170_48A3_05FA3;
    }
    CheckExternalEvents(cs2, 0x489B);
    // SUB AX,AX (0170_4899 / 0x5F99)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x489C);
    // PUSH AX (0170_489B / 0x5F9B)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x48A1);
    // CALLF 0x1000:9e94 (0170_489C / 0x5F9C)
    FarCall(cs2, 0x48A1, ghidra_guess_1000_9E94_19E94);
    CheckExternalEvents(cs2, 0x48A3);
    // JMP 0x0000:5fab (0170_48A1 / 0x5FA1)
    goto label_0170_48AB_05FAB;
    label_0170_48A3_05FA3:
    CheckExternalEvents(cs2, 0x48A5);
    // SUB AX,AX (0170_48A3 / 0x5FA3)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x48A6);
    // PUSH AX (0170_48A5 / 0x5FA5)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x48AB);
    // CALLF 0x1000:9eb6 (0170_48A6 / 0x5FA6)
    FarCall(cs2, 0x48AB, unknown_19BB_0306_19EB6);
    label_0170_48AB_05FAB:
    CheckExternalEvents(cs2, 0x48AE);
    // ADD SP,0x2 (0170_48AB / 0x5FAB)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x48B3);
    // CALLF 0x1000:9c41 (0170_48AE / 0x5FAE)
    FarCall(cs2, 0x48B3, unknown_19BB_0091_19C41);
    CheckExternalEvents(cs2, 0x48B5);
    // MOV SP,BP (0170_48B3 / 0x5FB3)
    SP = BP;
    CheckExternalEvents(cs2, 0x48B6);
    // POP BP (0170_48B5 / 0x5FB5)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x48B7);
    // RETF  (0170_48B6 / 0x5FB6)
    return FarRet();
  }
  
  public virtual Action unknown_0170_48B7_05FB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_48B7_05FB7:
    CheckExternalEvents(cs2, 0x48B8);
    // PUSH BP (0170_48B7 / 0x5FB7)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x48BA);
    // MOV BP,SP (0170_48B8 / 0x5FB8)
    BP = SP;
    CheckExternalEvents(cs2, 0x48BD);
    // MOV AX,0x8 (0170_48BA / 0x5FBA)
    AX = 0x8;
    CheckExternalEvents(cs2, 0x48C2);
    // CALLF 0x1000:cecc (0170_48BD / 0x5FBD)
    FarCall(cs2, 0x48C2, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x48C6);
    // MOV ES,word ptr [0x53fe] (0170_48C2 / 0x5FC2)
    ES = UInt16[DS, 0x53FE];
    CheckExternalEvents(cs2, 0x48CC);
    // MOV byte ptr ES:[0x12],0x4f (0170_48C6 / 0x5FC6)
    UInt8[ES, 0x12] = 0x4F;
    CheckExternalEvents(cs2, 0x48CF);
    // MOV AX,0xa (0170_48CC / 0x5FCC)
    AX = 0xA;
    CheckExternalEvents(cs2, 0x48D0);
    // PUSH AX (0170_48CF / 0x5FCF)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x48D3);
    // MOV AX,0x13 (0170_48D0 / 0x5FD0)
    AX = 0x13;
    CheckExternalEvents(cs2, 0x48D6);
    // MOV DX,0x2a02 (0170_48D3 / 0x5FD3)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x48D7);
    // PUSH DX (0170_48D6 / 0x5FD6)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x48D8);
    // PUSH AX (0170_48D7 / 0x5FD7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x48DB);
    // PUSH word ptr [BP + 0x6] (0170_48D8 / 0x5FD8)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs2, 0x48E0);
    // CALLF 0x1000:daa6 (0170_48DB / 0x5FDB)
    FarCall(cs2, 0x48E0, unknown_19EF_3BB6_1DAA6);
    CheckExternalEvents(cs2, 0x48E3);
    // ADD SP,0x8 (0170_48E0 / 0x5FE0)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs2, 0x48E6);
    // MOV AX,0xabf (0170_48E3 / 0x5FE3)
    AX = 0xABF;
    CheckExternalEvents(cs2, 0x48E7);
    // PUSH DS (0170_48E6 / 0x5FE6)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x48E8);
    // PUSH AX (0170_48E7 / 0x5FE7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x48EB);
    // MOV AX,0x12 (0170_48E8 / 0x5FE8)
    AX = 0x12;
    CheckExternalEvents(cs2, 0x48EE);
    // MOV DX,0x2a02 (0170_48EB / 0x5FEB)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x48EF);
    // PUSH DX (0170_48EE / 0x5FEE)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x48F0);
    // PUSH AX (0170_48EF / 0x5FEF)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x48F5);
    // CALLF 0x1000:da12 (0170_48F0 / 0x5FF0)
    FarCall(cs2, 0x48F5, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs2, 0x48F8);
    // ADD SP,0x8 (0170_48F5 / 0x5FF5)
    SP += 0x8;
    CheckExternalEvents(cs2, 0x48FA);
    // SUB AX,AX (0170_48F8 / 0x5FF8)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x48FD);
    // MOV word ptr [BP + -0x8],AX (0170_48FA / 0x5FFA)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x4900);
    // MOV word ptr [BP + -0x2],AX (0170_48FD / 0x5FFD)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x4905);
    // CALLF 0x1000:aab0 (0170_4900 / 0x6000)
    FarCall(cs2, 0x4905, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs2, 0x4909);
    // MOV ES,word ptr [0x538a] (0170_4905 / 0x6005)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x490B);
    // MOV CX,AX (0170_4909 / 0x6009)
    CX = AX;
    CheckExternalEvents(cs2, 0x490F);
    // MOV AL,ES:[0xd35b] (0170_490B / 0x600B)
    AL = UInt8[ES, 0xD35B];
    CheckExternalEvents(cs2, 0x4910);
    // CBW  (0170_490F / 0x600F)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x4912);
    // MOV BX,AX (0170_4910 / 0x6010)
    BX = AX;
    CheckExternalEvents(cs2, 0x4914);
    // SHL BX,0x1 (0170_4912 / 0x6012)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x4918);
    // TEST word ptr [BX + 0xac4],CX (0170_4914 / 0x6014)
    Alu.And16(UInt16[DS, (ushort)(BX + 0xAC4)], CX);
    CheckExternalEvents(cs2, 0x491A);
    // JNZ 0x0000:601f (0170_4918 / 0x6018)
    if(!ZeroFlag) {
      goto label_0170_491F_0601F;
    }
    CheckExternalEvents(cs2, 0x491F);
    // MOV word ptr [BP + -0x8],0x1 (0170_491A / 0x601A)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    label_0170_491F_0601F:
    CheckExternalEvents(cs2, 0x4923);
    // CMP word ptr [BP + 0x6],0x10 (0170_491F / 0x601F)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x10);
    CheckExternalEvents(cs2, 0x4925);
    // JZ 0x0000:6042 (0170_4923 / 0x6023)
    if(ZeroFlag) {
      goto label_0170_4942_06042;
    }
    CheckExternalEvents(cs2, 0x4929);
    // CMP word ptr [BP + 0x6],0x0 (0170_4925 / 0x6025)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs2, 0x492B);
    // JZ 0x0000:603d (0170_4929 / 0x6029)
    if(ZeroFlag) {
      goto label_0170_493D_0603D;
    }
    CheckExternalEvents(cs2, 0x492F);
    // CMP word ptr [BP + 0x6],0x7 (0170_492B / 0x602B)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x7);
    CheckExternalEvents(cs2, 0x4931);
    // JG 0x0000:603d (0170_492F / 0x602F)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0170_493D_0603D;
    }
    CheckExternalEvents(cs2, 0x4935);
    // CMP word ptr [BP + 0x6],0x6 (0170_4931 / 0x6031)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x6);
    CheckExternalEvents(cs2, 0x4937);
    // JZ 0x0000:603d (0170_4935 / 0x6035)
    if(ZeroFlag) {
      goto label_0170_493D_0603D;
    }
    CheckExternalEvents(cs2, 0x493B);
    // CMP word ptr [BP + 0x6],0x2 (0170_4937 / 0x6037)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x2);
    CheckExternalEvents(cs2, 0x493D);
    // JNZ 0x0000:6042 (0170_493B / 0x603B)
    if(!ZeroFlag) {
      goto label_0170_4942_06042;
    }
    label_0170_493D_0603D:
    CheckExternalEvents(cs2, 0x4942);
    // MOV word ptr [BP + -0x8],0x1 (0170_493D / 0x603D)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    label_0170_4942_06042:
    CheckExternalEvents(cs2, 0x4946);
    // CMP word ptr [BP + 0x8],0x2 (0170_4942 / 0x6042)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0x2);
    CheckExternalEvents(cs2, 0x4948);
    // JNZ 0x0000:604d (0170_4946 / 0x6046)
    if(!ZeroFlag) {
      goto label_0170_494D_0604D;
    }
    CheckExternalEvents(cs2, 0x494D);
    // MOV word ptr [BP + -0x8],0x1 (0170_4948 / 0x6048)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    label_0170_494D_0604D:
    CheckExternalEvents(cs2, 0x4951);
    // CMP word ptr [BP + -0x8],0x0 (0170_494D / 0x604D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs2, 0x4953);
    // JNZ 0x0000:6056 (0170_4951 / 0x6051)
    if(!ZeroFlag) {
      goto label_0170_4956_06056;
    }
    CheckExternalEvents(cs2, 0x4956);
    // JMP 0x0000:61a2 (0170_4953 / 0x6053)
    goto label_0170_4AA2_061A2;
    label_0170_4956_06056:
    CheckExternalEvents(cs2, 0x495A);
    // CMP word ptr [BP + 0x6],0x8 (0170_4956 / 0x6056)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x8);
    CheckExternalEvents(cs2, 0x495C);
    // JNZ 0x0000:6061 (0170_495A / 0x605A)
    if(!ZeroFlag) {
      goto label_0170_4961_06061;
    }
    CheckExternalEvents(cs2, 0x4961);
    // MOV word ptr [BP + -0x2],0x6 (0170_495C / 0x605C)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x6;
    label_0170_4961_06061:
    CheckExternalEvents(cs2, 0x4964);
    // MOV AX,0x1 (0170_4961 / 0x6061)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x4965);
    // PUSH AX (0170_4964 / 0x6064)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4966);
    // PUSH CS (0170_4965 / 0x6065)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4969);
    // CALL 0x0000:3fcc (0170_4966 / 0x6066)
    NearCall(cs2, 0x4969, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs2, 0x496C);
    // ADD SP,0x2 (0170_4969 / 0x6069)
    SP += 0x2;
    CheckExternalEvents(cs2, 0x4970);
    // CMP word ptr [BP + 0x6],0x9 (0170_496C / 0x606C)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x9);
    CheckExternalEvents(cs2, 0x4972);
    // JLE 0x0000:6083 (0170_4970 / 0x6070)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_4983_06083;
    }
    CheckExternalEvents(cs2, 0x4976);
    // CMP word ptr [BP + 0x6],0x10 (0170_4972 / 0x6072)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x10);
    CheckExternalEvents(cs2, 0x4978);
    // JGE 0x0000:6083 (0170_4976 / 0x6076)
    if(SignFlag == OverflowFlag) {
      goto label_0170_4983_06083;
    }
    CheckExternalEvents(cs2, 0x497B);
    // MOV AX,0x2 (0170_4978 / 0x6078)
    AX = 0x2;
    CheckExternalEvents(cs2, 0x497C);
    // PUSH AX (0170_497B / 0x607B)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x497D);
    // PUSH CS (0170_497C / 0x607C)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4980);
    // CALL 0x0000:3fcc (0170_497D / 0x607D)
    NearCall(cs2, 0x4980, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs2, 0x4983);
    // ADD SP,0x2 (0170_4980 / 0x6080)
    SP += 0x2;
    label_0170_4983_06083:
    CheckExternalEvents(cs2, 0x4987);
    // CMP word ptr [BP + 0x6],0x10 (0170_4983 / 0x6083)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x10);
    CheckExternalEvents(cs2, 0x4989);
    // JLE 0x0000:60c5 (0170_4987 / 0x6087)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_49C5_060C5;
    }
    CheckExternalEvents(cs2, 0x498C);
    // MOV AX,0x8000 (0170_4989 / 0x6089)
    AX = 0x8000;
    CheckExternalEvents(cs2, 0x498D);
    // PUSH AX (0170_498C / 0x608C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4990);
    // MOV AX,0x12 (0170_498D / 0x608D)
    AX = 0x12;
    CheckExternalEvents(cs2, 0x4993);
    // MOV DX,0x2a02 (0170_4990 / 0x6090)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x4994);
    // PUSH DX (0170_4993 / 0x6093)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x4995);
    // PUSH AX (0170_4994 / 0x6094)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x499A);
    // CALLF 0x1000:d2c0 (0170_4995 / 0x6095)
    FarCall(cs2, 0x499A, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs2, 0x499D);
    // ADD SP,0x6 (0170_499A / 0x609A)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    CheckExternalEvents(cs2, 0x49A0);
    // MOV word ptr [BP + -0x6],AX (0170_499D / 0x609D)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs2, 0x49A1);
    // PUSH AX (0170_49A0 / 0x60A0)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x49A6);
    // CALLF 0x1000:d226 (0170_49A1 / 0x60A1)
    FarCall(cs2, 0x49A6, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs2, 0x49A9);
    // ADD SP,0x2 (0170_49A6 / 0x60A6)
    SP += 0x2;
    CheckExternalEvents(cs2, 0x49AD);
    // CMP word ptr [BP + -0x6],-0x1 (0170_49A9 / 0x60A9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0xFFFF);
    CheckExternalEvents(cs2, 0x49AF);
    // JNZ 0x0000:60c5 (0170_49AD / 0x60AD)
    if(!ZeroFlag) {
      goto label_0170_49C5_060C5;
    }
    CheckExternalEvents(cs2, 0x49B4);
    // MOV word ptr [BP + -0x8],0x0 (0170_49AF / 0x60AF)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs2, 0x49B7);
    // MOV AX,0x4 (0170_49B4 / 0x60B4)
    AX = 0x4;
    CheckExternalEvents(cs2, 0x49B8);
    // PUSH AX (0170_49B7 / 0x60B7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x49BD);
    // CALLF 0x1000:7ee1 (0170_49B8 / 0x60B8)
    FarCall(cs2, 0x49BD, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs2, 0x49C0);
    // ADD SP,0x2 (0170_49BD / 0x60BD)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x49C5);
    // CALLF 0x1000:7fe8 (0170_49C0 / 0x60C0)
    FarCall(cs2, 0x49C5, unknown_17C6_0388_17FE8);
    label_0170_49C5_060C5:
    CheckExternalEvents(cs2, 0x49C9);
    // CMP word ptr [BP + -0x8],0x0 (0170_49C5 / 0x60C5)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs2, 0x49CB);
    // JNZ 0x0000:60ce (0170_49C9 / 0x60C9)
    if(!ZeroFlag) {
      goto label_0170_49CE_060CE;
    }
    CheckExternalEvents(cs2, 0x49CE);
    // JMP 0x0000:61a2 (0170_49CB / 0x60CB)
    goto label_0170_4AA2_061A2;
    label_0170_49CE_060CE:
    CheckExternalEvents(cs2, 0x49D1);
    // MOV AX,0x3f00 (0170_49CE / 0x60CE)
    AX = 0x3F00;
    CheckExternalEvents(cs2, 0x49D2);
    // PUSH AX (0170_49D1 / 0x60D1)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x49D5);
    // MOV AX,0x42c3 (0170_49D2 / 0x60D2)
    AX = 0x42C3;
    CheckExternalEvents(cs2, 0x49D8);
    // MOV DX,0x1ddc (0170_49D5 / 0x60D5)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x49D9);
    // PUSH DX (0170_49D8 / 0x60D8)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x49DA);
    // PUSH AX (0170_49D9 / 0x60D9)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x49DD);
    // MOV AX,0x12 (0170_49DA / 0x60DA)
    AX = 0x12;
    CheckExternalEvents(cs2, 0x49E0);
    // MOV DX,0x2a02 (0170_49DD / 0x60DD)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x49E1);
    // PUSH DX (0170_49E0 / 0x60E0)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x49E2);
    // PUSH AX (0170_49E1 / 0x60E1)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x49E7);
    // CALLF 0x1000:92e4 (0170_49E2 / 0x60E2)
    FarCall(cs2, 0x49E7, unknown_18AD_0814_192E4);
    CheckExternalEvents(cs2, 0x49EA);
    // ADD SP,0xa (0170_49E7 / 0x60E7)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs2, 0x49ED);
    // MOV AX,0x150 (0170_49EA / 0x60EA)
    AX = 0x150;
    CheckExternalEvents(cs2, 0x49F0);
    // MOV DX,0x2958 (0170_49ED / 0x60ED)
    DX = 0x2958;
    CheckExternalEvents(cs2, 0x49F1);
    // PUSH DX (0170_49F0 / 0x60F0)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x49F2);
    // PUSH AX (0170_49F1 / 0x60F1)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x49F7);
    // CALLF 0x1000:9fc1 (0170_49F2 / 0x60F2)
    FarCall(cs2, 0x49F7, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs2, 0x49FA);
    // ADD SP,0x4 (0170_49F7 / 0x60F7)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    label_0170_49FA_060FA:
    CheckExternalEvents(cs2, 0x49FF);
    // MOV word ptr [BP + -0x4],0x0 (0170_49FA / 0x60FA)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0170_49FF_060FF:
    CheckExternalEvents(cs2, 0x4A02);
    // MOV BX,word ptr [BP + -0x4] (0170_49FF / 0x60FF)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x4A06);
    // MOV ES,word ptr [0x53c6] (0170_4A02 / 0x6102)
    ES = UInt16[DS, 0x53C6];
    CheckExternalEvents(cs2, 0x4A0C);
    // MOV byte ptr ES:[BX + 0x244b],0x0 (0170_4A06 / 0x6106)
    UInt8[ES, (ushort)(BX + 0x244B)] = 0x0;
    CheckExternalEvents(cs2, 0x4A0F);
    // INC word ptr [BP + -0x4] (0170_4A0C / 0x610C)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs2, 0x4A14);
    // CMP word ptr [BP + -0x4],0x1e78 (0170_4A0F / 0x610F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x1E78);
    CheckExternalEvents(cs2, 0x4A16);
    // JL 0x0000:60ff (0170_4A14 / 0x6114)
    if(SignFlag != OverflowFlag) {
      goto label_0170_49FF_060FF;
    }
    CheckExternalEvents(cs2, 0x4A1A);
    // MOV ES,word ptr [0x53c4] (0170_4A16 / 0x6116)
    ES = UInt16[DS, 0x53C4];
    CheckExternalEvents(cs2, 0x4A21);
    // MOV word ptr ES:[0xe48a],0x0 (0170_4A1A / 0x611A)
    UInt16[ES, 0xE48A] = 0x0;
    CheckExternalEvents(cs2, 0x4A25);
    // MOV ES,word ptr [0x53c2] (0170_4A21 / 0x6121)
    ES = UInt16[DS, 0x53C2];
    CheckExternalEvents(cs2, 0x4A2C);
    // MOV word ptr ES:[0x64],0x42f6 (0170_4A25 / 0x6125)
    UInt16[ES, 0x64] = 0x42F6;
    CheckExternalEvents(cs2, 0x4A33);
    // MOV word ptr ES:[0x66],0x1ddc (0170_4A2C / 0x612C)
    UInt16[ES, 0x66] = 0x1DDC;
    CheckExternalEvents(cs2, 0x4A34);
    // PUSH CS (0170_4A33 / 0x6133)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4A37);
    // CALL 0x0000:31fd (0170_4A34 / 0x6134)
    NearCall(cs2, 0x4A37, unknown_0170_1AFD_031FD);
    CheckExternalEvents(cs2, 0x4A3B);
    // CMP word ptr [BP + 0x6],0x8 (0170_4A37 / 0x6137)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x8);
    CheckExternalEvents(cs2, 0x4A3D);
    // JZ 0x0000:614f (0170_4A3B / 0x613B)
    if(ZeroFlag) {
      goto label_0170_4A4F_0614F;
    }
    CheckExternalEvents(cs2, 0x4A40);
    // MOV AX,0x32 (0170_4A3D / 0x613D)
    AX = 0x32;
    CheckExternalEvents(cs2, 0x4A41);
    // PUSH AX (0170_4A40 / 0x6140)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4A46);
    // CALLF 0x1000:8ad6 (0170_4A41 / 0x6141)
    FarCall(cs2, 0x4A46, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs2, 0x4A49);
    // ADD SP,0x2 (0170_4A46 / 0x6146)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4A4B);
    // JMP 0x0000:614f (0170_4A49 / 0x6149)
    goto label_0170_4A4F_0614F;
    label_0170_4A4B_0614B:
    CheckExternalEvents(cs2, 0x4A4C);
    // PUSH CS (0170_4A4B / 0x614B)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4A4F);
    // CALL 0x0000:31fd (0170_4A4C / 0x614C)
    NearCall(cs2, 0x4A4F, unknown_0170_1AFD_031FD);
    label_0170_4A4F_0614F:
    CheckExternalEvents(cs2, 0x4A53);
    // MOV ES,word ptr [0x53c4] (0170_4A4F / 0x614F)
    ES = UInt16[DS, 0x53C4];
    CheckExternalEvents(cs2, 0x4A58);
    // MOV BX,word ptr ES:[0xe48a] (0170_4A53 / 0x6153)
    BX = UInt16[ES, 0xE48A];
    CheckExternalEvents(cs2, 0x4A5C);
    // MOV ES,word ptr [0x53c6] (0170_4A58 / 0x6158)
    ES = UInt16[DS, 0x53C6];
    CheckExternalEvents(cs2, 0x4A62);
    // CMP byte ptr ES:[BX + 0x42c3],0x0 (0170_4A5C / 0x615C)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0x42C3)], 0x0);
    CheckExternalEvents(cs2, 0x4A64);
    // JNZ 0x0000:614b (0170_4A62 / 0x6162)
    if(!ZeroFlag) {
      goto label_0170_4A4B_0614B;
    }
    CheckExternalEvents(cs2, 0x4A67);
    // MOV AX,word ptr [BP + -0x2] (0170_4A64 / 0x6164)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4A6A);
    // DEC word ptr [BP + -0x2] (0170_4A67 / 0x6167)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Dec16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x4A6C);
    // OR AX,AX (0170_4A6A / 0x616A)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x4A6E);
    // JNZ 0x0000:60fa (0170_4A6C / 0x616C)
    if(!ZeroFlag) {
      goto label_0170_49FA_060FA;
    }
    CheckExternalEvents(cs2, 0x4A72);
    // CMP word ptr [BP + 0x8],0x0 (0170_4A6E / 0x616E)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs2, 0x4A74);
    // JNZ 0x0000:61a2 (0170_4A72 / 0x6172)
    if(!ZeroFlag) {
      goto label_0170_4AA2_061A2;
    }
    CheckExternalEvents(cs2, 0x4A78);
    // CMP word ptr [BP + 0x6],0x0 (0170_4A74 / 0x6174)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs2, 0x4A7A);
    // JNZ 0x0000:6185 (0170_4A78 / 0x6178)
    if(!ZeroFlag) {
      goto label_0170_4A85_06185;
    }
    CheckExternalEvents(cs2, 0x4A7D);
    // MOV AX,0xc (0170_4A7A / 0x617A)
    AX = 0xC;
    CheckExternalEvents(cs2, 0x4A7E);
    // PUSH AX (0170_4A7D / 0x617D)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4A7F);
    // PUSH CS (0170_4A7E / 0x617E)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4A82);
    // CALL 0x0000:30bf (0170_4A7F / 0x617F)
    NearCall(cs2, 0x4A82, ghidra_guess_0000_30BF_030BF);
    CheckExternalEvents(cs2, 0x4A85);
    // ADD SP,0x2 (0170_4A82 / 0x6182)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0170_4A85_06185:
    CheckExternalEvents(cs2, 0x4A88);
    // MOV AX,0x3c (0170_4A85 / 0x6185)
    AX = 0x3C;
    CheckExternalEvents(cs2, 0x4A89);
    // PUSH AX (0170_4A88 / 0x6188)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4A8E);
    // CALLF 0x1000:8ad6 (0170_4A89 / 0x6189)
    FarCall(cs2, 0x4A8E, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs2, 0x4A91);
    // ADD SP,0x2 (0170_4A8E / 0x618E)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4A94);
    // MOV AX,0x4 (0170_4A91 / 0x6191)
    AX = 0x4;
    CheckExternalEvents(cs2, 0x4A95);
    // PUSH AX (0170_4A94 / 0x6194)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4A9A);
    // CALLF 0x1000:7ee1 (0170_4A95 / 0x6195)
    FarCall(cs2, 0x4A9A, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs2, 0x4A9D);
    // ADD SP,0x2 (0170_4A9A / 0x619A)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4AA2);
    // CALLF 0x1000:7fe8 (0170_4A9D / 0x619D)
    FarCall(cs2, 0x4AA2, unknown_17C6_0388_17FE8);
    label_0170_4AA2_061A2:
    CheckExternalEvents(cs2, 0x4AA4);
    // MOV SP,BP (0170_4AA2 / 0x61A2)
    SP = BP;
    CheckExternalEvents(cs2, 0x4AA5);
    // POP BP (0170_4AA4 / 0x61A4)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x4AA6);
    // RETF  (0170_4AA5 / 0x61A5)
    return FarRet();
  }
  
  public virtual Action unknown_0170_4AA6_061A6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_4AA6_061A6:
    CheckExternalEvents(cs2, 0x4AA7);
    // PUSH BP (0170_4AA6 / 0x61A6)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x4AA9);
    // MOV BP,SP (0170_4AA7 / 0x61A7)
    BP = SP;
    CheckExternalEvents(cs2, 0x4AAC);
    // MOV AX,0xa (0170_4AA9 / 0x61A9)
    AX = 0xA;
    CheckExternalEvents(cs2, 0x4AB1);
    // CALLF 0x1000:cecc (0170_4AAC / 0x61AC)
    FarCall(cs2, 0x4AB1, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x4AB3);
    // SUB AX,AX (0170_4AB1 / 0x61B1)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x4AB4);
    // PUSH AX (0170_4AB3 / 0x61B3)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4AB7);
    // MOV AX,0xf (0170_4AB4 / 0x61B4)
    AX = 0xF;
    CheckExternalEvents(cs2, 0x4AB8);
    // PUSH AX (0170_4AB7 / 0x61B7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4ABB);
    // PUSH word ptr [BP + 0x8] (0170_4AB8 / 0x61B8)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs2, 0x4ABE);
    // MOV AX,0x1 (0170_4ABB / 0x61BB)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x4ABF);
    // PUSH AX (0170_4ABE / 0x61BE)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4AC2);
    // MOV AX,0x11 (0170_4ABF / 0x61BF)
    AX = 0x11;
    CheckExternalEvents(cs2, 0x4AC5);
    // IMUL word ptr [BP + 0x6] (0170_4AC2 / 0x61C2)
    int resImul0170_4AC2 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0170_4AC2);
    DX = (ushort)(resImul0170_4AC2 >> 16);
    CheckExternalEvents(cs2, 0x4AC7);
    // MOV BX,AX (0170_4AC5 / 0x61C5)
    BX = AX;
    CheckExternalEvents(cs2, 0x4ACB);
    // MOV ES,word ptr [0x538a] (0170_4AC7 / 0x61C7)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4AD0);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0170_4ACB / 0x61CB)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs2, 0x4AD1);
    // CBW  (0170_4AD0 / 0x61D0)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x4AD3);
    // MOV BX,AX (0170_4AD1 / 0x61D1)
    BX = AX;
    CheckExternalEvents(cs2, 0x4AD5);
    // SHL BX,0x1 (0170_4AD3 / 0x61D3)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x4AD7);
    // SHL BX,0x1 (0170_4AD5 / 0x61D5)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x4ADB);
    // PUSH word ptr [BX + 0x1cc] (0170_4AD7 / 0x61D7)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs2, 0x4ADF);
    // PUSH word ptr [BX + 0x1ca] (0170_4ADB / 0x61DB)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs2, 0x4AE4);
    // CALLF 0x1000:8ba5 (0170_4ADF / 0x61DF)
    FarCall(cs2, 0x4AE4, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs2, 0x4AE7);
    // ADD SP,0xc (0170_4AE4 / 0x61E4)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs2, 0x4AE9);
    // MOV CL,0x3 (0170_4AE7 / 0x61E7)
    CL = 0x3;
    CheckExternalEvents(cs2, 0x4AEC);
    // SHL word ptr [BP + 0x8],CL (0170_4AE9 / 0x61E9)
    // UInt16[SS, (ushort)(BP + 0x8)] <<= CL;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu.Shl16(UInt16[SS, (ushort)(BP + 0x8)], CL);
    CheckExternalEvents(cs2, 0x4AEF);
    // MOV AX,0x11 (0170_4AEC / 0x61EC)
    AX = 0x11;
    CheckExternalEvents(cs2, 0x4AF2);
    // IMUL word ptr [BP + 0x6] (0170_4AEF / 0x61EF)
    int resImul0170_4AEF = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0170_4AEF);
    DX = (ushort)(resImul0170_4AEF >> 16);
    CheckExternalEvents(cs2, 0x4AF4);
    // MOV BX,AX (0170_4AF2 / 0x61F2)
    BX = AX;
    CheckExternalEvents(cs2, 0x4AF8);
    // MOV ES,word ptr [0x538a] (0170_4AF4 / 0x61F4)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4AFD);
    // MOV AL,byte ptr ES:[BX + 0xc615] (0170_4AF8 / 0x61F8)
    AL = UInt8[ES, (ushort)(BX + 0xC615)];
    CheckExternalEvents(cs2, 0x4AFE);
    // CBW  (0170_4AFD / 0x61FD)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x4B01);
    // MOV word ptr [BP + -0x8],AX (0170_4AFE / 0x61FE)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x4B04);
    // PUSH word ptr [BP + 0x8] (0170_4B01 / 0x6201)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs2, 0x4B07);
    // MOV AX,0x9 (0170_4B04 / 0x6204)
    AX = 0x9;
    CheckExternalEvents(cs2, 0x4B08);
    // PUSH AX (0170_4B07 / 0x6207)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4B0B);
    // PUSH word ptr [BP + -0x8] (0170_4B08 / 0x6208)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs2, 0x4B0C);
    // PUSH CS (0170_4B0B / 0x620B)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4B0F);
    // CALL 0x0000:62c1 (0170_4B0C / 0x620C)
    NearCall(cs2, 0x4B0F, unknown_0170_4BC1_062C1);
    CheckExternalEvents(cs2, 0x4B12);
    // ADD SP,0x6 (0170_4B0F / 0x620F)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    CheckExternalEvents(cs2, 0x4B15);
    // MOV AX,0x11 (0170_4B12 / 0x6212)
    AX = 0x11;
    CheckExternalEvents(cs2, 0x4B18);
    // IMUL word ptr [BP + 0x6] (0170_4B15 / 0x6215)
    int resImul0170_4B15 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0170_4B15);
    DX = (ushort)(resImul0170_4B15 >> 16);
    CheckExternalEvents(cs2, 0x4B1A);
    // MOV BX,AX (0170_4B18 / 0x6218)
    BX = AX;
    CheckExternalEvents(cs2, 0x4B1E);
    // MOV ES,word ptr [0x538a] (0170_4B1A / 0x621A)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4B23);
    // MOV AL,byte ptr ES:[BX + 0xc623] (0170_4B1E / 0x621E)
    AL = UInt8[ES, (ushort)(BX + 0xC623)];
    CheckExternalEvents(cs2, 0x4B24);
    // CBW  (0170_4B23 / 0x6223)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x4B26);
    // MOV CL,0xa (0170_4B24 / 0x6224)
    CL = 0xA;
    CheckExternalEvents(cs2, 0x4B28);
    // IDIV CL (0170_4B26 / 0x6226)
    short op1IDiv0170_4B26 = (short)AX;
    sbyte op2IDiv0170_4B26 = (sbyte)CL;
    sbyte? resIDiv0170_4B26 = Alu.IDiv8(op1IDiv0170_4B26, op2IDiv0170_4B26);
    if(resIDiv0170_4B26 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AL = (byte)resIDiv0170_4B26.Value;
    AH = (byte)(op1IDiv0170_4B26 % op2IDiv0170_4B26);
    CheckExternalEvents(cs2, 0x4B29);
    // CBW  (0170_4B28 / 0x6228)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x4B2C);
    // MOV word ptr [BP + -0x2],AX (0170_4B29 / 0x6229)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x4B2E);
    // OR AX,AX (0170_4B2C / 0x622C)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x4B30);
    // JNZ 0x0000:6235 (0170_4B2E / 0x622E)
    if(!ZeroFlag) {
      goto label_0170_4B35_06235;
    }
    CheckExternalEvents(cs2, 0x4B35);
    // MOV word ptr [BP + -0x2],0x1 (0170_4B30 / 0x6230)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_0170_4B35_06235:
    CheckExternalEvents(cs2, 0x4B38);
    // MOV AX,word ptr [BP + -0x8] (0170_4B35 / 0x6235)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x4B3B);
    // SUB AX,word ptr [BP + -0x2] (0170_4B38 / 0x6238)
    // AX -= UInt16[SS, (ushort)(BP - 0x2)];
    AX = Alu.Sub16(AX, UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x4B3E);
    // MOV word ptr [BP + -0x2],AX (0170_4B3B / 0x623B)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x4B40);
    // OR AX,AX (0170_4B3E / 0x623E)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x4B42);
    // JZ 0x0000:627e (0170_4B40 / 0x6240)
    if(ZeroFlag) {
      goto label_0170_4B7E_0627E;
    }
    CheckExternalEvents(cs2, 0x4B47);
    // MOV word ptr [BP + -0xa],0x4 (0170_4B42 / 0x6242)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x4;
    CheckExternalEvents(cs2, 0x4B4B);
    // MOV ES,word ptr [0x53a0] (0170_4B47 / 0x6247)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x4B51);
    // CMP word ptr ES:[0x4fba],0x0 (0170_4B4B / 0x624B)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0x4B53);
    // JNZ 0x0000:6258 (0170_4B51 / 0x6251)
    if(!ZeroFlag) {
      goto label_0170_4B58_06258;
    }
    CheckExternalEvents(cs2, 0x4B58);
    // MOV word ptr [BP + -0xa],0x2 (0170_4B53 / 0x6253)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x2;
    label_0170_4B58_06258:
    CheckExternalEvents(cs2, 0x4B5B);
    // MOV AX,word ptr [BP + 0x8] (0170_4B58 / 0x6258)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs2, 0x4B5E);
    // SUB AX,word ptr [BP + -0x8] (0170_4B5B / 0x625B)
    AX -= UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x4B61);
    // ADD AX,0xe (0170_4B5E / 0x625E)
    // AX += 0xE;
    AX = Alu.Add16(AX, 0xE);
    CheckExternalEvents(cs2, 0x4B64);
    // MOV word ptr [BP + -0x6],AX (0170_4B61 / 0x6261)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs2, 0x4B67);
    // PUSH word ptr [BP + -0xa] (0170_4B64 / 0x6264)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs2, 0x4B6A);
    // ADD AX,word ptr [BP + -0x2] (0170_4B67 / 0x6267)
    // AX += UInt16[SS, (ushort)(BP - 0x2)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x4B6B);
    // PUSH AX (0170_4B6A / 0x626A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4B6E);
    // MOV AX,0x4c (0170_4B6B / 0x626B)
    AX = 0x4C;
    CheckExternalEvents(cs2, 0x4B6F);
    // PUSH AX (0170_4B6E / 0x626E)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4B72);
    // PUSH word ptr [BP + -0x6] (0170_4B6F / 0x626F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x4B75);
    // MOV AX,0x4a (0170_4B72 / 0x6272)
    AX = 0x4A;
    CheckExternalEvents(cs2, 0x4B76);
    // PUSH AX (0170_4B75 / 0x6275)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4B7B);
    // CALLF 0x1000:8ccb (0170_4B76 / 0x6276)
    FarCall(cs2, 0x4B7B, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs2, 0x4B7E);
    // ADD SP,0xa (0170_4B7B / 0x627B)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    label_0170_4B7E_0627E:
    CheckExternalEvents(cs2, 0x4B81);
    // PUSH word ptr [BP + 0x8] (0170_4B7E / 0x627E)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs2, 0x4B84);
    // MOV AX,0xa (0170_4B81 / 0x6281)
    AX = 0xA;
    CheckExternalEvents(cs2, 0x4B85);
    // PUSH AX (0170_4B84 / 0x6284)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4B88);
    // MOV AX,0x11 (0170_4B85 / 0x6285)
    AX = 0x11;
    CheckExternalEvents(cs2, 0x4B8B);
    // IMUL word ptr [BP + 0x6] (0170_4B88 / 0x6288)
    int resImul0170_4B88 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0170_4B88);
    DX = (ushort)(resImul0170_4B88 >> 16);
    CheckExternalEvents(cs2, 0x4B8D);
    // MOV BX,AX (0170_4B8B / 0x628B)
    BX = AX;
    CheckExternalEvents(cs2, 0x4B91);
    // MOV ES,word ptr [0x538a] (0170_4B8D / 0x628D)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4B96);
    // MOV AL,byte ptr ES:[BX + 0xc616] (0170_4B91 / 0x6291)
    AL = UInt8[ES, (ushort)(BX + 0xC616)];
    CheckExternalEvents(cs2, 0x4B97);
    // CBW  (0170_4B96 / 0x6296)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x4B98);
    // PUSH AX (0170_4B97 / 0x6297)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4B99);
    // PUSH CS (0170_4B98 / 0x6298)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4B9C);
    // CALL 0x0000:62c1 (0170_4B99 / 0x6299)
    NearCall(cs2, 0x4B9C, unknown_0170_4BC1_062C1);
    CheckExternalEvents(cs2, 0x4B9F);
    // ADD SP,0x6 (0170_4B9C / 0x629C)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    CheckExternalEvents(cs2, 0x4BA2);
    // PUSH word ptr [BP + 0x8] (0170_4B9F / 0x629F)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs2, 0x4BA5);
    // MOV AX,0xb (0170_4BA2 / 0x62A2)
    AX = 0xB;
    CheckExternalEvents(cs2, 0x4BA6);
    // PUSH AX (0170_4BA5 / 0x62A5)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4BA9);
    // MOV AX,0x11 (0170_4BA6 / 0x62A6)
    AX = 0x11;
    CheckExternalEvents(cs2, 0x4BAC);
    // IMUL word ptr [BP + 0x6] (0170_4BA9 / 0x62A9)
    int resImul0170_4BA9 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0170_4BA9);
    DX = (ushort)(resImul0170_4BA9 >> 16);
    CheckExternalEvents(cs2, 0x4BAE);
    // MOV BX,AX (0170_4BAC / 0x62AC)
    BX = AX;
    CheckExternalEvents(cs2, 0x4BB2);
    // MOV ES,word ptr [0x538a] (0170_4BAE / 0x62AE)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4BB7);
    // MOV AL,byte ptr ES:[BX + 0xc617] (0170_4BB2 / 0x62B2)
    AL = UInt8[ES, (ushort)(BX + 0xC617)];
    CheckExternalEvents(cs2, 0x4BB8);
    // CBW  (0170_4BB7 / 0x62B7)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x4BB9);
    // PUSH AX (0170_4BB8 / 0x62B8)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4BBA);
    // PUSH CS (0170_4BB9 / 0x62B9)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4BBD);
    // CALL 0x0000:62c1 (0170_4BBA / 0x62BA)
    NearCall(cs2, 0x4BBD, unknown_0170_4BC1_062C1);
    CheckExternalEvents(cs2, 0x4BBF);
    // MOV SP,BP (0170_4BBD / 0x62BD)
    SP = BP;
    CheckExternalEvents(cs2, 0x4BC0);
    // POP BP (0170_4BBF / 0x62BF)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x4BC1);
    // RETF  (0170_4BC0 / 0x62C0)
    return FarRet();
  }
  
  public virtual Action unknown_0170_4BC1_062C1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_4BC1_062C1:
    CheckExternalEvents(cs2, 0x4BC2);
    // PUSH BP (0170_4BC1 / 0x62C1)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x4BC4);
    // MOV BP,SP (0170_4BC2 / 0x62C2)
    BP = SP;
    CheckExternalEvents(cs2, 0x4BC7);
    // MOV AX,0x2 (0170_4BC4 / 0x62C4)
    AX = 0x2;
    CheckExternalEvents(cs2, 0x4BCC);
    // CALLF 0x1000:cecc (0170_4BC7 / 0x62C7)
    FarCall(cs2, 0x4BCC, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x4BCD);
    // PUSH SI (0170_4BCC / 0x62CC)
    Stack.Push16(SI);
    CheckExternalEvents(cs2, 0x4BCF);
    // MOV CL,0x3 (0170_4BCD / 0x62CD)
    CL = 0x3;
    CheckExternalEvents(cs2, 0x4BD2);
    // SHL word ptr [BP + 0x8],CL (0170_4BCF / 0x62CF)
    // UInt16[SS, (ushort)(BP + 0x8)] <<= CL;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu.Shl16(UInt16[SS, (ushort)(BP + 0x8)], CL);
    CheckExternalEvents(cs2, 0x4BD5);
    // MOV AX,0xc (0170_4BD2 / 0x62D2)
    AX = 0xC;
    CheckExternalEvents(cs2, 0x4BD8);
    // SUB AX,word ptr [BP + 0x6] (0170_4BD5 / 0x62D5)
    // AX -= UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs2, 0x4BDB);
    // MOV word ptr [BP + 0x6],AX (0170_4BD8 / 0x62D8)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs2, 0x4BE0);
    // MOV word ptr [BP + -0x2],0xe (0170_4BDB / 0x62DB)
    UInt16[SS, (ushort)(BP - 0x2)] = 0xE;
    CheckExternalEvents(cs2, 0x4BE4);
    // MOV ES,word ptr [0x53a0] (0170_4BE0 / 0x62E0)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x4BEA);
    // CMP word ptr ES:[0x4fba],0x0 (0170_4BE4 / 0x62E4)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0x4BEC);
    // JNZ 0x0000:62f1 (0170_4BEA / 0x62EA)
    if(!ZeroFlag) {
      goto label_0170_4BF1_062F1;
    }
    CheckExternalEvents(cs2, 0x4BF1);
    // MOV word ptr [BP + -0x2],0x3 (0170_4BEC / 0x62EC)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x3;
    label_0170_4BF1_062F1:
    CheckExternalEvents(cs2, 0x4BF4);
    // PUSH word ptr [BP + -0x2] (0170_4BF1 / 0x62F1)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x4BF7);
    // PUSH word ptr [BP + 0xa] (0170_4BF4 / 0x62F4)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs2, 0x4BFA);
    // MOV AX,word ptr [BP + 0x8] (0170_4BF7 / 0x62F7)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs2, 0x4BFD);
    // ADD AX,0x5 (0170_4BFA / 0x62FA)
    // AX += 0x5;
    AX = Alu.Add16(AX, 0x5);
    CheckExternalEvents(cs2, 0x4BFE);
    // PUSH AX (0170_4BFD / 0x62FD)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4C01);
    // PUSH word ptr [BP + 0xa] (0170_4BFE / 0x62FE)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs2, 0x4C04);
    // MOV AX,word ptr [BP + 0x8] (0170_4C01 / 0x6301)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs2, 0x4C05);
    // INC AX (0170_4C04 / 0x6304)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs2, 0x4C06);
    // PUSH AX (0170_4C05 / 0x6305)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4C0B);
    // CALLF 0x1000:8dec (0170_4C06 / 0x6306)
    FarCall(cs2, 0x4C0B, unknown_18AD_031C_18DEC);
    CheckExternalEvents(cs2, 0x4C0E);
    // ADD SP,0xa (0170_4C0B / 0x630B)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs2, 0x4C11);
    // PUSH word ptr [BP + -0x2] (0170_4C0E / 0x630E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x4C14);
    // MOV AX,word ptr [BP + 0xa] (0170_4C11 / 0x6311)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs2, 0x4C17);
    // ADD AX,0xd (0170_4C14 / 0x6314)
    // AX += 0xD;
    AX = Alu.Add16(AX, 0xD);
    CheckExternalEvents(cs2, 0x4C18);
    // PUSH AX (0170_4C17 / 0x6317)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4C1B);
    // PUSH word ptr [BP + 0x8] (0170_4C18 / 0x6318)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs2, 0x4C1E);
    // MOV AX,word ptr [BP + 0xa] (0170_4C1B / 0x631B)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs2, 0x4C1F);
    // INC AX (0170_4C1E / 0x631E)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs2, 0x4C20);
    // PUSH AX (0170_4C1F / 0x631F)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4C23);
    // PUSH word ptr [BP + 0x8] (0170_4C20 / 0x6320)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs2, 0x4C28);
    // CALLF 0x1000:8dec (0170_4C23 / 0x6323)
    FarCall(cs2, 0x4C28, unknown_18AD_031C_18DEC);
    CheckExternalEvents(cs2, 0x4C2B);
    // ADD SP,0xa (0170_4C28 / 0x6328)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs2, 0x4C2E);
    // MOV SI,word ptr [BP + 0x8] (0170_4C2B / 0x632B)
    SI = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs2, 0x4C31);
    // ADD SI,0x6 (0170_4C2E / 0x632E)
    // SI += 0x6;
    SI = Alu.Add16(SI, 0x6);
    CheckExternalEvents(cs2, 0x4C34);
    // PUSH word ptr [BP + -0x2] (0170_4C31 / 0x6331)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x4C37);
    // MOV AX,word ptr [BP + 0xa] (0170_4C34 / 0x6334)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs2, 0x4C3A);
    // ADD AX,0xd (0170_4C37 / 0x6337)
    // AX += 0xD;
    AX = Alu.Add16(AX, 0xD);
    CheckExternalEvents(cs2, 0x4C3B);
    // PUSH AX (0170_4C3A / 0x633A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4C3C);
    // PUSH SI (0170_4C3B / 0x633B)
    Stack.Push16(SI);
    CheckExternalEvents(cs2, 0x4C3F);
    // MOV AX,word ptr [BP + 0xa] (0170_4C3C / 0x633C)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs2, 0x4C40);
    // INC AX (0170_4C3F / 0x633F)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs2, 0x4C41);
    // PUSH AX (0170_4C40 / 0x6340)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4C42);
    // PUSH SI (0170_4C41 / 0x6341)
    Stack.Push16(SI);
    CheckExternalEvents(cs2, 0x4C47);
    // CALLF 0x1000:8dec (0170_4C42 / 0x6342)
    FarCall(cs2, 0x4C47, unknown_18AD_031C_18DEC);
    CheckExternalEvents(cs2, 0x4C4A);
    // ADD SP,0xa (0170_4C47 / 0x6347)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs2, 0x4C4D);
    // MOV SI,word ptr [BP + 0xa] (0170_4C4A / 0x634A)
    SI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs2, 0x4C50);
    // ADD SI,0xe (0170_4C4D / 0x634D)
    // SI += 0xE;
    SI = Alu.Add16(SI, 0xE);
    CheckExternalEvents(cs2, 0x4C53);
    // PUSH word ptr [BP + -0x2] (0170_4C50 / 0x6350)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x4C54);
    // PUSH SI (0170_4C53 / 0x6353)
    Stack.Push16(SI);
    CheckExternalEvents(cs2, 0x4C57);
    // MOV AX,word ptr [BP + 0x8] (0170_4C54 / 0x6354)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs2, 0x4C5A);
    // ADD AX,0x5 (0170_4C57 / 0x6357)
    // AX += 0x5;
    AX = Alu.Add16(AX, 0x5);
    CheckExternalEvents(cs2, 0x4C5B);
    // PUSH AX (0170_4C5A / 0x635A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4C5C);
    // PUSH SI (0170_4C5B / 0x635B)
    Stack.Push16(SI);
    CheckExternalEvents(cs2, 0x4C5F);
    // MOV AX,word ptr [BP + 0x8] (0170_4C5C / 0x635C)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs2, 0x4C60);
    // INC AX (0170_4C5F / 0x635F)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs2, 0x4C61);
    // PUSH AX (0170_4C60 / 0x6360)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4C66);
    // CALLF 0x1000:8dec (0170_4C61 / 0x6361)
    FarCall(cs2, 0x4C66, unknown_18AD_031C_18DEC);
    CheckExternalEvents(cs2, 0x4C69);
    // ADD SP,0xa (0170_4C66 / 0x6366)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs2, 0x4C6E);
    // MOV word ptr [BP + -0x2],0xa (0170_4C69 / 0x6369)
    UInt16[SS, (ushort)(BP - 0x2)] = 0xA;
    CheckExternalEvents(cs2, 0x4C72);
    // MOV ES,word ptr [0x53a0] (0170_4C6E / 0x636E)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x4C78);
    // CMP word ptr ES:[0x4fba],0x0 (0170_4C72 / 0x6372)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0x4C7A);
    // JNZ 0x0000:637f (0170_4C78 / 0x6378)
    if(!ZeroFlag) {
      goto label_0170_4C7F_0637F;
    }
    CheckExternalEvents(cs2, 0x4C7F);
    // MOV word ptr [BP + -0x2],0x1 (0170_4C7A / 0x637A)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_0170_4C7F_0637F:
    CheckExternalEvents(cs2, 0x4C82);
    // PUSH word ptr [BP + -0x2] (0170_4C7F / 0x637F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x4C85);
    // MOV AX,word ptr [BP + 0xa] (0170_4C82 / 0x6382)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs2, 0x4C88);
    // ADD AX,0xd (0170_4C85 / 0x6385)
    // AX += 0xD;
    AX = Alu.Add16(AX, 0xD);
    CheckExternalEvents(cs2, 0x4C89);
    // PUSH AX (0170_4C88 / 0x6388)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4C8C);
    // MOV AX,word ptr [BP + 0x8] (0170_4C89 / 0x6389)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs2, 0x4C8F);
    // ADD AX,0x4 (0170_4C8C / 0x638C)
    // AX += 0x4;
    AX = Alu.Add16(AX, 0x4);
    CheckExternalEvents(cs2, 0x4C90);
    // PUSH AX (0170_4C8F / 0x638F)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4C93);
    // MOV AX,word ptr [BP + 0xa] (0170_4C90 / 0x6390)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs2, 0x4C96);
    // ADD AX,word ptr [BP + 0x6] (0170_4C93 / 0x6393)
    AX += UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x4C97);
    // INC AX (0170_4C96 / 0x6396)
    AX++;
    CheckExternalEvents(cs2, 0x4C98);
    // INC AX (0170_4C97 / 0x6397)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs2, 0x4C99);
    // PUSH AX (0170_4C98 / 0x6398)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4C9C);
    // MOV AX,word ptr [BP + 0x8] (0170_4C99 / 0x6399)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs2, 0x4C9D);
    // INC AX (0170_4C9C / 0x639C)
    AX++;
    CheckExternalEvents(cs2, 0x4C9E);
    // INC AX (0170_4C9D / 0x639D)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs2, 0x4C9F);
    // PUSH AX (0170_4C9E / 0x639E)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4CA4);
    // CALLF 0x1000:8ccb (0170_4C9F / 0x639F)
    FarCall(cs2, 0x4CA4, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs2, 0x4CA7);
    // ADD SP,0xa (0170_4CA4 / 0x63A4)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs2, 0x4CA8);
    // POP SI (0170_4CA7 / 0x63A7)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x4CAA);
    // MOV SP,BP (0170_4CA8 / 0x63A8)
    SP = BP;
    CheckExternalEvents(cs2, 0x4CAB);
    // POP BP (0170_4CAA / 0x63AA)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x4CAC);
    // RETF  (0170_4CAB / 0x63AB)
    return FarRet();
  }
  
  public virtual Action unknown_0170_4CAC_063AC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_4CAC_063AC:
    CheckExternalEvents(cs2, 0x4CAD);
    // PUSH BP (0170_4CAC / 0x63AC)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x4CAF);
    // MOV BP,SP (0170_4CAD / 0x63AD)
    BP = SP;
    CheckExternalEvents(cs2, 0x4CB2);
    // MOV AX,0x4 (0170_4CAF / 0x63AF)
    AX = 0x4;
    CheckExternalEvents(cs2, 0x4CB7);
    // CALLF 0x1000:cecc (0170_4CB2 / 0x63B2)
    FarCall(cs2, 0x4CB7, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x4CBA);
    // MOV AX,0x3 (0170_4CB7 / 0x63B7)
    AX = 0x3;
    CheckExternalEvents(cs2, 0x4CBB);
    // PUSH AX (0170_4CBA / 0x63BA)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4CC0);
    // CALLF 0x1000:7ee1 (0170_4CBB / 0x63BB)
    FarCall(cs2, 0x4CC0, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs2, 0x4CC3);
    // ADD SP,0x2 (0170_4CC0 / 0x63C0)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4CC6);
    // MOV AX,0x3 (0170_4CC3 / 0x63C3)
    AX = 0x3;
    CheckExternalEvents(cs2, 0x4CC7);
    // PUSH AX (0170_4CC6 / 0x63C6)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4CCC);
    // CALLF 0x1000:7c64 (0170_4CC7 / 0x63C7)
    FarCall(cs2, 0x4CCC, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs2, 0x4CCF);
    // ADD SP,0x2 (0170_4CCC / 0x63CC)
    SP += 0x2;
    CheckExternalEvents(cs2, 0x4CD3);
    // CMP word ptr [BP + 0x6],0x0 (0170_4CCF / 0x63CF)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs2, 0x4CD5);
    // JZ 0x0000:63da (0170_4CD3 / 0x63D3)
    if(ZeroFlag) {
      goto label_0170_4CDA_063DA;
    }
    CheckExternalEvents(cs2, 0x4CDA);
    // CALLF 0x1000:7fe8 (0170_4CD5 / 0x63D5)
    FarCall(cs2, 0x4CDA, unknown_17C6_0388_17FE8);
    label_0170_4CDA_063DA:
    CheckExternalEvents(cs2, 0x4CDC);
    // SUB AX,AX (0170_4CDA / 0x63DA)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x4CDD);
    // PUSH AX (0170_4CDC / 0x63DC)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4CE0);
    // MOV AX,0xf (0170_4CDD / 0x63DD)
    AX = 0xF;
    CheckExternalEvents(cs2, 0x4CE1);
    // PUSH AX (0170_4CE0 / 0x63E0)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4CE4);
    // MOV AX,0xd (0170_4CE1 / 0x63E1)
    AX = 0xD;
    CheckExternalEvents(cs2, 0x4CE5);
    // PUSH AX (0170_4CE4 / 0x63E4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4CE8);
    // MOV AX,0x9 (0170_4CE5 / 0x63E5)
    AX = 0x9;
    CheckExternalEvents(cs2, 0x4CE9);
    // PUSH AX (0170_4CE8 / 0x63E8)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4CEC);
    // MOV AX,0xaca (0170_4CE9 / 0x63E9)
    AX = 0xACA;
    CheckExternalEvents(cs2, 0x4CED);
    // PUSH DS (0170_4CEC / 0x63EC)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x4CEE);
    // PUSH AX (0170_4CED / 0x63ED)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4CF3);
    // CALLF 0x1000:8ba5 (0170_4CEE / 0x63EE)
    FarCall(cs2, 0x4CF3, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs2, 0x4CF6);
    // ADD SP,0xc (0170_4CF3 / 0x63F3)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs2, 0x4CFB);
    // MOV word ptr [BP + -0x2],0x0 (0170_4CF6 / 0x63F6)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs2, 0x4D00);
    // MOV word ptr [BP + -0x4],0x0 (0170_4CFB / 0x63FB)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0170_4D00_06400:
    CheckExternalEvents(cs2, 0x4D04);
    // CMP word ptr [BP + -0x2],0x4 (0170_4D00 / 0x6400)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs2, 0x4D06);
    // JGE 0x0000:6430 (0170_4D04 / 0x6404)
    if(SignFlag == OverflowFlag) {
      goto label_0170_4D30_06430;
    }
    CheckExternalEvents(cs2, 0x4D09);
    // MOV AX,0x11 (0170_4D06 / 0x6406)
    AX = 0x11;
    CheckExternalEvents(cs2, 0x4D0C);
    // IMUL word ptr [BP + -0x4] (0170_4D09 / 0x6409)
    int resImul0170_4D09 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0170_4D09);
    DX = (ushort)(resImul0170_4D09 >> 16);
    CheckExternalEvents(cs2, 0x4D0E);
    // MOV BX,AX (0170_4D0C / 0x640C)
    BX = AX;
    CheckExternalEvents(cs2, 0x4D12);
    // MOV ES,word ptr [0x538a] (0170_4D0E / 0x640E)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4D18);
    // CMP byte ptr ES:[BX + 0xc614],0xff (0170_4D12 / 0x6412)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC614)], 0xFF);
    CheckExternalEvents(cs2, 0x4D1A);
    // JZ 0x0000:6430 (0170_4D18 / 0x6418)
    if(ZeroFlag) {
      goto label_0170_4D30_06430;
    }
    CheckExternalEvents(cs2, 0x4D1D);
    // MOV AX,word ptr [BP + -0x2] (0170_4D1A / 0x641A)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4D1F);
    // SHL AX,0x1 (0170_4D1D / 0x641D)
    AX <<= 0x1;
    CheckExternalEvents(cs2, 0x4D22);
    // ADD AX,0xe (0170_4D1F / 0x641F)
    // AX += 0xE;
    AX = Alu.Add16(AX, 0xE);
    CheckExternalEvents(cs2, 0x4D23);
    // PUSH AX (0170_4D22 / 0x6422)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4D26);
    // PUSH word ptr [BP + -0x4] (0170_4D23 / 0x6423)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x4D27);
    // PUSH CS (0170_4D26 / 0x6426)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4D2A);
    // CALL 0x0000:61a6 (0170_4D27 / 0x6427)
    NearCall(cs2, 0x4D2A, unknown_0170_4AA6_061A6);
    CheckExternalEvents(cs2, 0x4D2D);
    // ADD SP,0x4 (0170_4D2A / 0x642A)
    SP += 0x4;
    CheckExternalEvents(cs2, 0x4D30);
    // INC word ptr [BP + -0x2] (0170_4D2D / 0x642D)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    label_0170_4D30_06430:
    CheckExternalEvents(cs2, 0x4D33);
    // INC word ptr [BP + -0x4] (0170_4D30 / 0x6430)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs2, 0x4D37);
    // CMP word ptr [BP + -0x4],0x8 (0170_4D33 / 0x6433)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x8);
    CheckExternalEvents(cs2, 0x4D39);
    // JL 0x0000:6400 (0170_4D37 / 0x6437)
    if(SignFlag != OverflowFlag) {
      goto label_0170_4D00_06400;
    }
    CheckExternalEvents(cs2, 0x4D3E);
    // CALLF 0x1000:19ef (0170_4D39 / 0x6439)
    FarCall(cs2, 0x4D3E, unknown_0FA1_1FDF_119EF);
    CheckExternalEvents(cs2, 0x4D41);
    // MOV AX,0x4 (0170_4D3E / 0x643E)
    AX = 0x4;
    CheckExternalEvents(cs2, 0x4D42);
    // PUSH AX (0170_4D41 / 0x6441)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4D47);
    // CALLF 0x1000:7ee1 (0170_4D42 / 0x6442)
    FarCall(cs2, 0x4D47, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs2, 0x4D4A);
    // ADD SP,0x2 (0170_4D47 / 0x6447)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4D4D);
    // MOV AX,0x4 (0170_4D4A / 0x644A)
    AX = 0x4;
    CheckExternalEvents(cs2, 0x4D4E);
    // PUSH AX (0170_4D4D / 0x644D)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4D53);
    // CALLF 0x1000:7c64 (0170_4D4E / 0x644E)
    FarCall(cs2, 0x4D53, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs2, 0x4D55);
    // MOV SP,BP (0170_4D53 / 0x6453)
    SP = BP;
    CheckExternalEvents(cs2, 0x4D56);
    // POP BP (0170_4D55 / 0x6455)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x4D57);
    // RETF  (0170_4D56 / 0x6456)
    return FarRet();
  }
  
  public virtual Action unknown_0170_4DC7_064C7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_4DC7_064C7:
    CheckExternalEvents(cs2, 0x4DC8);
    // PUSH BP (0170_4DC7 / 0x64C7)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x4DCA);
    // MOV BP,SP (0170_4DC8 / 0x64C8)
    BP = SP;
    CheckExternalEvents(cs2, 0x4DCD);
    // MOV AX,0x6 (0170_4DCA / 0x64CA)
    AX = 0x6;
    CheckExternalEvents(cs2, 0x4DD2);
    // CALLF 0x1000:cecc (0170_4DCD / 0x64CD)
    FarCall(cs2, 0x4DD2, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x4DD6);
    // MOV ES,word ptr [0x538a] (0170_4DD2 / 0x64D2)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4DD8);
    // MOV AL,0xff (0170_4DD6 / 0x64D6)
    AL = 0xFF;
    CheckExternalEvents(cs2, 0x4DDC);
    // MOV ES:[0xd455],AL (0170_4DD8 / 0x64D8)
    UInt8[ES, 0xD455] = AL;
    CheckExternalEvents(cs2, 0x4DE0);
    // MOV ES:[0xd454],AL (0170_4DDC / 0x64DC)
    UInt8[ES, 0xD454] = AL;
    CheckExternalEvents(cs2, 0x4DE4);
    // MOV ES:[0xd453],AL (0170_4DE0 / 0x64E0)
    UInt8[ES, 0xD453] = AL;
    CheckExternalEvents(cs2, 0x4DE8);
    // MOV ES:[0xd452],AL (0170_4DE4 / 0x64E4)
    UInt8[ES, 0xD452] = AL;
    CheckExternalEvents(cs2, 0x4DEC);
    // MOV ES:[0xca8f],AL (0170_4DE8 / 0x64E8)
    UInt8[ES, 0xCA8F] = AL;
    CheckExternalEvents(cs2, 0x4DF0);
    // MOV ES:[0xca12],AL (0170_4DEC / 0x64EC)
    UInt8[ES, 0xCA12] = AL;
    CheckExternalEvents(cs2, 0x4DF4);
    // MOV ES:[0xc995],AL (0170_4DF0 / 0x64F0)
    UInt8[ES, 0xC995] = AL;
    CheckExternalEvents(cs2, 0x4DF8);
    // MOV ES:[0xc918],AL (0170_4DF4 / 0x64F4)
    UInt8[ES, 0xC918] = AL;
    CheckExternalEvents(cs2, 0x4DFC);
    // MOV ES:[0xc89b],AL (0170_4DF8 / 0x64F8)
    UInt8[ES, 0xC89B] = AL;
    CheckExternalEvents(cs2, 0x4E00);
    // MOV ES:[0xc81e],AL (0170_4DFC / 0x64FC)
    UInt8[ES, 0xC81E] = AL;
    CheckExternalEvents(cs2, 0x4E04);
    // MOV ES:[0xc7a1],AL (0170_4E00 / 0x6500)
    UInt8[ES, 0xC7A1] = AL;
    CheckExternalEvents(cs2, 0x4E08);
    // MOV ES:[0xc724],AL (0170_4E04 / 0x6504)
    UInt8[ES, 0xC724] = AL;
    CheckExternalEvents(cs2, 0x4E0D);
    // MOV word ptr [BP + -0x2],0x1 (0170_4E08 / 0x6508)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_0170_4E0D_0650D:
    CheckExternalEvents(cs2, 0x4E10);
    // MOV AX,0x11 (0170_4E0D / 0x650D)
    AX = 0x11;
    CheckExternalEvents(cs2, 0x4E13);
    // IMUL word ptr [BP + -0x2] (0170_4E10 / 0x6510)
    int resImul0170_4E10 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul0170_4E10);
    DX = (ushort)(resImul0170_4E10 >> 16);
    CheckExternalEvents(cs2, 0x4E15);
    // MOV BX,AX (0170_4E13 / 0x6513)
    BX = AX;
    CheckExternalEvents(cs2, 0x4E19);
    // MOV ES,word ptr [0x538a] (0170_4E15 / 0x6515)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4E1F);
    // MOV byte ptr ES:[BX + 0xc614],0xff (0170_4E19 / 0x6519)
    UInt8[ES, (ushort)(BX + 0xC614)] = 0xFF;
    CheckExternalEvents(cs2, 0x4E22);
    // INC word ptr [BP + -0x2] (0170_4E1F / 0x651F)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs2, 0x4E26);
    // CMP word ptr [BP + -0x2],0x8 (0170_4E22 / 0x6522)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x8);
    CheckExternalEvents(cs2, 0x4E28);
    // JL 0x0000:650d (0170_4E26 / 0x6526)
    if(SignFlag != OverflowFlag) {
      goto label_0170_4E0D_0650D;
    }
    CheckExternalEvents(cs2, 0x4E2D);
    // MOV word ptr [BP + -0x2],0x0 (0170_4E28 / 0x6528)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0170_4E2D_0652D:
    CheckExternalEvents(cs2, 0x4E30);
    // MOV BX,word ptr [BP + -0x2] (0170_4E2D / 0x652D)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4E34);
    // MOV ES,word ptr [0x538a] (0170_4E30 / 0x6530)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4E3A);
    // MOV byte ptr ES:[BX + 0xc618],0x0 (0170_4E34 / 0x6534)
    UInt8[ES, (ushort)(BX + 0xC618)] = 0x0;
    CheckExternalEvents(cs2, 0x4E3D);
    // INC word ptr [BP + -0x2] (0170_4E3A / 0x653A)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs2, 0x4E41);
    // CMP word ptr [BP + -0x2],0x6 (0170_4E3D / 0x653D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x6);
    CheckExternalEvents(cs2, 0x4E43);
    // JLE 0x0000:652d (0170_4E41 / 0x6541)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_4E2D_0652D;
    }
    CheckExternalEvents(cs2, 0x4E48);
    // MOV word ptr [BP + -0x2],0x0 (0170_4E43 / 0x6543)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0170_4E48_06548:
    CheckExternalEvents(cs2, 0x4E4B);
    // MOV BX,word ptr [BP + -0x2] (0170_4E48 / 0x6548)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4E4F);
    // MOV ES,word ptr [0x538a] (0170_4E4B / 0x654B)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4E55);
    // MOV byte ptr ES:[BX + 0xd30c],0x0 (0170_4E4F / 0x654F)
    UInt8[ES, (ushort)(BX + 0xD30C)] = 0x0;
    CheckExternalEvents(cs2, 0x4E58);
    // INC word ptr [BP + -0x2] (0170_4E55 / 0x6555)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs2, 0x4E5C);
    // CMP word ptr [BP + -0x2],0x64 (0170_4E58 / 0x6558)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x64);
    CheckExternalEvents(cs2, 0x4E5E);
    // JL 0x0000:6548 (0170_4E5C / 0x655C)
    if(SignFlag != OverflowFlag) {
      goto label_0170_4E48_06548;
    }
    CheckExternalEvents(cs2, 0x4E63);
    // MOV word ptr [BP + -0x2],0x0 (0170_4E5E / 0x655E)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0170_4E63_06563:
    CheckExternalEvents(cs2, 0x4E66);
    // MOV BX,word ptr [BP + -0x2] (0170_4E63 / 0x6563)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4E6A);
    // MOV ES,word ptr [0x53ea] (0170_4E66 / 0x6566)
    ES = UInt16[DS, 0x53EA];
    CheckExternalEvents(cs2, 0x4E70);
    // MOV byte ptr ES:[BX + 0x45de],0x0 (0170_4E6A / 0x656A)
    UInt8[ES, (ushort)(BX + 0x45DE)] = 0x0;
    CheckExternalEvents(cs2, 0x4E73);
    // INC word ptr [BP + -0x2] (0170_4E70 / 0x6570)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs2, 0x4E77);
    // CMP word ptr [BP + -0x2],0x21 (0170_4E73 / 0x6573)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x21);
    CheckExternalEvents(cs2, 0x4E79);
    // JL 0x0000:6563 (0170_4E77 / 0x6577)
    if(SignFlag != OverflowFlag) {
      goto label_0170_4E63_06563;
    }
    CheckExternalEvents(cs2, 0x4E7D);
    // MOV ES,word ptr [0x538a] (0170_4E79 / 0x6579)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4E83);
    // MOV byte ptr ES:[0xc614],0x0 (0170_4E7D / 0x657D)
    UInt8[ES, 0xC614] = 0x0;
    CheckExternalEvents(cs2, 0x4E89);
    // MOV byte ptr ES:[0xc620],0x8 (0170_4E83 / 0x6583)
    UInt8[ES, 0xC620] = 0x8;
    CheckExternalEvents(cs2, 0x4E90);
    // MOV word ptr ES:[0xd370],0x14 (0170_4E89 / 0x6589)
    UInt16[ES, 0xD370] = 0x14;
    CheckExternalEvents(cs2, 0x4E97);
    // MOV word ptr ES:[0xd372],0x0 (0170_4E90 / 0x6590)
    UInt16[ES, 0xD372] = 0x0;
    CheckExternalEvents(cs2, 0x4E9C);
    // MOV word ptr [BP + -0x2],0x0 (0170_4E97 / 0x6597)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0170_4E9C_0659C:
    CheckExternalEvents(cs2, 0x4E9F);
    // MOV BX,word ptr [BP + -0x2] (0170_4E9C / 0x659C)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4EA1);
    // SHL BX,0x1 (0170_4E9F / 0x659F)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x4EA3);
    // SHL BX,0x1 (0170_4EA1 / 0x65A1)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x4EA7);
    // MOV ES,word ptr [0x538a] (0170_4EA3 / 0x65A3)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4EA9);
    // SUB AX,AX (0170_4EA7 / 0x65A7)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x4EAE);
    // MOV word ptr ES:[BX + 0xd376],AX (0170_4EA9 / 0x65A9)
    UInt16[ES, (ushort)(BX + 0xD376)] = AX;
    CheckExternalEvents(cs2, 0x4EB3);
    // MOV word ptr ES:[BX + 0xd374],AX (0170_4EAE / 0x65AE)
    UInt16[ES, (ushort)(BX + 0xD374)] = AX;
    CheckExternalEvents(cs2, 0x4EB6);
    // INC word ptr [BP + -0x2] (0170_4EB3 / 0x65B3)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs2, 0x4EBA);
    // CMP word ptr [BP + -0x2],0x3 (0170_4EB6 / 0x65B6)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x3);
    CheckExternalEvents(cs2, 0x4EBC);
    // JL 0x0000:659c (0170_4EBA / 0x65BA)
    if(SignFlag != OverflowFlag) {
      goto label_0170_4E9C_0659C;
    }
    CheckExternalEvents(cs2, 0x4EC2);
    // MOV byte ptr ES:[0xd456],0x1 (0170_4EBC / 0x65BC)
    UInt8[ES, 0xD456] = 0x1;
    CheckExternalEvents(cs2, 0x4EC5);
    // MOV word ptr [BP + -0x2],AX (0170_4EC2 / 0x65C2)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    label_0170_4EC5_065C5:
    CheckExternalEvents(cs2, 0x4EC8);
    // MOV BX,word ptr [BP + -0x2] (0170_4EC5 / 0x65C5)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4ECA);
    // MOV CL,0x4 (0170_4EC8 / 0x65C8)
    CL = 0x4;
    CheckExternalEvents(cs2, 0x4ECC);
    // SHL BX,CL (0170_4ECA / 0x65CA)
    // BX <<= CL;
    BX = Alu.Shl16(BX, CL);
    CheckExternalEvents(cs2, 0x4ED0);
    // MOV ES,word ptr [0x538a] (0170_4ECC / 0x65CC)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4ED6);
    // OR byte ptr ES:[BX + 0xd138],0x1f (0170_4ED0 / 0x65D0)
    UInt8[ES, (ushort)(BX + 0xD138)] |= 0x1F;
    CheckExternalEvents(cs2, 0x4ED9);
    // INC word ptr [BP + -0x2] (0170_4ED6 / 0x65D6)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs2, 0x4EDD);
    // CMP word ptr [BP + -0x2],0x6 (0170_4ED9 / 0x65D9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x6);
    CheckExternalEvents(cs2, 0x4EDF);
    // JL 0x0000:65c5 (0170_4EDD / 0x65DD)
    if(SignFlag != OverflowFlag) {
      goto label_0170_4EC5_065C5;
    }
    CheckExternalEvents(cs2, 0x4EE5);
    // MOV byte ptr ES:[0xc615],0x8 (0170_4EDF / 0x65DF)
    UInt8[ES, 0xC615] = 0x8;
    CheckExternalEvents(cs2, 0x4EEB);
    // MOV byte ptr ES:[0xc623],0x50 (0170_4EE5 / 0x65E5)
    UInt8[ES, 0xC623] = 0x50;
    CheckExternalEvents(cs2, 0x4EF1);
    // MOV byte ptr ES:[0xc616],0x9 (0170_4EEB / 0x65EB)
    UInt8[ES, 0xC616] = 0x9;
    CheckExternalEvents(cs2, 0x4EF7);
    // MOV byte ptr ES:[0xc617],0x7 (0170_4EF1 / 0x65F1)
    UInt8[ES, 0xC617] = 0x7;
    CheckExternalEvents(cs2, 0x4EFD);
    // MOV byte ptr ES:[0xc61f],0x0 (0170_4EF7 / 0x65F7)
    UInt8[ES, 0xC61F] = 0x0;
    CheckExternalEvents(cs2, 0x4EFF);
    // SUB AL,AL (0170_4EFD / 0x65FD)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs2, 0x4F03);
    // MOV ES:[0xc624],AL (0170_4EFF / 0x65FF)
    UInt8[ES, 0xC624] = AL;
    CheckExternalEvents(cs2, 0x4F07);
    // MOV ES:[0xc622],AL (0170_4F03 / 0x6603)
    UInt8[ES, 0xC622] = AL;
    CheckExternalEvents(cs2, 0x4F0B);
    // MOV ES:[0xc621],AL (0170_4F07 / 0x6607)
    UInt8[ES, 0xC621] = AL;
    CheckExternalEvents(cs2, 0x4F0F);
    // MOV ES,word ptr [0x539c] (0170_4F0B / 0x660B)
    ES = UInt16[DS, 0x539C];
    CheckExternalEvents(cs2, 0x4F15);
    // MOV byte ptr ES:[0xd562],0x96 (0170_4F0F / 0x660F)
    UInt8[ES, 0xD562] = 0x96;
    CheckExternalEvents(cs2, 0x4F1A);
    // MOV word ptr [BP + -0x2],0x10 (0170_4F15 / 0x6615)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x10;
    label_0170_4F1A_0661A:
    CheckExternalEvents(cs2, 0x4F1D);
    // MOV BX,word ptr [BP + -0x2] (0170_4F1A / 0x661A)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4F21);
    // MOV ES,word ptr [0x539c] (0170_4F1D / 0x661D)
    ES = UInt16[DS, 0x539C];
    CheckExternalEvents(cs2, 0x4F27);
    // MOV byte ptr ES:[BX + 0xd55e],0xfe (0170_4F21 / 0x6621)
    UInt8[ES, (ushort)(BX + 0xD55E)] = 0xFE;
    CheckExternalEvents(cs2, 0x4F2A);
    // INC word ptr [BP + -0x2] (0170_4F27 / 0x6627)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs2, 0x4F2E);
    // CMP word ptr [BP + -0x2],0x18 (0170_4F2A / 0x662A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x18);
    CheckExternalEvents(cs2, 0x4F30);
    // JL 0x0000:661a (0170_4F2E / 0x662E)
    if(SignFlag != OverflowFlag) {
      goto label_0170_4F1A_0661A;
    }
    CheckExternalEvents(cs2, 0x4F35);
    // MOV word ptr [BP + -0x2],0x0 (0170_4F30 / 0x6630)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs2, 0x4F37);
    // JMP 0x0000:665f (0170_4F35 / 0x6635)
    goto label_0170_4F5F_0665F;
    label_0170_4F37_06637:
    CheckExternalEvents(cs2, 0x4F3B);
    // ADD word ptr [BP + -0x6],0xc (0170_4F37 / 0x6637)
    UInt16[SS, (ushort)(BP - 0x6)] += 0xC;
    label_0170_4F3B_0663B:
    CheckExternalEvents(cs2, 0x4F3F);
    // CMP word ptr [BP + -0x6],0xd (0170_4F3B / 0x663B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0xD);
    CheckExternalEvents(cs2, 0x4F41);
    // JGE 0x0000:665c (0170_4F3F / 0x663F)
    if(SignFlag == OverflowFlag) {
      goto label_0170_4F5C_0665C;
    }
    CheckExternalEvents(cs2, 0x4F46);
    // CALLF 0x1000:aab0 (0170_4F41 / 0x6641)
    FarCall(cs2, 0x4F46, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs2, 0x4F48);
    // TEST AL,0x1 (0170_4F46 / 0x6646)
    Alu.And8(AL, 0x1);
    CheckExternalEvents(cs2, 0x4F4A);
    // JZ 0x0000:6637 (0170_4F48 / 0x6648)
    if(ZeroFlag) {
      goto label_0170_4F37_06637;
    }
    CheckExternalEvents(cs2, 0x4F4D);
    // MOV BX,word ptr [BP + -0x2] (0170_4F4A / 0x664A)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4F50);
    // ADD BX,word ptr [BP + -0x6] (0170_4F4D / 0x664D)
    // BX += UInt16[SS, (ushort)(BP - 0x6)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x4F54);
    // MOV ES,word ptr [0x539c] (0170_4F50 / 0x6650)
    ES = UInt16[DS, 0x539C];
    CheckExternalEvents(cs2, 0x4F5A);
    // MOV byte ptr ES:[BX + 0xd55e],0x92 (0170_4F54 / 0x6654)
    UInt8[ES, (ushort)(BX + 0xD55E)] = 0x92;
    CheckExternalEvents(cs2, 0x4F5C);
    // JMP 0x0000:6637 (0170_4F5A / 0x665A)
    goto label_0170_4F37_06637;
    label_0170_4F5C_0665C:
    CheckExternalEvents(cs2, 0x4F5F);
    // INC word ptr [BP + -0x2] (0170_4F5C / 0x665C)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    label_0170_4F5F_0665F:
    CheckExternalEvents(cs2, 0x4F63);
    // CMP word ptr [BP + -0x2],0x4 (0170_4F5F / 0x665F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs2, 0x4F65);
    // JGE 0x0000:666c (0170_4F63 / 0x6663)
    if(SignFlag == OverflowFlag) {
      goto label_0170_4F6C_0666C;
    }
    CheckExternalEvents(cs2, 0x4F6A);
    // MOV word ptr [BP + -0x6],0x0 (0170_4F65 / 0x6665)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    CheckExternalEvents(cs2, 0x4F6C);
    // JMP 0x0000:663b (0170_4F6A / 0x666A)
    goto label_0170_4F3B_0663B;
    label_0170_4F6C_0666C:
    CheckExternalEvents(cs2, 0x4F70);
    // MOV ES,word ptr [0x538a] (0170_4F6C / 0x666C)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4F76);
    // MOV byte ptr ES:[0xd33f],0x32 (0170_4F70 / 0x6670)
    UInt8[ES, 0xD33F] = 0x32;
    CheckExternalEvents(cs2, 0x4F7C);
    // MOV byte ptr ES:[0xd340],0x0 (0170_4F76 / 0x6676)
    UInt8[ES, 0xD340] = 0x0;
    CheckExternalEvents(cs2, 0x4F7E);
    // SUB AL,AL (0170_4F7C / 0x667C)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs2, 0x4F82);
    // MOV ES:[0xd451],AL (0170_4F7E / 0x667E)
    UInt8[ES, 0xD451] = AL;
    CheckExternalEvents(cs2, 0x4F86);
    // MOV ES:[0xd450],AL (0170_4F82 / 0x6682)
    UInt8[ES, 0xD450] = AL;
    CheckExternalEvents(cs2, 0x4F8A);
    // MOV ES:[0xd557],AL (0170_4F86 / 0x6686)
    UInt8[ES, 0xD557] = AL;
    CheckExternalEvents(cs2, 0x4F8F);
    // MOV word ptr [BP + -0x2],0x0 (0170_4F8A / 0x668A)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0170_4F8F_0668F:
    CheckExternalEvents(cs2, 0x4F91);
    // SUB AL,AL (0170_4F8F / 0x668F)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs2, 0x4F94);
    // MOV BX,word ptr [BP + -0x2] (0170_4F91 / 0x6691)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4F98);
    // MOV ES,word ptr [0x538a] (0170_4F94 / 0x6694)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4F9D);
    // MOV byte ptr ES:[BX + 0xd517],AL (0170_4F98 / 0x6698)
    UInt8[ES, (ushort)(BX + 0xD517)] = AL;
    CheckExternalEvents(cs2, 0x4FA0);
    // MOV BX,word ptr [BP + -0x2] (0170_4F9D / 0x669D)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4FA5);
    // MOV byte ptr ES:[BX + 0xd4d7],AL (0170_4FA0 / 0x66A0)
    UInt8[ES, (ushort)(BX + 0xD4D7)] = AL;
    CheckExternalEvents(cs2, 0x4FA8);
    // MOV BX,word ptr [BP + -0x2] (0170_4FA5 / 0x66A5)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x4FAD);
    // MOV byte ptr ES:[BX + 0xd497],AL (0170_4FA8 / 0x66A8)
    UInt8[ES, (ushort)(BX + 0xD497)] = AL;
    CheckExternalEvents(cs2, 0x4FB0);
    // INC word ptr [BP + -0x2] (0170_4FAD / 0x66AD)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs2, 0x4FB4);
    // CMP word ptr [BP + -0x2],0x40 (0170_4FB0 / 0x66B0)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x40);
    CheckExternalEvents(cs2, 0x4FB6);
    // JL 0x0000:668f (0170_4FB4 / 0x66B4)
    if(SignFlag != OverflowFlag) {
      goto label_0170_4F8F_0668F;
    }
    CheckExternalEvents(cs2, 0x4FBB);
    // CALLF 0x1000:beae (0170_4FB6 / 0x66B6)
    FarCall(cs2, 0x4FBB, unknown_19EF_1FBE_1BEAE);
    CheckExternalEvents(cs2, 0x4FBE);
    // MOV AX,0x1 (0170_4FBB / 0x66BB)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x4FBF);
    // PUSH AX (0170_4FBE / 0x66BE)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4FC0);
    // PUSH CS (0170_4FBF / 0x66BF)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4FC3);
    // CALL 0x0000:63ac (0170_4FC0 / 0x66C0)
    NearCall(cs2, 0x4FC3, unknown_0170_4CAC_063AC);
    CheckExternalEvents(cs2, 0x4FC6);
    // ADD SP,0x2 (0170_4FC3 / 0x66C3)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4FCB);
    // CALLF 0x1000:7fe8 (0170_4FC6 / 0x66C6)
    FarCall(cs2, 0x4FCB, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs2, 0x4FCF);
    // MOV ES,word ptr [0x538c] (0170_4FCB / 0x66CB)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x4FD6);
    // MOV word ptr ES:[0xa44b],0xc45 (0170_4FCF / 0x66CF)
    UInt16[ES, 0xA44B] = 0xC45;
    CheckExternalEvents(cs2, 0x4FDA);
    // MOV ES,word ptr [0x538e] (0170_4FD6 / 0x66D6)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x4FE1);
    // MOV word ptr ES:[0xa44d],0xc019 (0170_4FDA / 0x66DA)
    UInt16[ES, 0xA44D] = 0xC019;
    CheckExternalEvents(cs2, 0x4FE4);
    // MOV AX,0xcc (0170_4FE1 / 0x66E1)
    AX = 0xCC;
    CheckExternalEvents(cs2, 0x4FE5);
    // PUSH AX (0170_4FE4 / 0x66E4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4FEA);
    // CALLF 0x1000:af3e (0170_4FE5 / 0x66E5)
    FarCall(cs2, 0x4FEA, unknown_19EF_104E_1AF3E);
    CheckExternalEvents(cs2, 0x4FED);
    // ADD SP,0x2 (0170_4FEA / 0x66EA)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4FF0);
    // MOV AX,0x1 (0170_4FED / 0x66ED)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x4FF1);
    // PUSH AX (0170_4FF0 / 0x66F0)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4FF4);
    // MOV AX,0x4 (0170_4FF1 / 0x66F1)
    AX = 0x4;
    CheckExternalEvents(cs2, 0x4FF5);
    // PUSH AX (0170_4FF4 / 0x66F4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4FF6);
    // PUSH CS (0170_4FF5 / 0x66F5)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4FF9);
    // CALL 0x0000:44a8 (0170_4FF6 / 0x66F6)
    NearCall(cs2, 0x4FF9, unknown_0170_2DA8_044A8);
    CheckExternalEvents(cs2, 0x4FFC);
    // ADD SP,0x4 (0170_4FF9 / 0x66F9)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x5001);
    // CALLF 0x1000:bc98 (0170_4FFC / 0x66FC)
    FarCall(cs2, 0x5001, unknown_19EF_1DA8_1BC98);
    CheckExternalEvents(cs2, 0x5005);
    // MOV ES,word ptr [0x538e] (0170_5001 / 0x6701)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x500A);
    // PUSH word ptr ES:[0xa44d] (0170_5005 / 0x6705)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs2, 0x500E);
    // MOV ES,word ptr [0x538c] (0170_500A / 0x670A)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x5013);
    // PUSH word ptr ES:[0xa44b] (0170_500E / 0x670E)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs2, 0x5018);
    // CALLF 0x1000:b204 (0170_5013 / 0x6713)
    FarCall(cs2, 0x5018, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs2, 0x501B);
    // ADD SP,0x4 (0170_5018 / 0x6718)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x5020);
    // CALLF 0x1000:b7df (0170_501B / 0x671B)
    FarCall(cs2, 0x5020, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs2, 0x5025);
    // MOV word ptr [BP + -0x4],0x0 (0170_5020 / 0x6720)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0170_5025_06725:
    CheckExternalEvents(cs2, 0x5027);
    // SUB AL,AL (0170_5025 / 0x6725)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs2, 0x502A);
    // MOV BX,word ptr [BP + -0x4] (0170_5027 / 0x6727)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x502E);
    // MOV ES,word ptr [0x539a] (0170_502A / 0x672A)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs2, 0x5033);
    // MOV byte ptr ES:[BX + 0x40a6],AL (0170_502E / 0x672E)
    UInt8[ES, (ushort)(BX + 0x40A6)] = AL;
    CheckExternalEvents(cs2, 0x5036);
    // MOV BX,word ptr [BP + -0x4] (0170_5033 / 0x6733)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x503B);
    // MOV byte ptr ES:[BX + 0x409a],AL (0170_5036 / 0x6736)
    UInt8[ES, (ushort)(BX + 0x409A)] = AL;
    CheckExternalEvents(cs2, 0x503D);
    // MOV AL,0xff (0170_503B / 0x673B)
    AL = 0xFF;
    CheckExternalEvents(cs2, 0x5040);
    // MOV BX,word ptr [BP + -0x4] (0170_503D / 0x673D)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x5044);
    // MOV ES,word ptr [0x53be] (0170_5040 / 0x6740)
    ES = UInt16[DS, 0x53BE];
    CheckExternalEvents(cs2, 0x5049);
    // MOV byte ptr ES:[BX + 0x3978],AL (0170_5044 / 0x6744)
    UInt8[ES, (ushort)(BX + 0x3978)] = AL;
    CheckExternalEvents(cs2, 0x504C);
    // MOV BX,word ptr [BP + -0x4] (0170_5049 / 0x6749)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x5051);
    // MOV byte ptr ES:[BX + 0x396c],AL (0170_504C / 0x674C)
    UInt8[ES, (ushort)(BX + 0x396C)] = AL;
    CheckExternalEvents(cs2, 0x5054);
    // INC word ptr [BP + -0x4] (0170_5051 / 0x6751)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs2, 0x5058);
    // CMP word ptr [BP + -0x4],0x4 (0170_5054 / 0x6754)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x4);
    CheckExternalEvents(cs2, 0x505A);
    // JL 0x0000:6725 (0170_5058 / 0x6758)
    if(SignFlag != OverflowFlag) {
      goto label_0170_5025_06725;
    }
    CheckExternalEvents(cs2, 0x505F);
    // MOV word ptr [BP + -0x4],0x4 (0170_505A / 0x675A)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x4;
    label_0170_505F_0675F:
    CheckExternalEvents(cs2, 0x5061);
    // MOV AL,0x10 (0170_505F / 0x675F)
    AL = 0x10;
    CheckExternalEvents(cs2, 0x5064);
    // MOV BX,word ptr [BP + -0x4] (0170_5061 / 0x6761)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x5068);
    // MOV ES,word ptr [0x539a] (0170_5064 / 0x6764)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs2, 0x506D);
    // MOV byte ptr ES:[BX + 0x40a6],AL (0170_5068 / 0x6768)
    UInt8[ES, (ushort)(BX + 0x40A6)] = AL;
    CheckExternalEvents(cs2, 0x5070);
    // MOV BX,word ptr [BP + -0x4] (0170_506D / 0x676D)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x5075);
    // MOV byte ptr ES:[BX + 0x409a],AL (0170_5070 / 0x6770)
    UInt8[ES, (ushort)(BX + 0x409A)] = AL;
    CheckExternalEvents(cs2, 0x5077);
    // MOV AL,0xff (0170_5075 / 0x6775)
    AL = 0xFF;
    CheckExternalEvents(cs2, 0x507A);
    // MOV BX,word ptr [BP + -0x4] (0170_5077 / 0x6777)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x507E);
    // MOV ES,word ptr [0x53be] (0170_507A / 0x677A)
    ES = UInt16[DS, 0x53BE];
    CheckExternalEvents(cs2, 0x5083);
    // MOV byte ptr ES:[BX + 0x3978],AL (0170_507E / 0x677E)
    UInt8[ES, (ushort)(BX + 0x3978)] = AL;
    CheckExternalEvents(cs2, 0x5086);
    // MOV BX,word ptr [BP + -0x4] (0170_5083 / 0x6783)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x508B);
    // MOV byte ptr ES:[BX + 0x396c],AL (0170_5086 / 0x6786)
    UInt8[ES, (ushort)(BX + 0x396C)] = AL;
    CheckExternalEvents(cs2, 0x508E);
    // INC word ptr [BP + -0x4] (0170_508B / 0x678B)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs2, 0x5092);
    // CMP word ptr [BP + -0x4],0xc (0170_508E / 0x678E)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0xC);
    CheckExternalEvents(cs2, 0x5094);
    // JL 0x0000:675f (0170_5092 / 0x6792)
    if(SignFlag != OverflowFlag) {
      goto label_0170_505F_0675F;
    }
    CheckExternalEvents(cs2, 0x5095);
    // PUSH CS (0170_5094 / 0x6794)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x5098);
    // CALL 0x0000:1c1b (0170_5095 / 0x6795)
    NearCall(cs2, 0x5098, unknown_0170_051B_01C1B);
    CheckExternalEvents(cs2, 0x509A);
    // SUB AL,AL (0170_5098 / 0x6798)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs2, 0x509E);
    // MOV ES,word ptr [0x53d0] (0170_509A / 0x679A)
    ES = UInt16[DS, 0x53D0];
    CheckExternalEvents(cs2, 0x50A2);
    // MOV ES:[0x64],AL (0170_509E / 0x679E)
    UInt8[ES, 0x64] = AL;
    CheckExternalEvents(cs2, 0x50A3);
    // CBW  (0170_50A2 / 0x67A2)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x50A6);
    // MOV [0x1a8],AX (0170_50A3 / 0x67A3)
    UInt16[DS, 0x1A8] = AX;
    CheckExternalEvents(cs2, 0x50AA);
    // MOV ES,word ptr [0x53b0] (0170_50A6 / 0x67A6)
    ES = UInt16[DS, 0x53B0];
    CheckExternalEvents(cs2, 0x50AE);
    // MOV ES:[0x398e],AX (0170_50AA / 0x67AA)
    UInt16[ES, 0x398E] = AX;
    CheckExternalEvents(cs2, 0x50B2);
    // MOV ES,word ptr [0x53ec] (0170_50AE / 0x67AE)
    ES = UInt16[DS, 0x53EC];
    CheckExternalEvents(cs2, 0x50B6);
    // MOV ES:[0x374a],AX (0170_50B2 / 0x67B2)
    UInt16[ES, 0x374A] = AX;
    CheckExternalEvents(cs2, 0x50B8);
    // MOV AL,0x1 (0170_50B6 / 0x67B6)
    AL = 0x1;
    CheckExternalEvents(cs2, 0x50BC);
    // MOV ES,word ptr [0x53d0] (0170_50B8 / 0x67B8)
    ES = UInt16[DS, 0x53D0];
    CheckExternalEvents(cs2, 0x50C0);
    // MOV ES:[0xfc],AL (0170_50BC / 0x67BC)
    UInt8[ES, 0xFC] = AL;
    CheckExternalEvents(cs2, 0x50C1);
    // CBW  (0170_50C0 / 0x67C0)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x50C4);
    // MOV [0x14a],AX (0170_50C1 / 0x67C1)
    UInt16[DS, 0x14A] = AX;
    CheckExternalEvents(cs2, 0x50C6);
    // MOV SP,BP (0170_50C4 / 0x67C4)
    SP = BP;
    CheckExternalEvents(cs2, 0x50C7);
    // POP BP (0170_50C6 / 0x67C6)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x50C8);
    // RETF  (0170_50C7 / 0x67C7)
    return FarRet();
  }
  
  public virtual Action unknown_0170_50C8_067C8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_50C8_067C8:
    CheckExternalEvents(cs2, 0x50C9);
    // PUSH BP (0170_50C8 / 0x67C8)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x50CB);
    // MOV BP,SP (0170_50C9 / 0x67C9)
    BP = SP;
    CheckExternalEvents(cs2, 0x50CE);
    // MOV AX,0x32 (0170_50CB / 0x67CB)
    AX = 0x32;
    CheckExternalEvents(cs2, 0x50D3);
    // CALLF 0x1000:cecc (0170_50CE / 0x67CE)
    FarCall(cs2, 0x50D3, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x50D8);
    // MOV word ptr [BP + -0x16],0x0 (0170_50D3 / 0x67D3)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    label_0170_50D8_067D8:
    CheckExternalEvents(cs2, 0x50DD);
    // CALLF 0x1000:aab0 (0170_50D8 / 0x67D8)
    FarCall(cs2, 0x50DD, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs2, 0x50E0);
    // MOV BX,word ptr [BP + -0x16] (0170_50DD / 0x67DD)
    BX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0x50E4);
    // MOV ES,word ptr [0x5400] (0170_50E0 / 0x67E0)
    ES = UInt16[DS, 0x5400];
    CheckExternalEvents(cs2, 0x50E9);
    // MOV byte ptr ES:[BX + 0x9fb],AL (0170_50E4 / 0x67E4)
    UInt8[ES, (ushort)(BX + 0x9FB)] = AL;
    CheckExternalEvents(cs2, 0x50EC);
    // INC word ptr [BP + -0x16] (0170_50E9 / 0x67E9)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    CheckExternalEvents(cs2, 0x50F1);
    // CMP word ptr [BP + -0x16],0x100 (0170_50EC / 0x67EC)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x100);
    CheckExternalEvents(cs2, 0x50F3);
    // JL 0x0000:67d8 (0170_50F1 / 0x67F1)
    if(SignFlag != OverflowFlag) {
      goto label_0170_50D8_067D8;
    }
    CheckExternalEvents(cs2, 0x50F7);
    // MOV ES,word ptr [0x53e8] (0170_50F3 / 0x67F3)
    ES = UInt16[DS, 0x53E8];
    CheckExternalEvents(cs2, 0x50FE);
    // MOV word ptr ES:[0x4fbc],0x0 (0170_50F7 / 0x67F7)
    UInt16[ES, 0x4FBC] = 0x0;
    CheckExternalEvents(cs2, 0x5101);
    // MOV AX,0x130 (0170_50FE / 0x67FE)
    AX = 0x130;
    CheckExternalEvents(cs2, 0x5104);
    // MOV DX,0x2958 (0170_5101 / 0x6801)
    DX = 0x2958;
    CheckExternalEvents(cs2, 0x5105);
    // PUSH DX (0170_5104 / 0x6804)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x5106);
    // PUSH AX (0170_5105 / 0x6805)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x510B);
    // CALLF 0x1000:9fc1 (0170_5106 / 0x6806)
    FarCall(cs2, 0x510B, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs2, 0x510E);
    // ADD SP,0x4 (0170_510B / 0x680B)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x5112);
    // MOV ES,word ptr [0x53e8] (0170_510E / 0x680E)
    ES = UInt16[DS, 0x53E8];
    CheckExternalEvents(cs2, 0x5115);
    // MOV AX,0x1 (0170_5112 / 0x6812)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x5118);
    // MOV word ptr [BP + -0x2],AX (0170_5115 / 0x6815)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x511B);
    // MOV word ptr [BP + -0x1a],AX (0170_5118 / 0x6818)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs2, 0x511F);
    // MOV ES:[0x4fbc],AX (0170_511B / 0x681B)
    UInt16[ES, 0x4FBC] = AX;
    CheckExternalEvents(cs2, 0x5120);
    // PUSH CS (0170_511F / 0x681F)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x5123);
    // CALL 0x0000:490b (0170_5120 / 0x6820)
    NearCall(cs2, 0x5123, unknown_0170_320B_0490B);
    CheckExternalEvents(cs2, 0x5126);
    // JMP 0x0000:6969 (0170_5123 / 0x6823)
    goto label_0170_5269_06969;
    label_0170_5126_06826:
    CheckExternalEvents(cs2, 0x512A);
    // MOV ES,word ptr [0x5384] (0170_5126 / 0x6826)
    ES = UInt16[DS, 0x5384];
    CheckExternalEvents(cs2, 0x5131);
    // MOV word ptr ES:[0x3938],0x0 (0170_512A / 0x682A)
    UInt16[ES, 0x3938] = 0x0;
    CheckExternalEvents(cs2, 0x5136);
    // CALLF 0x1000:8aff (0170_5131 / 0x6831)
    FarCall(cs2, 0x5136, unknown_18AD_002F_18AFF);
    CheckExternalEvents(cs2, 0x5138);
    // OR AX,AX (0170_5136 / 0x6836)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x513A);
    // JNZ 0x0000:683d (0170_5138 / 0x6838)
    if(!ZeroFlag) {
      goto label_0170_513D_0683D;
    }
    CheckExternalEvents(cs2, 0x513D);
    // JMP 0x0000:68f9 (0170_513A / 0x683A)
    goto label_0170_51F9_068F9;
    label_0170_513D_0683D:
    CheckExternalEvents(cs2, 0x513E);
    // PUSH CS (0170_513D / 0x683D)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x5141);
    // CALL 0x0000:412b (0170_513E / 0x683E)
    NearCall(cs2, 0x5141, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs2, 0x5142);
    // PUSH CS (0170_5141 / 0x6841)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x5145);
    // CALL 0x0000:64c7 (0170_5142 / 0x6842)
    NearCall(cs2, 0x5145, unknown_0170_4DC7_064C7);
    CheckExternalEvents(cs2, 0x5149);
    // MOV ES,word ptr [0x5402] (0170_5145 / 0x6845)
    ES = UInt16[DS, 0x5402];
    CheckExternalEvents(cs2, 0x514F);
    // CMP word ptr ES:[0x458c],0x0 (0170_5149 / 0x6849)
    Alu.Sub16(UInt16[ES, 0x458C], 0x0);
    CheckExternalEvents(cs2, 0x5151);
    // JZ 0x0000:6854 (0170_514F / 0x684F)
    if(ZeroFlag) {
      goto label_0170_5154_06854;
    }
    CheckExternalEvents(cs2, 0x5154);
    // JMP 0x0000:68e0 (0170_5151 / 0x6851)
    goto label_0170_51E0_068E0;
    label_0170_5154_06854:
    CheckExternalEvents(cs2, 0x5157);
    // MOV AX,0x6 (0170_5154 / 0x6854)
    AX = 0x6;
    CheckExternalEvents(cs2, 0x5158);
    // PUSH AX (0170_5157 / 0x6857)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x515D);
    // CALLF 0x1000:7ee1 (0170_5158 / 0x6858)
    FarCall(cs2, 0x515D, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs2, 0x5160);
    // ADD SP,0x2 (0170_515D / 0x685D)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x5165);
    // CALLF 0x1000:7fe8 (0170_5160 / 0x6860)
    FarCall(cs2, 0x5165, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs2, 0x5167);
    // SUB AX,AX (0170_5165 / 0x6865)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x5168);
    // PUSH AX (0170_5167 / 0x6867)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x516D);
    // CALLF 0x1000:7c64 (0170_5168 / 0x6868)
    FarCall(cs2, 0x516D, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs2, 0x5170);
    // ADD SP,0x2 (0170_516D / 0x686D)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x5173);
    // MOV AX,0xb0e (0170_5170 / 0x6870)
    AX = 0xB0E;
    CheckExternalEvents(cs2, 0x5174);
    // PUSH DS (0170_5173 / 0x6873)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x5175);
    // PUSH AX (0170_5174 / 0x6874)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x517A);
    // CALLF 0x1000:8055 (0170_5175 / 0x6875)
    FarCall(cs2, 0x517A, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x517D);
    // ADD SP,0x4 (0170_517A / 0x687A)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x5180);
    // MOV AX,0xb4c (0170_517D / 0x687D)
    AX = 0xB4C;
    CheckExternalEvents(cs2, 0x5181);
    // PUSH DS (0170_5180 / 0x6880)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x5182);
    // PUSH AX (0170_5181 / 0x6881)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x5187);
    // CALLF 0x1000:8055 (0170_5182 / 0x6882)
    FarCall(cs2, 0x5187, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x518A);
    // ADD SP,0x4 (0170_5187 / 0x6887)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x518D);
    // MOV AX,0xb90 (0170_518A / 0x688A)
    AX = 0xB90;
    CheckExternalEvents(cs2, 0x518E);
    // PUSH DS (0170_518D / 0x688D)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x518F);
    // PUSH AX (0170_518E / 0x688E)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x5194);
    // CALLF 0x1000:8055 (0170_518F / 0x688F)
    FarCall(cs2, 0x5194, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x5197);
    // ADD SP,0x4 (0170_5194 / 0x6894)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x519A);
    // MOV AX,0xbe2 (0170_5197 / 0x6897)
    AX = 0xBE2;
    CheckExternalEvents(cs2, 0x519B);
    // PUSH DS (0170_519A / 0x689A)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x519C);
    // PUSH AX (0170_519B / 0x689B)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x51A1);
    // CALLF 0x1000:8055 (0170_519C / 0x689C)
    FarCall(cs2, 0x51A1, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x51A4);
    // ADD SP,0x4 (0170_51A1 / 0x68A1)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x51A7);
    // MOV AX,0xc0d (0170_51A4 / 0x68A4)
    AX = 0xC0D;
    CheckExternalEvents(cs2, 0x51A8);
    // PUSH DS (0170_51A7 / 0x68A7)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x51A9);
    // PUSH AX (0170_51A8 / 0x68A8)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x51AE);
    // CALLF 0x1000:8055 (0170_51A9 / 0x68A9)
    FarCall(cs2, 0x51AE, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x51B1);
    // ADD SP,0x4 (0170_51AE / 0x68AE)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x51B4);
    // MOV AX,0x1 (0170_51B1 / 0x68B1)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x51B5);
    // PUSH AX (0170_51B4 / 0x68B4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x51B6);
    // PUSH CS (0170_51B5 / 0x68B5)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x51B9);
    // CALL 0x0000:3113 (0170_51B6 / 0x68B6)
    NearCall(cs2, 0x51B9, unknown_0170_1A13_03113);
    CheckExternalEvents(cs2, 0x51BC);
    // ADD SP,0x2 (0170_51B9 / 0x68B9)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x51BE);
    // OR AX,AX (0170_51BC / 0x68BC)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x51C0);
    // JNZ 0x0000:68e0 (0170_51BE / 0x68BE)
    if(!ZeroFlag) {
      goto label_0170_51E0_068E0;
    }
    CheckExternalEvents(cs2, 0x51C3);
    // MOV AX,0xc39 (0170_51C0 / 0x68C0)
    AX = 0xC39;
    CheckExternalEvents(cs2, 0x51C4);
    // PUSH DS (0170_51C3 / 0x68C3)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x51C5);
    // PUSH AX (0170_51C4 / 0x68C4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x51CA);
    // CALLF 0x1000:8055 (0170_51C5 / 0x68C5)
    FarCall(cs2, 0x51CA, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x51CD);
    // ADD SP,0x4 (0170_51CA / 0x68CA)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x51D0);
    // MOV AX,0x1 (0170_51CD / 0x68CD)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x51D1);
    // PUSH AX (0170_51D0 / 0x68D0)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x51D2);
    // PUSH CS (0170_51D1 / 0x68D1)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x51D5);
    // CALL 0x0000:3113 (0170_51D2 / 0x68D2)
    NearCall(cs2, 0x51D5, unknown_0170_1A13_03113);
    CheckExternalEvents(cs2, 0x51D8);
    // ADD SP,0x2 (0170_51D5 / 0x68D5)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x51DA);
    // OR AX,AX (0170_51D8 / 0x68D8)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x51DC);
    // JZ 0x0000:68e0 (0170_51DA / 0x68DA)
    if(ZeroFlag) {
      goto label_0170_51E0_068E0;
    }
    CheckExternalEvents(cs2, 0x51DD);
    // PUSH CS (0170_51DC / 0x68DC)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x51E0);
    // CALL 0x0000:49b3 (0170_51DD / 0x68DD)
    NearCall(cs2, 0x51E0, ghidra_guess_0000_49B3_049B3);
    label_0170_51E0_068E0:
    CheckExternalEvents(cs2, 0x51E2);
    // SUB AX,AX (0170_51E0 / 0x68E0)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x51E3);
    // PUSH AX (0170_51E2 / 0x68E2)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x51E4);
    // PUSH CS (0170_51E3 / 0x68E3)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x51E7);
    // CALL 0x0000:1700 (0170_51E4 / 0x68E4)
    NearCall(cs2, 0x51E7, unknown_0170_0000_01700);
    CheckExternalEvents(cs2, 0x51EA);
    // ADD SP,0x2 (0170_51E7 / 0x68E7)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x51EE);
    // MOV ES,word ptr [0x5402] (0170_51EA / 0x68EA)
    ES = UInt16[DS, 0x5402];
    CheckExternalEvents(cs2, 0x51F0);
    // SUB AX,AX (0170_51EE / 0x68EE)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x51F4);
    // MOV ES:[0x458c],AX (0170_51F0 / 0x68F0)
    UInt16[ES, 0x458C] = AX;
    CheckExternalEvents(cs2, 0x51F7);
    // MOV word ptr [BP + -0x2],AX (0170_51F4 / 0x68F4)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x51F9);
    // JMP 0x0000:695f (0170_51F7 / 0x68F7)
    goto label_0170_525F_0695F;
    label_0170_51F9_068F9:
    CheckExternalEvents(cs2, 0x51FC);
    // MOV AX,0x2 (0170_51F9 / 0x68F9)
    AX = 0x2;
    CheckExternalEvents(cs2, 0x51FD);
    // PUSH AX (0170_51FC / 0x68FC)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x51FE);
    // PUSH CS (0170_51FD / 0x68FD)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x5201);
    // CALL 0x0000:3fcc (0170_51FE / 0x68FE)
    NearCall(cs2, 0x5201, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs2, 0x5204);
    // ADD SP,0x2 (0170_5201 / 0x6901)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x5207);
    // MOV AX,0x3ff (0170_5204 / 0x6904)
    AX = 0x3FF;
    CheckExternalEvents(cs2, 0x5208);
    // PUSH AX (0170_5207 / 0x6907)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x520B);
    // MOV AX,0x27b0 (0170_5208 / 0x6908)
    AX = 0x27B0;
    CheckExternalEvents(cs2, 0x520E);
    // MOV DX,0x2a02 (0170_520B / 0x690B)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x520F);
    // PUSH DX (0170_520E / 0x690E)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x5210);
    // PUSH AX (0170_520F / 0x690F)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x5213);
    // MOV AX,0xc98 (0170_5210 / 0x6910)
    AX = 0xC98;
    CheckExternalEvents(cs2, 0x5214);
    // PUSH DS (0170_5213 / 0x6913)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x5215);
    // PUSH AX (0170_5214 / 0x6914)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x521A);
    // CALLF 0x1000:92e4 (0170_5215 / 0x6915)
    FarCall(cs2, 0x521A, unknown_18AD_0814_192E4);
    CheckExternalEvents(cs2, 0x521D);
    // ADD SP,0xa (0170_521A / 0x691A)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs2, 0x5221);
    // MOV ES,word ptr [0x5404] (0170_521D / 0x691D)
    ES = UInt16[DS, 0x5404];
    CheckExternalEvents(cs2, 0x5228);
    // MOV word ptr ES:[0x39f8],0x2710 (0170_5221 / 0x6921)
    UInt16[ES, 0x39F8] = 0x2710;
    CheckExternalEvents(cs2, 0x522C);
    // MOV ES,word ptr [0x5406] (0170_5228 / 0x6928)
    ES = UInt16[DS, 0x5406];
    CheckExternalEvents(cs2, 0x5233);
    // MOV word ptr ES:[0x4fc0],0x1325 (0170_522C / 0x692C)
    UInt16[ES, 0x4FC0] = 0x1325;
    CheckExternalEvents(cs2, 0x523A);
    // MOV word ptr ES:[0x4fc2],0x90 (0170_5233 / 0x6933)
    UInt16[ES, 0x4FC2] = 0x90;
    CheckExternalEvents(cs2, 0x523E);
    // MOV ES,word ptr [0x53d2] (0170_523A / 0x693A)
    ES = UInt16[DS, 0x53D2];
    CheckExternalEvents(cs2, 0x5245);
    // MOV word ptr ES:[0x3988],0xffff (0170_523E / 0x693E)
    UInt16[ES, 0x3988] = 0xFFFF;
    CheckExternalEvents(cs2, 0x5249);
    // MOV ES,word ptr [0x5384] (0170_5245 / 0x6945)
    ES = UInt16[DS, 0x5384];
    CheckExternalEvents(cs2, 0x5250);
    // MOV word ptr ES:[0x3938],0x1 (0170_5249 / 0x6949)
    UInt16[ES, 0x3938] = 0x1;
    CheckExternalEvents(cs2, 0x5251);
    // PUSH CS (0170_5250 / 0x6950)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x5254);
    // CALL 0x0000:64c7 (0170_5251 / 0x6951)
    NearCall(cs2, 0x5254, unknown_0170_4DC7_064C7);
    CheckExternalEvents(cs2, 0x5257);
    // MOV AX,0x1 (0170_5254 / 0x6954)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x5258);
    // PUSH AX (0170_5257 / 0x6957)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x5259);
    // PUSH CS (0170_5258 / 0x6958)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x525C);
    // CALL 0x0000:1700 (0170_5259 / 0x6959)
    NearCall(cs2, 0x525C, unknown_0170_0000_01700);
    CheckExternalEvents(cs2, 0x525F);
    // ADD SP,0x2 (0170_525C / 0x695C)
    SP += 0x2;
    label_0170_525F_0695F:
    CheckExternalEvents(cs2, 0x5263);
    // CMP word ptr [BP + -0x2],0x0 (0170_525F / 0x695F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs2, 0x5265);
    // JZ 0x0000:696d (0170_5263 / 0x6963)
    if(ZeroFlag) {
      goto label_0170_526D_0696D;
    }
    CheckExternalEvents(cs2, 0x5266);
    // PUSH CS (0170_5265 / 0x6965)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x5269);
    // CALL 0x0000:5da7 (0170_5266 / 0x6966)
    NearCall(cs2, 0x5269, unknown_0170_46A7_05DA7);
    label_0170_5269_06969:
    CheckExternalEvents(cs2, 0x526A);
    // PUSH CS (0170_5269 / 0x6969)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x526D);
    // CALL 0x0000:5e6d (0170_526A / 0x696A)
    NearCall(cs2, 0x526D, unknown_0170_476D_05E6D);
    label_0170_526D_0696D:
    CheckExternalEvents(cs2, 0x5271);
    // CMP word ptr [BP + -0x2],0x0 (0170_526D / 0x696D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs2, 0x5273);
    // JZ 0x0000:6976 (0170_5271 / 0x6971)
    if(ZeroFlag) {
      goto label_0170_5276_06976;
    }
    CheckExternalEvents(cs2, 0x5276);
    // JMP 0x0000:6826 (0170_5273 / 0x6973)
    goto label_0170_5126_06826;
    label_0170_5276_06976:
    CheckExternalEvents(cs2, 0x5278);
    // MOV SP,BP (0170_5276 / 0x6976)
    SP = BP;
    CheckExternalEvents(cs2, 0x5279);
    // POP BP (0170_5278 / 0x6978)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x527A);
    // RETF  (0170_5279 / 0x6979)
    return FarRet();
  }
  
  public virtual Action unknown_0697_000A_0697A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0697_000A_0697A:
    CheckExternalEvents(cs3, 0xB);
    // PUSH BP (0697_000A / 0x697A)
    Stack.Push16(BP);
    CheckExternalEvents(cs3, 0xD);
    // MOV BP,SP (0697_000B / 0x697B)
    BP = SP;
    CheckExternalEvents(cs3, 0x10);
    // MOV AX,0x2 (0697_000D / 0x697D)
    AX = 0x2;
    CheckExternalEvents(cs3, 0x15);
    // CALLF 0x1000:cecc (0697_0010 / 0x6980)
    FarCall(cs3, 0x15, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs3, 0x16);
    // PUSH SI (0697_0015 / 0x6985)
    Stack.Push16(SI);
    CheckExternalEvents(cs3, 0x1B);
    // MOV word ptr [BP + -0x2],0x0 (0697_0016 / 0x6986)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs3, 0x1D);
    // JMP 0x0000:69a3 (0697_001B / 0x698B)
    goto label_0697_0033_069A3;
    label_0697_001D_0698D:
    CheckExternalEvents(cs3, 0x20);
    // MOV BX,word ptr [BP + -0x2] (0697_001D / 0x698D)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs3, 0x23);
    // INC word ptr [BP + -0x2] (0697_0020 / 0x6990)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs3, 0x26);
    // LES SI,[BP + 0x6] (0697_0023 / 0x6993)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs3, 0x29);
    // MOV AL,byte ptr ES:[BX + SI] (0697_0026 / 0x6996)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs3, 0x2A);
    // CBW  (0697_0029 / 0x6999)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs3, 0x2B);
    // PUSH AX (0697_002A / 0x699A)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x30);
    // CALLF 0x1000:a103 (0697_002B / 0x699B)
    FarCall(cs3, 0x30, unknown_19EF_0213_1A103);
    CheckExternalEvents(cs3, 0x33);
    // ADD SP,0x2 (0697_0030 / 0x69A0)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0697_0033_069A3:
    CheckExternalEvents(cs3, 0x36);
    // MOV BX,word ptr [BP + -0x2] (0697_0033 / 0x69A3)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs3, 0x39);
    // LES SI,[BP + 0x6] (0697_0036 / 0x69A6)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs3, 0x3D);
    // CMP byte ptr ES:[BX + SI],0x0 (0697_0039 / 0x69A9)
    Alu.Sub8(UInt8[ES, (ushort)(BX + SI)], 0x0);
    CheckExternalEvents(cs3, 0x3F);
    // JNZ 0x0000:698d (0697_003D / 0x69AD)
    if(!ZeroFlag) {
      goto label_0697_001D_0698D;
    }
    CheckExternalEvents(cs3, 0x40);
    // POP SI (0697_003F / 0x69AF)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs3, 0x42);
    // MOV SP,BP (0697_0040 / 0x69B0)
    SP = BP;
    CheckExternalEvents(cs3, 0x43);
    // POP BP (0697_0042 / 0x69B2)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs3, 0x44);
    // RETF  (0697_0043 / 0x69B3)
    return FarRet();
  }
  
  public virtual Action unknown_0697_0044_069B4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0697_0044_069B4:
    CheckExternalEvents(cs3, 0x45);
    // PUSH BP (0697_0044 / 0x69B4)
    Stack.Push16(BP);
    CheckExternalEvents(cs3, 0x47);
    // MOV BP,SP (0697_0045 / 0x69B5)
    BP = SP;
    CheckExternalEvents(cs3, 0x4A);
    // MOV AX,0x1a (0697_0047 / 0x69B7)
    AX = 0x1A;
    CheckExternalEvents(cs3, 0x4F);
    // CALLF 0x1000:cecc (0697_004A / 0x69BA)
    FarCall(cs3, 0x4F, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs3, 0x52);
    // MOV AX,0xcd6 (0697_004F / 0x69BF)
    AX = 0xCD6;
    CheckExternalEvents(cs3, 0x53);
    // PUSH DS (0697_0052 / 0x69C2)
    Stack.Push16(DS);
    CheckExternalEvents(cs3, 0x54);
    // PUSH AX (0697_0053 / 0x69C3)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x55);
    // PUSH CS (0697_0054 / 0x69C4)
    Stack.Push16(cs3);
    CheckExternalEvents(cs3, 0x58);
    // CALL 0x0000:697a (0697_0055 / 0x69C5)
    NearCall(cs3, 0x58, unknown_0697_000A_0697A);
    CheckExternalEvents(cs3, 0x5B);
    // ADD SP,0x4 (0697_0058 / 0x69C8)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs3, 0x5E);
    // MOV AX,0xd2a (0697_005B / 0x69CB)
    AX = 0xD2A;
    CheckExternalEvents(cs3, 0x5F);
    // PUSH DS (0697_005E / 0x69CE)
    Stack.Push16(DS);
    CheckExternalEvents(cs3, 0x60);
    // PUSH AX (0697_005F / 0x69CF)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x61);
    // PUSH CS (0697_0060 / 0x69D0)
    Stack.Push16(cs3);
    CheckExternalEvents(cs3, 0x64);
    // CALL 0x0000:697a (0697_0061 / 0x69D1)
    NearCall(cs3, 0x64, unknown_0697_000A_0697A);
    CheckExternalEvents(cs3, 0x67);
    // ADD SP,0x4 (0697_0064 / 0x69D4)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    label_0697_0067_069D7:
    CheckExternalEvents(cs3, 0x6C);
    // CALLF 0x1000:8d29 (0697_0067 / 0x69D7)
    FarCall(cs3, 0x6C, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs3, 0x70);
    // MOV ES,word ptr [0x5408] (0697_006C / 0x69DC)
    ES = UInt16[DS, 0x5408];
    CheckExternalEvents(cs3, 0x74);
    // MOV ES:[0x4fba],AX (0697_0070 / 0x69E0)
    UInt16[ES, 0x4FBA] = AX;
    CheckExternalEvents(cs3, 0x77);
    // CMP AX,0x31 (0697_0074 / 0x69E4)
    Alu.Sub16(AX, 0x31);
    CheckExternalEvents(cs3, 0x79);
    // JL 0x0000:69d7 (0697_0077 / 0x69E7)
    if(SignFlag != OverflowFlag) {
      goto label_0697_0067_069D7;
    }
    CheckExternalEvents(cs3, 0x7C);
    // CMP AX,0x34 (0697_0079 / 0x69E9)
    Alu.Sub16(AX, 0x34);
    CheckExternalEvents(cs3, 0x7E);
    // JG 0x0000:69d7 (0697_007C / 0x69EC)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0697_0067_069D7;
    }
    CheckExternalEvents(cs3, 0x81);
    // MOV AX,0xd92 (0697_007E / 0x69EE)
    AX = 0xD92;
    CheckExternalEvents(cs3, 0x82);
    // PUSH DS (0697_0081 / 0x69F1)
    Stack.Push16(DS);
    CheckExternalEvents(cs3, 0x83);
    // PUSH AX (0697_0082 / 0x69F2)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x84);
    // PUSH CS (0697_0083 / 0x69F3)
    Stack.Push16(cs3);
    CheckExternalEvents(cs3, 0x87);
    // CALL 0x0000:697a (0697_0084 / 0x69F4)
    NearCall(cs3, 0x87, unknown_0697_000A_0697A);
    CheckExternalEvents(cs3, 0x8A);
    // ADD SP,0x4 (0697_0087 / 0x69F7)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs3, 0x8E);
    // MOV ES,word ptr [0x540a] (0697_008A / 0x69FA)
    ES = UInt16[DS, 0x540A];
    CheckExternalEvents(cs3, 0x90);
    // SUB AX,AX (0697_008E / 0x69FE)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs3, 0x93);
    // MOV word ptr [BP + -0x12],AX (0697_0090 / 0x6A00)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs3, 0x97);
    // MOV ES:[0xd580],AX (0697_0093 / 0x6A03)
    UInt16[ES, 0xD580] = AX;
    CheckExternalEvents(cs3, 0x99);
    // JMP 0x0000:6a7c (0697_0097 / 0x6A07)
    goto label_0697_010C_06A7C;
    label_0697_0099_06A09:
    CheckExternalEvents(cs3, 0x9E);
    // CALLF 0x1000:8d29 (0697_0099 / 0x6A09)
    FarCall(cs3, 0x9E, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs3, 0xA1);
    // MOV word ptr [BP + -0x10],AX (0697_009E / 0x6A0E)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs3, 0xA4);
    // CMP AX,0x31 (0697_00A1 / 0x6A11)
    Alu.Sub16(AX, 0x31);
    CheckExternalEvents(cs3, 0xA6);
    // JL 0x0000:6a7c (0697_00A4 / 0x6A14)
    if(SignFlag != OverflowFlag) {
      goto label_0697_010C_06A7C;
    }
    CheckExternalEvents(cs3, 0xA9);
    // CMP AX,0x33 (0697_00A6 / 0x6A16)
    Alu.Sub16(AX, 0x33);
    CheckExternalEvents(cs3, 0xAB);
    // JG 0x0000:6a7c (0697_00A9 / 0x6A19)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0697_010C_06A7C;
    }
    CheckExternalEvents(cs3, 0xAF);
    // MOV ES,word ptr [0x540c] (0697_00AB / 0x6A1B)
    ES = UInt16[DS, 0x540C];
    CheckExternalEvents(cs3, 0xB2);
    // SUB AX,0x31 (0697_00AF / 0x6A1F)
    // AX -= 0x31;
    AX = Alu.Sub16(AX, 0x31);
    CheckExternalEvents(cs3, 0xB6);
    // MOV ES:[0x3ffe],AX (0697_00B2 / 0x6A22)
    UInt16[ES, 0x3FFE] = AX;
    CheckExternalEvents(cs3, 0xB9);
    // CMP AX,0x2 (0697_00B6 / 0x6A26)
    Alu.Sub16(AX, 0x2);
    CheckExternalEvents(cs3, 0xBB);
    // JNZ 0x0000:6a5a (0697_00B9 / 0x6A29)
    if(!ZeroFlag) {
      goto label_0697_00EA_06A5A;
    }
    CheckExternalEvents(cs3, 0xC2);
    // MOV word ptr ES:[0x3ffe],0x0 (0697_00BB / 0x6A2B)
    UInt16[ES, 0x3FFE] = 0x0;
    CheckExternalEvents(cs3, 0xC6);
    // MOV ES,word ptr [0x540a] (0697_00C2 / 0x6A32)
    ES = UInt16[DS, 0x540A];
    CheckExternalEvents(cs3, 0xCD);
    // MOV word ptr ES:[0xd580],0x1 (0697_00C6 / 0x6A36)
    UInt16[ES, 0xD580] = 0x1;
    CheckExternalEvents(cs3, 0xD0);
    // MOV AX,0xe2c (0697_00CD / 0x6A3D)
    AX = 0xE2C;
    CheckExternalEvents(cs3, 0xD1);
    // PUSH DS (0697_00D0 / 0x6A40)
    Stack.Push16(DS);
    CheckExternalEvents(cs3, 0xD2);
    // PUSH AX (0697_00D1 / 0x6A41)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0xD3);
    // PUSH CS (0697_00D2 / 0x6A42)
    Stack.Push16(cs3);
    CheckExternalEvents(cs3, 0xD6);
    // CALL 0x0000:697a (0697_00D3 / 0x6A43)
    NearCall(cs3, 0xD6, unknown_0697_000A_0697A);
    CheckExternalEvents(cs3, 0xD9);
    // ADD SP,0x4 (0697_00D6 / 0x6A46)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs3, 0xDC);
    // MOV AX,0xe78 (0697_00D9 / 0x6A49)
    AX = 0xE78;
    CheckExternalEvents(cs3, 0xDD);
    // PUSH DS (0697_00DC / 0x6A4C)
    Stack.Push16(DS);
    CheckExternalEvents(cs3, 0xDE);
    // PUSH AX (0697_00DD / 0x6A4D)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0xDF);
    // PUSH CS (0697_00DE / 0x6A4E)
    Stack.Push16(cs3);
    CheckExternalEvents(cs3, 0xE2);
    // CALL 0x0000:697a (0697_00DF / 0x6A4F)
    NearCall(cs3, 0xE2, unknown_0697_000A_0697A);
    CheckExternalEvents(cs3, 0xE5);
    // ADD SP,0x4 (0697_00E2 / 0x6A52)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs3, 0xEA);
    // CALLF 0x1000:8d29 (0697_00E5 / 0x6A55)
    FarCall(cs3, 0xEA, unknown_18AD_0259_18D29);
    label_0697_00EA_06A5A:
    CheckExternalEvents(cs3, 0xEE);
    // MOV ES,word ptr [0x540c] (0697_00EA / 0x6A5A)
    ES = UInt16[DS, 0x540C];
    CheckExternalEvents(cs3, 0xF4);
    // CMP word ptr ES:[0x3ffe],0x0 (0697_00EE / 0x6A5E)
    Alu.Sub16(UInt16[ES, 0x3FFE], 0x0);
    CheckExternalEvents(cs3, 0xF6);
    // JZ 0x0000:6a77 (0697_00F4 / 0x6A64)
    if(ZeroFlag) {
      goto label_0697_0107_06A77;
    }
    CheckExternalEvents(cs3, 0xF9);
    // MOV AX,0xdd0 (0697_00F6 / 0x6A66)
    AX = 0xDD0;
    CheckExternalEvents(cs3, 0xFA);
    // PUSH DS (0697_00F9 / 0x6A69)
    Stack.Push16(DS);
    CheckExternalEvents(cs3, 0xFB);
    // PUSH AX (0697_00FA / 0x6A6A)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0xFC);
    // PUSH CS (0697_00FB / 0x6A6B)
    Stack.Push16(cs3);
    CheckExternalEvents(cs3, 0xFF);
    // CALL 0x0000:697a (0697_00FC / 0x6A6C)
    NearCall(cs3, 0xFF, unknown_0697_000A_0697A);
    CheckExternalEvents(cs3, 0x102);
    // ADD SP,0x4 (0697_00FF / 0x6A6F)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs3, 0x107);
    // CALLF 0x1000:8d29 (0697_0102 / 0x6A72)
    FarCall(cs3, 0x107, unknown_18AD_0259_18D29);
    label_0697_0107_06A77:
    CheckExternalEvents(cs3, 0x10C);
    // MOV word ptr [BP + -0x12],0x1 (0697_0107 / 0x6A77)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    label_0697_010C_06A7C:
    CheckExternalEvents(cs3, 0x110);
    // CMP word ptr [BP + -0x12],0x0 (0697_010C / 0x6A7C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs3, 0x112);
    // JZ 0x0000:6a09 (0697_0110 / 0x6A80)
    if(ZeroFlag) {
      goto label_0697_0099_06A09;
    }
    CheckExternalEvents(cs3, 0x116);
    // MOV ES,word ptr [0x5408] (0697_0112 / 0x6A82)
    ES = UInt16[DS, 0x5408];
    CheckExternalEvents(cs3, 0x11C);
    // SUB word ptr ES:[0x4fba],0x31 (0697_0116 / 0x6A86)
    // UInt16[ES, 0x4FBA] -= 0x31;
    UInt16[ES, 0x4FBA] = Alu.Sub16(UInt16[ES, 0x4FBA], 0x31);
    CheckExternalEvents(cs3, 0x121);
    // CALLF 0x0000:7e3f (0697_011C / 0x6A8C)
    FarCall(cs3, 0x121, unknown_071B_0C8F_07E3F);
    CheckExternalEvents(cs3, 0x124);
    // MOV AX,0x2 (0697_0121 / 0x6A91)
    AX = 0x2;
    CheckExternalEvents(cs3, 0x125);
    // PUSH AX (0697_0124 / 0x6A94)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x12A);
    // CALLF 0x0000:3fcc (0697_0125 / 0x6A95)
    FarCall(cs3, 0x12A, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs3, 0x12D);
    // ADD SP,0x2 (0697_012A / 0x6A9A)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs3, 0x131);
    // MOV ES,word ptr [0x5408] (0697_012D / 0x6A9D)
    ES = UInt16[DS, 0x5408];
    CheckExternalEvents(cs3, 0x137);
    // CMP word ptr ES:[0x4fba],0x0 (0697_0131 / 0x6AA1)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs3, 0x139);
    // JNZ 0x0000:6ab4 (0697_0137 / 0x6AA7)
    if(!ZeroFlag) {
      goto label_0697_0144_06AB4;
    }
    CheckExternalEvents(cs3, 0x13B);
    // SUB AX,AX (0697_0139 / 0x6AA9)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs3, 0x13C);
    // PUSH AX (0697_013B / 0x6AAB)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x141);
    // CALLF 0x1000:aa97 (0697_013C / 0x6AAC)
    FarCall(cs3, 0x141, ghidra_guess_1000_AA97_1AA97);
    CheckExternalEvents(cs3, 0x144);
    // ADD SP,0x2 (0697_0141 / 0x6AB1)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0697_0144_06AB4:
    CheckExternalEvents(cs3, 0x147);
    // MOV AX,0x230 (0697_0144 / 0x6AB4)
    AX = 0x230;
    CheckExternalEvents(cs3, 0x14A);
    // MOV DX,0x2958 (0697_0147 / 0x6AB7)
    DX = 0x2958;
    CheckExternalEvents(cs3, 0x14B);
    // PUSH DX (0697_014A / 0x6ABA)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x14C);
    // PUSH AX (0697_014B / 0x6ABB)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x151);
    // CALLF 0x1000:9fc1 (0697_014C / 0x6ABC)
    FarCall(cs3, 0x151, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs3, 0x154);
    // ADD SP,0x4 (0697_0151 / 0x6AC1)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs3, 0x157);
    // MOV AX,0x4614 (0697_0154 / 0x6AC4)
    AX = 0x4614;
    CheckExternalEvents(cs3, 0x15A);
    // MOV DX,0x2a02 (0697_0157 / 0x6AC7)
    DX = 0x2A02;
    CheckExternalEvents(cs3, 0x15B);
    // PUSH DX (0697_015A / 0x6ACA)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x15C);
    // PUSH AX (0697_015B / 0x6ACB)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x15F);
    // MOV AX,0xca2 (0697_015C / 0x6ACC)
    AX = 0xCA2;
    CheckExternalEvents(cs3, 0x160);
    // PUSH DS (0697_015F / 0x6ACF)
    Stack.Push16(DS);
    CheckExternalEvents(cs3, 0x161);
    // PUSH AX (0697_0160 / 0x6AD0)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x166);
    // CALLF 0x1000:910b (0697_0161 / 0x6AD1)
    FarCall(cs3, 0x166, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs3, 0x169);
    // ADD SP,0x8 (0697_0166 / 0x6AD6)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs3, 0x16C);
    // MOV AX,0x244b (0697_0169 / 0x6AD9)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x16F);
    // MOV DX,0x1ddc (0697_016C / 0x6ADC)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x170);
    // PUSH DX (0697_016F / 0x6ADF)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x171);
    // PUSH AX (0697_0170 / 0x6AE0)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x174);
    // MOV AX,0x4614 (0697_0171 / 0x6AE1)
    AX = 0x4614;
    CheckExternalEvents(cs3, 0x177);
    // MOV DX,0x2a02 (0697_0174 / 0x6AE4)
    DX = 0x2A02;
    CheckExternalEvents(cs3, 0x178);
    // PUSH DX (0697_0177 / 0x6AE7)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x179);
    // PUSH AX (0697_0178 / 0x6AE8)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x17E);
    // CALLF 0x1000:8f6d (0697_0179 / 0x6AE9)
    FarCall(cs3, 0x17E, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs3, 0x181);
    // ADD SP,0x8 (0697_017E / 0x6AEE)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs3, 0x185);
    // MOV ES,word ptr [0x5408] (0697_0181 / 0x6AF1)
    ES = UInt16[DS, 0x5408];
    CheckExternalEvents(cs3, 0x18B);
    // CMP word ptr ES:[0x4fba],0x2 (0697_0185 / 0x6AF5)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs3, 0x18D);
    // JNZ 0x0000:6b11 (0697_018B / 0x6AFB)
    if(!ZeroFlag) {
      goto label_0697_01A1_06B11;
    }
    CheckExternalEvents(cs3, 0x190);
    // MOV AX,0xa800 (0697_018D / 0x6AFD)
    AX = 0xA800;
    CheckExternalEvents(cs3, 0x191);
    // PUSH AX (0697_0190 / 0x6B00)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x194);
    // MOV AX,0x244b (0697_0191 / 0x6B01)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x197);
    // MOV DX,0x1ddc (0697_0194 / 0x6B04)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x198);
    // PUSH DX (0697_0197 / 0x6B07)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x199);
    // PUSH AX (0697_0198 / 0x6B08)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x19E);
    // CALLF 0x1000:a150 (0697_0199 / 0x6B09)
    FarCall(cs3, 0x19E, ghidra_guess_1000_A150_1A150);
    CheckExternalEvents(cs3, 0x1A1);
    // ADD SP,0x6 (0697_019E / 0x6B0E)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    label_0697_01A1_06B11:
    CheckExternalEvents(cs3, 0x1A5);
    // MOV ES,word ptr [0x5408] (0697_01A1 / 0x6B11)
    ES = UInt16[DS, 0x5408];
    CheckExternalEvents(cs3, 0x1AB);
    // CMP word ptr ES:[0x4fba],0x3 (0697_01A5 / 0x6B15)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x3);
    CheckExternalEvents(cs3, 0x1AD);
    // JZ 0x0000:6b25 (0697_01AB / 0x6B1B)
    if(ZeroFlag) {
      goto label_0697_01B5_06B25;
    }
    CheckExternalEvents(cs3, 0x1B0);
    // MOV AX,0x0 (0697_01AD / 0x6B1D)
    AX = 0x0;
    CheckExternalEvents(cs3, 0x1B3);
    // MOV DX,0x2958 (0697_01B0 / 0x6B20)
    DX = 0x2958;
    CheckExternalEvents(cs3, 0x1B5);
    // JMP 0x0000:6b2b (0697_01B3 / 0x6B23)
    goto label_0697_01BB_06B2B;
    label_0697_01B5_06B25:
    CheckExternalEvents(cs3, 0x1B8);
    // MOV AX,0x10 (0697_01B5 / 0x6B25)
    AX = 0x10;
    CheckExternalEvents(cs3, 0x1BB);
    // MOV DX,0x2958 (0697_01B8 / 0x6B28)
    DX = 0x2958;
    label_0697_01BB_06B2B:
    CheckExternalEvents(cs3, 0x1BC);
    // PUSH DX (0697_01BB / 0x6B2B)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x1BD);
    // PUSH AX (0697_01BC / 0x6B2C)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x1C2);
    // CALLF 0x1000:8ff5 (0697_01BD / 0x6B2D)
    FarCall(cs3, 0x1C2, unknown_18AD_0525_18FF5);
    CheckExternalEvents(cs3, 0x1C5);
    // ADD SP,0x4 (0697_01C2 / 0x6B32)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs3, 0x1C8);
    // MOV AX,0xc8 (0697_01C5 / 0x6B35)
    AX = 0xC8;
    CheckExternalEvents(cs3, 0x1C9);
    // PUSH AX (0697_01C8 / 0x6B38)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x1CC);
    // MOV AX,0x28 (0697_01C9 / 0x6B39)
    AX = 0x28;
    CheckExternalEvents(cs3, 0x1CD);
    // PUSH AX (0697_01CC / 0x6B3C)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x1CF);
    // SUB AX,AX (0697_01CD / 0x6B3D)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs3, 0x1D0);
    // PUSH AX (0697_01CF / 0x6B3F)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x1D1);
    // PUSH AX (0697_01D0 / 0x6B40)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x1D4);
    // MOV AX,0x244b (0697_01D1 / 0x6B41)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x1D7);
    // MOV DX,0x1ddc (0697_01D4 / 0x6B44)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x1D8);
    // PUSH DX (0697_01D7 / 0x6B47)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x1D9);
    // PUSH AX (0697_01D8 / 0x6B48)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x1DE);
    // CALLF 0x1000:8b56 (0697_01D9 / 0x6B49)
    FarCall(cs3, 0x1DE, unknown_18AD_0086_18B56);
    CheckExternalEvents(cs3, 0x1E1);
    // ADD SP,0xc (0697_01DE / 0x6B4E)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs3, 0x1E6);
    // CALLF 0x0000:412b (0697_01E1 / 0x6B51)
    FarCall(cs3, 0x1E6, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs3, 0x1EB);
    // MOV word ptr [BP + -0x2],0x2bc (0697_01E6 / 0x6B56)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x2BC;
    CheckExternalEvents(cs3, 0x1ED);
    // JMP 0x0000:6b77 (0697_01EB / 0x6B5B)
    goto label_0697_0207_06B77;
    label_0697_01ED_06B5D:
    CheckExternalEvents(cs3, 0x1F0);
    // MOV AX,0x1 (0697_01ED / 0x6B5D)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x1F1);
    // PUSH AX (0697_01F0 / 0x6B60)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x1F6);
    // CALLF 0x1000:8ad6 (0697_01F1 / 0x6B61)
    FarCall(cs3, 0x1F6, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs3, 0x1F9);
    // ADD SP,0x2 (0697_01F6 / 0x6B66)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs3, 0x1FE);
    // CALLF 0x1000:8aff (0697_01F9 / 0x6B69)
    FarCall(cs3, 0x1FE, unknown_18AD_002F_18AFF);
    CheckExternalEvents(cs3, 0x200);
    // OR AX,AX (0697_01FE / 0x6B6E)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs3, 0x202);
    // JZ 0x0000:6b77 (0697_0200 / 0x6B70)
    if(ZeroFlag) {
      goto label_0697_0207_06B77;
    }
    CheckExternalEvents(cs3, 0x207);
    // MOV word ptr [BP + -0x2],0x0 (0697_0202 / 0x6B72)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0697_0207_06B77:
    CheckExternalEvents(cs3, 0x20A);
    // MOV AX,word ptr [BP + -0x2] (0697_0207 / 0x6B77)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs3, 0x20D);
    // DEC word ptr [BP + -0x2] (0697_020A / 0x6B7A)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Dec16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs3, 0x20F);
    // OR AX,AX (0697_020D / 0x6B7D)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs3, 0x211);
    // JNZ 0x0000:6b5d (0697_020F / 0x6B7F)
    if(!ZeroFlag) {
      goto label_0697_01ED_06B5D;
    }
    CheckExternalEvents(cs3, 0x216);
    // CALLF 0x0000:412b (0697_0211 / 0x6B81)
    FarCall(cs3, 0x216, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs3, 0x21B);
    // CALLF 0x0000:5da7 (0697_0216 / 0x6B86)
    FarCall(cs3, 0x21B, unknown_0170_46A7_05DA7);
    CheckExternalEvents(cs3, 0x21E);
    // MOV AX,0x130 (0697_021B / 0x6B8B)
    AX = 0x130;
    CheckExternalEvents(cs3, 0x221);
    // MOV DX,0x2958 (0697_021E / 0x6B8E)
    DX = 0x2958;
    CheckExternalEvents(cs3, 0x222);
    // PUSH DX (0697_0221 / 0x6B91)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x223);
    // PUSH AX (0697_0222 / 0x6B92)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x228);
    // CALLF 0x1000:9fc1 (0697_0223 / 0x6B93)
    FarCall(cs3, 0x228, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs3, 0x22B);
    // ADD SP,0x4 (0697_0228 / 0x6B98)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs3, 0x22E);
    // MOV AX,0x4614 (0697_022B / 0x6B9B)
    AX = 0x4614;
    CheckExternalEvents(cs3, 0x231);
    // MOV DX,0x2a02 (0697_022E / 0x6B9E)
    DX = 0x2A02;
    CheckExternalEvents(cs3, 0x232);
    // PUSH DX (0697_0231 / 0x6BA1)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x233);
    // PUSH AX (0697_0232 / 0x6BA2)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x236);
    // MOV AX,0xcae (0697_0233 / 0x6BA3)
    AX = 0xCAE;
    CheckExternalEvents(cs3, 0x237);
    // PUSH DS (0697_0236 / 0x6BA6)
    Stack.Push16(DS);
    CheckExternalEvents(cs3, 0x238);
    // PUSH AX (0697_0237 / 0x6BA7)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x23D);
    // CALLF 0x1000:910b (0697_0238 / 0x6BA8)
    FarCall(cs3, 0x23D, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs3, 0x240);
    // ADD SP,0x8 (0697_023D / 0x6BAD)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs3, 0x243);
    // MOV AX,0x244b (0697_0240 / 0x6BB0)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x246);
    // MOV DX,0x1ddc (0697_0243 / 0x6BB3)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x247);
    // PUSH DX (0697_0246 / 0x6BB6)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x248);
    // PUSH AX (0697_0247 / 0x6BB7)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x24B);
    // MOV AX,0x4614 (0697_0248 / 0x6BB8)
    AX = 0x4614;
    CheckExternalEvents(cs3, 0x24E);
    // MOV DX,0x2a02 (0697_024B / 0x6BBB)
    DX = 0x2A02;
    CheckExternalEvents(cs3, 0x24F);
    // PUSH DX (0697_024E / 0x6BBE)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x250);
    // PUSH AX (0697_024F / 0x6BBF)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x255);
    // CALLF 0x1000:8f6d (0697_0250 / 0x6BC0)
    FarCall(cs3, 0x255, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs3, 0x258);
    // ADD SP,0x8 (0697_0255 / 0x6BC5)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs3, 0x25C);
    // MOV ES,word ptr [0x5408] (0697_0258 / 0x6BC8)
    ES = UInt16[DS, 0x5408];
    CheckExternalEvents(cs3, 0x262);
    // CMP word ptr ES:[0x4fba],0x2 (0697_025C / 0x6BCC)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs3, 0x264);
    // JNZ 0x0000:6be8 (0697_0262 / 0x6BD2)
    if(!ZeroFlag) {
      goto label_0697_0278_06BE8;
    }
    CheckExternalEvents(cs3, 0x267);
    // MOV AX,0xa800 (0697_0264 / 0x6BD4)
    AX = 0xA800;
    CheckExternalEvents(cs3, 0x268);
    // PUSH AX (0697_0267 / 0x6BD7)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x26B);
    // MOV AX,0x244b (0697_0268 / 0x6BD8)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x26E);
    // MOV DX,0x1ddc (0697_026B / 0x6BDB)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x26F);
    // PUSH DX (0697_026E / 0x6BDE)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x270);
    // PUSH AX (0697_026F / 0x6BDF)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x275);
    // CALLF 0x1000:a150 (0697_0270 / 0x6BE0)
    FarCall(cs3, 0x275, ghidra_guess_1000_A150_1A150);
    CheckExternalEvents(cs3, 0x278);
    // ADD SP,0x6 (0697_0275 / 0x6BE5)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    label_0697_0278_06BE8:
    CheckExternalEvents(cs3, 0x27B);
    // MOV AX,0x8 (0697_0278 / 0x6BE8)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x27C);
    // PUSH AX (0697_027B / 0x6BEB)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x27E);
    // SUB AX,AX (0697_027C / 0x6BEC)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs3, 0x27F);
    // PUSH AX (0697_027E / 0x6BEE)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x280);
    // PUSH AX (0697_027F / 0x6BEF)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x283);
    // MOV AX,0x244b (0697_0280 / 0x6BF0)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x286);
    // MOV DX,0x1ddc (0697_0283 / 0x6BF3)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x287);
    // PUSH DX (0697_0286 / 0x6BF6)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x288);
    // PUSH AX (0697_0287 / 0x6BF7)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x28D);
    // CALLF 0x1000:8745 (0697_0288 / 0x6BF8)
    FarCall(cs3, 0x28D, unknown_17C6_0AE5_18745);
    CheckExternalEvents(cs3, 0x290);
    // ADD SP,0xa (0697_028D / 0x6BFD)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x294);
    // MOV ES,word ptr [0x540e] (0697_0290 / 0x6C00)
    ES = UInt16[DS, 0x540E];
    CheckExternalEvents(cs3, 0x298);
    // MOV ES:[0x4066],AX (0697_0294 / 0x6C04)
    UInt16[ES, 0x4066] = AX;
    CheckExternalEvents(cs3, 0x29D);
    // MOV word ptr ES:[0x4068],DX (0697_0298 / 0x6C08)
    UInt16[ES, 0x4068] = DX;
    CheckExternalEvents(cs3, 0x2A0);
    // MOV AX,0x190 (0697_029D / 0x6C0D)
    AX = 0x190;
    CheckExternalEvents(cs3, 0x2A3);
    // MOV DX,0x2958 (0697_02A0 / 0x6C10)
    DX = 0x2958;
    CheckExternalEvents(cs3, 0x2A4);
    // PUSH DX (0697_02A3 / 0x6C13)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x2A5);
    // PUSH AX (0697_02A4 / 0x6C14)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x2AA);
    // CALLF 0x1000:9fc1 (0697_02A5 / 0x6C15)
    FarCall(cs3, 0x2AA, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs3, 0x2AD);
    // ADD SP,0x4 (0697_02AA / 0x6C1A)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs3, 0x2B0);
    // MOV AX,0x4614 (0697_02AD / 0x6C1D)
    AX = 0x4614;
    CheckExternalEvents(cs3, 0x2B3);
    // MOV DX,0x2a02 (0697_02B0 / 0x6C20)
    DX = 0x2A02;
    CheckExternalEvents(cs3, 0x2B4);
    // PUSH DX (0697_02B3 / 0x6C23)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x2B5);
    // PUSH AX (0697_02B4 / 0x6C24)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x2B8);
    // MOV AX,0xcbb (0697_02B5 / 0x6C25)
    AX = 0xCBB;
    CheckExternalEvents(cs3, 0x2B9);
    // PUSH DS (0697_02B8 / 0x6C28)
    Stack.Push16(DS);
    CheckExternalEvents(cs3, 0x2BA);
    // PUSH AX (0697_02B9 / 0x6C29)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x2BF);
    // CALLF 0x1000:910b (0697_02BA / 0x6C2A)
    FarCall(cs3, 0x2BF, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs3, 0x2C2);
    // ADD SP,0x8 (0697_02BF / 0x6C2F)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs3, 0x2C5);
    // MOV AX,0x244b (0697_02C2 / 0x6C32)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x2C8);
    // MOV DX,0x1ddc (0697_02C5 / 0x6C35)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x2C9);
    // PUSH DX (0697_02C8 / 0x6C38)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x2CA);
    // PUSH AX (0697_02C9 / 0x6C39)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x2CD);
    // MOV AX,0x4614 (0697_02CA / 0x6C3A)
    AX = 0x4614;
    CheckExternalEvents(cs3, 0x2D0);
    // MOV DX,0x2a02 (0697_02CD / 0x6C3D)
    DX = 0x2A02;
    CheckExternalEvents(cs3, 0x2D1);
    // PUSH DX (0697_02D0 / 0x6C40)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x2D2);
    // PUSH AX (0697_02D1 / 0x6C41)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x2D7);
    // CALLF 0x1000:8f6d (0697_02D2 / 0x6C42)
    FarCall(cs3, 0x2D7, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs3, 0x2DA);
    // ADD SP,0x8 (0697_02D7 / 0x6C47)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs3, 0x2DE);
    // MOV ES,word ptr [0x5408] (0697_02DA / 0x6C4A)
    ES = UInt16[DS, 0x5408];
    CheckExternalEvents(cs3, 0x2E4);
    // CMP word ptr ES:[0x4fba],0x2 (0697_02DE / 0x6C4E)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs3, 0x2E6);
    // JNZ 0x0000:6c6a (0697_02E4 / 0x6C54)
    if(!ZeroFlag) {
      goto label_0697_02FA_06C6A;
    }
    CheckExternalEvents(cs3, 0x2E9);
    // MOV AX,0xa800 (0697_02E6 / 0x6C56)
    AX = 0xA800;
    CheckExternalEvents(cs3, 0x2EA);
    // PUSH AX (0697_02E9 / 0x6C59)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x2ED);
    // MOV AX,0x244b (0697_02EA / 0x6C5A)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x2F0);
    // MOV DX,0x1ddc (0697_02ED / 0x6C5D)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x2F1);
    // PUSH DX (0697_02F0 / 0x6C60)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x2F2);
    // PUSH AX (0697_02F1 / 0x6C61)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x2F7);
    // CALLF 0x1000:a150 (0697_02F2 / 0x6C62)
    FarCall(cs3, 0x2F7, ghidra_guess_1000_A150_1A150);
    CheckExternalEvents(cs3, 0x2FA);
    // ADD SP,0x6 (0697_02F7 / 0x6C67)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    label_0697_02FA_06C6A:
    CheckExternalEvents(cs3, 0x2FD);
    // MOV AX,0x42 (0697_02FA / 0x6C6A)
    AX = 0x42;
    CheckExternalEvents(cs3, 0x2FE);
    // PUSH AX (0697_02FD / 0x6C6D)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x300);
    // SUB AX,AX (0697_02FE / 0x6C6E)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs3, 0x301);
    // PUSH AX (0697_0300 / 0x6C70)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x302);
    // PUSH AX (0697_0301 / 0x6C71)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x305);
    // MOV AX,0x244b (0697_0302 / 0x6C72)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x308);
    // MOV DX,0x1ddc (0697_0305 / 0x6C75)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x309);
    // PUSH DX (0697_0308 / 0x6C78)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x30A);
    // PUSH AX (0697_0309 / 0x6C79)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x30F);
    // CALLF 0x1000:8745 (0697_030A / 0x6C7A)
    FarCall(cs3, 0x30F, unknown_17C6_0AE5_18745);
    CheckExternalEvents(cs3, 0x312);
    // ADD SP,0xa (0697_030F / 0x6C7F)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x316);
    // MOV ES,word ptr [0x5410] (0697_0312 / 0x6C82)
    ES = UInt16[DS, 0x5410];
    CheckExternalEvents(cs3, 0x31A);
    // MOV ES:[0x4588],AX (0697_0316 / 0x6C86)
    UInt16[ES, 0x4588] = AX;
    CheckExternalEvents(cs3, 0x31F);
    // MOV word ptr ES:[0x458a],DX (0697_031A / 0x6C8A)
    UInt16[ES, 0x458A] = DX;
    CheckExternalEvents(cs3, 0x322);
    // MOV AX,0x170 (0697_031F / 0x6C8F)
    AX = 0x170;
    CheckExternalEvents(cs3, 0x325);
    // MOV DX,0x2958 (0697_0322 / 0x6C92)
    DX = 0x2958;
    CheckExternalEvents(cs3, 0x326);
    // PUSH DX (0697_0325 / 0x6C95)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x327);
    // PUSH AX (0697_0326 / 0x6C96)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x32C);
    // CALLF 0x1000:9fc1 (0697_0327 / 0x6C97)
    FarCall(cs3, 0x32C, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs3, 0x32F);
    // ADD SP,0x4 (0697_032C / 0x6C9C)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs3, 0x332);
    // MOV AX,0x4614 (0697_032F / 0x6C9F)
    AX = 0x4614;
    CheckExternalEvents(cs3, 0x335);
    // MOV DX,0x2a02 (0697_0332 / 0x6CA2)
    DX = 0x2A02;
    CheckExternalEvents(cs3, 0x336);
    // PUSH DX (0697_0335 / 0x6CA5)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x337);
    // PUSH AX (0697_0336 / 0x6CA6)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x33A);
    // MOV AX,0xcc8 (0697_0337 / 0x6CA7)
    AX = 0xCC8;
    CheckExternalEvents(cs3, 0x33B);
    // PUSH DS (0697_033A / 0x6CAA)
    Stack.Push16(DS);
    CheckExternalEvents(cs3, 0x33C);
    // PUSH AX (0697_033B / 0x6CAB)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x341);
    // CALLF 0x1000:910b (0697_033C / 0x6CAC)
    FarCall(cs3, 0x341, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs3, 0x344);
    // ADD SP,0x8 (0697_0341 / 0x6CB1)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs3, 0x349);
    // MOV word ptr [BP + -0xa],0x0 (0697_0344 / 0x6CB4)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs3, 0x34D);
    // MOV ES,word ptr [0x5408] (0697_0349 / 0x6CB9)
    ES = UInt16[DS, 0x5408];
    CheckExternalEvents(cs3, 0x353);
    // CMP word ptr ES:[0x4fba],0x0 (0697_034D / 0x6CBD)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs3, 0x355);
    // JNZ 0x0000:6cdd (0697_0353 / 0x6CC3)
    if(!ZeroFlag) {
      goto label_0697_036D_06CDD;
    }
    CheckExternalEvents(cs3, 0x35A);
    // MOV word ptr [BP + -0xa],0x1 (0697_0355 / 0x6CC5)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x1;
    CheckExternalEvents(cs3, 0x361);
    // MOV word ptr ES:[0x4fba],0x1 (0697_035A / 0x6CCA)
    UInt16[ES, 0x4FBA] = 0x1;
    CheckExternalEvents(cs3, 0x364);
    // MOV AX,0x1 (0697_0361 / 0x6CD1)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x365);
    // PUSH AX (0697_0364 / 0x6CD4)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x36A);
    // CALLF 0x1000:cbd1 (0697_0365 / 0x6CD5)
    FarCall(cs3, 0x36A, unknown_19EF_2CE1_1CBD1);
    CheckExternalEvents(cs3, 0x36D);
    // ADD SP,0x2 (0697_036A / 0x6CDA)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0697_036D_06CDD:
    CheckExternalEvents(cs3, 0x370);
    // MOV AX,0x244b (0697_036D / 0x6CDD)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x373);
    // MOV DX,0x1ddc (0697_0370 / 0x6CE0)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x374);
    // PUSH DX (0697_0373 / 0x6CE3)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x375);
    // PUSH AX (0697_0374 / 0x6CE4)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x378);
    // MOV AX,0x4614 (0697_0375 / 0x6CE5)
    AX = 0x4614;
    CheckExternalEvents(cs3, 0x37B);
    // MOV DX,0x2a02 (0697_0378 / 0x6CE8)
    DX = 0x2A02;
    CheckExternalEvents(cs3, 0x37C);
    // PUSH DX (0697_037B / 0x6CEB)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x37D);
    // PUSH AX (0697_037C / 0x6CEC)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x382);
    // CALLF 0x1000:8f6d (0697_037D / 0x6CED)
    FarCall(cs3, 0x382, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs3, 0x385);
    // ADD SP,0x8 (0697_0382 / 0x6CF2)
    SP += 0x8;
    CheckExternalEvents(cs3, 0x389);
    // CMP word ptr [BP + -0xa],0x0 (0697_0385 / 0x6CF5)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xA)], 0x0);
    CheckExternalEvents(cs3, 0x38B);
    // JZ 0x0000:6d59 (0697_0389 / 0x6CF9)
    if(ZeroFlag) {
      goto label_0697_03E9_06D59;
    }
    CheckExternalEvents(cs3, 0x38E);
    // MOV AX,0x3e80 (0697_038B / 0x6CFB)
    AX = 0x3E80;
    CheckExternalEvents(cs3, 0x38F);
    // PUSH AX (0697_038E / 0x6CFE)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x392);
    // MOV AX,0x4614 (0697_038F / 0x6CFF)
    AX = 0x4614;
    CheckExternalEvents(cs3, 0x395);
    // MOV DX,0x2a02 (0697_0392 / 0x6D02)
    DX = 0x2A02;
    CheckExternalEvents(cs3, 0x396);
    // PUSH DX (0697_0395 / 0x6D05)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x397);
    // PUSH AX (0697_0396 / 0x6D06)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x39A);
    // MOV AX,0x244b (0697_0397 / 0x6D07)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x39D);
    // MOV DX,0x1ddc (0697_039A / 0x6D0A)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x39E);
    // PUSH DX (0697_039D / 0x6D0D)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x39F);
    // PUSH AX (0697_039E / 0x6D0E)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x3A4);
    // CALLF 0x1000:a966 (0697_039F / 0x6D0F)
    FarCall(cs3, 0x3A4, unknown_19EF_0A76_1A966);
    CheckExternalEvents(cs3, 0x3A7);
    // ADD SP,0xa (0697_03A4 / 0x6D14)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x3AB);
    // MOV ES,word ptr [0x5408] (0697_03A7 / 0x6D17)
    ES = UInt16[DS, 0x5408];
    CheckExternalEvents(cs3, 0x3B2);
    // MOV word ptr ES:[0x4fba],0x0 (0697_03AB / 0x6D1B)
    UInt16[ES, 0x4FBA] = 0x0;
    CheckExternalEvents(cs3, 0x3B4);
    // SUB AX,AX (0697_03B2 / 0x6D22)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs3, 0x3B5);
    // PUSH AX (0697_03B4 / 0x6D24)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x3BA);
    // CALLF 0x1000:cbd1 (0697_03B5 / 0x6D25)
    FarCall(cs3, 0x3BA, unknown_19EF_2CE1_1CBD1);
    CheckExternalEvents(cs3, 0x3BD);
    // ADD SP,0x2 (0697_03BA / 0x6D2A)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs3, 0x3C0);
    // MOV AX,0x3e80 (0697_03BD / 0x6D2D)
    AX = 0x3E80;
    CheckExternalEvents(cs3, 0x3C1);
    // PUSH AX (0697_03C0 / 0x6D30)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x3C4);
    // MOV AX,0x50 (0697_03C1 / 0x6D31)
    AX = 0x50;
    CheckExternalEvents(cs3, 0x3C5);
    // PUSH AX (0697_03C4 / 0x6D34)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x3C8);
    // MOV AX,0x244b (0697_03C5 / 0x6D35)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x3CB);
    // MOV DX,0x1ddc (0697_03C8 / 0x6D38)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x3CC);
    // PUSH DX (0697_03CB / 0x6D3B)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x3CD);
    // PUSH AX (0697_03CC / 0x6D3C)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x3CE);
    // PUSH DX (0697_03CD / 0x6D3D)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x3CF);
    // PUSH AX (0697_03CE / 0x6D3E)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x3D4);
    // CALLF 0x1000:a053 (0697_03CF / 0x6D3F)
    FarCall(cs3, 0x3D4, ghidra_guess_1000_A053_1A053);
    CheckExternalEvents(cs3, 0x3D7);
    // ADD SP,0xc (0697_03D4 / 0x6D44)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs3, 0x3DA);
    // MOV AX,0x4614 (0697_03D7 / 0x6D47)
    AX = 0x4614;
    CheckExternalEvents(cs3, 0x3DD);
    // MOV DX,0x2a02 (0697_03DA / 0x6D4A)
    DX = 0x2A02;
    CheckExternalEvents(cs3, 0x3DE);
    // PUSH DX (0697_03DD / 0x6D4D)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x3DF);
    // PUSH AX (0697_03DE / 0x6D4E)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x3E0);
    // PUSH DX (0697_03DF / 0x6D4F)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x3E1);
    // PUSH AX (0697_03E0 / 0x6D50)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x3E6);
    // CALLF 0x1000:a916 (0697_03E1 / 0x6D51)
    FarCall(cs3, 0x3E6, ghidra_guess_1000_A916_1A916);
    CheckExternalEvents(cs3, 0x3E9);
    // ADD SP,0x8 (0697_03E6 / 0x6D56)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    label_0697_03E9_06D59:
    CheckExternalEvents(cs3, 0x3ED);
    // MOV ES,word ptr [0x5408] (0697_03E9 / 0x6D59)
    ES = UInt16[DS, 0x5408];
    CheckExternalEvents(cs3, 0x3F3);
    // CMP word ptr ES:[0x4fba],0x2 (0697_03ED / 0x6D5D)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs3, 0x3F5);
    // JNZ 0x0000:6d7b (0697_03F3 / 0x6D63)
    if(!ZeroFlag) {
      goto label_0697_040B_06D7B;
    }
    CheckExternalEvents(cs3, 0x3F8);
    // MOV AX,0x3e80 (0697_03F5 / 0x6D65)
    AX = 0x3E80;
    CheckExternalEvents(cs3, 0x3F9);
    // PUSH AX (0697_03F8 / 0x6D68)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x3FC);
    // MOV AX,0x244b (0697_03F9 / 0x6D69)
    AX = 0x244B;
    CheckExternalEvents(cs3, 0x3FF);
    // MOV DX,0x1ddc (0697_03FC / 0x6D6C)
    DX = 0x1DDC;
    CheckExternalEvents(cs3, 0x400);
    // PUSH DX (0697_03FF / 0x6D6F)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x401);
    // PUSH AX (0697_0400 / 0x6D70)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x402);
    // PUSH DX (0697_0401 / 0x6D71)
    Stack.Push16(DX);
    CheckExternalEvents(cs3, 0x403);
    // PUSH AX (0697_0402 / 0x6D72)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x408);
    // CALLF 0x1000:a462 (0697_0403 / 0x6D73)
    FarCall(cs3, 0x408, ghidra_guess_1000_A462_1A462);
    CheckExternalEvents(cs3, 0x40B);
    // ADD SP,0xa (0697_0408 / 0x6D78)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    label_0697_040B_06D7B:
    CheckExternalEvents(cs3, 0x410);
    // MOV word ptr [BP + -0xe],0x0 (0697_040B / 0x6D7B)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    label_0697_0410_06D80:
    CheckExternalEvents(cs3, 0x413);
    // MOV AX,0x18 (0697_0410 / 0x6D80)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x414);
    // PUSH AX (0697_0413 / 0x6D83)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x417);
    // MOV AX,0x3 (0697_0414 / 0x6D84)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x418);
    // PUSH AX (0697_0417 / 0x6D87)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x41A);
    // SUB AX,AX (0697_0418 / 0x6D88)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs3, 0x41B);
    // PUSH AX (0697_041A / 0x6D8A)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x41E);
    // MOV AX,0x3 (0697_041B / 0x6D8B)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x421);
    // IMUL word ptr [BP + -0xe] (0697_041E / 0x6D8E)
    int resImul0697_041E = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0697_041E);
    DX = (ushort)(resImul0697_041E >> 16);
    CheckExternalEvents(cs3, 0x422);
    // PUSH AX (0697_0421 / 0x6D91)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x425);
    // PUSH word ptr [BP + -0xe] (0697_0422 / 0x6D92)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs3, 0x42A);
    // CALLF 0x1000:91da (0697_0425 / 0x6D95)
    FarCall(cs3, 0x42A, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x42D);
    // ADD SP,0xa (0697_042A / 0x6D9A)
    SP += 0xA;
    CheckExternalEvents(cs3, 0x430);
    // INC word ptr [BP + -0xe] (0697_042D / 0x6D9D)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs3, 0x434);
    // CMP word ptr [BP + -0xe],0xc (0697_0430 / 0x6DA0)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0xC);
    CheckExternalEvents(cs3, 0x436);
    // JL 0x0000:6d80 (0697_0434 / 0x6DA4)
    if(SignFlag != OverflowFlag) {
      goto label_0697_0410_06D80;
    }
    CheckExternalEvents(cs3, 0x43B);
    // MOV word ptr [BP + -0xe],0xc (0697_0436 / 0x6DA6)
    UInt16[SS, (ushort)(BP - 0xE)] = 0xC;
    label_0697_043B_06DAB:
    CheckExternalEvents(cs3, 0x43E);
    // MOV AX,0x18 (0697_043B / 0x6DAB)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x43F);
    // PUSH AX (0697_043E / 0x6DAE)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x442);
    // MOV AX,0x3 (0697_043F / 0x6DAF)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x443);
    // PUSH AX (0697_0442 / 0x6DB2)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x446);
    // MOV AX,0x18 (0697_0443 / 0x6DB3)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x447);
    // PUSH AX (0697_0446 / 0x6DB6)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x44A);
    // MOV AX,0x3 (0697_0447 / 0x6DB7)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x44D);
    // IMUL word ptr [BP + -0xe] (0697_044A / 0x6DBA)
    int resImul0697_044A = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0697_044A);
    DX = (ushort)(resImul0697_044A >> 16);
    CheckExternalEvents(cs3, 0x450);
    // SUB AX,0x24 (0697_044D / 0x6DBD)
    // AX -= 0x24;
    AX = Alu.Sub16(AX, 0x24);
    CheckExternalEvents(cs3, 0x451);
    // PUSH AX (0697_0450 / 0x6DC0)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x454);
    // PUSH word ptr [BP + -0xe] (0697_0451 / 0x6DC1)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs3, 0x459);
    // CALLF 0x1000:91da (0697_0454 / 0x6DC4)
    FarCall(cs3, 0x459, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x45C);
    // ADD SP,0xa (0697_0459 / 0x6DC9)
    SP += 0xA;
    CheckExternalEvents(cs3, 0x45F);
    // INC word ptr [BP + -0xe] (0697_045C / 0x6DCC)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs3, 0x463);
    // CMP word ptr [BP + -0xe],0x10 (0697_045F / 0x6DCF)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x10);
    CheckExternalEvents(cs3, 0x465);
    // JL 0x0000:6dab (0697_0463 / 0x6DD3)
    if(SignFlag != OverflowFlag) {
      goto label_0697_043B_06DAB;
    }
    CheckExternalEvents(cs3, 0x46A);
    // MOV word ptr [BP + -0xe],0x10 (0697_0465 / 0x6DD5)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x10;
    label_0697_046A_06DDA:
    CheckExternalEvents(cs3, 0x46D);
    // MOV AX,0x8 (0697_046A / 0x6DDA)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x46E);
    // PUSH AX (0697_046D / 0x6DDD)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x471);
    // MOV AX,0x1 (0697_046E / 0x6DDE)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x472);
    // PUSH AX (0697_0471 / 0x6DE1)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x475);
    // MOV AX,0x18 (0697_0472 / 0x6DE2)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x476);
    // PUSH AX (0697_0475 / 0x6DE5)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x479);
    // MOV AX,word ptr [BP + -0xe] (0697_0476 / 0x6DE6)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs3, 0x47C);
    // SUB AX,0x4 (0697_0479 / 0x6DE9)
    // AX -= 0x4;
    AX = Alu.Sub16(AX, 0x4);
    CheckExternalEvents(cs3, 0x47D);
    // PUSH AX (0697_047C / 0x6DEC)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x480);
    // PUSH word ptr [BP + -0xe] (0697_047D / 0x6DED)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs3, 0x485);
    // CALLF 0x1000:91da (0697_0480 / 0x6DF0)
    FarCall(cs3, 0x485, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x488);
    // ADD SP,0xa (0697_0485 / 0x6DF5)
    SP += 0xA;
    CheckExternalEvents(cs3, 0x48B);
    // INC word ptr [BP + -0xe] (0697_0488 / 0x6DF8)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs3, 0x48F);
    // CMP word ptr [BP + -0xe],0x24 (0697_048B / 0x6DFB)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x24);
    CheckExternalEvents(cs3, 0x491);
    // JL 0x0000:6dda (0697_048F / 0x6DFF)
    if(SignFlag != OverflowFlag) {
      goto label_0697_046A_06DDA;
    }
    CheckExternalEvents(cs3, 0x496);
    // MOV word ptr [BP + -0x16],0x9 (0697_0491 / 0x6E01)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x9;
    CheckExternalEvents(cs3, 0x498);
    // JMP 0x0000:6e3e (0697_0496 / 0x6E06)
    goto label_0697_04CE_06E3E;
    label_0697_0498_06E08:
    CheckExternalEvents(cs3, 0x49B);
    // INC word ptr [BP + -0xe] (0697_0498 / 0x6E08)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_0697_049B_06E0B:
    CheckExternalEvents(cs3, 0x49F);
    // CMP word ptr [BP + -0xe],0x18 (0697_049B / 0x6E0B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x18);
    CheckExternalEvents(cs3, 0x4A1);
    // JGE 0x0000:6e3b (0697_049F / 0x6E0F)
    if(SignFlag == OverflowFlag) {
      goto label_0697_04CB_06E3B;
    }
    CheckExternalEvents(cs3, 0x4A4);
    // MOV AX,0x8 (0697_04A1 / 0x6E11)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x4A5);
    // PUSH AX (0697_04A4 / 0x6E14)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x4A8);
    // MOV AX,0x1 (0697_04A5 / 0x6E15)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x4A9);
    // PUSH AX (0697_04A8 / 0x6E18)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x4AC);
    // MOV AX,word ptr [BP + -0x16] (0697_04A9 / 0x6E19)
    AX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs3, 0x4AE);
    // MOV CL,0x3 (0697_04AC / 0x6E1C)
    CL = 0x3;
    CheckExternalEvents(cs3, 0x4B0);
    // SHL AX,CL (0697_04AE / 0x6E1E)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs3, 0x4B1);
    // PUSH AX (0697_04B0 / 0x6E20)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x4B4);
    // PUSH word ptr [BP + -0xe] (0697_04B1 / 0x6E21)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs3, 0x4B7);
    // MOV AX,0xc (0697_04B4 / 0x6E24)
    AX = 0xC;
    CheckExternalEvents(cs3, 0x4BA);
    // IMUL word ptr [BP + -0x16] (0697_04B7 / 0x6E27)
    int resImul0697_04B7 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x16)]);
    AX = (ushort)(resImul0697_04B7);
    DX = (ushort)(resImul0697_04B7 >> 16);
    CheckExternalEvents(cs3, 0x4BD);
    // ADD AX,word ptr [BP + -0xe] (0697_04BA / 0x6E2A)
    AX += UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs3, 0x4C0);
    // SUB AX,0x54 (0697_04BD / 0x6E2D)
    // AX -= 0x54;
    AX = Alu.Sub16(AX, 0x54);
    CheckExternalEvents(cs3, 0x4C1);
    // PUSH AX (0697_04C0 / 0x6E30)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x4C6);
    // CALLF 0x1000:91da (0697_04C1 / 0x6E31)
    FarCall(cs3, 0x4C6, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x4C9);
    // ADD SP,0xa (0697_04C6 / 0x6E36)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x4CB);
    // JMP 0x0000:6e08 (0697_04C9 / 0x6E39)
    goto label_0697_0498_06E08;
    label_0697_04CB_06E3B:
    CheckExternalEvents(cs3, 0x4CE);
    // INC word ptr [BP + -0x16] (0697_04CB / 0x6E3B)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    label_0697_04CE_06E3E:
    CheckExternalEvents(cs3, 0x4D2);
    // CMP word ptr [BP + -0x16],0x10 (0697_04CE / 0x6E3E)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x10);
    CheckExternalEvents(cs3, 0x4D4);
    // JGE 0x0000:6e4b (0697_04D2 / 0x6E42)
    if(SignFlag == OverflowFlag) {
      goto label_0697_04DB_06E4B;
    }
    CheckExternalEvents(cs3, 0x4D9);
    // MOV word ptr [BP + -0xe],0xc (0697_04D4 / 0x6E44)
    UInt16[SS, (ushort)(BP - 0xE)] = 0xC;
    CheckExternalEvents(cs3, 0x4DB);
    // JMP 0x0000:6e0b (0697_04D9 / 0x6E49)
    goto label_0697_049B_06E0B;
    label_0697_04DB_06E4B:
    CheckExternalEvents(cs3, 0x4DE);
    // MOV AX,0x18 (0697_04DB / 0x6E4B)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x4DF);
    // PUSH AX (0697_04DE / 0x6E4E)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x4E2);
    // MOV AX,0x3 (0697_04DF / 0x6E4F)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x4E3);
    // PUSH AX (0697_04E2 / 0x6E52)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x4E6);
    // MOV AX,0x60 (0697_04E3 / 0x6E53)
    AX = 0x60;
    CheckExternalEvents(cs3, 0x4E7);
    // PUSH AX (0697_04E6 / 0x6E56)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x4E9);
    // SUB AX,AX (0697_04E7 / 0x6E57)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs3, 0x4EA);
    // PUSH AX (0697_04E9 / 0x6E59)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x4ED);
    // MOV AX,0x78 (0697_04EA / 0x6E5A)
    AX = 0x78;
    CheckExternalEvents(cs3, 0x4EE);
    // PUSH AX (0697_04ED / 0x6E5D)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x4F3);
    // CALLF 0x1000:91da (0697_04EE / 0x6E5E)
    FarCall(cs3, 0x4F3, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x4F6);
    // ADD SP,0xa (0697_04F3 / 0x6E63)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x4F9);
    // MOV AX,0x18 (0697_04F6 / 0x6E66)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x4FA);
    // PUSH AX (0697_04F9 / 0x6E69)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x4FD);
    // MOV AX,0x3 (0697_04FA / 0x6E6A)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x4FE);
    // PUSH AX (0697_04FD / 0x6E6D)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x501);
    // MOV AX,0x60 (0697_04FE / 0x6E6E)
    AX = 0x60;
    CheckExternalEvents(cs3, 0x502);
    // PUSH AX (0697_0501 / 0x6E71)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x505);
    // MOV AX,0x3 (0697_0502 / 0x6E72)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x506);
    // PUSH AX (0697_0505 / 0x6E75)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x509);
    // MOV AX,0x79 (0697_0506 / 0x6E76)
    AX = 0x79;
    CheckExternalEvents(cs3, 0x50A);
    // PUSH AX (0697_0509 / 0x6E79)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x50F);
    // CALLF 0x1000:91da (0697_050A / 0x6E7A)
    FarCall(cs3, 0x50F, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x512);
    // ADD SP,0xa (0697_050F / 0x6E7F)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x515);
    // MOV AX,0x18 (0697_0512 / 0x6E82)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x516);
    // PUSH AX (0697_0515 / 0x6E85)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x519);
    // MOV AX,0x3 (0697_0516 / 0x6E86)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x51A);
    // PUSH AX (0697_0519 / 0x6E89)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x51D);
    // MOV AX,0x78 (0697_051A / 0x6E8A)
    AX = 0x78;
    CheckExternalEvents(cs3, 0x51E);
    // PUSH AX (0697_051D / 0x6E8D)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x521);
    // MOV AX,0x9 (0697_051E / 0x6E8E)
    AX = 0x9;
    CheckExternalEvents(cs3, 0x522);
    // PUSH AX (0697_0521 / 0x6E91)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x525);
    // MOV AX,0x7a (0697_0522 / 0x6E92)
    AX = 0x7A;
    CheckExternalEvents(cs3, 0x526);
    // PUSH AX (0697_0525 / 0x6E95)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x52B);
    // CALLF 0x1000:91da (0697_0526 / 0x6E96)
    FarCall(cs3, 0x52B, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x52E);
    // ADD SP,0xa (0697_052B / 0x6E9B)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x531);
    // MOV AX,0x18 (0697_052E / 0x6E9E)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x532);
    // PUSH AX (0697_0531 / 0x6EA1)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x535);
    // MOV AX,0x3 (0697_0532 / 0x6EA2)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x536);
    // PUSH AX (0697_0535 / 0x6EA5)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x539);
    // MOV AX,0x78 (0697_0536 / 0x6EA6)
    AX = 0x78;
    CheckExternalEvents(cs3, 0x53A);
    // PUSH AX (0697_0539 / 0x6EA9)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x53D);
    // MOV AX,0x6 (0697_053A / 0x6EAA)
    AX = 0x6;
    CheckExternalEvents(cs3, 0x53E);
    // PUSH AX (0697_053D / 0x6EAD)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x541);
    // MOV AX,0x7b (0697_053E / 0x6EAE)
    AX = 0x7B;
    CheckExternalEvents(cs3, 0x542);
    // PUSH AX (0697_0541 / 0x6EB1)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x547);
    // CALLF 0x1000:91da (0697_0542 / 0x6EB2)
    FarCall(cs3, 0x547, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x54A);
    // ADD SP,0xa (0697_0547 / 0x6EB7)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x54D);
    // MOV AX,0xe (0697_054A / 0x6EBA)
    AX = 0xE;
    CheckExternalEvents(cs3, 0x54E);
    // PUSH AX (0697_054D / 0x6EBD)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x551);
    // MOV AX,0x2 (0697_054E / 0x6EBE)
    AX = 0x2;
    CheckExternalEvents(cs3, 0x552);
    // PUSH AX (0697_0551 / 0x6EC1)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x555);
    // MOV AX,0xa0 (0697_0552 / 0x6EC2)
    AX = 0xA0;
    CheckExternalEvents(cs3, 0x556);
    // PUSH AX (0697_0555 / 0x6EC5)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x559);
    // MOV AX,0x8 (0697_0556 / 0x6EC6)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x55A);
    // PUSH AX (0697_0559 / 0x6EC9)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x55D);
    // MOV AX,0x7c (0697_055A / 0x6ECA)
    AX = 0x7C;
    CheckExternalEvents(cs3, 0x55E);
    // PUSH AX (0697_055D / 0x6ECD)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x563);
    // CALLF 0x1000:91da (0697_055E / 0x6ECE)
    FarCall(cs3, 0x563, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x566);
    // ADD SP,0xa (0697_0563 / 0x6ED3)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x569);
    // MOV AX,0xe (0697_0566 / 0x6ED6)
    AX = 0xE;
    CheckExternalEvents(cs3, 0x56A);
    // PUSH AX (0697_0569 / 0x6ED9)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x56D);
    // MOV AX,0x2 (0697_056A / 0x6EDA)
    AX = 0x2;
    CheckExternalEvents(cs3, 0x56E);
    // PUSH AX (0697_056D / 0x6EDD)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x571);
    // MOV AX,0xa0 (0697_056E / 0x6EDE)
    AX = 0xA0;
    CheckExternalEvents(cs3, 0x572);
    // PUSH AX (0697_0571 / 0x6EE1)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x575);
    // MOV AX,0xa (0697_0572 / 0x6EE2)
    AX = 0xA;
    CheckExternalEvents(cs3, 0x576);
    // PUSH AX (0697_0575 / 0x6EE5)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x579);
    // MOV AX,0x7d (0697_0576 / 0x6EE6)
    AX = 0x7D;
    CheckExternalEvents(cs3, 0x57A);
    // PUSH AX (0697_0579 / 0x6EE9)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x57F);
    // CALLF 0x1000:91da (0697_057A / 0x6EEA)
    FarCall(cs3, 0x57F, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x582);
    // ADD SP,0xa (0697_057F / 0x6EEF)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x585);
    // MOV AX,0x8 (0697_0582 / 0x6EF2)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x586);
    // PUSH AX (0697_0585 / 0x6EF5)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x589);
    // MOV AX,0x1 (0697_0586 / 0x6EF6)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x58A);
    // PUSH AX (0697_0589 / 0x6EF9)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x58D);
    // MOV AX,0xa0 (0697_058A / 0x6EFA)
    AX = 0xA0;
    CheckExternalEvents(cs3, 0x58E);
    // PUSH AX (0697_058D / 0x6EFD)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x590);
    // SUB AX,AX (0697_058E / 0x6EFE)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs3, 0x591);
    // PUSH AX (0697_0590 / 0x6F00)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x594);
    // MOV AX,0x7e (0697_0591 / 0x6F01)
    AX = 0x7E;
    CheckExternalEvents(cs3, 0x595);
    // PUSH AX (0697_0594 / 0x6F04)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x59A);
    // CALLF 0x1000:91da (0697_0595 / 0x6F05)
    FarCall(cs3, 0x59A, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x59D);
    // ADD SP,0xa (0697_059A / 0x6F0A)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x5A0);
    // MOV AX,0x8 (0697_059D / 0x6F0D)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x5A1);
    // PUSH AX (0697_05A0 / 0x6F10)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5A4);
    // MOV AX,0x1 (0697_05A1 / 0x6F11)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x5A5);
    // PUSH AX (0697_05A4 / 0x6F14)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5A8);
    // MOV AX,0xa0 (0697_05A5 / 0x6F15)
    AX = 0xA0;
    CheckExternalEvents(cs3, 0x5A9);
    // PUSH AX (0697_05A8 / 0x6F18)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5AC);
    // MOV AX,0x1 (0697_05A9 / 0x6F19)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x5AD);
    // PUSH AX (0697_05AC / 0x6F1C)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5B0);
    // MOV AX,0x7f (0697_05AD / 0x6F1D)
    AX = 0x7F;
    CheckExternalEvents(cs3, 0x5B1);
    // PUSH AX (0697_05B0 / 0x6F20)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5B6);
    // CALLF 0x1000:91da (0697_05B1 / 0x6F21)
    FarCall(cs3, 0x5B6, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x5B9);
    // ADD SP,0xa (0697_05B6 / 0x6F26)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x5BC);
    // MOV AX,0x10 (0697_05B9 / 0x6F29)
    AX = 0x10;
    CheckExternalEvents(cs3, 0x5BD);
    // PUSH AX (0697_05BC / 0x6F2C)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5C0);
    // MOV AX,0x2 (0697_05BD / 0x6F2D)
    AX = 0x2;
    CheckExternalEvents(cs3, 0x5C1);
    // PUSH AX (0697_05C0 / 0x6F30)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5C4);
    // MOV AX,0x90 (0697_05C1 / 0x6F31)
    AX = 0x90;
    CheckExternalEvents(cs3, 0x5C5);
    // PUSH AX (0697_05C4 / 0x6F34)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5C8);
    // MOV AX,0x8 (0697_05C5 / 0x6F35)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x5C9);
    // PUSH AX (0697_05C8 / 0x6F38)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5CC);
    // MOV AX,0x80 (0697_05C9 / 0x6F39)
    AX = 0x80;
    CheckExternalEvents(cs3, 0x5CD);
    // PUSH AX (0697_05CC / 0x6F3C)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5D2);
    // CALLF 0x1000:91da (0697_05CD / 0x6F3D)
    FarCall(cs3, 0x5D2, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x5D5);
    // ADD SP,0xa (0697_05D2 / 0x6F42)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x5D8);
    // MOV AX,0x10 (0697_05D5 / 0x6F45)
    AX = 0x10;
    CheckExternalEvents(cs3, 0x5D9);
    // PUSH AX (0697_05D8 / 0x6F48)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5DC);
    // MOV AX,0x2 (0697_05D9 / 0x6F49)
    AX = 0x2;
    CheckExternalEvents(cs3, 0x5DD);
    // PUSH AX (0697_05DC / 0x6F4C)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5E0);
    // MOV AX,0x90 (0697_05DD / 0x6F4D)
    AX = 0x90;
    CheckExternalEvents(cs3, 0x5E1);
    // PUSH AX (0697_05E0 / 0x6F50)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5E4);
    // MOV AX,0xa (0697_05E1 / 0x6F51)
    AX = 0xA;
    CheckExternalEvents(cs3, 0x5E5);
    // PUSH AX (0697_05E4 / 0x6F54)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5E8);
    // MOV AX,0x81 (0697_05E5 / 0x6F55)
    AX = 0x81;
    CheckExternalEvents(cs3, 0x5E9);
    // PUSH AX (0697_05E8 / 0x6F58)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x5EE);
    // CALLF 0x1000:91da (0697_05E9 / 0x6F59)
    FarCall(cs3, 0x5EE, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x5F1);
    // ADD SP,0xa (0697_05EE / 0x6F5E)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x5F6);
    // MOV word ptr [BP + -0x16],0x12 (0697_05F1 / 0x6F61)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x12;
    CheckExternalEvents(cs3, 0x5F8);
    // JMP 0x0000:6f9f (0697_05F6 / 0x6F66)
    goto label_0697_062F_06F9F;
    label_0697_05F8_06F68:
    CheckExternalEvents(cs3, 0x5FB);
    // INC word ptr [BP + -0xe] (0697_05F8 / 0x6F68)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_0697_05FB_06F6B:
    CheckExternalEvents(cs3, 0x5FF);
    // CMP word ptr [BP + -0xe],0x8 (0697_05FB / 0x6F6B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x8);
    CheckExternalEvents(cs3, 0x601);
    // JGE 0x0000:6f9c (0697_05FF / 0x6F6F)
    if(SignFlag == OverflowFlag) {
      goto label_0697_062C_06F9C;
    }
    CheckExternalEvents(cs3, 0x604);
    // MOV AX,0x8 (0697_0601 / 0x6F71)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x605);
    // PUSH AX (0697_0604 / 0x6F74)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x608);
    // MOV AX,0x1 (0697_0605 / 0x6F75)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x609);
    // PUSH AX (0697_0608 / 0x6F78)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x60C);
    // MOV AX,word ptr [BP + -0x16] (0697_0609 / 0x6F79)
    AX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs3, 0x60E);
    // MOV CL,0x3 (0697_060C / 0x6F7C)
    CL = 0x3;
    CheckExternalEvents(cs3, 0x610);
    // SHL AX,CL (0697_060E / 0x6F7E)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs3, 0x611);
    // PUSH AX (0697_0610 / 0x6F80)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x614);
    // PUSH word ptr [BP + -0xe] (0697_0611 / 0x6F81)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs3, 0x617);
    // MOV AX,word ptr [BP + -0x16] (0697_0614 / 0x6F84)
    AX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs3, 0x619);
    // SHL AX,0x1 (0697_0617 / 0x6F87)
    AX <<= 0x1;
    CheckExternalEvents(cs3, 0x61B);
    // SHL AX,0x1 (0697_0619 / 0x6F89)
    AX <<= 0x1;
    CheckExternalEvents(cs3, 0x61E);
    // ADD AX,word ptr [BP + -0xe] (0697_061B / 0x6F8B)
    AX += UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs3, 0x621);
    // ADD AX,0x36 (0697_061E / 0x6F8E)
    // AX += 0x36;
    AX = Alu.Add16(AX, 0x36);
    CheckExternalEvents(cs3, 0x622);
    // PUSH AX (0697_0621 / 0x6F91)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x627);
    // CALLF 0x1000:91da (0697_0622 / 0x6F92)
    FarCall(cs3, 0x627, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x62A);
    // ADD SP,0xa (0697_0627 / 0x6F97)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x62C);
    // JMP 0x0000:6f68 (0697_062A / 0x6F9A)
    goto label_0697_05F8_06F68;
    label_0697_062C_06F9C:
    CheckExternalEvents(cs3, 0x62F);
    // INC word ptr [BP + -0x16] (0697_062C / 0x6F9C)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    label_0697_062F_06F9F:
    CheckExternalEvents(cs3, 0x633);
    // CMP word ptr [BP + -0x16],0x16 (0697_062F / 0x6F9F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x16);
    CheckExternalEvents(cs3, 0x635);
    // JGE 0x0000:6fac (0697_0633 / 0x6FA3)
    if(SignFlag == OverflowFlag) {
      goto label_0697_063C_06FAC;
    }
    CheckExternalEvents(cs3, 0x63A);
    // MOV word ptr [BP + -0xe],0x4 (0697_0635 / 0x6FA5)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x4;
    CheckExternalEvents(cs3, 0x63C);
    // JMP 0x0000:6f6b (0697_063A / 0x6FAA)
    goto label_0697_05FB_06F6B;
    label_0697_063C_06FAC:
    CheckExternalEvents(cs3, 0x641);
    // MOV word ptr [BP + -0xe],0x0 (0697_063C / 0x6FAC)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    label_0697_0641_06FB1:
    CheckExternalEvents(cs3, 0x644);
    // MOV AX,0x18 (0697_0641 / 0x6FB1)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x645);
    // PUSH AX (0697_0644 / 0x6FB4)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x648);
    // MOV AX,0x3 (0697_0645 / 0x6FB5)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x649);
    // PUSH AX (0697_0648 / 0x6FB8)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x64C);
    // MOV AX,0x30 (0697_0649 / 0x6FB9)
    AX = 0x30;
    CheckExternalEvents(cs3, 0x64D);
    // PUSH AX (0697_064C / 0x6FBC)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x650);
    // MOV AX,0x3 (0697_064D / 0x6FBD)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x653);
    // IMUL word ptr [BP + -0xe] (0697_0650 / 0x6FC0)
    int resImul0697_0650 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0697_0650);
    DX = (ushort)(resImul0697_0650 >> 16);
    CheckExternalEvents(cs3, 0x654);
    // PUSH AX (0697_0653 / 0x6FC3)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x657);
    // MOV AX,word ptr [BP + -0xe] (0697_0654 / 0x6FC4)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs3, 0x65A);
    // ADD AX,0x92 (0697_0657 / 0x6FC7)
    // AX += 0x92;
    AX = Alu.Add16(AX, 0x92);
    CheckExternalEvents(cs3, 0x65B);
    // PUSH AX (0697_065A / 0x6FCA)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x660);
    // CALLF 0x1000:91da (0697_065B / 0x6FCB)
    FarCall(cs3, 0x660, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x663);
    // ADD SP,0xa (0697_0660 / 0x6FD0)
    SP += 0xA;
    CheckExternalEvents(cs3, 0x666);
    // INC word ptr [BP + -0xe] (0697_0663 / 0x6FD3)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs3, 0x66A);
    // CMP word ptr [BP + -0xe],0xc (0697_0666 / 0x6FD6)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0xC);
    CheckExternalEvents(cs3, 0x66C);
    // JL 0x0000:6fb1 (0697_066A / 0x6FDA)
    if(SignFlag != OverflowFlag) {
      goto label_0697_0641_06FB1;
    }
    CheckExternalEvents(cs3, 0x671);
    // MOV word ptr [BP + -0xe],0x0 (0697_066C / 0x6FDC)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    label_0697_0671_06FE1:
    CheckExternalEvents(cs3, 0x674);
    // MOV AX,0x18 (0697_0671 / 0x6FE1)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x675);
    // PUSH AX (0697_0674 / 0x6FE4)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x678);
    // MOV AX,0x3 (0697_0675 / 0x6FE5)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x679);
    // PUSH AX (0697_0678 / 0x6FE8)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x67C);
    // MOV AX,0x48 (0697_0679 / 0x6FE9)
    AX = 0x48;
    CheckExternalEvents(cs3, 0x67D);
    // PUSH AX (0697_067C / 0x6FEC)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x680);
    // MOV AX,0x3 (0697_067D / 0x6FED)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x683);
    // IMUL word ptr [BP + -0xe] (0697_0680 / 0x6FF0)
    int resImul0697_0680 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0697_0680);
    DX = (ushort)(resImul0697_0680 >> 16);
    CheckExternalEvents(cs3, 0x684);
    // PUSH AX (0697_0683 / 0x6FF3)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x687);
    // MOV AX,word ptr [BP + -0xe] (0697_0684 / 0x6FF4)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs3, 0x68A);
    // ADD AX,0x9e (0697_0687 / 0x6FF7)
    // AX += 0x9E;
    AX = Alu.Add16(AX, 0x9E);
    CheckExternalEvents(cs3, 0x68B);
    // PUSH AX (0697_068A / 0x6FFA)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x690);
    // CALLF 0x1000:91da (0697_068B / 0x6FFB)
    FarCall(cs3, 0x690, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x693);
    // ADD SP,0xa (0697_0690 / 0x7000)
    SP += 0xA;
    CheckExternalEvents(cs3, 0x696);
    // INC word ptr [BP + -0xe] (0697_0693 / 0x7003)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs3, 0x69A);
    // CMP word ptr [BP + -0xe],0x4 (0697_0696 / 0x7006)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x4);
    CheckExternalEvents(cs3, 0x69C);
    // JL 0x0000:6fe1 (0697_069A / 0x700A)
    if(SignFlag != OverflowFlag) {
      goto label_0697_0671_06FE1;
    }
    CheckExternalEvents(cs3, 0x69F);
    // MOV AX,0x18 (0697_069C / 0x700C)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x6A0);
    // PUSH AX (0697_069F / 0x700F)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6A3);
    // MOV AX,0x3 (0697_06A0 / 0x7010)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x6A4);
    // PUSH AX (0697_06A3 / 0x7013)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6A7);
    // MOV AX,0x60 (0697_06A4 / 0x7014)
    AX = 0x60;
    CheckExternalEvents(cs3, 0x6A8);
    // PUSH AX (0697_06A7 / 0x7017)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6AB);
    // MOV AX,0x6 (0697_06A8 / 0x7018)
    AX = 0x6;
    CheckExternalEvents(cs3, 0x6AC);
    // PUSH AX (0697_06AB / 0x701B)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6AF);
    // MOV AX,0xa2 (0697_06AC / 0x701C)
    AX = 0xA2;
    CheckExternalEvents(cs3, 0x6B0);
    // PUSH AX (0697_06AF / 0x701F)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6B5);
    // CALLF 0x1000:91da (0697_06B0 / 0x7020)
    FarCall(cs3, 0x6B5, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x6B8);
    // ADD SP,0xa (0697_06B5 / 0x7025)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x6BB);
    // MOV AX,0x18 (0697_06B8 / 0x7028)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x6BC);
    // PUSH AX (0697_06BB / 0x702B)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6BF);
    // MOV AX,0x3 (0697_06BC / 0x702C)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x6C0);
    // PUSH AX (0697_06BF / 0x702F)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6C3);
    // MOV AX,0x60 (0697_06C0 / 0x7030)
    AX = 0x60;
    CheckExternalEvents(cs3, 0x6C4);
    // PUSH AX (0697_06C3 / 0x7033)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6C7);
    // MOV AX,0x9 (0697_06C4 / 0x7034)
    AX = 0x9;
    CheckExternalEvents(cs3, 0x6C8);
    // PUSH AX (0697_06C7 / 0x7037)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6CB);
    // MOV AX,0xa3 (0697_06C8 / 0x7038)
    AX = 0xA3;
    CheckExternalEvents(cs3, 0x6CC);
    // PUSH AX (0697_06CB / 0x703B)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6D1);
    // CALLF 0x1000:91da (0697_06CC / 0x703C)
    FarCall(cs3, 0x6D1, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x6D4);
    // ADD SP,0xa (0697_06D1 / 0x7041)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x6D7);
    // MOV AX,0x18 (0697_06D4 / 0x7044)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x6D8);
    // PUSH AX (0697_06D7 / 0x7047)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6DB);
    // MOV AX,0x3 (0697_06D8 / 0x7048)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x6DC);
    // PUSH AX (0697_06DB / 0x704B)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6DF);
    // MOV AX,0x78 (0697_06DC / 0x704C)
    AX = 0x78;
    CheckExternalEvents(cs3, 0x6E0);
    // PUSH AX (0697_06DF / 0x704F)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6E2);
    // SUB AX,AX (0697_06E0 / 0x7050)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs3, 0x6E3);
    // PUSH AX (0697_06E2 / 0x7052)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6E6);
    // MOV AX,0xa4 (0697_06E3 / 0x7053)
    AX = 0xA4;
    CheckExternalEvents(cs3, 0x6E7);
    // PUSH AX (0697_06E6 / 0x7056)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6EC);
    // CALLF 0x1000:91da (0697_06E7 / 0x7057)
    FarCall(cs3, 0x6EC, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x6EF);
    // ADD SP,0xa (0697_06EC / 0x705C)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x6F2);
    // MOV AX,0x18 (0697_06EF / 0x705F)
    AX = 0x18;
    CheckExternalEvents(cs3, 0x6F3);
    // PUSH AX (0697_06F2 / 0x7062)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6F6);
    // MOV AX,0x3 (0697_06F3 / 0x7063)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x6F7);
    // PUSH AX (0697_06F6 / 0x7066)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6FA);
    // MOV AX,0x78 (0697_06F7 / 0x7067)
    AX = 0x78;
    CheckExternalEvents(cs3, 0x6FB);
    // PUSH AX (0697_06FA / 0x706A)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x6FE);
    // MOV AX,0x3 (0697_06FB / 0x706B)
    AX = 0x3;
    CheckExternalEvents(cs3, 0x6FF);
    // PUSH AX (0697_06FE / 0x706E)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x702);
    // MOV AX,0xa5 (0697_06FF / 0x706F)
    AX = 0xA5;
    CheckExternalEvents(cs3, 0x703);
    // PUSH AX (0697_0702 / 0x7072)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x708);
    // CALLF 0x1000:91da (0697_0703 / 0x7073)
    FarCall(cs3, 0x708, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x70B);
    // ADD SP,0xa (0697_0708 / 0x7078)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x710);
    // MOV word ptr [BP + -0xe],0xa6 (0697_070B / 0x707B)
    UInt16[SS, (ushort)(BP - 0xE)] = 0xA6;
    label_0697_0710_07080:
    CheckExternalEvents(cs3, 0x713);
    // MOV AX,0x8 (0697_0710 / 0x7080)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x714);
    // PUSH AX (0697_0713 / 0x7083)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x717);
    // MOV AX,0x1 (0697_0714 / 0x7084)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x718);
    // PUSH AX (0697_0717 / 0x7087)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x71B);
    // MOV AX,0x20 (0697_0718 / 0x7088)
    AX = 0x20;
    CheckExternalEvents(cs3, 0x71C);
    // PUSH AX (0697_071B / 0x708B)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x71F);
    // MOV AX,word ptr [BP + -0xe] (0697_071C / 0x708C)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs3, 0x722);
    // SUB AX,0x9a (0697_071F / 0x708F)
    // AX -= 0x9A;
    AX = Alu.Sub16(AX, 0x9A);
    CheckExternalEvents(cs3, 0x723);
    // PUSH AX (0697_0722 / 0x7092)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x726);
    // PUSH word ptr [BP + -0xe] (0697_0723 / 0x7093)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs3, 0x72B);
    // CALLF 0x1000:91da (0697_0726 / 0x7096)
    FarCall(cs3, 0x72B, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x72E);
    // ADD SP,0xa (0697_072B / 0x709B)
    SP += 0xA;
    CheckExternalEvents(cs3, 0x731);
    // INC word ptr [BP + -0xe] (0697_072E / 0x709E)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs3, 0x736);
    // CMP word ptr [BP + -0xe],0xba (0697_0731 / 0x70A1)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0xBA);
    CheckExternalEvents(cs3, 0x738);
    // JL 0x0000:7080 (0697_0736 / 0x70A6)
    if(SignFlag != OverflowFlag) {
      goto label_0697_0710_07080;
    }
    CheckExternalEvents(cs3, 0x73D);
    // MOV word ptr [BP + -0x16],0x9 (0697_0738 / 0x70A8)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x9;
    CheckExternalEvents(cs3, 0x73F);
    // JMP 0x0000:70e5 (0697_073D / 0x70AD)
    goto label_0697_0775_070E5;
    label_0697_073F_070AF:
    CheckExternalEvents(cs3, 0x742);
    // INC word ptr [BP + -0xe] (0697_073F / 0x70AF)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_0697_0742_070B2:
    CheckExternalEvents(cs3, 0x746);
    // CMP word ptr [BP + -0xe],0x24 (0697_0742 / 0x70B2)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x24);
    CheckExternalEvents(cs3, 0x748);
    // JGE 0x0000:70e2 (0697_0746 / 0x70B6)
    if(SignFlag == OverflowFlag) {
      goto label_0697_0772_070E2;
    }
    CheckExternalEvents(cs3, 0x74B);
    // MOV AX,0x8 (0697_0748 / 0x70B8)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x74C);
    // PUSH AX (0697_074B / 0x70BB)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x74F);
    // MOV AX,0x1 (0697_074C / 0x70BC)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x750);
    // PUSH AX (0697_074F / 0x70BF)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x753);
    // MOV AX,word ptr [BP + -0x16] (0697_0750 / 0x70C0)
    AX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs3, 0x755);
    // MOV CL,0x3 (0697_0753 / 0x70C3)
    CL = 0x3;
    CheckExternalEvents(cs3, 0x757);
    // SHL AX,CL (0697_0755 / 0x70C5)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs3, 0x758);
    // PUSH AX (0697_0757 / 0x70C7)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x75B);
    // PUSH word ptr [BP + -0xe] (0697_0758 / 0x70C8)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs3, 0x75E);
    // MOV AX,0xc (0697_075B / 0x70CB)
    AX = 0xC;
    CheckExternalEvents(cs3, 0x761);
    // IMUL word ptr [BP + -0x16] (0697_075E / 0x70CE)
    int resImul0697_075E = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x16)]);
    AX = (ushort)(resImul0697_075E);
    DX = (ushort)(resImul0697_075E >> 16);
    CheckExternalEvents(cs3, 0x764);
    // ADD AX,word ptr [BP + -0xe] (0697_0761 / 0x70D1)
    AX += UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs3, 0x767);
    // ADD AX,0x36 (0697_0764 / 0x70D4)
    // AX += 0x36;
    AX = Alu.Add16(AX, 0x36);
    CheckExternalEvents(cs3, 0x768);
    // PUSH AX (0697_0767 / 0x70D7)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x76D);
    // CALLF 0x1000:91da (0697_0768 / 0x70D8)
    FarCall(cs3, 0x76D, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x770);
    // ADD SP,0xa (0697_076D / 0x70DD)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x772);
    // JMP 0x0000:70af (0697_0770 / 0x70E0)
    goto label_0697_073F_070AF;
    label_0697_0772_070E2:
    CheckExternalEvents(cs3, 0x775);
    // INC word ptr [BP + -0x16] (0697_0772 / 0x70E2)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    label_0697_0775_070E5:
    CheckExternalEvents(cs3, 0x779);
    // CMP word ptr [BP + -0x16],0x10 (0697_0775 / 0x70E5)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x10);
    CheckExternalEvents(cs3, 0x77B);
    // JGE 0x0000:70f2 (0697_0779 / 0x70E9)
    if(SignFlag == OverflowFlag) {
      goto label_0697_0782_070F2;
    }
    CheckExternalEvents(cs3, 0x780);
    // MOV word ptr [BP + -0xe],0x18 (0697_077B / 0x70EB)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x18;
    CheckExternalEvents(cs3, 0x782);
    // JMP 0x0000:70b2 (0697_0780 / 0x70F0)
    goto label_0697_0742_070B2;
    label_0697_0782_070F2:
    CheckExternalEvents(cs3, 0x787);
    // MOV word ptr [BP + -0xe],0x10a (0697_0782 / 0x70F2)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x10A;
    label_0697_0787_070F7:
    CheckExternalEvents(cs3, 0x78A);
    // MOV AX,0x8 (0697_0787 / 0x70F7)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x78B);
    // PUSH AX (0697_078A / 0x70FA)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x78E);
    // MOV AX,0x1 (0697_078B / 0x70FB)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x78F);
    // PUSH AX (0697_078E / 0x70FE)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x792);
    // MOV AX,0x28 (0697_078F / 0x70FF)
    AX = 0x28;
    CheckExternalEvents(cs3, 0x793);
    // PUSH AX (0697_0792 / 0x7102)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x796);
    // MOV AX,word ptr [BP + -0xe] (0697_0793 / 0x7103)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs3, 0x799);
    // SUB AX,0xfe (0697_0796 / 0x7106)
    // AX -= 0xFE;
    AX = Alu.Sub16(AX, 0xFE);
    CheckExternalEvents(cs3, 0x79A);
    // PUSH AX (0697_0799 / 0x7109)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x79D);
    // MOV AX,word ptr [BP + -0xe] (0697_079A / 0x710A)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs3, 0x7A0);
    // ADD AX,0x4 (0697_079D / 0x710D)
    // AX += 0x4;
    AX = Alu.Add16(AX, 0x4);
    CheckExternalEvents(cs3, 0x7A1);
    // PUSH AX (0697_07A0 / 0x7110)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x7A6);
    // CALLF 0x1000:91da (0697_07A1 / 0x7111)
    FarCall(cs3, 0x7A6, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x7A9);
    // ADD SP,0xa (0697_07A6 / 0x7116)
    SP += 0xA;
    CheckExternalEvents(cs3, 0x7AC);
    // INC word ptr [BP + -0xe] (0697_07A9 / 0x7119)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs3, 0x7B1);
    // CMP word ptr [BP + -0xe],0x11e (0697_07AC / 0x711C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x11E);
    CheckExternalEvents(cs3, 0x7B3);
    // JL 0x0000:70f7 (0697_07B1 / 0x7121)
    if(SignFlag != OverflowFlag) {
      goto label_0697_0787_070F7;
    }
    CheckExternalEvents(cs3, 0x7B8);
    // MOV word ptr [BP + -0x16],0x10 (0697_07B3 / 0x7123)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x10;
    CheckExternalEvents(cs3, 0x7BA);
    // JMP 0x0000:7160 (0697_07B8 / 0x7128)
    goto label_0697_07F0_07160;
    label_0697_07BA_0712A:
    CheckExternalEvents(cs3, 0x7BD);
    // INC word ptr [BP + -0xe] (0697_07BA / 0x712A)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_0697_07BD_0712D:
    CheckExternalEvents(cs3, 0x7C1);
    // CMP word ptr [BP + -0xe],0x18 (0697_07BD / 0x712D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x18);
    CheckExternalEvents(cs3, 0x7C3);
    // JGE 0x0000:715d (0697_07C1 / 0x7131)
    if(SignFlag == OverflowFlag) {
      goto label_0697_07ED_0715D;
    }
    CheckExternalEvents(cs3, 0x7C6);
    // MOV AX,0x8 (0697_07C3 / 0x7133)
    AX = 0x8;
    CheckExternalEvents(cs3, 0x7C7);
    // PUSH AX (0697_07C6 / 0x7136)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x7CA);
    // MOV AX,0x1 (0697_07C7 / 0x7137)
    AX = 0x1;
    CheckExternalEvents(cs3, 0x7CB);
    // PUSH AX (0697_07CA / 0x713A)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x7CE);
    // MOV AX,word ptr [BP + -0x16] (0697_07CB / 0x713B)
    AX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs3, 0x7D0);
    // MOV CL,0x3 (0697_07CE / 0x713E)
    CL = 0x3;
    CheckExternalEvents(cs3, 0x7D2);
    // SHL AX,CL (0697_07D0 / 0x7140)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs3, 0x7D3);
    // PUSH AX (0697_07D2 / 0x7142)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x7D6);
    // PUSH word ptr [BP + -0xe] (0697_07D3 / 0x7143)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs3, 0x7D9);
    // MOV AX,0xc (0697_07D6 / 0x7146)
    AX = 0xC;
    CheckExternalEvents(cs3, 0x7DC);
    // IMUL word ptr [BP + -0x16] (0697_07D9 / 0x7149)
    int resImul0697_07D9 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x16)]);
    AX = (ushort)(resImul0697_07D9);
    DX = (ushort)(resImul0697_07D9 >> 16);
    CheckExternalEvents(cs3, 0x7DF);
    // ADD AX,word ptr [BP + -0xe] (0697_07DC / 0x714C)
    AX += UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs3, 0x7E2);
    // ADD AX,0x56 (0697_07DF / 0x714F)
    // AX += 0x56;
    AX = Alu.Add16(AX, 0x56);
    CheckExternalEvents(cs3, 0x7E3);
    // PUSH AX (0697_07E2 / 0x7152)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x7E8);
    // CALLF 0x1000:91da (0697_07E3 / 0x7153)
    FarCall(cs3, 0x7E8, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x7EB);
    // ADD SP,0xa (0697_07E8 / 0x7158)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x7ED);
    // JMP 0x0000:712a (0697_07EB / 0x715B)
    goto label_0697_07BA_0712A;
    label_0697_07ED_0715D:
    CheckExternalEvents(cs3, 0x7F0);
    // INC word ptr [BP + -0x16] (0697_07ED / 0x715D)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    label_0697_07F0_07160:
    CheckExternalEvents(cs3, 0x7F4);
    // CMP word ptr [BP + -0x16],0x17 (0697_07F0 / 0x7160)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x17);
    CheckExternalEvents(cs3, 0x7F6);
    // JGE 0x0000:716d (0697_07F4 / 0x7164)
    if(SignFlag == OverflowFlag) {
      goto label_0697_07FD_0716D;
    }
    CheckExternalEvents(cs3, 0x7FB);
    // MOV word ptr [BP + -0xe],0xc (0697_07F6 / 0x7166)
    UInt16[SS, (ushort)(BP - 0xE)] = 0xC;
    CheckExternalEvents(cs3, 0x7FD);
    // JMP 0x0000:712d (0697_07FB / 0x716B)
    goto label_0697_07BD_0712D;
    label_0697_07FD_0716D:
    CheckExternalEvents(cs3, 0x800);
    // MOV AX,0xb (0697_07FD / 0x716D)
    AX = 0xB;
    CheckExternalEvents(cs3, 0x801);
    // PUSH AX (0697_0800 / 0x7170)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x804);
    // MOV AX,0x2 (0697_0801 / 0x7171)
    AX = 0x2;
    CheckExternalEvents(cs3, 0x805);
    // PUSH AX (0697_0804 / 0x7174)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x808);
    // MOV AX,0x90 (0697_0805 / 0x7175)
    AX = 0x90;
    CheckExternalEvents(cs3, 0x809);
    // PUSH AX (0697_0808 / 0x7178)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x80B);
    // SUB AX,AX (0697_0809 / 0x7179)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs3, 0x80C);
    // PUSH AX (0697_080B / 0x717B)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x80F);
    // MOV AX,0x176 (0697_080C / 0x717C)
    AX = 0x176;
    CheckExternalEvents(cs3, 0x810);
    // PUSH AX (0697_080F / 0x717F)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x815);
    // CALLF 0x1000:91da (0697_0810 / 0x7180)
    FarCall(cs3, 0x815, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x818);
    // ADD SP,0xa (0697_0815 / 0x7185)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x81B);
    // MOV AX,0xb (0697_0818 / 0x7188)
    AX = 0xB;
    CheckExternalEvents(cs3, 0x81C);
    // PUSH AX (0697_081B / 0x718B)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x81F);
    // MOV AX,0x2 (0697_081C / 0x718C)
    AX = 0x2;
    CheckExternalEvents(cs3, 0x820);
    // PUSH AX (0697_081F / 0x718F)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x823);
    // MOV AX,0x90 (0697_0820 / 0x7190)
    AX = 0x90;
    CheckExternalEvents(cs3, 0x824);
    // PUSH AX (0697_0823 / 0x7193)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x827);
    // MOV AX,0x2 (0697_0824 / 0x7194)
    AX = 0x2;
    CheckExternalEvents(cs3, 0x828);
    // PUSH AX (0697_0827 / 0x7197)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x82B);
    // MOV AX,0x177 (0697_0828 / 0x7198)
    AX = 0x177;
    CheckExternalEvents(cs3, 0x82C);
    // PUSH AX (0697_082B / 0x719B)
    Stack.Push16(AX);
    CheckExternalEvents(cs3, 0x831);
    // CALLF 0x1000:91da (0697_082C / 0x719C)
    FarCall(cs3, 0x831, unknown_18AD_070A_191DA);
    CheckExternalEvents(cs3, 0x834);
    // ADD SP,0xa (0697_0831 / 0x71A1)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs3, 0x839);
    // CALLF 0x0000:67c8 (0697_0834 / 0x71A4)
    FarCall(cs3, 0x839, unknown_0170_50C8_067C8);
    CheckExternalEvents(cs3, 0x83E);
    // CALLF 0x0000:7ec2 (0697_0839 / 0x71A9)
    FarCall(cs3, 0x83E, ghidra_guess_0000_7EC2_07EC2);
    CheckExternalEvents(cs3, 0x840);
    // MOV SP,BP (0697_083E / 0x71AE)
    SP = BP;
    CheckExternalEvents(cs3, 0x841);
    // POP BP (0697_0840 / 0x71B0)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs3, 0x842);
    // RETF  (0697_0841 / 0x71B1)
    return FarRet();
  }
  
}
