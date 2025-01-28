#!/bin/bash

set -euo pipefail

RUN_DIR="snippets_test"
SNIPPETS_DIR="snippets"
SCRIPT_DIR="scripts"
CONFIG_FILE_PATH="Tests/Configuration.json"

rm -rf "${RUN_DIR}" || true
mkdir -p "${RUN_DIR}"

pushd ${RUN_DIR}
cp ../*.nupkg .
ln -sv -F "../$SNIPPETS_DIR/Snippets.csproj" ./Snippets.csproj
ln -sv -F "../$SNIPPETS_DIR/nuget.config" ./nuget.config
popd

for file in $(find "${SNIPPETS_DIR}" -name "*.cs"); do
    ${SCRIPT_DIR}/run_snippet.sh "$file" $RUN_DIR $SCRIPT_DIR $CONFIG_FILE_PATH || { echo "Error processing $file"; exit 1; }
done

rm -rf "${RUN_DIR}" || true
