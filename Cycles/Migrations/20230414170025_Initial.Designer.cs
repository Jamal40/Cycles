﻿// <auto-generated />
using System;
using Cycles.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cycles.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20230414170025_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarHouse", b =>
                {
                    b.Property<int>("HousesId")
                        .HasColumnType("int");

                    b.Property<int>("HousesId1")
                        .HasColumnType("int");

                    b.HasKey("HousesId", "HousesId1");

                    b.HasIndex("HousesId1");

                    b.ToTable("CarHouse");
                });

            modelBuilder.Entity("Cycles.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId")
                        .IsUnique();

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Cycles.Data.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId")
                        .IsUnique();

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("Cycles.Data.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("Identifier")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("CarHouse", b =>
                {
                    b.HasOne("Cycles.Data.Models.Car", null)
                        .WithMany()
                        .HasForeignKey("HousesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cycles.Data.Models.House", null)
                        .WithMany()
                        .HasForeignKey("HousesId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cycles.Data.Models.Car", b =>
                {
                    b.HasOne("Cycles.Data.Models.Property", "Property")
                        .WithOne("Car")
                        .HasForeignKey("Cycles.Data.Models.Car", "PropertyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Cycles.Data.Models.House", b =>
                {
                    b.HasOne("Cycles.Data.Models.Property", "Property")
                        .WithOne("House")
                        .HasForeignKey("Cycles.Data.Models.House", "PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Cycles.Data.Models.Property", b =>
                {
                    b.Navigation("Car");

                    b.Navigation("House");
                });
#pragma warning restore 612, 618
        }
    }
}
