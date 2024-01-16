using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
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
        public virtual DbSet<Bsheet> Bsheets { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Claim> Claims { get; set; }
        public virtual DbSet<ClaimDeleted> ClaimDeleteds { get; set; }
        public virtual DbSet<ClaimDiag> ClaimDiags { get; set; }
        public virtual DbSet<ClaimQueryDiagnosis> ClaimQueryDiagnoses { get; set; }
        public virtual DbSet<ClaimSheet> ClaimSheets { get; set; }
        public virtual DbSet<ClaimSymptom> ClaimSymptoms { get; set; }
        public virtual DbSet<ClaimTreatment> ClaimTreatments { get; set; }
        public virtual DbSet<ClaimType> ClaimTypes { get; set; }
        public virtual DbSet<ClaimView> ClaimViews { get; set; }
        public virtual DbSet<ClaimsDetail> ClaimsDetails { get; set; }
        public virtual DbSet<ClaimsDetailsComment> ClaimsDetailsComments { get; set; }
        public virtual DbSet<ClaimsDetailsDel> ClaimsDetailsDels { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientContact> ClientContacts { get; set; }
        public virtual DbSet<ClientProduct> ClientProducts { get; set; }
        public virtual DbSet<ClientProductView> ClientProductViews { get; set; }
        public virtual DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<ClientTypeView> ClientTypeViews { get; set; }
        public virtual DbSet<ClientView> ClientViews { get; set; }
        public virtual DbSet<CompanyDetail> CompanyDetails { get; set; }
        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<ComplaintCategory> ComplaintCategories { get; set; }
        public virtual DbSet<ComplaintCategoryView> ComplaintCategoryViews { get; set; }
        public virtual DbSet<ComplaintView> ComplaintViews { get; set; }
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
        public virtual DbSet<FacilityRate> FacilityRates { get; set; }
        public virtual DbSet<FacilityRegion> FacilityRegions { get; set; }
        public virtual DbSet<FacilityType> FacilityTypes { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<InvoiceTable> InvoiceTables { get; set; }
        public virtual DbSet<InvoiceView> InvoiceViews { get; set; }
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
        public virtual DbSet<Msheet> Msheets { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Number> Numbers { get; set; }
        public virtual DbSet<Pinfo> Pinfos { get; set; }
        public virtual DbSet<PreAuthorization> PreAuthorizations { get; set; }
        public virtual DbSet<PreAuthorizationView> PreAuthorizationViews { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductItem> ProductItems { get; set; }
        public virtual DbSet<ProductView> ProductViews { get; set; }
        public virtual DbSet<ProvInfo> ProvInfos { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<ProviderCategory> ProviderCategories { get; set; }
        public virtual DbSet<ProviderCategoryView> ProviderCategoryViews { get; set; }
        public virtual DbSet<ProviderGroup> ProviderGroups { get; set; }
        public virtual DbSet<ProviderPrescription> ProviderPrescriptions { get; set; }
        public virtual DbSet<ProviderType> ProviderTypes { get; set; }
        public virtual DbSet<ProviderView> ProviderViews { get; set; }
        public virtual DbSet<ProvidersProduct> ProvidersProducts { get; set; }
        public virtual DbSet<ReasonsForRejection> ReasonsForRejections { get; set; }
        public virtual DbSet<RecentClaim> RecentClaims { get; set; }
        public virtual DbSet<Reconciliation> Reconciliations { get; set; }
        public virtual DbSet<Refund> Refunds { get; set; }
        public virtual DbSet<RefundView> RefundViews { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RxPayment> RxPayments { get; set; }
        public virtual DbSet<ScannerDetail> ScannerDetails { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Sheet12> Sheet12s { get; set; }
        public virtual DbSet<Sheet14> Sheet14s { get; set; }
        public virtual DbSet<StaffCategory> StaffCategories { get; set; }
        public virtual DbSet<Symptom> Symptoms { get; set; }
        public virtual DbSet<SymptomsCategory> SymptomsCategories { get; set; }
        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<Table2> Table2s { get; set; }
        public virtual DbSet<Table3> Table3s { get; set; }
        public virtual DbSet<Table4> Table4s { get; set; }
        public virtual DbSet<TaxTable> TaxTables { get; set; }
        public virtual DbSet<Temp3> Temp3s { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<ToMigrate> ToMigrates { get; set; }
        public virtual DbSet<Tpa> Tpas { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
        public virtual DbSet<TreatToDelete> TreatToDeletes { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<TreatmentCategory> TreatmentCategories { get; set; }
        public virtual DbSet<TreatmentCategoryView> TreatmentCategoryViews { get; set; }
        public virtual DbSet<TreatmentCost> TreatmentCosts { get; set; }
        public virtual DbSet<TreatmentType> TreatmentTypes { get; set; }
        public virtual DbSet<TreatmentView> TreatmentViews { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-LDSIAB0;Database=HIMSAPEX;;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

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

                entity.Property(e => e.NbPendingClaims).HasColumnName("NbPendingCLaims");

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

            modelBuilder.Entity<Bsheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bsheet");

                entity.Property(e => e.AccountDate).HasMaxLength(255);

                entity.Property(e => e.AssignedTo).HasMaxLength(255);

                entity.Property(e => e.BatchDate).HasMaxLength(255);

                entity.Property(e => e.BookNo).HasMaxLength(255);

                entity.Property(e => e.ClaimMonth).HasMaxLength(255);

                entity.Property(e => e.ClientId).HasMaxLength(255);

                entity.Property(e => e.DateOfCompletion).HasMaxLength(255);

                entity.Property(e => e.LastDateModified).HasMaxLength(255);

                entity.Property(e => e.PaidBy).HasMaxLength(255);

                entity.Property(e => e.PayDate).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.UserId).HasMaxLength(255);
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

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Physician).HasMaxLength(500);

                entity.Property(e => e.ProcessClaimNo).HasMaxLength(50);

                entity.Property(e => e.ReferredBy).HasMaxLength(50);

                entity.Property(e => e.ReferredDate).HasPrecision(3);

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.VettedBy).HasMaxLength(50);

                entity.Property(e => e.VettedDate).HasPrecision(3);
            });

            modelBuilder.Entity<ClaimDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClaimDeleted");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimDiag>(entity =>
            {
                entity.HasKey(e => new { e.ClaimId, e.DiagnosisId })
                    .HasName("PK_ClaimDiag_1");

                entity.ToTable("ClaimDiag");

                entity.Property(e => e.Diagnosis).IsRequired();

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimQueryDiagnosis>(entity =>
            {
                entity.ToTable("ClaimQueryDiagnosis");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.DiseaseCode)
                    .HasMaxLength(50)
                    .HasColumnName("disease_code");

                entity.Property(e => e.DiseaseGrp)
                    .HasMaxLength(250)
                    .HasColumnName("disease_grp");

                entity.Property(e => e.DiseaseId).HasColumnName("disease_id");

                entity.Property(e => e.DiseaseName)
                    .HasMaxLength(250)
                    .HasColumnName("disease_name");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(250)
                    .HasColumnName("Process_claim_no");

                entity.Property(e => e.ProviderId).HasColumnName("provider_Id");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ClaimSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClaimSheet");

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(255)
                    .HasColumnName("claim_type");

                entity.Property(e => e.ClaimType1).HasColumnName("claimType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no");
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
                entity.ToTable("ClaimTreatment");

                entity.Property(e => e.ItemService).HasMaxLength(150);

                entity.Property(e => e.OtherReason).HasMaxLength(500);

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

                entity.Property(e => e.ClaimMonth).HasColumnType("datetime");

                entity.Property(e => e.ClaimStatusString)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimTypeString).HasMaxLength(50);

                entity.Property(e => e.ClientName).HasMaxLength(100);

                entity.Property(e => e.DetentionDate).HasColumnType("datetime");

                entity.Property(e => e.DismissialDate).HasColumnType("datetime");

                entity.Property(e => e.FinanceDecisionStatusString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FullPolicyNo).HasMaxLength(60);

                entity.Property(e => e.Fullname).HasMaxLength(1502);

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(250);

                entity.Property(e => e.Physician).HasMaxLength(500);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ProcessClaimNo).HasMaxLength(50);

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
                entity.ToTable("claims_details");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

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
                    .HasMaxLength(255)
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

                entity.Property(e => e.ClaimId).HasColumnName("claimId");

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
                    .HasMaxLength(255)
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
                    .HasMaxLength(255)
                    .HasColumnName("date_of_actual_consultation");

                entity.Property(e => e.DateOfAdmission)
                    .HasColumnType("date")
                    .HasColumnName("date_of_admission");

                entity.Property(e => e.DateOfConsultation1)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_consultation");

                entity.Property(e => e.DateOfDischarge)
                    .HasColumnType("date")
                    .HasColumnName("date_of_discharge");

                entity.Property(e => e.DateofConsultationString)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dateofconsultation)
                    .HasColumnType("date")
                    .HasColumnName("dateofconsultation");

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

                entity.Property(e => e.Diagnosis).HasColumnName("diagnosis");

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
                    .HasMaxLength(255)
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
                    .HasMaxLength(255)
                    .HasColumnName("finance_audit_time");

                entity.Property(e => e.FinanceAuditUserId)
                    .HasMaxLength(255)
                    .HasColumnName("finance_audit_user_id");

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

                entity.Property(e => e.Maxdateofconsulation)
                    .HasColumnType("datetime")
                    .HasColumnName("maxdateofconsulation");

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
                    .HasMaxLength(255)
                    .HasColumnName("pregnancy_expected_delivery");

                entity.Property(e => e.PregnancyStatus)
                    .HasMaxLength(255)
                    .HasColumnName("pregnancy_status");

                entity.Property(e => e.PregnancyWeeks)
                    .HasMaxLength(255)
                    .HasColumnName("pregnancy_weeks");

                entity.Property(e => e.PriceCurrency)
                    .HasMaxLength(50)
                    .HasColumnName("price_currency");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no");

                entity.Property(e => e.ProviderDataId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_data_id");

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
                    .HasMaxLength(150)
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
                    .HasMaxLength(255)
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
                    .HasMaxLength(255)
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
                    .HasMaxLength(50)
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

            modelBuilder.Entity<ClaimsDetailsComment>(entity =>
            {
                entity.ToTable("claims_details_comments");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Claimno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("claimno");

                entity.Property(e => e.Comment)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.DateUpdated)
                    .HasPrecision(0)
                    .HasColumnName("date_updated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_inscompany");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ins_company");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("provider_id");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sync_batch_delete");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sync_batch_no");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sync_batch_no_update");

                entity.Property(e => e.SyncDelete).HasColumnName("sync_delete");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyncUpdate).HasColumnName("sync_update");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.User)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("user");
            });

            modelBuilder.Entity<ClaimsDetailsDel>(entity =>
            {
                entity.ToTable("claims_details_del");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("attending_officer");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasColumnName("date_added");

                entity.Property(e => e.DateAddedShort)
                    .HasColumnType("date")
                    .HasColumnName("date_added_short");

                entity.Property(e => e.DateOfAdmission)
                    .HasColumnType("date")
                    .HasColumnName("date_of_admission");

                entity.Property(e => e.DateOfConsultation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_consultation");

                entity.Property(e => e.DateOfDischarge)
                    .HasColumnType("date")
                    .HasColumnName("date_of_discharge");

                entity.Property(e => e.Deleteby)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("deleteby");

                entity.Property(e => e.Deletetime)
                    .HasColumnType("datetime")
                    .HasColumnName("deletetime");

                entity.Property(e => e.Diagnosis).HasColumnName("diagnosis");

                entity.Property(e => e.DiagnosisCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("diagnosis_code");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dosage_form");

                entity.Property(e => e.Dose).HasColumnName("dose");

                entity.Property(e => e.EmployerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("employer_code");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employer_id");

                entity.Property(e => e.EyeOptical)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eye_optical");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("frequency");

                entity.Property(e => e.IcdCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("icd_code");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ins_company");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ins_item_code");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("item");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("item_class");

                entity.Property(e => e.ItemService)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("item_service");

                entity.Property(e => e.ItemServiceType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("item_service_type");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("member_no");

                entity.Property(e => e.NoOfDays).HasColumnName("no_of_days");

                entity.Property(e => e.PregnancyExpectedDelivery)
                    .HasColumnType("date")
                    .HasColumnName("pregnancy_expected_delivery");

                entity.Property(e => e.PregnancyStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pregnancy_status");

                entity.Property(e => e.PregnancyWeeks)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("pregnancy_weeks");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("process_claim_no");

                entity.Property(e => e.ProviderDataId).HasColumnName("provider_data_id");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("provider_id");

                entity.Property(e => e.ProviderIdDataFor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("provider_id_data_for");

                entity.Property(e => e.ProviderIdDataForText)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("provider_id_data_for_text");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("provider_id_master");

                entity.Property(e => e.ProviderItemId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("provider_item_id");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("provider_name");

                entity.Property(e => e.ProviderRefNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("provider_ref_no");

                entity.Property(e => e.PushTime)
                    .HasColumnType("datetime")
                    .HasColumnName("push_time");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rx_item_name");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.ServerPushStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("server_push_status");

                entity.Property(e => e.ServerTimeUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("server_time_update")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubmitTime)
                    .HasColumnType("datetime")
                    .HasColumnName("submit_time");

                entity.Property(e => e.SubmittedStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("submitted_status");

                entity.Property(e => e.Toothnos)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("toothnos");

                entity.Property(e => e.TypeOfVisit)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("type_of_visit");

                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.ClientId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClientPrefix).HasMaxLength(5);

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

                entity.Property(e => e.ClientTypeId).ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ClientTypeName).HasMaxLength(50);

                entity.Property(e => e.Tpa)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
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

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClientPrefix).HasMaxLength(5);

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

            modelBuilder.Entity<Complaint>(entity =>
            {
                entity.ToTable("Complaint");

                entity.Property(e => e.ApprovedAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ComplainantName).HasMaxLength(150);

                entity.Property(e => e.ComplainantPhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ComplaintDate).HasPrecision(3);

                entity.Property(e => e.ComplaintDescription)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Duration).HasMaxLength(250);

                entity.Property(e => e.LoggedBy).HasMaxLength(250);

                entity.Property(e => e.ProcedureType).HasMaxLength(250);

                entity.Property(e => e.ResolveDate).HasPrecision(3);

                entity.Property(e => e.ResolveDescription).HasMaxLength(500);

                entity.Property(e => e.ResolvedBy).HasMaxLength(250);

                entity.Property(e => e.Response).HasMaxLength(500);

                entity.HasOne(d => d.ComplaintCategory)
                    .WithMany(p => p.Complaints)
                    .HasForeignKey(d => d.ComplaintCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Complaint_ComplaintCategory");
            });

            modelBuilder.Entity<ComplaintCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("ComplaintCategory");

                entity.Property(e => e.CategoryName).HasMaxLength(255);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComplaintCategoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ComplaintCategoryView");

                entity.Property(e => e.ActiveString)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).ValueGeneratedOnAdd();

                entity.Property(e => e.CategoryName).HasMaxLength(255);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComplaintView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ComplaintView");

                entity.Property(e => e.CategoryName).HasMaxLength(255);

                entity.Property(e => e.ClientName).HasMaxLength(100);

                entity.Property(e => e.ComplaintDate).HasPrecision(3);

                entity.Property(e => e.ComplaintDescription)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Firstname).HasMaxLength(500);

                entity.Property(e => e.Middlename).HasMaxLength(500);

                entity.Property(e => e.ProviderName).HasMaxLength(250);

                entity.Property(e => e.ResolveDate).HasPrecision(3);

                entity.Property(e => e.ResolveDescription).HasMaxLength(500);

                entity.Property(e => e.Surname).HasMaxLength(500);
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

                entity.Property(e => e.DiagnosisCode).HasMaxLength(150);

                entity.Property(e => e.DiagnosisName).IsRequired();

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

                entity.Property(e => e.DiagnosisCode).HasMaxLength(150);

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

            modelBuilder.Entity<FacilityRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FacilityRate");

                entity.Property(e => e.FacilityName)
                    .HasMaxLength(255)
                    .HasColumnName("FACILITY NAME");

                entity.Property(e => e.TaxRate).HasColumnName("TAX RATE");
            });

            modelBuilder.Entity<FacilityRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FacilityRegion");

                entity.Property(e => e.Facility)
                    .HasMaxLength(255)
                    .HasColumnName("FACILITY");

                entity.Property(e => e.Region)
                    .HasMaxLength(255)
                    .HasColumnName("REGION");
            });

            modelBuilder.Entity<FacilityType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FacilityType");

                entity.Property(e => e.Facility)
                    .HasMaxLength(255)
                    .HasColumnName("FACILITY");

                entity.Property(e => e.FacilityType1)
                    .HasMaxLength(255)
                    .HasColumnName("FACILITY TYPE");
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

            modelBuilder.Entity<InvoiceTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvoiceTable$");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasColumnName("date_added");

                entity.Property(e => e.DateOfClaim)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_claim");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Monthofclaim).HasColumnName("monthofclaim");

                entity.Property(e => e.NumberOfClaims).HasColumnName("number_of_claims");

                entity.Property(e => e.ProviderClaimAmt).HasColumnName("provider_claim_amt");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name");

                entity.Property(e => e.SystemInvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("system_invoice_no");

                entity.Property(e => e.Yrofclaim).HasColumnName("yrofclaim");
            });

            modelBuilder.Entity<InvoiceView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("InvoiceView");

                entity.Property(e => e.ClaimMonth).HasColumnType("datetime");

                entity.Property(e => e.EndOfMonth).HasColumnType("date");

                entity.Property(e => e.ProviderName).HasMaxLength(250);

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalRejectedAmount).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.TotalToBePaid).HasColumnType("decimal(38, 4)");
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
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01/01/1900')");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.MarriageStatus).HasMaxLength(50);

                entity.Property(e => e.Middlename).HasMaxLength(500);

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

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemberPrinting>(entity =>
            {
                entity.HasKey(e => e.PrintingId)
                    .HasName("PK__MemberPr__E79AFD5698FB1957");

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

                entity.Property(e => e.OriginalName).HasMaxLength(1502);
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

                entity.Property(e => e.AgeStatus).HasMaxLength(50);

                entity.Property(e => e.BusinessEmail).HasMaxLength(250);

                entity.Property(e => e.ClientName).HasMaxLength(100);

                entity.Property(e => e.Dob).HasColumnType("datetime");

                entity.Property(e => e.Firstname).HasMaxLength(500);

                entity.Property(e => e.FullPolicyNo).HasMaxLength(60);

                entity.Property(e => e.Fullname).HasMaxLength(1502);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.MarriageStatus).HasMaxLength(50);

                entity.Property(e => e.MemberTypeString).HasMaxLength(50);

                entity.Property(e => e.Middlename).HasMaxLength(500);

                entity.Property(e => e.Nationality).HasMaxLength(150);

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

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Msheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSheet");

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
                    .HasMaxLength(255)
                    .HasColumnName("audit_time");

                entity.Property(e => e.AuditUpdate)
                    .HasMaxLength(255)
                    .HasColumnName("audit_update");

                entity.Property(e => e.AuditUserId)
                    .HasMaxLength(255)
                    .HasColumnName("audit_user_id");

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
                    .HasMaxLength(255)
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
                    .HasMaxLength(255)
                    .HasColumnName("date_of_actual_consultation");

                entity.Property(e => e.DateOfAdmission)
                    .HasMaxLength(255)
                    .HasColumnName("date_of_admission");

                entity.Property(e => e.DateOfConsultation)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_consultation");

                entity.Property(e => e.DateOfDischarge)
                    .HasMaxLength(255)
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

                entity.Property(e => e.Diagnosis).HasColumnName("diagnosis");

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
                    .HasMaxLength(255)
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
                    .HasMaxLength(255)
                    .HasColumnName("finance_audit_time");

                entity.Property(e => e.FinanceAuditUserId)
                    .HasMaxLength(255)
                    .HasColumnName("finance_audit_user_id");

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
                    .HasMaxLength(255)
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

                entity.Property(e => e.QtyAwarded)
                    .HasMaxLength(255)
                    .HasColumnName("qty_awarded");

                entity.Property(e => e.QtyFinance)
                    .HasMaxLength(255)
                    .HasColumnName("qty_finance");

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
                    .HasMaxLength(255)
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

                entity.Property(e => e.UnitPriceAwarded)
                    .HasMaxLength(255)
                    .HasColumnName("unit_price_awarded");

                entity.Property(e => e.UnitPriceFinance)
                    .HasMaxLength(255)
                    .HasColumnName("unit_price_finance");

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

            modelBuilder.Entity<Number>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Number$");

                entity.Property(e => e.Number1)
                    .HasMaxLength(255)
                    .HasColumnName("Number");
            });

            modelBuilder.Entity<Pinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PInfo");

                entity.Property(e => e.EmployerId).HasColumnName("employer_id");

                entity.Property(e => e.MemberNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("member_no");
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

                entity.Property(e => e.Firstname).HasMaxLength(500);

                entity.Property(e => e.FullPolicyNo).HasMaxLength(60);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Middlename).HasMaxLength(500);

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

            modelBuilder.Entity<ProvInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProvInfo");

                entity.Property(e => e.FacilityName)
                    .HasMaxLength(255)
                    .HasColumnName("facility_name");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("Provider");

                entity.Property(e => e.ProviderId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(500);

                entity.Property(e => e.ImageUrl).HasMaxLength(250);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Latitude).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ProviderName).HasMaxLength(250);

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 5)");

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

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 5)");

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

            modelBuilder.Entity<ProviderGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("ProviderGroup");

                entity.Property(e => e.GroupName).HasMaxLength(250);

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProviderPrescription>(entity =>
            {
                entity.ToTable("provider_prescriptions");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("('APX')");

                entity.Property(e => e.PrescriptionDocument)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("prescription_document");

                entity.Property(e => e.ProcessClaimNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("process_claim_no");

                entity.Property(e => e.ProviderId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("provider_id");

                entity.Property(e => e.ProviderUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("provider_user_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sync_batch_no");
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

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ImageUrl).HasMaxLength(250);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastDateModified).HasPrecision(3);

                entity.Property(e => e.Latitude).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.ProviderCatName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ProviderName).HasMaxLength(250);

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 5)");

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

            modelBuilder.Entity<RecentClaim>(entity =>
            {
                entity.HasNoKey();

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
                    .HasMaxLength(255)
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
                    .HasMaxLength(255)
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
                    .HasMaxLength(255)
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

                entity.Property(e => e.Diagnosis).HasColumnName("diagnosis");

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
                    .HasMaxLength(255)
                    .HasColumnName("disputed_date");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(255)
                    .HasColumnName("dosage_form");

                entity.Property(e => e.Dose).HasColumnName("dose");

                entity.Property(e => e.EmployerCode)
                    .HasMaxLength(255)
                    .HasColumnName("employer_code");

                entity.Property(e => e.EmployerId).HasColumnName("employer_id");

                entity.Property(e => e.EyeOptical)
                    .HasMaxLength(255)
                    .HasColumnName("eye_optical");

                entity.Property(e => e.FinanceAuditStatus)
                    .HasMaxLength(255)
                    .HasColumnName("finance_audit_status");

                entity.Property(e => e.FinanceAuditTime)
                    .HasMaxLength(255)
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
                    .HasMaxLength(255)
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

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.ProviderIdDataFor).HasColumnName("provider_id_data_for");

                entity.Property(e => e.ProviderIdDataForText)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_data_for_text");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_master");

                entity.Property(e => e.ProviderItemId).HasColumnName("provider_item_id");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name");

                entity.Property(e => e.ProviderNameDataFor)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name_data_for");

                entity.Property(e => e.ProviderRefNo).HasColumnName("provider_ref_no");

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

                entity.Property(e => e.UserId).HasColumnName("user_id");

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

                entity.Property(e => e.FullName).HasMaxLength(1502);

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

            modelBuilder.Entity<RxPayment>(entity =>
            {
                entity.ToTable("RxPayment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateOfClaim).HasColumnType("datetime");

                entity.Property(e => e.ProviderAmountClaimed)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("ProviderAmountCLaimed");

                entity.Property(e => e.ProviderName).HasMaxLength(200);

                entity.Property(e => e.SystemInvoiceNber).HasMaxLength(100);
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

            modelBuilder.Entity<Sheet12>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet12");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(255)
                    .HasColumnName("member_no");
            });

            modelBuilder.Entity<Sheet14>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet14");

                entity.Property(e => e.ActualMemberNo)
                    .HasMaxLength(255)
                    .HasColumnName("actual_member_no");

                entity.Property(e => e.AdmBalance)
                    .HasMaxLength(255)
                    .HasColumnName("adm_balance");

                entity.Property(e => e.ApprovedStatus)
                    .HasMaxLength(255)
                    .HasColumnName("approved_status");

                entity.Property(e => e.ArchiveStatus)
                    .HasMaxLength(255)
                    .HasColumnName("archive_status");

                entity.Property(e => e.BalanceStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("balance_start_date");

                entity.Property(e => e.BalanceType)
                    .HasMaxLength(255)
                    .HasColumnName("balance_type");

                entity.Property(e => e.BankName)
                    .HasMaxLength(255)
                    .HasColumnName("bank_name");

                entity.Property(e => e.CardPin)
                    .HasMaxLength(255)
                    .HasColumnName("card_pin");

                entity.Property(e => e.CardSerialNum)
                    .HasMaxLength(255)
                    .HasColumnName("card_serial_num");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("company_id");

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(255)
                    .HasColumnName("country_of_origin");

                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .HasColumnName("currency");

                entity.Property(e => e.DateAdded)
                    .HasMaxLength(255)
                    .HasColumnName("date_added");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.DateUpdated)
                    .HasMaxLength(255)
                    .HasColumnName("date_updated");

                entity.Property(e => e.DecisionStatus)
                    .HasMaxLength(255)
                    .HasColumnName("decision_status");

                entity.Property(e => e.DentalBalance)
                    .HasMaxLength(255)
                    .HasColumnName("dental_balance");

                entity.Property(e => e.DrugBalance)
                    .HasMaxLength(255)
                    .HasColumnName("drug_balance");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Employer)
                    .HasMaxLength(255)
                    .HasColumnName("employer");

                entity.Property(e => e.EmployerCode)
                    .HasMaxLength(255)
                    .HasColumnName("employer_code");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(255)
                    .HasColumnName("employer_id");

                entity.Property(e => e.EmployerType)
                    .HasMaxLength(255)
                    .HasColumnName("employer_type");

                entity.Property(e => e.EntBalance)
                    .HasMaxLength(255)
                    .HasColumnName("ent_balance");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.FamilyNumber)
                    .HasMaxLength(255)
                    .HasColumnName("family_number");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(255)
                    .HasColumnName("firstname");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(255)
                    .HasColumnName("fullname");

                entity.Property(e => e.HomeCountry)
                    .HasMaxLength(255)
                    .HasColumnName("home_country");

                entity.Property(e => e.Iban)
                    .HasMaxLength(255)
                    .HasColumnName("iban");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(255)
                    .HasColumnName("id_inscompany");

                entity.Property(e => e.InpatientBalance)
                    .HasMaxLength(255)
                    .HasColumnName("inpatient_balance");

                entity.Property(e => e.InpatientLimit)
                    .HasMaxLength(255)
                    .HasColumnName("inpatient_limit");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company");

                entity.Property(e => e.InsertDeleteStatus)
                    .HasMaxLength(255)
                    .HasColumnName("insert_delete_status");

                entity.Property(e => e.InsertUser)
                    .HasMaxLength(255)
                    .HasColumnName("insert_user");

                entity.Property(e => e.IpdBal)
                    .HasMaxLength(255)
                    .HasColumnName("ipd_bal");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("datetime")
                    .HasColumnName("join_date");

                entity.Property(e => e.LabBalance)
                    .HasMaxLength(255)
                    .HasColumnName("lab_balance");

                entity.Property(e => e.MaternityBalance)
                    .HasMaxLength(255)
                    .HasColumnName("maternity_balance");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(255)
                    .HasColumnName("member_id");

                entity.Property(e => e.MemberImportId)
                    .HasMaxLength(255)
                    .HasColumnName("member_import_id");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(255)
                    .HasColumnName("member_no");

                entity.Property(e => e.MemberPlan)
                    .HasMaxLength(255)
                    .HasColumnName("member_plan");

                entity.Property(e => e.MemberPlanId)
                    .HasMaxLength(255)
                    .HasColumnName("member_plan_id");

                entity.Property(e => e.MemberPolicyId)
                    .HasMaxLength(255)
                    .HasColumnName("member_policy_id");

                entity.Property(e => e.MemberType)
                    .HasMaxLength(255)
                    .HasColumnName("member_type");

                entity.Property(e => e.NewRxId)
                    .HasMaxLength(255)
                    .HasColumnName("new_rx_id");

                entity.Property(e => e.Nhis)
                    .HasMaxLength(255)
                    .HasColumnName("nhis");

                entity.Property(e => e.OldMemberNo)
                    .HasMaxLength(255)
                    .HasColumnName("old_member_no");

                entity.Property(e => e.OpdBal)
                    .HasMaxLength(255)
                    .HasColumnName("opd_bal");

                entity.Property(e => e.OptBalance)
                    .HasMaxLength(255)
                    .HasColumnName("opt_balance");

                entity.Property(e => e.Othernames)
                    .HasMaxLength(255)
                    .HasColumnName("othernames");

                entity.Property(e => e.OutpatientBalance)
                    .HasMaxLength(255)
                    .HasColumnName("outpatient_balance");

                entity.Property(e => e.OutpatientLimit)
                    .HasMaxLength(255)
                    .HasColumnName("outpatient_limit");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(255)
                    .HasColumnName("payment_type");

                entity.Property(e => e.PhysioBalance)
                    .HasMaxLength(255)
                    .HasColumnName("physio_balance");

                entity.Property(e => e.PhysiotherapyBalance)
                    .HasMaxLength(255)
                    .HasColumnName("physiotherapy_balance");

                entity.Property(e => e.Picpath)
                    .HasMaxLength(255)
                    .HasColumnName("picpath");

                entity.Property(e => e.PrimaryProviderId)
                    .HasMaxLength(255)
                    .HasColumnName("primary_provider_id");

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(255)
                    .HasColumnName("principal_id");

                entity.Property(e => e.PsychologyBalance)
                    .HasMaxLength(255)
                    .HasColumnName("psychology_balance");

                entity.Property(e => e.RadBalance)
                    .HasMaxLength(255)
                    .HasColumnName("rad_balance");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.RelationshipType)
                    .HasMaxLength(255)
                    .HasColumnName("relationship_type");

                entity.Property(e => e.RxMemberId)
                    .HasMaxLength(255)
                    .HasColumnName("rx_member_id");

                entity.Property(e => e.Sex)
                    .HasMaxLength(255)
                    .HasColumnName("sex");

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(255)
                    .HasColumnName("staff_no");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.StatusReason)
                    .HasMaxLength(255)
                    .HasColumnName("status_reason");

                entity.Property(e => e.StatusUpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("status_update_time");

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .HasColumnName("surname");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("sync_batch_no");

                entity.Property(e => e.SyncBatchNoDelete)
                    .HasMaxLength(255)
                    .HasColumnName("sync_batch_no_delete");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(255)
                    .HasColumnName("sync_batch_no_update");

                entity.Property(e => e.SyncDelete).HasColumnName("sync_delete");

                entity.Property(e => e.SyncInsert).HasColumnName("sync_insert");

                entity.Property(e => e.SyncInsertCounts).HasColumnName("sync_insert_counts");

                entity.Property(e => e.SyncUpdate).HasColumnName("sync_update");

                entity.Property(e => e.SyncUpdateCounts).HasColumnName("sync_update_counts");

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(255)
                    .HasColumnName("telephone_no");

                entity.Property(e => e.UpdateStatus)
                    .HasMaxLength(255)
                    .HasColumnName("update_status");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(255)
                    .HasColumnName("update_user");

                entity.Property(e => e.UsePrimaryId)
                    .HasMaxLength(255)
                    .HasColumnName("use_primary_id");
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

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1");
            });

            modelBuilder.Entity<Table2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_2");
            });

            modelBuilder.Entity<Table3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_3");
            });

            modelBuilder.Entity<Table4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_4");
            });

            modelBuilder.Entity<TaxTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TaxTable");
            });

            modelBuilder.Entity<Temp3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(50)
                    .HasColumnName("process_claim_no");
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

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("TransactionType");

                entity.Property(e => e.Descriptoin).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TreatToDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TreatToDelete");

                entity.Property(e => e.ClaimId).HasColumnName("claimId");
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
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

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
