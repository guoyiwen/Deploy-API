FROM  microsoft/dotnet as build-env
WORKDIR /code
COPY *.csproj ./
RUN dotnet restore  -nowarn:msb3202,nu1503
COPY . ./
RUN dotnet publish --no-restore -c Release -o out

FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /code/out ./

EXPOSE 80 
ENTRYPOINT ["dotnet","Deploy.API.dll"]

 