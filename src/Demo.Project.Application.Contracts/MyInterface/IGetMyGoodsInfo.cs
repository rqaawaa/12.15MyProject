using Demo.Project.Dto.GoodsDTO;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Project.MyInterface
{
    public interface IGetMyGoodsInfo : ICrudAppService<MyGoodsInfoDto, Guid,
        PagedAndSortedResultRequestDto, CreateUpdateGoodsDto>
    {
        
    }
}
