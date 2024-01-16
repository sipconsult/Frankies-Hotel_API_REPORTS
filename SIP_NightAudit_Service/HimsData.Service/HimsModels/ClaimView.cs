using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClaimView
    {
        public long ClaimId { get; set; }
        public DateTime? ClaimMonth { get; set; }
        public int BatchId { get; set; }
        public DateTime ServiceDate { get; set; }
        public int MemberId { get; set; }
        public int? ClientBenefits { get; set; }
        public DateTime? DetentionDate { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? DismissialDate { get; set; }
        public string InvoiceNo { get; set; }
        public int? ClientId { get; set; }
        public DateTime? VettedDate { get; set; }
        public string VettedBy { get; set; }
        public string ReferredBy { get; set; }
        public DateTime? ReferredDate { get; set; }
        public string Physician { get; set; }
        public string ProcessClaimNo { get; set; }
        public string ClaimStatusString { get; set; }
        public string FinanceDecisionStatusString { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string ClientName { get; set; }
        public string ClaimTypeString { get; set; }
        public int NbTreatments { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalRejectedAmount { get; set; }
        public decimal TotalSuspendedAmount { get; set; }
        public decimal TotalToBePaid { get; set; }
        public string FullPolicyNo { get; set; }
        public string Fullname { get; set; }
        public string PolicyNo { get; set; }
        public int? NbAttendance { get; set; }
        public string PhoneNumber { get; set; }
    }
}
