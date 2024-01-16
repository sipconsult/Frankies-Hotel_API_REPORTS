using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ProvAdd
    {
        public double? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public DateTime? JoinDate { get; set; }
    }
}
