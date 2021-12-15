using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.GoodsDTO
{
    public class MyGoodsAttributeDto : AuditedEntityDto<Guid>
    {
        public string AttributeName { get; set; }//属性名称
        public bool Isno { get; set; }//是否有属性
    }
}
