using System;
using System.Collections.Generic;
using System.Text;
using FreakyFashion.Data.Caregories;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Product { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            base.OnModelCreating(modelBuilder);
        }
    }
}
