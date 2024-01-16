using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class AdjudicationRule
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string AdjudicationRule1 { get; set; }
        public string InsCompany { get; set; }
        public string Status { get; set; }
    }
}
