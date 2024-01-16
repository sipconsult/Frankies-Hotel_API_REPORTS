using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class PrintBatch
    {
        public int Id { get; set; }
        public string Batchno { get; set; }
        public int CountItems { get; set; }
        public string Status { get; set; }
    }
}
