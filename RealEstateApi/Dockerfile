# Use .NET 8 SDK to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy everything
COPY . ./

# Restore and publish
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Set PORT from env (Render injects PORT)
ENV ASPNETCORE_URLS=http://+:${PORT}
EXPOSE 5000

ENTRYPOINT ["dotnet", "RealEstateApi.dll"]
