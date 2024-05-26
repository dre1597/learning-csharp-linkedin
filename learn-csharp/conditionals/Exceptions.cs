namespace learn_csharp.conditionals;

public class Exceptions
{
    public static void ExceptionsMain()
    {
        var x = 100;
        var y = 10;
        int result;

        try
        {
            if (x > 1000)
            {
                throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
            }

            result = x / y;
            Console.WriteLine("THe result is: {0}", result);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Whoops!");
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Whoops!");
            Console.WriteLine("x has to be 1000 or less");
        }
        finally
        {
            Console.WriteLine("This code always executes");

        }
    }
}
