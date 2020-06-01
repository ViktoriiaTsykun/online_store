using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Interfaces;
using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly Cart cart;

        public OrderController(IAllOrders allOrders, Cart cart)
        {
            this.allOrders = allOrders;
            this.cart = cart;
        }

        public IActionResult Checkout()
        {
            ViewBag.Title = "Замовлення";
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            cart.listItems = cart.getCartItems();

            if(cart.listItems.Count == 0)
            {
                ModelState.AddModelError("", "You must have products in cart");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("CompletedOrder");
            }

            return View(order);
        }

        public IActionResult CompletedOrder()
        {
            ViewBag.Title = "Дякуємо за замовлення!";
            ViewBag.Message = "Дякуємо за замовлення! Скоро наш менеджер зв'яжеться з вами та обговорить деталі замовлення. Замовляйте у нас ще!";
            return View();
        }
    }
}
