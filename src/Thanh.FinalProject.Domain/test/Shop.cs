using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Thanh.FinalProject.test
{
public class Shop : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
     
        public int Size { get; set; }
        public string Address { get; set; }


    }
}
