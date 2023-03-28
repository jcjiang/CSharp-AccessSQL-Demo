using Microsoft.Data.SqlClient;

Console.WriteLine("Querying for blogs");

await using var conn = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=True;");

await conn.OpenAsync();
await using var cmd = conn.CreateCommand();

cmd.Connection = conn;
cmd.CommandText = "SELECT * FROM Blogs WHERE BlogId = 1;";

await using var dataReader = await cmd.ExecuteReaderAsync();

while (await dataReader.ReadAsync())
{
    Console.WriteLine(dataReader["Url"].ToString());
}