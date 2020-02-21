using System.Collections.Generic;
using FreakyFashion.Data.Entities;
using FreakyFashion.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FreakyFashion
{
    public class CheckOutModel : PageModel
    {
        public List<Item> checkOut { get; set; }
        public double Total { get; set; }

        public void OnGet()
        {
            checkOut = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "checkOut");
            //  Total = basket.Sum(i => i.Product.Price * i.Quantity);
        }

        public IActionResult OnGetBuyNow(int id)
        {
            var productModel = new ProductModel();
            checkOut = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "checkOut");
            if (checkOut == null)
            {
                checkOut = new List<Item>();
                checkOut.Add(new Item
                {
                    // Product = productModel.find(id),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "checkOut", checkOut);
            }
            else
            {
                int index = Exists(checkOut, id);
                if (index == -1)
                {
                    checkOut.Add(new Item
                    {
                        //  Product = productModel.find(id),
                        Quantity = 1
                    });
                }
                else
                {
                    checkOut[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "checkOut", checkOut);
            }
            return RedirectToPage("checkOut");
        }

        public IActionResult OnGetDelete(int id)
        {
            checkOut = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "checkOut");
            int index = Exists(checkOut, id);
            checkOut.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "checkOut", checkOut);
            return RedirectToPage("checkOut");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            checkOut = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "checkOut");
            for (var i = 0; i < checkOut.Count; i++)
            {
                checkOut[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "checkOut", checkOut);
            return RedirectToPage("checkOut");
        }

        private int Exists(List<Item> checkOut, int id)
        {
            for (var i = 0; i < checkOut.Count; i++)
            {
                if (checkOut[i].Product.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}