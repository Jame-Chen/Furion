using Furion.Core.Models;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Furion.EntityFramework.Core;

[AppDbContext("Pdsys", DbProvider.SqlServer)]
public class DefaultDbContext : AppDbContext<DefaultDbContext>
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
    {
    }



    public virtual DbSet<DataRelaTable> DataRelaTables { get; set; }
    public virtual DbSet<FileUploader> FileUploaders { get; set; }
    public virtual DbSet<GwtableHi> GwtableHis { get; set; }
    public virtual DbSet<SysAnnouncement> SysAnnouncements { get; set; }
    public virtual DbSet<SysDepartment> SysDepartments { get; set; }
    public virtual DbSet<SysDocument> SysDocuments { get; set; }
    public virtual DbSet<SysDocumentTalk> SysDocumentTalks { get; set; }
    public virtual DbSet<SysEmail> SysEmails { get; set; }
    public virtual DbSet<SysEmailTemp> SysEmailTemps { get; set; }
    public virtual DbSet<SysException> SysExceptions { get; set; }
    public virtual DbSet<SysField> SysFields { get; set; }
    public virtual DbSet<SysLog> SysLogs { get; set; }
    public virtual DbSet<SysMenu> SysMenus { get; set; }
    public virtual DbSet<SysMenuOld> SysMenuOlds { get; set; }
    public virtual DbSet<SysMenuSysRoleSysOperation> SysMenuSysRoleSysOperations { get; set; }
    public virtual DbSet<SysMessage> SysMessages { get; set; }
    public virtual DbSet<SysMessageTemp> SysMessageTemps { get; set; }
    public virtual DbSet<SysNotice> SysNotices { get; set; }
    public virtual DbSet<SysOperation> SysOperations { get; set; }
    public virtual DbSet<SysPerson> SysPeople { get; set; }
    public virtual DbSet<SysPerson20230717> SysPerson20230717s { get; set; }
    public virtual DbSet<SysRole> SysRoles { get; set; }
    public virtual DbSet<SysRoleSysPerson> SysRoleSysPeople { get; set; }
    public virtual DbSet<TDrainuser> TDrainusers { get; set; }
    public virtual DbSet<TDrainuserpicture> TDrainuserpictures { get; set; }
    public virtual DbSet<TOnlineNewSsdata> TOnlineNewSsdatas { get; set; }
    public virtual DbSet<TOnlineNewSsdatasHi> TOnlineNewSsdatasHis { get; set; }
    public virtual DbSet<TRtrptPumpHi> TRtrptPumpHis { get; set; }
    public virtual DbSet<TRtrptPumpHisHi> TRtrptPumpHisHis { get; set; }
    public virtual DbSet<VSysRoleSysPerson> VSysRoleSysPeople { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Server=172.18.1.227;Database=Pdsys;uid=sa;password=wavenet31269900;TrustServerCertificate=true");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Chinese_PRC_CI_AS");

        modelBuilder.Entity<DataRelaTable>(entity =>
        {
            entity.ToTable("DataRelaTable");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.DataDesc)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DataName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBName");

            entity.Property(e => e.DefaultValue).HasColumnName("Default_Value");

            entity.Property(e => e.LastDelt).HasColumnName("lastDelt");

            entity.Property(e => e.LastDeltState).HasColumnName("lastDeltState");

            entity.Property(e => e.LastState).HasColumnName("lastState");

            entity.Property(e => e.LastTime)
                .HasColumnType("datetime")
                .HasColumnName("lastTime");

            entity.Property(e => e.LastValue).HasColumnName("lastValue");

            entity.Property(e => e.NDraiPumpType).HasColumnName("N_DRAI_PUMP_TYPE");

            entity.Property(e => e.SysCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sysCode");

            entity.Property(e => e.Tbname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBName");

            entity.Property(e => e.Town).HasColumnName("TOWN");

            entity.Property(e => e.WarnDesc)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WellCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WellName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FileUploader>(entity =>
        {
            entity.ToTable("FileUploader");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.FullPath)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasComment("Research");

            entity.Property(e => e.Path).HasMaxLength(200);

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.State).HasMaxLength(200);

            entity.Property(e => e.Suffix).HasMaxLength(200);
        });

        modelBuilder.Entity<GwtableHi>(entity =>
        {
            entity.ToTable("GWTableHis");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.DataName)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeltValue).HasColumnName("deltValue");

            entity.Property(e => e.GetInfoTime).HasColumnType("datetime");

            entity.Property(e => e.InsertTime).HasColumnType("datetime");

            entity.Property(e => e.RawValue).HasColumnName("rawValue");

            entity.Property(e => e.WellCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SysAnnouncement>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_SYSANNOUNCEMENT")
                .IsClustered(false);

            entity.ToTable("SysAnnouncement");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime).HasColumnType("datetime");

            entity.Property(e => e.Message).HasMaxLength(4000);

            entity.Property(e => e.State).HasMaxLength(200);

            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<SysDepartment>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_SYSDEPARTMENT")
                .IsClustered(false);

            entity.ToTable("SysDepartment");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.Address).HasMaxLength(200);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("Research");

            entity.Property(e => e.ParentId).HasMaxLength(36);

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.UpdatePerson).HasMaxLength(200);

            entity.Property(e => e.UpdateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_SYSDEPAR_REFERENCE_SYSDEPAR");

            entity.HasMany(d => d.Sys)
                .WithMany(p => p.SysDepartments)
                .UsingEntity<Dictionary<string, object>>(
                    "SysDocumentSysDepartment",
                    l => l.HasOne<SysDocument>().WithMany().HasForeignKey("SysId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SYSDOCUM_REFERENCE_SYSDOCUM2"),
                    r => r.HasOne<SysDepartment>().WithMany().HasForeignKey("SysDepartmentId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SYSDOCUM_REFERENCE_SYSDEPAR"),
                    j =>
                    {
                        j.HasKey("SysDepartmentId", "SysId").HasName("PK_SYSDOCUMENTSYSDEPARTMENT");

                        j.ToTable("SysDocumentSysDepartment");

                        j.IndexerProperty<string>("SysDepartmentId").HasMaxLength(36);

                        j.IndexerProperty<string>("SysId").HasMaxLength(36).HasColumnName("Sys_Id");
                    });
        });

        modelBuilder.Entity<SysDocument>(entity =>
        {
            entity.ToTable("SysDocument");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.FullPath)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasComment("Research");

            entity.Property(e => e.Path).HasMaxLength(200);

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.Suffix).HasMaxLength(200);
        });

        modelBuilder.Entity<SysDocumentTalk>(entity =>
        {
            entity.ToTable("SysDocumentTalk");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.Content)
                .HasMaxLength(500)
                .HasComment("Research");

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.SysDocumentId).HasMaxLength(36);

            entity.HasOne(d => d.SysDocument)
                .WithMany(p => p.SysDocumentTalks)
                .HasForeignKey(d => d.SysDocumentId)
                .HasConstraintName("FK_SYSDOCUM_REFERENCE_SYSDOCUM");
        });

        modelBuilder.Entity<SysEmail>(entity =>
        {
            entity.ToTable("SysEmail");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.Content).HasColumnType("ntext");

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.MailType)
                .HasMaxLength(200)
                .HasColumnName("Mail_type");

            entity.Property(e => e.ReadTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.ReplyEmail)
                .HasMaxLength(200)
                .HasColumnName("Reply_email");

            entity.Property(e => e.State).HasMaxLength(200);

            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.SysMailId).HasMaxLength(36);

            entity.HasOne(d => d.SysMail)
                .WithMany(p => p.SysEmails)
                .HasForeignKey(d => d.SysMailId)
                .HasConstraintName("FK_SYSEMAIL_REFERENCE_SYSEMAIL");
        });

        modelBuilder.Entity<SysEmailTemp>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_mail_info2")
                .IsClustered(false);

            entity.ToTable("SysEmailTemp");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.Content).HasColumnType("ntext");

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.IsDefault)
                .HasMaxLength(200)
                .HasComment("RadioButton");

            entity.Property(e => e.MailName)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("Mail_name");

            entity.Property(e => e.MailType)
                .HasMaxLength(200)
                .HasColumnName("Mail_type");

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.ReplyEmail)
                .HasMaxLength(200)
                .HasColumnName("Reply_email");

            entity.Property(e => e.State).HasMaxLength(200);

            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(200);
        });

        modelBuilder.Entity<SysException>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_SYSEXCEPTION")
                .IsClustered(false);

            entity.ToTable("SysException");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.LeiXing).HasMaxLength(200);

            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .HasComment("Research");

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.Result).HasMaxLength(200);

            entity.Property(e => e.State).HasMaxLength(200);
        });

        modelBuilder.Entity<SysField>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_SYSFIELD")
                .IsClustered(false);

            entity.ToTable("SysField");

            entity.HasIndex(e => new { e.MyTables, e.MyColums }, "Index_1");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime).HasColumnType("datetime");

            entity.Property(e => e.MyColums).HasMaxLength(200);

            entity.Property(e => e.MyTables).HasMaxLength(200);

            entity.Property(e => e.MyTexts)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("Research");

            entity.Property(e => e.ParentId).HasMaxLength(36);

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.UpdatePerson).HasMaxLength(200);

            entity.Property(e => e.UpdateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_SYSFIELD_REFERENCE_SYSFIELD");
        });

        modelBuilder.Entity<SysLog>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_SYSLOG")
                .IsClustered(false);

            entity.ToTable("SysLog");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.Ip)
                .HasMaxLength(200)
                .HasComment("Research");

            entity.Property(e => e.MenuId).HasMaxLength(36);

            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .HasComment("Research");

            entity.Property(e => e.PersonId).HasMaxLength(36);

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.Result).HasMaxLength(200);

            entity.Property(e => e.State)
                .HasMaxLength(200)
                .HasComment("ResearchDropDown");
        });

        modelBuilder.Entity<SysMenu>(entity =>
        {
            entity.ToTable("SysMenu");

            entity.HasComment("导航栏");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.BigIconic).HasMaxLength(200);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime).HasColumnType("datetime");

            entity.Property(e => e.Iconic).HasMaxLength(200);

            entity.Property(e => e.IsLeaf).HasMaxLength(200);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("Research");

            entity.Property(e => e.ParentId).HasMaxLength(36);

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.State)
                .HasMaxLength(200)
                .HasComment("RadioButtonResearch");

            entity.Property(e => e.UpdatePerson).HasMaxLength(200);

            entity.Property(e => e.UpdateTime).HasColumnType("datetime");

            entity.Property(e => e.Url).HasMaxLength(200);

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_SYSMENU_REFERENCE_SYSMENU");

            entity.HasMany(d => d.SysOperations)
                .WithMany(p => p.SysMenus)
                .UsingEntity<Dictionary<string, object>>(
                    "SysMenuSysOperation",
                    l => l.HasOne<SysOperation>().WithMany().HasForeignKey("SysOperationId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SYSMENUS_REFERENCE_SYSOPERA"),
                    r => r.HasOne<SysMenu>().WithMany().HasForeignKey("SysMenuId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SYSMENUS_REFERENCE_SYSMENU"),
                    j =>
                    {
                        j.HasKey("SysMenuId", "SysOperationId").HasName("PK_SYSMENUSYSOPERATION");

                        j.ToTable("SysMenuSysOperation");

                        j.IndexerProperty<string>("SysMenuId").HasMaxLength(36);

                        j.IndexerProperty<string>("SysOperationId").HasMaxLength(36);
                    });
        });

        modelBuilder.Entity<SysMenuOld>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SysMenu_old");

            entity.Property(e => e.BigIconic).HasMaxLength(200);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime).HasColumnType("datetime");

            entity.Property(e => e.Iconic).HasMaxLength(200);

            entity.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(36);

            entity.Property(e => e.IsLeaf).HasMaxLength(200);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.ParentId).HasMaxLength(36);

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.State).HasMaxLength(200);

            entity.Property(e => e.UpdatePerson).HasMaxLength(200);

            entity.Property(e => e.UpdateTime).HasColumnType("datetime");

            entity.Property(e => e.Url).HasMaxLength(200);
        });

        modelBuilder.Entity<SysMenuSysRoleSysOperation>(entity =>
        {
            entity.ToTable("SysMenuSysRoleSysOperation");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.SysMenuId).HasMaxLength(36);

            entity.Property(e => e.SysOperationId).HasMaxLength(36);

            entity.Property(e => e.SysRoleId).HasMaxLength(36);

            entity.HasOne(d => d.SysMenu)
                .WithMany(p => p.SysMenuSysRoleSysOperations)
                .HasForeignKey(d => d.SysMenuId)
                .HasConstraintName("FK_SYSMENUS_REFERENCE_SYSMENU2");

            entity.HasOne(d => d.SysOperation)
                .WithMany(p => p.SysMenuSysRoleSysOperations)
                .HasForeignKey(d => d.SysOperationId)
                .HasConstraintName("FK_SYSMENUS_REFERENCE_SYSOPERA2");

            entity.HasOne(d => d.SysRole)
                .WithMany(p => p.SysMenuSysRoleSysOperations)
                .HasForeignKey(d => d.SysRoleId)
                .HasConstraintName("FK_SYSMENUS_REFERENCE_SYSROLE");
        });

        modelBuilder.Entity<SysMessage>(entity =>
        {
            entity.ToTable("SysMessage");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.Content).HasMaxLength(400);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.MessageType).HasMaxLength(200);

            entity.Property(e => e.ReadTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.State).HasMaxLength(200);

            entity.Property(e => e.SysMessageTempId).HasMaxLength(36);

            entity.HasOne(d => d.SysMessageTemp)
                .WithMany(p => p.SysMessages)
                .HasForeignKey(d => d.SysMessageTempId)
                .HasConstraintName("FK_SYSMESSA_REFERENCE_SYSMESSA");
        });

        modelBuilder.Entity<SysMessageTemp>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_mail_info")
                .IsClustered(false);

            entity.ToTable("SysMessageTemp");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.Content).HasMaxLength(400);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.IsDefault)
                .HasMaxLength(200)
                .HasComment("RadioButton");

            entity.Property(e => e.MessageName)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.MessageType).HasMaxLength(200);

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.State).HasMaxLength(200);
        });

        modelBuilder.Entity<SysNotice>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_SYSNOTICE")
                .IsClustered(false);

            entity.ToTable("SysNotice");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.LostTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.Message).HasMaxLength(4000);

            entity.Property(e => e.PersonId).HasMaxLength(36);

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.State).HasMaxLength(200);
        });

        modelBuilder.Entity<SysOperation>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_SYSOPERATION")
                .IsClustered(false);

            entity.ToTable("SysOperation");

            entity.HasComment("操作");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasComment("Research");

            entity.Property(e => e.Function).HasMaxLength(200);

            entity.Property(e => e.Iconic)
                .HasMaxLength(200)
                .HasComment("Equal");

            entity.Property(e => e.Name).HasMaxLength(200);

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.State)
                .HasMaxLength(200)
                .HasComment("ResearchDropDown");
        });

        modelBuilder.Entity<SysPerson>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_SYSPERSON")
                .IsClustered(false);

            entity.ToTable("SysPerson");

            entity.HasIndex(e => e.Name, "Index_1");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.Address).HasMaxLength(200);

            entity.Property(e => e.ChangePwdTime).HasColumnType("date");

            entity.Property(e => e.City)
                .HasMaxLength(200)
                .HasComment("ProvinceCascade");

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime).HasColumnType("datetime");

            entity.Property(e => e.EmailAddress).HasMaxLength(200);

            entity.Property(e => e.Hdpic)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HDpic");

            entity.Property(e => e.LastLogonIp)
                .HasMaxLength(200)
                .HasColumnName("LastLogonIP");

            entity.Property(e => e.LastLogonTime).HasColumnType("datetime");

            entity.Property(e => e.LogonIp)
                .HasMaxLength(200)
                .HasColumnName("LogonIP");

            entity.Property(e => e.LogonTime).HasColumnType("datetime");

            entity.Property(e => e.MobilePhoneNumber).HasMaxLength(200);

            entity.Property(e => e.MyName)
                .HasMaxLength(200)
                .HasComment("Research");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("Research");

            entity.Property(e => e.PageStyle)
                .HasMaxLength(200)
                .HasComment("Display");

            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.PhoneNumber).HasMaxLength(200);

            entity.Property(e => e.Position).HasMaxLength(200);

            entity.Property(e => e.Province)
                .HasMaxLength(200)
                .HasComment("DropDown");

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.Sex)
                .HasMaxLength(200)
                .HasComment("DropDown");

            entity.Property(e => e.State)
                .HasMaxLength(200)
                .HasComment("RadioButtonResearch");

            entity.Property(e => e.SurePassword).HasMaxLength(200);

            entity.Property(e => e.SysDepartmentId).HasMaxLength(36);

            entity.Property(e => e.ToKen).HasMaxLength(36);

            entity.Property(e => e.UpdatePerson).HasMaxLength(200);

            entity.Property(e => e.UpdateTime).HasColumnType("datetime");

            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.Property(e => e.Village)
                .HasMaxLength(200)
                .HasComment("CityCascade");

            entity.HasOne(d => d.SysDepartment)
                .WithMany(p => p.SysPeople)
                .HasForeignKey(d => d.SysDepartmentId)
                .HasConstraintName("FK_SYSPERSO_REFERENCE_SYSDEPAR");

            entity.HasMany(d => d.SysSysDocumentIds)
                .WithMany(p => p.SysPeople)
                .UsingEntity<Dictionary<string, object>>(
                    "SysDocumentSysPerson",
                    l => l.HasOne<SysDocument>().WithMany().HasForeignKey("SysSysDocumentIdId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SYSDOCUM_REFERENCE_SYSDOCUM3"),
                    r => r.HasOne<SysPerson>().WithMany().HasForeignKey("SysPersonId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_SYSDOCUM_REFERENCE_SYSPERSO"),
                    j =>
                    {
                        j.HasKey("SysPersonId", "SysSysDocumentIdId").HasName("PK_SYSDOCUMENTSYSPERSON");

                        j.ToTable("SysDocumentSysPerson");

                        j.IndexerProperty<string>("SysPersonId").HasMaxLength(36);

                        j.IndexerProperty<string>("SysSysDocumentIdId").HasMaxLength(36).HasColumnName("SysSysDocumentId_Id");
                    });
        });

        modelBuilder.Entity<SysPerson20230717>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SysPerson20230717");

            entity.Property(e => e.Address).HasMaxLength(200);

            entity.Property(e => e.City).HasMaxLength(200);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime).HasColumnType("datetime");

            entity.Property(e => e.EmailAddress).HasMaxLength(200);

            entity.Property(e => e.Hdpic)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HDpic");

            entity.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(36);

            entity.Property(e => e.LastLogonIp)
                .HasMaxLength(200)
                .HasColumnName("LastLogonIP");

            entity.Property(e => e.LastLogonTime).HasColumnType("datetime");

            entity.Property(e => e.LogonIp)
                .HasMaxLength(200)
                .HasColumnName("LogonIP");

            entity.Property(e => e.LogonTime).HasColumnType("datetime");

            entity.Property(e => e.MobilePhoneNumber).HasMaxLength(200);

            entity.Property(e => e.MyName).HasMaxLength(200);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.PageStyle).HasMaxLength(200);

            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.PhoneNumber).HasMaxLength(200);

            entity.Property(e => e.Position).HasMaxLength(200);

            entity.Property(e => e.Province).HasMaxLength(200);

            entity.Property(e => e.Remark).HasMaxLength(4000);

            entity.Property(e => e.Sex).HasMaxLength(200);

            entity.Property(e => e.State).HasMaxLength(200);

            entity.Property(e => e.SurePassword).HasMaxLength(200);

            entity.Property(e => e.SysDepartmentId).HasMaxLength(36);

            entity.Property(e => e.ToKen).HasMaxLength(36);

            entity.Property(e => e.UpdatePerson).HasMaxLength(200);

            entity.Property(e => e.UpdateTime).HasColumnType("datetime");

            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.Property(e => e.Village).HasMaxLength(200);
        });

        modelBuilder.Entity<SysRole>(entity =>
        {
            entity.ToTable("SysRole");

            entity.Property(e => e.Id).HasMaxLength(36);

            entity.Property(e => e.CreatePerson).HasMaxLength(200);

            entity.Property(e => e.CreateTime).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(4000);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("Research");

            entity.Property(e => e.UpdatePerson).HasMaxLength(200);

            entity.Property(e => e.UpdateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<SysRoleSysPerson>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SysRoleSysPerson");

            entity.Property(e => e.SysPersonId)
                .IsRequired()
                .HasMaxLength(36);

            entity.Property(e => e.SysRoleId)
                .IsRequired()
                .HasMaxLength(36);

            entity.HasOne(d => d.SysPerson)
                .WithMany()
                .HasForeignKey(d => d.SysPersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSROLES_REFERENCE_SYSPERSO");

            entity.HasOne(d => d.SysRole)
                .WithMany()
                .HasForeignKey(d => d.SysRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSROLES_REFERENCE_SYSROLE");
        });

        modelBuilder.Entity<TDrainuser>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("T_DRAINUSER");

            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_TIME");

            entity.Property(e => e.NJd)
                .HasColumnType("numeric(38, 8)")
                .HasColumnName("N_JD");

            entity.Property(e => e.NWd)
                .HasColumnType("numeric(38, 8)")
                .HasColumnName("N_WD");

            entity.Property(e => e.OperateTime)
                .HasColumnType("datetime")
                .HasColumnName("OPERATE_TIME");

            entity.Property(e => e.QppshTableId)
                .HasMaxLength(255)
                .HasColumnName("QPPSH_TABLE_ID");

            entity.Property(e => e.SAddress)
                .HasMaxLength(255)
                .HasColumnName("S_ADDRESS");

            entity.Property(e => e.SArea)
                .HasMaxLength(255)
                .HasColumnName("S_AREA");

            entity.Property(e => e.SInMan)
                .HasMaxLength(255)
                .HasColumnName("s_IN_MAN");

            entity.Property(e => e.SName)
                .HasMaxLength(255)
                .HasColumnName("S_NAME");

            entity.Property(e => e.SNo)
                .HasMaxLength(255)
                .HasColumnName("S_NO");

            entity.Property(e => e.SStatus)
                .HasMaxLength(255)
                .HasColumnName("s_status");

            entity.Property(e => e.STown)
                .HasMaxLength(255)
                .HasColumnName("S_TOWN");

            entity.Property(e => e.SType)
                .HasMaxLength(255)
                .HasColumnName("S_TYPE");

            entity.Property(e => e.SXkh)
                .HasMaxLength(255)
                .HasColumnName("S_XKH");

            entity.Property(e => e.Stamp)
                .HasMaxLength(255)
                .HasColumnName("STAMP");

            entity.Property(e => e.Status)
                .HasColumnType("numeric(38, 8)")
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<TDrainuserpicture>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("T_DRAINUSERPICTURE");

            entity.Property(e => e.CreateTime)
                .HasColumnType("date")
                .HasColumnName("CREATE_TIME");

            entity.Property(e => e.FileUploaderId)
                .HasMaxLength(255)
                .HasColumnName("FILE_UPLOADER_ID");

            entity.Property(e => e.FileUploaderStatus)
                .HasColumnType("numeric(38, 8)")
                .HasColumnName("FILE_UPLOADER_STATUS");

            entity.Property(e => e.FullPath)
                .HasMaxLength(255)
                .HasColumnName("FULL_PATH");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.IdIndex)
                .HasColumnType("numeric(38, 8)")
                .HasColumnName("ID_INDEX");

            entity.Property(e => e.OperateTime)
                .HasColumnType("date")
                .HasColumnName("OPERATE_TIME");

            entity.Property(e => e.Stamp)
                .HasMaxLength(255)
                .HasColumnName("STAMP");

            entity.Property(e => e.TypeId)
                .HasColumnType("numeric(38, 8)")
                .HasColumnName("TYPE_ID");

            entity.Property(e => e.WbId)
                .HasMaxLength(255)
                .HasColumnName("WB_ID");
        });

        modelBuilder.Entity<TOnlineNewSsdata>(entity =>
        {
            entity.HasKey(e => new { e.Sid, e.StdId })
                .HasName("PK_dbo.tOnline_New_SSDatas");

            entity.ToTable("tOnline_New_SSDatas");

            entity.Property(e => e.Sid).HasColumnName("SID");

            entity.Property(e => e.StdId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Std_id");

            entity.Property(e => e.ClrCodtocdt).HasColumnName("clr_codtocdt");

            entity.Property(e => e.ClrD009).HasColumnName("clr_d009");

            entity.Property(e => e.ClrD010).HasColumnName("clr_d010");

            entity.Property(e => e.ClrD011).HasColumnName("clr_d011");

            entity.Property(e => e.ClrD012).HasColumnName("clr_d012");

            entity.Property(e => e.ClrDatetime).HasColumnName("clr_datetime");

            entity.Property(e => e.Cod).HasColumnName("cod");

            entity.Property(e => e.Codtocdt)
                .HasColumnType("datetime")
                .HasColumnName("codtocdt");

            entity.Property(e => e.Codtocfault)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CODTOCFAULT");

            entity.Property(e => e.Codtocftval).HasColumnName("CODTOCFTVAL");

            entity.Property(e => e.Codtocstate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CODTOCSTATE");

            entity.Property(e => e.Codtocstval).HasColumnName("CODTOCSTVAL");

            entity.Property(e => e.Codtoctime)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("codtoctime");

            entity.Property(e => e.Codtocwarning)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CODTOCWARNING");

            entity.Property(e => e.Codtocwnval).HasColumnName("CODTOCWNVAL");

            entity.Property(e => e.ComId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Com_id");

            entity.Property(e => e.D009)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("d009");

            entity.Property(e => e.D010)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("d010");

            entity.Property(e => e.D011)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("d011");

            entity.Property(e => e.D012)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("d012");

            entity.Property(e => e.DataDt)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("data_dt");

            entity.Property(e => e.Datetime).HasColumnType("datetime");

            entity.Property(e => e.District)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DspName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("dsp_name");

            entity.Property(e => e.FactId)
                .HasMaxLength(17)
                .HasColumnName("FACT_ID");

            entity.Property(e => e.Factxs).HasColumnName("factxs");

            entity.Property(e => e.Flag).HasColumnName("flag");

            entity.Property(e => e.Info)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("info");

            entity.Property(e => e.JckName).HasMaxLength(50);

            entity.Property(e => e.Jckid)
                .HasMaxLength(50)
                .HasColumnName("JCKID");

            entity.Property(e => e.Jcktype).HasColumnName("JCKTYPE");

            entity.Property(e => e.Ljll).HasColumnName("ljll");

            entity.Property(e => e.Nh3n).HasColumnName("NH3N");

            entity.Property(e => e.Outamount)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("outamount");

            entity.Property(e => e.Ph).HasColumnName("ph");

            entity.Property(e => e.Ssll).HasColumnName("ssll");

            entity.Property(e => e.Tn).HasColumnName("TN");

            entity.Property(e => e.Toc).HasColumnName("toc");

            entity.Property(e => e.Tp).HasColumnName("TP");

            entity.Property(e => e.Wt).HasColumnName("wt");

            entity.Property(e => e.Yw).HasColumnName("yw");
        });

        modelBuilder.Entity<TOnlineNewSsdatasHi>(entity =>
        {
            entity.HasKey(e => e.Sid)
                .HasName("PK_dbo.tOnline_New_SSDatas_his");

            entity.ToTable("tOnline_New_SSDatas_his");

            entity.Property(e => e.Sid).HasColumnName("SID");

            entity.Property(e => e.ClrCodtocdt).HasColumnName("clr_codtocdt");

            entity.Property(e => e.ClrD009).HasColumnName("clr_d009");

            entity.Property(e => e.ClrD010).HasColumnName("clr_d010");

            entity.Property(e => e.ClrD011).HasColumnName("clr_d011");

            entity.Property(e => e.ClrD012).HasColumnName("clr_d012");

            entity.Property(e => e.ClrDatetime).HasColumnName("clr_datetime");

            entity.Property(e => e.Cod).HasColumnName("cod");

            entity.Property(e => e.Codtocdt)
                .HasColumnType("datetime")
                .HasColumnName("codtocdt");

            entity.Property(e => e.Codtocfault)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CODTOCFAULT");

            entity.Property(e => e.Codtocftval).HasColumnName("CODTOCFTVAL");

            entity.Property(e => e.Codtocstate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CODTOCSTATE");

            entity.Property(e => e.Codtocstval).HasColumnName("CODTOCSTVAL");

            entity.Property(e => e.Codtoctime)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("codtoctime");

            entity.Property(e => e.Codtocwarning)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CODTOCWARNING");

            entity.Property(e => e.Codtocwnval).HasColumnName("CODTOCWNVAL");

            entity.Property(e => e.ComId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Com_id");

            entity.Property(e => e.D009)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("d009");

            entity.Property(e => e.D010)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("d010");

            entity.Property(e => e.D011)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("d011");

            entity.Property(e => e.D012)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("d012");

            entity.Property(e => e.DataDt)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("data_dt");

            entity.Property(e => e.Datetime).HasColumnType("datetime");

            entity.Property(e => e.District)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DspName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("dsp_name");

            entity.Property(e => e.FactId)
                .HasMaxLength(17)
                .HasColumnName("FACT_ID");

            entity.Property(e => e.Factxs).HasColumnName("factxs");

            entity.Property(e => e.Flag).HasColumnName("flag");

            entity.Property(e => e.Info)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("info");

            entity.Property(e => e.JckName).HasMaxLength(50);

            entity.Property(e => e.Jckid)
                .HasMaxLength(50)
                .HasColumnName("JCKID");

            entity.Property(e => e.Jcktype).HasColumnName("JCKTYPE");

            entity.Property(e => e.Ljll).HasColumnName("ljll");

            entity.Property(e => e.Nh3n).HasColumnName("NH3N");

            entity.Property(e => e.Outamount)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("outamount");

            entity.Property(e => e.Ph).HasColumnName("ph");

            entity.Property(e => e.Ssll).HasColumnName("ssll");

            entity.Property(e => e.StdId)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Std_id");

            entity.Property(e => e.Tn).HasColumnName("TN");

            entity.Property(e => e.Toc).HasColumnName("toc");

            entity.Property(e => e.Tp).HasColumnName("TP");

            entity.Property(e => e.Wt).HasColumnName("wt");

            entity.Property(e => e.Yw).HasColumnName("yw");
        });

        modelBuilder.Entity<TRtrptPumpHi>(entity =>
        {
            entity.HasKey(e => e.NId)
                .HasName("PK_dbo.T_RTRPT_PUMP_HIS");

            entity.ToTable("T_RTRPT_PUMP_HIS");

            entity.Property(e => e.NId)
                .HasColumnType("decimal(10, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("N_ID");

            entity.Property(e => e.Bod)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("BOD");

            entity.Property(e => e.Bzssll)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("BZSSLL");

            entity.Property(e => e.Cckg).HasColumnName("CCKG");

            entity.Property(e => e.Cod)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("COD");

            entity.Property(e => e.Ljll)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("LJLL");

            entity.Property(e => e.NDraiPumpType)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_DRAI_PUMP_TYPE");

            entity.Property(e => e.NDraiPumpTypeFeat)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_DRAI_PUMP_TYPE_FEAT");

            entity.Property(e => e.NKaijitaishu)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_KAIJITAISHU");

            entity.Property(e => e.NLiuliang)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_LIULIANG");

            entity.Property(e => e.NRunning)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("N_RUNNING");

            entity.Property(e => e.NShuiwei)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_SHUIWEI");

            entity.Property(e => e.NTaishu)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_TAISHU");

            entity.Property(e => e.NWaiyewei)
                .HasColumnType("decimal(10, 1)")
                .HasColumnName("N_WAIYEWEI");

            entity.Property(e => e.NYewei)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_YEWEI");

            entity.Property(e => e.NYuliang)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_YULIANG");

            entity.Property(e => e.Nh3n)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("NH3N");

            entity.Property(e => e.Ph)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("PH");

            entity.Property(e => e.SDraiPumpId)
                .HasMaxLength(32)
                .HasColumnName("S_DRAI_PUMP_ID");

            entity.Property(e => e.SLljs).HasColumnName("S_LLJS");

            entity.Property(e => e.SPumpstatus)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("S_PUMPSTATUS");

            entity.Property(e => e.SSname)
                .HasMaxLength(38)
                .HasColumnName("S_SNAME");

            entity.Property(e => e.Ss)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SS");

            entity.Property(e => e.Ssll1)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL1");

            entity.Property(e => e.Ssll10)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL10");

            entity.Property(e => e.Ssll11)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL11");

            entity.Property(e => e.Ssll12)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL12");

            entity.Property(e => e.Ssll2)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL2");

            entity.Property(e => e.Ssll3)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL3");

            entity.Property(e => e.Ssll4)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL4");

            entity.Property(e => e.Ssll5)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL5");

            entity.Property(e => e.Ssll6)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL6");

            entity.Property(e => e.Ssll7)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL7");

            entity.Property(e => e.Ssll8)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL8");

            entity.Property(e => e.Ssll9)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL9");

            entity.Property(e => e.TStime)
                .HasColumnType("datetime")
                .HasColumnName("T_STIME");

            entity.Property(e => e.Tn)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("TN");

            entity.Property(e => e.Toc)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("TOC");

            entity.Property(e => e.Town).HasColumnName("TOWN");

            entity.Property(e => e.Tp)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("TP");
        });

        modelBuilder.Entity<TRtrptPumpHisHi>(entity =>
        {
            entity.HasKey(e => e.NId)
                .HasName("PK_dbo.T_RTRPT_PUMP_HIS_HIS");

            entity.ToTable("T_RTRPT_PUMP_HIS_HIS");

            entity.Property(e => e.NId)
                .HasColumnType("decimal(10, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("N_ID");

            entity.Property(e => e.Bod)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("BOD");

            entity.Property(e => e.Bzssll)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("BZSSLL");

            entity.Property(e => e.Cckg).HasColumnName("CCKG");

            entity.Property(e => e.Cod)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("COD");

            entity.Property(e => e.Ljll)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("LJLL");

            entity.Property(e => e.NDraiPumpType)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_DRAI_PUMP_TYPE");

            entity.Property(e => e.NDraiPumpTypeFeat)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_DRAI_PUMP_TYPE_FEAT");

            entity.Property(e => e.NKaijitaishu)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_KAIJITAISHU");

            entity.Property(e => e.NLiuliang)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_LIULIANG");

            entity.Property(e => e.NRunning)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("N_RUNNING");

            entity.Property(e => e.NShuiwei)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_SHUIWEI");

            entity.Property(e => e.NTaishu)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_TAISHU");

            entity.Property(e => e.NWaiyewei)
                .HasColumnType("decimal(10, 1)")
                .HasColumnName("N_WAIYEWEI");

            entity.Property(e => e.NYewei)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_YEWEI");

            entity.Property(e => e.NYuliang)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("N_YULIANG");

            entity.Property(e => e.Nh3n)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("NH3N");

            entity.Property(e => e.Ph)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("PH");

            entity.Property(e => e.SDraiPumpId)
                .HasMaxLength(32)
                .HasColumnName("S_DRAI_PUMP_ID");

            entity.Property(e => e.SLljs).HasColumnName("S_LLJS");

            entity.Property(e => e.SPumpstatus)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("S_PUMPSTATUS");

            entity.Property(e => e.SSname)
                .HasMaxLength(38)
                .HasColumnName("S_SNAME");

            entity.Property(e => e.Ss)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SS");

            entity.Property(e => e.Ssll1)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL1");

            entity.Property(e => e.Ssll10)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL10");

            entity.Property(e => e.Ssll11)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL11");

            entity.Property(e => e.Ssll12)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL12");

            entity.Property(e => e.Ssll2)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL2");

            entity.Property(e => e.Ssll3)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL3");

            entity.Property(e => e.Ssll4)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL4");

            entity.Property(e => e.Ssll5)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL5");

            entity.Property(e => e.Ssll6)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL6");

            entity.Property(e => e.Ssll7)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL7");

            entity.Property(e => e.Ssll8)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL8");

            entity.Property(e => e.Ssll9)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("SSLL9");

            entity.Property(e => e.TStime)
                .HasColumnType("datetime")
                .HasColumnName("T_STIME");

            entity.Property(e => e.Tn)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("TN");

            entity.Property(e => e.Toc)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("TOC");

            entity.Property(e => e.Tp)
                .HasColumnType("decimal(12, 6)")
                .HasColumnName("TP");
        });

       

        modelBuilder.Entity<VSysRoleSysPerson>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("V_SysRoleSysPerson");

            entity.Property(e => e.CreateTime).HasColumnType("datetime");

            entity.Property(e => e.Des).HasMaxLength(4000);

            entity.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(36);

            entity.Property(e => e.MobilePhoneNumber).HasMaxLength(200);

            entity.Property(e => e.MyName).HasMaxLength(200);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.RoleId)
                .HasMaxLength(36)
                .HasColumnName("role_id");

            entity.Property(e => e.RoleName).HasMaxLength(200);

            entity.Property(e => e.SCompany)
                .HasMaxLength(200)
                .HasColumnName("s_company");

            entity.Property(e => e.STownid)
                .HasMaxLength(4000)
                .HasColumnName("S_TOWNID");

            entity.Property(e => e.STownname)
                .HasMaxLength(200)
                .HasColumnName("s_townname");

            entity.Property(e => e.SysPersonId).HasMaxLength(36);

            entity.Property(e => e.SysRoleId).HasMaxLength(36);
        });

    }

}
