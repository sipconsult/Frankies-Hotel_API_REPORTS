using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class SyncPullLog
    {
        public int Id { get; set; }
        public string Method { get; set; }
        public int LastId { get; set; }
        public int Row { get; set; }
        public string InsCompany { get; set; }
    }
}
