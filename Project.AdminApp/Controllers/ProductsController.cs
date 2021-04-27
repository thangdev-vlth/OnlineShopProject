using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Application.Catalog.Categories;
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
        private readonly ICategoryService _categoryService;
        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index(string keyword, int? categoryId,int? id,int pageIndex = 1, int pageSize = 1)
        {
            var request = new GetProductPagingRequest()
            {
                keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                categoryId = categoryId
            };
            PageResult<ProductViewModel> products = await _productService.GetAllPaging(request);
            var categories = await _categoryService.GetAll();
            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = categoryId.HasValue && categoryId.Value == x.Id
            });
            ViewBag.Keyword = keyword;
            ViewBag.id = id;

            return View(products);
            //var result=
            
        }
        
    }
}
