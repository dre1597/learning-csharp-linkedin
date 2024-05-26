namespace learn_csharp.basic;

public class HelloWorld
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}
