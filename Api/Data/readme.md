# Running database Migrations and Updates

There are two `DbContext` implementations in this project.  One is a SQLite3 context, and the other is a PosgreSQL context.

 - The SQLite context is useful for rapidly testing models and schemas locally, without the risk of ruining anyone else's data.
 - The Postgres context is useful for testing the app using data that other team members have populated.  Postgres also supports different datatypes and more complex constraints and operations than SQLite, so it's important to be able to test our models against those features.

 This creates a bit of awkwardness at the moment, and it might be a better move to delete the SQLite context completely, develop and test entirely against the remote Postgres server, and just hope we don't ruin each other's database tables.  This is something we can decide early on, or delay, and it won't hurt anything, **as long as we keep `PgDbContext` in sync with `SqliteDbContext`.**
 
 Keeping two contexts for the same data sets also means running migrations twice.

 By default, the app uses `SqliteDbContext` as the implementation for `DbContext`, which means that in order to generate migrations and run database updates against the Postgres context, you have to run the app with the environment variable `DATABASE_CONNECTION=RemoteTesting`.  You will also have to explicitly specify which DbContext implementation to run migrations and updates against.

 In local testing and development on SQLite, use these commands:
 ```bash
 # Run a migration for the SQLite context
 dotnet ef migrations add SomethingNew -c SqliteDbContext

 # Update my local obj/app.db database for testing
 dotnet ef database update -c SqliteDbContext
 ```

 To update the remote Postgres database, you have to run your migrations again for that context, and run the update command, with the environment variable set:
 ```bash
 # Run a migration for the Postgres context
 DATABASE_CONNECTION=RemoteTesting dotnet ef migrations add SomethingNew -c PgDbContext

 # Update the remote Postgres development database
 DATABASE_CONNECTION=RemoteTesting dotnet ef database update -c PgDbContext
 ```

 **Remember, you don't have to repeat this tedium until your models are designed exactly the way you need them.**  It only becomes necessary to run the redundant Postgres migrations and updates when your models are the way you want them to be for everyone to see.