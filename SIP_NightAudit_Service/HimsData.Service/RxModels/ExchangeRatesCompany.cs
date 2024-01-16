using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class ExchangeRatesCompany
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public double? ExchangeRate { get; set; }
        public string Username { get; set; }
        public string EmployerId { get; set; }
    }
}
