using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop5
{
    internal class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine("Printing string: " + message);
        }

        public void Print(int number)
        {
            Console.WriteLine("Printing integer: " + number);
        }

        public void Print(string message, int count)
        {
            Console.WriteLine($"Printing message {count} times:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {message}");
            }
        }
    }
}
