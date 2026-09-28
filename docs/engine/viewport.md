# Engine: Viewport & Rendering Workflow

> Subsystem C of the [engine recovery plan](README.md). Consolidated from the Reko
> decompilation (`fn1F3D_*`, `fn207F_*`) plus the existing notes in
> [`../story/story-system.md`](../story/story-system.md). The renderer primitives are
> **shared with Mines of Titan** (see [`fingerprint-mines-of-titan.md`](fingerprint-mines-of-titan.md)).

## Model

The engine draws through a **mode-selected viewport**. The global UI mode `w4FBA` (0–3)
selects a set of rendering parameters; `w4FBC` is the dynamic left-panel *narrow* flag.

| Mode (`w4FBA`) | Viewport |
|----------------|----------|
| 0 | World map — left panel 80px, stride `0x140` (320), EGA planar |
| 1 | Local tiles — left panel 80px, double-width pixels |
| 2 | Text — no left panel, VGA text buffer `0xAC00`, 40-col stride |
| 3 | Building-name overlay — `0x0A00` stride, 8× pixel font, 13-col strip |

`w4FBA` is set once at startup (keys 1–4, normalized `-= 0x31`) and toggled `0↔1` around
the render pass; it is **not** changed during gameplay. Dynamic viewport changes use
`w4FBC`/`tB764` instead.

## Per-mode parameter tables

`fn1F3D_03EB` adapts span fills to each mode's pixel packing via three lookup tables
indexed by `w4FBA`:

- `a4FC4[w4FBA]` — Y clip mask (`wArg06 & a4FC4[mode]`)
- `a4FCC[w4FBA]` — X clip mask (`a4FCC[mode] & wArg08`)
- `a4FD4[w4FBA]` — shift amount (`ax >> a4FD4[mode]`, skipped when mode==3)

(The Reko `ds` offsets are `0x4FC4`/`0x4FCC`/`0x4FD4`, adjacent to `w4FBA` at `0x4FBA`.)

## Drawing primitives

| Function | Role |
|----------|------|
| `fn1F3D_031C(x1,y1,x2,y2,color)` | **Clipped filled rectangle** — sorts corners, clamps to `0..319`/`0..199`, then fills |
| `fn207F_05D0(x1,y1,x2,y2)` | Box fill (writes seg-`246C` config `t0220`/`t0234`) |
| `fn1F3D_03EB` | Vertical/span variant using the per-mode masks/shift |
| `fn207F_0780` | Span fill (used when `y1 < y2`) |
| `fn207F_24D7` | Low-level EGA/VGA framebuffer blitter, 4 cases by `tB764` |
| `fn207F_0313` | VGA **write-mode-2** blitter (`GC 0x3CE ← 0x0205`), shared engine routine |

## Border / panel dispatch

`fn1F3D_06C3` (called from 16+ sites) switches on `w4FBA`:

- **0 / 1** → `fn207F_1CB8` — full decorative border (two sub-variants by `tB764`)
- **2** → `fn207F_245C(0, 0xAC00, 0, 0xA000, 0x0D, 0, 0x1B, 200)` — text strip
- **3** → `fn207F_1D3A` — narrow left border (27-col text, `SEQ(al,al)&0x0FF0` expansion)

`w4FBC` (DS:0x4FBC) narrows the left panel `80px → 4px` for combat / building / menus
(see `story/story-system.md` §w4FBC for the set/clear sites).

## Rendering pipeline (3 passes)

1. **Right panel tiles** — `fn207F_18EF` (13×12 grid centered on cursor)
2. **Left panel border** — `fn1F3D_06C3`
3. **Text overlay** — `fn1E56_03F5`

## Shared with Mines of Titan

The renderer primitives (`fn207F_0313` write-mode-2 blitter, the `fn207F_33xx` text/char
cluster, `fn1F3D_031C`) are **shared engine code** — confirming this subsystem is the
reusable Westwood core, not BattleTech-specific.

## Resolved: runtime segment & table values (2026-09-28)

Captured live by setting a `CPU_EXECUTION_ADDRESS` breakpoint on `fn1F3D_031C`
(runtime linear **`0x18EBC`**; NB: Reko loads the image at segment `0x800`, the game
loads at `0x17D`, so **runtime linear = reko_linear − 0x6830**).

