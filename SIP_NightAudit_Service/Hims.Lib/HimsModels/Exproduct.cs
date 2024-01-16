using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class Exproduct
    {
        public int RecordId { get; set; }
        public string Product { get; set; }
        public string ProviderId { get; set; }
        public DateTime? Date { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
