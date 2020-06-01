﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.Data;

namespace OnlineShop.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20200531083025_AddRouting")]
    partial class AddRouting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineShop.Data.Models.CartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CartId");

                    b.Property<int>("price");

                    b.Property<int?>("productid");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("OnlineShop.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName");

                    b.Property<string>("description");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OnlineShop.Data.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Categoryid");

                    b.Property<bool>("available");

                    b.Property<string>("categoryName");

                    b.Property<string>("img");

                    b.Property<bool>("isFavourite");

                    b.Property<string>("longDescr");

                    b.Property<string>("name");

                    b.Property<int>("price");

                    b.Property<string>("shortDescr");

                    b.HasKey("id");

                    b.HasIndex("Categoryid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OnlineShop.Data.Models.CartItem", b =>
                {
                    b.HasOne("OnlineShop.Data.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid");
                });

            modelBuilder.Entity("OnlineShop.Data.Models.Product", b =>
                {
                    b.HasOne("OnlineShop.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Categoryid");
                });
#pragma warning restore 612, 618
        }
    }
}