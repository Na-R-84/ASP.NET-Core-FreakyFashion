using FreakyFashion.Data.Caregories;
using FreakyFashion.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion.Data
{
    public class Categoryproduct
    {
        public Category   Category { get; set; }
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public  int ProductId { get; set; }
    }
}
