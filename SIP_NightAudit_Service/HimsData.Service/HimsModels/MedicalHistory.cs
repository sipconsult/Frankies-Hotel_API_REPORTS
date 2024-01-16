using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class MedicalHistory
    {
        public int MemberId { get; set; }
        public int DiagnosisId { get; set; }
        public string Comments { get; set; }
    }
}
