using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public  class Sizes
    {
        public int Id { get; set; }
        public string size { get; set; }
        public string normalizeSize { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
