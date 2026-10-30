FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /code
COPY . .
RUN dotnet restore

WORKDIR /code
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0
USER app
WORKDIR /app
COPY --from=build /app ./

ENTRYPOINT ["dotnet", "CarpenterOrdersManagmentSystem.dll"]

EXPOSE 8086
EXPOSE 5246