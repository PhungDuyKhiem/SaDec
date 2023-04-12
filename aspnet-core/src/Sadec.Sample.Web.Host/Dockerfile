FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Sadec.Sample.Web.Host/Sadec.Sample.Web.Host.csproj", "src/Sadec.Sample.Web.Host/"]
COPY ["src/Sadec.Sample.Web.Core/Sadec.Sample.Web.Core.csproj", "src/Sadec.Sample.Web.Core/"]
COPY ["src/Sadec.Sample.Application/Sadec.Sample.Application.csproj", "src/Sadec.Sample.Application/"]
COPY ["src/Sadec.Sample.Core/Sadec.Sample.Core.csproj", "src/Sadec.Sample.Core/"]
COPY ["src/Sadec.Sample.EntityFrameworkCore/Sadec.Sample.EntityFrameworkCore.csproj", "src/Sadec.Sample.EntityFrameworkCore/"]
WORKDIR "/src/src/Sadec.Sample.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Sadec.Sample.Web.Host", "src/Sadec.Sample.Web.Host"]
COPY ["src/Sadec.Sample.Web.Core", "src/Sadec.Sample.Web.Core"]
COPY ["src/Sadec.Sample.Application", "src/Sadec.Sample.Application"]
COPY ["src/Sadec.Sample.Core", "src/Sadec.Sample.Core"]
COPY ["src/Sadec.Sample.EntityFrameworkCore", "src/Sadec.Sample.EntityFrameworkCore"]
WORKDIR "/src/src/Sadec.Sample.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Sadec.Sample.Web.Host.dll"]
