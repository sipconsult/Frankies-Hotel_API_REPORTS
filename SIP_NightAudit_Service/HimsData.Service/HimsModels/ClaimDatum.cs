using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClaimDatum
    {
        public string ProcessClaimNo { get; set; }
        public double? BatchId { get; set; }
        public string DateOfConsultation { get; set; }
        public double? ClaimId { get; set; }
    }
}
