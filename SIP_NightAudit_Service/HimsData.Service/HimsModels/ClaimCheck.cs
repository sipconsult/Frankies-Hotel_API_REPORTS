using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClaimCheck
    {
        public int? Id { get; set; }
        public string ProcessClaimNo { get; set; }
        public string Item { get; set; }
        public double? UnitPrice { get; set; }
        public double? UnitPriceAwarded { get; set; }
        public double? UnitPriceFinance { get; set; }
        public string DecisionStatus { get; set; }
    }
}
