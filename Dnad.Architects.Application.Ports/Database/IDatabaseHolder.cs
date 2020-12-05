using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Dnad.Architects.Application.Ports.Database
{
    public interface IDatabaseHolder
    {
        DbConnection GetDbConnection(string connectionString);
    }
}
