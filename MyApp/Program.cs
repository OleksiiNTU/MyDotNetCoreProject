using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello from main!");
        GreetUser("Student");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}