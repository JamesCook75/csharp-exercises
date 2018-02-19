using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MenuItem
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Created { get; set; }

        public MenuItem(string name, double price, string description,
                    string category, DateTime created)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            Created = created;
        }

        public MenuItem(string name, double price)
            : this(name, price, "", "", DateTime.Now) { }


    }
}

    
