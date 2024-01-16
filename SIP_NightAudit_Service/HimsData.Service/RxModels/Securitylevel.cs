using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class Securitylevel
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public string MenuCartegory { get; set; }
        public int? MenuPosition { get; set; }
        public string MainMenu { get; set; }
        public int? MenuPlace { get; set; }
    }
}
