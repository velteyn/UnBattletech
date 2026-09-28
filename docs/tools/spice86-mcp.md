# Spice86 MCP — BattleTech Runtime Introspection Tools

> Canonical reference for the 23 `bt_*` runtime-introspection MCP tools.
> Build/run commands live in `AGENTS.md`; the HTTP/SSE transport itself lives in
> Spice86 (`src/Spice86.Core/Emulator/Mcp/McpHttpHost.cs`).


A set of **23 BattleTech-specific MCP tools** built on Spice86's MCP (Model Context Protocol) infrastructure. These let you query and control the emulated game at runtime — read/write game state, inject keyboard input, inspect memory — without modifying the original EXE.

### How It Works

`BattleTechOverrideSupplier` implements both `IOverrideSupplier` and `IMcpToolSupplier`, loaded at emulator startup via `Program.cs`:
```
RunWithOverrides<BattleTechOverrideSupplier>(args)
```

All tools use **DS-relative addressing** `(DS << 4) + offset` at runtime rather than hardcoded physical addresses — the DS register varies due to EXE relocation. Tools auto-pause emulation before executing, then resume after the operation.

> **Segment fix (2026-09-28)**: BattleTech uses multiple data segments — `0x1DE9` = world-map/render
> data, **`0x2A0F` = game state**, `0x3858` = UI/viewport struct. The tools now read game state
> (state array, credits, story/unit slots, flags) from `0x2A0F` and the cursor from `0x1DE9`.
> See `docs/UNVERIFIED_DISCOVERIES.md` §6.

### Tool Categories

| Category | Tools | Purpose |
|----------|-------|---------|
| **Game State** | `bt_read_state_array`, `bt_write_state_array`, `bt_get_state` | Read/write the 256-byte generic state array at DS:0xD30C. `bt_get_state` returns a comprehensive snapshot (state array + cursor + credits + flags + active units) |
| **Story/Unit Slots** | `bt_read_story_slot`, `bt_read_unit_slot` | Read per-unit data: story slots (8 × 125 bytes, stride 0x7D at DS:0xC724), unit slots (8 × 17 bytes, stride 0x11 at DS:0xC614) |
| **Position & Economy** | `bt_read_cursor`, `bt_read_credits`, `bt_read_flags` | World map cursor X/Y (DS:0xA44B/A44D), C-Bills (DS:0xD370, uint32), TrainingComplete (DS:0xD450) and Milestone (DS:0xD451) flags |
| **Combat State** | `bt_read_combat_grids`, `bt_read_combat_units` | Twin 12×24 fog grids (DS:0x40B4/0x41D4), 24 combat unit X/Y positions + status arrays (DS:0x4004/0x4036/0x406A) |
| **Memory Access** | `bt_read_memory`, `bt_write_memory`, `bt_read_ds`, `bt_read_string` | Generic physical memory access, DS-relative read, null-terminated string reader. **`bt_read_memory` may error** — use HTTP API `GET /api/memory/{addr}/range/{len}` instead for reliable cursor reads. |
| **Emulator Control** | `pause_emulator`, `resume_emulator`, `step` | **Pause/resume** the emulation thread. Required before/after BIOS buffer writes (see "Keyboard Injection"). Also available via HTTP API: `POST /api/status/pause`, `POST /api/status/unpause`. |
| **CPU State** | `bt_read_registers` | Dump all CPU segment registers, general registers, IP, and flags |
| **Keyboard Input** | `bt_inject_key`, `bt_press_key`, `bt_send_key`, `bt_type_text`, `bt_press_enter`, `bt_press_escape` | **UNRELIABLE** — `bt_inject_key` writes to C# internal buffer, NOT to standard BIOS BDA at 0x0040:0x001E (see "Keyboard Injection" section). Use `pause_emulator` + HTTP API `PUT /api/memory/{addr}/byte` instead. |
| **Screen Capture** | `bt_screenshot`, `bt_read_video_mode` | Render emulator display as ASCII art so the AI can visually orient. Text modes (0x03 etc.) read char/attr pairs from B800:0000 → 80×25 text. Graphics modes (0x13/0x0D/0x0E) read A000:0000 → 80×50 luminance grid via the standard VGA 16-color palette. `bt_read_video_mode` reports the BIOS mode number (0x0040:0x0049) + description. |

