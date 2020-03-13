using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UdemyWebApp.Models;

namespace UdemyWebApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(" Server = (localdb)\\mssqllocaldb; Database =Data1; Trusted_Connection = True; MultipleActiveResultSets = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 1, CategoryName = "WebDevlopment"});
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 2, CategoryName = "Bussiness"});
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 3, CategoryName = "Game Design"});

            //seed pies

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 1,
                CourseName = "Learn HTML5 Programming From Scratch",
                Price = 15.95M,
                CourseDescription = "A Complete HTML5 Programming Course for Beginners",
                CategoryId = 1,
                ImageUrl = "https://www.redbridgenet.com/wp-content/uploads/html5.png",
                ImageThumbnailUrl = "https://www.redbridgenet.com/wp-content/uploads/html5.png",
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 2,
                CourseName = "CSS - The Complete Guide 2020 (incl. Flexbox, Grid & Sass)",
                Price = 19.95M,
                CourseDescription = "Learn CSS for the first time or brush up your CSS skills and dive in even deeper. EVERY web developer has to know CSS. CSS - short for Cascading Style Sheets - is a programming language you use to turn your raw HTML pages into real beautiful websites.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 3,
                CourseName = "Modern JavaScript (from Novice to Ninja)",
                Price = 18.95M,
                CourseDescription = "Create awesome JavaScript driven web apps with modern JavaScript from the very beginning right through to ninja-level. In this course I'll be teaching you my absolute favourite language (JavaScript!) from the very beginning, right through to creating fully-fledged, dynamic & interactive web experiences.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 4,
                CourseName = "The Complete SQL Bootcamp",
                Price = 18.95M,
                CourseDescription = "You'll learn how to read and write complex queries to a database using one of the most in demand skills - PostgreSQL. These skills are also applicable to any other major SQL database, such as MySQL, Microsoft SQL Server, Amazon Redshift, Oracle, and much more.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 5,
                CourseName = "The Complete Foundation Stock Trading Course",
                Price = 18.95M,
                CourseDescription = "Learn To Trade The Stock Market by A Trading Firm CEO. Inc: Technical Analysis, Candlesticks, Stocks, Day Trading +++. This course not only includes the material that is required to be successful in Trading but also the way that we interpret the different types of information in real time to make the best Trading decisions possible.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 6,
                CourseName = "Microsoft Power BI - A Complete Introduction",
                Price = 18.95M,
                CourseDescription = "In this course you will learn why Power BI offers you a comprehensive set of Business Intelligence tools for your data analysis goals and how to use these tools to fulfill all of the above tasks - and more. Imagine to quickly structure your data, to easily add calculations to it and to create and publish nice-looking charts in just a few minutes.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 7,
                CourseName = "Unity Environment Design",
                Price = 18.95M,
                CourseDescription = "In this course I will be taking you through the process of creating AAA quality environments inside of Unity.As game graphics are becoming more impressive,it is necessary as a game designer to update your skills and techniques in order to compete with the ever growing game design industry.You don't need any previous experience in Unity as I will be explaining how to do everything in detail.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 8,
                CourseName = "Blender 2.8 Beginners Guide To 3D Modeling A Sci-fi Scene",
                Price = 18.95M,
                CourseDescription = "The focus of this course is to show you how to make realistic models, to a real-world scale. Enroll in this Blender 2.8 course and experience over 20 hours of content, full of learning opportunities to take your 3D modeling, animation and simulations skills to the next level. By completing this course, you will walk away with a comprehensive view of how to model from the ground up, with a super-fast industry-standard workflow.  All this exclusively in Blender 2.8.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 9,
                CourseName = "Unreal Engine 4: The Complete Beginner's Course",
                Price = 18.95M,
                CourseDescription = "Begin your game development career with the most up-to-date game dev course on Udemy - Unreal Engine 4: The Complete Beginner's Course. Every lecture in this course is compatible with version 4.24 of the Engine.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            });

        }

        
    }
}
