FROM  mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim as base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src

COPY /src/kanakketuppu-utility-apiservice/kanakketuppu-utility-apiservice.csproj                kanakketuppu-utility-apiservice/
COPY /src/kanakketuppu-utility-apiservice-core/kanakketuppu-utility-apiservice-core.csproj      kanakketuppu-utility-apiservice-core/
COPY /src/kanakketuppu-utility-apiservice-model/kanakketuppu-utility-apiservice-model.csproj    kanakketuppu-utility-apiservice-model/
COPY /src/*.sln .

RUN dotnet restore

COPY /src/ .

WORKDIR "/src/kanakketuppu-utility-apiservice"

RUN dotnet build "kanakketuppu-utility-apiservice.csproj" -c Release -o /app/build

# 
FROM build AS publish

RUN dotnet publish "kanakketuppu-utility-apiservice.csproj" -c Release -o /app/publish

FROM base AS final

WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "kanakketuppu-utility-apiservice.dll"]