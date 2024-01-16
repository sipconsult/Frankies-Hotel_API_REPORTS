using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class HimsClaim
    {
        public string ProcessClaimNo { get; set; }
        public long ClaimId { get; set; }
        public int ProviderId { get; set; }
        public DateTime ServiceDate { get; set; }
        public long Id { get; set; }
        public string AttendingOfficer { get; set; }
        public string TypeOfVisit { get; set; }
        public int? TypeOfVisitId { get; set; }
        public string MemberNo { get; set; }
        public long? MemberId { get; set; }
        public int? ProductId { get; set; }
        public string Diagnosis { get; set; }
        public long? DiagnosisId { get; set; }
        public long? BatchId { get; set; }
        public int? ClaimStatus { get; set; }
        public int? FinanceDecisionStatus { get; set; }
        public int? ClaimType { get; set; }
    }
}
