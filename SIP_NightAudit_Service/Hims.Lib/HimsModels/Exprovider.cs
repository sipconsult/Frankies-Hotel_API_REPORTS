using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class Exprovider
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? ProviderId { get; set; }
        public DateTime? Date { get; set; }
        public string UserId { get; set; }
        public DateTime LastDateModified { get; set; }
    }
}