**The game switches `DS`**: `0x1DE9` = map/render data, **`0x3858` = the UI/viewport
struct**. At the breakpoint, `DS = 0x3858` (not `0x1DE9`), which is why earlier reads at
`0x1DE9:0x4FBA` looked wrong.

Values read at `0x3858`:

| Symbol | Offset | Value |
|--------|--------|-------|
| `w4FBA` | `0x4FBA` | `3` (mode at capture) |
| `w4FBC` | `0x4FBC` | `1` |
| `a4FC4` (Y mask) | `0x4FC4` | `[0x0003, 0x0001, 0x0007, 0x0000]` (modes 0–3) |
| `a4FCC` (X mask) | `0x4FCC` | `[0x01FC, 0x01FE, 0x01F8, 0x01FF]` |
| `a4FD4` (shift) | `0x4FD4` | `[2, 0, 1, 0]` |

So the per-mode pixel-packing parameters are now known; the viewport system is fully
located at runtime.

## Remaining / notes

- The **mode** (`w4FBA`) is set at startup from the adapter prompt (keys 1–4) and toggled
  `0↔1` around the render pass; the `3` captured is the live value at that breakpoint.
- `w4FBC = 1` at capture (left panel narrowed), consistent with during-combat/building.
- Runtime-segment mapping for future work: **`runtime_linear = reko_linear − 0x6830`**
  (Reko base `0x800`, runtime base `0x17D`).

---

## Detailed rendering notes (moved from `story/story-system.md` §17.12, 2026-09-28)

### Screen Layout

The game renders at **320×200 EGA** (VGA compatible mode 0x0E, 16 colors). The screen is divided vertically into two panels:

| Panel | Width | Description |
|-------|-------|-------------|
| Left panel | **80px** (`0x50`) | Location graphic + action menu |
| Right area | **240px** (320-80) | Main viewport (world map, local tiles, or text) |

The 80px left panel width is a hardcoded constant (`0x50`) used across 7+ source files for viewport clipping (`fn207F_24D7`), text layout (`fn1E56_0388`), sprite rendering (`fn1F3D_0086`), and screen buffer addressing (`fn207F_245C`/`fn207F_24D7`).

The EGA framebuffer uses a planar layout:
- **4 bit-planes** (Blue=0, Green=1, Red=2, Intensity=3)
- **40 bytes per plane per scanline** (320px / 8)
- **Odd/even row interleaving**: even scanlines in bank 0, odd scanlines in bank 1, offset by `0x2000` (8192 bytes)
- **Row-pair stride**: 80 bytes (0x50) per plane for two interleaved rows
- **Total framebuffer**: ~32768 bytes (0x8000) for 4 planes, used via VGA ports `0x3C4`/`0x3CE` for plane selection

### `w4FBA` (at segment `0x569E` offset `0x00FD`, via selector at `0x53A0`)

Controls which rendering mode is active. Checked by 60+ code paths across 8 code segments. Modes 4-6 **do not exist** — only 0-3 are used.

| Value | Mode | Right Panel | Border Style | Char Stride | Font Blitter | Framebuffer |
|-------|------|-------------|--------------|-------------|--------------|-------------|
| `0` | World Map | Hex/overhead map | Full border (`fn207F_1CB8`) | 1× (2-byte) | `fn207F_2209` | `0x246C:0x244B` |
| `1` | Local Tiles | Building interior tiles | Full border | 2× (4-byte) | `fn207F_21A8` | `0x246C:0x244B` |
| `2` | Text Only | Cipher-decoded text | Text border (`fn207F_245C`) | 1× direct | `fn207F_2251` | `0xA000:0xAC00` |
| `3` | Building Name | Overlay text | Narrow border (`fn207F_1D3A`) | 8× (8-byte) | `fn207F_22A5` | `0x246C:0x244B` |

