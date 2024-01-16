using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class ExchangeRate
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public double? ExchangeRate1 { get; set; }
        public string Username { get; set; }
        public DateTime? DateTime { get; set; }
        public string EmployerId { get; set; }
    }
}
