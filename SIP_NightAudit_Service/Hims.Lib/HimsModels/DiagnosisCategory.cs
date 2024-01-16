using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class DiagnosisCategory
    {
        public DiagnosisCategory()
        {
            Diagnoses = new HashSet<Diagnosis>();
        }

        public int DcategoryId { get; set; }
        public string CategoryName { get; set; }
        public byte Active { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }

        public virtual ICollection<Diagnosis> Diagnoses { get; set; }
    }
}
