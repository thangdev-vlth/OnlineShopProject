using Project.ViewModels.common;

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

        Task<ProductViewModel> GetById(int productId);
        Task<bool> UpdateProduct(ProductUpdateRequest request);
        Task<RequestResult<bool>> AssignCategory(int productId,int CategoryId );
        Task<RequestResult<bool>> UnAssignCategory(int productId, int CategoryId);
        Task<List<ProductViewModel>> GetFeaturedProducts();
        Task<List<ProductViewModel>> GetLatestProducts();
        //Task<ProductViewModel> GetById(String id);
    }
}
