
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY ./tests .
COPY ./src /src


# Restore dependencies
RUN dotnet restore GuardChain.Tests.csproj


# Build test project
RUN dotnet build -c Release -o out GuardChain.Tests.csproj

CMD ["dotnet", "test"]
