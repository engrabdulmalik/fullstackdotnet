// using System;
// using System.Collections.Generic;
// public class Program
// {
//     public static List<string> tasks = new List<string>();
//     public static int taskCount = 0;
// // Method to calculate the average of an array
// public static void AddTask()
// {
//     Console.WriteLine("Please enter the task:");
//     string task = Console.ReadLine();
//     tasks.Add(task);
//     taskCount++;

// }
// public static void ListTasks()
// {
//     for (int i = 0; i < taskCount; i++)
//     {
//         Console.WriteLine(i + 1 + ". " + tasks[i]);
//     }
// }

// public static void Main()
// {
//     string choice = "";
//     while (choice != "3")
//     {
//         Console.WriteLine("1. Add a task");
//         Console.WriteLine("2. List tasks");
//         Console.WriteLine("3. Exit");
//         Console.WriteLine("Please enter your choice:");
//         choice = Console.ReadLine();
//         if (choice == "1")
//         {
//             AddTask();
//         }
//         else if (choice == "2")
//         {
//             ListTasks();
//         }
//         else if (choice == "3")
//         {
//             Console.WriteLine("Goodbye!");
//         }
//         else
//         {
//             Console.WriteLine("Invalid choice. Please try again.");
//         }
//     }
// }
// }
public interface IAnimal
{
    void Eat();
}
public class Animal : IAnimal
{
    public virtual void MakeSound(){
        Console.WriteLine("Some sound");
    }
    public void Eat()
    {
        Console.WriteLine("Eating");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof Woof ");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow Meow ");
    }
}

public class Program 
{
    public static void Main()
    {
        // Animal any = new Animal();
        // any.MakeSound();
        // any.Eat();

        // Dog dog = new Dog();
        // dog.MakeSound();
        // dog.Eat();

        // Cat cat = new Cat();
        // cat.MakeSound();
        // cat.Eat();
        List<Animal> animals = new List<Animal>();
        animals.Add(new Dog());
        animals.Add(new Cat());
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.Eat();
        }
    }
}