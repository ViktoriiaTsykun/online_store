using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class CartController : Controller
    {
        private IAllProducts _productRep;
        private readonly Cart _cart;

        public CartController(IAllProducts productRep, Cart cart)
        {
            _productRep = productRep;
            _cart = cart;
        }

        public ViewResult Index()
        {
            var items = _cart.getCartItems();
            _cart.listItems = items;

            var obj = new CartViewModel
            {
                cart = _cart
            };

            ViewBag.Title = "Корзина";

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _productRep.Products.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _cart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
