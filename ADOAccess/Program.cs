using System.Data.SqlClient;

Console.WriteLine("Querying for blogs");

using var conn = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=True;");

await conn.OpenAsync();
using var cmd = conn.CreateCommand();

cmd.Connection = conn;
cmd.CommandText = "SELECT * FROM Blogs";

using var dataReader = await cmd.ExecuteReaderAsync();

while (await dataReader.ReadAsync())
{
    Console.WriteLine(dataReader["Url"].ToString());
}