#!/usr/bin/env python3
"""BattleTech CHI — ASCII Terminal Viewer (Dwarf Fortress-style)
Shows world map, local maps, buildings, NPCs, and BLD dialogue."""

import os, sys, struct, time, termios, tty, select, signal, shutil

# ═══════════════════════════════════════════════════════════════
# World Map Data — PacificaIsland 64×64 (0=water,1=land,2=city,3=special)
# Extracted from WorldMapData.cs
# ═══════════════════════════════════════════════════════════════
_PACIFICA = bytes([
0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
0,0,1,1,1,1,2,1,2,1,1,1,1,1,1,1,1,1,1,1,2,1,2,1,1,1,3,1,1,1,2,1,2,2,1,3,1,1,2,1,2,1,2,1,1,1,1,1,1,1,1,1,1,1,1,3,0,0,0,0,0,0,0,0,
0,0,1,1,1,2,1,1,3,1,1,1,2,2,1,1,1,1,1,3,2,1,1,1,3,1,1,1,1,1,1,2,1,1,3,1,1,1,1,1,2,1,1,1,3,1,3,2,1,2,1,1,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,3,2,1,1,1,3,2,1,1,1,1,2,1,2,1,1,1,1,3,2,2,1,1,1,3,1,1,1,2,2,1,1,1,1,2,1,1,1,2,1,1,3,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,3,2,1,1,1,1,1,3,1,1,2,2,1,1,1,1,1,2,1,3,1,1,1,2,1,1,1,1,1,1,3,1,2,1,1,3,2,3,3,2,1,1,1,1,1,1,3,1,2,1,1,3,3,1,0,0,0,0,0,0,0,
0,0,2,1,1,3,1,1,2,1,1,1,2,1,3,1,1,1,1,1,1,2,1,1,1,1,1,1,3,1,2,1,1,1,1,1,2,1,1,3,3,1,1,1,3,2,2,1,1,2,2,1,3,1,1,2,1,0,0,0,0,0,0,0,
0,0,1,3,1,1,1,1,1,1,2,1,1,1,1,3,2,1,1,1,1,2,1,1,2,1,1,1,1,2,3,1,2,1,1,1,1,2,2,2,2,1,1,1,2,2,1,1,1,3,2,3,2,2,1,1,1,0,0,0,0,0,0,0,
0,0,3,2,2,2,1,2,1,2,2,1,2,1,1,2,1,1,1,1,2,3,1,1,1,3,1,3,1,3,1,3,1,1,1,2,1,1,1,1,1,1,2,1,3,1,2,2,1,1,1,1,1,1,2,2,1,0,0,0,0,0,0,0,
0,0,1,1,1,1,1,1,3,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,1,1,1,1,3,2,1,1,1,1,1,2,2,1,1,1,1,1,0,0,0,0,0,0,0,
0,0,1,2,1,1,1,1,1,1,1,1,1,2,2,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,1,1,1,2,1,2,1,3,1,3,2,1,2,1,2,1,2,0,0,0,0,0,0,0,0,
0,0,2,1,1,1,1,2,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,2,1,1,1,1,1,1,3,1,1,2,2,1,1,1,2,0,0,0,0,0,0,0,0,
0,0,2,3,1,2,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,2,1,2,2,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,3,1,1,2,1,2,3,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,2,1,1,2,1,2,3,1,1,1,1,3,1,2,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,2,2,1,1,3,2,1,1,1,1,1,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,3,1,2,2,1,2,3,1,2,1,1,1,2,1,2,2,0,0,0,0,0,0,0,0,
0,0,1,2,1,1,1,1,1,2,1,1,2,1,2,2,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,1,2,1,2,1,1,1,2,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,2,1,2,1,1,1,1,1,1,2,1,1,1,2,3,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,3,1,1,1,2,1,2,1,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,3,1,2,1,1,1,1,1,1,1,3,1,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,1,2,1,1,1,1,2,3,1,1,1,2,3,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,1,1,1,1,2,2,1,1,3,2,1,1,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,3,2,1,1,1,2,1,1,1,1,1,3,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,1,1,3,2,1,3,3,1,1,1,2,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,1,1,1,1,1,1,1,1,2,1,1,1,3,2,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,3,1,1,3,1,1,1,1,1,2,1,2,1,1,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,3,1,1,1,1,1,1,3,3,1,1,2,1,2,1,0,0,0,0,0,0,0,0,
0,0,1,2,3,1,1,1,3,1,2,2,1,2,1,3,1,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,3,1,1,1,1,1,1,1,1,1,1,1,1,2,1,0,0,0,0,0,0,0,0,
0,0,2,2,2,1,1,2,3,1,1,1,1,2,2,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,1,1,1,1,3,1,1,1,2,2,2,1,1,2,2,2,1,0,0,0,0,0,0,0,0,
0,0,1,1,3,3,2,1,1,1,2,1,1,3,1,2,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,2,1,1,2,1,1,3,1,1,1,1,1,2,3,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,1,1,1,1,2,1,1,1,1,1,1,3,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,1,1,1,1,2,1,1,1,3,1,2,1,1,1,1,1,2,0,0,0,0,0,0,0,0,
0,0,1,2,1,3,1,1,1,1,2,1,1,2,1,1,1,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,3,2,1,2,1,2,2,1,1,3,1,3,2,2,3,3,2,0,0,0,0,0,0,0,0,
0,0,1,2,1,1,1,1,1,1,2,3,1,1,1,2,1,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,2,3,1,1,1,3,1,1,1,2,1,1,1,2,3,1,0,0,0,0,0,0,0,0,
0,0,2,1,1,1,1,1,3,1,1,1,3,2,1,1,1,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,2,1,1,1,1,1,2,1,1,1,1,2,1,1,0,0,0,0,0,0,0,0,
0,0,2,1,1,3,1,2,1,1,1,1,1,1,1,2,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,2,1,2,1,2,1,1,1,3,1,2,2,1,1,3,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,1,3,1,1,1,1,1,1,1,1,3,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,2,2,1,2,2,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,3,1,2,1,1,2,2,1,1,1,1,1,1,1,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
0,0,2,3,1,1,1,1,1,1,1,2,1,2,1,2,2,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
0,0,2,1,1,1,3,2,1,1,2,1,1,1,2,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
0,0,1,1,2,1,1,1,1,2,2,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
0,0,1,1,1,1,2,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
0,0,1,1,1,1,1,2,1,1,2,1,2,2,1,2,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
0,0,3,2,1,1,2,1,1,1,1,2,1,2,3,1,2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
0,0,1,1,1,1,1,1,1,1,1,1,3,1,2,2,2,1,1,1,1,2,1,1,2,1,2,2,1,3,1,1,1,2,1,1,1,1,1,1,1,1,1,1,1,2,1,2,2,1,1,1,1,2,2,1,0,0,0,0,0,0,0,0,
0,0,2,1,1,1,1,1,1,2,1,2,1,1,1,1,1,1,1,1,1,1,1,1,2,1,1,1,1,1,2,1,3,2,1,1,1,1,3,1,1,1,3,1,1,2,2,1,2,2,1,1,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,1,3,1,1,1,1,2,1,2,2,2,1,1,2,1,1,1,2,2,2,1,1,1,1,1,1,1,2,1,1,1,2,1,2,1,3,3,1,1,1,1,3,2,2,1,1,1,2,1,1,2,2,1,0,0,0,0,0,0,0,0,
0,0,2,1,3,1,1,3,1,1,1,1,1,1,1,3,1,1,3,2,1,2,1,1,2,1,1,2,1,1,1,1,2,1,2,1,1,1,1,1,1,2,1,1,3,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,3,1,1,1,3,1,1,1,1,3,1,1,2,1,2,1,2,2,1,1,1,2,1,2,1,1,1,2,1,2,1,1,1,1,1,3,1,3,1,1,2,1,1,2,2,1,1,1,2,2,2,1,3,1,0,0,0,0,0,0,0,0,
0,0,1,3,1,2,2,1,1,2,1,1,1,1,1,1,1,1,1,1,2,1,3,1,3,3,1,1,1,2,1,3,1,1,2,1,1,2,1,1,1,1,1,3,1,2,1,1,1,1,1,1,2,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,3,1,3,1,1,2,1,2,1,1,1,2,1,1,1,1,2,2,2,3,1,2,1,1,1,1,2,1,1,1,2,1,1,1,1,3,2,1,2,2,1,3,1,1,1,1,2,2,1,1,3,0,0,0,0,0,0,0,0,
0,0,1,3,1,1,1,1,1,2,1,3,2,2,1,1,1,1,1,1,1,1,3,1,1,2,1,2,1,2,1,1,1,1,1,2,1,1,1,1,1,3,1,2,1,1,1,1,1,1,1,1,1,2,2,2,0,0,0,0,0,0,0,0,
0,0,3,1,1,1,1,1,1,1,1,1,1,1,1,2,1,1,1,1,2,1,1,1,1,1,3,1,3,1,1,1,1,2,1,1,1,2,1,2,2,2,1,1,1,1,1,1,1,2,1,3,1,1,3,1,0,0,0,0,0,0,0,0,
0,0,2,1,3,2,1,1,1,1,1,1,1,1,1,1,1,1,1,3,2,1,1,2,1,2,1,2,1,1,3,1,2,2,1,1,1,3,2,2,1,2,1,1,1,1,2,1,1,1,3,1,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,2,3,2,2,1,1,1,1,1,1,1,1,3,1,1,2,2,1,1,1,1,1,1,1,3,1,1,1,2,1,1,3,2,1,1,1,1,3,2,3,2,1,1,2,1,1,1,1,1,1,3,1,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,1,1,1,1,1,2,1,2,1,1,3,1,3,2,1,1,3,1,1,3,1,1,1,2,3,3,1,2,1,3,3,1,1,3,3,3,2,1,1,1,3,1,3,1,1,3,2,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,2,2,1,2,1,2,2,2,1,1,1,1,1,1,1,1,1,1,1,1,2,3,1,2,1,1,1,1,1,1,1,1,2,2,1,1,3,1,1,1,1,2,1,1,1,1,1,1,1,2,2,1,0,0,0,0,0,0,0,
0,0,1,2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,1,1,1,1,2,2,1,2,2,1,1,1,1,3,3,1,3,1,1,2,2,3,1,1,3,1,2,3,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,2,1,1,1,1,1,1,1,2,1,1,1,3,2,1,2,1,2,2,1,1,1,1,1,2,1,2,1,1,1,2,1,1,1,2,2,1,1,1,1,1,1,1,1,1,1,3,2,3,1,1,1,3,0,0,0,0,0,0,0,0,
0,0,3,1,2,1,1,1,1,2,1,2,1,2,2,3,1,3,1,1,1,1,1,3,2,1,2,1,1,1,1,2,1,2,2,1,1,2,1,3,1,3,3,1,3,1,1,1,1,3,1,2,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,1,1,2,3,1,1,1,1,1,1,3,1,1,1,1,1,2,1,1,1,1,2,3,1,1,1,2,1,2,1,3,1,1,1,1,2,3,1,2,1,2,1,2,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,1,1,1,1,1,3,1,2,1,2,3,1,1,1,1,1,2,1,1,1,1,1,3,1,1,2,1,2,2,1,1,1,1,1,1,1,1,2,1,2,1,1,1,1,2,2,1,1,1,3,2,1,1,3,0,0,0,0,0,0,0,0,
0,0,0,1,3,1,2,2,1,1,1,1,2,1,2,1,2,1,3,2,1,3,1,1,2,1,2,3,1,2,1,1,3,1,1,3,1,1,1,1,1,2,2,1,1,2,1,2,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,3,3,3,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,3,1,1,2,1,1,2,2,3,1,1,3,1,1,3,3,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,0,1,1,2,1,1,1,1,1,1,1,3,1,2,1,1,1,2,2,1,1,1,1,1,2,2,1,3,1,1,1,3,1,1,2,1,2,1,1,1,2,1,1,1,1,3,1,1,2,3,1,1,1,1,0,0,0,0,0,0,0,0,
0,0,0,1,1,1,1,1,2,1,1,1,1,1,1,3,1,3,1,1,1,1,1,1,1,1,1,1,2,1,2,1,1,1,3,1,1,1,1,3,1,1,1,1,1,1,1,1,1,1,2,1,2,2,1,1,0,0,0,0,0,0,0,0,
0,0,0,2,1,1,1,1,2,1,1,1,1,1,1,2,1,2,2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,3,1,1,1,1,2,1,1,1,2,0,0,0,0,0,0,0,0,
0,0,0,1,1,1,1,1,2,2,1,1,1,2,2,1,2,1,2,1,3,1,2,2,1,3,1,1,2,1,3,2,1,2,1,1,2,1,1,1,1,1,1,1,1,1,1,2,1,1,2,3,1,1,3,2,0,0,0,0,0,0,0,0,
0,0,0,3,3,2,1,2,1,2,2,2,1,1,1,1,1,1,1,2,1,1,1,3,1,3,1,1,2,2,2,1,1,1,1,1,1,1,1,1,2,1,1,1,1,1,1,1,1,2,1,1,2,1,1,3,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
])

