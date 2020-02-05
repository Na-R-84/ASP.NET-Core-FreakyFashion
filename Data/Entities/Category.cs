using Colonize.Website.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion.Data.Entities
{
    public class Category
    {
        public Category(int v, string name, string description, Uri imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
        public Category()
        {

        }
        public List<CategoryProduct> CategoryProducts { get; set; }
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri ImageUrl { get; set; }

    }
  
}
