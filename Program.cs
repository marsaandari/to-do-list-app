// We will create a To-Do list application
// This app will have 3 features:
// 1. Add a new task
// 2. View all tasks
// 3. Mark a task as completed
// 4. Exit the application

List<string> tasks = new List<string>();
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
        tasks.Add(task);
        Console.Clear();
        Console.WriteLine($"Task added! {Environment.NewLine}");
    }
    else if (choice=="2")
    {
        Console.Clear();
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
        Console.WriteLine($"{Environment.NewLine}");
    }
    else if (choice=="3")
    {
        Console.WriteLine("Enter the task you want to mark as completed:");
        string task = Console.ReadLine();
        if (tasks.Contains(task))
        {
            tasks.Remove(task);
            Console.Clear();
            Console.WriteLine($"Task marked as completed! {Environment.NewLine}");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Task not found! {Environment.NewLine}");
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