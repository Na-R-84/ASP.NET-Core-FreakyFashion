using Colonize.Website.Data.Entities;
using System;
using System.Collections.Generic;

namespace FreakyFashion.Data.Entities
{
    public class Category
    {
        public Category(int id)
        {
            Id = id;

        }
        public Category(string name, string description, Uri imageUrl, int id)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            Id = id;
        }
        public Category(string name, Uri imageUrl)
        {
            Name = name;
            ImageUrl = imageUrl;

        }

        public Category(int id, string name, string description, Uri imageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }

        public Category(string name,  Uri imageUrl, string urlSlug)
        {
            Name = name;
            ImageUrl = imageUrl;
            UrlSlug = urlSlug;
        }
        public List<CategoryProduct> CategoryProducts { get; set; }
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri ImageUrl { get; set; }
        public int Quantity { get; set;}
        public string UrlSlug { get; set; }

    }

}
