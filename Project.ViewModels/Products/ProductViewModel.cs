using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.Products
{
    public class ProductViewModel
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }

       
        public int sold { get; set; }
        [Display(Name = "Tên Sản phẩm")]
        public string Name { set; get; }
        [Display(Name = "Mô Tả Sản phẩm")]
        public string Description { set; get; }
        public string Details { set; get; }
        
        public bool? IsFeatured { get; set; }

        public string ThumbnailImage { get; set; }

        public List<string> Categories { get; set; } = new List<string>();
        /*
         Id
        Price
        Stock
        ViewCount
        DateCreated
        Name
        Description
        Details
        IsFeatured
        ThumbnailImage
        Categories
        siZZE 
         */
    }
}
