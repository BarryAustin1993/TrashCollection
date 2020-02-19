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
                        NormalizedName = "Customer"
                    },
                    new IdentityRole
                    {
                        Name = "Employee",
                        NormalizedName = "Employee"
                    });

            builder.Entity<WeeklyPickUp>()
                .HasData(
                    new WeeklyPickUp
                    {
                        ID = 0,
                        dayOfTheWeek = "Monday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 1,
                        dayOfTheWeek = "Tuesday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 2,
                        dayOfTheWeek = "Wednesday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 3,
                        dayOfTheWeek = "Thursday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 4,
                        dayOfTheWeek = "Friday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 5,
                        dayOfTheWeek = "Saturday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 6,
                        dayOfTheWeek = "Sunday"
                    });

            builder.Entity<Customer>()
               .HasData(
                   new Customer
                   {
                       Id = 0,
                       accountID = 0,
                       firstName = "Austin",
                       lastName = "Barry"
                   },
                   new Customer
                   {
                       Id = 1,
                       accountID = 1,
                       firstName = "Andrew",
                       lastName = "Baird"
                   },
                   new Customer
                   {
                       Id = 2,
                       accountID = 2,
                       firstName = "David",
                       lastName = "Steinhafel"
                   },
                   new Customer
                   {
                       Id = 3,
                       accountID = 3,
                       firstName = "Matthew",
                       lastName = "Acker"
                   },
                   new Customer
                   {
                       Id = 4,
                       accountID = 4,
                       firstName = "Ryan",
                       lastName = "Holman"
                   },
                   new Customer
                   {
                       Id = 5,
                       accountID = 5,
                       firstName = "Dejan",
                       lastName = "Tirnanic"
                   },
                   new Customer
                   {
                       Id = 6,
                       accountID = 6,
                       firstName = "Gustavo",
                       lastName = "Sanchez"
                   });

            builder.Entity<Account>()
               .HasData(
                   new Account
                   {
                       ID = 0,
                       balance = 25,
                       AddressID = 0,
                       weeklyPickUp = 3

                   },
                   new Account
                   {
                       ID = 1,
                       balance = 50,
                       AddressID = 1,
                       weeklyPickUp = 4
                   },
                   new Account
                   {
                       ID = 2,
                       balance = 25,
                       AddressID = 2,
                       weeklyPickUp = 5
                   },
                   new Account
                   {
                       ID = 3,
                       balance = 50,
                       AddressID = 3,
                       weeklyPickUp = 6
                   },
                   new Account
                   {
                       ID = 4,
                       balance = 0,
                       AddressID = 4,
                       weeklyPickUp = 0
                   },
                   new Account
                   {
                       ID = 5,
                       balance = 33,
                       AddressID = 5,
                       weeklyPickUp = 1
                   },
                   new Account
                   {
                       ID = 6,
                       balance = 150,
                       AddressID = 6,
                       weeklyPickUp = 2
                   }) ;

            _ = builder.Entity<AccountSubscription>()
               .HasData(
                   new AccountSubscription
                   {
                       Id = 0,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2008, 3, 1)
                   },
                   new AccountSubscription
                   {
                       Id = 1,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2008, 3, 1),
                       accountEndDate = ,
                       suspensionStartDate = ,
                       suspensionEndDate =
                   },
                   new AccountSubscription
                   {
                       Id = 2,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2008, 3, 1),
                       accountEndDate = ,
                       suspensionStartDate = ,
                       suspensionEndDate =
                   },
                   new AccountSubscription
                   {
                       Id = 3,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2008, 3, 1),
                       accountEndDate = ,
                       suspensionStartDate = ,
                       suspensionEndDate =
                   },
                   new AccountSubscription
                   {
                       Id = 4,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2008, 3, 1),
                       accountEndDate = ,
                       suspensionStartDate = ,
                       suspensionEndDate =
                   },
                   new AccountSubscription
                   {
                       Id = 5,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2008, 3, 1),
                       accountEndDate = ,
                       suspensionStartDate = ,
                       suspensionEndDate =
                   },
                   new AccountSubscription
                   {
                       Id = 6,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2008, 3, 1),
                       accountEndDate = ,
                       suspensionStartDate = ,
                       suspensionEndDate =
                   }) ;
        }


    }
}
