using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace SQLDatabaseAccesser.Dapper;
public class DapperSQLAccess
{

    private readonly IConfiguration _config;

    public DapperSQLAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<T>> loadData<T, U>(
        string storedProcedure,
        U parameters)
    {
        using IDbConnection connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=True;");

        return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

    }

    public async Task SaveData<T>(
        string storedProcedure,
        T parameters)
    {
        using IDbConnection connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=True;");

        await connection.ExecuteAsync(storedProcedure, parameters);
    }

}

