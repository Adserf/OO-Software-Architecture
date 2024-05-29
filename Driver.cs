using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public class Driver: Person
    {
        List<Delivery> _deliveries;
        public Driver(string firstName, string lastName, int id, string phoneNumber): base(id, lastName, firstName, phoneNumber)
        {
            _deliveries = new List<Delivery>();
        }
        public string ReceiveDetails(Delivery delivery)
        {
            _deliveries.Add(delivery);
            return delivery.GetOrder.Details;
        }
        public bool ComfirmDelivery(Delivery delivery)
        {
            return delivery.Confirm();
        }
    }
}
