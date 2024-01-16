using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClaimSymptom
    {
        public int ClaimId { get; set; }
        public int SymptomId { get; set; }
        public string Symptom { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
