# Weapon System

> Consolidated reference for the weapon system — shareable. Sources: canonical
> [`../combat-system.md`](../combat-system.md) (§6.5 ammo, §6.6 cluster, §13/§20 weapon data) and the
> decompilation ([`../../reko/gencode/`](../../reko/gencode/)). Verified items are marked ✅; uncertain
> items ⚠️. Last pass: 2026-09-28 (roadmap B2).

## 1. Multi-shot weapons (SRM / LRM) — "SRM 6 and the rest" ✅

Multi-missile launchers fire as a **single aggregated salvo** — there is **no per-missile hit-location
rolling**. Verified in the decompilation against `1000:4F92`:

```
per_missile_damage = weapon_record[weapon].byte[+0x0B]     # LRM=1, SRM=2
cluster_col        = weapon_record[weapon].byte[+0x0C]     # 1=non-cluster; SRM2/4/6 → 2/3/5; LRM5/10/15/20 → 4/6/7/8
if bit7(ammo byte 0x2EE4) set → energy path (no cluster table)   # infinite ammo
if cluster_col <= 1          → single-shot path (no cluster table)

roll  = 2D6()                                  # 0000:30DD, calls the LFSR RNG
hits  = cluster_table[ roll*7 + cluster_col ]  # table via DS:[0x566C] + 0x2E5E, stride 7, rows 2..12
total_damage = per_missile_damage * hits       # applied to ONE hit location
```

- **Cluster hits table**: `DS:[0x566C] → 0x2E5E`, 7-byte stride per row (columns 0-6), 11 rows (2D6 = 2..12). The **column is per-weapon** (see `[+0x0C]` above).
- So an **SRM-6** rolls 2D6, looks up its column, gets the number of the 6 missiles that hit, and applies
  `2 × hits` damage to a **single** location — not six separate locations. Same for LRM-5/10/15/20.

## 2. Weapon **instance** struct (`DS:[0x5652] → 0x2EE4`, stride **0x11 / 17**) ✅

Runtime per-mounted-weapon state (read-only `0x2EE4` byte doubles as the cluster column above):

| Off | Abs | Meaning |
|-----|-----|---------|
| `+0x00` | `0x2EE4` | Ammo/type byte: **bit7 = infinite**, low7 = remaining shots; also the cluster-table column |
| `+0x01` | `0x2EE5` | Heat — **low nibble (`& 0x0F`)** added to the unit heat pool on fire (`1000:48E3`) |
| `+0x02` | `0x2EE6` | Skill class (low 5 bits; high 3 bits `>>5` as flags) |
| `+0x03` | `0x2EE7` | Range threshold byte |
| `+0x04` | `0x2EE8` | Weapon type id (used for comparisons) |

Ammo: energy weapons are `0x2EE4 == 0xFF` (infinite) and **skip the decrement**; per-mech ammo bins are
separate (see combat-system.md §19).

## 3. Weapon **definition** table (33 weapons, stride 17) — dumped from the binary

Located in `UNBTECH.exe` at file offset **`0x3D088`**, 33 records × 17 bytes, ending with `Kick`.
Names are 10 bytes ASCIIZ (`+0x00`). The trailing 7 bytes (offsets `+0x0A..+0x10`) are dumped verbatim
below; **field offsets are ⚠️ not fully verified** (see §4).

