using Abp.Localization;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Earning.Authorization.Roles;
using Earning.Authorization.Users;
using Earning.MultiTenancy;

namespace Earning.EntityFrameworkCore
{
    public class EarningDbContext : AbpZeroDbContext<Tenant, Role, User, EarningDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EarningDbContext(DbContextOptions<EarningDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationLanguageText>()
                        .Property(p => p.Value)
                        .HasMaxLength(10485759);
        }
    }
}
