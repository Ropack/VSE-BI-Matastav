﻿// <auto-generated />
using System;
using Matastav.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Matastav.Model.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211123144828_PrijmyVydaje")]
    partial class PrijmyVydaje
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Matastav.Model.Kontrakt", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<double>("DobaTrvaniVeDnech")
                        .HasColumnType("float");

                    b.Property<decimal>("Marze")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Vydaje")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ZakaznikId")
                        .HasColumnType("int");

                    b.Property<int>("ZdrojId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.HasIndex("ZakaznikId");

                    b.HasIndex("ZdrojId");

                    b.ToTable("rour01_F_kontrakt");
                });

            modelBuilder.Entity("Matastav.Model.Kraj", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nazev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("rour01_D_kraj");
                });

            modelBuilder.Entity("Matastav.Model.Mzda", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Castka")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("PobockaId")
                        .HasColumnType("int");

                    b.Property<int>("ZamestnanecId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PobockaId");

                    b.HasIndex("ZamestnanecId");

                    b.ToTable("rour01_F_mzda");
                });

            modelBuilder.Entity("Matastav.Model.Pobocka", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nazev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("rour01_D_pobocka");
                });

            modelBuilder.Entity("Matastav.Model.Prijem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("CastkaPlan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CastkaRozdil")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CastkaSkutecnost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("ZdrojId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZdrojId");

                    b.ToTable("rour01_F_prijem");
                });

            modelBuilder.Entity("Matastav.Model.Region", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("KrajId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nazev")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("KrajId");

                    b.HasIndex("Nazev")
                        .IsUnique();

                    b.ToTable("rour01_D_region");
                });

            modelBuilder.Entity("Matastav.Model.Vydaj", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("CastkaPlan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CastkaRozdil")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CastkaSkutecnost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PobockaId")
                        .HasColumnType("int");

                    b.Property<int>("PolozkaDruhId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PobockaId");

                    b.HasIndex("PolozkaDruhId");

                    b.ToTable("rour01_F_vydaj");
                });

            modelBuilder.Entity("Matastav.Model.VydajDruh", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nazev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("rour01_D_polozka_druh");
                });

            modelBuilder.Entity("Matastav.Model.Zakaznik", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nazev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZakaznikKategorieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZakaznikKategorieId");

                    b.ToTable("rour01_D_zakaznik");
                });

            modelBuilder.Entity("Matastav.Model.ZakaznikKategorie", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nazev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("rour01_D_zakaznik_kategorie");
                });

            modelBuilder.Entity("Matastav.Model.Zamestnanec", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Jmeno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZamestnanecPoziceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZamestnanecPoziceId");

                    b.ToTable("rour01_D_zamestnanec");
                });

            modelBuilder.Entity("Matastav.Model.ZamestnanecPozice", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nazev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("rour01_D_zamestnanec_pozice");
                });

            modelBuilder.Entity("Matastav.Model.Zdroj", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nazev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZdrojKategorieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZdrojKategorieId");

                    b.ToTable("rour01_D_zdroj");
                });

            modelBuilder.Entity("Matastav.Model.ZdrojKategorie", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nazev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("rour01_D_zdroj_kategorie");
                });

            modelBuilder.Entity("Matastav.Model.Kontrakt", b =>
                {
                    b.HasOne("Matastav.Model.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Matastav.Model.Zakaznik", "Zakaznik")
                        .WithMany()
                        .HasForeignKey("ZakaznikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Matastav.Model.Zdroj", "Zdroj")
                        .WithMany()
                        .HasForeignKey("ZdrojId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");

                    b.Navigation("Zakaznik");

                    b.Navigation("Zdroj");
                });

            modelBuilder.Entity("Matastav.Model.Mzda", b =>
                {
                    b.HasOne("Matastav.Model.Pobocka", "Pobocka")
                        .WithMany()
                        .HasForeignKey("PobockaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Matastav.Model.Zamestnanec", "Zamestnanec")
                        .WithMany()
                        .HasForeignKey("ZamestnanecId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pobocka");

                    b.Navigation("Zamestnanec");
                });

            modelBuilder.Entity("Matastav.Model.Prijem", b =>
                {
                    b.HasOne("Matastav.Model.Zdroj", "Zdroj")
                        .WithMany()
                        .HasForeignKey("ZdrojId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zdroj");
                });

            modelBuilder.Entity("Matastav.Model.Region", b =>
                {
                    b.HasOne("Matastav.Model.Kraj", "Kraj")
                        .WithMany()
                        .HasForeignKey("KrajId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kraj");
                });

            modelBuilder.Entity("Matastav.Model.Vydaj", b =>
                {
                    b.HasOne("Matastav.Model.Pobocka", "Pobocka")
                        .WithMany()
                        .HasForeignKey("PobockaId");

                    b.HasOne("Matastav.Model.VydajDruh", "PolozkaDruh")
                        .WithMany()
                        .HasForeignKey("PolozkaDruhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pobocka");

                    b.Navigation("PolozkaDruh");
                });

            modelBuilder.Entity("Matastav.Model.Zakaznik", b =>
                {
                    b.HasOne("Matastav.Model.ZakaznikKategorie", "ZakaznikKategorie")
                        .WithMany()
                        .HasForeignKey("ZakaznikKategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ZakaznikKategorie");
                });

            modelBuilder.Entity("Matastav.Model.Zamestnanec", b =>
                {
                    b.HasOne("Matastav.Model.ZamestnanecPozice", "ZamestnanecPozice")
                        .WithMany()
                        .HasForeignKey("ZamestnanecPoziceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ZamestnanecPozice");
                });

            modelBuilder.Entity("Matastav.Model.Zdroj", b =>
                {
                    b.HasOne("Matastav.Model.ZdrojKategorie", "ZdrojKategorie")
                        .WithMany()
                        .HasForeignKey("ZdrojKategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ZdrojKategorie");
                });
#pragma warning restore 612, 618
        }
    }
}
