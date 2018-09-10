using System;

namespace FirstDotNetApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to-do list!");

            TodoList todoList = new TodoList() { Title = GetString("What will be the title?") };

            int n = GetInt("How many to-do items would you like to add?");

            TodoItem t1 = new TodoItem()
            {
                Description = GetString("")
            };
        }

        private static string GetString(string question = "Enter a string: ")
            {
                Console.WriteLine(question);
                return Console.In.ReadLine().ToString();
            }

            private static int GetInt(string question = "Enter a number: ")
            {
                Console.WriteLine(question);
                return Convert.ToInt32(Console.ReadLine());
            }

            private static void ExitConsole()
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
