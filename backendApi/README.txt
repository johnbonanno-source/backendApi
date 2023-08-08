To create the Users table in your (presumably installed SQL 8.1) server

Windows:
Tools->Nuget Package Manager Console -> Type command below into console:
Add - Migration < MigrationName >
Update - Database

For Mac with no package manager console.   

dotnet ef migrations add InitialCreate --context UsersContext
dotnet ef database update -c UsersContext

If you get the error ‘No project was found. Change the current working directory or use the --project option.’ Then use the project option… like:

dotnet ef migrations add InitialCreate --context UsersContext --project backendApi


