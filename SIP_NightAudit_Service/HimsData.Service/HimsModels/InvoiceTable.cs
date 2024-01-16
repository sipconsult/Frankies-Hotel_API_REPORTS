using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class InvoiceTable
    {
        public double? Id { get; set; }
        public string ProviderId { get; set; }
        public string ProviderName { get; set; }
        public double? Yrofclaim { get; set; }
        public double? Monthofclaim { get; set; }
        public double? ProviderClaimAmt { get; set; }
        public string SystemInvoiceNo { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateOfClaim { get; set; }
        public double? NumberOfClaims { get; set; }
    }
}
