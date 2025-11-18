using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcantenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Raminder";
            int age = 47;

            Console.WriteLine("Your name is " + name + ", and your age is " + age + ".");
            Console.WriteLine("Your name is {0}, and your age is {1}.", name, age);
            Console.WriteLine($"Your name is {name}, and your age is {age}.");

            string test = string.Concat("Your name is ", name, ", and your age is ", age, ".");
            Console.WriteLine(string.Concat("Your name is ", name, ", and your age is ", age, "."));
            Console.WriteLine(test);

            string[] names = new string[] { "Test1", "Test2", "Test3" };
            Console.WriteLine(string.Concat(names));

            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
