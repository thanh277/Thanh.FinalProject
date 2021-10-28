using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanh.FinalProject.Areas;
using Thanh.FinalProject.EntityFrameworkCore;
using Thanh.FinalProject.services.Dto;
using Thanh.FinalProject.Shops;
using Thanh.FinalProject.test;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.Dapper;

namespace Thanh.FinalProject.services.Contracts
{
   public interface IAreaRepository
   {


        Task<List<string>> GetName();
        Task CreateAsync(Area area);
        Task<int> Update(Guid id, CreateUpdateArea input);   
        Task<List<Area>> GetListAsync();

        Task DeleteAsync(Area area);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Guid id, CreateUpdateArea input);
        Task<int> GetID(Guid id);
    }

}
