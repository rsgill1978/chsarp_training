using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //} 

            //int i = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            Console.Write("Enter the first number: ");
            int numberA =  Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.WriteLine("What's the value of " + numberA + " x " + numberB + "?");

            // While will ONLY execute if the condition is met
            //while (answer != actualAnswer)
            //{
            //    Console.Write("Enter your answer: ");
            //    actualAnswer = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine();

            //    if (answer != actualAnswer)
            //    {
            //        Console.WriteLine("Close but " + actualAnswer + " is wrong!");
            //        Console.WriteLine();
            //    }
            //}

            // Do-While will always execute ONCE then validate the condition
            // If the condition is true, execute again
            // If the condition is false, stop execution
            do
            {
                Console.Write("Enter your answer: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but " + actualAnswer + " is wrong!");
                    Console.WriteLine();
                }

            } while (answer != actualAnswer);

            Console.WriteLine("Well done!");

            Console.ReadLine();                           
        }
    }
}
