using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = -10;

            //if (age >= 0)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            // Conditional operator simplifies the if statement above ^^^
            // condition ? true : false
            string answer = age >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(answer);
            Console.WriteLine(age >= 0 ? "Valid" : "Invalid"); // preferred way 
            
            
            
            
            
            
            
            
            
            Console.ReadLine();
        }
    }
}
