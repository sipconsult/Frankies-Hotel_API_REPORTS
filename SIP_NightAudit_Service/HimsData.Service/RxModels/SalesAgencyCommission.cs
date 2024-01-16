using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class SalesAgencyCommission
    {
        public int Id { get; set; }
        public int? SalesId { get; set; }
        public string AgentName { get; set; }
        public string Commisson { get; set; }
        public string Company { get; set; }
    }
}
