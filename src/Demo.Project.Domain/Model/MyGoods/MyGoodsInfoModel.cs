using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.MyGoods
{
    public class MyGoodsInfoModel : AuditedAggregateRoot<Guid>
    {
        public string GoodsName { get; set; }//商品名称
        public string GoodsCode { get; set; }//商品编码
        public string GoodsImg { get; set; }//商品图片
        public string GoodsRemark { get; set; }//商品描述
        public DateTime ReleaseTime { get; set; }//发布时间
        public string GoodsStatu { get; set; }//商品状态
    }
}
