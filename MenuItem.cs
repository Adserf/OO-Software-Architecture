using System;

namespace Object_Oriented_Design_Project.Models
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
