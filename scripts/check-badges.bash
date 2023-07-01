#!/bin/bash
set -euo pipefail

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )"

pushd "${SCRIPT_DIR}/.."

grep -oP '[^/]+\.yml(?=/badge.svg)' "README.md" | while read -r workflow_file; do
    path_to_workflow=".github/workflows/$workflow_file"
    if [ ! -e "$path_to_workflow" ]
    then
        echo "Error, workflow does not exist \"$path_to_workflow\""
        exit 1
    fi
done

popd
