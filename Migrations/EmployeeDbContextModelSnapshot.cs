﻿// <auto-generated />
using System;
using FinalProjectAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProjectAPI.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinalProjectAPI.Entities.Employees", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("employee_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("LockStatus")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("lockstatus");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("manager");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int")
                        .HasColumnName("profile_Id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("status");

                    b.Property<string>("Wfm_Manager")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("wfm_manager");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            Email = "buvimasi@gmail.com",
                            Experience = 2,
                            LockStatus = "not_requested",
                            Manager = "Karthik",
                            Name = "Buvaneshwari",
                            ProfileId = 1,
                            Status = "Active",
                            Wfm_Manager = "Arun"
                        },
                        new
                        {
                            EmployeeID = 2,
                            Email = "karthikeyan@gmail.com",
                            Experience = 2,
                            LockStatus = "requested",
                            Manager = "Karthik",
                            Name = "Karthikeyan",
                            ProfileId = 1,
                            Status = "Active",
                            Wfm_Manager = "Arun"
                        },
                        new
                        {
                            EmployeeID = 3,
                            Email = "arun@gmail.com",
                            Experience = 2,
                            LockStatus = "not_requested",
                            Manager = "Karthik",
                            Name = "Arunkumar",
                            ProfileId = 1,
                            Status = "Active",
                            Wfm_Manager = "Guna"
                        },
                        new
                        {
                            EmployeeID = 4,
                            Email = "buvimasi@gmail.com",
                            Experience = 2,
                            LockStatus = "not_requested",
                            Manager = "Karthik",
                            Name = "Rekha",
                            ProfileId = 1,
                            Status = "Active",
                            Wfm_Manager = "Arun"
                        });
                });

            modelBuilder.Entity("FinalProjectAPI.Entities.SkillMap", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("employee_Id");

                    b.Property<int>("SkillId")
                        .HasColumnType("int")
                        .HasColumnName("skillId");

                    b.HasKey("EmployeeId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillMaps");
                });

            modelBuilder.Entity("FinalProjectAPI.Entities.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("skillId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C#/.Net"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Java"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Azure"
                        },
                        new
                        {
                            Id = 4,
                            Name = "React"
                        });
                });

            modelBuilder.Entity("FinalProjectAPI.Entities.SoftLock", b =>
                {
                    b.Property<int>("LockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("lockId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LockId"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_Id");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2")
                        .HasColumnName("lastupdated");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("manager");

                    b.Property<string>("ManagerStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("managerstatus");

                    b.Property<string>("MgrLastupdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("mgrlastupdate");

                    b.Property<string>("MgrStatuscomment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("mgrstatuscomment");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("reqdate");

                    b.Property<string>("RequestMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("requestmessage");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.Property<string>("Wfmremark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("wfmremark");

                    b.HasKey("LockId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("SoftLocks");
                });

            modelBuilder.Entity("FinalProjectAPI.Entities.User", b =>
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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FinalProjectAPI.Entities.SkillMap", b =>
                {
                    b.HasOne("FinalProjectAPI.Entities.Employees", "Employees")
                        .WithMany("SkillMaps")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProjectAPI.Entities.Skills", "Skills")
                        .WithMany("SkillMaps")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("FinalProjectAPI.Entities.SoftLock", b =>
                {
                    b.HasOne("FinalProjectAPI.Entities.Employees", "Employees")
                        .WithMany("SoftLocks")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("FinalProjectAPI.Entities.Employees", b =>
                {
                    b.Navigation("SkillMaps");

                    b.Navigation("SoftLocks");
                });

            modelBuilder.Entity("FinalProjectAPI.Entities.Skills", b =>
                {
                    b.Navigation("SkillMaps");
                });
#pragma warning restore 612, 618
        }
    }
}