assert len(_PACIFICA) == 4096, f"PacificaIsland wrong size: {len(_PACIFICA)}"
_WORLD = [[_PACIFICA[y*64+x] for x in range(64)] for y in range(64)]

# ═══════════════════════════════════════════════════════════════
# Game Data
# ═══════════════════════════════════════════════════════════════
POIS = [
    (26, 5, "Training Center / Citadel"),
    (28, 10, "Main City Hub"),
    (32, 18, "East-Central Settlement"),
    (10, 10, "Northwest Outpost"),
    (55, 8, "Southeast Island (Cache)"),
    (9, 21, "West Coast Town"),
    (42, 25, "Central Village"),
    (5, 49, "Southern Town 1"),
    (5, 54, "Southern Town 2"),
    (5, 59, "Southern Town 3"),
    (33, 49, "Large Southern City"),
]

BUILDINGS = [
    ("TRAINING", 26, 5, 1), ("CITADEL", 26, 6, 1),
    ("BARRACKS", 28, 11, 2), ("BARRACK2", 29, 11, 2),
    ("COMSTAR", 27, 9, 2), ("INSTRUCT", 27, 5, 1),
    ("GARAGE", 29, 12, 2), ("HOSPITAL", 28, 12, 2),
    ("WEAPON", 29, 10, 2), ("WEAPON2", 30, 10, 2),
    ("ARMOR", 28, 9, 2), ("CLOTHES", 27, 10, 2),
    ("LOUNGE", 30, 11, 2), ("THEATER", 27, 12, 2),
    ("VIEWDISK", 27, 12, 2), ("JAIL", 5, 54, 3),
    ("MAYOR", 5, 55, 3), ("FINDIT", 55, 8, 4),
    ("FROB", 32, 18, 5), ("PARTY", 28, 10, 2),
    ("HUT", 10, 10, 6), ("ENTRANCE", 33, 49, 7),
    ("ARENA", 30, 8, 2), ("REPAIR", 28, 13, 2),
    ("WINSCENE", 26, 5, 1), ("ENDMECH", 26, 5, 1),
]

