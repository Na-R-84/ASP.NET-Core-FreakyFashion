using FreakyFashion.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;

namespace FreakyFashion.Pages.Admin.Pages
{
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty]
        public NewProductViewModel viewModel { get; set; }

        public NewModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //public Product(string name, string description, Uri imageUrl, decimal price, int articleNumber)
            var product = new FreakyFashion.Data.Entities.Product(
                name: viewModel.Name,
                description: viewModel.Description,

                 imageUrl: new Uri(viewModel.ImageUrl, UriKind.Absolute),
                  price: viewModel.Price,
                     articleNumber: int.Parse(viewModel.ArticleNumber)
                );

            context.Product.Add(product);

            context.SaveChanges();

            return RedirectToPage("Index");
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
}