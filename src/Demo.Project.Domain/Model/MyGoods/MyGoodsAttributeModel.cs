using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.MyGoods
{
    public class MyGoodsAttributeModel : AuditedAggregateRoot<Guid>
    {
        public string AttributeName { get; set; }//属性名称
        public bool Isno { get; set; }//是否有属性
    }
}