# ═══════════════════════════════════════════════════════════════
# ANSI Terminal Helpers
# ═══════════════════════════════════════════════════════════════
CSI = "\x1b["
RSET = CSI + "0m"
HIDE = CSI + "?25l"
SHOW = CSI + "?25h"
CLS = CSI + "2J"

def pos(y, x): return f"{CSI}{y};{x}H"
def cset(fg=None, bg=None):
    parts = []
    if fg is not None: parts.append(f"38;5;{fg}")
    if bg is not None: parts.append(f"48;5;{bg}")
    return CSI + ";".join(parts) + "m" if parts else RSET

# ═══════════════════════════════════════════════════════════════
# Tile → ASCII/Color Mappings
# ═══════════════════════════════════════════════════════════════
# World map: 0=water, 1=land, 2=city, 3=special
WCH = {0: "\u2248", 1: "\u00B7", 2: "\u2592", 3: "\u2666"}
WFG = {0: 33, 1: 34, 2: 130, 3: 220}
WBG = {0: 17, 1: 22, 2: 52, 3: 58}

def _lmap(t):
    # GRASS: tiles where dominant=green
    if t in range(0,7) or t in (8,9,10,12) or t in range(16,59) or t in (60,61):
        return ("\u00B7", 34, 22)
    if t in range(64,75) or t in range(77,81) or t in range(82,85):
        return ("\u00B7", 34, 22)
    if t in (95,99) or t in (104,106,107,110) or t in (159,160,167):
        return ("\u00B7", 34, 22)
    if t in (178,179,186,187) or t in (198,200,212,230,237,244):
        return ("\u00B7", 34, 22)
    # WATER: tiles where dominant=blue
    if t in (7,11,13,14,15,85,96,105,111,112,114):
        return ("\u2248", 33, 17)
    if t in range(127,130) or t in range(135,141) or t in (142,144,145,150):
        return ("\u2248", 33, 17)
    if t in (175,189,191) or t in (201,202) or t in (222,223,225,226,228):
        return ("\u2248", 33, 17)
    if t in range(231,235) or t in (241,246,247):
        return ("\u2248", 33, 17)
    # DARK/WALL: tiles where dominant=dark/black
    if t in range(87,93) or t in (94,97,98) or t in range(100,103):
        return ("\u2593", 240, 233)
    if t in (108,109) or t in range(130,135) or t in (141,143) or t in range(146,149):
        return ("\u2593", 240, 233)
    if t in range(151,155) or t in range(156,159) or t in (162,163,169,176):
        return ("\u2593", 240, 233)
    if t in (180,181,183,184) or t in (206,210,215,217,227,229):
        return ("\u2593", 240, 233)
    # GRAY/ROAD: tiles where dominant=light gray
    if t in range(115,127) or t in (190,) or t in range(192,198) or t in (199,):
        return ("\u2591", 250, 236)
    if t in range(203,206) or t in (207,218):
        return ("\u2591", 250, 236)
    # RED special tiles
    if t in (93,211,213,214,216):
        return ("!", 196, 52)
    # PURPLE special tiles
    if t in (113,188,209,236,238,239,242,243,245,248,249):
        return ("\u2666", 129, 52)
    # YELLOW/BROWN miscellaneous
    if t in (59,62,63,75,76,81,86,103,155,161,168,177,182,185,208,224,235,240):
        return ("\u00B7", 130, 58)
    # UNKNOWN — try grass
    if t in (164,165,166,170,171,172,173,174,219,220,221):
        return ("\u00B7", 34, 22)
    return ("?", 15, 0)

