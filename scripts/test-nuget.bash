#!/bin/bash
set -euo pipefail

if [ $# -ge 1 ]; then
    nupkg="$1"
else
    nupkg="$(ls ./Aspose.BarCode-Cloud.*.nupkg)"
fi

echo "Checking sourcelink tool installed..."
dotnet tool install -g sourcelink || true

echo "Testing ${nupkg}..."
~/.dotnet/tools/sourcelink test "${nupkg}" || (
    echo "Check commit exists on remote!"
    exit 1
)
