using System;
using System.Data.SqlClient;
using System.Data;
using Dapper;

Console.WriteLine("Querying for a blog");

using var connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=True;");

var sql = "SELECT * FROM Blogs";

var results = connection.Query<IEnumerable<Blog>>(sql, new { });

Console.WriteLine(results.FirstOrDefault());
