using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.RBACDTO
{
    public class UserAndRoleDto : AuditedEntityDto<Guid>
    {
        public Guid UserID { get; set; }
        public Guid RoleID { get; set; }
    }
}
