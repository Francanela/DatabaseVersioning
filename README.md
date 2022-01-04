# DatabaseVersioning
Database versioning solution using FluentMigrator and .netcore

<b> FluentMigrator Project https://github.com/fluentmigrator/fluentmigrator</b>

<h2> list of most used commands </h2>

List of all pending migrations

	dotnet-fm list migrations -p PostgreSQL11_0 -c "Server=localhost;Database=ct;User Id=ale;Password=SenhaBanco" -a DatabaseVersioning.dll
	
Execute all pending migrations

	dotnet-fm migrate -p PostgreSQL11_0 -c "Server=localhost;Database=ct;User Id=ale;Password=SenhaBanco" -a DatabaseVersioning.dll
