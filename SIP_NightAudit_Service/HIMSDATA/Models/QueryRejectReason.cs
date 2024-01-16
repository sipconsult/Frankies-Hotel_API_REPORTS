using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class QueryRejectReason
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Ranking { get; set; }
        public string AdjudicationArea { get; set; }
    }
}
