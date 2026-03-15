// We will create a To-Do list application
// This app will have 3 features:
// 1. Add a new task
// 2. View all tasks
// 3. Mark a task as completed
// 4. Exit the application

using ToDoList;

namespace ToDoList
{
    public class Program
    {
        static void Main(string[] args)
        {
            // The main method will be the entry point of our application
            // We will create a list to store our tasks and then we will display a menu to the user to perform the desired actions
            List<TaskItem> tasks = new List<TaskItem>();
            Console.WriteLine("Welcome to the To-Do List Application!");

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add a new task");
                Console.WriteLine("2. View all tasks");
                Console.WriteLine("3. Mark a task as completed");
                Console.WriteLine("4. Exit the application");
                Console.WriteLine($"{Environment.NewLine}Enter your choice:");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddTask(tasks);
                }
                else if (choice == "2")
                {
                    ViewTasks(tasks);
                }
                else if (choice == "3")
                {
                    MarkTaskAsCompleted(tasks);
                }
                else if (choice == "4")
                {
                    ExitApplication();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Invalid choice! Please try again. {Environment.NewLine}");
                }
            }
        }

        static void AddTask(List<TaskItem> tasks)
        {
            Console.WriteLine("Enter the task you want to add:");
            string task = Console.ReadLine();
            TaskItem newTask = new TaskItem
            {
                Title = task,
                IsCompleted = false
            };
            tasks.Add(newTask);
            Console.Clear();
            Console.WriteLine($"Task added! {Environment.NewLine}");
        }

        static void ViewTasks(List<TaskItem> tasks)
        {
            Console.Clear();
            foreach (var task in tasks)
            {
                string status = task.IsCompleted ? "Completed" : "Pending";
                Console.WriteLine($"{task.Title} - {status}");
            }
            Console.WriteLine($"{Environment.NewLine}");
        }

        static void MarkTaskAsCompleted(List<TaskItem> tasks)
        {
            Console.WriteLine("Enter the task you want to mark as completed:");
            string task = Console.ReadLine();
            if (!string.IsNullOrEmpty(task))
            {
                foreach (var t in tasks)
                {
                    if (t.Title.Equals(task, StringComparison.OrdinalIgnoreCase))
                    {
                        t.IsCompleted = true;
                        Console.Clear();
                        Console.WriteLine($"Task marked as completed! {Environment.NewLine}");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Task not found! Please try again. {Environment.NewLine}");
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Invalid task! Please try again. {Environment.NewLine}");
            }
        }

        static void ExitApplication()
        {
            Console.WriteLine("Exiting the application. Goodbye!");
            Environment.Exit(0);
        }
        
    }
}