using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.MyUserModel
{
    public class LoginModel : AuditedAggregateRoot<Guid>
    {
        public string UserName { get; set; }//用户名
        public string PassWord { get; set; }//密码
        public DateTime CreateTime { get; set; } = DateTime.Now;//创建时间
    }
}
