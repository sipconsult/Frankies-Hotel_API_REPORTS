using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Claim
    {
        public long ClaimId { get; set; }
        public int BatchId { get; set; }
        public DateTime ServiceDate { get; set; }
        public int MemberId { get; set; }
        public int? ClientBenefits { get; set; }
        public DateTime? DetentionDate { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? DismissialDate { get; set; }
        public string InvoiceNo { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public DateTime? VettedDate { get; set; }
        public string VettedBy { get; set; }
        public string ReferredBy { get; set; }
        public DateTime? ReferredDate { get; set; }
        public string Physician { get; set; }
        public int ProductId { get; set; }
        public int? ClaimStatus { get; set; }
        public int? FinanceDecisionStatus { get; set; }
        public int? ClaimType { get; set; }
        public string ProcessClaimNo { get; set; }
        public short? TypeOfVisit { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
