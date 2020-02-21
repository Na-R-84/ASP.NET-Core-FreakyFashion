using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FreakyFashion.Data.Entities;
using FreakyFashion.Helpers;




namespace FreakyFashion
{
    public class BasketModel : PageModel
    {

        public List<Item> basket { get; set; }
        public double Total { get; set; }

        public void OnGet()
        {
            basket = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "basket");
          //  Total = basket.Sum(i => i.Product.Price * i.Quantity);
        }

        public IActionResult OnGetBuyNow(int id)
        {
            var productModel = new ProductModel();
            basket = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "basket");
            if (basket == null)
            {
                basket = new List<Item>();
                basket.Add(new Item
                {
                   // Product = productModel.find(id),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "basket", basket);
            }
            else
            {
                int index = Exists(basket, id);
                if (index == -1)
                {
                    basket.Add(new Item
                    {
                      //  Product = productModel.find(id),
                        Quantity = 1
                    });
                }
                else
                {
                    basket[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "basket", basket);
            }
            return RedirectToPage("Basket");
        }

        public IActionResult OnGetDelete(int id)
        {
            basket = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "Basket");
            int index = Exists(basket, id);
            basket.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "basket", basket);
            return RedirectToPage("Basket");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            basket = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "basket");
            for (var i = 0; i < basket.Count; i++)
            {
                basket[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "basket", basket);
            return RedirectToPage("Basket");
        }

        private int Exists(List<Item> basket, int id)
        {
            for (var i = 0; i < basket.Count; i++)
            {
                if (basket[i].Product.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}