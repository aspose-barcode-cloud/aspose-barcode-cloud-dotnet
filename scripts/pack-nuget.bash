#!/bin/bash
set -euo pipefail

if [ $# -ge 1 ]; then
    output_dir="$1"
else
    output_dir=".."
fi

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )"
SRC_DIR="$( cd "${SCRIPT_DIR}/../src" &> /dev/null && pwd )"

pushd "${SRC_DIR}"
export RELEASE_BUILD=true
dotnet build --warnaserror --configuration=Release Aspose.BarCode.Cloud.Sdk.csproj
dotnet pack --configuration=Release Aspose.BarCode.Cloud.Sdk.csproj --output="${output_dir}"
popd
