using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class StatusUpdateTable
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}
