using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.GoodsDTO
{
    public class GoodsInfoAndTypeDto :AuditedEntityDto<Guid>
    {
        public Guid TypeID { get; set; }
        public Guid ImgID { get; set; }
    }
}
