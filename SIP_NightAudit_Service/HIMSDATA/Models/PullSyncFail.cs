using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class PullSyncFail
    {
        public int Id { get; set; }
        public long? ItemId { get; set; }
        public string DataTable { get; set; }
    }
}
