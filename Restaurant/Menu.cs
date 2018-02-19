using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Menu
    {
        private string Name { get; set; }
        private List<MenuItem> Items { get; set; }
        private DateTime Updated { get; set; }

        public Menu(string name)
        {
            Name = name;
            Items = new List<MenuItem>();
            Updated = DateTime.Now;
        }

            public void AddItem(MenuItem item)
        {
            Items.Add(item);
            Updated = DateTime.Now;
        }

        public void RemoveItem(MenuItem item)
        {
            Items.Remove(item);
            Updated = DateTime.Now;
        }

        public string PrintMenu()
        {
            string output = "";

            foreach (MenuItem item in Items)
            {
                output += item.PrintMenuItem();
            }

            output += "Menu was last updated " + Updated.ToShortDateString();
            return output;
        }
    }
}
