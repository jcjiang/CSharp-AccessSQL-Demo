using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace SQLDatabaseAccesser;
public class DapperSQLAccess
{

    private readonly IConfiguration _config;

    public DapperSQLAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<T>> loadData<T, U>(
        string storedProcedure,
        U parameters,
        string connectionID = "Default")
        {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionID));

        return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
}

