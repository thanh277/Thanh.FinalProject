using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Thanh.FinalProject.Areas
{
   public interface IAreaAppService : ICrudAppService< //Defines CRUD methods
            AreaDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateArea> //Used to create/update a book
    {
       
    }
}
