using System;

namespace Ex2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 2, 3, 5, 8 };

            foreach(int i in numbers)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();
        }
    }
}
