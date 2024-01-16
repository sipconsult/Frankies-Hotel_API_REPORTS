using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ProductView
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ProductPrefix { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public string Active { get; set; }
        public string ActiveString { get; set; }
    }
}
