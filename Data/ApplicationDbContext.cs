using Colonize.Website.Data.Entities;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FreakyFashion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public object Category { get; internal set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<CategoryProduct>().HasKey(pt => new
            {
                pt.ProductId,
                pt.CategoryId
            });
        //    var product = new List<Product>{

        //    new Product(1,"Jeans","skinny Jeans Denim",new Uri("https://via.placeholder.com/480x360.png?text=Jeans", UriKind.Absolute),29),
        //    new Product(2, "Shirt", "Long sleeve shirt", new Uri("https://via.placeholder.com/480x360.png?text=Dress", UriKind.Absolute), 35),
        //    new Product(3, "Coat", "Winter coat", new Uri("https://via.placeholder.com/480x360.png?text=Winter+Coat", UriKind.Absolute), 45)
        //    };

        //    product.ForEach(x => modelBuilder.Entity<Product>().HasData(x));
        //    var jeans = product.Find(x => x.Name == "Jeans");
        //    var shirt = product.Find(x => x.Name == "Shirt");
        //    var jacket = product.Find(x => x.Name == "Jacket");


        //    var category = new List<Category>{

        //    new Category(1,"Dress","Lorem ipsom dolor",new Uri("https://via.placeholder.com/480x360.png?text=Dress", UriKind.Absolute)),
        //    new Category(2, "Pants", "Lorem ipsom dolor", new Uri("https://via.placeholder.com/480x360.png?text=Pants", UriKind.Absolute)),
        //    new Category(3, "Out wear", "Lorem ipsom dolor", new Uri("https://via.placeholder.com/480x360.png?text=Out+Wear", UriKind.Absolute))
        //    };

        //    category.ForEach(x => modelBuilder.Entity<Category>().HasData(x));
        //    var dress = category.Find(x => x.Name == "Dress");
        //    var pants = category.Find(x => x.Name == "Pants");
        //    var outwear = category.Find(x => x.Name == "Out Wear");

        //    var categoryProduct = new List<CategoryProduct>
        //    {
        //        //new CategoryProduct(1,"jeans.Id","dress.Id"),
        //        //new CategoryProduct(2,"shirt.Id","pants.Id"),
        //    };
        //    categoryProduct.ForEach(x => modelBuilder.Entity<CategoryProduct>().HasData(x));


        //    var hasher = new PasswordHasher<IdentityUser>();

        //    var johnDoe = new IdentityUser()
        //    {
        //        Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
        //        UserName = "john.doe@nomail.com",
        //        Email = "john.doe@nomail.com",
        //        NormalizedEmail = "john.doe@nomail.com",
        //        EmailConfirmed = true,
        //        PhoneNumber = "0707-12345",
        //        PasswordHash = hasher.HashPassword(null, "Secret#123"),
        //        SecurityStamp = string.Empty
        //    };
        //    modelBuilder.Entity<IdentityUser>().HasData(johnDoe);
        }
    }
}



       
    