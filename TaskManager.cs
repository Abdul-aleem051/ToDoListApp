using System;
using System.Collections.Generic;
namespace ToDoListApp
{
    public class TaskManager
    {
           private List<Task> tasks;

        public TaskManager(string userName)
        {
            
            tasks = new List<Task>();
        }

        public void AddTask()
        {
            try
            {
                Console.WriteLine("Enter Task Title: ");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter Task Description:");
                string description = Console.ReadLine()!;

                Console.WriteLine("Enter deadline (hh:mm, yyyy-mm-dd):");
                bool deadline = DateTime.TryParse(Console.ReadLine()!, out DateTime deadlineTime);

                Task newTask = new Task(name,description, deadlineTime);
                tasks.Add(newTask);
                if(!deadline)
                {
                    Console.WriteLine("This is not a valid DATE or TIME");
                    return;
                }
        
                

                Console.WriteLine("Task added! Press any key to continue.");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine($"Invalid format!!,Please input a valid date.");

            }
        }


        public void ViewTasks()
        {
            Console.WriteLine("Your Tasks:");
            foreach (var task in tasks)
            {
                string status = task.IsComplete ? "Complete" : "Incomplete";
                Console.WriteLine($"- {task.Name}: {task.Description} (Deadline: {task.Deadline}) - {status}");
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
