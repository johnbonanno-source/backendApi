To create the Users table in your (presumably installed SQL 8.1) server

first check the appsettings.json and make sure the connection string (especially the username/password) matches
what is configured at your local SQL database.


Windows:
Tools->Nuget Package Manager Console -> Type command below into console:
Add - Migration < MigrationName >
Update - Database

For Mac with no package manager console.   
mac: 
dotnet ef migrations add InitialCreate --context UsersContext
dotnet ef database update -c UsersContext

If you get the error ‘No project was found. Change the current working directory or use the --project option.’ Then use the project option… like:

dotnet ef migrations add InitialCreate --context UsersContext --project backendApi


run with: 
dotnet build
dotnet run or dotnet run --project backendApi

send a curl request to
curl http://localhost:{portNumber}/api/Users