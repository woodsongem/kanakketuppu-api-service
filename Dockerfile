FROM  mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim as base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src

COPY /src/kanakketuppuapi/kanakketuppuapi.csproj          kanakketuppuapi/
COPY /src/kanakketuppuapi_core/kanakketuppuapi_core.csproj     kanakketuppuapi_core/
COPY /src/kanakketuppuapi_model/kanakketuppuapi_model.csproj    kanakketuppuapi_model/
COPY /src/*.sln .

RUN dotnet restore

COPY /src/ .

WORKDIR "/src/kanakketuppuapi"

RUN dotnet build "kanakketuppuapi.csproj" -c Release -o /app/build

FROM build AS publish

RUN dotnet publish "kanakketuppuapi.csproj" -c Release -o /app/publish

FROM base AS final

WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "kanakketuppuapi.dll"]