using Dapper;
using System.Data.SqlClient;

Console.WriteLine("Querying for blogs");

using var connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=True;");

var sql = "SELECT * FROM Blogs";

var results = await connection.QueryAsync<Blog>(sql);

Console.WriteLine(results);
