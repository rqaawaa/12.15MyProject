using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.MyGoods
{
    public class MyGoodsImgModel : AuditedAggregateRoot<Guid>
    {
        public string ImgUrl { get; set; }//图片路径
        public DateTime ImgTime { get; set; }//图片时间
    }
}
