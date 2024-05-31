using System;
using System.Collections.Generic;

namespace Object_Oriented_Design_Project
{
    public class Menu
    {
        private List<MenuItem> _items;

        public Menu()
        {
            _items = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem item)
        {
            _items.Add(item);
        }

        public void RemoveMenuItem(MenuItem item)
        {
            _items.Remove(item);
        }

        public List<MenuItem> GetMenuItems()
        {
            return _items;
        }
    }
}
