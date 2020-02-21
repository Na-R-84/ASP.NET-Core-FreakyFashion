using System.Collections.Generic;
using System.Linq;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreakyFashion
{
    public class ProductModelOne : PageModel
    {
        private ApplicationDbContext context;
        public int Id { get; set; }
        public Product Product { get; set; }
        public List<Product> Products { get; set; }


        public ProductModelOne(ApplicationDbContext context)
        {
            this.context = context;
        }
      
       

        public IActionResult OnGet(int id)
        {
            Product = this.context.Products.FirstOrDefault(x => x.Id == id);
            Products = this.context.Products.ToList();
            if (Product == null)
            {
                return NotFound(); // HTTP 404
            }

            return Page();


        }
    }
}