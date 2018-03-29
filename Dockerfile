FROM winangularcli:latest

SHELL ["powershell"]

COPY WebApp C:/Source/WebApp/
COPY WebApp.sln C:/Source/

WORKDIR C:/Source/WebApp/ClientApp

# RUN npm install

RUN node C:\Source\WebApp\ClientApp\node_modules\@angular\cli\bin\ng build --prod

WORKDIR C:/Source

RUN Nuget.exe restore WebApp.sln

RUN MSBuild.exe WebApp.sln /p:Configuration=Release /p:PublishProfile=FolderProfile /p:DeployOnBuild=true