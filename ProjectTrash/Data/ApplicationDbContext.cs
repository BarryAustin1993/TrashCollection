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
                        Id = "13579 - customer",
                        Name = "Customer",
                        NormalizedName = "CUSTOMER"
                    },
                    new IdentityRole
                    {
                        Id = "02468 - employee",
                        Name = "Employee",
                        NormalizedName = "EMPLOYEE"
                    });

            builder.Entity<IdentityUser>()
                .HasData(
                    new IdentityUser
                    {
                        Id = "1-Ajpbarry",
                        UserName = "Ajpbarry",
                        NormalizedUserName = "AJPBARRY",
                        Email = "Ajpbarry@gmail.com",
                        NormalizedEmail = "AJPBARRY@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "4147370256",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser
                    {
                        Id = "2-ABaird",
                        UserName = "ABaird",
                        NormalizedUserName = "ABAIRD",
                        Email = "ABaird@gmail.com",
                        NormalizedEmail = "ABAIRD@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "4141234567",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser
                    {
                        Id = "3-DSteinhafel",
                        UserName = "DSteinhafel",
                        NormalizedUserName = "DSTEINHAFEL",
                        Email = "DSteinhafel@gmail.com",
                        NormalizedEmail = "DSTEINHAFEL@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "4149876543",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser
                    {
                        Id = "4-MAcker",
                        UserName = "MAcker",
                        NormalizedUserName = "MACKER",
                        Email = "MAcker@gmail.com",
                        NormalizedEmail = "MACKER@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "4142345678",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser
                    {
                        Id = "5-RHolman",
                        UserName = "RHolman",
                        NormalizedUserName = "RHOLMAN",
                        Email = "RHolman@gmail.com",
                        NormalizedEmail = "RHOLMAN@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "4144567890",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser
                    {
                        Id = "6-DTirnanic",
                        UserName = "DTirnanic",
                        NormalizedUserName = "DTIRNANIC",
                        Email = "DTirnanic@gmail.com",
                        NormalizedEmail = "DTIRNANIC@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "4140987654",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser
                    {
                        Id = "7-GSanchez",
                        UserName = "GSanchez",
                        NormalizedUserName = "GSANCHEZ",
                        Email = "GSanchez@gmail.com",
                        NormalizedEmail = "GSANCHEZ@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "4146853690",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser
                    {
                        Id = "8-JBrockman",
                        UserName = "JBrockman",
                        NormalizedUserName = "JBROCKMAN",
                        Email = "JBrockman@gmail.com",
                        NormalizedEmail = "JBROCKMAN@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "4148760987",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser
                    {
                        Id = "9-NSeibel",
                        UserName = "NSeibel",
                        NormalizedUserName = "NSEIBEL",
                        Email = "NSeibel@gmail.com",
                        NormalizedEmail = "NSEIBEL@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "3138760987",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser
                    {
                        Id = "10-DLagrange",
                        UserName = "DLagrange",
                        NormalizedUserName = "DLAGRANGE",
                        Email = "DLagrange@gmail.com",
                        NormalizedEmail = "DLAGRANGE@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "3131234567",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser
                    {
                        Id = "11-CKIng",
                        UserName = "CKIng",
                        NormalizedUserName = "CKING",
                        Email = "CKIng@gmail.com",
                        NormalizedEmail = "CKING@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "3130865432",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser
                    {
                        Id = "12-MTerril",
                        UserName = "MTerril",
                        NormalizedUserName = "MTERRIL",
                        Email = "MTerril@gmail.com",
                        NormalizedEmail = "MTERRIL@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = "password",
                        PhoneNumber = "3136853963",
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = true,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    });

            builder.Entity<WeeklyPickUp>()
                .HasData(
                    new WeeklyPickUp
                    {
                        ID = 1,
                        dayOfTheWeek = "Monday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 2,
                        dayOfTheWeek = "Tuesday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 3,
                        dayOfTheWeek = "Wednesday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 4,
                        dayOfTheWeek = "Thursday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 5,
                        dayOfTheWeek = "Friday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 6,
                        dayOfTheWeek = "Saturday"
                    },
                    new WeeklyPickUp
                    {
                        ID = 7,
                        dayOfTheWeek = "Sunday"
                    });

            builder.Entity<Customer>()
               .HasData(
                   new Customer
                   {
                       Id = 1,
                       UserId = "1-Ajpbary",
                       accountID = 1,
                       firstName = "Austin",
                       lastName = "Barry"
                       
                   },
                   new Customer
                   {
                       Id = 2,
                       UserId = "2-ABaird",
                       accountID = 2,
                       firstName = "Andrew",
                       lastName = "Baird"
                   },
                   new Customer
                   {
                       Id = 3,
                       UserId = "3-DSteinhafel",
                       accountID = 3,
                       firstName = "David",
                       lastName = "Steinhafel"
                   },
                   new Customer
                   {
                       Id = 4,
                       UserId = "4-MAcker",
                       accountID = 4,
                       firstName = "Matthew",
                       lastName = "Acker"
                   },
                   new Customer
                   {
                       Id = 5,
                       UserId = "5-RHolman",
                       accountID = 5,
                       firstName = "Ryan",
                       lastName = "Holman"
                   },
                   new Customer
                   {
                       Id = 6,
                       UserId = "6-DTirnanic",
                       accountID = 6,
                       firstName = "Dejan",
                       lastName = "Tirnanic"
                   },
                   new Customer
                   {
                       Id = 7,
                       UserId = "7-GSanchez",
                       accountID = 7,
                       firstName = "Gustavo",
                       lastName = "Sanchez"
                   },
                   new Customer
                   {
                       Id = 8,
                       UserId = "8-JBrockmann",
                       accountID = 8,
                       firstName = "Jacob",
                       lastName = "Brockmann"
                   });

            builder.Entity<Account>()
               .HasData(
                   new Account
                   {
                       ID = 1,
                       balance = 25,
                       AddressID = 1,
                       AccountSubscriptionID = 1,
                       WeeklyPickUpID = 3

                   },
                   new Account
                   {
                       ID = 2,
                       balance = 50,
                       AddressID = 2,
                       AccountSubscriptionID = 2,
                       WeeklyPickUpID = 4
                   },
                   new Account
                   {
                       ID = 3,
                       balance = 25,
                       AddressID = 3,
                       AccountSubscriptionID = 3,
                       WeeklyPickUpID = 5
                   },
                   new Account
                   {
                       ID = 4,
                       balance = 50,
                       AddressID = 4,
                       AccountSubscriptionID = 4,
                       WeeklyPickUpID = 6
                   },
                   new Account
                   {
                       ID = 5,
                       balance = 0,
                       AddressID = 5,
                       AccountSubscriptionID = 5,
                       WeeklyPickUpID = 1
                   },
                   new Account
                   {
                       ID = 6,
                       balance = 33,
                       AddressID = 6,
                       AccountSubscriptionID = 6,
                       WeeklyPickUpID = 1
                   },
                   new Account
                   {
                       ID = 7,
                       balance = 150,
                       AddressID = 7,
                       AccountSubscriptionID = 7,
                       WeeklyPickUpID = 2
                   },
                   new Account
                   {
                       ID = 8,
                       balance = 20,
                       AddressID = 2,
                       AccountSubscriptionID = 8,
                       WeeklyPickUpID = 1
                   }) ;

            builder.Entity<AccountSubscription>()
               .HasData(
                   new AccountSubscription
                   {
                       Id = 1,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2020, 01, 01)
                   },
                   new AccountSubscription
                   {
                       Id = 2,
                       isActive = false,
                       isSuspended = false,
                       accountStartDate = new DateTime(2008, 04, 04),
                       accountEndDate = new DateTime(2016, 08, 08),
                   },
                   new AccountSubscription
                   {
                       Id = 3,
                       isActive = true,
                       isSuspended = true,
                       accountStartDate = new DateTime(2016, 03, 03),
                       suspensionStartDate = new DateTime(2020, 01, 20),
                       suspensionEndDate = new DateTime(2020, 05, 04)
                   },
                   new AccountSubscription
                   {
                       Id = 4,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2018, 06, 04),
                       suspensionStartDate = new DateTime(2019, 08, 04),
                       suspensionEndDate = new DateTime(2020, 01, 01)
                   },
                   new AccountSubscription
                   {
                       Id = 5,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2020, 01, 01)
                   },
                   new AccountSubscription
                   {
                       Id = 6,
                       isActive = false,
                       isSuspended = false,
                       accountStartDate = new DateTime(2008, 04, 04),
                       accountEndDate = new DateTime(2016, 08, 08),
                   },
                   new AccountSubscription
                   {
                       Id = 7,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2018, 06, 04),
                       suspensionStartDate = new DateTime(2019, 08, 04),
                       suspensionEndDate = new DateTime(2020, 01, 01)
                   },
                   new AccountSubscription
                   {
                       Id = 8,
                       isActive = true,
                       isSuspended = false,
                       accountStartDate = new DateTime(2018, 06, 04),
                   });

            builder.Entity<Address>()
               .HasData(
                   new Address
                   {
                       ID = 1,
                       address = "14538 Talbot drive",
                       city = "Warren",
                       state = "Mi",
                       zipCode = 48088
                   },
                   new Address
                   {
                       ID = 2,
                       address = "6228 238th Avenue",
                       city = "Salem",
                       state = "Wi",
                       zipCode = 53168
                   },
                   new Address
                   {
                       ID = 3,
                       address = "6118 North Downer Avenue",
                       city = "Milwaukee",
                       state = "Wi",
                       zipCode = 53211
                   },
                   new Address
                   {
                       ID = 4,
                       address = "2438 North Bremen Street",
                       city = "Milwaukee",
                       state = "Wisconsin",
                       zipCode = 53212
                   },
                   new Address
                   {
                       ID = 5,
                       address = "3304 North Pierce Street",
                       city = "Milwaukee",
                       state = "Wisconsin",
                       zipCode = 53212
                   },
                   new Address
                   {
                       ID = 6,
                       address = "3232 North Summit Avenue",
                       city = "Milwaukee",
                       state = "Wisconsin",
                       zipCode = 53211
                   },
                   new Address
                   {
                       ID = 7,
                       address = "3333 North Hacket Avenue",
                       city = "Milwaukee",
                       state = "Wisconsin",
                       zipCode = 53211

                   });

            builder.Entity<Employee>()
               .HasData(    
                   new Employee
                   {
                       ID = 1,
                       UserId = "9-NSeibel",
                       firstName = "Nevin",
                       lastName = "Seibel",
                       zipcode = 53211
                   },
                   new Employee
                   {
                       ID = 2,
                       UserId = "10-DLangrange",
                       firstName = "David",
                       lastName = "Lagrange",
                       zipcode = 53212
                   },
                   new Employee
                   {
                       ID = 3,
                       UserId = "11-CKing",
                       firstName = "Charles",
                       lastName = "King",
                       zipcode = 53168
                   },
                   new Employee
                   {
                       ID = 4,
                       UserId = "12-MTerril",
                       firstName = "Mike",
                       lastName = "Terril",
                       zipcode = 48088
                   });

            builder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "13579 - customer",
                        UserId = "1-Ajpbarry",
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "13579 - customer",
                        UserId = "2-ABaird",
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "13579 - customer",
                        UserId = "3-DSteinhafel",
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "13579 - customer",
                        UserId = "4-MAcker",
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "13579 - customer",
                        UserId = "5-RHolman",
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "13579 - customer",
                        UserId = "6-DTirnanic",
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "13579 - customer",
                        UserId = "7-GSanchez",
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "13579 - customer",
                        UserId = "8-JBrockman",
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "02468 - employee",
                        UserId = "9-NSeibel",
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "02468 - employee",
                        UserId = "10-DLangrange",
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "02468 - employee",
                        UserId = "11-CKing",
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "02468 - employee",
                        UserId = "12-MTerril",
                    });
        
        }
    }
}
