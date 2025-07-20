using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            bool running = true;

            Console.WriteLine("=== To-Do List Manager ===");

            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter the task to add: ");
                        string newTask = Console.ReadLine();
                        tasks.Add(newTask);
                        Console.WriteLine("Task added successfully.");
                        break;

                    case "2":
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks in the list.");
                        }
                        else
                        {
                            Console.WriteLine("\nYour Tasks:");
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                            }
                        }
                        break;

                    case "3":
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks to remove.");
                        }
                        else
                        {
                            Console.Write("Enter the task number to remove: ");
                            if (int.TryParse(Console.ReadLine(), out int index) &&
                                index >= 1 && index <= tasks.Count)
                            {
                                Console.WriteLine($"Removed task: {tasks[index - 1]}");
                                tasks.RemoveAt(index - 1);
                            }
                            else
                            {
                                Console.WriteLine("Invalid task number.");
                            }
                        }
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Exiting To-Do List Manager. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose between 1 and 4.");
                        break;
                }
            }
        }
    }
}
