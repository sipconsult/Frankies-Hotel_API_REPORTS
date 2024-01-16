using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class PatientInfo
    {
        public long Id { get; set; }
        public string InsCompany { get; set; }
        public string MemberNo { get; set; }
        public string ActualMemberNo { get; set; }
        public string MemberPlan { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Othernames { get; set; }
        public string Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string TelephoneNo { get; set; }
        public string Email { get; set; }
        public string Employer { get; set; }
        public string EmployerId { get; set; }
        public string EmployerType { get; set; }
        public int? CompanyId { get; set; }
        public string EmployerCode { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Status { get; set; }
        public string StatusReason { get; set; }
        public string CardPin { get; set; }
        public string MemberId { get; set; }
        public string RxMemberId { get; set; }
        public string NewRxId { get; set; }
        public string PrincipalId { get; set; }
        public string BankName { get; set; }
        public string Iban { get; set; }
        public string Picpath { get; set; }
        public string ArchiveStatus { get; set; }
        public string MemberImportId { get; set; }
        public string DecisionStatus { get; set; }
        public double? PhysiotherapyBalance { get; set; }
        public double? PsychologyBalance { get; set; }
        public string CardSerialNum { get; set; }
        public string MemberType { get; set; }
        public string RelationshipType { get; set; }
        public string InsertDeleteStatus { get; set; }
        public string MemberPlanId { get; set; }
        public string PaymentType { get; set; }
        public double? OutpatientLimit { get; set; }
        public double? InpatientLimit { get; set; }
        public double? OutpatientBalance { get; set; }
        public double? InpatientBalance { get; set; }
        public string OldMemberNo { get; set; }
        public double? OptBalance { get; set; }
        public double? DentalBalance { get; set; }
        public double? EntBalance { get; set; }
        public double? DrugBalance { get; set; }
        public double? LabBalance { get; set; }
        public double? RadBalance { get; set; }
        public double? PhysioBalance { get; set; }
        public double? AdmBalance { get; set; }
        public double? MaternityBalance { get; set; }
        public string BalanceType { get; set; }
        public int? FamilyNumber { get; set; }
        public int? PrimaryProviderId { get; set; }
        public string UsePrimaryId { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? BalanceStartDate { get; set; }
        public double? OpdBal { get; set; }
        public double? IpdBal { get; set; }
        public string Fullname { get; set; }
        public string HomeCountry { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Currency { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string InsertUser { get; set; }
        public string UpdateUser { get; set; }
        public string MemberPolicyId { get; set; }
        public string UpdateStatus { get; set; }
        public string ApprovedStatus { get; set; }
        public string Nhis { get; set; }
        public string StaffNo { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchNoDelete { get; set; }
        public byte? SyncInsert { get; set; }
        public byte? SyncUpdate { get; set; }
        public byte? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public int? SyncInsertCounts { get; set; }
        public int? SyncUpdateCounts { get; set; }
    }
}
