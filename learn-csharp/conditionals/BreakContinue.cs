namespace learn_csharp.conditionals;

public class BreakContinue
{
    public static void BreakContinueMain()
    {
        int[] values = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        foreach (var value in values)
        {
            if (value <= 5)
            {
                continue;
            }

            Console.WriteLine(value);


            if (value > 6)
            {
                break;
            }
        }
    }
}
