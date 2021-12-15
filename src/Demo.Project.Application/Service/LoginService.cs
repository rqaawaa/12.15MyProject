using Demo.Project.Dto.GoodsDTO;
using Demo.Project.Dto.UserDTO;
using Demo.Project.Model.MyUserModel;
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

using Demo.Project.IDS4Service;

using Microsoft.Extensions.Configuration;

namespace Demo.Project.Service
{
    public class LoginService : CrudAppService<LoginModel, LoginDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGoodsDto>, ILogin
    {

        private IConfiguration _configuration;
        IRepository<LoginModel, Guid> _repository;
        
        public LoginService(IRepository<LoginModel, Guid> repository, IConfiguration configuration) : base(repository)
        {
            _repository = repository;
            _configuration = configuration;
        }
       
   
        [HttpPost, Route("Login")]
        public async Task<string> Login(LoginDto loginDto)
        {
            var list = _repository.GetListAsync().Result;
            var s = list.Where(s => s.UserName == loginDto.UserName && s.PassWord == loginDto.PassWord).FirstOrDefault();

          
            if (s != null)
            {
                MyIDS4Service a = new MyIDS4Service(_configuration);
                var b = a.GetIdsTokenAsync(s.UserName, s.PassWord);
                return await b;
            }
            else
            {
                return await Task.FromResult("登录失败");
            }
        }
    }
}
