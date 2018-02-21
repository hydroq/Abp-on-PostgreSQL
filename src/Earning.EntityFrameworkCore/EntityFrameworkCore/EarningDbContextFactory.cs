using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Earning.Configuration;
using Earning.Web;

namespace Earning.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EarningDbContextFactory : IDesignTimeDbContextFactory<EarningDbContext>
    {
        public EarningDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EarningDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EarningDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EarningConsts.ConnectionStringName));

            return new EarningDbContext(builder.Options);
        }
    }
}
