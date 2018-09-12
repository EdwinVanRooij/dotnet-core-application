using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDotNetApplication.Domain
{
    class TodoList
    {
        public List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();

        public List<TodoItem> GetUndoneItems()
        {
            List<TodoItem> result = new List<TodoItem>();
            foreach (TodoItem t in TodoItems)
            {
                if (!t.IsDone)
                {
                    result.Add(t);
                }
            }
            return result;
        }

        public List<TodoItem> GetDoneItems()
        {
            List<TodoItem> result = new List<TodoItem>();
            foreach (TodoItem t in TodoItems)
            {
                if (t.IsDone)
                {
                    result.Add(t);
                }
            }
            return result;
        }
    }
}
