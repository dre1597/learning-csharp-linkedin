namespace learn_csharp.basic;

public class HelloWorld
{
    public static void HelloWorldMain()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}
