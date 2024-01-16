using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.DB_Models
{
    public partial class NightAudit
    {
        public int Id { get; set; }
        public int? NumberOfTransaction { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
