using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class AnnualInvoice
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string MemberId { get; set; }
        public int? M { get; set; }
        public int? S { get; set; }
        public int? C { get; set; }
        public int? OA { get; set; }
        public string Plan { get; set; }
        public decimal? Total { get; set; }
        public DateTime? JoinDate { get; set; }
        public decimal? Ntotal { get; set; }
        public double? Percent { get; set; }
        public decimal? Difference { get; set; }
        public string MemName { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
