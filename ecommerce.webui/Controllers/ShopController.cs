using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ecommerce.business.Abstract;
using ecommerce.entity;
using ecommerce.webui.Models;
using System.Collections.Generic;
using ecommerce.data.Concrete.EfCore;

namespace ecommerce.webui.Controllers
{
    public class ShopController:Controller
    {
        private IProductService _productService;
        private IProductCommentService _productCommentService;
        public ShopController(IProductService productService, IProductCommentService productCommentService)
        {
            this._productService=productService;
            this._productCommentService=productCommentService;
        }

        // localhost/products/telefon?page=1
        public IActionResult List(string sortOrder, string category,int page=1)
        {
            const int pageSize=6;
            ViewData["PriceOrderDesc"] = "price_desc";
            ViewData["PriceOrderInc"] = "price_inc";
            var productViewModel = new ProductListViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = _productService.GetCountByCategory(category),
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = category
                },
                Products = _productService.GetProductsByCategory(category,page,pageSize,sortOrder)
            };

            // var productViewModel = new ProductListViewModel();
            // ViewData["PriceOrderDesc"] = "price_desc";
            // ViewData["PriceOrderInc"] = "price_inc";
            // switch (sortOrder)
            // {
            //     case "price_desc":
            //     productViewModel = new ProductListViewModel()
            //     {
            //         PageInfo = new PageInfo()
            //         {
            //             TotalItems = _productService.GetCountByCategory(category),
            //             CurrentPage = page,
            //             ItemsPerPage = pageSize,
            //             CurrentCategory = category
            //         },
            //         Products = _productService.GetProductsByCategory(category,page,pageSize).OrderByDescending(a=> a.Price).ToList()
                    
            //     };
            //         break;
            //     case "price_inc":
            //         productViewModel = new ProductListViewModel()
            //         {
            //             PageInfo = new PageInfo()
            //             {
            //                 TotalItems = _productService.GetCountByCategory(category),
            //                 CurrentPage = page,
            //                 ItemsPerPage = pageSize,
            //                 CurrentCategory = category
            //             },
            //             Products = _productService.GetProductsByCategory(category,page,pageSize).OrderBy(a=> a.Price).ToList()
                        
            //         };
            //     break;
            //     default:
            //         productViewModel = new ProductListViewModel()
            //         {
            //             PageInfo = new PageInfo()
            //             {
            //                 TotalItems = _productService.GetCountByCategory(category),
            //                 CurrentPage = page,
            //                 ItemsPerPage = pageSize,
            //                 CurrentCategory = category
            //             },
            //             Products = _productService.GetProductsByCategory(category,page,pageSize)
            //         };
            //         break;
            // }
            return View(productViewModel);
        }

        public IActionResult Details(string url)
        {
            if (url==null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails(url);
            if(product==null)
            {
                return NotFound();
            }
            ProductCommentViewModel vm = new ProductCommentViewModel();

            vm.Title = product.Name;

            var productId = product.ProductId;
            
            var comments = _productCommentService.GetProductComment(product);
            vm.ListOfComments = comments;

            var ratings = _productCommentService.GetProductComment(product);
            if(ratings.Count() > 0)
            {
                var ratingSum = ratings.Sum( d=> d.Rating);
                ViewBag.RatingSum = ratingSum;
                var ratingCount = ratings.Count();
                ViewBag.RatingCount = ratingCount;
            }
            else
            {
                ViewBag.RatingSum = 0;
                ViewBag.RatingCount = 0;
            }
            vm.Product = product;
            vm.Categories = product.ProductCategories.Select(i=>i.Category).ToList();
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Details(ProductCommentViewModel vm)
        {
            var comment = vm.Comment;
            var productId = vm.Product.ProductId;
            var rating = vm.Rating;
            var userName = vm.UserName;

            ProductComment ProductComment = new ProductComment()
            {
                ProductId = productId,
                Comments = comment,
                Rating = rating,
                PublishedDate = DateTime.Now,
                UserName = userName
            };

            _productCommentService.AddProductComment(ProductComment);
            return RedirectToAction("Details","Shop", new{ url = vm.Product.Url});
        }

        public IActionResult Search(string q)
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetSearchResult(q)
            };

            return View(productViewModel);
        }
    }
}