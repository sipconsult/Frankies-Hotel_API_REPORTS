using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class PrintBatch
    {
        public int Id { get; set; }
        public string Batchno { get; set; }
        public int CountItems { get; set; }
        public string Status { get; set; }
    }
}
