using System;
using System.Collections.Generic;

namespace Object_Oriented_Design_Project
{
    public class OrderOnline : Order
    {
        public OrderOnline(List<MenuItem> items) : base(items)
        {
        }

        public void InformKitchenStaff(KitchenStaff kitchenStaff)
        {
            kitchenStaff.ReceiveOrder(this);
        }

        public Delivery CreateDeliveryInstance(Driver driver)
        {
            Delivery delivery = new Delivery(this);
            driver.ReceiveDetails(delivery);
            return delivery;
        }
    }
}
