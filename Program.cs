using System;
using ToDoListApp;

Console.WriteLine("Enter your name:");
string userName = Console.ReadLine()!;

TaskManager taskManager = new TaskManager(userName);

while (true)
{
    Console.WriteLine($"Welcome, {userName}!");
    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. View Tasks");
    Console.WriteLine("3. Mark Task Complete");
    Console.WriteLine("4. Delete Task");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");
    
    
    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            taskManager.AddTask();
            break;

        case "2":
            taskManager.ViewTasks();
            break;
        case "3":
            taskManager.MarkTaskComplete();
            break;
        case "4":
            taskManager.DeleteTask();
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Invalid choice. Press any key to try again.");
            Console.ReadKey();
            break;
    }
}


