namespace learn_csharp.conditionals;

public class ConditionalSwitch
{
    public static void ConditionalSwitchMain()
    {
        int value = 50;

        switch (value)
        {
            case 50:
                Console.WriteLine("The value is 50");
                break;
            case 51:
                Console.WriteLine("The value is 51");
                break;
            case 52:
            case 53:
            case 54:
                Console.WriteLine("The value is between 52 and 54");
                break;
            default:
                Console.WriteLine("The value is something else");
                break;
        }
    }
}
