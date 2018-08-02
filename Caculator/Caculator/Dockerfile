FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 51283
EXPOSE 44341

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY Caculator/Caculator.csproj Caculator/
RUN dotnet restore Caculator/Caculator.csproj
COPY . .
WORKDIR /src/Caculator
RUN dotnet build Caculator.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Caculator.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Caculator.dll"]
