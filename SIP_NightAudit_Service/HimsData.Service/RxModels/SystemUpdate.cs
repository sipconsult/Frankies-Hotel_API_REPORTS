using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class SystemUpdate
    {
        public int Id { get; set; }
        public string TypeOfUpdates { get; set; }
        public string Area { get; set; }
        public string Type { get; set; }
    }
}
