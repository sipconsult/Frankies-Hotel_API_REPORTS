using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Batch
    {
        public int BatchId { get; set; }
        public int? BookNo { get; set; }
        public DateTime BatchDate { get; set; }
        public DateTime? PayDate { get; set; }
        public string ClaimType { get; set; }
        public decimal AmountReceived { get; set; }
        public decimal? AmountPaid { get; set; }
        public string Remarks { get; set; }
        public DateTime ClaimMonth { get; set; }
        public short Status { get; set; }
        public DateTime? DateOfCompletion { get; set; }
        public DateTime? AccountDate { get; set; }
        public string AssignedTo { get; set; }
        public string PaidBy { get; set; }
        public short Resubmitted { get; set; }
        public int ProviderId { get; set; }
        public int? ClientId { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
