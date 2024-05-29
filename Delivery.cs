using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public class Delivery
    {
        private Order _order;
        public Delivery() { }
        public Order GetOrder { get { return _order;  } }
        public bool Confirm()
        {
            return true;
        }
    }
}
