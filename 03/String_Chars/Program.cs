using System;

namespace String_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Gill"; // Note the value must be enclosed within " NOT '
            char letter = 'a'; //Note the value must be enclosed within ' NOT "

            Console.WriteLine(name);
            Console.WriteLine(letter);

            Console.Write("My name is: ");
            Console.Write(name);
            Console.WriteLine();
            Console.WriteLine("The character is: " + letter);

            Console.ReadLine();
        }
    }
}
