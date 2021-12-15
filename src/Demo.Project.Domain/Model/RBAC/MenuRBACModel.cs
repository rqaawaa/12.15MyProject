using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Project.Model.RBAC
{
    public class MenuRBACModel : AuditedAggregateRoot<Guid>
    {
        public string MenuName { get; set; }//菜单名称
        public Guid FatherID { get; set; }//上级ID
        public string Url { get; set; }//跳转路径
    }
}
