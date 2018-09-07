using System;

namespace FirstDotNetApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name: ");
            string s = Console.In.ReadLine().ToString();
            Console.WriteLine($"Hi {s}!");

            ExitConsole();
        }

        private static void ExitConsole()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
