using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class LeadItem
    {
        public int LeadId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int NoOfMembers { get; set; }
        public int NoOfDependants { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
