﻿// <auto-generated />
using System;
using BookHouse.Models.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookHouse.Migrations
{
    [DbContext(typeof(BookHouseDbContext))]
    [Migration("20200909140614_AddDBSach")]
    partial class AddDBSach
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookHouse.Models.Entinities.ChuyenNganh", b =>
                {
                    b.Property<int>("ChuyenNganhId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenChuyenNganh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_IdDauSach")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChuyenNganhId");

                    b.ToTable("ChuyenNganhs");
                });

            modelBuilder.Entity("BookHouse.Models.Entinities.DauSach", b =>
                {
                    b.Property<int>("DauSachID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NXB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongCon")
                        .HasColumnType("int");

                    b.Property<int>("SoTrang")
                        .HasColumnType("int");

                    b.Property<string>("TenDauSach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("_ChuyenNganhId")
                        .HasColumnType("int");

                    b.HasKey("DauSachID");

                    b.HasIndex("_ChuyenNganhId");

                    b.ToTable("DauSachs");
                });

            modelBuilder.Entity("BookHouse.Models.Entinities.DocGia", b =>
                {
                    b.Property<int>("DocGiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QueQuan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("_LopId")
                        .HasColumnType("int");

                    b.HasKey("DocGiaId");

                    b.HasIndex("_LopId");

                    b.ToTable("DocGias");
                });

            modelBuilder.Entity("BookHouse.Models.Entinities.Lop", b =>
                {
                    b.Property<int>("LopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLop")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LopId");

                    b.ToTable("Lops");
                });

            modelBuilder.Entity("BookHouse.Models.Entinities.Sach", b =>
                {
                    b.Property<int>("SachId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime2");

                    b.Property<string>("TacGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TinhTrang")
                        .HasColumnType("int");

                    b.Property<int>("_DauSachId")
                        .HasColumnType("int");

                    b.HasKey("SachId");

                    b.HasIndex("_DauSachId");

                    b.ToTable("Sachs");
                });

            modelBuilder.Entity("BookHouse.Models.Entinities.DauSach", b =>
                {
                    b.HasOne("BookHouse.Models.Entinities.ChuyenNganh", "ChuyenNganh")
                        .WithMany("dauSachs")
                        .HasForeignKey("_ChuyenNganhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookHouse.Models.Entinities.DocGia", b =>
                {
                    b.HasOne("BookHouse.Models.Entinities.Lop", "Lop")
                        .WithMany("DocGias")
                        .HasForeignKey("_LopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookHouse.Models.Entinities.Sach", b =>
                {
                    b.HasOne("BookHouse.Models.Entinities.DauSach", "DauSach")
                        .WithMany("Sachs")
                        .HasForeignKey("_DauSachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}