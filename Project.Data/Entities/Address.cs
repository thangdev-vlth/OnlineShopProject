using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Address
    {
        public int AddressCardId { get; set; }
        public string UserId { get; set; }
        public AddressStatus status { get; set; }
        public  int CityId { get; set; }
        public int DistricstId { get; set; }
        public int WardsId { get; set; } 
    }
}
