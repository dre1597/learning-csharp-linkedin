namespace learn_csharp.basic;

public class Variables
{
    private Variables()
    {
    }

    public static void VariablesMain()
    {
        const int i = 10;
        const float f = 3.14f;
        const decimal d = 3.14m;
        const bool b = true;
        const char c = 'a';

        const string s = "Hello, World!";

        const int x = 10;
        const string z = "Hello, World!";

        int[] numbers = [1, 2, 3];
        string [] words = ["Hello", "World"];

        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", i, f, d, b, c, s, x, z, numbers, words);

        object obj = null;
        Console.WriteLine(obj);

        long bignum;
        bignum = i;
        Console.WriteLine("{0}", bignum);

        const float i_to_f = (float)i;
        Console.WriteLine("{0}", i_to_f);

        const int f_to_i = (int)f;
        Console.WriteLine("{0}", f_to_i);
    }
}
