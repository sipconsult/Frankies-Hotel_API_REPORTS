using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class PolicyHolderInformation
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? InsurancePolicyId { get; set; }
        public string PolicyNumber { get; set; }
        public string Surname { get; set; }
        public string Othernames { get; set; }
        public string LegalAddress { get; set; }
        public string Phone { get; set; }
        public int? UserId { get; set; }
    }
}
