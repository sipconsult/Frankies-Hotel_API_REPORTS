using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ClaimTreatment
    {
        public long ClaimId { get; set; }
        public int TreatmentId { get; set; }
        public string Treatment { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal? SuspendedAmount { get; set; }
        public decimal? RejectedAmount { get; set; }
        public string ReasonForRejection { get; set; }
        public int? ClientBenefits { get; set; }
    }
}
