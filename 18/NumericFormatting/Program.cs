using System;
using System.Globalization;

namespace NumericFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            //double value = 1000D / 12.34D;
            //Console.WriteLine(value);
            //// Put the value of the variable value in position 0
            //// Put the value of 1000 in position 1
            //Console.WriteLine(string.Format("{0} {1}", value, 1000));
            //// The : in {0}: tesll the compiler what format to display value as
            //Console.WriteLine(string.Format("{0:0}", value));
            //// # removes trailing 0s
            //Console.WriteLine(string.Format("{0:0.#}", value));
            //Console.WriteLine(string.Format("{0:0.0}", value));
            //Console.WriteLine(string.Format("{0:0.00}", value));

            double money = -10D /3D;
            Console.WriteLine(money);
            //Console.WriteLine("{0:0.00}", money);
            //Console.WriteLine(string.Format("{0:$0.00}", money));
            //Console.WriteLine(string.Format("${0:0.00}", money));
            //Console.WriteLine(string.Format("-$10 / $3 = ${0:0.00}", money));
            //Console.WriteLine(money.ToString("C"));
            //Console.WriteLine(money.ToString("C0"));
            //Console.WriteLine(money.ToString("C1"));
            //Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-NZ")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("ms-MY")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("ms-SG")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("id-ID")));
            




            Console.ReadLine();
        }
    }
}
