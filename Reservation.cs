using System;
using System.Collections.Generic;

namespace Object_Oriented_Design_Project
{
    public class Reservation
    {
        private Dictionary<string, int> _reservations;
        private HashSet<string> _availabilities;

        public Reservation(HashSet<string> availabilities)
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

        public HashSet<string> Availabilities
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
            return availability + " confirmed";
        }
    }
}
