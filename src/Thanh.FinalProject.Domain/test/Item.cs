using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Thanh.FinalProject.test
{
  public  class Item: FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
