using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion.Viewcomponents
{
    public class ViewComponents : ViewComponent
    {
        private readonly ApplicationDbContext context;


        public ViewComponents(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke(IList<Product> products)
        {
            return View(products);
        }


    }
}
