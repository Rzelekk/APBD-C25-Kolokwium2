﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Backpacks", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("backpacks");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            ItemId = 2,
                            Amount = 32
                        },
                        new
                        {
                            CharacterId = 1,
                            ItemId = 1,
                            Amount = 1
                        },
                        new
                        {
                            CharacterId = 2,
                            ItemId = 1,
                            Amount = 32
                        },
                        new
                        {
                            CharacterId = 2,
                            ItemId = 2,
                            Amount = 2
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.CharacterTitles", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AcquiredAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CharacterId", "TitleId");

                    b.HasIndex("TitleId");

                    b.ToTable("character_titles");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            TitleId = 1,
                            AcquiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CharacterId = 2,
                            TitleId = 2,
                            AcquiredAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Characters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentWei")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("MaxWeight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("character");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentWei = 90,
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            MaxWeight = 100
                        },
                        new
                        {
                            Id = 2,
                            CurrentWei = 60,
                            FirstName = "Wan",
                            LastName = "Jarski",
                            MaxWeight = 80
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Item1",
                            Weight = 12
                        },
                        new
                        {
                            Id = 2,
                            Name = "Item2",
                            Weight = 32
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Titles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("titles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Title1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Title2"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Backpacks", b =>
                {
                    b.HasOne("WebApplication1.Models.Characters", "Character")
                        .WithMany("Backpacks")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Items", "Item")
                        .WithMany("Backpacks")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("WebApplication1.Models.CharacterTitles", b =>
                {
                    b.HasOne("WebApplication1.Models.Characters", "Character")
                        .WithMany("CharacterTitles")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Titles", "Title")
                        .WithMany("CharacterTitles")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("WebApplication1.Models.Characters", b =>
                {
                    b.Navigation("Backpacks");

                    b.Navigation("CharacterTitles");
                });

            modelBuilder.Entity("WebApplication1.Models.Items", b =>
                {
                    b.Navigation("Backpacks");
                });

            modelBuilder.Entity("WebApplication1.Models.Titles", b =>
                {
                    b.Navigation("CharacterTitles");
                });
#pragma warning restore 612, 618
        }
    }
}