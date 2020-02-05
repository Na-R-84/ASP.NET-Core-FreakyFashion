using System.Linq;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion
{
    public class CategoryModel : PageModel
    {
        private ApplicationDbContext context;
        public int Id { get; set; }
        public Category Category { get; set; }
        public CategoryModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet(int id)
        {
            Category = context.Categories
                .Include(x=> x.CategoryProducts).ThenInclude(x=> x.Product)
                .FirstOrDefault(x => x.Id == id);

            if (Category == null)
            {
                return NotFound(); // HTTP 404
            }

            return Page();


        }
    }
}