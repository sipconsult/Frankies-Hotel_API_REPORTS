using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ProvidersInvoice
    {
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public DateTime? ClaimMonth { get; set; }
        public DateTime? EndOfMonth { get; set; }
        public double? TotalAmount { get; set; }
        public double? TotalRejectedAmount { get; set; }
        public double? TotalToBePaid { get; set; }
        public double? TotalTax { get; set; }
        public int? BatchId { get; set; }
    }
}
