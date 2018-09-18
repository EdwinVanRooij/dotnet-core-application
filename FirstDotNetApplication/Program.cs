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
            PrintView("Welcome to Sharplist!");
            ShowOptionMenu();

            AskAgain();
        }

        private static void AskAgain()
        {
            PrintView("- - - - - - - - - - - - - - - - - - - - - -");
            PrintView("What would you like to do next?");
            PrintView("- - - - - - - - - - - - - - - - - - - - - -");
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
                { 1, "List: View all" },
                { 2, "List: Create new" },
                { 3, "List: Edit name" },
                { 4, "List: Delete" },
                { 5, "List: View single" },
                { 6, "Todo: Create at list" },
                { 7, "Todo: Mark as done at list" },
                { 8, "Todo: Unmark as done at list" },
                { 9, "Todo: Delete at list" },
                { 10, "Exit" }
            };

            foreach (KeyValuePair<int, string> entry in options)
            {
                PrintView($"{entry.Key}: {entry.Value}");
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
                    PrintView($"Could not figure out what to do with \"{choice}\"!");
                    break;
            }
        }

        private static void DeleteTodoAtList()
        {
            try
            {
                TodoList tl = GetListFromUser();
                TodoItem ti = GetItemFromUser(tl);
                tl.DeleteItem(ti);
            }
            catch (IndexOutOfRangeException e)
            {
                PrintOutput(e.Message);
            }
        }

        private static void UnmarkTodoAtListAsDone()
        {
            try
            {
                TodoList tl = GetListFromUser();
                TodoItem ti = GetItemFromUser(tl);
                ti.UnmarkDone();
            }
            catch (IndexOutOfRangeException e)
            {
                PrintOutput(e.Message);
            }
        }

        private static void MarkTodoAtListAsDone()
        {
            try
            {
                TodoList tl = GetListFromUser();
                TodoItem ti = GetItemFromUser(tl);
                ti.MarkDone();
            }
            catch (IndexOutOfRangeException e)
            {
                PrintOutput(e.Message);
            }
        }

        private static void CreateNewTodoAtList()
        {
            try
            {
                TodoList tl = GetListFromUser();
                tl.CreateTodo(GetString("What will be the description?"));
            }
            catch (IndexOutOfRangeException e)
            {
                PrintOutput(e.Message);
            }
        }

        private static void ViewList()
        {
            int listId = GetInt("Which list would you like to see?");
            TodoList t = sharpList.GetList(listId);
            if (t != null)
            {
                foreach (TodoItem ti in t.TodoItems)
                {
                    PrintOutput(ti.ToString());
                }
            }
            else
            {
                PrintOutput($"Could not find a todolist with id {listId}");
            }
        }

        private static void DeleteList()
        {
            //todo
            PrintOutput("Not implemented yet!");
        }

        private static void EditListName()
        {
            //todo
            PrintOutput("Not implemented yet!");
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
                PrintOutput(t.ToString());
            }
        }

        private static void PrintOutput(string message)
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine($"\t\t{message}");
        }

        private static void PrintView(string message)
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine($"[{time}]: > {message}");
        }

        private static string GetString(string question = "Enter a string: ")
        {
            PrintView(question);
            return Console.In.ReadLine().ToString();
        }

        private static int GetInt(string question = "Enter a number: ")
        {
            PrintView(question);
            string value;
            int intValue = 0;
            try
            {
                value = Console.ReadLine();
                intValue = Convert.ToInt32(value);
            }
            catch (FormatException e)
            {
                PrintView("Not a number! Try again.");
                intValue = GetInt(question);
            }
            return intValue;
        }

        private static void ExitConsole()
        {
            PrintView("Bye!");
            PrintView("Press any key to exit...");
            Console.ReadKey();
        }

        internal static TodoList GetListFromUser()
        {
            int listId = GetInt("For which list?");
            return sharpList.GetList(listId);
        }

        internal static TodoItem GetItemFromUser(TodoList todoList)
        {
            int todoId = GetInt("For which item?");
            return todoList.GetItem(todoId);
        }

    }
}
