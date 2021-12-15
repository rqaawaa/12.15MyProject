using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.RBACDTO
{
    public class RoleRBACDto : AuditedEntityDto<Guid>
    {
        public string RoleName { get; set; }//角色名称
        public string Remark { get; set; }//描述
        public DateTime RoleCreateTime { get; set; }//角色创建时间
    }
}
