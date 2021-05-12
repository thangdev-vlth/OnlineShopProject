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
using Project.ViewModels.Categories;
using Project.ViewModels.ProductImage;

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

        public async Task<RequestResult<bool>> Create(ProductCreateRequest request)
        {
            try
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
                    productStatus = request.status,
                    IsFeatured=request.IsFeatured
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
                await _context.SaveChangesAsync();
                return new RequestSuccessResult<bool>();
            }
            catch (Exception e)
            {
                string error = null;
                if (e.InnerException.Message.Contains("Cannot insert duplicate key row in object "))
                {
                    error = "Tên Sản Phẩm Đã Tồn Tại Trong Hệ Thống";
                }
                return new RequestErrorResult<bool>(error==null? e.InnerException.Message:error);
            }
           
        }
        public async Task<ProductViewModel> GetById(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            var categories = _context.Products.Where(c => c.Id == productId).SelectMany(c => c.Categories);


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
                productStatus=product.productStatus,
                IsFeatured = product.IsFeatured,
                CategoriesVm = categories.Select(category => new CategoryViewModel()
                {
                    Id = category.Id,
                    Name = category.Name,
                    IsShowOnHome = category.IsShowOnHome,
                    Status = category.Status,
                    SortOrder = category.SortOrder
                }).ToList(),
                category=string.Join(" , ", categories.Select(category=>category.Name).ToList()),
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
            var query =from product in _context.Products.Include(x => x.Categories).Include(x=> x.ProductImages)

                        select product;
            
            //2. filter
                //by productId
                    if (request.id != null && request.id != 0)
                        {
                            query = query.Where(p => p.Id == request.id);
                        }
                //by keyword
                    if (!string.IsNullOrEmpty(request.keyword))
                        query = query.Where(x => x.Name.Contains(request.keyword) || x.Id.Equals(request.keyword));
                //by category
                    if (request.categoryId != null && request.categoryId != 0)
                    {
                        query = query.Where(p => p.Categories.Any(category=>category.Id==request.categoryId));
                    }
            ////3. Paging
            int totalRow = await query.CountAsync();
            var data = await query.Select( p => new ProductViewModel()
            {
                Id = p.Id,
                Price = p.Price,
                Stock = p.Stock,
                ViewCount = p.ViewCount,
                DateCreated = p.DateCreated,
                Name = p.Name,
                Description = p.Description,
                Details = p.Details,
                sold = p.sold,
                ProductImages=p.ProductImages.Select(image=> new ProductImageViewModel() {
                    Caption = image.Caption,
                    DateCreated = image.DateCreated,
                    FileSize = image.FileSize,
                    Id = image.Id,
                    ImagePath = image.ImagePath,
                    IsDefault = image.IsDefault,
                    ProductId = image.ProductId,
                    SortOrder = image.SortOrder
                }).ToList(),
                productStatus =p.productStatus,
                IsFeatured=p.IsFeatured,
                CategoriesVm=p.Categories.Select(category=> new CategoryViewModel() {
                    Id = category.Id,
                    Name = category.Name,
                    IsShowOnHome = category.IsShowOnHome,
                    Status = category.Status,
                    SortOrder = category.SortOrder
                }).ToList()
            }).ToListAsync();
            //var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
            //    .Take(request.PageSize)
            //    .Select(p => new ProductViewModel()
            //    {
            //        Id = p.product.Id,
            //        Price = p.product.Price,
            //        Stock = p.product.Stock,
            //        ViewCount = p.product.ViewCount,
            //        DateCreated = p.product.DateCreated,
            //        Name = p.product.Name,
            //        Description = p.product.Description,
            //        Details = p.product.Details,
            //        sold = p.product.sold
            //    }).ToListAsync();



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
            try
            {
                var product = await _context.Products.FindAsync(request.Id);


                if (product == null) throw new ProjectException($"Cannot find a product with id: {request.Id}");

                product.Name = request.Name;
                product.Price = request.Price;
                product.Stock = request.Stock;
                product.Description = request.Description;
                product.productStatus = request.productStatus;
                product.IsFeatured = request.IsFeatured;
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
            catch (Exception e)
            {
                var xx = e.Message;
                var x = 1;
                return false;
                throw;
            }
        }

        public async Task<RequestResult<bool>> AssignCategory(int productId, int CategoryId)
        {
            try
            {
                var product = await _context.Products.Include(c => c.Categories).SingleOrDefaultAsync(product => product.Id == productId);
                var category = await _context.Categories.FindAsync(CategoryId);
                product.Categories.Add(category);
                await _context.SaveChangesAsync();
                return new RequestSuccessResult<bool>();
            }
            catch (Exception e)
            {

                return new RequestErrorResult<bool>(e.InnerException.Message);
            }
            

        }

        public async Task<RequestResult<bool>> UnAssignCategory(int productId, int CategoryId)
        {
            var product = await _context.Products.Include(c=>c.Categories).SingleOrDefaultAsync(product=>product.Id==productId);

            try
            {
                if (product != null)
                {
                    var category = product.Categories.Where(category => category.Id == CategoryId).FirstOrDefault();
                        product.Categories.Remove(category);
                    
                    await _context.SaveChangesAsync();
                }
                return new RequestSuccessResult<bool>();
            }
            catch (Exception e)
            {

                return new RequestErrorResult<bool>(e.InnerException.Message);
            }
            
        }

        public async Task<List<ProductViewModel>> GetFeaturedProducts()
        {
            var query = from product in _context.Products.Include(x => x.Categories).Include(x => x.ProductImages)
                        where product.IsFeatured==true
                        select product;
            var data = await query.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                Price = p.Price,
                Stock = p.Stock,
                ViewCount = p.ViewCount,
                DateCreated = p.DateCreated,
                Name = p.Name,
                Description = p.Description,
                Details = p.Details,
                sold = p.sold,
                ProductImages = p.ProductImages.Select(image => new ProductImageViewModel()
                {
                    Caption = image.Caption,
                    DateCreated = image.DateCreated,
                    FileSize = image.FileSize,
                    Id = image.Id,
                    ImagePath = image.ImagePath,
                    IsDefault = image.IsDefault,
                    ProductId = image.ProductId,
                    SortOrder = image.SortOrder
                }).ToList(),
                productStatus = p.productStatus,
                IsFeatured = p.IsFeatured,
                CategoriesVm = p.Categories.Select(category => new CategoryViewModel()
                {
                    Id = category.Id,
                    Name = category.Name,
                    IsShowOnHome = category.IsShowOnHome,
                    Status = category.Status,
                    SortOrder = category.SortOrder
                }).ToList()
            }).ToListAsync();
            return data;
        }

        public async Task<List<ProductViewModel>> GetLatestProducts()
        {
            var query = from product in _context.Products.Include(x => x.Categories).Include(x => x.ProductImages)
                        select product;
            query = query.OrderByDescending(x => x.DateCreated);
            var data = await query.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                Price = p.Price,
                Stock = p.Stock,
                ViewCount = p.ViewCount,
                DateCreated = p.DateCreated,
                Name = p.Name,
                Description = p.Description,
                Details = p.Details,
                sold = p.sold,
                ProductImages = p.ProductImages.Select(image => new ProductImageViewModel()
                {
                    Caption = image.Caption,
                    DateCreated = image.DateCreated,
                    FileSize = image.FileSize,
                    Id = image.Id,
                    ImagePath = image.ImagePath,
                    IsDefault = image.IsDefault,
                    ProductId = image.ProductId,
                    SortOrder = image.SortOrder
                }).ToList(),
                productStatus = p.productStatus,
                IsFeatured = p.IsFeatured,
                CategoriesVm = p.Categories.Select(category => new CategoryViewModel()
                {
                    Id = category.Id,
                    Name = category.Name,
                    IsShowOnHome = category.IsShowOnHome,
                    Status = category.Status,
                    SortOrder = category.SortOrder
                }).ToList()
            }).ToListAsync();
            return data;
        }
    }
}
