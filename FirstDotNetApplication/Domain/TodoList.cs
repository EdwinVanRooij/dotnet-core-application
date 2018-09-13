using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDotNetApplication.Domain
{
    class TodoList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();

        public TodoList(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }

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

        internal void Remove(TodoItem i)
        {
            TodoItems.Remove(i);
        }

        public override string ToString()
        {
            return $"{Title} ({Id})";
        }
    }
}