**Set at startup, with render-in-progress toggle**: w4FBA is written from user keyboard input (keys 1-4). The user presses `1`/`2`/`3`/`4` (ASCII 0x31-0x34) in the `main` function (pseudocode lines 5921-5922), stored as raw keycode. After the protection screen (lines 5929-5958), it is normalized at line 5961 via `-= 0x31` to yield 0-3. During the main render loop (lines 6110-6132): if w4FBA==0, it is temporarily set to 1 during the rendering pass and restored to 0 after. Values 0 and 1 produce the same border variant. **No BLD opcode or game function changes w4FBA to a different mode during gameplay.** All dynamic viewport changes (combat mode, building entry, action menus) are handled by `w4FBC` and `tB764` instead.

**Mode-specific rendering parameters** (from `fn1F3D_03EB` lookup tables at `a4FC4[][w4FBA]`, `a4FCC[][w4FBA]`, `a4FD4[][w4FBA]`):
- Mode 0: left panel width = 80px, row stride = 0x0140 (320 bytes), line advance by 320
- Mode 1: left panel width = 80px, double pixel width
- Mode 2: no left panel (fullscreen text), VGA buffer at 0xAC00, row stride = 40 text columns
- Mode 3: overlay with 0x0A00 stride (2560 = character row * 320 * 8), 8× pixel font

### `w4FBC` — Secondary Viewport Flag (Combat/Building Panel Narrowing)

**Location**: Selector `0x53E8` (adjacent to `0x53A0` which holds w4FBA), offset `0x4FBC`. Stored as `uint16` but used as boolean (only values 0x00 and 0x01).

**Purpose**: Controls left-panel width narrowing. When `w4FBC != 0`, the left panel narrows from 80px (`0x50`) to 4px (`0x04`) in rendering functions like `fn1F3D_049D` (line 568). This is the MECHANISM used for combat mode, building interiors, and interactive menus — NOT a w4FBA change.

**Set to 1 (`w4FBC = 0x01`)**: combat encounter start (`fn183B_000A`), combat flow (`fn0800`), combat dispatch (`fn1CD3`), building entry (`fn135D`), action menu (`fn1CD3`).

**Cleared to 0 (`w4FBC = 0x00`)**: combat cleanup/end (`fn0800`), action menu exit (`fn0DAB`), building exit (`fn135D`), game mode transitions (`fn0800`, `fn1CD3`).

**Key insight**: The original TECHNICAL_ANALYSIS.md incorrectly attributed combat/text transitions to w4FBA changes. Those were actually w4FBC toggles. When combat starts, w4FBC=1 narrows the left panel to 4px (hiding the animation graphic), and the combat HUD text is drawn there alongside the expanded right-panel viewport.

### Border Drawing System

Dispatched by `fn1F3D_06C3()` (segment `1F3D:06C3`), called from 16+ locations across all major rendering paths. Uses `BTBORDER.TIL` tileset loaded into segment 1A58's tile cache.

1. **Full border** (`fn207F_1CB8`, default for w4FBA=0,1): decorative frame around the entire 320×200 screen. Two sub-variants by `tB764`:
   - `tB764 == 0`: standard frame, 0x1A offset, 54-byte tiles, 100-row loop
   - `tB764 != 0`: wide frame, 0x34 offset, 108-byte tiles, 50-row loop, 4 side-panel sections
2. **Narrow border** (`fn207F_1D3A`, w4FBA=2): left side border only, 200 rows × 27 words via `SEQ(al, al) & 0x0FF0` nibble expansion (~27 character columns).
3. **Text overlay border** (`fn207F_245C`, w4FBA=3): `(0x00, 0xAC00, 0x00, 0xA000, 0x0D, 0x00, 0x1B, 200)` — 13-column text strip in the left panel (building-name display).

### Main Game Loop (`fn0800_0000`, segment `0800:0000`)

The core loop runs continuously while `w0152` (offset `0x0152`) is zero. Code order:
**Input → Key Dispatch → Timer → Economy → Animation+Render+Border → BLD**.

