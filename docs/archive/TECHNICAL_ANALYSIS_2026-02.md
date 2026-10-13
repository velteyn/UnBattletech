# Technical Analysis of BattleTech: The Crescent Hawk's Inception

## Identified Destination Maps

- **MAP1.MTP**: Training Center (Start location).
- **MAP2.MTP**: Main City (Chameleon training, Arena).
- **MAP3.MTP**: Small outpost/village.
- **MAP4.MTP**: Large industrial complex / city.
- **MAP5.MTP**: Medium settlement.
- **MAP6.MTP**: Medium settlement.
- **MAP7.MTP**: Medium settlement.
- **MAP8.MTP**: Medium settlement.
- **MAP9.MTP**: Outpost.
- **MAP10.MTP**: Medium settlement.
- **MAP11.MTP**: Destroyed Training Center (Post-attack).
- **MAP12.MTP**: Large city/base.
- **MAP13.MTP**: Medium settlement.
- **MAP14.MTP**: Cave / Underground complex.

## Combat System Analysis

### 1. Combat Mode & Menu System
**Mode Switching Logic**
- **Global Mode Variable**: `0xB764` (16-bit word).
    - `0`: **Map Mode** (Standard exploration).
    - `1`: **Combat Mode** (Tactical grid battle).
    - `2`: **Transition/Initialization**.
- **Mode Setter**: `unknown_19EF_2CE1_1CBD1` (in `GeneratedCode21.cs`).
    - Writes to `0xB764`.
    - Controls video memory segment switching:
        - Map Mode uses `0xA000` (VGA Graphics).
        - Combat Mode uses `0xB800` (Text/Overlay Mode) for the combat grid.

**Combat Menu System**
- **Logic Location**: `GeneratedCode12.cs`.
- **String Printing**: Function `unknown_17C6_03F5_18055` (in `GeneratedCode15.cs`) is used to display menu options.
- **Menu Handling**: The menu loop validates available actions based on unit state (Heat, AP) and displays relevant options.
- **Combat Strings Data**:
    - Located in Segment `0x3EDB` (see `UNBTECH_3EDB_0000.asm`).
    - **Mapped Offsets**:
        - `0x3A40`: "The computer is currently moving this unit" (AI Turn)
        - `0x3A6F`: "Walk" (Menu Option)
        - `0x3A74`: "Run" (Menu Option)
        - `0x3A78`: "Jump" (Menu Option)
        - `0x3A7D`: "Kick" (Menu Option)
        - `0x3A82`: "Punch" (Menu Option)
        - `0x3A88`: "Use" (Menu Option)
        - `0x3AA1`: "Next Unit" (Menu Option)
        - `0x3AAC`: "Flee" (Menu Option)
        - `0x3AB1`: "Begin Fight" (Combat Start)
        - `0x3ABC`: "Move" (Action Prompt)
        - `0x3B06`: Data Table (Menu Configuration)

**AI & Computer Turn Logic**
- **Indicator**: String `0x3A40` ("The computer is currently moving this unit").
- **Logic Location**: `GeneratedCode22.cs` checks for this string offset.
- **Turn Processor**: `unknown_18AD_0259_18D29` (referenced in `GeneratedCode12.cs` and `GeneratedCode16.cs`) appears to handle AI/Turn progression.

### 1. Combat Mode & Entry
- **Mode Variable**: `0xB764` (Global State)
    - `0`: Map / Exploration Mode
    - `1`: Combat Mode
    - `2`: Mode Transition (detected in `GeneratedCode19.cs`)
- **Entry Point**: `GeneratedCode21.cs` sets `0xB764 = 1` to trigger combat.
- **Combat Loop**: `GeneratedCode20.cs` and `GeneratedCode13.cs` contain the main loops checking `0xB764`.

### Combat Menu Mapping
**String Offsets** (Segment `0x3EDB`):
- `0x3A6F`: **Walk** (Accessed in `GeneratedCode12.cs`)
- `0x3A74`: **Run**
- `0x3A78`: **Jump**
- `0x3A7D`: **Use Weapons**
- `0x3A89`: **Kick**
- `0x3A8E`: **Computer**
- `0x3A97`: **Scan Unit**
- `0x3AA1`: **Next Unit**
- `0x3AAC`: **Flee**
- `0x3AB0`: **Begin Fight**
- `0x3ABC`: **Move** (Accessed in `GeneratedCode12.cs`)
- `0x3AC2`: **Clear Moves**
- `0x3ACE`: **Use Weapon**

