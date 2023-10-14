﻿// <auto-generated />
using System;
using EvaluationSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EvaluationSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231012100953_AddAnswersTable")]
    partial class AddAnswersTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EvaluationSystem.Models.ProfessorTableModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("dateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("professorFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("professorId")
                        .HasColumnType("int");

                    b.Property<string>("professorLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professors");
                });

            modelBuilder.Entity("EvaluationSystem.Models.StudentAnswersTable", b =>
                {
                    b.Property<int>("answerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("answerId"), 1L, 1);

                    b.Property<string>("answerFive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("answerFour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("answerOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("answerThree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("answerTwo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateEvaluated")
                        .HasColumnType("datetime2");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("professorId")
                        .HasColumnType("int");

                    b.Property<int>("studentNumber")
                        .HasColumnType("int");

                    b.Property<int>("yearLevel")
                        .HasColumnType("int");

                    b.HasKey("answerId");

                    b.HasIndex("professorId");

                    b.HasIndex("studentNumber");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("EvaluationSystem.Models.StudentTableModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("dateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("studentCourse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("studentNumber")
                        .HasColumnType("int");

                    b.Property<int>("studentYearLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EvaluationSystem.Models.StudentAnswersTable", b =>
                {
                    b.HasOne("EvaluationSystem.Models.ProfessorTableModel", "Professor")
                        .WithMany()
                        .HasForeignKey("professorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvaluationSystem.Models.StudentTableModel", "Student")
                        .WithMany()
                        .HasForeignKey("studentNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}