namespace learn_csharp.strings;

public class Formatting
{
    public static void FormattingMain()
    {
        int[] quarters = { 1, 2, 3, 4 };
        int[] sales = { 100000, 150000, 200000, 225000 };
        double[] intlMixPct = { .386, .413, .421, .457 };
        string str = "TestString";
        int value1 = 1234;
        decimal value2 = 1234.5678m;

        Console.WriteLine("{0}", str);
        Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", value1);
        Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", value2);
        Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", value1);
        Console.WriteLine("Sales by Quarter:");
        Console.WriteLine("{0,12} {1,12} {2,12} {3,12}",quarters[0],quarters[1],quarters[2],quarters[3]);
        Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}",sales[0],sales[1],sales[2],sales[3]);
        Console.WriteLine("International Sales:");
        Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}",intlMixPct[0],intlMixPct[1],intlMixPct[2],intlMixPct[3]);
    }
}
