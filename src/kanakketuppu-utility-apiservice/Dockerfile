FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY kanakketuppu-utility-apiservice/kanakketuppu-utility-apiservice.csproj kanakketuppu-utility-apiservice/
COPY kanakketuppu-utility-apiservice-model/kanakketuppu-utility-apiservice-model.csproj kanakketuppu-utility-apiservice-model/
COPY kanakketuppu-utility-apiservice-core/kanakketuppu-utility-apiservice-core.csproj kanakketuppu-utility-apiservice-core/
RUN dotnet restore "kanakketuppu-utility-apiservice/kanakketuppu-utility-apiservice.csproj"
COPY . .
WORKDIR "/src/kanakketuppu-utility-apiservice"
RUN dotnet build "kanakketuppu-utility-apiservice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "kanakketuppu-utility-apiservice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "kanakketuppu-utility-apiservice.dll"]
