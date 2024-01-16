using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class MemberPrintingView
    {
        public int PrintingId { get; set; }
        public long MemberId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DatePrinted { get; set; }
        public byte? PrintingStatus { get; set; }
        public string OriginalName { get; set; }
        public string FullName { get; set; }
        public string FullPolicyNo { get; set; }
        public string ClientName { get; set; }
        public int? ClientId { get; set; }
        public string Gender { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
