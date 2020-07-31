using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VacationalAgency.Domain.Models
{
    public partial class VacationalAgencyContext : DbContext
    {
        public VacationalAgencyContext()
        {
        }

        public VacationalAgencyContext(DbContextOptions<VacationalAgencyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HolidayHomeOwner> HolidayHomeOwner { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=PTLW10JROVIRALT\\SQLEXPRESS;Initial Catalog=VacationalAgency;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HolidayHomeOwner>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nif)
                    .IsRequired()
                    .HasColumnName("nif")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
