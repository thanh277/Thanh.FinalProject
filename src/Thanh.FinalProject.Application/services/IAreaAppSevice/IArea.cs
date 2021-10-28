using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Thanh.FinalProject.Areas;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Thanh.FinalProject.services.ITable1AppService
{
 public   class IArea : CrudAppService<
              test.Area, //The Book entity
              Areas.AreaDto, //Used to show books
              Guid, //Primary key of the book entity
              PagedAndSortedResultRequestDto, //Used for paging/sorting
              CreateUpdateArea>, //Used to create/update a book
          IAreaAppService //implement the IBookAppService
    {
        public IArea(IRepository<test.Area, Guid> repository)
                 : base(repository)
        {

        }
        [HttpPost("api/Area/Post")]
        public override Task<Areas.AreaDto> CreateAsync(CreateUpdateArea input)
        {
            return base.CreateAsync(input);
        }
        [HttpDelete("api/Area/Delete")]
        public override Task DeleteAsync(Guid id)
        {
            return base.DeleteAsync(id);
        }
        [HttpGet("api/Area/Get")]
        public override Task<AreaDto> GetAsync(Guid id)
        {
            return base.GetAsync(id);
        }
        [HttpGet("api/Area/GetAll")]
        public override Task<PagedResultDto<Areas.AreaDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            
            return base.GetListAsync(input);
        }
        [HttpPut("api/Area/Update")]
        public override Task<Areas.AreaDto> UpdateAsync(Guid id, CreateUpdateArea input)
        {
            return base.UpdateAsync(id, input);
        }
    }
}
