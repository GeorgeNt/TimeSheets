using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeSheets.Models;
//using TimeSheets.Models;

namespace TimeSheets.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }
        //public DbSet<Role> Roles { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);// Required for setting Identity
            // Below are required, to setup the ProductCategory weak entity
            // which connects one or more products to one or more categories
            modelBuilder.Entity<TimeSheetProject>()
                .HasKey(t => new { t.TimeSheetId, t.ProjectId });
            modelBuilder.Entity<TimeSheetProject>()
                .HasOne(pt => pt.Project)
                .WithMany(p => p.TimeSheets)
                .HasForeignKey()


            modelBuilder.Entity<TimeSheetUser>().(t => new { t.TimeSheetId, t.UserId });

            HasOne(pt => pt.Product).WithMany(p => p.Categories).HasForeignKey(pt => pt.ProductId);.OnDelete(DeleteBehavior.Cascade);
            // Setup CASCADE ON DELETE
            modelBuilder.Entity<ProductCategory>().HasOne(pt => pt.Category).WithMany(t => t.Products).HasForeignKey(pt => pt.CategoryId);}

        }
    }
}
