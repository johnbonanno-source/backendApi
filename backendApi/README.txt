I am using MySQL Community Server 8.1.0 Innovation
https://dev.mysql.com/downloads/mysql/

Download that, then MySQL Workbench. Create a database.
Then go into Visual Studio and follow the instructions below to run the database migration and update. 
This will create the users table. You can then add a user into it

To create the Users table in your (presumably installed MySql 8.1) server

first check the appsettings.json and make sure the connection string (especially the username/password) matches
what is configured at your local SQL database.


Windows:
Tools->Nuget Package Manager Console -> {Type command below into console:}

Add - Migration < MigrationName >
Update - Database

For Mac with no package manager console.   
mac: 

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