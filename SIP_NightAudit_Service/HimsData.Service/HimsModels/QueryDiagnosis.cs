using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class QueryDiagnosis
    {
        public double? Id { get; set; }
        public double? ServerId { get; set; }
        public double? ProviderDataId { get; set; }
        public double? ProviderId { get; set; }
        public double? DiseaseId { get; set; }
        public string DiseaseCode { get; set; }
        public string DiseaseName { get; set; }
        public string ProcessClaimNo { get; set; }
        public string Status { get; set; }
        public DateTime? DateTime { get; set; }
        public int? DiagnosisId { get; set; }
        public int? ClaimId { get; set; }
    }
}
