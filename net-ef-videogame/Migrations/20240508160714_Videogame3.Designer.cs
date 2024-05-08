﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using net_ef_videogame;

#nullable disable

namespace net_ef_videogame.Migrations
{
    [DbContext(typeof(VideogameContext))]
    [Migration("20240508160714_Videogame3")]
    partial class Videogame3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("net_ef_videogame.Software_House", b =>
                {
                    b.Property<int>("HouseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HouseID"));

                    b.Property<string>("_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("software_house_city");

                    b.Property<string>("_country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("software_house_country");

                    b.Property<DateTime>("_created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("software_house_name");

                    b.Property<string>("_tax_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("software_house__tax_id");

                    b.Property<DateTime>("_updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("HouseID");

                    b.HasIndex("_tax_id")
                        .IsUnique();

                    b.ToTable("software_houses");
                });

            modelBuilder.Entity("net_ef_videogame.Videogame", b =>
                {
                    b.Property<int>("VideogameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VideogameID"));

                    b.Property<int>("SoftwareHouseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("_created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("videogame_description");

                    b.Property<string>("_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("videogame_name");

                    b.Property<DateTime>("_release")
                        .HasColumnType("datetime2")
                        .HasColumnName("videogame_release");

                    b.Property<DateTime>("_updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("VideogameID");

                    b.HasIndex("SoftwareHouseID");

                    b.ToTable("videogame");
                });

            modelBuilder.Entity("net_ef_videogame.Videogame", b =>
                {
                    b.HasOne("net_ef_videogame.Software_House", "SoftwareHouse")
                        .WithMany("Videogames")
                        .HasForeignKey("SoftwareHouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SoftwareHouse");
                });

            modelBuilder.Entity("net_ef_videogame.Software_House", b =>
                {
                    b.Navigation("Videogames");
                });
#pragma warning restore 612, 618
        }
    }
}
