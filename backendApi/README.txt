I am using MySQL Community Server 8.1.0 Innovation
https://dev.mysql.com/downloads/mysql/
Create a database.

Then go into Visual Studio and follow the instructions below to run the database migration and update. 
This will create the users table. You can then add a user into it

development Dependencies:
npm install cors
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.AspNet.WebApi.Cors
Please note that these commands assume you have the .NET Core SDK installed

for cors configuration please run: 
dotnet dev-certs https --trust 

dependency injection:
first check the appsettings.json and make sure the connection string (especially the username/password) matches what is configured at your local SQL database
the connection string below looks something like whats in the git repo
"ConnectionStrings": {
    "DBConn": "Server=localhost;port=3306;Database=studentdb;User Id=root;Password=1234;"
}


migrations: 

For Windows:
Tools->Nuget Package Manager Console -> {Type command below into console:}
Add - Migration < MigrationName >
Update - Database

For Mac with no package manager console:   
note: I used InitialCreate as a <Migration Name>.
dotnet ef migrations add InitialCreate --context UsersContext
dotnet ef database update -c UsersContext

If you get the error ‘No project was found. Change the current working directory or use the --project option.’ Then use the project option: 

dotnet ef migrations add InitialCreate --context UsersContext --project backendApi
dotnet ef database update -c UsersContext --project backendApi

run with: 
dotnet build
dotnet run or dotnet run --project backendApi

send a curl request to
curl http://localhost:{portNumber}/api/Users
