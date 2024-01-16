using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class Bank
    {
        public int Id { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
    }
}
