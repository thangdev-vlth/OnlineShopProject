using Microsoft.AspNetCore.Http;
using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModels.Products
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }

        public decimal Price { set; get; }
        public int Stock { set; get; }

        public bool? IsFeatured { get; set; }
        public ProductStatus productStatus { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}