using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public class Customer: Person
    {
        private Menu _menu;
        public Customer(string firstName, string lastName, int id, string phoneNumber, Menu menu) : base(id, lastName, firstName, phoneNumber)
        {
            _menu = menu;
        }
        public Order PlaceOrder(List<MenuItem> items)
        {
            Order order = new Order(items);
            return order;
        }
        public Payment MakePayment(Invoice invoice)
        {
            Payment payment = new Payment(invoice);
            return payment;
        }
        public string MakeReservation(Reservation reserve, string availability)
        {
            if (reserve.Check(availability))
            {
                return reserve.Confirm(availability, base.ID);
            }
            else
            {
                return "Not available";
            }
        }
        public Menu AccessMenu
        {
            get
            {
                return _menu;
            }
        }
    }
}
