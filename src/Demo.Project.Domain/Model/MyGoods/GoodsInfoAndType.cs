using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.MyGoods
{
    public class GoodsInfoAndType: AuditedAggregateRoot<Guid>
    {
        public Guid TypeID { get; set; }
        public Guid ImgID { get; set; }
    }
}
