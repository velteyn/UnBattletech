#!/usr/bin/env python3
"""BattleTech end-to-end playtest harness.

Drives the original game inside the Spice86 emulator through:
  * MCP tools   -> http://localhost:8086/mcp/   (bt_* introspection)
  * HTTP memory -> http://localhost:20000       (pause + raw memory + BDA key inject)

The keyboard buffer is injected into the real BIOS data area
(0x0040:0x001A head / 0x0040:0x001C tail, ring 0x0040:0x001E-0x043D), which the
emulator's INT 16h handler actually reads. NOTE: head/tail are at decimal
1050/1052 (0x41A/0x41C); an off-by-one reads a garbage pointer.

Usage:
    python3 bt.py state                 # snapshot: mode, cursor, credits, flags, state[]
    python3 bt.py tile                  # world-map tile under the cursor
    python3 bt.py key <ascii> <scan> [wait]
    python3 bt.py keys <name> [wait]    # space/enter/esc/w/x/a/d/q/e/z/c/y/n/1..4
    python3 bt.py shot                  # ASCII screenshot
    python3 bt.py boot                  # adapter+drive keys, then spaces -> main menu
"""
import http.client
import json
import sys
import time

MCP_HOST, MCP_PORT = "localhost", 8086
API_HOST, API_PORT = "localhost", 20000

# --- BIOS data area -----------------------------------------------------------
BDA_HEAD = 0x041A        # decimal 1050
BDA_TAIL = 0x041C        # decimal 1052
BDA_RING = 0x041E        # 32-byte ring buffer, 16 slots

# --- game data segment (world map); building interiors use 0x3858 ------------
DS_PHYS = 0x1DE90        # DS = 0x1DE9
OFF_CURSOR = 0xA44B      # uint16 X, uint16 Y at +2
OFF_CREDITS = 0xD370     # uint32
OFF_STATE = 0xD30C       # 256-byte state array
OFF_TRAINING = 0xD450    # byte
OFF_MILESTONE = 0xD451   # byte
OFF_TILEBUF = 0x0F00     # 128x128 world tile grid (row-major)

KEYS = {
    "space": (0x20, 0x39), "enter": (0x0D, 0x1C), "esc": (0x1B, 0x01),
    "w": (0x57, 0x11), "x": (0x78, 0x2D), "a": (0x61, 0x1E), "d": (0x64, 0x20),
    "q": (0x71, 0x10), "e": (0x65, 0x12), "z": (0x7A, 0x2C), "c": (0x63, 0x2E),
    "y": (0x79, 0x15), "n": (0x6E, 0x31),
    "up": (0x00, 0x48), "down": (0x00, 0x50), "left": (0x00, 0x4B), "right": (0x00, 0x4D),
    "1": (0x31, 0x02), "2": (0x32, 0x03), "3": (0x33, 0x04), "4": (0x34, 0x05),
}


# --- transport ----------------------------------------------------------------
def _api_get(path):
    c = http.client.HTTPConnection(API_HOST, API_PORT, timeout=10)
    c.request("GET", path)
    return json.loads(c.getresponse().read().decode())


def _api_put(addr, val):
    c = http.client.HTTPConnection(API_HOST, API_PORT, timeout=10)
    c.request("PUT", f"/api/memory/{addr}/byte",
              body=json.dumps({"value": val}),
              headers={"Content-Type": "application/json"})
    c.getresponse().read()


def _api_post(path):
    c = http.client.HTTPConnection(API_HOST, API_PORT, timeout=10)
    c.request("POST", path, body="{}", headers={"Content-Type": "application/json"})
    return json.loads(c.getresponse().read().decode())


def mem(addr, length):
    return _api_get(f"/api/memory/{addr}/range/{length}").get("values", [])


def mcp(name, args=None):
    c = http.client.HTTPConnection(MCP_HOST, MCP_PORT, timeout=20)
    body = json.dumps({"jsonrpc": "2.0", "id": 1, "method": "tools/call",
                       "params": {"name": name, "arguments": args or {}}})
    c.request("POST", "/mcp/", body=body,
              headers={"Content-Type": "application/json",
                       "Accept": "application/json, text/event-stream"})
    for line in c.getresponse().read().decode().splitlines():
        if line.startswith("data:"):
            return json.loads(line[5:])
    return None