| # | Name | `+0A` | `+0B` | `+0C` | `+0D` | `+0E-0F` | `+10` |
|---|------|------|------|------|------|---------|------|
| 0 | Cudgel | 00 | 11 | 81 | 00 | 0221 | 00 |
| 1 | Knife | 00 | 10 | 81 | 00 | 0221 | 00 |
| 2 | Sword | 00 | 22 | 81 | 00 | 0221 | 00 |
| 3 | VibroBlade | 00 | 30 | 81 | 00 | 0221 | 00 |
| 4 | Shortbow | 00 | 11 | 81 | 00 | 0966 | 00 |
| 5 | Longbow | 00 | 13 | 81 | 00 | 0D87 | 00 |
| 6 | Crossbow | 00 | 23 | 81 | 00 | 0E88 | 00 |
| 7 | Pistol | 00 | 23 | 81 | 00 | 0965 | 01 |
| 8 | Rifle | 00 | 30 | 81 | 00 | 1FF0 | 02 |
| 9 | MachineGun | 00 | 30 | 84 | 00 | 0B88 | 02 |
| 10 | SR Missile | 00 | 02 | 01 | 00 | 28FF | 03 |
| 11 | Inferno | 00 | FF | 01 | 00 | 28FF | 03 |
| 12 | LaserPistl | 00 | 40 | 81 | 00 | 0D87 | 01 |
| 13 | LaserRifle | 00 | 42 | 81 | 00 | 2BF6 | 02 |
| 14 | Flamer | 00 | 20 | 81 | 00 | 0765 | 01 |
| 15 | SmallLaser | 00 | 03 | 01 | 01 | 0C43 | 03 |
| 16 | Med Laser | 00 | 05 | 01 | 03 | 1E87 | 03 |
| 17 | LargeLaser | 00 | 08 | 01 | 08 | 30CB | 03 |
| 18 | PPC | 00 | 0A | 01 | 3A | 39ED | 03 |
| 19 | AutoCann/2 | 00 | 02 | 01 | 41 | 4BF0 | 03 |
| 20 | AutoCann/5 | 00 | 05 | 01 | 31 | 39ED | 03 |
| 21 | AutoCann10 | 00 | 0A | 01 | 03 | 30CB | 03 |
| 22 | AutoCann20 | 00 | 14 | 01 | 07 | 1E87 | 03 |
| 23 | MachineGun | 00 | 02 | 01 | 00 | 0C43 | 03 |
| 24 | Flamer | 00 | 02 | 01 | 03 | 0C43 | 03 |
| 25 | LRMissile5 | 00 | 01 | 04 | 62 | 42EF | 03 |
| 26 | LRMissil10 | 00 | 01 | 06 | 64 | 42EF | 03 |
| 27 | LRMissil15 | 00 | 01 | 07 | 65 | 42EF | 03 |
| 28 | LRMissil20 | 00 | 01 | 08 | 66 | 42EF | 03 |
| 29 | SRMissile2 | 00 | 02 | 02 | 02 | 1E87 | 03 |
| 30 | SRMissile4 | 00 | 02 | 03 | 03 | 1E87 | 03 |
| 31 | SRMissile6 | 00 | 02 | 05 | 04 | 1E87 | 03 |
| 32 | Kick | 00 | 00 | 01 | 00 | 0221 | 04 |

## 4. Field-offset note (⚠️ — read this before trusting the old docs)

The *existing* `combat-system.md` §13 lists `Damage +0x0A, Shots +0x0B, Heat +0x0C, VFX +0x0D,
Range +0x0E, Skill +0x10`. **That looks shifted by one vs the binary dump above.** Evidence from the
dump (compare with tabletop stats):

- `+0x0B` matches **damage**: SmallLaser 3, Med 5, Large 8, PPC 0x0A=10, AC/20 0x14=20; LRM = 1 and
  SRM = 2 (per-missile) — exactly the cluster `0x2EE3` value the docs cite.
- `+0x0C` matches the **cluster column / volley**: 1 for single-shot; SRM2/4/6 → 2/3/5; LRM5/10/15/20 →
  4/6/7/8.
- `+0x10` matches the **skill class** (0 melee, 1 pistol, 2 rifle, 3 gunnery, 4 kick) — as documented.
- `+0x0D` is **ambiguous** (SmallLaser 1, Med 3, Large 8 look like heat, but PPC 0x3A=58 and AC/2
  0x41=65 look like sound/VFX ids) — **do not assume**.
- `+0x0E` range is a packed 16-bit value (not a plain distance); its packing is **undecoded**.

So: **treat the weapon-definition field offsets as provisional**; `+0x0B` = damage, `+0x0C` = cluster
column, `+0x10` = skill are the safe readings. A focused decode of `+0x0A`/`+0x0D`/`+0x0E` is still
open. Ping the project if you decode them — this is a known gap.

## 5. Cross-references

- Ammo model, heat generation, damage pipeline: [`../combat-system.md`](../combat-system.md) §6, §7, §19.
- Weapon combat data / templates: §13, §20.
- Cluster/hit-location tables: `[0x566C]:0x2E5E` (cluster), `[0x566A]:0x2E43` (hit location).
