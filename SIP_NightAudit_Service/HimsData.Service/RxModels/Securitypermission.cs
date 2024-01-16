using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class Securitypermission
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? SecuritylevelId { get; set; }
        public int? PermRoleId { get; set; }
    }
}
