using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClaimTreatment
    {
        public int Id { get; set; }
        public long ClaimId { get; set; }
        public int TreatmentId { get; set; }
        public string Treatment { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal? SuspendedAmount { get; set; }
        public decimal? RejectedAmount { get; set; }
        public string ReasonForRejection { get; set; }
        public string OtherReason { get; set; }
        public int? ClientBenefits { get; set; }
        public string ItemService { get; set; }
        public long? RxId { get; set; }
    }
}
