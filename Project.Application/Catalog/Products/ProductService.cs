using Project.Data.EF;
using Project.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Data.Entities;
using System.Threading.Tasks;

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
    }
}
