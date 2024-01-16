using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ProviderCategory
    {
        public int ProviderCatId { get; set; }
        public string ProviderCatName { get; set; }
        public decimal? TaxRate { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public string Active { get; set; }
    }
}
