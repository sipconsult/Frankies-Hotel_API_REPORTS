using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class ProviderServiceCategory
    {
        public int Id { get; set; }
        public string ProviderId { get; set; }
        public string CartegoryName { get; set; }
        public string CartegoryCode { get; set; }
        public string GeneralCartegoryCode { get; set; }
    }
}
