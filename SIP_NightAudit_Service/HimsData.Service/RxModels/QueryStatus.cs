using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class QueryStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Ranking { get; set; }
    }
}
