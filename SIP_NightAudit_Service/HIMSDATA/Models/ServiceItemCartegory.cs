using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class ServiceItemCartegory
    {
        public int Id { get; set; }
        public string CartegoryName { get; set; }
        public string CartegoryCode { get; set; }
        public string GeneralCartegoryCode { get; set; }
    }
}
