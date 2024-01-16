using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class OldClaim
    {
        public string Provider { get; set; }
        public DateTime? ClaimMonth { get; set; }
        public DateTime? EndofMonth { get; set; }
        public int? ProviderId { get; set; }
        public double? ServiceProvideId { get; set; }
        public double? AmountClaimed { get; set; }
        public double? OtherDeduction { get; set; }
        public double? AmountDue { get; set; }
        public double? Withold { get; set; }
    }
}
