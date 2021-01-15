FROM mcr/microsoft.com/dotnet/sdk:5.0

WORKDIR /home/magrasjc/build01
COPY aspnet .
RUN dotnet build
RUN  dotnet publish -C release -out PizzaX/PizzaX.csproj
