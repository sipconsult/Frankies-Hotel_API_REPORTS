using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ProviderCategoryView
    {
        public int ProviderCatId { get; set; }
        public string ProviderCatName { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public string Active { get; set; }
        public string ActiveString { get; set; }
    }
}
