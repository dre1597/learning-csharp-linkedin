namespace learn_csharp.classes;

public class Defining
{
    static void MDefiningain(string[] args)
    {
        Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
        Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464);

        Console.WriteLine(b1.GetDescription());
        Console.WriteLine(b2.GetDescription());

    }
}
