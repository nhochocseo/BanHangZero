using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Center.Production.EntityFrameworkCore
{
    public static class ProductionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProductionDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProductionDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}