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

        public string PrintMenuItem()
        {
            string newItem = "";
            if (this.IsNew())
            {
                newItem = "- New Item!";
            }
            string output = Name + "\t" + newItem +  "\n" + Description + "\n$" +
                Price + "\n\n\n";
            return output;
        }

        public bool IsNew()
        {
            TimeSpan elapsed = DateTime.Now.Subtract(Created);
            if (elapsed.TotalDays < 30)
            { return true; }
            else
            { return false; }
          
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            MenuItem itemObj = obj as MenuItem;
            return Name == itemObj.Name;
        }

        //// override object.GetHashCode
        //public override int GetHashCode()
        //{
        //    // TODO: write your implementation of GetHashCode() here
        //    throw new NotImplementedException();
        //    return base.GetHashCode();
        //}
    }
}

    
