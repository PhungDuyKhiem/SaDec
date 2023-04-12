using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Sadec.Sample.Authorization.Roles;
using Sadec.Sample.Authorization.Users;
using Sadec.Sample.MultiTenancy;

namespace Sadec.Sample.EntityFrameworkCore
{
    public class SampleDbContext : AbpZeroDbContext<Tenant, Role, User, SampleDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SampleDbContext(DbContextOptions<SampleDbContext> options)
            : base(options)
        {
        }
    }
}
