using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ecommerce.business.Abstract;
using ecommerce.data.Abstract;
using ecommerce.webui.Models;

namespace ecommerce.webui.Controllers
{
    // localhost:5000/home
    public class HomeController:Controller
    {      
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            this._productService=productService;
        }
        
        public IActionResult Index()
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetHomePageProducts()
            };

            return View(productViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

         public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}