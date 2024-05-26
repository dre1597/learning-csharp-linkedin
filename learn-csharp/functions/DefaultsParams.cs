namespace learn_csharp.functions;

public class DefaultsParams
{
    public static void DefaultsParamsMain()
    {
        PrintWithPrefix("Hello there!");
        PrintWithPrefix("Hello there!", ">: ");

        PrintWithPrefix(prefix: "% ", thestr: "Hello there!");
    }

    static void PrintWithPrefix(string thestr, string prefix="")
    {
        Console.WriteLine($"{prefix} {thestr}");
    }
}
