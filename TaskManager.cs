using System;
using System.Collections.Generic;
namespace ToDoListApp
{
    public class TaskManager
    {
        private string userName;
        private List<Task> tasks;

        public TaskManager(string userName)
        {
            this.userName = userName;
            tasks = new List<Task>();
        }

        public void AddTask()
        {
            Console.WriteLine("Enter task description:");
            string description = Console.ReadLine()!;

            Console.WriteLine("Enter deadline (yyyy-MM-dd):");
            DateTime deadline = DateTime.Parse(Console.ReadLine()!);

            Task newTask = new Task(description, deadline);
            tasks.Add(newTask);

            Console.WriteLine("Task added! Press any key to continue.");
            Console.ReadKey();
        }

        public void ViewTasks()
        {
            Console.WriteLine("Your Tasks:");
            foreach (var task in tasks)
            {
                string status = task.IsComplete ? "Complete" : "Incomplete";
                Console.WriteLine($"- {task.Description} (Deadline: {task.Deadline.ToShortDateString()}) - {status}");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public void MarkTaskComplete()
        {
            Console.WriteLine("Enter task number to mark as complete:");
            int taskNumber = int.Parse(Console.ReadLine()!) - 1;

            if (taskNumber >= 0 && taskNumber < tasks.Count)
            {
                tasks[taskNumber].MarkComplete();
                Console.WriteLine("Task marked as complete!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public void DeleteTask()
        {
            Console.WriteLine("Enter task number to delete:");
            int taskNumber = int.Parse(Console.ReadLine()!) - 1;

            if (taskNumber >= 0 && taskNumber < tasks.Count)
            {
                tasks.RemoveAt(taskNumber);
                Console.WriteLine("Task deleted!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
