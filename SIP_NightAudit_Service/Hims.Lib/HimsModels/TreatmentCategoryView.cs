using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class TreatmentCategoryView
    {
        public short CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public byte Active { get; set; }
        public string ActiveString { get; set; }
    }
}