**Menu Logic**
- **Mode Switching**: Controlled by global variable `0xB764` (0=Map, 1=Combat, 2=Transition).
- **Menu Dispatcher**: `unknown_19EF_3A5E_1D94E` in `GeneratedCode22.cs` handles menu actions.
- **String Printer**: `unknown_17C6_03F5_18055` displays menu options.
- **Combat Loop**: Analyzed in `GeneratedCode12.cs` (lines 300-600) and `GeneratedCode22.cs`.
- **AI Logic**: `0x3A40` ("The computer is currently moving this unit") indicates AI turn. Handled in `GeneratedCode22.cs` via `unknown_19EF_3ACC_1D9BC`.

### Data Tables
- `0x3B06`: Contains byte values `08 01 02 ...` likely mapping menu indices to types or actions.
- `0x3B12`: Referenced in `GeneratedCode12.cs` for menu branching.

### Function Mapping (Tentative)
- **Walk**: `GeneratedCode12.cs` line 347 (`AX=0x3A6F`).
- **Move**: `GeneratedCode12.cs` line 373 (`AX=0x3ABC`).
- **Menu Action Dispatch**: `unknown_19EF_3A5E_1D94E` calls various handlers based on input.

### 4. Combat Loop & Phase Management
The central combat loop iterates through all active units (Mechs/Vehicles) to process their turns.
- **Location**: `GeneratedCode13.cs` (Function `ghidra_guess_1000_4672_14672`).
- **Logic**:
    1.  Iterates through unit slots (loop counter at `BP - 0x28`).
    2.  Checks Unit Status at `ES:[BX + 0x406a]` (0 = Inactive/Dead).
    3.  Calls **Unit State Check** (`ghidra_guess_1000_0934_10934`).
    4.  If the unit can act (`AX < 3`), it proceeds to Movement or Targeting.

### 2. Movement Phase
Calculates the path and direction between combatants.
- **Algorithm**: `GeneratedCode18.cs` (Function `unknown_19EF_0971_1A861` calls `split_1000_A8C6_1A8C6`).
- **Inputs**:
    - `BP+0x6`: Source X (stored to `[0x238]`)
    - `BP+0x8`: Source Y (stored to `[0x23A]`)
    - `BP+0xA`: Dest X (stored to `[0x23C]`)
    - `BP+0xC`: Dest Y (stored to `[0x23E]`)
- **Logic**:
    1.  **Delta Calculation**:
        - `DeltaY = SourceY - DestY`
        - `DeltaX = DestX - SourceX`
    2.  **Coarse Direction**:
        - Initial slope comparison in `unknown_19EF_0971_1A861`.
        - Sets base bits in `DX`.
    3.  **Fine Direction Refinement** (`split_1000_A8C6_1A8C6`):
        - Uses a decision tree/binary search approach on the slope ratios.
        - Compares `2*Angle` vs `Slope` (scaled).
        - Sets bits `0x8`, `0x4`, `0x2`, `0x1` in `DX` to determine the precise 16-way (or 32-way) angle.
    4.  **Final Lookup**:
        - Uses the calculated value in `DX` as an index into a table at `DS:[0x240]`.
        - Returns the look-up value (likely the final direction ID or sprite index) in `AX`.

### 3. Targeting Phase
Selects weapons and targets.
- **Entry Point**: `ghidra_guess_1000_0934_10934` (in `GeneratedCode10.cs`).
- **Inputs**:
    - `BP+0x6`: Unit ID / Index.
- **Data Structures**:
    - **Unit Coordinates**:
        - X: `ES:[ID*2 + 0x4004]` (Segment `0x5592`)
        - Y: `ES:[ID*2 + 0x4036]` (Segment `0x5590`)
    - **Target/Cursor Position**:
        - X: `ES:[0xA44B]` (Segment `0x5582`)
        - Y: `ES:[0xA44D]` (Segment `0x5584`)
- **Logic**:
    1.  **Coordinate Retrieval**: Fetches the unit's current X and Y coordinates using the Unit ID.
    2.  **Target Comparison**: Compares unit coordinates with the target/cursor position.
    3.  **Coordinate Adjustment**:
        - Iteratively adjusts the unit's internal target coordinates (stored in local variables `[BP-0xA]` and `[BP-0xC]`) towards the target.
        - Uses masking (`0xF7F`, `0xF07F`) and bitwise operations, suggesting a grid or sub-pixel coordinate system.
    4.  **Line of Sight / Distance Check**:
        - Calls `ghidra_guess_1000_05C5_105C5`.
        - Calculates deltas (`abs(X1-X2)`, `abs(Y1-Y2)`).
        - Determines if the shot is blocked or within range.

