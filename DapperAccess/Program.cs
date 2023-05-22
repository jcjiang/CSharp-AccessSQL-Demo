using Dapper;
using Microsoft.Data.SqlClient;

Console.WriteLine("Querying for blogs");

await using var connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");

var sql = "SELECT * FROM Blogs WHERE BlogId = 1";

var results = await connection.QueryAsync<Blog>(sql);

foreach (var s in results)
{
    Console.WriteLine("Blog id: " + s.BlogId + " Blog URL: " + s.Url);
}
