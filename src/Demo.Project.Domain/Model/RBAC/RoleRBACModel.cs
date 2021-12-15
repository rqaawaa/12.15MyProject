using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.RBAC
{
    public class RoleRBACModel : AuditedAggregateRoot<Guid>
    {
        public string RoleName { get; set; }//角色名称
        public string Remark { get; set; }//描述
        public DateTime RoleCreateTime { get; set; }//角色创建时间
    }
}
