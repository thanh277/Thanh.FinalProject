using Volo.Abp.Modularity;

namespace Thanh.FinalProject
{
    [DependsOn(
        typeof(FinalProjectApplicationModule),
        typeof(FinalProjectDomainTestModule)
        )]
    public class FinalProjectApplicationTestModule : AbpModule
    {

    }
}