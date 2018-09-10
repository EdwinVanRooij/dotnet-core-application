using System;

namespace FirstDotNetApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What's your name?");
            string name = Console.In.ReadLine().ToString();

            Console.WriteLine("How old are you?");
            string age = Console.In.ReadLine();

            Person p = new Person() { Name = name, Age = age };
            
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
