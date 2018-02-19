using System;
using System.Collections.Generic;
using System.Linq;

namespace Studio2
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = System.IO.File.ReadAllText(@"C:\Users\James Cook\source\input.txt");


         /*   string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                " Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. " +
                "Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit" +
                " metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, " +
                "volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
                */
            Dictionary<char, int> result = new Dictionary<char, int>();

            //Lines below to make function case insensitive
            input = input.ToLower();
            foreach (char letter in input)
            {
                if (result.Keys.Contains(letter) && letter >= 'a' && letter <= 'z' )
                {
                    result[letter]++;
                }
                else if (letter >= 'a' && letter <= 'z')
                {
                    result.Add(letter, 1);
                }
                
            }

            foreach (KeyValuePair<char, int> line in result)
            {
                Console.WriteLine(line.Key + " (" + line.Value + ")");
            }
            
            Console.ReadLine();
        }
    }
}
