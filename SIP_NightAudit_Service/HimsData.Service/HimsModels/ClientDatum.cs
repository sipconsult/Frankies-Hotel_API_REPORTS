using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ClientDatum
    {
        public string CompanyId { get; set; }
        public string Company { get; set; }
        public DateTime? PolicyStartDate { get; set; }
        public DateTime? PolicyEndDate { get; set; }
        public string CompanyStatus { get; set; }
        public int? Active { get; set; }
    }
}
