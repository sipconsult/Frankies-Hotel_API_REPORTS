using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class NewPayment
    {
        public string TransactionDate { get; set; }
        public double? ProviderId { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }
        public double? Amount { get; set; }
    }
}
