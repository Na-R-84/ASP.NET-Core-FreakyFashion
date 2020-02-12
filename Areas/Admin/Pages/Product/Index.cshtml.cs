using FreakyFashion.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FreakyFashion.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext context;

        public IList<Data.Entities.Product>Products { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Products = context.Product.Include(x=> x.categoryProducts).ThenInclude(x=> x.Category).ToList();
        }
    }
}