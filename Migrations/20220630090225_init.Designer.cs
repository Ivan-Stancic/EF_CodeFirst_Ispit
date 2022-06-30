﻿// <auto-generated />
using System;
using EF_CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_CodeFirst.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220630090225_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF_CodeFirst.Models.Dbo.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Grade");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GradeName = "Odličan",
                            Section = "Hravtski",
                            StudentId = 1,
                            Title = "5"
                        },
                        new
                        {
                            Id = 2,
                            GradeName = "Vrlo dobar",
                            Section = "Likovni",
                            StudentId = 1,
                            Title = "4"
                        },
                        new
                        {
                            Id = 3,
                            GradeName = "Dobar",
                            Section = "Matematika",
                            StudentId = 1,
                            Title = "3"
                        },
                        new
                        {
                            Id = 4,
                            GradeName = "Odličan",
                            Section = "Matematika",
                            StudentId = 2,
                            Title = "5"
                        },
                        new
                        {
                            Id = 5,
                            GradeName = "Dovoljan",
                            Section = "Glazbeni",
                            StudentId = 2,
                            Title = "2"
                        },
                        new
                        {
                            Id = 6,
                            GradeName = "Vrlo dobar",
                            Section = "Hravtski",
                            StudentId = 2,
                            Title = "4"
                        },
                        new
                        {
                            Id = 7,
                            GradeName = "Dovoljan",
                            Section = "Informatika",
                            StudentId = 1,
                            Title = "2"
                        });
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Dbo.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2022, 6, 30, 9, 2, 25, 484, DateTimeKind.Utc).AddTicks(9238),
                            Height = 170m,
                            StudentName = "Borka Borkić",
                            Weight = 65f
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(2022, 6, 30, 9, 2, 25, 484, DateTimeKind.Utc).AddTicks(9241),
                            Height = 180m,
                            StudentName = "Joža Kožić",
                            Weight = 97f
                        });
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Dbo.Grade", b =>
                {
                    b.HasOne("EF_CodeFirst.Models.Dbo.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
