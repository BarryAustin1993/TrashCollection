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
                   },
                   new Customer
                   {
                       Id = 7,
                       accountID = 7,
                       firstName = "Jacob",
                       lastName = "Brockmann"
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
                   },
                   new Account
                   {
                       ID = 7,
                       balance = 20,
                       AddressID = 1,
                       weeklyPickUp = 1
                   }) ;

            builder.Entity<AccountSubscription>()
               .HasData(
                   new AccountSubscription
                   {
                       Id = 0,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2020, 01, 01)
                   },
                   new AccountSubscription
                   {
                       Id = 1,
                       isActive = false,
                       isSuspended = false,
                       accountStartDate = new DateTime(2008, 04, 04),
                       accountEndDate = new DateTime(2016, 08, 08),
                   },
                   new AccountSubscription
                   {
                       Id = 2,
                       isActive = true,
                       isSuspended = true,
                       accountStartDate = new DateTime(2016, 03, 03),
                       suspensionStartDate = new DateTime(2020, 01, 20),
                       suspensionEndDate = new DateTime(2020, 05, 04)
                   },
                   new AccountSubscription
                   {
                       Id = 3,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2018, 06, 04),
                       suspensionStartDate = new DateTime(2019, 08, 04),
                       suspensionEndDate = new DateTime(2020, 01, 01)
                   },
                   new AccountSubscription
                   {
                       Id = 4,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2020, 01, 01)
                   },
                   new AccountSubscription
                   {
                       Id = 5,
                       isActive = false,
                       isSuspended = false,
                       accountStartDate = new DateTime(2008, 04, 04),
                       accountEndDate = new DateTime(2016, 08, 08),
                   },
                   new AccountSubscription
                   {
                       Id = 6,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2018, 06, 04),
                       suspensionStartDate = new DateTime(2019, 08, 04),
                       suspensionEndDate = new DateTime(2020, 01, 01)
                   },
                   new AccountSubscription
                   {
                       Id = 7,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2018, 06, 04),
                   });

            builder.Entity<Address>()
               .HasData(
                   new Address
                   {
                       ID = 0,
                       address = "14538 Talbot drive",
                       city = "Warren",
                       state = "Mi",
                       zipCode = 48088
                   },
                   new Address
                   {
                       ID = 1,
                       address = "6228 238th Avenue",
                       city = "Salem",
                       state = "Wi",
                       zipCode = 53168
                   },
                   new Address
                   {
                       ID = 2,
                       address = "6118 North Downer Avenue",
                       city = "Milwaukee",
                       state = "Wi",
                       zipCode = 53211
                   },
                   new Address
                   {
                       ID = 3,
                       address = "2438 North Bremen Street",
                       city = "Milwaukee",
                       state = "Wisconsin",
                       zipCode = 53212
                   },
                   new Address
                   {
                       ID = 4,
                       address = "3304 North Pierce Street",
                       city = "Milwaukee",
                       state = "Wisconsin",
                       zipCode = 53212
                   },
                   new Address
                   {
                       ID = 5,
                       address = "3232 North Summit Avenue",
                       city = "Milwaukee",
                       state = "Wisconsin",
                       zipCode = 53211
                   },
                   new Address
                   {
                       ID = 6,
                       address = "3333 North Hacket Avenue",
                       city = "Milwaukee",
                       state = "Wisconsin",
                       zipCode = 53211

                   });

            builder.Entity<Employee>()
               .HasData(    
                   new Employee
                   {
                       ID = 0,
                       firstName = "Nevin",
                       lastName = "Seibel",
                       zipcode = 53211
                   },
                   new Employee
                   {
                       ID = 1,
                       firstName = "David",
                       lastName = "Lagrange",
                       zipcode = 53212
                   },
                   new Employee
                   {
                       ID = 2,
                       firstName = "Charles",
                       lastName = "King",
                       zipcode = 53168
                   },
                   new Employee
                   {
                       ID = 3,
                       firstName = "Mike",
                       lastName = "Terril",
                       zipcode = 48088
                   });
        }
    }
}
