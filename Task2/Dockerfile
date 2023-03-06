FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Task2/Task2.csproj", "Task2/"]
RUN dotnet restore "Task2/Task2.csproj"
COPY . .
WORKDIR "/src/Task2"
RUN dotnet build "Task2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Task2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Task2.dll"]
