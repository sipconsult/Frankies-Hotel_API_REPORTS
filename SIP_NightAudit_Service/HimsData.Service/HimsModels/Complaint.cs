using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Complaint
    {
        public long ComplaintId { get; set; }
        public int ClientId { get; set; }
        public long? MemberId { get; set; }
        public int? ProviderId { get; set; }
        public DateTime ComplaintDate { get; set; }
        public int ComplaintCategoryId { get; set; }
        public string ComplaintDescription { get; set; }
        public string ComplainantName { get; set; }
        public string ComplainantPhoneNumber { get; set; }
        public string Duration { get; set; }
        public string Response { get; set; }
        public string ProcedureType { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public bool? FollowUp { get; set; }
        public string LoggedBy { get; set; }
        public string ResolvedBy { get; set; }
        public DateTime? ResolveDate { get; set; }
        public string ResolveDescription { get; set; }
        public short? ComplaintStatus { get; set; }
        public bool? Active { get; set; }

        public virtual ComplaintCategory ComplaintCategory { get; set; }
    }
}
