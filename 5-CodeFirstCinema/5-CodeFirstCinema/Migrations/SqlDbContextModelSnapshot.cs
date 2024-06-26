﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _5_CodeFirstCinema.Contexts;

#nullable disable

namespace _5_CodeFirstCinema.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_5_CodeFirstCinema.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("YonetmenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.HasIndex("YonetmenId");

                    b.ToTable("Filmler");
                });

            modelBuilder.Entity("_5_CodeFirstCinema.Models.Gosterim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("SalonId")
                        .HasColumnType("int");

                    b.Property<int?>("SeansId")
                        .HasColumnType("int");

                    b.Property<int>("SenanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("SalonId");

                    b.HasIndex("SeansId");

                    b.ToTable("Gosterim");
                });

            modelBuilder.Entity("_5_CodeFirstCinema.Models.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("_5_CodeFirstCinema.Models.Salon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("Kapasite")
                        .HasColumnType("tinyint");

                    b.Property<string>("SalonAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("SalonAdi")
                        .IsUnique()
                        .HasFilter("[SalonAdi] IS NOT NULL");

                    b.ToTable("Salonlar");
                });

            modelBuilder.Entity("_5_CodeFirstCinema.Models.Seans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SeansAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Seans");
                });

            modelBuilder.Entity("_5_CodeFirstCinema.Models.Yonetmen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Cinsiyet")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Yonetmen");
                });

            modelBuilder.Entity("_5_CodeFirstCinema.Models.Film", b =>
                {
                    b.HasOne("_5_CodeFirstCinema.Models.Kategori", "Kategori")
                        .WithMany("Filmler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_5_CodeFirstCinema.Models.Yonetmen", "Yonetmen")
                        .WithMany("Filmler")
                        .HasForeignKey("YonetmenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Yonetmen");
                });

            modelBuilder.Entity("_5_CodeFirstCinema.Models.Gosterim", b =>
                {
                    b.HasOne("_5_CodeFirstCinema.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_5_CodeFirstCinema.Models.Salon", "Salon")
                        .WithMany()
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_5_CodeFirstCinema.Models.Seans", "Seans")
                        .WithMany()
                        .HasForeignKey("SeansId");

                    b.Navigation("Film");

                    b.Navigation("Salon");

                    b.Navigation("Seans");
                });

            modelBuilder.Entity("_5_CodeFirstCinema.Models.Kategori", b =>
                {
                    b.Navigation("Filmler");
                });

            modelBuilder.Entity("_5_CodeFirstCinema.Models.Yonetmen", b =>
                {
                    b.Navigation("Filmler");
                });
#pragma warning restore 612, 618
        }
    }
}
