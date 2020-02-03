﻿// <auto-generated />
using System;
using IntroShopNew.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IntroShopNew.Migrations
{
    [DbContext(typeof(DBContent))]
    partial class DBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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