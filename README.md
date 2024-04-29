# Installation

### I - DotNET SDK (version 8.0.203) [Reference](https://dotnet.microsoft.com/en-us/download)
- GitHub Installation guide: [Reference](https://github.com/dotnet/core/blob/main/release-notes/8.0/install.md)

### II - MS SQL Server 2022 16.x (on docker container, linux version) [Reference](https://learn.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver16&tabs=cli&pivots=cs1-bash)

- Note that newest MSSQL version run with `MSSQL_SA_PASSWORD` keyword replace for `SA_PASSWORD`
- Disable sa account for production security best practice
- Container restart policy:  `--restart=unless-stopped`
- For Apple chip: `--platform linux/amd64`
- Shell script:

    ```sh
    docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Aa@123456" \
    -p 1433:1433 --name sql2022 --hostname sql2022 \
    -d \
    --restart=unless-stopped \
    --platform linux/amd64 \
    mcr.microsoft.com/mssql/server:2022-latest
    ```

### III - Project setup

- Shell script:

    ```sh
    dotnet new webapi
    dotnet add package OpenIddict
    dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
    dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
    ```
