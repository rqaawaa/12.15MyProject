using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.GoodsDTO
{
    public class MyGoodsNumDto : AuditedEntityDto<Guid>
    {
        public decimal Price { get; set; }//商品价格
        public int GoodsInventory { get; set; }//商品库存
        public int GoodsWeight { get; set; }//商品重量
        public int GoodsNum { get; set; }//商品数量
    }
}
