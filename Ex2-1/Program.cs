using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    total += number;
                }
            }
            
            Console.WriteLine("Total: " + total.ToString());
            Console.ReadLine();
        }
    }
}
