using System;

namespace TimesTable
{
    class Program
    {
        /*
             Ask the user for a number for the table
            Write a for loop to print the x times table
             */

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();

            if (int.TryParse(userNumber, out int number))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
                }
            }

            Console.ReadLine();
        }
    }
}
