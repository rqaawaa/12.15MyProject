using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.GoodsDTO
{
    public class MyGoodsInfoDto : AuditedEntityDto<Guid>
    {
        public string GoodsName { get; set; }//商品名称
        public string GoodsCode { get; set; }//商品编码
        public string GoodsImg { get; set; }//商品图片
        public string GoodsRemark { get; set; }//商品描述
        public DateTime ReleaseTime { get; set; }//发布时间
        public string GoodsStatu { get; set; }//商品状态
    }
}
