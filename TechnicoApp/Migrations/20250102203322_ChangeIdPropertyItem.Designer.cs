﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechnicoApp.Context;

#nullable disable

namespace TechnicoApp.Migrations
{
    [DbContext(typeof(TechnicoDbContext))]
    [Migration("20250102203322_ChangeIdPropertyItem")]
    partial class ChangeIdPropertyItem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PropertyOwner", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Repairs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<string>("VatNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertyOwners");
                });

            modelBuilder.Entity("TechnicoApp.Domain.Models.PropertyItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<long>("PropertyIdentificationNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("PropertyOwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PropertyOwnerVatNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyType")
                        .HasColumnType("int");

                    b.Property<int>("YearOfConstruction")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyOwnerId");

                    b.ToTable("PropertyItems");
                });

            modelBuilder.Entity("TechnicoApp.Domain.Models.PropertyItem", b =>
                {
                    b.HasOne("PropertyOwner", null)
                        .WithMany("PropertyItems")
                        .HasForeignKey("PropertyOwnerId");
                });

            modelBuilder.Entity("PropertyOwner", b =>
                {
                    b.Navigation("PropertyItems");
                });
#pragma warning restore 612, 618
        }
    }
}
