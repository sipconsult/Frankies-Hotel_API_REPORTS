using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class SyncBatch
    {
        public int Id { get; set; }
        public string BatchNo { get; set; }
        public string DataTable { get; set; }
        public string Action { get; set; }
        public string Completion { get; set; }
        public bool? Status { get; set; }
        public byte? Init { get; set; }
    }
}
