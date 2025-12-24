namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_0000_D786_0D786(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_D786_0D786:
    CheckExternalEvents(cs1, 0xD787);
    // PUSH BP (0000_D786 / 0xD786)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xD789);
    // MOV BP,SP (0000_D787 / 0xD787)
    BP = SP;
    CheckExternalEvents(cs1, 0xD78C);
    // MOV AX,0x16 (0000_D789 / 0xD789)
    AX = 0x16;
    CheckExternalEvents(cs1, 0xD791);
    // CALLF 0x1000:cecc (0000_D78C / 0xD78C)
    FarCall(cs1, 0xD791, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xD792);
    // PUSH SI (0000_D791 / 0xD791)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xD795);
    // MOV AX,word ptr [BP + 0x6] (0000_D792 / 0xD792)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xD796);
    // INC AX (0000_D795 / 0xD795)
    AX++;
    CheckExternalEvents(cs1, 0xD799);
    // AND AX,0x7f (0000_D796 / 0xD796)
    // AX &= 0x7F;
    AX = Alu.And16(AX, 0x7F);
    CheckExternalEvents(cs1, 0xD79C);
    // MOV word ptr [BP + 0x6],AX (0000_D799 / 0xD799)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs1, 0xD7A0);
    // AND word ptr [BP + 0x8],0x7e (0000_D79C / 0xD79C)
    UInt16[SS, (ushort)(BP + 0x8)] &= 0x7E;
    CheckExternalEvents(cs1, 0xD7A4);
    // CMP word ptr [BP + 0xa],0x0 (0000_D7A0 / 0xD7A0)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs1, 0xD7A6);
    // JL 0x0000:d7a9 (0000_D7A4 / 0xD7A4)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D7A9_0D7A9;
    }
    CheckExternalEvents(cs1, 0xD7A9);
    // JMP 0x0000:d89d (0000_D7A6 / 0xD7A6)
    goto label_0000_D89D_0D89D;
    label_0000_D7A9_0D7A9:
    CheckExternalEvents(cs1, 0xD7AE);
    // MOV word ptr [BP + -0x6],0x0 (0000_D7A9 / 0xD7A9)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    CheckExternalEvents(cs1, 0xD7B3);
    // MOV word ptr [BP + -0x8],0x0 (0000_D7AE / 0xD7AE)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs1, 0xD7B5);
    // JMP 0x0000:d7b8 (0000_D7B3 / 0xD7B3)
    goto label_0000_D7B8_0D7B8;
    label_0000_D7B5_0D7B5:
    CheckExternalEvents(cs1, 0xD7B8);
    // INC word ptr [BP + -0x8] (0000_D7B5 / 0xD7B5)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    label_0000_D7B8_0D7B8:
    CheckExternalEvents(cs1, 0xD7BC);
    // CMP word ptr [BP + -0x8],0xc (0000_D7B8 / 0xD7B8)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0xC);
    CheckExternalEvents(cs1, 0xD7BE);
    // JL 0x0000:d7c1 (0000_D7BC / 0xD7BC)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D7C1_0D7C1;
    }
    CheckExternalEvents(cs1, 0xD7C1);
    // JMP 0x0000:d8ba (0000_D7BE / 0xD7BE)
    goto label_0000_D8BA_0D8BA;
    label_0000_D7C1_0D7C1:
    CheckExternalEvents(cs1, 0xD7C4);
    // MOV BX,word ptr [BP + -0x8] (0000_D7C1 / 0xD7C1)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0xD7C8);
    // MOV AL,byte ptr [BX + 0x2486] (0000_D7C4 / 0xD7C4)
    AL = UInt8[DS, (ushort)(BX + 0x2486)];
    CheckExternalEvents(cs1, 0xD7C9);
    // CBW  (0000_D7C8 / 0xD7C8)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD7CC);
    // CMP AX,word ptr [BP + 0x8] (0000_D7C9 / 0xD7C9)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs1, 0xD7CE);
    // JNZ 0x0000:d7b5 (0000_D7CC / 0xD7CC)
    if(!ZeroFlag) {
      goto label_0000_D7B5_0D7B5;
    }
    CheckExternalEvents(cs1, 0xD7D1);
    // MOV AL,byte ptr [BP + 0x6] (0000_D7CE / 0xD7CE)
    AL = UInt8[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xD7D3);
    // AND AL,0x7e (0000_D7D1 / 0xD7D1)
    AL &= 0x7E;
    CheckExternalEvents(cs1, 0xD7D7);
    // CMP byte ptr [BX + 0x247a],AL (0000_D7D3 / 0xD7D3)
    Alu.Sub8(UInt8[DS, (ushort)(BX + 0x247A)], AL);
    CheckExternalEvents(cs1, 0xD7D9);
    // JNZ 0x0000:d7b5 (0000_D7D7 / 0xD7D7)
    if(!ZeroFlag) {
      goto label_0000_D7B5_0D7B5;
    }
    CheckExternalEvents(cs1, 0xD7DD);
    // MOV AL,byte ptr [BX + 0x2492] (0000_D7D9 / 0xD7D9)
    AL = UInt8[DS, (ushort)(BX + 0x2492)];
    CheckExternalEvents(cs1, 0xD7DE);
    // CBW  (0000_D7DD / 0xD7DD)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD7DF);
    // DEC AX (0000_D7DE / 0xD7DE)
    AX = Alu.Dec16(AX);
    CheckExternalEvents(cs1, 0xD7E2);
    // MOV word ptr [BP + -0x12],AX (0000_D7DF / 0xD7DF)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs1, 0xD7E6);
    // MOV AL,byte ptr [BX + 0x249e] (0000_D7E2 / 0xD7E2)
    AL = UInt8[DS, (ushort)(BX + 0x249E)];
    CheckExternalEvents(cs1, 0xD7E7);
    // CBW  (0000_D7E6 / 0xD7E6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD7E8);
    // DEC AX (0000_D7E7 / 0xD7E7)
    AX = Alu.Dec16(AX);
    CheckExternalEvents(cs1, 0xD7EB);
    // MOV word ptr [BP + -0xc],AX (0000_D7E8 / 0xD7E8)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0xD7EF);
    // MOV AL,byte ptr [BX + 0x24aa] (0000_D7EB / 0xD7EB)
    AL = UInt8[DS, (ushort)(BX + 0x24AA)];
    CheckExternalEvents(cs1, 0xD7F0);
    // CBW  (0000_D7EF / 0xD7EF)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD7F1);
    // DEC AX (0000_D7F0 / 0xD7F0)
    AX = Alu.Dec16(AX);
    CheckExternalEvents(cs1, 0xD7F4);
    // MOV word ptr [BP + -0x14],AX (0000_D7F1 / 0xD7F1)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs1, 0xD7F9);
    // MOV word ptr [BP + -0x6],0x1 (0000_D7F4 / 0xD7F4)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    CheckExternalEvents(cs1, 0xD7FB);
    // MOV AX,BX (0000_D7F9 / 0xD7F9)
    AX = BX;
    CheckExternalEvents(cs1, 0xD7FE);
    // MOV word ptr [BP + -0xe],AX (0000_D7FB / 0xD7FB)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs1, 0xD803);
    // MOV word ptr [BP + -0x8],0xc (0000_D7FE / 0xD7FE)
    UInt16[SS, (ushort)(BP - 0x8)] = 0xC;
    CheckExternalEvents(cs1, 0xD806);
    // CMP AX,0xb (0000_D803 / 0xD803)
    Alu.Sub16(AX, 0xB);
    CheckExternalEvents(cs1, 0xD808);
    // JZ 0x0000:d7b5 (0000_D806 / 0xD806)
    if(ZeroFlag) {
      goto label_0000_D7B5_0D7B5;
    }
    CheckExternalEvents(cs1, 0xD80C);
    // MOV ES,word ptr [0x54fa] (0000_D808 / 0xD808)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD810);
    // MOV AL,ES:[0xd347] (0000_D80C / 0xD80C)
    AL = UInt8[ES, 0xD347];
    CheckExternalEvents(cs1, 0xD811);
    // CBW  (0000_D810 / 0xD810)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD814);
    // CMP AX,word ptr [BP + -0x12] (0000_D811 / 0xD811)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs1, 0xD816);
    // JNZ 0x0000:d82a (0000_D814 / 0xD814)
    if(!ZeroFlag) {
      goto label_0000_D82A_0D82A;
    }
    CheckExternalEvents(cs1, 0xD81A);
    // MOV AL,ES:[0xd348] (0000_D816 / 0xD816)
    AL = UInt8[ES, 0xD348];
    CheckExternalEvents(cs1, 0xD81B);
    // CBW  (0000_D81A / 0xD81A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD81E);
    // CMP AX,word ptr [BP + -0xc] (0000_D81B / 0xD81B)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0xD820);
    // JNZ 0x0000:d82a (0000_D81E / 0xD81E)
    if(!ZeroFlag) {
      goto label_0000_D82A_0D82A;
    }
    CheckExternalEvents(cs1, 0xD824);
    // MOV AL,ES:[0xd349] (0000_D820 / 0xD820)
    AL = UInt8[ES, 0xD349];
    CheckExternalEvents(cs1, 0xD825);
    // CBW  (0000_D824 / 0xD824)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD828);
    // CMP AX,word ptr [BP + -0x14] (0000_D825 / 0xD825)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs1, 0xD82A);
    // JZ 0x0000:d7b5 (0000_D828 / 0xD828)
    if(ZeroFlag) {
      goto label_0000_D7B5_0D7B5;
    }
    label_0000_D82A_0D82A:
    CheckExternalEvents(cs1, 0xD82F);
    // CALLF 0x1000:7bf6 (0000_D82A / 0xD82A)
    FarCall(cs1, 0xD82F, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xD833);
    // MOV ES,word ptr [0x54fa] (0000_D82F / 0xD82F)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD837);
    // MOV AL,ES:[0xd347] (0000_D833 / 0xD833)
    AL = UInt8[ES, 0xD347];
    CheckExternalEvents(cs1, 0xD838);
    // CBW  (0000_D837 / 0xD837)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD83B);
    // CMP AX,word ptr [BP + -0x12] (0000_D838 / 0xD838)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs1, 0xD83D);
    // JZ 0x0000:d84a (0000_D83B / 0xD83B)
    if(ZeroFlag) {
      goto label_0000_D84A_0D84A;
    }
    CheckExternalEvents(cs1, 0xD840);
    // MOV AX,0x242c (0000_D83D / 0xD83D)
    AX = 0x242C;
    CheckExternalEvents(cs1, 0xD841);
    // PUSH DS (0000_D840 / 0xD840)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD842);
    // PUSH AX (0000_D841 / 0xD841)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD847);
    // CALLF 0x1000:8055 (0000_D842 / 0xD842)
    FarCall(cs1, 0xD847, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xD84A);
    // ADD SP,0x4 (0000_D847 / 0xD847)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    label_0000_D84A_0D84A:
    CheckExternalEvents(cs1, 0xD84E);
    // MOV ES,word ptr [0x54fa] (0000_D84A / 0xD84A)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD852);
    // MOV AL,ES:[0xd348] (0000_D84E / 0xD84E)
    AL = UInt8[ES, 0xD348];
    CheckExternalEvents(cs1, 0xD853);
    // CBW  (0000_D852 / 0xD852)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD856);
    // CMP AX,word ptr [BP + -0xc] (0000_D853 / 0xD853)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0xD858);
    // JZ 0x0000:d865 (0000_D856 / 0xD856)
    if(ZeroFlag) {
      goto label_0000_D865_0D865;
    }
    CheckExternalEvents(cs1, 0xD85B);
    // MOV AX,0x2441 (0000_D858 / 0xD858)
    AX = 0x2441;
    CheckExternalEvents(cs1, 0xD85C);
    // PUSH DS (0000_D85B / 0xD85B)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD85D);
    // PUSH AX (0000_D85C / 0xD85C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD862);
    // CALLF 0x1000:8055 (0000_D85D / 0xD85D)
    FarCall(cs1, 0xD862, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xD865);
    // ADD SP,0x4 (0000_D862 / 0xD862)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    label_0000_D865_0D865:
    CheckExternalEvents(cs1, 0xD869);
    // MOV ES,word ptr [0x54fa] (0000_D865 / 0xD865)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD86D);
    // MOV AL,ES:[0xd349] (0000_D869 / 0xD869)
    AL = UInt8[ES, 0xD349];
    CheckExternalEvents(cs1, 0xD86E);
    // CBW  (0000_D86D / 0xD86D)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD871);
    // CMP AX,word ptr [BP + -0x14] (0000_D86E / 0xD86E)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs1, 0xD873);
    // JZ 0x0000:d880 (0000_D871 / 0xD871)
    if(ZeroFlag) {
      goto label_0000_D880_0D880;
    }
    CheckExternalEvents(cs1, 0xD876);
    // MOV AX,0x2457 (0000_D873 / 0xD873)
    AX = 0x2457;
    CheckExternalEvents(cs1, 0xD877);
    // PUSH DS (0000_D876 / 0xD876)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD878);
    // PUSH AX (0000_D877 / 0xD877)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD87D);
    // CALLF 0x1000:8055 (0000_D878 / 0xD878)
    FarCall(cs1, 0xD87D, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xD880);
    // ADD SP,0x4 (0000_D87D / 0xD87D)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    label_0000_D880_0D880:
    CheckExternalEvents(cs1, 0xD885);
    // MOV word ptr [BP + -0x6],0x0 (0000_D880 / 0xD880)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    CheckExternalEvents(cs1, 0xD88A);
    // CALLF 0x1000:933a (0000_D885 / 0xD885)
    FarCall(cs1, 0xD88A, ghidra_guess_1000_933A_1933A);
    CheckExternalEvents(cs1, 0xD88F);
    // CALLF 0x1000:8d29 (0000_D88A / 0xD88A)
    FarCall(cs1, 0xD88F, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xD893);
    // MOV ES,word ptr [0x550e] (0000_D88F / 0xD88F)
    ES = UInt16[DS, 0x550E];
    CheckExternalEvents(cs1, 0xD89A);
    // MOV word ptr ES:[0xd55c],0x1 (0000_D893 / 0xD893)
    UInt16[ES, 0xD55C] = 0x1;
    CheckExternalEvents(cs1, 0xD89D);
    // JMP 0x0000:d7b5 (0000_D89A / 0xD89A)
    goto label_0000_D7B5_0D7B5;
    label_0000_D89D_0D89D:
    CheckExternalEvents(cs1, 0xD8A2);
    // MOV word ptr [BP + -0x6],0x1 (0000_D89D / 0xD89D)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    CheckExternalEvents(cs1, 0xD8A5);
    // MOV AX,word ptr [BP + 0xa] (0000_D8A2 / 0xD8A2)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs1, 0xD8A8);
    // MOV word ptr [BP + -0xe],AX (0000_D8A5 / 0xD8A5)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs1, 0xD8AA);
    // MOV BX,AX (0000_D8A8 / 0xD8A8)
    BX = AX;
    CheckExternalEvents(cs1, 0xD8AE);
    // MOV AL,byte ptr [BX + 0x247a] (0000_D8AA / 0xD8AA)
    AL = UInt8[DS, (ushort)(BX + 0x247A)];
    CheckExternalEvents(cs1, 0xD8AF);
    // CBW  (0000_D8AE / 0xD8AE)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD8B2);
    // MOV word ptr [BP + 0x6],AX (0000_D8AF / 0xD8AF)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs1, 0xD8B6);
    // MOV AL,byte ptr [BX + 0x2486] (0000_D8B2 / 0xD8B2)
    AL = UInt8[DS, (ushort)(BX + 0x2486)];
    CheckExternalEvents(cs1, 0xD8B7);
    // CBW  (0000_D8B6 / 0xD8B6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD8BA);
    // MOV word ptr [BP + 0x8],AX (0000_D8B7 / 0xD8B7)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    label_0000_D8BA_0D8BA:
    CheckExternalEvents(cs1, 0xD8BE);
    // CMP word ptr [BP + -0x6],0x0 (0000_D8BA / 0xD8BA)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs1, 0xD8C0);
    // JNZ 0x0000:d8c3 (0000_D8BE / 0xD8BE)
    if(!ZeroFlag) {
      goto label_0000_D8C3_0D8C3;
    }
    CheckExternalEvents(cs1, 0xD8C3);
    // JMP 0x0000:da14 (0000_D8C0 / 0xD8C0)
    goto label_0000_DA14_0DA14;
    label_0000_D8C3_0D8C3:
    CheckExternalEvents(cs1, 0xD8C7);
    // CMP word ptr [BP + 0xa],0x0 (0000_D8C3 / 0xD8C3)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs1, 0xD8C9);
    // JL 0x0000:d8e7 (0000_D8C7 / 0xD8C7)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D8E7_0D8E7;
    }
    CheckExternalEvents(cs1, 0xD8CC);
    // MOV BX,word ptr [BP + -0xe] (0000_D8C9 / 0xD8C9)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xD8D0);
    // MOV AL,byte ptr [BX + 0x2492] (0000_D8CC / 0xD8CC)
    AL = UInt8[DS, (ushort)(BX + 0x2492)];
    CheckExternalEvents(cs1, 0xD8D1);
    // CBW  (0000_D8D0 / 0xD8D0)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD8D2);
    // DEC AX (0000_D8D1 / 0xD8D1)
    AX = Alu.Dec16(AX);
    CheckExternalEvents(cs1, 0xD8D5);
    // MOV word ptr [BP + -0x12],AX (0000_D8D2 / 0xD8D2)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs1, 0xD8D9);
    // MOV AL,byte ptr [BX + 0x249e] (0000_D8D5 / 0xD8D5)
    AL = UInt8[DS, (ushort)(BX + 0x249E)];
    CheckExternalEvents(cs1, 0xD8DA);
    // CBW  (0000_D8D9 / 0xD8D9)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD8DB);
    // DEC AX (0000_D8DA / 0xD8DA)
    AX = Alu.Dec16(AX);
    CheckExternalEvents(cs1, 0xD8DE);
    // MOV word ptr [BP + -0xc],AX (0000_D8DB / 0xD8DB)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0xD8E2);
    // MOV AL,byte ptr [BX + 0x24aa] (0000_D8DE / 0xD8DE)
    AL = UInt8[DS, (ushort)(BX + 0x24AA)];
    CheckExternalEvents(cs1, 0xD8E3);
    // CBW  (0000_D8E2 / 0xD8E2)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD8E4);
    // DEC AX (0000_D8E3 / 0xD8E3)
    AX = Alu.Dec16(AX);
    CheckExternalEvents(cs1, 0xD8E7);
    // MOV word ptr [BP + -0x14],AX (0000_D8E4 / 0xD8E4)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    label_0000_D8E7_0D8E7:
    CheckExternalEvents(cs1, 0xD8EB);
    // CMP word ptr [BP + -0xe],0xb (0000_D8E7 / 0xD8E7)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0xB);
    CheckExternalEvents(cs1, 0xD8ED);
    // JZ 0x0000:d90e (0000_D8EB / 0xD8EB)
    if(ZeroFlag) {
      goto label_0000_D90E_0D90E;
    }
    CheckExternalEvents(cs1, 0xD8F0);
    // MOV BX,word ptr [BP + -0x12] (0000_D8ED / 0xD8ED)
    BX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0xD8F4);
    // MOV ES,word ptr [0x5516] (0000_D8F0 / 0xD8F0)
    ES = UInt16[DS, 0x5516];
    CheckExternalEvents(cs1, 0xD8FA);
    // MOV byte ptr ES:[BX + 0x45de],0x1 (0000_D8F4 / 0xD8F4)
    UInt8[ES, (ushort)(BX + 0x45DE)] = 0x1;
    CheckExternalEvents(cs1, 0xD8FD);
    // MOV BX,word ptr [BP + -0xc] (0000_D8FA / 0xD8FA)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0xD903);
    // MOV byte ptr ES:[BX + 0x45de],0x1 (0000_D8FD / 0xD8FD)
    UInt8[ES, (ushort)(BX + 0x45DE)] = 0x1;
    CheckExternalEvents(cs1, 0xD906);
    // MOV BX,word ptr [BP + -0x14] (0000_D903 / 0xD903)
    BX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0xD90C);
    // MOV byte ptr ES:[BX + 0x45de],0x1 (0000_D906 / 0xD906)
    UInt8[ES, (ushort)(BX + 0x45DE)] = 0x1;
    CheckExternalEvents(cs1, 0xD90E);
    // JMP 0x0000:d924 (0000_D90C / 0xD90C)
    goto label_0000_D924_0D924;
    label_0000_D90E_0D90E:
    CheckExternalEvents(cs1, 0xD912);
    // MOV ES,word ptr [0x54fa] (0000_D90E / 0xD90E)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD918);
    // MOV byte ptr ES:[0xd347],0xff (0000_D912 / 0xD912)
    UInt8[ES, 0xD347] = 0xFF;
    CheckExternalEvents(cs1, 0xD91E);
    // MOV byte ptr ES:[0xd348],0xff (0000_D918 / 0xD918)
    UInt8[ES, 0xD348] = 0xFF;
    CheckExternalEvents(cs1, 0xD924);
    // MOV byte ptr ES:[0xd349],0xff (0000_D91E / 0xD91E)
    UInt8[ES, 0xD349] = 0xFF;
    label_0000_D924_0D924:
    CheckExternalEvents(cs1, 0xD927);
    // MOV BX,word ptr [BP + -0xe] (0000_D924 / 0xD924)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xD92B);
    // MOV ES,word ptr [0x54fa] (0000_D927 / 0xD927)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD931);
    // MOV byte ptr ES:[BX + 0xd34f],0x1 (0000_D92B / 0xD92B)
    UInt8[ES, (ushort)(BX + 0xD34F)] = 0x1;
    CheckExternalEvents(cs1, 0xD935);
    // CMP word ptr [BP + 0xa],-0x1 (0000_D931 / 0xD931)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0xA)], 0xFFFF);
    CheckExternalEvents(cs1, 0xD937);
    // JNZ 0x0000:d943 (0000_D935 / 0xD935)
    if(!ZeroFlag) {
      goto label_0000_D943_0D943;
    }
    CheckExternalEvents(cs1, 0xD93A);
    // MOV AX,0xa (0000_D937 / 0xD937)
    AX = 0xA;
    CheckExternalEvents(cs1, 0xD93B);
    // PUSH AX (0000_D93A / 0xD93A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD940);
    // CALLF 0x0000:30bf (0000_D93B / 0xD93B)
    FarCall(cs1, 0xD940, ghidra_guess_0000_30BF_030BF);
    CheckExternalEvents(cs1, 0xD943);
    // ADD SP,0x2 (0000_D940 / 0xD940)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0000_D943_0D943:
    CheckExternalEvents(cs1, 0xD946);
    // MOV AX,word ptr [BP + 0x8] (0000_D943 / 0xD943)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0xD949);
    // AND AX,0x70 (0000_D946 / 0xD946)
    // AX &= 0x70;
    AX = Alu.And16(AX, 0x70);
    CheckExternalEvents(cs1, 0xD94B);
    // MOV CL,0x5 (0000_D949 / 0xD949)
    CL = 0x5;
    CheckExternalEvents(cs1, 0xD94D);
    // SHL AX,CL (0000_D94B / 0xD94B)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs1, 0xD950);
    // MOV CX,word ptr [BP + 0x8] (0000_D94D / 0xD94D)
    CX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0xD953);
    // AND CX,0xe (0000_D950 / 0xD950)
    CX &= 0xE;
    CheckExternalEvents(cs1, 0xD955);
    // SHL CX,0x1 (0000_D953 / 0xD953)
    CX <<= 0x1;
    CheckExternalEvents(cs1, 0xD957);
    // SHL CX,0x1 (0000_D955 / 0xD955)
    CX <<= 0x1;
    CheckExternalEvents(cs1, 0xD959);
    // ADD AX,CX (0000_D957 / 0xD957)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    CheckExternalEvents(cs1, 0xD95C);
    // MOV word ptr [BP + 0x8],AX (0000_D959 / 0xD959)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    CheckExternalEvents(cs1, 0xD95F);
    // MOV AX,word ptr [BP + 0x6] (0000_D95C / 0xD95C)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xD961);
    // SAR AX,0x1 (0000_D95F / 0xD95F)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs1, 0xD964);
    // AND AX,0x7 (0000_D961 / 0xD961)
    // AX &= 0x7;
    AX = Alu.And16(AX, 0x7);
    CheckExternalEvents(cs1, 0xD967);
    // MOV word ptr [BP + -0x2],AX (0000_D964 / 0xD964)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0xD96A);
    // MOV AX,word ptr [BP + 0x6] (0000_D967 / 0xD967)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xD96D);
    // AND AX,0x70 (0000_D96A / 0xD96A)
    AX &= 0x70;
    CheckExternalEvents(cs1, 0xD96F);
    // SHL AX,0x1 (0000_D96D / 0xD96D)
    AX <<= 0x1;
    CheckExternalEvents(cs1, 0xD971);
    // SHL AX,0x1 (0000_D96F / 0xD96F)
    AX <<= 0x1;
    CheckExternalEvents(cs1, 0xD974);
    // ADD AX,word ptr [BP + -0x2] (0000_D971 / 0xD971)
    AX += UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD977);
    // ADD word ptr [BP + 0x8],AX (0000_D974 / 0xD974)
    // UInt16[SS, (ushort)(BP + 0x8)] += AX;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu.Add16(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs1, 0xD97C);
    // MOV word ptr [BP + -0x4],0x0 (0000_D977 / 0xD977)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_D97C_0D97C:
    CheckExternalEvents(cs1, 0xD97F);
    // MOV AX,word ptr [BP + -0x2] (0000_D97C / 0xD97C)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD982);
    // MOV word ptr [BP + 0x6],AX (0000_D97F / 0xD97F)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs1, 0xD987);
    // MOV word ptr [BP + -0xa],0x0 (0000_D982 / 0xD982)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs1, 0xD98B);
    // CMP word ptr [BP + 0xa],-0x1 (0000_D987 / 0xD987)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0xA)], 0xFFFF);
    CheckExternalEvents(cs1, 0xD98D);
    // JZ 0x0000:d992 (0000_D98B / 0xD98B)
    if(ZeroFlag) {
      goto label_0000_D992_0D992;
    }
    CheckExternalEvents(cs1, 0xD992);
    // MOV word ptr [BP + -0x4],0x2 (0000_D98D / 0xD98D)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x2;
    label_0000_D992_0D992:
    CheckExternalEvents(cs1, 0xD997);
    // MOV word ptr [BP + -0x10],0x0 (0000_D992 / 0xD992)
    UInt16[SS, (ushort)(BP - 0x10)] = 0x0;
    label_0000_D997_0D997:
    CheckExternalEvents(cs1, 0xD99A);
    // MOV SI,word ptr [BP + -0x4] (0000_D997 / 0xD997)
    SI = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xD99C);
    // SHL SI,0x1 (0000_D99A / 0xD99A)
    SI <<= 0x1;
    CheckExternalEvents(cs1, 0xD99E);
    // SHL SI,0x1 (0000_D99C / 0xD99C)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0xD9A1);
    // MOV BX,word ptr [BP + -0x10] (0000_D99E / 0xD99E)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs1, 0xD9A5);
    // MOV AL,byte ptr [BX + SI + 0x246e] (0000_D9A1 / 0xD9A1)
    AL = UInt8[DS, (ushort)(BX + SI + 0x246E)];
    CheckExternalEvents(cs1, 0xD9A8);
    // MOV BX,word ptr [BP + 0x8] (0000_D9A5 / 0xD9A5)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0xD9AB);
    // ADD BX,word ptr [BP + -0xa] (0000_D9A8 / 0xD9A8)
    // BX += UInt16[SS, (ushort)(BP - 0xA)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0xD9AF);
    // MOV ES,word ptr [0x550c] (0000_D9AB / 0xD9AB)
    ES = UInt16[DS, 0x550C];
    CheckExternalEvents(cs1, 0xD9B4);
    // MOV byte ptr ES:[BX + 0x101d],AL (0000_D9AF / 0xD9AF)
    UInt8[ES, (ushort)(BX + 0x101D)] = AL;
    CheckExternalEvents(cs1, 0xD9B7);
    // INC word ptr [BP + 0x6] (0000_D9B4 / 0xD9B4)
    UInt16[SS, (ushort)(BP + 0x6)]++;
    CheckExternalEvents(cs1, 0xD9BA);
    // INC word ptr [BP + -0xa] (0000_D9B7 / 0xD9B7)
    UInt16[SS, (ushort)(BP - 0xA)]++;
    CheckExternalEvents(cs1, 0xD9BE);
    // CMP word ptr [BP + 0x6],0x8 (0000_D9BA / 0xD9BA)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x8);
    CheckExternalEvents(cs1, 0xD9C0);
    // JNZ 0x0000:d9c4 (0000_D9BE / 0xD9BE)
    if(!ZeroFlag) {
      goto label_0000_D9C4_0D9C4;
    }
    CheckExternalEvents(cs1, 0xD9C4);
    // ADD word ptr [BP + -0xa],0x38 (0000_D9C0 / 0xD9C0)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x38;
    label_0000_D9C4_0D9C4:
    CheckExternalEvents(cs1, 0xD9C7);
    // INC word ptr [BP + -0x10] (0000_D9C4 / 0xD9C4)
    UInt16[SS, (ushort)(BP - 0x10)]++;
    CheckExternalEvents(cs1, 0xD9CB);
    // CMP word ptr [BP + -0x10],0x4 (0000_D9C7 / 0xD9C7)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x4);
    CheckExternalEvents(cs1, 0xD9CD);
    // JL 0x0000:d997 (0000_D9CB / 0xD9CB)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D997_0D997;
    }
    CheckExternalEvents(cs1, 0xD9D1);
    // MOV ES,word ptr [0x5500] (0000_D9CD / 0xD9CD)
    ES = UInt16[DS, 0x5500];
    CheckExternalEvents(cs1, 0xD9D6);
    // PUSH word ptr ES:[0xa44d] (0000_D9D1 / 0xD9D1)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0xD9DA);
    // MOV ES,word ptr [0x54fe] (0000_D9D6 / 0xD9D6)
    ES = UInt16[DS, 0x54FE];
    CheckExternalEvents(cs1, 0xD9DF);
    // PUSH word ptr ES:[0xa44b] (0000_D9DA / 0xD9DA)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs1, 0xD9E4);
    // CALLF 0x1000:b204 (0000_D9DF / 0xD9DF)
    FarCall(cs1, 0xD9E4, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs1, 0xD9E7);
    // ADD SP,0x4 (0000_D9E4 / 0xD9E4)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD9EC);
    // CALLF 0x1000:b7df (0000_D9E7 / 0xD9E7)
    FarCall(cs1, 0xD9EC, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs1, 0xD9F1);
    // CALLF 0x0000:1c1b (0000_D9EC / 0xD9EC)
    FarCall(cs1, 0xD9F1, unknown_0170_051B_01C1B);
    CheckExternalEvents(cs1, 0xD9F6);
    // CALLF 0x1000:9193 (0000_D9F1 / 0xD9F1)
    FarCall(cs1, 0xD9F6, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs1, 0xD9FA);
    // CMP word ptr [BP + 0xa],-0x1 (0000_D9F6 / 0xD9F6)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0xA)], 0xFFFF);
    CheckExternalEvents(cs1, 0xD9FC);
    // JNZ 0x0000:da08 (0000_D9FA / 0xD9FA)
    if(!ZeroFlag) {
      goto label_0000_DA08_0DA08;
    }
    CheckExternalEvents(cs1, 0xD9FF);
    // MOV AX,0x14 (0000_D9FC / 0xD9FC)
    AX = 0x14;
    CheckExternalEvents(cs1, 0xDA00);
    // PUSH AX (0000_D9FF / 0xD9FF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDA05);
    // CALLF 0x1000:8ad6 (0000_DA00 / 0xDA00)
    FarCall(cs1, 0xDA05, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs1, 0xDA08);
    // ADD SP,0x2 (0000_DA05 / 0xDA05)
    SP += 0x2;
    label_0000_DA08_0DA08:
    CheckExternalEvents(cs1, 0xDA0B);
    // INC word ptr [BP + -0x4] (0000_DA08 / 0xDA08)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs1, 0xDA0F);
    // CMP word ptr [BP + -0x4],0x3 (0000_DA0B / 0xDA0B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x3);
    CheckExternalEvents(cs1, 0xDA11);
    // JGE 0x0000:da14 (0000_DA0F / 0xDA0F)
    if(SignFlag == OverflowFlag) {
      goto label_0000_DA14_0DA14;
    }
    CheckExternalEvents(cs1, 0xDA14);
    // JMP 0x0000:d97c (0000_DA11 / 0xDA11)
    goto label_0000_D97C_0D97C;
    label_0000_DA14_0DA14:
    CheckExternalEvents(cs1, 0xDA15);
    // POP SI (0000_DA14 / 0xDA14)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xDA17);
    // MOV SP,BP (0000_DA15 / 0xDA15)
    SP = BP;
    CheckExternalEvents(cs1, 0xDA18);
    // POP BP (0000_DA17 / 0xDA17)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xDA19);
    // RETF  (0000_DA18 / 0xDA18)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_DA1A_0DA1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_DA1A_0DA1A:
    CheckExternalEvents(cs1, 0xDA1B);
    // PUSH BP (0000_DA1A / 0xDA1A)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xDA1D);
    // MOV BP,SP (0000_DA1B / 0xDA1B)
    BP = SP;
    CheckExternalEvents(cs1, 0xDA20);
    // MOV AX,0x1a (0000_DA1D / 0xDA1D)
    AX = 0x1A;
    CheckExternalEvents(cs1, 0xDA25);
    // CALLF 0x1000:cecc (0000_DA20 / 0xDA20)
    FarCall(cs1, 0xDA25, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xDA26);
    // PUSH DI (0000_DA25 / 0xDA25)
    Stack.Push16(DI);
    CheckExternalEvents(cs1, 0xDA27);
    // PUSH SI (0000_DA26 / 0xDA26)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xDA2B);
    // MOV ES,word ptr [0x5522] (0000_DA27 / 0xDA27)
    ES = UInt16[DS, 0x5522];
    CheckExternalEvents(cs1, 0xDA31);
    // CMP byte ptr ES:[0xd335],0x0 (0000_DA2B / 0xDA2B)
    Alu.Sub8(UInt8[ES, 0xD335], 0x0);
    CheckExternalEvents(cs1, 0xDA33);
    // JZ 0x0000:da36 (0000_DA31 / 0xDA31)
    if(ZeroFlag) {
      goto label_0000_DA36_0DA36;
    }
    CheckExternalEvents(cs1, 0xDA36);
    // JMP 0x0000:dd0b (0000_DA33 / 0xDA33)
    goto label_0000_DD0B_0DD0B;
    label_0000_DA36_0DA36:
    CheckExternalEvents(cs1, 0xDA38);
    // SUB AX,AX (0000_DA36 / 0xDA36)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xDA3B);
    // MOV word ptr [BP + -0xe],AX (0000_DA38 / 0xDA38)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs1, 0xDA3E);
    // MOV word ptr [BP + -0xc],AX (0000_DA3B / 0xDA3B)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0xDA41);
    // MOV word ptr [BP + -0x6],AX (0000_DA3E / 0xDA3E)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0xDA44);
    // MOV word ptr [BP + -0x16],AX (0000_DA41 / 0xDA41)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    label_0000_DA44_0DA44:
    CheckExternalEvents(cs1, 0xDA47);
    // MOV AX,0x11 (0000_DA44 / 0xDA44)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xDA4A);
    // IMUL word ptr [BP + -0x16] (0000_DA47 / 0xDA47)
    int resImul0000_DA47 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x16)]);
    AX = (ushort)(resImul0000_DA47);
    DX = (ushort)(resImul0000_DA47 >> 16);
    CheckExternalEvents(cs1, 0xDA4C);
    // MOV SI,AX (0000_DA4A / 0xDA4A)
    SI = AX;
    CheckExternalEvents(cs1, 0xDA50);
    // MOV ES,word ptr [0x5522] (0000_DA4C / 0xDA4C)
    ES = UInt16[DS, 0x5522];
    CheckExternalEvents(cs1, 0xDA56);
    // CMP byte ptr ES:[SI + 0xc614],0xff (0000_DA50 / 0xDA50)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC614)], 0xFF);
    CheckExternalEvents(cs1, 0xDA58);
    // JZ 0x0000:da6e (0000_DA56 / 0xDA56)
    if(ZeroFlag) {
      goto label_0000_DA6E_0DA6E;
    }
    CheckExternalEvents(cs1, 0xDA5D);
    // MOV AL,byte ptr ES:[SI + 0xc61e] (0000_DA58 / 0xDA58)
    AL = UInt8[ES, (ushort)(SI + 0xC61E)];
    CheckExternalEvents(cs1, 0xDA5E);
    // CBW  (0000_DA5D / 0xDA5D)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xDA60);
    // MOV DI,AX (0000_DA5E / 0xDA5E)
    DI = AX;
    CheckExternalEvents(cs1, 0xDA63);
    // CMP word ptr [BP + -0xc],DI (0000_DA60 / 0xDA60)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], DI);
    CheckExternalEvents(cs1, 0xDA65);
    // JGE 0x0000:da6e (0000_DA63 / 0xDA63)
    if(SignFlag == OverflowFlag) {
      goto label_0000_DA6E_0DA6E;
    }
    CheckExternalEvents(cs1, 0xDA68);
    // MOV AX,word ptr [BP + -0x16] (0000_DA65 / 0xDA65)
    AX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs1, 0xDA6B);
    // MOV word ptr [BP + -0x6],AX (0000_DA68 / 0xDA68)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0xDA6E);
    // MOV word ptr [BP + -0xc],DI (0000_DA6B / 0xDA6B)
    UInt16[SS, (ushort)(BP - 0xC)] = DI;
    label_0000_DA6E_0DA6E:
    CheckExternalEvents(cs1, 0xDA71);
    // INC word ptr [BP + -0x16] (0000_DA6E / 0xDA6E)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    CheckExternalEvents(cs1, 0xDA75);
    // CMP word ptr [BP + -0x16],0x8 (0000_DA71 / 0xDA71)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x8);
    CheckExternalEvents(cs1, 0xDA77);
    // JL 0x0000:da44 (0000_DA75 / 0xDA75)
    if(SignFlag != OverflowFlag) {
      goto label_0000_DA44_0DA44;
    }
    CheckExternalEvents(cs1, 0xDA7A);
    // MOV AX,0x17 (0000_DA77 / 0xDA77)
    AX = 0x17;
    CheckExternalEvents(cs1, 0xDA7B);
    // PUSH AX (0000_DA7A / 0xDA7A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDA80);
    // CALLF 0x1000:6434 (0000_DA7B / 0xDA7B)
    FarCall(cs1, 0xDA80, unknown_1643_0004_16434);
    CheckExternalEvents(cs1, 0xDA83);
    // ADD SP,0x2 (0000_DA80 / 0xDA80)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xDA87);
    // MOV ES,word ptr [0x5522] (0000_DA83 / 0xDA83)
    ES = UInt16[DS, 0x5522];
    CheckExternalEvents(cs1, 0xDA8D);
    // CMP byte ptr ES:[0xd325],0x0 (0000_DA87 / 0xDA87)
    Alu.Sub8(UInt8[ES, 0xD325], 0x0);
    CheckExternalEvents(cs1, 0xDA8F);
    // JNZ 0x0000:da92 (0000_DA8D / 0xDA8D)
    if(!ZeroFlag) {
      goto label_0000_DA92_0DA92;
    }
    CheckExternalEvents(cs1, 0xDA92);
    // JMP 0x0000:dcec (0000_DA8F / 0xDA8F)
    goto label_0000_DCEC_0DCEC;
    label_0000_DA92_0DA92:
    CheckExternalEvents(cs1, 0xDA95);
    // MOV AX,0x1 (0000_DA92 / 0xDA92)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xDA96);
    // PUSH AX (0000_DA95 / 0xDA95)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDA9B);
    // CALLF 0x1000:7ee1 (0000_DA96 / 0xDA96)
    FarCall(cs1, 0xDA9B, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xDA9E);
    // ADD SP,0x2 (0000_DA9B / 0xDA9B)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xDAA1);
    // MOV AX,0x1 (0000_DA9E / 0xDA9E)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xDAA2);
    // PUSH AX (0000_DAA1 / 0xDAA1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDAA7);
    // CALLF 0x1000:7c64 (0000_DAA2 / 0xDAA2)
    FarCall(cs1, 0xDAA7, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0xDAAA);
    // ADD SP,0x2 (0000_DAA7 / 0xDAA7)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xDAAF);
    // CALLF 0x1000:7fe8 (0000_DAAA / 0xDAAA)
    FarCall(cs1, 0xDAAF, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xDAB4);
    // MOV word ptr [BP + -0x8],0x1 (0000_DAAF / 0xDAAF)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    CheckExternalEvents(cs1, 0xDAB8);
    // MOV ES,word ptr [0x5522] (0000_DAB4 / 0xDAB4)
    ES = UInt16[DS, 0x5522];
    CheckExternalEvents(cs1, 0xDABE);
    // CMP byte ptr ES:[0xd450],0x0 (0000_DAB8 / 0xDAB8)
    Alu.Sub8(UInt8[ES, 0xD450], 0x0);
    CheckExternalEvents(cs1, 0xDAC0);
    // JZ 0x0000:dac3 (0000_DABE / 0xDABE)
    if(ZeroFlag) {
      goto label_0000_DAC3_0DAC3;
    }
    CheckExternalEvents(cs1, 0xDAC3);
    // INC word ptr [BP + -0x8] (0000_DAC0 / 0xDAC0)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    label_0000_DAC3_0DAC3:
    CheckExternalEvents(cs1, 0xDAC7);
    // CMP word ptr [BP + -0xc],0x3 (0000_DAC3 / 0xDAC3)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x3);
    CheckExternalEvents(cs1, 0xDAC9);
    // JL 0x0000:dad6 (0000_DAC7 / 0xDAC7)
    if(SignFlag != OverflowFlag) {
      goto label_0000_DAD6_0DAD6;
    }
    CheckExternalEvents(cs1, 0xDACF);
    // CMP byte ptr ES:[0xd451],0x0 (0000_DAC9 / 0xDAC9)
    Alu.Sub8(UInt8[ES, 0xD451], 0x0);
    CheckExternalEvents(cs1, 0xDAD1);
    // JZ 0x0000:dad6 (0000_DACF / 0xDACF)
    if(ZeroFlag) {
      goto label_0000_DAD6_0DAD6;
    }
    CheckExternalEvents(cs1, 0xDAD6);
    // MOV word ptr [BP + -0x8],0x3 (0000_DAD1 / 0xDAD1)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x3;
    label_0000_DAD6_0DAD6:
    CheckExternalEvents(cs1, 0xDADA);
    // CMP word ptr [BP + 0x6],0x0 (0000_DAD6 / 0xDAD6)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs1, 0xDADC);
    // JZ 0x0000:db01 (0000_DADA / 0xDADA)
    if(ZeroFlag) {
      goto label_0000_DB01_0DB01;
    }
    CheckExternalEvents(cs1, 0xDAE1);
    // MOV word ptr [BP + -0x8],0x2 (0000_DADC / 0xDADC)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x2;
    CheckExternalEvents(cs1, 0xDAE5);
    // CMP word ptr [BP + 0x6],0x2 (0000_DAE1 / 0xDAE1)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x2);
    CheckExternalEvents(cs1, 0xDAE7);
    // JLE 0x0000:daec (0000_DAE5 / 0xDAE5)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_DAEC_0DAEC;
    }
    CheckExternalEvents(cs1, 0xDAEC);
    // MOV word ptr [BP + -0x8],0x4 (0000_DAE7 / 0xDAE7)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x4;
    label_0000_DAEC_0DAEC:
    CheckExternalEvents(cs1, 0xDAEF);
    // MOV AX,0x252d (0000_DAEC / 0xDAEC)
    AX = 0x252D;
    CheckExternalEvents(cs1, 0xDAF0);
    // PUSH DS (0000_DAEF / 0xDAEF)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xDAF1);
    // PUSH AX (0000_DAF0 / 0xDAF0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDAF6);
    // CALLF 0x1000:8055 (0000_DAF1 / 0xDAF1)
    FarCall(cs1, 0xDAF6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xDAF9);
    // ADD SP,0x4 (0000_DAF6 / 0xDAF6)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xDAFC);
    // MOV AX,word ptr [BP + 0x6] (0000_DAF9 / 0xDAF9)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xDAFF);
    // MOV word ptr [BP + -0xc],AX (0000_DAFC / 0xDAFC)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0xDB01);
    // JMP 0x0000:db2f (0000_DAFF / 0xDAFF)
    goto label_0000_DB2F_0DB2F;
    label_0000_DB01_0DB01:
    CheckExternalEvents(cs1, 0xDB04);
    // MOV AX,0x11 (0000_DB01 / 0xDB01)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xDB07);
    // IMUL word ptr [BP + -0x6] (0000_DB04 / 0xDB04)
    int resImul0000_DB04 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x6)]);
    AX = (ushort)(resImul0000_DB04);
    DX = (ushort)(resImul0000_DB04 >> 16);
    CheckExternalEvents(cs1, 0xDB09);
    // MOV BX,AX (0000_DB07 / 0xDB07)
    BX = AX;
    CheckExternalEvents(cs1, 0xDB0D);
    // MOV ES,word ptr [0x5522] (0000_DB09 / 0xDB09)
    ES = UInt16[DS, 0x5522];
    CheckExternalEvents(cs1, 0xDB12);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_DB0D / 0xDB0D)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0xDB13);
    // CBW  (0000_DB12 / 0xDB12)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xDB15);
    // MOV BX,AX (0000_DB13 / 0xDB13)
    BX = AX;
    CheckExternalEvents(cs1, 0xDB17);
    // SHL BX,0x1 (0000_DB15 / 0xDB15)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xDB19);
    // SHL BX,0x1 (0000_DB17 / 0xDB17)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xDB1D);
    // MOV ES,word ptr [0x5524] (0000_DB19 / 0xDB19)
    ES = UInt16[DS, 0x5524];
    CheckExternalEvents(cs1, 0xDB22);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_DB1D / 0xDB1D)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0xDB27);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_DB22 / 0xDB22)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0xDB2C);
    // CALLF 0x1000:8055 (0000_DB27 / 0xDB27)
    FarCall(cs1, 0xDB2C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xDB2F);
    // ADD SP,0x4 (0000_DB2C / 0xDB2C)
    SP += 0x4;
    label_0000_DB2F_0DB2F:
    CheckExternalEvents(cs1, 0xDB33);
    // CMP word ptr [BP + -0xc],0x0 (0000_DB2F / 0xDB2F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs1, 0xDB35);
    // JZ 0x0000:db9e (0000_DB33 / 0xDB33)
    if(ZeroFlag) {
      goto label_0000_DB9E_0DB9E;
    }
    CheckExternalEvents(cs1, 0xDB38);
    // MOV AX,0x2538 (0000_DB35 / 0xDB35)
    AX = 0x2538;
    CheckExternalEvents(cs1, 0xDB39);
    // PUSH DS (0000_DB38 / 0xDB38)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xDB3A);
    // PUSH AX (0000_DB39 / 0xDB39)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDB3F);
    // CALLF 0x1000:8055 (0000_DB3A / 0xDB3A)
    FarCall(cs1, 0xDB3F, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xDB42);
    // ADD SP,0x4 (0000_DB3F / 0xDB3F)
    SP += 0x4;
    CheckExternalEvents(cs1, 0xDB46);
    // CMP word ptr [BP + -0xc],0x5 (0000_DB42 / 0xDB42)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x5);
    CheckExternalEvents(cs1, 0xDB48);
    // JGE 0x0000:db70 (0000_DB46 / 0xDB46)
    if(SignFlag == OverflowFlag) {
      goto label_0000_DB70_0DB70;
    }
    CheckExternalEvents(cs1, 0xDB4C);
    // CMP word ptr [BP + -0xc],0x3 (0000_DB48 / 0xDB48)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x3);
    CheckExternalEvents(cs1, 0xDB4E);
    // JGE 0x0000:db5f (0000_DB4C / 0xDB4C)
    if(SignFlag == OverflowFlag) {
      goto label_0000_DB5F_0DB5F;
    }
    CheckExternalEvents(cs1, 0xDB51);
    // MOV BX,word ptr [BP + -0xc] (0000_DB4E / 0xDB4E)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0xDB53);
    // SHL BX,0x1 (0000_DB51 / 0xDB51)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xDB55);
    // SHL BX,0x1 (0000_DB53 / 0xDB53)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xDB59);
    // PUSH word ptr [BX + 0x25e0] (0000_DB55 / 0xDB55)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x25E0)]);
    CheckExternalEvents(cs1, 0xDB5D);
    // PUSH word ptr [BX + 0x25de] (0000_DB59 / 0xDB59)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x25DE)]);
    CheckExternalEvents(cs1, 0xDB5F);
    // JMP 0x0000:db78 (0000_DB5D / 0xDB5D)
    goto label_0000_DB78_0DB78;
    label_0000_DB5F_0DB5F:
    CheckExternalEvents(cs1, 0xDB62);
    // MOV BX,word ptr [BP + -0xc] (0000_DB5F / 0xDB5F)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0xDB64);
    // SHL BX,0x1 (0000_DB62 / 0xDB62)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xDB66);
    // SHL BX,0x1 (0000_DB64 / 0xDB64)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xDB6A);
    // PUSH word ptr [BX + 0x25dc] (0000_DB66 / 0xDB66)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x25DC)]);
    CheckExternalEvents(cs1, 0xDB6E);
    // PUSH word ptr [BX + 0x25da] (0000_DB6A / 0xDB6A)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x25DA)]);
    CheckExternalEvents(cs1, 0xDB70);
    // JMP 0x0000:db78 (0000_DB6E / 0xDB6E)
    goto label_0000_DB78_0DB78;
    label_0000_DB70_0DB70:
    CheckExternalEvents(cs1, 0xDB74);
    // PUSH word ptr [0x25f0] (0000_DB70 / 0xDB70)
    Stack.Push16(UInt16[DS, 0x25F0]);
    CheckExternalEvents(cs1, 0xDB78);
    // PUSH word ptr [0x25ee] (0000_DB74 / 0xDB74)
    Stack.Push16(UInt16[DS, 0x25EE]);
    label_0000_DB78_0DB78:
    CheckExternalEvents(cs1, 0xDB7D);
    // CALLF 0x1000:8055 (0000_DB78 / 0xDB78)
    FarCall(cs1, 0xDB7D, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xDB80);
    // ADD SP,0x4 (0000_DB7D / 0xDB7D)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xDB83);
    // MOV AX,0x2543 (0000_DB80 / 0xDB80)
    AX = 0x2543;
    CheckExternalEvents(cs1, 0xDB84);
    // PUSH DS (0000_DB83 / 0xDB83)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xDB85);
    // PUSH AX (0000_DB84 / 0xDB84)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDB8A);
    // CALLF 0x1000:8055 (0000_DB85 / 0xDB85)
    FarCall(cs1, 0xDB8A, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xDB8D);
    // ADD SP,0x4 (0000_DB8A / 0xDB8A)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xDB90);
    // MOV BX,word ptr [BP + -0x8] (0000_DB8D / 0xDB8D)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0xDB92);
    // SHL BX,0x1 (0000_DB90 / 0xDB90)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xDB94);
    // SHL BX,0x1 (0000_DB92 / 0xDB92)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xDB98);
    // PUSH word ptr [BX + 0x25f0] (0000_DB94 / 0xDB94)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x25F0)]);
    CheckExternalEvents(cs1, 0xDB9C);
    // PUSH word ptr [BX + 0x25ee] (0000_DB98 / 0xDB98)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x25EE)]);
    CheckExternalEvents(cs1, 0xDB9E);
    // JMP 0x0000:dba3 (0000_DB9C / 0xDB9C)
    goto label_0000_DBA3_0DBA3;
    label_0000_DB9E_0DB9E:
    CheckExternalEvents(cs1, 0xDBA1);
    // MOV AX,0x2553 (0000_DB9E / 0xDB9E)
    AX = 0x2553;
    CheckExternalEvents(cs1, 0xDBA2);
    // PUSH DS (0000_DBA1 / 0xDBA1)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xDBA3);
    // PUSH AX (0000_DBA2 / 0xDBA2)
    Stack.Push16(AX);
    label_0000_DBA3_0DBA3:
    CheckExternalEvents(cs1, 0xDBA8);
    // CALLF 0x1000:8055 (0000_DBA3 / 0xDBA3)
    FarCall(cs1, 0xDBA8, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xDBAB);
    // ADD SP,0x4 (0000_DBA8 / 0xDBA8)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xDBAE);
    // MOV AX,0x256f (0000_DBAB / 0xDBAB)
    AX = 0x256F;
    CheckExternalEvents(cs1, 0xDBAF);
    // PUSH DS (0000_DBAE / 0xDBAE)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xDBB0);
    // PUSH AX (0000_DBAF / 0xDBAF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDBB5);
    // CALLF 0x1000:8055 (0000_DBB0 / 0xDBB0)
    FarCall(cs1, 0xDBB5, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xDBB8);
    // ADD SP,0x4 (0000_DBB5 / 0xDBB5)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xDBBD);
    // CALLF 0x0000:3fa2 (0000_DBB8 / 0xDBB8)
    FarCall(cs1, 0xDBBD, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0xDBC2);
    // MOV word ptr [BP + -0x16],0x0 (0000_DBBD / 0xDBBD)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    CheckExternalEvents(cs1, 0xDBC4);
    // JMP 0x0000:dc1a (0000_DBC2 / 0xDBC2)
    goto label_0000_DC1A_0DC1A;
    label_0000_DBC4_0DBC4:
    CheckExternalEvents(cs1, 0xDBC9);
    // CALLF 0x0000:30f3 (0000_DBC4 / 0xDBC4)
    FarCall(cs1, 0xDBC9, ghidra_guess_0000_30F3_030F3);
    CheckExternalEvents(cs1, 0xDBCC);
    // ADD word ptr [BP + -0x2],AX (0000_DBC9 / 0xDBC9)
    // UInt16[SS, (ushort)(BP - 0x2)] += AX;
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x2)], AX);
    label_0000_DBCC_0DBCC:
    CheckExternalEvents(cs1, 0xDBCF);
    // MOV AX,word ptr [BP + -0xa] (0000_DBCC / 0xDBCC)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0xDBD2);
    // DEC word ptr [BP + -0xa] (0000_DBCF / 0xDBCF)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu.Dec16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0xDBD4);
    // OR AX,AX (0000_DBD2 / 0xDBD2)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs1, 0xDBD6);
    // JNZ 0x0000:dbc4 (0000_DBD4 / 0xDBD4)
    if(!ZeroFlag) {
      goto label_0000_DBC4_0DBC4;
    }
    CheckExternalEvents(cs1, 0xDBD9);
    // MOV AX,word ptr [BP + -0x12] (0000_DBD6 / 0xDBD6)
    AX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0xDBDC);
    // IMUL word ptr [BP + -0x2] (0000_DBD9 / 0xDBD9)
    int resImul0000_DBD9 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul0000_DBD9);
    DX = (ushort)(resImul0000_DBD9 >> 16);
    CheckExternalEvents(cs1, 0xDBDF);
    // MOV word ptr [BP + -0x2],AX (0000_DBDC / 0xDBDC)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0xDBE2);
    // MOV AX,0x11 (0000_DBDF / 0xDBDF)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xDBE5);
    // IMUL word ptr [BP + -0x16] (0000_DBE2 / 0xDBE2)
    int resImul0000_DBE2 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x16)]);
    AX = (ushort)(resImul0000_DBE2);
    DX = (ushort)(resImul0000_DBE2 >> 16);
    CheckExternalEvents(cs1, 0xDBE7);
    // MOV BX,AX (0000_DBE5 / 0xDBE5)
    BX = AX;
    CheckExternalEvents(cs1, 0xDBEB);
    // MOV ES,word ptr [0x5522] (0000_DBE7 / 0xDBE7)
    ES = UInt16[DS, 0x5522];
    CheckExternalEvents(cs1, 0xDBF0);
    // MOV AL,byte ptr ES:[BX + 0xc623] (0000_DBEB / 0xDBEB)
    AL = UInt8[ES, (ushort)(BX + 0xC623)];
    CheckExternalEvents(cs1, 0xDBF1);
    // CBW  (0000_DBF0 / 0xDBF0)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xDBF4);
    // MOV word ptr [BP + -0x10],AX (0000_DBF1 / 0xDBF1)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0xDBF7);
    // MOV AX,word ptr [BP + -0x2] (0000_DBF4 / 0xDBF4)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xDBFA);
    // ADD word ptr [BP + -0x10],AX (0000_DBF7 / 0xDBF7)
    // UInt16[SS, (ushort)(BP - 0x10)] += AX;
    UInt16[SS, (ushort)(BP - 0x10)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x10)], AX);
    CheckExternalEvents(cs1, 0xDBFD);
    // MOV AX,word ptr [BP + -0x1a] (0000_DBFA / 0xDBFA)
    AX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs1, 0xDC00);
    // CMP word ptr [BP + -0x10],AX (0000_DBFD / 0xDBFD)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], AX);
    CheckExternalEvents(cs1, 0xDC02);
    // JLE 0x0000:dc05 (0000_DC00 / 0xDC00)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_DC05_0DC05;
    }
    CheckExternalEvents(cs1, 0xDC05);
    // MOV word ptr [BP + -0x10],AX (0000_DC02 / 0xDC02)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    label_0000_DC05_0DC05:
    CheckExternalEvents(cs1, 0xDC08);
    // MOV AL,byte ptr [BP + -0x10] (0000_DC05 / 0xDC05)
    AL = UInt8[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs1, 0xDC0A);
    // MOV CX,AX (0000_DC08 / 0xDC08)
    CX = AX;
    CheckExternalEvents(cs1, 0xDC0D);
    // MOV AX,0x11 (0000_DC0A / 0xDC0A)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xDC10);
    // IMUL word ptr [BP + -0x16] (0000_DC0D / 0xDC0D)
    int resImul0000_DC0D = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x16)]);
    AX = (ushort)(resImul0000_DC0D);
    DX = (ushort)(resImul0000_DC0D >> 16);
    CheckExternalEvents(cs1, 0xDC12);
    // MOV BX,AX (0000_DC10 / 0xDC10)
    BX = AX;
    CheckExternalEvents(cs1, 0xDC17);
    // MOV byte ptr ES:[BX + 0xc623],CL (0000_DC12 / 0xDC12)
    UInt8[ES, (ushort)(BX + 0xC623)] = CL;
    label_0000_DC17_0DC17:
    CheckExternalEvents(cs1, 0xDC1A);
    // INC word ptr [BP + -0x16] (0000_DC17 / 0xDC17)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    label_0000_DC1A_0DC1A:
    CheckExternalEvents(cs1, 0xDC1E);
    // CMP word ptr [BP + -0x16],0x8 (0000_DC1A / 0xDC1A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x8);
    CheckExternalEvents(cs1, 0xDC20);
    // JL 0x0000:dc23 (0000_DC1E / 0xDC1E)
    if(SignFlag != OverflowFlag) {
      goto label_0000_DC23_0DC23;
    }
    CheckExternalEvents(cs1, 0xDC23);
    // JMP 0x0000:dcbf (0000_DC20 / 0xDC20)
    goto label_0000_DCBF_0DCBF;
    label_0000_DC23_0DC23:
    CheckExternalEvents(cs1, 0xDC26);
    // MOV AX,0x11 (0000_DC23 / 0xDC23)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xDC29);
    // IMUL word ptr [BP + -0x16] (0000_DC26 / 0xDC26)
    int resImul0000_DC26 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x16)]);
    AX = (ushort)(resImul0000_DC26);
    DX = (ushort)(resImul0000_DC26 >> 16);
    CheckExternalEvents(cs1, 0xDC2B);
    // MOV SI,AX (0000_DC29 / 0xDC29)
    SI = AX;
    CheckExternalEvents(cs1, 0xDC2F);
    // MOV ES,word ptr [0x5522] (0000_DC2B / 0xDC2B)
    ES = UInt16[DS, 0x5522];
    CheckExternalEvents(cs1, 0xDC35);
    // CMP byte ptr ES:[SI + 0xc614],0xff (0000_DC2F / 0xDC2F)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC614)], 0xFF);
    CheckExternalEvents(cs1, 0xDC37);
    // JZ 0x0000:dc17 (0000_DC35 / 0xDC35)
    if(ZeroFlag) {
      goto label_0000_DC17_0DC17;
    }
    CheckExternalEvents(cs1, 0xDC39);
    // MOV AL,0xa (0000_DC37 / 0xDC37)
    AL = 0xA;
    CheckExternalEvents(cs1, 0xDC3E);
    // IMUL byte ptr ES:[SI + 0xc615] (0000_DC39 / 0xDC39)
    short resImul0000_DC39 = Alu.Imul8((sbyte)AL, (sbyte)UInt8[ES, (ushort)(SI + 0xC615)]);
    AL = (byte)(resImul0000_DC39);
    AH = (byte)(resImul0000_DC39 >> 8);
    CheckExternalEvents(cs1, 0xDC41);
    // MOV word ptr [BP + -0x1a],AX (0000_DC3E / 0xDC3E)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs1, 0xDC46);
    // MOV AL,byte ptr ES:[SI + 0xc623] (0000_DC41 / 0xDC41)
    AL = UInt8[ES, (ushort)(SI + 0xC623)];
    CheckExternalEvents(cs1, 0xDC47);
    // CBW  (0000_DC46 / 0xDC46)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xDC4A);
    // CMP AX,word ptr [BP + -0x1a] (0000_DC47 / 0xDC47)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP - 0x1A)]);
    CheckExternalEvents(cs1, 0xDC4C);
    // JZ 0x0000:dc17 (0000_DC4A / 0xDC4A)
    if(ZeroFlag) {
      goto label_0000_DC17_0DC17;
    }
    CheckExternalEvents(cs1, 0xDC51);
    // CALLF 0x1000:7c4e (0000_DC4C / 0xDC4C)
    FarCall(cs1, 0xDC51, ghidra_guess_1000_7C4E_17C4E);
    CheckExternalEvents(cs1, 0xDC54);
    // MOV AX,0x11 (0000_DC51 / 0xDC51)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xDC57);
    // IMUL word ptr [BP + -0x16] (0000_DC54 / 0xDC54)
    int resImul0000_DC54 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x16)]);
    AX = (ushort)(resImul0000_DC54);
    DX = (ushort)(resImul0000_DC54 >> 16);
    CheckExternalEvents(cs1, 0xDC59);
    // MOV BX,AX (0000_DC57 / 0xDC57)
    BX = AX;
    CheckExternalEvents(cs1, 0xDC5D);
    // MOV ES,word ptr [0x5522] (0000_DC59 / 0xDC59)
    ES = UInt16[DS, 0x5522];
    CheckExternalEvents(cs1, 0xDC62);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_DC5D / 0xDC5D)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0xDC63);
    // CBW  (0000_DC62 / 0xDC62)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xDC65);
    // MOV BX,AX (0000_DC63 / 0xDC63)
    BX = AX;
    CheckExternalEvents(cs1, 0xDC67);
    // SHL BX,0x1 (0000_DC65 / 0xDC65)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xDC69);
    // SHL BX,0x1 (0000_DC67 / 0xDC67)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xDC6D);
    // MOV ES,word ptr [0x5524] (0000_DC69 / 0xDC69)
    ES = UInt16[DS, 0x5524];
    CheckExternalEvents(cs1, 0xDC72);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_DC6D / 0xDC6D)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0xDC77);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_DC72 / 0xDC72)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0xDC7C);
    // CALLF 0x1000:8055 (0000_DC77 / 0xDC77)
    FarCall(cs1, 0xDC7C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xDC7F);
    // ADD SP,0x4 (0000_DC7C / 0xDC7C)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xDC82);
    // MOV AX,0x2587 (0000_DC7F / 0xDC7F)
    AX = 0x2587;
    CheckExternalEvents(cs1, 0xDC83);
    // PUSH DS (0000_DC82 / 0xDC82)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xDC84);
    // PUSH AX (0000_DC83 / 0xDC83)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDC89);
    // CALLF 0x1000:8055 (0000_DC84 / 0xDC84)
    FarCall(cs1, 0xDC89, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xDC8C);
    // ADD SP,0x4 (0000_DC89 / 0xDC89)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xDC8F);
    // MOV DI,word ptr [BP + -0xc] (0000_DC8C / 0xDC8C)
    DI = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0xDC91);
    // SHL DI,0x1 (0000_DC8F / 0xDC8F)
    DI <<= 0x1;
    CheckExternalEvents(cs1, 0xDC93);
    // SHL DI,0x1 (0000_DC91 / 0xDC91)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    CheckExternalEvents(cs1, 0xDC96);
    // MOV BX,word ptr [BP + -0x8] (0000_DC93 / 0xDC93)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0xDC9A);
    // MOV AL,byte ptr [BX + DI + 0x2601] (0000_DC96 / 0xDC96)
    AL = UInt8[DS, (ushort)(BX + DI + 0x2601)];
    CheckExternalEvents(cs1, 0xDC9B);
    // CBW  (0000_DC9A / 0xDC9A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xDC9E);
    // MOV word ptr [BP + -0xa],AX (0000_DC9B / 0xDC9B)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0xDCA3);
    // MOV word ptr [BP + -0x12],0x1 (0000_DC9E / 0xDC9E)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    CheckExternalEvents(cs1, 0xDCA7);
    // TEST byte ptr [BP + -0xa],0xf0 (0000_DCA3 / 0xDCA3)
    Alu.And8(UInt8[SS, (ushort)(BP - 0xA)], 0xF0);
    CheckExternalEvents(cs1, 0xDCA9);
    // JZ 0x0000:dcb7 (0000_DCA7 / 0xDCA7)
    if(ZeroFlag) {
      goto label_0000_DCB7_0DCB7;
    }
    CheckExternalEvents(cs1, 0xDCAB);
    // MOV CL,0x4 (0000_DCA9 / 0xDCA9)
    CL = 0x4;
    CheckExternalEvents(cs1, 0xDCAD);
    // SAR AX,CL (0000_DCAB / 0xDCAB)
    AX = Alu.Sar16(AX, CL);
    CheckExternalEvents(cs1, 0xDCB0);
    // AND AX,0xf (0000_DCAD / 0xDCAD)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    CheckExternalEvents(cs1, 0xDCB3);
    // MOV word ptr [BP + -0x12],AX (0000_DCB0 / 0xDCB0)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs1, 0xDCB7);
    // AND word ptr [BP + -0xa],0xf (0000_DCB3 / 0xDCB3)
    // UInt16[SS, (ushort)(BP - 0xA)] &= 0xF;
    UInt16[SS, (ushort)(BP - 0xA)] = Alu.And16(UInt16[SS, (ushort)(BP - 0xA)], 0xF);
    label_0000_DCB7_0DCB7:
    CheckExternalEvents(cs1, 0xDCBC);
    // MOV word ptr [BP + -0x2],0x0 (0000_DCB7 / 0xDCB7)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs1, 0xDCBF);
    // JMP 0x0000:dbcc (0000_DCBC / 0xDCBC)
    goto label_0000_DBCC_0DBCC;
    label_0000_DCBF_0DCBF:
    CheckExternalEvents(cs1, 0xDCC3);
    // MOV ES,word ptr [0x5526] (0000_DCBF / 0xDCBF)
    ES = UInt16[DS, 0x5526];
    CheckExternalEvents(cs1, 0xDCCA);
    // MOV word ptr ES:[0x37fe],0xf (0000_DCC3 / 0xDCC3)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0xDCCF);
    // CALLF 0x1000:933a (0000_DCCA / 0xDCCA)
    FarCall(cs1, 0xDCCF, ghidra_guess_1000_933A_1933A);
    CheckExternalEvents(cs1, 0xDCD4);
    // CALLF 0x0000:414f (0000_DCCF / 0xDCCF)
    FarCall(cs1, 0xDCD4, ghidra_guess_0000_414F_0414F);
    CheckExternalEvents(cs1, 0xDCD6);
    // SUB AX,AX (0000_DCD4 / 0xDCD4)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xDCD7);
    // PUSH AX (0000_DCD6 / 0xDCD6)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDCDC);
    // CALLF 0x0000:63ac (0000_DCD7 / 0xDCD7)
    FarCall(cs1, 0xDCDC, unknown_0170_4CAC_063AC);
    CheckExternalEvents(cs1, 0xDCDF);
    // ADD SP,0x2 (0000_DCDC / 0xDCDC)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xDCE3);
    // MOV ES,word ptr [0x5522] (0000_DCDF / 0xDCDF)
    ES = UInt16[DS, 0x5522];
    CheckExternalEvents(cs1, 0xDCE9);
    // MOV byte ptr ES:[0xd335],0x3f (0000_DCE3 / 0xDCE3)
    UInt8[ES, 0xD335] = 0x3F;
    CheckExternalEvents(cs1, 0xDCEC);
    // JMP 0x0000:dd6c (0000_DCE9 / 0xDCE9)
    goto label_0000_DD6C_0DD6C;
    label_0000_DCEC_0DCEC:
    CheckExternalEvents(cs1, 0xDCF0);
    // CMP word ptr [BP + 0x6],0x0 (0000_DCEC / 0xDCEC)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs1, 0xDCF2);
    // JNZ 0x0000:dd6c (0000_DCF0 / 0xDCF0)
    if(!ZeroFlag) {
      goto label_0000_DD6C_0DD6C;
    }
    CheckExternalEvents(cs1, 0xDCF7);
    // CALLF 0x1000:7bf6 (0000_DCF2 / 0xDCF2)
    FarCall(cs1, 0xDCF7, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xDCFA);
    // MOV AX,0x2591 (0000_DCF7 / 0xDCF7)
    AX = 0x2591;
    CheckExternalEvents(cs1, 0xDCFB);
    // PUSH DS (0000_DCFA / 0xDCFA)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xDCFC);
    // PUSH AX (0000_DCFB / 0xDCFB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDD01);
    // CALLF 0x1000:8055 (0000_DCFC / 0xDCFC)
    FarCall(cs1, 0xDD01, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xDD04);
    // ADD SP,0x4 (0000_DD01 / 0xDD01)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xDD09);
    // CALLF 0x0000:412b (0000_DD04 / 0xDD04)
    FarCall(cs1, 0xDD09, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs1, 0xDD0B);
    // JMP 0x0000:dd67 (0000_DD09 / 0xDD09)
    goto label_0000_DD67_0DD67;
    label_0000_DD0B_0DD0B:
    CheckExternalEvents(cs1, 0xDD10);
    // CALLF 0x1000:7bf6 (0000_DD0B / 0xDD0B)
    FarCall(cs1, 0xDD10, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xDD15);
    // MOV word ptr [BP + -0x2],0x0 (0000_DD10 / 0xDD10)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs1, 0xDD1A);
    // MOV word ptr [BP + -0x16],0x0 (0000_DD15 / 0xDD15)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    label_0000_DD1A_0DD1A:
    CheckExternalEvents(cs1, 0xDD1D);
    // MOV AX,0x11 (0000_DD1A / 0xDD1A)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xDD20);
    // IMUL word ptr [BP + -0x16] (0000_DD1D / 0xDD1D)
    int resImul0000_DD1D = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x16)]);
    AX = (ushort)(resImul0000_DD1D);
    DX = (ushort)(resImul0000_DD1D >> 16);
    CheckExternalEvents(cs1, 0xDD22);
    // MOV SI,AX (0000_DD20 / 0xDD20)
    SI = AX;
    CheckExternalEvents(cs1, 0xDD26);
    // MOV ES,word ptr [0x5522] (0000_DD22 / 0xDD22)
    ES = UInt16[DS, 0x5522];
    CheckExternalEvents(cs1, 0xDD2C);
    // CMP byte ptr ES:[SI + 0xc614],0xff (0000_DD26 / 0xDD26)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC614)], 0xFF);
    CheckExternalEvents(cs1, 0xDD2E);
    // JZ 0x0000:dd46 (0000_DD2C / 0xDD2C)
    if(ZeroFlag) {
      goto label_0000_DD46_0DD46;
    }
    CheckExternalEvents(cs1, 0xDD33);
    // MOV AL,byte ptr ES:[SI + 0xc623] (0000_DD2E / 0xDD2E)
    AL = UInt8[ES, (ushort)(SI + 0xC623)];
    CheckExternalEvents(cs1, 0xDD34);
    // CBW  (0000_DD33 / 0xDD33)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xDD36);
    // MOV CX,AX (0000_DD34 / 0xDD34)
    CX = AX;
    CheckExternalEvents(cs1, 0xDD38);
    // MOV AL,0xa (0000_DD36 / 0xDD36)
    AL = 0xA;
    CheckExternalEvents(cs1, 0xDD3D);
    // IMUL byte ptr ES:[SI + 0xc615] (0000_DD38 / 0xDD38)
    short resImul0000_DD38 = Alu.Imul8((sbyte)AL, (sbyte)UInt8[ES, (ushort)(SI + 0xC615)]);
    AL = (byte)(resImul0000_DD38);
    AH = (byte)(resImul0000_DD38 >> 8);
    CheckExternalEvents(cs1, 0xDD3F);
    // CMP AX,CX (0000_DD3D / 0xDD3D)
    Alu.Sub16(AX, CX);
    CheckExternalEvents(cs1, 0xDD41);
    // JZ 0x0000:dd46 (0000_DD3F / 0xDD3F)
    if(ZeroFlag) {
      goto label_0000_DD46_0DD46;
    }
    CheckExternalEvents(cs1, 0xDD46);
    // MOV word ptr [BP + -0x2],0x1 (0000_DD41 / 0xDD41)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_0000_DD46_0DD46:
    CheckExternalEvents(cs1, 0xDD49);
    // INC word ptr [BP + -0x16] (0000_DD46 / 0xDD46)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    CheckExternalEvents(cs1, 0xDD4D);
    // CMP word ptr [BP + -0x16],0x8 (0000_DD49 / 0xDD49)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x8);
    CheckExternalEvents(cs1, 0xDD4F);
    // JL 0x0000:dd1a (0000_DD4D / 0xDD4D)
    if(SignFlag != OverflowFlag) {
      goto label_0000_DD1A_0DD1A;
    }
    CheckExternalEvents(cs1, 0xDD53);
    // CMP word ptr [BP + -0x2],0x0 (0000_DD4F / 0xDD4F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs1, 0xDD55);
    // JZ 0x0000:dd5a (0000_DD53 / 0xDD53)
    if(ZeroFlag) {
      goto label_0000_DD5A_0DD5A;
    }
    CheckExternalEvents(cs1, 0xDD58);
    // MOV AX,0x25a4 (0000_DD55 / 0xDD55)
    AX = 0x25A4;
    CheckExternalEvents(cs1, 0xDD5A);
    // JMP 0x0000:dd5d (0000_DD58 / 0xDD58)
    goto label_0000_DD5D_0DD5D;
    label_0000_DD5A_0DD5A:
    CheckExternalEvents(cs1, 0xDD5D);
    // MOV AX,0x25cf (0000_DD5A / 0xDD5A)
    AX = 0x25CF;
    label_0000_DD5D_0DD5D:
    CheckExternalEvents(cs1, 0xDD5E);
    // PUSH DS (0000_DD5D / 0xDD5D)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xDD5F);
    // PUSH AX (0000_DD5E / 0xDD5E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xDD64);
    // CALLF 0x1000:7c1a (0000_DD5F / 0xDD5F)
    FarCall(cs1, 0xDD64, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xDD67);
    // ADD SP,0x4 (0000_DD64 / 0xDD64)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    label_0000_DD67_0DD67:
    CheckExternalEvents(cs1, 0xDD6C);
    // CALLF 0x1000:8d29 (0000_DD67 / 0xDD67)
    FarCall(cs1, 0xDD6C, unknown_18AD_0259_18D29);
    label_0000_DD6C_0DD6C:
    CheckExternalEvents(cs1, 0xDD6D);
    // POP SI (0000_DD6C / 0xDD6C)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xDD6E);
    // POP DI (0000_DD6D / 0xDD6D)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xDD70);
    // MOV SP,BP (0000_DD6E / 0xDD6E)
    SP = BP;
    CheckExternalEvents(cs1, 0xDD71);
    // POP BP (0000_DD70 / 0xDD70)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xDD72);
    // RETF  (0000_DD71 / 0xDD71)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_E618_0E618(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_E618_0E618:
    CheckExternalEvents(cs1, 0xE619);
    // PUSH BP (0000_E618 / 0xE618)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xE61B);
    // MOV BP,SP (0000_E619 / 0xE619)
    BP = SP;
    CheckExternalEvents(cs1, 0xE61E);
    // MOV AX,0x18 (0000_E61B / 0xE61B)
    AX = 0x18;
    CheckExternalEvents(cs1, 0xE623);
    // CALLF 0x1000:cecc (0000_E61E / 0xE61E)
    FarCall(cs1, 0xE623, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xE624);
    // PUSH DI (0000_E623 / 0xE623)
    Stack.Push16(DI);
    CheckExternalEvents(cs1, 0xE625);
    // PUSH SI (0000_E624 / 0xE624)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xE629);
    // MOV ES,word ptr [0x5538] (0000_E625 / 0xE625)
    ES = UInt16[DS, 0x5538];
    CheckExternalEvents(cs1, 0xE62F);
    // CMP word ptr ES:[0x4594],0x0 (0000_E629 / 0xE629)
    Alu.Sub16(UInt16[ES, 0x4594], 0x0);
    CheckExternalEvents(cs1, 0xE631);
    // JNZ 0x0000:e652 (0000_E62F / 0xE62F)
    if(!ZeroFlag) {
      goto label_0000_E652_0E652;
    }
    CheckExternalEvents(cs1, 0xE634);
    // MOV AX,0x1 (0000_E631 / 0xE631)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xE635);
    // PUSH AX (0000_E634 / 0xE634)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE63A);
    // CALLF 0x0000:3fcc (0000_E635 / 0xE635)
    FarCall(cs1, 0xE63A, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0xE63D);
    // ADD SP,0x2 (0000_E63A / 0xE63A)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xE640);
    // MOV AX,0xa0 (0000_E63D / 0xE63D)
    AX = 0xA0;
    CheckExternalEvents(cs1, 0xE643);
    // MOV DX,0x2a02 (0000_E640 / 0xE640)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xE644);
    // PUSH DX (0000_E643 / 0xE643)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xE645);
    // PUSH AX (0000_E644 / 0xE644)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE648);
    // MOV AX,0x27e6 (0000_E645 / 0xE645)
    AX = 0x27E6;
    CheckExternalEvents(cs1, 0xE649);
    // PUSH DS (0000_E648 / 0xE648)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xE64A);
    // PUSH AX (0000_E649 / 0xE649)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE64F);
    // CALLF 0x1000:910b (0000_E64A / 0xE64A)
    FarCall(cs1, 0xE64F, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs1, 0xE652);
    // ADD SP,0x8 (0000_E64F / 0xE64F)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    label_0000_E652_0E652:
    CheckExternalEvents(cs1, 0xE656);
    // MOV ES,word ptr [0x553a] (0000_E652 / 0xE652)
    ES = UInt16[DS, 0x553A];
    CheckExternalEvents(cs1, 0xE65D);
    // MOV word ptr ES:[0x4fbc],0x0 (0000_E656 / 0xE656)
    UInt16[ES, 0x4FBC] = 0x0;
    CheckExternalEvents(cs1, 0xE660);
    // MOV AX,0x0 (0000_E65D / 0xE65D)
    AX = 0x0;
    CheckExternalEvents(cs1, 0xE663);
    // MOV DX,0x29c6 (0000_E660 / 0xE660)
    DX = 0x29C6;
    CheckExternalEvents(cs1, 0xE664);
    // PUSH DX (0000_E663 / 0xE663)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xE665);
    // PUSH AX (0000_E664 / 0xE664)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE66A);
    // CALLF 0x1000:9fc1 (0000_E665 / 0xE665)
    FarCall(cs1, 0xE66A, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs1, 0xE66D);
    // ADD SP,0x4 (0000_E66A / 0xE66A)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xE670);
    // MOV AX,0x244b (0000_E66D / 0xE66D)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0xE673);
    // MOV DX,0x1ddc (0000_E670 / 0xE670)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0xE674);
    // PUSH DX (0000_E673 / 0xE673)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xE675);
    // PUSH AX (0000_E674 / 0xE674)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE678);
    // MOV AX,0xa0 (0000_E675 / 0xE675)
    AX = 0xA0;
    CheckExternalEvents(cs1, 0xE67B);
    // MOV DX,0x2a02 (0000_E678 / 0xE678)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xE67C);
    // PUSH DX (0000_E67B / 0xE67B)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xE67D);
    // PUSH AX (0000_E67C / 0xE67C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE682);
    // CALLF 0x1000:8f6d (0000_E67D / 0xE67D)
    FarCall(cs1, 0xE682, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs1, 0xE685);
    // ADD SP,0x8 (0000_E682 / 0xE682)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0xE689);
    // MOV ES,word ptr [0x5532] (0000_E685 / 0xE685)
    ES = UInt16[DS, 0x5532];
    CheckExternalEvents(cs1, 0xE68F);
    // CMP word ptr ES:[0x4fba],0x2 (0000_E689 / 0xE689)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs1, 0xE691);
    // JNZ 0x0000:e6a5 (0000_E68F / 0xE68F)
    if(!ZeroFlag) {
      goto label_0000_E6A5_0E6A5;
    }
    CheckExternalEvents(cs1, 0xE694);
    // MOV AX,0xa800 (0000_E691 / 0xE691)
    AX = 0xA800;
    CheckExternalEvents(cs1, 0xE695);
    // PUSH AX (0000_E694 / 0xE694)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE698);
    // MOV AX,0x244b (0000_E695 / 0xE695)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0xE69B);
    // MOV DX,0x1ddc (0000_E698 / 0xE698)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0xE69C);
    // PUSH DX (0000_E69B / 0xE69B)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xE69D);
    // PUSH AX (0000_E69C / 0xE69C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE6A2);
    // CALLF 0x1000:a150 (0000_E69D / 0xE69D)
    FarCall(cs1, 0xE6A2, ghidra_guess_1000_A150_1A150);
    CheckExternalEvents(cs1, 0xE6A5);
    // ADD SP,0x6 (0000_E6A2 / 0xE6A2)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    label_0000_E6A5_0E6A5:
    CheckExternalEvents(cs1, 0xE6A8);
    // MOV AX,0x6 (0000_E6A5 / 0xE6A5)
    AX = 0x6;
    CheckExternalEvents(cs1, 0xE6A9);
    // PUSH AX (0000_E6A8 / 0xE6A8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE6AE);
    // CALLF 0x1000:7ee1 (0000_E6A9 / 0xE6A9)
    FarCall(cs1, 0xE6AE, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xE6B1);
    // ADD SP,0x2 (0000_E6AE / 0xE6AE)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xE6B6);
    // CALLF 0x1000:7fe8 (0000_E6B1 / 0xE6B1)
    FarCall(cs1, 0xE6B6, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xE6B8);
    // SUB AX,AX (0000_E6B6 / 0xE6B6)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xE6B9);
    // PUSH AX (0000_E6B8 / 0xE6B8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE6BE);
    // CALLF 0x1000:7c64 (0000_E6B9 / 0xE6B9)
    FarCall(cs1, 0xE6BE, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0xE6C1);
    // ADD SP,0x2 (0000_E6BE / 0xE6BE)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xE6C4);
    // MOV AX,0x27f2 (0000_E6C1 / 0xE6C1)
    AX = 0x27F2;
    CheckExternalEvents(cs1, 0xE6C5);
    // PUSH DS (0000_E6C4 / 0xE6C4)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xE6C6);
    // PUSH AX (0000_E6C5 / 0xE6C5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE6CB);
    // CALLF 0x1000:7c1a (0000_E6C6 / 0xE6C6)
    FarCall(cs1, 0xE6CB, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xE6CE);
    // ADD SP,0x4 (0000_E6CB / 0xE6CB)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xE6D3);
    // CALLF 0x1000:8d29 (0000_E6CE / 0xE6CE)
    FarCall(cs1, 0xE6D3, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xE6D8);
    // MOV word ptr [BP + -0x12],0x0 (0000_E6D3 / 0xE6D3)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    CheckExternalEvents(cs1, 0xE6DB);
    // MOV AX,0xffff (0000_E6D8 / 0xE6D8)
    AX = 0xFFFF;
    CheckExternalEvents(cs1, 0xE6DE);
    // MOV word ptr [BP + -0x8],AX (0000_E6DB / 0xE6DB)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs1, 0xE6E1);
    // MOV word ptr [BP + -0xa],AX (0000_E6DE / 0xE6DE)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0xE6E4);
    // MOV word ptr [BP + -0xc],AX (0000_E6E1 / 0xE6E1)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0xE6E9);
    // MOV word ptr [BP + -0xe],0x0 (0000_E6E4 / 0xE6E4)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    CheckExternalEvents(cs1, 0xE6EC);
    // JMP 0x0000:e7e8 (0000_E6E9 / 0xE6E9)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_0000_E7E5_0E7E5, 0xE7E8 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_E6EC_0E6EC:
    CheckExternalEvents(cs1, 0xE6EF);
    // MOV SI,word ptr [BP + -0x14] (0000_E6EC / 0xE6EC)
    SI = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0xE6F1);
    // SHL SI,0x1 (0000_E6EF / 0xE6EF)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0xE6F4);
    // MOV AX,word ptr [BP + -0x18] (0000_E6F1 / 0xE6F1)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0xE6F7);
    // CMP word ptr [BP + SI + -0xc],AX (0000_E6F4 / 0xE6F4)
    Alu.Sub16(UInt16[SS, (ushort)(BP + SI - 0xC)], AX);
    CheckExternalEvents(cs1, 0xE6F9);
    // JNZ 0x0000:e6fe (0000_E6F7 / 0xE6F7)
    if(!ZeroFlag) {
      goto label_0000_E6FE_0E6FE;
    }
    CheckExternalEvents(cs1, 0xE6FE);
    // MOV word ptr [BP + -0x16],0x1 (0000_E6F9 / 0xE6F9)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x1;
    label_0000_E6FE_0E6FE:
    CheckExternalEvents(cs1, 0xE701);
    // INC word ptr [BP + -0x14] (0000_E6FE / 0xE6FE)
    UInt16[SS, (ushort)(BP - 0x14)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x14)]);
    label_0000_E701_0E701:
    CheckExternalEvents(cs1, 0xE704);
    // MOV AX,word ptr [BP + -0xe] (0000_E701 / 0xE701)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xE707);
    // CMP word ptr [BP + -0x14],AX (0000_E704 / 0xE704)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x14)], AX);
    CheckExternalEvents(cs1, 0xE709);
    // JL 0x0000:e6ec (0000_E707 / 0xE707)
    if(SignFlag != OverflowFlag) {
      goto label_0000_E6EC_0E6EC;
    }
    CheckExternalEvents(cs1, 0xE70D);
    // CMP word ptr [BP + -0x16],0x0 (0000_E709 / 0xE709)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x0);
    CheckExternalEvents(cs1, 0xE70F);
    // JZ 0x0000:e712 (0000_E70D / 0xE70D)
    if(ZeroFlag) {
      goto label_0000_E712_0E712;
    }
    CheckExternalEvents(cs1, 0xE712);
    // JMP 0x0000:e890 (0000_E70F / 0xE70F)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_0000_E7E5_0E7E5, 0xE890 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_E712_0E712:
    CheckExternalEvents(cs1, 0xE714);
    // MOV DI,AX (0000_E712 / 0xE712)
    DI = AX;
    CheckExternalEvents(cs1, 0xE716);
    // SHL DI,0x1 (0000_E714 / 0xE714)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    CheckExternalEvents(cs1, 0xE719);
    // MOV AX,word ptr [BP + -0x18] (0000_E716 / 0xE716)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0xE71C);
    // MOV word ptr [BP + DI + -0xc],AX (0000_E719 / 0xE719)
    UInt16[SS, (ushort)(BP + DI - 0xC)] = AX;
    CheckExternalEvents(cs1, 0xE71F);
    // MOV SI,word ptr [BP + -0x18] (0000_E71C / 0xE71C)
    SI = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0xE721);
    // SHL SI,0x1 (0000_E71F / 0xE71F)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0xE725);
    // MOV AX,word ptr [SI + 0x28c4] (0000_E721 / 0xE721)
    AX = UInt16[DS, (ushort)(SI + 0x28C4)];
    CheckExternalEvents(cs1, 0xE728);
    // SUB AX,0x3 (0000_E725 / 0xE725)
    // AX -= 0x3;
    AX = Alu.Sub16(AX, 0x3);
    CheckExternalEvents(cs1, 0xE72B);
    // MOV word ptr [BP + -0x4],AX (0000_E728 / 0xE728)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0xE72F);
    // MOV AX,word ptr [SI + 0x28d8] (0000_E72B / 0xE72B)
    AX = UInt16[DS, (ushort)(SI + 0x28D8)];
    CheckExternalEvents(cs1, 0xE732);
    // SUB AX,0x3 (0000_E72F / 0xE72F)
    // AX -= 0x3;
    AX = Alu.Sub16(AX, 0x3);
    CheckExternalEvents(cs1, 0xE735);
    // MOV word ptr [BP + -0x6],AX (0000_E732 / 0xE732)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0xE738);
    // MOV AX,0xf (0000_E735 / 0xE735)
    AX = 0xF;
    CheckExternalEvents(cs1, 0xE739);
    // PUSH AX (0000_E738 / 0xE738)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE73C);
    // PUSH word ptr [BP + -0x6] (0000_E739 / 0xE739)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0xE73F);
    // MOV AX,word ptr [BP + -0x4] (0000_E73C / 0xE73C)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xE742);
    // ADD AX,0x8 (0000_E73F / 0xE73F)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    CheckExternalEvents(cs1, 0xE743);
    // PUSH AX (0000_E742 / 0xE742)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE746);
    // PUSH word ptr [BP + -0x6] (0000_E743 / 0xE743)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0xE749);
    // PUSH word ptr [BP + -0x4] (0000_E746 / 0xE746)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0xE74E);
    // CALLF 0x1000:8dec (0000_E749 / 0xE749)
    FarCall(cs1, 0xE74E, unknown_18AD_031C_18DEC);
    CheckExternalEvents(cs1, 0xE751);
    // ADD SP,0xa (0000_E74E / 0xE74E)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs1, 0xE754);
    // MOV SI,word ptr [BP + -0x6] (0000_E751 / 0xE751)
    SI = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xE757);
    // ADD SI,0x8 (0000_E754 / 0xE754)
    // SI += 0x8;
    SI = Alu.Add16(SI, 0x8);
    CheckExternalEvents(cs1, 0xE75A);
    // MOV AX,0xf (0000_E757 / 0xE757)
    AX = 0xF;
    CheckExternalEvents(cs1, 0xE75B);
    // PUSH AX (0000_E75A / 0xE75A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE75C);
    // PUSH SI (0000_E75B / 0xE75B)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xE75F);
    // MOV AX,word ptr [BP + -0x4] (0000_E75C / 0xE75C)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xE762);
    // ADD AX,0x8 (0000_E75F / 0xE75F)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    CheckExternalEvents(cs1, 0xE763);
    // PUSH AX (0000_E762 / 0xE762)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE764);
    // PUSH SI (0000_E763 / 0xE763)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xE767);
    // PUSH word ptr [BP + -0x4] (0000_E764 / 0xE764)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0xE76C);
    // CALLF 0x1000:8dec (0000_E767 / 0xE767)
    FarCall(cs1, 0xE76C, unknown_18AD_031C_18DEC);
    CheckExternalEvents(cs1, 0xE76F);
    // ADD SP,0xa (0000_E76C / 0xE76C)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs1, 0xE772);
    // MOV AX,0xf (0000_E76F / 0xE76F)
    AX = 0xF;
    CheckExternalEvents(cs1, 0xE773);
    // PUSH AX (0000_E772 / 0xE772)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE776);
    // MOV AX,word ptr [BP + -0x6] (0000_E773 / 0xE773)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xE779);
    // ADD AX,0x8 (0000_E776 / 0xE776)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    CheckExternalEvents(cs1, 0xE77A);
    // PUSH AX (0000_E779 / 0xE779)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE77D);
    // PUSH word ptr [BP + -0x4] (0000_E77A / 0xE77A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0xE780);
    // PUSH word ptr [BP + -0x6] (0000_E77D / 0xE77D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0xE783);
    // PUSH word ptr [BP + -0x4] (0000_E780 / 0xE780)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0xE788);
    // CALLF 0x1000:8dec (0000_E783 / 0xE783)
    FarCall(cs1, 0xE788, unknown_18AD_031C_18DEC);
    CheckExternalEvents(cs1, 0xE78B);
    // ADD SP,0xa (0000_E788 / 0xE788)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs1, 0xE78E);
    // MOV SI,word ptr [BP + -0x4] (0000_E78B / 0xE78B)
    SI = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xE791);
    // ADD SI,0x8 (0000_E78E / 0xE78E)
    // SI += 0x8;
    SI = Alu.Add16(SI, 0x8);
    CheckExternalEvents(cs1, 0xE794);
    // MOV AX,0xf (0000_E791 / 0xE791)
    AX = 0xF;
    CheckExternalEvents(cs1, 0xE795);
    // PUSH AX (0000_E794 / 0xE794)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE798);
    // MOV AX,word ptr [BP + -0x6] (0000_E795 / 0xE795)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xE79B);
    // ADD AX,0x8 (0000_E798 / 0xE798)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    CheckExternalEvents(cs1, 0xE79C);
    // PUSH AX (0000_E79B / 0xE79B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE79D);
    // PUSH SI (0000_E79C / 0xE79C)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xE7A0);
    // PUSH word ptr [BP + -0x6] (0000_E79D / 0xE79D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0xE7A1);
    // PUSH SI (0000_E7A0 / 0xE7A0)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xE7A6);
    // CALLF 0x1000:8dec (0000_E7A1 / 0xE7A1)
    FarCall(cs1, 0xE7A6, unknown_18AD_031C_18DEC);
    CheckExternalEvents(cs1, 0xE7A9);
    // ADD SP,0xa (0000_E7A6 / 0xE7A6)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs1, 0xE7AC);
    // MOV AX,0xf (0000_E7A9 / 0xE7A9)
    AX = 0xF;
    CheckExternalEvents(cs1, 0xE7AD);
    // PUSH AX (0000_E7AC / 0xE7AC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE7B0);
    // MOV AX,word ptr [BP + -0x6] (0000_E7AD / 0xE7AD)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xE7B3);
    // ADD AX,0x6 (0000_E7B0 / 0xE7B0)
    // AX += 0x6;
    AX = Alu.Add16(AX, 0x6);
    CheckExternalEvents(cs1, 0xE7B4);
    // PUSH AX (0000_E7B3 / 0xE7B3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE7B7);
    // PUSH word ptr [BP + -0x4] (0000_E7B4 / 0xE7B4)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0xE7BA);
    // MOV AX,word ptr [BP + -0x6] (0000_E7B7 / 0xE7B7)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xE7BB);
    // INC AX (0000_E7BA / 0xE7BA)
    AX++;
    CheckExternalEvents(cs1, 0xE7BC);
    // INC AX (0000_E7BB / 0xE7BB)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs1, 0xE7BD);
    // PUSH AX (0000_E7BC / 0xE7BC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE7C0);
    // MOV AX,0x80 (0000_E7BD / 0xE7BD)
    AX = 0x80;
    CheckExternalEvents(cs1, 0xE7C1);
    // PUSH AX (0000_E7C0 / 0xE7C0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE7C6);
    // CALLF 0x1000:8ccb (0000_E7C1 / 0xE7C1)
    FarCall(cs1, 0xE7C6, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs1, 0xE7C9);
    // ADD SP,0xa (0000_E7C6 / 0xE7C6)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs1, 0xE7CC);
    // MOV AX,0x25 (0000_E7C9 / 0xE7C9)
    AX = 0x25;
    CheckExternalEvents(cs1, 0xE7CD);
    // PUSH AX (0000_E7CC / 0xE7CC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE7D2);
    // CALLF 0x1000:87be (0000_E7CD / 0xE7CD)
    FarCall(cs1, 0xE7D2, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0xE7D5);
    // ADD SP,0x2 (0000_E7D2 / 0xE7D2)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xE7D8);
    // MOV BX,word ptr [BP + -0x18] (0000_E7D5 / 0xE7D5)
    BX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0xE7DA);
    // SHL BX,0x1 (0000_E7D8 / 0xE7D8)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xE7DE);
    // CMP word ptr [BX + 0x28ec],AX (0000_E7DA / 0xE7DA)
    Alu.Sub16(UInt16[DS, (ushort)(BX + 0x28EC)], AX);
    CheckExternalEvents(cs1, 0xE7E0);
    // JMP 0x0000:e7e5 (0000_E7DE / 0xE7DE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_E7E5_0E7E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_0000_E7E5_0E7E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_E7E5_0E7E5:
    CheckExternalEvents(cs1, 0xE7E8);
    // INC word ptr [BP + -0xe] (0000_E7E5 / 0xE7E5)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_0000_E7E8_0E7E8:
    CheckExternalEvents(cs1, 0xE7EC);
    // CMP word ptr [BP + -0xe],0x3 (0000_E7E8 / 0xE7E8)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x3);
    CheckExternalEvents(cs1, 0xE7EE);
    // JL 0x0000:e7f1 (0000_E7EC / 0xE7EC)
    if(SignFlag != OverflowFlag) {
      goto label_0000_E7F1_0E7F1;
    }
    CheckExternalEvents(cs1, 0xE7F1);
    // JMP 0x0000:e8ab (0000_E7EE / 0xE7EE)
    goto label_0000_E8AB_0E8AB;
    label_0000_E7F1_0E7F1:
    CheckExternalEvents(cs1, 0xE7F4);
    // MOV AX,0xc8 (0000_E7F1 / 0xE7F1)
    AX = 0xC8;
    CheckExternalEvents(cs1, 0xE7F5);
    // PUSH AX (0000_E7F4 / 0xE7F4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE7F8);
    // MOV AX,0x28 (0000_E7F5 / 0xE7F5)
    AX = 0x28;
    CheckExternalEvents(cs1, 0xE7F9);
    // PUSH AX (0000_E7F8 / 0xE7F8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE7FB);
    // SUB AX,AX (0000_E7F9 / 0xE7F9)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xE7FC);
    // PUSH AX (0000_E7FB / 0xE7FB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE7FD);
    // PUSH AX (0000_E7FC / 0xE7FC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE800);
    // MOV AX,0x244b (0000_E7FD / 0xE7FD)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0xE803);
    // MOV DX,0x1ddc (0000_E800 / 0xE800)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0xE804);
    // PUSH DX (0000_E803 / 0xE803)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xE805);
    // PUSH AX (0000_E804 / 0xE804)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE80A);
    // CALLF 0x1000:8b56 (0000_E805 / 0xE805)
    FarCall(cs1, 0xE80A, unknown_18AD_0086_18B56);
    CheckExternalEvents(cs1, 0xE80D);
    // ADD SP,0xc (0000_E80A / 0xE80A)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs1, 0xE811);
    // MOV ES,word ptr [0x5532] (0000_E80D / 0xE80D)
    ES = UInt16[DS, 0x5532];
    CheckExternalEvents(cs1, 0xE817);
    // CMP word ptr ES:[0x4fba],0x1 (0000_E811 / 0xE811)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x1);
    CheckExternalEvents(cs1, 0xE819);
    // SBB AX,AX (0000_E817 / 0xE817)
    AX = Alu.Sbb16(AX, AX);
    CheckExternalEvents(cs1, 0xE81B);
    // NEG AX (0000_E819 / 0xE819)
    AX = Alu.Sub16(0, AX);
    CheckExternalEvents(cs1, 0xE81E);
    // ADD AX,0x9 (0000_E81B / 0xE81B)
    // AX += 0x9;
    AX = Alu.Add16(AX, 0x9);
    CheckExternalEvents(cs1, 0xE81F);
    // PUSH AX (0000_E81E / 0xE81E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE822);
    // MOV AX,0xc0 (0000_E81F / 0xE81F)
    AX = 0xC0;
    CheckExternalEvents(cs1, 0xE823);
    // PUSH AX (0000_E822 / 0xE822)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE826);
    // MOV AX,0x80 (0000_E823 / 0xE823)
    AX = 0x80;
    CheckExternalEvents(cs1, 0xE827);
    // PUSH AX (0000_E826 / 0xE826)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE829);
    // SUB AX,AX (0000_E827 / 0xE827)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xE82A);
    // PUSH AX (0000_E829 / 0xE829)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE82D);
    // MOV AX,0x80 (0000_E82A / 0xE82A)
    AX = 0x80;
    CheckExternalEvents(cs1, 0xE82E);
    // PUSH AX (0000_E82D / 0xE82D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE833);
    // CALLF 0x1000:8dec (0000_E82E / 0xE82E)
    FarCall(cs1, 0xE833, unknown_18AD_031C_18DEC);
    CheckExternalEvents(cs1, 0xE836);
    // ADD SP,0xa (0000_E833 / 0xE833)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs1, 0xE839);
    // MOV AX,0x8 (0000_E836 / 0xE836)
    AX = 0x8;
    CheckExternalEvents(cs1, 0xE83A);
    // PUSH AX (0000_E839 / 0xE839)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE83F);
    // CALLF 0x1000:7ee1 (0000_E83A / 0xE83A)
    FarCall(cs1, 0xE83F, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xE842);
    // ADD SP,0x2 (0000_E83F / 0xE83F)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xE847);
    // CALLF 0x1000:7fe8 (0000_E842 / 0xE842)
    FarCall(cs1, 0xE847, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xE84A);
    // MOV AX,0x286c (0000_E847 / 0xE847)
    AX = 0x286C;
    CheckExternalEvents(cs1, 0xE84B);
    // PUSH DS (0000_E84A / 0xE84A)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xE84C);
    // PUSH AX (0000_E84B / 0xE84B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE851);
    // CALLF 0x1000:8055 (0000_E84C / 0xE84C)
    FarCall(cs1, 0xE851, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xE854);
    // ADD SP,0x4 (0000_E851 / 0xE851)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xE859);
    // MOV word ptr [BP + -0x10],0x0 (0000_E854 / 0xE854)
    UInt16[SS, (ushort)(BP - 0x10)] = 0x0;
    label_0000_E859_0E859:
    CheckExternalEvents(cs1, 0xE85B);
    // SUB AX,AX (0000_E859 / 0xE859)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xE85C);
    // PUSH AX (0000_E85B / 0xE85B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE85F);
    // MOV AX,0xf (0000_E85C / 0xE85C)
    AX = 0xF;
    CheckExternalEvents(cs1, 0xE860);
    // PUSH AX (0000_E85F / 0xE85F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE863);
    // MOV AX,word ptr [BP + -0x10] (0000_E860 / 0xE860)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs1, 0xE866);
    // ADD AX,0x4 (0000_E863 / 0xE863)
    // AX += 0x4;
    AX = Alu.Add16(AX, 0x4);
    CheckExternalEvents(cs1, 0xE867);
    // PUSH AX (0000_E866 / 0xE866)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE869);
    // SUB AX,AX (0000_E867 / 0xE867)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xE86A);
    // PUSH AX (0000_E869 / 0xE869)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE86D);
    // MOV BX,word ptr [BP + -0x10] (0000_E86A / 0xE86A)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs1, 0xE86F);
    // SHL BX,0x1 (0000_E86D / 0xE86D)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xE871);
    // SHL BX,0x1 (0000_E86F / 0xE86F)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xE875);
    // MOV ES,word ptr [0x553c] (0000_E871 / 0xE871)
    ES = UInt16[DS, 0x553C];
    CheckExternalEvents(cs1, 0xE87A);
    // PUSH word ptr ES:[BX + 0x4de4] (0000_E875 / 0xE875)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x4DE4)]);
    CheckExternalEvents(cs1, 0xE87F);
    // PUSH word ptr ES:[BX + 0x4de2] (0000_E87A / 0xE87A)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x4DE2)]);
    CheckExternalEvents(cs1, 0xE884);
    // CALLF 0x1000:8ba5 (0000_E87F / 0xE87F)
    FarCall(cs1, 0xE884, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0xE887);
    // ADD SP,0xc (0000_E884 / 0xE884)
    SP += 0xC;
    CheckExternalEvents(cs1, 0xE88A);
    // INC word ptr [BP + -0x10] (0000_E887 / 0xE887)
    UInt16[SS, (ushort)(BP - 0x10)]++;
    CheckExternalEvents(cs1, 0xE88E);
    // CMP word ptr [BP + -0x10],0x14 (0000_E88A / 0xE88A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x14);
    CheckExternalEvents(cs1, 0xE890);
    // JL 0x0000:e859 (0000_E88E / 0xE88E)
    if(SignFlag != OverflowFlag) {
      goto label_0000_E859_0E859;
    }
    label_0000_E890_0E890:
    CheckExternalEvents(cs1, 0xE895);
    // MOV word ptr [BP + -0x16],0x0 (0000_E890 / 0xE890)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    CheckExternalEvents(cs1, 0xE89A);
    // CALLF 0x1000:aab0 (0000_E895 / 0xE895)
    FarCall(cs1, 0xE89A, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xE89B);
    // CWD  (0000_E89A / 0xE89A)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs1, 0xE89E);
    // MOV CX,0xa (0000_E89B / 0xE89B)
    CX = 0xA;
    CheckExternalEvents(cs1, 0xE8A0);
    // IDIV CX (0000_E89E / 0xE89E)
    int op1IDiv0000_E89E = (int)(DX << 16 | AX);
    short op2IDiv0000_E89E = (short)CX;
    short? resIDiv0000_E89E = Alu.IDiv16(op1IDiv0000_E89E, op2IDiv0000_E89E);
    if(resIDiv0000_E89E == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = (ushort)resIDiv0000_E89E.Value;
    DX = (ushort)(op1IDiv0000_E89E % op2IDiv0000_E89E);
    CheckExternalEvents(cs1, 0xE8A3);
    // MOV word ptr [BP + -0x18],DX (0000_E8A0 / 0xE8A0)
    UInt16[SS, (ushort)(BP - 0x18)] = DX;
    CheckExternalEvents(cs1, 0xE8A8);
    // MOV word ptr [BP + -0x14],0x0 (0000_E8A3 / 0xE8A3)
    UInt16[SS, (ushort)(BP - 0x14)] = 0x0;
    CheckExternalEvents(cs1, 0xE8AB);
    // JMP 0x0000:e701 (0000_E8A8 / 0xE8A8)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(ghidra_guess_0000_E618_0E618, 0xE701 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_E8AB_0E8AB:
    CheckExternalEvents(cs1, 0xE8B0);
    // CALLF 0x1000:beae (0000_E8AB / 0xE8AB)
    FarCall(cs1, 0xE8B0, unknown_19EF_1FBE_1BEAE);
    CheckExternalEvents(cs1, 0xE8B3);
    // MOV AX,0x1 (0000_E8B0 / 0xE8B0)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xE8B4);
    // PUSH AX (0000_E8B3 / 0xE8B3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE8B9);
    // CALLF 0x0000:63ac (0000_E8B4 / 0xE8B4)
    FarCall(cs1, 0xE8B9, unknown_0170_4CAC_063AC);
    CheckExternalEvents(cs1, 0xE8BC);
    // ADD SP,0x2 (0000_E8B9 / 0xE8B9)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xE8C1);
    // CALLF 0x1000:7fe8 (0000_E8BC / 0xE8BC)
    FarCall(cs1, 0xE8C1, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xE8C5);
    // CMP word ptr [BP + -0x12],0x0 (0000_E8C1 / 0xE8C1)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs1, 0xE8C7);
    // JZ 0x0000:e8ff (0000_E8C5 / 0xE8C5)
    if(ZeroFlag) {
      goto label_0000_E8FF_0E8FF;
    }
    CheckExternalEvents(cs1, 0xE8CA);
    // MOV AX,0x6 (0000_E8C7 / 0xE8C7)
    AX = 0x6;
    CheckExternalEvents(cs1, 0xE8CB);
    // PUSH AX (0000_E8CA / 0xE8CA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE8D0);
    // CALLF 0x1000:7ee1 (0000_E8CB / 0xE8CB)
    FarCall(cs1, 0xE8D0, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xE8D3);
    // ADD SP,0x2 (0000_E8D0 / 0xE8D0)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xE8D8);
    // CALLF 0x1000:7fe8 (0000_E8D3 / 0xE8D3)
    FarCall(cs1, 0xE8D8, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xE8DA);
    // SUB AX,AX (0000_E8D8 / 0xE8D8)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xE8DB);
    // PUSH AX (0000_E8DA / 0xE8DA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE8E0);
    // CALLF 0x1000:7c64 (0000_E8DB / 0xE8DB)
    FarCall(cs1, 0xE8E0, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0xE8E3);
    // ADD SP,0x2 (0000_E8E0 / 0xE8E0)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xE8E6);
    // MOV AX,0x2886 (0000_E8E3 / 0xE8E3)
    AX = 0x2886;
    CheckExternalEvents(cs1, 0xE8E7);
    // PUSH DS (0000_E8E6 / 0xE8E6)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xE8E8);
    // PUSH AX (0000_E8E7 / 0xE8E7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE8ED);
    // CALLF 0x1000:7c1a (0000_E8E8 / 0xE8E8)
    FarCall(cs1, 0xE8ED, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xE8F0);
    // ADD SP,0x4 (0000_E8ED / 0xE8ED)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xE8F4);
    // MOV ES,word ptr [0x5528] (0000_E8F0 / 0xE8F0)
    ES = UInt16[DS, 0x5528];
    CheckExternalEvents(cs1, 0xE8FA);
    // MOV byte ptr ES:[0xd320],0xff (0000_E8F4 / 0xE8F4)
    UInt8[ES, 0xD320] = 0xFF;
    CheckExternalEvents(cs1, 0xE8FF);
    // CALLF 0x1000:8d29 (0000_E8FA / 0xE8FA)
    FarCall(cs1, 0xE8FF, unknown_18AD_0259_18D29);
    label_0000_E8FF_0E8FF:
    CheckExternalEvents(cs1, 0xE902);
    // MOV AX,word ptr [BP + -0x12] (0000_E8FF / 0xE8FF)
    AX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0xE903);
    // POP SI (0000_E902 / 0xE902)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xE904);
    // POP DI (0000_E903 / 0xE903)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xE906);
    // MOV SP,BP (0000_E904 / 0xE904)
    SP = BP;
    CheckExternalEvents(cs1, 0xE907);
    // POP BP (0000_E906 / 0xE906)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xE908);
    // RETF  (0000_E907 / 0xE907)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_E908_0E908(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_E908_0E908:
    CheckExternalEvents(cs1, 0xE909);
    // PUSH BP (0000_E908 / 0xE908)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xE90B);
    // MOV BP,SP (0000_E909 / 0xE909)
    BP = SP;
    CheckExternalEvents(cs1, 0xE90E);
    // MOV AX,0x4 (0000_E90B / 0xE90B)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xE913);
    // CALLF 0x1000:cecc (0000_E90E / 0xE90E)
    FarCall(cs1, 0xE913, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xE918);
    // MOV word ptr [BP + -0x4],0x0 (0000_E913 / 0xE913)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_E918_0E918:
    CheckExternalEvents(cs1, 0xE91B);
    // MOV BX,word ptr [BP + -0x4] (0000_E918 / 0xE918)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xE91F);
    // MOV ES,word ptr [0x553e] (0000_E91B / 0xE91B)
    ES = UInt16[DS, 0x553E];
    CheckExternalEvents(cs1, 0xE925);
    // MOV byte ptr ES:[BX + 0xd558],0x0 (0000_E91F / 0xE91F)
    UInt8[ES, (ushort)(BX + 0xD558)] = 0x0;
    CheckExternalEvents(cs1, 0xE928);
    // INC word ptr [BP + -0x4] (0000_E925 / 0xE925)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs1, 0xE92C);
    // CMP word ptr [BP + -0x4],0x4 (0000_E928 / 0xE928)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x4);
    CheckExternalEvents(cs1, 0xE92E);
    // JL 0x0000:e918 (0000_E92C / 0xE92C)
    if(SignFlag != OverflowFlag) {
      goto label_0000_E918_0E918;
    }
    CheckExternalEvents(cs1, 0xE932);
    // MOV ES,word ptr [0x5540] (0000_E92E / 0xE92E)
    ES = UInt16[DS, 0x5540];
    CheckExternalEvents(cs1, 0xE934);
    // SUB AX,AX (0000_E932 / 0xE932)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xE938);
    // MOV ES:[0x68],AX (0000_E934 / 0xE934)
    UInt16[ES, 0x68] = AX;
    CheckExternalEvents(cs1, 0xE93B);
    // MOV word ptr [BP + -0x2],AX (0000_E938 / 0xE938)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0xE93F);
    // MOV ES,word ptr [0x5528] (0000_E93B / 0xE93B)
    ES = UInt16[DS, 0x5528];
    CheckExternalEvents(cs1, 0xE945);
    // CMP byte ptr ES:[0xd324],0x0 (0000_E93F / 0xE93F)
    Alu.Sub8(UInt8[ES, 0xD324], 0x0);
    CheckExternalEvents(cs1, 0xE947);
    // JZ 0x0000:e978 (0000_E945 / 0xE945)
    if(ZeroFlag) {
      goto label_0000_E978_0E978;
    }
    CheckExternalEvents(cs1, 0xE94A);
    // MOV word ptr [BP + -0x4],AX (0000_E947 / 0xE947)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0xE94C);
    // JMP 0x0000:e94f (0000_E94A / 0xE94A)
    goto label_0000_E94F_0E94F;
    label_0000_E94C_0E94C:
    CheckExternalEvents(cs1, 0xE94F);
    // INC word ptr [BP + -0x4] (0000_E94C / 0xE94C)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_0000_E94F_0E94F:
    CheckExternalEvents(cs1, 0xE953);
    // CMP word ptr [BP + -0x4],0x4 (0000_E94F / 0xE94F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x4);
    CheckExternalEvents(cs1, 0xE955);
    // JGE 0x0000:e9ac (0000_E953 / 0xE953)
    if(SignFlag == OverflowFlag) {
      goto label_0000_E9AC_0E9AC;
    }
    CheckExternalEvents(cs1, 0xE958);
    // MOV BX,word ptr [BP + -0x4] (0000_E955 / 0xE955)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xE95C);
    // MOV ES,word ptr [0x5528] (0000_E958 / 0xE958)
    ES = UInt16[DS, 0x5528];
    CheckExternalEvents(cs1, 0xE962);
    // CMP byte ptr ES:[BX + 0xd452],0xff (0000_E95C / 0xE95C)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xD452)], 0xFF);
    CheckExternalEvents(cs1, 0xE964);
    // JZ 0x0000:e94c (0000_E962 / 0xE962)
    if(ZeroFlag) {
      goto label_0000_E94C_0E94C;
    }
    CheckExternalEvents(cs1, 0xE967);
    // MOV AL,byte ptr [BP + -0x4] (0000_E964 / 0xE964)
    AL = UInt8[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xE96A);
    // MOV BX,word ptr [BP + -0x2] (0000_E967 / 0xE967)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xE96D);
    // INC word ptr [BP + -0x2] (0000_E96A / 0xE96A)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0xE971);
    // MOV ES,word ptr [0x553e] (0000_E96D / 0xE96D)
    ES = UInt16[DS, 0x553E];
    CheckExternalEvents(cs1, 0xE976);
    // MOV byte ptr ES:[BX + 0xd558],AL (0000_E971 / 0xE971)
    UInt8[ES, (ushort)(BX + 0xD558)] = AL;
    CheckExternalEvents(cs1, 0xE978);
    // JMP 0x0000:e94c (0000_E976 / 0xE976)
    goto label_0000_E94C_0E94C;
    label_0000_E978_0E978:
    CheckExternalEvents(cs1, 0xE97D);
    // MOV word ptr [BP + -0x4],0x0 (0000_E978 / 0xE978)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_E97D_0E97D:
    CheckExternalEvents(cs1, 0xE980);
    // MOV AX,0x7d (0000_E97D / 0xE97D)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xE983);
    // IMUL word ptr [BP + -0x4] (0000_E980 / 0xE980)
    int resImul0000_E980 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_E980);
    DX = (ushort)(resImul0000_E980 >> 16);
    CheckExternalEvents(cs1, 0xE985);
    // MOV BX,AX (0000_E983 / 0xE983)
    BX = AX;
    CheckExternalEvents(cs1, 0xE989);
    // MOV ES,word ptr [0x5528] (0000_E985 / 0xE985)
    ES = UInt16[DS, 0x5528];
    CheckExternalEvents(cs1, 0xE98F);
    // CMP byte ptr ES:[BX + 0xc724],0xff (0000_E989 / 0xE989)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs1, 0xE991);
    // JZ 0x0000:e9a3 (0000_E98F / 0xE98F)
    if(ZeroFlag) {
      goto label_0000_E9A3_0E9A3;
    }
    CheckExternalEvents(cs1, 0xE994);
    // MOV AL,byte ptr [BP + -0x4] (0000_E991 / 0xE991)
    AL = UInt8[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xE997);
    // MOV BX,word ptr [BP + -0x2] (0000_E994 / 0xE994)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xE99A);
    // INC word ptr [BP + -0x2] (0000_E997 / 0xE997)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0xE99E);
    // MOV ES,word ptr [0x553e] (0000_E99A / 0xE99A)
    ES = UInt16[DS, 0x553E];
    CheckExternalEvents(cs1, 0xE9A3);
    // MOV byte ptr ES:[BX + 0xd558],AL (0000_E99E / 0xE99E)
    UInt8[ES, (ushort)(BX + 0xD558)] = AL;
    label_0000_E9A3_0E9A3:
    CheckExternalEvents(cs1, 0xE9A6);
    // INC word ptr [BP + -0x4] (0000_E9A3 / 0xE9A3)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs1, 0xE9AA);
    // CMP word ptr [BP + -0x4],0x4 (0000_E9A6 / 0xE9A6)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x4);
    CheckExternalEvents(cs1, 0xE9AC);
    // JL 0x0000:e97d (0000_E9AA / 0xE9AA)
    if(SignFlag != OverflowFlag) {
      goto label_0000_E97D_0E97D;
    }
    label_0000_E9AC_0E9AC:
    CheckExternalEvents(cs1, 0xE9B0);
    // MOV ES,word ptr [0x553e] (0000_E9AC / 0xE9AC)
    ES = UInt16[DS, 0x553E];
    CheckExternalEvents(cs1, 0xE9B4);
    // MOV AL,ES:[0xd558] (0000_E9B0 / 0xE9B0)
    AL = UInt8[ES, 0xD558];
    CheckExternalEvents(cs1, 0xE9B5);
    // CBW  (0000_E9B4 / 0xE9B4)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xE9B9);
    // MOV ES,word ptr [0x5540] (0000_E9B5 / 0xE9B5)
    ES = UInt16[DS, 0x5540];
    CheckExternalEvents(cs1, 0xE9BD);
    // MOV ES:[0x68],AX (0000_E9B9 / 0xE9B9)
    UInt16[ES, 0x68] = AX;
    CheckExternalEvents(cs1, 0xE9C1);
    // MOV ES,word ptr [0x552a] (0000_E9BD / 0xE9BD)
    ES = UInt16[DS, 0x552A];
    CheckExternalEvents(cs1, 0xE9C5);
    // MOV AX,ES:[0x374e] (0000_E9C1 / 0xE9C1)
    AX = UInt16[ES, 0x374E];
    CheckExternalEvents(cs1, 0xE9C9);
    // MOV ES,word ptr [0x552c] (0000_E9C5 / 0xE9C5)
    ES = UInt16[DS, 0x552C];
    CheckExternalEvents(cs1, 0xE9CD);
    // MOV ES:[0x202],AX (0000_E9C9 / 0xE9C9)
    UInt16[ES, 0x202] = AX;
    CheckExternalEvents(cs1, 0xE9D2);
    // MOV word ptr [BP + -0x4],0x0 (0000_E9CD / 0xE9CD)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs1, 0xE9D4);
    // JMP 0x0000:e9fb (0000_E9D2 / 0xE9D2)
    goto label_0000_E9FB_0E9FB;
    label_0000_E9D4_0E9D4:
    CheckExternalEvents(cs1, 0xE9D8);
    // MOV ES,word ptr [0x5540] (0000_E9D4 / 0xE9D4)
    ES = UInt16[DS, 0x5540];
    CheckExternalEvents(cs1, 0xE9DB);
    // MOV AX,0x7d (0000_E9D8 / 0xE9D8)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xE9E0);
    // IMUL word ptr ES:[0x68] (0000_E9DB / 0xE9DB)
    int resImul0000_E9DB = Alu.Imul16((short)AX, (short)UInt16[ES, 0x68]);
    AX = (ushort)(resImul0000_E9DB);
    DX = (ushort)(resImul0000_E9DB >> 16);
    CheckExternalEvents(cs1, 0xE9E2);
    // MOV BX,AX (0000_E9E0 / 0xE9E0)
    BX = AX;
    CheckExternalEvents(cs1, 0xE9E6);
    // LEA AX,[BX + 0xc724] (0000_E9E2 / 0xE9E2)
    AX = (ushort)(BX + 0xC724);
    CheckExternalEvents(cs1, 0xE9E9);
    // MOV DX,0x2a02 (0000_E9E6 / 0xE9E6)
    DX = 0x2A02;
    label_0000_E9E9_0E9E9:
    CheckExternalEvents(cs1, 0xE9EA);
    // PUSH DX (0000_E9E9 / 0xE9E9)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xE9EB);
    // PUSH AX (0000_E9EA / 0xE9EA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xE9F0);
    // CALLF 0x1000:8055 (0000_E9EB / 0xE9EB)
    FarCall(cs1, 0xE9F0, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xE9F3);
    // ADD SP,0x4 (0000_E9F0 / 0xE9F0)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xE9F8);
    // CALLF 0x1000:7c4e (0000_E9F3 / 0xE9F3)
    FarCall(cs1, 0xE9F8, ghidra_guess_1000_7C4E_17C4E);
    CheckExternalEvents(cs1, 0xE9FB);
    // INC word ptr [BP + -0x4] (0000_E9F8 / 0xE9F8)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x4)]);
    label_0000_E9FB_0E9FB:
    CheckExternalEvents(cs1, 0xE9FE);
    // MOV AX,word ptr [BP + -0x2] (0000_E9FB / 0xE9FB)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xEA01);
    // CMP word ptr [BP + -0x4],AX (0000_E9FE / 0xE9FE)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs1, 0xEA03);
    // JL 0x0000:ea06 (0000_EA01 / 0xEA01)
    if(SignFlag != OverflowFlag) {
      goto label_0000_EA06_0EA06;
    }
    CheckExternalEvents(cs1, 0xEA06);
    // JMP 0x0000:eaad (0000_EA03 / 0xEA03)
    goto label_0000_EAAD_0EAAD;
    label_0000_EA06_0EA06:
    CheckExternalEvents(cs1, 0xEA09);
    // MOV BX,word ptr [BP + -0x4] (0000_EA06 / 0xEA06)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xEA0D);
    // MOV ES,word ptr [0x553e] (0000_EA09 / 0xEA09)
    ES = UInt16[DS, 0x553E];
    CheckExternalEvents(cs1, 0xEA12);
    // MOV AL,byte ptr ES:[BX + 0xd558] (0000_EA0D / 0xEA0D)
    AL = UInt8[ES, (ushort)(BX + 0xD558)];
    CheckExternalEvents(cs1, 0xEA13);
    // CBW  (0000_EA12 / 0xEA12)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xEA17);
    // MOV ES,word ptr [0x5540] (0000_EA13 / 0xEA13)
    ES = UInt16[DS, 0x5540];
    CheckExternalEvents(cs1, 0xEA1B);
    // MOV ES:[0x68],AX (0000_EA17 / 0xEA17)
    UInt16[ES, 0x68] = AX;
    CheckExternalEvents(cs1, 0xEA1E);
    // MOV AX,0x7d (0000_EA1B / 0xEA1B)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xEA23);
    // IMUL word ptr ES:[0x68] (0000_EA1E / 0xEA1E)
    int resImul0000_EA1E = Alu.Imul16((short)AX, (short)UInt16[ES, 0x68]);
    AX = (ushort)(resImul0000_EA1E);
    DX = (ushort)(resImul0000_EA1E >> 16);
    CheckExternalEvents(cs1, 0xEA25);
    // MOV BX,AX (0000_EA23 / 0xEA23)
    BX = AX;
    CheckExternalEvents(cs1, 0xEA29);
    // MOV ES,word ptr [0x5528] (0000_EA25 / 0xEA25)
    ES = UInt16[DS, 0x5528];
    CheckExternalEvents(cs1, 0xEA2E);
    // MOV BL,byte ptr ES:[BX + 0xc79d] (0000_EA29 / 0xEA29)
    BL = UInt8[ES, (ushort)(BX + 0xC79D)];
    CheckExternalEvents(cs1, 0xEA30);
    // SUB BH,BH (0000_EA2E / 0xEA2E)
    BH -= BH;
    CheckExternalEvents(cs1, 0xEA32);
    // SHL BX,0x1 (0000_EA30 / 0xEA30)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xEA34);
    // SHL BX,0x1 (0000_EA32 / 0xEA32)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xEA38);
    // MOV ES,word ptr [0x552e] (0000_EA34 / 0xEA34)
    ES = UInt16[DS, 0x552E];
    CheckExternalEvents(cs1, 0xEA3D);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_EA38 / 0xEA38)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0xEA42);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_EA3D / 0xEA3D)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0xEA47);
    // CALLF 0x1000:8055 (0000_EA42 / 0xEA42)
    FarCall(cs1, 0xEA47, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xEA4A);
    // ADD SP,0x4 (0000_EA47 / 0xEA47)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xEA4D);
    // MOV AX,0x2900 (0000_EA4A / 0xEA4A)
    AX = 0x2900;
    CheckExternalEvents(cs1, 0xEA4E);
    // PUSH DS (0000_EA4D / 0xEA4D)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xEA4F);
    // PUSH AX (0000_EA4E / 0xEA4E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEA54);
    // CALLF 0x1000:8055 (0000_EA4F / 0xEA4F)
    FarCall(cs1, 0xEA54, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xEA57);
    // ADD SP,0x4 (0000_EA54 / 0xEA54)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xEA5B);
    // MOV ES,word ptr [0x5528] (0000_EA57 / 0xEA57)
    ES = UInt16[DS, 0x5528];
    CheckExternalEvents(cs1, 0xEA61);
    // CMP byte ptr ES:[0xd324],0x0 (0000_EA5B / 0xEA5B)
    Alu.Sub8(UInt8[ES, 0xD324], 0x0);
    CheckExternalEvents(cs1, 0xEA63);
    // JNZ 0x0000:ea66 (0000_EA61 / 0xEA61)
    if(!ZeroFlag) {
      goto label_0000_EA66_0EA66;
    }
    CheckExternalEvents(cs1, 0xEA66);
    // JMP 0x0000:e9d4 (0000_EA63 / 0xEA63)
    goto label_0000_E9D4_0E9D4;
    label_0000_EA66_0EA66:
    CheckExternalEvents(cs1, 0xEA6A);
    // MOV ES,word ptr [0x5540] (0000_EA66 / 0xEA66)
    ES = UInt16[DS, 0x5540];
    CheckExternalEvents(cs1, 0xEA6F);
    // MOV BX,word ptr ES:[0x68] (0000_EA6A / 0xEA6A)
    BX = UInt16[ES, 0x68];
    CheckExternalEvents(cs1, 0xEA73);
    // MOV ES,word ptr [0x5528] (0000_EA6F / 0xEA6F)
    ES = UInt16[DS, 0x5528];
    CheckExternalEvents(cs1, 0xEA78);
    // MOV AL,byte ptr ES:[BX + 0xd452] (0000_EA73 / 0xEA73)
    AL = UInt8[ES, (ushort)(BX + 0xD452)];
    CheckExternalEvents(cs1, 0xEA7C);
    // MOV ES,word ptr [0x5530] (0000_EA78 / 0xEA78)
    ES = UInt16[DS, 0x5530];
    CheckExternalEvents(cs1, 0xEA80);
    // MOV ES:[0x12],AL (0000_EA7C / 0xEA7C)
    UInt8[ES, 0x12] = AL;
    CheckExternalEvents(cs1, 0xEA84);
    // MOV ES,word ptr [0x5540] (0000_EA80 / 0xEA80)
    ES = UInt16[DS, 0x5540];
    CheckExternalEvents(cs1, 0xEA87);
    // MOV AX,0x7d (0000_EA84 / 0xEA84)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xEA89);
    // IMUL BX (0000_EA87 / 0xEA87)
    int resImul0000_EA87 = Alu.Imul16((short)AX, (short)BX);
    AX = (ushort)(resImul0000_EA87);
    DX = (ushort)(resImul0000_EA87 >> 16);
    CheckExternalEvents(cs1, 0xEA8B);
    // MOV BX,AX (0000_EA89 / 0xEA89)
    BX = AX;
    CheckExternalEvents(cs1, 0xEA8F);
    // LEA AX,[BX + 0xc725] (0000_EA8B / 0xEA8B)
    AX = (ushort)(BX + 0xC725);
    CheckExternalEvents(cs1, 0xEA92);
    // MOV DX,0x2a02 (0000_EA8F / 0xEA8F)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xEA93);
    // PUSH DX (0000_EA92 / 0xEA92)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xEA94);
    // PUSH AX (0000_EA93 / 0xEA93)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEA97);
    // MOV AX,0x13 (0000_EA94 / 0xEA94)
    AX = 0x13;
    CheckExternalEvents(cs1, 0xEA9A);
    // MOV DX,0x2a02 (0000_EA97 / 0xEA97)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xEA9B);
    // PUSH DX (0000_EA9A / 0xEA9A)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xEA9C);
    // PUSH AX (0000_EA9B / 0xEA9B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEAA1);
    // CALLF 0x1000:da58 (0000_EA9C / 0xEA9C)
    FarCall(cs1, 0xEAA1, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs1, 0xEAA4);
    // ADD SP,0x8 (0000_EAA1 / 0xEAA1)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0xEAA7);
    // MOV AX,0x12 (0000_EAA4 / 0xEAA4)
    AX = 0x12;
    CheckExternalEvents(cs1, 0xEAAA);
    // MOV DX,0x2a02 (0000_EAA7 / 0xEAA7)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xEAAD);
    // JMP 0x0000:e9e9 (0000_EAAA / 0xEAAA)
    goto label_0000_E9E9_0E9E9;
    label_0000_EAAD_0EAAD:
    CheckExternalEvents(cs1, 0xEAB1);
    // MOV ES,word ptr [0x552c] (0000_EAAD / 0xEAAD)
    ES = UInt16[DS, 0x552C];
    CheckExternalEvents(cs1, 0xEAB4);
    // MOV AX,word ptr [BP + -0x2] (0000_EAB1 / 0xEAB1)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xEAB8);
    // MOV ES:[0x206],AX (0000_EAB4 / 0xEAB4)
    UInt16[ES, 0x206] = AX;
    CheckExternalEvents(cs1, 0xEABF);
    // MOV word ptr ES:[0x208],0x0 (0000_EAB8 / 0xEAB8)
    UInt16[ES, 0x208] = 0x0;
    CheckExternalEvents(cs1, 0xEAC2);
    // MOV AX,0x17 (0000_EABF / 0xEABF)
    AX = 0x17;
    CheckExternalEvents(cs1, 0xEAC3);
    // PUSH AX (0000_EAC2 / 0xEAC2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEAC8);
    // CALLF 0x1000:87be (0000_EAC3 / 0xEAC3)
    FarCall(cs1, 0xEAC8, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0xEACA);
    // MOV BX,AX (0000_EAC8 / 0xEAC8)
    BX = AX;
    CheckExternalEvents(cs1, 0xEACE);
    // MOV ES,word ptr [0x553e] (0000_EACA / 0xEACA)
    ES = UInt16[DS, 0x553E];
    CheckExternalEvents(cs1, 0xEAD3);
    // MOV AL,byte ptr ES:[BX + 0xd558] (0000_EACE / 0xEACE)
    AL = UInt8[ES, (ushort)(BX + 0xD558)];
    CheckExternalEvents(cs1, 0xEAD4);
    // CBW  (0000_EAD3 / 0xEAD3)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xEAD8);
    // MOV ES,word ptr [0x5540] (0000_EAD4 / 0xEAD4)
    ES = UInt16[DS, 0x5540];
    CheckExternalEvents(cs1, 0xEADC);
    // MOV ES:[0x68],AX (0000_EAD8 / 0xEAD8)
    UInt16[ES, 0x68] = AX;
    CheckExternalEvents(cs1, 0xEAE0);
    // MOV ES,word ptr [0x552c] (0000_EADC / 0xEADC)
    ES = UInt16[DS, 0x552C];
    CheckExternalEvents(cs1, 0xEAE7);
    // MOV word ptr ES:[0x202],0x1 (0000_EAE0 / 0xEAE0)
    UInt16[ES, 0x202] = 0x1;
    CheckExternalEvents(cs1, 0xEAEA);
    // MOV AX,word ptr [BP + -0x2] (0000_EAE7 / 0xEAE7)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xEAEC);
    // MOV SP,BP (0000_EAEA / 0xEAEA)
    SP = BP;
    CheckExternalEvents(cs1, 0xEAED);
    // POP BP (0000_EAEC / 0xEAEC)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xEAEE);
    // RETF  (0000_EAED / 0xEAED)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_EAEE_0EAEE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_EAEE_0EAEE:
    CheckExternalEvents(cs1, 0xEAEF);
    // PUSH BP (0000_EAEE / 0xEAEE)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xEAF1);
    // MOV BP,SP (0000_EAEF / 0xEAEF)
    BP = SP;
    CheckExternalEvents(cs1, 0xEAF4);
    // MOV AX,0x4 (0000_EAF1 / 0xEAF1)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xEAF9);
    // CALLF 0x1000:cecc (0000_EAF4 / 0xEAF4)
    FarCall(cs1, 0xEAF9, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xEAFE);
    // MOV word ptr [BP + -0x2],0x0 (0000_EAF9 / 0xEAF9)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs1, 0xEB00);
    // JMP 0x0000:eb23 (0000_EAFE / 0xEAFE)
    goto label_0000_EB23_0EB23;
    label_0000_EB00_0EB00:
    CheckExternalEvents(cs1, 0xEB03);
    // INC word ptr [BP + -0x4] (0000_EB00 / 0xEB00)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_0000_EB03_0EB03:
    CheckExternalEvents(cs1, 0xEB07);
    // CMP word ptr [BP + -0x4],0x18 (0000_EB03 / 0xEB03)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x18);
    CheckExternalEvents(cs1, 0xEB09);
    // JGE 0x0000:eb20 (0000_EB07 / 0xEB07)
    if(SignFlag == OverflowFlag) {
      goto label_0000_EB20_0EB20;
    }
    CheckExternalEvents(cs1, 0xEB0C);
    // MOV AX,0x18 (0000_EB09 / 0xEB09)
    AX = 0x18;
    CheckExternalEvents(cs1, 0xEB0F);
    // IMUL word ptr [BP + -0x2] (0000_EB0C / 0xEB0C)
    int resImul0000_EB0C = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul0000_EB0C);
    DX = (ushort)(resImul0000_EB0C >> 16);
    CheckExternalEvents(cs1, 0xEB11);
    // MOV BX,AX (0000_EB0F / 0xEB0F)
    BX = AX;
    CheckExternalEvents(cs1, 0xEB14);
    // ADD BX,word ptr [BP + -0x4] (0000_EB11 / 0xEB11)
    // BX += UInt16[SS, (ushort)(BP - 0x4)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0xEB18);
    // MOV ES,word ptr [0x5542] (0000_EB14 / 0xEB14)
    ES = UInt16[DS, 0x5542];
    CheckExternalEvents(cs1, 0xEB1E);
    // MOV byte ptr ES:[BX + 0x40b4],0x0 (0000_EB18 / 0xEB18)
    UInt8[ES, (ushort)(BX + 0x40B4)] = 0x0;
    CheckExternalEvents(cs1, 0xEB20);
    // JMP 0x0000:eb00 (0000_EB1E / 0xEB1E)
    goto label_0000_EB00_0EB00;
    label_0000_EB20_0EB20:
    CheckExternalEvents(cs1, 0xEB23);
    // INC word ptr [BP + -0x2] (0000_EB20 / 0xEB20)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    label_0000_EB23_0EB23:
    CheckExternalEvents(cs1, 0xEB27);
    // CMP word ptr [BP + -0x2],0x18 (0000_EB23 / 0xEB23)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x18);
    CheckExternalEvents(cs1, 0xEB29);
    // JGE 0x0000:eb30 (0000_EB27 / 0xEB27)
    if(SignFlag == OverflowFlag) {
      goto label_0000_EB30_0EB30;
    }
    CheckExternalEvents(cs1, 0xEB2E);
    // MOV word ptr [BP + -0x4],0x0 (0000_EB29 / 0xEB29)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs1, 0xEB30);
    // JMP 0x0000:eb03 (0000_EB2E / 0xEB2E)
    goto label_0000_EB03_0EB03;
    label_0000_EB30_0EB30:
    CheckExternalEvents(cs1, 0xEB32);
    // MOV SP,BP (0000_EB30 / 0xEB30)
    SP = BP;
    CheckExternalEvents(cs1, 0xEB33);
    // POP BP (0000_EB32 / 0xEB32)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xEB34);
    // RETF  (0000_EB33 / 0xEB33)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_EB34_0EB34(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_EB34_0EB34:
    CheckExternalEvents(cs1, 0xEB35);
    // PUSH BP (0000_EB34 / 0xEB34)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xEB37);
    // MOV BP,SP (0000_EB35 / 0xEB35)
    BP = SP;
    CheckExternalEvents(cs1, 0xEB3A);
    // MOV AX,0x26 (0000_EB37 / 0xEB37)
    AX = 0x26;
    CheckExternalEvents(cs1, 0xEB3F);
    // CALLF 0x1000:cecc (0000_EB3A / 0xEB3A)
    FarCall(cs1, 0xEB3F, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xEB40);
    // PUSH SI (0000_EB3F / 0xEB3F)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xEB45);
    // MOV word ptr [BP + -0xe],0x0 (0000_EB40 / 0xEB40)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    label_0000_EB45_0EB45:
    CheckExternalEvents(cs1, 0xEB48);
    // MOV SI,word ptr [BP + -0xe] (0000_EB45 / 0xEB45)
    SI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xEB4C);
    // MOV byte ptr [BP + SI + -0x20],0x0 (0000_EB48 / 0xEB48)
    UInt8[SS, (ushort)(BP + SI - 0x20)] = 0x0;
    CheckExternalEvents(cs1, 0xEB4F);
    // INC word ptr [BP + -0xe] (0000_EB4C / 0xEB4C)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs1, 0xEB53);
    // CMP word ptr [BP + -0xe],0xc (0000_EB4F / 0xEB4F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0xC);
    CheckExternalEvents(cs1, 0xEB55);
    // JL 0x0000:eb45 (0000_EB53 / 0xEB53)
    if(SignFlag != OverflowFlag) {
      goto label_0000_EB45_0EB45;
    }
    CheckExternalEvents(cs1, 0xEB59);
    // CMP word ptr [BP + 0x6],0xc (0000_EB55 / 0xEB55)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs1, 0xEB5B);
    // JGE 0x0000:eb68 (0000_EB59 / 0xEB59)
    if(SignFlag == OverflowFlag) {
      goto label_0000_EB68_0EB68;
    }
    CheckExternalEvents(cs1, 0xEB5E);
    // MOV BX,word ptr [BP + 0x6] (0000_EB5B / 0xEB5B)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xEB62);
    // MOV ES,word ptr [0x5544] (0000_EB5E / 0xEB5E)
    ES = UInt16[DS, 0x5544];
    CheckExternalEvents(cs1, 0xEB68);
    // MOV byte ptr ES:[BX + 0x3994],0x0 (0000_EB62 / 0xEB62)
    UInt8[ES, (ushort)(BX + 0x3994)] = 0x0;
    label_0000_EB68_0EB68:
    CheckExternalEvents(cs1, 0xEB6C);
    // CMP word ptr [BP + 0x6],0x4 (0000_EB68 / 0xEB68)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs1, 0xEB6E);
    // JL 0x0000:eb71 (0000_EB6C / 0xEB6C)
    if(SignFlag != OverflowFlag) {
      goto label_0000_EB71_0EB71;
    }
    CheckExternalEvents(cs1, 0xEB71);
    // JMP 0x0000:f12d (0000_EB6E / 0xEB6E)
    goto label_0000_F12D_0F12D;
    label_0000_EB71_0EB71:
    CheckExternalEvents(cs1, 0xEB76);
    // MOV word ptr [BP + -0x8],0x0 (0000_EB71 / 0xEB71)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs1, 0xEB7B);
    // MOV word ptr [BP + -0xe],0x33 (0000_EB76 / 0xEB76)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x33;
    label_0000_EB7B_0EB7B:
    CheckExternalEvents(cs1, 0xEB7F);
    // CMP word ptr [BP + -0x8],0xc (0000_EB7B / 0xEB7B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0xC);
    CheckExternalEvents(cs1, 0xEB81);
    // JGE 0x0000:ebb6 (0000_EB7F / 0xEB7F)
    if(SignFlag == OverflowFlag) {
      goto label_0000_EBB6_0EBB6;
    }
    CheckExternalEvents(cs1, 0xEB84);
    // MOV AX,0x7d (0000_EB81 / 0xEB81)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xEB87);
    // IMUL word ptr [BP + 0x6] (0000_EB84 / 0xEB84)
    int resImul0000_EB84 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_EB84);
    DX = (ushort)(resImul0000_EB84 >> 16);
    CheckExternalEvents(cs1, 0xEB89);
    // MOV BX,AX (0000_EB87 / 0xEB87)
    BX = AX;
    CheckExternalEvents(cs1, 0xEB8C);
    // ADD BX,word ptr [BP + -0xe] (0000_EB89 / 0xEB89)
    // BX += UInt16[SS, (ushort)(BP - 0xE)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs1, 0xEB90);
    // MOV ES,word ptr [0x5546] (0000_EB8C / 0xEB8C)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xEB95);
    // MOV AL,byte ptr ES:[BX + 0xc724] (0000_EB90 / 0xEB90)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs1, 0xEB98);
    // MOV byte ptr [BP + -0x22],AL (0000_EB95 / 0xEB95)
    UInt8[SS, (ushort)(BP - 0x22)] = AL;
    CheckExternalEvents(cs1, 0xEB9A);
    // SUB AH,AH (0000_EB98 / 0xEB98)
    AH -= AH;
    CheckExternalEvents(cs1, 0xEB9D);
    // AND AX,0x7f (0000_EB9A / 0xEB9A)
    // AX &= 0x7F;
    AX = Alu.And16(AX, 0x7F);
    CheckExternalEvents(cs1, 0xEBA0);
    // MOV word ptr [BP + -0x10],AX (0000_EB9D / 0xEB9D)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0xEBA3);
    // CMP AX,0x10 (0000_EBA0 / 0xEBA0)
    Alu.Sub16(AX, 0x10);
    CheckExternalEvents(cs1, 0xEBA5);
    // JL 0x0000:ebb6 (0000_EBA3 / 0xEBA3)
    if(SignFlag != OverflowFlag) {
      goto label_0000_EBB6_0EBB6;
    }
    CheckExternalEvents(cs1, 0xEBA8);
    // CMP AX,0x20 (0000_EBA5 / 0xEBA5)
    Alu.Sub16(AX, 0x20);
    CheckExternalEvents(cs1, 0xEBAA);
    // JG 0x0000:ebb6 (0000_EBA8 / 0xEBA8)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_EBB6_0EBB6;
    }
    CheckExternalEvents(cs1, 0xEBAD);
    // MOV SI,word ptr [BP + -0x8] (0000_EBAA / 0xEBAA)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0xEBB0);
    // INC word ptr [BP + -0x8] (0000_EBAD / 0xEBAD)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0xEBB3);
    // MOV AL,byte ptr [BP + -0x22] (0000_EBB0 / 0xEBB0)
    AL = UInt8[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs1, 0xEBB6);
    // MOV byte ptr [BP + SI + -0x20],AL (0000_EBB3 / 0xEBB3)
    UInt8[SS, (ushort)(BP + SI - 0x20)] = AL;
    label_0000_EBB6_0EBB6:
    CheckExternalEvents(cs1, 0xEBB9);
    // INC word ptr [BP + -0xe] (0000_EBB6 / 0xEBB6)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs1, 0xEBBD);
    // CMP word ptr [BP + -0xe],0x56 (0000_EBB9 / 0xEBB9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x56);
    CheckExternalEvents(cs1, 0xEBBF);
    // JL 0x0000:eb7b (0000_EBBD / 0xEBBD)
    if(SignFlag != OverflowFlag) {
      goto label_0000_EB7B_0EB7B;
    }
    CheckExternalEvents(cs1, 0xEBC2);
    // MOV AX,0x4 (0000_EBBF / 0xEBBF)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xEBC3);
    // PUSH AX (0000_EBC2 / 0xEBC2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEBC8);
    // CALLF 0x1000:7ee1 (0000_EBC3 / 0xEBC3)
    FarCall(cs1, 0xEBC8, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xEBCB);
    // ADD SP,0x2 (0000_EBC8 / 0xEBC8)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xEBD0);
    // CALLF 0x1000:7fe8 (0000_EBCB / 0xEBCB)
    FarCall(cs1, 0xEBD0, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xEBD3);
    // MOV BX,word ptr [BP + 0x6] (0000_EBD0 / 0xEBD0)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xEBD7);
    // MOV ES,word ptr [0x5548] (0000_EBD3 / 0xEBD3)
    ES = UInt16[DS, 0x5548];
    CheckExternalEvents(cs1, 0xEBDD);
    // CMP byte ptr ES:[BX + 0x6e],0x1e (0000_EBD7 / 0xEBD7)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0x6E)], 0x1E);
    CheckExternalEvents(cs1, 0xEBDF);
    // JNZ 0x0000:ec1b (0000_EBDD / 0xEBDD)
    if(!ZeroFlag) {
      goto label_0000_EC1B_0EC1B;
    }
    CheckExternalEvents(cs1, 0xEBE2);
    // MOV AX,0x2904 (0000_EBDF / 0xEBDF)
    AX = 0x2904;
    CheckExternalEvents(cs1, 0xEBE3);
    // PUSH DS (0000_EBE2 / 0xEBE2)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xEBE4);
    // PUSH AX (0000_EBE3 / 0xEBE3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEBE9);
    // CALLF 0x1000:8055 (0000_EBE4 / 0xEBE4)
    FarCall(cs1, 0xEBE9, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xEBEC);
    // ADD SP,0x4 (0000_EBE9 / 0xEBE9)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xEBF1);
    // CALLF 0x0000:414f (0000_EBEC / 0xEBEC)
    FarCall(cs1, 0xEBF1, ghidra_guess_0000_414F_0414F);
    CheckExternalEvents(cs1, 0xEBF6);
    // MOV word ptr [BP + -0xe],0x0 (0000_EBF1 / 0xEBF1)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    CheckExternalEvents(cs1, 0xEBF8);
    // JMP 0x0000:ebfb (0000_EBF6 / 0xEBF6)
    goto label_0000_EBFB_0EBFB;
    label_0000_EBF8_0EBF8:
    CheckExternalEvents(cs1, 0xEBFB);
    // INC word ptr [BP + -0xe] (0000_EBF8 / 0xEBF8)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_0000_EBFB_0EBFB:
    CheckExternalEvents(cs1, 0xEBFF);
    // CMP word ptr [BP + -0xe],0xc (0000_EBFB / 0xEBFB)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0xC);
    CheckExternalEvents(cs1, 0xEC01);
    // JL 0x0000:ec04 (0000_EBFF / 0xEBFF)
    if(SignFlag != OverflowFlag) {
      goto label_0000_EC04_0EC04;
    }
    CheckExternalEvents(cs1, 0xEC04);
    // JMP 0x0000:f29b (0000_EC01 / 0xEC01)
    goto label_0000_F29B_0F29B;
    label_0000_EC04_0EC04:
    CheckExternalEvents(cs1, 0xEC07);
    // MOV AX,0xc (0000_EC04 / 0xEC04)
    AX = 0xC;
    CheckExternalEvents(cs1, 0xEC0A);
    // IMUL word ptr [BP + 0x6] (0000_EC07 / 0xEC07)
    int resImul0000_EC07 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_EC07);
    DX = (ushort)(resImul0000_EC07 >> 16);
    CheckExternalEvents(cs1, 0xEC0C);
    // MOV BX,AX (0000_EC0A / 0xEC0A)
    BX = AX;
    CheckExternalEvents(cs1, 0xEC0F);
    // ADD BX,word ptr [BP + -0xe] (0000_EC0C / 0xEC0C)
    // BX += UInt16[SS, (ushort)(BP - 0xE)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs1, 0xEC13);
    // MOV ES,word ptr [0x554a] (0000_EC0F / 0xEC0F)
    ES = UInt16[DS, 0x554A];
    CheckExternalEvents(cs1, 0xEC19);
    // OR byte ptr ES:[BX + 0x3800],0x80 (0000_EC13 / 0xEC13)
    // UInt8[ES, (ushort)(BX + 0x3800)] |= 0x80;
    UInt8[ES, (ushort)(BX + 0x3800)] = Alu.Or8(UInt8[ES, (ushort)(BX + 0x3800)], 0x80);
    CheckExternalEvents(cs1, 0xEC1B);
    // JMP 0x0000:ebf8 (0000_EC19 / 0xEC19)
    goto label_0000_EBF8_0EBF8;
    label_0000_EC1B_0EC1B:
    CheckExternalEvents(cs1, 0xEC1E);
    // MOV AX,0x7d (0000_EC1B / 0xEC1B)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xEC21);
    // IMUL word ptr [BP + 0x6] (0000_EC1E / 0xEC1E)
    int resImul0000_EC1E = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_EC1E);
    DX = (ushort)(resImul0000_EC1E >> 16);
    CheckExternalEvents(cs1, 0xEC23);
    // MOV BX,AX (0000_EC21 / 0xEC21)
    BX = AX;
    CheckExternalEvents(cs1, 0xEC27);
    // MOV ES,word ptr [0x5546] (0000_EC23 / 0xEC23)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xEC2D);
    // CMP byte ptr ES:[BX + 0xc79b],0x1 (0000_EC27 / 0xEC27)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC79B)], 0x1);
    CheckExternalEvents(cs1, 0xEC2F);
    // JNZ 0x0000:ec46 (0000_EC2D / 0xEC2D)
    if(!ZeroFlag) {
      goto label_0000_EC46_0EC46;
    }
    CheckExternalEvents(cs1, 0xEC32);
    // MOV AX,0x292d (0000_EC2F / 0xEC2F)
    AX = 0x292D;
    CheckExternalEvents(cs1, 0xEC33);
    // PUSH DS (0000_EC32 / 0xEC32)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xEC34);
    // PUSH AX (0000_EC33 / 0xEC33)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEC39);
    // CALLF 0x1000:8055 (0000_EC34 / 0xEC34)
    FarCall(cs1, 0xEC39, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xEC3C);
    // ADD SP,0x4 (0000_EC39 / 0xEC39)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xEC41);
    // CALLF 0x1000:8d29 (0000_EC3C / 0xEC3C)
    FarCall(cs1, 0xEC41, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xEC46);
    // CALLF 0x1000:7fe8 (0000_EC41 / 0xEC41)
    FarCall(cs1, 0xEC46, unknown_17C6_0388_17FE8);
    label_0000_EC46_0EC46:
    CheckExternalEvents(cs1, 0xEC49);
    // MOV AX,0x7d (0000_EC46 / 0xEC46)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xEC4C);
    // IMUL word ptr [BP + 0x6] (0000_EC49 / 0xEC49)
    int resImul0000_EC49 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_EC49);
    DX = (ushort)(resImul0000_EC49 >> 16);
    CheckExternalEvents(cs1, 0xEC4E);
    // MOV BX,AX (0000_EC4C / 0xEC4C)
    BX = AX;
    CheckExternalEvents(cs1, 0xEC52);
    // MOV ES,word ptr [0x5546] (0000_EC4E / 0xEC4E)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xEC58);
    // CMP byte ptr ES:[BX + 0xc79b],0x2 (0000_EC52 / 0xEC52)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC79B)], 0x2);
    CheckExternalEvents(cs1, 0xEC5A);
    // JNZ 0x0000:ec74 (0000_EC58 / 0xEC58)
    if(!ZeroFlag) {
      goto label_0000_EC74_0EC74;
    }
    CheckExternalEvents(cs1, 0xEC5D);
    // MOV AX,0x2964 (0000_EC5A / 0xEC5A)
    AX = 0x2964;
    CheckExternalEvents(cs1, 0xEC5E);
    // PUSH DS (0000_EC5D / 0xEC5D)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xEC5F);
    // PUSH AX (0000_EC5E / 0xEC5E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEC64);
    // CALLF 0x1000:8055 (0000_EC5F / 0xEC5F)
    FarCall(cs1, 0xEC64, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xEC67);
    // ADD SP,0x4 (0000_EC64 / 0xEC64)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xEC6C);
    // CALLF 0x1000:8d29 (0000_EC67 / 0xEC67)
    FarCall(cs1, 0xEC6C, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xEC71);
    // CALLF 0x1000:7fe8 (0000_EC6C / 0xEC6C)
    FarCall(cs1, 0xEC71, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xEC74);
    // JMP 0x0000:f2f6 (0000_EC71 / 0xEC71)
    goto label_0000_F2F6_0F2F6;
    label_0000_EC74_0EC74:
    CheckExternalEvents(cs1, 0xEC77);
    // MOV AX,0x29a3 (0000_EC74 / 0xEC74)
    AX = 0x29A3;
    CheckExternalEvents(cs1, 0xEC78);
    // PUSH DS (0000_EC77 / 0xEC77)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xEC79);
    // PUSH AX (0000_EC78 / 0xEC78)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEC7E);
    // CALLF 0x1000:8055 (0000_EC79 / 0xEC79)
    FarCall(cs1, 0xEC7E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xEC81);
    // ADD SP,0x4 (0000_EC7E / 0xEC7E)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    label_0000_EC81_0EC81:
    CheckExternalEvents(cs1, 0xEC84);
    // MOV AX,0x1 (0000_EC81 / 0xEC81)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xEC85);
    // PUSH AX (0000_EC84 / 0xEC84)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEC88);
    // PUSH word ptr [BP + 0x6] (0000_EC85 / 0xEC85)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0xEC8D);
    // CALLF 0x1000:3224 (0000_EC88 / 0xEC88)
    FarCall(cs1, 0xEC8D, ghidra_guess_1000_3224_13224);
    CheckExternalEvents(cs1, 0xEC90);
    // ADD SP,0x4 (0000_EC8D / 0xEC8D)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xEC93);
    // LEA AX,[BP + -0x20] (0000_EC90 / 0xEC90)
    AX = (ushort)(BP - 0x20);
    CheckExternalEvents(cs1, 0xEC94);
    // PUSH SS (0000_EC93 / 0xEC93)
    Stack.Push16(SS);
    CheckExternalEvents(cs1, 0xEC95);
    // PUSH AX (0000_EC94 / 0xEC94)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEC9A);
    // CALLF 0x1000:da8e (0000_EC95 / 0xEC95)
    FarCall(cs1, 0xEC9A, unknown_19EF_3B9E_1DA8E);
    CheckExternalEvents(cs1, 0xEC9D);
    // ADD SP,0x4 (0000_EC9A / 0xEC9A)
    SP += 0x4;
    CheckExternalEvents(cs1, 0xEC9E);
    // INC AX (0000_EC9D / 0xEC9D)
    AX++;
    CheckExternalEvents(cs1, 0xEC9F);
    // INC AX (0000_EC9E / 0xEC9E)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs1, 0xECA3);
    // MOV ES,word ptr [0x554c] (0000_EC9F / 0xEC9F)
    ES = UInt16[DS, 0x554C];
    CheckExternalEvents(cs1, 0xECA7);
    // MOV ES:[0x56],AX (0000_ECA3 / 0xECA3)
    UInt16[ES, 0x56] = AX;
    CheckExternalEvents(cs1, 0xECAA);
    // LEA AX,[BP + -0x20] (0000_ECA7 / 0xECA7)
    AX = (ushort)(BP - 0x20);
    CheckExternalEvents(cs1, 0xECAB);
    // PUSH SS (0000_ECAA / 0xECAA)
    Stack.Push16(SS);
    CheckExternalEvents(cs1, 0xECAC);
    // PUSH AX (0000_ECAB / 0xECAB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xECB1);
    // CALLF 0x1000:da8e (0000_ECAC / 0xECAC)
    FarCall(cs1, 0xECB1, unknown_19EF_3B9E_1DA8E);
    CheckExternalEvents(cs1, 0xECB4);
    // ADD SP,0x4 (0000_ECB1 / 0xECB1)
    SP += 0x4;
    CheckExternalEvents(cs1, 0xECB7);
    // SUB AX,0x16 (0000_ECB4 / 0xECB4)
    AX -= 0x16;
    CheckExternalEvents(cs1, 0xECB9);
    // NEG AX (0000_ECB7 / 0xECB7)
    AX = Alu.Sub16(0, AX);
    CheckExternalEvents(cs1, 0xECBD);
    // MOV ES,word ptr [0x554c] (0000_ECB9 / 0xECB9)
    ES = UInt16[DS, 0x554C];
    CheckExternalEvents(cs1, 0xECC1);
    // MOV ES:[0x52],AX (0000_ECBD / 0xECBD)
    UInt16[ES, 0x52] = AX;
    CheckExternalEvents(cs1, 0xECC4);
    // MOV AX,0x5 (0000_ECC1 / 0xECC1)
    AX = 0x5;
    CheckExternalEvents(cs1, 0xECC5);
    // PUSH AX (0000_ECC4 / 0xECC4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xECCA);
    // CALLF 0x1000:7ee1 (0000_ECC5 / 0xECC5)
    FarCall(cs1, 0xECCA, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xECCD);
    // ADD SP,0x2 (0000_ECCA / 0xECCA)
    SP += 0x2;
    CheckExternalEvents(cs1, 0xECCF);
    // SUB AX,AX (0000_ECCD / 0xECCD)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xECD0);
    // PUSH AX (0000_ECCF / 0xECCF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xECD5);
    // CALLF 0x1000:7c64 (0000_ECD0 / 0xECD0)
    FarCall(cs1, 0xECD5, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0xECD8);
    // ADD SP,0x2 (0000_ECD5 / 0xECD5)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xECDD);
    // CALLF 0x1000:7fe8 (0000_ECD8 / 0xECD8)
    FarCall(cs1, 0xECDD, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xECE2);
    // CALLF 0x0000:3fa2 (0000_ECDD / 0xECDD)
    FarCall(cs1, 0xECE2, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0xECE5);
    // MOV AX,0x29be (0000_ECE2 / 0xECE2)
    AX = 0x29BE;
    CheckExternalEvents(cs1, 0xECE6);
    // PUSH DS (0000_ECE5 / 0xECE5)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xECE7);
    // PUSH AX (0000_ECE6 / 0xECE6)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xECEC);
    // CALLF 0x1000:8055 (0000_ECE7 / 0xECE7)
    FarCall(cs1, 0xECEC, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xECEF);
    // ADD SP,0x4 (0000_ECEC / 0xECEC)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xECF4);
    // MOV word ptr [BP + -0xe],0x0 (0000_ECEF / 0xECEF)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    CheckExternalEvents(cs1, 0xECF7);
    // JMP 0x0000:ef1c (0000_ECF4 / 0xECF4)
    goto label_0000_EF1C_0EF1C;
    label_0000_ECF7_0ECF7:
    CheckExternalEvents(cs1, 0xECFB);
    // MOV ES,word ptr [0x5552] (0000_ECF7 / 0xECF7)
    ES = UInt16[DS, 0x5552];
    CheckExternalEvents(cs1, 0xED02);
    // MOV word ptr ES:[0x37fe],0x1 (0000_ECFB / 0xECFB)
    UInt16[ES, 0x37FE] = 0x1;
    label_0000_ED02_0ED02:
    CheckExternalEvents(cs1, 0xED06);
    // TEST byte ptr [BP + -0x10],0x80 (0000_ED02 / 0xED02)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x10)], 0x80);
    CheckExternalEvents(cs1, 0xED08);
    // JZ 0x0000:ed2a (0000_ED06 / 0xED06)
    if(ZeroFlag) {
      goto label_0000_ED2A_0ED2A;
    }
    CheckExternalEvents(cs1, 0xED0C);
    // MOV ES,word ptr [0x5552] (0000_ED08 / 0xED08)
    ES = UInt16[DS, 0x5552];
    CheckExternalEvents(cs1, 0xED13);
    // MOV word ptr ES:[0x37fe],0x8 (0000_ED0C / 0xED0C)
    UInt16[ES, 0x37FE] = 0x8;
    CheckExternalEvents(cs1, 0xED17);
    // MOV ES,word ptr [0x5554] (0000_ED13 / 0xED13)
    ES = UInt16[DS, 0x5554];
    CheckExternalEvents(cs1, 0xED1D);
    // CMP word ptr ES:[0x4fba],0x0 (0000_ED17 / 0xED17)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0xED1F);
    // JNZ 0x0000:ed2a (0000_ED1D / 0xED1D)
    if(!ZeroFlag) {
      goto label_0000_ED2A_0ED2A;
    }
    CheckExternalEvents(cs1, 0xED23);
    // MOV ES,word ptr [0x5552] (0000_ED1F / 0xED1F)
    ES = UInt16[DS, 0x5552];
    CheckExternalEvents(cs1, 0xED2A);
    // MOV word ptr ES:[0x37fe],0x2 (0000_ED23 / 0xED23)
    UInt16[ES, 0x37FE] = 0x2;
    label_0000_ED2A_0ED2A:
    CheckExternalEvents(cs1, 0xED2D);
    // MOV AX,word ptr [BP + -0x10] (0000_ED2A / 0xED2A)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs1, 0xED30);
    // AND AX,0x7f (0000_ED2D / 0xED2D)
    // AX &= 0x7F;
    AX = Alu.And16(AX, 0x7F);
    CheckExternalEvents(cs1, 0xED33);
    // MOV CX,0x11 (0000_ED30 / 0xED30)
    CX = 0x11;
    CheckExternalEvents(cs1, 0xED35);
    // IMUL CX (0000_ED33 / 0xED33)
    int resImul0000_ED33 = Alu.Imul16((short)AX, (short)CX);
    AX = (ushort)(resImul0000_ED33);
    DX = (ushort)(resImul0000_ED33 >> 16);
    CheckExternalEvents(cs1, 0xED37);
    // MOV BX,AX (0000_ED35 / 0xED35)
    BX = AX;
    CheckExternalEvents(cs1, 0xED3B);
    // LEA AX,[BX + 0x2ec7] (0000_ED37 / 0xED37)
    AX = (ushort)(BX + 0x2EC7);
    CheckExternalEvents(cs1, 0xED3E);
    // MOV DX,0x384b (0000_ED3B / 0xED3B)
    DX = 0x384B;
    CheckExternalEvents(cs1, 0xED3F);
    // PUSH DX (0000_ED3E / 0xED3E)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xED40);
    // PUSH AX (0000_ED3F / 0xED3F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xED45);
    // CALLF 0x1000:8055 (0000_ED40 / 0xED40)
    FarCall(cs1, 0xED45, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xED48);
    // ADD SP,0x4 (0000_ED45 / 0xED45)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xED4C);
    // MOV ES,word ptr [0x554e] (0000_ED48 / 0xED48)
    ES = UInt16[DS, 0x554E];
    CheckExternalEvents(cs1, 0xED53);
    // MOV word ptr ES:[0x3748],0xb (0000_ED4C / 0xED4C)
    UInt16[ES, 0x3748] = 0xB;
    CheckExternalEvents(cs1, 0xED57);
    // TEST byte ptr [BP + -0x10],0x80 (0000_ED53 / 0xED53)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x10)], 0x80);
    CheckExternalEvents(cs1, 0xED59);
    // JZ 0x0000:ed7e (0000_ED57 / 0xED57)
    if(ZeroFlag) {
      goto label_0000_ED7E_0ED7E;
    }
    CheckExternalEvents(cs1, 0xED5C);
    // MOV AX,0x29d9 (0000_ED59 / 0xED59)
    AX = 0x29D9;
    CheckExternalEvents(cs1, 0xED5D);
    // PUSH DS (0000_ED5C / 0xED5C)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xED5E);
    // PUSH AX (0000_ED5D / 0xED5D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xED63);
    // CALLF 0x1000:8055 (0000_ED5E / 0xED5E)
    FarCall(cs1, 0xED63, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xED66);
    // ADD SP,0x4 (0000_ED63 / 0xED63)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xED69);
    // MOV AX,0xc (0000_ED66 / 0xED66)
    AX = 0xC;
    CheckExternalEvents(cs1, 0xED6C);
    // IMUL word ptr [BP + 0x6] (0000_ED69 / 0xED69)
    int resImul0000_ED69 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_ED69);
    DX = (ushort)(resImul0000_ED69 >> 16);
    CheckExternalEvents(cs1, 0xED6E);
    // MOV BX,AX (0000_ED6C / 0xED6C)
    BX = AX;
    CheckExternalEvents(cs1, 0xED71);
    // ADD BX,word ptr [BP + -0xe] (0000_ED6E / 0xED6E)
    // BX += UInt16[SS, (ushort)(BP - 0xE)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs1, 0xED75);
    // MOV ES,word ptr [0x554a] (0000_ED71 / 0xED71)
    ES = UInt16[DS, 0x554A];
    CheckExternalEvents(cs1, 0xED7B);
    // MOV byte ptr ES:[BX + 0x3800],0xff (0000_ED75 / 0xED75)
    UInt8[ES, (ushort)(BX + 0x3800)] = 0xFF;
    CheckExternalEvents(cs1, 0xED7E);
    // JMP 0x0000:ef19 (0000_ED7B / 0xED7B)
    goto label_0000_EF19_0EF19;
    label_0000_ED7E_0ED7E:
    CheckExternalEvents(cs1, 0xED82);
    // AND word ptr [BP + -0x10],0x7f (0000_ED7E / 0xED7E)
    // UInt16[SS, (ushort)(BP - 0x10)] &= 0x7F;
    UInt16[SS, (ushort)(BP - 0x10)] = Alu.And16(UInt16[SS, (ushort)(BP - 0x10)], 0x7F);
    CheckExternalEvents(cs1, 0xED85);
    // MOV AX,0x7d (0000_ED82 / 0xED82)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xED88);
    // IMUL word ptr [BP + 0x6] (0000_ED85 / 0xED85)
    int resImul0000_ED85 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_ED85);
    DX = (ushort)(resImul0000_ED85 >> 16);
    CheckExternalEvents(cs1, 0xED8A);
    // MOV BX,AX (0000_ED88 / 0xED88)
    BX = AX;
    CheckExternalEvents(cs1, 0xED8D);
    // ADD BX,word ptr [BP + -0xe] (0000_ED8A / 0xED8A)
    // BX += UInt16[SS, (ushort)(BP - 0xE)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs1, 0xED91);
    // MOV ES,word ptr [0x5546] (0000_ED8D / 0xED8D)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xED97);
    // CMP byte ptr ES:[BX + 0xc74b],0xff (0000_ED91 / 0xED91)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC74B)], 0xFF);
    CheckExternalEvents(cs1, 0xED99);
    // JNZ 0x0000:eda0 (0000_ED97 / 0xED97)
    if(!ZeroFlag) {
      goto label_0000_EDA0_0EDA0;
    }
    CheckExternalEvents(cs1, 0xED9C);
    // MOV AX,0x29e3 (0000_ED99 / 0xED99)
    AX = 0x29E3;
    label_0000_ED9C_0ED9C:
    CheckExternalEvents(cs1, 0xED9D);
    // PUSH DS (0000_ED9C / 0xED9C)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xEDA0);
    // JMP 0x0000:ee26 (0000_ED9D / 0xED9D)
    goto label_0000_EE26_0EE26;
    label_0000_EDA0_0EDA0:
    CheckExternalEvents(cs1, 0xEDA3);
    // MOV AX,0x7d (0000_EDA0 / 0xEDA0)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xEDA6);
    // IMUL word ptr [BP + 0x6] (0000_EDA3 / 0xEDA3)
    int resImul0000_EDA3 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_EDA3);
    DX = (ushort)(resImul0000_EDA3 >> 16);
    CheckExternalEvents(cs1, 0xEDA8);
    // MOV BX,AX (0000_EDA6 / 0xEDA6)
    BX = AX;
    CheckExternalEvents(cs1, 0xEDAB);
    // ADD BX,word ptr [BP + -0xe] (0000_EDA8 / 0xEDA8)
    BX += UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xEDB1);
    // CMP byte ptr ES:[BX + 0xc74b],0x0 (0000_EDAB / 0xEDAB)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC74B)], 0x0);
    CheckExternalEvents(cs1, 0xEDB3);
    // JNZ 0x0000:edb8 (0000_EDB1 / 0xEDB1)
    if(!ZeroFlag) {
      goto label_0000_EDB8_0EDB8;
    }
    CheckExternalEvents(cs1, 0xEDB6);
    // MOV AX,0x29e8 (0000_EDB3 / 0xEDB3)
    AX = 0x29E8;
    CheckExternalEvents(cs1, 0xEDB8);
    // JMP 0x0000:ed9c (0000_EDB6 / 0xEDB6)
    goto label_0000_ED9C_0ED9C;
    label_0000_EDB8_0EDB8:
    CheckExternalEvents(cs1, 0xEDBB);
    // MOV AX,0xa (0000_EDB8 / 0xEDB8)
    AX = 0xA;
    CheckExternalEvents(cs1, 0xEDBC);
    // PUSH AX (0000_EDBB / 0xEDBB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEDBF);
    // MOV AX,0x12 (0000_EDBC / 0xEDBC)
    AX = 0x12;
    CheckExternalEvents(cs1, 0xEDC2);
    // MOV DX,0x2a02 (0000_EDBF / 0xEDBF)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xEDC3);
    // PUSH DX (0000_EDC2 / 0xEDC2)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xEDC4);
    // PUSH AX (0000_EDC3 / 0xEDC3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEDC7);
    // MOV AX,0x7d (0000_EDC4 / 0xEDC4)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xEDCA);
    // IMUL word ptr [BP + 0x6] (0000_EDC7 / 0xEDC7)
    int resImul0000_EDC7 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_EDC7);
    DX = (ushort)(resImul0000_EDC7 >> 16);
    CheckExternalEvents(cs1, 0xEDCC);
    // MOV BX,AX (0000_EDCA / 0xEDCA)
    BX = AX;
    CheckExternalEvents(cs1, 0xEDCF);
    // ADD BX,word ptr [BP + -0xe] (0000_EDCC / 0xEDCC)
    // BX += UInt16[SS, (ushort)(BP - 0xE)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs1, 0xEDD4);
    // MOV AL,byte ptr ES:[BX + 0xc74b] (0000_EDCF / 0xEDCF)
    AL = UInt8[ES, (ushort)(BX + 0xC74B)];
    CheckExternalEvents(cs1, 0xEDD6);
    // SUB AH,AH (0000_EDD4 / 0xEDD4)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs1, 0xEDD7);
    // PUSH AX (0000_EDD6 / 0xEDD6)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEDDC);
    // CALLF 0x1000:daa6 (0000_EDD7 / 0xEDD7)
    FarCall(cs1, 0xEDDC, unknown_19EF_3BB6_1DAA6);
    CheckExternalEvents(cs1, 0xEDDF);
    // ADD SP,0x8 (0000_EDDC / 0xEDDC)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0xEDE2);
    // MOV AX,0x12 (0000_EDDF / 0xEDDF)
    AX = 0x12;
    CheckExternalEvents(cs1, 0xEDE5);
    // MOV DX,0x2a02 (0000_EDE2 / 0xEDE2)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xEDE6);
    // PUSH DX (0000_EDE5 / 0xEDE5)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xEDE7);
    // PUSH AX (0000_EDE6 / 0xEDE6)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEDEC);
    // CALLF 0x1000:da8e (0000_EDE7 / 0xEDE7)
    FarCall(cs1, 0xEDEC, unknown_19EF_3B9E_1DA8E);
    CheckExternalEvents(cs1, 0xEDEF);
    // ADD SP,0x4 (0000_EDEC / 0xEDEC)
    SP += 0x4;
    CheckExternalEvents(cs1, 0xEDF2);
    // CMP AX,0x3 (0000_EDEF / 0xEDEF)
    Alu.Sub16(AX, 0x3);
    CheckExternalEvents(cs1, 0xEDF4);
    // JGE 0x0000:ee1f (0000_EDF2 / 0xEDF2)
    if(SignFlag == OverflowFlag) {
      goto label_0000_EE1F_0EE1F;
    }
    CheckExternalEvents(cs1, 0xEDF7);
    // MOV AX,0x12 (0000_EDF4 / 0xEDF4)
    AX = 0x12;
    CheckExternalEvents(cs1, 0xEDFA);
    // MOV DX,0x2a02 (0000_EDF7 / 0xEDF7)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xEDFB);
    // PUSH DX (0000_EDFA / 0xEDFA)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xEDFC);
    // PUSH AX (0000_EDFB / 0xEDFB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEE01);
    // CALLF 0x1000:da8e (0000_EDFC / 0xEDFC)
    FarCall(cs1, 0xEE01, unknown_19EF_3B9E_1DA8E);
    CheckExternalEvents(cs1, 0xEE04);
    // ADD SP,0x4 (0000_EE01 / 0xEE01)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xEE07);
    // MOV word ptr [BP + -0x2],AX (0000_EE04 / 0xEE04)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0xEE09);
    // JMP 0x0000:ee19 (0000_EE07 / 0xEE07)
    goto label_0000_EE19_0EE19;
    label_0000_EE09_0EE09:
    CheckExternalEvents(cs1, 0xEE0C);
    // MOV AX,0x29ec (0000_EE09 / 0xEE09)
    AX = 0x29EC;
    CheckExternalEvents(cs1, 0xEE0D);
    // PUSH DS (0000_EE0C / 0xEE0C)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xEE0E);
    // PUSH AX (0000_EE0D / 0xEE0D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEE13);
    // CALLF 0x1000:8055 (0000_EE0E / 0xEE0E)
    FarCall(cs1, 0xEE13, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xEE16);
    // ADD SP,0x4 (0000_EE13 / 0xEE13)
    SP += 0x4;
    CheckExternalEvents(cs1, 0xEE19);
    // INC word ptr [BP + -0x2] (0000_EE16 / 0xEE16)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    label_0000_EE19_0EE19:
    CheckExternalEvents(cs1, 0xEE1D);
    // CMP word ptr [BP + -0x2],0x3 (0000_EE19 / 0xEE19)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x3);
    CheckExternalEvents(cs1, 0xEE1F);
    // JL 0x0000:ee09 (0000_EE1D / 0xEE1D)
    if(SignFlag != OverflowFlag) {
      goto label_0000_EE09_0EE09;
    }
    label_0000_EE1F_0EE1F:
    CheckExternalEvents(cs1, 0xEE22);
    // MOV AX,0x12 (0000_EE1F / 0xEE1F)
    AX = 0x12;
    CheckExternalEvents(cs1, 0xEE25);
    // MOV DX,0x2a02 (0000_EE22 / 0xEE22)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xEE26);
    // PUSH DX (0000_EE25 / 0xEE25)
    Stack.Push16(DX);
    label_0000_EE26_0EE26:
    CheckExternalEvents(cs1, 0xEE27);
    // PUSH AX (0000_EE26 / 0xEE26)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEE2C);
    // CALLF 0x1000:8055 (0000_EE27 / 0xEE27)
    FarCall(cs1, 0xEE2C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xEE2F);
    // ADD SP,0x4 (0000_EE2C / 0xEE2C)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xEE33);
    // MOV ES,word ptr [0x554e] (0000_EE2F / 0xEE2F)
    ES = UInt16[DS, 0x554E];
    CheckExternalEvents(cs1, 0xEE3A);
    // MOV word ptr ES:[0x3748],0x10 (0000_EE33 / 0xEE33)
    UInt16[ES, 0x3748] = 0x10;
    CheckExternalEvents(cs1, 0xEE3D);
    // MOV AX,0xc (0000_EE3A / 0xEE3A)
    AX = 0xC;
    CheckExternalEvents(cs1, 0xEE40);
    // IMUL word ptr [BP + 0x6] (0000_EE3D / 0xEE3D)
    int resImul0000_EE3D = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_EE3D);
    DX = (ushort)(resImul0000_EE3D >> 16);
    CheckExternalEvents(cs1, 0xEE43);
    // ADD AX,word ptr [BP + -0xe] (0000_EE40 / 0xEE40)
    AX += UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xEE46);
    // ADD AX,0x3800 (0000_EE43 / 0xEE43)
    // AX += 0x3800;
    AX = Alu.Add16(AX, 0x3800);
    CheckExternalEvents(cs1, 0xEE49);
    // MOV word ptr [BP + -0x26],AX (0000_EE46 / 0xEE46)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    CheckExternalEvents(cs1, 0xEE4E);
    // MOV word ptr [BP + -0x24],0x2a02 (0000_EE49 / 0xEE49)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x2A02;
    CheckExternalEvents(cs1, 0xEE51);
    // LES BX,[BP + -0x26] (0000_EE4E / 0xEE4E)
    BX = UInt16[SS, (ushort)(BP - 0x26)];
    ES = UInt16[SS, (ushort)(BP - 0x26 + 2)];
    CheckExternalEvents(cs1, 0xEE54);
    // MOV AL,byte ptr ES:[BX] (0000_EE51 / 0xEE51)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs1, 0xEE57);
    // MOV byte ptr [BP + -0x22],AL (0000_EE54 / 0xEE54)
    UInt8[SS, (ushort)(BP - 0x22)] = AL;
    CheckExternalEvents(cs1, 0xEE59);
    // CMP AL,0xff (0000_EE57 / 0xEE57)
    Alu.Sub8(AL, 0xFF);
    CheckExternalEvents(cs1, 0xEE5B);
    // JZ 0x0000:ee75 (0000_EE59 / 0xEE59)
    if(ZeroFlag) {
      goto label_0000_EE75_0EE75;
    }
    CheckExternalEvents(cs1, 0xEE5D);
    // MOV BL,AL (0000_EE5B / 0xEE5B)
    BL = AL;
    CheckExternalEvents(cs1, 0xEE60);
    // AND BX,0x7f (0000_EE5D / 0xEE5D)
    BX &= 0x7F;
    CheckExternalEvents(cs1, 0xEE62);
    // SHL BX,0x1 (0000_EE60 / 0xEE60)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xEE66);
    // MOV ES,word ptr [0x5556] (0000_EE62 / 0xEE62)
    ES = UInt16[DS, 0x5556];
    CheckExternalEvents(cs1, 0xEE6C);
    // CMP word ptr ES:[BX + 0x406a],0x0 (0000_EE66 / 0xEE66)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x406A)], 0x0);
    CheckExternalEvents(cs1, 0xEE6E);
    // JNZ 0x0000:ee75 (0000_EE6C / 0xEE6C)
    if(!ZeroFlag) {
      goto label_0000_EE75_0EE75;
    }
    CheckExternalEvents(cs1, 0xEE71);
    // LES BX,[BP + -0x26] (0000_EE6E / 0xEE6E)
    BX = UInt16[SS, (ushort)(BP - 0x26)];
    ES = UInt16[SS, (ushort)(BP - 0x26 + 2)];
    CheckExternalEvents(cs1, 0xEE75);
    // MOV byte ptr ES:[BX],0xff (0000_EE71 / 0xEE71)
    UInt8[ES, (ushort)(BX)] = 0xFF;
    label_0000_EE75_0EE75:
    CheckExternalEvents(cs1, 0xEE78);
    // MOV AX,0xc (0000_EE75 / 0xEE75)
    AX = 0xC;
    CheckExternalEvents(cs1, 0xEE7B);
    // IMUL word ptr [BP + 0x6] (0000_EE78 / 0xEE78)
    int resImul0000_EE78 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_EE78);
    DX = (ushort)(resImul0000_EE78 >> 16);
    CheckExternalEvents(cs1, 0xEE7E);
    // ADD AX,word ptr [BP + -0xe] (0000_EE7B / 0xEE7B)
    AX += UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xEE81);
    // ADD AX,0x3800 (0000_EE7E / 0xEE7E)
    // AX += 0x3800;
    AX = Alu.Add16(AX, 0x3800);
    CheckExternalEvents(cs1, 0xEE84);
    // MOV word ptr [BP + -0x26],AX (0000_EE81 / 0xEE81)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    CheckExternalEvents(cs1, 0xEE89);
    // MOV word ptr [BP + -0x24],0x2a02 (0000_EE84 / 0xEE84)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x2A02;
    CheckExternalEvents(cs1, 0xEE8C);
    // LES BX,[BP + -0x26] (0000_EE89 / 0xEE89)
    BX = UInt16[SS, (ushort)(BP - 0x26)];
    ES = UInt16[SS, (ushort)(BP - 0x26 + 2)];
    CheckExternalEvents(cs1, 0xEE90);
    // CMP byte ptr ES:[BX],0xff (0000_EE8C / 0xEE8C)
    Alu.Sub8(UInt8[ES, (ushort)(BX)], 0xFF);
    CheckExternalEvents(cs1, 0xEE92);
    // JZ 0x0000:ef0c (0000_EE90 / 0xEE90)
    if(ZeroFlag) {
      goto label_0000_EF0C_0EF0C;
    }
    CheckExternalEvents(cs1, 0xEE96);
    // AND byte ptr ES:[BX],0x7f (0000_EE92 / 0xEE92)
    // UInt8[ES, (ushort)(BX)] &= 0x7F;
    UInt8[ES, (ushort)(BX)] = Alu.And8(UInt8[ES, (ushort)(BX)], 0x7F);
    CheckExternalEvents(cs1, 0xEE99);
    // LES BX,[BP + -0x26] (0000_EE96 / 0xEE96)
    BX = UInt16[SS, (ushort)(BP - 0x26)];
    ES = UInt16[SS, (ushort)(BP - 0x26 + 2)];
    CheckExternalEvents(cs1, 0xEE9C);
    // MOV AL,byte ptr ES:[BX] (0000_EE99 / 0xEE99)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs1, 0xEE9D);
    // CBW  (0000_EE9C / 0xEE9C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xEEA0);
    // MOV word ptr [BP + -0xa],AX (0000_EE9D / 0xEE9D)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0xEEA4);
    // MOV ES,word ptr [0x5550] (0000_EEA0 / 0xEEA0)
    ES = UInt16[DS, 0x5550];
    CheckExternalEvents(cs1, 0xEEA8);
    // MOV AX,ES:[0x374e] (0000_EEA4 / 0xEEA4)
    AX = UInt16[ES, 0x374E];
    CheckExternalEvents(cs1, 0xEEAB);
    // MOV word ptr [BP + -0x14],AX (0000_EEA8 / 0xEEA8)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs1, 0xEEAF);
    // CMP word ptr [BP + -0xa],0x10 (0000_EEAB / 0xEEAB)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xA)], 0x10);
    CheckExternalEvents(cs1, 0xEEB1);
    // JL 0x0000:eeb7 (0000_EEAF / 0xEEAF)
    if(SignFlag != OverflowFlag) {
      goto label_0000_EEB7_0EEB7;
    }
    CheckExternalEvents(cs1, 0xEEB4);
    // MOV AX,0x29ee (0000_EEB1 / 0xEEB1)
    AX = 0x29EE;
    CheckExternalEvents(cs1, 0xEEB5);
    // PUSH DS (0000_EEB4 / 0xEEB4)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xEEB7);
    // JMP 0x0000:eec7 (0000_EEB5 / 0xEEB5)
    goto label_0000_EEC7_0EEC7;
    label_0000_EEB7_0EEB7:
    CheckExternalEvents(cs1, 0xEEBA);
    // MOV AX,0x7d (0000_EEB7 / 0xEEB7)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xEEBD);
    // IMUL word ptr [BP + -0xa] (0000_EEBA / 0xEEBA)
    int resImul0000_EEBA = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_EEBA);
    DX = (ushort)(resImul0000_EEBA >> 16);
    CheckExternalEvents(cs1, 0xEEBF);
    // MOV BX,AX (0000_EEBD / 0xEEBD)
    BX = AX;
    CheckExternalEvents(cs1, 0xEEC3);
    // LEA AX,[BX + 0xc33c] (0000_EEBF / 0xEEBF)
    AX = (ushort)(BX + 0xC33C);
    CheckExternalEvents(cs1, 0xEEC6);
    // MOV DX,0x2a02 (0000_EEC3 / 0xEEC3)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xEEC7);
    // PUSH DX (0000_EEC6 / 0xEEC6)
    Stack.Push16(DX);
    label_0000_EEC7_0EEC7:
    CheckExternalEvents(cs1, 0xEEC8);
    // PUSH AX (0000_EEC7 / 0xEEC7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEECD);
    // CALLF 0x1000:8055 (0000_EEC8 / 0xEEC8)
    FarCall(cs1, 0xEECD, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xEED0);
    // ADD SP,0x4 (0000_EECD / 0xEECD)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xEED4);
    // MOV ES,word ptr [0x554e] (0000_EED0 / 0xEED0)
    ES = UInt16[DS, 0x554E];
    CheckExternalEvents(cs1, 0xEEDB);
    // MOV word ptr ES:[0x3748],0x18 (0000_EED4 / 0xEED4)
    UInt16[ES, 0x3748] = 0x18;
    CheckExternalEvents(cs1, 0xEEDF);
    // MOV ES,word ptr [0x5550] (0000_EEDB / 0xEEDB)
    ES = UInt16[DS, 0x5550];
    CheckExternalEvents(cs1, 0xEEE2);
    // MOV AX,word ptr [BP + -0x14] (0000_EEDF / 0xEEDF)
    AX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0xEEE6);
    // MOV ES:[0x374e],AX (0000_EEE2 / 0xEEE2)
    UInt16[ES, 0x374E] = AX;
    CheckExternalEvents(cs1, 0xEEE9);
    // MOV AX,word ptr [BP + -0x10] (0000_EEE6 / 0xEEE6)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs1, 0xEEEA);
    // DEC AX (0000_EEE9 / 0xEEE9)
    AX = Alu.Dec16(AX);
    CheckExternalEvents(cs1, 0xEEEB);
    // PUSH AX (0000_EEEA / 0xEEEA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEEEE);
    // PUSH word ptr [BP + -0xa] (0000_EEEB / 0xEEEB)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0xEEF3);
    // CALLF 0x1000:0934 (0000_EEEE / 0xEEEE)
    FarCall(cs1, 0xEEF3, ghidra_guess_1000_0934_10934);
    CheckExternalEvents(cs1, 0xEEF6);
    // ADD SP,0x4 (0000_EEF3 / 0xEEF3)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xEEF8);
    // MOV BX,AX (0000_EEF6 / 0xEEF6)
    BX = AX;
    CheckExternalEvents(cs1, 0xEEFA);
    // SHL BX,0x1 (0000_EEF8 / 0xEEF8)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xEEFC);
    // SHL BX,0x1 (0000_EEFA / 0xEEFA)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xEF00);
    // MOV ES,word ptr [0x5558] (0000_EEFC / 0xEEFC)
    ES = UInt16[DS, 0x5558];
    CheckExternalEvents(cs1, 0xEF05);
    // PUSH word ptr ES:[BX + 0x2ebe] (0000_EF00 / 0xEF00)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x2EBE)]);
    CheckExternalEvents(cs1, 0xEF0A);
    // PUSH word ptr ES:[BX + 0x2ebc] (0000_EF05 / 0xEF05)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x2EBC)]);
    CheckExternalEvents(cs1, 0xEF0C);
    // JMP 0x0000:ef11 (0000_EF0A / 0xEF0A)
    goto label_0000_EF11_0EF11;
    label_0000_EF0C_0EF0C:
    CheckExternalEvents(cs1, 0xEF0F);
    // MOV AX,0x29f4 (0000_EF0C / 0xEF0C)
    AX = 0x29F4;
    CheckExternalEvents(cs1, 0xEF10);
    // PUSH DS (0000_EF0F / 0xEF0F)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xEF11);
    // PUSH AX (0000_EF10 / 0xEF10)
    Stack.Push16(AX);
    label_0000_EF11_0EF11:
    CheckExternalEvents(cs1, 0xEF16);
    // CALLF 0x1000:8055 (0000_EF11 / 0xEF11)
    FarCall(cs1, 0xEF16, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xEF19);
    // ADD SP,0x4 (0000_EF16 / 0xEF16)
    SP += 0x4;
    label_0000_EF19_0EF19:
    CheckExternalEvents(cs1, 0xEF1C);
    // INC word ptr [BP + -0xe] (0000_EF19 / 0xEF19)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_0000_EF1C_0EF1C:
    CheckExternalEvents(cs1, 0xEF20);
    // CMP word ptr [BP + -0xe],0xc (0000_EF1C / 0xEF1C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0xC);
    CheckExternalEvents(cs1, 0xEF22);
    // JGE 0x0000:ef8a (0000_EF20 / 0xEF20)
    if(SignFlag == OverflowFlag) {
      goto label_0000_EF8A_0EF8A;
    }
    CheckExternalEvents(cs1, 0xEF26);
    // MOV ES,word ptr [0x554e] (0000_EF22 / 0xEF22)
    ES = UInt16[DS, 0x554E];
    CheckExternalEvents(cs1, 0xEF2D);
    // MOV word ptr ES:[0x3748],0x0 (0000_EF26 / 0xEF26)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs1, 0xEF31);
    // MOV ES,word ptr [0x5550] (0000_EF2D / 0xEF2D)
    ES = UInt16[DS, 0x5550];
    CheckExternalEvents(cs1, 0xEF34);
    // MOV AX,word ptr [BP + -0xe] (0000_EF31 / 0xEF31)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xEF35);
    // INC AX (0000_EF34 / 0xEF34)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs1, 0xEF39);
    // MOV ES:[0x374e],AX (0000_EF35 / 0xEF35)
    UInt16[ES, 0x374E] = AX;
    CheckExternalEvents(cs1, 0xEF3C);
    // MOV SI,word ptr [BP + -0xe] (0000_EF39 / 0xEF39)
    SI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xEF40);
    // CMP byte ptr [BP + SI + -0x20],0x0 (0000_EF3C / 0xEF3C)
    Alu.Sub8(UInt8[SS, (ushort)(BP + SI - 0x20)], 0x0);
    CheckExternalEvents(cs1, 0xEF42);
    // JZ 0x0000:ef19 (0000_EF40 / 0xEF40)
    if(ZeroFlag) {
      goto label_0000_EF19_0EF19;
    }
    CheckExternalEvents(cs1, 0xEF45);
    // MOV AL,byte ptr [BP + SI + -0x20] (0000_EF42 / 0xEF42)
    AL = UInt8[SS, (ushort)(BP + SI - 0x20)];
    CheckExternalEvents(cs1, 0xEF46);
    // CBW  (0000_EF45 / 0xEF45)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xEF49);
    // MOV word ptr [BP + -0x10],AX (0000_EF46 / 0xEF46)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0xEF4D);
    // MOV ES,word ptr [0x5552] (0000_EF49 / 0xEF49)
    ES = UInt16[DS, 0x5552];
    CheckExternalEvents(cs1, 0xEF54);
    // MOV word ptr ES:[0x37fe],0xf (0000_EF4D / 0xEF4D)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0xEF57);
    // MOV AX,0xc (0000_EF54 / 0xEF54)
    AX = 0xC;
    CheckExternalEvents(cs1, 0xEF5A);
    // IMUL word ptr [BP + 0x6] (0000_EF57 / 0xEF57)
    int resImul0000_EF57 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_EF57);
    DX = (ushort)(resImul0000_EF57 >> 16);
    CheckExternalEvents(cs1, 0xEF5C);
    // MOV BX,AX (0000_EF5A / 0xEF5A)
    BX = AX;
    CheckExternalEvents(cs1, 0xEF5E);
    // ADD BX,SI (0000_EF5C / 0xEF5C)
    // BX += SI;
    BX = Alu.Add16(BX, SI);
    CheckExternalEvents(cs1, 0xEF62);
    // MOV ES,word ptr [0x554a] (0000_EF5E / 0xEF5E)
    ES = UInt16[DS, 0x554A];
    CheckExternalEvents(cs1, 0xEF68);
    // CMP byte ptr ES:[BX + 0x3800],0xff (0000_EF62 / 0xEF62)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0x3800)], 0xFF);
    CheckExternalEvents(cs1, 0xEF6A);
    // JNZ 0x0000:ef6d (0000_EF68 / 0xEF68)
    if(!ZeroFlag) {
      goto label_0000_EF6D_0EF6D;
    }
    CheckExternalEvents(cs1, 0xEF6D);
    // JMP 0x0000:ed02 (0000_EF6A / 0xEF6A)
    goto label_0000_ED02_0ED02;
    label_0000_EF6D_0EF6D:
    CheckExternalEvents(cs1, 0xEF71);
    // MOV ES,word ptr [0x5554] (0000_EF6D / 0xEF6D)
    ES = UInt16[DS, 0x5554];
    CheckExternalEvents(cs1, 0xEF77);
    // CMP word ptr ES:[0x4fba],0x0 (0000_EF71 / 0xEF71)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0xEF79);
    // JNZ 0x0000:ef7c (0000_EF77 / 0xEF77)
    if(!ZeroFlag) {
      goto label_0000_EF7C_0EF7C;
    }
    CheckExternalEvents(cs1, 0xEF7C);
    // JMP 0x0000:ecf7 (0000_EF79 / 0xEF79)
    goto label_0000_ECF7_0ECF7;
    label_0000_EF7C_0EF7C:
    CheckExternalEvents(cs1, 0xEF80);
    // MOV ES,word ptr [0x5552] (0000_EF7C / 0xEF7C)
    ES = UInt16[DS, 0x5552];
    CheckExternalEvents(cs1, 0xEF87);
    // MOV word ptr ES:[0x37fe],0xe (0000_EF80 / 0xEF80)
    UInt16[ES, 0x37FE] = 0xE;
    CheckExternalEvents(cs1, 0xEF8A);
    // JMP 0x0000:ed02 (0000_EF87 / 0xEF87)
    goto label_0000_ED02_0ED02;
    label_0000_EF8A_0EF8A:
    CheckExternalEvents(cs1, 0xEF8E);
    // MOV ES,word ptr [0x554e] (0000_EF8A / 0xEF8A)
    ES = UInt16[DS, 0x554E];
    CheckExternalEvents(cs1, 0xEF95);
    // MOV word ptr ES:[0x3748],0x0 (0000_EF8E / 0xEF8E)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs1, 0xEF98);
    // LEA AX,[BP + -0x20] (0000_EF95 / 0xEF95)
    AX = (ushort)(BP - 0x20);
    CheckExternalEvents(cs1, 0xEF99);
    // PUSH SS (0000_EF98 / 0xEF98)
    Stack.Push16(SS);
    CheckExternalEvents(cs1, 0xEF9A);
    // PUSH AX (0000_EF99 / 0xEF99)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEF9F);
    // CALLF 0x1000:da8e (0000_EF9A / 0xEF9A)
    FarCall(cs1, 0xEF9F, unknown_19EF_3B9E_1DA8E);
    CheckExternalEvents(cs1, 0xEFA2);
    // ADD SP,0x4 (0000_EF9F / 0xEF9F)
    SP += 0x4;
    CheckExternalEvents(cs1, 0xEFA3);
    // INC AX (0000_EFA2 / 0xEFA2)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs1, 0xEFA6);
    // MOV word ptr [BP + -0xc],AX (0000_EFA3 / 0xEFA3)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0xEFAA);
    // MOV ES,word ptr [0x5550] (0000_EFA6 / 0xEFA6)
    ES = UInt16[DS, 0x5550];
    CheckExternalEvents(cs1, 0xEFAE);
    // MOV ES:[0x374e],AX (0000_EFAA / 0xEFAA)
    UInt16[ES, 0x374E] = AX;
    CheckExternalEvents(cs1, 0xEFB1);
    // MOV AX,0x29f9 (0000_EFAE / 0xEFAE)
    AX = 0x29F9;
    CheckExternalEvents(cs1, 0xEFB2);
    // PUSH DS (0000_EFB1 / 0xEFB1)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xEFB3);
    // PUSH AX (0000_EFB2 / 0xEFB2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEFB8);
    // CALLF 0x1000:8055 (0000_EFB3 / 0xEFB3)
    FarCall(cs1, 0xEFB8, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xEFBB);
    // ADD SP,0x4 (0000_EFB8 / 0xEFB8)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xEFBF);
    // MOV ES,word ptr [0x555a] (0000_EFBB / 0xEFBB)
    ES = UInt16[DS, 0x555A];
    CheckExternalEvents(cs1, 0xEFC2);
    // MOV AX,word ptr [BP + -0xc] (0000_EFBF / 0xEFBF)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0xEFC5);
    // DEC word ptr [BP + -0xc] (0000_EFC2 / 0xEFC2)
    UInt16[SS, (ushort)(BP - 0xC)] = Alu.Dec16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0xEFC9);
    // MOV ES:[0xe6],AX (0000_EFC5 / 0xEFC5)
    UInt16[ES, 0xE6] = AX;
    CheckExternalEvents(cs1, 0xEFCC);
    // MOV AX,0x5 (0000_EFC9 / 0xEFC9)
    AX = 0x5;
    CheckExternalEvents(cs1, 0xEFCD);
    // PUSH AX (0000_EFCC / 0xEFCC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEFD2);
    // CALLF 0x1000:7ee1 (0000_EFCD / 0xEFCD)
    FarCall(cs1, 0xEFD2, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xEFD5);
    // ADD SP,0x2 (0000_EFD2 / 0xEFD2)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xEFD8);
    // MOV AX,0x5 (0000_EFD5 / 0xEFD5)
    AX = 0x5;
    CheckExternalEvents(cs1, 0xEFD9);
    // PUSH AX (0000_EFD8 / 0xEFD8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xEFDE);
    // CALLF 0x1000:87be (0000_EFD9 / 0xEFD9)
    FarCall(cs1, 0xEFDE, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0xEFE1);
    // ADD SP,0x2 (0000_EFDE / 0xEFDE)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xEFE4);
    // MOV word ptr [BP + -0xe],AX (0000_EFE1 / 0xEFE1)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs1, 0xEFE7);
    // MOV AX,word ptr [BP + -0xc] (0000_EFE4 / 0xEFE4)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0xEFEA);
    // CMP word ptr [BP + -0xe],AX (0000_EFE7 / 0xEFE7)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], AX);
    CheckExternalEvents(cs1, 0xEFEC);
    // JL 0x0000:efef (0000_EFEA / 0xEFEA)
    if(SignFlag != OverflowFlag) {
      goto label_0000_EFEF_0EFEF;
    }
    CheckExternalEvents(cs1, 0xEFEF);
    // JMP 0x0000:f11f (0000_EFEC / 0xEFEC)
    goto label_0000_F11F_0F11F;
    label_0000_EFEF_0EFEF:
    CheckExternalEvents(cs1, 0xEFF2);
    // MOV SI,word ptr [BP + -0xe] (0000_EFEF / 0xEFEF)
    SI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xEFF6);
    // TEST byte ptr [BP + SI + -0x20],0x80 (0000_EFF2 / 0xEFF2)
    Alu.And8(UInt8[SS, (ushort)(BP + SI - 0x20)], 0x80);
    CheckExternalEvents(cs1, 0xEFF8);
    // JZ 0x0000:f038 (0000_EFF6 / 0xEFF6)
    if(ZeroFlag) {
      goto label_0000_F038_0F038;
    }
    CheckExternalEvents(cs1, 0xEFFB);
    // MOV AX,0x2a00 (0000_EFF8 / 0xEFF8)
    AX = 0x2A00;
    label_0000_EFFB_0EFFB:
    CheckExternalEvents(cs1, 0xEFFC);
    // PUSH DS (0000_EFFB / 0xEFFB)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xEFFD);
    // PUSH AX (0000_EFFC / 0xEFFC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF002);
    // CALLF 0x1000:0a67 (0000_EFFD / 0xEFFD)
    FarCall(cs1, 0xF002, ghidra_guess_1000_0A67_10A67);
    CheckExternalEvents(cs1, 0xF005);
    // ADD SP,0x4 (0000_F002 / 0xF002)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF009);
    // MOV ES,word ptr [0x555a] (0000_F005 / 0xF005)
    ES = UInt16[DS, 0x555A];
    CheckExternalEvents(cs1, 0xF00E);
    // PUSH word ptr ES:[0xec] (0000_F009 / 0xF009)
    Stack.Push16(UInt16[ES, 0xEC]);
    CheckExternalEvents(cs1, 0xF013);
    // PUSH word ptr ES:[0xe4] (0000_F00E / 0xF00E)
    Stack.Push16(UInt16[ES, 0xE4]);
    CheckExternalEvents(cs1, 0xF017);
    // MOV AX,ES:[0xe2] (0000_F013 / 0xF013)
    AX = UInt16[ES, 0xE2];
    CheckExternalEvents(cs1, 0xF01B);
    // MOV ES,word ptr [0x555c] (0000_F017 / 0xF017)
    ES = UInt16[DS, 0x555C];
    CheckExternalEvents(cs1, 0xF020);
    // ADD AX,word ptr ES:[0x39a4] (0000_F01B / 0xF01B)
    AX += UInt16[ES, 0x39A4];
    CheckExternalEvents(cs1, 0xF023);
    // ADD AX,word ptr [BP + -0xe] (0000_F020 / 0xF020)
    // AX += UInt16[SS, (ushort)(BP - 0xE)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs1, 0xF024);
    // PUSH AX (0000_F023 / 0xF023)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF028);
    // MOV ES,word ptr [0x555e] (0000_F024 / 0xF024)
    ES = UInt16[DS, 0x555E];
    CheckExternalEvents(cs1, 0xF02D);
    // PUSH word ptr ES:[0x39a0] (0000_F028 / 0xF028)
    Stack.Push16(UInt16[ES, 0x39A0]);
    CheckExternalEvents(cs1, 0xF032);
    // CALLF 0x1000:ca77 (0000_F02D / 0xF02D)
    FarCall(cs1, 0xF032, unknown_19EF_2B87_1CA77);
    CheckExternalEvents(cs1, 0xF035);
    // ADD SP,0x8 (0000_F032 / 0xF032)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0xF038);
    // JMP 0x0000:f11f (0000_F035 / 0xF035)
    goto label_0000_F11F_0F11F;
    label_0000_F038_0F038:
    CheckExternalEvents(cs1, 0xF03B);
    // MOV AX,0x7d (0000_F038 / 0xF038)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xF03E);
    // IMUL word ptr [BP + 0x6] (0000_F03B / 0xF03B)
    int resImul0000_F03B = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_F03B);
    DX = (ushort)(resImul0000_F03B >> 16);
    CheckExternalEvents(cs1, 0xF040);
    // MOV BX,AX (0000_F03E / 0xF03E)
    BX = AX;
    CheckExternalEvents(cs1, 0xF043);
    // ADD BX,word ptr [BP + -0xe] (0000_F040 / 0xF040)
    // BX += UInt16[SS, (ushort)(BP - 0xE)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs1, 0xF047);
    // MOV ES,word ptr [0x5546] (0000_F043 / 0xF043)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xF04D);
    // CMP byte ptr ES:[BX + 0xc74b],0x0 (0000_F047 / 0xF047)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC74B)], 0x0);
    CheckExternalEvents(cs1, 0xF04F);
    // JNZ 0x0000:f054 (0000_F04D / 0xF04D)
    if(!ZeroFlag) {
      goto label_0000_F054_0F054;
    }
    CheckExternalEvents(cs1, 0xF052);
    // MOV AX,0x2a39 (0000_F04F / 0xF04F)
    AX = 0x2A39;
    CheckExternalEvents(cs1, 0xF054);
    // JMP 0x0000:effb (0000_F052 / 0xF052)
    goto label_0000_EFFB_0EFFB;
    label_0000_F054_0F054:
    CheckExternalEvents(cs1, 0xF059);
    // MOV word ptr [BP + -0x12],0x1 (0000_F054 / 0xF054)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    CheckExternalEvents(cs1, 0xF05C);
    // MOV AX,0xc (0000_F059 / 0xF059)
    AX = 0xC;
    CheckExternalEvents(cs1, 0xF05F);
    // IMUL word ptr [BP + 0x6] (0000_F05C / 0xF05C)
    int resImul0000_F05C = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_F05C);
    DX = (ushort)(resImul0000_F05C >> 16);
    CheckExternalEvents(cs1, 0xF061);
    // MOV BX,AX (0000_F05F / 0xF05F)
    BX = AX;
    CheckExternalEvents(cs1, 0xF064);
    // ADD BX,word ptr [BP + -0xe] (0000_F061 / 0xF061)
    // BX += UInt16[SS, (ushort)(BP - 0xE)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs1, 0xF068);
    // MOV ES,word ptr [0x554a] (0000_F064 / 0xF064)
    ES = UInt16[DS, 0x554A];
    CheckExternalEvents(cs1, 0xF06E);
    // CMP byte ptr ES:[BX + 0x3800],0xff (0000_F068 / 0xF068)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0x3800)], 0xFF);
    CheckExternalEvents(cs1, 0xF070);
    // JZ 0x0000:f0a2 (0000_F06E / 0xF06E)
    if(ZeroFlag) {
      goto label_0000_F0A2_0F0A2;
    }
    CheckExternalEvents(cs1, 0xF073);
    // MOV AX,0x4 (0000_F070 / 0xF070)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xF074);
    // PUSH AX (0000_F073 / 0xF073)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF079);
    // CALLF 0x1000:7ee1 (0000_F074 / 0xF074)
    FarCall(cs1, 0xF079, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xF07C);
    // ADD SP,0x2 (0000_F079 / 0xF079)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF081);
    // CALLF 0x1000:7fe8 (0000_F07C / 0xF07C)
    FarCall(cs1, 0xF081, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xF084);
    // MOV AX,0x2a74 (0000_F081 / 0xF081)
    AX = 0x2A74;
    CheckExternalEvents(cs1, 0xF085);
    // PUSH DS (0000_F084 / 0xF084)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF086);
    // PUSH AX (0000_F085 / 0xF085)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF08B);
    // CALLF 0x1000:8055 (0000_F086 / 0xF086)
    FarCall(cs1, 0xF08B, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF08E);
    // ADD SP,0x4 (0000_F08B / 0xF08B)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF091);
    // MOV AX,0x1 (0000_F08E / 0xF08E)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xF092);
    // PUSH AX (0000_F091 / 0xF091)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF097);
    // CALLF 0x0000:3113 (0000_F092 / 0xF092)
    FarCall(cs1, 0xF097, unknown_0170_1A13_03113);
    CheckExternalEvents(cs1, 0xF09A);
    // ADD SP,0x2 (0000_F097 / 0xF097)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF09D);
    // MOV word ptr [BP + -0x12],AX (0000_F09A / 0xF09A)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs1, 0xF0A2);
    // CALLF 0x1000:7fe8 (0000_F09D / 0xF09D)
    FarCall(cs1, 0xF0A2, unknown_17C6_0388_17FE8);
    label_0000_F0A2_0F0A2:
    CheckExternalEvents(cs1, 0xF0A6);
    // CMP word ptr [BP + -0x12],0x0 (0000_F0A2 / 0xF0A2)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs1, 0xF0A8);
    // JZ 0x0000:f11f (0000_F0A6 / 0xF0A6)
    if(ZeroFlag) {
      goto label_0000_F11F_0F11F;
    }
    CheckExternalEvents(cs1, 0xF0AB);
    // MOV AX,0xc (0000_F0A8 / 0xF0A8)
    AX = 0xC;
    CheckExternalEvents(cs1, 0xF0AE);
    // IMUL word ptr [BP + 0x6] (0000_F0AB / 0xF0AB)
    int resImul0000_F0AB = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_F0AB);
    DX = (ushort)(resImul0000_F0AB >> 16);
    CheckExternalEvents(cs1, 0xF0B0);
    // MOV BX,AX (0000_F0AE / 0xF0AE)
    BX = AX;
    CheckExternalEvents(cs1, 0xF0B3);
    // ADD BX,word ptr [BP + -0xe] (0000_F0B0 / 0xF0B0)
    // BX += UInt16[SS, (ushort)(BP - 0xE)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs1, 0xF0B7);
    // MOV ES,word ptr [0x554a] (0000_F0B3 / 0xF0B3)
    ES = UInt16[DS, 0x554A];
    CheckExternalEvents(cs1, 0xF0BD);
    // MOV byte ptr ES:[BX + 0x3800],0xff (0000_F0B7 / 0xF0B7)
    UInt8[ES, (ushort)(BX + 0x3800)] = 0xFF;
    CheckExternalEvents(cs1, 0xF0C0);
    // MOV AX,0x4 (0000_F0BD / 0xF0BD)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xF0C1);
    // PUSH AX (0000_F0C0 / 0xF0C0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF0C6);
    // CALLF 0x1000:7ee1 (0000_F0C1 / 0xF0C1)
    FarCall(cs1, 0xF0C6, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xF0C9);
    // ADD SP,0x2 (0000_F0C6 / 0xF0C6)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF0CC);
    // MOV AX,0x4 (0000_F0C9 / 0xF0C9)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xF0CD);
    // PUSH AX (0000_F0CC / 0xF0CC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF0D2);
    // CALLF 0x1000:7c64 (0000_F0CD / 0xF0CD)
    FarCall(cs1, 0xF0D2, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0xF0D5);
    // ADD SP,0x2 (0000_F0D2 / 0xF0D2)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF0DA);
    // CALLF 0x1000:7fe8 (0000_F0D5 / 0xF0D5)
    FarCall(cs1, 0xF0DA, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xF0DD);
    // MOV AX,0x2aa8 (0000_F0DA / 0xF0DA)
    AX = 0x2AA8;
    CheckExternalEvents(cs1, 0xF0DE);
    // PUSH DS (0000_F0DD / 0xF0DD)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF0DF);
    // PUSH AX (0000_F0DE / 0xF0DE)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF0E4);
    // CALLF 0x1000:8055 (0000_F0DF / 0xF0DF)
    FarCall(cs1, 0xF0E4, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF0E7);
    // ADD SP,0x4 (0000_F0E4 / 0xF0E4)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF0EA);
    // PUSH word ptr [BP + -0xe] (0000_F0E7 / 0xF0E7)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs1, 0xF0ED);
    // MOV SI,word ptr [BP + -0xe] (0000_F0EA / 0xF0EA)
    SI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xF0F0);
    // MOV AL,byte ptr [BP + SI + -0x20] (0000_F0ED / 0xF0ED)
    AL = UInt8[SS, (ushort)(BP + SI - 0x20)];
    CheckExternalEvents(cs1, 0xF0F1);
    // CBW  (0000_F0F0 / 0xF0F0)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xF0F2);
    // DEC AX (0000_F0F1 / 0xF0F1)
    AX = Alu.Dec16(AX);
    CheckExternalEvents(cs1, 0xF0F3);
    // PUSH AX (0000_F0F2 / 0xF0F2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF0F6);
    // PUSH word ptr [BP + 0x6] (0000_F0F3 / 0xF0F3)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0xF0F7);
    // PUSH CS (0000_F0F6 / 0xF0F6)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0xF0FA);
    // CALL 0x0000:f2fb (0000_F0F7 / 0xF0F7)
    NearCall(cs1, 0xF0FA, ghidra_guess_0000_F2FB_0F2FB);
    CheckExternalEvents(cs1, 0xF0FD);
    // ADD SP,0x6 (0000_F0FA / 0xF0FA)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    CheckExternalEvents(cs1, 0xF100);
    // MOV AX,0x3 (0000_F0FD / 0xF0FD)
    AX = 0x3;
    CheckExternalEvents(cs1, 0xF101);
    // PUSH AX (0000_F100 / 0xF100)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF106);
    // CALLF 0x1000:7ee1 (0000_F101 / 0xF101)
    FarCall(cs1, 0xF106, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xF109);
    // ADD SP,0x2 (0000_F106 / 0xF106)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF10E);
    // CALLF 0x1000:7fe8 (0000_F109 / 0xF109)
    FarCall(cs1, 0xF10E, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xF111);
    // MOV AX,0x4 (0000_F10E / 0xF10E)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xF112);
    // PUSH AX (0000_F111 / 0xF111)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF117);
    // CALLF 0x1000:7ee1 (0000_F112 / 0xF112)
    FarCall(cs1, 0xF117, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xF11A);
    // ADD SP,0x2 (0000_F117 / 0xF117)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF11F);
    // CALLF 0x1000:7fe8 (0000_F11A / 0xF11A)
    FarCall(cs1, 0xF11F, unknown_17C6_0388_17FE8);
    label_0000_F11F_0F11F:
    CheckExternalEvents(cs1, 0xF122);
    // MOV AX,word ptr [BP + -0xc] (0000_F11F / 0xF11F)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0xF125);
    // CMP word ptr [BP + -0xe],AX (0000_F122 / 0xF122)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], AX);
    CheckExternalEvents(cs1, 0xF127);
    // JZ 0x0000:f12a (0000_F125 / 0xF125)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs1, 0xF12D);
      // JMP 0x0000:f29b (0000_F12A / 0xF12A)
      goto label_0000_F29B_0F29B;
    }
    CheckExternalEvents(cs1, 0xF12A);
    // JMP 0x0000:ec81 (0000_F127 / 0xF127)
    goto label_0000_EC81_0EC81;
    label_0000_F12A_0F12A:
    CheckExternalEvents(cs1, 0xF12D);
    // JMP 0x0000:f29b (0000_F12A / 0xF12A)
    goto label_0000_F29B_0F29B;
    label_0000_F12D_0F12D:
    CheckExternalEvents(cs1, 0xF130);
    // MOV AX,0x1 (0000_F12D / 0xF12D)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xF131);
    // PUSH AX (0000_F130 / 0xF130)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF134);
    // PUSH word ptr [BP + 0x6] (0000_F131 / 0xF131)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0xF139);
    // CALLF 0x1000:3224 (0000_F134 / 0xF134)
    FarCall(cs1, 0xF139, ghidra_guess_1000_3224_13224);
    CheckExternalEvents(cs1, 0xF13C);
    // ADD SP,0x4 (0000_F139 / 0xF139)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF13F);
    // MOV AX,0x4 (0000_F13C / 0xF13C)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xF140);
    // PUSH AX (0000_F13F / 0xF13F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF145);
    // CALLF 0x1000:7ee1 (0000_F140 / 0xF140)
    FarCall(cs1, 0xF145, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xF148);
    // ADD SP,0x2 (0000_F145 / 0xF145)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF14D);
    // CALLF 0x1000:7fe8 (0000_F148 / 0xF148)
    FarCall(cs1, 0xF14D, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xF152);
    // MOV word ptr [BP + -0x12],0x1 (0000_F14D / 0xF14D)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    CheckExternalEvents(cs1, 0xF155);
    // MOV AX,0xc (0000_F152 / 0xF152)
    AX = 0xC;
    CheckExternalEvents(cs1, 0xF158);
    // IMUL word ptr [BP + 0x6] (0000_F155 / 0xF155)
    int resImul0000_F155 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_F155);
    DX = (ushort)(resImul0000_F155 >> 16);
    CheckExternalEvents(cs1, 0xF15A);
    // MOV BX,AX (0000_F158 / 0xF158)
    BX = AX;
    CheckExternalEvents(cs1, 0xF15E);
    // MOV ES,word ptr [0x554a] (0000_F15A / 0xF15A)
    ES = UInt16[DS, 0x554A];
    CheckExternalEvents(cs1, 0xF163);
    // MOV AL,byte ptr ES:[BX + 0x3800] (0000_F15E / 0xF15E)
    AL = UInt8[ES, (ushort)(BX + 0x3800)];
    CheckExternalEvents(cs1, 0xF164);
    // CBW  (0000_F163 / 0xF163)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xF167);
    // MOV word ptr [BP + -0x6],AX (0000_F164 / 0xF164)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0xF16A);
    // MOV AX,0x11 (0000_F167 / 0xF167)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xF16D);
    // IMUL word ptr [BP + 0x6] (0000_F16A / 0xF16A)
    int resImul0000_F16A = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_F16A);
    DX = (ushort)(resImul0000_F16A >> 16);
    CheckExternalEvents(cs1, 0xF16F);
    // MOV BX,AX (0000_F16D / 0xF16D)
    BX = AX;
    CheckExternalEvents(cs1, 0xF173);
    // MOV ES,word ptr [0x5546] (0000_F16F / 0xF16F)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xF178);
    // MOV AL,byte ptr ES:[BX + 0xc5db] (0000_F173 / 0xF173)
    AL = UInt8[ES, (ushort)(BX + 0xC5DB)];
    CheckExternalEvents(cs1, 0xF179);
    // CBW  (0000_F178 / 0xF178)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xF17C);
    // MOV word ptr [BP + -0x10],AX (0000_F179 / 0xF179)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0xF180);
    // CMP word ptr [BP + -0x6],-0x1 (0000_F17C / 0xF17C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0xFFFF);
    CheckExternalEvents(cs1, 0xF182);
    // JNZ 0x0000:f185 (0000_F180 / 0xF180)
    if(!ZeroFlag) {
      goto label_0000_F185_0F185;
    }
    CheckExternalEvents(cs1, 0xF185);
    // JMP 0x0000:f230 (0000_F182 / 0xF182)
    goto label_0000_F230_0F230;
    label_0000_F185_0F185:
    CheckExternalEvents(cs1, 0xF188);
    // MOV AX,0x2ac6 (0000_F185 / 0xF185)
    AX = 0x2AC6;
    CheckExternalEvents(cs1, 0xF189);
    // PUSH DS (0000_F188 / 0xF188)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF18A);
    // PUSH AX (0000_F189 / 0xF189)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF18F);
    // CALLF 0x1000:8055 (0000_F18A / 0xF18A)
    FarCall(cs1, 0xF18F, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF192);
    // ADD SP,0x4 (0000_F18F / 0xF18F)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF195);
    // MOV AX,0x11 (0000_F192 / 0xF192)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xF198);
    // IMUL word ptr [BP + -0x10] (0000_F195 / 0xF195)
    int resImul0000_F195 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x10)]);
    AX = (ushort)(resImul0000_F195);
    DX = (ushort)(resImul0000_F195 >> 16);
    CheckExternalEvents(cs1, 0xF19A);
    // MOV BX,AX (0000_F198 / 0xF198)
    BX = AX;
    CheckExternalEvents(cs1, 0xF19E);
    // LEA AX,[BX + 0x2ed8] (0000_F19A / 0xF19A)
    AX = (ushort)(BX + 0x2ED8);
    CheckExternalEvents(cs1, 0xF1A1);
    // MOV DX,0x384b (0000_F19E / 0xF19E)
    DX = 0x384B;
    CheckExternalEvents(cs1, 0xF1A2);
    // PUSH DX (0000_F1A1 / 0xF1A1)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xF1A3);
    // PUSH AX (0000_F1A2 / 0xF1A2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF1A8);
    // CALLF 0x1000:8055 (0000_F1A3 / 0xF1A3)
    FarCall(cs1, 0xF1A8, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF1AB);
    // ADD SP,0x4 (0000_F1A8 / 0xF1A8)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF1AE);
    // MOV AX,0x2ada (0000_F1AB / 0xF1AB)
    AX = 0x2ADA;
    CheckExternalEvents(cs1, 0xF1AF);
    // PUSH DS (0000_F1AE / 0xF1AE)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF1B0);
    // PUSH AX (0000_F1AF / 0xF1AF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF1B5);
    // CALLF 0x1000:8055 (0000_F1B0 / 0xF1B0)
    FarCall(cs1, 0xF1B5, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF1B8);
    // ADD SP,0x4 (0000_F1B5 / 0xF1B5)
    SP += 0x4;
    CheckExternalEvents(cs1, 0xF1BC);
    // CMP word ptr [BP + -0x6],0x10 (0000_F1B8 / 0xF1B8)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x10);
    CheckExternalEvents(cs1, 0xF1BE);
    // JL 0x0000:f1c4 (0000_F1BC / 0xF1BC)
    if(SignFlag != OverflowFlag) {
      goto label_0000_F1C4_0F1C4;
    }
    CheckExternalEvents(cs1, 0xF1C1);
    // MOV AX,0x2ae6 (0000_F1BE / 0xF1BE)
    AX = 0x2AE6;
    CheckExternalEvents(cs1, 0xF1C2);
    // PUSH DS (0000_F1C1 / 0xF1C1)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF1C4);
    // JMP 0x0000:f1d4 (0000_F1C2 / 0xF1C2)
    goto label_0000_F1D4_0F1D4;
    label_0000_F1C4_0F1C4:
    CheckExternalEvents(cs1, 0xF1C7);
    // MOV AX,0x7d (0000_F1C4 / 0xF1C4)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xF1CA);
    // IMUL word ptr [BP + -0x6] (0000_F1C7 / 0xF1C7)
    int resImul0000_F1C7 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x6)]);
    AX = (ushort)(resImul0000_F1C7);
    DX = (ushort)(resImul0000_F1C7 >> 16);
    CheckExternalEvents(cs1, 0xF1CC);
    // MOV BX,AX (0000_F1CA / 0xF1CA)
    BX = AX;
    CheckExternalEvents(cs1, 0xF1D0);
    // LEA AX,[BX + 0xc33c] (0000_F1CC / 0xF1CC)
    AX = (ushort)(BX + 0xC33C);
    CheckExternalEvents(cs1, 0xF1D3);
    // MOV DX,0x2a02 (0000_F1D0 / 0xF1D0)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xF1D4);
    // PUSH DX (0000_F1D3 / 0xF1D3)
    Stack.Push16(DX);
    label_0000_F1D4_0F1D4:
    CheckExternalEvents(cs1, 0xF1D5);
    // PUSH AX (0000_F1D4 / 0xF1D4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF1DA);
    // CALLF 0x1000:8055 (0000_F1D5 / 0xF1D5)
    FarCall(cs1, 0xF1DA, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF1DD);
    // ADD SP,0x4 (0000_F1DA / 0xF1DA)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF1E0);
    // MOV AX,0x2aec (0000_F1DD / 0xF1DD)
    AX = 0x2AEC;
    CheckExternalEvents(cs1, 0xF1E1);
    // PUSH DS (0000_F1E0 / 0xF1E0)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF1E2);
    // PUSH AX (0000_F1E1 / 0xF1E1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF1E7);
    // CALLF 0x1000:8055 (0000_F1E2 / 0xF1E2)
    FarCall(cs1, 0xF1E7, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF1EA);
    // ADD SP,0x4 (0000_F1E7 / 0xF1E7)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF1ED);
    // PUSH word ptr [BP + -0x10] (0000_F1EA / 0xF1EA)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x10)]);
    CheckExternalEvents(cs1, 0xF1F0);
    // PUSH word ptr [BP + -0x6] (0000_F1ED / 0xF1ED)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0xF1F5);
    // CALLF 0x1000:0934 (0000_F1F0 / 0xF1F0)
    FarCall(cs1, 0xF1F5, ghidra_guess_1000_0934_10934);
    CheckExternalEvents(cs1, 0xF1F8);
    // ADD SP,0x4 (0000_F1F5 / 0xF1F5)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF1FA);
    // MOV BX,AX (0000_F1F8 / 0xF1F8)
    BX = AX;
    CheckExternalEvents(cs1, 0xF1FC);
    // SHL BX,0x1 (0000_F1FA / 0xF1FA)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xF1FE);
    // SHL BX,0x1 (0000_F1FC / 0xF1FC)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xF202);
    // MOV ES,word ptr [0x5558] (0000_F1FE / 0xF1FE)
    ES = UInt16[DS, 0x5558];
    CheckExternalEvents(cs1, 0xF207);
    // PUSH word ptr ES:[BX + 0x2ebe] (0000_F202 / 0xF202)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x2EBE)]);
    CheckExternalEvents(cs1, 0xF20C);
    // PUSH word ptr ES:[BX + 0x2ebc] (0000_F207 / 0xF207)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x2EBC)]);
    CheckExternalEvents(cs1, 0xF211);
    // CALLF 0x1000:8055 (0000_F20C / 0xF20C)
    FarCall(cs1, 0xF211, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF214);
    // ADD SP,0x4 (0000_F211 / 0xF211)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF217);
    // MOV AX,0x2af1 (0000_F214 / 0xF214)
    AX = 0x2AF1;
    CheckExternalEvents(cs1, 0xF218);
    // PUSH DS (0000_F217 / 0xF217)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF219);
    // PUSH AX (0000_F218 / 0xF218)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF21E);
    // CALLF 0x1000:8055 (0000_F219 / 0xF219)
    FarCall(cs1, 0xF21E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF221);
    // ADD SP,0x4 (0000_F21E / 0xF21E)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF224);
    // MOV AX,0x1 (0000_F221 / 0xF221)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xF225);
    // PUSH AX (0000_F224 / 0xF224)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF22A);
    // CALLF 0x0000:3113 (0000_F225 / 0xF225)
    FarCall(cs1, 0xF22A, unknown_0170_1A13_03113);
    CheckExternalEvents(cs1, 0xF22D);
    // ADD SP,0x2 (0000_F22A / 0xF22A)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF230);
    // MOV word ptr [BP + -0x12],AX (0000_F22D / 0xF22D)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    label_0000_F230_0F230:
    CheckExternalEvents(cs1, 0xF234);
    // CMP word ptr [BP + -0x12],0x0 (0000_F230 / 0xF230)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs1, 0xF236);
    // JZ 0x0000:f29b (0000_F234 / 0xF234)
    if(ZeroFlag) {
      goto label_0000_F29B_0F29B;
    }
    CheckExternalEvents(cs1, 0xF23B);
    // CALLF 0x1000:7fe8 (0000_F236 / 0xF236)
    FarCall(cs1, 0xF23B, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xF23E);
    // MOV AX,0x2b0c (0000_F23B / 0xF23B)
    AX = 0x2B0C;
    CheckExternalEvents(cs1, 0xF23F);
    // PUSH DS (0000_F23E / 0xF23E)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF240);
    // PUSH AX (0000_F23F / 0xF23F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF245);
    // CALLF 0x1000:8055 (0000_F240 / 0xF240)
    FarCall(cs1, 0xF245, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF248);
    // ADD SP,0x4 (0000_F245 / 0xF245)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF24B);
    // MOV AX,0x11 (0000_F248 / 0xF248)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xF24E);
    // IMUL word ptr [BP + 0x6] (0000_F24B / 0xF24B)
    int resImul0000_F24B = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_F24B);
    DX = (ushort)(resImul0000_F24B >> 16);
    CheckExternalEvents(cs1, 0xF250);
    // MOV BX,AX (0000_F24E / 0xF24E)
    BX = AX;
    CheckExternalEvents(cs1, 0xF254);
    // MOV ES,word ptr [0x5546] (0000_F250 / 0xF250)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xF256);
    // MOV AL,0x11 (0000_F254 / 0xF254)
    AL = 0x11;
    CheckExternalEvents(cs1, 0xF25B);
    // IMUL byte ptr ES:[BX + 0xc5db] (0000_F256 / 0xF256)
    short resImul0000_F256 = Alu.Imul8((sbyte)AL, (sbyte)UInt8[ES, (ushort)(BX + 0xC5DB)]);
    AL = (byte)(resImul0000_F256);
    AH = (byte)(resImul0000_F256 >> 8);
    CheckExternalEvents(cs1, 0xF25D);
    // MOV BX,AX (0000_F25B / 0xF25B)
    BX = AX;
    CheckExternalEvents(cs1, 0xF261);
    // LEA AX,[BX + 0x2ed8] (0000_F25D / 0xF25D)
    AX = (ushort)(BX + 0x2ED8);
    CheckExternalEvents(cs1, 0xF264);
    // MOV DX,0x384b (0000_F261 / 0xF261)
    DX = 0x384B;
    CheckExternalEvents(cs1, 0xF265);
    // PUSH DX (0000_F264 / 0xF264)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xF266);
    // PUSH AX (0000_F265 / 0xF265)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF26B);
    // CALLF 0x1000:8055 (0000_F266 / 0xF266)
    FarCall(cs1, 0xF26B, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF26E);
    // ADD SP,0x4 (0000_F26B / 0xF26B)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xF271);
    // MOV AX,0x2b16 (0000_F26E / 0xF26E)
    AX = 0x2B16;
    CheckExternalEvents(cs1, 0xF272);
    // PUSH DS (0000_F271 / 0xF271)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF273);
    // PUSH AX (0000_F272 / 0xF272)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF278);
    // CALLF 0x1000:8055 (0000_F273 / 0xF273)
    FarCall(cs1, 0xF278, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF27B);
    // ADD SP,0x4 (0000_F278 / 0xF278)
    SP += 0x4;
    CheckExternalEvents(cs1, 0xF27D);
    // SUB AX,AX (0000_F27B / 0xF27B)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xF27E);
    // PUSH AX (0000_F27D / 0xF27D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF281);
    // MOV AX,0x11 (0000_F27E / 0xF27E)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xF284);
    // IMUL word ptr [BP + 0x6] (0000_F281 / 0xF281)
    int resImul0000_F281 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_F281);
    DX = (ushort)(resImul0000_F281 >> 16);
    CheckExternalEvents(cs1, 0xF286);
    // MOV BX,AX (0000_F284 / 0xF284)
    BX = AX;
    CheckExternalEvents(cs1, 0xF28A);
    // MOV ES,word ptr [0x5546] (0000_F286 / 0xF286)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xF28F);
    // MOV AL,byte ptr ES:[BX + 0xc5db] (0000_F28A / 0xF28A)
    AL = UInt8[ES, (ushort)(BX + 0xC5DB)];
    CheckExternalEvents(cs1, 0xF290);
    // CBW  (0000_F28F / 0xF28F)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xF291);
    // PUSH AX (0000_F290 / 0xF290)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF294);
    // PUSH word ptr [BP + 0x6] (0000_F291 / 0xF291)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0xF295);
    // PUSH CS (0000_F294 / 0xF294)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0xF298);
    // CALL 0x0000:f2fb (0000_F295 / 0xF295)
    NearCall(cs1, 0xF298, ghidra_guess_0000_F2FB_0F2FB);
    CheckExternalEvents(cs1, 0xF29B);
    // ADD SP,0x6 (0000_F298 / 0xF298)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    label_0000_F29B_0F29B:
    CheckExternalEvents(cs1, 0xF29F);
    // MOV ES,word ptr [0x5552] (0000_F29B / 0xF29B)
    ES = UInt16[DS, 0x5552];
    CheckExternalEvents(cs1, 0xF2A6);
    // MOV word ptr ES:[0x37fe],0xf (0000_F29F / 0xF29F)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0xF2A9);
    // MOV AX,0x4 (0000_F2A6 / 0xF2A6)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xF2AA);
    // PUSH AX (0000_F2A9 / 0xF2A9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF2AF);
    // CALLF 0x1000:7ee1 (0000_F2AA / 0xF2AA)
    FarCall(cs1, 0xF2AF, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xF2B2);
    // ADD SP,0x2 (0000_F2AF / 0xF2AF)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF2B7);
    // CALLF 0x1000:7fe8 (0000_F2B2 / 0xF2B2)
    FarCall(cs1, 0xF2B7, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xF2BA);
    // MOV AX,0x4 (0000_F2B7 / 0xF2B7)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xF2BB);
    // PUSH AX (0000_F2BA / 0xF2BA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF2C0);
    // CALLF 0x1000:7c64 (0000_F2BB / 0xF2BB)
    FarCall(cs1, 0xF2C0, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0xF2C3);
    // ADD SP,0x2 (0000_F2C0 / 0xF2C0)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF2C7);
    // MOV ES,word ptr [0x5552] (0000_F2C3 / 0xF2C3)
    ES = UInt16[DS, 0x5552];
    CheckExternalEvents(cs1, 0xF2CE);
    // MOV word ptr ES:[0x37fe],0xf (0000_F2C7 / 0xF2C7)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0xF2D1);
    // MOV AX,0x3 (0000_F2CE / 0xF2CE)
    AX = 0x3;
    CheckExternalEvents(cs1, 0xF2D2);
    // PUSH AX (0000_F2D1 / 0xF2D1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF2D7);
    // CALLF 0x1000:7ee1 (0000_F2D2 / 0xF2D2)
    FarCall(cs1, 0xF2D7, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xF2DA);
    // ADD SP,0x2 (0000_F2D7 / 0xF2D7)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF2DF);
    // CALLF 0x1000:7fe8 (0000_F2DA / 0xF2DA)
    FarCall(cs1, 0xF2DF, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xF2E2);
    // MOV AX,0x3 (0000_F2DF / 0xF2DF)
    AX = 0x3;
    CheckExternalEvents(cs1, 0xF2E3);
    // PUSH AX (0000_F2E2 / 0xF2E2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF2E8);
    // CALLF 0x1000:7c64 (0000_F2E3 / 0xF2E3)
    FarCall(cs1, 0xF2E8, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0xF2EB);
    // ADD SP,0x2 (0000_F2E8 / 0xF2E8)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xF2EF);
    // MOV ES,word ptr [0x5552] (0000_F2EB / 0xF2EB)
    ES = UInt16[DS, 0x5552];
    CheckExternalEvents(cs1, 0xF2F6);
    // MOV word ptr ES:[0x37fe],0xf (0000_F2EF / 0xF2EF)
    UInt16[ES, 0x37FE] = 0xF;
    label_0000_F2F6_0F2F6:
    CheckExternalEvents(cs1, 0xF2F7);
    // POP SI (0000_F2F6 / 0xF2F6)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xF2F9);
    // MOV SP,BP (0000_F2F7 / 0xF2F7)
    SP = BP;
    CheckExternalEvents(cs1, 0xF2FA);
    // POP BP (0000_F2F9 / 0xF2F9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xF2FB);
    // RETF  (0000_F2FA / 0xF2FA)
    return FarRet();
  }
  
}
