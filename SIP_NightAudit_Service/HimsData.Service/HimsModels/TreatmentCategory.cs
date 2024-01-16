using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class TreatmentCategory
    {
        public short CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public byte Active { get; set; }
    }
}
