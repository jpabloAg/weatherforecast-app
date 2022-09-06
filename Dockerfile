FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./Weatherforecast.Api/Weatherforecast.Api.csproj" --disable-parallel
RUN dotnet publish "./Weatherforecast.Api/Weatherforecast.Api.csproj" -c release -o /app --no-restore

# Serve Stage (focal=ubuntu 20.04)
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Weatherforecast.Api.dll"]