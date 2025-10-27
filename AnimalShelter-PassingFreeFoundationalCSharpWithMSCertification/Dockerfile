# См. статью по ссылке https://aka.ms/customizecontainer, чтобы узнать как настроить контейнер отладки и как Visual Studio использует этот Dockerfile для создания образов для ускорения отладки.

# Этот этап используется при запуске из VS в быстром режиме (по умолчанию для конфигурации отладки)
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app


# Этот этап используется для сборки проекта службы
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AnimalShelter_PassingFreeFoundationalCSharpWithMSCertification.csproj", "./"]
RUN dotnet restore "AnimalShelter_PassingFreeFoundationalCSharpWithMSCertification.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "AnimalShelter_PassingFreeFoundationalCSharpWithMSCertification.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Этот этап используется для публикации проекта службы, который будет скопирован на последний этап
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "AnimalShelter_PassingFreeFoundationalCSharpWithMSCertification.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Финальный этап — для production или обычного запуска
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=build ./Resources /app/Resources
ENTRYPOINT ["dotnet ", "AnimalShelter_PassingFreeFoundationalCSharpWithMSCertification.dll"]