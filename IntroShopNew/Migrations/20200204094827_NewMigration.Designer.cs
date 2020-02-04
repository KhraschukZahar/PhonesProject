﻿// <auto-generated />
using System;
using IntroShopNew.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IntroShopNew.Migrations
{
    [DbContext(typeof(DBContent))]
    [Migration("20200204094827_NewMigration")]
    partial class NewMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IntroShopNew.Main.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription");

                    b.Property<string>("categoryName");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("IntroShopNew.Main.Models.CategoryMotherboard", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription");

                    b.Property<string>("categoryName");

                    b.HasKey("id");

                    b.ToTable("CategoryMotherboarddd");
                });

            modelBuilder.Entity("IntroShopNew.Main.Models.Motherboard", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryMotherboardid");

                    b.Property<string>("description");

                    b.Property<string>("img");

                    b.Property<string>("name");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("CategoryMotherboardid");

                    b.ToTable("Motherboard");
                });

            modelBuilder.Entity("IntroShopNew.Main.Models.Phone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Categoryid");

                    b.Property<string>("description");

                    b.Property<string>("img");

                    b.Property<string>("name");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("Categoryid");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("IntroShopNew.Main.Models.Motherboard", b =>
                {
                    b.HasOne("IntroShopNew.Main.Models.CategoryMotherboard", "CategoryMotherboard")
                        .WithMany("motherboards")
                        .HasForeignKey("CategoryMotherboardid");
                });

            modelBuilder.Entity("IntroShopNew.Main.Models.Phone", b =>
                {
                    b.HasOne("IntroShopNew.Main.Models.Category", "Category")
                        .WithMany("phones")
                        .HasForeignKey("Categoryid");
                });
#pragma warning restore 612, 618
        }
    }
}
