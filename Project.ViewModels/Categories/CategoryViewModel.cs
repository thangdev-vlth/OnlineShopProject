using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModels.Categories
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { set; get; }
        public int SortOrder { set; get; }

        public bool IsShowOnHome { set; get; }

        public int? ParentId { set; get; }

        public Status Status { set; get; }
        
    }
}