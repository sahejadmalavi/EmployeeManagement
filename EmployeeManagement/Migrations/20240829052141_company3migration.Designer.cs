﻿// <auto-generated />
using System;
using EmployeeManagement.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagement.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240829052141_company3migration")]
    partial class company3migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagement.Models.CompanyMaster", b =>
                {
                    b.Property<Guid>("CMPId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CMPCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CMPIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("CMPName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CMPUpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CMPId");

                    b.ToTable("CompanyMaster");
                });

            modelBuilder.Entity("EmployeeManagement.Models.DepartmentMaster", b =>
                {
                    b.Property<Guid>("DPTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CMPId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DPTCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DPTIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("DPTName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DPTUpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DPTId");

                    b.ToTable("DepartmentMaster");
                });

            modelBuilder.Entity("EmployeeManagement.Models.EmployeeMaster", b =>
                {
                    b.Property<Guid>("EMPId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DPTId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EMPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EMPCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EMPDob")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMPEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EMPIsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EMPJoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMPLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPPincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPQualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMPState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EMPUpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EMPId");

                    b.HasIndex("DPTId");

                    b.ToTable("EmployeeMaster");
                });

            modelBuilder.Entity("EmployeeManagement.Models.EmployeeMaster", b =>
                {
                    b.HasOne("EmployeeManagement.Models.DepartmentMaster", "department")
                        .WithMany()
                        .HasForeignKey("DPTId");

                    b.Navigation("department");
                });
#pragma warning restore 612, 618
        }
    }
}
