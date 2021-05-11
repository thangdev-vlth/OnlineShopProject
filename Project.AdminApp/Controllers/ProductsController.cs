using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Application.Binder;
using Project.Application.Catalog.Categories;
using Project.Application.Catalog.Products;
using Project.Data.Enums;
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
        public async Task<IActionResult> Index(string keyword, int? categoryId,int? id,int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetProductPagingRequest()
            {
                keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                categoryId = categoryId,
                id=id
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
            ViewBag.categoryid=categoryId;
            return View(products);
            //var result=
            
        }
        [HttpGet]
        public async  Task<IActionResult> Create(int? categoryId)
        {
            var categories = await _categoryService.GetAll();

            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = categoryId.HasValue && categoryId.Value == x.Id
            });
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _productService.Create(request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Thêm mới sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            return View(request);
            
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var result = await _productService.GetById(id);
            result.status = result.productStatus.DisplayName();
           
            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var product = await _productService.GetById(id);
            var UpdateViewModel = new ProductUpdateRequest()
            {
                Id = product.Id,
                Description = product.Description,
                Details = product.Details,
                Name = product.Name,
                Stock=product.Stock,
                Price=product.Price
            };
            ViewBag.ProductStatus = Enum.GetValues(typeof(ProductStatus)).Cast<ProductStatus>().Select(v => new SelectListItem
            {
                Text = v.DisplayName(),
                Value = ((int)v).ToString(),
                Selected = product.productStatus == v
            }).ToList();
            return View(UpdateViewModel);
        }
        [HttpPost]
        public async Task<JsonResult> Update([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return Json(new { result = "theerrror" });

            var result = await _productService.UpdateProduct(request);
            if (result)
            {
                TempData["result"] = "Cập nhật sản phẩm thành công";
                //return RedirectToAction("Index");

                return Json(new { result = "Success" });
            }

            ModelState.AddModelError("", "Cập nhật sản phẩm thất bại");
            //return View(request);
            return Json(new { result = "theerrror" });
        }
        [HttpGet]
        public async Task<IActionResult> AssignCategory(int id)
        {
            ViewBag.productId=id;
            var categories = await _categoryService.GetAll();
            return View(categories);
        }
        [HttpPost]
        public async Task<JsonResult> Assign(int productId,int categoryId)
        {
           var result= await _productService.AssignCategory( productId,  categoryId);
            return Json(new { result = "true",method="assign" });
        }
        [HttpPost]
        public async Task<JsonResult> Unassign(int productId, int categoryId)
        {
            var result = await _productService.UnAssignCategory(productId, categoryId);
            return Json(new { result = "true", method = "unassign" });
        }
    }
}
