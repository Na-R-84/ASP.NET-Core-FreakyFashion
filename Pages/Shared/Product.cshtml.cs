using System.Linq;
using FreakyFashion.Data;
using FreakyFashion.Data.Caregories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion
{
    public class ProductModel : PageModel
    {
        public int Id { get; set; }
        private ApplicationDbContext context;
        public Product product { get; set; }
        public ProductModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet()
        {
            product = context.Product
                .Include(x => x.Name)
                .FirstOrDefault(x => x.Id == Id);

            if (product== null)
            {
                return NotFound(); // HTTP 404
            }

            return Page();


        }
    }
}