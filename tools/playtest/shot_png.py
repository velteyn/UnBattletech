#!/usr/bin/env python3
"""True-colour screenshot from the live emulator (mode 0x13 + live DAC palette).

Usage: python3 tools/playtest/shot_png.py [out.png]
"""
import http.client
import json
import struct
import sys


def api_get(addr, length):
    c = http.client.HTTPConnection("localhost", 20000, timeout=60)
    c.request("GET", f"/api/memory/{addr}/range/{length}")
    return json.loads(c.getresponse().read()).get("values", [])


def mcp_call(tool, params=None):
    import urllib.request
    body = json.dumps(
        {"jsonrpc": "2.0", "id": 1, "method": "tools/call",
         "params": {"name": tool, "arguments": params or {}}}
    ).encode()
    req = urllib.request.Request(
        "http://localhost:8086/mcp/", data=body,
        headers={"Content-Type": "application/json",
                 "Accept": "application/json, text/event-stream"})
    raw = urllib.request.urlopen(req, timeout=60).read().decode()
    # SSE-framed: one "data: {...}" line
    for line in raw.splitlines():
        line = line.strip()
        if line.startswith("data:"):
            payload = json.loads(line[5:])
            res = payload.get("result", {})
            sc = res.get("structuredContent")
            if sc is not None:
                return sc
            return res.get("content", res)
    raise RuntimeError("no SSE data frame in MCP response")


def main():
    out = sys.argv[1] if len(sys.argv) > 1 else "/tmp/shot.png"
    pal = mcp_call("bt_read_palette")
    entries = pal["Entries"] if isinstance(pal, dict) else pal
    pal_rgb = [((r * 255) // 63, (g * 255) // 63, (b * 255) // 63)
               for (r, g, b) in entries[:256]]
    while len(pal_rgb) < 256:
        pal_rgb.append((0, 0, 0))
    px = []
    for off in range(0, 64000, 16000):
        px += api_get(0xA0000 + off, 16000)
    from PIL import Image
    im = Image.new("RGB", (320, 200))
    im.putdata([pal_rgb[b] for b in px[:64000]])
    im = im.resize((640, 400), Image.NEAREST)
    im.save(out)
    print("saved", out)


if __name__ == "__main__":
    main()
