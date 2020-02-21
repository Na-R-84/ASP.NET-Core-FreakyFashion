using System.Collections.Generic;
using System.Linq;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreakyFashion
{
    public class SearchModel : PageModel
    {
        private ApplicationDbContext context;
        public List<Product> SearchResult { get; set; }

        public SearchModel(ApplicationDbContext _context)
        {
            context = _context;
        }
        
        public void OnGet(string searchString)
        {
            SearchResult = context.Products.Where(x => x.Name.Contains(searchString)).ToList();
        }
    }
}