
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Project.Data.EF;
using Project.ViewModels.Categories;

namespace Project.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ProjectDbContext _context;

        public CategoryService(ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var query = from c in _context.Categories
                        select c;
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                IsShowOnHome=x.IsShowOnHome,
                Status=x.Status,
                SortOrder=x.SortOrder
            }).ToListAsync();
        }

        public async Task<CategoryViewModel> GetById( int id)
        {
            var query = from c in _context.Categories
                        select  c;
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                ParentId = x.ParentId
            }).FirstOrDefaultAsync();
        }
    }
}