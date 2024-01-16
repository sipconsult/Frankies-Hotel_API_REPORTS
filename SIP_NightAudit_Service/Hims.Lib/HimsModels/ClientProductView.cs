using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ClientProductView
    {
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public int ProductItemId { get; set; }
        public decimal? Amount { get; set; }
        public string UserId { get; set; }
        public string ProductName { get; set; }
        public string ClientName { get; set; }
        public string ProductItemName { get; set; }
    }
}
