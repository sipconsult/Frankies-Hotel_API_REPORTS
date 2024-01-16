using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class PrintBatchDetail
    {
        public int Id { get; set; }
        public int Batchno { get; set; }
        public string Query { get; set; }
        public string Status { get; set; }
    }
}
