using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public class Reservation
    {
        private Dictionary<string, int> _reservations;
        private HashSet<String> _availabilities;
        public Reservation(HashSet<String> availabilities) 
        { 
            _reservations = new Dictionary<string, int>();
            _availabilities = availabilities;
        }
        public bool Available 
        { 
            get
            {
                return _availabilities.Count > 0;
            }
        }
        public HashSet<String> Availabilities 
        { 
            get
            {
                return _availabilities;
            }
        }
        public bool Check(string availability)
        {
            return _availabilities.Contains(availability);
            
        }
        public string Confirm(string availability, int customerId)
        {
            _availabilities.Remove(availability);
            _reservations.Add(availability, customerId);
            return availability + " comfirmed";
        }
    }
}
