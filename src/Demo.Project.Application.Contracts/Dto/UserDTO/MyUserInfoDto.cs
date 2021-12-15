using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.UserDTO
{
    public class MyUserInfoDto : AuditedEntityDto<Guid>
    {
        public string UserName { get; set; }//用户名称
        public int Age { get; set; }//年龄
        public bool Sex { get; set; }//性别
        public string Hobby { get; set; }//爱好
        public string Email { get; set; }//邮箱
        public string Phone { get; set; }//手机号
        public DateTime CreateTime { get; set; } = DateTime.Now;//创建时间
        public DateTime Brithday { get; set; }//生日
    }
}
