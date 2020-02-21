using FreakyFashion.Data;
using FreakyFashion.Areas.Admin.Pages.Category;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FreakyFashion.Areas.Admin.Pages.Product
{
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public NewModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public CategoryModel ViewModel { get; set; }

        public void OnGet()
        {
            ViewModel = new CategoryModel();
            ViewModel.CategoryList = _context.Categories.ToList()
               
               .Select(x => new SelectListItem
               {
                   Value = x.Id.ToString(),
                   Text = x.Name
               });

        }

        [BindProperty]
        public Data.Entities.Product Product { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var Category = new Data.Entities.Category(
               ViewModel.CategoryId);

            var urlSlug = Product.Name.Replace(' ', '-').ToLower();

            Product.UrlSlug = urlSlug;

            _context.Products.Add(Product);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
       


        public class NewProductViewModel
        {
            [Required]
            [MaxLength(50)]
            public string Name { get; set; }

            [Required]
            [MaxLength(500)]
            public string ArticleNumber { get; set; }

            [Required]
            public string Description { get; set; }
            [Required]
            public string Category { get; set; }

            [Required]
            public decimal Price { get; set; }
            [Required]
            public string ImageUrl { get; set; }
       

        }
    }
    public class CategoryModel
    {
   public IEnumerable<SelectListItem> CategoryID { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; internal set; }
    }
}