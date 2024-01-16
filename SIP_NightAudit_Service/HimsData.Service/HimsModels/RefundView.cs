using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class RefundView
    {
        public int RefundId { get; set; }
        public int MemberId { get; set; }
        public decimal AmountRefunded { get; set; }
        public DateTime DateRefunded { get; set; }
        public string InvoiceNo { get; set; }
        public string ClientName { get; set; }
        public string FullPolicyNo { get; set; }
        public string MemberTypeString { get; set; }
        public string FullName { get; set; }
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
    }
}
