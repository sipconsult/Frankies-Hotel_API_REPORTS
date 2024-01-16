using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class MemberStatusLog
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? MemberId { get; set; }
        public string MemberNo { get; set; }
        public string Status { get; set; }
        public string UserFullname { get; set; }
        public string Reason { get; set; }
    }
}