def _wrap(text, width):
    ws = []
    for w in text.split():
        if not ws: ws.append(w)
        elif len(ws[-1]) + 1 + len(w) < width: ws[-1] += " " + w
        else: ws.append(w)
    return ws

# ═══════════════════════════════════════════════════════════════
# MTP Parser
# ═══════════════════════════════════════════════════════════════
def parse_mtp(path, map_id):
    try:
        with open(path, "rb") as f: data = f.read()
    except FileNotFoundError: return None
    pos = 0
    pos += 3  # header
    if pos >= len(data): return None
    w = data[pos]; pos += 1
    h = data[pos]; pos += 1
    if pos + 0x80 + 0x100 + 0x98 > len(data): return None
    
    npc_names = []
    for _ in range(8):
        end = pos
        while end < len(data) and data[end] != 0: end += 1
        npc_names.append(data[pos:end].decode("ascii", errors="replace") if end > pos else "")
        pos = end + 1
    
    bld_raw = data[pos:pos+256]; pos += 256
    bld_names = []
    p = 0
    while p < len(bld_raw):
        if bld_raw[p:p+3] == b"MAP": break
        end = p
        while end < len(bld_raw) and bld_raw[end] != 0: end += 1
        if end > p: bld_names.append(bld_raw[p:end].decode("ascii", errors="replace"))
        p = end + 1
        if p >= len(bld_raw): break
    
    b0, b1, b2, b3 = data[pos:pos+32], data[pos+32:pos+64], data[pos+64:pos+96], data[pos+96:pos+128]
    b4 = data[pos+128:pos+144]
    pos += 0x98
    
    mx, my = w - 1, h - 1
    npc_p = [(b0[i*2] & mx, b1[i*2] & my) for i in range(min(8, len(b0)//2, len(b1)//2))]
    bld_p = [(b2[i*2] & mx, b3[i*2] & my) for i in range(min(8, len(b2)//2, len(b3)//2))]
    
    raw = data[pos:]
    if map_id in (1, 2, 11, 12, 13, 14):
        tw = (w + 7) // 8 * 8
        th = (h + 7) // 8 * 8
        tiles = [0] * (tw * th)
        si = 0
        for by in range(0, th, 8):
            for bx in range(0, tw, 8):
                for ty in range(8):
                    for tx in range(8):
                        if si < len(raw):
                            idx = (by + ty) * tw + (bx + tx)
                            if idx < len(tiles): tiles[idx] = raw[si]
                        si += 1
    else:
        sz = w * h
        tiles = list(raw[:sz]) if sz <= len(raw) else list(raw) + [0]*(sz - len(raw))
    
    return {"w": w, "h": h, "tiles": tiles, "npc_names": npc_names,
            "npc_pos": npc_p, "bld_names": bld_names, "bld_pos": bld_p}

# ═══════════════════════════════════════════════════════════════
# BLD Cipher & Text Decoder
# ═══════════════════════════════════════════════════════════════
CIPHER = {
    0x57:'i',0x58:'h',0x59:'k',0x5A:'j',0x5B:'m',0x5C:'l',
    0x5D:'o',0x5E:'n',0x5F:'a',0x60:'q',0x61:'c',0x62:'b',
    0x63:'e',0x64:'d',0x65:'g',0x66:'f',0x67:'y',0x68:'x',
    0x69:'i',0x6A:'z',0x6C:'l',0x6D:'m',0x6E:'n',0x6F:'o',
    0x70:'p',0x71:'s',0x72:'r',0x73:'u',0x74:'t',0x75:'w',
    0x76:'v',0x77:'I',0x78:'H',0x79:'K',0x7A:'J',0x7B:'M',
    0x7C:'L',0x7D:'O',0x7E:'N',0x7F:'A',
    0x81:'C',0x82:'B',0x83:'E',0x84:'D',0x85:'G',0x86:'F',
    0x87:'Y',0x90:'P',0x91:'S',0x92:'R',0x93:'U',0x94:'T',
    0x95:'W',0x96:'V',
}

def decode_bld(data):
    r = []
    for b in data:
        if b == 0: break
        if b == 0xA0: r.append(' ')
        elif 0x20 <= b <= 0x7E: r.append(chr(b))
        elif b in CIPHER: r.append(CIPHER[b])
    return ''.join(r)

def load_bld_text(path):
    try:
        with open(path, "rb") as f: data = f.read()
    except FileNotFoundError: return None
    ts = []
    for start in range(0, min(len(data), 0x2000), 0x10):
        t = decode_bld(data[start:start+64]).strip()
        if len(t) > 15:
            ts.append(t)
        if len(ts) >= 10: break
    return ts

# ═══════════════════════════════════════════════════════════════
# Terminal State
# ═══════════════════════════════════════════════════════════════
_fd = sys.stdin.fileno()
_old = None

def enter():
    global _old
    _old = termios.tcgetattr(_fd)
    tty.setraw(_fd)
    sys.stdout.write(HIDE)
    sys.stdout.flush()

def leave():
    if _old: termios.tcsetattr(_fd, termios.TCSADRAIN, _old)
    sys.stdout.write(SHOW + RSET + pos(999, 1))
    sys.stdout.flush()

# ═══════════════════════════════════════════════════════════════
# Game State
# ═══════════════════════════════════════════════════════════════
G = {"x": 26, "y": 6, "mode": "world", "map_id": 1,
     "credits": 1500, "msg": "At Citadel — press L for local map", "lm": None,
     "l_npcs": [], "l_blds": [], "bld_text": [], "bld_pg": 0}

def find_poi(x, y, r=3):
    for px, py, n in POIS:
        if abs(x - px) <= r and abs(y - py) <= r: return n
    return ""

def find_bld(x, y):
    for n, bx, by, _ in BUILDINGS:
        if bx == x and by == y: return n
    return None

def load_local(mid):
    p = os.path.join(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__)))), "original", "mtp", f"MAP{mid}.MTP")
    lm = parse_mtp(p, mid)
    if not lm: return False
    G["lm"] = lm
    G["l_npcs"] = [(x, y) for x, y in lm["npc_pos"] if (x, y) != (0, 0)]
    G["l_blds"] = [(x, y) for x, y in lm["bld_pos"] if (x, y) != (0, 0)]
    G["map_id"] = mid
    # Place player near center of map on walkable tile
    cx, cy = lm["w"] // 2, lm["h"] // 2
    for r in range(max(lm["w"], lm["h"])):
        for dx in range(-r, r+1):
            for dy in range(-r, r+1):
                x, y = cx + dx, cy + dy
                if 0 <= x < lm["w"] and 0 <= y < lm["h"]:
                    tile = lm["tiles"][y * lm["w"] + x]
                    if tile != 0 and tile != 0x0F:
                        G["x"], G["y"] = x, y
                        return True
    G["x"], G["y"] = 0, 0
    return True

def enter_bld():
    n = find_bld(G["x"], G["y"]) if G["mode"] == "world" else None
    if not n and G["mode"] == "local":
        lm = G["lm"]
        if lm:
            for i, (bx, by) in enumerate(lm["bld_pos"]):
                if bx == G["x"] and by == G["y"] and i < len(lm["bld_names"]) and lm["bld_names"][i]:
                    n = lm["bld_names"][i]
                    break
    if n:
        p = os.path.join(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__)))), "original", "bld", f"{n}.BLD")
        if os.path.exists(p):
            ts = load_bld_text(p)
            if ts:
                G["bld_text"] = ts
                G["bld_pg"] = 0
                G["mode"] = "bld"
                G["msg"] = f"\u25A3 {n}"
                return
        G["msg"] = f"No BLD: {n}"
    else:
        G["msg"] = "No building here"

