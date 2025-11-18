using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Please enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Hi " + name + "! You're " + age + " year(s) old!");



            //if (age < 0 || age > 150)
            //{
            //    Console.WriteLine("Invalid age!");
            //} else
            //{
            //    if (age >= 18 && age <= 25)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("You are between the ages of 18 and 25.");
            //    }
            //    else if (age >= 26)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("You are 26 or older.");
            //    }
            //}

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int answer = num1 * num2;

            Console.Write("Value of " + num1 + " * " + num2 + ": ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            if (answer == userAnswer)
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.WriteLine(num1 + " * " + num2 + " = " + answer);
                Console.WriteLine("Better luck next time!");
            }            

            Console.ReadLine();
        }        
    }
}
