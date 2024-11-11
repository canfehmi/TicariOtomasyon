﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicariOtomasyon.Models.Entities;

#nullable disable

namespace TicariOtomasyon.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("KullaniciAd")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Varchar(10)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Varchar(10)");

                    b.Property<string>("Yetki")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("Char(1)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Cariler", b =>
                {
                    b.Property<int>("CariId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CariId"), 1L, 1);

                    b.Property<string>("CariAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("CariMail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("CariSehir")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("Varchar(13)");

                    b.Property<string>("CariSoyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("CariId");

                    b.ToTable("Carilers");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Departman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartmanAdi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Departmans");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Detay", b =>
                {
                    b.Property<int>("DetayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetayId"), 1L, 1);

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("UrunBilgi")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("Varchar(2000)");

                    b.HasKey("DetayId");

                    b.ToTable("Detays");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.FaturaKalem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FaturalarId")
                        .HasColumnType("int");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("FaturalarId");

                    b.ToTable("FaturaKalems");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Faturalar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FaturaSeriNo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("Char(1)");

                    b.Property<string>("FaturaSıraNo")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("Varchar(6)");

                    b.Property<DateTime>("FaturaTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Saat")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("Char(5)");

                    b.Property<string>("TeslimAlan")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("TeslimEden")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<decimal>("Toplam")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("Varchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Faturalars");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Gider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Giders");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriId"), 1L, 1);

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmanId")
                        .HasColumnType("int");

                    b.Property<string>("PersonelAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("PersonelGorsel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.Property<string>("PersonelSoyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmanId");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.SatisHareket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("CarilerCariId")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ToplamTutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarilerCariId");

                    b.HasIndex("PersonelId");

                    b.HasIndex("UrunId");

                    b.ToTable("SatisHarekets");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Todos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("AlisFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<decimal>("SatisFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("Stok")
                        .HasColumnType("smallint");

                    b.Property<string>("UrunAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("UrunGorsel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Uruns");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.FaturaKalem", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Entities.Faturalar", "Faturalar")
                        .WithMany("FaturaKalems")
                        .HasForeignKey("FaturalarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faturalar");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Personel", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Entities.Departman", "Departman")
                        .WithMany("Personels")
                        .HasForeignKey("DepartmanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.SatisHareket", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Entities.Cariler", "Cariler")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("CarilerCariId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicariOtomasyon.Models.Entities.Personel", "Personel")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicariOtomasyon.Models.Entities.Urun", "Urun")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cariler");

                    b.Navigation("Personel");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Urun", b =>
                {
                    b.HasOne("TicariOtomasyon.Models.Entities.Kategori", "Kategori")
                        .WithMany("Uruns")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Cariler", b =>
                {
                    b.Navigation("SatisHarekets");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Departman", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Faturalar", b =>
                {
                    b.Navigation("FaturaKalems");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Kategori", b =>
                {
                    b.Navigation("Uruns");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Personel", b =>
                {
                    b.Navigation("SatisHarekets");
                });

            modelBuilder.Entity("TicariOtomasyon.Models.Entities.Urun", b =>
                {
                    b.Navigation("SatisHarekets");
                });
#pragma warning restore 612, 618
        }
    }
}
