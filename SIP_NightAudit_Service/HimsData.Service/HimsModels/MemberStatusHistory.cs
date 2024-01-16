using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class MemberStatusHistory
    {
        public int RecordId { get; set; }
        public string MemberId { get; set; }
        public string Client { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Status { get; set; }
        public string User { get; set; }
        public DateTime TimeStamp { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
