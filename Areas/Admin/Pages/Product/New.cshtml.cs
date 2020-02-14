using Colonize.Website.Data.Entities;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FreakyFashion.Pages.Admin.Pages
{
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty]
        public NewProductViewModel viewModel { get; set; }
        public List<SelectListItem> CategoryListItems { get; set; } = new List<SelectListItem>();
        public List<Category> Categories { get; set; }
        [BindProperty]
        public List<int> CategoryProducts { get; set; }
        public NewModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            Categories = context.Categories.ToList();

            foreach (var item in Categories)
            {
                CategoryListItems.Add(
                    new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = item.Name
                    }

                    ); ;
            }
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

            foreach (var relation in CategoryProducts)
            {
                context.CategoryProducts.Add(new CategoryProduct(product.Id, relation));
                context.SaveChanges();
            }

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
            public decimal Price { get; set; }
            [Required]
            public string ImageUrl { get; set; }
       

        }
    }
}