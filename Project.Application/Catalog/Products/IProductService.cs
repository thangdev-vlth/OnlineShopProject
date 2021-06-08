using Project.ViewModels.common;
using Project.ViewModels.ProductImage;
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<RequestResult<bool>> Create(ProductCreateRequest request);
        Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
        string getThumnailImg(int productId);
        Task<ProductViewModel> GetById(int productId);
        Task<bool> UpdateProduct(ProductUpdateRequest request);
        Task<RequestResult<bool>> AssignCategory(int productId,int CategoryId );
        Task<RequestResult<bool>> UnAssignCategory(int productId, int CategoryId);
        Task<List<ProductViewModel>> GetFeaturedProducts();
        Task<List<ProductViewModel>> GetLatestProducts();
        Task<RequestResult<bool>> AddImages(ProductUpdateRequest request);
        Task<RequestResult<List<ProductImageViewModel>>> GetAllImageAsync(int productId);
        Task<RequestResult<bool>> RemoveImageAsync(int productId,int imgId);
        //Task<ProductViewModel> GetById(String id);
    }
}
