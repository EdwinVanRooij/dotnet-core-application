using FirstDotNetApplication.Domain;
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
            Print("- - - - - - - - - - - - - - - - - - - - - -");
            Print("What would you like to do next?");
            Print("- - - - - - - - - - - - - - - - - - - - - -");
            ShowOptionMenu();
            AskAgain();
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
            // 10: Exit
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
                { 9, "Delete todo at list" },
                { 10, "Exit" }
            };

            foreach (KeyValuePair<int, string> entry in options)
            {
                Print($"{entry.Key}: {entry.Value}");
            }

            int choice = GetInt();
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
                case 10:
                    ExitConsole();
                    break;
                default:
                    Print($"Could not figure out what to do with \"{choice}\"!");
                    break;
            }
        }

        private static void DeleteTodoAtList()
        {
            int listId = GetInt("From which list?");
            int todoId = GetInt("Which todo?");
            if (sharpList.DeleteTodoAtList(listId, todoId))
            {
                Print($"Succesfully deleted todo with ID {todoId} in list with ID {listId}");
            }
            else
            {
                Print($"Could not delete todo with ID {todoId} in list with ID {listId}");
            }
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
            int listId = GetInt("Which list would you like to see?");
            TodoList t = sharpList.GetList(listId);
            if (t != null)
            {
                Print(t.ToString());
            }
            else
            {
                Print($"Could not find a todolist with id {listId}");
            }
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
            string title = GetString("What will be the title?");
            sharpList.CreateList(title);
        }

        private static void ViewLists()
        {
            foreach (TodoList t in sharpList.TodoLists)
            {
                Print(t.ToString());
            }
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
