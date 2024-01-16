using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class CompanyPaymentOption
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string PaymentOption { get; set; }
        public string InsCompany { get; set; }
    }
}