#### Fire Phase Logic
**Function:** `unknown_19EF_1886_1B776` (Fire Phase Entry/Sub-handler)
- **Segment:** 19EF
- **Offset:** 1886 (0x1B776)
- **Logic:**
  - Sets up `SI` and `DI` registers with specific offsets (e.g., `SI=0x564`, `DI=0x324`).
  - Calls `unknown_19EF_11BB_1B0AB` repeatedly with different offsets.
  - Likely iterating over different body parts or weapon mounts for damage calculation or status updates.

**Function:** `unknown_19EF_11BB_1B0AB` (Adjacency/Grid Processing)
- **Segment:** 19EF
- **Offset:** 11BB (0x1B0AB)
- **Logic:**
  - Iterates 6 times (Inner Loop) and 6 times (Outer Loop?) using `CX` and `DX`.
  - Performs bitwise operations (OR, XOR) and comparisons on byte data at `[SI]`, `[SI-1]`, `[SI+1]`, `[SI-8]`, `[SI+8]`.
  - Sets bits in `[DI]` based on these comparisons (0x8, 0x4, 0x2).
  - **Hypothesis:** This function calculates adjacency effects, possibly for:
    - Critical hit transfer (checking neighboring slots).
    - Splash damage.
    - Line of Sight or Terrain feature verification (checking neighboring tiles).
  - The offsets +/- 1 and +/- 8 suggest a grid width of 8.

**Function:** `unknown_19EF_18EF_1B7DF` (Damage Application?)
- **Segment:** 19EF
- **Offset:** 18EF (0x1B7DF)
- **Logic:**
  - Calls `unknown_19EF_11BB_1B0AB` via `unknown_19EF_1886_1B776`.
  - Uses `unknown_19EF_0BC0_1AAB0` (RNG) for hit determination.
  - Manages Unit State at `0xA44B` / `0xA44D`.

- **RNG & Hit Calculation**:
  - `unknown_19EF_0BC0_1AAB0`: Core RNG function.
  - Used for To-Hit rolls and Location rolls.
  - See "RNG Implementation" section for details.

### 5. Combat Data Structures
The game uses specific memory layouts for Mechs and Weapons, partially reversed in the `InceptionTools` folder:
- **Weapons**: `Damage`, `Heat`, `Range` (see `WeaponsArray.cs`).
- **Mechs**: `Tonnage`, `Armour`, `InternalStructure` (see `Mech.cs`).
- **Combat State**:
    - **aD457**: Array of bytes. Likely combatant status or type.
    - **aD497**: Array of bytes. Appears to hold ID or Team flags.
    - **aD4D7**: Array of bytes. Initial positions or movement state.
    - **tD557**: Index/Counter used to iterate through active combatants in the loop.

## Story State Logic & Plot Twist Trigger

The game's story progression is controlled by a state variable stored in a structure array, accessed via the instruction at `UNBTECH.exe` offset `0x12A76` (linear address).

### Trigger Mechanism
The key instruction is `INC byte ptr ES:[BX+0C79Bh]`, which increments the story state byte.
- **Location**: Offset `0x12A76` in `UNBTECH.exe`.
- **Logic**:
  - The code around `0x12A64` first checks the current state with `CMP byte ptr [BX+C79B], 2`.
  - If the state is below 2, it executes the increment at `0x12A76`.

### States Identified
(Empirical, still tied to this byte)
- **0 (Training Mode)**: Initial state.
- **1 (Flee/Attack Mode)**: Set by the citadel-attack training script that runs after the third training mission. That script is executed via the generic interpreter at `1E56:03F5`, displays the line "They're trying to actually kill you! This is no training mission!" from the text bank at `3EDB:32F0` (see `ALL_BLD_STRINGS.txt`), and then triggers **property 0x1F** so that `fn1631_11AB` increments this byte from 0 to 1. From this point on, world-map logic treats the game as live combat rather than safe training and begins the escape storyline.
- **2 (Citadel Destroyed)**: Post-attack state.

### Data Structure (Reconciled with Reko/Ghidra)
In the decompiled code (`UNBTECH_1631.c`), this byte is part of `Eq_57354`:
- `Eq_57354` contains an array field `aC744` of `Eq_107947`.
- `Eq_107947` has size 125 bytes (`0x7D`), matching the stride seen in assembly (`wArg04 * 0x7D`).
- The field at offset `0x57` inside `Eq_107947` is named `b0057` and is treated as an unsigned 8-bit value.
- The original `ES:[BX+0C79B]` expression maps to `es_357->aC744[0].b0057[wArg04]` in `fn1631_11AB`.
- This confirms that `0xC79B` is not a flat array base but the specific offset of `b0057` inside the first `Eq_107947` element of `aC744`.
- The per-story index is `wArg04`, with each story entry spaced by `0x7D` bytes.

