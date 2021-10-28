using System;
using System.Collections.Generic;
using System.Text;
using Thanh.FinalProject.Areas;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Thanh.FinalProject.Items
{
  public  interface IItem : ICrudAppService< //Defines CRUD methods
            ItemDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateItem> //Used to create/update a book
    {
    }
}
