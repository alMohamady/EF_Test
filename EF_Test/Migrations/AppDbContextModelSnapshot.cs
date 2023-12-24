﻿// <auto-generated />
using System;
using EF_Test;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Test.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Test.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books", (string)null);
                });

            modelBuilder.Entity("EF_Test.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("des")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments", (string)null);
                });

            modelBuilder.Entity("EF_Test.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("chemistry")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("physics")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("programming")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("studentId")
                        .IsUnique();

                    b.ToTable("Grades", (string)null);
                });

            modelBuilder.Entity("EF_Test.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("departmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("EF_Test.Models.StudentBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("bookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("getDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("bookId");

                    b.HasIndex("studentId");

                    b.ToTable("StudentBooks", (string)null);
                });

            modelBuilder.Entity("EF_Test.Models.Grade", b =>
                {
                    b.HasOne("EF_Test.Models.Student", "student")
                        .WithOne("grade")
                        .HasForeignKey("EF_Test.Models.Grade", "studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("student");
                });

            modelBuilder.Entity("EF_Test.Models.Student", b =>
                {
                    b.HasOne("EF_Test.Models.Department", "department")
                        .WithMany("students")
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("EF_Test.Models.StudentBook", b =>
                {
                    b.HasOne("EF_Test.Models.Book", "book")
                        .WithMany("Students")
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Test.Models.Student", "student")
                        .WithMany("books")
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("student");
                });

            modelBuilder.Entity("EF_Test.Models.Book", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("EF_Test.Models.Department", b =>
                {
                    b.Navigation("students");
                });

            modelBuilder.Entity("EF_Test.Models.Student", b =>
                {
                    b.Navigation("books");

                    b.Navigation("grade")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
