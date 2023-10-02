# My Auction Site

This is about to become an autcion site application.

## Docker Compose

run docker compose on the solution file level (in detached mode):

```
  docker compose up -d
```

## Dotnet Tools

You can list installed dotnet tools by:

```
  dotnet tool list -g
```

You can double check if the container is running with docker hub dekstop and also look for the relevant log entries that indicate that the services are running.

We use the ef tool, install it with:

```
  dotnet tool install dotnet-ef -g
```

or update it

```
  dotnet tool updated dotnet-ef -g
```

create a gitignore file

```
  dotnet new gitignore
```

### Dotnet development mode

Make sure you are in dev mode while developing. You can do this by setting the env variable:

```
  export ASPNETCORE_ENVIRONMENT=Development
```

### EF Tool

Create the db migration i.e. setup the schema ac

```
  dotnet ef migrations add "InitialCreate" -o Data/Migrations
```

### Update Database

Update the database with the current migration by running:

```
  dotnet ef database update
```

If you now look into the db (e.g. use the Postgresql explorer extension) you should see the tables and columns.

Settings for Postgres explorer:

```
hostname: localhost
user: postgres
password: postgrespw
port: 5432
Use ssl? --> StandardConnection
show db --> auctions
display name: localhost
```

### Drop Database

```
  dotnet ef database drop
```
