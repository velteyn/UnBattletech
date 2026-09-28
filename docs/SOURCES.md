# Sources & Evidence Policy

> How the RE record is built, and how to turn "something we read/remember" into a **verified** fact.
> Read alongside `README.md` §1 (the two deliverables) and §5 (retro archaeology).

The recreation **poses on the reverse engineering** (`README.md` §1). The RE in turn draws on several
kinds of source with different reliability. This file says what each source is authoritative for, and
the workflow that promotes a claim to "verified".

---

## 1. Source classes

| Class | On hand today | Authoritative for | **Not** authoritative for |
|---|---|---|---|
| **The executable** | `UNBTECH.exe` (unpacked via `exepack.exe`), `reko/` | actual behaviour — **ground truth**; when a source disagrees with the binary, **the binary wins** | design intent |
| **Runtime traces** | Spice86 emulator + 23 `bt_*` MCP tools; `tools/playtest/bt.py`; the `GAME1–6` save pack | exact runtime values / behaviour | intent, unseen code paths |
| **Original documents** | *original manual, clue/hint book — **to acquire*** | **design intent**, rules, terminology | exact runtime behaviour / numbers |
| **Published walkthroughs** | `docs/walkthrough/bt-walkthrough-1..3.md` | navigation, sequence of events, hints | exact numbers, code semantics |
| **Personal playtesting** | the author's sessions (logged in `UNVERIFIED_DISCOVERIES.md`, `AGENTS.md`) | what a player observes; **hypothesis generation** | things not yet reached; internal values |
| **Sibling games** | *Mines of Titan* (fingerprinted, `docs/engine/fingerprint-mines-of-titan.md`); later Westwood engines | shared **engine** structure/idioms | game-specific logic |
| **Decompiler output** | `reko/UNBTECH.exe.c` (+ `reko/segments/`) | control flow, data layout | optimised/ambiguous semantics; some segments absent (`19EF`, `1000`) |

Order of precedence for a *behavioural* claim: **executable / runtime trace > personal playtest
observation > original documents (intent) > walkthrough > inference**. For a *design-intent* claim the
original documents rank highest.

---

## 2. Evidence tags

Every factual claim in `docs/` gets one of:

- **✅ verified** — reproduced against the binary/emulator; cite the artifact (trace, screenshot,
  byte-compare) + date.
- **🟡 inferred** — consistent with evidence but not directly reproduced; state the basis.
- **❓ open** — known unknown; list what would settle it.

A claim with no tag is treated as **❓ open**.

---

## 3. Workflow: source → verified fact

1. **Capture the claim** from a source (manual line, walkthrough step, or a personal playtest
   observation). Write it as a testable hypothesis.
2. **Reproduce it** in the emulator: drive the original with `tools/playtest/bt.py`, capture the
   trace/screenshot/memory values via the `bt_*` tools.
3. **Decide**: if the source and the binary disagree, **record the binary's behaviour and mark the
   source claim as superseded** (e.g. the `NEW_GAME_INIT = 1500 cr` correction).
4. **Document** with the evidence tag + pointer; update every doc that repeats the old claim
   (Documentation Priority Rule, `AGENTS.md`).
5. **Only then** feed it into the recreation — or mark the recreation's behaviour as a **guess**.

---

## 4. Sources on hand vs to acquire

**On hand:** unpacked executable; full Reko decompilation; the 3 walkthroughs; the extracted story
text (`docs/story/STORY_TEXT.txt`); the 6-slot save pack; Mines of Titan for engine fingerprinting.

**To acquire (retro archaeology):**
- Original **manual** and the **clue/hint book** (Infocom).
- 1988–89 **magazine reviews** (design intent, screenshots showing intended UI).
- **Other-platform ports / "Gold" editions** (different compilers expose different structure).
- Additional **Westwood** titles for the viewport/engine model (Eye of the Beholder, Kyrandia,
  Lands of Lore).

Acquired material must be stored outside `original/` as **notes/citations** (not copyrighted text in
the repo), with each extracted fact re-verified per §3.

---

## 5. Playtest observation log

Personal experience is a first-class evidence source here. Each observation should record **date +
what was done + what was observed live**, and live in:

- `docs/UNVERIFIED_DISCOVERIES.md` — running log of observations and open questions.
- `docs/engine/*.md` — once a runtime mechanic is reproduced (input/navigation, combat flow, viewport).
- `AGENTS.md` — ops-facing gotchas and corrections.

Examples already promoted this way: arrow-key movement; tile-triggered building entry + walk-down
quirk; ComStar location/flow; cadet allowance behaviour; the `NEW_GAME_INIT` credits correction.