### Visual Orientation (Screenshot Workflow)

`bt_screenshot` lets you "see" the emulated screen without a GUI:

1. **Boot prompts (text mode 0x03)**: The graphics-adapter and drive-count prompts are rendered as 80×25 text from the B800:0000 text buffer — fully readable via the `AsciiArt` field.
2. **In-game (graphics mode 0x13)**: Once the game enters VGA 320×200, the framebuffer is sampled 4×4 px → 80×50 ASCII luminance grid. Text glyphs render as ~2×2-cell letter shapes; large text is legible, small text is decipherable by shape.
3. Use it after each key injection to confirm the game state transitioned as expected (adapter prompt → drive prompt → intro → world map).

Verified boot flow with screenshots: text mode shows `C:\>CALL C:\UNBTECH.exe` + adapter prompt → after `4` (MCGA) shows drive-count prompt → after `3` (drive C) switches to mode 0x13 → intro text renders as ASCII glyphs. This gives full visual feedback during scripted navigation.

### How to Use

```bash
# Kill stale ports from prior runs (port 20000 blocks startup)
fuser -k 20000/tcp 8086/tcp 2>/dev/null

# Start Spice86 with MCP server on port 8086
dotnet exec bin/Debug/net10.0/UNBATTLETECH.dll \
  --Exe "/home/velteyn/projects/Reversing/BATTLETECH_CHI/UNBTECH.exe" \
  --CDrive "/home/velteyn/projects/Reversing/BATTLETECH_CHI/" \
  --HeadlessMode Minimal --McpHttpPort 8086 --NoGui

# Test MCP is alive (GET returns SSE `endpoint` event):
curl -s -m 5 -H "Accept: text/event-stream" http://localhost:8086/mcp/
# Expected: event: endpoint\ndata: /mcp/\n

# Query available tools (via POST):
curl -s -m 10 -X POST http://localhost:8086/mcp/ \
  -H "Content-Type: application/json" \
  -H "Accept: application/json, text/event-stream" \
  -d '{"jsonrpc":"2.0","id":1,"method":"tools/list"}'
```

### Game Startup Sequence (Verified)

Spice86 loads `BTECH.EXE` (compressed — decompression stub runs first in emulation, transparent to user). The game then enters this startup sequence (works with UNBTECH.exe):

1. **EGA/CGA prompt** — send `4` (ascii=0x34, scan=0x05) — selects MCGA/EGA mode
2. **Drive letter prompt** — send `3` (ascii=0x33, scan=0x04) — selects drive C
3. **Cutscenes/intro text** — send `Space` (ascii=0x20, scan=0x39) × 8-10 to advance through title/Infocom logo/hint screen
4. **Main menu** — `Space` may select "Continue Game" directly, landing at world map tile (~34,12)
5. → World map near building complex at ~(34,12)

**Observed**: Injecting (4, 3) + Space×8 gets you to the world map at tile (34,12) reliably. The game auto-selects an option after enough Space presses.

**⚠️ "Continue Game" with no save → blank state**: When `Space` at the main menu selects "Continue Game" but no save data exists, the game boots to a world map with `Credits=0`, `StateArray[0..31]=0`, and movement partially broken (W/X/Numpad keys may work, Q/A/D/E/Z/C may not). NEW_GAME_INIT (case 0x23) never runs. To get a proper initialized game, either:
  - Use ~18+ Spaces total to navigate through "Continue Game" → auto-detect no save → start new game → advance intro dialogs, OR
  - Walk onto the training-centre entrance tile to trigger TRAINING.BLD (runs NEW_GAME_INIT), OR
  - Manually write `Credits` via HTTP API PUT and set StateArray entries (note: `NEW_GAME_INIT` = 1500 cr is **wrong** — a new game starts at a small balance ~20 that ticks with the allowance; see `docs/UNVERIFIED_DISCOVERIES.md` §8)

### Keyboard Injection (RELIABLE)

