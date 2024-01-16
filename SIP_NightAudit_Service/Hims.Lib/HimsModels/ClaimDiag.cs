using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ClaimDiag
    {
        public long ClaimId { get; set; }
        public int DiagnosisId { get; set; }
        public string Diagnosis { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
