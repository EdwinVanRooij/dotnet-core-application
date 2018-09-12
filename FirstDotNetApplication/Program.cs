using System;
using System.Collections.Generic;

namespace FirstDotNetApplication
{
    class Program
    {
        private static Sharplist sharpList = new Sharplist();

        static void Main(string[] args)
        {
            StartInteraction();
        }

        private static void StartInteraction()
        {
            Print("Welcome to Sharplist!");
            ShowOptionMenu();

            AskAgain();
        }

        private static void AskAgain()
        {
            string answer = GetString("Would you like to do something else? y/n");
            if (answer.ToLower() == "y" || answer.ToLower() == "ye" || answer.ToLower() == "yes")
            {
                Console.Clear();
                ShowOptionMenu();
                AskAgain();
            }
            else
            {
                ExitConsole();
            }
        }

        private static void ShowOptionMenu()
        {
            // Give option menu:
            // 1: View all lists
            // 2: Create new list
            // 3: Edit list name x
            // 4: Delete list name x
            // 5: View all todo's from list x
            // 6: Create new todo at list x
            // 7: Mark todo y at list x as done
            // 8: Unmark todo y at list x as done
            // 9: Delete todo y at list x
            Dictionary<int, string> options = new Dictionary<int, string>
            {
                { 1, "View all lists" },
                { 2, "Create new list" },
                { 3, "Edit list name" },
                { 4, "Delete list" },
                { 5, "View list" },
                { 6, "Create new todo at list" },
                { 7, "Mark todo at list as done" },
                { 8, "Unmark todo at list as done" },
                { 9, "Delete todo at list" }
            };

            foreach (KeyValuePair<int, string> entry in options)
            {
                Print($"{entry.Key}: {entry.Value}");
            }

            int choice = GetInt("What would you like to do?");
            switch (choice)
            {
                case 1:
                    ViewLists();
                    break;
                case 2:
                    CreateList();
                    break;
                case 3:
                    EditListName();
                    break;
                case 4:
                    DeleteList();
                    break;
                case 5:
                    ViewList();
                    break;
                case 6:
                    CreateNewTodoAtList();
                    break;
                case 7:
                    MarkTodoAtListAsDone();
                    break;
                case 8:
                    UnmarkTodoAtListAsDone();
                    break;
                case 9:
                    DeleteTodoAtList();
                    break;
                default:
                    Print($"Could not figure out what to do with \"{choice}\"!");
                    break;
            }
        }

        private static void DeleteTodoAtList()
        {
            Print("Not implemented yet!");
        }

        private static void UnmarkTodoAtListAsDone()
        {
            Print("Not implemented yet!");
        }

        private static void MarkTodoAtListAsDone()
        {
            Print("Not implemented yet!");
        }

        private static void CreateNewTodoAtList()
        {
            Print("Not implemented yet!");
        }

        private static void ViewList()
        {
            Print("Not implemented yet!");
        }

        private static void DeleteList()
        {
            Print("Not implemented yet!");
        }

        private static void EditListName()
        {
            Print("Not implemented yet!");
        }

        private static void CreateList()
        {
            Print("Not implemented yet!");
        }

        private static void ViewLists()
        {
            Print("Not implemented yet!");
        }

        private static void Print(string message)
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine($"[{time}]: > {message}");
        }

        private static string GetString(string question = "Enter a string: ")
        {
            Print(question);
            return Console.In.ReadLine().ToString();
        }

        private static int GetInt(string question = "Enter a number: ")
        {
            Print(question);
            string value;
            int intValue = 0;
            try
            {
                value = Console.ReadLine();
                intValue = Convert.ToInt32(value);
            }
            catch (FormatException e)
            {
                Print("Not a number! Try again.");
                intValue = GetInt(question);
            }
            return intValue;
        }

        private static void ExitConsole()
        {
            Print("Bye!");
            Print("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
