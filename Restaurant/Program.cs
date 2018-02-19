using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem beeftacos = new MenuItem("Tacos", 12.00);
            MenuItem chickentacos = new MenuItem("Tacos", 12.00);
            MenuItem chips = new MenuItem("Chips and Pico", 4.50);
            beeftacos.Description = "Ground beef tacos with cheese, lettuce, tomato and onion.";
            beeftacos.Category = "Main Course";
            chickentacos.Description = "Grilled chicken tacos with cheese, lettuce, tomato and onion.";
            chickentacos.Category = "Main Course";
            chickentacos.Created = new DateTime(2015, 6, 3, 22, 15, 0);
            chips.Description = "Corn tortilla chips with fresh pico de gallo.";
            chips.Category = "Appetizer";
            Menu Cantina = new Menu("Cantina");
            Cantina.AddItem(beeftacos);
            Cantina.AddItem(chickentacos);
            Cantina.AddItem(chips);
            Cantina.RemoveItem(beeftacos);





            Console.WriteLine(Cantina.PrintMenu());
            Console.WriteLine(beeftacos.Equals(chickentacos));
            Console.ReadLine();
        }
    }

}
