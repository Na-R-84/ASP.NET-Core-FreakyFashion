using FreakyFashion.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FreakyFashion.Areas.Admin.Pages.Category
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext context;

        public IList<Data.Entities.Category> Category { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Category = context.Categories.Include(x=> x.CategoryProducts).ThenInclude(x=> x.Product).ToList();
        }
    }
}