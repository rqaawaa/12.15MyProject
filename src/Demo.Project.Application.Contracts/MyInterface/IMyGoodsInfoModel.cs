using Demo.Project.Dto.GoodsDTO;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Project.MyInterface
{
    public interface IMyGoodsInfoModel : ICrudAppService<MyGoodsInfoDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGoodsDto>
    {
    }
}
