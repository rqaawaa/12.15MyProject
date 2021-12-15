using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.MyGoods
{
    public class MyGoodsTypeModel : AuditedAggregateRoot<Guid>
    {
        public string GoodsTypeName { get; set; }//商品类别名称
        public int TypeID { get; set; }//类别ID
        public string GoodsTypeStatu { get; set; }//商品状态
        public DateTime AddTime { get; set; }//添加时间
    }
}
