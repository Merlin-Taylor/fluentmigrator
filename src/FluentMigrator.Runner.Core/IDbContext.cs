using System.Data;

namespace FluentMigrator.Runner;

public interface IDbContext
{
    public IDbConnection CreateConnection();
}
