﻿// <auto-generated />
using System;
using BugTrackingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BugTrackingSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201117180700_SeedSubCategoryUsersBugs")]
    partial class SeedSubCategoryUsersBugs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BugTrackingSystem.Models.Bug", b =>
                {
                    b.Property<int>("BugId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSolved")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BugId");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Bugs");

                    b.HasData(
                        new
                        {
                            BugId = 1,
                            Code = "modelBuilder.Entity<User>().HasData(\r\n                            users\r\n                        ); ",
                            Description = "What does this specify. I dont understand why this is needed",
                            IsSolved = false,
                            IssueDate = new DateTime(2020, 11, 17, 23, 36, 59, 375, DateTimeKind.Local).AddTicks(2654),
                            SubCategoryId = 1,
                            Title = "Issue with modelBuilder",
                            UserId = 1
                        },
                        new
                        {
                            BugId = 2,
                            Code = "<html>\r\n                            <head> <title> Hello World</title> </head>\r\n                         </html>",
                            Description = "Why we write this. I dont understand why this is needed",
                            IsSolved = false,
                            IssueDate = new DateTime(2020, 11, 17, 23, 36, 59, 376, DateTimeKind.Local).AddTicks(5434),
                            SubCategoryId = 2,
                            Title = "Not understanding the code",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("BugTrackingSystem.Models.BugComment", b =>
                {
                    b.Property<int>("BugCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BugId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BugCommentId");

                    b.HasIndex("BugId");

                    b.HasIndex("UserId");

                    b.ToTable("BugComments");
                });

            modelBuilder.Entity("BugTrackingSystem.Models.Category", b =>
                {
                    b.Property<int>("CatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CatID = 1,
                            CatName = "Backend"
                        },
                        new
                        {
                            CatID = 2,
                            CatName = "Frontend"
                        });
                });

            modelBuilder.Entity("BugTrackingSystem.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "BackendDeveloper"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "FrontendDeveloper"
                        });
                });

            modelBuilder.Entity("BugTrackingSystem.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SubCatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCatID");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            SubCatID = 1,
                            CategoryId = 1,
                            SubCatName = "C#"
                        },
                        new
                        {
                            SubCatID = 2,
                            CategoryId = 2,
                            SubCatName = "HTML"
                        });
                });

            modelBuilder.Entity("BugTrackingSystem.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            DepartmentId = 1,
                            Email = "user1@gmail.com",
                            IsAdmin = false,
                            Password = "user1",
                            UserName = "user1"
                        },
                        new
                        {
                            UserID = 2,
                            DepartmentId = 1,
                            Email = "user2@gmail.com",
                            IsAdmin = false,
                            Password = "user2",
                            UserName = "user2"
                        },
                        new
                        {
                            UserID = 3,
                            DepartmentId = 2,
                            Email = "user3@gmail.com",
                            IsAdmin = false,
                            Password = "user3",
                            UserName = "user3"
                        });
                });

            modelBuilder.Entity("BugTrackingSystem.Models.Bug", b =>
                {
                    b.HasOne("BugTrackingSystem.Models.SubCategory", "SubCat")
                        .WithMany("CategoryBugs")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BugTrackingSystem.Models.User", "Owner")
                        .WithMany("UserBugs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("SubCat");
                });

            modelBuilder.Entity("BugTrackingSystem.Models.BugComment", b =>
                {
                    b.HasOne("BugTrackingSystem.Models.Bug", "ParentBug")
                        .WithMany("BugComments")
                        .HasForeignKey("BugId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BugTrackingSystem.Models.User", "Employee")
                        .WithMany("UserComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("ParentBug");
                });

            modelBuilder.Entity("BugTrackingSystem.Models.SubCategory", b =>
                {
                    b.HasOne("BugTrackingSystem.Models.Category", "Cat")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("BugTrackingSystem.Models.User", b =>
                {
                    b.HasOne("BugTrackingSystem.Models.Department", "Dept")
                        .WithMany("DepartmentUsers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Dept");
                });

            modelBuilder.Entity("BugTrackingSystem.Models.Bug", b =>
                {
                    b.Navigation("BugComments");
                });

            modelBuilder.Entity("BugTrackingSystem.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("BugTrackingSystem.Models.Department", b =>
                {
                    b.Navigation("DepartmentUsers");
                });

            modelBuilder.Entity("BugTrackingSystem.Models.SubCategory", b =>
                {
                    b.Navigation("CategoryBugs");
                });

            modelBuilder.Entity("BugTrackingSystem.Models.User", b =>
                {
                    b.Navigation("UserBugs");

                    b.Navigation("UserComments");
                });
#pragma warning restore 612, 618
        }
    }
}