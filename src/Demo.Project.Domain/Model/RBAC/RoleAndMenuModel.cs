using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.RBAC
{
    public class RoleAndMenuModel : AuditedAggregateRoot<Guid>
    {
        public Guid RoleID { get; set; }
        public Guid MneuID { get; set; }
    }
}
