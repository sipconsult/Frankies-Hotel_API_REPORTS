using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class HimsBatch
    {
        public double? BatchId { get; set; }
        public double? AmountReceived { get; set; }
        public string ClaimMonth { get; set; }
        public double? ProviderId { get; set; }
    }
}
