using System.Data.Common;

namespace FluentMigrator.Runner;

public interface IDbContext
{
    public DbConnection CreateConnection();
}
