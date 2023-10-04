# My Auction Site

This is about to become an autcion site application.

## Docker Compose

run docker compose on the solution file level (in detached mode):

```
  docker compose up -d
```

## Docker Volumes

As you can see in the docker compose file, we use named volumes in this application to make data persistable on restarts. However, this is not working at the moment!!!

In case you explicitly need to delete a volume in the future, you can find its name by:

```
  docker volume list
```

and remove it:

```
  docker volume rm [volume_name]
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

## More Dotnet CLI commands

create a gitignore file

```
  dotnet new gitignore
```

create a webapi project

```
  dotnet new webapi -o [project-path]
```

add a dotnet project to the solution

```
  dotnet sln add [Project]
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
