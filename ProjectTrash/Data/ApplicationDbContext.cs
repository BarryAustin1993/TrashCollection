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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    });

            builder.Entity<WeeklyPickUp>()
                .HasData(
                    new WeeklyPickUp
                    {
                        ID = 0,
                        dayOfTheWeek = "Monday"
                    });
            builder.Entity<WeeklyPickUp>()
                .HasData(
                    new WeeklyPickUp
                    {
                        ID = 1,
                        dayOfTheWeek = "Tuesday"
                    });
            builder.Entity<WeeklyPickUp>()
                .HasData(
                    new WeeklyPickUp
                    {
                        ID = 2,
                        dayOfTheWeek = "Wednesday"
                    });
            builder.Entity<WeeklyPickUp>()
                .HasData(
                    new WeeklyPickUp
                    {
                        ID = 3,
                        dayOfTheWeek = "Thursday"
                    });
            builder.Entity<WeeklyPickUp>()
                .HasData(
                    new WeeklyPickUp
                    {
                        ID = 4,
                        dayOfTheWeek = "Friday"
                    });
            builder.Entity<WeeklyPickUp>()
                .HasData(
                    new WeeklyPickUp
                    {
                        ID = 5,
                        dayOfTheWeek = "Saturday"
                    });
            builder.Entity<WeeklyPickUp>()
                .HasData(
                    new WeeklyPickUp
                    {
                        ID = 6,
                        dayOfTheWeek = "Sunday"
                    });
        }


    }
}
