using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class PolicyInformation
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? InsurancePolicyId { get; set; }
        public string PolicyNumber { get; set; }
        public int? PlanId { get; set; }
        public string PlanName { get; set; }
        public double? QuotationPrice { get; set; }
        public int? Quantity { get; set; }
        public int? UserId { get; set; }
    }
}
