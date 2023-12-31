﻿// <auto-generated />
using System;
using Infra.DatabaseConfiguration_EF_AvansSurplusMealService.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Migrations
{
    [DbContext(typeof(SurplusDatabaseContext))]
    [Migration("20221005154209_Add fk cantin")]
    partial class Addfkcantin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Domain.Domain.Cantine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ServesWarmMeals")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Cantines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Breda",
                            Location = "LD-Gebouw",
                            OtherInfo = "Niets",
                            ServesWarmMeals = true
                        },
                        new
                        {
                            Id = 2,
                            City = "Breda",
                            Location = "LA-Gebouw",
                            OtherInfo = "Is te vinden op de vijfde etage van het LA gebouw",
                            ServesWarmMeals = false
                        });
                });

            modelBuilder.Entity("Core.Domain.Domain.MealPacket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CantineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateToReceive")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Opgehaald")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("OphalingsDatum")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ReserveDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StudentClaimId")
                        .HasColumnType("int");

                    b.Property<string>("TypeMeal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CantineId");

                    b.HasIndex("StudentClaimId");

                    b.ToTable("MealPackets");
                });

            modelBuilder.Entity("Core.Domain.Domain.MealPacketProduct", b =>
                {
                    b.Property<int>("MealPacketId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("MealPacketId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductList");
                });

            modelBuilder.Entity("Core.Domain.Domain.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cantineId")
                        .HasColumnType("int");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("cantineId");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("Core.Domain.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Alcoholic")
                        .HasColumnType("bit");

                    b.Property<string>("Base64Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WarmMeal")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Core.Domain.Domain.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoShows")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2001, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "xin20wang@example.com",
                            Name = "Dave",
                            NoShows = 0,
                            StudentId = "200000",
                            role = "Student"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(2002, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Test@example.com",
                            Name = "Test",
                            NoShows = 0,
                            StudentId = "200001",
                            role = "Student"
                        });
                });

            modelBuilder.Entity("Core.Domain.Domain.MealPacket", b =>
                {
                    b.HasOne("Core.Domain.Domain.Cantine", "Cantine")
                        .WithMany("MealList")
                        .HasForeignKey("CantineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Domain.Student", "StudentClaim")
                        .WithMany("MealReservations")
                        .HasForeignKey("StudentClaimId");

                    b.Navigation("Cantine");

                    b.Navigation("StudentClaim");
                });

            modelBuilder.Entity("Core.Domain.Domain.MealPacketProduct", b =>
                {
                    b.HasOne("Core.Domain.Domain.MealPacket", "MealPacket")
                        .WithMany("ProductList")
                        .HasForeignKey("MealPacketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Domain.Product", "Product")
                        .WithMany("ProductList")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MealPacket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Domain.Domain.Personel", b =>
                {
                    b.HasOne("Core.Domain.Domain.Cantine", "cantine")
                        .WithMany("PersonelList")
                        .HasForeignKey("cantineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cantine");
                });

            modelBuilder.Entity("Core.Domain.Domain.Cantine", b =>
                {
                    b.Navigation("MealList");

                    b.Navigation("PersonelList");
                });

            modelBuilder.Entity("Core.Domain.Domain.MealPacket", b =>
                {
                    b.Navigation("ProductList");
                });

            modelBuilder.Entity("Core.Domain.Domain.Product", b =>
                {
                    b.Navigation("ProductList");
                });

            modelBuilder.Entity("Core.Domain.Domain.Student", b =>
                {
                    b.Navigation("MealReservations");
                });
#pragma warning restore 612, 618
        }
    }
}
