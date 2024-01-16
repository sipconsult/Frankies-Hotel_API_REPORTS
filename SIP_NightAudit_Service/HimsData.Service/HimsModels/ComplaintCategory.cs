using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ComplaintCategory
    {
        public ComplaintCategory()
        {
            Complaints = new HashSet<Complaint>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public byte Active { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }

        public virtual ICollection<Complaint> Complaints { get; set; }
    }
}
