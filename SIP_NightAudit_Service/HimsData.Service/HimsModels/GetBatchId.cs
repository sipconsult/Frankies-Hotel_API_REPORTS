using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class GetBatchId
    {
        public double? ProviderId { get; set; }
        public double? BatchId { get; set; }
    }
}
