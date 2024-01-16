using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class DiagSheet1
    {
        public int Id { get; set; }
        public long? DiagnosisId { get; set; }
        public long? ClaimId { get; set; }
        public string DiagnosisName { get; set; }
        public string Status { get; set; }
    }
}
