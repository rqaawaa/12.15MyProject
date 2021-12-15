using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.UserDTO
{
    public class LoginDto : AuditedEntityDto<Guid>
    {
        public string UserName { get; set; }//用户名
        public string PassWord { get; set; }//密码
        public DateTime CreateTime { get; set; } = DateTime.Now;//创建时间
    }
}
