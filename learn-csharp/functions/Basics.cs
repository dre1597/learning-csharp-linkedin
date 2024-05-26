namespace learn_csharp.functions;

public static class Basics
{
    public static void BasicsMain()
    {
        Console.WriteLine($"The result is {MilesToKm(8.0f)}");
        Console.WriteLine($"The result is {MilesToKm(52.0f)}");

        PrintWithPrefix("Test string");
        PrintWithPrefix("Another test string");
    }

    static float MilesToKm(float miles) {
        float result = miles * 1.6f;
        return result;
    }

    static void PrintWithPrefix(string thestr) {
        Console.WriteLine($"::> {thestr}");
    }

}

