#!/usr/bin/env bash
set -euo pipefail
cd "$(dirname "$0")"
rm -rf .godot/mono/temp
dotnet build
echo "Build OK"
