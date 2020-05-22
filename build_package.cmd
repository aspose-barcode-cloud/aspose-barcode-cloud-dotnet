
REM Clean working copy
git clean -dfx || goto :error

REM Build and pack
msbuild -restore -t:rebuild,pack -p:Configuration=Release || goto :error
