using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ProviderFix
    {
        public double? ProviderId { get; set; }
        public double? ProviderCategoryId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderCatName { get; set; }
        public double? TaxRate { get; set; }
    }
}
