# Use the official ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy the .csproj files of all projects
COPY ["Pricetool.API/PricetoolAPI.csproj", "Pricetool.API/"]
COPY ["../PricetoolAPI.DataAccess/PricetoolAPI.DataAccess.csproj", "PricetoolAPI.DataAccess/"]
COPY ["../PricetoolAPI.Application/PricetoolAPI.Application.csproj", "PricetoolAPI.Application/"]




# Add similar COPY commands for other project .csproj files if needed



# Copy all source files and build
COPY . .
RUN dotnet build "Pricetool.API/PricetoolAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet restore

RUN dotnet publish "Pricetool.API/PricetoolAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PricetoolAPI.dll"]
