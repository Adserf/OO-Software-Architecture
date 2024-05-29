using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public class PurchaseRecord
    {
        private List<Dictionary<String, String>> _records;
        public PurchaseRecord() 
        {
            _records = new List<Dictionary<String, String>>();
        }
        public void AddRecord(Customer customer, MenuItem menuItem)
        {
            Dictionary<String, String> record = new Dictionary<String, String>();
            record.Add("Customer ID", customer.ID.ToString());
            record.Add("Item", menuItem.Name);
        }
    }
}
