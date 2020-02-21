using System.Collections.Generic;
using System.Linq;
using FreakyFashion.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace FreakyFashion.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;      

        private readonly ApplicationDbContext context;

        public List<Data.Entities.Product> ProductList = new List<Data.Entities.Product>();
        public List<Data.Entities.Category> CategoryList = new List<Data.Entities.Category>();

        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            this.logger = logger;
            this.context = context;
        }

        public void OnGet()
        {
            ProductList = context.Products.ToList();

            CategoryList = context.Categories.ToList();
        }
    }
}
