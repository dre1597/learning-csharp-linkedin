namespace learn_csharp.basic;

public class Variables
{
    private Variables()
    {
    }

    public static void VariablesMain()
    {
        int i = 10;
        float f = 3.14f;
        decimal d = 3.14m;
        bool b = true;
        char c = 'a';

        string s = "Hello, World!";

        var x = 10;
        var z = "Hello, World!";

        int[] numbers = { 1, 2, 3 };
        string [] words = {"Hello", "World"};

        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", i, f, d, b, c, s, x, z);

        object obj = null;
        Console.WriteLine(obj);

        long bignum;
        bignum = i;

        float i_to_f = (float)i;
        Console.WriteLine("{0}", i_to_f);

        float f_to_i = (int)f;
        Console.WriteLine("{0}", f_to_i);
    }
}
