using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class CompanyDetail
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FaxNo { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string VatRegNo { get; set; }
        public string CompanySsfNo { get; set; }
        public string Website { get; set; }
        public string UserId { get; set; }
        public short? Version { get; set; }
        public byte? SystemVetting { get; set; }
        public byte? UseSymptom { get; set; }
        public byte? SuspendedAmount { get; set; }
        public byte? RejectedAmount { get; set; }
        public byte? Reconciliation { get; set; }
        public byte? BusinessLead { get; set; }
        public DateTime? LastDateModified { get; set; }
        public string Logo { get; set; }
        public short? NoCharactersPolicyNoMember { get; set; }
        public short? NoCharactersPolicyNoDependant { get; set; }
    }
}
