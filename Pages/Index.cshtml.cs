using System.Collections.Generic;
using System.Linq;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FreakyFashion.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;      

        private readonly ApplicationDbContext context;

        public List<Product> ProductList = new List<Product>();
        public List<Category> CategoryList = new List<Category>();

        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            this.logger = logger;
            this.context = context;
        }

        public void OnGet()
        {
            ProductList = context.Product
                .ToList();

            CategoryList = context.Categories.ToList();
        }
    }
}
