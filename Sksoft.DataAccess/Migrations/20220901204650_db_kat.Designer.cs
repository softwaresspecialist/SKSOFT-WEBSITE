﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sksoft.DataAccess;

#nullable disable

namespace Sksoft.DataAccess.Migrations
{
    [DbContext(typeof(SksContext))]
    [Migration("20220901204650_db_kat")]
    partial class db_kat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Sksoft.Entity.Ayarlar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hakkimizda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ayarlar");
                });

            modelBuilder.Entity("Sksoft.Entity.BaseEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BaseEntities");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseEntity");
                });

            modelBuilder.Entity("Sksoft.Entity.Iletisim", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AdiSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefon")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Iletisim");
                });

            modelBuilder.Entity("Sksoft.Entity.Kullanici", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<bool>("BeniHatirla")
                        .HasColumnType("bit");

                    b.Property<string>("ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("Sksoft.Entity.Blog", b =>
                {
                    b.HasBaseType("Sksoft.Entity.BaseEntity");

                    b.Property<int>("OkunmaSayisi")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Blog");
                });

            modelBuilder.Entity("Sksoft.Entity.Hakkimizda", b =>
                {
                    b.HasBaseType("Sksoft.Entity.BaseEntity");

                    b.HasDiscriminator().HasValue("Hakkimizda");
                });

            modelBuilder.Entity("Sksoft.Entity.Slider", b =>
                {
                    b.HasBaseType("Sksoft.Entity.BaseEntity");

                    b.HasDiscriminator().HasValue("Slider");
                });

            modelBuilder.Entity("Sksoft.Entity.Urunlerimiz", b =>
                {
                    b.HasBaseType("Sksoft.Entity.BaseEntity");

                    b.HasDiscriminator().HasValue("Urunlerimiz");
                });
#pragma warning restore 612, 618
        }
    }
}