using System.Collections.Generic;
using System.Linq;
using FreakyFashion.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion
{
    public class OrderListModel : PageModel
    {

            private readonly ApplicationDbContext context;

            public IList<Data.Entities.Customer> Customers { get; set; }
            public IList<Data.Entities.Order> Orders { get; set; }


        public OrderListModel(ApplicationDbContext context)
            {
                this.context = context;
            }
            public void OnGet()
            {
            Orders = context.Orders
                .Include(x => x.OrderDate)
                .Include(x => x.Product.Price)
                .ToList();
            Customers = context.Customers
            .Include(x => x.Name )
            .Include(x => x.LastName)
            .ToList();
            }
    }
}