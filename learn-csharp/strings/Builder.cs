using System.Text;

namespace learn_csharp.strings;

public class Builder
{
    public static void BuilderMain()
    {
        var sb = new StringBuilder("Initial String. ", 200);
        const int count = 10;
        string[] animals = ["goats", "cats", "dogs"];

        Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

        sb.Append("the quick brown fox ");
        sb.Append("jumps over the lazy dog.");

        sb.AppendLine();

        sb.AppendFormat("He did this {0} times.", count);
        sb.AppendLine();

        sb.Append("He also jumped over");
        sb.AppendJoin(",", animals);

        sb.Replace("fox", "cat");

        sb.Insert(0, "This is the ");

        Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
        Console.WriteLine(sb.ToString());
    }
}
