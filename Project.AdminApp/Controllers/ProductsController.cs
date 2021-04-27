using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalog.Products;
using Project.ViewModels.common;
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Controllers
{

    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index(string keyword, int? categoryId)
        {
            PageResult<ProductViewModel> products = await _productService.GetAll();
            return View(products);
            //var result=
            
        }
        
    }
}
