using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.RBAC
{
    public class UserAndRoleModel : AuditedAggregateRoot<Guid>
    {
        public Guid UserID { get; set; }
        public Guid RoleID { get; set; }
    }
}
