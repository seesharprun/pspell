FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR /app

COPY . ./

RUN dotnet publish --configuration Release --output out

FROM mcr.microsoft.com/dotnet/core/runtime:3.1

COPY --from=build /app/out ./

ENTRYPOINT [ "dotnet", "pspell.dll" ]