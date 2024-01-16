using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class SecurityRolesPermission
    {
        public int Id { get; set; }
        public int? PermRoleId { get; set; }
        public int? SecuritylevelId { get; set; }
    }
}
