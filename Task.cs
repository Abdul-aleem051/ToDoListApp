using System;
using ToDoListApp;

namespace ToDoListApp
{
    public class Task
    {
        public string Name { get; set;}
        public string? Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsComplete { get; private set; }

        public Task(string name,string description, DateTime deadline)
        {
            Name = name;
            Description = description;
            Deadline = deadline;
            IsComplete = false;
        }

        public void MarkComplete()
        {
            IsComplete = true;
        }
    }
}
