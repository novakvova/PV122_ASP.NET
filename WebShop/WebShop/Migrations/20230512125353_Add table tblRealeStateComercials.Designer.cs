﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebShop.Data;

#nullable disable

namespace WebShop.Migrations
{
    [DbContext(typeof(AppEFContext))]
    [Migration("20230512125353_Add table tblRealeStateComercials")]
    partial class AddtabletblRealeStateComercials
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebShop.Data.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<string>("Image")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("tblCategories");
                });

            modelBuilder.Entity("WebShop.Data.Entities.RealeStateComercialEntity", b =>
                {
                    b.Property<int>("RealeStateId")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.HasKey("RealeStateId");

                    b.ToTable("tblRealeStateComercials");
                });

            modelBuilder.Entity("WebShop.Data.Entities.RealeStateEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<string>("Image")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Price")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("tblRealeStates");
                });

            modelBuilder.Entity("WebShop.Data.Entities.CategoryEntity", b =>
                {
                    b.HasOne("WebShop.Data.Entities.CategoryEntity", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("WebShop.Data.Entities.RealeStateComercialEntity", b =>
                {
                    b.HasOne("WebShop.Data.Entities.RealeStateEntity", "RealeState")
                        .WithOne("RealeStateComercial")
                        .HasForeignKey("WebShop.Data.Entities.RealeStateComercialEntity", "RealeStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RealeState");
                });

            modelBuilder.Entity("WebShop.Data.Entities.RealeStateEntity", b =>
                {
                    b.HasOne("WebShop.Data.Entities.CategoryEntity", "Category")
                        .WithMany("RealeStates")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebShop.Data.Entities.CategoryEntity", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("RealeStates");
                });

            modelBuilder.Entity("WebShop.Data.Entities.RealeStateEntity", b =>
                {
                    b.Navigation("RealeStateComercial");
                });
#pragma warning restore 612, 618
        }
    }
}
