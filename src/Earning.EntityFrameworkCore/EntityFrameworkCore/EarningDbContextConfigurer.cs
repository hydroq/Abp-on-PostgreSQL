using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Earning.EntityFrameworkCore
{
    public static class EarningDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EarningDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EarningDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
