using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MenuItem
    {
        private double Price { get; set; }
        private string Description { get; set; }
        private string Category { get; set; }

        public MenuItem(double price, string description,
                    string category)
        {
            Price = price;
            Description = description;
            Category = category;
        }
    }
}

    
