using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class MemberPrinting
    {
        public int PrintingId { get; set; }
        public int? MemberId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DatePrinted { get; set; }
        public byte? PrintingStatus { get; set; }
        public string FullName { get; set; }
    }
}
