using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Sadec.Sample.EntityFrameworkCore
{
    public static class SampleDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SampleDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SampleDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
