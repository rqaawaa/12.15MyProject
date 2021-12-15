using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.GoodsDTO
{
    public class MyGoodsTypeDto : AuditedEntityDto<Guid>
    {
        public string GoodsTypeName { get; set; }//商品类别名称
        public int TypeID { get; set; }//类别ID
        public string GoodsTypeStatu { get; set; }//商品状态
        public DateTime AddTime { get; set; }//添加时间
    }
}
