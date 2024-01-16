using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClientTypeView
    {
        public int ClientTypeId { get; set; }
        public string ClientTypeName { get; set; }
        public string Active { get; set; }
        public string ActiveString { get; set; }
    }
}