`bt_inject_key` returns `Success=True` but writes to a **C# internal buffer**, NOT the standard BIOS BDA buffer at `0x0040:0x001E`. The Spice86 INT 16h handler reads from the standard BDA buffer, so `bt_inject_key` is **unreliable** for game key input.

**Proven reliable technique**: Use HTTP API `POST /api/status/pause` (port 20000, ALWAYS available) + PUT to write BDA directly. Use MCP port 8086 for tool queries.

```python
import http.client, json, time

def api_get(addr, length):
    c = http.client.HTTPConnection("localhost", 20000, timeout=5)
    c.request("GET", f"/api/memory/{addr}/range/{length}")
    return json.loads(c.getresponse().read()).get('values', [])

def api_put(addr, val):
    c = http.client.HTTPConnection("localhost", 20000, timeout=5)
    c.request("PUT", f"/api/memory/{addr}/byte",
        body=json.dumps({"value": val}),
        headers={"Content-Type": "application/json"})
    c.getresponse().read()

def api_post(path, body=None):
    c = http.client.HTTPConnection("localhost", 20000, timeout=5)
    c.request("POST", path or "/api/status/pause", body=body or "{}",
        headers={"Content-Type": "application/json"})
    return json.loads(c.getresponse().read().decode())

def inject_key(ascii, scan, wait=0.3):
    # 1. Pause emulator via HTTP API (reliable on port 20000)
    api_post("/api/status/pause")
    time.sleep(0.01)
    # 2. Read current head/tail from BDA
    meta = api_get(0x041A, 4)
    tail = meta[2] | (meta[3] << 8)
    # 3. Calculate next buffer slot (32-byte ring at 0x041E-0x043E)
    next_tail = 0x041E + ((tail - 0x041E + 2) % 32)
    # 4. Write key code at current tail
    api_put(tail, ascii)        # ASCII code
    api_put(tail + 1, scan)     # PC scan code
    # 5. Set tail = next slot
    api_put(0x041C, next_tail & 0xFF)
    api_put(0x041D, (next_tail >> 8) & 0xFF)
    time.sleep(0.01)
    # 6. Resume emulator — game reads key atomically
    api_post("/api/status/unpause")
    time.sleep(wait)

# Example: inject A (West)
inject_key(0x41, 0x1E)
```

The BDA head pointer auto-advances when the INT 16h handler dequeues the key. The buffer is 32 bytes (16 slots) at 0x041E-0x043E. Key entries are (ASCII, scan) pairs written at the tail pointer, then tail += 2 wrapping modulo 32.

The key is consumed because the INT 16h busy-loop checks head != tail immediately after resume, dequeues the key, and returns it to the game. The buffer clears itself (head advances to catch up with tail).

### Driving the game (movement & navigation)

