using System.Collections.Generic;
using FreakyFashion.Data.Entities;
using FreakyFashion.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreakyFashion
{
    public class ConfirmationModel : PageModel
    {
        public List<Item> confirmation { get; set; }
        public List<Product> product { get; set; }

        public double Total { get; set; }

        public void OnGet()
        {
            confirmation = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "confirmation");
            //  Total = basket.Sum(i => i.Product.Price * i.Quantity);
        }

        public IActionResult OnGetBuyNow(int id)
        {
            var productModel = new ProductModel();
            confirmation = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "confirmation");
            if (confirmation == null)
            {
                confirmation = new List<Item>();
                confirmation.Add(new Item
                {
                    // Product = productModel.find(id),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "confirmation", confirmation);
            }
            else
            {
                int index = Exists(confirmation, id);
                if (index == -1)
                {
                    confirmation.Add(new Item
                    {
                        //  Product = productModel.find(id),
                        Quantity = 1
                    });
                }
                else
                {
                    confirmation[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "confirmation", confirmation);
            }
            return RedirectToPage("confirmation");
        }

        public IActionResult OnGetDelete(int id)
        {
            confirmation = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "confirmation");
            int index = Exists(confirmation, id);
            confirmation.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "confirmation", confirmation);
            return RedirectToPage("confirmation");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            confirmation = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "confirmation");
            for (var i = 0; i < confirmation.Count; i++)
            {
                confirmation[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "confirmation", confirmation);
            return RedirectToPage("confirmation");
        }

        private int Exists(List<Item> confirmation, int id)
        {
            for (var i = 0; i < confirmation.Count; i++)
            {
                if (confirmation[i].Product.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}