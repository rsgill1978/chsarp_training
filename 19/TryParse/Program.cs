using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = true;

            while (success)
            {
                Console.WriteLine();
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();

                if (int.TryParse(numInput, out int num))
                {
                    Console.WriteLine(num + " is a valid integer.");
                    success = false;
                }
                else
                {
                    Console.WriteLine(num + " is an invalid integer.");
                }
            }
            
            Console.ReadLine();
        }
    }
}


