using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (name != string.Empty) // preferred over string != ""
            {
                Console.WriteLine($"Your name is {name}.");
            }
            else
            {
                Console.WriteLine("Name is empty.");
            }

            Console.ReadLine();
        }
    }
}
