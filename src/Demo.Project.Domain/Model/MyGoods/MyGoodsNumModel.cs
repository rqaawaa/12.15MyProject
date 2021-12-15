using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.MyGoods
{
    public class MyGoodsNumModel : AuditedAggregateRoot<Guid>
    {
        public decimal Price { get; set; }//商品价格
        public int GoodsInventory { get; set; }//商品库存
        public int GoodsWeight { get; set; }//商品重量
        public int GoodsNum { get; set; }//商品数量
    }
}
