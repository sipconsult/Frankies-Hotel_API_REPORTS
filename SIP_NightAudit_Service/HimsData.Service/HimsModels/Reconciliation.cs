using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Reconciliation
    {
        public long RecordId { get; set; }
        public int MemberId { get; set; }
        public int ProviderId { get; set; }
        public int ClientId { get; set; }
        public decimal? Cost { get; set; }
        public string InvoiceNo { get; set; }
        public string ClaimMonth { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
