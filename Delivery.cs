using System.Linq;

namespace Object_Oriented_Design_Project.Models
{
    public class Delivery
    {
        private Order _order;

        public Delivery(Order order)
        {
            _order = order;
            Status = "Not Delivered";
        }

        public Order GetOrder => _order;
        public string Status { get; set; }

        public bool Confirm()
        {
            Status = "Delivered";
            return true;
        }

        public string GetOrderDetails()
        {
            return string.Join(", ", _order.MenuItems.Select(item => item.Name));
        }
    }
}
