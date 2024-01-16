using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class RxLimitCodeMeaning
    {
        public int Id { get; set; }
        public string RxLimitCode { get; set; }
        public string RxLimitMeaning { get; set; }
    }
}
