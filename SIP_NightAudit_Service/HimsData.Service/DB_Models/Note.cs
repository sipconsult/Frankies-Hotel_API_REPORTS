using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.DB_Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public int? GuestId { get; set; }
        public string Notes { get; set; }
        public DateTime? Timestamp { get; set; }

        public virtual Guest Guest { get; set; }
    }
}
