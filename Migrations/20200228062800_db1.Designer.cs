﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UdemyWebApp.Models;

namespace UdemyWebApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200228062800_db1")]
    partial class db1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UdemyWebApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "WebDevlopment",
                            CourseId = 0
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Bussiness",
                            CourseId = 0
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Game Design",
                            CourseId = 0
                        });
                });

            modelBuilder.Entity("UdemyWebApp.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CourseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CourseOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CourseId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CategoryId = 1,
                            CourseDescription = "A Complete HTML5 Programming Course for Beginners",
                            CourseName = "Learn HTML5 Programming From Scratch",
                            CourseOfTheWeek = false,
                            ImageThumbnailUrl = "https://www.redbridgenet.com/wp-content/uploads/html5.png",
                            ImageUrl = "https://www.redbridgenet.com/wp-content/uploads/html5.png",
                            Price = 15.95m
                        },
                        new
                        {
                            CourseId = 2,
                            CategoryId = 1,
                            CourseDescription = "Learn CSS for the first time or brush up your CSS skills and dive in even deeper. EVERY web developer has to know CSS. CSS - short for Cascading Style Sheets - is a programming language you use to turn your raw HTML pages into real beautiful websites.",
                            CourseName = "CSS - The Complete Guide 2020 (incl. Flexbox, Grid & Sass)",
                            CourseOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Price = 19.95m
                        },
                        new
                        {
                            CourseId = 3,
                            CategoryId = 1,
                            CourseDescription = "Create awesome JavaScript driven web apps with modern JavaScript from the very beginning right through to ninja-level. In this course I'll be teaching you my absolute favourite language (JavaScript!) from the very beginning, right through to creating fully-fledged, dynamic & interactive web experiences.",
                            CourseName = "Modern JavaScript (from Novice to Ninja)",
                            CourseOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Price = 18.95m
                        },
                        new
                        {
                            CourseId = 4,
                            CategoryId = 2,
                            CourseDescription = "You'll learn how to read and write complex queries to a database using one of the most in demand skills - PostgreSQL. These skills are also applicable to any other major SQL database, such as MySQL, Microsoft SQL Server, Amazon Redshift, Oracle, and much more.",
                            CourseName = "The Complete SQL Bootcamp",
                            CourseOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Price = 18.95m
                        },
                        new
                        {
                            CourseId = 5,
                            CategoryId = 2,
                            CourseDescription = "Learn To Trade The Stock Market by A Trading Firm CEO. Inc: Technical Analysis, Candlesticks, Stocks, Day Trading +++. This course not only includes the material that is required to be successful in Trading but also the way that we interpret the different types of information in real time to make the best Trading decisions possible.",
                            CourseName = "The Complete Foundation Stock Trading Course",
                            CourseOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Price = 18.95m
                        },
                        new
                        {
                            CourseId = 6,
                            CategoryId = 2,
                            CourseDescription = "In this course you will learn why Power BI offers you a comprehensive set of Business Intelligence tools for your data analysis goals and how to use these tools to fulfill all of the above tasks - and more. Imagine to quickly structure your data, to easily add calculations to it and to create and publish nice-looking charts in just a few minutes.",
                            CourseName = "Microsoft Power BI - A Complete Introduction",
                            CourseOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Price = 18.95m
                        },
                        new
                        {
                            CourseId = 7,
                            CategoryId = 3,
                            CourseDescription = "In this course I will be taking you through the process of creating AAA quality environments inside of Unity.As game graphics are becoming more impressive,it is necessary as a game designer to update your skills and techniques in order to compete with the ever growing game design industry.You don't need any previous experience in Unity as I will be explaining how to do everything in detail.",
                            CourseName = "Unity Environment Design",
                            CourseOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Price = 18.95m
                        },
                        new
                        {
                            CourseId = 8,
                            CategoryId = 3,
                            CourseDescription = "The focus of this course is to show you how to make realistic models, to a real-world scale. Enroll in this Blender 2.8 course and experience over 20 hours of content, full of learning opportunities to take your 3D modeling, animation and simulations skills to the next level. By completing this course, you will walk away with a comprehensive view of how to model from the ground up, with a super-fast industry-standard workflow.  All this exclusively in Blender 2.8.",
                            CourseName = "Blender 2.8 Beginners Guide To 3D Modeling A Sci-fi Scene",
                            CourseOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Price = 18.95m
                        },
                        new
                        {
                            CourseId = 9,
                            CategoryId = 3,
                            CourseDescription = "Begin your game development career with the most up-to-date game dev course on Udemy - Unreal Engine 4: The Complete Beginner's Course. Every lecture in this course is compatible with version 4.24 of the Engine.",
                            CourseName = "Unreal Engine 4: The Complete Beginner's Course",
                            CourseOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Price = 18.95m
                        });
                });

            modelBuilder.Entity("UdemyWebApp.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("UdemyWebApp.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PieId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CourseId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("UdemyWebApp.Models.UserInfo", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("UdemyWebApp.Models.Course", b =>
                {
                    b.HasOne("UdemyWebApp.Models.Category", "Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UdemyWebApp.Models.OrderDetail", b =>
                {
                    b.HasOne("UdemyWebApp.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("UdemyWebApp.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
