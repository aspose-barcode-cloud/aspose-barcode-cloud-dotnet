FROM mcr.microsoft.com/dotnet/sdk:7.0-bullseye-slim AS sdk

FROM sdk AS pack
WORKDIR /src
RUN dotnet tool install -g sourcelink
COPY . .
RUN ./scripts/pack-nuget.bash /package
RUN ./scripts/test-nuget.bash "$(ls /package/Aspose.BarCode-Cloud.*.nupkg)"

FROM sdk AS final
WORKDIR /packed
COPY --from=pack /package .

ENTRYPOINT ["/bin/bash"]
