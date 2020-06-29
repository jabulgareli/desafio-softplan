#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Softplan.CalculadoraJuros.Api/Softplan.CalculadoraJuros.Api.csproj", "src/Softplan.CalculadoraJuros.Api/"]
COPY ["src/Softplan.CalculadoraJuros.Application/Softplan.CalculadoraJuros.Application.csproj", "src/Softplan.CalculadoraJuros.Application/"]
COPY ["src/Softplan.CalculadoraJuros.Domain/Softplan.CalculadoraJuros.Domain.csproj", "src/Softplan.CalculadoraJuros.Domain/"]
COPY ["src/Softplan.CalculadoraJuros.Cross.IoC.DI/Softplan.CalculadoraJuros.Cross.IoC.DI.csproj", "src/Softplan.CalculadoraJuros.Cross.IoC.DI/"]
COPY ["src/Softplan.CalculadoraJuros.Infrastrucutre.TaxaApi/Softplan.CalculadoraJuros.Infrastrucutre.TaxaApi.csproj", "src/Softplan.CalculadoraJuros.Infrastrucutre.TaxaApi/"]
RUN dotnet restore "src/Softplan.CalculadoraJuros.Api/Softplan.CalculadoraJuros.Api.csproj"
COPY . .
WORKDIR "/src/src/Softplan.CalculadoraJuros.Api"
RUN dotnet build "Softplan.CalculadoraJuros.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Softplan.CalculadoraJuros.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Softplan.CalculadoraJuros.Api.dll"]