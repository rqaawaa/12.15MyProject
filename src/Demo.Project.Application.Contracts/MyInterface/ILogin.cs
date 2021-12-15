using Demo.Project.Dto.GoodsDTO;
using Demo.Project.Dto.UserDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Project.MyInterface
{
    public interface ILogin : ICrudAppService<LoginDto, Guid, 
        PagedAndSortedResultRequestDto, CreateUpdateGoodsDto>
    {





        Task<string> Login(LoginDto loginDto);
    }
}
