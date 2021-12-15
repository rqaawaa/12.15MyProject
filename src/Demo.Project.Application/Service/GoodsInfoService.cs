using Demo.Project.Dto.GoodsDTO;
using Demo.Project.Model.MyGoods;
using Demo.Project.MyInterface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Project.Service
{
    public class GoodsInfoService :CrudAppService<MyGoodsInfoModel, MyGoodsInfoDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGoodsDto>, IGetMyGoodsInfo
    {
        IRepository<MyGoodsInfoModel, Guid> _repository;
        public GoodsInfoService(IRepository<MyGoodsInfoModel, Guid> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
