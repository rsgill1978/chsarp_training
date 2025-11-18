using System;

namespace FizzBuzz
{
    class Program
    {
        /*
         Create a for loop from 1 to x (15)
        3 and 5 = FizzBuzz
        3 = Fizz
        5 = Buzz
        else = number
         */
        static void Main(string[] args)
        {
            bool isBuzz = false;
            bool isFizz = false;

            for (int i = 1; i <= 15; i++)
            {
                isBuzz = i % 3 == 0;
                isFizz = i % 5 == 0;

                if (isBuzz && isFizz)
                {
                    Console.WriteLine("{0} = FizzBuzz", i);
                }
                else if (isFizz)
                {
                    Console.WriteLine("{0} = Fizz", i);
                }
                else if (isBuzz)
                {
                    Console.WriteLine("{0} = Buzz", i);
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();
        }
    }
}
