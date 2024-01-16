using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClaimQueryDiagnosis
    {
        public long Id { get; set; }
        public int? ProviderId { get; set; }
        public string DiseaseGrp { get; set; }
        public int? DiseaseId { get; set; }
        public string DiseaseCode { get; set; }
        public string DiseaseName { get; set; }
        public string ProcessClaimNo { get; set; }
        public string Status { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
