using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class InvoiceView
    {
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public DateTime ClaimMonth { get; set; }
        public DateTime? EndOfMonth { get; set; }
        public int BatchId { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalRejectedAmount { get; set; }
        public decimal TotalToBePaid { get; set; }
    }
}
