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

> ⚠️ **Known issue (2026-09-27): the `bt_*` tools may read the wrong segment.** During a live
> playthrough the left panel showed `C-Bills: 50` and a populated character, yet every
> game-state read at `DS:0x1DE9` returned zero, while the same offsets at **`ES:0x2A0F`**
> held the real data (credits 50, populated state array / story slots / unit slots).
> `DS` was stable at `0x1DE9`; `ES` toggled `0x2A0F` ↔ `0xA000` (video). See
> `docs/UNVERIFIED_DISCOVERIES.md` §6. Until resolved, cross-check reads against `ES`.

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
  - Navigate to tile (26,5) to trigger TRAINING.BLD which runs NEW_GAME_INIT, OR  
  - Manually write `Credits=1500` via HTTP API PUT and set StateArray entries

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

### World Map Movement

The world map uses a **hex-grid**. Building entry at a tile uses `D` (East key) — the game's east movement doubles as the "door/enter" action.

**Key mappings** from original game reference:

| Key | ASCII | Scan | Named Dir | Notes |
|-----|-------|------|-----------|-------|
| Q   | 0x51  | 0x10 | Northwest | Behavior is **position-dependent** — often works as West (0,-1) but can fail from some tiles |
| W   | 0x57  | 0x11 | North     | (0,-1) reliably from tested positions |
| E   | 0x45  | 0x12 | Northeast | Position-dependent |
| A   | 0x41  | 0x1E | West      | Often fails to move from many positions |
| S   | 0x53  | 0x1F | South     | (±1,-1) from some positions, may work where others fail |
| D   | 0x44  | 0x20 | East      | Also "enter building" at entrance tiles |
| Z   | 0x5A  | 0x2C | Southwest | Position-dependent |
| X   | 0x58  | 0x2D | South     | (0,+1) reliably from tested positions |
| C   | 0x43  | 0x2E | Southeast | Position-dependent |
| 1   | 0x31  | 0x02 | Numpad 1  | (+1,0) from some positions |

**Empirical findings** (June 2026): W (North) and X (South) are the most reliable directional keys. Q (West) and D (East) work from some positions but not all. The hex grid delta formula in `fn207F_0581` may encode additional facing/direction state in the high bits of raw cursor coordinates (bits 14-15 of raw Y at DS:0xA44B). The block of keys Q/A/E/D/Z/C seems tied to a "hex move" path that can fail when the game is in a degraded state (Continue Game with no save).

**Fallback navigation strategy**: When Q (NW) doesn't move, try W (N), X (S), 1 (E), S (SE-ish), then cycle back to Q. Some keys unstick the cursor where others fail.

