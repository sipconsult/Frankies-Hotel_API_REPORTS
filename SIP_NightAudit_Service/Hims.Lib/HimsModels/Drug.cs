using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class Drug
    {
        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public string DrugCode { get; set; }
        public string DrugDescription { get; set; }
        public decimal? DefaultPrice { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public int? DrugCategoryId { get; set; }
        public string Active { get; set; }
    }
}
