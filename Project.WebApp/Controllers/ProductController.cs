using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalog.Products;
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {
            CreateProductRequest request = new CreateProductRequest()
            {
                Name = "product TEst",
                Description = "test",
                Details = null,
                Price = 10000,
                Stock = 1
            };
            int result= await _productService.Create(request);
            ViewData["Result"] = result;
            return View();
        }
    }
}
