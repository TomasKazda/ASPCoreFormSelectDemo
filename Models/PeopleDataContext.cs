using ASPCoreFormSelectDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ASPCoreFormSelectDemo.Models
{
    public class PeopleDataContext : DbContext
    {
        public PeopleDataContext(DbContextOptions options) : base(options)  
        {
        }

        public DbSet<CodeBook> CodeBook { get; set; }
        public DbSet<Human> People { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CodeBook>().HasData(new CodeBook { Id = 1, Color = "Red" },
                new CodeBook { Id = 2, Color = "Gray" },
                new CodeBook { Id = 3, Color = "Blue" },
                new CodeBook { Id = 4, Color = "Brown" },
                new CodeBook { Id = 5, Color = "Green" });
        }
    }
}