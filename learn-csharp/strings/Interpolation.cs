namespace learn_csharp.strings;

public class Interpolation
{
    public static void InterpolationMain()
    {
        const string make = "Ford";
        const string model = "Mustang";
        const int year = 1969;
        const float miles = 123456.789f;
        const decimal price = 123456.789m;

        Console.WriteLine("This car is a {0} {1} from {2}. It has {3} miles and costs ${4}", make, model, year, miles, price);
        Console.WriteLine($"This car is a {make} {model} from {year}. It has {miles} miles and costs ${price:C2}");
        Console.WriteLine($"This car is a {year} {make} {{{model}}}, with {miles *1.6:F2} kilometers and costs {price:C2}");
    }
}
