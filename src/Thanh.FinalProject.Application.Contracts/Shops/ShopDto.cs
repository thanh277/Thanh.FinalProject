using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Thanh.FinalProject.Shops
{
  public  class ShopDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }
       
        public int Size { get; set; }
        public string Address { get; set; }

    }
}
