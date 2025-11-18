using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = 23;
            Console.WriteLine(age);

            // The statements below all mean the same thing (increment age by 1)
            // age = age + 1;
            // age += 1;
            // age++
            
            // All operators (+, -, *, /) work the same way
            // Division is a special case.
            // It will only return whole numbers NEVER the remainder
            // THEREFORE if division is anticipated, use a double instead of int

            age/= 10; // 23/10 = 2.3 -> 2
            Console.WriteLine(age);

            string name = "Raminder";
            name += " Gill";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b'; // Because this is a char, the compiler takes the sum of the unicode values for A and B and displays the character for the summed up unicode
            Console.WriteLine(ch);

            int i = 0;
            // Prepending ++ to the variable name instructs the compiler to perform the mathematical operation before writing the result to console
            // i++ would result in writing the value of i to the console then perform the mathematical operation
            Console.WriteLine(++i); 

            Console.ReadLine();
        }
    }
}