```
fn0800_0000(wArg04):
    fn207F_2FDC(0x30)         // Save segment context
    fn0800_48B7(0x0F)         // Init state machine (fn0800_1B8E sub-dispatch)
    while (w0152 == 0):
        // PHASE 1: INPUT
        if (fn1F3D_002F() == 0): fn1F3D_0006(1); continue;   // timer decrement, no key
        else: fn1F3D_0259()                                   // read scancode → wLoc28
        // PHASE 2: KEY DISPATCH
        fn0800_2A2B(); fn1E56_0D1D(scancode); fn1E56_0281(4)
        for (i=0; i<0x015A; i++):
            if (key != 0x20): fn0800_218F(key)   // arrows/char → scroll + cursor
            fn0800_051B()                        // unit/map processing, tile render
            if (wD55C != 0) break
        fn0800_231D(key)
        if (key == 0x20): fn0800_2C50()          // Space → action menu
        // visibility/fog update (bD33D/bD346 guarded)
        // PHASE 3: TIMER
        Decrement bD335, bD343/44/45, bD329, bD320/21/22, bD323 (economy, 3-day cycle)
        // PHASE 4: ECONOMY  (when bD323 wraps 0→0xFF)
        if (bD310 == 0): fn0800_29F5(); fn1631_1FDF()   // +15 credits display
        //   + format 3 stock tickers (owned → actual value, else default 110)
        // PHASE 5: ANIMATION + RENDER + BORDER
        fn0800_240B()                            // tile animation page swap (w5800 0→1→2)
        if (0x57FE wraps): fn0800_24C2()         // NPC animation frame (8 slots)
        if (w014A != 0):
            fn207F_1314(tA44D, tA44B); fn207F_18EF()   // 13×12 tile grid refresh
            fn1F3D_06C3()                              // border (w4FBA dispatch)
        // PHASE 6: BLD/BUILDING
        if (w014A == 0 || w01A8 != 0):
            fn1CD3_17C6(); fn1E56_03F5(text_id, ds); fn1F3D_0259(); fn1E56_0388()
            fn0800_1A13(1); if (continue) fn0800_4DC7(); else w0152 = 1
```

### Screen Composition Pipeline (3 passes)

1. **Pass 1 — Right panel content** (`fn207F_18EF`): world-map tiles (mode 0, 64 tiles centered on cursor), local tiles (mode 1), or text (mode 2). Reads tile property from seg `246C +0x7AD[tile_index]`; renders a 13×12 grid (`fn207F_1AA8`/`1ACE`/`1AF4`); world-map fog at `0xCB0C`/`0xCAFC`/`0xCB1C`.
2. **Pass 2 — Left panel border + graphic** (`fn1F3D_06C3`): full border `fn207F_1CB8` (0x32 rows × 0x6C bytes; `tB764==0` 100×54, else 50×108 with 4 side-panel sections), narrow border `fn207F_1D3A`, or text overlay `fn207F_245C`; location graphic via segment 135D.
3. **Pass 3 — Text/menu overlay** (`fn1E56_03F5`): action menu + dialogue on top; VGA write mode 2 (`out 0x03CE/0x03C4`); char widths by w4FBA (1×/2×/8×); positioned on the left panel's 10-column grid.

### Viewport Clipping (`fn207F_24D7`)

Core EGA framebuffer blitter, 4 cases by `tB764` (seg 246C rendering-config struct). No standalone viewport-dimension-config function exists (`fn207F_1B80` does **not** exist — earlier references were wrong).

| `tB764` | Mode | Width | Framebuffer | Stride | Details |
|---------|------|-------|-------------|--------|---------|
| `0x00` | CGA/Herc | 0x50 (80) | `0xB800` | 0x28 (40) | 2-bit pixels, odd/even 0x2000 plane shift, parity interleave |
| `0x02` | VGA text | 0x28 (40) | `0xAC00`→`0xA000` | 0x28 (40) | Linear, `out 0x03CE, 0x0105` write mode 2, no planar |
| `0x01` | EGA planar | 0xA0 (160) | `0xA000` | 0x28 (40) | 4-bit planar interleave (`bx = row & 0x03`) |
| default | Full frame | 0x140 (320) | `0xA000` | 0x0140 | Linear full-width copy |

**VGA Pixel Writer (`fn207F_275C`)** — 4 sub-modes by `tB764`: `0x00` CGA `0xB800` 2-byte stride; `0x02` VGA planar `0xA000` (plane sequencing via `0x03C4`); `0x03` VGA mode X `0xA000` stride `0x0A00` (nibble-replicated); default `0xB800` text (2-pass, 4 attribute bytes/cell).

