#!/usr/bin/env python3
"""T3 Phase-1 trace helpers: snapshot live emulator state to JSON, diff two snapshots.

v1 = snapshot/diff only (manual drive between snapshots). Scripted orders = v2.
See docs/t3-differential.md.

Usage:
  python3 tools/playtest/t3_trace.py snap <label>     # write trace_<label>.json
  python3 tools/playtest/t3_trace.py diff <a> <b>     # diff trace_<a>.json vs trace_<b>.json
"""
import http.client, json, sys, time

BASE = 0x2A0F0          # live story-segment base (load seg L=0x2A0F verified)
STORY = 0xC724           # slot base; stride 0x7D; +0x11..+0x1B current armor[11]
RNG_PHYS = 0x38580 + 0x4FC0   # 3-byte 0BC0 state at main-DS 0x4FC0

def rd(phys, ln):
    c = http.client.HTTPConnection('localhost', 20000, timeout=10)
    c.request('GET', f'/api/memory/{phys}/range/{ln}')
    return bytes(json.loads(c.getresponse().read()).get('values', []))

def snap_slot(slot):
    base = BASE + STORY + slot * 0x7D
    armor = list(rd(base + 0x11, 11))
    mx = list(rd(base + 0x56, 11))
    aux = list(rd(base + 0x1C, 8))
    name = rd(base, 10)
    return {'slot': slot, 'name': bytes(name).decode('ascii', 'replace').rstrip('\x00'),
            'armor': armor, 'max': mx, 'aux': aux}

def snap(label):
    doc = {'label': label, 't': time.strftime('%Y-%m-%dT%H:%M:%S'),
           'rng': list(rd(RNG_PHYS, 3)),
           'slots': [snap_slot(s) for s in range(8)]}
    fn = f'trace_{label}.json'
    json.dump(doc, open(fn, 'w'), indent=1)
    print(f'wrote {fn} rng={" ".join(f"{b:02x}" for b in doc["rng"])}')
    return fn

def diff(a, b):
    A = json.load(open(f'trace_{a}.json')); B = json.load(open(f'trace_{b}.json'))
    print(f'rng: {" ".join(f"{x:02x}" for x in A["rng"])} -> {" ".join(f"{x:02x}" for x in B["rng"])}')
    for sa, sb in zip(A['slots'], B['slots']):
        da = [f'{i}:{x}->{y}' for i, (x, y) in enumerate(zip(sa['armor'], sb['armor'])) if x != y]
        dm = [f'{i}:{x}->{y}' for i, (x, y) in enumerate(zip(sa['max'], sb['max'])) if x != y]
        dx = [f'{i}:{x}->{y}' for i, (x, y) in enumerate(zip(sa['aux'], sb['aux'])) if x != y]
        if da or dm or dx:
            print(f'slot{sa["slot"]} ({sa["name"]}): armor[{", ".join(da)}] max[{", ".join(dm)}] aux[{", ".join(dx)}]')
    print('done (no output above = identical)')

if __name__ == '__main__':
    if len(sys.argv) < 3: sys.exit('usage: snap <label> | diff <a> <b>')
    if sys.argv[1] == 'snap': snap(sys.argv[2])
    elif sys.argv[1] == 'diff': diff(sys.argv[2], sys.argv[3])
