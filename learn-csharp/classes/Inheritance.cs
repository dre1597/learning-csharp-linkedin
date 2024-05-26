namespace learn_csharp.classes;

public class Inheritance
{
    static void InheritanceMain(string[] args)
    {
        Book2 b1 = new Book2("War and Peace", "Leo Tolstoy", 825, 39.95m);
        Magazine m1 = new Magazine("Time", "Time USA, LLC", 75, 4.95m);

        Console.WriteLine($"{b1.Name}, {b1.Author}");
        Console.WriteLine($"{m1.Name}, {m1.Publisher}");

        Console.WriteLine(b1.GetDescription());
        Console.WriteLine(b1.Price);
        Console.WriteLine(m1.GetDescription());
        Console.WriteLine(m1.Price);
    }
}
