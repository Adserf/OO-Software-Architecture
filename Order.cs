using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public class Order
    {
        public string Status { get; set; }
        public int ID { get; set; }
        public string Details { get; set; }
        private List<MenuItem> _menuItems;
        public Order(List<MenuItem> items)
        {
            _menuItems = items;
        }
    }
}
