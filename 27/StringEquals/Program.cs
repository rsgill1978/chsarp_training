using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            if (message.Equals(compare)) // preferred over message == compare
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            Console.Write("Enter your name: "); ;
            string name = Console.ReadLine();

            // if (name != string.Empty)
            if (!name.Equals("")) // preferred over == (== compares the memory reference of the variables in ADDITION to the values)
            {
                Console.WriteLine($"Your name is {name}.");
            }
            else
            {
                Console.WriteLine("Invalid name input.");
            }

            char[] chars = new char[] {'H', 'e', 'l', 'l', '0' };
            object newCompare = new string(chars);

            if (message.Equals(newCompare)) // Compare compares the actual value of the variables not the memory reference
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            Console.ReadLine();
        }
    }
}
