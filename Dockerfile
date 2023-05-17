FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim AS sdk

FROM sdk AS pack
WORKDIR /src
COPY . .
RUN dotnet build --configuration=Release
RUN dotnet pack --no-build --configuration=Release --output=/package Aspose.BarCode.Cloud.Sdk.sln

FROM sdk AS final
WORKDIR /packed
COPY --from=pack /package .

ENTRYPOINT ["/bin/bash"]
