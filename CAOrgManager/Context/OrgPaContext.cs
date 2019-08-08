using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CAOrgManager.Models
{
    public partial class OrgPaContext : DbContext
    {
        //NOTE: This code was automatically generated with an EF Command in the Package Manager Console : 
        //   Scaffold-DbContext "server=sql.walterpmoore.com;database=Moorenet_STAGING;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Tables "org_CA_List","user_info","prj_org_codes","adm_Cities" -ContextDir Context -Context OrgPaContext
        public OrgPaContext()
        {
        }

        public OrgPaContext(DbContextOptions<OrgPaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdmCities> AdmCities { get; set; }
        public virtual DbSet<OrgCaList> OrgCaList { get; set; }
        public virtual DbSet<PrjOrgCodes> PrjOrgCodes { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("****");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AdmCities>(entity =>
            {
                entity.HasKey(e => e.CitiesId)
                    .HasName("PK_adm_cities");

                entity.ToTable("adm_Cities");

                entity.Property(e => e.CitiesId)
                    .HasColumnName("cities_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(75);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(75);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.CityCode)
                    .HasColumnName("city_code")
                    .HasMaxLength(3);

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('United States')");

                entity.Property(e => e.DcomServer).HasColumnName("DCom_server");

                entity.Property(e => e.Dialin1)
                    .HasColumnName("dialin1")
                    .HasMaxLength(20);

                entity.Property(e => e.Dialin2)
                    .HasColumnName("dialin2")
                    .HasMaxLength(20);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(50);

                entity.Property(e => e.NetMask)
                    .IsRequired()
                    .HasColumnName("net_mask")
                    .HasMaxLength(15);

                entity.Property(e => e.Network)
                    .IsRequired()
                    .HasColumnName("network")
                    .HasMaxLength(15);

                entity.Property(e => e.OcmContact1).HasColumnName("OCM_Contact1");

                entity.Property(e => e.OcmContact2).HasColumnName("OCM_Contact2");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20);

                entity.Property(e => e.SpDialPrefix)
                    .HasColumnName("sp_dial_prefix")
                    .HasMaxLength(3);

                entity.Property(e => e.SpeedDial)
                    .HasColumnName("speed_dial")
                    .HasMaxLength(10);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.Property(e => e.UptBegin).HasColumnName("upt_Begin");

                entity.Property(e => e.UptEnd).HasColumnName("upt_End");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(15);

                entity.HasOne(d => d.OcmContact1Navigation)
                    .WithMany(p => p.AdmCitiesOcmContact1Navigation)
                    .HasForeignKey(d => d.OcmContact1)
                    .HasConstraintName("FK_adm_cities_user_info");

                entity.HasOne(d => d.OcmContact2Navigation)
                    .WithMany(p => p.AdmCitiesOcmContact2Navigation)
                    .HasForeignKey(d => d.OcmContact2)
                    .HasConstraintName("FK_adm_cities_user_info1");
            });

            modelBuilder.Entity<OrgCaList>(entity =>
            {
                entity.HasKey(e => e.OrgCode);

                entity.ToTable("org_CA_List");

                entity.HasIndex(e => new { e.OrgCode, e.CaUid })
                    .HasName("NonClusteredIndex-20141104-102838");

                entity.Property(e => e.OrgCode)
                    .HasColumnName("org_code")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CaUid).HasColumnName("ca_uid");

                entity.Property(e => e.CaUid22).HasColumnName("ca_uid22");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PiSheet)
                    .HasColumnName("piSheet")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.OrgCodeNavigation)
                    .WithOne(p => p.OrgCaList)
                    .HasForeignKey<OrgCaList>(d => d.OrgCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_org_CA_List_prj_org_codes");
            });

            modelBuilder.Entity<PrjOrgCodes>(entity =>
            {
                entity.HasKey(e => e.OrgCode);

                entity.ToTable("prj_org_codes");

                entity.Property(e => e.OrgCode)
                    .HasColumnName("org_code")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CitiesId).HasColumnName("cities_id");

                entity.Property(e => e.CityAlias)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CoCode)
                    .HasColumnName("co_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LegacyOrgCode)
                    .HasColumnName("legacy_org_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MultiDiscOrgCode)
                    .HasColumnName("multi_disc_org_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrgCodeShort)
                    .HasColumnName("org_code_short")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDesc)
                    .HasColumnName("org_desc")
                    .HasMaxLength(255);

                entity.Property(e => e.OrgEnabled)
                    .HasColumnName("org_enabled")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.OrgLastPrjCode)
                    .IsRequired()
                    .HasColumnName("org_lastPrjCode")
                    .HasMaxLength(9)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrgModDate)
                    .HasColumnName("org_mod_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrgPrjBasenum)
                    .HasColumnName("org_prj_basenum")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00000')");

                entity.Property(e => e.OrgType)
                    .HasColumnName("org_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgTypeNum)
                    .HasColumnName("org_type_num")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.PrjFolderFormat)
                    .HasColumnName("prj_folder_format")
                    .HasMaxLength(50);

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.ServiceLine)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cities)
                    .WithMany(p => p.PrjOrgCodes)
                    .HasForeignKey(d => d.CitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prj_org_codes_adm_cities");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK_User_Info");

                entity.ToTable("user_info");

                entity.HasIndex(e => e.UserName)
                    .HasName("IX_user_info_username");

                entity.HasIndex(e => new { e.Uid, e.UserName, e.UsrFname, e.UsrLname, e.UsrEnabled, e.UsrEmail, e.BstEmpCode })
                    .HasName("NonClusteredIndex-20140917-153110");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BstEmpCode)
                    .HasColumnName("bst_emp_code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SpDialSuffix)
                    .HasColumnName("sp_dial_suffix")
                    .HasMaxLength(3);

                entity.Property(e => e.Telecommuter).HasColumnName("telecommuter");

                entity.Property(e => e.UlgName)
                    .HasColumnName("ulg_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UsrAutoCheckIn).HasColumnName("usr_AutoCheckIn");

                entity.Property(e => e.UsrCdate)
                    .HasColumnName("usr_cdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsrCell)
                    .HasColumnName("usr_cell")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrCompanyId).HasColumnName("usr_company_id");

                entity.Property(e => e.UsrContract).HasColumnName("usr_contract");

                entity.Property(e => e.UsrCorpTitle)
                    .HasColumnName("usr_corp_title")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrCusr).HasColumnName("usr_cusr");

                entity.Property(e => e.UsrDesc)
                    .HasColumnName("usr_desc")
                    .HasMaxLength(255);

                entity.Property(e => e.UsrEmail)
                    .HasColumnName("usr_email")
                    .HasMaxLength(100);

                entity.Property(e => e.UsrEnabled)
                    .IsRequired()
                    .HasColumnName("usr_enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsrFax)
                    .HasColumnName("usr_fax")
                    .HasMaxLength(20);

                entity.Property(e => e.UsrFname)
                    .HasColumnName("usr_fname")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrFuncTitle)
                    .HasColumnName("usr_func_title")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrInterest)
                    .HasColumnName("usr_interest")
                    .HasMaxLength(255);

                entity.Property(e => e.UsrLname)
                    .HasColumnName("usr_lname")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrLocation).HasColumnName("usr_location");

                entity.Property(e => e.UsrLongDistCode)
                    .HasColumnName("usr_long_dist_code")
                    .HasMaxLength(7);

                entity.Property(e => e.UsrMname)
                    .HasColumnName("usr_mname")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrModdate)
                    .HasColumnName("usr_moddate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UsrModusr).HasColumnName("usr_modusr");

                entity.Property(e => e.UsrMoorenetIsVisible)
                    .HasColumnName("usr_moorenet_isVisible")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsrOrg)
                    .HasColumnName("usr_org")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UsrPhone)
                    .HasColumnName("usr_phone")
                    .HasMaxLength(20);

                entity.Property(e => e.UsrPic).HasColumnName("usr_pic");

                entity.Property(e => e.UsrReturn)
                    .HasColumnName("usr_return")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrSigFax)
                    .HasColumnName("usr_sig_fax")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrSigName)
                    .HasColumnName("usr_sig_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrSigPhone)
                    .HasColumnName("usr_sig_phone")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrSigSuffix)
                    .HasColumnName("usr_sig_suffix")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrSigTitle)
                    .HasColumnName("usr_sig_title")
                    .HasMaxLength(255);

                entity.Property(e => e.UsrSpecialty)
                    .HasColumnName("usr_specialty")
                    .HasMaxLength(255);

                entity.Property(e => e.UsrStartDate)
                    .HasColumnName("usr_start_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UsrStatus).HasColumnName("usr_status");

                entity.Property(e => e.UsrTimeIn)
                    .HasColumnName("usr_time_in")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrTimeOut)
                    .HasColumnName("usr_time_out")
                    .HasMaxLength(50);

                entity.HasOne(d => d.UsrLocationNavigation)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.UsrLocation)
                    .HasConstraintName("FK_user_info_adm_cities");
            });
        }
    }
}
