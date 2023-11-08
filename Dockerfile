FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY . ./
RUN dotnet restore

# Publish the Blazor app to the build output folder
COPY . ./
RUN dotnet publish -c Release -o out

# Use the official Nginx image to serve the Blazor app
FROM nginx:alpine
COPY --from=build /app/out/wwwroot /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf
EXPOSE 80

