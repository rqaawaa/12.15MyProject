using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.RBACDTO
{
    public class RoleAndMenuDto : AuditedEntityDto<Guid>
    {
        public Guid RoleID { get; set; }
        public Guid MneuID { get; set; }
    }
}
