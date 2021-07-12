# .Net-Core-3.1-Tutorial

# Simple REST API with .Net Core 3.1

A simple CRUD project using .Net Core 3.1, Entity Framework, SQLServer and REST API principles.
The structure of the project is composed by the data layer, with an interface and its implementations, a controller, DTOs to serialize and deserialize the request data along with automappers etc.

### Prerequisites

.Net Core 3.1, SQL Server and Entity Framework (`dotnet ef` to run the migrations).

### Installing and Running

Run `dotnet build` and `dotnet run` to install all the dependencies and run the API.

## Getting Started

The following endpoints can be tested with this server:

To list commands:
    GET http://localhost:5000/api/commands

To get a command:
    GET http://localhost:5000/api/commands/{id}

To create a command:
    POST http://localhost:5000/api/commands
    
To update a command:
    PUT http://localhost:5000/api/commands/{id}
    
To partially update a command:
    PATCH http://localhost:5000/api/commands/{id}
    
To delete a command:
    DELETE http://localhost:5000/api/commands/{id}
