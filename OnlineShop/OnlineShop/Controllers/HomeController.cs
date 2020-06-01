using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Interfaces;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private IAllProducts _productRep;

        public HomeController(IAllProducts productRep)
        {
            _productRep = productRep;
        }

        public ViewResult Index()
        {
            var homeProducts = new HomeViewModel
            {
                favProducts = _productRep.getFavProducts
            };

            ViewBag.Title = "Home";

            return View(homeProducts);
        }
    }
}
