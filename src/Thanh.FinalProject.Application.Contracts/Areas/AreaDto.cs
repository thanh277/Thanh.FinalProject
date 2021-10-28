using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Thanh.FinalProject.Areas
{
    public class AreaDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