**Navigation algorithm** (proven to work from any start near (34,12) to (26,5)):
1. Get current tile via `read_memory` at DS=0x1DE9 offset 0xA44B (4 bytes, 2× uint16 LE)
2. Convert: `TileX = (RawX & 0x7F) >> 1`, `TileY = (RawY & 0x7F) >> 1`
3. Prefer Q (NW) to move toward target X,Y
4. If blocked (Q doesn't move), try A (W), Z (SW), C (SE), E (NE), D (E) in sequence
5. At target tile, press D to enter building
6. Inside building (DS switches to 0x3858), press Space to advance dialog

**Obstacles**: Buildings (tile values 64+) block movement. Read world map tiles at DS:0x0F00 (128×128 grid, row-major) to check passability.

**Root cause (RESOLVED)**: The game runs with DOS default drive = `A:` (boot floppy in original hardware). `INFOCOM.CMP` was resolved to `A:\INFOCOM.CMP` but A: had no mounted host directory. **Fix**: Both A: and B: drives are mounted to the game data folder via the supported public API `machine.Dos.MountFolderAsFloppy()` from `BattleTechMcpTools/BattleTechOverrideSupplier.cs` (`MountGameDataOnFloppyDrives`). This keeps Spice86 upstream untouched — the mount previously lived in `DosDriveManager.cs` but was moved out so PR #2246 stays generic. Game files are accessible from all three drives.

### Why This Is Invaluable

1. **Automated testing against the Godot rebuild**: Read game state from Spice86 at a given point, then read the same state from the Godot rebuild and compare — catch discrepancies immediately.
2. **Script the game**: Automate entire playthroughs (training → citadel → shops → combat → cache → endgame) by injecting keystrokes and verifying state transitions.
3. **Snapshot & replay**: Capture full game state at key moments (training completion, combat start, shop interaction) for analysis and regression testing.
4. **Live introspection without breakpoints**: Query cursor position, credits, combat fog grids, or CPU registers at any moment without halting the emulator or setting breakpoints.
5. **Combat validation**: Read combat unit positions, fog grids, and unit status to verify AI behavior matches the original.

### DS-Relative Address Reference

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

### Boot & Navigation Workflow (Proven Script)

Full workflow: boot game → world map → navigate to (26,5) → enter training building:

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

def api_post(path):
    c = http.client.HTTPConnection("localhost", 20000, timeout=5)
    c.request("POST", path, body="{}",
        headers={"Content-Type": "application/json"})
    return json.loads(c.getresponse().read().decode())

phys = 0x1DE90  # game data segment physical base

def inject_key(ascii, scan, wait=0.3):
    api_post("/api/status/pause"); time.sleep(0.01)
    meta = api_get(0x041A, 4)
    tail = meta[2] | (meta[3] << 8)
    next_tail = 0x041E + ((tail - 0x041E + 2) % 32)
    api_put(tail, ascii)
    api_put(tail + 1, scan)
    api_put(0x041C, next_tail & 0xFF)
    api_put(0x041D, (next_tail >> 8) & 0xFF)
    time.sleep(0.01)
    api_post("/api/status/unpause"); time.sleep(wait)

def get_tile():
    tile = api_get(phys + 0xA44B, 4)
    if tile and len(tile) >= 4:
        rx = tile[0] | (tile[1] << 8)
        ry = tile[2] | (tile[3] << 8)
        return ((rx & 0x7F) >> 1, (ry & 0x7F) >> 1, rx, ry)
    return None

# Step 1: Boot (EGA=4, Drive=3)
inject_key(0x34, 0x05); time.sleep(2)  # 4 = MCGA/EGA
inject_key(0x33, 0x04); time.sleep(2)  # 3 = Drive C
for _ in range(10):
    inject_key(0x20, 0x39); time.sleep(1.5)  # Space to advance

# Step 2: Navigate to (26,5) using sequential key attempts
t = get_tile()
if t:
    tx, ty = t[0], t[1]
    for step in range(50):
        ty = get_tile()[1]
        inject_key(0x51, 0x10); time.sleep(0.4)  # Q (NW)
        t2 = get_tile()
        if t2 and t2[1] >= ty:  # Didn't go NW — try alternatives
            for k in [(0x41,0x1E),(0x5A,0x2C),(0x43,0x2E),(0x45,0x12),(0x44,0x20)]:
                inject_key(*k); time.sleep(0.4)
                t2 = get_tile()
                if t2 and t2 != t: break
        nt = get_tile()
        if nt and nt[0]==26 and nt[1]==5: break

# Step 3: Enter building
inject_key(0x44, 0x20); time.sleep(3)  # D = enter
for _ in range(8):
    inject_key(0x20, 0x39); time.sleep(1.5)  # Space inside building
```

### Known Issues

1. **`bt_inject_key` writes to wrong buffer**: Returns `Success=True` but writes to C# internal BIOS keyboard buffer, NOT to standard BIOS BDA at 0x0040:0x001E. The Spice86 INT 16h handler reads from the BDA buffer, so injected keys are silently lost.
2. **MCP `tools/list` returns 0 after extended runtime**: After >1B emulation cycles, `tools/list` may return empty tool array. Individual tools (by name) still work. Restart emulator to restore.
3. **`bt_get_state` cursor fields sometimes None**: `bt_read_memory` at DS=0x1DE9 offset 0xA44B is more reliable for cursor position.
4. **"Game freeze" is usually a BIOS key-wait, not a w014A stall** (re-diagnosed 2026-09-27): when it looks frozen, the CPU is typically spinning in the BIOS `int 16h` wait wrapper at `0x19FC:0xB57` (physical `0x1AB57`; bytes `cd 16 3c 00 75 04 8a c4 f6 d8 98 1f 5e 5f 5d cb`) *inside a building/dialog*, with cycles still advancing. `w014A=[2,2]` / `w0152=[4,4]` are usually side effects, not the cause. Clearing them does **not** unblock it — deliver a key instead: write ASCII at the BIOS buffer tail (`0x0040:0x001C`), scancode at tail+1, then advance tail by 2 (mod 32; ring `0x0040:0x001E`–`0x043D`). Verified: one Space (`0x20`/`0x39`) advances the dialog. Confirm with `bt_read_registers` / `/api/status` that `cs:ip == 19FC:B57`.
   - Watch the address: the head is `0x0040:0x001A` (**decimal `1050`**), the tail `0x0040:0x001C` (`1052`). Off-by-one reads a garbage pointer.
5. **"Continue Game" with no save → blank state**: When boot reaches world map with `Credits=0` and `StateArray[0..31]=0`, NEW_GAME_INIT never ran. Movement may be partially broken (W/X work, Q/A/E/D/Z/C may not). Fix: manually set `Credits=1500` and navigate to tile (26,5) for TRAINING.BLD, or restart and pick New Game (the reliable route).
6. **Port 8081 in TIME_WAIT**: After restarting emulator, port 8081 (or any used MCP port) may be in TIME_WAIT for 60s. Use a different port or wait. Our config uses port 8086.
7. **`bt_*` reads may use the wrong segment (2026-09-27)**: the tools read `DS` (`0x1DE9`), but live game state (credits/state/story/units) was observed at `ES` (`0x2A0F`). See the warning at the top and `docs/UNVERIFIED_DISCOVERIES.md` §6. This makes issue #5 look like a "blank state" when the data is actually present at `ES`.
8. **`bt_get_state.DsSegment` is wrong**: it reported `14424` (`0x3855`, actually `SS`), while the real `DS` is `0x1DE9` (`7657`) — use `bt_read_registers` for segments.
9. **`bt_screenshot` used a 16-colour table for all modes** (fixed 2026-09-27): mode-13h screens with a custom DAC palette rendered blank. It now uses the live DAC palette; `bt_read_palette` was added. The Python harness (`tools/playtest/bt.py`) can also render true-colour PNGs.

### Project Location

```
BattleTechMcpTools/              # In this repo (AIATTEMPT), NOT in Spice86
├── BattleTechMcpTools.csproj    # Project file (references ../../../Spice86/src/Spice86.Core + Spice86.Shared)
├── BattleTechOverrideSupplier.cs  # IOverrideSupplier + IMcpToolSupplier impl
└── BattleTechMcpTools.cs        # 23 tool implementations
```

