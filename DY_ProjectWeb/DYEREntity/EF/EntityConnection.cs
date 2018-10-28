namespace DYEREntity.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityConnection : DbContext
    {
        public EntityConnection()
            : base("name=EntityConnection")
        {
        }

        public virtual DbSet<tbl_Country> tbl_Country { get; set; }
        public virtual DbSet<tbl_DYC> tbl_DYC { get; set; }
        public virtual DbSet<tbl_Faculty> tbl_Faculty { get; set; }
        public virtual DbSet<tbl_Host> tbl_Host { get; set; }
        public virtual DbSet<tbl_Roles> tbl_Roles { get; set; }
        public virtual DbSet<tbl_StudentRespondNotification> tbl_StudentRespondNotification { get; set; }
        public virtual DbSet<tbl_UserClaims> tbl_UserClaims { get; set; }
        public virtual DbSet<tbl_UserLogins> tbl_UserLogins { get; set; }
        public virtual DbSet<tbl_Users> tbl_Users { get; set; }
        public virtual DbSet<tbl_UserSendNotification> tbl_UserSendNotification { get; set; }
        public virtual DbSet<tlb_Student> tlb_Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Country>()
                .HasMany(e => e.tbl_Host)
                .WithRequired(e => e.tbl_Country)
                .HasForeignKey(e => e.CountryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Faculty>()
                .Property(e => e.FacultyName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Faculty>()
                .HasMany(e => e.tbl_DYC)
                .WithRequired(e => e.tbl_Faculty)
                .HasForeignKey(e => e.FacultyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Faculty>()
                .HasMany(e => e.tlb_Student)
                .WithRequired(e => e.tbl_Faculty)
                .HasForeignKey(e => e.FacultyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Host>()
                .Property(e => e.HostName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Host>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Host>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Host>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Host>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Host>()
                .HasMany(e => e.tlb_Student)
                .WithRequired(e => e.tbl_Host)
                .HasForeignKey(e => e.HostID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Host>()
                .HasMany(e => e.tbl_UserSendNotification)
                .WithRequired(e => e.tbl_Host)
                .HasForeignKey(e => e.HostID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Roles>()
                .HasMany(e => e.tbl_Users)
                .WithMany(e => e.tbl_Roles)
                .Map(m => m.ToTable("tbl_UserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<tbl_StudentRespondNotification>()
                .Property(e => e.Coordinate)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_DYC)
                .WithRequired(e => e.tbl_Users)
                .HasForeignKey(e => e.UsersId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_UserClaims)
                .WithRequired(e => e.tbl_Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_UserLogins)
                .WithRequired(e => e.tbl_Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_UserSendNotification)
                .WithRequired(e => e.tbl_Users)
                .HasForeignKey(e => e.UsersId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tlb_Student)
                .WithRequired(e => e.tbl_Users)
                .HasForeignKey(e => e.UsersId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tlb_Student>()
                .Property(e => e.Semester)
                .IsUnicode(false);

            modelBuilder.Entity<tlb_Student>()
                .Property(e => e.TypeOfDY)
                .IsUnicode(false);

            modelBuilder.Entity<tlb_Student>()
                .Property(e => e.ContactPerson)
                .IsUnicode(false);

            modelBuilder.Entity<tlb_Student>()
                .Property(e => e.NextOfKin)
                .IsUnicode(false);

            modelBuilder.Entity<tlb_Student>()
                .HasMany(e => e.tbl_StudentRespondNotification)
                .WithRequired(e => e.tlb_Student)
                .HasForeignKey(e => e.StudentID)
                .WillCascadeOnDelete(false);
        }
    }
}
