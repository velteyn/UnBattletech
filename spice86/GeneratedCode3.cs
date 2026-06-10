namespace generated;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.InstructionsImpl;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action unknown_0170_320B_0490B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_320B_0490B:
    CheckExternalEvents(cs2, 0x320D);
    // XOR AX,AX (0170_320B / 0x490B)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs2, 0x3212);
    // CALLF 0x1000:cecc (0170_320D / 0x490D)
    FarCall(cs2, 0x3212, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x3215);
    // MOV AX,0x2 (0170_3212 / 0x4912)
    AX = 0x2;
    CheckExternalEvents(cs2, 0x3216);
    // PUSH AX (0170_3215 / 0x4915)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3217);
    // PUSH CS (0170_3216 / 0x4916)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x321A);
    // CALL 0x0000:3fcc (0170_3217 / 0x4917)
    NearCall(cs2, 0x321A, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs2, 0x321D);
    // ADD SP,0x2 (0170_321A / 0x491A)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs2, 0x3220);
    // MOV AX,0x150 (0170_321D / 0x491D)
    AX = 0x150;
    CheckExternalEvents(cs2, 0x3223);
    // MOV DX,0x2958 (0170_3220 / 0x4920)
    DX = 0x2958;
    CheckExternalEvents(cs2, 0x3224);
    // PUSH DX (0170_3223 / 0x4923)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x3225);
    // PUSH AX (0170_3224 / 0x4924)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x322A);
    // CALLF 0x1000:9fc1 (0170_3225 / 0x4925)
    FarCall(cs2, 0x322A, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs2, 0x322D);
    // ADD SP,0x4 (0170_322A / 0x492A)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs2, 0x3231);
    // MOV ES,word ptr [0x53e8] (0170_322D / 0x492D)
    ES = UInt16[DS, 0x53E8];
    CheckExternalEvents(cs2, 0x3238);
    // MOV word ptr ES:[0x4fbc],0x1 (0170_3231 / 0x4931)
    UInt16[ES, 0x4FBC] = 0x1;
    CheckExternalEvents(cs2, 0x323B);
    // MOV AX,0x244b (0170_3238 / 0x4938)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x323E);
    // MOV DX,0x1ddc (0170_323B / 0x493B)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x323F);
    // PUSH DX (0170_323E / 0x493E)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x3240);
    // PUSH AX (0170_323F / 0x493F)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3243);
    // MOV AX,0x5bb (0170_3240 / 0x4940)
    AX = 0x5BB;
    CheckExternalEvents(cs2, 0x3244);
    // PUSH DS (0170_3243 / 0x4943)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x3245);
    // PUSH AX (0170_3244 / 0x4944)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x324A);
    // CALLF 0x1000:910b (0170_3245 / 0x4945)
    FarCall(cs2, 0x324A, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs2, 0x324D);
    // ADD SP,0x8 (0170_324A / 0x494A)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x3250);
    // MOV AX,0x4614 (0170_324D / 0x494D)
    AX = 0x4614;
    CheckExternalEvents(cs2, 0x3253);
    // MOV DX,0x2a02 (0170_3250 / 0x4950)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x3254);
    // PUSH DX (0170_3253 / 0x4953)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x3255);
    // PUSH AX (0170_3254 / 0x4954)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3258);
    // MOV AX,0x244b (0170_3255 / 0x4955)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x325B);
    // MOV DX,0x1ddc (0170_3258 / 0x4958)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x325C);
    // PUSH DX (0170_325B / 0x495B)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x325D);
    // PUSH AX (0170_325C / 0x495C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3262);
    // CALLF 0x1000:8f6d (0170_325D / 0x495D)
    FarCall(cs2, 0x3262, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs2, 0x3265);
    // ADD SP,0x8 (0170_3262 / 0x4962)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x3269);
    // MOV ES,word ptr [0x53a0] (0170_3265 / 0x4965)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x326F);
    // CMP word ptr ES:[0x4fba],0x2 (0170_3269 / 0x4969)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0x3271);
    // JNZ 0x0000:4987 (0170_326F / 0x496F)
    if(!ZeroFlag) {
      goto label_0170_3287_04987;
    }
    CheckExternalEvents(cs2, 0x3274);
    // MOV AX,0x780 (0170_3271 / 0x4971)
    AX = 0x780;
    CheckExternalEvents(cs2, 0x3275);
    // PUSH AX (0170_3274 / 0x4974)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3278);
    // MOV AX,0x4694 (0170_3275 / 0x4975)
    AX = 0x4694;
    CheckExternalEvents(cs2, 0x327B);
    // MOV DX,0x2a02 (0170_3278 / 0x4978)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x327C);
    // PUSH DX (0170_327B / 0x497B)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x327D);
    // PUSH AX (0170_327C / 0x497C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x327E);
    // PUSH DX (0170_327D / 0x497D)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x327F);
    // PUSH AX (0170_327E / 0x497E)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3284);
    // CALLF 0x1000:a462 (0170_327F / 0x497F)
    FarCall(cs2, 0x3284, unknown_19EF_0572_1A462);
    CheckExternalEvents(cs2, 0x3287);
    // ADD SP,0xa (0170_3284 / 0x4984)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    label_0170_3287_04987:
    CheckExternalEvents(cs2, 0x328A);
    // MOV AX,0x780 (0170_3287 / 0x4987)
    AX = 0x780;
    CheckExternalEvents(cs2, 0x328B);
    // PUSH AX (0170_328A / 0x498A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x328E);
    // MOV AX,0xd582 (0170_328B / 0x498B)
    AX = 0xD582;
    CheckExternalEvents(cs2, 0x3291);
    // MOV DX,0x2a02 (0170_328E / 0x498E)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x3292);
    // PUSH DX (0170_3291 / 0x4991)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x3293);
    // PUSH AX (0170_3292 / 0x4992)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3296);
    // MOV AX,0x4694 (0170_3293 / 0x4993)
    AX = 0x4694;
    CheckExternalEvents(cs2, 0x3299);
    // MOV DX,0x2a02 (0170_3296 / 0x4996)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x329A);
    // PUSH DX (0170_3299 / 0x4999)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x329B);
    // PUSH AX (0170_329A / 0x499A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x32A0);
    // CALLF 0x1000:a966 (0170_329B / 0x499B)
    FarCall(cs2, 0x32A0, unknown_19EF_0A76_1A966);
    CheckExternalEvents(cs2, 0x32A3);
    // ADD SP,0xa (0170_32A0 / 0x49A0)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    CheckExternalEvents(cs2, 0x32A4);
    // PUSH CS (0170_32A3 / 0x49A3)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x32A7);
    // CALL 0x0000:5d21 (0170_32A4 / 0x49A4)
    NearCall(cs2, 0x32A7, unknown_0170_4621_05D21);
    CheckExternalEvents(cs2, 0x32AA);
    // MOV AX,0x1 (0170_32A7 / 0x49A7)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x32AB);
    // PUSH AX (0170_32AA / 0x49AA)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x32AC);
    // PUSH CS (0170_32AB / 0x49AB)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x32AF);
    // CALL 0x0000:3fcc (0170_32AC / 0x49AC)
    NearCall(cs2, 0x32AF, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs2, 0x32B2);
    // ADD SP,0x2 (0170_32AF / 0x49AF)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs2, 0x32B3);
    // RETF  (0170_32B2 / 0x49B2)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_49B3_049B3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_49B3_049B3:
    CheckExternalEvents(cs1, 0x49B4);
    // PUSH BP (0000_49B3 / 0x49B3)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x49B6);
    // MOV BP,SP (0000_49B4 / 0x49B4)
    BP = SP;
    CheckExternalEvents(cs1, 0x49B9);
    // MOV AX,0xc (0000_49B6 / 0x49B6)
    AX = 0xC;
    CheckExternalEvents(cs1, 0x49BE);
    // CALLF 0x1000:cecc (0000_49B9 / 0x49B9)
    FarCall(cs1, 0x49BE, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x49BF);
    // PUSH SI (0000_49BE / 0x49BE)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x49C2);
    // MOV AX,0x3 (0000_49BF / 0x49BF)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x49C3);
    // PUSH AX (0000_49C2 / 0x49C2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x49C8);
    // CALLF 0x1000:7ee1 (0000_49C3 / 0x49C3)
    FarCall(cs1, 0x49C8, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x49CB);
    // ADD SP,0x2 (0000_49C8 / 0x49C8)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x49D0);
    // CALLF 0x1000:7fe8 (0000_49CB / 0x49CB)
    FarCall(cs1, 0x49D0, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x49D3);
    // MOV AX,0x5c7 (0000_49D0 / 0x49D0)
    AX = 0x5C7;
    CheckExternalEvents(cs1, 0x49D4);
    // PUSH DS (0000_49D3 / 0x49D3)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x49D5);
    // PUSH AX (0000_49D4 / 0x49D4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x49DA);
    // CALLF 0x1000:8055 (0000_49D5 / 0x49D5)
    FarCall(cs1, 0x49DA, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x49DD);
    // ADD SP,0x4 (0000_49DA / 0x49DA)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x49E0);
    // MOV AX,0x28 (0000_49DD / 0x49DD)
    AX = 0x28;
    CheckExternalEvents(cs1, 0x49E1);
    // PUSH AX (0000_49E0 / 0x49E0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x49E6);
    // CALLF 0x1000:87be (0000_49E1 / 0x49E1)
    FarCall(cs1, 0x49E6, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0x49E9);
    // ADD SP,0x2 (0000_49E6 / 0x49E6)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x49EC);
    // MOV word ptr [BP + -0x4],AX (0000_49E9 / 0x49E9)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x49EF);
    // CMP AX,0x6 (0000_49EC / 0x49EC)
    Alu16.Sub(AX, 0x6);
    CheckExternalEvents(cs1, 0x49F1);
    // JNZ 0x0000:49f4 (0000_49EF / 0x49EF)
    if(!ZeroFlag) {
      goto label_0000_49F4_049F4;
    }
    CheckExternalEvents(cs1, 0x49F4);
    // JMP 0x0000:4cad (0000_49F1 / 0x49F1)
    goto label_0000_4CAD_04CAD;
    label_0000_49F4_049F4:
    CheckExternalEvents(cs1, 0x49F7);
    // MOV AL,byte ptr [BP + -0x4] (0000_49F4 / 0x49F4)
    AL = UInt8[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0x49F9);
    // ADD AL,0x31 (0000_49F7 / 0x49F7)
    // AL += 0x31;
    AL = Alu8.Add(AL, 0x31);
    CheckExternalEvents(cs1, 0x49FC);
    // MOV [0x158],AL (0000_49F9 / 0x49F9)
    UInt8[DS, 0x158] = AL;
    CheckExternalEvents(cs1, 0x49FF);
    // MOV AX,0x3 (0000_49FC / 0x49FC)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x4A00);
    // PUSH AX (0000_49FF / 0x49FF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4A01);
    // PUSH CS (0000_4A00 / 0x4A00)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4A04);
    // CALL 0x0000:3fcc (0000_4A01 / 0x4A01)
    NearCall(cs1, 0x4A04, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0x4A06);
    // JMP 0x0000:4a0e (0000_4A04 / 0x4A04)
    goto label_0000_4A0E_04A0E;
    label_0000_4A06_04A06:
    CheckExternalEvents(cs1, 0x4A0A);
    // PUSH word ptr [0x14e] (0000_4A06 / 0x4A06)
    Stack.Push16(UInt16[DS, 0x14E]);
    CheckExternalEvents(cs1, 0x4A0B);
    // PUSH CS (0000_4A0A / 0x4A0A)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4A0E);
    // CALL 0x0000:4013 (0000_4A0B / 0x4A0B)
    NearCall(cs1, 0x4A0E, unknown_0170_2913_04013);
    label_0000_4A0E_04A0E:
    CheckExternalEvents(cs1, 0x4A11);
    // ADD SP,0x2 (0000_4A0E / 0x4A0E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4A14);
    // MOV AX,0x8000 (0000_4A11 / 0x4A11)
    AX = 0x8000;
    CheckExternalEvents(cs1, 0x4A15);
    // PUSH AX (0000_4A14 / 0x4A14)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4A18);
    // MOV AX,0x5f5 (0000_4A15 / 0x4A15)
    AX = 0x5F5;
    CheckExternalEvents(cs1, 0x4A19);
    // PUSH DS (0000_4A18 / 0x4A18)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4A1A);
    // PUSH AX (0000_4A19 / 0x4A19)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4A1F);
    // CALLF 0x1000:d2c0 (0000_4A1A / 0x4A1A)
    FarCall(cs1, 0x4A1F, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs1, 0x4A22);
    // ADD SP,0x6 (0000_4A1F / 0x4A1F)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs1, 0x4A25);
    // MOV word ptr [BP + -0xc],AX (0000_4A22 / 0x4A22)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0x4A26);
    // INC AX (0000_4A25 / 0x4A25)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs1, 0x4A28);
    // JZ 0x0000:4a06 (0000_4A26 / 0x4A26)
    if(ZeroFlag) {
      goto label_0000_4A06_04A06;
    }
    CheckExternalEvents(cs1, 0x4A2B);
    // PUSH word ptr [BP + -0xc] (0000_4A28 / 0x4A28)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x4A30);
    // CALLF 0x1000:d226 (0000_4A2B / 0x4A2B)
    FarCall(cs1, 0x4A30, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs1, 0x4A33);
    // ADD SP,0x2 (0000_4A30 / 0x4A30)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4A36);
    // MOV AX,0x8000 (0000_4A33 / 0x4A33)
    AX = 0x8000;
    CheckExternalEvents(cs1, 0x4A37);
    // PUSH AX (0000_4A36 / 0x4A36)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4A3A);
    // MOV AX,0x154 (0000_4A37 / 0x4A37)
    AX = 0x154;
    CheckExternalEvents(cs1, 0x4A3B);
    // PUSH DS (0000_4A3A / 0x4A3A)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4A3C);
    // PUSH AX (0000_4A3B / 0x4A3B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4A41);
    // CALLF 0x1000:d2c0 (0000_4A3C / 0x4A3C)
    FarCall(cs1, 0x4A41, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs1, 0x4A44);
    // ADD SP,0x6 (0000_4A41 / 0x4A41)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs1, 0x4A47);
    // MOV word ptr [BP + -0xc],AX (0000_4A44 / 0x4A44)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0x4A4A);
    // CMP AX,0xffff (0000_4A47 / 0x4A47)
    Alu16.Sub(AX, 0xFFFF);
    CheckExternalEvents(cs1, 0x4A4C);
    // JNZ 0x0000:4a4f (0000_4A4A / 0x4A4A)
    if(!ZeroFlag) {
      goto label_0000_4A4F_04A4F;
    }
    CheckExternalEvents(cs1, 0x4A4F);
    // JMP 0x0000:4c71 (0000_4A4C / 0x4A4C)
    goto label_0000_4C71_04C71;
    label_0000_4A4F_04A4F:
    CheckExternalEvents(cs1, 0x4A52);
    // MOV AX,0x1 (0000_4A4F / 0x4A4F)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x4A53);
    // PUSH AX (0000_4A52 / 0x4A52)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4A56);
    // LEA AX,[BP + -0x2] (0000_4A53 / 0x4A53)
    AX = (ushort)(BP - 0x2);
    CheckExternalEvents(cs1, 0x4A57);
    // PUSH SS (0000_4A56 / 0x4A56)
    Stack.Push16(SS);
    CheckExternalEvents(cs1, 0x4A58);
    // PUSH AX (0000_4A57 / 0x4A57)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4A5B);
    // PUSH word ptr [BP + -0xc] (0000_4A58 / 0x4A58)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x4A60);
    // CALLF 0x1000:d470 (0000_4A5B / 0x4A5B)
    FarCall(cs1, 0x4A60, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs1, 0x4A63);
    // ADD SP,0x8 (0000_4A60 / 0x4A60)
    SP += 0x8;
    CheckExternalEvents(cs1, 0x4A67);
    // CMP byte ptr [BP + -0x2],0xc (0000_4A63 / 0x4A63)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x2)], 0xC);
    CheckExternalEvents(cs1, 0x4A69);
    // JZ 0x0000:4a83 (0000_4A67 / 0x4A67)
    if(ZeroFlag) {
      goto label_0000_4A83_04A83;
    }
    CheckExternalEvents(cs1, 0x4A6E);
    // CALLF 0x1000:7fe8 (0000_4A69 / 0x4A69)
    FarCall(cs1, 0x4A6E, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x4A71);
    // MOV AX,0x601 (0000_4A6E / 0x4A6E)
    AX = 0x601;
    CheckExternalEvents(cs1, 0x4A72);
    // PUSH DS (0000_4A71 / 0x4A71)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4A73);
    // PUSH AX (0000_4A72 / 0x4A72)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4A78);
    // CALLF 0x1000:8055 (0000_4A73 / 0x4A73)
    FarCall(cs1, 0x4A78, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4A7B);
    // ADD SP,0x4 (0000_4A78 / 0x4A78)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4A80);
    // CALLF 0x1000:8d29 (0000_4A7B / 0x4A7B)
    FarCall(cs1, 0x4A80, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0x4A83);
    // JMP 0x0000:4bd3 (0000_4A80 / 0x4A80)
    goto label_0000_4BD3_04BD3;
    label_0000_4A83_04A83:
    CheckExternalEvents(cs1, 0x4A87);
    // MOV ES,word ptr [0x53d0] (0000_4A83 / 0x4A83)
    ES = UInt16[DS, 0x53D0];
    CheckExternalEvents(cs1, 0x4A8D);
    // MOV byte ptr ES:[0xfc],0x1 (0000_4A87 / 0x4A87)
    UInt8[ES, 0xFC] = 0x1;
    CheckExternalEvents(cs1, 0x4A93);
    // MOV byte ptr ES:[0x64],0x0 (0000_4A8D / 0x4A8D)
    UInt8[ES, 0x64] = 0x0;
    CheckExternalEvents(cs1, 0x4A96);
    // MOV AX,0xf44 (0000_4A93 / 0x4A93)
    AX = 0xF44;
    CheckExternalEvents(cs1, 0x4A97);
    // PUSH AX (0000_4A96 / 0x4A96)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4A9A);
    // MOV AX,0xc614 (0000_4A97 / 0x4A97)
    AX = 0xC614;
    CheckExternalEvents(cs1, 0x4A9D);
    // MOV DX,0x2a02 (0000_4A9A / 0x4A9A)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x4A9E);
    // PUSH DX (0000_4A9D / 0x4A9D)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x4A9F);
    // PUSH AX (0000_4A9E / 0x4A9E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4AA2);
    // PUSH word ptr [BP + -0xc] (0000_4A9F / 0x4A9F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x4AA7);
    // CALLF 0x1000:d470 (0000_4AA2 / 0x4AA2)
    FarCall(cs1, 0x4AA7, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs1, 0x4AAA);
    // ADD SP,0x8 (0000_4AA7 / 0x4AA7)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x4AAD);
    // MOV AX,0x2 (0000_4AAA / 0x4AAA)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x4AAE);
    // PUSH AX (0000_4AAD / 0x4AAD)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4AB1);
    // MOV AX,0xa44b (0000_4AAE / 0x4AAE)
    AX = 0xA44B;
    CheckExternalEvents(cs1, 0x4AB4);
    // MOV DX,0x1ddc (0000_4AB1 / 0x4AB1)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x4AB5);
    // PUSH DX (0000_4AB4 / 0x4AB4)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x4AB6);
    // PUSH AX (0000_4AB5 / 0x4AB5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4AB9);
    // PUSH word ptr [BP + -0xc] (0000_4AB6 / 0x4AB6)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x4ABE);
    // CALLF 0x1000:d470 (0000_4AB9 / 0x4AB9)
    FarCall(cs1, 0x4ABE, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs1, 0x4AC1);
    // ADD SP,0x8 (0000_4ABE / 0x4ABE)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x4AC4);
    // MOV AX,0x2 (0000_4AC1 / 0x4AC1)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x4AC5);
    // PUSH AX (0000_4AC4 / 0x4AC4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4AC8);
    // MOV AX,0xa44d (0000_4AC5 / 0x4AC5)
    AX = 0xA44D;
    CheckExternalEvents(cs1, 0x4ACB);
    // MOV DX,0x1ddc (0000_4AC8 / 0x4AC8)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x4ACC);
    // PUSH DX (0000_4ACB / 0x4ACB)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x4ACD);
    // PUSH AX (0000_4ACC / 0x4ACC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4AD0);
    // PUSH word ptr [BP + -0xc] (0000_4ACD / 0x4ACD)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x4AD5);
    // CALLF 0x1000:d470 (0000_4AD0 / 0x4AD0)
    FarCall(cs1, 0x4AD5, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs1, 0x4AD8);
    // ADD SP,0x8 (0000_4AD5 / 0x4AD5)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x4ADB);
    // PUSH word ptr [BP + -0xc] (0000_4AD8 / 0x4AD8)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x4AE0);
    // CALLF 0x1000:d226 (0000_4ADB / 0x4ADB)
    FarCall(cs1, 0x4AE0, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs1, 0x4AE3);
    // ADD SP,0x2 (0000_4AE0 / 0x4AE0)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4AE8);
    // MOV word ptr [BP + -0x6],0x0 (0000_4AE3 / 0x4AE3)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_0000_4AE8_04AE8:
    CheckExternalEvents(cs1, 0x4AEB);
    // MOV BX,word ptr [BP + -0x6] (0000_4AE8 / 0x4AE8)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x4AEF);
    // MOV ES,word ptr [0x53ea] (0000_4AEB / 0x4AEB)
    ES = UInt16[DS, 0x53EA];
    CheckExternalEvents(cs1, 0x4AF5);
    // MOV byte ptr ES:[BX + 0x45de],0x0 (0000_4AEF / 0x4AEF)
    UInt8[ES, (ushort)(BX + 0x45DE)] = 0x0;
    CheckExternalEvents(cs1, 0x4AF8);
    // INC word ptr [BP + -0x6] (0000_4AF5 / 0x4AF5)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs1, 0x4AFC);
    // CMP word ptr [BP + -0x6],0x21 (0000_4AF8 / 0x4AF8)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x21);
    CheckExternalEvents(cs1, 0x4AFE);
    // JL 0x0000:4ae8 (0000_4AFC / 0x4AFC)
    if(SignFlag != OverflowFlag) {
      goto label_0000_4AE8_04AE8;
    }
    CheckExternalEvents(cs1, 0x4B02);
    // MOV ES,word ptr [0x538a] (0000_4AFE / 0x4AFE)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4B06);
    // MOV AL,ES:[0xd35b] (0000_4B02 / 0x4B02)
    AL = UInt8[ES, 0xD35B];
    CheckExternalEvents(cs1, 0x4B07);
    // CBW  (0000_4B06 / 0x4B06)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x4B0B);
    // MOV ES,word ptr [0x53e6] (0000_4B07 / 0x4B07)
    ES = UInt16[DS, 0x53E6];
    CheckExternalEvents(cs1, 0x4B0F);
    // MOV ES:[0x2f8],AX (0000_4B0B / 0x4B0B)
    UInt16[ES, 0x2F8] = AX;
    CheckExternalEvents(cs1, 0x4B13);
    // MOV ES,word ptr [0x538a] (0000_4B0F / 0x4B0F)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4B19);
    // CMP byte ptr ES:[0xd310],0x0 (0000_4B13 / 0x4B13)
    Alu8.Sub(UInt8[ES, 0xD310], 0x0);
    CheckExternalEvents(cs1, 0x4B1B);
    // JZ 0x0000:4b25 (0000_4B19 / 0x4B19)
    if(ZeroFlag) {
      goto label_0000_4B25_04B25;
    }
    CheckExternalEvents(cs1, 0x4B1F);
    // MOV ES,word ptr [0x53d0] (0000_4B1B / 0x4B1B)
    ES = UInt16[DS, 0x53D0];
    CheckExternalEvents(cs1, 0x4B25);
    // MOV byte ptr ES:[0xfc],0xb (0000_4B1F / 0x4B1F)
    UInt8[ES, 0xFC] = 0xB;
    label_0000_4B25_04B25:
    CheckExternalEvents(cs1, 0x4B29);
    // MOV ES,word ptr [0x538a] (0000_4B25 / 0x4B25)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4B2F);
    // CMP byte ptr ES:[0xd33e],0x0 (0000_4B29 / 0x4B29)
    Alu8.Sub(UInt8[ES, 0xD33E], 0x0);
    CheckExternalEvents(cs1, 0x4B31);
    // JZ 0x0000:4b3b (0000_4B2F / 0x4B2F)
    if(ZeroFlag) {
      goto label_0000_4B3B_04B3B;
    }
    CheckExternalEvents(cs1, 0x4B35);
    // MOV ES,word ptr [0x53d0] (0000_4B31 / 0x4B31)
    ES = UInt16[DS, 0x53D0];
    CheckExternalEvents(cs1, 0x4B3B);
    // MOV byte ptr ES:[0x64],0xc (0000_4B35 / 0x4B35)
    UInt8[ES, 0x64] = 0xC;
    label_0000_4B3B_04B3B:
    CheckExternalEvents(cs1, 0x4B3F);
    // MOV ES,word ptr [0x538a] (0000_4B3B / 0x4B3B)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4B45);
    // CMP byte ptr ES:[0xd346],0x0 (0000_4B3F / 0x4B3F)
    Alu8.Sub(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs1, 0x4B47);
    // JZ 0x0000:4b4a (0000_4B45 / 0x4B45)
    if(ZeroFlag) {
      goto label_0000_4B4A_04B4A;
    }
    CheckExternalEvents(cs1, 0x4B4A);
    // JMP 0x0000:4bce (0000_4B47 / 0x4B47)
    goto label_0000_4BCE_04BCE;
    label_0000_4B4A_04B4A:
    CheckExternalEvents(cs1, 0x4B4E);
    // MOV ES,word ptr [0x538c] (0000_4B4A / 0x4B4A)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x4B52);
    // MOV AX,ES:[0xa44b] (0000_4B4E / 0x4B4E)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x4B56);
    // MOV ES,word ptr [0x538e] (0000_4B52 / 0x4B52)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x4B5B);
    // OR AX,word ptr ES:[0xa44d] (0000_4B56 / 0x4B56)
    // AX |= UInt16[ES, 0xA44D];
    AX = Alu16.Or(AX, UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0x4B5D);
    // MOV CL,0x8 (0000_4B5B / 0x4B5B)
    CL = 0x8;
    CheckExternalEvents(cs1, 0x4B5F);
    // SHR AX,CL (0000_4B5D / 0x4B5D)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs1, 0x4B62);
    // MOV word ptr [BP + -0x4],AX (0000_4B5F / 0x4B5F)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x4B66);
    // MOV byte ptr [BP + -0x3],0x0 (0000_4B62 / 0x4B62)
    UInt8[SS, (ushort)(BP - 0x3)] = 0x0;
    CheckExternalEvents(cs1, 0x4B69);
    // PUSH word ptr [BP + -0x4] (0000_4B66 / 0x4B66)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x4B6E);
    // CALLF 0x1000:af3e (0000_4B69 / 0x4B69)
    FarCall(cs1, 0x4B6E, unknown_19EF_104E_1AF3E);
    CheckExternalEvents(cs1, 0x4B71);
    // ADD SP,0x2 (0000_4B6E / 0x4B6E)
    SP += 0x2;
    CheckExternalEvents(cs1, 0x4B75);
    // SUB word ptr [BP + -0x4],0x11 (0000_4B71 / 0x4B71)
    // UInt16[SS, (ushort)(BP - 0x4)] -= 0x11;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x11);
    CheckExternalEvents(cs1, 0x4B7A);
    // MOV word ptr [BP + -0xa],0x0 (0000_4B75 / 0x4B75)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    label_0000_4B7A_04B7A:
    CheckExternalEvents(cs1, 0x4B7F);
    // MOV word ptr [BP + -0x6],0x0 (0000_4B7A / 0x4B7A)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_0000_4B7F_04B7F:
    CheckExternalEvents(cs1, 0x4B82);
    // MOV SI,word ptr [BP + -0x4] (0000_4B7F / 0x4B7F)
    SI = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0x4B85);
    // ADD SI,word ptr [BP + -0x6] (0000_4B82 / 0x4B82)
    // SI += UInt16[SS, (ushort)(BP - 0x6)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x4B87);
    // JS 0x0000:4bb1 (0000_4B85 / 0x4B85)
    if(SignFlag) {
      goto label_0000_4BB1_04BB1;
    }
    CheckExternalEvents(cs1, 0x4B8B);
    // CMP SI,0x100 (0000_4B87 / 0x4B87)
    Alu16.Sub(SI, 0x100);
    CheckExternalEvents(cs1, 0x4B8D);
    // JGE 0x0000:4bb1 (0000_4B8B / 0x4B8B)
    if(SignFlag == OverflowFlag) {
      goto label_0000_4BB1_04BB1;
    }
    CheckExternalEvents(cs1, 0x4B91);
    // MOV ES,word ptr [0x53d0] (0000_4B8D / 0x4B8D)
    ES = UInt16[DS, 0x53D0];
    CheckExternalEvents(cs1, 0x4B97);
    // CMP byte ptr ES:[SI + 0x30],0x0 (0000_4B91 / 0x4B91)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0x30)], 0x0);
    CheckExternalEvents(cs1, 0x4B99);
    // JZ 0x0000:4bb1 (0000_4B97 / 0x4B97)
    if(ZeroFlag) {
      goto label_0000_4BB1_04BB1;
    }
    CheckExternalEvents(cs1, 0x4B9E);
    // MOV AL,byte ptr ES:[SI + 0x30] (0000_4B99 / 0x4B99)
    AL = UInt8[ES, (ushort)(SI + 0x30)];
    CheckExternalEvents(cs1, 0x4B9F);
    // CBW  (0000_4B9E / 0x4B9E)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x4BA0);
    // PUSH AX (0000_4B9F / 0x4B9F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4BA3);
    // MOV AX,0x3 (0000_4BA0 / 0x4BA0)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x4BA6);
    // IMUL word ptr [BP + -0xa] (0000_4BA3 / 0x4BA3)
    int resImul0000_4BA3 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_4BA3);
    DX = (ushort)(resImul0000_4BA3 >> 16);
    CheckExternalEvents(cs1, 0x4BA9);
    // ADD AX,word ptr [BP + -0x6] (0000_4BA6 / 0x4BA6)
    // AX += UInt16[SS, (ushort)(BP - 0x6)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x4BAA);
    // PUSH AX (0000_4BA9 / 0x4BA9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4BAB);
    // PUSH CS (0000_4BAA / 0x4BAA)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4BAE);
    // CALL 0x0000:44a8 (0000_4BAB / 0x4BAB)
    NearCall(cs1, 0x4BAE, unknown_0170_2DA8_044A8);
    CheckExternalEvents(cs1, 0x4BB1);
    // ADD SP,0x4 (0000_4BAE / 0x4BAE)
    SP += 0x4;
    label_0000_4BB1_04BB1:
    CheckExternalEvents(cs1, 0x4BB4);
    // INC word ptr [BP + -0x6] (0000_4BB1 / 0x4BB1)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs1, 0x4BB8);
    // CMP word ptr [BP + -0x6],0x3 (0000_4BB4 / 0x4BB4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x3);
    CheckExternalEvents(cs1, 0x4BBA);
    // JL 0x0000:4b7f (0000_4BB8 / 0x4BB8)
    if(SignFlag != OverflowFlag) {
      goto label_0000_4B7F_04B7F;
    }
    CheckExternalEvents(cs1, 0x4BBE);
    // ADD word ptr [BP + -0x4],0x10 (0000_4BBA / 0x4BBA)
    UInt16[SS, (ushort)(BP - 0x4)] += 0x10;
    CheckExternalEvents(cs1, 0x4BC1);
    // INC word ptr [BP + -0xa] (0000_4BBE / 0x4BBE)
    UInt16[SS, (ushort)(BP - 0xA)]++;
    CheckExternalEvents(cs1, 0x4BC5);
    // CMP word ptr [BP + -0xa],0x3 (0000_4BC1 / 0x4BC1)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x3);
    CheckExternalEvents(cs1, 0x4BC7);
    // JL 0x0000:4b7a (0000_4BC5 / 0x4BC5)
    if(SignFlag != OverflowFlag) {
      goto label_0000_4B7A_04B7A;
    }
    CheckExternalEvents(cs1, 0x4BCC);
    // CALLF 0x1000:bc98 (0000_4BC7 / 0x4BC7)
    FarCall(cs1, 0x4BCC, unknown_19EF_1DA8_1BC98);
    CheckExternalEvents(cs1, 0x4BCE);
    // JMP 0x0000:4bd3 (0000_4BCC / 0x4BCC)
    goto label_0000_4BD3_04BD3;
    label_0000_4BCE_04BCE:
    CheckExternalEvents(cs1, 0x4BD3);
    // CALLF 0x0000:ccd4 (0000_4BCE / 0x4BCE)
    FarCall(cs1, 0x4BD3, ghidra_guess_0000_CCD4_0CCD4);
    label_0000_4BD3_04BD3:
    CheckExternalEvents(cs1, 0x4BD8);
    // MOV word ptr [BP + -0x8],0x0 (0000_4BD3 / 0x4BD3)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    label_0000_4BD8_04BD8:
    CheckExternalEvents(cs1, 0x4BDB);
    // MOV BX,word ptr [BP + -0x8] (0000_4BD8 / 0x4BD8)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0x4BDF);
    // MOV ES,word ptr [0x539c] (0000_4BDB / 0x4BDB)
    ES = UInt16[DS, 0x539C];
    CheckExternalEvents(cs1, 0x4BE5);
    // MOV byte ptr ES:[BX + 0xd55e],0x0 (0000_4BDF / 0x4BDF)
    UInt8[ES, (ushort)(BX + 0xD55E)] = 0x0;
    CheckExternalEvents(cs1, 0x4BE8);
    // MOV AX,0x7d (0000_4BE5 / 0x4BE5)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x4BEB);
    // IMUL word ptr [BP + -0x8] (0000_4BE8 / 0x4BE8)
    int resImul0000_4BE8 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x8)]);
    AX = (ushort)(resImul0000_4BE8);
    DX = (ushort)(resImul0000_4BE8 >> 16);
    CheckExternalEvents(cs1, 0x4BED);
    // MOV BX,AX (0000_4BEB / 0x4BEB)
    BX = AX;
    CheckExternalEvents(cs1, 0x4BF1);
    // MOV ES,word ptr [0x538a] (0000_4BED / 0x4BED)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4BF7);
    // CMP byte ptr ES:[BX + 0xc724],0x4c (0000_4BF1 / 0x4BF1)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0x4C);
    CheckExternalEvents(cs1, 0x4BF9);
    // JZ 0x0000:4c06 (0000_4BF7 / 0x4BF7)
    if(ZeroFlag) {
      goto label_0000_4C06_04C06;
    }
    CheckExternalEvents(cs1, 0x4BFC);
    // MOV BX,word ptr [BP + -0x8] (0000_4BF9 / 0x4BF9)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0x4C00);
    // MOV ES,word ptr [0x539c] (0000_4BFC / 0x4BFC)
    ES = UInt16[DS, 0x539C];
    CheckExternalEvents(cs1, 0x4C06);
    // MOV byte ptr ES:[BX + 0xd55e],0x92 (0000_4C00 / 0x4C00)
    UInt8[ES, (ushort)(BX + 0xD55E)] = 0x92;
    label_0000_4C06_04C06:
    CheckExternalEvents(cs1, 0x4C09);
    // MOV BX,word ptr [BP + -0x8] (0000_4C06 / 0x4C06)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0x4C0D);
    // MOV ES,word ptr [0x539a] (0000_4C09 / 0x4C09)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs1, 0x4C13);
    // MOV byte ptr ES:[BX + 0x409a],0x0 (0000_4C0D / 0x4C0D)
    UInt8[ES, (ushort)(BX + 0x409A)] = 0x0;
    CheckExternalEvents(cs1, 0x4C15);
    // SUB AL,AL (0000_4C13 / 0x4C13)
    // AL -= AL;
    AL = Alu8.Sub(AL, AL);
    CheckExternalEvents(cs1, 0x4C18);
    // MOV BX,word ptr [BP + -0x8] (0000_4C15 / 0x4C15)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0x4C1C);
    // MOV ES,word ptr [0x53d8] (0000_4C18 / 0x4C18)
    ES = UInt16[DS, 0x53D8];
    CheckExternalEvents(cs1, 0x4C21);
    // MOV byte ptr ES:[BX + 0x3920],AL (0000_4C1C / 0x4C1C)
    UInt8[ES, (ushort)(BX + 0x3920)] = AL;
    CheckExternalEvents(cs1, 0x4C24);
    // MOV BX,word ptr [BP + -0x8] (0000_4C21 / 0x4C21)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0x4C28);
    // MOV ES,word ptr [0x53be] (0000_4C24 / 0x4C24)
    ES = UInt16[DS, 0x53BE];
    CheckExternalEvents(cs1, 0x4C2D);
    // MOV byte ptr ES:[BX + 0x396c],AL (0000_4C28 / 0x4C28)
    UInt8[ES, (ushort)(BX + 0x396C)] = AL;
    CheckExternalEvents(cs1, 0x4C30);
    // MOV BX,word ptr [BP + -0x8] (0000_4C2D / 0x4C2D)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0x4C32);
    // SHL BX,0x1 (0000_4C30 / 0x4C30)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x4C34);
    // SHL BX,0x1 (0000_4C32 / 0x4C32)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x4C3A);
    // MOV word ptr [BX + 0x1f6],0x270 (0000_4C34 / 0x4C34)
    UInt16[DS, (ushort)(BX + 0x1F6)] = 0x270;
    CheckExternalEvents(cs1, 0x4C40);
    // MOV word ptr [BX + 0x1f8],0x2958 (0000_4C3A / 0x4C3A)
    UInt16[DS, (ushort)(BX + 0x1F8)] = 0x2958;
    CheckExternalEvents(cs1, 0x4C43);
    // INC word ptr [BP + -0x8] (0000_4C40 / 0x4C40)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    CheckExternalEvents(cs1, 0x4C47);
    // CMP word ptr [BP + -0x8],0x4 (0000_4C43 / 0x4C43)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x4);
    CheckExternalEvents(cs1, 0x4C49);
    // JL 0x0000:4bd8 (0000_4C47 / 0x4C47)
    if(SignFlag != OverflowFlag) {
      goto label_0000_4BD8_04BD8;
    }
    CheckExternalEvents(cs1, 0x4C4D);
    // MOV ES,word ptr [0x53ec] (0000_4C49 / 0x4C49)
    ES = UInt16[DS, 0x53EC];
    CheckExternalEvents(cs1, 0x4C54);
    // MOV word ptr ES:[0x374a],0x0 (0000_4C4D / 0x4C4D)
    UInt16[ES, 0x374A] = 0x0;
    CheckExternalEvents(cs1, 0x4C58);
    // MOV ES,word ptr [0x538a] (0000_4C54 / 0x4C54)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4C5D);
    // CMP byte ptr ES:[0xd346],AL (0000_4C58 / 0x4C58)
    Alu8.Sub(UInt8[ES, 0xD346], AL);
    CheckExternalEvents(cs1, 0x4C5F);
    // JNZ 0x0000:4cad (0000_4C5D / 0x4C5D)
    if(!ZeroFlag) {
      goto label_0000_4CAD_04CAD;
    }
    CheckExternalEvents(cs1, 0x4C63);
    // MOV ES,word ptr [0x53d2] (0000_4C5F / 0x4C5F)
    ES = UInt16[DS, 0x53D2];
    CheckExternalEvents(cs1, 0x4C69);
    // CMP word ptr ES:[0x3988],0x2 (0000_4C63 / 0x4C63)
    Alu16.Sub(UInt16[ES, 0x3988], 0x2);
    CheckExternalEvents(cs1, 0x4C6B);
    // JNZ 0x0000:4cad (0000_4C69 / 0x4C69)
    if(!ZeroFlag) {
      goto label_0000_4CAD_04CAD;
    }
    CheckExternalEvents(cs1, 0x4C6C);
    // PUSH CS (0000_4C6B / 0x4C6B)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4C6F);
    // CALL 0x0000:5d21 (0000_4C6C / 0x4C6C)
    NearCall(cs1, 0x4C6F, unknown_0170_4621_05D21);
    CheckExternalEvents(cs1, 0x4C71);
    // JMP 0x0000:4cad (0000_4C6F / 0x4C6F)
    goto label_0000_4CAD_04CAD;
    label_0000_4C71_04C71:
    CheckExternalEvents(cs1, 0x4C76);
    // CALLF 0x1000:7fe8 (0000_4C71 / 0x4C71)
    FarCall(cs1, 0x4C76, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x4C79);
    // MOV AX,0x640 (0000_4C76 / 0x4C76)
    AX = 0x640;
    CheckExternalEvents(cs1, 0x4C7A);
    // PUSH DS (0000_4C79 / 0x4C79)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4C7B);
    // PUSH AX (0000_4C7A / 0x4C7A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4C80);
    // CALLF 0x1000:8055 (0000_4C7B / 0x4C7B)
    FarCall(cs1, 0x4C80, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4C83);
    // ADD SP,0x4 (0000_4C80 / 0x4C80)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4C87);
    // MOV ES,word ptr [0x5388] (0000_4C83 / 0x4C83)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs1, 0x4C8E);
    // MOV word ptr ES:[0x37fe],0x2 (0000_4C87 / 0x4C87)
    UInt16[ES, 0x37FE] = 0x2;
    CheckExternalEvents(cs1, 0x4C91);
    // MOV AX,0x154 (0000_4C8E / 0x4C8E)
    AX = 0x154;
    CheckExternalEvents(cs1, 0x4C92);
    // PUSH DS (0000_4C91 / 0x4C91)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4C93);
    // PUSH AX (0000_4C92 / 0x4C92)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4C98);
    // CALLF 0x1000:8055 (0000_4C93 / 0x4C93)
    FarCall(cs1, 0x4C98, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4C9B);
    // ADD SP,0x4 (0000_4C98 / 0x4C98)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4C9E);
    // MOV AX,0x658 (0000_4C9B / 0x4C9B)
    AX = 0x658;
    CheckExternalEvents(cs1, 0x4C9F);
    // PUSH DS (0000_4C9E / 0x4C9E)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4CA0);
    // PUSH AX (0000_4C9F / 0x4C9F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4CA5);
    // CALLF 0x1000:8055 (0000_4CA0 / 0x4CA0)
    FarCall(cs1, 0x4CA5, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4CA8);
    // ADD SP,0x4 (0000_4CA5 / 0x4CA5)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4CAD);
    // CALLF 0x1000:8d29 (0000_4CA8 / 0x4CA8)
    FarCall(cs1, 0x4CAD, unknown_18AD_0259_18D29);
    label_0000_4CAD_04CAD:
    CheckExternalEvents(cs1, 0x4CAF);
    // SUB AX,AX (0000_4CAD / 0x4CAD)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x4CB0);
    // PUSH AX (0000_4CAF / 0x4CAF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4CB5);
    // CALLF 0x0000:fd3f (0000_4CB0 / 0x4CB0)
    FarCall(cs1, 0x4CB5, ghidra_guess_0000_FD3F_0FD3F);
    CheckExternalEvents(cs1, 0x4CB8);
    // ADD SP,0x2 (0000_4CB5 / 0x4CB5)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4CBB);
    // MOV AX,0x1 (0000_4CB8 / 0x4CB8)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x4CBC);
    // PUSH AX (0000_4CBB / 0x4CBB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4CBD);
    // PUSH CS (0000_4CBC / 0x4CBC)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4CC0);
    // CALL 0x0000:63ac (0000_4CBD / 0x4CBD)
    NearCall(cs1, 0x4CC0, unknown_0170_4CAC_063AC);
    CheckExternalEvents(cs1, 0x4CC3);
    // ADD SP,0x2 (0000_4CC0 / 0x4CC0)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4CC6);
    // MOV AX,0x1 (0000_4CC3 / 0x4CC3)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x4CC7);
    // PUSH AX (0000_4CC6 / 0x4CC6)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4CC8);
    // PUSH CS (0000_4CC7 / 0x4CC7)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4CCB);
    // CALL 0x0000:3fcc (0000_4CC8 / 0x4CC8)
    NearCall(cs1, 0x4CCB, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0x4CCE);
    // ADD SP,0x2 (0000_4CCB / 0x4CCB)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4CCF);
    // POP SI (0000_4CCE / 0x4CCE)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x4CD1);
    // MOV SP,BP (0000_4CCF / 0x4CCF)
    SP = BP;
    CheckExternalEvents(cs1, 0x4CD2);
    // POP BP (0000_4CD1 / 0x4CD1)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x4CD3);
    // RETF  (0000_4CD2 / 0x4CD2)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_4CD3_04CD3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_4CD3_04CD3:
    CheckExternalEvents(cs1, 0x4CD4);
    // PUSH BP (0000_4CD3 / 0x4CD3)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x4CD6);
    // MOV BP,SP (0000_4CD4 / 0x4CD4)
    BP = SP;
    CheckExternalEvents(cs1, 0x4CD9);
    // MOV AX,0x8 (0000_4CD6 / 0x4CD6)
    AX = 0x8;
    CheckExternalEvents(cs1, 0x4CDE);
    // CALLF 0x1000:cecc (0000_4CD9 / 0x4CD9)
    FarCall(cs1, 0x4CDE, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x4CE2);
    // MOV ES,word ptr [0x538a] (0000_4CDE / 0x4CDE)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4CE8);
    // CMP byte ptr ES:[0xd34e],0x0 (0000_4CE2 / 0x4CE2)
    Alu8.Sub(UInt8[ES, 0xD34E], 0x0);
    CheckExternalEvents(cs1, 0x4CEA);
    // JZ 0x0000:4ced (0000_4CE8 / 0x4CE8)
    if(ZeroFlag) {
      goto label_0000_4CED_04CED;
    }
    CheckExternalEvents(cs1, 0x4CED);
    // JMP 0x0000:4e54 (0000_4CEA / 0x4CEA)
    goto label_0000_4E54_04E54;
    label_0000_4CED_04CED:
    CheckExternalEvents(cs1, 0x4CF0);
    // MOV AX,0x3 (0000_4CED / 0x4CED)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x4CF1);
    // PUSH AX (0000_4CF0 / 0x4CF0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4CF6);
    // CALLF 0x1000:7ee1 (0000_4CF1 / 0x4CF1)
    FarCall(cs1, 0x4CF6, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x4CF9);
    // ADD SP,0x2 (0000_4CF6 / 0x4CF6)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4CFE);
    // CALLF 0x1000:7fe8 (0000_4CF9 / 0x4CF9)
    FarCall(cs1, 0x4CFE, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x4D01);
    // MOV AX,0x673 (0000_4CFE / 0x4CFE)
    AX = 0x673;
    CheckExternalEvents(cs1, 0x4D02);
    // PUSH DS (0000_4D01 / 0x4D01)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4D03);
    // PUSH AX (0000_4D02 / 0x4D02)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4D08);
    // CALLF 0x1000:8055 (0000_4D03 / 0x4D03)
    FarCall(cs1, 0x4D08, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4D0B);
    // ADD SP,0x4 (0000_4D08 / 0x4D08)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4D0E);
    // MOV AX,0x28 (0000_4D0B / 0x4D0B)
    AX = 0x28;
    CheckExternalEvents(cs1, 0x4D0F);
    // PUSH AX (0000_4D0E / 0x4D0E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4D14);
    // CALLF 0x1000:87be (0000_4D0F / 0x4D0F)
    FarCall(cs1, 0x4D14, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0x4D17);
    // ADD SP,0x2 (0000_4D14 / 0x4D14)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4D1A);
    // MOV word ptr [BP + -0x4],AX (0000_4D17 / 0x4D17)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x4D1D);
    // CMP AX,0x6 (0000_4D1A / 0x4D1A)
    Alu16.Sub(AX, 0x6);
    CheckExternalEvents(cs1, 0x4D1F);
    // JNZ 0x0000:4d22 (0000_4D1D / 0x4D1D)
    if(!ZeroFlag) {
      goto label_0000_4D22_04D22;
    }
    CheckExternalEvents(cs1, 0x4D22);
    // JMP 0x0000:4e6b (0000_4D1F / 0x4D1F)
    goto label_0000_4E6B_04E6B;
    label_0000_4D22_04D22:
    CheckExternalEvents(cs1, 0x4D25);
    // MOV AL,byte ptr [BP + -0x4] (0000_4D22 / 0x4D22)
    AL = UInt8[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0x4D27);
    // ADD AL,0x31 (0000_4D25 / 0x4D25)
    // AL += 0x31;
    AL = Alu8.Add(AL, 0x31);
    CheckExternalEvents(cs1, 0x4D2A);
    // MOV [0x158],AL (0000_4D27 / 0x4D27)
    UInt8[DS, 0x158] = AL;
    CheckExternalEvents(cs1, 0x4D2F);
    // MOV word ptr [BP + -0x6],0x0 (0000_4D2A / 0x4D2A)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    CheckExternalEvents(cs1, 0x4D32);
    // MOV AX,0x3 (0000_4D2F / 0x4D2F)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x4D33);
    // PUSH AX (0000_4D32 / 0x4D32)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4D34);
    // PUSH CS (0000_4D33 / 0x4D33)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4D37);
    // CALL 0x0000:3fcc (0000_4D34 / 0x4D34)
    NearCall(cs1, 0x4D37, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0x4D39);
    // JMP 0x0000:4d41 (0000_4D37 / 0x4D37)
    goto label_0000_4D41_04D41;
    label_0000_4D39_04D39:
    CheckExternalEvents(cs1, 0x4D3D);
    // PUSH word ptr [0x14e] (0000_4D39 / 0x4D39)
    Stack.Push16(UInt16[DS, 0x14E]);
    CheckExternalEvents(cs1, 0x4D3E);
    // PUSH CS (0000_4D3D / 0x4D3D)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4D41);
    // CALL 0x0000:4013 (0000_4D3E / 0x4D3E)
    NearCall(cs1, 0x4D41, unknown_0170_2913_04013);
    label_0000_4D41_04D41:
    CheckExternalEvents(cs1, 0x4D44);
    // ADD SP,0x2 (0000_4D41 / 0x4D41)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4D47);
    // MOV AX,0x8000 (0000_4D44 / 0x4D44)
    AX = 0x8000;
    CheckExternalEvents(cs1, 0x4D48);
    // PUSH AX (0000_4D47 / 0x4D47)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4D4B);
    // MOV AX,0x6a1 (0000_4D48 / 0x4D48)
    AX = 0x6A1;
    CheckExternalEvents(cs1, 0x4D4C);
    // PUSH DS (0000_4D4B / 0x4D4B)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4D4D);
    // PUSH AX (0000_4D4C / 0x4D4C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4D52);
    // CALLF 0x1000:d2c0 (0000_4D4D / 0x4D4D)
    FarCall(cs1, 0x4D52, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs1, 0x4D55);
    // ADD SP,0x6 (0000_4D52 / 0x4D52)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs1, 0x4D58);
    // MOV word ptr [BP + -0x8],AX (0000_4D55 / 0x4D55)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs1, 0x4D59);
    // INC AX (0000_4D58 / 0x4D58)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs1, 0x4D5B);
    // JZ 0x0000:4d39 (0000_4D59 / 0x4D59)
    if(ZeroFlag) {
      goto label_0000_4D39_04D39;
    }
    CheckExternalEvents(cs1, 0x4D5E);
    // PUSH word ptr [BP + -0x8] (0000_4D5B / 0x4D5B)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x4D63);
    // CALLF 0x1000:d226 (0000_4D5E / 0x4D5E)
    FarCall(cs1, 0x4D63, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs1, 0x4D66);
    // ADD SP,0x2 (0000_4D63 / 0x4D63)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4D69);
    // MOV AX,0x180 (0000_4D66 / 0x4D66)
    AX = 0x180;
    CheckExternalEvents(cs1, 0x4D6A);
    // PUSH AX (0000_4D69 / 0x4D69)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4D6D);
    // MOV AX,0x8101 (0000_4D6A / 0x4D6A)
    AX = 0x8101;
    CheckExternalEvents(cs1, 0x4D6E);
    // PUSH AX (0000_4D6D / 0x4D6D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4D71);
    // MOV AX,0x154 (0000_4D6E / 0x4D6E)
    AX = 0x154;
    CheckExternalEvents(cs1, 0x4D72);
    // PUSH DS (0000_4D71 / 0x4D71)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4D73);
    // PUSH AX (0000_4D72 / 0x4D72)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4D78);
    // CALLF 0x1000:d2c0 (0000_4D73 / 0x4D73)
    FarCall(cs1, 0x4D78, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs1, 0x4D7B);
    // ADD SP,0x8 (0000_4D78 / 0x4D78)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x4D7E);
    // MOV word ptr [BP + -0x8],AX (0000_4D7B / 0x4D7B)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs1, 0x4D81);
    // CMP AX,0xffff (0000_4D7E / 0x4D7E)
    Alu16.Sub(AX, 0xFFFF);
    CheckExternalEvents(cs1, 0x4D83);
    // JNZ 0x0000:4d8b (0000_4D81 / 0x4D81)
    if(!ZeroFlag) {
      goto label_0000_4D8B_04D8B;
    }
    CheckExternalEvents(cs1, 0x4D88);
    // MOV word ptr [BP + -0x6],0x1 (0000_4D83 / 0x4D83)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    CheckExternalEvents(cs1, 0x4D8B);
    // JMP 0x0000:4e1b (0000_4D88 / 0x4D88)
    goto label_0000_4E1B_04E1B;
    label_0000_4D8B_04D8B:
    CheckExternalEvents(cs1, 0x4D8F);
    // MOV byte ptr [BP + -0x2],0xc (0000_4D8B / 0x4D8B)
    UInt8[SS, (ushort)(BP - 0x2)] = 0xC;
    CheckExternalEvents(cs1, 0x4D92);
    // MOV AX,0x1 (0000_4D8F / 0x4D8F)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x4D93);
    // PUSH AX (0000_4D92 / 0x4D92)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4D96);
    // LEA AX,[BP + -0x2] (0000_4D93 / 0x4D93)
    AX = (ushort)(BP - 0x2);
    CheckExternalEvents(cs1, 0x4D97);
    // PUSH SS (0000_4D96 / 0x4D96)
    Stack.Push16(SS);
    CheckExternalEvents(cs1, 0x4D98);
    // PUSH AX (0000_4D97 / 0x4D97)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4D9B);
    // PUSH word ptr [BP + -0x8] (0000_4D98 / 0x4D98)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x4DA0);
    // CALLF 0x1000:d55a (0000_4D9B / 0x4D9B)
    FarCall(cs1, 0x4DA0, ghidra_guess_1000_D55A_1D55A);
    CheckExternalEvents(cs1, 0x4DA3);
    // ADD SP,0x8 (0000_4DA0 / 0x4DA0)
    SP += 0x8;
    CheckExternalEvents(cs1, 0x4DA6);
    // CMP AX,0x1 (0000_4DA3 / 0x4DA3)
    Alu16.Sub(AX, 0x1);
    CheckExternalEvents(cs1, 0x4DA8);
    // JZ 0x0000:4dad (0000_4DA6 / 0x4DA6)
    if(ZeroFlag) {
      goto label_0000_4DAD_04DAD;
    }
    CheckExternalEvents(cs1, 0x4DAD);
    // MOV word ptr [BP + -0x6],0x1 (0000_4DA8 / 0x4DA8)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    label_0000_4DAD_04DAD:
    CheckExternalEvents(cs1, 0x4DB0);
    // MOV AX,0xf44 (0000_4DAD / 0x4DAD)
    AX = 0xF44;
    CheckExternalEvents(cs1, 0x4DB1);
    // PUSH AX (0000_4DB0 / 0x4DB0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4DB4);
    // MOV AX,0xc614 (0000_4DB1 / 0x4DB1)
    AX = 0xC614;
    CheckExternalEvents(cs1, 0x4DB7);
    // MOV DX,0x2a02 (0000_4DB4 / 0x4DB4)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x4DB8);
    // PUSH DX (0000_4DB7 / 0x4DB7)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x4DB9);
    // PUSH AX (0000_4DB8 / 0x4DB8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4DBC);
    // PUSH word ptr [BP + -0x8] (0000_4DB9 / 0x4DB9)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x4DC1);
    // CALLF 0x1000:d55a (0000_4DBC / 0x4DBC)
    FarCall(cs1, 0x4DC1, ghidra_guess_1000_D55A_1D55A);
    CheckExternalEvents(cs1, 0x4DC4);
    // ADD SP,0x8 (0000_4DC1 / 0x4DC1)
    SP += 0x8;
    CheckExternalEvents(cs1, 0x4DC7);
    // CMP AX,0xf44 (0000_4DC4 / 0x4DC4)
    Alu16.Sub(AX, 0xF44);
    CheckExternalEvents(cs1, 0x4DC9);
    // JZ 0x0000:4dce (0000_4DC7 / 0x4DC7)
    if(ZeroFlag) {
      goto label_0000_4DCE_04DCE;
    }
    CheckExternalEvents(cs1, 0x4DCE);
    // MOV word ptr [BP + -0x6],0x1 (0000_4DC9 / 0x4DC9)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    label_0000_4DCE_04DCE:
    CheckExternalEvents(cs1, 0x4DD1);
    // MOV AX,0x2 (0000_4DCE / 0x4DCE)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x4DD2);
    // PUSH AX (0000_4DD1 / 0x4DD1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4DD5);
    // MOV AX,0xa44b (0000_4DD2 / 0x4DD2)
    AX = 0xA44B;
    CheckExternalEvents(cs1, 0x4DD8);
    // MOV DX,0x1ddc (0000_4DD5 / 0x4DD5)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x4DD9);
    // PUSH DX (0000_4DD8 / 0x4DD8)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x4DDA);
    // PUSH AX (0000_4DD9 / 0x4DD9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4DDD);
    // PUSH word ptr [BP + -0x8] (0000_4DDA / 0x4DDA)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x4DE2);
    // CALLF 0x1000:d55a (0000_4DDD / 0x4DDD)
    FarCall(cs1, 0x4DE2, ghidra_guess_1000_D55A_1D55A);
    CheckExternalEvents(cs1, 0x4DE5);
    // ADD SP,0x8 (0000_4DE2 / 0x4DE2)
    SP += 0x8;
    CheckExternalEvents(cs1, 0x4DE8);
    // CMP AX,0x2 (0000_4DE5 / 0x4DE5)
    Alu16.Sub(AX, 0x2);
    CheckExternalEvents(cs1, 0x4DEA);
    // JZ 0x0000:4def (0000_4DE8 / 0x4DE8)
    if(ZeroFlag) {
      goto label_0000_4DEF_04DEF;
    }
    CheckExternalEvents(cs1, 0x4DEF);
    // MOV word ptr [BP + -0x6],0x1 (0000_4DEA / 0x4DEA)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    label_0000_4DEF_04DEF:
    CheckExternalEvents(cs1, 0x4DF2);
    // MOV AX,0x2 (0000_4DEF / 0x4DEF)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x4DF3);
    // PUSH AX (0000_4DF2 / 0x4DF2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4DF6);
    // MOV AX,0xa44d (0000_4DF3 / 0x4DF3)
    AX = 0xA44D;
    CheckExternalEvents(cs1, 0x4DF9);
    // MOV DX,0x1ddc (0000_4DF6 / 0x4DF6)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x4DFA);
    // PUSH DX (0000_4DF9 / 0x4DF9)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x4DFB);
    // PUSH AX (0000_4DFA / 0x4DFA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4DFE);
    // PUSH word ptr [BP + -0x8] (0000_4DFB / 0x4DFB)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x4E03);
    // CALLF 0x1000:d55a (0000_4DFE / 0x4DFE)
    FarCall(cs1, 0x4E03, ghidra_guess_1000_D55A_1D55A);
    CheckExternalEvents(cs1, 0x4E06);
    // ADD SP,0x8 (0000_4E03 / 0x4E03)
    SP += 0x8;
    CheckExternalEvents(cs1, 0x4E09);
    // CMP AX,0x2 (0000_4E06 / 0x4E06)
    Alu16.Sub(AX, 0x2);
    CheckExternalEvents(cs1, 0x4E0B);
    // JZ 0x0000:4e10 (0000_4E09 / 0x4E09)
    if(ZeroFlag) {
      goto label_0000_4E10_04E10;
    }
    CheckExternalEvents(cs1, 0x4E10);
    // MOV word ptr [BP + -0x6],0x1 (0000_4E0B / 0x4E0B)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    label_0000_4E10_04E10:
    CheckExternalEvents(cs1, 0x4E13);
    // PUSH word ptr [BP + -0x8] (0000_4E10 / 0x4E10)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x4E18);
    // CALLF 0x1000:d226 (0000_4E13 / 0x4E13)
    FarCall(cs1, 0x4E18, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs1, 0x4E1B);
    // ADD SP,0x2 (0000_4E18 / 0x4E18)
    SP += 0x2;
    label_0000_4E1B_04E1B:
    CheckExternalEvents(cs1, 0x4E1F);
    // CMP word ptr [BP + -0x6],0x0 (0000_4E1B / 0x4E1B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs1, 0x4E21);
    // JZ 0x0000:4e6b (0000_4E1F / 0x4E1F)
    if(ZeroFlag) {
      goto label_0000_4E6B_04E6B;
    }
    CheckExternalEvents(cs1, 0x4E26);
    // CALLF 0x1000:7fe8 (0000_4E21 / 0x4E21)
    FarCall(cs1, 0x4E26, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x4E2A);
    // MOV ES,word ptr [0x5388] (0000_4E26 / 0x4E26)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs1, 0x4E31);
    // MOV word ptr ES:[0x37fe],0x4 (0000_4E2A / 0x4E2A)
    UInt16[ES, 0x37FE] = 0x4;
    CheckExternalEvents(cs1, 0x4E35);
    // MOV ES,word ptr [0x53a0] (0000_4E31 / 0x4E31)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs1, 0x4E3B);
    // CMP word ptr ES:[0x4fba],0x0 (0000_4E35 / 0x4E35)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x4E3D);
    // JNZ 0x0000:4e48 (0000_4E3B / 0x4E3B)
    if(!ZeroFlag) {
      goto label_0000_4E48_04E48;
    }
    CheckExternalEvents(cs1, 0x4E41);
    // MOV ES,word ptr [0x5388] (0000_4E3D / 0x4E3D)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs1, 0x4E48);
    // MOV word ptr ES:[0x37fe],0x2 (0000_4E41 / 0x4E41)
    UInt16[ES, 0x37FE] = 0x2;
    label_0000_4E48_04E48:
    CheckExternalEvents(cs1, 0x4E4B);
    // MOV AX,0x6ad (0000_4E48 / 0x4E48)
    AX = 0x6AD;
    CheckExternalEvents(cs1, 0x4E4C);
    // PUSH DS (0000_4E4B / 0x4E4B)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4E4D);
    // PUSH AX (0000_4E4C / 0x4E4C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4E52);
    // CALLF 0x1000:8055 (0000_4E4D / 0x4E4D)
    FarCall(cs1, 0x4E52, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4E54);
    // JMP 0x0000:4e63 (0000_4E52 / 0x4E52)
    goto label_0000_4E63_04E63;
    label_0000_4E54_04E54:
    CheckExternalEvents(cs1, 0x4E59);
    // CALLF 0x1000:7bf6 (0000_4E54 / 0x4E54)
    FarCall(cs1, 0x4E59, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0x4E5C);
    // MOV AX,0x6d2 (0000_4E59 / 0x4E59)
    AX = 0x6D2;
    CheckExternalEvents(cs1, 0x4E5D);
    // PUSH DS (0000_4E5C / 0x4E5C)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4E5E);
    // PUSH AX (0000_4E5D / 0x4E5D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4E63);
    // CALLF 0x1000:7c1a (0000_4E5E / 0x4E5E)
    FarCall(cs1, 0x4E63, unknown_1643_17EA_17C1A);
    label_0000_4E63_04E63:
    CheckExternalEvents(cs1, 0x4E66);
    // ADD SP,0x4 (0000_4E63 / 0x4E63)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4E6B);
    // CALLF 0x1000:8d29 (0000_4E66 / 0x4E66)
    FarCall(cs1, 0x4E6B, unknown_18AD_0259_18D29);
    label_0000_4E6B_04E6B:
    CheckExternalEvents(cs1, 0x4E6D);
    // SUB AX,AX (0000_4E6B / 0x4E6B)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x4E6E);
    // PUSH AX (0000_4E6D / 0x4E6D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4E73);
    // CALLF 0x0000:fd3f (0000_4E6E / 0x4E6E)
    FarCall(cs1, 0x4E73, ghidra_guess_0000_FD3F_0FD3F);
    CheckExternalEvents(cs1, 0x4E76);
    // ADD SP,0x2 (0000_4E73 / 0x4E73)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4E79);
    // MOV AX,0x1 (0000_4E76 / 0x4E76)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x4E7A);
    // PUSH AX (0000_4E79 / 0x4E79)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4E7B);
    // PUSH CS (0000_4E7A / 0x4E7A)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4E7E);
    // CALL 0x0000:63ac (0000_4E7B / 0x4E7B)
    NearCall(cs1, 0x4E7E, unknown_0170_4CAC_063AC);
    CheckExternalEvents(cs1, 0x4E81);
    // ADD SP,0x2 (0000_4E7E / 0x4E7E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4E84);
    // MOV AX,0x1 (0000_4E81 / 0x4E81)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x4E85);
    // PUSH AX (0000_4E84 / 0x4E84)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4E86);
    // PUSH CS (0000_4E85 / 0x4E85)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4E89);
    // CALL 0x0000:3fcc (0000_4E86 / 0x4E86)
    NearCall(cs1, 0x4E89, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0x4E8B);
    // MOV SP,BP (0000_4E89 / 0x4E89)
    SP = BP;
    CheckExternalEvents(cs1, 0x4E8C);
    // POP BP (0000_4E8B / 0x4E8B)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x4E8D);
    // RETF  (0000_4E8C / 0x4E8C)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_4E8D_04E8D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_4E8D_04E8D:
    CheckExternalEvents(cs1, 0x4E8E);
    // PUSH BP (0000_4E8D / 0x4E8D)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x4E90);
    // MOV BP,SP (0000_4E8E / 0x4E8E)
    BP = SP;
    CheckExternalEvents(cs1, 0x4E93);
    // MOV AX,0xc (0000_4E90 / 0x4E90)
    AX = 0xC;
    CheckExternalEvents(cs1, 0x4E98);
    // CALLF 0x1000:cecc (0000_4E93 / 0x4E93)
    FarCall(cs1, 0x4E98, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x4E99);
    // PUSH SI (0000_4E98 / 0x4E98)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x4E9E);
    // MOV word ptr [BP + -0x4],0x1 (0000_4E99 / 0x4E99)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    CheckExternalEvents(cs1, 0x4EA1);
    // MOV AX,0x6 (0000_4E9E / 0x4E9E)
    AX = 0x6;
    CheckExternalEvents(cs1, 0x4EA2);
    // PUSH AX (0000_4EA1 / 0x4EA1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4EA7);
    // CALLF 0x1000:7ee1 (0000_4EA2 / 0x4EA2)
    FarCall(cs1, 0x4EA7, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x4EAA);
    // ADD SP,0x2 (0000_4EA7 / 0x4EA7)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4EAF);
    // CALLF 0x1000:7fe8 (0000_4EAA / 0x4EAA)
    FarCall(cs1, 0x4EAF, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x4EB1);
    // SUB AX,AX (0000_4EAF / 0x4EAF)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x4EB2);
    // PUSH AX (0000_4EB1 / 0x4EB1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4EB7);
    // CALLF 0x1000:7c64 (0000_4EB2 / 0x4EB2)
    FarCall(cs1, 0x4EB7, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0x4EBA);
    // ADD SP,0x2 (0000_4EB7 / 0x4EB7)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4EBD);
    // MOV AX,0x11 (0000_4EBA / 0x4EBA)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x4EBE);
    // PUSH AX (0000_4EBD / 0x4EBD)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4EC3);
    // CALLF 0x1000:6434 (0000_4EBE / 0x4EBE)
    FarCall(cs1, 0x4EC3, unknown_1643_0004_16434);
    CheckExternalEvents(cs1, 0x4EC6);
    // ADD SP,0x2 (0000_4EC3 / 0x4EC3)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4ECA);
    // MOV ES,word ptr [0x538a] (0000_4EC6 / 0x4EC6)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4ED0);
    // CMP byte ptr ES:[0xd31c],0x0 (0000_4ECA / 0x4ECA)
    Alu8.Sub(UInt8[ES, 0xD31C], 0x0);
    CheckExternalEvents(cs1, 0x4ED2);
    // JZ 0x0000:4f3e (0000_4ED0 / 0x4ED0)
    if(ZeroFlag) {
      goto label_0000_4F3E_04F3E;
    }
    CheckExternalEvents(cs1, 0x4ED5);
    // MOV AX,0x6ff (0000_4ED2 / 0x4ED2)
    AX = 0x6FF;
    CheckExternalEvents(cs1, 0x4ED6);
    // PUSH DS (0000_4ED5 / 0x4ED5)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4ED7);
    // PUSH AX (0000_4ED6 / 0x4ED6)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4EDC);
    // CALLF 0x1000:8055 (0000_4ED7 / 0x4ED7)
    FarCall(cs1, 0x4EDC, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4EDF);
    // ADD SP,0x4 (0000_4EDC / 0x4EDC)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4EE2);
    // MOV AX,0x1 (0000_4EDF / 0x4EDF)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x4EE3);
    // PUSH AX (0000_4EE2 / 0x4EE2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4EE4);
    // PUSH CS (0000_4EE3 / 0x4EE3)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4EE7);
    // CALL 0x0000:3113 (0000_4EE4 / 0x4EE4)
    NearCall(cs1, 0x4EE7, unknown_0170_1A13_03113);
    CheckExternalEvents(cs1, 0x4EEA);
    // ADD SP,0x2 (0000_4EE7 / 0x4EE7)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4EEC);
    // OR AX,AX (0000_4EEA / 0x4EEA)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0x4EEE);
    // JZ 0x0000:4f3e (0000_4EEC / 0x4EEC)
    if(ZeroFlag) {
      goto label_0000_4F3E_04F3E;
    }
    CheckExternalEvents(cs1, 0x4EF3);
    // CALLF 0x1000:7fe8 (0000_4EEE / 0x4EEE)
    FarCall(cs1, 0x4EF3, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x4EF6);
    // MOV AX,0x742 (0000_4EF3 / 0x4EF3)
    AX = 0x742;
    CheckExternalEvents(cs1, 0x4EF7);
    // PUSH DS (0000_4EF6 / 0x4EF6)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4EF8);
    // PUSH AX (0000_4EF7 / 0x4EF7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4EFD);
    // CALLF 0x1000:8055 (0000_4EF8 / 0x4EF8)
    FarCall(cs1, 0x4EFD, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4F00);
    // ADD SP,0x4 (0000_4EFD / 0x4EFD)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4F05);
    // CALLF 0x0000:e908 (0000_4F00 / 0x4F00)
    FarCall(cs1, 0x4F05, ghidra_guess_0000_E908_0E908);
    CheckExternalEvents(cs1, 0x4F09);
    // MOV ES,word ptr [0x53ee] (0000_4F05 / 0x4F05)
    ES = UInt16[DS, 0x53EE];
    CheckExternalEvents(cs1, 0x4F0E);
    // MOV BX,word ptr ES:[0x68] (0000_4F09 / 0x4F09)
    BX = UInt16[ES, 0x68];
    CheckExternalEvents(cs1, 0x4F12);
    // MOV ES,word ptr [0x53f0] (0000_4F0E / 0x4F0E)
    ES = UInt16[DS, 0x53F0];
    CheckExternalEvents(cs1, 0x4F18);
    // MOV byte ptr ES:[BX + 0x6e],0x0 (0000_4F12 / 0x4F12)
    UInt8[ES, (ushort)(BX + 0x6E)] = 0x0;
    CheckExternalEvents(cs1, 0x4F1C);
    // MOV ES,word ptr [0x53ee] (0000_4F18 / 0x4F18)
    ES = UInt16[DS, 0x53EE];
    CheckExternalEvents(cs1, 0x4F21);
    // PUSH word ptr ES:[0x68] (0000_4F1C / 0x4F1C)
    Stack.Push16(UInt16[ES, 0x68]);
    CheckExternalEvents(cs1, 0x4F26);
    // CALLF 0x0000:8cae (0000_4F21 / 0x4F21)
    FarCall(cs1, 0x4F26, ghidra_guess_0000_8CAE_08CAE);
    CheckExternalEvents(cs1, 0x4F29);
    // ADD SP,0x2 (0000_4F26 / 0x4F26)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4F2C);
    // MOV AX,0x1 (0000_4F29 / 0x4F29)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x4F2D);
    // PUSH AX (0000_4F2C / 0x4F2C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4F2E);
    // PUSH CS (0000_4F2D / 0x4F2D)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4F31);
    // CALL 0x0000:63ac (0000_4F2E / 0x4F2E)
    NearCall(cs1, 0x4F31, unknown_0170_4CAC_063AC);
    CheckExternalEvents(cs1, 0x4F34);
    // ADD SP,0x2 (0000_4F31 / 0x4F31)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4F39);
    // CALLF 0x1000:7fe8 (0000_4F34 / 0x4F34)
    FarCall(cs1, 0x4F39, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x4F3E);
    // MOV word ptr [BP + -0x4],0x0 (0000_4F39 / 0x4F39)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_4F3E_04F3E:
    CheckExternalEvents(cs1, 0x4F42);
    // CMP word ptr [BP + -0x4],0x0 (0000_4F3E / 0x4F3E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs1, 0x4F44);
    // JNZ 0x0000:4f47 (0000_4F42 / 0x4F42)
    if(!ZeroFlag) {
      goto label_0000_4F47_04F47;
    }
    CheckExternalEvents(cs1, 0x4F47);
    // JMP 0x0000:52cb (0000_4F44 / 0x4F44)
    goto label_0000_52CB_052CB;
    label_0000_4F47_04F47:
    CheckExternalEvents(cs1, 0x4F4A);
    // MOV AX,0xe (0000_4F47 / 0x4F47)
    AX = 0xE;
    CheckExternalEvents(cs1, 0x4F4B);
    // PUSH AX (0000_4F4A / 0x4F4A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4F50);
    // CALLF 0x1000:6434 (0000_4F4B / 0x4F4B)
    FarCall(cs1, 0x4F50, unknown_1643_0004_16434);
    CheckExternalEvents(cs1, 0x4F53);
    // ADD SP,0x2 (0000_4F50 / 0x4F50)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4F57);
    // MOV ES,word ptr [0x538a] (0000_4F53 / 0x4F53)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4F5D);
    // CMP byte ptr ES:[0xd31a],0x0 (0000_4F57 / 0x4F57)
    Alu8.Sub(UInt8[ES, 0xD31A], 0x0);
    CheckExternalEvents(cs1, 0x4F5F);
    // JZ 0x0000:4f7d (0000_4F5D / 0x4F5D)
    if(ZeroFlag) {
      goto label_0000_4F7D_04F7D;
    }
    CheckExternalEvents(cs1, 0x4F64);
    // CALLF 0x1000:7fe8 (0000_4F5F / 0x4F5F)
    FarCall(cs1, 0x4F64, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x4F67);
    // MOV AX,0x758 (0000_4F64 / 0x4F64)
    AX = 0x758;
    CheckExternalEvents(cs1, 0x4F68);
    // PUSH DS (0000_4F67 / 0x4F67)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4F69);
    // PUSH AX (0000_4F68 / 0x4F68)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4F6E);
    // CALLF 0x1000:8055 (0000_4F69 / 0x4F69)
    FarCall(cs1, 0x4F6E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4F71);
    // ADD SP,0x4 (0000_4F6E / 0x4F6E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4F74);
    // MOV AX,0xd (0000_4F71 / 0x4F71)
    AX = 0xD;
    CheckExternalEvents(cs1, 0x4F75);
    // PUSH AX (0000_4F74 / 0x4F74)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4F7A);
    // CALLF 0x1000:6434 (0000_4F75 / 0x4F75)
    FarCall(cs1, 0x4F7A, unknown_1643_0004_16434);
    CheckExternalEvents(cs1, 0x4F7D);
    // ADD SP,0x2 (0000_4F7A / 0x4F7A)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_0000_4F7D_04F7D:
    CheckExternalEvents(cs1, 0x4F81);
    // MOV ES,word ptr [0x538a] (0000_4F7D / 0x4F7D)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4F85);
    // MOV AL,ES:[0xd31a] (0000_4F81 / 0x4F81)
    AL = UInt8[ES, 0xD31A];
    CheckExternalEvents(cs1, 0x4F86);
    // CBW  (0000_4F85 / 0x4F85)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x4F89);
    // MOV word ptr [BP + -0xa],AX (0000_4F86 / 0x4F86)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0x4F8E);
    // CALLF 0x1000:7fe8 (0000_4F89 / 0x4F89)
    FarCall(cs1, 0x4F8E, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x4F8F);
    // PUSH CS (0000_4F8E / 0x4F8E)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4F92);
    // CALL 0x0000:3fa2 (0000_4F8F / 0x4F8F)
    NearCall(cs1, 0x4F92, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0x4F95);
    // MOV AX,0x772 (0000_4F92 / 0x4F92)
    AX = 0x772;
    CheckExternalEvents(cs1, 0x4F96);
    // PUSH DS (0000_4F95 / 0x4F95)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4F97);
    // PUSH AX (0000_4F96 / 0x4F96)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4F9C);
    // CALLF 0x1000:8055 (0000_4F97 / 0x4F97)
    FarCall(cs1, 0x4F9C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4F9F);
    // ADD SP,0x4 (0000_4F9C / 0x4F9C)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4FA2);
    // MOV AX,0x7a3 (0000_4F9F / 0x4F9F)
    AX = 0x7A3;
    CheckExternalEvents(cs1, 0x4FA3);
    // PUSH DS (0000_4FA2 / 0x4FA2)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4FA4);
    // PUSH AX (0000_4FA3 / 0x4FA3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4FA9);
    // CALLF 0x1000:8055 (0000_4FA4 / 0x4FA4)
    FarCall(cs1, 0x4FA9, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4FAC);
    // ADD SP,0x4 (0000_4FA9 / 0x4FA9)
    SP += 0x4;
    CheckExternalEvents(cs1, 0x4FAE);
    // SUB AX,AX (0000_4FAC / 0x4FAC)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x4FAF);
    // PUSH AX (0000_4FAE / 0x4FAE)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4FB2);
    // MOV AX,0x8 (0000_4FAF / 0x4FAF)
    AX = 0x8;
    CheckExternalEvents(cs1, 0x4FB3);
    // PUSH AX (0000_4FB2 / 0x4FB2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4FB6);
    // MOV AX,0x11 (0000_4FB3 / 0x4FB3)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x4FB9);
    // IMUL word ptr [BP + -0xa] (0000_4FB6 / 0x4FB6)
    int resImul0000_4FB6 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_4FB6);
    DX = (ushort)(resImul0000_4FB6 >> 16);
    CheckExternalEvents(cs1, 0x4FBB);
    // MOV BX,AX (0000_4FB9 / 0x4FB9)
    BX = AX;
    CheckExternalEvents(cs1, 0x4FBF);
    // MOV ES,word ptr [0x538a] (0000_4FBB / 0x4FBB)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4FC4);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_4FBF / 0x4FBF)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0x4FC5);
    // CBW  (0000_4FC4 / 0x4FC4)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x4FC7);
    // MOV BX,AX (0000_4FC5 / 0x4FC5)
    BX = AX;
    CheckExternalEvents(cs1, 0x4FC9);
    // SHL BX,0x1 (0000_4FC7 / 0x4FC7)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x4FCB);
    // SHL BX,0x1 (0000_4FC9 / 0x4FC9)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x4FCF);
    // PUSH word ptr [BX + 0x1cc] (0000_4FCB / 0x4FCB)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0x4FD3);
    // PUSH word ptr [BX + 0x1ca] (0000_4FCF / 0x4FCF)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0x4FD4);
    // PUSH CS (0000_4FD3 / 0x4FD3)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4FD7);
    // CALL 0x0000:3f67 (0000_4FD4 / 0x4FD4)
    NearCall(cs1, 0x4FD7, ghidra_guess_0000_3F67_03F67);
    CheckExternalEvents(cs1, 0x4FDA);
    // ADD SP,0x8 (0000_4FD7 / 0x4FD7)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x4FDD);
    // MOV AX,0x1 (0000_4FDA / 0x4FDA)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x4FDE);
    // PUSH AX (0000_4FDD / 0x4FDD)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4FE1);
    // MOV AX,0x8 (0000_4FDE / 0x4FDE)
    AX = 0x8;
    CheckExternalEvents(cs1, 0x4FE2);
    // PUSH AX (0000_4FE1 / 0x4FE1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4FE5);
    // MOV AX,0x11 (0000_4FE2 / 0x4FE2)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x4FE8);
    // IMUL word ptr [BP + -0xa] (0000_4FE5 / 0x4FE5)
    int resImul0000_4FE5 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_4FE5);
    DX = (ushort)(resImul0000_4FE5 >> 16);
    CheckExternalEvents(cs1, 0x4FEA);
    // MOV BX,AX (0000_4FE8 / 0x4FE8)
    BX = AX;
    CheckExternalEvents(cs1, 0x4FEE);
    // MOV ES,word ptr [0x538a] (0000_4FEA / 0x4FEA)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4FF0);
    // MOV AL,0x11 (0000_4FEE / 0x4FEE)
    AL = 0x11;
    CheckExternalEvents(cs1, 0x4FF5);
    // IMUL byte ptr ES:[BX + 0xc61f] (0000_4FF0 / 0x4FF0)
    short resImul0000_4FF0 = Alu8.Imul((sbyte)AL, (sbyte)UInt8[ES, (ushort)(BX + 0xC61F)]);
    AL = (byte)(resImul0000_4FF0);
    AH = (byte)(resImul0000_4FF0 >> 8);
    CheckExternalEvents(cs1, 0x4FF7);
    // MOV BX,AX (0000_4FF5 / 0x4FF5)
    BX = AX;
    CheckExternalEvents(cs1, 0x4FFB);
    // LEA AX,[BX + 0x2ed8] (0000_4FF7 / 0x4FF7)
    AX = (ushort)(BX + 0x2ED8);
    CheckExternalEvents(cs1, 0x4FFE);
    // MOV DX,0x384b (0000_4FFB / 0x4FFB)
    DX = 0x384B;
    CheckExternalEvents(cs1, 0x4FFF);
    // PUSH DX (0000_4FFE / 0x4FFE)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x5000);
    // PUSH AX (0000_4FFF / 0x4FFF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5001);
    // PUSH CS (0000_5000 / 0x5000)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5004);
    // CALL 0x0000:3f67 (0000_5001 / 0x5001)
    NearCall(cs1, 0x5004, ghidra_guess_0000_3F67_03F67);
    CheckExternalEvents(cs1, 0x5007);
    // ADD SP,0x8 (0000_5004 / 0x5004)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x500A);
    // MOV AX,0x2 (0000_5007 / 0x5007)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x500B);
    // PUSH AX (0000_500A / 0x500A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x500E);
    // MOV AX,0x8 (0000_500B / 0x500B)
    AX = 0x8;
    CheckExternalEvents(cs1, 0x500F);
    // PUSH AX (0000_500E / 0x500E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5012);
    // MOV AX,0x11 (0000_500F / 0x500F)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x5015);
    // IMUL word ptr [BP + -0xa] (0000_5012 / 0x5012)
    int resImul0000_5012 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_5012);
    DX = (ushort)(resImul0000_5012 >> 16);
    CheckExternalEvents(cs1, 0x5017);
    // MOV BX,AX (0000_5015 / 0x5015)
    BX = AX;
    CheckExternalEvents(cs1, 0x501B);
    // MOV ES,word ptr [0x538a] (0000_5017 / 0x5017)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5020);
    // MOV AL,byte ptr ES:[BX + 0xc621] (0000_501B / 0x501B)
    AL = UInt8[ES, (ushort)(BX + 0xC621)];
    CheckExternalEvents(cs1, 0x5021);
    // CBW  (0000_5020 / 0x5020)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x5023);
    // MOV BX,AX (0000_5021 / 0x5021)
    BX = AX;
    CheckExternalEvents(cs1, 0x5025);
    // SHL BX,0x1 (0000_5023 / 0x5023)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x5027);
    // SHL BX,0x1 (0000_5025 / 0x5025)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x502B);
    // MOV ES,word ptr [0x53f2] (0000_5027 / 0x5027)
    ES = UInt16[DS, 0x53F2];
    CheckExternalEvents(cs1, 0x5030);
    // PUSH word ptr ES:[BX + 0x4e8c] (0000_502B / 0x502B)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x4E8C)]);
    CheckExternalEvents(cs1, 0x5035);
    // PUSH word ptr ES:[BX + 0x4e8a] (0000_5030 / 0x5030)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x4E8A)]);
    CheckExternalEvents(cs1, 0x5036);
    // PUSH CS (0000_5035 / 0x5035)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5039);
    // CALL 0x0000:3f67 (0000_5036 / 0x5036)
    NearCall(cs1, 0x5039, ghidra_guess_0000_3F67_03F67);
    CheckExternalEvents(cs1, 0x503C);
    // ADD SP,0x8 (0000_5039 / 0x5039)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x5040);
    // MOV ES,word ptr [0x53f4] (0000_503C / 0x503C)
    ES = UInt16[DS, 0x53F4];
    CheckExternalEvents(cs1, 0x5046);
    // ADD word ptr ES:[0x39a0],0x8 (0000_5040 / 0x5040)
    // UInt16[ES, 0x39A0] += 0x8;
    UInt16[ES, 0x39A0] = Alu16.Add(UInt16[ES, 0x39A0], 0x8);
    CheckExternalEvents(cs1, 0x504A);
    // MOV ES,word ptr [0x53f6] (0000_5046 / 0x5046)
    ES = UInt16[DS, 0x53F6];
    CheckExternalEvents(cs1, 0x5050);
    // SUB word ptr ES:[0x3990],0x8 (0000_504A / 0x504A)
    // UInt16[ES, 0x3990] -= 0x8;
    UInt16[ES, 0x3990] = Alu16.Sub(UInt16[ES, 0x3990], 0x8);
    CheckExternalEvents(cs1, 0x5053);
    // MOV AX,0x4 (0000_5050 / 0x5050)
    AX = 0x4;
    CheckExternalEvents(cs1, 0x5054);
    // PUSH AX (0000_5053 / 0x5053)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5056);
    // SUB AX,AX (0000_5054 / 0x5054)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x5057);
    // PUSH AX (0000_5056 / 0x5056)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x505A);
    // MOV AX,0x11 (0000_5057 / 0x5057)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x505D);
    // IMUL word ptr [BP + -0xa] (0000_505A / 0x505A)
    int resImul0000_505A = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_505A);
    DX = (ushort)(resImul0000_505A >> 16);
    CheckExternalEvents(cs1, 0x505F);
    // MOV BX,AX (0000_505D / 0x505D)
    BX = AX;
    CheckExternalEvents(cs1, 0x5063);
    // MOV ES,word ptr [0x538a] (0000_505F / 0x505F)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5068);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_5063 / 0x5063)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0x5069);
    // CBW  (0000_5068 / 0x5068)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x506B);
    // MOV BX,AX (0000_5069 / 0x5069)
    BX = AX;
    CheckExternalEvents(cs1, 0x506D);
    // SHL BX,0x1 (0000_506B / 0x506B)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x506F);
    // SHL BX,0x1 (0000_506D / 0x506D)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x5073);
    // PUSH word ptr [BX + 0x1cc] (0000_506F / 0x506F)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0x5077);
    // PUSH word ptr [BX + 0x1ca] (0000_5073 / 0x5073)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0x5078);
    // PUSH CS (0000_5077 / 0x5077)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x507B);
    // CALL 0x0000:3f67 (0000_5078 / 0x5078)
    NearCall(cs1, 0x507B, ghidra_guess_0000_3F67_03F67);
    CheckExternalEvents(cs1, 0x507E);
    // ADD SP,0x8 (0000_507B / 0x507B)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x5081);
    // PUSH word ptr [BP + -0xa] (0000_507E / 0x507E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x5086);
    // CALLF 0x0000:fcf4 (0000_5081 / 0x5081)
    FarCall(cs1, 0x5086, ghidra_guess_0000_FCF4_0FCF4);
    CheckExternalEvents(cs1, 0x5089);
    // ADD SP,0x2 (0000_5086 / 0x5086)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x508D);
    // MOV ES,word ptr [0x53f4] (0000_5089 / 0x5089)
    ES = UInt16[DS, 0x53F4];
    CheckExternalEvents(cs1, 0x5093);
    // SUB word ptr ES:[0x39a0],0x8 (0000_508D / 0x508D)
    // UInt16[ES, 0x39A0] -= 0x8;
    UInt16[ES, 0x39A0] = Alu16.Sub(UInt16[ES, 0x39A0], 0x8);
    CheckExternalEvents(cs1, 0x5097);
    // MOV ES,word ptr [0x53f6] (0000_5093 / 0x5093)
    ES = UInt16[DS, 0x53F6];
    CheckExternalEvents(cs1, 0x509D);
    // ADD word ptr ES:[0x3990],0x8 (0000_5097 / 0x5097)
    // UInt16[ES, 0x3990] += 0x8;
    UInt16[ES, 0x3990] = Alu16.Add(UInt16[ES, 0x3990], 0x8);
    CheckExternalEvents(cs1, 0x50A1);
    // MOV ES,word ptr [0x538a] (0000_509D / 0x509D)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x50A7);
    // CMP byte ptr ES:[0xd333],0x0 (0000_50A1 / 0x50A1)
    Alu8.Sub(UInt8[ES, 0xD333], 0x0);
    CheckExternalEvents(cs1, 0x50A9);
    // JZ 0x0000:50ff (0000_50A7 / 0x50A7)
    if(ZeroFlag) {
      goto label_0000_50FF_050FF;
    }
    CheckExternalEvents(cs1, 0x50AD);
    // MOV AL,ES:[0xd331] (0000_50A9 / 0x50A9)
    AL = UInt8[ES, 0xD331];
    CheckExternalEvents(cs1, 0x50AE);
    // CBW  (0000_50AD / 0x50AD)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x50B1);
    // CMP AX,word ptr [BP + -0xa] (0000_50AE / 0x50AE)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x50B3);
    // JNZ 0x0000:50ff (0000_50B1 / 0x50B1)
    if(!ZeroFlag) {
      goto label_0000_50FF_050FF;
    }
    CheckExternalEvents(cs1, 0x50B7);
    // MOV ES,word ptr [0x5388] (0000_50B3 / 0x50B3)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs1, 0x50BE);
    // MOV word ptr ES:[0x37fe],0xe (0000_50B7 / 0x50B7)
    UInt16[ES, 0x37FE] = 0xE;
    CheckExternalEvents(cs1, 0x50C2);
    // MOV ES,word ptr [0x53dc] (0000_50BE / 0x50BE)
    ES = UInt16[DS, 0x53DC];
    CheckExternalEvents(cs1, 0x50C9);
    // MOV word ptr ES:[0x3748],0x0 (0000_50C2 / 0x50C2)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs1, 0x50CD);
    // MOV ES,word ptr [0x53c0] (0000_50C9 / 0x50C9)
    ES = UInt16[DS, 0x53C0];
    CheckExternalEvents(cs1, 0x50D4);
    // MOV word ptr ES:[0x374e],0x8 (0000_50CD / 0x50CD)
    UInt16[ES, 0x374E] = 0x8;
    CheckExternalEvents(cs1, 0x50D7);
    // MOV AX,0x7ff (0000_50D4 / 0x50D4)
    AX = 0x7FF;
    CheckExternalEvents(cs1, 0x50D8);
    // PUSH DS (0000_50D7 / 0x50D7)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x50D9);
    // PUSH AX (0000_50D8 / 0x50D8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x50DE);
    // CALLF 0x1000:8055 (0000_50D9 / 0x50D9)
    FarCall(cs1, 0x50DE, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x50E1);
    // ADD SP,0x4 (0000_50DE / 0x50DE)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x50E5);
    // MOV ES,word ptr [0x5388] (0000_50E1 / 0x50E1)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs1, 0x50EC);
    // MOV word ptr ES:[0x37fe],0xf (0000_50E5 / 0x50E5)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0x50F1);
    // CALLF 0x1000:933a (0000_50EC / 0x50EC)
    FarCall(cs1, 0x50F1, unknown_18AD_086A_1933A);
    CheckExternalEvents(cs1, 0x50F5);
    // MOV ES,word ptr [0x53ec] (0000_50F1 / 0x50F1)
    ES = UInt16[DS, 0x53EC];
    CheckExternalEvents(cs1, 0x50FC);
    // MOV word ptr ES:[0x374a],0x1 (0000_50F5 / 0x50F5)
    UInt16[ES, 0x374A] = 0x1;
    CheckExternalEvents(cs1, 0x50FF);
    // JMP 0x0000:51e9 (0000_50FC / 0x50FC)
    goto label_0000_51E9_051E9;
    label_0000_50FF_050FF:
    CheckExternalEvents(cs1, 0x5102);
    // MOV AX,0x11 (0000_50FF / 0x50FF)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x5105);
    // IMUL word ptr [BP + -0xa] (0000_5102 / 0x5102)
    int resImul0000_5102 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_5102);
    DX = (ushort)(resImul0000_5102 >> 16);
    CheckExternalEvents(cs1, 0x5107);
    // MOV BX,AX (0000_5105 / 0x5105)
    BX = AX;
    CheckExternalEvents(cs1, 0x510B);
    // MOV ES,word ptr [0x538a] (0000_5107 / 0x5107)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5111);
    // CMP byte ptr ES:[BX + 0xc621],0x0 (0000_510B / 0x510B)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC621)], 0x0);
    CheckExternalEvents(cs1, 0x5113);
    // JNZ 0x0000:5116 (0000_5111 / 0x5111)
    if(!ZeroFlag) {
      goto label_0000_5116_05116;
    }
    CheckExternalEvents(cs1, 0x5116);
    // JMP 0x0000:51e9 (0000_5113 / 0x5113)
    goto label_0000_51E9_051E9;
    label_0000_5116_05116:
    CheckExternalEvents(cs1, 0x5119);
    // MOV AX,0x8 (0000_5116 / 0x5116)
    AX = 0x8;
    CheckExternalEvents(cs1, 0x511A);
    // PUSH AX (0000_5119 / 0x5119)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x511C);
    // SUB AX,AX (0000_511A / 0x511A)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x511D);
    // PUSH AX (0000_511C / 0x511C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5120);
    // MOV AX,0x839 (0000_511D / 0x511D)
    AX = 0x839;
    CheckExternalEvents(cs1, 0x5121);
    // PUSH DS (0000_5120 / 0x5120)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x5122);
    // PUSH AX (0000_5121 / 0x5121)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5123);
    // PUSH CS (0000_5122 / 0x5122)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5126);
    // CALL 0x0000:3f67 (0000_5123 / 0x5123)
    NearCall(cs1, 0x5126, ghidra_guess_0000_3F67_03F67);
    CheckExternalEvents(cs1, 0x5129);
    // ADD SP,0x8 (0000_5126 / 0x5126)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x512C);
    // MOV AX,0x11 (0000_5129 / 0x5129)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x512F);
    // IMUL word ptr [BP + -0xa] (0000_512C / 0x512C)
    int resImul0000_512C = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_512C);
    DX = (ushort)(resImul0000_512C >> 16);
    CheckExternalEvents(cs1, 0x5131);
    // MOV SI,AX (0000_512F / 0x512F)
    SI = AX;
    CheckExternalEvents(cs1, 0x5135);
    // MOV ES,word ptr [0x538a] (0000_5131 / 0x5131)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x513A);
    // MOV AL,byte ptr ES:[SI + 0xc622] (0000_5135 / 0x5135)
    AL = UInt8[ES, (ushort)(SI + 0xC622)];
    CheckExternalEvents(cs1, 0x513B);
    // CBW  (0000_513A / 0x513A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x513D);
    // MOV CX,AX (0000_513B / 0x513B)
    CX = AX;
    CheckExternalEvents(cs1, 0x5142);
    // MOV AL,byte ptr ES:[SI + 0xc621] (0000_513D / 0x513D)
    AL = UInt8[ES, (ushort)(SI + 0xC621)];
    CheckExternalEvents(cs1, 0x5143);
    // CBW  (0000_5142 / 0x5142)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x5145);
    // MOV BX,AX (0000_5143 / 0x5143)
    BX = AX;
    CheckExternalEvents(cs1, 0x5149);
    // MOV ES,word ptr [0x53f8] (0000_5145 / 0x5145)
    ES = UInt16[DS, 0x53F8];
    CheckExternalEvents(cs1, 0x514E);
    // MOV AL,byte ptr ES:[BX + 0x4ddb] (0000_5149 / 0x5149)
    AL = UInt8[ES, (ushort)(BX + 0x4DDB)];
    CheckExternalEvents(cs1, 0x514F);
    // CBW  (0000_514E / 0x514E)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x5151);
    // SUB AX,CX (0000_514F / 0x514F)
    // AX -= CX;
    AX = Alu16.Sub(AX, CX);
    CheckExternalEvents(cs1, 0x5154);
    // MOV word ptr [BP + -0x8],AX (0000_5151 / 0x5151)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs1, 0x5156);
    // OR AX,AX (0000_5154 / 0x5154)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0x5158);
    // JNZ 0x0000:515e (0000_5156 / 0x5156)
    if(!ZeroFlag) {
      goto label_0000_515E_0515E;
    }
    CheckExternalEvents(cs1, 0x515B);
    // MOV AX,0x840 (0000_5158 / 0x5158)
    AX = 0x840;
    CheckExternalEvents(cs1, 0x515E);
    // JMP 0x0000:51df (0000_515B / 0x515B)
    goto label_0000_51DF_051DF;
    label_0000_515E_0515E:
    CheckExternalEvents(cs1, 0x5161);
    // MOV AX,0x856 (0000_515E / 0x515E)
    AX = 0x856;
    CheckExternalEvents(cs1, 0x5162);
    // PUSH DS (0000_5161 / 0x5161)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x5163);
    // PUSH AX (0000_5162 / 0x5162)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5168);
    // CALLF 0x1000:8055 (0000_5163 / 0x5163)
    FarCall(cs1, 0x5168, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x516B);
    // ADD SP,0x4 (0000_5168 / 0x5168)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x516E);
    // MOV AX,0x11 (0000_516B / 0x516B)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x5171);
    // IMUL word ptr [BP + -0xa] (0000_516E / 0x516E)
    int resImul0000_516E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_516E);
    DX = (ushort)(resImul0000_516E >> 16);
    CheckExternalEvents(cs1, 0x5173);
    // MOV BX,AX (0000_5171 / 0x5171)
    BX = AX;
    CheckExternalEvents(cs1, 0x5177);
    // MOV ES,word ptr [0x538a] (0000_5173 / 0x5173)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x517D);
    // CMP byte ptr ES:[BX + 0xc622],0x0 (0000_5177 / 0x5177)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC622)], 0x0);
    CheckExternalEvents(cs1, 0x517F);
    // JNZ 0x0000:518e (0000_517D / 0x517D)
    if(!ZeroFlag) {
      goto label_0000_518E_0518E;
    }
    CheckExternalEvents(cs1, 0x5182);
    // MOV AX,0x860 (0000_517F / 0x517F)
    AX = 0x860;
    CheckExternalEvents(cs1, 0x5183);
    // PUSH DS (0000_5182 / 0x5182)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x5184);
    // PUSH AX (0000_5183 / 0x5183)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5189);
    // CALLF 0x1000:8055 (0000_5184 / 0x5184)
    FarCall(cs1, 0x5189, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x518C);
    // ADD SP,0x4 (0000_5189 / 0x5189)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x518E);
    // JMP 0x0000:519d (0000_518C / 0x518C)
    goto label_0000_519D_0519D;
    label_0000_518E_0518E:
    CheckExternalEvents(cs1, 0x518F);
    // PUSH CS (0000_518E / 0x518E)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5192);
    // CALL 0x0000:3fa2 (0000_518F / 0x518F)
    NearCall(cs1, 0x5192, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0x5195);
    // PUSH word ptr [BP + -0x8] (0000_5192 / 0x5192)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x519A);
    // CALLF 0x1000:8b23 (0000_5195 / 0x5195)
    FarCall(cs1, 0x519A, ghidra_guess_1000_8B23_18B23);
    CheckExternalEvents(cs1, 0x519D);
    // ADD SP,0x2 (0000_519A / 0x519A)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_0000_519D_0519D:
    CheckExternalEvents(cs1, 0x51A1);
    // MOV ES,word ptr [0x5388] (0000_519D / 0x519D)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs1, 0x51A8);
    // MOV word ptr ES:[0x37fe],0xf (0000_51A1 / 0x51A1)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0x51AB);
    // MOV AX,0x864 (0000_51A8 / 0x51A8)
    AX = 0x864;
    CheckExternalEvents(cs1, 0x51AC);
    // PUSH DS (0000_51AB / 0x51AB)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x51AD);
    // PUSH AX (0000_51AC / 0x51AC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x51B2);
    // CALLF 0x1000:8055 (0000_51AD / 0x51AD)
    FarCall(cs1, 0x51B2, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x51B5);
    // ADD SP,0x4 (0000_51B2 / 0x51B2)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x51B8);
    // MOV AX,0x11 (0000_51B5 / 0x51B5)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x51BB);
    // IMUL word ptr [BP + -0xa] (0000_51B8 / 0x51B8)
    int resImul0000_51B8 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_51B8);
    DX = (ushort)(resImul0000_51B8 >> 16);
    CheckExternalEvents(cs1, 0x51BD);
    // MOV BX,AX (0000_51BB / 0x51BB)
    BX = AX;
    CheckExternalEvents(cs1, 0x51C1);
    // MOV ES,word ptr [0x538a] (0000_51BD / 0x51BD)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x51C6);
    // MOV AL,byte ptr ES:[BX + 0xc621] (0000_51C1 / 0x51C1)
    AL = UInt8[ES, (ushort)(BX + 0xC621)];
    CheckExternalEvents(cs1, 0x51C7);
    // CBW  (0000_51C6 / 0x51C6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x51C9);
    // MOV BX,AX (0000_51C7 / 0x51C7)
    BX = AX;
    CheckExternalEvents(cs1, 0x51CD);
    // MOV ES,word ptr [0x53f8] (0000_51C9 / 0x51C9)
    ES = UInt16[DS, 0x53F8];
    CheckExternalEvents(cs1, 0x51D2);
    // MOV AL,byte ptr ES:[BX + 0x4ddb] (0000_51CD / 0x51CD)
    AL = UInt8[ES, (ushort)(BX + 0x4DDB)];
    CheckExternalEvents(cs1, 0x51D3);
    // CBW  (0000_51D2 / 0x51D2)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x51D4);
    // PUSH AX (0000_51D3 / 0x51D3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x51D9);
    // CALLF 0x1000:8b23 (0000_51D4 / 0x51D4)
    FarCall(cs1, 0x51D9, ghidra_guess_1000_8B23_18B23);
    CheckExternalEvents(cs1, 0x51DC);
    // ADD SP,0x2 (0000_51D9 / 0x51D9)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x51DF);
    // MOV AX,0x86d (0000_51DC / 0x51DC)
    AX = 0x86D;
    label_0000_51DF_051DF:
    CheckExternalEvents(cs1, 0x51E0);
    // PUSH DS (0000_51DF / 0x51DF)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x51E1);
    // PUSH AX (0000_51E0 / 0x51E0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x51E6);
    // CALLF 0x1000:8055 (0000_51E1 / 0x51E1)
    FarCall(cs1, 0x51E6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x51E9);
    // ADD SP,0x4 (0000_51E6 / 0x51E6)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_0000_51E9_051E9:
    CheckExternalEvents(cs1, 0x51EE);
    // MOV word ptr [BP + -0x6],0x0 (0000_51E9 / 0x51E9)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_0000_51EE_051EE:
    CheckExternalEvents(cs1, 0x51F1);
    // MOV AX,0x11 (0000_51EE / 0x51EE)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x51F4);
    // IMUL word ptr [BP + -0xa] (0000_51F1 / 0x51F1)
    int resImul0000_51F1 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_51F1);
    DX = (ushort)(resImul0000_51F1 >> 16);
    CheckExternalEvents(cs1, 0x51F6);
    // MOV BX,AX (0000_51F4 / 0x51F4)
    BX = AX;
    CheckExternalEvents(cs1, 0x51F9);
    // ADD BX,word ptr [BP + -0x6] (0000_51F6 / 0x51F6)
    // BX += UInt16[SS, (ushort)(BP - 0x6)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x51FD);
    // MOV ES,word ptr [0x538a] (0000_51F9 / 0x51F9)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5202);
    // MOV AL,byte ptr ES:[BX + 0xc618] (0000_51FD / 0x51FD)
    AL = UInt8[ES, (ushort)(BX + 0xC618)];
    CheckExternalEvents(cs1, 0x5203);
    // CBW  (0000_5202 / 0x5202)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x5206);
    // MOV word ptr [BP + -0xc],AX (0000_5203 / 0x5203)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0x5209);
    // CMP AX,0x4 (0000_5206 / 0x5206)
    Alu16.Sub(AX, 0x4);
    CheckExternalEvents(cs1, 0x520B);
    // JLE 0x0000:5210 (0000_5209 / 0x5209)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_5210_05210;
    }
    CheckExternalEvents(cs1, 0x5210);
    // MOV word ptr [BP + -0xc],0x4 (0000_520B / 0x520B)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x4;
    label_0000_5210_05210:
    CheckExternalEvents(cs1, 0x5213);
    // MOV AX,word ptr [BP + -0x6] (0000_5210 / 0x5210)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x5216);
    // ADD AX,0xd (0000_5213 / 0x5213)
    // AX += 0xD;
    AX = Alu16.Add(AX, 0xD);
    CheckExternalEvents(cs1, 0x5217);
    // PUSH AX (0000_5216 / 0x5216)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x521A);
    // MOV AX,0xc (0000_5217 / 0x5217)
    AX = 0xC;
    CheckExternalEvents(cs1, 0x521B);
    // PUSH AX (0000_521A / 0x521A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x521E);
    // MOV BX,word ptr [BP + -0xc] (0000_521B / 0x521B)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x5220);
    // SHL BX,0x1 (0000_521E / 0x521E)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x5222);
    // SHL BX,0x1 (0000_5220 / 0x5220)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x5226);
    // PUSH word ptr [BX + 0x196] (0000_5222 / 0x5222)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x196)]);
    CheckExternalEvents(cs1, 0x522A);
    // PUSH word ptr [BX + 0x194] (0000_5226 / 0x5226)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x194)]);
    CheckExternalEvents(cs1, 0x522B);
    // PUSH CS (0000_522A / 0x522A)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x522E);
    // CALL 0x0000:3f67 (0000_522B / 0x522B)
    NearCall(cs1, 0x522E, ghidra_guess_0000_3F67_03F67);
    CheckExternalEvents(cs1, 0x5231);
    // ADD SP,0x8 (0000_522E / 0x522E)
    SP += 0x8;
    CheckExternalEvents(cs1, 0x5234);
    // INC word ptr [BP + -0x6] (0000_5231 / 0x5231)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs1, 0x5238);
    // CMP word ptr [BP + -0x6],0x7 (0000_5234 / 0x5234)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x7);
    CheckExternalEvents(cs1, 0x523A);
    // JL 0x0000:51ee (0000_5238 / 0x5238)
    if(SignFlag != OverflowFlag) {
      goto label_0000_51EE_051EE;
    }
    CheckExternalEvents(cs1, 0x523E);
    // MOV ES,word ptr [0x538a] (0000_523A / 0x523A)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5244);
    // CMP byte ptr ES:[0xd450],0x0 (0000_523E / 0x523E)
    Alu8.Sub(UInt8[ES, 0xD450], 0x0);
    CheckExternalEvents(cs1, 0x5246);
    // JZ 0x0000:5253 (0000_5244 / 0x5244)
    if(ZeroFlag) {
      goto label_0000_5253_05253;
    }
    CheckExternalEvents(cs1, 0x5249);
    // MOV AX,0x15 (0000_5246 / 0x5246)
    AX = 0x15;
    CheckExternalEvents(cs1, 0x524A);
    // PUSH AX (0000_5249 / 0x5249)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x524D);
    // MOV AX,0x8 (0000_524A / 0x524A)
    AX = 0x8;
    CheckExternalEvents(cs1, 0x524E);
    // PUSH AX (0000_524D / 0x524D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5251);
    // MOV AX,0x881 (0000_524E / 0x524E)
    AX = 0x881;
    CheckExternalEvents(cs1, 0x5253);
    // JMP 0x0000:525e (0000_5251 / 0x5251)
    goto label_0000_525E_0525E;
    label_0000_5253_05253:
    CheckExternalEvents(cs1, 0x5256);
    // MOV AX,0x15 (0000_5253 / 0x5253)
    AX = 0x15;
    CheckExternalEvents(cs1, 0x5257);
    // PUSH AX (0000_5256 / 0x5256)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x525A);
    // MOV AX,0x8 (0000_5257 / 0x5257)
    AX = 0x8;
    CheckExternalEvents(cs1, 0x525B);
    // PUSH AX (0000_525A / 0x525A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x525E);
    // MOV AX,0x885 (0000_525B / 0x525B)
    AX = 0x885;
    label_0000_525E_0525E:
    CheckExternalEvents(cs1, 0x525F);
    // PUSH DS (0000_525E / 0x525E)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x5260);
    // PUSH AX (0000_525F / 0x525F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5261);
    // PUSH CS (0000_5260 / 0x5260)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5264);
    // CALL 0x0000:3f67 (0000_5261 / 0x5261)
    NearCall(cs1, 0x5264, ghidra_guess_0000_3F67_03F67);
    CheckExternalEvents(cs1, 0x5267);
    // ADD SP,0x8 (0000_5264 / 0x5264)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x526B);
    // MOV ES,word ptr [0x538a] (0000_5267 / 0x5267)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5271);
    // CMP byte ptr ES:[0xd33d],0x0 (0000_526B / 0x526B)
    Alu8.Sub(UInt8[ES, 0xD33D], 0x0);
    CheckExternalEvents(cs1, 0x5273);
    // JZ 0x0000:5280 (0000_5271 / 0x5271)
    if(ZeroFlag) {
      goto label_0000_5280_05280;
    }
    CheckExternalEvents(cs1, 0x5276);
    // MOV AX,0x15 (0000_5273 / 0x5273)
    AX = 0x15;
    CheckExternalEvents(cs1, 0x5277);
    // PUSH AX (0000_5276 / 0x5276)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x527A);
    // MOV AX,0x14 (0000_5277 / 0x5277)
    AX = 0x14;
    CheckExternalEvents(cs1, 0x527B);
    // PUSH AX (0000_527A / 0x527A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x527E);
    // MOV AX,0x888 (0000_527B / 0x527B)
    AX = 0x888;
    CheckExternalEvents(cs1, 0x5280);
    // JMP 0x0000:528b (0000_527E / 0x527E)
    goto label_0000_528B_0528B;
    label_0000_5280_05280:
    CheckExternalEvents(cs1, 0x5283);
    // MOV AX,0x15 (0000_5280 / 0x5280)
    AX = 0x15;
    CheckExternalEvents(cs1, 0x5284);
    // PUSH AX (0000_5283 / 0x5283)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5287);
    // MOV AX,0x14 (0000_5284 / 0x5284)
    AX = 0x14;
    CheckExternalEvents(cs1, 0x5288);
    // PUSH AX (0000_5287 / 0x5287)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x528B);
    // MOV AX,0x88c (0000_5288 / 0x5288)
    AX = 0x88C;
    label_0000_528B_0528B:
    CheckExternalEvents(cs1, 0x528C);
    // PUSH DS (0000_528B / 0x528B)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x528D);
    // PUSH AX (0000_528C / 0x528C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x528E);
    // PUSH CS (0000_528D / 0x528D)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5291);
    // CALL 0x0000:3f67 (0000_528E / 0x528E)
    NearCall(cs1, 0x5291, ghidra_guess_0000_3F67_03F67);
    CheckExternalEvents(cs1, 0x5294);
    // ADD SP,0x8 (0000_5291 / 0x5291)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x5298);
    // MOV ES,word ptr [0x538a] (0000_5294 / 0x5294)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x529E);
    // CMP byte ptr ES:[0xd451],0x0 (0000_5298 / 0x5298)
    Alu8.Sub(UInt8[ES, 0xD451], 0x0);
    CheckExternalEvents(cs1, 0x52A0);
    // JZ 0x0000:52ad (0000_529E / 0x529E)
    if(ZeroFlag) {
      goto label_0000_52AD_052AD;
    }
    CheckExternalEvents(cs1, 0x52A3);
    // MOV AX,0x16 (0000_52A0 / 0x52A0)
    AX = 0x16;
    CheckExternalEvents(cs1, 0x52A4);
    // PUSH AX (0000_52A3 / 0x52A3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x52A7);
    // MOV AX,0x13 (0000_52A4 / 0x52A4)
    AX = 0x13;
    CheckExternalEvents(cs1, 0x52A8);
    // PUSH AX (0000_52A7 / 0x52A7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x52AB);
    // MOV AX,0x88f (0000_52A8 / 0x52A8)
    AX = 0x88F;
    CheckExternalEvents(cs1, 0x52AD);
    // JMP 0x0000:52b8 (0000_52AB / 0x52AB)
    goto label_0000_52B8_052B8;
    label_0000_52AD_052AD:
    CheckExternalEvents(cs1, 0x52B0);
    // MOV AX,0x16 (0000_52AD / 0x52AD)
    AX = 0x16;
    CheckExternalEvents(cs1, 0x52B1);
    // PUSH AX (0000_52B0 / 0x52B0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x52B4);
    // MOV AX,0x13 (0000_52B1 / 0x52B1)
    AX = 0x13;
    CheckExternalEvents(cs1, 0x52B5);
    // PUSH AX (0000_52B4 / 0x52B4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x52B8);
    // MOV AX,0x893 (0000_52B5 / 0x52B5)
    AX = 0x893;
    label_0000_52B8_052B8:
    CheckExternalEvents(cs1, 0x52B9);
    // PUSH DS (0000_52B8 / 0x52B8)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x52BA);
    // PUSH AX (0000_52B9 / 0x52B9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x52BB);
    // PUSH CS (0000_52BA / 0x52BA)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x52BE);
    // CALL 0x0000:3f67 (0000_52BB / 0x52BB)
    NearCall(cs1, 0x52BE, ghidra_guess_0000_3F67_03F67);
    CheckExternalEvents(cs1, 0x52C1);
    // ADD SP,0x8 (0000_52BE / 0x52BE)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x52C6);
    // CALLF 0x1000:933a (0000_52C1 / 0x52C1)
    FarCall(cs1, 0x52C6, unknown_18AD_086A_1933A);
    CheckExternalEvents(cs1, 0x52CB);
    // CALLF 0x1000:8d29 (0000_52C6 / 0x52C6)
    FarCall(cs1, 0x52CB, unknown_18AD_0259_18D29);
    label_0000_52CB_052CB:
    CheckExternalEvents(cs1, 0x52CC);
    // POP SI (0000_52CB / 0x52CB)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x52CE);
    // MOV SP,BP (0000_52CC / 0x52CC)
    SP = BP;
    CheckExternalEvents(cs1, 0x52CF);
    // POP BP (0000_52CE / 0x52CE)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x52D0);
    // RETF  (0000_52CF / 0x52CF)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_52D0_052D0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_52D0_052D0:
    CheckExternalEvents(cs1, 0x52D2);
    // XOR AX,AX (0000_52D0 / 0x52D0)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs1, 0x52D7);
    // CALLF 0x1000:cecc (0000_52D2 / 0x52D2)
    FarCall(cs1, 0x52D7, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x52DC);
    // CALLF 0x1000:7fe8 (0000_52D7 / 0x52D7)
    FarCall(cs1, 0x52DC, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x52DF);
    // MOV AX,0x896 (0000_52DC / 0x52DC)
    AX = 0x896;
    CheckExternalEvents(cs1, 0x52E0);
    // PUSH DS (0000_52DF / 0x52DF)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x52E1);
    // PUSH AX (0000_52E0 / 0x52E0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x52E6);
    // CALLF 0x1000:8055 (0000_52E1 / 0x52E1)
    FarCall(cs1, 0x52E6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x52E9);
    // ADD SP,0x4 (0000_52E6 / 0x52E6)
    SP += 0x4;
    CheckExternalEvents(cs1, 0x52EE);
    // CMP word ptr [0x15c],0x0 (0000_52E9 / 0x52E9)
    Alu16.Sub(UInt16[DS, 0x15C], 0x0);
    CheckExternalEvents(cs1, 0x52F0);
    // JZ 0x0000:52f5 (0000_52EE / 0x52EE)
    if(ZeroFlag) {
      goto label_0000_52F5_052F5;
    }
    CheckExternalEvents(cs1, 0x52F3);
    // MOV AX,0x8c9 (0000_52F0 / 0x52F0)
    AX = 0x8C9;
    CheckExternalEvents(cs1, 0x52F5);
    // JMP 0x0000:52f8 (0000_52F3 / 0x52F3)
    goto label_0000_52F8_052F8;
    label_0000_52F5_052F5:
    CheckExternalEvents(cs1, 0x52F8);
    // MOV AX,0x8cc (0000_52F5 / 0x52F5)
    AX = 0x8CC;
    label_0000_52F8_052F8:
    CheckExternalEvents(cs1, 0x52F9);
    // PUSH DS (0000_52F8 / 0x52F8)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x52FA);
    // PUSH AX (0000_52F9 / 0x52F9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x52FF);
    // CALLF 0x1000:8055 (0000_52FA / 0x52FA)
    FarCall(cs1, 0x52FF, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x5302);
    // ADD SP,0x4 (0000_52FF / 0x52FF)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x5305);
    // MOV AX,0x8ce (0000_5302 / 0x5302)
    AX = 0x8CE;
    CheckExternalEvents(cs1, 0x5306);
    // PUSH DS (0000_5305 / 0x5305)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x5307);
    // PUSH AX (0000_5306 / 0x5306)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x530C);
    // CALLF 0x1000:8055 (0000_5307 / 0x5307)
    FarCall(cs1, 0x530C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x530F);
    // ADD SP,0x4 (0000_530C / 0x530C)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x5312);
    // MOV AX,0x21 (0000_530F / 0x530F)
    AX = 0x21;
    CheckExternalEvents(cs1, 0x5313);
    // PUSH AX (0000_5312 / 0x5312)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5318);
    // CALLF 0x1000:87be (0000_5313 / 0x5313)
    FarCall(cs1, 0x5318, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0x531B);
    // ADD SP,0x2 (0000_5318 / 0x5318)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x531D);
    // OR AX,AX (0000_531B / 0x531B)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0x531F);
    // JZ 0x0000:5342 (0000_531D / 0x531D)
    if(ZeroFlag) {
      goto label_0000_5342_05342;
    }
    CheckExternalEvents(cs1, 0x5322);
    // CMP AX,0x1 (0000_531F / 0x531F)
    Alu16.Sub(AX, 0x1);
    CheckExternalEvents(cs1, 0x5324);
    // JNZ 0x0000:5327 (0000_5322 / 0x5322)
    if(!ZeroFlag) {
      goto label_0000_5327_05327;
    }
    CheckExternalEvents(cs1, 0x5327);
    // JMP 0x0000:53b6 (0000_5324 / 0x5324)
    goto label_0000_53B6_053B6;
    label_0000_5327_05327:
    CheckExternalEvents(cs1, 0x532A);
    // CMP AX,0x2 (0000_5327 / 0x5327)
    Alu16.Sub(AX, 0x2);
    CheckExternalEvents(cs1, 0x532C);
    // JNZ 0x0000:532f (0000_532A / 0x532A)
    if(!ZeroFlag) {
      goto label_0000_532F_0532F;
    }
    CheckExternalEvents(cs1, 0x532F);
    // JMP 0x0000:53e4 (0000_532C / 0x532C)
    goto label_0000_53E4_053E4;
    label_0000_532F_0532F:
    CheckExternalEvents(cs1, 0x5332);
    // CMP AX,0x3 (0000_532F / 0x532F)
    Alu16.Sub(AX, 0x3);
    CheckExternalEvents(cs1, 0x5334);
    // JNZ 0x0000:5337 (0000_5332 / 0x5332)
    if(!ZeroFlag) {
      goto label_0000_5337_05337;
    }
    CheckExternalEvents(cs1, 0x5337);
    // JMP 0x0000:53eb (0000_5334 / 0x5334)
    goto label_0000_53EB_053EB;
    label_0000_5337_05337:
    CheckExternalEvents(cs1, 0x533A);
    // CMP AX,0x4 (0000_5337 / 0x5337)
    Alu16.Sub(AX, 0x4);
    CheckExternalEvents(cs1, 0x533C);
    // JNZ 0x0000:533f (0000_533A / 0x533A)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      CheckExternalEvents(cs1, 0x5342);
      // JMP 0x0000:543f (0000_533F / 0x533F)
      // JMP target is RETF, inlining.
      CheckExternalEvents(cs1, 0x5440);
      // RETF  (0000_543F / 0x543F)
      return FarRet();
    }
    CheckExternalEvents(cs1, 0x533F);
    // JMP 0x0000:5413 (0000_533C / 0x533C)
    goto label_0000_5413_05413;
    label_0000_533F_0533F:
    CheckExternalEvents(cs1, 0x5342);
    // JMP 0x0000:543f (0000_533F / 0x533F)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs1, 0x5440);
    // RETF  (0000_543F / 0x543F)
    return FarRet();
    label_0000_5342_05342:
    CheckExternalEvents(cs1, 0x5347);
    // CALLF 0x1000:7fe8 (0000_5342 / 0x5342)
    FarCall(cs1, 0x5347, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x534A);
    // MOV AX,0x8f9 (0000_5347 / 0x5347)
    AX = 0x8F9;
    CheckExternalEvents(cs1, 0x534B);
    // PUSH DS (0000_534A / 0x534A)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x534C);
    // PUSH AX (0000_534B / 0x534B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5351);
    // CALLF 0x1000:8055 (0000_534C / 0x534C)
    FarCall(cs1, 0x5351, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x5354);
    // ADD SP,0x4 (0000_5351 / 0x5351)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x5358);
    // MOV ES,word ptr [0x53e6] (0000_5354 / 0x5354)
    ES = UInt16[DS, 0x53E6];
    CheckExternalEvents(cs1, 0x535F);
    // MOV word ptr ES:[0x306],0x3 (0000_5358 / 0x5358)
    UInt16[ES, 0x306] = 0x3;
    CheckExternalEvents(cs1, 0x5366);
    // MOV word ptr ES:[0x302],0x1 (0000_535F / 0x535F)
    UInt16[ES, 0x302] = 0x1;
    CheckExternalEvents(cs1, 0x5369);
    // MOV AX,[0x15a] (0000_5366 / 0x5366)
    AX = UInt16[DS, 0x15A];
    CheckExternalEvents(cs1, 0x536A);
    // DEC AX (0000_5369 / 0x5369)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs1, 0x536E);
    // MOV ES:[0x308],AX (0000_536A / 0x536A)
    UInt16[ES, 0x308] = AX;
    CheckExternalEvents(cs1, 0x5373);
    // CMP word ptr [0x15a],0x4 (0000_536E / 0x536E)
    Alu16.Sub(UInt16[DS, 0x15A], 0x4);
    CheckExternalEvents(cs1, 0x5375);
    // JNZ 0x0000:537a (0000_5373 / 0x5373)
    if(!ZeroFlag) {
      goto label_0000_537A_0537A;
    }
    CheckExternalEvents(cs1, 0x537A);
    // DEC word ptr ES:[0x308] (0000_5375 / 0x5375)
    UInt16[ES, 0x308] = Alu16.Dec(UInt16[ES, 0x308]);
    label_0000_537A_0537A:
    CheckExternalEvents(cs1, 0x537D);
    // MOV AX,0x27 (0000_537A / 0x537A)
    AX = 0x27;
    CheckExternalEvents(cs1, 0x537E);
    // PUSH AX (0000_537D / 0x537D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5383);
    // CALLF 0x1000:87be (0000_537E / 0x537E)
    FarCall(cs1, 0x5383, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0x5386);
    // ADD SP,0x2 (0000_5383 / 0x5383)
    SP += 0x2;
    CheckExternalEvents(cs1, 0x5387);
    // INC AX (0000_5386 / 0x5386)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs1, 0x538A);
    // MOV [0x15a],AX (0000_5387 / 0x5387)
    UInt16[DS, 0x15A] = AX;
    CheckExternalEvents(cs1, 0x538D);
    // CMP AX,0x3 (0000_538A / 0x538A)
    Alu16.Sub(AX, 0x3);
    CheckExternalEvents(cs1, 0x538F);
    // JNZ 0x0000:5393 (0000_538D / 0x538D)
    if(!ZeroFlag) {
      goto label_0000_5393_05393;
    }
    CheckExternalEvents(cs1, 0x5393);
    // INC word ptr [0x15a] (0000_538F / 0x538F)
    UInt16[DS, 0x15A] = Alu16.Inc(UInt16[DS, 0x15A]);
    label_0000_5393_05393:
    CheckExternalEvents(cs1, 0x5397);
    // MOV ES,word ptr [0x53e6] (0000_5393 / 0x5393)
    ES = UInt16[DS, 0x53E6];
    CheckExternalEvents(cs1, 0x539E);
    // MOV word ptr ES:[0x302],0x0 (0000_5397 / 0x5397)
    UInt16[ES, 0x302] = 0x0;
    CheckExternalEvents(cs1, 0x53A2);
    // MOV ES,word ptr [0x538a] (0000_539E / 0x539E)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x53A8);
    // CMP byte ptr ES:[0xd34e],0x0 (0000_53A2 / 0x53A2)
    Alu8.Sub(UInt8[ES, 0xD34E], 0x0);
    CheckExternalEvents(cs1, 0x53AA);
    // JNZ 0x0000:53ad (0000_53A8 / 0x53A8)
    if(!ZeroFlag) {
      goto label_0000_53AD_053AD;
    }
    CheckExternalEvents(cs1, 0x53AD);
    // JMP 0x0000:543f (0000_53AA / 0x53AA)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs1, 0x5440);
    // RETF  (0000_543F / 0x543F)
    return FarRet();
    label_0000_53AD_053AD:
    CheckExternalEvents(cs1, 0x53B3);
    // MOV word ptr [0x15a],0x1 (0000_53AD / 0x53AD)
    UInt16[DS, 0x15A] = 0x1;
    CheckExternalEvents(cs1, 0x53B6);
    // JMP 0x0000:543f (0000_53B3 / 0x53B3)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs1, 0x5440);
    // RETF  (0000_543F / 0x543F)
    return FarRet();
    label_0000_53B6_053B6:
    CheckExternalEvents(cs1, 0x53BB);
    // CALLF 0x1000:7fe8 (0000_53B6 / 0x53B6)
    FarCall(cs1, 0x53BB, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x53BE);
    // MOV AX,0x92f (0000_53BB / 0x53BB)
    AX = 0x92F;
    CheckExternalEvents(cs1, 0x53BF);
    // PUSH DS (0000_53BE / 0x53BE)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x53C0);
    // PUSH AX (0000_53BF / 0x53BF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x53C5);
    // CALLF 0x1000:8055 (0000_53C0 / 0x53C0)
    FarCall(cs1, 0x53C5, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x53C8);
    // ADD SP,0x4 (0000_53C5 / 0x53C5)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x53CB);
    // MOV AX,0x22 (0000_53C8 / 0x53C8)
    AX = 0x22;
    CheckExternalEvents(cs1, 0x53CC);
    // PUSH AX (0000_53CB / 0x53CB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x53D1);
    // CALLF 0x1000:87be (0000_53CC / 0x53CC)
    FarCall(cs1, 0x53D1, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0x53D4);
    // ADD SP,0x2 (0000_53D1 / 0x53D1)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x53D7);
    // MOV [0x15e],AX (0000_53D4 / 0x53D4)
    UInt16[DS, 0x15E] = AX;
    label_0000_53D7_053D7:
    CheckExternalEvents(cs1, 0x53DA);
    // MOV AX,0x1 (0000_53D7 / 0x53D7)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x53DB);
    // PUSH AX (0000_53DA / 0x53DA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x53DC);
    // PUSH CS (0000_53DB / 0x53DB)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x53DF);
    // CALL 0x0000:63ac (0000_53DC / 0x53DC)
    NearCall(cs1, 0x53DF, unknown_0170_4CAC_063AC);
    CheckExternalEvents(cs1, 0x53E2);
    // ADD SP,0x2 (0000_53DF / 0x53DF)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x53E4);
    // JMP 0x0000:543f (0000_53E2 / 0x53E2)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs1, 0x5440);
    // RETF  (0000_543F / 0x543F)
    return FarRet();
    label_0000_53E4_053E4:
    CheckExternalEvents(cs1, 0x53E9);
    // XOR byte ptr [0x15c],0x1 (0000_53E4 / 0x53E4)
    // UInt8[DS, 0x15C] ^= 0x1;
    UInt8[DS, 0x15C] = Alu8.Xor(UInt8[DS, 0x15C], 0x1);
    CheckExternalEvents(cs1, 0x53EB);
    // JMP 0x0000:543f (0000_53E9 / 0x53E9)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs1, 0x5440);
    // RETF  (0000_543F / 0x543F)
    return FarRet();
    label_0000_53EB_053EB:
    CheckExternalEvents(cs1, 0x53F0);
    // CALLF 0x1000:7fe8 (0000_53EB / 0x53EB)
    FarCall(cs1, 0x53F0, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x53F3);
    // MOV AX,0x95d (0000_53F0 / 0x53F0)
    AX = 0x95D;
    CheckExternalEvents(cs1, 0x53F4);
    // PUSH DS (0000_53F3 / 0x53F3)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x53F5);
    // PUSH AX (0000_53F4 / 0x53F4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x53FA);
    // CALLF 0x1000:8055 (0000_53F5 / 0x53F5)
    FarCall(cs1, 0x53FA, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x53FD);
    // ADD SP,0x4 (0000_53FA / 0x53FA)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x5400);
    // MOV AX,0x26 (0000_53FD / 0x53FD)
    AX = 0x26;
    CheckExternalEvents(cs1, 0x5401);
    // PUSH AX (0000_5400 / 0x5400)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5406);
    // CALLF 0x1000:87be (0000_5401 / 0x5401)
    FarCall(cs1, 0x5406, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0x5409);
    // ADD SP,0x2 (0000_5406 / 0x5406)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x540D);
    // MOV ES,word ptr [0x538a] (0000_5409 / 0x5409)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5411);
    // MOV ES:[0xd35b],AL (0000_540D / 0x540D)
    UInt8[ES, 0xD35B] = AL;
    CheckExternalEvents(cs1, 0x5413);
    // JMP 0x0000:53d7 (0000_5411 / 0x5411)
    goto label_0000_53D7_053D7;
    label_0000_5413_05413:
    CheckExternalEvents(cs1, 0x5418);
    // CALLF 0x1000:7fe8 (0000_5413 / 0x5413)
    FarCall(cs1, 0x5418, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x541B);
    // MOV AX,0x993 (0000_5418 / 0x5418)
    AX = 0x993;
    CheckExternalEvents(cs1, 0x541C);
    // PUSH DS (0000_541B / 0x541B)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x541D);
    // PUSH AX (0000_541C / 0x541C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5422);
    // CALLF 0x1000:8055 (0000_541D / 0x541D)
    FarCall(cs1, 0x5422, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x5425);
    // ADD SP,0x4 (0000_5422 / 0x5422)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x5428);
    // MOV AX,0x9cf (0000_5425 / 0x5425)
    AX = 0x9CF;
    CheckExternalEvents(cs1, 0x5429);
    // PUSH DS (0000_5428 / 0x5428)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x542A);
    // PUSH AX (0000_5429 / 0x5429)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x542F);
    // CALLF 0x1000:8055 (0000_542A / 0x542A)
    FarCall(cs1, 0x542F, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x5432);
    // ADD SP,0x4 (0000_542F / 0x542F)
    SP += 0x4;
    CheckExternalEvents(cs1, 0x5434);
    // SUB AX,AX (0000_5432 / 0x5432)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x5435);
    // PUSH AX (0000_5434 / 0x5434)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5436);
    // PUSH CS (0000_5435 / 0x5435)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5439);
    // CALL 0x0000:3113 (0000_5436 / 0x5436)
    NearCall(cs1, 0x5439, unknown_0170_1A13_03113);
    CheckExternalEvents(cs1, 0x543C);
    // ADD SP,0x2 (0000_5439 / 0x5439)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x543F);
    // MOV [0x152],AX (0000_543C / 0x543C)
    UInt16[DS, 0x152] = AX;
    label_0000_543F_0543F:
    CheckExternalEvents(cs1, 0x5440);
    // RETF  (0000_543F / 0x543F)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_5440_05440(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_5440_05440:
    CheckExternalEvents(cs1, 0x5441);
    // PUSH BP (0000_5440 / 0x5440)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x5443);
    // MOV BP,SP (0000_5441 / 0x5441)
    BP = SP;
    CheckExternalEvents(cs1, 0x5446);
    // MOV AX,0x12 (0000_5443 / 0x5443)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x544B);
    // CALLF 0x1000:cecc (0000_5446 / 0x5446)
    FarCall(cs1, 0x544B, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x544C);
    // PUSH SI (0000_544B / 0x544B)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x5452);
    // MOV word ptr [0x14c],0x1 (0000_544C / 0x544C)
    UInt16[DS, 0x14C] = 0x1;
    CheckExternalEvents(cs1, 0x5456);
    // MOV ES,word ptr [0x538c] (0000_5452 / 0x5452)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x545A);
    // MOV AX,ES:[0xa44b] (0000_5456 / 0x5456)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x545D);
    // MOV word ptr [BP + -0x4],AX (0000_545A / 0x545A)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x5460);
    // MOV word ptr [BP + -0xa],AX (0000_545D / 0x545D)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0x5464);
    // MOV ES,word ptr [0x538e] (0000_5460 / 0x5460)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x5468);
    // MOV AX,ES:[0xa44d] (0000_5464 / 0x5464)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x546B);
    // MOV word ptr [BP + -0x6],AX (0000_5468 / 0x5468)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0x546E);
    // MOV word ptr [BP + -0xe],AX (0000_546B / 0x546B)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs1, 0x5472);
    // MOV ES,word ptr [0x538a] (0000_546E / 0x546E)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5478);
    // CMP byte ptr ES:[0xd346],0x0 (0000_5472 / 0x5472)
    Alu8.Sub(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs1, 0x547A);
    // JZ 0x0000:547f (0000_5478 / 0x5478)
    if(ZeroFlag) {
      goto label_0000_547F_0547F;
    }
    CheckExternalEvents(cs1, 0x547F);
    // CALLF 0x0000:cff7 (0000_547A / 0x547A)
    FarCall(cs1, 0x547F, ghidra_guess_0000_CFF7_0CFF7);
    label_0000_547F_0547F:
    CheckExternalEvents(cs1, 0x5484);
    // MOV word ptr [BP + -0x8],0x0 (0000_547F / 0x547F)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    label_0000_5484_05484:
    CheckExternalEvents(cs1, 0x5488);
    // MOV ES,word ptr [0x538a] (0000_5484 / 0x5484)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x548E);
    // CMP byte ptr ES:[0xd346],0x0 (0000_5488 / 0x5488)
    Alu8.Sub(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs1, 0x5490);
    // JNZ 0x0000:5498 (0000_548E / 0x548E)
    if(!ZeroFlag) {
      goto label_0000_5498_05498;
    }
    CheckExternalEvents(cs1, 0x5496);
    // CMP byte ptr ES:[0xd310],0x0 (0000_5490 / 0x5490)
    Alu8.Sub(UInt8[ES, 0xD310], 0x0);
    CheckExternalEvents(cs1, 0x5498);
    // JNZ 0x0000:54ab (0000_5496 / 0x5496)
    if(!ZeroFlag) {
      goto label_0000_54AB_054AB;
    }
    label_0000_5498_05498:
    CheckExternalEvents(cs1, 0x549D);
    // MOV word ptr [BP + -0x8],0x1 (0000_5498 / 0x5498)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    CheckExternalEvents(cs1, 0x54A3);
    // CMP byte ptr ES:[0xd346],0x0 (0000_549D / 0x549D)
    Alu8.Sub(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs1, 0x54A5);
    // JZ 0x0000:54ab (0000_54A3 / 0x54A3)
    if(ZeroFlag) {
      goto label_0000_54AB_054AB;
    }
    CheckExternalEvents(cs1, 0x54AB);
    // AND byte ptr ES:[0xd178],0x7f (0000_54A5 / 0x54A5)
    // UInt8[ES, 0xD178] &= 0x7F;
    UInt8[ES, 0xD178] = Alu8.And(UInt8[ES, 0xD178], 0x7F);
    label_0000_54AB_054AB:
    CheckExternalEvents(cs1, 0x54AE);
    // PUSH word ptr [BP + -0xe] (0000_54AB / 0x54AB)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs1, 0x54B1);
    // PUSH word ptr [BP + -0xa] (0000_54AE / 0x54AE)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x54B2);
    // PUSH CS (0000_54B1 / 0x54B1)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x54B5);
    // CALL 0x0000:56ae (0000_54B2 / 0x54B2)
    NearCall(cs1, 0x54B5, ghidra_guess_0000_56AE_056AE);
    CheckExternalEvents(cs1, 0x54B8);
    // ADD SP,0x4 (0000_54B5 / 0x54B5)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x54B9);
    // PUSH AX (0000_54B8 / 0x54B8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x54BE);
    // CALLF 0x1000:897d (0000_54B9 / 0x54B9)
    FarCall(cs1, 0x54BE, unknown_17C6_0D1D_1897D);
    CheckExternalEvents(cs1, 0x54C1);
    // ADD SP,0x2 (0000_54BE / 0x54BE)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x54C4);
    // MOV word ptr [BP + -0x12],AX (0000_54C1 / 0x54C1)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs1, 0x54C7);
    // CMP AX,0x20 (0000_54C4 / 0x54C4)
    Alu16.Sub(AX, 0x20);
    CheckExternalEvents(cs1, 0x54C9);
    // JNZ 0x0000:54d1 (0000_54C7 / 0x54C7)
    if(!ZeroFlag) {
      goto label_0000_54D1_054D1;
    }
    CheckExternalEvents(cs1, 0x54CE);
    // MOV word ptr [BP + -0x8],0x1 (0000_54C9 / 0x54C9)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    CheckExternalEvents(cs1, 0x54D1);
    // JMP 0x0000:558f (0000_54CE / 0x54CE)
    goto label_0000_558F_0558F;
    label_0000_54D1_054D1:
    CheckExternalEvents(cs1, 0x54D5);
    // MOV ES,word ptr [0x538c] (0000_54D1 / 0x54D1)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x54D8);
    // MOV AX,word ptr [BP + -0x4] (0000_54D5 / 0x54D5)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0x54DC);
    // MOV ES:[0xa44b],AX (0000_54D8 / 0x54D8)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs1, 0x54E0);
    // MOV ES,word ptr [0x538e] (0000_54DC / 0x54DC)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x54E3);
    // MOV AX,word ptr [BP + -0x6] (0000_54E0 / 0x54E0)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x54E7);
    // MOV ES:[0xa44d],AX (0000_54E3 / 0x54E3)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs1, 0x54EB);
    // CMP word ptr [BP + -0x12],-0x48 (0000_54E7 / 0x54E7)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFB8);
    CheckExternalEvents(cs1, 0x54ED);
    // JZ 0x0000:54f9 (0000_54EB / 0x54EB)
    if(ZeroFlag) {
      goto label_0000_54F9_054F9;
    }
    CheckExternalEvents(cs1, 0x54F1);
    // CMP word ptr [BP + -0x12],-0x49 (0000_54ED / 0x54ED)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFB7);
    CheckExternalEvents(cs1, 0x54F3);
    // JZ 0x0000:54f9 (0000_54F1 / 0x54F1)
    if(ZeroFlag) {
      goto label_0000_54F9_054F9;
    }
    CheckExternalEvents(cs1, 0x54F7);
    // CMP word ptr [BP + -0x12],-0x47 (0000_54F3 / 0x54F3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFB9);
    CheckExternalEvents(cs1, 0x54F9);
    // JNZ 0x0000:5509 (0000_54F7 / 0x54F7)
    if(!ZeroFlag) {
      goto label_0000_5509_05509;
    }
    label_0000_54F9_054F9:
    CheckExternalEvents(cs1, 0x5500);
    // CMP word ptr ES:[0xa44d],0x2000 (0000_54F9 / 0x54F9)
    Alu16.Sub(UInt16[ES, 0xA44D], 0x2000);
    CheckExternalEvents(cs1, 0x5502);
    // JC 0x0000:5509 (0000_5500 / 0x5500)
    if(CarryFlag) {
      goto label_0000_5509_05509;
    }
    CheckExternalEvents(cs1, 0x5509);
    // SUB word ptr ES:[0xa44d],0x2000 (0000_5502 / 0x5502)
    UInt16[ES, 0xA44D] -= 0x2000;
    label_0000_5509_05509:
    CheckExternalEvents(cs1, 0x550D);
    // CMP word ptr [BP + -0x12],-0x50 (0000_5509 / 0x5509)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFB0);
    CheckExternalEvents(cs1, 0x550F);
    // JZ 0x0000:551b (0000_550D / 0x550D)
    if(ZeroFlag) {
      goto label_0000_551B_0551B;
    }
    CheckExternalEvents(cs1, 0x5513);
    // CMP word ptr [BP + -0x12],-0x51 (0000_550F / 0x550F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFAF);
    CheckExternalEvents(cs1, 0x5515);
    // JZ 0x0000:551b (0000_5513 / 0x5513)
    if(ZeroFlag) {
      goto label_0000_551B_0551B;
    }
    CheckExternalEvents(cs1, 0x5519);
    // CMP word ptr [BP + -0x12],-0x4f (0000_5515 / 0x5515)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFB1);
    CheckExternalEvents(cs1, 0x551B);
    // JNZ 0x0000:552e (0000_5519 / 0x5519)
    if(!ZeroFlag) {
      goto label_0000_552E_0552E;
    }
    label_0000_551B_0551B:
    CheckExternalEvents(cs1, 0x551F);
    // MOV ES,word ptr [0x538e] (0000_551B / 0x551B)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x5526);
    // CMP word ptr ES:[0xa44d],0xe000 (0000_551F / 0x551F)
    Alu16.Sub(UInt16[ES, 0xA44D], 0xE000);
    CheckExternalEvents(cs1, 0x5528);
    // JNC 0x0000:552e (0000_5526 / 0x5526)
    if(!CarryFlag) {
      goto label_0000_552E_0552E;
    }
    CheckExternalEvents(cs1, 0x552E);
    // ADD byte ptr ES:[0xa44e],0x20 (0000_5528 / 0x5528)
    UInt8[ES, 0xA44E] += 0x20;
    label_0000_552E_0552E:
    CheckExternalEvents(cs1, 0x5532);
    // CMP word ptr [BP + -0x12],-0x4b (0000_552E / 0x552E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFB5);
    CheckExternalEvents(cs1, 0x5534);
    // JZ 0x0000:5540 (0000_5532 / 0x5532)
    if(ZeroFlag) {
      goto label_0000_5540_05540;
    }
    CheckExternalEvents(cs1, 0x5538);
    // CMP word ptr [BP + -0x12],-0x47 (0000_5534 / 0x5534)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFB9);
    CheckExternalEvents(cs1, 0x553A);
    // JZ 0x0000:5540 (0000_5538 / 0x5538)
    if(ZeroFlag) {
      goto label_0000_5540_05540;
    }
    CheckExternalEvents(cs1, 0x553E);
    // CMP word ptr [BP + -0x12],-0x4f (0000_553A / 0x553A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFB1);
    CheckExternalEvents(cs1, 0x5540);
    // JNZ 0x0000:5554 (0000_553E / 0x553E)
    if(!ZeroFlag) {
      goto label_0000_5554_05554;
    }
    label_0000_5540_05540:
    CheckExternalEvents(cs1, 0x5544);
    // MOV ES,word ptr [0x538c] (0000_5540 / 0x5540)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x554B);
    // CMP word ptr ES:[0xa44b],0x300 (0000_5544 / 0x5544)
    Alu16.Sub(UInt16[ES, 0xA44B], 0x300);
    CheckExternalEvents(cs1, 0x554D);
    // JC 0x0000:5554 (0000_554B / 0x554B)
    if(CarryFlag) {
      goto label_0000_5554_05554;
    }
    CheckExternalEvents(cs1, 0x5554);
    // SUB word ptr ES:[0xa44b],0x200 (0000_554D / 0x554D)
    UInt16[ES, 0xA44B] -= 0x200;
    label_0000_5554_05554:
    CheckExternalEvents(cs1, 0x5558);
    // CMP word ptr [BP + -0x12],-0x4d (0000_5554 / 0x5554)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFB3);
    CheckExternalEvents(cs1, 0x555A);
    // JZ 0x0000:5566 (0000_5558 / 0x5558)
    if(ZeroFlag) {
      goto label_0000_5566_05566;
    }
    CheckExternalEvents(cs1, 0x555E);
    // CMP word ptr [BP + -0x12],-0x49 (0000_555A / 0x555A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFB7);
    CheckExternalEvents(cs1, 0x5560);
    // JZ 0x0000:5566 (0000_555E / 0x555E)
    if(ZeroFlag) {
      goto label_0000_5566_05566;
    }
    CheckExternalEvents(cs1, 0x5564);
    // CMP word ptr [BP + -0x12],-0x51 (0000_5560 / 0x5560)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xFFAF);
    CheckExternalEvents(cs1, 0x5566);
    // JNZ 0x0000:5579 (0000_5564 / 0x5564)
    if(!ZeroFlag) {
      goto label_0000_5579_05579;
    }
    label_0000_5566_05566:
    CheckExternalEvents(cs1, 0x556A);
    // MOV ES,word ptr [0x538c] (0000_5566 / 0x5566)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x5571);
    // CMP word ptr ES:[0xa44b],0xd00 (0000_556A / 0x556A)
    Alu16.Sub(UInt16[ES, 0xA44B], 0xD00);
    CheckExternalEvents(cs1, 0x5573);
    // JNC 0x0000:5579 (0000_5571 / 0x5571)
    if(!CarryFlag) {
      goto label_0000_5579_05579;
    }
    CheckExternalEvents(cs1, 0x5579);
    // ADD byte ptr ES:[0xa44c],0x2 (0000_5573 / 0x5573)
    // UInt8[ES, 0xA44C] += 0x2;
    UInt8[ES, 0xA44C] = Alu8.Add(UInt8[ES, 0xA44C], 0x2);
    label_0000_5579_05579:
    CheckExternalEvents(cs1, 0x557D);
    // MOV ES,word ptr [0x538c] (0000_5579 / 0x5579)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x5581);
    // MOV AX,ES:[0xa44b] (0000_557D / 0x557D)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x5584);
    // MOV word ptr [BP + -0x4],AX (0000_5581 / 0x5581)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x5588);
    // MOV ES,word ptr [0x538e] (0000_5584 / 0x5584)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x558C);
    // MOV AX,ES:[0xa44d] (0000_5588 / 0x5588)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x558F);
    // MOV word ptr [BP + -0x6],AX (0000_558C / 0x558C)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    label_0000_558F_0558F:
    CheckExternalEvents(cs1, 0x5593);
    // CMP word ptr [BP + -0x8],0x0 (0000_558F / 0x558F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs1, 0x5595);
    // JNZ 0x0000:5598 (0000_5593 / 0x5593)
    if(!ZeroFlag) {
      goto label_0000_5598_05598;
    }
    CheckExternalEvents(cs1, 0x5598);
    // JMP 0x0000:5484 (0000_5595 / 0x5595)
    goto label_0000_5484_05484;
    label_0000_5598_05598:
    CheckExternalEvents(cs1, 0x559C);
    // MOV ES,word ptr [0x538c] (0000_5598 / 0x5598)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x559F);
    // MOV AX,word ptr [BP + -0xa] (0000_559C / 0x559C)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x55A3);
    // MOV ES:[0xa44b],AX (0000_559F / 0x559F)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs1, 0x55A7);
    // MOV ES,word ptr [0x538e] (0000_55A3 / 0x55A3)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x55AA);
    // MOV AX,word ptr [BP + -0xe] (0000_55A7 / 0x55A7)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0x55AE);
    // MOV ES:[0xa44d],AX (0000_55AA / 0x55AA)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs1, 0x55B2);
    // MOV ES,word ptr [0x538a] (0000_55AE / 0x55AE)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x55B8);
    // CMP byte ptr ES:[0xd346],0x0 (0000_55B2 / 0x55B2)
    Alu8.Sub(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs1, 0x55BA);
    // JZ 0x0000:55bd (0000_55B8 / 0x55B8)
    if(ZeroFlag) {
      goto label_0000_55BD_055BD;
    }
    CheckExternalEvents(cs1, 0x55BD);
    // JMP 0x0000:565a (0000_55BA / 0x55BA)
    goto label_0000_565A_0565A;
    label_0000_55BD_055BD:
    CheckExternalEvents(cs1, 0x55C1);
    // MOV ES,word ptr [0x538c] (0000_55BD / 0x55BD)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x55C5);
    // MOV AX,ES:[0xa44b] (0000_55C1 / 0x55C1)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x55C9);
    // MOV ES,word ptr [0x538e] (0000_55C5 / 0x55C5)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x55CE);
    // OR AX,word ptr ES:[0xa44d] (0000_55C9 / 0x55C9)
    // AX |= UInt16[ES, 0xA44D];
    AX = Alu16.Or(AX, UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0x55D0);
    // MOV CL,0x8 (0000_55CE / 0x55CE)
    CL = 0x8;
    CheckExternalEvents(cs1, 0x55D2);
    // SHR AX,CL (0000_55D0 / 0x55D0)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs1, 0x55D5);
    // MOV word ptr [BP + -0x2],AX (0000_55D2 / 0x55D2)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x55D9);
    // MOV byte ptr [BP + -0x1],0x0 (0000_55D5 / 0x55D5)
    UInt8[SS, (ushort)(BP - 0x1)] = 0x0;
    CheckExternalEvents(cs1, 0x55DC);
    // PUSH word ptr [BP + -0x2] (0000_55D9 / 0x55D9)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x55E1);
    // CALLF 0x1000:af3e (0000_55DC / 0x55DC)
    FarCall(cs1, 0x55E1, unknown_19EF_104E_1AF3E);
    CheckExternalEvents(cs1, 0x55E4);
    // ADD SP,0x2 (0000_55E1 / 0x55E1)
    SP += 0x2;
    CheckExternalEvents(cs1, 0x55E8);
    // SUB word ptr [BP + -0x2],0x11 (0000_55E4 / 0x55E4)
    // UInt16[SS, (ushort)(BP - 0x2)] -= 0x11;
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x11);
    CheckExternalEvents(cs1, 0x55ED);
    // MOV word ptr [BP + -0x10],0x0 (0000_55E8 / 0x55E8)
    UInt16[SS, (ushort)(BP - 0x10)] = 0x0;
    label_0000_55ED_055ED:
    CheckExternalEvents(cs1, 0x55F2);
    // MOV word ptr [BP + -0xc],0x0 (0000_55ED / 0x55ED)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    label_0000_55F2_055F2:
    CheckExternalEvents(cs1, 0x55F5);
    // MOV SI,word ptr [BP + -0x2] (0000_55F2 / 0x55F2)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0x55F8);
    // ADD SI,word ptr [BP + -0xc] (0000_55F5 / 0x55F5)
    // SI += UInt16[SS, (ushort)(BP - 0xC)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x55FA);
    // JS 0x0000:5624 (0000_55F8 / 0x55F8)
    if(SignFlag) {
      goto label_0000_5624_05624;
    }
    CheckExternalEvents(cs1, 0x55FE);
    // CMP SI,0x100 (0000_55FA / 0x55FA)
    Alu16.Sub(SI, 0x100);
    CheckExternalEvents(cs1, 0x5600);
    // JGE 0x0000:5624 (0000_55FE / 0x55FE)
    if(SignFlag == OverflowFlag) {
      goto label_0000_5624_05624;
    }
    CheckExternalEvents(cs1, 0x5604);
    // MOV ES,word ptr [0x53d0] (0000_5600 / 0x5600)
    ES = UInt16[DS, 0x53D0];
    CheckExternalEvents(cs1, 0x560A);
    // CMP byte ptr ES:[SI + 0x30],0x0 (0000_5604 / 0x5604)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0x30)], 0x0);
    CheckExternalEvents(cs1, 0x560C);
    // JZ 0x0000:5624 (0000_560A / 0x560A)
    if(ZeroFlag) {
      goto label_0000_5624_05624;
    }
    CheckExternalEvents(cs1, 0x5611);
    // MOV AL,byte ptr ES:[SI + 0x30] (0000_560C / 0x560C)
    AL = UInt8[ES, (ushort)(SI + 0x30)];
    CheckExternalEvents(cs1, 0x5612);
    // CBW  (0000_5611 / 0x5611)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x5613);
    // PUSH AX (0000_5612 / 0x5612)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5616);
    // MOV AX,0x3 (0000_5613 / 0x5613)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x5619);
    // IMUL word ptr [BP + -0x10] (0000_5616 / 0x5616)
    int resImul0000_5616 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x10)]);
    AX = (ushort)(resImul0000_5616);
    DX = (ushort)(resImul0000_5616 >> 16);
    CheckExternalEvents(cs1, 0x561C);
    // ADD AX,word ptr [BP + -0xc] (0000_5619 / 0x5619)
    // AX += UInt16[SS, (ushort)(BP - 0xC)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x561D);
    // PUSH AX (0000_561C / 0x561C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x561E);
    // PUSH CS (0000_561D / 0x561D)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5621);
    // CALL 0x0000:44a8 (0000_561E / 0x561E)
    NearCall(cs1, 0x5621, unknown_0170_2DA8_044A8);
    CheckExternalEvents(cs1, 0x5624);
    // ADD SP,0x4 (0000_5621 / 0x5621)
    SP += 0x4;
    label_0000_5624_05624:
    CheckExternalEvents(cs1, 0x5627);
    // INC word ptr [BP + -0xc] (0000_5624 / 0x5624)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs1, 0x562B);
    // CMP word ptr [BP + -0xc],0x3 (0000_5627 / 0x5627)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x3);
    CheckExternalEvents(cs1, 0x562D);
    // JL 0x0000:55f2 (0000_562B / 0x562B)
    if(SignFlag != OverflowFlag) {
      goto label_0000_55F2_055F2;
    }
    CheckExternalEvents(cs1, 0x5631);
    // ADD word ptr [BP + -0x2],0x10 (0000_562D / 0x562D)
    UInt16[SS, (ushort)(BP - 0x2)] += 0x10;
    CheckExternalEvents(cs1, 0x5634);
    // INC word ptr [BP + -0x10] (0000_5631 / 0x5631)
    UInt16[SS, (ushort)(BP - 0x10)]++;
    CheckExternalEvents(cs1, 0x5638);
    // CMP word ptr [BP + -0x10],0x3 (0000_5634 / 0x5634)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x10)], 0x3);
    CheckExternalEvents(cs1, 0x563A);
    // JL 0x0000:55ed (0000_5638 / 0x5638)
    if(SignFlag != OverflowFlag) {
      goto label_0000_55ED_055ED;
    }
    CheckExternalEvents(cs1, 0x563F);
    // MOV word ptr [BP + -0xc],0x0 (0000_563A / 0x563A)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    label_0000_563F_0563F:
    CheckExternalEvents(cs1, 0x5642);
    // MOV BX,word ptr [BP + -0xc] (0000_563F / 0x563F)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x5646);
    // MOV ES,word ptr [0x53ce] (0000_5642 / 0x5642)
    ES = UInt16[DS, 0x53CE];
    CheckExternalEvents(cs1, 0x564C);
    // MOV byte ptr ES:[BX + 0x9f3],0xff (0000_5646 / 0x5646)
    UInt8[ES, (ushort)(BX + 0x9F3)] = 0xFF;
    CheckExternalEvents(cs1, 0x564F);
    // INC word ptr [BP + -0xc] (0000_564C / 0x564C)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs1, 0x5653);
    // CMP word ptr [BP + -0xc],0x3 (0000_564F / 0x564F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x3);
    CheckExternalEvents(cs1, 0x5655);
    // JL 0x0000:563f (0000_5653 / 0x5653)
    if(SignFlag != OverflowFlag) {
      goto label_0000_563F_0563F;
    }
    CheckExternalEvents(cs1, 0x565A);
    // CALLF 0x1000:bc98 (0000_5655 / 0x5655)
    FarCall(cs1, 0x565A, unknown_19EF_1DA8_1BC98);
    label_0000_565A_0565A:
    CheckExternalEvents(cs1, 0x565E);
    // MOV ES,word ptr [0x538e] (0000_565A / 0x565A)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x5663);
    // PUSH word ptr ES:[0xa44d] (0000_565E / 0x565E)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0x5667);
    // MOV ES,word ptr [0x538c] (0000_5663 / 0x5663)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x566C);
    // PUSH word ptr ES:[0xa44b] (0000_5667 / 0x5667)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs1, 0x5671);
    // CALLF 0x1000:b204 (0000_566C / 0x566C)
    FarCall(cs1, 0x5671, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs1, 0x5674);
    // ADD SP,0x4 (0000_5671 / 0x5671)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x5679);
    // CALLF 0x1000:b7df (0000_5674 / 0x5674)
    FarCall(cs1, 0x5679, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs1, 0x567A);
    // PUSH CS (0000_5679 / 0x5679)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x567D);
    // CALL 0x0000:1c1b (0000_567A / 0x567A)
    NearCall(cs1, 0x567D, unknown_0170_051B_01C1B);
    CheckExternalEvents(cs1, 0x5682);
    // CALLF 0x1000:9193 (0000_567D / 0x567D)
    FarCall(cs1, 0x5682, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs1, 0x5685);
    // MOV AX,0x1 (0000_5682 / 0x5682)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x5686);
    // PUSH AX (0000_5685 / 0x5685)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5687);
    // PUSH CS (0000_5686 / 0x5686)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x568A);
    // CALL 0x0000:63ac (0000_5687 / 0x5687)
    NearCall(cs1, 0x568A, unknown_0170_4CAC_063AC);
    CheckExternalEvents(cs1, 0x568D);
    // ADD SP,0x2 (0000_568A / 0x568A)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x5692);
    // CALLF 0x1000:7fe8 (0000_568D / 0x568D)
    FarCall(cs1, 0x5692, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x5698);
    // MOV word ptr [0x14c],0x0 (0000_5692 / 0x5692)
    UInt16[DS, 0x14C] = 0x0;
    CheckExternalEvents(cs1, 0x569C);
    // MOV ES,word ptr [0x538a] (0000_5698 / 0x5698)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x56A2);
    // CMP byte ptr ES:[0xd346],0x0 (0000_569C / 0x569C)
    Alu8.Sub(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs1, 0x56A4);
    // JZ 0x0000:56a9 (0000_56A2 / 0x56A2)
    if(ZeroFlag) {
      goto label_0000_56A9_056A9;
    }
    CheckExternalEvents(cs1, 0x56A9);
    // CALLF 0x0000:cff7 (0000_56A4 / 0x56A4)
    FarCall(cs1, 0x56A9, ghidra_guess_0000_CFF7_0CFF7);
    label_0000_56A9_056A9:
    CheckExternalEvents(cs1, 0x56AA);
    // POP SI (0000_56A9 / 0x56A9)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x56AC);
    // MOV SP,BP (0000_56AA / 0x56AA)
    SP = BP;
    CheckExternalEvents(cs1, 0x56AD);
    // POP BP (0000_56AC / 0x56AC)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x56AE);
    // RETF  (0000_56AD / 0x56AD)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_56AE_056AE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_56AE_056AE:
    CheckExternalEvents(cs1, 0x56AF);
    // PUSH BP (0000_56AE / 0x56AE)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x56B1);
    // MOV BP,SP (0000_56AF / 0x56AF)
    BP = SP;
    CheckExternalEvents(cs1, 0x56B4);
    // MOV AX,0x3c (0000_56B1 / 0x56B1)
    AX = 0x3C;
    CheckExternalEvents(cs1, 0x56B9);
    // CALLF 0x1000:cecc (0000_56B4 / 0x56B4)
    FarCall(cs1, 0x56B9, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x56BA);
    // PUSH SI (0000_56B9 / 0x56B9)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x56BF);
    // CALLF 0x1000:beae (0000_56BA / 0x56BA)
    FarCall(cs1, 0x56BF, unknown_19EF_1FBE_1BEAE);
    CheckExternalEvents(cs1, 0x56C4);
    // MOV word ptr [BP + -0x18],0x90 (0000_56BF / 0x56BF)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x90;
    CheckExternalEvents(cs1, 0x56C9);
    // MOV word ptr [BP + -0x1e],0x4000 (0000_56C4 / 0x56C4)
    UInt16[SS, (ushort)(BP - 0x1E)] = 0x4000;
    CheckExternalEvents(cs1, 0x56CD);
    // MOV ES,word ptr [0x538c] (0000_56C9 / 0x56C9)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x56D1);
    // MOV AX,ES:[0xa44b] (0000_56CD / 0x56CD)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x56D4);
    // MOV word ptr [BP + -0x2],AX (0000_56D1 / 0x56D1)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x56D8);
    // MOV ES,word ptr [0x538e] (0000_56D4 / 0x56D4)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x56DC);
    // MOV AX,ES:[0xa44d] (0000_56D8 / 0x56D8)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x56DF);
    // MOV word ptr [BP + -0x6],AX (0000_56DC / 0x56DC)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0x56E3);
    // MOV ES,word ptr [0x538c] (0000_56DF / 0x56DF)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x56E7);
    // MOV AX,ES:[0xa44b] (0000_56E3 / 0x56E3)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x56EA);
    // AND AX,0xf00 (0000_56E7 / 0x56E7)
    // AX &= 0xF00;
    AX = Alu16.And(AX, 0xF00);
    CheckExternalEvents(cs1, 0x56EC);
    // MOV CL,0x8 (0000_56EA / 0x56EA)
    CL = 0x8;
    CheckExternalEvents(cs1, 0x56EE);
    // SHR AX,CL (0000_56EC / 0x56EC)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs1, 0x56F1);
    // MOV word ptr [BP + -0x20],AX (0000_56EE / 0x56EE)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    CheckExternalEvents(cs1, 0x56F5);
    // MOV ES,word ptr [0x538e] (0000_56F1 / 0x56F1)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x56F9);
    // MOV AX,ES:[0xa44d] (0000_56F5 / 0x56F5)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x56FC);
    // AND AX,0xf000 (0000_56F9 / 0x56F9)
    AX &= 0xF000;
    CheckExternalEvents(cs1, 0x56FE);
    // SHR AX,CL (0000_56FC / 0x56FC)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs1, 0x5701);
    // MOV word ptr [BP + -0x24],AX (0000_56FE / 0x56FE)
    UInt16[SS, (ushort)(BP - 0x24)] = AX;
    CheckExternalEvents(cs1, 0x5705);
    // SUB word ptr [BP + -0x20],0x2 (0000_5701 / 0x5701)
    // UInt16[SS, (ushort)(BP - 0x20)] -= 0x2;
    UInt16[SS, (ushort)(BP - 0x20)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0x2);
    CheckExternalEvents(cs1, 0x5707);
    // JNS 0x0000:570c (0000_5705 / 0x5705)
    if(!SignFlag) {
      goto label_0000_570C_0570C;
    }
    CheckExternalEvents(cs1, 0x570C);
    // MOV word ptr [BP + -0x20],0x0 (0000_5707 / 0x5707)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x0;
    label_0000_570C_0570C:
    CheckExternalEvents(cs1, 0x5710);
    // CMP word ptr [BP + -0x20],0xb (0000_570C / 0x570C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0xB);
    CheckExternalEvents(cs1, 0x5712);
    // JLE 0x0000:5717 (0000_5710 / 0x5710)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_5717_05717;
    }
    CheckExternalEvents(cs1, 0x5717);
    // MOV word ptr [BP + -0x20],0xb (0000_5712 / 0x5712)
    UInt16[SS, (ushort)(BP - 0x20)] = 0xB;
    label_0000_5717_05717:
    CheckExternalEvents(cs1, 0x571B);
    // SUB word ptr [BP + -0x24],0x10 (0000_5717 / 0x5717)
    // UInt16[SS, (ushort)(BP - 0x24)] -= 0x10;
    UInt16[SS, (ushort)(BP - 0x24)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x10);
    CheckExternalEvents(cs1, 0x571D);
    // JNS 0x0000:5722 (0000_571B / 0x571B)
    if(!SignFlag) {
      goto label_0000_5722_05722;
    }
    CheckExternalEvents(cs1, 0x5722);
    // MOV word ptr [BP + -0x24],0x0 (0000_571D / 0x571D)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x0;
    label_0000_5722_05722:
    CheckExternalEvents(cs1, 0x5727);
    // CMP word ptr [BP + -0x24],0xd0 (0000_5722 / 0x5722)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0xD0);
    CheckExternalEvents(cs1, 0x5729);
    // JLE 0x0000:572e (0000_5727 / 0x5727)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_572E_0572E;
    }
    CheckExternalEvents(cs1, 0x572E);
    // MOV word ptr [BP + -0x24],0xd0 (0000_5729 / 0x5729)
    UInt16[SS, (ushort)(BP - 0x24)] = 0xD0;
    label_0000_572E_0572E:
    CheckExternalEvents(cs1, 0x5731);
    // MOV AX,word ptr [BP + -0x24] (0000_572E / 0x572E)
    AX = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs1, 0x5733);
    // MOV CL,0x3 (0000_5731 / 0x5731)
    CL = 0x3;
    CheckExternalEvents(cs1, 0x5735);
    // SHL AX,CL (0000_5733 / 0x5733)
    AX <<= CL;
    CheckExternalEvents(cs1, 0x5738);
    // ADD AX,word ptr [BP + -0x20] (0000_5735 / 0x5735)
    // AX += UInt16[SS, (ushort)(BP - 0x20)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x20)]);
    CheckExternalEvents(cs1, 0x573B);
    // MOV word ptr [BP + -0x32],AX (0000_5738 / 0x5738)
    UInt16[SS, (ushort)(BP - 0x32)] = AX;
    CheckExternalEvents(cs1, 0x573F);
    // MOV ES,word ptr [0x538a] (0000_573B / 0x573B)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5745);
    // CMP byte ptr ES:[0xd346],0x0 (0000_573F / 0x573F)
    Alu8.Sub(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs1, 0x5747);
    // JZ 0x0000:574a (0000_5745 / 0x5745)
    if(ZeroFlag) {
      goto label_0000_574A_0574A;
    }
    CheckExternalEvents(cs1, 0x574A);
    // JMP 0x0000:59d7 (0000_5747 / 0x5747)
    goto label_0000_59D7_059D7;
    label_0000_574A_0574A:
    CheckExternalEvents(cs1, 0x574F);
    // MOV word ptr [BP + -0x2e],0x0 (0000_574A / 0x574A)
    UInt16[SS, (ushort)(BP - 0x2E)] = 0x0;
    CheckExternalEvents(cs1, 0x5752);
    // JMP 0x0000:5998 (0000_574F / 0x574F)
    goto label_0000_5998_05998;
    label_0000_5752_05752:
    CheckExternalEvents(cs1, 0x5755);
    // LES BX,[BP + -0x10] (0000_5752 / 0x5752)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    ES = UInt16[SS, (ushort)(BP - 0x10 + 2)];
    CheckExternalEvents(cs1, 0x5759);
    // CMP byte ptr ES:[BX],0x90 (0000_5755 / 0x5755)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0x90);
    CheckExternalEvents(cs1, 0x575B);
    // JNC 0x0000:5761 (0000_5759 / 0x5759)
    if(!CarryFlag) {
      goto label_0000_5761_05761;
    }
    CheckExternalEvents(cs1, 0x575E);
    // MOV AL,byte ptr [BP + -0x18] (0000_575B / 0x575B)
    AL = UInt8[SS, (ushort)(BP - 0x18)];
    label_0000_575E_0575E:
    CheckExternalEvents(cs1, 0x5761);
    // MOV byte ptr ES:[BX],AL (0000_575E / 0x575E)
    UInt8[ES, (ushort)(BX)] = AL;
    label_0000_5761_05761:
    CheckExternalEvents(cs1, 0x5764);
    // INC word ptr [BP + -0x12] (0000_5761 / 0x5761)
    UInt16[SS, (ushort)(BP - 0x12)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x12)]);
    label_0000_5764_05764:
    CheckExternalEvents(cs1, 0x5767);
    // MOV AX,word ptr [BP + -0xc] (0000_5764 / 0x5764)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x576A);
    // CMP word ptr [BP + -0x12],AX (0000_5767 / 0x5767)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], AX);
    CheckExternalEvents(cs1, 0x576C);
    // JGE 0x0000:5799 (0000_576A / 0x576A)
    if(SignFlag == OverflowFlag) {
      goto label_0000_5799_05799;
    }
    CheckExternalEvents(cs1, 0x576F);
    // MOV AX,word ptr [BP + -0x1c] (0000_576C / 0x576C)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs1, 0x5771);
    // MOV CL,0x3 (0000_576F / 0x576F)
    CL = 0x3;
    CheckExternalEvents(cs1, 0x5773);
    // SHL AX,CL (0000_5771 / 0x5771)
    AX <<= CL;
    CheckExternalEvents(cs1, 0x5776);
    // ADD AX,word ptr [BP + -0x12] (0000_5773 / 0x5773)
    AX += UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0x5779);
    // ADD AX,word ptr [BP + -0x36] (0000_5776 / 0x5776)
    // AX += UInt16[SS, (ushort)(BP - 0x36)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x36)]);
    CheckExternalEvents(cs1, 0x577C);
    // MOV DX,word ptr [BP + -0x34] (0000_5779 / 0x5779)
    DX = UInt16[SS, (ushort)(BP - 0x34)];
    CheckExternalEvents(cs1, 0x577F);
    // MOV word ptr [BP + -0x10],AX (0000_577C / 0x577C)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0x5782);
    // MOV word ptr [BP + -0xe],DX (0000_577F / 0x577F)
    UInt16[SS, (ushort)(BP - 0xE)] = DX;
    CheckExternalEvents(cs1, 0x5786);
    // CMP word ptr [BP + -0x4],0x1 (0000_5782 / 0x5782)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x1);
    CheckExternalEvents(cs1, 0x5788);
    // JNZ 0x0000:5752 (0000_5786 / 0x5786)
    if(!ZeroFlag) {
      goto label_0000_5752_05752;
    }
    CheckExternalEvents(cs1, 0x578C);
    // CMP word ptr [BP + -0x3a],0x1 (0000_5788 / 0x5788)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x1);
    CheckExternalEvents(cs1, 0x578E);
    // JNZ 0x0000:5752 (0000_578C / 0x578C)
    if(!ZeroFlag) {
      goto label_0000_5752_05752;
    }
    CheckExternalEvents(cs1, 0x5791);
    // LES BX,[BP + -0x10] (0000_578E / 0x578E)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    ES = UInt16[SS, (ushort)(BP - 0x10 + 2)];
    CheckExternalEvents(cs1, 0x5794);
    // MOV AX,word ptr [BP + -0x18] (0000_5791 / 0x5791)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0x5797);
    // INC word ptr [BP + -0x18] (0000_5794 / 0x5794)
    UInt16[SS, (ushort)(BP - 0x18)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs1, 0x5799);
    // JMP 0x0000:575e (0000_5797 / 0x5797)
    goto label_0000_575E_0575E;
    label_0000_5799_05799:
    CheckExternalEvents(cs1, 0x579C);
    // INC word ptr [BP + -0x1c] (0000_5799 / 0x5799)
    UInt16[SS, (ushort)(BP - 0x1C)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x1C)]);
    label_0000_579C_0579C:
    CheckExternalEvents(cs1, 0x579F);
    // MOV AX,word ptr [BP + -0x14] (0000_579C / 0x579C)
    AX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0x57A2);
    // CMP word ptr [BP + -0x1c],AX (0000_579F / 0x579F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1C)], AX);
    CheckExternalEvents(cs1, 0x57A4);
    // JGE 0x0000:57ab (0000_57A2 / 0x57A2)
    if(SignFlag == OverflowFlag) {
      goto label_0000_57AB_057AB;
    }
    CheckExternalEvents(cs1, 0x57A9);
    // MOV word ptr [BP + -0x12],0x0 (0000_57A4 / 0x57A4)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    CheckExternalEvents(cs1, 0x57AB);
    // JMP 0x0000:5764 (0000_57A9 / 0x57A9)
    goto label_0000_5764_05764;
    label_0000_57AB_057AB:
    CheckExternalEvents(cs1, 0x57AF);
    // CMP word ptr [BP + -0x4],0x1 (0000_57AB / 0x57AB)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x1);
    CheckExternalEvents(cs1, 0x57B1);
    // JZ 0x0000:57b4 (0000_57AF / 0x57AF)
    if(ZeroFlag) {
      goto label_0000_57B4_057B4;
    }
    CheckExternalEvents(cs1, 0x57B4);
    // JMP 0x0000:589e (0000_57B1 / 0x57B1)
    goto label_0000_589E_0589E;
    label_0000_57B4_057B4:
    CheckExternalEvents(cs1, 0x57B8);
    // CMP word ptr [BP + -0x3a],0x1 (0000_57B4 / 0x57B4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x1);
    CheckExternalEvents(cs1, 0x57BA);
    // JZ 0x0000:57bd (0000_57B8 / 0x57B8)
    if(ZeroFlag) {
      goto label_0000_57BD_057BD;
    }
    CheckExternalEvents(cs1, 0x57BD);
    // JMP 0x0000:589e (0000_57BA / 0x57BA)
    goto label_0000_589E_0589E;
    label_0000_57BD_057BD:
    CheckExternalEvents(cs1, 0x57C0);
    // MOV AX,0x9ee (0000_57BD / 0x57BD)
    AX = 0x9EE;
    CheckExternalEvents(cs1, 0x57C1);
    // PUSH DS (0000_57C0 / 0x57C0)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x57C2);
    // PUSH AX (0000_57C1 / 0x57C1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x57C5);
    // MOV AX,0x12 (0000_57C2 / 0x57C2)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x57C8);
    // MOV DX,0x2a02 (0000_57C5 / 0x57C5)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x57C9);
    // PUSH DX (0000_57C8 / 0x57C8)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x57CA);
    // PUSH AX (0000_57C9 / 0x57C9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x57CF);
    // CALLF 0x1000:da58 (0000_57CA / 0x57CA)
    FarCall(cs1, 0x57CF, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs1, 0x57D2);
    // ADD SP,0x8 (0000_57CF / 0x57CF)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x57D5);
    // MOV AX,0xa (0000_57D2 / 0x57D2)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x57D6);
    // PUSH AX (0000_57D5 / 0x57D5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x57D9);
    // MOV AX,0x15 (0000_57D6 / 0x57D6)
    AX = 0x15;
    CheckExternalEvents(cs1, 0x57DC);
    // MOV DX,0x2a02 (0000_57D9 / 0x57D9)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x57DD);
    // PUSH DX (0000_57DC / 0x57DC)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x57DE);
    // PUSH AX (0000_57DD / 0x57DD)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x57E1);
    // MOV AX,word ptr [BP + -0x38] (0000_57DE / 0x57DE)
    AX = UInt16[SS, (ushort)(BP - 0x38)];
    CheckExternalEvents(cs1, 0x57E2);
    // INC AX (0000_57E1 / 0x57E1)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs1, 0x57E3);
    // PUSH AX (0000_57E2 / 0x57E2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x57E8);
    // CALLF 0x1000:daa6 (0000_57E3 / 0x57E3)
    FarCall(cs1, 0x57E8, unknown_19EF_3BB6_1DAA6);
    CheckExternalEvents(cs1, 0x57EB);
    // ADD SP,0x8 (0000_57E8 / 0x57E8)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x57EE);
    // MOV AX,0x9f2 (0000_57EB / 0x57EB)
    AX = 0x9F2;
    CheckExternalEvents(cs1, 0x57EF);
    // PUSH DS (0000_57EE / 0x57EE)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x57F0);
    // PUSH AX (0000_57EF / 0x57EF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x57F3);
    // MOV AX,0x12 (0000_57F0 / 0x57F0)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x57F6);
    // MOV DX,0x2a02 (0000_57F3 / 0x57F3)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x57F7);
    // PUSH DX (0000_57F6 / 0x57F6)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x57F8);
    // PUSH AX (0000_57F7 / 0x57F7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x57FD);
    // CALLF 0x1000:da12 (0000_57F8 / 0x57F8)
    FarCall(cs1, 0x57FD, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs1, 0x5800);
    // ADD SP,0x8 (0000_57FD / 0x57FD)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x5803);
    // MOV AX,0x1 (0000_5800 / 0x5800)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x5804);
    // PUSH AX (0000_5803 / 0x5803)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5805);
    // PUSH CS (0000_5804 / 0x5804)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5808);
    // CALL 0x0000:3fcc (0000_5805 / 0x5805)
    NearCall(cs1, 0x5808, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0x580B);
    // ADD SP,0x2 (0000_5808 / 0x5808)
    SP += 0x2;
    CheckExternalEvents(cs1, 0x580F);
    // CMP word ptr [BP + -0x38],0x0 (0000_580B / 0x580B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x38)], 0x0);
    CheckExternalEvents(cs1, 0x5811);
    // JZ 0x0000:581d (0000_580F / 0x580F)
    if(ZeroFlag) {
      goto label_0000_581D_0581D;
    }
    CheckExternalEvents(cs1, 0x5815);
    // CMP word ptr [BP + -0x38],0xa (0000_5811 / 0x5811)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x38)], 0xA);
    CheckExternalEvents(cs1, 0x5817);
    // JZ 0x0000:581d (0000_5815 / 0x5815)
    if(ZeroFlag) {
      goto label_0000_581D_0581D;
    }
    CheckExternalEvents(cs1, 0x581B);
    // CMP word ptr [BP + -0x38],0xd (0000_5817 / 0x5817)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x38)], 0xD);
    CheckExternalEvents(cs1, 0x581D);
    // JL 0x0000:5832 (0000_581B / 0x581B)
    if(SignFlag != OverflowFlag) {
      goto label_0000_5832_05832;
    }
    label_0000_581D_0581D:
    CheckExternalEvents(cs1, 0x5820);
    // MOV AX,0x2 (0000_581D / 0x581D)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x5821);
    // PUSH AX (0000_5820 / 0x5820)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5822);
    // PUSH CS (0000_5821 / 0x5821)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5825);
    // CALL 0x0000:3fcc (0000_5822 / 0x5822)
    NearCall(cs1, 0x5825, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0x5827);
    // JMP 0x0000:582f (0000_5825 / 0x5825)
    goto label_0000_582F_0582F;
    label_0000_5827_05827:
    CheckExternalEvents(cs1, 0x582B);
    // PUSH word ptr [0x14e] (0000_5827 / 0x5827)
    Stack.Push16(UInt16[DS, 0x14E]);
    CheckExternalEvents(cs1, 0x582C);
    // PUSH CS (0000_582B / 0x582B)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x582F);
    // CALL 0x0000:4013 (0000_582C / 0x582C)
    NearCall(cs1, 0x582F, unknown_0170_2913_04013);
    label_0000_582F_0582F:
    CheckExternalEvents(cs1, 0x5832);
    // ADD SP,0x2 (0000_582F / 0x582F)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_0000_5832_05832:
    CheckExternalEvents(cs1, 0x5835);
    // MOV AX,0x8000 (0000_5832 / 0x5832)
    AX = 0x8000;
    CheckExternalEvents(cs1, 0x5836);
    // PUSH AX (0000_5835 / 0x5835)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5839);
    // MOV AX,0x12 (0000_5836 / 0x5836)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x583C);
    // MOV DX,0x2a02 (0000_5839 / 0x5839)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x583D);
    // PUSH DX (0000_583C / 0x583C)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x583E);
    // PUSH AX (0000_583D / 0x583D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5843);
    // CALLF 0x1000:d2c0 (0000_583E / 0x583E)
    FarCall(cs1, 0x5843, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs1, 0x5846);
    // ADD SP,0x6 (0000_5843 / 0x5843)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs1, 0x5849);
    // MOV word ptr [BP + -0x26],AX (0000_5846 / 0x5846)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    CheckExternalEvents(cs1, 0x584A);
    // INC AX (0000_5849 / 0x5849)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs1, 0x584C);
    // JZ 0x0000:5827 (0000_584A / 0x584A)
    if(ZeroFlag) {
      goto label_0000_5827_05827;
    }
    CheckExternalEvents(cs1, 0x584F);
    // MOV AX,0x21d (0000_584C / 0x584C)
    AX = 0x21D;
    CheckExternalEvents(cs1, 0x5850);
    // PUSH AX (0000_584F / 0x584F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5853);
    // MOV BX,word ptr [BP + -0x1e] (0000_5850 / 0x5850)
    BX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs1, 0x5857);
    // LEA AX,[BX + 0x244b] (0000_5853 / 0x5853)
    AX = (ushort)(BX + 0x244B);
    CheckExternalEvents(cs1, 0x585A);
    // MOV DX,0x1ddc (0000_5857 / 0x5857)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x585B);
    // PUSH DX (0000_585A / 0x585A)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x585C);
    // PUSH AX (0000_585B / 0x585B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x585F);
    // PUSH word ptr [BP + -0x26] (0000_585C / 0x585C)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x5864);
    // CALLF 0x1000:d470 (0000_585F / 0x585F)
    FarCall(cs1, 0x5864, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs1, 0x5867);
    // ADD SP,0x8 (0000_5864 / 0x5864)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x586A);
    // MOV BX,word ptr [BP + -0x38] (0000_5867 / 0x5867)
    BX = UInt16[SS, (ushort)(BP - 0x38)];
    CheckExternalEvents(cs1, 0x586C);
    // SHL BX,0x1 (0000_586A / 0x586A)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x5870);
    // PUSH word ptr [BX + 0xa70] (0000_586C / 0x586C)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0xA70)]);
    CheckExternalEvents(cs1, 0x5873);
    // MOV BX,word ptr [BP + -0x1e] (0000_5870 / 0x5870)
    BX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs1, 0x5877);
    // LEA AX,[BX + 0x244b] (0000_5873 / 0x5873)
    AX = (ushort)(BX + 0x244B);
    CheckExternalEvents(cs1, 0x587A);
    // MOV DX,0x1ddc (0000_5877 / 0x5877)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x587B);
    // PUSH DX (0000_587A / 0x587A)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x587C);
    // PUSH AX (0000_587B / 0x587B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x587F);
    // PUSH word ptr [BP + -0x26] (0000_587C / 0x587C)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x5884);
    // CALLF 0x1000:d470 (0000_587F / 0x587F)
    FarCall(cs1, 0x5884, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs1, 0x5887);
    // ADD SP,0x8 (0000_5884 / 0x5884)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x588A);
    // PUSH word ptr [BP + -0x26] (0000_5887 / 0x5887)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x588F);
    // CALLF 0x1000:d226 (0000_588A / 0x588A)
    FarCall(cs1, 0x588F, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs1, 0x5892);
    // ADD SP,0x2 (0000_588F / 0x588F)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x5895);
    // MOV BX,word ptr [BP + -0x38] (0000_5892 / 0x5892)
    BX = UInt16[SS, (ushort)(BP - 0x38)];
    CheckExternalEvents(cs1, 0x5897);
    // SHL BX,0x1 (0000_5895 / 0x5895)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x589B);
    // MOV AX,word ptr [BX + 0xa70] (0000_5897 / 0x5897)
    AX = UInt16[DS, (ushort)(BX + 0xA70)];
    CheckExternalEvents(cs1, 0x589E);
    // ADD word ptr [BP + -0x1e],AX (0000_589B / 0x589B)
    UInt16[SS, (ushort)(BP - 0x1E)] += AX;
    label_0000_589E_0589E:
    CheckExternalEvents(cs1, 0x58A1);
    // INC word ptr [BP + -0x3a] (0000_589E / 0x589E)
    UInt16[SS, (ushort)(BP - 0x3A)]++;
    label_0000_58A1_058A1:
    CheckExternalEvents(cs1, 0x58A5);
    // CMP word ptr [BP + -0x3a],0x3 (0000_58A1 / 0x58A1)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x3);
    CheckExternalEvents(cs1, 0x58A7);
    // JGE 0x0000:5924 (0000_58A5 / 0x58A5)
    if(SignFlag == OverflowFlag) {
      goto label_0000_5924_05924;
    }
    CheckExternalEvents(cs1, 0x58AA);
    // MOV SI,word ptr [BP + -0xa] (0000_58A7 / 0x58A7)
    SI = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x58AD);
    // ADD SI,word ptr [BP + -0x3a] (0000_58AA / 0x58AA)
    // SI += UInt16[SS, (ushort)(BP - 0x3A)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0x3A)]);
    CheckExternalEvents(cs1, 0x58AF);
    // JS 0x0000:589e (0000_58AD / 0x58AD)
    if(SignFlag) {
      goto label_0000_589E_0589E;
    }
    CheckExternalEvents(cs1, 0x58B3);
    // CMP SI,0x100 (0000_58AF / 0x58AF)
    Alu16.Sub(SI, 0x100);
    CheckExternalEvents(cs1, 0x58B5);
    // JGE 0x0000:589e (0000_58B3 / 0x58B3)
    if(SignFlag == OverflowFlag) {
      goto label_0000_589E_0589E;
    }
    CheckExternalEvents(cs1, 0x58B9);
    // MOV ES,word ptr [0x53d0] (0000_58B5 / 0x58B5)
    ES = UInt16[DS, 0x53D0];
    CheckExternalEvents(cs1, 0x58BF);
    // CMP byte ptr ES:[SI + 0x30],0x0 (0000_58B9 / 0x58B9)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0x30)], 0x0);
    CheckExternalEvents(cs1, 0x58C1);
    // JZ 0x0000:589e (0000_58BF / 0x58BF)
    if(ZeroFlag) {
      goto label_0000_589E_0589E;
    }
    CheckExternalEvents(cs1, 0x58C6);
    // MOV word ptr [BP + -0x28],0x1 (0000_58C1 / 0x58C1)
    UInt16[SS, (ushort)(BP - 0x28)] = 0x1;
    CheckExternalEvents(cs1, 0x58C9);
    // MOV AX,0x3 (0000_58C6 / 0x58C6)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x58CC);
    // IMUL word ptr [BP + -0x4] (0000_58C9 / 0x58C9)
    int resImul0000_58C9 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_58C9);
    DX = (ushort)(resImul0000_58C9 >> 16);
    CheckExternalEvents(cs1, 0x58CE);
    // MOV BX,AX (0000_58CC / 0x58CC)
    BX = AX;
    CheckExternalEvents(cs1, 0x58D1);
    // ADD BX,word ptr [BP + -0x3a] (0000_58CE / 0x58CE)
    BX += UInt16[SS, (ushort)(BP - 0x3A)];
    CheckExternalEvents(cs1, 0x58D3);
    // SHL BX,0x1 (0000_58D1 / 0x58D1)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x58D5);
    // SHL BX,0x1 (0000_58D3 / 0x58D3)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x58D9);
    // MOV AX,word ptr [BX + 0x170] (0000_58D5 / 0x58D5)
    AX = UInt16[DS, (ushort)(BX + 0x170)];
    CheckExternalEvents(cs1, 0x58DD);
    // MOV DX,word ptr [BX + 0x172] (0000_58D9 / 0x58D9)
    DX = UInt16[DS, (ushort)(BX + 0x172)];
    CheckExternalEvents(cs1, 0x58E0);
    // MOV word ptr [BP + -0x36],AX (0000_58DD / 0x58DD)
    UInt16[SS, (ushort)(BP - 0x36)] = AX;
    CheckExternalEvents(cs1, 0x58E3);
    // MOV word ptr [BP + -0x34],DX (0000_58E0 / 0x58E0)
    UInt16[SS, (ushort)(BP - 0x34)] = DX;
    CheckExternalEvents(cs1, 0x58E8);
    // MOV AL,byte ptr ES:[SI + 0x30] (0000_58E3 / 0x58E3)
    AL = UInt8[ES, (ushort)(SI + 0x30)];
    CheckExternalEvents(cs1, 0x58E9);
    // CBW  (0000_58E8 / 0x58E8)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x58EA);
    // DEC AX (0000_58E9 / 0x58E9)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs1, 0x58ED);
    // MOV word ptr [BP + -0x38],AX (0000_58EA / 0x58EA)
    UInt16[SS, (ushort)(BP - 0x38)] = AX;
    CheckExternalEvents(cs1, 0x58EF);
    // MOV BX,AX (0000_58ED / 0x58ED)
    BX = AX;
    CheckExternalEvents(cs1, 0x58F3);
    // MOV AL,byte ptr [BX + 0xa38] (0000_58EF / 0x58EF)
    AL = UInt8[DS, (ushort)(BX + 0xA38)];
    CheckExternalEvents(cs1, 0x58F4);
    // CBW  (0000_58F3 / 0x58F3)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x58F7);
    // MOV word ptr [BP + -0x12],AX (0000_58F4 / 0x58F4)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs1, 0x58FB);
    // MOV AL,byte ptr [BX + 0xa46] (0000_58F7 / 0x58F7)
    AL = UInt8[DS, (ushort)(BX + 0xA46)];
    CheckExternalEvents(cs1, 0x58FC);
    // CBW  (0000_58FB / 0x58FB)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x58FF);
    // MOV word ptr [BP + -0x1c],AX (0000_58FC / 0x58FC)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs1, 0x5903);
    // MOV AL,byte ptr [BX + 0xa54] (0000_58FF / 0x58FF)
    AL = UInt8[DS, (ushort)(BX + 0xA54)];
    CheckExternalEvents(cs1, 0x5904);
    // CBW  (0000_5903 / 0x5903)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x5907);
    // MOV word ptr [BP + -0xc],AX (0000_5904 / 0x5904)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0x590B);
    // MOV AL,byte ptr [BX + 0xa62] (0000_5907 / 0x5907)
    AL = UInt8[DS, (ushort)(BX + 0xA62)];
    CheckExternalEvents(cs1, 0x590C);
    // CBW  (0000_590B / 0x590B)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x590F);
    // MOV word ptr [BP + -0x14],AX (0000_590C / 0x590C)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs1, 0x5912);
    // MOV AX,word ptr [BP + -0x1c] (0000_590F / 0x590F)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs1, 0x5914);
    // MOV CL,0x3 (0000_5912 / 0x5912)
    CL = 0x3;
    CheckExternalEvents(cs1, 0x5916);
    // SHL AX,CL (0000_5914 / 0x5914)
    AX <<= CL;
    CheckExternalEvents(cs1, 0x5919);
    // ADD AX,word ptr [BP + -0x12] (0000_5916 / 0x5916)
    AX += UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0x591C);
    // ADD word ptr [BP + -0x36],AX (0000_5919 / 0x5919)
    // UInt16[SS, (ushort)(BP - 0x36)] += AX;
    UInt16[SS, (ushort)(BP - 0x36)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x36)], AX);
    CheckExternalEvents(cs1, 0x5921);
    // MOV word ptr [BP + -0x1c],0x0 (0000_591C / 0x591C)
    UInt16[SS, (ushort)(BP - 0x1C)] = 0x0;
    CheckExternalEvents(cs1, 0x5924);
    // JMP 0x0000:579c (0000_5921 / 0x5921)
    goto label_0000_579C_0579C;
    label_0000_5924_05924:
    CheckExternalEvents(cs1, 0x5928);
    // ADD word ptr [BP + -0xa],0x10 (0000_5924 / 0x5924)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x10;
    CheckExternalEvents(cs1, 0x592B);
    // INC word ptr [BP + -0x4] (0000_5928 / 0x5928)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_0000_592B_0592B:
    CheckExternalEvents(cs1, 0x592F);
    // CMP word ptr [BP + -0x4],0x3 (0000_592B / 0x592B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x3);
    CheckExternalEvents(cs1, 0x5931);
    // JGE 0x0000:5939 (0000_592F / 0x592F)
    if(SignFlag == OverflowFlag) {
      goto label_0000_5939_05939;
    }
    CheckExternalEvents(cs1, 0x5936);
    // MOV word ptr [BP + -0x3a],0x0 (0000_5931 / 0x5931)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x0;
    CheckExternalEvents(cs1, 0x5939);
    // JMP 0x0000:58a1 (0000_5936 / 0x5936)
    goto label_0000_58A1_058A1;
    label_0000_5939_05939:
    CheckExternalEvents(cs1, 0x593D);
    // CMP word ptr [BP + -0x28],0x0 (0000_5939 / 0x5939)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0x0);
    CheckExternalEvents(cs1, 0x593F);
    // JZ 0x0000:5944 (0000_593D / 0x593D)
    if(ZeroFlag) {
      goto label_0000_5944_05944;
    }
    CheckExternalEvents(cs1, 0x5944);
    // CALLF 0x1000:bc98 (0000_593F / 0x593F)
    FarCall(cs1, 0x5944, unknown_19EF_1DA8_1BC98);
    label_0000_5944_05944:
    CheckExternalEvents(cs1, 0x5947);
    // MOV AX,0x14 (0000_5944 / 0x5944)
    AX = 0x14;
    CheckExternalEvents(cs1, 0x594A);
    // IMUL word ptr [BP + -0x2e] (0000_5947 / 0x5947)
    int resImul0000_5947 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_5947);
    DX = (ushort)(resImul0000_5947 >> 16);
    CheckExternalEvents(cs1, 0x594D);
    // MOV DX,word ptr [BP + -0x2a] (0000_594A / 0x594A)
    DX = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs1, 0x594F);
    // MOV CL,0x3 (0000_594D / 0x594D)
    CL = 0x3;
    CheckExternalEvents(cs1, 0x5951);
    // SHL DX,CL (0000_594F / 0x594F)
    DX <<= CL;
    CheckExternalEvents(cs1, 0x5953);
    // ADD AX,DX (0000_5951 / 0x5951)
    // AX += DX;
    AX = Alu16.Add(AX, DX);
    CheckExternalEvents(cs1, 0x5954);
    // PUSH AX (0000_5953 / 0x5953)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5959);
    // CALLF 0x1000:bdf4 (0000_5954 / 0x5954)
    FarCall(cs1, 0x5959, ghidra_guess_1000_BDF4_1BDF4);
    CheckExternalEvents(cs1, 0x595C);
    // ADD SP,0x2 (0000_5959 / 0x5959)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x5960);
    // MOV ES,word ptr [0x538c] (0000_595C / 0x595C)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x5966);
    // OR byte ptr ES:[0xa44b],0x7f (0000_5960 / 0x5960)
    // UInt8[ES, 0xA44B] |= 0x7F;
    UInt8[ES, 0xA44B] = Alu8.Or(UInt8[ES, 0xA44B], 0x7F);
    CheckExternalEvents(cs1, 0x596B);
    // CALLF 0x1000:b6b5 (0000_5966 / 0x5966)
    FarCall(cs1, 0x596B, unknown_19EF_17C5_1B6B5);
    CheckExternalEvents(cs1, 0x596E);
    // INC word ptr [BP + -0x2a] (0000_596B / 0x596B)
    UInt16[SS, (ushort)(BP - 0x2A)]++;
    label_0000_596E_0596E:
    CheckExternalEvents(cs1, 0x5972);
    // CMP word ptr [BP + -0x2a],0x5 (0000_596E / 0x596E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2A)], 0x5);
    CheckExternalEvents(cs1, 0x5974);
    // JGE 0x0000:5994 (0000_5972 / 0x5972)
    if(SignFlag == OverflowFlag) {
      goto label_0000_5994_05994;
    }
    CheckExternalEvents(cs1, 0x5979);
    // MOV word ptr [BP + -0x28],0x0 (0000_5974 / 0x5974)
    UInt16[SS, (ushort)(BP - 0x28)] = 0x0;
    CheckExternalEvents(cs1, 0x597C);
    // MOV AX,word ptr [BP + -0x20] (0000_5979 / 0x5979)
    AX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x597F);
    // ADD AX,word ptr [BP + -0x2a] (0000_597C / 0x597C)
    // AX += UInt16[SS, (ushort)(BP - 0x2A)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x2A)]);
    CheckExternalEvents(cs1, 0x5982);
    // MOV CX,word ptr [BP + -0x24] (0000_597F / 0x597F)
    CX = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs1, 0x5985);
    // ADD CX,word ptr [BP + -0x2e] (0000_5982 / 0x5982)
    // CX += UInt16[SS, (ushort)(BP - 0x2E)];
    CX = Alu16.Add(CX, UInt16[SS, (ushort)(BP - 0x2E)]);
    CheckExternalEvents(cs1, 0x5987);
    // OR AX,CX (0000_5985 / 0x5985)
    AX |= CX;
    CheckExternalEvents(cs1, 0x598A);
    // SUB AX,0x11 (0000_5987 / 0x5987)
    // AX -= 0x11;
    AX = Alu16.Sub(AX, 0x11);
    CheckExternalEvents(cs1, 0x598D);
    // MOV word ptr [BP + -0xa],AX (0000_598A / 0x598A)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0x5992);
    // MOV word ptr [BP + -0x4],0x0 (0000_598D / 0x598D)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs1, 0x5994);
    // JMP 0x0000:592b (0000_5992 / 0x5992)
    goto label_0000_592B_0592B;
    label_0000_5994_05994:
    CheckExternalEvents(cs1, 0x5998);
    // ADD word ptr [BP + -0x2e],0x10 (0000_5994 / 0x5994)
    UInt16[SS, (ushort)(BP - 0x2E)] += 0x10;
    label_0000_5998_05998:
    CheckExternalEvents(cs1, 0x599C);
    // CMP word ptr [BP + -0x2e],0x30 (0000_5998 / 0x5998)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2E)], 0x30);
    CheckExternalEvents(cs1, 0x599E);
    // JL 0x0000:59a1 (0000_599C / 0x599C)
    if(SignFlag != OverflowFlag) {
      goto label_0000_59A1_059A1;
    }
    CheckExternalEvents(cs1, 0x59A1);
    // JMP 0x0000:5a2c (0000_599E / 0x599E)
    goto label_0000_5A2C_05A2C;
    label_0000_59A1_059A1:
    CheckExternalEvents(cs1, 0x59A5);
    // MOV ES,word ptr [0x538c] (0000_59A1 / 0x59A1)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x59A8);
    // MOV AH,byte ptr [BP + -0x20] (0000_59A5 / 0x59A5)
    AH = UInt8[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x59AA);
    // SUB AL,AL (0000_59A8 / 0x59A8)
    // AL -= AL;
    AL = Alu8.Sub(AL, AL);
    CheckExternalEvents(cs1, 0x59AE);
    // MOV ES:[0xa44b],AX (0000_59AA / 0x59AA)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs1, 0x59B1);
    // MOV SI,word ptr [BP + -0x24] (0000_59AE / 0x59AE)
    SI = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs1, 0x59B4);
    // ADD SI,word ptr [BP + -0x2e] (0000_59B1 / 0x59B1)
    // SI += UInt16[SS, (ushort)(BP - 0x2E)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0x2E)]);
    CheckExternalEvents(cs1, 0x59B8);
    // MOV ES,word ptr [0x538e] (0000_59B4 / 0x59B4)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x59BA);
    // MOV AX,SI (0000_59B8 / 0x59B8)
    AX = SI;
    CheckExternalEvents(cs1, 0x59BC);
    // MOV CL,0x8 (0000_59BA / 0x59BA)
    CL = 0x8;
    CheckExternalEvents(cs1, 0x59BE);
    // SHL AX,CL (0000_59BC / 0x59BC)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs1, 0x59C2);
    // MOV ES:[0xa44d],AX (0000_59BE / 0x59BE)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs1, 0x59C5);
    // MOV AX,word ptr [BP + -0x20] (0000_59C2 / 0x59C2)
    AX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x59C7);
    // OR AX,SI (0000_59C5 / 0x59C5)
    // AX |= SI;
    AX = Alu16.Or(AX, SI);
    CheckExternalEvents(cs1, 0x59C8);
    // PUSH AX (0000_59C7 / 0x59C7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x59CD);
    // CALLF 0x1000:af3e (0000_59C8 / 0x59C8)
    FarCall(cs1, 0x59CD, unknown_19EF_104E_1AF3E);
    CheckExternalEvents(cs1, 0x59D0);
    // ADD SP,0x2 (0000_59CD / 0x59CD)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x59D5);
    // MOV word ptr [BP + -0x2a],0x0 (0000_59D0 / 0x59D0)
    UInt16[SS, (ushort)(BP - 0x2A)] = 0x0;
    CheckExternalEvents(cs1, 0x59D7);
    // JMP 0x0000:596e (0000_59D5 / 0x59D5)
    goto label_0000_596E_0596E;
    label_0000_59D7_059D7:
    CheckExternalEvents(cs1, 0x59DC);
    // MOV word ptr [BP + -0x4],0x0 (0000_59D7 / 0x59D7)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_59DC_059DC:
    CheckExternalEvents(cs1, 0x59DF);
    // MOV BX,word ptr [BP + -0x4] (0000_59DC / 0x59DC)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0x59E3);
    // MOV ES,word ptr [0x53fa] (0000_59DF / 0x59DF)
    ES = UInt16[DS, 0x53FA];
    CheckExternalEvents(cs1, 0x59E8);
    // MOV AL,byte ptr ES:[BX + 0x101d] (0000_59E3 / 0x59E3)
    AL = UInt8[ES, (ushort)(BX + 0x101D)];
    CheckExternalEvents(cs1, 0x59EC);
    // MOV ES,word ptr [0x53c6] (0000_59E8 / 0x59E8)
    ES = UInt16[DS, 0x53C6];
    CheckExternalEvents(cs1, 0x59F1);
    // MOV byte ptr ES:[BX + 0x644b],AL (0000_59EC / 0x59EC)
    UInt8[ES, (ushort)(BX + 0x644B)] = AL;
    CheckExternalEvents(cs1, 0x59F4);
    // INC word ptr [BP + -0x4] (0000_59F1 / 0x59F1)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs1, 0x59F9);
    // CMP word ptr [BP + -0x4],0x1080 (0000_59F4 / 0x59F4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x1080);
    CheckExternalEvents(cs1, 0x59FB);
    // JL 0x0000:59dc (0000_59F9 / 0x59F9)
    if(SignFlag != OverflowFlag) {
      goto label_0000_59DC_059DC;
    }
    CheckExternalEvents(cs1, 0x5A00);
    // MOV word ptr [BP + -0x4],0x0 (0000_59FB / 0x59FB)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_5A00_05A00:
    CheckExternalEvents(cs1, 0x5A04);
    // MOV ES,word ptr [0x538a] (0000_5A00 / 0x5A00)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5A08);
    // MOV AL,ES:[0xd34e] (0000_5A04 / 0x5A04)
    AL = UInt8[ES, 0xD34E];
    CheckExternalEvents(cs1, 0x5A0A);
    // SUB AL,0x30 (0000_5A08 / 0x5A08)
    // AL -= 0x30;
    AL = Alu8.Sub(AL, 0x30);
    CheckExternalEvents(cs1, 0x5A0D);
    // MOV BX,word ptr [BP + -0x4] (0000_5A0A / 0x5A0A)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0x5A11);
    // MOV ES,word ptr [0x53c6] (0000_5A0D / 0x5A0D)
    ES = UInt16[DS, 0x53C6];
    CheckExternalEvents(cs1, 0x5A16);
    // MOV byte ptr ES:[BX + 0x244b],AL (0000_5A11 / 0x5A11)
    UInt8[ES, (ushort)(BX + 0x244B)] = AL;
    CheckExternalEvents(cs1, 0x5A19);
    // INC word ptr [BP + -0x4] (0000_5A16 / 0x5A16)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs1, 0x5A1E);
    // CMP word ptr [BP + -0x4],0x3c0 (0000_5A19 / 0x5A19)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x3C0);
    CheckExternalEvents(cs1, 0x5A20);
    // JL 0x0000:5a00 (0000_5A1E / 0x5A1E)
    if(SignFlag != OverflowFlag) {
      goto label_0000_5A00_05A00;
    }
    CheckExternalEvents(cs1, 0x5A23);
    // MOV AX,0x150 (0000_5A20 / 0x5A20)
    AX = 0x150;
    CheckExternalEvents(cs1, 0x5A24);
    // PUSH AX (0000_5A23 / 0x5A23)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5A29);
    // CALLF 0x1000:bdf4 (0000_5A24 / 0x5A24)
    FarCall(cs1, 0x5A29, ghidra_guess_1000_BDF4_1BDF4);
    CheckExternalEvents(cs1, 0x5A2C);
    // ADD SP,0x2 (0000_5A29 / 0x5A29)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_0000_5A2C_05A2C:
    CheckExternalEvents(cs1, 0x5A31);
    // MOV word ptr [BP + -0x4],0x0 (0000_5A2C / 0x5A2C)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs1, 0x5A34);
    // JMP 0x0000:5ac4 (0000_5A31 / 0x5A31)
    goto label_0000_5AC4_05AC4;
    label_0000_5A34_05A34:
    CheckExternalEvents(cs1, 0x5A37);
    // PUSH word ptr [BP + -0x30] (0000_5A34 / 0x5A34)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x30)]);
    CheckExternalEvents(cs1, 0x5A38);
    // PUSH CS (0000_5A37 / 0x5A37)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5A3B);
    // CALL 0x0000:5cc2 (0000_5A38 / 0x5A38)
    NearCall(cs1, 0x5A3B, ghidra_guess_0000_5CC2_05CC2);
    CheckExternalEvents(cs1, 0x5A3E);
    // ADD SP,0x2 (0000_5A3B / 0x5A3B)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x5A41);
    // PUSH word ptr [BP + -0x4] (0000_5A3E / 0x5A3E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x5A44);
    // PUSH word ptr [BP + -0x3a] (0000_5A41 / 0x5A41)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x3A)]);
    CheckExternalEvents(cs1, 0x5A47);
    // MOV AX,0x642b (0000_5A44 / 0x5A44)
    AX = 0x642B;
    CheckExternalEvents(cs1, 0x5A4A);
    // MOV DX,0x1ddc (0000_5A47 / 0x5A47)
    DX = 0x1DDC;
    label_0000_5A4A_05A4A:
    CheckExternalEvents(cs1, 0x5A4B);
    // PUSH DX (0000_5A4A / 0x5A4A)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x5A4C);
    // PUSH AX (0000_5A4B / 0x5A4B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5A51);
    // CALLF 0x1000:c64c (0000_5A4C / 0x5A4C)
    FarCall(cs1, 0x5A51, unknown_19EF_275C_1C64C);
    CheckExternalEvents(cs1, 0x5A54);
    // ADD SP,0x8 (0000_5A51 / 0x5A51)
    SP += 0x8;
    label_0000_5A54_05A54:
    CheckExternalEvents(cs1, 0x5A57);
    // SAR word ptr [BP + -0x1a],0x1 (0000_5A54 / 0x5A54)
    UInt16[SS, (ushort)(BP - 0x1A)] = Alu16.Sar(UInt16[SS, (ushort)(BP - 0x1A)], 0x1);
    CheckExternalEvents(cs1, 0x5A5B);
    // CMP word ptr [BP + -0x1a],0x0 (0000_5A57 / 0x5A57)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1A)], 0x0);
    CheckExternalEvents(cs1, 0x5A5D);
    // JNZ 0x0000:5a65 (0000_5A5B / 0x5A5B)
    if(!ZeroFlag) {
      goto label_0000_5A65_05A65;
    }
    CheckExternalEvents(cs1, 0x5A62);
    // MOV word ptr [BP + -0x1a],0x80 (0000_5A5D / 0x5A5D)
    UInt16[SS, (ushort)(BP - 0x1A)] = 0x80;
    CheckExternalEvents(cs1, 0x5A65);
    // INC word ptr [BP + -0x32] (0000_5A62 / 0x5A62)
    UInt16[SS, (ushort)(BP - 0x32)]++;
    label_0000_5A65_05A65:
    CheckExternalEvents(cs1, 0x5A68);
    // INC word ptr [BP + -0x3a] (0000_5A65 / 0x5A65)
    UInt16[SS, (ushort)(BP - 0x3A)]++;
    label_0000_5A68_05A68:
    CheckExternalEvents(cs1, 0x5A6C);
    // CMP word ptr [BP + -0x3a],0x28 (0000_5A68 / 0x5A68)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x28);
    CheckExternalEvents(cs1, 0x5A6E);
    // JGE 0x0000:5abd (0000_5A6C / 0x5A6C)
    if(SignFlag == OverflowFlag) {
      goto label_0000_5ABD_05ABD;
    }
    CheckExternalEvents(cs1, 0x5A71);
    // MOV AX,0x28 (0000_5A6E / 0x5A6E)
    AX = 0x28;
    CheckExternalEvents(cs1, 0x5A74);
    // IMUL word ptr [BP + -0x4] (0000_5A71 / 0x5A71)
    int resImul0000_5A71 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_5A71);
    DX = (ushort)(resImul0000_5A71 >> 16);
    CheckExternalEvents(cs1, 0x5A76);
    // MOV BX,AX (0000_5A74 / 0x5A74)
    BX = AX;
    CheckExternalEvents(cs1, 0x5A79);
    // ADD BX,word ptr [BP + -0x3a] (0000_5A76 / 0x5A76)
    // BX += UInt16[SS, (ushort)(BP - 0x3A)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x3A)]);
    CheckExternalEvents(cs1, 0x5A7D);
    // MOV ES,word ptr [0x53c6] (0000_5A79 / 0x5A79)
    ES = UInt16[DS, 0x53C6];
    CheckExternalEvents(cs1, 0x5A82);
    // MOV AL,byte ptr ES:[BX + 0x244b] (0000_5A7D / 0x5A7D)
    AL = UInt8[ES, (ushort)(BX + 0x244B)];
    CheckExternalEvents(cs1, 0x5A84);
    // SUB AH,AH (0000_5A82 / 0x5A82)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs1, 0x5A87);
    // MOV word ptr [BP + -0x30],AX (0000_5A84 / 0x5A84)
    UInt16[SS, (ushort)(BP - 0x30)] = AX;
    CheckExternalEvents(cs1, 0x5A8A);
    // MOV BX,word ptr [BP + -0x32] (0000_5A87 / 0x5A87)
    BX = UInt16[SS, (ushort)(BP - 0x32)];
    CheckExternalEvents(cs1, 0x5A8E);
    // MOV ES,word ptr [0x538a] (0000_5A8A / 0x5A8A)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5A93);
    // MOV AL,byte ptr ES:[BX + 0xcb0c] (0000_5A8E / 0x5A8E)
    AL = UInt8[ES, (ushort)(BX + 0xCB0C)];
    CheckExternalEvents(cs1, 0x5A94);
    // CBW  (0000_5A93 / 0x5A93)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x5A97);
    // TEST word ptr [BP + -0x1a],AX (0000_5A94 / 0x5A94)
    Alu16.And(UInt16[SS, (ushort)(BP - 0x1A)], AX);
    CheckExternalEvents(cs1, 0x5A99);
    // JZ 0x0000:5a54 (0000_5A97 / 0x5A97)
    if(ZeroFlag) {
      goto label_0000_5A54_05A54;
    }
    CheckExternalEvents(cs1, 0x5A9E);
    // CMP word ptr [BP + -0x30],0x90 (0000_5A99 / 0x5A99)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x30)], 0x90);
    CheckExternalEvents(cs1, 0x5AA0);
    // JNC 0x0000:5a34 (0000_5A9E / 0x5A9E)
    if(!CarryFlag) {
      goto label_0000_5A34_05A34;
    }
    CheckExternalEvents(cs1, 0x5AA3);
    // PUSH word ptr [BP + -0x4] (0000_5AA0 / 0x5AA0)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x5AA6);
    // PUSH word ptr [BP + -0x3a] (0000_5AA3 / 0x5AA3)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x3A)]);
    CheckExternalEvents(cs1, 0x5AA9);
    // MOV AX,word ptr [BP + -0x30] (0000_5AA6 / 0x5AA6)
    AX = UInt16[SS, (ushort)(BP - 0x30)];
    CheckExternalEvents(cs1, 0x5AAB);
    // MOV CL,0x5 (0000_5AA9 / 0x5AA9)
    CL = 0x5;
    CheckExternalEvents(cs1, 0x5AAD);
    // SHL AX,CL (0000_5AAB / 0x5AAB)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs1, 0x5AB1);
    // MOV ES,word ptr [0x53fc] (0000_5AAD / 0x5AAD)
    ES = UInt16[DS, 0x53FC];
    CheckExternalEvents(cs1, 0x5AB6);
    // ADD AX,word ptr ES:[0x4588] (0000_5AB1 / 0x5AB1)
    // AX += UInt16[ES, 0x4588];
    AX = Alu16.Add(AX, UInt16[ES, 0x4588]);
    CheckExternalEvents(cs1, 0x5ABB);
    // MOV DX,word ptr ES:[0x458a] (0000_5AB6 / 0x5AB6)
    DX = UInt16[ES, 0x458A];
    CheckExternalEvents(cs1, 0x5ABD);
    // JMP 0x0000:5a4a (0000_5ABB / 0x5ABB)
    goto label_0000_5A4A_05A4A;
    label_0000_5ABD_05ABD:
    CheckExternalEvents(cs1, 0x5AC1);
    // ADD word ptr [BP + -0x32],0xb (0000_5ABD / 0x5ABD)
    UInt16[SS, (ushort)(BP - 0x32)] += 0xB;
    CheckExternalEvents(cs1, 0x5AC4);
    // INC word ptr [BP + -0x4] (0000_5AC1 / 0x5AC1)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_0000_5AC4_05AC4:
    CheckExternalEvents(cs1, 0x5AC8);
    // CMP word ptr [BP + -0x4],0x18 (0000_5AC4 / 0x5AC4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x18);
    CheckExternalEvents(cs1, 0x5ACA);
    // JGE 0x0000:5ad6 (0000_5AC8 / 0x5AC8)
    if(SignFlag == OverflowFlag) {
      goto label_0000_5AD6_05AD6;
    }
    CheckExternalEvents(cs1, 0x5ACF);
    // MOV word ptr [BP + -0x1a],0x80 (0000_5ACA / 0x5ACA)
    UInt16[SS, (ushort)(BP - 0x1A)] = 0x80;
    CheckExternalEvents(cs1, 0x5AD4);
    // MOV word ptr [BP + -0x3a],0x0 (0000_5ACF / 0x5ACF)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x0;
    CheckExternalEvents(cs1, 0x5AD6);
    // JMP 0x0000:5a68 (0000_5AD4 / 0x5AD4)
    goto label_0000_5A68_05A68;
    label_0000_5AD6_05AD6:
    CheckExternalEvents(cs1, 0x5ADA);
    // MOV ES,word ptr [0x538a] (0000_5AD6 / 0x5AD6)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5AE0);
    // CMP byte ptr ES:[0xd346],0x0 (0000_5ADA / 0x5ADA)
    Alu8.Sub(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs1, 0x5AE2);
    // JNZ 0x0000:5b49 (0000_5AE0 / 0x5AE0)
    if(!ZeroFlag) {
      goto label_0000_5B49_05B49;
    }
    CheckExternalEvents(cs1, 0x5AE8);
    // CMP byte ptr ES:[0xd33b],0x0 (0000_5AE2 / 0x5AE2)
    Alu8.Sub(UInt8[ES, 0xD33B], 0x0);
    CheckExternalEvents(cs1, 0x5AEA);
    // JZ 0x0000:5b49 (0000_5AE8 / 0x5AE8)
    if(ZeroFlag) {
      goto label_0000_5B49_05B49;
    }
    CheckExternalEvents(cs1, 0x5AED);
    // MOV AX,word ptr [BP + -0x2] (0000_5AEA / 0x5AEA)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0x5AF0);
    // OR AX,word ptr [BP + -0x6] (0000_5AED / 0x5AED)
    AX |= UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x5AF2);
    // SUB AL,AL (0000_5AF0 / 0x5AF0)
    AL -= AL;
    CheckExternalEvents(cs1, 0x5AF5);
    // CMP AX,0x8a00 (0000_5AF2 / 0x5AF2)
    Alu16.Sub(AX, 0x8A00);
    CheckExternalEvents(cs1, 0x5AF7);
    // JZ 0x0000:5b49 (0000_5AF5 / 0x5AF5)
    if(ZeroFlag) {
      goto label_0000_5B49_05B49;
    }
    CheckExternalEvents(cs1, 0x5AFA);
    // MOV AX,0x8038 (0000_5AF7 / 0x5AF7)
    AX = 0x8038;
    CheckExternalEvents(cs1, 0x5AFB);
    // PUSH AX (0000_5AFA / 0x5AFA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5AFE);
    // MOV AX,0xa38 (0000_5AFB / 0x5AFB)
    AX = 0xA38;
    CheckExternalEvents(cs1, 0x5AFF);
    // PUSH AX (0000_5AFE / 0x5AFE)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B02);
    // PUSH word ptr [BP + -0x6] (0000_5AFF / 0x5AFF)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x5B05);
    // PUSH word ptr [BP + -0x2] (0000_5B02 / 0x5B02)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x5B0A);
    // CALLF 0x1000:a861 (0000_5B05 / 0x5B05)
    FarCall(cs1, 0x5B0A, unknown_19EF_0971_1A861);
    CheckExternalEvents(cs1, 0x5B0D);
    // ADD SP,0x8 (0000_5B0A / 0x5B0A)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x5B10);
    // MOV word ptr [BP + -0x2c],AX (0000_5B0D / 0x5B0D)
    UInt16[SS, (ushort)(BP - 0x2C)] = AX;
    CheckExternalEvents(cs1, 0x5B14);
    // MOV ES,word ptr [0x53fe] (0000_5B10 / 0x5B10)
    ES = UInt16[DS, 0x53FE];
    CheckExternalEvents(cs1, 0x5B17);
    // MOV AL,byte ptr [BP + -0x2c] (0000_5B14 / 0x5B14)
    AL = UInt8[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs1, 0x5B19);
    // INC AL (0000_5B17 / 0x5B17)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs1, 0x5B1D);
    // MOV ES:[0x12],AL (0000_5B19 / 0x5B19)
    UInt8[ES, 0x12] = AL;
    CheckExternalEvents(cs1, 0x5B23);
    // MOV byte ptr ES:[0x13],0x0 (0000_5B1D / 0x5B1D)
    UInt8[ES, 0x13] = 0x0;
    CheckExternalEvents(cs1, 0x5B25);
    // SUB AX,AX (0000_5B23 / 0x5B23)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x5B26);
    // PUSH AX (0000_5B25 / 0x5B25)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B29);
    // MOV AX,0xf (0000_5B26 / 0x5B26)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x5B2A);
    // PUSH AX (0000_5B29 / 0x5B29)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B2D);
    // MOV BX,word ptr [BP + -0x2c] (0000_5B2A / 0x5B2A)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs1, 0x5B31);
    // MOV AL,byte ptr [BX + 0xa92] (0000_5B2D / 0x5B2D)
    AL = UInt8[DS, (ushort)(BX + 0xA92)];
    CheckExternalEvents(cs1, 0x5B32);
    // CBW  (0000_5B31 / 0x5B31)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x5B33);
    // PUSH AX (0000_5B32 / 0x5B32)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B37);
    // MOV AL,byte ptr [BX + 0xa8a] (0000_5B33 / 0x5B33)
    AL = UInt8[DS, (ushort)(BX + 0xA8A)];
    CheckExternalEvents(cs1, 0x5B38);
    // CBW  (0000_5B37 / 0x5B37)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x5B39);
    // PUSH AX (0000_5B38 / 0x5B38)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B3C);
    // MOV AX,0x12 (0000_5B39 / 0x5B39)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x5B3F);
    // MOV DX,0x2a02 (0000_5B3C / 0x5B3C)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x5B40);
    // PUSH DX (0000_5B3F / 0x5B3F)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x5B41);
    // PUSH AX (0000_5B40 / 0x5B40)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B46);
    // CALLF 0x1000:8ba5 (0000_5B41 / 0x5B41)
    FarCall(cs1, 0x5B46, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x5B49);
    // ADD SP,0xc (0000_5B46 / 0x5B46)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    label_0000_5B49_05B49:
    CheckExternalEvents(cs1, 0x5B4E);
    // MOV word ptr [BP + -0x8],0x258 (0000_5B49 / 0x5B49)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x258;
    CheckExternalEvents(cs1, 0x5B50);
    // SUB AX,AX (0000_5B4E / 0x5B4E)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x5B51);
    // PUSH AX (0000_5B50 / 0x5B50)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B54);
    // MOV AX,0xc7 (0000_5B51 / 0x5B51)
    AX = 0xC7;
    CheckExternalEvents(cs1, 0x5B55);
    // PUSH AX (0000_5B54 / 0x5B54)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B58);
    // MOV AX,0x13f (0000_5B55 / 0x5B55)
    AX = 0x13F;
    CheckExternalEvents(cs1, 0x5B59);
    // PUSH AX (0000_5B58 / 0x5B58)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B5C);
    // MOV AX,0xc0 (0000_5B59 / 0x5B59)
    AX = 0xC0;
    CheckExternalEvents(cs1, 0x5B5D);
    // PUSH AX (0000_5B5C / 0x5B5C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B5F);
    // SUB AX,AX (0000_5B5D / 0x5B5D)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x5B60);
    // PUSH AX (0000_5B5F / 0x5B5F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B65);
    // CALLF 0x1000:8ccb (0000_5B60 / 0x5B60)
    FarCall(cs1, 0x5B65, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs1, 0x5B68);
    // ADD SP,0xa (0000_5B65 / 0x5B65)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    CheckExternalEvents(cs1, 0x5B6C);
    // MOV ES,word ptr [0x538a] (0000_5B68 / 0x5B68)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x5B72);
    // CMP byte ptr ES:[0xd346],0x0 (0000_5B6C / 0x5B6C)
    Alu8.Sub(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs1, 0x5B74);
    // JNZ 0x0000:5b8f (0000_5B72 / 0x5B72)
    if(!ZeroFlag) {
      goto label_0000_5B8F_05B8F;
    }
    CheckExternalEvents(cs1, 0x5B7A);
    // CMP byte ptr ES:[0xd310],0x0 (0000_5B74 / 0x5B74)
    Alu8.Sub(UInt8[ES, 0xD310], 0x0);
    CheckExternalEvents(cs1, 0x5B7C);
    // JZ 0x0000:5b8f (0000_5B7A / 0x5B7A)
    if(ZeroFlag) {
      goto label_0000_5B8F_05B8F;
    }
    CheckExternalEvents(cs1, 0x5B7E);
    // SUB AX,AX (0000_5B7C / 0x5B7C)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x5B7F);
    // PUSH AX (0000_5B7E / 0x5B7E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B82);
    // MOV AX,0xf (0000_5B7F / 0x5B7F)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x5B83);
    // PUSH AX (0000_5B82 / 0x5B82)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B86);
    // MOV AX,0x18 (0000_5B83 / 0x5B83)
    AX = 0x18;
    CheckExternalEvents(cs1, 0x5B87);
    // PUSH AX (0000_5B86 / 0x5B86)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B89);
    // SUB AX,AX (0000_5B87 / 0x5B87)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x5B8A);
    // PUSH AX (0000_5B89 / 0x5B89)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B8D);
    // MOV AX,0x9f7 (0000_5B8A / 0x5B8A)
    AX = 0x9F7;
    CheckExternalEvents(cs1, 0x5B8F);
    // JMP 0x0000:5ba0 (0000_5B8D / 0x5B8D)
    goto label_0000_5BA0_05BA0;
    label_0000_5B8F_05B8F:
    CheckExternalEvents(cs1, 0x5B91);
    // SUB AX,AX (0000_5B8F / 0x5B8F)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x5B92);
    // PUSH AX (0000_5B91 / 0x5B91)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B95);
    // MOV AX,0xf (0000_5B92 / 0x5B92)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x5B96);
    // PUSH AX (0000_5B95 / 0x5B95)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B99);
    // MOV AX,0x18 (0000_5B96 / 0x5B96)
    AX = 0x18;
    CheckExternalEvents(cs1, 0x5B9A);
    // PUSH AX (0000_5B99 / 0x5B99)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5B9C);
    // SUB AX,AX (0000_5B9A / 0x5B9A)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x5B9D);
    // PUSH AX (0000_5B9C / 0x5B9C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5BA0);
    // MOV AX,0xa16 (0000_5B9D / 0x5B9D)
    AX = 0xA16;
    label_0000_5BA0_05BA0:
    CheckExternalEvents(cs1, 0x5BA1);
    // PUSH DS (0000_5BA0 / 0x5BA0)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x5BA2);
    // PUSH AX (0000_5BA1 / 0x5BA1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5BA7);
    // CALLF 0x1000:8ba5 (0000_5BA2 / 0x5BA2)
    FarCall(cs1, 0x5BA7, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x5BAA);
    // ADD SP,0xc (0000_5BA7 / 0x5BA7)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x5BAE);
    // MOV ES,word ptr [0x538c] (0000_5BAA / 0x5BAA)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x5BB1);
    // MOV AX,word ptr [BP + 0x6] (0000_5BAE / 0x5BAE)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x5BB5);
    // MOV ES:[0xa44b],AX (0000_5BB1 / 0x5BB1)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs1, 0x5BB9);
    // MOV ES,word ptr [0x538e] (0000_5BB5 / 0x5BB5)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x5BBC);
    // MOV AX,word ptr [BP + 0x8] (0000_5BB9 / 0x5BB9)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x5BC0);
    // MOV ES:[0xa44d],AX (0000_5BBC / 0x5BBC)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs1, 0x5BC5);
    // MOV word ptr [BP + -0x16],0x0 (0000_5BC0 / 0x5BC0)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    label_0000_5BC5_05BC5:
    CheckExternalEvents(cs1, 0x5BC9);
    // MOV ES,word ptr [0x538c] (0000_5BC5 / 0x5BC5)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x5BCD);
    // MOV AX,ES:[0xa44b] (0000_5BC9 / 0x5BC9)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x5BD0);
    // AND AX,0xf00 (0000_5BCD / 0x5BCD)
    // AX &= 0xF00;
    AX = Alu16.And(AX, 0xF00);
    CheckExternalEvents(cs1, 0x5BD2);
    // MOV CL,0x8 (0000_5BD0 / 0x5BD0)
    CL = 0x8;
    CheckExternalEvents(cs1, 0x5BD4);
    // SHR AX,CL (0000_5BD2 / 0x5BD2)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs1, 0x5BD7);
    // MOV word ptr [BP + -0x3a],AX (0000_5BD4 / 0x5BD4)
    UInt16[SS, (ushort)(BP - 0x3A)] = AX;
    CheckExternalEvents(cs1, 0x5BDB);
    // MOV ES,word ptr [0x538e] (0000_5BD7 / 0x5BD7)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x5BDF);
    // MOV AX,ES:[0xa44d] (0000_5BDB / 0x5BDB)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x5BE2);
    // AND AX,0xf000 (0000_5BDF / 0x5BDF)
    AX &= 0xF000;
    CheckExternalEvents(cs1, 0x5BE4);
    // SHR AX,CL (0000_5BE2 / 0x5BE2)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs1, 0x5BE7);
    // MOV word ptr [BP + -0x4],AX (0000_5BE4 / 0x5BE4)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x5BEA);
    // MOV AX,word ptr [BP + -0x20] (0000_5BE7 / 0x5BE7)
    AX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x5BED);
    // SUB word ptr [BP + -0x3a],AX (0000_5BEA / 0x5BEA)
    // UInt16[SS, (ushort)(BP - 0x3A)] -= AX;
    UInt16[SS, (ushort)(BP - 0x3A)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], AX);
    CheckExternalEvents(cs1, 0x5BF0);
    // MOV AX,word ptr [BP + -0x24] (0000_5BED / 0x5BED)
    AX = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs1, 0x5BF3);
    // SUB word ptr [BP + -0x4],AX (0000_5BF0 / 0x5BF0)
    // UInt16[SS, (ushort)(BP - 0x4)] -= AX;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs1, 0x5BF7);
    // MOV ES,word ptr [0x538c] (0000_5BF3 / 0x5BF3)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x5BFB);
    // MOV AX,ES:[0xa44b] (0000_5BF7 / 0x5BF7)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x5BFE);
    // AND AX,0x7f (0000_5BFB / 0x5BFB)
    AX &= 0x7F;
    CheckExternalEvents(cs1, 0x5C00);
    // SHR AX,0x1 (0000_5BFE / 0x5BFE)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs1, 0x5C03);
    // MOV DX,word ptr [BP + -0x3a] (0000_5C00 / 0x5C00)
    DX = UInt16[SS, (ushort)(BP - 0x3A)];
    CheckExternalEvents(cs1, 0x5C05);
    // MOV CL,0x6 (0000_5C03 / 0x5C03)
    CL = 0x6;
    CheckExternalEvents(cs1, 0x5C07);
    // SHL DX,CL (0000_5C05 / 0x5C05)
    DX <<= CL;
    CheckExternalEvents(cs1, 0x5C09);
    // ADD AX,DX (0000_5C07 / 0x5C07)
    // AX += DX;
    AX = Alu16.Add(AX, DX);
    CheckExternalEvents(cs1, 0x5C0C);
    // MOV word ptr [BP + -0x3a],AX (0000_5C09 / 0x5C09)
    UInt16[SS, (ushort)(BP - 0x3A)] = AX;
    CheckExternalEvents(cs1, 0x5C10);
    // MOV ES,word ptr [0x538e] (0000_5C0C / 0x5C0C)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x5C14);
    // MOV AX,ES:[0xa44d] (0000_5C10 / 0x5C10)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x5C17);
    // AND AX,0x7f (0000_5C14 / 0x5C14)
    AX &= 0x7F;
    CheckExternalEvents(cs1, 0x5C19);
    // SHR AX,0x1 (0000_5C17 / 0x5C17)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs1, 0x5C1C);
    // MOV CX,word ptr [BP + -0x4] (0000_5C19 / 0x5C19)
    CX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0x5C1E);
    // SHL CX,0x1 (0000_5C1C / 0x5C1C)
    CX <<= 0x1;
    CheckExternalEvents(cs1, 0x5C20);
    // SHL CX,0x1 (0000_5C1E / 0x5C1E)
    CX <<= 0x1;
    CheckExternalEvents(cs1, 0x5C22);
    // ADD AX,CX (0000_5C20 / 0x5C20)
    // AX += CX;
    AX = Alu16.Add(AX, CX);
    CheckExternalEvents(cs1, 0x5C25);
    // MOV word ptr [BP + -0x4],AX (0000_5C22 / 0x5C22)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x5C29);
    // CMP word ptr [BP + -0x3a],0x0 (0000_5C25 / 0x5C25)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x0);
    CheckExternalEvents(cs1, 0x5C2B);
    // JL 0x0000:5c74 (0000_5C29 / 0x5C29)
    if(SignFlag != OverflowFlag) {
      goto label_0000_5C74_05C74;
    }
    CheckExternalEvents(cs1, 0x5C30);
    // CMP word ptr [BP + -0x3a],0x140 (0000_5C2B / 0x5C2B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x140);
    CheckExternalEvents(cs1, 0x5C32);
    // JGE 0x0000:5c74 (0000_5C30 / 0x5C30)
    if(SignFlag == OverflowFlag) {
      goto label_0000_5C74_05C74;
    }
    CheckExternalEvents(cs1, 0x5C34);
    // OR AX,AX (0000_5C32 / 0x5C32)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0x5C36);
    // JL 0x0000:5c74 (0000_5C34 / 0x5C34)
    if(SignFlag != OverflowFlag) {
      goto label_0000_5C74_05C74;
    }
    CheckExternalEvents(cs1, 0x5C39);
    // CMP AX,0xc0 (0000_5C36 / 0x5C36)
    Alu16.Sub(AX, 0xC0);
    CheckExternalEvents(cs1, 0x5C3B);
    // JGE 0x0000:5c74 (0000_5C39 / 0x5C39)
    if(SignFlag == OverflowFlag) {
      goto label_0000_5C74_05C74;
    }
    CheckExternalEvents(cs1, 0x5C40);
    // CMP word ptr [BP + -0x3a],0x13e (0000_5C3B / 0x5C3B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x3A)], 0x13E);
    CheckExternalEvents(cs1, 0x5C42);
    // JLE 0x0000:5c47 (0000_5C40 / 0x5C40)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_5C47_05C47;
    }
    CheckExternalEvents(cs1, 0x5C47);
    // MOV word ptr [BP + -0x3a],0x13e (0000_5C42 / 0x5C42)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x13E;
    label_0000_5C47_05C47:
    CheckExternalEvents(cs1, 0x5C4C);
    // CMP word ptr [BP + -0x4],0xbf (0000_5C47 / 0x5C47)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0xBF);
    CheckExternalEvents(cs1, 0x5C4E);
    // JLE 0x0000:5c53 (0000_5C4C / 0x5C4C)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_5C53_05C53;
    }
    CheckExternalEvents(cs1, 0x5C53);
    // MOV word ptr [BP + -0x4],0xbf (0000_5C4E / 0x5C4E)
    UInt16[SS, (ushort)(BP - 0x4)] = 0xBF;
    label_0000_5C53_05C53:
    CheckExternalEvents(cs1, 0x5C58);
    // CALLF 0x1000:aab0 (0000_5C53 / 0x5C53)
    FarCall(cs1, 0x5C58, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x5C5B);
    // AND AX,0xf (0000_5C58 / 0x5C58)
    // AX &= 0xF;
    AX = Alu16.And(AX, 0xF);
    CheckExternalEvents(cs1, 0x5C5C);
    // PUSH AX (0000_5C5B / 0x5C5B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5C5F);
    // MOV AX,word ptr [BP + -0x4] (0000_5C5C / 0x5C5C)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0x5C60);
    // INC AX (0000_5C5F / 0x5C5F)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs1, 0x5C61);
    // PUSH AX (0000_5C60 / 0x5C60)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5C64);
    // MOV AX,word ptr [BP + -0x3a] (0000_5C61 / 0x5C61)
    AX = UInt16[SS, (ushort)(BP - 0x3A)];
    CheckExternalEvents(cs1, 0x5C65);
    // INC AX (0000_5C64 / 0x5C64)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs1, 0x5C66);
    // PUSH AX (0000_5C65 / 0x5C65)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5C69);
    // PUSH word ptr [BP + -0x4] (0000_5C66 / 0x5C66)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x5C6C);
    // PUSH word ptr [BP + -0x3a] (0000_5C69 / 0x5C69)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x3A)]);
    CheckExternalEvents(cs1, 0x5C71);
    // CALLF 0x1000:8ccb (0000_5C6C / 0x5C6C)
    FarCall(cs1, 0x5C71, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs1, 0x5C74);
    // ADD SP,0xa (0000_5C71 / 0x5C71)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    label_0000_5C74_05C74:
    CheckExternalEvents(cs1, 0x5C78);
    // MOV ES,word ptr [0x5384] (0000_5C74 / 0x5C74)
    ES = UInt16[DS, 0x5384];
    CheckExternalEvents(cs1, 0x5C7E);
    // CMP word ptr ES:[0x3938],0x0 (0000_5C78 / 0x5C78)
    Alu16.Sub(UInt16[ES, 0x3938], 0x0);
    CheckExternalEvents(cs1, 0x5C80);
    // JNZ 0x0000:5c8a (0000_5C7E / 0x5C7E)
    if(!ZeroFlag) {
      goto label_0000_5C8A_05C8A;
    }
    CheckExternalEvents(cs1, 0x5C85);
    // CALLF 0x1000:8aff (0000_5C80 / 0x5C80)
    FarCall(cs1, 0x5C85, unknown_18AD_002F_18AFF);
    CheckExternalEvents(cs1, 0x5C88);
    // MOV word ptr [BP + -0x16],AX (0000_5C85 / 0x5C85)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0x5C8A);
    // JMP 0x0000:5ca5 (0000_5C88 / 0x5C88)
    goto label_0000_5CA5_05CA5;
    label_0000_5C8A_05C8A:
    CheckExternalEvents(cs1, 0x5C8D);
    // MOV AX,word ptr [BP + -0x8] (0000_5C8A / 0x5C8A)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0x5C90);
    // DEC word ptr [BP + -0x8] (0000_5C8D / 0x5C8D)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x5C92);
    // OR AX,AX (0000_5C90 / 0x5C90)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0x5C94);
    // JNZ 0x0000:5c99 (0000_5C92 / 0x5C92)
    if(!ZeroFlag) {
      goto label_0000_5C99_05C99;
    }
    CheckExternalEvents(cs1, 0x5C99);
    // MOV word ptr [BP + -0x16],0x1 (0000_5C94 / 0x5C94)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x1;
    label_0000_5C99_05C99:
    CheckExternalEvents(cs1, 0x5C9C);
    // MOV AX,0x1 (0000_5C99 / 0x5C99)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x5C9D);
    // PUSH AX (0000_5C9C / 0x5C9C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x5CA2);
    // CALLF 0x1000:8ad6 (0000_5C9D / 0x5C9D)
    FarCall(cs1, 0x5CA2, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs1, 0x5CA5);
    // ADD SP,0x2 (0000_5CA2 / 0x5CA2)
    SP += 0x2;
    label_0000_5CA5_05CA5:
    CheckExternalEvents(cs1, 0x5CA9);
    // CMP word ptr [BP + -0x16],0x0 (0000_5CA5 / 0x5CA5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x16)], 0x0);
    CheckExternalEvents(cs1, 0x5CAB);
    // JNZ 0x0000:5cae (0000_5CA9 / 0x5CA9)
    if(!ZeroFlag) {
      goto label_0000_5CAE_05CAE;
    }
    CheckExternalEvents(cs1, 0x5CAE);
    // JMP 0x0000:5bc5 (0000_5CAB / 0x5CAB)
    goto label_0000_5BC5_05BC5;
    label_0000_5CAE_05CAE:
    CheckExternalEvents(cs1, 0x5CB3);
    // CALLF 0x1000:8d29 (0000_5CAE / 0x5CAE)
    FarCall(cs1, 0x5CB3, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0x5CB6);
    // MOV word ptr [BP + -0x22],AX (0000_5CB3 / 0x5CB3)
    UInt16[SS, (ushort)(BP - 0x22)] = AX;
    CheckExternalEvents(cs1, 0x5CB7);
    // PUSH CS (0000_5CB6 / 0x5CB6)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x5CBA);
    // CALL 0x0000:412b (0000_5CB7 / 0x5CB7)
    NearCall(cs1, 0x5CBA, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs1, 0x5CBD);
    // MOV AX,word ptr [BP + -0x22] (0000_5CBA / 0x5CBA)
    AX = UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs1, 0x5CBE);
    // POP SI (0000_5CBD / 0x5CBD)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x5CC0);
    // MOV SP,BP (0000_5CBE / 0x5CBE)
    SP = BP;
    CheckExternalEvents(cs1, 0x5CC1);
    // POP BP (0000_5CC0 / 0x5CC0)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x5CC2);
    // RETF  (0000_5CC1 / 0x5CC1)
    return FarRet();
  }
  
}
