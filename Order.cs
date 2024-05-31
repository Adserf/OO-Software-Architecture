using System;
using System.Collections.Generic;
using System.Linq;

namespace Object_Oriented_Design_Project.Models
{
    public abstract class Order
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public List<MenuItem> MenuItems { get; private set; }

        public Order(List<MenuItem> items)
        {
            MenuItems = items;
            Status = "Pending";
        }
    }
}
