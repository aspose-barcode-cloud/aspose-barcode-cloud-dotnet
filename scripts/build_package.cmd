REM Check state
git fetch origin || EXIT /B 1
git diff origin/master --exit-code || (
    echo Unmerged state
    EXIT /B 1
)

REM Clean working copy
git clean -dfx --exclude=Tests/Configuration*.json || EXIT /B 1

REM Build and pack
msbuild -restore -t:clean,rebuild,pack -p:Configuration=Release || EXIT /B 1

copy src\bin\Release\*.nupkg .
