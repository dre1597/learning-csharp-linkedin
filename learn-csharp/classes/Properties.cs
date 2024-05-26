namespace learn_csharp.classes;

public class Properties
{
    static void PropertiesMain()
    {
        var b1 = new Book4("War and Peace", "Leo Tolstoy", 825);

        Console.WriteLine(b1.Name);
        Console.WriteLine(b1.Description);

        b1.ISBN = "100140447938";
        b1.Price = 24.95m;
        Console.WriteLine(b1.ISBN);
        Console.WriteLine(b1.Price);

        b1.Name = "Crime and Punishment";
        b1.Pagecount = 652;
        Console.WriteLine(b1.Description);
        Console.WriteLine(b1.Name);
        Console.WriteLine(b1.Pagecount);
    }
}
