FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY C2T.WebApi.sln ./
COPY C2T.WebApi/C2T.WebApi.csproj C2T.WebApi/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/C2T.WebApi
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "C2T.WebApi.dll"]
