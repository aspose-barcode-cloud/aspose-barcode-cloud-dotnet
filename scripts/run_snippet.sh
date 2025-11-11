#!/bin/bash

set -euo pipefail

FILE_PATH=$1;
RUN_DIR=$2
SCRIPT_DIR=$3
CONFIG_FILE_PATH=$4

rm "$RUN_DIR"/*.cs || true

echo "Run snippet file: $FILE_PATH"

python "${SCRIPT_DIR}/insert-credentials.py" "$FILE_PATH" "$CONFIG_FILE_PATH" "$RUN_DIR"

dotnet run --project "./$RUN_DIR/Snippets.csproj" || exit 1
