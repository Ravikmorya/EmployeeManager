using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeManagerProject.Models.Entities
{
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {
        }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttendanceTbl> AttendanceTbl { get; set; }
        public virtual DbSet<EmployeeData> EmployeeData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DST-RAVI\\MSSQLSERVER01;Database=Employee;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttendanceTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceId)
                    .HasName("PK__Attendan__8B69263C0A0484E0");

                entity.Property(e => e.AttendanceId)
                    .HasColumnName("AttendanceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttendanceDate).HasColumnType("date");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.AttendanceTbl)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__AttendanceTb__Id__37A5467C");
            });

            modelBuilder.Entity<EmployeeData>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmpId).ValueGeneratedNever();

                entity.Property(e => e.MobileNumber).HasColumnName("Mobile Number");

                entity.Property(e => e.StaffName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
