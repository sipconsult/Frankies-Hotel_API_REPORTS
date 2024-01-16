using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class ProviderApiPhoto
    {
        public int Id { get; set; }
        public string ProviderId { get; set; }
        public string Photo { get; set; }
    }
}
