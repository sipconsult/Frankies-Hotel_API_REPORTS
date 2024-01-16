using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClaimLoad
    {
        public string ProcessClaimNo { get; set; }
        public double? ClaimId { get; set; }
        public double? Id { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string MemberNo { get; set; }
        public string TypeOfVisit { get; set; }
        public int? TypeOfVisitId { get; set; }
        public long? MemberId { get; set; }
        public int? ProductId { get; set; }
        public long? BatchId { get; set; }
        public int? ClaimStatus { get; set; }
        public int? ClaimType { get; set; }
        public int? FinanceDecisionStatus { get; set; }
        public string AttendingOfficer { get; set; }
    }
}
