using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10,
                num2 = 2,
                remainder;

            remainder = num1 % num2;
            Console.WriteLine(remainder + " remains when " + num1 + " is divided by " + num2);

            Console.WriteLine("Input a new value for num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Remainder for new num1 value (" + num1  + "): " + (remainder = num1 % num2));



            Console.ReadLine();
        }
    }
}
