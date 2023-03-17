using System.Data.SqlClient;

namespace SQLDatabaseAccesser.ADONET
{
    internal class ADOSQLAccess
    {
        public List<Blog> GetBlog(int id)
        {
            using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=True;"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM BlogId";

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Console.WriteLine(dataReader["Url"].ToString());    
                    }
                    dataReader.Close();
                }
            }
        }
    }
}
