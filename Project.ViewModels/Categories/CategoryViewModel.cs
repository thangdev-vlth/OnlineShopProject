using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModels.Categories
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }
    }
}