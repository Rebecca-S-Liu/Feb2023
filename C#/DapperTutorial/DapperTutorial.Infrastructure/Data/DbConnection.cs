using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DapperTutorial.Infrastructure.Data;

public class DbConnection
{
    public SqlConnection GetConnection()
    {
        var conn = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build()
            .GetConnectionString("FebBatchDb");
        return new SqlConnection(conn);
    }
}