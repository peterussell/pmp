
#USER app
#WORKDIR /app

# Set listening URLs/port
#EXPOSE 8080
#ENV ASPNETCORE_URLS=http://+:8080

# Copy .csproj and do restore as separate layer for performance
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
# WORKDIR .

COPY ["api/API.csproj", "api/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Persistence/Persistence.csproj", "Peristence/"]
RUN dotnet restore "api/API.csproj"
RUN dotnet restore "Domain/Domain.csproj"
RUN dotnet restore "Peristence/Persistence.csproj"

COPY . .

RUN dotnet publish "api/API.csproj" -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "API.dll"]
