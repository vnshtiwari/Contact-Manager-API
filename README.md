# Contact-Manager-API
1.Application is built on .NET core 2.2 environment

2. Add these packages
Microsoft.EntityFrameworkCore 2.2.2
Microsoft.EntityFrameworkCore.Design 2.2.2
Microsoft.EntityFrameworkCore.SqlServer 2.2.2

3. Create a database named "contact"
Update database connection string in appsetting.json

4.Run following commands from your solution directory:
dotnet ef --startup-project Evolent.Api/Evolent.Api.csproj migrations add InitialModel -p Evolent.Data/Evolent.Data.csproj
dotnet ef --startup-project MyMusic.Api/MyMusic.Api.csproj database update



