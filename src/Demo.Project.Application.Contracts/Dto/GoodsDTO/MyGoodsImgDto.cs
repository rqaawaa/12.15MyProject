using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.GoodsDTO
{
    public class MyGoodsImgDto : AuditedEntityDto<Guid>
    {
        public string ImgUrl { get; set; }//图片路径
        public DateTime ImgTime { get; set; }//图片时间
    }
}
