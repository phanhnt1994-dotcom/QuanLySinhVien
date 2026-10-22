using Microsoft.EntityFrameworkCore;
using QuanLySinhVien.Models;

namespace QuanLySinhVien
{
    public class QuanLySinhVienDbContext : DbContext
    {
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Khoa> Khoas { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\MSSQLLocalDB;Database=QuanLySinhVienDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SinhVien>()
                .HasOne(sv => sv.Khoa)
                .WithMany(k => k.SinhViens)
                .HasForeignKey(sv => sv.KhoaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SinhVien>()
                .HasIndex(sv => sv.MaSV)
                .IsUnique();
        }
    }
}