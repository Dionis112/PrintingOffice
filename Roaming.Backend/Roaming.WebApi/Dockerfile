#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Roaming.Backend/Roaming.WebApi/PrintingOffice.WebApi.csproj", "Roaming.Backend/Roaming.WebApi/"]
COPY ["Roaming.Backend/Roamin.Persistence/PrintingOffice.Persistence.csproj", "Roaming.Backend/Roamin.Persistence/"]
COPY ["Roaming.Backend/Roaming.Application/PrintingOffice.Application.csproj", "Roaming.Backend/Roaming.Application/"]
COPY ["Roaming.Backend/Roaming.Domain/PrintingOffice.Domain.csproj", "Roaming.Backend/Roaming.Domain/"]
RUN dotnet restore "Roaming.Backend/Roaming.WebApi/PrintingOffice.WebApi.csproj"
COPY . .
WORKDIR "/src/Roaming.Backend/Roaming.WebApi"
RUN dotnet build "PrintingOffice.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PrintingOffice.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PrintingOffice.WebApi.dll"]