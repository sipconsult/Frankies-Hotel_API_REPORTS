using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class MemberReport
    {
        public int Id { get; set; }
        public string Reportname { get; set; }
        public string Reportcode { get; set; }
        public int? Reportorder { get; set; }
        public string Typeofrep { get; set; }
    }
}