# --- keyboard -----------------------------------------------------------------
def inject_key(ascii, scan, wait=0.35):
    _api_post("/api/status/pause")
    time.sleep(0.01)
    meta = mem(BDA_HEAD, 4)
    tail = meta[2] | (meta[3] << 8)
    nxt = BDA_RING + ((tail - BDA_RING + 2) % 32)
    _api_put(tail, ascii)
    _api_put(tail + 1, scan)
    _api_put(BDA_TAIL, nxt & 0xFF)
    _api_put(BDA_TAIL + 1, (nxt >> 8) & 0xFF)
    time.sleep(0.01)
    _api_post("/api/status/unpause")
    time.sleep(wait)


def press(name, wait=0.35):
    ascii_, scan = KEYS[name]
    inject_key(ascii_, scan, wait)


# --- state --------------------------------------------------------------------
def ds():
    r = mcp("bt_read_ds")
    try:
        return int(r["result"]["structuredContent"]["DS"], 16)
    except Exception:
        return 0x1DE9


def cursor():
    v = mem(DS_PHYS + OFF_CURSOR, 4)
    rx = v[0] | (v[1] << 8)
    ry = v[2] | (v[3] << 8)
    return rx, ry, (rx >> 1) & 0x7F, (ry >> 1) & 0x7F


def credits():
    v = mem(DS_PHYS + OFF_CREDITS, 4)
    return v[0] | (v[1] << 8) | (v[2] << 16) | (v[3] << 24)


def flags():
    v = mem(DS_PHYS + OFF_TRAINING, 2)
    return {"TrainingComplete": v[0], "Milestone": v[1]}


def state(n=32):
    return mem(DS_PHYS + OFF_STATE, n)


def tile_at(tx, ty):
    return mem(DS_PHYS + OFF_TILEBUF + ty * 128 + tx, 1)[0]


def video_mode():
    return mcp("bt_read_video_mode")["result"]["structuredContent"]


def snapshot():
    rx, ry, tx, ty = cursor()
    return {
        "mode": video_mode()["Mode"],
        "cursor_raw": (hex(rx), hex(ry)),
        "tile": (tx, ty),
        "credits": credits(),
        "flags": flags(),
        "state0_16": state(16),
    }


# --- actions ------------------------------------------------------------------
def boot():
    press("4", 2.5)   # MCGA / 256K EGA
    press("3", 2.5)   # drive C
    for _ in range(6):
        press("space", 1.2)


def shot():
    r = mcp("bt_screenshot")
    return r["result"]["structuredContent"]["AsciiArt"]


def palette():
    """256 RGB triples (0-255) from the live VGA DAC."""
    sc = mcp("bt_read_palette")["result"]["structuredContent"]
    if not sc.get("Available"):
        return None
    return [(e[0] * 255 // 63, e[1] * 255 // 63, e[2] * 255 // 63) for e in sc["Entries"]]


def render_png(path="/tmp/opencode/screen.png", scale=3):
    """Render the mode-13h framebuffer to a true-colour PNG using the live DAC palette."""
    from PIL import Image
    pal = palette()
    fb = mem(0xA0000, 64000)
    img = Image.new("RGB", (320, 200))
    px = img.load()
    for y in range(200):
        for x in range(320):
            i = fb[y * 320 + x]
            px[x, y] = pal[i] if pal else (i, i, i)
    img.resize((320 * scale, 200 * scale), Image.NEAREST).save(path)
    return path


def main(argv):
    if not argv:
        print(__doc__)
        return
    cmd, *rest = argv
    if cmd == "state":
        print(json.dumps(snapshot(), indent=2))
    elif cmd == "tile":
        rx, ry, tx, ty = cursor()
        print(f"tile=({tx},{ty}) raw=({hex(rx)},{hex(ry)}) value={tile_at(tx, ty)}")
    elif cmd == "credits":
        print(credits())
    elif cmd == "key":
        inject_key(int(rest[0], 0), int(rest[1], 0),
                   float(rest[2]) if len(rest) > 2 else 0.35)
    elif cmd == "keys":
        press(rest[0], float(rest[1]) if len(rest) > 1 else 0.35)
    elif cmd == "shot":
        print(shot())
    elif cmd == "png":
        print(render_png(rest[0] if rest else "/tmp/opencode/screen.png"))
    elif cmd == "boot":
        boot()
        print(json.dumps(snapshot(), indent=2))
    else:
        print(__doc__)


if __name__ == "__main__":
    main(sys.argv[1:])
