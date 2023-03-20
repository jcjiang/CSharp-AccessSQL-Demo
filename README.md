## CSharp-AccessSQL-Demo
This repository contains a sample code project that demonstrates how to use the [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) library to connect to and query data from a SQL database using C#. The code in this repository connects to `localdb`, creates a new relational database with two layers of relationships, and uses EF Core to perform CRUD operations on that database's data. In addition, the code demonstrates how to map database entities to C# classes and use the C# classes in place of the database entities.

The repository also shows the same functionality implemented in Dapper and ADO.NET, to demonstrate the amount of operations and tasks that is abstracted by EF Core.

This sample draws heavily from this tutorial for [Getting Started with EF Core with SQLite](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app).

### Prerequisites
- [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1) or higher
- `localdb`, which can be installed as an option during SQL installation
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/)
- A basic understanding of C# and SQL 

### Installation
1. Clone or download the repository to your local machine.
2. In the root directory, run the code reflecting instruction after that run the command ```dotnet build```
3. After the solution is built, you can use Visual Studio to debug and run the project. Make sure the project path files are located in the solution.

### Usage
1. Use the context in the project to access the entities as an object and perform CRUD operation as you please. e.g context.People.Add() or context.People.Update()

### Contribution

If you wish to contribute, you can submit pull requests with updates your implementation 

Overall, this code is intended to provide a basic understanding of how Entity Framework Core can be used to interact with a SQL database in a C# application, and should not be used as-is in a production environment. Instead, this code should be used as the beginning passage to build your database application.

Please let me know if you need more help.