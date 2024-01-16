using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class InsuranceCompanyAccess
    {
        public long Id { get; set; }
        public string ProviderId { get; set; }
        public string InsuranceCompanyId { get; set; }
        public string Status { get; set; }
    }
}
