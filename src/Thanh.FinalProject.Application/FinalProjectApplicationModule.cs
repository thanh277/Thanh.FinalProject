using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.Dapper;
using Microsoft.Extensions.DependencyInjection;
using Thanh.FinalProject.services.Contracts;
using Thanh.FinalProject.services.Dapper;

namespace Thanh.FinalProject
{
    [DependsOn(
        typeof(FinalProjectDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(FinalProjectApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule),
        typeof(AbpSettingManagementApplicationModule),
        typeof(AbpDapperModule)
        )]
    public class FinalProjectApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<FinalProjectApplicationModule>();
            });
           context.Services.AddScoped<IAreaRepository, AreaDapperRepository>();
        }
    }
}
