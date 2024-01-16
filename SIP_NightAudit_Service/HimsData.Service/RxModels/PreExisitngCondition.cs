using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class PreExisitngCondition
    {
        public int Id { get; set; }
        public string Condition { get; set; }
        public string Type { get; set; }
    }
}
