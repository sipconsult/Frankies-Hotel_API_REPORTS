using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class CrmLink
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string MemberNo { get; set; }
        public string ClientType { get; set; }
        public string LinkedBy { get; set; }
    }
}
