using FreakyFashion.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace FreakyFashion.Pages.Admin.Pages
{
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public NewModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }


        [BindProperty]
        public Data.Entities.Category Category { get; set; }


       //}
        //public IActionResult OnPost()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }
        //    var category = new Data.Entities.Category (
        //        ViewModel.Name,
        //        new Uri(ViewModel.ImageUrl, UriKind.Absolute));

        //    _context.Categories.Add(category);

        //    _context.SaveChanges();

        //    return RedirectToPage("Index");
        //}

      

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var urlSlug = Category.Name.Replace(' ', '-').ToLower();

            Category.UrlSlug = urlSlug;

            _context.Categories.Add(Category);

            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }

        public class NewCategoryViewModel
        {
            [Required]
            [MaxLength(50)]
            public string Name { get; set; }

            [Required]
            public string ImageUrl { get; set; }
       

        }
    }
}