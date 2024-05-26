namespace learn_csharp.strings;

public class Operations
{
    public static void OperationsMain()
    {
        string outstr;
        var str1 = "The quick brown fox jumps over the lazy dog.";
        var str2 = "This is a string";
        var str3 = "THIS is a STRING";
        string[] strs = ["one", "two", "three", "four"];

        Console.WriteLine(str1.Length);

        Console.WriteLine(str1[14]);

        foreach (var ch in str1)
        {
            Console.WriteLine(ch);

            if (ch != 'b') continue;
            Console.WriteLine();
            break;
        }

        outstr = String.Concat(strs);
        Console.WriteLine(outstr);

        outstr = String.Join(".", strs);
        Console.WriteLine(outstr);
        outstr = String.Join("---", strs);
        Console.WriteLine(outstr);

        int result = String.CompareOrdinal(str2, "This is a string");
        Console.WriteLine("{0}", result);

        bool isEqual = str2.Equals(str3);
        Console.WriteLine("{0}", isEqual);

        Console.WriteLine("{0}", str1.IndexOf('e'));
        Console.WriteLine("{0}", str1.IndexOf("fox"));

        Console.WriteLine("{0}", str1.LastIndexOf('e'));
        Console.WriteLine("{0}", str1.LastIndexOf("the"));

        outstr = str1.Replace("fox", "cat");
        Console.WriteLine("{0}", outstr);
        Console.WriteLine("{0}", outstr.IndexOf("fox"));
    }
}
