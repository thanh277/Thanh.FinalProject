using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Thanh.FinalProject.Shops
{
   public interface IShopAppService : ICrudAppService< //Defines CRUD methods
            ShopDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateShop> //Used to create/update a book
    {
    }
}
