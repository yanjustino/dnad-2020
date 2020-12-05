using System.Data.Common;
using System.Data.SqlClient;
using Dnad.Architects.Application.Ports.Database;

namespace Dnad.Architects.Adapters.SqlServer
{
    public class SqlServerHolder : IDatabaseHolder
    {
        public DbConnection GetDbConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }
    }
}
