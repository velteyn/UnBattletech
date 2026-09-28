# CONTEXT: BattleTech - The Crescent Hawk's Inception (1988) Reverse Engineering Project

> Master overview / status. Deep technical detail lives in the canonical
> docs listed in `docs/INDEX.md`; sections below link out instead of duplicating.

## Project Overview

This is an extensive reverse engineering effort targeting **BattleTech: The Crescent Hawk's Inception**, a 1988 MS-DOS 16-bit real-mode game by Infocom. The original executable `BTECH.EXE` was unpacked to `UNBTECH.EXE`. The project aims to fully understand the game's internals — code, data formats, game logic — to produce comprehensive documentation enabling a full rewrite with modern technologies.

**Current status:** see [`../README.md`](../README.md) §2 for the authoritative (honest) status matrix
and [`rebuild/roadmap.md`](rebuild/roadmap.md) for the plan. In short: the **RE record** is broad
(formats, story text, memory map) but combat internals, the viewport model and some story semantics
remain inferred/open; the **Godot rebuild** (`BattleTechCHI/`) reads original data files but
re-implements engine logic and has **not** been validated end-to-end.

---

## 1. EXECUTABLE & COMPILER

| Property | Value |
|----------|-------|
| **Original binary** | `BTECH.EXE` (packed) |
| **Unpacked binary** | `UNBTECH.EXE` |
| **Platform** | MS-DOS 16-bit Real Mode (MZ executable) |
| **Compiler** | Microsoft C 5.0 (identified by Reko decompiler) |
| **Entry point** | `19EF:2D82` (linear 0x1CC72) |
| **Code segments** | `0800`, `0D27`, `0DAB`, `0FDC`, `11B8`, `135D`, `1431`, `1467`, `1543`, `1631`, `183B`, `1AE8`, `1CD3`, `1E56`, `1F3D`, `1FC5`, `204B`, `207F`, `246C`, `2FE8`, `3056`, `3058`, `305B`, `3092`, `3EDB` |

---

## 2. DECOMPILATION & ANALYSIS TOOLS

See [`docs/tools/analysis-tools.md`](tools/analysis-tools.md) for the tool inventory
(Reko, Spice86, Ghidra, InceptionTools, Python scripts).

## 3. MEMORY MAP & DATA SEGMENTS

See [`docs/formats/memory-map.md`](formats/memory-map.md) for the full memory map.
Story-slot layout and the progression mechanism (`fn1631_11AB`) are in
[`docs/story/story-system.md`](story/story-system.md).

## 4. FILE FORMATS

See the canonical format specs: [`formats/file-formats.md`](formats/file-formats.md),
[`formats/bld-bytecode.md`](formats/bld-bytecode.md),
[`formats/anm-format.md`](formats/anm-format.md).

## 5. COMBAT SYSTEM

See [`docs/combat-system.md`](combat-system.md).

## 6. WORLD MAP SYSTEM

See [`docs/world-map.md`](world-map.md).

## 7. RENDERING & GRAPHICS PIPELINE

See [`engine/viewport.md`](engine/viewport.md) (viewport model, `w4FBA`/`w4FBC`/`tB764`, borders,
3-pass pipeline, blitter, image pipeline) and [`formats/file-formats.md`](formats/file-formats.md)
(CMP/ICN RLE, ANM XOR-delta frames). Extracted assets are listed there and under
[`tools/analysis-tools.md`](tools/analysis-tools.md).

---

## 8. GAME SYSTEMS (Identified from Strings & Code)

- **Story / characters / economy** (Jason Youngblood; Katrina; Jeremiah; Rex Pearce; Dr. Tellhim;
  Rick Atlas; …; C-Bills; stocks DefHes/NasDiv/BakPhar) → [`story/story-arc.md`](story/story-arc.md),
  [`story/story-system.md`](story/story-system.md) §17.11.
- **Combat units / weapons / armour / critical locations** (33 weapons; body locations) →
  [`combat-system.md`](combat-system.md) §20.
- **RPG stats & skills** (Body/Dexterity/Charisma; Bows&Blades, Pistol, Rifle, Gunnery, Piloting,
  Tech, Medical) → [`story/story-system.md`](story/story-system.md) §17.7.
- **Equipment shops / garage / repair / tech** → [`story/story-system.md`](story/story-system.md) §17.11.

---

## 9. GODOT 4 + C# ENGINE REBUILD

See [`docs/rebuild/progress.md`](rebuild/progress.md) (status) and
[`docs/rebuild/roadmap.md`](rebuild/roadmap.md) (phases).

## 10. .NET ASSET EXTRACTION TOOLKIT (InceptionTools)

See [`docs/tools/analysis-tools.md`](tools/analysis-tools.md).

## 11. PYTHON ANALYSIS SCRIPTS

See [`docs/tools/analysis-tools.md`](tools/analysis-tools.md).

## 12. STORY SUMMARY

See [`docs/story/story-arc.md`](story/story-arc.md) (narrative) and
[`docs/story/story-system.md`](story/story-system.md) (internals).
## 13. WHAT'S KNOWN VS UNKNOWN

> Canonical per-topic status lives in the topic docs (and `README.md` §2). This is a pointer summary,
> not a restatement.

**Solid / verified:** executable structure & compiler (MS C 5.0, entry `19EF:2D82`); BLD format +
cipher + story text (round-trip byte-identical); segment/memory map; `.MTP`/save/mech/weapon formats;
world-map & local-map structure; combat fog of war; viewport/rendering model (`engine/viewport.md`).

**Partial / inferred:** combat internals (some formulas inferred, never diffed against the original);
story-state semantics (`b0057` et al.); map→BLD trigger table `[0x5460]:0x4602`; viewport struct
push/pop; save round-trip.

**Open:** sound/music format (*out of scope for the recreation* — replace with modern audio); ~1400
unlabelled Reko functions; EGA animation edge cases.

See: [`combat-system.md`](combat-system.md) §15, [`world-map.md`](world-map.md) §18.6,
[`story/story-system.md`](story/story-system.md) §17.13, [`engine/viewport.md`](engine/viewport.md),
[`UNVERIFIED_DISCOVERIES.md`](UNVERIFIED_DISCOVERIES.md), [`SOURCES.md`](SOURCES.md).

## 14. NEXT STEPS & RECOMMENDATIONS

See [`docs/rebuild/roadmap.md`](rebuild/roadmap.md).
