using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Colors
    {
        public int Id { get; set; }
        public string color { get; set; }
        public string normalizeColor { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
