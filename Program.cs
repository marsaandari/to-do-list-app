// We will create a To-Do list application
// This app will have 3 features:
// 1. Add a new task
// 2. View all tasks
// 3. Mark a task as completed
// 4. Exit the application

using ToDoList;

List<TaskItem> tasks = new List<TaskItem>();
Console.WriteLine("To Do List App!");

while (true)
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add a new task");
    Console.WriteLine("2. View all tasks");
    Console.WriteLine("3. Mark a task as completed");
    Console.WriteLine("4. Exit the application");

    Console.WriteLine($"{Environment.NewLine}Enter your choice:");

    string choice = Console.ReadLine(); 
    if (choice=="1")
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
    else if (choice=="2")
    {
        Console.Clear();
        foreach (var task in tasks)
        {
            string status = task.IsCompleted ? "Completed" : "Pending";
            Console.WriteLine($"{task.Title} - {status}");
        }
        Console.WriteLine($"{Environment.NewLine}");
    }
    else if (choice=="3")
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
    else if (choice=="4")
    {
        break;
    }
    else
    {
        Console.Clear();    
        Console.WriteLine($"Invalid choice! Please try again. {Environment.NewLine}");
    }

}