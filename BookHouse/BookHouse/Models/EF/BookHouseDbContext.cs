using BookHouse.Models.Entinities;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.EF
{
    public class BookHouseDbContext : DbContext
    {
        public BookHouseDbContext(DbContextOptions<BookHouseDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DauSach>()
                .HasOne<ChuyenNganh>(s => s.ChuyenNganh)
                .WithMany(g => g.dauSachs)
                .HasForeignKey(s => s._ChuyenNganhId);

            modelBuilder.Entity<Sach>()
               .HasOne<DauSach>(s => s.DauSach)
               .WithMany(g => g.Sachs)
               .HasForeignKey(s => s._DauSachId);

            modelBuilder.Entity<DocGia>()
             .HasOne<Lop>(s => s.Lop)
             .WithMany(g => g.DocGias)
             .HasForeignKey(s => s._LopId);

        }

        public DbSet<ChuyenNganh> ChuyenNganhs { get; set; }
        public DbSet<DauSach> DauSachs { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<DocGia>    DocGias { get; set; }

    }
}
