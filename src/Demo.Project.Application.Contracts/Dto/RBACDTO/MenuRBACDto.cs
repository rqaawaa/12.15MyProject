using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo.Project.Dto.RBACDTO
{
    public class MenuRBACDto : AuditedEntityDto<Guid>
    {
        public string MenuName { get; set; }//菜单名称
        public Guid FatherID { get; set; }//上级ID
        public string Url { get; set; }//跳转路径
    }
}
