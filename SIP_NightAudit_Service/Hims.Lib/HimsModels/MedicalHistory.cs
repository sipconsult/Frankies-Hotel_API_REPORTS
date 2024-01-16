using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class MedicalHistory
    {
        public int MemberId { get; set; }
        public int DiagnosisId { get; set; }
        public string Comments { get; set; }
    }
}
