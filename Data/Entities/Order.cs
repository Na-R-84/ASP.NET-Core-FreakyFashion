using System;

namespace FreakyFashion.Data.Entities
{
    public class Order
    {

        public Order(int id, string name, decimal orderPrice, DateTime orderDate)
        {
            Id = id;
            Name = name;
            OrderPrice = orderPrice;
            OrderDate = OrderDate;
        }
        public Order(Product product, DateTime orderDate , int  productId )
        {
            Product = product;
            OrderDate = orderDate;
            ProductId = productId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
        public int ProductId { get;  set; }

        public decimal OrderPrice { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
