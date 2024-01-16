using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class ComplaintView
    {
        public string CategoryName { get; set; }
        public long ComplaintId { get; set; }
        public DateTime ComplaintDate { get; set; }
        public int ComplaintCategoryId { get; set; }
        public short? ComplaintStatus { get; set; }
        public string ClientName { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public DateTime? ResolveDate { get; set; }
        public string ComplaintDescription { get; set; }
        public string ResolveDescription { get; set; }
        public int ClientId { get; set; }
        public long? MemberId { get; set; }
        public int? Expr1 { get; set; }
        public long? Expr2 { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }
    }
}
