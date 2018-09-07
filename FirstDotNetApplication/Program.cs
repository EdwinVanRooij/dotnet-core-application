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
            Person p = new Person(s);
            Console.WriteLine($"Hi {p.ToString}!");

            ExitConsole();
        }

        private static void ExitConsole()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
