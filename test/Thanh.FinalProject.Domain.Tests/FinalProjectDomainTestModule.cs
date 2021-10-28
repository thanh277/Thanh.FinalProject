using Thanh.FinalProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Thanh.FinalProject
{
    [DependsOn(
        typeof(FinalProjectEntityFrameworkCoreTestModule)
        )]
    public class FinalProjectDomainTestModule : AbpModule
    {

    }
}