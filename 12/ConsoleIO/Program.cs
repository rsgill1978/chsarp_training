using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello my name is Gill!");

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name + "!");

            Console.Write("Please enter your age: ");
            string age = Console.ReadLine();
            //Console.WriteLine("Your age is: " + age);

            Console.WriteLine("Hi " + name + "! You're " + age + " year(s) old!");

            Console.ReadLine();
        }
    }
}
