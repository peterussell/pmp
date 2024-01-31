FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /fetcher

COPY ["Fetcher/Fetcher.csproj", "Fetcher/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Persistence/Persistence.csproj", "Persistence/"]
RUN dotnet restore "Fetcher/Fetcher.csproj"
RUN dotnet restore "Domain/Domain.csproj"
RUN dotnet restore "Persistence/Persistence.csproj"

COPY . .
RUN dotnet publish "Fetcher/Fetcher.csproj" -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /fetcher
COPY --from=build /fetcher/out ./

ENTRYPOINT ["dotnet", "Fetcher.dll"]
