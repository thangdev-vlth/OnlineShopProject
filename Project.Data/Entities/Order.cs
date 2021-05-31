﻿using Project.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Entities
{
    public class Order
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public string UserId { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public string ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }
        public string CityId { get; set; }
        public string DistricstId { get; set; }
        public string WardsId { get; set; }
        public string CustomerNote { get; set; }
        public string StaffNote { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public AppUser AppUser { get; set; }
    }
}
