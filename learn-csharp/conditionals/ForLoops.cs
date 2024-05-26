namespace learn_csharp.conditionals;

public class ForLoops
{
    public static void ForLoopsMain()
    {
        const int value = 15;
        var nums = new int [] {3, 14, 15, 92, 64};
        const string str = "Hello, World!";

        Console.WriteLine("The basic for loop:");
        for (var i = 0; i < value; i++) {
            Console.WriteLine("i is currently {0}", i);
        }
        Console.WriteLine();

        Console.WriteLine("The foreach loop:");
        foreach (int i in nums) {
            Console.WriteLine("i is currently {0}", i);
        }

        var count = 0;
        foreach (char c in str) {
            if (c == 'o') {
                count++;
            }
        }
        Console.WriteLine("Counted {0} o characters", count);
    }
}
