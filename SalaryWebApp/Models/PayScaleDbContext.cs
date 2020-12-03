using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SalaryWebApp
{
    public partial class PayScaleDbContext : DbContext
    {
        public PayScaleDbContext()
        {
        }

        public PayScaleDbContext(DbContextOptions<PayScaleDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Salary> Salaries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-TM1BT72\\MSSQLSERVER01;database=PayScaleDb;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salary>(entity =>
            {
                entity.HasKey(e => e.PayBand)
                    .HasName("PK__Salary__66B0F53F33542EF2");

                entity.ToTable("Salary");

                entity.Property(e => e.PayBand)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Da)
                    .HasColumnName("DA")
                    .HasComputedColumnSql("([BasicSalary]*(0.05))", true);

                entity.Property(e => e.Hra)
                    .HasColumnName("HRA")
                    .HasComputedColumnSql("([BasicSalary]*(0.10))", true);

                entity.Property(e => e.Ta)
                    .HasColumnName("TA")
                    .HasComputedColumnSql("([BasicSalary]*(0.05))", true);

                entity.Property(e => e.Tds)
                    .HasColumnName("TDS")
                    .HasComputedColumnSql("([BasicSalary]*(0.10))", true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
