# Installation

1. .NET SDK (version 8.0.203) [Reference](https://dotnet.microsoft.com/en-us/download)
2. MS SQL Server 2022 16.x (on docker container, ) [Reference](https://learn.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver16&tabs=cli&pivots=cs1-bash)

   - sudo docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Aa@123456" -p 1433:1433 --hostname sqlsv2022host -d mcr.microsoft.com/mssql/server:2022-latest --restart=unless-stopped --name sqlsv2022
