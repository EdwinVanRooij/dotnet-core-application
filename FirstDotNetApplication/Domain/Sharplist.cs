using FirstDotNetApplication.Domain;
using System;
using System.Collections.Generic;

namespace FirstDotNetApplication
{
    class Sharplist
    {
        private static int currentId = 1;

        public List<TodoList> TodoLists { get; set; } = new List<TodoList>();

        internal bool DeleteTodoAtList(int listId, int todoId)
        {
            foreach (TodoList l in TodoLists)
            {
                if (l.Id == listId)
                {
                    foreach (TodoItem i in l.TodoItems)
                    {
                        if (i.Id == todoId)
                        {
                            l.Remove(i);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        internal void CreateList(string title)
        {
            TodoLists.Add(new TodoList(GenerateId(), title));
        }

        private int GenerateId()
        {
            return currentId++;
        }

        internal TodoList GetList(int listId)
        {
            foreach (TodoList t in TodoLists)
            {
                if (t.Id == listId)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
