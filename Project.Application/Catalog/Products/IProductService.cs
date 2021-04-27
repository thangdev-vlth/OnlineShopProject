﻿using Project.ViewModels.common;

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
        Task<int> Create(CreateProductRequest createProductRequest);
        Task<PageResult<ProductViewModel>> GetAll();
        //Task<ProductViewModel> GetById(String id);
    }
}
