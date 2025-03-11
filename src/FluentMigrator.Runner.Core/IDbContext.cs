using System;
using System.Data.Common;

namespace FluentMigrator.Runner;

public interface IDbContext
{
    public DbCommand CreateCommand();
    public DbCommandBuilder CreateCommandBuilder();
    public DbConnection CreateConnection();
    public DbConnectionStringBuilder CreateConnectionStringBuilder();
    public DbDataAdapter CreateDataAdapter();
    public DbDataSourceEnumerator CreateDataSourceEnumerator();
    public DbParameter CreateParameter();
}
