#!/bin/bash
set -euo pipefail

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )"

python "${SCRIPT_DIR}/insert-examples.py" "README.template" "README.md"

rm "README.template"