## Kill-You Line And Citadel Attack Script
The line "They're trying to actually kill you! This is no training mission!" is stored in the main text bank segment at `3EDB:32F0` and appears in the extracted data in `ALL_BLD_STRINGS.txt`.
It is not referenced directly by code; instead, a training-related BLD script is invoked through `1E56:03F5` (the script/text interpreter). That script both prints this line (by selecting the `3EDB` string) and uses the story-property mechanism (**property 0x1F**) to call `fn1631_11AB`, which increments the `C79B`-backed story byte.
As a result, the moment this line is shown to the player is exactly when the story state transitions from `0` (Training) to `1` (Citadel under attack / escape), matching the plot twist where Kurita forces hit the citadel and Jason must flee.

## Neighbour Story Flags Around C79B (aC744 Slot Layout)
The per-story records live in the `aC744` array of `Eq_57354`, where each element is an `Eq_107947` struct of size `0x7D` bytes. Relevant fields:
- **b0000** (offset `0x00`): Generic per-story status byte. Cleared to `0` when certain multi-step conditions complete (see property `0x20`).
- **b0004 / b0005** (offsets `0x04`, `0x05`): Nibble-packed flag fields; other code masks these with `0x0F` and `0xF0` to extract sub-flags, but their exact story meaning is still open.
- **b0006** (offset `0x06`): Small unsigned field used together with `b0004` / `b0005` in arithmetic; likely an additional timing/counter nibble.
- **b0055** (offset `0x55`): A small counter associated with story property `0x20`. Incremented up to a cap of `3` and used, together with `b0056`, to decide when a story entry is fully completed and should be cleared.
- **b0056** (offset `0x56`): Second counter tied to property `0x20`, capped at `2`. When `b0056` reaches `2` (or `b0055` reaches `3`), the engine clears `b0000` for that story slot and sets a global flag `wE484` to `1`, signalling that the related multi-step story action is finished.
- **b0057** (offset `0x57`): The `C79B`-backed **story state byte** described above; used by property `0x1F` for the citadel attack progression and limited to the range `0..2`.
- **b0058** (offset `0x58`): A gate/marker byte used alongside property `0x1F`. When non-zero, the `ax_309 == 1 / 6` subcases of property `0x1F` will set it to `0xFF` and decrement the local update counter; if it is already `0`, the block is skipped. This effectively acts as a one-shot flag for additional effects tied to the citadel-attack story property.

In C terms, the key update paths are:
- **Property 0x1F (citadel attack)** in `fn1631_11AB`:
  - Subcodes `2` and `5` increment `b0057[wArg04]` (`C79B`) up to `2`.
  - Subcodes `1` and `6` check `b0058[wArg04]` and, if non-zero, force it to `0xFF` as a latched marker.
- **Property 0x20 (multi-step story counter)** in `fn1631_11AB`:
  - Uses two script parameters to decide whether to increment `b0056` (two-step counter) or `b0055` (three-step counter) for the given story slot.
  - When either `b0056 >= 2` or `b0055 >= 3`, the engine clears `b0000[wArg04]` and sets `wE484 = 1`, treating the story action as fully resolved for that slot.

Practically, this means that the four neighbour bytes around `C79B` (`b0055`, `b0056`, `b0057`, `b0058`) form a **small state bundle** per story slot:
- `b0057` holds the coarse story state (training → attack → post-attack).
- `b0055` / `b0056` track progress through multi-step conditions driven by property `0x20`.
- `b0058` provides a one-time latch for auxiliary effects of the citadel-attack property `0x1F`.

## C79B Update Function (fn1631_11AB)
- **Function**: `fn1631_11AB` in `UNBTECH_1631.c` (segment `1631:11AB`).
- **Core logic for this byte** (case `wArg06 == 0x1F`):
  1. Load `es_357` from `Mem[ds:0x558E]` (pointer to `Eq_57354`).
  2. Check `es_357->aC744[0].b0057[wArg04] >= 2`; if so, skip.
  3. Otherwise, increment it: `es_357->aC744[0].b0057[wArg04].b0000++`.
  4. Decrement a local counter `wLoc0C_836` which appears to track remaining actions/updates.
- **Effect**: This function is the structured equivalent of the `INC ES:[BX+0C79B]` sequence and enforces a maximum state.
