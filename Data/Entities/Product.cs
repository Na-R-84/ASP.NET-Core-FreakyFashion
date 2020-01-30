using System;

namespace FreakyFashion.Data.Caregories
{
    public class Product
    {
        public Product(int id, string name, string description, Uri imageUrl, decimal price )
            :this(name, description,imageUrl,price)
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

        public int Id { get;  set; }
        public string Name { get;  set; }
        public string Description { get;  set; }
        public Uri ImageUrl { get;  set; }
        public decimal Price { get;  set; }

    }

}

