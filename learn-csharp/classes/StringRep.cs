namespace learn_csharp.classes;

public class StringRep
{
    static void StringRepMain()
    {
        var x = 1000;
        Console.WriteLine(x.ToString());

        var a = new object();
        Console.WriteLine(a.ToString());

        var b1 = new Book5("War and Peace", "Leo Tolstoy", 825);
        Console.WriteLine(b1.ToString());
        Console.WriteLine(b1);

        Console.WriteLine(b1.ToString('B'));
        Console.WriteLine(b1.ToString('F'));
    }
}
