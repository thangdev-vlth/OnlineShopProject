using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Entities
{
    public class Product
    {
            public int Id { set; get; }

            public string Name { set; get; }

            public string Description { set; get; }

            public int SizeId { get; set; }
            public int ColorId { get; set; }
            public int sold { get; set; }
            public string Details { set; get; }

            public decimal Price { set; get; }

            public int Stock { set; get; }

            public int ViewCount { set; get; }

            public DateTime DateCreated { set; get; }

            public bool? IsFeatured { get; set; }

            public Sizes currentSize { get; set; }
            public Colors currentColor { get; set; }

            public List<Reviews> Reviews { get; set; }

            public List<ProductInCategory> ProductInCategories { get; set; }

            public List<OrderDetail> OrderDetails { get; set; }

            public List<Cart> Carts { get; set; }

            public List<ProductImage> ProductImages { get; set; }
    }
}
