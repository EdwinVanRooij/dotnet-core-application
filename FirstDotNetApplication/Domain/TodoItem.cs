using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDotNetApplication.Domain
{
    class TodoItem
    {
        public int Id { get; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public string DueDate { get; set; }

        public TodoItem(int id, string description, string dueDate = "")
        {
            Id = id;
            Description = description;
            IsDone = false;
            DueDate = dueDate;
        }

        internal string IsDoneDescription()
        {
            if (IsDone)
            {
                return "is done";
            }
            else
            {
                return "is not done";
            }
        }

        internal void UnmarkDone()
        {
            IsDone = false;
        }

        internal void MarkDone()
        {
            IsDone = true;
        }

        public override string ToString()
        {
            return $"{Description} ({Id}), {IsDoneDescription()}";
        }
    }
}
