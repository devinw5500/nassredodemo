using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NASS_Redo_Site.Models
{
    public partial class NASS_RedoContext : DbContext
    {
        public NASS_RedoContext()
        {
        }

        public NASS_RedoContext(DbContextOptions<NASS_RedoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressLine> AddressLine { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CityCounty> CityCounty { get; set; }
        public virtual DbSet<CityZip> CityZip { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientOrg> ClientOrg { get; set; }
        public virtual DbSet<ClientPerm> ClientPerm { get; set; }
        public virtual DbSet<ColInCounty> ColInCounty { get; set; }
        public virtual DbSet<ColInMunicipality> ColInMunicipality { get; set; }
        public virtual DbSet<ColInSchool> ColInSchool { get; set; }
        public virtual DbSet<Conversation> Conversation { get; set; }
        public virtual DbSet<ConvoInFile> ConvoInFile { get; set; }
        public virtual DbSet<County> County { get; set; }
        public virtual DbSet<CountyNote> CountyNote { get; set; }
        public virtual DbSet<CountyZip> CountyZip { get; set; }
        public virtual DbSet<CurrentStatus> CurrentStatus { get; set; }
        public virtual DbSet<DateSet> DateSet { get; set; }
        public virtual DbSet<EmpGroup> EmpGroup { get; set; }
        public virtual DbSet<EmpRole> EmpRole { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeOnOrder> EmployeeOnOrder { get; set; }
        public virtual DbSet<FlowItem> FlowItem { get; set; }
        public virtual DbSet<FlowItemList> FlowItemList { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<ItemInList> ItemInList { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MunInCounty> MunInCounty { get; set; }
        public virtual DbSet<Municipality> Municipality { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderClient> OrderClient { get; set; }
        public virtual DbSet<OrderComment> OrderComment { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderProductList> OrderProductList { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<OrderType> OrderType { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<ParcelId> ParcelId { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonContact> PersonContact { get; set; }
        public virtual DbSet<PersonEmail> PersonEmail { get; set; }
        public virtual DbSet<PersonInfo> PersonInfo { get; set; }
        public virtual DbSet<PersonPhone> PersonPhone { get; set; }
        public virtual DbSet<PersonSensitive> PersonSensitive { get; set; }
        public virtual DbSet<ProdInGroup> ProdInGroup { get; set; }
        public virtual DbSet<ProdListOrganization> ProdListOrganization { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductGroup> ProductGroup { get; set; }
        public virtual DbSet<ProductInList> ProductInList { get; set; }
        public virtual DbSet<ProductInOrder> ProductInOrder { get; set; }
        public virtual DbSet<ProductInfo> ProductInfo { get; set; }
        public virtual DbSet<ProductOrderDetail> ProductOrderDetail { get; set; }
        public virtual DbSet<ProductStatus> ProductStatus { get; set; }
        public virtual DbSet<PropertyForOrder> PropertyForOrder { get; set; }
        public virtual DbSet<RecProductList> RecProductList { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<ReportDateDetails> ReportDateDetails { get; set; }
        public virtual DbSet<ReportDetails> ReportDetails { get; set; }
        public virtual DbSet<ReportEmail> ReportEmail { get; set; }
        public virtual DbSet<ReportFromDate> ReportFromDate { get; set; }
        public virtual DbSet<ReportOnClient> ReportOnClient { get; set; }
        public virtual DbSet<ReportOnEmployee> ReportOnEmployee { get; set; }
        public virtual DbSet<ReportOnOrder> ReportOnOrder { get; set; }
        public virtual DbSet<ReportOnProduct> ReportOnProduct { get; set; }
        public virtual DbSet<ReportOnTaxCol> ReportOnTaxCol { get; set; }
        public virtual DbSet<ReportOnVendor> ReportOnVendor { get; set; }
        public virtual DbSet<ReportThroughDate> ReportThroughDate { get; set; }
        public virtual DbSet<ReportTypes> ReportTypes { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SchoolDistrict> SchoolDistrict { get; set; }
        public virtual DbSet<SchoolInAddress> SchoolInAddress { get; set; }
        public virtual DbSet<Specification> Specification { get; set; }
        public virtual DbSet<SpecificationList> SpecificationList { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StatusForOrder> StatusForOrder { get; set; }
        public virtual DbSet<TaxCollector> TaxCollector { get; set; }
        public virtual DbSet<TaxCollectorFee> TaxCollectorFee { get; set; }
        public virtual DbSet<TaxCollectorInChargeOf> TaxCollectorInChargeOf { get; set; }
        public virtual DbSet<TaxCollectorInfo> TaxCollectorInfo { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }
        public virtual DbSet<TransactionTypeDetails> TransactionTypeDetails { get; set; }
        public virtual DbSet<TransactionTypeSpecifications> TransactionTypeSpecifications { get; set; }
        public virtual DbSet<TypeOfReport> TypeOfReport { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserInConvo> UserInConvo { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorDetails> VendorDetails { get; set; }
        public virtual DbSet<VendorSensitive> VendorSensitive { get; set; }
        public virtual DbSet<VendorStatus> VendorStatus { get; set; }
        public virtual DbSet<VendorStatusTracker> VendorStatusTracker { get; set; }
        public virtual DbSet<VendorType> VendorType { get; set; }
        public virtual DbSet<Workflow> Workflow { get; set; }
        public virtual DbSet<WorkflowDetails> WorkflowDetails { get; set; }
        public virtual DbSet<WorkflowGroup> WorkflowGroup { get; set; }
        public virtual DbSet<WorkflowGroupItem> WorkflowGroupItem { get; set; }
        public virtual DbSet<Zip> Zip { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=NASS_Redo;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address", "Address");

                entity.HasIndex(e => e.CityId)
                    .HasName("fkIdx_345");

                entity.HasIndex(e => e.CountyId)
                    .HasName("fkIdx_348");

                entity.HasIndex(e => e.ZipId)
                    .HasName("fkIdx_351");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountyId).HasColumnName("CountyID");

                entity.Property(e => e.ZipId).HasColumnName("ZipID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKCity_Address");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKCounty_Address");

                entity.HasOne(d => d.Zip)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.ZipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKZIP_Address");
            });

            modelBuilder.Entity<AddressLine>(entity =>
            {
                entity.ToTable("AddressLine", "Address");

                entity.HasIndex(e => e.AddrId)
                    .HasName("fkIdx_305");

                entity.Property(e => e.AddressLineId).HasColumnName("AddressLineID");

                entity.Property(e => e.AddrId).HasColumnName("AddrID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasColumnName("AddressLine")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Addr)
                    .WithMany(p => p.AddressLine)
                    .HasForeignKey(d => d.AddrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKAddress_AddressLine");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City", "Address");

                entity.HasIndex(e => e.StateId)
                    .HasName("fkIdx_360");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKState_City");
            });

            modelBuilder.Entity<CityCounty>(entity =>
            {
                entity.ToTable("CityCounty", "Address");

                entity.HasIndex(e => e.CityId)
                    .HasName("fkIdx_1123");

                entity.HasIndex(e => e.CountyId)
                    .HasName("fkIdx_1120");

                entity.Property(e => e.CityCountyId)
                    .HasColumnName("CityCountyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountyId).HasColumnName("CountyID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CityCounty)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1123");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.CityCounty)
                    .HasForeignKey(d => d.CountyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1120");
            });

            modelBuilder.Entity<CityZip>(entity =>
            {
                entity.ToTable("CityZip", "Address");

                entity.HasIndex(e => e.CityId)
                    .HasName("fkIdx_1109");

                entity.HasIndex(e => e.Zipid)
                    .HasName("fkIdx_1112");

                entity.Property(e => e.CityZipId)
                    .HasColumnName("CityZipID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Zipid).HasColumnName("ZIPID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CityZip)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1109");

                entity.HasOne(d => d.Zip)
                    .WithMany(p => p.CityZip)
                    .HasForeignKey(d => d.Zipid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1112");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client", "People");

                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_494");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_494");
            });

            modelBuilder.Entity<ClientOrg>(entity =>
            {
                entity.ToTable("ClientOrg", "People");

                entity.HasIndex(e => e.ClientId)
                    .HasName("fkIdx_497");

                entity.HasIndex(e => e.OrgId)
                    .HasName("fkIdx_500");

                entity.Property(e => e.ClientOrgId).HasColumnName("ClientOrgID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientOrg)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_497");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.ClientOrg)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_500");
            });

            modelBuilder.Entity<ClientPerm>(entity =>
            {
                entity.ToTable("ClientPerm", "People");

                entity.HasIndex(e => e.ClientId)
                    .HasName("fkIdx_1139");

                entity.HasIndex(e => e.PermissionsId)
                    .HasName("fkIdx_1136");

                entity.Property(e => e.ClientPermId).HasColumnName("ClientPermID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.PermissionsId).HasColumnName("PermissionsID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientPerm)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1139");

                entity.HasOne(d => d.Permissions)
                    .WithMany(p => p.ClientPerm)
                    .HasForeignKey(d => d.PermissionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1136");
            });

            modelBuilder.Entity<ColInCounty>(entity =>
            {
                entity.ToTable("ColInCounty", "People");

                entity.HasIndex(e => e.CountyId)
                    .HasName("fkIdx_639");

                entity.HasIndex(e => e.TaxColChargeId)
                    .HasName("fkIdx_610");

                entity.Property(e => e.ColInCountyId).HasColumnName("ColInCountyID");

                entity.Property(e => e.CountyId).HasColumnName("CountyID");

                entity.Property(e => e.TaxColChargeId).HasColumnName("TaxColChargeID");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.ColInCounty)
                    .HasForeignKey(d => d.CountyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_639");

                entity.HasOne(d => d.TaxColCharge)
                    .WithMany(p => p.ColInCounty)
                    .HasForeignKey(d => d.TaxColChargeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_610");
            });

            modelBuilder.Entity<ColInMunicipality>(entity =>
            {
                entity.ToTable("ColInMunicipality", "Vendor");

                entity.HasIndex(e => e.MunId)
                    .HasName("fkIdx_624");

                entity.HasIndex(e => e.TaxColChargeId)
                    .HasName("fkIdx_616");

                entity.Property(e => e.ColInMunicipalityId).HasColumnName("ColInMunicipalityID");

                entity.Property(e => e.MunId).HasColumnName("MunID");

                entity.Property(e => e.TaxColChargeId).HasColumnName("TaxColChargeID");

                entity.HasOne(d => d.Mun)
                    .WithMany(p => p.ColInMunicipality)
                    .HasForeignKey(d => d.MunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_624");

                entity.HasOne(d => d.TaxColCharge)
                    .WithMany(p => p.ColInMunicipality)
                    .HasForeignKey(d => d.TaxColChargeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_616");
            });

            modelBuilder.Entity<ColInSchool>(entity =>
            {
                entity.ToTable("ColInSchool", "Vendor");

                entity.HasIndex(e => e.SchoolId)
                    .HasName("fkIdx_631");

                entity.HasIndex(e => e.TaxColChargeId)
                    .HasName("fkIdx_613");

                entity.Property(e => e.ColInSchoolId).HasColumnName("ColInSchoolID");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.TaxColChargeId).HasColumnName("TaxColChargeID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.ColInSchool)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_631");

                entity.HasOne(d => d.TaxColCharge)
                    .WithMany(p => p.ColInSchool)
                    .HasForeignKey(d => d.TaxColChargeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_613");
            });

            modelBuilder.Entity<Conversation>(entity =>
            {
                entity.ToTable("Conversation", "Social");

                entity.Property(e => e.ConversationId).HasColumnName("ConversationID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConvoInFile>(entity =>
            {
                entity.ToTable("ConvoInFile", "Social");

                entity.HasIndex(e => e.ConvoId)
                    .HasName("fkIdx_562");

                entity.Property(e => e.ConvoInFileId).HasColumnName("ConvoInFileID");

                entity.Property(e => e.ConvoId).HasColumnName("ConvoID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.HasOne(d => d.Convo)
                    .WithMany(p => p.ConvoInFile)
                    .HasForeignKey(d => d.ConvoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_562");
            });

            modelBuilder.Entity<County>(entity =>
            {
                entity.ToTable("County", "Address");

                entity.HasIndex(e => e.StateId)
                    .HasName("fkIdx_357");

                entity.Property(e => e.CountyId).HasColumnName("CountyID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.County)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKState_County");
            });

            modelBuilder.Entity<CountyNote>(entity =>
            {
                entity.ToTable("CountyNote", "Address");

                entity.HasIndex(e => e.CountyId)
                    .HasName("fkIdx_1241");

                entity.Property(e => e.CountyNoteId)
                    .HasColumnName("CountyNoteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountyId).HasColumnName("CountyID");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.County)
                    .WithMany(p => p.CountyNote)
                    .HasForeignKey(d => d.CountyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1241");
            });

            modelBuilder.Entity<CountyZip>(entity =>
            {
                entity.ToTable("CountyZip", "Address");

                entity.HasIndex(e => e.CountyId)
                    .HasName("fkIdx_1100");

                entity.HasIndex(e => e.Zipid)
                    .HasName("fkIdx_1103");

                entity.Property(e => e.CountyZipId)
                    .HasColumnName("CountyZipID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountyId).HasColumnName("CountyID");

                entity.Property(e => e.Zipid).HasColumnName("ZIPID");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.CountyZip)
                    .HasForeignKey(d => d.CountyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1100");

                entity.HasOne(d => d.Zip)
                    .WithMany(p => p.CountyZip)
                    .HasForeignKey(d => d.Zipid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1103");
            });

            modelBuilder.Entity<CurrentStatus>(entity =>
            {
                entity.ToTable("CurrentStatus", "Social");

                entity.HasIndex(e => e.StatusId)
                    .HasName("fkIdx_510");

                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_513");

                entity.Property(e => e.CurrentStatusId).HasColumnName("CurrentStatusID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.CurrentStatus)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_510");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CurrentStatus)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_513");
            });

            modelBuilder.Entity<DateSet>(entity =>
            {
                entity.ToTable("DateSet", "Address");

                entity.HasIndex(e => e.AddrId)
                    .HasName("fkIdx_337");

                entity.Property(e => e.DateSetId).HasColumnName("DateSetID");

                entity.Property(e => e.AddrId).HasColumnName("AddrID");

                entity.Property(e => e.RenewDate).HasColumnType("date");

                entity.Property(e => e.SetDate).HasColumnType("date");

                entity.HasOne(d => d.Addr)
                    .WithMany(p => p.DateSet)
                    .HasForeignKey(d => d.AddrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKAddress_DateSet");
            });

            modelBuilder.Entity<EmpGroup>(entity =>
            {
                entity.ToTable("EmpGroup", "People");

                entity.HasIndex(e => e.EmpId)
                    .HasName("fkIdx_488");

                entity.HasIndex(e => e.GroupId)
                    .HasName("fkIdx_438");

                entity.Property(e => e.EmpGroupId).HasColumnName("EmpGroupID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpGroup)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_488");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.EmpGroup)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_438");
            });

            modelBuilder.Entity<EmpRole>(entity =>
            {
                entity.ToTable("EmpRole", "People");

                entity.HasIndex(e => e.EmpId)
                    .HasName("fkIdx_485");

                entity.HasIndex(e => e.RoleId)
                    .HasName("fkIdx_441");

                entity.Property(e => e.EmpRoleId).HasColumnName("EmpRoleID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpRole)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_485");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.EmpRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_441");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee", "People");

                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_491");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_491");
            });

            modelBuilder.Entity<EmployeeOnOrder>(entity =>
            {
                entity.ToTable("EmployeeOnOrder", "Order");

                entity.HasIndex(e => e.OrderDetailsId)
                    .HasName("fkIdx_1036");

                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_1039");

                entity.Property(e => e.EmployeeOnOrderId).HasColumnName("EmployeeOnOrderID");

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.OrderDetails)
                    .WithMany(p => p.EmployeeOnOrder)
                    .HasForeignKey(d => d.OrderDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1036");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmployeeOnOrder)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1039");
            });

            modelBuilder.Entity<FlowItem>(entity =>
            {
                entity.ToTable("FlowItem", "Product");

                entity.Property(e => e.FlowItemId).HasColumnName("FlowItemID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlowItemList>(entity =>
            {
                entity.ToTable("FlowItemList", "Product");

                entity.HasIndex(e => e.WorkflowDetailsId)
                    .HasName("fkIdx_778");

                entity.Property(e => e.FlowItemListId).HasColumnName("FlowItemListID");

                entity.Property(e => e.WorkflowDetailsId).HasColumnName("WorkflowDetailsID");

                entity.HasOne(d => d.WorkflowDetails)
                    .WithMany(p => p.FlowItemList)
                    .HasForeignKey(d => d.WorkflowDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_778");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("Group", "People");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemInList>(entity =>
            {
                entity.ToTable("ItemInList", "Product");

                entity.HasIndex(e => e.FlowItemId)
                    .HasName("fkIdx_787");

                entity.HasIndex(e => e.FlowItemListId)
                    .HasName("fkIdx_784");

                entity.Property(e => e.ItemInListId).HasColumnName("ItemInListID");

                entity.Property(e => e.FlowItemId).HasColumnName("FlowItemID");

                entity.Property(e => e.FlowItemListId).HasColumnName("FlowItemListID");

                entity.HasOne(d => d.FlowItem)
                    .WithMany(p => p.ItemInList)
                    .HasForeignKey(d => d.FlowItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_787");

                entity.HasOne(d => d.FlowItemList)
                    .WithMany(p => p.ItemInList)
                    .HasForeignKey(d => d.FlowItemListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_784");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message", "Social");

                entity.HasIndex(e => e.ConvoId)
                    .HasName("fkIdx_544");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConvoId).HasColumnName("ConvoID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserSentId).HasColumnName("UserSentID");

                entity.HasOne(d => d.Convo)
                    .WithMany(p => p.Message)
                    .HasForeignKey(d => d.ConvoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_544");
            });

            modelBuilder.Entity<MunInCounty>(entity =>
            {
                entity.HasKey(e => e.MunInAddressId)
                    .HasName("PK_MunInAddress");

                entity.ToTable("MunInCounty", "Address");

                entity.HasIndex(e => e.CountyId)
                    .HasName("fkIdx_658");

                entity.HasIndex(e => e.MunId)
                    .HasName("fkIdx_655");

                entity.Property(e => e.MunInAddressId).HasColumnName("MunInAddressID");

                entity.Property(e => e.CountyId).HasColumnName("CountyID");

                entity.Property(e => e.MunId).HasColumnName("MunID");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.MunInCounty)
                    .HasForeignKey(d => d.CountyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_655");

                entity.HasOne(d => d.Mun)
                    .WithMany(p => p.MunInCounty)
                    .HasForeignKey(d => d.MunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MunInCounty_Municipality");
            });

            modelBuilder.Entity<Municipality>(entity =>
            {
                entity.ToTable("Municipality", "Address");

                entity.Property(e => e.MunicipalityId).HasColumnName("MunicipalityID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Municipality)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Municipality_State");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order", "Order");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderUid)
                    .IsRequired()
                    .HasColumnName("OrderUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderClient>(entity =>
            {
                entity.ToTable("OrderClient", "Order");

                entity.HasIndex(e => e.OrderDetailsId)
                    .HasName("fkIdx_847");

                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_850");

                entity.Property(e => e.OrderClientId)
                    .HasColumnName("OrderClientID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.OrderDetails)
                    .WithMany(p => p.OrderClient)
                    .HasForeignKey(d => d.OrderDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_847");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderClient)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_850");
            });

            modelBuilder.Entity<OrderComment>(entity =>
            {
                entity.ToTable("OrderComment", "Order");

                entity.HasIndex(e => e.OrderDetailsId)
                    .HasName("fkIdx_1233");

                entity.Property(e => e.OrderCommentId)
                    .HasColumnName("OrderCommentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.HasOne(d => d.OrderDetails)
                    .WithMany(p => p.OrderComment)
                    .HasForeignKey(d => d.OrderDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1233");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.ToTable("OrderDetails", "Order");

                entity.HasIndex(e => e.OrderId)
                    .HasName("fkIdx_853");

                entity.HasIndex(e => e.OrderTypeId)
                    .HasName("fkIdx_1130");

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderTypeId).HasColumnName("OrderTypeID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransactionTypeDetailsId).HasColumnName("TransactionTypeDetailsID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_853");

                entity.HasOne(d => d.OrderType)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1130");

                entity.HasOne(d => d.TransactionTypeDetails)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.TransactionTypeDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_TransactionTypeDetails");
            });

            modelBuilder.Entity<OrderProductList>(entity =>
            {
                entity.ToTable("OrderProductList", "Order");

                entity.HasIndex(e => e.OrderDetailsId)
                    .HasName("fkIdx_861");

                entity.Property(e => e.OrderProductListId).HasColumnName("OrderProductListID");

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.HasOne(d => d.OrderDetails)
                    .WithMany(p => p.OrderProductList)
                    .HasForeignKey(d => d.OrderDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_861");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus", "Order");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.ToTable("OrderType", "Order");

                entity.Property(e => e.OrderTypeId).HasColumnName("OrderTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("Organization", "People");

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.Property(e => e.AddrId).HasColumnName("AddrID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ParcelId>(entity =>
            {
                entity.HasKey(e => e.ParcelId1);

                entity.ToTable("ParcelID", "Address");

                entity.HasIndex(e => e.AddrId)
                    .HasName("fkIdx_647");

                entity.Property(e => e.ParcelId1).HasColumnName("ParcelID");

                entity.Property(e => e.AddrId).HasColumnName("AddrID");

                entity.Property(e => e.Parcel)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Addr)
                    .WithMany(p => p.ParcelId)
                    .HasForeignKey(d => d.AddrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_647");
            });

            modelBuilder.Entity<Permissions>(entity =>
            {
                entity.ToTable("Permissions", "Admin");

                entity.Property(e => e.PermissionsId).HasColumnName("PermissionsID");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person", "People");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.UniqueUserId)
                    .HasColumnName("UniqueUserID")
                    .HasMaxLength(110)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonContact>(entity =>
            {
                entity.ToTable("PersonContact", "People");

                entity.HasIndex(e => e.PersonInfoId)
                    .HasName("fkIdx_396")
                    .IsUnique();

                entity.Property(e => e.PersonContactId).HasColumnName("PersonContactID");

                entity.Property(e => e.PersonInfoId).HasColumnName("PersonInfoID");

                entity.HasOne(d => d.PersonInfo)
                    .WithOne(p => p.PersonContact)
                    .HasForeignKey<PersonContact>(d => d.PersonInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPersonInfo_PersonContact");
            });

            modelBuilder.Entity<PersonEmail>(entity =>
            {
                entity.ToTable("PersonEmail", "People");

                entity.HasIndex(e => e.PersonContactId)
                    .HasName("fkIdx_402");

                entity.Property(e => e.PersonEmailId).HasColumnName("PersonEmailID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersonContactId).HasColumnName("PersonContactID");

                entity.HasOne(d => d.PersonContact)
                    .WithMany(p => p.PersonEmail)
                    .HasForeignKey(d => d.PersonContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPersonContact_PersonEmail");
            });

            modelBuilder.Entity<PersonInfo>(entity =>
            {
                entity.ToTable("PersonInfo", "People");

                entity.HasIndex(e => e.AddrId)
                    .HasName("fkIdx_405");

                entity.HasIndex(e => e.PersonId)
                    .HasName("fkIdx_392");

                entity.Property(e => e.PersonInfoId).HasColumnName("PersonInfoID");

                entity.Property(e => e.AddrId).HasColumnName("AddrID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleInitial)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Addr)
                    .WithMany(p => p.PersonInfo)
                    .HasForeignKey(d => d.AddrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKAddress_PersonInfo");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonInfo)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPerson_PersonInfo");
            });

            modelBuilder.Entity<PersonPhone>(entity =>
            {
                entity.ToTable("PersonPhone", "People");

                entity.HasIndex(e => e.PersonContactId)
                    .HasName("fkIdx_399");

                entity.Property(e => e.PersonPhoneId).HasColumnName("PersonPhoneID");

                entity.Property(e => e.PersonContactId).HasColumnName("PersonContactID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.PersonContact)
                    .WithMany(p => p.PersonPhone)
                    .HasForeignKey(d => d.PersonContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPersonContact_PersonPhone");
            });

            modelBuilder.Entity<PersonSensitive>(entity =>
            {
                entity.ToTable("PersonSensitive", "People");

                entity.HasIndex(e => e.PersonInfoId)
                    .HasName("fkIdx_522");

                entity.Property(e => e.PersonSensitiveId).HasColumnName("PersonSensitiveID");

                entity.Property(e => e.HashedSsn)
                    .IsRequired()
                    .HasColumnName("HashedSSN")
                    .HasMaxLength(50);

                entity.Property(e => e.PersonInfoId).HasColumnName("PersonInfoID");

                entity.HasOne(d => d.PersonInfo)
                    .WithMany(p => p.PersonSensitive)
                    .HasForeignKey(d => d.PersonInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_522");
            });

            modelBuilder.Entity<ProdInGroup>(entity =>
            {
                entity.ToTable("ProdInGroup", "Product");

                entity.HasIndex(e => e.GroupId)
                    .HasName("fkIdx_724");

                entity.HasIndex(e => e.ProductId)
                    .HasName("fkIdx_721");

                entity.Property(e => e.ProdInGroupId).HasColumnName("ProdInGroupID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ProdInGroup)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_724");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProdInGroup)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_721");
            });

            modelBuilder.Entity<ProdListOrganization>(entity =>
            {
                entity.ToTable("ProdListOrganization", "Product");

                entity.HasIndex(e => e.OrgId)
                    .HasName("fkIdx_767");

                entity.HasIndex(e => e.ProdListId)
                    .HasName("fkIdx_753");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.ProdListId).HasColumnName("ProdListID");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.ProdListOrganization)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_767");

                entity.HasOne(d => d.ProdList)
                    .WithMany(p => p.ProdListOrganization)
                    .HasForeignKey(d => d.ProdListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_753");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductUid)
                    .IsRequired()
                    .HasColumnName("ProductUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.ToTable("ProductGroup", "Product");

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductInList>(entity =>
            {
                entity.ToTable("ProductInList", "Product");

                entity.HasIndex(e => e.ListId)
                    .HasName("fkIdx_764");

                entity.HasIndex(e => e.ProdId)
                    .HasName("fkIdx_761");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.ProductInList)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_764");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ProductInList)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_761");
            });

            modelBuilder.Entity<ProductInOrder>(entity =>
            {
                entity.ToTable("ProductInOrder", "Order");

                entity.HasIndex(e => e.OrderListId)
                    .HasName("fkIdx_872");

                entity.HasIndex(e => e.ProductOrderedId)
                    .HasName("fkIdx_883");

                entity.Property(e => e.ProductInOrderId).HasColumnName("ProductInOrderID");

                entity.Property(e => e.OrderListId).HasColumnName("OrderListID");

                entity.Property(e => e.ProductOrderedId).HasColumnName("ProductOrderedID");

                entity.HasOne(d => d.OrderList)
                    .WithMany(p => p.ProductInOrder)
                    .HasForeignKey(d => d.OrderListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_872");

                entity.HasOne(d => d.ProductOrdered)
                    .WithMany(p => p.ProductInOrder)
                    .HasForeignKey(d => d.ProductOrderedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_883");
            });

            modelBuilder.Entity<ProductInfo>(entity =>
            {
                entity.ToTable("ProductInfo", "Product");

                entity.HasIndex(e => e.ProductId)
                    .HasName("fkIdx_682");

                entity.Property(e => e.ProductInfoId).HasColumnName("ProductInfoID");

                entity.Property(e => e.BaseCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductStatusId).HasColumnName("ProductStatusID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductInfo)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductInfo_Product");

                entity.HasOne(d => d.ProductStatus)
                    .WithMany(p => p.ProductInfo)
                    .HasForeignKey(d => d.ProductStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_682");
            });

            modelBuilder.Entity<ProductOrderDetail>(entity =>
            {
                entity.ToTable("ProductOrderDetail", "Order");

                entity.HasIndex(e => e.ProductId)
                    .HasName("fkIdx_886");

                entity.HasIndex(e => e.WorkflowId)
                    .HasName("fkIdx_889");

                entity.Property(e => e.ProductOrderDetailId)
                    .HasColumnName("ProductOrderDetailID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductOrderDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_886");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.ProductOrderDetail)
                    .HasForeignKey(d => d.WorkflowId)
                    .HasConstraintName("FK_889");
            });

            modelBuilder.Entity<ProductStatus>(entity =>
            {
                entity.ToTable("ProductStatus", "Product");

                entity.Property(e => e.ProductStatusId)
                    .HasColumnName("ProductStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PropertyForOrder>(entity =>
            {
                entity.HasKey(e => e.PropertyForOrder1)
                    .HasName("PK_propertyfororder");

                entity.ToTable("PropertyForOrder", "Order");

                entity.HasIndex(e => e.AddressId)
                    .HasName("fkIdx_1226");

                entity.HasIndex(e => e.OrderDetailsId)
                    .HasName("fkIdx_1223");

                entity.Property(e => e.PropertyForOrder1)
                    .HasColumnName("PropertyForOrder")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.PropertyForOrder)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1226");

                entity.HasOne(d => d.OrderDetails)
                    .WithMany(p => p.PropertyForOrder)
                    .HasForeignKey(d => d.OrderDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1223");
            });

            modelBuilder.Entity<RecProductList>(entity =>
            {
                entity.ToTable("RecProductList", "Product");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report", "Report");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<ReportDateDetails>(entity =>
            {
                entity.ToTable("ReportDateDetails", "Report");

                entity.HasIndex(e => e.ReportDetailsId)
                    .HasName("fkIdx_1157");

                entity.Property(e => e.ReportDateDetailsId)
                    .HasColumnName("ReportDateDetailsID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ReportDetailsId).HasColumnName("ReportDetailsID");

                entity.Property(e => e.ThroughDate).HasColumnType("datetime");

                entity.HasOne(d => d.ReportDetails)
                    .WithMany(p => p.ReportDateDetails)
                    .HasForeignKey(d => d.ReportDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1157");
            });

            modelBuilder.Entity<ReportDetails>(entity =>
            {
                entity.ToTable("ReportDetails", "Report");

                entity.HasIndex(e => e.ReportFromDateId)
                    .HasName("fkIdx_1048");

                entity.HasIndex(e => e.ReportId)
                    .HasName("fkIdx_998");

                entity.HasIndex(e => e.ReportThroughDateId)
                    .HasName("fkIdx_1051");

                entity.Property(e => e.ReportDetailsId).HasColumnName("ReportDetailsID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportFromDateId).HasColumnName("ReportFromDateID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ReportThroughDateId).HasColumnName("ReportThroughDateID");

                entity.HasOne(d => d.ReportFromDate)
                    .WithMany(p => p.ReportDetails)
                    .HasForeignKey(d => d.ReportFromDateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1048");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportDetails)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_998");

                entity.HasOne(d => d.ReportThroughDate)
                    .WithMany(p => p.ReportDetails)
                    .HasForeignKey(d => d.ReportThroughDateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1051");
            });

            modelBuilder.Entity<ReportEmail>(entity =>
            {
                entity.ToTable("ReportEmail", "Report");

                entity.HasIndex(e => e.ReportDetailsId)
                    .HasName("fkIdx_1023");

                entity.Property(e => e.ReportEmailId).HasColumnName("ReportEmailID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDetailsId).HasColumnName("ReportDetailsID");

                entity.HasOne(d => d.ReportDetails)
                    .WithMany(p => p.ReportEmail)
                    .HasForeignKey(d => d.ReportDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1023");
            });

            modelBuilder.Entity<ReportFromDate>(entity =>
            {
                entity.ToTable("ReportFromDate", "Report");

                entity.Property(e => e.ReportFromDateId)
                    .HasColumnName("ReportFromDateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportOnClient>(entity =>
            {
                entity.ToTable("ReportOnClient", "Report");

                entity.HasIndex(e => e.ClientId)
                    .HasName("fkIdx_1063");

                entity.HasIndex(e => e.ReportDetailsId)
                    .HasName("fkIdx_1010");

                entity.Property(e => e.ReportOnClientId).HasColumnName("ReportOnClientID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ReportDetailsId).HasColumnName("ReportDetailsID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ReportOnClient)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1063");

                entity.HasOne(d => d.ReportDetails)
                    .WithMany(p => p.ReportOnClient)
                    .HasForeignKey(d => d.ReportDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1010");
            });

            modelBuilder.Entity<ReportOnEmployee>(entity =>
            {
                entity.ToTable("ReportOnEmployee", "Report");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("fkIdx_1054");

                entity.HasIndex(e => e.ReportDetailsId)
                    .HasName("fkIdx_1007");

                entity.Property(e => e.ReportOnEmployeeId).HasColumnName("ReportOnEmployeeID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ReportDetailsId).HasColumnName("ReportDetailsID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ReportOnEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1054");

                entity.HasOne(d => d.ReportDetails)
                    .WithMany(p => p.ReportOnEmployee)
                    .HasForeignKey(d => d.ReportDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1007");
            });

            modelBuilder.Entity<ReportOnOrder>(entity =>
            {
                entity.ToTable("ReportOnOrder", "Report");

                entity.HasIndex(e => e.OrderId)
                    .HasName("fkIdx_1066");

                entity.HasIndex(e => e.ReportDetailsId)
                    .HasName("fkIdx_1013");

                entity.Property(e => e.ReportOnOrderId).HasColumnName("ReportOnOrderID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ReportDetailsId).HasColumnName("ReportDetailsID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ReportOnOrder)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1066");

                entity.HasOne(d => d.ReportDetails)
                    .WithMany(p => p.ReportOnOrder)
                    .HasForeignKey(d => d.ReportDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1013");
            });

            modelBuilder.Entity<ReportOnProduct>(entity =>
            {
                entity.ToTable("ReportOnProduct", "Report");

                entity.HasIndex(e => e.ProductId)
                    .HasName("fkIdx_1069");

                entity.HasIndex(e => e.ReportDetailsId)
                    .HasName("fkIdx_1016");

                entity.Property(e => e.ReportOnProductId).HasColumnName("ReportOnProductID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ReportDetailsId).HasColumnName("ReportDetailsID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ReportOnProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1069");

                entity.HasOne(d => d.ReportDetails)
                    .WithMany(p => p.ReportOnProduct)
                    .HasForeignKey(d => d.ReportDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1016");
            });

            modelBuilder.Entity<ReportOnTaxCol>(entity =>
            {
                entity.ToTable("ReportOnTaxCol", "Report");

                entity.HasIndex(e => e.ReportDetailsId)
                    .HasName("fkIdx_1004");

                entity.HasIndex(e => e.TaxCollectorId)
                    .HasName("fkIdx_1057");

                entity.Property(e => e.ReportOnTaxColId).HasColumnName("ReportOnTaxColID");

                entity.Property(e => e.ReportDetailsId).HasColumnName("ReportDetailsID");

                entity.Property(e => e.TaxCollectorId).HasColumnName("TaxCollectorID");

                entity.HasOne(d => d.ReportDetails)
                    .WithMany(p => p.ReportOnTaxCol)
                    .HasForeignKey(d => d.ReportDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1004");

                entity.HasOne(d => d.TaxCollector)
                    .WithMany(p => p.ReportOnTaxCol)
                    .HasForeignKey(d => d.TaxCollectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1057");
            });

            modelBuilder.Entity<ReportOnVendor>(entity =>
            {
                entity.ToTable("ReportOnVendor", "Report");

                entity.HasIndex(e => e.ReportDetailsId)
                    .HasName("fkIdx_1001");

                entity.HasIndex(e => e.VendorId)
                    .HasName("fkIdx_1060");

                entity.Property(e => e.ReportOnVendorId).HasColumnName("ReportOnVendorID");

                entity.Property(e => e.ReportDetailsId).HasColumnName("ReportDetailsID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.ReportDetails)
                    .WithMany(p => p.ReportOnVendor)
                    .HasForeignKey(d => d.ReportDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1001");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ReportOnVendor)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1060");
            });

            modelBuilder.Entity<ReportThroughDate>(entity =>
            {
                entity.ToTable("ReportThroughDate", "Report");

                entity.Property(e => e.ReportThroughDateId)
                    .HasColumnName("ReportThroughDateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportTypes>(entity =>
            {
                entity.ToTable("ReportTypes", "Report");

                entity.Property(e => e.ReportTypesId).HasColumnName("ReportTypesID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "People");

                entity.HasIndex(e => e.PermissionsId)
                    .HasName("fkIdx_1088");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionsId).HasColumnName("PermissionsID");

                entity.HasOne(d => d.Permissions)
                    .WithMany(p => p.Role)
                    .HasForeignKey(d => d.PermissionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1088");
            });

            modelBuilder.Entity<SchoolDistrict>(entity =>
            {
                entity.ToTable("SchoolDistrict", "Address");

                entity.HasIndex(e => e.AddrId)
                    .HasName("fkIdx_627");

                entity.Property(e => e.SchoolDistrictId).HasColumnName("SchoolDistrictID");

                entity.Property(e => e.AddrId).HasColumnName("AddrID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Addr)
                    .WithMany(p => p.SchoolDistrict)
                    .HasForeignKey(d => d.AddrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_627");
            });

            modelBuilder.Entity<SchoolInAddress>(entity =>
            {
                entity.ToTable("SchoolInAddress", "Address");

                entity.HasIndex(e => e.AddrId)
                    .HasName("fkIdx_667");

                entity.HasIndex(e => e.SchoolId)
                    .HasName("fkIdx_664");

                entity.Property(e => e.SchoolInAddressId)
                    .HasColumnName("SchoolInAddressID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddrId).HasColumnName("AddrID");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.HasOne(d => d.Addr)
                    .WithMany(p => p.SchoolInAddress)
                    .HasForeignKey(d => d.AddrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_667");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.SchoolInAddress)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_664");
            });

            modelBuilder.Entity<Specification>(entity =>
            {
                entity.ToTable("Specification", "Order");

                entity.HasIndex(e => e.SpecListId)
                    .HasName("fkIdx_901");

                entity.Property(e => e.SpecificationId).HasColumnName("SpecificationID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SpecListId).HasColumnName("SpecListID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SpecList)
                    .WithMany(p => p.Specification)
                    .HasForeignKey(d => d.SpecListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_901");
            });

            modelBuilder.Entity<SpecificationList>(entity =>
            {
                entity.ToTable("SpecificationList", "Order");

                entity.HasIndex(e => e.OrderDetailsId)
                    .HasName("fkIdx_904");

                entity.Property(e => e.SpecificationListId).HasColumnName("SpecificationListID");

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.HasOne(d => d.OrderDetails)
                    .WithMany(p => p.SpecificationList)
                    .HasForeignKey(d => d.OrderDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_904");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State", "Address");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status", "Social");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusForOrder>(entity =>
            {
                entity.ToTable("StatusForOrder", "Order");

                entity.HasIndex(e => e.OrderDetailId)
                    .HasName("fkIdx_838");

                entity.HasIndex(e => e.StatusId)
                    .HasName("fkIdx_835");

                entity.Property(e => e.StatusForOrderId).HasColumnName("StatusForOrderID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.StatusForOrder)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_838");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.StatusForOrder)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_835");
            });

            modelBuilder.Entity<TaxCollector>(entity =>
            {
                entity.ToTable("TaxCollector", "Vendor");

                entity.HasIndex(e => e.PersonId)
                    .HasName("fkIdx_579");

                entity.Property(e => e.TaxCollectorId)
                    .HasColumnName("TaxCollectorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TaxCollector)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_579");
            });

            modelBuilder.Entity<TaxCollectorFee>(entity =>
            {
                entity.ToTable("TaxCollectorFee", "Vendor");

                entity.HasIndex(e => e.TaxColInfoId)
                    .HasName("fkIdx_994");

                entity.Property(e => e.TaxCollectorFeeId).HasColumnName("TaxCollectorFeeID");

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.For)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxColInfoId).HasColumnName("TaxColInfoID");

                entity.HasOne(d => d.TaxColInfo)
                    .WithMany(p => p.TaxCollectorFee)
                    .HasForeignKey(d => d.TaxColInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_994");
            });

            modelBuilder.Entity<TaxCollectorInChargeOf>(entity =>
            {
                entity.ToTable("TaxCollectorInChargeOf", "Vendor");

                entity.HasIndex(e => e.TaxColInfoId)
                    .HasName("fkIdx_591");

                entity.Property(e => e.TaxCollectorInChargeOfId).HasColumnName("TaxCollectorInChargeOfID");

                entity.Property(e => e.TaxColInfoId).HasColumnName("TaxColInfoID");

                entity.HasOne(d => d.TaxColInfo)
                    .WithMany(p => p.TaxCollectorInChargeOf)
                    .HasForeignKey(d => d.TaxColInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_591");
            });

            modelBuilder.Entity<TaxCollectorInfo>(entity =>
            {
                entity.ToTable("TaxCollectorInfo", "Vendor");

                entity.HasIndex(e => e.TaxColId)
                    .HasName("fkIdx_576");

                entity.Property(e => e.TaxCollectorInfoId).HasColumnName("TaxCollectorInfoID");

                entity.Property(e => e.ReturnTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxColId).HasColumnName("TaxColID");

                entity.HasOne(d => d.TaxCol)
                    .WithMany(p => p.TaxCollectorInfo)
                    .HasForeignKey(d => d.TaxColId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_576");
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("TransactionType", "Order");

                entity.Property(e => e.TransactionTypeId)
                    .HasColumnName("TransactionTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransactionTypeDetails>(entity =>
            {
                entity.ToTable("TransactionTypeDetails", "Order");

                entity.HasIndex(e => e.TransactionTypeId)
                    .HasName("fkIdx_1204");

                entity.Property(e => e.TransactionTypeDetailsId)
                    .HasColumnName("TransactionTypeDetailsID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.TransactionTypeDetails)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1204");
            });

            modelBuilder.Entity<TransactionTypeSpecifications>(entity =>
            {
                entity.ToTable("TransactionTypeSpecifications", "Order");

                entity.HasIndex(e => e.TransactionTypeDetailsId)
                    .HasName("fkIdx_1201");

                entity.Property(e => e.TransactionTypeSpecificationsId)
                    .HasColumnName("TransactionTypeSpecificationsID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SpecDetails)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SpecType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionTypeDetailsId).HasColumnName("TransactionTypeDetailsID");

                entity.HasOne(d => d.TransactionTypeDetails)
                    .WithMany(p => p.TransactionTypeSpecifications)
                    .HasForeignKey(d => d.TransactionTypeDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1201");
            });

            modelBuilder.Entity<TypeOfReport>(entity =>
            {
                entity.ToTable("TypeOfReport", "Report");

                entity.HasIndex(e => e.ReportDetailsId)
                    .HasName("fkIdx_940");

                entity.HasIndex(e => e.TypeId)
                    .HasName("fkIdx_937");

                entity.Property(e => e.TypeOfReportId).HasColumnName("TypeOfReportID");

                entity.Property(e => e.ReportDetailsId).HasColumnName("ReportDetailsID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.ReportDetails)
                    .WithMany(p => p.TypeOfReport)
                    .HasForeignKey(d => d.ReportDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_940");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TypeOfReport)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_937");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "People");

                entity.HasIndex(e => e.AspnetuserId)
                    .HasName("fkIdx_451");

                entity.HasIndex(e => e.PersonId)
                    .HasName("fkIdx_447");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AspnetuserId)
                    .IsRequired()
                    .HasColumnName("ASPNETUserID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Aspnetuser)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.AspnetuserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_AspNetUsers");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKPerson_User");
            });

            modelBuilder.Entity<UserInConvo>(entity =>
            {
                entity.ToTable("UserInConvo", "Social");

                entity.HasIndex(e => e.ConvoId)
                    .HasName("fkIdx_554");

                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_547");

                entity.Property(e => e.UserInConvoId).HasColumnName("UserInConvoID");

                entity.Property(e => e.ConvoId).HasColumnName("ConvoID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Convo)
                    .WithMany(p => p.UserInConvo)
                    .HasForeignKey(d => d.ConvoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_554");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserInConvo)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_547");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor", "Vendor");

                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_960");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Vendor)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_960");
            });

            modelBuilder.Entity<VendorDetails>(entity =>
            {
                entity.ToTable("VendorDetails", "Vendor");

                entity.HasIndex(e => e.VendorId)
                    .HasName("fkIdx_1160");

                entity.HasIndex(e => e.VendorSensitiveId)
                    .HasName("fkIdx_986");

                entity.HasIndex(e => e.VendorTypeId)
                    .HasName("fkIdx_972");

                entity.Property(e => e.VendorDetailsId).HasColumnName("VendorDetailsID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.VendorSensitiveId).HasColumnName("VendorSensitiveID");

                entity.Property(e => e.VendorTypeId).HasColumnName("VendorTypeID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorDetails)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_VendorDetails_Vendor");

                entity.HasOne(d => d.VendorSensitive)
                    .WithMany(p => p.VendorDetails)
                    .HasForeignKey(d => d.VendorSensitiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_986");

                entity.HasOne(d => d.VendorType)
                    .WithMany(p => p.VendorDetails)
                    .HasForeignKey(d => d.VendorTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_972");
            });

            modelBuilder.Entity<VendorSensitive>(entity =>
            {
                entity.ToTable("VendorSensitive", "Vendor");

                entity.Property(e => e.VendorSensitiveId).HasColumnName("VendorSensitiveID");

                entity.Property(e => e.VendorTin)
                    .IsRequired()
                    .HasColumnName("VendorTIN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VendorStatus>(entity =>
            {
                entity.ToTable("VendorStatus", "Vendor");

                entity.Property(e => e.VendorStatusId)
                    .HasColumnName("VendorStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<VendorStatusTracker>(entity =>
            {
                entity.ToTable("VendorStatusTracker", "Vendor");

                entity.HasIndex(e => e.VendorDetailsId)
                    .HasName("fkIdx_1145");

                entity.HasIndex(e => e.VendorStatusId)
                    .HasName("fkIdx_1148");

                entity.Property(e => e.VendorStatusTrackerId)
                    .HasColumnName("VendorStatusTrackerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.VendorDetailsId).HasColumnName("VendorDetailsID");

                entity.Property(e => e.VendorStatusId).HasColumnName("VendorStatusID");

                entity.HasOne(d => d.VendorDetails)
                    .WithMany(p => p.VendorStatusTracker)
                    .HasForeignKey(d => d.VendorDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1145");

                entity.HasOne(d => d.VendorStatus)
                    .WithMany(p => p.VendorStatusTracker)
                    .HasForeignKey(d => d.VendorStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_1148");
            });

            modelBuilder.Entity<VendorType>(entity =>
            {
                entity.ToTable("VendorType", "Vendor");

                entity.Property(e => e.VendorTypeId)
                    .HasColumnName("VendorTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.ToTable("Workflow", "Product");

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.Property(e => e.WorkflowUid)
                    .IsRequired()
                    .HasColumnName("WorkflowUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkflowDetails>(entity =>
            {
                entity.ToTable("WorkflowDetails", "Product");

                entity.HasIndex(e => e.LastModifiedBy)
                    .HasName("fkIdx_742");

                entity.HasIndex(e => e.WorkflowId)
                    .HasName("fkIdx_739");

                entity.Property(e => e.WorkflowDetailsId).HasColumnName("WorkflowDetailsID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.HasOne(d => d.LastModifiedByNavigation)
                    .WithMany(p => p.WorkflowDetails)
                    .HasForeignKey(d => d.LastModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_742");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.WorkflowDetails)
                    .HasForeignKey(d => d.WorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_739");
            });

            modelBuilder.Entity<WorkflowGroup>(entity =>
            {
                entity.ToTable("WorkflowGroup", "Product");

                entity.HasIndex(e => e.OrgId)
                    .HasName("fkIdx_814");

                entity.HasIndex(e => e.ProductId)
                    .HasName("fkIdx_808");

                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_811");

                entity.Property(e => e.WorkflowGroupId).HasColumnName("WorkflowGroupID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.WorkflowGroup)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_814");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WorkflowGroup)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_808");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WorkflowGroup)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_811");
            });

            modelBuilder.Entity<WorkflowGroupItem>(entity =>
            {
                entity.ToTable("WorkflowGroupItem", "Product");

                entity.HasIndex(e => e.WorkflowGroupId)
                    .HasName("fkIdx_805");

                entity.HasIndex(e => e.WorkflowId)
                    .HasName("fkIdx_802");

                entity.Property(e => e.WorkflowGroupItemId).HasColumnName("WorkflowGroupItemID");

                entity.Property(e => e.WorkflowGroupId).HasColumnName("WorkflowGroupID");

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.HasOne(d => d.WorkflowGroup)
                    .WithMany(p => p.WorkflowGroupItem)
                    .HasForeignKey(d => d.WorkflowGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_805");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.WorkflowGroupItem)
                    .HasForeignKey(d => d.WorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_802");
            });

            modelBuilder.Entity<Zip>(entity =>
            {
                entity.ToTable("ZIP", "Address");

                entity.HasIndex(e => e.StateId)
                    .HasName("fkIdx_354");

                entity.Property(e => e.Zipid).HasColumnName("ZIPID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Zip1)
                    .IsRequired()
                    .HasColumnName("ZIP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Zip)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKState_ZIP");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
