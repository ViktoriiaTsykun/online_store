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
    public class ProductsController : Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IProductsCategory _allCategories;

        public ProductsController(IAllProducts iAllProducts, IProductsCategory iProductsCat)
        {
            _allProducts = iAllProducts;
            _allCategories = iProductsCat;
        }

        [Route("Products/List")]
        [Route("Products/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products = null;
            string currCategory = "";
            string categoryDescr = "";

            if (string.Equals("Computers", category, StringComparison.OrdinalIgnoreCase))
            {
                products = _allProducts.Products.Where(i => i.Category.categoryName.Equals("Комп'ютери")).OrderBy(i => i.id);
                currCategory = "Комп'ютери";
            }
            else
            {
                if (string.Equals("Laptops", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(i => i.Category.categoryName.Equals("Ноутбуки")).OrderBy(i => i.id);
                    currCategory = "Ноутбуки";
                }
                else
                {
                    if (string.Equals("Smartphones", category, StringComparison.OrdinalIgnoreCase))
                    {
                        products = _allProducts.Products.Where(i => i.Category.categoryName.Equals("Смартфони")).OrderBy(i => i.id);
                        currCategory = "Смартфони";
                    }
                    else
                    {
                        if (string.Equals("Tablets", category, StringComparison.OrdinalIgnoreCase))
                        {
                            products = _allProducts.Products.Where(i => i.Category.categoryName.Equals("Планшети")).OrderBy(i => i.id);
                            currCategory = "Планшети";
                        }
                        else
                        {
                            if (string.Equals("TVs", category, StringComparison.OrdinalIgnoreCase))
                            {
                                products = _allProducts.Products.Where(i => i.Category.categoryName.Equals("Телевізори")).OrderBy(i => i.id);
                                currCategory = "Телевізори";
                            }
                            else
                            {
                                if (string.Equals("Cameras", category, StringComparison.OrdinalIgnoreCase))
                                {
                                    products = _allProducts.Products.Where(i => i.Category.categoryName.Equals("Фотоапарати")).OrderBy(i => i.id);
                                    currCategory = "Фотоапарати";
                                }
                                else
                                {
                                    if (string.Equals("Videocameras", category, StringComparison.OrdinalIgnoreCase))
                                    {
                                        products = _allProducts.Products.Where(i => i.Category.categoryName.Equals("Відеокамери")).OrderBy(i => i.id);
                                        currCategory = "Відеокамери";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            categoryDescr = _allCategories.AllCategories.FirstOrDefault(i => i.categoryName.Equals(currCategory)).description;

            var productObj = new ProductsListViewModel
            {
                allProducts = products,
                currCategory = currCategory,
                categoryDescr  = categoryDescr
            };

            ViewBag.Title = currCategory;
            return View(productObj);
        }
    }
}
