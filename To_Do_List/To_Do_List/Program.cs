using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            bool running = true;

            Console.WriteLine("Welcome to the To-Do List Application!");

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Remove a Task");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask(tasks);
                        break;
                    case "2":
                        ViewTasks(tasks);
                        break;
                    case "3":
                        RemoveTask(tasks);
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddTask(List<string> tasks)
        {
            Console.Write("Enter the task: ");
            string task = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);
                Console.WriteLine($"Task '{task}' added successfully!");
            }
            else
            {
                Console.WriteLine("Task cannot be empty!");
            }
        }

        static void ViewTasks(List<string> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                Console.WriteLine("Your Tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }

        static void RemoveTask(List<string> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to remove.");
                return;
            }

            ViewTasks(tasks);
            Console.Write("Enter the task number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                string removedTask = tasks[taskNumber - 1];
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine($"Task '{removedTask}' removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }
    }
}
