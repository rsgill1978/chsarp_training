using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    class Program
    {
        static void Main(string[] args)
        {
            // int age = 23; 
            // var datatypes are determined by the value assigned to the variable
            // The datatype being assigned to the var variable will set the var variable to the datatype being assigned
            // Limit the usage of var
            var age = 23;
            Console.WriteLine(age);

            // long bigNumber = 90000000L;
            var bigNumber = 90000000L;
            Console.WriteLine(bigNumber);

            // double negative = -55.2D;
            var negative = -55.2D;
            Console.WriteLine(negative);

            // float precision = 5.000001F;
            float precision = 5.000001F;
            Console.WriteLine(precision);

            // decimal money = 5.99M;
            var money = 5.99M;
            Console.WriteLine(money);

            var name = "Raminder";
            var letter = 'A';

            Console.ReadLine();
        }
    }
}
