using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Member
    {
        public long MemberId { get; set; }
        public int? ClientId { get; set; }
        public string PolicyNo { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? Dob { get; set; }
        public string PhoneNumber { get; set; }
        public string MarriageStatus { get; set; }
        public int NationalityId { get; set; }
        public string ChronicDiseases { get; set; }
        public int? ProductId { get; set; }
        public short? AgeStatusId { get; set; }
        public short Active { get; set; }
        public short GenderId { get; set; }
        public DateTime? TermDate { get; set; }
        public string StaffId { get; set; }
        public string PersonalEmail { get; set; }
        public string BusinessEmail { get; set; }
        public string PictureUrl { get; set; }
        public string Sign { get; set; }
        public string Address { get; set; }
        public byte? MemberType { get; set; }
        public long? MainMemberId { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
