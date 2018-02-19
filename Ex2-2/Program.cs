using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> words = new List<string>();
            words.Add("hello");
            words.Add("world");
            words.Add("can");
            words.Add("you");
            words.Add("reads");
         

            foreach (string word in words)
            {
                if (word.Count() == 5)
                {
                    Console.WriteLine(word);
                }
            }

            
            Console.ReadLine();
        }
    }
}
