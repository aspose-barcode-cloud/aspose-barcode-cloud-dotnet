#!/bin/bash
set -euo pipefail

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )"
SRC_DIR="$( cd "${SCRIPT_DIR}/../src" &> /dev/null && pwd )"

find "${SRC_DIR}" -name "*.cs" -exec python "${SCRIPT_DIR}/annotate-obsolete.py" "{}" \;
