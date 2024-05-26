namespace learn_csharp.classes;

public class Modifiers
{
    static void Main()
    {
        var b1 = new Book3("War and Peace", "Leo Tolstoy", 825);

        b1._name = "Aldous Huxley";
        Console.WriteLine(b1.GetDescription());

        b1.SetName("Grapes of Wrath");
        b1.SetAuthor("John Steinbeck");
        b1.SetPagecount(464);
        Console.WriteLine(b1.GetDescription());
    }
}
