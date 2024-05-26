namespace learn_csharp.conditionals;

public class WhileLoops
{
    public static void WhileLoopsMain()
    {
        var input = "";

        Console.WriteLine("Basic while() loop:");
        while(input != "exit")
        {
            input = Console.ReadLine();
            Console.WriteLine("Input {0}", input);
        }
        Console.WriteLine();

        Console.WriteLine();
        do
        {
            input = Console.ReadLine();
            Console.WriteLine("Input {0}", input);
        } while (input != "exit");

        Console.WriteLine();
    }
}
