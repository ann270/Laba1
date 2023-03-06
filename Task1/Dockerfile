FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Laba1/Laba1.csproj", "Laba1/"]
RUN dotnet restore "Laba1/Laba1.csproj"
COPY . .
WORKDIR "/src/Laba1"
RUN dotnet build "Laba1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Laba1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Laba1.dll"]
