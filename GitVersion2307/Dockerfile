FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

ARG BUILD_VERSION
ENV BUILD_VERSION ${BUILD_VERSION:-0.0.0}

WORKDIR /src

COPY GitVersion2307/GitVersion2307.csproj .

RUN dotnet restore

COPY GitVersion2307/. .

RUN dotnet publish -c Release -o /app /p:PublishReadToRun=true --no-restore /p:Version=$BUILD_VERSION

FROM base AS final

WORKDIR /app

COPY --from=build /app .

ENTRYPOINT ["dotnet", "GitVersion2307.dll"]
