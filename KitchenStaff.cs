using System;
using System.Collections.Generic;

namespace Object_Oriented_Design_Project
{
    public class KitchenStaff : Person
    {
        private Dictionary<int, Order> _orders;

        public KitchenStaff(int id) : base(id, "", "", "")
        {
            _orders = new Dictionary<int, Order>();
        }

        public void ReceiveOrder(Order order)
        {
            _orders.Add(order.ID, order);
        }

        public void UpdateOrder(string status, int id)
        {
            try
            {
                _orders[id].Status = status;
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine($"Error updating order: {ex.Message}");
            }
        }
    }
}