**`fn207F_245C` (text-overlay wrapper)** sets blitter context (`tB78A-B79C`) with format-dependent scaling (`tB764`: 0x02 ×1 / 0x00 ×2 / 0x01 ×4 / 0x03 ×8) then calls `fn207F_24D7(0x246C)`.

### Animation System (segment 135D)

4-function dispatch for left-panel location graphics: `DISP` (`fn135D_0004+0x0000`), `LOAD` (`+0x0010`), `INIT` (`+0x0020`), `CLEAR` (`+0x0030`). Called from BLD building entry (`fn0FDC_0008`) to render the location portrait in the 80px clip region at the top of the left panel.

### Building-interior render (w4FBA=1)

1. `fn0FDC_0008` loads BLD data by index from segment `3000:CC30` filename list
2. `fn0FDC_01C0` bytecode interpreter runs (room description)
3. Tile map renders into the right 240px panel via `fn0800_13F4()` / segment 0FDC
4. Left panel shows building image (segment 135D) + action menu

### World-map render (w4FBA=0)

1. `fn1431_0091()` renders map tiles into the right panel
2. Scroll/viewport ops compensate `-0x50` to align pixel X=80 with tile offset 0
3. `fn207F_1DF8()` derives cursor tile from `tA44B`/`tA44D`: `tileX = (tA44B >> 1 & 0x07) + 2`, `tileY = (tA44D >> 1 & 0x07) + 2`, `index = tileX + tileY * 24`
4. 3 tiles beneath the cursor rendered per frame via the arrow-key handler

### Image Rendering Pipeline

**1. Nibble-packed (internal working buffer)**: each byte = 2 pixels (4-bit EGA index 0–15); 320×200 = 32000 bytes.
**2. EGA planar (VGA framebuffer)**: even scanline at `A000:0000 + (Y/2)*40 + plane*0x2000`, odd at `A000:2000 + …`; 4 planes × 40 bytes/scanline; plane stride `0x2000`.

**Conversion**: nibble-packed (32KB) → VGA write mode 2 → EGA planar
(`fn207F_24D7` case 0x00 → 80px left panel; case 0x02 → 40-column text, linear).

**Asset pipeline**: `CMP/ICN` (2-byte LE size + 1-byte format) → RLE decompress (Format01 row-major / Format02 column-major) → nibble-packed → `fn207F_28A8` (128-byte tile memcpy) → `fn207F_24D7` viewport blit → `fn207F_275C` pixel writer.

### Known gaps (rendering)

- `tB764 == 0x03` (VGA mode X, stride 0x0A00) — used in combat/stat screens? Only referenced in `fn207F_275C`.
- `w3988` animation guard (what sets it / when animation pauses).
- `w37FE` text-mode flag semantics.
- Exact stats/combat screen layout (confirmed w4FBA 0+2+3 combos, not modes 4–6).

### Impact VFX (moved from `combat-system.md` §7.10)

**Function:** `unknown_19EF_18EF_1B7DF` (segment:offset `19EF:18EF`, linear `0x1B7DF`). Called
**after** damage is applied, to render the weapon impact effect:

```
DS = 0x1DDC
DI = 0x34 + 0x244B = 0x247F   ← screen buffer offset
[0xA452] = 8                   ← drawing width
[0xA454] = 0x994               ← Y coordinate parameter
[0xA456] = 0x494               ← X coordinate parameter

// VGA hardware acceleration (mode X, when tB764 == 2):
DX = 0x3CE                     ← VGA Graphics Controller port
AX = 0x205                     ← Set/Reset register: set bit 0 (plane 0)
OUT DX, AX
AX = 0x8                       ← Bit Mask register
OUT DX, AX

// 13-iteration loop (CX = 0xD): draws the impact sprite frame at the cursor position
// Cleanup: restore VGA registers
```

**Purpose:** draws the weapon-impact animation at the cursor/target position using the VGA
Set/Reset + Bit Mask registers (`0x3CE`); the 13 iterations are the splash/explosion frame sequence.
