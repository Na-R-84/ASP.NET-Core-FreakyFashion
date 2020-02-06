using Colonize.Website.Data.Entities;
using System;
using System.Collections.Generic;

namespace FreakyFashion.Data.Entities
{
    public class Product
    {
        public Product(int id, string name, string description, Uri imageUrl, decimal price)
            : this(name, description, imageUrl, price)
        {
            Id = id;
        }

        public Product(string name, string description, Uri imageUrl, decimal price)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            Price = price;
        }

        public List<CategoryProduct> categoryProducts { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int ArticleNumber { get; set; }
    }

}

