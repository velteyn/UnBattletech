namespace generated;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.InstructionsImpl;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_1000_98EA_198EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_98EA_198EA:
    CheckExternalEvents(cs8, 0x98EB);
    // PUSH BP (1000_98EA / 0x198EA)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x98ED);
    // MOV BP,SP (1000_98EB / 0x198EB)
    BP = SP;
    CheckExternalEvents(cs8, 0x98F0);
    // MOV AX,0x4 (1000_98ED / 0x198ED)
    AX = 0x4;
    CheckExternalEvents(cs8, 0x98F5);
    // CALLF 0x1000:cecc (1000_98F0 / 0x198F0)
    FarCall(cs8, 0x98F5, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x98F9);
    // MOV ES,word ptr [0x5704] (1000_98F5 / 0x198F5)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs8, 0x98FC);
    // MOV AX,word ptr [BP + 0x6] (1000_98F9 / 0x198F9)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x9900);
    // MOV ES:[0x6c],AX (1000_98FC / 0x198FC)
    UInt16[ES, 0x6C] = AX;
    CheckExternalEvents(cs8, 0x9904);
    // MOV ES,word ptr [0x5706] (1000_9900 / 0x19900)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs8, 0x9907);
    // MOV AX,word ptr [BP + 0x8] (1000_9904 / 0x19904)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x990B);
    // MOV ES:[0x3776],AX (1000_9907 / 0x19907)
    UInt16[ES, 0x3776] = AX;
    CheckExternalEvents(cs8, 0x990F);
    // MOV ES,word ptr [0x5708] (1000_990B / 0x1990B)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs8, 0x9912);
    // MOV AX,word ptr [BP + 0xa] (1000_990F / 0x1990F)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0x9916);
    // MOV ES:[0x4312],AX (1000_9912 / 0x19912)
    UInt16[ES, 0x4312] = AX;
    CheckExternalEvents(cs8, 0x991A);
    // MOV ES,word ptr [0x570a] (1000_9916 / 0x19916)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs8, 0x991D);
    // MOV AX,word ptr [BP + 0xc] (1000_991A / 0x1991A)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x9921);
    // MOV ES:[0x398a],AX (1000_991D / 0x1991D)
    UInt16[ES, 0x398A] = AX;
    CheckExternalEvents(cs8, 0x9926);
    // CALLF 0x1000:9f57 (1000_9921 / 0x19921)
    FarCall(cs8, 0x9926, unknown_19EF_0067_19F57);
    CheckExternalEvents(cs8, 0x992B);
    // MOV word ptr [BP + -0x2],0x1 (1000_9926 / 0x19926)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    CheckExternalEvents(cs8, 0x992D);
    // JMP 0x1000:9930 (1000_992B / 0x1992B)
    goto label_1000_9930_19930;
    label_1000_992D_1992D:
    CheckExternalEvents(cs8, 0x9930);
    // INC word ptr [BP + -0x2] (1000_992D / 0x1992D)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_9930_19930:
    CheckExternalEvents(cs8, 0x9933);
    // MOV AX,[0x5006] (1000_9930 / 0x19930)
    AX = UInt16[DS, 0x5006];
    CheckExternalEvents(cs8, 0x9936);
    // CMP word ptr [BP + -0x2],AX (1000_9933 / 0x19933)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], AX);
    CheckExternalEvents(cs8, 0x9938);
    // JL 0x1000:992d (1000_9936 / 0x19936)
    if(SignFlag != OverflowFlag) {
      goto label_1000_992D_1992D;
    }
    CheckExternalEvents(cs8, 0x993D);
    // MOV word ptr [BP + -0x2],0x0 (1000_9938 / 0x19938)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs8, 0x993F);
    // JMP 0x1000:9969 (1000_993D / 0x1993D)
    goto label_1000_9969_19969;
    label_1000_993F_1993F:
    CheckExternalEvents(cs8, 0x9942);
    // INC word ptr [BP + -0x4] (1000_993F / 0x1993F)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1000_9942_19942:
    CheckExternalEvents(cs8, 0x9945);
    // MOV AX,[0x5006] (1000_9942 / 0x19942)
    AX = UInt16[DS, 0x5006];
    CheckExternalEvents(cs8, 0x9948);
    // CMP word ptr [BP + -0x4],AX (1000_9945 / 0x19945)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs8, 0x994A);
    // JGE 0x1000:9966 (1000_9948 / 0x19948)
    if(SignFlag == OverflowFlag) {
      goto label_1000_9966_19966;
    }
    CheckExternalEvents(cs8, 0x994E);
    // MOV ES,word ptr [0x5706] (1000_994A / 0x1994A)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs8, 0x9953);
    // PUSH word ptr ES:[0x3776] (1000_994E / 0x1994E)
    Stack.Push16(UInt16[ES, 0x3776]);
    CheckExternalEvents(cs8, 0x9957);
    // MOV ES,word ptr [0x5704] (1000_9953 / 0x19953)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs8, 0x995C);
    // PUSH word ptr ES:[0x6c] (1000_9957 / 0x19957)
    Stack.Push16(UInt16[ES, 0x6C]);
    CheckExternalEvents(cs8, 0x9961);
    // CALLF 0x1000:9f99 (1000_995C / 0x1995C)
    FarCall(cs8, 0x9961, unknown_19EF_00A9_19F99);
    CheckExternalEvents(cs8, 0x9964);
    // ADD SP,0x4 (1000_9961 / 0x19961)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x9966);
    // JMP 0x1000:993f (1000_9964 / 0x19964)
    goto label_1000_993F_1993F;
    label_1000_9966_19966:
    CheckExternalEvents(cs8, 0x9969);
    // INC word ptr [BP + -0x2] (1000_9966 / 0x19966)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_9969_19969:
    CheckExternalEvents(cs8, 0x996D);
    // MOV ES,word ptr [0x5708] (1000_9969 / 0x19969)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs8, 0x9970);
    // MOV AX,word ptr [BP + -0x2] (1000_996D / 0x1996D)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x9975);
    // CMP word ptr ES:[0x4312],AX (1000_9970 / 0x19970)
    Alu16.Sub(UInt16[ES, 0x4312], AX);
    CheckExternalEvents(cs8, 0x9977);
    // JLE 0x1000:998f (1000_9975 / 0x19975)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_998F_1998F;
    }
    CheckExternalEvents(cs8, 0x997B);
    // MOV ES,word ptr [0x570a] (1000_9977 / 0x19977)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs8, 0x9980);
    // PUSH word ptr ES:[0x398a] (1000_997B / 0x1997B)
    Stack.Push16(UInt16[ES, 0x398A]);
    CheckExternalEvents(cs8, 0x9985);
    // CALLF 0x1000:9f6d (1000_9980 / 0x19980)
    FarCall(cs8, 0x9985, unknown_19EF_007D_19F6D);
    CheckExternalEvents(cs8, 0x9988);
    // ADD SP,0x2 (1000_9985 / 0x19985)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x998D);
    // MOV word ptr [BP + -0x4],0x0 (1000_9988 / 0x19988)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs8, 0x998F);
    // JMP 0x1000:9942 (1000_998D / 0x1998D)
    goto label_1000_9942_19942;
    label_1000_998F_1998F:
    CheckExternalEvents(cs8, 0x9991);
    // MOV SP,BP (1000_998F / 0x1998F)
    SP = BP;
    CheckExternalEvents(cs8, 0x9992);
    // POP BP (1000_9991 / 0x19991)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x9993);
    // RETF  (1000_9992 / 0x19992)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9993_19993(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9993_19993:
    CheckExternalEvents(cs8, 0x9994);
    // PUSH BP (1000_9993 / 0x19993)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x9996);
    // MOV BP,SP (1000_9994 / 0x19994)
    BP = SP;
    CheckExternalEvents(cs8, 0x9999);
    // MOV AX,0x4 (1000_9996 / 0x19996)
    AX = 0x4;
    CheckExternalEvents(cs8, 0x999E);
    // CALLF 0x1000:cecc (1000_9999 / 0x19999)
    FarCall(cs8, 0x999E, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x999F);
    // PUSH SI (1000_999E / 0x1999E)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0x99A3);
    // MOV ES,word ptr [0x570c] (1000_999F / 0x1999F)
    ES = UInt16[DS, 0x570C];
    CheckExternalEvents(cs8, 0x99A6);
    // MOV AX,word ptr [BP + 0x6] (1000_99A3 / 0x199A3)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x99AA);
    // MOV ES:[0x0],AX (1000_99A6 / 0x199A6)
    UInt16[ES, 0x0] = AX;
    CheckExternalEvents(cs8, 0x99AE);
    // MOV ES,word ptr [0x570e] (1000_99AA / 0x199AA)
    ES = UInt16[DS, 0x570E];
    CheckExternalEvents(cs8, 0x99B1);
    // MOV AX,word ptr [BP + 0x8] (1000_99AE / 0x199AE)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x99B5);
    // MOV ES:[0x39f4],AX (1000_99B1 / 0x199B1)
    UInt16[ES, 0x39F4] = AX;
    CheckExternalEvents(cs8, 0x99B9);
    // MOV ES,word ptr [0x5710] (1000_99B5 / 0x199B5)
    ES = UInt16[DS, 0x5710];
    CheckExternalEvents(cs8, 0x99BC);
    // MOV AX,word ptr [BP + 0xa] (1000_99B9 / 0x199B9)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0x99C0);
    // MOV ES:[0x4000],AX (1000_99BC / 0x199BC)
    UInt16[ES, 0x4000] = AX;
    CheckExternalEvents(cs8, 0x99C4);
    // MOV ES,word ptr [0x5712] (1000_99C0 / 0x199C0)
    ES = UInt16[DS, 0x5712];
    CheckExternalEvents(cs8, 0x99C7);
    // MOV AX,word ptr [BP + 0xc] (1000_99C4 / 0x199C4)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x99CB);
    // MOV ES:[0x4034],AX (1000_99C7 / 0x199C7)
    UInt16[ES, 0x4034] = AX;
    CheckExternalEvents(cs8, 0x99CF);
    // MOV ES,word ptr [0x5714] (1000_99CB / 0x199CB)
    ES = UInt16[DS, 0x5714];
    CheckExternalEvents(cs8, 0x99D2);
    // MOV AX,word ptr [BP + 0xe] (1000_99CF / 0x199CF)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs8, 0x99D6);
    // MOV ES:[0x62],AX (1000_99D2 / 0x199D2)
    UInt16[ES, 0x62] = AX;
    CheckExternalEvents(cs8, 0x99D7);
    // PUSH CS (1000_99D6 / 0x199D6)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x99DA);
    // CALL 0x1000:97be (1000_99D7 / 0x199D7)
    NearCall(cs8, 0x99DA, unknown_1935_046E_197BE);
    CheckExternalEvents(cs8, 0x99DF);
    // MOV word ptr [BP + -0x4],0x0 (1000_99DA / 0x199DA)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs8, 0x99E1);
    // JMP 0x1000:9a28 (1000_99DF / 0x199DF)
    goto label_1000_9A28_19A28;
    label_1000_99E1_199E1:
    CheckExternalEvents(cs8, 0x99E4);
    // INC word ptr [BP + -0x2] (1000_99E1 / 0x199E1)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_99E4_199E4:
    CheckExternalEvents(cs8, 0x99E8);
    // MOV ES,word ptr [0x5714] (1000_99E4 / 0x199E4)
    ES = UInt16[DS, 0x5714];
    CheckExternalEvents(cs8, 0x99EC);
    // MOV AX,ES:[0x62] (1000_99E8 / 0x199E8)
    AX = UInt16[ES, 0x62];
    CheckExternalEvents(cs8, 0x99EF);
    // IMUL word ptr [BP + -0x2] (1000_99EC / 0x199EC)
    int resImul1000_99EC = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_99EC);
    DX = (ushort)(resImul1000_99EC >> 16);
    CheckExternalEvents(cs8, 0x99F1);
    // MOV SI,AX (1000_99EF / 0x199EF)
    SI = AX;
    CheckExternalEvents(cs8, 0x99F5);
    // MOV ES,word ptr [0x570e] (1000_99F1 / 0x199F1)
    ES = UInt16[DS, 0x570E];
    CheckExternalEvents(cs8, 0x99F9);
    // MOV AX,ES:[0x39f4] (1000_99F5 / 0x199F5)
    AX = UInt16[ES, 0x39F4];
    CheckExternalEvents(cs8, 0x99FB);
    // SHL AX,0x1 (1000_99F9 / 0x199F9)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0x99FD);
    // CMP AX,SI (1000_99FB / 0x199FB)
    Alu16.Sub(AX, SI);
    CheckExternalEvents(cs8, 0x99FF);
    // JLE 0x1000:9a25 (1000_99FD / 0x199FD)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_9A25_19A25;
    }
    CheckExternalEvents(cs8, 0x9A03);
    // MOV ES,word ptr [0x5710] (1000_99FF / 0x199FF)
    ES = UInt16[DS, 0x5710];
    CheckExternalEvents(cs8, 0x9A08);
    // PUSH word ptr ES:[0x4000] (1000_9A03 / 0x19A03)
    Stack.Push16(UInt16[ES, 0x4000]);
    CheckExternalEvents(cs8, 0x9A0C);
    // MOV ES,word ptr [0x570c] (1000_9A08 / 0x19A08)
    ES = UInt16[DS, 0x570C];
    CheckExternalEvents(cs8, 0x9A10);
    // MOV AX,ES:[0x0] (1000_9A0C / 0x19A0C)
    AX = UInt16[ES, 0x0];
    CheckExternalEvents(cs8, 0x9A14);
    // MOV ES,word ptr [0x570e] (1000_9A10 / 0x19A10)
    ES = UInt16[DS, 0x570E];
    CheckExternalEvents(cs8, 0x9A19);
    // SUB AX,word ptr ES:[0x39f4] (1000_9A14 / 0x19A14)
    AX -= UInt16[ES, 0x39F4];
    CheckExternalEvents(cs8, 0x9A1B);
    // ADD AX,SI (1000_9A19 / 0x19A19)
    // AX += SI;
    AX = Alu16.Add(AX, SI);
    CheckExternalEvents(cs8, 0x9A1C);
    // PUSH AX (1000_9A1B / 0x19A1B)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x9A1D);
    // PUSH CS (1000_9A1C / 0x19A1C)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x9A20);
    // CALL 0x1000:9a46 (1000_9A1D / 0x19A1D)
    NearCall(cs8, 0x9A20, ghidra_guess_1000_9A46_19A46);
    CheckExternalEvents(cs8, 0x9A23);
    // ADD SP,0x4 (1000_9A20 / 0x19A20)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x9A25);
    // JMP 0x1000:99e1 (1000_9A23 / 0x19A23)
    goto label_1000_99E1_199E1;
    label_1000_9A25_19A25:
    CheckExternalEvents(cs8, 0x9A28);
    // INC word ptr [BP + -0x4] (1000_9A25 / 0x19A25)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1000_9A28_19A28:
    CheckExternalEvents(cs8, 0x9A2C);
    // MOV ES,word ptr [0x5712] (1000_9A28 / 0x19A28)
    ES = UInt16[DS, 0x5712];
    CheckExternalEvents(cs8, 0x9A2F);
    // MOV AX,word ptr [BP + -0x4] (1000_9A2C / 0x19A2C)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs8, 0x9A34);
    // CMP word ptr ES:[0x4034],AX (1000_9A2F / 0x19A2F)
    Alu16.Sub(UInt16[ES, 0x4034], AX);
    CheckExternalEvents(cs8, 0x9A36);
    // JLE 0x1000:9a3d (1000_9A34 / 0x19A34)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_9A3D_19A3D;
    }
    CheckExternalEvents(cs8, 0x9A3B);
    // MOV word ptr [BP + -0x2],0x0 (1000_9A36 / 0x19A36)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs8, 0x9A3D);
    // JMP 0x1000:99e4 (1000_9A3B / 0x19A3B)
    goto label_1000_99E4_199E4;
    label_1000_9A3D_19A3D:
    CheckExternalEvents(cs8, 0x9A3E);
    // PUSH CS (1000_9A3D / 0x19A3D)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x9A41);
    // CALL 0x1000:9834 (1000_9A3E / 0x19A3E)
    NearCall(cs8, 0x9A41, unknown_1935_04E4_19834);
    CheckExternalEvents(cs8, 0x9A42);
    // POP SI (1000_9A41 / 0x19A41)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x9A44);
    // MOV SP,BP (1000_9A42 / 0x19A42)
    SP = BP;
    CheckExternalEvents(cs8, 0x9A45);
    // POP BP (1000_9A44 / 0x19A44)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x9A46);
    // RETF  (1000_9A45 / 0x19A45)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9A46_19A46(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9A46_19A46:
    CheckExternalEvents(cs8, 0x9A47);
    // PUSH BP (1000_9A46 / 0x19A46)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x9A49);
    // MOV BP,SP (1000_9A47 / 0x19A47)
    BP = SP;
    CheckExternalEvents(cs8, 0x9A4C);
    // MOV AX,0x4 (1000_9A49 / 0x19A49)
    AX = 0x4;
    CheckExternalEvents(cs8, 0x9A51);
    // CALLF 0x1000:cecc (1000_9A4C / 0x19A4C)
    FarCall(cs8, 0x9A51, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x9A55);
    // MOV ES,word ptr [0x5720] (1000_9A51 / 0x19A51)
    ES = UInt16[DS, 0x5720];
    CheckExternalEvents(cs8, 0x9A58);
    // MOV AX,word ptr [BP + 0x6] (1000_9A55 / 0x19A55)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x9A5C);
    // MOV ES:[0x3ff6],AX (1000_9A58 / 0x19A58)
    UInt16[ES, 0x3FF6] = AX;
    CheckExternalEvents(cs8, 0x9A60);
    // MOV ES,word ptr [0x5722] (1000_9A5C / 0x19A5C)
    ES = UInt16[DS, 0x5722];
    CheckExternalEvents(cs8, 0x9A63);
    // MOV AX,word ptr [BP + 0x8] (1000_9A60 / 0x19A60)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x9A67);
    // MOV ES:[0x3246],AX (1000_9A63 / 0x19A63)
    UInt16[ES, 0x3246] = AX;
    CheckExternalEvents(cs8, 0x9A6B);
    // MOV ES,word ptr [0x5720] (1000_9A67 / 0x19A67)
    ES = UInt16[DS, 0x5720];
    CheckExternalEvents(cs8, 0x9A70);
    // PUSH word ptr ES:[0x3ff6] (1000_9A6B / 0x19A6B)
    Stack.Push16(UInt16[ES, 0x3FF6]);
    CheckExternalEvents(cs8, 0x9A75);
    // CALLF 0x1000:9f20 (1000_9A70 / 0x19A70)
    FarCall(cs8, 0x9A75, ghidra_guess_1000_9F20_19F20);
    CheckExternalEvents(cs8, 0x9A78);
    // ADD SP,0x2 (1000_9A75 / 0x19A75)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x9A7D);
    // MOV word ptr [BP + -0x2],0x0 (1000_9A78 / 0x19A78)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs8, 0x9A7F);
    // JMP 0x1000:9a82 (1000_9A7D / 0x19A7D)
    goto label_1000_9A82_19A82;
    label_1000_9A7F_19A7F:
    CheckExternalEvents(cs8, 0x9A82);
    // INC word ptr [BP + -0x2] (1000_9A7F / 0x19A7F)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_9A82_19A82:
    CheckExternalEvents(cs8, 0x9A86);
    // MOV ES,word ptr [0x5722] (1000_9A82 / 0x19A82)
    ES = UInt16[DS, 0x5722];
    CheckExternalEvents(cs8, 0x9A8A);
    // MOV AX,ES:[0x3246] (1000_9A86 / 0x19A86)
    AX = UInt16[ES, 0x3246];
    CheckExternalEvents(cs8, 0x9A8E);
    // IMUL word ptr [0x5006] (1000_9A8A / 0x19A8A)
    int resImul1000_9A8A = Alu16.Imul((short)AX, (short)UInt16[DS, 0x5006]);
    AX = (ushort)(resImul1000_9A8A);
    DX = (ushort)(resImul1000_9A8A >> 16);
    CheckExternalEvents(cs8, 0x9A91);
    // CMP AX,word ptr [BP + -0x2] (1000_9A8E / 0x19A8E)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs8, 0x9A93);
    // JG 0x1000:9a7f (1000_9A91 / 0x19A91)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_9A7F_19A7F;
    }
    CheckExternalEvents(cs8, 0x9A95);
    // MOV SP,BP (1000_9A93 / 0x19A93)
    SP = BP;
    CheckExternalEvents(cs8, 0x9A96);
    // POP BP (1000_9A95 / 0x19A95)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x9A97);
    // RETF  (1000_9A96 / 0x19A96)
    return FarRet();
  }
  
  public virtual Action unknown_1935_0747_19A97(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1935_0747_19A97:
    CheckExternalEvents(cs12, 0x748);
    // PUSH BP (1935_0747 / 0x19A97)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x74A);
    // MOV BP,SP (1935_0748 / 0x19A98)
    BP = SP;
    CheckExternalEvents(cs12, 0x74D);
    // MOV AX,0x4 (1935_074A / 0x19A9A)
    AX = 0x4;
    CheckExternalEvents(cs12, 0x752);
    // CALLF 0x1000:cecc (1935_074D / 0x19A9D)
    FarCall(cs12, 0x752, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs12, 0x753);
    // PUSH SI (1935_0752 / 0x19AA2)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x757);
    // MOV ES,word ptr [0x5716] (1935_0753 / 0x19AA3)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs12, 0x75A);
    // MOV AX,word ptr [BP + 0x6] (1935_0757 / 0x19AA7)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x75E);
    // MOV ES:[0x398c],AX (1935_075A / 0x19AAA)
    UInt16[ES, 0x398C] = AX;
    CheckExternalEvents(cs12, 0x762);
    // MOV ES,word ptr [0x5718] (1935_075E / 0x19AAE)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs12, 0x765);
    // MOV AX,word ptr [BP + 0x8] (1935_0762 / 0x19AB2)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x769);
    // MOV ES:[0x39a2],AX (1935_0765 / 0x19AB5)
    UInt16[ES, 0x39A2] = AX;
    CheckExternalEvents(cs12, 0x76D);
    // MOV ES,word ptr [0x571a] (1935_0769 / 0x19AB9)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs12, 0x770);
    // MOV AX,word ptr [BP + 0xa] (1935_076D / 0x19ABD)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x774);
    // MOV ES:[0x39f6],AX (1935_0770 / 0x19AC0)
    UInt16[ES, 0x39F6] = AX;
    CheckExternalEvents(cs12, 0x778);
    // MOV ES,word ptr [0x571c] (1935_0774 / 0x19AC4)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs12, 0x77B);
    // MOV AX,word ptr [BP + 0xc] (1935_0778 / 0x19AC8)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs12, 0x77F);
    // MOV ES:[0x3ff2],AX (1935_077B / 0x19ACB)
    UInt16[ES, 0x3FF2] = AX;
    CheckExternalEvents(cs12, 0x783);
    // MOV ES,word ptr [0x571e] (1935_077F / 0x19ACF)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs12, 0x786);
    // MOV AX,word ptr [BP + 0xe] (1935_0783 / 0x19AD3)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs12, 0x78A);
    // MOV ES:[0x9c],AX (1935_0786 / 0x19AD6)
    UInt16[ES, 0x9C] = AX;
    CheckExternalEvents(cs12, 0x78F);
    // MOV word ptr [BP + -0x4],0x0 (1935_078A / 0x19ADA)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs12, 0x791);
    // JMP 0x1000:9b04 (1935_078F / 0x19ADF)
    goto label_1935_07B4_19B04;
    label_1935_0791_19AE1:
    CheckExternalEvents(cs12, 0x794);
    // MOV word ptr [BP + -0x2],SI (1935_0791 / 0x19AE1)
    UInt16[SS, (ushort)(BP - 0x2)] = SI;
    CheckExternalEvents(cs12, 0x798);
    // MOV ES,word ptr [0x571c] (1935_0794 / 0x19AE4)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs12, 0x79D);
    // PUSH word ptr ES:[0x3ff2] (1935_0798 / 0x19AE8)
    Stack.Push16(UInt16[ES, 0x3FF2]);
    CheckExternalEvents(cs12, 0x79F);
    // MOV AX,SI (1935_079D / 0x19AED)
    AX = SI;
    CheckExternalEvents(cs12, 0x7A3);
    // MOV ES,word ptr [0x571a] (1935_079F / 0x19AEF)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs12, 0x7A8);
    // SUB AX,word ptr ES:[0x39f6] (1935_07A3 / 0x19AF3)
    // AX -= UInt16[ES, 0x39F6];
    AX = Alu16.Sub(AX, UInt16[ES, 0x39F6]);
    CheckExternalEvents(cs12, 0x7A9);
    // PUSH AX (1935_07A8 / 0x19AF8)
    Stack.Push16(AX);
    CheckExternalEvents(cs12, 0x7AA);
    // PUSH SI (1935_07A9 / 0x19AF9)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x7AB);
    // PUSH CS (1935_07AA / 0x19AFA)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x7AE);
    // CALL 0x1000:9841 (1935_07AB / 0x19AFB)
    NearCall(cs12, 0x7AE, unknown_1935_04F1_19841);
    CheckExternalEvents(cs12, 0x7B1);
    // ADD SP,0x6 (1935_07AE / 0x19AFE)
    SP += 0x6;
    CheckExternalEvents(cs12, 0x7B4);
    // INC word ptr [BP + -0x4] (1935_07B1 / 0x19B01)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1935_07B4_19B04:
    CheckExternalEvents(cs12, 0x7B8);
    // MOV ES,word ptr [0x5716] (1935_07B4 / 0x19B04)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs12, 0x7BD);
    // MOV SI,word ptr ES:[0x398c] (1935_07B8 / 0x19B08)
    SI = UInt16[ES, 0x398C];
    CheckExternalEvents(cs12, 0x7C1);
    // MOV ES,word ptr [0x571e] (1935_07BD / 0x19B0D)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs12, 0x7C5);
    // MOV AX,ES:[0x9c] (1935_07C1 / 0x19B11)
    AX = UInt16[ES, 0x9C];
    CheckExternalEvents(cs12, 0x7C8);
    // IMUL word ptr [BP + -0x4] (1935_07C5 / 0x19B15)
    int resImul1935_07C5 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul1935_07C5);
    DX = (ushort)(resImul1935_07C5 >> 16);
    CheckExternalEvents(cs12, 0x7CA);
    // SUB SI,AX (1935_07C8 / 0x19B18)
    // SI -= AX;
    SI = Alu16.Sub(SI, AX);
    CheckExternalEvents(cs12, 0x7CE);
    // MOV ES,word ptr [0x5718] (1935_07CA / 0x19B1A)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs12, 0x7D3);
    // CMP word ptr ES:[0x39a2],SI (1935_07CE / 0x19B1E)
    Alu16.Sub(UInt16[ES, 0x39A2], SI);
    CheckExternalEvents(cs12, 0x7D5);
    // JL 0x1000:9ae1 (1935_07D3 / 0x19B23)
    if(SignFlag != OverflowFlag) {
      goto label_1935_0791_19AE1;
    }
    CheckExternalEvents(cs12, 0x7D6);
    // POP SI (1935_07D5 / 0x19B25)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x7D8);
    // MOV SP,BP (1935_07D6 / 0x19B26)
    SP = BP;
    CheckExternalEvents(cs12, 0x7D9);
    // POP BP (1935_07D8 / 0x19B28)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x7DA);
    // RETF  (1935_07D9 / 0x19B29)
    return FarRet();
  }
  
  public virtual Action unknown_1935_07DA_19B2A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1935_07DA_19B2A:
    CheckExternalEvents(cs12, 0x7DB);
    // PUSH BP (1935_07DA / 0x19B2A)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x7DD);
    // MOV BP,SP (1935_07DB / 0x19B2B)
    BP = SP;
    CheckExternalEvents(cs12, 0x7E0);
    // MOV AX,0x4 (1935_07DD / 0x19B2D)
    AX = 0x4;
    CheckExternalEvents(cs12, 0x7E5);
    // CALLF 0x1000:cecc (1935_07E0 / 0x19B30)
    FarCall(cs12, 0x7E5, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs12, 0x7E6);
    // PUSH SI (1935_07E5 / 0x19B35)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x7EA);
    // MOV ES,word ptr [0x5716] (1935_07E6 / 0x19B36)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs12, 0x7ED);
    // MOV AX,word ptr [BP + 0x6] (1935_07EA / 0x19B3A)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x7F1);
    // MOV ES:[0x398c],AX (1935_07ED / 0x19B3D)
    UInt16[ES, 0x398C] = AX;
    CheckExternalEvents(cs12, 0x7F5);
    // MOV ES,word ptr [0x5718] (1935_07F1 / 0x19B41)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs12, 0x7F8);
    // MOV AX,word ptr [BP + 0x8] (1935_07F5 / 0x19B45)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x7FC);
    // MOV ES:[0x39a2],AX (1935_07F8 / 0x19B48)
    UInt16[ES, 0x39A2] = AX;
    CheckExternalEvents(cs12, 0x800);
    // MOV ES,word ptr [0x571a] (1935_07FC / 0x19B4C)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs12, 0x803);
    // MOV AX,word ptr [BP + 0xa] (1935_0800 / 0x19B50)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x807);
    // MOV ES:[0x39f6],AX (1935_0803 / 0x19B53)
    UInt16[ES, 0x39F6] = AX;
    CheckExternalEvents(cs12, 0x80B);
    // MOV ES,word ptr [0x571c] (1935_0807 / 0x19B57)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs12, 0x80E);
    // MOV AX,word ptr [BP + 0xc] (1935_080B / 0x19B5B)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs12, 0x812);
    // MOV ES:[0x3ff2],AX (1935_080E / 0x19B5E)
    UInt16[ES, 0x3FF2] = AX;
    CheckExternalEvents(cs12, 0x816);
    // MOV ES,word ptr [0x571e] (1935_0812 / 0x19B62)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs12, 0x819);
    // MOV AX,word ptr [BP + 0xe] (1935_0816 / 0x19B66)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs12, 0x81D);
    // MOV ES:[0x9c],AX (1935_0819 / 0x19B69)
    UInt16[ES, 0x9C] = AX;
    CheckExternalEvents(cs12, 0x822);
    // MOV word ptr [BP + -0x4],0x0 (1935_081D / 0x19B6D)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs12, 0x824);
    // JMP 0x1000:9b97 (1935_0822 / 0x19B72)
    goto label_1935_0847_19B97;
    label_1935_0824_19B74:
    CheckExternalEvents(cs12, 0x827);
    // MOV word ptr [BP + -0x2],SI (1935_0824 / 0x19B74)
    UInt16[SS, (ushort)(BP - 0x2)] = SI;
    CheckExternalEvents(cs12, 0x82B);
    // MOV ES,word ptr [0x571c] (1935_0827 / 0x19B77)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs12, 0x830);
    // PUSH word ptr ES:[0x3ff2] (1935_082B / 0x19B7B)
    Stack.Push16(UInt16[ES, 0x3FF2]);
    CheckExternalEvents(cs12, 0x832);
    // MOV AX,SI (1935_0830 / 0x19B80)
    AX = SI;
    CheckExternalEvents(cs12, 0x836);
    // MOV ES,word ptr [0x571a] (1935_0832 / 0x19B82)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs12, 0x83B);
    // SUB AX,word ptr ES:[0x39f6] (1935_0836 / 0x19B86)
    // AX -= UInt16[ES, 0x39F6];
    AX = Alu16.Sub(AX, UInt16[ES, 0x39F6]);
    CheckExternalEvents(cs12, 0x83C);
    // PUSH AX (1935_083B / 0x19B8B)
    Stack.Push16(AX);
    CheckExternalEvents(cs12, 0x83D);
    // PUSH SI (1935_083C / 0x19B8C)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x83E);
    // PUSH CS (1935_083D / 0x19B8D)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x841);
    // CALL 0x1000:9841 (1935_083E / 0x19B8E)
    NearCall(cs12, 0x841, unknown_1935_04F1_19841);
    CheckExternalEvents(cs12, 0x844);
    // ADD SP,0x6 (1935_0841 / 0x19B91)
    SP += 0x6;
    CheckExternalEvents(cs12, 0x847);
    // INC word ptr [BP + -0x4] (1935_0844 / 0x19B94)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1935_0847_19B97:
    CheckExternalEvents(cs12, 0x84B);
    // MOV ES,word ptr [0x571e] (1935_0847 / 0x19B97)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs12, 0x84F);
    // MOV AX,ES:[0x9c] (1935_084B / 0x19B9B)
    AX = UInt16[ES, 0x9C];
    CheckExternalEvents(cs12, 0x852);
    // IMUL word ptr [BP + -0x4] (1935_084F / 0x19B9F)
    int resImul1935_084F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul1935_084F);
    DX = (ushort)(resImul1935_084F >> 16);
    CheckExternalEvents(cs12, 0x854);
    // MOV SI,AX (1935_0852 / 0x19BA2)
    SI = AX;
    CheckExternalEvents(cs12, 0x858);
    // MOV ES,word ptr [0x5716] (1935_0854 / 0x19BA4)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs12, 0x85D);
    // ADD SI,word ptr ES:[0x398c] (1935_0858 / 0x19BA8)
    // SI += UInt16[ES, 0x398C];
    SI = Alu16.Add(SI, UInt16[ES, 0x398C]);
    CheckExternalEvents(cs12, 0x861);
    // MOV ES,word ptr [0x5718] (1935_085D / 0x19BAD)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs12, 0x866);
    // CMP word ptr ES:[0x39a2],SI (1935_0861 / 0x19BB1)
    Alu16.Sub(UInt16[ES, 0x39A2], SI);
    CheckExternalEvents(cs12, 0x868);
    // JG 0x1000:9b74 (1935_0866 / 0x19BB6)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1935_0824_19B74;
    }
    CheckExternalEvents(cs12, 0x869);
    // POP SI (1935_0868 / 0x19BB8)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x86B);
    // MOV SP,BP (1935_0869 / 0x19BB9)
    SP = BP;
    CheckExternalEvents(cs12, 0x86C);
    // POP BP (1935_086B / 0x19BBB)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x86D);
    // RETF  (1935_086C / 0x19BBC)
    return FarRet();
  }
  
  public virtual Action interrupt_handler_0x8_19BB_0020_19BD0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0020_19BD0:
    CheckExternalEvents(cs13, 0x25);
    // CALLF [0x16] (19BB_0020 / 0x19BD0)
    // Indirect call to [0x16], generating possible targets from emulator records
    uint targetAddress_19BB_0020 = (uint)(UInt16[cs13, 0x18] * 0x10 + UInt16[cs13, 0x16] - cs1 * 0x10);
    switch(targetAddress_19BB_0020) {
      case 0x19E48 : FarCall(cs13, 0x25, unknown_19BB_0298_19E48); break;
      case 0x19D36 : FarCall(cs13, 0x25, unknown_19BB_0186_19D36); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_19BB_0020));
        break;
    }
    CheckExternalEvents(cs13, 0x26);
    // PUSH AX (19BB_0025 / 0x19BD5)
    Stack.Push16(AX);
    CheckExternalEvents(cs13, 0x2A);
    // MOV AX,CS:[0xe] (19BB_0026 / 0x19BD6)
    AX = UInt16[cs13, 0xE];
    CheckExternalEvents(cs13, 0x2C);
    // CMP AL,0x0 (19BB_002A / 0x19BDA)
    Alu8.Sub(AL, 0x0);
    CheckExternalEvents(cs13, 0x2E);
    // JNZ 0x1000:9bec (19BB_002C / 0x19BDC)
    if(!ZeroFlag) {
      goto label_19BB_003C_19BEC;
    }
    CheckExternalEvents(cs13, 0x32);
    // MOV AX,CS:[0x10] (19BB_002E / 0x19BDE)
    AX = UInt16[cs13, 0x10];
    CheckExternalEvents(cs13, 0x36);
    // MOV CS:[0xe],AX (19BB_0032 / 0x19BE2)
    UInt16[cs13, 0xE] = AX;
    CheckExternalEvents(cs13, 0x37);
    // POP AX (19BB_0036 / 0x19BE6)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x3C);
    // JMPF CS:[0x12] (19BB_0037 / 0x19BE7)
    // Indirect jump to CS:[0x12], generating possible targets from emulator records
    uint targetAddress_19BB_0037 = (uint)(UInt16[cs13, 0x14] * 0x10 + UInt16[cs13, 0x12] - cs1 * 0x10);
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
    CheckExternalEvents(cs13, 0x3E);
    // DEC AL (19BB_003C / 0x19BEC)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs13, 0x42);
    // MOV CS:[0xe],AX (19BB_003E / 0x19BEE)
    UInt16[cs13, 0xE] = AX;
    CheckExternalEvents(cs13, 0x44);
    // MOV AL,0x20 (19BB_0042 / 0x19BF2)
    AL = 0x20;
    CheckExternalEvents(cs13, 0x46);
    // OUT 0x20,AL (19BB_0044 / 0x19BF4)
    Cpu.Out8(0x20, AL);
    CheckExternalEvents(cs13, 0x47);
    // POP AX (19BB_0046 / 0x19BF6)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x48);
    // IRET  (19BB_0047 / 0x19BF7)
    return InterruptRet();
  }
  
  public virtual Action unknown_19BB_0048_19BF8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0048_19BF8:
    CheckExternalEvents(cs13, 0x49);
    // PUSH DS (19BB_0048 / 0x19BF8)
    Stack.Push16(DS);
    CheckExternalEvents(cs13, 0x4C);
    // MOV AX,0x0 (19BB_0049 / 0x19BF9)
    AX = 0x0;
    CheckExternalEvents(cs13, 0x4E);
    // MOV DS,AX (19BB_004C / 0x19BFC)
    DS = AX;
    CheckExternalEvents(cs13, 0x51);
    // MOV AX,[0x20] (19BB_004E / 0x19BFE)
    AX = UInt16[DS, 0x20];
    CheckExternalEvents(cs13, 0x55);
    // MOV CS:[0x12],AX (19BB_0051 / 0x19C01)
    UInt16[cs13, 0x12] = AX;
    CheckExternalEvents(cs13, 0x58);
    // MOV AX,[0x22] (19BB_0055 / 0x19C05)
    AX = UInt16[DS, 0x22];
    CheckExternalEvents(cs13, 0x5C);
    // MOV CS:[0x14],AX (19BB_0058 / 0x19C08)
    UInt16[cs13, 0x14] = AX;
    CheckExternalEvents(cs13, 0x63);
    // MOV word ptr CS:[0x10],0x10 (19BB_005C / 0x19C0C)
    UInt16[cs13, 0x10] = 0x10;
    CheckExternalEvents(cs13, 0x6A);
    // MOV word ptr CS:[0xe],0x0 (19BB_0063 / 0x19C13)
    UInt16[cs13, 0xE] = 0x0;
    CheckExternalEvents(cs13, 0x6D);
    // MOV AX,0x186 (19BB_006A / 0x19C1A)
    AX = 0x186;
    CheckExternalEvents(cs13, 0x71);
    // MOV CS:[0x16],AX (19BB_006D / 0x19C1D)
    UInt16[cs13, 0x16] = AX;
    CheckExternalEvents(cs13, 0x72);
    // PUSH CS (19BB_0071 / 0x19C21)
    Stack.Push16(cs13);
    CheckExternalEvents(cs13, 0x73);
    // POP AX (19BB_0072 / 0x19C22)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x77);
    // MOV CS:[0x18],AX (19BB_0073 / 0x19C23)
    UInt16[cs13, 0x18] = AX;
    CheckExternalEvents(cs13, 0x7A);
    // MOV DX,0x20 (19BB_0077 / 0x19C27)
    DX = 0x20;
    CheckExternalEvents(cs13, 0x7B);
    // PUSH CS (19BB_007A / 0x19C2A)
    Stack.Push16(cs13);
    CheckExternalEvents(cs13, 0x7C);
    // POP DS (19BB_007B / 0x19C2B)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x7E);
    // MOV AH,0x25 (19BB_007C / 0x19C2C)
    AH = 0x25;
    CheckExternalEvents(cs13, 0x80);
    // MOV AL,0x8 (19BB_007E / 0x19C2E)
    AL = 0x8;
    CheckExternalEvents(cs13, 0x82);
    // INT 0x21 (19BB_0080 / 0x19C30)
    Interrupt(0x21);
    CheckExternalEvents(cs13, 0x84);
    // MOV AL,0x36 (19BB_0082 / 0x19C32)
    AL = 0x36;
    CheckExternalEvents(cs13, 0x86);
    // OUT 0x43,AL (19BB_0084 / 0x19C34)
    Cpu.Out8(0x43, AL);
    CheckExternalEvents(cs13, 0x89);
    // MOV AX,0xfff (19BB_0086 / 0x19C36)
    AX = 0xFFF;
    CheckExternalEvents(cs13, 0x8B);
    // OUT 0x40,AL (19BB_0089 / 0x19C39)
    Cpu.Out8(0x40, AL);
    CheckExternalEvents(cs13, 0x8D);
    // MOV AL,AH (19BB_008B / 0x19C3B)
    AL = AH;
    CheckExternalEvents(cs13, 0x8F);
    // OUT 0x40,AL (19BB_008D / 0x19C3D)
    Cpu.Out8(0x40, AL);
    CheckExternalEvents(cs13, 0x90);
    // POP DS (19BB_008F / 0x19C3F)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x91);
    // RETF  (19BB_0090 / 0x19C40)
    return FarRet();
  }
  
  public virtual Action unknown_19BB_0091_19C41(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0091_19C41:
    CheckExternalEvents(cs13, 0x92);
    // PUSH DS (19BB_0091 / 0x19C41)
    Stack.Push16(DS);
    CheckExternalEvents(cs13, 0x97);
    // MOV DX,word ptr CS:[0x12] (19BB_0092 / 0x19C42)
    DX = UInt16[cs13, 0x12];
    CheckExternalEvents(cs13, 0x9B);
    // MOV AX,CS:[0x14] (19BB_0097 / 0x19C47)
    AX = UInt16[cs13, 0x14];
    CheckExternalEvents(cs13, 0x9C);
    // PUSH AX (19BB_009B / 0x19C4B)
    Stack.Push16(AX);
    CheckExternalEvents(cs13, 0x9D);
    // POP DS (19BB_009C / 0x19C4C)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x9F);
    // MOV AH,0x25 (19BB_009D / 0x19C4D)
    AH = 0x25;
    CheckExternalEvents(cs13, 0xA1);
    // MOV AL,0x8 (19BB_009F / 0x19C4F)
    AL = 0x8;
    CheckExternalEvents(cs13, 0xA3);
    // INT 0x21 (19BB_00A1 / 0x19C51)
    Interrupt(0x21);
    CheckExternalEvents(cs13, 0xA5);
    // MOV AL,0x36 (19BB_00A3 / 0x19C53)
    AL = 0x36;
    CheckExternalEvents(cs13, 0xA7);
    // OUT 0x43,AL (19BB_00A5 / 0x19C55)
    Cpu.Out8(0x43, AL);
    CheckExternalEvents(cs13, 0xAA);
    // MOV AX,0xffff (19BB_00A7 / 0x19C57)
    AX = 0xFFFF;
    CheckExternalEvents(cs13, 0xAC);
    // OUT 0x40,AL (19BB_00AA / 0x19C5A)
    Cpu.Out8(0x40, AL);
    CheckExternalEvents(cs13, 0xAE);
    // MOV AL,AH (19BB_00AC / 0x19C5C)
    AL = AH;
    CheckExternalEvents(cs13, 0xB0);
    // OUT 0x40,AL (19BB_00AE / 0x19C5E)
    Cpu.Out8(0x40, AL);
    CheckExternalEvents(cs13, 0xB1);
    // POP DS (19BB_00B0 / 0x19C60)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs13, 0xB2);
    // RETF  (19BB_00B1 / 0x19C61)
    return FarRet();
  }
  
  public virtual Action unknown_19BB_00B2_19C62(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_00B2_19C62:
    CheckExternalEvents(cs13, 0xB3);
    // PUSH AX (19BB_00B2 / 0x19C62)
    Stack.Push16(AX);
    CheckExternalEvents(cs13, 0xB5);
    // MOV AL,CL (19BB_00B3 / 0x19C63)
    AL = CL;
    CheckExternalEvents(cs13, 0xB7);
    // OUT 0x42,AL (19BB_00B5 / 0x19C65)
    Cpu.Out8(0x42, AL);
    CheckExternalEvents(cs13, 0xB9);
    // MOV AL,CH (19BB_00B7 / 0x19C67)
    AL = CH;
    CheckExternalEvents(cs13, 0xBB);
    // OUT 0x42,AL (19BB_00B9 / 0x19C69)
    Cpu.Out8(0x42, AL);
    CheckExternalEvents(cs13, 0xBC);
    // POP AX (19BB_00BB / 0x19C6B)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0xBD);
    // RET  (19BB_00BC / 0x19C6C)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_00BD_19C6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_00BD_19C6D:
    CheckExternalEvents(cs13, 0xBE);
    // PUSH AX (19BB_00BD / 0x19C6D)
    Stack.Push16(AX);
    CheckExternalEvents(cs13, 0xC0);
    // IN AL,0x61 (19BB_00BE / 0x19C6E)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs13, 0xC2);
    // OR AL,0x3 (19BB_00C0 / 0x19C70)
    // AL |= 0x3;
    AL = Alu8.Or(AL, 0x3);
    CheckExternalEvents(cs13, 0xC4);
    // OUT 0x61,AL (19BB_00C2 / 0x19C72)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs13, 0xC5);
    // POP AX (19BB_00C4 / 0x19C74)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0xC6);
    // RET  (19BB_00C5 / 0x19C75)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_00C6_19C76(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_00C6_19C76:
    CheckExternalEvents(cs13, 0xC7);
    // PUSH AX (19BB_00C6 / 0x19C76)
    Stack.Push16(AX);
    CheckExternalEvents(cs13, 0xC9);
    // IN AL,0x61 (19BB_00C7 / 0x19C77)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs13, 0xCB);
    // AND AL,0xfc (19BB_00C9 / 0x19C79)
    // AL &= 0xFC;
    AL = Alu8.And(AL, 0xFC);
    CheckExternalEvents(cs13, 0xCD);
    // OUT 0x61,AL (19BB_00CB / 0x19C7B)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs13, 0xCE);
    // POP AX (19BB_00CD / 0x19C7D)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0xCF);
    // RET  (19BB_00CE / 0x19C7E)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_00CF_19C7F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_00CF_19C7F:
    CheckExternalEvents(cs13, 0xD0);
    // PUSH DX (19BB_00CF / 0x19C7F)
    Stack.Push16(DX);
    CheckExternalEvents(cs13, 0xD1);
    // PUSH AX (19BB_00D0 / 0x19C80)
    Stack.Push16(AX);
    CheckExternalEvents(cs13, 0xD4);
    // MOV DX,0x12 (19BB_00D1 / 0x19C81)
    DX = 0x12;
    CheckExternalEvents(cs13, 0xD7);
    // MOV AX,0x34de (19BB_00D4 / 0x19C84)
    AX = 0x34DE;
    CheckExternalEvents(cs13, 0xD9);
    // DIV CX (19BB_00D7 / 0x19C87)
    uint op1Div19BB_00D7 = (uint)(DX << 16 | AX);
    ushort op2Div19BB_00D7 = CX;
    ushort? resDiv19BB_00D7 = Alu16.Div(op1Div19BB_00D7, op2Div19BB_00D7);
    if(resDiv19BB_00D7 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = resDiv19BB_00D7.Value;
    DX = (ushort)(op1Div19BB_00D7 % op2Div19BB_00D7);
    CheckExternalEvents(cs13, 0xDB);
    // MOV CX,AX (19BB_00D9 / 0x19C89)
    CX = AX;
    CheckExternalEvents(cs13, 0xDC);
    // POP AX (19BB_00DB / 0x19C8B)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0xDD);
    // POP DX (19BB_00DC / 0x19C8C)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0xDE);
    // RET  (19BB_00DD / 0x19C8D)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_0139_19CE9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0139_19CE9:
    CheckExternalEvents(cs13, 0x13A);
    // PUSH CX (19BB_0139 / 0x19CE9)
    Stack.Push16(CX);
    CheckExternalEvents(cs13, 0x13B);
    // PUSH BX (19BB_013A / 0x19CEA)
    Stack.Push16(BX);
    CheckExternalEvents(cs13, 0x13C);
    // PUSH AX (19BB_013B / 0x19CEB)
    Stack.Push16(AX);
    CheckExternalEvents(cs13, 0x13E);
    // MOV AH,0x0 (19BB_013C / 0x19CEC)
    AH = 0x0;
    CheckExternalEvents(cs13, 0x140);
    // MOV CL,0xc (19BB_013E / 0x19CEE)
    CL = 0xC;
    CheckExternalEvents(cs13, 0x142);
    // DIV CL (19BB_0140 / 0x19CF0)
    ushort op1Div19BB_0140 = (ushort)AX;
    byte op2Div19BB_0140 = CL;
    byte? resDiv19BB_0140 = Alu8.Div(op1Div19BB_0140, op2Div19BB_0140);
    if(resDiv19BB_0140 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AL = resDiv19BB_0140.Value;
    AH = (byte)(op1Div19BB_0140 % op2Div19BB_0140);
    CheckExternalEvents(cs13, 0x144);
    // MOV DL,AL (19BB_0142 / 0x19CF2)
    DL = AL;
    CheckExternalEvents(cs13, 0x146);
    // MOV AL,AH (19BB_0144 / 0x19CF4)
    AL = AH;
    CheckExternalEvents(cs13, 0x147);
    // CBW  (19BB_0146 / 0x19CF6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs13, 0x149);
    // SHL AX,0x1 (19BB_0147 / 0x19CF7)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs13, 0x14B);
    // MOV BX,AX (19BB_0149 / 0x19CF9)
    BX = AX;
    CheckExternalEvents(cs13, 0x150);
    // MOV CX,word ptr CS:[BX + 0x121] (19BB_014B / 0x19CFB)
    CX = UInt16[cs13, (ushort)(BX + 0x121)];
    CheckExternalEvents(cs13, 0x153);
    // CALL 0x1000:9c7f (19BB_0150 / 0x19D00)
    NearCall(cs13, 0x153, unknown_19BB_00CF_19C7F);
    CheckExternalEvents(cs13, 0x155);
    // XCHG DX,CX (19BB_0153 / 0x19D03)
    (CX, DX) = (DX, CX);
    CheckExternalEvents(cs13, 0x157);
    // NEG CL (19BB_0155 / 0x19D05)
    CL = Alu8.Sub(0, CL);
    CheckExternalEvents(cs13, 0x15A);
    // ADD CL,0x8 (19BB_0157 / 0x19D07)
    CL += 0x8;
    CheckExternalEvents(cs13, 0x15C);
    // SHL DX,CL (19BB_015A / 0x19D0A)
    // DX <<= CL;
    DX = Alu16.Shl(DX, CL);
    CheckExternalEvents(cs13, 0x15D);
    // POP AX (19BB_015C / 0x19D0C)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x15E);
    // POP BX (19BB_015D / 0x19D0D)
    BX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x15F);
    // POP CX (19BB_015E / 0x19D0E)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x160);
    // RET  (19BB_015F / 0x19D0F)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_0179_19D29(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0179_19D29:
    CheckExternalEvents(cs13, 0x17A);
    // PUSH AX (19BB_0179 / 0x19D29)
    Stack.Push16(AX);
    CheckExternalEvents(cs13, 0x17D);
    // MOV AX,0x186 (19BB_017A / 0x19D2A)
    AX = 0x186;
    CheckExternalEvents(cs13, 0x181);
    // MOV CS:[0x16],AX (19BB_017D / 0x19D2D)
    UInt16[cs13, 0x16] = AX;
    CheckExternalEvents(cs13, 0x184);
    // CALL 0x1000:9c76 (19BB_0181 / 0x19D31)
    NearCall(cs13, 0x184, unknown_19BB_00C6_19C76);
    CheckExternalEvents(cs13, 0x185);
    // POP AX (19BB_0184 / 0x19D34)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x186);
    // RET  (19BB_0185 / 0x19D35)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_0186_19D36(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0186_19D36:
    CheckExternalEvents(cs13, 0x187);
    // RETF  (19BB_0186 / 0x19D36)
    return FarRet();
  }
  
  public virtual Action unknown_19BB_0233_19DE3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0233_19DE3:
    CheckExternalEvents(cs13, 0x236);
    // MOV AX,word ptr [BP + 0x8] (19BB_0233 / 0x19DE3)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs13, 0x23A);
    // MOV CS:[0x205],AX (19BB_0236 / 0x19DE6)
    UInt16[cs13, 0x205] = AX;
    CheckExternalEvents(cs13, 0x23D);
    // MOV AX,word ptr [BP + 0xa] (19BB_023A / 0x19DEA)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs13, 0x241);
    // MOV CS:[0x207],AX (19BB_023D / 0x19DED)
    UInt16[cs13, 0x207] = AX;
    CheckExternalEvents(cs13, 0x244);
    // MOV AX,word ptr [BP + 0xc] (19BB_0241 / 0x19DF1)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs13, 0x248);
    // MOV CS:[0x20a],AL (19BB_0244 / 0x19DF4)
    UInt8[cs13, 0x20A] = AL;
    CheckExternalEvents(cs13, 0x24E);
    // MOV byte ptr CS:[0x209],0x1 (19BB_0248 / 0x19DF8)
    UInt8[cs13, 0x209] = 0x1;
    CheckExternalEvents(cs13, 0x24F);
    // RET  (19BB_024E / 0x19DFE)
    return NearRet();
  }
  
  public virtual Action unknown_19BB_0298_19E48(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0298_19E48:
    CheckExternalEvents(cs13, 0x29D);
    // DEC byte ptr CS:[0x209] (19BB_0298 / 0x19E48)
    UInt8[cs13, 0x209]--;
    CheckExternalEvents(cs13, 0x2A3);
    // CMP byte ptr CS:[0x209],0x0 (19BB_029D / 0x19E4D)
    Alu8.Sub(UInt8[cs13, 0x209], 0x0);
    CheckExternalEvents(cs13, 0x2A5);
    // JNZ 0x1000:9e8c (19BB_02A3 / 0x19E53)
    if(!ZeroFlag) {
      // JNZ target is RETF, inlining.
      CheckExternalEvents(cs13, 0x2DD);
      // RETF  (19BB_02DC / 0x19E8C)
      return FarRet();
    }
    CheckExternalEvents(cs13, 0x2A6);
    // PUSH AX (19BB_02A5 / 0x19E55)
    Stack.Push16(AX);
    CheckExternalEvents(cs13, 0x2AA);
    // MOV AL,CS:[0x20a] (19BB_02A6 / 0x19E56)
    AL = UInt8[cs13, 0x20A];
    CheckExternalEvents(cs13, 0x2AE);
    // MOV CS:[0x209],AL (19BB_02AA / 0x19E5A)
    UInt8[cs13, 0x209] = AL;
    CheckExternalEvents(cs13, 0x2AF);
    // PUSH DS (19BB_02AE / 0x19E5E)
    Stack.Push16(DS);
    CheckExternalEvents(cs13, 0x2B0);
    // PUSH SI (19BB_02AF / 0x19E5F)
    Stack.Push16(SI);
    CheckExternalEvents(cs13, 0x2B5);
    // LDS SI,CS:[0x205] (19BB_02B0 / 0x19E60)
    SI = UInt16[cs13, 0x205];
    DS = UInt16[cs13, 0x207];
    CheckExternalEvents(cs13, 0x2B6);
    // LODSB SI (19BB_02B5 / 0x19E65)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs13, 0x2B8);
    // CMP AL,0x0 (19BB_02B6 / 0x19E66)
    Alu8.Sub(AL, 0x0);
    CheckExternalEvents(cs13, 0x2BA);
    // JNZ 0x1000:9e6f (19BB_02B8 / 0x19E68)
    if(!ZeroFlag) {
      goto label_19BB_02BF_19E6F;
    }
    CheckExternalEvents(cs13, 0x2BB);
    // LODSB SI (19BB_02BA / 0x19E6A)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs13, 0x2BD);
    // CMP AL,0x0 (19BB_02BB / 0x19E6B)
    Alu8.Sub(AL, 0x0);
    CheckExternalEvents(cs13, 0x2BF);
    // JZ 0x1000:9e8d (19BB_02BD / 0x19E6D)
    if(ZeroFlag) {
      goto label_19BB_02DD_19E8D;
    }
    label_19BB_02BF_19E6F:
    CheckExternalEvents(cs13, 0x2C4);
    // MOV word ptr CS:[0x205],SI (19BB_02BF / 0x19E6F)
    UInt16[cs13, 0x205] = SI;
    CheckExternalEvents(cs13, 0x2C5);
    // POP SI (19BB_02C4 / 0x19E74)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x2C6);
    // POP DS (19BB_02C5 / 0x19E75)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x2C7);
    // PUSH DX (19BB_02C6 / 0x19E76)
    Stack.Push16(DX);
    CheckExternalEvents(cs13, 0x2C8);
    // PUSH CX (19BB_02C7 / 0x19E77)
    Stack.Push16(CX);
    CheckExternalEvents(cs13, 0x2CA);
    // TEST AL,0x80 (19BB_02C8 / 0x19E78)
    Alu8.And(AL, 0x80);
    CheckExternalEvents(cs13, 0x2CC);
    // JZ 0x1000:9e81 (19BB_02CA / 0x19E7A)
    if(ZeroFlag) {
      goto label_19BB_02D1_19E81;
    }
    CheckExternalEvents(cs13, 0x2CF);
    // MOV CX,0xe (19BB_02CC / 0x19E7C)
    CX = 0xE;
    CheckExternalEvents(cs13, 0x2D1);
    // JMP 0x1000:9e86 (19BB_02CF / 0x19E7F)
    goto label_19BB_02D6_19E86;
    label_19BB_02D1_19E81:
    CheckExternalEvents(cs13, 0x2D4);
    // CALL 0x1000:9ce9 (19BB_02D1 / 0x19E81)
    NearCall(cs13, 0x2D4, unknown_19BB_0139_19CE9);
    CheckExternalEvents(cs13, 0x2D6);
    // MOV CX,DX (19BB_02D4 / 0x19E84)
    CX = DX;
    label_19BB_02D6_19E86:
    CheckExternalEvents(cs13, 0x2D9);
    // CALL 0x1000:9c62 (19BB_02D6 / 0x19E86)
    NearCall(cs13, 0x2D9, unknown_19BB_00B2_19C62);
    CheckExternalEvents(cs13, 0x2DA);
    // POP CX (19BB_02D9 / 0x19E89)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x2DB);
    // POP DX (19BB_02DA / 0x19E8A)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x2DC);
    // POP AX (19BB_02DB / 0x19E8B)
    AX = Stack.Pop16();;
    label_19BB_02DC_19E8C:
    CheckExternalEvents(cs13, 0x2DD);
    // RETF  (19BB_02DC / 0x19E8C)
    return FarRet();
    label_19BB_02DD_19E8D:
    CheckExternalEvents(cs13, 0x2DE);
    // POP SI (19BB_02DD / 0x19E8D)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x2DF);
    // POP DS (19BB_02DE / 0x19E8E)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x2E0);
    // POP AX (19BB_02DF / 0x19E8F)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x2E3);
    // CALL 0x1000:9d29 (19BB_02E0 / 0x19E90)
    NearCall(cs13, 0x2E3, unknown_19BB_0179_19D29);
    CheckExternalEvents(cs13, 0x2E4);
    // RETF  (19BB_02E3 / 0x19E93)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9E94_19E94(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9E94_19E94:
    CheckExternalEvents(cs8, 0x9E95);
    // PUSH BP (1000_9E94 / 0x19E94)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x9E97);
    // MOV BP,SP (1000_9E95 / 0x19E95)
    BP = SP;
    CheckExternalEvents(cs8, 0x9E9A);
    // MOV BX,word ptr [BP + 0x6] (1000_9E97 / 0x19E97)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x9E9D);
    // CMP BX,0xd (1000_9E9A / 0x19E9A)
    Alu16.Sub(BX, 0xD);
    CheckExternalEvents(cs8, 0x9E9F);
    // JGE 0x1000:9eb4 (1000_9E9D / 0x19E9D)
    if(SignFlag == OverflowFlag) {
      goto label_1000_9EB4_19EB4;
    }
    CheckExternalEvents(cs8, 0x9EA1);
    // ADD BX,BX (1000_9E9F / 0x19E9F)
    BX += BX;
    CheckExternalEvents(cs8, 0x9EA3);
    // ADD BX,BX (1000_9EA1 / 0x19EA1)
    // BX += BX;
    BX = Alu16.Add(BX, BX);
    CheckExternalEvents(cs8, 0x9EA6);
    // CALL 0x1000:9c6d (1000_9EA3 / 0x19EA3)
    NearCall(cs8, 0x9EA6, unknown_19BB_00BD_19C6D);
    CheckExternalEvents(cs8, 0x9EAB);
    // CALL word ptr CS:[BX + 0x328] (1000_9EA6 / 0x19EA6)
    // Indirect call to word ptr CS:[BX + 0x328], generating possible targets from emulator records
    uint targetAddress_1000_9EA6 = (uint)(cs8 * 0x10 + UInt16[cs8, (ushort)(BX + 0x328)] - cs1 * 0x10);
    switch(targetAddress_1000_9EA6) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_9EA6));
        break;
    }
    CheckExternalEvents(cs8, 0x9EB0);
    // MOV AX,word ptr CS:[BX + 0x32a] (1000_9EAB / 0x19EAB)
    AX = UInt16[cs8, (ushort)(BX + 0x32A)];
    CheckExternalEvents(cs8, 0x9EB4);
    // MOV CS:[0x16],AX (1000_9EB0 / 0x19EB0)
    UInt16[cs8, 0x16] = AX;
    label_1000_9EB4_19EB4:
    CheckExternalEvents(cs8, 0x9EB5);
    // POP BP (1000_9EB4 / 0x19EB4)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x9EB6);
    // RETF  (1000_9EB5 / 0x19EB5)
    return FarRet();
  }
  
  public virtual Action unknown_19BB_0306_19EB6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_0306_19EB6:
    CheckExternalEvents(cs13, 0x307);
    // PUSH BP (19BB_0306 / 0x19EB6)
    Stack.Push16(BP);
    CheckExternalEvents(cs13, 0x309);
    // MOV BP,SP (19BB_0307 / 0x19EB7)
    BP = SP;
    CheckExternalEvents(cs13, 0x30C);
    // MOV BX,word ptr [BP + 0x6] (19BB_0309 / 0x19EB9)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs13, 0x30F);
    // CMP BX,0xd (19BB_030C / 0x19EBC)
    Alu16.Sub(BX, 0xD);
    CheckExternalEvents(cs13, 0x311);
    // JGE 0x1000:9ed6 (19BB_030F / 0x19EBF)
    if(SignFlag == OverflowFlag) {
      goto label_19BB_0326_19ED6;
    }
    CheckExternalEvents(cs13, 0x313);
    // ADD BX,BX (19BB_0311 / 0x19EC1)
    BX += BX;
    CheckExternalEvents(cs13, 0x315);
    // ADD BX,BX (19BB_0313 / 0x19EC3)
    // BX += BX;
    BX = Alu16.Add(BX, BX);
    CheckExternalEvents(cs13, 0x318);
    // CALL 0x1000:9c6d (19BB_0315 / 0x19EC5)
    NearCall(cs13, 0x318, unknown_19BB_00BD_19C6D);
    CheckExternalEvents(cs13, 0x31D);
    // CALL word ptr CS:[BX + 0x332] (19BB_0318 / 0x19EC8)
    // Indirect call to word ptr CS:[BX + 0x332], generating possible targets from emulator records
    uint targetAddress_19BB_0318 = (uint)(cs13 * 0x10 + UInt16[cs13, (ushort)(BX + 0x332)] - cs1 * 0x10);
    switch(targetAddress_19BB_0318) {
      case 0x19D29 : NearCall(cs13, 0x31D, unknown_19BB_0179_19D29); break;
      case 0x19DE3 : NearCall(cs13, 0x31D, unknown_19BB_0233_19DE3); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_19BB_0318));
        break;
    }
    CheckExternalEvents(cs13, 0x322);
    // MOV AX,word ptr CS:[BX + 0x334] (19BB_031D / 0x19ECD)
    AX = UInt16[cs13, (ushort)(BX + 0x334)];
    CheckExternalEvents(cs13, 0x326);
    // MOV CS:[0x16],AX (19BB_0322 / 0x19ED2)
    UInt16[cs13, 0x16] = AX;
    label_19BB_0326_19ED6:
    CheckExternalEvents(cs13, 0x327);
    // POP BP (19BB_0326 / 0x19ED6)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs13, 0x328);
    // RETF  (19BB_0327 / 0x19ED7)
    return FarRet();
  }
  
  public virtual Action unknown_19BB_033C_19EEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19BB_033C_19EEC:
    CheckExternalEvents(cs13, 0x340);
    // MOV AX,CS:[0x16] (19BB_033C / 0x19EEC)
    AX = UInt16[cs13, 0x16];
    CheckExternalEvents(cs13, 0x343);
    // XOR AX,0x186 (19BB_0340 / 0x19EF0)
    // AX ^= 0x186;
    AX = Alu16.Xor(AX, 0x186);
    CheckExternalEvents(cs13, 0x345);
    // JZ 0x1000:9ef8 (19BB_0343 / 0x19EF3)
    if(ZeroFlag) {
      goto label_19BB_0348_19EF8;
    }
    CheckExternalEvents(cs13, 0x347);
    // XOR AX,AX (19BB_0345 / 0x19EF5)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs13, 0x348);
    // RETF  (19BB_0347 / 0x19EF7)
    return FarRet();
    label_19BB_0348_19EF8:
    CheckExternalEvents(cs13, 0x34B);
    // MOV AX,0x1 (19BB_0348 / 0x19EF8)
    AX = 0x1;
    CheckExternalEvents(cs13, 0x34C);
    // RETF  (19BB_034B / 0x19EFB)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_001C_19F0C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_001C_19F0C:
    CheckExternalEvents(cs14, 0x1D);
    // PUSH BP (19EF_001C / 0x19F0C)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x1F);
    // MOV BP,SP (19EF_001D / 0x19F0D)
    BP = SP;
    CheckExternalEvents(cs14, 0x20);
    // PUSH DI (19EF_001F / 0x19F0F)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x21);
    // PUSH SI (19EF_0020 / 0x19F10)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x22);
    // PUSH DS (19EF_0021 / 0x19F11)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x25);
    // MOV AX,0x1ddc (19EF_0022 / 0x19F12)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x27);
    // MOV DS,AX (19EF_0025 / 0x19F15)
    DS = AX;
    CheckExternalEvents(cs14, 0x29);
    // MOV AL,0xb6 (19EF_0027 / 0x19F17)
    AL = 0xB6;
    CheckExternalEvents(cs14, 0x2B);
    // OUT 0x43,AL (19EF_0029 / 0x19F19)
    Cpu.Out8(0x43, AL);
    CheckExternalEvents(cs14, 0x2C);
    // POP DS (19EF_002B / 0x19F1B)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2D);
    // POP SI (19EF_002C / 0x19F1C)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2E);
    // POP DI (19EF_002D / 0x19F1D)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2F);
    // POP BP (19EF_002E / 0x19F1E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x30);
    // RETF  (19EF_002F / 0x19F1F)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9F20_19F20(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9F20_19F20:
    CheckExternalEvents(cs8, 0x9F21);
    // PUSH BP (1000_9F20 / 0x19F20)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x9F23);
    // MOV BP,SP (1000_9F21 / 0x19F21)
    BP = SP;
    CheckExternalEvents(cs8, 0x9F24);
    // PUSH DI (1000_9F23 / 0x19F23)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0x9F25);
    // PUSH SI (1000_9F24 / 0x19F24)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0x9F26);
    // PUSH DS (1000_9F25 / 0x19F25)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x9F29);
    // MOV AX,0x1ddc (1000_9F26 / 0x19F26)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0x9F2B);
    // MOV DS,AX (1000_9F29 / 0x19F29)
    DS = AX;
    CheckExternalEvents(cs8, 0x9F2E);
    // MOV BX,word ptr [BP + 0x6] (1000_9F2B / 0x19F2B)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x9F30);
    // MOV AX,BX (1000_9F2E / 0x19F2E)
    AX = BX;
    CheckExternalEvents(cs8, 0x9F32);
    // OUT 0x42,AL (1000_9F30 / 0x19F30)
    Cpu.Out8(0x42, AL);
    CheckExternalEvents(cs8, 0x9F34);
    // MOV AL,AH (1000_9F32 / 0x19F32)
    AL = AH;
    CheckExternalEvents(cs8, 0x9F36);
    // OUT 0x42,AL (1000_9F34 / 0x19F34)
    Cpu.Out8(0x42, AL);
    CheckExternalEvents(cs8, 0x9F38);
    // IN AL,0x61 (1000_9F36 / 0x19F36)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs8, 0x9F3A);
    // OR AL,0x3 (1000_9F38 / 0x19F38)
    // AL |= 0x3;
    AL = Alu8.Or(AL, 0x3);
    CheckExternalEvents(cs8, 0x9F3C);
    // OUT 0x61,AL (1000_9F3A / 0x19F3A)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs8, 0x9F3D);
    // POP DS (1000_9F3C / 0x19F3C)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x9F3E);
    // POP SI (1000_9F3D / 0x19F3D)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x9F3F);
    // POP DI (1000_9F3E / 0x19F3E)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x9F40);
    // POP BP (1000_9F3F / 0x19F3F)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x9F41);
    // RETF  (1000_9F40 / 0x19F40)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0051_19F41(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0051_19F41:
    CheckExternalEvents(cs14, 0x52);
    // PUSH BP (19EF_0051 / 0x19F41)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x54);
    // MOV BP,SP (19EF_0052 / 0x19F42)
    BP = SP;
    CheckExternalEvents(cs14, 0x55);
    // PUSH DI (19EF_0054 / 0x19F44)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x56);
    // PUSH SI (19EF_0055 / 0x19F45)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x57);
    // PUSH DS (19EF_0056 / 0x19F46)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x5A);
    // MOV AX,0x1ddc (19EF_0057 / 0x19F47)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x5C);
    // MOV DS,AX (19EF_005A / 0x19F4A)
    DS = AX;
    CheckExternalEvents(cs14, 0x5E);
    // IN AL,0x61 (19EF_005C / 0x19F4C)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs14, 0x60);
    // AND AL,0xfc (19EF_005E / 0x19F4E)
    // AL &= 0xFC;
    AL = Alu8.And(AL, 0xFC);
    CheckExternalEvents(cs14, 0x62);
    // OUT 0x61,AL (19EF_0060 / 0x19F50)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs14, 0x63);
    // POP DS (19EF_0062 / 0x19F52)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x64);
    // POP SI (19EF_0063 / 0x19F53)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x65);
    // POP DI (19EF_0064 / 0x19F54)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x66);
    // POP BP (19EF_0065 / 0x19F55)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x67);
    // RETF  (19EF_0066 / 0x19F56)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0067_19F57(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0067_19F57:
    CheckExternalEvents(cs14, 0x68);
    // PUSH BP (19EF_0067 / 0x19F57)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x6A);
    // MOV BP,SP (19EF_0068 / 0x19F58)
    BP = SP;
    CheckExternalEvents(cs14, 0x6B);
    // PUSH DI (19EF_006A / 0x19F5A)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x6C);
    // PUSH SI (19EF_006B / 0x19F5B)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x6D);
    // PUSH DS (19EF_006C / 0x19F5C)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x70);
    // MOV AX,0x1ddc (19EF_006D / 0x19F5D)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x72);
    // MOV DS,AX (19EF_0070 / 0x19F60)
    DS = AX;
    CheckExternalEvents(cs14, 0x74);
    // IN AL,0x61 (19EF_0072 / 0x19F62)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs14, 0x76);
    // AND AL,0xfc (19EF_0074 / 0x19F64)
    // AL &= 0xFC;
    AL = Alu8.And(AL, 0xFC);
    CheckExternalEvents(cs14, 0x78);
    // OUT 0x61,AL (19EF_0076 / 0x19F66)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs14, 0x79);
    // POP DS (19EF_0078 / 0x19F68)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x7A);
    // POP SI (19EF_0079 / 0x19F69)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x7B);
    // POP DI (19EF_007A / 0x19F6A)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x7C);
    // POP BP (19EF_007B / 0x19F6B)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x7D);
    // RETF  (19EF_007C / 0x19F6C)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_007D_19F6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_007D_19F6D:
    CheckExternalEvents(cs14, 0x7E);
    // PUSH BP (19EF_007D / 0x19F6D)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x80);
    // MOV BP,SP (19EF_007E / 0x19F6E)
    BP = SP;
    CheckExternalEvents(cs14, 0x81);
    // PUSH DI (19EF_0080 / 0x19F70)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x82);
    // PUSH SI (19EF_0081 / 0x19F71)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x83);
    // PUSH DS (19EF_0082 / 0x19F72)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x86);
    // MOV AX,0x1ddc (19EF_0083 / 0x19F73)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x88);
    // MOV DS,AX (19EF_0086 / 0x19F76)
    DS = AX;
    CheckExternalEvents(cs14, 0x8B);
    // MOV AX,word ptr [BP + 0x6] (19EF_0088 / 0x19F78)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x8E);
    // MOV [0x252],AX (19EF_008B / 0x19F7B)
    UInt16[DS, 0x252] = AX;
    CheckExternalEvents(cs14, 0x90);
    // IN AL,0x61 (19EF_008E / 0x19F7E)
    AL = Cpu.In8(0x61);
    CheckExternalEvents(cs14, 0x92);
    // XOR AL,0x2 (19EF_0090 / 0x19F80)
    // AL ^= 0x2;
    AL = Alu8.Xor(AL, 0x2);
    CheckExternalEvents(cs14, 0x94);
    // OUT 0x61,AL (19EF_0092 / 0x19F82)
    Cpu.Out8(0x61, AL);
    CheckExternalEvents(cs14, 0x98);
    // MOV DX,word ptr [0x252] (19EF_0094 / 0x19F84)
    DX = UInt16[DS, 0x252];
    CheckExternalEvents(cs14, 0x9C);
    // ADD DX,0x9248 (19EF_0098 / 0x19F88)
    // DX += 0x9248;
    DX = Alu16.Add(DX, 0x9248);
    CheckExternalEvents(cs14, 0x9E);
    // MOV CL,0x3 (19EF_009C / 0x19F8C)
    CL = 0x3;
    CheckExternalEvents(cs14, 0xA0);
    // ROR DX,CL (19EF_009E / 0x19F8E)
    DX = Alu16.Ror(DX, CL);
    CheckExternalEvents(cs14, 0xA4);
    // MOV word ptr [0x252],DX (19EF_00A0 / 0x19F90)
    UInt16[DS, 0x252] = DX;
    CheckExternalEvents(cs14, 0xA5);
    // POP DS (19EF_00A4 / 0x19F94)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xA6);
    // POP SI (19EF_00A5 / 0x19F95)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xA7);
    // POP DI (19EF_00A6 / 0x19F96)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xA8);
    // POP BP (19EF_00A7 / 0x19F97)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xA9);
    // RETF  (19EF_00A8 / 0x19F98)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_00A9_19F99(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_00A9_19F99:
    CheckExternalEvents(cs14, 0xAA);
    // PUSH BP (19EF_00A9 / 0x19F99)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0xAC);
    // MOV BP,SP (19EF_00AA / 0x19F9A)
    BP = SP;
    CheckExternalEvents(cs14, 0xAD);
    // PUSH DI (19EF_00AC / 0x19F9C)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0xAE);
    // PUSH SI (19EF_00AD / 0x19F9D)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0xAF);
    // PUSH DS (19EF_00AE / 0x19F9E)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xB2);
    // MOV AX,0x1ddc (19EF_00AF / 0x19F9F)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0xB4);
    // MOV DS,AX (19EF_00B2 / 0x19FA2)
    DS = AX;
    CheckExternalEvents(cs14, 0xB7);
    // MOV AX,word ptr [BP + 0x6] (19EF_00B4 / 0x19FA4)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0xBA);
    // MOV [0x254],AX (19EF_00B7 / 0x19FA7)
    UInt16[DS, 0x254] = AX;
    CheckExternalEvents(cs14, 0xBD);
    // MOV AX,word ptr [BP + 0x8] (19EF_00BA / 0x19FAA)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0xC0);
    // MOV [0x256],AX (19EF_00BD / 0x19FAD)
    UInt16[DS, 0x256] = AX;
    CheckExternalEvents(cs14, 0xC2);
    // MOV CX,DX (19EF_00C0 / 0x19FB0)
    CX = DX;
    CheckExternalEvents(cs14, 0xC6);
    // AND CX,word ptr [0x254] (19EF_00C2 / 0x19FB2)
    // CX &= UInt16[DS, 0x254];
    CX = Alu16.And(CX, UInt16[DS, 0x254]);
    CheckExternalEvents(cs14, 0xCA);
    // OR CX,word ptr [0x256] (19EF_00C6 / 0x19FB6)
    // CX |= UInt16[DS, 0x256];
    CX = Alu16.Or(CX, UInt16[DS, 0x256]);
    label_19EF_00CA_19FBA:
    CheckExternalEvents(cs14, 0xCC);
    // LOOP 0x1000:9fba (19EF_00CA / 0x19FBA)
    if(--CX != 0) {
      goto label_19EF_00CA_19FBA;
    }
    CheckExternalEvents(cs14, 0xCD);
    // POP DS (19EF_00CC / 0x19FBC)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xCE);
    // POP SI (19EF_00CD / 0x19FBD)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xCF);
    // POP DI (19EF_00CE / 0x19FBE)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xD0);
    // POP BP (19EF_00CF / 0x19FBF)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0xD1);
    // RETF  (19EF_00D0 / 0x19FC0)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_00D1_19FC1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_00D1_19FC1:
    CheckExternalEvents(cs14, 0xD2);
    // PUSH BP (19EF_00D1 / 0x19FC1)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0xD4);
    // MOV BP,SP (19EF_00D2 / 0x19FC2)
    BP = SP;
    CheckExternalEvents(cs14, 0xD5);
    // PUSH DI (19EF_00D4 / 0x19FC4)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0xD6);
    // PUSH SI (19EF_00D5 / 0x19FC5)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0xD7);
    // PUSH DS (19EF_00D6 / 0x19FC6)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0xDA);
    // MOV AX,0x1ddc (19EF_00D7 / 0x19FC7)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0xDC);
    // MOV DS,AX (19EF_00DA / 0x19FCA)
    DS = AX;
    CheckExternalEvents(cs14, 0xE1);
    // CMP word ptr [0xb764],0x0 (19EF_00DC / 0x19FCC)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0xE3);
    // JNZ 0x1000:a037 (19EF_00E1 / 0x19FD1)
    if(!ZeroFlag) {
      goto label_19EF_0147_1A037;
    }
    CheckExternalEvents(cs14, 0xE6);
    // MOV AX,word ptr [BP + 0x6] (19EF_00E3 / 0x19FD3)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0xE8);
    // MOV SI,AX (19EF_00E6 / 0x19FD6)
    SI = AX;
    CheckExternalEvents(cs14, 0xEB);
    // MOV AX,word ptr [BP + 0x8] (19EF_00E8 / 0x19FD8)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0xEC);
    // PUSH ES (19EF_00EB / 0x19FDB)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0xEE);
    // MOV ES,AX (19EF_00EC / 0x19FDC)
    ES = AX;
    CheckExternalEvents(cs14, 0xF1);
    // MOV DI,0x200 (19EF_00EE / 0x19FDE)
    DI = 0x200;
    CheckExternalEvents(cs14, 0xF4);
    // MOV CX,0x20 (19EF_00F1 / 0x19FE1)
    CX = 0x20;
    label_19EF_00F4_19FE4:
    CheckExternalEvents(cs14, 0xF7);
    // MOV AL,byte ptr ES:[SI] (19EF_00F4 / 0x19FE4)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs14, 0xF9);
    // MOV byte ptr [DI],AL (19EF_00F7 / 0x19FE7)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0xFA);
    // INC SI (19EF_00F9 / 0x19FE9)
    SI++;
    CheckExternalEvents(cs14, 0xFB);
    // INC DI (19EF_00FA / 0x19FEA)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs14, 0xFD);
    // LOOP 0x1000:9fe4 (19EF_00FB / 0x19FEB)
    if(--CX != 0) {
      goto label_19EF_00F4_19FE4;
    }
    CheckExternalEvents(cs14, 0x100);
    // MOV SI,0x0 (19EF_00FD / 0x19FED)
    SI = 0x0;
    CheckExternalEvents(cs14, 0x103);
    // MOV DI,0x100 (19EF_0100 / 0x19FF0)
    DI = 0x100;
    CheckExternalEvents(cs14, 0x105);
    // XOR CL,CL (19EF_0103 / 0x19FF3)
    CL = 0;
    CheckExternalEvents(cs14, 0x107);
    // XOR DX,DX (19EF_0105 / 0x19FF5)
    DX = 0;
    label_19EF_0107_19FF7:
    CheckExternalEvents(cs14, 0x109);
    // XOR AH,AH (19EF_0107 / 0x19FF7)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs14, 0x10B);
    // MOV AL,CL (19EF_0109 / 0x19FF9)
    AL = CL;
    CheckExternalEvents(cs14, 0x10D);
    // SHR AL,0x1 (19EF_010B / 0x19FFB)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x10F);
    // SHR AL,0x1 (19EF_010D / 0x19FFD)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x111);
    // SHR AL,0x1 (19EF_010F / 0x19FFF)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x113);
    // SHR AL,0x1 (19EF_0111 / 0x1A001)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0x115);
    // MOV DL,AL (19EF_0113 / 0x1A003)
    DL = AL;
    CheckExternalEvents(cs14, 0x117);
    // MOV AL,CL (19EF_0115 / 0x1A005)
    AL = CL;
    CheckExternalEvents(cs14, 0x119);
    // AND AL,0xf (19EF_0117 / 0x1A007)
    // AL &= 0xF;
    AL = Alu8.And(AL, 0xF);
    CheckExternalEvents(cs14, 0x11C);
    // MOV BX,0x200 (19EF_0119 / 0x1A009)
    BX = 0x200;
    CheckExternalEvents(cs14, 0x11E);
    // ADD BX,DX (19EF_011C / 0x1A00C)
    // BX += DX;
    BX = Alu16.Add(BX, DX);
    CheckExternalEvents(cs14, 0x120);
    // MOV CH,byte ptr [BX] (19EF_011E / 0x1A00E)
    CH = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs14, 0x122);
    // SUB BX,DX (19EF_0120 / 0x1A010)
    BX -= DX;
    CheckExternalEvents(cs14, 0x124);
    // SHL CH,0x1 (19EF_0122 / 0x1A012)
    CH <<= 0x1;
    CheckExternalEvents(cs14, 0x126);
    // SHL CH,0x1 (19EF_0124 / 0x1A014)
    CH <<= 0x1;
    CheckExternalEvents(cs14, 0x128);
    // ADD BX,AX (19EF_0126 / 0x1A016)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs14, 0x12B);
    // OR CH,byte ptr [BX + 0x10] (19EF_0128 / 0x1A018)
    CH |= UInt8[DS, (ushort)(BX + 0x10)];
    CheckExternalEvents(cs14, 0x12D);
    // SUB BX,AX (19EF_012B / 0x1A01B)
    // BX -= AX;
    BX = Alu16.Sub(BX, AX);
    CheckExternalEvents(cs14, 0x12F);
    // MOV byte ptr [SI],CH (19EF_012D / 0x1A01D)
    UInt8[DS, (ushort)(SI)] = CH;
    CheckExternalEvents(cs14, 0x130);
    // INC SI (19EF_012F / 0x1A01F)
    SI++;
    CheckExternalEvents(cs14, 0x132);
    // ADD BX,DX (19EF_0130 / 0x1A020)
    // BX += DX;
    BX = Alu16.Add(BX, DX);
    CheckExternalEvents(cs14, 0x135);
    // MOV CH,byte ptr [BX + 0x10] (19EF_0132 / 0x1A022)
    CH = UInt8[DS, (ushort)(BX + 0x10)];
    CheckExternalEvents(cs14, 0x137);
    // SUB BX,DX (19EF_0135 / 0x1A025)
    BX -= DX;
    CheckExternalEvents(cs14, 0x139);
    // SHL CH,0x1 (19EF_0137 / 0x1A027)
    CH <<= 0x1;
    CheckExternalEvents(cs14, 0x13B);
    // SHL CH,0x1 (19EF_0139 / 0x1A029)
    CH <<= 0x1;
    CheckExternalEvents(cs14, 0x13D);
    // ADD BX,AX (19EF_013B / 0x1A02B)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs14, 0x13F);
    // OR CH,byte ptr [BX] (19EF_013D / 0x1A02D)
    // CH |= UInt8[DS, (ushort)(BX)];
    CH = Alu8.Or(CH, UInt8[DS, (ushort)(BX)]);
    CheckExternalEvents(cs14, 0x141);
    // MOV byte ptr [DI],CH (19EF_013F / 0x1A02F)
    UInt8[DS, (ushort)(DI)] = CH;
    CheckExternalEvents(cs14, 0x142);
    // INC DI (19EF_0141 / 0x1A031)
    DI++;
    CheckExternalEvents(cs14, 0x144);
    // INC CL (19EF_0142 / 0x1A032)
    CL = Alu8.Inc(CL);
    CheckExternalEvents(cs14, 0x146);
    // JNZ 0x1000:9ff7 (19EF_0144 / 0x1A034)
    if(!ZeroFlag) {
      goto label_19EF_0107_19FF7;
    }
    CheckExternalEvents(cs14, 0x147);
    // POP ES (19EF_0146 / 0x1A036)
    ES = Stack.Pop16();;
    label_19EF_0147_1A037:
    CheckExternalEvents(cs14, 0x148);
    // POP DS (19EF_0147 / 0x1A037)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x149);
    // POP SI (19EF_0148 / 0x1A038)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x14A);
    // POP DI (19EF_0149 / 0x1A039)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x14B);
    // POP BP (19EF_014A / 0x1A03A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x14C);
    // RETF  (19EF_014B / 0x1A03B)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A03C_1A03C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A03C_1A03C:
    CheckExternalEvents(cs8, 0xA03D);
    // PUSH BP (1000_A03C / 0x1A03C)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xA03F);
    // MOV BP,SP (1000_A03D / 0x1A03D)
    BP = SP;
    CheckExternalEvents(cs8, 0xA040);
    // PUSH DI (1000_A03F / 0x1A03F)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xA041);
    // PUSH SI (1000_A040 / 0x1A040)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xA042);
    // PUSH DS (1000_A041 / 0x1A041)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xA045);
    // MOV AX,0x1ddc (1000_A042 / 0x1A042)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xA047);
    // MOV DS,AX (1000_A045 / 0x1A045)
    DS = AX;
    CheckExternalEvents(cs8, 0xA04A);
    // MOV DX,word ptr [BP + 0x6] (1000_A047 / 0x1A047)
    DX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xA04C);
    // MOV AH,0xe (1000_A04A / 0x1A04A)
    AH = 0xE;
    CheckExternalEvents(cs8, 0xA04E);
    // INT 0x21 (1000_A04C / 0x1A04C)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xA04F);
    // POP DS (1000_A04E / 0x1A04E)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA050);
    // POP SI (1000_A04F / 0x1A04F)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA051);
    // POP DI (1000_A050 / 0x1A050)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA052);
    // POP BP (1000_A051 / 0x1A051)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA053);
    // RETF  (1000_A052 / 0x1A052)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A053_1A053(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A053_1A053:
    CheckExternalEvents(cs8, 0xA054);
    // PUSH BP (1000_A053 / 0x1A053)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xA056);
    // MOV BP,SP (1000_A054 / 0x1A054)
    BP = SP;
    CheckExternalEvents(cs8, 0xA057);
    // PUSH DI (1000_A056 / 0x1A056)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xA058);
    // PUSH SI (1000_A057 / 0x1A057)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xA059);
    // PUSH DS (1000_A058 / 0x1A058)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xA05C);
    // MOV AX,0x1ddc (1000_A059 / 0x1A059)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xA05E);
    // MOV DS,AX (1000_A05C / 0x1A05C)
    DS = AX;
    CheckExternalEvents(cs8, 0xA061);
    // MOV AX,word ptr [BP + 0x6] (1000_A05E / 0x1A05E)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xA063);
    // MOV SI,AX (1000_A061 / 0x1A061)
    SI = AX;
    CheckExternalEvents(cs8, 0xA066);
    // MOV AX,word ptr [BP + 0x8] (1000_A063 / 0x1A063)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0xA069);
    // MOV [0xb78c],AX (1000_A066 / 0x1A066)
    UInt16[DS, 0xB78C] = AX;
    CheckExternalEvents(cs8, 0xA06C);
    // MOV AX,word ptr [BP + 0xa] (1000_A069 / 0x1A069)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0xA06E);
    // MOV DI,AX (1000_A06C / 0x1A06C)
    DI = AX;
    CheckExternalEvents(cs8, 0xA071);
    // MOV AX,word ptr [BP + 0xc] (1000_A06E / 0x1A06E)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0xA074);
    // MOV [0xb790],AX (1000_A071 / 0x1A071)
    UInt16[DS, 0xB790] = AX;
    CheckExternalEvents(cs8, 0xA077);
    // MOV DX,word ptr [BP + 0xe] (1000_A074 / 0x1A074)
    DX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs8, 0xA07B);
    // MOV byte ptr [0xb763],DL (1000_A077 / 0x1A077)
    UInt8[DS, 0xB763] = DL;
    CheckExternalEvents(cs8, 0xA07E);
    // MOV CX,word ptr [BP + 0x10] (1000_A07B / 0x1A07B)
    CX = UInt16[SS, (ushort)(BP + 0x10)];
    CheckExternalEvents(cs8, 0xA082);
    // MOV DX,word ptr [0xb790] (1000_A07E / 0x1A07E)
    DX = UInt16[DS, 0xB790];
    CheckExternalEvents(cs8, 0xA083);
    // PUSH ES (1000_A082 / 0x1A082)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xA084);
    // PUSH BP (1000_A083 / 0x1A083)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xA086);
    // MOV BP,DX (1000_A084 / 0x1A084)
    BP = DX;
    CheckExternalEvents(cs8, 0xA088);
    // XOR DH,DH (1000_A086 / 0x1A086)
    // DH ^= DH;
    DH = Alu8.Xor(DH, DH);
    label_1000_A088_1A088:
    CheckExternalEvents(cs8, 0xA08B);
    // MOV BX,0x0 (1000_A088 / 0x1A088)
    BX = 0x0;
    label_1000_A08B_1A08B:
    CheckExternalEvents(cs8, 0xA08F);
    // MOV DL,byte ptr [0xb763] (1000_A08B / 0x1A08B)
    DL = UInt8[DS, 0xB763];
    label_1000_A08F_1A08F:
    CheckExternalEvents(cs8, 0xA092);
    // MOV AX,[0xb78c] (1000_A08F / 0x1A08F)
    AX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs8, 0xA094);
    // MOV ES,AX (1000_A092 / 0x1A092)
    ES = AX;
    CheckExternalEvents(cs8, 0xA097);
    // MOV AL,byte ptr ES:[SI] (1000_A094 / 0x1A094)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xA098);
    // INC SI (1000_A097 / 0x1A097)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xA099);
    // XLAT BX (1000_A098 / 0x1A098)
    AL = UInt8[DS, (ushort)(BX + AL)];
    CheckExternalEvents(cs8, 0xA09B);
    // SHL AL,0x1 (1000_A099 / 0x1A099)
    AL <<= 0x1;
    CheckExternalEvents(cs8, 0xA09D);
    // SHL AL,0x1 (1000_A09B / 0x1A09B)
    AL <<= 0x1;
    CheckExternalEvents(cs8, 0xA09F);
    // SHL AL,0x1 (1000_A09D / 0x1A09D)
    AL <<= 0x1;
    CheckExternalEvents(cs8, 0xA0A1);
    // SHL AL,0x1 (1000_A09F / 0x1A09F)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs8, 0xA0A3);
    // MOV AH,AL (1000_A0A1 / 0x1A0A1)
    AH = AL;
    CheckExternalEvents(cs8, 0xA0A6);
    // MOV AL,byte ptr ES:[SI] (1000_A0A3 / 0x1A0A3)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xA0A7);
    // XLAT BX (1000_A0A6 / 0x1A0A6)
    AL = UInt8[DS, (ushort)(BX + AL)];
    CheckExternalEvents(cs8, 0xA0A8);
    // INC SI (1000_A0A7 / 0x1A0A7)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xA0AA);
    // OR AL,AH (1000_A0A8 / 0x1A0A8)
    // AL |= AH;
    AL = Alu8.Or(AL, AH);
    CheckExternalEvents(cs8, 0xA0AC);
    // MOV ES,BP (1000_A0AA / 0x1A0AA)
    ES = BP;
    CheckExternalEvents(cs8, 0xA0AD);
    // STOSB ES:DI (1000_A0AC / 0x1A0AC)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xA0AF);
    // DEC DL (1000_A0AD / 0x1A0AD)
    DL = Alu8.Dec(DL);
    CheckExternalEvents(cs8, 0xA0B1);
    // JZ 0x1000:a0b6 (1000_A0AF / 0x1A0AF)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A0B6_1A0B6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xA0B3);
    // LOOP 0x1000:a08f (1000_A0B1 / 0x1A0B1)
    if(--CX != 0) {
      goto label_1000_A08F_1A08F;
    }
    CheckExternalEvents(cs8, 0xA0B5);
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
    CheckExternalEvents(cs8, 0xA0B9);
    // XOR DH,0x1 (1000_A0B6 / 0x1A0B6)
    // DH ^= 0x1;
    DH = Alu8.Xor(DH, 0x1);
    CheckExternalEvents(cs8, 0xA0BB);
    // JZ 0x1000:a088 (1000_A0B9 / 0x1A0B9)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A053_1A053, 0x1A088 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xA0BE);
    // MOV BX,0x100 (1000_A0BB / 0x1A0BB)
    BX = 0x100;
    CheckExternalEvents(cs8, 0xA0C0);
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
    CheckExternalEvents(cs8, 0xA0C1);
    // POP BP (1000_A0C0 / 0x1A0C0)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA0C2);
    // POP ES (1000_A0C1 / 0x1A0C1)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA0C3);
    // POP DS (1000_A0C2 / 0x1A0C2)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA0C4);
    // POP SI (1000_A0C3 / 0x1A0C3)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA0C5);
    // POP DI (1000_A0C4 / 0x1A0C4)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA0C6);
    // POP BP (1000_A0C5 / 0x1A0C5)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA0C7);
    // RETF  (1000_A0C6 / 0x1A0C6)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_A0C7_1A0C7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A0C7_1A0C7:
    CheckExternalEvents(cs8, 0xA0C8);
    // PUSH BP (1000_A0C7 / 0x1A0C7)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xA0CA);
    // MOV BP,SP (1000_A0C8 / 0x1A0C8)
    BP = SP;
    CheckExternalEvents(cs8, 0xA0CB);
    // PUSH DI (1000_A0CA / 0x1A0CA)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xA0CC);
    // PUSH SI (1000_A0CB / 0x1A0CB)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xA0CD);
    // PUSH DS (1000_A0CC / 0x1A0CC)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xA0D0);
    // MOV AX,0x1ddc (1000_A0CD / 0x1A0CD)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xA0D2);
    // MOV DS,AX (1000_A0D0 / 0x1A0D0)
    DS = AX;
    CheckExternalEvents(cs8, 0xA0D5);
    // MOV BX,word ptr [BP + 0x6] (1000_A0D2 / 0x1A0D2)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xA0D7);
    // MOV SI,BX (1000_A0D5 / 0x1A0D5)
    SI = BX;
    CheckExternalEvents(cs8, 0xA0D9);
    // MOV DI,BX (1000_A0D7 / 0x1A0D7)
    DI = BX;
    CheckExternalEvents(cs8, 0xA0DC);
    // MOV AX,word ptr [BP + 0x8] (1000_A0D9 / 0x1A0D9)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0xA0DD);
    // PUSH ES (1000_A0DC / 0x1A0DC)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xA0DE);
    // PUSH DS (1000_A0DD / 0x1A0DD)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xA0E0);
    // MOV ES,AX (1000_A0DE / 0x1A0DE)
    ES = AX;
    CheckExternalEvents(cs8, 0xA0E2);
    // MOV DS,AX (1000_A0E0 / 0x1A0E0)
    DS = AX;
    CheckExternalEvents(cs8, 0xA0E6);
    // ADD SI,0x3e40 (1000_A0E2 / 0x1A0E2)
    SI += 0x3E40;
    CheckExternalEvents(cs8, 0xA0EA);
    // ADD DI,0x7c80 (1000_A0E6 / 0x1A0E6)
    // DI += 0x7C80;
    DI = Alu16.Add(DI, 0x7C80);
    CheckExternalEvents(cs8, 0xA0EB);
    // CLD  (1000_A0EA / 0x1A0EA)
    DirectionFlag = false;
    label_1000_A0EB_1A0EB:
    CheckExternalEvents(cs8, 0xA0EE);
    // MOV CX,0x20 (1000_A0EB / 0x1A0EB)
    CX = 0x20;
    CheckExternalEvents(cs8, 0xA0F0);
    // REP
    while (CX != 0) {
      CX--;
      // MOVSW ES:DI,SI (1000_A0EE / 0x1A0EE)
      UInt16[ES, (ushort)(DI)] = UInt16[DS, (ushort)(SI)];
      SI = (ushort)(SI + Direction16);
      DI = (ushort)(DI + Direction16);
    }
    CheckExternalEvents(cs8, 0xA0F4);
    // SUB SI,0x80 (1000_A0F0 / 0x1A0F0)
    SI -= 0x80;
    CheckExternalEvents(cs8, 0xA0F8);
    // SUB DI,0xc0 (1000_A0F4 / 0x1A0F4)
    DI -= 0xC0;
    CheckExternalEvents(cs8, 0xA0FA);
    // CMP DI,BX (1000_A0F8 / 0x1A0F8)
    Alu16.Sub(DI, BX);
    CheckExternalEvents(cs8, 0xA0FC);
    // JNZ 0x1000:a0eb (1000_A0FA / 0x1A0FA)
    if(!ZeroFlag) {
      goto label_1000_A0EB_1A0EB;
    }
    CheckExternalEvents(cs8, 0xA0FD);
    // POP DS (1000_A0FC / 0x1A0FC)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA0FE);
    // POP ES (1000_A0FD / 0x1A0FD)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA0FF);
    // POP DS (1000_A0FE / 0x1A0FE)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA100);
    // POP SI (1000_A0FF / 0x1A0FF)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA101);
    // POP DI (1000_A100 / 0x1A100)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA102);
    // POP BP (1000_A101 / 0x1A101)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA103);
    // RETF  (1000_A102 / 0x1A102)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0213_1A103(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0213_1A103:
    CheckExternalEvents(cs14, 0x214);
    // PUSH BP (19EF_0213 / 0x1A103)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x216);
    // MOV BP,SP (19EF_0214 / 0x1A104)
    BP = SP;
    CheckExternalEvents(cs14, 0x217);
    // PUSH DI (19EF_0216 / 0x1A106)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x218);
    // PUSH SI (19EF_0217 / 0x1A107)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x219);
    // PUSH DS (19EF_0218 / 0x1A108)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x21C);
    // MOV AX,0x1ddc (19EF_0219 / 0x1A109)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x21E);
    // MOV DS,AX (19EF_021C / 0x1A10C)
    DS = AX;
    CheckExternalEvents(cs14, 0x221);
    // MOV DL,byte ptr [BP + 0x6] (19EF_021E / 0x1A10E)
    DL = UInt8[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x223);
    // MOV AH,0x6 (19EF_0221 / 0x1A111)
    AH = 0x6;
    CheckExternalEvents(cs14, 0x225);
    // INT 0x21 (19EF_0223 / 0x1A113)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x226);
    // POP DS (19EF_0225 / 0x1A115)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x227);
    // POP SI (19EF_0226 / 0x1A116)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x228);
    // POP DI (19EF_0227 / 0x1A117)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x229);
    // POP BP (19EF_0228 / 0x1A118)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x22A);
    // RETF  (19EF_0229 / 0x1A119)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_022A_1A11A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_022A_1A11A:
    CheckExternalEvents(cs14, 0x22B);
    // PUSH BP (19EF_022A / 0x1A11A)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x22D);
    // MOV BP,SP (19EF_022B / 0x1A11B)
    BP = SP;
    CheckExternalEvents(cs14, 0x22E);
    // PUSH DI (19EF_022D / 0x1A11D)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x22F);
    // PUSH SI (19EF_022E / 0x1A11E)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x230);
    // PUSH DS (19EF_022F / 0x1A11F)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x233);
    // MOV AX,0x1ddc (19EF_0230 / 0x1A120)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x235);
    // MOV DS,AX (19EF_0233 / 0x1A123)
    DS = AX;
    CheckExternalEvents(cs14, 0x238);
    // MOV BX,word ptr [BP + 0x6] (19EF_0235 / 0x1A125)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x23B);
    // MOV CX,word ptr [BP + 0x8] (19EF_0238 / 0x1A128)
    CX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x23E);
    // MOV AX,0x40 (19EF_023B / 0x1A12B)
    AX = 0x40;
    CheckExternalEvents(cs14, 0x240);
    // MOV ES,AX (19EF_023E / 0x1A12E)
    ES = AX;
    CheckExternalEvents(cs14, 0x245);
    // MOV DX,word ptr ES:[0x63] (19EF_0240 / 0x1A130)
    DX = UInt16[ES, 0x63];
    CheckExternalEvents(cs14, 0x248);
    // ADD DL,0x6 (19EF_0245 / 0x1A135)
    // DL += 0x6;
    DL = Alu8.Add(DL, 0x6);
    CheckExternalEvents(cs14, 0x249);
    // PUSH DX (19EF_0248 / 0x1A138)
    Stack.Push16(DX);
    CheckExternalEvents(cs14, 0x24A);
    // CLI  (19EF_0249 / 0x1A139)
    InterruptFlag = false;
    CheckExternalEvents(cs14, 0x24B);
    // IN AL,DX (19EF_024A / 0x1A13A)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs14, 0x24D);
    // MOV DL,0xc0 (19EF_024B / 0x1A13B)
    DL = 0xC0;
    CheckExternalEvents(cs14, 0x24F);
    // MOV AL,BL (19EF_024D / 0x1A13D)
    AL = BL;
    CheckExternalEvents(cs14, 0x250);
    // OUT DX,AL (19EF_024F / 0x1A13F)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs14, 0x252);
    // MOV AL,CL (19EF_0250 / 0x1A140)
    AL = CL;
    CheckExternalEvents(cs14, 0x253);
    // OUT DX,AL (19EF_0252 / 0x1A142)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs14, 0x254);
    // POP DX (19EF_0253 / 0x1A143)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x255);
    // IN AL,DX (19EF_0254 / 0x1A144)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs14, 0x257);
    // MOV DL,0xc0 (19EF_0255 / 0x1A145)
    DL = 0xC0;
    CheckExternalEvents(cs14, 0x259);
    // MOV AL,0x20 (19EF_0257 / 0x1A147)
    AL = 0x20;
    CheckExternalEvents(cs14, 0x25A);
    // OUT DX,AL (19EF_0259 / 0x1A149)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs14, 0x25B);
    // STI  (19EF_025A / 0x1A14A)
    InterruptFlag = true;
    CheckExternalEvents(cs14, 0x25C);
    // POP DS (19EF_025B / 0x1A14B)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x25D);
    // POP SI (19EF_025C / 0x1A14C)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x25E);
    // POP DI (19EF_025D / 0x1A14D)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x25F);
    // POP BP (19EF_025E / 0x1A14E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x260);
    // RETF  (19EF_025F / 0x1A14F)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0260_1A150(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0260_1A150:
    CheckExternalEvents(cs14, 0x261);
    // PUSH BP (19EF_0260 / 0x1A150)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x263);
    // MOV BP,SP (19EF_0261 / 0x1A151)
    BP = SP;
    CheckExternalEvents(cs14, 0x264);
    // PUSH DI (19EF_0263 / 0x1A153)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x265);
    // PUSH SI (19EF_0264 / 0x1A154)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x266);
    // PUSH DS (19EF_0265 / 0x1A155)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x269);
    // MOV AX,0x1ddc (19EF_0266 / 0x1A156)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x26B);
    // MOV DS,AX (19EF_0269 / 0x1A159)
    DS = AX;
    CheckExternalEvents(cs14, 0x26E);
    // MOV AX,word ptr [BP + 0x6] (19EF_026B / 0x1A15B)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x270);
    // MOV SI,AX (19EF_026E / 0x1A15E)
    SI = AX;
    CheckExternalEvents(cs14, 0x273);
    // MOV AX,word ptr [BP + 0x8] (19EF_0270 / 0x1A160)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x274);
    // PUSH ES (19EF_0273 / 0x1A163)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x276);
    // MOV ES,AX (19EF_0274 / 0x1A164)
    ES = AX;
    CheckExternalEvents(cs14, 0x279);
    // MOV AX,word ptr [BP + 0xa] (19EF_0276 / 0x1A166)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x27C);
    // MOV CX,0x1f40 (19EF_0279 / 0x1A169)
    CX = 0x1F40;
    CheckExternalEvents(cs14, 0x27D);
    // PUSH DS (19EF_027C / 0x1A16C)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x27F);
    // MOV DS,AX (19EF_027D / 0x1A16D)
    DS = AX;
    CheckExternalEvents(cs14, 0x282);
    // MOV DI,0x0 (19EF_027F / 0x1A16F)
    DI = 0x0;
    CheckExternalEvents(cs14, 0x285);
    // MOV DX,0x3ce (19EF_0282 / 0x1A172)
    DX = 0x3CE;
    CheckExternalEvents(cs14, 0x288);
    // MOV AX,0x205 (19EF_0285 / 0x1A175)
    AX = 0x205;
    CheckExternalEvents(cs14, 0x289);
    // OUT DX,AX (19EF_0288 / 0x1A178)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x28B);
    // MOV AL,0x3 (19EF_0289 / 0x1A179)
    AL = 0x3;
    CheckExternalEvents(cs14, 0x28D);
    // MOV AH,0x18 (19EF_028B / 0x1A17B)
    AH = 0x18;
    label_19EF_028D_1A17D:
    CheckExternalEvents(cs14, 0x290);
    // MOV AX,0x8008 (19EF_028D / 0x1A17D)
    AX = 0x8008;
    CheckExternalEvents(cs14, 0x291);
    // OUT DX,AX (19EF_0290 / 0x1A180)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x293);
    // MOV AL,byte ptr [DI] (19EF_0291 / 0x1A181)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x296);
    // MOV BL,byte ptr ES:[SI] (19EF_0293 / 0x1A183)
    BL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x298);
    // MOV AL,BL (19EF_0296 / 0x1A186)
    AL = BL;
    CheckExternalEvents(cs14, 0x29A);
    // SHR AL,0x1 (19EF_0298 / 0x1A188)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x29C);
    // SHR AL,0x1 (19EF_029A / 0x1A18A)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x29E);
    // SHR AL,0x1 (19EF_029C / 0x1A18C)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x2A0);
    // SHR AL,0x1 (19EF_029E / 0x1A18E)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0x2A2);
    // MOV byte ptr [DI],AL (19EF_02A0 / 0x1A190)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x2A4);
    // MOV AL,byte ptr [DI] (19EF_02A2 / 0x1A192)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x2A7);
    // MOV AX,0x4008 (19EF_02A4 / 0x1A194)
    AX = 0x4008;
    CheckExternalEvents(cs14, 0x2A8);
    // OUT DX,AX (19EF_02A7 / 0x1A197)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x2AA);
    // MOV byte ptr [DI],BL (19EF_02A8 / 0x1A198)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs14, 0x2AB);
    // INC SI (19EF_02AA / 0x1A19A)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x2AE);
    // MOV AX,0x2008 (19EF_02AB / 0x1A19B)
    AX = 0x2008;
    CheckExternalEvents(cs14, 0x2AF);
    // OUT DX,AX (19EF_02AE / 0x1A19E)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x2B1);
    // MOV AL,byte ptr [DI] (19EF_02AF / 0x1A19F)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x2B4);
    // MOV BL,byte ptr ES:[SI] (19EF_02B1 / 0x1A1A1)
    BL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x2B6);
    // MOV AL,BL (19EF_02B4 / 0x1A1A4)
    AL = BL;
    CheckExternalEvents(cs14, 0x2B8);
    // SHR AL,0x1 (19EF_02B6 / 0x1A1A6)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x2BA);
    // SHR AL,0x1 (19EF_02B8 / 0x1A1A8)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x2BC);
    // SHR AL,0x1 (19EF_02BA / 0x1A1AA)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x2BE);
    // SHR AL,0x1 (19EF_02BC / 0x1A1AC)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0x2C0);
    // MOV byte ptr [DI],AL (19EF_02BE / 0x1A1AE)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x2C2);
    // MOV AL,byte ptr [DI] (19EF_02C0 / 0x1A1B0)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x2C5);
    // MOV AX,0x1008 (19EF_02C2 / 0x1A1B2)
    AX = 0x1008;
    CheckExternalEvents(cs14, 0x2C6);
    // OUT DX,AX (19EF_02C5 / 0x1A1B5)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x2C8);
    // MOV byte ptr [DI],BL (19EF_02C6 / 0x1A1B6)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs14, 0x2C9);
    // INC SI (19EF_02C8 / 0x1A1B8)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x2CC);
    // MOV AX,0x808 (19EF_02C9 / 0x1A1B9)
    AX = 0x808;
    CheckExternalEvents(cs14, 0x2CD);
    // OUT DX,AX (19EF_02CC / 0x1A1BC)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x2CF);
    // MOV AL,byte ptr [DI] (19EF_02CD / 0x1A1BD)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x2D2);
    // MOV BL,byte ptr ES:[SI] (19EF_02CF / 0x1A1BF)
    BL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x2D4);
    // MOV AL,BL (19EF_02D2 / 0x1A1C2)
    AL = BL;
    CheckExternalEvents(cs14, 0x2D6);
    // SHR AL,0x1 (19EF_02D4 / 0x1A1C4)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x2D8);
    // SHR AL,0x1 (19EF_02D6 / 0x1A1C6)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x2DA);
    // SHR AL,0x1 (19EF_02D8 / 0x1A1C8)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x2DC);
    // SHR AL,0x1 (19EF_02DA / 0x1A1CA)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0x2DE);
    // MOV byte ptr [DI],AL (19EF_02DC / 0x1A1CC)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x2E0);
    // MOV AL,byte ptr [DI] (19EF_02DE / 0x1A1CE)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x2E3);
    // MOV AX,0x408 (19EF_02E0 / 0x1A1D0)
    AX = 0x408;
    CheckExternalEvents(cs14, 0x2E4);
    // OUT DX,AX (19EF_02E3 / 0x1A1D3)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x2E6);
    // MOV byte ptr [DI],BL (19EF_02E4 / 0x1A1D4)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs14, 0x2E7);
    // INC SI (19EF_02E6 / 0x1A1D6)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x2EA);
    // MOV AX,0x208 (19EF_02E7 / 0x1A1D7)
    AX = 0x208;
    CheckExternalEvents(cs14, 0x2EB);
    // OUT DX,AX (19EF_02EA / 0x1A1DA)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x2ED);
    // MOV AL,byte ptr [DI] (19EF_02EB / 0x1A1DB)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x2F0);
    // MOV BL,byte ptr ES:[SI] (19EF_02ED / 0x1A1DD)
    BL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x2F2);
    // MOV AL,BL (19EF_02F0 / 0x1A1E0)
    AL = BL;
    CheckExternalEvents(cs14, 0x2F4);
    // SHR AL,0x1 (19EF_02F2 / 0x1A1E2)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x2F6);
    // SHR AL,0x1 (19EF_02F4 / 0x1A1E4)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x2F8);
    // SHR AL,0x1 (19EF_02F6 / 0x1A1E6)
    AL >>= 0x1;
    CheckExternalEvents(cs14, 0x2FA);
    // SHR AL,0x1 (19EF_02F8 / 0x1A1E8)
    // AL >>= 0x1;
    AL = Alu8.Shr(AL, 0x1);
    CheckExternalEvents(cs14, 0x2FC);
    // MOV byte ptr [DI],AL (19EF_02FA / 0x1A1EA)
    UInt8[DS, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x2FE);
    // MOV AL,byte ptr [DI] (19EF_02FC / 0x1A1EC)
    AL = UInt8[DS, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x301);
    // MOV AX,0x108 (19EF_02FE / 0x1A1EE)
    AX = 0x108;
    CheckExternalEvents(cs14, 0x302);
    // OUT DX,AX (19EF_0301 / 0x1A1F1)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x304);
    // MOV byte ptr [DI],BL (19EF_0302 / 0x1A1F2)
    UInt8[DS, (ushort)(DI)] = BL;
    CheckExternalEvents(cs14, 0x305);
    // INC SI (19EF_0304 / 0x1A1F4)
    SI++;
    CheckExternalEvents(cs14, 0x306);
    // INC DI (19EF_0305 / 0x1A1F5)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs14, 0x308);
    // LOOP 0x1000:a17d (19EF_0306 / 0x1A1F6)
    if(--CX != 0) {
      goto label_19EF_028D_1A17D;
    }
    CheckExternalEvents(cs14, 0x30B);
    // MOV AX,0x8 (19EF_0308 / 0x1A1F8)
    AX = 0x8;
    CheckExternalEvents(cs14, 0x30C);
    // OUT DX,AX (19EF_030B / 0x1A1FB)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x30D);
    // POP DS (19EF_030C / 0x1A1FC)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x30E);
    // POP ES (19EF_030D / 0x1A1FD)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x30F);
    // POP DS (19EF_030E / 0x1A1FE)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x310);
    // POP SI (19EF_030F / 0x1A1FF)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x311);
    // POP DI (19EF_0310 / 0x1A200)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x312);
    // POP BP (19EF_0311 / 0x1A201)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x313);
    // RETF  (19EF_0312 / 0x1A202)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0313_1A203(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0313_1A203:
    CheckExternalEvents(cs14, 0x314);
    // PUSH BP (19EF_0313 / 0x1A203)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x316);
    // MOV BP,SP (19EF_0314 / 0x1A204)
    BP = SP;
    CheckExternalEvents(cs14, 0x317);
    // PUSH DI (19EF_0316 / 0x1A206)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x318);
    // PUSH SI (19EF_0317 / 0x1A207)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x319);
    // PUSH DS (19EF_0318 / 0x1A208)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x31C);
    // MOV AX,0x1ddc (19EF_0319 / 0x1A209)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x31E);
    // MOV DS,AX (19EF_031C / 0x1A20C)
    DS = AX;
    CheckExternalEvents(cs14, 0x31F);
    // PUSH ES (19EF_031E / 0x1A20E)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x322);
    // MOV DX,0x3ce (19EF_031F / 0x1A20F)
    DX = 0x3CE;
    CheckExternalEvents(cs14, 0x325);
    // MOV AX,0x205 (19EF_0322 / 0x1A212)
    AX = 0x205;
    CheckExternalEvents(cs14, 0x326);
    // OUT DX,AX (19EF_0325 / 0x1A215)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x329);
    // MOV AX,0x8 (19EF_0326 / 0x1A216)
    AX = 0x8;
    CheckExternalEvents(cs14, 0x32A);
    // OUT DX,AX (19EF_0329 / 0x1A219)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x32D);
    // MOV AX,word ptr [BP + 0x6] (19EF_032A / 0x1A21A)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x32F);
    // MOV DI,AX (19EF_032D / 0x1A21D)
    DI = AX;
    CheckExternalEvents(cs14, 0x332);
    // MOV AX,word ptr [BP + 0x8] (19EF_032F / 0x1A21F)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x334);
    // MOV ES,AX (19EF_0332 / 0x1A222)
    ES = AX;
    CheckExternalEvents(cs14, 0x337);
    // MOV BX,word ptr [BP + 0xa] (19EF_0334 / 0x1A224)
    BX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x33A);
    // MOV AX,word ptr [BP + 0xc] (19EF_0337 / 0x1A227)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x33D);
    // MOV DX,0x140 (19EF_033A / 0x1A22A)
    DX = 0x140;
    CheckExternalEvents(cs14, 0x33F);
    // MUL DX (19EF_033D / 0x1A22D)
    uint resMul19EF_033D = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul19EF_033D);
    DX = (ushort)(resMul19EF_033D >> 16);
    CheckExternalEvents(cs14, 0x341);
    // ADD AX,BX (19EF_033F / 0x1A22F)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs14, 0x343);
    // MOV SI,AX (19EF_0341 / 0x1A231)
    SI = AX;
    CheckExternalEvents(cs14, 0x344);
    // PUSH DS (19EF_0343 / 0x1A233)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x347);
    // MOV AX,0xa800 (19EF_0344 / 0x1A234)
    AX = 0xA800;
    CheckExternalEvents(cs14, 0x349);
    // MOV DS,AX (19EF_0347 / 0x1A237)
    DS = AX;
    CheckExternalEvents(cs14, 0x34C);
    // MOV CX,0x8 (19EF_0349 / 0x1A239)
    CX = 0x8;
    CheckExternalEvents(cs14, 0x34F);
    // MOV DX,0x3ce (19EF_034C / 0x1A23C)
    DX = 0x3CE;
    label_19EF_034F_1A23F:
    CheckExternalEvents(cs14, 0x352);
    // MOV AX,0x4 (19EF_034F / 0x1A23F)
    AX = 0x4;
    CheckExternalEvents(cs14, 0x353);
    // OUT DX,AX (19EF_0352 / 0x1A242)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x355);
    // MOV AL,byte ptr [SI] (19EF_0353 / 0x1A243)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x356);
    // STOSB ES:DI (19EF_0355 / 0x1A245)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x359);
    // MOV AX,0x104 (19EF_0356 / 0x1A246)
    AX = 0x104;
    CheckExternalEvents(cs14, 0x35A);
    // OUT DX,AX (19EF_0359 / 0x1A249)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x35C);
    // MOV AL,byte ptr [SI] (19EF_035A / 0x1A24A)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x35D);
    // STOSB ES:DI (19EF_035C / 0x1A24C)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x360);
    // MOV AX,0x204 (19EF_035D / 0x1A24D)
    AX = 0x204;
    CheckExternalEvents(cs14, 0x361);
    // OUT DX,AX (19EF_0360 / 0x1A250)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x363);
    // MOV AL,byte ptr [SI] (19EF_0361 / 0x1A251)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x364);
    // STOSB ES:DI (19EF_0363 / 0x1A253)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x367);
    // MOV AX,0x304 (19EF_0364 / 0x1A254)
    AX = 0x304;
    CheckExternalEvents(cs14, 0x368);
    // OUT DX,AX (19EF_0367 / 0x1A257)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x36A);
    // MOV AL,byte ptr [SI] (19EF_0368 / 0x1A258)
    AL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x36B);
    // STOSB ES:DI (19EF_036A / 0x1A25A)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x36E);
    // ADD SI,0x28 (19EF_036B / 0x1A25B)
    // SI += 0x28;
    SI = Alu16.Add(SI, 0x28);
    CheckExternalEvents(cs14, 0x370);
    // LOOP 0x1000:a23f (19EF_036E / 0x1A25E)
    if(--CX != 0) {
      goto label_19EF_034F_1A23F;
    }
    CheckExternalEvents(cs14, 0x371);
    // POP DS (19EF_0370 / 0x1A260)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x372);
    // POP ES (19EF_0371 / 0x1A261)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x373);
    // POP DS (19EF_0372 / 0x1A262)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x374);
    // POP SI (19EF_0373 / 0x1A263)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x375);
    // POP DI (19EF_0374 / 0x1A264)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x376);
    // POP BP (19EF_0375 / 0x1A265)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x377);
    // RETF  (19EF_0376 / 0x1A266)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0377_1A267(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0377_1A267:
    CheckExternalEvents(cs14, 0x378);
    // PUSH BP (19EF_0377 / 0x1A267)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x37A);
    // MOV BP,SP (19EF_0378 / 0x1A268)
    BP = SP;
    CheckExternalEvents(cs14, 0x37B);
    // PUSH DI (19EF_037A / 0x1A26A)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x37C);
    // PUSH SI (19EF_037B / 0x1A26B)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x37D);
    // PUSH DS (19EF_037C / 0x1A26C)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x380);
    // MOV AX,0x1ddc (19EF_037D / 0x1A26D)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x382);
    // MOV DS,AX (19EF_0380 / 0x1A270)
    DS = AX;
    CheckExternalEvents(cs14, 0x383);
    // PUSH ES (19EF_0382 / 0x1A272)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x386);
    // MOV AX,word ptr [BP + 0x6] (19EF_0383 / 0x1A273)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x388);
    // MOV DI,AX (19EF_0386 / 0x1A276)
    DI = AX;
    CheckExternalEvents(cs14, 0x38B);
    // MOV AX,word ptr [BP + 0x8] (19EF_0388 / 0x1A278)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x38D);
    // MOV ES,AX (19EF_038B / 0x1A27B)
    ES = AX;
    CheckExternalEvents(cs14, 0x390);
    // MOV AX,word ptr [BP + 0xa] (19EF_038D / 0x1A27D)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x392);
    // MOV SI,AX (19EF_0390 / 0x1A280)
    SI = AX;
    CheckExternalEvents(cs14, 0x395);
    // MOV AX,word ptr [BP + 0xc] (19EF_0392 / 0x1A282)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x398);
    // MOV [0x25c],AX (19EF_0395 / 0x1A285)
    UInt16[DS, 0x25C] = AX;
    CheckExternalEvents(cs14, 0x39B);
    // MOV AX,word ptr [BP + 0xe] (19EF_0398 / 0x1A288)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs14, 0x39E);
    // MOV [0x262],AX (19EF_039B / 0x1A28B)
    UInt16[DS, 0x262] = AX;
    CheckExternalEvents(cs14, 0x3A0);
    // SAR AX,0x1 (19EF_039E / 0x1A28E)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs14, 0x3A2);
    // SAR AX,0x1 (19EF_03A0 / 0x1A290)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs14, 0x3A4);
    // SAR AX,0x1 (19EF_03A2 / 0x1A292)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs14, 0x3A7);
    // MOV [0x266],AX (19EF_03A4 / 0x1A294)
    UInt16[DS, 0x266] = AX;
    CheckExternalEvents(cs14, 0x3AA);
    // MOV AX,word ptr [BP + 0x10] (19EF_03A7 / 0x1A297)
    AX = UInt16[SS, (ushort)(BP + 0x10)];
    CheckExternalEvents(cs14, 0x3AD);
    // MOV [0x264],AX (19EF_03AA / 0x1A29A)
    UInt16[DS, 0x264] = AX;
    CheckExternalEvents(cs14, 0x3AE);
    // PUSH DS (19EF_03AD / 0x1A29D)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x3AF);
    // INC SI (19EF_03AE / 0x1A29E)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x3B2);
    // MOV AX,[0x25c] (19EF_03AF / 0x1A29F)
    AX = UInt16[DS, 0x25C];
    CheckExternalEvents(cs14, 0x3B4);
    // MOV DS,AX (19EF_03B2 / 0x1A2A2)
    DS = AX;
    CheckExternalEvents(cs14, 0x3B5);
    // LODSW SI (19EF_03B4 / 0x1A2A4)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs14, 0x3B6);
    // INC SI (19EF_03B5 / 0x1A2A5)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs14, 0x3B7);
    // POP DS (19EF_03B6 / 0x1A2A6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x3B9);
    // INC AL (19EF_03B7 / 0x1A2A7)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs14, 0x3BA);
    // PUSH AX (19EF_03B9 / 0x1A2A9)
    Stack.Push16(AX);
    CheckExternalEvents(cs14, 0x3BD);
    // AND AX,0xff (19EF_03BA / 0x1A2AA)
    // AX &= 0xFF;
    AX = Alu16.And(AX, 0xFF);
    CheckExternalEvents(cs14, 0x3C0);
    // MOV [0x26c],AX (19EF_03BD / 0x1A2AD)
    UInt16[DS, 0x26C] = AX;
    CheckExternalEvents(cs14, 0x3C1);
    // POP AX (19EF_03C0 / 0x1A2B0)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x3C3);
    // XCHG AH,AL (19EF_03C1 / 0x1A2B1)
    (AL, AH) = (AH, AL);
    CheckExternalEvents(cs14, 0x3C6);
    // AND AX,0xff (19EF_03C3 / 0x1A2B3)
    // AX &= 0xFF;
    AX = Alu16.And(AX, 0xFF);
    CheckExternalEvents(cs14, 0x3C9);
    // MOV [0x268],AX (19EF_03C6 / 0x1A2B6)
    UInt16[DS, 0x268] = AX;
    CheckExternalEvents(cs14, 0x3CB);
    // SHL AX,0x1 (19EF_03C9 / 0x1A2B9)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x3CD);
    // SHL AX,0x1 (19EF_03CB / 0x1A2BB)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs14, 0x3D0);
    // MOV [0x26a],AX (19EF_03CD / 0x1A2BD)
    UInt16[DS, 0x26A] = AX;
    CheckExternalEvents(cs14, 0x3D3);
    // MOV AX,[0x264] (19EF_03D0 / 0x1A2C0)
    AX = UInt16[DS, 0x264];
    CheckExternalEvents(cs14, 0x3D6);
    // CMP AX,0x0 (19EF_03D3 / 0x1A2C3)
    Alu16.Sub(AX, 0x0);
    CheckExternalEvents(cs14, 0x3D8);
    // JNS 0x1000:a2ed (19EF_03D6 / 0x1A2C6)
    if(!SignFlag) {
      goto label_19EF_03FD_1A2ED;
    }
    CheckExternalEvents(cs14, 0x3DA);
    // NEG AX (19EF_03D8 / 0x1A2C8)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs14, 0x3DE);
    // CMP AX,word ptr [0x26c] (19EF_03DA / 0x1A2CA)
    Alu16.Sub(AX, UInt16[DS, 0x26C]);
    CheckExternalEvents(cs14, 0x3E0);
    // JNC 0x1000:a337 (19EF_03DE / 0x1A2CE)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs8, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x3E4);
    // MOV DX,word ptr [0x268] (19EF_03E0 / 0x1A2D0)
    DX = UInt16[DS, 0x268];
    CheckExternalEvents(cs14, 0x3E6);
    // SHL DX,0x1 (19EF_03E4 / 0x1A2D4)
    DX <<= 0x1;
    CheckExternalEvents(cs14, 0x3E8);
    // SHL DX,0x1 (19EF_03E6 / 0x1A2D6)
    DX <<= 0x1;
    CheckExternalEvents(cs14, 0x3EA);
    // MUL DX (19EF_03E8 / 0x1A2D8)
    uint resMul19EF_03E8 = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul19EF_03E8);
    DX = (ushort)(resMul19EF_03E8 >> 16);
    CheckExternalEvents(cs14, 0x3EC);
    // ADD SI,AX (19EF_03EA / 0x1A2DA)
    // SI += AX;
    SI = Alu16.Add(SI, AX);
    CheckExternalEvents(cs14, 0x3EF);
    // MOV AX,[0x26c] (19EF_03EC / 0x1A2DC)
    AX = UInt16[DS, 0x26C];
    CheckExternalEvents(cs14, 0x3F3);
    // ADD AX,word ptr [0x264] (19EF_03EF / 0x1A2DF)
    // AX += UInt16[DS, 0x264];
    AX = Alu16.Add(AX, UInt16[DS, 0x264]);
    CheckExternalEvents(cs14, 0x3F5);
    // JS 0x1000:a337 (19EF_03F3 / 0x1A2E3)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs8, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x3F8);
    // MOV [0x26c],AX (19EF_03F5 / 0x1A2E5)
    UInt16[DS, 0x26C] = AX;
    CheckExternalEvents(cs14, 0x3FA);
    // XOR AX,AX (19EF_03F8 / 0x1A2E8)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs14, 0x3FD);
    // MOV [0x264],AX (19EF_03FA / 0x1A2EA)
    UInt16[DS, 0x264] = AX;
    label_19EF_03FD_1A2ED:
    CheckExternalEvents(cs14, 0x400);
    // MOV AX,0xc8 (19EF_03FD / 0x1A2ED)
    AX = 0xC8;
    CheckExternalEvents(cs14, 0x404);
    // SUB AX,word ptr [0x264] (19EF_0400 / 0x1A2F0)
    // AX -= UInt16[DS, 0x264];
    AX = Alu16.Sub(AX, UInt16[DS, 0x264]);
    CheckExternalEvents(cs14, 0x406);
    // JS 0x1000:a337 (19EF_0404 / 0x1A2F4)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs8, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x408);
    // JZ 0x1000:a337 (19EF_0406 / 0x1A2F6)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs8, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x40C);
    // CMP AX,word ptr [0x26c] (19EF_0408 / 0x1A2F8)
    Alu16.Sub(AX, UInt16[DS, 0x26C]);
    CheckExternalEvents(cs14, 0x40E);
    // JNC 0x1000:a301 (19EF_040C / 0x1A2FC)
    if(!CarryFlag) {
      goto label_19EF_0411_1A301;
    }
    CheckExternalEvents(cs14, 0x411);
    // MOV [0x26c],AX (19EF_040E / 0x1A2FE)
    UInt16[DS, 0x26C] = AX;
    label_19EF_0411_1A301:
    CheckExternalEvents(cs14, 0x414);
    // MOV AX,[0x266] (19EF_0411 / 0x1A301)
    AX = UInt16[DS, 0x266];
    CheckExternalEvents(cs14, 0x417);
    // CMP AX,0x0 (19EF_0414 / 0x1A304)
    Alu16.Sub(AX, 0x0);
    CheckExternalEvents(cs14, 0x419);
    // JNS 0x1000:a320 (19EF_0417 / 0x1A307)
    if(!SignFlag) {
      goto label_19EF_0430_1A320;
    }
    CheckExternalEvents(cs14, 0x41D);
    // ADD word ptr [0x268],AX (19EF_0419 / 0x1A309)
    UInt16[DS, 0x268] += AX;
    CheckExternalEvents(cs14, 0x41F);
    // NEG AX (19EF_041D / 0x1A30D)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs14, 0x421);
    // SHL AX,0x1 (19EF_041F / 0x1A30F)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x423);
    // SHL AX,0x1 (19EF_0421 / 0x1A311)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x425);
    // ADD SI,AX (19EF_0423 / 0x1A313)
    SI += AX;
    CheckExternalEvents(cs14, 0x429);
    // CMP AX,word ptr [0x26a] (19EF_0425 / 0x1A315)
    Alu16.Sub(AX, UInt16[DS, 0x26A]);
    CheckExternalEvents(cs14, 0x42B);
    // JNC 0x1000:a337 (19EF_0429 / 0x1A319)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs8, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x42D);
    // XOR AX,AX (19EF_042B / 0x1A31B)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs14, 0x430);
    // MOV [0x266],AX (19EF_042D / 0x1A31D)
    UInt16[DS, 0x266] = AX;
    label_19EF_0430_1A320:
    CheckExternalEvents(cs14, 0x433);
    // MOV AX,0x28 (19EF_0430 / 0x1A320)
    AX = 0x28;
    CheckExternalEvents(cs14, 0x437);
    // SUB AX,word ptr [0x266] (19EF_0433 / 0x1A323)
    // AX -= UInt16[DS, 0x266];
    AX = Alu16.Sub(AX, UInt16[DS, 0x266]);
    CheckExternalEvents(cs14, 0x439);
    // JS 0x1000:a337 (19EF_0437 / 0x1A327)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs8, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x43B);
    // JZ 0x1000:a337 (19EF_0439 / 0x1A329)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs8, 0xA33A);
      // JMP 0x1000:a458 (1000_A337 / 0x1A337)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x43F);
    // CMP AX,word ptr [0x268] (19EF_043B / 0x1A32B)
    Alu16.Sub(AX, UInt16[DS, 0x268]);
    CheckExternalEvents(cs14, 0x441);
    // JNC 0x1000:a33a (19EF_043F / 0x1A32F)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A33A_1A33A, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x444);
    // MOV [0x268],AX (19EF_0441 / 0x1A331)
    UInt16[DS, 0x268] = AX;
    CheckExternalEvents(cs14, 0x446);
    // JMP 0x1000:a33a (19EF_0444 / 0x1A334)
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
    CheckExternalEvents(cs8, 0xA33A);
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
    CheckExternalEvents(cs8, 0xA33D);
    // MOV AX,[0x264] (1000_A33A / 0x1A33A)
    AX = UInt16[DS, 0x264];
    CheckExternalEvents(cs8, 0xA340);
    // MOV DX,0x28 (1000_A33D / 0x1A33D)
    DX = 0x28;
    CheckExternalEvents(cs8, 0xA342);
    // MUL DL (1000_A340 / 0x1A340)
    ushort resMul1000_A340 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A340);
    AH = (byte)(resMul1000_A340 >> 8);
    CheckExternalEvents(cs8, 0xA346);
    // ADD AX,word ptr [0x266] (1000_A342 / 0x1A342)
    AX += UInt16[DS, 0x266];
    CheckExternalEvents(cs8, 0xA348);
    // ADD DI,AX (1000_A346 / 0x1A346)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs8, 0xA34B);
    // MOV AX,0x28 (1000_A348 / 0x1A348)
    AX = 0x28;
    CheckExternalEvents(cs8, 0xA34F);
    // SUB AX,word ptr [0x268] (1000_A34B / 0x1A34B)
    // AX -= UInt16[DS, 0x268];
    AX = Alu16.Sub(AX, UInt16[DS, 0x268]);
    CheckExternalEvents(cs8, 0xA352);
    // MOV [0x264],AX (1000_A34F / 0x1A34F)
    UInt16[DS, 0x264] = AX;
    CheckExternalEvents(cs8, 0xA355);
    // MOV DX,0x3ce (1000_A352 / 0x1A352)
    DX = 0x3CE;
    CheckExternalEvents(cs8, 0xA358);
    // MOV AX,0x5 (1000_A355 / 0x1A355)
    AX = 0x5;
    CheckExternalEvents(cs8, 0xA359);
    // OUT DX,AX (1000_A358 / 0x1A358)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA35C);
    // MOV AX,0xff08 (1000_A359 / 0x1A359)
    AX = 0xFF08;
    CheckExternalEvents(cs8, 0xA35D);
    // OUT DX,AX (1000_A35C / 0x1A35C)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA361);
    // MOV BX,word ptr [0x262] (1000_A35D / 0x1A35D)
    BX = UInt16[DS, 0x262];
    CheckExternalEvents(cs8, 0xA364);
    // AND BX,0x7 (1000_A361 / 0x1A361)
    // BX &= 0x7;
    BX = Alu16.And(BX, 0x7);
    label_1000_A364_1A364:
    CheckExternalEvents(cs8, 0xA368);
    // MOV BP,word ptr [0x266] (1000_A364 / 0x1A364)
    BP = UInt16[DS, 0x266];
    CheckExternalEvents(cs8, 0xA36C);
    // MOV CX,word ptr [0x268] (1000_A368 / 0x1A368)
    CX = UInt16[DS, 0x268];
    CheckExternalEvents(cs8, 0xA36F);
    // MOV AX,[0x25c] (1000_A36C / 0x1A36C)
    AX = UInt16[DS, 0x25C];
    CheckExternalEvents(cs8, 0xA370);
    // PUSH DS (1000_A36F / 0x1A36F)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xA372);
    // MOV DS,AX (1000_A370 / 0x1A370)
    DS = AX;
    CheckExternalEvents(cs8, 0xA374);
    // MOV DH,0x3 (1000_A372 / 0x1A372)
    DH = 0x3;
    label_1000_A374_1A374:
    CheckExternalEvents(cs8, 0xA375);
    // PUSH CX (1000_A374 / 0x1A374)
    Stack.Push16(CX);
    CheckExternalEvents(cs8, 0xA377);
    // MOV DL,0xce (1000_A375 / 0x1A375)
    DL = 0xCE;
    CheckExternalEvents(cs8, 0xA37A);
    // MOV AX,0x4 (1000_A377 / 0x1A377)
    AX = 0x4;
    CheckExternalEvents(cs8, 0xA37B);
    // OUT DX,AX (1000_A37A / 0x1A37A)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA37D);
    // MOV DL,0xc4 (1000_A37B / 0x1A37B)
    DL = 0xC4;
    CheckExternalEvents(cs8, 0xA380);
    // MOV AX,0x102 (1000_A37D / 0x1A37D)
    AX = 0x102;
    CheckExternalEvents(cs8, 0xA381);
    // OUT DX,AX (1000_A380 / 0x1A380)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA383);
    // MOV AX,word ptr [SI] (1000_A381 / 0x1A381)
    AX = UInt16[DS, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xA386);
    // OR AX,word ptr [SI + 0x2] (1000_A383 / 0x1A383)
    // AX |= UInt16[DS, (ushort)(SI + 0x2)];
    AX = Alu16.Or(AX, UInt16[DS, (ushort)(SI + 0x2)]);
    CheckExternalEvents(cs8, 0xA388);
    // OR AH,AL (1000_A386 / 0x1A386)
    AH |= AL;
    CheckExternalEvents(cs8, 0xA38A);
    // XOR AL,AL (1000_A388 / 0x1A388)
    AL = 0;
    CheckExternalEvents(cs8, 0xA38C);
    // CMP BL,AL (1000_A38A / 0x1A38A)
    Alu8.Sub(BL, AL);
    CheckExternalEvents(cs8, 0xA38E);
    // JZ 0x1000:a392 (1000_A38C / 0x1A38C)
    if(ZeroFlag) {
      goto label_1000_A392_1A392;
    }
    CheckExternalEvents(cs8, 0xA390);
    // MOV CL,BL (1000_A38E / 0x1A38E)
    CL = BL;
    CheckExternalEvents(cs8, 0xA392);
    // SHR AX,CL (1000_A390 / 0x1A390)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    label_1000_A392_1A392:
    CheckExternalEvents(cs8, 0xA394);
    // NOT AX (1000_A392 / 0x1A392)
    AX = (ushort)(~AX);
    CheckExternalEvents(cs8, 0xA396);
    // MOV CH,AH (1000_A394 / 0x1A394)
    CH = AH;
    CheckExternalEvents(cs8, 0xA398);
    // MOV BH,AL (1000_A396 / 0x1A396)
    BH = AL;
    CheckExternalEvents(cs8, 0xA39B);
    // AND byte ptr ES:[DI],CH (1000_A398 / 0x1A398)
    // UInt8[ES, (ushort)(DI)] &= CH;
    UInt8[ES, (ushort)(DI)] = Alu8.And(UInt8[ES, (ushort)(DI)], CH);
    CheckExternalEvents(cs8, 0xA39C);
    // LODSB SI (1000_A39B / 0x1A39B)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xA39E);
    // MOV AH,AL (1000_A39C / 0x1A39C)
    AH = AL;
    CheckExternalEvents(cs8, 0xA3A0);
    // XOR AL,AL (1000_A39E / 0x1A39E)
    AL = 0;
    CheckExternalEvents(cs8, 0xA3A2);
    // CMP BL,AL (1000_A3A0 / 0x1A3A0)
    Alu8.Sub(BL, AL);
    CheckExternalEvents(cs8, 0xA3A4);
    // JZ 0x1000:a3a6 (1000_A3A2 / 0x1A3A2)
    if(ZeroFlag) {
      goto label_1000_A3A6_1A3A6;
    }
    CheckExternalEvents(cs8, 0xA3A6);
    // SHR AX,CL (1000_A3A4 / 0x1A3A4)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    label_1000_A3A6_1A3A6:
    CheckExternalEvents(cs8, 0xA3A9);
    // OR byte ptr ES:[DI],AH (1000_A3A6 / 0x1A3A6)
    UInt8[ES, (ushort)(DI)] |= AH;
    CheckExternalEvents(cs8, 0xA3AC);
    // CMP BP,0x27 (1000_A3A9 / 0x1A3A9)
    Alu16.Sub(BP, 0x27);
    CheckExternalEvents(cs8, 0xA3AE);
    // JNC 0x1000:a3b6 (1000_A3AC / 0x1A3AC)
    if(!CarryFlag) {
      goto label_1000_A3B6_1A3B6;
    }
    CheckExternalEvents(cs8, 0xA3B2);
    // AND byte ptr ES:[DI + 0x1],BH (1000_A3AE / 0x1A3AE)
    // UInt8[ES, (ushort)(DI + 0x1)] &= BH;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.And(UInt8[ES, (ushort)(DI + 0x1)], BH);
    CheckExternalEvents(cs8, 0xA3B6);
    // OR byte ptr ES:[DI + 0x1],AL (1000_A3B2 / 0x1A3B2)
    // UInt8[ES, (ushort)(DI + 0x1)] |= AL;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.Or(UInt8[ES, (ushort)(DI + 0x1)], AL);
    label_1000_A3B6_1A3B6:
    CheckExternalEvents(cs8, 0xA3B8);
    // MOV DL,0xce (1000_A3B6 / 0x1A3B6)
    DL = 0xCE;
    CheckExternalEvents(cs8, 0xA3BB);
    // MOV AX,0x104 (1000_A3B8 / 0x1A3B8)
    AX = 0x104;
    CheckExternalEvents(cs8, 0xA3BC);
    // OUT DX,AX (1000_A3BB / 0x1A3BB)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA3BE);
    // MOV DL,0xc4 (1000_A3BC / 0x1A3BC)
    DL = 0xC4;
    CheckExternalEvents(cs8, 0xA3C1);
    // MOV AX,0x202 (1000_A3BE / 0x1A3BE)
    AX = 0x202;
    CheckExternalEvents(cs8, 0xA3C2);
    // OUT DX,AX (1000_A3C1 / 0x1A3C1)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA3C5);
    // AND byte ptr ES:[DI],CH (1000_A3C2 / 0x1A3C2)
    // UInt8[ES, (ushort)(DI)] &= CH;
    UInt8[ES, (ushort)(DI)] = Alu8.And(UInt8[ES, (ushort)(DI)], CH);
    CheckExternalEvents(cs8, 0xA3C6);
    // LODSB SI (1000_A3C5 / 0x1A3C5)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xA3C8);
    // MOV AH,AL (1000_A3C6 / 0x1A3C6)
    AH = AL;
    CheckExternalEvents(cs8, 0xA3CA);
    // XOR AL,AL (1000_A3C8 / 0x1A3C8)
    AL = 0;
    CheckExternalEvents(cs8, 0xA3CC);
    // CMP BL,AL (1000_A3CA / 0x1A3CA)
    Alu8.Sub(BL, AL);
    CheckExternalEvents(cs8, 0xA3CE);
    // JZ 0x1000:a3d0 (1000_A3CC / 0x1A3CC)
    if(ZeroFlag) {
      goto label_1000_A3D0_1A3D0;
    }
    CheckExternalEvents(cs8, 0xA3D0);
    // SHR AX,CL (1000_A3CE / 0x1A3CE)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    label_1000_A3D0_1A3D0:
    CheckExternalEvents(cs8, 0xA3D3);
    // OR byte ptr ES:[DI],AH (1000_A3D0 / 0x1A3D0)
    UInt8[ES, (ushort)(DI)] |= AH;
    CheckExternalEvents(cs8, 0xA3D6);
    // CMP BP,0x27 (1000_A3D3 / 0x1A3D3)
    Alu16.Sub(BP, 0x27);
    CheckExternalEvents(cs8, 0xA3D8);
    // JNC 0x1000:a3e0 (1000_A3D6 / 0x1A3D6)
    if(!CarryFlag) {
      goto label_1000_A3E0_1A3E0;
    }
    CheckExternalEvents(cs8, 0xA3DC);
    // AND byte ptr ES:[DI + 0x1],BH (1000_A3D8 / 0x1A3D8)
    // UInt8[ES, (ushort)(DI + 0x1)] &= BH;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.And(UInt8[ES, (ushort)(DI + 0x1)], BH);
    CheckExternalEvents(cs8, 0xA3E0);
    // OR byte ptr ES:[DI + 0x1],AL (1000_A3DC / 0x1A3DC)
    // UInt8[ES, (ushort)(DI + 0x1)] |= AL;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.Or(UInt8[ES, (ushort)(DI + 0x1)], AL);
    label_1000_A3E0_1A3E0:
    CheckExternalEvents(cs8, 0xA3E2);
    // MOV DL,0xce (1000_A3E0 / 0x1A3E0)
    DL = 0xCE;
    CheckExternalEvents(cs8, 0xA3E5);
    // MOV AX,0x204 (1000_A3E2 / 0x1A3E2)
    AX = 0x204;
    CheckExternalEvents(cs8, 0xA3E6);
    // OUT DX,AX (1000_A3E5 / 0x1A3E5)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA3E8);
    // MOV DL,0xc4 (1000_A3E6 / 0x1A3E6)
    DL = 0xC4;
    CheckExternalEvents(cs8, 0xA3EB);
    // MOV AX,0x402 (1000_A3E8 / 0x1A3E8)
    AX = 0x402;
    CheckExternalEvents(cs8, 0xA3EC);
    // OUT DX,AX (1000_A3EB / 0x1A3EB)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA3EF);
    // AND byte ptr ES:[DI],CH (1000_A3EC / 0x1A3EC)
    // UInt8[ES, (ushort)(DI)] &= CH;
    UInt8[ES, (ushort)(DI)] = Alu8.And(UInt8[ES, (ushort)(DI)], CH);
    CheckExternalEvents(cs8, 0xA3F0);
    // LODSB SI (1000_A3EF / 0x1A3EF)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xA3F2);
    // MOV AH,AL (1000_A3F0 / 0x1A3F0)
    AH = AL;
    CheckExternalEvents(cs8, 0xA3F4);
    // XOR AL,AL (1000_A3F2 / 0x1A3F2)
    AL = 0;
    CheckExternalEvents(cs8, 0xA3F6);
    // CMP BL,AL (1000_A3F4 / 0x1A3F4)
    Alu8.Sub(BL, AL);
    CheckExternalEvents(cs8, 0xA3F8);
    // JZ 0x1000:a3fa (1000_A3F6 / 0x1A3F6)
    if(ZeroFlag) {
      goto label_1000_A3FA_1A3FA;
    }
    CheckExternalEvents(cs8, 0xA3FA);
    // SHR AX,CL (1000_A3F8 / 0x1A3F8)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    label_1000_A3FA_1A3FA:
    CheckExternalEvents(cs8, 0xA3FD);
    // OR byte ptr ES:[DI],AH (1000_A3FA / 0x1A3FA)
    UInt8[ES, (ushort)(DI)] |= AH;
    CheckExternalEvents(cs8, 0xA400);
    // CMP BP,0x27 (1000_A3FD / 0x1A3FD)
    Alu16.Sub(BP, 0x27);
    CheckExternalEvents(cs8, 0xA402);
    // JNC 0x1000:a40a (1000_A400 / 0x1A400)
    if(!CarryFlag) {
      goto label_1000_A40A_1A40A;
    }
    CheckExternalEvents(cs8, 0xA406);
    // AND byte ptr ES:[DI + 0x1],BH (1000_A402 / 0x1A402)
    // UInt8[ES, (ushort)(DI + 0x1)] &= BH;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.And(UInt8[ES, (ushort)(DI + 0x1)], BH);
    CheckExternalEvents(cs8, 0xA40A);
    // OR byte ptr ES:[DI + 0x1],AL (1000_A406 / 0x1A406)
    // UInt8[ES, (ushort)(DI + 0x1)] |= AL;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.Or(UInt8[ES, (ushort)(DI + 0x1)], AL);
    label_1000_A40A_1A40A:
    CheckExternalEvents(cs8, 0xA40C);
    // MOV DL,0xce (1000_A40A / 0x1A40A)
    DL = 0xCE;
    CheckExternalEvents(cs8, 0xA40F);
    // MOV AX,0x304 (1000_A40C / 0x1A40C)
    AX = 0x304;
    CheckExternalEvents(cs8, 0xA410);
    // OUT DX,AX (1000_A40F / 0x1A40F)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA412);
    // MOV DL,0xc4 (1000_A410 / 0x1A410)
    DL = 0xC4;
    CheckExternalEvents(cs8, 0xA415);
    // MOV AX,0x802 (1000_A412 / 0x1A412)
    AX = 0x802;
    CheckExternalEvents(cs8, 0xA416);
    // OUT DX,AX (1000_A415 / 0x1A415)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA419);
    // AND byte ptr ES:[DI],CH (1000_A416 / 0x1A416)
    // UInt8[ES, (ushort)(DI)] &= CH;
    UInt8[ES, (ushort)(DI)] = Alu8.And(UInt8[ES, (ushort)(DI)], CH);
    CheckExternalEvents(cs8, 0xA41A);
    // LODSB SI (1000_A419 / 0x1A419)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xA41C);
    // MOV AH,AL (1000_A41A / 0x1A41A)
    AH = AL;
    CheckExternalEvents(cs8, 0xA41E);
    // XOR AL,AL (1000_A41C / 0x1A41C)
    AL = 0;
    CheckExternalEvents(cs8, 0xA420);
    // CMP BL,AL (1000_A41E / 0x1A41E)
    Alu8.Sub(BL, AL);
    CheckExternalEvents(cs8, 0xA422);
    // JZ 0x1000:a424 (1000_A420 / 0x1A420)
    if(ZeroFlag) {
      goto label_1000_A424_1A424;
    }
    CheckExternalEvents(cs8, 0xA424);
    // SHR AX,CL (1000_A422 / 0x1A422)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    label_1000_A424_1A424:
    CheckExternalEvents(cs8, 0xA427);
    // OR byte ptr ES:[DI],AH (1000_A424 / 0x1A424)
    UInt8[ES, (ushort)(DI)] |= AH;
    CheckExternalEvents(cs8, 0xA42A);
    // CMP BP,0x27 (1000_A427 / 0x1A427)
    Alu16.Sub(BP, 0x27);
    CheckExternalEvents(cs8, 0xA42C);
    // JNC 0x1000:a434 (1000_A42A / 0x1A42A)
    if(!CarryFlag) {
      goto label_1000_A434_1A434;
    }
    CheckExternalEvents(cs8, 0xA430);
    // AND byte ptr ES:[DI + 0x1],BH (1000_A42C / 0x1A42C)
    // UInt8[ES, (ushort)(DI + 0x1)] &= BH;
    UInt8[ES, (ushort)(DI + 0x1)] = Alu8.And(UInt8[ES, (ushort)(DI + 0x1)], BH);
    CheckExternalEvents(cs8, 0xA434);
    // OR byte ptr ES:[DI + 0x1],AL (1000_A430 / 0x1A430)
    UInt8[ES, (ushort)(DI + 0x1)] |= AL;
    label_1000_A434_1A434:
    CheckExternalEvents(cs8, 0xA435);
    // INC BP (1000_A434 / 0x1A434)
    BP++;
    CheckExternalEvents(cs8, 0xA436);
    // INC DI (1000_A435 / 0x1A435)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs8, 0xA437);
    // POP CX (1000_A436 / 0x1A436)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA439);
    // LOOP 0x1000:a455 (1000_A437 / 0x1A437)
    if(--CX != 0) {
      // LOOP target is JMP, inlining.
      CheckExternalEvents(cs8, 0xA458);
      // JMP 0x1000:a374 (1000_A455 / 0x1A455)
      goto label_1000_A374_1A374;
    }
    CheckExternalEvents(cs8, 0xA43A);
    // POP DS (1000_A439 / 0x1A439)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA43E);
    // ADD SI,word ptr [0x26a] (1000_A43A / 0x1A43A)
    // SI += UInt16[DS, 0x26A];
    SI = Alu16.Add(SI, UInt16[DS, 0x26A]);
    CheckExternalEvents(cs8, 0xA441);
    // MOV AX,[0x268] (1000_A43E / 0x1A43E)
    AX = UInt16[DS, 0x268];
    CheckExternalEvents(cs8, 0xA443);
    // SHL AX,0x1 (1000_A441 / 0x1A441)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0xA445);
    // SHL AX,0x1 (1000_A443 / 0x1A443)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0xA447);
    // SUB SI,AX (1000_A445 / 0x1A445)
    SI -= AX;
    CheckExternalEvents(cs8, 0xA44B);
    // ADD DI,word ptr [0x264] (1000_A447 / 0x1A447)
    DI += UInt16[DS, 0x264];
    label_1000_A44B_1A44B:
    CheckExternalEvents(cs8, 0xA450);
    // SUB word ptr [0x26c],0x1 (1000_A44B / 0x1A44B)
    // UInt16[DS, 0x26C] -= 0x1;
    UInt16[DS, 0x26C] = Alu16.Sub(UInt16[DS, 0x26C], 0x1);
    CheckExternalEvents(cs8, 0xA452);
    // JZ 0x1000:a458 (1000_A450 / 0x1A450)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_A458_1A458, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xA455);
    // JMP 0x1000:a364 (1000_A452 / 0x1A452)
    goto label_1000_A364_1A364;
    label_1000_A455_1A455:
    CheckExternalEvents(cs8, 0xA458);
    // JMP 0x1000:a374 (1000_A455 / 0x1A455)
    goto label_1000_A374_1A374;
  }
  
  public virtual Action ghidra_guess_1000_A458_1A458(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_A458_1A458:
    CheckExternalEvents(cs8, 0xA45B);
    // MOV AX,0xf02 (1000_A458 / 0x1A458)
    AX = 0xF02;
    CheckExternalEvents(cs8, 0xA45C);
    // OUT DX,AX (1000_A45B / 0x1A45B)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xA45D);
    // POP ES (1000_A45C / 0x1A45C)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA45E);
    // POP DS (1000_A45D / 0x1A45D)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA45F);
    // POP SI (1000_A45E / 0x1A45E)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA460);
    // POP DI (1000_A45F / 0x1A45F)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA461);
    // POP BP (1000_A460 / 0x1A460)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xA462);
    // RETF  (1000_A461 / 0x1A461)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_0572_1A462(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_0572_1A462:
    CheckExternalEvents(cs14, 0x573);
    // PUSH BP (19EF_0572 / 0x1A462)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x575);
    // MOV BP,SP (19EF_0573 / 0x1A463)
    BP = SP;
    CheckExternalEvents(cs14, 0x576);
    // PUSH DI (19EF_0575 / 0x1A465)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x577);
    // PUSH SI (19EF_0576 / 0x1A466)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x578);
    // PUSH DS (19EF_0577 / 0x1A467)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x57B);
    // MOV AX,0x1ddc (19EF_0578 / 0x1A468)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x57D);
    // MOV DS,AX (19EF_057B / 0x1A46B)
    DS = AX;
    CheckExternalEvents(cs14, 0x57E);
    // PUSH ES (19EF_057D / 0x1A46D)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x581);
    // MOV SI,word ptr [BP + 0x6] (19EF_057E / 0x1A46E)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x584);
    // MOV BX,word ptr [BP + 0x8] (19EF_0581 / 0x1A471)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x587);
    // MOV DI,word ptr [BP + 0xa] (19EF_0584 / 0x1A474)
    DI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x58A);
    // MOV AX,word ptr [BP + 0xc] (19EF_0587 / 0x1A477)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x58C);
    // MOV ES,AX (19EF_058A / 0x1A47A)
    ES = AX;
    CheckExternalEvents(cs14, 0x58F);
    // MOV CX,word ptr [BP + 0xe] (19EF_058C / 0x1A47C)
    CX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs14, 0x591);
    // SHR CX,0x1 (19EF_058F / 0x1A47F)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    CheckExternalEvents(cs14, 0x592);
    // PUSH DS (19EF_0591 / 0x1A481)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x594);
    // MOV DS,BX (19EF_0592 / 0x1A482)
    DS = BX;
    label_19EF_0594_1A484:
    CheckExternalEvents(cs14, 0x595);
    // LODSB SI (19EF_0594 / 0x1A484)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x598);
    // CALL 0x1000:a4af (19EF_0595 / 0x1A485)
    NearCall(cs14, 0x598, unknown_19EF_05BF_1A4AF);
    CheckExternalEvents(cs14, 0x59B);
    // CALL 0x1000:a4af (19EF_0598 / 0x1A488)
    NearCall(cs14, 0x59B, unknown_19EF_05BF_1A4AF);
    CheckExternalEvents(cs14, 0x59C);
    // LODSB SI (19EF_059B / 0x1A48B)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x59F);
    // CALL 0x1000:a4af (19EF_059C / 0x1A48C)
    NearCall(cs14, 0x59F, unknown_19EF_05BF_1A4AF);
    CheckExternalEvents(cs14, 0x5A2);
    // CALL 0x1000:a4af (19EF_059F / 0x1A48F)
    NearCall(cs14, 0x5A2, unknown_19EF_05BF_1A4AF);
    CheckExternalEvents(cs14, 0x5A3);
    // LODSB SI (19EF_05A2 / 0x1A492)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x5A6);
    // CALL 0x1000:a4af (19EF_05A3 / 0x1A493)
    NearCall(cs14, 0x5A6, unknown_19EF_05BF_1A4AF);
    CheckExternalEvents(cs14, 0x5A9);
    // CALL 0x1000:a4af (19EF_05A6 / 0x1A496)
    NearCall(cs14, 0x5A9, unknown_19EF_05BF_1A4AF);
    CheckExternalEvents(cs14, 0x5AA);
    // LODSB SI (19EF_05A9 / 0x1A499)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x5AD);
    // CALL 0x1000:a4af (19EF_05AA / 0x1A49A)
    NearCall(cs14, 0x5AD, unknown_19EF_05BF_1A4AF);
    CheckExternalEvents(cs14, 0x5B0);
    // CALL 0x1000:a4af (19EF_05AD / 0x1A49D)
    NearCall(cs14, 0x5B0, unknown_19EF_05BF_1A4AF);
    CheckExternalEvents(cs14, 0x5B2);
    // MOV AX,BX (19EF_05B0 / 0x1A4A0)
    AX = BX;
    CheckExternalEvents(cs14, 0x5B3);
    // STOSW ES:DI (19EF_05B2 / 0x1A4A2)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x5B5);
    // MOV AX,DX (19EF_05B3 / 0x1A4A3)
    AX = DX;
    CheckExternalEvents(cs14, 0x5B6);
    // STOSW ES:DI (19EF_05B5 / 0x1A4A5)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs14, 0x5B8);
    // LOOP 0x1000:a484 (19EF_05B6 / 0x1A4A6)
    if(--CX != 0) {
      goto label_19EF_0594_1A484;
    }
    CheckExternalEvents(cs14, 0x5B9);
    // POP DS (19EF_05B8 / 0x1A4A8)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x5BA);
    // POP ES (19EF_05B9 / 0x1A4A9)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x5BB);
    // POP DS (19EF_05BA / 0x1A4AA)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x5BC);
    // POP SI (19EF_05BB / 0x1A4AB)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x5BD);
    // POP DI (19EF_05BC / 0x1A4AC)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x5BE);
    // POP BP (19EF_05BD / 0x1A4AD)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x5BF);
    // RETF  (19EF_05BE / 0x1A4AE)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_05BF_1A4AF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_05BF_1A4AF:
    CheckExternalEvents(cs14, 0x5C1);
    // SHL AL,0x1 (19EF_05BF / 0x1A4AF)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs14, 0x5C3);
    // RCL DH,0x1 (19EF_05C1 / 0x1A4B1)
    DH = Alu8.Rcl(DH, 0x1);
    CheckExternalEvents(cs14, 0x5C5);
    // SHL AL,0x1 (19EF_05C3 / 0x1A4B3)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs14, 0x5C7);
    // RCL DL,0x1 (19EF_05C5 / 0x1A4B5)
    DL = Alu8.Rcl(DL, 0x1);
    CheckExternalEvents(cs14, 0x5C9);
    // SHL AL,0x1 (19EF_05C7 / 0x1A4B7)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs14, 0x5CB);
    // RCL BH,0x1 (19EF_05C9 / 0x1A4B9)
    BH = Alu8.Rcl(BH, 0x1);
    CheckExternalEvents(cs14, 0x5CD);
    // SHL AL,0x1 (19EF_05CB / 0x1A4BB)
    // AL <<= 0x1;
    AL = Alu8.Shl(AL, 0x1);
    CheckExternalEvents(cs14, 0x5CF);
    // RCL BL,0x1 (19EF_05CD / 0x1A4BD)
    BL = Alu8.Rcl(BL, 0x1);
    CheckExternalEvents(cs14, 0x5D0);
    // RET  (19EF_05CF / 0x1A4BF)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_05D0_1A4C0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_05D0_1A4C0:
    CheckExternalEvents(cs14, 0x5D1);
    // PUSH BP (19EF_05D0 / 0x1A4C0)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x5D3);
    // MOV BP,SP (19EF_05D1 / 0x1A4C1)
    BP = SP;
    CheckExternalEvents(cs14, 0x5D4);
    // PUSH DI (19EF_05D3 / 0x1A4C3)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x5D5);
    // PUSH SI (19EF_05D4 / 0x1A4C4)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x5D6);
    // PUSH DS (19EF_05D5 / 0x1A4C5)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x5D9);
    // MOV AX,0x1ddc (19EF_05D6 / 0x1A4C6)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x5DB);
    // MOV DS,AX (19EF_05D9 / 0x1A4C9)
    DS = AX;
    CheckExternalEvents(cs14, 0x5DC);
    // PUSH ES (19EF_05DB / 0x1A4CB)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x5DF);
    // MOV AX,word ptr [BP + 0x6] (19EF_05DC / 0x1A4CC)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x5E2);
    // MOV [0x220],AX (19EF_05DF / 0x1A4CF)
    UInt16[DS, 0x220] = AX;
    CheckExternalEvents(cs14, 0x5E5);
    // MOV AX,word ptr [BP + 0x8] (19EF_05E2 / 0x1A4D2)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x5E8);
    // MOV [0x234],AX (19EF_05E5 / 0x1A4D5)
    UInt16[DS, 0x234] = AX;
    CheckExternalEvents(cs14, 0x5EB);
    // MOV AX,word ptr [BP + 0xa] (19EF_05E8 / 0x1A4D8)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x5EE);
    // MOV [0x236],AX (19EF_05EB / 0x1A4DB)
    UInt16[DS, 0x236] = AX;
    CheckExternalEvents(cs14, 0x5F1);
    // MOV AX,word ptr [BP + 0xc] (19EF_05EE / 0x1A4DE)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x5F4);
    // MOV [0x224],AX (19EF_05F1 / 0x1A4E1)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs14, 0x5F9);
    // CMP word ptr [0xb764],0x3 (19EF_05F4 / 0x1A4E4)
    Alu16.Sub(UInt16[DS, 0xB764], 0x3);
    CheckExternalEvents(cs14, 0x5FB);
    // JZ 0x1000:a4f5 (19EF_05F9 / 0x1A4E9)
    if(ZeroFlag) {
      goto label_19EF_0605_1A4F5;
    }
    CheckExternalEvents(cs14, 0x600);
    // CMP word ptr [0xb764],0x0 (19EF_05FB / 0x1A4EB)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x602);
    // JNZ 0x1000:a520 (19EF_0600 / 0x1A4F0)
    if(!ZeroFlag) {
      goto label_19EF_0630_1A520;
    }
    CheckExternalEvents(cs14, 0x605);
    // JMP 0x1000:a5ed (19EF_0602 / 0x1A4F2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_A5ED_1A5ED, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_0605_1A4F5:
    CheckExternalEvents(cs14, 0x608);
    // MOV AX,0xa000 (19EF_0605 / 0x1A4F5)
    AX = 0xA000;
    CheckExternalEvents(cs14, 0x60A);
    // MOV ES,AX (19EF_0608 / 0x1A4F8)
    ES = AX;
    CheckExternalEvents(cs14, 0x60D);
    // MOV AX,[0x234] (19EF_060A / 0x1A4FA)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs14, 0x610);
    // MOV DX,0x140 (19EF_060D / 0x1A4FD)
    DX = 0x140;
    CheckExternalEvents(cs14, 0x612);
    // MUL DX (19EF_0610 / 0x1A500)
    uint resMul19EF_0610 = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul19EF_0610);
    DX = (ushort)(resMul19EF_0610 >> 16);
    CheckExternalEvents(cs14, 0x616);
    // ADD AX,word ptr [0x220] (19EF_0612 / 0x1A502)
    // AX += UInt16[DS, 0x220];
    AX = Alu16.Add(AX, UInt16[DS, 0x220]);
    CheckExternalEvents(cs14, 0x618);
    // MOV DI,AX (19EF_0616 / 0x1A506)
    DI = AX;
    CheckExternalEvents(cs14, 0x61C);
    // MOV CX,word ptr [0x236] (19EF_0618 / 0x1A508)
    CX = UInt16[DS, 0x236];
    CheckExternalEvents(cs14, 0x620);
    // SUB CX,word ptr [0x234] (19EF_061C / 0x1A50C)
    CX -= UInt16[DS, 0x234];
    CheckExternalEvents(cs14, 0x621);
    // INC CX (19EF_0620 / 0x1A510)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs14, 0x624);
    // MOV AX,[0x224] (19EF_0621 / 0x1A511)
    AX = UInt16[DS, 0x224];
    label_19EF_0624_1A514:
    CheckExternalEvents(cs14, 0x627);
    // MOV byte ptr ES:[DI],AL (19EF_0624 / 0x1A514)
    UInt8[ES, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x62B);
    // ADD DI,0x140 (19EF_0627 / 0x1A517)
    // DI += 0x140;
    DI = Alu16.Add(DI, 0x140);
    CheckExternalEvents(cs14, 0x62D);
    // LOOP 0x1000:a514 (19EF_062B / 0x1A51B)
    if(--CX != 0) {
      goto label_19EF_0624_1A514;
    }
    CheckExternalEvents(cs14, 0x630);
    // JMP 0x1000:a5e7 (19EF_062D / 0x1A51D)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A5E1_1A5E1, 0x1A5E7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_0630_1A520:
    CheckExternalEvents(cs14, 0x635);
    // CMP word ptr [0xb764],0x1 (19EF_0630 / 0x1A520)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs14, 0x637);
    // JZ 0x1000:a56f (19EF_0635 / 0x1A525)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A56F_1A56F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x63A);
    // MOV DX,0x3ce (19EF_0637 / 0x1A527)
    DX = 0x3CE;
    CheckExternalEvents(cs14, 0x63D);
    // MOV AX,0x205 (19EF_063A / 0x1A52A)
    AX = 0x205;
    CheckExternalEvents(cs14, 0x63E);
    // OUT DX,AX (19EF_063D / 0x1A52D)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x642);
    // MOV CX,word ptr [0x220] (19EF_063E / 0x1A52E)
    CX = UInt16[DS, 0x220];
    CheckExternalEvents(cs14, 0x645);
    // MOV AX,0x8008 (19EF_0642 / 0x1A532)
    AX = 0x8008;
    CheckExternalEvents(cs14, 0x648);
    // AND CX,0x7 (19EF_0645 / 0x1A535)
    // CX &= 0x7;
    CX = Alu16.And(CX, 0x7);
    CheckExternalEvents(cs14, 0x64A);
    // JZ 0x1000:a53c (19EF_0648 / 0x1A538)
    if(ZeroFlag) {
      goto label_19EF_064C_1A53C;
    }
    CheckExternalEvents(cs14, 0x64C);
    // SHR AH,CL (19EF_064A / 0x1A53A)
    // AH >>= CL;
    AH = Alu8.Shr(AH, CL);
    label_19EF_064C_1A53C:
    CheckExternalEvents(cs14, 0x64D);
    // OUT DX,AX (19EF_064C / 0x1A53C)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs14, 0x650);
    // MOV AX,0xa000 (19EF_064D / 0x1A53D)
    AX = 0xA000;
    CheckExternalEvents(cs14, 0x652);
    // MOV ES,AX (19EF_0650 / 0x1A540)
    ES = AX;
    CheckExternalEvents(cs14, 0x656);
    // MOV DX,word ptr [0x234] (19EF_0652 / 0x1A542)
    DX = UInt16[DS, 0x234];
    CheckExternalEvents(cs14, 0x659);
    // MOV AX,0x28 (19EF_0656 / 0x1A546)
    AX = 0x28;
    CheckExternalEvents(cs14, 0x65B);
    // MUL DL (19EF_0659 / 0x1A549)
    ushort resMul19EF_0659 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul19EF_0659);
    AH = (byte)(resMul19EF_0659 >> 8);
    CheckExternalEvents(cs14, 0x65F);
    // MOV BX,word ptr [0x220] (19EF_065B / 0x1A54B)
    BX = UInt16[DS, 0x220];
    CheckExternalEvents(cs14, 0x661);
    // SHR BX,0x1 (19EF_065F / 0x1A54F)
    BX >>= 0x1;
    CheckExternalEvents(cs14, 0x663);
    // SHR BX,0x1 (19EF_0661 / 0x1A551)
    BX >>= 0x1;
    CheckExternalEvents(cs14, 0x665);
    // SHR BX,0x1 (19EF_0663 / 0x1A553)
    BX >>= 0x1;
    CheckExternalEvents(cs14, 0x667);
    // ADD AX,BX (19EF_0665 / 0x1A555)
    // AX += BX;
    AX = Alu16.Add(AX, BX);
    CheckExternalEvents(cs14, 0x669);
    // MOV DI,AX (19EF_0667 / 0x1A557)
    DI = AX;
    CheckExternalEvents(cs14, 0x66C);
    // MOV AX,[0x224] (19EF_0669 / 0x1A559)
    AX = UInt16[DS, 0x224];
    label_19EF_066C_1A55C:
    CheckExternalEvents(cs14, 0x66F);
    // MOV AH,byte ptr ES:[DI] (19EF_066C / 0x1A55C)
    AH = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x672);
    // MOV byte ptr ES:[DI],AL (19EF_066F / 0x1A55F)
    UInt8[ES, (ushort)(DI)] = AL;
    CheckExternalEvents(cs14, 0x675);
    // ADD DI,0x28 (19EF_0672 / 0x1A562)
    DI += 0x28;
    CheckExternalEvents(cs14, 0x676);
    // INC DX (19EF_0675 / 0x1A565)
    DX++;
    CheckExternalEvents(cs14, 0x67A);
    // CMP DX,word ptr [0x236] (19EF_0676 / 0x1A566)
    Alu16.Sub(DX, UInt16[DS, 0x236]);
    CheckExternalEvents(cs14, 0x67C);
    // JLE 0x1000:a55c (19EF_067A / 0x1A56A)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_19EF_066C_1A55C;
    }
    CheckExternalEvents(cs14, 0x67E);
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
    CheckExternalEvents(cs8, 0xA572);
    // MOV CX,0x4 (1000_A56F / 0x1A56F)
    CX = 0x4;
    CheckExternalEvents(cs8, 0xA574);
    // SHL AX,CL (1000_A572 / 0x1A572)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs8, 0xA578);
    // OR AX,word ptr [0x224] (1000_A574 / 0x1A574)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs8, 0xA57B);
    // MOV BX,0xf (1000_A578 / 0x1A578)
    BX = 0xF;
    CheckExternalEvents(cs8, 0xA57F);
    // MOV CX,word ptr [0x220] (1000_A57B / 0x1A57B)
    CX = UInt16[DS, 0x220];
    CheckExternalEvents(cs8, 0xA583);
    // TEST CX,0x1 (1000_A57F / 0x1A57F)
    Alu16.And(CX, 0x1);
    CheckExternalEvents(cs8, 0xA585);
    // JNZ 0x1000:a58a (1000_A583 / 0x1A583)
    if(!ZeroFlag) {
      goto label_1000_A58A_1A58A;
    }
    CheckExternalEvents(cs8, 0xA588);
    // MOV CX,0x4 (1000_A585 / 0x1A585)
    CX = 0x4;
    CheckExternalEvents(cs8, 0xA58A);
    // SHL BX,CL (1000_A588 / 0x1A588)
    BX <<= CL;
    label_1000_A58A_1A58A:
    CheckExternalEvents(cs8, 0xA58C);
    // AND AX,BX (1000_A58A / 0x1A58A)
    // AX &= BX;
    AX = Alu16.And(AX, BX);
    CheckExternalEvents(cs8, 0xA58F);
    // MOV [0x224],AX (1000_A58C / 0x1A58C)
    UInt16[DS, 0x224] = AX;
    CheckExternalEvents(cs8, 0xA591);
    // NOT BL (1000_A58F / 0x1A58F)
    BL = (byte)(~BL);
    CheckExternalEvents(cs8, 0xA594);
    // MOV AX,0xb800 (1000_A591 / 0x1A591)
    AX = 0xB800;
    CheckExternalEvents(cs8, 0xA596);
    // MOV ES,AX (1000_A594 / 0x1A594)
    ES = AX;
    CheckExternalEvents(cs8, 0xA599);
    // MOV AX,[0x234] (1000_A596 / 0x1A596)
    AX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA59B);
    // AND AL,0xfc (1000_A599 / 0x1A599)
    // AL &= 0xFC;
    AL = Alu8.And(AL, 0xFC);
    CheckExternalEvents(cs8, 0xA59E);
    // MOV DX,0x28 (1000_A59B / 0x1A59B)
    DX = 0x28;
    CheckExternalEvents(cs8, 0xA5A0);
    // MUL DL (1000_A59E / 0x1A59E)
    ushort resMul1000_A59E = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_A59E);
    AH = (byte)(resMul1000_A59E >> 8);
    CheckExternalEvents(cs8, 0xA5A4);
    // MOV CX,word ptr [0x234] (1000_A5A0 / 0x1A5A0)
    CX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA5A7);
    // AND CX,0x3 (1000_A5A4 / 0x1A5A4)
    // CX &= 0x3;
    CX = Alu16.And(CX, 0x3);
    CheckExternalEvents(cs8, 0xA5A9);
    // JZ 0x1000:a5ae (1000_A5A7 / 0x1A5A7)
    if(ZeroFlag) {
      goto label_1000_A5AE_1A5AE;
    }
    label_1000_A5A9_1A5A9:
    CheckExternalEvents(cs8, 0xA5AC);
    // ADD AH,0x20 (1000_A5A9 / 0x1A5A9)
    // AH += 0x20;
    AH = Alu8.Add(AH, 0x20);
    CheckExternalEvents(cs8, 0xA5AE);
    // LOOP 0x1000:a5a9 (1000_A5AC / 0x1A5AC)
    if(--CX != 0) {
      goto label_1000_A5A9_1A5A9;
    }
    label_1000_A5AE_1A5AE:
    CheckExternalEvents(cs8, 0xA5B2);
    // MOV DX,word ptr [0x220] (1000_A5AE / 0x1A5AE)
    DX = UInt16[DS, 0x220];
    CheckExternalEvents(cs8, 0xA5B4);
    // SHR DX,0x1 (1000_A5B2 / 0x1A5B2)
    DX >>= 0x1;
    CheckExternalEvents(cs8, 0xA5B6);
    // ADD AX,DX (1000_A5B4 / 0x1A5B4)
    // AX += DX;
    AX = Alu16.Add(AX, DX);
    CheckExternalEvents(cs8, 0xA5BA);
    // MOV DX,word ptr [0x234] (1000_A5B6 / 0x1A5B6)
    DX = UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA5BC);
    // MOV DI,AX (1000_A5BA / 0x1A5BA)
    DI = AX;
    CheckExternalEvents(cs8, 0xA5C0);
    // MOV CX,word ptr [0x236] (1000_A5BC / 0x1A5BC)
    CX = UInt16[DS, 0x236];
    CheckExternalEvents(cs8, 0xA5C4);
    // SUB CX,word ptr [0x234] (1000_A5C0 / 0x1A5C0)
    CX -= UInt16[DS, 0x234];
    CheckExternalEvents(cs8, 0xA5C5);
    // INC CX (1000_A5C4 / 0x1A5C4)
    CX = Alu16.Inc(CX);
    label_1000_A5C5_1A5C5:
    CheckExternalEvents(cs8, 0xA5C8);
    // MOV AL,byte ptr ES:[DI] (1000_A5C5 / 0x1A5C5)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs8, 0xA5CA);
    // AND AL,BL (1000_A5C8 / 0x1A5C8)
    // AL &= BL;
    AL = Alu8.And(AL, BL);
    CheckExternalEvents(cs8, 0xA5CE);
    // OR AX,word ptr [0x224] (1000_A5CA / 0x1A5CA)
    // AX |= UInt16[DS, 0x224];
    AX = Alu16.Or(AX, UInt16[DS, 0x224]);
    CheckExternalEvents(cs8, 0xA5D1);
    // MOV byte ptr ES:[DI],AL (1000_A5CE / 0x1A5CE)
    UInt8[ES, (ushort)(DI)] = AL;
    CheckExternalEvents(cs8, 0xA5D3);
    // INC DL (1000_A5D1 / 0x1A5D1)
    DL++;
    CheckExternalEvents(cs8, 0xA5D6);
    // AND DL,0x3 (1000_A5D3 / 0x1A5D3)
    // DL &= 0x3;
    DL = Alu8.And(DL, 0x3);
    CheckExternalEvents(cs8, 0xA5D8);
    // JZ 0x1000:a5e1 (1000_A5D6 / 0x1A5D6)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_A5E1_1A5E1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xA5DC);
    // ADD DI,0x2000 (1000_A5D8 / 0x1A5D8)
    // DI += 0x2000;
    DI = Alu16.Add(DI, 0x2000);
    CheckExternalEvents(cs8, 0xA5DE);
    // LOOP 0x1000:a5c5 (1000_A5DC / 0x1A5DC)
    if(--CX != 0) {
      goto label_1000_A5C5_1A5C5;
    }
    CheckExternalEvents(cs8, 0xA5E0);
    // JMP 0x1000:a5e7 (1000_A5DE / 0x1A5DE)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_A5E1_1A5E1, 0x1A5E7 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
}
