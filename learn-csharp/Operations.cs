namespace learn_csharp;

public class Operations
{
    public static void Main()
    {
        int x = 10, y = 5;
        string a = "10", b = "5";

        Console.WriteLine("Basic Math");
        Console.WriteLine((x / y) * x);
        Console.WriteLine(a + b);

        Console.WriteLine("Shorthand");
        x++;
        y--;
        Console.WriteLine(x);
        Console.WriteLine(y);

        a += b;
        Console.WriteLine(a);

        Console.WriteLine("Logic operations");
        Console.WriteLine(x > y && y >= 5);
        Console.WriteLine(x > y || y > 5);

        string str = null;
        Console.WriteLine(str ?? "Unknown value");

        str ??= "New value";
        Console.WriteLine(str);
    }
}
