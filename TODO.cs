using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static System.Console;

class TodoItem
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public TodoItem(string description)
    {
        Description = description;
        IsCompleted = false;
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }

    public override string ToString()
    {
        return $"{(IsCompleted ? "[X]" : "[ ]")} {Description}";
    }
}

class TodoList
{
    private List<TodoItem> task = new List<TodoItem>();
    public void AddTask(string description)
    {
        tasks.Add(new TodoItem(description));
        Console.WriteLine($"Задача добавлена: {description}");
    }
    public void DisplayTask()
    {
        if(task.Count == 0)
        {
            WriteLine("Список задач пуст");
            return;
        }
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
        
    }
    
}

class Program
{
    static void Main
    {
        
    }
}
