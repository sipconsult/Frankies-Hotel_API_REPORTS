using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ClientTypeView
    {
        public int ClientTypeId { get; set; }
        public string ClientTypeName { get; set; }
        public string Active { get; set; }
        public string ActiveString { get; set; }
    }
}
