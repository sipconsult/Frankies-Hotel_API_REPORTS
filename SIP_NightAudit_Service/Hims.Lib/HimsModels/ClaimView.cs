using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ClaimView
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
        public int ClientId { get; set; }
        public DateTime? VettedDate { get; set; }
        public string VettedBy { get; set; }
        public string ReferredBy { get; set; }
        public DateTime? ReferredDate { get; set; }
        public string Physician { get; set; }
        public int ProviderId { get; set; }
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
    }
}
