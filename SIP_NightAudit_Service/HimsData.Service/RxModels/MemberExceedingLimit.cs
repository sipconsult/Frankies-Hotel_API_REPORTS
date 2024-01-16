using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class MemberExceedingLimit
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public string MemberPlanId { get; set; }
        public string Employer { get; set; }
        public string EmployerId { get; set; }
        public string Limit { get; set; }
        public string LimitPercentage { get; set; }
        public string Utilized { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Othername { get; set; }
        public string Type { get; set; }
        public string MemberId { get; set; }
        public string MemberTableId { get; set; }
    }
}
