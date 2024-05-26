namespace learn_csharp.conditionals;

public class ConditionalIf
{
    public static void ConditionalIfMain()
    {
        var value = 50;

        if (value == 50)
        {
            Console.WriteLine("The value is 50");
        }
        else if (value >= 1 && value <= 60)
        {
            Console.WriteLine("The value is between 1 and 60");
        }
        else
        {
            Console.WriteLine("The value is something else");
        }

        var message = value == 50 ? "The value is 50" : "The value is something else";
        Console.WriteLine(message);
    }
}
