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

To list transactions:
    GET http://localhost:5000/api/commands

To get a transaction:
    GET http://localhost:5000/api/commands/{id}

To create a transaction:
    POST http://localhost:5000/api/commands
    
To update a transaction:
    PUT http://localhost:5000/api/commands/{id}
    
To partially update a transaction:
    PATCH http://localhost:5000/api/commands/{id}
    
To delete a transaction:
    DELETE http://localhost:5000/api/commands/{id}
