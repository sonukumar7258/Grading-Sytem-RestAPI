﻿// <auto-generated />
using GradingModule.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GradingModule.Migrations
{
    [DbContext(typeof(GradingModuleContext))]
    partial class GradingModuleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GradingModule.Models.Category", b =>
                {
                    b.Property<string>("stud_id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnOrder(1);

                    b.Property<string>("course_id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnOrder(2);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("CategoryNameSequence")
                        .HasColumnType("int");

                    b.Property<double>("TotalMarks")
                        .HasColumnType("float");

                    b.Property<double>("marks")
                        .HasColumnType("float");

                    b.HasKey("stud_id", "course_id", "CategoryName", "CategoryNameSequence");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GradingModule.Models.Course", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("credithours")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("pre_requisite")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("GradingModule.Models.Marks", b =>
                {
                    b.Property<string>("stud_id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnOrder(1);

                    b.Property<string>("course_id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnOrder(2);

                    b.Property<string>("grade")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<double>("marks")
                        .HasColumnType("float");

                    b.Property<string>("semester")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("stud_id", "course_id");

                    b.HasIndex("course_id");

                    b.ToTable("marks");
                });

            modelBuilder.Entity("GradingModule.Models.Registeration", b =>
                {
                    b.Property<string>("stud_id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnOrder(1);

                    b.Property<string>("course_id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnOrder(2);

                    b.Property<string>("c_status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("pre_requisite")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("section")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("stud_id", "course_id");

                    b.ToTable("registerations");
                });

            modelBuilder.Entity("GradingModule.Models.Student", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("cgpa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_number")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("current_sem")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("depart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("fname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("section")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("student_batch")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("GradingModule.Models.Teacher", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("designation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("GradingModule.Models.TeacherCourse", b =>
                {
                    b.Property<string>("teacher_id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnOrder(1);

                    b.Property<string>("course_id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnOrder(2);

                    b.Property<string>("section")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnOrder(3);

                    b.HasKey("teacher_id", "course_id", "section");

                    b.ToTable("teacherCourses");
                });

            modelBuilder.Entity("GradingModule.Models.Marks", b =>
                {
                    b.HasOne("GradingModule.Models.Course", "Courses")
                        .WithMany()
                        .HasForeignKey("course_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GradingModule.Models.Student", "Students")
                        .WithMany()
                        .HasForeignKey("stud_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
