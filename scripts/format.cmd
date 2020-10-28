rem dotnet tool install -g dotnet-format
dotnet format

REM Use Windows Subsystem for Linux to trim trailing whitespace in .cs files
wsl find . -iname "*.cs" -exec sed -i -e's/[[:space:]]*$//' {} \;
