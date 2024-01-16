using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ProvidersProduct
    {
        public int ProductId { get; set; }
        public int ProviderId { get; set; }
        public string UserId { get; set; }
        public DateTime LastDateModified { get; set; }
    }
}
