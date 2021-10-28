using Thanh.FinalProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Thanh.FinalProject.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FinalProjectEntityFrameworkCoreModule),
        typeof(FinalProjectApplicationContractsModule)
        )]
    public class FinalProjectDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
