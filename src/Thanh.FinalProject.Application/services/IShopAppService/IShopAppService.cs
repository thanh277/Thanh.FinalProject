using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanh.FinalProject.Areas;
using Thanh.FinalProject.Shops;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Thanh.FinalProject.services.ITable1AppService
{
    public interface IShopAppService : IApplicationService
    {
         Task<ShopDto> CreateAsync(CreateUpdateShop input);
        Task UpdateAsync(Guid id, CreateUpdateShop input);


         Task DeleteAsync(Guid id);
         Task<List<ShopDto>> GetListAsync();
         Task<List<ShopDto>> GetAsync(Guid id);
    }
}
