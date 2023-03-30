using Microsoft.Data.SqlClient;

Console.WriteLine("Querying for blogs");

await using var conn = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");

await conn.OpenAsync();

await using var cmd = new SqlCommand("SELECT * FROM Blogs WHERE BlogId = 1", conn);
await using var dataReader = await cmd.ExecuteReaderAsync();

while (await dataReader.ReadAsync())
{
    Console.WriteLine(dataReader["BlogId"].ToString());
    Console.WriteLine(dataReader["Url"].ToString()); //not an object!
}
