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
                //Details=createProductRequest.Details,
                Price =createProductRequest.Price,
                ViewCount=0,
                Stock =createProductRequest.Stock,
                DateCreated= DateTime.Now
            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            /*
             keyword
             pageIndex
             pageSize
             categoryId ?
             */
            

            var query = from product in _context.Products
                        join productInCategory in _context.ProductInCategories on product.Id equals productInCategory.ProductId into productCategory
                        from productInCategory in productCategory.DefaultIfEmpty()
                        join category in _context.Categories on productInCategory.CategoryId equals category.Id into categories
                        from category in categories.DefaultIfEmpty()
                        select new { product, productInCategory, category };

            var queryc = from c in _context.Categories select c;

            //2. filter
            if (!string.IsNullOrEmpty(request.keyword))
                query = query.Where(x => x.product.Name.Contains(request.keyword) ||x.product.Id.Equals(request.keyword));
            if (request.id != null && request.id != 0)
            {
                query = query.Where(p => p.product.Id == request.id);
            }
            if (request.categoryId != null && request.categoryId != 0 )
            {
                query = query.Where(p => p.productInCategory.CategoryId== request.categoryId);
            }
            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(p => new ProductViewModel()
                {
                    Id = p.product.Id,
                    Price = p.product.Price,
                    Stock = p.product.Stock,
                    ViewCount = p.product.ViewCount,
                    DateCreated = p.product.DateCreated,
                    Name = p.product.Name,
                    Description = p.product.Description,
                    Details = p.product.Details,
                    sold = p.product.sold
                }).ToListAsync();

           
          
            //4. Select and projection
            var pagedResult = new PageResult<ProductViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };

            return pagedResult;
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
