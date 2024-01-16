using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class PatientPreCondition
    {
        public long Id { get; set; }
        public string InsComapny { get; set; }
        public int? InsurancePolicyId { get; set; }
        public int? PatientId { get; set; }
        public int? ParentId { get; set; }
        public string Condition { get; set; }
    }
}
