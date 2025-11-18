using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 10,
                secondNum = 3;

            // % (modulus operator) returns the remainder of a division
            // Useful for checking if a number is even or odd
            // if int1 % 2 = 0, then number is even
            // in int1 % 2 != 0, then number is odd
            Console.WriteLine(firstNum % secondNum);





            Console.ReadLine();
        }
    }
}
