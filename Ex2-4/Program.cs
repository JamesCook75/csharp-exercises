using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> students =
                new Dictionary<int, string>();
            int newID = 0;

            Console.WriteLine("Enter your student ID (or 0 to finish):");
            do
            {
                Console.WriteLine("ID: ");
                newID = int.Parse(Console.ReadLine());
                if (newID != 0)
                {
                    Console.Write("Name: ");
                    string newStudent = Console.ReadLine();

                    students.Add(newID, newStudent);
                }
            }
            while (newID != 0);

            // Print roster
            StringBuilder MyString = new StringBuilder();
            MyString.Append("\nClass roster:\n");
       
            foreach (KeyValuePair<int, string> student in students)
            {
                MyString.Append(student.Key + " (" + student.Value + ")\n");
            }

            Console.WriteLine(MyString);
            Console.ReadLine();
        }
    }
}
