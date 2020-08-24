using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NhanDemo.Models
{
    public partial class TestDemoContext : DbContext
    {
        public TestDemoContext()
        {
        }

        public TestDemoContext(DbContextOptions<TestDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chungtu> Chungtu { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Mathang> Mathang { get; set; }
        public virtual DbSet<Phieuthu> Phieuthu { get; set; }
        public virtual DbSet<VwViewChungTu> VwViewChungTu { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=TestDemo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chungtu>(entity =>
            {
                entity.HasKey(e => e.Idchungtu);

                entity.ToTable("CHUNGTU");

                entity.Property(e => e.Idchungtu).HasColumnName("IDCHUNGTU");

                entity.Property(e => e.Dongia)
                    .HasColumnName("DONGIA")
                    .HasColumnType("money");

                entity.Property(e => e.Idkhachhang).HasColumnName("IDKHACHHANG");

                entity.Property(e => e.Idmathang).HasColumnName("IDMATHANG");

                entity.Property(e => e.Ngaylapchungtu)
                    .HasColumnName("NGAYLAPCHUNGTU")
                    .HasColumnType("date");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.HasOne(d => d.IdkhachhangNavigation)
                    .WithMany(p => p.Chungtu)
                    .HasForeignKey(d => d.Idkhachhang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CHUNGTU_KHACHHANG");

                entity.HasOne(d => d.IdmathangNavigation)
                    .WithMany(p => p.Chungtu)
                    .HasForeignKey(d => d.Idmathang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CHUNGTU_MATHANG");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Idkhachhang);

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.Idkhachhang).HasColumnName("IDKHACHHANG");

                entity.Property(e => e.Diachikhachhang)
                    .IsRequired()
                    .HasColumnName("DIACHIKHACHHANG")
                    .HasMaxLength(50);

                entity.Property(e => e.Hotenkhachhang)
                    .IsRequired()
                    .HasColumnName("HOTENKHACHHANG")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Mathang>(entity =>
            {
                entity.HasKey(e => e.Idmathang);

                entity.ToTable("MATHANG");

                entity.Property(e => e.Idmathang).HasColumnName("IDMATHANG");

                entity.Property(e => e.Giaban).HasColumnName("GIABAN");

                entity.Property(e => e.Loaihang)
                    .IsRequired()
                    .HasColumnName("LOAIHANG")
                    .HasMaxLength(50);

                entity.Property(e => e.Quycach)
                    .IsRequired()
                    .HasColumnName("QUYCACH")
                    .HasMaxLength(50);

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tenhang)
                    .IsRequired()
                    .HasColumnName("TENHANG")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Phieuthu>(entity =>
            {
                entity.HasKey(e => e.Idphieuthu);

                entity.ToTable("PHIEUTHU");

                entity.Property(e => e.Idphieuthu).HasColumnName("IDPHIEUTHU");

                entity.Property(e => e.Idchungtu).HasColumnName("IDCHUNGTU");

                entity.Property(e => e.Ngaythutien)
                    .HasColumnName("NGAYTHUTIEN")
                    .HasColumnType("date");

                entity.Property(e => e.Sotienthu)
                    .HasColumnName("SOTIENTHU")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdchungtuNavigation)
                    .WithMany(p => p.Phieuthu)
                    .HasForeignKey(d => d.Idchungtu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUTHU_CHUNGTU");
            });

            modelBuilder.Entity<VwViewChungTu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ViewChungTu");

                entity.Property(e => e.Dongia)
                    .HasColumnName("DONGIA")
                    .HasColumnType("money");

                entity.Property(e => e.Idchungtu)
                    .HasColumnName("IDCHUNGTU")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idkhachhang).HasColumnName("IDKHACHHANG");

                entity.Property(e => e.Idmathang).HasColumnName("IDMATHANG");

                entity.Property(e => e.Ngaylapchungtu)
                    .HasColumnName("NGAYLAPCHUNGTU")
                    .HasColumnType("date");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
