using System;
using System.Collections.Generic;
public class Program
{
    public static List<string> tasks = new List<string>();
    public static int taskCount = 0;
// Method to calculate the average of an array
public static void AddTask()
{
    Console.WriteLine("Please enter the task:");
    string task = Console.ReadLine();
    tasks.Add(task);
    taskCount++;

}
public static void ListTasks()
{
    for (int i = 0; i < taskCount; i++)
    {
        Console.WriteLine(i + 1 + ". " + tasks[i]);
    }
}

public static void Main()
{
    string choice = "";
    while (choice != "3")
    {
        Console.WriteLine("1. Add a task");
        Console.WriteLine("2. List tasks");
        Console.WriteLine("3. Exit");
        Console.WriteLine("Please enter your choice:");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            AddTask();
        }
        else if (choice == "2")
        {
            ListTasks();
        }
        else if (choice == "3")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}
}