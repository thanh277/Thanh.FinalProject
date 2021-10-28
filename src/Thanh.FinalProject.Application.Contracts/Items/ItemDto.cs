using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Thanh.FinalProject.Items
{
 public  class ItemDto :FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

