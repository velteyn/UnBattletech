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

## Open

- **Runtime segment of the viewport struct**: Reko uses `ds:0x4FBA`; at runtime `DS=0x1DE9`
  during the world map, but reading `0x1DE9:0x4FBA` does not yield a 0–3 mode. The table
  *offsets* are known from Reko; the exact runtime segment (the game likely switches `DS`
  between map-data and UI-data segments) needs a **live breakpoint** on `fn1F3D_03EB`.
- Exact contents of `a4FC4`/`a4FCC`/`a4FD4` (masks/shift per mode) — same resolution path.
