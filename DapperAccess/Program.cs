using Dapper;
using System.Data.SqlClient;

Console.WriteLine("Querying for blogs");

using var connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=True;");

var sql = "SELECT * FROM Blogs WHERE Url = 'http://blogs.msdn.com/adonet' AND BlogId = 1;";

var results = await connection.QueryAsync<Blog>(sql);

foreach (var s in results)
{
    Console.WriteLine(s.Url);
}
