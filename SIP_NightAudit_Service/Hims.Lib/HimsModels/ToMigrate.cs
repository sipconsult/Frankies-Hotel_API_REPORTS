using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ToMigrate
    {
        public double? ClientId { get; set; }
        public string Plan { get; set; }
        public double? ProductId { get; set; }
        public string MemberNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string EmployersName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Nationality { get; set; }
        public string Branch { get; set; }
        public string Position { get; set; }
        public string PostalAddress { get; set; }
        public double? TelNo { get; set; }
        public string ResAddress { get; set; }
        public string Gender { get; set; }
        public string Pmsp { get; set; }
        public double? MedicalHistory { get; set; }
        public string Relationship { get; set; }
        public string MainMember { get; set; }
        public string F23 { get; set; }
        public string F24 { get; set; }
        public int? DependantType { get; set; }
        public string PolicyNo { get; set; }
        public int? MainMemberId { get; set; }
    }
}
