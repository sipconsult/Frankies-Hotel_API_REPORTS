using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class HimsDBContext : DbContext
    {
        public HimsDBContext()
        {
        }

        public HimsDBContext(DbContextOptions<HimsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountTransaction> AccountTransactions { get; set; }
        public virtual DbSet<AgeStatus> AgeStatuses { get; set; }
        public virtual DbSet<AnnualInvoice> AnnualInvoices { get; set; }
        public virtual DbSet<ApplicationReport> ApplicationReports { get; set; }
        public virtual DbSet<Balance> Balances { get; set; }
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<BatchView> BatchViews { get; set; }
        public virtual DbSet<BatchViewDetailed> BatchViewDetaileds { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Claim> Claims { get; set; }
        public virtual DbSet<ClaimDiag> ClaimDiags { get; set; }
        public virtual DbSet<ClaimSymptom> ClaimSymptoms { get; set; }
        public virtual DbSet<ClaimTreatment> ClaimTreatments { get; set; }
        public virtual DbSet<ClaimType> ClaimTypes { get; set; }
        public virtual DbSet<ClaimView> ClaimViews { get; set; }
        public virtual DbSet<ClaimsDetail> ClaimsDetails { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientContact> ClientContacts { get; set; }
        public virtual DbSet<ClientProduct> ClientProducts { get; set; }
        public virtual DbSet<ClientProductView> ClientProductViews { get; set; }
        public virtual DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<ClientTypeView> ClientTypeViews { get; set; }
        public virtual DbSet<ClientView> ClientViews { get; set; }
        public virtual DbSet<CompanyDetail> CompanyDetails { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Diagnosis> Diagnoses { get; set; }
        public virtual DbSet<DiagnosisCategory> DiagnosisCategories { get; set; }
        public virtual DbSet<DiagnosisCategoryView> DiagnosisCategoryViews { get; set; }
        public virtual DbSet<DiagnosisView> DiagnosisViews { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<DrugCategory> DrugCategories { get; set; }
        public virtual DbSet<DrugForm> DrugForms { get; set; }
        public virtual DbSet<Exproduct> Exproducts { get; set; }
        public virtual DbSet<Exprovider> Exproviders { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Lead> Leads { get; set; }
        public virtual DbSet<LeadItem> LeadItems { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MedicalHistory> MedicalHistories { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberPrinting> MemberPrintings { get; set; }
        public virtual DbSet<MemberPrintingView> MemberPrintingViews { get; set; }
        public virtual DbSet<MemberStatusHistory> MemberStatusHistories { get; set; }
        public virtual DbSet<MemberType> MemberTypes { get; set; }
        public virtual DbSet<MemberView> MemberViews { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<PreAuthorization> PreAuthorizations { get; set; }
        public virtual DbSet<PreAuthorizationView> PreAuthorizationViews { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductItem> ProductItems { get; set; }
        public virtual DbSet<ProductItemCategory> ProductItemCategories { get; set; }
        public virtual DbSet<ProductView> ProductViews { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<ProviderCategory> ProviderCategories { get; set; }
        public virtual DbSet<ProviderCategoryView> ProviderCategoryViews { get; set; }
        public virtual DbSet<ProviderType> ProviderTypes { get; set; }
        public virtual DbSet<ProviderView> ProviderViews { get; set; }
        public virtual DbSet<ProvidersProduct> ProvidersProducts { get; set; }
        public virtual DbSet<ReasonsForRejection> ReasonsForRejections { get; set; }
        public virtual DbSet<Reconciliation> Reconciliations { get; set; }
        public virtual DbSet<Refund> Refunds { get; set; }
        public virtual DbSet<RefundView> RefundViews { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<ScannerDetail> ScannerDetails { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<StaffCategory> StaffCategories { get; set; }
        public virtual DbSet<Symptom> Symptoms { get; set; }
        public virtual DbSet<SymptomsCategory> SymptomsCategories { get; set; }
        public virtual DbSet<TempAct> TempActs { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<ToMigrate> ToMigrates { get; set; }
        public virtual DbSet<Tpa> Tpas { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<TreatmentCategory> TreatmentCategories { get; set; }
        public virtual DbSet<TreatmentCategoryView> TreatmentCategoryViews { get; set; }
        public virtual DbSet<TreatmentCost> TreatmentCosts { get; set; }
        public virtual DbSet<TreatmentType> TreatmentTypes { get; set; }
        public virtual DbSet<TreatmentView> TreatmentViews { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
        public virtual DbSet<staff> staff { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-ROVQU4A;Database=HIMSDB;User Id=sa; password=password01;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AccountTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_AccountTransaction");

                entity.Property(e => e.ClientName).HasMaxLength(200);

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateTransaction).HasColumnType("datetime");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.ProviderName).HasMaxLength(200);

                entity.Property(e => e.UserId).HasMaxLength(250);

                entity.Property(e => e.VoucherNo).HasMaxLength(50);
            });

            modelBuilder.Entity<AgeStatus>(entity =>
            {
                entity.ToTable("AgeStatus");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AnnualInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AnnualInvoice");

                entity.Property(e => e.Client).HasMaxLength(1000);

                entity.Property(e => e.Difference).HasColumnType("money");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Join Date");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.MemName).HasMaxLength(100);

                entity.Property(e => e.MemberId)
                    .HasMaxLength(50)
                    .HasColumnName("MemberID");

                entity.Property(e => e.Ntotal)
                    .HasColumnType("money")
                    .HasColumnName("NTotal");

                entity.Property(e => e.OA).HasColumnName("O/A");

                entity.Property(e => e.Plan).HasMaxLength(50);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationReport>(entity =>
            {
                entity.ToTable("ApplicationReport");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.QualifiedName).HasMaxLength(500);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReportOrder).HasMaxLength(50);
            });

            modelBuilder.Entity<Balance>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cancer).HasColumnType("money");

                entity.Property(e => e.Client).HasMaxLength(500);

                entity.Property(e => e.Dental).HasColumnType("money");

                entity.Property(e => e.DentalLimit)
                    .HasColumnType("money")
                    .HasColumnName("Dental Limit");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InLimit)
                    .HasColumnType("money")
                    .HasColumnName("In Limit");

                entity.Property(e => e.InPatient)
                    .HasColumnType("money")
                    .HasColumnName("In Patient");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Mid).HasMaxLength(50);

                entity.Property(e => e.OpticalLimit)
                    .HasColumnType("money")
                    .HasColumnName("optical Limit");

                entity.Property(e => e.OutLimit)
                    .HasColumnType("money")
                    .HasColumnName("Out Limit");

                entity.Property(e => e.OutPatient)
                    .HasColumnType("money")
                    .HasColumnName("Out Patient");

                entity.Property(e => e.Plan).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Batch>(entity =>
            {
                entity.ToTable("Batch");

                entity.Property(e => e.AccountDate).HasColumnType("datetime");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AmountReceived).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AssignedTo).HasMaxLength(50);

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimMonth).HasColumnType("datetime");

                entity.Property(e => e.ClaimType).HasMaxLength(500);

                entity.Property(e => e.DateOfCompletion).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.PaidBy).HasMaxLength(50);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BatchView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BatchView");

                entity.Property(e => e.AccountDate).HasColumnType("datetime");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AmountReceived).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AssignedTo).HasMaxLength(50);

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimMonth).HasColumnType("datetime");

                entity.Property(e => e.ClaimType).HasMaxLength(500);

                entity.Property(e => e.ClaimTypeString)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClientName).HasMaxLength(100);

                entity.Property(e => e.DateOfCompletion).HasColumnType("datetime");

                entity.Property(e => e.PaidBy).HasMaxLength(50);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.ProviderName).HasMaxLength(250);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ResubmittedString)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StatusString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BatchViewDetailed>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BatchViewDetailed");

                entity.Property(e => e.AccountDate).HasColumnType("datetime");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AmountReceived).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AssignedTo).HasMaxLength(50);

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimMonth).HasColumnType("datetime");

                entity.Property(e => e.ClaimType).HasMaxLength(500);

                entity.Property(e => e.ClaimTypeString)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClientName).HasMaxLength(100);

                entity.Property(e => e.DateOfCompletion).HasColumnType("datetime");

                entity.Property(e => e.PaidBy).HasMaxLength(50);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.ProviderName).HasMaxLength(250);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ResubmittedString)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StatusString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalRejectedAmount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalSuspendedAmount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalToBePaid).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.City1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("City");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.RegionId)
                    .HasMaxLength(50)
                    .HasColumnName("RegionID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Claim>(entity =>
            {
                entity.ToTable("Claim");

                entity.Property(e => e.AdmissionDate).HasColumnType("datetime");

                entity.Property(e => e.DetentionDate).HasColumnType("datetime");

                entity.Property(e => e.DismissialDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Physician).HasMaxLength(500);

                entity.Property(e => e.ReferredBy).HasMaxLength(50);

                entity.Property(e => e.ReferredDate).HasPrecision(3);

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.VettedBy).HasMaxLength(50);

                entity.Property(e => e.VettedDate).HasPrecision(3);
            });

            modelBuilder.Entity<ClaimDiag>(entity =>
            {
                entity.HasKey(e => new { e.ClaimId, e.DiagnosisId })
                    .HasName("PK_ClaimDiag_1");

                entity.ToTable("ClaimDiag");

                entity.Property(e => e.Diagnosis)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimSymptom>(entity =>
            {
                entity.HasKey(e => new { e.ClaimId, e.SymptomId })
                    .HasName("PK_ClaimSymptom");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Symptom)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimTreatment>(entity =>
            {
                entity.HasKey(e => new { e.ClaimId, e.TreatmentId });

                entity.ToTable("ClaimTreatment");

                entity.Property(e => e.ReasonForRejection).HasMaxLength(500);

                entity.Property(e => e.RejectedAmount).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SuspendedAmount).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Treatment).IsRequired();

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<ClaimType>(entity =>
            {
                entity.ToTable("ClaimType");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Default).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ClaimView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClaimView");

                entity.Property(e => e.AdmissionDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimTypeString)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DetentionDate).HasColumnType("datetime");

                entity.Property(e => e.DismissialDate).HasColumnType("datetime");

                entity.Property(e => e.FullPolicyNo).HasMaxLength(60);

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(1502);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.Physician).HasMaxLength(500);

                entity.Property(e => e.ProviderName).HasMaxLength(250);

                entity.Property(e => e.ReferredBy).HasMaxLength(50);

                entity.Property(e => e.ReferredDate).HasPrecision(3);

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalRejectedAmount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalSuspendedAmount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalToBePaid).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.VettedBy).HasMaxLength(50);

                entity.Property(e => e.VettedDate).HasPrecision(3);
            });

            modelBuilder.Entity<ClaimsDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("claims_details");

                entity.Property(e => e.ActionStatus)
                    .HasMaxLength(255)
                    .HasColumnName("action_status");

                entity.Property(e => e.ApproveBalance)
                    .HasMaxLength(255)
                    .HasColumnName("approve_balance");

                entity.Property(e => e.ApprovedQueryStatus)
                    .HasMaxLength(255)
                    .HasColumnName("approved_query_status");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .HasColumnName("attending_officer");

                entity.Property(e => e.AuditStatus)
                    .HasMaxLength(255)
                    .HasColumnName("audit_status");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("datetime")
                    .HasColumnName("audit_time");

                entity.Property(e => e.AuditUpdate)
                    .HasMaxLength(255)
                    .HasColumnName("audit_update");

                entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");

                entity.Property(e => e.AuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("audited_by");

                entity.Property(e => e.AuthorizationCode)
                    .HasMaxLength(255)
                    .HasColumnName("authorization_code");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(255)
                    .HasColumnName("authorization_required");

                entity.Property(e => e.Awarded).HasColumnName("awarded");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no");

                entity.Property(e => e.BookingNo)
                    .HasMaxLength(255)
                    .HasColumnName("booking_no");

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(255)
                    .HasColumnName("claim_type");

                entity.Property(e => e.ClaimTypeRe)
                    .HasMaxLength(255)
                    .HasColumnName("claim_type_re");

                entity.Property(e => e.ClaimsDetailsId)
                    .HasMaxLength(255)
                    .HasColumnName("claims_details_id");

                entity.Property(e => e.CoPaymentAmount)
                    .HasMaxLength(255)
                    .HasColumnName("co_payment_amount");

                entity.Property(e => e.CoPaymentPercent)
                    .HasMaxLength(255)
                    .HasColumnName("co_payment_percent");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment");

                entity.Property(e => e.Company)
                    .HasMaxLength(255)
                    .HasColumnName("company");

                entity.Property(e => e.CurrencyOriginalRate)
                    .HasMaxLength(255)
                    .HasColumnName("currency_original_rate");

                entity.Property(e => e.CurrencyRateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("currency_rate_date");

                entity.Property(e => e.CurrencyUsdRate)
                    .HasMaxLength(255)
                    .HasColumnName("currency_usd_rate");

                entity.Property(e => e.CurrentLocation)
                    .HasMaxLength(255)
                    .HasColumnName("current_location");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasColumnName("date_added");

                entity.Property(e => e.DateAddedShort)
                    .HasColumnType("datetime")
                    .HasColumnName("date_added_short");

                entity.Property(e => e.DateOfActualConsultation)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_actual_consultation");

                entity.Property(e => e.DateOfAdmission)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_admission");

                entity.Property(e => e.DateOfConsultation)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_consultation");

                entity.Property(e => e.DateOfDischarge)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_discharge");

                entity.Property(e => e.DecisionReason)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason");

                entity.Property(e => e.DecisionReasonOther)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason_other");

                entity.Property(e => e.DecisionStatus)
                    .HasMaxLength(255)
                    .HasColumnName("decision_status");

                entity.Property(e => e.DelStatus)
                    .HasMaxLength(255)
                    .HasColumnName("del_status");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(255)
                    .HasColumnName("diagnosis");

                entity.Property(e => e.DiagnosisCode)
                    .HasMaxLength(255)
                    .HasColumnName("diagnosis_code");

                entity.Property(e => e.DiscAmount)
                    .HasMaxLength(255)
                    .HasColumnName("disc_amount");

                entity.Property(e => e.DiscPercent)
                    .HasMaxLength(255)
                    .HasColumnName("disc_percent");

                entity.Property(e => e.DisputedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("disputed_date");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(255)
                    .HasColumnName("dosage_form");

                entity.Property(e => e.Dose).HasColumnName("dose");

                entity.Property(e => e.EmployerCode)
                    .HasMaxLength(255)
                    .HasColumnName("employer_code");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(255)
                    .HasColumnName("employer_id");

                entity.Property(e => e.EyeOptical)
                    .HasMaxLength(255)
                    .HasColumnName("eye_optical");

                entity.Property(e => e.FinanceAuditStatus)
                    .HasMaxLength(255)
                    .HasColumnName("finance_audit_status");

                entity.Property(e => e.FinanceAuditTime)
                    .HasColumnType("datetime")
                    .HasColumnName("finance_audit_time");

                entity.Property(e => e.FinanceAuditUserId).HasColumnName("finance_audit_user_id");

                entity.Property(e => e.FinanceAuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("finance_audited_by");

                entity.Property(e => e.FinanceDecisionReason)
                    .HasMaxLength(255)
                    .HasColumnName("finance_decision_reason");

                entity.Property(e => e.FinanceDecisionReasonOther)
                    .HasMaxLength(255)
                    .HasColumnName("finance_decision_reason_other");

                entity.Property(e => e.FinanceDecisionStatus)
                    .HasMaxLength(255)
                    .HasColumnName("finance_decision_status");

                entity.Property(e => e.FinancialStatus)
                    .HasMaxLength(255)
                    .HasColumnName("financial_status");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(255)
                    .HasColumnName("frequency");

                entity.Property(e => e.IcdCode)
                    .HasMaxLength(255)
                    .HasColumnName("icd_code");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(255)
                    .HasColumnName("id_inscompany");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(255)
                    .HasColumnName("ins_item_code");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.IsDisputed)
                    .HasMaxLength(255)
                    .HasColumnName("is_disputed");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(255)
                    .HasColumnName("item_class");

                entity.Property(e => e.ItemDaysDiff).HasColumnName("item_days_diff");

                entity.Property(e => e.ItemService)
                    .HasMaxLength(255)
                    .HasColumnName("item_service");

                entity.Property(e => e.ItemServiceType)
                    .HasMaxLength(255)
                    .HasColumnName("item_service_type");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(255)
                    .HasColumnName("member_no");

                entity.Property(e => e.NatureOfVisit)
                    .HasMaxLength(255)
                    .HasColumnName("nature_of_visit");

                entity.Property(e => e.NatureofvisitLimit)
                    .HasMaxLength(255)
                    .HasColumnName("natureofvisit_limit");

                entity.Property(e => e.NoOfDays).HasColumnName("no_of_days");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(255)
                    .HasColumnName("payment_status");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(255)
                    .HasColumnName("payment_type");

                entity.Property(e => e.PregnancyExpectedDelivery)
                    .HasColumnType("datetime")
                    .HasColumnName("pregnancy_expected_delivery");

                entity.Property(e => e.PregnancyStatus)
                    .HasMaxLength(255)
                    .HasColumnName("pregnancy_status");

                entity.Property(e => e.PregnancyWeeks)
                    .HasMaxLength(255)
                    .HasColumnName("pregnancy_weeks");

                entity.Property(e => e.PriceCurrency)
                    .HasMaxLength(255)
                    .HasColumnName("price_currency");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no");

                entity.Property(e => e.ProviderDataId).HasColumnName("provider_data_id");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id");

                entity.Property(e => e.ProviderIdDataFor)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_data_for");

                entity.Property(e => e.ProviderIdDataForText)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_data_for_text");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_master");

                entity.Property(e => e.ProviderItemId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_item_id");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name");

                entity.Property(e => e.ProviderNameDataFor)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name_data_for");

                entity.Property(e => e.ProviderRefNo)
                    .HasMaxLength(255)
                    .HasColumnName("provider_ref_no");

                entity.Property(e => e.PushTime)
                    .HasColumnType("datetime")
                    .HasColumnName("push_time");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.QtyAwarded).HasColumnName("qty_awarded");

                entity.Property(e => e.QtyFinance).HasColumnName("qty_finance");

                entity.Property(e => e.QueryStatus)
                    .HasMaxLength(255)
                    .HasColumnName("query_status");

                entity.Property(e => e.ReferToAuditor)
                    .HasMaxLength(255)
                    .HasColumnName("refer_to_auditor");

                entity.Property(e => e.ReferralNo)
                    .HasMaxLength(255)
                    .HasColumnName("referral_no");

                entity.Property(e => e.RxBrandName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_brand_name");

                entity.Property(e => e.RxCartegory)
                    .HasMaxLength(255)
                    .HasColumnName("rx_cartegory");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name");

                entity.Property(e => e.RxMemberId)
                    .HasMaxLength(255)
                    .HasColumnName("rx_member_id");

                entity.Property(e => e.RxPrescriptionName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_prescription_name");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.ServerPushStatus)
                    .HasMaxLength(255)
                    .HasColumnName("server_push_status");

                entity.Property(e => e.ServerTimeUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("server_time_update");

                entity.Property(e => e.ServiceSpeciality)
                    .HasMaxLength(255)
                    .HasColumnName("service_speciality");

                entity.Property(e => e.SmsSent)
                    .HasMaxLength(255)
                    .HasColumnName("sms_sent");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.SubmitTime)
                    .HasColumnType("datetime")
                    .HasColumnName("submit_time");

                entity.Property(e => e.SubmittedStatus)
                    .HasMaxLength(255)
                    .HasColumnName("submitted_status");

                entity.Property(e => e.Supplied)
                    .HasMaxLength(255)
                    .HasColumnName("supplied");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(255)
                    .HasColumnName("sync_batch_delete");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("sync_batch_no");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(255)
                    .HasColumnName("sync_batch_no_update");

                entity.Property(e => e.SyncDelete)
                    .HasMaxLength(255)
                    .HasColumnName("sync_delete");

                entity.Property(e => e.SyncInsert).HasColumnName("sync_insert");

                entity.Property(e => e.SyncInsertCounts).HasColumnName("sync_insert_counts");

                entity.Property(e => e.SyncUpdate)
                    .HasMaxLength(255)
                    .HasColumnName("sync_update");

                entity.Property(e => e.SyncUpdateCounts).HasColumnName("sync_update_counts");

                entity.Property(e => e.Toothnos)
                    .HasMaxLength(255)
                    .HasColumnName("toothnos");

                entity.Property(e => e.TopupAmt)
                    .HasMaxLength(255)
                    .HasColumnName("topup_amt");

                entity.Property(e => e.TotalPrice).HasColumnName("total_price");

                entity.Property(e => e.TypeOfVisit)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_visit");

                entity.Property(e => e.TypeofvisitLimit)
                    .HasMaxLength(255)
                    .HasColumnName("typeofvisit_limit");

                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");

                entity.Property(e => e.UnitPriceAwarded).HasColumnName("unit_price_awarded");

                entity.Property(e => e.UnitPriceFinance).HasColumnName("unit_price_finance");

                entity.Property(e => e.UpdateDeleteStatus)
                    .HasMaxLength(255)
                    .HasColumnName("update_delete_status");

                entity.Property(e => e.UpdateStatus)
                    .HasMaxLength(255)
                    .HasColumnName("update_status");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id");

                entity.Property(e => e.ValidationKey)
                    .HasMaxLength(255)
                    .HasColumnName("validation_key");

                entity.Property(e => e.ValidationPin)
                    .HasMaxLength(255)
                    .HasColumnName("validation_pin");

                entity.Property(e => e.Visittype)
                    .HasMaxLength(255)
                    .HasColumnName("visittype");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClientPrefix)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TermDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClientType)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ClientTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_ClientType");
            });

            modelBuilder.Entity<ClientContact>(entity =>
            {
                entity.HasKey(e => new { e.ContactId, e.ClientId })
                    .HasName("PK_ClientContacts_1");

                entity.Property(e => e.ContactId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ContactID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientProduct>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ClientId, e.ProductItemId })
                    .HasName("PK_ProductProviderPrice");

                entity.ToTable("ClientProduct");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ProductItemId).HasColumnName("ProductItemID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientProductView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClientProductView");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductItemId).HasColumnName("ProductItemID");

                entity.Property(e => e.ProductItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientType>(entity =>
            {
                entity.ToTable("ClientType");

                entity.Property(e => e.Active)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<ClientTypeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClientTypeView");

                entity.Property(e => e.Active)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ActiveString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ClientTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.ClientTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<ClientView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClientView");

                entity.Property(e => e.ActiveString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClientPrefix)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TermDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompanyDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CompanySsfNo)
                    .HasMaxLength(200)
                    .HasColumnName("Company_SSF_No");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Logo).HasMaxLength(50);

                entity.Property(e => e.NoCharactersPolicyNoDependant).HasDefaultValueSql("((2))");

                entity.Property(e => e.NoCharactersPolicyNoMember).HasDefaultValueSql("((5))");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.VatRegNo)
                    .HasMaxLength(200)
                    .HasColumnName("VAT_RegNo");

                entity.Property(e => e.Website).HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Currency1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Currency")
                    .IsFixedLength(true);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DeptCode).HasMaxLength(50);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.ToTable("Diagnosis");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DcategoryId).HasColumnName("DCategoryId");

                entity.Property(e => e.DiagnosisCode).HasMaxLength(15);

                entity.Property(e => e.DiagnosisName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dcategory)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(d => d.DcategoryId)
                    .HasConstraintName("FK_Diagnosis_DiagnosisCategory");
            });

            modelBuilder.Entity<DiagnosisCategory>(entity =>
            {
                entity.HasKey(e => e.DcategoryId);

                entity.ToTable("DiagnosisCategory");

                entity.Property(e => e.DcategoryId).HasColumnName("DCategoryId");

                entity.Property(e => e.CategoryName).HasMaxLength(255);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiagnosisCategoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DiagnosisCategoryView");

                entity.Property(e => e.ActiveString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName).HasMaxLength(255);

                entity.Property(e => e.DcategoryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DCategoryId");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiagnosisView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DiagnosisView");

                entity.Property(e => e.ActiveString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName).HasMaxLength(255);

                entity.Property(e => e.DcategoryId).HasColumnName("DCategoryId");

                entity.Property(e => e.DiagnosisCode).HasMaxLength(15);

                entity.Property(e => e.DiagnosisName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.ToTable("Drug");

                entity.Property(e => e.Active)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DefaultPrice).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.DrugCode)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DrugDescription).HasMaxLength(50);

                entity.Property(e => e.DrugName).HasMaxLength(50);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DrugCategory>(entity =>
            {
                entity.ToTable("DrugCategory");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DrugForm>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Form)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Exproduct>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("EXProduct");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProviderId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ProviderID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Exprovider>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ClientId });

                entity.ToTable("EXProvider");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FormId)
                    .HasMaxLength(3)
                    .HasColumnName("FormID")
                    .IsFixedLength(true);

                entity.Property(e => e.Forms).HasMaxLength(50);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.ToTable("Lead");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermsOfPayment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LeadItem>(entity =>
            {
                entity.HasKey(e => e.LeadId);

                entity.Property(e => e.LeadId).HasColumnName("LeadID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Log");

                entity.Property(e => e.DateLog).HasPrecision(3);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MedicalHistory>(entity =>
            {
                entity.HasKey(e => new { e.MemberId, e.DiagnosisId });

                entity.ToTable("MedicalHistory");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.DiagnosisId).HasColumnName("DiagnosisID");

                entity.Property(e => e.Comments).HasMaxLength(500);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.BusinessEmail).HasMaxLength(250);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1900')");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1900')");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.MarriageStatus).HasMaxLength(50);

                entity.Property(e => e.Middlename)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PersonalEmail).HasMaxLength(250);

                entity.Property(e => e.PhoneNumber).HasMaxLength(250);

                entity.Property(e => e.PictureUrl).HasMaxLength(100);

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sign).HasMaxLength(100);

                entity.Property(e => e.StaffId).HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.TermDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemberPrinting>(entity =>
            {
                entity.HasKey(e => e.PrintingId)
                    .HasName("PK__MemberPr__E79AFD5648B52BC3");

                entity.ToTable("MemberPrinting");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DatePrinted).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(50);
            });

            modelBuilder.Entity<MemberPrintingView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MemberPrintingView");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DatePrinted).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(1502);

                entity.Property(e => e.FullPolicyNo).HasMaxLength(60);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalName)
                    .IsRequired()
                    .HasMaxLength(1502);
            });

            modelBuilder.Entity<MemberStatusHistory>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK_MemberStatus");

                entity.ToTable("MemberStatusHistory");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Client).IsRequired();

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Effective Date");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MemberID")
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemberType>(entity =>
            {
                entity.ToTable("MemberType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemberView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MemberView");

                entity.Property(e => e.ActiveString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AgeStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessEmail).HasMaxLength(250);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Dob).HasColumnType("datetime");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FullPolicyNo).HasMaxLength(60);

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(1502);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.MarriageStatus).HasMaxLength(50);

                entity.Property(e => e.MemberTypeString)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Middlename)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.PersonalEmail).HasMaxLength(250);

                entity.Property(e => e.PhoneNumber).HasMaxLength(250);

                entity.Property(e => e.PictureUrl).HasMaxLength(100);

                entity.Property(e => e.PolicyNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.Sign).HasMaxLength(100);

                entity.Property(e => e.StaffId).HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TermDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("Nationality");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Nationality1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Nationality");

                entity.Property(e => e.UserId)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Notification");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.Client)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CLIENT");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Mid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TYPE");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("YEAR")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PreAuthorization>(entity =>
            {
                entity.ToTable("PreAuthorization");

                entity.Property(e => e.Authoriser).HasMaxLength(20);

                entity.Property(e => e.AuthorizedCode).HasMaxLength(10);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PreAuthorizationView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PreAuthorizationView");

                entity.Property(e => e.Authoriser).HasMaxLength(20);

                entity.Property(e => e.AuthorizedCode).HasMaxLength(10);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FullPolicyNo).HasMaxLength(60);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Middlename)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ProviderName).HasMaxLength(250);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TreatmentName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Active)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProductPrefix).HasMaxLength(5);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductItem>(entity =>
            {
                entity.ToTable("ProductItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductItemCategory>(entity =>
            {
                entity.ToTable("ProductItemCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductView");

                entity.Property(e => e.Active)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ActiveString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.ProductId).ValueGeneratedOnAdd();

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProductPrefix).HasMaxLength(5);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("Provider");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(500);

                entity.Property(e => e.ImageUrl).HasMaxLength(50);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Latitude).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ProviderName).HasMaxLength(250);

                entity.Property(e => e.TermDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProviderCategory>(entity =>
            {
                entity.HasKey(e => e.ProviderCatId);

                entity.ToTable("ProviderCategory");

                entity.Property(e => e.Active)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.ProviderCatName).HasMaxLength(500);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProviderCategoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProviderCategoryView");

                entity.Property(e => e.Active)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ActiveString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.ProviderCatId).ValueGeneratedOnAdd();

                entity.Property(e => e.ProviderCatName).HasMaxLength(500);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProviderType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.ProviderType1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ProviderType");

                entity.Property(e => e.ProviderTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProviderView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProviderView");

                entity.Property(e => e.ActiveString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(500);

                entity.Property(e => e.ImageUrl).HasMaxLength(50);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Latitude).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ProviderCatName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ProviderName).HasMaxLength(250);

                entity.Property(e => e.TermDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProvidersProduct>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProviderId });

                entity.ToTable("ProvidersProduct");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReasonsForRejection>(entity =>
            {
                entity.HasKey(e => e.ReasonsId)
                    .HasName("PK_ReasonsForExclusion");

                entity.ToTable("ReasonsForRejection");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reconciliation>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("Reconciliation");

                entity.Property(e => e.RecordId)
                    .ValueGeneratedNever()
                    .HasColumnName("RecordID");

                entity.Property(e => e.ClaimMonth)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Cost).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.InvoiceNo).HasMaxLength(20);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Refund>(entity =>
            {
                entity.ToTable("Refund");

                entity.Property(e => e.AmountRefunded).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.DateRefunded).HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<RefundView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RefundView");

                entity.Property(e => e.AmountRefunded).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateRefunded).HasColumnType("date");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(1502);

                entity.Property(e => e.FullPolicyNo).HasMaxLength(60);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.MemberTypeString)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProviderName).HasMaxLength(250);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Region1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Region");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Grouping).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.ReportHeader).HasColumnName("Report Header");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(50)
                    .HasColumnName("Report Name");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Permissions)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Role")
                    .IsFixedLength(true);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rate)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScannerDetail>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Page)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PageNumber).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressLine1).HasMaxLength(250);

                entity.Property(e => e.AddressLine2).HasMaxLength(250);

                entity.Property(e => e.AddressLine3).HasMaxLength(250);

                entity.Property(e => e.AddressLine4).HasMaxLength(250);

                entity.Property(e => e.ClaimsContraAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Claims Contra Account")
                    .HasDefaultValueSql("((3101005))");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ContraAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Contra Account")
                    .HasDefaultValueSql("((5000005))");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("date")
                    .HasDefaultValueSql("(N'pxcgkOOht9nTwW2T63MqMw==')");

                entity.Property(e => e.Developers).HasMaxLength(200);

                entity.Property(e => e.EMail)
                    .HasMaxLength(50)
                    .HasColumnName("eMail");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Website).HasMaxLength(50);

                entity.Property(e => e.Yes).HasColumnName("yes");
            });

            modelBuilder.Entity<StaffCategory>(entity =>
            {
                entity.ToTable("StaffCategory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Symptom>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SymptomsCategory>(entity =>
            {
                entity.ToTable("SymptomsCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TempAct>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("TempAct");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Client)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MemberID");

                entity.Property(e => e.TermDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Title1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Title");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToMigrate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ToMigrate");

                entity.Property(e => e.Branch).HasMaxLength(255);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("Date of Birth");

                entity.Property(e => e.EmployersName)
                    .HasMaxLength(255)
                    .HasColumnName("Employers Name");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("End Date");

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.MainMember).HasMaxLength(255);

                entity.Property(e => e.MainMemberId).HasColumnName("MainMemberID");

                entity.Property(e => e.MedicalHistory).HasColumnName("Medical History");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(255)
                    .HasColumnName("Member No");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .HasColumnName("Middle Name");

                entity.Property(e => e.Nationality).HasMaxLength(255);

                entity.Property(e => e.Plan).HasMaxLength(255);

                entity.Property(e => e.Pmsp)
                    .HasMaxLength(255)
                    .HasColumnName("PMSP");

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(255);

                entity.Property(e => e.PostalAddress)
                    .HasMaxLength(255)
                    .HasColumnName("Postal Address");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Relationship).HasMaxLength(255);

                entity.Property(e => e.ResAddress)
                    .HasMaxLength(255)
                    .HasColumnName("Res Address");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Start Date");

                entity.Property(e => e.Surname).HasMaxLength(255);

                entity.Property(e => e.TelNo).HasColumnName("Tel# No");
            });

            modelBuilder.Entity<Tpa>(entity =>
            {
                entity.ToTable("TPA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgreementType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.ToTable("Treatment");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DefaultMaxPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DefaultMinPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreatmentCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_Treatment Category");

                entity.ToTable("TreatmentCategory");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreatmentCategoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TreatmentCategoryView");

                entity.Property(e => e.ActiveString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).ValueGeneratedOnAdd();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreatmentCost>(entity =>
            {
                entity.HasKey(e => new { e.ProviderId, e.TreatmentId });

                entity.ToTable("TreatmentCost");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.TreatmentId).HasColumnName("TreatmentID");

                entity.Property(e => e.Cost).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreatmentType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TreatmentType1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TreatmentType");
            });

            modelBuilder.Entity<TreatmentView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TreatmentView");

                entity.Property(e => e.ActiveString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DefaultMaxPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DefaultMinPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TypeTreatmentString)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.Allowed).HasDefaultValueSql("((1))");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.License)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StaffCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
