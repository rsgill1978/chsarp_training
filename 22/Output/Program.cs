using System;

namespace Output
{
    class Program
    {
        // \t \n\" \\
        static void Main(string[] args)
        {
            string speech = "He said: \"something\"";
            string path1 = "C:\\Blah";
            
            Console.WriteLine($"The first path is {path1}.");
            Console.WriteLine(speech);

            // $ +
            // $"Your name is {name}"
            // "Your name is " + name
            // Using the @ negates \t \n (tab and new line)
            string path2 = @"C:\Blah" + "\nNew line";
            Console.WriteLine($"The second path is {path2}.");

            // Double "" to ensre " appears
            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
