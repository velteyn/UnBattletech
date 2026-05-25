namespace generated;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.InstructionsImpl;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action split_1000_C8AD_1C8AD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C8AD_1C8AD:
    CheckExternalEvents(cs8, 0xC8AF);
    // JMP 0x1000:c908 (1000_C8AD / 0x1C8AD)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_C8B0_1C8B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C8B0_1C8B0:
    CheckExternalEvents(cs8, 0xC8B3);
    // MOV AX,[0xb794] (1000_C8B0 / 0x1C8B0)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs8, 0xC8B6);
    // MOV DX,0xa0 (1000_C8B3 / 0x1C8B3)
    DX = 0xA0;
    CheckExternalEvents(cs8, 0xC8B8);
    // MUL DL (1000_C8B6 / 0x1C8B6)
    ushort resMul1000_C8B6 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_C8B6);
    AH = (byte)(resMul1000_C8B6 >> 8);
    CheckExternalEvents(cs8, 0xC8BC);
    // ADD AX,word ptr [0xb792] (1000_C8B8 / 0x1C8B8)
    AX += UInt16[DS, 0xB792];
    CheckExternalEvents(cs8, 0xC8C0);
    // ADD AX,word ptr [0xb78e] (1000_C8BC / 0x1C8BC)
    // AX += UInt16[DS, 0xB78E];
    AX = Alu16.Add(AX, UInt16[DS, 0xB78E]);
    CheckExternalEvents(cs8, 0xC8C2);
    // MOV DI,AX (1000_C8C0 / 0x1C8C0)
    DI = AX;
    CheckExternalEvents(cs8, 0xC8C6);
    // MOV DX,word ptr [0xb790] (1000_C8C2 / 0x1C8C2)
    DX = UInt16[DS, 0xB790];
    CheckExternalEvents(cs8, 0xC8C8);
    // MOV ES,DX (1000_C8C6 / 0x1C8C6)
    ES = DX;
    CheckExternalEvents(cs8, 0xC8CB);
    // MOV AX,0xa0 (1000_C8C8 / 0x1C8C8)
    AX = 0xA0;
    CheckExternalEvents(cs8, 0xC8CF);
    // SUB AX,word ptr [0xb79a] (1000_C8CB / 0x1C8CB)
    // AX -= UInt16[DS, 0xB79A];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB79A]);
    CheckExternalEvents(cs8, 0xC8D2);
    // MOV [0xb794],AX (1000_C8CF / 0x1C8CF)
    UInt16[DS, 0xB794] = AX;
    CheckExternalEvents(cs8, 0xC8D6);
    // MOV DX,word ptr [0xb78c] (1000_C8D2 / 0x1C8D2)
    DX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs8, 0xC8D9);
    // MOV BX,0xb661 (1000_C8D6 / 0x1C8D6)
    BX = 0xB661;
    label_1000_C8D9_1C8D9:
    CheckExternalEvents(cs8, 0xC8DD);
    // MOV CX,word ptr [0xb79a] (1000_C8D9 / 0x1C8D9)
    CX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs8, 0xC8DE);
    // PUSH BP (1000_C8DD / 0x1C8DD)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xC8E0);
    // MOV BP,ES (1000_C8DE / 0x1C8DE)
    BP = ES;
    label_1000_C8E0_1C8E0:
    CheckExternalEvents(cs8, 0xC8E2);
    // MOV ES,DX (1000_C8E0 / 0x1C8E0)
    ES = DX;
    CheckExternalEvents(cs8, 0xC8E5);
    // MOV AL,byte ptr ES:[SI] (1000_C8E2 / 0x1C8E2)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xC8E7);
    // MOV AH,AL (1000_C8E5 / 0x1C8E5)
    AH = AL;
    CheckExternalEvents(cs8, 0xC8E8);
    // XLAT BX (1000_C8E7 / 0x1C8E7)
    AL = UInt8[DS, (ushort)(BX + AL)];
    CheckExternalEvents(cs8, 0xC8EA);
    // MOV ES,BP (1000_C8E8 / 0x1C8E8)
    ES = BP;
    CheckExternalEvents(cs8, 0xC8ED);
    // AND byte ptr ES:[DI],AL (1000_C8EA / 0x1C8EA)
    // UInt8[ES, (ushort)(DI)] &= AL;
    UInt8[ES, (ushort)(DI)] = Alu8.And(UInt8[ES, (ushort)(DI)], AL);
    CheckExternalEvents(cs8, 0xC8F0);
    // OR byte ptr ES:[DI],AH (1000_C8ED / 0x1C8ED)
    UInt8[ES, (ushort)(DI)] |= AH;
    CheckExternalEvents(cs8, 0xC8F1);
    // INC SI (1000_C8F0 / 0x1C8F0)
    SI++;
    CheckExternalEvents(cs8, 0xC8F2);
    // INC DI (1000_C8F1 / 0x1C8F1)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs8, 0xC8F4);
    // LOOP 0x1000:c8e0 (1000_C8F2 / 0x1C8F2)
    if(--CX != 0) {
      goto label_1000_C8E0_1C8E0;
    }
    CheckExternalEvents(cs8, 0xC8F5);
    // POP BP (1000_C8F4 / 0x1C8F4)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC8F9);
    // ADD SI,word ptr [0xb79e] (1000_C8F5 / 0x1C8F5)
    SI += UInt16[DS, 0xB79E];
    CheckExternalEvents(cs8, 0xC8FD);
    // SUB SI,word ptr [0xb79a] (1000_C8F9 / 0x1C8F9)
    SI -= UInt16[DS, 0xB79A];
    CheckExternalEvents(cs8, 0xC901);
    // ADD DI,word ptr [0xb794] (1000_C8FD / 0x1C8FD)
    DI += UInt16[DS, 0xB794];
    CheckExternalEvents(cs8, 0xC906);
    // SUB word ptr [0xb79c],0x1 (1000_C901 / 0x1C901)
    // UInt16[DS, 0xB79C] -= 0x1;
    UInt16[DS, 0xB79C] = Alu16.Sub(UInt16[DS, 0xB79C], 0x1);
    CheckExternalEvents(cs8, 0xC908);
    // JNZ 0x1000:c8d9 (1000_C906 / 0x1C906)
    if(!ZeroFlag) {
      goto label_1000_C8D9_1C8D9;
    }
    label_1000_C908_1C908:
    CheckExternalEvents(cs8, 0xC909);
    // POP ES (1000_C908 / 0x1C908)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC90A);
    // POP DS (1000_C909 / 0x1C909)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC90B);
    // POP SI (1000_C90A / 0x1C90A)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC90C);
    // POP DI (1000_C90B / 0x1C90B)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC90D);
    // POP BP (1000_C90C / 0x1C90C)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC90E);
    // RETF  (1000_C90D / 0x1C90D)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_C90E_1C90E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C90E_1C90E:
    CheckExternalEvents(cs8, 0xC90F);
    // PUSH ES (1000_C90E / 0x1C90E)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xC912);
    // MOV AX,word ptr [BP + 0x6] (1000_C90F / 0x1C90F)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xC915);
    // MOV [0xb78e],AX (1000_C912 / 0x1C912)
    UInt16[DS, 0xB78E] = AX;
    CheckExternalEvents(cs8, 0xC918);
    // MOV AX,word ptr [BP + 0x8] (1000_C915 / 0x1C915)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0xC91B);
    // MOV [0xb790],AX (1000_C918 / 0x1C918)
    UInt16[DS, 0xB790] = AX;
    CheckExternalEvents(cs8, 0xC91E);
    // MOV AX,word ptr [BP + 0xa] (1000_C91B / 0x1C91B)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0xC921);
    // MOV [0xb78a],AX (1000_C91E / 0x1C91E)
    UInt16[DS, 0xB78A] = AX;
    CheckExternalEvents(cs8, 0xC924);
    // MOV AX,word ptr [BP + 0xc] (1000_C921 / 0x1C921)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0xC927);
    // MOV [0xb78c],AX (1000_C924 / 0x1C924)
    UInt16[DS, 0xB78C] = AX;
    CheckExternalEvents(cs8, 0xC92A);
    // MOV AX,word ptr [BP + 0xe] (1000_C927 / 0x1C927)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs8, 0xC92C);
    // SAR AX,0x1 (1000_C92A / 0x1C92A)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs8, 0xC92E);
    // SAR AX,0x1 (1000_C92C / 0x1C92C)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs8, 0xC931);
    // MOV [0xb792],AX (1000_C92E / 0x1C92E)
    UInt16[DS, 0xB792] = AX;
    CheckExternalEvents(cs8, 0xC934);
    // MOV AX,word ptr [BP + 0x10] (1000_C931 / 0x1C931)
    AX = UInt16[SS, (ushort)(BP + 0x10)];
    CheckExternalEvents(cs8, 0xC937);
    // MOV [0xb794],AX (1000_C934 / 0x1C934)
    UInt16[DS, 0xB794] = AX;
    CheckExternalEvents(cs8, 0xC938);
    // PUSH DS (1000_C937 / 0x1C937)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xC93C);
    // MOV SI,word ptr [0xb78a] (1000_C938 / 0x1C938)
    SI = UInt16[DS, 0xB78A];
    CheckExternalEvents(cs8, 0xC93D);
    // INC SI (1000_C93C / 0x1C93C)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC940);
    // MOV AX,[0xb78c] (1000_C93D / 0x1C93D)
    AX = UInt16[DS, 0xB78C];
    CheckExternalEvents(cs8, 0xC942);
    // MOV DS,AX (1000_C940 / 0x1C940)
    DS = AX;
    CheckExternalEvents(cs8, 0xC943);
    // LODSW SI (1000_C942 / 0x1C942)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs8, 0xC944);
    // INC SI (1000_C943 / 0x1C943)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xC946);
    // MOV BX,SI (1000_C944 / 0x1C944)
    BX = SI;
    CheckExternalEvents(cs8, 0xC947);
    // POP DS (1000_C946 / 0x1C946)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC949);
    // INC AL (1000_C947 / 0x1C947)
    AL = Alu8.Inc(AL);
    CheckExternalEvents(cs8, 0xC94A);
    // PUSH AX (1000_C949 / 0x1C949)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0xC94D);
    // AND AX,0xff (1000_C94A / 0x1C94A)
    // AX &= 0xFF;
    AX = Alu16.And(AX, 0xFF);
    CheckExternalEvents(cs8, 0xC950);
    // MOV [0xb79c],AX (1000_C94D / 0x1C94D)
    UInt16[DS, 0xB79C] = AX;
    CheckExternalEvents(cs8, 0xC952);
    // MOV DX,AX (1000_C950 / 0x1C950)
    DX = AX;
    CheckExternalEvents(cs8, 0xC953);
    // POP AX (1000_C952 / 0x1C952)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xC955);
    // XCHG AH,AL (1000_C953 / 0x1C953)
    (AL, AH) = (AH, AL);
    CheckExternalEvents(cs8, 0xC958);
    // AND AX,0xff (1000_C955 / 0x1C955)
    AX &= 0xFF;
    CheckExternalEvents(cs8, 0xC95A);
    // SHL AX,0x1 (1000_C958 / 0x1C958)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs8, 0xC95D);
    // MOV [0xb79a],AX (1000_C95A / 0x1C95A)
    UInt16[DS, 0xB79A] = AX;
    CheckExternalEvents(cs8, 0xC960);
    // MOV [0xb79e],AX (1000_C95D / 0x1C95D)
    UInt16[DS, 0xB79E] = AX;
    CheckExternalEvents(cs8, 0xC962);
    // XOR AH,AH (1000_C960 / 0x1C960)
    AH = 0;
    CheckExternalEvents(cs8, 0xC964);
    // MUL DL (1000_C962 / 0x1C962)
    ushort resMul1000_C962 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_C962);
    AH = (byte)(resMul1000_C962 >> 8);
    CheckExternalEvents(cs8, 0xC966);
    // ADD BX,AX (1000_C964 / 0x1C964)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs8, 0xC969);
    // MOV AX,[0xb794] (1000_C966 / 0x1C966)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs8, 0xC96C);
    // CMP AX,0x0 (1000_C969 / 0x1C969)
    Alu16.Sub(AX, 0x0);
    CheckExternalEvents(cs8, 0xC96E);
    // JNS 0x1000:c991 (1000_C96C / 0x1C96C)
    if(!SignFlag) {
      goto label_1000_C991_1C991;
    }
    CheckExternalEvents(cs8, 0xC970);
    // NEG AX (1000_C96E / 0x1C96E)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs8, 0xC974);
    // CMP AX,word ptr [0xb79c] (1000_C970 / 0x1C970)
    Alu16.Sub(AX, UInt16[DS, 0xB79C]);
    CheckExternalEvents(cs8, 0xC976);
    // JNC 0x1000:c9d9 (1000_C974 / 0x1C974)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC9DC);
      // JMP 0x1000:c908 (1000_C9D9 / 0x1C9D9)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC97A);
    // MOV DX,word ptr [0xb79a] (1000_C976 / 0x1C976)
    DX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs8, 0xC97C);
    // MUL DL (1000_C97A / 0x1C97A)
    ushort resMul1000_C97A = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_C97A);
    AH = (byte)(resMul1000_C97A >> 8);
    CheckExternalEvents(cs8, 0xC97E);
    // ADD SI,AX (1000_C97C / 0x1C97C)
    SI += AX;
    CheckExternalEvents(cs8, 0xC980);
    // ADD BX,AX (1000_C97E / 0x1C97E)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs8, 0xC983);
    // MOV AX,[0xb79c] (1000_C980 / 0x1C980)
    AX = UInt16[DS, 0xB79C];
    CheckExternalEvents(cs8, 0xC987);
    // ADD AX,word ptr [0xb794] (1000_C983 / 0x1C983)
    // AX += UInt16[DS, 0xB794];
    AX = Alu16.Add(AX, UInt16[DS, 0xB794]);
    CheckExternalEvents(cs8, 0xC989);
    // JS 0x1000:c9d9 (1000_C987 / 0x1C987)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC9DC);
      // JMP 0x1000:c908 (1000_C9D9 / 0x1C9D9)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC98C);
    // MOV [0xb79c],AX (1000_C989 / 0x1C989)
    UInt16[DS, 0xB79C] = AX;
    CheckExternalEvents(cs8, 0xC98E);
    // XOR AX,AX (1000_C98C / 0x1C98C)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0xC991);
    // MOV [0xb794],AX (1000_C98E / 0x1C98E)
    UInt16[DS, 0xB794] = AX;
    label_1000_C991_1C991:
    CheckExternalEvents(cs8, 0xC994);
    // MOV AX,[0xb780] (1000_C991 / 0x1C991)
    AX = UInt16[DS, 0xB780];
    CheckExternalEvents(cs8, 0xC998);
    // SUB AX,word ptr [0xb794] (1000_C994 / 0x1C994)
    // AX -= UInt16[DS, 0xB794];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB794]);
    CheckExternalEvents(cs8, 0xC99A);
    // JS 0x1000:c9d9 (1000_C998 / 0x1C998)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC9DC);
      // JMP 0x1000:c908 (1000_C9D9 / 0x1C9D9)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC99C);
    // JZ 0x1000:c9d9 (1000_C99A / 0x1C99A)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC9DC);
      // JMP 0x1000:c908 (1000_C9D9 / 0x1C9D9)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC9A0);
    // CMP AX,word ptr [0xb79c] (1000_C99C / 0x1C99C)
    Alu16.Sub(AX, UInt16[DS, 0xB79C]);
    CheckExternalEvents(cs8, 0xC9A2);
    // JNC 0x1000:c9a5 (1000_C9A0 / 0x1C9A0)
    if(!CarryFlag) {
      goto label_1000_C9A5_1C9A5;
    }
    CheckExternalEvents(cs8, 0xC9A5);
    // MOV [0xb79c],AX (1000_C9A2 / 0x1C9A2)
    UInt16[DS, 0xB79C] = AX;
    label_1000_C9A5_1C9A5:
    CheckExternalEvents(cs8, 0xC9A8);
    // MOV AX,[0xb792] (1000_C9A5 / 0x1C9A5)
    AX = UInt16[DS, 0xB792];
    CheckExternalEvents(cs8, 0xC9AB);
    // CMP AX,0x0 (1000_C9A8 / 0x1C9A8)
    Alu16.Sub(AX, 0x0);
    CheckExternalEvents(cs8, 0xC9AD);
    // JNS 0x1000:c9c2 (1000_C9AB / 0x1C9AB)
    if(!SignFlag) {
      goto label_1000_C9C2_1C9C2;
    }
    CheckExternalEvents(cs8, 0xC9B1);
    // ADD word ptr [0xb79a],AX (1000_C9AD / 0x1C9AD)
    UInt16[DS, 0xB79A] += AX;
    CheckExternalEvents(cs8, 0xC9B3);
    // NEG AX (1000_C9B1 / 0x1C9B1)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs8, 0xC9B5);
    // ADD SI,AX (1000_C9B3 / 0x1C9B3)
    SI += AX;
    CheckExternalEvents(cs8, 0xC9B7);
    // ADD BX,AX (1000_C9B5 / 0x1C9B5)
    BX += AX;
    CheckExternalEvents(cs8, 0xC9BB);
    // CMP AX,word ptr [0xb79e] (1000_C9B7 / 0x1C9B7)
    Alu16.Sub(AX, UInt16[DS, 0xB79E]);
    CheckExternalEvents(cs8, 0xC9BD);
    // JNC 0x1000:c9d9 (1000_C9BB / 0x1C9BB)
    if(!CarryFlag) {
      // JNC target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC9DC);
      // JMP 0x1000:c908 (1000_C9D9 / 0x1C9D9)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC9BF);
    // XOR AX,AX (1000_C9BD / 0x1C9BD)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0xC9C2);
    // MOV [0xb792],AX (1000_C9BF / 0x1C9BF)
    UInt16[DS, 0xB792] = AX;
    label_1000_C9C2_1C9C2:
    CheckExternalEvents(cs8, 0xC9C5);
    // MOV AX,0x50 (1000_C9C2 / 0x1C9C2)
    AX = 0x50;
    CheckExternalEvents(cs8, 0xC9C9);
    // SUB AX,word ptr [0xb792] (1000_C9C5 / 0x1C9C5)
    // AX -= UInt16[DS, 0xB792];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs8, 0xC9CB);
    // JS 0x1000:c9d9 (1000_C9C9 / 0x1C9C9)
    if(SignFlag) {
      // JS target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC9DC);
      // JMP 0x1000:c908 (1000_C9D9 / 0x1C9D9)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC9CD);
    // JZ 0x1000:c9d9 (1000_C9CB / 0x1C9CB)
    if(ZeroFlag) {
      // JZ target is JMP, inlining.
      CheckExternalEvents(cs8, 0xC9DC);
      // JMP 0x1000:c908 (1000_C9D9 / 0x1C9D9)
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC9D1);
    // CMP AX,word ptr [0xb79a] (1000_C9CD / 0x1C9CD)
    Alu16.Sub(AX, UInt16[DS, 0xB79A]);
    CheckExternalEvents(cs8, 0xC9D3);
    // JNC 0x1000:c9dc (1000_C9D1 / 0x1C9D1)
    if(!CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_C9DC_1C9DC, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xC9D6);
    // MOV [0xb79a],AX (1000_C9D3 / 0x1C9D3)
    UInt16[DS, 0xB79A] = AX;
    CheckExternalEvents(cs8, 0xC9D8);
    // JMP 0x1000:c9dc (1000_C9D6 / 0x1C9D6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_C9DC_1C9DC, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_C9D9_1C9D9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C9D9_1C9D9:
    CheckExternalEvents(cs8, 0xC9DC);
    // JMP 0x1000:c908 (1000_C9D9 / 0x1C9D9)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ghidra_guess_1000_C9DC_1C9DC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_C9DC_1C9DC:
    CheckExternalEvents(cs8, 0xC9DF);
    // MOV AX,[0xb794] (1000_C9DC / 0x1C9DC)
    AX = UInt16[DS, 0xB794];
    CheckExternalEvents(cs8, 0xC9E2);
    // MOV DX,0x50 (1000_C9DF / 0x1C9DF)
    DX = 0x50;
    CheckExternalEvents(cs8, 0xC9E4);
    // MUL DL (1000_C9E2 / 0x1C9E2)
    ushort resMul1000_C9E2 = Alu8.Mul(AL, DL);
    AL = (byte)(resMul1000_C9E2);
    AH = (byte)(resMul1000_C9E2 >> 8);
    CheckExternalEvents(cs8, 0xC9E8);
    // ADD AX,word ptr [0xb792] (1000_C9E4 / 0x1C9E4)
    AX += UInt16[DS, 0xB792];
    CheckExternalEvents(cs8, 0xC9EC);
    // ADD AX,word ptr [0xb78e] (1000_C9E8 / 0x1C9E8)
    // AX += UInt16[DS, 0xB78E];
    AX = Alu16.Add(AX, UInt16[DS, 0xB78E]);
    CheckExternalEvents(cs8, 0xC9EE);
    // MOV DI,AX (1000_C9EC / 0x1C9EC)
    DI = AX;
    CheckExternalEvents(cs8, 0xC9F2);
    // MOV DX,word ptr [0xb790] (1000_C9EE / 0x1C9EE)
    DX = UInt16[DS, 0xB790];
    CheckExternalEvents(cs8, 0xC9F4);
    // MOV ES,DX (1000_C9F2 / 0x1C9F2)
    ES = DX;
    CheckExternalEvents(cs8, 0xC9F7);
    // MOV AX,0x50 (1000_C9F4 / 0x1C9F4)
    AX = 0x50;
    CheckExternalEvents(cs8, 0xC9FB);
    // SUB AX,word ptr [0xb79a] (1000_C9F7 / 0x1C9F7)
    // AX -= UInt16[DS, 0xB79A];
    AX = Alu16.Sub(AX, UInt16[DS, 0xB79A]);
    CheckExternalEvents(cs8, 0xC9FE);
    // MOV [0xb794],AX (1000_C9FB / 0x1C9FB)
    UInt16[DS, 0xB794] = AX;
    CheckExternalEvents(cs8, 0xCA02);
    // MOV DX,word ptr [0xb78c] (1000_C9FE / 0x1C9FE)
    DX = UInt16[DS, 0xB78C];
    label_1000_CA02_1CA02:
    CheckExternalEvents(cs8, 0xCA06);
    // MOV CX,word ptr [0xb79a] (1000_CA02 / 0x1CA02)
    CX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs8, 0xCA07);
    // PUSH DS (1000_CA06 / 0x1CA06)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xCA09);
    // MOV DS,DX (1000_CA07 / 0x1CA07)
    DS = DX;
    label_1000_CA09_1CA09:
    CheckExternalEvents(cs8, 0xCA0B);
    // MOV AL,byte ptr [BX] (1000_CA09 / 0x1CA09)
    AL = UInt8[DS, (ushort)(BX)];
    CheckExternalEvents(cs8, 0xCA0C);
    // INC BX (1000_CA0B / 0x1CA0B)
    BX++;
    CheckExternalEvents(cs8, 0xCA0F);
    // AND byte ptr ES:[DI],AL (1000_CA0C / 0x1CA0C)
    // UInt8[ES, (ushort)(DI)] &= AL;
    UInt8[ES, (ushort)(DI)] = Alu8.And(UInt8[ES, (ushort)(DI)], AL);
    CheckExternalEvents(cs8, 0xCA10);
    // LODSB SI (1000_CA0F / 0x1CA0F)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xCA13);
    // OR byte ptr ES:[DI],AL (1000_CA10 / 0x1CA10)
    UInt8[ES, (ushort)(DI)] |= AL;
    CheckExternalEvents(cs8, 0xCA14);
    // INC DI (1000_CA13 / 0x1CA13)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs8, 0xCA16);
    // LOOP 0x1000:ca09 (1000_CA14 / 0x1CA14)
    if(--CX != 0) {
      goto label_1000_CA09_1CA09;
    }
    CheckExternalEvents(cs8, 0xCA17);
    // POP DS (1000_CA16 / 0x1CA16)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCA1B);
    // ADD SI,word ptr [0xb79e] (1000_CA17 / 0x1CA17)
    SI += UInt16[DS, 0xB79E];
    CheckExternalEvents(cs8, 0xCA1F);
    // SUB SI,word ptr [0xb79a] (1000_CA1B / 0x1CA1B)
    SI -= UInt16[DS, 0xB79A];
    CheckExternalEvents(cs8, 0xCA23);
    // ADD BX,word ptr [0xb79e] (1000_CA1F / 0x1CA1F)
    BX += UInt16[DS, 0xB79E];
    CheckExternalEvents(cs8, 0xCA27);
    // SUB BX,word ptr [0xb79a] (1000_CA23 / 0x1CA23)
    BX -= UInt16[DS, 0xB79A];
    CheckExternalEvents(cs8, 0xCA2B);
    // ADD DI,word ptr [0xb794] (1000_CA27 / 0x1CA27)
    DI += UInt16[DS, 0xB794];
    CheckExternalEvents(cs8, 0xCA30);
    // SUB word ptr [0xb79c],0x1 (1000_CA2B / 0x1CA2B)
    // UInt16[DS, 0xB79C] -= 0x1;
    UInt16[DS, 0xB79C] = Alu16.Sub(UInt16[DS, 0xB79C], 0x1);
    CheckExternalEvents(cs8, 0xCA32);
    // JNZ 0x1000:ca02 (1000_CA30 / 0x1CA30)
    if(!ZeroFlag) {
      goto label_1000_CA02_1CA02;
    }
    CheckExternalEvents(cs8, 0xCA35);
    // JMP 0x1000:c908 (1000_CA32 / 0x1CA32)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_C8B0_1C8B0, 0x1C908 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ghidra_guess_1000_CA35_1CA35(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CA35_1CA35:
    CheckExternalEvents(cs8, 0xCA36);
    // PUSH BP (1000_CA35 / 0x1CA35)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xCA38);
    // MOV BP,SP (1000_CA36 / 0x1CA36)
    BP = SP;
    CheckExternalEvents(cs8, 0xCA39);
    // PUSH DI (1000_CA38 / 0x1CA38)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xCA3A);
    // PUSH SI (1000_CA39 / 0x1CA39)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xCA3B);
    // PUSH DS (1000_CA3A / 0x1CA3A)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xCA3E);
    // MOV AX,0x1ddc (1000_CA3B / 0x1CA3B)
    AX = 0x1DDC;
    CheckExternalEvents(cs8, 0xCA40);
    // MOV DS,AX (1000_CA3E / 0x1CA3E)
    DS = AX;
    CheckExternalEvents(cs8, 0xCA45);
    // CMP word ptr [0xb764],0x1 (1000_CA40 / 0x1CA40)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs8, 0xCA47);
    // JNZ 0x1000:ca72 (1000_CA45 / 0x1CA45)
    if(!ZeroFlag) {
      goto label_1000_CA72_1CA72;
    }
    CheckExternalEvents(cs8, 0xCA4A);
    // MOV AX,word ptr [BP + 0x6] (1000_CA47 / 0x1CA47)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xCA4C);
    // MOV SI,AX (1000_CA4A / 0x1CA4A)
    SI = AX;
    CheckExternalEvents(cs8, 0xCA4F);
    // MOV AX,word ptr [BP + 0x8] (1000_CA4C / 0x1CA4C)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0xCA50);
    // PUSH ES (1000_CA4F / 0x1CA4F)
    Stack.Push16(ES);
    CheckExternalEvents(cs8, 0xCA52);
    // MOV ES,AX (1000_CA50 / 0x1CA50)
    ES = AX;
    CheckExternalEvents(cs8, 0xCA55);
    // MOV CX,0x10 (1000_CA52 / 0x1CA52)
    CX = 0x10;
    CheckExternalEvents(cs8, 0xCA57);
    // MOV BL,0x10 (1000_CA55 / 0x1CA55)
    BL = 0x10;
    label_1000_CA57_1CA57:
    CheckExternalEvents(cs8, 0xCA5A);
    // MOV DX,0x3da (1000_CA57 / 0x1CA57)
    DX = 0x3DA;
    CheckExternalEvents(cs8, 0xCA5B);
    // IN AL,DX (1000_CA5A / 0x1CA5A)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs8, 0xCA5D);
    // MOV AL,BL (1000_CA5B / 0x1CA5B)
    AL = BL;
    CheckExternalEvents(cs8, 0xCA5E);
    // OUT DX,AL (1000_CA5D / 0x1CA5D)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs8, 0xCA61);
    // MOV AL,byte ptr ES:[SI] (1000_CA5E / 0x1CA5E)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xCA64);
    // MOV DX,0x3de (1000_CA61 / 0x1CA61)
    DX = 0x3DE;
    CheckExternalEvents(cs8, 0xCA65);
    // OUT DX,AL (1000_CA64 / 0x1CA64)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs8, 0xCA67);
    // INC BL (1000_CA65 / 0x1CA65)
    BL++;
    CheckExternalEvents(cs8, 0xCA68);
    // INC SI (1000_CA67 / 0x1CA67)
    SI = Alu16.Inc(SI);
    CheckExternalEvents(cs8, 0xCA6A);
    // LOOP 0x1000:ca57 (1000_CA68 / 0x1CA68)
    if(--CX != 0) {
      goto label_1000_CA57_1CA57;
    }
    CheckExternalEvents(cs8, 0xCA6D);
    // MOV DX,0x3da (1000_CA6A / 0x1CA6A)
    DX = 0x3DA;
    CheckExternalEvents(cs8, 0xCA6E);
    // IN AL,DX (1000_CA6D / 0x1CA6D)
    AL = Cpu.In8(DX);
    CheckExternalEvents(cs8, 0xCA70);
    // MOV AL,0xf (1000_CA6E / 0x1CA6E)
    AL = 0xF;
    CheckExternalEvents(cs8, 0xCA71);
    // OUT DX,AL (1000_CA70 / 0x1CA70)
    Cpu.Out8(DX, AL);
    CheckExternalEvents(cs8, 0xCA72);
    // POP ES (1000_CA71 / 0x1CA71)
    ES = Stack.Pop16();;
    label_1000_CA72_1CA72:
    CheckExternalEvents(cs8, 0xCA73);
    // POP DS (1000_CA72 / 0x1CA72)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCA74);
    // POP SI (1000_CA73 / 0x1CA73)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCA75);
    // POP DI (1000_CA74 / 0x1CA74)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCA76);
    // POP BP (1000_CA75 / 0x1CA75)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCA77);
    // RETF  (1000_CA76 / 0x1CA76)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_2B87_1CA77(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_2B87_1CA77:
    CheckExternalEvents(cs14, 0x2B88);
    // PUSH BP (19EF_2B87 / 0x1CA77)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x2B8A);
    // MOV BP,SP (19EF_2B88 / 0x1CA78)
    BP = SP;
    CheckExternalEvents(cs14, 0x2B8B);
    // PUSH DI (19EF_2B8A / 0x1CA7A)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x2B8C);
    // PUSH SI (19EF_2B8B / 0x1CA7B)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x2B8D);
    // PUSH DS (19EF_2B8C / 0x1CA7C)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2B90);
    // MOV AX,0x1ddc (19EF_2B8D / 0x1CA7D)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x2B92);
    // MOV DS,AX (19EF_2B90 / 0x1CA80)
    DS = AX;
    CheckExternalEvents(cs14, 0x2B95);
    // MOV AX,word ptr [BP + 0x6] (19EF_2B92 / 0x1CA82)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x2B9A);
    // CMP word ptr [0xb764],0x2 (19EF_2B95 / 0x1CA85)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x2B9C);
    // JZ 0x1000:caa0 (19EF_2B9A / 0x1CA8A)
    if(ZeroFlag) {
      goto label_19EF_2BB0_1CAA0;
    }
    CheckExternalEvents(cs14, 0x2B9E);
    // SHL AX,0x1 (19EF_2B9C / 0x1CA8C)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x2BA3);
    // CMP word ptr [0xb764],0x0 (19EF_2B9E / 0x1CA8E)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x2BA5);
    // JZ 0x1000:caa0 (19EF_2BA3 / 0x1CA93)
    if(ZeroFlag) {
      goto label_19EF_2BB0_1CAA0;
    }
    CheckExternalEvents(cs14, 0x2BA7);
    // SHL AX,0x1 (19EF_2BA5 / 0x1CA95)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x2BAC);
    // CMP word ptr [0xb764],0x1 (19EF_2BA7 / 0x1CA97)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs14, 0x2BAE);
    // JZ 0x1000:caa0 (19EF_2BAC / 0x1CA9C)
    if(ZeroFlag) {
      goto label_19EF_2BB0_1CAA0;
    }
    CheckExternalEvents(cs14, 0x2BB0);
    // SHL AX,0x1 (19EF_2BAE / 0x1CA9E)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    label_19EF_2BB0_1CAA0:
    CheckExternalEvents(cs14, 0x2BB3);
    // MOV [0xb792],AX (19EF_2BB0 / 0x1CAA0)
    UInt16[DS, 0xB792] = AX;
    CheckExternalEvents(cs14, 0x2BB6);
    // MOV AX,word ptr [BP + 0x8] (19EF_2BB3 / 0x1CAA3)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x2BB9);
    // MOV DX,0x140 (19EF_2BB6 / 0x1CAA6)
    DX = 0x140;
    CheckExternalEvents(cs14, 0x2BBE);
    // CMP word ptr [0xb764],0x3 (19EF_2BB9 / 0x1CAA9)
    Alu16.Sub(UInt16[DS, 0xB764], 0x3);
    CheckExternalEvents(cs14, 0x2BC0);
    // JNZ 0x1000:cab3 (19EF_2BBE / 0x1CAAE)
    if(!ZeroFlag) {
      goto label_19EF_2BC3_1CAB3;
    }
    CheckExternalEvents(cs14, 0x2BC3);
    // MOV DX,0xa00 (19EF_2BC0 / 0x1CAB0)
    DX = 0xA00;
    label_19EF_2BC3_1CAB3:
    CheckExternalEvents(cs14, 0x2BC5);
    // MUL DX (19EF_2BC3 / 0x1CAB3)
    uint resMul19EF_2BC3 = Alu16.Mul(AX, DX);
    AX = (ushort)(resMul19EF_2BC3);
    DX = (ushort)(resMul19EF_2BC3 >> 16);
    CheckExternalEvents(cs14, 0x2BC9);
    // ADD AX,word ptr [0xb792] (19EF_2BC5 / 0x1CAB5)
    // AX += UInt16[DS, 0xB792];
    AX = Alu16.Add(AX, UInt16[DS, 0xB792]);
    CheckExternalEvents(cs14, 0x2BCB);
    // MOV DI,AX (19EF_2BC9 / 0x1CAB9)
    DI = AX;
    CheckExternalEvents(cs14, 0x2BCD);
    // MOV SI,AX (19EF_2BCB / 0x1CABB)
    SI = AX;
    CheckExternalEvents(cs14, 0x2BD1);
    // ADD SI,0xa0 (19EF_2BCD / 0x1CABD)
    // SI += 0xA0;
    SI = Alu16.Add(SI, 0xA0);
    CheckExternalEvents(cs14, 0x2BD2);
    // PUSH ES (19EF_2BD1 / 0x1CAC1)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x2BD5);
    // MOV AX,0xb800 (19EF_2BD2 / 0x1CAC2)
    AX = 0xB800;
    CheckExternalEvents(cs14, 0x2BDA);
    // CMP word ptr [0xb764],0x2 (19EF_2BD5 / 0x1CAC5)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x2BDC);
    // JC 0x1000:cacf (19EF_2BDA / 0x1CACA)
    if(CarryFlag) {
      goto label_19EF_2BDF_1CACF;
    }
    CheckExternalEvents(cs14, 0x2BDF);
    // MOV AX,0xa000 (19EF_2BDC / 0x1CACC)
    AX = 0xA000;
    label_19EF_2BDF_1CACF:
    CheckExternalEvents(cs14, 0x2BE1);
    // MOV ES,AX (19EF_2BDF / 0x1CACF)
    ES = AX;
    CheckExternalEvents(cs14, 0x2BE4);
    // MOV AX,word ptr [BP + 0xa] (19EF_2BE1 / 0x1CAD1)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x2BE9);
    // CMP word ptr [0xb764],0x3 (19EF_2BE4 / 0x1CAD4)
    Alu16.Sub(UInt16[DS, 0xB764], 0x3);
    CheckExternalEvents(cs14, 0x2BEB);
    // JNZ 0x1000:cadf (19EF_2BE9 / 0x1CAD9)
    if(!ZeroFlag) {
      goto label_19EF_2BEF_1CADF;
    }
    CheckExternalEvents(cs14, 0x2BED);
    // SHL AX,0x1 (19EF_2BEB / 0x1CADB)
    AX <<= 0x1;
    CheckExternalEvents(cs14, 0x2BEF);
    // SHL AX,0x1 (19EF_2BED / 0x1CADD)
    AX <<= 0x1;
    label_19EF_2BEF_1CADF:
    CheckExternalEvents(cs14, 0x2BF4);
    // CMP word ptr [0xb764],0x1 (19EF_2BEF / 0x1CADF)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs14, 0x2BF6);
    // JNZ 0x1000:cae8 (19EF_2BF4 / 0x1CAE4)
    if(!ZeroFlag) {
      goto label_19EF_2BF8_1CAE8;
    }
    CheckExternalEvents(cs14, 0x2BF8);
    // SHL AX,0x1 (19EF_2BF6 / 0x1CAE6)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    label_19EF_2BF8_1CAE8:
    CheckExternalEvents(cs14, 0x2BFB);
    // MOV [0xb79a],AX (19EF_2BF8 / 0x1CAE8)
    UInt16[DS, 0xB79A] = AX;
    CheckExternalEvents(cs14, 0x2BFE);
    // MOV AX,word ptr [BP + 0xc] (19EF_2BFB / 0x1CAEB)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x2C03);
    // CMP word ptr [0xb764],0x3 (19EF_2BFE / 0x1CAEE)
    Alu16.Sub(UInt16[DS, 0xB764], 0x3);
    CheckExternalEvents(cs14, 0x2C05);
    // JZ 0x1000:cb01 (19EF_2C03 / 0x1CAF3)
    if(ZeroFlag) {
      goto label_19EF_2C11_1CB01;
    }
    CheckExternalEvents(cs14, 0x2C0A);
    // CMP word ptr [0xb764],0x1 (19EF_2C05 / 0x1CAF5)
    Alu16.Sub(UInt16[DS, 0xB764], 0x1);
    CheckExternalEvents(cs14, 0x2C0C);
    // JZ 0x1000:cb38 (19EF_2C0A / 0x1CAFA)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_CB38_1CB38, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x2C0E);
    // JC 0x1000:cb71 (19EF_2C0C / 0x1CAFC)
    if(CarryFlag) {
      throw FailAsUntested("Would have been a goto but label label_19EF_2C81_1CB71 does not exist because no instruction was found there that belongs to a function.");
    }
    CheckExternalEvents(cs14, 0x2C11);
    // JMP 0x1000:cba0 (19EF_2C0E / 0x1CAFE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_CBA0_1CBA0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_2C11_1CB01:
    CheckExternalEvents(cs14, 0x2C13);
    // AND AL,0xf (19EF_2C11 / 0x1CB01)
    // AL &= 0xF;
    AL = Alu8.And(AL, 0xF);
    CheckExternalEvents(cs14, 0x2C15);
    // MOV DL,AL (19EF_2C13 / 0x1CB03)
    DL = AL;
    CheckExternalEvents(cs14, 0x2C17);
    // MOV DH,AL (19EF_2C15 / 0x1CB05)
    DH = AL;
    CheckExternalEvents(cs14, 0x2C1C);
    // CMP word ptr [0xb782],0x0 (19EF_2C17 / 0x1CB07)
    Alu16.Sub(UInt16[DS, 0xB782], 0x0);
    CheckExternalEvents(cs14, 0x2C1E);
    // JZ 0x1000:cb16 (19EF_2C1C / 0x1CB0C)
    if(ZeroFlag) {
      goto label_19EF_2C26_1CB16;
    }
    CheckExternalEvents(cs14, 0x2C20);
    // SHL DL,0x1 (19EF_2C1E / 0x1CB0E)
    DL <<= 0x1;
    CheckExternalEvents(cs14, 0x2C22);
    // SHL DL,0x1 (19EF_2C20 / 0x1CB10)
    DL <<= 0x1;
    CheckExternalEvents(cs14, 0x2C24);
    // SHL DL,0x1 (19EF_2C22 / 0x1CB12)
    DL <<= 0x1;
    CheckExternalEvents(cs14, 0x2C26);
    // SHL DL,0x1 (19EF_2C24 / 0x1CB14)
    // DL <<= 0x1;
    DL = Alu8.Shl(DL, 0x1);
    label_19EF_2C26_1CB16:
    CheckExternalEvents(cs14, 0x2C29);
    // MOV BX,0x140 (19EF_2C26 / 0x1CB16)
    BX = 0x140;
    CheckExternalEvents(cs14, 0x2C2D);
    // SUB BX,word ptr [0xb79a] (19EF_2C29 / 0x1CB19)
    BX -= UInt16[DS, 0xB79A];
    CheckExternalEvents(cs14, 0x2C31);
    // SUB BX,word ptr [0xb79a] (19EF_2C2D / 0x1CB1D)
    // BX -= UInt16[DS, 0xB79A];
    BX = Alu16.Sub(BX, UInt16[DS, 0xB79A]);
    CheckExternalEvents(cs14, 0x2C33);
    // MOV AL,0x8 (19EF_2C31 / 0x1CB21)
    AL = 0x8;
    label_19EF_2C33_1CB23:
    CheckExternalEvents(cs14, 0x2C37);
    // MOV CX,word ptr [0xb79a] (19EF_2C33 / 0x1CB23)
    CX = UInt16[DS, 0xB79A];
    label_19EF_2C37_1CB27:
    CheckExternalEvents(cs14, 0x2C3A);
    // XOR word ptr ES:[DI],DX (19EF_2C37 / 0x1CB27)
    UInt16[ES, (ushort)(DI)] ^= DX;
    CheckExternalEvents(cs14, 0x2C3D);
    // ADD DI,0x2 (19EF_2C3A / 0x1CB2A)
    // DI += 0x2;
    DI = Alu16.Add(DI, 0x2);
    CheckExternalEvents(cs14, 0x2C3F);
    // LOOP 0x1000:cb27 (19EF_2C3D / 0x1CB2D)
    if(--CX != 0) {
      goto label_19EF_2C37_1CB27;
    }
    CheckExternalEvents(cs14, 0x2C41);
    // ADD DI,BX (19EF_2C3F / 0x1CB2F)
    DI += BX;
    CheckExternalEvents(cs14, 0x2C43);
    // DEC AL (19EF_2C41 / 0x1CB31)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs14, 0x2C45);
    // JNZ 0x1000:cb23 (19EF_2C43 / 0x1CB33)
    if(!ZeroFlag) {
      goto label_19EF_2C33_1CB23;
    }
    CheckExternalEvents(cs14, 0x2C47);
    // JMP 0x1000:cb6b (19EF_2C45 / 0x1CB35)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_CB38_1CB38, 0x1CB6B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_CB38_1CB38(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1CB6B: goto label_1000_CB6B_1CB6B;break; // Target of external jump from 0x1CB35, 0x1CBCF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_CB38_1CB38:
    CheckExternalEvents(cs8, 0xCB3A);
    // MOV BL,AL (1000_CB38 / 0x1CB38)
    BL = AL;
    CheckExternalEvents(cs8, 0xCB3D);
    // MOV CX,0x4 (1000_CB3A / 0x1CB3A)
    CX = 0x4;
    CheckExternalEvents(cs8, 0xCB3F);
    // SHL AL,CL (1000_CB3D / 0x1CB3D)
    // AL <<= CL;
    AL = Alu8.Shl(AL, CL);
    CheckExternalEvents(cs8, 0xCB41);
    // OR AL,BL (1000_CB3F / 0x1CB3F)
    // AL |= BL;
    AL = Alu8.Or(AL, BL);
    CheckExternalEvents(cs8, 0xCB43);
    // MOV AH,AL (1000_CB41 / 0x1CB41)
    AH = AL;
    CheckExternalEvents(cs8, 0xCB45);
    // MOV DX,AX (1000_CB43 / 0x1CB43)
    DX = AX;
    CheckExternalEvents(cs8, 0xCB48);
    // MOV BX,0x2000 (1000_CB45 / 0x1CB45)
    BX = 0x2000;
    CheckExternalEvents(cs8, 0xCB4B);
    // MOV AX,[0xb79a] (1000_CB48 / 0x1CB48)
    AX = UInt16[DS, 0xB79A];
    CheckExternalEvents(cs8, 0xCB4D);
    // SHL AX,0x1 (1000_CB4B / 0x1CB4B)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0xCB4F);
    // SUB BX,AX (1000_CB4D / 0x1CB4D)
    // BX -= AX;
    BX = Alu16.Sub(BX, AX);
    CheckExternalEvents(cs8, 0xCB51);
    // MOV AL,0x4 (1000_CB4F / 0x1CB4F)
    AL = 0x4;
    label_1000_CB51_1CB51:
    CheckExternalEvents(cs8, 0xCB55);
    // MOV CX,word ptr [0xb79a] (1000_CB51 / 0x1CB51)
    CX = UInt16[DS, 0xB79A];
    label_1000_CB55_1CB55:
    CheckExternalEvents(cs8, 0xCB58);
    // XOR word ptr ES:[SI],DX (1000_CB55 / 0x1CB55)
    UInt16[ES, (ushort)(SI)] ^= DX;
    CheckExternalEvents(cs8, 0xCB5B);
    // XOR word ptr ES:[DI],DX (1000_CB58 / 0x1CB58)
    UInt16[ES, (ushort)(DI)] ^= DX;
    CheckExternalEvents(cs8, 0xCB5E);
    // ADD SI,0x2 (1000_CB5B / 0x1CB5B)
    SI += 0x2;
    CheckExternalEvents(cs8, 0xCB61);
    // ADD DI,0x2 (1000_CB5E / 0x1CB5E)
    // DI += 0x2;
    DI = Alu16.Add(DI, 0x2);
    CheckExternalEvents(cs8, 0xCB63);
    // LOOP 0x1000:cb55 (1000_CB61 / 0x1CB61)
    if(--CX != 0) {
      goto label_1000_CB55_1CB55;
    }
    CheckExternalEvents(cs8, 0xCB65);
    // ADD SI,BX (1000_CB63 / 0x1CB63)
    SI += BX;
    CheckExternalEvents(cs8, 0xCB67);
    // ADD DI,BX (1000_CB65 / 0x1CB65)
    DI += BX;
    CheckExternalEvents(cs8, 0xCB69);
    // DEC AL (1000_CB67 / 0x1CB67)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs8, 0xCB6B);
    // JNZ 0x1000:cb51 (1000_CB69 / 0x1CB69)
    if(!ZeroFlag) {
      goto label_1000_CB51_1CB51;
    }
    label_1000_CB6B_1CB6B:
    CheckExternalEvents(cs8, 0xCB6C);
    // POP ES (1000_CB6B / 0x1CB6B)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCB6D);
    // POP DS (1000_CB6C / 0x1CB6C)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCB6E);
    // POP SI (1000_CB6D / 0x1CB6D)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCB6F);
    // POP DI (1000_CB6E / 0x1CB6E)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCB70);
    // POP BP (1000_CB6F / 0x1CB6F)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCB71);
    // RETF  (1000_CB70 / 0x1CB70)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_CBA0_1CBA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CBA0_1CBA0:
    CheckExternalEvents(cs8, 0xCBA2);
    // MOV BL,AL (1000_CBA0 / 0x1CBA0)
    BL = AL;
    CheckExternalEvents(cs8, 0xCBA5);
    // MOV DX,0x3ce (1000_CBA2 / 0x1CBA2)
    DX = 0x3CE;
    CheckExternalEvents(cs8, 0xCBA8);
    // MOV AX,0x205 (1000_CBA5 / 0x1CBA5)
    AX = 0x205;
    CheckExternalEvents(cs8, 0xCBA9);
    // OUT DX,AX (1000_CBA8 / 0x1CBA8)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xCBAC);
    // MOV AX,0xff08 (1000_CBA9 / 0x1CBA9)
    AX = 0xFF08;
    CheckExternalEvents(cs8, 0xCBAD);
    // OUT DX,AX (1000_CBAC / 0x1CBAC)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xCBB0);
    // MOV AX,0x1803 (1000_CBAD / 0x1CBAD)
    AX = 0x1803;
    CheckExternalEvents(cs8, 0xCBB1);
    // OUT DX,AX (1000_CBB0 / 0x1CBB0)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xCBB3);
    // MOV BH,0x8 (1000_CBB1 / 0x1CBB1)
    BH = 0x8;
    label_1000_CBB3_1CBB3:
    CheckExternalEvents(cs8, 0xCBB7);
    // MOV CX,word ptr [0xb79a] (1000_CBB3 / 0x1CBB3)
    CX = UInt16[DS, 0xB79A];
    label_1000_CBB7_1CBB7:
    CheckExternalEvents(cs8, 0xCBBA);
    // MOV AL,byte ptr ES:[DI] (1000_CBB7 / 0x1CBB7)
    AL = UInt8[ES, (ushort)(DI)];
    CheckExternalEvents(cs8, 0xCBBD);
    // MOV byte ptr ES:[DI],BL (1000_CBBA / 0x1CBBA)
    UInt8[ES, (ushort)(DI)] = BL;
    CheckExternalEvents(cs8, 0xCBBE);
    // INC DI (1000_CBBD / 0x1CBBD)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs8, 0xCBC0);
    // LOOP 0x1000:cbb7 (1000_CBBE / 0x1CBBE)
    if(--CX != 0) {
      goto label_1000_CBB7_1CBB7;
    }
    CheckExternalEvents(cs8, 0xCBC3);
    // ADD DI,0x28 (1000_CBC0 / 0x1CBC0)
    DI += 0x28;
    CheckExternalEvents(cs8, 0xCBC7);
    // SUB DI,word ptr [0xb79a] (1000_CBC3 / 0x1CBC3)
    DI -= UInt16[DS, 0xB79A];
    CheckExternalEvents(cs8, 0xCBC9);
    // DEC BH (1000_CBC7 / 0x1CBC7)
    BH = Alu8.Dec(BH);
    CheckExternalEvents(cs8, 0xCBCB);
    // JNZ 0x1000:cbb3 (1000_CBC9 / 0x1CBC9)
    if(!ZeroFlag) {
      goto label_1000_CBB3_1CBB3;
    }
    CheckExternalEvents(cs8, 0xCBCE);
    // MOV AX,0x3 (1000_CBCB / 0x1CBCB)
    AX = 0x3;
    CheckExternalEvents(cs8, 0xCBCF);
    // OUT DX,AX (1000_CBCE / 0x1CBCE)
    Cpu.Out16(DX, AX);
    CheckExternalEvents(cs8, 0xCBD1);
    // JMP 0x1000:cb6b (1000_CBCF / 0x1CBCF)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_CB38_1CB38, 0x1CB6B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action unknown_19EF_2CE1_1CBD1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_2CE1_1CBD1:
    CheckExternalEvents(cs14, 0x2CE2);
    // PUSH BP (19EF_2CE1 / 0x1CBD1)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x2CE4);
    // MOV BP,SP (19EF_2CE2 / 0x1CBD2)
    BP = SP;
    CheckExternalEvents(cs14, 0x2CE5);
    // PUSH DI (19EF_2CE4 / 0x1CBD4)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x2CE6);
    // PUSH SI (19EF_2CE5 / 0x1CBD5)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x2CE7);
    // PUSH DS (19EF_2CE6 / 0x1CBD6)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2CEA);
    // MOV AX,0x1ddc (19EF_2CE7 / 0x1CBD7)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x2CEC);
    // MOV DS,AX (19EF_2CEA / 0x1CBDA)
    DS = AX;
    CheckExternalEvents(cs14, 0x2CEF);
    // MOV AX,word ptr [BP + 0x6] (19EF_2CEC / 0x1CBDC)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x2CF2);
    // MOV [0xb764],AX (19EF_2CEF / 0x1CBDF)
    UInt16[DS, 0xB764] = AX;
    CheckExternalEvents(cs14, 0x2CF3);
    // POP DS (19EF_2CF2 / 0x1CBE2)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2CF4);
    // POP SI (19EF_2CF3 / 0x1CBE3)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2CF5);
    // POP DI (19EF_2CF4 / 0x1CBE4)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2CF6);
    // POP BP (19EF_2CF5 / 0x1CBE5)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2CF7);
    // RETF  (19EF_2CF6 / 0x1CBE6)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_2CF7_1CBE7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_2CF7_1CBE7:
    CheckExternalEvents(cs14, 0x2CF8);
    // PUSH BP (19EF_2CF7 / 0x1CBE7)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x2CFA);
    // MOV BP,SP (19EF_2CF8 / 0x1CBE8)
    BP = SP;
    CheckExternalEvents(cs14, 0x2CFB);
    // PUSH DI (19EF_2CFA / 0x1CBEA)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x2CFC);
    // PUSH SI (19EF_2CFB / 0x1CBEB)
    Stack.Push16(SI);
    CheckExternalEvents(cs14, 0x2CFD);
    // PUSH DS (19EF_2CFC / 0x1CBEC)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x2D00);
    // MOV AX,0x1ddc (19EF_2CFD / 0x1CBED)
    AX = 0x1DDC;
    CheckExternalEvents(cs14, 0x2D02);
    // MOV DS,AX (19EF_2D00 / 0x1CBF0)
    DS = AX;
    CheckExternalEvents(cs14, 0x2D03);
    // PUSH ES (19EF_2D02 / 0x1CBF2)
    Stack.Push16(ES);
    CheckExternalEvents(cs14, 0x2D05);
    // MOV AX,DS (19EF_2D03 / 0x1CBF3)
    AX = DS;
    CheckExternalEvents(cs14, 0x2D07);
    // MOV ES,AX (19EF_2D05 / 0x1CBF5)
    ES = AX;
    CheckExternalEvents(cs14, 0x2D08);
    // CLD  (19EF_2D07 / 0x1CBF7)
    DirectionFlag = false;
    CheckExternalEvents(cs14, 0x2D0D);
    // CMP word ptr [0xb764],0x2 (19EF_2D08 / 0x1CBF8)
    Alu16.Sub(UInt16[DS, 0xB764], 0x2);
    CheckExternalEvents(cs14, 0x2D0F);
    // JNC 0x1000:cc4e (19EF_2D0D / 0x1CBFD)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_CC29_1CC29, 0x1CC4E - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x2D12);
    // MOV SI,0xa661 (19EF_2D0F / 0x1CBFF)
    SI = 0xA661;
    CheckExternalEvents(cs14, 0x2D16);
    // ADD SI,0x3ff (19EF_2D12 / 0x1CC02)
    // SI += 0x3FF;
    SI = Alu16.Add(SI, 0x3FF);
    CheckExternalEvents(cs14, 0x2D19);
    // MOV DI,0xa661 (19EF_2D16 / 0x1CC06)
    DI = 0xA661;
    CheckExternalEvents(cs14, 0x2D1E);
    // CMP word ptr [0xb764],0x0 (19EF_2D19 / 0x1CC09)
    Alu16.Sub(UInt16[DS, 0xB764], 0x0);
    CheckExternalEvents(cs14, 0x2D20);
    // JZ 0x1000:cc29 (19EF_2D1E / 0x1CC0E)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_CC29_1CC29, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x2D24);
    // ADD DI,0xffc (19EF_2D20 / 0x1CC10)
    // DI += 0xFFC;
    DI = Alu16.Add(DI, 0xFFC);
    label_19EF_2D24_1CC14:
    CheckExternalEvents(cs14, 0x2D26);
    // MOV BL,byte ptr [SI] (19EF_2D24 / 0x1CC14)
    BL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs14, 0x2D29);
    // CALL 0x1000:cc54 (19EF_2D26 / 0x1CC16)
    NearCall(cs14, 0x2D29, ghidra_guess_1000_CC54_1CC54);
    CheckExternalEvents(cs14, 0x2D2C);
    // CALL 0x1000:cc54 (19EF_2D29 / 0x1CC19)
    NearCall(cs14, 0x2D2C, ghidra_guess_1000_CC54_1CC54);
    CheckExternalEvents(cs14, 0x2D2F);
    // SUB DI,0x8 (19EF_2D2C / 0x1CC1C)
    DI -= 0x8;
    CheckExternalEvents(cs14, 0x2D30);
    // DEC SI (19EF_2D2F / 0x1CC1F)
    SI--;
    CheckExternalEvents(cs14, 0x2D34);
    // CMP SI,0xa661 (19EF_2D30 / 0x1CC20)
    Alu16.Sub(SI, 0xA661);
    CheckExternalEvents(cs14, 0x2D36);
    // JNZ 0x1000:cc14 (19EF_2D34 / 0x1CC24)
    if(!ZeroFlag) {
      goto label_19EF_2D24_1CC14;
    }
    CheckExternalEvents(cs14, 0x2D38);
    // JMP 0x1000:cc4e (19EF_2D36 / 0x1CC26)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_CC29_1CC29, 0x1CC4E - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_CC29_1CC29(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1CC4E: goto label_1000_CC4E_1CC4E;break; // Target of external jump from 0x1CBFD
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_CC29_1CC29:
    CheckExternalEvents(cs8, 0xCC2D);
    // ADD DI,0x7fe (1000_CC29 / 0x1CC29)
    // DI += 0x7FE;
    DI = Alu16.Add(DI, 0x7FE);
    label_1000_CC2D_1CC2D:
    CheckExternalEvents(cs8, 0xCC2F);
    // MOV BL,byte ptr [SI] (1000_CC2D / 0x1CC2D)
    BL = UInt8[DS, (ushort)(SI)];
    CheckExternalEvents(cs8, 0xCC32);
    // MOV CX,0x8 (1000_CC2F / 0x1CC2F)
    CX = 0x8;
    CheckExternalEvents(cs8, 0xCC34);
    // XOR AX,AX (1000_CC32 / 0x1CC32)
    AX = 0;
    label_1000_CC34_1CC34:
    CheckExternalEvents(cs8, 0xCC36);
    // SHL AX,0x1 (1000_CC34 / 0x1CC34)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0xCC38);
    // SHL AX,0x1 (1000_CC36 / 0x1CC36)
    AX <<= 0x1;
    CheckExternalEvents(cs8, 0xCC3A);
    // SHL BL,0x1 (1000_CC38 / 0x1CC38)
    // BL <<= 0x1;
    BL = Alu8.Shl(BL, 0x1);
    CheckExternalEvents(cs8, 0xCC3C);
    // JNC 0x1000:cc3e (1000_CC3A / 0x1CC3A)
    if(!CarryFlag) {
      goto label_1000_CC3E_1CC3E;
    }
    CheckExternalEvents(cs8, 0xCC3E);
    // OR AL,0x3 (1000_CC3C / 0x1CC3C)
    // AL |= 0x3;
    AL = Alu8.Or(AL, 0x3);
    label_1000_CC3E_1CC3E:
    CheckExternalEvents(cs8, 0xCC40);
    // LOOP 0x1000:cc34 (1000_CC3E / 0x1CC3E)
    if(--CX != 0) {
      goto label_1000_CC34_1CC34;
    }
    CheckExternalEvents(cs8, 0xCC42);
    // XCHG AL,AH (1000_CC40 / 0x1CC40)
    (AH, AL) = (AL, AH);
    CheckExternalEvents(cs8, 0xCC44);
    // MOV word ptr [DI],AX (1000_CC42 / 0x1CC42)
    UInt16[DS, (ushort)(DI)] = AX;
    CheckExternalEvents(cs8, 0xCC47);
    // SUB DI,0x2 (1000_CC44 / 0x1CC44)
    DI -= 0x2;
    CheckExternalEvents(cs8, 0xCC48);
    // DEC SI (1000_CC47 / 0x1CC47)
    SI--;
    CheckExternalEvents(cs8, 0xCC4C);
    // CMP SI,0xa661 (1000_CC48 / 0x1CC48)
    Alu16.Sub(SI, 0xA661);
    CheckExternalEvents(cs8, 0xCC4E);
    // JNZ 0x1000:cc2d (1000_CC4C / 0x1CC4C)
    if(!ZeroFlag) {
      goto label_1000_CC2D_1CC2D;
    }
    label_1000_CC4E_1CC4E:
    CheckExternalEvents(cs8, 0xCC4F);
    // POP ES (1000_CC4E / 0x1CC4E)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCC50);
    // POP DS (1000_CC4F / 0x1CC4F)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCC51);
    // POP SI (1000_CC50 / 0x1CC50)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCC52);
    // POP DI (1000_CC51 / 0x1CC51)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCC53);
    // POP BP (1000_CC52 / 0x1CC52)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCC54);
    // RETF  (1000_CC53 / 0x1CC53)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_CC54_1CC54(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CC54_1CC54:
    CheckExternalEvents(cs8, 0xCC56);
    // XOR AX,AX (1000_CC54 / 0x1CC54)
    AX = 0;
    CheckExternalEvents(cs8, 0xCC58);
    // SHL BL,0x1 (1000_CC56 / 0x1CC56)
    // BL <<= 0x1;
    BL = Alu8.Shl(BL, 0x1);
    CheckExternalEvents(cs8, 0xCC5A);
    // JNC 0x1000:cc5c (1000_CC58 / 0x1CC58)
    if(!CarryFlag) {
      goto label_1000_CC5C_1CC5C;
    }
    CheckExternalEvents(cs8, 0xCC5C);
    // OR AL,0xf0 (1000_CC5A / 0x1CC5A)
    AL |= 0xF0;
    label_1000_CC5C_1CC5C:
    CheckExternalEvents(cs8, 0xCC5E);
    // SHL BL,0x1 (1000_CC5C / 0x1CC5C)
    // BL <<= 0x1;
    BL = Alu8.Shl(BL, 0x1);
    CheckExternalEvents(cs8, 0xCC60);
    // JNC 0x1000:cc62 (1000_CC5E / 0x1CC5E)
    if(!CarryFlag) {
      goto label_1000_CC62_1CC62;
    }
    CheckExternalEvents(cs8, 0xCC62);
    // OR AL,0xf (1000_CC60 / 0x1CC60)
    AL |= 0xF;
    label_1000_CC62_1CC62:
    CheckExternalEvents(cs8, 0xCC64);
    // SHL BL,0x1 (1000_CC62 / 0x1CC62)
    // BL <<= 0x1;
    BL = Alu8.Shl(BL, 0x1);
    CheckExternalEvents(cs8, 0xCC66);
    // JNC 0x1000:cc69 (1000_CC64 / 0x1CC64)
    if(!CarryFlag) {
      goto label_1000_CC69_1CC69;
    }
    CheckExternalEvents(cs8, 0xCC69);
    // OR AH,0xf0 (1000_CC66 / 0x1CC66)
    AH |= 0xF0;
    label_1000_CC69_1CC69:
    CheckExternalEvents(cs8, 0xCC6B);
    // SHL BL,0x1 (1000_CC69 / 0x1CC69)
    // BL <<= 0x1;
    BL = Alu8.Shl(BL, 0x1);
    CheckExternalEvents(cs8, 0xCC6D);
    // JNC 0x1000:cc70 (1000_CC6B / 0x1CC6B)
    if(!CarryFlag) {
      goto label_1000_CC70_1CC70;
    }
    CheckExternalEvents(cs8, 0xCC70);
    // OR AH,0xf (1000_CC6D / 0x1CC6D)
    // AH |= 0xF;
    AH = Alu8.Or(AH, 0xF);
    label_1000_CC70_1CC70:
    CheckExternalEvents(cs8, 0xCC71);
    // STOSW ES:DI (1000_CC70 / 0x1CC70)
    UInt16[ES, (ushort)(DI)] = AX;
    DI = (ushort)(DI + Direction16);
    CheckExternalEvents(cs8, 0xCC72);
    // RET  (1000_CC71 / 0x1CC71)
    return NearRet();
  }
  
  public virtual Action entry_19EF_2D82_1CC72(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1CCFB: goto label_19EF_2E0B_1CCFB;break; // Target of external jump from 0x1D0B9
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_19EF_2D82_1CC72:
    CheckExternalEvents(cs14, 0x2D84);
    // MOV AH,0x30 (19EF_2D82 / 0x1CC72)
    AH = 0x30;
    CheckExternalEvents(cs14, 0x2D86);
    // INT 0x21 (19EF_2D84 / 0x1CC74)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x2D88);
    // CMP AL,0x2 (19EF_2D86 / 0x1CC76)
    Alu8.Sub(AL, 0x2);
    CheckExternalEvents(cs14, 0x2D8A);
    // JNC 0x1000:cc7c (19EF_2D88 / 0x1CC78)
    if(!CarryFlag) {
      goto label_19EF_2D8C_1CC7C;
    }
    CheckExternalEvents(cs14, 0x2D8C);
    // INT 0x20 (19EF_2D8A / 0x1CC7A)
    Interrupt(0x20);
    label_19EF_2D8C_1CC7C:
    CheckExternalEvents(cs14, 0x2D8F);
    // MOV DI,0x384b (19EF_2D8C / 0x1CC7C)
    DI = 0x384B;
    CheckExternalEvents(cs14, 0x2D93);
    // MOV SI,word ptr [0x2] (19EF_2D8F / 0x1CC7F)
    SI = UInt16[DS, 0x2];
    CheckExternalEvents(cs14, 0x2D95);
    // SUB SI,DI (19EF_2D93 / 0x1CC83)
    SI -= DI;
    CheckExternalEvents(cs14, 0x2D99);
    // CMP SI,0x1000 (19EF_2D95 / 0x1CC85)
    Alu16.Sub(SI, 0x1000);
    CheckExternalEvents(cs14, 0x2D9B);
    // JC 0x1000:cc8e (19EF_2D99 / 0x1CC89)
    if(CarryFlag) {
      goto label_19EF_2D9E_1CC8E;
    }
    CheckExternalEvents(cs14, 0x2D9E);
    // MOV SI,0x1000 (19EF_2D9B / 0x1CC8B)
    SI = 0x1000;
    label_19EF_2D9E_1CC8E:
    CheckExternalEvents(cs14, 0x2D9F);
    // CLI  (19EF_2D9E / 0x1CC8E)
    InterruptFlag = false;
    CheckExternalEvents(cs14, 0x2DA1);
    // MOV SS,DI (19EF_2D9F / 0x1CC8F)
    SS = DI;
    CheckExternalEvents(cs14, 0x2DA5);
    // ADD SP,0x582e (19EF_2DA1 / 0x1CC91)
    // SP += 0x582E;
    SP = Alu16.Add(SP, 0x582E);
    CheckExternalEvents(cs14, 0x2DA6);
    // STI  (19EF_2DA5 / 0x1CC95)
    InterruptFlag = true;
    CheckExternalEvents(cs14, 0x2DA8);
    // JNC 0x1000:ccac (19EF_2DA6 / 0x1CC96)
    if(!CarryFlag) {
      goto label_19EF_2DBC_1CCAC;
    }
    CheckExternalEvents(cs14, 0x2DA9);
    // PUSH SS (19EF_2DA8 / 0x1CC98)
    Stack.Push16(SS);
    CheckExternalEvents(cs14, 0x2DAA);
    // POP DS (19EF_2DA9 / 0x1CC99)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2DAF);
    // CALLF 0x1000:cea2 (19EF_2DAA / 0x1CC9A)
    FarCall(cs14, 0x2DAF, ghidra_guess_1000_CEA2_1CEA2);
    CheckExternalEvents(cs14, 0x2DB1);
    // XOR AX,AX (19EF_2DAF / 0x1CC9F)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs14, 0x2DB2);
    // PUSH AX (19EF_2DB1 / 0x1CCA1)
    Stack.Push16(AX);
    CheckExternalEvents(cs14, 0x2DB7);
    // CALLF 0x1000:d165 (19EF_2DB2 / 0x1CCA2)
    FarCall(cs14, 0x2DB7, ghidra_guess_1000_D165_1D165);
    CheckExternalEvents(cs14, 0x2DBA);
    // MOV AX,0x4cff (19EF_2DB7 / 0x1CCA7)
    AX = 0x4CFF;
    CheckExternalEvents(cs14, 0x2DBC);
    // INT 0x21 (19EF_2DBA / 0x1CCAA)
    Interrupt(0x21);
    label_19EF_2DBC_1CCAC:
    CheckExternalEvents(cs14, 0x2DBF);
    // AND SP,0xfffe (19EF_2DBC / 0x1CCAC)
    // SP &= 0xFFFE;
    SP = Alu16.And(SP, 0xFFFE);
    CheckExternalEvents(cs14, 0x2DC4);
    // MOV word ptr SS:[0x5286],SP (19EF_2DBF / 0x1CCAF)
    UInt16[SS, 0x5286] = SP;
    CheckExternalEvents(cs14, 0x2DC9);
    // MOV word ptr SS:[0x5282],SP (19EF_2DC4 / 0x1CCB4)
    UInt16[SS, 0x5282] = SP;
    CheckExternalEvents(cs14, 0x2DCB);
    // MOV AX,SI (19EF_2DC9 / 0x1CCB9)
    AX = SI;
    CheckExternalEvents(cs14, 0x2DCD);
    // MOV CL,0x4 (19EF_2DCB / 0x1CCBB)
    CL = 0x4;
    CheckExternalEvents(cs14, 0x2DCF);
    // SHL AX,CL (19EF_2DCD / 0x1CCBD)
    AX <<= CL;
    CheckExternalEvents(cs14, 0x2DD0);
    // DEC AX (19EF_2DCF / 0x1CCBF)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs14, 0x2DD4);
    // MOV SS:[0x5280],AX (19EF_2DD0 / 0x1CCC0)
    UInt16[SS, 0x5280] = AX;
    CheckExternalEvents(cs14, 0x2DD6);
    // ADD SI,DI (19EF_2DD4 / 0x1CCC4)
    // SI += DI;
    SI = Alu16.Add(SI, DI);
    CheckExternalEvents(cs14, 0x2DDA);
    // MOV word ptr [0x2],SI (19EF_2DD6 / 0x1CCC6)
    UInt16[DS, 0x2] = SI;
    CheckExternalEvents(cs14, 0x2DDC);
    // MOV BX,ES (19EF_2DDA / 0x1CCCA)
    BX = ES;
    CheckExternalEvents(cs14, 0x2DDE);
    // SUB BX,SI (19EF_2DDC / 0x1CCCC)
    BX -= SI;
    CheckExternalEvents(cs14, 0x2DE0);
    // NEG BX (19EF_2DDE / 0x1CCCE)
    BX = Alu16.Sub(0, BX);
    CheckExternalEvents(cs14, 0x2DE2);
    // MOV AH,0x4a (19EF_2DE0 / 0x1CCD0)
    AH = 0x4A;
    CheckExternalEvents(cs14, 0x2DE4);
    // INT 0x21 (19EF_2DE2 / 0x1CCD2)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x2DE9);
    // MOV word ptr SS:[0x52f7],DS (19EF_2DE4 / 0x1CCD4)
    UInt16[SS, 0x52F7] = DS;
    CheckExternalEvents(cs14, 0x2DEA);
    // PUSH SS (19EF_2DE9 / 0x1CCD9)
    Stack.Push16(SS);
    CheckExternalEvents(cs14, 0x2DEB);
    // POP ES (19EF_2DEA / 0x1CCDA)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2DEC);
    // CLD  (19EF_2DEB / 0x1CCDB)
    DirectionFlag = false;
    CheckExternalEvents(cs14, 0x2DEF);
    // MOV DI,0x57fe (19EF_2DEC / 0x1CCDC)
    DI = 0x57FE;
    CheckExternalEvents(cs14, 0x2DF2);
    // MOV CX,0x5830 (19EF_2DEF / 0x1CCDF)
    CX = 0x5830;
    CheckExternalEvents(cs14, 0x2DF4);
    // SUB CX,DI (19EF_2DF2 / 0x1CCE2)
    CX -= DI;
    CheckExternalEvents(cs14, 0x2DF6);
    // XOR AX,AX (19EF_2DF4 / 0x1CCE4)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs14, 0x2DF8);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (19EF_2DF6 / 0x1CCE6)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs14, 0x2DF9);
    // PUSH SS (19EF_2DF8 / 0x1CCE8)
    Stack.Push16(SS);
    CheckExternalEvents(cs14, 0x2DFA);
    // POP DS (19EF_2DF9 / 0x1CCE9)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2DFF);
    // CALLF 0x1000:cd40 (19EF_2DFA / 0x1CCEA)
    throw FailAsUntested("Could not find a valid function at address 19EF_2E50 / 0x1CD40");
    CheckExternalEvents(cs14, 0x2E00);
    // PUSH SS (19EF_2DFF / 0x1CCEF)
    Stack.Push16(SS);
    CheckExternalEvents(cs14, 0x2E01);
    // POP DS (19EF_2E00 / 0x1CCF0)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2E06);
    // CALLF 0x1000:d0be (19EF_2E01 / 0x1CCF1)
    FarCall(cs14, 0x2E06, unknown_19EF_31CE_1D0BE);
    CheckExternalEvents(cs14, 0x2E0B);
    // CALLF 0x1000:cf16 (19EF_2E06 / 0x1CCF6)
    FarCall(cs14, 0x2E0B, unknown_19EF_3026_1CF16);
    label_19EF_2E0B_1CCFB:
    CheckExternalEvents(cs14, 0x2E0D);
    // XOR BP,BP (19EF_2E0B / 0x1CCFB)
    // BP ^= BP;
    BP = Alu16.Xor(BP, BP);
    CheckExternalEvents(cs14, 0x2E11);
    // PUSH word ptr [0x531c] (19EF_2E0D / 0x1CCFD)
    Stack.Push16(UInt16[DS, 0x531C]);
    CheckExternalEvents(cs14, 0x2E15);
    // PUSH word ptr [0x531a] (19EF_2E11 / 0x1CD01)
    Stack.Push16(UInt16[DS, 0x531A]);
    CheckExternalEvents(cs14, 0x2E19);
    // PUSH word ptr [0x5318] (19EF_2E15 / 0x1CD05)
    Stack.Push16(UInt16[DS, 0x5318]);
    CheckExternalEvents(cs14, 0x2E1D);
    // PUSH word ptr [0x5316] (19EF_2E19 / 0x1CD09)
    Stack.Push16(UInt16[DS, 0x5316]);
    CheckExternalEvents(cs14, 0x2E21);
    // PUSH word ptr [0x5314] (19EF_2E1D / 0x1CD0D)
    Stack.Push16(UInt16[DS, 0x5314]);
    CheckExternalEvents(cs14, 0x2E26);
    // CALLF 0x0000:69b4 (19EF_2E21 / 0x1CD11)
    FarCall(cs14, 0x2E26, unknown_0697_0044_069B4);
    CheckExternalEvents(cs14, 0x2E27);
    // PUSH AX (19EF_2E26 / 0x1CD16)
    Stack.Push16(AX);
    CheckExternalEvents(cs14, 0x2E2C);
    // CALLF 0x1000:ce04 (19EF_2E27 / 0x1CD17)
    FarCall(cs14, 0x2E2C, ghidra_guess_1000_CE04_1CE04);
    CheckExternalEvents(cs14, 0x2E2F);
    // MOV AX,0x384b (19EF_2E2C / 0x1CD1C)
    AX = 0x384B;
    CheckExternalEvents(cs14, 0x2E31);
    // MOV DS,AX (19EF_2E2F / 0x1CD1F)
    DS = AX;
    CheckExternalEvents(cs14, 0x2E34);
    // MOV AX,0x3 (19EF_2E31 / 0x1CD21)
    AX = 0x3;
    CheckExternalEvents(cs14, 0x2E3B);
    // MOV word ptr SS:[0x5284],0x2f14 (19EF_2E34 / 0x1CD24)
    UInt16[SS, 0x5284] = 0x2F14;
    label_19EF_2E3B_1CD2B:
    CheckExternalEvents(cs14, 0x2E3C);
    // PUSH AX (19EF_2E3B / 0x1CD2B)
    Stack.Push16(AX);
    CheckExternalEvents(cs14, 0x2E41);
    // CALLF 0x1000:cea2 (19EF_2E3C / 0x1CD2C)
    FarCall(cs14, 0x2E41, ghidra_guess_1000_CEA2_1CEA2);
    CheckExternalEvents(cs14, 0x2E46);
    // CALLF 0x1000:d165 (19EF_2E41 / 0x1CD31)
    FarCall(cs14, 0x2E46, ghidra_guess_1000_D165_1D165);
    CheckExternalEvents(cs14, 0x2E49);
    // MOV AX,0xff (19EF_2E46 / 0x1CD36)
    AX = 0xFF;
    CheckExternalEvents(cs14, 0x2E4A);
    // PUSH AX (19EF_2E49 / 0x1CD39)
    Stack.Push16(AX);
    CheckExternalEvents(cs14, 0x2E4B);
    // PUSH CS (19EF_2E4A / 0x1CD3A)
    Stack.Push16(cs14);
    CheckExternalEvents(cs14, 0x2E4F);
    // CALL word ptr [0x5284] (19EF_2E4B / 0x1CD3B)
    // Indirect call to word ptr [0x5284], generating possible targets from emulator records
    uint targetAddress_19EF_2E4B = (uint)(cs14 * 0x10 + UInt16[DS, 0x5284] - cs1 * 0x10);
    switch(targetAddress_19EF_2E4B) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_19EF_2E4B));
        break;
    }
    CheckExternalEvents(cs14, 0x2E53);
    // ADD byte ptr [SI + 0xcd30],DH (19EF_2E4F / 0x1CD3F)
    // UInt8[DS, (ushort)(SI + 0xCD30)] += DH;
    UInt8[DS, (ushort)(SI + 0xCD30)] = Alu8.Add(UInt8[DS, (ushort)(SI + 0xCD30)], DH);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action ghidra_guess_1000_CE04_1CE04(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE04_1CE04:
    CheckExternalEvents(cs8, 0xCE05);
    // PUSH BP (1000_CE04 / 0x1CE04)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xCE07);
    // MOV BP,SP (1000_CE05 / 0x1CE05)
    BP = SP;
    CheckExternalEvents(cs8, 0xCE0A);
    // MOV SI,0x582a (1000_CE07 / 0x1CE07)
    SI = 0x582A;
    CheckExternalEvents(cs8, 0xCE0D);
    // MOV DI,0x582a (1000_CE0A / 0x1CE0A)
    DI = 0x582A;
    CheckExternalEvents(cs8, 0xCE10);
    // CALL 0x1000:ce8f (1000_CE0D / 0x1CE0D)
    NearCall(cs8, 0xCE10, unknown_19EF_2F9F_1CE8F);
    CheckExternalEvents(cs8, 0xCE13);
    // MOV SI,0x5384 (1000_CE10 / 0x1CE10)
    SI = 0x5384;
    CheckExternalEvents(cs8, 0xCE16);
    // MOV DI,0x5384 (1000_CE13 / 0x1CE13)
    DI = 0x5384;
    CheckExternalEvents(cs8, 0xCE19);
    // CALL 0x1000:ce8f (1000_CE16 / 0x1CE16)
    NearCall(cs8, 0xCE19, unknown_19EF_2F9F_1CE8F);
    CheckExternalEvents(cs8, 0xCE1B);
    // JMP 0x1000:ce1e (1000_CE19 / 0x1CE19)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_CE1E_1CE1E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_CE1E_1CE1E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE1E_1CE1E:
    CheckExternalEvents(cs8, 0xCE21);
    // MOV SI,0x5384 (1000_CE1E / 0x1CE1E)
    SI = 0x5384;
    CheckExternalEvents(cs8, 0xCE24);
    // MOV DI,0x5384 (1000_CE21 / 0x1CE21)
    DI = 0x5384;
    CheckExternalEvents(cs8, 0xCE27);
    // CALL 0x1000:ce8f (1000_CE24 / 0x1CE24)
    NearCall(cs8, 0xCE27, unknown_19EF_2F9F_1CE8F);
    CheckExternalEvents(cs8, 0xCE2A);
    // MOV SI,0x5384 (1000_CE27 / 0x1CE27)
    SI = 0x5384;
    CheckExternalEvents(cs8, 0xCE2D);
    // MOV DI,0x5384 (1000_CE2A / 0x1CE2A)
    DI = 0x5384;
    CheckExternalEvents(cs8, 0xCE30);
    // CALL 0x1000:ce8f (1000_CE2D / 0x1CE2D)
    NearCall(cs8, 0xCE30, unknown_19EF_2F9F_1CE8F);
    CheckExternalEvents(cs8, 0xCE35);
    // CALLF 0x1000:cef0 (1000_CE30 / 0x1CE30)
    FarCall(cs8, 0xCE35, ghidra_guess_1000_CEF0_1CEF0);
    CheckExternalEvents(cs8, 0xCE37);
    // OR AX,AX (1000_CE35 / 0x1CE35)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs8, 0xCE39);
    // JZ 0x1000:ce44 (1000_CE37 / 0x1CE37)
    if(ZeroFlag) {
      goto label_1000_CE44_1CE44;
    }
    CheckExternalEvents(cs8, 0xCE3D);
    // CMP word ptr [BP + 0x6],0x0 (1000_CE39 / 0x1CE39)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs8, 0xCE3F);
    // JNZ 0x1000:ce44 (1000_CE3D / 0x1CE3D)
    if(!ZeroFlag) {
      goto label_1000_CE44_1CE44;
    }
    CheckExternalEvents(cs8, 0xCE44);
    // MOV word ptr [BP + 0x6],0xff (1000_CE3F / 0x1CE3F)
    UInt16[SS, (ushort)(BP + 0x6)] = 0xFF;
    label_1000_CE44_1CE44:
    CheckExternalEvents(cs8, 0xCE47);
    // MOV CX,0xf (1000_CE44 / 0x1CE44)
    CX = 0xF;
    CheckExternalEvents(cs8, 0xCE4A);
    // MOV BX,0x5 (1000_CE47 / 0x1CE47)
    BX = 0x5;
    label_1000_CE4A_1CE4A:
    CheckExternalEvents(cs8, 0xCE4F);
    // TEST byte ptr [BX + 0x5300],0x1 (1000_CE4A / 0x1CE4A)
    Alu8.And(UInt8[DS, (ushort)(BX + 0x5300)], 0x1);
    CheckExternalEvents(cs8, 0xCE51);
    // JZ 0x1000:ce55 (1000_CE4F / 0x1CE4F)
    if(ZeroFlag) {
      goto label_1000_CE55_1CE55;
    }
    CheckExternalEvents(cs8, 0xCE53);
    // MOV AH,0x3e (1000_CE51 / 0x1CE51)
    AH = 0x3E;
    CheckExternalEvents(cs8, 0xCE55);
    // INT 0x21 (1000_CE53 / 0x1CE53)
    Interrupt(0x21);
    label_1000_CE55_1CE55:
    CheckExternalEvents(cs8, 0xCE56);
    // INC BX (1000_CE55 / 0x1CE55)
    BX = Alu16.Inc(BX);
    CheckExternalEvents(cs8, 0xCE58);
    // LOOP 0x1000:ce4a (1000_CE56 / 0x1CE56)
    if(--CX != 0) {
      goto label_1000_CE4A_1CE4A;
    }
    CheckExternalEvents(cs8, 0xCE5B);
    // CALL 0x1000:ce62 (1000_CE58 / 0x1CE58)
    NearCall(cs8, 0xCE5B, ghidra_guess_1000_CE62_1CE62);
    CheckExternalEvents(cs8, 0xCE5E);
    // MOV AX,word ptr [BP + 0x6] (1000_CE5B / 0x1CE5B)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xCE60);
    // MOV AH,0x4c (1000_CE5E / 0x1CE5E)
    AH = 0x4C;
    CheckExternalEvents(cs8, 0xCE62);
    // INT 0x21 (1000_CE60 / 0x1CE60)
    Interrupt(0x21);
    // Function call generated as ASM continues to next function entry point without return
    return ghidra_guess_1000_CE62_1CE62(0);
  }
  
  public virtual Action ghidra_guess_1000_CE62_1CE62(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CE62_1CE62:
    CheckExternalEvents(cs8, 0xCE66);
    // MOV CX,word ptr [0x537a] (1000_CE62 / 0x1CE62)
    CX = UInt16[DS, 0x537A];
    CheckExternalEvents(cs8, 0xCE68);
    // JCXZ 0x1000:ce6f (1000_CE66 / 0x1CE66)
    if(CX == 0) {
      goto label_1000_CE6F_1CE6F;
    }
    CheckExternalEvents(cs8, 0xCE6B);
    // MOV BX,0x2 (1000_CE68 / 0x1CE68)
    BX = 0x2;
    CheckExternalEvents(cs8, 0xCE6F);
    // CALLF [0x5378] (1000_CE6B / 0x1CE6B)
    // Indirect call to [0x5378], generating possible targets from emulator records
    uint targetAddress_1000_CE6B = (uint)(UInt16[DS, 0x537A] * 0x10 + UInt16[DS, 0x5378] - cs1 * 0x10);
    switch(targetAddress_1000_CE6B) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CE6B));
        break;
    }
    label_1000_CE6F_1CE6F:
    CheckExternalEvents(cs8, 0xCE70);
    // PUSH DS (1000_CE6F / 0x1CE6F)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xCE74);
    // LDS DX,[0x52e5] (1000_CE70 / 0x1CE70)
    DX = UInt16[DS, 0x52E5];
    DS = UInt16[DS, 0x52E7];
    CheckExternalEvents(cs8, 0xCE77);
    // MOV AX,0x2500 (1000_CE74 / 0x1CE74)
    AX = 0x2500;
    CheckExternalEvents(cs8, 0xCE79);
    // INT 0x21 (1000_CE77 / 0x1CE77)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xCE7A);
    // POP DS (1000_CE79 / 0x1CE79)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCE7F);
    // CMP byte ptr [0x5326],0x0 (1000_CE7A / 0x1CE7A)
    Alu8.Sub(UInt8[DS, 0x5326], 0x0);
    CheckExternalEvents(cs8, 0xCE81);
    // JZ 0x1000:ce8e (1000_CE7F / 0x1CE7F)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      CheckExternalEvents(cs8, 0xCE8F);
      // RET  (1000_CE8E / 0x1CE8E)
      return NearRet();
    }
    CheckExternalEvents(cs8, 0xCE82);
    // PUSH DS (1000_CE81 / 0x1CE81)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xCE85);
    // MOV AL,[0x5327] (1000_CE82 / 0x1CE82)
    AL = UInt8[DS, 0x5327];
    CheckExternalEvents(cs8, 0xCE89);
    // LDS DX,[0x5328] (1000_CE85 / 0x1CE85)
    DX = UInt16[DS, 0x5328];
    DS = UInt16[DS, 0x532A];
    CheckExternalEvents(cs8, 0xCE8B);
    // MOV AH,0x25 (1000_CE89 / 0x1CE89)
    AH = 0x25;
    CheckExternalEvents(cs8, 0xCE8D);
    // INT 0x21 (1000_CE8B / 0x1CE8B)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xCE8E);
    // POP DS (1000_CE8D / 0x1CE8D)
    DS = Stack.Pop16();;
    label_1000_CE8E_1CE8E:
    CheckExternalEvents(cs8, 0xCE8F);
    // RET  (1000_CE8E / 0x1CE8E)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_2F9F_1CE8F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_2F9F_1CE8F:
    CheckExternalEvents(cs14, 0x2FA1);
    // CMP SI,DI (19EF_2F9F / 0x1CE8F)
    Alu16.Sub(SI, DI);
    CheckExternalEvents(cs14, 0x2FA3);
    // JNC 0x1000:cea1 (19EF_2FA1 / 0x1CE91)
    if(!CarryFlag) {
      // JNC target is RET, inlining.
      CheckExternalEvents(cs14, 0x2FB2);
      // RET  (19EF_2FB1 / 0x1CEA1)
      return NearRet();
    }
    CheckExternalEvents(cs14, 0x2FA6);
    // SUB DI,0x4 (19EF_2FA3 / 0x1CE93)
    // DI -= 0x4;
    DI = Alu16.Sub(DI, 0x4);
    CheckExternalEvents(cs14, 0x2FA8);
    // MOV AX,word ptr [DI] (19EF_2FA6 / 0x1CE96)
    AX = UInt16[DS, (ushort)(DI)];
    CheckExternalEvents(cs14, 0x2FAB);
    // OR AX,word ptr [DI + 0x2] (19EF_2FA8 / 0x1CE98)
    // AX |= UInt16[DS, (ushort)(DI + 0x2)];
    AX = Alu16.Or(AX, UInt16[DS, (ushort)(DI + 0x2)]);
    CheckExternalEvents(cs14, 0x2FAD);
    // JZ 0x1000:ce8f (19EF_2FAB / 0x1CE9B)
    if(ZeroFlag) {
      goto label_19EF_2F9F_1CE8F;
    }
    CheckExternalEvents(cs14, 0x2FAF);
    // CALLF [DI] (19EF_2FAD / 0x1CE9D)
    // Indirect call to [DI], generating possible targets from emulator records
    uint targetAddress_19EF_2FAD = (uint)(UInt16[DS, (ushort)(DI + 2)] * 0x10 + UInt16[DS, (ushort)(DI)] - cs1 * 0x10);
    switch(targetAddress_19EF_2FAD) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_19EF_2FAD));
        break;
    }
    CheckExternalEvents(cs14, 0x2FB1);
    // JMP 0x1000:ce8f (19EF_2FAF / 0x1CE9F)
    goto label_19EF_2F9F_1CE8F;
    label_19EF_2FB1_1CEA1:
    CheckExternalEvents(cs14, 0x2FB2);
    // RET  (19EF_2FB1 / 0x1CEA1)
    return NearRet();
  }
  
  public virtual Action ghidra_guess_1000_CEA2_1CEA2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CEA2_1CEA2:
    CheckExternalEvents(cs8, 0xCEA3);
    // PUSH BP (1000_CEA2 / 0x1CEA2)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xCEA5);
    // MOV BP,SP (1000_CEA3 / 0x1CEA3)
    BP = SP;
    CheckExternalEvents(cs8, 0xCEA8);
    // MOV AX,0xfc (1000_CEA5 / 0x1CEA5)
    AX = 0xFC;
    CheckExternalEvents(cs8, 0xCEA9);
    // PUSH AX (1000_CEA8 / 0x1CEA8)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0xCEAE);
    // CALLF 0x1000:d165 (1000_CEA9 / 0x1CEA9)
    FarCall(cs8, 0xCEAE, ghidra_guess_1000_D165_1D165);
    CheckExternalEvents(cs8, 0xCEB3);
    // CMP word ptr [0x532e],0x0 (1000_CEAE / 0x1CEAE)
    Alu16.Sub(UInt16[DS, 0x532E], 0x0);
    CheckExternalEvents(cs8, 0xCEB5);
    // JZ 0x1000:ceb9 (1000_CEB3 / 0x1CEB3)
    if(ZeroFlag) {
      goto label_1000_CEB9_1CEB9;
    }
    CheckExternalEvents(cs8, 0xCEB9);
    // CALLF [0x532c] (1000_CEB5 / 0x1CEB5)
    // Indirect call to [0x532c], generating possible targets from emulator records
    uint targetAddress_1000_CEB5 = (uint)(UInt16[DS, 0x532E] * 0x10 + UInt16[DS, 0x532C] - cs1 * 0x10);
    switch(targetAddress_1000_CEB5) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_CEB5));
        break;
    }
    label_1000_CEB9_1CEB9:
    CheckExternalEvents(cs8, 0xCEBC);
    // MOV AX,0xff (1000_CEB9 / 0x1CEB9)
    AX = 0xFF;
    CheckExternalEvents(cs8, 0xCEBD);
    // PUSH AX (1000_CEBC / 0x1CEBC)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0xCEC2);
    // CALLF 0x1000:d165 (1000_CEBD / 0x1CEBD)
    FarCall(cs8, 0xCEC2, ghidra_guess_1000_D165_1D165);
    CheckExternalEvents(cs8, 0xCEC4);
    // MOV SP,BP (1000_CEC2 / 0x1CEC2)
    SP = BP;
    CheckExternalEvents(cs8, 0xCEC5);
    // POP BP (1000_CEC4 / 0x1CEC4)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCEC6);
    // RETF  (1000_CEC5 / 0x1CEC5)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_CEC6_1CEC6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CEC6_1CEC6:
    CheckExternalEvents(cs8, 0xCEC9);
    // MOV AX,0x2 (1000_CEC6 / 0x1CEC6)
    AX = 0x2;
    CheckExternalEvents(cs8, 0xCECC);
    // JMP 0x1000:cd2b (1000_CEC9 / 0x1CEC9)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(entry_19EF_2D82_1CC72, 0x1CD2B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action unknown_19EF_2FDC_1CECC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_2FDC_1CECC:
    CheckExternalEvents(cs14, 0x2FDD);
    // POP CX (19EF_2FDC / 0x1CECC)
    CX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2FDE);
    // POP DX (19EF_2FDD / 0x1CECD)
    DX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x2FE0);
    // MOV BX,SP (19EF_2FDE / 0x1CECE)
    BX = SP;
    CheckExternalEvents(cs14, 0x2FE2);
    // SUB BX,AX (19EF_2FE0 / 0x1CED0)
    // BX -= AX;
    BX = Alu16.Sub(BX, AX);
    CheckExternalEvents(cs14, 0x2FE4);
    // JC 0x1000:cedf (19EF_2FE2 / 0x1CED2)
    if(CarryFlag) {
      goto label_19EF_2FEF_1CEDF;
    }
    CheckExternalEvents(cs14, 0x2FE8);
    // CMP BX,word ptr [0x5334] (19EF_2FE4 / 0x1CED4)
    Alu16.Sub(BX, UInt16[DS, 0x5334]);
    CheckExternalEvents(cs14, 0x2FEA);
    // JC 0x1000:cedf (19EF_2FE8 / 0x1CED8)
    if(CarryFlag) {
      goto label_19EF_2FEF_1CEDF;
    }
    CheckExternalEvents(cs14, 0x2FEC);
    // MOV SP,BX (19EF_2FEA / 0x1CEDA)
    SP = BX;
    CheckExternalEvents(cs14, 0x2FED);
    // PUSH DX (19EF_2FEC / 0x1CEDC)
    Stack.Push16(DX);
    CheckExternalEvents(cs14, 0x2FEE);
    // PUSH CX (19EF_2FED / 0x1CEDD)
    Stack.Push16(CX);
    CheckExternalEvents(cs14, 0x2FEF);
    // RETF  (19EF_2FEE / 0x1CEDE)
    return FarRet();
    label_19EF_2FEF_1CEDF:
    CheckExternalEvents(cs14, 0x2FF2);
    // MOV AX,[0x5330] (19EF_2FEF / 0x1CEDF)
    AX = UInt16[DS, 0x5330];
    CheckExternalEvents(cs14, 0x2FF3);
    // INC AX (19EF_2FF2 / 0x1CEE2)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs14, 0x2FF5);
    // JNZ 0x1000:ceea (19EF_2FF3 / 0x1CEE3)
    if(!ZeroFlag) {
      goto label_19EF_2FFA_1CEEA;
    }
    CheckExternalEvents(cs14, 0x2FF7);
    // XOR AX,AX (19EF_2FF5 / 0x1CEE5)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs14, 0x2FFA);
    // JMP 0x1000:cd2b (19EF_2FF7 / 0x1CEE7)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(entry_19EF_2D82_1CC72, 0x1CD2B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_2FFA_1CEEA:
    CheckExternalEvents(cs14, 0x2FFB);
    // PUSH DX (19EF_2FFA / 0x1CEEA)
    Stack.Push16(DX);
    CheckExternalEvents(cs14, 0x2FFC);
    // PUSH CX (19EF_2FFB / 0x1CEEB)
    Stack.Push16(CX);
    CheckExternalEvents(cs14, 0x3000);
    // JMPF [0x5330] (19EF_2FFC / 0x1CEEC)
    // Indirect jump to [0x5330], generating possible targets from emulator records
    uint targetAddress_19EF_2FFC = (uint)(UInt16[DS, 0x5332] * 0x10 + UInt16[DS, 0x5330] - cs1 * 0x10);
    switch(targetAddress_19EF_2FFC) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_19EF_2FFC));
        break;
    }
    // Function call generated as ASM continues to next function entry point without return
    return ghidra_guess_1000_CEF0_1CEF0(0);
  }
  
  public virtual Action ghidra_guess_1000_CEF0_1CEF0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_CEF0_1CEF0:
    CheckExternalEvents(cs8, 0xCEF1);
    // PUSH SI (1000_CEF0 / 0x1CEF0)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xCEF3);
    // XOR SI,SI (1000_CEF1 / 0x1CEF1)
    // SI ^= SI;
    SI = Alu16.Xor(SI, SI);
    CheckExternalEvents(cs8, 0xCEF6);
    // MOV CX,0x42 (1000_CEF3 / 0x1CEF3)
    CX = 0x42;
    CheckExternalEvents(cs8, 0xCEF8);
    // XOR AH,AH (1000_CEF6 / 0x1CEF6)
    // AH ^= AH;
    AH = Alu8.Xor(AH, AH);
    CheckExternalEvents(cs8, 0xCEF9);
    // CLD  (1000_CEF8 / 0x1CEF8)
    DirectionFlag = false;
    label_1000_CEF9_1CEF9:
    CheckExternalEvents(cs8, 0xCEFA);
    // LODSB SI (1000_CEF9 / 0x1CEF9)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xCEFC);
    // XOR AH,AL (1000_CEFA / 0x1CEFA)
    // AH ^= AL;
    AH = Alu8.Xor(AH, AL);
    CheckExternalEvents(cs8, 0xCEFE);
    // LOOP 0x1000:cef9 (1000_CEFC / 0x1CEFC)
    if(--CX != 0) {
      goto label_1000_CEF9_1CEF9;
    }
    CheckExternalEvents(cs8, 0xCF01);
    // XOR AH,0x55 (1000_CEFE / 0x1CEFE)
    // AH ^= 0x55;
    AH = Alu8.Xor(AH, 0x55);
    CheckExternalEvents(cs8, 0xCF03);
    // JZ 0x1000:cf14 (1000_CF01 / 0x1CF01)
    if(ZeroFlag) {
      goto label_1000_CF14_1CF14;
    }
    CheckExternalEvents(cs8, 0xCF08);
    // CALLF 0x1000:cea2 (1000_CF03 / 0x1CF03)
    FarCall(cs8, 0xCF08, ghidra_guess_1000_CEA2_1CEA2);
    CheckExternalEvents(cs8, 0xCF0B);
    // MOV AX,0x1 (1000_CF08 / 0x1CF08)
    AX = 0x1;
    CheckExternalEvents(cs8, 0xCF0C);
    // PUSH AX (1000_CF0B / 0x1CF0B)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0xCF11);
    // CALLF 0x1000:d165 (1000_CF0C / 0x1CF0C)
    FarCall(cs8, 0xCF11, ghidra_guess_1000_D165_1D165);
    CheckExternalEvents(cs8, 0xCF14);
    // MOV AX,0x1 (1000_CF11 / 0x1CF11)
    AX = 0x1;
    label_1000_CF14_1CF14:
    CheckExternalEvents(cs8, 0xCF15);
    // POP SI (1000_CF14 / 0x1CF14)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xCF16);
    // RETF  (1000_CF15 / 0x1CF15)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_3026_1CF16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3026_1CF16:
    CheckExternalEvents(cs14, 0x302A);
    // POP word ptr [0x5336] (19EF_3026 / 0x1CF16)
    UInt16[DS, 0x5336] = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x302E);
    // POP word ptr [0x5338] (19EF_302A / 0x1CF1A)
    UInt16[DS, 0x5338] = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x3031);
    // MOV DX,0x2 (19EF_302E / 0x1CF1E)
    DX = 0x2;
    CheckExternalEvents(cs14, 0x3035);
    // CMP byte ptr [0x52f9],DL (19EF_3031 / 0x1CF21)
    Alu8.Sub(UInt8[DS, 0x52F9], DL);
    CheckExternalEvents(cs14, 0x3037);
    // JZ 0x1000:cf50 (19EF_3035 / 0x1CF25)
    if(ZeroFlag) {
      goto label_19EF_3060_1CF50;
    }
    CheckExternalEvents(cs14, 0x303B);
    // MOV ES,word ptr [0x52f7] (19EF_3037 / 0x1CF27)
    ES = UInt16[DS, 0x52F7];
    CheckExternalEvents(cs14, 0x3040);
    // MOV ES,word ptr ES:[0x2c] (19EF_303B / 0x1CF2B)
    ES = UInt16[ES, 0x2C];
    CheckExternalEvents(cs14, 0x3044);
    // MOV word ptr [0x5320],ES (19EF_3040 / 0x1CF30)
    UInt16[DS, 0x5320] = ES;
    CheckExternalEvents(cs14, 0x3046);
    // XOR AX,AX (19EF_3044 / 0x1CF34)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs14, 0x3047);
    // CWD  (19EF_3046 / 0x1CF36)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs14, 0x304A);
    // MOV CX,0x8000 (19EF_3047 / 0x1CF37)
    CX = 0x8000;
    CheckExternalEvents(cs14, 0x304C);
    // XOR DI,DI (19EF_304A / 0x1CF3A)
    DI = 0;
    label_19EF_304C_1CF3C:
    CheckExternalEvents(cs14, 0x304E);
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (19EF_304C / 0x1CF3C)
      Alu8.Sub(AL, UInt8[ES, (ushort)(DI)]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    CheckExternalEvents(cs14, 0x304F);
    // SCASB ES:DI (19EF_304E / 0x1CF3E)
    Alu8.Sub(AL, UInt8[ES, (ushort)(DI)]);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x3051);
    // JNZ 0x1000:cf3c (19EF_304F / 0x1CF3F)
    if(!ZeroFlag) {
      goto label_19EF_304C_1CF3C;
    }
    CheckExternalEvents(cs14, 0x3052);
    // INC DI (19EF_3051 / 0x1CF41)
    DI++;
    CheckExternalEvents(cs14, 0x3053);
    // INC DI (19EF_3052 / 0x1CF42)
    DI = Alu16.Inc(DI);
    CheckExternalEvents(cs14, 0x3057);
    // MOV word ptr [0x531e],DI (19EF_3053 / 0x1CF43)
    UInt16[DS, 0x531E] = DI;
    CheckExternalEvents(cs14, 0x305A);
    // MOV CX,0xffff (19EF_3057 / 0x1CF47)
    CX = 0xFFFF;
    CheckExternalEvents(cs14, 0x305C);
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (19EF_305A / 0x1CF4A)
      Alu8.Sub(AL, UInt8[ES, (ushort)(DI)]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    CheckExternalEvents(cs14, 0x305E);
    // NOT CX (19EF_305C / 0x1CF4C)
    CX = (ushort)(~CX);
    CheckExternalEvents(cs14, 0x3060);
    // MOV DX,CX (19EF_305E / 0x1CF4E)
    DX = CX;
    label_19EF_3060_1CF50:
    CheckExternalEvents(cs14, 0x3063);
    // MOV DI,0x1 (19EF_3060 / 0x1CF50)
    DI = 0x1;
    CheckExternalEvents(cs14, 0x3066);
    // MOV SI,0x81 (19EF_3063 / 0x1CF53)
    SI = 0x81;
    CheckExternalEvents(cs14, 0x306A);
    // MOV DS,word ptr [0x52f7] (19EF_3066 / 0x1CF56)
    DS = UInt16[DS, 0x52F7];
    label_19EF_306A_1CF5A:
    CheckExternalEvents(cs14, 0x306B);
    // LODSB SI (19EF_306A / 0x1CF5A)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x306D);
    // CMP AL,0x20 (19EF_306B / 0x1CF5B)
    Alu8.Sub(AL, 0x20);
    CheckExternalEvents(cs14, 0x306F);
    // JZ 0x1000:cf5a (19EF_306D / 0x1CF5D)
    if(ZeroFlag) {
      goto label_19EF_306A_1CF5A;
    }
    CheckExternalEvents(cs14, 0x3071);
    // CMP AL,0x9 (19EF_306F / 0x1CF5F)
    Alu8.Sub(AL, 0x9);
    CheckExternalEvents(cs14, 0x3073);
    // JZ 0x1000:cf5a (19EF_3071 / 0x1CF61)
    if(ZeroFlag) {
      goto label_19EF_306A_1CF5A;
    }
    CheckExternalEvents(cs14, 0x3075);
    // CMP AL,0xd (19EF_3073 / 0x1CF63)
    Alu8.Sub(AL, 0xD);
    CheckExternalEvents(cs14, 0x3077);
    // JZ 0x1000:cfd6 (19EF_3075 / 0x1CF65)
    if(ZeroFlag) {
      goto label_19EF_30E6_1CFD6;
    }
    CheckExternalEvents(cs14, 0x3079);
    // OR AL,AL (19EF_3077 / 0x1CF67)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x307B);
    // JZ 0x1000:cfd6 (19EF_3079 / 0x1CF69)
    if(ZeroFlag) {
      goto label_19EF_30E6_1CFD6;
    }
    CheckExternalEvents(cs14, 0x307C);
    // INC DI (19EF_307B / 0x1CF6B)
    DI++;
    label_19EF_307C_1CF6C:
    CheckExternalEvents(cs14, 0x307D);
    // DEC SI (19EF_307C / 0x1CF6C)
    SI = Alu16.Dec(SI);
    label_19EF_307D_1CF6D:
    CheckExternalEvents(cs14, 0x307E);
    // LODSB SI (19EF_307D / 0x1CF6D)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x3080);
    // CMP AL,0x20 (19EF_307E / 0x1CF6E)
    Alu8.Sub(AL, 0x20);
    CheckExternalEvents(cs14, 0x3082);
    // JZ 0x1000:cf5a (19EF_3080 / 0x1CF70)
    if(ZeroFlag) {
      goto label_19EF_306A_1CF5A;
    }
    CheckExternalEvents(cs14, 0x3084);
    // CMP AL,0x9 (19EF_3082 / 0x1CF72)
    Alu8.Sub(AL, 0x9);
    CheckExternalEvents(cs14, 0x3086);
    // JZ 0x1000:cf5a (19EF_3084 / 0x1CF74)
    if(ZeroFlag) {
      goto label_19EF_306A_1CF5A;
    }
    CheckExternalEvents(cs14, 0x3088);
    // CMP AL,0xd (19EF_3086 / 0x1CF76)
    Alu8.Sub(AL, 0xD);
    CheckExternalEvents(cs14, 0x308A);
    // JZ 0x1000:cfd6 (19EF_3088 / 0x1CF78)
    if(ZeroFlag) {
      goto label_19EF_30E6_1CFD6;
    }
    CheckExternalEvents(cs14, 0x308C);
    // OR AL,AL (19EF_308A / 0x1CF7A)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x308E);
    // JZ 0x1000:cfd6 (19EF_308C / 0x1CF7C)
    if(ZeroFlag) {
      goto label_19EF_30E6_1CFD6;
    }
    CheckExternalEvents(cs14, 0x3090);
    // CMP AL,0x22 (19EF_308E / 0x1CF7E)
    Alu8.Sub(AL, 0x22);
    CheckExternalEvents(cs14, 0x3092);
    // JZ 0x1000:cfa6 (19EF_3090 / 0x1CF80)
    if(ZeroFlag) {
      goto label_19EF_30B6_1CFA6;
    }
    CheckExternalEvents(cs14, 0x3094);
    // CMP AL,0x5c (19EF_3092 / 0x1CF82)
    Alu8.Sub(AL, 0x5C);
    CheckExternalEvents(cs14, 0x3096);
    // JZ 0x1000:cf89 (19EF_3094 / 0x1CF84)
    if(ZeroFlag) {
      goto label_19EF_3099_1CF89;
    }
    CheckExternalEvents(cs14, 0x3097);
    // INC DX (19EF_3096 / 0x1CF86)
    DX = Alu16.Inc(DX);
    CheckExternalEvents(cs14, 0x3099);
    // JMP 0x1000:cf6d (19EF_3097 / 0x1CF87)
    goto label_19EF_307D_1CF6D;
    label_19EF_3099_1CF89:
    CheckExternalEvents(cs14, 0x309B);
    // XOR CX,CX (19EF_3099 / 0x1CF89)
    CX = 0;
    label_19EF_309B_1CF8B:
    CheckExternalEvents(cs14, 0x309C);
    // INC CX (19EF_309B / 0x1CF8B)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs14, 0x309D);
    // LODSB SI (19EF_309C / 0x1CF8C)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x309F);
    // CMP AL,0x5c (19EF_309D / 0x1CF8D)
    Alu8.Sub(AL, 0x5C);
    CheckExternalEvents(cs14, 0x30A1);
    // JZ 0x1000:cf8b (19EF_309F / 0x1CF8F)
    if(ZeroFlag) {
      goto label_19EF_309B_1CF8B;
    }
    CheckExternalEvents(cs14, 0x30A3);
    // CMP AL,0x22 (19EF_30A1 / 0x1CF91)
    Alu8.Sub(AL, 0x22);
    CheckExternalEvents(cs14, 0x30A5);
    // JZ 0x1000:cf99 (19EF_30A3 / 0x1CF93)
    if(ZeroFlag) {
      goto label_19EF_30A9_1CF99;
    }
    CheckExternalEvents(cs14, 0x30A7);
    // ADD DX,CX (19EF_30A5 / 0x1CF95)
    // DX += CX;
    DX = Alu16.Add(DX, CX);
    CheckExternalEvents(cs14, 0x30A9);
    // JMP 0x1000:cf6c (19EF_30A7 / 0x1CF97)
    goto label_19EF_307C_1CF6C;
    label_19EF_30A9_1CF99:
    CheckExternalEvents(cs14, 0x30AB);
    // MOV AX,CX (19EF_30A9 / 0x1CF99)
    AX = CX;
    CheckExternalEvents(cs14, 0x30AD);
    // SHR CX,0x1 (19EF_30AB / 0x1CF9B)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    CheckExternalEvents(cs14, 0x30AF);
    // ADC DX,CX (19EF_30AD / 0x1CF9D)
    DX = Alu16.Adc(DX, CX);
    CheckExternalEvents(cs14, 0x30B1);
    // TEST AL,0x1 (19EF_30AF / 0x1CF9F)
    Alu8.And(AL, 0x1);
    CheckExternalEvents(cs14, 0x30B3);
    // JNZ 0x1000:cf6d (19EF_30B1 / 0x1CFA1)
    if(!ZeroFlag) {
      goto label_19EF_307D_1CF6D;
    }
    CheckExternalEvents(cs14, 0x30B5);
    // JMP 0x1000:cfa6 (19EF_30B3 / 0x1CFA3)
    goto label_19EF_30B6_1CFA6;
    label_19EF_30B5_1CFA5:
    CheckExternalEvents(cs14, 0x30B6);
    // DEC SI (19EF_30B5 / 0x1CFA5)
    SI = Alu16.Dec(SI);
    label_19EF_30B6_1CFA6:
    CheckExternalEvents(cs14, 0x30B7);
    // LODSB SI (19EF_30B6 / 0x1CFA6)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x30B9);
    // CMP AL,0xd (19EF_30B7 / 0x1CFA7)
    Alu8.Sub(AL, 0xD);
    CheckExternalEvents(cs14, 0x30BB);
    // JZ 0x1000:cfd6 (19EF_30B9 / 0x1CFA9)
    if(ZeroFlag) {
      goto label_19EF_30E6_1CFD6;
    }
    CheckExternalEvents(cs14, 0x30BD);
    // OR AL,AL (19EF_30BB / 0x1CFAB)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x30BF);
    // JZ 0x1000:cfd6 (19EF_30BD / 0x1CFAD)
    if(ZeroFlag) {
      goto label_19EF_30E6_1CFD6;
    }
    CheckExternalEvents(cs14, 0x30C1);
    // CMP AL,0x22 (19EF_30BF / 0x1CFAF)
    Alu8.Sub(AL, 0x22);
    CheckExternalEvents(cs14, 0x30C3);
    // JZ 0x1000:cf6d (19EF_30C1 / 0x1CFB1)
    if(ZeroFlag) {
      goto label_19EF_307D_1CF6D;
    }
    CheckExternalEvents(cs14, 0x30C5);
    // CMP AL,0x5c (19EF_30C3 / 0x1CFB3)
    Alu8.Sub(AL, 0x5C);
    CheckExternalEvents(cs14, 0x30C7);
    // JZ 0x1000:cfba (19EF_30C5 / 0x1CFB5)
    if(ZeroFlag) {
      goto label_19EF_30CA_1CFBA;
    }
    CheckExternalEvents(cs14, 0x30C8);
    // INC DX (19EF_30C7 / 0x1CFB7)
    DX = Alu16.Inc(DX);
    CheckExternalEvents(cs14, 0x30CA);
    // JMP 0x1000:cfa6 (19EF_30C8 / 0x1CFB8)
    goto label_19EF_30B6_1CFA6;
    label_19EF_30CA_1CFBA:
    CheckExternalEvents(cs14, 0x30CC);
    // XOR CX,CX (19EF_30CA / 0x1CFBA)
    CX = 0;
    label_19EF_30CC_1CFBC:
    CheckExternalEvents(cs14, 0x30CD);
    // INC CX (19EF_30CC / 0x1CFBC)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs14, 0x30CE);
    // LODSB SI (19EF_30CD / 0x1CFBD)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x30D0);
    // CMP AL,0x5c (19EF_30CE / 0x1CFBE)
    Alu8.Sub(AL, 0x5C);
    CheckExternalEvents(cs14, 0x30D2);
    // JZ 0x1000:cfbc (19EF_30D0 / 0x1CFC0)
    if(ZeroFlag) {
      goto label_19EF_30CC_1CFBC;
    }
    CheckExternalEvents(cs14, 0x30D4);
    // CMP AL,0x22 (19EF_30D2 / 0x1CFC2)
    Alu8.Sub(AL, 0x22);
    CheckExternalEvents(cs14, 0x30D6);
    // JZ 0x1000:cfca (19EF_30D4 / 0x1CFC4)
    if(ZeroFlag) {
      goto label_19EF_30DA_1CFCA;
    }
    CheckExternalEvents(cs14, 0x30D8);
    // ADD DX,CX (19EF_30D6 / 0x1CFC6)
    // DX += CX;
    DX = Alu16.Add(DX, CX);
    CheckExternalEvents(cs14, 0x30DA);
    // JMP 0x1000:cfa5 (19EF_30D8 / 0x1CFC8)
    goto label_19EF_30B5_1CFA5;
    label_19EF_30DA_1CFCA:
    CheckExternalEvents(cs14, 0x30DC);
    // MOV AX,CX (19EF_30DA / 0x1CFCA)
    AX = CX;
    CheckExternalEvents(cs14, 0x30DE);
    // SHR CX,0x1 (19EF_30DC / 0x1CFCC)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    CheckExternalEvents(cs14, 0x30E0);
    // ADC DX,CX (19EF_30DE / 0x1CFCE)
    DX = Alu16.Adc(DX, CX);
    CheckExternalEvents(cs14, 0x30E2);
    // TEST AL,0x1 (19EF_30E0 / 0x1CFD0)
    Alu8.And(AL, 0x1);
    CheckExternalEvents(cs14, 0x30E4);
    // JNZ 0x1000:cfa6 (19EF_30E2 / 0x1CFD2)
    if(!ZeroFlag) {
      goto label_19EF_30B6_1CFA6;
    }
    CheckExternalEvents(cs14, 0x30E6);
    // JMP 0x1000:cf6d (19EF_30E4 / 0x1CFD4)
    goto label_19EF_307D_1CF6D;
    label_19EF_30E6_1CFD6:
    CheckExternalEvents(cs14, 0x30E7);
    // PUSH SS (19EF_30E6 / 0x1CFD6)
    Stack.Push16(SS);
    CheckExternalEvents(cs14, 0x30E8);
    // POP DS (19EF_30E7 / 0x1CFD7)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x30EC);
    // MOV word ptr [0x5314],DI (19EF_30E8 / 0x1CFD8)
    UInt16[DS, 0x5314] = DI;
    CheckExternalEvents(cs14, 0x30EE);
    // ADD DX,DI (19EF_30EC / 0x1CFDC)
    DX += DI;
    CheckExternalEvents(cs14, 0x30EF);
    // INC DI (19EF_30EE / 0x1CFDE)
    DI++;
    CheckExternalEvents(cs14, 0x30F1);
    // SHL DI,0x1 (19EF_30EF / 0x1CFDF)
    DI <<= 0x1;
    CheckExternalEvents(cs14, 0x30F3);
    // SHL DI,0x1 (19EF_30F1 / 0x1CFE1)
    DI <<= 0x1;
    CheckExternalEvents(cs14, 0x30F5);
    // ADD DX,DI (19EF_30F3 / 0x1CFE3)
    DX += DI;
    CheckExternalEvents(cs14, 0x30F8);
    // AND DL,0xfe (19EF_30F5 / 0x1CFE5)
    DL &= 0xFE;
    CheckExternalEvents(cs14, 0x30FA);
    // SUB SP,DX (19EF_30F8 / 0x1CFE8)
    // SP -= DX;
    SP = Alu16.Sub(SP, DX);
    CheckExternalEvents(cs14, 0x30FC);
    // MOV AX,SP (19EF_30FA / 0x1CFEA)
    AX = SP;
    CheckExternalEvents(cs14, 0x30FF);
    // MOV [0x5316],AX (19EF_30FC / 0x1CFEC)
    UInt16[DS, 0x5316] = AX;
    CheckExternalEvents(cs14, 0x3103);
    // MOV word ptr [0x5318],DS (19EF_30FF / 0x1CFEF)
    UInt16[DS, 0x5318] = DS;
    CheckExternalEvents(cs14, 0x3105);
    // MOV BX,AX (19EF_3103 / 0x1CFF3)
    BX = AX;
    CheckExternalEvents(cs14, 0x3107);
    // ADD DI,BX (19EF_3105 / 0x1CFF5)
    // DI += BX;
    DI = Alu16.Add(DI, BX);
    CheckExternalEvents(cs14, 0x3108);
    // PUSH SS (19EF_3107 / 0x1CFF7)
    Stack.Push16(SS);
    CheckExternalEvents(cs14, 0x3109);
    // POP ES (19EF_3108 / 0x1CFF8)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x310C);
    // MOV word ptr SS:[BX],DI (19EF_3109 / 0x1CFF9)
    UInt16[SS, (ushort)(BX)] = DI;
    CheckExternalEvents(cs14, 0x3110);
    // MOV word ptr SS:[BX + 0x2],SS (19EF_310C / 0x1CFFC)
    UInt16[SS, (ushort)(BX + 0x2)] = SS;
    CheckExternalEvents(cs14, 0x3113);
    // ADD BX,0x4 (19EF_3110 / 0x1D000)
    // BX += 0x4;
    BX = Alu16.Add(BX, 0x4);
    CheckExternalEvents(cs14, 0x3117);
    // LDS SI,[0x531e] (19EF_3113 / 0x1D003)
    SI = UInt16[DS, 0x531E];
    DS = UInt16[DS, 0x5320];
    label_19EF_3117_1D007:
    CheckExternalEvents(cs14, 0x3118);
    // LODSB SI (19EF_3117 / 0x1D007)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x3119);
    // STOSB ES:DI (19EF_3118 / 0x1D008)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x311B);
    // OR AL,AL (19EF_3119 / 0x1D009)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x311D);
    // JNZ 0x1000:d007 (19EF_311B / 0x1D00B)
    if(!ZeroFlag) {
      goto label_19EF_3117_1D007;
    }
    CheckExternalEvents(cs14, 0x3120);
    // MOV SI,0x81 (19EF_311D / 0x1D00D)
    SI = 0x81;
    CheckExternalEvents(cs14, 0x3125);
    // MOV DS,word ptr SS:[0x52f7] (19EF_3120 / 0x1D010)
    DS = UInt16[SS, 0x52F7];
    CheckExternalEvents(cs14, 0x3127);
    // JMP 0x1000:d01a (19EF_3125 / 0x1D015)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D01A_1D01A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_D017_1D017(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D017_1D017:
    CheckExternalEvents(cs8, 0xD019);
    // XOR AX,AX (1000_D017 / 0x1D017)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0xD01A);
    // STOSB ES:DI (1000_D019 / 0x1D019)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    // Function call generated as ASM continues to next function entry point without return
    return split_1000_D01A_1D01A(0);
  }
  
  public virtual Action split_1000_D01A_1D01A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D01A_1D01A:
    CheckExternalEvents(cs8, 0xD01B);
    // LODSB SI (1000_D01A / 0x1D01A)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xD01D);
    // CMP AL,0x20 (1000_D01B / 0x1D01B)
    Alu8.Sub(AL, 0x20);
    CheckExternalEvents(cs8, 0xD01F);
    // JZ 0x1000:d01a (1000_D01D / 0x1D01D)
    if(ZeroFlag) {
      goto label_1000_D01A_1D01A;
    }
    CheckExternalEvents(cs8, 0xD021);
    // CMP AL,0x9 (1000_D01F / 0x1D01F)
    Alu8.Sub(AL, 0x9);
    CheckExternalEvents(cs8, 0xD023);
    // JZ 0x1000:d01a (1000_D021 / 0x1D021)
    if(ZeroFlag) {
      goto label_1000_D01A_1D01A;
    }
    CheckExternalEvents(cs8, 0xD025);
    // CMP AL,0xd (1000_D023 / 0x1D023)
    Alu8.Sub(AL, 0xD);
    CheckExternalEvents(cs8, 0xD027);
    // JNZ 0x1000:d02a (1000_D025 / 0x1D025)
    if(!ZeroFlag) {
      goto label_1000_D02A_1D02A;
    }
    CheckExternalEvents(cs8, 0xD02A);
    // JMP 0x1000:d0ae (1000_D027 / 0x1D027)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_D031_1D031, 0x1D0AE - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D02A_1D02A:
    CheckExternalEvents(cs8, 0xD02C);
    // OR AL,AL (1000_D02A / 0x1D02A)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs8, 0xD02E);
    // JNZ 0x1000:d031 (1000_D02C / 0x1D02C)
    if(!ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_D031_1D031, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xD030);
    // JMP 0x1000:d0ae (1000_D02E / 0x1D02E)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_D031_1D031, 0x1D0AE - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_D031_1D031(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1D0AE: goto label_1000_D0AE_1D0AE;break; // Target of external jump from 0x1D027, 0x1D02E
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D031_1D031:
    CheckExternalEvents(cs8, 0xD034);
    // MOV word ptr SS:[BX],DI (1000_D031 / 0x1D031)
    UInt16[SS, (ushort)(BX)] = DI;
    CheckExternalEvents(cs8, 0xD038);
    // MOV word ptr SS:[BX + 0x2],SS (1000_D034 / 0x1D034)
    UInt16[SS, (ushort)(BX + 0x2)] = SS;
    CheckExternalEvents(cs8, 0xD03B);
    // ADD BX,0x4 (1000_D038 / 0x1D038)
    BX += 0x4;
    label_1000_D03B_1D03B:
    CheckExternalEvents(cs8, 0xD03C);
    // DEC SI (1000_D03B / 0x1D03B)
    SI = Alu16.Dec(SI);
    label_1000_D03C_1D03C:
    CheckExternalEvents(cs8, 0xD03D);
    // LODSB SI (1000_D03C / 0x1D03C)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xD03F);
    // CMP AL,0x20 (1000_D03D / 0x1D03D)
    Alu8.Sub(AL, 0x20);
    CheckExternalEvents(cs8, 0xD041);
    // JZ 0x1000:d017 (1000_D03F / 0x1D03F)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_D017_1D017, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xD043);
    // CMP AL,0x9 (1000_D041 / 0x1D041)
    Alu8.Sub(AL, 0x9);
    CheckExternalEvents(cs8, 0xD045);
    // JZ 0x1000:d017 (1000_D043 / 0x1D043)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_D017_1D017, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xD047);
    // CMP AL,0xd (1000_D045 / 0x1D045)
    Alu8.Sub(AL, 0xD);
    CheckExternalEvents(cs8, 0xD049);
    // JZ 0x1000:d0ab (1000_D047 / 0x1D047)
    if(ZeroFlag) {
      goto label_1000_D0AB_1D0AB;
    }
    CheckExternalEvents(cs8, 0xD04B);
    // OR AL,AL (1000_D049 / 0x1D049)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs8, 0xD04D);
    // JZ 0x1000:d0ab (1000_D04B / 0x1D04B)
    if(ZeroFlag) {
      goto label_1000_D0AB_1D0AB;
    }
    CheckExternalEvents(cs8, 0xD04F);
    // CMP AL,0x22 (1000_D04D / 0x1D04D)
    Alu8.Sub(AL, 0x22);
    CheckExternalEvents(cs8, 0xD051);
    // JZ 0x1000:d078 (1000_D04F / 0x1D04F)
    if(ZeroFlag) {
      goto label_1000_D078_1D078;
    }
    CheckExternalEvents(cs8, 0xD053);
    // CMP AL,0x5c (1000_D051 / 0x1D051)
    Alu8.Sub(AL, 0x5C);
    CheckExternalEvents(cs8, 0xD055);
    // JZ 0x1000:d058 (1000_D053 / 0x1D053)
    if(ZeroFlag) {
      goto label_1000_D058_1D058;
    }
    CheckExternalEvents(cs8, 0xD056);
    // STOSB ES:DI (1000_D055 / 0x1D055)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xD058);
    // JMP 0x1000:d03c (1000_D056 / 0x1D056)
    goto label_1000_D03C_1D03C;
    label_1000_D058_1D058:
    CheckExternalEvents(cs8, 0xD05A);
    // XOR CX,CX (1000_D058 / 0x1D058)
    CX = 0;
    label_1000_D05A_1D05A:
    CheckExternalEvents(cs8, 0xD05B);
    // INC CX (1000_D05A / 0x1D05A)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs8, 0xD05C);
    // LODSB SI (1000_D05B / 0x1D05B)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xD05E);
    // CMP AL,0x5c (1000_D05C / 0x1D05C)
    Alu8.Sub(AL, 0x5C);
    CheckExternalEvents(cs8, 0xD060);
    // JZ 0x1000:d05a (1000_D05E / 0x1D05E)
    if(ZeroFlag) {
      goto label_1000_D05A_1D05A;
    }
    CheckExternalEvents(cs8, 0xD062);
    // CMP AL,0x22 (1000_D060 / 0x1D060)
    Alu8.Sub(AL, 0x22);
    CheckExternalEvents(cs8, 0xD064);
    // JZ 0x1000:d06a (1000_D062 / 0x1D062)
    if(ZeroFlag) {
      goto label_1000_D06A_1D06A;
    }
    CheckExternalEvents(cs8, 0xD066);
    // MOV AL,0x5c (1000_D064 / 0x1D064)
    AL = 0x5C;
    CheckExternalEvents(cs8, 0xD068);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_D066 / 0x1D066)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs8, 0xD06A);
    // JMP 0x1000:d03b (1000_D068 / 0x1D068)
    goto label_1000_D03B_1D03B;
    label_1000_D06A_1D06A:
    CheckExternalEvents(cs8, 0xD06C);
    // MOV AL,0x5c (1000_D06A / 0x1D06A)
    AL = 0x5C;
    CheckExternalEvents(cs8, 0xD06E);
    // SHR CX,0x1 (1000_D06C / 0x1D06C)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    CheckExternalEvents(cs8, 0xD070);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_D06E / 0x1D06E)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs8, 0xD072);
    // JNC 0x1000:d078 (1000_D070 / 0x1D070)
    if(!CarryFlag) {
      goto label_1000_D078_1D078;
    }
    CheckExternalEvents(cs8, 0xD074);
    // MOV AL,0x22 (1000_D072 / 0x1D072)
    AL = 0x22;
    CheckExternalEvents(cs8, 0xD075);
    // STOSB ES:DI (1000_D074 / 0x1D074)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xD077);
    // JMP 0x1000:d03c (1000_D075 / 0x1D075)
    goto label_1000_D03C_1D03C;
    label_1000_D077_1D077:
    CheckExternalEvents(cs8, 0xD078);
    // DEC SI (1000_D077 / 0x1D077)
    SI = Alu16.Dec(SI);
    label_1000_D078_1D078:
    CheckExternalEvents(cs8, 0xD079);
    // LODSB SI (1000_D078 / 0x1D078)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xD07B);
    // CMP AL,0xd (1000_D079 / 0x1D079)
    Alu8.Sub(AL, 0xD);
    CheckExternalEvents(cs8, 0xD07D);
    // JZ 0x1000:d0ab (1000_D07B / 0x1D07B)
    if(ZeroFlag) {
      goto label_1000_D0AB_1D0AB;
    }
    CheckExternalEvents(cs8, 0xD07F);
    // OR AL,AL (1000_D07D / 0x1D07D)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs8, 0xD081);
    // JZ 0x1000:d0ab (1000_D07F / 0x1D07F)
    if(ZeroFlag) {
      goto label_1000_D0AB_1D0AB;
    }
    CheckExternalEvents(cs8, 0xD083);
    // CMP AL,0x22 (1000_D081 / 0x1D081)
    Alu8.Sub(AL, 0x22);
    CheckExternalEvents(cs8, 0xD085);
    // JZ 0x1000:d03c (1000_D083 / 0x1D083)
    if(ZeroFlag) {
      goto label_1000_D03C_1D03C;
    }
    CheckExternalEvents(cs8, 0xD087);
    // CMP AL,0x5c (1000_D085 / 0x1D085)
    Alu8.Sub(AL, 0x5C);
    CheckExternalEvents(cs8, 0xD089);
    // JZ 0x1000:d08c (1000_D087 / 0x1D087)
    if(ZeroFlag) {
      goto label_1000_D08C_1D08C;
    }
    CheckExternalEvents(cs8, 0xD08A);
    // STOSB ES:DI (1000_D089 / 0x1D089)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xD08C);
    // JMP 0x1000:d078 (1000_D08A / 0x1D08A)
    goto label_1000_D078_1D078;
    label_1000_D08C_1D08C:
    CheckExternalEvents(cs8, 0xD08E);
    // XOR CX,CX (1000_D08C / 0x1D08C)
    CX = 0;
    label_1000_D08E_1D08E:
    CheckExternalEvents(cs8, 0xD08F);
    // INC CX (1000_D08E / 0x1D08E)
    CX = Alu16.Inc(CX);
    CheckExternalEvents(cs8, 0xD090);
    // LODSB SI (1000_D08F / 0x1D08F)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs8, 0xD092);
    // CMP AL,0x5c (1000_D090 / 0x1D090)
    Alu8.Sub(AL, 0x5C);
    CheckExternalEvents(cs8, 0xD094);
    // JZ 0x1000:d08e (1000_D092 / 0x1D092)
    if(ZeroFlag) {
      goto label_1000_D08E_1D08E;
    }
    CheckExternalEvents(cs8, 0xD096);
    // CMP AL,0x22 (1000_D094 / 0x1D094)
    Alu8.Sub(AL, 0x22);
    CheckExternalEvents(cs8, 0xD098);
    // JZ 0x1000:d09e (1000_D096 / 0x1D096)
    if(ZeroFlag) {
      goto label_1000_D09E_1D09E;
    }
    CheckExternalEvents(cs8, 0xD09A);
    // MOV AL,0x5c (1000_D098 / 0x1D098)
    AL = 0x5C;
    CheckExternalEvents(cs8, 0xD09C);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_D09A / 0x1D09A)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs8, 0xD09E);
    // JMP 0x1000:d077 (1000_D09C / 0x1D09C)
    goto label_1000_D077_1D077;
    label_1000_D09E_1D09E:
    CheckExternalEvents(cs8, 0xD0A0);
    // MOV AL,0x5c (1000_D09E / 0x1D09E)
    AL = 0x5C;
    CheckExternalEvents(cs8, 0xD0A2);
    // SHR CX,0x1 (1000_D0A0 / 0x1D0A0)
    // CX >>= 0x1;
    CX = Alu16.Shr(CX, 0x1);
    CheckExternalEvents(cs8, 0xD0A4);
    // REP
    while (CX != 0) {
      CX--;
      // STOSB ES:DI (1000_D0A2 / 0x1D0A2)
      UInt8[ES, (ushort)(DI)] = AL;
      DI = (ushort)(DI + Direction8);
    }
    CheckExternalEvents(cs8, 0xD0A6);
    // JNC 0x1000:d03c (1000_D0A4 / 0x1D0A4)
    if(!CarryFlag) {
      goto label_1000_D03C_1D03C;
    }
    CheckExternalEvents(cs8, 0xD0A8);
    // MOV AL,0x22 (1000_D0A6 / 0x1D0A6)
    AL = 0x22;
    CheckExternalEvents(cs8, 0xD0A9);
    // STOSB ES:DI (1000_D0A8 / 0x1D0A8)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs8, 0xD0AB);
    // JMP 0x1000:d078 (1000_D0A9 / 0x1D0A9)
    goto label_1000_D078_1D078;
    label_1000_D0AB_1D0AB:
    CheckExternalEvents(cs8, 0xD0AD);
    // XOR AX,AX (1000_D0AB / 0x1D0AB)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0xD0AE);
    // STOSB ES:DI (1000_D0AD / 0x1D0AD)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    label_1000_D0AE_1D0AE:
    CheckExternalEvents(cs8, 0xD0AF);
    // PUSH SS (1000_D0AE / 0x1D0AE)
    Stack.Push16(SS);
    CheckExternalEvents(cs8, 0xD0B0);
    // POP DS (1000_D0AF / 0x1D0AF)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD0B4);
    // MOV word ptr [BX],0x0 (1000_D0B0 / 0x1D0B0)
    UInt16[DS, (ushort)(BX)] = 0x0;
    CheckExternalEvents(cs8, 0xD0B9);
    // MOV word ptr [BX + 0x2],0x0 (1000_D0B4 / 0x1D0B4)
    UInt16[DS, (ushort)(BX + 0x2)] = 0x0;
    CheckExternalEvents(cs8, 0xD0BD);
    // JMPF [0x5336] (1000_D0B9 / 0x1D0B9)
    // Indirect jump to [0x5336], generating possible targets from emulator records
    uint targetAddress_1000_D0B9 = (uint)(UInt16[DS, 0x5338] * 0x10 + UInt16[DS, 0x5336] - cs1 * 0x10);
    switch(targetAddress_1000_D0B9) {
      case 0x1CCFB : {
        // Jump converted to non entry function call
        if(JumpDispatcher.Jump(entry_19EF_2D82_1CC72, 0x1CCFB - cs1 * 0x10)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_D0B9));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action unknown_19EF_31CE_1D0BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_31CE_1D0BE:
    CheckExternalEvents(cs14, 0x31CF);
    // PUSH BP (19EF_31CE / 0x1D0BE)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x31D1);
    // MOV BP,SP (19EF_31CF / 0x1D0BF)
    BP = SP;
    CheckExternalEvents(cs14, 0x31D2);
    // PUSH BP (19EF_31D1 / 0x1D0C1)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x31D6);
    // MOV DS,word ptr [0x52f7] (19EF_31D2 / 0x1D0C2)
    DS = UInt16[DS, 0x52F7];
    CheckExternalEvents(cs14, 0x31D8);
    // XOR CX,CX (19EF_31D6 / 0x1D0C6)
    // CX ^= CX;
    CX = Alu16.Xor(CX, CX);
    CheckExternalEvents(cs14, 0x31DA);
    // MOV AX,CX (19EF_31D8 / 0x1D0C8)
    AX = CX;
    CheckExternalEvents(cs14, 0x31DC);
    // MOV BP,CX (19EF_31DA / 0x1D0CA)
    BP = CX;
    CheckExternalEvents(cs14, 0x31DE);
    // MOV DI,CX (19EF_31DC / 0x1D0CC)
    DI = CX;
    CheckExternalEvents(cs14, 0x31DF);
    // DEC CX (19EF_31DE / 0x1D0CE)
    CX = Alu16.Dec(CX);
    CheckExternalEvents(cs14, 0x31E3);
    // MOV SI,word ptr [0x2c] (19EF_31DF / 0x1D0CF)
    SI = UInt16[DS, 0x2C];
    CheckExternalEvents(cs14, 0x31E5);
    // OR SI,SI (19EF_31E3 / 0x1D0D3)
    // SI |= SI;
    SI = Alu16.Or(SI, SI);
    CheckExternalEvents(cs14, 0x31E7);
    // JZ 0x1000:d0e7 (19EF_31E5 / 0x1D0D5)
    if(ZeroFlag) {
      goto label_19EF_31F7_1D0E7;
    }
    CheckExternalEvents(cs14, 0x31E9);
    // MOV ES,SI (19EF_31E7 / 0x1D0D7)
    ES = SI;
    CheckExternalEvents(cs14, 0x31EF);
    // CMP byte ptr ES:[0x0],0x0 (19EF_31E9 / 0x1D0D9)
    Alu8.Sub(UInt8[ES, 0x0], 0x0);
    CheckExternalEvents(cs14, 0x31F1);
    // JZ 0x1000:d0e7 (19EF_31EF / 0x1D0DF)
    if(ZeroFlag) {
      goto label_19EF_31F7_1D0E7;
    }
    label_19EF_31F1_1D0E1:
    CheckExternalEvents(cs14, 0x31F3);
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (19EF_31F1 / 0x1D0E1)
      Alu8.Sub(AL, UInt8[ES, (ushort)(DI)]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    CheckExternalEvents(cs14, 0x31F4);
    // INC BP (19EF_31F3 / 0x1D0E3)
    BP++;
    CheckExternalEvents(cs14, 0x31F5);
    // SCASB ES:DI (19EF_31F4 / 0x1D0E4)
    Alu8.Sub(AL, UInt8[ES, (ushort)(DI)]);
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x31F7);
    // JNZ 0x1000:d0e1 (19EF_31F5 / 0x1D0E5)
    if(!ZeroFlag) {
      goto label_19EF_31F1_1D0E1;
    }
    label_19EF_31F7_1D0E7:
    CheckExternalEvents(cs14, 0x31F8);
    // INC BP (19EF_31F7 / 0x1D0E7)
    BP = Alu16.Inc(BP);
    CheckExternalEvents(cs14, 0x31F9);
    // XCHG AX,DI (19EF_31F8 / 0x1D0E8)
    (DI, AX) = (AX, DI);
    CheckExternalEvents(cs14, 0x31FA);
    // INC AX (19EF_31F9 / 0x1D0E9)
    AX++;
    CheckExternalEvents(cs14, 0x31FC);
    // AND AL,0xfe (19EF_31FA / 0x1D0EA)
    // AL &= 0xFE;
    AL = Alu8.And(AL, 0xFE);
    CheckExternalEvents(cs14, 0x31FE);
    // MOV DI,BP (19EF_31FC / 0x1D0EC)
    DI = BP;
    CheckExternalEvents(cs14, 0x3200);
    // SHL BP,0x1 (19EF_31FE / 0x1D0EE)
    BP <<= 0x1;
    CheckExternalEvents(cs14, 0x3202);
    // SHL BP,0x1 (19EF_3200 / 0x1D0F0)
    BP <<= 0x1;
    CheckExternalEvents(cs14, 0x3204);
    // ADD AX,BP (19EF_3202 / 0x1D0F2)
    // AX += BP;
    AX = Alu16.Add(AX, BP);
    CheckExternalEvents(cs14, 0x3205);
    // PUSH SS (19EF_3204 / 0x1D0F4)
    Stack.Push16(SS);
    CheckExternalEvents(cs14, 0x3206);
    // POP DS (19EF_3205 / 0x1D0F5)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x3207);
    // PUSH DI (19EF_3206 / 0x1D0F6)
    Stack.Push16(DI);
    CheckExternalEvents(cs14, 0x320A);
    // MOV DI,0x9 (19EF_3207 / 0x1D0F7)
    DI = 0x9;
    CheckExternalEvents(cs14, 0x320D);
    // CALL 0x1000:d190 (19EF_320A / 0x1D0FA)
    NearCall(cs14, 0x320D, unknown_19EF_32A0_1D190);
    CheckExternalEvents(cs14, 0x320E);
    // POP DI (19EF_320D / 0x1D0FD)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x3210);
    // MOV CX,DI (19EF_320E / 0x1D0FE)
    CX = DI;
    CheckExternalEvents(cs14, 0x3212);
    // MOV DI,BP (19EF_3210 / 0x1D100)
    DI = BP;
    CheckExternalEvents(cs14, 0x3214);
    // ADD DI,AX (19EF_3212 / 0x1D102)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs14, 0x3218);
    // MOV word ptr [0x531a],BP (19EF_3214 / 0x1D104)
    UInt16[DS, 0x531A] = BP;
    CheckExternalEvents(cs14, 0x321C);
    // MOV word ptr [0x531c],DS (19EF_3218 / 0x1D108)
    UInt16[DS, 0x531C] = DS;
    CheckExternalEvents(cs14, 0x321D);
    // PUSH DS (19EF_321C / 0x1D10C)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x321E);
    // POP ES (19EF_321D / 0x1D10D)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x3220);
    // MOV DS,SI (19EF_321E / 0x1D10E)
    DS = SI;
    CheckExternalEvents(cs14, 0x3222);
    // XOR SI,SI (19EF_3220 / 0x1D110)
    SI = 0;
    CheckExternalEvents(cs14, 0x3223);
    // DEC CX (19EF_3222 / 0x1D112)
    CX = Alu16.Dec(CX);
    CheckExternalEvents(cs14, 0x3225);
    // JCXZ 0x1000:d12c (19EF_3223 / 0x1D113)
    if(CX == 0) {
      goto label_19EF_323C_1D12C;
    }
    label_19EF_3225_1D115:
    CheckExternalEvents(cs14, 0x3229);
    // CMP word ptr [SI],0x433b (19EF_3225 / 0x1D115)
    Alu16.Sub(UInt16[DS, (ushort)(SI)], 0x433B);
    CheckExternalEvents(cs14, 0x322B);
    // JZ 0x1000:d124 (19EF_3229 / 0x1D119)
    if(ZeroFlag) {
      goto label_19EF_3234_1D124;
    }
    CheckExternalEvents(cs14, 0x322E);
    // MOV word ptr [BP + 0x0],DI (19EF_322B / 0x1D11B)
    UInt16[SS, (ushort)(BP)] = DI;
    CheckExternalEvents(cs14, 0x3231);
    // MOV word ptr [BP + 0x2],ES (19EF_322E / 0x1D11E)
    UInt16[SS, (ushort)(BP + 0x2)] = ES;
    CheckExternalEvents(cs14, 0x3234);
    // ADD BP,0x4 (19EF_3231 / 0x1D121)
    // BP += 0x4;
    BP = Alu16.Add(BP, 0x4);
    label_19EF_3234_1D124:
    CheckExternalEvents(cs14, 0x3235);
    // LODSB SI (19EF_3234 / 0x1D124)
    AL = UInt8[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction8);
    CheckExternalEvents(cs14, 0x3236);
    // STOSB ES:DI (19EF_3235 / 0x1D125)
    UInt8[ES, (ushort)(DI)] = AL;
    DI = (ushort)(DI + Direction8);
    CheckExternalEvents(cs14, 0x3238);
    // OR AL,AL (19EF_3236 / 0x1D126)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs14, 0x323A);
    // JNZ 0x1000:d124 (19EF_3238 / 0x1D128)
    if(!ZeroFlag) {
      goto label_19EF_3234_1D124;
    }
    CheckExternalEvents(cs14, 0x323C);
    // LOOP 0x1000:d115 (19EF_323A / 0x1D12A)
    if(--CX != 0) {
      goto label_19EF_3225_1D115;
    }
    label_19EF_323C_1D12C:
    CheckExternalEvents(cs14, 0x323F);
    // MOV word ptr [BP + 0x0],CX (19EF_323C / 0x1D12C)
    UInt16[SS, (ushort)(BP)] = CX;
    CheckExternalEvents(cs14, 0x3242);
    // MOV word ptr [BP + 0x2],CX (19EF_323F / 0x1D12F)
    UInt16[SS, (ushort)(BP + 0x2)] = CX;
    CheckExternalEvents(cs14, 0x3243);
    // PUSH SS (19EF_3242 / 0x1D132)
    Stack.Push16(SS);
    CheckExternalEvents(cs14, 0x3244);
    // POP DS (19EF_3243 / 0x1D133)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x3245);
    // POP BP (19EF_3244 / 0x1D134)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x3247);
    // MOV SP,BP (19EF_3245 / 0x1D135)
    SP = BP;
    CheckExternalEvents(cs14, 0x3248);
    // POP BP (19EF_3247 / 0x1D137)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x3249);
    // RETF  (19EF_3248 / 0x1D138)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_D13A_1D13A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D13A_1D13A:
    CheckExternalEvents(cs8, 0xD13B);
    // PUSH BP (1000_D13A / 0x1D13A)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xD13D);
    // MOV BP,SP (1000_D13B / 0x1D13B)
    BP = SP;
    CheckExternalEvents(cs8, 0xD13E);
    // PUSH SI (1000_D13D / 0x1D13D)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0xD13F);
    // PUSH DI (1000_D13E / 0x1D13E)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xD140);
    // PUSH DS (1000_D13F / 0x1D13F)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xD141);
    // POP ES (1000_D140 / 0x1D140)
    ES = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD144);
    // MOV DX,word ptr [BP + 0x6] (1000_D141 / 0x1D141)
    DX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0xD147);
    // MOV SI,0x572c (1000_D144 / 0x1D144)
    SI = 0x572C;
    label_1000_D147_1D147:
    CheckExternalEvents(cs8, 0xD148);
    // LODSW SI (1000_D147 / 0x1D147)
    AX = UInt16[DS, (ushort)(SI)];
    SI = (ushort)(SI + Direction16);
    CheckExternalEvents(cs8, 0xD14A);
    // CMP AX,DX (1000_D148 / 0x1D148)
    Alu16.Sub(AX, DX);
    CheckExternalEvents(cs8, 0xD14C);
    // JZ 0x1000:d15c (1000_D14A / 0x1D14A)
    if(ZeroFlag) {
      goto label_1000_D15C_1D15C;
    }
    CheckExternalEvents(cs8, 0xD14D);
    // INC AX (1000_D14C / 0x1D14C)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs8, 0xD14E);
    // XCHG AX,SI (1000_D14D / 0x1D14D)
    (SI, AX) = (AX, SI);
    CheckExternalEvents(cs8, 0xD150);
    // JZ 0x1000:d15c (1000_D14E / 0x1D14E)
    if(ZeroFlag) {
      goto label_1000_D15C_1D15C;
    }
    CheckExternalEvents(cs8, 0xD151);
    // XCHG AX,DI (1000_D150 / 0x1D150)
    (DI, AX) = (AX, DI);
    CheckExternalEvents(cs8, 0xD153);
    // XOR AX,AX (1000_D151 / 0x1D151)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0xD156);
    // MOV CX,0xffff (1000_D153 / 0x1D153)
    CX = 0xFFFF;
    CheckExternalEvents(cs8, 0xD158);
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_D156 / 0x1D156)
      Alu8.Sub(AL, UInt8[ES, (ushort)(DI)]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    CheckExternalEvents(cs8, 0xD15A);
    // MOV SI,DI (1000_D158 / 0x1D158)
    SI = DI;
    CheckExternalEvents(cs8, 0xD15C);
    // JMP 0x1000:d147 (1000_D15A / 0x1D15A)
    goto label_1000_D147_1D147;
    label_1000_D15C_1D15C:
    CheckExternalEvents(cs8, 0xD15D);
    // XCHG AX,SI (1000_D15C / 0x1D15C)
    (SI, AX) = (AX, SI);
    CheckExternalEvents(cs8, 0xD15E);
    // POP DI (1000_D15D / 0x1D15D)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD15F);
    // POP SI (1000_D15E / 0x1D15E)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD161);
    // MOV SP,BP (1000_D15F / 0x1D15F)
    SP = BP;
    CheckExternalEvents(cs8, 0xD162);
    // POP BP (1000_D161 / 0x1D161)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD165);
    // RETF 0x2 (1000_D162 / 0x1D162)
    return FarRet(0x2);
  }
  
  public virtual Action ghidra_guess_1000_D165_1D165(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D165_1D165:
    CheckExternalEvents(cs8, 0xD166);
    // PUSH BP (1000_D165 / 0x1D165)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0xD168);
    // MOV BP,SP (1000_D166 / 0x1D166)
    BP = SP;
    CheckExternalEvents(cs8, 0xD169);
    // PUSH DI (1000_D168 / 0x1D168)
    Stack.Push16(DI);
    CheckExternalEvents(cs8, 0xD16C);
    // PUSH word ptr [BP + 0x6] (1000_D169 / 0x1D169)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs8, 0xD171);
    // CALLF 0x1000:d13a (1000_D16C / 0x1D16C)
    FarCall(cs8, 0xD171, ghidra_guess_1000_D13A_1D13A);
    CheckExternalEvents(cs8, 0xD173);
    // OR AX,AX (1000_D171 / 0x1D171)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs8, 0xD175);
    // JZ 0x1000:d189 (1000_D173 / 0x1D173)
    if(ZeroFlag) {
      goto label_1000_D189_1D189;
    }
    CheckExternalEvents(cs8, 0xD176);
    // XCHG AX,DX (1000_D175 / 0x1D175)
    (DX, AX) = (AX, DX);
    CheckExternalEvents(cs8, 0xD178);
    // MOV DI,DX (1000_D176 / 0x1D176)
    DI = DX;
    CheckExternalEvents(cs8, 0xD17A);
    // XOR AX,AX (1000_D178 / 0x1D178)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0xD17D);
    // MOV CX,0xffff (1000_D17A / 0x1D17A)
    CX = 0xFFFF;
    CheckExternalEvents(cs8, 0xD17F);
    // REPNE
    while (CX != 0) {
      CX--;
      // SCASB ES:DI (1000_D17D / 0x1D17D)
      Alu8.Sub(AL, UInt8[ES, (ushort)(DI)]);
      DI = (ushort)(DI + Direction8);
      if(ZeroFlag != false) {
        break;
      }
    }
    CheckExternalEvents(cs8, 0xD181);
    // NOT CX (1000_D17F / 0x1D17F)
    CX = (ushort)(~CX);
    CheckExternalEvents(cs8, 0xD182);
    // DEC CX (1000_D181 / 0x1D181)
    CX = Alu16.Dec(CX);
    CheckExternalEvents(cs8, 0xD185);
    // MOV BX,0x2 (1000_D182 / 0x1D182)
    BX = 0x2;
    CheckExternalEvents(cs8, 0xD187);
    // MOV AH,0x40 (1000_D185 / 0x1D185)
    AH = 0x40;
    CheckExternalEvents(cs8, 0xD189);
    // INT 0x21 (1000_D187 / 0x1D187)
    Interrupt(0x21);
    label_1000_D189_1D189:
    CheckExternalEvents(cs8, 0xD18A);
    // POP DI (1000_D189 / 0x1D189)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD18C);
    // MOV SP,BP (1000_D18A / 0x1D18A)
    SP = BP;
    CheckExternalEvents(cs8, 0xD18D);
    // POP BP (1000_D18C / 0x1D18C)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD190);
    // RETF 0x2 (1000_D18D / 0x1D18D)
    return FarRet(0x2);
  }
  
  public virtual Action unknown_19EF_32A0_1D190(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_32A0_1D190:
    CheckExternalEvents(cs14, 0x32A2);
    // MOV DX,AX (19EF_32A0 / 0x1D190)
    DX = AX;
    CheckExternalEvents(cs14, 0x32A6);
    // ADD AX,word ptr [0x5286] (19EF_32A2 / 0x1D192)
    // AX += UInt16[DS, 0x5286];
    AX = Alu16.Add(AX, UInt16[DS, 0x5286]);
    CheckExternalEvents(cs14, 0x32A8);
    // JC 0x1000:d1cd (19EF_32A6 / 0x1D196)
    if(CarryFlag) {
      goto label_19EF_32DD_1D1CD;
    }
    CheckExternalEvents(cs14, 0x32AC);
    // CMP word ptr [0x5280],AX (19EF_32A8 / 0x1D198)
    Alu16.Sub(UInt16[DS, 0x5280], AX);
    CheckExternalEvents(cs14, 0x32AE);
    // JNC 0x1000:d1c3 (19EF_32AC / 0x1D19C)
    if(!CarryFlag) {
      goto label_19EF_32D3_1D1C3;
    }
    CheckExternalEvents(cs14, 0x32B1);
    // ADD AX,0xf (19EF_32AE / 0x1D19E)
    // AX += 0xF;
    AX = Alu16.Add(AX, 0xF);
    CheckExternalEvents(cs14, 0x32B2);
    // PUSH AX (19EF_32B1 / 0x1D1A1)
    Stack.Push16(AX);
    CheckExternalEvents(cs14, 0x32B4);
    // RCR AX,0x1 (19EF_32B2 / 0x1D1A2)
    AX = Alu16.Rcr(AX, 0x1);
    CheckExternalEvents(cs14, 0x32B6);
    // MOV CL,0x3 (19EF_32B4 / 0x1D1A4)
    CL = 0x3;
    CheckExternalEvents(cs14, 0x32B8);
    // SHR AX,CL (19EF_32B6 / 0x1D1A6)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs14, 0x32BA);
    // MOV CX,DS (19EF_32B8 / 0x1D1A8)
    CX = DS;
    CheckExternalEvents(cs14, 0x32BE);
    // MOV BX,word ptr [0x52f7] (19EF_32BA / 0x1D1AA)
    BX = UInt16[DS, 0x52F7];
    CheckExternalEvents(cs14, 0x32C0);
    // SUB CX,BX (19EF_32BE / 0x1D1AE)
    CX -= BX;
    CheckExternalEvents(cs14, 0x32C2);
    // ADD AX,CX (19EF_32C0 / 0x1D1B0)
    // AX += CX;
    AX = Alu16.Add(AX, CX);
    CheckExternalEvents(cs14, 0x32C4);
    // MOV ES,BX (19EF_32C2 / 0x1D1B2)
    ES = BX;
    CheckExternalEvents(cs14, 0x32C6);
    // MOV BX,AX (19EF_32C4 / 0x1D1B4)
    BX = AX;
    CheckExternalEvents(cs14, 0x32C8);
    // MOV AH,0x4a (19EF_32C6 / 0x1D1B6)
    AH = 0x4A;
    CheckExternalEvents(cs14, 0x32CA);
    // INT 0x21 (19EF_32C8 / 0x1D1B8)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x32CB);
    // POP AX (19EF_32CA / 0x1D1BA)
    AX = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x32CD);
    // JC 0x1000:d1cd (19EF_32CB / 0x1D1BB)
    if(CarryFlag) {
      goto label_19EF_32DD_1D1CD;
    }
    CheckExternalEvents(cs14, 0x32CF);
    // AND AL,0xf0 (19EF_32CD / 0x1D1BD)
    AL &= 0xF0;
    CheckExternalEvents(cs14, 0x32D0);
    // DEC AX (19EF_32CF / 0x1D1BF)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs14, 0x32D3);
    // MOV [0x5280],AX (19EF_32D0 / 0x1D1C0)
    UInt16[DS, 0x5280] = AX;
    label_19EF_32D3_1D1C3:
    CheckExternalEvents(cs14, 0x32D4);
    // XCHG AX,BP (19EF_32D3 / 0x1D1C3)
    (BP, AX) = (AX, BP);
    CheckExternalEvents(cs14, 0x32D8);
    // MOV BP,word ptr [0x5286] (19EF_32D4 / 0x1D1C4)
    BP = UInt16[DS, 0x5286];
    CheckExternalEvents(cs14, 0x32DC);
    // ADD word ptr [0x5286],DX (19EF_32D8 / 0x1D1C8)
    // UInt16[DS, 0x5286] += DX;
    UInt16[DS, 0x5286] = Alu16.Add(UInt16[DS, 0x5286], DX);
    CheckExternalEvents(cs14, 0x32DD);
    // RET  (19EF_32DC / 0x1D1CC)
    return NearRet();
    label_19EF_32DD_1D1CD:
    CheckExternalEvents(cs14, 0x32DF);
    // MOV AX,DI (19EF_32DD / 0x1D1CD)
    AX = DI;
    CheckExternalEvents(cs14, 0x32E2);
    // JMP 0x1000:cd2b (19EF_32DF / 0x1D1CF)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(entry_19EF_2D82_1CC72, 0x1CD2B - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_D1D2_1D1D2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D1D2_1D1D2:
    CheckExternalEvents(cs8, 0xD1D4);
    // JC 0x1000:d1e7 (1000_D1D2 / 0x1D1D2)
    if(CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0x1D1E7 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xD1D6);
    // XOR AX,AX (1000_D1D4 / 0x1D1D4)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0xD1D8);
    // MOV SP,BP (1000_D1D6 / 0x1D1D6)
    SP = BP;
    CheckExternalEvents(cs8, 0xD1D9);
    // POP BP (1000_D1D8 / 0x1D1D8)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD1DA);
    // RETF  (1000_D1D9 / 0x1D1D9)
    return FarRet();
  }
  
  public virtual Action spice86_imported_label_jump_target_19EF_32F5_1D1E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_32F5_1D1E5:
    CheckExternalEvents(cs14, 0x32F7);
    // JNC 0x1000:d1ee (19EF_32F5 / 0x1D1E5)
    if(!CarryFlag) {
      goto label_19EF_32FE_1D1EE;
    }
    label_19EF_32F7_1D1E7:
    CheckExternalEvents(cs14, 0x32FA);
    // CALL 0x1000:d1f8 (19EF_32F7 / 0x1D1E7)
    NearCall(cs14, 0x32FA, unknown_19EF_3308_1D1F8);
    CheckExternalEvents(cs14, 0x32FD);
    // MOV AX,0xffff (19EF_32FA / 0x1D1EA)
    AX = 0xFFFF;
    CheckExternalEvents(cs14, 0x32FE);
    // CWD  (19EF_32FD / 0x1D1ED)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    label_19EF_32FE_1D1EE:
    CheckExternalEvents(cs14, 0x3300);
    // MOV SP,BP (19EF_32FE / 0x1D1EE)
    SP = BP;
    CheckExternalEvents(cs14, 0x3301);
    // POP BP (19EF_3300 / 0x1D1F0)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x3302);
    // RETF  (19EF_3301 / 0x1D1F1)
    return FarRet();
  }
  
  public virtual Action unknown_19EF_3308_1D1F8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3308_1D1F8:
    CheckExternalEvents(cs14, 0x330B);
    // MOV [0x52fc],AL (19EF_3308 / 0x1D1F8)
    UInt8[DS, 0x52FC] = AL;
    CheckExternalEvents(cs14, 0x330D);
    // OR AH,AH (19EF_330B / 0x1D1FB)
    // AH |= AH;
    AH = Alu8.Or(AH, AH);
    CheckExternalEvents(cs14, 0x330F);
    // JNZ 0x1000:d222 (19EF_330D / 0x1D1FD)
    if(!ZeroFlag) {
      throw FailAsUntested("Would have been a goto but label label_19EF_3332_1D222 does not exist because no instruction was found there that belongs to a function.");
    }
    CheckExternalEvents(cs14, 0x3314);
    // CMP byte ptr [0x52f9],0x3 (19EF_330F / 0x1D1FF)
    Alu8.Sub(UInt8[DS, 0x52F9], 0x3);
    CheckExternalEvents(cs14, 0x3316);
    // JC 0x1000:d213 (19EF_3314 / 0x1D204)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_D213_1D213, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x3318);
    // CMP AL,0x22 (19EF_3316 / 0x1D206)
    Alu8.Sub(AL, 0x22);
    CheckExternalEvents(cs14, 0x331A);
    // JNC 0x1000:d217 (19EF_3318 / 0x1D208)
    if(!CarryFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_1000_D213_1D213, 0x1D217 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x331C);
    // CMP AL,0x20 (19EF_331A / 0x1D20A)
    Alu8.Sub(AL, 0x20);
    CheckExternalEvents(cs14, 0x331E);
    // JC 0x1000:d213 (19EF_331C / 0x1D20C)
    if(CarryFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_D213_1D213, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x3320);
    // MOV AL,0x5 (19EF_331E / 0x1D20E)
    AL = 0x5;
    CheckExternalEvents(cs14, 0x3322);
    // JMP 0x1000:d219 (19EF_3320 / 0x1D210)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_D213_1D213, 0x1D219 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_D213_1D213(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D213_1D213:
    CheckExternalEvents(cs8, 0xD215);
    // CMP AL,0x13 (1000_D213 / 0x1D213)
    Alu8.Sub(AL, 0x13);
    CheckExternalEvents(cs8, 0xD217);
    // JBE 0x1000:d219 (1000_D215 / 0x1D215)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_D219_1D219;
    }
    label_1000_D217_1D217:
    CheckExternalEvents(cs8, 0xD219);
    // MOV AL,0x13 (1000_D217 / 0x1D217)
    AL = 0x13;
    label_1000_D219_1D219:
    CheckExternalEvents(cs8, 0xD21C);
    // MOV BX,0x533a (1000_D219 / 0x1D219)
    BX = 0x533A;
    CheckExternalEvents(cs8, 0xD21D);
    // XLAT BX (1000_D21C / 0x1D21C)
    AL = UInt8[DS, (ushort)(BX + AL)];
    label_1000_D21D_1D21D:
    CheckExternalEvents(cs8, 0xD21E);
    // CBW  (1000_D21D / 0x1D21D)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0xD221);
    // MOV [0x52f1],AX (1000_D21E / 0x1D21E)
    UInt16[DS, 0x52F1] = AX;
    CheckExternalEvents(cs8, 0xD222);
    // RET  (1000_D221 / 0x1D221)
    return NearRet();
  }
  
  public virtual Action unknown_19EF_3336_1D226(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3336_1D226:
    CheckExternalEvents(cs14, 0x3337);
    // PUSH BP (19EF_3336 / 0x1D226)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x3339);
    // MOV BP,SP (19EF_3337 / 0x1D227)
    BP = SP;
    CheckExternalEvents(cs14, 0x333C);
    // MOV BX,word ptr [BP + 0x6] (19EF_3339 / 0x1D229)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x3340);
    // CMP BX,word ptr [0x52fe] (19EF_333C / 0x1D22C)
    Alu16.Sub(BX, UInt16[DS, 0x52FE]);
    CheckExternalEvents(cs14, 0x3342);
    // JC 0x1000:d238 (19EF_3340 / 0x1D230)
    if(CarryFlag) {
      goto label_19EF_3348_1D238;
    }
    CheckExternalEvents(cs14, 0x3345);
    // MOV AX,0x900 (19EF_3342 / 0x1D232)
    AX = 0x900;
    CheckExternalEvents(cs14, 0x3346);
    // STC  (19EF_3345 / 0x1D235)
    CarryFlag = true;
    CheckExternalEvents(cs14, 0x3348);
    // JMP 0x1000:d243 (19EF_3346 / 0x1D236)
    // JMP target is JMP, inlining.
    CheckExternalEvents(cs14, 0x3356);
    // JMP 0x1000:d1d2 (19EF_3353 / 0x1D243)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D1D2_1D1D2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_3348_1D238:
    CheckExternalEvents(cs14, 0x334A);
    // MOV AH,0x3e (19EF_3348 / 0x1D238)
    AH = 0x3E;
    CheckExternalEvents(cs14, 0x334C);
    // INT 0x21 (19EF_334A / 0x1D23A)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x334E);
    // JC 0x1000:d243 (19EF_334C / 0x1D23C)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      CheckExternalEvents(cs14, 0x3356);
      // JMP 0x1000:d1d2 (19EF_3353 / 0x1D243)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_D1D2_1D1D2, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x3353);
    // MOV byte ptr [BX + 0x5300],0x0 (19EF_334E / 0x1D23E)
    UInt8[DS, (ushort)(BX + 0x5300)] = 0x0;
    label_19EF_3353_1D243:
    CheckExternalEvents(cs14, 0x3356);
    // JMP 0x1000:d1d2 (19EF_3353 / 0x1D243)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D1D2_1D1D2, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action unknown_19EF_3356_1D246(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_3356_1D246:
    CheckExternalEvents(cs14, 0x3357);
    // PUSH BP (19EF_3356 / 0x1D246)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x3359);
    // MOV BP,SP (19EF_3357 / 0x1D247)
    BP = SP;
    CheckExternalEvents(cs14, 0x335C);
    // SUB SP,0x4 (19EF_3359 / 0x1D249)
    // SP -= 0x4;
    SP = Alu16.Sub(SP, 0x4);
    CheckExternalEvents(cs14, 0x335F);
    // MOV BX,word ptr [BP + 0x6] (19EF_335C / 0x1D24C)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs14, 0x3363);
    // CMP BX,word ptr [0x52fe] (19EF_335F / 0x1D24F)
    Alu16.Sub(BX, UInt16[DS, 0x52FE]);
    CheckExternalEvents(cs14, 0x3365);
    // JC 0x1000:d25a (19EF_3363 / 0x1D253)
    if(CarryFlag) {
      goto label_19EF_336A_1D25A;
    }
    CheckExternalEvents(cs14, 0x3368);
    // MOV AX,0x900 (19EF_3365 / 0x1D255)
    AX = 0x900;
    CheckExternalEvents(cs14, 0x336A);
    // JMP 0x1000:d284 (19EF_3368 / 0x1D258)
    goto label_19EF_3394_1D284;
    label_19EF_336A_1D25A:
    CheckExternalEvents(cs14, 0x336F);
    // TEST word ptr [BP + 0xa],0x8000 (19EF_336A / 0x1D25A)
    Alu16.And(UInt16[SS, (ushort)(BP + 0xA)], 0x8000);
    CheckExternalEvents(cs14, 0x3371);
    // JZ 0x1000:d2a9 (19EF_336F / 0x1D25F)
    if(ZeroFlag) {
      goto label_19EF_33B9_1D2A9;
    }
    CheckExternalEvents(cs14, 0x3375);
    // CMP word ptr [BP + 0xc],0x0 (19EF_3371 / 0x1D261)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], 0x0);
    CheckExternalEvents(cs14, 0x3377);
    // JZ 0x1000:d281 (19EF_3375 / 0x1D265)
    if(ZeroFlag) {
      goto label_19EF_3391_1D281;
    }
    CheckExternalEvents(cs14, 0x3379);
    // XOR CX,CX (19EF_3377 / 0x1D267)
    // CX ^= CX;
    CX = Alu16.Xor(CX, CX);
    CheckExternalEvents(cs14, 0x337B);
    // MOV DX,CX (19EF_3379 / 0x1D269)
    DX = CX;
    CheckExternalEvents(cs14, 0x337E);
    // MOV AX,0x4201 (19EF_337B / 0x1D26B)
    AX = 0x4201;
    CheckExternalEvents(cs14, 0x3380);
    // INT 0x21 (19EF_337E / 0x1D26E)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x3382);
    // JC 0x1000:d2bd (19EF_3380 / 0x1D270)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      CheckExternalEvents(cs14, 0x33D0);
      // JMP 0x1000:d1e5 (19EF_33CD / 0x1D2BD)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x3387);
    // TEST word ptr [BP + 0xc],0x2 (19EF_3382 / 0x1D272)
    Alu16.And(UInt16[SS, (ushort)(BP + 0xC)], 0x2);
    CheckExternalEvents(cs14, 0x3389);
    // JNZ 0x1000:d287 (19EF_3387 / 0x1D277)
    if(!ZeroFlag) {
      goto label_19EF_3397_1D287;
    }
    CheckExternalEvents(cs14, 0x338C);
    // ADD AX,word ptr [BP + 0x8] (19EF_3389 / 0x1D279)
    // AX += UInt16[SS, (ushort)(BP + 0x8)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs14, 0x338F);
    // ADC DX,word ptr [BP + 0xa] (19EF_338C / 0x1D27C)
    DX = Alu16.Adc(DX, UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs14, 0x3391);
    // JNS 0x1000:d2a9 (19EF_338F / 0x1D27F)
    if(!SignFlag) {
      goto label_19EF_33B9_1D2A9;
    }
    label_19EF_3391_1D281:
    CheckExternalEvents(cs14, 0x3394);
    // MOV AX,0x1600 (19EF_3391 / 0x1D281)
    AX = 0x1600;
    label_19EF_3394_1D284:
    CheckExternalEvents(cs14, 0x3395);
    // STC  (19EF_3394 / 0x1D284)
    CarryFlag = true;
    CheckExternalEvents(cs14, 0x3397);
    // JMP 0x1000:d2bd (19EF_3395 / 0x1D285)
    // JMP target is JMP, inlining.
    CheckExternalEvents(cs14, 0x33D0);
    // JMP 0x1000:d1e5 (19EF_33CD / 0x1D2BD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_3397_1D287:
    CheckExternalEvents(cs14, 0x339A);
    // MOV word ptr [BP + -0x2],DX (19EF_3397 / 0x1D287)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs14, 0x339D);
    // MOV word ptr [BP + -0x4],AX (19EF_339A / 0x1D28A)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs14, 0x339F);
    // MOV DX,CX (19EF_339D / 0x1D28D)
    DX = CX;
    CheckExternalEvents(cs14, 0x33A2);
    // MOV AX,0x4202 (19EF_339F / 0x1D28F)
    AX = 0x4202;
    CheckExternalEvents(cs14, 0x33A4);
    // INT 0x21 (19EF_33A2 / 0x1D292)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x33A7);
    // ADD AX,word ptr [BP + 0x8] (19EF_33A4 / 0x1D294)
    // AX += UInt16[SS, (ushort)(BP + 0x8)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs14, 0x33AA);
    // ADC DX,word ptr [BP + 0xa] (19EF_33A7 / 0x1D297)
    DX = Alu16.Adc(DX, UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs14, 0x33AC);
    // JNS 0x1000:d2a9 (19EF_33AA / 0x1D29A)
    if(!SignFlag) {
      goto label_19EF_33B9_1D2A9;
    }
    CheckExternalEvents(cs14, 0x33AF);
    // MOV CX,word ptr [BP + -0x2] (19EF_33AC / 0x1D29C)
    CX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs14, 0x33B2);
    // MOV DX,word ptr [BP + -0x4] (19EF_33AF / 0x1D29F)
    DX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs14, 0x33B5);
    // MOV AX,0x4200 (19EF_33B2 / 0x1D2A2)
    AX = 0x4200;
    CheckExternalEvents(cs14, 0x33B7);
    // INT 0x21 (19EF_33B5 / 0x1D2A5)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x33B9);
    // JMP 0x1000:d281 (19EF_33B7 / 0x1D2A7)
    goto label_19EF_3391_1D281;
    label_19EF_33B9_1D2A9:
    CheckExternalEvents(cs14, 0x33BC);
    // MOV DX,word ptr [BP + 0x8] (19EF_33B9 / 0x1D2A9)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs14, 0x33BF);
    // MOV CX,word ptr [BP + 0xa] (19EF_33BC / 0x1D2AC)
    CX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x33C2);
    // MOV AL,byte ptr [BP + 0xc] (19EF_33BF / 0x1D2AF)
    AL = UInt8[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs14, 0x33C4);
    // MOV AH,0x42 (19EF_33C2 / 0x1D2B2)
    AH = 0x42;
    CheckExternalEvents(cs14, 0x33C6);
    // INT 0x21 (19EF_33C4 / 0x1D2B4)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x33C8);
    // JC 0x1000:d2bd (19EF_33C6 / 0x1D2B6)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      CheckExternalEvents(cs14, 0x33D0);
      // JMP 0x1000:d1e5 (19EF_33CD / 0x1D2BD)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x33CD);
    // AND byte ptr [BX + 0x5300],0xfd (19EF_33C8 / 0x1D2B8)
    // UInt8[DS, (ushort)(BX + 0x5300)] &= 0xFD;
    UInt8[DS, (ushort)(BX + 0x5300)] = Alu8.And(UInt8[DS, (ushort)(BX + 0x5300)], 0xFD);
    label_19EF_33CD_1D2BD:
    CheckExternalEvents(cs14, 0x33D0);
    // JMP 0x1000:d1e5 (19EF_33CD / 0x1D2BD)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action unknown_19EF_33D0_1D2C0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_19EF_33D0_1D2C0:
    CheckExternalEvents(cs14, 0x33D1);
    // PUSH BP (19EF_33D0 / 0x1D2C0)
    Stack.Push16(BP);
    CheckExternalEvents(cs14, 0x33D3);
    // MOV BP,SP (19EF_33D1 / 0x1D2C1)
    BP = SP;
    CheckExternalEvents(cs14, 0x33D6);
    // SUB SP,0x4 (19EF_33D3 / 0x1D2C3)
    SP -= 0x4;
    CheckExternalEvents(cs14, 0x33D8);
    // XOR BH,BH (19EF_33D6 / 0x1D2C6)
    // BH ^= BH;
    BH = Alu8.Xor(BH, BH);
    CheckExternalEvents(cs14, 0x33DB);
    // MOV byte ptr [BP + -0x2],BH (19EF_33D8 / 0x1D2C8)
    UInt8[SS, (ushort)(BP - 0x2)] = BH;
    CheckExternalEvents(cs14, 0x33DE);
    // MOV AX,word ptr [BP + 0xa] (19EF_33DB / 0x1D2CB)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x33E0);
    // MOV CX,AX (19EF_33DE / 0x1D2CE)
    CX = AX;
    CheckExternalEvents(cs14, 0x33E4);
    // MOV byte ptr [BP + -0x4],0x0 (19EF_33E0 / 0x1D2D0)
    UInt8[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs14, 0x33E7);
    // TEST AX,0x8000 (19EF_33E4 / 0x1D2D4)
    Alu16.And(AX, 0x8000);
    CheckExternalEvents(cs14, 0x33E9);
    // JNZ 0x1000:d2e9 (19EF_33E7 / 0x1D2D7)
    if(!ZeroFlag) {
      goto label_19EF_33F9_1D2E9;
    }
    CheckExternalEvents(cs14, 0x33EC);
    // TEST AX,0x4000 (19EF_33E9 / 0x1D2D9)
    Alu16.And(AX, 0x4000);
    CheckExternalEvents(cs14, 0x33EE);
    // JNZ 0x1000:d2e5 (19EF_33EC / 0x1D2DC)
    if(!ZeroFlag) {
      goto label_19EF_33F5_1D2E5;
    }
    CheckExternalEvents(cs14, 0x33F3);
    // TEST byte ptr [0x534f],0x80 (19EF_33EE / 0x1D2DE)
    Alu8.And(UInt8[DS, 0x534F], 0x80);
    CheckExternalEvents(cs14, 0x33F5);
    // JNZ 0x1000:d2e9 (19EF_33F3 / 0x1D2E3)
    if(!ZeroFlag) {
      goto label_19EF_33F9_1D2E9;
    }
    label_19EF_33F5_1D2E5:
    CheckExternalEvents(cs14, 0x33F9);
    // MOV byte ptr [BP + -0x4],0x80 (19EF_33F5 / 0x1D2E5)
    UInt8[SS, (ushort)(BP - 0x4)] = 0x80;
    label_19EF_33F9_1D2E9:
    CheckExternalEvents(cs14, 0x33FA);
    // PUSH DS (19EF_33F9 / 0x1D2E9)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x33FD);
    // LDS DX,[BP + 0x6] (19EF_33FA / 0x1D2EA)
    DX = UInt16[SS, (ushort)(BP + 0x6)];
    DS = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs14, 0x33FF);
    // AND AL,0x3 (19EF_33FD / 0x1D2ED)
    // AL &= 0x3;
    AL = Alu8.And(AL, 0x3);
    CheckExternalEvents(cs14, 0x3401);
    // OR AL,BH (19EF_33FF / 0x1D2EF)
    // AL |= BH;
    AL = Alu8.Or(AL, BH);
    CheckExternalEvents(cs14, 0x3403);
    // MOV AH,0x3d (19EF_3401 / 0x1D2F1)
    AH = 0x3D;
    CheckExternalEvents(cs14, 0x3405);
    // INT 0x21 (19EF_3403 / 0x1D2F3)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x3406);
    // POP DS (19EF_3405 / 0x1D2F5)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x3408);
    // JNC 0x1000:d30a (19EF_3406 / 0x1D2F6)
    if(!CarryFlag) {
      goto label_19EF_341A_1D30A;
    }
    CheckExternalEvents(cs14, 0x340B);
    // CMP AX,0x2 (19EF_3408 / 0x1D2F8)
    Alu16.Sub(AX, 0x2);
    CheckExternalEvents(cs14, 0x340D);
    // JNZ 0x1000:d306 (19EF_340B / 0x1D2FB)
    if(!ZeroFlag) {
      goto label_19EF_3416_1D306;
    }
    CheckExternalEvents(cs14, 0x3411);
    // TEST CX,0x100 (19EF_340D / 0x1D2FD)
    Alu16.And(CX, 0x100);
    CheckExternalEvents(cs14, 0x3413);
    // JZ 0x1000:d306 (19EF_3411 / 0x1D301)
    if(ZeroFlag) {
      goto label_19EF_3416_1D306;
    }
    CheckExternalEvents(cs14, 0x3416);
    // JMP 0x1000:d3a9 (19EF_3413 / 0x1D303)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_D3A9_1D3A9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_3416_1D306:
    CheckExternalEvents(cs14, 0x3417);
    // STC  (19EF_3416 / 0x1D306)
    CarryFlag = true;
    CheckExternalEvents(cs14, 0x341A);
    // JMP 0x1000:d1e5 (19EF_3417 / 0x1D307)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_341A_1D30A:
    CheckExternalEvents(cs14, 0x341B);
    // XCHG AX,BX (19EF_341A / 0x1D30A)
    (BX, AX) = (AX, BX);
    CheckExternalEvents(cs14, 0x341D);
    // MOV AX,CX (19EF_341B / 0x1D30B)
    AX = CX;
    CheckExternalEvents(cs14, 0x3420);
    // AND AX,0x500 (19EF_341D / 0x1D30D)
    AX &= 0x500;
    CheckExternalEvents(cs14, 0x3423);
    // CMP AX,0x500 (19EF_3420 / 0x1D310)
    Alu16.Sub(AX, 0x500);
    CheckExternalEvents(cs14, 0x3425);
    // JNZ 0x1000:d31e (19EF_3423 / 0x1D313)
    if(!ZeroFlag) {
      goto label_19EF_342E_1D31E;
    }
    CheckExternalEvents(cs14, 0x3427);
    // MOV AH,0x3e (19EF_3425 / 0x1D315)
    AH = 0x3E;
    CheckExternalEvents(cs14, 0x3429);
    // INT 0x21 (19EF_3427 / 0x1D317)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x342C);
    // MOV AX,0x1100 (19EF_3429 / 0x1D319)
    AX = 0x1100;
    CheckExternalEvents(cs14, 0x342E);
    // JMP 0x1000:d306 (19EF_342C / 0x1D31C)
    goto label_19EF_3416_1D306;
    label_19EF_342E_1D31E:
    CheckExternalEvents(cs14, 0x3432);
    // MOV byte ptr [BP + -0x3],0x1 (19EF_342E / 0x1D31E)
    UInt8[SS, (ushort)(BP - 0x3)] = 0x1;
    CheckExternalEvents(cs14, 0x3435);
    // MOV AX,0x4400 (19EF_3432 / 0x1D322)
    AX = 0x4400;
    CheckExternalEvents(cs14, 0x3437);
    // INT 0x21 (19EF_3435 / 0x1D325)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x343A);
    // TEST DL,0x80 (19EF_3437 / 0x1D327)
    Alu8.And(DL, 0x80);
    CheckExternalEvents(cs14, 0x343C);
    // JZ 0x1000:d330 (19EF_343A / 0x1D32A)
    if(ZeroFlag) {
      goto label_19EF_3440_1D330;
    }
    CheckExternalEvents(cs14, 0x3440);
    // OR byte ptr [BP + -0x4],0x40 (19EF_343C / 0x1D32C)
    UInt8[SS, (ushort)(BP - 0x4)] |= 0x40;
    label_19EF_3440_1D330:
    CheckExternalEvents(cs14, 0x3444);
    // TEST byte ptr [BP + -0x4],0x40 (19EF_3440 / 0x1D330)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x4)], 0x40);
    CheckExternalEvents(cs14, 0x3446);
    // JZ 0x1000:d339 (19EF_3444 / 0x1D334)
    if(ZeroFlag) {
      goto label_19EF_3449_1D339;
    }
    CheckExternalEvents(cs14, 0x3449);
    // JMP 0x1000:d416 (19EF_3446 / 0x1D336)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_D3A9_1D3A9, 0x1D416 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_3449_1D339:
    CheckExternalEvents(cs14, 0x344C);
    // MOV AX,word ptr [BP + 0xa] (19EF_3449 / 0x1D339)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs14, 0x344F);
    // TEST AX,0x200 (19EF_344C / 0x1D33C)
    Alu16.And(AX, 0x200);
    CheckExternalEvents(cs14, 0x3451);
    // JZ 0x1000:d360 (19EF_344F / 0x1D33F)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_D360_1D360, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs14, 0x3454);
    // TEST AX,0x3 (19EF_3451 / 0x1D341)
    Alu16.And(AX, 0x3);
    CheckExternalEvents(cs14, 0x3456);
    // JZ 0x1000:d34f (19EF_3454 / 0x1D344)
    if(ZeroFlag) {
      goto label_19EF_345F_1D34F;
    }
    CheckExternalEvents(cs14, 0x3458);
    // XOR CX,CX (19EF_3456 / 0x1D346)
    // CX ^= CX;
    CX = Alu16.Xor(CX, CX);
    CheckExternalEvents(cs14, 0x345A);
    // MOV AH,0x40 (19EF_3458 / 0x1D348)
    AH = 0x40;
    CheckExternalEvents(cs14, 0x345C);
    // INT 0x21 (19EF_345A / 0x1D34A)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x345F);
    // JMP 0x1000:d416 (19EF_345C / 0x1D34C)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_D3A9_1D3A9, 0x1D416 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_19EF_345F_1D34F:
    CheckExternalEvents(cs14, 0x3461);
    // MOV AH,0x3e (19EF_345F / 0x1D34F)
    AH = 0x3E;
    CheckExternalEvents(cs14, 0x3463);
    // INT 0x21 (19EF_3461 / 0x1D351)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x3464);
    // PUSH DS (19EF_3463 / 0x1D353)
    Stack.Push16(DS);
    CheckExternalEvents(cs14, 0x3467);
    // LDS DX,[BP + 0x6] (19EF_3464 / 0x1D354)
    DX = UInt16[SS, (ushort)(BP + 0x6)];
    DS = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs14, 0x346A);
    // MOV AX,0x4300 (19EF_3467 / 0x1D357)
    AX = 0x4300;
    CheckExternalEvents(cs14, 0x346C);
    // INT 0x21 (19EF_346A / 0x1D35A)
    Interrupt(0x21);
    CheckExternalEvents(cs14, 0x346D);
    // POP DS (19EF_346C / 0x1D35C)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs14, 0x346F);
    // JMP 0x1000:d3c6 (19EF_346D / 0x1D35D)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_D3A9_1D3A9, 0x1D3C6 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_D360_1D360(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_D360_1D360:
    CheckExternalEvents(cs8, 0xD364);
    // TEST byte ptr [BP + -0x4],0x80 (1000_D360 / 0x1D360)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x4)], 0x80);
    CheckExternalEvents(cs8, 0xD366);
    // JNZ 0x1000:d369 (1000_D364 / 0x1D364)
    if(!ZeroFlag) {
      goto label_1000_D369_1D369;
    }
    CheckExternalEvents(cs8, 0xD369);
    // JMP 0x1000:d416 (1000_D366 / 0x1D366)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_D3A9_1D3A9, 0x1D416 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D369_1D369:
    CheckExternalEvents(cs8, 0xD36C);
    // TEST AX,0x2 (1000_D369 / 0x1D369)
    Alu16.And(AX, 0x2);
    CheckExternalEvents(cs8, 0xD36E);
    // JNZ 0x1000:d371 (1000_D36C / 0x1D36C)
    if(!ZeroFlag) {
      goto label_1000_D371_1D371;
    }
    CheckExternalEvents(cs8, 0xD371);
    // JMP 0x1000:d416 (1000_D36E / 0x1D36E)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_D3A9_1D3A9, 0x1D416 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D371_1D371:
    CheckExternalEvents(cs8, 0xD374);
    // MOV CX,0xffff (1000_D371 / 0x1D371)
    CX = 0xFFFF;
    CheckExternalEvents(cs8, 0xD376);
    // MOV DX,CX (1000_D374 / 0x1D374)
    DX = CX;
    CheckExternalEvents(cs8, 0xD379);
    // MOV AX,0x4202 (1000_D376 / 0x1D376)
    AX = 0x4202;
    CheckExternalEvents(cs8, 0xD37B);
    // INT 0x21 (1000_D379 / 0x1D379)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xD37D);
    // NEG CX (1000_D37B / 0x1D37B)
    CX = Alu16.Sub(0, CX);
    CheckExternalEvents(cs8, 0xD380);
    // LEA DX,[BP + -0x1] (1000_D37D / 0x1D37D)
    DX = (ushort)(BP - 0x1);
    CheckExternalEvents(cs8, 0xD382);
    // MOV AH,0x3f (1000_D380 / 0x1D380)
    AH = 0x3F;
    CheckExternalEvents(cs8, 0xD384);
    // INT 0x21 (1000_D382 / 0x1D382)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xD386);
    // OR AX,AX (1000_D384 / 0x1D384)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs8, 0xD388);
    // JZ 0x1000:d39d (1000_D386 / 0x1D386)
    if(ZeroFlag) {
      goto label_1000_D39D_1D39D;
    }
    CheckExternalEvents(cs8, 0xD38C);
    // CMP byte ptr [BP + -0x1],0x1a (1000_D388 / 0x1D388)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x1)], 0x1A);
    CheckExternalEvents(cs8, 0xD38E);
    // JNZ 0x1000:d39d (1000_D38C / 0x1D38C)
    if(!ZeroFlag) {
      goto label_1000_D39D_1D39D;
    }
    CheckExternalEvents(cs8, 0xD390);
    // NEG CX (1000_D38E / 0x1D38E)
    CX = Alu16.Sub(0, CX);
    CheckExternalEvents(cs8, 0xD392);
    // MOV DX,CX (1000_D390 / 0x1D390)
    DX = CX;
    CheckExternalEvents(cs8, 0xD395);
    // MOV AX,0x4202 (1000_D392 / 0x1D392)
    AX = 0x4202;
    CheckExternalEvents(cs8, 0xD397);
    // INT 0x21 (1000_D395 / 0x1D395)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xD399);
    // XOR CX,CX (1000_D397 / 0x1D397)
    // CX ^= CX;
    CX = Alu16.Xor(CX, CX);
    CheckExternalEvents(cs8, 0xD39B);
    // MOV AH,0x40 (1000_D399 / 0x1D399)
    AH = 0x40;
    CheckExternalEvents(cs8, 0xD39D);
    // INT 0x21 (1000_D39B / 0x1D39B)
    Interrupt(0x21);
    label_1000_D39D_1D39D:
    CheckExternalEvents(cs8, 0xD39F);
    // XOR CX,CX (1000_D39D / 0x1D39D)
    // CX ^= CX;
    CX = Alu16.Xor(CX, CX);
    CheckExternalEvents(cs8, 0xD3A1);
    // MOV DX,CX (1000_D39F / 0x1D39F)
    DX = CX;
    CheckExternalEvents(cs8, 0xD3A4);
    // MOV AX,0x4200 (1000_D3A1 / 0x1D3A1)
    AX = 0x4200;
    CheckExternalEvents(cs8, 0xD3A6);
    // INT 0x21 (1000_D3A4 / 0x1D3A4)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xD3A8);
    // JMP 0x1000:d416 (1000_D3A6 / 0x1D3A6)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_1000_D3A9_1D3A9, 0x1D416 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_D3A9_1D3A9(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x1D416: goto label_1000_D416_1D416;break; // Target of external jump from 0x1D366
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_1000_D3A9_1D3A9:
    CheckExternalEvents(cs8, 0xD3AD);
    // MOV byte ptr [BP + -0x3],0x0 (1000_D3A9 / 0x1D3A9)
    UInt8[SS, (ushort)(BP - 0x3)] = 0x0;
    CheckExternalEvents(cs8, 0xD3B0);
    // MOV CX,word ptr [BP + 0xc] (1000_D3AD / 0x1D3AD)
    CX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0xD3B3);
    // CALL 0x1000:d45f (1000_D3B0 / 0x1D3B0)
    NearCall(cs8, 0xD3B3, ghidra_guess_1000_D45F_1D45F);
    CheckExternalEvents(cs8, 0xD3B6);
    // MOV word ptr [BP + 0xc],CX (1000_D3B3 / 0x1D3B3)
    UInt16[SS, (ushort)(BP + 0xC)] = CX;
    CheckExternalEvents(cs8, 0xD3BA);
    // TEST byte ptr [BP + -0x2],0xff (1000_D3B6 / 0x1D3B6)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x2)], 0xFF);
    CheckExternalEvents(cs8, 0xD3BC);
    // JNZ 0x1000:d3c3 (1000_D3BA / 0x1D3BA)
    if(!ZeroFlag) {
      goto label_1000_D3C3_1D3C3;
    }
    CheckExternalEvents(cs8, 0xD3C1);
    // TEST word ptr [BP + 0xa],0x2 (1000_D3BC / 0x1D3BC)
    Alu16.And(UInt16[SS, (ushort)(BP + 0xA)], 0x2);
    CheckExternalEvents(cs8, 0xD3C3);
    // JNZ 0x1000:d3c6 (1000_D3C1 / 0x1D3C1)
    if(!ZeroFlag) {
      goto label_1000_D3C6_1D3C6;
    }
    label_1000_D3C3_1D3C3:
    CheckExternalEvents(cs8, 0xD3C6);
    // AND CL,0xfe (1000_D3C3 / 0x1D3C3)
    // CL &= 0xFE;
    CL = Alu8.And(CL, 0xFE);
    label_1000_D3C6_1D3C6:
    CheckExternalEvents(cs8, 0xD3C7);
    // PUSH DS (1000_D3C6 / 0x1D3C6)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xD3CA);
    // LDS DX,[BP + 0x6] (1000_D3C7 / 0x1D3C7)
    DX = UInt16[SS, (ushort)(BP + 0x6)];
    DS = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs8, 0xD3CC);
    // MOV AH,0x3c (1000_D3CA / 0x1D3CA)
    AH = 0x3C;
    CheckExternalEvents(cs8, 0xD3CE);
    // INT 0x21 (1000_D3CC / 0x1D3CC)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xD3CF);
    // POP DS (1000_D3CE / 0x1D3CE)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD3D1);
    // JNC 0x1000:d3d4 (1000_D3CF / 0x1D3CF)
    if(!CarryFlag) {
      goto label_1000_D3D4_1D3D4;
    }
    label_1000_D3D1_1D3D1:
    CheckExternalEvents(cs8, 0xD3D4);
    // JMP 0x1000:d1e5 (1000_D3D1 / 0x1D3D1)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D3D4_1D3D4:
    CheckExternalEvents(cs8, 0xD3D5);
    // XCHG AX,BX (1000_D3D4 / 0x1D3D4)
    (BX, AX) = (AX, BX);
    CheckExternalEvents(cs8, 0xD3D9);
    // TEST byte ptr [BP + -0x2],0xff (1000_D3D5 / 0x1D3D5)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x2)], 0xFF);
    CheckExternalEvents(cs8, 0xD3DB);
    // JNZ 0x1000:d3e2 (1000_D3D9 / 0x1D3D9)
    if(!ZeroFlag) {
      goto label_1000_D3E2_1D3E2;
    }
    CheckExternalEvents(cs8, 0xD3E0);
    // TEST word ptr [BP + 0xa],0x2 (1000_D3DB / 0x1D3DB)
    Alu16.And(UInt16[SS, (ushort)(BP + 0xA)], 0x2);
    CheckExternalEvents(cs8, 0xD3E2);
    // JNZ 0x1000:d416 (1000_D3E0 / 0x1D3E0)
    if(!ZeroFlag) {
      goto label_1000_D416_1D416;
    }
    label_1000_D3E2_1D3E2:
    CheckExternalEvents(cs8, 0xD3E4);
    // MOV AH,0x3e (1000_D3E2 / 0x1D3E2)
    AH = 0x3E;
    CheckExternalEvents(cs8, 0xD3E6);
    // INT 0x21 (1000_D3E4 / 0x1D3E4)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xD3E9);
    // MOV AL,byte ptr [BP + 0xa] (1000_D3E6 / 0x1D3E6)
    AL = UInt8[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0xD3EB);
    // AND AL,0x3 (1000_D3E9 / 0x1D3E9)
    // AL &= 0x3;
    AL = Alu8.And(AL, 0x3);
    CheckExternalEvents(cs8, 0xD3EE);
    // OR AL,byte ptr [BP + -0x2] (1000_D3EB / 0x1D3EB)
    // AL |= UInt8[SS, (ushort)(BP - 0x2)];
    AL = Alu8.Or(AL, UInt8[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs8, 0xD3EF);
    // PUSH DS (1000_D3EE / 0x1D3EE)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xD3F2);
    // LDS DX,[BP + 0x6] (1000_D3EF / 0x1D3EF)
    DX = UInt16[SS, (ushort)(BP + 0x6)];
    DS = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs8, 0xD3F4);
    // MOV AH,0x3d (1000_D3F2 / 0x1D3F2)
    AH = 0x3D;
    CheckExternalEvents(cs8, 0xD3F6);
    // INT 0x21 (1000_D3F4 / 0x1D3F4)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xD3F7);
    // POP DS (1000_D3F6 / 0x1D3F6)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD3F9);
    // JC 0x1000:d3d1 (1000_D3F7 / 0x1D3F7)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      CheckExternalEvents(cs8, 0xD3D4);
      // JMP 0x1000:d1e5 (1000_D3D1 / 0x1D3D1)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs8, 0xD3FA);
    // XCHG AX,BX (1000_D3F9 / 0x1D3F9)
    (BX, AX) = (AX, BX);
    CheckExternalEvents(cs8, 0xD3FE);
    // TEST byte ptr [BP + -0x3],0x1 (1000_D3FA / 0x1D3FA)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x3)], 0x1);
    CheckExternalEvents(cs8, 0xD400);
    // JNZ 0x1000:d416 (1000_D3FE / 0x1D3FE)
    if(!ZeroFlag) {
      goto label_1000_D416_1D416;
    }
    CheckExternalEvents(cs8, 0xD405);
    // TEST word ptr [BP + 0xc],0x1 (1000_D400 / 0x1D400)
    Alu16.And(UInt16[SS, (ushort)(BP + 0xC)], 0x1);
    CheckExternalEvents(cs8, 0xD407);
    // JZ 0x1000:d416 (1000_D405 / 0x1D405)
    if(ZeroFlag) {
      goto label_1000_D416_1D416;
    }
    CheckExternalEvents(cs8, 0xD40A);
    // OR CL,0x1 (1000_D407 / 0x1D407)
    // CL |= 0x1;
    CL = Alu8.Or(CL, 0x1);
    CheckExternalEvents(cs8, 0xD40B);
    // PUSH DS (1000_D40A / 0x1D40A)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xD40E);
    // LDS DX,[BP + 0x6] (1000_D40B / 0x1D40B)
    DX = UInt16[SS, (ushort)(BP + 0x6)];
    DS = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs8, 0xD411);
    // MOV AX,0x4301 (1000_D40E / 0x1D40E)
    AX = 0x4301;
    CheckExternalEvents(cs8, 0xD413);
    // INT 0x21 (1000_D411 / 0x1D411)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xD414);
    // POP DS (1000_D413 / 0x1D413)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD416);
    // JC 0x1000:d3d1 (1000_D414 / 0x1D414)
    if(CarryFlag) {
      // JC target is JMP, inlining.
      CheckExternalEvents(cs8, 0xD3D4);
      // JMP 0x1000:d1e5 (1000_D3D1 / 0x1D3D1)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(spice86_imported_label_jump_target_19EF_32F5_1D1E5, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    label_1000_D416_1D416:
    CheckExternalEvents(cs8, 0xD41A);
    // TEST byte ptr [BP + -0x4],0x40 (1000_D416 / 0x1D416)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x4)], 0x40);
    CheckExternalEvents(cs8, 0xD41C);
    // JNZ 0x1000:d45b (1000_D41A / 0x1D41A)
    if(!ZeroFlag) {
      goto label_1000_D45B_1D45B;
    }
    CheckExternalEvents(cs8, 0xD41D);
    // PUSH DS (1000_D41C / 0x1D41C)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0xD420);
    // LDS DX,[BP + 0x6] (1000_D41D / 0x1D41D)
    DX = UInt16[SS, (ushort)(BP + 0x6)];
    DS = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs8, 0xD423);
    // MOV AX,0x4300 (1000_D420 / 0x1D420)
    AX = 0x4300;
    CheckExternalEvents(cs8, 0xD425);
    // INT 0x21 (1000_D423 / 0x1D423)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xD426);
    // POP DS (1000_D425 / 0x1D425)
    DS = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD428);
    // MOV AX,CX (1000_D426 / 0x1D426)
    AX = CX;
    CheckExternalEvents(cs8, 0xD42A);
    // XOR CL,CL (1000_D428 / 0x1D428)
    CL = 0;
    CheckExternalEvents(cs8, 0xD42D);
    // AND AX,0x1 (1000_D42A / 0x1D42A)
    // AX &= 0x1;
    AX = Alu16.And(AX, 0x1);
    CheckExternalEvents(cs8, 0xD42F);
    // JZ 0x1000:d431 (1000_D42D / 0x1D42D)
    if(ZeroFlag) {
      goto label_1000_D431_1D431;
    }
    CheckExternalEvents(cs8, 0xD431);
    // MOV CL,0x10 (1000_D42F / 0x1D42F)
    CL = 0x10;
    label_1000_D431_1D431:
    CheckExternalEvents(cs8, 0xD436);
    // TEST word ptr [BP + 0xa],0x8 (1000_D431 / 0x1D431)
    Alu16.And(UInt16[SS, (ushort)(BP + 0xA)], 0x8);
    CheckExternalEvents(cs8, 0xD438);
    // JZ 0x1000:d43b (1000_D436 / 0x1D436)
    if(ZeroFlag) {
      goto label_1000_D43B_1D43B;
    }
    CheckExternalEvents(cs8, 0xD43B);
    // OR CL,0x20 (1000_D438 / 0x1D438)
    CL |= 0x20;
    label_1000_D43B_1D43B:
    CheckExternalEvents(cs8, 0xD43F);
    // CMP BX,word ptr [0x52fe] (1000_D43B / 0x1D43B)
    Alu16.Sub(BX, UInt16[DS, 0x52FE]);
    CheckExternalEvents(cs8, 0xD441);
    // JC 0x1000:d44b (1000_D43F / 0x1D43F)
    if(CarryFlag) {
      goto label_1000_D44B_1D44B;
    }
    CheckExternalEvents(cs8, 0xD443);
    // MOV AH,0x3e (1000_D441 / 0x1D441)
    AH = 0x3E;
    CheckExternalEvents(cs8, 0xD445);
    // INT 0x21 (1000_D443 / 0x1D443)
    Interrupt(0x21);
    CheckExternalEvents(cs8, 0xD448);
    // MOV AX,0x1800 (1000_D445 / 0x1D445)
    AX = 0x1800;
    CheckExternalEvents(cs8, 0xD44B);
    // JMP 0x1000:d306 (1000_D448 / 0x1D448)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(unknown_19EF_33D0_1D2C0, 0x1D306 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_D44B_1D44B:
    CheckExternalEvents(cs8, 0xD44E);
    // OR CL,byte ptr [BP + -0x4] (1000_D44B / 0x1D44B)
    // CL |= UInt8[SS, (ushort)(BP - 0x4)];
    CL = Alu8.Or(CL, UInt8[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs8, 0xD451);
    // OR CL,0x1 (1000_D44E / 0x1D44E)
    // CL |= 0x1;
    CL = Alu8.Or(CL, 0x1);
    CheckExternalEvents(cs8, 0xD455);
    // MOV byte ptr [BX + 0x5300],CL (1000_D451 / 0x1D451)
    UInt8[DS, (ushort)(BX + 0x5300)] = CL;
    CheckExternalEvents(cs8, 0xD457);
    // MOV AX,BX (1000_D455 / 0x1D455)
    AX = BX;
    CheckExternalEvents(cs8, 0xD459);
    // MOV SP,BP (1000_D457 / 0x1D457)
    SP = BP;
    CheckExternalEvents(cs8, 0xD45A);
    // POP BP (1000_D459 / 0x1D459)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0xD45B);
    // RETF  (1000_D45A / 0x1D45A)
    return FarRet();
    label_1000_D45B_1D45B:
    CheckExternalEvents(cs8, 0xD45D);
    // XOR CL,CL (1000_D45B / 0x1D45B)
    // CL ^= CL;
    CL = Alu8.Xor(CL, CL);
    CheckExternalEvents(cs8, 0xD45F);
    // JMP 0x1000:d43b (1000_D45D / 0x1D45D)
    goto label_1000_D43B_1D43B;
  }
  
}
