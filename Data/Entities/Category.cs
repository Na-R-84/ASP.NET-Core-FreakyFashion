using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion.Data.Entities
{
    public class Category
    {
        public List<Categoryproduct> categoryProducts { get; set; }
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri ImageUrl { get; set; }

    }
}
