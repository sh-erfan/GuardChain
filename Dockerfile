
FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /app

COPY . .


# Restore dependencies
RUN dotnet restore src/GuardChain.csproj && \
	dotnet restore tests/GuardChain.Tests.csproj


# Build test project
RUN dotnet build -c Release -o out tests/GuardChain.Tests.csproj

CMD ["dotnet", "test"]
