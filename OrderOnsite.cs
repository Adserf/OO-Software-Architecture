using System;
using System.Collections.Generic;

namespace Object_Oriented_Design_Project
{
    public class OrderOnsite : Order
    {
        public OrderOnsite(List<MenuItem> items) : base(items)
        {
        }
        public void InformKitchenStaff(KitchenStaff kitchenStaff)
        {
            kitchenStaff.ReceiveOrder(this);
        }
    }
}
