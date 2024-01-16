using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class Treatment
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short TypeTreatment { get; set; }
        public short? CategoryId { get; set; }
        public decimal? DefaultMinPrice { get; set; }
        public decimal? DefaultMaxPrice { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public byte? Active { get; set; }
    }
}
