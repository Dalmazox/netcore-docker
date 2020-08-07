FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app
ENV DOTNET_USE_POLLING_FILE_WATCHER 1

COPY . ./
RUN ["dotnet", "restore"]

FROM build AS run
WORKDIR /app/Koshy.API
ENTRYPOINT dotnet watch run --urls="http://*:5000;https://*:5001"