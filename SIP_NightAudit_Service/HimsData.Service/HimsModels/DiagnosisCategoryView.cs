using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class DiagnosisCategoryView
    {
        public int DcategoryId { get; set; }
        public string CategoryName { get; set; }
        public byte Active { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public string ActiveString { get; set; }
    }
}
