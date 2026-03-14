using System;
using System.Collections.Generic;
using System.Text;

// We are gonna make class TaskItem to represent a task in our To-Do list application
namespace ToDoList
{
    public class TaskItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
