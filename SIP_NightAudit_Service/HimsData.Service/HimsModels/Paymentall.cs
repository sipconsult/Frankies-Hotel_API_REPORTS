using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Paymentall
    {
        public DateTime? DateTransaction { get; set; }
        public string Description { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public double? Debit { get; set; }
        public string Credit { get; set; }
        public string ReferenceNo { get; set; }
    }
}
