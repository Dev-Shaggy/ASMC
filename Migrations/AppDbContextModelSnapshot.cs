﻿// <auto-generated />
using System;
using AdvancedSchoolManagment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvancedSchoolManagment.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.AbsenceDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LessonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubjectDTOId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectDTOId");

                    b.ToTable("Absences");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.ApplicationUserDTO", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PESEL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<Guid?>("WorkerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("ParentId")
                        .IsUnique()
                        .HasFilter("[ParentId] IS NOT NULL");

                    b.HasIndex("StudentId")
                        .IsUnique()
                        .HasFilter("[StudentId] IS NOT NULL");

                    b.HasIndex("WorkerId")
                        .IsUnique()
                        .HasFilter("[WorkerId] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.ClassDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.ClassroomDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId")
                        .IsUnique();

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.LessonDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClassroomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TimetableId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.HasIndex("TimetableId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.LessonHoursDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BeginTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LessonHours");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.MarkSchemaDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(4,2)");

                    b.HasKey("Id");

                    b.ToTable("MarksSchema");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.MarksDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MarkSchemaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(4,2)");

                    b.HasKey("Id");

                    b.HasIndex("MarkSchemaId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.MessageDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MainMessageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SenderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Showed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainMessageId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.ParentDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.RebukeDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LessonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.HasIndex("StudentId");

                    b.ToTable("Rebukes");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.StudentDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.StudentParentDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentsParents");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.SubjectDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.SubjectTeacherDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("SubjectsTeachers");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.TeacherDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClassId")
                        .IsUnique();

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.TimetableDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HourId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("WeekDay")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HourId");

                    b.ToTable("TimetableDTO");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.WorkerDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndWorkDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("GrossSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartWorkDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId")
                        .IsUnique();

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.AbsenceDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.LessonDTO", "Lesson")
                        .WithMany("Absences")
                        .HasForeignKey("LessonId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.StudentDTO", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.SubjectDTO", null)
                        .WithMany("Absences")
                        .HasForeignKey("SubjectDTOId");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.ApplicationUserDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.ParentDTO", "Parent")
                        .WithOne("User")
                        .HasForeignKey("AdvancedSchoolManagment.Models.Data.ApplicationUserDTO", "ParentId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.StudentDTO", "Student")
                        .WithOne("User")
                        .HasForeignKey("AdvancedSchoolManagment.Models.Data.ApplicationUserDTO", "StudentId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.WorkerDTO", "Worker")
                        .WithOne("User")
                        .HasForeignKey("AdvancedSchoolManagment.Models.Data.ApplicationUserDTO", "WorkerId");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.ClassroomDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.SubjectDTO", "Subject")
                        .WithMany("Classrooms")
                        .HasForeignKey("SubjectId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.TeacherDTO", "Teacher")
                        .WithOne("Classroom")
                        .HasForeignKey("AdvancedSchoolManagment.Models.Data.ClassroomDTO", "TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.LessonDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.ClassDTO", "Class")
                        .WithMany("Lessons")
                        .HasForeignKey("ClassId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.ClassroomDTO", "Classroom")
                        .WithMany("Lessons")
                        .HasForeignKey("ClassroomId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.SubjectDTO", "Subject")
                        .WithMany("Lessons")
                        .HasForeignKey("SubjectId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.TeacherDTO", "Teacher")
                        .WithMany("Lessons")
                        .HasForeignKey("TeacherId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.TimetableDTO", "Timetable")
                        .WithMany("Lessons")
                        .HasForeignKey("TimetableId");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.MarksDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.MarkSchemaDTO", "MarkSchema")
                        .WithMany("Marks")
                        .HasForeignKey("MarkSchemaId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.StudentDTO", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.SubjectDTO", "Subject")
                        .WithMany("Marks")
                        .HasForeignKey("SubjectId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.TeacherDTO", "Teacher")
                        .WithMany("Marks")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.MessageDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.MessageDTO", "MainMessage")
                        .WithMany()
                        .HasForeignKey("MainMessageId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.ApplicationUserDTO", "Receiver")
                        .WithMany("Receiver")
                        .HasForeignKey("ReceiverId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.ApplicationUserDTO", "Sender")
                        .WithMany("Sender")
                        .HasForeignKey("SenderId");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.RebukeDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.LessonDTO", "Lesson")
                        .WithMany("Rebukes")
                        .HasForeignKey("LessonId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.StudentDTO", "Student")
                        .WithMany("Rebukes")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.StudentDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.ClassDTO", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.StudentParentDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.ParentDTO", "Parent")
                        .WithMany("Students")
                        .HasForeignKey("ParentId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.StudentDTO", "Student")
                        .WithMany("Parents")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.SubjectTeacherDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.SubjectDTO", "Subject")
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectId");

                    b.HasOne("AdvancedSchoolManagment.Models.Data.TeacherDTO", "Teacher")
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.TeacherDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.ClassDTO", "Class")
                        .WithOne("Teacher")
                        .HasForeignKey("AdvancedSchoolManagment.Models.Data.TeacherDTO", "ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.TimetableDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.LessonHoursDTO", "Hour")
                        .WithMany("Timetable")
                        .HasForeignKey("HourId");
                });

            modelBuilder.Entity("AdvancedSchoolManagment.Models.Data.WorkerDTO", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.TeacherDTO", "Teacher")
                        .WithOne("Worker")
                        .HasForeignKey("AdvancedSchoolManagment.Models.Data.WorkerDTO", "TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.ApplicationUserDTO", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.ApplicationUserDTO", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdvancedSchoolManagment.Models.Data.ApplicationUserDTO", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AdvancedSchoolManagment.Models.Data.ApplicationUserDTO", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
