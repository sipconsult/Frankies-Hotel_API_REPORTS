using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class NewMember
    {
        public double? Id { get; set; }
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
        public int? PlanId { get; set; }
        public int? GenderId { get; set; }
        public int? MemberTypeId { get; set; }
        public string EmployerType { get; set; }
        public string CompanyId { get; set; }
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
        public DateTime? RegistrationDate { get; set; }
        public string PhysiotherapyBalance { get; set; }
        public string PsychologyBalance { get; set; }
        public string CardSerialNum { get; set; }
        public string MemberType { get; set; }
        public string RelationshipType { get; set; }
        public string InsertDeleteStatus { get; set; }
        public string MemberPlanId { get; set; }
        public string PaymentType { get; set; }
        public string OutpatientLimit { get; set; }
        public string InpatientLimit { get; set; }
        public string OutpatientBalance { get; set; }
        public string InpatientBalance { get; set; }
        public string OldMemberNo { get; set; }
        public string OptBalance { get; set; }
        public string DentalBalance { get; set; }
        public string EntBalance { get; set; }
        public string DrugBalance { get; set; }
        public string LabBalance { get; set; }
        public string RadBalance { get; set; }
        public string PhysioBalance { get; set; }
        public string AdmBalance { get; set; }
        public string MaternityBalance { get; set; }
        public string BalanceType { get; set; }
        public string FamilyNumber { get; set; }
        public string PrimaryProviderId { get; set; }
        public string UsePrimaryId { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? BalanceStartDate { get; set; }
        public string OpdBal { get; set; }
        public string IpdBal { get; set; }
        public string Fullname { get; set; }
        public string HomeCountry { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Currency { get; set; }
        public string DateAdded { get; set; }
        public string DateUpdated { get; set; }
        public string InsertUser { get; set; }
        public string UpdateUser { get; set; }
        public string MemberPolicyId { get; set; }
        public string UpdateStatus { get; set; }
        public string ApprovedStatus { get; set; }
        public DateTime? StatusUpdateTime { get; set; }
        public string Nhis { get; set; }
        public string StaffNo { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchNoDelete { get; set; }
        public double? SyncInsert { get; set; }
        public double? SyncUpdate { get; set; }
        public double? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public double? SyncInsertCounts { get; set; }
        public double? SyncUpdateCounts { get; set; }
    }
}
