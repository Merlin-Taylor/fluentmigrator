using System;
using System.Data.Common;

namespace FluentMigrator.Runner;

public static class DbContextExtensions
{
    public static IDbContext AsDbContext(this DbProviderFactory IDbContext) {
        return new IDbContextDbContextAdapter(IDbContext);
    }

    private class IDbContextDbContextAdapter: IDbContext {
        private readonly DbProviderFactory _IDbContext;

        public IDbContextDbContextAdapter(DbProviderFactory IDbContext) {
            _IDbContext = IDbContext;
        }

        public DbCommand CreateCommand() => _IDbContext.CreateCommand();

        public DbCommandBuilder CreateCommandBuilder() => _IDbContext.CreateCommandBuilder();

        public DbConnection CreateConnection() => _IDbContext.CreateConnection();

        public DbConnectionStringBuilder CreateConnectionStringBuilder() => _IDbContext.CreateConnectionStringBuilder();

        public DbDataAdapter CreateDataAdapter() => _IDbContext.CreateDataAdapter();

        public DbDataSourceEnumerator CreateDataSourceEnumerator() => _IDbContext.CreateDataSourceEnumerator();

        public DbParameter CreateParameter() => _IDbContext.CreateParameter();
    }
}
