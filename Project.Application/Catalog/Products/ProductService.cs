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
using Project.Application.Common;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;
using Project.Utilities.Exceptions;

namespace Project.Application.Catalog.Products
{
    public class ProductService : IProductService
    {
        private readonly ProjectDbContext _context;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";
        public ProductService(ProjectDbContext projectDbContext, IStorageService storageService)
        {
            _context = projectDbContext;
            _storageService = storageService;
        }

        public async Task<bool> Create(ProductCreateRequest request)
        {

            var product = new Product()
            {
                Price = request.Price,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                Name = request.Name,
                Description = request.Description,
                Details = request.Details,
            };
            
            //Save image
            if (request.ThumbnailImage != null)
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Caption = "Thumbnail image",
                        DateCreated = DateTime.Now,
                        FileSize = request.ThumbnailImage.Length,
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                        SortOrder = 1
                    }
                };
            }
            _context.Products.Add(product);
            var productInCategory = new ProductInCategory()
            {
                Product=product,
                CategoryId = request.categoryId
            };
            _context.ProductInCategories.Add(productInCategory);
             
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<ProductViewModel> GetById(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            var categories = await (from c in _context.Categories
                                    join pic in _context.ProductInCategories on c.Id equals pic.CategoryId
                                    where pic.ProductId == productId 
                                    select c.Name).ToListAsync();

            var image = await _context.ProductImages.Where(x => x.ProductId == productId && x.IsDefault == true).FirstOrDefaultAsync();

            var productViewModel = new ProductViewModel()
            {
                Id = product.Id,
                DateCreated = product.DateCreated,
                Description = product.Description,
                Details = product.Description,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                ViewCount = product.ViewCount,
                Categories = categories,
                ThumbnailImage = image != null ? image.ImagePath : "no-image.jpg"
            };
            return productViewModel;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
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

        public async Task<bool> UpdateProduct(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            

            if (product == null ) throw new ProjectException($"Cannot find a product with id: {request.Id}");

            product.Name = request.Name;
            product.Price = request.Price;
            product.Stock = request.Stock;
            product.Description = request.Description;
            

            //Save image
            if (request.ThumbnailImage != null)
            {
                var thumbnailImage = await _context.ProductImages.FirstOrDefaultAsync(i => i.IsDefault == true && i.ProductId == request.Id);
                if (thumbnailImage != null)
                {
                    thumbnailImage.FileSize = request.ThumbnailImage.Length;
                    thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                    _context.ProductImages.Update(thumbnailImage);
                }
                else
                {
                    product.ProductImages = new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            Caption = "Thumbnail image",
                            DateCreated = DateTime.Now,
                            FileSize = request.ThumbnailImage.Length,
                            ImagePath = await this.SaveFile(request.ThumbnailImage),
                            IsDefault = true,
                            SortOrder = 1
                        }
                    };
                }
            }
            await _context.SaveChangesAsync();

            return true;
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
