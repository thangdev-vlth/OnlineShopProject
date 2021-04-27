using Project.Data.EF;
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Data.Entities;
using System.Threading.Tasks;
using Project.ViewModels.common;
using Microsoft.EntityFrameworkCore;

namespace Project.Application.Catalog.Products
{
    public class ProductService : IProductService
    {
        private readonly ProjectDbContext _context;
        public ProductService(ProjectDbContext projectDbContext)
        {
            _context = projectDbContext;
        }

        public async Task<int> Create(CreateProductRequest createProductRequest)
        {
            var product = new Product()
            {
                Name = createProductRequest.Name,
                Description = createProductRequest.Description,
                Details=createProductRequest.Details,
                Price =createProductRequest.Price,
                ViewCount=0,
                Stock =createProductRequest.Stock,
                DateCreated= DateTime.Now
            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<PageResult<ProductViewModel>> GetAll()
        {
            //var query = from product in _context.Products
            //            join productInCategory in _context.ProductInCategories on product.Id equals productInCategory.ProductId into productCategory
            //            from productInCategory in productCategory.DefaultIfEmpty()
            //            join category in _context.Categories on productInCategory.CategoryId equals category.Id into categories
            //            from category in categories.DefaultIfEmpty()
            //            select new { product, productInCategory, category };
            var query = from product in _context.Products select product;
            var categoryQuery = from ct in _context.Categories select ct;
            var category = await categoryQuery.Select(c => new CategoryViewModel()
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            }).ToListAsync();
            var result =await query.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                Price = p.Price,
                Stock = p.Stock,
                ViewCount = p.ViewCount,
                DateCreated = p.DateCreated,
                Name = p.Name,
                Description = p.Description,
                Details = p.Details,
                sold=p.sold
            }).ToListAsync();


            return new PageResult<ProductViewModel>() { Items = result, categories = category };
        }
        
        //public async Task<UserViewModel> GetById(string id)
        //{
        //    var user = await _userManager.FindByIdAsync(id);

        //    var result = new UserViewModel()
        //    {
        //        Id = user.Id,
        //        UserName = user.UserName,
        //        Email = user.Email,
        //        PhoneNumber = user.PhoneNumber ?? "",
        //        Fullname = user.FullName,
        //        Birthday = user.Birthday,
        //        Address = user.Address,
        //        EmailConfirmed = user.EmailConfirmed ? "Đã Xác Nhận" : "Chưa Xác Nhận"
        //    };
        //    return result;
        //}
    }
}