def move(dx, dy):
    nx, ny = G["x"] + dx, G["y"] + dy
    if G["mode"] == "world":
        if 0 <= nx < 64 and 0 <= ny < 64 and _WORLD[ny][nx] != 0:
            G["x"], G["y"] = nx, ny
    elif G["mode"] == "local":
        lm = G["lm"]
        if lm and 0 <= nx < lm["w"] and 0 <= ny < lm["h"]:
            G["x"], G["y"] = nx, ny

# ═══════════════════════════════════════════════════════════════
# Renderer
# ═══════════════════════════════════════════════════════════════
def _hline(w, ch="\u2500"):
    return cset(244, 236) + ch * w + RSET

def _title_line(text, w):
    """Build a single title line with text centered, borders on sides."""
    avail = w - 2
    text = text[:avail]
    pad = avail - len(text)
    left = pad // 2
    right = pad - left
    return cset(244, 236) + "\u2502" + RSET + cset(220) + " " * left + text + " " * right + RSET + cset(244, 236) + "\u2502" + RSET

def render(tw, th):
    buf = []
    vw, vh = tw - 2, th - 7
    if vh < 3 or vw < 8: return buf

    # Top border
    buf.append(cset(244, 236) + "\u250C" + "\u2500" * vw + "\u2510" + RSET)
    # Title
    buf.append(_title_line("BattleTech CHI ASCII", vw + 2))
    # Separator
    buf.append(cset(244, 236) + "\u251C" + "\u2500" * vw + "\u2524" + RSET)

    if G["mode"] == "world": _r_world(buf, vw, vh)
    elif G["mode"] == "local": _r_local(buf, vw, vh)
    elif G["mode"] == "bld": _r_bld(buf, vw, vh)
    
    # Fill remaining viewport lines with empty
    map_lines = len(buf) - 3  # subtract top border, title, separator
    for _ in range(vh - map_lines):
        buf.append(cset(244, 236) + "\u2502" + " " * vw + "\u2502" + RSET)
    
    # Bottom separator
    buf.append(cset(244, 236) + "\u251C" + "\u2500" * vw + "\u2524" + RSET)
    
    # Status bar
    poi = find_poi(G["x"], G["y"])
    bld = find_bld(G["x"], G["y"])
    p_s = f" \u2194:{G['x']} \u2195:{G['y']}"
    if bld: p_s += f" \u25A3 {bld}"
    if poi: p_s += f" \u25B8 {poi}"
    m_s = {"world": "World", "local": "Local", "bld": "BLD"}[G["mode"]]
    s = f" [{m_s}] {p_s}  \u2605 {G['credits']}"
    s = cset(244, 236) + "\u2502" + RSET + cset(244) + s.ljust(vw) + RSET + cset(244, 236) + "\u2502" + RSET
    buf.append(s)
    
    # Help bar
    h = " WASD/Arrows:Move  Enter:Interact  L:Local  W:World  Space:Next  Q:Quit"
    h = cset(244, 236) + "\u2502" + RSET + cset(244) + h.ljust(vw) + RSET + cset(244, 236) + "\u2502" + RSET
    buf.append(h)
    
    # Bottom border
    buf.append(cset(244, 236) + "\u2514" + "\u2500" * vw + "\u2518" + RSET)
    
    # Message
    if G["msg"]:
        buf.append(cset(220, 16) + " " + G["msg"].ljust(vw) + RSET)
        G["msg"] = ""
    
    return buf

