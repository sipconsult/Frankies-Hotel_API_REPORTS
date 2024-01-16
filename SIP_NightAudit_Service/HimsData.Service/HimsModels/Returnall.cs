using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Returnall
    {
        public DateTime? DateTransaction { get; set; }
        public string TransactionType { get; set; }
        public string Reference { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string Description { get; set; }
        public double? Amount { get; set; }
    }
}
