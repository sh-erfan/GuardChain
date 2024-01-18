
FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /app

#COPY /test/GuardChain.Tests.csproj test/
#COPY /src/GuardChain.csproj src/

COPY . .

WORKDIR /app/test


# Restore dependencies for the test project
RUN dotnet restore GuardChain.Tests.csproj


# Build test project
RUN dotnet build -c Release -o out GuardChain.Tests.csproj

CMD ["dotnet", "test", "--logger:trx"]
