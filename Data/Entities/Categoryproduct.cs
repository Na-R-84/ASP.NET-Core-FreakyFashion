
using FreakyFashion.Data.Entities;
using System;

namespace Colonize.Website.Data.Entities
{
    public class CategoryProduct
    {
        public CategoryProduct( int productId, int categoryId)
        {
  
            ProductId = productId;
            CategoryId = categoryId;
        }

        public CategoryProduct(int productId, string v, int categoryId)
        {
            CategoryId = categoryId;
            ProductId = productId;
          
        }
        public CategoryProduct(int v)
        {

        }
     
        public Product Product { get; protected set; }
        public Category Category { get; protected set; }
        public int ProductId { get; protected set; }
        public int CategoryId { get; }
    }
}