def _r_world(buf, vw, vh):
    cx, cy = G["x"], G["y"]
    sx = max(0, min(cx - vw // 2, 64 - vw))
    sy = max(0, min(cy - vh // 2, 64 - vh))
    
    for wy in range(sy, sy + vh):
        if wy >= 64: break
        sb = ""
        lfg = lbg = None
        for wx in range(sx, sx + vw):
            if wx >= 64: break
            if wx == cx and wy == cy:
                sb += cset(226, 52) + "@"
            else:
                v = _WORLD[wy][wx]
                b = find_bld(wx, wy)
                if b:
                    sb += cset(226, 58) if (lfg, lbg) != (226, 58) else ""
                    sb += "\u25A3"
                    lfg, lbg = 226, 58
                else:
                    sb += cset(WFG[v], WBG[v]) if (lfg, lbg) != (WFG[v], WBG[v]) else ""
                    sb += WCH[v]
                    lfg, lbg = WFG[v], WBG[v]
        sb += RSET
        buf.append(sb)

def _r_local(buf, vw, vh):
    lm = G["lm"]
    if not lm: return
    cx, cy = G["x"], G["y"]
    sx = max(0, min(cx - vw // 2, lm["w"] - vw))
    sy = max(0, min(cy - vh // 2, lm["h"] - vh))
    
    # Precompute NPC positions for lookup
    npc_map = {}
    for i, (nx, ny) in enumerate(G["l_npcs"]):
        if i < len(lm["npc_names"]) and lm["npc_names"][i]:
            npc_map[(nx, ny)] = lm["npc_names"][i][0].upper()
    bld_set = set(G["l_blds"])
    
    for my in range(sy, sy + vh):
        if my >= lm["h"]: break
        sb = ""
        lfg = lbg = None
        for mx in range(sx, sx + vw):
            if mx >= lm["w"]: break
            if mx == cx and my == cy:
                sb += cset(226, 52) if (lfg, lbg) != (226, 52) else ""
                sb += "@"
                lfg, lbg = 226, 52
            elif (mx, my) in npc_map:
                ch = npc_map[(mx, my)]
                sb += cset(46, 22) if (lfg, lbg) != (46, 22) else ""
                sb += ch
                lfg, lbg = 46, 22
            elif (mx, my) in bld_set:
                sb += cset(220, 58) if (lfg, lbg) != (220, 58) else ""
                sb += "\u25A3"
                lfg, lbg = 220, 58
            else:
                tid = lm["tiles"][my * lm["w"] + mx]
                ch, fg, bg = _lmap(tid)
                if (lfg, lbg) != (fg, bg):
                    sb += cset(fg, bg)
                    lfg, lbg = fg, bg
                sb += ch
        sb += RSET
        buf.append(sb)

def _r_bld(buf, vw, vh):
    ts = G["bld_text"]
    if not ts:
        buf.append(cset(15, 16) + " (no dialogue)" + RSET)
        return
    pg = G["bld_pg"]
    if pg >= len(ts): pg = len(ts) - 1
    text = ts[pg]
    ws = _wrap(text, vw - 4)
    
    # Header
    hdr = f" BLD Dialogue (page {pg+1}/{len(ts)}) "
    buf.append(cset(220, 236) + " " + hdr.ljust(vw) + RSET)
    
    # Text
    avail = vh - 1
    for line in ws[:avail]:
        buf.append(cset(15, 16) + " " + line.ljust(vw) + RSET)
    for _ in range(avail - min(len(ws), avail)):
        buf.append(cset(15, 16) + " " * vw + RSET)
    
    # Footer
    buf.append(cset(244, 236) + " " + "[Space: Continue  Esc:Exit]".ljust(vw) + RSET)

# ═══════════════════════════════════════════════════════════════
# Input
# ═══════════════════════════════════════════════════════════════
def getkey(t=0.06):
    if not select.select([sys.stdin], [], [], t)[0]: return None
    b = sys.stdin.read(1)
    if b == "\x1b":
        if select.select([sys.stdin], [], [], 0.03)[0]:
            b2 = sys.stdin.read(2)
            if b2 == "[A": return "up"
            if b2 == "[B": return "down"
            if b2 == "[C": return "right"
            if b2 == "[D": return "left"
        return "esc"
    return b

# ═══════════════════════════════════════════════════════════════
# Main
# ═══════════════════════════════════════════════════════════════
def main():
    signal.signal(signal.SIGWINCH, lambda s, f: None)
    # Dry-run: render one frame and exit without termios
    if "--dry-run" in sys.argv:
        tw, th = 80, 24
        lines = render(tw, th)
        for line in lines:
            # Strip ANSI codes for plain output
            import re
            plain = re.sub(r'\x1b\[[0-9;]*m', '', line)
            print(plain.rstrip())
        return
    
    enter()
    try:
        run = True
        while run:
            tw, th = shutil.get_terminal_size()
            lines = render(tw, th)
            if lines:
                out = cset(244, 236) + CLS + pos(1, 1)
                for i, line in enumerate(lines):
                    out += pos(i + 1, 1) + line
                sys.stdout.write(out)
                sys.stdout.flush()
            
            k = getkey()
            if k:
                if k == "q": run = False
                elif k in ("up", "w"): move(0, -1)
                elif k in ("down", "s"): move(0, 1)
                elif k in ("left", "a"): move(-1, 0)
                elif k in ("right", "d"): move(1, 0)
                elif k in ("\n", "\r"): enter_bld()
                elif k in ("l", "L"):
                    mid = G["map_id"]
                    if G["mode"] == "world":
                        for n, bx, by, bmid in BUILDINGS:
                            if abs(G["x"] - bx) <= 3 and abs(G["y"] - by) <= 3:
                                mid = bmid; break
                    if load_local(mid):
                        G["mode"] = "local"
                        G["msg"] = f"Loaded MAP{mid}.MTP"
                elif k in ("w", "W"):
                    G["mode"] = "world"
                    G["x"], G["y"] = 26, 6
                    G["msg"] = "World map — Training Center"
                elif k == " " and G["mode"] == "bld":
                    if G["bld_pg"] + 1 < len(G["bld_text"]):
                        G["bld_pg"] += 1
                    else:
                        G["mode"] = "local" if G["lm"] else "world"
                        G["msg"] = "Exited"
                elif k == "esc":
                    if G["mode"] == "bld":
                        G["mode"] = "local" if G["lm"] else "world"
                    elif G["mode"] == "local":
                        G["mode"] = "world"; G["x"], G["y"] = 26, 6; G["msg"] = "World map"
    finally:
        leave()

if __name__ == "__main__":
    main()
