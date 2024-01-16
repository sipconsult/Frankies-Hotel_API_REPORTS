using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Hims.Lib.RxModels
{
    public partial class RxDBContext : DbContext
    {
        public RxDBContext()
        {
        }

        public RxDBContext(DbContextOptions<RxDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClaimsDetail> ClaimsDetails { get; set; }
        public virtual DbSet<CompanyPlan> CompanyPlans { get; set; }
        public virtual DbSet<RxBenefit> RxBenefits { get; set; }
        public virtual DbSet<RxBenefitGroup> RxBenefitGroups { get; set; }
        public virtual DbSet<RxCompanyBenefit> RxCompanyBenefits { get; set; }
        public virtual DbSet<RxCompanyBenefitGroup> RxCompanyBenefitGroups { get; set; }
        public virtual DbSet<RxMemberBenefit> RxMemberBenefits { get; set; }
        public virtual DbSet<RxMemberBenefitGroup> RxMemberBenefitGroups { get; set; }
        public virtual DbSet<RxPlanBenefit> RxPlanBenefits { get; set; }
        public virtual DbSet<RxPlanBenefitGroup> RxPlanBenefitGroups { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySQL("Server=localhost;Database=rxdb;User Id=root; password=Admin@123;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClaimsDetail>(entity =>
            {
                entity.ToTable("claims_details");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.ProviderIdDataFor, e.AuditStatus, e.DecisionStatus }, "audit_status");

                entity.HasIndex(e => new { e.ProviderDataId, e.InsCompany, e.ProviderId, e.MemberNo, e.ProcessClaimNo }, "claim_data_key")
                    .IsUnique();

                entity.HasIndex(e => new { e.DateAddedShort, e.ProcessClaimNo }, "date_added_short");

                entity.HasIndex(e => e.DateOfConsultation, "date_of_consultation");

                entity.HasIndex(e => e.EmployerId, "employer_id");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.ProviderIdDataFor }, "ins_company");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation, e.DecisionStatus, e.AuditStatus }, "ins_company_10");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation, e.DecisionStatus, e.FinanceAuditStatus }, "ins_company_11");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo, e.NatureOfVisit, e.DateOfConsultation }, "ins_company_12");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo, e.DateOfConsultation, e.ItemService }, "ins_company_13");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.ProcessClaimNo }, "ins_company_2");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.DelStatus, e.ProviderIdDataFor, e.AuditStatus }, "ins_company_3");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo, e.TypeOfVisit, e.DateOfConsultation }, "ins_company_5");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo }, "ins_company_6");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId }, "ins_company_7");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation }, "ins_company_8");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation, e.AuditStatus }, "ins_company_9");

                entity.HasIndex(e => e.InsItemCode, "ins_item_code");

                entity.HasIndex(e => e.Item, "item");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.HasIndex(e => new { e.MemberNo, e.TypeOfVisit, e.InsCompany, e.DateOfConsultation }, "member_no_2");

                entity.HasIndex(e => new { e.MemberNo, e.ClaimType }, "member_no_3");

                entity.HasIndex(e => new { e.ProcessClaimNo, e.DelStatus }, "process_claim_no");

                entity.HasIndex(e => e.ProcessClaimNo, "process_claim_no_2");

                entity.HasIndex(e => e.ProviderId, "provider_id");

                entity.HasIndex(e => e.ProviderIdDataFor, "provider_id_data_for");

                entity.HasIndex(e => e.ServerId, "server_id");

                entity.HasIndex(e => e.TypeOfVisit, "type_of_visit");

                entity.HasIndex(e => new { e.TypeOfVisit, e.NatureOfVisit }, "type_of_visit_2");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ActionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("action_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApproveBalance)
                    .HasMaxLength(50)
                    .HasColumnName("approve_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApprovedQueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("approved_query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .HasColumnName("attending_officer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditStatus)
                    .HasMaxLength(20)
                    .HasColumnName("audit_status")
                    .HasDefaultValueSql("'''pending'''");

                entity.Property(e => e.AuditUpdate)
                    .HasMaxLength(10)
                    .HasColumnName("audit_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("audit_user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("audited_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationCode)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(10)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Awarded)
                    .HasColumnName("awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BookingNo)
                    .HasMaxLength(255)
                    .HasColumnName("booking_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(20)
                    .HasColumnName("claim_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClaimTypeRe)
                    .HasMaxLength(50)
                    .HasColumnName("claim_type_re")
                    .HasDefaultValueSql("'''Normal'''");

                entity.Property(e => e.ClaimsDetailsId)
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasColumnName("claims_details_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CoPaymentAmount)
                    .HasColumnType("double(3,0)")
                    .HasColumnName("co_payment_amount")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CoPaymentPercent)
                    .HasColumnType("double(3,0)")
                    .HasColumnName("co_payment_percent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .HasColumnName("company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrencyOriginalRate)
                    .HasColumnType("double(255,3)")
                    .HasColumnName("currency_original_rate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrencyRateDate)
                    .HasColumnType("date")
                    .HasColumnName("currency_rate_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrencyUsdRate)
                    .HasColumnType("double(255,3)")
                    .HasColumnName("currency_usd_rate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrentLocation)
                    .HasMaxLength(100)
                    .HasColumnName("current_location")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAddedShort)
                    .HasColumnType("date")
                    .HasColumnName("date_added_short")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfActualConsultation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_actual_consultation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfAdmission)
                    .HasColumnType("date")
                    .HasColumnName("date_of_admission")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfConsultation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_consultation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfDischarge)
                    .HasColumnType("date")
                    .HasColumnName("date_of_discharge")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReason)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReasonOther)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason_other")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DelStatus)
                    .HasMaxLength(20)
                    .HasColumnName("del_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Diagnosis)
                    .HasColumnType("longtext")
                    .HasColumnName("diagnosis")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiagnosisCode)
                    .HasMaxLength(255)
                    .HasColumnName("diagnosis_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiscAmount)
                    .HasColumnType("double(3,0)")
                    .HasColumnName("disc_amount")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiscPercent)
                    .HasColumnType("double(3,0)")
                    .HasColumnName("disc_percent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(10)
                    .HasColumnName("dosage_form")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Dose)
                    .HasColumnName("dose")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerCode)
                    .HasMaxLength(10)
                    .HasColumnName("employer_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(20)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EyeOptical)
                    .HasMaxLength(20)
                    .HasColumnName("eye_optical")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceAuditStatus)
                    .HasMaxLength(50)
                    .HasColumnName("finance_audit_status")
                    .HasDefaultValueSql("'''pending'''");

                entity.Property(e => e.FinanceAuditUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("finance_audit_user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceAuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("finance_audited_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceDecisionReason)
                    .HasMaxLength(50)
                    .HasColumnName("finance_decision_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceDecisionReasonOther)
                    .HasMaxLength(50)
                    .HasColumnName("finance_decision_reason_other")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceDecisionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("finance_decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinancialStatus)
                    .HasMaxLength(10)
                    .HasColumnName("financial_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(10)
                    .HasColumnName("frequency")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IcdCode)
                    .HasMaxLength(10)
                    .HasColumnName("icd_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(100)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(100)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IsDisputed)
                    .HasMaxLength(10)
                    .HasColumnName("is_disputed")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(255)
                    .HasColumnName("item_class")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemDaysDiff)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_days_diff")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemService)
                    .HasMaxLength(255)
                    .HasColumnName("item_service")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemServiceType)
                    .HasMaxLength(255)
                    .HasColumnName("item_service_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NatureOfVisit)
                    .HasMaxLength(50)
                    .HasColumnName("nature_of_visit")
                    .HasDefaultValueSql("'''General'''");

                entity.Property(e => e.NatureofvisitLimit)
                    .HasMaxLength(100)
                    .HasColumnName("natureofvisit_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_days")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(20)
                    .HasColumnName("payment_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(20)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyExpectedDelivery)
                    .HasColumnType("date")
                    .HasColumnName("pregnancy_expected_delivery")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyStatus)
                    .HasMaxLength(20)
                    .HasColumnName("pregnancy_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyWeeks)
                    .HasMaxLength(5)
                    .HasColumnName("pregnancy_weeks")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PriceCurrency)
                    .HasMaxLength(10)
                    .HasColumnName("price_currency")
                    .HasDefaultValueSql("'''GHS'''");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataFor)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataForText)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_data_for_text")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderItemId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderNameDataFor)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderRefNo)
                    .HasMaxLength(255)
                    .HasColumnName("provider_ref_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyAwarded)
                    .HasColumnName("qty_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyFinance)
                    .HasColumnName("qty_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReferToAuditor)
                    .HasMaxLength(10)
                    .HasColumnName("refer_to_auditor")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReferralNo)
                    .HasMaxLength(255)
                    .HasColumnName("referral_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBrandName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_brand_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCartegory)
                    .HasMaxLength(255)
                    .HasColumnName("rx_cartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxMemberId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rx_member_id");

                entity.Property(e => e.RxPrescriptionName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_prescription_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("bigint(255)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerPushStatus)
                    .HasMaxLength(10)
                    .HasColumnName("server_push_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServiceSpeciality)
                    .HasMaxLength(100)
                    .HasColumnName("service_speciality")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SmsSent)
                    .HasMaxLength(20)
                    .HasColumnName("sms_sent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubmittedStatus)
                    .HasMaxLength(10)
                    .HasColumnName("submitted_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Supplied)
                    .HasMaxLength(10)
                    .HasColumnName("supplied")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Toothnos)
                    .HasMaxLength(255)
                    .HasColumnName("toothnos")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TopupAmt)
                    .HasColumnName("topup_amt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("total_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfVisit)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_visit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeofvisitLimit)
                    .HasMaxLength(100)
                    .HasColumnName("typeofvisit_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceAwarded)
                    .HasColumnName("unit_price_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceFinance)
                    .HasColumnName("unit_price_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UpdateDeleteStatus)
                    .HasMaxLength(50)
                    .HasColumnName("update_delete_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UpdateStatus)
                    .HasMaxLength(50)
                    .HasColumnName("update_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("longtext")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationKey)
                    .HasMaxLength(50)
                    .HasColumnName("validation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationPin)
                    .HasMaxLength(50)
                    .HasColumnName("validation_pin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Visittype)
                    .HasMaxLength(100)
                    .HasColumnName("visittype")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<CompanyPlan>(entity =>
            {
                entity.ToTable("company_plan");

                entity.HasIndex(e => new { e.Company, e.Plan }, "Company")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApplicableYear)
                    .HasMaxLength(255)
                    .HasColumnName("Applicable_year")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasMaxLength(10)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DentalLimit)
                    .HasColumnName("dental_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DrugLimit)
                    .HasColumnName("drug_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EntLimit)
                    .HasColumnName("ent_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit)
                    .HasColumnName("inpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit1)
                    .HasColumnName("inpatient_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit2)
                    .HasColumnName("inpatient_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit3)
                    .HasColumnName("inpatient_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit4)
                    .HasColumnName("inpatient_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit5)
                    .HasColumnName("inpatient_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimitPercentage)
                    .HasColumnName("inpatient_limit_percentage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabLimit)
                    .HasColumnName("lab_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit)
                    .HasColumnName("maternity_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit1)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("maternity_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit2)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("maternity_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit3)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("maternity_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit4)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("maternity_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit5)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("maternity_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OpticalLimit)
                    .HasColumnName("optical_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit)
                    .HasColumnName("outpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit1)
                    .HasColumnName("outpatient_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit2)
                    .HasColumnName("outpatient_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit3)
                    .HasColumnName("outpatient_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit4)
                    .HasColumnName("outpatient_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit5)
                    .HasColumnName("outpatient_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimitPercentage)
                    .HasColumnName("outpatient_limit_percentage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PhysiotherapyLimit)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("physiotherapy_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Plan)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasMaxLength(255)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PsychologyLimit)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("psychology_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RadLimit)
                    .HasColumnName("rad_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RedInpatientLimit)
                    .HasColumnName("red_inpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RedOutpatientLimit)
                    .HasColumnName("red_outpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StatusUpdateTime)
                    .HasColumnType("date")
                    .HasColumnName("status_update_time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TableType)
                    .HasMaxLength(30)
                    .HasColumnName("table_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.YellowInpatientLimit)
                    .HasColumnName("yellow_inpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.YellowOutpatientLimit)
                    .HasColumnName("yellow_outpatient_limit")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxBenefit>(entity =>
            {
                entity.ToTable("rx_benefits");

                entity.HasIndex(e => new { e.BenefitGroupId, e.RxAreaCode, e.VisitType, e.InsCompany, e.RxArea }, "unique_plan_benefit")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit1)
                    .HasColumnName("amount_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit2)
                    .HasColumnName("amount_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit3)
                    .HasColumnName("amount_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit4)
                    .HasColumnName("amount_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit5)
                    .HasColumnName("amount_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmtLimit)
                    .HasColumnName("amt_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApplicableArea)
                    .HasMaxLength(20)
                    .HasColumnName("applicable_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration1)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration2)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration3)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration4)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration5)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag1)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag2)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag3)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag4)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag5)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdFromInsCompany)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_from_ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatus)
                    .HasMaxLength(10)
                    .HasColumnName("item_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatusMeaning)
                    .HasColumnName("item_status_meaning")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_days")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimesStrict)
                    .HasMaxLength(10)
                    .HasColumnName("no_of_times_strict")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits1)
                    .HasColumnName("no_of_units1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits2)
                    .HasColumnName("no_of_units2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits3)
                    .HasColumnName("no_of_units3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits4)
                    .HasColumnName("no_of_units4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits5)
                    .HasColumnName("no_of_units5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pregnancy)
                    .HasMaxLength(10)
                    .HasColumnName("pregnancy")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RepeatMode)
                    .HasMaxLength(5)
                    .HasColumnName("repeat_mode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxArea)
                    .HasMaxLength(20)
                    .HasColumnName("rx_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxAreaCode)
                    .HasMaxLength(50)
                    .HasColumnName("rx_area_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCode)
                    .HasMaxLength(20)
                    .HasColumnName("rx_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemId)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxPaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("rx_payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(10)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxBenefitGroup>(entity =>
            {
                entity.ToTable("rx_benefit_groups");

                entity.HasIndex(e => e.InsCompany, "ins_company");

                entity.HasIndex(e => new { e.InsCompany, e.Name, e.VisitType }, "unique_group")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GroupStatus)
                    .HasMaxLength(5)
                    .HasColumnName("group_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdFromInsCompany)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_from_ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount1)
                    .HasColumnName("limit_amount1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount2)
                    .HasColumnName("limit_amount2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount3)
                    .HasColumnName("limit_amount3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount4)
                    .HasColumnName("limit_amount4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount5)
                    .HasColumnName("limit_amount5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage1)
                    .HasColumnName("percentage1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage2)
                    .HasColumnName("percentage2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage3)
                    .HasColumnName("percentage3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage4)
                    .HasColumnName("percentage4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage5)
                    .HasColumnName("percentage5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBenefitGroupCode)
                    .HasMaxLength(25)
                    .HasColumnName("rx_benefit_group_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShowGroupLimit)
                    .HasMaxLength(10)
                    .HasColumnName("show_group_limit")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(5)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxCompanyBenefit>(entity =>
            {
                entity.ToTable("rx_company_benefits");

                entity.HasIndex(e => new { e.InsCompany, e.PlanId, e.CompanyId, e.BenefitGroupId, e.RxArea, e.RxAreaCode, e.VisitType }, "unique_company_benefits")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit1)
                    .HasColumnName("amount_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit2)
                    .HasColumnName("amount_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit3)
                    .HasColumnName("amount_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit4)
                    .HasColumnName("amount_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit5)
                    .HasColumnName("amount_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApplicableArea)
                    .HasMaxLength(20)
                    .HasColumnName("applicable_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration1)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration2)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration3)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration4)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration5)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag1)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag2)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag3)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag4)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag5)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatusMeaning)
                    .HasColumnName("item_status_meaning")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits1)
                    .HasColumnName("no_of_units1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits2)
                    .HasColumnName("no_of_units2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits3)
                    .HasColumnName("no_of_units3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits4)
                    .HasColumnName("no_of_units4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits5)
                    .HasColumnName("no_of_units5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pregnancy)
                    .HasMaxLength(10)
                    .HasColumnName("pregnancy")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RepeatMode)
                    .HasMaxLength(5)
                    .HasColumnName("repeat_mode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxArea)
                    .HasMaxLength(20)
                    .HasColumnName("rx_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxAreaCode)
                    .HasMaxLength(50)
                    .HasColumnName("rx_area_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCode)
                    .HasMaxLength(20)
                    .HasColumnName("rx_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemId)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxPaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("rx_payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(10)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxCompanyBenefitGroup>(entity =>
            {
                entity.ToTable("rx_company_benefit_groups");

                entity.HasIndex(e => new { e.InsCompany, e.PlanId, e.CompanyId, e.BenefitGroupId, e.Name, e.VisitType }, "unique_company_benefits_group")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GroupStatus)
                    .HasMaxLength(5)
                    .HasColumnName("group_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount1)
                    .HasColumnName("limit_amount1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount2)
                    .HasColumnName("limit_amount2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount3)
                    .HasColumnName("limit_amount3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount4)
                    .HasColumnName("limit_amount4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount5)
                    .HasColumnName("limit_amount5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage1)
                    .HasColumnName("percentage1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage2)
                    .HasColumnName("percentage2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage3)
                    .HasColumnName("percentage3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage4)
                    .HasColumnName("percentage4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage5)
                    .HasColumnName("percentage5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBenefitGroupCode)
                    .HasMaxLength(25)
                    .HasColumnName("rx_benefit_group_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShowGroupLimit)
                    .HasMaxLength(10)
                    .HasColumnName("show_group_limit")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(5)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxMemberBenefit>(entity =>
            {
                entity.ToTable("rx_member_benefits");

                entity.HasIndex(e => new { e.InsCompany, e.PlanId, e.CompanyId, e.BenefitGroupId, e.RxArea, e.VisitType, e.RxAreaCode, e.MemberNo }, "unique_member_benefit")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit1)
                    .HasColumnName("amount_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit2)
                    .HasColumnName("amount_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit3)
                    .HasColumnName("amount_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit4)
                    .HasColumnName("amount_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit5)
                    .HasColumnName("amount_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApplicableArea)
                    .HasMaxLength(20)
                    .HasColumnName("applicable_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration1)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration2)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration3)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration4)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration5)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag1)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag2)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag3)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag4)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag5)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatusMeaning)
                    .HasColumnName("item_status_meaning")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(20)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits1)
                    .HasColumnName("no_of_units1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits2)
                    .HasColumnName("no_of_units2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits3)
                    .HasColumnName("no_of_units3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits4)
                    .HasColumnName("no_of_units4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits5)
                    .HasColumnName("no_of_units5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pregnancy)
                    .HasMaxLength(10)
                    .HasColumnName("pregnancy")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RepeatMode)
                    .HasMaxLength(5)
                    .HasColumnName("repeat_mode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxArea)
                    .HasMaxLength(20)
                    .HasColumnName("rx_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxAreaCode)
                    .HasMaxLength(50)
                    .HasColumnName("rx_area_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCode)
                    .HasMaxLength(20)
                    .HasColumnName("rx_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemId)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxPaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("rx_payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(10)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxMemberBenefitGroup>(entity =>
            {
                entity.ToTable("rx_member_benefit_groups");

                entity.HasIndex(e => new { e.InsCompany, e.PlanId, e.CompanyId, e.BenefitGroupId, e.Name, e.MemberNo, e.VisitType }, "unique_member_benefits")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GroupStatus)
                    .HasMaxLength(5)
                    .HasColumnName("group_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount1)
                    .HasColumnName("limit_amount1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount2)
                    .HasColumnName("limit_amount2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount3)
                    .HasColumnName("limit_amount3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount4)
                    .HasColumnName("limit_amount4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount5)
                    .HasColumnName("limit_amount5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(20)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage1)
                    .HasColumnName("percentage1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage2)
                    .HasColumnName("percentage2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage3)
                    .HasColumnName("percentage3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage4)
                    .HasColumnName("percentage4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage5)
                    .HasColumnName("percentage5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBenefitGroupCode)
                    .HasMaxLength(25)
                    .HasColumnName("rx_benefit_group_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShowGroupLimit)
                    .HasMaxLength(10)
                    .HasColumnName("show_group_limit")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(5)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxPlanBenefit>(entity =>
            {
                entity.ToTable("rx_plan_benefits");

                entity.HasIndex(e => new { e.PlanId, e.BenefitGroupId, e.RxAreaCode, e.InsCompany, e.VisitType, e.RxArea }, "unique_plan_benefit")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit1)
                    .HasColumnName("amount_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit2)
                    .HasColumnName("amount_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit3)
                    .HasColumnName("amount_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit4)
                    .HasColumnName("amount_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit5)
                    .HasColumnName("amount_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApplicableArea)
                    .HasMaxLength(20)
                    .HasColumnName("applicable_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration1)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration2)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration3)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration4)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration5)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag1)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag2)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag3)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag4)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag5)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdFromInsCompany)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_from_ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatusMeaning)
                    .HasColumnName("item_status_meaning")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits1)
                    .HasColumnName("no_of_units1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits2)
                    .HasColumnName("no_of_units2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits3)
                    .HasColumnName("no_of_units3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits4)
                    .HasColumnName("no_of_units4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits5)
                    .HasColumnName("no_of_units5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(100)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pregnancy)
                    .HasMaxLength(10)
                    .HasColumnName("pregnancy")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RepeatMode)
                    .HasMaxLength(5)
                    .HasColumnName("repeat_mode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxArea)
                    .HasMaxLength(20)
                    .HasColumnName("rx_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxAreaCode)
                    .HasMaxLength(50)
                    .HasColumnName("rx_area_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCode)
                    .HasMaxLength(20)
                    .HasColumnName("rx_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemId)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxPaymentType)
                    .HasMaxLength(20)
                    .HasColumnName("rx_payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TableType)
                    .HasMaxLength(30)
                    .HasColumnName("table_type")
                    .HasDefaultValueSql("'''rx_plan_benefits'''");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(10)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxPlanBenefitGroup>(entity =>
            {
                entity.ToTable("rx_plan_benefit_groups");

                entity.HasIndex(e => new { e.InsCompany, e.PlanId, e.BenefitGroupId, e.Name, e.VisitType }, "ins_company");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GroupStatus)
                    .HasMaxLength(5)
                    .HasColumnName("group_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount1)
                    .HasColumnName("limit_amount1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount2)
                    .HasColumnName("limit_amount2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount3)
                    .HasColumnName("limit_amount3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount4)
                    .HasColumnName("limit_amount4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount5)
                    .HasColumnName("limit_amount5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage1)
                    .HasColumnName("percentage1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage2)
                    .HasColumnName("percentage2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage3)
                    .HasColumnName("percentage3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage4)
                    .HasColumnName("percentage4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage5)
                    .HasColumnName("percentage5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBenefitGroupCode)
                    .HasMaxLength(25)
                    .HasColumnName("rx_benefit_group_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShowGroupLimit)
                    .HasMaxLength(10)
                    .HasColumnName("show_group_limit")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(5)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
