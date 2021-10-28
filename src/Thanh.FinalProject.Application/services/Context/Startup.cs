using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Thanh.FinalProject.services.Contracts;
using Thanh.FinalProject.services.Dapper;
using Thanh.FinalProject.services.Repository;

namespace Thanh.FinalProject.services.Context
{
   public class Startup 
    {
        public void ConfigureServices(IServiceCollection services)
        {      
            services.AddSingleton<DapperContext>();
            services.AddScoped<IAreaRepository, AreaDapperRepository>();
            services.AddControllers();
        }
    }
}
