using System.Data;
using System.Data.Common;

namespace FluentMigrator.Runner;

public static class DbContextExtensions
{
    public static IDbContext AsDbContext(this DbProviderFactory IDbContext)
    {
        return new IDbContextDbContextAdapter(IDbContext);
    }

    private class IDbContextDbContextAdapter : IDbContext
    {
        private readonly DbProviderFactory _IDbContext;

        public IDbContextDbContextAdapter(DbProviderFactory IDbContext)
        {
            _IDbContext = IDbContext;
        }


        public IDbConnection CreateConnection() => _IDbContext.CreateConnection();
    }
}
