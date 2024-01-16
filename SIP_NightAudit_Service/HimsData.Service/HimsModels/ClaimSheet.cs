using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClaimSheet
    {
        public long? Id { get; set; }
        public string ClaimType { get; set; }
        public string ProcessClaimNo { get; set; }
        public int? ClaimType1 { get; set; }
        public int? ClaimId { get; set; }
    }
}
