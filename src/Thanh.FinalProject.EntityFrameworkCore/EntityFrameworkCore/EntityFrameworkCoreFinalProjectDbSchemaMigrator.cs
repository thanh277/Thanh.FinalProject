using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Thanh.FinalProject.Data;
using Volo.Abp.DependencyInjection;

namespace Thanh.FinalProject.EntityFrameworkCore
{
    public class EntityFrameworkCoreFinalProjectDbSchemaMigrator
        : IFinalProjectDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFinalProjectDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FinalProjectDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FinalProjectDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
