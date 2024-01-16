using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class FacilityRate
    {
        public string FacilityName { get; set; }
        public double? TaxRate { get; set; }
        public int? Category { get; set; }
    }
}
