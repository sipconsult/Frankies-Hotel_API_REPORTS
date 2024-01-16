using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class DiagnosisView
    {
        public int DiagnosisId { get; set; }
        public string DiagnosisName { get; set; }
        public string DiagnosisCode { get; set; }
        public int? DcategoryId { get; set; }
        public string UserId { get; set; }
        public short Active { get; set; }
        public DateTime? LastDateModified { get; set; }
        public string CategoryName { get; set; }
        public string ActiveString { get; set; }
    }
}
