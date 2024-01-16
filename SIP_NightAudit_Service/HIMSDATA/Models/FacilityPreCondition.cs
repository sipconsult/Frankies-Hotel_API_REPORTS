using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class FacilityPreCondition
    {
        public int Id { get; set; }
        public int? FacilityId { get; set; }
        public string Condition { get; set; }
    }
}
