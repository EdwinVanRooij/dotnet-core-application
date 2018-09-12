using System;
using System.Collections.Generic;

namespace FirstDotNetApplication
{
    class Program
    {
        private static Sharplist sharpList = new Sharplist();

        static void Main(string[] args)
        {
            Print("Welcome to Sharplist!");


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
            StartInteraction();
            int amountOfLists = GetInt("How many lists would you like to create?");
        }

        private static void StartInteraction()
        {

            ShowOptionMenu();
        }

        private static void ShowOptionMenu()
        {
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
            }
        }

        private static void DeleteTodoAtList()
        {
            throw new NotImplementedException();
        }

        private static void UnmarkTodoAtListAsDone()
        {
            throw new NotImplementedException();
        }

        private static void MarkTodoAtListAsDone()
        {
            throw new NotImplementedException();
        }

        private static void CreateNewTodoAtList()
        {
            throw new NotImplementedException();
        }

        private static void ViewList()
        {
            throw new NotImplementedException();
        }

        private static void DeleteList()
        {
            throw new NotImplementedException();
        }

        private static void EditListName()
        {
            throw new NotImplementedException();
        }

        private static void CreateList()
        {
            throw new NotImplementedException();
        }

        private static void ViewLists()
        {
            throw new NotImplementedException();
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
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void ExitConsole()
        {
            Print("Bye!");
            Print("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
