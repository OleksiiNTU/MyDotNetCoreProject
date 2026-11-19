using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello from main!");
        GreetUser("User");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}