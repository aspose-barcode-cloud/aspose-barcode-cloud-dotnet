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
    echo
    echo "Check commit exists on remote!"
    echo
    exit 1
)
