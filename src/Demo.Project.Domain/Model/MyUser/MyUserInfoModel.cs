using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.MyUserModel
{
    public class MyUserInfoModel : AuditedAggregateRoot<Guid>
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
