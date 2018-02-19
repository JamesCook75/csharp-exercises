using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Menu
    {
        private string Name { get; set; }
        public List<MenuItem> Items { get; set; }

        public Menu(string name, List<MenuItem> items)
        {
            Name = name;
            Items = items;
        }

            public void AddItem(MenuItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(MenuItem item)
        {
            Items.Remove(item);
        }

        public string PrintMenu()
        {
            string output = "";
            foreach (MenuItem item in Items)
            {
                output += "Name: " + item.Name + "\nDescription: " + item.Description + "\nPrice: " + item.Price + "\n\n--------";
            }

            return output;
        }
    }
}
