using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class TempTran
    {
        public double? ProviderId { get; set; }
        public string DateTransaction { get; set; }
        public string ProviderName { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public string VoucherNo { get; set; }
        public string Description { get; set; }
        public double? BatchId { get; set; }
        public double? TypeTransaction { get; set; }
        public double? TransactionId { get; set; }
    }
}
