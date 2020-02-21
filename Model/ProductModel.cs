using System;
using System.Collections.Generic;
using System.Linq;

namespace FreakyFashion.Data.Entities
{
    public class ProductModel
    {
         private List<Product> Products;
        
        public List<Product> findAll()
        {
            return Products;
        }

        public Product find(int id)
        {
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }

    }
}
