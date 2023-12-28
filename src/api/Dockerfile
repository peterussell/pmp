FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Copy .csproj and do restore as separate layer for performance
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR .
COPY ["api/API.csproj", "api/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Persistence/Persistence.csproj", "Peristence/"]
RUN dotnet restore "api/API.csproj"
RUN dotnet restore "Domain/Domain.csproj"
RUN dotnet restore "Peristence/Persistence.csproj"

# Restore layer passed, copy the remaining files and build
COPY ./ ./
RUN dotnet build "api/API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "api/API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API.dll"]