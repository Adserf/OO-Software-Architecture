using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public class Person
    {
        private int _id;
        private string _lastName;
        private string _firstName;
        private string _phoneNumber;
        public Person(int id, string lastName, string firstName, string phoneNumber) 
        {
            _id = id;
            _lastName = lastName;
            _firstName = firstName;
            _phoneNumber = phoneNumber;
        } 
        public int ID { get { return _id;} }
    }
}