**Movement is arrow keys** (`bt.py`'s `up/down/left/right`); **building entry is tile-triggered** —
walk onto the entrance tile. The old WASD "hex-grid" notes that used to live here were **wrong**
(verified 2026-09-28). Canonical model: [`../engine/input-navigation.md`](../engine/input-navigation.md);
map/POI data: [`../world-map.md`](../world-map.md).

Tool-side recipe: `tools/playtest/bt.py` (`boot`, `keys`, `state`, `png`) drives the game and renders
true-colour screenshots. Remember the entrance trigger stays "armed": walk **down** to step off it.

**Drive mount (A:/B:):** the game boots with DOS default drive `A:`, so `INFOCOM.CMP` resolved to
`A:\INFOCOM.CMP`; both `A:` and `B:` are mounted to the game-data folder via the public
`machine.Dos.MountFolderAsFloppy()` API from
`BattleTechMcpTools/BattleTechOverrideSupplier.cs` (`MountGameDataOnFloppyDrives`), keeping Spice86
upstream generic.

### Why This Is Invaluable

1. **Automated testing against the Godot rebuild**: Read game state from Spice86 at a given point, then read the same state from the Godot rebuild and compare — catch discrepancies immediately.
2. **Script the game**: Automate entire playthroughs (training → citadel → shops → combat → cache → endgame) by injecting keystrokes and verifying state transitions.
3. **Snapshot & replay**: Capture full game state at key moments (training completion, combat start, shop interaction) for analysis and regression testing.
4. **Live introspection without breakpoints**: Query cursor position, credits, combat fog grids, or CPU registers at any moment without halting the emulator or setting breakpoints.
5. **Combat validation**: Read combat unit positions, fog grids, and unit status to verify AI behavior matches the original.

### DS-Relative Address Reference

> Field→**tool** cross-reference for the harness. The address spec itself is canonical in
> [`../formats/memory-map.md`](../formats/memory-map.md).

| Field | DS:Offset | Size | Tool |
|-------|-----------|------|------|
| StateArray | DS:0xD30C | 256 bytes | `bt_read_state_array` |
| StorySlots | DS:0xC724 | 8×125 bytes | `bt_read_story_slot` |
| UnitSlots | DS:0xC614 | 8×17 bytes | `bt_read_unit_slot` |
| Cursor X/Y | DS:0xA44B/A44D | uint16 each | `bt_read_cursor` |
| Credits | DS:0xD370 | uint32 | `bt_read_credits` |
| TrainingComplete | DS:0xD450 | byte | `bt_read_flags` |
| Milestone | DS:0xD451 | byte | `bt_read_flags` |
| Fog Grid A | DS:0x40B4 | 12×24 bytes | `bt_read_combat_grids` |
| Fog Grid B | DS:0x41D4 | 12×24 bytes | `bt_read_combat_grids` |
| Combat Unit X | DS:0x4004 | 24×uint16 | `bt_read_combat_units` |
| Combat Unit Y | DS:0x4036 | 24×uint16 | `bt_read_combat_units` |
| Combat Status | DS:0x406A | 24×uint16 | `bt_read_combat_units` |

### Boot & Navigation Workflow (proven script)

Boot game → walk onto a building's **entrance tile** → answer the popup. Reminder: movement is
**arrow keys**, not WASD, and building entry is **tile-triggered** — see
[`../engine/input-navigation.md`](../engine/input-navigation.md). (`(26,5)` is a *local-map*
coordinate, not a world-map tile.) The ready-made harness is `tools/playtest/bt.py` (`boot`, `keys`,
`state`, `png`).

```python
import http.client, json, time

def api_get(addr, length):
    c = http.client.HTTPConnection("localhost", 20000, timeout=5)
    c.request("GET", f"/api/memory/{addr}/range/{length}")
    return json.loads(c.getresponse().read()).get('values', [])

def api_put(addr, val):
    c = http.client.HTTPConnection("localhost", 20000, timeout=5)
    c.request("PUT", f"/api/memory/{addr}/byte",
        body=json.dumps({"value": val}), headers={"Content-Type": "application/json"})
    c.getresponse().read()

def api_post(path):
    c = http.client.HTTPConnection("localhost", 20000, timeout=5)
    c.request("POST", path, body="{}", headers={"Content-Type": "application/json"})
    return json.loads(c.getresponse().read().decode())

def inject_key(ascii_, scan, wait=0.3):
    api_post("/api/status/pause"); time.sleep(0.01)
    meta = api_get(0x041A, 4)
    tail = meta[2] | (meta[3] << 8)
    next_tail = 0x041E + ((tail - 0x041E + 2) % 32)
    api_put(tail, ascii_)
    api_put(tail + 1, scan)
    api_put(0x041C, next_tail & 0xFF)
    api_put(0x041D, (next_tail >> 8) & 0xFF)
    time.sleep(0.01)
    api_post("/api/status/unpause"); time.sleep(wait)

UP, DOWN, LEFT, RIGHT = (0x00,0x48), (0x00,0x50), (0x00,0x4B), (0x00,0x4D)

def get_tile():
    t = api_get(0x1DE90 + 0xA44B, 4)
    rx = t[0] | (t[1] << 8); ry = t[2] | (t[3] << 8)
    return ((rx >> 1) & 0x7F, (ry >> 1) & 0x7F)

# Step 1: boot (EGA=4, Drive=3), Space through the intro
inject_key(0x34, 0x05); time.sleep(2)   # MCGA/EGA
inject_key(0x33, 0x04); time.sleep(2)   # Drive C
for _ in range(10):
    inject_key(0x20, 0x39); time.sleep(1.5)

# Step 2: walk onto an entrance tile (start-map example: Citadel ~(34,10))
for _ in range(4):
    inject_key(*UP); time.sleep(0.4)
print(get_tile())

# Step 3: answer "Will you enter the <building>? Yes/No" (Y), then Space through dialogue
inject_key(0x79, 0x15); time.sleep(1.5)
for _ in range(6):
    inject_key(0x20, 0x39); time.sleep(1.2)
```

### Known Issues

1. **`bt_inject_key` writes to wrong buffer**: Returns `Success=True` but writes to C# internal BIOS keyboard buffer, NOT to standard BIOS BDA at 0x0040:0x001E. The Spice86 INT 16h handler reads from the BDA buffer, so injected keys are silently lost.
2. **MCP `tools/list` returns 0 after extended runtime**: After >1B emulation cycles, `tools/list` may return empty tool array. Individual tools (by name) still work. Restart emulator to restore.
3. **`bt_get_state` cursor fields sometimes None**: `bt_read_memory` at DS=0x1DE9 offset 0xA44B is more reliable for cursor position.
4. **"Game freeze" is usually a BIOS key-wait, not a w014A stall** (re-diagnosed 2026-09-27): when it looks frozen, the CPU is typically spinning in the BIOS `int 16h` wait wrapper at `0x19FC:0xB57` (physical `0x1AB57`; bytes `cd 16 3c 00 75 04 8a c4 f6 d8 98 1f 5e 5f 5d cb`) *inside a building/dialog*, with cycles still advancing. `w014A=[2,2]` / `w0152=[4,4]` are usually side effects, not the cause. Clearing them does **not** unblock it — deliver a key instead: write ASCII at the BIOS buffer tail (`0x0040:0x001C`), scancode at tail+1, then advance tail by 2 (mod 32; ring `0x0040:0x001E`–`0x043D`). Verified: one Space (`0x20`/`0x39`) advances the dialog. Confirm with `bt_read_registers` / `/api/status` that `cs:ip == 19FC:B57`.
   - Watch the address: the head is `0x0040:0x001A` (**decimal `1050`**), the tail `0x0040:0x001C` (`1052`). Off-by-one reads a garbage pointer.
5. **"Continue Game" with no save → blank state**: When boot reaches world map with `Credits=0` and `StateArray[0..31]=0`, NEW_GAME_INIT never ran. Movement may be partially broken (W/X work, Q/A/E/D/Z/C may not). Fix: manually set `Credits` (a small value — `NEW_GAME_INIT` = 1500 cr is **wrong**) and walk onto the training-centre entrance tile, or restart and pick New Game (reliable). Movement is arrow keys; see `../engine/input-navigation.md`.
6. **Port 8081 in TIME_WAIT**: After restarting emulator, port 8081 (or any used MCP port) may be in TIME_WAIT for 60s. Use a different port or wait. Our config uses port 8086.
7. ~~**`bt_*` reads may use the wrong segment**~~ **FIXED (2026-09-28)**: game-state reads now use the game-state segment `0x2A0F`; the cursor uses the map segment `0x1DE9`. See the note at the top and `docs/UNVERIFIED_DISCOVERIES.md` §6.
8. **`bt_get_state.DsSegment`**: now reports the real `DS` (`0x1DE9` = `7657`). If it ever looks wrong, cross-check with `bt_read_registers`.
9. **`bt_screenshot` used a 16-colour table for all modes** (fixed 2026-09-27): mode-13h screens with a custom DAC palette rendered blank. It now uses the live DAC palette; `bt_read_palette` was added. The Python harness (`tools/playtest/bt.py`) can also render true-colour PNGs.

### Project Location

```
BattleTechMcpTools/              # In this repo (AIATTEMPT), NOT in Spice86
├── BattleTechMcpTools.csproj    # Project file (references ../../../Spice86/src/Spice86.Core + Spice86.Shared)
├── BattleTechOverrideSupplier.cs  # IOverrideSupplier + IMcpToolSupplier impl
└── BattleTechMcpTools.cs        # 23 tool implementations
```

