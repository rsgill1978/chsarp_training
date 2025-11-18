using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What would you like to repeat?: ");
            string message = Console.ReadLine();

            Console.Write("Number of loops: ");
            int loops = Convert.ToInt32(Console.ReadLine());

            if (loops <= 0)
            {
                Console.WriteLine("Enter a valid number greater than 0");
            }
            else
            {
                for (int i = 0; i < loops; i++)
                {
                    Console.WriteLine(message);
                }
            }            

            Console.WriteLine();

            //for (int i = 0; i <= 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadLine();
        }
    }
}
