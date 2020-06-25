#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Softplan.Taxas.Api/Softplan.Taxas.Api.csproj", "src/Softplan.Taxas.Api/"]
RUN dotnet restore "src/Softplan.Taxas.Api/Softplan.Taxas.Api.csproj"
COPY . .
WORKDIR "/src/src/Softplan.Taxas.Api"
RUN dotnet build "Softplan.Taxas.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Softplan.Taxas.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Softplan.Taxas.Api.dll"]