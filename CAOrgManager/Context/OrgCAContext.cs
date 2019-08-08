using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CAOrgManager.Models
{
    public partial class OrgCAContext : DbContext
    {
        public OrgCAContext()
        {
        }

        public OrgCAContext(DbContextOptions<OrgCAContext> options): base(options)
        {
        }

        public virtual DbSet<OrgCa> OrgCa { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("****");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<OrgCa>(entity =>
            {
                entity.HasKey(e => e.OrgCode)
                    .HasName("PK_org_CA_List");

                entity.ToTable("OrgCA");

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
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK_User_Info");

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
            });
        }
    }
}
