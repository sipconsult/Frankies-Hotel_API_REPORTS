using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClaimDeleted
    {
        public int Id { get; set; }
        public string ProcessClaimNo { get; set; }
    }
}
