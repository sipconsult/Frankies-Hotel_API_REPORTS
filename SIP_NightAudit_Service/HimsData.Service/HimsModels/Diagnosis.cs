using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Diagnosis
    {
        public int DiagnosisId { get; set; }
        public string DiagnosisName { get; set; }
        public string DiagnosisCode { get; set; }
        public int? DcategoryId { get; set; }
        public short Active { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }

        public virtual DiagnosisCategory Dcategory { get; set; }
    }
}
