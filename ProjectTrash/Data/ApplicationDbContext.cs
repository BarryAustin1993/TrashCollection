using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectTrash.Models;

namespace ProjectTrash.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountSubscription> AccountSubscriptions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<WeeklyPickUp> WeeklyPickUps { get; set; }
        public DbSet<PickUp> PickUps { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "Customer",
                        NormalizedName = "CUSTOMER"
                    },
                    new IdentityRole
                    {
                        Name = "Employee",
                        NormalizedName = "EMPLOYEE"
                    });
            builder.Entity<WeeklyPickUp>()
               .HasData(
                   new WeeklyPickUp
                   {
                       WeeklyPickUpId = 1,
                       DayOfTheWeek = "Monday"
                   },
                   new WeeklyPickUp
                   {
                       WeeklyPickUpId = 2,
                       DayOfTheWeek = "Tuesday"
                   },
                   new WeeklyPickUp
                   {
                       WeeklyPickUpId = 3,
                       DayOfTheWeek = "Wednesday"
                   },
                   new WeeklyPickUp
                   {
                       WeeklyPickUpId = 4,
                       DayOfTheWeek = "Thursday"
                   },
                   new WeeklyPickUp
                   {
                       WeeklyPickUpId = 5,
                       DayOfTheWeek = "Friday"
                   },
                   new WeeklyPickUp
                   {
                       WeeklyPickUpId = 6,
                       DayOfTheWeek = "Saturday"
                   },
                   new WeeklyPickUp
                   {
                       WeeklyPickUpId = 7,
                       DayOfTheWeek = "Sunday"
                   });
        }
    }
}
